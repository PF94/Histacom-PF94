Public Class _2002_virus_labels
    Dim white As Boolean = True
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If white = True Then
            original.ForeColor = Color.Black
            white = False
        Else
            original.ForeColor = Color.White
            white = True
        End If
    End Sub
End Class