' *****************************************************************************
' * PROYECTO   : SISTEMA AUTOMATIZADO PARA CONTROL DE PELUQUERIAS
' * FORMULARIO : Acceso al sistema solicita login y password
' * AUTOR      : Miguel Angel Quinteiro Piñero
' * FECHA      : 30 de Junio de 2017
' * ***************************************************************************

Public Class frmLogin
    ' Al cargar el formulario
    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '' Borrar estas dos lineas
        ''My.Settings.ProductoRegistrado = False
        ''My.Settings.HaIngresado = False
        ''My.Settings.Save()

        '' Ajusta las variables de configuración
        'If My.Settings.ProductoRegistrado = False Then
        '    If My.Settings.HaIngresado = False Then
        '        MsgBox(" *** ES LA PRIMERA VEZ QUE INGRESA AL SISTEMA *** ")
        '        Timer1.Start()
        '        My.Settings.FechaCaducidad = DateTime.Now.AddSeconds(15)
        '        My.Settings.HaIngresado = True
        '        My.Settings.Save()
        '    Else
        '        MsgBox(" *** NO ES LA PRIMERA VEZ QUE INGRESA AL SISTEMA *** ")
        '        Timer1.Start()
        '    End If
        'Else
        '    MsgBox(" *** BIENVENIDO AL SISTEMA DE ADMINISTRACIÓN DE PELUQUERÍAS *** ")
        'End If
    End Sub

    '' Controla la fecha de caducidad en uso
    'Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
    '    If DateTime.Now > My.Settings.FechaCaducidad Then
    '        Me.Hide()
    '        frmLicencia.Show()
    '        Timer1.Stop()
    '    End If
    'End Sub

    ' Botón de aceptar
    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If txtUsuario.Text = "Miguel" And txtContraseña.Text = "1234" Then
            Me.Hide()
            frmSAP.Show()
        Else
            MsgBox("Error en datos de acceso")
        End If
    End Sub

    ' Botón de cancelar
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
        End
    End Sub

End Class