Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles LNya.Click

    End Sub

    Private Sub TGuardar_Click(sender As Object, e As EventArgs) Handles TGuardar.Click
        TGuardar.BackgroundImageLayout = ImageLayout.Stretch
        If String.IsNullOrWhiteSpace(TDni.Text) Or String.IsNullOrWhiteSpace(TNombre.Text) OrElse String.IsNullOrWhiteSpace(TApellido.Text) Then
            MsgBox("Debe completar todos los campos", MsgBoxStyle.Critical)
            Return
        End If

        LModificar.Text = TNombre.Text & " " & TApellido.Text

        Dim ask As MsgBoxResult
        ask = MsgBox("¿Seguro que desea insertar un nuevo Cliente?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirmar insercion")

        If ask = MsgBoxResult.Yes Then
            MsgBox("El Cliente " & LModificar.Text & " se inserto correctamente", +MsgBoxStyle.Information, "Guardar")
        Else
            MsgBox("No se han guardado los cambios", MsgBoxStyle.Exclamation)
        End If

    End Sub

    Private Sub Eliminar_Click(sender As Object, e As EventArgs) Handles TEliminar.Click
        TEliminar.BackgroundImageLayout = ImageLayout.Stretch
        Dim ask As MsgBoxResult
        ask = MsgBox("Esta a punto de eliminar el Cliente " & LModificar.Text, MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "Confirmar Eliminacion")
        If ask = MsgBoxResult.Yes Then
            TDni.Clear()
            TNombre.Clear()
            TApellido.Clear()
            MsgBox("El Cliente: " & LModificar.Text & " se eliminó correctamente", MsgBoxStyle.Information, "Eliminar")
            LModificar.Text = String.Empty

        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TDni_TextChanged(sender As Object, e As EventArgs) Handles TDni.TextChanged
        If Not IsNumeric(TDni.Text) Then
            MsgBox("Solo se permiten números")
        End If
    End Sub

    Private Sub TApellido_TextChanged(sender As Object, e As EventArgs) Handles TApellido.TextChanged
        Dim numero As Integer
        If Integer.TryParse(TApellido.Text, numero) Then
            MsgBox("Solo se permiten letras")
        End If
    End Sub

    Private Sub TNombre_TextChanged(sender As Object, e As EventArgs) Handles TNombre.TextChanged
        Dim numero As Integer
        If Integer.TryParse(TNombre.Text, numero) Then
            MsgBox("Solo se permiten letras.")
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RBMujer.CheckedChanged
        If RBMujer.Checked Then
            PictureBox1.Image = Image.FromFile("C:\Users\Fatima B\OneDrive\Documentos\BretFatimaTp1,2y3\Practico3\My Project\imagenes\LogoMujer.jpg")

        End If
    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles LTarjetas.Click

    End Sub

    Private Sub RBVaron_CheckedChanged(sender As Object, e As EventArgs) Handles RBVaron.CheckedChanged
        If RBVaron.Checked Then
            PictureBox1.Image = Image.FromFile("C:\Users\Fatima B\OneDrive\Documentos\BretFatimaTp1,2y3\Practico3\My Project\imagenes\LogoVaron.jpg")
        End If
    End Sub

    Private Sub LModificar_Click(sender As Object, e As EventArgs) Handles LModificar.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
    End Sub

    Private Sub TSalir_Click(sender As Object, e As EventArgs) Handles TSalir.Click
        Me.Close()
    End Sub
End Class
