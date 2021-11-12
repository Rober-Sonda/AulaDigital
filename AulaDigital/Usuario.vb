Public Class FrmUsuario

    Private Sub FrmUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load



    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs)
        Dim Usuario As New Clave
        'Dim passActual As String

        Usuario.Usuario = TxtUsuario.Text
        Usuario.Clave = TxtContrasena.Text
        Usuario.InsertarClave(Usuario.Clave, Usuario.Usuario, "1")
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs)
        Me.Dispose()
    End Sub
End Class