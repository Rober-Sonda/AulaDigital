Imports System.Data.OleDb

Public Class Evento
    Public Id_Evento As Long
    Public Dia As Date
    Public Hora_inicio As String
    Public Hora_fin As String
    Public Descripcion As String

    Sub AgregarEvento(ByVal Evento As Evento, Optional ByVal Transact As IDbTransaction = Nothing)
        Try
            Dim cmmd As New OleDbCommand
            'Clave = ComprobarClaveAcceso(ClaveActual)
            cmmd.Connection = conexion
            cmmd.Transaction = Transact
            cmmd.CommandText = "INSERT INTO EVENTO (Dia, Hora_inicio, Hora_fin, Hora_fin, Descripcion) VALUES ('" & Evento.Dia & "','" & Evento.Hora_inicio & "', '" & Evento.Hora_fin & "', '" & Evento.Descripcion & "')"
            cmmd.ExecuteNonQuery()
            MsgBox("Evento agregado Correctamente", vbInformation)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub EditarEvento(ByVal Evento As Evento, Optional ByVal Transact As IDbTransaction = Nothing)
        Try
            Dim cmmd As New OleDbCommand
            'Clave = ComprobarClaveAcceso(ClaveActual)
            cmmd.Connection = conexion
            cmmd.Transaction = Transact
            cmmd.CommandText = "UPDATE SET EVENTO Dia = " & Evento.Dia & ", Hora_inicio = " & Evento.Hora_inicio & ", Hora_fin = " & Evento.Hora_fin & ", Descripcion = " & Evento.Descripcion & " WHERE Id_Evento = " & Evento.Id_Evento & ""
            cmmd.ExecuteNonQuery()
            'cmmd.Transaction.Commit()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub EliminarEvento(ByVal Evento As Evento, Optional ByVal Transact As IDbTransaction = Nothing)
        Try
            Dim cmmd As New OleDbCommand
            'Clave = ComprobarClaveAcceso(ClaveActual)
            cmmd.Connection = conexion
            cmmd.Transaction = Transact
            cmmd.CommandText = "DELETE FROM EVENTO WHERE Id_Evento = " & Evento.Id_Evento & ""
            cmmd.ExecuteNonQuery()
            'cmmd.Transaction.Commit()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
