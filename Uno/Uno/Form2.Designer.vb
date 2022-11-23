<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.labelDirection = New System.Windows.Forms.Label()
        Me.labelRed = New System.Windows.Forms.Label()
        Me.labelYellow = New System.Windows.Forms.Label()
        Me.labelBlue = New System.Windows.Forms.Label()
        Me.labelGreen = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'labelDirection
        '
        Me.labelDirection.Font = New System.Drawing.Font("Ravie", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelDirection.ForeColor = System.Drawing.Color.White
        Me.labelDirection.Location = New System.Drawing.Point(12, 0)
        Me.labelDirection.Name = "labelDirection"
        Me.labelDirection.Size = New System.Drawing.Size(376, 70)
        Me.labelDirection.TabIndex = 0
        Me.labelDirection.Text = "CHOOSE YOUR WILD CARD COLOR"
        Me.labelDirection.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labelRed
        '
        Me.labelRed.BackColor = System.Drawing.Color.Red
        Me.labelRed.Location = New System.Drawing.Point(0, 80)
        Me.labelRed.Name = "labelRed"
        Me.labelRed.Size = New System.Drawing.Size(200, 160)
        Me.labelRed.TabIndex = 1
        '
        'labelYellow
        '
        Me.labelYellow.BackColor = System.Drawing.Color.Yellow
        Me.labelYellow.Location = New System.Drawing.Point(0, 240)
        Me.labelYellow.Name = "labelYellow"
        Me.labelYellow.Size = New System.Drawing.Size(200, 160)
        Me.labelYellow.TabIndex = 2
        '
        'labelBlue
        '
        Me.labelBlue.BackColor = System.Drawing.Color.Blue
        Me.labelBlue.Location = New System.Drawing.Point(200, 80)
        Me.labelBlue.Name = "labelBlue"
        Me.labelBlue.Size = New System.Drawing.Size(200, 160)
        Me.labelBlue.TabIndex = 3
        '
        'labelGreen
        '
        Me.labelGreen.BackColor = System.Drawing.Color.Green
        Me.labelGreen.Location = New System.Drawing.Point(200, 240)
        Me.labelGreen.Name = "labelGreen"
        Me.labelGreen.Size = New System.Drawing.Size(200, 160)
        Me.labelGreen.TabIndex = 4
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(400, 400)
        Me.Controls.Add(Me.labelGreen)
        Me.Controls.Add(Me.labelBlue)
        Me.Controls.Add(Me.labelYellow)
        Me.Controls.Add(Me.labelRed)
        Me.Controls.Add(Me.labelDirection)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents labelDirection As Label
    Friend WithEvents labelRed As Label
    Friend WithEvents labelYellow As Label
    Friend WithEvents labelBlue As Label
    Friend WithEvents labelGreen As Label
End Class
