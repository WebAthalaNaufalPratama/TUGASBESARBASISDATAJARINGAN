<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PegawaiControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        TxtPegawai = New Label()
        DataGridView1 = New DataGridView()
        FormName = New TextBox()
        TxtDaftar = New Label()
        FormUsername = New TextBox()
        FormEmail = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        FormLevel = New ComboBox()
        FormPassword = New TextBox()
        TxtName = New Label()
        TxtUsername = New Label()
        TxtEmail = New Label()
        TxtPassword = New Label()
        TxtLevel = New Label()
        Button4 = New Button()
        FormCari = New TextBox()
        TxtCari = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TxtPegawai
        ' 
        TxtPegawai.AutoSize = True
        TxtPegawai.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TxtPegawai.Location = New Point(563, 31)
        TxtPegawai.Name = "TxtPegawai"
        TxtPegawai.Size = New Size(136, 18)
        TxtPegawai.TabIndex = 0
        TxtPegawai.Text = "Halaman Pegawai"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(89, 185)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(240, 150)
        DataGridView1.TabIndex = 1
        ' 
        ' FormName
        ' 
        FormName.Location = New Point(314, 83)
        FormName.Name = "FormName"
        FormName.Size = New Size(200, 23)
        FormName.TabIndex = 2
        ' 
        ' TxtDaftar
        ' 
        TxtDaftar.AutoSize = True
        TxtDaftar.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TxtDaftar.Location = New Point(89, 155)
        TxtDaftar.Name = "TxtDaftar"
        TxtDaftar.Size = New Size(117, 18)
        TxtDaftar.TabIndex = 6
        TxtDaftar.Text = "Daftar Pegawai"
        ' 
        ' FormUsername
        ' 
        FormUsername.Location = New Point(314, 13)
        FormUsername.Name = "FormUsername"
        FormUsername.Size = New Size(200, 23)
        FormUsername.TabIndex = 7
        ' 
        ' FormEmail
        ' 
        FormEmail.Location = New Point(314, 42)
        FormEmail.Name = "FormEmail"
        FormEmail.Size = New Size(200, 23)
        FormEmail.TabIndex = 8
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.Location = New Point(314, 146)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 9
        Button1.Text = "Button1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Button2.Location = New Point(445, 188)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 10
        Button2.Text = "Button2"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Button3.Location = New Point(456, 130)
        Button3.Name = "Button3"
        Button3.Size = New Size(75, 23)
        Button3.TabIndex = 11
        Button3.Text = "8"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' FormLevel
        ' 
        FormLevel.FormattingEnabled = True
        FormLevel.Items.AddRange(New Object() {"admin", "pegawai"})
        FormLevel.Location = New Point(487, 71)
        FormLevel.Name = "FormLevel"
        FormLevel.Size = New Size(200, 23)
        FormLevel.TabIndex = 13
        ' 
        ' FormPassword
        ' 
        FormPassword.Location = New Point(89, 74)
        FormPassword.Name = "FormPassword"
        FormPassword.Size = New Size(200, 23)
        FormPassword.TabIndex = 14
        ' 
        ' TxtName
        ' 
        TxtName.AutoSize = True
        TxtName.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TxtName.Location = New Point(125, 15)
        TxtName.Name = "TxtName"
        TxtName.Size = New Size(50, 18)
        TxtName.TabIndex = 15
        TxtName.Text = "Nama"
        ' 
        ' TxtUsername
        ' 
        TxtUsername.AutoSize = True
        TxtUsername.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TxtUsername.Location = New Point(347, 179)
        TxtUsername.Name = "TxtUsername"
        TxtUsername.Size = New Size(80, 18)
        TxtUsername.TabIndex = 16
        TxtUsername.Text = "Username"
        ' 
        ' TxtEmail
        ' 
        TxtEmail.AutoSize = True
        TxtEmail.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TxtEmail.Location = New Point(332, 179)
        TxtEmail.Name = "TxtEmail"
        TxtEmail.Size = New Size(48, 18)
        TxtEmail.TabIndex = 17
        TxtEmail.Text = "Email"
        ' 
        ' TxtPassword
        ' 
        TxtPassword.AutoSize = True
        TxtPassword.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TxtPassword.Location = New Point(332, 179)
        TxtPassword.Name = "TxtPassword"
        TxtPassword.Size = New Size(78, 18)
        TxtPassword.TabIndex = 18
        TxtPassword.Text = "Password"
        ' 
        ' TxtLevel
        ' 
        TxtLevel.AutoSize = True
        TxtLevel.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TxtLevel.Location = New Point(332, 179)
        TxtLevel.Name = "TxtLevel"
        TxtLevel.Size = New Size(45, 18)
        TxtLevel.TabIndex = 19
        TxtLevel.Text = "Level"
        ' 
        ' Button4
        ' 
        Button4.Font = New Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Button4.Location = New Point(335, 177)
        Button4.Name = "Button4"
        Button4.Size = New Size(75, 23)
        Button4.TabIndex = 20
        Button4.Text = "Button4"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' FormCari
        ' 
        FormCari.Location = New Point(487, 246)
        FormCari.Name = "FormCari"
        FormCari.Size = New Size(200, 23)
        FormCari.TabIndex = 21
        ' 
        ' TxtCari
        ' 
        TxtCari.AutoSize = True
        TxtCari.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TxtCari.Location = New Point(425, 246)
        TxtCari.Name = "TxtCari"
        TxtCari.Size = New Size(38, 18)
        TxtCari.TabIndex = 22
        TxtCari.Text = "Cari"
        ' 
        ' PegawaiControl
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        Controls.Add(TxtCari)
        Controls.Add(FormCari)
        Controls.Add(Button4)
        Controls.Add(TxtLevel)
        Controls.Add(TxtPassword)
        Controls.Add(TxtEmail)
        Controls.Add(TxtUsername)
        Controls.Add(TxtName)
        Controls.Add(FormPassword)
        Controls.Add(FormLevel)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(FormEmail)
        Controls.Add(FormUsername)
        Controls.Add(TxtDaftar)
        Controls.Add(FormName)
        Controls.Add(DataGridView1)
        Controls.Add(TxtPegawai)
        Name = "PegawaiControl"
        Size = New Size(745, 376)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TxtPegawai As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents FormName As TextBox
    Friend WithEvents TxtDaftar As Label
    Friend WithEvents FormUsername As TextBox
    Friend WithEvents FormEmail As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents FormLevel As ComboBox
    Friend WithEvents FormPassword As TextBox
    Friend WithEvents TxtName As Label
    Friend WithEvents TxtUsername As Label
    Friend WithEvents TxtEmail As Label
    Friend WithEvents TxtPassword As Label
    Friend WithEvents TxtLevel As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents FormCari As TextBox
    Friend WithEvents TxtCari As Label
End Class
