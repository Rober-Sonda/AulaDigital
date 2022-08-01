Public Class FrmTelCel
    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        vbYesNo = False
        Me.Dispose()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click


        vbYesNo = True
    End Sub

    Private Sub FrmTelCel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtCodArea.Focus()
    End Sub
End Class