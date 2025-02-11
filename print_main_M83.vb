Imports System.Globalization
Imports System.Web.Script.Serialization
Imports System.Drawing.Printing
Imports Newtonsoft.Json

Public Class print_main_M83
	Dim QR_Generator As New MessagingToolkit.QRCode.Codec.QRCodeEncoder
	Dim back_office As New Model
	Dim dt_wi_tag, dt_actaul_tag, dt_box_tag, dt_seq_tag, dt_lot_tag, dt_qty_tag, dt_plan_tag, dt_qr_code_tag, dt_instr_tag, dt_ref_str_id, dt_log_tag_id As String

	Private Sub print_main_M83_Load(sender As Object, e As EventArgs) Handles MyBase.Load

	End Sub

	Dim sub_wi_tag, sub_actaul_tag, sub_box_tag, sub_seq_tag, sub_lot_tag, sub_qty_tag, sub_plan_tag, sub_qr_code_tag, sub_instr_tag, sub_shift_tag, sub_id_log As String

	Public Sub printTagTest(ByVal wi_tag, ByVal actaul_tag, ByVal box_tag, ByVal seq_tag, ByVal lot_tag, ByVal qty_tag, ByVal plan_tag, ByVal qr_code_tag, ByVal instr_tag, ByVal ref_str_id, ByVal log_tag_id)
		dt_wi_tag = wi_tag
		dt_actaul_tag = actaul_tag
		dt_box_tag = box_tag
		dt_seq_tag = seq_tag
		dt_lot_tag = lot_tag
		dt_qty_tag = qty_tag
		dt_plan_tag = plan_tag
		dt_qr_code_tag = qr_code_tag
		dt_instr_tag = instr_tag
		dt_ref_str_id = ref_str_id
		dt_log_tag_id = log_tag_id

		Return
		Dim printDoc As New PrintDocument()
		Dim customPaperSize As New PaperSize("Custom", 311, 713)
		printDoc.DefaultPageSettings.PaperSize = customPaperSize
		printDoc.DefaultPageSettings.Landscape = True

		AddHandler printDoc.PrintPage, AddressOf PrintPage_Handler

		PrintPreviewDialog1.Document = printDoc
		'PrintPreviewDialog1.ShowDialog()
		printDoc.Print()
	End Sub

	Public Sub printTagDummy(ByVal wi_tag As String, ByVal actaul_tag As String, ByVal box_tag As String, ByVal seq_tag As String, ByVal lot_tag As String, ByVal qty_tag_key As String, ByVal plan_tag As String, ByVal qr_code_tag As String, ByVal instr_tag As String, ByVal ref_str_id As String, ByVal log_tag_id As String)
		dt_wi_tag = wi_tag
		dt_actaul_tag = actaul_tag
		dt_box_tag = box_tag
		dt_seq_tag = seq_tag
		dt_lot_tag = lot_tag
		dt_qty_tag = qty_tag_key
		dt_plan_tag = plan_tag
		dt_qr_code_tag = qr_code_tag
		dt_instr_tag = instr_tag
		dt_ref_str_id = ref_str_id
		dt_log_tag_id = log_tag_id

		Dim printDoc As New PrintDocument()
		Dim customPaperSize As New PaperSize("Custom", 311, 713)
		printDoc.DefaultPageSettings.PaperSize = customPaperSize
		printDoc.DefaultPageSettings.Landscape = True

		AddHandler printDoc.PrintPage, AddressOf PrintPageDummy_Handler

		PrintPreviewDialog1.Document = printDoc
		'PrintPreviewDialog1.ShowDialog()
		printDoc.Print()
	End Sub

	Private Sub PrintPage_Handler(sender As Object, e As PrintPageEventArgs)
		'Dim dt_actaul_tag As String = "01/03/2024" ' Date string in "dd/MM/yyyy" format
		Dim dateFormat As String = "dd/MM/yyyy"
		Dim date_parsed As DateTime
		Dim date_plan As String
		Dim date_actaul As String

		If DateTime.TryParseExact(dt_plan_tag, dateFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, date_parsed) Then
			' Convert the DateTime object to a different string format (e.g., "yyyy-MM-dd")
			date_plan = date_parsed.ToString("yyyyMMdd")
			Console.WriteLine("Formatted Date: " & date_plan)
		Else
			date_plan = dt_plan_tag
		End If

		If DateTime.TryParseExact(dt_actaul_tag, dateFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, date_parsed) Then
			' Convert the DateTime object to a different string format (e.g., "yyyy-MM-dd")
			date_actaul = date_parsed.ToString("yyyyMMdd")
			Console.WriteLine("Formatted Date: " & date_actaul)
		Else
			date_actaul = dt_actaul_tag
		End If

		Dim aPen = New Pen(Color.Black)
		aPen.Width = 2.0F
		'vertical ตรง
		e.Graphics.DrawLine(aPen, 10, 10, 10, 290)

		e.Graphics.DrawLine(aPen, 280, 58, 280, 116) ' model

		e.Graphics.DrawLine(aPen, 460, 10, 460, 58) ' line qr
		e.Graphics.DrawLine(aPen, 420, 58, 420, 116) ' nextprocess
		e.Graphics.DrawLine(aPen, 490, 116, 490, 214) ' QTY Title

		e.Graphics.DrawLine(aPen, 310, 10, 310, 58) 'QTY
		e.Graphics.DrawLine(aPen, 595, 10, 595, 213) 'shift

		e.Graphics.DrawLine(aPen, 110, 10, 110, 116) 'Back TBKK
		e.Graphics.DrawLine(aPen, 110, 288, 110, 213) 'Factory

		e.Graphics.DrawLine(aPen, 700, 10, 700, 290)
		'Horizontal นอน

		e.Graphics.DrawLine(aPen, 110, 58, 700, 58)
		' e.Graphics.DrawLine(aPen, 110, 95, 700, 95)
		e.Graphics.DrawLine(aPen, 10, 11, 700, 11)
		'  e.Graphics.DrawLine(aPen, 10, 220, 110, 220) 'factory
		'e.Graphics.DrawLine(aPen, 595, 142, 700, 142) 'line
		e.Graphics.DrawLine(aPen, 490, 166, 700, 166) 'line ยาว
		'  e.Graphics.DrawLine(aPen, 595, 235, 700, 235) 'actual
		e.Graphics.DrawLine(aPen, 10, 289, 700, 289)
		'DATA
		e.Graphics.DrawString("TBKK", lb_font1.Font, Brushes.Black, 19, 15)
		e.Graphics.DrawString("(Thailand) Co.,Ltd. ", Label_wi_type.Font, Brushes.Black, 12, 50)
		e.Graphics.DrawString("FA System", Label_wi_type.Font, Brushes.Black, 12, 78)
		'If Working_Pro.lb_prd_type.Text = "10" Then
		'    prdtype = "PART TYPE : FG"
		'ElseIf Working_Pro.lb_prd_type.Text = "40" Then
		'    prdtype = "PART TYPE : Parts"
		'Else
		'    prdtype = "PART TYPE : FW"
		'End If

		Dim prdtype As String = "PART TYPE : FG"
		e.Graphics.DrawString(prdtype, Label_wi_type.Font, Brushes.Black, 12, 99)
		e.Graphics.DrawString("Instr. Code", lb_font5.Font, Brushes.Black, 120, 15)
		e.Graphics.DrawString("BRACKET CAM ASSY ", lb_font4_B.Font, Brushes.Black, 120, 35)
		e.Graphics.DrawString("QTY.", lb_font3.Font, Brushes.Black, 316, 15)
		e.Graphics.DrawString(dt_qty_tag, LB_QTY.Font, Brushes.Black, 363, 30)
		e.Graphics.DrawString("MODEL", lb_font5.Font, Brushes.Black, 120, 60)
		e.Graphics.DrawString("EJ40", batchModel.Font, Brushes.Black, 140, 75)
		e.Graphics.DrawString("NEXT PROCESS", lb_font5.Font, Brushes.Black, 282, 60)
		e.Graphics.DrawString("ISUZU", batchModel.Font, Brushes.Black, 305, 75)
		e.Graphics.DrawString("LOCATION", lb_font5.Font, Brushes.Black, 430, 60)
		e.Graphics.DrawString("D4U10A1", batchModel.Font, Brushes.Black, 445, 75)

		Dim shift_tag As String
		'Console.WriteLine("dt_log_tag_id" & dt_log_tag_id)
		'Console.WriteLine("date_plan" & date_plan)
		Dim rs_shift = back_office.get_data_shift_reprint_m83_main(dt_log_tag_id, date_plan)
		Dim shiftItem As List(Of ShiftItem) = JsonConvert.DeserializeObject(Of List(Of ShiftItem))(rs_shift)
		For Each item As ShiftItem In shiftItem
			shift_tag = item.pwi_shift
		Next

		e.Graphics.DrawString("SHIFT", lb_font3.Font, Brushes.Black, 460, 15)
		e.Graphics.DrawString(shift_tag, LB_QTY.Font, Brushes.Black, 520, 30)
		e.Graphics.DrawString("LINE", lb_font5.Font, Brushes.Black, 495, 124)
		e.Graphics.DrawString("K1M083", lb_font4_B.Font, Brushes.Black, 517, 140)
		e.Graphics.DrawString("PRO SEQ", lb_font5.Font, Brushes.Black, 600, 60)
		e.Graphics.DrawString(dt_seq_tag, batchModel.Font, Brushes.Black, 620, 75)
		e.Graphics.DrawString("LOT NO", lb_font3.Font, Brushes.Black, 596, 15)
		e.Graphics.DrawString(dt_lot_tag, LB_QTY.Font, Brushes.Black, 622, 30)

		e.Graphics.DrawString("PLAN DATE", lb_font5.Font, Brushes.Black, 495, 170)
		e.Graphics.DrawString(dt_plan_tag, lb_font4_B.Font, Brushes.Black, 500, 188)
		e.Graphics.DrawString("BATCH NO", lb_font5.Font, Brushes.Black, 605, 124)
		e.Graphics.DrawString(dt_box_tag, lb_font4_B.Font, Brushes.Black, 630, 140)
		e.Graphics.DrawString("ACTUAL DATE", lb_font5.Font, Brushes.Black, 605, 170)
		e.Graphics.DrawString(dt_actaul_tag, lb_font4_B.Font, Brushes.Black, 606, 188)
		e.Graphics.DrawString("NO.", lb_font5.Font, Brushes.Black, 15, 119)
		e.Graphics.DrawString("WI No.", lb_font5.Font, Brushes.Black, 85, 119)
		e.Graphics.DrawString("Part No.", lb_font5.Font, Brushes.Black, 180, 119)
		e.Graphics.DrawString("Part Name.", lb_font5.Font, Brushes.Black, 300, 119)
		e.Graphics.DrawString("QTY", lb_font5.Font, Brushes.Black, 430, 119)
		e.Graphics.DrawLine(aPen, 10, 117, 700, 117) ' start line Title
		e.Graphics.DrawLine(aPen, 10, 134, 490, 134) ' end line Title

		e.Graphics.DrawLine(aPen, 10, 213, 700, 213)
		Dim margin_left_no = 18
		Dim margin_top_no = 136
		Dim margin_top_wi = 158
		Dim margin_left_wi = 75
		Dim margin_left_item_cd = 162
		Dim margin_left_part_name = 275
		Dim margin_left_QTY = 435
		Dim arr_item_cd() As String = {"898244-6240", "898244-6250", "898244-6260", "898244-6270", "898244-6280"}
		Dim arr_qr_code_sub() As String = {"01", "02", "03", "04", "05"}
		Dim i As Integer = 1

		'######### for 5 wi
		Dim rs_wi = back_office.get_data_tag_reprint_m83(dt_wi_tag, date_plan)
		Dim specialItems As List(Of SpecialItem) = JsonConvert.DeserializeObject(Of List(Of SpecialItem))(rs_wi)
		For Each item As SpecialItem In specialItems
			Dim special_wi As String = item.WI
			Dim special_item_cd As String = item.ITEM_CD
			Dim special_item_name As String = item.ITEM_NAME

			'Console.WriteLine(special_wi)
			'Console.WriteLine(special_item_cd)
			'Console.WriteLine(special_item_name)

			e.Graphics.DrawString(i, lb_font5.Font, Brushes.Black, margin_left_no, margin_top_no)
			e.Graphics.DrawString(special_wi, lb_font5.Font, Brushes.Black, margin_left_wi, margin_top_no)
			e.Graphics.DrawString(special_item_cd, lb_font5.Font, Brushes.Black, margin_left_item_cd, margin_top_no)
			e.Graphics.DrawString(special_item_name, lb_font5.Font, Brushes.Black, margin_left_part_name, margin_top_no)
			e.Graphics.DrawString(dt_qty_tag, lb_font5.Font, Brushes.Black, margin_left_QTY, margin_top_no)
			margin_top_no += 15
			i = i + 1
		Next

		Dim qrcode As New MessagingToolkit.QRCode.Codec.QRCodeEncoder
		qrcode.QRCodeScale = 10
		Dim bitmap_qr_box As Bitmap = qrcode.Encode("TEST")
		Dim qr_by_model = 158
		Dim qr_by_model_left = 118
		Dim iden_cd As String
		Dim part_no_res1 As String
		Dim part_no_res As String
		Dim part_numm As Integer = 0
		Dim act_date As String
		Dim actdateConv As Date = DateTime.Now.ToString("dd/MM/yyyy")
		act_date = Format(actdateConv, "yyyyMMdd")

		Dim space_partno As String = ""
		For Each item As SpecialItem In specialItems
			For x As Integer = 0 To 24
				If (item.ITEM_CD.Length + space_partno.Length) < 25 Then
					space_partno &= " "
				Else
					Exit For
				End If
			Next
		Next

		Dim space_qty As String = ""
		For y As Integer = 0 To 5
			If (dt_qty_tag.Length + space_qty.Length) < 6 Then
				space_qty &= " "
			Else
				Exit For
			End If
		Next

		Dim space_lot As String = "                         "
		Dim j As Integer = 1
		For Each item As SpecialItem In specialItems
			bitmap_qr_box = QR_Generator.Encode("GB" & "K1M083" & date_plan & dt_seq_tag & item.ITEM_CD & space_partno & date_actaul & space_qty & dt_qty_tag & dt_lot_tag & space_lot & date_actaul & dt_seq_tag & "51" & dt_box_tag)
			e.Graphics.DrawString("QR No ." & j, BTitle.Font, Brushes.Black, qr_by_model_left, 215)
			e.Graphics.DrawImage(bitmap_qr_box, qr_by_model, 226, 68, 60) 'Right top
			qr_by_model += 116
			margin_top_no += 15
			qr_by_model_left += 114
			j = j + 1
		Next

		e.Graphics.DrawString("FACTORY", lb_font3.Font, Brushes.Black, 15, 230)
		e.Graphics.DrawString("Phase10", lb_font3.Font, Brushes.Black, 33, 250)

		' keep log
		'back_office.insert_m83_batch(dt_log_tag_id)

	End Sub

	Private Sub PrintPageDummy_Handler(sender As Object, e As PrintPageEventArgs)

		'Dim dt_actaul_tag As String = "01/03/2024" ' Date string in "dd/MM/yyyy" format
		Dim dateFormat As String = "dd/MM/yyyy"
		Dim date_parsed As DateTime
		Dim date_plan As String
		Dim date_actaul As String

		If DateTime.TryParseExact(dt_plan_tag, dateFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, date_parsed) Then
			' Convert the DateTime object to a different string format (e.g., "yyyy-MM-dd")
			date_plan = date_parsed.ToString("yyyyMMdd")
			Console.WriteLine("Formatted Date: " & date_plan)
		Else
			date_plan = dt_plan_tag
		End If

		If DateTime.TryParseExact(dt_actaul_tag, dateFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, date_parsed) Then
			' Convert the DateTime object to a different string format (e.g., "yyyy-MM-dd")
			date_actaul = date_parsed.ToString("yyyyMMdd")
			Console.WriteLine("Formatted Date: " & date_actaul)
		Else
			date_actaul = dt_actaul_tag
		End If

		Dim aPen = New Pen(Color.Black)
		aPen.Width = 2.0F
		'vertical ตรง
		e.Graphics.DrawLine(aPen, 10, 10, 10, 290)

		e.Graphics.DrawLine(aPen, 280, 58, 280, 116) ' model

		e.Graphics.DrawLine(aPen, 460, 10, 460, 58) ' line qr
		e.Graphics.DrawLine(aPen, 420, 58, 420, 116) ' nextprocess
		e.Graphics.DrawLine(aPen, 490, 116, 490, 214) ' QTY Title

		e.Graphics.DrawLine(aPen, 310, 10, 310, 58) 'QTY
		e.Graphics.DrawLine(aPen, 595, 10, 595, 213) 'shift

		e.Graphics.DrawLine(aPen, 110, 10, 110, 116) 'Back TBKK
		e.Graphics.DrawLine(aPen, 110, 288, 110, 213) 'Factory

		e.Graphics.DrawLine(aPen, 700, 10, 700, 290)
		'Horizontal นอน

		e.Graphics.DrawLine(aPen, 110, 58, 700, 58)
		' e.Graphics.DrawLine(aPen, 110, 95, 700, 95)
		e.Graphics.DrawLine(aPen, 10, 11, 700, 11)
		'  e.Graphics.DrawLine(aPen, 10, 220, 110, 220) 'factory
		'e.Graphics.DrawLine(aPen, 595, 142, 700, 142) 'line
		e.Graphics.DrawLine(aPen, 490, 166, 700, 166) 'line ยาว
		'  e.Graphics.DrawLine(aPen, 595, 235, 700, 235) 'actual
		e.Graphics.DrawLine(aPen, 10, 289, 700, 289)
		'DATA
		e.Graphics.DrawString("TBKK", lb_font1.Font, Brushes.Black, 19, 15)
		e.Graphics.DrawString("(Thailand) Co.,Ltd. ", Label_wi_type.Font, Brushes.Black, 12, 50)
		e.Graphics.DrawString("FA System", Label_wi_type.Font, Brushes.Black, 12, 78)
		'If Working_Pro.lb_prd_type.Text = "10" Then
		'    prdtype = "PART TYPE : FG"
		'ElseIf Working_Pro.lb_prd_type.Text = "40" Then
		'    prdtype = "PART TYPE : Parts"
		'Else
		'    prdtype = "PART TYPE : FW"
		'End If

		Dim prdtype As String = "PART TYPE : FG"
		e.Graphics.DrawString(prdtype, Label_wi_type.Font, Brushes.Black, 12, 99)
		e.Graphics.DrawString("Instr. Code", lb_font5.Font, Brushes.Black, 120, 15)
		e.Graphics.DrawString("BRACKET CAM ASSY ", lb_font4_B.Font, Brushes.Black, 120, 35)
		e.Graphics.DrawString("QTY.", lb_font3.Font, Brushes.Black, 316, 15)
		e.Graphics.DrawString(dt_qty_tag, LB_QTY.Font, Brushes.Black, 363, 30)
		e.Graphics.DrawString("MODEL", lb_font5.Font, Brushes.Black, 120, 60)
		e.Graphics.DrawString("EJ40", batchModel.Font, Brushes.Black, 140, 75)
		e.Graphics.DrawString("NEXT PROCESS", lb_font5.Font, Brushes.Black, 282, 60)
		e.Graphics.DrawString("ISUZU", batchModel.Font, Brushes.Black, 305, 75)
		e.Graphics.DrawString("LOCATION", lb_font5.Font, Brushes.Black, 430, 60)
		e.Graphics.DrawString("D4U10A1", batchModel.Font, Brushes.Black, 445, 75)

		Dim shift_tag As String
		'Console.WriteLine("dt_log_tag_id" & dt_log_tag_id)
		'Console.WriteLine("date_plan" & date_plan)
		Dim rs_shift = back_office.get_data_shift_reprint_m83_main(dt_log_tag_id, date_plan)
		Dim shiftItem As List(Of ShiftItem) = JsonConvert.DeserializeObject(Of List(Of ShiftItem))(rs_shift)
		For Each item As ShiftItem In shiftItem
			shift_tag = item.pwi_shift
		Next

		e.Graphics.DrawString("SHIFT", lb_font3.Font, Brushes.Black, 460, 15)
		e.Graphics.DrawString(shift_tag, LB_QTY.Font, Brushes.Black, 520, 30)
		e.Graphics.DrawString("LINE", lb_font5.Font, Brushes.Black, 495, 124)
		e.Graphics.DrawString("K1M083", lb_font4_B.Font, Brushes.Black, 517, 140)
		e.Graphics.DrawString("PRO SEQ", lb_font5.Font, Brushes.Black, 600, 60)
		e.Graphics.DrawString(dt_seq_tag, batchModel.Font, Brushes.Black, 620, 75)
		e.Graphics.DrawString("LOT NO", lb_font3.Font, Brushes.Black, 596, 15)
		e.Graphics.DrawString(dt_lot_tag, LB_QTY.Font, Brushes.Black, 622, 30)

		e.Graphics.DrawString("PLAN DATE", lb_font5.Font, Brushes.Black, 495, 170)
		e.Graphics.DrawString(dt_plan_tag, lb_font4_B.Font, Brushes.Black, 500, 188)
		e.Graphics.DrawString("BATCH NO", lb_font5.Font, Brushes.Black, 605, 124)
		e.Graphics.DrawString(dt_box_tag, lb_font4_B.Font, Brushes.Black, 630, 140)
		e.Graphics.DrawString("ACTUAL DATE", lb_font5.Font, Brushes.Black, 605, 170)
		e.Graphics.DrawString(dt_actaul_tag, lb_font4_B.Font, Brushes.Black, 606, 188)
		e.Graphics.DrawString("NO.", lb_font5.Font, Brushes.Black, 15, 119)
		e.Graphics.DrawString("WI No.", lb_font5.Font, Brushes.Black, 85, 119)
		e.Graphics.DrawString("Part No.", lb_font5.Font, Brushes.Black, 180, 119)
		e.Graphics.DrawString("Part Name.", lb_font5.Font, Brushes.Black, 300, 119)
		e.Graphics.DrawString("QTY", lb_font5.Font, Brushes.Black, 430, 119)
		e.Graphics.DrawLine(aPen, 10, 117, 700, 117) ' start line Title
		e.Graphics.DrawLine(aPen, 10, 134, 490, 134) ' end line Title

		e.Graphics.DrawLine(aPen, 10, 213, 700, 213)
		Dim margin_left_no = 18
		Dim margin_top_no = 136
		Dim margin_top_wi = 158
		Dim margin_left_wi = 75
		Dim margin_left_item_cd = 162
		Dim margin_left_part_name = 275
		Dim margin_left_QTY = 435
		Dim arr_item_cd() As String = {"898244-6240", "898244-6250", "898244-6260", "898244-6270", "898244-6280"}
		Dim arr_qr_code_sub() As String = {"01", "02", "03", "04", "05"}
		Dim i As Integer = 1

		'######### for 5 wi
		Dim rs_wi = back_office.get_data_tag_reprint_m83(dt_wi_tag, date_plan)
		Dim specialItems As List(Of SpecialItem) = JsonConvert.DeserializeObject(Of List(Of SpecialItem))(rs_wi)
		For Each item As SpecialItem In specialItems
			Dim special_wi As String = item.WI
			Dim special_item_cd As String = item.ITEM_CD
			Dim special_item_name As String = item.ITEM_NAME

			e.Graphics.DrawString(i, lb_font5.Font, Brushes.Black, margin_left_no, margin_top_no)
			e.Graphics.DrawString(special_wi, lb_font5.Font, Brushes.Black, margin_left_wi, margin_top_no)
			e.Graphics.DrawString(special_item_cd, lb_font5.Font, Brushes.Black, margin_left_item_cd, margin_top_no)
			e.Graphics.DrawString(special_item_name, lb_font5.Font, Brushes.Black, margin_left_part_name, margin_top_no)
			e.Graphics.DrawString(dt_qty_tag, lb_font5.Font, Brushes.Black, margin_left_QTY, margin_top_no)
			margin_top_no += 15
			i = i + 1
		Next

		Dim qrcode As New MessagingToolkit.QRCode.Codec.QRCodeEncoder
		qrcode.QRCodeScale = 10
		Dim bitmap_qr_box As Bitmap = qrcode.Encode("TEST")
		Dim qr_by_model = 158
		Dim qr_by_model_left = 118
		Dim iden_cd As String
		Dim part_no_res1 As String
		Dim part_no_res As String
		Dim part_numm As Integer = 0
		Dim act_date As String
		Dim actdateConv As Date = DateTime.Now.ToString("dd/MM/yyyy")
		act_date = Format(actdateConv, "yyyyMMdd")

		Dim space_partno As String = ""
		For Each item As SpecialItem In specialItems
			For x As Integer = 0 To 24
				If (item.ITEM_CD.Length + space_partno.Length) < 25 Then
					space_partno &= " "
				Else
					Exit For
				End If
			Next
		Next

		Dim space_qty As String = ""
		For y As Integer = 0 To 5
			If (dt_qty_tag.Length + space_qty.Length) < 6 Then
				space_qty &= " "
			Else
				Exit For
			End If
		Next

		Dim space_lot As String = "                         "
		Dim j As Integer = 1
		For Each item As SpecialItem In specialItems
			bitmap_qr_box = QR_Generator.Encode("GB" & "K1M083" & date_plan & dt_seq_tag & item.ITEM_CD & space_partno & date_actaul & space_qty & dt_qty_tag & dt_lot_tag & space_lot & date_actaul & dt_seq_tag & "51" & dt_box_tag)
			e.Graphics.DrawString("QR No ." & j, BTitle.Font, Brushes.Black, qr_by_model_left, 215)
			e.Graphics.DrawImage(bitmap_qr_box, qr_by_model, 226, 68, 60) 'Right top
			qr_by_model += 116
			margin_top_no += 15
			qr_by_model_left += 114
			j = j + 1
		Next

		e.Graphics.DrawString("FACTORY", lb_font3.Font, Brushes.Black, 15, 230)
		e.Graphics.DrawString("Phase10", lb_font3.Font, Brushes.Black, 33, 250)

		' keep log
		'back_office.insert_m83_batch(dt_log_tag_id)

	End Sub
	Public Sub printTag_sub(ByVal wi_tag, ByVal actaul_tag, ByVal box_tag, ByVal seq_tag, ByVal lot_tag, ByVal qty_tag, ByVal plan_tag, ByVal qr_code_tag, ByVal instr_tag, ByVal shift_tag, ByVal id_log)
		sub_wi_tag = wi_tag
		sub_actaul_tag = actaul_tag
		sub_box_tag = box_tag
		sub_seq_tag = seq_tag
		sub_lot_tag = lot_tag
		sub_qty_tag = qty_tag
		sub_plan_tag = plan_tag
		sub_qr_code_tag = qr_code_tag
		sub_instr_tag = instr_tag
		sub_shift_tag = shift_tag
		sub_id_log = id_log

		Dim printDoc As New PrintDocument()
		Dim customPaperSize As New PaperSize("Custom", 311, 713)
		printDoc.DefaultPageSettings.PaperSize = customPaperSize
		printDoc.DefaultPageSettings.Landscape = True

		AddHandler printDoc.PrintPage, AddressOf PrintPage_sub

		PrintPreviewDialog1.Document = printDoc
		PrintPreviewDialog1.ShowDialog()
		'PrintDocument1.Print()
	End Sub

	Public Sub PrintPage_sub(sender As Object, e As PrintPageEventArgs)
		Dim dateFormat As String = "dd/MM/yyyy"
		Dim date_parsed As DateTime
		Dim date_show As String

		If DateTime.TryParseExact(sub_plan_tag, dateFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, date_parsed) Then
			' Convert the DateTime object to a different string format (e.g., "yyyy-MM-dd")
			date_show = date_parsed.ToString("yyyyMMdd")
			Console.WriteLine("Formatted Date: " & date_show)
		Else
			date_show = sub_plan_tag
		End If


		Dim aPen = New Pen(Color.Black)
		aPen.Width = 2.0F
		e.Graphics.DrawLine(aPen, 10, 10, 10, 290)

		e.Graphics.DrawLine(aPen, 280, 58, 280, 95) ' model

		e.Graphics.DrawLine(aPen, 460, 10, 460, 58) ' line qr
		e.Graphics.DrawLine(aPen, 420, 58, 420, 95) ' nextprocess


		e.Graphics.DrawLine(aPen, 310, 10, 310, 58) 'QTY
		e.Graphics.DrawLine(aPen, 595, 10, 595, 290) 'shift

		e.Graphics.DrawLine(aPen, 110, 10, 110, 290) 'QR right top


		e.Graphics.DrawLine(aPen, 700, 10, 700, 290)
		'Horizontal นอน

		e.Graphics.DrawLine(aPen, 110, 58, 700, 58)

		e.Graphics.DrawLine(aPen, 110, 95, 700, 95)


		e.Graphics.DrawLine(aPen, 10, 11, 700, 11)
		e.Graphics.DrawLine(aPen, 10, 220, 110, 220) 'factory


		e.Graphics.DrawLine(aPen, 595, 142, 700, 142) 'line

		e.Graphics.DrawLine(aPen, 595, 183, 700, 183) 'plan

		e.Graphics.DrawLine(aPen, 595, 235, 700, 235) 'actual

		e.Graphics.DrawLine(aPen, 10, 289, 700, 289)


		'DATA
		e.Graphics.DrawString("TBKK", lb_font1.Font, Brushes.Black, 19, 15)
		e.Graphics.DrawString("(Thailand) Co.,Ltd. ", Label_wi_type.Font, Brushes.Black, 12, 50)
		e.Graphics.DrawString("FA System", Label_wi_type.Font, Brushes.Black, 12, 78)

		e.Graphics.DrawString("PART TYPE : FG", Label_wi_type.Font, Brushes.Black, 12, 105)
		e.Graphics.DrawString("Instr. Code", lb_font5.Font, Brushes.Black, 120, 15)
		e.Graphics.DrawString("BRACKET CAM ASSY ", lb_font4_B.Font, Brushes.Black, 120, 35)
		Dim result_snp As Integer = 1 'CDbl(Val(Working_Pro.Label6.Text)) Mod CDbl(Val(Working_Pro.Label27.Text))

		e.Graphics.DrawString("QTY.", lb_font3.Font, Brushes.Black, 316, 15)
		e.Graphics.DrawString(sub_qty_tag, LB_QTY.Font, Brushes.Black, 363, 30)
		e.Graphics.DrawString("MODEL", lb_font5.Font, Brushes.Black, 120, 60)
		e.Graphics.DrawString("EJ40", lb_font4_B.Font, Brushes.Black, 140, 75)
		e.Graphics.DrawString("NEXT PROCESS", lb_font5.Font, Brushes.Black, 282, 60)
		e.Graphics.DrawString("ISUZU", lb_font4_B.Font, Brushes.Black, 320, 75)
		e.Graphics.DrawString("LOCATION", lb_font5.Font, Brushes.Black, 430, 60)
		e.Graphics.DrawString("D4U10A1", lb_font4_B.Font, Brushes.Black, 460, 75)

		e.Graphics.DrawString("SHIFT", lb_font3.Font, Brushes.Black, 460, 15)
		e.Graphics.DrawString(sub_shift_tag, LB_QTY.Font, Brushes.Black, 520, 30)
		e.Graphics.DrawString("LINE", lb_font5.Font, Brushes.Black, 600, 98)
		e.Graphics.DrawString("K1M083", lb_font4_B.Font, Brushes.Black, 620, 115)
		e.Graphics.DrawString("PRO SEQ", lb_font5.Font, Brushes.Black, 600, 60)
		e.Graphics.DrawString(sub_seq_tag, lb_font4_B.Font, Brushes.Black, 640, 75)
		e.Graphics.DrawString("LOT NO", lb_font3.Font, Brushes.Black, 596, 15)
		e.Graphics.DrawString(sub_lot_tag, LB_QTY.Font, Brushes.Black, 622, 30)

		e.Graphics.DrawString("PLAN DATE", lb_font5.Font, Brushes.Black, 600, 187)
		e.Graphics.DrawString(sub_plan_tag, lb_font4_B.Font, Brushes.Black, 605, 205)
		e.Graphics.DrawString("BOX NO", lb_font5.Font, Brushes.Black, 600, 148)
		e.Graphics.DrawString(sub_box_tag, lb_font4_B.Font, Brushes.Black, 640, 159)
		e.Graphics.DrawString("ACTUAL DATE", lb_font5.Font, Brushes.Black, 600, 243)
		e.Graphics.DrawString(sub_actaul_tag, lb_font4_B.Font, Brushes.Black, 605, 258)
		e.Graphics.DrawString("NO.", lb_font5.Font, Brushes.Black, 120, 105)
		e.Graphics.DrawString("WI.", lb_font5.Font, Brushes.Black, 180, 105)
		e.Graphics.DrawString("Part No.", lb_font5.Font, Brushes.Black, 270, 105)
		e.Graphics.DrawString("Part Name.", lb_font5.Font, Brushes.Black, 400, 105)
		e.Graphics.DrawString("QTY", lb_font5.Font, Brushes.Black, 547, 105)
		e.Graphics.DrawLine(aPen, 110, 123, 595, 123)
		Dim margin_left_no = 125
		Dim margin_top_no = 140
		Dim margin_left_wi = 160
		Dim margin_left_item_cd = 250
		Dim margin_left_part_name = 357
		Dim margin_left_QTY = 553
		' For i = 1 To 5 Step 1
		'Dim Iseq As Integer = 0

		Dim i As Integer = 1
		Dim rs_wi = back_office.get_data_tag_reprint_m83(sub_wi_tag, date_show)
		'Console.WriteLine("rs_wi :" + rs_wi)
		Dim specialItems As List(Of SpecialItem) = JsonConvert.DeserializeObject(Of List(Of SpecialItem))(rs_wi)
		For Each item As SpecialItem In specialItems
			Dim special_wi As String = item.WI
			Dim special_item_cd As String = item.ITEM_CD
			Dim special_item_name As String = item.ITEM_NAME

			'Console.WriteLine(special_wi)
			'Console.WriteLine(special_item_cd)
			'Console.WriteLine(special_item_name)

			e.Graphics.DrawString(i, lb_font5.Font, Brushes.Black, margin_left_no, margin_top_no)
			e.Graphics.DrawString(special_wi, lb_font5.Font, Brushes.Black, margin_left_wi, margin_top_no)
			e.Graphics.DrawString(special_item_cd, lb_font5.Font, Brushes.Black, margin_left_item_cd, margin_top_no)
			e.Graphics.DrawString(special_item_name, lb_font5.Font, Brushes.Black, margin_left_part_name, margin_top_no)
			e.Graphics.DrawString(sub_qty_tag, lb_font5.Font, Brushes.Black, margin_left_QTY, margin_top_no)
			margin_top_no += 30
			i = i + 1
		Next

		e.Graphics.DrawString("FACTORY", lb_font3.Font, Brushes.Black, 15, 230)
		e.Graphics.DrawString("Phase10", lb_font3.Font, Brushes.Black, 33, 250)

		'back_office.insert_m83_sub(sub_id_log)
	End Sub

End Class

Public Class SpecialItem
	Public Property LINE_CD As String
	Public Property WI As String
	Public Property ITEM_CD As String
	Public Property ITEM_NAME As String
	Public Property MODEL As String
	Public Property LOCATION_PART As String
	Public Property PRODUCT_TYP As String
End Class

Public Class ShiftItem
	Public Property pwi_id As String
	Public Property ind_row As String
	Public Property pwi_lot_no As String
	Public Property pwi_seq_no As String
	Public Property pwi_shift As String
	Public Property pwi_created_date As String
	Public Property pwi_created_by As String
End Class
