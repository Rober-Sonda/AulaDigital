Imports System.Data.OleDb

Public Class Carrera
    Public id_Carrera As Long
    Public Nombre As String
    Public Turno As String
    Public Anios_Carrera As Byte
    Public ESTADO As Byte
    Public Id_Institucion As Long

    Sub AgregarCarrera(ByVal Carrera As Carrera, Optional ByVal Transact As IDbTransaction = Nothing)
        Try
            Dim cmmd As New OleDbCommand
            'Clave = ComprobarClaveAcceso(ClaveActual)
            cmmd.Connection = conexion
            cmmd.Transaction = Transact
            cmmd.CommandText = "INSERT INTO CARRERA (Nombre, Turno, Anios_Carrera, ESTADO, Id_Institucion) VALUES  ('" & Carrera.Nombre & "', " & Carrera.Turno & ", " & Carrera.Anios_Carrera & ", " & Carrera.ESTADO & ", " & Carrera.Id_Institucion & ")"
            cmmd.ExecuteNonQuery()
            MsgBox("Alumno agregado Correctamente", vbInformation)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub EditarCarrera(ByVal Carrera As Carrera, Optional ByVal Transact As IDbTransaction = Nothing)
        Try
            Dim cmmd As New OleDbCommand
            'Clave = ComprobarClaveAcceso(ClaveActual)
            cmmd.Connection = conexion
            cmmd.Transaction = Transact
            cmmd.CommandText = "UPDATE SET CARRERA Nombre = '" & Carrera.Nombre & "', Turno = " & Carrera.Turno & ", Anios_Carrera = " & Carrera.Anios_Carrera & ", ESTADO = " & Carrera.ESTADO & ", Id_Institucion = " & Carrera.Id_Institucion & " WHERE id_Carrera = " & Carrera.id_Carrera & ""
            cmmd.ExecuteNonQuery()
            'cmmd.Transaction.Commit()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub EliminarCarrera(ByVal Carrera As Carrera, Optional ByVal Transact As IDbTransaction = Nothing)
        Try
            Dim cmmd As New OleDbCommand
            'Clave = ComprobarClaveAcceso(ClaveActual)
            cmmd.Connection = conexion
            cmmd.Transaction = Transact
            cmmd.CommandText = "UPDATE CARRERA SET ESTADO = " & 0 & " WHERE id_Carrera = " & Carrera.id_Carrera & ""
            cmmd.ExecuteNonQuery()
            'cmmd.Transaction.Commit()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub ListarCarreras(ByVal DgvView As DataGridView)
        Try
            Dim Adaptador As OleDbDataAdapter
            Adaptador = New OleDbDataAdapter("SELECT * FROM CARRERA WHERE CARRERA.ESTADO = 1 ORDER BY CARRERA.Nombre", conexion)
            Dim dataS As New DataSet
            Adaptador.Fill(dataS, "Carreras")
            DgvView.DataSource = dataS.Tables("Carreras")

        Catch ex As Exception
            MsgBox("ERROR", ex.ToString)
        End Try
    End Sub
End Class
