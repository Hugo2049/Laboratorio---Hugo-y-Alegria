Imports MySql.Data.MySqlClient
Imports MySql.Data
Imports System.Configuration

Public Class Admin
    Dim conn As New MySqlConnection
    Dim objetoconexion As New conexion

    Dim cmd As MySqlCommand

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        conn = objetoconexion.AbrirCon
        cmd = conn.CreateCommand

        cmd.CommandText = "Select * From admin Where admin = '" + TextBox1.Text + "' And contraseña_admin = '" + TextBox2.Text + "'"
        Dim r As MySqlDataReader
        r = cmd.ExecuteReader
        If r.HasRows <> False Then
            r.Read()

            Form2.Show()
            Me.Hide()
        Else
            MsgBox("El usuario o la contraseña son incorrectos")
        End If
    End Sub
End Class