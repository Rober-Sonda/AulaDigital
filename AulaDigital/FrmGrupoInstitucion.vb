Imports System.Data.OleDb

Public Class FrmGrupoInst
    Public modFrm As Integer = 0 ' 0:agregar 1:editar 2:listar 3:eliminar
    Public tagProgress As Integer = 0 '0 inst 1 carrera 2 Materias
    Public mInstitucion As Institucion
    Public mCarrera As Carrera
    Public mMateras As List(Of Materia)

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs)
        Me.Dispose()
    End Sub

    Private Sub FrmGrupoInst_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mFrmInst = New FrmAgregarInst
        'mFrmInst.btnGuardar.Visible = False
        'AbrirFormHijo(mFrmInst, 0)
        EstiloGrillas(dgvInst, 0)
        EstiloGrillas(dgvCarrera, 0)
        EstiloGrillas(dgvMateria, 0)
        Dim strQuery As String = "SELECT Nombre FROM Institucion where Institucion.ESTADO = 1 ORDER BY Institucion.NOMBRE"
        Dim Adaptador = New OleDbDataAdapter(strQuery, conexion)
        CargarDatagridview(dgvInst, Adaptador)
        strQuery = "SELECT Nombre, Anio_cursada_carrera FROM Carrera where Carrera.ESTADO = 1 ORDER BY Carrera.NOMBRE"
        Adaptador = New OleDbDataAdapter(strQuery, conexion)
        CargarDatagridview(dgvCarrera, Adaptador)
        strQuery = "SELECT Nombre FROM Materia where Materia.ESTADO = 1 ORDER BY Materia.NOMBRE"
        Adaptador = New OleDbDataAdapter(strQuery, conexion)
        CargarDatagridview(dgvMateria, Adaptador)
        PnlCurso.BackColor = BACKCOLORFORMS
        lblTitulo.BackColor = BACKCOLORFORMS

    End Sub

    Private currentForm As Form = Nothing
    Private Sub AbrirFormHijo(childForm As Form, funcForm As Integer) ' 0: Agreagr 1: Editar 2: Eliminar 3: Consultar
        If currentForm IsNot Nothing Then currentForm.Close()
        currentForm = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        PnlCurso.Controls.Add(childForm)
        PnlCurso.Tag = childForm
        childForm.BringToFront()
        childForm.Tag = funcForm
        childForm.Show()
    End Sub

    Private Sub btnAgregarInst_Click(sender As Object, e As EventArgs) Handles btnAgregarInst.Click
        Dim mFrmInst = New FrmAgregarInst
        mFrmInst.TransparencyKey = Color.DimGray
        'mFrmInst.StartPosition = FormStartPosition.CenterParent
        'Dim pt As New System.Drawing.Point(200, 200)
        mFrmInst.WindowState = FormWindowState.Maximized
        mFrmInst.ShowDialog()

    End Sub

    Private Sub btnAgregarCarrera_Click(sender As Object, e As EventArgs) Handles btnAgregarCarrera.Click
        Dim mFrmCarrer = New FrmAgregarCarrera
        mFrmCarrer.TransparencyKey = Color.DimGray
        'mFrmInst.StartPosition = FormStartPosition.CenterParent

        mFrmCarrer.ShowDialog()
    End Sub

    Private Sub btnAgregarMateria_Click(sender As Object, e As EventArgs) Handles btnAgregarMateria.Click
        Dim mFrmMateria = New FrmAgregarMateria
        mFrmMateria.TransparencyKey = Color.DimGray
        'mFrmInst.StartPosition = FormStartPosition.CenterParent

        mFrmMateria.ShowDialog()
    End Sub

    Private Sub BtnDescartar_Click(sender As Object, e As EventArgs) Handles BtnDescartar.Click
        AcceptCancel = False
        Me.Dispose()
    End Sub

    Public Sub CargarDatagridview(ByVal tabla As DataGridView, ByVal Adaptador As OleDbDataAdapter)
        Try
            Dim dataS As New DataSet
            Adaptador.Fill(dataS, "Institucion")
            tabla.DataSource = dataS.Tables("Institucion")
        Catch ex As Exception
            Console.WriteLine(ex.ToString)
        End Try
    End Sub

    Private Sub btnCrearClase_Click(sender As Object, e As EventArgs) Handles btnCrearClase.Click

    End Sub

    Private Sub PnlCurso_Paint(sender As Object, e As PaintEventArgs) Handles PnlCurso.Paint

    End Sub
End Class