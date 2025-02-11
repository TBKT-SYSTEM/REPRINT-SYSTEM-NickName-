Imports System.Runtime.InteropServices
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Public Class connect
    Public myConnectQGATE As SqlConnection
    Public myConn As SqlConnection
    Public Function connect_reprint_newfa()
        Dim myConn As SqlConnection
        Try
            myConn = New SqlConnection("Data Source=192.168.161.101;Initial Catalog=" & login_form.select_db.Text & ";Integrated Security=False;User Id=pcs_admin;Password=P@ss!fa")
            myConn.Open()
            Return myConn
        Catch ex As Exception
            MsgBox("Connect Database Fail" & System.Environment.NewLine & ex.Message, 16, "Status in")
        End Try
        Return "SORRY CONNECT FAILL"
    End Function
    Public Function connect_reprint_testnewfa()
        Dim myConn As SqlConnection
        Try
            myConn = New SqlConnection("Data Source=192.168.161.101;Initial Catalog=test_new_fa02;Integrated Security=False;User Id=pcs_admin;Password=P@ss!fa")
            myConn.Open()
            Return myConn
        Catch ex As Exception
            MsgBox("Connect Database Fail" & System.Environment.NewLine & ex.Message, 16, "Status in")
        End Try
        Return "SORRY CONNECT FAILL"
    End Function
End Class