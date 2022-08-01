Imports System.Data.OleDb
Imports System.Data.SqlClient
Public Class FrmAgregarAlumno
    Public modFrm As Integer = 0 ' 0:agregar 1:editar 2:listar 3:eliminar
    Public idAlumno As Integer = 0
    Public alumno As New Alumnos
    Dim flagBackForm As Integer = 1
    Private currentForm As Form = Nothing
    Dim NeedUpdate As Integer = 1
    Dim mFrmLocalidad As FrmLocalidad = Nothing
    Private Sub Agregar_alumno_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'AcceptCancel = True
            CmbLocalidadAlumno.Refresh()
            LlenarCombo(CmbLocalidadAlumno, "Localidad", "Nombre", "Id_Localidad")
            If (modFrm = 1) Then
                Dim mLocal As New Localidad
                alumno = alumno.ConsultarAlumno(alumno.IdAlumnos)
                TxtNombre.Text = alumno.Nombre
                TxtApellidoAlumno.Text = alumno.Apellido
                TxtDomicilio.Text = alumno.Domicilio
                CmbLocalidadAlumno.Text = mLocal.ConsultarLocalidad(alumno.IdLocalidad).Nombre
                'CmbLocalidadAlumno.SelectedValue = alumno.IdLocalidad
                TxtDNIAlumno.Text = CStr(alumno.DNI)
                TxtCelular.Text = alumno.Telefono
                TxtMail.Text = alumno.Mail
                ChkAlumnoTrabaja.Checked = alumno.Trabaja
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        PnlAlumnos.BackColor = BACKCOLORFORMS
        LbltitulofrmAlumno.BackColor = BACKCOLORFORMS
        TxtNombre.Focus()
    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        vbYesNo = False
        Me.Dispose()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If (VerificarDatosEnFormularios(Me)) Then
            alumno.Nombre = TxtNombre.Text
            alumno.Apellido = TxtApellidoAlumno.Text
            alumno.Domicilio = TxtDomicilio.Text
            alumno.IdLocalidad = CInt(CmbLocalidadAlumno.SelectedValue)
            alumno.DNI = CInt(TxtDNIAlumno.Text)
            alumno.Telefono = TxtCelular.Text
            alumno.Mail = TxtMail.Text
            alumno.Trabaja = ChkAlumnoTrabaja.Checked
            If (modFrm = 0) Then
                alumno.AgregarAlumno(alumno)
            ElseIf (modFrm = 1) Then
                alumno.EditarAlumno(alumno)
            End If
            Limpiar_TextBox_ComboBox(Me)
            TxtNombre.Focus()

        End If
        vbYesNo = True
        Me.Dispose()
    End Sub

    Private Sub btnAgregarLocalidad_Click(sender As Object, e As EventArgs) Handles btnAgregarLocalidad.Click
        mFrmLocalidad = New FrmLocalidad
        abrirFormHijo(mFrmLocalidad, 0, flagBackForm)
    End Sub

    Public Sub abrirFormHijo(childForm As Form, funcForm As Integer, closeBackForm As Integer) ' 0: Agreagr 1: Editar 2: Eliminar 3: Consultar
        If (closeBackForm > 0) Then
            If currentForm IsNot Nothing Then currentForm.Close()
        End If
        currentForm = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        PnlAlumnos.Controls.Add(childForm)
        PnlAlumnos.Tag = childForm
        childForm.BringToFront()
        childForm.Tag = funcForm
        childForm.BackColor = childForm.BackColor
        childForm.TransparencyKey = childForm.BackColor
        childForm.Opacity = 0.5
        childForm.Show()
    End Sub

    Private Sub tmrRefrescos_Tick(sender As Object, e As EventArgs) Handles tmrRefrescos.Tick
        If (False) Then
            CmbLocalidadAlumno.Refresh()
            LlenarCombo(CmbLocalidadAlumno, "Localidad", "Nombre", "Id_Localidad")
            AcceptCancel = False
        End If
        NeedUpdate += 1
    End Sub


End Class