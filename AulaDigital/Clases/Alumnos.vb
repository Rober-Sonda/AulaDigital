Imports System.Data.OleDb

Public Class Alumnos
    Public IdAlumnos As Integer
    Public Nombre As String
    Public Apellido As String
    Public DNI As Integer
    Public Mail As String
    Public Telefono As Integer
    Public Trabaja As Boolean
    Public ESTADO As Byte = 1

    Sub AgregarAlumno(ByVal Alumno As Alumnos, Optional ByVal Transact As IDbTransaction = Nothing)
        Try
            Dim cmmd As New OleDbCommand
            'Clave = ComprobarClaveAcceso(ClaveActual)
            cmmd.Connection = conexion
            cmmd.Transaction = Transact
            cmmd.CommandText = "INSERT INTO ALUMNOS (Nombre, Apellido, DNI, Mail, Telefono, Trabaja, ESTADO) VALUES  ('" & Alumno.Nombre & "','" & Alumno.Apellido & "', " & Alumno.DNI & ",'" & Alumno.Mail & "'," & Alumno.Telefono & "," & Alumno.Trabaja & "," & Alumno.ESTADO & ")"
            cmmd.ExecuteNonQuery()
            MsgBox("Alumno agregado Correctamente", vbInformation)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub EditarAlumno(ByVal Alumno As Alumnos, Optional ByVal Transact As IDbTransaction = Nothing)
        Try
            Dim cmmd As New OleDbCommand
            'Clave = ComprobarClaveAcceso(ClaveActual)
            cmmd.Connection = conexion
            cmmd.Transaction = Transact
            cmmd.CommandText = "UPDATE SET ALUMNOS Nombre = '" & Alumno.Nombre & "', Apellido = " & Alumno.Apellido & ", Mail = " & Alumno.Mail & ", Telefono = " & Alumno.Telefono & ", Trabaja = " & Alumno.Trabaja & ", ESTADO = " & Alumno.ESTADO & " WHERE IdAlumnos = " & Alumno.IdAlumnos & ""
            cmmd.ExecuteNonQuery()
            'cmmd.Transaction.Commit()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub EliminarAlumno(ByVal Alumno As Alumnos, Optional ByVal Transact As IDbTransaction = Nothing)
        Try
            Dim cmmd As New OleDbCommand
            'Clave = ComprobarClaveAcceso(ClaveActual)
            cmmd.Connection = conexion
            cmmd.Transaction = Transact
            cmmd.CommandText = "UPDATE SET ALUMNOS ESTADO = " & 0 & " WHERE IdAlumnos = " & Alumno.IdAlumnos & ""
            cmmd.ExecuteNonQuery()
            'cmmd.Transaction.Commit()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub ListarAlumnos(ByVal DgvView As DataGridView)
        Try
            Dim Adaptador As OleDbDataAdapter
            Adaptador = New OleDbDataAdapter("SELECT * FROM ALUMNOS WHERE ALUMNOS.ESTADO = 1 ORDER BY ALUMNOS.Nombre", conexion)
            Dim dataS As New DataSet
            Adaptador.Fill(dataS, "Alumnos")
            DgvView.DataSource = dataS.Tables("Alumnos")
        Catch ex As Exception
            MsgBox("ERROR", ex.ToString)
        End Try
    End Sub
End Class
