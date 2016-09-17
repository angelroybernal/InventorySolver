Public Class frmPresentacion

    Private Sub btnContinuar_Click(sender As Object, e As EventArgs) Handles btnContinuar.Click
        frmModelos.Show()
        Me.Hide()
    End Sub

    Private Sub frmPresentacion_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub

End Class
