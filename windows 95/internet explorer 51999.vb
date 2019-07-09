﻿Public Class internet_explorer_5

    Private Sub internet_explorer_5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        programtopbar.BackColor = Windows95.exampleprogramtopbar.BackColor
        removewebsites()
        welcomeinternetscreen.Show()
        welcomeinternetscreen.Dock = DockStyle.Fill
        look.Start()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        removewebsites()
        padamsbackground.Dock = DockStyle.None
        hotmailmain.Dock = DockStyle.None
        padamsmain.Dock = DockStyle.None
        googlemain.Dock = DockStyle.None
        googlemain.Dock = DockStyle.None
        welcomeinternetscreen.Dock = DockStyle.None

        If addressbar.Text = "www.google.com" Then
            googlemain.Dock = DockStyle.Fill
            googlemain.Show()
        End If
        If addressbar.Text = "www.microsoft.com/internetexplorer5/welcome" Then
            welcomeinternetscreen.Dock = DockStyle.Fill
            welcomeinternetscreen.Show()
        End If
        If addressbar.Text = "www.12padams.com" Then
            padamsmain.Dock = DockStyle.Fill
            padamsmain.Show()
        End If
        If addressbar.Text = "www.hotmail.com" Then
            hotmailmain.Dock = DockStyle.Fill
            hotmailmain.Show()
        End If
        If addressbar.Text = "www.12padams.com/background" Then
            padamsbackground.Dock = DockStyle.Fill
            padamsbackground.Show()
        End If

        If addressbar.Text = "www.12padams.com/skindows" Then
            skindows98advertisment.Dock = DockStyle.Fill
            skindows98advertisment.Show()
        End If
        If addressbar.Text = "www.12padams.com/y2k" Then
            padamsNewsstorys.Dock = DockStyle.Fill
            padamsNewsstorys.Show()
        End If
        If addressbar.Text = "www.12padams.com/microsoftwindowshistory" Then
            padamscomputerhistorymicrosoft.Dock = DockStyle.Fill
            padamscomputerhistorymicrosoft.Show()
        End If


    End Sub


    Private Sub googlebetalink_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        removewebsites()
        googlemain.Dock = DockStyle.Fill
        googlemain.Show()
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
        Dim opendownload As New Downloader98
        opendownload.Show()
        opendownload.Label2.Text = "Downloading: Guess The Number 2"
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        Dim opendownload As New Downloader98
        opendownload.Show()
        opendownload.Label2.Text = "Downloading: Start Runner 98"
    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        Dim opendownload As New Downloader98
        opendownload.Show()
        opendownload.Label2.Text = "Downloading: Error Blaster 98"
    End Sub

    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        previewimage.Image = My.Resources.windows_95_background
    End Sub

    Private Sub Button22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        previewimage.Image = My.Resources._1994_mclaren_f1
    End Sub

    Private Sub Button20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        windows98.BackgroundImage = My.Resources.windows_95_background
    End Sub

    Private Sub Button21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        windows98.BackgroundImage = My.Resources._1994_mclaren_f1
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
        padamsbackground.Dock = DockStyle.Fill
        padamsbackground.Show()
    End Sub
    Private Sub removewebsites()
        googlemain.Hide()
        welcomeinternetscreen.Hide()
        googlemain.Hide()
        padamsmain.Hide()
        hotmailmain.Hide()
        padamsbackground.Hide()
        padamsbackground.Hide()
        skindows98advertisment.Hide()
        padamshidden.Hide()
        email1.Hide()
        email2.Hide()
        email3.Hide()
        hotmailpadams.Hide()
        padamsNewsstorys.Hide()
        padamscomputerhistorymicrosoft.Hide()
    End Sub

    Private Sub Button24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button24.Click
        removewebsites()
        addressbar.Text = "www.12padams.com/skindows"
        skindows98advertisment.Dock = DockStyle.Fill
        skindows98advertisment.Show()
    End Sub

    Private Sub Button25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button25.Click
        Dim opendownload As New Downloader98
        opendownload.Show()
        opendownload.Label2.Text = "Downloading: Web Chat 1999"
    End Sub

    Private Sub Label20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label20.Click
        removewebsites()
        addressbar.Text = "www.12padams.com/???"
        padamshidden.Dock = DockStyle.Fill
        padamshidden.Show()
    End Sub

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
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
        Dim opendownload As New Downloader98
        opendownload.Show()
        opendownload.Label2.Text = "Downloading: hwcv.exe"
    End Sub

    Private Sub Button26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim opendownload As New Downloader98
        opendownload.Show()
        opendownload.Label2.Text = "Downloading: Time Distorter"
    End Sub

    Private Sub LinkLabel20_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel20.LinkClicked
        removewebsites()
        addressbar.Text = "www.12padams.com/y2k"
        padamsNewsstorys.Dock = DockStyle.Fill
        padamsNewsstorys.Show()
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        removewebsites()
        addressbar.Text = "www.12padams.com"
        padamsmain.Dock = DockStyle.Fill
        padamsmain.Show()
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        removewebsites()
        addressbar.Text = "www.12padams.com"
        padamsmain.Dock = DockStyle.Fill
        padamsmain.Show()
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        removewebsites()
        addressbar.Text = "www.12padams.com"
        padamsmain.Dock = DockStyle.Fill
        padamsmain.Show()
    End Sub

    Private Sub Button29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button29.Click
        removewebsites()
        addressbar.Text = "www.12padams.com"
        padamsmain.Dock = DockStyle.Fill
        padamsmain.Show()
    End Sub

    Private Sub LinkLabel19_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel19.LinkClicked
        removewebsites()
        addressbar.Text = "www.12padams.com/microsoftwindowshistory"
        padamscomputerhistorymicrosoft.Dock = DockStyle.Fill
        padamscomputerhistorymicrosoft.Show()
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

    Private Sub Button30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button30.Click
        removewebsites()
        addressbar.Text = "www.12padams.com"
        padamsmain.Dock = DockStyle.Fill
        padamsmain.Show()
    End Sub

    Private Sub Button28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button28.Click
        previewimage.Image = My.Resources.windows_98_background
    End Sub

    Private Sub Button26_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button26.Click
        previewimage.Image = My.Resources._1999_sky
    End Sub

    Private Sub Button27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button27.Click
        windows98.desktopicons.BackgroundImage = My.Resources.windows_98_background
        Dim w, h As Integer
        w = windows98.desktopicons.Width
        h = windows98.desktopicons.Height
        Dim bmp As Bitmap = New Bitmap(w, h)
        Using g As Graphics = Graphics.FromImage(bmp)
            g.DrawImage(windows98.desktopicons.BackgroundImage, 0, 0, bmp.Width, bmp.Height)
        End Using
        windows98.BackgroundImage = bmp
        windows98.desktopicons.BackgroundImage = bmp
    End Sub

    Private Sub Button18_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        Windows98.desktopicons.BackgroundImage = My.Resources._1999_sky
        Dim w, h As Integer
        w = windows98.desktopicons.Width
        h = windows98.desktopicons.Height
        Dim bmp As Bitmap = New Bitmap(w, h)
        Using g As Graphics = Graphics.FromImage(bmp)
            g.DrawImage(windows98.desktopicons.BackgroundImage, 0, 0, bmp.Width, bmp.Height)
        End Using
        windows98.BackgroundImage = bmp
        windows98.desktopicons.BackgroundImage = bmp
    End Sub

End Class