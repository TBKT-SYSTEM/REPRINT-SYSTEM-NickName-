Imports System.Data.SqlClient
Imports System.Web.Script.Serialization

Public Class log_reprint_form
    Dim back_office As New Model
    Dim reader As SqlDataReader
    Dim reader_show As SqlDataReader
    Dim log_ref_id As Integer
    Dim lot_tag, production_type, part_no_tag, line_tag, _location, PD, part_name_tag, model_tag, part_no_class, lot_class, line_class, seq_class, qr_code_tag, next_process, plan_, _actual, wi_tag, seq_tag, shift_tag As String
    Dim qty_tag, box_tag, ref_id, box_class, qty_class, id_menu, id_menu_ref As Integer
    Private Sub slide_Click(sender As Object, e As EventArgs) Handles slide.Click
        reprint.Visible = True
    End Sub
    Private Sub log_reprint_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
    Public Sub New()
        InitializeComponent()
        Dim i = 1
        Dim ref_line As String = menu_form.line_data.Text
        Dim ref_year As String = menu_form.year_data.Text
        Dim ref_month As String = month_Convert_to_num(menu_form.month_data.Text)
        Dim year_and_month As String = (ref_year + ref_month)
        Dim ref_part_no As String = menu_form.part_no_data.Text
        Dim ref_lot As String = menu_form.lot_no_data.Text
        Try
            Dim rs = back_office.get_data_tag_log_reprint(ref_line, year_and_month, ref_part_no, ref_lot)
            If rs <> "0" Then
                Dim result_data_json As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(rs)
                For Each item As Object In result_data_json
                    box.Text = reader("log_new_box_no").ToString()
                    qty.Text = reader("log_new_qty").ToString()
                    Dim qr_code As String = reader("log_qr_detail").ToString()
                    id_menu = reader("id_menu").ToString()
                    Dim qr_detail = qr_code.Substring(19, 25)
                    data_combobox.Text = qr_detail
                    Dim lot_detail As String = qr_code.Substring(44, 18)
                    lot.Text = lot_detail.Substring(lot_detail.Length - 4)
                    Dim qr_code_check As String = qr_code.Substring(0, 52)
                    line.Text = qr_code.Substring(2, 6)
                    seq.Text = qr_code.Substring(16, 3)
                    Dim newitem As New ListViewItem(i)
                    newitem.SubItems.Add(qr_detail.Trim)
                    newitem.SubItems.Add(lot.Text.Trim)
                    newitem.SubItems.Add(line.Text.Trim)
                    newitem.SubItems.Add(box.Text)
                    newitem.SubItems.Add(qty.Text)
                    newitem.SubItems.Add(seq.Text.Trim)
                    newitem.SubItems.Add(id_menu)
                    ListView1.Items.Add(newitem)
                    i += 1
                Next
            End If
            If box.Text = "" Then
                alert.Visible = True
            End If
        Catch ex As Exception
            alert.Visible = True
        End Try
    End Sub
    Public Function month_Convert_to_num(ByVal month As String)
        Try
            If month = "1.January" Then
                month = "01"
            ElseIf month = "2.February" Then
                month = "02"
            ElseIf month = "3.March" Then
                month = "03"
            ElseIf month = "4.Aprill" Then
                month = "04"
            ElseIf month = "5.May" Then
                month = "05"
            ElseIf month = "6.June" Then
                month = "06"
            ElseIf month = "7.July" Then
                month = "07"
            ElseIf month = "8.August" Then
                month = "08"
            ElseIf month = "9.September" Then
                month = "09"
            ElseIf month = "10.October" Then
                month = "10"
            ElseIf month = "11.November" Then
                month = "11"
            ElseIf month = "12.December" Then
                month = "12"
            End If
            Return month
        Catch ex As Exception
            MsgBox(ex.Message())
        End Try
        Return 0
    End Function
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        menu_form.Show()
        Me.Close()
    End Sub

    Private Sub alert_Click(sender As Object, e As EventArgs) Handles alert.Click
        menu_form.Show()
        Me.Close()
    End Sub
    Private Sub succes_Click(sender As Object, e As EventArgs) Handles succes.Click
        succes.Visible = False
    End Sub

    Private Sub ListView1_DoubleClick(sender As Object, e As EventArgs) Handles ListView1.DoubleClick
        Try
            If ListView1.SelectedItems.Count > 0 Then
                part_no_class = ListView1.SelectedItems(0).SubItems(1).Text
                lot_class = ListView1.SelectedItems(0).SubItems(2).Text
                line_class = ListView1.SelectedItems(0).SubItems(3).Text
                box_class = ListView1.SelectedItems(0).SubItems(4).Text
                qty_class = ListView1.SelectedItems(0).SubItems(5).Text
                seq_class = ListView1.SelectedItems(0).SubItems(6).Text
                id_menu_ref = ListView1.SelectedItems(0).SubItems(7).Text
                logreprint_app()
                Dim part_name_over As String
                Dim part_name_digit_over As String
                If part_name_tag.Length > 33 Then
                    font_part_name.Font = New Font("Consolas", 16, FontStyle.Bold)
                    part_name_over = part_name_tag.Substring(0, 32)
                    part_name_digit_over = (part_name_over + "...")
                    part_name_tag = part_name_digit_over
                ElseIf part_name_tag.Length > 25 Then
                    font_part_name.Font = New Font("Consolas", 18, FontStyle.Bold)
                End If
                PrintDocument1.Print()
                ' PrintPreviewDialog1.ShowDialog()
                runreprint()
            Else
                succes.Image = Api.DownloadImage("http://192.168.161.102/reprint_app/images/alert/select_data_print.png")
                succes.Visible = True
                succes.Focus()
            End If

        Catch ex As Exception
            MsgBox("EROOR1!!" & " " & ex.Message())
        End Try
    End Sub
    Public Sub logreprint_app()
        Dim Model_reprint As New Model()
        Dim rs = Model_reprint.get_data_to_reprint_log(part_no_class, lot_class, line_class, box_class, qty_class)
        If rs <> "0" Then
            Dim result_data_json As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(rs)
            For Each item As Object In result_data_json
                Dim qr_detail As String = item("log_qr_detail").ToString()
                box_tag = item("log_new_box_no").ToString()
                qty_tag = item("log_new_qty").ToString()
                ref_id = item("log_id").ToString()
                qr_code_tag = qr_detail
                next_process = item("log_new_next_proc").ToString()
                Dim plan As String = qr_detail.Substring(8, 8)
                plan_ = plan
                Dim actual As String = qr_detail.Substring(44, 8)
                _actual = actual
                Dim act As Date = Date.ParseExact(_actual, "yyyyMMdd", Globalization.CultureInfo.InvariantCulture)
                Dim da As Date = Date.ParseExact(plan_, "yyyyMMdd", Globalization.CultureInfo.InvariantCulture)
                Dim lot As String = qr_detail.Substring(44, 18)
                'lot_no.Text = lot.Substring(lot.Length - 4)
                Dim qt_y As String = lot.Substring(Trim(lot.Length - 7))
                Dim tim As String = qt_y.Remove(qt_y.Length - 4)
                get_data_tag_inserttwo()
            Next
        End If
    End Sub
    Public Sub get_data_tag_inserttwo()
        Try

            Dim Model_reprint As New Model()
            Dim reader As SqlDataReader
            Dim qr_code_check As String = qr_code_tag.Substring(0, 52)
            Dim min_cur_box As Integer = back_office.get_log_ref_id(qr_code_check)
            Dim min_log_id As Integer = back_office.get_log_ref_id_1(qr_code_check, min_cur_box)
            Dim log_ref_id As Integer = back_office.get_log_ref_id_2(min_log_id)
            Dim rs = Model_reprint.get_data_all(log_ref_id)
            If rs <> "0" Then
                Dim result_data_json As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(rs)
                For Each item As Object In result_data_json
                    wi_tag = item("wi").ToString()
                    shift_tag = item("shift").ToString()
                    seq_tag = item("seq_no").ToString()
                    get_data()
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub runreprint()
        back_office.insert_log_print(ref_id)
    End Sub
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
        e.Graphics.DrawString(part_no_tag, lb_font2.Font, Brushes.Black, 152, 25)
        e.Graphics.DrawString("QTY.", lb_font1.Font, Brushes.Black, 492, 13)
        e.Graphics.DrawString(qty_tag, lb_font2.Font, Brushes.Black, 505, 25)
        e.Graphics.DrawString("PART NAME", lb_font1.Font, Brushes.Black, 152, 67)

        e.Graphics.DrawString(part_name_tag, font_part_name.Font, Brushes.Black, 152, 79)
        e.Graphics.DrawString("MODEL", lb_font1.Font, Brushes.Black, 152, 123)
        e.Graphics.DrawString(model_tag, lb_font5.Font, Brushes.Black, 152, 141)
        e.Graphics.DrawString("NEXT PROCESS", lb_font1.Font, Brushes.Black, 412, 123)
        e.Graphics.DrawString(next_process, lb_font5.Font, Brushes.Black, 414, 141)

        e.Graphics.DrawString("LOCATION", lb_font1.Font, Brushes.Black, 592, 123)
        e.Graphics.DrawString(_location, lb_font5.Font, Brushes.Black, 596, 141)
        e.Graphics.DrawString("SHIFT", lb_font1.Font, Brushes.Black, 152, 178)
        e.Graphics.DrawString(shift_tag, lb_font2.Font, Brushes.Black, 170, 190)
        e.Graphics.DrawString("PRO. SEQ.", lb_font1.Font, Brushes.Black, 227, 178)
        e.Graphics.DrawString(seq_tag, lb_font2.Font, Brushes.Black, 231, 190)
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
        e.Graphics.DrawString(line_tag, lb_font2.Font, Brushes.Black, 152, 250)
        Dim result_plan_date As String = ""

        Dim da As Date = Date.ParseExact(plan_, "yyyyMMdd", Globalization.CultureInfo.InvariantCulture)
        'lb_dlv_date.Text = da.ToString("dd/MM/yyyy")
        result_plan_date = da.ToString("dd/MM/yyyy")

        e.Graphics.DrawString("PLAN DATE", lb_font1.Font, Brushes.Black, 302, 238)
        e.Graphics.DrawString(result_plan_date, plandate.Font, Brushes.Black, 334, 255)
        e.Graphics.DrawString("LOT NO.", lb_font1.Font, Brushes.Black, 522, 238)
        e.Graphics.DrawString(lot_class, lb_font2.Font, Brushes.Black, 522, 250)
        ''e.Graphics.DrawString("PROD. SEQ.", lb_font1.Font, Brushes.Black, 612, 238)
        ''e.Graphics.DrawString(plan_seq, lb_font2.Font, Brushes.Black, 622, 250)
        e.Graphics.DrawString("TBKK", lb_font2.Font, Brushes.Black, 15, 13)
        e.Graphics.DrawString("(Thailand) Co., Ltd.", lb_font1.Font, Brushes.Black, 15, 45)
        e.Graphics.DrawString("Shop floor system", lb_font4.Font, Brushes.Black, 15, 73)
        e.Graphics.DrawString("(New FA system)", lb_font4.Font, Brushes.Black, 15, 85)
        e.Graphics.DrawString("WI : " & wi_tag, lb_font6.Font, Brushes.Black, 15, 123)
        production_type = back_office.product_type(wi_tag)
        e.Graphics.DrawString(production_type, lb_font6.Font, Brushes.Black, 15, 136)
        If id_menu_ref = 5 Then
            e.Graphics.DrawString("[ Dummy Tag ]", lb_font4.Font, Brushes.Black, 31, 172)
        End If
        Dim generate As New MessagingToolkit.QRCode.Codec.QRCodeEncoder

        qr_code_1.Image = generate.Encode(qr_code_tag)
        e.Graphics.DrawImage(qr_code_1.Image, 597, 17, 95, 95)
        e.Graphics.DrawImage(qr_code_1.Image, 31, 190, 95, 95)
        qr_code_2.Image = generate.Encode(qr_code_tag)
        e.Graphics.DrawImage(qr_code_2.Image, 620, 199, 70, 70)
        succes.Image = Api.DownloadImage("http://192.168.161.102/reprint_app/images/alert/alert_success.png")
        succes.Visible = True
    End Sub
    Public Sub get_data()
        Try
            Dim Model_reprint As New Model()
            Dim rs = Model_reprint.GET_DATA_TAG_2(wi_tag)
            If rs <> "0" Then
                Dim result_data_json As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(rs)
                For Each item As Object In result_data_json
                    model_tag = item("MODEL").ToString()
                    part_name_tag = item("ITEM_NAME").ToString()
                    line_tag = item("LINE_CD").ToString()
                    part_no_tag = item("ITEM_CD").ToString()
                    PD = item("PD").ToString()
                    _location = item("LOCATION_PART").ToString()
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub reprint_Click(sender As Object, e As EventArgs) Handles reprint.Click
        Try
            If ListView1.SelectedItems.Count > 0 Then
                part_no_class = ListView1.SelectedItems(0).SubItems(1).Text
                lot_class = ListView1.SelectedItems(0).SubItems(2).Text
                line_class = ListView1.SelectedItems(0).SubItems(3).Text
                box_class = ListView1.SelectedItems(0).SubItems(4).Text
                qty_class = ListView1.SelectedItems(0).SubItems(5).Text
                seq_class = ListView1.SelectedItems(0).SubItems(6).Text
                id_menu_ref = ListView1.SelectedItems(0).SubItems(7).Text

                logreprint_app()
                Dim part_name_over As String
                Dim part_name_digit_over As String
                If part_name_tag.Length > 33 Then
                    font_part_name.Font = New Font("Consolas", 16, FontStyle.Bold)
                    part_name_over = part_name_tag.Substring(0, 32)
                    part_name_digit_over = (part_name_over + "...")
                    part_name_tag = part_name_digit_over
                ElseIf part_name_tag.Length > 25 Then
                    font_part_name.Font = New Font("Consolas", 18, FontStyle.Bold)
                End If
                'PrintDocument1.Print()
                PrintPreviewDialog1.ShowDialog()
                runreprint()
            Else
                succes.Image = Api.DownloadImage("http://192.168.161.102/reprint_app/images/alert/select_data_print.png")
                succes.Visible = True
                succes.Focus()
            End If

        Catch ex As Exception
            MsgBox("EROOR!!" & " " & ex.Message())
        End Try
    End Sub
End Class