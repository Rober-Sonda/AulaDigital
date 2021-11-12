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
        Me.Guna2HtmlLabel8 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.BtnDescartar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.btnAgregarLocalidad = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblNombreInst = New System.Windows.Forms.Label()
        Me.CmbLocalidadInstitucion = New System.Windows.Forms.ComboBox()
        Me.TxtCodAreaCel = New System.Windows.Forms.TextBox()
        Me.TxtCodAreaTel = New System.Windows.Forms.TextBox()
        Me.TxtCelular = New System.Windows.Forms.TextBox()
        Me.TxtTelefono = New System.Windows.Forms.TextBox()
        Me.TxtMail = New System.Windows.Forms.TextBox()
        Me.TxtDirecion = New System.Windows.Forms.TextBox()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Dgv_ListaCarreras = New System.Windows.Forms.DataGridView()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PnlBotones = New Guna.UI2.WinForms.Guna2Panel()
        Me.BtnMinimizar = New System.Windows.Forms.Button()
        Me.BtnMaximizar = New System.Windows.Forms.Button()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.LbltitulofrmInstitucion = New System.Windows.Forms.Label()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.Dgv_ListaCarreras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.PnlBotones.SuspendLayout()
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
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.btnGuardar)
        Me.Panel3.Controls.Add(Me.BtnDescartar)
        Me.Panel3.Controls.Add(Me.BtnEliminar)
        Me.Panel3.Controls.Add(Me.BtnEditar)
        Me.Panel3.Controls.Add(Me.btnAgregarLocalidad)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.LblNombreInst)
        Me.Panel3.Controls.Add(Me.CmbLocalidadInstitucion)
        Me.Panel3.Controls.Add(Me.TxtCodAreaCel)
        Me.Panel3.Controls.Add(Me.TxtCodAreaTel)
        Me.Panel3.Controls.Add(Me.TxtCelular)
        Me.Panel3.Controls.Add(Me.TxtTelefono)
        Me.Panel3.Controls.Add(Me.TxtMail)
        Me.Panel3.Controls.Add(Me.TxtDirecion)
        Me.Panel3.Controls.Add(Me.TxtNombre)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.Location = New System.Drawing.Point(0, 38)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(497, 474)
        Me.Panel3.TabIndex = 95
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!)
        Me.Label7.ForeColor = System.Drawing.Color.MediumAquamarine
        Me.Label7.Location = New System.Drawing.Point(27, 25)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(128, 18)
        Me.Label7.TabIndex = 113
        Me.Label7.Text = "Agregar Institución"
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.MediumAquamarine
        Me.btnGuardar.FlatAppearance.BorderSize = 0
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!)
        Me.btnGuardar.ForeColor = System.Drawing.Color.White
        Me.btnGuardar.Location = New System.Drawing.Point(268, 407)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(100, 35)
        Me.btnGuardar.TabIndex = 112
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'BtnDescartar
        '
        Me.BtnDescartar.BackColor = System.Drawing.Color.MediumAquamarine
        Me.BtnDescartar.FlatAppearance.BorderSize = 0
        Me.BtnDescartar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDescartar.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!)
        Me.BtnDescartar.ForeColor = System.Drawing.Color.White
        Me.BtnDescartar.Location = New System.Drawing.Point(374, 407)
        Me.BtnDescartar.Name = "BtnDescartar"
        Me.BtnDescartar.Size = New System.Drawing.Size(100, 35)
        Me.BtnDescartar.TabIndex = 108
        Me.BtnDescartar.Text = "Descartar"
        Me.BtnDescartar.UseVisualStyleBackColor = False
        '
        'BtnEliminar
        '
        Me.BtnEliminar.BackColor = System.Drawing.Color.MediumAquamarine
        Me.BtnEliminar.FlatAppearance.BorderSize = 0
        Me.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEliminar.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!)
        Me.BtnEliminar.Location = New System.Drawing.Point(444, 96)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(30, 30)
        Me.BtnEliminar.TabIndex = 111
        Me.BtnEliminar.UseVisualStyleBackColor = False
        '
        'BtnEditar
        '
        Me.BtnEditar.BackColor = System.Drawing.Color.MediumAquamarine
        Me.BtnEditar.FlatAppearance.BorderSize = 0
        Me.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEditar.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!)
        Me.BtnEditar.Location = New System.Drawing.Point(444, 60)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(30, 30)
        Me.BtnEditar.TabIndex = 110
        Me.BtnEditar.UseVisualStyleBackColor = False
        '
        'btnAgregarLocalidad
        '
        Me.btnAgregarLocalidad.BackColor = System.Drawing.Color.MediumAquamarine
        Me.btnAgregarLocalidad.FlatAppearance.BorderSize = 0
        Me.btnAgregarLocalidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarLocalidad.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!)
        Me.btnAgregarLocalidad.Location = New System.Drawing.Point(268, 145)
        Me.btnAgregarLocalidad.Name = "btnAgregarLocalidad"
        Me.btnAgregarLocalidad.Size = New System.Drawing.Size(30, 30)
        Me.btnAgregarLocalidad.TabIndex = 109
        Me.btnAgregarLocalidad.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(27, 283)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 18)
        Me.Label5.TabIndex = 106
        Me.Label5.Text = "Mail"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(27, 243)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 18)
        Me.Label4.TabIndex = 103
        Me.Label4.Text = "Celular"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(27, 202)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 18)
        Me.Label3.TabIndex = 105
        Me.Label3.Text = "Telefono"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(27, 154)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 18)
        Me.Label2.TabIndex = 104
        Me.Label2.Text = "Localidad"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(27, 114)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 18)
        Me.Label1.TabIndex = 107
        Me.Label1.Text = "Dirección"
        '
        'LblNombreInst
        '
        Me.LblNombreInst.AutoSize = True
        Me.LblNombreInst.BackColor = System.Drawing.Color.Transparent
        Me.LblNombreInst.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!)
        Me.LblNombreInst.ForeColor = System.Drawing.Color.Black
        Me.LblNombreInst.Location = New System.Drawing.Point(27, 69)
        Me.LblNombreInst.Name = "LblNombreInst"
        Me.LblNombreInst.Size = New System.Drawing.Size(62, 18)
        Me.LblNombreInst.TabIndex = 102
        Me.LblNombreInst.Text = "Nombre"
        '
        'CmbLocalidadInstitucion
        '
        Me.CmbLocalidadInstitucion.FormattingEnabled = True
        Me.CmbLocalidadInstitucion.Location = New System.Drawing.Point(111, 145)
        Me.CmbLocalidadInstitucion.Name = "CmbLocalidadInstitucion"
        Me.CmbLocalidadInstitucion.Size = New System.Drawing.Size(148, 32)
        Me.CmbLocalidadInstitucion.TabIndex = 101
        '
        'TxtCodAreaCel
        '
        Me.TxtCodAreaCel.Location = New System.Drawing.Point(111, 241)
        Me.TxtCodAreaCel.Name = "TxtCodAreaCel"
        Me.TxtCodAreaCel.Size = New System.Drawing.Size(61, 29)
        Me.TxtCodAreaCel.TabIndex = 98
        '
        'TxtCodAreaTel
        '
        Me.TxtCodAreaTel.Location = New System.Drawing.Point(111, 193)
        Me.TxtCodAreaTel.Name = "TxtCodAreaTel"
        Me.TxtCodAreaTel.Size = New System.Drawing.Size(61, 29)
        Me.TxtCodAreaTel.TabIndex = 97
        '
        'TxtCelular
        '
        Me.TxtCelular.Location = New System.Drawing.Point(182, 241)
        Me.TxtCelular.Name = "TxtCelular"
        Me.TxtCelular.Size = New System.Drawing.Size(121, 29)
        Me.TxtCelular.TabIndex = 96
        '
        'TxtTelefono
        '
        Me.TxtTelefono.Location = New System.Drawing.Point(182, 193)
        Me.TxtTelefono.Name = "TxtTelefono"
        Me.TxtTelefono.Size = New System.Drawing.Size(121, 29)
        Me.TxtTelefono.TabIndex = 95
        '
        'TxtMail
        '
        Me.TxtMail.Location = New System.Drawing.Point(111, 284)
        Me.TxtMail.Name = "TxtMail"
        Me.TxtMail.Size = New System.Drawing.Size(192, 29)
        Me.TxtMail.TabIndex = 94
        '
        'TxtDirecion
        '
        Me.TxtDirecion.Location = New System.Drawing.Point(111, 105)
        Me.TxtDirecion.Name = "TxtDirecion"
        Me.TxtDirecion.Size = New System.Drawing.Size(192, 29)
        Me.TxtDirecion.TabIndex = 99
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(111, 60)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(192, 29)
        Me.TxtNombre.TabIndex = 100
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Dgv_ListaCarreras)
        Me.Panel1.Controls.Add(Me.BtnBuscar)
        Me.Panel1.Controls.Add(Me.TxtBuscar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(531, 38)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(353, 474)
        Me.Panel1.TabIndex = 94
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!)
        Me.Label6.ForeColor = System.Drawing.Color.MediumAquamarine
        Me.Label6.Location = New System.Drawing.Point(130, 10)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(105, 21)
        Me.Label6.TabIndex = 48
        Me.Label6.Text = "Instituciones"
        '
        'Dgv_ListaCarreras
        '
        Me.Dgv_ListaCarreras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_ListaCarreras.Location = New System.Drawing.Point(27, 84)
        Me.Dgv_ListaCarreras.Name = "Dgv_ListaCarreras"
        Me.Dgv_ListaCarreras.Size = New System.Drawing.Size(300, 355)
        Me.Dgv_ListaCarreras.TabIndex = 51
        '
        'BtnBuscar
        '
        Me.BtnBuscar.BackColor = System.Drawing.Color.MediumAquamarine
        Me.BtnBuscar.FlatAppearance.BorderSize = 0
        Me.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBuscar.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!)
        Me.BtnBuscar.Location = New System.Drawing.Point(297, 34)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(30, 30)
        Me.BtnBuscar.TabIndex = 50
        Me.BtnBuscar.UseVisualStyleBackColor = False
        '
        'TxtBuscar
        '
        Me.TxtBuscar.Location = New System.Drawing.Point(27, 34)
        Me.TxtBuscar.Multiline = True
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(264, 30)
        Me.TxtBuscar.TabIndex = 49
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.MediumAquamarine
        Me.Panel2.Controls.Add(Me.PnlBotones)
        Me.Panel2.Controls.Add(Me.LbltitulofrmInstitucion)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(884, 38)
        Me.Panel2.TabIndex = 96
        '
        'PnlBotones
        '
        Me.PnlBotones.BackColor = System.Drawing.Color.Transparent
        Me.PnlBotones.Controls.Add(Me.BtnMinimizar)
        Me.PnlBotones.Controls.Add(Me.BtnMaximizar)
        Me.PnlBotones.Controls.Add(Me.BtnCerrar)
        Me.PnlBotones.Dock = System.Windows.Forms.DockStyle.Right
        Me.PnlBotones.Location = New System.Drawing.Point(766, 0)
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
        'LbltitulofrmInstitucion
        '
        Me.LbltitulofrmInstitucion.BackColor = System.Drawing.Color.Transparent
        Me.LbltitulofrmInstitucion.Dock = System.Windows.Forms.DockStyle.Left
        Me.LbltitulofrmInstitucion.Font = New System.Drawing.Font("Berlin Sans FB", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbltitulofrmInstitucion.ForeColor = System.Drawing.Color.White
        Me.LbltitulofrmInstitucion.Location = New System.Drawing.Point(0, 0)
        Me.LbltitulofrmInstitucion.Name = "LbltitulofrmInstitucion"
        Me.LbltitulofrmInstitucion.Size = New System.Drawing.Size(140, 38)
        Me.LbltitulofrmInstitucion.TabIndex = 67
        Me.LbltitulofrmInstitucion.Text = "Institucion"
        Me.LbltitulofrmInstitucion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmAgregarInst
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 512)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmAgregarInst"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Agregar_Institucion"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Dgv_ListaCarreras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.PnlBotones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2HtmlLabel8 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents btnGuardar As Button
    Friend WithEvents BtnDescartar As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnEditar As Button
    Friend WithEvents btnAgregarLocalidad As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LblNombreInst As Label
    Friend WithEvents CmbLocalidadInstitucion As ComboBox
    Friend WithEvents TxtCodAreaCel As TextBox
    Friend WithEvents TxtCodAreaTel As TextBox
    Friend WithEvents TxtCelular As TextBox
    Friend WithEvents TxtTelefono As TextBox
    Friend WithEvents TxtMail As TextBox
    Friend WithEvents TxtDirecion As TextBox
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Dgv_ListaCarreras As DataGridView
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents TxtBuscar As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PnlBotones As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents BtnMinimizar As Button
    Friend WithEvents BtnMaximizar As Button
    Friend WithEvents BtnCerrar As Button
    Friend WithEvents LbltitulofrmInstitucion As Label
End Class
