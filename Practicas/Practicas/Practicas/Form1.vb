Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Registros.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "usuario" And TextBox2.Text = "1234" Then
            Me.Hide()
            Proyectos.Show()
        Else
            MessageBox.Show("Usuario o Contraseña incorrectos", "Usuairo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox1.Focus()
        End If
    End Sub
End Class
