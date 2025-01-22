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
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.AdminLabel = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.UserTypeLbl = New System.Windows.Forms.Label()
        Me.UsersNameLbl = New System.Windows.Forms.Label()
        Me.ExitBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Shapes1 = New Guna.UI2.WinForms.Guna2Shapes()
        Me.ReportsBtn = New FontAwesome.Sharp.IconButton()
        Me.AddStaffBtn = New FontAwesome.Sharp.IconButton()
        Me.MembersBtn = New FontAwesome.Sharp.IconButton()
        Me.OptionsBtn = New FontAwesome.Sharp.IconButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PayslipBtn = New FontAwesome.Sharp.IconButton()
        Me.ClockInBtn = New FontAwesome.Sharp.IconButton()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.KMText = New System.Windows.Forms.Label()
        Me.lblClock = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
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
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.PayslipBtn)
        Me.Panel3.Controls.Add(Me.ClockInBtn)
        Me.Panel3.Location = New System.Drawing.Point(0, 56)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(210, 582)
        Me.Panel3.TabIndex = 32
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Panel4.Controls.Add(Me.AdminLabel)
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Controls.Add(Me.OptionsBtn)
        Me.Panel4.Location = New System.Drawing.Point(-1, 106)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(210, 469)
        Me.Panel4.TabIndex = 33
        '
        'AdminLabel
        '
        Me.AdminLabel.AutoSize = True
        Me.AdminLabel.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdminLabel.ForeColor = System.Drawing.Color.White
        Me.AdminLabel.Location = New System.Drawing.Point(12, 49)
        Me.AdminLabel.Name = "AdminLabel"
        Me.AdminLabel.Size = New System.Drawing.Size(41, 15)
        Me.AdminLabel.TabIndex = 27
        Me.AdminLabel.Text = "Admin"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Panel5.Controls.Add(Me.UserTypeLbl)
        Me.Panel5.Controls.Add(Me.UsersNameLbl)
        Me.Panel5.Controls.Add(Me.ExitBtn)
        Me.Panel5.Controls.Add(Me.Guna2Shapes1)
        Me.Panel5.Controls.Add(Me.ReportsBtn)
        Me.Panel5.Controls.Add(Me.AddStaffBtn)
        Me.Panel5.Controls.Add(Me.MembersBtn)
        Me.Panel5.Location = New System.Drawing.Point(2, 66)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(210, 421)
        Me.Panel5.TabIndex = 34
        '
        'UserTypeLbl
        '
        Me.UserTypeLbl.AutoSize = True
        Me.UserTypeLbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.UserTypeLbl.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserTypeLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.UserTypeLbl.Location = New System.Drawing.Point(13, 345)
        Me.UserTypeLbl.Name = "UserTypeLbl"
        Me.UserTypeLbl.Size = New System.Drawing.Size(69, 16)
        Me.UserTypeLbl.TabIndex = 28
        Me.UserTypeLbl.Text = "User Type"
        '
        'UsersNameLbl
        '
        Me.UsersNameLbl.AutoSize = True
        Me.UsersNameLbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.UsersNameLbl.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsersNameLbl.ForeColor = System.Drawing.Color.White
        Me.UsersNameLbl.Location = New System.Drawing.Point(11, 314)
        Me.UsersNameLbl.Name = "UsersNameLbl"
        Me.UsersNameLbl.Size = New System.Drawing.Size(58, 19)
        Me.UsersNameLbl.TabIndex = 27
        Me.UsersNameLbl.Text = "Name"
        '
        'ExitBtn
        '
        Me.ExitBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.ExitBtn.BorderRadius = 20
        Me.ExitBtn.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ExitBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.ExitBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.ExitBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.ExitBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.ExitBtn.FillColor = System.Drawing.Color.Red
        Me.ExitBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ExitBtn.ForeColor = System.Drawing.Color.White
        Me.ExitBtn.Location = New System.Drawing.Point(150, 312)
        Me.ExitBtn.Name = "ExitBtn"
        Me.ExitBtn.Size = New System.Drawing.Size(46, 57)
        Me.ExitBtn.TabIndex = 0
        Me.ExitBtn.Text = "Exit"
        '
        'Guna2Shapes1
        '
        Me.Guna2Shapes1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Guna2Shapes1.FillColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Guna2Shapes1.Location = New System.Drawing.Point(-22, 292)
        Me.Guna2Shapes1.Name = "Guna2Shapes1"
        Me.Guna2Shapes1.PolygonSkip = 1
        Me.Guna2Shapes1.Rotate = 0!
        Me.Guna2Shapes1.Shape = Guna.UI2.WinForms.Enums.ShapeType.Rounded
        Me.Guna2Shapes1.Size = New System.Drawing.Size(248, 92)
        Me.Guna2Shapes1.TabIndex = 5
        Me.Guna2Shapes1.Text = "Guna2Shapes1"
        Me.Guna2Shapes1.Zoom = 80
        '
        'ReportsBtn
        '
        Me.ReportsBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ReportsBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.ReportsBtn.FlatAppearance.BorderSize = 0
        Me.ReportsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ReportsBtn.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReportsBtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.ReportsBtn.IconChar = FontAwesome.Sharp.IconChar.ChartBar
        Me.ReportsBtn.IconColor = System.Drawing.SystemColors.ButtonFace
        Me.ReportsBtn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.ReportsBtn.IconSize = 30
        Me.ReportsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ReportsBtn.Location = New System.Drawing.Point(0, 100)
        Me.ReportsBtn.Name = "ReportsBtn"
        Me.ReportsBtn.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.ReportsBtn.Size = New System.Drawing.Size(210, 50)
        Me.ReportsBtn.TabIndex = 4
        Me.ReportsBtn.Text = "Reports"
        Me.ReportsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ReportsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ReportsBtn.UseVisualStyleBackColor = True
        '
        'AddStaffBtn
        '
        Me.AddStaffBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AddStaffBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.AddStaffBtn.FlatAppearance.BorderSize = 0
        Me.AddStaffBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddStaffBtn.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddStaffBtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.AddStaffBtn.IconChar = FontAwesome.Sharp.IconChar.Plus
        Me.AddStaffBtn.IconColor = System.Drawing.SystemColors.ButtonFace
        Me.AddStaffBtn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.AddStaffBtn.IconSize = 30
        Me.AddStaffBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AddStaffBtn.Location = New System.Drawing.Point(0, 50)
        Me.AddStaffBtn.Name = "AddStaffBtn"
        Me.AddStaffBtn.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.AddStaffBtn.Size = New System.Drawing.Size(210, 50)
        Me.AddStaffBtn.TabIndex = 3
        Me.AddStaffBtn.Text = "Add Staff"
        Me.AddStaffBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AddStaffBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.AddStaffBtn.UseVisualStyleBackColor = True
        '
        'MembersBtn
        '
        Me.MembersBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MembersBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.MembersBtn.FlatAppearance.BorderSize = 0
        Me.MembersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MembersBtn.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MembersBtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.MembersBtn.IconChar = FontAwesome.Sharp.IconChar.User
        Me.MembersBtn.IconColor = System.Drawing.SystemColors.ButtonFace
        Me.MembersBtn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.MembersBtn.IconSize = 30
        Me.MembersBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MembersBtn.Location = New System.Drawing.Point(0, 0)
        Me.MembersBtn.Name = "MembersBtn"
        Me.MembersBtn.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.MembersBtn.Size = New System.Drawing.Size(210, 50)
        Me.MembersBtn.TabIndex = 2
        Me.MembersBtn.Text = "Members"
        Me.MembersBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MembersBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.MembersBtn.UseVisualStyleBackColor = True
        '
        'OptionsBtn
        '
        Me.OptionsBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.OptionsBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.OptionsBtn.FlatAppearance.BorderSize = 0
        Me.OptionsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OptionsBtn.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptionsBtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.OptionsBtn.IconChar = FontAwesome.Sharp.IconChar.Cog
        Me.OptionsBtn.IconColor = System.Drawing.SystemColors.ButtonFace
        Me.OptionsBtn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.OptionsBtn.IconSize = 30
        Me.OptionsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.OptionsBtn.Location = New System.Drawing.Point(0, 0)
        Me.OptionsBtn.Name = "OptionsBtn"
        Me.OptionsBtn.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.OptionsBtn.Size = New System.Drawing.Size(210, 50)
        Me.OptionsBtn.TabIndex = 2
        Me.OptionsBtn.Text = "Options"
        Me.OptionsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.OptionsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.OptionsBtn.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(10, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 15)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "User"
        '
        'PayslipBtn
        '
        Me.PayslipBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PayslipBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.PayslipBtn.FlatAppearance.BorderSize = 0
        Me.PayslipBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PayslipBtn.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PayslipBtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.PayslipBtn.IconChar = FontAwesome.Sharp.IconChar.MoneyBill
        Me.PayslipBtn.IconColor = System.Drawing.SystemColors.ButtonFace
        Me.PayslipBtn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.PayslipBtn.IconSize = 30
        Me.PayslipBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.PayslipBtn.Location = New System.Drawing.Point(0, 50)
        Me.PayslipBtn.Name = "PayslipBtn"
        Me.PayslipBtn.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.PayslipBtn.Size = New System.Drawing.Size(210, 50)
        Me.PayslipBtn.TabIndex = 3
        Me.PayslipBtn.Text = "Payslip"
        Me.PayslipBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.PayslipBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.PayslipBtn.UseVisualStyleBackColor = True
        '
        'ClockInBtn
        '
        Me.ClockInBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ClockInBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.ClockInBtn.FlatAppearance.BorderSize = 0
        Me.ClockInBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ClockInBtn.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClockInBtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.ClockInBtn.IconChar = FontAwesome.Sharp.IconChar.ClockFour
        Me.ClockInBtn.IconColor = System.Drawing.SystemColors.ButtonFace
        Me.ClockInBtn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.ClockInBtn.IconSize = 30
        Me.ClockInBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ClockInBtn.Location = New System.Drawing.Point(0, 0)
        Me.ClockInBtn.Name = "ClockInBtn"
        Me.ClockInBtn.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.ClockInBtn.Size = New System.Drawing.Size(210, 50)
        Me.ClockInBtn.TabIndex = 2
        Me.ClockInBtn.Text = "Time Clock"
        Me.ClockInBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ClockInBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ClockInBtn.UseVisualStyleBackColor = True
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(31, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 15)
        Me.Label2.TabIndex = 26
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
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MainDesign"
        Me.Text = "MainDesign"
        Me.TopMost = True
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
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
    Friend WithEvents ClockInBtn As FontAwesome.Sharp.IconButton
    Friend WithEvents PayslipBtn As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel4 As Panel
    Friend WithEvents OptionsBtn As FontAwesome.Sharp.IconButton
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents AdminLabel As Label
    Friend WithEvents MembersBtn As FontAwesome.Sharp.IconButton
    Friend WithEvents ReportsBtn As FontAwesome.Sharp.IconButton
    Friend WithEvents AddStaffBtn As FontAwesome.Sharp.IconButton
    Friend WithEvents UserTypeLbl As Label
    Friend WithEvents UsersNameLbl As Label
    Friend WithEvents ExitBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Shapes1 As Guna.UI2.WinForms.Guna2Shapes
End Class
