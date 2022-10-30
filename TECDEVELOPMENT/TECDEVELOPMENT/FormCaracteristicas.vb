Public Class FormCaracteristicas

    Private Sub FormCaracteristicas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim nombre = Datoscompartidos.Marca + " " + Datoscompartidos.Modelo + " " + Datoscompartidos.anio
        LabelNombre.Text = nombre
        LabelPrecio.Text = "$" + Datoscompartidos.precio
        LabelTipo.Text = Datoscompartidos.Tipo
        LabelConsumo.Text = Datoscompartidos.Consumo
        LabelCiudad.Text = Datoscompartidos.Ciudad
        LabelSucursal.Text = Datoscompartidos.Sucursal
        LabelPuertas.Text = Datoscompartidos.puertas


    End Sub


    Private Sub ButtonAtras_Click(sender As Object, e As EventArgs) Handles ButtonAtras.Click
        FormProductos.Show()
        Me.Close()
        Datoscompartidos.anio = ""
        Datoscompartidos.Ciudad = ""
        Datoscompartidos.Consumo = ""
        Datoscompartidos.ID = ""
        Datoscompartidos.Marca = ""
        Datoscompartidos.Modelo = ""
        Datoscompartidos.precio = ""
        Datoscompartidos.puertas = ""
        Datoscompartidos.stock = ""
        Datoscompartidos.Sucursal = ""
        Datoscompartidos.Tipo = ""
    End Sub

    Private Sub Button1Meinteresa_Click(sender As Object, e As EventArgs) Handles Button1Meinteresa.Click
        FormAgregardatosCliente.Show()
        Me.Close()
    End Sub

    Private Sub LabelNombre_Click(sender As Object, e As EventArgs) Handles LabelNombre.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub LabelPrecio_Click(sender As Object, e As EventArgs) Handles LabelPrecio.Click

    End Sub

    Private Sub LabelTipo_Click(sender As Object, e As EventArgs) Handles LabelTipo.Click

    End Sub

    Private Sub LabelConsumo_Click(sender As Object, e As EventArgs) Handles LabelConsumo.Click

    End Sub

    Private Sub LabelCiudad_Click(sender As Object, e As EventArgs) Handles LabelCiudad.Click

    End Sub

    Private Sub LabelSucursal_Click(sender As Object, e As EventArgs) Handles LabelSucursal.Click

    End Sub

    Private Sub LabelPuertas_Click(sender As Object, e As EventArgs) Handles LabelPuertas.Click

    End Sub
End Class