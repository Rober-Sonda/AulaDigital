Public Class FrmAgregarMateria
    Public modFrm As Integer = 0 ' 0:agregar 1:editar 2:listar 3:eliminar
    Public nMateria As New Materia
    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Dispose()
    End Sub

    Private Sub FrmAgregarMateria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If modFrm = 0 Then LbltitulofrmMateria.Text = "Agregar Materia"
        If modFrm = 1 Then LbltitulofrmMateria.Text = "Editar Materia"
        Me.BackColor = BACKCOLORCONTROLS
        PnlMateria.BackColor = BACKCOLORFORMS
        LbltitulofrmMateria.BackColor = BACKCOLORFORMS
        TxtNombre.BackColor = BACKCOLORFORMS
        lblNombreMateria.ForeColor = VERDE_APP
        LbltitulofrmMateria.ForeColor = VERDE_APP
        Me.TxtNombre.Focus()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If (VerificarDatosEnFormularios(Me)) Then
            nMateria.Nombre = TxtNombre.Text
            nMateria.AgregarMateria(nMateria)
            TxtNombre.Clear()
        End If
    End Sub
End Class