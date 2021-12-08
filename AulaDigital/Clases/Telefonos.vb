Imports System.Data.OleDb

Public Class Telefonos

    Public Id_Telefono As Long
    Public Id_Institucion As Long
    Public Cod_Area As Integer
    Public Telefono As Long
    Public Tipo As Long

    Function ConsultarTelefonosPersona(ByVal ID_PERSONA As Long) As String
        Dim salida As String = ""
        Try
            Dim rs44 As OleDbDataReader = Nothing
            cmd = New OleDbCommand("SELECT Personas.NOMBRE, Personas.APELLIDO, Alumnos.DNI, Alumnos.FECHA_NAC, _
            Telefonos.PREFIJO, Telefonos.SUFIJO _
            FROM (Personas INNER JOIN Alumnos ON Personas.ID_PERSONA = Alumnos.ID_ALUMNO) _
            INNER JOIN Telefonos ON Personas.ID_PERSONA = Telefonos.ID_PERSONA WHERE TELEFONOS.ID_PERSONA = " & ID_PERSONA & " ", Conexion)
            rs44 = cmd.ExecuteReader
            While rs44.Read
                salida += rs44("PREFIJO").ToString + vbCrLf
                salida += rs44("SUFIJO").ToString + vbCrLf
            End While
            rs44.Close()
        Catch ex As Exception
            Throw ex
        End Try
        Return salida
    End Function    'Consulta la informacion de los telefonos asignados a una persona'

    Sub AgregarTelefono(ByVal Id_Institucion As Long, ByVal Cod_Area As Integer, ByVal Telefono As Long, ByVal Tipo As Byte, ByVal Transact As IDbTransaction)
        'validacion de datos
        Try
            Dim cmmd As New OleDbCommand
            'Clave = ComprobarClaveAcceso(ClaveActual)
            cmmd.Connection = conexion
            cmmd.Transaction = CType(Transact, OleDbTransaction)
            cmmd.CommandText = "INSERT INTO TELEFONOS (Id_Institucion, Cod_Area, Telefono, Tipo) VALUES  (" & Id_Institucion & "," & Cod_Area & "," & Telefono & "," & Tipo & ")"
            cmmd.ExecuteNonQuery()
            'cmmd.Transaction.Commit()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub EditarTelefono(ByVal Telefono As Telefonos, Optional ByVal Transact As IDbTransaction = Nothing)
        Try
            Dim cmmd As New OleDbCommand
            'Clave = ComprobarClaveAcceso(ClaveActual)
            cmmd.Connection = conexion
            cmmd.Transaction = CType(Transact, OleDbTransaction)
            cmmd.CommandText = "UPDATE SET TELEFONOS Cod_Area = " & Telefono.Cod_Area & ", Telefono = " & Telefono.Telefono & ", Tipo = " & Telefono.Tipo & " WHERE Id_Telefono = " & Telefono.Id_Telefono & ""
            cmmd.ExecuteNonQuery()
            'cmmd.Transaction.Commit()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub EliminarTelefono(ByVal Telefono As Telefonos, Optional ByVal Transact As IDbTransaction = Nothing)
        Try
            Dim cmmd As New OleDbCommand
            'Clave = ComprobarClaveAcceso(ClaveActual)
            cmmd.Connection = conexion
            cmmd.Transaction = CType(Transact, OleDbTransaction)
            cmmd.CommandText = "DELETE FROM TELEFONOS WHERE Id_Telefono = " & Telefono.Id_Telefono & ""
            cmmd.ExecuteNonQuery()
            'cmmd.Transaction.Commit()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
