<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmGrupoMateria
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmGrupoMateria))
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.BtnGuardar = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnEliminar = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnBuscar = New Guna.UI2.WinForms.Guna2Button()
        Me.TxtOtro = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel10 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.CbxFecha = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.CbxAnio = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.CbxNombre = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Guna2HtmlLabel7 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel9 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.TxtHasta = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TxtDesde = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel6 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.PnlRecuadro1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.BtnSiguiente = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2HtmlLabel8 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.PnlBotones = New Guna.UI2.WinForms.Guna2Panel()
        Me.BtnCerrar = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnMaximizar = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnMinimizar = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2GroupBox1.SuspendLayout()
        Me.PnlRecuadro1.SuspendLayout()
        Me.PnlBotones.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.Controls.Add(Me.PnlBotones)
        Me.Guna2GroupBox1.Controls.Add(Me.BtnGuardar)
        Me.Guna2GroupBox1.Controls.Add(Me.BtnEliminar)
        Me.Guna2GroupBox1.Controls.Add(Me.BtnBuscar)
        Me.Guna2GroupBox1.Controls.Add(Me.TxtOtro)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2HtmlLabel10)
        Me.Guna2GroupBox1.Controls.Add(Me.CbxFecha)
        Me.Guna2GroupBox1.Controls.Add(Me.CbxAnio)
        Me.Guna2GroupBox1.Controls.Add(Me.CbxNombre)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2HtmlLabel7)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2HtmlLabel9)
        Me.Guna2GroupBox1.Controls.Add(Me.TxtHasta)
        Me.Guna2GroupBox1.Controls.Add(Me.TxtDesde)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2HtmlLabel6)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2HtmlLabel5)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2HtmlLabel4)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2HtmlLabel3)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Guna2GroupBox1.Controls.Add(Me.PnlRecuadro1)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.MediumAquamarine
        Me.Guna2GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2GroupBox1.FillColor = System.Drawing.Color.LightGray
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Berlin Sans FB", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.ShadowDecoration.Parent = Me.Guna2GroupBox1
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(868, 478)
        Me.Guna2GroupBox1.TabIndex = 0
        Me.Guna2GroupBox1.Text = "Crear Grupo"
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
        Me.BtnGuardar.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardar.ForeColor = System.Drawing.Color.White
        Me.BtnGuardar.HoverState.Parent = Me.BtnGuardar
        Me.BtnGuardar.Location = New System.Drawing.Point(619, 132)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.ShadowDecoration.Parent = Me.BtnGuardar
        Me.BtnGuardar.Size = New System.Drawing.Size(100, 35)
        Me.BtnGuardar.TabIndex = 16
        Me.BtnGuardar.Text = "Guardar"
        '
        'BtnEliminar
        '
        Me.BtnEliminar.BackgroundImage = CType(resources.GetObject("BtnEliminar.BackgroundImage"), System.Drawing.Image)
        Me.BtnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnEliminar.CheckedState.Parent = Me.BtnEliminar
        Me.BtnEliminar.CustomImages.Parent = Me.BtnEliminar
        Me.BtnEliminar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnEliminar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnEliminar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnEliminar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnEliminar.DisabledState.Parent = Me.BtnEliminar
        Me.BtnEliminar.FillColor = System.Drawing.Color.Transparent
        Me.BtnEliminar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnEliminar.ForeColor = System.Drawing.Color.White
        Me.BtnEliminar.HoverState.Parent = Me.BtnEliminar
        Me.BtnEliminar.Location = New System.Drawing.Point(667, 339)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.ShadowDecoration.Parent = Me.BtnEliminar
        Me.BtnEliminar.Size = New System.Drawing.Size(30, 30)
        Me.BtnEliminar.TabIndex = 15
        '
        'BtnBuscar
        '
        Me.BtnBuscar.BackgroundImage = CType(resources.GetObject("BtnBuscar.BackgroundImage"), System.Drawing.Image)
        Me.BtnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnBuscar.CheckedState.Parent = Me.BtnBuscar
        Me.BtnBuscar.CustomImages.Parent = Me.BtnBuscar
        Me.BtnBuscar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnBuscar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnBuscar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnBuscar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnBuscar.DisabledState.Parent = Me.BtnBuscar
        Me.BtnBuscar.FillColor = System.Drawing.Color.Transparent
        Me.BtnBuscar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnBuscar.ForeColor = System.Drawing.Color.White
        Me.BtnBuscar.HoverState.Parent = Me.BtnBuscar
        Me.BtnBuscar.Location = New System.Drawing.Point(631, 339)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.ShadowDecoration.Parent = Me.BtnBuscar
        Me.BtnBuscar.Size = New System.Drawing.Size(30, 30)
        Me.BtnBuscar.TabIndex = 14
        '
        'TxtOtro
        '
        Me.TxtOtro.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtOtro.DefaultText = ""
        Me.TxtOtro.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtOtro.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtOtro.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtOtro.DisabledState.Parent = Me.TxtOtro
        Me.TxtOtro.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtOtro.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtOtro.FocusedState.Parent = Me.TxtOtro
        Me.TxtOtro.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!)
        Me.TxtOtro.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtOtro.HoverState.Parent = Me.TxtOtro
        Me.TxtOtro.Location = New System.Drawing.Point(416, 136)
        Me.TxtOtro.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtOtro.Name = "TxtOtro"
        Me.TxtOtro.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtOtro.PlaceholderText = ""
        Me.TxtOtro.SelectedText = ""
        Me.TxtOtro.ShadowDecoration.Parent = Me.TxtOtro
        Me.TxtOtro.Size = New System.Drawing.Size(175, 30)
        Me.TxtOtro.TabIndex = 14
        '
        'Guna2HtmlLabel10
        '
        Me.Guna2HtmlLabel10.BackColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel10.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!)
        Me.Guna2HtmlLabel10.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel10.Location = New System.Drawing.Point(370, 139)
        Me.Guna2HtmlLabel10.Name = "Guna2HtmlLabel10"
        Me.Guna2HtmlLabel10.Size = New System.Drawing.Size(33, 20)
        Me.Guna2HtmlLabel10.TabIndex = 13
        Me.Guna2HtmlLabel10.Text = "Otro"
        '
        'CbxFecha
        '
        Me.CbxFecha.BackColor = System.Drawing.Color.Transparent
        Me.CbxFecha.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CbxFecha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxFecha.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CbxFecha.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CbxFecha.FocusedState.Parent = Me.CbxFecha
        Me.CbxFecha.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!)
        Me.CbxFecha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CbxFecha.HoverState.Parent = Me.CbxFecha
        Me.CbxFecha.ItemHeight = 30
        Me.CbxFecha.ItemsAppearance.Parent = Me.CbxFecha
        Me.CbxFecha.Location = New System.Drawing.Point(106, 334)
        Me.CbxFecha.Name = "CbxFecha"
        Me.CbxFecha.ShadowDecoration.Parent = Me.CbxFecha
        Me.CbxFecha.Size = New System.Drawing.Size(120, 36)
        Me.CbxFecha.TabIndex = 12
        '
        'CbxAnio
        '
        Me.CbxAnio.BackColor = System.Drawing.Color.Transparent
        Me.CbxAnio.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CbxAnio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxAnio.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CbxAnio.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CbxAnio.FocusedState.Parent = Me.CbxAnio
        Me.CbxAnio.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!)
        Me.CbxAnio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CbxAnio.HoverState.Parent = Me.CbxAnio
        Me.CbxAnio.ItemHeight = 30
        Me.CbxAnio.ItemsAppearance.Parent = Me.CbxAnio
        Me.CbxAnio.Location = New System.Drawing.Point(135, 207)
        Me.CbxAnio.Name = "CbxAnio"
        Me.CbxAnio.ShadowDecoration.Parent = Me.CbxAnio
        Me.CbxAnio.Size = New System.Drawing.Size(175, 36)
        Me.CbxAnio.TabIndex = 11
        '
        'CbxNombre
        '
        Me.CbxNombre.BackColor = System.Drawing.Color.Transparent
        Me.CbxNombre.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CbxNombre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxNombre.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CbxNombre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CbxNombre.FocusedState.Parent = Me.CbxNombre
        Me.CbxNombre.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!)
        Me.CbxNombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CbxNombre.HoverState.Parent = Me.CbxNombre
        Me.CbxNombre.ItemHeight = 30
        Me.CbxNombre.ItemsAppearance.Parent = Me.CbxNombre
        Me.CbxNombre.Location = New System.Drawing.Point(135, 133)
        Me.CbxNombre.Name = "CbxNombre"
        Me.CbxNombre.ShadowDecoration.Parent = Me.CbxNombre
        Me.CbxNombre.Size = New System.Drawing.Size(175, 36)
        Me.CbxNombre.TabIndex = 10
        '
        'Guna2HtmlLabel7
        '
        Me.Guna2HtmlLabel7.BackColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel7.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel7.ForeColor = System.Drawing.Color.MediumAquamarine
        Me.Guna2HtmlLabel7.Location = New System.Drawing.Point(156, 76)
        Me.Guna2HtmlLabel7.Name = "Guna2HtmlLabel7"
        Me.Guna2HtmlLabel7.Size = New System.Drawing.Size(74, 22)
        Me.Guna2HtmlLabel7.TabIndex = 5
        Me.Guna2HtmlLabel7.Text = "/ Materia"
        '
        'Guna2HtmlLabel9
        '
        Me.Guna2HtmlLabel9.BackColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel9.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!)
        Me.Guna2HtmlLabel9.ForeColor = System.Drawing.Color.MediumAquamarine
        Me.Guna2HtmlLabel9.Location = New System.Drawing.Point(27, 76)
        Me.Guna2HtmlLabel9.Name = "Guna2HtmlLabel9"
        Me.Guna2HtmlLabel9.Size = New System.Drawing.Size(65, 20)
        Me.Guna2HtmlLabel9.TabIndex = 3
        Me.Guna2HtmlLabel9.Text = "Institución"
        '
        'TxtHasta
        '
        Me.TxtHasta.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtHasta.DefaultText = ""
        Me.TxtHasta.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtHasta.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtHasta.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtHasta.DisabledState.Parent = Me.TxtHasta
        Me.TxtHasta.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtHasta.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtHasta.FocusedState.Parent = Me.TxtHasta
        Me.TxtHasta.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!)
        Me.TxtHasta.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtHasta.HoverState.Parent = Me.TxtHasta
        Me.TxtHasta.Location = New System.Drawing.Point(484, 339)
        Me.TxtHasta.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtHasta.Name = "TxtHasta"
        Me.TxtHasta.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtHasta.PlaceholderText = ""
        Me.TxtHasta.SelectedText = ""
        Me.TxtHasta.ShadowDecoration.Parent = Me.TxtHasta
        Me.TxtHasta.Size = New System.Drawing.Size(120, 30)
        Me.TxtHasta.TabIndex = 8
        '
        'TxtDesde
        '
        Me.TxtDesde.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtDesde.DefaultText = ""
        Me.TxtDesde.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtDesde.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtDesde.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtDesde.DisabledState.Parent = Me.TxtDesde
        Me.TxtDesde.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtDesde.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtDesde.FocusedState.Parent = Me.TxtDesde
        Me.TxtDesde.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!)
        Me.TxtDesde.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtDesde.HoverState.Parent = Me.TxtDesde
        Me.TxtDesde.Location = New System.Drawing.Point(295, 339)
        Me.TxtDesde.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtDesde.Name = "TxtDesde"
        Me.TxtDesde.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtDesde.PlaceholderText = ""
        Me.TxtDesde.SelectedText = ""
        Me.TxtDesde.ShadowDecoration.Parent = Me.TxtDesde
        Me.TxtDesde.Size = New System.Drawing.Size(120, 30)
        Me.TxtDesde.TabIndex = 7
        '
        'Guna2HtmlLabel6
        '
        Me.Guna2HtmlLabel6.BackColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel6.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!)
        Me.Guna2HtmlLabel6.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel6.Location = New System.Drawing.Point(436, 344)
        Me.Guna2HtmlLabel6.Name = "Guna2HtmlLabel6"
        Me.Guna2HtmlLabel6.Size = New System.Drawing.Size(42, 20)
        Me.Guna2HtmlLabel6.TabIndex = 5
        Me.Guna2HtmlLabel6.Text = "Hasta"
        '
        'Guna2HtmlLabel5
        '
        Me.Guna2HtmlLabel5.BackColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel5.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!)
        Me.Guna2HtmlLabel5.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel5.Location = New System.Drawing.Point(245, 344)
        Me.Guna2HtmlLabel5.Name = "Guna2HtmlLabel5"
        Me.Guna2HtmlLabel5.Size = New System.Drawing.Size(44, 20)
        Me.Guna2HtmlLabel5.TabIndex = 4
        Me.Guna2HtmlLabel5.Text = "Desde"
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!)
        Me.Guna2HtmlLabel4.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(54, 340)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(27, 20)
        Me.Guna2HtmlLabel4.TabIndex = 3
        Me.Guna2HtmlLabel4.Text = "Día"
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel3.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(30, 284)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(209, 23)
        Me.Guna2HtmlLabel3.TabIndex = 2
        Me.Guna2HtmlLabel3.Text = "Horario y dia del módulo:"
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!)
        Me.Guna2HtmlLabel2.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(54, 213)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(30, 20)
        Me.Guna2HtmlLabel2.TabIndex = 1
        Me.Guna2HtmlLabel2.Text = "Año"
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!)
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(54, 139)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(57, 20)
        Me.Guna2HtmlLabel1.TabIndex = 0
        Me.Guna2HtmlLabel1.Text = "Nombre"
        '
        'PnlRecuadro1
        '
        Me.PnlRecuadro1.BackgroundImage = CType(resources.GetObject("PnlRecuadro1.BackgroundImage"), System.Drawing.Image)
        Me.PnlRecuadro1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PnlRecuadro1.Controls.Add(Me.BtnSiguiente)
        Me.PnlRecuadro1.Controls.Add(Me.Guna2HtmlLabel8)
        Me.PnlRecuadro1.Location = New System.Drawing.Point(6, 52)
        Me.PnlRecuadro1.Name = "PnlRecuadro1"
        Me.PnlRecuadro1.ShadowDecoration.Parent = Me.PnlRecuadro1
        Me.PnlRecuadro1.Size = New System.Drawing.Size(798, 415)
        Me.PnlRecuadro1.TabIndex = 25
        '
        'BtnSiguiente
        '
        Me.BtnSiguiente.CheckedState.Parent = Me.BtnSiguiente
        Me.BtnSiguiente.CustomImages.Parent = Me.BtnSiguiente
        Me.BtnSiguiente.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnSiguiente.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnSiguiente.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnSiguiente.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnSiguiente.DisabledState.Parent = Me.BtnSiguiente
        Me.BtnSiguiente.FillColor = System.Drawing.Color.MediumAquamarine
        Me.BtnSiguiente.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSiguiente.ForeColor = System.Drawing.Color.White
        Me.BtnSiguiente.HoverState.Parent = Me.BtnSiguiente
        Me.BtnSiguiente.Location = New System.Drawing.Point(672, 356)
        Me.BtnSiguiente.Name = "BtnSiguiente"
        Me.BtnSiguiente.ShadowDecoration.Parent = Me.BtnSiguiente
        Me.BtnSiguiente.Size = New System.Drawing.Size(100, 35)
        Me.BtnSiguiente.TabIndex = 9
        Me.BtnSiguiente.Text = "Siguente"
        '
        'Guna2HtmlLabel8
        '
        Me.Guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel8.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel8.ForeColor = System.Drawing.Color.MediumAquamarine
        Me.Guna2HtmlLabel8.Location = New System.Drawing.Point(85, 24)
        Me.Guna2HtmlLabel8.Name = "Guna2HtmlLabel8"
        Me.Guna2HtmlLabel8.Size = New System.Drawing.Size(62, 20)
        Me.Guna2HtmlLabel8.TabIndex = 4
        Me.Guna2HtmlLabel8.Text = "/ Carrera "
        '
        'PnlBotones
        '
        Me.PnlBotones.BackColor = System.Drawing.Color.Transparent
        Me.PnlBotones.Controls.Add(Me.BtnCerrar)
        Me.PnlBotones.Controls.Add(Me.BtnMaximizar)
        Me.PnlBotones.Controls.Add(Me.BtnMinimizar)
        Me.PnlBotones.Location = New System.Drawing.Point(768, 3)
        Me.PnlBotones.Name = "PnlBotones"
        Me.PnlBotones.ShadowDecoration.Parent = Me.PnlBotones
        Me.PnlBotones.Size = New System.Drawing.Size(97, 34)
        Me.PnlBotones.TabIndex = 28
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
        Me.BtnCerrar.Location = New System.Drawing.Point(65, 3)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.ShadowDecoration.Parent = Me.BtnCerrar
        Me.BtnCerrar.Size = New System.Drawing.Size(25, 25)
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
        Me.BtnMaximizar.Location = New System.Drawing.Point(34, 3)
        Me.BtnMaximizar.Name = "BtnMaximizar"
        Me.BtnMaximizar.ShadowDecoration.Parent = Me.BtnMaximizar
        Me.BtnMaximizar.Size = New System.Drawing.Size(25, 25)
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
        Me.BtnMinimizar.Location = New System.Drawing.Point(3, 3)
        Me.BtnMinimizar.Name = "BtnMinimizar"
        Me.BtnMinimizar.ShadowDecoration.Parent = Me.BtnMinimizar
        Me.BtnMinimizar.Size = New System.Drawing.Size(25, 25)
        Me.BtnMinimizar.TabIndex = 4
        '
        'FrmGrupoMateria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(868, 478)
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmGrupoMateria"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox1.PerformLayout()
        Me.PnlRecuadro1.ResumeLayout(False)
        Me.PnlRecuadro1.PerformLayout()
        Me.PnlBotones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Guna2HtmlLabel6 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents BtnSiguiente As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2HtmlLabel7 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel8 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel9 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents CbxNombre As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents TxtOtro As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel10 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents CbxFecha As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents CbxAnio As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents TxtHasta As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TxtDesde As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents BtnGuardar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnEliminar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnBuscar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PnlRecuadro1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents PnlBotones As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents BtnCerrar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnMaximizar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnMinimizar As Guna.UI2.WinForms.Guna2Button
End Class
