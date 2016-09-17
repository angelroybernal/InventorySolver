Public Class frmModelos

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnContinuar.Click
        If rdbModulo1.Checked = True Then
            FrmModulo1.Show()
            Me.Hide()
        ElseIf rdbModulo2.Checked = True Then
            frmModulo2.Show()
            Me.Hide()
        ElseIf rdbModulo3.Checked = True Then
            FrmModulo3.Show()
            Me.Hide()
        ElseIf rdbModulo4.Checked = True Then
            FrmModulo4.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        End
    End Sub

    Private Sub AcercaDeWinISToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeWinISToolStripMenuItem.Click
        Ayuda()
    End Sub

    Private Sub frmModelos_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub

End Class