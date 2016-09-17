Public Class FrmAyuda

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Me.Close()
    End Sub

    'Habilita todas las opciones al cerrar la pantalla de ayuda
    Private Sub FrmAyuda_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        habilitar()
    End Sub

    'Desabilita todas las opciones mientras la pantalla de ayuda esté abierta
    Private Sub FrmAyuda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        deshabilitar()
    End Sub
End Class