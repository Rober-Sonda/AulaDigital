Public Class FrmMenu
    Private Sub FrmMenuPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OcultarBotones()
    End Sub



    'Oculta los botonos opcionales del menu principal.
    Private Sub OcultarBotones()
        PnlGrupos.Visible = False
        PnlInformacion.Visible = False
        PnlResumenC.Visible = False
    End Sub


    'Funcion para Mostrar/Ocultar botones.
    Private Sub MostrarBotones(SubMenu As Panel)
        If SubMenu.Visible = False Then
            OcultarBotones()
            SubMenu.Visible = True
        Else
            SubMenu.Visible = False
        End If
    End Sub


    'Mostrar/Ocultar botones opcionales del menu principal.
    Private Sub BtnInformacion_Click(sender As Object, e As EventArgs) Handles BtnInformacion.Click
        MostrarBotones(PnlInformacion)
    End Sub

    Private Sub BtnGrupos_Click(sender As Object, e As EventArgs) Handles BtnGrupos.Click
        MostrarBotones(PnlGrupos)
    End Sub

    Private Sub BtnAsistencia_Click(sender As Object, e As EventArgs) Handles BtnAsistencia.Click
        FrmTomarAsistencia.ShowDialog()
    End Sub

    Private Sub BtnResumen_Click(sender As Object, e As EventArgs) Handles BtnResumen.Click
        MostrarBotones(PnlResumenC)
    End Sub



    'Otros Botones

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Close()
    End Sub

    Private Sub BtnMinimizar_Click(sender As Object, e As EventArgs) Handles BtnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub



    'Abrir ventanas con Informacion principal de cada registro.
    Private Sub BtnInstitucion_Click(sender As Object, e As EventArgs) Handles BtnInstitucion.Click
        FrmInformacion.ShowDialog()
    End Sub

    Private Sub BtnCarrera_Click(sender As Object, e As EventArgs) Handles BtnCarrera.Click
        FrmInformacion.ShowDialog()
    End Sub

    Private Sub BtnMateria_Click(sender As Object, e As EventArgs) Handles BtnMateria.Click
        FrmInformacion.ShowDialog()
    End Sub

    Private Sub BtnAlumno_Click(sender As Object, e As EventArgs) Handles BtnAlumno.Click
        FrmInformacion.ShowDialog()
    End Sub


    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles BtnCrearGrupo.Click
        FrmGrupoInst.ShowDialog()
    End Sub

    Private Sub BtnInformes_Click(sender As Object, e As EventArgs) Handles BtnInformes.Click
        FrmInformes.ShowDialog()
    End Sub

    Private Sub BtnResumenC_Click(sender As Object, e As EventArgs) Handles BtnResumenC.Click
        FrmEventos.ShowDialog()
    End Sub







    Private Sub FrmMenu_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        PnlTitulo.Width = Val(Me.Width)
        PnlMenu.Height = Val(Me.Height)

        Call Centrar(PbxLogo, Me)

    End Sub
    Private Sub BtnMaximizar_Click(sender As Object, e As EventArgs) Handles BtnMaximizar.Click
        If WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        Else
            Me.WindowState = FormWindowState.Maximized
        End If
    End Sub


End Class
