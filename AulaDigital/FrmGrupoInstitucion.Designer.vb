<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmGrupoInst
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmGrupoInst))
        Me.PnlCurso = New System.Windows.Forms.Panel()
        Me.dgvMateria = New System.Windows.Forms.DataGridView()
        Me.dgvCarrera = New System.Windows.Forms.DataGridView()
        Me.dgvInst = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCrearClase = New System.Windows.Forms.Button()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.Db_Dataset_AulaDigital1 = New AulaDigital.db_Dataset_AulaDigital()
        Me.btnAgregarMateria = New System.Windows.Forms.Button()
        Me.btnAgregarCarrera = New System.Windows.Forms.Button()
        Me.btnAgregarInst = New System.Windows.Forms.Button()
        Me.BtnDescartar = New System.Windows.Forms.Button()
        Me.PnlCurso.SuspendLayout()
        CType(Me.dgvMateria, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCarrera, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvInst, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel12.SuspendLayout()
        CType(Me.Db_Dataset_AulaDigital1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PnlCurso
        '
        Me.PnlCurso.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PnlCurso.BackColor = System.Drawing.Color.FloralWhite
        Me.PnlCurso.Controls.Add(Me.dgvMateria)
        Me.PnlCurso.Controls.Add(Me.dgvCarrera)
        Me.PnlCurso.Controls.Add(Me.dgvInst)
        Me.PnlCurso.Controls.Add(Me.Label3)
        Me.PnlCurso.Controls.Add(Me.Label1)
        Me.PnlCurso.Controls.Add(Me.Label2)
        Me.PnlCurso.Controls.Add(Me.btnCrearClase)
        Me.PnlCurso.Controls.Add(Me.btnAgregarMateria)
        Me.PnlCurso.Controls.Add(Me.btnAgregarCarrera)
        Me.PnlCurso.Controls.Add(Me.btnAgregarInst)
        Me.PnlCurso.Controls.Add(Me.Panel12)
        Me.PnlCurso.Location = New System.Drawing.Point(21, 46)
        Me.PnlCurso.Margin = New System.Windows.Forms.Padding(0)
        Me.PnlCurso.Name = "PnlCurso"
        Me.PnlCurso.Size = New System.Drawing.Size(770, 435)
        Me.PnlCurso.TabIndex = 191
        '
        'dgvMateria
        '
        Me.dgvMateria.BackgroundColor = System.Drawing.Color.Gray
        Me.dgvMateria.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvMateria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMateria.Location = New System.Drawing.Point(515, 95)
        Me.dgvMateria.Name = "dgvMateria"
        Me.dgvMateria.Size = New System.Drawing.Size(229, 251)
        Me.dgvMateria.TabIndex = 239
        '
        'dgvCarrera
        '
        Me.dgvCarrera.BackgroundColor = System.Drawing.Color.Gray
        Me.dgvCarrera.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvCarrera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCarrera.Location = New System.Drawing.Point(269, 95)
        Me.dgvCarrera.Name = "dgvCarrera"
        Me.dgvCarrera.Size = New System.Drawing.Size(229, 251)
        Me.dgvCarrera.TabIndex = 238
        '
        'dgvInst
        '
        Me.dgvInst.BackgroundColor = System.Drawing.Color.Gray
        Me.dgvInst.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvInst.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInst.Location = New System.Drawing.Point(23, 95)
        Me.dgvInst.Name = "dgvInst"
        Me.dgvInst.Size = New System.Drawing.Size(229, 251)
        Me.dgvInst.TabIndex = 237
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(511, 67)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 20)
        Me.Label3.TabIndex = 235
        Me.Label3.Text = "Materia"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(265, 66)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 20)
        Me.Label1.TabIndex = 232
        Me.Label1.Text = "Carrera"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(19, 67)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 20)
        Me.Label2.TabIndex = 232
        Me.Label2.Text = "Institución"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCrearClase
        '
        Me.btnCrearClase.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCrearClase.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnCrearClase.FlatAppearance.BorderSize = 0
        Me.btnCrearClase.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCrearClase.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.btnCrearClase.ForeColor = System.Drawing.Color.White
        Me.btnCrearClase.Location = New System.Drawing.Point(630, 390)
        Me.btnCrearClase.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCrearClase.Name = "btnCrearClase"
        Me.btnCrearClase.Size = New System.Drawing.Size(117, 30)
        Me.btnCrearClase.TabIndex = 227
        Me.btnCrearClase.Text = "Crear clase"
        Me.btnCrearClase.UseVisualStyleBackColor = False
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.Color.Transparent
        Me.Panel12.Controls.Add(Me.BtnDescartar)
        Me.Panel12.Controls.Add(Me.lblTitulo)
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel12.Location = New System.Drawing.Point(0, 0)
        Me.Panel12.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(770, 43)
        Me.Panel12.TabIndex = 203
        '
        'lblTitulo
        '
        Me.lblTitulo.BackColor = System.Drawing.Color.FloralWhite
        Me.lblTitulo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTitulo.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.lblTitulo.Location = New System.Drawing.Point(0, 0)
        Me.lblTitulo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(770, 43)
        Me.lblTitulo.TabIndex = 71
        Me.lblTitulo.Text = "Crear Clase"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Db_Dataset_AulaDigital1
        '
        Me.Db_Dataset_AulaDigital1.DataSetName = "Institucion"
        Me.Db_Dataset_AulaDigital1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnAgregarMateria
        '
        Me.btnAgregarMateria.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAgregarMateria.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnAgregarMateria.FlatAppearance.BorderSize = 0
        Me.btnAgregarMateria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarMateria.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.btnAgregarMateria.ForeColor = System.Drawing.Color.White
        Me.btnAgregarMateria.Image = CType(resources.GetObject("btnAgregarMateria.Image"), System.Drawing.Image)
        Me.btnAgregarMateria.Location = New System.Drawing.Point(515, 353)
        Me.btnAgregarMateria.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAgregarMateria.Name = "btnAgregarMateria"
        Me.btnAgregarMateria.Size = New System.Drawing.Size(229, 29)
        Me.btnAgregarMateria.TabIndex = 224
        Me.btnAgregarMateria.Text = "Agregar Materia"
        Me.btnAgregarMateria.UseVisualStyleBackColor = False
        '
        'btnAgregarCarrera
        '
        Me.btnAgregarCarrera.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAgregarCarrera.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnAgregarCarrera.FlatAppearance.BorderSize = 0
        Me.btnAgregarCarrera.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarCarrera.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.btnAgregarCarrera.ForeColor = System.Drawing.Color.White
        Me.btnAgregarCarrera.Image = CType(resources.GetObject("btnAgregarCarrera.Image"), System.Drawing.Image)
        Me.btnAgregarCarrera.Location = New System.Drawing.Point(269, 353)
        Me.btnAgregarCarrera.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAgregarCarrera.Name = "btnAgregarCarrera"
        Me.btnAgregarCarrera.Size = New System.Drawing.Size(229, 29)
        Me.btnAgregarCarrera.TabIndex = 225
        Me.btnAgregarCarrera.Text = "Agregar Carrera"
        Me.btnAgregarCarrera.UseVisualStyleBackColor = False
        '
        'btnAgregarInst
        '
        Me.btnAgregarInst.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAgregarInst.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnAgregarInst.FlatAppearance.BorderSize = 0
        Me.btnAgregarInst.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarInst.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.btnAgregarInst.ForeColor = System.Drawing.Color.White
        Me.btnAgregarInst.Image = CType(resources.GetObject("btnAgregarInst.Image"), System.Drawing.Image)
        Me.btnAgregarInst.Location = New System.Drawing.Point(23, 353)
        Me.btnAgregarInst.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAgregarInst.Name = "btnAgregarInst"
        Me.btnAgregarInst.Size = New System.Drawing.Size(229, 29)
        Me.btnAgregarInst.TabIndex = 226
        Me.btnAgregarInst.Text = "Agregar Institución"
        Me.btnAgregarInst.UseVisualStyleBackColor = False
        '
        'BtnDescartar
        '
        Me.BtnDescartar.BackColor = System.Drawing.Color.FloralWhite
        Me.BtnDescartar.Dock = System.Windows.Forms.DockStyle.Left
        Me.BtnDescartar.FlatAppearance.BorderSize = 0
        Me.BtnDescartar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDescartar.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!)
        Me.BtnDescartar.Image = CType(resources.GetObject("BtnDescartar.Image"), System.Drawing.Image)
        Me.BtnDescartar.Location = New System.Drawing.Point(0, 0)
        Me.BtnDescartar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnDescartar.Name = "BtnDescartar"
        Me.BtnDescartar.Size = New System.Drawing.Size(35, 43)
        Me.BtnDescartar.TabIndex = 70
        Me.BtnDescartar.UseVisualStyleBackColor = False
        '
        'FrmGrupoInst
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(813, 527)
        Me.Controls.Add(Me.PnlCurso)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmGrupoInst"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.PnlCurso.ResumeLayout(False)
        Me.PnlCurso.PerformLayout()
        CType(Me.dgvMateria, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCarrera, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvInst, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel12.ResumeLayout(False)
        CType(Me.Db_Dataset_AulaDigital1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PnlCurso As Panel
    Friend WithEvents Panel12 As Panel
    Friend WithEvents BtnDescartar As Button
    Friend WithEvents lblTitulo As Label
    Friend WithEvents btnAgregarMateria As Button
    Friend WithEvents btnAgregarCarrera As Button
    Friend WithEvents btnAgregarInst As Button
    Friend WithEvents btnCrearClase As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvMateria As DataGridView
    Friend WithEvents dgvCarrera As DataGridView
    Friend WithEvents dgvInst As DataGridView
    Friend WithEvents Db_Dataset_AulaDigital1 As db_Dataset_AulaDigital
End Class
