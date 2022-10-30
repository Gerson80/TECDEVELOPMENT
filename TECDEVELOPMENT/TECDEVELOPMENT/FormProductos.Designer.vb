<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormProductos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormProductos))
        Me.ButtonSeleccionarProductos = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ButtonActualizar = New System.Windows.Forms.Button()
        Me.ButtonAgregar = New System.Windows.Forms.Button()
        Me.ButtonBuscar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ButtonInicio = New System.Windows.Forms.Button()
        Me.ButtonAbonos = New System.Windows.Forms.Button()
        Me.ButtonCsesion = New System.Windows.Forms.Button()
        Me.TextoBuscarAu = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonSeleccionarProductos
        '
        Me.ButtonSeleccionarProductos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonSeleccionarProductos.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSeleccionarProductos.Location = New System.Drawing.Point(708, 433)
        Me.ButtonSeleccionarProductos.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonSeleccionarProductos.Name = "ButtonSeleccionarProductos"
        Me.ButtonSeleccionarProductos.Size = New System.Drawing.Size(231, 28)
        Me.ButtonSeleccionarProductos.TabIndex = 9
        Me.ButtonSeleccionarProductos.Text = ">>  Seleccionar producto"
        Me.ButtonSeleccionarProductos.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(55, 177)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(923, 248)
        Me.DataGridView1.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.ButtonActualizar)
        Me.GroupBox1.Controls.Add(Me.ButtonAgregar)
        Me.GroupBox1.Controls.Add(Me.ButtonBuscar)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.ButtonInicio)
        Me.GroupBox1.Controls.Add(Me.ButtonAbonos)
        Me.GroupBox1.Controls.Add(Me.ButtonCsesion)
        Me.GroupBox1.Controls.Add(Me.TextoBuscarAu)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(55, 22)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(923, 111)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Inventario"
        '
        'ButtonActualizar
        '
        Me.ButtonActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonActualizar.Location = New System.Drawing.Point(461, 66)
        Me.ButtonActualizar.Name = "ButtonActualizar"
        Me.ButtonActualizar.Size = New System.Drawing.Size(100, 28)
        Me.ButtonActualizar.TabIndex = 8
        Me.ButtonActualizar.Text = "Actualizar"
        Me.ButtonActualizar.UseVisualStyleBackColor = True
        '
        'ButtonAgregar
        '
        Me.ButtonAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonAgregar.Location = New System.Drawing.Point(569, 23)
        Me.ButtonAgregar.Name = "ButtonAgregar"
        Me.ButtonAgregar.Size = New System.Drawing.Size(100, 28)
        Me.ButtonAgregar.TabIndex = 5
        Me.ButtonAgregar.Text = "Agregar"
        Me.ButtonAgregar.UseVisualStyleBackColor = True
        '
        'ButtonBuscar
        '
        Me.ButtonBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonBuscar.Location = New System.Drawing.Point(266, 66)
        Me.ButtonBuscar.Name = "ButtonBuscar"
        Me.ButtonBuscar.Size = New System.Drawing.Size(75, 24)
        Me.ButtonBuscar.TabIndex = 2
        Me.ButtonBuscar.Text = "Buscar"
        Me.ButtonBuscar.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(37, 32)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(73, 58)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'ButtonInicio
        '
        Me.ButtonInicio.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonInicio.Location = New System.Drawing.Point(676, 23)
        Me.ButtonInicio.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonInicio.Name = "ButtonInicio"
        Me.ButtonInicio.Size = New System.Drawing.Size(100, 28)
        Me.ButtonInicio.TabIndex = 6
        Me.ButtonInicio.Text = "Inicio"
        Me.ButtonInicio.UseVisualStyleBackColor = True
        '
        'ButtonAbonos
        '
        Me.ButtonAbonos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonAbonos.Location = New System.Drawing.Point(461, 23)
        Me.ButtonAbonos.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonAbonos.Name = "ButtonAbonos"
        Me.ButtonAbonos.Size = New System.Drawing.Size(100, 28)
        Me.ButtonAbonos.TabIndex = 4
        Me.ButtonAbonos.Text = "Abonos"
        Me.ButtonAbonos.UseVisualStyleBackColor = True
        '
        'ButtonCsesion
        '
        Me.ButtonCsesion.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonCsesion.Location = New System.Drawing.Point(784, 23)
        Me.ButtonCsesion.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonCsesion.Name = "ButtonCsesion"
        Me.ButtonCsesion.Size = New System.Drawing.Size(112, 28)
        Me.ButtonCsesion.TabIndex = 7
        Me.ButtonCsesion.Text = "Cerrar sesión"
        Me.ButtonCsesion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ButtonCsesion.UseVisualStyleBackColor = True
        '
        'TextoBuscarAu
        '
        Me.TextoBuscarAu.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextoBuscarAu.Location = New System.Drawing.Point(266, 43)
        Me.TextoBuscarAu.Margin = New System.Windows.Forms.Padding(4)
        Me.TextoBuscarAu.Name = "TextoBuscarAu"
        Me.TextoBuscarAu.Size = New System.Drawing.Size(133, 15)
        Me.TextoBuscarAu.TabIndex = 1
        Me.TextoBuscarAu.Text = "Buscar auto"
        Me.TextoBuscarAu.UseWaitCursor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Location = New System.Drawing.Point(119, 32)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Productos"
        '
        'FormProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1032, 482)
        Me.Controls.Add(Me.ButtonSeleccionarProductos)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FormProductos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Automoviles"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ButtonSeleccionarProductos As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ButtonInicio As System.Windows.Forms.Button
    Friend WithEvents ButtonAbonos As System.Windows.Forms.Button
    Friend WithEvents ButtonCsesion As System.Windows.Forms.Button
    Friend WithEvents TextoBuscarAu As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ButtonBuscar As System.Windows.Forms.Button
    Friend WithEvents ButtonAgregar As System.Windows.Forms.Button
    Friend WithEvents ButtonActualizar As System.Windows.Forms.Button
End Class
