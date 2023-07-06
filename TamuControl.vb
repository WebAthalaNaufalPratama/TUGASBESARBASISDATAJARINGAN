Imports System.Data.SqlClient

Public Class TamuControl
    Public IdTamu As String

    Sub TamuHariIni()
        Dim today As DateTime = DateTime.Now
        'MsgBox(today.ToString("yyyy-MM-dd"))
        Koneksi.Open()
        Dim query As String = "SELECT count(*) FROM tb_tamu WHERE CONVERT(date, created_at) = '" + today.ToString("yyyy-MM-dd") + "'"
        Dim command As New SqlCommand(query, connection)
        Dim reader As SqlDataReader = command.ExecuteReader()
        If reader.Read() Then
            Label7.Text = reader.GetInt32(0).ToString()
        End If
        Koneksi.Close()
    End Sub
    Sub TotalTamu()
        Koneksi.Open()
        Dim query As String = "SELECT count(*) FROM tb_tamu"
        Dim command As New SqlCommand(query, connection)
        Dim reader As SqlDataReader = command.ExecuteReader()
        If reader.Read() Then
            Label8.Text = reader.GetInt32(0).ToString()
        End If
        Koneksi.Close()
    End Sub
    Sub Start()
        Call TamuHariIni()
        Button1.Text = "Tambah"
        Button2.Text = "Edit"
        Button3.Text = "Hapus"
        Button4.Text = "Batal"
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = False
        TextBox1.Enabled = False
        TextBox2.Enabled = False
        TextBox3.Enabled = False
        TextBox3.Enabled = False
        TextBox4.Enabled = False
        Call ViewData()
        Call TamuHariIni()
        Call TotalTamu()
    End Sub

    Sub EnableForm()
        TextBox1.Enabled = True
        TextBox2.Enabled = True
        TextBox3.Enabled = True
        TextBox4.Enabled = True
    End Sub

    Sub ClearForm()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
    End Sub

    Sub ViewData()
        Koneksi.Open()
        Dim query As String = "SELECT [tb_tamu].[id],[tb_tamu].[nama],
        [tb_tamu].[notelp],[tb_tamu].[noktp],[tb_tamu].[email],
        [tb_pegawai].[nama] FROM [tb_tamu] 
        JOIN [tb_pegawai] ON [tb_tamu].[id_pegawai] = [tb_pegawai].[id] ORDER BY [tb_tamu].[id] DESC"
        Dim command As New SqlCommand(query, connection)
        Dim reader As SqlDataReader = command.ExecuteReader()
        Dim dataTable As New DataTable()
        dataTable.Load(reader)
        DataGridView1.DataSource = dataTable
        Koneksi.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Button1.Text = "Tambah" Then
            Button1.Text = "Simpan"
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = True
            Call EnableForm()
        Else
            If TextBox1.Text = "" Or TextBox2.Text = "" Or
                TextBox3.Text = "" Or TextBox4.Text = "" Then
                MsgBox("Pastikan semua form telah terisi !", vbQuestion + vbOKOnly, "Peringatan")
            ElseIf Not TextBox4.Text.Contains("@"c) Or Not TextBox4.Text.Contains("."c) Then
                MsgBox("Email Harus Valid", vbQuestion + vbOKOnly, "Peringatan")
                Return
            Else
                Koneksi.Open()
                Dim QuerySelect As String = "SELECT * from tb_tamu where noktp = @noktp OR notelp = @notelp OR email = @email"
                Dim komand As New SqlCommand(QuerySelect, connection)
                komand.Parameters.AddWithValue("@noktp", TextBox3.Text)
                komand.Parameters.AddWithValue("@notelp", TextBox2.Text)
                komand.Parameters.AddWithValue("@email", TextBox4.Text)
                Dim hasil As SqlDataReader = komand.ExecuteReader()
                If hasil.HasRows Then
                    MsgBox("Data yang di masukkan sudah terdaftar", vbQuestion + vbOKOnly, "Peringatan")
                    MsgBox("Silahkan cek menggunakan fitur pencarian", vbQuestion + vbOKOnly, "Peringatan")
                    Return
                End If
                Koneksi.Close()
                Koneksi.Open()
                Dim query As String = "INSERT INTO tb_tamu
                (nama,notelp,noktp,email,id_pegawai,created_at) VALUES
                (@nama,@notelp,@noktp,@email,@id_pegawai,getdate())"
                Dim command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@nama", TextBox1.Text)
                command.Parameters.AddWithValue("@noktp", TextBox2.Text)
                command.Parameters.AddWithValue("@notelp", TextBox3.Text)
                command.Parameters.AddWithValue("@email", TextBox4.Text)
                command.Parameters.AddWithValue("@id_pegawai", User.Id)
                command.ExecuteNonQuery()
                Koneksi.Close()
                MsgBox("Data Tamu Baru Telah di Tambahkan !", vbQuestion + vbOKOnly, "Berhasil")
                Call Start()
                Call ClearForm()
            End If
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Call Start()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Button2.Text = "Edit" Then
            Button2.Text = "Simpan"
            Button1.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = True
            Call EnableForm()
        Else
            If TextBox1.Text = "" Or TextBox2.Text = "" Or
                    TextBox3.Text = "" Or TextBox4.Text = "" Then
                MsgBox("Pastikan semua form telah terisi !", vbQuestion + vbOKOnly, "Peringatan")
            Else
                Koneksi.Open()
                Dim QuerySelect As String = "SELECT * from tb_tamu where noktp = @noktp OR notelp = @notelp OR email = @email"
                Dim komand As New SqlCommand(QuerySelect, connection)
                komand.Parameters.AddWithValue("@noktp", TextBox3.Text)
                komand.Parameters.AddWithValue("@notelp", TextBox2.Text)
                komand.Parameters.AddWithValue("@email", TextBox4.Text)
                Dim hasil As SqlDataReader = komand.ExecuteReader()
                If hasil.HasRows Then
                    MsgBox("Data yang di masukkan sudah terdaftar", vbQuestion + vbOKOnly, "Peringatan")
                    MsgBox("Silahkan cek menggunakan fitur pencarian", vbQuestion + vbOKOnly, "Peringatan")
                    Return
                End If
                Koneksi.Close()
                Koneksi.Open()
                Dim query As String = "UPDATE [tb_tamu]
                SET [nama] = @nama, [notelp] = @notelp,
                [noktp] = @noktp, [email] = @email, [updated_at] = getdate()"
                Dim command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@nama", TextBox1.Text)
                command.Parameters.AddWithValue("@noktp", TextBox2.Text)
                command.Parameters.AddWithValue("@notelp", TextBox3.Text)
                command.Parameters.AddWithValue("@email", TextBox4.Text)
                command.ExecuteNonQuery()
                Koneksi.Close()
                MsgBox("Data Tamu Berhasil di Update", vbQuestion + vbOKOnly, "Berhasil")
                Call Start()
                Call ClearForm()
            End If
        End If
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim jir As String
        If e.RowIndex >= 0 Then
            jir = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString()
            IdTamu = jir
            jir = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString()
            TextBox1.Text = jir
            jir = DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString()
            TextBox2.Text = jir
            jir = DataGridView1.Rows(e.RowIndex).Cells(3).Value.ToString()
            TextBox3.Text = jir
            jir = DataGridView1.Rows(e.RowIndex).Cells(4).Value.ToString()
            TextBox4.Text = jir
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If IdTamu = "" Then
            MsgBox("Pilih Data Tamu Terlebih Dahulu !", vbQuestion + vbOKOnly, "Peringatan")
            Return
        End If
        Dim blok As MsgBoxResult
        blok = MsgBox("Yakin Ingin Menghapus Tamu ID : " + IdTamu + " ?", vbQuestion + vbYesNoCancel, "Konfirmasi")
        If blok = MsgBoxResult.Yes Then
            Koneksi.Open()
            Dim query As String = "DELETE FROM tb_tamu WHERE id = " + IdTamu
            Dim command As New SqlCommand(query, connection)
            command.ExecuteNonQuery()
            MsgBox("Tamu ID " + IdTamu + " Berhasil di Hapus", vbQuestion + vbOKOnly, "Berhasil")
            Koneksi.Close()
            Call Start()
            Call ClearForm()
        End If
    End Sub

    Private Sub TextBox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox5.KeyPress
        If TextBox5.Text = "" Then
            Call Start()
        Else
            Koneksi.Open()
            Dim query As String = "SELECT [tb_tamu].[id],[tb_tamu].[nama],
        [tb_tamu].[notelp],[tb_tamu].[noktp],[tb_tamu].[email],
        [tb_pegawai].[nama] FROM [tb_tamu] 
        JOIN [tb_pegawai] ON [tb_tamu].[id_pegawai] = [tb_pegawai].[id]
        WHERE [tb_tamu].[nama] LIKE @nama OR [tb_tamu].[notelp] LIKE @notelp OR
        [tb_tamu].[email] LIKE @email OR [tb_pegawai].[nama] LIKE @nama_pegawai"
            Dim command As New SqlCommand(query, connection)
            Dim yok As String = "%" + TextBox5.Text + "%"
            command.Parameters.AddWithValue("@nama", yok)
            command.Parameters.AddWithValue("@notelp", yok)
            command.Parameters.AddWithValue("@email", yok)
            command.Parameters.AddWithValue("nama_pegawai", yok)
            Dim reader As SqlDataReader = command.ExecuteReader()
            If reader.HasRows Then
                Dim dataTable As New DataTable()
                dataTable.Load(reader)
                DataGridView1.DataSource = dataTable
            End If
            Koneksi.Close()
        End If

    End Sub
End Class
