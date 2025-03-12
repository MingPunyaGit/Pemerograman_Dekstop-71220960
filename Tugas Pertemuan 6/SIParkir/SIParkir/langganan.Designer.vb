<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class langganan
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTarif = New System.Windows.Forms.TextBox()
        Me.lblKetikLagi = New System.Windows.Forms.Label()
        Me.btnTutup = New System.Windows.Forms.Button()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.txtNoPlat = New System.Windows.Forms.TextBox()
        Me.txtNamaPelanggan = New System.Windows.Forms.TextBox()
        Me.lblNoPlat = New System.Windows.Forms.Label()
        Me.lblNama = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(508, 40)
        Me.Panel1.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(237, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SIParkir - Langganan"
        '
        'txtTarif
        '
        Me.txtTarif.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.txtTarif.Location = New System.Drawing.Point(122, 122)
        Me.txtTarif.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtTarif.Name = "txtTarif"
        Me.txtTarif.Size = New System.Drawing.Size(115, 20)
        Me.txtTarif.TabIndex = 24
        Me.txtTarif.Text = "text"
        '
        'lblKetikLagi
        '
        Me.lblKetikLagi.AutoSize = True
        Me.lblKetikLagi.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblKetikLagi.Location = New System.Drawing.Point(20, 127)
        Me.lblKetikLagi.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblKetikLagi.Name = "lblKetikLagi"
        Me.lblKetikLagi.Size = New System.Drawing.Size(81, 13)
        Me.lblKetikLagi.TabIndex = 23
        Me.lblKetikLagi.Text = "Tarif langganan"
        '
        'btnTutup
        '
        Me.btnTutup.Location = New System.Drawing.Point(415, 345)
        Me.btnTutup.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnTutup.Name = "btnTutup"
        Me.btnTutup.Size = New System.Drawing.Size(69, 26)
        Me.btnTutup.TabIndex = 21
        Me.btnTutup.Text = "Tutup"
        Me.btnTutup.UseVisualStyleBackColor = True
        '
        'btnTambah
        '
        Me.btnTambah.Location = New System.Drawing.Point(274, 147)
        Me.btnTambah.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(65, 26)
        Me.btnTambah.TabIndex = 20
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'txtNoPlat
        '
        Me.txtNoPlat.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.txtNoPlat.Location = New System.Drawing.Point(122, 93)
        Me.txtNoPlat.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtNoPlat.Name = "txtNoPlat"
        Me.txtNoPlat.Size = New System.Drawing.Size(115, 20)
        Me.txtNoPlat.TabIndex = 19
        Me.txtNoPlat.Text = "text"
        '
        'txtNamaPelanggan
        '
        Me.txtNamaPelanggan.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.txtNamaPelanggan.Location = New System.Drawing.Point(122, 63)
        Me.txtNamaPelanggan.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtNamaPelanggan.Name = "txtNamaPelanggan"
        Me.txtNamaPelanggan.Size = New System.Drawing.Size(166, 20)
        Me.txtNamaPelanggan.TabIndex = 18
        Me.txtNamaPelanggan.Text = "text"
        '
        'lblNoPlat
        '
        Me.lblNoPlat.AutoSize = True
        Me.lblNoPlat.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblNoPlat.Location = New System.Drawing.Point(20, 98)
        Me.lblNoPlat.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNoPlat.Name = "lblNoPlat"
        Me.lblNoPlat.Size = New System.Drawing.Size(59, 13)
        Me.lblNoPlat.TabIndex = 17
        Me.lblNoPlat.Text = "Nomot Plat"
        '
        'lblNama
        '
        Me.lblNama.AutoSize = True
        Me.lblNama.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblNama.Location = New System.Drawing.Point(20, 65)
        Me.lblNama.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNama.Name = "lblNama"
        Me.lblNama.Size = New System.Drawing.Size(89, 13)
        Me.lblNama.TabIndex = 16
        Me.lblNama.Text = "Nama Pelanggan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label2.Location = New System.Drawing.Point(20, 158)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Berlaku hingga"
        '
        'btnHapus
        '
        Me.btnHapus.Location = New System.Drawing.Point(417, 147)
        Me.btnHapus.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(69, 26)
        Me.btnHapus.TabIndex = 27
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 207)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(171, 13)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Kendaraan Terdaftar Langganan : "
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(22, 223)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(461, 106)
        Me.DataGridView1.TabIndex = 29
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(274, 97)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Jenis"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(311, 67)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 13)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "ID Pelanggan : "
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"option"})
        Me.ComboBox1.Location = New System.Drawing.Point(332, 93)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(92, 21)
        Me.ComboBox1.TabIndex = 32
        Me.ComboBox1.Text = "option"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(122, 158)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(132, 20)
        Me.DateTimePicker1.TabIndex = 33
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(344, 147)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(69, 26)
        Me.btnEdit.TabIndex = 34
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'langganan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(508, 391)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtTarif)
        Me.Controls.Add(Me.lblKetikLagi)
        Me.Controls.Add(Me.btnTutup)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.txtNoPlat)
        Me.Controls.Add(Me.txtNamaPelanggan)
        Me.Controls.Add(Me.lblNoPlat)
        Me.Controls.Add(Me.lblNama)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "langganan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SIParkir"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTarif As TextBox
    Friend WithEvents lblKetikLagi As Label
    Friend WithEvents btnTutup As Button
    Friend WithEvents btnTambah As Button
    Friend WithEvents txtNoPlat As TextBox
    Friend WithEvents txtNamaPelanggan As TextBox
    Friend WithEvents lblNoPlat As Label
    Friend WithEvents lblNama As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnHapus As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents btnEdit As Button
End Class
