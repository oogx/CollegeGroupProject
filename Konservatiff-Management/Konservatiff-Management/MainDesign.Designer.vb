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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.KMText = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.User_Desktop_Panel = New System.Windows.Forms.Panel()
        Me.ClockInButton = New FontAwesome.Sharp.IconButton()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
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
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Panel2.Controls.Add(Me.KMText)
        Me.Panel2.Location = New System.Drawing.Point(-19, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1012, 50)
        Me.Panel2.TabIndex = 31
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
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Panel3.Controls.Add(Me.ClockInButton)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Location = New System.Drawing.Point(0, 45)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(210, 566)
        Me.Panel3.TabIndex = 32
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Main Menu"
        '
        'User_Desktop_Panel
        '
        Me.User_Desktop_Panel.Location = New System.Drawing.Point(207, 45)
        Me.User_Desktop_Panel.Name = "User_Desktop_Panel"
        Me.User_Desktop_Panel.Size = New System.Drawing.Size(766, 554)
        Me.User_Desktop_Panel.TabIndex = 33
        '
        'ClockInButton
        '
        Me.ClockInButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ClockInButton.ForeColor = System.Drawing.Color.White
        Me.ClockInButton.IconChar = FontAwesome.Sharp.IconChar.MaskVentilator
        Me.ClockInButton.IconColor = System.Drawing.Color.White
        Me.ClockInButton.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.ClockInButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ClockInButton.Location = New System.Drawing.Point(12, 36)
        Me.ClockInButton.Name = "ClockInButton"
        Me.ClockInButton.Size = New System.Drawing.Size(142, 38)
        Me.ClockInButton.TabIndex = 1
        Me.ClockInButton.Text = "Clock In"
        Me.ClockInButton.UseVisualStyleBackColor = False
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
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents KMText As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Panel3 As Panel
    Friend WithEvents User_Desktop_Panel As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents ClockInButton As FontAwesome.Sharp.IconButton
End Class
