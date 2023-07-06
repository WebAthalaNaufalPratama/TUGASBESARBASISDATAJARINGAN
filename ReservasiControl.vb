Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class ReservasiControl
    Public Tagihan As Integer = 0
    Public Malam As Integer
    Public TanggalCheckIn As DateTime
    Public TanggalCheckOut As DateTime
    Public IdTamu As Integer
    Public IdKamar As Integer
    Public Id As String = ""

    Sub ClearForm()
        TextBox1.Text = ""
        TextBox2.Text = ""
        CheckBox1.Checked = False
        CheckBox2.Checked = False
    End Sub
    Sub Start()
        Button1.Text = "Tambah"
        Button2.Text = "Edit"
        Button3.Text = "Hapus"
        Button4.Text = "Batal"
        Button5.Text = "Kalkulasi"
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = False
        Button5.Enabled = False
        TextBox1.Enabled = False
        TextBox2.Enabled = False
        DateTimePicker1.Enabled = False
        DateTimePicker2.Enabled = False
        CheckBox1.Enabled = False
        CheckBox2.Enabled = False
        Call ViewData()
        Call ClearForm()
    End Sub

    Sub ViewData()
        Koneksi.Open()
        Dim query As String = "SELECT
                [tb_reservasi].[id],
                [tb_tamu].[nama],
                [tb_reservasi].[id_kamar],
                [tb_reservasi].[tanggal_checkin],
                [tb_reservasi].[tanggal_checkout],
                [tb_reservasi].[jam_checkin],
                [tb_reservasi].[jam_checkout],
                [tb_reservasi].[tagihan],
                [tb_pegawai].[nama]
                FROM [tb_reservasi]
                JOIN [tb_tamu] ON [tb_reservasi].[id_tamu] = [tb_tamu].[id]
                JOIN [tb_pegawai] ON [tb_reservasi].[id_pegawai] = [tb_pegawai].[id];"
        Dim command As New SqlCommand(query, connection)
        Dim reader As SqlDataReader = command.ExecuteReader()
        Dim dataTable As New DataTable()
        dataTable.Load(reader)
        DataGridView1.DataSource = dataTable
        Koneksi.Close()
    End Sub

    Sub EnableForm()
        TextBox1.Enabled = True
        TextBox2.Enabled = True
        DateTimePicker1.Enabled = True
        DateTimePicker2.Enabled = True
        CheckBox1.Enabled = True
        CheckBox2.Enabled = True
    End Sub
    Private Sub ReservasiControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If TextBox1.Text = "" Then
            Label5.Text = "Nama : "
            Label6.Text = "No KTP : "
            Label7.Text = "No Telp : "
            Return
        End If
        Koneksi.Open()
        Dim query As String = "SELECT [nama],[notelp],[noktp] FROM [tb_tamu] WHERE [id] LIKE '%" + TextBox1.Text + "%' "
        Dim command As New SqlCommand(query, connection)
        Dim reader As SqlDataReader = command.ExecuteReader()
        If reader.Read() Then
            Label5.Text = "Nama : " + reader.GetString(0)
            Label6.Text = "No KTP : " + reader.GetString(2)
            Label7.Text = "No Telp : " + reader.GetString(1)
        End If
        Koneksi.Close()
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If TextBox2.Text = "" Then
            Label10.Text = "Tipe Kamar : "
            Label9.Text = "Harga/Malam : "
            Return
        End If
        Koneksi.Open()
        Dim query As String = "SELECT [tipe_kamar],[harga] FROM [db_hotel].[dbo].[tb_kamar] WHERE [id] LIKE '%" + TextBox2.Text + "%'"
        Dim command As New SqlCommand(query, connection)
        Dim reader As SqlDataReader = command.ExecuteReader()
        If reader.Read() Then
            Label10.Text = "Tipe Kamar : " + reader.GetString(0)
            Label9.Text = "Harga/Malam : " + reader.GetString(1)
        End If
        Koneksi.Close()
    End Sub

    Shared Function GetHargaKamar(Id As Integer) As Integer
        Koneksi.Open()
        'Dim harga As Integer
        Dim query As String = "SELECT [harga] FROM [tb_kamar] WHERE [id] = @id"
        Dim command As New SqlCommand(query, connection)
        command.Parameters.AddWithValue("@id", Id)
        Dim reader As SqlDataReader = command.ExecuteReader()
        If reader.Read() Then
            Dim harga As String = reader.GetString(0)
            Return Integer.Parse(harga)
        Else
            Return 0
        End If
    End Function

    Shared Function TidakTersedia(Id As Integer)
        Koneksi.Open()
        Dim query As String = "UPDATE [tb_kamar] 
                SET [tersedia] = 'Tidak Tersedia',
                [updated_at] = getdate(),
                [id_pegawai] = @idpegawai WHERE [id] = @idkamar"
        Dim command As New SqlCommand(query, connection)
        command.Parameters.AddWithValue("@idkamar", Id)
        command.Parameters.AddWithValue("@idpegawai", User.Id)
        command.ExecuteNonQuery()
        Koneksi.Close()
        Return True
    End Function

    Shared Function Tersedia(Id As Integer)
        Koneksi.Open()
        Dim query As String = "UPDATE [tb_kamar] 
                SET [tersedia] = 'Tersedia',
                [updated_at] = getdate(),
                [id_pegawai] = @idpegawai WHERE [id] = @idkamar"
        Dim command As New SqlCommand(query, connection)
        command.Parameters.AddWithValue("@idkamar", Id)
        command.Parameters.AddWithValue("@idpegawai", User.Id)
        command.ExecuteNonQuery()
        Koneksi.Close()
        Return True
    End Function

    Shared Function CheckIn(Id As String)
        Koneksi.Open()
        Dim query As String = "UPDATE [tb_reservasi]
                SET [jam_checkin] = getdate(),
                [checkin] = 1 , [updated_at] = getdate() WHERE [id] = @id"
        Dim command As New SqlCommand(query, connection)
        command.Parameters.AddWithValue("@id", Id)
        command.ExecuteNonQuery()
        Koneksi.Close()
        Return True
    End Function

    Shared Function CheckOut(Id As String)
        Koneksi.Open()
        Dim query As String = "UPDATE [tb_reservasi]
                SET [jam_checkout] = getdate(),
                [checkout] = 1 , [updated_at] = getdate() WHERE [id] = @id"
        Dim command As New SqlCommand(query, connection)
        command.Parameters.AddWithValue("@id", Id)
        command.ExecuteNonQuery()
        Koneksi.Close()
        Return True
    End Function

    Shared Function GetIdTamu(Id As String)
        Koneksi.Open()
        Dim TempId As Integer = 0
        Dim query As String = "SELECT [id_tamu] FROM [tb_reservasi] WHERE [id] = @id AND [id] = @id"
        Dim command As New SqlCommand(query, connection)
        command.Parameters.AddWithValue("@id", Id)
        Dim reader As SqlDataReader = command.ExecuteReader()
        If reader.Read() Then
            TempId = reader.GetInt32(0)
        End If
        Return TempId
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Button1.Text = "Tambah" Then
            Button1.Text = "Simpan"
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = True
            Button5.Enabled = True
            Call ClearForm()
            Call EnableForm()
            CheckBox2.Enabled = False
        Else
            If TextBox1.Text = "" Or TextBox2.Text = "" Then
                MsgBox("Pastikan Semua Form Telah Terisi !", vbQuestion + vbOKOnly, "Peringatan")
                Return
            End If
            'Dim StatusCheckIn As Integer
            IdTamu = TextBox1.Text
            IdKamar = TextBox2.Text
            TanggalCheckIn = DateTimePicker1.Value
            TanggalCheckOut = DateTimePicker2.Value
            If TanggalCheckIn > TanggalCheckOut Then
                MsgBox("Pilih Tanggal Check Out Dengan Benar", vbQuestion + vbOKOnly, "Peringatan")
                Return
            End If
            Malam = Integer.Parse(TanggalCheckOut.Day) - Integer.Parse(TanggalCheckIn.Day)
            If Tagihan = 0 Then
                MsgBox("Klik Tombol Kalkukasi Dahulu !", vbQuestion + vbOKOnly, "Peringatan")
                Return
            End If
            Koneksi.Open()
            Dim query As String = "INSERT INTO [tb_reservasi] 
                (id_tamu,id_kamar,tanggal_checkin,tanggal_checkout,tagihan,id_pegawai,created_at) VALUES
                (@id_tamu,@id_kamar,@tanggal_checkin,@tanggal_checkout,@tagihan,@id_pegawai,getdate())"
            Dim command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@id_tamu", IdTamu)
            command.Parameters.AddWithValue("@id_kamar", IdKamar)
            command.Parameters.AddWithValue("@tanggal_checkin", TanggalCheckIn.ToString("yyyy-MM-dd"))
            command.Parameters.AddWithValue("@tanggal_checkout", TanggalCheckOut.ToString("yyyy-MM-dd"))
            command.Parameters.AddWithValue("@tagihan", Tagihan)
            command.Parameters.AddWithValue("@id_pegawai", User.Id)
            command.ExecuteNonQuery()
            Koneksi.Close()
            Koneksi.Open()
            query = "SELECT TOP 1 [id] FROM [tb_reservasi] ORDER BY [created_at] DESC"
            command = New SqlCommand(query, connection)
            Dim reader As SqlDataReader = command.ExecuteReader()
            Dim IdReservasi As Integer
            If reader.Read() Then
                IdReservasi = reader.GetInt32(0)
            Else
                IdReservasi = 0
            End If
            If CheckBox1.Checked Then
                CheckIn(IdReservasi)
            End If
            TidakTersedia(IdKamar)
            MsgBox("Data Reservasi Baru Telah di Tambahkan !", vbQuestion + vbOKOnly, "Berhasil")
            Call Start()
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        IdKamar = TextBox2.Text
        TanggalCheckIn = DateTimePicker1.Value
        TanggalCheckOut = DateTimePicker2.Value
        If TanggalCheckIn > TanggalCheckOut Then
            MsgBox("Pilih Tanggal Check Out Dengan Benar", vbQuestion + vbOKOnly, "Peringatan")
            Return
        End If
        Malam = Integer.Parse(TanggalCheckOut.Day) - Integer.Parse(TanggalCheckIn.Day)
        Dim Per As Integer = GetHargaKamar(IdKamar)
        Tagihan = Malam * Per
        Label11.Text = "Menginap : " + Malam.ToString() + " Malam"
        Label8.Text = "Tagihan : " + Tagihan.ToString()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Call Start()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Id = "" Then
            MsgBox("Pilih Data Reservasi Dahulu !", vbQuestion + vbOKOnly, "Peringatan")
        Else
            Dim cc As MsgBoxResult
            cc = MsgBox("Yakin Ingin Menghapus Reservasi ID : " + Id + "?", vbQuestion + vbYesNoCancel, "Peringatan")
            If cc = MsgBoxResult.Yes Then
                Koneksi.Open()
                Dim query As String = "DELETE FROM [tb_reservasi] WHERE [id] = " + Id
                Dim command As New SqlCommand(query, connection)
                command.ExecuteNonQuery()
                Koneksi.Close()
                MsgBox("Data Reservasi Berhasil di Hapus", vbQuestion + vbOKOnly, "Berhasil")
                Call Start()
            End If
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Button2.Text = "Edit" Then
            Button1.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = True
            CheckBox1.Enabled = True
            CheckBox2.Enabled = True
            If CheckBox1.Checked Then
                CheckBox1.Enabled = False
            End If
            If CheckBox2.Checked Then
                CheckBox2.Enabled = False
            End If
            Button2.Text = "Simpan"
        Else
            If CheckBox1.Checked Then
                CheckIn(Id)
                TidakTersedia(IdKamar)
            End If
            If CheckBox2.Checked Then
                CheckOut(Id)
                Tersedia(IdKamar)
            End If
            MsgBox("Data Reservasi Berhasil di Update", vbQuestion + vbOKOnly, "Berhasil")
            Call Start()
            Return
        End If
    End Sub

    Function GroupboxTamu(Id As String)
        Koneksi.Open()
        Dim query As String = "SELECT [nama],[noktp],[notelp] FROM [tb_tamu] WHERE [id] = @id"
        Dim command As New SqlCommand(query, connection)
        command.Parameters.AddWithValue("@id", Id)
        Dim reader As SqlDataReader = command.ExecuteReader()
        If reader.HasRows Then
            If reader.Read() Then
                Label5.Text = "Nama : " + reader.GetString(0)
                Label6.Text = "No KTP : " + reader.GetString(1)
                Label7.Text = "No Telp : " + reader.GetString(2)
            End If
        End If
        Koneksi.Close()
        Return True
    End Function

    Function GroupboxKamar(Id As String)
        Koneksi.Open()
        Dim query As String = "SELECT [tipe_kamar],[harga] FROM [tb_kamar] WHERE [id] = @id"
        Dim command As New SqlCommand(query, connection)
        command.Parameters.AddWithValue("@id", Id)
        Dim reader As SqlDataReader = command.ExecuteReader()
        If reader.HasRows Then
            If reader.Read() Then
                Label10.Text = "Tipe Kamar : " + reader.GetString(0)
                Label9.Text = "Harga/Malam : " + reader.GetString(1)
            End If
        End If
        Koneksi.Close()
        Return True
    End Function

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim hehe As String
        If e.RowIndex >= 0 Then
            hehe = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString()
            Id = hehe
            Dim TempIdTamu As String = GetIdTamu(hehe)
            TextBox1.Text = TempIdTamu
            GroupboxTamu(TempIdTamu)
            'MsgBox(IdTamu.ToString())
            hehe = DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString()
            IdKamar = Integer.Parse(hehe)
            TextBox2.Text = hehe
            GroupboxKamar(hehe)
            hehe = DataGridView1.Rows(e.RowIndex).Cells(3).Value.ToString()
            Dim _TanggalCheckIn As DateTime = DateTime.Parse(hehe)
            DateTimePicker1.Value = _TanggalCheckIn
            hehe = DataGridView1.Rows(e.RowIndex).Cells(4).Value.ToString()
            Dim _TanggalCheckOut As DateTime = DateTime.Parse(hehe)
            DateTimePicker2.Value = _TanggalCheckOut
            Dim DayIn As Integer = _TanggalCheckIn.Day
            Dim DayOut As Integer = _TanggalCheckOut.Day
            Dim _Malam As Integer = DayOut - DayIn
            Label11.Text = "Menginap : " + _Malam.ToString() + " Malam"
            hehe = DataGridView1.Rows(e.RowIndex).Cells(5).Value.ToString()
            If hehe <> "" Then
                CheckBox1.Checked = True
            End If
            hehe = DataGridView1.Rows(e.RowIndex).Cells(6).Value.ToString()
            If hehe <> "" Then
                CheckBox2.Checked = True
            End If
            hehe = DataGridView1.Rows(e.RowIndex).Cells(7).Value.ToString()
            Label8.Text = "Tagihan : " + hehe
        End If
    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        If TextBox3.Text = "" Then
            Call ViewData()
        End If
        Koneksi.Open()
        Dim query As String = "SELECT
                [tb_reservasi].[id],
                [tb_tamu].[nama],
                [tb_reservasi].[id_kamar],
                [tb_reservasi].[tanggal_checkin],
                [tb_reservasi].[tanggal_checkout],
                [tb_reservasi].[jam_checkin],
                [tb_reservasi].[jam_checkout],
                [tb_reservasi].[tagihan],
                [tb_pegawai].[nama]
                FROM [tb_reservasi]
                JOIN [tb_tamu] ON [tb_reservasi].[id_tamu] = [tb_tamu].[id]
                JOIN [tb_pegawai] ON [tb_reservasi].[id_pegawai] = [tb_pegawai].[id]
                WHERE 
                ([tb_reservasi].[id] LIKE @hehe OR
                [tb_tamu].[nama] LIKE @hehe OR
                [tb_reservasi].[id_kamar] LIKE @hehe OR
                [tb_reservasi].[tanggal_checkin] LIKE @hehe OR
                [tb_reservasi].[tanggal_checkout] LIKE @hehe OR
                [tb_reservasi].[jam_checkin] LIKE @hehe OR
                [tb_reservasi].[jam_checkout] LIKE @hehe OR
                [tb_reservasi].[tagihan] LIKE @hehe OR
                [tb_pegawai].[nama] LIKE @hehe)"
        Dim command As New SqlCommand(query, connection)
        command.Parameters.AddWithValue("@hehe", "%" + TextBox3.Text + "%")
        Dim reader As SqlDataReader = command.ExecuteReader()
        Dim dataTable As New DataTable()
        dataTable.Load(reader)
        DataGridView1.DataSource = dataTable

        Koneksi.Close()
    End Sub
End Class
