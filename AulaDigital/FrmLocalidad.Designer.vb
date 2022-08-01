<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLocalidad
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLocalidad))
        Me.PnlLocalidad = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TxtCPostal = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TxtNombreLocalidad = New System.Windows.Forms.TextBox()
        Me.BtnGuardarLocalidad = New System.Windows.Forms.Button()
        Me.lblCPostal = New System.Windows.Forms.Label()
        Me.lblLocalidad = New System.Windows.Forms.Label()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BtnDescartar = New System.Windows.Forms.Button()
        Me.PnlLocalidad.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlLocalidad
        '
        Me.PnlLocalidad.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PnlLocalidad.BackColor = System.Drawing.Color.FloralWhite
        Me.PnlLocalidad.Controls.Add(Me.Panel2)
        Me.PnlLocalidad.Controls.Add(Me.TxtCPostal)
        Me.PnlLocalidad.Controls.Add(Me.Panel3)
        Me.PnlLocalidad.Controls.Add(Me.TxtNombreLocalidad)
        Me.PnlLocalidad.Controls.Add(Me.BtnGuardarLocalidad)
        Me.PnlLocalidad.Controls.Add(Me.lblCPostal)
        Me.PnlLocalidad.Controls.Add(Me.lblLocalidad)
        Me.PnlLocalidad.Controls.Add(Me.Panel12)
        Me.PnlLocalidad.Location = New System.Drawing.Point(30, 8)
        Me.PnlLocalidad.Name = "PnlLocalidad"
        Me.PnlLocalidad.Size = New System.Drawing.Size(410, 223)
        Me.PnlLocalidad.TabIndex = 134
        '
        'Panel2
        '
        Me.Panel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(121, 150)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(103, 1)
        Me.Panel2.TabIndex = 199
        '
        'TxtCPostal
        '
        Me.TxtCPostal.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtCPostal.BackColor = System.Drawing.Color.FloralWhite
        Me.TxtCPostal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtCPostal.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCPostal.ForeColor = System.Drawing.Color.White
        Me.TxtCPostal.Location = New System.Drawing.Point(121, 130)
        Me.TxtCPostal.Name = "TxtCPostal"
        Me.TxtCPostal.Size = New System.Drawing.Size(103, 20)
        Me.TxtCPostal.TabIndex = 198
        Me.TxtCPostal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel3
        '
        Me.Panel3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(121, 93)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(256, 1)
        Me.Panel3.TabIndex = 197
        '
        'TxtNombreLocalidad
        '
        Me.TxtNombreLocalidad.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtNombreLocalidad.BackColor = System.Drawing.Color.FloralWhite
        Me.TxtNombreLocalidad.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtNombreLocalidad.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombreLocalidad.ForeColor = System.Drawing.Color.White
        Me.TxtNombreLocalidad.Location = New System.Drawing.Point(121, 73)
        Me.TxtNombreLocalidad.Name = "TxtNombreLocalidad"
        Me.TxtNombreLocalidad.Size = New System.Drawing.Size(256, 20)
        Me.TxtNombreLocalidad.TabIndex = 196
        Me.TxtNombreLocalidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnGuardarLocalidad
        '
        Me.BtnGuardarLocalidad.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.BtnGuardarLocalidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.BtnGuardarLocalidad.FlatAppearance.BorderSize = 0
        Me.BtnGuardarLocalidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGuardarLocalidad.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.BtnGuardarLocalidad.ForeColor = System.Drawing.Color.White
        Me.BtnGuardarLocalidad.Location = New System.Drawing.Point(147, 178)
        Me.BtnGuardarLocalidad.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnGuardarLocalidad.Name = "BtnGuardarLocalidad"
        Me.BtnGuardarLocalidad.Size = New System.Drawing.Size(117, 30)
        Me.BtnGuardarLocalidad.TabIndex = 195
        Me.BtnGuardarLocalidad.Text = "Guardar"
        Me.BtnGuardarLocalidad.UseVisualStyleBackColor = False
        '
        'lblCPostal
        '
        Me.lblCPostal.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblCPostal.AutoSize = True
        Me.lblCPostal.BackColor = System.Drawing.Color.Transparent
        Me.lblCPostal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblCPostal.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.lblCPostal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.lblCPostal.Location = New System.Drawing.Point(29, 131)
        Me.lblCPostal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCPostal.Name = "lblCPostal"
        Me.lblCPostal.Size = New System.Drawing.Size(68, 20)
        Me.lblCPostal.TabIndex = 192
        Me.lblCPostal.Text = "C.Postal"
        Me.lblCPostal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLocalidad
        '
        Me.lblLocalidad.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblLocalidad.AutoSize = True
        Me.lblLocalidad.BackColor = System.Drawing.Color.Transparent
        Me.lblLocalidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblLocalidad.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.lblLocalidad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.lblLocalidad.Location = New System.Drawing.Point(29, 74)
        Me.lblLocalidad.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLocalidad.Name = "lblLocalidad"
        Me.lblLocalidad.Size = New System.Drawing.Size(82, 20)
        Me.lblLocalidad.TabIndex = 191
        Me.lblLocalidad.Text = "Localidad"
        Me.lblLocalidad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.Color.Transparent
        Me.Panel12.Controls.Add(Me.BtnDescartar)
        Me.Panel12.Controls.Add(Me.Label6)
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel12.Location = New System.Drawing.Point(0, 0)
        Me.Panel12.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(410, 43)
        Me.Panel12.TabIndex = 133
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(0, 0)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(410, 43)
        Me.Label6.TabIndex = 71
        Me.Label6.Text = "Agregar localidad"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnDescartar
        '
        Me.BtnDescartar.BackColor = System.Drawing.Color.Transparent
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
        'FrmLocalidad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(473, 239)
        Me.Controls.Add(Me.PnlLocalidad)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmLocalidad"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FrmLocalidad"
        Me.PnlLocalidad.ResumeLayout(False)
        Me.PnlLocalidad.PerformLayout()
        Me.Panel12.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PnlLocalidad As Panel
    Friend WithEvents BtnGuardarLocalidad As Button
    Friend WithEvents lblCPostal As Label
    Friend WithEvents lblLocalidad As Label
    Friend WithEvents Panel12 As Panel
    Friend WithEvents BtnDescartar As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TxtCPostal As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TxtNombreLocalidad As TextBox
    Friend WithEvents Label6 As Label
End Class
