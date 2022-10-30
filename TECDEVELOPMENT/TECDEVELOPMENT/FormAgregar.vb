Imports System.Data.SqlClient

Public Class FormAgregar
    Dim con As New SqlConnection("Data Source=DESKTOP-KH7N6DR\SQLEXPRESS;Initial Catalog=Datos_TECDEVELOPMENT;Persist Security Info=True;User ID=sa;Password=12345678")

    Private Sub ButtonAgregar_Click(sender As Object, e As EventArgs) Handles ButtonAgregar.Click


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
        If Modelo = "" Or anio = "" Or precio = "" Or Tipo = "" Or Consumo = "" Or Ciudad = "" Or Sucursal = "" Or stock = "" Or puertas = "" Or Marca = "" Then
            MsgBox("No puede dejar campos vacios")
        Else
            con.Open() ''abrimos conexion
            Dim command As New SqlCommand("insert into Autos values('" & Marca & "','" & Modelo & "','" & precio & "','" & Tipo & "','" & Consumo & "','" & Ciudad & "','" & Sucursal & "','" & puertas & "','" & stock & "','" & anio & "')", con)
            command.ExecuteNonQuery()
            con.Close() ''cerramos conexion
            MessageBox.Show("Agregado correctamente")
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
            TextBoxModelo.Focus()
        End If


    End Sub

    Private Sub ButtonInicio_Click(sender As Object, e As EventArgs) Handles ButtonInicio.Click
        FormProductos.Show()
        Me.Close()
    End Sub

    Private Sub ButtonCsesion_Click(sender As Object, e As EventArgs) Handles ButtonCsesion.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub FormAgregar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


End Class