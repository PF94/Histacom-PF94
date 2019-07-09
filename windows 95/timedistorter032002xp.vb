Public Class timedistorter032002xp
    Dim yearselected As Integer
    Dim timergo As Boolean
    Dim countdownnum As Integer
    Dim moveable As Boolean = True
    Dim mexlocation, meylocation As Integer
    Dim mewidth, meheight As Integer
    Dim maximize As Boolean

    Private Sub programtopbar_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles top.MouseDown
        If moveable = True Then
            If e.Button = MouseButtons.Left Then
                top.Capture = False
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
            meylocation = Windowsxp2002damaged.desktopicons.Height - Me.Height
            mexlocation = Windowsxp2002damaged.desktopicons.Width - Me.Width
            mewidth = Me.Width
            meheight = Me.Height
            bottomrightcorner.Hide()
            bottomleftcorner.Hide()
            left.Hide()
            bottom.Hide()
            right.Hide()
            Dim w, h As Integer
            w = Windowsxp2002damaged.desktopicons.Width
            h = Windowsxp2002damaged.desktopicons.Height
            Me.Location = New Point(0, 0)
            Me.Size = New Size(w, h)
            moveable = False
            maximizebutton.Image = My.Resources.windowsxprestorebutton
            maximize = True
            toprightcorner.Hide()
            topleftcorner.Hide()
        Else
            bottomrightcorner.Show()
            bottomleftcorner.Show()
            left.Show()
            bottom.Show()
            right.Show()
            Me.Location = New Point(mexlocation, meylocation)
            Me.Size = New Size(mewidth, meheight)
            moveable = True
            maximizebutton.Image = My.Resources.windowsxpmaximizebutton
            maximize = False
            toprightcorner.Show()
            topleftcorner.Show()
        End If
    End Sub

    Private Sub look_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles look.Tick
        Me.top.BackColor = Windowsxp2002damaged.top.BackColor
        Me.top.BackgroundImage = Windowsxp2002damaged.top.BackgroundImage
        Me.programname.ForeColor = Windowsxp2002damaged.programname.ForeColor
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        yearselected = 2001
        countdownnum = 60
        timergo = True
        Countdownlabel.Location = New Point(314, 52)
        countdown.Location = New Point(339, 75)
        Label2.Show()
        Button1.Hide()
        Button2.Hide()
        countdowntimer.Start()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        yearselected = 2000
        countdownnum = 60
        timergo = True
        Countdownlabel.Location = New Point(314, 52)
        countdown.Location = New Point(339, 75)
        Label2.Show()
        Button1.Hide()
        Button2.Hide()
        countdowntimer.Start()
    End Sub

    Private Sub countdowntimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles countdowntimer.Tick
        countdownnum = countdownnum - 1
        If yearselected = 2000 Then




            If countdownnum = -10 Then
                Windows2000.Show()
                countdowntimer.Stop()
                time_travel_year_display.Hide()
                Me.Close()
            End If
            If countdownnum = -9 Then
                time_travel_year_display.year.Show()
                commandpromptxp.Hide()
                Me.Hide()

            End If
            If countdownnum = -8 Then
                time_travel_year_display.year.Hide()
            End If
            If countdownnum = -7 Then
                time_travel_year_display.year.Text = "2000"
            End If
            If countdownnum = -6 Then
                time_travel_year_display.year.Text = "2001"
            End If
            If countdownnum = -2 Then
                time_travel_year_display.Show()
                time_travel_year_display.year.Text = "2002"
            End If
            If countdownnum = -1 Then
                Label2.Text = "Traveling"
                Countdownlabel.Text = "Year:"
                countdown.Text = "2002"
            End If
            If countdownnum = 1 Then
                countdown.Text = countdownnum
                commandpromptxp.TextBox1.Text = commandpromptxp.TextBox1.Text + ("The Hidden Hacker: good luck " & mainname & Environment.NewLine)
            End If
            If countdownnum = 5 Then
                countdown.Text = countdownnum
                commandpromptxp.TextBox1.Text = commandpromptxp.TextBox1.Text + ("The Hidden Hacker: and 2002 will no longer be a virus wasteland." & Environment.NewLine)
            End If
            If countdownnum = 9 Then
                countdown.Text = countdownnum
                commandpromptxp.TextBox1.Text = commandpromptxp.TextBox1.Text + ("The Hidden Hacker: We will be a team again" & Environment.NewLine)
            End If
            If countdownnum = 13 Then
                countdown.Text = countdownnum
                commandpromptxp.TextBox1.Text = commandpromptxp.TextBox1.Text + ("The Hidden Hacker: As soon as things are fixed in 2000 and 12padams sees you come back, he will not unlease the virus" & Environment.NewLine)
            End If
            If countdownnum = 18 Then
                countdown.Text = countdownnum
                commandpromptxp.TextBox1.Text = commandpromptxp.TextBox1.Text + ("The Hidden Hacker: Anyway don't worry about me... when you leave 2002 and go to 2000 to fix things up ill be ok" & Environment.NewLine)
            End If
            If countdownnum = 24 Then
                countdown.Text = countdownnum
                commandpromptxp.TextBox1.Text = commandpromptxp.TextBox1.Text + ("The Hidden Hacker: I am glad you choose 2000... I don't think you and I would have been able to tell this story to 12padams in 2001" & Environment.NewLine)
            End If
            If countdownnum = 29 Then
                countdown.Text = countdownnum
                commandpromptxp.TextBox1.Text = commandpromptxp.TextBox1.Text + ("The Hidden Hacker: So you are the only one with memory of this bad virus infected 2002" & Environment.NewLine)
            End If
            If countdownnum = 34 Then
                countdown.Text = countdownnum
                commandpromptxp.TextBox1.Text = commandpromptxp.TextBox1.Text + ("The Hidden Hacker: Remember when you get to 2000 the hidden hacker of that time will not know about the time travel stuffing up" & Environment.NewLine)
            End If
            If countdownnum = 40 Then
                countdown.Text = countdownnum
                commandpromptxp.TextBox1.Text = commandpromptxp.TextBox1.Text + ("The Hidden Hacker: ok since you are going to 2000 12padams will think his software worked without fail and you went 1998 -> 1999 -> 2000" & Environment.NewLine)
            End If
            If countdownnum = 44 Then
                countdown.Text = countdownnum
                commandpromptxp.TextBox1.Text = commandpromptxp.TextBox1.Text + ("The Hidden Hacker: Your travel from 1999 ->2000 stuffed up and took you here instead..." & Environment.NewLine)
            End If
            If countdownnum = 49 Then
                countdown.Text = countdownnum
                commandpromptxp.TextBox1.Text = commandpromptxp.TextBox1.Text + ("The Hidden Hacker: For you your experience has gone like this: 1998 -> 1999 -> 2002 and then 2000 in less then a minute" & Environment.NewLine)
            End If
            If countdownnum = 54 Then
                countdown.Text = countdownnum
                commandpromptxp.TextBox1.Text = commandpromptxp.TextBox1.Text + ("The Hidden Hacker: This means that you will have to pretend you never met me here." & Environment.NewLine)
            End If
            If countdownnum = 59 Then
                countdown.Text = countdownnum
                commandpromptxp.TextBox1.Text = commandpromptxp.TextBox1.Text + ("The Hidden Hacker: Ok... you chose the year 2000." & Environment.NewLine)
            End If
            If timergo = True Then
                countdown.Text = countdownnum
            End If
        End If

        If yearselected = 2001 Then
            Label2.Text = "Year 2001 Selected Preparing Time Travel:"
            If countdownnum = -9 Then
                windowsxp2001_do_not_make_the_virus.Show()
                windowsxp2001_do_not_make_the_virus.BringToFront()
                countdowntimer.Stop()
                time_travel_year_display.Hide()
                Me.Close()
            End If
            If countdownnum = -8 Then
                time_travel_year_display.year.Show()
                commandpromptxp.Hide()
                Me.Hide()

            End If
            If countdownnum = -7 Then
                time_travel_year_display.year.Hide()
            End If
            If countdownnum = -6 Then
                time_travel_year_display.year.Text = "2001"
            End If
            If countdownnum = -2 Then
                time_travel_year_display.Show()
                time_travel_year_display.year.Text = "2002"
            End If
            If countdownnum = -1 Then
                Label2.Text = "Traveling"
                Countdownlabel.Text = "Year:"
                countdown.Text = "2002"
            End If
            If countdownnum = 1 Then
                countdown.Text = countdownnum
                commandpromptxp.TextBox1.Text = commandpromptxp.TextBox1.Text + ("The Hidden Hacker: see you there " & mainname & Environment.NewLine)
            End If
            If countdownnum = 5 Then
                countdown.Text = countdownnum
                commandpromptxp.TextBox1.Text = commandpromptxp.TextBox1.Text + ("The Hidden Hacker: 2001 here we come" & Environment.NewLine)
            End If
            If countdownnum = 9 Then
                countdown.Text = countdownnum
                commandpromptxp.TextBox1.Text = commandpromptxp.TextBox1.Text + ("The Hidden Hacker: anyway here we go" & Environment.NewLine)
            End If
            If countdownnum = 13 Then
                countdown.Text = countdownnum
                commandpromptxp.TextBox1.Text = commandpromptxp.TextBox1.Text + ("The Hidden Hacker: I know time distorter 0.4 is on the website but its hard to access" & Environment.NewLine)
            End If
            If countdownnum = 18 Then
                countdown.Text = countdownnum
                commandpromptxp.TextBox1.Text = commandpromptxp.TextBox1.Text + ("The Hidden Hacker: Just know that if worst comes to worst we will need to hack into his website" & Environment.NewLine)
            End If
            If countdownnum = 24 Then
                countdown.Text = countdownnum
                commandpromptxp.TextBox1.Text = commandpromptxp.TextBox1.Text + ("The Hidden Hacker: so we need to make sure we dont get infected" & Environment.NewLine)
            End If
            If countdownnum = 29 Then
                countdown.Text = countdownnum
                commandpromptxp.TextBox1.Text = commandpromptxp.TextBox1.Text + ("The Hidden Hacker: he also has lots of viruses which he constantly attacks us with" & Environment.NewLine)
            End If
            If countdownnum = 34 Then
                countdown.Text = countdownnum
                commandpromptxp.TextBox1.Text = commandpromptxp.TextBox1.Text + ("The Hidden Hacker: he had no trust for me in 2001... so i doubt he will believe us" & Environment.NewLine)
            End If
            If countdownnum = 40 Then
                countdown.Text = countdownnum
                commandpromptxp.TextBox1.Text = commandpromptxp.TextBox1.Text + ("The Hidden Hacker: I need to warn you though..." & Environment.NewLine)
            End If
            If countdownnum = 44 Then
                countdown.Text = countdownnum
                commandpromptxp.TextBox1.Text = commandpromptxp.TextBox1.Text + ("The Hidden Hacker: but we need to give it a try" & Environment.NewLine)
            End If
            If countdownnum = 49 Then
                countdown.Text = countdownnum
                commandpromptxp.TextBox1.Text = commandpromptxp.TextBox1.Text + ("The Hidden Hacker: I dont know if he will believe us..." & Environment.NewLine)
            End If
            If countdownnum = 54 Then
                countdown.Text = countdownnum
                commandpromptxp.TextBox1.Text = commandpromptxp.TextBox1.Text + ("The Hidden Hacker: Now this means that me and you will go back to last year and try to tell 12padams what happened" & Environment.NewLine)
            End If
            If countdownnum = 59 Then
                countdown.Text = countdownnum
                commandpromptxp.TextBox1.Text = commandpromptxp.TextBox1.Text + ("The Hidden Hacker: Ok... you chose the year 2001." & Environment.NewLine)
            End If
            If timergo = True Then
                countdown.Text = countdownnum
            End If
        End If

        commandpromptxp.TextBox1.SelectionStart = 999999
        commandpromptxp.TextBox1.ScrollToCaret()
    End Sub
End Class