Imports BCrypt.Net.BCrypt
Imports System.Data.SqlClient
Imports System.IO

Public Class Form1
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim jam As DateTime = DateTime.Parse("2023-06-30 09:39:23")
        'MsgBox(jam.ToString())
        'Me.Hide()
        'Dim form2 As New Form2()
        'Form2.ShowDialog()
        'login
        passwordBox.UseSystemPasswordChar = True
        Dim PanjangWindow = Me.ClientSize.Width
        Dim TinggiWindow = Me.ClientSize.Height
        'TextBox1.Left = (Me.ClientSize.Width - TextBox1.Width) \ 2
        'FormName.Location = New Point()
        'MsgBox(PanjangWindow / 2)
        Panel.Width = PanjangWindow - 700
        Panel.Height = TinggiWindow - 300
        Dim WidthPanel = Panel.Width
        Dim HeightPanel = Panel.Height
        Panel.Location = New Point((PanjangWindow - Panel.Width) \ 2, (TinggiWindow - Panel.Height) \ 2)
        FormName.Location = New Point((WidthPanel - FormName.Width) \ 2, (HeightPanel - FormName.Height) \ 250)
        'boxUsername.Enabled = False
        username.Location = New Point((WidthPanel - username.Width) \ 2, (HeightPanel - username.Height) \ 2 - 50)
        password.Location = New Point((WidthPanel - password.Width) \ 2, (HeightPanel - password.Height) \ 2 + 20)
        ButtonLogin.Location = New Point((WidthPanel - ButtonLogin.Width) \ 2, (HeightPanel - ButtonLogin.Height) \ 2 + 90)
    End Sub

    Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles ButtonLogin.Click
        If boxUsername.Text = "" And passwordBox.Text = "" Then
            MsgBox("Username dan Password harus diisi !")
        End If
        If boxUsername.Text <> "" And passwordBox.Text <> "" Then
            Dim username = boxUsername.Text
            Dim password = passwordBox.Text
            Try
                Dim connectionString As String = "Data Source=localhost;Initial Catalog=db_hotel;User ID=mine;Password=user@123;"
                Dim connection As New SqlConnection(connectionString)
                connection.Open()
                Dim query As String = "SELECT TOP (1) * FROM [tb_pegawai] WHERE [username] = @value"
                Dim command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@value", username)
                Dim reader As SqlDataReader = command.ExecuteReader()
                Dim path As String = "D:\logs.txt"
                If reader.Read() Then
                    Dim resId As Integer = reader.GetInt32(0)
                    Dim resName As String = reader.GetString(1)
                    Dim resUsername As String = reader.GetString(2)
                    Dim resEmail As String = reader.GetString(3)
                    Dim resPassword As String = reader.GetString(4)
                    Dim resLevel As String = reader.GetString(5)
                    My.Computer.FileSystem.WriteAllText(path, reader.Read().ToString(), True)
                    'MsgBox(resPassword)
                    If BCrypt.Net.BCrypt.Verify(password, resPassword) Then
                        User.Id = resId
                        User.name = resName
                        Level = resLevel
                        User.username = resUsername
                        User.email = resEmail
                        connection.Close()
                        Me.Hide()
                        Dim form2 As New Form2()
                        form2.ShowDialog()
                    Else
                        boxUsername.Text = ""
                        passwordBox.Text = ""
                        MsgBox("username atau password salah !")
                    End If
                Else
                    boxUsername.Text = ""
                    passwordBox.Text = ""
                    MsgBox("username atau password salah !")
                End If


            Catch ex As Exception
                MsgBox(ex.ToString())
            End Try
        End If
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
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
