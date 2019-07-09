Public Class downloader2000
    Dim amounttodownload As Integer
    Dim downloadspeed As Integer
    Dim amountdownloaded As Integer

    Private Sub Downloader_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        amountdownloaded = 0
        downloadspeed = 8
        amounttodownload = 100
        Timer1.Start()
        Label3.Text = ("Transfer Speed: " & downloadspeed & " Kilobytes per Second")
        look.Start()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        amountdownloaded = amountdownloaded + downloadspeed
        If downloadspeed > amounttodownload - amountdownloaded Then
            ProgressBar1.Value = 100
            Label1.Text = ("Downloaded " & amountdownloaded & " kb out of " & amounttodownload & " kb")
            If Label2.Text = "Downloading: Survive The Day" Then
                Windows2000.desktopicons.Items.Add("Survive The Day Setup", imageIndex:=11)
            End If
            If Label2.Text = "Downloading: Rouge Scanner" Then
                Windows2000.desktopicons.Items.Add("Rouge Scanner Setup", imageIndex:=12)
            End If
            If Label2.Text = "Downloading: Guess The Number 2" Then
                Windows2000.desktopicons.Items.Add("Guess The Number 2 Setup", imageIndex:=0)
            End If
            If Label2.Text = "Downloading: Start Runner 2000" Then
                Windows2000.desktopicons.Items.Add("Start Runner 2000 Setup", imageIndex:=1)
            End If
            If Label2.Text = "Downloading: Error Blaster 2000" Then
                Windows2000.desktopicons.Items.Add("Error Blaster 2000 Setup", imageIndex:=2)
            End If
            If Label2.Text = "Downloading: Skindows 95" Then
                Windows2000.desktopicons.Items.Add("Skindows 95 Setup", imageIndex:=12)
            End If
            If Label2.Text = "Downloading: Web Chat 2000" Then
                Windows2000.desktopicons.Items.Add("Web Chat 2000 Setup", imageIndex:=3)
            End If
            If Label2.Text = "Downloading: hwcv.exe" Then
                Windows2000.desktopicons.Items.Add("hwcv.exe", imageIndex:=11)
            End If
            If Label2.Text = "Downloading: Time Distorter 0.3" Then
                Windows2000.desktopicons.Items.Add("Time Distorter 0.3 Setup", imageIndex:=5)
            End If
            If Label2.Text = "Downloading: sodoku" Then
                windowsxp2001_do_not_make_the_virus.desktopicons.Items.Add("sodoku", imageIndex:=17)
            End If
            If Label2.Text = "Downloading: hwcv2001.exe" Then
                windowsxp2001_do_not_make_the_virus.desktopicons.Items.Add("hwcv2001.exe", imageIndex:=11)
            End If
            Me.Close()
            Timer1.Stop()
        Else
            ProgressBar1.Maximum = amounttodownload
            ProgressBar1.Value = amountdownloaded
        End If
        Label1.Text = ("Downloaded " & amountdownloaded & " kb out of " & amounttodownload)

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

    Private Sub minimizebutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles minimizebutton.Click

    End Sub
End Class