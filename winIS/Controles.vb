Module Controles
    Dim objeto1 As New FrmModulo1
    Dim objeto2 As New frmModulo2
    Dim objeto3 As New FrmModulo3
    Dim objeto4 As New FrmModulo4
    Dim gf As New FrmGráfica

    'Control que valida que los datos ingresados solo sean de tipo numerico
    Public Sub ControlDatos(sender As Object, e As KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Asc(e.KeyChar) = 46 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    'Retorna a la pantalla de menu para elegir un nuevo modelo
    Public Sub Nuevo()
        frmModelos.Show()
        FrmModulo1.Close()
        frmModulo2.Close()
        FrmModulo3.Close()
        FrmModulo4.Close()
    End Sub

    'Finaliza el programa
    Public Sub Finalizar()
        Application.Exit()
    End Sub

    'Regresa a la pantalla de menu
    Public Sub Salir()
        frmModelos.Show()
    End Sub

    'Limpia todas las celdas de los parametros de entrada
    Public Sub LimpiarM1()
        Dim cont As Integer

        objeto1 = FrmModulo1
        While cont < 7
            objeto1.dgwEntrada.Item(1, cont).Value = ""
            objeto1.dgwSalida.Item(1, cont).Value = ""
            cont = cont + 1
        End While
    End Sub

    'Limpia todas las celdas de los parametros de entrada del Modulo 2
    Public Sub LimpiarM2()
        Dim cont As Integer

        objeto2 = frmModulo2

        While cont < 8
            objeto2.dgwEntrada.Item(1, cont).Value = ""
            objeto2.dgwSalida.Item(1, cont).Value = ""
            cont = cont + 1
        End While
    End Sub

    'Limpia todas las celdas de los parametros de entrada del Modulo 3
    Public Sub LimpiarM3()
        Dim cont As Integer

        objeto3 = FrmModulo3

        While cont < 8
            objeto3.dgwEntrada.Item(1, cont).Value = ""
            objeto3.dgwSalida.Item(1, cont).Value = ""
            cont = cont + 1
        End While
    End Sub

    'Limpia todas las celdas de los parametros de entrada del Modulo 4
    Public Sub LimpiarM4()
        Dim cont As Integer

        objeto4 = FrmModulo4

        While cont < 9
            objeto4.dgwEntrada.Item(1, cont).Value = ""
            objeto4.dgwSalida.Item(1, cont).Value = ""
            cont = cont + 1
        End While
    End Sub

    'Guarda los resultados en un archivo txt para el modulo 1
    Public Sub GuardarM1()
        Dim Guardar As New SaveFileDialog

        'Muestra el cuadro de guardar
        Guardar.DefaultExt = "txt"
        objeto1 = FrmModulo1
        If Guardar.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Try
                Dim Dat As String = (Guardar.FileName.ToString)
                ' generando el archivo
                Using f As New IO.StreamWriter(Dat, False)
                    f.Flush()
                    For Each r As DataGridViewRow In objeto1.dgwEntrada.Rows
                        If Not r.IsNewRow Then
                            Dim lin As New List(Of String)
                            For Each cell As DataGridViewCell In r.Cells
                                lin.Add(CStr(cell.Value))
                            Next
                            f.WriteLine(String.Join(": ", lin.ToArray))
                        End If
                    Next
                    For Each r As DataGridViewRow In objeto1.dgwSalida.Rows
                        If Not r.IsNewRow Then
                            Dim lin As New List(Of String)
                            For Each cell As DataGridViewCell In r.Cells
                                lin.Add(CStr(cell.Value))
                            Next
                            f.WriteLine(String.Join(": ", lin.ToArray))
                        End If
                    Next
                    f.Flush()
                End Using
            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            End Try
        End If
    End Sub

    'Guarda los resultados en un archivo txt para el modulo 2
    Public Sub GuardarM2()
        Dim Guardar As New SaveFileDialog
        'Muestra el cuadro de guardar

        Guardar.DefaultExt = "txt"
        objeto2 = frmModulo2
        If Guardar.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Try
                Dim Dat As String = (Guardar.FileName.ToString)
                ' generando el archivo
                Using f As New IO.StreamWriter(Dat, False)
                    f.Flush()
                    For Each r As DataGridViewRow In objeto2.dgwEntrada.Rows
                        If Not r.IsNewRow Then
                            Dim lin As New List(Of String)
                            For Each cell As DataGridViewCell In r.Cells
                                lin.Add(CStr(cell.Value))
                            Next
                            f.WriteLine(String.Join(": ", lin.ToArray))
                        End If
                    Next
                    For Each r As DataGridViewRow In objeto2.dgwSalida.Rows
                        If Not r.IsNewRow Then
                            Dim lin As New List(Of String)
                            For Each cell As DataGridViewCell In r.Cells
                                lin.Add(CStr(cell.Value))
                            Next
                            f.WriteLine(String.Join(": ", lin.ToArray))
                        End If
                    Next
                    f.Flush()
                End Using
            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            End Try
        End If
    End Sub

    'Guarda los resultados en un archivo txt para el modulo 3
    Public Sub GuardarM3()
        Dim Guardar As New SaveFileDialog

        'Muestra el cuadro de guardar
        Guardar.DefaultExt = "txt"
        objeto3 = FrmModulo3
        If Guardar.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Try
                Dim Dat As String = (Guardar.FileName.ToString)
                ' generando el archivo
                Using f As New IO.StreamWriter(Dat, False)
                    f.Flush()
                    For Each r As DataGridViewRow In objeto3.dgwEntrada.Rows
                        If Not r.IsNewRow Then
                            Dim lin As New List(Of String)
                            For Each cell As DataGridViewCell In r.Cells
                                lin.Add(CStr(cell.Value))
                            Next
                            f.WriteLine(String.Join(": ", lin.ToArray))
                        End If
                    Next
                    For Each r As DataGridViewRow In objeto3.dgwSalida.Rows
                        If Not r.IsNewRow Then
                            Dim lin As New List(Of String)
                            For Each cell As DataGridViewCell In r.Cells
                                lin.Add(CStr(cell.Value))
                            Next
                            f.WriteLine(String.Join(": ", lin.ToArray))
                        End If
                    Next
                    f.Flush()
                End Using
            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            End Try
        End If
    End Sub

    'Guarda los resultados en un archivo txt para el modulo 4
    Public Sub GuardarM4()
        Dim Guardar As New SaveFileDialog

        'Muestra el cuadro de guardar
        Guardar.DefaultExt = "txt"
        objeto4 = FrmModulo4
        If Guardar.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Try
                Dim Dat As String = (Guardar.FileName.ToString)
                ' generando el archivo
                Using f As New IO.StreamWriter(Dat, False)
                    f.Flush()
                    For Each r As DataGridViewRow In objeto4.dgwEntrada.Rows
                        If Not r.IsNewRow Then
                            Dim lin As New List(Of String)
                            For Each cell As DataGridViewCell In r.Cells
                                lin.Add(CStr(cell.Value))
                            Next
                            f.WriteLine(String.Join(": ", lin.ToArray))
                        End If
                    Next
                    For Each r As DataGridViewRow In objeto4.dgwSalida.Rows
                        If Not r.IsNewRow Then
                            Dim lin As New List(Of String)
                            For Each cell As DataGridViewCell In r.Cells
                                lin.Add(CStr(cell.Value))
                            Next
                            f.WriteLine(String.Join(": ", lin.ToArray))
                        End If
                    Next
                    f.Flush()
                End Using
            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            End Try
        End If
    End Sub

    Public Sub GuardarGrafica()
        Dim guardar As New SaveFileDialog

        gf = FrmGráfica
        guardar.DefaultExt = "png"
        If guardar.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim bmp As New Bitmap(gf.Grafica.Width, gf.Grafica.Height)
            gf.Grafica.DrawToBitmap(bmp, gf.Grafica.DisplayRectangle)
            bmp.Save(guardar.FileName.ToString, System.Drawing.Imaging.ImageFormat.Png)
        End If
    End Sub


    'Despliega la pantalla con la información de WinIS
    Public Sub Ayuda()
        FrmAyuda.Show()
    End Sub

    'Habilita todas las opciones al cerrar la gráfica o la ventana ayuda
    Public Sub habilitar()
        FrmModulo1.dgwEntrada.Columns(1).ReadOnly = False
        frmModulo2.dgwEntrada.Columns(1).ReadOnly = False
        FrmModulo1.btnGráfica.Enabled = True
        FrmModulo1.mntMenu.Enabled = True
        frmModulo2.btnGráfica.Enabled = True
        frmModulo2.mntMenu.Enabled = True
        FrmModulo3.btnGráfica.Enabled = True
        FrmModulo3.mntMenu.Enabled = True
        FrmModulo4.btnGráfica.Enabled = True
        FrmModulo4.mntMenu.Enabled = True
        frmModelos.mntMenu.Enabled = True
        frmModelos.btnContinuar.Enabled = True
        frmModelos.rdbModulo1.Enabled = True
        frmModelos.rdbModulo2.Enabled = True
        frmModelos.rdbModulo3.Enabled = True
        frmModelos.rdbModulo4.Enabled = True
        frmModelos.lbltitulo.Enabled = True
    End Sub

    'Desabilita toda opción de modificación mientras se muestre el gráfico o la ventana ayuda
    Public Sub deshabilitar()
        FrmModulo1.dgwEntrada.Columns(1).ReadOnly = True
        frmModulo2.dgwEntrada.Columns(1).ReadOnly = True
        FrmModulo1.btnGráfica.Enabled = False
        FrmModulo1.mntMenu.Enabled = False
        frmModulo2.btnGráfica.Enabled = False
        frmModulo2.mntMenu.Enabled = False
        FrmModulo3.btnGráfica.Enabled = False
        FrmModulo3.mntMenu.Enabled = False
        FrmModulo4.btnGráfica.Enabled = False
        FrmModulo4.mntMenu.Enabled = False
        frmModelos.mntMenu.Enabled = False
        frmModelos.btnContinuar.Enabled = False
        frmModelos.rdbModulo1.Enabled = False
        frmModelos.rdbModulo2.Enabled = False
        frmModelos.rdbModulo3.Enabled = False
        frmModelos.rdbModulo4.Enabled = False
        frmModelos.lbltitulo.Enabled = False
    End Sub
End Module
