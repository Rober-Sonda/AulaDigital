Imports System.Data.OleDb

Public Class Alumnos
    Public IdAlumnos As Integer
    Public Nombre As String
    Public Apellido As String
    Public DNI As Integer
    Public Mail As String
    Public Telefono As Integer
    Public Domicilio As String
    Public IdLocalidad As Integer
    Public Trabaja As Boolean
    Public ESTADO As Byte = 1

    Sub AgregarAlumno(ByVal Alumno As Alumnos, Optional ByVal Transact As IDbTransaction = Nothing)
        Try
            Dim cmmd As New OleDbCommand
            'Clave = ComprobarClaveAcceso(ClaveActual)
            cmmd.Connection = conexion
            cmmd.Transaction = CType(Transact, OleDbTransaction)
            cmmd.CommandText = "INSERT INTO ALUMNOS (Nombre, Apellido, DNI, Mail, Telefono, Trabaja, ESTADO) VALUES  ('" & Alumno.Nombre & "','" & Alumno.Apellido & "', " & Alumno.DNI & ",'" & Alumno.Mail & "'," & Alumno.Telefono & "," & Alumno.Trabaja & "," & Alumno.ESTADO & ")"
            cmmd.ExecuteNonQuery()
            MsgBox("Alumno agregado Correctamente", vbInformation)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub EditarAlumno(ByVal Alumno As Alumnos, Optional ByVal Transact As IDbTransaction = Nothing)
        Try
            Dim cmmd As New OleDbCommand
            'Clave = ComprobarClaveAcceso(ClaveActual)
            cmmd.Connection = conexion
            cmmd.Transaction = CType(Transact, OleDbTransaction)
            cmmd.CommandText = "UPDATE SET ALUMNOS Nombre = '" & Alumno.Nombre & "', Apellido = " & Alumno.Apellido & ", Mail = " & Alumno.Mail & ", Telefono = " & Alumno.Telefono & ", Trabaja = " & Alumno.Trabaja & ", ESTADO = " & Alumno.ESTADO & " WHERE IdAlumnos = " & Alumno.IdAlumnos & ""
            cmmd.ExecuteNonQuery()
            'cmmd.Transaction.Commit()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub EliminarAlumno(ByVal Alumno As Alumnos, Optional ByVal Transact As IDbTransaction = Nothing)
        Try
            Dim cmmd As New OleDbCommand
            'Clave = ComprobarClaveAcceso(ClaveActual)
            cmmd.Connection = conexion
            cmmd.Transaction = CType(Transact, OleDbTransaction)
            cmmd.CommandText = "UPDATE SET ALUMNOS ESTADO = " & 0 & " WHERE IdAlumnos = " & Alumno.IdAlumnos & ""
            cmmd.ExecuteNonQuery()
            'cmmd.Transaction.Commit()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub ListarAlumnos(ByVal DgvView As DataGridView)
        Try
            Dim Adaptador As OleDbDataAdapter
            Adaptador = New OleDbDataAdapter("SELECT * FROM ALUMNOS WHERE ALUMNOS.ESTADO = 1 ORDER BY ALUMNOS.Nombre", conexion)
            Dim dataS As New DataSet
            Adaptador.Fill(dataS, "Alumnos")
            DgvView.DataSource = dataS.Tables("Alumnos")
        Catch ex As Exception
            MsgBox("ERROR", CType(ex.ToString, MsgBoxStyle))
        End Try
    End Sub
    Public Function ConsultarAlumno(ByVal idAlumno As Integer) As Alumnos
        Dim mAlumno As New Alumnos
        Dim dbConn As New OleDbConnection
        dbConn = New OleDbConnection(cadenaConexion)
        Try
            dbConn.Open()
            Dim dReader As OleDbDataReader
            Dim sqlstr As String = "SELECT * FROM ALUMNOS WHERE ALUMNOS.ESTADO = 1 AND id_Alumnos =" & idAlumno & " ORDER BY ALUMNOS.Nombre"

            If dReader.HasRows Then
                Do While dReader.Read()
                    mAlumno.IdAlumnos = Convert.ToInt32(dReader(0))
                    mAlumno.Nombre = Convert.ToString(dReader(1))
                    mAlumno.Apellido = Convert.ToString(dReader(2))
                    mAlumno.DNI = Convert.ToInt32(dReader(3))
                    mAlumno.Domicilio = Convert.ToString(dReader(4))
                    mAlumno.IdLocalidad = Convert.ToInt32(dReader(5))
                    mAlumno.Mail = Convert.ToString(dReader(6))
                    mAlumno.Telefono = Convert.ToInt32(dReader(7))
                    mAlumno.Trabaja = Convert.ToBoolean(dReader(8))
                    mAlumno.ESTADO = Convert.ToByte(dReader(9))
                Loop
            Else
                Console.WriteLine("No rows returned.")
            End If

            dReader.Close()
            dbConn.Dispose()
        Catch ex As Exception
            MsgBox("ERROR", CType(ex.ToString, MsgBoxStyle))
        End Try
        Return mAlumno
    End Function
End Class
