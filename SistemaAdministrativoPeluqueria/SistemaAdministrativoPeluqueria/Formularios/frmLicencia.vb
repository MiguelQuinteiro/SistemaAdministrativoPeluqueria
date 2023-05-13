' *****************************************************************************
' * PROYECTO   : SISTEMA AUTOMATIZADO PARA CONTROL DE PELUQUERIAS
' * FORMULARIO : Controla el uso del sistema según licencia de uso (1 año)
' * AUTOR      : Miguel Angel Quinteiro Piñero
' * FECHA      : 30 de Junio de 2017
' * ***************************************************************************

Public Class frmLicencia
    ' Al cargar el formulario
    Private Sub frmLicencia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    ' Botón Registrar
    Private Sub btnRegistar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistar.Click
        'If TextBox1.Text = My.Settings.Serial Then
        '    MsgBox(" *** REGRISTRADO CORRECTAMENTE *** ")
        '    My.Settings.ProductoRegistrado = True
        '    My.Settings.Save()
        '    Me.Close()
        '    Me.Hide()
        '    frmLogin.Show()
        'Else
        '    MsgBox(" *** SERIAL INVALIDO EL PRODUCTO NO FUE REGRISTRADO *** ")
        'End If
    End Sub
End Class