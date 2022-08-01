Public Class FrmLocalidad
    Public modFrm As Integer = 0 ' 0:agregar 1:editar 2:listar 3:eliminar
    Dim mLocalidad As New Localidad
    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs)
        Dim newLocalidad As New Localidad
        If (newLocalidad.VerificarDatos(TxtNombreLocalidad.Text, TxtCPostal.Text)) Then
            newLocalidad.Nombre = TxtNombreLocalidad.Text
            newLocalidad.CPostal = CLng(TxtCPostal.Text)
            newLocalidad.AgregarLocalidad(newLocalidad)
            Me.Dispose()
        End If
    End Sub

    Private Sub FrmLocalidad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PnlLocalidad.BackColor = BACKCOLORFORMS
        'lblCPostal.ForeColor = COLORTEXT

        TxtNombreLocalidad.Focus()
    End Sub

    Private Sub BtnDescartar_Click(sender As Object, e As EventArgs) Handles BtnDescartar.Click
        vbYesNo = False
        Me.Dispose()
    End Sub

    Private Sub BtnGuardarLocalidad_Click(sender As Object, e As EventArgs) Handles BtnGuardarLocalidad.Click
        If (VerificarDatosEnFormularios(Me)) Then
            mLocalidad.Nombre = TxtNombreLocalidad.Text
            mLocalidad.CPostal = CLng(TxtCPostal.Text)
            mLocalidad.AgregarLocalidad(mLocalidad)
            TxtNombreLocalidad.Clear()
            TxtCPostal.Clear()
            TxtNombreLocalidad.Focus()
        End If
        vbYesNo = True
        Me.Dispose()
    End Sub
End Class