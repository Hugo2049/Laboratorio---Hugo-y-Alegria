Imports MySql.Data.MySqlClient
Imports MySql.Data
Imports System.Configuration

Public Class Form3
    Dim conn As New MySqlConnection
    Dim objetoconexion As New conexion

    Dim cmd As MySqlCommand
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub mostrar()
        conn = objetoconexion.AbrirCon
        Dim query As String = "select * from proyectos"
        Dim adpt As New MySqlDataAdapter(query, conn)
        Dim ds As New DataSet()
        adpt.Fill(ds)
        GridData.DataSource = ds.Tables(0)
        conn.Close()
        conn.Dispose()
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
    End Sub
End Class
