Public Class FrmAgregarCarrera
    Public mCarrera As New Carrera
    Public modFrm As Integer = 0 ' 0:agregar 1:editar 2:listar 3:eliminar


    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        vbYesNo = True
        Me.Dispose()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If (VerificarDatosEnFormularios(Me)) Then
            mCarrera.Nombre = TxtNombre.Text
            mCarrera.Duracion_Carrera = CByte(TxtDuracion.Text)
            mCarrera.AgregarCarrera(mCarrera)
            AcceptCancel = True
            TxtNombre.Clear()
            TxtDuracion.Clear()
            TxtNombre.Focus()
        End If
        vbYesNo = True
    End Sub

    Private Sub FrmAgregarCarrera_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If modFrm = 0 Then LbltitulofrmCarrera.Text = "Agregar Carrera"
        If modFrm = 1 Then LbltitulofrmCarrera.Text = "Editar Carrera"


        TxtNombre.Focus()
    End Sub
End Class