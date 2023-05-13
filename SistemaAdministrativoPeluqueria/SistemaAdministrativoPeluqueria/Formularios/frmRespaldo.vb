' *****************************************************************************
' * PROYECTO   : SISTEMA AUTOMATIZADO PARA CONTROL DE PELUQUERIAS
' * FORMULARIO : Respaldo, se respalda la información del sistema
' * AUTOR      : Miguel Angel Quinteiro Piñero
' * FECHA      : 30 de Junio de 2017
' * ***************************************************************************
Imports System.IO

Public Class frmRespaldo
    ' Al cargar el formulario
    Private Sub frmRespaldo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        For Each di As DriveInfo In DriveInfo.GetDrives()
            lstUnidadesO.Items.Add(di)
            lstUnidadesD.Items.Add(di)
        Next

        For Each diD As DriveInfo In DriveInfo.GetDrives()
            lstUnidadesD.Items.Add(diD)
        Next
    End Sub

    ' Unidad Origen
    Private Sub lstUnidadesO_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstUnidadesO.SelectedIndexChanged
        lblUnidadO.Text = lstUnidadesO.Text
        lstCarpetasO.Items.Clear()
        Try
            Dim drive As DriveInfo = DirectCast(lstUnidadesO.SelectedItem, DriveInfo)
            For Each dirInfo As DirectoryInfo In drive.RootDirectory.GetDirectories()
                lstCarpetasO.Items.Add(dirInfo)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    ' Carpeta Origen
    Private Sub lstCarpetasO_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstCarpetasO.SelectedIndexChanged
        lblCarpetaO.Text = lstCarpetasO.Text
        lstArchivosO.Items.Clear()
        Try
            Dim dir As DirectoryInfo = DirectCast(lstCarpetasO.SelectedItem, DirectoryInfo)
            For Each fi As FileInfo In dir.GetFiles()
                lstArchivosO.Items.Add(fi)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    ' Archivo Origen
    Private Sub lstArchivosO_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstArchivosO.SelectedIndexChanged
        lblArchivoO.Text = lstArchivosO.Text
    End Sub

    ' Unidad Destino
    Private Sub lstUnidadesD_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstUnidadesD.SelectedIndexChanged
        lblUnidadD.Text = lstUnidadesD.Text
        lstCarpetasD.Items.Clear()
        Try
            Dim drive As DriveInfo = DirectCast(lstUnidadesD.SelectedItem, DriveInfo)
            For Each dirInfo As DirectoryInfo In drive.RootDirectory.GetDirectories()
                lstCarpetasD.Items.Add(dirInfo)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    ' Carpeta Destino
    Private Sub lstCarpetasD_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstCarpetasD.SelectedIndexChanged
        lblCarpetaD.Text = lstCarpetasD.Text
        lstArchivosD.Items.Clear()
        Try
            Dim dir As DirectoryInfo = DirectCast(lstCarpetasD.SelectedItem, DirectoryInfo)
            For Each fi As FileInfo In dir.GetFiles()
                lstArchivosD.Items.Add(fi)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    ' Archivo Destino
    Private Sub lstArchivosD_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstArchivosD.SelectedIndexChanged
        lblArchivoD.Text = lstArchivosD.Text
    End Sub
End Class