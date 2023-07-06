<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Panel = New Panel()
        password = New GroupBox()
        passwordBox = New TextBox()
        username = New GroupBox()
        boxUsername = New TextBox()
        ButtonLogin = New Button()
        FormName = New Label()
        Panel.SuspendLayout()
        password.SuspendLayout()
        username.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel
        ' 
        Panel.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Panel.BackColor = Color.GhostWhite
        Panel.Controls.Add(password)
        Panel.Controls.Add(username)
        Panel.Controls.Add(ButtonLogin)
        Panel.Controls.Add(FormName)
        Panel.Location = New Point(248, 131)
        Panel.Name = "Panel"
        Panel.Size = New Size(385, 291)
        Panel.TabIndex = 0
        ' 
        ' password
        ' 
        password.Controls.Add(passwordBox)
        password.Font = New Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point)
        password.Location = New Point(78, 156)
        password.Name = "password"
        password.Size = New Size(200, 63)
        password.TabIndex = 4
        password.TabStop = False
        password.Text = "Password"
        ' 
        ' passwordBox
        ' 
        passwordBox.Location = New Point(32, 22)
        passwordBox.Name = "passwordBox"
        passwordBox.Size = New Size(120, 26)
        passwordBox.TabIndex = 0
        ' 
        ' username
        ' 
        username.Controls.Add(boxUsername)
        username.Font = New Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point)
        username.Location = New Point(78, 75)
        username.Name = "username"
        username.Size = New Size(200, 63)
        username.TabIndex = 3
        username.TabStop = False
        username.Text = "Username"
        ' 
        ' boxUsername
        ' 
        boxUsername.Location = New Point(32, 22)
        boxUsername.Name = "boxUsername"
        boxUsername.Size = New Size(120, 26)
        boxUsername.TabIndex = 0
        ' 
        ' ButtonLogin
        ' 
        ButtonLogin.Location = New Point(62, 225)
        ButtonLogin.Name = "ButtonLogin"
        ButtonLogin.Size = New Size(100, 30)
        ButtonLogin.TabIndex = 2
        ButtonLogin.Text = "Login"
        ButtonLogin.UseVisualStyleBackColor = True
        ' 
        ' FormName
        ' 
        FormName.AutoSize = True
        FormName.Font = New Font("Arial", 40F, FontStyle.Regular, GraphicsUnit.Point)
        FormName.Location = New Point(100, 0)
        FormName.Name = "FormName"
        FormName.Size = New Size(174, 61)
        FormName.TabIndex = 1
        FormName.Text = "Login "
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.MediumOrchid
        ClientSize = New Size(800, 450)
        Controls.Add(Panel)
        Name = "Form1"
        Text = "Login - Aplikasi Hotel Kelompok 7"
        WindowState = FormWindowState.Maximized
        Panel.ResumeLayout(False)
        Panel.PerformLayout()
        password.ResumeLayout(False)
        password.PerformLayout()
        username.ResumeLayout(False)
        username.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel As Panel
    Friend WithEvents boxUsername As TextBox
    Friend WithEvents FormName As Label
    Friend WithEvents ButtonLogin As Button
    Friend WithEvents username As GroupBox
    Friend WithEvents password As GroupBox
    Friend WithEvents passwordBox As TextBox
End Class
