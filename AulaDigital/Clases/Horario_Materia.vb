Imports System.Data.OleDb

Public Class Horario_Materia
    Public Dia As String
    Public Hora_Inicio As String
    Public Hora_Fin As String
    Public Id_Materia As Long

    Sub AgregarHorarioMateria(ByVal HorarioMateria As Horario_Materia, Optional ByVal Transact As IDbTransaction = Nothing)
        Try
            Dim cmmd As New OleDbCommand
            'Clave = ComprobarClaveAcceso(ClaveActual)
            cmmd.Connection = conexion
            cmmd.Transaction = CType(Transact, OleDbTransaction)
            cmmd.CommandText = "INSERT INTO HORARIO_MATERIA (Dia, Hora_Inicio, Hora_Fin) VALUES ('" & HorarioMateria.Dia & "','" & HorarioMateria.Hora_Inicio & "', " & HorarioMateria.Hora_Fin & ")"
            cmmd.ExecuteNonQuery()
            MsgBox("Horario de materia establecido Correctamente", vbInformation)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub EditarHorarioMateria(ByVal HorarioMateria As Horario_Materia, Optional ByVal Transact As IDbTransaction = Nothing)
        Try
            Dim cmmd As New OleDbCommand
            'Clave = ComprobarClaveAcceso(ClaveActual)
            cmmd.Connection = conexion
            cmmd.Transaction = CType(Transact, OleDbTransaction)
            cmmd.CommandText = "UPDATE SET HORARIO_MATERIA Dia = '" & HorarioMateria.Dia & "', Hora_Inicio = " & HorarioMateria.Hora_Inicio & ", Hora_Fin = " & HorarioMateria.Hora_Fin & " WHERE Id_Materia = " & HorarioMateria.Id_Materia & ""
            cmmd.ExecuteNonQuery()
            'cmmd.Transaction.Commit()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub EliminarHorarioMateria(ByVal HorarioMateria As Horario_Materia, Optional ByVal Transact As IDbTransaction = Nothing)
        Try
            Dim cmmd As New OleDbCommand
            'Clave = ComprobarClaveAcceso(ClaveActual)
            cmmd.Connection = conexion
            cmmd.Transaction = CType(Transact, OleDbTransaction)
            cmmd.CommandText = "DELETE FROM HORARIO_MATERIA WHERE Id_Materia = " & HorarioMateria.Id_Materia & ""
            cmmd.ExecuteNonQuery()
            'cmmd.Transaction.Commit()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
