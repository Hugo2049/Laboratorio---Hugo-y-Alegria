Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports System.Configuration.ConfigurationManager
Imports System.Configuration
Public Class conexion
    Private servidor, database, usuario, password As String

    Public Sub New()
        Try
            servidor = System.Configuration.ConfigurationManager.AppSettings("servidor").ToString
            database = System.Configuration.ConfigurationManager.AppSettings("database").ToString
            usuario = System.Configuration.ConfigurationManager.AppSettings("usuario").ToString
            password = System.Configuration.ConfigurationManager.AppSettings("password").ToString
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Public Function AbrirCon() As MySqlConnection
        Dim MySQLConnectionString As String
        Dim conn As MySqlConnection

        MySQLConnectionString = "Server=" + servidor + ";" & "Database=" + database + ";" & "Uid=" + usuario + ";" & "Pwd=" + password + ";"
        conn = New MySqlConnection(MySQLConnectionString)
        conn.Open()
        Return conn
    End Function
End Class
