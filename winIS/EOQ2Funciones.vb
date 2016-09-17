Module EOQ2Funciones
    Dim objeto As New frmModulo2
    Dim gf As New FrmGráfica
    Dim tdisp As Single = 0
    Dim tfalt As Single = 0
    Dim tdem As Single = 0

    'Carga los nombres de los parametros de entrada y salida del modulo 2
    Public Sub CargarM2()
        objeto = frmModulo2

        'parametros de entrada, tabla 1
        objeto.dgwEntrada.Rows.Add("Demanda Anual")
        objeto.dgwEntrada.Rows.Add("Costo de pedido")
        objeto.dgwEntrada.Rows.Add("Costo de mantener inventario")
        objeto.dgwEntrada.Rows.Add("Costo de faltante")
        objeto.dgwEntrada.Rows.Add("Costo por unidad (opcional)")
        objeto.dgwEntrada.Rows.Add("Días al año")
        objeto.dgwEntrada.Rows.Add("Demanda diaria")
        objeto.dgwEntrada.Rows.Add("Tiempo de espera (opcional)")

        'Parametros de salida, tabla 2
        objeto.dgwSalida.Rows.Add("Tamaño del pedido optimo")
        objeto.dgwSalida.Rows.Add("Pedido pendiente")
        objeto.dgwSalida.Rows.Add("Inventario máximo")
        objeto.dgwSalida.Rows.Add("Número de pedidos")
        objeto.dgwSalida.Rows.Add("Tiempo de ciclo")
        objeto.dgwSalida.Rows.Add("Punto de reorden")
        objeto.dgwSalida.Rows.Add("")
        objeto.dgwSalida.Rows.Add("Costo de la politica")

        'Cambia el tipo y tamaño de fuente de las tablas
        objeto.dgwEntrada.Font = New Font("Segoe Ui", 10)
        objeto.dgwSalida.Font = New Font("Segoe Ui", 10)
    End Sub

    'Calcula los resultados del modulo 2 con los datos de entrada proporcionados
    Public Sub calculoM2()
        Dim parametros(8) As Single
        Dim cont As Integer = 0

        'toma los valores de la tabla entradas y los almacena en un arreglo
        While cont < 8
            parametros(cont) = objeto.dgwEntrada.Item(1, cont).Value
            cont = cont + 1
        End While

        'Envia el arreglo como parametro a la clase EOQ2 y asigna los resultados a la tabla salida
        Dim objeto2 As New EOQ2(parametros)
        objeto.dgwSalida.Item(1, 0).Value = objeto2.TamañoPedido()
        objeto.dgwSalida.Item(1, 1).Value = objeto2.PedidosPendientes()
        objeto.dgwSalida.Item(1, 2).Value = objeto2.InventarioMaximo()
        objeto.dgwSalida.Item(1, 3).Value = objeto2.Npedidos()
        objeto.dgwSalida.Item(1, 4).Value = objeto2.TiempoCiclo()
        objeto.dgwSalida.Item(1, 5).Value = objeto2.PuntoReorden()
        objeto.dgwSalida.Item(1, 7).Value = "$" + Format(objeto2.CostoPolitica(), Style:="")
        tdisp = objeto2.TiempoDisponibilidad()
        tfalt = objeto2.TiempoFaltante()
        tdem = objeto.dgwEntrada.Item(1, 7).Value
    End Sub

    'Valida los campos y calcula la respuesta
    Public Sub solucionM2()
        Dim val1 As Integer
        Dim val2 As Integer

        val1 = objeto.dgwEntrada.Item(1, 0).Value
        val2 = objeto.dgwEntrada.Item(1, 5).Value

        'Asigna 0 al tiempo de espera si no se especifico
        If Format(objeto.dgwEntrada.Item(1, 7).Value, Style:="") = "" Then
            objeto.dgwEntrada.Item(1, 7).Value = 0
        End If

        'Asigna 0 al costo por unidad si no se especifico
        If Format(objeto.dgwEntrada.Item(1, 4).Value, Style:="") = "" Then
            objeto.dgwEntrada.Item(1, 4).Value = 0
        End If

        'Comprueba que la demanda anual sea mayor que la demanda diaria
        If val1 < val2 Then
            MsgBox("La demanda diaria no puede ser mayor que la demanda anual", MsgBoxStyle.Exclamation)
        Else
            calculoM2() 'Llamado al procedimiento que calcula la respuesta
            objeto.GuardarToolStripMenuItem.Enabled = True
            objeto.btnGráfica.Visible = True
        End If
    End Sub

    'Crea la grafica para el modulo 2
    Public Sub GraficaM2()
        Dim Imax, Tc, td, tl, L, S, tf As Single
        Dim cont As Integer = 1
        Dim serie As Integer

        Imax = objeto.dgwSalida.Item(1, 2).Value
        Tc = objeto.dgwSalida.Item(1, 4).Value
        td = tdisp
        tl = tdem
        L = objeto.dgwSalida.Item(1, 5).Value
        S = objeto.dgwSalida.Item(1, 1).Value
        tf = tfalt

        gf = FrmGráfica

        'Se introduce los parametros a la grafica
        gf.Grafica.Series(0).Points.AddXY(0, Imax)
        gf.Grafica.Series(1).Points.AddXY(0, Imax)
        While cont < 4
            For serie = 0 To 1 Step 1
                gf.Grafica.Series(serie).Points.AddXY((Tc * cont) - tl, L)
                gf.Grafica.Series(serie).Points.AddXY((Tc * cont) - tf, 0)
                gf.Grafica.Series(serie).Points.AddXY(Tc * cont, -S)
                gf.Grafica.Series(serie).Points.AddXY(Tc * cont, Imax)
            Next
            cont = cont + 1
        End While

        'Se define el intervalo de la gráfica
        gf.Grafica.ChartAreas(0).AxisX.Interval = 3
        gf.Grafica.ChartAreas(0).AxisX.Minimum = 0
    End Sub

End Module
