Imports MySql.Data.MySqlClient
Imports MySql.Data
Imports System.Configuration

Public Class Form1
    Dim conn As New MySqlConnection
    Dim objetoconexion As New conexion

    Dim cmd As MySqlCommand
    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Registros.Show()
    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            CheckBox2.Checked = False
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            CheckBox1.Checked = False
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If CheckBox1.Checked = True Then
            Me.Hide()
            Admin.Show()
        ElseIf CheckBox2.Checked = True Then
            Me.Hide()
            Form4.Show()
        End If
    End Sub
End Class
