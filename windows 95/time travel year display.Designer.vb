<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class time_travel_year_display
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
        Me.year = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'year
        '
        Me.year.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.year.AutoSize = True
        Me.year.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.year.ForeColor = System.Drawing.Color.Lime
        Me.year.Location = New System.Drawing.Point(145, 9)
        Me.year.Name = "year"
        Me.year.Size = New System.Drawing.Size(337, 108)
        Me.year.TabIndex = 0
        Me.year.Text = "Label1"
        '
        'time_travel_year_display
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(637, 412)
        Me.Controls.Add(Me.year)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "time_travel_year_display"
        Me.Text = "time_travel_year_display"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents year As System.Windows.Forms.Label
End Class
