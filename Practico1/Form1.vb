Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BGuardar.Click
        Dim textoConcatenado = TextBox1.Text & " " & TextBox2.Text
        TextBox3.Text = textoConcatenado

    End Sub

    Private Sub BEliminar_Click(sender As Object, e As EventArgs) Handles BEliminar.Click
        If TextBox1.Multiline Then
            TextBox1.Clear()
        End If

        If TextBox2.Multiline Then
            TextBox2.Clear()
        End If

        If TextBox3.Multiline Then
            TextBox3.Clear()
        End If

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub BSalir_Click(sender As Object, e As EventArgs) Handles BSalir.Click, BSalir.Click
        Me.Close()
    End Sub

    Private Sub BSalir_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BSalir.KeyPress

    End Sub

    Private Sub BSalir_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles BSalir.PreviewKeyDown
        If e.Control AndAlso e.KeyCode = Keys.S Then
            Me.Close()
        End If
    End Sub

    Private Sub BSalir_KeyDown(sender As Object, e As KeyEventArgs) Handles BSalir.KeyDown

    End Sub
End Class
