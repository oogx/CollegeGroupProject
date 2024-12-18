<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainDesign
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
        Me.components = New System.ComponentModel.Container()
        Me.User_Desktop_Panel = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PayslipButton = New FontAwesome.Sharp.IconButton()
        Me.ClockInButton = New FontAwesome.Sharp.IconButton()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.KMText = New System.Windows.Forms.Label()
        Me.lblClock = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'User_Desktop_Panel
        '
        Me.User_Desktop_Panel.Location = New System.Drawing.Point(207, 45)
        Me.User_Desktop_Panel.Name = "User_Desktop_Panel"
        Me.User_Desktop_Panel.Size = New System.Drawing.Size(766, 554)
        Me.User_Desktop_Panel.TabIndex = 33
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Panel3.Controls.Add(Me.PayslipButton)
        Me.Panel3.Controls.Add(Me.ClockInButton)
        Me.Panel3.Location = New System.Drawing.Point(0, 56)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(210, 555)
        Me.Panel3.TabIndex = 32
        '
        'PayslipButton
        '
        Me.PayslipButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PayslipButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.PayslipButton.FlatAppearance.BorderSize = 0
        Me.PayslipButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PayslipButton.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.PayslipButton.IconChar = FontAwesome.Sharp.IconChar.MoneyBill
        Me.PayslipButton.IconColor = System.Drawing.SystemColors.ButtonFace
        Me.PayslipButton.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.PayslipButton.IconSize = 30
        Me.PayslipButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.PayslipButton.Location = New System.Drawing.Point(0, 50)
        Me.PayslipButton.Name = "PayslipButton"
        Me.PayslipButton.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.PayslipButton.Size = New System.Drawing.Size(210, 50)
        Me.PayslipButton.TabIndex = 3
        Me.PayslipButton.Text = "Payslip"
        Me.PayslipButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.PayslipButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.PayslipButton.UseVisualStyleBackColor = True
        '
        'ClockInButton
        '
        Me.ClockInButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ClockInButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.ClockInButton.FlatAppearance.BorderSize = 0
        Me.ClockInButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ClockInButton.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.ClockInButton.IconChar = FontAwesome.Sharp.IconChar.ClockFour
        Me.ClockInButton.IconColor = System.Drawing.SystemColors.ButtonFace
        Me.ClockInButton.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.ClockInButton.IconSize = 30
        Me.ClockInButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ClockInButton.Location = New System.Drawing.Point(0, 0)
        Me.ClockInButton.Name = "ClockInButton"
        Me.ClockInButton.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.ClockInButton.Size = New System.Drawing.Size(210, 50)
        Me.ClockInButton.TabIndex = 2
        Me.ClockInButton.Text = "Clock In"
        Me.ClockInButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ClockInButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ClockInButton.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'KMText
        '
        Me.KMText.AutoSize = True
        Me.KMText.BackColor = System.Drawing.Color.Transparent
        Me.KMText.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KMText.ForeColor = System.Drawing.Color.White
        Me.KMText.Location = New System.Drawing.Point(26, 6)
        Me.KMText.Name = "KMText"
        Me.KMText.Size = New System.Drawing.Size(382, 32)
        Me.KMText.TabIndex = 15
        Me.KMText.Text = "Konservatiff Management | "
        '
        'lblClock
        '
        Me.lblClock.AutoSize = True
        Me.lblClock.BackColor = System.Drawing.Color.Transparent
        Me.lblClock.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClock.ForeColor = System.Drawing.Color.White
        Me.lblClock.Location = New System.Drawing.Point(664, 6)
        Me.lblClock.Name = "lblClock"
        Me.lblClock.Size = New System.Drawing.Size(328, 32)
        Me.lblClock.TabIndex = 25
        Me.lblClock.Text = "DD/MM/YYYY HH:MM:SS"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Panel2.Controls.Add(Me.lblClock)
        Me.Panel2.Controls.Add(Me.KMText)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(-19, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1012, 62)
        Me.Panel2.TabIndex = 31
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(31, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Main Menu"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(26, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(526, 32)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Konservatiff Management | Time Clock"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(-106, -80)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1012, 46)
        Me.Panel1.TabIndex = 27
        '
        'MainDesign
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(974, 611)
        Me.Controls.Add(Me.User_Desktop_Panel)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "MainDesign"
        Me.Text = "MainDesign"
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents User_Desktop_Panel As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents KMText As Label
    Friend WithEvents lblClock As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ClockInButton As FontAwesome.Sharp.IconButton
    Friend WithEvents PayslipButton As FontAwesome.Sharp.IconButton
End Class
