Public Class FrmMenuPrincipal
    Public flagBackForm As Integer = 1
    Private currentForm As Form = Nothing
    Private Sub FrmMenuPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        PanelSideMenu.AutoScroll = False
        PanelSideMenu.VerticalScroll.Maximum = 0
        PanelSideMenu.VerticalScroll.Visible = False
        PanelSideMenu.HorizontalScroll.Maximum = 0
        PanelSideMenu.HorizontalScroll.Visible = False
        PanelSideMenu.AutoScroll = True
        OcultarSubmenu()

    End Sub

    Private Sub btnAsistencia_Click(sender As Object, e As EventArgs) Handles btnAsistencia.Click
        abrirFormHijo(New FrmTomarAsistencia, 0, flagBackForm)
    End Sub

    Private Sub MostrarSubmenu(submenu As Panel)

        If submenu.Visible = False Then
            OcultarSubmenu()
            submenu.Visible = True
        Else
            submenu.Visible = False
        End If

    End Sub

    Private Sub OcultarSubmenu()
        'submenúes 
        PanelInstitucionSubmenu.Visible = False
        PanelCarrerasSubmenu.Visible = False
        PanelMateriasSubmenu.Visible = False
        PanelAlumnosSubMenu.Visible = False
        PanelCursoSubmenu.Visible = False
    End Sub

    Private Sub btnInstituciones_Click(sender As Object, e As EventArgs) Handles btnInstituciones.Click
        MostrarSubmenu(PanelInstitucionSubmenu)
        Dim frmListado As FrmListados = New FrmListados
        frmListado.listado = "Instituciones"
        abrirFormHijo(frmListado, 0, flagBackForm)
    End Sub

    Private Sub btnCarreras_Click(sender As Object, e As EventArgs) Handles btnCarreras.Click
        MostrarSubmenu(PanelCarrerasSubmenu)
        Dim frmListado As FrmListados = New FrmListados
        frmListado.listado = "Carreras"
        abrirFormHijo(frmListado, 0, flagBackForm)
    End Sub

    Private Sub btnTools_Click(sender As Object, e As EventArgs) Handles btnMaterias.Click
        MostrarSubmenu(PanelMateriasSubmenu)
        Dim frmListado As FrmListados = New FrmListados
        frmListado.listado = "Materias"
        abrirFormHijo(frmListado, 0, flagBackForm)
    End Sub

    Private Sub btnAlumnos_Click(sender As Object, e As EventArgs) Handles btnAlumnos.Click
        MostrarSubmenu(PanelAlumnosSubMenu)
        Dim frmListado As FrmListados = New FrmListados
        frmListado.listado = "Alumnos"
        abrirFormHijo(frmListado, 0, flagBackForm)
    End Sub
    Public Sub abrirFormHijo(childForm As Form, funcForm As Integer, closeBackForm As Integer) ' 0: Agreagr 1: Editar 2: Eliminar 3: Consultar
        If (closeBackForm > 0) Then
            If currentForm IsNot Nothing Then currentForm.Close()
        End If
        currentForm = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        PanelChildForm.Controls.Add(childForm)
        PanelChildForm.Tag = childForm
        childForm.BringToFront()
        childForm.Tag = funcForm
        childForm.Show()
    End Sub

    Private Sub btnAgregarInstitucion_Click(sender As Object, e As EventArgs) Handles btnAgregarInstitucion.Click
        abrirFormHijo(New FrmAgregarInst, 0, flagBackForm)
    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click, btnSalir.Click
        Me.Dispose()
    End Sub

    Private Sub btnCursos_Click(sender As Object, e As EventArgs) Handles btnCursos.Click
        MostrarSubmenu(PanelCursoSubmenu)
        Dim frmListado As FrmListados = New FrmListados
        frmListado.listado = "Cursos"
        abrirFormHijo(frmListado, 0, flagBackForm)
    End Sub

    Private Sub btn_AgregarAlumno_Click(sender As Object, e As EventArgs) Handles btn_AgregarAlumno.Click
        abrirFormHijo(New FrmAgregarAlumno, 0, flagBackForm)
    End Sub

    Private Sub btnAgregarCarreras_Click(sender As Object, e As EventArgs) Handles btnAgregarCarreras.Click
        abrirFormHijo(New FrmAgregarCarrera, 0, flagBackForm)
    End Sub

    Private Sub btnAgregarMateria_Click(sender As Object, e As EventArgs) Handles btnAgregarMateria.Click
        abrirFormHijo(New FrmAgregarMateria, 0, flagBackForm)
    End Sub

    Private Sub btnAdd_Int_Career_Mat_Click(sender As Object, e As EventArgs) Handles btnAdd_Int_Career_Mat.Click
        'codigo consulta a listados de instituciones y se llena el datagrid con dataset
        'en este formulario se van a administrar instituciones carreras y materias
        abrirFormHijo(New FrmGrupoInst, 0, flagBackForm)
    End Sub

    Private Sub btnAgregarCursos_Click(sender As Object, e As EventArgs) Handles btnAgregarCursos.Click

    End Sub

    Private Sub btnListarMaterias_Click(sender As Object, e As EventArgs) Handles btnListarMaterias.Click

    End Sub
End Class