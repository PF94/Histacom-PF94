Public Class Windows2000
    Dim comn As Integer
    Dim count As Integer
    Dim txtcount As Integer
    Dim usersave As String

    Private Sub windows95_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles desktopicons.Click
        startmenu.Hide()
    End Sub

    Private Sub windows95_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        desktopicons.Show()
        If My.Resources.windows_2000_boot_sound.CanRead Then
            Dim bStr(My.Resources.windows_2000_boot_sound.Length) As Byte
            My.Resources.windows_2000_boot_sound.Read(bStr, 0, My.Resources.windows_2000_boot_sound.Length)
            My.Computer.Audio.Play(bStr, AudioPlayMode.Background)
        End If
        startmenu.Hide()
        program.Hide()
        Timer4.Start()
        Timer1.Start()
        exampleprogramtopbar.Show()
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
        System.Windows.Forms.Application.VisualStyleState = VisualStyles.VisualStyleState.NoneEnabled
        Me.desktopicons.BackgroundImage = My.Resources.Windows_2000_background
        Dim w, h As Integer
        w = Me.desktopicons.Width
        h = Me.desktopicons.Height
        Dim bmp As Bitmap = New Bitmap(w, h)
        Using g As Graphics = Graphics.FromImage(bmp)
            g.DrawImage(Me.desktopicons.BackgroundImage, 0, 0, bmp.Width, bmp.Height)
        End Using
        Me.BackgroundImage = bmp
        Me.desktopicons.BackgroundImage = bmp
        commandpromptstartup.Start()
        comn = 100
    End Sub

    Private Sub NotePadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NotePadToolStripMenuItem.Click
        Dim opennotepad As New notepad2000
        opennotepad.Show()
        startmenu.Hide()
    End Sub

    Private Sub HelpToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpToolStripMenuItem.Click
        Dim windowshelpopen As New formwindowshelp
        windowshelpopen.Show()
        startmenu.Hide()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        program.Hide()
    End Sub

    Private Sub CalculatorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalculatorToolStripMenuItem.Click
        Dim opencalc As New formcalculator
        opencalc.Show()
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
                    Dim openinternet As New Internet_Explorer_52001
                    openinternet.Show()
                End If
                If objListViewItem.Text = "Guess The Number 2 Setup" Then

                    Dim openinstall As New installer2000
                    openinstall.installname.Text = "Guess The Number 2"
                    openinstall.installimage.Image = My.Resources.Guess_the_Number__install_
                    openinstall.Show()
                End If
                If objListViewItem.Text = "Start Runner 2000 Setup" Then

                    Dim openinstall As New installer2000
                    openinstall.installname.Text = "Start Runner 2000"
                    openinstall.installimage.Image = My.Resources.start_run__install___white_with_programname_
                    openinstall.Show()
                End If
                If objListViewItem.Text = "Error Blaster 2000 Setup" Then

                    Dim openinstall As New installer2000
                    openinstall.installname.Text = "Error Blaster 2000"
                    openinstall.installimage.Image = My.Resources.error_blast__big_
                    openinstall.Show()
                End If
                If objListViewItem.Text = "Survive The Day Setup" Then

                    Dim openinstall As New installer2000
                    openinstall.installname.Text = "Survive The Day"
                    openinstall.installimage.Image = My.Resources.survive_the_day_install_banner
                    openinstall.Show()
                End If
                If objListViewItem.Text = "Skindows 95 Setup" Then

                    Dim openinstall As New installer2000
                    openinstall.installname.Text = "Skindows 95"
                    openinstall.installimage.Image = My.Resources.skindows_95__install_
                    openinstall.Show()
                End If
                If objListViewItem.Text = "Web Chat 2000 Setup" Then

                    Dim openinstall As New installer2000
                    openinstall.installname.Text = "Web Chat 2000"
                    openinstall.installimage.Image = My.Resources.chat__big_
                    openinstall.Show()
                End If
                If objListViewItem.Text = "Rouge Scanner Setup" Then

                    Dim openinstall As New installer2000
                    openinstall.installname.Text = "Rouge Scanner"
                    openinstall.installimage.Image = My.Resources.rouge_scanner_install_banner
                    openinstall.Show()
                End If
                If objListViewItem.Text = "hwcv.exe" Then
                    Dim openhwcv As New hwcv
                    openhwcv.Show()
                End If
                If objListViewItem.Text = "Time Distorter 0.3 Setup" Then

                    Dim openinstall As New installer2000
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

    Private Sub minimizebutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles minimizebutton.Click

    End Sub

    Private Sub maximizebutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles maximizebutton.Click

    End Sub

    Private Sub startbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles startbutton.Click
        startmenu.Show()
        startmenu.BringToFront()
    End Sub

    Private Sub PropertiesToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PropertiesToolStripMenuItem1.Click
        Dim oform As New formDisplayproperties
        oform.Show()
        startmenu.Hide()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        desktopicons.BackColor = Me.BackColor
        taskbartime.Text = TimeOfDay
    End Sub

    Private Sub PhoneDialerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PhoneDialerToolStripMenuItem.Click
        Dim openphonedialer As New phone_dialer
        openphonedialer.Show()
        startmenu.Hide()
    End Sub

    Private Sub AddressBookToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddressBookToolStripMenuItem.Click
        Dim openaddressbook As New Address_Book
        openaddressbook.Show()
        startmenu.Hide()
    End Sub

    Private Sub VolumeControlToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim openvolumecontrol As New volume_control
        openvolumecontrol.Show()
        startmenu.Hide()
    End Sub

    Private Sub RunToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RunToolStripMenuItem.Click
        Dim openrun As New run
        openrun.Show()
        startmenu.Hide()
    End Sub

    Private Sub PaintToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PaintToolStripMenuItem.Click
        Dim openpaint As New mspaint
        openpaint.Show()
        startmenu.Hide()
    End Sub

    Private Sub Timer4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer4.Tick

    End Sub

    Private Sub FolderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FolderToolStripMenuItem.Click
        desktopicons.Items.Add("New Folder")
    End Sub

    Private Sub desktopicons_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles desktopicons.MouseDown
        startmenu.Hide()

    End Sub

    Private Sub GuessTheNumberToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuessTheNumberToolStripMenuItem.Click
        Dim openguessnumber As New guessthenumber2win2000()
        openguessnumber.Show()
        startmenu.Hide()
    End Sub

    Private Sub StartRunnerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StartRunnerToolStripMenuItem.Click
        Dim openstartrunner As New startrunner2000
        openstartrunner.Show()
        startmenu.Hide()
    End Sub

    Private Sub ErrorBlasterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ErrorBlasterToolStripMenuItem.Click
        Dim openerror As New errorblaster2000
        openerror.Show()
        startmenu.Hide()
    End Sub

    Private Sub SkindowsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SkindowsToolStripMenuItem.Click
        Dim openskin As New Skindows_95
        openskin.Show()
        startmenu.Hide()
    End Sub

    Private Sub WebChatToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WebChatToolStripMenuItem.Click
        Dim openchat As New webchat_2000
        openchat.Show()
        startmenu.Hide()
    End Sub

    Private Sub TimeDistorterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SurviveTheDayToolStripMenuItem.Click
        Dim opensurvivetheday As New Survive_The_Day
        opensurvivetheday.Show()
        startmenu.Hide()
    End Sub

    Private Sub taskbartime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles taskbartime.Click
        Dim showmess As New windows2000messagebox
        showmess.infomessage.Text = "Your save code is: fgsd7f6a"
        showmess.Show()
    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        Title_Screen.Close()
    End Sub


    Private Sub desktopicons_Click(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles desktopicons.MouseDown

    End Sub

    Private Sub commandpromptstartup_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles commandpromptstartup.Tick

        If comn = -43 Then
            commandprompt2000.TextBox1.Text = ""
            commandprompt2000.Close()
            commandpromptstartup.Stop()
        End If
        If comn = -41 Then
            commandprompt2000.TextBox1.Text = commandprompt2000.TextBox1.Text + ("12padams: bye" & Environment.NewLine)

        End If
        If comn = -37 Then
            commandprompt2000.TextBox1.Text = commandprompt2000.TextBox1.Text + ("12padams: We will see you after your done " & mainname & Environment.NewLine)

        End If
        If comn = -32 Then
            commandprompt2000.TextBox1.Text = commandprompt2000.TextBox1.Text + ("12padams: Stop it hidden hacker he needs a break..." & Environment.NewLine)

        End If
        If comn = -26 Then
            commandprompt2000.TextBox1.Text = commandprompt2000.TextBox1.Text + ("The Hidden Hacker: Don't be long " & mainname & " since I really wanna time travel now" & Environment.NewLine)

        End If
        If comn = -20 Then
            commandprompt2000.TextBox1.Text = commandprompt2000.TextBox1.Text + ("12padams: Ok bye " & mainname & ", and good luck :)" & Environment.NewLine)

        End If
        If comn = -15 Then
            commandprompt2000.TextBox1.Text = commandprompt2000.TextBox1.Text + ("12padams: Once you tell me the password you and The Hidden hacker will go on a time travel test together." & Environment.NewLine)

        End If
        If comn = -8 Then
            commandprompt2000.TextBox1.Text = commandprompt2000.TextBox1.Text + ("12padams: Then download webchat and tell me what the password is." & Environment.NewLine)

        End If
        If comn = 3 Then
            commandprompt2000.TextBox1.Text = commandprompt2000.TextBox1.Text + ("12padams: When you beat it you will be given a password" & Environment.NewLine)

        End If
        If comn = 7 Then
            commandprompt2000.TextBox1.Text = commandprompt2000.TextBox1.Text + ("12padams: Go onto my website and download survive the day" & Environment.NewLine)

        End If
        If comn = 14 Then
            commandprompt2000.TextBox1.Text = commandprompt2000.TextBox1.Text + ("12padams: " & mainname & " I will let you time travel again once you complete a game" & Environment.NewLine)

        End If
        If comn = 20 Then
            commandprompt2000.TextBox1.Text = commandprompt2000.TextBox1.Text + ("12padams: Please be patient... Not now becasue " & mainname & " has already time traveled recently" & Environment.NewLine)

        End If
        If comn = 26 Then
            commandprompt2000.TextBox1.Text = commandprompt2000.TextBox1.Text + ("The Hidden Hacker: Why not NOWWWWW!!!!!" & Environment.NewLine)

        End If
        If comn = 33 Then
            commandprompt2000.TextBox1.Text = commandprompt2000.TextBox1.Text + ("12padams: Don't worry you will both time travel... just not now" & Environment.NewLine)

        End If
        If comn = 37 Then
            commandprompt2000.TextBox1.Text = commandprompt2000.TextBox1.Text + ("The Hidden Hacker: Thats why you gave me time distorter 0.3 yesterday..." & Environment.NewLine)

        End If
        If comn = 43 Then
            commandprompt2000.TextBox1.Text = commandprompt2000.TextBox1.Text + ("The Hidden Hacker: but you said when " & mainname & " gets back we get to time travel together..." & Environment.NewLine)

        End If
        If comn = 47 Then
            commandprompt2000.TextBox1.Text = commandprompt2000.TextBox1.Text + ("12padams: Well no where right now... " & mainname & " only just got back" & Environment.NewLine)

        End If
        If comn = 51 Then
            commandprompt2000.TextBox1.Text = commandprompt2000.TextBox1.Text + ("The Hidden Hacker: Well what do we do now where are we of to?" & Environment.NewLine)

        End If
        If comn = 55 Then
            commandprompt2000.TextBox1.Text = commandprompt2000.TextBox1.Text + ("12padams: Yes It did work... see I told you hidden hacker that it would work." & Environment.NewLine)

        End If
        If comn = 60 Then
            commandprompt2000.TextBox1.Text = commandprompt2000.TextBox1.Text + ("12padams Connected" & Environment.NewLine)

        End If
        If comn = 62 Then
            commandprompt2000.TextBox1.Text = commandprompt2000.TextBox1.Text + ("Ip 185.352.857.342 Connecting..." & Environment.NewLine)

        End If
        If comn = 65 Then
            commandprompt2000.TextBox1.Text = commandprompt2000.TextBox1.Text + ("The Hidden Hacker: Ok he's gunna come now..." & Environment.NewLine)

        End If
        If comn = 78 Then
            commandprompt2000.TextBox1.Text = commandprompt2000.TextBox1.Text + ("The Hidden Hacker: Just wait a sec while I message him." & Environment.NewLine)

        End If
        If comn = 83 Then
            commandprompt2000.TextBox1.Text = commandprompt2000.TextBox1.Text + ("The Hidden Hacker: Ok " & mainname & " I will get 12padams here and tell him the good news" & Environment.NewLine)

        End If
        If comn = 91 Then
            commandprompt2000.TextBox1.Text = commandprompt2000.TextBox1.Text + ("The Hidden Hacker: The time travel from 1999 to 2000 worked without getting stuffed up by the y2k" & Environment.NewLine)

        End If
        If comn = 95 Then
            commandprompt2000.TextBox1.Text = commandprompt2000.TextBox1.Text + ("The Hidden Hacker: Yay it worked perfectly" & Environment.NewLine)

        End If
        If comn = 98 Then
            commandprompt2000.TextBox1.Text = commandprompt2000.TextBox1.Text + ("The Hidden Hacker Connected" & Environment.NewLine)

        End If
        If comn = 99 Then
            commandprompt2000.TextBox1.Text = commandprompt2000.TextBox1.Text + ("IP 146.342.534.632 Connecting..." & Environment.NewLine)

        End If
        If comn = 100 Then
            commandprompt2000.Show()

            commandpromptstartup.Interval = 1000
        End If
        commandprompt2000.TextBox1.SelectionStart = 999999
        commandprompt2000.TextBox1.ScrollToCaret()
        comn = comn - 1
    End Sub

    Private Sub WindowsExplorerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WindowsExplorerToolStripMenuItem.Click
        Dim openinternet As New Internet_Explorer_52001
        openinternet.Show()
        startmenu.Hide()
    End Sub

    Private Sub TimeDistorter03ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimeDistorter03ToolStripMenuItem.Click
        Dim opentime As New timedistorter0
        opentime.Show()
        startmenu.Hide()
    End Sub

    Private Sub RougeScannerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RougeScannerToolStripMenuItem.Click
        Dim opentime As New rougescanner2000
        opentime.Show()
        startmenu.Hide()

    End Sub
End Class