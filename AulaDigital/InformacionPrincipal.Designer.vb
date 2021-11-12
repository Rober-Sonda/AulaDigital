<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmInformacion
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmInformacion))
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.Guna2DataGridView1 = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.PnlRecuadro1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.BtnBloquear = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnModificar = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnAsistencia = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnNuevo = New Guna.UI2.WinForms.Guna2Button()
        Me.PnlBotones = New Guna.UI2.WinForms.Guna2Panel()
        Me.BtnCerrar = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnMaximizar = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnMinimizar = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2GroupBox1.SuspendLayout()
        CType(Me.Guna2DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlBotones.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.Controls.Add(Me.PnlBotones)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2DataGridView1)
        Me.Guna2GroupBox1.Controls.Add(Me.PnlRecuadro1)
        Me.Guna2GroupBox1.Controls.Add(Me.BtnBloquear)
        Me.Guna2GroupBox1.Controls.Add(Me.BtnModificar)
        Me.Guna2GroupBox1.Controls.Add(Me.BtnAsistencia)
        Me.Guna2GroupBox1.Controls.Add(Me.BtnNuevo)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.MediumAquamarine
        Me.Guna2GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2GroupBox1.FillColor = System.Drawing.Color.LightGray
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Berlin Sans FB", 18.0!)
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.ShadowDecoration.Parent = Me.Guna2GroupBox1
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(868, 478)
        Me.Guna2GroupBox1.TabIndex = 0
        Me.Guna2GroupBox1.Text = "Informacíon principal"
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
        Me.Guna2DataGridView1.Location = New System.Drawing.Point(49, 74)
        Me.Guna2DataGridView1.Name = "Guna2DataGridView1"
        Me.Guna2DataGridView1.RowHeadersVisible = False
        Me.Guna2DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Guna2DataGridView1.Size = New System.Drawing.Size(671, 377)
        Me.Guna2DataGridView1.TabIndex = 9
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
        'PnlRecuadro1
        '
        Me.PnlRecuadro1.BackgroundImage = CType(resources.GetObject("PnlRecuadro1.BackgroundImage"), System.Drawing.Image)
        Me.PnlRecuadro1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PnlRecuadro1.Location = New System.Drawing.Point(7, 49)
        Me.PnlRecuadro1.Name = "PnlRecuadro1"
        Me.PnlRecuadro1.ShadowDecoration.Parent = Me.PnlRecuadro1
        Me.PnlRecuadro1.Size = New System.Drawing.Size(760, 424)
        Me.PnlRecuadro1.TabIndex = 26
        '
        'BtnBloquear
        '
        Me.BtnBloquear.BackgroundImage = CType(resources.GetObject("BtnBloquear.BackgroundImage"), System.Drawing.Image)
        Me.BtnBloquear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnBloquear.BorderRadius = 1
        Me.BtnBloquear.BorderThickness = 1
        Me.BtnBloquear.CheckedState.Parent = Me.BtnBloquear
        Me.BtnBloquear.CustomImages.Parent = Me.BtnBloquear
        Me.BtnBloquear.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnBloquear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnBloquear.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnBloquear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnBloquear.DisabledState.Parent = Me.BtnBloquear
        Me.BtnBloquear.FillColor = System.Drawing.Color.Transparent
        Me.BtnBloquear.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnBloquear.ForeColor = System.Drawing.Color.Black
        Me.BtnBloquear.HoverState.Parent = Me.BtnBloquear
        Me.BtnBloquear.Location = New System.Drawing.Point(798, 322)
        Me.BtnBloquear.Name = "BtnBloquear"
        Me.BtnBloquear.ShadowDecoration.Parent = Me.BtnBloquear
        Me.BtnBloquear.Size = New System.Drawing.Size(40, 40)
        Me.BtnBloquear.TabIndex = 8
        '
        'BtnModificar
        '
        Me.BtnModificar.BackgroundImage = CType(resources.GetObject("BtnModificar.BackgroundImage"), System.Drawing.Image)
        Me.BtnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnModificar.BorderRadius = 1
        Me.BtnModificar.BorderThickness = 1
        Me.BtnModificar.CheckedState.Parent = Me.BtnModificar
        Me.BtnModificar.CustomImages.Parent = Me.BtnModificar
        Me.BtnModificar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnModificar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnModificar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnModificar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnModificar.DisabledState.Parent = Me.BtnModificar
        Me.BtnModificar.FillColor = System.Drawing.Color.Transparent
        Me.BtnModificar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnModificar.ForeColor = System.Drawing.Color.Black
        Me.BtnModificar.HoverState.Parent = Me.BtnModificar
        Me.BtnModificar.Location = New System.Drawing.Point(798, 265)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.ShadowDecoration.Parent = Me.BtnModificar
        Me.BtnModificar.Size = New System.Drawing.Size(40, 40)
        Me.BtnModificar.TabIndex = 7
        '
        'BtnAsistencia
        '
        Me.BtnAsistencia.BackColor = System.Drawing.Color.Transparent
        Me.BtnAsistencia.BackgroundImage = CType(resources.GetObject("BtnAsistencia.BackgroundImage"), System.Drawing.Image)
        Me.BtnAsistencia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnAsistencia.BorderRadius = 1
        Me.BtnAsistencia.BorderThickness = 1
        Me.BtnAsistencia.CheckedState.Parent = Me.BtnAsistencia
        Me.BtnAsistencia.CustomImages.Parent = Me.BtnAsistencia
        Me.BtnAsistencia.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnAsistencia.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnAsistencia.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnAsistencia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnAsistencia.DisabledState.Parent = Me.BtnAsistencia
        Me.BtnAsistencia.FillColor = System.Drawing.Color.Transparent
        Me.BtnAsistencia.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnAsistencia.ForeColor = System.Drawing.Color.Black
        Me.BtnAsistencia.HoverState.Parent = Me.BtnAsistencia
        Me.BtnAsistencia.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BtnAsistencia.Location = New System.Drawing.Point(798, 151)
        Me.BtnAsistencia.Name = "BtnAsistencia"
        Me.BtnAsistencia.ShadowDecoration.Parent = Me.BtnAsistencia
        Me.BtnAsistencia.Size = New System.Drawing.Size(40, 40)
        Me.BtnAsistencia.TabIndex = 5
        '
        'BtnNuevo
        '
        Me.BtnNuevo.BackgroundImage = CType(resources.GetObject("BtnNuevo.BackgroundImage"), System.Drawing.Image)
        Me.BtnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnNuevo.BorderRadius = 1
        Me.BtnNuevo.BorderThickness = 1
        Me.BtnNuevo.CheckedState.Parent = Me.BtnNuevo
        Me.BtnNuevo.CustomImages.Parent = Me.BtnNuevo
        Me.BtnNuevo.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnNuevo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnNuevo.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnNuevo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnNuevo.DisabledState.Parent = Me.BtnNuevo
        Me.BtnNuevo.FillColor = System.Drawing.Color.Transparent
        Me.BtnNuevo.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnNuevo.ForeColor = System.Drawing.Color.Black
        Me.BtnNuevo.HoverState.Parent = Me.BtnNuevo
        Me.BtnNuevo.Location = New System.Drawing.Point(798, 208)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.ShadowDecoration.Parent = Me.BtnNuevo
        Me.BtnNuevo.Size = New System.Drawing.Size(40, 40)
        Me.BtnNuevo.TabIndex = 6
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
        'FrmInformacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(868, 478)
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmInformacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Guna2GroupBox1.ResumeLayout(False)
        CType(Me.Guna2DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlBotones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Guna2DataGridView1 As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents BtnBloquear As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnModificar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnAsistencia As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnNuevo As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PnlRecuadro1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents PnlBotones As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents BtnCerrar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnMaximizar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnMinimizar As Guna.UI2.WinForms.Guna2Button
End Class
