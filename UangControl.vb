Imports System.Data.SqlClient

Public Class UangControl
    Public IdPengeluaran As String

    Sub LabaBulaniIni()
        Koneksi.Open()
        Dim query As String = "SELECT SUM([tagihan]) AS PendapatanPerHari
FROM [tb_reservasi]
WHERE CONVERT(DATE, [created_at]) = CONVERT(DATE, GETDATE());"
        Dim command As New SqlCommand(query, connection)
        Dim reader As SqlDataReader = command.ExecuteReader()
        If reader.Read() Then
            Try
                Dim aku As Decimal = reader.GetDecimal(0)
                If aku = 0 Then
                    Label4.Text = "0"
                Else
                    Label4.Text = reader.GetDecimal(0).ToString()
                End If
            Catch ex As Exception
                Label4.Text = "0"
            End Try
        End If
    End Sub

    Sub LabahariIni()
        Koneksi.Open()
        Dim query As String = "SELECT SUM([tagihan]) AS PendapatanPerBulan
FROM [tb_reservasi]
WHERE MONTH([created_at]) = MONTH(GETDATE()) AND YEAR([created_at]) = YEAR(GETDATE());"
        Dim command As New SqlCommand(query, connection)
        Dim reader As SqlDataReader = command.ExecuteReader()
        If reader.Read() Then
            Try
                Dim aku As Decimal = reader.GetDecimal(0)
                If aku = 0 Then
                    Label3.Text = "0"
                Else
                    Label3.Text = reader.GetDecimal(0).ToString()
                End If
            Catch ex As Exception
                Label3.Text = "0"
            End Try
        End If
    End Sub

    Sub OuthariIni()
        Koneksi.Open()
        Dim query As String = "SELECT SUM([total_pengeluaran]) AS PendapatanPerBulan
FROM [tb_keuangan]
WHERE MONTH([created_at]) = MONTH(GETDATE()) AND YEAR([created_at]) = YEAR(GETDATE());"
        Dim command As New SqlCommand(query, connection)
        Dim reader As SqlDataReader = command.ExecuteReader()
        If reader.Read() Then
            Try
                Dim aku As Decimal = reader.GetDecimal(0)
                If aku = 0 Then
                    Label5.Text = "0"
                Else
                    Label5.Text = reader.GetDecimal(0).ToString()
                End If
            Catch ex As Exception
                Label5.Text = "0"
            End Try
        End If
    End Sub

    Sub OutBulaniIni()
        Koneksi.Open()
        Dim query As String = "SELECT SUM([total_pengeluaran]) AS PendapatanPerHari
FROM [tb_keuangan]
WHERE CONVERT(DATE, [created_at]) = CONVERT(DATE, GETDATE());"
        Dim command As New SqlCommand(query, connection)
        Dim reader As SqlDataReader = command.ExecuteReader()
        If reader.Read() Then
            Try
                Dim aku As Decimal = reader.GetDecimal(0)
                If aku = 0 Then
                    Label6.Text = "0"
                Else
                    Label6.Text = reader.GetDecimal(0).ToString()
                End If
            Catch ex As Exception
                Label6.Text = "0"
            End Try
        End If
    End Sub

    Sub ClearForm()
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub

    Sub CloseForm()
        TextBox1.Enabled = False
        TextBox2.Enabled = False

    End Sub
    Sub OpenForm()
        TextBox1.Enabled = True
        TextBox2.Enabled = True
    End Sub
    Sub Start()
        Button1.Text = "Tambah"
        Button2.Text = "Edit"
        Button3.Text = "Hapus"
        Button4.Text = "Hapus"
        Button4.Enabled = False
        TextBox1.Enabled = False
        TextBox2.Enabled = False
        Call ViewData()
        Call CloseForm()
        Call ClearForm()
        Call LabahariIni()
        Call LabaBulaniIni()
        Call OuthariIni()
        Call OutBulaniIni()
    End Sub

    Sub ViewData()
        Koneksi.Open()
        Dim query As String = "SELECT * FROM tb_keuangan"
        Dim command As New SqlCommand(query, connection)
        Dim reader As SqlDataReader = command.ExecuteReader()
        Dim dataTable As New DataTable()
        dataTable.Load(reader)
        DataGridView1.DataSource = dataTable
        Koneksi.Close()
    End Sub
    Private Sub UangControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Button1.Text = "Tambah" Then
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = True
            Call OpenForm()
        Else
            If TextBox1.Text = "" Or TextBox2.Text = "" Then
                MsgBox("Pastikan Semua Fornm Telah Terisi!", vbQuestion + vbOKOnly, "Peringatan")
                Return
            End If
            Koneksi.Open()
            Dim query As String = "INSERT INTO [tb_keuangan] (total_pengeluaran,deskripsi,created_at) VALUES
                    (@tot,@des,getdate())"
            Dim command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@tot", TextBox1.Text)
            command.Parameters.AddWithValue("@des", TextBox2.Text)
            command.ExecuteNonQuery()
            MsgBox("Data Pengeluaran Berhasil di Tambah", vbQuestion + vbOKOnly, "Berhasil")
            Call Start()
            Koneksi.Close()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Button2.Text = "Edit" Then
            Button1.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = True
            Call OpenForm()
        Else
            If TextBox1.Text = "" Or TextBox2.Text = "" Then
                MsgBox("Pastikan Semua Fornm Telah Terisi!", vbQuestion + vbOKOnly, "Peringatan")
                Return
            End If
            Koneksi.Open()
            Dim query As String = "UPDATE [tb_keuangan] SET
            [total_pengeluaran] = @tot, [deskripsi] = @des , [updated_at] = getdate()"
            Dim command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@tot", TextBox1.Text)
            command.Parameters.AddWithValue("@des", TextBox2.Text)
            command.ExecuteNonQuery()
            MsgBox("Date Pengeluaran Berhasil di Perbarui !", vbQuestion + vbOKOnly, "Berhasil")
            Call Start()
            Koneksi.Close()
        End If
    End Sub


    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim cok As String
        If e.RowIndex > 0 Then
            cok = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString()
            IdPengeluaran = cok
            cok = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString()
            TextBox1.Text = cok
            cok = DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString()
            TextBox2.Text = cok
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Pilih Data yang mau dihapus", vbQuestion + vbOKOnly)
            Return
        End If
        Dim njir As MsgBoxResult
        njir = MsgBox("Yakin Ingin Menghapus Data Pengeluaran ID : " + IdPengeluaran + " ?", vbQuestion + vbYesNoCancel, "Pertanyaan")
        If njir = MsgBoxResult.Yes Then
            Koneksi.Open()
            Dim query As String = "DELETE FROM [tb_keuangan] WHERE id = @cok"
            Dim command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@cok", Id)
            command.ExecuteNonQuery()
            MsgBox("Data Pengeluaran Berhasil di Hapus", vbQuestion + vbOKOnly, "Berhasil")
            Call Start()
            Koneksi.Close()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Call Start()
    End Sub
End Class
