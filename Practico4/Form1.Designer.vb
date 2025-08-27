<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.lblNumeros = New System.Windows.Forms.Label()
        Me.lblDesde = New System.Windows.Forms.Label()
        Me.lblHasta = New System.Windows.Forms.Label()
        Me.btnFuncion = New System.Windows.Forms.Button()
        Me.txtDesde = New System.Windows.Forms.TextBox()
        Me.txtHasta = New System.Windows.Forms.TextBox()
        Me.btnPares = New System.Windows.Forms.Button()
        Me.btnImpares = New System.Windows.Forms.Button()
        Me.btnPrimos = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(299, 111)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(291, 303)
        Me.ListBox1.TabIndex = 0
        '
        'lblNumeros
        '
        Me.lblNumeros.AutoSize = True
        Me.lblNumeros.Location = New System.Drawing.Point(400, 82)
        Me.lblNumeros.Name = "lblNumeros"
        Me.lblNumeros.Size = New System.Drawing.Size(89, 13)
        Me.lblNumeros.TabIndex = 1
        Me.lblNumeros.Text = "Lista de Numeros"
        '
        'lblDesde
        '
        Me.lblDesde.AutoSize = True
        Me.lblDesde.Location = New System.Drawing.Point(12, 121)
        Me.lblDesde.Name = "lblDesde"
        Me.lblDesde.Size = New System.Drawing.Size(38, 13)
        Me.lblDesde.TabIndex = 2
        Me.lblDesde.Text = "Desde"
        '
        'lblHasta
        '
        Me.lblHasta.AutoSize = True
        Me.lblHasta.Location = New System.Drawing.Point(12, 162)
        Me.lblHasta.Name = "lblHasta"
        Me.lblHasta.Size = New System.Drawing.Size(35, 13)
        Me.lblHasta.TabIndex = 3
        Me.lblHasta.Text = "Hasta"
        '
        'btnFuncion
        '
        Me.btnFuncion.Location = New System.Drawing.Point(171, 111)
        Me.btnFuncion.Name = "btnFuncion"
        Me.btnFuncion.Size = New System.Drawing.Size(105, 23)
        Me.btnFuncion.TabIndex = 4
        Me.btnFuncion.Text = "Generar Función"
        Me.btnFuncion.UseVisualStyleBackColor = True
        '
        'txtDesde
        '
        Me.txtDesde.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDesde.Location = New System.Drawing.Point(56, 114)
        Me.txtDesde.Name = "txtDesde"
        Me.txtDesde.Size = New System.Drawing.Size(100, 20)
        Me.txtDesde.TabIndex = 5
        '
        'txtHasta
        '
        Me.txtHasta.Location = New System.Drawing.Point(56, 155)
        Me.txtHasta.Name = "txtHasta"
        Me.txtHasta.Size = New System.Drawing.Size(100, 20)
        Me.txtHasta.TabIndex = 6
        '
        'btnPares
        '
        Me.btnPares.Location = New System.Drawing.Point(51, 204)
        Me.btnPares.Name = "btnPares"
        Me.btnPares.Size = New System.Drawing.Size(105, 23)
        Me.btnPares.TabIndex = 7
        Me.btnPares.Text = "Numeros Pares"
        Me.btnPares.UseVisualStyleBackColor = True
        '
        'btnImpares
        '
        Me.btnImpares.Location = New System.Drawing.Point(51, 245)
        Me.btnImpares.Name = "btnImpares"
        Me.btnImpares.Size = New System.Drawing.Size(105, 23)
        Me.btnImpares.TabIndex = 8
        Me.btnImpares.Text = "Numeros Impares"
        Me.btnImpares.UseVisualStyleBackColor = True
        '
        'btnPrimos
        '
        Me.btnPrimos.Location = New System.Drawing.Point(51, 284)
        Me.btnPrimos.Name = "btnPrimos"
        Me.btnPrimos.Size = New System.Drawing.Size(105, 23)
        Me.btnPrimos.TabIndex = 9
        Me.btnPrimos.Text = "Numeros Primos"
        Me.btnPrimos.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnPrimos)
        Me.Controls.Add(Me.btnImpares)
        Me.Controls.Add(Me.btnPares)
        Me.Controls.Add(Me.txtHasta)
        Me.Controls.Add(Me.txtDesde)
        Me.Controls.Add(Me.btnFuncion)
        Me.Controls.Add(Me.lblHasta)
        Me.Controls.Add(Me.lblDesde)
        Me.Controls.Add(Me.lblNumeros)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "Form1"
        Me.Text = "Formulario4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents lblNumeros As Label
    Friend WithEvents lblDesde As Label
    Friend WithEvents lblHasta As Label
    Friend WithEvents btnFuncion As Button
    Friend WithEvents txtDesde As TextBox
    Friend WithEvents txtHasta As TextBox
    Friend WithEvents btnPares As Button
    Friend WithEvents btnImpares As Button
    Friend WithEvents btnPrimos As Button
End Class
