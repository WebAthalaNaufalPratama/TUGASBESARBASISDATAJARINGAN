<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        PanelSideBar = New Panel()
        BtnPegawai = New Button()
        BtnLogout = New Button()
        BtnKeuangan = New Button()
        BtnKamar = New Button()
        BtnTamu = New Button()
        BtnReservasi = New Button()
        BtnDashboard = New Button()
        PanelSideBar.SuspendLayout()
        SuspendLayout()
        ' 
        ' PanelSideBar
        ' 
        PanelSideBar.BackColor = Color.WhiteSmoke
        PanelSideBar.Controls.Add(BtnPegawai)
        PanelSideBar.Controls.Add(BtnLogout)
        PanelSideBar.Controls.Add(BtnKeuangan)
        PanelSideBar.Controls.Add(BtnKamar)
        PanelSideBar.Controls.Add(BtnTamu)
        PanelSideBar.Controls.Add(BtnReservasi)
        PanelSideBar.Controls.Add(BtnDashboard)
        PanelSideBar.Location = New Point(0, 3)
        PanelSideBar.Name = "PanelSideBar"
        PanelSideBar.Size = New Size(200, 469)
        PanelSideBar.TabIndex = 0
        ' 
        ' BtnPegawai
        ' 
        BtnPegawai.BackColor = Color.MediumOrchid
        BtnPegawai.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        BtnPegawai.ForeColor = Color.GhostWhite
        BtnPegawai.Location = New Point(-3, 279)
        BtnPegawai.Name = "BtnPegawai"
        BtnPegawai.Size = New Size(200, 36)
        BtnPegawai.TabIndex = 6
        BtnPegawai.Text = "Pegawai"
        BtnPegawai.UseVisualStyleBackColor = False
        ' 
        ' BtnLogout
        ' 
        BtnLogout.BackColor = Color.MediumOrchid
        BtnLogout.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        BtnLogout.ForeColor = Color.GhostWhite
        BtnLogout.Location = New Point(-3, 321)
        BtnLogout.Name = "BtnLogout"
        BtnLogout.Size = New Size(200, 36)
        BtnLogout.TabIndex = 5
        BtnLogout.Text = "Log Out"
        BtnLogout.UseVisualStyleBackColor = False
        ' 
        ' BtnKeuangan
        ' 
        BtnKeuangan.BackColor = Color.MediumOrchid
        BtnKeuangan.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        BtnKeuangan.ForeColor = Color.GhostWhite
        BtnKeuangan.Location = New Point(0, 237)
        BtnKeuangan.Name = "BtnKeuangan"
        BtnKeuangan.Size = New Size(200, 36)
        BtnKeuangan.TabIndex = 4
        BtnKeuangan.Text = "Keuangan"
        BtnKeuangan.UseVisualStyleBackColor = False
        ' 
        ' BtnKamar
        ' 
        BtnKamar.BackColor = Color.MediumOrchid
        BtnKamar.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        BtnKamar.ForeColor = Color.GhostWhite
        BtnKamar.Location = New Point(0, 195)
        BtnKamar.Name = "BtnKamar"
        BtnKamar.Size = New Size(200, 36)
        BtnKamar.TabIndex = 3
        BtnKamar.Text = "Kamar"
        BtnKamar.UseVisualStyleBackColor = False
        ' 
        ' BtnTamu
        ' 
        BtnTamu.BackColor = Color.MediumOrchid
        BtnTamu.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        BtnTamu.ForeColor = Color.GhostWhite
        BtnTamu.Location = New Point(0, 153)
        BtnTamu.Name = "BtnTamu"
        BtnTamu.Size = New Size(200, 36)
        BtnTamu.TabIndex = 2
        BtnTamu.Text = "Daftar Tamu"
        BtnTamu.UseVisualStyleBackColor = False
        ' 
        ' BtnReservasi
        ' 
        BtnReservasi.BackColor = Color.MediumOrchid
        BtnReservasi.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        BtnReservasi.ForeColor = Color.GhostWhite
        BtnReservasi.Location = New Point(0, 115)
        BtnReservasi.Name = "BtnReservasi"
        BtnReservasi.Size = New Size(200, 36)
        BtnReservasi.TabIndex = 1
        BtnReservasi.Text = "Reservasi"
        BtnReservasi.UseVisualStyleBackColor = False
        ' 
        ' BtnDashboard
        ' 
        BtnDashboard.BackColor = Color.MediumOrchid
        BtnDashboard.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        BtnDashboard.ForeColor = Color.GhostWhite
        BtnDashboard.Location = New Point(0, 73)
        BtnDashboard.Name = "BtnDashboard"
        BtnDashboard.Size = New Size(200, 36)
        BtnDashboard.TabIndex = 0
        BtnDashboard.Text = "Dashboard"
        BtnDashboard.UseVisualStyleBackColor = False
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.MediumOrchid
        ClientSize = New Size(800, 450)
        Controls.Add(PanelSideBar)
        ForeColor = Color.MediumOrchid
        Name = "Form2"
        Text = "Dashboard - Aplikasi Hotel Kelompok 7"
        WindowState = FormWindowState.Maximized
        PanelSideBar.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents PanelSideBar As Panel
    Friend WithEvents BtnDashboard As Button
    Friend WithEvents BtnReservasi As Button
    Friend WithEvents BtnTamu As Button
    Friend WithEvents BtnKeuangan As Button
    Friend WithEvents BtnKamar As Button
    Friend WithEvents BtnLogout As Button
    Friend WithEvents BtnPegawai As Button
End Class
