Module EPQ2Funciones
    Dim objeto As New FrmModulo4
    Dim gf As New FrmGráfica
    Dim tdem As Single = 0
    Dim tpro As Single = 0
    Dim tcon As Single = 0
    Dim tfalt As Single = 0

    'Carga los nombres de los parametros de entrada y salida del modulo 1
    Public Sub CargarM4()
        objeto = FrmModulo4

        'parametros de entrada, tabla 1
        objeto.dgwEntrada.Rows.Add("Demanda anual")
        objeto.dgwEntrada.Rows.Add("Costo de preparar una tanda")
        objeto.dgwEntrada.Rows.Add("Costo de mantener inventario")
        objeto.dgwEntrada.Rows.Add("Costo de faltante")
        objeto.dgwEntrada.Rows.Add("Producción diaria")
        objeto.dgwEntrada.Rows.Add("Días al año")
        objeto.dgwEntrada.Rows.Add("Demanda diaria")
        objeto.dgwEntrada.Rows.Add("Tiempo de preparación (opcional)")
        objeto.dgwEntrada.Rows.Add("Costo por unidad (opcional)")

        'Parametros de salida, tabla 2
        objeto.dgwSalida.Rows.Add("Tamaño del lote optimo")
        objeto.dgwSalida.Rows.Add("Escasez Máxima")
        objeto.dgwSalida.Rows.Add("Inventario máximo")
        objeto.dgwSalida.Rows.Add("Número de tandas")
        objeto.dgwSalida.Rows.Add("Tiempo de ciclo")
        objeto.dgwSalida.Rows.Add("Punto de reorden")
        objeto.dgwSalida.Rows.Add("")
        objeto.dgwSalida.Rows.Add("")
        objeto.dgwSalida.Rows.Add("Costo de la politica")

        'Cambia el tipo y tamaño de fuente de las tablas
        objeto.dgwEntrada.Font = New Font("Segoe Ui", 10)
        objeto.dgwSalida.Font = New Font("Segoe Ui", 10)
    End Sub

    'Calcula los resultados del modulo 1 con los datos de entrada proporcionados
    Public Sub calculoM4()
        Dim parametros(9) As Single
        Dim cont As Integer = 0

        'toma los valores de la tabla entradas y los almacena en un arreglo
        While cont < 9
            parametros(cont) = objeto.dgwEntrada.Item(1, cont).Value
            cont = cont + 1
        End While

        'Envia el arreglo como parametro a la clase EPQ2 y asigna los resultados a la tabla salida
        Dim objeto2 As New EPQ2(parametros)
        objeto.dgwSalida.Item(1, 0).Value = objeto2.TamañoLote()
        objeto.dgwSalida.Item(1, 1).Value = objeto2.Deficit()
        objeto.dgwSalida.Item(1, 2).Value = objeto2.InventarioMaximo()
        objeto.dgwSalida.Item(1, 3).Value = objeto2.Ntandas()
        objeto.dgwSalida.Item(1, 4).Value = objeto2.TiempoCiclo()
        objeto.dgwSalida.Item(1, 5).Value = objeto2.PuntoReorden()
        objeto.dgwSalida.Item(1, 8).Value = "$" + Format(objeto2.CostoPolitica(), Style:="")
        tdem = objeto.dgwEntrada.Item(1, 7).Value
        tpro = objeto2.TiempoProduccion()
        tcon = objeto2.TiempoConsumo()
        tfalt = objeto2.TiempoFaltante()
    End Sub

    'Valida los campos y calcula la respuesta
    Public Sub solucionM4()
        Dim val1 As Integer
        Dim val2 As Integer

        val1 = objeto.dgwEntrada.Item(1, 0).Value
        val2 = objeto.dgwEntrada.Item(1, 5).Value

        'Asigna 0 al tiempo de espera si no se especifico
        If Format(objeto.dgwEntrada.Item(1, 7).Value, Style:="") = "" Then
            objeto.dgwEntrada.Item(1, 7).Value = 0
        End If

        'Comprueba que la demanda anual sea mayor que la demanda diaria
        If val1 < val2 Then
            MsgBox("La demanda diaria no puede ser mayor que la demanda anual", MsgBoxStyle.Exclamation)
        Else
            calculoM4() 'Llamado al procedimiento que calcula la respuesta
            objeto.GuardarToolStripMenuItem.Enabled = True
            objeto.btnGráfica.Visible = True
        End If
    End Sub

    'Crea la grafica para el modulo 4
    Public Sub GraficaM4()
        Dim Imax, S, Tc, tl, tp, td, tf, L As Single
        Dim cont As Integer = 1
        Dim serie As Integer

        Imax = objeto.dgwSalida.Item(1, 2).Value
        S = objeto.dgwSalida.Item(1, 1).Value
        Tc = objeto.dgwSalida.Item(1, 4).Value
        tl = tdem
        tp = tpro
        td = tcon
        tf = tfalt
        L = objeto.dgwSalida.Item(1, 5).Value

        gf = FrmGráfica

        'Se introduce los parametros a la grafica
        gf.Grafica.Series(0).Points.AddXY(0, -S)
        gf.Grafica.Series(1).Points.AddXY(0, -S)
        While cont < 4
            For serie = 0 To 1 Step 1
                gf.Grafica.Series(serie).Points.AddXY((Tc * cont) - tf - td, Imax)
                gf.Grafica.Series(serie).Points.AddXY((Tc * cont) - tf, 0)
                gf.Grafica.Series(serie).Points.AddXY((Tc * cont) - tl, L)
                gf.Grafica.Series(serie).Points.AddXY((Tc * cont), -S)
            Next
            cont = cont + 1
        End While
        'Se define el intervalo de la gráfica
        gf.Grafica.ChartAreas(0).AxisX.Minimum = 0
    End Sub

End Module
