<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmTomarAsistencia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTomarAsistencia))
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.LblCarrera = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.LblAño = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.BtnTemas = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnInforme = New Guna.UI2.WinForms.Guna2Button()
        Me.LblFecha = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.LblInstitucion = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.BtnCancelar = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2DataGridView1 = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.BtnAceptar = New Guna.UI2.WinForms.Guna2Button()
        Me.PnlRecuadro1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2GroupBox1.SuspendLayout()
        CType(Me.Guna2DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlRecuadro1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.Controls.Add(Me.PnlRecuadro1)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Guna2GroupBox1.Controls.Add(Me.LblCarrera)
        Me.Guna2GroupBox1.Controls.Add(Me.LblAño)
        Me.Guna2GroupBox1.Controls.Add(Me.BtnTemas)
        Me.Guna2GroupBox1.Controls.Add(Me.BtnInforme)
        Me.Guna2GroupBox1.Controls.Add(Me.LblFecha)
        Me.Guna2GroupBox1.Controls.Add(Me.LblInstitucion)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.MediumAquamarine
        Me.Guna2GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2GroupBox1.FillColor = System.Drawing.Color.LightGray
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Berlin Sans FB", 18.0!)
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.ShadowDecoration.Parent = Me.Guna2GroupBox1
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(895, 512)
        Me.Guna2GroupBox1.TabIndex = 0
        Me.Guna2GroupBox1.Text = "Tomar asistencia"
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(802, 232)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(58, 20)
        Me.Guna2HtmlLabel2.TabIndex = 34
        Me.Guna2HtmlLabel2.Text = "Informes"
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(781, 125)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(101, 20)
        Me.Guna2HtmlLabel1.TabIndex = 33
        Me.Guna2HtmlLabel1.Text = "Libro de temas"
        '
        'LblCarrera
        '
        Me.LblCarrera.BackColor = System.Drawing.Color.Transparent
        Me.LblCarrera.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCarrera.ForeColor = System.Drawing.Color.Black
        Me.LblCarrera.Location = New System.Drawing.Point(555, 10)
        Me.LblCarrera.Name = "LblCarrera"
        Me.LblCarrera.Size = New System.Drawing.Size(57, 20)
        Me.LblCarrera.TabIndex = 31
        Me.LblCarrera.Text = "Carrera:"
        '
        'LblAño
        '
        Me.LblAño.BackColor = System.Drawing.Color.Transparent
        Me.LblAño.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAño.ForeColor = System.Drawing.Color.Black
        Me.LblAño.Location = New System.Drawing.Point(749, 10)
        Me.LblAño.Name = "LblAño"
        Me.LblAño.Size = New System.Drawing.Size(34, 20)
        Me.LblAño.TabIndex = 32
        Me.LblAño.Text = "Año:"
        '
        'BtnTemas
        '
        Me.BtnTemas.BackColor = System.Drawing.Color.Transparent
        Me.BtnTemas.BackgroundImage = CType(resources.GetObject("BtnTemas.BackgroundImage"), System.Drawing.Image)
        Me.BtnTemas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnTemas.BorderRadius = 1
        Me.BtnTemas.BorderThickness = 1
        Me.BtnTemas.CheckedState.Parent = Me.BtnTemas
        Me.BtnTemas.CustomImages.Parent = Me.BtnTemas
        Me.BtnTemas.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnTemas.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnTemas.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnTemas.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnTemas.DisabledState.Parent = Me.BtnTemas
        Me.BtnTemas.FillColor = System.Drawing.Color.Transparent
        Me.BtnTemas.Font = New System.Drawing.Font("Berlin Sans FB", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTemas.ForeColor = System.Drawing.Color.Black
        Me.BtnTemas.HoverState.Parent = Me.BtnTemas
        Me.BtnTemas.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BtnTemas.Location = New System.Drawing.Point(800, 59)
        Me.BtnTemas.Name = "BtnTemas"
        Me.BtnTemas.ShadowDecoration.Parent = Me.BtnTemas
        Me.BtnTemas.Size = New System.Drawing.Size(60, 60)
        Me.BtnTemas.TabIndex = 24
        '
        'BtnInforme
        '
        Me.BtnInforme.BackgroundImage = CType(resources.GetObject("BtnInforme.BackgroundImage"), System.Drawing.Image)
        Me.BtnInforme.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnInforme.BorderRadius = 1
        Me.BtnInforme.BorderThickness = 1
        Me.BtnInforme.CheckedState.Parent = Me.BtnInforme
        Me.BtnInforme.CustomImages.Parent = Me.BtnInforme
        Me.BtnInforme.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnInforme.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnInforme.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnInforme.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnInforme.DisabledState.Parent = Me.BtnInforme
        Me.BtnInforme.FillColor = System.Drawing.Color.Transparent
        Me.BtnInforme.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!)
        Me.BtnInforme.ForeColor = System.Drawing.Color.Black
        Me.BtnInforme.HoverState.Parent = Me.BtnInforme
        Me.BtnInforme.Location = New System.Drawing.Point(800, 166)
        Me.BtnInforme.Name = "BtnInforme"
        Me.BtnInforme.ShadowDecoration.Parent = Me.BtnInforme
        Me.BtnInforme.Size = New System.Drawing.Size(60, 60)
        Me.BtnInforme.TabIndex = 25
        '
        'LblFecha
        '
        Me.LblFecha.BackColor = System.Drawing.Color.Transparent
        Me.LblFecha.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFecha.ForeColor = System.Drawing.Color.Black
        Me.LblFecha.Location = New System.Drawing.Point(246, 10)
        Me.LblFecha.Name = "LblFecha"
        Me.LblFecha.Size = New System.Drawing.Size(47, 20)
        Me.LblFecha.TabIndex = 29
        Me.LblFecha.Text = "Fecha:"
        '
        'LblInstitucion
        '
        Me.LblInstitucion.BackColor = System.Drawing.Color.Transparent
        Me.LblInstitucion.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblInstitucion.ForeColor = System.Drawing.Color.Black
        Me.LblInstitucion.Location = New System.Drawing.Point(345, 10)
        Me.LblInstitucion.Name = "LblInstitucion"
        Me.LblInstitucion.Size = New System.Drawing.Size(69, 20)
        Me.LblInstitucion.TabIndex = 30
        Me.LblInstitucion.Text = "Institución:"
        '
        'BtnCancelar
        '
        Me.BtnCancelar.CheckedState.Parent = Me.BtnCancelar
        Me.BtnCancelar.CustomImages.Parent = Me.BtnCancelar
        Me.BtnCancelar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnCancelar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnCancelar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnCancelar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnCancelar.DisabledState.Parent = Me.BtnCancelar
        Me.BtnCancelar.FillColor = System.Drawing.Color.MediumAquamarine
        Me.BtnCancelar.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.ForeColor = System.Drawing.Color.White
        Me.BtnCancelar.HoverState.Parent = Me.BtnCancelar
        Me.BtnCancelar.Location = New System.Drawing.Point(516, 403)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.ShadowDecoration.Parent = Me.BtnCancelar
        Me.BtnCancelar.Size = New System.Drawing.Size(100, 35)
        Me.BtnCancelar.TabIndex = 28
        Me.BtnCancelar.Text = "Cancelar"
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
        Me.Guna2DataGridView1.Location = New System.Drawing.Point(16, 11)
        Me.Guna2DataGridView1.Name = "Guna2DataGridView1"
        Me.Guna2DataGridView1.RowHeadersVisible = False
        Me.Guna2DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Guna2DataGridView1.Size = New System.Drawing.Size(727, 386)
        Me.Guna2DataGridView1.TabIndex = 26
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
        'BtnAceptar
        '
        Me.BtnAceptar.CheckedState.Parent = Me.BtnAceptar
        Me.BtnAceptar.CustomImages.Parent = Me.BtnAceptar
        Me.BtnAceptar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnAceptar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnAceptar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnAceptar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnAceptar.DisabledState.Parent = Me.BtnAceptar
        Me.BtnAceptar.FillColor = System.Drawing.Color.MediumAquamarine
        Me.BtnAceptar.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAceptar.ForeColor = System.Drawing.Color.White
        Me.BtnAceptar.HoverState.Parent = Me.BtnAceptar
        Me.BtnAceptar.Location = New System.Drawing.Point(643, 403)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.ShadowDecoration.Parent = Me.BtnAceptar
        Me.BtnAceptar.Size = New System.Drawing.Size(100, 35)
        Me.BtnAceptar.TabIndex = 27
        Me.BtnAceptar.Text = "Aceptar"
        '
        'PnlRecuadro1
        '
        Me.PnlRecuadro1.BackgroundImage = CType(resources.GetObject("PnlRecuadro1.BackgroundImage"), System.Drawing.Image)
        Me.PnlRecuadro1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PnlRecuadro1.Controls.Add(Me.BtnCancelar)
        Me.PnlRecuadro1.Controls.Add(Me.Guna2DataGridView1)
        Me.PnlRecuadro1.Controls.Add(Me.BtnAceptar)
        Me.PnlRecuadro1.Location = New System.Drawing.Point(9, 48)
        Me.PnlRecuadro1.Name = "PnlRecuadro1"
        Me.PnlRecuadro1.ShadowDecoration.Parent = Me.PnlRecuadro1
        Me.PnlRecuadro1.Size = New System.Drawing.Size(760, 452)
        Me.PnlRecuadro1.TabIndex = 35
        '
        'FrmTomarAsistencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(895, 512)
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "FrmTomarAsistencia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox1.PerformLayout()
        CType(Me.Guna2DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlRecuadro1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents LblCarrera As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents LblAño As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents LblFecha As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents LblInstitucion As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents BtnCancelar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2DataGridView1 As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents BtnAceptar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnTemas As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnInforme As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents PnlRecuadro1 As Guna.UI2.WinForms.Guna2Panel
End Class
