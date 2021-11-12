Public Class FrmLocalidad
    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs)
        Dim newLocalidad As New Localidad
        If (newLocalidad.VerificarDatos(TxtNombreLocalidad.Text, TxtCPostal.Text)) Then
            newLocalidad.Nombre = TxtNombreLocalidad.Text
            newLocalidad.CPostal = TxtCPostal.Text
            newLocalidad.AgregarLocalidad(newLocalidad)
            Me.Dispose()
        End If
    End Sub

    Private Sub FrmLocalidad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtNombreLocalidad.Focus()
    End Sub

    Private Sub BtnDescartar_Click_1(sender As Object, e As EventArgs)
        Me.Dispose()
    End Sub
End Class