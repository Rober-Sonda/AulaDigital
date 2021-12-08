Public Class FrmLocalidad
    Public modFrm As Integer = 0 ' 0:agregar 1:editar 2:listar 3:eliminar
    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Dim newLocalidad As New Localidad
        If (newLocalidad.VerificarDatos(TxtNombreLocalidad.Text, TxtCPostal.Text)) Then
            newLocalidad.Nombre = TxtNombreLocalidad.Text
            newLocalidad.CPostal = CLng(TxtCPostal.Text)
            newLocalidad.AgregarLocalidad(newLocalidad)
            Me.Dispose()
        End If
    End Sub

    Private Sub FrmLocalidad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtNombreLocalidad.Focus()
    End Sub

    Private Sub BtnDescartar_Click(sender As Object, e As EventArgs) Handles BtnDescartar.Click
        Me.Dispose()
    End Sub
End Class