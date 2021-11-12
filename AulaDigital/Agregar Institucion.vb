Public Class FrmAgregarInst
    Private Sub LblLista_Click(sender As Object, e As EventArgs) Handles LblLista.Click

    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Dim newInstitucion As New Institucion
        Dim newTelefono As New Telefonos
        'existeUsuario = newUser.ComprobarCampoClave
        If (newInstitucion.ExisteInstitucion) Then

            'Dim passActual As String
            Dim passCorrecta As Boolean
            ' Usuario.Usuario = TxtContrasena.Text
            newInstitucion.Nombre = TxtNombre.Text
            newInstitucion.Direccion = TxtDirecion.Text
            newInstitucion.Mail = TxtMail.Text
            'se agrega la institucion 
            'los telefonos toman el id de la nueva institucion consultando a la base la ultima inst agregada
            'podemos crear un trigger en la tabla de instituciones para que cada ingreso agregue en la tabla de telefonos
            ' en cada ingreso (probar con trigger)
            newTelefono.AgregarTelefono()
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
End Class