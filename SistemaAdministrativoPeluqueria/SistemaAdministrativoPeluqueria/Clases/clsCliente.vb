' *****************************************************************************
' * PROYECTO   : SISTEMA AUTOMATIZADO PARA CONTROL DE PELUQUERIAS
' * CLASE      : Cliente
' * AUTOR      : Miguel Angel Quinteiro Piñero
' * FECHA      : 30 de Junio de 2017
' * ***************************************************************************

Public Class clsCliente
    Inherits clsPersona

#Region "AREA DE DATOS"
    ' AREA DE DATOS
    '*******************************************************************
    ' Atributos
    Private aRuc As String
    Private aDireccionFiscal As String
    Private aEstado As String

    ' Propiedades
    ' Propiedad Ruc
    Public Property Ruc As String
        Get
            Return aRuc
        End Get
        Set(ByVal value As String)
            aRuc = value
        End Set
    End Property
    ' Propiedad DireccionFiscal
    Public Property DireccionFiscal As String
        Get
            Return aDireccionFiscal
        End Get
        Set(ByVal value As String)
            aDireccionFiscal = value
        End Set
    End Property
    ' Propiedad Estado
    Public Property Estado As String
        Get
            Return aEstado
        End Get
        Set(ByVal value As String)
            aEstado = value
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
        aRuc = "Ruc"
        aDireccionFiscal = "DireccionFiscal"
        aEstado = "Estado"
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
