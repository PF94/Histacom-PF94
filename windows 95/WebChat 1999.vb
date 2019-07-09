Public Class WebChat_1999
    Dim waiting As Boolean
    Dim waiting2 As Boolean = False
    Dim con As Integer
    Dim ran As New Random
    Dim abletoclose As String = "yes"
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
        If waiting = True Then
            mainname = typechat.Text
            waiting = False
            history.Text = history.Text + (username & ": " & typechat.Text & Environment.NewLine)
            typechat.Text = ""
            history.Focus()
            history.SelectionStart = 999999
            history.ScrollToCaret()
            typechat.Focus()
        Else
            history.Text = history.Text + (username & ": " & typechat.Text & Environment.NewLine)
            typechat.Text = ""
            typechat.Focus()
            history.SelectionStart = 999999
            history.ScrollToCaret()
        End If
        
    End Sub

    Private Sub Chat_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chat.Tick

        If con = 67 Then
            If waitfor02download = True Then
                Chat.Stop()
            Else
                Chat.Start()
                history.Text = history.Text + ("12padams: Ok I got a message that you just started the timer " & mainname & Environment.NewLine)
                con = con + 1
            End If
        End If
        If con = 66 Then
            history.Text = history.Text + ("The Hidden Hacker: I Hope this works..." & Environment.NewLine)
            Chat.Interval = 3000
            con = con + 1
            count.Start()
            waitfor02download = True
            Chat.Stop()
        End If
        If con = 65 Then
            history.Text = history.Text + ("12padams: Ok " & mainname & " download it now and we will wait for you" & Environment.NewLine)
            Chat.Interval = 4000
            con = con + 1
        End If
        If con = 64 Then
            Label5.Show()
            Button5.Show()
            con = con + 1
        End If
        If con = 63 Then
            history.Text = history.Text + ("12padams: We will start right now. Ill send 0.2 of time distorter and " & mainname & " can download it" & Environment.NewLine)
            Chat.Interval = 4000
            con = con + 1
        End If
        If con = 62 Then
            history.Text = history.Text + ("The Hidden Hacker: Ok then when do we start?" & Environment.NewLine)
            Chat.Interval = 6000
            con = con + 1
        End If
        If con = 61 Then
            history.Text = history.Text + ("12padams: Nothings going to go wrong I think i Got this" & Environment.NewLine)
            Chat.Interval = 4000
            con = con + 1
        End If
        If con = 60 Then
            history.Text = history.Text + ("The Hidden Hacker: But what If something goes wrong and " & mainname & " doesn't get to the year 2000 properly?" & Environment.NewLine)
            Chat.Interval = 5000
            con = con + 1
        End If
        If con = 59 Then
            history.Text = history.Text + ("12padams: Ok I want you to look out for " & mainname & " so that in 1 year you can tell me when he comes back" & Environment.NewLine)
            Chat.Interval = 7000
            con = con + 1
        End If
        If con = 58 Then
            history.Text = history.Text + ("The Hidden Hacker: Ok but what do you want me to do?" & Environment.NewLine)
            Chat.Interval = 6000
            con = con + 1
        End If
        If con = 57 Then
            history.Text = history.Text + ("12padams: But It has to be done... you need to help me, guys... please" & Environment.NewLine)
            Chat.Interval = 4000
            con = con + 1
        End If
        If con = 56 Then
            history.Text = history.Text + ("The Hidden Hacker: 12padams thats too risky" & Environment.NewLine)
            Chat.Interval = 5000
            con = con + 1
        End If
        If con = 55 Then
            history.Text = history.Text + ("12padams: This could serriously impact my time travel software." & Environment.NewLine)
            Chat.Interval = 3000
            con = con + 1
        End If
        If con = 54 Then
            history.Text = history.Text + ("12padams: Computer dates may stuff up and display 1900 instead of 2000" & Environment.NewLine)
            Chat.Interval = 5000
            con = con + 1
        End If
        If con = 53 Then
            history.Text = history.Text + ("12padams: Well basically I wrote an article on the year 2000 bug AKA y2k" & Environment.NewLine)
            Chat.Interval = 4000
            con = con + 1
        End If
        If con = 52 Then
            history.Text = history.Text + ("12padams: haha sorry I forgot about that" & Environment.NewLine)
            Chat.Interval = 4000
            con = con + 1
        End If
        If con = 51 Then
            history.Text = history.Text + ("The Hidden Hacker: no since I am blocked from using your website" & Environment.NewLine)
            Chat.Interval = 3000
            con = con + 1
        End If
        If con = 50 Then
            history.Text = history.Text + ("12padams: no... Its not accually. Didn't you read the article on my website?" & Environment.NewLine)
            Chat.Interval = 4000
            con = con + 1
        End If
        If con = 49 Then
            history.Text = history.Text + ("The Hidden Hacker: Why does he need to try it out??? its gunna work just like 0.1 did" & Environment.NewLine)
            Chat.Interval = 5000
            con = con + 1
        End If
        If con = 48 Then
            history.Text = history.Text + ("12padams: " & mainname & "... I will need you to try this out again" & Environment.NewLine)
            Chat.Interval = 5000
            con = con + 1
        End If
        If con = 47 Then
            history.Text = history.Text + ("12padams: well not much different... it works the same except it works in all time periods and it takes you to 2000" & Environment.NewLine)
            Chat.Interval = 4000
            con = con + 1
        End If
        If con = 46 Then
            history.Text = history.Text + ("12padams: 0.2 is much different however" & Environment.NewLine)
            Chat.Interval = 5000
            con = con + 1
        End If
        If con = 45 Then
            history.Text = history.Text + ("12padams: Well anyway... 0.1 is now useless since it only works if the year is 1998 and it will only take you to 1999" & Environment.NewLine)
            Chat.Interval = 7000
            con = con + 1
        End If
        If con = 44 Then
            history.Text = history.Text + ("12padams: oh woops yea oh cause you would" & Environment.NewLine)
            Chat.Interval = 8000
            con = con + 1
        End If
        If con = 43 Then
            history.Text = history.Text + ("The Hidden Hacker: Of cause I remember that..." & Environment.NewLine)
            Chat.Interval = 3000
            con = con + 1
        End If
        If con = 42 Then
            history.Text = history.Text + ("12padams: Remember time distorter 0.1?" & Environment.NewLine)
            Chat.Interval = 3000
            con = con + 1
        End If
        If con = 41 Then
            history.Text = history.Text + ("12padams: Oh right I forgot to tell you both" & Environment.NewLine)
            Chat.Interval = 4000
            con = con + 1
        End If
        If con = 40 Then
            history.Text = history.Text + ("The Hidden Hacker: Wait A sec... you mean we are going to time travel again?" & Environment.NewLine)
            Chat.Interval = 5000
            con = con + 1
        End If
        If con = 39 Then
            history.Text = history.Text + ("12padams: Ok I know... you can track the time travels so you can see when " & mainname & " gets to a new time period you say whats going on..." & Environment.NewLine)
            Chat.Interval = 6000
            con = con + 1
        End If
        If con = 38 Then
            history.Text = history.Text + ("12padams: I am not really sure accually... um let me think" & Environment.NewLine)
            Chat.Interval = 5000
            con = con + 1
        End If
        If con = 37 Then
            history.Text = history.Text + ("The Hidden Hacker: Um what do you mean by guider?" & Environment.NewLine)
            Chat.Interval = 4000
            con = con + 1
        End If
        If con = 36 Then
            history.Text = history.Text + ("12padams: And The Hidden Hacker... you can be the um... Guider" & Environment.NewLine)
            Chat.Interval = 3000
            con = con + 1
        End If
        If con = 35 Then
            history.Text = history.Text + ("12padams: " & mainname & " you can be the tester for my time travel software" & Environment.NewLine)
            Chat.Interval = 4000
            con = con + 1
        End If
        If con = 34 Then
            history.Text = history.Text + ("12padams: Well I am the coder who will be working on the time travel software" & Environment.NewLine)
            Chat.Interval = 7000
            con = con + 1
        End If
        If con = 33 Then
            history.Text = history.Text + ("The Hidden Hacker: Wait what do you mean by 'a team'" & Environment.NewLine)
            Chat.Interval = 5000
            con = con + 1
        End If
        If con = 32 Then
            history.Text = history.Text + ("12padams: Look Since you both know about this whole time travel thing... I want us to be a team " & Environment.NewLine)
            Chat.Interval = 5000
            con = con + 1
        End If
        If con = 31 Then
            history.Text = history.Text + ("12padams: Well anyway I have something very important I now have to say to you both " & Environment.NewLine)
            Chat.Interval = 6000
            con = con + 1
        End If
        If con = 30 Then
            history.Text = history.Text + ("The Hidden Hacker: Lol its good you now have a name " & mainname & Environment.NewLine)
            Chat.Interval = 6000
            con = con + 1
        End If
        If con = 29 Then
            history.Text = history.Text + ("12padams: Ok from now on we will call you " & mainname & Environment.NewLine)
            Chat.Interval = 4000
            con = con + 1
        End If

        If con = 28 Then
            If mainname = "" Then
                Chat.Interval = 3000
            Else
                Chat.Interval = 3000
                con = con + 1
            End If
        End If
        If con = 27 Then
            history.Text = history.Text + ("12padams: Um whats your name 'windows 98 user' just type it in the chat now. I recommend less then 10 letters" & Environment.NewLine)
            Chat.Interval = 6000
            waiting = True
            con = con + 1
        End If
        If con = 26 Then
            history.Text = history.Text + ("12padams: Ok just to let you know... the only thing thats getting me 'angrey' right now is not knowing what this windows 98 users name is " & Environment.NewLine)
            Chat.Interval = 9000
            con = con + 1
        End If
        If con = 25 Then
            history.Text = history.Text + ("The Hidden Hacker: Well thats a relief... um whatever your name is... " & Environment.NewLine)
            Chat.Interval = 7000
            con = con + 1
        End If
        If con = 24 Then
            history.Text = history.Text + ("12padams: So I just wanna say thanks :) both of you... " & Environment.NewLine)
            Chat.Interval = 5000
            con = con + 1
        End If
        If con = 23 Then
            history.Text = history.Text + ("12padams: Liston... If you had not hacked my emails and taken my software and tried it out I would never have tested my software. " & Environment.NewLine)
            Chat.Interval = 9000
            con = con + 1
        End If
        If con = 22 Then
            history.Text = history.Text + ("12padams: Yea I'm not angrey at any of you..." & Environment.NewLine)
            Chat.Interval = 6000
            con = con + 1
        End If
        If con = 21 Then
            history.Text = history.Text + ("The Hidden Hacker: What???" & Environment.NewLine)
            Chat.Interval = 4000
            con = con + 1
        End If
        If con = 20 Then
            history.Text = history.Text + ("12padams: Oh for goodness sake what's wrong with you 2... I am not angrey" & Environment.NewLine)
            Chat.Interval = 4000
            con = con + 1
        End If
        If con = 19 Then
            history.Text = history.Text + ("The Hidden Hacker: Crap the close button is not working!!!" & Environment.NewLine)
            Chat.Interval = 6000
            con = con + 1
        End If
        If con = 18 Then
            history.Text = history.Text + ("12padams: Come on guys..." & Environment.NewLine)
            Chat.Interval = 5000
            con = con + 1
        End If
        If con = 17 Then
            history.Text = history.Text + ("The Hidden Hacker: Log off... um whatever your name is wh owns that windows 98 computer!!!!" & Environment.NewLine)
            Chat.Interval = 5000
            con = con + 1
        End If
        If con = 16 Then
            history.Text = history.Text + ("The Hidden Hacker: Oh CRAP!!!" & Environment.NewLine)
            Chat.Interval = 5000
            con = con + 1
        End If
        If con = 15 Then
            history.Text = history.Text + ("12padams: Yea and you have not done a good job of hidding" & Environment.NewLine)
            Chat.Interval = 4000
            con = con + 1
        End If
        If con = 14 Then
            history.Text = history.Text + ("12padams Has Logged On" & Environment.NewLine)
            Chat.Interval = 2000
            con = con + 1
            abletoclose = "no"
        End If
        If con = 13 Then
            history.Text = history.Text + ("The Hidden Hacker: since then I have been hiding so 12padams could not get me" & Environment.NewLine)
            Chat.Interval = 4000
            con = con + 1
        End If
        If con = 12 Then
            history.Text = history.Text + ("The Hidden Hacker: after you left 1998 12padams tried to attack and well..." & Environment.NewLine)
            Chat.Interval = 7000
            con = con + 1
        End If
        If con = 11 Then
            history.Text = history.Text + ("The Hidden Hacker: Ok well heres what happened while you were gone." & Environment.NewLine)
            Chat.Interval = 5000
            con = con + 1
        End If
        If con = 10 Then
            history.Text = history.Text + ("The Hidden Hacker: Finally your here." & Environment.NewLine)
            Chat.Interval = 5000
            con = con + 1
        End If
        If con = 9 Then
            history.Text = history.Text + ("The Hidden Hacker: For 1 whole year I have been waiting to see if that time travel software worked" & Environment.NewLine)
            Chat.Interval = 4000
            con = con + 1
        End If
        If con = 8 Then
            history.Text = history.Text + ("[The Known Checker] has changed his display name to [The Hidden Hacker]" & Environment.NewLine)
            ListBox1.Items.Remove("The Known Checker")
            ListBox1.Items.Add("The Hidden Hacker")
            Chat.Interval = 6000
            con = con + 1
        End If
        If con = 7 Then
            history.Text = history.Text + ("The Known Checker: Wait sorry i am using a fake name... Just wait a sec" & Environment.NewLine)
            Chat.Interval = 5000
            con = con + 1
        End If
        If con = 6 Then
            history.Text = history.Text + ("The Known Checker: Yes!!! Its YOU!!!!!" & Environment.NewLine)
            Chat.Interval = 3000
            con = con + 1
        End If
        If con = 5 Then
            history.Text = history.Text + ("Scan Complete!" & Environment.NewLine)
            Chat.Interval = 4000
            con = con + 1
        End If
        If con = 4 Then
            history.Text = history.Text + ("The Known Checker is: Scanning IP..." & Environment.NewLine)
            Chat.Interval = 3000
            con = con + 1
        End If
        If con = 3 Then
            history.Text = history.Text + ("The Known Checker: Wait I'll quickly do an ip scan..." & Environment.NewLine)
            Chat.Interval = 5000
            con = con + 1
        End If
        If con = 2 Then
            history.Text = history.Text + ("The Known Checker: Hi um I know this is going to sound weird but do you know about some software called time distorter?" & Environment.NewLine)
            Chat.Interval = 8000
            con = con + 1
        End If
        If con = 1 Then
            history.Text = history.Text + ("The Known Checker: OMG I think I found you!!!" & Environment.NewLine)
            Chat.Interval = 5000
            con = con + 1
        End If
        If con = 0 Then
            ListBox1.Items.Add("The Known Checker")
            Chat.Interval = 5000
            con = con + 1
        End If
        history.Focus()
        history.SelectionStart = 999999
        history.ScrollToCaret()
        typechat.Focus()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim opendownload As New Downloader98
        opendownload.Show()
        opendownload.Label2.Text = "Downloading: Time Distorter 0.2"
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

    End Sub

    Private Sub waitingdownload_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles waitingdownload.Tick
        If waitfor02download = False Then
            Chat.Start()
            waitingdownload.Stop()
        End If

    End Sub

    Private Sub count_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles count.Tick
        If count2000 = -8 Then
            Me.BackColor = Color.Black
            history.BackColor = Color.Black
            history.ForeColor = Color.White
            Me.Close()
            count.Stop()
        End If
        If count2000 = -7 Then
            Me.BackColor = Color.Black
            history.BackColor = Color.White
            history.ForeColor = Color.Black
        End If
        If count2000 = -6 Then
            Me.BackColor = Color.Black
            history.BackColor = Color.Black
            history.ForeColor = Color.White
        End If
        If count2000 = -5 Then
            Me.BackColor = Color.Black
            history.BackColor = Color.White
            history.ForeColor = Color.Black
        End If
        If count2000 = -4 Then
            Me.BackColor = Color.Black
            history.BackColor = Color.Black
            history.ForeColor = Color.White
        End If
        If count2000 = -3 Then
            Me.BackColor = Color.Black
            history.BackColor = Color.White
            history.ForeColor = Color.Black
        End If
        If count2000 = -2 Then
            Me.BackColor = Color.Black
            history.BackColor = Color.Black
            history.ForeColor = Color.White
        End If
        If count2000 = -1 Then
            Me.BackColor = Color.Black
            history.BackColor = Color.White
            history.ForeColor = Color.Black
            count.Interval = 100
            Me.Close()
        End If
        If count2000 = 4 Then
            count.Interval = 100
            history.Text = history.Text + ("12padams: Oh " & mainname & " just remember to watch the year incase something goes wrong... have a good trip :)" & Environment.NewLine)
        End If
        If count2000 = 8 Then
            history.Text = history.Text + ("The Hidden Hacker: Ok cool thanks for that" & Environment.NewLine)
        End If
        If count2000 = 13 Then
            history.Text = history.Text + ("12padams: well when " & mainname & " gets back ill let you go as well on the next one" & Environment.NewLine)
        End If
        If count2000 = 17 Then
            history.Text = history.Text + ("The Hidden Hacker: not really... I just wish I got to time travel myself" & Environment.NewLine)
        End If
        If count2000 = 22 Then
            history.Text = history.Text + ("12padams: Is there anything you want to say to " & mainname & " now just before " & mainname & " is gone?" & Environment.NewLine)
        End If
        If count2000 = 27 Then
            history.Text = history.Text + ("12padams: yea me too but it needs to be done..." & Environment.NewLine)
        End If
        If count2000 = 33 Then
            history.Text = history.Text + ("The Hidden Hacker: Yea... I just wish It didn't take so long :(" & Environment.NewLine)
        End If
        If count2000 = 37 Then
            history.Text = history.Text + ("12padams: Ok well here we go again... another test which will show interesting and powerful results" & Environment.NewLine)
        End If
        If count2000 = 42 Then
            history.Text = history.Text + ("The Hidden Hacker: Don't worry I will tell you strait away I promise" & Environment.NewLine)
        End If
        If count2000 = 48 Then
            history.Text = history.Text + ("12padams: Ok get just remeber as soon as " & mainname & " gets the the year 2000 you need to tell me strait away" & Environment.NewLine)
        End If
        If count2000 = 53 Then
            history.Text = history.Text + ("The Hidden Hacker: Well I guess I trust you then" & Environment.NewLine)
        End If
        If count2000 = 57 Then
            history.Text = history.Text + ("12padams: don't worry nothings gunna happen" & Environment.NewLine)
        End If
        If count2000 = 62 Then
            history.Text = history.Text + ("The Hidden Hacker: Well I hope nothing goes wrong..." & Environment.NewLine)
        End If
        If count2000 = 68 Then
            history.Text = history.Text + ("12padams: No it can't thats why i have coded it so if it does show 1900 it will jump forward in time back the the year 2000" & Environment.NewLine)
        End If
        If count2000 = 72 Then
            history.Text = history.Text + ("The Hidden Hacker: wait are you saying that this software can accually take someone back that far?" & Environment.NewLine)
        End If
        If count2000 = 78 Then
            history.Text = history.Text + ("12padams: Well apon the numbers switching to 2000 it may instead switch to 1900" & Environment.NewLine)
        End If
        If count2000 = 82 Then
            history.Text = history.Text + ("The Hidden Hacker: Ok but can you tell me what will happen?" & Environment.NewLine)
        End If
        If count2000 = 87 Then
            history.Text = history.Text + ("12padams: Well I am just worried about when he goes past the year 2000 during travel..." & Environment.NewLine)
        End If
        If count2000 = 91 Then
            history.Text = history.Text + ("The Hidden Hacker: I know that but what could happen?" & Environment.NewLine)
        End If
        If count2000 = 96 Then
            history.Text = history.Text + ("12padams: Well There may be the slight chance of YK2 interference" & Environment.NewLine)
        End If
        If count2000 = 100 Then
            history.Text = history.Text + ("The Hidden Hacker: I need to know what could go wrong." & Environment.NewLine)
        End If
        If count2000 = 104 Then
        history.Text = history.Text + ("12padams: What do you need to know?" & Environment.NewLine)
        End If
        If count2000 = 108 Then
            history.Text = history.Text + ("The Hidden Hacker: I just have a few questions..." & Environment.NewLine)
        End If
        If count2000 = 111 Then
            history.Text = history.Text + ("The Hidden Hacker: Don't Worry... I will" & Environment.NewLine)
        End If
        If count2000 = 115 Then
            history.Text = history.Text + ("12padams: You just have to make sure you tell me ok..." & Environment.NewLine)
        End If
        If count2000 = 120 Then
            history.Text = history.Text + ("12padams: I want you to tell me as soon as he ges the the year 2000 then we will start another chat." & Environment.NewLine)
        End If
        If count2000 = 124 Then
            history.Text = history.Text + ("12padams: wow good job... ok heres what we will do" & Environment.NewLine)
        End If
        If count2000 = 130 Then
            history.Text = history.Text + ("The Hidden Hacker: Hey I got tracking software which will alert me as soon as the time travel is over... I developed it after a year of waiting." & Environment.NewLine)
        End If
        If count2000 = 135 Then
            history.Text = history.Text + ("12padams: The most important thing now is preparing for when " & mainname & " gets to the year 2000" & Environment.NewLine)
        End If
        If count2000 = 140 Then
            history.Text = history.Text + ("12padams: Now we have to stop chatting about who gets to do what now " & Environment.NewLine)
        End If
        If count2000 = 144 Then
            history.Text = history.Text + ("The Hidden Hacker: Hmm I would prefere to be me then..." & Environment.NewLine)
        End If
        If count2000 = 149 Then
            history.Text = history.Text + ("12padams: Well accually " & mainname & " will need to go back to 1998 after experiencing all the future tech so..." & Environment.NewLine)
        End If
        If count2000 = 155 Then
            history.Text = history.Text + ("The Hidden Hacker: Ok... " & mainname & " you should feel happy that you don't have to wait a whole year for results " & Environment.NewLine)
        End If
        If count2000 = 160 Then
            history.Text = history.Text + ("12padams: Hey hidden hacker... if your doing tests like this they take time... just be patient " & Environment.NewLine)
        End If
        If count2000 = 166 Then
            history.Text = history.Text + ("The Hidden Hacker: Oh great not another whole year :( " & Environment.NewLine)
        End If
        If count2000 = 170 Then
            history.Text = history.Text + ("12padams: your wrong... 3 minutes for " & mainname & " and 1 year for us..." & Environment.NewLine)
        End If
        If count2000 = 175 Then
            history.Text = history.Text + ("The Hidden Hacker: Hmm 3 minutes and we get to see the results to this test " & Environment.NewLine)
        End If
        If count2000 < 175 Then
            history.Focus()
            history.SelectionStart = 999999
            history.ScrollToCaret()
            typechat.Focus()
        End If
    End Sub
End Class