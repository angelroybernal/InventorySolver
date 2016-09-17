Public Class FrmModulo3

    'Llama al procedimiento que carga los nombres de los parametros de entrada y salida
    Private Sub FrmModulo3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarM3()
        btnResolver.Enabled = False
        btnGráfica.Visible = False
    End Sub

    'Llama al procedimiento que retorna a la pantalla de menu
    Private Sub FrmModulo3_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Salir()
    End Sub

    'LLama al procedimiento para elegir un nuevo modelo
    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        Nuevo()
    End Sub

    'Guarda los resultados en un archivo txt
    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click
        GuardarM3()
    End Sub

    'LLama al procedimiento que limpia todos los resultados
    Private Sub BorrarTodoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BorrarTodoToolStripMenuItem.Click
        LimpiarM3() 'Llamado al procedimiento de limpieza
        btnResolver.Enabled = False
        btnGráfica.Visible = False
        GuardarToolStripMenuItem.Enabled = False
    End Sub

    'Llama al procedimiento que finaliza el programa
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Finalizar()
    End Sub

    'Llama al procedimiento que muestra la ventana de ayuda
    Private Sub AcercaDeWinISToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeWinISToolStripMenuItem.Click
        Ayuda()
    End Sub

    'Valida si los campos estan vacios o son 0
    Private Sub dgwEntrada_RowValidating(sender As Object, e As DataGridViewCellCancelEventArgs) Handles dgwEntrada.RowValidating
        If dgwEntrada.Item(1, 4).Selected = True And Not (Format(dgwEntrada.Item(1, 4).Value, Style:="") = "" Or dgwEntrada.Item(1, 4).Value = Format(0, Style:="")) Then
            dgwEntrada.Item(1, 5).Value = dgwEntrada.Item(1, 0).Value / dgwEntrada.Item(1, 4).Value
        ElseIf dgwEntrada.Item(1, 5).Selected = True And Not (Format(dgwEntrada.Item(1, 5).Value, Style:="") = "" Or dgwEntrada.Item(1, 5).Value = Format(0, Style:="")) Then
            dgwEntrada.Item(1, 4).Value = dgwEntrada.Item(1, 0).Value / dgwEntrada.Item(1, 5).Value
        End If

        If Not (Format(dgwEntrada.Item(1, 0).Value, Style:="") = "" Or dgwEntrada.Item(1, 0).Value = Format(0, Style:="")) And
           Not (Format(dgwEntrada.Item(1, 1).Value, Style:="") = "" Or dgwEntrada.Item(1, 1).Value = Format(0, Style:="")) And
           Not (Format(dgwEntrada.Item(1, 2).Value, Style:="") = "" Or dgwEntrada.Item(1, 2).Value = Format(0, Style:="")) And
           Not (Format(dgwEntrada.Item(1, 3).Value, Style:="") = "" Or dgwEntrada.Item(1, 3).Value = Format(0, Style:="")) And
           Not (Format(dgwEntrada.Item(1, 4).Value, Style:="") = "" Or dgwEntrada.Item(1, 4).Value = Format(0, Style:="")) And
           Not (Format(dgwEntrada.Item(1, 5).Value, Style:="") = "" Or dgwEntrada.Item(1, 5).Value = Format(0, Style:="")) Then
            btnResolver.Enabled = True
        Else
            btnResolver.Enabled = False
        End If
    End Sub

    'LLama al procedimiento que calcula los resultados
    Private Sub btnResolver_Click(sender As Object, e As EventArgs) Handles btnResolver.Click
        solucionM3()
    End Sub

    'Llama al procedimiento que crea la grafica y despliega su pantalla
    Private Sub btnGráfica_Click(sender As Object, e As EventArgs) Handles btnGráfica.Click
        GraficaM3()
        FrmGráfica.Show()
    End Sub

    'Agrega el oontrol de datos que pueden ingresarse en cada celda de la tabla Entrada
    Private Sub dgwEntrada_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles dgwEntrada.EditingControlShowing
        Dim validar As TextBox = CType(e.Control, TextBox) ' referencia a la celda  
        'agrega el controlador de eventos para el KeyPress 
        AddHandler validar.KeyPress, AddressOf ControlDatos
    End Sub

End Class