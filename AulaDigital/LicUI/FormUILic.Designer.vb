<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUILic
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
        Me.Licensing1 = New Guna.UI.Licensing.Licensing()
        Me.SuspendLayout()
        '
        'Licensing1
        '
        Me.Licensing1.BackColor = System.Drawing.Color.White
        Me.Licensing1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.Licensing1.Location = New System.Drawing.Point(12, -17)
        Me.Licensing1.MaximumSize = New System.Drawing.Size(348, 485)
        Me.Licensing1.MinimumSize = New System.Drawing.Size(348, 485)
        Me.Licensing1.Name = "Licensing1"
        Me.Licensing1.Size = New System.Drawing.Size(348, 485)
        Me.Licensing1.TabIndex = 0
        '
        'FormUILic
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(376, 480)
        Me.Controls.Add(Me.Licensing1)
        Me.Name = "FormUILic"
        Me.Text = "FormUILic"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Licensing1 As Guna.UI.Licensing.Licensing
End Class
