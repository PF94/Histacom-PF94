Public Class Title_Screen
    Private Sub buttonexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonexit.Click
        Me.Close()
    End Sub

    Private Sub buttonnewgame_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonnewgame.Click
        Windows95.Show()
        Me.Hide()
    End Sub

    Private Sub buttonnewgame_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles buttonnewgame.MouseEnter
        buttonnewgame.Image = My.Resources.msnewgame
    End Sub

    Private Sub buttonnewgame_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles buttonnewgame.MouseLeave
        buttonnewgame.Image = My.Resources.new_game
    End Sub

    Private Sub buttonexit_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles buttonexit.MouseEnter
        buttonexit.Image = My.Resources.msexit
    End Sub

    Private Sub buttonexit_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles buttonexit.MouseLeave
        buttonexit.Image = My.Resources._exit
    End Sub

    Private Sub buttonloadgame_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles buttonloadgame.MouseEnter
        buttonloadgame.Image = My.Resources.msload_game
    End Sub

    Private Sub buttonloadgame_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles buttonloadgame.MouseLeave
        buttonloadgame.Image = My.Resources.load_game
    End Sub

    Private Sub buttonloadgame_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonloadgame.Click
        loadsettings.Show()
    End Sub

    Private Sub Title_Screen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MessageBox.Show("made by 12padams and benpowerman all copyright go to microsoft and google thank you and have a nice day")
    End Sub
End Class