Imports System.Data.SqlClient

Public Class DashboardControl

    Sub ReservasiHariIni()
        Koneksi.Open()
        Dim query = "SELECT COUNT(*) AS TotalTransaksi
                FROM tb_reservasi
                WHERE CONVERT(DATE, created_at) = CONVERT(DATE, GETDATE());"
        Dim command As New SqlCommand(query, connection)
        Dim reader As SqlDataReader = command.ExecuteReader()
        If reader.HasRows Then
            If reader.Read() Then
                Label3.Text = reader.GetInt32(0)
            End If
        End If
        Koneksi.Close()
    End Sub

    Sub ReservasiBulanIni()
        Koneksi.Open()
        Dim query As String = "SELECT COUNT(*) AS TotalTransaksi
                FROM tb_reservasi
                WHERE MONTH(created_at) = MONTH(GETDATE()) AND YEAR(created_at) = YEAR(GETDATE());"
        Dim command As New SqlCommand(query, connection)
        Dim reader As SqlDataReader = command.ExecuteReader()
        If reader.HasRows Then
            If reader.Read() Then
                Label4.Text = reader.GetInt32(0)
            End If
        End If
        Koneksi.Close()
    End Sub

    Sub TamuCheckIn()
        Koneksi.Open()
        Dim query As String = "SELECT COUNT(*)
                FROM tb_reservasi
                WHERE checkin = 1 and checkout = 0"
        Dim command As New SqlCommand(query, connection)
        Dim reader As SqlDataReader = command.ExecuteReader()
        If reader.HasRows Then
            If reader.Read() Then
                Label5.Text = reader.GetInt32(0)
            End If
        End If
    End Sub

    Sub TamuHariIni()
        Koneksi.Open()
        Dim query = "SELECT COUNT(*) AS TotalTransaksi
                FROM tb_reservasi
                WHERE CONVERT(DATE, created_at) = CONVERT(DATE, GETDATE());"
        Dim command As New SqlCommand(query, connection)
        Dim reader As SqlDataReader = command.ExecuteReader()
        If reader.HasRows Then
            If reader.Read() Then
                Label6.Text = reader.GetInt32(0)
            End If
        End If
        Koneksi.Close()
    End Sub

    Sub SemuaTamu()
        Koneksi.Open()
        Dim query As String = "SELECT COUNT(*) FROM tb_tamu"
        Dim command As New SqlCommand(query, connection)
        Dim reader As SqlDataReader = command.ExecuteReader()
        If reader.HasRows Then
            If reader.Read() Then
                Label7.Text = reader.GetInt32(0)
            End If
        End If
        Koneksi.Close()
    End Sub

    Sub TamuBulanIni()
        Koneksi.Open()
        Dim query As String = "SELECT COUNT(*) FROM tb_tamu WHERE MONTH(created_at) = MONTH(GETDATE()) AND YEAR(created_at) = YEAR(GETDATE());"
        Dim command As New SqlCommand(query, connection)
        Dim reader As SqlDataReader = command.ExecuteReader()
        If reader.HasRows Then
            If reader.Read() Then
                Label8.Text = reader.GetInt32(0)
            End If
        End If
        Koneksi.Close()
    End Sub

    Sub KamarTerpakai()
        Koneksi.Open()
        Dim query As String = "SELECT COUNT(*) FROM tb_kamar WHERE tersedia = 'Tidak Tersedia'"
        Dim command As New SqlCommand(query, connection)
        Dim reader As SqlDataReader = command.ExecuteReader()
        If reader.HasRows Then
            If reader.Read() Then
                Label9.Text = reader.GetInt32(0)
            End If
        End If
        Koneksi.Close()
    End Sub

    Sub KamarTersedia()
        Koneksi.Open()
        Dim query As String = "SELECT COUNT(*) FROM tb_kamar WHERE tersedia = 'Tersedia'"
        Dim command As New SqlCommand(query, connection)
        Dim reader As SqlDataReader = command.ExecuteReader()
        If reader.HasRows Then
            If reader.Read() Then
                Label10.Text = reader.GetInt32(0)
            End If
        End If
        Koneksi.Close()
    End Sub

    Sub Start()
        Call ReservasiHariIni()
        Call ReservasiBulanIni()
        Call TamuCheckIn()
        Call TamuHariIni()
        Call SemuaTamu()
        Call TamuBulanIni()
        Call KamarTerpakai()
        Call KamarTersedia()
    End Sub

    Private Sub DashboardControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

End Class
