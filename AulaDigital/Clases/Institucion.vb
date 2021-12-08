Imports System.Data.OleDb
Public Class Institucion
    Public Nombre As String
    Public Mail As String
    Public Direccion As String
    Public ESTADO As Byte
    Public Id_Localidad As Long
    Public ID_Institucion As Long


    Sub InsertarInstitucion(ByVal Id_Localidad As Integer, ByVal ESTADO As Byte, ByVal Direccion As String, ByVal Mail As String, ByVal Nombre As String)
        'validacion de datos
        Try
            Dim cmmd As New OleDbCommand
            'Clave = ComprobarClaveAcceso(ClaveActual)
            cmmd.Connection = conexion
            cmmd.CommandText = "INSERT INTO INSTITUCION (Id_Localidad, ESTADO, Direccion, Mail, Nombre) VALUES 
                                                        ('" & Id_Localidad & "',
                                                        " & ESTADO & ",
                                                        '" & Direccion & "',
                                                        '" & Mail & "',
                                                        '" & Nombre & "')"
            cmmd.ExecuteNonQuery()
        Catch ex As Exception
            Print(CInt("ERROR"), ex.ToString)
        End Try
    End Sub

    Sub EditarInstitucion(ByVal Id_Institucion As Integer, ByVal Id_Localidad As Integer, ByVal ESTADO As Byte, ByVal Direccion As String, ByVal Mail As String, ByVal Nombre As String)

        Try
            cmd = New OleDbCommand("UPDATE INSTITUCION SET Nombre = '" & Nombre & "', 
                                                           Id_Localidad =" & Id_Localidad & ", 
                                                           ESTADO = " & ESTADO & ", 
                                                           Direccion = '" & Direccion & "',
                                                           Mail = '" & Mail & "'
                                    WHERE INSTITUCION.Id_Institucion = " & Id_Institucion & "", conexion)
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try
    End Sub

    Sub BloquearInstitucion(ByVal ID_Institucion As Integer)
        Try
            cmd = New OleDbCommand("UPDATE INSTITUCION SET ESTADO = 0,
                                    WHERE INSTITUCION.Id_Institucion = " & ID_Institucion & "", conexion)
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try
    End Sub

    Sub DesbloquearInstitucion(ByVal ID_Institucion As Integer)
        Try
            cmd = New OleDbCommand("UPDATE INSTITUCION SET ESTADO = 1,
                                    WHERE INSTITUCION.Id_Institucion = " & ID_Institucion & "", conexion)
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try
    End Sub

    Function ExisteInstitucion(ByVal Id_Institucion As Integer) As Boolean
        Dim VerdaderaFalsa As Boolean = False
        Dim cmmd As New OleDbCommand
        Dim rs77 As OleDbDataReader = Nothing
        cmmd.Connection = conexion
        cmmd.CommandText = "SELECT Id_Institucion FROM INSTITUCION"
        Try
            rs77 = cmmd.ExecuteReader
            If rs77.HasRows = True Then
                rs77.Read()
                If CInt(rs77.GetString(0)) = Id_Institucion Then
                    VerdaderaFalsa = True
                Else
                    VerdaderaFalsa = False
                End If
            End If
            rs77.Close()
        Catch ex As Exception

        End Try
        Return VerdaderaFalsa
    End Function

    Function UltimaInstitucion() As Long
        Dim rs50 As OleDbDataReader = Nothing
        Try
            cmd = New OleDbCommand("SELECT TOP 1 Id_Institucion FROM INSTITUCION ORDER BY Id_Institucion DESC", conexion)
            'SELECT TOP 1 * FROM... ORDER BY RowId DESC
            rs50 = cmd.ExecuteReader
            rs50.Read()
            UltimaInstitucion = CLng(rs50.GetValue(0))
        Catch ex As Exception
            Throw ex
        Finally
            rs50.Close()
        End Try
        Return UltimaInstitucion
    End Function
End Class
