Public Class FrmGráfica

    'Llama al procedimiento que habilita las opciones
    Private Sub FrmGráfica_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        habilitar()
    End Sub

    'Desabilita todas las opciones mientras la pantalla de grafica esté abierta
    Private Sub FrmGráfica_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Grafica.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Line 'asigna a la serie 0 el tipo de grafica a lineal
        Grafica.Series(1).ChartType = DataVisualization.Charting.SeriesChartType.Point 'asigna a la serie 1 el tipo de grafica a marcadores
        'Llama al procedimiento que deshabilita todas las opciones
        deshabilitar()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Finalizar()
    End Sub

    Private Sub AcercaDeWinISToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeWinISToolStripMenuItem.Click
        FrmAyuda.Show()
    End Sub

    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click
        GuardarGrafica()
    End Sub
End Class