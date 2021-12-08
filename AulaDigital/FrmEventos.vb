Public Class FrmEventos
    Public modFrm As Integer = 0 ' 0:agregar 1:editar 2:listar 3:eliminar
    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click

    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Dispose()
    End Sub

    Private Sub FrmEventos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class