'Imports systems.data
Imports System.Data.OleDb
Imports System.Drawing
Imports System.Text.RegularExpressions

Module FuncionesGenerales
    Public Const TYPE_MATERIA As Integer = 0
    Public Const TYPE_INSTITUCION As Integer = 1
    Public Const TYPE_ALUMNO As Integer = 2
    Public Const TYPE_CARRERA As Integer = 3
    Public Const TYPE_ASISTENCIA As Integer = 4
    Public Const TYPE_CREAR_GRUPO As Integer = 5
    Public Const TYPE_EVENTOS As Integer = 6
    Public VERDE_APP As Color = Color.FromArgb(255, 49, 175, 180)
    Public btnSelected As Integer
    Public AcceptCancel As Boolean = True
    Public BACKCOLORFORMS As Color = Color.FloralWhite
    Public BACKCOLORCONTROLS As Color = Color.DimGray
    Public COLORTEXT As Integer = RGB(49, 175, 180)
    'Private oDataAdapter As OleDb.OleDbDataAdapter
    ' Private oDataSet As PruebaDeBaseDataSet
    Public cmd As New OleDbCommand 'Comando
    Public conexion As OleDbConnection = New OleDbConnection 'generar la conexion
    Public cadenaConexion As String 'Para ver el estado de la conexion
    Public Estado As String 'Para ver el estado de la conexion
    Public Comando As New OleDbCommand 'Comando
    Public Adaptador As New OleDbDataAdapter
    Public vbYesNo As Boolean = False
    'Conexion DB
    Sub Enlace()
        Try 'Excepciones
            cadenaConexion = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ROBER\OneDrive\Escritorio\AulaDigital\PruebaDeBase - modificada-sin-intermedias.accdb")
            'conexion.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\monita\Desktop\base terminada\PruebaDeBase - modificada-sin-intermedias.accdb" 'Direccion de la base de datos
            conexion = New OleDbConnection(cadenaConexion)
            conexion.Open()
            Estado = "Conectado"
        Catch ex As Exception
            Dim Msg As String = ex.Message
            MsgBox(Msg)
            Estado = "Desconectado"
        End Try
    End Sub

    Public Sub Desconectardb()
        conexion.Close()
    End Sub


    'Comprobar contraseña.

    'Public Function compro_clave(ByRef contrasena) As Boolean
    '    cmd.Connection = Conexionbd
    '    cmd.CommandType = CommandType.Text
    '    cmd.CommandText = "select contrasena from Usuario"
    '    Try
    '        dr = cmd.ExecuteReader
    '        dr.Read()
    '        If (dr(0).ToString) = (contrasena).ToString Then
    '            dr.Close()
    '(True)
    'Else
    '            dr.Close()
    '            Return (False)
    '        End If
    '    Catch ex As Exception
    '        dr.Close()
    '        Return (False)
    '    End Try
    'End Function


    Public Sub Centrar(ByVal Objeto As Object, ByVal Frm As Form)  ' referencia al control  
        Dim c As Control = CType(Objeto, Control)

        'le  establece el top y el Left dentro del Parent  
        With c
            .Top = (Frm.Height - c.Height) \ 2
            .Left = (Frm.Width - c.Width) \ 2
        End With
    End Sub

    Public Sub CentrarTitulo(ByVal Objeto As Object, ByVal Frm As Form)  ' referencia al control  
        Dim c As Control = CType(Objeto, Control)

        'le  establece el Left dentro del Parent  
        With c
            .Left = (Frm.Width - c.Width) \ 2
        End With
    End Sub


    Public Sub CentrarBotones(ByVal Objeto As Object, ByVal Frm As Form)  ' referencia al control  
        Dim c As Control = CType(Objeto, Control)

        'le  establece el Left dentro del Parent  
        With c
            .Top = (Frm.Height - c.Height) \ 2
        End With
    End Sub

    Public Function ValidarEmail(ByVal Email As String) As Boolean   'Validar correo electrónico
        Return Regex.IsMatch(Email, "^[_a-z0-9-]+(\.[_a-z0-9-]+)*@[a-z0-9-]+(\.[a-z0-9-]+)*(\.[a-z]{2,4})$")
    End Function
    Public Sub SinEspacios(ByVal e As KeyPressEventArgs)
        If e.KeyChar = " " Then
            e.Handled = True
        End If
    End Sub
    Public Sub SoloNumeros(ByVal e As KeyPressEventArgs)
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub 'No Permite Letras
    Public Sub SoloLetras(e As KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) And Not (e.KeyChar = "º") And Not (e.KeyChar = "ç") And Not (e.KeyChar = "Ç") And Not (e.KeyChar = "ª") Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub 'No permite números
    Public Sub NoPermiteEspacios(e As KeyPressEventArgs)
        If e.KeyChar = ChrW(Keys.Space) Then
            e.Handled = True
            Exit Sub
        End If
    End Sub 'No permite Espacios
    Public Sub PermitirSigno(e As KeyPressEventArgs, ByVal Simbolo As Char)
        If e.KeyChar = Simbolo Then
            e.Handled = False
            Exit Sub
        End If
    End Sub 'No permite Espacios
    Public Sub Ambos_LetrasNumeros(e As KeyPressEventArgs)

        If Regex.IsMatch(e.KeyChar, "^[a-zA-Z0-9]+$") = True Or e.KeyChar = ChrW(Keys.Back) Or (e.KeyChar = "-") Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub 'No permite Caracteres especiales
    Public Sub SiguienteControl(ByVal e As KeyPressEventArgs)
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub 'CON EL ENTER O TAB PASA AL SIGUIENTE CONTROL.
    Public Sub PressEnterHagoClickEnBoton(ByVal e As KeyPressEventArgs, ByVal Boton As Button)
        If e.KeyChar = ChrW(Keys.Enter) Then
            Boton.PerformClick()
        End If
    End Sub

    'Sub ActualizarClaveAcceso(ByVal ClaveActual As String, ByVal ClaveNueva As String)
    '    Try
    '        Dim cmmd As New OleDbCommand
    '        Dim Clave As Boolean
    '        Clave = ComprobarClaveAcceso(ClaveActual)
    '        If Clave = True Then
    '            cmmd.Connection = Conexion
    '            cmmd.CommandText = "UPDATE CLAVE_ACCESO SET CLAVE ='" & ClaveNueva & "'"
    '            cmmd.ExecuteNonQuery()
    '        End If
    '    Catch ex As Exception
    '        Print("ERROR", ex.ToString)
    '    End Try
    'End Sub
    Public Sub OcultarPrimerColumna(ByRef DgView As DataGridView)
        If (DgView.Rows.Count > 0) Then
            DgView.Columns(0).Visible = False
        End If
    End Sub

    Public Sub SeleccionarPrimerFila(ByRef DgView As DataGridView)
        If (DgView.Rows.Count > 0) Then
            DgView.Rows(0).Selected = True
        End If
    End Sub

    Public Sub OcultarUltimaColumna(ByRef DgView As DataGridView)
        If (DgView.Rows.Count > 0) Then
            DgView.Columns(DgView.Columns.Count - 1).Visible = False
        End If
    End Sub
    Public Sub EstiloGrillas(ByRef Dgview As DataGridView)
        Try
            With Dgview.ColumnHeadersDefaultCellStyle
                .Font = New Font("Century Gothic", 9)
                .ForeColor = Color.Blue
                .BackColor = ColorPersonalizado(224, 224, 224)
                .SelectionForeColor = Color.White
                .SelectionBackColor = SystemColors.Highlight
            End With 'celda titulo
            With Dgview.DefaultCellStyle
                .Font = New Font("Century Gothic", 9.75)
                .ForeColor = Color.Black
                .BackColor = Color.White
                .SelectionForeColor = Color.Black
                .SelectionBackColor = SystemColors.GradientActiveCaption
            End With 'Celdas listadas
            With Dgview.AlternatingRowsDefaultCellStyle
                .Font = New Font("Century Gothic", 9.75)
                .ForeColor = Color.Black
                .BackColor = Color.White
                .SelectionForeColor = Color.Black
                .SelectionBackColor = SystemColors.GradientActiveCaption
            End With 'Celdas listadas
            With Dgview
                .ReadOnly = True
                .MultiSelect = False
                .RowHeadersVisible = False 'Quita la columna con el *
                .ColumnHeadersVisible = True
                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill 'Rellenan
                .AutoSizeRowsMode = CType(DataGridViewAutoSizeColumnsMode.AllCells, DataGridViewAutoSizeRowsMode)
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .AllowUserToAddRows = False 'Quita la ultima fila vacia
            End With
        Catch ex As Exception
            MsgBox("Se produjo un error: " + ex.ToString)
        End Try
    End Sub

    Public Sub EstiloGrillas(ByRef Dgview As DataGridView, ByVal Tag As Integer)
        Try
            With Dgview.ColumnHeadersDefaultCellStyle
                .Font = New Font("Century Gothic", 9)
                .ForeColor = Color.Blue
                .BackColor = ColorPersonalizado(224, 224, 224)
                .SelectionForeColor = Color.White
                .SelectionBackColor = SystemColors.Highlight
            End With 'celda titulo
            With Dgview.DefaultCellStyle
                .Font = New Font("Century Gothic", 9.75)
                .ForeColor = Color.Black
                .BackColor = Color.White
                .SelectionForeColor = Color.Black
                .SelectionBackColor = SystemColors.GradientActiveCaption
            End With 'Celdas listadas
            With Dgview.AlternatingRowsDefaultCellStyle
                .Font = New Font("Century Gothic", 9.75)
                .ForeColor = Color.Black
                .BackColor = Color.White
                .SelectionForeColor = Color.Black
                .SelectionBackColor = SystemColors.GradientActiveCaption
            End With 'Celdas listadas
            With Dgview
                .ReadOnly = True
                .MultiSelect = False
                .RowHeadersVisible = False 'Quita la columna con el *
                .ColumnHeadersVisible = True
                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill 'Rellenan
                .AutoSizeRowsMode = CType(DataGridViewAutoSizeColumnsMode.AllCells, DataGridViewAutoSizeRowsMode)
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .AllowUserToAddRows = False 'Quita la ultima fila vacia
                If (Tag = 0) Then
                    .ColumnHeadersVisible = False
                End If
            End With
        Catch ex As Exception
            MsgBox("Se produjo un error: " + ex.ToString)
        End Try
    End Sub

    Public Sub EstiloGrillas(ByRef Dgview As DataGridView, ByVal Tag As Integer, ByVal titBtn1 As String, ByVal titBtn2 As String, ByVal listado As String)
        Dim BtnColumn1 As DataGridViewButtonColumn = New DataGridViewButtonColumn
        Dim BtnColumn2 As DataGridViewButtonColumn = New DataGridViewButtonColumn

        BtnColumn1.Text = titBtn1
        BtnColumn2.Text = titBtn2

        With Dgview.ColumnHeadersDefaultCellStyle
            .Font = New Font("Century Gothic", 9)
            .ForeColor = Color.Blue
            .BackColor = ColorPersonalizado(224, 224, 224)
            .SelectionForeColor = Color.White
            .SelectionBackColor = SystemColors.Highlight
        End With 'celda titulo
        With Dgview.DefaultCellStyle
            .Font = New Font("Century Gothic", 9.75)
            .ForeColor = Color.Black
            .BackColor = Color.White
            .SelectionForeColor = Color.Black
            .SelectionBackColor = SystemColors.GradientActiveCaption
        End With 'Celdas listadas
        With Dgview.AlternatingRowsDefaultCellStyle
            .Font = New Font("Century Gothic", 9.75)
            .ForeColor = Color.Black
            .BackColor = Color.White
            .SelectionForeColor = Color.Black
            .SelectionBackColor = SystemColors.GradientActiveCaption
        End With 'Celdas listadas
        With Dgview
            .ReadOnly = True
            .MultiSelect = False
            .RowHeadersVisible = False 'Quita la columna con el *
            .ColumnHeadersVisible = True
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill 'Rellenan
            .AutoSizeRowsMode = CType(DataGridViewAutoSizeColumnsMode.AllCells, DataGridViewAutoSizeRowsMode)
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .AllowUserToAddRows = False 'Quita la ultima fila vacia
            If (Tag = 0) Then
                .ColumnHeadersVisible = False
            End If
        End With

        BtnColumn1.HeaderText = titBtn1
        BtnColumn2.HeaderText = titBtn2

        BtnColumn1.UseColumnTextForButtonValue = True
        BtnColumn2.UseColumnTextForButtonValue = True

        BtnColumn1.FillWeight = 20
        BtnColumn2.FillWeight = 20

        Dgview.Columns.Add(BtnColumn1)
        Dgview.Columns.Add(BtnColumn2)

    End Sub

    Public Function ColorPersonalizado(ByVal R As Integer, ByVal G As Integer, ByVal B As Integer) As Color
        Try
            ColorPersonalizado = Color.FromArgb(R, G, B)
            Return ColorPersonalizado
        Catch ex As Exception
            MsgBox("Se produjo un error: " + ex.ToString)
        End Try
    End Function

    Public Sub Limpiar_TextBox_ComboBox(ByVal Formulario As Form)
        For Each control As Control In Formulario.Controls 'Recorremos todos los controles del formulario que enviamos 
            If TypeOf control Is TextBox Or TypeOf control Is ComboBox Then 'Filtramos solo aquellos de tipo TextBox
                control.Text = "" ' eliminar el texto
            End If
        Next
    End Sub

    Sub LlenarCombo(ByVal combo As ComboBox, ByVal tabla As String, ByVal campoPrincipal As String, ByVal campoValueMember As String)
        Dim listado As OleDbDataAdapter
        Dim dtabl As DataTable
        Using conect As New OleDbConnection(cadenaConexion)
            Dim strSql = "SELECT " & campoPrincipal & ", " & campoValueMember & " FROM " & tabla & " WHERE ESTADO = " & 1 & ""
            listado = New OleDbDataAdapter(strSql, conect)
            Try
                If IsDBNull(listado) = False And Not IsNothing(listado) Then
                    dtabl = New DataTable
                    listado.Fill(dtabl) 'Llenamos el dtab con la consulta
                    combo.DataSource = dtabl
                    combo.DisplayMember = campoPrincipal '& Campo que se muestra en el combo
                    combo.ValueMember = campoValueMember 'valor que se almacena en el value del combo
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Using
    End Sub

End Module

