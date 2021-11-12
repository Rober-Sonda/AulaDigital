Public Class FrmIniciar

    Private Sub LblOlvido_Click(sender As Object, e As EventArgs) Handles LblOlvido.Click
        FrmUsuario.ShowDialog()
    End Sub

    Private Sub LblCambiar_Click(sender As Object, e As EventArgs)
        'FrmUsuario.ShowDialog()

    End Sub



    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click

        Dim existeUsuario As Boolean
        Dim newUser As New Clave
        existeUsuario = newUser.ComprobarCampoClave
        If (existeUsuario) Then
            Dim Usuario As New Clave
            'Dim passActual As String
            Dim passCorrecta As Boolean
            ' Usuario.Usuario = TxtContrasena.Text
            Usuario.Clave = TxtContrasena.Text
            passCorrecta = Usuario.CompararClaves(Usuario.Clave)
            If (passCorrecta) Then
                FrmMenu.ShowDialog()
                Me.Close()
            Else
                MsgBox("Contraseña incorrecta", vbInformation)
            End If
        Else
            FrmUsuario.Show()
            Exit Sub
        End If
    End Sub

    Private Sub FrmIniciar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Enlace()
    End Sub
End Class