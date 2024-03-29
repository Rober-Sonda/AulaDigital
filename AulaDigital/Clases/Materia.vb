﻿Imports System.Data.OleDb

Public Class Materia
    Public ID_Materia As Long
    Public Nombre As String
    Public Hs_Semanales As String
    Public Tipo_Hora As Byte
    Public ESTADO As Byte
    Public Id_Carrera As Long

    Sub AgregarMateria(ByVal Materia As Materia, Optional ByVal Transact As IDbTransaction = Nothing)
        Try
            Dim cmmd As New OleDbCommand
            'Clave = ComprobarClaveAcceso(ClaveActual)
            cmmd.Connection = conexion
            cmmd.Transaction = Transact
            cmmd.CommandText = "INSERT INTO MATERIA (Nombre, Hs_Semanales, Tipo_Hora, ESTADO, Id_Carrera) VALUES ('" & Materia.Nombre & "', " & Materia.Hs_Semanales & ", " & Materia.Tipo_Hora & ", " & Materia.ESTADO & ", " & Materia.Id_Carrera & ")"
            cmmd.ExecuteNonQuery()
            MsgBox("Materia agregada Correctamente", vbInformation)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub EditarMateria(ByVal Materia As Materia, Optional ByVal Transact As IDbTransaction = Nothing)
        Try
            Dim cmmd As New OleDbCommand
            'Clave = ComprobarClaveAcceso(ClaveActual)
            cmmd.Connection = conexion
            cmmd.Transaction = Transact
            cmmd.CommandText = "UPDATE SET MATERIA Nombre = '" & Materia.Nombre & "', Hs_Semanales = " & Materia.Hs_Semanales & ", Tipo_Hora = " & Materia.Tipo_Hora & ", ESTADO = " & Materia.ESTADO & ", Id_Carrera = " & Materia.Id_Carrera & " WHERE ID_Materia = " & Materia.ID_Materia & ""
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
            cmmd.CommandText = "UPDATE SET CARRERA ESTADO = " & 0 & " WHERE id_Carrera = " & Carrera.id_Carrera & ""
            cmmd.ExecuteNonQuery()
            'cmmd.Transaction.Commit()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub ListarMaterias(ByVal DgvView As DataGridView)
        Try
            Dim Adaptador As OleDbDataAdapter
            Adaptador = New OleDbDataAdapter("SELECT * FROM MATERIA WHERE MATERIA.ESTADO = 1 ORDER BY MATERIA.Nombre", conexion)
            Dim dataS As New DataSet
            Adaptador.Fill(dataS, "Materias")
            DgvView.DataSource = dataS.Tables("Materias")
        Catch ex As Exception
            MsgBox("ERROR", ex.ToString)
        End Try
    End Sub
End Class
