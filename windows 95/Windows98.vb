Public Class Windows98
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
        If My.Resources.windows98bootsound.CanRead Then
            Dim bStr(My.Resources.windows98bootsound.Length) As Byte
            My.Resources.windows98bootsound.Read(bStr, 0, My.Resources.windows98bootsound.Length)
            My.Computer.Audio.Play(bStr, AudioPlayMode.Background)
        End If
        startmenu.Hide()
        program.Hide()
        Timer1.Start()
        exampleprogramtopbar.Show()
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
        System.Windows.Forms.Application.VisualStyleState = VisualStyles.VisualStyleState.NoneEnabled
    End Sub

    Private Sub NotePadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NotePadToolStripMenuItem.Click
        Dim opennotepad As New formnotepad
        opennotepad.Show()
        startmenu.Hide()
    End Sub

    Private Sub Closebutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        program.Hide()
        exampleprogramtext.Text = ""
        program.Size = New Size(367, 253)
    End Sub

    Private Sub fullscreen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        program.Dock = DockStyle.Fill
    End Sub

    Private Sub minimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        program.Dock = DockStyle.None
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
                If objListViewItem.Text = "Web Chat 1999 Setup" Then

                    Dim openinstall As New Installer98
                    openinstall.installname.Text = "Web Chat 1999"
                    openinstall.installimage.Image = My.Resources.chat__big_
                    openinstall.Show()
                End If
                If objListViewItem.Text = "hwcv.exe" Then
                    Dim openhwcv As New hwcv
                    openhwcv.Show()
                End If
                If objListViewItem.Text = "Time Distorter 0.2 Setup" Then

                    Dim openinstall As New Installer98
                    openinstall.installname.Text = "Time Distorter 0.2"
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

    Private Sub minimizebutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        program.Dock = DockStyle.None
    End Sub

    Private Sub maximizebutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        program.Dock = DockStyle.Fill
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles startbutton.Click
        startmenu.Show()
    End Sub

    Private Sub PropertiesToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PropertiesToolStripMenuItem1.Click
        Dim oform As New formDisplayproperties
        oform.Show()
        startmenu.Hide()
    End Sub

    Private Sub ShutdownToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShutdownToolStripMenuItem1.Click
        Title_Screen.Close()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        desktopicons.BackColor = Me.BackColor
        taskbartime.Text = TimeOfDay
    End Sub

    Private Sub PhoneDialerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim openphonedialer As New phone_dialer
        openphonedialer.Show()
        startmenu.Hide()
    End Sub

    Private Sub AddressBookToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddressBookToolStripMenuItem.Click
        Dim openaddressbook As New Address_Book
        openaddressbook.Show()
        startmenu.Hide()
    End Sub

    Private Sub VolumeControlToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VolumeControlToolStripMenuItem.Click
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

    Private Sub WindowsExplorerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WindowsExplorerToolStripMenuItem.Click
        Dim openinternetexplorer As New internet_explorer_5
        openinternetexplorer.Show()
        startmenu.Hide()
    End Sub

    Private Sub FolderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FolderToolStripMenuItem.Click
        desktopicons.Items.Add("New Folder")
    End Sub

    Private Sub desktopicons_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles desktopicons.MouseDown
        startmenu.Hide()

    End Sub

    Private Sub WindowsExplorerToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WindowsExplorerToolStripMenuItem1.Click
        Dim openexplorer As New windows_explorer
        openexplorer.Show()
        startmenu.Hide()
    End Sub

    Private Sub GuessTheNumberToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuessTheNumberToolStripMenuItem.Click
        Dim openguessnumber As New Guess_The_Number_98
        openguessnumber.Show()
        startmenu.Hide()
    End Sub

    Private Sub StartRunnerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StartRunnerToolStripMenuItem.Click
        Dim openstartrunner As New StartRunner98
        openstartrunner.Show()
        startmenu.Hide()
    End Sub

    Private Sub ErrorBlasterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ErrorBlasterToolStripMenuItem.Click
        Dim openerror As New errorblaster98
        openerror.Show()
        startmenu.Hide()
    End Sub

    Private Sub SkindowsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SkindowsToolStripMenuItem.Click
        Dim openskin As New Skindows_95
        openskin.Show()
        startmenu.Hide()
    End Sub

    Private Sub WebChatToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WebChatToolStripMenuItem.Click
        Dim openchat As New WebChat_1999
        openchat.Show()
        startmenu.Hide()
    End Sub

    Private Sub TimeDistorterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimeDistorterToolStripMenuItem.Click
        time_distorter_0.Show()
        startmenu.Hide()
    End Sub

    Private Sub taskbartime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles taskbartime.Click
        Dim showmess As New windows98messagebox
        showmess.infomessage.Text = "Your save code is: sdu247w4"
        showmess.Show()
    End Sub
End Class
