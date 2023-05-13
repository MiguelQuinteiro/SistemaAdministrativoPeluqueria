Imports System.Data.SqlClient

Public Class clsConexxion
    Protected cnn As New SqlConnection

    Public idusuario As Integer

    ' Conectar a base de datos en sql server
    Protected Function conectado() As Boolean
        Try
            cnn = New SqlConnection("data source=(local);initial catalog=dbventas;integrated security=true")
            cnn.Open()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    ' Desconectar de base de datos en sql server
    Protected Function desconectado()
        Try
            If cnn.State = ConnectionState.Open Then
                cnn.Close()
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

End Class
