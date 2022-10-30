Imports System.Data.SqlClient
Public Class FormActualizar
    Dim con As New SqlConnection("Data Source=DESKTOP-KH7N6DR\SQLEXPRESS;Initial Catalog=Datos_TECDEVELOPMENT;Persist Security Info=True;User ID=sa;Password=12345678")
    Public dato As String
    Private Sub ButtonBuscar_Click(sender As Object, e As EventArgs) Handles ButtonBuscar.Click
        con.Open()

        Dim Tb As String = TextoBuscar.Text()
        Dim command As New SqlCommand("select * from Autos where ID_Auto= '" & dato & "'", con)
        Dim sda As New SqlDataAdapter(command)
        Dim dt As New DataTable
        sda.Fill(dt)
        DataGridView1.DataSource = dt

        con.Close()
    End Sub


    Private Sub ButtonAtras_Click(sender As Object, e As EventArgs) Handles ButtonAtras.Click
        FormProductos.Show()
        Me.Close()
    End Sub

    Private Sub ButtonCsesion_Click(sender As Object, e As EventArgs) Handles ButtonCsesion.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub ButtonActualizar_Click(sender As Object, e As EventArgs) Handles ButtonActualizar.Click
        Dim Modelo = TextBoxModelo.Text() ''variable se lo asignamos a un texbox
        Dim anio = TextBoxAnio.Text()
        Dim precio = TextBoxPrecio.Text()
        Dim Tipo = TextBoxTipo.Text()
        Dim Consumo = TextBoxGasolina.Text()
        Dim Ciudad = TextBoxCiudad.Text()
        Dim Sucursal = TextBoxSucursal.Text()
        Dim stock = TextBoxStock.Text()
        Dim puertas = TextBoxPuertsas.Text()
        Dim Marca = TextBoxMarca.Text()

        Dim buscar = TextoBuscar.Text()



        If dato = "" Then
            MsgBox("Seleccione un dato primero")
        Else

            If Modelo = "" Or anio = "" Or precio = "" Or Tipo = "" Or Consumo = "" Or Ciudad = "" Or Sucursal = "" Or stock = "" Or puertas = "" Or Marca = "" Then
                MsgBox("No puede dejar campos vacios")
            Else
                con.Open()
                Dim command As New SqlCommand("update Autos set Marca='" & Marca & "', Modelo='" & Modelo & "', Precio='" & precio & "', Tipo_Transmicion='" & Tipo & "', Consumo_gasolina='" & Consumo & "', Ciudad='" & Ciudad & "', Sucursal='" & Sucursal & "', No_puertas='" & puertas & "', Stock='" & stock & "', Anio='" & anio & "' where ID_Auto = '" & dato & "' ", con)
                command.ExecuteNonQuery()
                con.Close()

                MessageBox.Show("actualizado")
                LoadDataGrid()
                TextBoxModelo.Clear()
                TextBoxAnio.Clear()
                TextBoxPrecio.Clear()
                TextBoxTipo.Clear()
                TextBoxGasolina.Clear()
                TextBoxCiudad.Clear()
                TextBoxSucursal.Clear()
                TextBoxStock.Clear()
                TextBoxPuertsas.Clear()
                TextBoxMarca.Clear()
                TextoBuscar.Focus()
            End If
        End If
        
    End Sub

    Private Sub LoadDataGrid() ''para actualizar los datos en la tabla

        Dim command As New SqlCommand("select * from Autos", con) ''seleccionamos los datos de la tabla
        Dim sda As New SqlDataAdapter(command)
        Dim dt As New DataTable
        sda.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub ButtonBorrar_Click(sender As Object, e As EventArgs) Handles ButtonBorrar.Click
        If MessageBox.Show("Seguro que lo quieres eliminar? ", "Eliminar dato", MessageBoxButtons.YesNo) = DialogResult.Yes Then


            Dim Tid As String = TextoBuscar.Text
            con.Open()
            Dim command As New SqlCommand("delete Autos where ID_Auto = '" & Tid & "'", con)
            command.ExecuteNonQuery()
            MessageBox.Show("Eliminado correctamente")
            con.Close()
            LoadDataGrid()

        End If
    End Sub

    Private Sub FormActualizar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataGrid()
    End Sub

    Private Sub DataGridView1_CellClick1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        dato = DataGridView1.Item(0, i).Value()
        'MsgBox(Datoscompartidos.Dato)
    End Sub

    Private Sub ButtonAgregar_Click(sender As Object, e As EventArgs)

    End Sub
End Class