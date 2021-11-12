<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmIniciar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmIniciar))
        Me.LblUsuario = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.LblNombre = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.LblContrasena = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.LblOlvido = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.TxtContrasena = New Guna.UI2.WinForms.Guna2TextBox()
        Me.PtbLogo = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.BtnAceptar = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnCancelar = New Guna.UI2.WinForms.Guna2Button()
        Me.LblIniciar = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.PnlBarra = New Guna.UI2.WinForms.Guna2Panel()
        CType(Me.PtbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlBarra.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblUsuario
        '
        Me.LblUsuario.BackColor = System.Drawing.Color.Transparent
        Me.LblUsuario.Font = New System.Drawing.Font("Berlin Sans FB", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUsuario.ForeColor = System.Drawing.Color.White
        Me.LblUsuario.Location = New System.Drawing.Point(111, 65)
        Me.LblUsuario.Name = "LblUsuario"
        Me.LblUsuario.Size = New System.Drawing.Size(74, 25)
        Me.LblUsuario.TabIndex = 0
        Me.LblUsuario.Text = "Usuario:"
        '
        'LblNombre
        '
        Me.LblNombre.BackColor = System.Drawing.Color.Transparent
        Me.LblNombre.Font = New System.Drawing.Font("Berlin Sans FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNombre.ForeColor = System.Drawing.Color.White
        Me.LblNombre.Location = New System.Drawing.Point(190, 65)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(61, 28)
        Me.LblNombre.TabIndex = 1
        Me.LblNombre.Text = "Angie"
        '
        'LblContrasena
        '
        Me.LblContrasena.BackColor = System.Drawing.Color.Transparent
        Me.LblContrasena.Font = New System.Drawing.Font("Berlin Sans FB", 15.75!)
        Me.LblContrasena.Location = New System.Drawing.Point(129, 115)
        Me.LblContrasena.Name = "LblContrasena"
        Me.LblContrasena.Size = New System.Drawing.Size(102, 25)
        Me.LblContrasena.TabIndex = 2
        Me.LblContrasena.Text = "Contraseña"
        '
        'LblOlvido
        '
        Me.LblOlvido.BackColor = System.Drawing.Color.Transparent
        Me.LblOlvido.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblOlvido.ForeColor = System.Drawing.Color.SteelBlue
        Me.LblOlvido.Location = New System.Drawing.Point(269, 197)
        Me.LblOlvido.Name = "LblOlvido"
        Me.LblOlvido.Size = New System.Drawing.Size(168, 20)
        Me.LblOlvido.TabIndex = 3
        Me.LblOlvido.Text = "¿Olvidaste tu contraseña? "
        '
        'TxtContrasena
        '
        Me.TxtContrasena.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtContrasena.DefaultText = ""
        Me.TxtContrasena.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtContrasena.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtContrasena.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtContrasena.DisabledState.Parent = Me.TxtContrasena
        Me.TxtContrasena.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtContrasena.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtContrasena.FocusedState.Parent = Me.TxtContrasena
        Me.TxtContrasena.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtContrasena.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtContrasena.HoverState.Parent = Me.TxtContrasena
        Me.TxtContrasena.Location = New System.Drawing.Point(214, 149)
        Me.TxtContrasena.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtContrasena.Name = "TxtContrasena"
        Me.TxtContrasena.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtContrasena.PlaceholderText = ""
        Me.TxtContrasena.SelectedText = ""
        Me.TxtContrasena.ShadowDecoration.Parent = Me.TxtContrasena
        Me.TxtContrasena.Size = New System.Drawing.Size(281, 30)
        Me.TxtContrasena.TabIndex = 5
        '
        'PtbLogo
        '
        Me.PtbLogo.BackColor = System.Drawing.Color.Transparent
        Me.PtbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PtbLogo.Dock = System.Windows.Forms.DockStyle.Left
        Me.PtbLogo.Image = CType(resources.GetObject("PtbLogo.Image"), System.Drawing.Image)
        Me.PtbLogo.ImageRotate = 0!
        Me.PtbLogo.Location = New System.Drawing.Point(0, 0)
        Me.PtbLogo.Name = "PtbLogo"
        Me.PtbLogo.ShadowDecoration.Parent = Me.PtbLogo
        Me.PtbLogo.Size = New System.Drawing.Size(175, 341)
        Me.PtbLogo.TabIndex = 6
        Me.PtbLogo.TabStop = False
        '
        'BtnAceptar
        '
        Me.BtnAceptar.CheckedState.Parent = Me.BtnAceptar
        Me.BtnAceptar.CustomImages.Parent = Me.BtnAceptar
        Me.BtnAceptar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnAceptar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnAceptar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnAceptar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnAceptar.DisabledState.Parent = Me.BtnAceptar
        Me.BtnAceptar.FillColor = System.Drawing.Color.MediumAquamarine
        Me.BtnAceptar.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAceptar.ForeColor = System.Drawing.Color.White
        Me.BtnAceptar.HoverState.Parent = Me.BtnAceptar
        Me.BtnAceptar.Location = New System.Drawing.Point(214, 279)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.ShadowDecoration.Parent = Me.BtnAceptar
        Me.BtnAceptar.Size = New System.Drawing.Size(100, 35)
        Me.BtnAceptar.TabIndex = 7
        Me.BtnAceptar.Text = "Aceptar"
        '
        'BtnCancelar
        '
        Me.BtnCancelar.CheckedState.Parent = Me.BtnCancelar
        Me.BtnCancelar.CustomImages.Parent = Me.BtnCancelar
        Me.BtnCancelar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnCancelar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnCancelar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnCancelar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnCancelar.DisabledState.Parent = Me.BtnCancelar
        Me.BtnCancelar.FillColor = System.Drawing.Color.MediumAquamarine
        Me.BtnCancelar.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.ForeColor = System.Drawing.Color.White
        Me.BtnCancelar.HoverState.Parent = Me.BtnCancelar
        Me.BtnCancelar.Location = New System.Drawing.Point(395, 279)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.ShadowDecoration.Parent = Me.BtnCancelar
        Me.BtnCancelar.Size = New System.Drawing.Size(100, 35)
        Me.BtnCancelar.TabIndex = 8
        Me.BtnCancelar.Text = "Cancelar"
        '
        'LblIniciar
        '
        Me.LblIniciar.BackColor = System.Drawing.Color.Transparent
        Me.LblIniciar.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblIniciar.ForeColor = System.Drawing.Color.Gainsboro
        Me.LblIniciar.Location = New System.Drawing.Point(138, 6)
        Me.LblIniciar.Name = "LblIniciar"
        Me.LblIniciar.Size = New System.Drawing.Size(82, 20)
        Me.LblIniciar.TabIndex = 9
        Me.LblIniciar.Text = "Iniciar seción"
        '
        'PnlBarra
        '
        Me.PnlBarra.BackgroundImage = CType(resources.GetObject("PnlBarra.BackgroundImage"), System.Drawing.Image)
        Me.PnlBarra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PnlBarra.Controls.Add(Me.LblNombre)
        Me.PnlBarra.Controls.Add(Me.LblIniciar)
        Me.PnlBarra.Controls.Add(Me.LblUsuario)
        Me.PnlBarra.Controls.Add(Me.LblContrasena)
        Me.PnlBarra.Location = New System.Drawing.Point(172, 0)
        Me.PnlBarra.Name = "PnlBarra"
        Me.PnlBarra.ShadowDecoration.Parent = Me.PnlBarra
        Me.PnlBarra.Size = New System.Drawing.Size(357, 167)
        Me.PnlBarra.TabIndex = 10
        '
        'FrmIniciar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(527, 341)
        Me.Controls.Add(Me.LblOlvido)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.PtbLogo)
        Me.Controls.Add(Me.TxtContrasena)
        Me.Controls.Add(Me.PnlBarra)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmIniciar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PtbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlBarra.ResumeLayout(False)
        Me.PnlBarra.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblUsuario As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents LblNombre As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents LblContrasena As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents LblOlvido As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents TxtContrasena As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents PtbLogo As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents BtnAceptar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnCancelar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents LblIniciar As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents PnlBarra As Guna.UI2.WinForms.Guna2Panel
End Class
