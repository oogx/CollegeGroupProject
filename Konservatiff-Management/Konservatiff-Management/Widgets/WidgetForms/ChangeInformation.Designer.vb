<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChangeInformation
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
        Me.btnCancel = New Guna.UI2.WinForms.Guna2Button()
        Me.btnSave = New Guna.UI2.WinForms.Guna2Button()
        Me.LblStaffName = New System.Windows.Forms.Label()
        Me.LblForename = New System.Windows.Forms.Label()
        Me.LblMobile = New System.Windows.Forms.Label()
        Me.LblDoB = New System.Windows.Forms.Label()
        Me.LblNINo = New System.Windows.Forms.Label()
        Me.LblSurname = New System.Windows.Forms.Label()
        Me.LblTaxID = New System.Windows.Forms.Label()
        Me.LblTxtSize = New System.Windows.Forms.Label()
        Me.LblContrast = New System.Windows.Forms.Label()
        Me.LblTheme = New System.Windows.Forms.Label()
        Me.LblSex = New System.Windows.Forms.Label()
        Me.LblPassword = New System.Windows.Forms.Label()
        Me.LblAdminStat = New System.Windows.Forms.Label()
        Me.LblEmail = New System.Windows.Forms.Label()
        Me.IconDropDownButton1 = New FontAwesome.Sharp.IconDropDownButton()
        Me.IconDropDownButton2 = New FontAwesome.Sharp.IconDropDownButton()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.Guna2CustomCheckBox1 = New Guna.UI2.WinForms.Guna2CustomCheckBox()
        Me.Guna2CustomCheckBox2 = New Guna.UI2.WinForms.Guna2CustomCheckBox()
        Me.Guna2CustomCheckBox3 = New Guna.UI2.WinForms.Guna2CustomCheckBox()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.Animated = True
        Me.btnCancel.AutoRoundedCorners = True
        Me.btnCancel.BackColor = System.Drawing.Color.Transparent
        Me.btnCancel.BorderRadius = 21
        Me.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnCancel.FillColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btnCancel.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.btnCancel.Location = New System.Drawing.Point(176, 427)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(180, 45)
        Me.btnCancel.TabIndex = 28
        Me.btnCancel.Text = "Cancel"
        '
        'btnSave
        '
        Me.btnSave.Animated = True
        Me.btnSave.AutoRoundedCorners = True
        Me.btnSave.BackColor = System.Drawing.Color.Transparent
        Me.btnSave.BorderRadius = 21
        Me.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSave.FillColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btnSave.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.btnSave.Location = New System.Drawing.Point(412, 427)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(180, 45)
        Me.btnSave.TabIndex = 29
        Me.btnSave.Text = "Save"
        '
        'LblStaffName
        '
        Me.LblStaffName.AutoSize = True
        Me.LblStaffName.Font = New System.Drawing.Font("Century Gothic", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblStaffName.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LblStaffName.Location = New System.Drawing.Point(277, 9)
        Me.LblStaffName.Name = "LblStaffName"
        Me.LblStaffName.Size = New System.Drawing.Size(213, 44)
        Me.LblStaffName.TabIndex = 30
        Me.LblStaffName.Text = "Staff Name"
        '
        'LblForename
        '
        Me.LblForename.AutoSize = True
        Me.LblForename.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblForename.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LblForename.Location = New System.Drawing.Point(37, 73)
        Me.LblForename.Name = "LblForename"
        Me.LblForename.Size = New System.Drawing.Size(83, 20)
        Me.LblForename.TabIndex = 31
        Me.LblForename.Text = "Forename"
        '
        'LblMobile
        '
        Me.LblMobile.AutoSize = True
        Me.LblMobile.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMobile.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LblMobile.Location = New System.Drawing.Point(37, 287)
        Me.LblMobile.Name = "LblMobile"
        Me.LblMobile.Size = New System.Drawing.Size(122, 20)
        Me.LblMobile.TabIndex = 32
        Me.LblMobile.Text = "Mobile Number"
        '
        'LblDoB
        '
        Me.LblDoB.AutoSize = True
        Me.LblDoB.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDoB.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LblDoB.Location = New System.Drawing.Point(37, 242)
        Me.LblDoB.Name = "LblDoB"
        Me.LblDoB.Size = New System.Drawing.Size(39, 20)
        Me.LblDoB.TabIndex = 33
        Me.LblDoB.Text = "DoB"
        '
        'LblNINo
        '
        Me.LblNINo.AutoSize = True
        Me.LblNINo.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNINo.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LblNINo.Location = New System.Drawing.Point(37, 200)
        Me.LblNINo.Name = "LblNINo"
        Me.LblNINo.Size = New System.Drawing.Size(46, 20)
        Me.LblNINo.TabIndex = 34
        Me.LblNINo.Text = "NINo"
        '
        'LblSurname
        '
        Me.LblSurname.AutoSize = True
        Me.LblSurname.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSurname.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LblSurname.Location = New System.Drawing.Point(37, 114)
        Me.LblSurname.Name = "LblSurname"
        Me.LblSurname.Size = New System.Drawing.Size(72, 20)
        Me.LblSurname.TabIndex = 35
        Me.LblSurname.Text = "Surname"
        '
        'LblTaxID
        '
        Me.LblTaxID.AutoSize = True
        Me.LblTaxID.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTaxID.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LblTaxID.Location = New System.Drawing.Point(37, 158)
        Me.LblTaxID.Name = "LblTaxID"
        Me.LblTaxID.Size = New System.Drawing.Size(47, 20)
        Me.LblTaxID.TabIndex = 36
        Me.LblTaxID.Text = "TaxID"
        '
        'LblTxtSize
        '
        Me.LblTxtSize.AutoSize = True
        Me.LblTxtSize.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTxtSize.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LblTxtSize.Location = New System.Drawing.Point(438, 74)
        Me.LblTxtSize.Name = "LblTxtSize"
        Me.LblTxtSize.Size = New System.Drawing.Size(66, 20)
        Me.LblTxtSize.TabIndex = 37
        Me.LblTxtSize.Text = "Text Size"
        '
        'LblContrast
        '
        Me.LblContrast.AutoSize = True
        Me.LblContrast.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblContrast.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LblContrast.Location = New System.Drawing.Point(438, 288)
        Me.LblContrast.Name = "LblContrast"
        Me.LblContrast.Size = New System.Drawing.Size(71, 20)
        Me.LblContrast.TabIndex = 38
        Me.LblContrast.Text = "Contrast"
        '
        'LblTheme
        '
        Me.LblTheme.AutoSize = True
        Me.LblTheme.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTheme.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LblTheme.Location = New System.Drawing.Point(438, 246)
        Me.LblTheme.Name = "LblTheme"
        Me.LblTheme.Size = New System.Drawing.Size(94, 20)
        Me.LblTheme.TabIndex = 39
        Me.LblTheme.Text = "Dark Theme"
        '
        'LblSex
        '
        Me.LblSex.AutoSize = True
        Me.LblSex.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSex.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LblSex.Location = New System.Drawing.Point(438, 157)
        Me.LblSex.Name = "LblSex"
        Me.LblSex.Size = New System.Drawing.Size(33, 20)
        Me.LblSex.TabIndex = 40
        Me.LblSex.Text = "Sex"
        '
        'LblPassword
        '
        Me.LblPassword.AutoSize = True
        Me.LblPassword.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPassword.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LblPassword.Location = New System.Drawing.Point(438, 113)
        Me.LblPassword.Name = "LblPassword"
        Me.LblPassword.Size = New System.Drawing.Size(79, 20)
        Me.LblPassword.TabIndex = 41
        Me.LblPassword.Text = "Password"
        '
        'LblAdminStat
        '
        Me.LblAdminStat.AutoSize = True
        Me.LblAdminStat.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAdminStat.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LblAdminStat.Location = New System.Drawing.Point(438, 204)
        Me.LblAdminStat.Name = "LblAdminStat"
        Me.LblAdminStat.Size = New System.Drawing.Size(101, 20)
        Me.LblAdminStat.TabIndex = 42
        Me.LblAdminStat.Text = "Admin Status"
        '
        'LblEmail
        '
        Me.LblEmail.AutoSize = True
        Me.LblEmail.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEmail.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LblEmail.Location = New System.Drawing.Point(37, 333)
        Me.LblEmail.Name = "LblEmail"
        Me.LblEmail.Size = New System.Drawing.Size(46, 20)
        Me.LblEmail.TabIndex = 43
        Me.LblEmail.Text = "Email"
        '
        'IconDropDownButton1
        '
        Me.IconDropDownButton1.IconChar = FontAwesome.Sharp.IconChar.None
        Me.IconDropDownButton1.IconColor = System.Drawing.Color.Black
        Me.IconDropDownButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconDropDownButton1.Name = "IconDropDownButton1"
        Me.IconDropDownButton1.Size = New System.Drawing.Size(23, 23)
        Me.IconDropDownButton1.Text = "IconDropDownButton1"
        '
        'IconDropDownButton2
        '
        Me.IconDropDownButton2.IconChar = FontAwesome.Sharp.IconChar.None
        Me.IconDropDownButton2.IconColor = System.Drawing.Color.Black
        Me.IconDropDownButton2.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconDropDownButton2.Name = "IconDropDownButton2"
        Me.IconDropDownButton2.Size = New System.Drawing.Size(23, 23)
        Me.IconDropDownButton2.Text = "IconDropDownButton2"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(202, 118)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(176, 20)
        Me.TextBox1.TabIndex = 44
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(202, 77)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(176, 20)
        Me.TextBox2.TabIndex = 45
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(590, 160)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(133, 20)
        Me.TextBox5.TabIndex = 48
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(590, 116)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(133, 20)
        Me.TextBox6.TabIndex = 49
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(202, 335)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(176, 20)
        Me.TextBox8.TabIndex = 51
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(202, 291)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(176, 20)
        Me.TextBox9.TabIndex = 52
        '
        'TextBox10
        '
        Me.TextBox10.Location = New System.Drawing.Point(202, 246)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(176, 20)
        Me.TextBox10.TabIndex = 53
        '
        'TextBox11
        '
        Me.TextBox11.Location = New System.Drawing.Point(202, 204)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(176, 20)
        Me.TextBox11.TabIndex = 54
        '
        'TextBox12
        '
        Me.TextBox12.Location = New System.Drawing.Point(202, 162)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(176, 20)
        Me.TextBox12.TabIndex = 55
        '
        'TextBox13
        '
        Me.TextBox13.Location = New System.Drawing.Point(590, 77)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(133, 20)
        Me.TextBox13.TabIndex = 56
        '
        'Guna2CustomCheckBox1
        '
        Me.Guna2CustomCheckBox1.Checked = True
        Me.Guna2CustomCheckBox1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2CustomCheckBox1.CheckedState.BorderRadius = 2
        Me.Guna2CustomCheckBox1.CheckedState.BorderThickness = 0
        Me.Guna2CustomCheckBox1.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2CustomCheckBox1.Location = New System.Drawing.Point(590, 251)
        Me.Guna2CustomCheckBox1.Name = "Guna2CustomCheckBox1"
        Me.Guna2CustomCheckBox1.Size = New System.Drawing.Size(20, 20)
        Me.Guna2CustomCheckBox1.TabIndex = 58
        Me.Guna2CustomCheckBox1.Text = "Guna2CustomCheckBox1"
        Me.Guna2CustomCheckBox1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2CustomCheckBox1.UncheckedState.BorderRadius = 2
        Me.Guna2CustomCheckBox1.UncheckedState.BorderThickness = 0
        Me.Guna2CustomCheckBox1.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        '
        'Guna2CustomCheckBox2
        '
        Me.Guna2CustomCheckBox2.Checked = True
        Me.Guna2CustomCheckBox2.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2CustomCheckBox2.CheckedState.BorderRadius = 2
        Me.Guna2CustomCheckBox2.CheckedState.BorderThickness = 0
        Me.Guna2CustomCheckBox2.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2CustomCheckBox2.Location = New System.Drawing.Point(590, 291)
        Me.Guna2CustomCheckBox2.Name = "Guna2CustomCheckBox2"
        Me.Guna2CustomCheckBox2.Size = New System.Drawing.Size(20, 20)
        Me.Guna2CustomCheckBox2.TabIndex = 59
        Me.Guna2CustomCheckBox2.Text = "Guna2CustomCheckBox2"
        Me.Guna2CustomCheckBox2.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2CustomCheckBox2.UncheckedState.BorderRadius = 2
        Me.Guna2CustomCheckBox2.UncheckedState.BorderThickness = 0
        Me.Guna2CustomCheckBox2.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        '
        'Guna2CustomCheckBox3
        '
        Me.Guna2CustomCheckBox3.Checked = True
        Me.Guna2CustomCheckBox3.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2CustomCheckBox3.CheckedState.BorderRadius = 2
        Me.Guna2CustomCheckBox3.CheckedState.BorderThickness = 0
        Me.Guna2CustomCheckBox3.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2CustomCheckBox3.Location = New System.Drawing.Point(590, 204)
        Me.Guna2CustomCheckBox3.Name = "Guna2CustomCheckBox3"
        Me.Guna2CustomCheckBox3.Size = New System.Drawing.Size(20, 20)
        Me.Guna2CustomCheckBox3.TabIndex = 60
        Me.Guna2CustomCheckBox3.Text = "Guna2CustomCheckBox3"
        Me.Guna2CustomCheckBox3.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2CustomCheckBox3.UncheckedState.BorderRadius = 2
        Me.Guna2CustomCheckBox3.UncheckedState.BorderThickness = 0
        Me.Guna2CustomCheckBox3.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        '
        'ChangeInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(750, 515)
        Me.Controls.Add(Me.Guna2CustomCheckBox3)
        Me.Controls.Add(Me.Guna2CustomCheckBox2)
        Me.Controls.Add(Me.Guna2CustomCheckBox1)
        Me.Controls.Add(Me.TextBox13)
        Me.Controls.Add(Me.TextBox12)
        Me.Controls.Add(Me.TextBox11)
        Me.Controls.Add(Me.TextBox10)
        Me.Controls.Add(Me.TextBox9)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.LblEmail)
        Me.Controls.Add(Me.LblAdminStat)
        Me.Controls.Add(Me.LblPassword)
        Me.Controls.Add(Me.LblSex)
        Me.Controls.Add(Me.LblTheme)
        Me.Controls.Add(Me.LblContrast)
        Me.Controls.Add(Me.LblTxtSize)
        Me.Controls.Add(Me.LblTaxID)
        Me.Controls.Add(Me.LblSurname)
        Me.Controls.Add(Me.LblNINo)
        Me.Controls.Add(Me.LblDoB)
        Me.Controls.Add(Me.LblMobile)
        Me.Controls.Add(Me.LblForename)
        Me.Controls.Add(Me.LblStaffName)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnCancel)
        Me.Name = "ChangeInformation"
        Me.Text = "ChangeInformation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCancel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSave As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents LblStaffName As Label
    Friend WithEvents LblForename As Label
    Friend WithEvents LblMobile As Label
    Friend WithEvents LblDoB As Label
    Friend WithEvents LblNINo As Label
    Friend WithEvents LblSurname As Label
    Friend WithEvents LblTaxID As Label
    Friend WithEvents LblTxtSize As Label
    Friend WithEvents LblContrast As Label
    Friend WithEvents LblTheme As Label
    Friend WithEvents LblSex As Label
    Friend WithEvents LblPassword As Label
    Friend WithEvents LblAdminStat As Label
    Friend WithEvents LblEmail As Label
    Friend WithEvents IconDropDownButton1 As FontAwesome.Sharp.IconDropDownButton
    Friend WithEvents IconDropDownButton2 As FontAwesome.Sharp.IconDropDownButton
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents TextBox12 As TextBox
    Friend WithEvents TextBox13 As TextBox
    Friend WithEvents Guna2CustomCheckBox1 As Guna.UI2.WinForms.Guna2CustomCheckBox
    Friend WithEvents Guna2CustomCheckBox2 As Guna.UI2.WinForms.Guna2CustomCheckBox
    Friend WithEvents Guna2CustomCheckBox3 As Guna.UI2.WinForms.Guna2CustomCheckBox
End Class
