<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReservasiControl
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
        Label1 = New Label()
        Label2 = New Label()
        GroupBox1 = New GroupBox()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        DataGridView1 = New DataGridView()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        CheckBox1 = New CheckBox()
        CheckBox2 = New CheckBox()
        DateTimePicker1 = New DateTimePicker()
        DateTimePicker2 = New DateTimePicker()
        Label3 = New Label()
        Label4 = New Label()
        GroupBox2 = New GroupBox()
        Label9 = New Label()
        Label10 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        GroupBox3 = New GroupBox()
        Label8 = New Label()
        Label11 = New Label()
        Label12 = New Label()
        TextBox3 = New TextBox()
        GroupBox1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(76, 75)
        Label1.Name = "Label1"
        Label1.Size = New Size(64, 18)
        Label1.TabIndex = 0
        Label1.Text = "ID Tamu"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(76, 110)
        Label2.Name = "Label2"
        Label2.Size = New Size(55, 18)
        Label2.TabIndex = 1
        Label2.Text = "Kamar"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.MediumOrchid
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        GroupBox1.ForeColor = Color.WhiteSmoke
        GroupBox1.Location = New Point(475, 66)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(250, 100)
        GroupBox1.TabIndex = 4
        GroupBox1.TabStop = False
        GroupBox1.Text = "Detail Tamu"
        ' 
        ' Label7
        ' 
        Label7.Font = New Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(15, 70)
        Label7.Name = "Label7"
        Label7.Size = New Size(229, 15)
        Label7.TabIndex = 2
        Label7.Text = "No Telp :"
        ' 
        ' Label6
        ' 
        Label6.Font = New Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(15, 50)
        Label6.Name = "Label6"
        Label6.Size = New Size(229, 15)
        Label6.TabIndex = 1
        Label6.Text = "No KTP :"
        ' 
        ' Label5
        ' 
        Label5.Font = New Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(15, 32)
        Label5.Name = "Label5"
        Label5.Size = New Size(229, 15)
        Label5.TabIndex = 0
        Label5.Text = "Nama : "
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(539, 309)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(240, 150)
        DataGridView1.TabIndex = 19
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(209, 70)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(200, 23)
        TextBox1.TabIndex = 5
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(209, 110)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(200, 23)
        TextBox2.TabIndex = 6
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        CheckBox1.Location = New Point(76, 209)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.RightToLeft = RightToLeft.Yes
        CheckBox1.Size = New Size(136, 22)
        CheckBox1.TabIndex = 8
        CheckBox1.Text = "Sudah Check In"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        CheckBox2.Location = New Point(79, 244)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.RightToLeft = RightToLeft.Yes
        CheckBox2.Size = New Size(149, 22)
        CheckBox2.TabIndex = 9
        CheckBox2.Text = "Sudah Check Out"
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(251, 144)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(200, 23)
        DateTimePicker1.TabIndex = 10
        ' 
        ' DateTimePicker2
        ' 
        DateTimePicker2.Location = New Point(251, 176)
        DateTimePicker2.Name = "DateTimePicker2"
        DateTimePicker2.Size = New Size(200, 23)
        DateTimePicker2.TabIndex = 11
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(85, 149)
        Label3.Name = "Label3"
        Label3.Size = New Size(126, 18)
        Label3.TabIndex = 12
        Label3.Text = "Tanggal Check In"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(79, 288)
        Label4.Name = "Label4"
        Label4.Size = New Size(139, 18)
        Label4.TabIndex = 13
        Label4.Text = "Tanggal Check Out"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = Color.MediumOrchid
        GroupBox2.Controls.Add(Label9)
        GroupBox2.Controls.Add(Label10)
        GroupBox2.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        GroupBox2.ForeColor = Color.WhiteSmoke
        GroupBox2.Location = New Point(475, 176)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(250, 100)
        GroupBox2.TabIndex = 5
        GroupBox2.TabStop = False
        GroupBox2.Text = "Detail Kamar"
        ' 
        ' Label9
        ' 
        Label9.Font = New Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label9.Location = New Point(15, 50)
        Label9.Name = "Label9"
        Label9.Size = New Size(229, 15)
        Label9.TabIndex = 1
        Label9.Text = "Harga/Malam :"
        ' 
        ' Label10
        ' 
        Label10.Font = New Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label10.Location = New Point(15, 32)
        Label10.Name = "Label10"
        Label10.Size = New Size(229, 15)
        Label10.TabIndex = 0
        Label10.Text = "Tipe Kamar : "
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.Location = New Point(86, 333)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 14
        Button1.Text = "Button1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Button2.Location = New Point(143, 309)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 15
        Button2.Text = "Button2"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Button3.Location = New Point(202, 333)
        Button3.Name = "Button3"
        Button3.Size = New Size(75, 23)
        Button3.TabIndex = 16
        Button3.Text = "Button3"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Font = New Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Button4.Location = New Point(283, 333)
        Button4.Name = "Button4"
        Button4.Size = New Size(75, 23)
        Button4.TabIndex = 17
        Button4.Text = "Button4"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Font = New Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Button5.Location = New Point(364, 333)
        Button5.Name = "Button5"
        Button5.Size = New Size(75, 23)
        Button5.TabIndex = 18
        Button5.Text = "Button5"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' GroupBox3
        ' 
        GroupBox3.BackColor = Color.MediumOrchid
        GroupBox3.Controls.Add(Label8)
        GroupBox3.Controls.Add(Label11)
        GroupBox3.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        GroupBox3.ForeColor = Color.WhiteSmoke
        GroupBox3.Location = New Point(304, 226)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(200, 100)
        GroupBox3.TabIndex = 6
        GroupBox3.TabStop = False
        GroupBox3.Text = "Detail Pesanan"
        ' 
        ' Label8
        ' 
        Label8.Font = New Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.Location = New Point(15, 50)
        Label8.Name = "Label8"
        Label8.Size = New Size(250, 15)
        Label8.TabIndex = 1
        Label8.Text = "Tagihan : "
        ' 
        ' Label11
        ' 
        Label11.Font = New Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label11.Location = New Point(15, 32)
        Label11.Name = "Label11"
        Label11.Size = New Size(185, 15)
        Label11.TabIndex = 0
        Label11.Text = "Menginap"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label12.Location = New Point(34, 311)
        Label12.Name = "Label12"
        Label12.Size = New Size(38, 18)
        Label12.TabIndex = 20
        Label12.Text = "Cari"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(257, 22)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(200, 23)
        TextBox3.TabIndex = 21
        ' 
        ' ReservasiControl
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        Controls.Add(TextBox3)
        Controls.Add(Label12)
        Controls.Add(DataGridView1)
        Controls.Add(GroupBox3)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(GroupBox2)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(DateTimePicker2)
        Controls.Add(DateTimePicker1)
        Controls.Add(CheckBox2)
        Controls.Add(CheckBox1)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(GroupBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "ReservasiControl"
        Size = New Size(806, 519)
        GroupBox1.ResumeLayout(False)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        GroupBox3.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label12 As Label
    Friend WithEvents TextBox3 As TextBox
End Class
