<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAgregarMateria
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAgregarMateria))
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblNombreMateria = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.LbltitulofrmMateria = New System.Windows.Forms.Label()
        Me.PnlMateria = New System.Windows.Forms.Panel()
        Me.Panel2.SuspendLayout()
        Me.PnlMateria.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnGuardar.FlatAppearance.BorderSize = 0
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.btnGuardar.ForeColor = System.Drawing.Color.White
        Me.btnGuardar.Location = New System.Drawing.Point(199, 208)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(117, 30)
        Me.btnGuardar.TabIndex = 9
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'TxtNombre
        '
        Me.TxtNombre.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtNombre.BackColor = System.Drawing.Color.Gray
        Me.TxtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtNombre.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombre.ForeColor = System.Drawing.Color.White
        Me.TxtNombre.Location = New System.Drawing.Point(131, 119)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(332, 20)
        Me.TxtNombre.TabIndex = 1
        Me.TxtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel3
        '
        Me.Panel3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(131, 139)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(332, 1)
        Me.Panel3.TabIndex = 158
        '
        'lblNombreMateria
        '
        Me.lblNombreMateria.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblNombreMateria.AutoSize = True
        Me.lblNombreMateria.BackColor = System.Drawing.Color.Transparent
        Me.lblNombreMateria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblNombreMateria.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.lblNombreMateria.ForeColor = System.Drawing.Color.White
        Me.lblNombreMateria.Location = New System.Drawing.Point(33, 120)
        Me.lblNombreMateria.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNombreMateria.Name = "lblNombreMateria"
        Me.lblNombreMateria.Size = New System.Drawing.Size(68, 20)
        Me.lblNombreMateria.TabIndex = 181
        Me.lblNombreMateria.Text = "Nombre"
        Me.lblNombreMateria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.BtnCerrar)
        Me.Panel2.Controls.Add(Me.LbltitulofrmMateria)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(518, 43)
        Me.Panel2.TabIndex = 183
        '
        'BtnCerrar
        '
        Me.BtnCerrar.BackColor = System.Drawing.Color.Transparent
        Me.BtnCerrar.Dock = System.Windows.Forms.DockStyle.Left
        Me.BtnCerrar.FlatAppearance.BorderSize = 0
        Me.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCerrar.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!)
        Me.BtnCerrar.Image = CType(resources.GetObject("BtnCerrar.Image"), System.Drawing.Image)
        Me.BtnCerrar.Location = New System.Drawing.Point(0, 0)
        Me.BtnCerrar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(35, 43)
        Me.BtnCerrar.TabIndex = 70
        Me.BtnCerrar.UseVisualStyleBackColor = False
        '
        'LbltitulofrmMateria
        '
        Me.LbltitulofrmMateria.BackColor = System.Drawing.Color.Gray
        Me.LbltitulofrmMateria.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LbltitulofrmMateria.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbltitulofrmMateria.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.LbltitulofrmMateria.Location = New System.Drawing.Point(0, 0)
        Me.LbltitulofrmMateria.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LbltitulofrmMateria.Name = "LbltitulofrmMateria"
        Me.LbltitulofrmMateria.Size = New System.Drawing.Size(518, 43)
        Me.LbltitulofrmMateria.TabIndex = 71
        Me.LbltitulofrmMateria.Text = "Agregar Materia"
        Me.LbltitulofrmMateria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PnlMateria
        '
        Me.PnlMateria.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PnlMateria.BackColor = System.Drawing.Color.Gray
        Me.PnlMateria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlMateria.Controls.Add(Me.Panel2)
        Me.PnlMateria.Controls.Add(Me.lblNombreMateria)
        Me.PnlMateria.Controls.Add(Me.Panel3)
        Me.PnlMateria.Controls.Add(Me.TxtNombre)
        Me.PnlMateria.Controls.Add(Me.btnGuardar)
        Me.PnlMateria.Location = New System.Drawing.Point(34, 37)
        Me.PnlMateria.Name = "PnlMateria"
        Me.PnlMateria.Size = New System.Drawing.Size(520, 265)
        Me.PnlMateria.TabIndex = 158
        '
        'FrmAgregarMateria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(593, 340)
        Me.Controls.Add(Me.PnlMateria)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmAgregarMateria"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FrmAgregarMateria"
        Me.Panel2.ResumeLayout(False)
        Me.PnlMateria.ResumeLayout(False)
        Me.PnlMateria.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnGuardar As Button
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblNombreMateria As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BtnCerrar As Button
    Friend WithEvents LbltitulofrmMateria As Label
    Friend WithEvents PnlMateria As Panel
End Class
