Public Class Windowsxp2002damaged
    Dim countdown As Integer
    Dim ampm As String
    Dim count As Integer
    Dim txtcount As Integer
    Dim usersave As String

    Private Sub startbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        startmenu.Show()
    End Sub

    Private Sub windows98_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Click
        startmenu.Hide()
    End Sub

    Private Sub windows98Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        If My.Resources.Windows_XP_Startup.CanRead Then
            Dim bStr(My.Resources.Windows_XP_Startup.Length) As Byte
            My.Resources.Windows_XP_Startup.Read(bStr, 0, My.Resources.Windows_XP_Startup.Length)
            My.Computer.Audio.Play(bStr, AudioPlayMode.Background)
        End If
        startmenu.Hide()

        Timer1.Start()
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
        Dim w, h As Integer
        w = Me.desktopicons.Width
        h = Me.desktopicons.Height
        Dim bmp As Bitmap = New Bitmap(w, h)
        Using g As Graphics = Graphics.FromImage(bmp)
            g.DrawImage(Me.BackgroundImage, 0, 0, bmp.Width, bmp.Height)
        End Using
        Me.BackgroundImage = bmp
        Me.desktopicons.BackgroundImage = bmp
        commandpromptstartup.Start()
        System.Windows.Forms.Application.VisualStyleState = VisualStyles.VisualStyleState.ClientAndNonClientAreasEnabled
        System.Windows.Forms.Application.EnableVisualStyles()
    End Sub

    Private Sub NotePadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim opennotepad As New formnotepad
        opennotepad.Show()
        startmenu.Hide()
    End Sub

    Private Sub desktopicons_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles desktopicons.DoubleClick
        Dim objDrawingPoint As Drawing.Point
        Dim objListViewItem As ListViewItem

        objDrawingPoint = desktopicons.PointToClient(Cursor.Position)

        If Not IsNothing(objDrawingPoint) Then
            With objDrawingPoint
                objListViewItem = desktopicons.GetItemAt(.X, .Y)
            End With

            If Not IsNothing(objListViewItem) Then
                If objListViewItem.Text = "Internet Explorer" Then
                    Dim openinternet As New internet_explorer_5
                    openinternet.Show()
                End If
                If objListViewItem.Text = "Guess The Number 2 Setup" Then

                    Dim openinstall As New Installer98
                    openinstall.installname.Text = "Guess The Number 2"
                    openinstall.installimage.Image = My.Resources.Guess_the_Number__install_
                    openinstall.Show()
                End If
                If objListViewItem.Text = "Start Runner 98 Setup" Then

                    Dim openinstall As New Installer98
                    openinstall.installname.Text = "Start Runner 98"
                    openinstall.installimage.Image = My.Resources.start_run__install___white_with_programname_
                    openinstall.Show()
                End If
                If objListViewItem.Text = "Error Blaster 98 Setup" Then

                    Dim openinstall As New Installer98
                    openinstall.installname.Text = "Error Blaster 98"
                    openinstall.installimage.Image = My.Resources.error_blast__big_
                    openinstall.Show()
                End If
                If objListViewItem.Text = "Skindows 95 Setup" Then

                    Dim openinstall As New Installer98
                    openinstall.installname.Text = "Skindows 95"
                    openinstall.installimage.Image = My.Resources.skindows_95__install_
                    openinstall.Show()
                End If
                If objListViewItem.Text = "Web Chat Setup" Then

                    Dim openinstall As New Installer98
                    openinstall.installname.Text = "Web Chat"
                    openinstall.installimage.Image = My.Resources.chat__big_
                    openinstall.Show()
                End If
                If objListViewItem.Text = "hwcv.exe" Then
                    Dim openhwcv As New hwcv
                    openhwcv.Show()
                End If
                If objListViewItem.Text = "Time Distorter 0.3 Setup" Then

                    Dim openinstall As New installerxp
                    openinstall.installname.Text = "Time Distorter 0.3"
                    openinstall.installimage.Image = My.Resources.time_distorter__install_Black_
                    openinstall.Show()
                End If
            End If
        End If
    End Sub

    Private Sub Desktop_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles desktopicons.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            rightclickbackproperties.Show()
            rightclickbackproperties.BringToFront()
            rightclickbackproperties.Location = MousePosition
        End If
        If e.Button = Windows.Forms.MouseButtons.Left Then
        End If
        If e.Button = Windows.Forms.MouseButtons.Middle Then
        End If

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles startbutton.Click
        startmenu.Show()
        usernamestart.Text = mainname
        startbutton.Image = My.Resources.windowsxpstartbuttonpressed
    End Sub

    Private Sub PropertiesToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PropertiesToolStripMenuItem1.Click
        Dim oform As New formDisplayproperties
        oform.Show()
        startmenu.Hide()
    End Sub

    Private Sub WindowsExplorerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim openinternetexplorer As New internet_explorer_5
        openinternetexplorer.Show()
        startmenu.Hide()
    End Sub

    Private Sub FolderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FolderToolStripMenuItem.Click
        desktopicons.Items.Add("New Folder")
    End Sub

    Private Sub desktopicons_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles desktopicons.MouseDown
        startmenu.Hide()
        startbutton.Image = My.Resources.winxpstartbutton
    End Sub

    Private Sub desktopicons_Click(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles desktopicons.MouseDown

    End Sub

    Private Sub turnoffcomputerbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles turnoffcomputerbutton.Click
        Title_Screen.Close()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Hour(Now) > 12 Then
            ampm = "PM"
        Else
            ampm = "AM"
        End If
        taskbartime.Text = Format(Now, "hh:mm") & " " & ampm
    End Sub

    Private Sub NotepadToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NotepadToolStripMenuItem.Click
        Dim opennotepad As New notepadxp
        opennotepad.Show()
        startmenu.Hide()
        startbutton.Image = My.Resources.winxpstartbutton
    End Sub

    Private Sub commandpromptstartup_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles commandpromptstartup.Tick
        commandpromptxp.Show()
        comcountdown.Start()
        countaction.Start()
        countdown = 200
        commandpromptstartup.Stop()
    End Sub

    Private Sub countaction_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles countaction.Tick
        countdown = countdown - 1
    End Sub

    Private Sub comcountdown_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles comcountdown.Tick
        If countdown = 13 Then
            commandpromptxp.TextBox1.Text = commandpromptxp.TextBox1.Text + ("The Hidden Hacker: Ill just wait for you and you can make the choice of 2000 or 2001" & Environment.NewLine)
            countdown = countdown - 1
            countaction.Stop()
        End If
        If countdown = 17 Then
            commandpromptxp.TextBox1.Text = commandpromptxp.TextBox1.Text + ("The Hidden Hacker: Ok install it now..." & Environment.NewLine)
        End If
        If countdown = 18 Then
            commandpromptxp.TextBox1.Text = commandpromptxp.TextBox1.Text + ("time distorter 0.3 - 100%" & Environment.NewLine)
            Me.desktopicons.Items.Add("Time Distorter 0.3 Setup", imageIndex:=2)
        End If
        If countdown = 19 Then
            commandpromptxp.TextBox1.Text = commandpromptxp.TextBox1.Text + ("time distorter 0.3 - 98%" & Environment.NewLine)
        End If
        If countdown = 20 Then
            commandpromptxp.TextBox1.Text = commandpromptxp.TextBox1.Text + ("time distorter 0.3 - 94" & Environment.NewLine)
        End If
        If countdown = 21 Then
            commandpromptxp.TextBox1.Text = commandpromptxp.TextBox1.Text + ("time distorter 0.3 - 91%" & Environment.NewLine)
        End If
        If countdown = 22 Then
            commandpromptxp.TextBox1.Text = commandpromptxp.TextBox1.Text + ("time distorter 0.3 - 87%" & Environment.NewLine)
        End If
        If countdown = 23 Then
            commandpromptxp.TextBox1.Text = commandpromptxp.TextBox1.Text + ("time distorter 0.3 - 83%" & Environment.NewLine)
        End If
        If countdown = 24 Then
            commandpromptxp.TextBox1.Text = commandpromptxp.TextBox1.Text + ("time distorter 0.3 - 76%" & Environment.NewLine)
        End If
        If countdown = 25 Then
            commandpromptxp.TextBox1.Text = commandpromptxp.TextBox1.Text + ("time distorter 0.3 - 71%" & Environment.NewLine)
        End If
        If countdown = 26 Then
            commandpromptxp.TextBox1.Text = commandpromptxp.TextBox1.Text + ("time distorter 0.3 - 67%" & Environment.NewLine)
        End If
        If countdown = 27 Then
            commandpromptxp.TextBox1.Text = commandpromptxp.TextBox1.Text + ("time distorter 0.3 - 65%" & Environment.NewLine)
        End If
        If countdown = 28 Then
            commandpromptxp.TextBox1.Text = commandpromptxp.TextBox1.Text + ("time distorter 0.3 - 61%" & Environment.NewLine)
        End If
        If countdown = 29 Then
            commandpromptxp.TextBox1.Text = commandpromptxp.TextBox1.Text + ("time distorter 0.3 - 59%" & Environment.NewLine)
        End If
        If countdown = 30 Then
            commandpromptxp.TextBox1.Text = commandpromptxp.TextBox1.Text + ("time distorter 0.3 - 55%" & Environment.NewLine)
        End If
        If countdown = 31 Then
            commandpromptxp.TextBox1.Text = commandpromptxp.TextBox1.Text + ("time distorter 0.3 - 52%" & Environment.NewLine)
        End If
        If countdown = 32 Then
            commandpromptxp.TextBox1.Text = commandpromptxp.TextBox1.Text + ("time distorter 0.3 - 49%" & Environment.NewLine)
        End If
        If countdown = 33 Then
            commandpromptxp.TextBox1.Text = commandpromptxp.TextBox1.Text + ("time distorter 0.3 - 43%" & Environment.NewLine)
        End If
        If countdown = 34 Then
            commandpromptxp.TextBox1.Text = commandpromptxp.TextBox1.Text + ("time distorter 0.3 - 36%" & Environment.NewLine)
        End If
        If countdown = 35 Then
            commandpromptxp.TextBox1.Text = commandpromptxp.TextBox1.Text + ("time distorter 0.3 - 30%" & Environment.NewLine)
        End If
        If countdown = 36 Then
            commandpromptxp.TextBox1.Text = commandpromptxp.TextBox1.Text + ("time distorter 0.3 - 26%" & Environment.NewLine)
        End If
        If countdown = 37 Then
            commandpromptxp.TextBox1.Text = commandpromptxp.TextBox1.Text + ("time distorter 0.3 - 23%" & Environment.NewLine)
        End If
        If countdown = 38 Then
            commandpromptxp.TextBox1.Text = commandpromptxp.TextBox1.Text + ("time distorter 0.3 - 18%" & Environment.NewLine)
        End If
        If countdown = 39 Then
            commandpromptxp.TextBox1.Text = commandpromptxp.TextBox1.Text + ("time distorter 0.3 - 16%" & Environment.NewLine)
        End If
        If countdown = 40 Then
            commandpromptxp.TextBox1.Text = commandpromptxp.TextBox1.Text + ("time distorter 0.3 - 11%" & Environment.NewLine)
        End If
        If countdown = 41 Then
            commandpromptxp.TextBox1.Text = commandpromptxp.TextBox1.Text + ("time distorter 0.3 - 7%" & Environment.NewLine)
        End If
        If countdown = 42 Then
            commandpromptxp.TextBox1.Text = commandpromptxp.TextBox1.Text + ("time distorter 0.3 - 4%" & Environment.NewLine)
        End If
        If countdown = 43 Then
            commandpromptxp.TextBox1.Text = commandpromptxp.TextBox1.Text + ("time distorter 0.3 - 0%" & Environment.NewLine)
            countaction.Interval = 1000
            comcountdown.Interval = 1000
        End If
        If countdown = 44 Then
            commandpromptxp.TextBox1.Text = commandpromptxp.TextBox1.Text + ("Starting tranfer: time distorter 0.3" & Environment.NewLine)
        End If
        If countdown = 48 Then
            commandpromptxp.TextBox1.Text = commandpromptxp.TextBox1.Text + ("The Hidden Hacker: Here ill send you time distorter 0.3 now" & Environment.NewLine)
        End If
        If countdown = 52 Then
            commandpromptxp.TextBox1.Text = commandpromptxp.TextBox1.Text + ("The Hidden Hacker: So its up to you where you want to go" & Environment.NewLine)
        End If
        If countdown = 56 Then
            commandpromptxp.TextBox1.Text = commandpromptxp.TextBox1.Text + ("The Hidden Hacker: The reason that I can not go to 2000 is that if nothing went wrong why would I be there..." & Environment.NewLine)
        End If
        If countdown = 61 Then
            commandpromptxp.TextBox1.Text = commandpromptxp.TextBox1.Text + ("The Hidden Hacker: 2. you by yourself go to 2000 and pretend that the whole time travel experiment worked fine and nothing went wrong" & Environment.NewLine)
        End If
        If countdown = 65 Then
            commandpromptxp.TextBox1.Text = commandpromptxp.TextBox1.Text + ("The Hidden Hacker: 1. we both go to the year 2001 and try to tell 12padams about what has happened before his virus infects the whole internet" & Environment.NewLine)
        End If
        If countdown = 70 Then
            commandpromptxp.TextBox1.Text = commandpromptxp.TextBox1.Text + ("The Hidden Hacker: which gives us 2 choices" & Environment.NewLine)
        End If
        If countdown = 73 Then
            commandpromptxp.TextBox1.Text = commandpromptxp.TextBox1.Text + ("The Hidden Hacker: These years are 2000 and 2001" & Environment.NewLine)
        End If
        If countdown = 78 Then
            commandpromptxp.TextBox1.Text = commandpromptxp.TextBox1.Text + ("The Hidden Hacker: time distorter 0.3 allows time travel to 2 years..." & Environment.NewLine)
        End If
        If countdown = 81 Then
            commandpromptxp.TextBox1.Text = commandpromptxp.TextBox1.Text + ("The Hidden Hacker: Ok as you know in 2000 12padams gave me time distorter 0.3" & Environment.NewLine)
        End If
        If countdown = 85 Then
            commandpromptxp.TextBox1.Text = commandpromptxp.TextBox1.Text + ("The Hidden Hacker: So everything is now lost the only way we can fix this is by going back in time" & Environment.NewLine)
        End If
        If countdown = 90 Then
            commandpromptxp.TextBox1.Text = commandpromptxp.TextBox1.Text + ("The Hidden Hacker: The only use for the internet now is remote home pc to pc communications which is how i am talking to you now..." & Environment.NewLine)
        End If
        If countdown = 94 Then
            commandpromptxp.TextBox1.Text = commandpromptxp.TextBox1.Text + ("The Hidden Hacker: now Its 2002 and the whole internet has been taken out and 12padams is gone" & Environment.NewLine)
        End If
        If countdown = 98 Then
            commandpromptxp.TextBox1.Text = commandpromptxp.TextBox1.Text + ("The Hidden Hacker: It went from website to website destroying each one..." & Environment.NewLine)
        End If
        If countdown = 103 Then
            commandpromptxp.TextBox1.Text = commandpromptxp.TextBox1.Text + ("The Hidden Hacker: This virus was so powerful that it killed his own computer and then spread through the whole internet" & Environment.NewLine)
        End If
        If countdown = 107 Then
            commandpromptxp.TextBox1.Text = commandpromptxp.TextBox1.Text + ("The Hidden Hacker: He suddenly went crazy and started making the worlds most dangerous virus." & Environment.NewLine)
        End If
        If countdown = 110 Then
            commandpromptxp.TextBox1.Text = commandpromptxp.TextBox1.Text + ("The Hidden Hacker: but then all hell broke loose..." & Environment.NewLine)
        End If
        If countdown = 115 Then
            commandpromptxp.TextBox1.Text = commandpromptxp.TextBox1.Text + ("The Hidden Hacker: but I was just too good and avoided the viruses easily" & Environment.NewLine)
        End If
        If countdown = 119 Then
            commandpromptxp.TextBox1.Text = commandpromptxp.TextBox1.Text + ("The Hidden Hacker: 12padams basically tried making a virus to destroy my computer in 2001" & Environment.NewLine)
        End If
        If countdown = 123 Then
            commandpromptxp.TextBox1.Text = commandpromptxp.TextBox1.Text + ("The Hidden Hacker: anyway back to the story..." & Environment.NewLine)
        End If
        If countdown = 128 Then
            commandpromptxp.TextBox1.Text = commandpromptxp.TextBox1.Text + ("The Hidden Hacker: I have 0.3 of time distorter because he sent it to me in 2000 ready for you and me to both time travel together" & Environment.NewLine)
        End If
        If countdown = 133 Then
            commandpromptxp.TextBox1.Text = commandpromptxp.TextBox1.Text + ("The Hidden Hacker: I guess he wanted to get rid of my computer which has 0.3 of time distorter on it" & Environment.NewLine)
        End If
        If countdown = 138 Then
            commandpromptxp.TextBox1.Text = commandpromptxp.TextBox1.Text + ("The Hidden Hacker: In 2001 he started getting furious and started attacking me." & Environment.NewLine)
        End If
        If countdown = 142 Then
            commandpromptxp.TextBox1.Text = commandpromptxp.TextBox1.Text + ("The Hidden Hacker: So he lost complete trust In me" & Environment.NewLine)
        End If
        If countdown = 145 Then
            commandpromptxp.TextBox1.Text = commandpromptxp.TextBox1.Text + ("The Hidden Hacker: He thought that you had come to the year 2000 and the I was hiding you." & Environment.NewLine)
        End If
        If countdown = 149 Then
            commandpromptxp.TextBox1.Text = commandpromptxp.TextBox1.Text + ("The Hidden Hacker: He refused to believe that his software failed" & Environment.NewLine)
        End If
        If countdown = 152 Then
            commandpromptxp.TextBox1.Text = commandpromptxp.TextBox1.Text + ("The Hidden Hacker: When the year 2000 came and you never showed up" & Environment.NewLine)
        End If
        If countdown = 155 Then
            commandpromptxp.TextBox1.Text = commandpromptxp.TextBox1.Text + ("The Hidden Hacker: He was certain that nothing would go wrong." & Environment.NewLine)
        End If
        If countdown = 158 Then
            commandpromptxp.TextBox1.Text = commandpromptxp.TextBox1.Text + ("The Hidden Hacker: The problem was that his software jumped forward two years while you were time traveling" & Environment.NewLine)
        End If
        If countdown = 163 Then
            commandpromptxp.TextBox1.Text = commandpromptxp.TextBox1.Text + ("The Hidden Hacker: 12padams believed that his software would successfully go past the year 2000 without errors..." & Environment.NewLine)
        End If
        If countdown = 168 Then
            commandpromptxp.TextBox1.Text = commandpromptxp.TextBox1.Text + ("The Hidden Hacker: 12padams basically had an agreement with me that as soon as you got to the year 2000 I would tell him" & Environment.NewLine)
        End If
        If countdown = 172 Then
            commandpromptxp.TextBox1.Text = commandpromptxp.TextBox1.Text + ("The Hidden Hacker: It all started when you left the year 1999" & Environment.NewLine)
        End If
        If countdown = 176 Then
            commandpromptxp.TextBox1.Text = commandpromptxp.TextBox1.Text + ("The Hidden Hacker: ok I will tell you what happened" & Environment.NewLine)
        End If
        If countdown = 179 Then
            commandpromptxp.TextBox1.Text = commandpromptxp.TextBox1.Text + ("The Hidden Hacker: I have a lot to tell you... the world is in crysis" & Environment.NewLine)
        End If
        If countdown = 182 Then
            commandpromptxp.TextBox1.Text = commandpromptxp.TextBox1.Text + ("The Hidden Hacker: Trust me don't go on..." & Environment.NewLine)
        End If
        If countdown = 185 Then
            commandpromptxp.TextBox1.Text = commandpromptxp.TextBox1.Text + ("The Hidden Hacker: If you go on the internet you will have your computer completly infected!!!" & Environment.NewLine)
        End If
        If countdown = 189 Then
            commandpromptxp.TextBox1.Text = commandpromptxp.TextBox1.Text + ("The Hidden Hacker: The whole internet is infected and is permently unusable and damaged" & Environment.NewLine)
        End If
        If countdown = 192 Then
            commandpromptxp.TextBox1.Text = commandpromptxp.TextBox1.Text + ("The Hidden Hacker: Don't go on the internet!!!!" & Environment.NewLine)
            countaction.Interval = 1500
            comcountdown.Interval = 1500
        End If
        If countdown = 195 Then
            commandpromptxp.TextBox1.Text = commandpromptxp.TextBox1.Text + ("The Hidden Hacker: STOP!!!!" & Environment.NewLine)
        End If
        If countdown = 197 Then
            commandpromptxp.TextBox1.Text = commandpromptxp.TextBox1.Text + ("The Hidden Hacker Connected" & Environment.NewLine)
        End If
        If countdown = 199 Then
            commandpromptxp.TextBox1.Text = commandpromptxp.TextBox1.Text + ("Ip 192.424.112.432 Connecting..." & Environment.NewLine)
        End If
        commandpromptxp.TextBox1.SelectionStart = 999999
        commandpromptxp.TextBox1.ScrollToCaret()
    End Sub

    Private Sub InternetExplorerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InternetExplorerToolStripMenuItem.Click
        Dim openinternet As New Internetexplorer62002damaged
        openinternet.Show()
        startmenu.Hide()
        startbutton.Image = My.Resources.winxpstartbutton
    End Sub

    Private Sub TimeDistorter03ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimeDistorter03ToolStripMenuItem.Click
        Dim timedistorter03 As New timedistorter032002xp
        timedistorter03.Show()
        startmenu.Hide()
        startbutton.Image = My.Resources.winxpstartbutton
    End Sub

    Private Sub taskbartime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles taskbartime.Click
        Dim showmess As New Windows_Xp_messagebox
        showmess.errormessage.Text = "your save code is: bsdn98e5"
        showmess.Show()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub startmenuitems_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles startmenuitems.ItemClicked

    End Sub

    Private Sub MenuStrip2_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip2.ItemClicked

    End Sub
End Class