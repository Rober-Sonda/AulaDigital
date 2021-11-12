<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEventos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEventos))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.PnlBotones = New Guna.UI2.WinForms.Guna2Panel()
        Me.BtnCerrar = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnMaximizar = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnMinimizar = New Guna.UI2.WinForms.Guna2Button()
        Me.PnlRecuadro1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2DataGridView1 = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.LblBuscar = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.BtnBuscar = New Guna.UI2.WinForms.Guna2Button()
        Me.TxtBuscar = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2GroupBox1.SuspendLayout()
        Me.PnlBotones.SuspendLayout()
        Me.PnlRecuadro1.SuspendLayout()
        CType(Me.Guna2DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.BorderRadius = 2
        Me.Guna2GroupBox1.Controls.Add(Me.PnlBotones)
        Me.Guna2GroupBox1.Controls.Add(Me.PnlRecuadro1)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.MediumAquamarine
        Me.Guna2GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2GroupBox1.FillColor = System.Drawing.Color.LightGray
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Berlin Sans FB", 18.0!)
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.ShadowDecoration.Parent = Me.Guna2GroupBox1
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(868, 470)
        Me.Guna2GroupBox1.TabIndex = 2
        Me.Guna2GroupBox1.Text = "Resumen de calendario"
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
        'PnlRecuadro1
        '
        Me.PnlRecuadro1.BackgroundImage = CType(resources.GetObject("PnlRecuadro1.BackgroundImage"), System.Drawing.Image)
        Me.PnlRecuadro1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PnlRecuadro1.Controls.Add(Me.LblBuscar)
        Me.PnlRecuadro1.Controls.Add(Me.Guna2DataGridView1)
        Me.PnlRecuadro1.Controls.Add(Me.BtnBuscar)
        Me.PnlRecuadro1.Controls.Add(Me.TxtBuscar)
        Me.PnlRecuadro1.Location = New System.Drawing.Point(6, 52)
        Me.PnlRecuadro1.Name = "PnlRecuadro1"
        Me.PnlRecuadro1.ShadowDecoration.Parent = Me.PnlRecuadro1
        Me.PnlRecuadro1.Size = New System.Drawing.Size(800, 414)
        Me.PnlRecuadro1.TabIndex = 24
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
        Me.Guna2DataGridView1.Location = New System.Drawing.Point(20, 78)
        Me.Guna2DataGridView1.Name = "Guna2DataGridView1"
        Me.Guna2DataGridView1.RowHeadersVisible = False
        Me.Guna2DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Guna2DataGridView1.Size = New System.Drawing.Size(757, 315)
        Me.Guna2DataGridView1.TabIndex = 2
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
        'LblBuscar
        '
        Me.LblBuscar.BackColor = System.Drawing.Color.White
        Me.LblBuscar.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBuscar.ForeColor = System.Drawing.Color.MediumAquamarine
        Me.LblBuscar.Location = New System.Drawing.Point(30, 29)
        Me.LblBuscar.Name = "LblBuscar"
        Me.LblBuscar.Size = New System.Drawing.Size(59, 22)
        Me.LblBuscar.TabIndex = 17
        Me.LblBuscar.Text = "Buscar:"
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
        Me.BtnBuscar.Location = New System.Drawing.Point(426, 25)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.ShadowDecoration.Parent = Me.BtnBuscar
        Me.BtnBuscar.Size = New System.Drawing.Size(30, 30)
        Me.BtnBuscar.TabIndex = 16
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
        Me.TxtBuscar.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtBuscar.HoverState.Parent = Me.TxtBuscar
        Me.TxtBuscar.Location = New System.Drawing.Point(106, 25)
        Me.TxtBuscar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtBuscar.PlaceholderText = ""
        Me.TxtBuscar.SelectedText = ""
        Me.TxtBuscar.ShadowDecoration.Parent = Me.TxtBuscar
        Me.TxtBuscar.Size = New System.Drawing.Size(300, 30)
        Me.TxtBuscar.TabIndex = 15
        '
        'FrmEventos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(868, 470)
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmEventos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.PnlBotones.ResumeLayout(False)
        Me.PnlRecuadro1.ResumeLayout(False)
        Me.PnlRecuadro1.PerformLayout()
        CType(Me.Guna2DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents PnlBotones As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents BtnCerrar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnMaximizar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnMinimizar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PnlRecuadro1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2DataGridView1 As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents LblBuscar As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents BtnBuscar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TxtBuscar As Guna.UI2.WinForms.Guna2TextBox
End Class
