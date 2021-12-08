<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAgregarAlumno
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
        Me.Guna2HtmlLabel6 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Dgv_ListaCarreras = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PnlBotones = New Guna.UI2.WinForms.Guna2Panel()
        Me.BtnMinimizar = New System.Windows.Forms.Button()
        Me.BtnMaximizar = New System.Windows.Forms.Button()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.LbltitulofrmInstitucion = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnDescartar = New System.Windows.Forms.Button()
        CType(Me.Dgv_ListaCarreras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.PnlBotones.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2HtmlLabel6
        '
        Me.Guna2HtmlLabel6.BackColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel6.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel6.ForeColor = System.Drawing.Color.MediumAquamarine
        Me.Guna2HtmlLabel6.Location = New System.Drawing.Point(22, 50)
        Me.Guna2HtmlLabel6.Name = "Guna2HtmlLabel6"
        Me.Guna2HtmlLabel6.Size = New System.Drawing.Size(68, 22)
        Me.Guna2HtmlLabel6.TabIndex = 28
        Me.Guna2HtmlLabel6.Text = "Alumnos"
        '
        'Guna2HtmlLabel5
        '
        Me.Guna2HtmlLabel5.BackColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel5.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!)
        Me.Guna2HtmlLabel5.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel5.Location = New System.Drawing.Point(22, 327)
        Me.Guna2HtmlLabel5.Name = "Guna2HtmlLabel5"
        Me.Guna2HtmlLabel5.Size = New System.Drawing.Size(61, 20)
        Me.Guna2HtmlLabel5.TabIndex = 19
        Me.Guna2HtmlLabel5.Text = "Dirección"
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!)
        Me.Guna2HtmlLabel4.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(22, 271)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(59, 20)
        Me.Guna2HtmlLabel4.TabIndex = 18
        Me.Guna2HtmlLabel4.Text = "Telefono"
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!)
        Me.Guna2HtmlLabel3.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(22, 215)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(28, 20)
        Me.Guna2HtmlLabel3.TabIndex = 17
        Me.Guna2HtmlLabel3.Text = "DNI"
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!)
        Me.Guna2HtmlLabel2.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(22, 159)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(57, 20)
        Me.Guna2HtmlLabel2.TabIndex = 16
        Me.Guna2HtmlLabel2.Text = "Apellido"
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!)
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(22, 103)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(57, 20)
        Me.Guna2HtmlLabel1.TabIndex = 15
        Me.Guna2HtmlLabel1.Text = "Nombre"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!)
        Me.Label6.ForeColor = System.Drawing.Color.MediumAquamarine
        Me.Label6.Location = New System.Drawing.Point(24, 57)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 21)
        Me.Label6.TabIndex = 48
        Me.Label6.Text = "Alumnos"
        '
        'Dgv_ListaCarreras
        '
        Me.Dgv_ListaCarreras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_ListaCarreras.Location = New System.Drawing.Point(350, 90)
        Me.Dgv_ListaCarreras.Name = "Dgv_ListaCarreras"
        Me.Dgv_ListaCarreras.Size = New System.Drawing.Size(251, 320)
        Me.Dgv_ListaCarreras.TabIndex = 51
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.MediumAquamarine
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!)
        Me.Button1.Location = New System.Drawing.Point(570, 52)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(30, 30)
        Me.Button1.TabIndex = 50
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.MediumAquamarine
        Me.Panel2.Controls.Add(Me.PnlBotones)
        Me.Panel2.Controls.Add(Me.LbltitulofrmInstitucion)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(630, 38)
        Me.Panel2.TabIndex = 98
        '
        'PnlBotones
        '
        Me.PnlBotones.BackColor = System.Drawing.Color.Transparent
        Me.PnlBotones.Controls.Add(Me.BtnMinimizar)
        Me.PnlBotones.Controls.Add(Me.BtnMaximizar)
        Me.PnlBotones.Controls.Add(Me.BtnCerrar)
        Me.PnlBotones.Dock = System.Windows.Forms.DockStyle.Right
        Me.PnlBotones.Location = New System.Drawing.Point(512, 0)
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
        Me.LbltitulofrmInstitucion.Size = New System.Drawing.Size(210, 38)
        Me.LbltitulofrmInstitucion.TabIndex = 67
        Me.LbltitulofrmInstitucion.Text = "Buscar alumno"
        Me.LbltitulofrmInstitucion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(28, 90)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(251, 320)
        Me.DataGridView1.TabIndex = 51
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.MediumAquamarine
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!)
        Me.Button2.Location = New System.Drawing.Point(300, 215)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(30, 30)
        Me.Button2.TabIndex = 50
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.MediumAquamarine
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!)
        Me.Button3.Location = New System.Drawing.Point(300, 264)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(30, 30)
        Me.Button3.TabIndex = 50
        Me.Button3.UseVisualStyleBackColor = False
        '
        'BtnGuardar
        '
        Me.BtnGuardar.BackColor = System.Drawing.Color.MediumAquamarine
        Me.BtnGuardar.FlatAppearance.BorderSize = 0
        Me.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGuardar.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!)
        Me.BtnGuardar.ForeColor = System.Drawing.Color.White
        Me.BtnGuardar.Location = New System.Drawing.Point(384, 427)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(100, 35)
        Me.BtnGuardar.TabIndex = 121
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
        Me.BtnDescartar.Location = New System.Drawing.Point(501, 427)
        Me.BtnDescartar.Name = "BtnDescartar"
        Me.BtnDescartar.Size = New System.Drawing.Size(100, 35)
        Me.BtnDescartar.TabIndex = 120
        Me.BtnDescartar.Text = "Descartar"
        Me.BtnDescartar.UseVisualStyleBackColor = False
        '
        'FrmAgregarAlumno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(630, 503)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.BtnDescartar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Dgv_ListaCarreras)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmAgregarAlumno"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        CType(Me.Dgv_ListaCarreras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.PnlBotones.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2HtmlLabel6 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Label6 As Label
    Friend WithEvents Dgv_ListaCarreras As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PnlBotones As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents BtnMinimizar As Button
    Friend WithEvents BtnMaximizar As Button
    Friend WithEvents BtnCerrar As Button
    Friend WithEvents LbltitulofrmInstitucion As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnDescartar As Button
End Class
