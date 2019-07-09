Public Class windowsmesudoku


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


    ' Private attributes
    Private SolutionShown As Boolean = False
    Private SudokuGrid(81) As Integer
    Private SudokuTemp(81) As String
    Private SudokuSolution(81) As String
    'Friend Buttons(81) As Button
    'Friend WithEvents TmpButton As Button
    Private CurButtons(81) As Button
    Private RandNumb As New System.Random(CType(Now.Ticks Mod Int32.MaxValue, Integer))

    Private Sub SudokuForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim i, j, k As Integer
        Dim row, col As Integer

        CurButtons(1) = Button1
        CurButtons(2) = Button2
        CurButtons(3) = Button3
        CurButtons(4) = Button4
        CurButtons(5) = Button5
        CurButtons(6) = Button6
        CurButtons(7) = Button7
        CurButtons(8) = Button8
        CurButtons(9) = Button9
        CurButtons(10) = Button10
        CurButtons(11) = Button11
        CurButtons(12) = Button12
        CurButtons(13) = Button13
        CurButtons(14) = Button14
        CurButtons(15) = Button15
        CurButtons(16) = Button16
        CurButtons(17) = Button17
        CurButtons(18) = Button18
        CurButtons(19) = Button19
        CurButtons(20) = Button20
        CurButtons(21) = Button21
        CurButtons(22) = Button22
        CurButtons(23) = Button23
        CurButtons(24) = Button24
        CurButtons(25) = Button25
        CurButtons(26) = Button26
        CurButtons(27) = Button27
        CurButtons(28) = Button28
        CurButtons(29) = Button29
        CurButtons(30) = Button30
        CurButtons(31) = Button31
        CurButtons(32) = Button32
        CurButtons(33) = Button33
        CurButtons(34) = Button34
        CurButtons(35) = Button35
        CurButtons(36) = Button36
        CurButtons(37) = Button37
        CurButtons(38) = Button38
        CurButtons(39) = Button39
        CurButtons(40) = Button40
        CurButtons(41) = Button41
        CurButtons(42) = Button42
        CurButtons(43) = Button43
        CurButtons(44) = Button44
        CurButtons(45) = Button45
        CurButtons(46) = Button46
        CurButtons(47) = Button47
        CurButtons(48) = Button48
        CurButtons(49) = Button49
        CurButtons(50) = Button50
        CurButtons(51) = Button51
        CurButtons(52) = Button52
        CurButtons(53) = Button53
        CurButtons(54) = Button54
        CurButtons(55) = Button55
        CurButtons(56) = Button56
        CurButtons(57) = Button57
        CurButtons(58) = Button58
        CurButtons(59) = Button59
        CurButtons(60) = Button60
        CurButtons(61) = Button61
        CurButtons(62) = Button62
        CurButtons(63) = Button63
        CurButtons(64) = Button64
        CurButtons(65) = Button65
        CurButtons(66) = Button66
        CurButtons(67) = Button67
        CurButtons(68) = Button68
        CurButtons(69) = Button69
        CurButtons(70) = Button70
        CurButtons(71) = Button71
        CurButtons(72) = Button72
        CurButtons(73) = Button73
        CurButtons(74) = Button74
        CurButtons(75) = Button75
        CurButtons(76) = Button76
        CurButtons(77) = Button77
        CurButtons(78) = Button78
        CurButtons(79) = Button79
        CurButtons(80) = Button80
        CurButtons(81) = Button81
        For i = 1 To 81
            CurButtons(i).Enabled = False
            ''CurButtons(i).Visible = False
        Next i
        'For i = 1 To 81
        'j = Int((i - 1) / 9)
        'k = ((i - 1) Mod 9)
        'row = Int(j / 3)
        'col = Int(k / 3)
        'TmpButton = New Button
        'TmpButton.Text = Trim(i.ToString)
        'TmpButton.Name = "Buttons" + Trim(i.ToString)
        'TmpButton.Location = New Point(16 + (k * 24) + (col * 8), 16 + (j * 24) + (row * 8))
        'TmpButton.Size = New Size(24, 23)
        'TmpButton.SetBounds(16 + (k * 24) + (col * 8), 16 + (j * 24) + (row * 8), 24, 23)
        'TmpButton.Visible = True
        'AddHandler TmpButton.Click, AddressOf Me.SudokuButton_Click
        'Buttons(i) = TmpButton
        'Buttons(i).Visible = True
        'Buttons(i).Update()
        'Buttons(i).Refresh()
        'Next i
    End Sub

    ' ----------------------------------------------------------------------
    ' ROUTINE:      btnNewGame_Click()
    ' DESCRIPTION:  This routine starts a new game.
    ' PARAMETERS:   sender -- sending object
    '               e -- event arguments
    ' RETURN VALUE: None.
    ' ----------------------------------------------------------------------
    Private Sub btnNewGame_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewGame.Click
        While Not CreateSudokuGrid()
        End While
        lblDone.Visible = False
        btnShowSolution.Enabled = True
        btnShowSolution.Text = "Show Solution"
        SolutionShown = False
    End Sub

    ' ----------------------------------------------------------------------
    ' ROUTINE:      btnExit_Click()
    ' DESCRIPTION:  This routine exits the application.
    ' PARAMETERS:   sender -- sending object
    '               e -- event arguments
    ' RETURN VALUE: None.
    ' ----------------------------------------------------------------------
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Close()
    End Sub


    ' ----------------------------------------------------------------------
    ' ROUTINE:      SudokuButton_Click()
    ' DESCRIPTION:  Handles all digital (1-9) value toggle button clicks.
    ' PARAMETERS:   sender -- sending object
    '               e -- event arguments
    ' RETURN VALUE: None.
    ' ----------------------------------------------------------------------
    'Private Sub SudokuButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    Private Sub SudokuButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click, Button2.Click, Button3.Click, Button4.Click, Button5.Click, Button6.Click, Button7.Click, Button8.Click, Button9.Click, Button10.Click, Button11.Click, Button12.Click, Button13.Click, Button14.Click, Button15.Click, Button16.Click, Button17.Click, Button18.Click, Button19.Click, Button20.Click, Button21.Click, Button22.Click, Button23.Click, Button24.Click, Button25.Click, Button26.Click, Button27.Click, Button28.Click, Button29.Click, Button30.Click, Button31.Click, Button32.Click, Button33.Click, Button34.Click, Button35.Click, Button36.Click, Button37.Click, Button38.Click, Button39.Click, Button40.Click, Button41.Click, Button42.Click, Button43.Click, Button44.Click, Button45.Click, Button46.Click, Button47.Click, Button48.Click, Button49.Click, Button50.Click, Button51.Click, Button52.Click, Button53.Click, Button54.Click, Button55.Click, Button56.Click, Button57.Click, Button58.Click, Button59.Click, Button60.Click, Button61.Click, Button62.Click, Button63.Click, Button64.Click, Button65.Click, Button66.Click, Button67.Click, Button68.Click, Button69.Click, Button70.Click, Button71.Click, Button72.Click, Button73.Click, Button74.Click, Button75.Click, Button76.Click, Button77.Click, Button78.Click, Button79.Click, Button80.Click, Button81.Click
        Dim i As Integer
        Dim solFound As Boolean = True
        Dim CurButton As Button = CType(sender, Button)

        If Not SolutionShown Then
            If CurButton.Text = "" Then
                CurButton.Text = "1"
            ElseIf CurButton.Text = "9" Then
                CurButton.Text = ""
            Else
                CurButton.Text = Trim(Str(CInt(CurButton.Text) + 1))
            End If
            For i = 1 To 81
                If CurButtons(i).Text <> SudokuSolution(i) Then
                    solFound = False
                    Exit For
                End If
            Next i
            lblDone.Visible = solFound
        End If
    End Sub

    ' ----------------------------------------------------------------------
    ' ROUTINE:      btnShowSolution_Click()
    ' DESCRIPTION:  This routine shows the solution.
    ' PARAMETERS:   sender -- sending object
    '               e -- event arguments
    ' RETURN VALUE: None.
    ' ----------------------------------------------------------------------
    Private Sub btnShowSolution_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowSolution.Click
        Dim i As Integer

        If SolutionShown Then
            For i = 1 To 81
                CurButtons(i).Text = SudokuTemp(i)
            Next i
            btnShowSolution.Text = "Show Solution"
        Else
            For i = 1 To 81
                SudokuTemp(i) = CurButtons(i).Text
                CurButtons(i).Text = SudokuSolution(i)
            Next i
            btnShowSolution.Text = "Hide Solution"
        End If
        SolutionShown = Not SolutionShown
    End Sub

    ' ----------------------------------------------------------------------
    ' ROUTINE:      CreateSudokuGrid()
    ' DESCRIPTION:  This routine creates a Sudoku grid.
    ' PARAMETERS:   None.
    ' RETURN VALUE: TRUE if grid is solvable, FALSE if not.
    ' ----------------------------------------------------------------------
    Private Function CreateSudokuGrid() As Boolean
        Dim i, j, k As Integer
        Dim numRand As Integer
        Dim CurButton As Button
        Dim ValIsOK(9) As Boolean
        Dim valsOK As Integer = 0

        Cursor.Current = Cursors.WaitCursor
        lblConfiguring.Visible = True
        For i = 1 To 81
            CurButton = CurButtons(i)
            CurButton.Text = ""
            CurButton.BackColor = System.Drawing.Color.LightGray
            CurButton.Visible = False
            SudokuSolution(i) = ""
        Next i
        lblConfiguring.Visible = True
        lblConfiguring.Refresh()
        For i = 1 To 81
            If True Then
                CurButton = CurButtons(i)
                valsOK = GetValidVals(i, ValIsOK)
                If valsOK <= 0 Then
                    Return False
                End If
                numRand = RandNumb.Next(0, valsOK) + 1
                k = 0
                For j = 1 To 9
                    If ValIsOK(j) Then
                        k = k + 1
                        If k = numRand Then
                            Exit For
                        End If
                    End If
                Next j
                CurButton.Text = j.ToString()
                CurButton.BackColor = System.Drawing.Color.Gray
            End If
        Next i
        lblConfiguring.Visible = False
        For i = 1 To 81
            CurButton = CurButtons(i)
            SudokuSolution(i) = CurButton.Text
            numRand = RandNumb.Next(0, spnDifficulty.Value + 1) + 1
            If numRand > 1 Then
                CurButton.Text = ""
                CurButton.BackColor = System.Drawing.Color.LightGray
                CurButton.Enabled = True
            Else
                CurButton.Enabled = False
            End If
            CurButton.Visible = True
        Next i
        Cursor.Current = Cursors.Default
        Return True
    End Function

    ' ----------------------------------------------------------------------
    ' ROUTINE:      GetGridVals()
    ' DESCRIPTION:  This routine creates a Sudoku grid.
    ' PARAMETERS:   Location - grid location to get next value for.
    '               ValidVals - validity checks for 9 possible values.
    ' RETURN VALUE: Number of valid values indicated in ValidVals.
    ' ----------------------------------------------------------------------
    Private Function GetValidVals(ByVal Location As Integer, ByRef ValidVals As Boolean()) As Integer
        Dim i, j, k As Integer
        Dim row, col As Integer
        Dim numStr As String
        Dim numOK As Boolean
        Dim retVal As Integer = 0

        For i = 1 To 9
            numOK = True
            numStr = i.ToString()
            For j = 1 To 9
                k = (Int((Location - 1) / 9) * 9) + j
                If CurButtons(k).Text = numStr Then
                    numOK = False
                    Exit For
                End If
            Next j
            If numOK Then
                For j = 1 To 9
                    k = (((Location - 1) Mod 9) + 1) + ((j - 1) * 9)
                    If CurButtons(k).Text = numStr Then
                        numOK = False
                        Exit For
                    End If
                Next j
            End If
            If numOK Then
                row = Int(Int((Location - 1) / 9) / 3)
                col = Int(((Location - 1) Mod 9) / 3)
                For j = 1 To 9
                    k = (((row * 3) + Int((j - 1) / 3)) * 9) + (col * 3) + ((j - 1) Mod 3) + 1
                    If CurButtons(k).Text = numStr Then
                        numOK = False
                        Exit For
                    End If
                Next j
            End If
            ValidVals(i) = numOK
            If numOK Then
                retVal = retVal + 1
            End If
        Next i
        Return retVal
    End Function
End Class