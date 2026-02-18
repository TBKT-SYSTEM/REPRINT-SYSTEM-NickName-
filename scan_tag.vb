Imports System.IO.Ports
Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Globalization
Imports System.Web.Script.Serialization
Imports System.ComponentModel
Imports System.Security.Cryptography
Imports System.Windows.Documents

Public Class scan_tag
    Dim back_office As New Model()
    Dim _location, qr_code_tag1, plan_, _actual, production_type, next_process, qr, dot, qr_code_scan_box, qr_scan_tag As String
    Public new_box, id, id_log, quatity, box_tag, box_tag_2, qty_new, status As Integer
    Dim second As String
    Dim ref_id As String
    Dim qrd As String
    Dim PD As String
    '<--------------- form-load ---------------------->
    Dim WithEvents backgroundWorker As New BackgroundWorker()
    Dim loadingForm As New loading
    Private Sub scan_tag_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'check_port()
        qty_pcs.Visible = False
        qr_code_3.Visible = False
        qr_code_2.Visible = False
        qr_code_1.Visible = False
        wi.Visible = False
        key.Visible = False
        box_no.Visible = False
        part_name.Visible = False
        part_no.Visible = False
        pro_seq.Visible = False
        shift.Visible = False
        model.Visible = False
        lot_no.Visible = False
        qty.Visible = False
        line.Visible = False
        actual_date.Visible = False
        plan_date.Visible = False
        PictureBox2.Visible = False
        reprint.Visible = False
        alert.Visible = False
        exit_pagedata.Visible = False
        PictureBox3.Visible = False
        confirm.Visible = False
        button_cancel.Visible = False
        button_confirm.Visible = False
        Label1.Visible = False
        key.Visible = False
        panel_number.Visible = False
        ok_button.Visible = False
        back_button.Visible = False
        number_input.Visible = False
        Label2.Visible = False
        Label3.Visible = False
        menu_key_number.Visible = False
        qr_code.Text() = ""
        qr_code.Focus()
    End Sub
    Private Sub backgroundWorker_DoWork(sender As Object, e As DoWorkEventArgs) Handles backgroundWorker.DoWork
        ' Simulate a time-consuming operation
        System.Threading.Thread.Sleep(5000)
        ' If you need to report progress or send results back, you can do so here
        ' backgroundWorker.ReportProgress(percentage)
        ' e.Result = someResult
    End Sub

    Private Sub backgroundWorker_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles backgroundWorker.RunWorkerCompleted
        ' Hide the loading form when the background operation is complete
        loadingForm.Close()
        'asdasd
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        'Dim loadpage As New menu_form
        'loadpage.Show()
        menu_form.Show()
        Me.Hide()
    End Sub

    Private Async Sub qr_code_KeyDown(sender As Object, e As KeyEventArgs) Handles qr_code.KeyDown
        Dim last3 As String = ""
        Dim model_ As New Model()
        If e.KeyCode <> Keys.Enter Then Exit Sub

        qr_code_scan_box = qr_code.Text.Trim()
        If qr_code_scan_box.Length < 103 Then
            ShowAlert("alert_not_have_tag.png")
            Exit Sub
        End If

        If check_type() = 2 Then
            ShowAlert("alert_M083.png")
            Exit Sub
        End If

        'If check_duplicate(qr_code_scan_box) = True Then
        '    MessageBox.Show("TAG นี้ถูกพิมพ์ไปแล้ว")
        '    Exit Sub
        'End If

        'Return

        last3 = qr_code_scan_box.Substring(qr_code_scan_box.Length - 3)

        Try
            Dim rs2 As String = model_.get_data_tag_log(qr_code_scan_box)

            If rs2 = "0" Then

                HandleNewTag()
            Else
                Dim result_data_json As List(Of Object) = New JavaScriptSerializer().Deserialize(Of List(Of Object))(rs2)
                Dim item = result_data_json(0)

                id_log = item("log_id").ToString()
                'MsgBox("id_logkey =>" & id_log)
                ref_id = item("log_ref_id").ToString()
                status = item("log_status").ToString()

                If status = "2" Then
                    ShowReprintAlert(id_log)
                    Exit Sub
                End If

                If last3 >= 800 Then
                    Await loadingForm.load()
                End If

                PictureBox1.Visible = False
                logreprint_app()
                get_data()
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            qr_code.Text = ""
        End Try
    End Sub

    Private Sub ShowAlert(imageName As String)
        qr_code.Text = ""
        PictureBox3.Image = Api.DownloadImage($"http://192.168.161.102/reprint_app/images/alert/{imageName}")
        PictureBox3.Visible = True
        PictureBox3.BackColor = Color.Transparent
    End Sub

    Private Sub ShowReprintAlert(id As String)
        Label3.Text = "(ID: " & id & " : REPRINT)"
        Label2.Text = Label3.Text
        Label2.Visible = True
        Label3.Visible = True
        alert.Visible = True
        alert.BringToFront()
        Label2.BringToFront()
        Label3.BringToFront()
        qr_code.Text = ""
    End Sub

    'After scan tag -----------------------------------------------------------------------------------------------------

    Private Sub HandleNewTag()
        'MsgBox("HandleNewTag")

        If check_status() = "2" Then
            ShowReprintAlert(id)
            Exit Sub
        ElseIf check_id() = "0" Then
            ShowAlert("alert_not_have_tag.png")
            Exit Sub
        End If

        Dim Model_reprint As New Model()
        Dim rs3 As String = Model_reprint.GET_DATA_TAG(qr_code_scan_box)

        If Not String.IsNullOrEmpty(rs3) AndAlso (rs3.Trim.StartsWith("[") OrElse rs3.Trim.StartsWith("{")) Then
            Dim result_data_json As List(Of Object) = New JavaScriptSerializer().Deserialize(Of List(Of Object))(rs3)
            If result_data_json.Count > 0 Then
                Dim item As Dictionary(Of String, Object) = CType(result_data_json(0), Dictionary(Of String, Object))

                id = item("id").ToString()
                wi.Text = item("wi").ToString()
                box_no.Text = item("box_no").ToString()
                shift.Text = item("shift").ToString()
                pro_seq.Text = item("seq_no").ToString()
                Dim qr_detail As String = item("qr_detail").ToString()
                qr = qr_detail
                actual_date.Text = item("updated_date").ToString()
                Dim plan As String = qr_detail.Substring(8, 8)
                plan_ = plan
                Dim actual As String = qr_detail.Substring(44, 8)
                _actual = actual
                Dim act As Date = Date.ParseExact(_actual, "yyyyMMdd", Globalization.CultureInfo.InvariantCulture)
                Dim da As Date = Date.ParseExact(plan_, "yyyyMMdd", Globalization.CultureInfo.InvariantCulture)
                Dim lot As String = qr_detail.Substring(44, 18)
                lot_no.Text = lot.Substring(lot.Length - 4)
                Dim qt_y As String = lot.Substring(Trim(lot.Length - 8))
                Dim tim As String = qt_y.Remove(qt_y.Length - 4)
                qty.Text = Trim(tim)
                quatity = Trim(tim)
                plan_date.Text = da.ToString("dd/MM/yyyy")
                actual_date.Text = act.ToString("dd/MM/yyyy")
                next_process = item("next_proc").ToString()

            End If
        End If
        get_data()
        PictureBox1.Visible = False

    End Sub

    Public Sub logreprint_app()
        Dim model As New Model()
        Dim rs2 As String = model.get_data_tag_log(Trim(qr_code.Text))

        If String.IsNullOrWhiteSpace(rs2) OrElse rs2 = "0" Then
            MsgBox("No data found.")
            Exit Sub
        End If

        Dim result As List(Of Object) =
        New JavaScriptSerializer().Deserialize(Of List(Of Object))(rs2)

        For Each item As Dictionary(Of String, Object) In result
            Dim qr_detail As String = CStr(item("log_qr_detail"))

            If String.IsNullOrEmpty(qr_detail) OrElse qr_detail.Length < 62 Then
                MsgBox("QR detail is invalid.")
                Continue For
            End If

            Dim plan As String = qr_detail.Substring(8, 8)      ' yyyyMMdd
            Dim actual As String = qr_detail.Substring(44, 8)   ' yyyyMMdd

            Dim da As Date = Date.ParseExact(plan, "yyyyMMdd", Globalization.CultureInfo.InvariantCulture)
            Dim act As Date = Date.ParseExact(actual, "yyyyMMdd", Globalization.CultureInfo.InvariantCulture)

            Dim lot As String = qr_detail.Substring(44, 18)
            Dim qt_y As String = lot.Substring(lot.Length - 8)
            Dim tim As String = qt_y.Remove(qt_y.Length - 4)

            box_no.Text = CStr(item("log_new_box_no"))
            qr = qr_detail
            next_process = CStr(item("log_new_next_proc"))

            plan_ = plan
            _actual = actual
            lot_no.Text = lot.Substring(lot.Length - 4)
            qty.Text = tim.Trim()
            quatity = tim.Trim()
            plan_date.Text = da.ToString("dd/MM/yyyy")
            actual_date.Text = act.ToString("dd/MM/yyyy")

            get_data_tag_inserttwo()
        Next
    End Sub


    Public Sub get_data_tag_inserttwo()
        Try
            Dim modelReprint As New Model()
            Dim qrCodeCheck As String = qr.Substring(0, 52)
            Dim minCurBox As Integer = back_office.get_log_ref_id(qrCodeCheck)
            Dim minLogId As Integer = back_office.get_log_ref_id_1(qrCodeCheck, minCurBox)
            Dim logRefId As Integer = back_office.get_log_ref_id_2(minLogId)

            ' Determine the prefix and fetch data accordingly
            Dim refPrefix As String = qr.Substring(2, 3)
            Dim rs As String

            If refPrefix = "K1P" Then
                rs = modelReprint.get_data_all_packing(qr)
            Else
                rs = modelReprint.get_data_all(logRefId)
            End If

            ' Deserialize and process the data
            Dim resultData As List(Of Object) = New JavaScriptSerializer().Deserialize(Of List(Of Object))(rs)

            For Each item As Object In resultData
                Try
                    ' Populate the UI elements with data
                    wi.Text = item("wi").ToString()
                    shift.Text = item("shift").ToString()
                    pro_seq.Text = item("seq_no").ToString()
                Catch ex As Exception
                    ' Handle errors for individual item processing
                    Console.WriteLine($"Error processing item: {ex.Message}")
                End Try
            Next
        Catch ex As Exception
            ' Handle errors for the entire method
            Console.WriteLine($"Error in GetDataTagInsertTwo: {ex.Message}")
        End Try
    End Sub

    Public Sub get_data()
        Dim Model_reprint As New Model()

        Dim rs = Model_reprint.GET_DATA_TAG_2(wi.Text)

        If rs <> "0" Then
            Dim result_data_json As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(rs)
            For Each item As Object In result_data_json
                ' ตรวจสอบว่าค่ามีอยู่หรือไม่ก่อนเข้าถึง
                model.Text = If(item.ContainsKey("MODEL") AndAlso item("MODEL") IsNot Nothing, item("MODEL").ToString(), "")
                part_name.Text = If(item.ContainsKey("ITEM_NAME") AndAlso item("ITEM_NAME") IsNot Nothing, item("ITEM_NAME").ToString(), "")
                line.Text = If(item.ContainsKey("LINE_CD") AndAlso item("LINE_CD") IsNot Nothing, item("LINE_CD").ToString(), "")
                part_no.Text = If(item.ContainsKey("ITEM_CD") AndAlso item("ITEM_CD") IsNot Nothing, item("ITEM_CD").ToString(), "")
                PD = If(item.ContainsKey("PD") AndAlso item("PD") IsNot Nothing, item("PD").ToString(), "")
                _location = If(item.ContainsKey("LOCATION_PART") AndAlso item("LOCATION_PART") IsNot Nothing, item("LOCATION_PART").ToString(), "")
            Next
        End If

        qty_pcs.Text = (quatity & " " & "Pcs.")
        qty_pcs.Visible = True
        wi.Visible = True
        box_no.Visible = True
        part_name.Visible = True
        part_no.Visible = True
        pro_seq.Visible = True
        shift.Visible = True
        model.Visible = True
        lot_no.Visible = True
        qty.Visible = True
        line.Visible = True
        actual_date.Visible = True
        plan_date.Visible = True
        PictureBox2.Visible = True
        exit_pagedata.Visible = True
        menu_key_number.Visible = True
        qty.Focus()
        loadingForm.Close()
    End Sub


    Private Sub qty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles qty.KeyPress
        Dim ch As Char = e.KeyChar
        If Not Char.IsDigit(ch) AndAlso Asc(ch) <> 8 Then
            e.Handled = True
        End If
        reprint.Visible = True

    End Sub
    '<------------------ make qr-code ----------------------->

    Private Sub make_qr()
        Dim qr_code As String = qr.Substring(0, 52)
        Dim qq As Integer = qty.Text
        Dim qr_code_ As String = qr.Substring(87, 13)
        If qq < 10 Then
            dot = (qr_code & "     " & qq & lot_no.Text & "                         " & qr_code_)
        ElseIf qq < 100 Then
            dot = (qr_code & "    " & qq & lot_no.Text & "                         " & qr_code_)
        ElseIf qq < 1000 Then
            dot = (qr_code & "   " & qq & lot_no.Text & "                         " & qr_code_)
        ElseIf qq > 1000 Then
            dot = (qr_code & "  " & qq & lot_no.Text & "                         " & qr_code_)
        End If

    End Sub

    '<------------------ exit page data ----------------------->
    Private Sub exit_pagedata_Click(sender As Object, e As EventArgs) Handles exit_pagedata.Click
        qr_code.Text = ""
        qty.Text = ""
        qty_pcs.Visible = False
        key.Visible = False
        panel_number.Visible = False
        ok_button.Visible = False
        Label1.Visible = False
        back_button.Visible = False
        number_input.Visible = False
        wi.Visible = False
        box_no.Visible = False
        part_name.Visible = False
        part_no.Visible = False
        pro_seq.Visible = False
        shift.Visible = False
        model.Visible = False
        lot_no.Visible = False
        qty.Visible = False
        line.Visible = False
        actual_date.Visible = False
        plan_date.Visible = False
        PictureBox2.Visible = False
        reprint.Visible = False
        menu_key_number.Visible = False
        PictureBox1.Visible = True
        exit_pagedata.Visible = False
        id_log = 0
        id = 0
    End Sub

    Private Sub reprint_Click(sender As Object, e As EventArgs) Handles reprint.Click
        Try
            If qty.Text = "" Then
                PictureBox3.Image = Api.DownloadImage("http://192.168.161.102/reprint_app/images/alert/alert_blanks.png")
                PictureBox3.Visible = True
                alert.BringToFront()
                qty.Focus()
                PictureBox3.Focus()
                Exit Sub
            ElseIf qty.Text = 0 Then
                PictureBox3.Image = Api.DownloadImage("http://192.168.161.102/reprint_app/images/alert/alert_blanks.png")
                PictureBox3.Visible = True
                PictureBox3.SizeMode = PictureBoxSizeMode.AutoSize
                alert.BringToFront()
                qty.Focus()
                PictureBox3.Focus()
                Exit Sub
            ElseIf qty.Text >= quatity Then
                PictureBox3.Image = Api.DownloadImage("http://192.168.161.102/reprint_app/images/alert/alert_qty_error.png")
                PictureBox3.Visible = True
                alert.BringToFront()
                qty.Focus()
                PictureBox3.Focus()
                Exit Sub
            ElseIf quatity = 1 Then
                PictureBox3.Image = Api.DownloadImage("http://192.168.161.102/reprint_app/images/alert/alert_qty_1.png")
                PictureBox3.Visible = True
                alert.BringToFront()
                qty.Focus()
                PictureBox3.Focus()
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox("error!!!!")
            qty.Text = Nothing
            qty.Focus()
            Exit Sub
        End Try
        confirm.Visible = True
        button_cancel.Visible = True
        button_confirm.Visible = True
        button_confirm.Focus()
    End Sub
    '<------------------ run reprint ----------------------->
    Public Sub run_reprint()
        Dim model_re As New Model
        Dim conn = New connect()
        Dim Nbox_no = 800
        Dim nbox_no_s = 801
        Dim userID = login_form.Str
        Dim check As Integer = 0
        Dim new_qty
        Dim qty_tag As Integer = qty.Text

        new_qty = quatity - qty.Text()
        qty_new = new_qty
        Dim connect = conn.connect_reprint_newfa()
        'MsgBox("im here")
        make_qr()
        If id_log = 0 Then

            '<----------------- qr first ------------------>
            qr_scan_tag = dot
            'MsgBox("qr :" & qr_scan_tag)
            Dim box_number_max = back_office.get_box_first_scan(Trim(qr_scan_tag))
            If box_number_max <> 0 Then
                Nbox_no = box_number_max + 1
                nbox_no_s = Nbox_no + 1
            End If
            'MsgBox("Nbox_no =>", Nbox_no)

            Dim Firstbox As String = (dot & Nbox_no)
            qr_code_tag1 = Firstbox
            box_tag = Nbox_no
            box_tag_2 = nbox_no_s
            Dim strCommand_insert1 = "INSERT INTO log_reprint_app (id_menu,log_ref_db,log_ref_id,log_cur_qty,log_new_qty,log_cur_box_no,log_new_box_no,log_cur_next_proc,log_new_next_proc,log_qr_detail,log_status,log_created_date,log_created_by,log_updated_date,log_updated_by )VALUES (1,2," & id & "," & quatity & "," & qty_tag & "," & box_no.Text & "," & Nbox_no & ",'" & next_process & "','" & next_process & "','" & Firstbox & "',1,CURRENT_TIMESTAMP,'" & userID.ToUpper() & "',CURRENT_TIMESTAMP,'" & userID.ToUpper() & "')"
            Dim command_1 As SqlCommand = New SqlCommand(strCommand_insert1, connect)
            Dim reader_1 = command_1.ExecuteNonQuery()
            Dim qr_code As String = qr.Substring(0, 52)
            Dim qr_code_ As String = qr.Substring(87, 13)
            '<----------------- qr second ------------------>
            If new_qty.ToString.Length = 1 Then
                second = (qr_code & "     " & new_qty & lot_no.Text & "                         " & qr_code_ & nbox_no_s)
            ElseIf new_qty.ToString.Length = 2 Then
                second = (qr_code & "    " & new_qty & lot_no.Text & "                         " & qr_code_ & nbox_no_s)
            ElseIf new_qty.ToString.Length = 3 Then
                second = (qr_code & "   " & new_qty & lot_no.Text & "                         " & qr_code_ & nbox_no_s)
            ElseIf new_qty.ToString.Length = 4 Then
                second = (qr_code & "  " & new_qty & lot_no.Text & "                         " & qr_code_ & nbox_no_s)
            End If

            Dim strCommand_insert2 = "INSERT INTO log_reprint_app (id_menu,log_ref_db,log_ref_id,log_cur_qty,log_new_qty,log_cur_box_no,log_new_box_no,log_cur_next_proc,log_new_next_proc,log_qr_detail,log_status,log_created_date,log_created_by,log_updated_date,log_updated_by )VALUES (1,2," & id & "," & quatity & "," & new_qty & "," & box_no.Text & "," & nbox_no_s & ",'" & next_process & "','" & next_process & "','" & second & "',1,CURRENT_TIMESTAMP,'" & userID.ToUpper() & "',CURRENT_TIMESTAMP,'" & userID.ToUpper() & "')"
            Dim command_2 As SqlCommand = New SqlCommand(strCommand_insert2, connect)
            Dim reader_2 = command_2.ExecuteNonQuery()
            check = 1
            model_re.update_status_tag_print_detail(id)
        Else
            Try
                'MsgBox("ref_id =>", ref_id)
                Dim box_plus As Integer = model_re.get_max_boxno(id_log)
                'MsgBox("box_plus =>" & box_plus)
                Dim newbox = box_plus + 1
                Dim newbox_2 = newbox + 1
                'MsgBox(newbox & "  " & newbox_2)
                qr_scan_tag = dot
                Dim subPF As String = qr_scan_tag.Substring(2, 3)
                Dim id_ref_program As String = ""
                If subPF = "K1P" Then
                    id_ref_program = ref_id
                Else
                    id_ref_program = id_log
                End If
                'MsgBox("qr :" & qr_scan_tag)
                Dim box_number_max = back_office.get_box_first_scan(Trim(qr_scan_tag))
                'MsgBox("max :" & box_number_max)
                If box_number_max <> 0 Then
                    newbox = box_number_max + 1
                    newbox_2 = newbox + 1
                End If
                box_tag_2 = newbox_2
                box_tag = newbox
                Dim num_char_box2 As Integer = newbox_2.ToString().Length
                Dim num_char_box1 As Integer = newbox.ToString().Length
                Dim boxString2 As String = ""
                Dim boxString As String = ""
                If num_char_box2 = 1 Then
                    boxString2 = "00" & newbox_2
                ElseIf num_char_box2 = 2 Then
                    boxString2 = "0" & newbox_2
                Else
                    boxString2 = newbox_2
                End If


                If num_char_box1 = 1 Then
                    boxString = "00" & newbox
                ElseIf num_char_box1 = 2 Then
                    boxString = "0" & newbox
                Else
                    boxString = newbox
                End If
                '<----------------- qr first ------------------>
                Dim Firstbox As String = (dot & boxString)
                qr_code_tag1 = Firstbox
                Dim strCommand_insert1 = "INSERT INTO log_reprint_app (id_menu,log_ref_db,log_ref_id,log_cur_qty,log_new_qty,log_cur_box_no,log_new_box_no,log_cur_next_proc,log_new_next_proc,log_qr_detail,log_status,log_created_date,log_created_by,log_updated_date,log_updated_by )VALUES (1,1," & id_ref_program & "," & quatity & "," & qty_tag & "," & box_no.Text & "," & newbox & ",'" & next_process & "','" & next_process & "','" & Firstbox & "',1,CURRENT_TIMESTAMP,'" & userID.ToUpper() & "',CURRENT_TIMESTAMP,'" & userID.ToUpper() & "')"
                Dim command_1 As SqlCommand = New SqlCommand(strCommand_insert1, connect)
                Dim reader_1 = command_1.ExecuteNonQuery()
                Dim qr_code As String = qr.Substring(0, 52)
                Dim qr_code_ As String = qr.Substring(87, 13)
                '<----------------- qr second ------------------>
                If new_qty.ToString.Length = 1 Then
                    second = (qr_code & "     " & new_qty & lot_no.Text & "                         " & qr_code_ & boxString2)
                ElseIf new_qty.ToString.Length = 2 Then
                    second = (qr_code & "    " & new_qty & lot_no.Text & "                         " & qr_code_ & boxString2)
                ElseIf new_qty.ToString.Length = 3 Then
                    second = (qr_code & "   " & new_qty & lot_no.Text & "                         " & qr_code_ & boxString2)
                ElseIf new_qty.ToString.Length = 4 Then
                    second = (qr_code & "  " & new_qty & lot_no.Text & "                         " & qr_code_ & boxString2)
                End If
                Dim strCommand_insert2 = "INSERT INTO log_reprint_app (id_menu,log_ref_db,log_ref_id,log_cur_qty,log_new_qty,log_cur_box_no,log_new_box_no,log_cur_next_proc,log_new_next_proc,log_qr_detail,log_status,log_created_date,log_created_by,log_updated_date,log_updated_by )VALUES (1,1," & id_ref_program & "," & quatity & "," & new_qty & "," & box_no.Text & "," & newbox_2 & ",'" & next_process & "','" & next_process & "','" & second & "',1,CURRENT_TIMESTAMP,'" & userID.ToUpper() & "',CURRENT_TIMESTAMP,'" & userID.ToUpper() & "')"
                Dim command_2 As SqlCommand = New SqlCommand(strCommand_insert2, connect)
                Dim reader_2 = command_2.ExecuteNonQuery()
                model_re.update_status(id_ref_program)
                check = 1

            Catch ex As Exception
                MsgBox("An error occurred: " & ex.Message)
            End Try

        End If
        If check = 1 Then

        End If
        id = 0
        id_log = 0
    End Sub
    Private Sub PictureBox3_Click_1(sender As Object, e As EventArgs) Handles PictureBox3.Click
        PictureBox3.Visible = False
        qr_code.Text = Nothing
        Trim(qr_code.Text)
        qty.Text = Nothing
    End Sub
    Private Sub alert_click(sender As Object, e As EventArgs) Handles alert.Click
        qr_code.Text = ""
        Trim(qr_code.Text)
        Label2.Visible = False
        Label3.Visible = False
        alert.Visible = False
        id_log = 0
        id = 0
        status = 0
        loadingForm.Close()
    End Sub
    '<------------------ confirm --------------------->
    Private Sub button_confirm_Click(sender As Object, e As EventArgs) Handles button_confirm.Click
        PictureBox2.Visible = False
        wi.Visible = False
        qty_pcs.Visible = False
        box_no.Visible = False
        part_name.Visible = False
        part_no.Visible = False
        pro_seq.Visible = False
        shift.Visible = False
        model.Visible = False
        lot_no.Visible = False
        qty.Visible = False
        line.Visible = False
        actual_date.Visible = False
        plan_date.Visible = False
        reprint.Visible = False
        exit_pagedata.Visible = False
        menu_key_number.Visible = False
        run_reprint()
        confirm.Visible = False
        button_confirm.Visible = False
        button_cancel.Visible = False
        Dim part_name_over As String
        Dim part_name_digit_over As String
        If part_name.Text.Length > 33 Then
            font_part_name.Font = New Font("Consolas", 16, FontStyle.Bold)
            part_name_over = part_name.Text.Substring(0, 32)
            part_name_digit_over = (part_name_over + "...")
            part_name.Text = part_name_digit_over
        ElseIf part_name.Text.Length > 25 Then
            font_part_name.Font = New Font("Consolas", 18, FontStyle.Bold)
        End If
        'PrintPreviewDialog1.ShowDialog()
        'PrintPreviewDialog2.ShowDialog()
        PrintDocument1.Print()
        PrintDocument2.Print()
    End Sub

    Private Sub button_cancel_Click(sender As Object, e As EventArgs) Handles button_cancel.Click
        confirm.Visible = False
        button_confirm.Visible = False
        button_cancel.Visible = False
    End Sub
    '<------------------ print1 ----------------------->
    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim aPen = New Pen(Color.Black)
        aPen.Width = 2.0F
        'MsgBox(Label10.Text)
        'vertical
        e.Graphics.DrawLine(aPen, 150, 10, 150, 290)
        e.Graphics.DrawLine(aPen, 300, 175, 300, 290)
        e.Graphics.DrawLine(aPen, 590, 10, 590, 175)
        e.Graphics.DrawLine(aPen, 410, 120, 410, 235)
        e.Graphics.DrawLine(aPen, 410, 175, 410, 235)
        e.Graphics.DrawLine(aPen, 225, 175, 225, 235)
        e.Graphics.DrawLine(aPen, 490, 10, 490, 65)
        e.Graphics.DrawLine(aPen, 520, 175, 520, 290)
        e.Graphics.DrawLine(aPen, 610, 175, 610, 290)
        e.Graphics.DrawLine(aPen, 700, 10, 700, 290)
        'Horizontal
        e.Graphics.DrawLine(aPen, 150, 11, 700, 11)
        e.Graphics.DrawLine(aPen, 150, 65, 590, 65)
        e.Graphics.DrawLine(aPen, 150, 120, 700, 120)
        e.Graphics.DrawLine(aPen, 150, 175, 700, 175)
        e.Graphics.DrawLine(aPen, 150, 235, 610, 235)
        e.Graphics.DrawLine(aPen, 150, 289, 700, 289)
        'TAG LAYOUT
        e.Graphics.DrawString("PART NO.", lb_font1.Font, Brushes.Black, 152, 13)
        e.Graphics.DrawString(part_no.Text, lb_font2.Font, Brushes.Black, 152, 25)
        e.Graphics.DrawString("QTY.", lb_font1.Font, Brushes.Black, 492, 13)
        Dim qty_tag As Integer = qty.Text
        e.Graphics.DrawString(qty_tag, lb_font2.Font, Brushes.Black, 505, 25)
        e.Graphics.DrawString("PART NAME", lb_font1.Font, Brushes.Black, 152, 67)

        e.Graphics.DrawString(part_name.Text, font_part_name.Font, Brushes.Black, 152, 79)
        e.Graphics.DrawString("MODEL", lb_font1.Font, Brushes.Black, 152, 123)
        e.Graphics.DrawString(model.Text, lb_font5.Font, Brushes.Black, 152, 141)
        e.Graphics.DrawString("NEXT PROCESS", lb_font1.Font, Brushes.Black, 412, 123)
        e.Graphics.DrawString(next_process, lb_font5.Font, Brushes.Black, 414, 141)

        e.Graphics.DrawString("LOCATION", lb_font1.Font, Brushes.Black, 592, 123)
        e.Graphics.DrawString(_location, lb_font5.Font, Brushes.Black, 596, 141)
        e.Graphics.DrawString("SHIFT", lb_font1.Font, Brushes.Black, 152, 178)
        e.Graphics.DrawString(shift.Text, lb_font2.Font, Brushes.Black, 170, 190)
        e.Graphics.DrawString("PRO. SEQ.", lb_font1.Font, Brushes.Black, 227, 178)
        e.Graphics.DrawString(pro_seq.Text, lb_font2.Font, Brushes.Black, 231, 190)
        e.Graphics.DrawString("BOX NO.", lb_font1.Font, Brushes.Black, 302, 178)
        e.Graphics.DrawString(box_tag, lb_font2.Font, Brushes.Black, 320, 190)
        e.Graphics.DrawString("ACTUAL DATE", lb_font1.Font, Brushes.Black, 412, 178)
        Dim actaul_data_time As String
        Dim act As Date = Date.ParseExact(_actual, "yyyyMMdd", Globalization.CultureInfo.InvariantCulture)
        'lb_dlv_date.Text = da.ToString("dd/MM/yyyy")
        actaul_data_time = act.ToString("dd/MM/yyyy")

        e.Graphics.DrawString(actaul_data_time, lb_font3.Font, Brushes.Black, 412, 196)

        Dim factory_cd As String
        If PD = "K2PD06" Then
            factory_cd = "Phase8"

        Else
            factory_cd = "Phase10"

        End If
        e.Graphics.DrawString("FACTORY", lb_font1.Font, Brushes.Black, 522, 178)
        e.Graphics.DrawString(factory_cd, lb_font3.Font, Brushes.Black, 522, 196)
        e.Graphics.DrawString("INFO.", lb_font1.Font, Brushes.Black, 612, 178)
        ''e.Graphics.DrawString(Label14.Text, lb_font2.Font, Brushes.Black, 626, 190)
        e.Graphics.DrawString("LINE", lb_font1.Font, Brushes.Black, 152, 238)
        e.Graphics.DrawString(line.Text, lb_font2.Font, Brushes.Black, 152, 250)
        Dim result_plan_date As String = ""

        Dim da As Date = Date.ParseExact(plan_, "yyyyMMdd", Globalization.CultureInfo.InvariantCulture)
        'lb_dlv_date.Text = da.ToString("dd/MM/yyyy")
        result_plan_date = da.ToString("dd/MM/yyyy")

        e.Graphics.DrawString("PLAN DATE", lb_font1.Font, Brushes.Black, 302, 238)
        e.Graphics.DrawString(result_plan_date, plandate.Font, Brushes.Black, 334, 255)
        e.Graphics.DrawString("LOT NO.", lb_font1.Font, Brushes.Black, 522, 238)
        e.Graphics.DrawString(lot_no.Text, lb_font2.Font, Brushes.Black, 522, 250)
        ''e.Graphics.DrawString("PROD. SEQ.", lb_font1.Font, Brushes.Black, 612, 238)
        ''e.Graphics.DrawString(plan_seq, lb_font2.Font, Brushes.Black, 622, 250)
        e.Graphics.DrawString("TBKK", lb_font2.Font, Brushes.Black, 15, 13)
        e.Graphics.DrawString("(Thailand) Co., Ltd.", lb_font1.Font, Brushes.Black, 15, 45)
        e.Graphics.DrawString("Shop floor system", lb_font4.Font, Brushes.Black, 15, 73)
        e.Graphics.DrawString("(New FA system)", lb_font4.Font, Brushes.Black, 15, 85)
        e.Graphics.DrawString("WI : " & wi.Text, lb_font6.Font, Brushes.Black, 15, 123)
        production_type = back_office.product_type(wi.Text)
        e.Graphics.DrawString(production_type, lb_font6.Font, Brushes.Black, 15, 136)

        Dim generate As New MessagingToolkit.QRCode.Codec.QRCodeEncoder

        qr_code_1.Image = generate.Encode(qr_code_tag1)
        e.Graphics.DrawImage(qr_code_1.Image, 597, 17, 95, 95)
        e.Graphics.DrawImage(qr_code_1.Image, 31, 190, 95, 95)
        qr_code_2.Image = generate.Encode(qr_code_tag1)
        e.Graphics.DrawImage(qr_code_2.Image, 620, 199, 70, 70)

    End Sub

    Private Sub del_Click(sender As Object, e As EventArgs) Handles del.Click
        Dim a = number_input.Text.Length
        If number_input.Text = "" Then
            number_input.Text = ""
        Else
            number_input.Text = number_input.Text.Remove(a - 1)
        End If
    End Sub
    Private Sub clear_Click(sender As Object, e As EventArgs) Handles clear.Click
        number_input.Text = ""
    End Sub
    '<------------------ print2 ----------------------->
    Private Sub PrintDocument2_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument2.PrintPage
        Dim aPen = New Pen(Color.Black)
        aPen.Width = 2.0F
        'MsgBox(Label10.Text)
        'vertical
        e.Graphics.DrawLine(aPen, 150, 10, 150, 290)
        e.Graphics.DrawLine(aPen, 300, 175, 300, 290)
        e.Graphics.DrawLine(aPen, 590, 10, 590, 175)
        e.Graphics.DrawLine(aPen, 410, 120, 410, 235)
        e.Graphics.DrawLine(aPen, 410, 175, 410, 235)
        e.Graphics.DrawLine(aPen, 225, 175, 225, 235)
        e.Graphics.DrawLine(aPen, 490, 10, 490, 65)
        e.Graphics.DrawLine(aPen, 520, 175, 520, 290)
        e.Graphics.DrawLine(aPen, 610, 175, 610, 290)
        e.Graphics.DrawLine(aPen, 700, 10, 700, 290)
        'Horizontal
        e.Graphics.DrawLine(aPen, 150, 11, 700, 11)
        e.Graphics.DrawLine(aPen, 150, 65, 590, 65)
        e.Graphics.DrawLine(aPen, 150, 120, 700, 120)
        e.Graphics.DrawLine(aPen, 150, 175, 700, 175)
        e.Graphics.DrawLine(aPen, 150, 235, 610, 235)
        e.Graphics.DrawLine(aPen, 150, 289, 700, 289)
        'TAG LAYOUT
        e.Graphics.DrawString("PART NO.", lb_font1.Font, Brushes.Black, 152, 13)
        e.Graphics.DrawString(part_no.Text, lb_font2.Font, Brushes.Black, 152, 25)
        e.Graphics.DrawString("QTY.", lb_font1.Font, Brushes.Black, 492, 13)

        e.Graphics.DrawString(qty_new, lb_font2.Font, Brushes.Black, 505, 25)
        e.Graphics.DrawString("PART NAME", lb_font1.Font, Brushes.Black, 152, 67)
        e.Graphics.DrawString(part_name.Text, font_part_name.Font, Brushes.Black, 152, 79)
        e.Graphics.DrawString("MODEL", lb_font1.Font, Brushes.Black, 152, 123)
        e.Graphics.DrawString(model.Text, lb_font5.Font, Brushes.Black, 152, 141)
        e.Graphics.DrawString("NEXT PROCESS", lb_font1.Font, Brushes.Black, 412, 123)
        e.Graphics.DrawString(next_process, lb_font5.Font, Brushes.Black, 414, 141)

        e.Graphics.DrawString("LOCATION", lb_font1.Font, Brushes.Black, 592, 123)
        e.Graphics.DrawString(_location, lb_font5.Font, Brushes.Black, 596, 141)
        e.Graphics.DrawString("SHIFT", lb_font1.Font, Brushes.Black, 152, 178)
        e.Graphics.DrawString(shift.Text, lb_font2.Font, Brushes.Black, 170, 190)
        e.Graphics.DrawString("PRO. SEQ.", lb_font1.Font, Brushes.Black, 227, 178)
        e.Graphics.DrawString(pro_seq.Text, lb_font2.Font, Brushes.Black, 231, 190)
        e.Graphics.DrawString("BOX NO.", lb_font1.Font, Brushes.Black, 302, 178)
        e.Graphics.DrawString(box_tag_2, lb_font2.Font, Brushes.Black, 320, 190)
        e.Graphics.DrawString("ACTUAL DATE", lb_font1.Font, Brushes.Black, 412, 178)
        Dim actaul_data_time As String
        Dim act As Date = Date.ParseExact(_actual, "yyyyMMdd", Globalization.CultureInfo.InvariantCulture)
        'lb_dlv_date.Text = da.ToString("dd/MM/yyyy")
        actaul_data_time = act.ToString("dd/MM/yyyy")

        e.Graphics.DrawString(actaul_data_time, lb_font3.Font, Brushes.Black, 412, 196)
        ' Dim plan_cd As String

        Dim factory_cd As String
        If PD = "K2PD06" Then
            factory_cd = "Phase8"

        Else
            factory_cd = "Phase10"

        End If
        e.Graphics.DrawString("FACTORY", lb_font1.Font, Brushes.Black, 522, 178)
        e.Graphics.DrawString(factory_cd, lb_font3.Font, Brushes.Black, 522, 196)
        e.Graphics.DrawString("INFO.", lb_font1.Font, Brushes.Black, 612, 178)
        ''e.Graphics.DrawString(Label14.Text, lb_font2.Font, Brushes.Black, 626, 190)
        e.Graphics.DrawString("LINE", lb_font1.Font, Brushes.Black, 152, 238)
        e.Graphics.DrawString(line.Text, lb_font2.Font, Brushes.Black, 152, 250)
        Dim result_plan_date As String = ""

        Dim da As Date = Date.ParseExact(plan_, "yyyyMMdd", Globalization.CultureInfo.InvariantCulture)
        'lb_dlv_date.Text = da.ToString("dd/MM/yyyy")
        result_plan_date = da.ToString("dd/MM/yyyy")

        e.Graphics.DrawString("PLAN DATE", lb_font1.Font, Brushes.Black, 302, 238)
        e.Graphics.DrawString(result_plan_date, plandate.Font, Brushes.Black, 334, 253)
        e.Graphics.DrawString("LOT NO.", lb_font1.Font, Brushes.Black, 522, 238)
        e.Graphics.DrawString(lot_no.Text, lb_font2.Font, Brushes.Black, 522, 250)
        ''e.Graphics.DrawString("PROD. SEQ.", lb_font1.Font, Brushes.Black, 612, 238)
        ''e.Graphics.DrawString(plan_seq, lb_font2.Font, Brushes.Black, 622, 250)
        e.Graphics.DrawString("TBKK", lb_font2.Font, Brushes.Black, 15, 13)
        e.Graphics.DrawString("(Thailand) Co., Ltd.", lb_font1.Font, Brushes.Black, 15, 45)
        e.Graphics.DrawString("Shop floor system", lb_font4.Font, Brushes.Black, 15, 73)
        e.Graphics.DrawString("(New FA system)", lb_font4.Font, Brushes.Black, 15, 85)
        e.Graphics.DrawString("WI : " & wi.Text, lb_font6.Font, Brushes.Black, 15, 123)
        production_type = back_office.product_type(wi.Text)
        e.Graphics.DrawString(production_type, lb_font6.Font, Brushes.Black, 15, 136)

        Dim generate As New MessagingToolkit.QRCode.Codec.QRCodeEncoder

        qr_code_1.Image = generate.Encode(second)
        e.Graphics.DrawImage(qr_code_1.Image, 597, 17, 95, 95)
        e.Graphics.DrawImage(qr_code_1.Image, 31, 190, 95, 95)
        qr_code_2.Image = generate.Encode(second)
        e.Graphics.DrawImage(qr_code_2.Image, 620, 199, 70, 70)
        PictureBox1.Visible = True
        PictureBox3.Image = Api.DownloadImage("http://192.168.161.102/reprint_app/images/alert/alert_success.png")
        PictureBox3.Visible = True
        PictureBox3.Focus()
        PictureBox3.BackColor = Color.Transparent
        qr_code.Text = " "
        Trim(qr_code.Text)
    End Sub
    Public Function check_status()
        Dim status_check As Integer
        Dim rs2 As String = back_office.GET_DATA_TAG(Trim(qr_code.Text))
        If rs2 <> "0" Then
            Dim result_data_json As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(rs2)
            For Each item As Object In result_data_json
                status_check = item("flg_control").ToString()
                id = item("id").ToString()
            Next
        End If
        Return status_check
    End Function

    Public Function check_id()
        Dim id As Integer
        Dim qrcode = qr_code.Text
        'Dim reader As SqlDataReader
        ' reader = back_office.GET_DATA_TAG(Trim(qrcode))
        ' Do While reader.Read
        ' id = reader("id").ToString()
        ' Loop
        Dim rs2 As String = back_office.GET_DATA_TAG(Trim(qrcode))
        If rs2 <> "0" Then
            Dim result_data_json As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(rs2)
            For Each item As Object In result_data_json
                id = item("id").ToString()
            Next
        End If
        Return id
    End Function

    Private Sub qty_KeyDown(sender As Object, e As KeyEventArgs) Handles qty.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                Try
                    If qty.Text = "" Then
                        PictureBox3.Image = Api.DownloadImage("http://192.168.161.102/reprint_app/images/alert/alert_blanks.png")
                        PictureBox3.Visible = True
                        alert.BringToFront()
                        qty.Focus()
                        PictureBox3.Focus()
                        Exit Sub
                    ElseIf qty.Text = 0 Then
                        PictureBox3.Image = Api.DownloadImage("http://192.168.161.102/reprint_app/images/alert/alert_blanks.png")
                        PictureBox3.Visible = True
                        PictureBox3.SizeMode = PictureBoxSizeMode.AutoSize
                        alert.BringToFront()
                        qty.Focus()
                        PictureBox3.Focus()
                        Exit Sub
                    ElseIf qty.Text >= quatity Then
                        PictureBox3.Image = Api.DownloadImage("http://192.168.161.102/reprint_app/images/alert/alert_qty_error.png")
                        PictureBox3.Visible = True
                        alert.BringToFront()
                        qty.Focus()
                        PictureBox3.Focus()
                        Exit Sub
                    ElseIf quatity = 1 Then
                        PictureBox3.Image = Api.DownloadImage("http://192.168.161.102/reprint_app/images/alert/alert_qty_1.png")
                        PictureBox3.Visible = True
                        alert.BringToFront()
                        qty.Focus()
                        PictureBox3.Focus()
                        Exit Sub
                    End If
                Catch ex As Exception
                    MsgBox("error!!!!")
                    qty.Text = Nothing
                    qty.Focus()
                    Exit Sub
                End Try
                confirm.Visible = True
                button_cancel.Visible = True
                button_confirm.Visible = True
                button_confirm.Focus()
        End Select
    End Sub

    Public Function check_type()
        Dim check As Integer
        Dim line_check = qr_code.Text
        Dim rs = back_office.check_tag_type(Trim(line_check.Substring(2, 6)))
        If rs <> "0" Then
            Dim result_data_json As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(rs)
            For Each item As Object In result_data_json
                check = item("tag_type").ToString()
            Next
        End If
        Return check
    End Function

    Public Function check_duplicate(ByVal qr_code As String) As Boolean
        Try
            Dim rs As String = back_office.check_duplicate_tag_fa(qr_code)
            'MsgBox("rs", rs)
            If rs <> "0" Then
                Dim result_data_json As List(Of Object) = New JavaScriptSerializer().Deserialize(Of List(Of Object))(rs)

                If result_data_json.Count > 0 Then
                    Return True
                End If
            End If
        Catch ex As Exception
            MsgBox("ERROR!! check_duplicate: " & ex.Message())
        End Try

        ' ถ้าไม่พบ หรือเกิด error
        Return False
    End Function

    '<----------------------  1-10  --------------------------->
    Private Sub num1_Click(sender As Object, e As EventArgs) Handles num1.Click
        number_input.Text = number_input.Text + "1"
        Dim num As Integer = number_input.Text
        If num >= quatity Then
            PictureBox3.Image = Api.DownloadImage("http://192.168.161.102/reprint_app/images/alert/alert_qty_error.png")
            PictureBox3.Visible = True
            PictureBox3.Focus()
            PictureBox3.BringToFront()
            number_input.Text = number_input.Text.Remove(number_input.Text.Length - 1)
            Exit Sub
        End If
    End Sub

    Private Sub num2_Click(sender As Object, e As EventArgs) Handles num2.Click
        number_input.Text = number_input.Text + "2"
        Dim num As Integer = number_input.Text
        If num >= quatity Then
            PictureBox3.Image = Api.DownloadImage("http://192.168.161.102/reprint_app/images/alert/alert_qty_error.png")
            PictureBox3.Visible = True
            PictureBox3.Focus()
            PictureBox3.BringToFront()
            number_input.Text = number_input.Text.Remove(number_input.Text.Length - 1)
            Exit Sub
        End If
    End Sub

    Private Sub num3_Click(sender As Object, e As EventArgs) Handles num3.Click
        number_input.Text = number_input.Text + "3"
        Dim num As Integer = number_input.Text
        If num >= quatity Then
            PictureBox3.Image = Api.DownloadImage("http://192.168.161.102/reprint_app/images/alert/alert_qty_error.png")
            PictureBox3.Visible = True
            PictureBox3.Focus()
            PictureBox3.BringToFront()
            number_input.Text = number_input.Text.Remove(number_input.Text.Length - 1)
            Exit Sub
        End If
    End Sub

    Private Sub num4_Click(sender As Object, e As EventArgs) Handles num4.Click
        number_input.Text = number_input.Text + "4"
        Dim num As Integer = number_input.Text
        If num >= quatity Then
            PictureBox3.Image = Api.DownloadImage("http://192.168.161.102/reprint_app/images/alert/alert_qty_error.png")
            PictureBox3.Visible = True
            PictureBox3.Focus()
            PictureBox3.BringToFront()
            number_input.Text = number_input.Text.Remove(number_input.Text.Length - 1)
            Exit Sub
        End If
    End Sub

    Private Sub num5_Click(sender As Object, e As EventArgs) Handles num5.Click
        number_input.Text = number_input.Text + "5"
        Dim num As Integer = number_input.Text
        If num >= quatity Then
            PictureBox3.Image = Api.DownloadImage("http://192.168.161.102/reprint_app/images/alert/alert_qty_error.png")
            PictureBox3.Visible = True
            PictureBox3.Focus()
            PictureBox3.BringToFront()
            number_input.Text = number_input.Text.Remove(number_input.Text.Length - 1)
            Exit Sub
        End If
    End Sub

    Private Sub num6_Click(sender As Object, e As EventArgs) Handles num6.Click
        number_input.Text = number_input.Text + "6"
        Dim num As Integer = number_input.Text
        If num >= quatity Then
            PictureBox3.Image = Api.DownloadImage("http://192.168.161.102/reprint_app/images/alert/alert_qty_error.png")
            PictureBox3.Visible = True
            PictureBox3.Focus()
            PictureBox3.BringToFront()
            number_input.Text = number_input.Text.Remove(number_input.Text.Length - 1)
            Exit Sub
        End If
    End Sub

    Private Sub num7_Click(sender As Object, e As EventArgs) Handles num7.Click
        number_input.Text = number_input.Text + "7"
        Dim num As Integer = number_input.Text
        If num >= quatity Then
            PictureBox3.Image = Api.DownloadImage("http://192.168.161.102/reprint_app/images/alert/alert_qty_error.png")
            PictureBox3.Visible = True
            PictureBox3.Focus()
            PictureBox3.BringToFront()
            number_input.Text = number_input.Text.Remove(number_input.Text.Length - 1)
            Exit Sub
        End If
    End Sub
    Private Sub num8_Click(sender As Object, e As EventArgs) Handles num8.Click
        number_input.Text = number_input.Text + "8"
        Dim num As Integer = number_input.Text
        If num >= quatity Then
            PictureBox3.Image = Api.DownloadImage("http://192.168.161.102/reprint_app/images/alert/alert_qty_error.png")
            PictureBox3.Visible = True
            PictureBox3.Focus()
            PictureBox3.BringToFront()
            number_input.Text = number_input.Text.Remove(number_input.Text.Length - 1)
            Exit Sub
        End If
    End Sub
    Private Sub num9_Click(sender As Object, e As EventArgs) Handles num9.Click
        number_input.Text = number_input.Text + "9"
        Dim num As Integer = number_input.Text
        If num >= quatity Then
            PictureBox3.Image = Api.DownloadImage("http://192.168.161.102/reprint_app/images/alert/alert_qty_error.png")
            PictureBox3.Visible = True
            PictureBox3.Focus()
            PictureBox3.BringToFront()
            number_input.Text = number_input.Text.Remove(number_input.Text.Length - 1)
            Exit Sub
        End If
    End Sub
    Private Sub num0_Click(sender As Object, e As EventArgs) Handles num0.Click
        number_input.Text = number_input.Text + "0"
        Dim num As Integer = number_input.Text
        If num = 0 Then
            PictureBox3.Image = Api.DownloadImage("http://192.168.161.102/reprint_app/images/alert/alert_blanks.png")
            PictureBox3.Visible = True
            PictureBox3.Focus()
            PictureBox3.BringToFront()
            number_input.Text = number_input.Text.Remove(number_input.Text.Length - 1)
            Exit Sub
        ElseIf num >= quatity Then
            PictureBox3.Image = Api.DownloadImage("http://192.168.161.102/reprint_app/images/alert/alert_qty_error.png")
            PictureBox3.Visible = True
            PictureBox3.Focus()
            PictureBox3.BringToFront()
            number_input.Text = number_input.Text.Remove(number_input.Text.Length - 1)
            Exit Sub
        End If
    End Sub

    Private Sub ok_button_Click(sender As Object, e As EventArgs) Handles ok_button.Click
        If number_input.Text = "" Then
            PictureBox3.Image = Api.DownloadImage("http://192.168.161.102/reprint_app/images/alert/alert_blanks.png")
            PictureBox3.Visible = True
            PictureBox3.Focus()
            Exit Sub
        End If
        qty.Text = number_input.Text
        key.Visible = False
        qty.Focus()
        panel_number.Visible = False
        ok_button.Visible = False
        reprint.Visible = True
        back_button.Visible = False
        number_input.Visible = False
        Label1.Visible = False
    End Sub

    Private Sub back_button_Click(sender As Object, e As EventArgs) Handles back_button.Click
        key.Visible = False
        qty.Focus()
        panel_number.Visible = False
        ok_button.Visible = False
        Label1.Visible = False
        back_button.Visible = False
        number_input.Visible = False
    End Sub

    Private Sub cc_Click(sender As Object, e As EventArgs) Handles menu_key_number.Click
        key.Visible = True
        Label1.Text = qty_pcs.Text
        panel_number.Visible = True
        Label1.Visible = False
        number_input.Visible = True
        ok_button.Visible = True
        back_button.Visible = True
        Label1.Visible = True
        number_input.Text = ""
    End Sub

    Private Sub Pb3_focus(sender As Object, e As EventArgs) Handles PictureBox3.KeyDown
        PictureBox3.Visible = False
        qr_code.Text = Nothing
        Trim(qr_code.Text)
        qty.Text = Nothing
        qty.Focus()
    End Sub

    Public Sub confrim_eroor(sender As Object, e As EventArgs) Handles button_confirm.KeyDown
        PictureBox2.Visible = False
        wi.Visible = False
        qty_pcs.Visible = False
        box_no.Visible = False
        part_name.Visible = False
        part_no.Visible = False
        pro_seq.Visible = False
        shift.Visible = False
        model.Visible = False
        lot_no.Visible = False
        qty.Visible = False
        line.Visible = False
        actual_date.Visible = False
        plan_date.Visible = False
        reprint.Visible = False
        exit_pagedata.Visible = False
        menu_key_number.Visible = False
        run_reprint()
        confirm.Visible = False
        button_confirm.Visible = False
        button_cancel.Visible = False
        'PrintPreviewDialog1.ShowDialog()
        'PrintPreviewDialog2.ShowDialog()
        PrintDocument1.Print()
        PrintDocument2.Print()
    End Sub
End Class

