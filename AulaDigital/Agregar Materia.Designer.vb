<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAgregarMateria
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAgregarMateria))
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.PnlRecuadro2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.TxtBuscar = New Guna.UI2.WinForms.Guna2TextBox()
        Me.BtnBuscar = New Guna.UI2.WinForms.Guna2Button()
        Me.LblLista = New System.Windows.Forms.Label()
        Me.Guna2DataGridView1 = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.BtnEliminarFecha = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnAgregar = New Guna.UI2.WinForms.Guna2Button()
        Me.CbxFecha = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.CbxAnio = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.CbxNombre = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.TxtHasta = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TxtDesde = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel6 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.PnlRecuadro1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.BtnEliminar = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2HtmlLabel9 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.BtnEditar = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnDescartar = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2HtmlLabel11 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.BtnGuardar = New Guna.UI2.WinForms.Guna2Button()
        Me.PnlBotones = New Guna.UI2.WinForms.Guna2Panel()
        Me.BtnCerrar = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnMaximizar = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnMinimizar = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2GroupBox1.SuspendLayout()
        Me.PnlRecuadro2.SuspendLayout()
        CType(Me.Guna2DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlRecuadro1.SuspendLayout()
        Me.PnlBotones.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.Controls.Add(Me.PnlBotones)
        Me.Guna2GroupBox1.Controls.Add(Me.PnlRecuadro2)
        Me.Guna2GroupBox1.Controls.Add(Me.BtnEliminarFecha)
        Me.Guna2GroupBox1.Controls.Add(Me.BtnAgregar)
        Me.Guna2GroupBox1.Controls.Add(Me.CbxFecha)
        Me.Guna2GroupBox1.Controls.Add(Me.CbxAnio)
        Me.Guna2GroupBox1.Controls.Add(Me.CbxNombre)
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
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(1092, 512)
        Me.Guna2GroupBox1.TabIndex = 1
        Me.Guna2GroupBox1.Text = "Materia"
        '
        'PnlRecuadro2
        '
        Me.PnlRecuadro2.BackgroundImage = CType(resources.GetObject("PnlRecuadro2.BackgroundImage"), System.Drawing.Image)
        Me.PnlRecuadro2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PnlRecuadro2.Controls.Add(Me.TxtBuscar)
        Me.PnlRecuadro2.Controls.Add(Me.BtnBuscar)
        Me.PnlRecuadro2.Controls.Add(Me.LblLista)
        Me.PnlRecuadro2.Controls.Add(Me.Guna2DataGridView1)
        Me.PnlRecuadro2.Location = New System.Drawing.Point(722, 47)
        Me.PnlRecuadro2.Name = "PnlRecuadro2"
        Me.PnlRecuadro2.ShadowDecoration.Parent = Me.PnlRecuadro2
        Me.PnlRecuadro2.Size = New System.Drawing.Size(318, 451)
        Me.PnlRecuadro2.TabIndex = 25
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
        Me.LblLista.Size = New System.Drawing.Size(79, 21)
        Me.LblLista.TabIndex = 21
        Me.LblLista.Text = "Materias"
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
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Berlin Sans FB", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Guna2DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Guna2DataGridView1.ColumnHeadersHeight = 4
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Berlin Sans FB", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        'BtnEliminarFecha
        '
        Me.BtnEliminarFecha.BackgroundImage = CType(resources.GetObject("BtnEliminarFecha.BackgroundImage"), System.Drawing.Image)
        Me.BtnEliminarFecha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnEliminarFecha.CheckedState.Parent = Me.BtnEliminarFecha
        Me.BtnEliminarFecha.CustomImages.Parent = Me.BtnEliminarFecha
        Me.BtnEliminarFecha.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnEliminarFecha.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnEliminarFecha.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnEliminarFecha.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnEliminarFecha.DisabledState.Parent = Me.BtnEliminarFecha
        Me.BtnEliminarFecha.FillColor = System.Drawing.Color.Transparent
        Me.BtnEliminarFecha.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnEliminarFecha.ForeColor = System.Drawing.Color.White
        Me.BtnEliminarFecha.HoverState.Parent = Me.BtnEliminarFecha
        Me.BtnEliminarFecha.Location = New System.Drawing.Point(652, 314)
        Me.BtnEliminarFecha.Name = "BtnEliminarFecha"
        Me.BtnEliminarFecha.ShadowDecoration.Parent = Me.BtnEliminarFecha
        Me.BtnEliminarFecha.Size = New System.Drawing.Size(30, 30)
        Me.BtnEliminarFecha.TabIndex = 15
        '
        'BtnAgregar
        '
        Me.BtnAgregar.BackgroundImage = CType(resources.GetObject("BtnAgregar.BackgroundImage"), System.Drawing.Image)
        Me.BtnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnAgregar.CheckedState.Parent = Me.BtnAgregar
        Me.BtnAgregar.CustomImages.Parent = Me.BtnAgregar
        Me.BtnAgregar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnAgregar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnAgregar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnAgregar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnAgregar.DisabledState.Parent = Me.BtnAgregar
        Me.BtnAgregar.FillColor = System.Drawing.Color.Transparent
        Me.BtnAgregar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnAgregar.ForeColor = System.Drawing.Color.White
        Me.BtnAgregar.HoverState.Parent = Me.BtnAgregar
        Me.BtnAgregar.Location = New System.Drawing.Point(616, 314)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.ShadowDecoration.Parent = Me.BtnAgregar
        Me.BtnAgregar.Size = New System.Drawing.Size(30, 30)
        Me.BtnAgregar.TabIndex = 14
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
        Me.CbxFecha.Location = New System.Drawing.Point(91, 309)
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
        Me.CbxAnio.Location = New System.Drawing.Point(120, 182)
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
        Me.CbxNombre.Location = New System.Drawing.Point(120, 108)
        Me.CbxNombre.Name = "CbxNombre"
        Me.CbxNombre.ShadowDecoration.Parent = Me.CbxNombre
        Me.CbxNombre.Size = New System.Drawing.Size(175, 36)
        Me.CbxNombre.TabIndex = 10
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
        Me.TxtHasta.Location = New System.Drawing.Point(469, 314)
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
        Me.TxtDesde.Location = New System.Drawing.Point(280, 314)
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
        Me.Guna2HtmlLabel6.Location = New System.Drawing.Point(421, 319)
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
        Me.Guna2HtmlLabel5.Location = New System.Drawing.Point(230, 319)
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
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(39, 315)
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
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(15, 259)
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
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(39, 188)
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
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(39, 114)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(57, 20)
        Me.Guna2HtmlLabel1.TabIndex = 0
        Me.Guna2HtmlLabel1.Text = "Nombre"
        '
        'PnlRecuadro1
        '
        Me.PnlRecuadro1.BackgroundImage = CType(resources.GetObject("PnlRecuadro1.BackgroundImage"), System.Drawing.Image)
        Me.PnlRecuadro1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PnlRecuadro1.Controls.Add(Me.BtnEliminar)
        Me.PnlRecuadro1.Controls.Add(Me.Guna2HtmlLabel9)
        Me.PnlRecuadro1.Controls.Add(Me.BtnEditar)
        Me.PnlRecuadro1.Controls.Add(Me.BtnDescartar)
        Me.PnlRecuadro1.Controls.Add(Me.Guna2HtmlLabel11)
        Me.PnlRecuadro1.Controls.Add(Me.BtnGuardar)
        Me.PnlRecuadro1.Location = New System.Drawing.Point(9, 47)
        Me.PnlRecuadro1.Name = "PnlRecuadro1"
        Me.PnlRecuadro1.ShadowDecoration.Parent = Me.PnlRecuadro1
        Me.PnlRecuadro1.Size = New System.Drawing.Size(710, 453)
        Me.PnlRecuadro1.TabIndex = 24
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
        Me.BtnEliminar.Location = New System.Drawing.Point(646, 94)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.ShadowDecoration.Parent = Me.BtnEliminar
        Me.BtnEliminar.Size = New System.Drawing.Size(30, 30)
        Me.BtnEliminar.TabIndex = 28
        '
        'Guna2HtmlLabel9
        '
        Me.Guna2HtmlLabel9.BackColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel9.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel9.ForeColor = System.Drawing.Color.MediumAquamarine
        Me.Guna2HtmlLabel9.Location = New System.Drawing.Point(10, 12)
        Me.Guna2HtmlLabel9.Name = "Guna2HtmlLabel9"
        Me.Guna2HtmlLabel9.Size = New System.Drawing.Size(111, 20)
        Me.Guna2HtmlLabel9.TabIndex = 27
        Me.Guna2HtmlLabel9.Text = "Agregar Materia"
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
        Me.BtnEditar.Location = New System.Drawing.Point(646, 57)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.ShadowDecoration.Parent = Me.BtnEditar
        Me.BtnEditar.Size = New System.Drawing.Size(30, 30)
        Me.BtnEditar.TabIndex = 27
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
        Me.BtnDescartar.Location = New System.Drawing.Point(460, 398)
        Me.BtnDescartar.Name = "BtnDescartar"
        Me.BtnDescartar.ShadowDecoration.Parent = Me.BtnDescartar
        Me.BtnDescartar.Size = New System.Drawing.Size(110, 35)
        Me.BtnDescartar.TabIndex = 26
        Me.BtnDescartar.Text = "Descartar"
        '
        'Guna2HtmlLabel11
        '
        Me.Guna2HtmlLabel11.BackColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel11.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel11.ForeColor = System.Drawing.Color.MediumAquamarine
        Me.Guna2HtmlLabel11.Location = New System.Drawing.Point(126, 12)
        Me.Guna2HtmlLabel11.Name = "Guna2HtmlLabel11"
        Me.Guna2HtmlLabel11.Size = New System.Drawing.Size(101, 20)
        Me.Guna2HtmlLabel11.TabIndex = 11
        Me.Guna2HtmlLabel11.Text = "/  Ver existentes"
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
        Me.BtnGuardar.Location = New System.Drawing.Point(576, 398)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.ShadowDecoration.Parent = Me.BtnGuardar
        Me.BtnGuardar.Size = New System.Drawing.Size(100, 35)
        Me.BtnGuardar.TabIndex = 9
        Me.BtnGuardar.Text = "Guardar"
        '
        'PnlBotones
        '
        Me.PnlBotones.BackColor = System.Drawing.Color.Transparent
        Me.PnlBotones.Controls.Add(Me.BtnCerrar)
        Me.PnlBotones.Controls.Add(Me.BtnMaximizar)
        Me.PnlBotones.Controls.Add(Me.BtnMinimizar)
        Me.PnlBotones.Location = New System.Drawing.Point(992, 3)
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
        'FrmAgregarMateria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1092, 512)
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.Name = "FrmAgregarMateria"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Agregar_Materia"
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox1.PerformLayout()
        Me.PnlRecuadro2.ResumeLayout(False)
        Me.PnlRecuadro2.PerformLayout()
        CType(Me.Guna2DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlRecuadro1.ResumeLayout(False)
        Me.PnlRecuadro1.PerformLayout()
        Me.PnlBotones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents BtnEliminarFecha As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnAgregar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents CbxFecha As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents CbxAnio As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents CbxNombre As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents TxtHasta As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TxtDesde As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel6 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents PnlRecuadro1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents BtnDescartar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnGuardar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2HtmlLabel11 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel9 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents PnlRecuadro2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents TxtBuscar As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BtnBuscar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents LblLista As Label
    Friend WithEvents Guna2DataGridView1 As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents BtnEliminar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnEditar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PnlBotones As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents BtnCerrar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnMaximizar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnMinimizar As Guna.UI2.WinForms.Guna2Button
End Class
