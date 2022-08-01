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
        Me.BtnEliminarLocalidad = New System.Windows.Forms.Button()
        Me.BtnModificarLocalidad = New System.Windows.Forms.Button()
        Me.BtnAgregarLocalidad = New System.Windows.Forms.Button()
        Me.BtnListarLocalidades = New System.Windows.Forms.Button()
        CType(Me.DgvLocalidades, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Controls.Add(Me.DgvLocalidades)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmListadoLocalidades"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FrmListadoLocalidades"
        CType(Me.DgvLocalidades, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DgvLocalidades As DataGridView
    Friend WithEvents BtnEliminarLocalidad As Button
    Friend WithEvents BtnModificarLocalidad As Button
    Friend WithEvents BtnAgregarLocalidad As Button
    Friend WithEvents BtnListarLocalidades As Button
End Class
