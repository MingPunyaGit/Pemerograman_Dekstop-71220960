<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
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
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblUsername.Location = New System.Drawing.Point(119, 102)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(70, 16)
        Me.lblUsername.TabIndex = 0
        Me.lblUsername.Text = "Username"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblPassword.Location = New System.Drawing.Point(119, 168)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(67, 16)
        Me.lblPassword.TabIndex = 1
        Me.lblPassword.Text = "Password"
        '
        'txtUsername
        '
        Me.txtUsername.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.txtUsername.Location = New System.Drawing.Point(225, 102)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(152, 22)
        Me.txtUsername.TabIndex = 2
        Me.txtUsername.Text = "text"
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.txtPassword.Location = New System.Drawing.Point(225, 165)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(152, 22)
        Me.txtPassword.TabIndex = 3
        Me.txtPassword.Text = "text"
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(199, 221)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(87, 32)
        Me.btnLogin.TabIndex = 4
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'btnKeluar
        '
        Me.btnKeluar.Location = New System.Drawing.Point(292, 221)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(92, 32)
        Me.btnKeluar.TabIndex = 5
        Me.btnKeluar.Text = "Keluar"
        Me.btnKeluar.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(541, 49)
        Me.Panel1.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(208, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SIParkir-Login"
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(540, 322)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnKeluar)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblUsername)
        Me.Name = "login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SIParkir"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblUsername As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnKeluar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
End Class
