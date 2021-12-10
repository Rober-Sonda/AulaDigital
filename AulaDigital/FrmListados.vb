Public Class FrmListados
    Public titulo As String
    Public listado As String
    Private Sub FrmListados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LbltitulofrmListado.Text = titulo
        If (listado.Equals("Instituciones")) Then
            'cargar dataset para llenar la grilla
        ElseIf (listado.Equals("Carreras")) Then

        ElseIf (listado.Equals("Materias")) Then

        ElseIf (listado.Equals("Alumnos")) Then

        End If
    End Sub
End Class