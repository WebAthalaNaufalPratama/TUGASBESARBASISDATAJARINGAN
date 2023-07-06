Imports System.Collections.ObjectModel
Imports System.Data.SqlClient
Imports System.Diagnostics.Eventing
Imports System.Net.NetworkInformation
Imports BCrypt.Net.BCrypt

Public Class PegawaiControl
    Public IdUser As String
    Sub Start()
        Button1.Text = "Tambah"
        Button2.Text = "Edit"
        Button3.Text = "Hapus"
        Button4.Text = "Batal"
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = False
        FormName.Text = ""
        FormUsername.Text = ""
        FormPassword.Text = ""
        FormLevel.Text = ""
        FormEmail.Text = ""
        FormName.Enabled = False
        FormUsername.Enabled = False
        FormEmail.Enabled = False
        FormPassword.Enabled = False
        FormLevel.Enabled = False
    End Sub

    Sub SetupDatagrid()
        DataGridView1.Columns(0).Width = DataGridView1.Size.Width / 5
        DataGridView1.Columns(1).Width = DataGridView1.Size.Width / 5
        DataGridView1.Columns(2).Width = DataGridView1.Size.Width / 5
        DataGridView1.Columns(3).Width = DataGridView1.Size.Width / 5
        DataGridView1.Columns(4).Width = DataGridView1.Size.Width / 5
    End Sub

    Sub FormEnabled()
        FormName.Enabled = True
        FormUsername.Enabled = True
        FormEmail.Enabled = True
        FormPassword.Enabled = True
        FormLevel.Enabled = True
    End Sub

    Sub ViewData()
        Koneksi.Open()
        Dim query As String = "SELECT id,nama,username,email,level FROM [tb_pegawai]"
        Dim command As New SqlCommand(query, connection)
        Dim reader As SqlDataReader = command.ExecuteReader()
        Dim dataTable As New DataTable()
        dataTable.Load(reader)
        DataGridView1.DataSource = dataTable
        Koneksi.Close()
    End Sub
    Private Sub PegawaiControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Start()
        Call ViewData()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Button1.Text = "Tambah" Then
            Button1.Text = "Simpan"
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = True
            FormName.Text = ""
            FormUsername.Text = ""
            FormPassword.Text = ""
            FormLevel.Text = ""
            FormEmail.Text = ""
            Call FormEnabled()
        Else
            If FormName.Text = "" Or FormUsername.Text = "" Or FormEmail.Text = "" Or
                FormPassword.Text = "" Or FormLevel.Text = "" Then
                MsgBox("Pastikan semua form telah terisi !")
            ElseIf Not FormEmail.Text.Contains("@"c) Then
                MsgBox("Format Email salah !")
            Else
                Dim salt As String = GenerateSalt()
                Dim hashedPassword As String = HashPassword(FormPassword.Text, salt)
                Koneksi.Open()
                Dim query As String = "INSERT INTO tb_pegawai 
                (nama,username,email,password,level,created_at) VALUES 
                (@nama,@username,@email,@password,@level,getdate())"
                Dim command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@nama", FormName.Text)
                command.Parameters.AddWithValue("@username", FormUsername.Text)
                command.Parameters.AddWithValue("@email", FormEmail.Text)
                command.Parameters.AddWithValue("@password", hashedPassword)
                command.Parameters.AddWithValue("@level", FormLevel.Text)
                command.ExecuteNonQuery()
                Koneksi.Close()
                MsgBox("Data Pegawai baru telah ditambahkan !")
                Call Start()
                Call ViewData()
            End If
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Call Start()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim isi As String
        If e.RowIndex >= 0 Then
            isi = DataGridView1.Rows(e.RowIndex).Cells("id").Value.ToString()
            IdUser = isi
            isi = DataGridView1.Rows(e.RowIndex).Cells("username").Value.ToString()
            FormUsername.Text = isi
            isi = DataGridView1.Rows(e.RowIndex).Cells("nama").Value.ToString()
            FormName.Text = isi
            isi = DataGridView1.Rows(e.RowIndex).Cells("email").Value.ToString()
            FormEmail.Text = isi
            isi = DataGridView1.Rows(e.RowIndex).Cells("level").Value.ToString()
            FormLevel.Text = isi
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Button2.Text = "Edit" Then
            Button2.Text = "Simpan"
            Button1.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = True
            Call FormEnabled()
        Else
            If FormName.Text = "" Or FormUsername.Text = "" Or
                FormEmail.Text = "" Or FormPassword.Text = "" Or FormLevel.Text = "" Then
                MsgBox("Pastikan semua form telah terisi !")
            ElseIf Not FormEmail.Text.Contains("@"c) Then
                MsgBox("Format Email salah !")
            Else
                Dim salt As String = GenerateSalt()
                Dim hashedPassword As String = HashPassword(FormPassword.Text, salt)
                Koneksi.Open()
                Dim query As String = "UPDATE [tb_pegawai] SET 
                [nama] = @nama,[username] = @username,[email] = @email,
                [password] = @password,[level] = @level,[updated_at] = getdate() WHERE [id] = @iduser"
                Dim command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@nama", FormName.Text)
                command.Parameters.AddWithValue("@username", FormUsername.Text)
                command.Parameters.AddWithValue("@email", FormEmail.Text)
                command.Parameters.AddWithValue("@password", hashedPassword)
                command.Parameters.AddWithValue("@level", FormLevel.Text)
                command.Parameters.AddWithValue("@iduser", IdUser)
                command.ExecuteNonQuery()
                Koneksi.Close()
                MsgBox("Data Pegawai Berhasil di Perbarui !")
                Call Start()
                Call ViewData()
            End If
        End If
    End Sub

    Private Sub FormCari_KeyPress(sender As Object, e As KeyPressEventArgs) Handles FormCari.KeyPress
        If FormCari.Text = "" Then
            Call ViewData()
        End If
        Koneksi.Open()
        Dim query As String = "SELECT id,nama,username,email,level FROM [tb_pegawai] WHERE [nama] LIKE @nama OR [email] LIKE @email OR [username] LIKE @username"
        Dim command As New SqlCommand(query, connection)
        command.Parameters.AddWithValue("@nama", FormCari.Text)
        command.Parameters.AddWithValue("@email", FormCari.Text)
        command.Parameters.AddWithValue("@username", FormCari.Text)
        Dim reader As SqlDataReader = command.ExecuteReader()
        If reader.HasRows Then
            Dim dataTable As New DataTable()
            dataTable.Load(reader)
            DataGridView1.DataSource = dataTable
        End If
        Koneksi.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If IdUser = "" Then
            MsgBox("Pilih Data Pegawai yang mau dihapus !")
        Else
            Koneksi.Open()
            Dim query As String = "SELECT id,nama,username,email,level FROM [tb_pegawai] WHERE [id] = @id"
            Dim command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@id", IdUser)
            Dim reader As SqlDataReader = command.ExecuteReader()
            If reader.HasRows Then
                If reader.Read() Then
                    Dim Nama As String = reader.GetString(2)
                    Dim Hasil As MsgBoxResult
                    Hasil = MsgBox("Yakin ingin menghapus '" & Nama & "'", vbQuestion + vbYesNoCancel, "Konfirmasi")
                    If Hasil = MsgBoxResult.Yes Then
                        Koneksi.Close()
                        Koneksi.Open()
                        query = "DELETE FROM [tb_pegawai] WHERE [id] = @id"
                        command = New SqlCommand(query, connection)
                        command.Parameters.AddWithValue("@id", IdUser)
                        command.ExecuteNonQuery()
                        MsgBox("Data Pegawai Berhasil di hapus !")
                        Koneksi.Close()
                        Call ViewData()
                    End If
                End If
            Else
                MsgBox("Pilih Data Pegawai yang mau dihapus !")
            End If
        End If
    End Sub

End Class
