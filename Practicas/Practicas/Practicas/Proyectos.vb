Imports MySql.Data.MySqlClient
Imports MySql.Data
Imports System.Configuration

Public Class Proyectos
    Dim conn As New MySqlConnection
    Dim objetoconexion As New conexion

    Dim cmd As MySqlCommand

    Private Sub Proyectos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "yyyy-MM-dd"
        mostrar()
        DateTimePicker2.Format = DateTimePickerFormat.Custom
        DateTimePicker2.CustomFormat = "yyyy-MM-dd"
        mostrar()
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



    Private Sub GridData_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        Dim row As DataGridViewRow = GridData.CurrentRow
        Try
            TextBox6.Text = row.Cells(0).Value.ToString()
            TextBox1.Text = row.Cells(1).Value.ToString()
            DateTimePicker1.Text = row.Cells(2).Value.ToString()
            TextBox3.Text = row.Cells(3).Value.ToString()
            TextBox4.Text = row.Cells(4).Value.ToString()
            TextBox2.Text = row.Cells(5).Value.ToString()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        conn = objetoconexion.AbrirCon
        Try
            cmd = conn.CreateCommand
            cmd.CommandText = "UPDATE medicamentos SET nombre_medicamentos =@nom,fecha_de_vencimiento =@fech, Precio =@prec, Proveedores = @prov, Presentación =@pres WHERE id_medicamentos =@id"
            cmd.Parameters.AddWithValue("@nom", TextBox1.Text)
            cmd.Parameters.AddWithValue("@fech", DateTimePicker1.Text)
            cmd.Parameters.AddWithValue("@prec", TextBox3.Text)
            cmd.Parameters.AddWithValue("@prov", TextBox4.Text)
            cmd.Parameters.AddWithValue("@pres", TextBox2.Text)
            cmd.Parameters.AddWithValue("@id", TextBox6.Text)
            cmd.ExecuteNonQuery()

            mostrar()
            conn.Close()
            conn.Dispose()
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox4.Clear()
            TextBox6.Clear()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TextBox6_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "0123456789 "
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "0123456789 "
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        conn = objetoconexion.AbrirCon
        Try
            cmd = conn.CreateCommand
            cmd.CommandText = "delete from medicamentos where id_medicamentos =@id"
            cmd.Parameters.AddWithValue("@id", TextBox6.Text)
            cmd.ExecuteNonQuery()
            mostrar()
            conn.Close()
            conn.Dispose()
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox4.Clear()
            TextBox6.Clear()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtbuscar_TextChanged(sender As Object, e As EventArgs)
        conn = objetoconexion.AbrirCon
        Try
            Dim query As String = "select * from proyectos where nombre_proyecto like '%" & txtbuscar.Text & "%'"
            Dim adpt As New MySqlDataAdapter(query, conn)
            Dim ds As New DataSet()
            adpt.Fill(ds)
            GridData.DataSource = ds.Tables(0)
            conn.Close()
            conn.Dispose()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        conn = objetoconexion.AbrirCon
        Try
            cmd = conn.CreateCommand
            cmd.CommandText = "INSERT INTO proyectos( id_proyecto, nombre_proyecto, pais, departamento, fecha_de_inicio, fecha_de_finalizacion, costo, donante) VALUES('" & TextBox6.Text & "','" & TextBox1.Text & "', '" & TextBox2.Text & "', '" & TextBox5.Text & "' ,'" & DateTimePicker1.Text & "','" & DateTimePicker2.Text & "', '" & TextBox3.Text & "', '" & TextBox4.Text & "');"

            cmd.ExecuteNonQuery()
            conn.Close()
            conn.Dispose()
            mostrar()
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox4.Clear()
            TextBox6.Clear()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtbuscar_TextChanged_1(sender As Object, e As EventArgs) Handles txtbuscar.TextChanged
        conn = objetoconexion.AbrirCon
        Try
            Dim query As String = "select * from proyectos where nombre_proyecto like '%" & txtbuscar.Text & "%'"
            Dim adpt As New MySqlDataAdapter(query, conn)
            Dim ds As New DataSet()
            adpt.Fill(ds)
            GridData.DataSource = ds.Tables(0)
            conn.Close()
            conn.Dispose()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        conn = objetoconexion.AbrirCon
        Try
            cmd = conn.CreateCommand
            cmd.CommandText = "delete from proyectos where id_proyecto =@id"
            cmd.Parameters.AddWithValue("@id", TextBox6.Text)
            cmd.ExecuteNonQuery()
            mostrar()
            conn.Close()
            conn.Dispose()
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox4.Clear()
            TextBox6.Clear()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub GridData_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles GridData.CellContentClick
        Dim row As DataGridViewRow = GridData.CurrentRow
        Try
            TextBox6.Text = row.Cells(0).Value.ToString()
            TextBox1.Text = row.Cells(1).Value.ToString()
            TextBox2.Text = row.Cells(2).Value.ToString()
            TextBox5.Text = row.Cells(3).Value.ToString()
            DateTimePicker1.Text = row.Cells(4).Value.ToString()
            DateTimePicker2.Text = row.Cells(5).Value.ToString()
            TextBox3.Text = row.Cells(6).Value.ToString()
            TextBox4.Text = row.Cells(7).Value.ToString()


        Catch ex As Exception

        End Try
    End Sub
End Class