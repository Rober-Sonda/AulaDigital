Imports System.Data.OleDb

Public Class Asistencia_Alumnos
    Public Id_Alumno As Long
    Public Id_Cursa_Materia As Long
    Public Asistencias As Boolean

    Sub AgregarAsistenciaAlumnos(ByVal AsistenciaAlumnos As Asistencia_Alumnos, Optional ByVal Transact As IDbTransaction = Nothing)
        Try
            Dim cmmd As New OleDbCommand
            'Clave = ComprobarClaveAcceso(ClaveActual)
            cmmd.Connection = conexion
            cmmd.Transaction = Transact
            cmmd.CommandText = "INSERT INTO ASISTENCIA_ALUMNOS (Id_Alumno, Id_Cursa_Materia, Asistencias) VALUES  ('" & AsistenciaAlumnos.Id_Alumno & "', " & AsistenciaAlumnos.Id_Cursa_Materia & ", " & AsistenciaAlumnos.Asistencias & ")"
            cmmd.ExecuteNonQuery()
            MsgBox("Alumno agregado Correctamente", vbInformation)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub EditarAsistenciaAlumnos(ByVal AsistenciaAlumnos As Asistencia_Alumnos, Optional ByVal Transact As IDbTransaction = Nothing)
        Try
            Dim cmmd As New OleDbCommand
            'Clave = ComprobarClaveAcceso(ClaveActual)
            cmmd.Connection = conexion
            cmmd.Transaction = Transact
            cmmd.CommandText = "UPDATE SET ASISTENCIA_ALUMNOS Asistencia = " & AsistenciaAlumnos.Asistencias & " WHERE Id_Cursa_Materia = " & AsistenciaAlumnos.Id_Cursa_Materia & " AND Id_Alumno = " & AsistenciaAlumnos.Id_Alumno & " "
            cmmd.ExecuteNonQuery()
            'cmmd.Transaction.Commit()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub EliminarCarrera(ByVal AsistenciaAlumnos As Asistencia_Alumnos, Optional ByVal Transact As IDbTransaction = Nothing)
        Try
            Dim cmmd As New OleDbCommand
            'Clave = ComprobarClaveAcceso(ClaveActual)
            cmmd.Connection = conexion
            cmmd.Transaction = Transact
            cmmd.CommandText = "DELETE FROM ASISTENCIA_ALUMNOS WHERE Id_Cursa_Materia = " & AsistenciaAlumnos.Id_Cursa_Materia & " AND Id_Alumno = " & AsistenciaAlumnos.Id_Alumno & ""
            cmmd.ExecuteNonQuery()
            'cmmd.Transaction.Commit()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
