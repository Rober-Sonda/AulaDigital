Public Class FrmGrupoMateria
    Public modFrm As Integer = 0 ' 0:agregar 1:editar 2:listar 3:eliminar
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FrmAgregarAlumno.ShowDialog()
    End Sub

    Private Sub FrmGrupoMateria_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class