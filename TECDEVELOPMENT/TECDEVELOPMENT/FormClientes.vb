Imports System.Data.SqlClient
Public Class FormClientes

    Dim con As New SqlConnection("Data Source=DESKTOP-KH7N6DR\SQLEXPRESS;Initial Catalog=Datos_TECDEVELOPMENT;Persist Security Info=True;User ID=sa;Password=12345678")

    Public dato As String

    Private Sub ButtonBuscar_Click(sender As Object, e As EventArgs) Handles ButtonBuscar.Click
        con.Open()


        Dim Tb As String = TextoBuscar.Text()
        Dim command As New SqlCommand("select * from Clientes where ID_Cliente= '" & Tb & "'", con)
        Dim sda As New SqlDataAdapter(command)
        Dim dt As New DataTable
        sda.Fill(dt)
        DataGridView1.DataSource = dt

        con.Close()
    End Sub

    Private Sub ButtonInicio_Click(sender As Object, e As EventArgs) Handles ButtonInicio.Click
        formaMenu.Show()
        Me.Close()

    End Sub

    Private Sub LoadDataGrid() ''para actualizar los datos en la tabla

        Dim command As New SqlCommand("select * from Clientes", con) ''seleccionamos los datos de la tabla
        Dim sda As New SqlDataAdapter(command)
        Dim dt As New DataTable
        sda.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub FormClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataGrid()
    End Sub

    Private Sub ButtonAbonos_Click(sender As Object, e As EventArgs) Handles ButtonAbonos.Click
        FormAbonos.Show()
        Me.Close()
    End Sub

    Private Sub ButtonCsesion_Click(sender As Object, e As EventArgs) Handles ButtonCsesion.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub ButtonActualizar_Click(sender As Object, e As EventArgs) Handles ButtonActualizar.Click
        FormActualizarCliente.Show()
        Me.Close()
    End Sub
End Class