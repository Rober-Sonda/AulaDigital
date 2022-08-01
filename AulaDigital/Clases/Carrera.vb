Imports System.Data.OleDb

Public Class Carrera
    Public id_Carrera As Long
    Public Nombre As String
    Public Duracion_Carrera As Byte
    Public ESTADO As Byte

    Sub AgregarCarrera(ByVal Carrera As Carrera, Optional ByVal Transact As IDbTransaction = Nothing)
        Try
            Dim cmmd As New OleDbCommand
            'Clave = ComprobarClaveAcceso(ClaveActual)
            cmmd.Connection = conexion
            cmmd.Transaction = CType(Transact, OleDbTransaction)
            cmmd.CommandText = "INSERT INTO CARRERA (Nombre, Duracion_Carrera, ESTADO) VALUES  ('" & Carrera.Nombre & "', " & Carrera.Duracion_Carrera & ", " & 1 & ")"
            cmmd.ExecuteNonQuery()
            MsgBox("La carrera ha sido agregada Correctamente", vbInformation)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub EditarCarrera(ByVal Carrera As Carrera, Optional ByVal Transact As IDbTransaction = Nothing)
        Try
            Dim cmmd As New OleDbCommand
            'Clave = ComprobarClaveAcceso(ClaveActual)
            cmmd.Connection = conexion
            cmmd.Transaction = CType(Transact, OleDbTransaction)
            cmmd.CommandText = "UPDATE SET Carrera_de_Institucion Nombre = '" & Carrera.Nombre & "', Duracion_Carrera = " & Carrera.Duracion_Carrera & ", ESTADO = " & Carrera.ESTADO & " WHERE id_Carrera = " & Carrera.id_Carrera & ""
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
            cmmd.Transaction = CType(Transact, OleDbTransaction)
            cmmd.CommandText = "UPDATE CARRERA SET ESTADO = " & 0 & " WHERE id_Carrera = " & Carrera.id_Carrera & ""
            cmmd.ExecuteNonQuery()
            'cmmd.Transaction.Commit()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub EliminarCarrera(ByVal idCarrera As Long)
        Try
            Dim cmmd As New OleDbCommand
            'Clave = ComprobarClaveAcceso(ClaveActual)
            cmmd.Connection = conexion
            cmmd.CommandText = "UPDATE CARRERA SET ESTADO = " & 0 & " WHERE id_Carrera = " & idCarrera & ""
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
            MsgBox("ERROR", CType(ex.ToString, MsgBoxStyle))
        End Try
    End Sub

    Public Function _ListaCarreras() As List(Of Carrera)
        Dim _ListCarrera As New List(Of Carrera)
        Dim mCarrera As New Carrera
        Dim dbConn As New OleDbConnection
        dbConn = New OleDbConnection(cadenaConexion)
        Try
            Try
                dbConn.Open()
                Dim dReader As OleDbDataReader
                Dim sqlstr As String = "SELECT * FROM CARRERA WHERE CARRERA.ESTADO = 1 ORDER BY CARRERA.Nombre"

                If dReader.HasRows Then
                    Do While dReader.Read()
                        mCarrera.id_Carrera = Convert.ToInt64(dReader(0))
                        mCarrera.Nombre = Convert.ToString(dReader(1))
                        mCarrera.Duracion_Carrera = Convert.ToByte(dReader(2))
                        mCarrera.ESTADO = Convert.ToByte(dReader(3))

                        _ListCarrera.Add(mCarrera)
                    Loop
                Else
                    Console.WriteLine("No rows returned.")
                End If

                dReader.Close()
                dbConn.Dispose()
            Catch ex As Exception
                MsgBox("ERROR", CType(ex.ToString, MsgBoxStyle))
            End Try
        Catch ex As Exception
            MsgBox("ERROR", CType(ex.ToString, MsgBoxStyle))
        End Try
        Return _ListCarrera
    End Function

    Public Function ConsultarCarrera(ByVal idCarrera As Integer) As Carrera
        Dim mCarrera As New Carrera
        Dim dbConn As New OleDbConnection
        dbConn = New OleDbConnection(cadenaConexion)
        Try
            dbConn.Open()
            Dim dReader As OleDbDataReader
            Dim sqlstr As String = "SELECT * FROM CARRERA WHERE CARRERA.ESTADO = 1 AND id_Carrera =" & idCarrera & " ORDER BY CARRERA.Nombre"

            If dReader.HasRows Then
                Do While dReader.Read()
                    mCarrera.id_Carrera = Convert.ToInt32(dReader(0))
                    mCarrera.Nombre = Convert.ToString(dReader(1))
                    mCarrera.Duracion_Carrera = Convert.ToByte(dReader(2))
                    mCarrera.ESTADO = Convert.ToByte(dReader(3))
                Loop
            Else
                Console.WriteLine("No rows returned.")
            End If

            dReader.Close()
            dbConn.Dispose()
        Catch ex As Exception
            MsgBox("ERROR", CType(ex.ToString, MsgBoxStyle))
        End Try
        Return mCarrera
    End Function
End Class
