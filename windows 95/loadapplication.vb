Public Class loadsettings

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub

    Private Sub btnhelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhelp.Click
        MessageBox.Show("The Application Code is a code that lets you able to use applications from Histacom outside Histacom")
    End Sub

    Private Sub btnload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnload.Click
        mainname = appcode.Text
        If appcode.Text = "Paint" Then
            mspaint.Show()
        End If
        If appcode.Text = "sdu247w4" Then
            Windows98.Show()
        End If
        If appcode.Text = "bsdn98e5" Then
            Windowsxp2002damaged.Show()
        End If
        If appcode.Text = "fgsd7f6a" Then
            Windows2000.Show()
        End If
        If appcode.Text = "2iu35giu" Then
            windows_me.Show()
        End If
        If appcode.Text = "vistatest" Then
            windowsvista.Show()
        End If
        If appcode.Text = "f2j349qs" Then
            windowsxp2001_do_not_make_the_virus.Show()
        End If
        If appcode.Text = "lodhe8je" Then
            Windows95.Show()
        End If
        Me.Hide()
    End Sub
End Class