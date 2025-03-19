<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClockInSubform
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
        Me.ClockOutBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.ClockInBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.lblSignInDot = New System.Windows.Forms.Label()
        Me.lblSignIn = New System.Windows.Forms.Label()
        Me.lblClock = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.LblShiftIndicator = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ClockOutBtn
        '
        Me.ClockOutBtn.Animated = True
        Me.ClockOutBtn.AutoRoundedCorners = True
        Me.ClockOutBtn.BackColor = System.Drawing.Color.Transparent
        Me.ClockOutBtn.BorderRadius = 21
        Me.ClockOutBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.ClockOutBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.ClockOutBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.ClockOutBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.ClockOutBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.ClockOutBtn.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClockOutBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.ClockOutBtn.Location = New System.Drawing.Point(395, 302)
        Me.ClockOutBtn.Name = "ClockOutBtn"
        Me.ClockOutBtn.PressedColor = System.Drawing.Color.SlateBlue
        Me.ClockOutBtn.Size = New System.Drawing.Size(180, 45)
        Me.ClockOutBtn.TabIndex = 28
        Me.ClockOutBtn.Text = "Clock Out"
        '
        'ClockInBtn
        '
        Me.ClockInBtn.Animated = True
        Me.ClockInBtn.AutoRoundedCorners = True
        Me.ClockInBtn.BackColor = System.Drawing.Color.Transparent
        Me.ClockInBtn.BorderRadius = 21
        Me.ClockInBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.ClockInBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.ClockInBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.ClockInBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.ClockInBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.ClockInBtn.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClockInBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.ClockInBtn.Location = New System.Drawing.Point(166, 302)
        Me.ClockInBtn.Name = "ClockInBtn"
        Me.ClockInBtn.PressedColor = System.Drawing.Color.SlateBlue
        Me.ClockInBtn.Size = New System.Drawing.Size(180, 45)
        Me.ClockInBtn.TabIndex = 27
        Me.ClockInBtn.Text = "Clock In"
        '
        'lblSignInDot
        '
        Me.lblSignInDot.AutoSize = True
        Me.lblSignInDot.BackColor = System.Drawing.Color.Transparent
        Me.lblSignInDot.Font = New System.Drawing.Font("Century Gothic", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSignInDot.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.lblSignInDot.Location = New System.Drawing.Point(363, 132)
        Me.lblSignInDot.Name = "lblSignInDot"
        Me.lblSignInDot.Size = New System.Drawing.Size(126, 44)
        Me.lblSignInDot.TabIndex = 26
        Me.lblSignInDot.Text = "Clock"
        '
        'lblSignIn
        '
        Me.lblSignIn.AutoSize = True
        Me.lblSignIn.BackColor = System.Drawing.Color.Transparent
        Me.lblSignIn.Font = New System.Drawing.Font("Century Gothic", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSignIn.ForeColor = System.Drawing.Color.White
        Me.lblSignIn.Location = New System.Drawing.Point(270, 132)
        Me.lblSignIn.Name = "lblSignIn"
        Me.lblSignIn.Size = New System.Drawing.Size(103, 44)
        Me.lblSignIn.TabIndex = 25
        Me.lblSignIn.Text = "Time"
        '
        'lblClock
        '
        Me.lblClock.AutoSize = True
        Me.lblClock.BackColor = System.Drawing.Color.Transparent
        Me.lblClock.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClock.ForeColor = System.Drawing.Color.White
        Me.lblClock.Location = New System.Drawing.Point(240, 195)
        Me.lblClock.Name = "lblClock"
        Me.lblClock.Size = New System.Drawing.Size(328, 32)
        Me.lblClock.TabIndex = 24
        Me.lblClock.Text = "DD/MM/YYYY HH:MM:SS"
        '
        'Timer1
        '
        '
        'LblShiftIndicator
        '
        Me.LblShiftIndicator.AutoSize = True
        Me.LblShiftIndicator.BackColor = System.Drawing.Color.Transparent
        Me.LblShiftIndicator.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblShiftIndicator.ForeColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.LblShiftIndicator.Location = New System.Drawing.Point(255, 248)
        Me.LblShiftIndicator.Name = "LblShiftIndicator"
        Me.LblShiftIndicator.Size = New System.Drawing.Size(228, 21)
        Me.LblShiftIndicator.TabIndex = 29
        Me.LblShiftIndicator.Text = "You are currently clocked in"
        '
        'ClockInSubform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(750, 515)
        Me.Controls.Add(Me.LblShiftIndicator)
        Me.Controls.Add(Me.ClockOutBtn)
        Me.Controls.Add(Me.ClockInBtn)
        Me.Controls.Add(Me.lblSignInDot)
        Me.Controls.Add(Me.lblSignIn)
        Me.Controls.Add(Me.lblClock)
        Me.Name = "ClockInSubform"
        Me.Text = "Clock In"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ClockOutBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ClockInBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblSignInDot As Label
    Friend WithEvents lblSignIn As Label
    Friend WithEvents lblClock As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents LblShiftIndicator As Label
End Class
