' *****************************************************************************
' * PROYECTO   : SISTEMA AUTOMATIZADO PARA CONTROL DE PELUQUERIAS
' * CLASE      : Persona
' * AUTOR      : Miguel Angel Quinteiro Piñero
' * FECHA      : 30 de Junio de 2017
' * ***************************************************************************

Public Class clsPersona
#Region "AREA DE DATOS"
    ' AREA DE DATOS
    '*******************************************************************
    ' Atributos
    Private aDocumento As String
    Private aNombre As String
    Private aDireccion As String
    Private aTelefono As String
    Private aEmail As String
    Private aFoto As String

    ' Propiedades
    ' Propiedad Documento
    Public Property Documento As String
        Get
            Return aDocumento
        End Get
        Set(ByVal value As String)
            aDocumento = value
        End Set
    End Property
    ' Propiedad Nombre
    Public Property Nombre As String
        Get
            Return aNombre
        End Get
        Set(ByVal value As String)
            aNombre = value
        End Set
    End Property
    ' Propiedad Direccion
    Public Property Direccion As String
        Get
            Return aDireccion
        End Get
        Set(ByVal value As String)
            aDireccion = value
        End Set
    End Property
    ' Propiedad Telefono
    Public Property Telefono As String
        Get
            Return aTelefono
        End Get
        Set(ByVal value As String)
            aTelefono = value
        End Set
    End Property
    ' Propiedad Email
    Public Property Email As String
        Get
            Return aEmail
        End Get
        Set(ByVal value As String)
            aEmail = value
        End Set
    End Property
    ' Propiedad Email
    Public Property Foto As String
        Get
            Return aFoto
        End Get
        Set(ByVal value As String)
            aFoto = value
        End Set
    End Property
#End Region


#Region "AREA DE METODOS Y FUNCIONALIDAD"
    ' "AREA DE METODOS Y FUNCIONALIDAD"
    '*******************************************************************
    ' Metodos constructores y destructores de la clase
    ' Constructor
    Public Sub New()
        ' Que hacer al instanciar el objeto
        aDocumento = "Documento"
        aNombre = "Nombre"
        aDireccion = "Direccion"
        aTelefono = "Telefono"
        aEmail = "Email"
        aFoto = "Foto"
    End Sub
    ' Destructor

    ' Metodos publicos para la funcionalidad de la clase
    ' Subrutinas
    Public Sub Subrutina()
    End Sub
    ' Funciones
    Public Function Funcion() As Integer
        Funcion = 0
    End Function
#End Region

End Class
