<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KamarControl
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
        DataGridView1 = New DataGridView()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        ComboBox1 = New ComboBox()
        ComboBox2 = New ComboBox()
        ComboBox3 = New ComboBox()
        TextBox1 = New TextBox()
        Label5 = New Label()
        TextBox2 = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        TextBox3 = New TextBox()
        Label6 = New Label()
        GroupBox1 = New GroupBox()
        Label7 = New Label()
        GroupBox2 = New GroupBox()
        Label8 = New Label()
        CheckBox1 = New CheckBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(492, 46)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(240, 150)
        DataGridView1.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(128, 72)
        Label1.Name = "Label1"
        Label1.Size = New Size(89, 18)
        Label1.TabIndex = 3
        Label1.Text = "Tipe Kamar"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(128, 120)
        Label2.Name = "Label2"
        Label2.Size = New Size(51, 18)
        Label2.TabIndex = 4
        Label2.Text = "Harga"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(384, 217)
        Label3.Name = "Label3"
        Label3.Size = New Size(52, 18)
        Label3.TabIndex = 5
        Label3.Text = "Status"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(208, 162)
        Label4.Name = "Label4"
        Label4.Size = New Size(68, 18)
        Label4.TabIndex = 6
        Label4.Text = "Tersedia"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Single Bed", "Double Bed"})
        ComboBox1.Location = New Point(452, 29)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(200, 23)
        ComboBox1.TabIndex = 7
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Items.AddRange(New Object() {"Bersih", "Kotor", "Sedang di Bersihkan", "Maintenance"})
        ComboBox2.Location = New Point(128, 29)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(200, 23)
        ComboBox2.TabIndex = 8
        ' 
        ' ComboBox3
        ' 
        ComboBox3.FormattingEnabled = True
        ComboBox3.Items.AddRange(New Object() {"Tersedia", "Tidak Tersedia"})
        ComboBox3.Location = New Point(276, 72)
        ComboBox3.Name = "ComboBox3"
        ComboBox3.Size = New Size(200, 23)
        ComboBox3.TabIndex = 9
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(373, 293)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(200, 23)
        TextBox1.TabIndex = 10
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(343, 171)
        Label5.Name = "Label5"
        Label5.Size = New Size(67, 18)
        Label5.TabIndex = 11
        Label5.Text = "Fasilitas"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(162, 255)
        TextBox2.Multiline = True
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(200, 50)
        TextBox2.TabIndex = 12
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.Location = New Point(60, 211)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 13
        Button1.Text = "Button1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Button2.Location = New Point(350, 169)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 14
        Button2.Text = "Button2"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Button3.Location = New Point(492, 217)
        Button3.Name = "Button3"
        Button3.Size = New Size(75, 23)
        Button3.TabIndex = 15
        Button3.Text = "Button3"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Font = New Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Button4.Location = New Point(232, 199)
        Button4.Name = "Button4"
        Button4.Size = New Size(75, 23)
        Button4.TabIndex = 16
        Button4.Text = "Button4"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(476, 255)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(200, 23)
        TextBox3.TabIndex = 17
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(361, 171)
        Label6.Name = "Label6"
        Label6.Size = New Size(38, 18)
        Label6.TabIndex = 18
        Label6.Text = "Cari"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.MediumOrchid
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        GroupBox1.ForeColor = Color.WhiteSmoke
        GroupBox1.Location = New Point(297, 128)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(200, 100)
        GroupBox1.TabIndex = 19
        GroupBox1.TabStop = False
        GroupBox1.Text = "Total Kamar Tersedia"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(72, 50)
        Label7.Name = "Label7"
        Label7.Size = New Size(56, 18)
        Label7.TabIndex = 0
        Label7.Text = "Label7"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = Color.MediumOrchid
        GroupBox2.Controls.Add(Label8)
        GroupBox2.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        GroupBox2.ForeColor = Color.WhiteSmoke
        GroupBox2.Location = New Point(85, 240)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(200, 100)
        GroupBox2.TabIndex = 20
        GroupBox2.TabStop = False
        GroupBox2.Text = "Total Kamar"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(77, 47)
        Label8.Name = "Label8"
        Label8.Size = New Size(56, 18)
        Label8.TabIndex = 1
        Label8.Text = "Label8"
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        CheckBox1.Location = New Point(72, 164)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(229, 22)
        CheckBox1.TabIndex = 21
        CheckBox1.Text = "Melihat Kamar yang Tersedia"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' KamarControl
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        Controls.Add(CheckBox1)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(Label6)
        Controls.Add(TextBox3)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(TextBox2)
        Controls.Add(Label5)
        Controls.Add(TextBox1)
        Controls.Add(ComboBox3)
        Controls.Add(ComboBox2)
        Controls.Add(ComboBox1)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(DataGridView1)
        Name = "KamarControl"
        Size = New Size(775, 361)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents CheckBox1 As CheckBox
End Class
