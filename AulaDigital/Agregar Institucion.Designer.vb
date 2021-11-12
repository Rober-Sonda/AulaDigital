<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAgregarInst
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAgregarInst))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.PnlBotones = New Guna.UI2.WinForms.Guna2Panel()
        Me.BtnCerrar = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnMaximizar = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnMinimizar = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2HtmlLabel10 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel9 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.TxtCelular = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TxtTelefono = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TxtDirecion = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel6 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.LblNombreInst = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.PnlRecuadro1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.BtnDescartar = New Guna.UI2.WinForms.Guna2Button()
        Me.TxtNombre = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel8 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.BtnEliminar = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnEditar = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnGuardar = New Guna.UI2.WinForms.Guna2Button()
        Me.PnlRecuadro2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.TxtBuscar = New Guna.UI2.WinForms.Guna2TextBox()
        Me.BtnBuscar = New Guna.UI2.WinForms.Guna2Button()
        Me.LblLista = New System.Windows.Forms.Label()
        Me.Guna2DataGridView1 = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.TxtMail = New Guna.UI2.WinForms.Guna2TextBox()
        Me.LblMail = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.TxtCodAreaTel = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TxtCodAreaCel = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2.SuspendLayout()
        Me.PnlBotones.SuspendLayout()
        Me.PnlRecuadro1.SuspendLayout()
        Me.PnlRecuadro2.SuspendLayout()
        CType(Me.Guna2DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2
        '
        Me.Guna2.Controls.Add(Me.PnlBotones)
        Me.Guna2.Controls.Add(Me.Guna2HtmlLabel10)
        Me.Guna2.Controls.Add(Me.Guna2HtmlLabel9)
        Me.Guna2.Controls.Add(Me.TxtCelular)
        Me.Guna2.Controls.Add(Me.TxtTelefono)
        Me.Guna2.Controls.Add(Me.TxtDirecion)
        Me.Guna2.Controls.Add(Me.Guna2HtmlLabel6)
        Me.Guna2.Controls.Add(Me.Guna2HtmlLabel5)
        Me.Guna2.Controls.Add(Me.LblNombreInst)
        Me.Guna2.Controls.Add(Me.PnlRecuadro1)
        Me.Guna2.Controls.Add(Me.PnlRecuadro2)
        Me.Guna2.CustomBorderColor = System.Drawing.Color.MediumAquamarine
        Me.Guna2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2.FillColor = System.Drawing.Color.LightGray
        Me.Guna2.Font = New System.Drawing.Font("Berlin Sans FB", 18.0!)
        Me.Guna2.ForeColor = System.Drawing.Color.White
        Me.Guna2.Location = New System.Drawing.Point(0, 0)
        Me.Guna2.Name = "Guna2"
        Me.Guna2.ShadowDecoration.Parent = Me.Guna2
        Me.Guna2.Size = New System.Drawing.Size(884, 512)
        Me.Guna2.TabIndex = 1
        Me.Guna2.Text = "Institucion"
        '
        'PnlBotones
        '
        Me.PnlBotones.BackColor = System.Drawing.Color.Transparent
        Me.PnlBotones.Controls.Add(Me.BtnCerrar)
        Me.PnlBotones.Controls.Add(Me.BtnMaximizar)
        Me.PnlBotones.Controls.Add(Me.BtnMinimizar)
        Me.PnlBotones.Location = New System.Drawing.Point(784, 3)
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
        'Guna2HtmlLabel10
        '
        Me.Guna2HtmlLabel10.BackColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel10.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!)
        Me.Guna2HtmlLabel10.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel10.Location = New System.Drawing.Point(36, 264)
        Me.Guna2HtmlLabel10.Name = "Guna2HtmlLabel10"
        Me.Guna2HtmlLabel10.Size = New System.Drawing.Size(48, 20)
        Me.Guna2HtmlLabel10.TabIndex = 19
        Me.Guna2HtmlLabel10.Text = "Celular"
        '
        'Guna2HtmlLabel9
        '
        Me.Guna2HtmlLabel9.BackColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel9.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel9.ForeColor = System.Drawing.Color.MediumAquamarine
        Me.Guna2HtmlLabel9.Location = New System.Drawing.Point(17, 61)
        Me.Guna2HtmlLabel9.Name = "Guna2HtmlLabel9"
        Me.Guna2HtmlLabel9.Size = New System.Drawing.Size(123, 20)
        Me.Guna2HtmlLabel9.TabIndex = 10
        Me.Guna2HtmlLabel9.Text = "Agregar Institución"
        '
        'TxtCelular
        '
        Me.TxtCelular.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtCelular.DefaultText = ""
        Me.TxtCelular.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtCelular.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtCelular.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtCelular.DisabledState.Parent = Me.TxtCelular
        Me.TxtCelular.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtCelular.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtCelular.FocusedState.Parent = Me.TxtCelular
        Me.TxtCelular.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!)
        Me.TxtCelular.ForeColor = System.Drawing.Color.Black
        Me.TxtCelular.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtCelular.HoverState.Parent = Me.TxtCelular
        Me.TxtCelular.Location = New System.Drawing.Point(188, 260)
        Me.TxtCelular.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtCelular.Name = "TxtCelular"
        Me.TxtCelular.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtCelular.PlaceholderText = ""
        Me.TxtCelular.SelectedText = ""
        Me.TxtCelular.ShadowDecoration.Parent = Me.TxtCelular
        Me.TxtCelular.Size = New System.Drawing.Size(104, 30)
        Me.TxtCelular.TabIndex = 8
        '
        'TxtTelefono
        '
        Me.TxtTelefono.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtTelefono.DefaultText = ""
        Me.TxtTelefono.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtTelefono.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtTelefono.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtTelefono.DisabledState.Parent = Me.TxtTelefono
        Me.TxtTelefono.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtTelefono.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtTelefono.FocusedState.Parent = Me.TxtTelefono
        Me.TxtTelefono.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!)
        Me.TxtTelefono.ForeColor = System.Drawing.Color.Black
        Me.TxtTelefono.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtTelefono.HoverState.Parent = Me.TxtTelefono
        Me.TxtTelefono.Location = New System.Drawing.Point(188, 209)
        Me.TxtTelefono.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtTelefono.Name = "TxtTelefono"
        Me.TxtTelefono.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtTelefono.PlaceholderText = ""
        Me.TxtTelefono.SelectedText = ""
        Me.TxtTelefono.ShadowDecoration.Parent = Me.TxtTelefono
        Me.TxtTelefono.Size = New System.Drawing.Size(104, 30)
        Me.TxtTelefono.TabIndex = 7
        '
        'TxtDirecion
        '
        Me.TxtDirecion.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtDirecion.DefaultText = ""
        Me.TxtDirecion.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtDirecion.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtDirecion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtDirecion.DisabledState.Parent = Me.TxtDirecion
        Me.TxtDirecion.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtDirecion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtDirecion.FocusedState.Parent = Me.TxtDirecion
        Me.TxtDirecion.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!)
        Me.TxtDirecion.ForeColor = System.Drawing.Color.Black
        Me.TxtDirecion.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtDirecion.HoverState.Parent = Me.TxtDirecion
        Me.TxtDirecion.Location = New System.Drawing.Point(117, 159)
        Me.TxtDirecion.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtDirecion.Name = "TxtDirecion"
        Me.TxtDirecion.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtDirecion.PlaceholderText = ""
        Me.TxtDirecion.SelectedText = ""
        Me.TxtDirecion.ShadowDecoration.Parent = Me.TxtDirecion
        Me.TxtDirecion.Size = New System.Drawing.Size(175, 30)
        Me.TxtDirecion.TabIndex = 6
        '
        'Guna2HtmlLabel6
        '
        Me.Guna2HtmlLabel6.BackColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel6.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!)
        Me.Guna2HtmlLabel6.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel6.Location = New System.Drawing.Point(36, 213)
        Me.Guna2HtmlLabel6.Name = "Guna2HtmlLabel6"
        Me.Guna2HtmlLabel6.Size = New System.Drawing.Size(59, 20)
        Me.Guna2HtmlLabel6.TabIndex = 5
        Me.Guna2HtmlLabel6.Text = "Telefono"
        '
        'Guna2HtmlLabel5
        '
        Me.Guna2HtmlLabel5.BackColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel5.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!)
        Me.Guna2HtmlLabel5.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel5.Location = New System.Drawing.Point(36, 163)
        Me.Guna2HtmlLabel5.Name = "Guna2HtmlLabel5"
        Me.Guna2HtmlLabel5.Size = New System.Drawing.Size(61, 20)
        Me.Guna2HtmlLabel5.TabIndex = 4
        Me.Guna2HtmlLabel5.Text = "Dirección"
        '
        'LblNombreInst
        '
        Me.LblNombreInst.BackColor = System.Drawing.Color.White
        Me.LblNombreInst.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!)
        Me.LblNombreInst.ForeColor = System.Drawing.Color.Black
        Me.LblNombreInst.Location = New System.Drawing.Point(36, 108)
        Me.LblNombreInst.Name = "LblNombreInst"
        Me.LblNombreInst.Size = New System.Drawing.Size(57, 20)
        Me.LblNombreInst.TabIndex = 3
        Me.LblNombreInst.Text = "Nombre"
        '
        'PnlRecuadro1
        '
        Me.PnlRecuadro1.BackgroundImage = CType(resources.GetObject("PnlRecuadro1.BackgroundImage"), System.Drawing.Image)
        Me.PnlRecuadro1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PnlRecuadro1.Controls.Add(Me.TxtCodAreaCel)
        Me.PnlRecuadro1.Controls.Add(Me.TxtCodAreaTel)
        Me.PnlRecuadro1.Controls.Add(Me.BtnDescartar)
        Me.PnlRecuadro1.Controls.Add(Me.LblMail)
        Me.PnlRecuadro1.Controls.Add(Me.TxtNombre)
        Me.PnlRecuadro1.Controls.Add(Me.Guna2HtmlLabel8)
        Me.PnlRecuadro1.Controls.Add(Me.TxtMail)
        Me.PnlRecuadro1.Controls.Add(Me.BtnEliminar)
        Me.PnlRecuadro1.Controls.Add(Me.BtnEditar)
        Me.PnlRecuadro1.Controls.Add(Me.BtnGuardar)
        Me.PnlRecuadro1.Location = New System.Drawing.Point(8, 49)
        Me.PnlRecuadro1.Name = "PnlRecuadro1"
        Me.PnlRecuadro1.ShadowDecoration.Parent = Me.PnlRecuadro1
        Me.PnlRecuadro1.Size = New System.Drawing.Size(494, 451)
        Me.PnlRecuadro1.TabIndex = 23
        '
        'BtnDescartar
        '
        Me.BtnDescartar.CheckedState.Parent = Me.BtnDescartar
        Me.BtnDescartar.CustomImages.Parent = Me.BtnDescartar
        Me.BtnDescartar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnDescartar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnDescartar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnDescartar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnDescartar.DisabledState.Parent = Me.BtnDescartar
        Me.BtnDescartar.FillColor = System.Drawing.Color.MediumAquamarine
        Me.BtnDescartar.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!)
        Me.BtnDescartar.ForeColor = System.Drawing.Color.White
        Me.BtnDescartar.HoverState.Parent = Me.BtnDescartar
        Me.BtnDescartar.Location = New System.Drawing.Point(256, 396)
        Me.BtnDescartar.Name = "BtnDescartar"
        Me.BtnDescartar.ShadowDecoration.Parent = Me.BtnDescartar
        Me.BtnDescartar.Size = New System.Drawing.Size(110, 35)
        Me.BtnDescartar.TabIndex = 26
        Me.BtnDescartar.Text = "Descartar"
        '
        'TxtNombre
        '
        Me.TxtNombre.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtNombre.DefaultText = ""
        Me.TxtNombre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtNombre.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtNombre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtNombre.DisabledState.Parent = Me.TxtNombre
        Me.TxtNombre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtNombre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtNombre.FocusedState.Parent = Me.TxtNombre
        Me.TxtNombre.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!)
        Me.TxtNombre.ForeColor = System.Drawing.Color.Black
        Me.TxtNombre.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtNombre.HoverState.Parent = Me.TxtNombre
        Me.TxtNombre.Location = New System.Drawing.Point(109, 59)
        Me.TxtNombre.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtNombre.PlaceholderText = ""
        Me.TxtNombre.SelectedText = ""
        Me.TxtNombre.ShadowDecoration.Parent = Me.TxtNombre
        Me.TxtNombre.Size = New System.Drawing.Size(175, 30)
        Me.TxtNombre.TabIndex = 25
        '
        'Guna2HtmlLabel8
        '
        Me.Guna2HtmlLabel8.BackColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel8.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel8.ForeColor = System.Drawing.Color.MediumAquamarine
        Me.Guna2HtmlLabel8.Location = New System.Drawing.Point(136, 12)
        Me.Guna2HtmlLabel8.Name = "Guna2HtmlLabel8"
        Me.Guna2HtmlLabel8.Size = New System.Drawing.Size(101, 20)
        Me.Guna2HtmlLabel8.TabIndex = 11
        Me.Guna2HtmlLabel8.Text = "/  Ver existentes"
        '
        'BtnEliminar
        '
        Me.BtnEliminar.BackColor = System.Drawing.Color.Transparent
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
        Me.BtnEliminar.Location = New System.Drawing.Point(442, 86)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.ShadowDecoration.Parent = Me.BtnEliminar
        Me.BtnEliminar.Size = New System.Drawing.Size(30, 30)
        Me.BtnEliminar.TabIndex = 24
        '
        'BtnEditar
        '
        Me.BtnEditar.BackColor = System.Drawing.Color.Transparent
        Me.BtnEditar.BackgroundImage = CType(resources.GetObject("BtnEditar.BackgroundImage"), System.Drawing.Image)
        Me.BtnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnEditar.CheckedState.Parent = Me.BtnEditar
        Me.BtnEditar.CustomImages.Parent = Me.BtnEditar
        Me.BtnEditar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnEditar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnEditar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnEditar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnEditar.DisabledState.Parent = Me.BtnEditar
        Me.BtnEditar.FillColor = System.Drawing.Color.Transparent
        Me.BtnEditar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnEditar.ForeColor = System.Drawing.Color.White
        Me.BtnEditar.HoverState.Parent = Me.BtnEditar
        Me.BtnEditar.Location = New System.Drawing.Point(442, 49)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.ShadowDecoration.Parent = Me.BtnEditar
        Me.BtnEditar.Size = New System.Drawing.Size(30, 30)
        Me.BtnEditar.TabIndex = 23
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
        Me.BtnGuardar.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!)
        Me.BtnGuardar.ForeColor = System.Drawing.Color.White
        Me.BtnGuardar.HoverState.Parent = Me.BtnGuardar
        Me.BtnGuardar.Location = New System.Drawing.Point(372, 396)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.ShadowDecoration.Parent = Me.BtnGuardar
        Me.BtnGuardar.Size = New System.Drawing.Size(100, 35)
        Me.BtnGuardar.TabIndex = 9
        Me.BtnGuardar.Text = "Guardar"
        '
        'PnlRecuadro2
        '
        Me.PnlRecuadro2.BackgroundImage = CType(resources.GetObject("PnlRecuadro2.BackgroundImage"), System.Drawing.Image)
        Me.PnlRecuadro2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PnlRecuadro2.Controls.Add(Me.TxtBuscar)
        Me.PnlRecuadro2.Controls.Add(Me.BtnBuscar)
        Me.PnlRecuadro2.Controls.Add(Me.LblLista)
        Me.PnlRecuadro2.Controls.Add(Me.Guna2DataGridView1)
        Me.PnlRecuadro2.Location = New System.Drawing.Point(546, 49)
        Me.PnlRecuadro2.Name = "PnlRecuadro2"
        Me.PnlRecuadro2.ShadowDecoration.Parent = Me.PnlRecuadro2
        Me.PnlRecuadro2.Size = New System.Drawing.Size(318, 451)
        Me.PnlRecuadro2.TabIndex = 24
        '
        'TxtBuscar
        '
        Me.TxtBuscar.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtBuscar.DefaultText = ""
        Me.TxtBuscar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtBuscar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtBuscar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtBuscar.DisabledState.Parent = Me.TxtBuscar
        Me.TxtBuscar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtBuscar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtBuscar.FocusedState.Parent = Me.TxtBuscar
        Me.TxtBuscar.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!)
        Me.TxtBuscar.ForeColor = System.Drawing.Color.Black
        Me.TxtBuscar.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtBuscar.HoverState.Parent = Me.TxtBuscar
        Me.TxtBuscar.Location = New System.Drawing.Point(25, 40)
        Me.TxtBuscar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtBuscar.PlaceholderText = ""
        Me.TxtBuscar.SelectedText = ""
        Me.TxtBuscar.ShadowDecoration.Parent = Me.TxtBuscar
        Me.TxtBuscar.Size = New System.Drawing.Size(248, 30)
        Me.TxtBuscar.TabIndex = 26
        '
        'BtnBuscar
        '
        Me.BtnBuscar.BackColor = System.Drawing.Color.Transparent
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
        Me.BtnBuscar.Location = New System.Drawing.Point(279, 40)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.ShadowDecoration.Parent = Me.BtnBuscar
        Me.BtnBuscar.Size = New System.Drawing.Size(30, 30)
        Me.BtnBuscar.TabIndex = 22
        '
        'LblLista
        '
        Me.LblLista.AutoSize = True
        Me.LblLista.BackColor = System.Drawing.Color.Transparent
        Me.LblLista.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!)
        Me.LblLista.ForeColor = System.Drawing.Color.MediumAquamarine
        Me.LblLista.Location = New System.Drawing.Point(121, 15)
        Me.LblLista.Name = "LblLista"
        Me.LblLista.Size = New System.Drawing.Size(105, 21)
        Me.LblLista.TabIndex = 21
        Me.LblLista.Text = "Instituciones"
        '
        'Guna2DataGridView1
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.Guna2DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Guna2DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Guna2DataGridView1.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.Guna2DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Guna2DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.Guna2DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Berlin Sans FB", 18.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Guna2DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Guna2DataGridView1.ColumnHeadersHeight = 4
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Berlin Sans FB", 18.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Guna2DataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Me.Guna2DataGridView1.EnableHeadersVisualStyles = False
        Me.Guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2DataGridView1.Location = New System.Drawing.Point(9, 85)
        Me.Guna2DataGridView1.Name = "Guna2DataGridView1"
        Me.Guna2DataGridView1.RowHeadersVisible = False
        Me.Guna2DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Guna2DataGridView1.Size = New System.Drawing.Size(300, 346)
        Me.Guna2DataGridView1.TabIndex = 20
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.Guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.Gainsboro
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
        'TxtMail
        '
        Me.TxtMail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtMail.DefaultText = ""
        Me.TxtMail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtMail.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtMail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtMail.DisabledState.Parent = Me.TxtMail
        Me.TxtMail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtMail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtMail.FocusedState.Parent = Me.TxtMail
        Me.TxtMail.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!)
        Me.TxtMail.ForeColor = System.Drawing.Color.Black
        Me.TxtMail.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtMail.HoverState.Parent = Me.TxtMail
        Me.TxtMail.Location = New System.Drawing.Point(109, 261)
        Me.TxtMail.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtMail.Name = "TxtMail"
        Me.TxtMail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtMail.PlaceholderText = ""
        Me.TxtMail.SelectedText = ""
        Me.TxtMail.ShadowDecoration.Parent = Me.TxtMail
        Me.TxtMail.Size = New System.Drawing.Size(175, 30)
        Me.TxtMail.TabIndex = 8
        '
        'LblMail
        '
        Me.LblMail.BackColor = System.Drawing.Color.White
        Me.LblMail.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!)
        Me.LblMail.ForeColor = System.Drawing.Color.Black
        Me.LblMail.Location = New System.Drawing.Point(28, 265)
        Me.LblMail.Name = "LblMail"
        Me.LblMail.Size = New System.Drawing.Size(29, 20)
        Me.LblMail.TabIndex = 19
        Me.LblMail.Text = "Mail"
        '
        'TxtCodAreaTel
        '
        Me.TxtCodAreaTel.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtCodAreaTel.DefaultText = ""
        Me.TxtCodAreaTel.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtCodAreaTel.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtCodAreaTel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtCodAreaTel.DisabledState.Parent = Me.TxtCodAreaTel
        Me.TxtCodAreaTel.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtCodAreaTel.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtCodAreaTel.FocusedState.Parent = Me.TxtCodAreaTel
        Me.TxtCodAreaTel.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!)
        Me.TxtCodAreaTel.ForeColor = System.Drawing.Color.Black
        Me.TxtCodAreaTel.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtCodAreaTel.HoverState.Parent = Me.TxtCodAreaTel
        Me.TxtCodAreaTel.Location = New System.Drawing.Point(109, 160)
        Me.TxtCodAreaTel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtCodAreaTel.Name = "TxtCodAreaTel"
        Me.TxtCodAreaTel.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtCodAreaTel.PlaceholderText = ""
        Me.TxtCodAreaTel.SelectedText = ""
        Me.TxtCodAreaTel.ShadowDecoration.Parent = Me.TxtCodAreaTel
        Me.TxtCodAreaTel.Size = New System.Drawing.Size(61, 30)
        Me.TxtCodAreaTel.TabIndex = 29
        '
        'TxtCodAreaCel
        '
        Me.TxtCodAreaCel.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtCodAreaCel.DefaultText = ""
        Me.TxtCodAreaCel.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtCodAreaCel.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtCodAreaCel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtCodAreaCel.DisabledState.Parent = Me.TxtCodAreaCel
        Me.TxtCodAreaCel.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtCodAreaCel.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtCodAreaCel.FocusedState.Parent = Me.TxtCodAreaCel
        Me.TxtCodAreaCel.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!)
        Me.TxtCodAreaCel.ForeColor = System.Drawing.Color.Black
        Me.TxtCodAreaCel.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtCodAreaCel.HoverState.Parent = Me.TxtCodAreaCel
        Me.TxtCodAreaCel.Location = New System.Drawing.Point(109, 211)
        Me.TxtCodAreaCel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtCodAreaCel.Name = "TxtCodAreaCel"
        Me.TxtCodAreaCel.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtCodAreaCel.PlaceholderText = ""
        Me.TxtCodAreaCel.SelectedText = ""
        Me.TxtCodAreaCel.ShadowDecoration.Parent = Me.TxtCodAreaCel
        Me.TxtCodAreaCel.Size = New System.Drawing.Size(61, 30)
        Me.TxtCodAreaCel.TabIndex = 29
        '
        'FrmAgregarInst
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 512)
        Me.Controls.Add(Me.Guna2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmAgregarInst"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Agregar_Institucion"
        Me.Guna2.ResumeLayout(False)
        Me.Guna2.PerformLayout()
        Me.PnlBotones.ResumeLayout(False)
        Me.PnlRecuadro1.ResumeLayout(False)
        Me.PnlRecuadro1.PerformLayout()
        Me.PnlRecuadro2.ResumeLayout(False)
        Me.PnlRecuadro2.PerformLayout()
        CType(Me.Guna2DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Guna2HtmlLabel10 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel8 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel9 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents BtnGuardar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TxtCelular As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TxtTelefono As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TxtDirecion As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel6 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents LblNombreInst As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents PnlRecuadro1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents TxtNombre As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BtnEliminar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnEditar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PnlRecuadro2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents BtnBuscar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents LblLista As Label
    Friend WithEvents Guna2DataGridView1 As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents BtnDescartar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TxtBuscar As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents PnlBotones As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents BtnCerrar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnMaximizar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnMinimizar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents LblMail As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents TxtMail As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TxtCodAreaCel As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TxtCodAreaTel As Guna.UI2.WinForms.Guna2TextBox
End Class
