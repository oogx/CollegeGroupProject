<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Dropdown
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
        Me.ChangeInformationBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.ViewShiftsBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.DeleteMemberBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.PDFPayslipBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.CloseDropdownBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.SuspendLayout()
        '
        'ChangeInformationBtn
        '
        Me.ChangeInformationBtn.Animated = True
        Me.ChangeInformationBtn.AutoRoundedCorners = True
        Me.ChangeInformationBtn.BackColor = System.Drawing.Color.Transparent
        Me.ChangeInformationBtn.BorderRadius = 21
        Me.ChangeInformationBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.ChangeInformationBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.ChangeInformationBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.ChangeInformationBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.ChangeInformationBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.ChangeInformationBtn.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChangeInformationBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.ChangeInformationBtn.Location = New System.Drawing.Point(2, 7)
        Me.ChangeInformationBtn.Name = "ChangeInformationBtn"
        Me.ChangeInformationBtn.Size = New System.Drawing.Size(180, 45)
        Me.ChangeInformationBtn.TabIndex = 28
        Me.ChangeInformationBtn.Text = "Change Information"
        '
        'ViewShiftsBtn
        '
        Me.ViewShiftsBtn.Animated = True
        Me.ViewShiftsBtn.AutoRoundedCorners = True
        Me.ViewShiftsBtn.BackColor = System.Drawing.Color.Transparent
        Me.ViewShiftsBtn.BorderRadius = 21
        Me.ViewShiftsBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.ViewShiftsBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.ViewShiftsBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.ViewShiftsBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.ViewShiftsBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.ViewShiftsBtn.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewShiftsBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.ViewShiftsBtn.Location = New System.Drawing.Point(2, 58)
        Me.ViewShiftsBtn.Name = "ViewShiftsBtn"
        Me.ViewShiftsBtn.Size = New System.Drawing.Size(180, 45)
        Me.ViewShiftsBtn.TabIndex = 29
        Me.ViewShiftsBtn.Text = "View Shifts"
        '
        'DeleteMemberBtn
        '
        Me.DeleteMemberBtn.Animated = True
        Me.DeleteMemberBtn.AutoRoundedCorners = True
        Me.DeleteMemberBtn.BackColor = System.Drawing.Color.Transparent
        Me.DeleteMemberBtn.BorderRadius = 21
        Me.DeleteMemberBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.DeleteMemberBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.DeleteMemberBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.DeleteMemberBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.DeleteMemberBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.DeleteMemberBtn.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteMemberBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.DeleteMemberBtn.Location = New System.Drawing.Point(2, 109)
        Me.DeleteMemberBtn.Name = "DeleteMemberBtn"
        Me.DeleteMemberBtn.Size = New System.Drawing.Size(180, 45)
        Me.DeleteMemberBtn.TabIndex = 30
        Me.DeleteMemberBtn.Text = "Delete Member"
        '
        'PDFPayslipBtn
        '
        Me.PDFPayslipBtn.Animated = True
        Me.PDFPayslipBtn.AutoRoundedCorners = True
        Me.PDFPayslipBtn.BackColor = System.Drawing.Color.Transparent
        Me.PDFPayslipBtn.BorderRadius = 21
        Me.PDFPayslipBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.PDFPayslipBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.PDFPayslipBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.PDFPayslipBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.PDFPayslipBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.PDFPayslipBtn.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PDFPayslipBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.PDFPayslipBtn.Location = New System.Drawing.Point(2, 259)
        Me.PDFPayslipBtn.Name = "PDFPayslipBtn"
        Me.PDFPayslipBtn.Size = New System.Drawing.Size(180, 45)
        Me.PDFPayslipBtn.TabIndex = 32
        Me.PDFPayslipBtn.Text = "View Payslip"
        '
        'CloseDropdownBtn
        '
        Me.CloseDropdownBtn.Animated = True
        Me.CloseDropdownBtn.AutoRoundedCorners = True
        Me.CloseDropdownBtn.BackColor = System.Drawing.Color.Transparent
        Me.CloseDropdownBtn.BorderRadius = 21
        Me.CloseDropdownBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.CloseDropdownBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.CloseDropdownBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.CloseDropdownBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.CloseDropdownBtn.FillColor = System.Drawing.Color.Red
        Me.CloseDropdownBtn.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseDropdownBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.CloseDropdownBtn.Location = New System.Drawing.Point(2, 310)
        Me.CloseDropdownBtn.Name = "CloseDropdownBtn"
        Me.CloseDropdownBtn.Size = New System.Drawing.Size(180, 45)
        Me.CloseDropdownBtn.TabIndex = 33
        Me.CloseDropdownBtn.Text = "Close Dropdown"
        '
        'Dropdown
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(184, 365)
        Me.ControlBox = False
        Me.Controls.Add(Me.CloseDropdownBtn)
        Me.Controls.Add(Me.PDFPayslipBtn)
        Me.Controls.Add(Me.DeleteMemberBtn)
        Me.Controls.Add(Me.ViewShiftsBtn)
        Me.Controls.Add(Me.ChangeInformationBtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Dropdown"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.Text = "Dropdown"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ChangeInformationBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ViewShiftsBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents DeleteMemberBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PDFPayslipBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents CloseDropdownBtn As Guna.UI2.WinForms.Guna2Button
End Class
