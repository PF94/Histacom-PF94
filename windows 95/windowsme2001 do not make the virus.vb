Public Class windowsxp2001_do_not_make_the_virus
    Dim convasationnumber As Integer
    Dim count As Integer
    Dim txtcount As Integer
    Dim usersave As String

    'NEED TO DEBUG THAT I SHOW YOU

    Private Sub windows95_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Click
        startmenu.Hide()
    End Sub

    Private Sub windows95_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        desktopicons.Show()
        hwcv2001.Show()
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
        Me.desktopicons.BackgroundImage = My.Resources.windows_me_background_color
        Dim w, h As Integer
        w = Me.desktopicons.Width
        h = Me.desktopicons.Height
        Dim bmp As Bitmap = New Bitmap(w, h)
        Using g As Graphics = Graphics.FromImage(bmp)
            g.DrawImage(Me.desktopicons.BackgroundImage, 0, 0, bmp.Width, bmp.Height)
        End Using
        Me.BackgroundImage = bmp
        Me.desktopicons.BackgroundImage = bmp
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
        End If
        If Not IsNothing(objListViewItem) Then
            If objListViewItem.Text = "Internet Explorer" Then
                Dim openinternet As New internet_explorer_52001
                openinternet.Show()
                startmenu.Hide()
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
            If objListViewItem.Text = "Web Chat Setup" Then

                Dim openinstall As New installer2000
                openinstall.installname.Text = "Web Chat"
                openinstall.installimage.Image = My.Resources.chat__big_
                openinstall.Show()
            End If
            If objListViewItem.Text = "hwcv.exe" Then
                Dim openhwcv As New hwcv
                openhwcv.Show()
            End If
            If objListViewItem.Text = "sodoku" Then

                Dim openinstall As New installer2000
                openinstall.installname.Text = "sodoku"
                openinstall.installimage.Image = My.Resources.welcome_to_soduku
                openinstall.Show()
            End If
            If objListViewItem.Text = "Time Distorter Setup" Then

                Dim openinstall As New installer2000
                openinstall.installname.Text = "Time Distorter"
                openinstall.installimage.Image = My.Resources.time_distorter__install_Black_
                openinstall.Show()
            End If
            If objListViewItem.Text = "hwcv2001.exe" Then
                Dim openhwcv As New hwcv2001
                openhwcv.Show()
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
        Dim openpaint As New paint
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
        Dim openchat As New Webchat1998
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
        showmess.infomessage.Text = "Your save code is: f2j349qs"
        showmess.Show()
    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        Title_Screen.Close()
    End Sub

    Private Sub WindowsExplorerToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WindowsExplorerToolStripMenuItem.Click
        Dim openinternet As New internet_explorer_52001
        openinternet.Show()
        startmenu.Hide()
    End Sub

    Private Sub commanddelay_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles commanddelay.Tick
        commandprompt2000.Show()
        convasationnumber = 0
        commandprompt2000.TextBox1.Text = ""
        commanddelay.Stop()
        convasation.Start()



    End Sub

    Private Sub convasation_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles convasation.Tick


        If convasationnumber = 39 Then
            commandprompt2000.Close()
        End If
        If convasationnumber = 36 Then
            commandprompt2000.TextBox1.Text = commandprompt2000.TextBox1.Text + ("The Hidden Hacker Disconnected" & Environment.NewLine)
        End If
        If convasationnumber = 32 Then
            commandprompt2000.TextBox1.Text = commandprompt2000.TextBox1.Text + ("The Hidden Hacker" & mainname & "hope for the best" & Environment.NewLine)
        End If
        If convasationnumber = 27 Then
            commandprompt2000.TextBox1.Text = commandprompt2000.TextBox1.Text + ("The Hidden Hacker: Ill meet you there " & mainname & ", bye" & Environment.NewLine)
        End If
        If convasationnumber = 22 Then
            commandprompt2000.TextBox1.Text = commandprompt2000.TextBox1.Text + ("The Hidden Hacker: I hope he believes us... since he didn't believe me back in this time" & Environment.NewLine)
        End If
        If convasationnumber = 16 Then
            commandprompt2000.TextBox1.Text = commandprompt2000.TextBox1.Text + ("The Hidden Hacker: lets go onto his webchat now and tell him" & Environment.NewLine)
        End If
        If convasationnumber = 11 Then
            commandprompt2000.TextBox1.Text = commandprompt2000.TextBox1.Text + ("The Hidden Hacker: We now have to try to explain all this to 12padams" & Environment.NewLine)
        End If
        If convasationnumber = 5 Then
            commandprompt2000.TextBox1.Text = commandprompt2000.TextBox1.Text + ("The Hidden Hacker: Ok we made to to 2001" & Environment.NewLine)
        End If
        If convasationnumber = 1 Then
            commandprompt2000.TextBox1.Text = commandprompt2000.TextBox1.Text + ("The Hidden Hacker Connected" & Environment.NewLine)
        End If
        If convasationnumber = 0 Then
            commandprompt2000.TextBox1.Text = commandprompt2000.TextBox1.Text + ("Ip 192.424.112.432 Connecting..." & Environment.NewLine)
        End If





        convasationnumber = convasationnumber + 1




        commandprompt2000.TextBox1.SelectionStart = 999999
        commandprompt2000.TextBox1.ScrollToCaret()
    End Sub

    Private Sub taskbartime_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles taskbartime.Click

    End Sub

    Private Sub ToolStripMenuItem46_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem46.Click
        Me.Close()
    End Sub

    Private Sub ToolStripMenuItem43_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem43.Click
        Dim opentime As New windowsmesudoku
        opentime.show
        startmenu.Hide()
    End Sub

    Private Sub desktopicons_Click(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles desktopicons.MouseDown

    End Sub
End Class
