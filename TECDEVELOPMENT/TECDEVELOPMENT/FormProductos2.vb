Imports System.Data.SqlClient
Public Class FormProductos2
    Dim con As New SqlConnection("Data Source=DESKTOP-KH7N6DR\SQLEXPRESS;Initial Catalog=Datos_TECDEVELOPMENT;Persist Security Info=True;User ID=sa;Password=12345678")

    Public dato As String



    Private Sub ButtonBuscar_Click(sender As Object, e As EventArgs) Handles ButtonBuscar.Click


        con.Open()


        Dim Tb As String = TextoBuscarAu.Text()
        Dim command As New SqlCommand("select * from Autos where ID_Auto= '" & Tb & "'", con)
        Dim sda As New SqlDataAdapter(command)
        Dim dt As New DataTable
        sda.Fill(dt)
        DataGridView1.DataSource = dt


        con.Close()

    End Sub


    Private Sub ButtonInicio_Click(sender As Object, e As EventArgs) Handles ButtonInicio.Click
        FormMenu2.Show()
        Me.Close()
    End Sub

    Private Sub ButtonAbonos_Click(sender As Object, e As EventArgs) Handles ButtonAbonos.Click
        FormAbonos2.Show()
        Me.Close()
    End Sub



    Private Sub ButtonCsesion_Click(sender As Object, e As EventArgs) Handles ButtonCsesion.Click
        Form1.Show()
        Me.Close()
    End Sub


    Private Sub LoadDataGrid() ''para actualizar los datos en la tabla

        Dim command As New SqlCommand("select * from Autos", con) ''seleccionamos los datos de la tabla
        Dim sda As New SqlDataAdapter(command)
        Dim dt As New DataTable
        sda.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub FormProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataGrid()
    End Sub


    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index

        Datoscompartidos.ID = DataGridView1.Item(0, i).Value()
        Datoscompartidos.Marca = DataGridView1.Item(1, i).Value()
        Datoscompartidos.Modelo = DataGridView1.Item(2, i).Value()
        Datoscompartidos.precio = DataGridView1.Item(3, i).Value()
        Datoscompartidos.Tipo = DataGridView1.Item(4, i).Value()
        Datoscompartidos.Consumo = DataGridView1.Item(5, i).Value()
        Datoscompartidos.Ciudad = DataGridView1.Item(6, i).Value()
        Datoscompartidos.Sucursal = DataGridView1.Item(7, i).Value()
        Datoscompartidos.puertas = DataGridView1.Item(8, i).Value()
        Datoscompartidos.stock = DataGridView1.Item(9, i).Value()
        Datoscompartidos.anio = DataGridView1.Item(10, i).Value()


    End Sub


    Private Sub ButtonSeleccionarProductos_Click(sender As Object, e As EventArgs) Handles ButtonSeleccionarProductos.Click
        If Datoscompartidos.anio = "" Then
            MsgBox("Seleccione un vehiculo primero")
        Else
            FormCaracteristicas2.Show()
            Me.Close()
        End If
    End Sub
End Class