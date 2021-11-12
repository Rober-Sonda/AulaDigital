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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMenu))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PnlTitulo = New Guna.UI2.WinForms.Guna2Panel()
        Me.PnlBotones = New Guna.UI2.WinForms.Guna2Panel()
        Me.BtnCerrar = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnMaximizar = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnMinimizar = New Guna.UI2.WinForms.Guna2Button()
        Me.PnlMenu = New Guna.UI2.WinForms.Guna2Panel()
        Me.BtnBackup = New Guna.UI2.WinForms.Guna2Button()
        Me.PnlResumenC = New Guna.UI2.WinForms.Guna2Panel()
        Me.BtnResumenC = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnResumen = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnInformes = New Guna.UI2.WinForms.Guna2Button()
        Me.PnlInformacion = New Guna.UI2.WinForms.Guna2Panel()
        Me.BtnAlumno = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnMateria = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnCarrera = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnInstitucion = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnInformacion = New Guna.UI2.WinForms.Guna2Button()
        Me.PnlGrupos = New Guna.UI2.WinForms.Guna2Panel()
        Me.BtnBuscar = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnCrearGrupo = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnGrupos = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnAsistencia = New Guna.UI2.WinForms.Guna2Button()
        Me.PbxLogo = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.PnlEventos = New Guna.UI2.WinForms.Guna2Panel()
        Me.TxtEvento = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2DataGridView1 = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.LblEvento = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.BtnGuardar = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnNuevoEvento = New Guna.UI2.WinForms.Guna2Button()
        Me.LblFecha = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.LblHora = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.PnlBarra = New Guna.UI2.WinForms.Guna2Panel()
        Me.LblMenu = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PnlTitulo.SuspendLayout()
        Me.PnlBotones.SuspendLayout()
        Me.PnlMenu.SuspendLayout()
        Me.PnlResumenC.SuspendLayout()
        Me.PnlInformacion.SuspendLayout()
        Me.PnlGrupos.SuspendLayout()
        CType(Me.PbxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlEventos.SuspendLayout()
        CType(Me.Guna2DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlBarra.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlTitulo
        '
        Me.PnlTitulo.BackColor = System.Drawing.Color.White
        Me.PnlTitulo.BackgroundImage = CType(resources.GetObject("PnlTitulo.BackgroundImage"), System.Drawing.Image)
        Me.PnlTitulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PnlTitulo.Controls.Add(Me.PnlBarra)
        Me.PnlTitulo.Controls.Add(Me.PnlBotones)
        Me.PnlTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlTitulo.Location = New System.Drawing.Point(0, 0)
        Me.PnlTitulo.Name = "PnlTitulo"
        Me.PnlTitulo.ShadowDecoration.Parent = Me.PnlTitulo
        Me.PnlTitulo.Size = New System.Drawing.Size(1024, 40)
        Me.PnlTitulo.TabIndex = 0
        '
        'PnlBotones
        '
        Me.PnlBotones.BackColor = System.Drawing.Color.Transparent
        Me.PnlBotones.Controls.Add(Me.BtnCerrar)
        Me.PnlBotones.Controls.Add(Me.BtnMaximizar)
        Me.PnlBotones.Controls.Add(Me.BtnMinimizar)
        Me.PnlBotones.Dock = System.Windows.Forms.DockStyle.Right
        Me.PnlBotones.Location = New System.Drawing.Point(908, 0)
        Me.PnlBotones.Name = "PnlBotones"
        Me.PnlBotones.ShadowDecoration.Parent = Me.PnlBotones
        Me.PnlBotones.Size = New System.Drawing.Size(116, 40)
        Me.PnlBotones.TabIndex = 5
        '
        'BtnCerrar
        '
        Me.BtnCerrar.BackgroundImage = CType(resources.GetObject("BtnCerrar.BackgroundImage"), System.Drawing.Image)
        Me.BtnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnCerrar.CheckedState.Parent = Me.BtnCerrar
        Me.BtnCerrar.CustomImages.Parent = Me.BtnCerrar
        Me.BtnCerrar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnCerrar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnCerrar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnCerrar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnCerrar.DisabledState.Parent = Me.BtnCerrar
        Me.BtnCerrar.FillColor = System.Drawing.Color.Transparent
        Me.BtnCerrar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnCerrar.ForeColor = System.Drawing.Color.White
        Me.BtnCerrar.HoverState.Parent = Me.BtnCerrar
        Me.BtnCerrar.Location = New System.Drawing.Point(81, 5)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.ShadowDecoration.Parent = Me.BtnCerrar
        Me.BtnCerrar.Size = New System.Drawing.Size(30, 30)
        Me.BtnCerrar.TabIndex = 2
        '
        'BtnMaximizar
        '
        Me.BtnMaximizar.BackgroundImage = CType(resources.GetObject("BtnMaximizar.BackgroundImage"), System.Drawing.Image)
        Me.BtnMaximizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnMaximizar.CheckedState.Parent = Me.BtnMaximizar
        Me.BtnMaximizar.CustomImages.Parent = Me.BtnMaximizar
        Me.BtnMaximizar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnMaximizar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnMaximizar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnMaximizar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnMaximizar.DisabledState.Parent = Me.BtnMaximizar
        Me.BtnMaximizar.FillColor = System.Drawing.Color.Transparent
        Me.BtnMaximizar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnMaximizar.ForeColor = System.Drawing.Color.White
        Me.BtnMaximizar.HoverState.Parent = Me.BtnMaximizar
        Me.BtnMaximizar.Location = New System.Drawing.Point(45, 5)
        Me.BtnMaximizar.Name = "BtnMaximizar"
        Me.BtnMaximizar.ShadowDecoration.Parent = Me.BtnMaximizar
        Me.BtnMaximizar.Size = New System.Drawing.Size(30, 30)
        Me.BtnMaximizar.TabIndex = 3
        '
        'BtnMinimizar
        '
        Me.BtnMinimizar.BackgroundImage = CType(resources.GetObject("BtnMinimizar.BackgroundImage"), System.Drawing.Image)
        Me.BtnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnMinimizar.CheckedState.Parent = Me.BtnMinimizar
        Me.BtnMinimizar.CustomImages.Parent = Me.BtnMinimizar
        Me.BtnMinimizar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnMinimizar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnMinimizar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnMinimizar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnMinimizar.DisabledState.Parent = Me.BtnMinimizar
        Me.BtnMinimizar.FillColor = System.Drawing.Color.Transparent
        Me.BtnMinimizar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnMinimizar.ForeColor = System.Drawing.Color.White
        Me.BtnMinimizar.HoverState.Parent = Me.BtnMinimizar
        Me.BtnMinimizar.Location = New System.Drawing.Point(9, 5)
        Me.BtnMinimizar.Name = "BtnMinimizar"
        Me.BtnMinimizar.ShadowDecoration.Parent = Me.BtnMinimizar
        Me.BtnMinimizar.Size = New System.Drawing.Size(30, 30)
        Me.BtnMinimizar.TabIndex = 4
        '
        'PnlMenu
        '
        Me.PnlMenu.BackColor = System.Drawing.Color.Gainsboro
        Me.PnlMenu.BorderColor = System.Drawing.Color.Gray
        Me.PnlMenu.BorderRadius = 2
        Me.PnlMenu.BorderThickness = 2
        Me.PnlMenu.Controls.Add(Me.BtnBackup)
        Me.PnlMenu.Controls.Add(Me.PnlResumenC)
        Me.PnlMenu.Controls.Add(Me.BtnResumen)
        Me.PnlMenu.Controls.Add(Me.BtnInformes)
        Me.PnlMenu.Controls.Add(Me.PnlInformacion)
        Me.PnlMenu.Controls.Add(Me.BtnInformacion)
        Me.PnlMenu.Controls.Add(Me.PnlGrupos)
        Me.PnlMenu.Controls.Add(Me.BtnGrupos)
        Me.PnlMenu.Controls.Add(Me.BtnAsistencia)
        Me.PnlMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PnlMenu.Location = New System.Drawing.Point(0, 40)
        Me.PnlMenu.Name = "PnlMenu"
        Me.PnlMenu.ShadowDecoration.Parent = Me.PnlMenu
        Me.PnlMenu.Size = New System.Drawing.Size(225, 615)
        Me.PnlMenu.TabIndex = 1
        '
        'BtnBackup
        '
        Me.BtnBackup.BackColor = System.Drawing.Color.Transparent
        Me.BtnBackup.CheckedState.Parent = Me.BtnBackup
        Me.BtnBackup.CustomImages.Parent = Me.BtnBackup
        Me.BtnBackup.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnBackup.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnBackup.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnBackup.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnBackup.DisabledState.Parent = Me.BtnBackup
        Me.BtnBackup.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnBackup.FillColor = System.Drawing.Color.Transparent
        Me.BtnBackup.Font = New System.Drawing.Font("Berlin Sans FB Demi", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnBackup.ForeColor = System.Drawing.Color.Black
        Me.BtnBackup.HoverState.Parent = Me.BtnBackup
        Me.BtnBackup.Image = CType(resources.GetObject("BtnBackup.Image"), System.Drawing.Image)
        Me.BtnBackup.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BtnBackup.Location = New System.Drawing.Point(0, 482)
        Me.BtnBackup.Name = "BtnBackup"
        Me.BtnBackup.ShadowDecoration.Parent = Me.BtnBackup
        Me.BtnBackup.Size = New System.Drawing.Size(225, 45)
        Me.BtnBackup.TabIndex = 2
        Me.BtnBackup.Text = "Backup"
        Me.BtnBackup.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'PnlResumenC
        '
        Me.PnlResumenC.BackColor = System.Drawing.Color.Transparent
        Me.PnlResumenC.Controls.Add(Me.BtnResumenC)
        Me.PnlResumenC.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlResumenC.Location = New System.Drawing.Point(0, 438)
        Me.PnlResumenC.Name = "PnlResumenC"
        Me.PnlResumenC.ShadowDecoration.Parent = Me.PnlResumenC
        Me.PnlResumenC.Size = New System.Drawing.Size(225, 44)
        Me.PnlResumenC.TabIndex = 6
        '
        'BtnResumenC
        '
        Me.BtnResumenC.CheckedState.Parent = Me.BtnResumenC
        Me.BtnResumenC.CustomImages.Parent = Me.BtnResumenC
        Me.BtnResumenC.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnResumenC.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnResumenC.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnResumenC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnResumenC.DisabledState.Parent = Me.BtnResumenC
        Me.BtnResumenC.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnResumenC.FillColor = System.Drawing.Color.Transparent
        Me.BtnResumenC.Font = New System.Drawing.Font("Berlin Sans FB Demi", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnResumenC.ForeColor = System.Drawing.Color.Black
        Me.BtnResumenC.HoverState.Parent = Me.BtnResumenC
        Me.BtnResumenC.Image = CType(resources.GetObject("BtnResumenC.Image"), System.Drawing.Image)
        Me.BtnResumenC.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BtnResumenC.Location = New System.Drawing.Point(0, 0)
        Me.BtnResumenC.Name = "BtnResumenC"
        Me.BtnResumenC.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.BtnResumenC.ShadowDecoration.Parent = Me.BtnResumenC
        Me.BtnResumenC.Size = New System.Drawing.Size(225, 40)
        Me.BtnResumenC.TabIndex = 4
        Me.BtnResumenC.Text = "Resumen Calendario"
        Me.BtnResumenC.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BtnResumen
        '
        Me.BtnResumen.BackColor = System.Drawing.Color.Transparent
        Me.BtnResumen.CheckedState.Parent = Me.BtnResumen
        Me.BtnResumen.CustomImages.Parent = Me.BtnResumen
        Me.BtnResumen.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnResumen.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnResumen.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnResumen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnResumen.DisabledState.Parent = Me.BtnResumen
        Me.BtnResumen.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnResumen.FillColor = System.Drawing.Color.Transparent
        Me.BtnResumen.Font = New System.Drawing.Font("Berlin Sans FB Demi", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnResumen.ForeColor = System.Drawing.Color.Black
        Me.BtnResumen.HoverState.Parent = Me.BtnResumen
        Me.BtnResumen.Image = CType(resources.GetObject("BtnResumen.Image"), System.Drawing.Image)
        Me.BtnResumen.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BtnResumen.Location = New System.Drawing.Point(0, 393)
        Me.BtnResumen.Name = "BtnResumen"
        Me.BtnResumen.ShadowDecoration.Parent = Me.BtnResumen
        Me.BtnResumen.Size = New System.Drawing.Size(225, 45)
        Me.BtnResumen.TabIndex = 9
        Me.BtnResumen.Text = "Eventos"
        Me.BtnResumen.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BtnInformes
        '
        Me.BtnInformes.BackColor = System.Drawing.Color.Transparent
        Me.BtnInformes.CheckedState.Parent = Me.BtnInformes
        Me.BtnInformes.CustomImages.Parent = Me.BtnInformes
        Me.BtnInformes.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnInformes.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnInformes.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnInformes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnInformes.DisabledState.Parent = Me.BtnInformes
        Me.BtnInformes.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnInformes.FillColor = System.Drawing.Color.Transparent
        Me.BtnInformes.Font = New System.Drawing.Font("Berlin Sans FB Demi", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnInformes.ForeColor = System.Drawing.Color.Black
        Me.BtnInformes.HoverState.Parent = Me.BtnInformes
        Me.BtnInformes.Image = CType(resources.GetObject("BtnInformes.Image"), System.Drawing.Image)
        Me.BtnInformes.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BtnInformes.Location = New System.Drawing.Point(0, 348)
        Me.BtnInformes.Name = "BtnInformes"
        Me.BtnInformes.ShadowDecoration.Parent = Me.BtnInformes
        Me.BtnInformes.Size = New System.Drawing.Size(225, 45)
        Me.BtnInformes.TabIndex = 2
        Me.BtnInformes.Text = "Informes"
        Me.BtnInformes.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'PnlInformacion
        '
        Me.PnlInformacion.BackColor = System.Drawing.Color.Transparent
        Me.PnlInformacion.Controls.Add(Me.BtnAlumno)
        Me.PnlInformacion.Controls.Add(Me.BtnMateria)
        Me.PnlInformacion.Controls.Add(Me.BtnCarrera)
        Me.PnlInformacion.Controls.Add(Me.BtnInstitucion)
        Me.PnlInformacion.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlInformacion.Location = New System.Drawing.Point(0, 221)
        Me.PnlInformacion.Name = "PnlInformacion"
        Me.PnlInformacion.ShadowDecoration.Parent = Me.PnlInformacion
        Me.PnlInformacion.Size = New System.Drawing.Size(225, 127)
        Me.PnlInformacion.TabIndex = 6
        '
        'BtnAlumno
        '
        Me.BtnAlumno.CheckedState.Parent = Me.BtnAlumno
        Me.BtnAlumno.CustomImages.Parent = Me.BtnAlumno
        Me.BtnAlumno.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnAlumno.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnAlumno.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnAlumno.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnAlumno.DisabledState.Parent = Me.BtnAlumno
        Me.BtnAlumno.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnAlumno.FillColor = System.Drawing.Color.Transparent
        Me.BtnAlumno.Font = New System.Drawing.Font("Berlin Sans FB Demi", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAlumno.ForeColor = System.Drawing.Color.Black
        Me.BtnAlumno.HoverState.Parent = Me.BtnAlumno
        Me.BtnAlumno.Image = CType(resources.GetObject("BtnAlumno.Image"), System.Drawing.Image)
        Me.BtnAlumno.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BtnAlumno.Location = New System.Drawing.Point(0, 90)
        Me.BtnAlumno.Name = "BtnAlumno"
        Me.BtnAlumno.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.BtnAlumno.ShadowDecoration.Parent = Me.BtnAlumno
        Me.BtnAlumno.Size = New System.Drawing.Size(225, 30)
        Me.BtnAlumno.TabIndex = 6
        Me.BtnAlumno.Text = "Alumno"
        Me.BtnAlumno.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BtnMateria
        '
        Me.BtnMateria.CheckedState.Parent = Me.BtnMateria
        Me.BtnMateria.CustomImages.Parent = Me.BtnMateria
        Me.BtnMateria.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnMateria.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnMateria.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnMateria.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnMateria.DisabledState.Parent = Me.BtnMateria
        Me.BtnMateria.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnMateria.FillColor = System.Drawing.Color.Transparent
        Me.BtnMateria.Font = New System.Drawing.Font("Berlin Sans FB Demi", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMateria.ForeColor = System.Drawing.Color.Black
        Me.BtnMateria.HoverState.Parent = Me.BtnMateria
        Me.BtnMateria.Image = CType(resources.GetObject("BtnMateria.Image"), System.Drawing.Image)
        Me.BtnMateria.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BtnMateria.Location = New System.Drawing.Point(0, 60)
        Me.BtnMateria.Name = "BtnMateria"
        Me.BtnMateria.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.BtnMateria.ShadowDecoration.Parent = Me.BtnMateria
        Me.BtnMateria.Size = New System.Drawing.Size(225, 30)
        Me.BtnMateria.TabIndex = 6
        Me.BtnMateria.Text = "Materia"
        Me.BtnMateria.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BtnCarrera
        '
        Me.BtnCarrera.CheckedState.Parent = Me.BtnCarrera
        Me.BtnCarrera.CustomImages.Parent = Me.BtnCarrera
        Me.BtnCarrera.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnCarrera.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnCarrera.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnCarrera.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnCarrera.DisabledState.Parent = Me.BtnCarrera
        Me.BtnCarrera.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnCarrera.FillColor = System.Drawing.Color.Transparent
        Me.BtnCarrera.Font = New System.Drawing.Font("Berlin Sans FB Demi", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCarrera.ForeColor = System.Drawing.Color.Black
        Me.BtnCarrera.HoverState.Parent = Me.BtnCarrera
        Me.BtnCarrera.Image = CType(resources.GetObject("BtnCarrera.Image"), System.Drawing.Image)
        Me.BtnCarrera.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BtnCarrera.Location = New System.Drawing.Point(0, 30)
        Me.BtnCarrera.Name = "BtnCarrera"
        Me.BtnCarrera.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.BtnCarrera.ShadowDecoration.Parent = Me.BtnCarrera
        Me.BtnCarrera.Size = New System.Drawing.Size(225, 30)
        Me.BtnCarrera.TabIndex = 5
        Me.BtnCarrera.Text = "Carrera"
        Me.BtnCarrera.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BtnInstitucion
        '
        Me.BtnInstitucion.CheckedState.Parent = Me.BtnInstitucion
        Me.BtnInstitucion.CustomImages.Parent = Me.BtnInstitucion
        Me.BtnInstitucion.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnInstitucion.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnInstitucion.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnInstitucion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnInstitucion.DisabledState.Parent = Me.BtnInstitucion
        Me.BtnInstitucion.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnInstitucion.FillColor = System.Drawing.Color.Transparent
        Me.BtnInstitucion.Font = New System.Drawing.Font("Berlin Sans FB Demi", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnInstitucion.ForeColor = System.Drawing.Color.Black
        Me.BtnInstitucion.HoverState.Parent = Me.BtnInstitucion
        Me.BtnInstitucion.Image = CType(resources.GetObject("BtnInstitucion.Image"), System.Drawing.Image)
        Me.BtnInstitucion.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BtnInstitucion.Location = New System.Drawing.Point(0, 0)
        Me.BtnInstitucion.Name = "BtnInstitucion"
        Me.BtnInstitucion.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.BtnInstitucion.ShadowDecoration.Parent = Me.BtnInstitucion
        Me.BtnInstitucion.Size = New System.Drawing.Size(225, 30)
        Me.BtnInstitucion.TabIndex = 4
        Me.BtnInstitucion.Text = "Institución"
        Me.BtnInstitucion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BtnInformacion
        '
        Me.BtnInformacion.BackColor = System.Drawing.Color.Transparent
        Me.BtnInformacion.CheckedState.Parent = Me.BtnInformacion
        Me.BtnInformacion.CustomImages.Parent = Me.BtnInformacion
        Me.BtnInformacion.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnInformacion.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnInformacion.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnInformacion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnInformacion.DisabledState.Parent = Me.BtnInformacion
        Me.BtnInformacion.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnInformacion.FillColor = System.Drawing.Color.Transparent
        Me.BtnInformacion.Font = New System.Drawing.Font("Berlin Sans FB Demi", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnInformacion.ForeColor = System.Drawing.Color.Black
        Me.BtnInformacion.HoverState.Parent = Me.BtnInformacion
        Me.BtnInformacion.Image = CType(resources.GetObject("BtnInformacion.Image"), System.Drawing.Image)
        Me.BtnInformacion.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BtnInformacion.Location = New System.Drawing.Point(0, 176)
        Me.BtnInformacion.Name = "BtnInformacion"
        Me.BtnInformacion.ShadowDecoration.Parent = Me.BtnInformacion
        Me.BtnInformacion.Size = New System.Drawing.Size(225, 45)
        Me.BtnInformacion.TabIndex = 5
        Me.BtnInformacion.Text = "Información Principal"
        Me.BtnInformacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'PnlGrupos
        '
        Me.PnlGrupos.BackColor = System.Drawing.Color.Transparent
        Me.PnlGrupos.Controls.Add(Me.BtnBuscar)
        Me.PnlGrupos.Controls.Add(Me.BtnCrearGrupo)
        Me.PnlGrupos.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlGrupos.Location = New System.Drawing.Point(0, 90)
        Me.PnlGrupos.Name = "PnlGrupos"
        Me.PnlGrupos.ShadowDecoration.Parent = Me.PnlGrupos
        Me.PnlGrupos.Size = New System.Drawing.Size(225, 86)
        Me.PnlGrupos.TabIndex = 4
        '
        'BtnBuscar
        '
        Me.BtnBuscar.CheckedState.Parent = Me.BtnBuscar
        Me.BtnBuscar.CustomImages.Parent = Me.BtnBuscar
        Me.BtnBuscar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnBuscar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnBuscar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnBuscar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnBuscar.DisabledState.Parent = Me.BtnBuscar
        Me.BtnBuscar.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnBuscar.FillColor = System.Drawing.Color.Transparent
        Me.BtnBuscar.Font = New System.Drawing.Font("Berlin Sans FB Demi", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscar.ForeColor = System.Drawing.Color.Black
        Me.BtnBuscar.HoverState.Parent = Me.BtnBuscar
        Me.BtnBuscar.Image = CType(resources.GetObject("BtnBuscar.Image"), System.Drawing.Image)
        Me.BtnBuscar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BtnBuscar.Location = New System.Drawing.Point(0, 40)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.BtnBuscar.ShadowDecoration.Parent = Me.BtnBuscar
        Me.BtnBuscar.Size = New System.Drawing.Size(225, 40)
        Me.BtnBuscar.TabIndex = 5
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BtnCrearGrupo
        '
        Me.BtnCrearGrupo.CheckedState.Parent = Me.BtnCrearGrupo
        Me.BtnCrearGrupo.CustomImages.Parent = Me.BtnCrearGrupo
        Me.BtnCrearGrupo.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnCrearGrupo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnCrearGrupo.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnCrearGrupo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnCrearGrupo.DisabledState.Parent = Me.BtnCrearGrupo
        Me.BtnCrearGrupo.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnCrearGrupo.FillColor = System.Drawing.Color.Transparent
        Me.BtnCrearGrupo.Font = New System.Drawing.Font("Berlin Sans FB Demi", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCrearGrupo.ForeColor = System.Drawing.Color.Black
        Me.BtnCrearGrupo.HoverState.Parent = Me.BtnCrearGrupo
        Me.BtnCrearGrupo.Image = CType(resources.GetObject("BtnCrearGrupo.Image"), System.Drawing.Image)
        Me.BtnCrearGrupo.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BtnCrearGrupo.Location = New System.Drawing.Point(0, 0)
        Me.BtnCrearGrupo.Name = "BtnCrearGrupo"
        Me.BtnCrearGrupo.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.BtnCrearGrupo.ShadowDecoration.Parent = Me.BtnCrearGrupo
        Me.BtnCrearGrupo.Size = New System.Drawing.Size(225, 40)
        Me.BtnCrearGrupo.TabIndex = 4
        Me.BtnCrearGrupo.Text = "Crear Grupo"
        Me.BtnCrearGrupo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BtnGrupos
        '
        Me.BtnGrupos.BackColor = System.Drawing.Color.Transparent
        Me.BtnGrupos.CheckedState.Parent = Me.BtnGrupos
        Me.BtnGrupos.CustomImages.Parent = Me.BtnGrupos
        Me.BtnGrupos.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnGrupos.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnGrupos.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnGrupos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnGrupos.DisabledState.Parent = Me.BtnGrupos
        Me.BtnGrupos.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnGrupos.FillColor = System.Drawing.Color.Transparent
        Me.BtnGrupos.Font = New System.Drawing.Font("Berlin Sans FB Demi", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnGrupos.ForeColor = System.Drawing.Color.Black
        Me.BtnGrupos.HoverState.Parent = Me.BtnGrupos
        Me.BtnGrupos.Image = CType(resources.GetObject("BtnGrupos.Image"), System.Drawing.Image)
        Me.BtnGrupos.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BtnGrupos.Location = New System.Drawing.Point(0, 45)
        Me.BtnGrupos.Name = "BtnGrupos"
        Me.BtnGrupos.ShadowDecoration.Parent = Me.BtnGrupos
        Me.BtnGrupos.Size = New System.Drawing.Size(225, 45)
        Me.BtnGrupos.TabIndex = 4
        Me.BtnGrupos.Text = "Grupos"
        Me.BtnGrupos.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BtnAsistencia
        '
        Me.BtnAsistencia.BackColor = System.Drawing.Color.Transparent
        Me.BtnAsistencia.CheckedState.Parent = Me.BtnAsistencia
        Me.BtnAsistencia.CustomImages.Parent = Me.BtnAsistencia
        Me.BtnAsistencia.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnAsistencia.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnAsistencia.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnAsistencia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnAsistencia.DisabledState.Parent = Me.BtnAsistencia
        Me.BtnAsistencia.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnAsistencia.FillColor = System.Drawing.Color.Transparent
        Me.BtnAsistencia.Font = New System.Drawing.Font("Berlin Sans FB Demi", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnAsistencia.ForeColor = System.Drawing.Color.Black
        Me.BtnAsistencia.HoverState.Parent = Me.BtnAsistencia
        Me.BtnAsistencia.Image = CType(resources.GetObject("BtnAsistencia.Image"), System.Drawing.Image)
        Me.BtnAsistencia.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BtnAsistencia.Location = New System.Drawing.Point(0, 0)
        Me.BtnAsistencia.Name = "BtnAsistencia"
        Me.BtnAsistencia.ShadowDecoration.Parent = Me.BtnAsistencia
        Me.BtnAsistencia.Size = New System.Drawing.Size(225, 45)
        Me.BtnAsistencia.TabIndex = 7
        Me.BtnAsistencia.Text = "Tomar Asistencia"
        Me.BtnAsistencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'PbxLogo
        '
        Me.PbxLogo.BackColor = System.Drawing.Color.Transparent
        Me.PbxLogo.BackgroundImage = CType(resources.GetObject("PbxLogo.BackgroundImage"), System.Drawing.Image)
        Me.PbxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PbxLogo.FillColor = System.Drawing.Color.Transparent
        Me.PbxLogo.ImageRotate = 0!
        Me.PbxLogo.Location = New System.Drawing.Point(315, 273)
        Me.PbxLogo.Name = "PbxLogo"
        Me.PbxLogo.ShadowDecoration.Parent = Me.PbxLogo
        Me.PbxLogo.Size = New System.Drawing.Size(412, 289)
        Me.PbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbxLogo.TabIndex = 3
        Me.PbxLogo.TabStop = False
        '
        'PnlEventos
        '
        Me.PnlEventos.BackColor = System.Drawing.Color.Gainsboro
        Me.PnlEventos.BorderColor = System.Drawing.Color.Gray
        Me.PnlEventos.BorderRadius = 2
        Me.PnlEventos.BorderThickness = 2
        Me.PnlEventos.Controls.Add(Me.Panel3)
        Me.PnlEventos.Controls.Add(Me.Panel2)
        Me.PnlEventos.Controls.Add(Me.Panel1)
        Me.PnlEventos.Dock = System.Windows.Forms.DockStyle.Right
        Me.PnlEventos.Location = New System.Drawing.Point(774, 40)
        Me.PnlEventos.Name = "PnlEventos"
        Me.PnlEventos.ShadowDecoration.Parent = Me.PnlEventos
        Me.PnlEventos.Size = New System.Drawing.Size(250, 615)
        Me.PnlEventos.TabIndex = 8
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
        Me.TxtEvento.Location = New System.Drawing.Point(29, 44)
        Me.TxtEvento.Name = "TxtEvento"
        Me.TxtEvento.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtEvento.PlaceholderText = ""
        Me.TxtEvento.SelectedText = ""
        Me.TxtEvento.ShadowDecoration.Parent = Me.TxtEvento
        Me.TxtEvento.Size = New System.Drawing.Size(200, 36)
        Me.TxtEvento.TabIndex = 10
        '
        'Guna2DataGridView1
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.Guna2DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Guna2DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Guna2DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.Guna2DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Guna2DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.Guna2DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Guna2DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Guna2DataGridView1.ColumnHeadersHeight = 4
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Guna2DataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Me.Guna2DataGridView1.EnableHeadersVisualStyles = False
        Me.Guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2DataGridView1.Location = New System.Drawing.Point(29, 160)
        Me.Guna2DataGridView1.Name = "Guna2DataGridView1"
        Me.Guna2DataGridView1.RowHeadersVisible = False
        Me.Guna2DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Guna2DataGridView1.Size = New System.Drawing.Size(201, 179)
        Me.Guna2DataGridView1.TabIndex = 9
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.Guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.Guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 4
        Me.Guna2DataGridView1.ThemeStyle.ReadOnly = False
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.Height = 22
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'LblEvento
        '
        Me.LblEvento.BackColor = System.Drawing.Color.Transparent
        Me.LblEvento.Font = New System.Drawing.Font("Berlin Sans FB", 9.75!)
        Me.LblEvento.Location = New System.Drawing.Point(29, 11)
        Me.LblEvento.Name = "LblEvento"
        Me.LblEvento.Size = New System.Drawing.Size(24, 17)
        Me.LblEvento.TabIndex = 5
        Me.LblEvento.Text = "Hoy"
        '
        'BtnGuardar
        '
        Me.BtnGuardar.CheckedState.Parent = Me.BtnGuardar
        Me.BtnGuardar.CustomImages.Parent = Me.BtnGuardar
        Me.BtnGuardar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnGuardar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnGuardar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnGuardar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnGuardar.DisabledState.Parent = Me.BtnGuardar
        Me.BtnGuardar.FillColor = System.Drawing.Color.MediumAquamarine
        Me.BtnGuardar.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!)
        Me.BtnGuardar.ForeColor = System.Drawing.Color.White
        Me.BtnGuardar.HoverState.Parent = Me.BtnGuardar
        Me.BtnGuardar.Location = New System.Drawing.Point(30, 94)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.ShadowDecoration.Parent = Me.BtnGuardar
        Me.BtnGuardar.Size = New System.Drawing.Size(200, 40)
        Me.BtnGuardar.TabIndex = 4
        Me.BtnGuardar.Text = "Guardar Evento"
        '
        'BtnNuevoEvento
        '
        Me.BtnNuevoEvento.CheckedState.Parent = Me.BtnNuevoEvento
        Me.BtnNuevoEvento.CustomImages.Parent = Me.BtnNuevoEvento
        Me.BtnNuevoEvento.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnNuevoEvento.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnNuevoEvento.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnNuevoEvento.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnNuevoEvento.DisabledState.Parent = Me.BtnNuevoEvento
        Me.BtnNuevoEvento.FillColor = System.Drawing.Color.White
        Me.BtnNuevoEvento.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnNuevoEvento.ForeColor = System.Drawing.Color.White
        Me.BtnNuevoEvento.HoverState.Parent = Me.BtnNuevoEvento
        Me.BtnNuevoEvento.Location = New System.Drawing.Point(205, 11)
        Me.BtnNuevoEvento.Name = "BtnNuevoEvento"
        Me.BtnNuevoEvento.ShadowDecoration.Parent = Me.BtnNuevoEvento
        Me.BtnNuevoEvento.Size = New System.Drawing.Size(25, 25)
        Me.BtnNuevoEvento.TabIndex = 3
        Me.BtnNuevoEvento.Text = "Guna2Button1"
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
        'PnlBarra
        '
        Me.PnlBarra.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PnlBarra.BackgroundImage = CType(resources.GetObject("PnlBarra.BackgroundImage"), System.Drawing.Image)
        Me.PnlBarra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PnlBarra.BorderColor = System.Drawing.Color.Gray
        Me.PnlBarra.BorderRadius = 2
        Me.PnlBarra.BorderThickness = 2
        Me.PnlBarra.Controls.Add(Me.LblMenu)
        Me.PnlBarra.Dock = System.Windows.Forms.DockStyle.Left
        Me.PnlBarra.Location = New System.Drawing.Point(0, 0)
        Me.PnlBarra.Name = "PnlBarra"
        Me.PnlBarra.ShadowDecoration.Parent = Me.PnlBarra
        Me.PnlBarra.Size = New System.Drawing.Size(225, 40)
        Me.PnlBarra.TabIndex = 11
        '
        'LblMenu
        '
        Me.LblMenu.BackColor = System.Drawing.Color.Transparent
        Me.LblMenu.Font = New System.Drawing.Font("Berlin Sans FB", 18.0!)
        Me.LblMenu.ForeColor = System.Drawing.Color.White
        Me.LblMenu.Location = New System.Drawing.Point(15, 3)
        Me.LblMenu.Name = "LblMenu"
        Me.LblMenu.Size = New System.Drawing.Size(60, 28)
        Me.LblMenu.TabIndex = 6
        Me.LblMenu.Text = "Menú"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.LblHora)
        Me.Panel1.Controls.Add(Me.LblFecha)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(250, 70)
        Me.Panel1.TabIndex = 11
        '
        'Panel2
        '
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
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.LblEvento)
        Me.Panel3.Controls.Add(Me.BtnNuevoEvento)
        Me.Panel3.Controls.Add(Me.Guna2DataGridView1)
        Me.Panel3.Controls.Add(Me.TxtEvento)
        Me.Panel3.Controls.Add(Me.BtnGuardar)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 255)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(250, 370)
        Me.Panel3.TabIndex = 13
        '
        'FrmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1024, 655)
        Me.Controls.Add(Me.PnlMenu)
        Me.Controls.Add(Me.PnlEventos)
        Me.Controls.Add(Me.PnlTitulo)
        Me.Controls.Add(Me.PbxLogo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PnlTitulo.ResumeLayout(False)
        Me.PnlBotones.ResumeLayout(False)
        Me.PnlMenu.ResumeLayout(False)
        Me.PnlResumenC.ResumeLayout(False)
        Me.PnlInformacion.ResumeLayout(False)
        Me.PnlGrupos.ResumeLayout(False)
        CType(Me.PbxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlEventos.ResumeLayout(False)
        CType(Me.Guna2DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlBarra.ResumeLayout(False)
        Me.PnlBarra.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlTitulo As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents PnlMenu As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents PbxLogo As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents PnlInformacion As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents BtnMateria As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnCarrera As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnInstitucion As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnInformacion As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PnlGrupos As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents BtnAlumno As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnBuscar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnCrearGrupo As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnGrupos As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnCerrar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnBackup As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnInformes As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnAsistencia As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnMinimizar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnMaximizar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PnlBotones As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents PnlEventos As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents LblEvento As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents BtnGuardar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnNuevoEvento As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents LblFecha As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents LblHora As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents PnlResumenC As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents BtnResumenC As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnResumen As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TxtEvento As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2DataGridView1 As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents PnlBarra As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents LblMenu As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents Panel1 As Panel
End Class
