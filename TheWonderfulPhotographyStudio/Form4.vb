Public Class Form4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Visible = False
        Form2.Visible = True
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Val(Mid(TextBox1.Text, 7, 9)) = 0 Then
            MsgBox("El número de teléfono no puede ser cero", vbInformation, "Guardar")
            Exit Sub
        End If
    End Sub
End Class