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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Panel1 = New Panel()
        btnFoto = New Button()
        TxtFoto = New TextBox()
        txtSaldo = New TextBox()
        txtApellido = New TextBox()
        txtNombre = New TextBox()
        rbMujer = New RadioButton()
        rbHombre = New RadioButton()
        Label5 = New Label()
        Label4 = New Label()
        DateTimePicker1 = New DateTimePicker()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Button1 = New Button()
        picFoto = New PictureBox()
        OpenFileDialog1 = New OpenFileDialog()
        DataGridView1 = New DataGridView()
        apellido = New DataGridViewTextBoxColumn()
        nombre = New DataGridViewTextBoxColumn()
        fechNac = New DataGridViewTextBoxColumn()
        sexo = New DataGridViewTextBoxColumn()
        eliminar = New DataGridViewButtonColumn()
        saldo = New DataGridViewTextBoxColumn()
        foto = New DataGridViewImageColumn()
        ruta = New DataGridViewTextBoxColumn()
        Panel1.SuspendLayout()
        CType(picFoto, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackgroundImage = My.Resources.Resources.catt
        Panel1.BackgroundImageLayout = ImageLayout.Stretch
        Panel1.Controls.Add(btnFoto)
        Panel1.Controls.Add(TxtFoto)
        Panel1.Controls.Add(txtSaldo)
        Panel1.Controls.Add(txtApellido)
        Panel1.Controls.Add(txtNombre)
        Panel1.Controls.Add(rbMujer)
        Panel1.Controls.Add(rbHombre)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(DateTimePicker1)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Button1)
        Panel1.Location = New Point(36, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(451, 257)
        Panel1.TabIndex = 0
        ' 
        ' btnFoto
        ' 
        btnFoto.Cursor = Cursors.Hand
        btnFoto.Font = New Font("Arial Narrow", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnFoto.Location = New Point(28, 173)
        btnFoto.Name = "btnFoto"
        btnFoto.Size = New Size(75, 23)
        btnFoto.TabIndex = 13
        btnFoto.Text = "Foto"
        btnFoto.UseVisualStyleBackColor = True
        ' 
        ' TxtFoto
        ' 
        TxtFoto.Font = New Font("Arial Narrow", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TxtFoto.Location = New Point(154, 174)
        TxtFoto.Name = "TxtFoto"
        TxtFoto.Size = New Size(265, 20)
        TxtFoto.TabIndex = 12
        ' 
        ' txtSaldo
        ' 
        txtSaldo.Font = New Font("Arial Narrow", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtSaldo.Location = New Point(154, 142)
        txtSaldo.Name = "txtSaldo"
        txtSaldo.Size = New Size(265, 20)
        txtSaldo.TabIndex = 11
        ' 
        ' txtApellido
        ' 
        txtApellido.Font = New Font("Arial Narrow", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtApellido.Location = New Point(154, 45)
        txtApellido.Name = "txtApellido"
        txtApellido.Size = New Size(265, 20)
        txtApellido.TabIndex = 10
        ' 
        ' txtNombre
        ' 
        txtNombre.Font = New Font("Arial Narrow", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtNombre.Location = New Point(154, 11)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(265, 20)
        txtNombre.TabIndex = 9
        ' 
        ' rbMujer
        ' 
        rbMujer.AutoSize = True
        rbMujer.BackColor = SystemColors.ActiveCaptionText
        rbMujer.Cursor = Cursors.Hand
        rbMujer.Font = New Font("Papyrus", 9.75F)
        rbMujer.ForeColor = Color.White
        rbMujer.Location = New Point(239, 107)
        rbMujer.Name = "rbMujer"
        rbMujer.Size = New Size(63, 25)
        rbMujer.TabIndex = 8
        rbMujer.Text = "Mujer"
        rbMujer.UseVisualStyleBackColor = False
        ' 
        ' rbHombre
        ' 
        rbHombre.AutoSize = True
        rbHombre.BackColor = SystemColors.ActiveCaptionText
        rbHombre.Checked = True
        rbHombre.Cursor = Cursors.Hand
        rbHombre.Font = New Font("Papyrus", 9.75F)
        rbHombre.ForeColor = Color.White
        rbHombre.Location = New Point(155, 107)
        rbHombre.Name = "rbHombre"
        rbHombre.Size = New Size(78, 25)
        rbHombre.TabIndex = 7
        rbHombre.TabStop = True
        rbHombre.Text = "Hombre"
        rbHombre.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = SystemColors.ActiveCaptionText
        Label5.ForeColor = Color.White
        Label5.Location = New Point(21, 135)
        Label5.Name = "Label5"
        Label5.Size = New Size(82, 34)
        Label5.TabIndex = 6
        Label5.Text = "Saldo:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = SystemColors.ActiveCaptionText
        Label4.ForeColor = Color.White
        Label4.Location = New Point(21, 101)
        Label4.Name = "Label4"
        Label4.Size = New Size(74, 34)
        Label4.TabIndex = 5
        Label4.Text = "Sexo:"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.CalendarFont = New Font("Arial Narrow", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DateTimePicker1.Cursor = Cursors.Hand
        DateTimePicker1.Font = New Font("Arial Narrow", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DateTimePicker1.Format = DateTimePickerFormat.Short
        DateTimePicker1.Location = New Point(251, 76)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(77, 22)
        DateTimePicker1.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = SystemColors.ActiveCaptionText
        Label3.ForeColor = Color.White
        Label3.Location = New Point(21, 68)
        Label3.Name = "Label3"
        Label3.Size = New Size(194, 34)
        Label3.TabIndex = 3
        Label3.Text = "Fecha Nacimiento:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.ActiveCaptionText
        Label2.ForeColor = Color.White
        Label2.Location = New Point(21, 38)
        Label2.Name = "Label2"
        Label2.Size = New Size(104, 34)
        Label2.TabIndex = 2
        Label2.Text = "Apellido:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.ActiveCaptionText
        Label1.ForeColor = Color.White
        Label1.Location = New Point(21, 4)
        Label1.Name = "Label1"
        Label1.Size = New Size(96, 34)
        Label1.TabIndex = 1
        Label1.Text = "Nombre:"
        ' 
        ' Button1
        ' 
        Button1.Cursor = Cursors.Hand
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Arial", 8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.Image = My.Resources.Resources.vintage
        Button1.ImageAlign = ContentAlignment.MiddleLeft
        Button1.Location = New Point(185, 207)
        Button1.Margin = New Padding(1)
        Button1.Name = "Button1"
        Button1.Size = New Size(91, 39)
        Button1.TabIndex = 0
        Button1.Text = "Guardar"
        Button1.TextAlign = ContentAlignment.MiddleRight
        Button1.TextImageRelation = TextImageRelation.ImageBeforeText
        Button1.UseVisualStyleBackColor = True
        ' 
        ' picFoto
        ' 
        picFoto.BackgroundImageLayout = ImageLayout.Stretch
        picFoto.Location = New Point(516, 12)
        picFoto.Name = "picFoto"
        picFoto.Size = New Size(232, 257)
        picFoto.TabIndex = 1
        picFoto.TabStop = False
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' DataGridView1
        ' 
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Arial Narrow", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {apellido, nombre, fechNac, sexo, eliminar, saldo, foto, ruta})
        DataGridView1.Location = New Point(36, 293)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 40
        DataGridView1.RowTemplate.Height = 100
        DataGridView1.RowTemplate.Resizable = DataGridViewTriState.True
        DataGridView1.Size = New Size(712, 236)
        DataGridView1.TabIndex = 2
        ' 
        ' apellido
        ' 
        apellido.HeaderText = "Apellido"
        apellido.Name = "apellido"
        ' 
        ' nombre
        ' 
        nombre.HeaderText = "Nombre"
        nombre.Name = "nombre"
        ' 
        ' fechNac
        ' 
        fechNac.HeaderText = "Fecha Nacimiento"
        fechNac.Name = "fechNac"
        ' 
        ' sexo
        ' 
        sexo.HeaderText = "Sexo"
        sexo.Name = "sexo"
        sexo.Resizable = DataGridViewTriState.True
        ' 
        ' eliminar
        ' 
        eliminar.HeaderText = "Eliminar"
        eliminar.Name = "eliminar"
        eliminar.Resizable = DataGridViewTriState.True
        eliminar.SortMode = DataGridViewColumnSortMode.Automatic
        ' 
        ' saldo
        ' 
        saldo.HeaderText = "Saldo"
        saldo.Name = "saldo"
        ' 
        ' foto
        ' 
        foto.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        foto.HeaderText = "Foto"
        foto.Name = "foto"
        foto.Resizable = DataGridViewTriState.True
        foto.SortMode = DataGridViewColumnSortMode.Automatic
        foto.Width = 50
        ' 
        ' ruta
        ' 
        ruta.HeaderText = "Ruta"
        ruta.Name = "ruta"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(14F, 33F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.tony
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(786, 541)
        Controls.Add(DataGridView1)
        Controls.Add(picFoto)
        Controls.Add(Panel1)
        Font = New Font("Papyrus", 16F)
        Margin = New Padding(5, 7, 5, 7)
        Name = "Form1"
        Text = "Formulario con DataGrid"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(picFoto, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents rbHombre As RadioButton
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents rbMujer As RadioButton
    Friend WithEvents btnFoto As Button
    Friend WithEvents TxtFoto As TextBox
    Friend WithEvents txtSaldo As TextBox
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents picFoto As PictureBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents apellido As DataGridViewTextBoxColumn
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents fechNac As DataGridViewTextBoxColumn
    Friend WithEvents sexo As DataGridViewTextBoxColumn
    Friend WithEvents eliminar As DataGridViewButtonColumn
    Friend WithEvents saldo As DataGridViewTextBoxColumn
    Friend WithEvents foto As DataGridViewImageColumn
    Friend WithEvents ruta As DataGridViewTextBoxColumn

End Class
