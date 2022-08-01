<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMenuPrincipal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMenuPrincipal))
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.PanelChildForm = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PanelSideMenu = New System.Windows.Forms.Panel()
        Me.PanelAlumnosSubMenu = New System.Windows.Forms.Panel()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.btn_AgregarAlumno = New System.Windows.Forms.Button()
        Me.btnAlumnos = New System.Windows.Forms.Button()
        Me.PanelMateriasSubmenu = New System.Windows.Forms.Panel()
        Me.btnListarMaterias = New System.Windows.Forms.Button()
        Me.btnEliminarMateria = New System.Windows.Forms.Button()
        Me.button12 = New System.Windows.Forms.Button()
        Me.btnAgregarMateria = New System.Windows.Forms.Button()
        Me.btnMaterias = New System.Windows.Forms.Button()
        Me.PanelCarrerasSubmenu = New System.Windows.Forms.Panel()
        Me.button6 = New System.Windows.Forms.Button()
        Me.button7 = New System.Windows.Forms.Button()
        Me.btnAgregarCarreras = New System.Windows.Forms.Button()
        Me.btnCarreras = New System.Windows.Forms.Button()
        Me.PanelCursoSubmenu = New System.Windows.Forms.Panel()
        Me.btnEliminarCurso = New System.Windows.Forms.Button()
        Me.btnEditarCurso = New System.Windows.Forms.Button()
        Me.btnAgregarCursos = New System.Windows.Forms.Button()
        Me.btnCursos = New System.Windows.Forms.Button()
        Me.btnAdd_Int_Career_Mat = New System.Windows.Forms.Button()
        Me.btnAsistencia = New System.Windows.Forms.Button()
        Me.PanelInstitucionSubmenu = New System.Windows.Forms.Panel()
        Me.btnEliminarInst = New System.Windows.Forms.Button()
        Me.btnEditarInst = New System.Windows.Forms.Button()
        Me.btnAgregarInstitucion = New System.Windows.Forms.Button()
        Me.btnInstituciones = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.panelLogo = New System.Windows.Forms.Panel()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtnMinimizar = New System.Windows.Forms.Button()
        Me.BtnMaximizar = New System.Windows.Forms.Button()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.LbltitulofrmInstitucion = New System.Windows.Forms.Label()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelChildForm.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.PanelSideMenu.SuspendLayout()
        Me.PanelAlumnosSubMenu.SuspendLayout()
        Me.PanelMateriasSubmenu.SuspendLayout()
        Me.PanelCarrerasSubmenu.SuspendLayout()
        Me.PanelCursoSubmenu.SuspendLayout()
        Me.PanelInstitucionSubmenu.SuspendLayout()
        Me.panelLogo.SuspendLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox9
        '
        Me.PictureBox9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox9.Image = CType(resources.GetObject("PictureBox9.Image"), System.Drawing.Image)
        Me.PictureBox9.Location = New System.Drawing.Point(250, 0)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(529, 613)
        Me.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox9.TabIndex = 0
        Me.PictureBox9.TabStop = False
        '
        'PanelChildForm
        '
        Me.PanelChildForm.BackColor = System.Drawing.Color.FloralWhite
        Me.PanelChildForm.Controls.Add(Me.PictureBox9)
        Me.PanelChildForm.Controls.Add(Me.Panel3)
        Me.PanelChildForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelChildForm.Location = New System.Drawing.Point(0, 38)
        Me.PanelChildForm.Name = "PanelChildForm"
        Me.PanelChildForm.Size = New System.Drawing.Size(779, 613)
        Me.PanelChildForm.TabIndex = 5
        '
        'Panel3
        '
        Me.Panel3.AutoSize = True
        Me.Panel3.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel3.Controls.Add(Me.PanelSideMenu)
        Me.Panel3.Controls.Add(Me.btnSalir)
        Me.Panel3.Controls.Add(Me.panelLogo)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(250, 613)
        Me.Panel3.TabIndex = 1
        '
        'PanelSideMenu
        '
        Me.PanelSideMenu.AutoScroll = True
        Me.PanelSideMenu.BackColor = System.Drawing.Color.Transparent
        Me.PanelSideMenu.Controls.Add(Me.PanelAlumnosSubMenu)
        Me.PanelSideMenu.Controls.Add(Me.btnAlumnos)
        Me.PanelSideMenu.Controls.Add(Me.PanelMateriasSubmenu)
        Me.PanelSideMenu.Controls.Add(Me.btnMaterias)
        Me.PanelSideMenu.Controls.Add(Me.PanelCarrerasSubmenu)
        Me.PanelSideMenu.Controls.Add(Me.btnCarreras)
        Me.PanelSideMenu.Controls.Add(Me.PanelCursoSubmenu)
        Me.PanelSideMenu.Controls.Add(Me.btnCursos)
        Me.PanelSideMenu.Controls.Add(Me.btnAdd_Int_Career_Mat)
        Me.PanelSideMenu.Controls.Add(Me.btnAsistencia)
        Me.PanelSideMenu.Controls.Add(Me.PanelInstitucionSubmenu)
        Me.PanelSideMenu.Controls.Add(Me.btnInstituciones)
        Me.PanelSideMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelSideMenu.Location = New System.Drawing.Point(0, 92)
        Me.PanelSideMenu.Name = "PanelSideMenu"
        Me.PanelSideMenu.Size = New System.Drawing.Size(250, 476)
        Me.PanelSideMenu.TabIndex = 14
        '
        'PanelAlumnosSubMenu
        '
        Me.PanelAlumnosSubMenu.AutoSize = True
        Me.PanelAlumnosSubMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.PanelAlumnosSubMenu.Controls.Add(Me.Button9)
        Me.PanelAlumnosSubMenu.Controls.Add(Me.Button11)
        Me.PanelAlumnosSubMenu.Controls.Add(Me.btn_AgregarAlumno)
        Me.PanelAlumnosSubMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelAlumnosSubMenu.Location = New System.Drawing.Point(0, 835)
        Me.PanelAlumnosSubMenu.Name = "PanelAlumnosSubMenu"
        Me.PanelAlumnosSubMenu.Size = New System.Drawing.Size(233, 120)
        Me.PanelAlumnosSubMenu.TabIndex = 10
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.Gray
        Me.Button9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button9.FlatAppearance.BorderSize = 0
        Me.Button9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Button9.ForeColor = System.Drawing.Color.Gainsboro
        Me.Button9.Image = CType(resources.GetObject("Button9.Image"), System.Drawing.Image)
        Me.Button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button9.Location = New System.Drawing.Point(0, 80)
        Me.Button9.Name = "Button9"
        Me.Button9.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.Button9.Size = New System.Drawing.Size(233, 40)
        Me.Button9.TabIndex = 2
        Me.Button9.Text = "Eliminar Alumno"
        Me.Button9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button9.UseCompatibleTextRendering = True
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Button11
        '
        Me.Button11.BackColor = System.Drawing.Color.Gray
        Me.Button11.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button11.FlatAppearance.BorderSize = 0
        Me.Button11.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Button11.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Button11.ForeColor = System.Drawing.Color.Gainsboro
        Me.Button11.Image = CType(resources.GetObject("Button11.Image"), System.Drawing.Image)
        Me.Button11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button11.Location = New System.Drawing.Point(0, 40)
        Me.Button11.Name = "Button11"
        Me.Button11.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.Button11.Size = New System.Drawing.Size(233, 40)
        Me.Button11.TabIndex = 1
        Me.Button11.Text = "Editar Alumno"
        Me.Button11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button11.UseCompatibleTextRendering = True
        Me.Button11.UseVisualStyleBackColor = False
        '
        'btn_AgregarAlumno
        '
        Me.btn_AgregarAlumno.BackColor = System.Drawing.Color.Gray
        Me.btn_AgregarAlumno.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_AgregarAlumno.FlatAppearance.BorderSize = 0
        Me.btn_AgregarAlumno.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.btn_AgregarAlumno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.btn_AgregarAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_AgregarAlumno.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.btn_AgregarAlumno.ForeColor = System.Drawing.Color.Gainsboro
        Me.btn_AgregarAlumno.Image = CType(resources.GetObject("btn_AgregarAlumno.Image"), System.Drawing.Image)
        Me.btn_AgregarAlumno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_AgregarAlumno.Location = New System.Drawing.Point(0, 0)
        Me.btn_AgregarAlumno.Name = "btn_AgregarAlumno"
        Me.btn_AgregarAlumno.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btn_AgregarAlumno.Size = New System.Drawing.Size(233, 40)
        Me.btn_AgregarAlumno.TabIndex = 0
        Me.btn_AgregarAlumno.Text = "Agregar Alumno"
        Me.btn_AgregarAlumno.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_AgregarAlumno.UseCompatibleTextRendering = True
        Me.btn_AgregarAlumno.UseVisualStyleBackColor = False
        '
        'btnAlumnos
        '
        Me.btnAlumnos.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnAlumnos.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnAlumnos.FlatAppearance.BorderSize = 0
        Me.btnAlumnos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnAlumnos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnAlumnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAlumnos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnAlumnos.ForeColor = System.Drawing.Color.GhostWhite
        Me.btnAlumnos.Image = CType(resources.GetObject("btnAlumnos.Image"), System.Drawing.Image)
        Me.btnAlumnos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAlumnos.Location = New System.Drawing.Point(0, 790)
        Me.btnAlumnos.Name = "btnAlumnos"
        Me.btnAlumnos.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnAlumnos.Size = New System.Drawing.Size(233, 45)
        Me.btnAlumnos.TabIndex = 11
        Me.btnAlumnos.Text = "Alumnos"
        Me.btnAlumnos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAlumnos.UseCompatibleTextRendering = True
        Me.btnAlumnos.UseVisualStyleBackColor = False
        '
        'PanelMateriasSubmenu
        '
        Me.PanelMateriasSubmenu.AutoSize = True
        Me.PanelMateriasSubmenu.BackColor = System.Drawing.Color.Gray
        Me.PanelMateriasSubmenu.Controls.Add(Me.btnListarMaterias)
        Me.PanelMateriasSubmenu.Controls.Add(Me.btnEliminarMateria)
        Me.PanelMateriasSubmenu.Controls.Add(Me.button12)
        Me.PanelMateriasSubmenu.Controls.Add(Me.btnAgregarMateria)
        Me.PanelMateriasSubmenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelMateriasSubmenu.Location = New System.Drawing.Point(0, 630)
        Me.PanelMateriasSubmenu.Name = "PanelMateriasSubmenu"
        Me.PanelMateriasSubmenu.Size = New System.Drawing.Size(233, 160)
        Me.PanelMateriasSubmenu.TabIndex = 7
        '
        'btnListarMaterias
        '
        Me.btnListarMaterias.BackColor = System.Drawing.Color.Gray
        Me.btnListarMaterias.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnListarMaterias.FlatAppearance.BorderSize = 0
        Me.btnListarMaterias.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.btnListarMaterias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.btnListarMaterias.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnListarMaterias.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.btnListarMaterias.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnListarMaterias.Image = CType(resources.GetObject("btnListarMaterias.Image"), System.Drawing.Image)
        Me.btnListarMaterias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnListarMaterias.Location = New System.Drawing.Point(0, 120)
        Me.btnListarMaterias.Name = "btnListarMaterias"
        Me.btnListarMaterias.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btnListarMaterias.Size = New System.Drawing.Size(233, 40)
        Me.btnListarMaterias.TabIndex = 3
        Me.btnListarMaterias.Text = "Horarios de materias"
        Me.btnListarMaterias.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnListarMaterias.UseCompatibleTextRendering = True
        Me.btnListarMaterias.UseVisualStyleBackColor = False
        '
        'btnEliminarMateria
        '
        Me.btnEliminarMateria.BackColor = System.Drawing.Color.Gray
        Me.btnEliminarMateria.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnEliminarMateria.FlatAppearance.BorderSize = 0
        Me.btnEliminarMateria.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.btnEliminarMateria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.btnEliminarMateria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminarMateria.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.btnEliminarMateria.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnEliminarMateria.Image = CType(resources.GetObject("btnEliminarMateria.Image"), System.Drawing.Image)
        Me.btnEliminarMateria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEliminarMateria.Location = New System.Drawing.Point(0, 80)
        Me.btnEliminarMateria.Name = "btnEliminarMateria"
        Me.btnEliminarMateria.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btnEliminarMateria.Size = New System.Drawing.Size(233, 40)
        Me.btnEliminarMateria.TabIndex = 2
        Me.btnEliminarMateria.Text = "Eliminar Materia"
        Me.btnEliminarMateria.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEliminarMateria.UseCompatibleTextRendering = True
        Me.btnEliminarMateria.UseVisualStyleBackColor = False
        '
        'button12
        '
        Me.button12.BackColor = System.Drawing.Color.Gray
        Me.button12.Dock = System.Windows.Forms.DockStyle.Top
        Me.button12.FlatAppearance.BorderSize = 0
        Me.button12.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.button12.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.button12.ForeColor = System.Drawing.Color.Gainsboro
        Me.button12.Image = CType(resources.GetObject("button12.Image"), System.Drawing.Image)
        Me.button12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button12.Location = New System.Drawing.Point(0, 40)
        Me.button12.Name = "button12"
        Me.button12.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.button12.Size = New System.Drawing.Size(233, 40)
        Me.button12.TabIndex = 1
        Me.button12.Text = "Editar Materia"
        Me.button12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.button12.UseCompatibleTextRendering = True
        Me.button12.UseVisualStyleBackColor = False
        '
        'btnAgregarMateria
        '
        Me.btnAgregarMateria.BackColor = System.Drawing.Color.Gray
        Me.btnAgregarMateria.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnAgregarMateria.FlatAppearance.BorderSize = 0
        Me.btnAgregarMateria.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.btnAgregarMateria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.btnAgregarMateria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarMateria.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.btnAgregarMateria.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnAgregarMateria.Image = CType(resources.GetObject("btnAgregarMateria.Image"), System.Drawing.Image)
        Me.btnAgregarMateria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgregarMateria.Location = New System.Drawing.Point(0, 0)
        Me.btnAgregarMateria.Name = "btnAgregarMateria"
        Me.btnAgregarMateria.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btnAgregarMateria.Size = New System.Drawing.Size(233, 40)
        Me.btnAgregarMateria.TabIndex = 0
        Me.btnAgregarMateria.Text = "Agregar Materia"
        Me.btnAgregarMateria.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAgregarMateria.UseCompatibleTextRendering = True
        Me.btnAgregarMateria.UseVisualStyleBackColor = False
        '
        'btnMaterias
        '
        Me.btnMaterias.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnMaterias.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnMaterias.FlatAppearance.BorderSize = 0
        Me.btnMaterias.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnMaterias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnMaterias.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMaterias.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnMaterias.ForeColor = System.Drawing.Color.GhostWhite
        Me.btnMaterias.Image = CType(resources.GetObject("btnMaterias.Image"), System.Drawing.Image)
        Me.btnMaterias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMaterias.Location = New System.Drawing.Point(0, 585)
        Me.btnMaterias.Name = "btnMaterias"
        Me.btnMaterias.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnMaterias.Size = New System.Drawing.Size(233, 45)
        Me.btnMaterias.TabIndex = 6
        Me.btnMaterias.Text = "Materias"
        Me.btnMaterias.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnMaterias.UseCompatibleTextRendering = True
        Me.btnMaterias.UseVisualStyleBackColor = False
        '
        'PanelCarrerasSubmenu
        '
        Me.PanelCarrerasSubmenu.AutoSize = True
        Me.PanelCarrerasSubmenu.BackColor = System.Drawing.Color.Gray
        Me.PanelCarrerasSubmenu.Controls.Add(Me.button6)
        Me.PanelCarrerasSubmenu.Controls.Add(Me.button7)
        Me.PanelCarrerasSubmenu.Controls.Add(Me.btnAgregarCarreras)
        Me.PanelCarrerasSubmenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelCarrerasSubmenu.Location = New System.Drawing.Point(0, 465)
        Me.PanelCarrerasSubmenu.Name = "PanelCarrerasSubmenu"
        Me.PanelCarrerasSubmenu.Size = New System.Drawing.Size(233, 120)
        Me.PanelCarrerasSubmenu.TabIndex = 4
        '
        'button6
        '
        Me.button6.BackColor = System.Drawing.Color.Gray
        Me.button6.Dock = System.Windows.Forms.DockStyle.Top
        Me.button6.FlatAppearance.BorderSize = 0
        Me.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.button6.ForeColor = System.Drawing.Color.Gainsboro
        Me.button6.Image = CType(resources.GetObject("button6.Image"), System.Drawing.Image)
        Me.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button6.Location = New System.Drawing.Point(0, 80)
        Me.button6.Name = "button6"
        Me.button6.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.button6.Size = New System.Drawing.Size(233, 40)
        Me.button6.TabIndex = 2
        Me.button6.Text = "Eliminar Carrera"
        Me.button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.button6.UseCompatibleTextRendering = True
        Me.button6.UseVisualStyleBackColor = False
        '
        'button7
        '
        Me.button7.BackColor = System.Drawing.Color.Gray
        Me.button7.Dock = System.Windows.Forms.DockStyle.Top
        Me.button7.FlatAppearance.BorderSize = 0
        Me.button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.button7.ForeColor = System.Drawing.Color.Gainsboro
        Me.button7.Image = CType(resources.GetObject("button7.Image"), System.Drawing.Image)
        Me.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button7.Location = New System.Drawing.Point(0, 40)
        Me.button7.Name = "button7"
        Me.button7.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.button7.Size = New System.Drawing.Size(233, 40)
        Me.button7.TabIndex = 1
        Me.button7.Text = "Editar Carrera"
        Me.button7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.button7.UseCompatibleTextRendering = True
        Me.button7.UseVisualStyleBackColor = False
        '
        'btnAgregarCarreras
        '
        Me.btnAgregarCarreras.BackColor = System.Drawing.Color.Gray
        Me.btnAgregarCarreras.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnAgregarCarreras.FlatAppearance.BorderSize = 0
        Me.btnAgregarCarreras.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.btnAgregarCarreras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.btnAgregarCarreras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarCarreras.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.btnAgregarCarreras.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnAgregarCarreras.Image = CType(resources.GetObject("btnAgregarCarreras.Image"), System.Drawing.Image)
        Me.btnAgregarCarreras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgregarCarreras.Location = New System.Drawing.Point(0, 0)
        Me.btnAgregarCarreras.Name = "btnAgregarCarreras"
        Me.btnAgregarCarreras.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btnAgregarCarreras.Size = New System.Drawing.Size(233, 40)
        Me.btnAgregarCarreras.TabIndex = 0
        Me.btnAgregarCarreras.Text = "Agregar Carrera"
        Me.btnAgregarCarreras.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAgregarCarreras.UseCompatibleTextRendering = True
        Me.btnAgregarCarreras.UseVisualStyleBackColor = False
        '
        'btnCarreras
        '
        Me.btnCarreras.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnCarreras.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCarreras.FlatAppearance.BorderSize = 0
        Me.btnCarreras.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnCarreras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnCarreras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCarreras.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnCarreras.ForeColor = System.Drawing.Color.GhostWhite
        Me.btnCarreras.Image = CType(resources.GetObject("btnCarreras.Image"), System.Drawing.Image)
        Me.btnCarreras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCarreras.Location = New System.Drawing.Point(0, 420)
        Me.btnCarreras.Name = "btnCarreras"
        Me.btnCarreras.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnCarreras.Size = New System.Drawing.Size(233, 45)
        Me.btnCarreras.TabIndex = 3
        Me.btnCarreras.Text = "Carreras"
        Me.btnCarreras.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCarreras.UseCompatibleTextRendering = True
        Me.btnCarreras.UseVisualStyleBackColor = False
        '
        'PanelCursoSubmenu
        '
        Me.PanelCursoSubmenu.AutoSize = True
        Me.PanelCursoSubmenu.BackColor = System.Drawing.Color.Gray
        Me.PanelCursoSubmenu.Controls.Add(Me.btnEliminarCurso)
        Me.PanelCursoSubmenu.Controls.Add(Me.btnEditarCurso)
        Me.PanelCursoSubmenu.Controls.Add(Me.btnAgregarCursos)
        Me.PanelCursoSubmenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelCursoSubmenu.Location = New System.Drawing.Point(0, 300)
        Me.PanelCursoSubmenu.Name = "PanelCursoSubmenu"
        Me.PanelCursoSubmenu.Size = New System.Drawing.Size(233, 120)
        Me.PanelCursoSubmenu.TabIndex = 14
        '
        'btnEliminarCurso
        '
        Me.btnEliminarCurso.BackColor = System.Drawing.Color.Gray
        Me.btnEliminarCurso.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnEliminarCurso.FlatAppearance.BorderSize = 0
        Me.btnEliminarCurso.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.btnEliminarCurso.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.btnEliminarCurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminarCurso.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.btnEliminarCurso.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnEliminarCurso.Image = CType(resources.GetObject("btnEliminarCurso.Image"), System.Drawing.Image)
        Me.btnEliminarCurso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEliminarCurso.Location = New System.Drawing.Point(0, 80)
        Me.btnEliminarCurso.Name = "btnEliminarCurso"
        Me.btnEliminarCurso.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btnEliminarCurso.Size = New System.Drawing.Size(233, 40)
        Me.btnEliminarCurso.TabIndex = 2
        Me.btnEliminarCurso.Text = "Eliminar Curso"
        Me.btnEliminarCurso.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEliminarCurso.UseCompatibleTextRendering = True
        Me.btnEliminarCurso.UseVisualStyleBackColor = False
        '
        'btnEditarCurso
        '
        Me.btnEditarCurso.BackColor = System.Drawing.Color.Gray
        Me.btnEditarCurso.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnEditarCurso.FlatAppearance.BorderSize = 0
        Me.btnEditarCurso.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.btnEditarCurso.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.btnEditarCurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditarCurso.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.btnEditarCurso.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnEditarCurso.Image = CType(resources.GetObject("btnEditarCurso.Image"), System.Drawing.Image)
        Me.btnEditarCurso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEditarCurso.Location = New System.Drawing.Point(0, 40)
        Me.btnEditarCurso.Name = "btnEditarCurso"
        Me.btnEditarCurso.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btnEditarCurso.Size = New System.Drawing.Size(233, 40)
        Me.btnEditarCurso.TabIndex = 1
        Me.btnEditarCurso.Text = "Editar Curso"
        Me.btnEditarCurso.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEditarCurso.UseCompatibleTextRendering = True
        Me.btnEditarCurso.UseVisualStyleBackColor = False
        '
        'btnAgregarCursos
        '
        Me.btnAgregarCursos.BackColor = System.Drawing.Color.Gray
        Me.btnAgregarCursos.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnAgregarCursos.FlatAppearance.BorderSize = 0
        Me.btnAgregarCursos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.btnAgregarCursos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.btnAgregarCursos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarCursos.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.btnAgregarCursos.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnAgregarCursos.Image = CType(resources.GetObject("btnAgregarCursos.Image"), System.Drawing.Image)
        Me.btnAgregarCursos.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnAgregarCursos.Location = New System.Drawing.Point(0, 0)
        Me.btnAgregarCursos.Name = "btnAgregarCursos"
        Me.btnAgregarCursos.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btnAgregarCursos.Size = New System.Drawing.Size(233, 40)
        Me.btnAgregarCursos.TabIndex = 0
        Me.btnAgregarCursos.Text = "Agregar  Curso"
        Me.btnAgregarCursos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAgregarCursos.UseCompatibleTextRendering = True
        Me.btnAgregarCursos.UseVisualStyleBackColor = False
        '
        'btnCursos
        '
        Me.btnCursos.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnCursos.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCursos.FlatAppearance.BorderSize = 0
        Me.btnCursos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnCursos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnCursos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCursos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnCursos.ForeColor = System.Drawing.Color.GhostWhite
        Me.btnCursos.Image = CType(resources.GetObject("btnCursos.Image"), System.Drawing.Image)
        Me.btnCursos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCursos.Location = New System.Drawing.Point(0, 255)
        Me.btnCursos.Name = "btnCursos"
        Me.btnCursos.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnCursos.Size = New System.Drawing.Size(233, 45)
        Me.btnCursos.TabIndex = 13
        Me.btnCursos.Text = "Cursos"
        Me.btnCursos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCursos.UseCompatibleTextRendering = True
        Me.btnCursos.UseVisualStyleBackColor = False
        '
        'btnAdd_Int_Career_Mat
        '
        Me.btnAdd_Int_Career_Mat.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnAdd_Int_Career_Mat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAdd_Int_Career_Mat.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnAdd_Int_Career_Mat.FlatAppearance.BorderSize = 0
        Me.btnAdd_Int_Career_Mat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnAdd_Int_Career_Mat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnAdd_Int_Career_Mat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd_Int_Career_Mat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnAdd_Int_Career_Mat.ForeColor = System.Drawing.Color.GhostWhite
        Me.btnAdd_Int_Career_Mat.Image = CType(resources.GetObject("btnAdd_Int_Career_Mat.Image"), System.Drawing.Image)
        Me.btnAdd_Int_Career_Mat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdd_Int_Career_Mat.Location = New System.Drawing.Point(0, 210)
        Me.btnAdd_Int_Career_Mat.Name = "btnAdd_Int_Career_Mat"
        Me.btnAdd_Int_Career_Mat.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnAdd_Int_Career_Mat.Size = New System.Drawing.Size(233, 45)
        Me.btnAdd_Int_Career_Mat.TabIndex = 15
        Me.btnAdd_Int_Career_Mat.Text = "Materias de carrera"
        Me.btnAdd_Int_Career_Mat.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAdd_Int_Career_Mat.UseCompatibleTextRendering = True
        Me.btnAdd_Int_Career_Mat.UseVisualStyleBackColor = False
        '
        'btnAsistencia
        '
        Me.btnAsistencia.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnAsistencia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAsistencia.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnAsistencia.FlatAppearance.BorderSize = 0
        Me.btnAsistencia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnAsistencia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnAsistencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAsistencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnAsistencia.ForeColor = System.Drawing.Color.GhostWhite
        Me.btnAsistencia.Image = CType(resources.GetObject("btnAsistencia.Image"), System.Drawing.Image)
        Me.btnAsistencia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAsistencia.Location = New System.Drawing.Point(0, 165)
        Me.btnAsistencia.Name = "btnAsistencia"
        Me.btnAsistencia.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnAsistencia.Size = New System.Drawing.Size(233, 45)
        Me.btnAsistencia.TabIndex = 5
        Me.btnAsistencia.Text = "Tomar Asistencia"
        Me.btnAsistencia.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAsistencia.UseCompatibleTextRendering = True
        Me.btnAsistencia.UseVisualStyleBackColor = False
        '
        'PanelInstitucionSubmenu
        '
        Me.PanelInstitucionSubmenu.AutoSize = True
        Me.PanelInstitucionSubmenu.BackColor = System.Drawing.Color.Gray
        Me.PanelInstitucionSubmenu.Controls.Add(Me.btnEliminarInst)
        Me.PanelInstitucionSubmenu.Controls.Add(Me.btnEditarInst)
        Me.PanelInstitucionSubmenu.Controls.Add(Me.btnAgregarInstitucion)
        Me.PanelInstitucionSubmenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelInstitucionSubmenu.Location = New System.Drawing.Point(0, 45)
        Me.PanelInstitucionSubmenu.Name = "PanelInstitucionSubmenu"
        Me.PanelInstitucionSubmenu.Size = New System.Drawing.Size(233, 120)
        Me.PanelInstitucionSubmenu.TabIndex = 2
        '
        'btnEliminarInst
        '
        Me.btnEliminarInst.BackColor = System.Drawing.Color.Gray
        Me.btnEliminarInst.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnEliminarInst.FlatAppearance.BorderSize = 0
        Me.btnEliminarInst.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.btnEliminarInst.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.btnEliminarInst.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminarInst.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.btnEliminarInst.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnEliminarInst.Image = CType(resources.GetObject("btnEliminarInst.Image"), System.Drawing.Image)
        Me.btnEliminarInst.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEliminarInst.Location = New System.Drawing.Point(0, 80)
        Me.btnEliminarInst.Name = "btnEliminarInst"
        Me.btnEliminarInst.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btnEliminarInst.Size = New System.Drawing.Size(233, 40)
        Me.btnEliminarInst.TabIndex = 2
        Me.btnEliminarInst.Text = "Eliminar Institución"
        Me.btnEliminarInst.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEliminarInst.UseCompatibleTextRendering = True
        Me.btnEliminarInst.UseVisualStyleBackColor = False
        '
        'btnEditarInst
        '
        Me.btnEditarInst.BackColor = System.Drawing.Color.Gray
        Me.btnEditarInst.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnEditarInst.FlatAppearance.BorderSize = 0
        Me.btnEditarInst.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.btnEditarInst.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.btnEditarInst.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditarInst.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.btnEditarInst.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnEditarInst.Image = CType(resources.GetObject("btnEditarInst.Image"), System.Drawing.Image)
        Me.btnEditarInst.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEditarInst.Location = New System.Drawing.Point(0, 40)
        Me.btnEditarInst.Name = "btnEditarInst"
        Me.btnEditarInst.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btnEditarInst.Size = New System.Drawing.Size(233, 40)
        Me.btnEditarInst.TabIndex = 1
        Me.btnEditarInst.Text = "Editar Institución"
        Me.btnEditarInst.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEditarInst.UseCompatibleTextRendering = True
        Me.btnEditarInst.UseVisualStyleBackColor = False
        '
        'btnAgregarInstitucion
        '
        Me.btnAgregarInstitucion.BackColor = System.Drawing.Color.Gray
        Me.btnAgregarInstitucion.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnAgregarInstitucion.FlatAppearance.BorderSize = 0
        Me.btnAgregarInstitucion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.btnAgregarInstitucion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.btnAgregarInstitucion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarInstitucion.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.btnAgregarInstitucion.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnAgregarInstitucion.Image = CType(resources.GetObject("btnAgregarInstitucion.Image"), System.Drawing.Image)
        Me.btnAgregarInstitucion.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnAgregarInstitucion.Location = New System.Drawing.Point(0, 0)
        Me.btnAgregarInstitucion.Name = "btnAgregarInstitucion"
        Me.btnAgregarInstitucion.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btnAgregarInstitucion.Size = New System.Drawing.Size(233, 40)
        Me.btnAgregarInstitucion.TabIndex = 0
        Me.btnAgregarInstitucion.Text = "Agregar  Institución"
        Me.btnAgregarInstitucion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAgregarInstitucion.UseCompatibleTextRendering = True
        Me.btnAgregarInstitucion.UseVisualStyleBackColor = False
        '
        'btnInstituciones
        '
        Me.btnInstituciones.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnInstituciones.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnInstituciones.FlatAppearance.BorderSize = 0
        Me.btnInstituciones.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnInstituciones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnInstituciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInstituciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnInstituciones.ForeColor = System.Drawing.Color.GhostWhite
        Me.btnInstituciones.Image = CType(resources.GetObject("btnInstituciones.Image"), System.Drawing.Image)
        Me.btnInstituciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInstituciones.Location = New System.Drawing.Point(0, 0)
        Me.btnInstituciones.Name = "btnInstituciones"
        Me.btnInstituciones.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnInstituciones.Size = New System.Drawing.Size(233, 45)
        Me.btnInstituciones.TabIndex = 1
        Me.btnInstituciones.Text = "Instituciones"
        Me.btnInstituciones.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnInstituciones.UseCompatibleTextRendering = True
        Me.btnInstituciones.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnSalir.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnSalir.FlatAppearance.BorderSize = 0
        Me.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnSalir.ForeColor = System.Drawing.Color.GhostWhite
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.Location = New System.Drawing.Point(0, 568)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnSalir.Size = New System.Drawing.Size(250, 45)
        Me.btnSalir.TabIndex = 13
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSalir.UseCompatibleTextRendering = True
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'panelLogo
        '
        Me.panelLogo.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.panelLogo.Controls.Add(Me.pictureBox1)
        Me.panelLogo.Controls.Add(Me.Label1)
        Me.panelLogo.Controls.Add(Me.Label2)
        Me.panelLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelLogo.Location = New System.Drawing.Point(0, 0)
        Me.panelLogo.Name = "panelLogo"
        Me.panelLogo.Size = New System.Drawing.Size(250, 92)
        Me.panelLogo.TabIndex = 5
        '
        'pictureBox1
        '
        Me.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
        Me.pictureBox1.Location = New System.Drawing.Point(0, 25)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.pictureBox1.Size = New System.Drawing.Size(250, 67)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBox1.TabIndex = 0
        Me.pictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Location = New System.Drawing.Point(0, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(250, 12)
        Me.Label1.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(250, 13)
        Me.Label2.TabIndex = 19
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel2.Controls.Add(Me.BtnMinimizar)
        Me.Panel2.Controls.Add(Me.BtnMaximizar)
        Me.Panel2.Controls.Add(Me.BtnCerrar)
        Me.Panel2.Controls.Add(Me.LbltitulofrmInstitucion)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(779, 38)
        Me.Panel2.TabIndex = 99
        '
        'BtnMinimizar
        '
        Me.BtnMinimizar.BackColor = System.Drawing.Color.Transparent
        Me.BtnMinimizar.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtnMinimizar.FlatAppearance.BorderSize = 0
        Me.BtnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMinimizar.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!)
        Me.BtnMinimizar.Image = CType(resources.GetObject("BtnMinimizar.Image"), System.Drawing.Image)
        Me.BtnMinimizar.Location = New System.Drawing.Point(689, 0)
        Me.BtnMinimizar.Name = "BtnMinimizar"
        Me.BtnMinimizar.Size = New System.Drawing.Size(30, 38)
        Me.BtnMinimizar.TabIndex = 68
        Me.BtnMinimizar.UseVisualStyleBackColor = False
        '
        'BtnMaximizar
        '
        Me.BtnMaximizar.BackColor = System.Drawing.Color.Transparent
        Me.BtnMaximizar.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtnMaximizar.FlatAppearance.BorderSize = 0
        Me.BtnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMaximizar.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!)
        Me.BtnMaximizar.Image = CType(resources.GetObject("BtnMaximizar.Image"), System.Drawing.Image)
        Me.BtnMaximizar.Location = New System.Drawing.Point(719, 0)
        Me.BtnMaximizar.Name = "BtnMaximizar"
        Me.BtnMaximizar.Size = New System.Drawing.Size(30, 38)
        Me.BtnMaximizar.TabIndex = 69
        Me.BtnMaximizar.UseVisualStyleBackColor = False
        '
        'BtnCerrar
        '
        Me.BtnCerrar.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtnCerrar.FlatAppearance.BorderSize = 0
        Me.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCerrar.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!)
        Me.BtnCerrar.Image = CType(resources.GetObject("BtnCerrar.Image"), System.Drawing.Image)
        Me.BtnCerrar.Location = New System.Drawing.Point(749, 0)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(30, 38)
        Me.BtnCerrar.TabIndex = 70
        Me.BtnCerrar.UseVisualStyleBackColor = False
        '
        'LbltitulofrmInstitucion
        '
        Me.LbltitulofrmInstitucion.BackColor = System.Drawing.Color.Transparent
        Me.LbltitulofrmInstitucion.Dock = System.Windows.Forms.DockStyle.Left
        Me.LbltitulofrmInstitucion.Font = New System.Drawing.Font("Berlin Sans FB", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbltitulofrmInstitucion.ForeColor = System.Drawing.Color.White
        Me.LbltitulofrmInstitucion.Location = New System.Drawing.Point(0, 0)
        Me.LbltitulofrmInstitucion.Name = "LbltitulofrmInstitucion"
        Me.LbltitulofrmInstitucion.Size = New System.Drawing.Size(230, 38)
        Me.LbltitulofrmInstitucion.TabIndex = 67
        Me.LbltitulofrmInstitucion.Text = "Menu Principal"
        Me.LbltitulofrmInstitucion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmMenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(779, 651)
        Me.Controls.Add(Me.PanelChildForm)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmMenuPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelChildForm.ResumeLayout(False)
        Me.PanelChildForm.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.PanelSideMenu.ResumeLayout(False)
        Me.PanelSideMenu.PerformLayout()
        Me.PanelAlumnosSubMenu.ResumeLayout(False)
        Me.PanelMateriasSubmenu.ResumeLayout(False)
        Me.PanelCarrerasSubmenu.ResumeLayout(False)
        Me.PanelCursoSubmenu.ResumeLayout(False)
        Me.PanelInstitucionSubmenu.ResumeLayout(False)
        Me.panelLogo.ResumeLayout(False)
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents PanelChildForm As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BtnMinimizar As Button
    Friend WithEvents BtnMaximizar As Button
    Friend WithEvents BtnCerrar As Button
    Friend WithEvents LbltitulofrmInstitucion As Label
    Friend WithEvents Panel3 As Panel
    Private WithEvents PanelSideMenu As Panel
    Private WithEvents PanelAlumnosSubMenu As Panel
    Private WithEvents Button9 As Button
    Private WithEvents Button11 As Button
    Private WithEvents btn_AgregarAlumno As Button
    Private WithEvents btnAlumnos As Button
    Private WithEvents PanelMateriasSubmenu As Panel
    Private WithEvents btnEliminarMateria As Button
    Private WithEvents button12 As Button
    Private WithEvents btnAgregarMateria As Button
    Private WithEvents btnMaterias As Button
    Private WithEvents PanelCarrerasSubmenu As Panel
    Private WithEvents button6 As Button
    Private WithEvents button7 As Button
    Private WithEvents btnAgregarCarreras As Button
    Private WithEvents btnCarreras As Button
    Private WithEvents btnAsistencia As Button
    Private WithEvents panelLogo As Panel
    Private WithEvents pictureBox1 As PictureBox
    Private WithEvents btnSalir As Button
    Private WithEvents btnCursos As Button
    Private WithEvents PanelCursoSubmenu As Panel
    Private WithEvents btnEliminarCurso As Button
    Private WithEvents btnEditarCurso As Button
    Private WithEvents btnAgregarCursos As Button
    Private WithEvents btnListarMaterias As Button
    Private WithEvents btnAdd_Int_Career_Mat As Button
    Friend WithEvents Label2 As Label
    Private WithEvents PanelInstitucionSubmenu As Panel
    Private WithEvents btnEliminarInst As Button
    Private WithEvents btnEditarInst As Button
    Private WithEvents btnAgregarInstitucion As Button
    Private WithEvents btnInstituciones As Button
    Friend WithEvents Label1 As Label
End Class
