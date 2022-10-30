<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAgregardatosCliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAgregardatosCliente))
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBoxDomicilio = New System.Windows.Forms.TextBox()
        Me.TextBoxCiudad = New System.Windows.Forms.TextBox()
        Me.TextBoxCorreo = New System.Windows.Forms.TextBox()
        Me.TextBoxTelefono = New System.Windows.Forms.TextBox()
        Me.TextBoxNombre = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LabelPrecio = New System.Windows.Forms.Label()
        Me.LabelAnio = New System.Windows.Forms.Label()
        Me.LabelNombre = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ButtonAtras = New System.Windows.Forms.Button()
        Me.ButtonCancelar = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.BontonAceptar = New System.Windows.Forms.Button()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.LabelAbonos = New System.Windows.Forms.Label()
        Me.LabelTotal = New System.Windows.Forms.Label()
        Me.LabelEnganche = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Contado", "Crédito"})
        Me.ComboBox1.Location = New System.Drawing.Point(115, 486)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(160, 24)
        Me.ComboBox1.TabIndex = 7
        Me.ComboBox1.Text = "Forma de compra"
        '
        'TextBoxDomicilio
        '
        Me.TextBoxDomicilio.Location = New System.Drawing.Point(288, 405)
        Me.TextBoxDomicilio.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxDomicilio.Name = "TextBoxDomicilio"
        Me.TextBoxDomicilio.Size = New System.Drawing.Size(170, 22)
        Me.TextBoxDomicilio.TabIndex = 5
        '
        'TextBoxCiudad
        '
        Me.TextBoxCiudad.Location = New System.Drawing.Point(288, 355)
        Me.TextBoxCiudad.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxCiudad.Name = "TextBoxCiudad"
        Me.TextBoxCiudad.Size = New System.Drawing.Size(170, 22)
        Me.TextBoxCiudad.TabIndex = 4
        '
        'TextBoxCorreo
        '
        Me.TextBoxCorreo.Location = New System.Drawing.Point(288, 311)
        Me.TextBoxCorreo.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxCorreo.Name = "TextBoxCorreo"
        Me.TextBoxCorreo.Size = New System.Drawing.Size(170, 22)
        Me.TextBoxCorreo.TabIndex = 3
        '
        'TextBoxTelefono
        '
        Me.TextBoxTelefono.Location = New System.Drawing.Point(288, 270)
        Me.TextBoxTelefono.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxTelefono.Name = "TextBoxTelefono"
        Me.TextBoxTelefono.Size = New System.Drawing.Size(170, 22)
        Me.TextBoxTelefono.TabIndex = 2
        '
        'TextBoxNombre
        '
        Me.TextBoxNombre.Location = New System.Drawing.Point(288, 216)
        Me.TextBoxNombre.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxNombre.Name = "TextBoxNombre"
        Me.TextBoxNombre.Size = New System.Drawing.Size(170, 22)
        Me.TextBoxNombre.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(111, 403)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 24)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Domicilio"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(111, 353)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(136, 24)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Ciudad, estado"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(111, 311)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(166, 24)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Correo electrónico"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(111, 270)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 24)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Teléfono"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(111, 216)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 24)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(111, 165)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 22)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Datos del cliente"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.LabelPrecio)
        Me.GroupBox1.Controls.Add(Me.LabelAnio)
        Me.GroupBox1.Controls.Add(Me.LabelNombre)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.ButtonAtras)
        Me.GroupBox1.Controls.Add(Me.ButtonCancelar)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(549, 138)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Venta"
        '
        'LabelPrecio
        '
        Me.LabelPrecio.AutoSize = True
        Me.LabelPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPrecio.Location = New System.Drawing.Point(141, 93)
        Me.LabelPrecio.Name = "LabelPrecio"
        Me.LabelPrecio.Size = New System.Drawing.Size(59, 20)
        Me.LabelPrecio.TabIndex = 9
        Me.LabelPrecio.Text = "Label9"
        '
        'LabelAnio
        '
        Me.LabelAnio.AutoSize = True
        Me.LabelAnio.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAnio.Location = New System.Drawing.Point(141, 64)
        Me.LabelAnio.Name = "LabelAnio"
        Me.LabelAnio.Size = New System.Drawing.Size(59, 20)
        Me.LabelAnio.TabIndex = 8
        Me.LabelAnio.Text = "Label8"
        '
        'LabelNombre
        '
        Me.LabelNombre.AutoSize = True
        Me.LabelNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNombre.Location = New System.Drawing.Point(141, 32)
        Me.LabelNombre.Name = "LabelNombre"
        Me.LabelNombre.Size = New System.Drawing.Size(59, 20)
        Me.LabelNombre.TabIndex = 7
        Me.LabelNombre.Text = "Label7"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(37, 32)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(88, 78)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'ButtonAtras
        '
        Me.ButtonAtras.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonAtras.Location = New System.Drawing.Point(408, 32)
        Me.ButtonAtras.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonAtras.Name = "ButtonAtras"
        Me.ButtonAtras.Size = New System.Drawing.Size(112, 28)
        Me.ButtonAtras.TabIndex = 5
        Me.ButtonAtras.Text = "Atras"
        Me.ButtonAtras.UseVisualStyleBackColor = True
        '
        'ButtonCancelar
        '
        Me.ButtonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonCancelar.Location = New System.Drawing.Point(408, 82)
        Me.ButtonCancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonCancelar.Name = "ButtonCancelar"
        Me.ButtonCancelar.Size = New System.Drawing.Size(112, 28)
        Me.ButtonCancelar.TabIndex = 6
        Me.ButtonCancelar.Text = "Cancelar"
        Me.ButtonCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ButtonCancelar.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(111, 443)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 24)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Fecha"
        '
        'DateTimePicker
        '
        Me.DateTimePicker.Location = New System.Drawing.Point(193, 445)
        Me.DateTimePicker.Margin = New System.Windows.Forms.Padding(4)
        Me.DateTimePicker.Name = "DateTimePicker"
        Me.DateTimePicker.Size = New System.Drawing.Size(265, 22)
        Me.DateTimePicker.TabIndex = 6
        '
        'BontonAceptar
        '
        Me.BontonAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BontonAceptar.Location = New System.Drawing.Point(473, 585)
        Me.BontonAceptar.Name = "BontonAceptar"
        Me.BontonAceptar.Size = New System.Drawing.Size(80, 30)
        Me.BontonAceptar.TabIndex = 26
        Me.BontonAceptar.Text = "Aceptar"
        Me.BontonAceptar.UseVisualStyleBackColor = True
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"3", "5"})
        Me.ComboBox2.Location = New System.Drawing.Point(298, 486)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(160, 24)
        Me.ComboBox2.TabIndex = 27
        Me.ComboBox2.Text = "Años a pagar"
        Me.ComboBox2.Visible = False
        '
        'LabelAbonos
        '
        Me.LabelAbonos.AutoSize = True
        Me.LabelAbonos.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAbonos.Location = New System.Drawing.Point(294, 533)
        Me.LabelAbonos.Name = "LabelAbonos"
        Me.LabelAbonos.Size = New System.Drawing.Size(65, 20)
        Me.LabelAbonos.TabIndex = 28
        Me.LabelAbonos.Text = "Label8"
        Me.LabelAbonos.Visible = False
        '
        'LabelTotal
        '
        Me.LabelTotal.AutoSize = True
        Me.LabelTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTotal.Location = New System.Drawing.Point(111, 572)
        Me.LabelTotal.Name = "LabelTotal"
        Me.LabelTotal.Size = New System.Drawing.Size(65, 20)
        Me.LabelTotal.TabIndex = 29
        Me.LabelTotal.Text = "Label8"
        Me.LabelTotal.Visible = False
        '
        'LabelEnganche
        '
        Me.LabelEnganche.AutoSize = True
        Me.LabelEnganche.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelEnganche.Location = New System.Drawing.Point(111, 533)
        Me.LabelEnganche.Name = "LabelEnganche"
        Me.LabelEnganche.Size = New System.Drawing.Size(65, 20)
        Me.LabelEnganche.TabIndex = 30
        Me.LabelEnganche.Text = "Label8"
        Me.LabelEnganche.Visible = False
        '
        'FormAgregardatosCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(576, 627)
        Me.Controls.Add(Me.LabelEnganche)
        Me.Controls.Add(Me.LabelTotal)
        Me.Controls.Add(Me.LabelAbonos)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.BontonAceptar)
        Me.Controls.Add(Me.DateTimePicker)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TextBoxDomicilio)
        Me.Controls.Add(Me.TextBoxCiudad)
        Me.Controls.Add(Me.TextBoxCorreo)
        Me.Controls.Add(Me.TextBoxTelefono)
        Me.Controls.Add(Me.TextBoxNombre)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormAgregardatosCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cliente"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBoxDomicilio As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxCiudad As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxCorreo As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxTelefono As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LabelPrecio As System.Windows.Forms.Label
    Friend WithEvents LabelAnio As System.Windows.Forms.Label
    Friend WithEvents LabelNombre As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ButtonAtras As System.Windows.Forms.Button
    Friend WithEvents ButtonCancelar As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents BontonAceptar As System.Windows.Forms.Button
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents LabelAbonos As System.Windows.Forms.Label
    Friend WithEvents LabelTotal As System.Windows.Forms.Label
    Friend WithEvents LabelEnganche As System.Windows.Forms.Label
End Class
