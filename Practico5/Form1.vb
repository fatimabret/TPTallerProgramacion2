Public Class Form1
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnFoto.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            picFoto.Image = Image.FromFile(OpenFileDialog1.FileName)
            TxtFoto.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged
        If txtNombre.Text.Length > 0 Then
            txtNombre.Text = Char.ToUpper(txtNombre.Text(0)) & txtNombre.Text.Substring(1).ToLower()
            txtNombre.SelectionStart = txtNombre.Text.Length
        End If
        Dim numero As Integer
        If Integer.TryParse(txtNombre.Text, numero) Then
            MsgBox("Solo se permiten letras")
        End If
    End Sub

    Private Sub txtApellido_TextChanged(sender As Object, e As EventArgs) Handles txtApellido.TextChanged
        If txtApellido.Text.Length > 0 Then
            txtApellido.Text = Char.ToUpper(txtApellido.Text(0)) & txtApellido.Text.Substring(1).ToLower()
            txtApellido.SelectionStart = txtApellido.Text.Length 'deja el cursor al final
        End If
        Dim numero As Integer
        If Integer.TryParse(txtApellido.Text, numero) Then
            MsgBox("Solo se permiten letras")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim sexo As String = If(rbHombre.Checked, "Hombre", "Mujer")


        Dim index As Integer = DataGridView1.Rows.Add()
        With DataGridView1.Rows(index)
            .Cells("apellido").Value = txtApellido.Text
            .Cells("nombre").Value = txtNombre.Text
            .Cells("fechNac").Value = DateTimePicker1.Value.ToShortDateString()
            .Cells("sexo").Value = sexo
            .Cells("saldo").Value = CDec(txtSaldo.Text)
            .Cells("foto").Value = picFoto.Image
            .Cells("ruta").Value = TxtFoto.Text
            .Cells("eliminar").Value = "Eliminar"
        End With

        ' Cambiar color de fila si el saldo < 50
        If CDec(txtSaldo.Text) < 50 Then
            DataGridView1.Rows(index).DefaultCellStyle.BackColor = Color.Red
        End If

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.ColumnIndex = DataGridView1.Columns("Eliminar").Index AndAlso e.RowIndex >= 0 Then
            Dim resp As DialogResult = MessageBox.Show("¿Desea eliminar este registro?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If resp = DialogResult.Yes Then
                DataGridView1.Rows.RemoveAt(e.RowIndex)
            End If
        End If

        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            If DataGridView1.Columns(e.ColumnIndex).Name = "sexo" Then
                Dim valorSexo As String = DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString()

                If valorSexo = "Hombre" Then
                    rbHombre.Checked = True
                    rbMujer.Checked = False
                Else
                    rbMujer.Checked = True
                    rbHombre.Checked = False
                End If
            End If
        End If

    End Sub

    Private Sub txtSaldo_TextChanged(sender As Object, e As EventArgs) Handles txtSaldo.TextChanged
        If Not IsNumeric(txtSaldo.Text) Then
            MsgBox("Solo se permiten números")
        End If
    End Sub
End Class
