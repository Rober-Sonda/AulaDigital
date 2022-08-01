Imports System.Data.OleDb

Public Class FrmListados
    Public titulo As String = ""
    Public listado As String = ""
    Dim dataS As New DataSet
    Dim mStr As String = ""
    Dim _ListaInst As New List(Of Institucion)
    Dim _ListaMat As New List(Of Materia)
    Dim _ListaCar As New List(Of Carrera)
    Dim _ListaAlumn As New List(Of Alumnos)

    Dim _adapterGral As OleDbDataAdapter
    'Public Delegate _mClick() As ClickGrilla

    Private Sub FrmListados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        init()
        EstiloGrillas(Dgv_Listados, 1, "Editar", "Eliminar", listado)
    End Sub

    Public Sub init()
        Dgv_Listados.DataSource = Nothing
        Dgv_Listados.Refresh()
        Dgv_Listados.Columns.Clear()
        If (_ListaAlumn.Count > 0) Then
            For i = _ListaAlumn.Count - 1 To 0 Step -1
                _ListaAlumn.Remove(_ListaAlumn(i))
            Next
        End If
        LbltitulofrmListado.Text = titulo
        CargaInicial() 'funcion que se carga dataS
        If (IsNothing(dataS.Tables)) Then Return

        CargarLista()
        '_Lista = CargarLista(dataS.Tables(mStr)) ' cargar lista 

    End Sub

    Public Sub CargarLista()
        If (listado.Equals("Instituciones")) Then
            mStr = "Instituciones"
            Dim mInst As New Institucion
            _ListaInst = mInst._ListaInstituciones
        ElseIf (listado.Equals("Carreras")) Then
            mStr = "Carreras"
            Dim mCarrera As New Carrera
            _ListaCar = mCarrera._ListaCarreras
        ElseIf (listado.Equals("Materias")) Then
            mStr = "Materias"
            Dim mMateria As New Materia
            _ListaMat = mMateria._ListaMateria
        ElseIf (listado.Equals("Alumnos")) Then
            mStr = "Alumnos"
            Dim mAlum As New Alumnos
            _ListaAlumn = mAlum._ListaAlumnos
        End If
    End Sub


    Public Sub CargarDatagridview(ByRef tabla As DataGridView, ByRef Adaptador As OleDbDataAdapter)
        Try
            If (listado.Equals("Instituciones")) Then
                mStr = "Instituciones"
            ElseIf (listado.Equals("Carreras")) Then
                mStr = "Carreras"
            ElseIf (listado.Equals("Materias")) Then
                mStr = "Materias"
            ElseIf (listado.Equals("Alumnos")) Then
                mStr = "Alumnos"
            End If
            dataS.Clear()
            Adaptador.Fill(dataS, mStr)
            tabla.DataSource = dataS.Tables(mStr)

        Catch ex As Exception
            Console.WriteLine(ex.ToString)
        End Try
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Dispose()
    End Sub

    Private Sub Dgv_Listados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv_Listados.CellClick

        If (Dgv_Listados.Rows.Count > 0) And (Dgv_Listados.Columns(e.ColumnIndex).HeaderText = "Editar") Then 'Editar
            If (listado.Equals("Instituciones")) Then
                Dim mInst As New FrmAgregarInst
                mInst.StartPosition = FormStartPosition.CenterScreen
                If (IsDBNull(dataS)) Then
                    Return
                End If
                'CargarLista()
                mInst.ShowDialog()
            End If
            If (listado.Equals("Carreras")) Then
                Dim mCarr As New FrmAgregarCarrera
                mCarr.StartPosition = FormStartPosition.CenterScreen
                mCarr.modFrm = 1
                If (_ListaCar.Count < e.RowIndex) Then Return
                mCarr.mCarrera.id_Carrera = _ListaCar(e.RowIndex).id_Carrera
                mCarr.mCarrera.Nombre = _ListaCar(e.RowIndex).Nombre
                'CargarLista()
                mCarr.ShowDialog()
            End If
            If (listado.Equals("Materias")) Then
                Dim mMateria As New FrmAgregarMateria
                mMateria.StartPosition = FormStartPosition.CenterScreen
                mMateria.modFrm = 1
                If (_ListaMat.Count < e.RowIndex) Then Return
                mMateria.nMateria.ID_Materia = _ListaMat(e.RowIndex).ID_Materia
                mMateria.nMateria.Nombre = _ListaMat(e.RowIndex).Nombre
                mMateria.ShowDialog()
            End If
            If (listado.Equals(mStr)) Then
                Dim mAlumn As New FrmAgregarAlumno
                mAlumn.StartPosition = FormStartPosition.CenterScreen
                mAlumn.modFrm = 1
                If (_ListaAlumn.Count < e.RowIndex) Then Return
                mAlumn.alumno.IdAlumnos = _ListaAlumn(e.RowIndex).IdAlumnos
                mAlumn.alumno.Nombre = _ListaAlumn(e.RowIndex).Nombre
                mAlumn.alumno.Apellido = _ListaAlumn(e.RowIndex).Apellido
                mAlumn.alumno.DNI = _ListaAlumn(e.RowIndex).DNI
                mAlumn.alumno.Domicilio = _ListaAlumn(e.RowIndex).Domicilio
                mAlumn.alumno.IdLocalidad = _ListaAlumn(e.RowIndex).IdLocalidad
                mAlumn.alumno.Mail = _ListaAlumn(e.RowIndex).Mail
                mAlumn.alumno.Telefono = _ListaAlumn(e.RowIndex).Telefono
                mAlumn.alumno.Trabaja = _ListaAlumn(e.RowIndex).Trabaja
                mAlumn.ShowDialog()
            End If
        End If
        If (Dgv_Listados.Rows.Count > 0) And (Dgv_Listados.Columns(e.ColumnIndex).HeaderText = "Eliminar") Then 'Eliminar
            If (listado.Equals("Instituciones")) Then
                Dim mInst As New Institucion
                mInst.EliminarInstitucion(_ListaInst(e.RowIndex).ID_Institucion)
                vbYesNo = True
            End If
            If (listado.Equals("Carreras")) Then
                Dim mCarrera As New Carrera
                mCarrera.EliminarCarrera(_ListaInst(e.RowIndex).ID_Institucion)
                vbYesNo = True
            End If
            If (listado.Equals("Materias")) Then
                Dim mMateria As New Materia
                mMateria.EliminarMateria(_ListaMat(e.RowIndex).ID_Materia)
                vbYesNo = True
            End If
            If (listado.Equals(mStr)) Then
                Dim cAlumn = New Alumnos
                cAlumn.EliminarAlumno(_ListaAlumn(e.RowIndex).IdAlumnos)
                vbYesNo = True
            End If
        End If
        If (vbYesNo = False) Then Return
        init()
        EstiloGrillas(Dgv_Listados, 1, "Editar", "Eliminar", listado)
    End Sub

    Public Sub CargaInicial()
        Dim strQuery As String = ""
        Dim Adaptador As OleDbDataAdapter
        If (listado.Equals("Instituciones")) Then
            strQuery = "SELECT Nombre, Mail, Direccion, (SELECT Nombre FROM LOCALIDAD WHERE Id_Localidad = Institucion.Id_Localidad) As Localidad FROM Institucion where Institucion.ESTADO = 1 ORDER BY Institucion.NOMBRE"
            Adaptador = New OleDbDataAdapter(strQuery, conexion)
        ElseIf (listado.Equals("Carreras")) Then
            strQuery = "SELECT Nombre, Duracion FROM Carrera Where Carrera.ESTADO = 1 ORDER BY Carrera.NOMBRE"
            Adaptador = New OleDbDataAdapter(strQuery, conexion)
        ElseIf (listado.Equals("Materias")) Then
            strQuery = "SELECT Nombre FROM Materia where Materia.ESTADO = 1 ORDER BY Materia.NOMBRE"
            Adaptador = New OleDbDataAdapter(strQuery, conexion)
        ElseIf (listado.Equals("Alumnos")) Then
            strQuery = "SELECT Nombre, Apellido, DNI, Domicilio, Trabaja, Mail, Telefono FROM Alumnos where Alumnos.ESTADO = 1 ORDER BY Alumnos.NOMBRE"
            Adaptador = New OleDbDataAdapter(strQuery, conexion)

        End If
        If (IsNothing(Adaptador)) Then Return
        CargarDatagridview(Dgv_Listados, Adaptador)
    End Sub
End Class