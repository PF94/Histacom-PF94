Public Class loadsettings

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub

    Private Sub btnhelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhelp.Click
        MessageBox.Show("The username is what you will be called in the game. The year code is the code that you get after clicking the time in the taskbar which is unique for that year.")
    End Sub

    Private Sub btnload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnload.Click
        mainname = txtname.Text
        If txtcode.Text = "ety53g63" Then
            Windows95.Show()
        End If
        If txtcode.Text = "sdu247w4" Then
            Windows98.Show()
        End If
        If txtcode.Text = "bsdn98e5" Then
            Windowsxp2002damaged.Show()
        End If
        If txtcode.Text = "fgsd7f6a" Then
            Windows2000.Show()
        End If
        If txtcode.Text = "2iu35giu" Then
            windows_me.Show()
        End If
        If txtcode.Text = "vistatest" Then
            windowsvista.Show()
        End If
        If txtcode.Text = "f2j349qs" Then
            windowsxp2001_do_not_make_the_virus.Show()
        End If
        If txtcode.Text = "lodhe8je" Then
            Windows95.Show()
        End If
        Me.Hide()
    End Sub
End Class