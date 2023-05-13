' *****************************************************************************
' * PROYECTO   : SISTEMA AUTOMATIZADO PARA CONTROL DE PELUQUERIAS
' * FORMULARIO : Carga inicial al sistema
' * AUTOR      : Miguel Angel Quinteiro Piñero
' * FECHA      : 30 de Junio de 2017
' * ***************************************************************************

Public Class frmCargaInicial
    ' Al cargar el formulario
    Private Sub frmCargaInicial_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ProgressBar1.Value = 0
    End Sub

    ' Control de tiempo de inicio del sistema
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value < 100 Then
            ProgressBar1.Value = ProgressBar1.Value + 2
            Label1.Text = "Cargando el sistema al " & ProgressBar1.Value & "%"
        Else
            Timer1.Enabled = False
            Me.Hide()
            frmLogin.Show()
        End If
    End Sub
End Class