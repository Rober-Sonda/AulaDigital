﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Dgv_ListaMaterias = New System.Windows.Forms.DataGridView()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PnlBotones = New Guna.UI2.WinForms.Guna2Panel()
        Me.BtnMinimizar = New System.Windows.Forms.Button()
        Me.BtnMaximizar = New System.Windows.Forms.Button()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.LbltitulofrmCarrera = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.BtnBorrar = New System.Windows.Forms.Button()
        Me.CmbNombre = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.CmbFecha = New System.Windows.Forms.ComboBox()
        Me.TxtDesde = New System.Windows.Forms.TextBox()
        Me.TxtHasta = New System.Windows.Forms.TextBox()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.LblNombreCarrera = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.Dgv_ListaMaterias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.PnlBotones.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Dgv_ListaMaterias)
        Me.Panel1.Controls.Add(Me.BtnBuscar)
        Me.Panel1.Controls.Add(Me.TxtBuscar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(599, 38)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(353, 474)
        Me.Panel1.TabIndex = 61
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!)
        Me.Label4.ForeColor = System.Drawing.Color.MediumAquamarine
        Me.Label4.Location = New System.Drawing.Point(146, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 21)
        Me.Label4.TabIndex = 48
        Me.Label4.Text = "Materias"
        '
        'Dgv_ListaMaterias
        '
        Me.Dgv_ListaMaterias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_ListaMaterias.Location = New System.Drawing.Point(27, 84)
        Me.Dgv_ListaMaterias.Name = "Dgv_ListaMaterias"
        Me.Dgv_ListaMaterias.Size = New System.Drawing.Size(300, 355)
        Me.Dgv_ListaMaterias.TabIndex = 51
        '
        'BtnBuscar
        '
        Me.BtnBuscar.BackColor = System.Drawing.Color.MediumAquamarine
        Me.BtnBuscar.FlatAppearance.BorderSize = 0
        Me.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBuscar.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!)
        Me.BtnBuscar.Location = New System.Drawing.Point(297, 34)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(30, 30)
        Me.BtnBuscar.TabIndex = 50
        Me.BtnBuscar.UseVisualStyleBackColor = False
        '
        'TxtBuscar
        '
        Me.TxtBuscar.Location = New System.Drawing.Point(27, 34)
        Me.TxtBuscar.Multiline = True
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(264, 30)
        Me.TxtBuscar.TabIndex = 49
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.MediumAquamarine
        Me.Panel2.Controls.Add(Me.PnlBotones)
        Me.Panel2.Controls.Add(Me.LbltitulofrmCarrera)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(952, 38)
        Me.Panel2.TabIndex = 62
        '
        'PnlBotones
        '
        Me.PnlBotones.BackColor = System.Drawing.Color.Transparent
        Me.PnlBotones.Controls.Add(Me.BtnMinimizar)
        Me.PnlBotones.Controls.Add(Me.BtnMaximizar)
        Me.PnlBotones.Controls.Add(Me.BtnCerrar)
        Me.PnlBotones.Dock = System.Windows.Forms.DockStyle.Right
        Me.PnlBotones.Location = New System.Drawing.Point(834, 0)
        Me.PnlBotones.Name = "PnlBotones"
        Me.PnlBotones.ShadowDecoration.Parent = Me.PnlBotones
        Me.PnlBotones.Size = New System.Drawing.Size(118, 38)
        Me.PnlBotones.TabIndex = 29
        '
        'BtnMinimizar
        '
        Me.BtnMinimizar.BackColor = System.Drawing.Color.MediumAquamarine
        Me.BtnMinimizar.FlatAppearance.BorderSize = 0
        Me.BtnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMinimizar.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!)
        Me.BtnMinimizar.Location = New System.Drawing.Point(3, 3)
        Me.BtnMinimizar.Name = "BtnMinimizar"
        Me.BtnMinimizar.Size = New System.Drawing.Size(30, 30)
        Me.BtnMinimizar.TabIndex = 30
        Me.BtnMinimizar.Text = "M"
        Me.BtnMinimizar.UseVisualStyleBackColor = False
        '
        'BtnMaximizar
        '
        Me.BtnMaximizar.BackColor = System.Drawing.Color.MediumAquamarine
        Me.BtnMaximizar.FlatAppearance.BorderSize = 0
        Me.BtnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMaximizar.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!)
        Me.BtnMaximizar.Location = New System.Drawing.Point(39, 3)
        Me.BtnMaximizar.Name = "BtnMaximizar"
        Me.BtnMaximizar.Size = New System.Drawing.Size(30, 30)
        Me.BtnMaximizar.TabIndex = 30
        Me.BtnMaximizar.Text = "M"
        Me.BtnMaximizar.UseVisualStyleBackColor = False
        '
        'BtnCerrar
        '
        Me.BtnCerrar.BackColor = System.Drawing.Color.MediumAquamarine
        Me.BtnCerrar.FlatAppearance.BorderSize = 0
        Me.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCerrar.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!)
        Me.BtnCerrar.Location = New System.Drawing.Point(75, 3)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(30, 30)
        Me.BtnCerrar.TabIndex = 30
        Me.BtnCerrar.Text = "C"
        Me.BtnCerrar.UseVisualStyleBackColor = False
        '
        'LbltitulofrmCarrera
        '
        Me.LbltitulofrmCarrera.BackColor = System.Drawing.Color.Transparent
        Me.LbltitulofrmCarrera.Dock = System.Windows.Forms.DockStyle.Left
        Me.LbltitulofrmCarrera.Font = New System.Drawing.Font("Berlin Sans FB", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbltitulofrmCarrera.ForeColor = System.Drawing.Color.White
        Me.LbltitulofrmCarrera.Location = New System.Drawing.Point(0, 0)
        Me.LbltitulofrmCarrera.Name = "LbltitulofrmCarrera"
        Me.LbltitulofrmCarrera.Size = New System.Drawing.Size(140, 38)
        Me.LbltitulofrmCarrera.TabIndex = 67
        Me.LbltitulofrmCarrera.Text = "Materias"
        Me.LbltitulofrmCarrera.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.LblNombreCarrera)
        Me.Panel3.Controls.Add(Me.Button5)
        Me.Panel3.Controls.Add(Me.BtnAgregar)
        Me.Panel3.Controls.Add(Me.TxtHasta)
        Me.Panel3.Controls.Add(Me.TxtDesde)
        Me.Panel3.Controls.Add(Me.CmbFecha)
        Me.Panel3.Controls.Add(Me.ComboBox1)
        Me.Panel3.Controls.Add(Me.CmbNombre)
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Controls.Add(Me.Button2)
        Me.Panel3.Controls.Add(Me.Button3)
        Me.Panel3.Controls.Add(Me.BtnBorrar)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 38)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(593, 474)
        Me.Panel3.TabIndex = 82
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.MediumAquamarine
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(369, 404)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 35)
        Me.Button1.TabIndex = 64
        Me.Button1.Text = "Guardar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.MediumAquamarine
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!)
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(475, 404)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 35)
        Me.Button2.TabIndex = 61
        Me.Button2.Text = "Descartar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.MediumAquamarine
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!)
        Me.Button3.Location = New System.Drawing.Point(545, 58)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(30, 30)
        Me.Button3.TabIndex = 63
        Me.Button3.UseVisualStyleBackColor = False
        '
        'BtnBorrar
        '
        Me.BtnBorrar.BackColor = System.Drawing.Color.MediumAquamarine
        Me.BtnBorrar.FlatAppearance.BorderSize = 0
        Me.BtnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBorrar.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!)
        Me.BtnBorrar.Location = New System.Drawing.Point(545, 94)
        Me.BtnBorrar.Name = "BtnBorrar"
        Me.BtnBorrar.Size = New System.Drawing.Size(30, 30)
        Me.BtnBorrar.TabIndex = 62
        Me.BtnBorrar.UseVisualStyleBackColor = False
        '
        'CmbNombre
        '
        Me.CmbNombre.Font = New System.Drawing.Font("Berlin Sans FB", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbNombre.FormattingEnabled = True
        Me.CmbNombre.Location = New System.Drawing.Point(100, 58)
        Me.CmbNombre.Name = "CmbNombre"
        Me.CmbNombre.Size = New System.Drawing.Size(250, 31)
        Me.CmbNombre.TabIndex = 97
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Berlin Sans FB", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(97, 118)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(250, 31)
        Me.ComboBox1.TabIndex = 97
        '
        'CmbFecha
        '
        Me.CmbFecha.Font = New System.Drawing.Font("Berlin Sans FB", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbFecha.FormattingEnabled = True
        Me.CmbFecha.Location = New System.Drawing.Point(64, 235)
        Me.CmbFecha.Name = "CmbFecha"
        Me.CmbFecha.Size = New System.Drawing.Size(120, 31)
        Me.CmbFecha.TabIndex = 97
        '
        'TxtDesde
        '
        Me.TxtDesde.Location = New System.Drawing.Point(245, 233)
        Me.TxtDesde.Multiline = True
        Me.TxtDesde.Name = "TxtDesde"
        Me.TxtDesde.Size = New System.Drawing.Size(87, 31)
        Me.TxtDesde.TabIndex = 98
        '
        'TxtHasta
        '
        Me.TxtHasta.Location = New System.Drawing.Point(391, 233)
        Me.TxtHasta.Multiline = True
        Me.TxtHasta.Name = "TxtHasta"
        Me.TxtHasta.Size = New System.Drawing.Size(87, 31)
        Me.TxtHasta.TabIndex = 99
        '
        'BtnAgregar
        '
        Me.BtnAgregar.BackColor = System.Drawing.Color.MediumAquamarine
        Me.BtnAgregar.FlatAppearance.BorderSize = 0
        Me.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAgregar.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!)
        Me.BtnAgregar.Location = New System.Drawing.Point(509, 235)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(30, 30)
        Me.BtnAgregar.TabIndex = 100
        Me.BtnAgregar.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.MediumAquamarine
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!)
        Me.Button5.Location = New System.Drawing.Point(545, 235)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(30, 30)
        Me.Button5.TabIndex = 101
        Me.Button5.UseVisualStyleBackColor = False
        '
        'LblNombreCarrera
        '
        Me.LblNombreCarrera.AutoSize = True
        Me.LblNombreCarrera.BackColor = System.Drawing.Color.Transparent
        Me.LblNombreCarrera.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!)
        Me.LblNombreCarrera.ForeColor = System.Drawing.Color.Black
        Me.LblNombreCarrera.Location = New System.Drawing.Point(26, 65)
        Me.LblNombreCarrera.Name = "LblNombreCarrera"
        Me.LblNombreCarrera.Size = New System.Drawing.Size(62, 18)
        Me.LblNombreCarrera.TabIndex = 102
        Me.LblNombreCarrera.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(26, 124)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 18)
        Me.Label1.TabIndex = 102
        Me.Label1.Text = "Año"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!)
        Me.Label3.ForeColor = System.Drawing.Color.MediumAquamarine
        Me.Label3.Location = New System.Drawing.Point(143, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 18)
        Me.Label3.TabIndex = 103
        Me.Label3.Text = "/  Ver existentes"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!)
        Me.Label2.ForeColor = System.Drawing.Color.MediumAquamarine
        Me.Label2.Location = New System.Drawing.Point(24, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 18)
        Me.Label2.TabIndex = 104
        Me.Label2.Text = "Agregar Materia"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(26, 242)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 18)
        Me.Label5.TabIndex = 105
        Me.Label5.Text = "Día"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!)
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(190, 240)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 18)
        Me.Label6.TabIndex = 105
        Me.Label6.Text = "Desde"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!)
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(338, 240)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 18)
        Me.Label7.TabIndex = 106
        Me.Label7.Text = "Hasta"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!)
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(26, 199)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(175, 18)
        Me.Label8.TabIndex = 102
        Me.Label8.Text = "Horario y dia del módulo:"
        '
        'FrmAgregarMateria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(952, 512)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmAgregarMateria"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Agregar_Materia"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Dgv_ListaMaterias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.PnlBotones.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Dgv_ListaMaterias As DataGridView
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents TxtBuscar As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PnlBotones As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents BtnMinimizar As Button
    Friend WithEvents BtnMaximizar As Button
    Friend WithEvents BtnCerrar As Button
    Friend WithEvents LbltitulofrmCarrera As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents BtnBorrar As Button
    Friend WithEvents CmbFecha As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents CmbNombre As ComboBox
    Friend WithEvents Button5 As Button
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents TxtHasta As TextBox
    Friend WithEvents TxtDesde As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LblNombreCarrera As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label8 As Label
End Class
