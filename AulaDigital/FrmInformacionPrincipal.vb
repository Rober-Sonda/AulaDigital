Public Class FrmInformacion
    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs)
        Dim frmInstitucion As New FrmAgregarInst
        frmInstitucion.ShowDialog()
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs)
        Dim frmInstitucion As New FrmAgregarInst
        frmInstitucion.ShowDialog()
    End Sub

    Private Sub FrmInformacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (btnSelected = TYPE_MATERIA) Then
            Dim Materias As New Materia
            Materias.ListarMaterias(DgvInformacionPrincipal)
            OcultarPrimerColumna(DgvInformacionPrincipal)
            OcultarUltimaColumna(DgvInformacionPrincipal)
        End If
        If (btnSelected = TYPE_ALUMNO) Then
            Dim Alumnos As New Alumnos
            Alumnos.ListarAlumnos(DgvInformacionPrincipal)
            OcultarPrimerColumna(DgvInformacionPrincipal)
            OcultarUltimaColumna(DgvInformacionPrincipal)
        End If

        If (btnSelected = TYPE_CARRERA) Then
            Dim Carreras As New Carrera
            OcultarUltimaColumna(DgvInformacionPrincipal)
            Carreras.ListarCarreras(DgvInformacionPrincipal)
            OcultarPrimerColumna(DgvInformacionPrincipal)
            OcultarUltimaColumna(DgvInformacionPrincipal)
            OcultarUltimaColumna(DgvInformacionPrincipal)
        End If
        EstiloGrillas(DgvInformacionPrincipal)
    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs)
        Me.Dispose()
    End Sub
End Class