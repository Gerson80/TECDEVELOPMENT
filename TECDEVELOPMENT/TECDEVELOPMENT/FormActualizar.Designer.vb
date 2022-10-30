<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormActualizar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormActualizar))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ButtonBorrar = New System.Windows.Forms.Button()
        Me.ButtonActualizar = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ButtonBuscar = New System.Windows.Forms.Button()
        Me.TextoBuscar = New System.Windows.Forms.TextBox()
        Me.TextBoxMarca = New System.Windows.Forms.TextBox()
        Me.TextBoxPuertsas = New System.Windows.Forms.TextBox()
        Me.TextBoxStock = New System.Windows.Forms.TextBox()
        Me.TextBoxSucursal = New System.Windows.Forms.TextBox()
        Me.TextBoxCiudad = New System.Windows.Forms.TextBox()
        Me.TextBoxGasolina = New System.Windows.Forms.TextBox()
        Me.TextBoxTipo = New System.Windows.Forms.TextBox()
        Me.TextBoxPrecio = New System.Windows.Forms.TextBox()
        Me.TextBoxAnio = New System.Windows.Forms.TextBox()
        Me.TextBoxModelo = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonAtras = New System.Windows.Forms.Button()
        Me.ButtonCsesion = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.ButtonBorrar)
        Me.GroupBox1.Controls.Add(Me.ButtonActualizar)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Controls.Add(Me.ButtonBuscar)
        Me.GroupBox1.Controls.Add(Me.TextoBuscar)
        Me.GroupBox1.Controls.Add(Me.TextBoxMarca)
        Me.GroupBox1.Controls.Add(Me.TextBoxPuertsas)
        Me.GroupBox1.Controls.Add(Me.TextBoxStock)
        Me.GroupBox1.Controls.Add(Me.TextBoxSucursal)
        Me.GroupBox1.Controls.Add(Me.TextBoxCiudad)
        Me.GroupBox1.Controls.Add(Me.TextBoxGasolina)
        Me.GroupBox1.Controls.Add(Me.TextBoxTipo)
        Me.GroupBox1.Controls.Add(Me.TextBoxPrecio)
        Me.GroupBox1.Controls.Add(Me.TextBoxAnio)
        Me.GroupBox1.Controls.Add(Me.TextBoxModelo)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ButtonAtras)
        Me.GroupBox1.Controls.Add(Me.ButtonCsesion)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(1142, 528)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Inventario"
        '
        'ButtonBorrar
        '
        Me.ButtonBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonBorrar.Location = New System.Drawing.Point(1021, 296)
        Me.ButtonBorrar.Name = "ButtonBorrar"
        Me.ButtonBorrar.Size = New System.Drawing.Size(100, 36)
        Me.ButtonBorrar.TabIndex = 14
        Me.ButtonBorrar.Text = "Borrar"
        Me.ButtonBorrar.UseVisualStyleBackColor = True
        '
        'ButtonActualizar
        '
        Me.ButtonActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonActualizar.Location = New System.Drawing.Point(928, 297)
        Me.ButtonActualizar.Name = "ButtonActualizar"
        Me.ButtonActualizar.Size = New System.Drawing.Size(87, 34)
        Me.ButtonActualizar.TabIndex = 13
        Me.ButtonActualizar.Text = "Actualizar"
        Me.ButtonActualizar.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(37, 350)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1084, 150)
        Me.DataGridView1.TabIndex = 19
        '
        'ButtonBuscar
        '
        Me.ButtonBuscar.BackColor = System.Drawing.Color.White
        Me.ButtonBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonBuscar.Location = New System.Drawing.Point(263, 61)
        Me.ButtonBuscar.Name = "ButtonBuscar"
        Me.ButtonBuscar.Size = New System.Drawing.Size(75, 24)
        Me.ButtonBuscar.TabIndex = 2
        Me.ButtonBuscar.Text = "Buscar"
        Me.ButtonBuscar.UseVisualStyleBackColor = False
        '
        'TextoBuscar
        '
        Me.TextoBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextoBuscar.Location = New System.Drawing.Point(263, 38)
        Me.TextoBuscar.Margin = New System.Windows.Forms.Padding(4)
        Me.TextoBuscar.Name = "TextoBuscar"
        Me.TextoBuscar.Size = New System.Drawing.Size(133, 15)
        Me.TextoBuscar.TabIndex = 1
        Me.TextoBuscar.Text = "Buscar auto"
        Me.TextoBuscar.UseWaitCursor = True
        '
        'TextBoxMarca
        '
        Me.TextBoxMarca.Location = New System.Drawing.Point(125, 140)
        Me.TextBoxMarca.Name = "TextBoxMarca"
        Me.TextBoxMarca.Size = New System.Drawing.Size(214, 22)
        Me.TextBoxMarca.TabIndex = 3
        '
        'TextBoxPuertsas
        '
        Me.TextBoxPuertsas.Location = New System.Drawing.Point(990, 195)
        Me.TextBoxPuertsas.Name = "TextBoxPuertsas"
        Me.TextBoxPuertsas.Size = New System.Drawing.Size(131, 22)
        Me.TextBoxPuertsas.TabIndex = 12
        '
        'TextBoxStock
        '
        Me.TextBoxStock.Location = New System.Drawing.Point(875, 141)
        Me.TextBoxStock.Name = "TextBoxStock"
        Me.TextBoxStock.Size = New System.Drawing.Size(246, 22)
        Me.TextBoxStock.TabIndex = 11
        '
        'TextBoxSucursal
        '
        Me.TextBoxSucursal.Location = New System.Drawing.Point(498, 299)
        Me.TextBoxSucursal.Name = "TextBoxSucursal"
        Me.TextBoxSucursal.Size = New System.Drawing.Size(235, 22)
        Me.TextBoxSucursal.TabIndex = 10
        '
        'TextBoxCiudad
        '
        Me.TextBoxCiudad.Location = New System.Drawing.Point(487, 247)
        Me.TextBoxCiudad.Name = "TextBoxCiudad"
        Me.TextBoxCiudad.Size = New System.Drawing.Size(246, 22)
        Me.TextBoxCiudad.TabIndex = 9
        '
        'TextBoxGasolina
        '
        Me.TextBoxGasolina.Location = New System.Drawing.Point(607, 195)
        Me.TextBoxGasolina.Name = "TextBoxGasolina"
        Me.TextBoxGasolina.Size = New System.Drawing.Size(126, 22)
        Me.TextBoxGasolina.TabIndex = 8
        '
        'TextBoxTipo
        '
        Me.TextBoxTipo.Location = New System.Drawing.Point(593, 141)
        Me.TextBoxTipo.Name = "TextBoxTipo"
        Me.TextBoxTipo.Size = New System.Drawing.Size(140, 22)
        Me.TextBoxTipo.TabIndex = 7
        '
        'TextBoxPrecio
        '
        Me.TextBoxPrecio.Location = New System.Drawing.Point(125, 299)
        Me.TextBoxPrecio.Name = "TextBoxPrecio"
        Me.TextBoxPrecio.Size = New System.Drawing.Size(214, 22)
        Me.TextBoxPrecio.TabIndex = 6
        '
        'TextBoxAnio
        '
        Me.TextBoxAnio.Location = New System.Drawing.Point(125, 245)
        Me.TextBoxAnio.Name = "TextBoxAnio"
        Me.TextBoxAnio.Size = New System.Drawing.Size(214, 22)
        Me.TextBoxAnio.TabIndex = 5
        '
        'TextBoxModelo
        '
        Me.TextBoxModelo.Location = New System.Drawing.Point(125, 192)
        Me.TextBoxModelo.Name = "TextBoxModelo"
        Me.TextBoxModelo.Size = New System.Drawing.Size(214, 22)
        Me.TextBoxModelo.TabIndex = 4
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(32, 137)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(73, 25)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "Marca:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(780, 192)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(184, 25)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Numero de puertas:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(780, 137)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 25)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Stock:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(385, 298)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(95, 25)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Sucursal:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(385, 243)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 25)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Ciudad:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(385, 191)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(208, 25)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Consumo de gasolina:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(385, 141)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(188, 25)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Tipo de transmición:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(32, 298)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 25)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Precio:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(32, 241)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 25)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Año:"
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 192)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Modelo:"
        '
        'ButtonAtras
        '
        Me.ButtonAtras.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonAtras.Location = New System.Drawing.Point(901, 38)
        Me.ButtonAtras.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonAtras.Name = "ButtonAtras"
        Me.ButtonAtras.Size = New System.Drawing.Size(100, 28)
        Me.ButtonAtras.TabIndex = 15
        Me.ButtonAtras.Text = "Atras"
        Me.ButtonAtras.UseVisualStyleBackColor = True
        '
        'ButtonCsesion
        '
        Me.ButtonCsesion.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonCsesion.Location = New System.Drawing.Point(1009, 38)
        Me.ButtonCsesion.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonCsesion.Name = "ButtonCsesion"
        Me.ButtonCsesion.Size = New System.Drawing.Size(112, 28)
        Me.ButtonCsesion.TabIndex = 16
        Me.ButtonCsesion.Text = "Cerrar sesión"
        Me.ButtonCsesion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ButtonCsesion.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label2.Location = New System.Drawing.Point(119, 32)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 33)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Productos"
        '
        'FormActualizar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1168, 555)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FormActualizar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ACTUALIZAR DATOS"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxMarca As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxPuertsas As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxStock As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxSucursal As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxCiudad As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxGasolina As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxTipo As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxPrecio As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxAnio As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxModelo As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ButtonAtras As System.Windows.Forms.Button
    Friend WithEvents ButtonCsesion As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ButtonBuscar As System.Windows.Forms.Button
    Friend WithEvents TextoBuscar As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ButtonActualizar As System.Windows.Forms.Button
    Friend WithEvents ButtonBorrar As System.Windows.Forms.Button
End Class
