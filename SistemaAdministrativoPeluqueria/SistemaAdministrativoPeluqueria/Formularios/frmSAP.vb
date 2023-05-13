' *****************************************************************************
' * PROYECTO   : SISTEMA AUTOMATIZADO PARA CONTROL DE PELUQUERIAS
' * FORMULARIO : SAP contenedor principal de la aplización
' * AUTOR      : Miguel Angel Quinteiro Piñero
' * FECHA      : 30 de Junio de 2017
' * ***************************************************************************
Option Explicit On

Public Class frmSAP
    '***************************************************************************************************************************************************
    ' AL CARGAR EL FORMULARIO
    '***************************************************************************************************************************************************
    Private Sub frmSAP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    '***************************************************************************************************************************************************
    ' ARCHIVOS
    '***************************************************************************************************************************************************
    ' Opción de Usuarios
    Private Sub UsuariosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsuariosToolStripMenuItem.Click
        frmUsuarios.MdiParent = Me
        frmUsuarios.Show()
    End Sub
    ' Opción de Empleados
    Private Sub EmpleadosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmpleadosToolStripMenuItem.Click
        frmEmpleados.MdiParent = Me
        frmEmpleados.Show()
    End Sub
    ' Opción de Clientes
    Private Sub ClientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClientesToolStripMenuItem.Click
        frmClientes.MdiParent = Me
        frmClientes.Show()
    End Sub
    ' Opción Servicios
    Private Sub ServiciosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ServiciosToolStripMenuItem.Click
        frmServicios.MdiParent = Me
        frmServicios.Show()
    End Sub
    ' Opción Productos
    Private Sub ProductosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductosToolStripMenuItem.Click
        frmProductos.MdiParent = Me
        frmProductos.Show()
    End Sub

    '***************************************************************************************************************************************************
    ' CONTROL
    '***************************************************************************************************************************************************
    ' Opción Control Citas
    Private Sub CitasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CitasToolStripMenuItem.Click
        frmCtrlCitas.MdiParent = Me
        frmCtrlCitas.Show()
    End Sub
    ' Opción Control Servicios
    Private Sub ServicioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ServicioToolStripMenuItem.Click
        frmCtrlServicios.MdiParent = Me
        frmCtrlServicios.Show()
    End Sub
    ' Opción Control Inventario
    Private Sub InventarioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InventarioToolStripMenuItem.Click
        frmCtrlInventario.MdiParent = Me
        frmCtrlInventario.Show()
    End Sub

    '***************************************************************************************************************************************************
    ' UTILIDADES
    '***************************************************************************************************************************************************
    ' Opción Configuración
    Private Sub ConfiguraciónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConfiguraciónToolStripMenuItem.Click
        frmConfiguracion.MdiParent = Me
        frmConfiguracion.Show()
    End Sub
    ' Opción Respaldo
    Private Sub RespaldoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RespaldoToolStripMenuItem.Click
        frmRespaldo.MdiParent = Me
        frmRespaldo.Show()
    End Sub
    ' Opción Recuperación
    Private Sub RecuperaciónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RecuperaciónToolStripMenuItem.Click
        frmRecuperacion.MdiParent = Me
        frmRecuperacion.Show()
    End Sub

    '***************************************************************************************************************************************************
    ' VENTANAS
    '***************************************************************************************************************************************************
    ' Opción Horizontal
    Private Sub HorizontalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HorizontalToolStripMenuItem.Click

    End Sub
    ' Opción Vertical
    Private Sub VerticalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VerticalToolStripMenuItem.Click

    End Sub
    ' Opción Cascada
    Private Sub CascadaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CascadaToolStripMenuItem.Click

    End Sub

    '***************************************************************************************************************************************************
    ' AYUDA
    '***************************************************************************************************************************************************
    ' Opción Contenido
    Private Sub ContenidoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContenidoToolStripMenuItem.Click
        frmContenido.MdiParent = Me
        frmContenido.Show()
    End Sub
    ' Opción Apariencia
    Private Sub AparienciaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AparienciaToolStripMenuItem.Click
        frmApariencia.MdiParent = Me
        frmApariencia.Show()
    End Sub
    ' Opción Licencia
    Private Sub LicenciaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LicenciaToolStripMenuItem.Click
        frmLicencia.MdiParent = Me
        frmLicencia.Show()
    End Sub
    ' Opción Versión
    Private Sub VersiónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VersiónToolStripMenuItem.Click
        frmVersion.MdiParent = Me
        frmVersion.Show()
    End Sub

    '***************************************************************************************************************************************************
    ' SALIDA
    '***************************************************************************************************************************************************
    ' Opción Salida
    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        End
    End Sub
End Class
