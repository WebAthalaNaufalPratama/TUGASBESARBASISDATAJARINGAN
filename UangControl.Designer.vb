<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UangControl
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
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        GroupBox1 = New GroupBox()
        Label3 = New Label()
        GroupBox2 = New GroupBox()
        Label4 = New Label()
        GroupBox3 = New GroupBox()
        GroupBox4 = New GroupBox()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        DataGridView1 = New DataGridView()
        Label5 = New Label()
        Label6 = New Label()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        GroupBox4.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(103, 39)
        Label1.Name = "Label1"
        Label1.Size = New Size(140, 18)
        Label1.TabIndex = 0
        Label1.Text = "Total Pengeluaran :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(103, 78)
        Label2.Name = "Label2"
        Label2.Size = New Size(75, 18)
        Label2.TabIndex = 1
        Label2.Text = "Deskripsi"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(314, 34)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(200, 23)
        TextBox1.TabIndex = 2
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(314, 78)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(200, 23)
        TextBox2.TabIndex = 3
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.MediumOrchid
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        GroupBox1.ForeColor = Color.WhiteSmoke
        GroupBox1.Location = New Point(580, 34)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(200, 100)
        GroupBox1.TabIndex = 4
        GroupBox1.TabStop = False
        GroupBox1.Text = "Pendapatan Hari Ini"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(71, 44)
        Label3.Name = "Label3"
        Label3.Size = New Size(56, 18)
        Label3.TabIndex = 0
        Label3.Text = "Label3"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = Color.MediumOrchid
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        GroupBox2.ForeColor = Color.WhiteSmoke
        GroupBox2.Location = New Point(580, 149)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(200, 100)
        GroupBox2.TabIndex = 5
        GroupBox2.TabStop = False
        GroupBox2.Text = "Pendapatan Bulan Ini"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(71, 43)
        Label4.Name = "Label4"
        Label4.Size = New Size(56, 18)
        Label4.TabIndex = 1
        Label4.Text = "Label4"
        ' 
        ' GroupBox3
        ' 
        GroupBox3.BackColor = Color.MediumOrchid
        GroupBox3.Controls.Add(Label5)
        GroupBox3.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        GroupBox3.ForeColor = Color.WhiteSmoke
        GroupBox3.Location = New Point(580, 265)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(200, 100)
        GroupBox3.TabIndex = 6
        GroupBox3.TabStop = False
        GroupBox3.Text = "Pengeluaran Hari Ini"
        ' 
        ' GroupBox4
        ' 
        GroupBox4.BackColor = Color.MediumOrchid
        GroupBox4.Controls.Add(Label6)
        GroupBox4.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        GroupBox4.ForeColor = Color.WhiteSmoke
        GroupBox4.Location = New Point(361, 192)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(200, 100)
        GroupBox4.TabIndex = 6
        GroupBox4.TabStop = False
        GroupBox4.Text = "Pengeluaran Bulan Ini"
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.Location = New Point(61, 151)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 7
        Button1.Text = "Button1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Button2.Location = New Point(183, 151)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 8
        Button2.Text = "Button2"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Button3.Location = New Point(298, 151)
        Button3.Name = "Button3"
        Button3.Size = New Size(75, 23)
        Button3.TabIndex = 9
        Button3.Text = "Button3"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Font = New Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Button4.Location = New Point(429, 151)
        Button4.Name = "Button4"
        Button4.Size = New Size(75, 23)
        Button4.TabIndex = 10
        Button4.Text = "Button4"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(140, 437)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(240, 150)
        DataGridView1.TabIndex = 11
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(71, 49)
        Label5.Name = "Label5"
        Label5.Size = New Size(56, 18)
        Label5.TabIndex = 2
        Label5.Text = "Label5"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(68, 39)
        Label6.Name = "Label6"
        Label6.Size = New Size(56, 18)
        Label6.TabIndex = 3
        Label6.Text = "Label6"
        ' 
        ' UangControl
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        Controls.Add(DataGridView1)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(GroupBox4)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "UangControl"
        Size = New Size(955, 615)
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        GroupBox4.ResumeLayout(False)
        GroupBox4.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
