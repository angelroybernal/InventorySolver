<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModelos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmModelos))
        Me.rdbModulo1 = New System.Windows.Forms.RadioButton()
        Me.rdbModulo2 = New System.Windows.Forms.RadioButton()
        Me.rdbModulo3 = New System.Windows.Forms.RadioButton()
        Me.rdbModulo4 = New System.Windows.Forms.RadioButton()
        Me.btnContinuar = New System.Windows.Forms.Button()
        Me.lbltitulo = New System.Windows.Forms.Label()
        Me.mntMenu = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EdiciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BorrarTodoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeWinISToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mntMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'rdbModulo1
        '
        Me.rdbModulo1.AutoSize = True
        Me.rdbModulo1.BackColor = System.Drawing.Color.Transparent
        Me.rdbModulo1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbModulo1.Location = New System.Drawing.Point(12, 73)
        Me.rdbModulo1.Name = "rdbModulo1"
        Me.rdbModulo1.Size = New System.Drawing.Size(330, 25)
        Me.rdbModulo1.TabIndex = 0
        Me.rdbModulo1.TabStop = True
        Me.rdbModulo1.Text = "EOQ de reemplazo instantaneo sin faltantes"
        Me.rdbModulo1.UseVisualStyleBackColor = False
        '
        'rdbModulo2
        '
        Me.rdbModulo2.AutoSize = True
        Me.rdbModulo2.BackColor = System.Drawing.Color.Transparent
        Me.rdbModulo2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbModulo2.Location = New System.Drawing.Point(12, 104)
        Me.rdbModulo2.Name = "rdbModulo2"
        Me.rdbModulo2.Size = New System.Drawing.Size(335, 25)
        Me.rdbModulo2.TabIndex = 1
        Me.rdbModulo2.TabStop = True
        Me.rdbModulo2.Text = "EOQ de reemplazo instantaneo con faltantes"
        Me.rdbModulo2.UseVisualStyleBackColor = False
        '
        'rdbModulo3
        '
        Me.rdbModulo3.AutoSize = True
        Me.rdbModulo3.BackColor = System.Drawing.Color.Transparent
        Me.rdbModulo3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbModulo3.Location = New System.Drawing.Point(12, 135)
        Me.rdbModulo3.Name = "rdbModulo3"
        Me.rdbModulo3.Size = New System.Drawing.Size(302, 25)
        Me.rdbModulo3.TabIndex = 2
        Me.rdbModulo3.TabStop = True
        Me.rdbModulo3.Text = "EOQ de reemplazo gradual sin faltantes"
        Me.rdbModulo3.UseVisualStyleBackColor = False
        '
        'rdbModulo4
        '
        Me.rdbModulo4.AutoSize = True
        Me.rdbModulo4.BackColor = System.Drawing.Color.Transparent
        Me.rdbModulo4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbModulo4.Location = New System.Drawing.Point(12, 166)
        Me.rdbModulo4.Name = "rdbModulo4"
        Me.rdbModulo4.Size = New System.Drawing.Size(307, 25)
        Me.rdbModulo4.TabIndex = 3
        Me.rdbModulo4.TabStop = True
        Me.rdbModulo4.Text = "EOQ de reemplazo gradual con faltantes"
        Me.rdbModulo4.UseVisualStyleBackColor = False
        '
        'btnContinuar
        '
        Me.btnContinuar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnContinuar.Location = New System.Drawing.Point(251, 230)
        Me.btnContinuar.Name = "btnContinuar"
        Me.btnContinuar.Size = New System.Drawing.Size(87, 27)
        Me.btnContinuar.TabIndex = 4
        Me.btnContinuar.Text = "Continuar"
        Me.btnContinuar.UseVisualStyleBackColor = True
        '
        'lbltitulo
        '
        Me.lbltitulo.AutoSize = True
        Me.lbltitulo.BackColor = System.Drawing.Color.Transparent
        Me.lbltitulo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitulo.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.lbltitulo.Location = New System.Drawing.Point(8, 39)
        Me.lbltitulo.Name = "lbltitulo"
        Me.lbltitulo.Size = New System.Drawing.Size(179, 21)
        Me.lbltitulo.TabIndex = 5
        Me.lbltitulo.Text = "Seleccione un modelo"
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
        Me.mntMenu.Size = New System.Drawing.Size(350, 25)
        Me.mntMenu.TabIndex = 6
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
        Me.GuardarToolStripMenuItem.Enabled = False
        Me.GuardarToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GuardarToolStripMenuItem.Name = "GuardarToolStripMenuItem"
        Me.GuardarToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.GuardarToolStripMenuItem.Text = "Guardar"
        '
        'frmModelos
        '
        Me.AcceptButton = Me.btnContinuar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(350, 266)
        Me.Controls.Add(Me.mntMenu)
        Me.Controls.Add(Me.lbltitulo)
        Me.Controls.Add(Me.btnContinuar)
        Me.Controls.Add(Me.rdbModulo4)
        Me.Controls.Add(Me.rdbModulo3)
        Me.Controls.Add(Me.rdbModulo2)
        Me.Controls.Add(Me.rdbModulo1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmModelos"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "winIS - Modelos"
        Me.mntMenu.ResumeLayout(False)
        Me.mntMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rdbModulo1 As System.Windows.Forms.RadioButton
    Friend WithEvents rdbModulo2 As System.Windows.Forms.RadioButton
    Friend WithEvents rdbModulo3 As System.Windows.Forms.RadioButton
    Friend WithEvents rdbModulo4 As System.Windows.Forms.RadioButton
    Friend WithEvents btnContinuar As System.Windows.Forms.Button
    Friend WithEvents lbltitulo As System.Windows.Forms.Label
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
