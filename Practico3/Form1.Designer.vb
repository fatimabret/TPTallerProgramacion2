<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        LNya = New Label()
        LModificar = New Label()
        LDni = New Label()
        LApellido = New Label()
        LNombre = New Label()
        TDni = New TextBox()
        TApellido = New TextBox()
        TNombre = New TextBox()
        TGuardar = New Button()
        TEliminar = New Button()
        Panel1 = New Panel()
        CheckBox3 = New CheckBox()
        CheckBox2 = New CheckBox()
        CheckBox1 = New CheckBox()
        LTarjetas = New Label()
        PictureBox1 = New PictureBox()
        RBVaron = New RadioButton()
        RBMujer = New RadioButton()
        Label1 = New Label()
        TSalir = New Button()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' LNya
        ' 
        LNya.AutoSize = True
        LNya.Location = New Point(12, 23)
        LNya.Name = "LNya"
        LNya.Size = New Size(110, 15)
        LNya.TabIndex = 0
        LNya.Text = "Nombre y Apellido:"
        ' 
        ' LModificar
        ' 
        LModificar.AutoSize = True
        LModificar.BackColor = SystemColors.AppWorkspace
        LModificar.ForeColor = Color.Red
        LModificar.Location = New Point(130, 23)
        LModificar.Name = "LModificar"
        LModificar.Size = New Size(58, 15)
        LModificar.TabIndex = 1
        LModificar.Text = "modificar"
        ' 
        ' LDni
        ' 
        LDni.AutoSize = True
        LDni.Location = New Point(11, 74)
        LDni.Name = "LDni"
        LDni.Size = New Size(25, 15)
        LDni.TabIndex = 2
        LDni.Text = "Dni"
        ' 
        ' LApellido
        ' 
        LApellido.AutoSize = True
        LApellido.Location = New Point(11, 123)
        LApellido.Name = "LApellido"
        LApellido.Size = New Size(51, 15)
        LApellido.TabIndex = 3
        LApellido.Text = "Apellido"
        ' 
        ' LNombre
        ' 
        LNombre.AutoSize = True
        LNombre.Location = New Point(11, 180)
        LNombre.Name = "LNombre"
        LNombre.Size = New Size(51, 15)
        LNombre.TabIndex = 4
        LNombre.Text = "Nombre"
        ' 
        ' TDni
        ' 
        TDni.Location = New Point(88, 66)
        TDni.Name = "TDni"
        TDni.Size = New Size(100, 23)
        TDni.TabIndex = 5
        ' 
        ' TApellido
        ' 
        TApellido.Location = New Point(88, 115)
        TApellido.Name = "TApellido"
        TApellido.Size = New Size(100, 23)
        TApellido.TabIndex = 6
        ' 
        ' TNombre
        ' 
        TNombre.Location = New Point(88, 172)
        TNombre.Name = "TNombre"
        TNombre.Size = New Size(100, 23)
        TNombre.TabIndex = 7
        ' 
        ' TGuardar
        ' 
        TGuardar.Image = My.Resources.Resources.vintage
        TGuardar.ImageAlign = ContentAlignment.MiddleLeft
        TGuardar.Location = New Point(38, 441)
        TGuardar.Name = "TGuardar"
        TGuardar.Size = New Size(91, 61)
        TGuardar.TabIndex = 8
        TGuardar.Text = "Guardar"
        TGuardar.TextAlign = ContentAlignment.MiddleRight
        TGuardar.UseVisualStyleBackColor = True
        ' 
        ' TEliminar
        ' 
        TEliminar.Image = My.Resources.Resources.garbage
        TEliminar.ImageAlign = ContentAlignment.MiddleLeft
        TEliminar.Location = New Point(157, 441)
        TEliminar.Name = "TEliminar"
        TEliminar.Size = New Size(98, 61)
        TEliminar.TabIndex = 9
        TEliminar.Text = "Eliminar"
        TEliminar.TextAlign = ContentAlignment.MiddleRight
        TEliminar.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.AppWorkspace
        Panel1.Controls.Add(CheckBox3)
        Panel1.Controls.Add(CheckBox2)
        Panel1.Controls.Add(CheckBox1)
        Panel1.Controls.Add(LTarjetas)
        Panel1.Controls.Add(TApellido)
        Panel1.Controls.Add(LNya)
        Panel1.Controls.Add(LModificar)
        Panel1.Controls.Add(TNombre)
        Panel1.Controls.Add(LDni)
        Panel1.Controls.Add(LApellido)
        Panel1.Controls.Add(TDni)
        Panel1.Controls.Add(LNombre)
        Panel1.Location = New Point(38, 88)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(211, 300)
        Panel1.TabIndex = 10
        ' 
        ' CheckBox3
        ' 
        CheckBox3.AutoSize = True
        CheckBox3.Location = New Point(119, 278)
        CheckBox3.Name = "CheckBox3"
        CheckBox3.Size = New Size(85, 19)
        CheckBox3.TabIndex = 11
        CheckBox3.Text = "Mastercard"
        CheckBox3.UseVisualStyleBackColor = True
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.Location = New Point(119, 253)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(47, 19)
        CheckBox2.TabIndex = 10
        CheckBox2.Text = "Visa"
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(119, 228)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(67, 19)
        CheckBox1.TabIndex = 9
        CheckBox1.Text = "Naranja"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' LTarjetas
        ' 
        LTarjetas.AutoSize = True
        LTarjetas.Location = New Point(12, 227)
        LTarjetas.Name = "LTarjetas"
        LTarjetas.Size = New Size(102, 15)
        LTarjetas.TabIndex = 8
        LTarjetas.Text = "Tarjeta de creditos"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.LogoVaron
        PictureBox1.Location = New Point(255, 88)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(117, 138)
        PictureBox1.TabIndex = 11
        PictureBox1.TabStop = False
        PictureBox1.UseWaitCursor = True
        ' 
        ' RBVaron
        ' 
        RBVaron.AutoSize = True
        RBVaron.Checked = True
        RBVaron.Location = New Point(255, 240)
        RBVaron.Name = "RBVaron"
        RBVaron.Size = New Size(55, 19)
        RBVaron.TabIndex = 12
        RBVaron.TabStop = True
        RBVaron.Text = "Varon"
        RBVaron.UseVisualStyleBackColor = True
        ' 
        ' RBMujer
        ' 
        RBMujer.AutoSize = True
        RBMujer.Location = New Point(316, 240)
        RBMujer.Name = "RBMujer"
        RBMujer.Size = New Size(56, 19)
        RBMujer.TabIndex = 13
        RBMujer.Text = "Mujer"
        RBMujer.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(157, 29)
        Label1.Name = "Label1"
        Label1.Size = New Size(82, 15)
        Label1.TabIndex = 14
        Label1.Text = "Nuevo Cliente"
        ' 
        ' TSalir
        ' 
        TSalir.Image = My.Resources.Resources._exit
        TSalir.ImageAlign = ContentAlignment.MiddleLeft
        TSalir.Location = New Point(273, 441)
        TSalir.Name = "TSalir"
        TSalir.Size = New Size(84, 61)
        TSalir.TabIndex = 15
        TSalir.Text = "Salir"
        TSalir.TextAlign = ContentAlignment.MiddleRight
        TSalir.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(384, 561)
        Controls.Add(TSalir)
        Controls.Add(Label1)
        Controls.Add(RBMujer)
        Controls.Add(RBVaron)
        Controls.Add(PictureBox1)
        Controls.Add(Panel1)
        Controls.Add(TEliminar)
        Controls.Add(TGuardar)
        Name = "Form1"
        Text = "Pequeño Formulario"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LNya As Label
    Friend WithEvents LModificar As Label
    Friend WithEvents LDni As Label
    Friend WithEvents LApellido As Label
    Friend WithEvents LNombre As Label
    Friend WithEvents TDni As TextBox
    Friend WithEvents TApellido As TextBox
    Friend WithEvents TNombre As TextBox
    Friend WithEvents TGuardar As Button
    Friend WithEvents TEliminar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents RBVaron As RadioButton
    Friend WithEvents RBMujer As RadioButton
    Friend WithEvents LTarjetas As Label
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TSalir As Button

End Class
