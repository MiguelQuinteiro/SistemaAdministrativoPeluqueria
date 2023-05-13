' *****************************************************************************
' * PROYECTO   : SISTEMA AUTOMATIZADO PARA CONTROL DE PELUQUERIAS
' * CLASE      : Empleado
' * AUTOR      : Miguel Angel Quinteiro Piñero
' * FECHA      : 30 de Junio de 2017
' * ***************************************************************************

Public Class clsEmpleado
    Inherits clsPersona

#Region "AREA DE DATOS"
    ' AREA DE DATOS
    '*******************************************************************
    ' Atributos
    Private aCargo As String
    Private aDepartamento As String
    Private aEstado As String

    ' Propiedades
    ' Propiedad Cargo
    Public Property Cargo As String
        Get
            Return aCargo
        End Get
        Set(ByVal value As String)
            aCargo = value
        End Set
    End Property
    ' Propiedad Departamento
    Public Property Departamento As String
        Get
            Return aDepartamento
        End Get
        Set(ByVal value As String)
            aDepartamento = value
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
        aCargo = "Cargo"
        aDepartamento = "Departamento"
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
