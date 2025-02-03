<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Guna2Shapes1 = New Guna.UI2.WinForms.Guna2Shapes()
        Me.SuspendLayout()
        '
        'Guna2Shapes1
        '
        Me.Guna2Shapes1.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2Shapes1.FillColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Guna2Shapes1.Location = New System.Drawing.Point(-26, -41)
        Me.Guna2Shapes1.Name = "Guna2Shapes1"
        Me.Guna2Shapes1.PolygonSkip = 1
        Me.Guna2Shapes1.Rotate = 0!
        Me.Guna2Shapes1.RoundedRadius = 5
        Me.Guna2Shapes1.Shape = Guna.UI2.WinForms.Enums.ShapeType.Rounded
        Me.Guna2Shapes1.Size = New System.Drawing.Size(852, 533)
        Me.Guna2Shapes1.TabIndex = 1
        Me.Guna2Shapes1.Text = "Guna2Shapes1"
        Me.Guna2Shapes1.Zoom = 80
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Guna2Shapes1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Shapes1 As Guna.UI2.WinForms.Guna2Shapes
End Class
