<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormActualizarCliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormActualizarCliente))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ButtonActualizar = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ButtonBuscar = New System.Windows.Forms.Button()
        Me.TextoBuscar = New System.Windows.Forms.TextBox()
        Me.TextBoxNombre = New System.Windows.Forms.TextBox()
        Me.TextBoxDomicilio = New System.Windows.Forms.TextBox()
        Me.TextBoxCIudad = New System.Windows.Forms.TextBox()
        Me.TextBoxCorreo = New System.Windows.Forms.TextBox()
        Me.TextBoxTelefono = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
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
        Me.GroupBox1.Controls.Add(Me.ButtonActualizar)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Controls.Add(Me.ButtonBuscar)
        Me.GroupBox1.Controls.Add(Me.TextoBuscar)
        Me.GroupBox1.Controls.Add(Me.TextBoxNombre)
        Me.GroupBox1.Controls.Add(Me.TextBoxDomicilio)
        Me.GroupBox1.Controls.Add(Me.TextBoxCIudad)
        Me.GroupBox1.Controls.Add(Me.TextBoxCorreo)
        Me.GroupBox1.Controls.Add(Me.TextBoxTelefono)
        Me.GroupBox1.Controls.Add(Me.Label11)
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
        Me.GroupBox1.Size = New System.Drawing.Size(776, 519)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Clientes"
        '
        'ButtonActualizar
        '
        Me.ButtonActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonActualizar.Location = New System.Drawing.Point(633, 287)
        Me.ButtonActualizar.Name = "ButtonActualizar"
        Me.ButtonActualizar.Size = New System.Drawing.Size(100, 34)
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
        Me.DataGridView1.Size = New System.Drawing.Size(696, 150)
        Me.DataGridView1.TabIndex = 19
        '
        'ButtonBuscar
        '
        Me.ButtonBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonBuscar.Location = New System.Drawing.Point(263, 61)
        Me.ButtonBuscar.Name = "ButtonBuscar"
        Me.ButtonBuscar.Size = New System.Drawing.Size(75, 24)
        Me.ButtonBuscar.TabIndex = 2
        Me.ButtonBuscar.Text = "Buscar"
        Me.ButtonBuscar.UseVisualStyleBackColor = True
        '
        'TextoBuscar
        '
        Me.TextoBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextoBuscar.Location = New System.Drawing.Point(263, 38)
        Me.TextoBuscar.Margin = New System.Windows.Forms.Padding(4)
        Me.TextoBuscar.Name = "TextoBuscar"
        Me.TextoBuscar.Size = New System.Drawing.Size(133, 15)
        Me.TextoBuscar.TabIndex = 1
        Me.TextoBuscar.UseWaitCursor = True
        '
        'TextBoxNombre
        '
        Me.TextBoxNombre.Location = New System.Drawing.Point(138, 140)
        Me.TextBoxNombre.Name = "TextBoxNombre"
        Me.TextBoxNombre.Size = New System.Drawing.Size(201, 22)
        Me.TextBoxNombre.TabIndex = 3
        '
        'TextBoxDomicilio
        '
        Me.TextBoxDomicilio.Location = New System.Drawing.Point(511, 141)
        Me.TextBoxDomicilio.Name = "TextBoxDomicilio"
        Me.TextBoxDomicilio.Size = New System.Drawing.Size(222, 22)
        Me.TextBoxDomicilio.TabIndex = 7
        '
        'TextBoxCIudad
        '
        Me.TextBoxCIudad.Location = New System.Drawing.Point(138, 299)
        Me.TextBoxCIudad.Name = "TextBoxCIudad"
        Me.TextBoxCIudad.Size = New System.Drawing.Size(201, 22)
        Me.TextBoxCIudad.TabIndex = 6
        '
        'TextBoxCorreo
        '
        Me.TextBoxCorreo.Location = New System.Drawing.Point(138, 245)
        Me.TextBoxCorreo.Name = "TextBoxCorreo"
        Me.TextBoxCorreo.Size = New System.Drawing.Size(201, 22)
        Me.TextBoxCorreo.TabIndex = 5
        '
        'TextBoxTelefono
        '
        Me.TextBoxTelefono.Location = New System.Drawing.Point(138, 192)
        Me.TextBoxTelefono.Name = "TextBoxTelefono"
        Me.TextBoxTelefono.Size = New System.Drawing.Size(201, 22)
        Me.TextBoxTelefono.TabIndex = 4
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(32, 137)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(92, 25)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "Nombre: "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(385, 141)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 25)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Domicilio: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(32, 298)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 25)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Ciudad: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(32, 241)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 25)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Correo:"
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
        Me.Label1.Size = New System.Drawing.Size(100, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Telefono: "
        '
        'ButtonAtras
        '
        Me.ButtonAtras.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonAtras.Location = New System.Drawing.Point(511, 38)
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
        Me.ButtonCsesion.Location = New System.Drawing.Point(621, 38)
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
        Me.Label2.Size = New System.Drawing.Size(103, 33)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Clientes"
        '
        'FormActualizarCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(803, 554)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FormActualizarCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Actualizar"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonActualizar As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ButtonBuscar As System.Windows.Forms.Button
    Friend WithEvents TextoBuscar As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxNombre As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxDomicilio As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxCIudad As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxCorreo As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxTelefono As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ButtonAtras As System.Windows.Forms.Button
    Friend WithEvents ButtonCsesion As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
