Imports System.Data.SqlClient
Imports System.Security.Cryptography.X509Certificates

Module Koneksi
    Public connection As New SqlConnection
    Public Sub Open()
        Dim connectionString As String = "Data Source=localhost;Initial Catalog=db_hotel;User ID=mine;Password=user@123;"
        connection = New SqlConnection(connectionString)
        connection.Open()
    End Sub

    Public Sub Close()
        connection.Close()
    End Sub
End Module
