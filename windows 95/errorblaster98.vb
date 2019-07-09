Public Class errorblaster98
    Dim ran As New Random
    Dim chosenerror As Integer


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim openerror As New windows98messagebox
        chosenerror = ran.Next(1, 9)
        If chosenerror = 1 Then
            openerror.infomessage.Text = "Your Computer Is Infected"
        End If
        If chosenerror = 2 Then
            openerror.infomessage.Text = "Virus Detected"
        End If
        If chosenerror = 3 Then
            openerror.infomessage.Text = "You need to uninfect your computer"
        End If
        If chosenerror = 4 Then
            openerror.infomessage.Text = "your computer is at risk download some program now to fix your comptuer"
        End If
        If chosenerror = 5 Then
            openerror.infomessage.Text = "Your computer is going to explode you need to save all changed now and then take it apart"
        End If
        If chosenerror = 6 Then
            openerror.infomessage.Text = "download an antivirus program now to save your computer"
        End If
        If chosenerror = 7 Then
            openerror.infomessage.Text = "Windows has detected a virus"
        End If
        If chosenerror = 8 Then
            openerror.infomessage.Text = "Your computer is going to be completly taken over if you do not right now downlaod antivirus software"
        End If
        
        openerror.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Timer1.Start()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Timer1.Stop()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub errorblaster_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        look.Start()

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
            meylocation = Windows98.desktopicons.Height - Me.Height
            mexlocation = Windows98.desktopicons.Width - Me.Width
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
            w = Windows98.desktopicons.Width
            h = Windows98.desktopicons.Height
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
        Me.programtopbar.BackColor = Windows98.exampleprogramtopbar.BackColor
        Me.programtopbar.BackgroundImage = Windows98.exampleprogramtopbar.BackgroundImage
        Me.programname.BackColor = Windows98.exampleprogramtext.BackColor
    End Sub

    Private Sub minimizebutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles minimizebutton.Click
        Me.Hide()
    End Sub

End Class