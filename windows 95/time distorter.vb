Public Class time_distorter
    Dim label6x As Integer
    Dim label6y As Integer
    Dim showcount As String
    Dim count As Integer

    Private Sub Timedistort_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        look.Start()
        Label7.Hide()
        count = 180
        Me.Location = New Point(300, 300)
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If count = -200 Then
            Windows98.Show()
            Me.Close()
        End If
        If count = -180 Then
            Label1.Hide()
            Label2.Hide()
            Label3.Hide()
            Label4.Hide()
            Label5.Hide()
            Label7.Hide()
            Label7.Hide()
        End If
        If count = -178 Then
            Label4.ForeColor = Color.Black
            Label5.ForeColor = Color.Black
        End If
        If count = -178 Then
            Label4.ForeColor = Color.Black
            Label5.ForeColor = Color.Black
        End If
        If count = -177 Then
            Label4.ForeColor = Color.White
            Label5.ForeColor = Color.White
        End If
        If count = -176 Then
            Label4.ForeColor = Color.Black
            Label5.ForeColor = Color.Black
        End If
        If count = -175 Then
            Label4.ForeColor = Color.Black
            Label5.ForeColor = Color.Black
        End If
        If count = -174 Then
            Label4.ForeColor = Color.Black
            Label1.Hide()
            Label5.ForeColor = Color.Black
        End If
        If count = -173 Then
            Label4.ForeColor = Color.White
            Label5.ForeColor = Color.White
        End If
        If count = -172 Then
            Label4.ForeColor = Color.Black
            Label5.ForeColor = Color.Black
        End If
        If count = -171 Then
            Label4.ForeColor = Color.Black
            Label5.ForeColor = Color.Black
        End If
        If count = -170 Then
            Label4.ForeColor = Color.Black
            Label5.ForeColor = Color.Black
        End If
        If count = -169 Then
            Label4.ForeColor = Color.White
            Label5.ForeColor = Color.White
            Label7.Hide()
        End If
        If count = -168 Then
            Label4.ForeColor = Color.Black
            Label5.ForeColor = Color.Black
        End If
        If count = -167 Then
            Label4.ForeColor = Color.Black
            Label5.ForeColor = Color.Black
        End If
        If count = -166 Then
            Label4.ForeColor = Color.Black
            Label5.ForeColor = Color.Black
        End If
        If count = -165 Then
            Label4.ForeColor = Color.White
            Label5.ForeColor = Color.White
        End If
        If count = -164 Then
            Label6.Hide()
            Label4.ForeColor = Color.Black
            Label5.ForeColor = Color.Black
        End If
        If count = -163 Then
            label6x = label6x + 10
            Label6.BackColor = Color.White
            Label6.Location = New Point(label6x, label6y)
        End If
        If count = -162 Then
            label6x = label6x + 10
            Label6.BackColor = Color.Gray
            Label6.Location = New Point(label6x, label6y)
        End If
        If count = -161 Then
            label6x = label6x + 10
            Label6.BackColor = Color.White
            Label6.Location = New Point(label6x, label6y)
        End If
        If count = -160 Then
            label6x = label6x + 10
            Label6.BackColor = Color.Gray
            Label6.Location = New Point(label6x, label6y)
        End If
        If count = -159 Then
            label6x = label6x + 10
            Label6.BackColor = Color.White
            Label6.Location = New Point(label6x, label6y)
        End If
        If count = -158 Then
            label6x = label6x + 10
            Label6.BackColor = Color.Gray
            Label6.Location = New Point(label6x, label6y)
        End If
        If count = -157 Then
            label6x = label6x + 10
            Label6.BackColor = Color.White
            Label6.Location = New Point(label6x, label6y)
        End If
        If count = -156 Then
            label6x = label6x + 10
            Label6.BackColor = Color.Gray
            Label6.Location = New Point(label6x, label6y)
        End If
        If count = -155 Then
            label6x = label6x + 10
            Label6.BackColor = Color.White
            Label6.Location = New Point(label6x, label6y)
        End If
        If count = -154 Then
            label6x = label6x + 10
            Label6.BackColor = Color.Gray
            Label6.Location = New Point(label6x, label6y)
        End If
        If count = -153 Then
            label6x = label6x + 10
            Label6.BackColor = Color.White
            Label6.Location = New Point(label6x, label6y)
        End If
        If count = -152 Then
            label6x = label6x + 10
            Label6.BackColor = Color.Gray
            Label6.Location = New Point(label6x, label6y)
        End If
        If count = -151 Then
            label6x = label6x + 10
            Label6.BackColor = Color.White
            Label6.Location = New Point(label6x, label6y)
        End If
        If count = -150 Then
            label6x = label6x + 10
            Label6.BackColor = Color.Gray
            Label6.Location = New Point(label6x, label6y)
        End If
        If count = -149 Then
            label6x = label6x + 10
            Label6.BackColor = Color.White
            Label6.Location = New Point(label6x, label6y)
        End If
        If count = -148 Then
            label6x = label6x + 10
            Label6.BackColor = Color.Gray
            Label6.Location = New Point(label6x, label6y)
        End If
        If count = -147 Then
            label6x = label6x + 10
            Label6.BackColor = Color.White
            Label6.Location = New Point(label6x, label6y)
        End If
        If count = -146 Then
            label6x = label6x + 10
            Label6.BackColor = Color.Gray
            Label6.Location = New Point(label6x, label6y)
        End If
        If count = -145 Then
            label6x = label6x + 10
            Label6.BackColor = Color.White
            Label6.Location = New Point(label6x, label6y)
        End If
        If count = -144 Then
            label6x = label6x + 10
            Label6.BackColor = Color.Gray
            Label6.Location = New Point(label6x, label6y)
        End If
        If count = -143 Then
            label6x = label6x + 10
            Label6.BackColor = Color.White
            Label6.Location = New Point(label6x, label6y)
        End If
        If count = -142 Then
            label6x = label6x + 10
            Label6.BackColor = Color.Gray
            Label6.Location = New Point(label6x, label6y)
        End If
        If count = -141 Then
            label6x = label6x + 10
            Label6.BackColor = Color.White
            Label6.Location = New Point(label6x, label6y)
        End If
        If count = -140 Then
            label6x = label6x + 10
            Label6.BackColor = Color.Gray
            Label6.Location = New Point(label6x, label6y)
        End If
        If count = -139 Then
            label6x = Label6.Location.X
            label6y = Label6.Location.Y
            Label6.Location = New Point(label6x, label6y)
            If My.Resources.windows95bootsound.CanRead Then
                Dim bStr(My.Resources.windows95bootsound.Length) As Byte
                My.Resources.windows95bootsound.Read(bStr, 0, My.Resources.windows95bootsound.Length)
                My.Computer.Audio.Play(bStr, AudioPlayMode.Background)
            End If
        End If
        If count = -138 Then
            Label2.ForeColor = Color.Black
            Label3.ForeColor = Color.Black
        End If
        If count = -137 Then
            Label2.ForeColor = Color.White
            Label3.ForeColor = Color.White
        End If
        If count = -136 Then
            Label2.ForeColor = Color.Black
            Label3.ForeColor = Color.Black
        End If
        If count = -135 Then
            Label2.ForeColor = Color.White
            Label3.ForeColor = Color.White
        End If
        If count = -134 Then
            Label2.ForeColor = Color.Black
            Label3.ForeColor = Color.Black
        End If
        If count = -133 Then
            Label2.ForeColor = Color.White
            Label3.ForeColor = Color.White
        End If
        If count = -132 Then
            Label2.ForeColor = Color.Black
            Label3.ForeColor = Color.Black
        End If
        If count = -131 Then
            Label2.ForeColor = Color.White
            Label3.ForeColor = Color.White
        End If
        If count = -130 Then
            Label2.ForeColor = Color.Black
            Label3.ForeColor = Color.Black
        End If
        If count = -116 Then
            programtopbar.BackColor = Color.White
            programtopbar.Hide()
            top.Hide()
            left.Hide()
            right.Hide()
            bottom.Hide()
            toprightcorner.Hide()
            topleftcorner.Hide()
            bottomrightcorner.Hide()
            bottomleftcorner.Hide()
        End If
        If count = -115 Then
            programtopbar.BackColor = Color.Black
        End If
        If count = -104 Then
            programtopbar.BackColor = Color.White
        End If
        If count = -113 Then
            programtopbar.BackColor = Color.Black
        End If
        If count = -112 Then
            programtopbar.BackColor = Color.White
        End If
        If count = -111 Then
            programtopbar.BackColor = Color.Black
        End If
        If count = -110 Then
            programtopbar.BackColor = Color.White
        End If
        If count = -109 Then
            programtopbar.BackColor = Color.Black
            programname.Hide()
        End If
        If count = -108 Then
            programtopbar.BackColor = Color.White
        End If
        If count = -107 Then
            programtopbar.BackColor = Color.Black
        End If
        If count = -106 Then
            programtopbar.BackColor = Color.White
        End If
        If count = -105 Then
            programtopbar.BackColor = Color.Black
        End If
        If count = -104 Then
            programtopbar.BackColor = Color.White
        End If
        If count = -103 Then
            programtopbar.BackColor = Color.Black
        End If
        If count = -102 Then
            programtopbar.BackColor = Color.White
        End If
        If count = -101 Then
            programtopbar.BackColor = Color.Black
        End If
        If count = -100 Then
            programtopbar.BackColor = Color.White
            minimizebutton.Hide()
        End If
        If count = -99 Then
            programtopbar.BackColor = Color.Black
        End If
        If count = -98 Then
            programtopbar.BackColor = Color.White
        End If
        If count = -97 Then
            programtopbar.BackColor = Color.Black
        End If
        If count = -96 Then
            programtopbar.BackColor = Color.White
        End If
        If count = -95 Then
            programtopbar.BackColor = Color.Black
        End If
        If count = -94 Then
            programtopbar.BackColor = Color.White
        End If
        If count = -93 Then
            programtopbar.BackColor = Color.Black
        End If
        If count = -92 Then
            programtopbar.BackColor = Color.White
        End If
        If count = -91 Then
            programtopbar.BackColor = Color.Black
        End If
        If count = -90 Then
            programtopbar.BackColor = Color.White
            maximizebutton.Hide()
        End If
        If count = -89 Then
            programtopbar.BackColor = Color.Black
        End If
        If count = -88 Then
            programtopbar.BackColor = Color.White
        End If
        If count = -87 Then
            programtopbar.BackColor = Color.Black
        End If
        If count = -86 Then
            programtopbar.BackColor = Color.White
        End If
        If count = -85 Then
            programtopbar.BackColor = Color.Black
        End If
        If count = -84 Then
            programtopbar.BackColor = Color.White
        End If
        If count = -83 Then
            programtopbar.BackColor = Color.Black
        End If
        If count = -82 Then
            programtopbar.BackColor = Color.White
        End If
        If count = -81 Then
            programtopbar.BackColor = Color.Black
        End If
        If count = -80 Then
            programtopbar.BackColor = Color.White
            closebutton.Hide()
        End If
        If count = -79 Then
            programtopbar.BackColor = Color.Black
        End If
        If count = -78 Then
            programtopbar.BackColor = Color.White
        End If
        If count = -77 Then
            programtopbar.BackColor = Color.Black
        End If
        If count = -76 Then
            programtopbar.BackColor = Color.White
        End If
        If count = -75 Then
            programtopbar.BackColor = Color.Black
        End If
        If count = -74 Then
            programtopbar.BackColor = Color.White
        End If
        If count = -73 Then
            programtopbar.BackColor = Color.Black
        End If
        If count = -72 Then
            programtopbar.BackColor = Color.White
        End If
        If count = -71 Then
            Label7.Text = "Traveling..."
            Button1.Hide()
        End If
        If count = -70 Then
            Label7.ForeColor = Color.White
        End If
        If count = -69 Then
            Label6.ForeColor = Color.White
        End If
        If count = -68 Then
            Label5.ForeColor = Color.White
        End If
        If count = -67 Then
            Label4.ForeColor = Color.White
        End If
        If count = -66 Then
            Label3.ForeColor = Color.White
        End If
        If count = -65 Then
            Label2.ForeColor = Color.White
        End If
        If count = -64 Then
            Label1.ForeColor = Color.White
        End If
        If count = -63 Then
            program.BackColor = Color.Black
        End If
        If count = -62 Then
            Windows95.BackColor = Color.White
            Windows95.Hide()
        End If
        If count = -61 Then
            Windows95.BackColor = Color.Black
            Me.WindowState = FormWindowState.Maximized
        End If
        If count = -60 Then
            Windows95.BackColor = Color.White
            Me.Location = New Point(330, 240)
        End If
        If count = -59 Then
            Windows95.BackColor = Color.Black
            Me.Location = New Point(295, 285)
        End If
        If count = -58 Then
            Windows95.BackColor = Color.White
            Me.Location = New Point(295, 300)
        End If
        If count = -57 Then
            Windows95.BackColor = Color.Black
            Me.Location = New Point(305, 300)
        End If
        If count = -56 Then
            Windows95.BackColor = Color.White
            Me.Location = New Point(300, 300)
        End If
        If count = -55 Then
            Windows95.BackColor = Color.Black
            Me.Location = New Point(295, 300)
        End If
        If count = -54 Then
            Windows95.BackColor = Color.White
            Me.Location = New Point(300, 300)
        End If
        If count = -52 Then
            Windows95.BackColor = Color.Black
            Me.Location = New Point(300, 295)
        End If
        If count = -51 Then
            Windows95.BackColor = Color.White
            Me.Location = New Point(300, 300)
        End If
        If count = -50 Then
            Windows95.BackColor = Color.Black
            Me.Location = New Point(300, 305)
        End If
        If count = -49 Then
            Windows95.BackColor = Color.White
        End If
        If count = -48 Then
            Windows95.BackColor = Color.Black
        End If
        If count = -47 Then
            Windows95.BackColor = Color.White
        End If
        If count = -46 Then
            Windows95.BackColor = Color.Black
        End If
        If count = -45 Then
            Windows95.BackColor = Color.White
        End If
        If count = -44 Then
            Windows95.BackColor = Color.Black
        End If
        If count = -43 Then
            Windows95.BackColor = Color.White
        End If
        If count = -42 Then
            Windows95.BackColor = Color.Black
        End If
        If count = -41 Then
            Windows95.BackColor = Color.White
        End If
        If count = -40 Then
            Windows95.BackColor = Color.Black
            Windows95.BackgroundImage = Nothing
        End If
        If count = -39 Then
            Windows95.desktopicons.Hide()
        End If
        If count = -38 Then
            Windows95.desktopicons.Show()
        End If
        If count = -37 Then
            Windows95.desktopicons.Hide()
        End If
        If count = -36 Then
            Windows95.desktopicons.Show()
        End If
        If count = -35 Then
            Windows95.desktopicons.Hide()
        End If
        If count = -34 Then
            Windows95.desktopicons.Show()
        End If
        If count = -33 Then
            Windows95.desktopicons.Hide()
        End If
        If count = -32 Then
            Windows95.desktopicons.Show()
        End If
        If count = -31 Then
            Windows95.desktopicons.Hide()
        End If
        If count = -30 Then
            Windows95.taskbar.Hide()
        End If
        If count = -29 Then
            Windows95.taskbar.BackColor = Color.White
        End If
        If count = -28 Then
            Windows95.taskbar.BackColor = Color.Black
        End If
        If count = -27 Then
            Windows95.taskbar.BackColor = Color.White
        End If
        If count = -26 Then
            Windows95.taskbar.BackColor = Color.Black
        End If
        If count = -25 Then
            Windows95.taskbar.BackColor = Color.White
        End If
        If count = -24 Then
            Windows95.taskbar.BackColor = Color.Black
        End If
        If count = -23 Then
            Windows95.taskbar.BackColor = Color.White
        End If
        If count = -22 Then
            Windows95.taskbar.BackColor = Color.Black
        End If
        If count = -21 Then
            Windows95.taskbar.BackColor = Color.White
        End If
        If count = -20 Then
            Windows95.taskbar.BackColor = Color.Black
        End If
        If count = -10 Then
            Command_prompt.Hide()
        End If
        If count = -9 Then
            Command_prompt.TextBox1.ForeColor = Color.Black
            Command_prompt.TextBox1.BackColor = Color.White
        End If
        If count = -8 Then
            Command_prompt.TextBox1.ForeColor = Color.White
            Command_prompt.TextBox1.BackColor = Color.Black
        End If
        If count = -7 Then
            Command_prompt.TextBox1.ForeColor = Color.Black
            Command_prompt.TextBox1.BackColor = Color.White
        End If
        If count = -6 Then
            Command_prompt.TextBox1.ForeColor = Color.White
            Command_prompt.TextBox1.BackColor = Color.Black
        End If
        If count = -5 Then
            Command_prompt.TextBox1.ForeColor = Color.Black
            Command_prompt.TextBox1.BackColor = Color.White
        End If
        If count = -4 Then
            Command_prompt.TextBox1.ForeColor = Color.White
            Command_prompt.TextBox1.BackColor = Color.Black
        End If
        If count = -3 Then
            Command_prompt.TextBox1.ForeColor = Color.Black
            Command_prompt.TextBox1.BackColor = Color.White
        End If
        If count = -2 Then
            Command_prompt.TextBox1.ForeColor = Color.White
            Command_prompt.TextBox1.BackColor = Color.Black
        End If
        If count = -1 Then
            Command_prompt.TextBox1.ForeColor = Color.Black
            Command_prompt.TextBox1.BackColor = Color.White
        End If
        If count = 0 Then
            look.Stop()
            showcount = "no"
            Label7.Text = "Initiating Time Travel Sequence..."
            Timer1.Interval = 100
        End If
        If count = 3 Then
            Command_prompt.TextBox1.Text = Command_prompt.TextBox1.Text + ("The Hidden Hacker: Good luck Windows 95 user... Ill see you in the future!" & Environment.NewLine)
        End If
        If count = 6 Then
            Command_prompt.TextBox1.Text = Command_prompt.TextBox1.Text + ("12padams Has been Disconnected..." & Environment.NewLine)
        End If
        If count = 7 Then
            Command_prompt.TextBox1.Text = Command_prompt.TextBox1.Text + ("Disconnect 12padams" & Environment.NewLine)
        End If
        If count = 10 Then
            Command_prompt.TextBox1.Text = Command_prompt.TextBox1.Text + ("The Hidden Hacker: Oh and heres one more command for you to learn" & Environment.NewLine)
        End If
        If count = 12 Then
            showcount = "yes"
            Label7.Show()

        End If
        If count = 13 Then
            Command_prompt.TextBox1.Text = Command_prompt.TextBox1.Text + ("Show Timer" & Environment.NewLine)
        End If
        If count = 15 Then
            Command_prompt.TextBox1.Text = Command_prompt.TextBox1.Text + ("The Hidden Hacker: Oh Is It? Well watch this!!" & Environment.NewLine)
        End If
        If count = 20 Then
            Command_prompt.TextBox1.Text = Command_prompt.TextBox1.Text + ("12padams: THATS IMPOSSIBLE" & Environment.NewLine)
        End If
        If count = 26 Then
            Command_prompt.TextBox1.Text = Command_prompt.TextBox1.Text + ("The Hidden Hacker: I converted the stop function to the hide function when i first logged on..." & Environment.NewLine)
        End If
        If count = 30 Then
            Command_prompt.TextBox1.Text = Command_prompt.TextBox1.Text + ("The Hidden Hacker: Oh but i did..." & Environment.NewLine)
        End If
        If count = 34 Then
            Command_prompt.TextBox1.Text = Command_prompt.TextBox1.Text + ("12padams: Bet You didn't see that one coming..." & Environment.NewLine)
        End If
        If count = 38 Then
            Me.Label7.Hide()
        End If
        If count = 39 Then
            Command_prompt.TextBox1.Text = Command_prompt.TextBox1.Text + ("Stop Timer" & Environment.NewLine)
            showcount = "no"
        End If
        If count = 41 Then
            Command_prompt.TextBox1.Text = Command_prompt.TextBox1.Text + ("12padams: OK NOW YOU HAVE DONE IT!!!!" & Environment.NewLine)
        End If
        If count = 44 Then
            Windows95.startbutton.Show()
        End If
        If count = 45 Then
            Command_prompt.TextBox1.Text = Command_prompt.TextBox1.Text + ("Show Start Button" & Environment.NewLine)
        End If
        If count = 47 Then
            Command_prompt.TextBox1.Text = Command_prompt.TextBox1.Text + ("The Hidden Hacker: Hey heres your start button back" & Environment.NewLine)
        End If
        If count = 51 Then
            Command_prompt.TextBox1.Text = Command_prompt.TextBox1.Text + ("The Hidden Hacker: Hey person who owns this computer don't worry your about to get away from all this..." & Environment.NewLine)
        End If
        If count = 56 Then
            Command_prompt.TextBox1.Text = Command_prompt.TextBox1.Text + ("12padams: Get out now or ill make you get out!!!!" & Environment.NewLine)
        End If
        If count = 62 Then
            Command_prompt.TextBox1.Text = Command_prompt.TextBox1.Text + ("The Hidden Hacker: Well Now that i have uncovered your secret... I'm not gunna just go away" & Environment.NewLine)
        End If
        If count = 67 Then
            Command_prompt.TextBox1.Text = Command_prompt.TextBox1.Text + ("12padams: The Hidden Hacker... I Though My first leason was enough to get you away" & Environment.NewLine)
        End If
        If count = 71 Then
            Command_prompt.TextBox1.Text = Command_prompt.TextBox1.Text + ("The Hidden Hacker: Good job for getting this software" & Environment.NewLine)
        End If
        If count = 75 Then
            Command_prompt.TextBox1.Text = Command_prompt.TextBox1.Text + ("The Hidden Hacker: but to the person who owns this computer..." & Environment.NewLine)
        End If
        If count = 78 Then
            Command_prompt.TextBox1.Text = Command_prompt.TextBox1.Text + ("The Hidden Hacker: Don't worry um... sorry i don't know your name" & Environment.NewLine)
        End If
        If count = 81 Then
            Command_prompt.TextBox1.Text = Command_prompt.TextBox1.Text + ("12padams: HOW DARE YOU INVADE" & Environment.NewLine)
        End If
        If count = 84 Then
            Command_prompt.TextBox1.Text = Command_prompt.TextBox1.Text + ("The Hidden Hacker: Great you found The software" & Environment.NewLine)
        End If
        If count = 86 Then
            Command_prompt.TextBox1.Text = Command_prompt.TextBox1.Text + ("The Hidden Hacker has connected" & Environment.NewLine)
        End If
        If count = 90 Then
            Command_prompt.TextBox1.Text = Command_prompt.TextBox1.Text + ("146.342.534.632 connecting" & Environment.NewLine)
        End If
        If count = 92 Then
            Command_prompt.TextBox1.Text = Command_prompt.TextBox1.Text + ("12padams: Ha Ha having a few errors are we?" & Environment.NewLine)
        End If
        If count = 95 Then
            Windows95.desktopicons.BackgroundImage = My.Resources.windows95error
        End If
        If count = 97 Then
            Command_prompt.TextBox1.Text = Command_prompt.TextBox1.Text + ("12padams: Now watch this" & Environment.NewLine)
        End If
        If count = 103 Then
            Command_prompt.TextBox1.Text = Command_prompt.TextBox1.Text + ("12padams: See how easy that was" & Environment.NewLine)
        End If
        If count = 106 Then
            Windows95.startbutton.Hide()
        End If
        If count = 108 Then
            Command_prompt.TextBox1.Text = Command_prompt.TextBox1.Text + ("Hide Start Button" & Environment.NewLine)
        End If
        If count = 112 Then
            Command_prompt.TextBox1.Text = Command_prompt.TextBox1.Text + ("12padams: Ok Let me show you how easy this is" & Environment.NewLine)
        End If
        If count = 117 Then
            Command_prompt.TextBox1.Text = Command_prompt.TextBox1.Text + ("12padams: You see I have LOTS of power over your computer" & Environment.NewLine)
        End If
        If count = 122 Then
            Command_prompt.TextBox1.Text = Command_prompt.TextBox1.Text + ("12padams: Well I am sorry but i just can't let you do that." & Environment.NewLine)
        End If
        If count = 127 Then
            Command_prompt.TextBox1.Text = Command_prompt.TextBox1.Text + ("12padams: Now In 2 minutes you think your going to be able to travel to 1999" & Environment.NewLine)
        End If
        If count = 132 Then
            Command_prompt.TextBox1.Text = Command_prompt.TextBox1.Text + ("12padams: To prove that I can see it look at your timer... It says 130 seconds left... " & Environment.NewLine)
        End If
        If count = 137 Then
            Command_prompt.TextBox1.Text = Command_prompt.TextBox1.Text + ("12padams: I can see your screen right now..." & Environment.NewLine)
        End If
        If count = 142 Then
            Command_prompt.TextBox1.Text = Command_prompt.TextBox1.Text + ("12padams: Oh and i know you pressed it" & Environment.NewLine)
        End If
        If count = 147 Then
            Command_prompt.TextBox1.Text = Command_prompt.TextBox1.Text + ("12padams: And download my secret time travel software..." & Environment.NewLine)
        End If
        If count = 151 Then
            Command_prompt.TextBox1.Text = Command_prompt.TextBox1.Text + ("12padams: Then use it to hack my website" & Environment.NewLine)
        End If
        If count = 154 Then
            Command_prompt.TextBox1.Text = Command_prompt.TextBox1.Text + ("12padams: And you download an attachment" & Environment.NewLine)
        End If
        If count = 157 Then
            Command_prompt.TextBox1.Text = Command_prompt.TextBox1.Text + ("12padams: Then you read them all..." & Environment.NewLine)
        End If
        If count = 161 Then
            Command_prompt.TextBox1.Text = Command_prompt.TextBox1.Text + ("12padams: You first hack my emails..." & Environment.NewLine)
        End If
        If count = 165 Then
            Command_prompt.TextBox1.Text = Command_prompt.TextBox1.Text + ("12padams: WHAT DO YOU THINK YOUR DOING!!!" & Environment.NewLine)
        End If
        If count = 168 Then
            Command_prompt.TextBox1.Text = Command_prompt.TextBox1.Text + ("12padams Connected" & Environment.NewLine)
        End If
        If count = 171 Then
            Command_prompt.TextBox1.Text = Command_prompt.TextBox1.Text + ("Ip 185.352.857.342 Connecting..." & Environment.NewLine)
        End If
        If count = 172 Then
            Command_prompt.Show()
        End If
        If Label1.Text = "                    ---------------  TIME DISTORTER ---------------" Then
            If showcount = "yes" Then
                Label7.Show()
                Label7.Text = "Preparing to travel...   ETA: " & count & " Seconds"
                count = count - 1
            End If
            If showcount = "no" Then
                count = count - 1
            End If
        End If
        If Label1.Text = "                  --------------#  TIME DISTORTER #--------------" Then
            showcount = "yes"
            Label1.Text = "                    ---------------  TIME DISTORTER ---------------"
        End If
        If Label1.Text = "                -------------##  TIME DISTORTER ##-------------" Then
            Label1.Text = "                  --------------#  TIME DISTORTER #--------------"
        End If
        If Label1.Text = "              ------------###  TIME DISTORTER ###------------" Then
            Label1.Text = "                -------------##  TIME DISTORTER ##-------------"
        End If
        If Label1.Text = "            -----------####  TIME DISTORTER ####-----------" Then
            Label1.Text = "              ------------###  TIME DISTORTER ###------------"
        End If
        If Label1.Text = "          ----------#####  TIME DISTORTER #####----------" Then
            Label1.Text = "            -----------####  TIME DISTORTER ####-----------"
        End If
        If Label1.Text = "         ---------######  TIME DISTORTER ######---------" Then
            Label1.Text = "          ----------#####  TIME DISTORTER #####----------"
        End If
        If Label1.Text = "        --------#######  TIME DISTORTER #######--------" Then
            Label1.Text = "         ---------######  TIME DISTORTER ######---------"
        End If
        If Label1.Text = "       -------########  TIME DISTORTER ########-------" Then
            Label1.Text = "        --------#######  TIME DISTORTER #######--------"
        End If
        If Label1.Text = "      ------#########  TIME DISTORTER #########------" Then
            Label1.Text = "       -------########  TIME DISTORTER ########-------"
        End If
        If Label1.Text = "     -----##########  TIME DISTORTER ##########-----" Then
            Label1.Text = "      ------#########  TIME DISTORTER #########------"
        End If
        If Label1.Text = "    ----###########  TIME DISTORTER ###########----" Then
            Label1.Text = "     -----##########  TIME DISTORTER ##########-----"
        End If
        If Label1.Text = "   ---############  TIME DISTORTER ############---" Then
            Label1.Text = "    ----###########  TIME DISTORTER ###########----"
        End If
        If Label1.Text = "  --#############  TIME DISTORTER #############--" Then
            Label1.Text = "   ---############  TIME DISTORTER ############---"
        End If
        If Label1.Text = " -##############  TIME DISTORTER ##############-" Then
            Label1.Text = "  --#############  TIME DISTORTER #############--"
        End If
        If Label1.Text = "###############  TIME DISTORTER ###############" Then
            Label1.Text = " -##############  TIME DISTORTER ##############-"
        End If
        Command_prompt.TextBox1.SelectionStart = 999999
        Command_prompt.TextBox1.ScrollToCaret()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Timer1.Start()
    End Sub
    Dim moveable As Boolean = True
    Dim mexlocation, meylocation As Integer
    Dim mewidth, meheight As Integer
    Dim maximize As Boolean

    Private Sub programtopbar_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles programtopbar.MouseDown
        If moveable = True Then
            If e.Button = MouseButtons.Left Then
                programtopbar.Capture = False
                Const WM_NCLBUTTONDOWN As Integer = &HA1S
                Const HTCAPTION As Integer = 2
                Dim msg As Message = _
                    Message.Create(Me.Handle, WM_NCLBUTTONDOWN, _
                        New IntPtr(HTCAPTION), IntPtr.Zero)
                Me.DefWndProc(msg)
            End If
        Else
        End If
    End Sub

    Private Sub closebutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles closebutton.Click

        Me.Close()
    End Sub

    Private Sub pullside_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pullside.Tick
        Me.Width = Cursor.Position.X - Me.Location.X
    End Sub

    Private Sub pullbottom_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pullbottom.Tick
        Me.Height = Cursor.Position.Y - Me.Location.Y
    End Sub

    Private Sub pullbs_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles pullbs.Tick
        Me.Width = Cursor.Position.X - Me.Location.X
        Me.Height = Cursor.Position.Y - Me.Location.Y
    End Sub

    Private Sub Rightpull_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles right.MouseDown
        pullside.Start()
    End Sub

    Private Sub rightpull_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles right.MouseUp
        pullside.Stop()
    End Sub

    Private Sub bottompull_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles bottom.MouseDown
        pullbottom.Start()
    End Sub

    Private Sub buttompull_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles bottom.MouseUp
        pullbottom.Stop()
    End Sub

    Private Sub bspull_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles bottomrightcorner.MouseDown
        pullbs.Start()
    End Sub

    Private Sub bspull_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles bottomrightcorner.MouseUp
        pullbs.Stop()
    End Sub

    Private Sub maximizebutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles maximizebutton.Click
        If maximize = False Then
            meylocation = Windows95.desktopicons.Height - Me.Height
            mexlocation = Windows95.desktopicons.Width - Me.Width
            mewidth = Me.Width
            meheight = Me.Height
            toprightcorner.Hide()
            topleftcorner.Hide()
            bottomrightcorner.Hide()
            bottomleftcorner.Hide()
            left.Hide()
            top.Hide()
            bottom.Hide()
            right.Hide()
            Dim w, h As Integer
            w = Windows95.desktopicons.Width
            h = Windows95.desktopicons.Height
            Me.Location = New Point(0, 0)
            Me.Size = New Size(w, h)
            moveable = False
            maximizebutton.Image = My.Resources.unmaximizebutton
            maximize = True
        Else
            toprightcorner.Show()
            topleftcorner.Show()
            bottomrightcorner.Show()
            bottomleftcorner.Show()
            left.Show()
            top.Show()
            bottom.Show()
            right.Show()
            Me.Location = New Point(mexlocation, meylocation)
            Me.Size = New Size(mewidth, meheight)
            moveable = True
            maximizebutton.Image = My.Resources.Maximize
            maximize = False
        End If
    End Sub

    Private Sub look_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles look.Tick
        Me.programtopbar.BackColor = Windows95.exampleprogramtopbar.BackColor
        Me.programtopbar.BackgroundImage = Windows95.exampleprogramtopbar.BackgroundImage
        Me.programname.BackColor = Windows95.exampleprogramtext.BackColor
    End Sub

    Private Sub minimizebutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles minimizebutton.Click
        Me.Hide()
    End Sub
End Class