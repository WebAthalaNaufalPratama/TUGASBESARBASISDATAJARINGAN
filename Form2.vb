Public Class Form2
    Private TinggiWindow As Integer
    Private PanjangWindow As Integer
    Public dashboard As New DashboardControl()
    Public kamar As New KamarControl()
    Public reservasi As New ReservasiControl()
    Public tamu As New TamuControl()
    Public pegawai As New PegawaiControl()
    Public uang As New UangControl()

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' set name in module User / can be removed
        'User.name = "admin"
        'User.Level = "admin"
        'User.id = "1"

        If User.Level = "admin" Then
            BtnPegawai.Enabled = True
            BtnKeuangan.Enabled = True
        Else
            BtnPegawai.Enabled = False
            BtnKeuangan.Enabled = False
        End If
        ' initialization client height and client width
        TinggiWindow = Me.ClientSize.Height
        PanjangWindow = Me.ClientSize.Width
        ' customize height and width panel side bar
        PanelSideBar.Height = PanjangWindow
        PanelSideBar.Width = 200
        ' customize width button side bar
        BtnDashboard.Width = 200
        BtnReservasi.Width = 200
        BtnTamu.Width = 200
        BtnKamar.Width = 200
        BtnKeuangan.Width = 200
        BtnLogout.Width = 200
        ' customize location button
        BtnDashboard.Location = New Point(0, 80)
        BtnReservasi.Location = New Point(0, (BtnDashboard.Location.Y + 40))
        BtnTamu.Location = New Point(0, (BtnReservasi.Location.Y + 40))
        BtnKamar.Location = New Point(0, (BtnTamu.Location.Y + 40))
        BtnKeuangan.Location = New Point(0, (BtnKamar.Location.Y + 40))
        BtnPegawai.Location = New Point(0, (BtnKeuangan.Location.Y + 40))
        BtnLogout.Location = New Point(0, (BtnPegawai.Location.Y + 40))

        ' adding dashboard
        Me.Controls.Add(dashboard)
        Me.Controls.Add(reservasi)
        Me.Controls.Add(tamu)
        Me.Controls.Add(kamar)
        Me.Controls.Add(pegawai)
        Me.Controls.Add(uang)
        dashboard.Visible = True
        reservasi.Visible = False
        tamu.Visible = False
        kamar.Visible = False
        pegawai.Visible = False
        uang.Visible = False

        ' customize properties in DashboardControl
        'dashboard.TxtName.Text = "Masuk sebagai " & User.name
        'dashboard.TxtName.Location = New Point(50, 20)
        dashboard.Size = New Size((PanjangWindow - PanelSideBar.Width) - 100, (TinggiWindow - 100))
        dashboard.Location = New Point((PanelSideBar.Width + 50), 50)
        dashboard.GroupBox1.Location = New Point((dashboard.Location.X - 150), (dashboard.Location.Y + 30))
        dashboard.GroupBox2.Location = New Point((dashboard.Location.X + 150), (dashboard.Location.Y + 30))
        dashboard.GroupBox3.Location = New Point((dashboard.Location.X + 450), (dashboard.Location.Y + 30))
        dashboard.GroupBox4.Location = New Point((dashboard.Location.X - 150), (dashboard.Location.Y + 200))
        dashboard.GroupBox5.Location = New Point((dashboard.Location.X + 150), (dashboard.Location.Y + 200))
        dashboard.GroupBox6.Location = New Point((dashboard.Location.X + 450), (dashboard.Location.Y + 200))
        dashboard.GroupBox7.Location = New Point((dashboard.Location.X - 150), (dashboard.Location.Y + 370))
        dashboard.GroupBox8.Location = New Point((dashboard.Location.X + 150), (dashboard.Location.Y + 370))
        dashboard.GroupBox9.Location = New Point((dashboard.Location.X + 450), (dashboard.Location.Y + 370))
        dashboard.Start()
        dashboard.Label3.Location = New Point((dashboard.GroupBox1.Width - dashboard.Label3.Width) / 2, (dashboard.GroupBox1.Height - dashboard.Label3.Height) / 2)
        dashboard.Label4.Location = New Point((dashboard.GroupBox2.Width - dashboard.Label4.Width) / 2, (dashboard.GroupBox2.Height - dashboard.Label4.Height) / 2)
        dashboard.Label5.Location = New Point((dashboard.GroupBox3.Width - dashboard.Label5.Width) / 2, (dashboard.GroupBox3.Height - dashboard.Label5.Height) / 2)
        dashboard.Label6.Location = New Point((dashboard.GroupBox4.Width - dashboard.Label6.Width) / 2, (dashboard.GroupBox4.Height - dashboard.Label6.Height) / 2)
        dashboard.Label7.Location = New Point((dashboard.GroupBox5.Width - dashboard.Label7.Width) / 2, (dashboard.GroupBox5.Height - dashboard.Label7.Height) / 2)
        dashboard.Label8.Location = New Point((dashboard.GroupBox6.Width - dashboard.Label8.Width) / 2, (dashboard.GroupBox6.Height - dashboard.Label8.Height) / 2)
        dashboard.Label9.Location = New Point((dashboard.GroupBox7.Width - dashboard.Label9.Width) / 2, (dashboard.GroupBox7.Height - dashboard.Label9.Height) / 2)
        dashboard.Label10.Location = New Point((dashboard.GroupBox8.Width - dashboard.Label10.Width) / 2, (dashboard.GroupBox8.Height - dashboard.Label10.Height) / 2)
        dashboard.Label11.Location = New Point((dashboard.GroupBox9.Width - dashboard.Label11.Width) / 2, (dashboard.GroupBox9.Height - dashboard.GroupBox9.Height) / 2)
        dashboard.GroupBox9.Visible = False
    End Sub

    Private Sub BtnDashboard_Click(sender As Object, e As EventArgs) Handles BtnDashboard.Click
        dashboard.Visible = True
        reservasi.Visible = False
        tamu.Visible = False
        kamar.Visible = False
        pegawai.Visible = False
        uang.Visible = False
        dashboard.Start()
    End Sub

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click
        User.username = ""
        User.Level = ""
        User.name = ""
        User.email = ""
        Me.Close()
        Dim form1 As New Form1()
        form1.Show()
    End Sub

    Private Sub BtnReservasi_Click(sender As Object, e As EventArgs) Handles BtnReservasi.Click
        'Me.Controls.Add(reservasi)
        reservasi.Start()
        dashboard.Visible = False
        reservasi.Visible = True
        tamu.Visible = False
        kamar.Visible = False
        pegawai.Visible = False
        uang.Visible = False
        ' customize size and location for reservasi (user control)
        reservasi.Size = New Size((PanjangWindow - PanelSideBar.Width) - 100, (TinggiWindow - 100))
        reservasi.Location = New Point((PanelSideBar.Width + 50), 50)
        ' lokasi label 
        reservasi.Label1.Location = New Point((reservasi.Location.X - 200), (reservasi.Location.Y))
        reservasi.Label2.Location = New Point((reservasi.Location.X - 200), (reservasi.Location.Y + 40))
        reservasi.Label3.Location = New Point((reservasi.Location.X - 200), (reservasi.Location.Y + 80))
        reservasi.Label4.Location = New Point((reservasi.Location.X - 200), (reservasi.Location.Y + 120))
        reservasi.Label12.Location = New Point((reservasi.Location.X + 450), (reservasi.Location.Y + 250))
        'reservasi.Label5.Location = New Point((reservasi.Location.X - 200), (reservasi.Location.Y + 120))
        ' lokasi checkbox
        reservasi.CheckBox1.Location = New Point((reservasi.Location.X - 200), (reservasi.Location.Y + 160))
        reservasi.CheckBox2.Location = New Point((reservasi.Location.X), (reservasi.Location.Y + 160))
        ' lokasi textbox
        reservasi.TextBox1.Location = New Point((reservasi.Location.X), (reservasi.Location.Y))
        reservasi.TextBox2.Location = New Point((reservasi.Location.X), (reservasi.Location.Y + 40))
        ' textbox pencarian
        reservasi.TextBox3.Location = New Point((reservasi.Location.X + 500), (reservasi.Location.Y + 250))
        ' lokasi date picker
        reservasi.DateTimePicker1.Location = New Point((reservasi.Location.X), (reservasi.Location.Y + 80))
        reservasi.DateTimePicker2.Location = New Point((reservasi.Location.X), (reservasi.Location.Y + 120))
        ' lokasi groupbox
        reservasi.GroupBox1.Location = New Point((reservasi.Location.X + 300), (reservasi.Location.Y))
        reservasi.GroupBox2.Location = New Point((reservasi.Location.X + 300), (reservasi.Location.Y + 120))
        reservasi.GroupBox3.Location = New Point((reservasi.Location.X + 570), (reservasi.Location.Y))
        ' lokasi button
        reservasi.Button1.Location = New Point((reservasi.Location.X - 200), (reservasi.Location.Y + 200))
        reservasi.Button2.Location = New Point((reservasi.Location.X - 100), (reservasi.Location.Y + 200))
        reservasi.Button3.Location = New Point((reservasi.Location.X), (reservasi.Location.Y + 200))
        reservasi.Button4.Location = New Point((reservasi.Location.X + 100), (reservasi.Location.Y + 200))
        reservasi.Button5.Location = New Point((reservasi.Location.X + 200), (reservasi.Location.Y + 200))
        ' lokasi datagrid
        reservasi.DataGridView1.Size = New Size((reservasi.Width - 100), reservasi.Height - 350)
        reservasi.DataGridView1.Location = New Point((PanelSideBar.Location.X + 50), (reservasi.Location.Y + 280))
        reservasi.DataGridView1.Columns(0).HeaderText = "ID"
        reservasi.DataGridView1.Columns(1).HeaderText = "Nama Tamu"
        reservasi.DataGridView1.Columns(2).HeaderText = "ID Kamar"
        reservasi.DataGridView1.Columns(3).HeaderText = "Tanggal check in"
        reservasi.DataGridView1.Columns(4).HeaderText = "Tanggal check out"
        reservasi.DataGridView1.Columns(5).HeaderText = "Jam check in"
        reservasi.DataGridView1.Columns(6).HeaderText = "Jam check out"
        reservasi.DataGridView1.Columns(7).HeaderText = "Tagihan"
        reservasi.DataGridView1.Columns(8).HeaderText = "Di Masukkan Oleh"
        reservasi.DataGridView1.Columns(0).Width = Math.Ceiling((reservasi.DataGridView1.Size.Width / 8 - 50) / 10) * 10
        reservasi.DataGridView1.Columns(1).Width = reservasi.DataGridView1.Size.Width / 8
        reservasi.DataGridView1.Columns(2).Width = reservasi.DataGridView1.Size.Width / 8
        reservasi.DataGridView1.Columns(3).Width = reservasi.DataGridView1.Size.Width / 8
        reservasi.DataGridView1.Columns(4).Width = reservasi.DataGridView1.Size.Width / 8
        reservasi.DataGridView1.Columns(5).Width = reservasi.DataGridView1.Size.Width / 8
        reservasi.DataGridView1.Columns(6).Width = reservasi.DataGridView1.Size.Width / 8
        reservasi.DataGridView1.Columns(7).Width = reservasi.DataGridView1.Size.Width / 8
        'MsgBox(reservasi.DataGridView1.Size.Width.ToString())
    End Sub

    Private Sub BtnPegawai_Click(sender As Object, e As EventArgs) Handles BtnPegawai.Click
        'Me.Controls.Add(pegawai)
        dashboard.Visible = False
        reservasi.Visible = False
        tamu.Visible = False
        kamar.Visible = False
        pegawai.Visible = True
        uang.Visible = False
        'pegawai.FormLevel.Items.Add("admin")
        'pegawai.FormLevel.Items.Add("pegawai")
        ' customize size and location for pegawai (user control)
        pegawai.Size = New Size((PanjangWindow - PanelSideBar.Width) - 100, (TinggiWindow - 100))
        pegawai.Location = New Point((PanelSideBar.Width + 50), PanelSideBar.Location.Y + 50)
        ' lokasi text halaman pegawai
        pegawai.TxtPegawai.Location = New Point((pegawai.Width - 150), (pegawai.Height - 570))
        ' lokasi text daftar pegawai
        pegawai.TxtDaftar.Location = New Point((pegawai.Location.X - 200), (pegawai.Location.Y + 270))
        ' lokasi text form
        pegawai.TxtName.Location = New Point((pegawai.Location.X - 150), (pegawai.Location.Y))
        pegawai.TxtUsername.Location = New Point((pegawai.Location.X - 150), (pegawai.Location.Y + 40))
        pegawai.TxtEmail.Location = New Point((pegawai.Location.X - 150), (pegawai.Location.Y + 80))
        pegawai.TxtPassword.Location = New Point((pegawai.Location.X - 150), (pegawai.Location.Y + 120))
        pegawai.TxtLevel.Location = New Point((pegawai.Location.X - 150), (pegawai.Location.Y + 160))
        pegawai.TxtCari.Location = New Point((pegawai.Location.X + 450), (pegawai.Location.Y + 270))
        ' lokasi input form
        pegawai.FormName.Location = New Point((pegawai.Location.X - 50), (pegawai.Location.Y))
        pegawai.FormUsername.Location = New Point((pegawai.Location.X - 50), (pegawai.Location.Y + 40))
        pegawai.FormEmail.Location = New Point((pegawai.Location.X - 50), (pegawai.Location.Y + 80))
        pegawai.FormPassword.Location = New Point((pegawai.Location.X - 50), (pegawai.Location.Y + 120))
        pegawai.FormLevel.Location = New Point((pegawai.Location.X - 50), (pegawai.Location.Y + 160))
        pegawai.FormCari.Location = New Point((pegawai.Location.X + 500), (pegawai.Location.Y + 270))
        ' lokasi tombol button1,button2,button3
        pegawai.Button1.Location = New Point((pegawai.Location.X - 150), (pegawai.Location.Y + 220))
        pegawai.Button2.Location = New Point((pegawai.Location.X - 50), (pegawai.Location.Y + 220))
        pegawai.Button3.Location = New Point((pegawai.Location.X + 50), (pegawai.Location.Y + 220))
        pegawai.Button4.Location = New Point((pegawai.Location.X + 150), (pegawai.Location.Y + 220))
        ' ukuran datagridview untuk daftar pegawai
        pegawai.DataGridView1.Size = New Size((pegawai.Width - 100), pegawai.Height - 400)
        ' lokasi datagridview untuk daftar pegawai
        pegawai.DataGridView1.Location = New Point((PanelSideBar.Location.X + 50), (pegawai.Location.Y + 300))
        ' mengatur ukuran kolom di data grid view dengan rumus panjang datagridview dibagi jumlah kolom
        pegawai.DataGridView1.Columns(0).Width = pegawai.DataGridView1.Size.Width / 5
        pegawai.DataGridView1.Columns(1).Width = pegawai.DataGridView1.Size.Width / 5
        pegawai.DataGridView1.Columns(2).Width = pegawai.DataGridView1.Size.Width / 5
        pegawai.DataGridView1.Columns(3).Width = pegawai.DataGridView1.Size.Width / 5
        pegawai.DataGridView1.Columns(4).Width = pegawai.DataGridView1.Size.Width / 5
    End Sub

    Private Sub BtnKamar_Click(sender As Object, e As EventArgs) Handles BtnKamar.Click
        'Me.Controls.Add(kamar)
        dashboard.Visible = False
        reservasi.Visible = False
        tamu.Visible = False
        kamar.Visible = True
        pegawai.Visible = False
        uang.Visible = False
        kamar.Start()
        kamar.ViewData()
        kamar.ViewKamarTersedia()
        kamar.ViewTotalKamar()
        ' customize size and location for kamar user control
        kamar.Size = New Size((PanjangWindow - PanelSideBar.Width) - 100, (TinggiWindow - 100))
        kamar.Location = New Point((PanelSideBar.Width + 50), 50)
        ' ukuran datagridview untuk daftar kamar
        kamar.DataGridView1.Size = New Size((kamar.Width - 100), kamar.Height - 400)
        ' lokasi datagridview untuk daftar kamar
        kamar.DataGridView1.Location = New Point((PanelSideBar.Location.X + 50), (kamar.Location.Y + 300))
        ' mengatur nama kolom di data grid view
        kamar.DataGridView1.Columns(0).HeaderText = "ID"
        kamar.DataGridView1.Columns(1).HeaderText = "Tipe Kamar"
        kamar.DataGridView1.Columns(2).HeaderText = "Harga"
        kamar.DataGridView1.Columns(3).HeaderText = "Status"
        kamar.DataGridView1.Columns(4).HeaderText = "Tersedia"
        kamar.DataGridView1.Columns(5).HeaderText = "Fasilitas"
        ' mengatur ukuran kolom di data grid view dengan rumus panjang datagridview dibagi jumlah kolom
        kamar.DataGridView1.Columns(0).Width = kamar.DataGridView1.Size.Width / 6
        kamar.DataGridView1.Columns(1).Width = kamar.DataGridView1.Size.Width / 6
        kamar.DataGridView1.Columns(2).Width = kamar.DataGridView1.Size.Width / 6
        kamar.DataGridView1.Columns(3).Width = kamar.DataGridView1.Size.Width / 6
        kamar.DataGridView1.Columns(4).Width = kamar.DataGridView1.Size.Width / 6
        kamar.DataGridView1.Columns(5).Width = kamar.DataGridView1.Size.Width / 6

        ' lokasi label form input
        kamar.Label1.Location = New Point((kamar.Location.X - 150), (kamar.Location.Y))
        kamar.Label2.Location = New Point((kamar.Location.X - 150), (kamar.Location.Y + 40))
        kamar.Label3.Location = New Point((kamar.Location.X - 150), (kamar.Location.Y + 80))
        kamar.Label4.Location = New Point((kamar.Location.X - 150), (kamar.Location.Y + 120))
        kamar.Label5.Location = New Point((kamar.Location.X - 150), (kamar.Location.Y + 160))
        kamar.Label6.Location = New Point((kamar.Location.X + 450), (kamar.Location.Y + 270))
        kamar.CheckBox1.Location = New Point((kamar.Location.X + 200), (kamar.Location.Y + 270))
        ' lokasi form
        kamar.ComboBox1.Location = New Point((kamar.Location.X + 50), (kamar.Location.Y))
        kamar.TextBox1.Location = New Point((kamar.Location.X + 50), (kamar.Location.Y + 40))
        kamar.ComboBox2.Location = New Point((kamar.Location.X + 50), (kamar.Location.Y + 80))
        kamar.ComboBox3.Location = New Point((kamar.Location.X + 50), (kamar.Location.Y + 120))
        kamar.TextBox2.Location = New Point((kamar.Location.X + 50), (kamar.Location.Y + 160))
        kamar.TextBox3.Location = New Point((kamar.Location.X + 500), (kamar.Location.Y + 270))
        ' lokasi button
        kamar.Button1.Location = New Point((kamar.Location.X - 150), (kamar.Location.Y + 230))
        kamar.Button2.Location = New Point((kamar.Location.X - 50), (kamar.Location.Y + 230))
        kamar.Button3.Location = New Point((kamar.Location.X + 50), (kamar.Location.Y + 230))
        kamar.Button4.Location = New Point((kamar.Location.X + 150), (kamar.Location.Y + 230))
        ' lokasi group box
        kamar.GroupBox1.Location = New Point((kamar.Location.X + 580), (kamar.Location.Y))
        kamar.GroupBox2.Location = New Point((kamar.Location.X + 300), (kamar.Location.Y))
        kamar.Label7.Location = New Point((kamar.GroupBox1.Width - kamar.Label7.Width) / 2, (kamar.GroupBox1.Height - kamar.Label7.Height) / 2)
        kamar.Label8.Location = New Point((kamar.GroupBox2.Width - kamar.Label8.Width) / 2, (kamar.GroupBox2.Height - kamar.Label8.Height) / 2)
    End Sub

    Private Sub BtnTamu_Click(sender As Object, e As EventArgs) Handles BtnTamu.Click
        dashboard.Visible = False
        reservasi.Visible = False
        tamu.Visible = True
        kamar.Visible = False
        pegawai.Visible = False
        uang.Visible = False
        ' awalan
        tamu.start()
        ' lokasi dan ukuran user control (tamu)
        tamu.Size = New Size((PanjangWindow - PanelSideBar.Width) - 100, (TinggiWindow - 100))
        tamu.Location = New Point((PanelSideBar.Width + 50), 50)
        ' lokasi groupbox
        tamu.GroupBox1.Location = New Point((tamu.Location.X + 300), (tamu.Location.Y))
        tamu.GroupBox2.Location = New Point((tamu.Location.X + 550), (tamu.Location.Y))
        ' lokasi label form 
        tamu.Label1.Location = New Point((tamu.Location.X - 150), (tamu.Location.Y))
        tamu.Label2.Location = New Point((tamu.Location.X - 150), (tamu.Location.Y + 40))
        tamu.Label3.Location = New Point((tamu.Location.X - 150), (tamu.Location.Y + 80))
        tamu.Label4.Location = New Point((tamu.Location.X - 150), (tamu.Location.Y + 120))
        tamu.Label5.Location = New Point((tamu.Location.X - 170), (tamu.Location.Y + 210))
        tamu.Label6.Location = New Point((tamu.Location.X + 430), (tamu.Location.Y + 210))
        tamu.Label7.Location = New Point((tamu.GroupBox1.Width - tamu.Label7.Width) / 2, (tamu.GroupBox1.Height - tamu.Label7.Height) / 2)
        tamu.Label8.Location = New Point((tamu.GroupBox2.Width - tamu.Label8.Width) / 2, (tamu.GroupBox2.Height - tamu.Label8.Height) / 2)
        ' lokasi input form
        tamu.TextBox1.Location = New Point((tamu.Location.X - 20), (tamu.Location.Y))
        tamu.TextBox2.Location = New Point((tamu.Location.X - 20), (tamu.Location.Y + 40))
        tamu.TextBox3.Location = New Point((tamu.Location.X - 20), (tamu.Location.Y + 80))
        tamu.TextBox4.Location = New Point((tamu.Location.X - 20), (tamu.Location.Y + 120))
        tamu.TextBox5.Location = New Point((tamu.Location.X + 480), (tamu.Location.Y + 210))
        ' lokasi button
        tamu.Button1.Location = New Point((tamu.Location.X - 150), (tamu.Location.Y + 165))
        tamu.Button2.Location = New Point((tamu.Location.X - 50), (tamu.Location.Y + 165))
        tamu.Button3.Location = New Point((tamu.Location.X + 50), (tamu.Location.Y + 165))
        tamu.Button4.Location = New Point((tamu.Location.X + 150), (tamu.Location.Y + 165))
        ' ukuran datagridview untuk daftar tamu
        tamu.DataGridView1.Size = New Size((tamu.Width - 100), tamu.Height - 320)
        ' lokasi datagridview untuk daftar tamu
        tamu.DataGridView1.Location = New Point((PanelSideBar.Location.X + 50), (tamu.Location.Y + 240))
        tamu.DataGridView1.Columns(0).HeaderText = "ID Tamu"
        tamu.DataGridView1.Columns(1).HeaderText = "Nama Tamu"
        tamu.DataGridView1.Columns(2).HeaderText = "No Telepon"
        tamu.DataGridView1.Columns(3).HeaderText = "No Identitas"
        tamu.DataGridView1.Columns(4).HeaderText = "Email"
        tamu.DataGridView1.Columns(5).HeaderText = "Di Masukkan Oleh"
        ' mengatur ukuran kolom di data grid view dengan rumus panjang datagridview dibagi jumlah kolom
        tamu.DataGridView1.Columns(0).Width = tamu.DataGridView1.Size.Width / 6
        tamu.DataGridView1.Columns(1).Width = tamu.DataGridView1.Size.Width / 6
        tamu.DataGridView1.Columns(2).Width = tamu.DataGridView1.Size.Width / 6
        tamu.DataGridView1.Columns(3).Width = tamu.DataGridView1.Size.Width / 6
        tamu.DataGridView1.Columns(4).Width = tamu.DataGridView1.Size.Width / 6
        tamu.DataGridView1.Columns(5).Width = tamu.DataGridView1.Size.Width / 6
    End Sub

    Private Sub BtnKeuangan_Click(sender As Object, e As EventArgs) Handles BtnKeuangan.Click
        dashboard.Visible = False
        reservasi.Visible = False
        tamu.Visible = False
        kamar.Visible = False
        pegawai.Visible = False
        uang.Visible = True
        uang.Start()
        uang.Size = New Size((PanjangWindow - PanelSideBar.Width) - 100, (TinggiWindow - 100))
        uang.Location = New Point((PanelSideBar.Width + 50), 50)

        ' lokasi label
        uang.Label1.Location = New Point((uang.Location.X - 150), (uang.Location.Y))
        uang.Label2.Location = New Point((uang.Location.X - 150), (uang.Location.Y + 40))

        'lokasi button
        uang.Button1.Location = New Point((uang.Location.X - 150), (uang.Location.Y + 100))
        uang.Button2.Location = New Point((uang.Location.X - 50), (uang.Location.Y + 100))
        uang.Button3.Location = New Point((uang.Location.X + 50), (uang.Location.Y + 100))
        uang.Button4.Location = New Point((uang.Location.X + 150), (uang.Location.Y + 100))
        ' lokasi textbox
        uang.TextBox1.Location = New Point((uang.Location.X + 40), (uang.Location.Y))
        uang.TextBox2.Location = New Point((uang.Location.X + 40), (uang.Location.Y + 40))

        ' lokasi grupbox
        uang.GroupBox1.Location = New Point((uang.Location.X + 300), (uang.Location.Y))
        uang.GroupBox2.Location = New Point((uang.Location.X + 550), (uang.Location.Y))
        uang.GroupBox3.Location = New Point((uang.Location.X + 300), (uang.Location.Y + 150))
        uang.GroupBox4.Location = New Point((uang.Location.X + 550), (uang.Location.Y + 150))

        uang.DataGridView1.Size = New Size((uang.Width - 100), uang.Height - 400)
        uang.DataGridView1.Location = New Point((PanelSideBar.Location.X + 50), (uang.Location.Y + 300))
        
        uang.DataGridView1.Columns(0).HeaderText = "ID"
        uang.DataGridView1.Columns(1).HeaderText = "Total Pengeluaran"
        uang.DataGridView1.Columns(2).HeaderText = "Deskripsi"
        uang.DataGridView1.Columns(3).HeaderText = "UPDATED AT"
        uang.DataGridView1.Columns(4).HeaderText = "CREATED AT"

        uang.DataGridView1.Columns(0).Width = uang.DataGridView1.Size.Width / 5
        uang.DataGridView1.Columns(1).Width = uang.DataGridView1.Size.Width / 5
        uang.DataGridView1.Columns(2).Width = uang.DataGridView1.Size.Width / 5
        uang.DataGridView1.Columns(3).Width = uang.DataGridView1.Size.Width / 5
        uang.DataGridView1.Columns(4).Width = uang.DataGridView1.Size.Width / 5

    End Sub

    Private Sub Form2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ' Menghentikan semua proses aplikasi ketika aplikasi ditutup
        Dim currentProcess As Process = Process.GetCurrentProcess()
        Dim processName As String = currentProcess.ProcessName

        ' Mencari proses dengan nama aplikasi saat ini
        Dim processes As Process() = Process.GetProcessesByName(processName)

        ' Menghentikan setiap proses dengan nama aplikasi saat ini
        For Each process As Process In processes
            If process.Id <> currentProcess.Id Then
                ' Menghentikan proses lain selain proses utama
                process.Kill()
            End If
        Next
    End Sub
End Class