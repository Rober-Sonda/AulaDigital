<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Agregar_alumno
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LbltitulofrmAlum = New System.Windows.Forms.Label()
        Me.PnlBotones = New Guna.UI2.WinForms.Guna2Panel()
        Me.BtnMinimizar = New System.Windows.Forms.Button()
        Me.BtnMaximizar = New System.Windows.Forms.Button()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.btnAgregarLocalidad = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CmbLocalidadInstitucion = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.TxtApellido = New System.Windows.Forms.TextBox()
        Me.LblApellido = New System.Windows.Forms.Label()
        Me.TxtDni = New System.Windows.Forms.TextBox()
        Me.LblDireccion = New System.Windows.Forms.Label()
        Me.TxtTelefono = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TexDireccion = New System.Windows.Forms.TextBox()
        Me.LblDNI = New System.Windows.Forms.Label()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnDescartar = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        Me.PnlBotones.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.MediumAquamarine
        Me.Panel2.Controls.Add(Me.LbltitulofrmAlum)
        Me.Panel2.Controls.Add(Me.PnlBotones)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(540, 38)
        Me.Panel2.TabIndex = 54
        '
        'LbltitulofrmAlum
        '
        Me.LbltitulofrmAlum.BackColor = System.Drawing.Color.Transparent
        Me.LbltitulofrmAlum.Dock = System.Windows.Forms.DockStyle.Left
        Me.LbltitulofrmAlum.Font = New System.Drawing.Font("Berlin Sans FB", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbltitulofrmAlum.ForeColor = System.Drawing.Color.White
        Me.LbltitulofrmAlum.Location = New System.Drawing.Point(0, 0)
        Me.LbltitulofrmAlum.Name = "LbltitulofrmAlum"
        Me.LbltitulofrmAlum.Size = New System.Drawing.Size(140, 38)
        Me.LbltitulofrmAlum.TabIndex = 67
        Me.LbltitulofrmAlum.Text = "Alumnos"
        Me.LbltitulofrmAlum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PnlBotones
        '
        Me.PnlBotones.BackColor = System.Drawing.Color.Transparent
        Me.PnlBotones.Controls.Add(Me.BtnMinimizar)
        Me.PnlBotones.Controls.Add(Me.BtnMaximizar)
        Me.PnlBotones.Controls.Add(Me.BtnCerrar)
        Me.PnlBotones.Dock = System.Windows.Forms.DockStyle.Right
        Me.PnlBotones.Location = New System.Drawing.Point(422, 0)
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
        'btnAgregarLocalidad
        '
        Me.btnAgregarLocalidad.BackColor = System.Drawing.Color.MediumAquamarine
        Me.btnAgregarLocalidad.FlatAppearance.BorderSize = 0
        Me.btnAgregarLocalidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarLocalidad.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!)
        Me.btnAgregarLocalidad.Location = New System.Drawing.Point(403, 261)
        Me.btnAgregarLocalidad.Name = "btnAgregarLocalidad"
        Me.btnAgregarLocalidad.Size = New System.Drawing.Size(30, 30)
        Me.btnAgregarLocalidad.TabIndex = 129
        Me.btnAgregarLocalidad.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(61, 266)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 18)
        Me.Label4.TabIndex = 128
        Me.Label4.Text = "Localidad"
        '
        'CmbLocalidadInstitucion
        '
        Me.CmbLocalidadInstitucion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbLocalidadInstitucion.FormattingEnabled = True
        Me.CmbLocalidadInstitucion.Location = New System.Drawing.Point(139, 262)
        Me.CmbLocalidadInstitucion.Name = "CmbLocalidadInstitucion"
        Me.CmbLocalidadInstitucion.Size = New System.Drawing.Size(250, 28)
        Me.CmbLocalidadInstitucion.TabIndex = 127
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!)
        Me.Label3.ForeColor = System.Drawing.Color.MediumAquamarine
        Me.Label3.Location = New System.Drawing.Point(194, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 18)
        Me.Label3.TabIndex = 120
        Me.Label3.Text = "/  Ver existentes"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!)
        Me.Label2.ForeColor = System.Drawing.Color.MediumAquamarine
        Me.Label2.Location = New System.Drawing.Point(75, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 18)
        Me.Label2.TabIndex = 121
        Me.Label2.Text = "Agregar Alumno"
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(139, 98)
        Me.TxtNombre.Multiline = True
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(250, 30)
        Me.TxtNombre.TabIndex = 117
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.BackColor = System.Drawing.Color.Transparent
        Me.LblNombre.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!)
        Me.LblNombre.ForeColor = System.Drawing.Color.Black
        Me.LblNombre.Location = New System.Drawing.Point(71, 104)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(62, 18)
        Me.LblNombre.TabIndex = 122
        Me.LblNombre.Text = "Nombre"
        '
        'TxtApellido
        '
        Me.TxtApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtApellido.Location = New System.Drawing.Point(139, 154)
        Me.TxtApellido.Multiline = True
        Me.TxtApellido.Name = "TxtApellido"
        Me.TxtApellido.Size = New System.Drawing.Size(250, 30)
        Me.TxtApellido.TabIndex = 116
        '
        'LblApellido
        '
        Me.LblApellido.AutoSize = True
        Me.LblApellido.BackColor = System.Drawing.Color.Transparent
        Me.LblApellido.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!)
        Me.LblApellido.ForeColor = System.Drawing.Color.Black
        Me.LblApellido.Location = New System.Drawing.Point(71, 160)
        Me.LblApellido.Name = "LblApellido"
        Me.LblApellido.Size = New System.Drawing.Size(62, 18)
        Me.LblApellido.TabIndex = 123
        Me.LblApellido.Text = "Apellido"
        '
        'TxtDni
        '
        Me.TxtDni.Location = New System.Drawing.Point(139, 210)
        Me.TxtDni.Multiline = True
        Me.TxtDni.Name = "TxtDni"
        Me.TxtDni.Size = New System.Drawing.Size(250, 30)
        Me.TxtDni.TabIndex = 115
        '
        'LblDireccion
        '
        Me.LblDireccion.AutoSize = True
        Me.LblDireccion.BackColor = System.Drawing.Color.Transparent
        Me.LblDireccion.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!)
        Me.LblDireccion.ForeColor = System.Drawing.Color.Black
        Me.LblDireccion.Location = New System.Drawing.Point(71, 374)
        Me.LblDireccion.Name = "LblDireccion"
        Me.LblDireccion.Size = New System.Drawing.Size(66, 18)
        Me.LblDireccion.TabIndex = 124
        Me.LblDireccion.Text = "Dirección"
        '
        'TxtTelefono
        '
        Me.TxtTelefono.Location = New System.Drawing.Point(139, 312)
        Me.TxtTelefono.Multiline = True
        Me.TxtTelefono.Name = "TxtTelefono"
        Me.TxtTelefono.Size = New System.Drawing.Size(250, 30)
        Me.TxtTelefono.TabIndex = 114
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(71, 318)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 18)
        Me.Label1.TabIndex = 125
        Me.Label1.Text = "Teléfono"
        '
        'TexDireccion
        '
        Me.TexDireccion.Location = New System.Drawing.Point(139, 368)
        Me.TexDireccion.Multiline = True
        Me.TexDireccion.Name = "TexDireccion"
        Me.TexDireccion.Size = New System.Drawing.Size(250, 30)
        Me.TexDireccion.TabIndex = 113
        '
        'LblDNI
        '
        Me.LblDNI.AutoSize = True
        Me.LblDNI.BackColor = System.Drawing.Color.Transparent
        Me.LblDNI.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!)
        Me.LblDNI.ForeColor = System.Drawing.Color.Black
        Me.LblDNI.Location = New System.Drawing.Point(71, 216)
        Me.LblDNI.Name = "LblDNI"
        Me.LblDNI.Size = New System.Drawing.Size(33, 18)
        Me.LblDNI.TabIndex = 126
        Me.LblDNI.Text = "DNI"
        '
        'BtnGuardar
        '
        Me.BtnGuardar.BackColor = System.Drawing.Color.MediumAquamarine
        Me.BtnGuardar.FlatAppearance.BorderSize = 0
        Me.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGuardar.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!)
        Me.BtnGuardar.ForeColor = System.Drawing.Color.White
        Me.BtnGuardar.Location = New System.Drawing.Point(311, 428)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(100, 35)
        Me.BtnGuardar.TabIndex = 119
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = False
        '
        'BtnDescartar
        '
        Me.BtnDescartar.BackColor = System.Drawing.Color.MediumAquamarine
        Me.BtnDescartar.FlatAppearance.BorderSize = 0
        Me.BtnDescartar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDescartar.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!)
        Me.BtnDescartar.ForeColor = System.Drawing.Color.White
        Me.BtnDescartar.Location = New System.Drawing.Point(428, 428)
        Me.BtnDescartar.Name = "BtnDescartar"
        Me.BtnDescartar.Size = New System.Drawing.Size(100, 35)
        Me.BtnDescartar.TabIndex = 118
        Me.BtnDescartar.Text = "Descartar"
        Me.BtnDescartar.UseVisualStyleBackColor = False
        '
        'Agregar_alumno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(540, 512)
        Me.Controls.Add(Me.btnAgregarLocalidad)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CmbLocalidadInstitucion)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.LblNombre)
        Me.Controls.Add(Me.TxtApellido)
        Me.Controls.Add(Me.LblApellido)
        Me.Controls.Add(Me.TxtDni)
        Me.Controls.Add(Me.LblDireccion)
        Me.Controls.Add(Me.TxtTelefono)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TexDireccion)
        Me.Controls.Add(Me.LblDNI)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.BtnDescartar)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Agregar_alumno"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Agregar_alumno"
        Me.Panel2.ResumeLayout(False)
        Me.PnlBotones.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents LbltitulofrmAlum As Label
    Friend WithEvents PnlBotones As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents BtnMinimizar As Button
    Friend WithEvents BtnMaximizar As Button
    Friend WithEvents BtnCerrar As Button
    Friend WithEvents btnAgregarLocalidad As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents CmbLocalidadInstitucion As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents LblNombre As Label
    Friend WithEvents TxtApellido As TextBox
    Friend WithEvents LblApellido As Label
    Friend WithEvents TxtDni As TextBox
    Friend WithEvents LblDireccion As Label
    Friend WithEvents TxtTelefono As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TexDireccion As TextBox
    Friend WithEvents LblDNI As Label
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnDescartar As Button
End Class
