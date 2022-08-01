<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTelCel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTelCel))
        Me.PnlInstitucion = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.Lbltelcel = New System.Windows.Forms.Label()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TxtCodArea = New System.Windows.Forms.TextBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.TxtTelCel = New System.Windows.Forms.TextBox()
        Me.PnlInstitucion.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlInstitucion
        '
        Me.PnlInstitucion.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PnlInstitucion.BackColor = System.Drawing.Color.FloralWhite
        Me.PnlInstitucion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlInstitucion.Controls.Add(Me.Panel1)
        Me.PnlInstitucion.Controls.Add(Me.TxtCodArea)
        Me.PnlInstitucion.Controls.Add(Me.Panel5)
        Me.PnlInstitucion.Controls.Add(Me.TxtTelCel)
        Me.PnlInstitucion.Controls.Add(Me.Panel2)
        Me.PnlInstitucion.Controls.Add(Me.btnGuardar)
        Me.PnlInstitucion.Location = New System.Drawing.Point(32, 6)
        Me.PnlInstitucion.Name = "PnlInstitucion"
        Me.PnlInstitucion.Size = New System.Drawing.Size(409, 188)
        Me.PnlInstitucion.TabIndex = 181
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.BtnCerrar)
        Me.Panel2.Controls.Add(Me.Lbltelcel)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(407, 43)
        Me.Panel2.TabIndex = 183
        '
        'BtnCerrar
        '
        Me.BtnCerrar.BackColor = System.Drawing.Color.FloralWhite
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
        'Lbltelcel
        '
        Me.Lbltelcel.BackColor = System.Drawing.Color.FloralWhite
        Me.Lbltelcel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Lbltelcel.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbltelcel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Lbltelcel.Location = New System.Drawing.Point(0, 0)
        Me.Lbltelcel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbltelcel.Name = "Lbltelcel"
        Me.Lbltelcel.Size = New System.Drawing.Size(407, 43)
        Me.Lbltelcel.TabIndex = 71
        Me.Lbltelcel.Text = "Teléfono / Celular"
        Me.Lbltelcel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnGuardar.FlatAppearance.BorderSize = 0
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.btnGuardar.ForeColor = System.Drawing.Color.White
        Me.btnGuardar.Location = New System.Drawing.Point(143, 135)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(117, 30)
        Me.btnGuardar.TabIndex = 9
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(38, 100)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(99, 1)
        Me.Panel1.TabIndex = 187
        '
        'TxtCodArea
        '
        Me.TxtCodArea.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtCodArea.BackColor = System.Drawing.Color.FloralWhite
        Me.TxtCodArea.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtCodArea.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCodArea.ForeColor = System.Drawing.Color.Black
        Me.TxtCodArea.Location = New System.Drawing.Point(38, 80)
        Me.TxtCodArea.Name = "TxtCodArea"
        Me.TxtCodArea.Size = New System.Drawing.Size(99, 20)
        Me.TxtCodArea.TabIndex = 1
        Me.TxtCodArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel5
        '
        Me.Panel5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Panel5.Location = New System.Drawing.Point(143, 100)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(238, 1)
        Me.Panel5.TabIndex = 185
        '
        'TxtTelCel
        '
        Me.TxtTelCel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtTelCel.BackColor = System.Drawing.Color.FloralWhite
        Me.TxtTelCel.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTelCel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTelCel.ForeColor = System.Drawing.Color.Black
        Me.TxtTelCel.Location = New System.Drawing.Point(143, 80)
        Me.TxtTelCel.Name = "TxtTelCel"
        Me.TxtTelCel.Size = New System.Drawing.Size(238, 20)
        Me.TxtTelCel.TabIndex = 2
        Me.TxtTelCel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FrmTelCel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(476, 202)
        Me.Controls.Add(Me.PnlInstitucion)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmTelCel"
        Me.Text = "FrmTelCel"
        Me.PnlInstitucion.ResumeLayout(False)
        Me.PnlInstitucion.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlInstitucion As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TxtCodArea As TextBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents TxtTelCel As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BtnCerrar As Button
    Friend WithEvents Lbltelcel As Label
    Friend WithEvents btnGuardar As Button
End Class
