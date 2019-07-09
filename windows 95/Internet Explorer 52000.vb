Public Class Internet_Explorer_52000
    Dim randomnumb As New Random
    Dim chosencolor As Integer
    Dim randomnumb2 As New Random
    Dim chosencolor2 As Integer
    Private Sub internet_explorer_5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        programtopbar.BackColor = Windows2000.exampleprogramtopbar.BackColor
        removewebsites()
        welcomeinternetscreen.Show()
        welcomeinternetscreen.Dock = DockStyle.Fill
        look.Start()
        rainbowbuttonflash.Start()
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

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles guessthenumberdownloadbutton.Click
        Dim opendownload As New downloader2000
        opendownload.Show()
        opendownload.Label2.Text = "Downloading: Guess The Number 2"
    End Sub

    Private Sub startrybber_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles startrunnerbutton.Click
        Dim opendownload As New downloader2000
        opendownload.Show()
        opendownload.Label2.Text = "Downloading: Start Runner 2000"
    End Sub

    Private Sub errorblaster_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles errorblasterbutton.Click
        Dim opendownload As New downloader2000
        opendownload.Show()
        opendownload.Label2.Text = "Downloading: Error Blaster 2000"
    End Sub

    Private Sub LinkLabel17_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel17.LinkClicked
        removewebsites()
        addressbar.Text = "www.google.com"
        googlemain.Dock = DockStyle.Fill
        googlemain.Show()
    End Sub

    Private Sub Button23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles backgroundsbutton.Click
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

    Private Sub Button24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        removewebsites()
        addressbar.Text = "www.12padams.com/skindows"
        skindows98advertisment.Dock = DockStyle.Fill
        skindows98advertisment.Show()
    End Sub

    Private Sub Button25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles webchatdownloadbutton.Click
        Dim opendownload As New downloader2000
        opendownload.Show()
        opendownload.Label2.Text = "Downloading: Web Chat 2000"
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
            email3.Hide()
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
            meylocation = Windows2000.desktopicons.Height - Me.Height
            mexlocation = Windows2000.desktopicons.Width - Me.Width
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
            w = Windows2000.desktopicons.Width
            h = Windows2000.desktopicons.Height
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
        Me.programtopbar.BackColor = Windows2000.exampleprogramtopbar.BackColor
        Me.programtopbar.BackgroundImage = Windows2000.exampleprogramtopbar.BackgroundImage
        Me.programname.BackColor = Windows2000.exampleprogramtext.BackColor
    End Sub

    Private Sub Button30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button30.Click
        removewebsites()
        addressbar.Text = "www.12padams.com"
        padamsmain.Dock = DockStyle.Fill
        padamsmain.Show()
    End Sub

    Private Sub Button28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button28.Click
        previewimage.Image = My.Resources.Year2000bikebackground
    End Sub

    Private Sub Button26_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button26.Click
        previewimage.Image = My.Resources.sydney_new_years
    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        previewimage.Image = My.Resources.Ps2_wallpaper
    End Sub

    Private Sub Button27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button27.Click
        Windows2000.desktopicons.BackgroundImage = My.Resources.Year2000bikebackground
        Dim w, h As Integer
        w = Windows2000.desktopicons.Width
        h = Windows2000.desktopicons.Height
        Dim bmp As Bitmap = New Bitmap(w, h)
        Using g As Graphics = Graphics.FromImage(bmp)
            g.DrawImage(Windows2000.desktopicons.BackgroundImage, 0, 0, bmp.Width, bmp.Height)
        End Using
        Windows2000.BackgroundImage = bmp
        Windows2000.desktopicons.BackgroundImage = bmp
    End Sub

    Private Sub Button18_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        Windows2000.desktopicons.BackgroundImage = My.Resources.sydney_new_years
        Dim w, h As Integer
        w = Windows2000.desktopicons.Width
        h = Windows2000.desktopicons.Height
        Dim bmp As Bitmap = New Bitmap(w, h)
        Using g As Graphics = Graphics.FromImage(bmp)
            g.DrawImage(Windows2000.desktopicons.BackgroundImage, 0, 0, bmp.Width, bmp.Height)
        End Using
        Windows2000.BackgroundImage = bmp
        Windows2000.desktopicons.BackgroundImage = bmp
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        Windows2000.desktopicons.BackgroundImage = My.Resources.Ps2_wallpaper
        Dim w, h As Integer
        w = Windows2000.desktopicons.Width
        h = Windows2000.desktopicons.Height
        Dim bmp As Bitmap = New Bitmap(w, h)
        Using g As Graphics = Graphics.FromImage(bmp)
            g.DrawImage(Windows2000.desktopicons.BackgroundImage, 0, 0, bmp.Width, bmp.Height)
        End Using
        Windows2000.BackgroundImage = bmp
        Windows2000.desktopicons.BackgroundImage = bmp
    End Sub

    Private Sub bluetheme_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bluetheme.Click
        rainbowtimer.Stop()
        padamsmain.BackColor = Color.RoyalBlue
        gameandsoftwaretop.BackColor = Color.Blue
        gamesandsoftware.BackColor = Color.LightSteelBlue
        customizationstop.BackColor = Color.Blue
        customizations.BackColor = Color.LightSteelBlue
        examplevirusestop.BackColor = Color.Blue
        exampleviruses.BackColor = Color.LightSteelBlue
        websitestop.BackColor = Color.Blue
        websites.BackColor = Color.LightSteelBlue
        newstorystop.BackColor = Color.Blue
        newsstorys.BackColor = Color.LightSteelBlue
        historyofcomputerstop.BackColor = Color.Blue
        historyofcomputers.BackColor = Color.LightSteelBlue
        websitesettingstop.BackColor = Color.Blue
        websitesettings.BackColor = Color.LightSteelBlue
        colorstop.BackColor = Color.Blue
        colors.BackColor = Color.LightSteelBlue
        guessthenumberdownloadbutton.BackColor = Color.DeepSkyBlue
        webchatdownloadbutton.BackColor = Color.DeepSkyBlue
        backgroundsbutton.BackColor = Color.DeepSkyBlue
        startrunnerbutton.BackColor = Color.DeepSkyBlue
        errorblasterbutton.BackColor = Color.DeepSkyBlue
        suvivethedaydownloadbutton.BackColor = Color.DeepSkyBlue
        hoctop.BackColor = Color.Blue
        hoc.BackColor = Color.LightSteelBlue
        newstop.BackColor = Color.Blue
        news.BackColor = Color.LightSteelBlue
        backtop.BackColor = Color.Blue
        back.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub greentheme_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles greentheme.Click
        rainbowtimer.Stop()
        padamsmain.BackColor = Color.PaleGreen
        gameandsoftwaretop.BackColor = Color.Green
        gamesandsoftware.BackColor = Color.Lime
        customizationstop.BackColor = Color.Green
        customizations.BackColor = Color.Lime
        examplevirusestop.BackColor = Color.Green
        exampleviruses.BackColor = Color.Lime
        websitestop.BackColor = Color.Green
        websites.BackColor = Color.Lime
        newstorystop.BackColor = Color.Green
        newsstorys.BackColor = Color.Lime
        historyofcomputerstop.BackColor = Color.Green
        historyofcomputers.BackColor = Color.Lime
        websitesettingstop.BackColor = Color.Green
        websitesettings.BackColor = Color.Lime
        colorstop.BackColor = Color.Green
        colors.BackColor = Color.Lime
        guessthenumberdownloadbutton.BackColor = Color.PaleGreen
        webchatdownloadbutton.BackColor = Color.PaleGreen
        backgroundsbutton.BackColor = Color.PaleGreen
        startrunnerbutton.BackColor = Color.PaleGreen
        errorblasterbutton.BackColor = Color.PaleGreen
        suvivethedaydownloadbutton.BackColor = Color.PaleGreen
        hoctop.BackColor = Color.Green
        hoc.BackColor = Color.Lime
        newstop.BackColor = Color.Green
        news.BackColor = Color.Lime
        backtop.BackColor = Color.Green
        back.BackColor = Color.Lime
    End Sub

    Private Sub redtheme_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles redtheme.Click
        rainbowtimer.Stop()
        padamsmain.BackColor = Color.Maroon
        gameandsoftwaretop.BackColor = Color.Red
        gamesandsoftware.BackColor = Color.IndianRed
        customizationstop.BackColor = Color.Red
        customizations.BackColor = Color.IndianRed
        examplevirusestop.BackColor = Color.Red
        exampleviruses.BackColor = Color.IndianRed
        websitestop.BackColor = Color.Red
        websites.BackColor = Color.IndianRed
        newstorystop.BackColor = Color.Red
        newsstorys.BackColor = Color.IndianRed
        historyofcomputerstop.BackColor = Color.Red
        historyofcomputers.BackColor = Color.IndianRed
        websitesettingstop.BackColor = Color.Red
        websitesettings.BackColor = Color.IndianRed
        colorstop.BackColor = Color.Red
        colors.BackColor = Color.IndianRed
        guessthenumberdownloadbutton.BackColor = Color.OrangeRed
        webchatdownloadbutton.BackColor = Color.OrangeRed
        backgroundsbutton.BackColor = Color.OrangeRed
        startrunnerbutton.BackColor = Color.OrangeRed
        errorblasterbutton.BackColor = Color.OrangeRed
        suvivethedaydownloadbutton.BackColor = Color.OrangeRed
        hoctop.BackColor = Color.Red
        hoc.BackColor = Color.IndianRed
        newstop.BackColor = Color.Red
        news.BackColor = Color.IndianRed
        backtop.BackColor = Color.Red
        back.BackColor = Color.IndianRed
    End Sub

    Private Sub purpletheme_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles purpletheme.Click
        rainbowtimer.Stop()
        padamsmain.BackColor = Color.MediumPurple
        gameandsoftwaretop.BackColor = Color.Purple
        gamesandsoftware.BackColor = Color.Thistle
        customizationstop.BackColor = Color.Purple
        customizations.BackColor = Color.Thistle
        examplevirusestop.BackColor = Color.Purple
        exampleviruses.BackColor = Color.Thistle
        websitestop.BackColor = Color.Purple
        websites.BackColor = Color.Thistle
        newstorystop.BackColor = Color.Purple
        newsstorys.BackColor = Color.Thistle
        historyofcomputerstop.BackColor = Color.Purple
        historyofcomputers.BackColor = Color.Thistle
        websitesettingstop.BackColor = Color.Purple
        websitesettings.BackColor = Color.Thistle
        colorstop.BackColor = Color.Purple
        colors.BackColor = Color.Thistle
        guessthenumberdownloadbutton.BackColor = Color.DarkOrchid
        webchatdownloadbutton.BackColor = Color.DarkOrchid
        backgroundsbutton.BackColor = Color.DarkOrchid
        startrunnerbutton.BackColor = Color.DarkOrchid
        errorblasterbutton.BackColor = Color.DarkOrchid
        suvivethedaydownloadbutton.BackColor = Color.DarkOrchid
        hoctop.BackColor = Color.Purple
        hoc.BackColor = Color.Thistle
        newstop.BackColor = Color.Purple
        news.BackColor = Color.Thistle
        backtop.BackColor = Color.Purple
        back.BackColor = Color.Thistle
    End Sub

    Private Sub greytheme_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles greytheme.Click
        rainbowtimer.Stop()
        padamsmain.BackColor = Color.DimGray
        gameandsoftwaretop.BackColor = Color.Black
        gamesandsoftware.BackColor = Color.Silver
        customizationstop.BackColor = Color.Black
        customizations.BackColor = Color.Silver
        examplevirusestop.BackColor = Color.Black
        exampleviruses.BackColor = Color.Silver
        websitestop.BackColor = Color.Black
        websites.BackColor = Color.Silver
        newstorystop.BackColor = Color.Black
        newsstorys.BackColor = Color.Silver
        historyofcomputerstop.BackColor = Color.Black
        historyofcomputers.BackColor = Color.Silver
        websitesettingstop.BackColor = Color.Black
        websitesettings.BackColor = Color.Silver
        colorstop.BackColor = Color.Black
        colors.BackColor = Color.Silver
        guessthenumberdownloadbutton.BackColor = Color.Gray
        webchatdownloadbutton.BackColor = Color.Gray
        backgroundsbutton.BackColor = Color.Gray
        startrunnerbutton.BackColor = Color.Gray
        errorblasterbutton.BackColor = Color.Gray
        suvivethedaydownloadbutton.BackColor = Color.Gray
        hoctop.BackColor = Color.Black
        hoc.BackColor = Color.Silver
        newstop.BackColor = Color.Black
        news.BackColor = Color.Silver
        backtop.BackColor = Color.Black
        back.BackColor = Color.Silver
    End Sub

    Private Sub pinktheme_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pinktheme.Click
        rainbowtimer.Stop()
        padamsmain.BackColor = Color.PaleVioletRed
        gameandsoftwaretop.BackColor = Color.DeepPink
        gamesandsoftware.BackColor = Color.Pink
        customizationstop.BackColor = Color.DeepPink
        customizations.BackColor = Color.Pink
        examplevirusestop.BackColor = Color.DeepPink
        exampleviruses.BackColor = Color.Pink
        websitestop.BackColor = Color.DeepPink
        websites.BackColor = Color.Pink
        newstorystop.BackColor = Color.DeepPink
        newsstorys.BackColor = Color.Pink
        historyofcomputerstop.BackColor = Color.DeepPink
        historyofcomputers.BackColor = Color.Pink
        websitesettingstop.BackColor = Color.DeepPink
        websitesettings.BackColor = Color.Pink
        colorstop.BackColor = Color.DeepPink
        colors.BackColor = Color.Pink
        guessthenumberdownloadbutton.BackColor = Color.Fuchsia
        webchatdownloadbutton.BackColor = Color.Fuchsia
        backgroundsbutton.BackColor = Color.Fuchsia
        startrunnerbutton.BackColor = Color.Fuchsia
        errorblasterbutton.BackColor = Color.Fuchsia
        suvivethedaydownloadbutton.BackColor = Color.Fuchsia
        hoctop.BackColor = Color.DeepPink
        hoc.BackColor = Color.Pink
        newstop.BackColor = Color.DeepPink
        news.BackColor = Color.Pink
        backtop.BackColor = Color.DeepPink
        back.BackColor = Color.Pink
    End Sub

    Private Sub yellowtheme_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles yellowtheme.Click
        rainbowtimer.Stop()
        padamsmain.BackColor = Color.Gold
        gameandsoftwaretop.BackColor = Color.Goldenrod
        gamesandsoftware.BackColor = Color.Yellow
        customizationstop.BackColor = Color.Goldenrod
        customizations.BackColor = Color.Yellow
        examplevirusestop.BackColor = Color.Goldenrod
        exampleviruses.BackColor = Color.Yellow
        websitestop.BackColor = Color.Goldenrod
        websites.BackColor = Color.Yellow
        newstorystop.BackColor = Color.Goldenrod
        newsstorys.BackColor = Color.Yellow
        historyofcomputerstop.BackColor = Color.Goldenrod
        historyofcomputers.BackColor = Color.Yellow
        websitesettingstop.BackColor = Color.Goldenrod
        websitesettings.BackColor = Color.Yellow
        colorstop.BackColor = Color.Goldenrod
        colors.BackColor = Color.Yellow
        guessthenumberdownloadbutton.BackColor = Color.Khaki
        webchatdownloadbutton.BackColor = Color.Khaki
        backgroundsbutton.BackColor = Color.Khaki
        startrunnerbutton.BackColor = Color.Khaki
        errorblasterbutton.BackColor = Color.Khaki
        suvivethedaydownloadbutton.BackColor = Color.Khaki
        hoctop.BackColor = Color.Goldenrod
        hoc.BackColor = Color.Yellow
        newstop.BackColor = Color.Goldenrod
        news.BackColor = Color.Yellow
        backtop.BackColor = Color.Goldenrod
        back.BackColor = Color.Yellow
    End Sub

    Private Sub rainbowtimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rainbowtimer.Tick
        chosencolor = randomnumb.Next(1, 8)
        If chosencolor = 1 Then
            padamsmain.BackColor = Color.RoyalBlue
            gameandsoftwaretop.BackColor = Color.Blue
            gamesandsoftware.BackColor = Color.LightSteelBlue
            customizationstop.BackColor = Color.Blue
            customizations.BackColor = Color.LightSteelBlue
            examplevirusestop.BackColor = Color.Blue
            exampleviruses.BackColor = Color.LightSteelBlue
            websitestop.BackColor = Color.Blue
            websites.BackColor = Color.LightSteelBlue
            newstorystop.BackColor = Color.Blue
            newsstorys.BackColor = Color.LightSteelBlue
            historyofcomputerstop.BackColor = Color.Blue
            historyofcomputers.BackColor = Color.LightSteelBlue
            websitesettingstop.BackColor = Color.Blue
            websitesettings.BackColor = Color.LightSteelBlue
            colorstop.BackColor = Color.Blue
            colors.BackColor = Color.LightSteelBlue
            guessthenumberdownloadbutton.BackColor = Color.DeepSkyBlue
            webchatdownloadbutton.BackColor = Color.DeepSkyBlue
            backgroundsbutton.BackColor = Color.DeepSkyBlue
            startrunnerbutton.BackColor = Color.DeepSkyBlue
            errorblasterbutton.BackColor = Color.DeepSkyBlue
            suvivethedaydownloadbutton.BackColor = Color.DeepSkyBlue
            hoctop.BackColor = Color.Blue
            hoc.BackColor = Color.LightSteelBlue
            newstop.BackColor = Color.Blue
            news.BackColor = Color.LightSteelBlue
            backtop.BackColor = Color.Blue
            back.BackColor = Color.LightSteelBlue
        End If
        If chosencolor = 2 Then
            padamsmain.BackColor = Color.PaleGreen
            gameandsoftwaretop.BackColor = Color.Green
            gamesandsoftware.BackColor = Color.Lime
            customizationstop.BackColor = Color.Green
            customizations.BackColor = Color.Lime
            examplevirusestop.BackColor = Color.Green
            exampleviruses.BackColor = Color.Lime
            websitestop.BackColor = Color.Green
            websites.BackColor = Color.Lime
            newstorystop.BackColor = Color.Green
            newsstorys.BackColor = Color.Lime
            historyofcomputerstop.BackColor = Color.Green
            historyofcomputers.BackColor = Color.Lime
            websitesettingstop.BackColor = Color.Green
            websitesettings.BackColor = Color.Lime
            colorstop.BackColor = Color.Green
            colors.BackColor = Color.Lime
            guessthenumberdownloadbutton.BackColor = Color.PaleGreen
            webchatdownloadbutton.BackColor = Color.PaleGreen
            backgroundsbutton.BackColor = Color.PaleGreen
            startrunnerbutton.BackColor = Color.PaleGreen
            errorblasterbutton.BackColor = Color.PaleGreen
            suvivethedaydownloadbutton.BackColor = Color.PaleGreen
            hoctop.BackColor = Color.Green
            hoc.BackColor = Color.Lime
            newstop.BackColor = Color.Green
            news.BackColor = Color.Lime
            backtop.BackColor = Color.Green
            back.BackColor = Color.Lime
        End If
        If chosencolor = 3 Then
            padamsmain.BackColor = Color.Maroon
            gameandsoftwaretop.BackColor = Color.Red
            gamesandsoftware.BackColor = Color.IndianRed
            customizationstop.BackColor = Color.Red
            customizations.BackColor = Color.IndianRed
            examplevirusestop.BackColor = Color.Red
            exampleviruses.BackColor = Color.IndianRed
            websitestop.BackColor = Color.Red
            websites.BackColor = Color.IndianRed
            newstorystop.BackColor = Color.Red
            newsstorys.BackColor = Color.IndianRed
            historyofcomputerstop.BackColor = Color.Red
            historyofcomputers.BackColor = Color.IndianRed
            websitesettingstop.BackColor = Color.Red
            websitesettings.BackColor = Color.IndianRed
            colorstop.BackColor = Color.Red
            colors.BackColor = Color.IndianRed
            guessthenumberdownloadbutton.BackColor = Color.OrangeRed
            webchatdownloadbutton.BackColor = Color.OrangeRed
            backgroundsbutton.BackColor = Color.OrangeRed
            startrunnerbutton.BackColor = Color.OrangeRed
            errorblasterbutton.BackColor = Color.OrangeRed
            suvivethedaydownloadbutton.BackColor = Color.OrangeRed
            hoctop.BackColor = Color.Red
            hoc.BackColor = Color.IndianRed
            newstop.BackColor = Color.Red
            news.BackColor = Color.IndianRed
            backtop.BackColor = Color.Red
            back.BackColor = Color.IndianRed
        End If
        If chosencolor = 4 Then
            padamsmain.BackColor = Color.MediumPurple
            gameandsoftwaretop.BackColor = Color.Purple
            gamesandsoftware.BackColor = Color.Thistle
            customizationstop.BackColor = Color.Purple
            customizations.BackColor = Color.Thistle
            examplevirusestop.BackColor = Color.Purple
            exampleviruses.BackColor = Color.Thistle
            websitestop.BackColor = Color.Purple
            websites.BackColor = Color.Thistle
            newstorystop.BackColor = Color.Purple
            newsstorys.BackColor = Color.Thistle
            historyofcomputerstop.BackColor = Color.Purple
            historyofcomputers.BackColor = Color.Thistle
            websitesettingstop.BackColor = Color.Purple
            websitesettings.BackColor = Color.Thistle
            colorstop.BackColor = Color.Purple
            colors.BackColor = Color.Thistle
            guessthenumberdownloadbutton.BackColor = Color.DarkOrchid
            webchatdownloadbutton.BackColor = Color.DarkOrchid
            backgroundsbutton.BackColor = Color.DarkOrchid
            startrunnerbutton.BackColor = Color.DarkOrchid
            errorblasterbutton.BackColor = Color.DarkOrchid
            suvivethedaydownloadbutton.BackColor = Color.DarkOrchid
            hoctop.BackColor = Color.Purple
            hoc.BackColor = Color.Thistle
            newstop.BackColor = Color.Purple
            news.BackColor = Color.Thistle
            backtop.BackColor = Color.Purple
            back.BackColor = Color.Thistle
        End If
        If chosencolor = 5 Then
            padamsmain.BackColor = Color.DimGray
            gameandsoftwaretop.BackColor = Color.Black
            gamesandsoftware.BackColor = Color.Silver
            customizationstop.BackColor = Color.Black
            customizations.BackColor = Color.Silver
            examplevirusestop.BackColor = Color.Black
            exampleviruses.BackColor = Color.Silver
            websitestop.BackColor = Color.Black
            websites.BackColor = Color.Silver
            newstorystop.BackColor = Color.Black
            newsstorys.BackColor = Color.Silver
            historyofcomputerstop.BackColor = Color.Black
            historyofcomputers.BackColor = Color.Silver
            websitesettingstop.BackColor = Color.Black
            websitesettings.BackColor = Color.Silver
            colorstop.BackColor = Color.Black
            colors.BackColor = Color.Silver
            guessthenumberdownloadbutton.BackColor = Color.Gray
            webchatdownloadbutton.BackColor = Color.Gray
            backgroundsbutton.BackColor = Color.Gray
            startrunnerbutton.BackColor = Color.Gray
            errorblasterbutton.BackColor = Color.Gray
            suvivethedaydownloadbutton.BackColor = Color.Gray
            hoctop.BackColor = Color.Black
            hoc.BackColor = Color.Silver
            newstop.BackColor = Color.Black
            news.BackColor = Color.Silver
            backtop.BackColor = Color.Black
            back.BackColor = Color.Silver
        End If
        If chosencolor = 6 Then
            padamsmain.BackColor = Color.PaleVioletRed
            gameandsoftwaretop.BackColor = Color.DeepPink
            gamesandsoftware.BackColor = Color.Pink
            customizationstop.BackColor = Color.DeepPink
            customizations.BackColor = Color.Pink
            examplevirusestop.BackColor = Color.DeepPink
            exampleviruses.BackColor = Color.Pink
            websitestop.BackColor = Color.DeepPink
            websites.BackColor = Color.Pink
            newstorystop.BackColor = Color.DeepPink
            newsstorys.BackColor = Color.Pink
            historyofcomputerstop.BackColor = Color.DeepPink
            historyofcomputers.BackColor = Color.Pink
            websitesettingstop.BackColor = Color.DeepPink
            websitesettings.BackColor = Color.Pink
            colorstop.BackColor = Color.DeepPink
            colors.BackColor = Color.Pink
            guessthenumberdownloadbutton.BackColor = Color.Fuchsia
            webchatdownloadbutton.BackColor = Color.Fuchsia
            backgroundsbutton.BackColor = Color.Fuchsia
            startrunnerbutton.BackColor = Color.Fuchsia
            errorblasterbutton.BackColor = Color.Fuchsia
            suvivethedaydownloadbutton.BackColor = Color.Fuchsia
            hoctop.BackColor = Color.DeepPink
            hoc.BackColor = Color.Pink
            newstop.BackColor = Color.DeepPink
            news.BackColor = Color.Pink
            backtop.BackColor = Color.DeepPink
            back.BackColor = Color.Pink
        End If
        If chosencolor = 7 Then
            padamsmain.BackColor = Color.Gold
            gameandsoftwaretop.BackColor = Color.Goldenrod
            gamesandsoftware.BackColor = Color.Yellow
            customizationstop.BackColor = Color.Goldenrod
            customizations.BackColor = Color.Yellow
            examplevirusestop.BackColor = Color.Goldenrod
            exampleviruses.BackColor = Color.Yellow
            websitestop.BackColor = Color.Goldenrod
            websites.BackColor = Color.Yellow
            newstorystop.BackColor = Color.Goldenrod
            newsstorys.BackColor = Color.Yellow
            historyofcomputerstop.BackColor = Color.Goldenrod
            historyofcomputers.BackColor = Color.Yellow
            websitesettingstop.BackColor = Color.Goldenrod
            websitesettings.BackColor = Color.Yellow
            colorstop.BackColor = Color.Goldenrod
            colors.BackColor = Color.Yellow
            guessthenumberdownloadbutton.BackColor = Color.Khaki
            webchatdownloadbutton.BackColor = Color.Khaki
            backgroundsbutton.BackColor = Color.Khaki
            startrunnerbutton.BackColor = Color.Khaki
            errorblasterbutton.BackColor = Color.Khaki
            suvivethedaydownloadbutton.BackColor = Color.Khaki
            hoctop.BackColor = Color.Goldenrod
            hoc.BackColor = Color.Yellow
            newstop.BackColor = Color.Goldenrod
            news.BackColor = Color.Yellow
            backtop.BackColor = Color.Goldenrod
            back.BackColor = Color.Yellow
        End If
    End Sub

    Private Sub rainbowtheme_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rainbowtheme.Click
        rainbowtimer.Start()
    End Sub

    Private Sub rainbowbuttonflash_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rainbowbuttonflash.Tick
        chosencolor2 = randomnumb2.Next(1, 8)
        If chosencolor2 = 1 Then
            rainbowtheme.BackColor = Color.DimGray
        End If
        If chosencolor2 = 2 Then
            rainbowtheme.BackColor = Color.DeepPink
        End If
        If chosencolor2 = 3 Then
            rainbowtheme.BackColor = Color.Yellow
        End If
        If chosencolor2 = 4 Then
            rainbowtheme.BackColor = Color.Purple
        End If
        If chosencolor2 = 5 Then
            rainbowtheme.BackColor = Color.Blue
        End If
        If chosencolor2 = 6 Then
            rainbowtheme.BackColor = Color.Green
        End If
        If chosencolor2 = 7 Then
            rainbowtheme.BackColor = Color.Red
        End If
    End Sub

    Private Sub suvivethedaydownloadbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles suvivethedaydownloadbutton.Click
        Dim opendownload As New downloader2000
        opendownload.Show()
        opendownload.Label2.Text = "Downloading: Survive The Day"
    End Sub

    Private Sub Button17_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        Dim opendownload As New downloader2000
        opendownload.Show()
        opendownload.Label2.Text = "Downloading: Rouge Scanner"
    End Sub
End Class