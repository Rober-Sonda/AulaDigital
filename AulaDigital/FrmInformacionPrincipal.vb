Public Class FrmInformacion
    Public modFrm As Integer = 0 ' 0:agregar 1:editar 2:listar 3:eliminar
    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        Dim frmInstitucion As New FrmAgregarInst
        frmInstitucion.ShowDialog()
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
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
    Private Sub BtnCerrar_Click_1(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Dispose()
    End Sub
End Class