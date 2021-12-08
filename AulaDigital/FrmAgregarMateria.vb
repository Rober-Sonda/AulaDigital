Public Class FrmAgregarMateria
    Public modFrm As Integer = 0 ' 0:agregar 1:editar 2:listar 3:eliminar
    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Dispose()
    End Sub

    Private Sub FrmAgregarMateria_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class