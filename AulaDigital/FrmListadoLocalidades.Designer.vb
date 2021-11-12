<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListadoLocalidades
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
        Me.DgvLocalidades = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PnlBotones = New Guna.UI2.WinForms.Guna2Panel()
        Me.BtnMinimizar = New System.Windows.Forms.Button()
        Me.BtnMaximizar = New System.Windows.Forms.Button()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.Lbllistadolocalidades = New System.Windows.Forms.Label()
        Me.BtnEliminarLocalidad = New System.Windows.Forms.Button()
        Me.BtnModificarLocalidad = New System.Windows.Forms.Button()
        Me.BtnAgregarLocalidad = New System.Windows.Forms.Button()
        Me.BtnListarLocalidades = New System.Windows.Forms.Button()
        CType(Me.DgvLocalidades, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.PnlBotones.SuspendLayout()
        Me.SuspendLayout()
        '
        'DgvLocalidades
        '
        Me.DgvLocalidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvLocalidades.Location = New System.Drawing.Point(29, 68)
        Me.DgvLocalidades.Name = "DgvLocalidades"
        Me.DgvLocalidades.Size = New System.Drawing.Size(759, 393)
        Me.DgvLocalidades.TabIndex = 117
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.MediumAquamarine
        Me.Panel2.Controls.Add(Me.PnlBotones)
        Me.Panel2.Controls.Add(Me.Lbllistadolocalidades)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(863, 38)
        Me.Panel2.TabIndex = 118
        '
        'PnlBotones
        '
        Me.PnlBotones.BackColor = System.Drawing.Color.Transparent
        Me.PnlBotones.Controls.Add(Me.BtnMinimizar)
        Me.PnlBotones.Controls.Add(Me.BtnMaximizar)
        Me.PnlBotones.Controls.Add(Me.BtnCerrar)
        Me.PnlBotones.Dock = System.Windows.Forms.DockStyle.Right
        Me.PnlBotones.Location = New System.Drawing.Point(745, 0)
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
        'Lbllistadolocalidades
        '
        Me.Lbllistadolocalidades.BackColor = System.Drawing.Color.Transparent
        Me.Lbllistadolocalidades.Dock = System.Windows.Forms.DockStyle.Left
        Me.Lbllistadolocalidades.Font = New System.Drawing.Font("Berlin Sans FB", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbllistadolocalidades.ForeColor = System.Drawing.Color.White
        Me.Lbllistadolocalidades.Location = New System.Drawing.Point(0, 0)
        Me.Lbllistadolocalidades.Name = "Lbllistadolocalidades"
        Me.Lbllistadolocalidades.Size = New System.Drawing.Size(273, 38)
        Me.Lbllistadolocalidades.TabIndex = 67
        Me.Lbllistadolocalidades.Text = "Listado de localidades"
        Me.Lbllistadolocalidades.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnEliminarLocalidad
        '
        Me.BtnEliminarLocalidad.BackColor = System.Drawing.Color.MediumAquamarine
        Me.BtnEliminarLocalidad.FlatAppearance.BorderSize = 0
        Me.BtnEliminarLocalidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEliminarLocalidad.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!)
        Me.BtnEliminarLocalidad.Location = New System.Drawing.Point(805, 318)
        Me.BtnEliminarLocalidad.Name = "BtnEliminarLocalidad"
        Me.BtnEliminarLocalidad.Size = New System.Drawing.Size(40, 40)
        Me.BtnEliminarLocalidad.TabIndex = 126
        Me.BtnEliminarLocalidad.UseVisualStyleBackColor = False
        '
        'BtnModificarLocalidad
        '
        Me.BtnModificarLocalidad.BackColor = System.Drawing.Color.MediumAquamarine
        Me.BtnModificarLocalidad.FlatAppearance.BorderSize = 0
        Me.BtnModificarLocalidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnModificarLocalidad.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!)
        Me.BtnModificarLocalidad.Location = New System.Drawing.Point(805, 258)
        Me.BtnModificarLocalidad.Name = "BtnModificarLocalidad"
        Me.BtnModificarLocalidad.Size = New System.Drawing.Size(40, 40)
        Me.BtnModificarLocalidad.TabIndex = 125
        Me.BtnModificarLocalidad.UseVisualStyleBackColor = False
        '
        'BtnAgregarLocalidad
        '
        Me.BtnAgregarLocalidad.BackColor = System.Drawing.Color.MediumAquamarine
        Me.BtnAgregarLocalidad.FlatAppearance.BorderSize = 0
        Me.BtnAgregarLocalidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAgregarLocalidad.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!)
        Me.BtnAgregarLocalidad.Location = New System.Drawing.Point(805, 203)
        Me.BtnAgregarLocalidad.Name = "BtnAgregarLocalidad"
        Me.BtnAgregarLocalidad.Size = New System.Drawing.Size(40, 40)
        Me.BtnAgregarLocalidad.TabIndex = 123
        Me.BtnAgregarLocalidad.UseVisualStyleBackColor = False
        '
        'BtnListarLocalidades
        '
        Me.BtnListarLocalidades.BackColor = System.Drawing.Color.MediumAquamarine
        Me.BtnListarLocalidades.FlatAppearance.BorderSize = 0
        Me.BtnListarLocalidades.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnListarLocalidades.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!)
        Me.BtnListarLocalidades.Location = New System.Drawing.Point(805, 148)
        Me.BtnListarLocalidades.Name = "BtnListarLocalidades"
        Me.BtnListarLocalidades.Size = New System.Drawing.Size(40, 40)
        Me.BtnListarLocalidades.TabIndex = 124
        Me.BtnListarLocalidades.UseVisualStyleBackColor = False
        '
        'FrmListadoLocalidades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(863, 487)
        Me.Controls.Add(Me.BtnEliminarLocalidad)
        Me.Controls.Add(Me.BtnModificarLocalidad)
        Me.Controls.Add(Me.BtnAgregarLocalidad)
        Me.Controls.Add(Me.BtnListarLocalidades)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.DgvLocalidades)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmListadoLocalidades"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FrmListadoLocalidades"
        CType(Me.DgvLocalidades, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.PnlBotones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DgvLocalidades As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PnlBotones As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents BtnMinimizar As Button
    Friend WithEvents BtnMaximizar As Button
    Friend WithEvents BtnCerrar As Button
    Friend WithEvents Lbllistadolocalidades As Label
    Friend WithEvents BtnEliminarLocalidad As Button
    Friend WithEvents BtnModificarLocalidad As Button
    Friend WithEvents BtnAgregarLocalidad As Button
    Friend WithEvents BtnListarLocalidades As Button
End Class
