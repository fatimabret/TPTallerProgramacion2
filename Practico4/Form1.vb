Imports System.Security.Cryptography
Imports System.Security.Policy

Public Class Form1
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub btnFuncion_Click(sender As Object, e As EventArgs) Handles btnFuncion.Click
        Dim desde As Integer
        Dim hasta As Integer

        desde = CInt(txtDesde.Text)
        hasta = CInt(txtHasta.Text)

        While (desde <= hasta)
            ListBox1.Items.Add(desde)
            desde = desde + 1
        End While
    End Sub

    Private Sub btnPares_Click(sender As Object, e As EventArgs) Handles btnPares.Click
        Dim desde As Integer
        Dim hasta As Integer

        desde = CInt(txtDesde.Text)
        hasta = CInt(txtHasta.Text)

        While (desde <= hasta)
            If desde Mod 2 = 0 Then
                ListBox1.Items.Add(desde)
            End If
            desde = desde + 1
        End While
    End Sub

    Private Sub txtDesde_TextChanged(sender As Object, e As EventArgs) Handles txtDesde.TextChanged

        If Not IsNumeric(txtDesde.Text) And txtDesde.Text <> "" Then
            MsgBox("Debe ingresar un valor numérico")
            txtDesde.Text = ""
        End If
    End Sub

    Private Sub txtHasta_TextChanged(sender As Object, e As EventArgs) Handles txtHasta.TextChanged
        If Not IsNumeric(txtHasta.Text) And txtHasta.Text <> "" Then
            MsgBox("Debe ingresar un valor numérico")
            txtHasta.Text = ""
        End If
    End Sub

    Private Sub btnImpares_Click(sender As Object, e As EventArgs) Handles btnImpares.Click
        Dim desde As Integer
        Dim hasta As Integer

        desde = CInt(txtDesde.Text)
        hasta = CInt(txtHasta.Text)

        While (desde <= hasta)
            If desde Mod 2 <> 0 Then
                ListBox1.Items.Add(desde)
            End If
            desde = desde + 1
        End While
    End Sub

    Private Sub btnPrimos_Click(sender As Object, e As EventArgs) Handles btnPrimos.Click
        Dim desde As Integer = CInt(txtDesde.Text)
        Dim hasta As Integer = CInt(txtHasta.Text)

        For n As Integer = desde To hasta
            If n > 1 Then
                Dim esPrimo As Boolean = True
                For i As Integer = 2 To Math.Sqrt(n)
                    If n Mod i = 0 Then
                        esPrimo = False
                        Exit For
                    End If
                Next
                If esPrimo Then
                    ListBox1.Items.Add(n)
                End If
            End If
        Next

    End Sub
End Class
