Imports System.Data.SqlClient
Imports System.Drawing.Printing
Imports System.Web.Script.Serialization
Imports Newtonsoft.Json.Linq

Public Class reprint_qgate
    Dim back_office As New Model
    Dim qr_code As String


    Private Sub reprint_qgate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inputQRcode.Focus()
        labelProducts.Visible = False
        labelDMC1.Visible = False
        labelDMC2.Visible = False
        labelDMC3.Visible = False
        labelDMC4.Visible = False
        labelDMC5.Visible = False
        labelDMC6.Visible = False
        labelShipping.Visible = False
        labelStatus.Visible = False
        labelDateShipped.Visible = False
        labelTag.Visible = False
        DragFormHelper.EnableDrag(Me)
    End Sub

    Private Sub buttonClose_Click(sender As Object, e As EventArgs) Handles buttonClose.Click
        menu_form.Show()
        Me.Close()
    End Sub

    Private Sub buttonSearch_Click(sender As Object, e As EventArgs) Handles buttonSearch.Click
        Dim select_function As String = ""
        qr_code = inputQRcode.Text
        Dim count_tag As Integer
        count_tag = back_office.get_count_tag(qr_code)
        labelTag.Text = count_tag

        ' Use a more flexible approach for determining the function to call
        If qr_code.Length = 103 Then
            select_function = back_office.get_data_qgate_tag(qr_code)
        ElseIf qr_code.Length = 25 Then
            select_function = back_office.get_data_qgate_dmc(qr_code)
        Else
            MsgBox("Format not found")
            Return ' Exit the subroutine if the format is incorrect
        End If

        Try
            Dim result = select_function
            Dim jsonString As String = ""

            If result <> "0" Then
                ' Extract the valid JSON substring
                Dim jsonStartIndex As Integer = result.IndexOf("["c)

                If jsonStartIndex <> -1 Then
                    jsonString = result.Substring(jsonStartIndex)
                Else
                    MsgBox("Error: JSON data not found.")
                    Return ' Exit the subroutine if JSON is not found
                End If

                ' Deserialize the JSON
                Dim result_data_json As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(jsonString)

                ' Ensure we have at most 6 records to assign to labels
                Dim maxLabels As Integer = Math.Min(result_data_json.Count, 6)
                For i As Integer = 0 To maxLabels - 1
                    Dim item As Object = result_data_json(i)
                    Dim qrProm As String = item("QR_PROM").ToString()
                    Dim produnct_id As String = item("ID").ToString()

                    ' Use an array of labels for assignment
                    Dim labels() As Label = {labelDMC1, labelDMC2, labelDMC3, labelDMC4, labelDMC5, labelDMC6}
                    Dim labels_id() As Label = {labelIdDMC1, labelIdDMC2, labelIdDMC3, labelIdDMC4, labelIdDMC5, labelIdDMC6}

                    ' Assign QR_PROM to the corresponding label
                    labels(i).Text = qrProm
                    labels(i).Visible = True
                    labels_id(i).Text = produnct_id
                    labels_id(i).Visible = False
                Next

                labelProducts.Visible = True
                labelTag.Visible = True
            Else
                MsgBox("No data found.")
            End If

        Catch ex As Exception
            MsgBox("Error: " & ex.Message())
        End Try
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If qr_code = "" Then
            MsgBox("Please Scan QRcode")
            Return
        End If
        ' Initialize variables
        Dim select_function As String = ""
        Dim LB_PART_NO As String = ""
        Dim LB_PART_NAME As String = ""
        Dim LB_MODEL As String = ""
        Dim LB_LOT As String = ""
        Dim LB_COUNTBOX As String = ""
        Dim box_qr As String = ""
        Dim LB_SNP As String = "6" ' Default value
        Dim LB_Hide_QR_FA_SCAN As String = ""
        Dim max_box As Integer = 0
        Dim QR_PRODUCT_SCAN As String = ""
        Dim default_box As Integer = 0
        Dim COUNT_TEXTBOX As String = "6" ' Default value
        Dim para_shift As String = ""
        Dim cus_item As String = ""
        Dim lo As String = ""
        Dim date_check As String = ""
        Dim createdDate As DateTime
        Dim createdTime As TimeSpan
        Dim status_print As String = "1"
        Dim lProd As String = ""

        ' Check QR code length and determine function to call
        If qr_code.Length = 103 Then

            ' select_function = back_office.get_data_qgate_print_tag(qr_code)
        ElseIf qr_code.Length = 25 Then

            select_function = back_office.dmc_get_data_qgate(qr_code)
        Else
            MsgBox("ไม่พบข้อมูล")
            Return ' Exit if the format is incorrect
        End If

        ' Process JSON result
        If select_function <> "0" Then
            Try
                Dim result_data_json As List(Of Dictionary(Of String, Object)) =
                    New JavaScriptSerializer().Deserialize(Of List(Of Dictionary(Of String, Object)))(select_function)

                ' Extract values from JSON
                For Each item As Dictionary(Of String, Object) In result_data_json
                    LB_PART_NO = If(item.ContainsKey("TAG_OK_ITEM_CD"), item("TAG_OK_ITEM_CD").ToString(), "")
                    LB_LOT = If(item.ContainsKey("TAG_OK_LOT_NO"), item("TAG_OK_LOT_NO").ToString(), "")
                    LB_Hide_QR_FA_SCAN = If(item.ContainsKey("TAG_OK_QR"), item("TAG_OK_QR").ToString(), "")

                    ' Try to parse BOX_NO
                    If item.ContainsKey("BOX_NO") Then
                        Integer.TryParse(item("BOX_NO").ToString(), max_box)

                        default_box = max_box
                        LB_COUNTBOX = default_box
                    End If

                    QR_PRODUCT_SCAN = "REF_ID " & labelIdDMC1.Text & " " & labelIdDMC2.Text & " " &
                                      labelIdDMC3.Text & " " & labelIdDMC4.Text & " " & labelIdDMC5.Text & " " & labelIdDMC6.Text

                    lo = LB_LOT
                    date_check = If(item.ContainsKey("CREATED_DATE"), item("CREATED_DATE").ToString(), "")

                    ' Handle Created Date & Shift Calculation
                    If item.ContainsKey("CREATED_DATE") AndAlso DateTime.TryParse(item("CREATED_DATE").ToString(), createdDate) Then
                        createdTime = createdDate.TimeOfDay
                        para_shift = If(createdTime >= TimeSpan.FromHours(8) AndAlso createdTime < TimeSpan.FromHours(20), "A", "B")
                    End If

                    lProd = LB_LOT
                Next

                Dim last_three As String = LB_Hide_QR_FA_SCAN.Substring(LB_Hide_QR_FA_SCAN.Length - 3)
                box_qr = last_three.TrimStart("0"c) ' Remove leading zeros

                ' Fetch Customer Item Data
                cus_item = back_office.get_cus_item(LB_PART_NO)

                ' Fetch Supply Plan Data
                Dim rusult = back_office.get_data_sup_work_plan_supply(LB_PART_NO)

                If rusult <> "0" Then
                    Dim result_data As List(Of Dictionary(Of String, Object)) =
                        New JavaScriptSerializer().Deserialize(Of List(Of Dictionary(Of String, Object)))(rusult)

                    ' Extract ITEM_NAME & MODEL from JSON
                    For Each item1 As Dictionary(Of String, Object) In result_data
                        LB_PART_NAME = If(item1.ContainsKey("ITEM_NAME"), item1("ITEM_NAME").ToString(), "")
                        LB_MODEL = If(item1.ContainsKey("MODEL"), item1("MODEL").ToString(), "")
                    Next
                Else
                    MsgBox("No data found for supply plan.")
                End If

            Catch ex As Exception
                MsgBox("Error processing data: " & ex.Message)
                Return ' Exit if there's an error to prevent incorrect data from being processed
            End Try
        End If
        ' Call print function with extracted parameters

        Dim print_tag As New Print()
        print_tag.Set_parameter_print(
            LB_PART_NO, LB_PART_NAME, LB_MODEL, LB_LOT, box_qr, LB_SNP,
            LB_Hide_QR_FA_SCAN, max_box, QR_PRODUCT_SCAN, default_box, COUNT_TEXTBOX,
            para_shift, cus_item, lo, date_check, status_print, lProd
        )
        inputQRcode.Text = Nothing
        labelDMC1.Text = Nothing
        labelDMC2.Text = Nothing
        labelDMC3.Text = Nothing
        labelDMC4.Text = Nothing
        labelDMC5.Text = Nothing
        labelDMC6.Text = Nothing
        labelTag.Text = Nothing
    End Sub


End Class

