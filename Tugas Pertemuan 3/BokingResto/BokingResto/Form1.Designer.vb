<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        CmbJmlhKursi = New ComboBox()
        NumericUpDown1 = New NumericUpDown()
        LbxRiwayat = New ListBox()
        Button1 = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        LbxMenu = New ListBox()
        LbxMenuRekomendasi = New ListBox()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' CmbJmlhKursi
        ' 
        CmbJmlhKursi.FormattingEnabled = True
        CmbJmlhKursi.Location = New Point(130, 73)
        CmbJmlhKursi.Name = "CmbJmlhKursi"
        CmbJmlhKursi.Size = New Size(143, 23)
        CmbJmlhKursi.TabIndex = 0
        ' 
        ' NumericUpDown1
        ' 
        NumericUpDown1.Location = New Point(130, 147)
        NumericUpDown1.Name = "NumericUpDown1"
        NumericUpDown1.Size = New Size(142, 23)
        NumericUpDown1.TabIndex = 1
        ' 
        ' LbxRiwayat
        ' 
        LbxRiwayat.FormattingEnabled = True
        LbxRiwayat.ItemHeight = 15
        LbxRiwayat.Location = New Point(43, 574)
        LbxRiwayat.Name = "LbxRiwayat"
        LbxRiwayat.Size = New Size(529, 94)
        LbxRiwayat.TabIndex = 2
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Yellow
        Button1.Location = New Point(45, 726)
        Button1.Name = "Button1"
        Button1.Size = New Size(115, 23)
        Button1.TabIndex = 3
        Button1.Text = "Pesan Sekarang"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(279, 76)
        Label1.Name = "Label1"
        Label1.Size = New Size(41, 15)
        Label1.TabIndex = 5
        Label1.Text = "Label1"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(43, 76)
        Label2.Name = "Label2"
        Label2.Size = New Size(59, 15)
        Label2.TabIndex = 6
        Label2.Text = "Pilih Meja"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(43, 155)
        Label3.Name = "Label3"
        Label3.Size = New Size(77, 15)
        Label3.TabIndex = 7
        Label3.Text = "Jumlah Tamu"
        ' 
        ' LbxMenu
        ' 
        LbxMenu.FormattingEnabled = True
        LbxMenu.ItemHeight = 15
        LbxMenu.Location = New Point(43, 403)
        LbxMenu.Name = "LbxMenu"
        LbxMenu.Size = New Size(368, 94)
        LbxMenu.TabIndex = 9
        ' 
        ' LbxMenuRekomendasi
        ' 
        LbxMenuRekomendasi.FormattingEnabled = True
        LbxMenuRekomendasi.ItemHeight = 15
        LbxMenuRekomendasi.Location = New Point(43, 238)
        LbxMenuRekomendasi.Name = "LbxMenuRekomendasi"
        LbxMenuRekomendasi.Size = New Size(368, 94)
        LbxMenuRekomendasi.TabIndex = 10
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(61, 220)
        Label4.Name = "Label4"
        Label4.Size = New Size(41, 15)
        Label4.TabIndex = 11
        Label4.Text = "Label4"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(61, 385)
        Label5.Name = "Label5"
        Label5.Size = New Size(41, 15)
        Label5.TabIndex = 12
        Label5.Text = "Label5"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(61, 556)
        Label6.Name = "Label6"
        Label6.Size = New Size(41, 15)
        Label6.TabIndex = 13
        Label6.Text = "Label6"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(278, 149)
        Label7.Name = "Label7"
        Label7.Size = New Size(41, 15)
        Label7.TabIndex = 14
        Label7.Text = "Label7"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(237, 9)
        Label8.Margin = New Padding(0)
        Label8.Name = "Label8"
        Label8.Size = New Size(122, 15)
        Label8.TabIndex = 15
        Label8.Text = "WELCOME TO WEKIDI"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(584, 761)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(LbxMenuRekomendasi)
        Controls.Add(LbxMenu)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Controls.Add(LbxRiwayat)
        Controls.Add(NumericUpDown1)
        Controls.Add(CmbJmlhKursi)
        Name = "Form1"
        Text = "Selamat Datang Di WEKIDI"
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents CmbJmlhKursi As ComboBox
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents LbxRiwayat As ListBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LbxMenu As ListBox
    Friend WithEvents LbxMenuRekomendasi As ListBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label

End Class
