Public Class Webchat1998
    Dim con As Integer
    Dim ran As New Random
    Dim abletoclose As String
    Dim correct As String
    Dim username As String
    Private Sub closebutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles closebutton.Click
        If abletoclose = "yes" Then
            Me.Close()
        End If
        If abletoclose = "no" Then

        End If
    End Sub

    Private Sub me_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        look.Start()
        Button3.Hide()
        Button4.Hide()
        Button5.Hide()
        Label5.Hide()
        abletoclose = "yes"
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        username = txtscreenname.Text
        login.Hide()
        Chat.Start()
        ListBox1.Items.Add(username)
        history.Text = history.Text + (username & " Has Logged On" & Environment.NewLine)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        history.Text = history.Text + (username & ": " & typechat.Text & Environment.NewLine)
        typechat.Text = ""
        typechat.Focus()
        history.SelectionStart = 999999
        history.ScrollToCaret()
    End Sub

    Private Sub Chat_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chat.Tick
        If con = 144 Then
            Title_Screen.Close()
        End If
        If con = 143 Then
            history.Text = (Environment.NewLine & "Game Over... You lose because you are using MS-DOS from the early 1980's and its 1998... Serriously what were you thinking??" & Environment.NewLine)
            Chat.Interval = 8000
            con = con + 1
        End If
        If con = 142 Then
            history.Text = history.Text + ("" & Environment.NewLine)
            history.Text = history.Text + ("" & Environment.NewLine)
            history.Text = history.Text + ("C:\>")
            Chat.Interval = 10000
            history.ReadOnly = False
            con = con + 1

        End If
        If con = 141 Then
            history.Text = "Starting MS-DOS..."
            Chat.Interval = 4000
            history.ReadOnly = True
            con = con + 1
        End If
        If con = 140 Then
            history.Text = ""
            Chat.Interval = 2000
            history.ReadOnly = True
            con = con + 1
        End If
        If con = 139 Then
            history.Text = history.Text + ("12padams: Oh last of all here is one hint... DOS IS USLESS... ITS JUST TEXT. NEXTTIME DON'T PIRATE SOFTWARE" & Environment.NewLine)
            Chat.Interval = 6000
            history.ReadOnly = False
            con = con + 1
        End If
        If con = 138 Then
            history.Text = history.Text + ("12padams: Ok see ya... You have learned two leasons today... 1. don't pirtae software,    2. you learnt about old operating systems." & Environment.NewLine)
            Chat.Interval = 10000
            history.ReadOnly = False
            con = con + 1
        End If
        If con = 137 Then
            history.ForeColor = Color.Silver
            Chat.Interval = 2000
            history.ReadOnly = False
            con = con + 1
        End If
        If con = 136 Then
            history.Text = history.Text + ("12padams: In DOS the computer had grey text not white text i just gotta modify it first." & Environment.NewLine)
            Chat.Interval = 4000
            history.ReadOnly = False
            con = con + 1
        End If
        If con = 135 Then
            history.Text = history.Text + ("12padams: Ok I just need to do one last setup for DOS" & Environment.NewLine)
            Chat.Interval = 4000
            history.ReadOnly = False
            con = con + 1
        End If
        If con = 133 Then
            history.Text = history.Text + ("12padams: Your computer now needs MS-DOS this will disconnect you from the convasation." & Environment.NewLine)
            Chat.Interval = 7000
            history.ReadOnly = False
            con = con + 2
        End If
        If con = 131 Then
            history.Text = history.Text + ("12padams: Hmm i am being to kind.... I think i gotta go now." & Environment.NewLine)
            Chat.Interval = 6000
            history.ReadOnly = False
            con = con + 2
        End If
        If con = 130 Then
            history.Text = history.Text + ("12padams: Ok there you go you can now type... Happy now?" & Environment.NewLine)
            Chat.Interval = 8000
            history.ReadOnly = False
            con = con + 1
        End If
        If con = 129 Then
            history.Text = history.Text + ("12padams: Lol for once i am giving you a feature..." & Environment.NewLine)
            Chat.Interval = 5000
            con = con + 1
        End If
        If con = 128 Then
            history.Text = history.Text + ("12padams: Ok Well lol woops you can't type... thats a big mistake!!!!" & Environment.NewLine)
            Chat.Interval = 5000
            con = con + 1
        End If
        If con = 127 Then
            history.Text = history.Text + ("12padams: Good now thats gone. I really gotta think for a little while at what to do next." & Environment.NewLine)
            Chat.Interval = 10000
            con = con + 1
        End If
        If con = 126 Then
            program.BorderStyle = BorderStyle.None
            history.BorderStyle = BorderStyle.None
            top.Hide()
            left.Hide()
            bottom.Hide()
            right.Hide()
            toprightcorner.Hide()
            topleftcorner.Hide()
            bottomrightcorner.Hide()
            bottomleftcorner.Hide()
            Chat.Interval = 3000
            con = con + 1
        End If
        If con = 125 Then
            history.Text = history.Text + ("12padams: Ok ill remove it now." & Environment.NewLine)
            Chat.Interval = 3000
            con = con + 1
        End If
        If con = 124 Then
            history.Text = history.Text + ("12padams: Oh and the the white border around your screen i can't forget to remove that..." & Environment.NewLine)
            Chat.Interval = 4000
            con = con + 1
        End If
        If con = 123 Then
            history.Text = history.Text + ("12padams: mouse removed..." & Environment.NewLine)
            Chat.Interval = 5000
            con = con + 1
            Cursor.Hide()
        End If
        If con = 122 Then
            history.Text = history.Text + ("12padams: 1" & Environment.NewLine)
            Chat.Interval = 1000
            con = con + 1
        End If
        If con = 121 Then
            history.Text = history.Text + ("12padams: 2" & Environment.NewLine)
            Chat.Interval = 1000
            con = con + 1
        End If
        If con = 120 Then
            history.Text = history.Text + ("12padams: 3 " & Environment.NewLine)
            Chat.Interval = 1000
            con = con + 1
        End If
        If con = 119 Then
            history.Text = history.Text + ("12padams: 4" & Environment.NewLine)
            Chat.Interval = 1000
            con = con + 1
        End If
        If con = 118 Then
            history.Text = history.Text + ("12padams: 5" & Environment.NewLine)
            Chat.Interval = 1000
            con = con + 1
        End If
        If con = 117 Then
            history.Text = history.Text + ("12padams: 6" & Environment.NewLine)
            Chat.Interval = 1000
            con = con + 1
        End If
        If con = 116 Then
            history.Text = history.Text + ("12padams: 7" & Environment.NewLine)
            Chat.Interval = 1000
            con = con + 1
        End If
        If con = 115 Then
            history.Text = history.Text + ("12padams: 8" & Environment.NewLine)
            Chat.Interval = 1000
            con = con + 1
        End If
        If con = 114 Then
            history.Text = history.Text + ("12padams: 9" & Environment.NewLine)
            Chat.Interval = 1000
            con = con + 1
        End If
        If con = 113 Then
            history.Text = history.Text + ("12padams: Ok removing in 10..." & Environment.NewLine)
            Chat.Interval = 1000
            con = con + 1
        End If
        If con = 112 Then
            history.Text = history.Text + ("12padams: Ok enjoy the mouse while you can because I am just about to remove it..." & Environment.NewLine)
            Chat.Interval = 5000
            con = con + 1
        End If
        If con = 111 Then
            history.Text = history.Text + ("12padams: How could i forget to remove then mouse..." & Environment.NewLine)
            Chat.Interval = 3000
            con = con + 1
        End If
        If con = 110 Then
            history.Text = history.Text + ("12padams: Ok this is imbarrissing... I forgot to remove something thats really noticable that didn't exist." & Environment.NewLine)
            Chat.Interval = 6000
            con = con + 1
        End If
        If con = 109 Then
            history.Text = history.Text + ("12padams: Hmm... I seem to be making quite a good theme... I really should add this to skindows..." & Environment.NewLine)
            Chat.Interval = 5000
            con = con + 1
        End If
        If con = 108 Then
            history.ScrollBars = ScrollBars.None
            Chat.Interval = 4000
            con = con + 1
        End If
        If con = 107 Then
            history.Text = history.Text + ("12padams: Ill just remove it now..." & Environment.NewLine)
            Chat.Interval = 2000
            con = con + 1
        End If
        If con = 106 Then
            history.Text = history.Text + ("12padams: I see the scroll bar at the side of the screen... that didn't exist early 1980's" & Environment.NewLine)
            Chat.Interval = 6000
            con = con + 1
        End If
        If con = 105 Then
            history.Text = history.Text + ("12padams: hmm theres still something missing..." & Environment.NewLine)
            Chat.Interval = 6000
            con = con + 1
        End If
        If con = 104 Then
            history.Text = history.Text + ("12padams: Wow your computers looking good... I should be a programmer since i did such a godo job..." & Environment.NewLine)
            Chat.Interval = 7000
            con = con + 1
        End If
        If con = 103 Then
            history.Dock = DockStyle.Fill
            Chat.Interval = 3000
            con = con + 1
        End If
        If con = 102 Then
            history.Text = history.Text + ("12padams: Hmm yes Thats whats missing I gotta make the text full screen..." & Environment.NewLine)
            Chat.Interval = 4000
            con = con + 1
        End If
        If con = 101 Then
            history.Text = history.Text + ("12padams: I Think I almost got your computer converted... early 1980's should be enough of a punishment..." & Environment.NewLine)
            Chat.Interval = 7000
            con = con + 1
        End If
        If con = 100 Then
            history.ForeColor = Color.White
            history.BackColor = Color.Black
            Chat.Interval = 6000
            con = con + 1
        End If
        If con = 99 Then
            Me.BackColor = Color.Black
            Chat.Interval = 5000
            con = con + 1
        End If
        If con = 98 Then
            history.Text = history.Text + ("12padams: Ok I hope Your not Scared Of the dark!" & Environment.NewLine)
            Chat.Interval = 5000
            con = con + 1
        End If
        If con = 97 Then
            history.Text = history.Text + ("12padams: Hmm ok this is gunna be tricky..." & Environment.NewLine)
            Chat.Interval = 5000
            con = con + 1
        End If
        If con = 96 Then
            history.Text = history.Text + ("12padams: Oh and we didn't have backgrounds... or even color for the matter..." & Environment.NewLine)
            Chat.Interval = 6000
            con = con + 1
        End If
        If con = 95 Then
            Chat.Interval = 3000
            con = con + 1
            Label6.Hide()
            Label1.Hide()
            Label7.Hide()
        End If
        If con = 94 Then
            history.Text = history.Text + ("12padams: First of all we didn't have labels... so ill remove labels now" & Environment.NewLine)
            Chat.Interval = 2000
            con = con + 1
        End If
        If con = 93 Then
            history.Text = history.Text + ("12padams: Well let me give you a little lesson on the history of computers..." & Environment.NewLine)
            Chat.Interval = 5000
            con = con + 1
        End If
        If con = 92 Then
            history.Text = history.Text + ("12padams: This is good now i can teach you and punish you at the same time lol :) " & Environment.NewLine)
            Chat.Interval = 6000
            con = con + 1
        End If
        If con = 91 Then
            history.Text = history.Text + ("12padams: Hey you must be new to computers... " & Environment.NewLine)
            Chat.Interval = 4000
            con = con + 1
        End If
        If con = 90 Then
            history.Text = history.Text + ("12padams: Hmm your new... Infact I have scanned your system and your using windwos 95 which you just got very recenty... " & Environment.NewLine)
            Chat.Interval = 10000
            con = con + 1
        End If
        If con = 89 Then
            history.Text = history.Text + ("12padams: Oh thats Right you dont even talk so your problably don't even know its gone... " & Environment.NewLine)
            Chat.Interval = 6000
            con = con + 1
        End If
        If con = 88 Then
            history.Text = history.Text + ("12padams: Lol your problably saying WHY CAN'T I TALK... " & Environment.NewLine)
            Chat.Interval = 4000
            typechat.Hide()
            Button2.Hide()
            con = con + 1
        End If
        If con = 87 Then
            history.Text = history.Text + ("12padams: Since you never talk i guess you won't be needing this..." & Environment.NewLine)
            Chat.Interval = 4000
            con = con + 1
        End If
        If con = 86 Then
            history.Text = history.Text + ("12padams: " & username & "? I don't remeber you... Oh right your the silent one... " & Environment.NewLine)
            Chat.Interval = 6000
            con = con + 1
        End If
        If con = 85 Then
            history.Text = history.Text + ("12padams: Now We are just left with... um wait who was it again..." & Environment.NewLine)
            Chat.Interval = 4000
            con = con + 1
        End If
        If con = 84 Then
            history.Text = history.Text + ("SkyHigh Has Logged Off" & Environment.NewLine)
            ListBox1.Items.Remove("SkyHigh")
            Chat.Interval = 5000
            con = con + 1
        End If
        If con = 83 Then
            history.Text = history.Text + ("12padams: Oh Don't you know how to? here ill do it for you..." & Environment.NewLine)
            Chat.Interval = 4000
            con = con + 1
        End If
        If con = 82 Then
            history.Text = history.Text + ("SkyHigh: But I can't!!!" & Environment.NewLine)
            Chat.Interval = 4000
            con = con + 1
        End If
        If con = 81 Then
            history.Text = history.Text + ("12padams: Stop? you both have been able to stop this the whole time... just turn off your computer..." & Environment.NewLine)
            Chat.Interval = 7000
            con = con + 1
        End If
        If con = 80 Then
            history.Text = history.Text + ("SkyHigh: Please Stop!!!" & Environment.NewLine)
            Chat.Interval = 8000
            con = con + 1
        End If
        If con = 79 Then
            history.Text = history.Text + ("12padams: Ok now that thats removed i Can deal with your punishments" & Environment.NewLine)
            Chat.Interval = 5000
            Panel1.Hide()
            con = con + 1
        End If
        If con = 78 Then
            history.Text = history.Text + ("12padams: No because i got rid of him... oh woops and talking about getting rid of things lol i forgot to remove the illegal file he uploaded which has been here all along..." & Environment.NewLine)
            Chat.Interval = 6000
            con = con + 1
        End If
        If con = 77 Then
            history.Text = history.Text + ("12padams: Exactly and rain49 uploaded the skindows and do you see him now?" & Environment.NewLine)
            Chat.Interval = 7000
            con = con + 1
        End If
        If con = 76 Then
            history.Text = history.Text + ("SkyHigh: I thought its only illegal to upload stuff..." & Environment.NewLine)
            Chat.Interval = 4000
            con = con + 1
        End If
        If con = 75 Then
            history.Text = history.Text + ("SkyHigh: Please Thats It!!! STOP. Me and " & username & " didn't accually do the uploading..." & Environment.NewLine)
            Chat.Interval = 9000
            con = con + 1
        End If
        If con = 74 Then
            history.Text = history.Text + ("SkyHigh: Damn IT!!! what are we supposed to do now " & username & "... he got rid of the top bar with the close button and maximize and all the..." & Environment.NewLine)
            Chat.Interval = 8000
            con = con + 1
        End If
        If con = 73 Then
            programtopbar.Hide()
            Chat.Interval = 3000
            con = con + 1
        End If
        If con = 72 Then
            history.Text = history.Text + ("12padams: What I have done everything...? What about this?" & Environment.NewLine)
            Chat.Interval = 3000
            con = con + 1
        End If
        If con = 71 Then
            history.Text = history.Text + ("SkyHigh: NOOOOOOO please this is enough you have done everything. I won't illegally download your software again" & Environment.NewLine)
            Chat.Interval = 6000
            con = con + 1
        End If
        If con = 70 Then
            Chat.Interval = 4000
            con = con + 1
            Windows95.Hide()
            Me.WindowState = FormWindowState.Maximized
        End If
        If con = 69 Then
            history.Text = history.Text + ("12padams: Well first I need your full attention..." & Environment.NewLine)
            Chat.Interval = 3000
            con = con + 1
            Dim FontName As String = "Arial"
            Dim FontSize As Integer = 11
            Dim FS As New Font(FontName, FontSize, FontStyle.Regular)
            history.Font = FS
        End If
        If con = 68 Then
            history.Text = history.Text + ("SkyHigh: Please Let Me and " & username & " go and just forget this happened!!!!" & Environment.NewLine)
            Chat.Interval = 6000
            con = con + 1
        End If
        If con = 67 Then
            history.Text = history.Text + ("12padams: You wanna Know how to Stop this?!!!!" & Environment.NewLine)
            Chat.Interval = 4000
            con = con + 1
        End If
        If con = 66 Then
            history.Text = history.Text + ("SkyHigh: Please Stop!!!!" & Environment.NewLine)
            Chat.Interval = 6000
            con = con + 1
        End If
        If con = 65 Then
            history.Text = history.Text + ("12padams: Oh yea and your icons are infected so you don't need them" & Environment.NewLine)
            Chat.Interval = 8000
            Windows95.desktopicons.Hide()
            con = con + 1
        End If
        If con = 64 Then
            history.Text = history.Text + ("12padams: Oh but you said to the remove viruses and your taskbar was infected... it had no start button" & Environment.NewLine)
            Chat.Interval = 7000
            con = con + 1
        End If
        If con = 63 Then
            history.Text = history.Text + ("SkyHigh: Hey What the hell give me back my taskbar!!!" & Environment.NewLine)
            Chat.Interval = 9000
            con = con + 1
        End If
        If con = 62 Then
            history.Text = history.Text + ("12padams: Hmm the taskbar was made by microsoft for windows 95...." & Environment.NewLine)
            Chat.Interval = 6000
            con = con + 1
            Windows95.taskbar.Hide()
        End If
        If con = 61 Then
            history.Text = history.Text + ("12padams: Hmm I see a Taskbar at the bottom of the screen..." & Environment.NewLine)
            Chat.Interval = 4000
            con = con + 1
        End If
        If con = 60 Then
            history.Text = history.Text + ("12padams: Well the whole of windows 95 is a virus so hmm where do we begin..." & Environment.NewLine)
            Chat.Interval = 5000
            con = con + 1
        End If
        If con = 59 Then
            history.Text = history.Text + ("12padams: Get Rid of the viruses did you say???" & Environment.NewLine)
            Chat.Interval = 6000
            con = con + 1
        End If
        If con = 58 Then
            history.Text = history.Text + ("SkyHigh: What the Hell??? just get rid of these viruses now!!!" & Environment.NewLine)
            Chat.Interval = 5000
            con = con + 1
        End If
        If con = 57 Then
            history.Text = history.Text + ("12padams: Anyway SkyHigh you are asking to many questions... Its time I unleash my next virus" & Environment.NewLine)
            Chat.Interval = 8000
            con = con + 1
        End If
        If con = 56 Then
            history.Text = history.Text + ("12padams: Well It causes your computer to have all its funtions disabled" & Environment.NewLine)
            Chat.Interval = 8000
            con = con + 1
        End If
        If con = 55 Then
            history.Text = history.Text + ("SkyHigh: Whats the virus do?" & Environment.NewLine)
            Chat.Interval = 6000
            con = con + 1
        End If
        If con = 54 Then
            history.Text = history.Text + ("12padams: Your both experienceing a lethal virus which i like to call (death)" & Environment.NewLine)
            Chat.Interval = 4000
            con = con + 1
        End If
        If con = 53 Then
            history.Text = history.Text + ("12padams: I told you that you were gunna be punished...." & Environment.NewLine)
            Chat.Interval = 8000
            con = con + 1
        End If
        If con = 52 Then
            history.Text = history.Text + ("SkyHigh: Hey what i can't open anything?" & Environment.NewLine)
            Chat.Interval = 5000
            con = con + 1
        End If
        If con = 51 Then
            history.Text = history.Text + ("SkyHigh: Don't worry " & username & " ill look online for help" & Environment.NewLine)
            Chat.Interval = 4000
            Windows95.Enabled = False
            con = con + 1
        End If
        If con = 50 Then
            history.Text = history.Text + ("12padams: Hey trying to fight back are we...? well ill punish you both!" & Environment.NewLine)
            Chat.Interval = 6000
            con = con + 1
        End If
        If con = 49 Then
            history.Text = history.Text + ("SkyHigh: Stop it!!! Let me and " & username & " go!" & Environment.NewLine)
            Chat.Interval = 3000
            con = con + 1
        End If
        If con = 48 Then
            history.Text = history.Text + ("12padams: Oh yea thats right... Now we had two left. We have SkyHigh and " & username & Environment.NewLine)
            Chat.Interval = 5000
            con = con + 1
        End If
        If con = 47 Then
            history.Text = history.Text + ("12padams: anyway... where were we?" & Environment.NewLine)
            Chat.Interval = 6000
            con = con + 1
        End If
        If con = 46 Then
            history.Text = history.Text + ("12padams: lol All your Computers are infected with a virus which makes them unable to boot." & Environment.NewLine)
            Chat.Interval = 6000
            con = con + 1
        End If
        If con = 45 Then
            history.Text = history.Text + ("rain49 Has Logged Out" & Environment.NewLine)
            ListBox1.Items.Remove("rain49")
            Chat.Interval = 7000
            con = con + 1
        End If
        If con = 44 Then
            history.Text = history.Text + ("rain49: Oh yea... just watch" & Environment.NewLine)
            Chat.Interval = 1000
            con = con + 1
        End If
        If con = 43 Then
            history.Text = history.Text + ("12padams: I would not do that if i were you..." & Environment.NewLine)
            Chat.Interval = 3000
            con = con + 1
        End If
        If con = 42 Then
            history.Text = history.Text + ("rain49: No... because i can just turn my computer off at the powerpoint... " & Environment.NewLine)
            Chat.Interval = 4000
            con = con + 1
        End If
        If con = 41 Then
            history.Text = history.Text + ("12padams: ... scared Yet?" & Environment.NewLine)
            Chat.Interval = 5000
            con = con + 1
        End If
        If con = 40 Then
            history.Text = history.Text + ("rain49: Omg 12padams disabled it..." & Environment.NewLine)
            Chat.Interval = 6000
            con = con + 1
        End If
        If con = 39 Then
            history.Text = history.Text + ("SkyHigh: What the Hell!!!! wheres my startbutton." & Environment.NewLine)
            Chat.Interval = 4000
            con = con + 1
        End If
        If con = 38 Then
            history.Text = history.Text + ("12padams: Ha Ha Ha... nobodys turning off their computer???" & Environment.NewLine)
            Chat.Interval = 3000
            con = con + 1
        End If
        If con = 37 Then
            history.Text = history.Text + ("12padams: Yea Guys I Will definatly unban you if you do that..." & Environment.NewLine)
            Chat.Interval = 5000
            con = con + 1
            Windows95.startbutton.Hide()
        End If
        If con = 36 Then
            history.Text = history.Text + ("rain49: Guys Quickly go to start and turn off your computer!!!" & Environment.NewLine)
            Chat.Interval = 5000
            con = con + 1
        End If
        If con = 35 Then
            history.Text = history.Text + ("12padams: Now that I Have you... We are gunna have a bit of fun..." & Environment.NewLine)
            Chat.Interval = 10000
            con = con + 1
        End If
        If con = 34 Then
            history.Text = history.Text + ("12padams: I Have Caught you!!!" & Environment.NewLine)
            Chat.Interval = 3000
            con = con + 1
        End If
        If con = 33 Then
            history.Text = history.Text + ("SkyHigh: I can't the x button is not working!!!!" & Environment.NewLine)
            Chat.Interval = 3000
            con = con + 1
        End If
        If con = 32 Then
            history.Text = history.Text + ("rain49: CRAP 12padams logged on... Quickly SkyHigh and " & username & " LOGOUT!!!" & Environment.NewLine)
            Chat.Interval = 4000
            con = con + 1

        End If
        If con = 31 Then
            history.Text = history.Text + ("12padams Has Logged On" & Environment.NewLine)
            ListBox1.Items.Add("12padams")
            Chat.Interval = 4000
            con = con + 1
            abletoclose = "no"
        End If
        If con = 30 Then
            history.Text = history.Text + ("SkyHigh: OMG THIS IS AWESOME.... I like the fire theme :0" & Environment.NewLine)
            Chat.Interval = 8000
            con = con + 1
        End If
        If con = 29 Then
            history.Text = history.Text + ("rain49: ok have fun then..." & Environment.NewLine)
            Chat.Interval = 8000
            con = con + 1
        End If
        If con = 28 Then
            history.Text = history.Text + ("SkyHigh: YAY! Download Finished... Ill install it now :)" & Environment.NewLine)
            Chat.Interval = 3000
            con = con + 1
        End If
        If con = 27 Then
            history.Text = history.Text + ("rain49: lol ok... hey " & username & " you can download it as well :)" & Environment.NewLine)
            Chat.Interval = 9000
            con = con + 1
        End If
        If con = 26 Then
            history.Text = history.Text + ("SkyHigh: Yay Thanks rain49!!! Ill download it now" & Environment.NewLine)
            Chat.Interval = 5000
            con = con + 1
        End If
        If con = 25 Then
            history.Text = history.Text + ("rain49: Its now added to the file sharing section at the bottom right of the screen" & Environment.NewLine)
            Chat.Interval = 4000
            Label5.Show()
            Button5.Show()
            con = con + 1
        End If
        If con = 24 Then
            history.Text = history.Text + ("rain49: Ok just wait a sec..." & Environment.NewLine)
            Chat.Interval = 7000
            con = con + 1
        End If
        If con = 23 Then
            history.Text = history.Text + ("SkyHigh: I think thats enough time... SEND IT NOW!!!!" & Environment.NewLine)
            Chat.Interval = 3000
            con = con + 1
        End If
        If con = 22 Then
            history.Text = history.Text + ("rain49: Wait ill just give " & username & " a few moments to quit this chat just incase..." & Environment.NewLine)
            Chat.Interval = 10000
            con = con + 1
        End If
        If con = 21 Then
            history.Text = history.Text + ("SkyHigh: Come on send it now..." & Environment.NewLine)
            Chat.Interval = 6000
            con = con + 1
        End If
        If con = 20 Then
            history.Text = history.Text + ("SkyHigh: Yea and rain 49 is gunna send it to us through Webchat :)" & Environment.NewLine)
            Chat.Interval = 3000
            con = con + 1
        End If
        If con = 19 Then
            history.Text = history.Text + ("rain49: Anyway on the 12padams site there is a really cool piece of software called skindows95" & Environment.NewLine)
            Chat.Interval = 5000
            con = con + 1
        End If
        If con = 18 Then
            history.Text = history.Text + ("rain49: If I were you i would log out right now... otherwise you will probably be banned" & Environment.NewLine)
            Chat.Interval = 7000
            con = con + 1
        End If
        If con = 17 Then
            history.Text = history.Text + ("rain49: Ok " & username & " we are going to be breaking the chat rules..." & Environment.NewLine)
            Chat.Interval = 8000
            con = con + 1
        End If
        If con = 16 Then
            history.Text = history.Text + ("rain49: Ill Have to tell " & username & " then..." & Environment.NewLine)
            Chat.Interval = 6000
            con = con + 1
        End If
        If con = 15 Then
            history.Text = history.Text + ("SkyHigh: Oh woops I forgot to to warn " & username & Environment.NewLine)
            Chat.Interval = 4000
            con = con + 1
        End If
        If con = 14 Then
            history.Text = history.Text + ("rain49: Oh ok... Does " & username & " know?" & Environment.NewLine)
            Chat.Interval = 4000
            con = con + 1
        End If
        If con = 13 Then
            history.Text = history.Text + ("SkyHigh: Oh " & username & " is just some new person who just logged on for the first time today" & Environment.NewLine)
            Chat.Interval = 6000
            con = con + 1
        End If
        If con = 12 Then
            history.Text = history.Text + ("rain49: Hey Who's " & username & Environment.NewLine)
            Chat.Interval = 7000
            con = con + 1
        End If
        If con = 11 Then
            history.Text = history.Text + ("rain49: lol... hi SkyHigh" & Environment.NewLine)
            Chat.Interval = 4000
            con = con + 1
        End If
        If con = 10 Then
            history.Text = history.Text + ("SkyHigh: rain49 is finally on :) !!!!!!" & Environment.NewLine)
            Chat.Interval = 4000
            con = con + 1
        End If
        If con = 9 Then
            history.Text = history.Text + ("SkyHigh: Yay" & Environment.NewLine)
            Chat.Interval = 3000
            con = con + 1
        End If
        If con = 8 Then
            history.Text = history.Text + ("rain49 Has Logged On" & Environment.NewLine)
            ListBox1.Items.Add("rain49")
            Chat.Interval = 4000
            con = con + 1
        End If
        If con = 7 Then
            If correct = "Yes" Then
                history.Text = history.Text + ("SkyHigh: Yay You got it :)" & Environment.NewLine)
                Button4.Hide()
                Button3.Hide()
                typechat.Show()
                con = con + 1
            End If
            If correct = "No" Then
                history.Text = history.Text + ("SkyHigh: Sorry My Name was Bill :(" & Environment.NewLine)
                Button4.Hide()
                Button3.Hide()
                typechat.Show()
                con = con + 1
            End If
        End If
        If con = 6 Then
            history.Text = history.Text + ("SkyHigh: Ill make 2 buttons appear at the bottom of your screen and you click to guess" & Environment.NewLine)
            Chat.Interval = 500
            con = con + 1
            Button3.Show()
            Button4.Show()
            typechat.Hide()
            Chat.Stop()
        End If
        If con = 5 Then
            history.Text = history.Text + ("SkyHigh: Ok Guess What my Name is" & Environment.NewLine)
            Chat.Interval = 3000
            con = con + 1
        End If
        If con = 4 Then
            history.Text = history.Text + ("SkyHigh: " & username & " We can play a game while we wait for rain49 to login" & Environment.NewLine)
            Chat.Interval = 4000
            con = con + 1
        End If
        If con = 3 Then
            history.Text = history.Text + ("SkyHigh: But wait!" & Environment.NewLine)
            Chat.Interval = 5000
            con = con + 1
        End If
        If con = 2 Then
            history.Text = history.Text + ("SkyHigh: Sorry I thought my friend rain49 was gunna be on..." & Environment.NewLine)
            Chat.Interval = 1000
            con = con + 1
        End If
        If con = 1 Then
            history.Text = history.Text + ("SkyHigh: Damn" & Environment.NewLine)
            Chat.Interval = 5000
            con = con + 1
        End If
        If con = 0 Then
            ListBox1.Items.Add("SkyHigh")
            history.Text = history.Text + ("SkyHigh Has Logged On" & Environment.NewLine)
            Chat.Interval = 5000
            con = con + 1
        End If
        history.Focus()
        history.SelectionStart = 999999
        history.ScrollToCaret()
        typechat.Focus()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        con = 7
        correct = "No"
        Chat.Start()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        con = 7
        correct = "Yes"
        Chat.Start()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim opendownload As New downloader95
        opendownload.Show()
        opendownload.Label2.Text = "Downloading: Skindows 95"
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