Module Modulo_General

    Function VerificarDatosEnFormularios(ByVal mFrm As Form) As Boolean
        Dim mTxtb As Control
        Dim mPanel As Panel
        Try
            'Recorre los textbox y combobox fuera de los paneles
            For Each mTxtb In mFrm.Controls
                If (TypeOf mTxtb Is TextBox) Or (TypeOf mTxtb Is ComboBox) Then
                    'cada textbox != empty
                    If (String.IsNullOrEmpty(mTxtb.Text)) Or (mTxtb.Text.Equals("")) Then
                        MsgBox("Los campos no pueden estar vacíos")
                        Return False
                    End If
                End If
            Next

            For Each mPanel In mFrm.Controls
                For Each mTxtb In mPanel.Controls
                    If (TypeOf mTxtb Is TextBox) Or (TypeOf mTxtb Is ComboBox) Then
                        'cada textbox != empty
                        If (String.IsNullOrEmpty(mTxtb.Text)) Or (mTxtb.Text.Equals("")) Then
                            MsgBox("Los campos no pueden estar vacíos")
                            Return False
                        End If
                    End If
                Next
            Next
        Catch ex As Exception
            MsgBox("Datos incorrectos, verificar")
            Return False
        End Try
        Return True
    End Function

End Module
