Public Class FrmAgregarMateria
    Public modFrm As Integer = 0 ' 0:agregar 1:editar 2:listar 3:eliminar
    Public idMateria As Integer = 0
    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Dispose()
    End Sub

    Private Sub FrmAgregarMateria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (modFrm = 0) Then
            'agregar
        ElseIf (modFrm = 1) Then
            Dim mMateria As New Materia
            mMateria = mMateria.ConsultarMateria(idMateria)
        ElseIf (modFrm = 2) Then

        End If
    End Sub
End Class