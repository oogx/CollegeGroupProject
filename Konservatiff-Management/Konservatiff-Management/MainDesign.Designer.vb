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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.IconButton2 = New FontAwesome.Sharp.IconButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.IconButton3 = New FontAwesome.Sharp.IconButton()
        Me.IconButton4 = New FontAwesome.Sharp.IconButton()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
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
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.PayslipButton)
        Me.Panel3.Controls.Add(Me.ClockInButton)
        Me.Panel3.Location = New System.Drawing.Point(0, 56)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(210, 582)
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
        Me.ClockInButton.Text = "Time Clock"
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
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.lblClock)
        Me.Panel2.Controls.Add(Me.KMText)
        Me.Panel2.Location = New System.Drawing.Point(-19, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1012, 62)
        Me.Panel2.TabIndex = 31
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
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Controls.Add(Me.IconButton2)
        Me.Panel4.Location = New System.Drawing.Point(-1, 106)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(210, 469)
        Me.Panel4.TabIndex = 33
        '
        'IconButton2
        '
        Me.IconButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.IconButton2.Dock = System.Windows.Forms.DockStyle.Top
        Me.IconButton2.FlatAppearance.BorderSize = 0
        Me.IconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.IconButton2.IconChar = FontAwesome.Sharp.IconChar.User
        Me.IconButton2.IconColor = System.Drawing.SystemColors.ButtonFace
        Me.IconButton2.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton2.IconSize = 30
        Me.IconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton2.Location = New System.Drawing.Point(0, 0)
        Me.IconButton2.Name = "IconButton2"
        Me.IconButton2.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.IconButton2.Size = New System.Drawing.Size(210, 50)
        Me.IconButton2.TabIndex = 2
        Me.IconButton2.Text = "Options"
        Me.IconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(31, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Main Menu"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(10, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "User"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(12, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Admin"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Panel5.Controls.Add(Me.IconButton4)
        Me.Panel5.Controls.Add(Me.IconButton3)
        Me.Panel5.Controls.Add(Me.IconButton1)
        Me.Panel5.Location = New System.Drawing.Point(2, 66)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(210, 421)
        Me.Panel5.TabIndex = 34
        '
        'IconButton1
        '
        Me.IconButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.IconButton1.Dock = System.Windows.Forms.DockStyle.Top
        Me.IconButton1.FlatAppearance.BorderSize = 0
        Me.IconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.User
        Me.IconButton1.IconColor = System.Drawing.SystemColors.ButtonFace
        Me.IconButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton1.IconSize = 30
        Me.IconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton1.Location = New System.Drawing.Point(0, 0)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.IconButton1.Size = New System.Drawing.Size(210, 50)
        Me.IconButton1.TabIndex = 2
        Me.IconButton1.Text = "Members"
        Me.IconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton1.UseVisualStyleBackColor = True
        '
        'IconButton3
        '
        Me.IconButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.IconButton3.Dock = System.Windows.Forms.DockStyle.Top
        Me.IconButton3.FlatAppearance.BorderSize = 0
        Me.IconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.IconButton3.IconChar = FontAwesome.Sharp.IconChar.Plus
        Me.IconButton3.IconColor = System.Drawing.SystemColors.ButtonFace
        Me.IconButton3.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton3.IconSize = 30
        Me.IconButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton3.Location = New System.Drawing.Point(0, 50)
        Me.IconButton3.Name = "IconButton3"
        Me.IconButton3.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.IconButton3.Size = New System.Drawing.Size(210, 50)
        Me.IconButton3.TabIndex = 3
        Me.IconButton3.Text = "Add Staff"
        Me.IconButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton3.UseVisualStyleBackColor = True
        '
        'IconButton4
        '
        Me.IconButton4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.IconButton4.Dock = System.Windows.Forms.DockStyle.Top
        Me.IconButton4.FlatAppearance.BorderSize = 0
        Me.IconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.IconButton4.IconChar = FontAwesome.Sharp.IconChar.ChartBar
        Me.IconButton4.IconColor = System.Drawing.SystemColors.ButtonFace
        Me.IconButton4.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton4.IconSize = 30
        Me.IconButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton4.Location = New System.Drawing.Point(0, 100)
        Me.IconButton4.Name = "IconButton4"
        Me.IconButton4.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.IconButton4.Size = New System.Drawing.Size(210, 50)
        Me.IconButton4.TabIndex = 4
        Me.IconButton4.Text = "Reports"
        Me.IconButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton4.UseVisualStyleBackColor = True
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
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents User_Desktop_Panel As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents KMText As Label
    Friend WithEvents lblClock As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ClockInButton As FontAwesome.Sharp.IconButton
    Friend WithEvents PayslipButton As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel4 As Panel
    Friend WithEvents IconButton2 As FontAwesome.Sharp.IconButton
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton4 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton3 As FontAwesome.Sharp.IconButton
End Class
