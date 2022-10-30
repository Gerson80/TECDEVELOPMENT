<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formaMenu
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
        Me.ButtonADU = New System.Windows.Forms.Button()
        Me.ButtonClientes = New System.Windows.Forms.Button()
        Me.ButtonInven = New System.Windows.Forms.Button()
        Me.Buttoncerrar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ButtonADU
        '
        Me.ButtonADU.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonADU.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonADU.Location = New System.Drawing.Point(92, 163)
        Me.ButtonADU.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonADU.Name = "ButtonADU"
        Me.ButtonADU.Size = New System.Drawing.Size(219, 43)
        Me.ButtonADU.TabIndex = 5
        Me.ButtonADU.Text = "Administrar Usuarios"
        Me.ButtonADU.UseVisualStyleBackColor = True
        '
        'ButtonClientes
        '
        Me.ButtonClientes.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonClientes.Location = New System.Drawing.Point(120, 103)
        Me.ButtonClientes.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonClientes.Name = "ButtonClientes"
        Me.ButtonClientes.Size = New System.Drawing.Size(169, 43)
        Me.ButtonClientes.TabIndex = 4
        Me.ButtonClientes.Text = "Clientes"
        Me.ButtonClientes.UseVisualStyleBackColor = True
        '
        'ButtonInven
        '
        Me.ButtonInven.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonInven.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonInven.Location = New System.Drawing.Point(120, 52)
        Me.ButtonInven.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonInven.Name = "ButtonInven"
        Me.ButtonInven.Size = New System.Drawing.Size(169, 43)
        Me.ButtonInven.TabIndex = 3
        Me.ButtonInven.Text = "Inventario"
        Me.ButtonInven.UseVisualStyleBackColor = True
        '
        'Buttoncerrar
        '
        Me.Buttoncerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Buttoncerrar.Location = New System.Drawing.Point(322, 275)
        Me.Buttoncerrar.Name = "Buttoncerrar"
        Me.Buttoncerrar.Size = New System.Drawing.Size(78, 37)
        Me.Buttoncerrar.TabIndex = 6
        Me.Buttoncerrar.Text = "Cerrar"
        Me.Buttoncerrar.UseVisualStyleBackColor = True
        '
        'formaMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(412, 324)
        Me.Controls.Add(Me.Buttoncerrar)
        Me.Controls.Add(Me.ButtonADU)
        Me.Controls.Add(Me.ButtonClientes)
        Me.Controls.Add(Me.ButtonInven)
        Me.Name = "formaMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ButtonADU As System.Windows.Forms.Button
    Friend WithEvents ButtonClientes As System.Windows.Forms.Button
    Friend WithEvents ButtonInven As System.Windows.Forms.Button
    Friend WithEvents Buttoncerrar As System.Windows.Forms.Button
End Class
