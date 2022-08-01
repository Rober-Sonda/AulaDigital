Public Class FrmIniciar
    Public frmPrincipal As New FrmMenuPrincipal

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
                frmPrincipal.ShowDialog()
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
        TxtContrasena.Focus()
    End Sub

    Private Sub LblOlvido_Click(sender As Object, e As EventArgs)
        FrmUsuario.ShowDialog()
    End Sub

    Private Sub BtnCerrar_Click_1(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Dispose()
    End Sub
End Class