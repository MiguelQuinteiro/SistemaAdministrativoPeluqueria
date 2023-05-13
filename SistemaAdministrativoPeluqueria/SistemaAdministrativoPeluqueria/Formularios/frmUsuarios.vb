' *****************************************************************************
' * PROYECTO   : SISTEMA AUTOMATIZADO PARA CONTROL DE PELUQUERIAS
' * FORMULARIO : Usuarios del Sistema, controlan la aplización informática
' * AUTOR      : Miguel Angel Quinteiro Piñero
' * FECHA      : 30 de Junio de 2017
' * ***************************************************************************

Public Class frmUsuarios
    ' Al cargar el formulario
    Private Sub frmUsuarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim miUsuario As New clsPersona
        With miUsuario
            .Documento = "6314267"
            .Nombre = "Miguel"
            .Direccion = "Copacoa 1"
            .Telefono = "0416 1537258"
            .Email = "maq77@hotmail.com"
        End With
    End Sub


End Class