Public Class Guess_The_Number_98
        Dim thenumber As Integer
        Dim chosencolor As Color
        Dim flashnumb As Integer
        Dim controlpicked As Integer
        Dim controlnumb As New Random
        Dim chosencontrol As Control
        Dim flashgen As New Random
        Dim guessednumb As Integer
        Dim randnumb As New Random

    Private Sub Guess_The_Number_app_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        thenumber = randnumb.Next(1, 101)
        look.Start()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        guessednumb = txtGuessedNumber.Text
        If guessednumb < thenumber Then
            higherorlower.Text = "Higher"
            higherorlower.ForeColor = Color.Blue
        End If
        If guessednumb > thenumber Then
            higherorlower.Text = "Lower"
            higherorlower.ForeColor = Color.Red
        End If
        If guessednumb = thenumber Then
            higherorlower.Text = "Correct"
            higherorlower.ForeColor = Color.Green
            selector.Start()
        End If
    End Sub

        Private Sub flasher_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles flasher.Tick
            flashnumb = flashgen.Next(1, 10)
            If flashnumb = 1 Then
                chosencolor = Color.Red
            End If
            If flashnumb = 2 Then
                chosencolor = Color.Green
            End If
            If flashnumb = 3 Then
                chosencolor = Color.Pink
            End If
            If flashnumb = 4 Then
                chosencolor = Color.Orange
            End If
            If flashnumb = 5 Then
                chosencolor = Color.Aqua
            End If
            If flashnumb = 6 Then
                chosencolor = Color.Gold
            End If
            If flashnumb = 7 Then
                chosencolor = Color.YellowGreen
            End If
            If flashnumb = 8 Then
                chosencolor = Color.Yellow
            End If
            If flashnumb = 9 Then
                chosencolor = Color.Black
            End If
            chosencontrol.BackColor = chosencolor
        End Sub

        Private Sub selector_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles selector.Tick
            controlpicked = controlnumb.Next(1, 10)
            If controlpicked = 1 Then
                chosencontrol = Label1
            End If
            If controlpicked = 2 Then
                chosencontrol = program
            End If
            If controlpicked = 3 Then
                chosencontrol = txtGuessedNumber
            End If
            If controlpicked = 4 Then
                chosencontrol = Button1
            End If
            If controlpicked = 5 Then
                chosencontrol = Button2
            End If
            If controlpicked = 6 Then
                chosencontrol = programtopbar
            End If
            If controlpicked = 7 Then
                chosencontrol = Label2
            End If
            If controlpicked = 8 Then
                chosencontrol = Label3
            End If
            If controlpicked = 9 Then
                chosencontrol = higherorlower
            End If
            flasher.Start()
        End Sub

        Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
            Me.Close()
        Dim openguess As New Guess_The_Number_98
            openguess.Show()
        End Sub


    Private Sub btnveryeasy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnveryeasy.Click
        thenumber = randnumb.Next(1, 10)
        Label1.Text = "I am thinking of a number between 1-10"
        Panel1.Hide()
    End Sub

    Private Sub btneasy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btneasy.Click
        thenumber = randnumb.Next(1, 101)
        Label1.Text = "I am thinking of a number between 1-100"
        Panel1.Hide()
    End Sub

    Private Sub btnmedium_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmedium.Click
        thenumber = randnumb.Next(1, 1001)
        Label1.Text = "I am thinking of a number between 1-1,000"
        Panel1.Hide()
    End Sub

    Private Sub btnhard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhard.Click
        thenumber = randnumb.Next(1, 10001)
        Label1.Text = "I am thinking of a number between 1-10,000"
        Panel1.Hide()
    End Sub

    Private Sub btnveryhard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnveryhard.Click
        thenumber = randnumb.Next(1, 100001)
        Label1.Text = "I am thinking of a number between 1-100,000"
        Panel1.Hide()
    End Sub

    Private Sub btnimpossible_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnimpossible.Click
        thenumber = randnumb.Next(1, 1000001)
        Label1.Text = "I am thinking of a number between 1-1,000,000"
        Panel1.Hide()
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
            meylocation = windows98.desktopicons.Height - Me.Height
            mexlocation = windows98.desktopicons.Width - Me.Width
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
            w = windows98.desktopicons.Width
            h = windows98.desktopicons.Height
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
        Me.programtopbar.BackColor = windows98.exampleprogramtopbar.BackColor
        Me.programtopbar.BackgroundImage = windows98.exampleprogramtopbar.BackgroundImage
        Me.programname.BackColor = windows98.exampleprogramtext.BackColor
    End Sub

    Private Sub minimizebutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles minimizebutton.Click
        Me.Hide()
    End Sub

End Class