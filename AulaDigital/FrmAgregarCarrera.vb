Public Class FrmAgregarCarrera
    Public modFrm As Integer = 0 ' 0:agregar 1:editar 2:listar 3:eliminar
    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Dispose()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Dispose()
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click

    End Sub

    Private Sub FrmAgregarCarrera_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class