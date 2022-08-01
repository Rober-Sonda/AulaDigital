Imports System.Data.OleDb

Public Class Alumnos
    Public IdAlumnos As Long
    Public Nombre As String
    Public Apellido As String
    Public DNI As Long
    Public Mail As String
    Public Telefono As String
    Public Domicilio As String
    Public IdLocalidad As Long
    Public Trabaja As Boolean
    Public ESTADO As Byte = 1

    Sub AgregarAlumno(ByVal Alumno As Alumnos, Optional ByVal Transact As IDbTransaction = Nothing)
        Try
            Dim cmmd As New OleDbCommand
            'Clave = ComprobarClaveAcceso(ClaveActual)
            cmmd.Connection = conexion
            cmmd.Transaction = CType(Transact, OleDbTransaction)
            cmmd.CommandText = "INSERT INTO ALUMNOS (Nombre, Apellido, Domicilio, id_Localidad, DNI, Mail, Telefono, Trabaja, ESTADO) VALUES  ('" & Alumno.Nombre & "','" & Alumno.Apellido & "', '" & Alumno.Domicilio & "', " & Alumno.IdLocalidad & ", " & Alumno.DNI & ",'" & Alumno.Mail & "'," & Alumno.Telefono & "," & Alumno.Trabaja & "," & Alumno.ESTADO & ")"
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
            If IsNothing(Transact) Then
            Else
                cmmd.Transaction = CType(Transact, OleDbTransaction)
            End If
            cmmd.CommandText = "UPDATE ALUMNOS SET Nombre = '" & Alumno.Nombre & "', Apellido = '" & Alumno.Apellido & "', DNI = " & Alumno.DNI & ", Domicilio = '" & Alumno.Domicilio & "', Mail = '" & Alumno.Mail & "', Telefono = '" & Alumno.Telefono & "', Trabaja = " & Alumno.Trabaja & ", Id_Localidad = " & Alumno.IdLocalidad & ", ESTADO = " & Alumno.ESTADO & " WHERE Id_Alumnos = " & Alumno.IdAlumnos & ""
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

    Sub EliminarAlumno(ByVal idAlumno As Long)
        Try
            Dim cmmd As New OleDbCommand
            'Clave = ComprobarClaveAcceso(ClaveActual)
            cmmd.Connection = conexion
            cmmd.CommandText = "UPDATE ALUMNOS SET ESTADO = " & 0 & " WHERE id_Alumnos = " & idAlumno & ""
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

    Public Function _ListaAlumnos() As List(Of Alumnos)
        Dim _ListAlum As New List(Of Alumnos)
        'Dim dbConn As New OleDbConnection
        'dbConn = New OleDbConnection(cadenaConexion)
        Try
            Try
                'dbConn.Open()
                Dim dReader As OleDbDataReader
                Dim sqlstr As String = "SELECT * FROM ALUMNOS WHERE ALUMNOS.ESTADO = 1 ORDER BY ALUMNOS.Nombre"
                Dim cmd = New OleDbCommand(sqlstr, conexion)
                dReader = cmd.ExecuteReader
                If dReader.HasRows Then
                    Do While dReader.Read()
                        Dim mAlumno As New Alumnos
                        mAlumno.IdAlumnos = Convert.ToInt64(dReader(0))
                        mAlumno.Nombre = Convert.ToString(dReader(1))
                        mAlumno.Apellido = Convert.ToString(dReader(2))
                        mAlumno.DNI = Convert.ToInt64(dReader(3))
                        mAlumno.Domicilio = Convert.ToString(dReader(4))
                        mAlumno.IdLocalidad = Convert.ToInt64(dReader(5))
                        mAlumno.Mail = Convert.ToString(dReader(6))
                        mAlumno.Telefono = Convert.ToString(dReader(7))
                        mAlumno.Trabaja = Convert.ToBoolean(dReader(8))
                        mAlumno.ESTADO = Convert.ToByte(dReader(9))
                        _ListAlum.Add(mAlumno)
                    Loop
                Else
                    Console.WriteLine("No rows returned.")
                End If

                dReader.Close()
            Catch ex As Exception
                MsgBox("ERROR", CType(ex.ToString, MsgBoxStyle))
            End Try
        Catch ex As Exception
            MsgBox("ERROR", CType(ex.ToString, MsgBoxStyle))
        End Try
        Return _ListAlum
    End Function
    Public Function ConsultarAlumno(ByVal idAlumno As Long) As Alumnos
        Dim mAlumno As New Alumnos

        Try
            Dim dReader As OleDbDataReader
            Dim sqlstr As String = "SELECT * FROM ALUMNOS WHERE ALUMNOS.ESTADO = 1 AND id_Alumnos =" & idAlumno & " ORDER BY ALUMNOS.Nombre"
            Dim cmd = New OleDbCommand(sqlstr, conexion)
            dReader = cmd.ExecuteReader
            If dReader.HasRows Then
                Do While dReader.Read()
                    mAlumno.IdAlumnos = Convert.ToInt64(dReader(0))
                    mAlumno.Nombre = Convert.ToString(dReader(1))
                    mAlumno.Apellido = Convert.ToString(dReader(2))
                    mAlumno.DNI = Convert.ToInt64(dReader(3))
                    mAlumno.Domicilio = Convert.ToString(dReader(4))
                    mAlumno.IdLocalidad = Convert.ToInt64(dReader(5))
                    mAlumno.Mail = Convert.ToString(dReader(6))
                    mAlumno.Telefono = Convert.ToString(dReader(7))
                    mAlumno.Trabaja = Convert.ToBoolean(dReader(8))
                    mAlumno.ESTADO = Convert.ToByte(dReader(9))
                Loop
            Else
                Console.WriteLine("No rows returned.")
            End If

            dReader.Close()
        Catch ex As Exception
            MsgBox("ERROR", CType(ex.ToString, MsgBoxStyle))
        End Try
        Return mAlumno
    End Function
End Class
