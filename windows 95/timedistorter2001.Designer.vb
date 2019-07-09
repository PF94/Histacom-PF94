<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class timedistorter2001
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(timedistorter2001))
        Me.exampleprogramtopbar = New System.Windows.Forms.Panel()
        Me.maximizebutton = New System.Windows.Forms.PictureBox()
        Me.minimizebutton = New System.Windows.Forms.PictureBox()
        Me.exampleprogramtext = New System.Windows.Forms.Label()
        Me.closebutton = New System.Windows.Forms.PictureBox()
        Me.program = New System.Windows.Forms.Panel()
        Me.top = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.programname = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.bottomleftcorner = New System.Windows.Forms.Panel()
        Me.toprightcorner = New System.Windows.Forms.Panel()
        Me.bottomrightcorner = New System.Windows.Forms.Panel()
        Me.topleftcorner = New System.Windows.Forms.Panel()
        Me.bottom = New System.Windows.Forms.Panel()
        Me.right = New System.Windows.Forms.Panel()
        Me.left = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.exampleprogramtopbar.SuspendLayout()
        CType(Me.maximizebutton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.minimizebutton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.closebutton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.program.SuspendLayout()
        Me.top.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'exampleprogramtopbar
        '
        Me.exampleprogramtopbar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.exampleprogramtopbar.BackColor = System.Drawing.Color.DarkBlue
        Me.exampleprogramtopbar.BackgroundImage = Global.Histacom.My.Resources.Resources.windows2000gradient
        Me.exampleprogramtopbar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.exampleprogramtopbar.Controls.Add(Me.maximizebutton)
        Me.exampleprogramtopbar.Controls.Add(Me.minimizebutton)
        Me.exampleprogramtopbar.Controls.Add(Me.exampleprogramtext)
        Me.exampleprogramtopbar.Controls.Add(Me.closebutton)
        Me.exampleprogramtopbar.Location = New System.Drawing.Point(0, 1)
        Me.exampleprogramtopbar.Margin = New System.Windows.Forms.Padding(4)
        Me.exampleprogramtopbar.Name = "exampleprogramtopbar"
        Me.exampleprogramtopbar.Size = New System.Drawing.Size(545, 22)
        Me.exampleprogramtopbar.TabIndex = 1
        '
        'maximizebutton
        '
        Me.maximizebutton.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.maximizebutton.Image = Global.Histacom.My.Resources.Resources.Maximize
        Me.maximizebutton.Location = New System.Drawing.Point(500, 2)
        Me.maximizebutton.Margin = New System.Windows.Forms.Padding(4)
        Me.maximizebutton.Name = "maximizebutton"
        Me.maximizebutton.Size = New System.Drawing.Size(21, 17)
        Me.maximizebutton.TabIndex = 6
        Me.maximizebutton.TabStop = False
        '
        'minimizebutton
        '
        Me.minimizebutton.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.minimizebutton.Image = Global.Histacom.My.Resources.Resources.minimize
        Me.minimizebutton.Location = New System.Drawing.Point(478, 2)
        Me.minimizebutton.Margin = New System.Windows.Forms.Padding(4)
        Me.minimizebutton.Name = "minimizebutton"
        Me.minimizebutton.Size = New System.Drawing.Size(21, 17)
        Me.minimizebutton.TabIndex = 5
        Me.minimizebutton.TabStop = False
        '
        'exampleprogramtext
        '
        Me.exampleprogramtext.AutoSize = True
        Me.exampleprogramtext.BackColor = System.Drawing.Color.Transparent
        Me.exampleprogramtext.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exampleprogramtext.ForeColor = System.Drawing.Color.White
        Me.exampleprogramtext.Location = New System.Drawing.Point(4, 2)
        Me.exampleprogramtext.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.exampleprogramtext.Name = "exampleprogramtext"
        Me.exampleprogramtext.Size = New System.Drawing.Size(117, 17)
        Me.exampleprogramtext.TabIndex = 3
        Me.exampleprogramtext.Text = "Program1name"
        '
        'closebutton
        '
        Me.closebutton.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.closebutton.Image = Global.Histacom.My.Resources.Resources.close
        Me.closebutton.Location = New System.Drawing.Point(522, 2)
        Me.closebutton.Margin = New System.Windows.Forms.Padding(4)
        Me.closebutton.Name = "closebutton"
        Me.closebutton.Size = New System.Drawing.Size(21, 17)
        Me.closebutton.TabIndex = 4
        Me.closebutton.TabStop = False
        '
        'program
        '
        Me.program.BackColor = System.Drawing.Color.OldLace
        Me.program.Controls.Add(Me.Label1)
        Me.program.Controls.Add(Me.Button1)
        Me.program.Controls.Add(Me.Button2)
        Me.program.Controls.Add(Me.top)
        Me.program.Controls.Add(Me.bottomleftcorner)
        Me.program.Controls.Add(Me.toprightcorner)
        Me.program.Controls.Add(Me.bottomrightcorner)
        Me.program.Controls.Add(Me.topleftcorner)
        Me.program.Controls.Add(Me.bottom)
        Me.program.Controls.Add(Me.right)
        Me.program.Controls.Add(Me.left)
        Me.program.Dock = System.Windows.Forms.DockStyle.Fill
        Me.program.Location = New System.Drawing.Point(0, 0)
        Me.program.Margin = New System.Windows.Forms.Padding(4)
        Me.program.Name = "program"
        Me.program.Size = New System.Drawing.Size(545, 268)
        Me.program.TabIndex = 6
        '
        'top
        '
        Me.top.BackColor = System.Drawing.Color.Transparent
        Me.top.BackgroundImage = Global.Histacom.My.Resources.Resources.windowsxptopbarmiddle
        Me.top.Controls.Add(Me.PictureBox2)
        Me.top.Controls.Add(Me.PictureBox3)
        Me.top.Controls.Add(Me.programname)
        Me.top.Controls.Add(Me.PictureBox4)
        Me.top.Dock = System.Windows.Forms.DockStyle.Top
        Me.top.Location = New System.Drawing.Point(5, 0)
        Me.top.Margin = New System.Windows.Forms.Padding(4)
        Me.top.Name = "top"
        Me.top.Size = New System.Drawing.Size(535, 37)
        Me.top.TabIndex = 0
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.PictureBox2.Image = Global.Histacom.My.Resources.Resources.windowsxpmaximizebutton
        Me.PictureBox2.Location = New System.Drawing.Point(471, 6)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(28, 26)
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.PictureBox3.Image = Global.Histacom.My.Resources.Resources.windowsxpminimizebutton
        Me.PictureBox3.Location = New System.Drawing.Point(440, 6)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(28, 26)
        Me.PictureBox3.TabIndex = 5
        Me.PictureBox3.TabStop = False
        '
        'programname
        '
        Me.programname.AutoSize = True
        Me.programname.BackColor = System.Drawing.Color.Transparent
        Me.programname.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.programname.ForeColor = System.Drawing.Color.White
        Me.programname.Location = New System.Drawing.Point(7, 10)
        Me.programname.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.programname.Name = "programname"
        Me.programname.Size = New System.Drawing.Size(139, 17)
        Me.programname.TabIndex = 3
        Me.programname.Text = "Time Distorter 0.4"
        '
        'PictureBox4
        '
        Me.PictureBox4.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.PictureBox4.Image = Global.Histacom.My.Resources.Resources.windowsxpclosebutton
        Me.PictureBox4.Location = New System.Drawing.Point(501, 6)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(28, 26)
        Me.PictureBox4.TabIndex = 4
        Me.PictureBox4.TabStop = False
        '
        'bottomleftcorner
        '
        Me.bottomleftcorner.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bottomleftcorner.BackgroundImage = Global.Histacom.My.Resources.Resources.windowsxpbottomleftcorner
        Me.bottomleftcorner.Location = New System.Drawing.Point(0, 263)
        Me.bottomleftcorner.Margin = New System.Windows.Forms.Padding(4)
        Me.bottomleftcorner.Name = "bottomleftcorner"
        Me.bottomleftcorner.Size = New System.Drawing.Size(7, 5)
        Me.bottomleftcorner.TabIndex = 10
        '
        'toprightcorner
        '
        Me.toprightcorner.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.toprightcorner.BackColor = System.Drawing.Color.Magenta
        Me.toprightcorner.BackgroundImage = CType(resources.GetObject("toprightcorner.BackgroundImage"), System.Drawing.Image)
        Me.toprightcorner.Location = New System.Drawing.Point(537, 0)
        Me.toprightcorner.Margin = New System.Windows.Forms.Padding(4)
        Me.toprightcorner.Name = "toprightcorner"
        Me.toprightcorner.Size = New System.Drawing.Size(8, 37)
        Me.toprightcorner.TabIndex = 9
        '
        'bottomrightcorner
        '
        Me.bottomrightcorner.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bottomrightcorner.BackgroundImage = Global.Histacom.My.Resources.Resources.windowsxpbottomcorner
        Me.bottomrightcorner.Cursor = System.Windows.Forms.Cursors.SizeNWSE
        Me.bottomrightcorner.Location = New System.Drawing.Point(540, 263)
        Me.bottomrightcorner.Margin = New System.Windows.Forms.Padding(4)
        Me.bottomrightcorner.Name = "bottomrightcorner"
        Me.bottomrightcorner.Size = New System.Drawing.Size(5, 5)
        Me.bottomrightcorner.TabIndex = 4
        '
        'topleftcorner
        '
        Me.topleftcorner.BackColor = System.Drawing.Color.Magenta
        Me.topleftcorner.BackgroundImage = CType(resources.GetObject("topleftcorner.BackgroundImage"), System.Drawing.Image)
        Me.topleftcorner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.topleftcorner.Location = New System.Drawing.Point(0, 0)
        Me.topleftcorner.Margin = New System.Windows.Forms.Padding(4)
        Me.topleftcorner.Name = "topleftcorner"
        Me.topleftcorner.Size = New System.Drawing.Size(9, 37)
        Me.topleftcorner.TabIndex = 8
        '
        'bottom
        '
        Me.bottom.BackgroundImage = Global.Histacom.My.Resources.Resources.windowsxpbottom
        Me.bottom.Cursor = System.Windows.Forms.Cursors.SizeNS
        Me.bottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.bottom.Location = New System.Drawing.Point(5, 263)
        Me.bottom.Margin = New System.Windows.Forms.Padding(4)
        Me.bottom.Name = "bottom"
        Me.bottom.Size = New System.Drawing.Size(535, 5)
        Me.bottom.TabIndex = 3
        '
        'right
        '
        Me.right.BackgroundImage = Global.Histacom.My.Resources.Resources.windowsxprightside
        Me.right.Cursor = System.Windows.Forms.Cursors.SizeWE
        Me.right.Dock = System.Windows.Forms.DockStyle.Right
        Me.right.Location = New System.Drawing.Point(540, 0)
        Me.right.Margin = New System.Windows.Forms.Padding(4)
        Me.right.Name = "right"
        Me.right.Size = New System.Drawing.Size(5, 268)
        Me.right.TabIndex = 2
        '
        'left
        '
        Me.left.BackgroundImage = Global.Histacom.My.Resources.Resources.windowsxpleftside
        Me.left.Dock = System.Windows.Forms.DockStyle.Left
        Me.left.Location = New System.Drawing.Point(0, 0)
        Me.left.Margin = New System.Windows.Forms.Padding(4)
        Me.left.Name = "left"
        Me.left.Size = New System.Drawing.Size(5, 268)
        Me.left.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(221, 124)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "1999"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(33, 124)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "1998"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(170, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 17)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "time traver"
        '
        'timedistorter2001
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(545, 268)
        Me.Controls.Add(Me.program)
        Me.Controls.Add(Me.exampleprogramtopbar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "timedistorter2001"
        Me.Text = "timedistorter2001"
        Me.exampleprogramtopbar.ResumeLayout(False)
        Me.exampleprogramtopbar.PerformLayout()
        CType(Me.maximizebutton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.minimizebutton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.closebutton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.program.ResumeLayout(False)
        Me.program.PerformLayout()
        Me.top.ResumeLayout(False)
        Me.top.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents exampleprogramtopbar As System.Windows.Forms.Panel
    Friend WithEvents maximizebutton As System.Windows.Forms.PictureBox
    Friend WithEvents minimizebutton As System.Windows.Forms.PictureBox
    Friend WithEvents exampleprogramtext As System.Windows.Forms.Label
    Friend WithEvents closebutton As System.Windows.Forms.PictureBox
    Friend WithEvents program As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents top As System.Windows.Forms.Panel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents programname As System.Windows.Forms.Label
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents bottomleftcorner As System.Windows.Forms.Panel
    Friend WithEvents toprightcorner As System.Windows.Forms.Panel
    Friend WithEvents bottomrightcorner As System.Windows.Forms.Panel
    Friend WithEvents topleftcorner As System.Windows.Forms.Panel
    Friend WithEvents bottom As System.Windows.Forms.Panel
    Friend WithEvents right As System.Windows.Forms.Panel
    Friend WithEvents left As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
