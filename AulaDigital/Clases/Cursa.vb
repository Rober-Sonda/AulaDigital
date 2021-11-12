Imports System.Data.OleDb

Public Class Cursa
    Public Id_Libro_de_Temas As Long
    Public Fecha_Actual As Date
    Public Id_Materia As Long
    Public Id_Cursa_Materia As Long

    Sub AgregarMateriaCursada(ByVal Cursada As Cursa, Optional ByVal Transact As IDbTransaction = Nothing)
        Try
            Dim cmmd As New OleDbCommand
            'Clave = ComprobarClaveAcceso(ClaveActual)
            cmmd.Connection = conexion
            cmmd.Transaction = Transact
            cmmd.CommandText = "INSERT INTO CURSA (Id_Libro_de_Temas, Fecha_Actual, Id_Materia) VALUES (" & Cursada.Id_Libro_de_Temas & ",'" & Cursada.Fecha_Actual & "', " & Cursada.Id_Materia & ")"
            cmmd.ExecuteNonQuery()
            MsgBox("Alumno agregado Correctamente", vbInformation)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub EditarMateriaCursada(ByVal Cursada As Cursa, Optional ByVal Transact As IDbTransaction = Nothing)
        Try
            Dim cmmd As New OleDbCommand
            'Clave = ComprobarClaveAcceso(ClaveActual)
            cmmd.Connection = conexion
            cmmd.Transaction = Transact
            cmmd.CommandText = "UPDATE SET CURSA Id_Libro_de_Temas = " & Cursada.Id_Libro_de_Temas & ", Fecha_Actual = " & Cursada.Fecha_Actual & ", Id_Materia = " & Cursada.Id_Materia & " WHERE Id_Cursa_Materia = " & Cursada.Id_Cursa_Materia & ""
            cmmd.ExecuteNonQuery()
            'cmmd.Transaction.Commit()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub EliminarMateriaCursada(ByVal Cursada As Cursa, Optional ByVal Transact As IDbTransaction = Nothing)
        Try
            Dim cmmd As New OleDbCommand
            'Clave = ComprobarClaveAcceso(ClaveActual)
            cmmd.Connection = conexion
            cmmd.Transaction = Transact
            cmmd.CommandText = "DELETE FROM CURSA WHERE Id_Cursa_Materia = " & Cursada.Id_Cursa_Materia & ""
            cmmd.ExecuteNonQuery()
            'cmmd.Transaction.Commit()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
