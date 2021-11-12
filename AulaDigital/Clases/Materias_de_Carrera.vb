Imports System.Data.OleDb

Public Class Materias_de_Carrera
    Public Id_Materia As Long
    Public Id_Carrera As Long
    Public Ano_Materia As String
    Public Id_Materia_de_Carrera As Long

    Sub AgregarMateriaDeCarrera(ByVal MateriaDeCarrera As Materias_de_Carrera, Optional ByVal Transact As IDbTransaction = Nothing)
        Try
            Dim cmmd As New OleDbCommand
            'Clave = ComprobarClaveAcceso(ClaveActual)
            cmmd.Connection = conexion
            cmmd.Transaction = Transact
            cmmd.CommandText = "INSERT INTO MATERIA_DE_CARRERA (Id_Materia, Id_Carrera, Ano_Materia) VALUES (" & MateriaDeCarrera.Id_Materia & "," & MateriaDeCarrera.Id_Carrera & "," & MateriaDeCarrera.Ano_Materia & ")"
            cmmd.ExecuteNonQuery()
            MsgBox("Materia asignada Correctamente", vbInformation)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub EditarMateriaDeCarrera(ByVal MateriaDeCarrera As Materias_de_Carrera, Optional ByVal Transact As IDbTransaction = Nothing)
        Try
            Dim cmmd As New OleDbCommand
            'Clave = ComprobarClaveAcceso(ClaveActual)
            cmmd.Connection = conexion
            cmmd.Transaction = Transact
            cmmd.CommandText = "UPDATE SET MATERIA_DE_CARRERA Ano_Materia = " & MateriaDeCarrera.Ano_Materia & " WHERE Id_Materia_de_Carrera = " & MateriaDeCarrera.Id_Materia_de_Carrera & ""
            cmmd.ExecuteNonQuery()
            'cmmd.Transaction.Commit()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub EliminarMateriaDeCarrera(ByVal MateriaDeCarrera As Materias_de_Carrera, Optional ByVal Transact As IDbTransaction = Nothing)
        Try
            Dim cmmd As New OleDbCommand
            'Clave = ComprobarClaveAcceso(ClaveActual)
            cmmd.Connection = conexion
            cmmd.Transaction = Transact
            cmmd.CommandText = "DELETE FROM MATERIA_DE_CARRERA WHERE Id_Materia_de_Carrera = " & MateriaDeCarrera.Id_Materia_de_Carrera & ""
            cmmd.ExecuteNonQuery()
            'cmmd.Transaction.Commit()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Class
