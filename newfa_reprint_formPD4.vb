Imports System.Data.SqlClient
Imports System.Drawing.Printing
Imports System.Web.Script.Serialization

Public Class newfa_reprint_formPD4
    Dim back_office As New Model
    Dim reader As SqlDataReader
    Dim status_log, wi_test, lot_tag, production_type, plan_tag, actaul_tag, next_process, wi_tag, qr_code_tag, shift_tag, seq_tag, box_tag, model_tag, part_name_tag, line_tag, part_no_tag, PD, location_tag As String

    Private Sub PictureBox3_Click_1(sender As Object, e As EventArgs) Handles PictureBox3.Click
        loadData()
    End Sub

    Dim id_log, qty_tag, ref_db, re_id_log, fa_id_log As Integer
    Dim G_boxNo As String = ""
    Private Sub PBOK_Click(sender As Object, e As EventArgs)
        menu_form.Show()
        Me.Close()
    End Sub
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PBclose.Click
        menu_form.Show()
        Me.Close()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim aPen = New Pen(Color.Black)
        aPen.Width = 2.0F
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
        'Tag Layout
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
        e.Graphics.DrawString(location_tag, lb_font5.Font, Brushes.Black, 596, 141)
        e.Graphics.DrawString("SHIFT", lb_font1.Font, Brushes.Black, 152, 178)
        e.Graphics.DrawString(shift_tag, lb_font2.Font, Brushes.Black, 170, 190)
        e.Graphics.DrawString("PRO. SEQ.", lb_font1.Font, Brushes.Black, 227, 178)
        e.Graphics.DrawString(seq_tag, lb_font2.Font, Brushes.Black, 231, 190)
        e.Graphics.DrawString("BOX NO.", lb_font1.Font, Brushes.Black, 302, 178)
        e.Graphics.DrawString(G_boxNo, lb_font2.Font, Brushes.Black, 320, 190)
        e.Graphics.DrawString("ACTUAL DATE", lb_font1.Font, Brushes.Black, 412, 178)
        e.Graphics.DrawString(actaul_tag, lb_font3.Font, Brushes.Black, 412, 196)
        Dim factory_cd As String
        If PD = "K2PD06" Then
            factory_cd = "Phase8"
        Else
            factory_cd = "Phase10"
        End If
        e.Graphics.DrawString("FACTORY", lb_font1.Font, Brushes.Black, 522, 178)
        e.Graphics.DrawString(factory_cd, lb_font3.Font, Brushes.Black, 522, 196)
        e.Graphics.DrawString("INFO.", lb_font1.Font, Brushes.Black, 612, 178)
        e.Graphics.DrawString("LINE", lb_font1.Font, Brushes.Black, 152, 238)
        e.Graphics.DrawString(line_tag, lb_font2.Font, Brushes.Black, 152, 250)

        e.Graphics.DrawString("PLAN DATE", lb_font1.Font, Brushes.Black, 302, 238)
        e.Graphics.DrawString(plan_tag, plandate.Font, Brushes.Black, 334, 255)
        e.Graphics.DrawString("LOT NO.", lb_font1.Font, Brushes.Black, 522, 238)
        e.Graphics.DrawString(lot_tag, lb_font2.Font, Brushes.Black, 522, 250)
        e.Graphics.DrawString("TBKK", lb_font2.Font, Brushes.Black, 15, 13)
        e.Graphics.DrawString("(Thailand) Co., Ltd.", lb_font1.Font, Brushes.Black, 15, 45)
        e.Graphics.DrawString("Shop floor system", lb_font4.Font, Brushes.Black, 15, 73)
        e.Graphics.DrawString("(New FA system)", lb_font4.Font, Brushes.Black, 15, 85)
        e.Graphics.DrawString("WI : " & wi_tag, lb_font6.Font, Brushes.Black, 15, 123)
        If status_log = "Incomplete Tag" Then
            e.Graphics.DrawString("[ " & status_log & "]", lb_font4.Font, Brushes.Black, 25, 172)
        End If
        production_type = back_office.product_type(wi_tag)
        e.Graphics.DrawString(production_type, lb_font6.Font, Brushes.Black, 15, 136)
        Dim generate As New MessagingToolkit.QRCode.Codec.QRCodeEncoder
        qr_code_1.Image = generate.Encode(qr_code_tag)
        e.Graphics.DrawImage(qr_code_1.Image, 597, 17, 95, 95)
        e.Graphics.DrawImage(qr_code_1.Image, 31, 190, 95, 95)
        qr_code_2.Image = generate.Encode(qr_code_tag)
        e.Graphics.DrawImage(qr_code_2.Image, 620, 199, 70, 70)
    End Sub
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        Dim i = 1
        Dim ref_line As String = menu_form.line_data.Text
        Dim ref_date As String = menu_form.DateTimePicker1.Text
        Dim date_show As String = convert(ref_date)
        Dim ref_lot_no As String = menu_form.lot_no_data.Text
        Dim ref_wi As String = menu_form.wi_data.Text
        PBclose.Visible = False
        'Try
        Dim rs As String = back_office.get_data_to_reprint_new_fa(ref_line, date_show, ref_lot_no, ref_wi)
        Try
            If rs <> "0" Then
                Dim result_data_json As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(rs)
                For Each item As Object In result_data_json
                    Dim wi = item("WI").ToString()
                    wi_test = wi
                    Dim ITEM_CD = item("ITEM_CD").ToString()
                    Dim box_no = item("BOX_NO").ToString()
                    G_boxNo = box_no
                    Dim shift = item("SHIFT").ToString()
                    Dim seq = item("SEQ_NO").ToString()
                    Dim qr_code = item("QR_DETAIL").ToString()
                    Dim status_tag = item("STATUS_TAG").ToString()
                    Dim fa_id_log = item("FA_ID").ToString()
                    Dim re_id_log As String = ""
                    Try
                        re_id_log = item("RE_ID").ToString()
                    Catch ex As Exception
                        re_id_log = 0
                    End Try
                    Dim date_detail = qr_code.Substring(44, 8)
                    Dim actaul As Date = Date.ParseExact(date_detail, "yyyyMMdd", Globalization.CultureInfo.InvariantCulture)
                    Dim actaul_show = actaul.ToString("dd/MM/yyyy")
                    Dim lot As String = qr_code.Substring(44, 18)
                    Dim lot_show = lot.Substring(lot.Length - 4)
                    Dim qt_y As String = qr_code.Substring(52, 6) 'lot.Substring(Trim(lot.Length - 7))
                    Dim qty_show = qr_code.Substring(52, 6) 'qt_y.Remove(qt_y.Length - 4)
                    Dim newitem As New ListViewItem(wi)
                    newitem.SubItems.Add(ITEM_CD)
                    newitem.SubItems.Add(actaul_show)
                    newitem.SubItems.Add(box_no)
                    newitem.SubItems.Add(seq)
                    newitem.SubItems.Add(qty_show)
                    newitem.SubItems.Add(lot_show)
                    newitem.SubItems.Add(shift)
                    newitem.SubItems.Add(qr_code)
                    newitem.SubItems.Add(status_tag)
                    newitem.SubItems.Add(fa_id_log)
                    newitem.SubItems.Add(re_id_log)
                    i += 1
                    ListView1.Items.Add(newitem)
                Next
            End If
        Catch ex As Exception

        End Try
        If wi_test = "" Then
                alert.Visible = True
                PBclose.Visible = True
            End If
            'Catch ex As Exception
        '     MsgBox(ex.Message())
        ' End Try
        ' Add any initialization after the InitializeComponent() call.
    End Sub
    Public Sub loadData()
        ListView1.Items.Clear()
        Dim i = 1
        Dim ref_line As String = menu_form.line_data.Text
        Dim ref_date As String = menu_form.DateTimePicker1.Text
        Dim date_show As String = convert(ref_date)
        Dim ref_lot_no As String = menu_form.lot_no_data.Text
        Dim ref_wi As String = menu_form.wi_data.Text
        PBclose.Visible = False
        Try
            Dim rs As String = back_office.get_data_to_reprint_new_fa(ref_line, date_show, ref_lot_no, ref_wi)
            If rs <> "" Then
                Dim result_data_json As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(rs)
                For Each item As Object In result_data_json
                    Dim wi = item("WI").ToString()
                    wi_test = wi
                    Dim ITEM_CD = item("ITEM_CD").ToString()
                    Dim box_no = item("BOX_NO").ToString()
                    G_boxNo = box_no
                    Dim shift = item("SHIFT").ToString()
                    Dim seq = item("SEQ_NO").ToString()
                    Dim qr_code = item("QR_DETAIL").ToString()
                    Dim status_tag = item("STATUS_TAG").ToString()
                    Dim fa_id_log = item("FA_ID").ToString()
                    Dim re_id_log As String = "0"
                    Try
                        re_id_log = item("RE_ID").ToString()
                    Catch ex As Exception
                        re_id_log = "0"
                    End Try
                    Dim date_detail = qr_code.Substring(44, 8)
                    Dim actaul As Date = Date.ParseExact(date_detail, "yyyyMMdd", Globalization.CultureInfo.InvariantCulture)
                    Dim actaul_show = actaul.ToString("dd/MM/yyyy")
                    Dim lot As String = qr_code.Substring(44, 18)
                    Dim lot_show = lot.Substring(lot.Length - 4)
                    Dim qt_y As String = qr_code.Substring(52, 6) 'lot.Substring(Trim(lot.Length - 7))
                    Dim qty_show = qr_code.Substring(52, 6) 'qt_y.Remove(qt_y.Length - 4)
                    Dim newitem As New ListViewItem(wi)
                    newitem.SubItems.Add(ITEM_CD)
                    newitem.SubItems.Add(actaul_show)
                    newitem.SubItems.Add(box_no)
                    newitem.SubItems.Add(seq)
                    newitem.SubItems.Add(qty_show)
                    newitem.SubItems.Add(lot_show)
                    newitem.SubItems.Add(shift)
                    newitem.SubItems.Add(qr_code)
                    newitem.SubItems.Add(status_tag)
                    newitem.SubItems.Add(fa_id_log)
                    newitem.SubItems.Add(re_id_log)
                    i += 1
                    ListView1.Items.Add(newitem)
                Next
            End If
            If wi_test = "" Then
                alert.Visible = True
                PBclose.Visible = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message())
        End Try
    End Sub

    Public Function convert(ByVal date_detail As String)
        Dim date_show1 = date_detail.Substring(0, 2)
        Dim date_show2 = date_detail.Substring(3, 2)
        Dim date_show3 = date_detail.Substring(6, 2)
        Dim date_show4 = ("20" + date_show3 + date_show2 + date_show1)
        ' MsgBox(date_show4)
        Return date_show4
    End Function
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        menu_form.Show()
        Me.Close()
    End Sub
    Public Sub in_put_log_reprint_new_fa()
        back_office.insert_new_fa_print(ref_db, id_log)
    End Sub
    Public Sub get_data()
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
                location_tag = item("LOCATION_PART").ToString()
            Next
        End If
    End Sub
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Try
            If ListView1.SelectedItems.Count > 0 Then
                wi_tag = ListView1.SelectedItems(0).SubItems(0).Text
                actaul_tag = ListView1.SelectedItems(0).SubItems(2).Text
                box_tag = ListView1.SelectedItems(0).SubItems(3).Text
                G_boxNo = box_tag
                seq_tag = ListView1.SelectedItems(0).SubItems(4).Text
                qty_tag = ListView1.SelectedItems(0).SubItems(5).Text
                lot_tag = ListView1.SelectedItems(0).SubItems(6).Text
                shift_tag = ListView1.SelectedItems(0).SubItems(7).Text
                qr_code_tag = ListView1.SelectedItems(0).SubItems(8).Text
                status_log = ListView1.SelectedItems(0).SubItems(9).Text
                fa_id_log = ListView1.SelectedItems(0).SubItems(10).Text
                If status_log = "Reprint Tag" Then
                    re_id_log = ListView1.SelectedItems(0).SubItems(11).Text
                    id_log = re_id_log
                    ref_db = 1
                Else
                    id_log = fa_id_log
                    back_office.update_print_count(id_log)
                    ref_db = 2
                End If
                reprint_fa()
                get_data()
                Dim plan As String = qr_code_tag.Substring(8, 8)
                Dim da As Date = Date.ParseExact(plan, "yyyyMMdd", Globalization.CultureInfo.InvariantCulture)
                plan_tag = da.ToString("dd/MM/yyyy")
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
                maxBox.Text = back_office.getMaxBox_reprintPD4(wi_tag, lot_tag, seq_tag)
                tbEndprint.Text = maxBox.Text
                tbStartprint.Text = G_boxNo
                Panel1.Show()
                itemcd.Text = ListView1.SelectedItems(0).SubItems(1).Text
                Lot.Text = lot_tag
                seq.Text = seq_tag
            Else
            End If
        Catch ex As Exception
            MsgBox(ex.Message())
        End Try
    End Sub
    Public Sub reprint_fa()
        Dim Model_reprint As New Model()
        next_process = Model_reprint.get_data_tag_new_fa(wi_tag)
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Panel1.Hide()
    End Sub
    Private Sub newfa_reprint_formPD4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.Visible = False
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If CDbl(Val(tbStartprint.Text)) < 1 Then
                tbStartprint.Text = 1
            End If
            If CDbl(Val(tbEndprint.Text)) > CDbl(Val(maxBox.Text)) Then
                MsgBox("คุณสามารถใส่ Box ได้สูงสุด " & maxBox.Text)
            Else
                Dim i = 1 '
                Dim count As Integer = CDbl(Val(tbEndprint.Text)) - CDbl(Val(maxBox.Text))
                If count = 0 Then
                    count = 1
                End If
                Dim ref_line As String = menu_form.line_data.Text
                Dim ref_date As String = menu_form.DateTimePicker1.Text
                Dim date_show As String = convert(ref_date)
                Dim ref_lot_no As String = Lot.Text
                Dim ref_wi As String = wi_tag
                Dim J = 1
                For CboxNo As Integer = CDbl(Val(tbStartprint.Text)) To CDbl(Val(tbEndprint.Text)) Step 1
                    Dim rs = back_office.get_data_to_reprint_new_faPD4(ref_line, date_show, ref_lot_no, ref_wi, CboxNo)
                    If rs <> "0" Then
                        Dim result_data_json As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(rs)
                        For Each item As Object In result_data_json
                            J += 1
                            Dim wi = item("WI").ToString()
                            wi_test = wi
                            Dim ITEM_CD = item("ITEM_CD").ToString()
                            Dim box_no = item("BOX_NO").ToString()
                            G_boxNo = box_no
                            Dim shift = item("SHIFT").ToString()
                            Dim seq = item("SEQ_NO").ToString()
                            Dim qr_code = item("QR_DETAIL").ToString()
                            Dim status_tag = item("STATUS_TAG").ToString()
                            Dim fa_id_log = item("FA_ID").ToString()
                            Dim re_id_log As String = ""
                            Try
                                re_id_log = item("RE_ID").ToString()
                            Catch ex As Exception
                                re_id_log = 0
                            End Try
                            Dim date_detail = qr_code.Substring(44, 8)
                            Dim actaul As Date = Date.ParseExact(date_detail, "yyyyMMdd", Globalization.CultureInfo.InvariantCulture)
                            Dim actaul_show = actaul.ToString("dd/MM/yyyy")
                            Dim lot As String = qr_code.Substring(44, 18)
                            Dim lot_show = lot.Substring(lot.Length - 4)
                            Dim qt_y As String = qr_code.Substring(52, 6) 'lot.Substring(Trim(lot.Length - 7))
                            Dim qty_show = qr_code.Substring(52, 6) 'qt_y.Remove(qt_y.Length - 4)
                            i += 1
                            wi_tag = wi
                            actaul_tag = actaul_show
                            box_tag = G_boxNo
                            seq_tag = seq
                            qty_tag = qty_show
                            lot_tag = lot_show
                            shift_tag = shift
                            qr_code_tag = qr_code
                            status_log = status_tag
                            fa_id_log = fa_id_log
                            If status_log = "Reprint Tag" Then
                                re_id_log = ListView1.SelectedItems(0).SubItems(11).Text
                                id_log = re_id_log
                                ref_db = 1
                            Else
                                id_log = fa_id_log
                                back_office.update_print_count(id_log)
                                ref_db = 2
                            End If
                            reprint_fa()
                            get_data()
                            Dim plan As String = qr_code_tag.Substring(8, 8)
                            Dim da As Date = Date.ParseExact(plan, "yyyyMMdd", Globalization.CultureInfo.InvariantCulture)
                            plan_tag = da.ToString("dd/MM/yyyy")
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
                            in_put_log_reprint_new_fa()
                        Next
                    End If
                Next
                Panel1.Hide()
            End If
        Catch ex As Exception
            MsgBox("Please Check Input Box." & ex.Message)
        End Try
    End Sub
End Class