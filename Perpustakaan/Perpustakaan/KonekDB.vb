Imports System.Data.SqlClient

Module KonekDB
    Public Conn As SqlConnection
    Public cmd As SqlCommand
    Public Da As SqlDataAdapter
    Public Dr As SqlDataReader
    Public Ds As DataSet

    Sub Koneksi()
        Dim Source As String
        Source = "Data Source =LAPTOP-4OA8EOBS\SQLEXPRESS;initial catalog= DB_Perpus;integrated security=true"
        Conn = New SqlConnection(Source)
        If Conn.State = ConnectionState.Closed Then
            Conn.Open()
        End If
    End Sub

End Module
