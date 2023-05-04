<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmcliente
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
        GroupBox1 = New GroupBox()
        Label6 = New Label()
        txtdni = New TextBox()
        Label5 = New Label()
        txttelefono = New TextBox()
        Label4 = New Label()
        txtdireccion = New TextBox()
        Label3 = New Label()
        txtapellidos = New TextBox()
        Label2 = New Label()
        txtnombre = New TextBox()
        Label1 = New Label()
        txtidcliente = New TextBox()
        btnnuevo = New Button()
        btneditar = New Button()
        btncancelar = New Button()
        GroupBox2 = New GroupBox()
        btneliminar = New Button()
        inexistente = New LinkLabel()
        txtbuscar = New TextBox()
        cbocampo = New ComboBox()
        datalistado = New DataGridView()
        Eliminar = New DataGridViewCheckBoxColumn()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        CType(datalistado, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(txtdni)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(txttelefono)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(txtdireccion)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(txtapellidos)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(txtnombre)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(txtidcliente)
        GroupBox1.Location = New Point(86, 64)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(422, 353)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Mantenimiento"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(61, 286)
        Label6.Name = "Label6"
        Label6.Size = New Size(27, 15)
        Label6.TabIndex = 11
        Label6.Text = "DNI"
        ' 
        ' txtdni
        ' 
        txtdni.Location = New Point(236, 278)
        txtdni.MaxLength = 8
        txtdni.Name = "txtdni"
        txtdni.Size = New Size(154, 23)
        txtdni.TabIndex = 10
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(61, 237)
        Label5.Name = "Label5"
        Label5.Size = New Size(52, 15)
        Label5.TabIndex = 9
        Label5.Text = "Teléfono"
        ' 
        ' txttelefono
        ' 
        txttelefono.Location = New Point(236, 229)
        txttelefono.MaxLength = 9
        txttelefono.Name = "txttelefono"
        txttelefono.Size = New Size(154, 23)
        txttelefono.TabIndex = 8
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(61, 189)
        Label4.Name = "Label4"
        Label4.Size = New Size(57, 15)
        Label4.TabIndex = 7
        Label4.Text = "Dirección"
        ' 
        ' txtdireccion
        ' 
        txtdireccion.Location = New Point(236, 181)
        txtdireccion.Name = "txtdireccion"
        txtdireccion.Size = New Size(154, 23)
        txtdireccion.TabIndex = 6
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(61, 140)
        Label3.Name = "Label3"
        Label3.Size = New Size(56, 15)
        Label3.TabIndex = 5
        Label3.Text = "Apellidos"
        ' 
        ' txtapellidos
        ' 
        txtapellidos.Location = New Point(236, 132)
        txtapellidos.Name = "txtapellidos"
        txtapellidos.Size = New Size(154, 23)
        txtapellidos.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(61, 94)
        Label2.Name = "Label2"
        Label2.Size = New Size(51, 15)
        Label2.TabIndex = 3
        Label2.Text = "Nombre"
        ' 
        ' txtnombre
        ' 
        txtnombre.Location = New Point(236, 86)
        txtnombre.Name = "txtnombre"
        txtnombre.Size = New Size(154, 23)
        txtnombre.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(61, 52)
        Label1.Name = "Label1"
        Label1.Size = New Size(52, 15)
        Label1.TabIndex = 1
        Label1.Text = "Idcliente"
        ' 
        ' txtidcliente
        ' 
        txtidcliente.Location = New Point(236, 44)
        txtidcliente.Name = "txtidcliente"
        txtidcliente.Size = New Size(154, 23)
        txtidcliente.TabIndex = 0
        ' 
        ' btnnuevo
        ' 
        btnnuevo.Location = New Point(86, 459)
        btnnuevo.Name = "btnnuevo"
        btnnuevo.Size = New Size(75, 23)
        btnnuevo.TabIndex = 1
        btnnuevo.Text = "Nuevo"
        btnnuevo.UseVisualStyleBackColor = True
        ' 
        ' btneditar
        ' 
        btneditar.Location = New Point(243, 459)
        btneditar.Name = "btneditar"
        btneditar.Size = New Size(75, 23)
        btneditar.TabIndex = 2
        btneditar.Text = "Editar"
        btneditar.UseVisualStyleBackColor = True
        ' 
        ' btncancelar
        ' 
        btncancelar.Location = New Point(401, 459)
        btncancelar.Name = "btncancelar"
        btncancelar.Size = New Size(75, 23)
        btncancelar.TabIndex = 3
        btncancelar.Text = "Cancelar"
        btncancelar.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(btneliminar)
        GroupBox2.Controls.Add(inexistente)
        GroupBox2.Controls.Add(txtbuscar)
        GroupBox2.Controls.Add(cbocampo)
        GroupBox2.Controls.Add(datalistado)
        GroupBox2.Location = New Point(576, 64)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(452, 418)
        GroupBox2.TabIndex = 4
        GroupBox2.TabStop = False
        GroupBox2.Text = "Listado de Clientes"
        ' 
        ' btneliminar
        ' 
        btneliminar.Location = New Point(44, 357)
        btneliminar.Name = "btneliminar"
        btneliminar.Size = New Size(75, 23)
        btneliminar.TabIndex = 4
        btneliminar.Text = "Eliminar"
        btneliminar.UseVisualStyleBackColor = True
        ' 
        ' inexistente
        ' 
        inexistente.AutoSize = True
        inexistente.Location = New Point(170, 204)
        inexistente.Name = "inexistente"
        inexistente.Size = New Size(102, 15)
        inexistente.TabIndex = 3
        inexistente.TabStop = True
        inexistente.Text = "Datos inexistentes"
        ' 
        ' txtbuscar
        ' 
        txtbuscar.Location = New Point(188, 35)
        txtbuscar.Name = "txtbuscar"
        txtbuscar.Size = New Size(122, 23)
        txtbuscar.TabIndex = 2
        ' 
        ' cbocampo
        ' 
        cbocampo.FormattingEnabled = True
        cbocampo.Items.AddRange(New Object() {"nombre", "apellidos", "dni", "telefono"})
        cbocampo.Location = New Point(44, 35)
        cbocampo.Name = "cbocampo"
        cbocampo.Size = New Size(121, 23)
        cbocampo.TabIndex = 1
        cbocampo.Text = "dni"
        ' 
        ' datalistado
        ' 
        datalistado.AllowUserToAddRows = False
        datalistado.AllowUserToDeleteRows = False
        datalistado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        datalistado.Columns.AddRange(New DataGridViewColumn() {Eliminar})
        datalistado.Location = New Point(29, 72)
        datalistado.Name = "datalistado"
        datalistado.ReadOnly = True
        datalistado.RowTemplate.Height = 25
        datalistado.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        datalistado.Size = New Size(380, 247)
        datalistado.TabIndex = 0
        ' 
        ' Eliminar
        ' 
        Eliminar.HeaderText = "Eliminar"
        Eliminar.Name = "Eliminar"
        Eliminar.ReadOnly = True
        ' 
        ' frmcliente
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1052, 529)
        Controls.Add(GroupBox2)
        Controls.Add(btncancelar)
        Controls.Add(btneditar)
        Controls.Add(btnnuevo)
        Controls.Add(GroupBox1)
        Name = "frmcliente"
        Text = "- Listado de clientes -"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        CType(datalistado, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtidcliente As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtdni As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txttelefono As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtdireccion As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtapellidos As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents btnnuevo As Button
    Friend WithEvents btneditar As Button
    Friend WithEvents btncancelar As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btneliminar As Button
    Friend WithEvents inexistente As LinkLabel
    Friend WithEvents txtbuscar As TextBox
    Friend WithEvents cbocampo As ComboBox
    Friend WithEvents datalistado As DataGridView
    Friend WithEvents Eliminar As DataGridViewCheckBoxColumn
End Class
