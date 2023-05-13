' *****************************************************************************
' * PROYECTO   : SISTEMA AUTOMATIZADO PARA CONTROL DE PELUQUERIAS
' * CLASE      : Usuario
' * AUTOR      : Miguel Angel Quinteiro Piñero
' * FECHA      : 30 de Junio de 2017
' * ***************************************************************************

Public Class clsUsuario
    Inherits clsPersona

#Region "AREA DE DATOS"
    ' AREA DE DATOS
    '*******************************************************************
    ' Atributos
    Private aLogin As String
    Private aPassword As String
    Private aAutoridad As String

    ' Propiedades
    ' Propiedad Login
    Public Property Login As String
        Get
            Return aLogin
        End Get
        Set(ByVal value As String)
            aLogin = value
        End Set
    End Property
    ' Propiedad Password
    Public Property Password As String
        Get
            Return aPassword
        End Get
        Set(ByVal value As String)
            aPassword = value
        End Set
    End Property
    ' Propiedad Autoridad
    Public Property Autoridad As String
        Get
            Return aAutoridad
        End Get
        Set(ByVal value As String)
            aAutoridad = value
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
        aLogin = "Login"
        aPassword = "Password"
        aAutoridad = "Autoridad"
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
