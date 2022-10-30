Imports System.Data.SqlClient
Public Class FormActualizarCliente
    Dim con As New SqlConnection("Data Source=DESKTOP-KH7N6DR\SQLEXPRESS;Initial Catalog=Datos_TECDEVELOPMENT;Persist Security Info=True;User ID=sa;Password=12345678")

    Private cadenaConexion As String = "Data Source=DESKTOP-KH7N6DR\SQLEXPRESS;Initial Catalog=Datos_TECDEVELOPMENT;Persist Security Info=True;User ID=sa;Password=12345678"
    Public IDD
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


    Private Sub ButtonAtras_Click(sender As Object, e As EventArgs) Handles ButtonAtras.Click
        FormClientes.Show()
        Me.Close()
    End Sub

    Private Sub ButtonCsesion_Click(sender As Object, e As EventArgs) Handles ButtonCsesion.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub ButtonActualizar_Click(sender As Object, e As EventArgs) Handles ButtonActualizar.Click
        Dim Telefono = TextBoxTelefono.Text() ''variable se lo asignamos a un texbox
        Dim Correo = TextBoxCorreo.Text()
        Dim Ciudad = TextBoxCIudad.Text()
        Dim Domicilio = TextBoxDomicilio.Text()
        Dim Nombre = TextBoxNombre.Text()

        Dim buscar = TextoBuscar.Text()


        If dato = "" Then
            MsgBox("Seleccione un dato primero")
        Else
            If Nombre = "" Or Telefono = "" Or Correo = "" Or Ciudad = "" Or Domicilio = "" Then
                MsgBox("No deje campos vacios")
            Else
                con.Open()
                Dim command As New SqlCommand("update Clientes set ID_AutoVendido='" & IDD & "', Nombre='" & Nombre & "', Telefono='" & Telefono & "', Correo='" & Correo & "', Ciudad_estado='" & Ciudad & "', Domicilio='" & Domicilio & "' where ID_Cliente = '" & dato & "' ", con)
                command.ExecuteNonQuery()
                con.Close()

                MessageBox.Show("actualizado")
                LoadDataGrid()
                TextBoxTelefono.Clear()
                TextBoxCorreo.Clear()
                TextBoxCIudad.Clear()
                TextBoxDomicilio.Clear()
                TextBoxCIudad.Clear()
                TextBoxNombre.Clear()
                TextoBuscar.Focus()
            End If
            
        End If


        
    End Sub

    Private Sub LoadDataGrid() ''para actualizar los datos en la tabla

        Dim command As New SqlCommand("select * from Clientes", con) ''seleccionamos los datos de la tabla
        Dim sda As New SqlDataAdapter(command)
        Dim dt As New DataTable
        sda.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub FormActualizar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataGrid()
    End Sub

    Private Sub DataGridView1_CellClick1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        dato = DataGridView1.Item(0, i).Value()
        IDD = DataGridView1.Item(1, i).Value()
        'MsgBox(Datoscompartidos.Dato)
    End Sub

    Private Sub FormActualizarCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class