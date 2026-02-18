Imports System.Data.SqlClient
Imports System.Drawing.Printing
Imports System.Globalization
Imports System.Web.Script.Serialization

Public Class m83_reprint_form_batch
	Dim back_office As New Model
	Dim reader As SqlDataReader
	Dim QR_Generator As New MessagingToolkit.QRCode.Codec.QRCodeEncoder
	Dim wi_ref, status_log, wi_test, lot_tag, production_type, instr_tag, plan_tag, actaul_tag, next_process, wi_tag, qr_code_tag, shift_tag, seq_tag, box_tag, model_tag, part_name_tag, line_tag, part_no_tag, PD, location_tag As String

	Private Sub m83_reprint_form_batch_Load(sender As Object, e As EventArgs) Handles MyBase.Load

	End Sub

	Private Sub Button1_Click(sender As Object, e As EventArgs)
		print_main_M83.Show()
		Me.Hide()
	End Sub

	Public Shared dateProductMat As String = ""
	Private Sub alert_Click(sender As Object, e As EventArgs) Handles alert.Click
		menu_form.Show()
		Me.Close()
	End Sub
	Dim id_log, qty_tag, ref_db, re_id_log, fa_id_log, ref_str_id, ref_end_id, log_tag_id As Integer
	Private Sub succes_Click(sender As Object, e As EventArgs) Handles succes.Click
		succes.Visible = False
	End Sub

	Private Sub succes_KeyDown(sender As Object, e As KeyEventArgs) Handles succes.KeyDown
		succes.Visible = False
	End Sub
	Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
		If ListView1.SelectedItems.Count > 0 Then
			ref_start_show.Text = ListView1.SelectedItems(0).SubItems(9).Text
			ref_end_show.Text = ListView1.SelectedItems(0).SubItems(10).Text

		Else
			succes.Image = Api.DownloadImage("http://192.168.161.102/reprint_app/images/alert/select_data_print.png")
			succes.Visible = True
			succes.Focus()
			Exit Sub
		End If
		m83_reprint_form_sub.Show()
		Me.Visible = False
	End Sub
	Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
		menu_form.Show()
		Me.Close()
	End Sub
	Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

		Dim print_tag As New print_main_M83()

		If ListView1.SelectedItems.Count > 0 Then
			wi_tag = ListView1.SelectedItems(0).SubItems(0).Text
			actaul_tag = ListView1.SelectedItems(0).SubItems(1).Text
			box_tag = ListView1.SelectedItems(0).SubItems(2).Text
			seq_tag = ListView1.SelectedItems(0).SubItems(3).Text
			lot_tag = ListView1.SelectedItems(0).SubItems(4).Text
			qty_tag = ListView1.SelectedItems(0).SubItems(5).Text
			plan_tag = ListView1.SelectedItems(0).SubItems(6).Text
			qr_code_tag = ListView1.SelectedItems(0).SubItems(7).Text
			instr_tag = ListView1.SelectedItems(0).SubItems(8).Text
			ref_str_id = ListView1.SelectedItems(0).SubItems(9).Text
			log_tag_id = ListView1.SelectedItems(0).SubItems(11).Text

			If PictureBox2 IsNot Nothing Then
				'print_tag.printTag_sub(wi_tag, actaul_tag, box_tag, seq_tag, lot_tag, qty_tag, plan_tag, qr_code_tag, instr_tag, ref_str_id, log_tag_id)
				print_tag.printTagTest(wi_tag, actaul_tag, box_tag, seq_tag, lot_tag, qty_tag, plan_tag, qr_code_tag, instr_tag, ref_str_id, log_tag_id)
			Else
				' จัดการกรณีที่ PictureBox2 เป็น null
				MessageBox.Show("PictureBox2 is not available.")
			End If


		Else
			succes.Image = Api.DownloadImage("http://192.168.161.102/reprint_app/images/alert/select_data_print.png")
			succes.Visible = True
			succes.Focus()
			Exit Sub
		End If
		'get_data()
		'PrintDocument1.Print()
		'PrintPreviewDialog1.ShowDialog()
		back_office.insert_m83_batch(log_tag_id)
	End Sub

	Public Sub New()
		InitializeComponent()
		Dim ref_wi As String = menu_form.wi_data.Text
		Dim ref_lot As String = menu_form.lot_no_data.Text
		Dim ref_date As DateTime = menu_form.DateTimePicker1.Value
		Dim date_show As String = ref_date.ToString("yyyyMMdd")
		'MsgBox(ref_date)
		'MsgBox(date_show)
		Console.WriteLine(ref_wi)
		Console.WriteLine(ref_lot)
		Console.WriteLine(date_show)
		Try
			Dim rs = back_office.get_data_to_reprint_main_m83(ref_wi, ref_lot, date_show)
			If rs <> "0" Then
				Console.WriteLine(rs)
				Dim result_data_json As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(rs)
				For Each item As Object In result_data_json
					Dim wi_no_tag As String = item("TAG_WI_NO").ToString()
					wi_ref = wi_no_tag
					Dim qr_detail As String = item("TAG_QR_DETAIL").ToString()
					Dim ref_start_id As String = item("TAG_REF_STR_ID").ToString()
					Dim ref_end_id As String = item("TAG_REF_END_ID").ToString()
					Dim tag_id As String = item("TAG_ID").ToString()
					Dim date_detail = qr_detail.Substring(44, 8)
					Dim box_no As String = qr_detail.Substring(100, 3)
					Dim seq_no As String = qr_detail.Substring(16, 3)
					Dim plan As String = qr_detail.Substring(8, 8)
					Dim part_no_tag = qr_detail.Substring(19, 20)
					Dim da As Date = Date.ParseExact(plan, "yyyyMMdd", Globalization.CultureInfo.InvariantCulture)
					Dim plan_show = da.ToString("dd/MM/yyyy")
					Dim actaul As Date = Date.ParseExact(date_detail, "yyyyMMdd", Globalization.CultureInfo.InvariantCulture)
					Dim actaul_show = actaul.ToString("dd/MM/yyyy")
					dateProductMat = actaul.ToString("yyyy-MM-dd")
					Dim lot As String = qr_detail.Substring(44, 18)
					Dim lot_show = lot.Substring(lot.Length - 4)
					Dim qt_y As String = lot.Substring(Trim(lot.Length - 7))
					Dim qty_show = qt_y.Remove(qt_y.Length - 4)
					Dim newitem As New ListViewItem(wi_no_tag)
					Console.WriteLine(qr_detail)
					newitem.SubItems.Add(actaul_show)
					newitem.SubItems.Add(box_no)
					newitem.SubItems.Add(seq_no)
					newitem.SubItems.Add(lot_show)
					newitem.SubItems.Add(qty_show)
					newitem.SubItems.Add(plan_show)
					newitem.SubItems.Add(qr_detail)
					newitem.SubItems.Add(part_no_tag.Trim & "    ")
					newitem.SubItems.Add(ref_start_id)
					newitem.SubItems.Add(ref_end_id)
					newitem.SubItems.Add(tag_id)
					ListView1.Items.Add(newitem)

				Next
			End If
			If wi_ref = "" Then
				alert.Visible = True
			End If
		Catch ex As Exception
			MsgBox(ex.Message())
			MsgBox("ok error 1")
		End Try
	End Sub

	Public Sub get_data()
		Dim Model_reprint As New Model()
		'Dim reader As SqlDataReader
		Dim rs = Model_reprint.GET_DATA_TAG_2(wi_tag)
		If rs <> "0" Then
			Dim result_data_json As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(rs)
			For Each item As Object In result_data_json
				model_tag = item("MODEL").ToString()
				part_name_tag = item("ITEM_NAME").ToString()
			Next
		End If
	End Sub
	Public Function convert(ByVal date_detail As String)
		Try
			Dim date_show1 = date_detail.Substring(0, 2)
			Dim date_show2 = date_detail.Substring(3, 2)
			Dim date_show3 = date_detail.Substring(6, 2)
			Dim date_show4 = ("20" + date_show3 + date_show2 + date_show1)
			Return date_show4
		Catch ex As Exception

		End Try
	End Function
	Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage


		Dim back_office As New Model
		Dim aPen = New Pen(Color.Black)
		aPen.Width = 2.0F
		'vertical ตรง
		e.Graphics.DrawLine(aPen, 10, 10, 10, 290)
		e.Graphics.DrawLine(aPen, 330, 58, 330, 95)
		e.Graphics.DrawLine(aPen, 460, 10, 460, 290)
		e.Graphics.DrawLine(aPen, 580, 10, 580, 290) 'QTY

		e.Graphics.DrawLine(aPen, 110, 10, 110, 290) 'QR right top
		e.Graphics.DrawLine(aPen, 700, 10, 700, 290)
		'Horizontal นอน
		e.Graphics.DrawLine(aPen, 110, 58, 580, 58)
		e.Graphics.DrawLine(aPen, 110, 95, 700, 95)
		e.Graphics.DrawLine(aPen, 10, 11, 700, 11)
		e.Graphics.DrawLine(aPen, 10, 110, 110, 110)
		e.Graphics.DrawLine(aPen, 10, 220, 110, 220)
		e.Graphics.DrawLine(aPen, 580, 67, 700, 67)
		'	e.Graphics.DrawLine(aPen, 460, 140, 700, 140)
		'	e.Graphics.DrawLine(aPen, 460, 190, 700, 190)
		'	e.Graphics.DrawLine(aPen, 460, 240, 580, 240)
		'	e.Graphics.DrawLine(aPen, 10, 289, 700, 289)
		'	e.Graphics.DrawString("TBKK", font_1.Font, Brushes.Black, 19, 15)
		'	e.Graphics.DrawString("WI : " & wi_tag, Label_wi_type.Font, Brushes.Black, 15, 60)
		'	Dim prodtype As String = back_office.product_type(wi_tag)
		'	e.Graphics.DrawString(prodtype, Label_wi_type.Font, Brushes.Black, 15, 85)
		'	e.Graphics.DrawString("Instr. Code", font_2.Font, Brushes.Black, 120, 15)
		'	e.Graphics.DrawString(instr_tag & part_name_tag, font_4.Font, Brushes.Black, 120, 35)
		'	e.Graphics.DrawString("QTY.", font_3.Font, Brushes.Black, 465, 15)
		'	e.Graphics.DrawString(qty_tag, font_qty.Font, Brushes.Black, 495, 28)
		'	e.Graphics.DrawString("MODEL", font_2.Font, Brushes.Black, 120, 60)
		'	e.Graphics.DrawString(model_tag, font_4.Font, Brushes.Black, 140, 75)
		'	e.Graphics.DrawString("NEXT PROCESS", font_2.Font, Brushes.Black, 340, 60)
		'	e.Graphics.DrawString("ISUZU", font_4.Font, Brushes.Black, 360, 75)
		'	e.Graphics.DrawString("LOCATION", font_2.Font, Brushes.Black, 465, 60)
		'	e.Graphics.DrawString("D4U10A1", font_4.Font, Brushes.Black, 485, 75)
		'	e.Graphics.DrawString("SHIFT", font_2.Font, Brushes.Black, 585, 69)
		'	e.Graphics.DrawString(back_office.get_shift(ref_str_id), font_4.Font, Brushes.Black, 625, 75)
		'	e.Graphics.DrawString("LINE", font_2.Font, Brushes.Black, 467, 98)
		'	e.Graphics.DrawString("K1M083", font_4.Font, Brushes.Black, 470, 115)
		'	e.Graphics.DrawString("PRO SEQ", font_2.Font, Brushes.Black, 585, 98)
		'	e.Graphics.DrawString(seq_tag, font_4.Font, Brushes.Black, 610, 115)
		'	e.Graphics.DrawString("PLAN DATE", font_2.Font, Brushes.Black, 465, 145)
		'	e.Graphics.DrawString(plan_tag, font_4.Font, Brushes.Black, 470, 162)
		'	e.Graphics.DrawString("BATCH NO", font_2.Font, Brushes.Black, 585, 145)
		'	e.Graphics.DrawString(box_tag, font_4.Font, Brushes.Black, 610, 162)
		'	e.Graphics.DrawString("ACTUAL DATE", font_2.Font, Brushes.Black, 465, 195)
		'	e.Graphics.DrawString(actaul_tag, font_4.Font, Brushes.Black, 470, 215)
		'	e.Graphics.DrawString("LOT NO", font_2.Font, Brushes.Black, 465, 245)
		'	e.Graphics.DrawString(lot_tag, font_4.Font, Brushes.Black, 485, 265)
		'	e.Graphics.DrawString("NO.", font_2.Font, Brushes.Black, 120, 105)
		'	e.Graphics.DrawString("Part No.", font_2.Font, Brushes.Black, 160, 105)
		'	e.Graphics.DrawString("Part Name.", font_2.Font, Brushes.Black, 250, 105)
		'	e.Graphics.DrawString("QTY", font_2.Font, Brushes.Black, 420, 105)
		'	e.Graphics.DrawLine(aPen, 110, 123, 460, 123)
		'	e.Graphics.DrawLine(aPen, 110, 210, 460, 210)
		'	Dim margin_left_no = 125
		'	Dim margin_top_no = 130
		'	Dim margin_left_item_cd = 160
		'	Dim margin_left_part_name = 250
		'	Dim margin_left_QTY = 425
		'	Dim arr_item_cd() As String = {"898244-6240", "898244-6250", "898244-6260", "898244-6270", "898244-6280"}
		'	Dim arr_qr_code_sub() As String = {"01", "02", "03", "04", "05"}
		'	For i = 1 To 5 Step 1
		'		e.Graphics.DrawString(i, font_2.Font, Brushes.Black, margin_left_no, margin_top_no)
		'		e.Graphics.DrawString(arr_item_cd(i - 1), font_2.Font, Brushes.Black, margin_left_item_cd, margin_top_no)
		'		e.Graphics.DrawString("BRACKET ASM;CAM NO" & i, font_2.Font, Brushes.Black, margin_left_part_name, margin_top_no)
		'		e.Graphics.DrawString(qty_tag, font_2.Font, Brushes.Black, margin_left_QTY, margin_top_no)
		'		margin_top_no += 15
		'	Next
		'	Dim qrcode As New MessagingToolkit.QRCode.Codec.QRCodeEncoder
		'	qrcode.QRCodeScale = 10
		'	Dim qr_by_model = 120
		'	Dim bitmap_qr_box As Bitmap = qrcode.Encode("TEST")
		'	Dim qr_by_model_left = 118
		'	Dim rs = back_office.get_qrcode_tag_sub(log_tag_id)
		'	Dim j = 1
		'	If rs <> "0" Then
		'		Dim result_data_json As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(rs)
		'		For Each item As Object In result_data_json
		'			Dim qr_code As String = item("tag_qr_detail").ToString()
		'			bitmap_qr_box = QR_Generator.Encode(qr_code)
		'			e.Graphics.DrawString("QR No ." & j, font_2.Font, Brushes.Black, qr_by_model_left, 215)
		'			e.Graphics.DrawImage(bitmap_qr_box, qr_by_model, 233, 50, 50) 'Right top
		'			qr_by_model += 70
		'			margin_top_no += 15
		'			qr_by_model_left += 70
		'			j += 1
		'		Next
		'	End If
		'	Dim qr_detail_main As Bitmap = QR_Generator.Encode(qr_code_tag)
		'	e.Graphics.DrawImage(qr_detail_main, 15, 120, 90, 90) 'left
		'	e.Graphics.DrawImage(qr_detail_main, 615, 15, 45, 45) 'Right top
		'	e.Graphics.DrawString("FACTORY", font_3.Font, Brushes.Black, 15, 230)
		'	e.Graphics.DrawString("Phase10", font_3.Font, Brushes.Black, 33, 250)
		'	e.Graphics.DrawImage(qr_detail_main, 600, 205, 75, 75) 'Right top
		succes.Image = Api.DownloadImage("http://192.168.161.102/reprint_app/images/alert/alert_success.png")
		succes.Visible = True
		succes.Focus()
	End Sub

	Private Sub ListView1_DoubleClick(sender As Object, e As EventArgs) Handles ListView1.DoubleClick
		If ListView1.SelectedItems.Count > 0 Then
			wi_tag = ListView1.SelectedItems(0).SubItems(0).Text
			actaul_tag = ListView1.SelectedItems(0).SubItems(1).Text
			box_tag = ListView1.SelectedItems(0).SubItems(2).Text
			seq_tag = ListView1.SelectedItems(0).SubItems(3).Text
			lot_tag = ListView1.SelectedItems(0).SubItems(4).Text
			qty_tag = ListView1.SelectedItems(0).SubItems(5).Text
			plan_tag = ListView1.SelectedItems(0).SubItems(6).Text
			qr_code_tag = ListView1.SelectedItems(0).SubItems(7).Text
			instr_tag = ListView1.SelectedItems(0).SubItems(8).Text
			ref_str_id = ListView1.SelectedItems(0).SubItems(9).Text
			log_tag_id = ListView1.SelectedItems(0).SubItems(11).Text
		Else
			succes.Image = Api.DownloadImage("http://192.168.161.102/reprint_app/images/alert/select_data_print.png")
			succes.Visible = True
			succes.Focus()
			Exit Sub
		End If
		get_data()
		PrintDocument1.Print()
		' PrintPreviewDialog1.ShowDialog()
		back_office.insert_m83_batch(log_tag_id)
	End Sub



End Class
