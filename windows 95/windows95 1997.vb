Public Class windows95_1997
    Dim count As Integer
    Dim txtcount As Integer
    Dim usersave As String

    Private Sub windows95_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Click
        startmenu.Hide()
    End Sub

    Private Sub windows95_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        desktopicons.Show()
        If My.Resources.windows95bootsound.CanRead Then
            Dim bStr(My.Resources.windows95bootsound.Length) As Byte
            My.Resources.windows95bootsound.Read(bStr, 0, My.Resources.windows95bootsound.Length)
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
        My.Computer.Audio.Play(My.Resources._01_Prisoner_of_Love, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub NotePadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NotePadToolStripMenuItem.Click
        Dim opennotepad As New formnotepad
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
                    Dim openinternet As New internet_explorer_4
                    openinternet.Show()
                End If
                If objListViewItem.Text = "Guess The Number Setup" Then

                    Dim openinstall As New Installer95
                    openinstall.installname.Text = "Guess The Number"
                    openinstall.installimage.Image = My.Resources.Guess_the_Number__install_
                    openinstall.Show()
                End If
                If objListViewItem.Text = "Start Runner Setup" Then

                    Dim openinstall As New Installer95
                    openinstall.installname.Text = "Start Runner"
                    openinstall.installimage.Image = My.Resources.start_run__install___white_with_programname_
                    openinstall.Show()
                End If
                If objListViewItem.Text = "Error Blaster Setup" Then

                    Dim openinstall As New Installer95
                    openinstall.installname.Text = "Error Blaster"
                    openinstall.installimage.Image = My.Resources.error_blast__big_
                    openinstall.Show()
                End If
                If objListViewItem.Text = "Skindows 95 Setup" Then

                    Dim openinstall As New Installer95
                    openinstall.installname.Text = "Skindows 95"
                    openinstall.installimage.Image = My.Resources.skindows_95__install_
                    openinstall.Show()
                End If
                If objListViewItem.Text = "Web Chat Setup" Then

                    Dim openinstall As New Installer95
                    openinstall.installname.Text = "Web Chat"
                    openinstall.installimage.Image = My.Resources.chat__big_
                    openinstall.Show()
                End If
                If objListViewItem.Text = "hwcv.exe" Then
                    Dim openhwcv As New hwcv
                    openhwcv.Show()
                End If
                If objListViewItem.Text = "Time Distorter Setup" Then

                    Dim openinstall As New Installer95
                    openinstall.installname.Text = "Time Distorter"
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
        program.Dock = DockStyle.None
    End Sub

    Private Sub maximizebutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles maximizebutton.Click
        program.Dock = DockStyle.Fill
    End Sub

    Private Sub startbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles startbutton.Click
        startmenu.Show()
        startmenu.BringToFront()
        My.Computer.Audio.Play(My.Resources._01_Prisoner_of_Love, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub PropertiesToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PropertiesToolStripMenuItem1.Click
        Dim oform As New formDisplayproperties
        oform.Show()
        startmenu.Hide()
    End Sub

    Private Sub ShutdownToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShutdownToolStripMenuItem1.Click
        Me.Close()
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
        Dim openinternetexplorer As New internet_explorer_4
        openinternetexplorer.Show()
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

    Private Sub WindowsExplorerToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WindowsExplorerToolStripMenuItem1.Click
        Dim openexplorer As New windows_explorer
        openexplorer.Show()
        startmenu.Hide()
    End Sub

    Private Sub GuessTheNumberToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuessTheNumberToolStripMenuItem.Click
        Dim openguessnumber As New Guess_The_Number_app()
        openguessnumber.Show()
        startmenu.Hide()
    End Sub

    Private Sub StartRunnerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StartRunnerToolStripMenuItem.Click
        Dim openstartrunner As New Start_Runner
        openstartrunner.Show()
        startmenu.Hide()
    End Sub

    Private Sub ErrorBlasterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ErrorBlasterToolStripMenuItem.Click
        Dim openerror As New errorblaster95
        openerror.Show()
        startmenu.Hide()
    End Sub

    Private Sub desktopicons_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles desktopicons.SelectedIndexChanged

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

    Private Sub TimeDistorterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimeDistorterToolStripMenuItem.Click
        Dim opentimedistorter As New time_distorter
        opentimedistorter.Show()
        startmenu.Hide()
    End Sub

    Private Sub taskbartime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles taskbartime.Click
        Dim showmess As New windows95messagebox
        showmess.infomessage.Text = "Your save code is: lodhe8je"
        showmess.Show()
    End Sub
End Class

