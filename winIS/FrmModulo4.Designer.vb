<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmModulo4
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmModulo4))
        Me.dgwEntrada = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgwSalida = New System.Windows.Forms.DataGridView()
        Me.SalidaParametros = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SalidaValores = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnGráfica = New System.Windows.Forms.Button()
        Me.btnResolver = New System.Windows.Forms.Button()
        Me.mntMenu = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EdiciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BorrarTodoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeWinISToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.dgwEntrada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgwSalida, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mntMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgwEntrada
        '
        Me.dgwEntrada.AllowUserToAddRows = False
        Me.dgwEntrada.AllowUserToDeleteRows = False
        Me.dgwEntrada.AllowUserToResizeColumns = False
        Me.dgwEntrada.AllowUserToResizeRows = False
        Me.dgwEntrada.BackgroundColor = System.Drawing.Color.White
        Me.dgwEntrada.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgwEntrada.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.dgwEntrada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgwEntrada.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.dgwEntrada.Location = New System.Drawing.Point(12, 43)
        Me.dgwEntrada.Name = "dgwEntrada"
        Me.dgwEntrada.RowHeadersVisible = False
        Me.dgwEntrada.Size = New System.Drawing.Size(313, 227)
        Me.dgwEntrada.TabIndex = 20
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle1.NullValue = Nothing
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn1.FillWeight = 146.9118!
        Me.DataGridViewTextBoxColumn1.HeaderText = "Parametro"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.FillWeight = 62.94417!
        Me.DataGridViewTextBoxColumn2.HeaderText = "Valor"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'dgwSalida
        '
        Me.dgwSalida.AllowUserToAddRows = False
        Me.dgwSalida.AllowUserToDeleteRows = False
        Me.dgwSalida.AllowUserToResizeColumns = False
        Me.dgwSalida.AllowUserToResizeRows = False
        Me.dgwSalida.BackgroundColor = System.Drawing.Color.White
        Me.dgwSalida.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgwSalida.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.dgwSalida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgwSalida.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SalidaParametros, Me.SalidaValores})
        Me.dgwSalida.Location = New System.Drawing.Point(331, 43)
        Me.dgwSalida.Name = "dgwSalida"
        Me.dgwSalida.RowHeadersVisible = False
        Me.dgwSalida.Size = New System.Drawing.Size(313, 227)
        Me.dgwSalida.TabIndex = 21
        '
        'SalidaParametros
        '
        Me.SalidaParametros.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        Me.SalidaParametros.DefaultCellStyle = DataGridViewCellStyle2
        Me.SalidaParametros.FillWeight = 150.7769!
        Me.SalidaParametros.HeaderText = "Parametro"
        Me.SalidaParametros.Name = "SalidaParametros"
        Me.SalidaParametros.ReadOnly = True
        Me.SalidaParametros.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'SalidaValores
        '
        Me.SalidaValores.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        Me.SalidaValores.DefaultCellStyle = DataGridViewCellStyle3
        Me.SalidaValores.FillWeight = 62.94417!
        Me.SalidaValores.HeaderText = "Valor"
        Me.SalidaValores.Name = "SalidaValores"
        Me.SalidaValores.ReadOnly = True
        Me.SalidaValores.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'btnGráfica
        '
        Me.btnGráfica.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnGráfica.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGráfica.Location = New System.Drawing.Point(508, 276)
        Me.btnGráfica.Name = "btnGráfica"
        Me.btnGráfica.Size = New System.Drawing.Size(136, 27)
        Me.btnGráfica.TabIndex = 23
        Me.btnGráfica.Text = "Mostrar Gráfica"
        Me.btnGráfica.UseVisualStyleBackColor = False
        '
        'btnResolver
        '
        Me.btnResolver.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnResolver.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResolver.Location = New System.Drawing.Point(508, 303)
        Me.btnResolver.Name = "btnResolver"
        Me.btnResolver.Size = New System.Drawing.Size(136, 27)
        Me.btnResolver.TabIndex = 22
        Me.btnResolver.Text = "Resolver"
        Me.btnResolver.UseVisualStyleBackColor = False
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
        Me.mntMenu.Size = New System.Drawing.Size(656, 25)
        Me.mntMenu.TabIndex = 24
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
        Me.NuevoToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem"
        Me.NuevoToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.NuevoToolStripMenuItem.Text = "Nuevo"
        '
        'GuardarToolStripMenuItem
        '
        Me.GuardarToolStripMenuItem.Enabled = False
        Me.GuardarToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GuardarToolStripMenuItem.Name = "GuardarToolStripMenuItem"
        Me.GuardarToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.GuardarToolStripMenuItem.Text = "Guardar"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
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
        'FrmModulo4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(656, 340)
        Me.Controls.Add(Me.mntMenu)
        Me.Controls.Add(Me.btnGráfica)
        Me.Controls.Add(Me.btnResolver)
        Me.Controls.Add(Me.dgwSalida)
        Me.Controls.Add(Me.dgwEntrada)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmModulo4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "winIS - EOQ de reemplazo gradual con faltante"
        CType(Me.dgwEntrada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgwSalida, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mntMenu.ResumeLayout(False)
        Me.mntMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgwEntrada As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgwSalida As System.Windows.Forms.DataGridView
    Friend WithEvents SalidaParametros As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SalidaValores As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnGráfica As System.Windows.Forms.Button
    Friend WithEvents btnResolver As System.Windows.Forms.Button
    Friend WithEvents mntMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GuardarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EdiciónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BorrarTodoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AcercaDeWinISToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
