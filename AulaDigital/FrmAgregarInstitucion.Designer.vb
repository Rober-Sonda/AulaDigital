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
        Me.Guna2HtmlLabel8 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblTelCel = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.CmbLocalidadInstitucion = New System.Windows.Forms.ComboBox()
        Me.TxtDireccion = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.Panel16 = New System.Windows.Forms.Panel()
        Me.TxtMail = New System.Windows.Forms.TextBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lblNomInst = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.LbltitulofrmInstitucion = New System.Windows.Forms.Label()
        Me.PnlInstitucion = New System.Windows.Forms.Panel()
        Me.dgvTelCelInst = New System.Windows.Forms.DataGridView()
        Me.btnAgregarTelCel = New System.Windows.Forms.Button()
        Me.btnAgregarLocalidad = New System.Windows.Forms.Button()
        Me.Panel4.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.Panel13.SuspendLayout()
        Me.Panel14.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.PnlInstitucion.SuspendLayout()
        CType(Me.dgvTelCelInst, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(29, 152)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 20)
        Me.Label2.TabIndex = 162
        Me.Label2.Text = "Localidad *"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTelCel
        '
        Me.lblTelCel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTelCel.AutoSize = True
        Me.lblTelCel.BackColor = System.Drawing.Color.Transparent
        Me.lblTelCel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblTelCel.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.lblTelCel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.lblTelCel.Location = New System.Drawing.Point(29, 263)
        Me.lblTelCel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTelCel.Name = "lblTelCel"
        Me.lblTelCel.Size = New System.Drawing.Size(67, 20)
        Me.lblTelCel.TabIndex = 163
        Me.lblTelCel.Text = "Tel / Cel"
        Me.lblTelCel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(29, 204)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 20)
        Me.Label5.TabIndex = 164
        Me.Label5.Text = "Mail"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnGuardar.FlatAppearance.BorderSize = 0
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.btnGuardar.ForeColor = System.Drawing.Color.White
        Me.btnGuardar.Location = New System.Drawing.Point(201, 332)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(117, 30)
        Me.btnGuardar.TabIndex = 9
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'TxtNombre
        '
        Me.TxtNombre.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtNombre.BackColor = System.Drawing.Color.FloralWhite
        Me.TxtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtNombre.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombre.ForeColor = System.Drawing.Color.Black
        Me.TxtNombre.Location = New System.Drawing.Point(127, 59)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(332, 20)
        Me.TxtNombre.TabIndex = 1
        Me.TxtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CmbLocalidadInstitucion
        '
        Me.CmbLocalidadInstitucion.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
        Me.CmbLocalidadInstitucion.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CmbLocalidadInstitucion.BackColor = System.Drawing.Color.FloralWhite
        Me.CmbLocalidadInstitucion.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CmbLocalidadInstitucion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmbLocalidadInstitucion.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbLocalidadInstitucion.ForeColor = System.Drawing.Color.Black
        Me.CmbLocalidadInstitucion.FormattingEnabled = True
        Me.CmbLocalidadInstitucion.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.CmbLocalidadInstitucion.Location = New System.Drawing.Point(127, 148)
        Me.CmbLocalidadInstitucion.Margin = New System.Windows.Forms.Padding(0)
        Me.CmbLocalidadInstitucion.Name = "CmbLocalidadInstitucion"
        Me.CmbLocalidadInstitucion.Size = New System.Drawing.Size(332, 24)
        Me.CmbLocalidadInstitucion.Sorted = True
        Me.CmbLocalidadInstitucion.TabIndex = 3
        '
        'TxtDireccion
        '
        Me.TxtDireccion.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtDireccion.BackColor = System.Drawing.Color.FloralWhite
        Me.TxtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtDireccion.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDireccion.ForeColor = System.Drawing.Color.Black
        Me.TxtDireccion.Location = New System.Drawing.Point(127, 105)
        Me.TxtDireccion.Name = "TxtDireccion"
        Me.TxtDireccion.Size = New System.Drawing.Size(332, 20)
        Me.TxtDireccion.TabIndex = 2
        Me.TxtDireccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel3
        '
        Me.Panel3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(127, 79)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(332, 1)
        Me.Panel3.TabIndex = 158
        '
        'Panel4
        '
        Me.Panel4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Panel4.Controls.Add(Me.Panel11)
        Me.Panel4.Controls.Add(Me.Panel10)
        Me.Panel4.Location = New System.Drawing.Point(127, 125)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(332, 1)
        Me.Panel4.TabIndex = 160
        '
        'Panel11
        '
        Me.Panel11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Panel11.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Panel11.Controls.Add(Me.Panel12)
        Me.Panel11.Location = New System.Drawing.Point(-47, 52)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(426, 1)
        Me.Panel11.TabIndex = 162
        '
        'Panel12
        '
        Me.Panel12.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Panel12.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Panel12.Location = New System.Drawing.Point(0, 51)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(426, 1)
        Me.Panel12.TabIndex = 161
        '
        'Panel10
        '
        Me.Panel10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Panel10.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Panel10.Location = New System.Drawing.Point(-47, 51)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(426, 1)
        Me.Panel10.TabIndex = 161
        '
        'Panel13
        '
        Me.Panel13.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel13.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Panel13.Controls.Add(Me.Panel14)
        Me.Panel13.Controls.Add(Me.Panel16)
        Me.Panel13.Location = New System.Drawing.Point(127, 171)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(332, 1)
        Me.Panel13.TabIndex = 160
        '
        'Panel14
        '
        Me.Panel14.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Panel14.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Panel14.Controls.Add(Me.Panel15)
        Me.Panel14.Location = New System.Drawing.Point(-47, 52)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(426, 1)
        Me.Panel14.TabIndex = 162
        '
        'Panel15
        '
        Me.Panel15.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Panel15.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Panel15.Location = New System.Drawing.Point(0, 51)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(426, 1)
        Me.Panel15.TabIndex = 161
        '
        'Panel16
        '
        Me.Panel16.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Panel16.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Panel16.Location = New System.Drawing.Point(-47, 51)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New System.Drawing.Size(426, 1)
        Me.Panel16.TabIndex = 161
        '
        'TxtMail
        '
        Me.TxtMail.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtMail.BackColor = System.Drawing.Color.FloralWhite
        Me.TxtMail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtMail.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMail.ForeColor = System.Drawing.Color.Black
        Me.TxtMail.Location = New System.Drawing.Point(127, 203)
        Me.TxtMail.Name = "TxtMail"
        Me.TxtMail.Size = New System.Drawing.Size(332, 20)
        Me.TxtMail.TabIndex = 8
        Me.TxtMail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel5
        '
        Me.Panel5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Panel5.Location = New System.Drawing.Point(127, 223)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(332, 1)
        Me.Panel5.TabIndex = 176
        '
        'lblNomInst
        '
        Me.lblNomInst.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblNomInst.AutoSize = True
        Me.lblNomInst.BackColor = System.Drawing.Color.Transparent
        Me.lblNomInst.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblNomInst.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.lblNomInst.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.lblNomInst.Location = New System.Drawing.Point(29, 60)
        Me.lblNomInst.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNomInst.Name = "lblNomInst"
        Me.lblNomInst.Size = New System.Drawing.Size(78, 20)
        Me.lblNomInst.TabIndex = 181
        Me.lblNomInst.Text = "Nombre *"
        Me.lblNomInst.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(29, 106)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 20)
        Me.Label6.TabIndex = 182
        Me.Label6.Text = "Dirección *"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.BtnCerrar)
        Me.Panel2.Controls.Add(Me.LbltitulofrmInstitucion)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(518, 43)
        Me.Panel2.TabIndex = 183
        '
        'BtnCerrar
        '
        Me.BtnCerrar.BackColor = System.Drawing.Color.FloralWhite
        Me.BtnCerrar.Dock = System.Windows.Forms.DockStyle.Left
        Me.BtnCerrar.FlatAppearance.BorderSize = 0
        Me.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCerrar.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!)
        Me.BtnCerrar.Image = CType(resources.GetObject("BtnCerrar.Image"), System.Drawing.Image)
        Me.BtnCerrar.Location = New System.Drawing.Point(0, 0)
        Me.BtnCerrar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(35, 43)
        Me.BtnCerrar.TabIndex = 70
        Me.BtnCerrar.UseVisualStyleBackColor = False
        '
        'LbltitulofrmInstitucion
        '
        Me.LbltitulofrmInstitucion.BackColor = System.Drawing.Color.FloralWhite
        Me.LbltitulofrmInstitucion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LbltitulofrmInstitucion.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbltitulofrmInstitucion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.LbltitulofrmInstitucion.Location = New System.Drawing.Point(0, 0)
        Me.LbltitulofrmInstitucion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LbltitulofrmInstitucion.Name = "LbltitulofrmInstitucion"
        Me.LbltitulofrmInstitucion.Size = New System.Drawing.Size(518, 43)
        Me.LbltitulofrmInstitucion.TabIndex = 71
        Me.LbltitulofrmInstitucion.Text = "Institución"
        Me.LbltitulofrmInstitucion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PnlInstitucion
        '
        Me.PnlInstitucion.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PnlInstitucion.BackColor = System.Drawing.Color.FloralWhite
        Me.PnlInstitucion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlInstitucion.Controls.Add(Me.dgvTelCelInst)
        Me.PnlInstitucion.Controls.Add(Me.Panel2)
        Me.PnlInstitucion.Controls.Add(Me.Label6)
        Me.PnlInstitucion.Controls.Add(Me.lblNomInst)
        Me.PnlInstitucion.Controls.Add(Me.Panel5)
        Me.PnlInstitucion.Controls.Add(Me.TxtMail)
        Me.PnlInstitucion.Controls.Add(Me.Panel13)
        Me.PnlInstitucion.Controls.Add(Me.Panel4)
        Me.PnlInstitucion.Controls.Add(Me.Panel3)
        Me.PnlInstitucion.Controls.Add(Me.TxtDireccion)
        Me.PnlInstitucion.Controls.Add(Me.CmbLocalidadInstitucion)
        Me.PnlInstitucion.Controls.Add(Me.TxtNombre)
        Me.PnlInstitucion.Controls.Add(Me.btnGuardar)
        Me.PnlInstitucion.Controls.Add(Me.btnAgregarTelCel)
        Me.PnlInstitucion.Controls.Add(Me.btnAgregarLocalidad)
        Me.PnlInstitucion.Controls.Add(Me.Label5)
        Me.PnlInstitucion.Controls.Add(Me.lblTelCel)
        Me.PnlInstitucion.Controls.Add(Me.Label2)
        Me.PnlInstitucion.Location = New System.Drawing.Point(5, 7)
        Me.PnlInstitucion.Name = "PnlInstitucion"
        Me.PnlInstitucion.Size = New System.Drawing.Size(520, 400)
        Me.PnlInstitucion.TabIndex = 156
        '
        'dgvTelCelInst
        '
        Me.dgvTelCelInst.BackgroundColor = System.Drawing.Color.FloralWhite
        Me.dgvTelCelInst.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTelCelInst.GridColor = System.Drawing.Color.Gray
        Me.dgvTelCelInst.Location = New System.Drawing.Point(127, 263)
        Me.dgvTelCelInst.Name = "dgvTelCelInst"
        Me.dgvTelCelInst.Size = New System.Drawing.Size(332, 21)
        Me.dgvTelCelInst.TabIndex = 240
        '
        'btnAgregarTelCel
        '
        Me.btnAgregarTelCel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAgregarTelCel.BackColor = System.Drawing.Color.Transparent
        Me.btnAgregarTelCel.FlatAppearance.BorderSize = 0
        Me.btnAgregarTelCel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarTelCel.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!)
        Me.btnAgregarTelCel.Image = CType(resources.GetObject("btnAgregarTelCel.Image"), System.Drawing.Image)
        Me.btnAgregarTelCel.Location = New System.Drawing.Point(466, 261)
        Me.btnAgregarTelCel.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAgregarTelCel.Name = "btnAgregarTelCel"
        Me.btnAgregarTelCel.Size = New System.Drawing.Size(26, 23)
        Me.btnAgregarTelCel.TabIndex = 166
        Me.btnAgregarTelCel.UseVisualStyleBackColor = False
        '
        'btnAgregarLocalidad
        '
        Me.btnAgregarLocalidad.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAgregarLocalidad.BackColor = System.Drawing.Color.Transparent
        Me.btnAgregarLocalidad.FlatAppearance.BorderSize = 0
        Me.btnAgregarLocalidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarLocalidad.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!)
        Me.btnAgregarLocalidad.Image = CType(resources.GetObject("btnAgregarLocalidad.Image"), System.Drawing.Image)
        Me.btnAgregarLocalidad.Location = New System.Drawing.Point(466, 149)
        Me.btnAgregarLocalidad.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAgregarLocalidad.Name = "btnAgregarLocalidad"
        Me.btnAgregarLocalidad.Size = New System.Drawing.Size(26, 23)
        Me.btnAgregarLocalidad.TabIndex = 166
        Me.btnAgregarLocalidad.UseVisualStyleBackColor = False
        '
        'FrmAgregarInst
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(530, 416)
        Me.Controls.Add(Me.PnlInstitucion)
        Me.Font = New System.Drawing.Font("Berlin Sans FB", 10.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmAgregarInst"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Panel4.ResumeLayout(False)
        Me.Panel11.ResumeLayout(False)
        Me.Panel13.ResumeLayout(False)
        Me.Panel14.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.PnlInstitucion.ResumeLayout(False)
        Me.PnlInstitucion.PerformLayout()
        CType(Me.dgvTelCelInst, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2HtmlLabel8 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Label2 As Label
    Friend WithEvents lblTelCel As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnAgregarLocalidad As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents CmbLocalidadInstitucion As ComboBox
    Friend WithEvents TxtDireccion As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Panel12 As Panel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Panel13 As Panel
    Friend WithEvents Panel14 As Panel
    Friend WithEvents Panel15 As Panel
    Friend WithEvents Panel16 As Panel
    Friend WithEvents TxtMail As TextBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents lblNomInst As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BtnCerrar As Button
    Friend WithEvents LbltitulofrmInstitucion As Label
    Friend WithEvents PnlInstitucion As Panel
    Friend WithEvents btnAgregarTelCel As Button
    Friend WithEvents dgvTelCelInst As DataGridView
End Class
