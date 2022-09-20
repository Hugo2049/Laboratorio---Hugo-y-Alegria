Public Class Form2
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hidesubmenu()

    End Sub

    Private Sub hidesubmenu()
        PanelProySubmenu.Visible = False
        PanelInfo.Visible = False
    End Sub
    Private Sub showsubmenu(submenu As Panel)
        If submenu.Visible = False Then
            hidesubmenu()
            submenu.Visible = True
        Else
            submenu.Visible = False
        End If
    End Sub

    Private Sub Btproy_Click(sender As Object, e As EventArgs) Handles Btproy.Click
        showsubmenu(PanelProySubmenu)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        showsubmenu(PanelInfo)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        openchildform(New Form3())
        '...
        'codigo
        '...
        hidesubmenu()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        openchildform(New Proyectos())
        '...
        'codigo
        '...
        hidesubmenu()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        openchildform(New Registros())
        '...
        'codigo
        '...
        hidesubmenu()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        openchildform(New Ong)
        '...
        'codigo
        '...
        hidesubmenu()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        openchildform(New Ong2)
        '...
        'codigo
        '...
        hidesubmenu()
    End Sub





    Private currentForm As Form = Nothing
    Private Sub openchildform(childform As Form)
        If currentForm IsNot Nothing Then currentForm.Close()
        currentForm = childform
        childform.TopLevel = False
        childform.FormBorderStyle = FormBorderStyle.None
        childform.Dock = DockStyle.Fill
        PanelChildForm.Controls.Add(childform)
        PanelChildForm.Tag = childform
        childform.BringToFront()
        childform.Show()

    End Sub
End Class