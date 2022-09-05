Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports System.Configuration.ConfigurationManager
Imports System.Configuration
Imports System.Runtime.InteropServices

Public Class Registros
    Dim conn As New MySqlConnection
    Dim objetoconexion As New conexion
    Dim cmd As MySqlCommand
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        conn = objetoconexion.AbrirCon
            Try
                cmd = conn.CreateCommand
            cmd.CommandText = "INSERT INTO usuario(usuario, contraseña_usuario) VALUES('" & TextBox1.Text & "','" & TextBox2.Text & "');"
            cmd.ExecuteNonQuery()
                conn.Close()
                conn.Dispose()
                TextBox1.Clear()
                TextBox2.Clear()


            Catch ex As Exception

            End Try
            Me.Close()
            Form1.Show()



    End Sub
End Class