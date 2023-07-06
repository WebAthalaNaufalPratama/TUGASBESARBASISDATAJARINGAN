Imports System.Data.SqlClient

Public Class KamarControl
    Public IdKamar As String
    Sub Start()
        Button1.Text = "Tambah"
        Button2.Text = "Edit"
        Button3.Text = "Hapus"
        Button4.Text = "Batal"
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = False
        ComboBox1.Enabled = False
        ComboBox2.Enabled = False
        ComboBox3.Enabled = False
        TextBox1.Enabled = False
        TextBox2.Enabled = False
        Call ViewData()
        Call ViewKamarTersedia()
        Call ViewTotalKamar()
    End Sub

    Sub EnableForm()
        ComboBox1.Enabled = True
        ComboBox2.Enabled = True
        ComboBox3.Enabled = True
        TextBox1.Enabled = True
        TextBox2.Enabled = True
    End Sub

    Sub ViewData()
        Koneksi.Open()
        Dim query As String = "SELECT [id], [tipe_kamar], [harga], 
        [status], [tersedia], [fasilitas] FROM [tb_kamar]"
        Dim command As New SqlCommand(query, connection)
        Dim reader As SqlDataReader = command.ExecuteReader()
        Dim dataTable As New DataTable()
        dataTable.Load(reader)
        DataGridView1.DataSource = dataTable
        Koneksi.Close()
    End Sub

    Sub ViewTotalKamar()
        Koneksi.Open()
        Dim query As String = "SELECT COUNT(*) FROM tb_kamar"
        Dim command As New SqlCommand(query, connection)
        Dim reader As SqlDataReader = command.ExecuteReader()
        If reader.Read() Then
            Label8.Text = reader.GetInt32(0).ToString()
        End If
        Koneksi.Close()
    End Sub

    Sub ViewKamarTersedia()
        Koneksi.Open()
        Dim query As String = "SELECT COUNT(*) FROM tb_kamar WHERE [tersedia] = 'Tersedia'"
        Dim command As New SqlCommand(query, connection)
        Dim reader As SqlDataReader = command.ExecuteReader()
        If reader.Read() Then
            Label7.Text = reader.GetInt32(0).ToString()
        End If
        Koneksi.Close()
    End Sub

    Private Sub KamarControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Call Start()
        'Call ViewData()
        'Call ViewTotalKamar()
        'Call ViewKamarTersedia()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Dim Sedia As Integer
        If Button1.Text = "Tambah" Then
            Button1.Text = "Simpan"
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = True
            ComboBox1.Text = ""
            ComboBox2.Text = ""
            ComboBox3.Text = ""
            TextBox1.Text = ""
            TextBox2.Text = ""
            Call EnableForm()
        Else
            If ComboBox1.Text = "" Or ComboBox2.Text = "" Or ComboBox3.Text = "" Or
                TextBox1.Text = "" Or TextBox2.Text = "" Then
                MsgBox("Pastikan semua form sudah terisi !")
            Else
                Koneksi.Open()
                Dim query As String = "INSERT INTO tb_kamar 
                (tipe_kamar,harga,status,tersedia,id_pegawai,fasilitas,created_at) VALUES 
                (@tipe_kamar,@harga,@status,@tersedia,@id_pegawai,@fasilitas,getdate())"
                Dim command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@tipe_kamar", ComboBox1.Text)
                command.Parameters.AddWithValue("@harga", TextBox1.Text)
                command.Parameters.AddWithValue("@status", ComboBox2.Text)
                command.Parameters.AddWithValue("@tersedia", ComboBox3.Text)
                command.Parameters.AddWithValue("@id_pegawai", User.Id)
                command.Parameters.AddWithValue("@fasilitas", TextBox2.Text)
                command.ExecuteNonQuery()
                Koneksi.Close()
                MsgBox("Data Kamar Baru Telah di Tambahkan !")
                ComboBox1.Text = ""
                TextBox1.Text = ""
                ComboBox2.Text = ""
                ComboBox3.Text = ""
                TextBox2.Text = ""
                Call Start()
            End If
        End If
    End Sub


    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim jancok As String
        If e.RowIndex >= 0 Then
            jancok = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString()
            IdKamar = jancok
            jancok = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString()
            ComboBox1.Text = jancok
            jancok = DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString()
            TextBox1.Text = jancok
            jancok = DataGridView1.Rows(e.RowIndex).Cells(3).Value.ToString()
            ComboBox2.Text = jancok
            jancok = DataGridView1.Rows(e.RowIndex).Cells(4).Value.ToString()
            ComboBox3.Text = jancok
            jancok = DataGridView1.Rows(e.RowIndex).Cells(5).Value.ToString()
            TextBox2.Text = jancok
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
            If ComboBox1.Text = "" Or ComboBox2.Text = "" Or
                ComboBox3.Text = "" Or TextBox1.Text = "" Or TextBox2.Text = "" Then
                MsgBox("Pastikan Semua Form telah terisi")
            Else
                Koneksi.Open()
                Dim query As String = "UPDATE [tb_kamar] 
                SET [tipe_kamar] = @tipe_kamar,[harga] = @harga,[status] = @status,
                [tersedia] = @tersedia,[updated_at] = getdate(),[id_pegawai] = @idpegawai,
                [fasilitas] = @fasilitas WHERE [id] = @idkamar"
                Dim command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@tipe_kamar", ComboBox1.Text)
                command.Parameters.AddWithValue("@harga", TextBox1.Text)
                command.Parameters.AddWithValue("@status", ComboBox2.Text)
                command.Parameters.AddWithValue("@tersedia", ComboBox3.Text)
                command.Parameters.AddWithValue("@idpegawai", User.Id)
                command.Parameters.AddWithValue("@fasilitas", TextBox2.Text)
                command.Parameters.AddWithValue("@idkamar", IdKamar)
                command.ExecuteNonQuery()
                Koneksi.Close()
                MsgBox("Data Kamar Berhasil di Perbarui !")
                Call Start()
            End If
        End If
    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        If TextBox3.Text = "" Then
            Call ViewData()
        Else
            Koneksi.Open()
            Dim query As String = "SELECT [id], [tipe_kamar], [harga], 
            [status], [tersedia], [fasilitas] FROM [tb_kamar]
            WHERE [tipe_kamar] LIKE @tipe_kamar OR [harga] LIKE @harga OR
            [fasilitas] LIKE @fasilitas OR [tersedia] LIKE @tersedia OR
            [status] LIKE @status"
            Dim command As New SqlCommand(query, connection)
            Dim fuiyo As String = "%" & TextBox3.Text & "%"
            command.Parameters.AddWithValue("@tipe_kamar", fuiyo)
            command.Parameters.AddWithValue("@harga", fuiyo)
            command.Parameters.AddWithValue("@fasilitas", fuiyo)
            command.Parameters.AddWithValue("@tersedia", fuiyo)
            command.Parameters.AddWithValue("@status", fuiyo)
            Dim reader As SqlDataReader = command.ExecuteReader()
            If reader.HasRows Then
                Dim dataTable As New DataTable()
                dataTable.Load(reader)
                DataGridView1.DataSource = dataTable
            End If
            Koneksi.Close()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If IdKamar = "" Then
            MsgBox("Pilih Data Kamar yang Ingin di Hapus !")
        Else
            Dim blok As MsgBoxResult
            blok = MsgBox("Yakin Ingin Menghapus Kamar ID : " + IdKamar + " ?", vbQuestion + vbYesNoCancel, "Konfirmasi")
            If blok = MsgBoxResult.Yes Then
                Koneksi.Open()
                Dim query As String = "DELETE FROM [tb_kamar] WHERE [id] = " + IdKamar
                Dim command As New SqlCommand(query, connection)
                command.ExecuteNonQuery()
                MsgBox("Kamar ID " + IdKamar + " Berhasil di Hapus !")
                Call Start()
            End If
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            Koneksi.Open()
            Dim query As String = "SELECT [id], [tipe_kamar], [harga], 
            [status], [tersedia], [fasilitas] FROM [tb_kamar] WHERE [tersedia] = 'Tersedia' AND [status] = 'Bersih'"
            Dim command As New SqlCommand(query, connection)
            Dim reader As SqlDataReader = command.ExecuteReader()
            Dim dataTable As New DataTable()
            dataTable.Load(reader)
            DataGridView1.DataSource = dataTable
            Koneksi.Close()
        Else
            Call ViewData()
        End If
    End Sub
End Class
