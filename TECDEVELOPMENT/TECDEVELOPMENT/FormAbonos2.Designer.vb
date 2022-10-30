<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAbonos2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAbonos2))
        Me.DateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Labelfecha = New System.Windows.Forms.Label()
        Me.ButtonSeleccionar = New System.Windows.Forms.Button()
        Me.ButtonAceptar = New System.Windows.Forms.Button()
        Me.TextBoxPago = New System.Windows.Forms.TextBox()
        Me.LabelPago = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ButtonAtras = New System.Windows.Forms.Button()
        Me.ButtonBuscar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ButtonInicio = New System.Windows.Forms.Button()
        Me.ButtonCsesion = New System.Windows.Forms.Button()
        Me.TextoBuscar = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DateTimePicker
        '
        Me.DateTimePicker.Location = New System.Drawing.Point(341, 459)
        Me.DateTimePicker.Margin = New System.Windows.Forms.Padding(4)
        Me.DateTimePicker.Name = "DateTimePicker"
        Me.DateTimePicker.Size = New System.Drawing.Size(265, 22)
        Me.DateTimePicker.TabIndex = 34
        Me.DateTimePicker.Visible = False
        '
        'Labelfecha
        '
        Me.Labelfecha.AutoSize = True
        Me.Labelfecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelfecha.Location = New System.Drawing.Point(259, 457)
        Me.Labelfecha.Name = "Labelfecha"
        Me.Labelfecha.Size = New System.Drawing.Size(64, 24)
        Me.Labelfecha.TabIndex = 35
        Me.Labelfecha.Text = "Fecha"
        Me.Labelfecha.Visible = False
        '
        'ButtonSeleccionar
        '
        Me.ButtonSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonSeleccionar.Location = New System.Drawing.Point(933, 414)
        Me.ButtonSeleccionar.Name = "ButtonSeleccionar"
        Me.ButtonSeleccionar.Size = New System.Drawing.Size(90, 29)
        Me.ButtonSeleccionar.TabIndex = 28
        Me.ButtonSeleccionar.Text = "Seleccionar"
        Me.ButtonSeleccionar.UseVisualStyleBackColor = True
        '
        'ButtonAceptar
        '
        Me.ButtonAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAceptar.Location = New System.Drawing.Point(932, 485)
        Me.ButtonAceptar.Name = "ButtonAceptar"
        Me.ButtonAceptar.Size = New System.Drawing.Size(90, 31)
        Me.ButtonAceptar.TabIndex = 30
        Me.ButtonAceptar.Text = "Aceptar"
        Me.ButtonAceptar.UseVisualStyleBackColor = True
        Me.ButtonAceptar.Visible = False
        '
        'TextBoxPago
        '
        Me.TextBoxPago.Location = New System.Drawing.Point(110, 459)
        Me.TextBoxPago.Name = "TextBoxPago"
        Me.TextBoxPago.Size = New System.Drawing.Size(100, 22)
        Me.TextBoxPago.TabIndex = 29
        Me.TextBoxPago.Visible = False
        '
        'LabelPago
        '
        Me.LabelPago.AutoSize = True
        Me.LabelPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPago.Location = New System.Drawing.Point(36, 459)
        Me.LabelPago.Name = "LabelPago"
        Me.LabelPago.Size = New System.Drawing.Size(57, 20)
        Me.LabelPago.TabIndex = 33
        Me.LabelPago.Text = "Pago:"
        Me.LabelPago.Visible = False
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(15, 158)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1007, 248)
        Me.DataGridView1.TabIndex = 32
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.ButtonAtras)
        Me.GroupBox1.Controls.Add(Me.ButtonBuscar)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.ButtonInicio)
        Me.GroupBox1.Controls.Add(Me.ButtonCsesion)
        Me.GroupBox1.Controls.Add(Me.TextoBuscar)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 24)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(1007, 111)
        Me.GroupBox1.TabIndex = 31
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Registros"
        '
        'ButtonAtras
        '
        Me.ButtonAtras.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonAtras.Location = New System.Drawing.Point(692, 43)
        Me.ButtonAtras.Name = "ButtonAtras"
        Me.ButtonAtras.Size = New System.Drawing.Size(80, 28)
        Me.ButtonAtras.TabIndex = 8
        Me.ButtonAtras.Text = "Atras"
        Me.ButtonAtras.UseVisualStyleBackColor = True
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
        Me.ButtonInicio.Location = New System.Drawing.Point(779, 43)
        Me.ButtonInicio.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonInicio.Name = "ButtonInicio"
        Me.ButtonInicio.Size = New System.Drawing.Size(100, 28)
        Me.ButtonInicio.TabIndex = 6
        Me.ButtonInicio.Text = "Inicio"
        Me.ButtonInicio.UseVisualStyleBackColor = True
        '
        'ButtonCsesion
        '
        Me.ButtonCsesion.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonCsesion.Location = New System.Drawing.Point(887, 43)
        Me.ButtonCsesion.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonCsesion.Name = "ButtonCsesion"
        Me.ButtonCsesion.Size = New System.Drawing.Size(112, 28)
        Me.ButtonCsesion.TabIndex = 7
        Me.ButtonCsesion.Text = "Cerrar sesión"
        Me.ButtonCsesion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ButtonCsesion.UseVisualStyleBackColor = True
        '
        'TextoBuscar
        '
        Me.TextoBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextoBuscar.Location = New System.Drawing.Point(266, 43)
        Me.TextoBuscar.Margin = New System.Windows.Forms.Padding(4)
        Me.TextoBuscar.Name = "TextoBuscar"
        Me.TextoBuscar.Size = New System.Drawing.Size(133, 15)
        Me.TextoBuscar.TabIndex = 1
        Me.TextoBuscar.Text = "Nombre"
        Me.TextoBuscar.UseWaitCursor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Location = New System.Drawing.Point(119, 32)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Abonos"
        '
        'FormAbonos2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1038, 541)
        Me.Controls.Add(Me.DateTimePicker)
        Me.Controls.Add(Me.Labelfecha)
        Me.Controls.Add(Me.ButtonSeleccionar)
        Me.Controls.Add(Me.ButtonAceptar)
        Me.Controls.Add(Me.TextBoxPago)
        Me.Controls.Add(Me.LabelPago)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FormAbonos2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Abonos"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Labelfecha As System.Windows.Forms.Label
    Friend WithEvents ButtonSeleccionar As System.Windows.Forms.Button
    Friend WithEvents ButtonAceptar As System.Windows.Forms.Button
    Friend WithEvents TextBoxPago As System.Windows.Forms.TextBox
    Friend WithEvents LabelPago As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonAtras As System.Windows.Forms.Button
    Friend WithEvents ButtonBuscar As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ButtonInicio As System.Windows.Forms.Button
    Friend WithEvents ButtonCsesion As System.Windows.Forms.Button
    Friend WithEvents TextoBuscar As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
