<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmInformacion
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
        Me.DgvInformacionPrincipal = New System.Windows.Forms.DataGridView()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.Btn = New System.Windows.Forms.Button()
        CType(Me.DgvInformacionPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgvInformacionPrincipal
        '
        Me.DgvInformacionPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvInformacionPrincipal.Location = New System.Drawing.Point(30, 62)
        Me.DgvInformacionPrincipal.Name = "DgvInformacionPrincipal"
        Me.DgvInformacionPrincipal.Size = New System.Drawing.Size(730, 390)
        Me.DgvInformacionPrincipal.TabIndex = 123
        '
        'BtnEliminar
        '
        Me.BtnEliminar.BackColor = System.Drawing.Color.MediumAquamarine
        Me.BtnEliminar.FlatAppearance.BorderSize = 0
        Me.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEliminar.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!)
        Me.BtnEliminar.Location = New System.Drawing.Point(798, 317)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(40, 40)
        Me.BtnEliminar.TabIndex = 122
        Me.BtnEliminar.UseVisualStyleBackColor = False
        '
        'BtnModificar
        '
        Me.BtnModificar.BackColor = System.Drawing.Color.MediumAquamarine
        Me.BtnModificar.FlatAppearance.BorderSize = 0
        Me.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnModificar.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!)
        Me.BtnModificar.Location = New System.Drawing.Point(798, 261)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(40, 40)
        Me.BtnModificar.TabIndex = 121
        Me.BtnModificar.UseVisualStyleBackColor = False
        '
        'BtnNuevo
        '
        Me.BtnNuevo.BackColor = System.Drawing.Color.MediumAquamarine
        Me.BtnNuevo.FlatAppearance.BorderSize = 0
        Me.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNuevo.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!)
        Me.BtnNuevo.Location = New System.Drawing.Point(798, 204)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(40, 40)
        Me.BtnNuevo.TabIndex = 119
        Me.BtnNuevo.UseVisualStyleBackColor = False
        '
        'Btn
        '
        Me.Btn.BackColor = System.Drawing.Color.MediumAquamarine
        Me.Btn.FlatAppearance.BorderSize = 0
        Me.Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!)
        Me.Btn.Location = New System.Drawing.Point(798, 147)
        Me.Btn.Name = "Btn"
        Me.Btn.Size = New System.Drawing.Size(40, 40)
        Me.Btn.TabIndex = 120
        Me.Btn.UseVisualStyleBackColor = False
        '
        'FrmInformacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(868, 478)
        Me.Controls.Add(Me.DgvInformacionPrincipal)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnModificar)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.Btn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmInformacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        CType(Me.DgvInformacionPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DgvInformacionPrincipal As DataGridView
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnModificar As Button
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents Btn As Button
End Class
