Imports MySql.Data.MySqlClient
Imports MySql.Data
Imports System.Configuration

Public Class Form4
    Dim conn As New MySqlConnection
    Dim objetoconexion As New conexion

    Dim cmd As MySqlCommand

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        conn = objetoconexion.AbrirCon
        cmd = conn.CreateCommand

        cmd.CommandText = "Select * From usuario Where usuario = '" + TextBox1.Text + "' And contraseña_usuario = '" + TextBox2.Text + "'"
        Dim r As MySqlDataReader
        r = cmd.ExecuteReader
        If r.HasRows <> False Then
            r.Read()

            Form5.Show()
            Me.Hide()
        Else
            MsgBox("El usuario o la contraseña son incorrectos")
        End If
    End Sub
End Class