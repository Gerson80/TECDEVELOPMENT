Imports System.Data.SqlClient
Public Class FormUsuarios
    Public Dato As String
    Public IDD
    Dim con As New SqlConnection("Data Source=DESKTOP-KH7N6DR\SQLEXPRESS;Initial Catalog=Datos_TECDEVELOPMENT;Persist Security Info=True;User ID=sa;Password=12345678")
    Private cadenaConexion As String = "Data Source=DESKTOP-KH7N6DR\SQLEXPRESS;Initial Catalog=Datos_TECDEVELOPMENT;Persist Security Info=True;User ID=sa;Password=12345678"

    Public Usuario ''variable se lo asignamos a un texbox

    Public Contraseña
    Public Nivel

    Private Sub LoadDataGrid() ''para actualizar los datos en la tabla

        Dim command As New SqlCommand("select * from usuarios", con) ''seleccionamos los datos de la tabla
        Dim sda As New SqlDataAdapter(command)
        Dim dt As New DataTable
        sda.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub DataGridView1_CellClick1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        Dato = DataGridView1.Item(0, i).Value()
        IDD = DataGridView1.Item(1, i).Value()
        'MsgBox(Datoscompartidos.Dato)
    End Sub


    Private Sub FormUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataGrid()

    End Sub

    Private Sub ButtonAgregar_Click(sender As Object, e As EventArgs) Handles ButtonAgregar.Click
        Usuario = TextBoxUsuario.Text()
        Contraseña = TextBoxContraseña.Text()
        Nivel = TextBoxNivel.Text()
        If Usuario = "" Or Contraseña = "" Or Nivel = "" Then
            MsgBox("No puede dejar las casilla sin llenar")
        Else
            If Nivel = "Administrador " Or Nivel = "Normal" Then
                con.Open() ''abrimos conexion
                Dim command As New SqlCommand("insert into usuarios values('" & Usuario & "','" & Contraseña & "','" & Nivel & "')", con)
                command.ExecuteNonQuery()
                con.Close() ''cerramos conexion
                MsgBox("Dato ingresado")
                TextBoxUsuario.Clear()
                TextBoxContraseña.Clear()
                TextBoxNivel.Clear()
                LoadDataGrid()
            Else
                MsgBox("Los niveles solo pueden ser 'Administrador' o 'Normal'")
            End If
            
        End If


    End Sub

    Private Sub ButtonAtras_Click(sender As Object, e As EventArgs) Handles ButtonAtras.Click
        formaMenu.Show()
        Me.Close()

    End Sub

    Private Sub ButtonActualizar_Click(sender As Object, e As EventArgs) Handles ButtonActualizar.Click
        Usuario = TextBoxUsuario.Text()
        Contraseña = TextBoxContraseña.Text()
        Nivel = TextBoxNivel.Text()

        If Dato = "" Then
            MsgBox("Seleccione un dato primero")
        Else

            If Usuario = "" Or Contraseña = "" Or Nivel = "" Then
                MsgBox("No puede dejar las casillas sin llenar")
            Else
                If Nivel = "Administrador " Or Nivel = "Normal" Then
                    con.Open()
                    Dim command As New SqlCommand("update usuarios set users='" & Usuario & "', password='" & Contraseña & "', nivel='" & Nivel & "' where ID_Usuario = '" & Dato & "' ", con)
                    command.ExecuteNonQuery()
                    con.Close()
                    MsgBox("Dato actualizado")
                    TextBoxUsuario.Clear()
                    TextBoxContraseña.Clear()
                    TextBoxNivel.Clear()
                    LoadDataGrid()
                Else
                    MsgBox("Los niveles solo pueden ser 'Administrador' o 'Normal'")
                End If
                
            End If
        End If

        

    End Sub

    Private Sub ButtonELiminar_Click(sender As Object, e As EventArgs) Handles ButtonELiminar.Click
        If MessageBox.Show("Seguro que lo quieres eliminar? ", "Eliminar dato", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Dim no = "si"
            If Dato = "" Then
                MsgBox("Seleccione un dato primero")
            Else
                con.Open()
                Dim command As New SqlCommand("delete usuarios where ID_Usuario = '" & Dato & "'", con)
                command.ExecuteNonQuery()
                MessageBox.Show("Eliminado correctamente")
                con.Close()
                LoadDataGrid()

            End If
            

           

        End If
    End Sub

    Private Sub ButtonBuscar_Click(sender As Object, e As EventArgs) Handles ButtonBuscar.Click
        con.Open()

        Dim Tb As String = TextoBuscar.Text()
        Dim command As New SqlCommand("select * from usuarios where ID_Usuario= '" & Tb & "'", con)
        Dim sda As New SqlDataAdapter(command)
        Dim dt As New DataTable
        sda.Fill(dt)
        DataGridView1.DataSource = dt

        con.Close()
    End Sub

    Private Sub ButtonCsesion_Click(sender As Object, e As EventArgs) Handles ButtonCsesion.Click
        Form1.Show()
        Me.Close()

    End Sub
End Class