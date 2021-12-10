Imports System.Data.OleDb
Imports System.Data.SqlClient
Public Class Agregar_alumno
    Public modFrm As Integer = 0 ' 0:agregar 1:editar 2:listar 3:eliminar
    Public idAlumno As Integer = 0
    Private Sub BtnDescartar_Click(sender As Object, e As EventArgs) Handles BtnDescartar.Click, BtnCerrar.Click
        Me.Dispose()
    End Sub

    Private Sub Agregar_alumno_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim MyCommand As OleDbCommand
            Dim MyAdapter As New OleDbDataAdapter
            Dim MyConexion As New OleDbConnection
            MyConexion.ConnectionString = conexion.ConnectionString
            MyCommand = MyConexion.CreateCommand
            MyCommand.CommandText = "SELECT * FROM Localidad"
            MyAdapter.SelectCommand = MyCommand
            Dim Dt_Cliente As New DataTable
            MyAdapter.Fill(Dt_Cliente)
            CmbLocalidadInstitucion.DataSource = Dt_Cliente
            CmbLocalidadInstitucion.DisplayMember = "Nombre"
            CmbLocalidadInstitucion.ValueMember = "Id_Localidad"
            CmbLocalidadInstitucion.Text = "Seleccione un Nombre..."
            If (modFrm = 1) Then
                Dim alumno As New Alumnos
                alumno = alumno.ConsultarAlumno(idAlumno)

            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub


End Class