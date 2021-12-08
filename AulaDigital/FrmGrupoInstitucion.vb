Public Class FrmGrupoInst
    Public modFrm As Integer = 0 ' 0:agregar 1:editar 2:listar 3:eliminar
    Private Sub BtnDescartar_Click(sender As Object, e As EventArgs) Handles BtnDescartar.Click
        FrmGrupoMateria.ShowDialog()
    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Dispose()
    End Sub

    Private Sub FrmGrupoInst_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class