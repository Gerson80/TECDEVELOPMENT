Public Class FormCaracteristicas2


    Private Sub FormCaracteristicas2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        FormProductos2.Show()
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
        FormAgregardatosCliente2.Show()
        Me.Close()
    End Sub
End Class