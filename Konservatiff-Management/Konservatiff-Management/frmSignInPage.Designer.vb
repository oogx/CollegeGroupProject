<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSignInPage
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSignInPage))
        Me.picLoginLogo = New System.Windows.Forms.PictureBox()
        Me.lblSignInDot = New System.Windows.Forms.Label()
        Me.lblSignIn = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblPayrollNo = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblClock = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Shapes1 = New Guna.UI2.WinForms.Guna2Shapes()
        Me.Guna2Shapes2 = New Guna.UI2.WinForms.Guna2Shapes()
        Me.payrollTxtBx = New System.Windows.Forms.TextBox()
        Me.passTxtBx = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.picLoginLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'picLoginLogo
        '
        Me.picLoginLogo.BackColor = System.Drawing.Color.Transparent
        Me.picLoginLogo.BackgroundImage = CType(resources.GetObject("picLoginLogo.BackgroundImage"), System.Drawing.Image)
        Me.picLoginLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picLoginLogo.Enabled = False
        Me.picLoginLogo.Location = New System.Drawing.Point(590, 268)
        Me.picLoginLogo.Name = "picLoginLogo"
        Me.picLoginLogo.Size = New System.Drawing.Size(339, 128)
        Me.picLoginLogo.TabIndex = 13
        Me.picLoginLogo.TabStop = False
        '
        'lblSignInDot
        '
        Me.lblSignInDot.AutoSize = True
        Me.lblSignInDot.BackColor = System.Drawing.Color.Transparent
        Me.lblSignInDot.Font = New System.Drawing.Font("Century Gothic", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSignInDot.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.lblSignInDot.Location = New System.Drawing.Point(273, 146)
        Me.lblSignInDot.Name = "lblSignInDot"
        Me.lblSignInDot.Size = New System.Drawing.Size(51, 77)
        Me.lblSignInDot.TabIndex = 12
        Me.lblSignInDot.Text = "."
        '
        'lblSignIn
        '
        Me.lblSignIn.AutoSize = True
        Me.lblSignIn.BackColor = System.Drawing.Color.Transparent
        Me.lblSignIn.Font = New System.Drawing.Font("Century Gothic", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSignIn.ForeColor = System.Drawing.Color.White
        Me.lblSignIn.Location = New System.Drawing.Point(62, 146)
        Me.lblSignIn.Name = "lblSignIn"
        Me.lblSignIn.Size = New System.Drawing.Size(232, 77)
        Me.lblSignIn.TabIndex = 11
        Me.lblSignIn.Text = "Sign in"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(98, 350)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 15)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Password"
        '
        'lblPayrollNo
        '
        Me.lblPayrollNo.AutoSize = True
        Me.lblPayrollNo.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.lblPayrollNo.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPayrollNo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.lblPayrollNo.Location = New System.Drawing.Point(98, 271)
        Me.lblPayrollNo.Name = "lblPayrollNo"
        Me.lblPayrollNo.Size = New System.Drawing.Size(90, 15)
        Me.lblPayrollNo.TabIndex = 8
        Me.lblPayrollNo.Text = "Payroll Number"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblClock)
        Me.Panel1.Location = New System.Drawing.Point(0, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1012, 42)
        Me.Panel1.TabIndex = 14
        '
        'lblClock
        '
        Me.lblClock.AutoSize = True
        Me.lblClock.BackColor = System.Drawing.Color.Transparent
        Me.lblClock.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClock.ForeColor = System.Drawing.Color.White
        Me.lblClock.Location = New System.Drawing.Point(637, 4)
        Me.lblClock.Name = "lblClock"
        Me.lblClock.Size = New System.Drawing.Size(328, 32)
        Me.lblClock.TabIndex = 15
        Me.lblClock.Text = "DD/MM/YYYY HH:MM:SS"
        '
        'Timer1
        '
        '
        'Guna2Button1
        '
        Me.Guna2Button1.Animated = True
        Me.Guna2Button1.AutoRoundedCorners = True
        Me.Guna2Button1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Button1.BorderRadius = 21
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.FillColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Guna2Button1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.Guna2Button1.Location = New System.Drawing.Point(156, 429)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(180, 45)
        Me.Guna2Button1.TabIndex = 16
        Me.Guna2Button1.Text = "LOG IN"
        '
        'Guna2Shapes1
        '
        Me.Guna2Shapes1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Shapes1.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2Shapes1.FillColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Guna2Shapes1.Location = New System.Drawing.Point(35, 338)
        Me.Guna2Shapes1.Name = "Guna2Shapes1"
        Me.Guna2Shapes1.PolygonSkip = 1
        Me.Guna2Shapes1.Rotate = 0!
        Me.Guna2Shapes1.RoundedRadius = 25
        Me.Guna2Shapes1.Shape = Guna.UI2.WinForms.Enums.ShapeType.Rounded
        Me.Guna2Shapes1.Size = New System.Drawing.Size(419, 76)
        Me.Guna2Shapes1.TabIndex = 19
        Me.Guna2Shapes1.Text = "Guna2Shapes1"
        Me.Guna2Shapes1.Zoom = 80
        '
        'Guna2Shapes2
        '
        Me.Guna2Shapes2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Shapes2.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2Shapes2.FillColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Guna2Shapes2.Location = New System.Drawing.Point(35, 261)
        Me.Guna2Shapes2.Name = "Guna2Shapes2"
        Me.Guna2Shapes2.PolygonSkip = 1
        Me.Guna2Shapes2.Rotate = 0!
        Me.Guna2Shapes2.RoundedRadius = 25
        Me.Guna2Shapes2.Shape = Guna.UI2.WinForms.Enums.ShapeType.Rounded
        Me.Guna2Shapes2.Size = New System.Drawing.Size(419, 76)
        Me.Guna2Shapes2.TabIndex = 20
        Me.Guna2Shapes2.Text = "Guna2Shapes2"
        Me.Guna2Shapes2.Zoom = 80
        '
        'payrollTxtBx
        '
        Me.payrollTxtBx.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.payrollTxtBx.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.payrollTxtBx.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.payrollTxtBx.ForeColor = System.Drawing.Color.White
        Me.payrollTxtBx.Location = New System.Drawing.Point(101, 295)
        Me.payrollTxtBx.Name = "payrollTxtBx"
        Me.payrollTxtBx.Size = New System.Drawing.Size(287, 17)
        Me.payrollTxtBx.TabIndex = 21
        '
        'passTxtBx
        '
        Me.passTxtBx.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.passTxtBx.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.passTxtBx.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.passTxtBx.ForeColor = System.Drawing.Color.White
        Me.passTxtBx.Location = New System.Drawing.Point(101, 373)
        Me.passTxtBx.Name = "passTxtBx"
        Me.passTxtBx.Size = New System.Drawing.Size(287, 17)
        Me.passTxtBx.TabIndex = 22
        Me.passTxtBx.UseSystemPasswordChar = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(135, 410)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(220, 15)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "*If new account, password not required."
        '
        'frmSignInPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(974, 611)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.passTxtBx)
        Me.Controls.Add(Me.payrollTxtBx)
        Me.Controls.Add(Me.Guna2Button1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.picLoginLogo)
        Me.Controls.Add(Me.lblSignInDot)
        Me.Controls.Add(Me.lblSignIn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblPayrollNo)
        Me.Controls.Add(Me.Guna2Shapes1)
        Me.Controls.Add(Me.Guna2Shapes2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSignInPage"
        Me.Text = "frmSignInPage"
        Me.TopMost = True
        CType(Me.picLoginLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picLoginLogo As PictureBox
    Friend WithEvents lblSignInDot As Label
    Friend WithEvents lblSignIn As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblPayrollNo As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblClock As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Shapes1 As Guna.UI2.WinForms.Guna2Shapes
    Friend WithEvents Guna2Shapes2 As Guna.UI2.WinForms.Guna2Shapes
    Friend WithEvents payrollTxtBx As TextBox
    Friend WithEvents passTxtBx As TextBox
    Friend WithEvents Label2 As Label
End Class
