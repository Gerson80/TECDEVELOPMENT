Public Class FormMenu2

    Private Sub FormMenu2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ButtonInven_Click(sender As Object, e As EventArgs) Handles ButtonInven.Click
        FormProductos2.Show()
        Me.Close()
    End Sub

    Private Sub ButtonClientes_Click(sender As Object, e As EventArgs) Handles ButtonClientes.Click
        FormClientes2.Show()
        Me.Close()

    End Sub

    Private Sub Buttoncerrar_Click(sender As Object, e As EventArgs) Handles Buttoncerrar.Click
        Me.Close()
    End Sub
End Class