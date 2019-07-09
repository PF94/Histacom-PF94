Public Class formDisplayproperties

    Private Sub ComboBox5_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox5.SelectedIndexChanged
        If ComboBox5.SelectedItem = "Small Fonts" Then
            fontsizeinfo.Text = "Normal size (96 dpi)"
        End If
        If ComboBox5.SelectedItem = "Large Fonts" Then
            fontsizeinfo.Text = "125% Normal size (120 dpi)"
        End If
    End Sub
    Private Sub TrackBarscreenres_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBarscreenres.Scroll
        If TrackBarscreenres.Value = 1 Then
            screenreslabel.Text = "640 by 480 pixels"
        End If
        If TrackBarscreenres.Value = 2 Then
            screenreslabel.Text = "800 by 512 pixels"
        End If
        If TrackBarscreenres.Value = 3 Then
            screenreslabel.Text = "800 by 600 pixels"
        End If
        If TrackBarscreenres.Value = 4 Then
            screenreslabel.Text = "896 by 600 pixels"
        End If
        If TrackBarscreenres.Value = 5 Then
            screenreslabel.Text = "912 by 642 pixels"
        End If
        If TrackBarscreenres.Value = 6 Then
            screenreslabel.Text = "1024 by 768 pixels"
        End If
        If TrackBarscreenres.Value = 7 Then
            screenreslabel.Text = "1152 by 768 pixels"
        End If
        If TrackBarscreenres.Value = 8 Then
            screenreslabel.Text = "1152 by 864 pixels"
        End If
        If TrackBarscreenres.Value = 9 Then
            screenreslabel.Text = "1280 by 1024 pixels"
        End If
        If TrackBarscreenres.Value = 10 Then
            screenreslabel.Text = "1440 by 900 pixels"
        End If
        If TrackBarscreenres.Value = 11 Then
            screenreslabel.Text = "1600 by 1024 pixels"
        End If
        If TrackBarscreenres.Value = 12 Then
            screenreslabel.Text = "1600 by 1200 pixels"
        End If
    End Sub

    Private Sub colorpalettecbox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles colorpalettecbox.SelectedIndexChanged
        If colorpalettecbox.SelectedItem = "16 Color" Then
            colourpaletepicturebox.Image = My.Resources._16_color
        End If
        If colorpalettecbox.SelectedItem = "256 Color" Then
            colourpaletepicturebox.Image = My.Resources._256_color
        End If
        If colorpalettecbox.SelectedItem = "High Color (16 bit)" Then
            colourpaletepicturebox.Image = My.Resources.high_color
        End If
        If colorpalettecbox.SelectedItem = "True Color (32 bit)" Then
            colourpaletepicturebox.Image = My.Resources.true_color
        End If
    End Sub
    Private Sub Button39_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles form1.Click
        colourselectorexample.Hide()
    End Sub

    Private Sub Whitecs_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Whitecs.Click
        If cboxitemselect.SelectedItem = "Desktop" Then
            appearencesettingspanel.BackColor = Color.White
        End If
        If cboxitemselect.SelectedItem = "Active Title Bar" Then
            exampletopbaractivewindow.BackColor = Color.White
        End If
    End Sub

    Private Sub blackcs_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles blackcs.MouseClick
        If cboxitemselect.SelectedItem = "Desktop" Then
            appearencesettingspanel.BackColor = Color.Black
        End If
        If cboxitemselect.SelectedItem = "Active Title Bar" Then
            exampletopbaractivewindow.BackColor = Color.Black
        End If
    End Sub

    Private Sub lightgreycs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lightgreycs.Click
        If cboxitemselect.SelectedItem = "Desktop" Then
            appearencesettingspanel.BackColor = Color.LightGray
        End If
        If cboxitemselect.SelectedItem = "Active Title Bar" Then
            exampletopbaractivewindow.BackColor = Color.LightGray
        End If
    End Sub

    Private Sub greycs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles greycs.Click
        If cboxitemselect.SelectedItem = "Desktop" Then
            appearencesettingspanel.BackColor = Color.Gray
        End If
        If cboxitemselect.SelectedItem = "Active Title Bar" Then
            exampletopbaractivewindow.BackColor = Color.Gray
        End If
    End Sub

    Private Sub redcs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles redcs.Click
        If cboxitemselect.SelectedItem = "Desktop" Then
            appearencesettingspanel.BackColor = Color.Red
        End If
        If cboxitemselect.SelectedItem = "Active Title Bar" Then
            exampletopbaractivewindow.BackColor = Color.Red
        End If
    End Sub

    Private Sub darkredcs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles darkredcs.Click
        If cboxitemselect.SelectedItem = "Desktop" Then
            appearencesettingspanel.BackColor = Color.DarkRed
        End If
        If cboxitemselect.SelectedItem = "Active Title Bar" Then
            exampletopbaractivewindow.BackColor = Color.DarkRed
        End If
    End Sub

    Private Sub yellowcs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles yellowcs.Click
        If cboxitemselect.SelectedItem = "Desktop" Then
            appearencesettingspanel.BackColor = Color.Yellow
        End If
        If cboxitemselect.SelectedItem = "Active Title Bar" Then
            exampletopbaractivewindow.BackColor = Color.Yellow
        End If
    End Sub

    Private Sub olivecs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles olivecs.Click
        If cboxitemselect.SelectedItem = "Desktop" Then
            appearencesettingspanel.BackColor = Color.Olive
        End If
        If cboxitemselect.SelectedItem = "Active Title Bar" Then
            exampletopbaractivewindow.BackColor = Color.Olive
        End If
    End Sub

    Private Sub limecs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles limecs.Click
        If cboxitemselect.SelectedItem = "Desktop" Then
            appearencesettingspanel.BackColor = Color.Lime
        End If
        If cboxitemselect.SelectedItem = "Active Title Bar" Then
            exampletopbaractivewindow.BackColor = Color.Lime
        End If
    End Sub

    Private Sub forestgreencs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles forestgreencs.Click
        If cboxitemselect.SelectedItem = "Desktop" Then
            appearencesettingspanel.BackColor = Color.ForestGreen
        End If
        If cboxitemselect.SelectedItem = "Active Title Bar" Then
            exampletopbaractivewindow.BackColor = Color.ForestGreen
        End If
    End Sub

    Private Sub cyancs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cyancs.Click
        If cboxitemselect.SelectedItem = "Desktop" Then
            appearencesettingspanel.BackColor = Color.Cyan
        End If
        If cboxitemselect.SelectedItem = "Active Title Bar" Then
            exampletopbaractivewindow.BackColor = Color.Cyan
        End If
    End Sub

    Private Sub tealcs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tealcs.Click
        If cboxitemselect.SelectedItem = "Desktop" Then
            appearencesettingspanel.BackColor = Color.Teal
        End If
        If cboxitemselect.SelectedItem = "Active Title Bar" Then
            exampletopbaractivewindow.BackColor = Color.Teal
        End If
    End Sub

    Private Sub bluecs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bluecs.Click
        If cboxitemselect.SelectedItem = "Desktop" Then
            appearencesettingspanel.BackColor = Color.Blue
        End If
        If cboxitemselect.SelectedItem = "Active Title Bar" Then
            exampletopbaractivewindow.BackColor = Color.Blue
        End If
    End Sub

    Private Sub darkbluecs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles darkbluecs.Click
        If cboxitemselect.SelectedItem = "Desktop" Then
            appearencesettingspanel.BackColor = Color.DarkBlue
        End If
        If cboxitemselect.SelectedItem = "Active Title Bar" Then
            exampletopbaractivewindow.BackColor = Color.DarkBlue
        End If
    End Sub

    Private Sub DarkMagentacs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DarkMagentacs.Click
        If cboxitemselect.SelectedItem = "Desktop" Then
            appearencesettingspanel.BackColor = Color.DarkMagenta
        End If
        If cboxitemselect.SelectedItem = "Active Title Bar" Then
            exampletopbaractivewindow.BackColor = Color.DarkMagenta
        End If
    End Sub

    Private Sub palegreencs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles palegreencs.Click
        If cboxitemselect.SelectedItem = "Desktop" Then
            appearencesettingspanel.BackColor = Color.PaleGreen
        End If
        If cboxitemselect.SelectedItem = "Active Title Bar" Then
            exampletopbaractivewindow.BackColor = Color.PaleGreen
        End If
    End Sub

    Private Sub lightbluecs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lightbluecs.Click
        If cboxitemselect.SelectedItem = "Desktop" Then
            appearencesettingspanel.BackColor = Color.LightBlue
        End If
        If cboxitemselect.SelectedItem = "Active Title Bar" Then
            exampletopbaractivewindow.BackColor = Color.LightBlue
        End If
    End Sub

    Private Sub whitesmokecs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles whitesmokecs.Click
        If cboxitemselect.SelectedItem = "Desktop" Then
            appearencesettingspanel.BackColor = Color.WhiteSmoke
        End If
        If cboxitemselect.SelectedItem = "Active Title Bar" Then
            exampletopbaractivewindow.BackColor = Color.WhiteSmoke
        End If
    End Sub

    Private Sub darkgraycs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles darkgraycs.Click
        If cboxitemselect.SelectedItem = "Desktop" Then
            appearencesettingspanel.BackColor = Color.DarkGray
        End If
        If cboxitemselect.SelectedItem = "Active Title Bar" Then
            exampletopbaractivewindow.BackColor = Color.DarkGray
        End If
    End Sub

    Private Sub magentacs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles magentacs.Click
        If cboxitemselect.SelectedItem = "Desktop" Then
            appearencesettingspanel.BackColor = Color.Magenta
        End If
        If cboxitemselect.SelectedItem = "Active Title Bar" Then
            exampletopbaractivewindow.BackColor = Color.Magenta
        End If
    End Sub

    Private Sub applysettings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles applysettings.Click
        Windows95.BackColor = appearencesettingspanel.BackColor
        Windows95.exampleprogramtopbar.BackColor = exampletopbaractivewindow.BackColor
        Me.programtopbar.BackColor = exampletopbaractivewindow.BackColor
    End Sub

    Private Sub PictureBox13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox13.Click
        colourselectorexample.Show()
    End Sub

    Private Sub formDisplayproperties_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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