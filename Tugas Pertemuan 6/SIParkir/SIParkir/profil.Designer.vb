<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class profil
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnTutup = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.txtVerifikasiPassword = New System.Windows.Forms.TextBox()
        Me.lblKetikLagi = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 29)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(406, 40)
        Me.Panel1.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(239, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SIParkir - Ubah Profil"
        '
        'btnTutup
        '
        Me.btnTutup.Location = New System.Drawing.Point(214, 244)
        Me.btnTutup.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnTutup.Name = "btnTutup"
        Me.btnTutup.Size = New System.Drawing.Size(69, 26)
        Me.btnTutup.TabIndex = 12
        Me.btnTutup.Text = "Tutup"
        Me.btnTutup.UseVisualStyleBackColor = True
        '
        'btnSimpan
        '
        Me.btnSimpan.Location = New System.Drawing.Point(144, 244)
        Me.btnSimpan.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(65, 26)
        Me.btnSimpan.TabIndex = 11
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.txtPassword.Location = New System.Drawing.Point(169, 156)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(115, 20)
        Me.txtPassword.TabIndex = 10
        Me.txtPassword.Text = "text"
        '
        'txtUsername
        '
        Me.txtUsername.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.txtUsername.Location = New System.Drawing.Point(169, 110)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(115, 20)
        Me.txtUsername.TabIndex = 9
        Me.txtUsername.Text = "text"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblPassword.Location = New System.Drawing.Point(89, 158)
        Me.lblPassword.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(78, 13)
        Me.lblPassword.TabIndex = 8
        Me.lblPassword.Text = "Password Baru"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblUsername.Location = New System.Drawing.Point(89, 110)
        Me.lblUsername.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(55, 13)
        Me.lblUsername.TabIndex = 7
        Me.lblUsername.Text = "Username"
        '
        'txtVerifikasiPassword
        '
        Me.txtVerifikasiPassword.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.txtVerifikasiPassword.Location = New System.Drawing.Point(169, 203)
        Me.txtVerifikasiPassword.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtVerifikasiPassword.Name = "txtVerifikasiPassword"
        Me.txtVerifikasiPassword.Size = New System.Drawing.Size(115, 20)
        Me.txtVerifikasiPassword.TabIndex = 15
        Me.txtVerifikasiPassword.Text = "text"
        '
        'lblKetikLagi
        '
        Me.lblKetikLagi.AutoSize = True
        Me.lblKetikLagi.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblKetikLagi.Location = New System.Drawing.Point(89, 206)
        Me.lblKetikLagi.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblKetikLagi.Name = "lblKetikLagi"
        Me.lblKetikLagi.Size = New System.Drawing.Size(54, 13)
        Me.lblKetikLagi.TabIndex = 14
        Me.lblKetikLagi.Text = "Ketik Lagi"
        '
        'profil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(405, 321)
        Me.Controls.Add(Me.txtVerifikasiPassword)
        Me.Controls.Add(Me.lblKetikLagi)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnTutup)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblUsername)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "profil"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SIParkir"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnTutup As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents txtVerifikasiPassword As TextBox
    Friend WithEvents lblKetikLagi As Label
End Class
