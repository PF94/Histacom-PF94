<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class templetevista
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(templetevista))
        Me.pullside = New System.Windows.Forms.Timer(Me.components)
        Me.pullbottom = New System.Windows.Forms.Timer(Me.components)
        Me.pullbs = New System.Windows.Forms.Timer(Me.components)
        Me.look = New System.Windows.Forms.Timer(Me.components)
        Me.program = New System.Windows.Forms.Panel()
        Me.top = New System.Windows.Forms.Panel()
        Me.maximizebutton = New System.Windows.Forms.PictureBox()
        Me.minimizebutton = New System.Windows.Forms.PictureBox()
        Me.programname = New System.Windows.Forms.Label()
        Me.closebutton = New System.Windows.Forms.PictureBox()
        Me.bottomleftcorner = New System.Windows.Forms.Panel()
        Me.toprightcorner = New System.Windows.Forms.Panel()
        Me.bottomrightcorner = New System.Windows.Forms.Panel()
        Me.topleftcorner = New System.Windows.Forms.Panel()
        Me.bottom = New System.Windows.Forms.Panel()
        Me.right = New System.Windows.Forms.Panel()
        Me.left = New System.Windows.Forms.Panel()
        Me.program.SuspendLayout()
        Me.top.SuspendLayout()
        CType(Me.maximizebutton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.minimizebutton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.closebutton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pullside
        '
        Me.pullside.Interval = 1
        '
        'pullbottom
        '
        Me.pullbottom.Interval = 1
        '
        'pullbs
        '
        Me.pullbs.Interval = 1
        '
        'look
        '
        '
        'program
        '
        Me.program.BackColor = System.Drawing.Color.Transparent
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
        Me.program.Name = "program"
        Me.program.Size = New System.Drawing.Size(561, 414)
        Me.program.TabIndex = 5
        '
        'top
        '
        Me.top.BackColor = System.Drawing.Color.Transparent
        Me.top.BackgroundImage = Global.Histacom.My.Resources.Resources.vistatop
        Me.top.Controls.Add(Me.maximizebutton)
        Me.top.Controls.Add(Me.minimizebutton)
        Me.top.Controls.Add(Me.programname)
        Me.top.Controls.Add(Me.closebutton)
        Me.top.Dock = System.Windows.Forms.DockStyle.Top
        Me.top.Location = New System.Drawing.Point(4, 0)
        Me.top.Name = "top"
        Me.top.Size = New System.Drawing.Size(553, 30)
        Me.top.TabIndex = 0
        '
        'maximizebutton
        '
        Me.maximizebutton.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.maximizebutton.BackColor = System.Drawing.Color.White
        Me.maximizebutton.Image = Global.Histacom.My.Resources.Resources.windowsxpmaximizebutton
        Me.maximizebutton.Location = New System.Drawing.Point(505, 5)
        Me.maximizebutton.Name = "maximizebutton"
        Me.maximizebutton.Size = New System.Drawing.Size(21, 21)
        Me.maximizebutton.TabIndex = 6
        Me.maximizebutton.TabStop = False
        '
        'minimizebutton
        '
        Me.minimizebutton.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.minimizebutton.BackColor = System.Drawing.Color.White
        Me.minimizebutton.Image = Global.Histacom.My.Resources.Resources.windowsxpminimizebutton
        Me.minimizebutton.Location = New System.Drawing.Point(482, 5)
        Me.minimizebutton.Name = "minimizebutton"
        Me.minimizebutton.Size = New System.Drawing.Size(21, 21)
        Me.minimizebutton.TabIndex = 5
        Me.minimizebutton.TabStop = False
        '
        'programname
        '
        Me.programname.AutoSize = True
        Me.programname.BackColor = System.Drawing.Color.Transparent
        Me.programname.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.programname.ForeColor = System.Drawing.Color.Black
        Me.programname.Location = New System.Drawing.Point(9, 9)
        Me.programname.Name = "programname"
        Me.programname.Size = New System.Drawing.Size(78, 13)
        Me.programname.TabIndex = 3
        Me.programname.Text = "Program1name"
        '
        'closebutton
        '
        Me.closebutton.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.closebutton.BackColor = System.Drawing.Color.White
        Me.closebutton.Image = Global.Histacom.My.Resources.Resources.windowsxpclosebutton
        Me.closebutton.Location = New System.Drawing.Point(528, 5)
        Me.closebutton.Name = "closebutton"
        Me.closebutton.Size = New System.Drawing.Size(21, 21)
        Me.closebutton.TabIndex = 4
        Me.closebutton.TabStop = False
        '
        'bottomleftcorner
        '
        Me.bottomleftcorner.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bottomleftcorner.BackgroundImage = Global.Histacom.My.Resources.Resources.windowsxpbottomleftcorner
        Me.bottomleftcorner.Location = New System.Drawing.Point(0, 410)
        Me.bottomleftcorner.Name = "bottomleftcorner"
        Me.bottomleftcorner.Size = New System.Drawing.Size(5, 4)
        Me.bottomleftcorner.TabIndex = 10
        '
        'toprightcorner
        '
        Me.toprightcorner.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.toprightcorner.BackColor = System.Drawing.Color.Magenta
        Me.toprightcorner.BackgroundImage = CType(resources.GetObject("toprightcorner.BackgroundImage"), System.Drawing.Image)
        Me.toprightcorner.Location = New System.Drawing.Point(555, 0)
        Me.toprightcorner.Name = "toprightcorner"
        Me.toprightcorner.Size = New System.Drawing.Size(6, 30)
        Me.toprightcorner.TabIndex = 9
        '
        'bottomrightcorner
        '
        Me.bottomrightcorner.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bottomrightcorner.BackgroundImage = Global.Histacom.My.Resources.Resources.windowsxpbottomcorner
        Me.bottomrightcorner.Cursor = System.Windows.Forms.Cursors.SizeNWSE
        Me.bottomrightcorner.Location = New System.Drawing.Point(557, 410)
        Me.bottomrightcorner.Name = "bottomrightcorner"
        Me.bottomrightcorner.Size = New System.Drawing.Size(4, 4)
        Me.bottomrightcorner.TabIndex = 4
        '
        'topleftcorner
        '
        Me.topleftcorner.BackColor = System.Drawing.Color.Magenta
        Me.topleftcorner.BackgroundImage = CType(resources.GetObject("topleftcorner.BackgroundImage"), System.Drawing.Image)
        Me.topleftcorner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.topleftcorner.Location = New System.Drawing.Point(0, 0)
        Me.topleftcorner.Name = "topleftcorner"
        Me.topleftcorner.Size = New System.Drawing.Size(7, 30)
        Me.topleftcorner.TabIndex = 8
        '
        'bottom
        '
        Me.bottom.BackgroundImage = Global.Histacom.My.Resources.Resources.windowsxpbottom
        Me.bottom.Cursor = System.Windows.Forms.Cursors.SizeNS
        Me.bottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.bottom.Location = New System.Drawing.Point(4, 410)
        Me.bottom.Name = "bottom"
        Me.bottom.Size = New System.Drawing.Size(553, 4)
        Me.bottom.TabIndex = 3
        '
        'right
        '
        Me.right.BackgroundImage = Global.Histacom.My.Resources.Resources.windowsxprightside
        Me.right.Cursor = System.Windows.Forms.Cursors.SizeWE
        Me.right.Dock = System.Windows.Forms.DockStyle.Right
        Me.right.Location = New System.Drawing.Point(557, 0)
        Me.right.Name = "right"
        Me.right.Size = New System.Drawing.Size(4, 414)
        Me.right.TabIndex = 2
        '
        'left
        '
        Me.left.BackgroundImage = Global.Histacom.My.Resources.Resources.windowsxpleftside
        Me.left.Dock = System.Windows.Forms.DockStyle.Left
        Me.left.Location = New System.Drawing.Point(0, 0)
        Me.left.Name = "left"
        Me.left.Size = New System.Drawing.Size(4, 414)
        Me.left.TabIndex = 1
        '
        'templetevista
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(561, 414)
        Me.Controls.Add(Me.program)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "templetevista"
        Me.Text = "templetevista"
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.Color.Magenta
        Me.program.ResumeLayout(False)
        Me.top.ResumeLayout(False)
        Me.top.PerformLayout()
        CType(Me.maximizebutton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.minimizebutton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.closebutton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pullside As System.Windows.Forms.Timer
    Friend WithEvents pullbottom As System.Windows.Forms.Timer
    Friend WithEvents pullbs As System.Windows.Forms.Timer
    Friend WithEvents look As System.Windows.Forms.Timer
    Friend WithEvents program As System.Windows.Forms.Panel
    Friend WithEvents top As System.Windows.Forms.Panel
    Friend WithEvents maximizebutton As System.Windows.Forms.PictureBox
    Friend WithEvents minimizebutton As System.Windows.Forms.PictureBox
    Friend WithEvents programname As System.Windows.Forms.Label
    Friend WithEvents closebutton As System.Windows.Forms.PictureBox
    Friend WithEvents bottomleftcorner As System.Windows.Forms.Panel
    Friend WithEvents toprightcorner As System.Windows.Forms.Panel
    Friend WithEvents bottomrightcorner As System.Windows.Forms.Panel
    Friend WithEvents topleftcorner As System.Windows.Forms.Panel
    Friend WithEvents bottom As System.Windows.Forms.Panel
    Friend WithEvents right As System.Windows.Forms.Panel
    Friend WithEvents left As System.Windows.Forms.Panel
End Class
