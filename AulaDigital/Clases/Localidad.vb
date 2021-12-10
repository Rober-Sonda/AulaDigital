Imports System.Data.OleDb

Public Class Localidad
    Public Id_Localidad As Long = 0
    Public Nombre As String
    Public CPostal As Long
    Public ESTADO As Byte = 1

    Sub AgregarLocalidad(ByVal Localidad As Localidad, Optional ByVal Transact As IDbTransaction = Nothing)
        Try
            Dim cmmd As New OleDbCommand
            'Clave = ComprobarClaveAcceso(ClaveActual)
            cmmd.Connection = conexion
            cmmd.Transaction = CType(Transact, OleDbTransaction)
            cmmd.CommandText = "INSERT INTO LOCALIDAD (Nombre, CPostal, ESTADO) VALUES  ('" & Localidad.Nombre & "'," & Localidad.CPostal & "," & Localidad.ESTADO & ")"
            cmmd.ExecuteNonQuery()
            MsgBox("Localidad agregada Correctamente", vbInformation)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub EditarLocalidad(ByVal Localidad As Localidad, Optional ByVal Transact As IDbTransaction = Nothing)
        Try
            Dim cmmd As New OleDbCommand
            'Clave = ComprobarClaveAcceso(ClaveActual)
            cmmd.Connection = conexion
            cmmd.Transaction = CType(Transact, OleDbTransaction)
            cmmd.CommandText = "UPDATE LOCALIDAD SET Nombre = '" & Localidad.Nombre & "', CPostal = " & Localidad.CPostal & ", ESTADO = " & Localidad.ESTADO & " WHERE Id_Localidad = " & Localidad.Id_Localidad & ""
            cmmd.ExecuteNonQuery()
            'cmmd.Transaction.Commit()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub EliminarLocalidad(ByVal Id_Localidad As Long, Optional ByVal Transact As IDbTransaction = Nothing)
        Try
            Dim cmmd As New OleDbCommand
            'Clave = ComprobarClaveAcceso(ClaveActual)
            cmmd.Connection = conexion
            cmmd.Transaction = CType(Transact, OleDbTransaction)
            cmmd.CommandText = "UPDATE LOCALIDAD SET ESTADO = " & 0 & " WHERE Id_Localidad = " & Id_Localidad & ""
            cmmd.ExecuteNonQuery()
            'cmmd.Transaction.Commit()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Function VerificarDatos(ByVal Localidad As String, ByVal CPostal As String) As Boolean

        Dim flag As Integer = 0
        Dim mLocalidad As New Localidad
        Try
            If (String.IsNullOrEmpty(Localidad) Or String.IsNullOrEmpty(CPostal)) Then
                MsgBox("Los campos no pueden estar vacíos")
                Return False
            End If
            mLocalidad.Nombre = Localidad
            mLocalidad.CPostal = CLng(CPostal)
        Catch ex As Exception
            MsgBox("Datos incorrectos, verificar")
            Return False
        End Try
        Return True
    End Function

    Public Sub ListarLocalidades(ByVal DgvView As DataGridView)
        Try
            Dim Adaptador As OleDbDataAdapter
            Adaptador = New OleDbDataAdapter("SELECT * FROM LOCALIDAD WHERE LOCALIDAD.ESTADO = 1 ORDER BY LOCALIDAD.Nombre", conexion)
            Dim dataS As New DataSet
            Adaptador.Fill(dataS, "Localidades")
            DgvView.DataSource = dataS.Tables("Localidades")
        Catch ex As Exception
            MsgBox("ERROR", CType(ex.ToString, MsgBoxStyle))
        End Try
    End Sub

    Public Function ConsultarLocalidad(ByVal IdMateria As Integer) As Localidad
        Dim mLocalidad As New Localidad
        Dim dbConn As New OleDbConnection
        dbConn = New OleDbConnection(cadenaConexion)
        Try
            dbConn.Open()
            Dim dReader As OleDbDataReader
            Dim sqlstr As String = "SELECT * FROM MATERIA WHERE MATERIA.ESTADO = 1 AND ID_Materia =" & IdMateria & " ORDER BY MATERIA.Nombre"

            If dReader.HasRows Then
                Do While dReader.Read()
                    mLocalidad.Id_Localidad = Convert.ToInt32(dReader(0))
                    mLocalidad.Nombre = Convert.ToString(dReader(1))
                    mLocalidad.CPostal = Convert.ToInt32(dReader(2))
                    mLocalidad.ESTADO = Convert.ToByte(dReader(3))
                Loop
            Else
                Console.WriteLine("No rows returned.")
            End If

            dReader.Close()
            dbConn.Dispose()
        Catch ex As Exception
            MsgBox("ERROR", CType(ex.ToString, MsgBoxStyle))
        End Try
        Return mMateria
    End Function
End Class
