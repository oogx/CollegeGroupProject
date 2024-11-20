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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSignInPage))
        Me.picLoginLogo = New System.Windows.Forms.PictureBox()
        Me.lblSignInDot = New System.Windows.Forms.Label()
        Me.lblSignIn = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.lblPayrollNo = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblClock = New System.Windows.Forms.Label()
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
        Me.lblSignInDot.Location = New System.Drawing.Point(272, 146)
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
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(72, 335)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Password"
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.TextBox2.Location = New System.Drawing.Point(75, 351)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(362, 20)
        Me.TextBox2.TabIndex = 9
        '
        'lblPayrollNo
        '
        Me.lblPayrollNo.AutoSize = True
        Me.lblPayrollNo.BackColor = System.Drawing.Color.Transparent
        Me.lblPayrollNo.ForeColor = System.Drawing.Color.White
        Me.lblPayrollNo.Location = New System.Drawing.Point(72, 281)
        Me.lblPayrollNo.Name = "lblPayrollNo"
        Me.lblPayrollNo.Size = New System.Drawing.Size(78, 13)
        Me.lblPayrollNo.TabIndex = 8
        Me.lblPayrollNo.Text = "Payroll Number"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.TextBox1.Location = New System.Drawing.Point(75, 297)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(362, 20)
        Me.TextBox1.TabIndex = 7
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
        Me.lblClock.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClock.ForeColor = System.Drawing.Color.White
        Me.lblClock.Location = New System.Drawing.Point(637, 4)
        Me.lblClock.Name = "lblClock"
        Me.lblClock.Size = New System.Drawing.Size(326, 33)
        Me.lblClock.TabIndex = 15
        Me.lblClock.Text = "DD/MM/YYYY HH:MM:SS"
        '
        'frmSignInPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(971, 614)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.picLoginLogo)
        Me.Controls.Add(Me.lblSignInDot)
        Me.Controls.Add(Me.lblSignIn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.lblPayrollNo)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "frmSignInPage"
        Me.Text = "frmSignInPage"
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
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents lblPayrollNo As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblClock As Label
End Class
