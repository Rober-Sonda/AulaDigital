Imports System.Data.OleDb

Public Class Libro_de_Temas
    Public Id_Libro_de_Temas As Long
    Public Temas As String
    Public ESTADO As Byte

    Sub AgregarLibroDeTemas(ByVal LibroDeTemas As Libro_de_Temas, Optional ByVal Transact As IDbTransaction = Nothing)
        Try
            Dim cmmd As New OleDbCommand
            'Clave = ComprobarClaveAcceso(ClaveActual)
            cmmd.Connection = conexion
            cmmd.Transaction = CType(Transact, OleDbTransaction)
            cmmd.CommandText = "INSERT INTO LIBRO_DE_TEMAS (Temas, ESTADO) VALUES (" & LibroDeTemas.Temas & ",'" & LibroDeTemas.ESTADO & "')"
            cmmd.ExecuteNonQuery()
            MsgBox("Alumno agregado Correctamente", vbInformation)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub EditarLibroDeTemas(ByVal LibroDeTemas As Libro_de_Temas, Optional ByVal Transact As IDbTransaction = Nothing)
        Try
            Dim cmmd As New OleDbCommand
            'Clave = ComprobarClaveAcceso(ClaveActual)
            cmmd.Connection = conexion
            cmmd.Transaction = CType(Transact, OleDbTransaction)
            cmmd.CommandText = "UPDATE SET LIBRO_DE_TEMAS Temas = " & LibroDeTemas.Temas & " WHERE Id_Libro_de_Temas = " & LibroDeTemas.Id_Libro_de_Temas & ""
            cmmd.ExecuteNonQuery()
            'cmmd.Transaction.Commit()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub EliminarLibroDeTemas(ByVal LibroDeTemas As Libro_de_Temas, Optional ByVal Transact As IDbTransaction = Nothing)
        Try
            Dim cmmd As New OleDbCommand
            'Clave = ComprobarClaveAcceso(ClaveActual)
            cmmd.Connection = conexion
            cmmd.Transaction = CType(Transact, OleDbTransaction)
            cmmd.CommandText = "DELETE FROM LIBRO_DE_TEMAS WHERE Id_Libro_de_Temas = " & LibroDeTemas.Id_Libro_de_Temas & ""
            cmmd.ExecuteNonQuery()
            'cmmd.Transaction.Commit()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
