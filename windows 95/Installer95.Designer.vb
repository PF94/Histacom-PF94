<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Installer95
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Installer95))
        Me.welcome = New System.Windows.Forms.Panel()
        Me.programimage = New System.Windows.Forms.Panel()
        Me.installimage = New System.Windows.Forms.PictureBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.installname = New System.Windows.Forms.Label()
        Me.licenseagreement = New System.Windows.Forms.Panel()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.summary = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.installerproccess = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Complete = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.finishinstallimage = New System.Windows.Forms.PictureBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.look = New System.Windows.Forms.Timer(Me.components)
        Me.pullbs = New System.Windows.Forms.Timer(Me.components)
        Me.pullbottom = New System.Windows.Forms.Timer(Me.components)
        Me.pullside = New System.Windows.Forms.Timer(Me.components)
        Me.program = New System.Windows.Forms.Panel()
        Me.programtopbar = New System.Windows.Forms.Panel()
        Me.maximizebutton = New System.Windows.Forms.PictureBox()
        Me.minimizebutton = New System.Windows.Forms.PictureBox()
        Me.programname = New System.Windows.Forms.Label()
        Me.closebutton = New System.Windows.Forms.PictureBox()
        Me.toprightcorner = New System.Windows.Forms.Panel()
        Me.bottomrightcorner = New System.Windows.Forms.Panel()
        Me.bottomleftcorner = New System.Windows.Forms.Panel()
        Me.topleftcorner = New System.Windows.Forms.Panel()
        Me.left = New System.Windows.Forms.Panel()
        Me.bottom = New System.Windows.Forms.Panel()
        Me.right = New System.Windows.Forms.Panel()
        Me.top = New System.Windows.Forms.Panel()
        Me.welcome.SuspendLayout()
        Me.programimage.SuspendLayout()
        CType(Me.installimage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.licenseagreement.SuspendLayout()
        Me.summary.SuspendLayout()
        Me.installerproccess.SuspendLayout()
        Me.Complete.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.finishinstallimage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.program.SuspendLayout()
        Me.programtopbar.SuspendLayout()
        CType(Me.maximizebutton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.minimizebutton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.closebutton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'welcome
        '
        Me.welcome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.welcome.Controls.Add(Me.programimage)
        Me.welcome.Controls.Add(Me.TextBox2)
        Me.welcome.Controls.Add(Me.Label3)
        Me.welcome.Controls.Add(Me.Label1)
        Me.welcome.Controls.Add(Me.Label2)
        Me.welcome.Controls.Add(Me.TextBox1)
        Me.welcome.Location = New System.Drawing.Point(8, 28)
        Me.welcome.Name = "welcome"
        Me.welcome.Size = New System.Drawing.Size(565, 342)
        Me.welcome.TabIndex = 14
        '
        'programimage
        '
        Me.programimage.Controls.Add(Me.installimage)
        Me.programimage.Location = New System.Drawing.Point(16, 7)
        Me.programimage.Name = "programimage"
        Me.programimage.Size = New System.Drawing.Size(167, 316)
        Me.programimage.TabIndex = 14
        '
        'installimage
        '
        Me.installimage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.installimage.Location = New System.Drawing.Point(0, 0)
        Me.installimage.Name = "installimage"
        Me.installimage.Size = New System.Drawing.Size(167, 316)
        Me.installimage.TabIndex = 0
        Me.installimage.TabStop = False
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.Silver
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Location = New System.Drawing.Point(209, 170)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(270, 65)
        Me.TextBox2.TabIndex = 9
        Me.TextBox2.Text = "Click Cancel to quit Setup and then close an programs you have running. Click Nex" & _
            "t to continue the Setup program."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(209, 298)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(249, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Click Next to continue installing Guess The Number"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(204, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(351, 25)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Welcome To Guess The Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(206, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(202, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "You are about to install guess the number"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Silver
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Location = New System.Drawing.Point(209, 112)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(262, 41)
        Me.TextBox1.TabIndex = 8
        Me.TextBox1.Text = "It is strongly recommended that you exit all Windows program before running this " & _
            "Setup program"
        '
        'installname
        '
        Me.installname.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.installname.AutoSize = True
        Me.installname.Location = New System.Drawing.Point(10, 400)
        Me.installname.Name = "installname"
        Me.installname.Size = New System.Drawing.Size(45, 13)
        Me.installname.TabIndex = 18
        Me.installname.Text = "Label18"
        '
        'licenseagreement
        '
        Me.licenseagreement.Controls.Add(Me.RadioButton2)
        Me.licenseagreement.Controls.Add(Me.RadioButton1)
        Me.licenseagreement.Controls.Add(Me.TextBox4)
        Me.licenseagreement.Controls.Add(Me.TextBox3)
        Me.licenseagreement.Controls.Add(Me.Label5)
        Me.licenseagreement.Controls.Add(Me.Label4)
        Me.licenseagreement.Location = New System.Drawing.Point(13, 31)
        Me.licenseagreement.Name = "licenseagreement"
        Me.licenseagreement.Size = New System.Drawing.Size(539, 342)
        Me.licenseagreement.TabIndex = 15
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(28, 288)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(276, 17)
        Me.RadioButton2.TabIndex = 5
        Me.RadioButton2.Text = "I do NOT Accept the terms of the License Agreement"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(28, 269)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(234, 17)
        Me.RadioButton1.TabIndex = 4
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "I accept the terms of the License Agreement"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.Color.Silver
        Me.TextBox4.Location = New System.Drawing.Point(28, 129)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox4.Size = New System.Drawing.Size(497, 133)
        Me.TextBox4.TabIndex = 3
        Me.TextBox4.Text = resources.GetString("TextBox4.Text")
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.Silver
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox3.Location = New System.Drawing.Point(28, 92)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(424, 39)
        Me.TextBox3.TabIndex = 2
        Me.TextBox3.Text = "Please read the following licence agreement, Use the scroll bar to view the rest " & _
            "of this agreement"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(41, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(216, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Terms and conditions for using this software."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(7, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(170, 14)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Software License Agreement"
        '
        'summary
        '
        Me.summary.Controls.Add(Me.Label11)
        Me.summary.Controls.Add(Me.Label10)
        Me.summary.Controls.Add(Me.Label9)
        Me.summary.Controls.Add(Me.Label8)
        Me.summary.Controls.Add(Me.Label7)
        Me.summary.Controls.Add(Me.Label6)
        Me.summary.Location = New System.Drawing.Point(19, 31)
        Me.summary.Name = "summary"
        Me.summary.Size = New System.Drawing.Size(533, 342)
        Me.summary.TabIndex = 16
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(75, 187)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(185, 13)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "C:\Program Files\ Guess The Number"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(35, 159)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(121, 13)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "to the following location:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(75, 114)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(99, 13)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Guess The Number"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(32, 91)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(230, 13)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Setup will now install the following components:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(40, 31)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(211, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Ready to start installing Guess The Number"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(17, 13)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 14)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Summary"
        '
        'installerproccess
        '
        Me.installerproccess.Controls.Add(Me.Label14)
        Me.installerproccess.Controls.Add(Me.ProgressBar1)
        Me.installerproccess.Controls.Add(Me.Label13)
        Me.installerproccess.Controls.Add(Me.Label12)
        Me.installerproccess.Location = New System.Drawing.Point(23, 33)
        Me.installerproccess.Name = "installerproccess"
        Me.installerproccess.Size = New System.Drawing.Size(521, 342)
        Me.installerproccess.TabIndex = 15
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(22, 207)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(187, 13)
        Me.Label14.TabIndex = 20
        Me.Label14.Text = "Currently Installing Guess The Number"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(22, 226)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(476, 23)
        Me.ProgressBar1.TabIndex = 19
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(40, 35)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(152, 13)
        Me.Label13.TabIndex = 18
        Me.Label13.Text = "Installing Guess The Number..."
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(19, 16)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(58, 15)
        Me.Label12.TabIndex = 17
        Me.Label12.Text = "Installing"
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.Location = New System.Drawing.Point(416, 391)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "Next >"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Location = New System.Drawing.Point(342, 391)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "< Back"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(504, 391)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Cancel"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Complete
        '
        Me.Complete.Controls.Add(Me.Panel1)
        Me.Complete.Controls.Add(Me.Label17)
        Me.Complete.Controls.Add(Me.Label16)
        Me.Complete.Controls.Add(Me.Label15)
        Me.Complete.Location = New System.Drawing.Point(15, 32)
        Me.Complete.Name = "Complete"
        Me.Complete.Size = New System.Drawing.Size(537, 342)
        Me.Complete.TabIndex = 17
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.finishinstallimage)
        Me.Panel1.Location = New System.Drawing.Point(27, 7)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(167, 316)
        Me.Panel1.TabIndex = 15
        '
        'finishinstallimage
        '
        Me.finishinstallimage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.finishinstallimage.Location = New System.Drawing.Point(0, 0)
        Me.finishinstallimage.Name = "finishinstallimage"
        Me.finishinstallimage.Size = New System.Drawing.Size(167, 316)
        Me.finishinstallimage.TabIndex = 0
        Me.finishinstallimage.TabStop = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(263, 307)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(167, 13)
        Me.Label17.TabIndex = 2
        Me.Label17.Text = "Click Finish to complete the Setup"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(263, 55)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(225, 13)
        Me.Label16.TabIndex = 1
        Me.Label16.Text = "Guess The Number was successfully installed."
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(259, 17)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(158, 24)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "Install Complete"
        '
        'Timer1
        '
        '
        'look
        '
        '
        'pullbs
        '
        Me.pullbs.Interval = 1
        '
        'pullbottom
        '
        Me.pullbottom.Interval = 1
        '
        'pullside
        '
        Me.pullside.Interval = 1
        '
        'program
        '
        Me.program.BackColor = System.Drawing.Color.Silver
        Me.program.Controls.Add(Me.programtopbar)
        Me.program.Controls.Add(Me.welcome)
        Me.program.Controls.Add(Me.installname)
        Me.program.Controls.Add(Me.licenseagreement)
        Me.program.Controls.Add(Me.summary)
        Me.program.Controls.Add(Me.installerproccess)
        Me.program.Controls.Add(Me.toprightcorner)
        Me.program.Controls.Add(Me.bottomrightcorner)
        Me.program.Controls.Add(Me.Button3)
        Me.program.Controls.Add(Me.Complete)
        Me.program.Controls.Add(Me.Button2)
        Me.program.Controls.Add(Me.bottomleftcorner)
        Me.program.Controls.Add(Me.topleftcorner)
        Me.program.Controls.Add(Me.Button1)
        Me.program.Controls.Add(Me.left)
        Me.program.Controls.Add(Me.bottom)
        Me.program.Controls.Add(Me.right)
        Me.program.Controls.Add(Me.top)
        Me.program.Dock = System.Windows.Forms.DockStyle.Fill
        Me.program.Location = New System.Drawing.Point(0, 0)
        Me.program.Name = "program"
        Me.program.Size = New System.Drawing.Size(590, 422)
        Me.program.TabIndex = 19
        '
        'programtopbar
        '
        Me.programtopbar.BackColor = System.Drawing.Color.DarkBlue
        Me.programtopbar.Controls.Add(Me.maximizebutton)
        Me.programtopbar.Controls.Add(Me.minimizebutton)
        Me.programtopbar.Controls.Add(Me.programname)
        Me.programtopbar.Controls.Add(Me.closebutton)
        Me.programtopbar.Dock = System.Windows.Forms.DockStyle.Top
        Me.programtopbar.Location = New System.Drawing.Point(4, 4)
        Me.programtopbar.Name = "programtopbar"
        Me.programtopbar.Size = New System.Drawing.Size(582, 18)
        Me.programtopbar.TabIndex = 0
        '
        'maximizebutton
        '
        Me.maximizebutton.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.maximizebutton.Image = Global.Histacom.My.Resources.Resources.Maximize
        Me.maximizebutton.Location = New System.Drawing.Point(548, 2)
        Me.maximizebutton.Name = "maximizebutton"
        Me.maximizebutton.Size = New System.Drawing.Size(16, 14)
        Me.maximizebutton.TabIndex = 6
        Me.maximizebutton.TabStop = False
        '
        'minimizebutton
        '
        Me.minimizebutton.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.minimizebutton.Image = Global.Histacom.My.Resources.Resources.minimize
        Me.minimizebutton.Location = New System.Drawing.Point(532, 2)
        Me.minimizebutton.Name = "minimizebutton"
        Me.minimizebutton.Size = New System.Drawing.Size(16, 14)
        Me.minimizebutton.TabIndex = 5
        Me.minimizebutton.TabStop = False
        '
        'programname
        '
        Me.programname.AutoSize = True
        Me.programname.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.programname.ForeColor = System.Drawing.Color.White
        Me.programname.Location = New System.Drawing.Point(3, 2)
        Me.programname.Name = "programname"
        Me.programname.Size = New System.Drawing.Size(107, 13)
        Me.programname.TabIndex = 3
        Me.programname.Text = "Windows Installer"
        '
        'closebutton
        '
        Me.closebutton.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.closebutton.Image = Global.Histacom.My.Resources.Resources.close
        Me.closebutton.Location = New System.Drawing.Point(565, 2)
        Me.closebutton.Name = "closebutton"
        Me.closebutton.Size = New System.Drawing.Size(16, 14)
        Me.closebutton.TabIndex = 4
        Me.closebutton.TabStop = False
        '
        'toprightcorner
        '
        Me.toprightcorner.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.toprightcorner.BackgroundImage = Global.Histacom.My.Resources.Resources.windows95toprightcorner
        Me.toprightcorner.Location = New System.Drawing.Point(586, 0)
        Me.toprightcorner.Name = "toprightcorner"
        Me.toprightcorner.Size = New System.Drawing.Size(4, 4)
        Me.toprightcorner.TabIndex = 6
        '
        'bottomrightcorner
        '
        Me.bottomrightcorner.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bottomrightcorner.BackgroundImage = Global.Histacom.My.Resources.Resources.windows95bottomrightcorner
        Me.bottomrightcorner.Cursor = System.Windows.Forms.Cursors.SizeNWSE
        Me.bottomrightcorner.Location = New System.Drawing.Point(586, 418)
        Me.bottomrightcorner.Name = "bottomrightcorner"
        Me.bottomrightcorner.Size = New System.Drawing.Size(4, 4)
        Me.bottomrightcorner.TabIndex = 4
        '
        'bottomleftcorner
        '
        Me.bottomleftcorner.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bottomleftcorner.BackgroundImage = Global.Histacom.My.Resources.Resources.windows95bottomleftcorner
        Me.bottomleftcorner.Location = New System.Drawing.Point(0, 418)
        Me.bottomleftcorner.Name = "bottomleftcorner"
        Me.bottomleftcorner.Size = New System.Drawing.Size(4, 4)
        Me.bottomleftcorner.TabIndex = 2
        '
        'topleftcorner
        '
        Me.topleftcorner.BackgroundImage = Global.Histacom.My.Resources.Resources.windows95topleftcorner
        Me.topleftcorner.Location = New System.Drawing.Point(0, 0)
        Me.topleftcorner.Name = "topleftcorner"
        Me.topleftcorner.Size = New System.Drawing.Size(4, 4)
        Me.topleftcorner.TabIndex = 1
        '
        'left
        '
        Me.left.BackgroundImage = Global.Histacom.My.Resources.Resources.windows95leftside
        Me.left.Dock = System.Windows.Forms.DockStyle.Left
        Me.left.Location = New System.Drawing.Point(0, 4)
        Me.left.Name = "left"
        Me.left.Size = New System.Drawing.Size(4, 414)
        Me.left.TabIndex = 3
        '
        'bottom
        '
        Me.bottom.BackgroundImage = Global.Histacom.My.Resources.Resources.windows95bottom
        Me.bottom.Cursor = System.Windows.Forms.Cursors.SizeNS
        Me.bottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.bottom.Location = New System.Drawing.Point(0, 418)
        Me.bottom.Name = "bottom"
        Me.bottom.Size = New System.Drawing.Size(586, 4)
        Me.bottom.TabIndex = 5
        '
        'right
        '
        Me.right.BackgroundImage = Global.Histacom.My.Resources.Resources.windows95rightside
        Me.right.Cursor = System.Windows.Forms.Cursors.SizeWE
        Me.right.Dock = System.Windows.Forms.DockStyle.Right
        Me.right.Location = New System.Drawing.Point(586, 4)
        Me.right.Name = "right"
        Me.right.Size = New System.Drawing.Size(4, 418)
        Me.right.TabIndex = 7
        '
        'top
        '
        Me.top.BackgroundImage = Global.Histacom.My.Resources.Resources.windows95top
        Me.top.Dock = System.Windows.Forms.DockStyle.Top
        Me.top.Location = New System.Drawing.Point(0, 0)
        Me.top.Name = "top"
        Me.top.Size = New System.Drawing.Size(590, 4)
        Me.top.TabIndex = 8
        '
        'Installer95
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(590, 422)
        Me.Controls.Add(Me.program)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Installer95"
        Me.Text = "Installer"
        Me.TopMost = True
        Me.welcome.ResumeLayout(False)
        Me.welcome.PerformLayout()
        Me.programimage.ResumeLayout(False)
        CType(Me.installimage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.licenseagreement.ResumeLayout(False)
        Me.licenseagreement.PerformLayout()
        Me.summary.ResumeLayout(False)
        Me.summary.PerformLayout()
        Me.installerproccess.ResumeLayout(False)
        Me.installerproccess.PerformLayout()
        Me.Complete.ResumeLayout(False)
        Me.Complete.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.finishinstallimage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.program.ResumeLayout(False)
        Me.program.PerformLayout()
        Me.programtopbar.ResumeLayout(False)
        Me.programtopbar.PerformLayout()
        CType(Me.maximizebutton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.minimizebutton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.closebutton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents welcome As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents installerproccess As System.Windows.Forms.Panel
    Friend WithEvents licenseagreement As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents summary As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Complete As System.Windows.Forms.Panel
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents installname As System.Windows.Forms.Label
    Friend WithEvents programimage As System.Windows.Forms.Panel
    Friend WithEvents installimage As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents finishinstallimage As System.Windows.Forms.PictureBox
    Friend WithEvents look As System.Windows.Forms.Timer
    Friend WithEvents pullbs As System.Windows.Forms.Timer
    Friend WithEvents pullbottom As System.Windows.Forms.Timer
    Friend WithEvents pullside As System.Windows.Forms.Timer
    Friend WithEvents program As System.Windows.Forms.Panel
    Friend WithEvents programtopbar As System.Windows.Forms.Panel
    Friend WithEvents maximizebutton As System.Windows.Forms.PictureBox
    Friend WithEvents minimizebutton As System.Windows.Forms.PictureBox
    Friend WithEvents programname As System.Windows.Forms.Label
    Friend WithEvents closebutton As System.Windows.Forms.PictureBox
    Friend WithEvents toprightcorner As System.Windows.Forms.Panel
    Friend WithEvents bottomrightcorner As System.Windows.Forms.Panel
    Friend WithEvents bottomleftcorner As System.Windows.Forms.Panel
    Friend WithEvents topleftcorner As System.Windows.Forms.Panel
    Friend WithEvents left As System.Windows.Forms.Panel
    Friend WithEvents bottom As System.Windows.Forms.Panel
    Friend WithEvents right As System.Windows.Forms.Panel
    Friend WithEvents top As System.Windows.Forms.Panel
End Class
