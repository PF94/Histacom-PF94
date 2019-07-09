<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Title_Screen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Title_Screen))
        Me.buttonnewgame = New System.Windows.Forms.PictureBox()
        Me.buttonloadgame = New System.Windows.Forms.PictureBox()
        Me.buttonexit = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.buttonnewgame, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.buttonloadgame, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.buttonexit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'buttonnewgame
        '
        Me.buttonnewgame.BackColor = System.Drawing.Color.Transparent
        Me.buttonnewgame.Image = Global.Histacom.My.Resources.Resources.new_game
        Me.buttonnewgame.Location = New System.Drawing.Point(44, 146)
        Me.buttonnewgame.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.buttonnewgame.Name = "buttonnewgame"
        Me.buttonnewgame.Size = New System.Drawing.Size(208, 139)
        Me.buttonnewgame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.buttonnewgame.TabIndex = 0
        Me.buttonnewgame.TabStop = False
        '
        'buttonloadgame
        '
        Me.buttonloadgame.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.buttonloadgame.BackColor = System.Drawing.Color.Transparent
        Me.buttonloadgame.Image = Global.Histacom.My.Resources.Resources.load_game
        Me.buttonloadgame.Location = New System.Drawing.Point(413, 146)
        Me.buttonloadgame.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.buttonloadgame.Name = "buttonloadgame"
        Me.buttonloadgame.Size = New System.Drawing.Size(208, 139)
        Me.buttonloadgame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.buttonloadgame.TabIndex = 1
        Me.buttonloadgame.TabStop = False
        '
        'buttonexit
        '
        Me.buttonexit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonexit.BackColor = System.Drawing.Color.Transparent
        Me.buttonexit.Image = Global.Histacom.My.Resources.Resources._exit
        Me.buttonexit.Location = New System.Drawing.Point(803, 146)
        Me.buttonexit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.buttonexit.Name = "buttonexit"
        Me.buttonexit.Size = New System.Drawing.Size(208, 139)
        Me.buttonexit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.buttonexit.TabIndex = 2
        Me.buttonexit.TabStop = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(16, 668)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(211, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Time Hack 1.9 by benpowerman"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(413, 525)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "about"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Title_Screen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Histacom.My.Resources.Resources.Histacom_1_8_Background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1045, 692)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.buttonexit)
        Me.Controls.Add(Me.buttonloadgame)
        Me.Controls.Add(Me.buttonnewgame)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Title_Screen"
        Me.Text = "Histacom 1.8"
        Me.TransparencyKey = System.Drawing.Color.Magenta
        CType(Me.buttonnewgame, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.buttonloadgame, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.buttonexit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents buttonnewgame As System.Windows.Forms.PictureBox
    Friend WithEvents buttonloadgame As System.Windows.Forms.PictureBox
    Friend WithEvents buttonexit As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
