Public Class internet_explorer_4

    Private Sub internet_explorer_5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        programtopbar.BackColor = Windows95.exampleprogramtopbar.BackColor
        removewebsites()
        welcomeinternetscreen.Show()
        welcomeinternetscreen.Dock = DockStyle.Fill
        look.Start()
        Button26.Hide()
        Label57.Hide()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        removewebsites()
        padamsbackgrounds.Dock = DockStyle.None
        hotmailmain.Dock = DockStyle.None
        padamsmain.Dock = DockStyle.None
        googlealpha.Dock = DockStyle.None
        googlemain.Dock = DockStyle.None
        googleprototype.Dock = DockStyle.None
        welcomeinternetscreen.Dock = DockStyle.None

        If addressbar.Text = "www.google.com" Then
            googlemain.Dock = DockStyle.Fill
            googlemain.Show()
        End If
        If addressbar.Text = "www.microsoft.com/internetexplorer5/welcome" Then
            welcomeinternetscreen.Dock = DockStyle.Fill
            welcomeinternetscreen.Show()
        End If
        If addressbar.Text = "www.google.stanford.edu" Then
            googleprototype.Dock = DockStyle.Fill
            googleprototype.Show()
        End If
        If addressbar.Text = "www.alpha.google.com" Then
            googlealpha.Dock = DockStyle.Fill
            googlealpha.Show()
        End If
        If addressbar.Text = "www.12padams.com" Then
            padamsmain.Dock = DockStyle.Fill
            padamsmain.Show()
        End If
        If addressbar.Text = "www.hotmail.com" Then
            hotmailmain.Dock = DockStyle.Fill
            hotmailmain.Show()
        End If
        If addressbar.Text = "www.12padams.com/backgrounds" Then
            padamsbackgrounds.Dock = DockStyle.Fill
            padamsbackgrounds.Show()
        End If

        If addressbar.Text = "www.12padams.com/skindows" Then
            skindows95advertisment.Dock = DockStyle.Fill
            skindows95advertisment.Show()
        End If

    End Sub

    Private Sub googleprototypelink_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles googleprototypelink.LinkClicked
        removewebsites()
        googleprototype.Dock = DockStyle.Fill
        googleprototype.Show()
        addressbar.Text = "www.google.stanford.edu"
    End Sub


    Private Sub googlebetalink_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles googlebetalink.LinkClicked
        removewebsites()
        googlealpha.Dock = DockStyle.Fill
        googlealpha.Show()
        addressbar.Text = "www.alpha.google.com"
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        removewebsites()
        addressbar.Text = "www.microsoft.com/internetexplorer5/welcome"
        welcomeinternetscreen.Dock = DockStyle.Fill
        welcomeinternetscreen.Show()
    End Sub

    Private Sub LinkLabel15_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel15.LinkClicked
        removewebsites()
        addressbar.Text = "www.google.com"
        googlemain.Dock = DockStyle.Fill
        googlemain.Show()
    End Sub

    Private Sub LinkLabel16_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel16.LinkClicked
        removewebsites()
        addressbar.Text = "www.12padams.com"
        padamsmain.Dock = DockStyle.Fill
        padamsmain.Show()
    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        Dim opendownload As New downloader95
        opendownload.Show()
        opendownload.Label2.Text = "Downloading: Guess The Number"
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        Dim opendownload As New downloader95
        opendownload.Show()
        opendownload.Label2.Text = "Downloading: Start Runner"
    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        Dim opendownload As New downloader95
        opendownload.Show()
        opendownload.Label2.Text = "Downloading: Error Blaster"
    End Sub

    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button19.Click
        Previewimage.Image = win95background.Image
    End Sub

    Private Sub Button22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button22.Click
        Previewimage.Image = mclarinflimage.Image
    End Sub

    Private Sub Button20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button20.Click
        Windows95.desktopicons.BackgroundImage = win95background.Image
        Dim w, h As Integer
        w = Windows95.desktopicons.Width
        h = Windows95.desktopicons.Height
        Dim bmp As Bitmap = New Bitmap(w, h)
        Using g As Graphics = Graphics.FromImage(bmp)
            g.DrawImage(Windows95.desktopicons.BackgroundImage, 0, 0, bmp.Width, bmp.Height)
        End Using
        Windows95.BackgroundImage = bmp
        Windows95.desktopicons.BackgroundImage = bmp
    End Sub

    Private Sub Button21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button21.Click
        Windows95.desktopicons.BackgroundImage = mclarinflimage.Image
        Dim w, h As Integer
        w = Windows95.desktopicons.Width
        h = Windows95.desktopicons.Height
        Dim bmp As Bitmap = New Bitmap(w, h)
        Using g As Graphics = Graphics.FromImage(bmp)
            g.DrawImage(Windows95.desktopicons.BackgroundImage, 0, 0, bmp.Width, bmp.Height)
        End Using
        Windows95.BackgroundImage = bmp
        Windows95.desktopicons.BackgroundImage = bmp
    End Sub

    Private Sub LinkLabel17_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel17.LinkClicked
        removewebsites()
        addressbar.Text = "www.hotmail.com"
        hotmailmain.Dock = DockStyle.Fill
        hotmailmain.Show()
    End Sub

    Private Sub Button23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button23.Click
        removewebsites()
        addressbar.Text = "www.12padams.com/backgrounds"
        padamsbackgrounds.Dock = DockStyle.Fill
        padamsbackgrounds.Show()
    End Sub
    Private Sub removewebsites()
        googlemain.Hide()
        welcomeinternetscreen.Hide()
        googleprototype.Hide()
        googlealpha.Hide()
        padamsmain.Hide()
        hotmailmain.Hide()
        padamsbackgrounds.Hide()
        skindows95advertisment.Hide()
        secretwebsite.Hide()
        padamshidden.Hide()
        email1.Hide()
        email2.Hide()
        email3.Hide()
        hotmailpadams.Hide()
    End Sub

    Private Sub look_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles look.Tick
        Me.programtopbar.BackColor = Windows95.exampleprogramtopbar.BackColor
        Me.programtopbar.BackgroundImage = Windows95.exampleprogramtopbar.BackgroundImage
        Me.programname.BackColor = Windows95.exampleprogramtext.BackColor
        If close_everything_.timesoftware = "yes" Then
            Button26.Show()
            Label57.Show()
        End If
    End Sub

    Private Sub Button24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button24.Click
        removewebsites()
        addressbar.Text = "www.12padams.com/skindows"
        skindows95advertisment.Dock = DockStyle.Fill
        skindows95advertisment.Show()
    End Sub

    Private Sub Button25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button25.Click
        Dim opendownload As New downloader95
        opendownload.Show()
        opendownload.Label2.Text = "Downloading: Web Chat"
    End Sub

    Private Sub Label20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label20.Click
        removewebsites()
        addressbar.Text = "www.12padams.com/???"
        padamshidden.Dock = DockStyle.Fill
        padamshidden.Show()
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        removewebsites()
        addressbar.Text = "www.???.com"
        secretwebsite.Dock = DockStyle.Fill
        secretwebsite.Show()
    End Sub

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        If txtloginname.Text = "12padams@hotmail.com" And txtpassword.Text = "projectdeath" Then
            removewebsites()
            addressbar.Text = "www.hotmail.com/seculink/145624987903246EGS4HFO954325UPWEM5N8BSSA5634S"
            hotmailpadams.Show()
            hotmailpadams.Dock = DockStyle.Fill
        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        If ListBox1.SelectedItem = "12padams.com datalog 1998" Then
            email1.Show()
            email2.Hide()
            email3.hide()
        End If
        If ListBox1.SelectedItem = "What's the secret to your website?" Then
            email1.Hide()
            email2.Hide()
            email3.Show()
        End If
        If ListBox1.SelectedItem = "RE: What's the secrect to your website?" Then
            email1.Hide()
            email3.Hide()
            email2.Show()
        End If

    End Sub

    Private Sub LinkLabel18_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel18.LinkClicked
        Dim opendownload As New downloader95
        opendownload.Show()
        opendownload.Label2.Text = "Downloading: hwcv.exe"
    End Sub

    Private Sub Button26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button26.Click
        Dim opendownload As New downloader95
        opendownload.Show()
        opendownload.Label2.Text = "Downloading: Time Distorter"
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

    Private Sub minimizebutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles minimizebutton.Click
        Me.Hide()
    End Sub
End Class