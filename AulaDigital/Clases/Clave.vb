Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class Clave

    Public Clave As String
    Public Usuario As String
    Public Codigo_recuperacion As String

    Sub InsertarClave(ByVal Clave As String, ByVal Usuario As String, ByVal Codigo_recuperacion As String)
        'validacion de datos
        Try
            Dim cmmd As New OleDbCommand
            'Clave = ComprobarClaveAcceso(ClaveActual)
            cmmd.Connection = conexion
            cmmd.CommandText = "INSERT INTO CLAVE (CLAVE, USUARIO, CODIGO_RECUPERACION) VALUES  ('" & Clave & "','" & Usuario & "','" & Codigo_recuperacion & "')"
            cmmd.ExecuteNonQuery()
        Catch ex As Exception
            Print("ERROR", ex.ToString)
        End Try
    End Sub

    Sub ActualizarClaveAcceso(ByVal ClaveNueva As String)
        Try
            Dim cmmd As New OleDbCommand
            Dim Clave As Boolean
            Clave = CompararClaves(ClaveNueva)

            If (Clave) Then
                cmmd.Connection = conexion
                cmmd.CommandText = "UPDATE CLAVE_ACCESO SET CLAVE ='" & ClaveNueva & "'"
                cmmd.ExecuteNonQuery()
            End If
        Catch ex As Exception
            Print("ERROR", ex.ToString)
        End Try
    End Sub

    'metodo para verificar que haya datos en el campo as boolean

    Function CompararClaves(ByVal ClaveIngresada As String) As Boolean
        Dim Clave As Boolean = False
        Dim ClaveActual As String
        Try
            Dim rs As OleDbDataReader = Nothing
            Dim cmd = New OleDbCommand("SELECT Clave FROM Clave", conexion)
            rs = cmd.ExecuteReader
            While rs.Read
                ClaveActual = CLng(rs.GetValue(0))
            End While

            If (ClaveActual = ClaveIngresada) Then
                Clave = True
            Else
                Dim Msg As String = "Clave de Acceso incorrecta"
                MsgBox(Msg)
            End If
            rs.Close()
        Catch ex As Exception
            Dim Msg As String = ex.Message
            MsgBox(Msg)
            'Print("ERROR", ex.ToString)
        End Try
        Return Clave
    End Function

    'Funcion que verifica que haya un usuario creado
    'devuelve un valor boolean True = existe un usuario creado false = no existe usuario
    Function ComprobarCampoClave() As Boolean
        Dim Clave As Boolean = False
        Try
            Dim rs As OleDbDataReader = Nothing
            Dim cmd = New OleDbCommand("SELECT Clave FROM Clave", conexion)
            rs = cmd.ExecuteReader
            If (rs.HasRows) Then
                Clave = True
            End If

            rs.Close()
        Catch ex As Exception
            Dim Msg As String = ex.Message
            MsgBox(Msg)
        End Try
        Return Clave
    End Function
End Class
