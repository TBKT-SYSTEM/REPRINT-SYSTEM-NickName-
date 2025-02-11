Imports System.Data.SqlClient
Imports System.Configuration
Imports System.IO
Imports System.Windows.Forms.Form
Imports System
Imports Newtonsoft.Json
Imports System.Web.Script.Serialization
Public Class Model
    Public reader As SqlDataReader
    Public ID As Integer
    Dim id_user As String
    Dim id_perm_g As Integer
    Public Function check_user(ByVal emp_id As String)
        Try
            Dim result As Integer = 0
            Dim rs = Api.Load_data("http://192.168.161.207/API_NEW_FA/API_REPRINT_FA_APP_UPDATE/check_user?emp_id=" & Trim(emp_id))
            If rs <> "0" Then
                Dim result_data_json As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(rs)
                For Each item As Object In result_data_json
                    result = item("id").ToString()
                Next
            End If
            Return result
        Catch ex As Exception
            MsgBox("ERROR!! check_user :" & ex.Message())
        End Try
        Return 0
    End Function
    Public Function check_emp_cd(ByVal id As String)
        Try
            Dim result As Integer = 0
            Dim rs = Api.Load_data("http://192.168.161.207/API_NEW_FA/API_REPRINT_FA_APP_UPDATE/check_emp_cd?id=" & Trim(id))
            If rs <> "0" Then
                Dim result_data_json As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(rs)
                For Each item As Object In result_data_json
                    result = item("status").ToString()
                    id_perm_g = item("id_perm_g").ToString()
                Next
            End If
            Return result
        Catch ex As Exception
            MsgBox("ERROR!! check_emp_cd :" & ex.Message())
        End Try
        Return 0
    End Function
    Public Function check_status_perm()
        Try
            Dim id As Integer = id_perm_g
            Dim result As Integer = 0
            Dim rs = Api.Load_data("http://192.168.161.207/API_NEW_FA/API_REPRINT_FA_APP_UPDATE/check_status_perm?id=" & Trim(id))
            If rs <> "0" Then
                Dim result_data_json As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(rs)
                For Each item As Object In result_data_json
                    result = item("status").ToString()
                Next
            End If
            If result <> 0 Then
                result = 1
            ElseIf result = 0 Then
                result = 0
            End If
            Return result
        Catch ex As Exception
            MsgBox("ERROR!! check_status_perm :" & ex.Message())
        End Try
        Return 0
    End Function
    Public Function check_status_menu(ByVal id_user As String)
        Try
            Dim rs = Api.Load_data("http://192.168.161.207/API_NEW_FA/API_REPRINT_FA_APP_UPDATE/check_status_menu?id_user=" & Trim(id_user))
            Dim result As Integer = 0
            If rs <> "0" Then
                Dim result_data_json As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(rs)
                For Each item As Object In result_data_json
                    Result = item("status").ToString()
                Next
            End If
            If result <> 0 Then
                result = 1
            ElseIf result = 0 Then
                result = 0
            End If
            Return result
        Catch ex As Exception
            MsgBox("ERROR!! check_status_menu :" & ex.Message())
        End Try
        Return 0
    End Function
    Public Function GET_DATA_USER(ByVal emp_id As String)
        Try
            Dim rs = Api.Load_data("http://192.168.161.207/API_NEW_FA/API_REPRINT_FA_APP_UPDATE/GET_DATA_USER?id_user=" & Trim(emp_id))
            Return rs
        Catch ex As Exception
            MsgBox("ERROR!! GET_DATA_USER :" & ex.Message())
        End Try
        Return 0
    End Function
    Public Function GET_DATA_TAG(ByVal qr_code As String)
        Try
            Dim rs = Api.Load_data("http://192.168.161.207/API_NEW_FA/API_REPRINT_FA_APP_UPDATE/GET_DATA_TAG?qr_code=" & qr_code)
            Console.WriteLine("GET_DATA_TAG= ===>" & "http://192.168.161.207/API_NEW_FA/API_REPRINT_FA_APP_UPDATE/GET_DATA_TAG?qr_code=" & qr_code)
            Return rs
        Catch ex As Exception
            MsgBox("ERROR!! GET_DATA_TAG :" & ex.Message())
        End Try
        Return 0
    End Function

    Public Function get_data_tag_qrcode(ByVal qr_code As String)
        Try
            Dim rs = Api.Load_data("http://192.168.161.207/API_NEW_FA/API_REPRINT_FA_APP_UPDATE/get_data_tag_qrcode?qr_code=" & qr_code)
            Console.WriteLine("API_MODEL====>" & "http://192.168.161.207/API_NEW_FA/API_REPRINT_FA_APP_UPDATE/get_data_tag_qrcode?qr_code=" & qr_code)
            Return rs
        Catch ex As Exception
            MsgBox("ERROR!! get_data_tag_qrcode :" & ex.Message())
        End Try
        Return 0
    End Function

    Public Function get_data_log_tag_qrcode(ByVal qr_code As String)
        Try
            Dim rs = Api.Load_data("http://192.168.161.207/API_NEW_FA/API_REPRINT_FA_APP_UPDATE/get_data_log_tag_qrcode?qr_code=" & qr_code)
            Console.WriteLine("API_MODEL====>" & "http://192.168.161.207/API_NEW_FA/API_REPRINT_FA_APP_UPDATE/get_data_log_tag_qrcode?qr_code=" & qr_code)
            Return rs
        Catch ex As Exception
            MsgBox("ERROR!! get_data_tag_qrcode :" & ex.Message())
        End Try
        Return 0
    End Function
    Public Function GET_DATA_TAG_2(ByVal wi As String)
        Try
            Dim rs = Api.Load_data("http://192.168.161.207/API_NEW_FA/API_REPRINT_FA_APP_UPDATE/GET_DATA_TAG_2?wi=" & wi)
            Console.WriteLine("GET_DATA_TAG_2===>" & "http://192.168.161.207/API_NEW_FA/API_REPRINT_FA_APP_UPDATE/GET_DATA_TAG_2?wi=" & wi)
            Return rs
        Catch ex As Exception
            MsgBox("ERROR!! GET_DATA_TAG_2:" & ex.Message())
        End Try
        Return 0
    End Function
    Public Function get_data_tag_log(ByVal qr_code As String)
        Try
            Dim rs = Api.Load_data("http://192.168.161.207/API_NEW_FA/API_REPRINT_FA_APP_UPDATE/get_data_tag_log?qr_code=" & qr_code)
            Console.WriteLine("get_data_tag_log   ====>" & "http://192.168.161.207/API_NEW_FA/API_REPRINT_FA_APP_UPDATE/get_data_tag_log?qr_code=" & qr_code)
            Console.WriteLine("get_data_tag_log rs ====>" & rs)
            Return rs
        Catch ex As Exception
            MsgBox("ERROR!! get_data_tag_log :" & ex.Message())
        End Try
        Return 0
    End Function
    Public Function insert_log_print(ByVal log_ref As Integer)
        Try
            Dim userID As String = login_form.Str
            Dim rs = Api.Load_data("http://192.168.161.207/API_NEW_FA/API_REPRINT_FA_APP_UPDATE/insert_log_print?log_ref=" & log_ref & "&userID=" & userID.ToUpper())
            'MsgBox("insert_log_print rs ===>" & rs)
            Return rs
        Catch ex As Exception
            MsgBox("ERROR!! insert_log_print :" & ex.Message())
        End Try
        Return 0
    End Function
    Public Function GET_ID_MENU(ByVal wi As String)
        Try
            Dim id_menu As Integer
            Dim rs = Api.Load_data("http://192.168.161.207/API_NEW_FA/API_REPRINT_FA_APP_UPDATE/GET_ID_MENU?wi=" & Trim(wi))
            If rs <> "0" Then
                Dim result_data_json As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(rs)
                For Each item As Object In result_data_json
                    id_menu = item("id_menu").ToString()
                Next
            End If
            Return id_menu
        Catch ex As Exception
            MsgBox("ERROR!! GET_ID_MENU:" & ex.Message())
        End Try
        Return 0
    End Function
    Public Function getMaxBox_reprintPD4(wi_tag As String, lot_tag As String, seq_tag As String)
        Try
            Dim MaxBoxNo As Integer
            Dim rs = Api.Load_data("http://192.168.161.207/API_NEW_FA/API_REPRINT_FA_APP_UPDATE/getMaxBox_reprintPD4?wi_tag=" & Trim(wi_tag) & "&lot_tag=" & lot_tag & "&seq_tag=" & seq_tag)
            If rs <> "0" Then
                Dim result_data_json As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(rs)
                For Each item As Object In result_data_json
                    MaxBoxNo = item("MaxBoxNo").ToString()
                Next
            End If
            Return MaxBoxNo
        Catch ex As Exception
            MsgBox("ERROR!! getMaxBox_reprintPD4 :" & ex.Message())
        End Try
        Return 0
    End Function
    Public Function get_max_boxno(ByVal id As String)
        Try
            Dim box As String = "0"
            Dim rs = Api.Load_data("http://192.168.161.207/API_NEW_FA/API_REPRINT_FA_APP_UPDATE/get_max_boxno?id=" & Trim(id))
            If rs <> "0" Then
                Dim result_data_json As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(rs)
                For Each item As Object In result_data_json
                    box = item("box_no").ToString()
                Next
            End If
            Return box
        Catch ex As Exception
            MsgBox("ERROR!! get_max_boxno :" & ex.Message())
        End Try
        Return 0
    End Function
    'Public Function get_data_qr(ByVal id As String)
    '    Try
    '        Dim conn = New connect()
    '        Dim connect = conn.connect_reprint_newfa()
    '        Dim strCommand = "select * from log_reprint_app where log_id = " & id & ""
    '        Dim command As SqlCommand = New SqlCommand(strCommand, connect)
    '        reader = command.ExecuteReader()
    '
    '        Return reader
    '        reader.Close()
    '    Catch ex As Exception
    '        MsgBox("ERROR!! get_data_tag_log :" & ex.Message())
    'End Try
    'Return 0
    'End Function
    Public Function update_status(ByVal id As String)
        Try
            Dim rs = Api.Load_data("http://192.168.161.207/API_NEW_FA/API_REPRINT_FA_APP_UPDATE/update_status?id=" & Trim(id))
            Return 0
        Catch ex As Exception
            MsgBox("ERROR!! DB_QGATE :" & ex.Message())
        End Try
        Return 0
    End Function
    Public Function update_status_tag_print_detail(ByVal id As String)
        Try
            Dim rs = Api.Load_data("http://192.168.161.207/API_NEW_FA/API_REPRINT_FA_APP_UPDATE/update_status_tag_print_detail?id=" & Trim(id))
            Return 0
        Catch ex As Exception
            MsgBox("ERROR!! update_status_tag_print_detail :" & ex.Message())
        End Try
        Return 0
    End Function
    Public Function get_data_all(ByVal id As String)
        Try
            '  MsgBox("Trim(id)===>" & Trim(id))
            Dim rs = Api.Load_data("http://192.168.161.207/API_NEW_FA/API_REPRINT_FA_APP_UPDATE/get_data_all?id=" & Trim(id))
            Console.WriteLine("get_data_all===>" & "http://192.168.161.207/API_NEW_FA/API_REPRINT_FA_APP_UPDATE/get_data_all?id=" & Trim(id))
            Console.WriteLine("get_data_all===>" & rs)
            '   MsgBox(rs)
            'พน มา get data นี้
            Return rs
        Catch ex As Exception
            MsgBox("ERROR!! get_data_tag_log :" & ex.Message())
        End Try
        Return 0
    End Function
    Public Function get_data_all_packing(ByVal qr As String)
        Try
            '  MsgBox("Trim(id)===>" & Trim(id))
            Dim rs = Api.Load_data("http://192.168.161.207/API_NEW_FA/API_REPRINT_FA_APP_UPDATE/get_data_all_packing?qr_code=" & qr)
            Console.WriteLine("get_data_all_packing===>" & "http://192.168.161.207/API_NEW_FA/API_REPRINT_FA_APP_UPDATE/get_data_all_packing?qr_code=" & qr)
            Console.WriteLine("get_data_all_packing===>" & rs)
            '   MsgBox(rs)
            'พน มา get data นี้
            Return rs
        Catch ex As Exception
            MsgBox("ERROR!! get_data_tag_log :" & ex.Message())
        End Try
        Return 0
    End Function

    Public Function get_log_ref_id(ByVal id As String)
        Try
            Dim rs = Api.Load_data("http://192.168.161.207/API_NEW_FA/API_REPRINT_FA_APP_UPDATE/get_log_ref_id?log_qr_detail=" & Trim(id))
            Console.WriteLine("get_log_ref_id===>" & "http://192.168.161.207/API_NEW_FA/API_REPRINT_FA_APP_UPDATE/get_log_ref_id?log_qr_detail=" & Trim(id))
            '  MsgBox(rs)
            'พน มา get data นี้
            Dim box As String = "0"
            If rs <> "0" Then
                Dim result_data_json As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(rs)
                For Each item As Object In result_data_json
                    box = item("cur_box").ToString()
                Next
                Return box
            Else
                box = "0"
                Return box
            End If
        Catch ex As Exception
            MsgBox("ERROR!! get_log_ref_id :" & ex.Message())
        End Try
        Return 0
    End Function
    Public Function get_log_ref_id_1(ByVal qr As String, ByVal id As Integer)
        Try
            Dim conn = New connect()
            Dim connect = conn.connect_reprint_newfa()
            Dim rs = Api.Load_data("http://192.168.161.207/API_NEW_FA/API_REPRINT_FA_APP_UPDATE/get_log_ref_id_1?qr=" & qr & "&id=" & id)
            Console.WriteLine("get_log_ref_id_1===>" & "http://192.168.161.207/API_NEW_FA/API_REPRINT_FA_APP_UPDATE/get_log_ref_id_1?qr=" & qr & "&id=" & id)
            Console.WriteLine("result get_log_ref_id_1 === >>" & rs)
            Dim box As String = "0"
            If rs <> "0" Then
                Dim result_data_json As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(rs)
                For Each item As Object In result_data_json
                    box = item("log_id").ToString()
                Next
                Return box
            Else
                box = "0"
                Return box
            End If
        Catch ex As Exception
            MsgBox("ERROR!! get_log_ref_id_1 :" & ex.Message())
        End Try
        Return 0
    End Function
    Public Function get_log_ref_id_2(ByVal id As Integer)
        Try
            Dim conn = New connect()
            Dim connect = conn.connect_reprint_newfa()
            Dim rs = Api.Load_data("http://192.168.161.207/API_NEW_FA/API_REPRINT_FA_APP_UPDATE/get_log_ref_id_2?id=" & id)
            Console.WriteLine("get_log_ref_id_2====>" & "http://192.168.161.207/API_NEW_FA/API_REPRINT_FA_APP_UPDATE/get_log_ref_id_2?id=" & id)
            Console.WriteLine("result get_log_ref_id_2 === >>" & rs)
            Dim box As String = "0"
            If rs <> "0" Then
                Dim result_data_json As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(rs)
                For Each item As Object In result_data_json
                    box = item("log_ref_id").ToString()
                Next
                Return box
            Else
                box = "0"
                Return box
            End If
        Catch ex As Exception
            MsgBox("ERROR!! get_log_ref_id_2 :" & ex.Message())
        End Try
        Return 0
    End Function
    Public Function product_type(ByVal WI As String)
        Try
            Dim type As Integer = 0
            Dim rs = Api.Load_data("http://192.168.161.207/API_NEW_FA/API_REPRINT_FA_APP_UPDATE/product_type?wi=" & WI)
            Console.WriteLine("http://192.168.161.207/API_NEW_FA/API_REPRINT_FA_APP_UPDATE/product_type?wi=" & WI)
            If rs <> "0" Then
                Dim result_data_json As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(rs)
                For Each item As Object In result_data_json
                    type = item("PRODUCT_TYP").ToString()
                Next
                If type = 10 Then
                    Return "PART TYPE : FG"
                ElseIf type = 20 Then
                    Return "PART TYPE : RM"
                ElseIf type = 30 Then
                    Return "PART TYPE : FW"
                ElseIf type = 40 Then
                    Return "PART TYPE : Parts"
                End If
            End If
        Catch ex As Exception
            MsgBox("ERROR!! product_type :" & ex.Message())
        End Try
        Return 0
    End Function
    Public Function check_tag_type(ByVal line_cd As String)
        Try
            Dim rs = Api.Load_data("http://192.168.161.207/API_NEW_FA/API_REPRINT_FA_APP_UPDATE/check_tag_type?line_cd=" & line_cd)
            Return rs
        Catch ex As Exception
            MsgBox("ERROR!! check_tag_type :" & ex.Message())
        End Try
        Return 0
    End Function
    Public Function get_box_first_scan(ByVal qr_code_detail As String)
        Try
            Dim rs = Api.Load_data("http://192.168.161.207/API_NEW_FA/API_REPRINT_FA_APP_UPDATE/get_box_first_scan?qr_code_detail=" & qr_code_detail)
            If rs <> "0" Then
                Dim result_data_json As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(rs)
                Dim box As String = ""
                For Each item As Object In result_data_json
                    Dim num_char_box = item("box_no").ToString().Length
                    If num_char_box = 1 Then
                        box = "00" & box
                    ElseIf num_char_box = 2 Then
                        box = "0" & box
                    Else
                        box = box
                    End If
                Next
                If box <> 0 Then
                    Return box
                Else
                    Return 0
                End If
            End If
        Catch ex As Exception
        End Try
        Return 0
    End Function
    Public Function get_data_tag_log_reprint(ByVal line As String, ByVal year As String, ByVal part_no As String, ByVal lot_no As String)
        Try
            Dim rs = Api.Load_data("http://192.168.161.207/API_NEW_FA/API_REPRINT_FA_APP_UPDATE/get_data_tag_log_reprint?line=" & line & "&year=" & year & "&part_no=" & part_no & "&lot_no=" & lot_no)
            Return rs
        Catch ex As Exception
        End Try
        Return 0
    End Function
    Public Function getpd()
        Try
            Dim rs = Api.Load_data("http://192.168.161.207/API_NEW_FA/API_REPRINT_FA_APP_UPDATE/getpd")
            Return rs
        Catch ex As Exception
            MsgBox("ERROR!! getpd :" & ex.Message())
        End Try
        Return 0
    End Function
    Public Function getpd_dummytag()
        Try
            Dim rs = Api.Load_data("http://192.168.161.207/API_NEW_FA/API_REPRINT_FA_APP_UPDATE/getpd_dummytag")
            Return rs
        Catch ex As Exception
            MsgBox("ERROR!! getpd_dummytag :" & ex.Message())
        End Try
        Return 0
    End Function
    Public Function getline(ByVal pd As String)
        Try
            Dim rs = Api.Load_data("http://192.168.161.207/API_NEW_FA/API_REPRINT_FA_APP_UPDATE/getline?pd=" & pd)
            Return rs
        Catch ex As Exception
            MsgBox("ERROR!! getline :" & ex.Message())
        End Try
        Return 0
    End Function
    Public Function get_data_to_reprint_log(ByVal part_no As String, ByVal lot As String, ByVal line As String, ByVal box As Integer, ByVal qty As Integer)
        Try
            Dim conn = New connect()
            Dim connect = conn.connect_reprint_newfa()
            Dim rs = Api.Load_data("http://192.168.161.207/API_NEW_FA/API_REPRINT_FA_APP_UPDATE/get_data_to_reprint_log?part_no=" & part_no & "&line=" & line & "&lot=" & lot & "&box=" & box & "&qty=" & qty)
            Console.WriteLine("http://192.168.161.207/API_NEW_FA/API_REPRINT_FA_APP_UPDATE/get_data_to_reprint_log?part_no=" & part_no & "&line=" & line & "&lot=" & lot & "&box=" & box & "&qty=" & qty)
            ' MsgBox("GET_DATA_TAGrs ===>" & rs)
            Return rs
        Catch ex As Exception
            MsgBox("ERROR!! get_data_to_reprint_log :" & ex.Message())
        End Try
        Return 0
    End Function
    Public Function get_data_to_reprint_new_fa(ByVal line As String, ByVal actaul_date As String, ByVal lot_no As String, ByVal wi As String)
        Try
            Dim rs As String = Api.Load_data("http://192.168.161.207/API_NEW_FA/API_REPRINT_FA_APP_UPDATE/get_data_to_reprint_new_fa?line=" & line & "&actaul_date=" & actaul_date & "&lot_no=" & lot_no & "&wi=" & wi)
            Console.WriteLine("get_data_to_reprint_new_fa=====>" & "http://192.168.161.207/API_NEW_FA/API_REPRINT_FA_APP_UPDATE/get_data_to_reprint_new_fa?line=" & line & "&actaul_date=" & actaul_date & "&lot_no=" & lot_no & "&wi=" & wi)
            Console.WriteLine("get_data_to_reprint_new_fa result ====>" & rs)
            Return rs
        Catch ex As Exception
            MsgBox("ERROR!! get_data_to_reprint_log :" & ex.Message())
        End Try
        Return 0
    End Function
    Public Function get_data_to_reprint_packing(ByVal line As String, ByVal actaul_date As String, ByVal lot_no As String, ByVal wi As String)
        Try
            Dim rs As String = Api.Load_data("http://192.168.161.207/API_NEW_FA/API_REPRINT_FA_APP_UPDATE/get_data_to_reprint_packing?line=" & line & "&actaul_date=" & actaul_date & "&lot_no=" & lot_no & "&wi=" & wi)
            Console.WriteLine("get_data_to_reprint_new_fa=====>" & "http://192.168.161.207/API_NEW_FA/API_REPRINT_FA_APP_UPDATE/get_data_to_reprint_packing?line=" & line & "&actaul_date=" & actaul_date & "&lot_no=" & lot_no & "&wi=" & wi)
            Console.WriteLine("get_data_to_reprint_new_fa result ====>" & rs)
            Return rs
        Catch ex As Exception
            MsgBox("ERROR!! get_data_to_reprint_log :" & ex.Message())
        End Try
        Return 0
    End Function


    Public Function get_data_to_reprint_new_faPD4(ByVal line As String, ByVal actaul_date As String, ByVal lot_no As String, ByVal wi As String, boxNo As String)
        Try
            Dim rs = Api.Load_data("http://192.168.161.207/API_NEW_FA/API_REPRINT_FA_APP_UPDATE/get_data_to_reprint_new_faPD4?line=" & line & "&actaul_date=" & actaul_date & "&lot_no=" & lot_no & "&wi=" & wi & "&boxNo=" & boxNo)
            Console.WriteLine("get_data_to_reprint_new_fa=====>" & "http://192.168.161.207/API_NEW_FA/API_REPRINT_FA_APP_UPDATE/get_data_to_reprint_new_faPD4?line=" & line & "&actaul_date=" & actaul_date & "&lot_no=" & lot_no & "&wi=" & wi & "&boxNo=" & boxNo)
            Console.WriteLine("get_data_to_reprint_new_fa RS ======> " & rs)
            Return rs
        Catch ex As Exception
            MsgBox("ERROR!! get_data_to_reprint_new_faPD4 :" & ex.Message())
        End Try
        Return 0
    End Function
    Public Function get_data_tag_new_fa(ByVal wi As String)
        Try
            Dim rs = Api.Load_data("http://192.168.161.207/API_NEW_FA/API_REPRINT_FA_APP_UPDATE/get_data_tag_new_fa?wi=" & wi)
            Dim next_process As String = ""
            If rs <> "0" Then
                Dim result_data_json As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(rs)
                For Each item As Object In result_data_json
                    next_process = item("next_proc").ToString()
                Next
            End If
            Return next_process
        Catch ex As Exception
            MsgBox("ERROR!! get_data_tag_new_fa :" & ex.Message())
        End Try
    End Function
    Public Function next_process_packing(ByVal wi As String)
        Try
            Dim rs = Api.Load_data("http://192.168.161.207/API_NEW_FA/API_REPRINT_FA_APP_UPDATE/next_process_packing?wi=" & wi)
            Dim next_process As String = ""
            If rs <> "0" Then
                Dim result_data_json As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(rs)
                For Each item As Object In result_data_json
                    next_process = item("next_proc").ToString()
                Next
            End If
            Return next_process
        Catch ex As Exception
            MsgBox("ERROR!! get_data_tag_new_fa :" & ex.Message())
        End Try
    End Function

    Public Function insert_new_fa_print(ByVal ref_db As Integer, ByVal log_ref As Integer)
        Try
            Dim rs = Api.Load_data("http://192.168.161.207/API_NEW_FA/API_REPRINT_FA_APP_UPDATE/insert_new_fa_print?ref_db=" & ref_db & "&log_ref=" & log_ref & "&userID=" & login_form.Str.ToUpper())
            Return rs
        Catch ex As Exception
            MsgBox("ERROR!! insert_new_fa_print :" & ex.Message())
        End Try
        Return 0
    End Function
    Public Function get_data_to_reprint_main_m83(ByVal wi As String, ByVal lot_no As String, ByVal prod_date As String)
        Dim rs = Api.Load_data("http://192.168.161.207/API_NEW_FA/API_REPRINT_FA_APP_UPDATE/get_data_to_reprint_main_m83?wi=" & wi & "&lot_no=" & lot_no & "&prod_date=" & prod_date)

        Return rs
    End Function
    Public Function get_pd(ByVal wi As String)
        Try
            Dim rs = Api.Load_data("http://192.168.161.207/API_NEW_FA/API_REPRINT_FA_APP_UPDATE/get_pd?wi=" & wi)
            Dim pd As String = ""
            If rs <> "0" Then
                Dim result_data_json As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(rs)
                Dim tag_type As String = ""
                For Each item As Object In result_data_json
                    pd = item("PD").ToString()
                Next
            End If
            Return pd
        Catch ex As Exception
            MsgBox("ERROR!! get_pd :" & ex.Message())
        End Try
        Return 0
    End Function
    Public Function get_detail_tag_main(ByVal qr_code_tag As String)
        Try
            Dim rs = Api.Load_data("http://192.168.161.207/API_NEW_FA/API_REPRINT_FA_APP_UPDATE/get_detail_tag_main?qr_code=" & qr_code_tag)

            Return rs
        Catch ex As Exception
            MsgBox("ERROR!! get_qrcode_tag_sub :" & ex.Message())
        End Try
        Return 0
    End Function

    Public Function get_id_tag_print_main(ByVal qr_code As String)
        Try
            Dim rs = Api.Load_data("http://192.168.161.207/API_NEW_FA/API_REPRINT_FA_APP_UPDATE/get_id_tag_print_main?qr_code=" & Trim(qr_code))
            Dim id As Integer = 0
            If rs <> "0" Then
                Dim result_data_json As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(rs)
                Dim tag_type As String = ""
                For Each item As Object In result_data_json
                    id = item("tag_id").ToString()
                Next
            End If
            Return id
        Catch ex As Exception
            MsgBox("ERROR!! get_id_tag_print_main :" & ex.Message())
        End Try
        Return 0
    End Function
    Public Function get_qrcode_tag_sub(ByVal id As String)
        Try
            Dim rs = Api.Load_data("http://192.168.161.207/API_NEW_FA/API_REPRINT_FA_APP_UPDATE/get_qrcode_tag_sub?id=" & id)
            Console.WriteLine("BBB===>" & "http://192.168.161.207/API_NEW_FA/API_REPRINT_FA_APP_UPDATE/get_qrcode_tag_sub?id=" & id)
            Return rs
        Catch ex As Exception
            MsgBox("ERROR!! get_qrcode_tag_sub :" & ex.Message())
        End Try
        Return 0
    End Function
    ' Public Function get_part_no(ByVal wi As String)
    ' Try
    ' Dim part_no As String = ""
    ' Dim rs = Api.Load_data("http://192.168.161.207/API_NEW_FA/API_REPRINT_FA_APP_UPDATE/get_part_no?wi=" & wi)
    ' If rs <> "0" Then
    ' Dim result_data_json As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(rs)
    ' Dim tag_type As String = ""
    ' For Each item As Object In result_data_json
    '                 part_no = item("ITEM_CD").ToString()
    ' Next
    ' Return part_no
    ' End If
    ' Catch ex As Exception
    '         MsgBox("ERROR!! get_part_no :" & ex.Message())
    ' End Try
    ' Return 0
    ' End Function
    ' Public Function get_part_name(ByVal wi As String)
    ' Try
    ' Dim conn = New connect()
    ' Dim connect = conn.connect_reprint_newfa()
    ' Dim strCommand = "SELECT  ITEM_NAME FROM [dbo].[sup_work_plan_supply_dev] WHERE [WI] LIKE N'%" & wi & "%' AND [LVL] LIKE N'%1%' "
    ' Dim command As SqlCommand = New SqlCommand(strCommand, connect)
    '         reader = command.ExecuteReader()
    ' Dim part_name As String = ""
    ' Do While reader.Read
    '             part_name = reader("ITEM_NAME").ToString()
    ' Loop
    ' Return part_name
    '         reader.Close()
    ' Catch ex As Exception
    '         MsgBox("ERROR!! get_part_name :" & ex.Message())
    ' End Try
    ' Return 0
    ' End Function
    ' Public Function get_model(ByVal wi As String)
    ' Try
    ' Dim conn = New connect()
    ' Dim connect = conn.connect_reprint_newfa()
    ' Dim strCommand = "select MODEL from sup_work_plan_supply_dev where wi = '" & wi & "' and lvl = '1'"
    ' Dim command As SqlCommand = New SqlCommand(strCommand, connect)
    '         reader = command.ExecuteReader()
    ' Dim MODEL As String = ""
    ' Do While reader.Read
    '             MODEL = reader("MODEL").ToString()
    ' Loop
    ' Return MODEL
    '         reader.Close()
    ' Catch ex As Exception
    '         MsgBox("ERROR!! get_model :" & ex.Message())
    ' End Try
    ' Return 0
    ' End Function
    Public Function get_shift(ByVal ref_id As String)
        Try
            Dim shift As String = ""
            Dim rs = Api.Load_data("http://192.168.161.207/API_NEW_FA/API_REPRINT_FA_APP_UPDATE/get_shift?ref_id=" & ref_id)
            If rs <> "0" Then
                Dim result_data_json As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(rs)
                Dim tag_type As String = ""
                For Each item As Object In result_data_json
                    shift = item("SHIFT").ToString()
                Next
            End If
            Return shift
        Catch ex As Exception
            MsgBox("NOT HAVE TAG IN DATABASE:" & ex.Message())
        End Try
        Return 0
    End Function
    Public Function update_print_count(ByVal id As Integer)
        Try
            Dim rs = Api.Load_data("http://192.168.161.207/API_NEW_FA/API_REPRINT_FA_APP_UPDATE/update_print_count?id=" & id)
            Return rs
        Catch ex As Exception
            MsgBox("ERROR!! update_print_count :" & ex.Message())
        End Try
        Return 0
    End Function
    Public Function get_qrcode_detail_sub(ByVal ref_start As Integer, ByVal ref_end As Integer, dateProduct As String)
        Try
            Dim rs = Api.Load_data("http://192.168.161.207/API_NEW_FA/API_REPRINT_FA_APP_UPDATE/get_qrcode_detail_sub?ref_start=" & ref_start & "&ref_end=" & ref_end & "&dateProduct=" & dateProduct)
            Return rs
        Catch ex As Exception
            MsgBox("ERROR!! get_qrcode_detail_sub :" & ex.Message())
        End Try
        Return 0
    End Function
    Public Function insert_m83_batch(ByVal log_ref As Integer)
        Try
            Dim userID As String = login_form.Str
            Dim rs = Api.Load_data("http://192.168.161.207/API_NEW_FA/API_REPRINT_FA_APP_UPDATE/insert_m83_batch?log_ref=" & log_ref & "&user_id=" & userID.ToUpper())
            Return rs
        Catch ex As Exception
            MsgBox("ERROR!! insert_m83_batch :" & ex.Message())
        End Try
        Return 0
    End Function
    Public Function insert_m83_sub(ByVal log_ref As Integer)
        Try
            Dim rs = Api.Load_data("http://192.168.161.207/API_NEW_FA/API_REPRINT_FA_APP_UPDATE/insert_m83_sub?log_ref=" & log_ref & "&user_id=" & login_form.Str.ToUpper())
            Return rs
        Catch ex As Exception
            MsgBox("ERROR!! insert_m83_sub :" & ex.Message())
        End Try
        Return 0
    End Function
    Public Function get_data_dummytag(ByVal line As String, ByVal prod_date As String, ByVal wi As String, ByVal lot_no As String)
        Try
            Dim rs = Api.Load_data("http://192.168.161.207/API_NEW_FA/API_REPRINT_FA_APP_UPDATE/get_data_dummytag?line=" & line & "&prod_date=" & prod_date & "&wi=" & wi & "&lot_no=" & lot_no)
            Console.WriteLine("dummyyyyy==>" & "http://192.168.161.207/API_NEW_FA/API_REPRINT_FA_APP_UPDATE/get_data_dummytag?line=" & line & "&prod_date=" & prod_date & "&wi=" & wi & "&lot_no=" & lot_no)
            Return rs
        Catch ex As Exception
            MsgBox("ERROR!! getpd_dummytag :" & ex.Message())
        End Try
        Return 0
    End Function
    Public Function get_data_dummytag_m83(ByVal wi As String, ByVal lot_no As String, ByVal part_no As String)
        Try
            Dim rs = Api.Load_data("http://192.168.161.207/API_NEW_FA/API_REPRINT_FA_APP_UPDATE/get_data_dummytag_m83?wi=" & wi & "&lot_no=" & lot_no & "&wi=" & wi & "&part_no=" & part_no)
            Console.WriteLine("dummy tag 83==>" & "http://192.168.161.207/API_NEW_FA/API_REPRINT_FA_APP_UPDATE/get_data_dummytag_m83?wi=" & wi & "&lot_no=" & lot_no & "&wi=" & wi & "&part_no=" & part_no)
            Return rs
        Catch ex As Exception
            MsgBox("ERROR!! get_data_dummytag_m83 :" & ex.Message())
        End Try
        Return 0
    End Function

    Public Function get_tagtype(ByVal line As String)
        Try
            Dim rs = Api.Load_data("http://192.168.161.207/API_NEW_FA/API_REPRINT_FA_APP_UPDATE/get_tagtype?line=" & line)
            If rs <> "0" Then
                Dim result_data_json As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(rs)
                Dim tag_type As String = ""
                For Each item As Object In result_data_json
                    tag_type = item("tag_type").ToString()
                Next
                Return tag_type
            End If
        Catch ex As Exception
            MsgBox("ERROR!! get_tagtype :" & ex.Message())
        End Try
        Return 0
    End Function

    Public Async Function get_data_tag_for_dummy(ByVal wi As String, ByVal seq As String, ByVal lot_no As String) As Task(Of String)
        Try
            Dim rs = Api.Load_data("http://192.168.161.207/API_NEW_FA/API_REPRINT_FA_APP_UPDATE/get_data_tag_for_dummy?wi=" & wi & "&lot_no=" & lot_no & "&seq=" & seq)
            Console.WriteLine("DUMMY1===>" & "http://192.168.161.207/API_NEW_FA/API_REPRINT_FA_APP_UPDATE/get_data_tag_for_dummy?wi=" & wi & "&lot_no=" & lot_no & "&seq=" & seq)
            Return rs
        Catch ex As Exception
            MsgBox("ERROR!! get_data_tag_for_dummy :" & ex.Message())
        End Try
        Return 0
    End Function

    Public Function find_max_box(ByVal part_no As String, ByVal lot_no As String, ByVal line As String, ByVal seq As String)
        Try
            Dim rs = Api.Load_data("http://192.168.161.207/API_NEW_FA/API_REPRINT_FA_APP_UPDATE/find_max_box?part_no=" & part_no & "&lot_no=" & lot_no & "&line=" & line & "&seq=" & seq)
            Console.WriteLine("find_max_box===>" & "http://192.168.161.207/API_NEW_FA/API_REPRINT_FA_APP_UPDATE/find_max_box?part_no=" & part_no & "&lot_no=" & lot_no & "&line=" & line & "&seq=" & seq)
            If rs <> "0" Then
                Dim result_data_json As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(rs)
                Dim box As Integer
                For Each item As Object In result_data_json
                    box = item("box_no").ToString()
                Next
                If box <> 0 Then
                    Return box
                Else
                    Return 0
                End If
            End If
        Catch ex As Exception
        End Try
        Return 0
    End Function

    Public Function find_max_box_test(ByVal part_no As String, ByVal lot_no As String, ByVal line As String, ByVal seq As String)
        Try
            Dim rs = Api.Load_data("http://192.168.161.207/API_NEW_FA/API_REPRINT_FA_APP_UPDATE/find_max_box_test?part_no=" & part_no & "&lot_no=" & lot_no & "&line=" & line & "&seq=" & seq)
            Console.WriteLine("find_max_box===>" & "http://192.168.161.207/API_NEW_FA/API_REPRINT_FA_APP_UPDATE/find_max_box_test?part_no=" & part_no & "&lot_no=" & lot_no & "&line=" & line & "&seq=" & seq)
            If rs <> "0" Then
                Dim result_data_json As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(rs)
                Dim box As Integer
                For Each item As Object In result_data_json
                    box = item("box_no").ToString()
                Next
                If box <> 0 Then
                    Return box
                Else
                    Return 0
                End If
            End If
        Catch ex As Exception
        End Try
        Return 0
    End Function

    Public Function insert_dummy_tag(ByVal id As Integer, ByVal cur_qty As Integer, ByVal new_qty As String, ByVal cur_box As Integer, ByVal new_box As Integer, ByVal next_process As String, ByVal qr_detail As String)
        Try
            Dim rs = Api.Load_data("http://192.168.161.207/API_NEW_FA/API_REPRINT_FA_APP_UPDATE/insert_dummy_tag?id=" & id & "&cur_qty=" & cur_qty & "&new_qty=" & new_qty & "&cur_box=" & cur_box & "&new_box=" & new_box & "&next_process=" & next_process & "&qr_detail=" & qr_detail & "&user_id=" & login_form.Str)
            Return rs
        Catch ex As Exception
            MsgBox("ERROR!! insert_dummy_tag :" & ex.Message())
        End Try
        Return 0
    End Function
    Public Function insert_dummy_tag_test(ByVal id As Integer, ByVal cur_qty As Integer, ByVal new_qty As String, ByVal cur_box As Integer, ByVal new_box As Integer, ByVal next_process As String, ByVal qr_detail As String)
        Try
            Dim rs = Api.Load_data("http://192.168.161.207/API_NEW_FA/API_REPRINT_FA_APP_UPDATE/insert_dummy_tag_test?id=" & id & "&cur_qty=" & cur_qty & "&new_qty=" & new_qty & "&cur_box=" & cur_box & "&new_box=" & new_box & "&next_process=" & next_process & "&qr_detail=" & qr_detail & "&user_id=" & login_form.Str)
            Return rs
        Catch ex As Exception
            MsgBox("ERROR!! insert_dummy_tag :" & ex.Message())
        End Try
        Return 0
    End Function
    Public Function insert_dummy_tag2(ByVal id As Integer, ByVal cur_qty As Integer, ByVal new_qty As String, ByVal cur_box As Integer, ByVal new_box As Integer, ByVal next_process As String, ByVal qr_detail As String)
        Try
            Dim rs = Api.Load_data("http://192.168.161.207/API_NEW_FA/API_REPRINT_FA_APP_UPDATE/insert_dummy_tag2?id=" & id & "&cur_qty=" & cur_qty & "&new_qty=" & new_qty & "&cur_box=" & cur_box & "&new_box=" & new_box & "&next_process=" & next_process & "&qr_detail=" & qr_detail & "&user_id=" & login_form.Str)
            Return rs
        Catch ex As Exception
            MsgBox("ERROR!! insert_dummy_tag2 :" & ex.Message())
        End Try
        Return 0
    End Function
    Public Function insert_scan_tag(ByVal id As Integer, ByVal cur_qty As Integer, ByVal new_qty As String, ByVal cur_box As Integer, ByVal new_box As Integer, ByVal next_process As String, ByVal qr_detail As String)
        Try
            Dim rs = Api.Load_data("http://192.168.161.207/API_NEW_FA/API_REPRINT_FA_APP_UPDATE/insert_scan_tag?id=" & id & "&cur_qty=" & cur_qty & "&new_qty=" & new_qty & "&cur_box=" & cur_box & "&new_box=" & new_box & "&next_process=" & next_process & "&qr_detail=" & qr_detail & "&user_id=" & login_form.Str)
            Return rs
        Catch ex As Exception
            MsgBox("ERROR!! insert_scan_tag :" & ex.Message())
        End Try
        Return 0
    End Function

    Public Function get_data_tag_reprint_m83(ByVal wi As String, ByVal prod_date As String)
        Try
            Console.WriteLine("wi :" + wi)
            Console.WriteLine("prod_date :" + prod_date)
            Dim rs = Api.Load_data("http://192.168.161.207/API_NEW_FA/API_REPRINT_FA_APP_UPDATE/get_data_tag_reprint_m83?wi=" & wi & "&prod_date=" & prod_date)
            Console.WriteLine("get_data_tag_reprint_m83 :" + rs)
            Return rs
        Catch ex As Exception
            MsgBox("ERROR!! get_data_tag_reprint_m83 :" & ex.Message())
        End Try
        Return 0
    End Function

    Public Function get_data_shift_reprint_m83_main(ByVal id As String, ByVal prod_date As String)
        Try
            Dim rs = Api.Load_data("http://192.168.161.207/API_NEW_FA/API_REPRINT_FA_APP_UPDATE/get_data_shift_reprint_m83_main?id=" & id & "&prod_date=" & prod_date)
            Return rs
        Catch ex As Exception
            MsgBox("ERROR!! insert_scan_tag :" & ex.Message())
        End Try
        Return 0
    End Function




End Class
