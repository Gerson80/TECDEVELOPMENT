<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormClientes2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormClientes2))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ButtonBuscar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ButtonInicio = New System.Windows.Forms.Button()
        Me.ButtonAbonos = New System.Windows.Forms.Button()
        Me.ButtonCsesion = New System.Windows.Forms.Button()
        Me.TextoBuscar = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(13, 169)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(923, 248)
        Me.DataGridView1.TabIndex = 13
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.ButtonBuscar)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.ButtonInicio)
        Me.GroupBox1.Controls.Add(Me.ButtonAbonos)
        Me.GroupBox1.Controls.Add(Me.ButtonCsesion)
        Me.GroupBox1.Controls.Add(Me.TextoBuscar)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 14)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(923, 111)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Registros"
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
        Me.ButtonInicio.Location = New System.Drawing.Point(676, 43)
        Me.ButtonInicio.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonInicio.Name = "ButtonInicio"
        Me.ButtonInicio.Size = New System.Drawing.Size(100, 28)
        Me.ButtonInicio.TabIndex = 5
        Me.ButtonInicio.Text = "Inicio"
        Me.ButtonInicio.UseVisualStyleBackColor = True
        '
        'ButtonAbonos
        '
        Me.ButtonAbonos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonAbonos.Location = New System.Drawing.Point(568, 43)
        Me.ButtonAbonos.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonAbonos.Name = "ButtonAbonos"
        Me.ButtonAbonos.Size = New System.Drawing.Size(100, 28)
        Me.ButtonAbonos.TabIndex = 3
        Me.ButtonAbonos.Text = "Abonos"
        Me.ButtonAbonos.UseVisualStyleBackColor = True
        '
        'ButtonCsesion
        '
        Me.ButtonCsesion.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonCsesion.Location = New System.Drawing.Point(784, 43)
        Me.ButtonCsesion.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonCsesion.Name = "ButtonCsesion"
        Me.ButtonCsesion.Size = New System.Drawing.Size(112, 28)
        Me.ButtonCsesion.TabIndex = 6
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
        Me.TextoBuscar.Text = "Buscar auto"
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
        Me.Label1.Size = New System.Drawing.Size(103, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Clientes"
        '
        'FormClientes2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(957, 442)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FormClientes2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormClientes2"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonBuscar As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ButtonInicio As System.Windows.Forms.Button
    Friend WithEvents ButtonAbonos As System.Windows.Forms.Button
    Friend WithEvents ButtonCsesion As System.Windows.Forms.Button
    Friend WithEvents TextoBuscar As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
