
Imports System.Data.SqlClient
Imports System.Drawing.Printing
Imports System.Web.Script.Serialization
Imports System.Threading.Tasks
Imports Newtonsoft.Json
Public Class dummy_tag_detail_form
    Dim back_office As New Model
    Dim reader As SqlDataReader
    Dim QR_Generator As New MessagingToolkit.QRCode.Codec.QRCodeEncoder
    Dim reader_show As SqlDataReader
    Dim log_ref_id As Integer
    Dim tag_ref_str_id As Integer
    Dim log_id_main As Integer
    Dim lot_tag, new_qr_code, production_type, part_no_tag, line_tag, wi_notdata, _location, PD, part_name_tag, model_tag, part_no_class, lot_class, line_class, seq_class, qr_code_tag, next_process, plan_, _actual, wi_tag, seq_tag, shift_tag As String

    Private Sub dummy_tag_detail_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Dim qty_tag, box_tag, ref_id, box_class, qty_class, box_max, log_id, cur_qty, box_tag_ps As Integer

    Public Async Sub SetData(wi As String, seq As String, lot As String, line As String)
        wi_tag = wi
        seq_tag = seq
        lot_tag = lot
        line_tag = line
        Try
            InitializeComponent()
            Dim rs = Await back_office.get_data_tag_for_dummy(wi_tag, seq_tag, lot_tag)
            If rs <> "0" Then
                Dim result_data_json As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(rs)

                For Each item As Object In result_data_json
                    Dim qr_detail As String = item("qr_detail").ToString()
                    Dim plan As String = qr_detail.Substring(8, 8)
                    Dim actual As String = qr_detail.Substring(44, 8)
                    Dim act As Date = Date.ParseExact(actual, "yyyyMMdd", Globalization.CultureInfo.InvariantCulture)
                    Dim pld As Date = Date.ParseExact(plan, "yyyyMMdd", Globalization.CultureInfo.InvariantCulture)
                    Dim lot1 As String = qr_detail.Substring(44, 18)
                    Dim lot_show = lot1.Substring(lot1.Length - 4)
                    Dim qt_y As String = lot1.Substring(Trim(lot1.Length - 7))

                    log_id = item("id").ToString()
                    wi_show_data.Text = wi_tag.ToString()
                    seq_show_data.Text = seq_tag.ToString()
                    lot_no_show_data.Text = lot_tag.ToString()
                    box_tag = item("box_no").ToString()
                    shift_show_data.Text = item("shift").ToString()
                    qr_code_tag = qr_detail
                    ac_date_show_data.Text = act.ToString("dd/MM/yyyy")
                    plan_date_show_data.Text = pld.ToString("dd/MM/yyyy")
                    next_process = item("next_proc").ToString()
                    qty_show_data.Text = qt_y.Remove(qt_y.Length - 4).Trim()
                    tag_show_data.Text = 1
                    cur_qty = qty_show_data.Text
                Next
                get_data()
            End If
            part_no_tag = part_no_show_data.Text

            box_max = back_office.find_max_box(part_no_tag, lot_tag, line_tag, seq_tag)

            box_tag_ps = 999 - box_max
            If box_max <= 989 Then
                max_box_ps.Text = ("MAX 10 TAG/TIMES")
            ElseIf box_max > 989 Then
                max_box_ps.Text = ("MAX " & box_tag_ps & " TAG/TIMES")
            End If

        Catch ex As Exception
            MsgBox("Catch")
            'alert.Visible = True
        End Try

        wi_show_data.Visible = True
        part_name_show_data.Visible = True
        part_no_show_data.Visible = True
        model_show_data.Visible = True
        line_show_data.Visible = True
        shift_show_data.Visible = True
        lot_no_show_data.Visible = True
        seq_show_data.Visible = True
        ac_date_show_data.Visible = True
        plan_date_show_data.Visible = True
        qty_show_data.Visible = True
        tag_show_data.Visible = True
        PictureBox2.Visible = True
        exit_pagedata.Visible = True
        exit_pagedata.BringToFront()
        print_BT.Visible = True
        max_box_ps.Visible = True
        print_BT.BringToFront()
        max_box_ps.BringToFront()
        max_box_ps.BringToFront()
        'reprint.Visible = False

    End Sub

    Private Sub exit_pagedata_Click(sender As Object, e As EventArgs) Handles exit_pagedata.Click
        'wi_show_data.Visible = False
        'part_name_show_data.Visible = False
        'part_no_show_data.Visible = False
        'model_show_data.Visible = False
        'line_show_data.Visible = False
        'shift_show_data.Visible = False
        'lot_no_show_data.Visible = False
        'seq_show_data.Visible = False
        'ac_date_show_data.Visible = False
        'plan_date_show_data.Visible = False
        'qty_show_data.Visible = False
        'tag_show_data.Visible = False
        'PictureBox2.Visible = False
        'print_BT.Visible = False
        'exit_pagedata.Visible = False
        ''max_box_ps.Text = Nothing
        ''max_box_ps.Visible = False
        'tag_show_data.Text = Nothing
        menu_form.modalScanSearch.Show()
        Me.Close()
    End Sub

    Public Sub get_data()
        Dim Model_reprint As New Model()
        Dim rs = Model_reprint.GET_DATA_TAG_2(wi_tag)
        If rs <> "0" Then
            Dim result_data_json As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(rs)
            For Each item As Object In result_data_json
                model_show_data.Text = item("MODEL").ToString()
                part_no_show_data.Text = item("ITEM_CD").ToString()
                part_name_show_data.Text = item("ITEM_NAME").ToString()
                model_show_data.Text = item("MODEL").ToString()
                line_show_data.Text = item("LINE_CD").ToString()
                PD = item("PD").ToString()
                _location = item("LOCATION_PART").ToString()
            Next
        End If
    End Sub

    Private Sub print_BT_Click(sender As Object, e As EventArgs) Handles print_BT.Click
        Dim print_tag As New print_main_M83()
        If tag_show_data.Text = Nothing Then
            MsgBox("Please insert data")
            Exit Sub
        End If
        If tag_show_data.Text = 0 Then
            MsgBox("Please insert data")
            Exit Sub
        End If
        gen_qr()
        If back_office.get_tagtype(line_tag) = 1 Then
            tag_type_1()
            Me.Close()

        ElseIf back_office.get_tagtype(line_tag) = 3 Then
            tag_type_1()
            Me.Close()
        Else
            Dim rs = back_office.get_detail_tag_main(qr_code_tag)


            If rs <> "0" Then
                Dim result_data_json As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(rs)
                For Each item As Object In result_data_json
                    tag_ref_str_id = item("tag_ref_str_id").ToString()
                    log_id_main = item("tag_id").ToString()
                Next
            End If

            tag_type_2()
            Me.Close()
        End If
    End Sub

    Private Sub gen_qr()
        Dim qr_code As String = qr_code_tag.Substring(0, 52)
        Dim qq As Integer = qty_show_data.Text
        Dim qr_code_ As String = qr_code_tag.Substring(87, 13)
        If qq < 10 Then
            new_qr_code = (qr_code & "     " & qq & lot_no_show_data.Text & "                         " & qr_code_)
        ElseIf qq < 100 Then
            new_qr_code = (qr_code & "    " & qq & lot_no_show_data.Text & "                         " & qr_code_)
        ElseIf qq < 1000 Then
            new_qr_code = (qr_code & "   " & qq & lot_no_show_data.Text & "                         " & qr_code_)
        ElseIf qq < 10000 Then
            new_qr_code = (qr_code & "  " & qq & lot_no_show_data.Text & "                         " & qr_code_)
        End If
    End Sub

    Public Sub tag_type_1()
        Dim tag_amount As Integer = tag_show_data.Text
        If tag_amount > 10 Then
            succes.Image = Api.DownloadImage("http://192.168.161.102/reprint_app/images/alert/alert_max_tag_time.png")
            succes.BringToFront()
            succes.Visible = True
            succes.Focus()
            tag_show_data.Text = Nothing

            Exit Sub
        End If

        If box_max = 999 Then
            succes.Image = Api.DownloadImage("http://192.168.161.102/reprint_app/images/alert/alert_box_number_over.png")
            succes.BringToFront()
            succes.Visible = True
            succes.Focus()

            Exit Sub
        End If
        If box_max = 0 Then
            box_max = 900
            Dim index As Integer = 1
            Do While index <= tag_show_data.Text
                PrintDocument1.Print()
                '  PrintPreviewDialog1.ShowDialog()
                If box_max = 999 Then

                    succes.Image = Api.DownloadImage("http://192.168.161.102/reprint_app/images/alert/alert_box_number_over.png")
                    succes.BringToFront()
                    succes.Visible = True
                    succes.Focus()
                    Exit Sub
                End If
                box_max += 1
                index += 1
            Loop

            succes.Image = Api.DownloadImage("http://192.168.161.102/reprint_app/images/alert/alert_success.png")
            succes.Focus()
            succes.BringToFront()
            succes.Visible = True
        Else
            box_max = back_office.find_max_box(part_no_tag, lot_tag, line_tag, seq_tag)
            box_max += 1
            Dim index As Integer = 1
            Do While index <= tag_show_data.Text
                PrintDocument1.Print()
                'PrintPreviewDialog1.ShowDialog()
                If box_max = 999 Then

                    succes.Image = Api.DownloadImage("http://192.168.161.102/reprint_app/images/alert/alert_box_number_over.png")
                    succes.Visible = True
                    succes.Focus()
                    succes.BringToFront()
                    Exit Sub
                End If
                box_max += 1
                index += 1
            Loop

            succes.Image = Api.DownloadImage("http://192.168.161.102/reprint_app/images/alert/alert_success.png")
            succes.Focus()
            succes.BringToFront()
            succes.Visible = True
        End If
        box_tag_ps = 999 - box_max
        If box_max <= 989 Then
            max_box_ps.Text = ("MAX 10 TAG/TIMES")
        ElseIf box_max > 989 Then
            max_box_ps.Text = ("MAX " & box_tag_ps & " TAG/TIMES")
        End If
    End Sub

    Public Sub tag_type_2()
        Dim newForm As New print_main_M83()
        Dim actaul_tag As String = ac_date_show_data.Text
        Dim plan_tag As String = plan_date_show_data.Text
        Dim instr_tag As String = part_name_show_data.Text
        Dim qty_tag_key As String = qty_show_data.Text
        Dim qr_detail As String
        Dim tag_amount As Integer = CInt(tag_show_data.Text)

        ' Validate tag amount
        If tag_amount > 10 Then
            MsgBox("Tag Over 10 Times")
            tag_show_data.Text = Nothing
            Exit Sub
        End If

        ' Validate max box limit
        If box_max = 999 Then
            MsgBox("Box Number Over 999")
            Exit Sub
        End If

        ' Initialize box number
        If box_max = 0 Then
            box_max = 900
        Else
            box_max = back_office.find_max_box(part_no_tag, lot_tag, line_tag, seq_tag) + 1
        End If

        ' Process tags
        For index As Integer = 1 To tag_amount
            qr_detail = new_qr_code & box_max
            newForm.printTagDummy(wi_tag, actaul_tag, box_max, seq_tag, lot_tag, qty_tag_key, plan_tag, qr_code_tag, instr_tag, tag_ref_str_id, log_id_main)
            back_office.insert_dummy_tag2(log_id, cur_qty, qty_show_data.Text, box_tag, box_max, "ISUZU", qr_detail)

            ' Check max box limit
            If box_max = 999 Then
                MsgBox("Box Number Over 999")
                Exit Sub
            End If

            box_max += 1
        Next

        ' Show success message
        MsgBox("Success")

        ' Update remaining tags display
        box_tag_ps = 999 - box_max
        max_box_ps.Text = If(box_max <= 989, "MAX 10 TAG/TIME", "MAX " & box_tag_ps & " TAG/TIME")
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim aPen = New Pen(Color.Black)
        aPen.Width = 2.0F
        '   Dim num_char_box1 As Integer = box_max.ToString().Length
        'Dim box_qr As String = ""
        'If num_char_box1 = 1 Then
        'box_qr = "00" & box_max
        'ElseIf num_char_box1 = 2 Then
        'box_qr = "0" & box_max
        'Else
        'box_qr = box_max
        'End If


        Dim qr_detail As String = (new_qr_code & box_max)
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
        e.Graphics.DrawString(part_no_show_data.Text, lb_font2.Font, Brushes.Black, 152, 25)
        e.Graphics.DrawString("QTY.", lb_font1.Font, Brushes.Black, 492, 13)
        e.Graphics.DrawString(qty_show_data.Text, lb_font2.Font, Brushes.Black, 505, 25)
        e.Graphics.DrawString("PART NAME", lb_font1.Font, Brushes.Black, 152, 67)

        e.Graphics.DrawString(part_name_show_data.Text, font_part_name.Font, Brushes.Black, 152, 79)
        e.Graphics.DrawString("MODEL", lb_font1.Font, Brushes.Black, 152, 123)
        e.Graphics.DrawString(model_show_data.Text, lb_font5.Font, Brushes.Black, 152, 141)
        e.Graphics.DrawString("NEXT PROCESS", lb_font1.Font, Brushes.Black, 412, 123)
        e.Graphics.DrawString(next_process, lb_font5.Font, Brushes.Black, 414, 141)

        e.Graphics.DrawString("LOCATION", lb_font1.Font, Brushes.Black, 592, 123)
        e.Graphics.DrawString(_location, lb_font5.Font, Brushes.Black, 596, 141)
        e.Graphics.DrawString("SHIFT", lb_font1.Font, Brushes.Black, 152, 178)
        e.Graphics.DrawString(shift_show_data.Text, lb_font2.Font, Brushes.Black, 170, 190)
        e.Graphics.DrawString("PRO. SEQ.", lb_font1.Font, Brushes.Black, 227, 178)
        e.Graphics.DrawString(seq_show_data.Text, lb_font2.Font, Brushes.Black, 231, 190)
        e.Graphics.DrawString("BOX NO.", lb_font1.Font, Brushes.Black, 302, 178)
        e.Graphics.DrawString(box_max, lb_font2.Font, Brushes.Black, 320, 190)
        e.Graphics.DrawString("ACTUAL DATE", lb_font1.Font, Brushes.Black, 412, 178)
        e.Graphics.DrawString(ac_date_show_data.Text, lb_font3.Font, Brushes.Black, 412, 196)
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
        e.Graphics.DrawString(line_show_data.Text, lb_font2.Font, Brushes.Black, 152, 250)
        e.Graphics.DrawString("PLAN DATE", lb_font1.Font, Brushes.Black, 302, 238)
        e.Graphics.DrawString(plan_date_show_data.Text, plandate.Font, Brushes.Black, 334, 255)
        e.Graphics.DrawString("LOT NO.", lb_font1.Font, Brushes.Black, 522, 238)
        e.Graphics.DrawString(lot_no_show_data.Text, lb_font2.Font, Brushes.Black, 522, 250)
        ''e.Graphics.DrawString("PROD. SEQ.", lb_font1.Font, Brushes.Black, 612, 238)
        ''e.Graphics.DrawString(plan_seq, lb_font2.Font, Brushes.Black, 622, 250)
        e.Graphics.DrawString("TBKK", lb_font2.Font, Brushes.Black, 15, 13)
        e.Graphics.DrawString("(Thailand) Co., Ltd.", lb_font1.Font, Brushes.Black, 15, 45)
        e.Graphics.DrawString("Shop floor system", lb_font4.Font, Brushes.Black, 15, 73)
        e.Graphics.DrawString("(New FA system)", lb_font4.Font, Brushes.Black, 15, 85)
        e.Graphics.DrawString("WI : " & wi_tag, lb_font6.Font, Brushes.Black, 15, 123)
        production_type = back_office.product_type(wi_tag)
        e.Graphics.DrawString(production_type, lb_font6.Font, Brushes.Black, 15, 136)
        e.Graphics.DrawString("[ Dummy Tag ]", lb_font4.Font, Brushes.Black, 31, 172)
        Dim generate As New MessagingToolkit.QRCode.Codec.QRCodeEncoder

        qr_code_1.Image = generate.Encode(qr_detail)
        e.Graphics.DrawImage(qr_code_1.Image, 597, 17, 95, 95)
        e.Graphics.DrawImage(qr_code_1.Image, 31, 190, 95, 95)
        qr_code_2.Image = generate.Encode(qr_detail)
        e.Graphics.DrawImage(qr_code_2.Image, 620, 199, 70, 70)
        back_office.insert_dummy_tag(log_id, cur_qty, qty_show_data.Text, box_tag, box_max, next_process, qr_detail)
    End Sub
    Private Sub succes_Click(sender As Object, e As EventArgs) Handles succes.Click
        succes.Visible = False
        tag_show_data.Focus()
    End Sub
    Private Sub succes_KeyPress(sender As Object, e As KeyPressEventArgs) Handles succes.KeyPress
        succes.Visible = False
        tag_show_data.Focus()
    End Sub
End Class