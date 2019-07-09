Public Class Installer98
    Dim programtoinstall As String
    Private Sub Installer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        welcome.Show()
        programtoinstall = installname.Text
        installname.Hide()
        programname.Text = ("Installing " & programtoinstall)
        Label1.Text = ("Welcome To " & programtoinstall)
        Label2.Text = ("You are about to install " & programtoinstall)
        Label3.Text = ("Click Next to continue installing " & programtoinstall)
        Label7.Text = ("Ready to start installing " & programtoinstall)
        Label9.Text = (programtoinstall)
        Label11.Text = ("C:\Program Files\ " & programtoinstall)
        Label13.Text = ("Installing " & programtoinstall & "...")
        Label14.Text = ("Currently Installing " & programtoinstall)
        Label16.Text = (programtoinstall & " was successfully installed.")
        finishinstallimage.Image = installimage.Image
        look.Start()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If Button3.Text = "Finish" Then
            If programtoinstall = "Guess The Number 2" Then
                Me.Close()
                Windows98.GuessTheNumberToolStripMenuItem.Visible = True
            End If
            If programtoinstall = "Start Runner 98" Then
                Me.Close()
                Windows98.StartRunnerToolStripMenuItem.Visible = True
            End If
            If programtoinstall = "Error Blaster 98" Then
                Me.Close()
                Windows98.ErrorBlasterToolStripMenuItem.Visible = True
            End If
            If programtoinstall = "Skindows 95" Then
                Me.Close()
                Windows98.SkindowsToolStripMenuItem.Visible = True
            End If
            If programtoinstall = "Web Chat 1999" Then
                Me.Close()
                Windows98.WebChatToolStripMenuItem.Visible = True
            End If
            If programtoinstall = "Time Distorter 0.2" Then
                Me.Close()
                Windows98.TimeDistorterToolStripMenuItem.Visible = True
            End If
        End If
        If summary.Visible = True And licenseagreement.Visible = False Then
            summary.Hide()
            Button3.Hide()
            Timer1.Start()
        End If
        If licenseagreement.Visible = True And welcome.Visible = False Then
            licenseagreement.Hide()
        End If
        If welcome.Visible = True Then
            welcome.Hide()
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value < 100 Then
            ProgressBar1.Value = ProgressBar1.Value + 1
        End If
        If ProgressBar1.Value = 100 Then
            Button3.Show()
            installerproccess.Hide()
            Button3.Text = "Finish"
            Timer1.Stop()
        End If
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
End Class