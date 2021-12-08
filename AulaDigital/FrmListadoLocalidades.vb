Public Class FrmListadoLocalidades
    Public modFrm As Integer = 0 ' 0:agregar 1:editar 2:listar 3:eliminar
    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Dispose()
    End Sub

    Private Sub BtnAgregarLocalidad_Click(sender As Object, e As EventArgs) Handles BtnAgregarLocalidad.Click
        Dim frmLocalidades As New FrmLocalidad()
        frmLocalidades.modFrm = 0
        frmLocalidades.ShowDialog()
        Dim localidad As New Localidad
        localidad.ListarLocalidades(DgvLocalidades)
    End Sub

    Private Sub BtnEliminarLocalidad_Click(sender As Object, e As EventArgs) Handles BtnEliminarLocalidad.Click
        Dim localidad As New Localidad
        Try
            Dim row As DataGridViewRow = DgvLocalidades.CurrentRow
            If (row Is Nothing) Then
                Exit Sub
            End If
            Dim idLocalidad As Integer = CInt(row.Cells(0).Value)
            localidad.EliminarLocalidad(idLocalidad)
            localidad.ListarLocalidades(DgvLocalidades)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnListarLocalidades_Click(sender As Object, e As EventArgs) Handles BtnListarLocalidades.Click
        Dim localidad As New Localidad
        localidad.ListarLocalidades(DgvLocalidades)
    End Sub

    Private Sub FrmListadoLocalidades_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EstiloGrillas(DgvLocalidades)
        Dim Localidad As New Localidad
        Localidad.ListarLocalidades(DgvLocalidades)
        OcultarPrimerColumna(DgvLocalidades)
        OcultarUltimaColumna(DgvLocalidades)
        SeleccionarPrimerFila(DgvLocalidades)
    End Sub

    Private Sub BtnModificarLocalidad_Click(sender As Object, e As EventArgs) Handles BtnModificarLocalidad.Click
        Dim row As DataGridViewRow = DgvLocalidades.CurrentRow
        If (row Is Nothing) Then
            Exit Sub
        End If
        Dim localidad As New Localidad
        Try
            Dim frmLocalidades As New FrmLocalidad
            If (DgvLocalidades.Rows.Count > 0) Then
                Dim idLocalidad As Integer = CInt(row.Cells(0).Value)
            End If
            localidad.Nombre = CStr(row.Cells(1).Value)
            localidad.CPostal = CLng(row.Cells(2).Value)
            frmLocalidades.TxtNombreLocalidad.Text = localidad.Nombre
            frmLocalidades.TxtCPostal.Text = CStr(localidad.CPostal)

            frmLocalidades.ShowDialog()
            localidad.ListarLocalidades(DgvLocalidades)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Class