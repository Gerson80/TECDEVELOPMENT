Public Class formaMenu

    Private Sub ButtonInven_Click(sender As Object, e As EventArgs) Handles ButtonInven.Click
        FormProductos.Show()
        Me.Close()
    End Sub

    Private Sub ButtonClientes_Click(sender As Object, e As EventArgs) Handles ButtonClientes.Click
        FormClientes.Show()
        Me.Close()

    End Sub


    Private Sub ButtonADU_Click(sender As Object, e As EventArgs) Handles ButtonADU.Click
        FormUsuarios.Show()
        Me.Close()
    End Sub

    Private Sub Buttoncerrar_Click(sender As Object, e As EventArgs) Handles Buttoncerrar.Click
        Me.Close()
    End Sub

    Private Sub formaMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class