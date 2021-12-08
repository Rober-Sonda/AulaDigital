<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmUsuario
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
        Me.LblUsuario = New System.Windows.Forms.Label()
        Me.LblContrasena = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.LblRepetir = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.TxtRepetir = New System.Windows.Forms.TextBox()
        Me.TxtContrasena = New System.Windows.Forms.TextBox()
        Me.TxtUsuario = New System.Windows.Forms.TextBox()
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LblUsuario
        '
        Me.LblUsuario.AutoSize = True
        Me.LblUsuario.BackColor = System.Drawing.Color.Transparent
        Me.LblUsuario.Font = New System.Drawing.Font("Berlin Sans FB", 15.75!)
        Me.LblUsuario.Location = New System.Drawing.Point(166, 28)
        Me.LblUsuario.Name = "LblUsuario"
        Me.LblUsuario.Size = New System.Drawing.Size(76, 23)
        Me.LblUsuario.TabIndex = 27
        Me.LblUsuario.Text = "Usuario"
        '
        'LblContrasena
        '
        Me.LblContrasena.BackColor = System.Drawing.Color.Transparent
        Me.LblContrasena.Font = New System.Drawing.Font("Berlin Sans FB", 15.75!)
        Me.LblContrasena.Location = New System.Drawing.Point(153, 100)
        Me.LblContrasena.Name = "LblContrasena"
        Me.LblContrasena.Size = New System.Drawing.Size(102, 25)
        Me.LblContrasena.TabIndex = 20
        Me.LblContrasena.Text = "Contraseña"
        '
        'LblRepetir
        '
        Me.LblRepetir.BackColor = System.Drawing.Color.Transparent
        Me.LblRepetir.Font = New System.Drawing.Font("Berlin Sans FB", 15.75!)
        Me.LblRepetir.Location = New System.Drawing.Point(122, 174)
        Me.LblRepetir.Name = "LblRepetir"
        Me.LblRepetir.Size = New System.Drawing.Size(165, 25)
        Me.LblRepetir.TabIndex = 24
        Me.LblRepetir.Text = "Repetir contraseña"
        '
        'TxtRepetir
        '
        Me.TxtRepetir.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtRepetir.Location = New System.Drawing.Point(67, 209)
        Me.TxtRepetir.Name = "TxtRepetir"
        Me.TxtRepetir.Size = New System.Drawing.Size(274, 29)
        Me.TxtRepetir.TabIndex = 101
        '
        'TxtContrasena
        '
        Me.TxtContrasena.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtContrasena.Location = New System.Drawing.Point(67, 135)
        Me.TxtContrasena.Name = "TxtContrasena"
        Me.TxtContrasena.Size = New System.Drawing.Size(274, 29)
        Me.TxtContrasena.TabIndex = 102
        '
        'TxtUsuario
        '
        Me.TxtUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUsuario.Location = New System.Drawing.Point(67, 61)
        Me.TxtUsuario.Name = "TxtUsuario"
        Me.TxtUsuario.Size = New System.Drawing.Size(274, 29)
        Me.TxtUsuario.TabIndex = 103
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnAceptar.BackColor = System.Drawing.Color.MediumAquamarine
        Me.BtnAceptar.FlatAppearance.BorderSize = 0
        Me.BtnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAceptar.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!)
        Me.BtnAceptar.ForeColor = System.Drawing.Color.White
        Me.BtnAceptar.Location = New System.Drawing.Point(170, 261)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(100, 35)
        Me.BtnAceptar.TabIndex = 116
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = False
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCancelar.BackColor = System.Drawing.Color.MediumAquamarine
        Me.BtnCancelar.FlatAppearance.BorderSize = 0
        Me.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancelar.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!)
        Me.BtnCancelar.ForeColor = System.Drawing.Color.White
        Me.BtnCancelar.Location = New System.Drawing.Point(282, 261)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(100, 35)
        Me.BtnCancelar.TabIndex = 115
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = False
        '
        'FrmUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(394, 305)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.TxtRepetir)
        Me.Controls.Add(Me.TxtContrasena)
        Me.Controls.Add(Me.TxtUsuario)
        Me.Controls.Add(Me.LblUsuario)
        Me.Controls.Add(Me.LblContrasena)
        Me.Controls.Add(Me.LblRepetir)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmUsuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblUsuario As Label
    Friend WithEvents LblContrasena As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents LblRepetir As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents TxtRepetir As TextBox
    Friend WithEvents TxtContrasena As TextBox
    Friend WithEvents TxtUsuario As TextBox
    Friend WithEvents BtnAceptar As Button
    Friend WithEvents BtnCancelar As Button
End Class
