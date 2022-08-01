<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAgregarAlumno
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAgregarAlumno))
        Me.PnlAlumnos = New System.Windows.Forms.Panel()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.Panel16 = New System.Windows.Forms.Panel()
        Me.Panel18 = New System.Windows.Forms.Panel()
        Me.CmbLocalidadAlumno = New System.Windows.Forms.ComboBox()
        Me.btnAgregarLocalidad = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ChkAlumnoTrabaja = New System.Windows.Forms.CheckBox()
        Me.lblDomicilio = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.TxtDomicilio = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.LbltitulofrmAlumno = New System.Windows.Forms.Label()
        Me.lblApellidoAlumno = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel17 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.TxtCelular = New System.Windows.Forms.TextBox()
        Me.TxtDNIAlumno = New System.Windows.Forms.TextBox()
        Me.TxtMail = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TxtApellidoAlumno = New System.Windows.Forms.TextBox()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tmrRefrescos = New System.Windows.Forms.Timer(Me.components)
        Me.PnlAlumnos.SuspendLayout()
        Me.Panel14.SuspendLayout()
        Me.Panel15.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlAlumnos
        '
        Me.PnlAlumnos.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PnlAlumnos.BackColor = System.Drawing.Color.FloralWhite
        Me.PnlAlumnos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlAlumnos.Controls.Add(Me.Panel14)
        Me.PnlAlumnos.Controls.Add(Me.CmbLocalidadAlumno)
        Me.PnlAlumnos.Controls.Add(Me.btnAgregarLocalidad)
        Me.PnlAlumnos.Controls.Add(Me.Label3)
        Me.PnlAlumnos.Controls.Add(Me.ChkAlumnoTrabaja)
        Me.PnlAlumnos.Controls.Add(Me.lblDomicilio)
        Me.PnlAlumnos.Controls.Add(Me.Panel6)
        Me.PnlAlumnos.Controls.Add(Me.TxtDomicilio)
        Me.PnlAlumnos.Controls.Add(Me.Panel2)
        Me.PnlAlumnos.Controls.Add(Me.lblApellidoAlumno)
        Me.PnlAlumnos.Controls.Add(Me.Label1)
        Me.PnlAlumnos.Controls.Add(Me.Panel7)
        Me.PnlAlumnos.Controls.Add(Me.Panel17)
        Me.PnlAlumnos.Controls.Add(Me.Panel5)
        Me.PnlAlumnos.Controls.Add(Me.TxtCelular)
        Me.PnlAlumnos.Controls.Add(Me.TxtDNIAlumno)
        Me.PnlAlumnos.Controls.Add(Me.TxtMail)
        Me.PnlAlumnos.Controls.Add(Me.Panel4)
        Me.PnlAlumnos.Controls.Add(Me.Panel3)
        Me.PnlAlumnos.Controls.Add(Me.TxtApellidoAlumno)
        Me.PnlAlumnos.Controls.Add(Me.TxtNombre)
        Me.PnlAlumnos.Controls.Add(Me.btnGuardar)
        Me.PnlAlumnos.Controls.Add(Me.Label7)
        Me.PnlAlumnos.Controls.Add(Me.Label2)
        Me.PnlAlumnos.Controls.Add(Me.Label5)
        Me.PnlAlumnos.Controls.Add(Me.Label4)
        Me.PnlAlumnos.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.PnlAlumnos.Location = New System.Drawing.Point(23, 32)
        Me.PnlAlumnos.Name = "PnlAlumnos"
        Me.PnlAlumnos.Size = New System.Drawing.Size(520, 478)
        Me.PnlAlumnos.TabIndex = 157
        '
        'Panel14
        '
        Me.Panel14.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel14.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Panel14.Controls.Add(Me.Panel15)
        Me.Panel14.Controls.Add(Me.Panel18)
        Me.Panel14.Location = New System.Drawing.Point(127, 236)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(332, 1)
        Me.Panel14.TabIndex = 190
        '
        'Panel15
        '
        Me.Panel15.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Panel15.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Panel15.Controls.Add(Me.Panel16)
        Me.Panel15.Location = New System.Drawing.Point(-47, 52)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(426, 1)
        Me.Panel15.TabIndex = 162
        '
        'Panel16
        '
        Me.Panel16.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Panel16.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Panel16.Location = New System.Drawing.Point(0, 51)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New System.Drawing.Size(426, 1)
        Me.Panel16.TabIndex = 161
        '
        'Panel18
        '
        Me.Panel18.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Panel18.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Panel18.Location = New System.Drawing.Point(-47, 51)
        Me.Panel18.Name = "Panel18"
        Me.Panel18.Size = New System.Drawing.Size(426, 1)
        Me.Panel18.TabIndex = 161
        '
        'CmbLocalidadAlumno
        '
        Me.CmbLocalidadAlumno.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CmbLocalidadAlumno.BackColor = System.Drawing.Color.FloralWhite
        Me.CmbLocalidadAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmbLocalidadAlumno.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbLocalidadAlumno.ForeColor = System.Drawing.Color.Black
        Me.CmbLocalidadAlumno.FormattingEnabled = True
        Me.CmbLocalidadAlumno.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.CmbLocalidadAlumno.Location = New System.Drawing.Point(127, 210)
        Me.CmbLocalidadAlumno.Name = "CmbLocalidadAlumno"
        Me.CmbLocalidadAlumno.Size = New System.Drawing.Size(332, 25)
        Me.CmbLocalidadAlumno.Sorted = True
        Me.CmbLocalidadAlumno.TabIndex = 189
        '
        'btnAgregarLocalidad
        '
        Me.btnAgregarLocalidad.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAgregarLocalidad.BackColor = System.Drawing.Color.Transparent
        Me.btnAgregarLocalidad.FlatAppearance.BorderSize = 0
        Me.btnAgregarLocalidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarLocalidad.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!)
        Me.btnAgregarLocalidad.Image = CType(resources.GetObject("btnAgregarLocalidad.Image"), System.Drawing.Image)
        Me.btnAgregarLocalidad.Location = New System.Drawing.Point(480, 212)
        Me.btnAgregarLocalidad.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAgregarLocalidad.Name = "btnAgregarLocalidad"
        Me.btnAgregarLocalidad.Size = New System.Drawing.Size(26, 23)
        Me.btnAgregarLocalidad.TabIndex = 192
        Me.btnAgregarLocalidad.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(29, 217)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 20)
        Me.Label3.TabIndex = 191
        Me.Label3.Text = "Localidad"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ChkAlumnoTrabaja
        '
        Me.ChkAlumnoTrabaja.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ChkAlumnoTrabaja.AutoSize = True
        Me.ChkAlumnoTrabaja.Location = New System.Drawing.Point(127, 403)
        Me.ChkAlumnoTrabaja.Name = "ChkAlumnoTrabaja"
        Me.ChkAlumnoTrabaja.Size = New System.Drawing.Size(15, 14)
        Me.ChkAlumnoTrabaja.TabIndex = 188
        Me.ChkAlumnoTrabaja.UseVisualStyleBackColor = True
        '
        'lblDomicilio
        '
        Me.lblDomicilio.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblDomicilio.AutoSize = True
        Me.lblDomicilio.BackColor = System.Drawing.Color.Transparent
        Me.lblDomicilio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblDomicilio.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.lblDomicilio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.lblDomicilio.Location = New System.Drawing.Point(28, 167)
        Me.lblDomicilio.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDomicilio.Name = "lblDomicilio"
        Me.lblDomicilio.Size = New System.Drawing.Size(75, 20)
        Me.lblDomicilio.TabIndex = 187
        Me.lblDomicilio.Text = "Domicilio"
        Me.lblDomicilio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel6
        '
        Me.Panel6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Panel6.Controls.Add(Me.Panel8)
        Me.Panel6.Controls.Add(Me.Panel13)
        Me.Panel6.Location = New System.Drawing.Point(126, 186)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(332, 1)
        Me.Panel6.TabIndex = 186
        '
        'Panel8
        '
        Me.Panel8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Panel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Panel8.Controls.Add(Me.Panel9)
        Me.Panel8.Location = New System.Drawing.Point(-47, 52)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(426, 1)
        Me.Panel8.TabIndex = 162
        '
        'Panel9
        '
        Me.Panel9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Panel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Panel9.Location = New System.Drawing.Point(0, 51)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(426, 1)
        Me.Panel9.TabIndex = 161
        '
        'Panel13
        '
        Me.Panel13.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Panel13.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Panel13.Location = New System.Drawing.Point(-47, 51)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(426, 1)
        Me.Panel13.TabIndex = 161
        '
        'TxtDomicilio
        '
        Me.TxtDomicilio.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtDomicilio.BackColor = System.Drawing.Color.FloralWhite
        Me.TxtDomicilio.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtDomicilio.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDomicilio.ForeColor = System.Drawing.Color.Black
        Me.TxtDomicilio.Location = New System.Drawing.Point(126, 165)
        Me.TxtDomicilio.Name = "TxtDomicilio"
        Me.TxtDomicilio.Size = New System.Drawing.Size(332, 20)
        Me.TxtDomicilio.TabIndex = 185
        Me.TxtDomicilio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.BtnCerrar)
        Me.Panel2.Controls.Add(Me.LbltitulofrmAlumno)
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
        'LbltitulofrmAlumno
        '
        Me.LbltitulofrmAlumno.BackColor = System.Drawing.Color.FloralWhite
        Me.LbltitulofrmAlumno.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LbltitulofrmAlumno.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbltitulofrmAlumno.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.LbltitulofrmAlumno.Location = New System.Drawing.Point(0, 0)
        Me.LbltitulofrmAlumno.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LbltitulofrmAlumno.Name = "LbltitulofrmAlumno"
        Me.LbltitulofrmAlumno.Size = New System.Drawing.Size(518, 43)
        Me.LbltitulofrmAlumno.TabIndex = 71
        Me.LbltitulofrmAlumno.Text = "Alumno"
        Me.LbltitulofrmAlumno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblApellidoAlumno
        '
        Me.lblApellidoAlumno.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblApellidoAlumno.AutoSize = True
        Me.lblApellidoAlumno.BackColor = System.Drawing.Color.Transparent
        Me.lblApellidoAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblApellidoAlumno.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.lblApellidoAlumno.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.lblApellidoAlumno.Location = New System.Drawing.Point(29, 122)
        Me.lblApellidoAlumno.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblApellidoAlumno.Name = "lblApellidoAlumno"
        Me.lblApellidoAlumno.Size = New System.Drawing.Size(69, 20)
        Me.lblApellidoAlumno.TabIndex = 182
        Me.lblApellidoAlumno.Text = "Apellido"
        Me.lblApellidoAlumno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(29, 76)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 20)
        Me.Label1.TabIndex = 181
        Me.Label1.Text = "Nombre"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel7
        '
        Me.Panel7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Panel7.Location = New System.Drawing.Point(127, 327)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(332, 1)
        Me.Panel7.TabIndex = 176
        '
        'Panel17
        '
        Me.Panel17.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel17.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Panel17.Location = New System.Drawing.Point(127, 282)
        Me.Panel17.Name = "Panel17"
        Me.Panel17.Size = New System.Drawing.Size(332, 1)
        Me.Panel17.TabIndex = 176
        '
        'Panel5
        '
        Me.Panel5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Panel5.Location = New System.Drawing.Point(127, 371)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(332, 1)
        Me.Panel5.TabIndex = 176
        '
        'TxtCelular
        '
        Me.TxtCelular.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtCelular.BackColor = System.Drawing.Color.FloralWhite
        Me.TxtCelular.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtCelular.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCelular.ForeColor = System.Drawing.Color.Black
        Me.TxtCelular.Location = New System.Drawing.Point(127, 305)
        Me.TxtCelular.Name = "TxtCelular"
        Me.TxtCelular.Size = New System.Drawing.Size(332, 20)
        Me.TxtCelular.TabIndex = 7
        Me.TxtCelular.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtDNIAlumno
        '
        Me.TxtDNIAlumno.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtDNIAlumno.BackColor = System.Drawing.Color.FloralWhite
        Me.TxtDNIAlumno.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtDNIAlumno.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDNIAlumno.ForeColor = System.Drawing.Color.Black
        Me.TxtDNIAlumno.Location = New System.Drawing.Point(127, 260)
        Me.TxtDNIAlumno.Name = "TxtDNIAlumno"
        Me.TxtDNIAlumno.Size = New System.Drawing.Size(332, 20)
        Me.TxtDNIAlumno.TabIndex = 8
        Me.TxtDNIAlumno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtMail
        '
        Me.TxtMail.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtMail.BackColor = System.Drawing.Color.FloralWhite
        Me.TxtMail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtMail.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMail.ForeColor = System.Drawing.Color.Black
        Me.TxtMail.Location = New System.Drawing.Point(127, 350)
        Me.TxtMail.Name = "TxtMail"
        Me.TxtMail.Size = New System.Drawing.Size(332, 20)
        Me.TxtMail.TabIndex = 8
        Me.TxtMail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel4
        '
        Me.Panel4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Panel4.Controls.Add(Me.Panel11)
        Me.Panel4.Controls.Add(Me.Panel10)
        Me.Panel4.Location = New System.Drawing.Point(127, 141)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(332, 1)
        Me.Panel4.TabIndex = 160
        '
        'Panel11
        '
        Me.Panel11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Panel11.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Panel11.Controls.Add(Me.Panel12)
        Me.Panel11.Location = New System.Drawing.Point(-47, 52)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(426, 1)
        Me.Panel11.TabIndex = 162
        '
        'Panel12
        '
        Me.Panel12.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Panel12.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Panel12.Location = New System.Drawing.Point(0, 51)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(426, 1)
        Me.Panel12.TabIndex = 161
        '
        'Panel10
        '
        Me.Panel10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Panel10.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Panel10.Location = New System.Drawing.Point(-47, 51)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(426, 1)
        Me.Panel10.TabIndex = 161
        '
        'Panel3
        '
        Me.Panel3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(127, 95)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(332, 1)
        Me.Panel3.TabIndex = 158
        '
        'TxtApellidoAlumno
        '
        Me.TxtApellidoAlumno.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtApellidoAlumno.BackColor = System.Drawing.Color.FloralWhite
        Me.TxtApellidoAlumno.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtApellidoAlumno.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtApellidoAlumno.ForeColor = System.Drawing.Color.Black
        Me.TxtApellidoAlumno.Location = New System.Drawing.Point(127, 120)
        Me.TxtApellidoAlumno.Name = "TxtApellidoAlumno"
        Me.TxtApellidoAlumno.Size = New System.Drawing.Size(332, 20)
        Me.TxtApellidoAlumno.TabIndex = 2
        Me.TxtApellidoAlumno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtNombre
        '
        Me.TxtNombre.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtNombre.BackColor = System.Drawing.Color.FloralWhite
        Me.TxtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtNombre.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombre.ForeColor = System.Drawing.Color.Black
        Me.TxtNombre.Location = New System.Drawing.Point(127, 75)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(332, 20)
        Me.TxtNombre.TabIndex = 1
        Me.TxtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnGuardar.FlatAppearance.BorderSize = 0
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.btnGuardar.ForeColor = System.Drawing.Color.White
        Me.btnGuardar.Location = New System.Drawing.Point(201, 427)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(117, 30)
        Me.btnGuardar.TabIndex = 9
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(29, 263)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 20)
        Me.Label7.TabIndex = 164
        Me.Label7.Text = "DNI"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(29, 397)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 20)
        Me.Label2.TabIndex = 164
        Me.Label2.Text = "Trabaja"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(29, 352)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 20)
        Me.Label5.TabIndex = 164
        Me.Label5.Text = "Mail"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(29, 308)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 20)
        Me.Label4.TabIndex = 161
        Me.Label4.Text = "Celular"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tmrRefrescos
        '
        Me.tmrRefrescos.Enabled = True
        Me.tmrRefrescos.Interval = 1000
        '
        'FrmAgregarAlumno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(574, 524)
        Me.Controls.Add(Me.PnlAlumnos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmAgregarAlumno"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FrmAgregarAlumno"
        Me.PnlAlumnos.ResumeLayout(False)
        Me.PnlAlumnos.PerformLayout()
        Me.Panel14.ResumeLayout(False)
        Me.Panel15.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel11.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlAlumnos As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BtnCerrar As Button
    Friend WithEvents LbltitulofrmAlumno As Label
    Friend WithEvents lblApellidoAlumno As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents TxtCelular As TextBox
    Friend WithEvents TxtMail As TextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Panel12 As Panel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TxtApellidoAlumno As TextBox
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel17 As Panel
    Friend WithEvents TxtDNIAlumno As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblDomicilio As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel13 As Panel
    Friend WithEvents TxtDomicilio As TextBox
    Friend WithEvents ChkAlumnoTrabaja As CheckBox
    Friend WithEvents Panel14 As Panel
    Friend WithEvents Panel15 As Panel
    Friend WithEvents Panel16 As Panel
    Friend WithEvents Panel18 As Panel
    Friend WithEvents CmbLocalidadAlumno As ComboBox
    Friend WithEvents btnAgregarLocalidad As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents tmrRefrescos As Timer
End Class
