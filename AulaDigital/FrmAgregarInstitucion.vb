Imports System.Data.OleDb
Public Class FrmAgregarInst
    Public modFrm As Integer = 0 ' 0:agregar 1:editar 2:listar 3:eliminar
    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs)
        Dim mInstitucion As New Institucion
        Dim newTelefono As New Telefonos
        'existeUsuario = newUser.ComprobarCampoClave
        Dim ultimoIdInstitucion As Integer = 0
        ' Usuario.Usuario = TxtContrasena.Text
        'Dim cn As OleDbConnection = New OleDbConnection
        'cn = conexion
        Dim tran As IDbTransaction = Nothing
        Try
            'cn.Open()
            ultimoIdInstitucion = CInt(mInstitucion.UltimaInstitucion())
            tran = conexion.BeginTransaction
            'run some queries here
            mInstitucion.Nombre = TxtNombre.Text
            mInstitucion.Direccion = TxtDirecion.Text
            mInstitucion.Mail = TxtMail.Text
            mInstitucion.ESTADO = 1
            mInstitucion.Id_Localidad = 0
            'se agrega la institucion 
            'los telefonos toman el id de la nueva institucion consultando a la base la ultima inst agregada
            'podemos crear un trigger en la tabla de instituciones para que cada ingreso agregue en la tabla de telefonos
            ' en cada ingreso (probar con trigger)
            newTelefono.AgregarTelefono(ultimoIdInstitucion, CInt(TxtCodAreaCel.Text), CLng(TxtCelular.Text), 0, tran)
            newTelefono.AgregarTelefono(ultimoIdInstitucion, CInt(TxtCodAreaTel.Text), CLng(TxtTelefono.Text), 1, tran)
            tran.Commit()
        Catch ex As Exception
            'If (cn.State = ConnectionState.Open) Then
            '    cn.Close()
            'End If
            If Not tran Is Nothing Then tran.Rollback()
            MsgBox(ex.Message)
        Finally
            'cn.Close()
        End Try
    End Sub

    Private Sub btnAgregarLocalidad_Click(sender As Object, e As EventArgs)
        Dim Localidad As New FrmLocalidad
        Localidad.modFrm = 0
        Localidad.ShowDialog()
    End Sub

    Private Sub BtnDescartar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Dispose()
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub FrmAgregarInst_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class