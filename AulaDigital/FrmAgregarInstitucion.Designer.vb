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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PnlBotones = New Guna.UI2.WinForms.Guna2Panel()
        Me.BtnMinimizar = New System.Windows.Forms.Button()
        Me.BtnMaximizar = New System.Windows.Forms.Button()
        Me.BtnCerrar = New System.Windows.Forms.Button()
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
        Me.LbltitulofrmInstitucion = New System.Windows.Forms.Label()
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
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.MediumAquamarine
        Me.Panel2.Controls.Add(Me.PnlBotones)
        Me.Panel2.Controls.Add(Me.LbltitulofrmInstitucion)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(556, 43)
        Me.Panel2.TabIndex = 96
        '
        'PnlBotones
        '
        Me.PnlBotones.BackColor = System.Drawing.Color.Transparent
        Me.PnlBotones.Controls.Add(Me.BtnMinimizar)
        Me.PnlBotones.Controls.Add(Me.BtnMaximizar)
        Me.PnlBotones.Controls.Add(Me.BtnCerrar)
        Me.PnlBotones.Dock = System.Windows.Forms.DockStyle.Right
        Me.PnlBotones.Location = New System.Drawing.Point(418, 0)
        Me.PnlBotones.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PnlBotones.Name = "PnlBotones"
        Me.PnlBotones.ShadowDecoration.Parent = Me.PnlBotones
        Me.PnlBotones.Size = New System.Drawing.Size(138, 43)
        Me.PnlBotones.TabIndex = 29
        '
        'BtnMinimizar
        '
        Me.BtnMinimizar.BackColor = System.Drawing.Color.MediumAquamarine
        Me.BtnMinimizar.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtnMinimizar.FlatAppearance.BorderSize = 0
        Me.BtnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMinimizar.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!)
        Me.BtnMinimizar.Location = New System.Drawing.Point(33, 0)
        Me.BtnMinimizar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnMinimizar.Name = "BtnMinimizar"
        Me.BtnMinimizar.Size = New System.Drawing.Size(35, 43)
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
        Me.BtnMaximizar.Location = New System.Drawing.Point(68, 0)
        Me.BtnMaximizar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnMaximizar.Name = "BtnMaximizar"
        Me.BtnMaximizar.Size = New System.Drawing.Size(35, 43)
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
        Me.BtnCerrar.Location = New System.Drawing.Point(103, 0)
        Me.BtnCerrar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(35, 43)
        Me.BtnCerrar.TabIndex = 30
        Me.BtnCerrar.Text = "C"
        Me.BtnCerrar.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.MediumAquamarine
        Me.btnGuardar.FlatAppearance.BorderSize = 0
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!)
        Me.btnGuardar.ForeColor = System.Drawing.Color.White
        Me.btnGuardar.Location = New System.Drawing.Point(271, 423)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(117, 41)
        Me.btnGuardar.TabIndex = 132
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
        Me.BtnDescartar.Location = New System.Drawing.Point(394, 423)
        Me.BtnDescartar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnDescartar.Name = "BtnDescartar"
        Me.BtnDescartar.Size = New System.Drawing.Size(117, 41)
        Me.BtnDescartar.TabIndex = 128
        Me.BtnDescartar.Text = "Descartar"
        Me.BtnDescartar.UseVisualStyleBackColor = False
        '
        'BtnEliminar
        '
        Me.BtnEliminar.BackColor = System.Drawing.Color.MediumAquamarine
        Me.BtnEliminar.FlatAppearance.BorderSize = 0
        Me.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEliminar.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!)
        Me.BtnEliminar.Location = New System.Drawing.Point(476, 122)
        Me.BtnEliminar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(35, 34)
        Me.BtnEliminar.TabIndex = 131
        Me.BtnEliminar.UseVisualStyleBackColor = False
        '
        'BtnEditar
        '
        Me.BtnEditar.BackColor = System.Drawing.Color.MediumAquamarine
        Me.BtnEditar.FlatAppearance.BorderSize = 0
        Me.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEditar.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!)
        Me.BtnEditar.Location = New System.Drawing.Point(476, 79)
        Me.BtnEditar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(35, 34)
        Me.BtnEditar.TabIndex = 130
        Me.BtnEditar.UseVisualStyleBackColor = False
        '
        'btnAgregarLocalidad
        '
        Me.btnAgregarLocalidad.BackColor = System.Drawing.Color.MediumAquamarine
        Me.btnAgregarLocalidad.FlatAppearance.BorderSize = 0
        Me.btnAgregarLocalidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarLocalidad.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!)
        Me.btnAgregarLocalidad.Location = New System.Drawing.Point(362, 178)
        Me.btnAgregarLocalidad.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAgregarLocalidad.Name = "btnAgregarLocalidad"
        Me.btnAgregarLocalidad.Size = New System.Drawing.Size(26, 23)
        Me.btnAgregarLocalidad.TabIndex = 129
        Me.btnAgregarLocalidad.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(34, 337)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 18)
        Me.Label5.TabIndex = 126
        Me.Label5.Text = "Mail"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(34, 290)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 18)
        Me.Label4.TabIndex = 123
        Me.Label4.Text = "Celular"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(34, 237)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 18)
        Me.Label3.TabIndex = 125
        Me.Label3.Text = "Telefono"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(34, 183)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 18)
        Me.Label2.TabIndex = 124
        Me.Label2.Text = "Localidad"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(34, 135)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 18)
        Me.Label1.TabIndex = 127
        Me.Label1.Text = "Dirección"
        '
        'LblNombreInst
        '
        Me.LblNombreInst.AutoSize = True
        Me.LblNombreInst.BackColor = System.Drawing.Color.Transparent
        Me.LblNombreInst.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!)
        Me.LblNombreInst.ForeColor = System.Drawing.Color.Black
        Me.LblNombreInst.Location = New System.Drawing.Point(34, 83)
        Me.LblNombreInst.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblNombreInst.Name = "LblNombreInst"
        Me.LblNombreInst.Size = New System.Drawing.Size(62, 18)
        Me.LblNombreInst.TabIndex = 122
        Me.LblNombreInst.Text = "Nombre"
        '
        'CmbLocalidadInstitucion
        '
        Me.CmbLocalidadInstitucion.FormattingEnabled = True
        Me.CmbLocalidadInstitucion.Location = New System.Drawing.Point(132, 178)
        Me.CmbLocalidadInstitucion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CmbLocalidadInstitucion.Name = "CmbLocalidadInstitucion"
        Me.CmbLocalidadInstitucion.Size = New System.Drawing.Size(222, 23)
        Me.CmbLocalidadInstitucion.TabIndex = 121
        '
        'TxtCodAreaCel
        '
        Me.TxtCodAreaCel.Location = New System.Drawing.Point(132, 288)
        Me.TxtCodAreaCel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtCodAreaCel.Name = "TxtCodAreaCel"
        Me.TxtCodAreaCel.Size = New System.Drawing.Size(70, 22)
        Me.TxtCodAreaCel.TabIndex = 118
        '
        'TxtCodAreaTel
        '
        Me.TxtCodAreaTel.Location = New System.Drawing.Point(132, 233)
        Me.TxtCodAreaTel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtCodAreaTel.Name = "TxtCodAreaTel"
        Me.TxtCodAreaTel.Size = New System.Drawing.Size(70, 22)
        Me.TxtCodAreaTel.TabIndex = 117
        '
        'TxtCelular
        '
        Me.TxtCelular.Location = New System.Drawing.Point(214, 288)
        Me.TxtCelular.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtCelular.Name = "TxtCelular"
        Me.TxtCelular.Size = New System.Drawing.Size(174, 22)
        Me.TxtCelular.TabIndex = 116
        '
        'TxtTelefono
        '
        Me.TxtTelefono.Location = New System.Drawing.Point(214, 233)
        Me.TxtTelefono.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTelefono.Name = "TxtTelefono"
        Me.TxtTelefono.Size = New System.Drawing.Size(174, 22)
        Me.TxtTelefono.TabIndex = 115
        '
        'TxtMail
        '
        Me.TxtMail.Location = New System.Drawing.Point(132, 338)
        Me.TxtMail.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtMail.Name = "TxtMail"
        Me.TxtMail.Size = New System.Drawing.Size(256, 22)
        Me.TxtMail.TabIndex = 114
        '
        'TxtDirecion
        '
        Me.TxtDirecion.Location = New System.Drawing.Point(132, 131)
        Me.TxtDirecion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtDirecion.Name = "TxtDirecion"
        Me.TxtDirecion.Size = New System.Drawing.Size(256, 22)
        Me.TxtDirecion.TabIndex = 119
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(132, 79)
        Me.TxtNombre.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(256, 22)
        Me.TxtNombre.TabIndex = 120
        '
        'LbltitulofrmInstitucion
        '
        Me.LbltitulofrmInstitucion.BackColor = System.Drawing.Color.Transparent
        Me.LbltitulofrmInstitucion.Dock = System.Windows.Forms.DockStyle.Left
        Me.LbltitulofrmInstitucion.Font = New System.Drawing.Font("Berlin Sans FB", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbltitulofrmInstitucion.ForeColor = System.Drawing.Color.White
        Me.LbltitulofrmInstitucion.Location = New System.Drawing.Point(0, 0)
        Me.LbltitulofrmInstitucion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LbltitulofrmInstitucion.Name = "LbltitulofrmInstitucion"
        Me.LbltitulofrmInstitucion.Size = New System.Drawing.Size(163, 43)
        Me.LbltitulofrmInstitucion.TabIndex = 67
        Me.LbltitulofrmInstitucion.Text = "Institucion"
        Me.LbltitulofrmInstitucion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmAgregarInst
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(556, 483)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.BtnDescartar)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnEditar)
        Me.Controls.Add(Me.btnAgregarLocalidad)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LblNombreInst)
        Me.Controls.Add(Me.CmbLocalidadInstitucion)
        Me.Controls.Add(Me.TxtCodAreaCel)
        Me.Controls.Add(Me.TxtCodAreaTel)
        Me.Controls.Add(Me.TxtCelular)
        Me.Controls.Add(Me.TxtTelefono)
        Me.Controls.Add(Me.TxtMail)
        Me.Controls.Add(Me.TxtDirecion)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.Panel2)
        Me.Font = New System.Drawing.Font("Berlin Sans FB", 10.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FrmAgregarInst"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Agregar_Institucion"
        Me.Panel2.ResumeLayout(False)
        Me.PnlBotones.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Guna2HtmlLabel8 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PnlBotones As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents BtnMinimizar As Button
    Friend WithEvents BtnMaximizar As Button
    Friend WithEvents BtnCerrar As Button
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
    Friend WithEvents LbltitulofrmInstitucion As Label
End Class
