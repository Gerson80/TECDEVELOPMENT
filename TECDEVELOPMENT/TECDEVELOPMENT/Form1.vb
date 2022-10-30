Imports System.Data.SqlClient

Public Class Form1
    Private cadenaConexion As String = "Data Source=DESKTOP-KH7N6DR\SQLEXPRESS;Initial Catalog=Datos_TECDEVELOPMENT;Persist Security Info=True;User ID=sa;Password=12345678"


    Private tempcorrelativo As String
    Private Sub IniciarSesion_Click(sender As Object, e As EventArgs) Handles IniciarSesion.Click

    Dim usuario As String = txtUsuario.Text
    Dim contraseña As String = txtContraseña.Text
    ' Configuramos una conexión con la base de datos de SQL Server
    '
        Using cnn As New SqlConnection(cadenaConexion)

    ' Creamos el comando
    Dim cmd As SqlCommand = cnn.CreateCommand()

    ' Construimos la consulta T-SQL que deseamos ejecutar
    '
            cmd.CommandText = "SELECT users FROM usuarios WHERE users='" & usuario & "'"

    ' Abrimos la conexión
            cnn.Open()

    ' Ejecutamos la consulta
    Dim value As Object = cmd.ExecuteScalar()

    ' Pasamos el valor a la variable
            tempcorrelativo = Convert.ToString(value)
            If tempcorrelativo = txtUsuario.Text Then
                cmd.CommandText = "SELECT password FROM usuarios WHERE password='" & contraseña & "'"
    Dim value2 As Object = cmd.ExecuteScalar()
                tempcorrelativo = Convert.ToString(value2)
                If tempcorrelativo = txtContraseña.Text Then

                    cmd.CommandText = "SELECT nivel FROM usuarios WHERE users='" & value & "'"
    Dim value3 As Object = cmd.ExecuteScalar()
                    tempcorrelativo = Convert.ToString(value3)
                    If value3 = "Administrador" Then
                        txtUsuario.Clear()
                        txtContraseña.Clear()
                        txtUsuario.Focus()
                        cnn.Close()
                        formaMenu.Show()
                        Me.Hide()
                    Else
                        txtUsuario.Clear()
                        txtContraseña.Clear()
                        txtUsuario.Focus()
                        cnn.Close()
                        FormMenu2.Show()
                        Me.Hide()
                    End If

                Else
                    txtUsuario.Clear()
                    txtContraseña.Clear()
                    txtUsuario.Focus()
                    MsgBox("Usuario o contraseña incorrecta")
                End If

            Else

                txtUsuario.Clear()
                txtContraseña.Clear()
                txtUsuario.Focus()
                MsgBox("Usuario o contraseña incorrecta")

            End If


        End Using


    End Sub


    Private Sub botonCancelar_Click(sender As Object, e As EventArgs) Handles botonCancelar.Click
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
