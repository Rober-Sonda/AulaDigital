Imports System.Data.OleDb
Public Class FrmAgregarInst
    Public modFrm As Integer = 0 ' 0:agregar 1:editar 2:listar 3:eliminar
    Private currentForm As Form = Nothing
    Dim mFrmLocalidad As FrmLocalidad = Nothing
    Dim mFrmTelCel As FrmTelCel = Nothing
    Dim flagBackForm As Integer = 1
    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs)
        Dim mInstitucion As New Institucion
        Dim newTelefono As New Telefonos
        Dim row As DataGridViewRow = dgvTelCelInst.CurrentRow

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
            mInstitucion.Direccion = TxtDireccion.Text
            mInstitucion.Mail = TxtMail.Text
            mInstitucion.ESTADO = 1
            mInstitucion.Id_Localidad = 0
            'se agrega la institucion 
            'los telefonos toman el id de la nueva institucion consultando a la base la ultima inst agregada
            'podemos crear un trigger en la tabla de instituciones para que cada ingreso agregue en la tabla de telefonos
            ' en cada ingreso (probar con trigger)
            Dim cArea As Integer = 0
            Dim cTelCel As Long = 0
            Dim mType As Byte = 0
            For Each row In dgvTelCelInst.Rows
                With row
                    cArea = CInt(.Cells(0).Value)
                    cTelCel = CLng(.Cells(1).Value)
                    mType = CByte(.Cells(2).Value)
                End With
                newTelefono.AgregarTelefono(ultimoIdInstitucion, cArea, cTelCel, mType, tran)
            Next
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

    Private Sub btnAgregarLocalidad_Click(sender As Object, e As EventArgs) Handles btnAgregarLocalidad.Click
        mFrmLocalidad = New FrmLocalidad
        abrirFormHijo(mFrmLocalidad, 0, flagBackForm)
    End Sub

    Private Sub FrmAgregarInst_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PnlInstitucion.BackColor = BACKCOLORFORMS
        TxtNombre.Focus()
    End Sub


    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        vbYesNo = False
        Me.Dispose()
    End Sub

    Private Sub btnGuardar_Click_1(sender As Object, e As EventArgs) Handles btnGuardar.Click

        vbYesNo = True
    End Sub

    Public Sub abrirFormHijo(childForm As Form, funcForm As Integer, closeBackForm As Integer) ' 0: Agreagr 1: Editar 2: Eliminar 3: Consultar
        If (closeBackForm > 0) Then
            If currentForm IsNot Nothing Then currentForm.Close()
        End If

        currentForm = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        PnlInstitucion.Controls.Add(childForm)
        PnlInstitucion.Tag = childForm
        childForm.BringToFront()
        childForm.Tag = funcForm
        'childForm.BackColor = Color.FromArgb(50, Color.Black)
        childForm.Opacity = 0.5
        childForm.Show()
    End Sub

    Private Sub btnAgregarTelCel_Click(sender As Object, e As EventArgs) Handles btnAgregarTelCel.Click
        mFrmTelCel = New FrmTelCel
        mFrmTelCel.TransparencyKey = Color.DimGray
        abrirFormHijo(mFrmTelCel, 0, flagBackForm)
    End Sub
End Class