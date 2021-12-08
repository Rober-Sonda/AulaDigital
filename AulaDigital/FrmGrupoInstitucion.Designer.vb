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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LbltitulofrmAlum = New System.Windows.Forms.Label()
        Me.PnlBotones = New Guna.UI2.WinForms.Guna2Panel()
        Me.BtnMinimizar = New System.Windows.Forms.Button()
        Me.BtnMaximizar = New System.Windows.Forms.Button()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
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
        Me.Panel2.Size = New System.Drawing.Size(566, 38)
        Me.Panel2.TabIndex = 55
        '
        'LbltitulofrmAlum
        '
        Me.LbltitulofrmAlum.BackColor = System.Drawing.Color.Transparent
        Me.LbltitulofrmAlum.Dock = System.Windows.Forms.DockStyle.Left
        Me.LbltitulofrmAlum.Font = New System.Drawing.Font("Berlin Sans FB", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbltitulofrmAlum.ForeColor = System.Drawing.Color.White
        Me.LbltitulofrmAlum.Location = New System.Drawing.Point(0, 0)
        Me.LbltitulofrmAlum.Name = "LbltitulofrmAlum"
        Me.LbltitulofrmAlum.Size = New System.Drawing.Size(239, 38)
        Me.LbltitulofrmAlum.TabIndex = 67
        Me.LbltitulofrmAlum.Text = "Agregar institucion"
        Me.LbltitulofrmAlum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PnlBotones
        '
        Me.PnlBotones.BackColor = System.Drawing.Color.Transparent
        Me.PnlBotones.Controls.Add(Me.BtnMinimizar)
        Me.PnlBotones.Controls.Add(Me.BtnMaximizar)
        Me.PnlBotones.Controls.Add(Me.BtnCerrar)
        Me.PnlBotones.Dock = System.Windows.Forms.DockStyle.Right
        Me.PnlBotones.Location = New System.Drawing.Point(448, 0)
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
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(121, 143)
        Me.TxtNombre.Multiline = True
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(292, 30)
        Me.TxtNombre.TabIndex = 68
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.BackColor = System.Drawing.Color.Transparent
        Me.LblNombre.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!)
        Me.LblNombre.ForeColor = System.Drawing.Color.Black
        Me.LblNombre.Location = New System.Drawing.Point(53, 101)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(62, 18)
        Me.LblNombre.TabIndex = 69
        Me.LblNombre.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(53, 155)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 18)
        Me.Label1.TabIndex = 104
        Me.Label1.Text = "Dirección"
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Berlin Sans FB", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(121, 94)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(292, 31)
        Me.ComboBox1.TabIndex = 103
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(121, 192)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(292, 30)
        Me.TextBox1.TabIndex = 68
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(53, 204)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 18)
        Me.Label2.TabIndex = 104
        Me.Label2.Text = "Telefono"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(121, 240)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(292, 30)
        Me.TextBox2.TabIndex = 68
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(53, 252)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 18)
        Me.Label3.TabIndex = 104
        Me.Label3.Text = "Celular"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(30, 292)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 18)
        Me.Label4.TabIndex = 104
        Me.Label4.Text = "Carrera:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(53, 328)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 18)
        Me.Label5.TabIndex = 69
        Me.Label5.Text = "Nombre"
        '
        'ComboBox2
        '
        Me.ComboBox2.Font = New System.Drawing.Font("Berlin Sans FB", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(121, 321)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(292, 31)
        Me.ComboBox2.TabIndex = 103
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!)
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(53, 372)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 18)
        Me.Label6.TabIndex = 104
        Me.Label6.Text = "Turno"
        '
        'ComboBox3
        '
        Me.ComboBox3.Font = New System.Drawing.Font("Berlin Sans FB", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(121, 365)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(292, 31)
        Me.ComboBox3.TabIndex = 103
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!)
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(30, 58)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(216, 18)
        Me.Label7.TabIndex = 104
        Me.Label7.Text = "* Institución / * Carrera / Materia"
        '
        'BtnDescartar
        '
        Me.BtnDescartar.BackColor = System.Drawing.Color.MediumAquamarine
        Me.BtnDescartar.FlatAppearance.BorderSize = 0
        Me.BtnDescartar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDescartar.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!)
        Me.BtnDescartar.ForeColor = System.Drawing.Color.White
        Me.BtnDescartar.Location = New System.Drawing.Point(442, 363)
        Me.BtnDescartar.Name = "BtnDescartar"
        Me.BtnDescartar.Size = New System.Drawing.Size(100, 35)
        Me.BtnDescartar.TabIndex = 109
        Me.BtnDescartar.Text = "Siguiente"
        Me.BtnDescartar.UseVisualStyleBackColor = False
        '
        'FrmGrupoInst
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(566, 436)
        Me.Controls.Add(Me.BtnDescartar)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.LblNombre)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmGrupoInst"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
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
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents LblNombre As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents BtnDescartar As Button
End Class
