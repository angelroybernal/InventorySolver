<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmGráfica
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmGráfica))
        Me.Grafica = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.mntMenu = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EdiciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BorrarTodoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeWinISToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.Grafica, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mntMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'Grafica
        '
        ChartArea1.Name = "ChartArea1"
        Me.Grafica.ChartAreas.Add(ChartArea1)
        Me.Grafica.Location = New System.Drawing.Point(12, 39)
        Me.Grafica.Name = "Grafica"
        Series1.ChartArea = "ChartArea1"
        Series1.Name = "Series1"
        Series2.ChartArea = "ChartArea1"
        Series2.Name = "Series2"
        Me.Grafica.Series.Add(Series1)
        Me.Grafica.Series.Add(Series2)
        Me.Grafica.Size = New System.Drawing.Size(587, 374)
        Me.Grafica.TabIndex = 0
        Me.Grafica.Text = "Gráfica"
        '
        'mntMenu
        '
        Me.mntMenu.BackColor = System.Drawing.SystemColors.MenuBar
        Me.mntMenu.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mntMenu.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.mntMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.EdiciónToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.mntMenu.Location = New System.Drawing.Point(0, 0)
        Me.mntMenu.Name = "mntMenu"
        Me.mntMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.mntMenu.Size = New System.Drawing.Size(608, 25)
        Me.mntMenu.TabIndex = 1
        Me.mntMenu.Text = "Menu"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.GuardarToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(63, 21)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'NuevoToolStripMenuItem
        '
        Me.NuevoToolStripMenuItem.Enabled = False
        Me.NuevoToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem"
        Me.NuevoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.NuevoToolStripMenuItem.Text = "Nuevo"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'EdiciónToolStripMenuItem
        '
        Me.EdiciónToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BorrarTodoToolStripMenuItem})
        Me.EdiciónToolStripMenuItem.Name = "EdiciónToolStripMenuItem"
        Me.EdiciónToolStripMenuItem.Size = New System.Drawing.Size(62, 21)
        Me.EdiciónToolStripMenuItem.Text = "Edición"
        '
        'BorrarTodoToolStripMenuItem
        '
        Me.BorrarTodoToolStripMenuItem.Enabled = False
        Me.BorrarTodoToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BorrarTodoToolStripMenuItem.Name = "BorrarTodoToolStripMenuItem"
        Me.BorrarTodoToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.BorrarTodoToolStripMenuItem.Text = "Borrar todo"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AcercaDeWinISToolStripMenuItem})
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(56, 21)
        Me.AyudaToolStripMenuItem.Text = "Ayuda"
        '
        'AcercaDeWinISToolStripMenuItem
        '
        Me.AcercaDeWinISToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AcercaDeWinISToolStripMenuItem.Name = "AcercaDeWinISToolStripMenuItem"
        Me.AcercaDeWinISToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.AcercaDeWinISToolStripMenuItem.Text = "Acerca de WinIS"
        '
        'GuardarToolStripMenuItem
        '
        Me.GuardarToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GuardarToolStripMenuItem.Name = "GuardarToolStripMenuItem"
        Me.GuardarToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.GuardarToolStripMenuItem.Text = "Guardar"
        '
        'FrmGráfica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(608, 425)
        Me.Controls.Add(Me.mntMenu)
        Me.Controls.Add(Me.Grafica)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmGráfica"
        Me.Text = "winIS - Gráfica"
        CType(Me.Grafica, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mntMenu.ResumeLayout(False)
        Me.mntMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Grafica As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents mntMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EdiciónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BorrarTodoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AcercaDeWinISToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GuardarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
