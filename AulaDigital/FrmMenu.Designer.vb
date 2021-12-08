<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMenu
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
        Me.PnlEventos = New Guna.UI2.WinForms.Guna2Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Dgv_ListaAlumnos = New System.Windows.Forms.DataGridView()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnNuevoEvento = New System.Windows.Forms.Button()
        Me.LblEvento = New System.Windows.Forms.Label()
        Me.TxtEvento = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.PnlTit = New System.Windows.Forms.Panel()
        Me.LblHora = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.LblFecha = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.PnlMenu = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.BtnBackup = New System.Windows.Forms.Button()
        Me.BtnResumenC = New System.Windows.Forms.Button()
        Me.BtnResumen = New System.Windows.Forms.Button()
        Me.BtnInformes = New System.Windows.Forms.Button()
        Me.BtnLocalidades = New System.Windows.Forms.Button()
        Me.BtnAlumnos = New System.Windows.Forms.Button()
        Me.PnlGrupos = New Guna.UI2.WinForms.Guna2Panel()
        Me.PnlInformacion = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.BtnAgregarAlumno = New System.Windows.Forms.Button()
        Me.BtnMateria = New System.Windows.Forms.Button()
        Me.BtnCarrera = New System.Windows.Forms.Button()
        Me.BtnInstitucion = New System.Windows.Forms.Button()
        Me.BtnInformacion = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.BtnCrearGrupo = New System.Windows.Forms.Button()
        Me.BtnGrupos = New System.Windows.Forms.Button()
        Me.BtnAsistencia = New System.Windows.Forms.Button()
        Me.PnlTitulo = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.PnlBotones = New Guna.UI2.WinForms.Guna2Panel()
        Me.BtnMinimizar = New System.Windows.Forms.Button()
        Me.BtnMaximizar = New System.Windows.Forms.Button()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.PnlEventos.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.Dgv_ListaAlumnos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.PnlTit.SuspendLayout()
        Me.PnlMenu.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.PnlGrupos.SuspendLayout()
        Me.PnlInformacion.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.PnlBotones.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlEventos
        '
        Me.PnlEventos.BackColor = System.Drawing.Color.Gainsboro
        Me.PnlEventos.BorderColor = System.Drawing.Color.Gray
        Me.PnlEventos.BorderRadius = 2
        Me.PnlEventos.BorderThickness = 2
        Me.PnlEventos.Controls.Add(Me.Panel3)
        Me.PnlEventos.Controls.Add(Me.Panel2)
        Me.PnlEventos.Controls.Add(Me.PnlTit)
        Me.PnlEventos.Dock = System.Windows.Forms.DockStyle.Right
        Me.PnlEventos.Location = New System.Drawing.Point(774, 38)
        Me.PnlEventos.Name = "PnlEventos"
        Me.PnlEventos.ShadowDecoration.Parent = Me.PnlEventos
        Me.PnlEventos.Size = New System.Drawing.Size(250, 617)
        Me.PnlEventos.TabIndex = 8
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.Dgv_ListaAlumnos)
        Me.Panel3.Controls.Add(Me.BtnGuardar)
        Me.Panel3.Controls.Add(Me.BtnNuevoEvento)
        Me.Panel3.Controls.Add(Me.LblEvento)
        Me.Panel3.Controls.Add(Me.TxtEvento)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 255)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(250, 370)
        Me.Panel3.TabIndex = 13
        '
        'Dgv_ListaAlumnos
        '
        Me.Dgv_ListaAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_ListaAlumnos.Location = New System.Drawing.Point(19, 138)
        Me.Dgv_ListaAlumnos.Name = "Dgv_ListaAlumnos"
        Me.Dgv_ListaAlumnos.Size = New System.Drawing.Size(210, 210)
        Me.Dgv_ListaAlumnos.TabIndex = 66
        '
        'BtnGuardar
        '
        Me.BtnGuardar.BackColor = System.Drawing.Color.MediumAquamarine
        Me.BtnGuardar.FlatAppearance.BorderSize = 0
        Me.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGuardar.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!)
        Me.BtnGuardar.Location = New System.Drawing.Point(19, 93)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(211, 27)
        Me.BtnGuardar.TabIndex = 65
        Me.BtnGuardar.Text = "Guardar Evento"
        Me.BtnGuardar.UseVisualStyleBackColor = False
        '
        'BtnNuevoEvento
        '
        Me.BtnNuevoEvento.BackColor = System.Drawing.Color.MediumAquamarine
        Me.BtnNuevoEvento.FlatAppearance.BorderSize = 0
        Me.BtnNuevoEvento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNuevoEvento.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!)
        Me.BtnNuevoEvento.Location = New System.Drawing.Point(202, 11)
        Me.BtnNuevoEvento.Name = "BtnNuevoEvento"
        Me.BtnNuevoEvento.Size = New System.Drawing.Size(27, 27)
        Me.BtnNuevoEvento.TabIndex = 64
        Me.BtnNuevoEvento.UseVisualStyleBackColor = False
        '
        'LblEvento
        '
        Me.LblEvento.AutoSize = True
        Me.LblEvento.Location = New System.Drawing.Point(16, 20)
        Me.LblEvento.Name = "LblEvento"
        Me.LblEvento.Size = New System.Drawing.Size(26, 13)
        Me.LblEvento.TabIndex = 11
        Me.LblEvento.Text = "Hoy"
        '
        'TxtEvento
        '
        Me.TxtEvento.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtEvento.DefaultText = ""
        Me.TxtEvento.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtEvento.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtEvento.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtEvento.DisabledState.Parent = Me.TxtEvento
        Me.TxtEvento.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtEvento.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtEvento.FocusedState.Parent = Me.TxtEvento
        Me.TxtEvento.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtEvento.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtEvento.HoverState.Parent = Me.TxtEvento
        Me.TxtEvento.Location = New System.Drawing.Point(19, 44)
        Me.TxtEvento.Name = "TxtEvento"
        Me.TxtEvento.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtEvento.PlaceholderText = ""
        Me.TxtEvento.SelectedText = ""
        Me.TxtEvento.ShadowDecoration.Parent = Me.TxtEvento
        Me.TxtEvento.Size = New System.Drawing.Size(210, 36)
        Me.TxtEvento.TabIndex = 10
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.MonthCalendar1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 70)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(250, 185)
        Me.Panel2.TabIndex = 12
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.BackColor = System.Drawing.SystemColors.Window
        Me.MonthCalendar1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MonthCalendar1.Location = New System.Drawing.Point(0, 0)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 3
        '
        'PnlTit
        '
        Me.PnlTit.BackColor = System.Drawing.Color.Transparent
        Me.PnlTit.Controls.Add(Me.LblHora)
        Me.PnlTit.Controls.Add(Me.LblFecha)
        Me.PnlTit.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlTit.Location = New System.Drawing.Point(0, 0)
        Me.PnlTit.Name = "PnlTit"
        Me.PnlTit.Size = New System.Drawing.Size(250, 70)
        Me.PnlTit.TabIndex = 11
        '
        'LblHora
        '
        Me.LblHora.BackColor = System.Drawing.Color.Transparent
        Me.LblHora.Font = New System.Drawing.Font("Berlin Sans FB", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHora.Location = New System.Drawing.Point(19, 9)
        Me.LblHora.Name = "LblHora"
        Me.LblHora.Size = New System.Drawing.Size(53, 28)
        Me.LblHora.TabIndex = 1
        Me.LblHora.Text = "Hora"
        '
        'LblFecha
        '
        Me.LblFecha.BackColor = System.Drawing.Color.Transparent
        Me.LblFecha.Font = New System.Drawing.Font("Berlin Sans FB", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFecha.Location = New System.Drawing.Point(19, 45)
        Me.LblFecha.Name = "LblFecha"
        Me.LblFecha.Size = New System.Drawing.Size(62, 17)
        Me.LblFecha.TabIndex = 2
        Me.LblFecha.Text = "Fecha, año"
        '
        'PnlMenu
        '
        Me.PnlMenu.Controls.Add(Me.Panel6)
        Me.PnlMenu.Controls.Add(Me.PnlGrupos)
        Me.PnlMenu.Controls.Add(Me.PnlTitulo)
        Me.PnlMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PnlMenu.Location = New System.Drawing.Point(0, 0)
        Me.PnlMenu.Name = "PnlMenu"
        Me.PnlMenu.Size = New System.Drawing.Size(208, 655)
        Me.PnlMenu.TabIndex = 9
        '
        'Panel6
        '
        Me.Panel6.AutoSize = True
        Me.Panel6.Controls.Add(Me.BtnBackup)
        Me.Panel6.Controls.Add(Me.BtnResumenC)
        Me.Panel6.Controls.Add(Me.BtnResumen)
        Me.Panel6.Controls.Add(Me.BtnInformes)
        Me.Panel6.Controls.Add(Me.BtnLocalidades)
        Me.Panel6.Controls.Add(Me.BtnAlumnos)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel6.Location = New System.Drawing.Point(0, 493)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(208, 162)
        Me.Panel6.TabIndex = 88
        '
        'BtnBackup
        '
        Me.BtnBackup.BackColor = System.Drawing.Color.Transparent
        Me.BtnBackup.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnBackup.FlatAppearance.BorderSize = 0
        Me.BtnBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBackup.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!)
        Me.BtnBackup.Location = New System.Drawing.Point(0, 135)
        Me.BtnBackup.Name = "BtnBackup"
        Me.BtnBackup.Size = New System.Drawing.Size(208, 27)
        Me.BtnBackup.TabIndex = 96
        Me.BtnBackup.Text = "Backup"
        Me.BtnBackup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBackup.UseVisualStyleBackColor = False
        '
        'BtnResumenC
        '
        Me.BtnResumenC.BackColor = System.Drawing.Color.Transparent
        Me.BtnResumenC.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnResumenC.FlatAppearance.BorderSize = 0
        Me.BtnResumenC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnResumenC.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!)
        Me.BtnResumenC.Location = New System.Drawing.Point(0, 108)
        Me.BtnResumenC.Name = "BtnResumenC"
        Me.BtnResumenC.Size = New System.Drawing.Size(208, 27)
        Me.BtnResumenC.TabIndex = 95
        Me.BtnResumenC.Text = "Resumen Calendario"
        Me.BtnResumenC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnResumenC.UseVisualStyleBackColor = False
        '
        'BtnResumen
        '
        Me.BtnResumen.BackColor = System.Drawing.Color.Transparent
        Me.BtnResumen.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnResumen.FlatAppearance.BorderSize = 0
        Me.BtnResumen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnResumen.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!)
        Me.BtnResumen.Location = New System.Drawing.Point(0, 81)
        Me.BtnResumen.Name = "BtnResumen"
        Me.BtnResumen.Size = New System.Drawing.Size(208, 27)
        Me.BtnResumen.TabIndex = 94
        Me.BtnResumen.Text = "Eventos"
        Me.BtnResumen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnResumen.UseVisualStyleBackColor = False
        '
        'BtnInformes
        '
        Me.BtnInformes.BackColor = System.Drawing.Color.Transparent
        Me.BtnInformes.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnInformes.FlatAppearance.BorderSize = 0
        Me.BtnInformes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnInformes.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!)
        Me.BtnInformes.Location = New System.Drawing.Point(0, 54)
        Me.BtnInformes.Name = "BtnInformes"
        Me.BtnInformes.Size = New System.Drawing.Size(208, 27)
        Me.BtnInformes.TabIndex = 92
        Me.BtnInformes.Text = "Informes"
        Me.BtnInformes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnInformes.UseVisualStyleBackColor = False
        '
        'BtnLocalidades
        '
        Me.BtnLocalidades.BackColor = System.Drawing.Color.Transparent
        Me.BtnLocalidades.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnLocalidades.FlatAppearance.BorderSize = 0
        Me.BtnLocalidades.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLocalidades.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!)
        Me.BtnLocalidades.Location = New System.Drawing.Point(0, 27)
        Me.BtnLocalidades.Name = "BtnLocalidades"
        Me.BtnLocalidades.Size = New System.Drawing.Size(208, 27)
        Me.BtnLocalidades.TabIndex = 93
        Me.BtnLocalidades.Text = "Localidades"
        Me.BtnLocalidades.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnLocalidades.UseVisualStyleBackColor = False
        '
        'BtnAlumnos
        '
        Me.BtnAlumnos.BackColor = System.Drawing.Color.Transparent
        Me.BtnAlumnos.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnAlumnos.FlatAppearance.BorderSize = 0
        Me.BtnAlumnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAlumnos.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!)
        Me.BtnAlumnos.Location = New System.Drawing.Point(0, 0)
        Me.BtnAlumnos.Name = "BtnAlumnos"
        Me.BtnAlumnos.Size = New System.Drawing.Size(208, 27)
        Me.BtnAlumnos.TabIndex = 97
        Me.BtnAlumnos.Text = "Alumnos"
        Me.BtnAlumnos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAlumnos.UseVisualStyleBackColor = False
        '
        'PnlGrupos
        '
        Me.PnlGrupos.AutoSize = True
        Me.PnlGrupos.BackColor = System.Drawing.Color.Transparent
        Me.PnlGrupos.Controls.Add(Me.PnlInformacion)
        Me.PnlGrupos.Controls.Add(Me.BtnInformacion)
        Me.PnlGrupos.Controls.Add(Me.Panel1)
        Me.PnlGrupos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlGrupos.Location = New System.Drawing.Point(0, 38)
        Me.PnlGrupos.Name = "PnlGrupos"
        Me.PnlGrupos.ShadowDecoration.Parent = Me.PnlGrupos
        Me.PnlGrupos.Size = New System.Drawing.Size(208, 617)
        Me.PnlGrupos.TabIndex = 87
        '
        'PnlInformacion
        '
        Me.PnlInformacion.AutoSize = True
        Me.PnlInformacion.Controls.Add(Me.Panel7)
        Me.PnlInformacion.Controls.Add(Me.BtnInstitucion)
        Me.PnlInformacion.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlInformacion.Location = New System.Drawing.Point(0, 139)
        Me.PnlInformacion.Name = "PnlInformacion"
        Me.PnlInformacion.Size = New System.Drawing.Size(208, 108)
        Me.PnlInformacion.TabIndex = 74
        '
        'Panel7
        '
        Me.Panel7.AutoSize = True
        Me.Panel7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel7.Controls.Add(Me.BtnAgregarAlumno)
        Me.Panel7.Controls.Add(Me.BtnMateria)
        Me.Panel7.Controls.Add(Me.BtnCarrera)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(0, 27)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(208, 81)
        Me.Panel7.TabIndex = 68
        '
        'BtnAgregarAlumno
        '
        Me.BtnAgregarAlumno.BackColor = System.Drawing.Color.Transparent
        Me.BtnAgregarAlumno.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnAgregarAlumno.FlatAppearance.BorderSize = 0
        Me.BtnAgregarAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAgregarAlumno.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!)
        Me.BtnAgregarAlumno.Location = New System.Drawing.Point(0, 54)
        Me.BtnAgregarAlumno.Name = "BtnAgregarAlumno"
        Me.BtnAgregarAlumno.Size = New System.Drawing.Size(208, 27)
        Me.BtnAgregarAlumno.TabIndex = 69
        Me.BtnAgregarAlumno.Text = "Alumno"
        Me.BtnAgregarAlumno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAgregarAlumno.UseVisualStyleBackColor = False
        '
        'BtnMateria
        '
        Me.BtnMateria.BackColor = System.Drawing.Color.Transparent
        Me.BtnMateria.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnMateria.FlatAppearance.BorderSize = 0
        Me.BtnMateria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMateria.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!)
        Me.BtnMateria.Location = New System.Drawing.Point(0, 27)
        Me.BtnMateria.Name = "BtnMateria"
        Me.BtnMateria.Size = New System.Drawing.Size(208, 27)
        Me.BtnMateria.TabIndex = 67
        Me.BtnMateria.Text = "Materia"
        Me.BtnMateria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnMateria.UseVisualStyleBackColor = False
        '
        'BtnCarrera
        '
        Me.BtnCarrera.BackColor = System.Drawing.Color.Transparent
        Me.BtnCarrera.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnCarrera.FlatAppearance.BorderSize = 0
        Me.BtnCarrera.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCarrera.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!)
        Me.BtnCarrera.Location = New System.Drawing.Point(0, 0)
        Me.BtnCarrera.Name = "BtnCarrera"
        Me.BtnCarrera.Size = New System.Drawing.Size(208, 27)
        Me.BtnCarrera.TabIndex = 68
        Me.BtnCarrera.Text = "Carrera"
        Me.BtnCarrera.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCarrera.UseVisualStyleBackColor = False
        '
        'BtnInstitucion
        '
        Me.BtnInstitucion.BackColor = System.Drawing.Color.MediumAquamarine
        Me.BtnInstitucion.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnInstitucion.FlatAppearance.BorderSize = 0
        Me.BtnInstitucion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnInstitucion.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!)
        Me.BtnInstitucion.Location = New System.Drawing.Point(0, 0)
        Me.BtnInstitucion.Name = "BtnInstitucion"
        Me.BtnInstitucion.Size = New System.Drawing.Size(208, 27)
        Me.BtnInstitucion.TabIndex = 66
        Me.BtnInstitucion.Text = "Intitucion"
        Me.BtnInstitucion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnInstitucion.UseVisualStyleBackColor = False
        '
        'BtnInformacion
        '
        Me.BtnInformacion.BackColor = System.Drawing.Color.MediumAquamarine
        Me.BtnInformacion.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnInformacion.FlatAppearance.BorderSize = 0
        Me.BtnInformacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnInformacion.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!)
        Me.BtnInformacion.Location = New System.Drawing.Point(0, 112)
        Me.BtnInformacion.Name = "BtnInformacion"
        Me.BtnInformacion.Size = New System.Drawing.Size(208, 27)
        Me.BtnInformacion.TabIndex = 73
        Me.BtnInformacion.Text = "Informacion principal"
        Me.BtnInformacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnInformacion.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.AutoSize = True
        Me.Panel1.Controls.Add(Me.BtnBuscar)
        Me.Panel1.Controls.Add(Me.BtnCrearGrupo)
        Me.Panel1.Controls.Add(Me.BtnGrupos)
        Me.Panel1.Controls.Add(Me.BtnAsistencia)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(208, 112)
        Me.Panel1.TabIndex = 75
        '
        'BtnBuscar
        '
        Me.BtnBuscar.BackColor = System.Drawing.Color.Transparent
        Me.BtnBuscar.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnBuscar.FlatAppearance.BorderSize = 0
        Me.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBuscar.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!)
        Me.BtnBuscar.Location = New System.Drawing.Point(0, 85)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(208, 27)
        Me.BtnBuscar.TabIndex = 71
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBuscar.UseVisualStyleBackColor = False
        '
        'BtnCrearGrupo
        '
        Me.BtnCrearGrupo.BackColor = System.Drawing.Color.Transparent
        Me.BtnCrearGrupo.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnCrearGrupo.FlatAppearance.BorderSize = 0
        Me.BtnCrearGrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCrearGrupo.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!)
        Me.BtnCrearGrupo.Location = New System.Drawing.Point(0, 58)
        Me.BtnCrearGrupo.Name = "BtnCrearGrupo"
        Me.BtnCrearGrupo.Size = New System.Drawing.Size(208, 27)
        Me.BtnCrearGrupo.TabIndex = 72
        Me.BtnCrearGrupo.Text = "Crear grupo"
        Me.BtnCrearGrupo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCrearGrupo.UseVisualStyleBackColor = False
        '
        'BtnGrupos
        '
        Me.BtnGrupos.BackColor = System.Drawing.Color.MediumAquamarine
        Me.BtnGrupos.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnGrupos.FlatAppearance.BorderSize = 0
        Me.BtnGrupos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGrupos.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!)
        Me.BtnGrupos.Location = New System.Drawing.Point(0, 31)
        Me.BtnGrupos.Name = "BtnGrupos"
        Me.BtnGrupos.Size = New System.Drawing.Size(208, 27)
        Me.BtnGrupos.TabIndex = 69
        Me.BtnGrupos.Text = "Grupos"
        Me.BtnGrupos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGrupos.UseVisualStyleBackColor = False
        '
        'BtnAsistencia
        '
        Me.BtnAsistencia.AutoSize = True
        Me.BtnAsistencia.BackColor = System.Drawing.Color.MediumAquamarine
        Me.BtnAsistencia.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnAsistencia.FlatAppearance.BorderSize = 0
        Me.BtnAsistencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAsistencia.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!)
        Me.BtnAsistencia.Location = New System.Drawing.Point(0, 0)
        Me.BtnAsistencia.Name = "BtnAsistencia"
        Me.BtnAsistencia.Size = New System.Drawing.Size(208, 31)
        Me.BtnAsistencia.TabIndex = 70
        Me.BtnAsistencia.Text = "Tomar asistencia"
        Me.BtnAsistencia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAsistencia.UseVisualStyleBackColor = False
        '
        'PnlTitulo
        '
        Me.PnlTitulo.BackColor = System.Drawing.Color.MediumAquamarine
        Me.PnlTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlTitulo.Font = New System.Drawing.Font("Berlin Sans FB", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PnlTitulo.ForeColor = System.Drawing.Color.White
        Me.PnlTitulo.Location = New System.Drawing.Point(0, 0)
        Me.PnlTitulo.Name = "PnlTitulo"
        Me.PnlTitulo.Size = New System.Drawing.Size(208, 38)
        Me.PnlTitulo.TabIndex = 68
        Me.PnlTitulo.Text = "Menú"
        Me.PnlTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.MediumAquamarine
        Me.Panel5.Controls.Add(Me.PnlBotones)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(208, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(816, 38)
        Me.Panel5.TabIndex = 55
        '
        'PnlBotones
        '
        Me.PnlBotones.BackColor = System.Drawing.Color.Transparent
        Me.PnlBotones.Controls.Add(Me.BtnMinimizar)
        Me.PnlBotones.Controls.Add(Me.BtnMaximizar)
        Me.PnlBotones.Controls.Add(Me.BtnCerrar)
        Me.PnlBotones.Dock = System.Windows.Forms.DockStyle.Right
        Me.PnlBotones.Location = New System.Drawing.Point(698, 0)
        Me.PnlBotones.Name = "PnlBotones"
        Me.PnlBotones.ShadowDecoration.Parent = Me.PnlBotones
        Me.PnlBotones.Size = New System.Drawing.Size(118, 38)
        Me.PnlBotones.TabIndex = 29
        '
        'BtnMinimizar
        '
        Me.BtnMinimizar.BackColor = System.Drawing.Color.MediumAquamarine
        Me.BtnMinimizar.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtnMinimizar.FlatAppearance.BorderSize = 0
        Me.BtnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMinimizar.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!)
        Me.BtnMinimizar.Location = New System.Drawing.Point(28, 0)
        Me.BtnMinimizar.Name = "BtnMinimizar"
        Me.BtnMinimizar.Size = New System.Drawing.Size(30, 38)
        Me.BtnMinimizar.TabIndex = 30
        Me.BtnMinimizar.Text = "M"
        Me.BtnMinimizar.UseVisualStyleBackColor = False
        '
        'BtnMaximizar
        '
        Me.BtnMaximizar.BackColor = System.Drawing.Color.MediumAquamarine
        Me.BtnMaximizar.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtnMaximizar.FlatAppearance.BorderSize = 0
        Me.BtnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMaximizar.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!)
        Me.BtnMaximizar.Location = New System.Drawing.Point(58, 0)
        Me.BtnMaximizar.Name = "BtnMaximizar"
        Me.BtnMaximizar.Size = New System.Drawing.Size(30, 38)
        Me.BtnMaximizar.TabIndex = 30
        Me.BtnMaximizar.Text = "M"
        Me.BtnMaximizar.UseVisualStyleBackColor = False
        '
        'BtnCerrar
        '
        Me.BtnCerrar.BackColor = System.Drawing.Color.MediumAquamarine
        Me.BtnCerrar.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtnCerrar.FlatAppearance.BorderSize = 0
        Me.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCerrar.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!)
        Me.BtnCerrar.Location = New System.Drawing.Point(88, 0)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(30, 38)
        Me.BtnCerrar.TabIndex = 30
        Me.BtnCerrar.Text = "C"
        Me.BtnCerrar.UseVisualStyleBackColor = False
        '
        'FrmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1024, 655)
        Me.Controls.Add(Me.PnlEventos)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.PnlMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PnlEventos.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.Dgv_ListaAlumnos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.PnlTit.ResumeLayout(False)
        Me.PnlTit.PerformLayout()
        Me.PnlMenu.ResumeLayout(False)
        Me.PnlMenu.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.PnlGrupos.ResumeLayout(False)
        Me.PnlGrupos.PerformLayout()
        Me.PnlInformacion.ResumeLayout(False)
        Me.PnlInformacion.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.PnlBotones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PnlEventos As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents LblFecha As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents LblHora As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents TxtEvento As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents PnlTit As Panel
    Friend WithEvents LblEvento As Label
    Friend WithEvents BtnNuevoEvento As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents Dgv_ListaAlumnos As DataGridView
    Friend WithEvents PnlMenu As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents PnlBotones As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents BtnMinimizar As Button
    Friend WithEvents BtnMaximizar As Button
    Friend WithEvents BtnCerrar As Button
    Friend WithEvents PnlTitulo As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents BtnBackup As Button
    Friend WithEvents BtnResumenC As Button
    Friend WithEvents BtnResumen As Button
    Friend WithEvents BtnInformes As Button
    Friend WithEvents BtnLocalidades As Button
    Friend WithEvents BtnAlumnos As Button
    Friend WithEvents PnlGrupos As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents PnlInformacion As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents BtnAgregarAlumno As Button
    Friend WithEvents BtnMateria As Button
    Friend WithEvents BtnCarrera As Button
    Friend WithEvents BtnInstitucion As Button
    Friend WithEvents BtnInformacion As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents BtnCrearGrupo As Button
    Friend WithEvents BtnGrupos As Button
    Friend WithEvents BtnAsistencia As Button
End Class
