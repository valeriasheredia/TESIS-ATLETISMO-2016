<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LISTACOMPETENCIAS
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
        Me.lblIngresarNombre = New System.Windows.Forms.Label()
        Me.txtNombreCompetenciaCalle = New System.Windows.Forms.TextBox()
        Me.dgvCompetencias = New System.Windows.Forms.DataGridView()
        Me.lbltotalcompetencias = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnEditarCompetencia = New System.Windows.Forms.Button()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.rbtDistancia = New System.Windows.Forms.RadioButton()
        Me.rbtDisciplina = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbtTodas = New System.Windows.Forms.RadioButton()
        Me.btnNuevaCompetencia = New System.Windows.Forms.Button()
        Me.btnEditarListaAtletas = New System.Windows.Forms.Button()
        CType(Me.dgvCompetencias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblIngresarNombre
        '
        Me.lblIngresarNombre.AutoSize = True
        Me.lblIngresarNombre.Location = New System.Drawing.Point(583, 81)
        Me.lblIngresarNombre.Name = "lblIngresarNombre"
        Me.lblIngresarNombre.Size = New System.Drawing.Size(85, 13)
        Me.lblIngresarNombre.TabIndex = 24
        Me.lblIngresarNombre.Text = "Ingresar Nombre"
        '
        'txtNombreCompetenciaCalle
        '
        Me.txtNombreCompetenciaCalle.Location = New System.Drawing.Point(674, 78)
        Me.txtNombreCompetenciaCalle.Name = "txtNombreCompetenciaCalle"
        Me.txtNombreCompetenciaCalle.Size = New System.Drawing.Size(291, 20)
        Me.txtNombreCompetenciaCalle.TabIndex = 22
        '
        'dgvCompetencias
        '
        Me.dgvCompetencias.AllowUserToAddRows = False
        Me.dgvCompetencias.AllowUserToDeleteRows = False
        Me.dgvCompetencias.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvCompetencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCompetencias.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvCompetencias.Location = New System.Drawing.Point(12, 123)
        Me.dgvCompetencias.MultiSelect = False
        Me.dgvCompetencias.Name = "dgvCompetencias"
        Me.dgvCompetencias.ReadOnly = True
        Me.dgvCompetencias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCompetencias.Size = New System.Drawing.Size(971, 208)
        Me.dgvCompetencias.TabIndex = 20
        '
        'lbltotalcompetencias
        '
        Me.lbltotalcompetencias.AutoSize = True
        Me.lbltotalcompetencias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbltotalcompetencias.Location = New System.Drawing.Point(965, 344)
        Me.lbltotalcompetencias.Name = "lbltotalcompetencias"
        Me.lbltotalcompetencias.Size = New System.Drawing.Size(2, 15)
        Me.lbltotalcompetencias.TabIndex = 37
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(841, 344)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 13)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Total de Competencias"
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(827, 371)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar.TabIndex = 90
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnEditarCompetencia
        '
        Me.btnEditarCompetencia.Location = New System.Drawing.Point(577, 371)
        Me.btnEditarCompetencia.Name = "btnEditarCompetencia"
        Me.btnEditarCompetencia.Size = New System.Drawing.Size(110, 23)
        Me.btnEditarCompetencia.TabIndex = 89
        Me.btnEditarCompetencia.Text = "Editar Competencia"
        Me.btnEditarCompetencia.UseVisualStyleBackColor = True
        '
        'btnImprimir
        '
        Me.btnImprimir.Location = New System.Drawing.Point(12, 371)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(75, 23)
        Me.btnImprimir.TabIndex = 88
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(908, 371)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(75, 23)
        Me.btnCerrar.TabIndex = 87
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'rbtDistancia
        '
        Me.rbtDistancia.AutoSize = True
        Me.rbtDistancia.Location = New System.Drawing.Point(6, 56)
        Me.rbtDistancia.Name = "rbtDistancia"
        Me.rbtDistancia.Size = New System.Drawing.Size(48, 17)
        Me.rbtDistancia.TabIndex = 93
        Me.rbtDistancia.TabStop = True
        Me.rbtDistancia.Text = "Calle"
        Me.rbtDistancia.UseVisualStyleBackColor = True
        '
        'rbtDisciplina
        '
        Me.rbtDisciplina.AutoSize = True
        Me.rbtDisciplina.Location = New System.Drawing.Point(6, 79)
        Me.rbtDisciplina.Name = "rbtDisciplina"
        Me.rbtDisciplina.Size = New System.Drawing.Size(92, 17)
        Me.rbtDisciplina.TabIndex = 94
        Me.rbtDisciplina.TabStop = True
        Me.rbtDisciplina.Text = "Pista y Campo"
        Me.rbtDisciplina.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbtTodas)
        Me.GroupBox1.Controls.Add(Me.rbtDisciplina)
        Me.GroupBox1.Controls.Add(Me.rbtDistancia)
        Me.GroupBox1.Controls.Add(Me.lblIngresarNombre)
        Me.GroupBox1.Controls.Add(Me.txtNombreCompetenciaCalle)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(971, 105)
        Me.GroupBox1.TabIndex = 96
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buscar por"
        '
        'rbtTodas
        '
        Me.rbtTodas.AutoSize = True
        Me.rbtTodas.Location = New System.Drawing.Point(6, 33)
        Me.rbtTodas.Name = "rbtTodas"
        Me.rbtTodas.Size = New System.Drawing.Size(55, 17)
        Me.rbtTodas.TabIndex = 95
        Me.rbtTodas.TabStop = True
        Me.rbtTodas.Text = "Todas"
        Me.rbtTodas.UseVisualStyleBackColor = True
        '
        'btnNuevaCompetencia
        '
        Me.btnNuevaCompetencia.Location = New System.Drawing.Point(463, 371)
        Me.btnNuevaCompetencia.Name = "btnNuevaCompetencia"
        Me.btnNuevaCompetencia.Size = New System.Drawing.Size(108, 23)
        Me.btnNuevaCompetencia.TabIndex = 97
        Me.btnNuevaCompetencia.Text = "Agregar Nueva"
        Me.btnNuevaCompetencia.UseVisualStyleBackColor = True
        '
        'btnEditarListaAtletas
        '
        Me.btnEditarListaAtletas.Location = New System.Drawing.Point(693, 371)
        Me.btnEditarListaAtletas.Name = "btnEditarListaAtletas"
        Me.btnEditarListaAtletas.Size = New System.Drawing.Size(128, 23)
        Me.btnEditarListaAtletas.TabIndex = 97
        Me.btnEditarListaAtletas.Text = "Editar Lista de Atletas"
        Me.btnEditarListaAtletas.UseVisualStyleBackColor = True
        '
        'LISTACOMPETENCIAS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(998, 401)
        Me.Controls.Add(Me.btnEditarListaAtletas)
        Me.Controls.Add(Me.btnNuevaCompetencia)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnEditarCompetencia)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.lbltotalcompetencias)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvCompetencias)
        Me.Name = "LISTACOMPETENCIAS"
        Me.Text = "LISTA DE COMPETENCIAS"
        CType(Me.dgvCompetencias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblIngresarNombre As System.Windows.Forms.Label
    Friend WithEvents txtNombreCompetenciaCalle As System.Windows.Forms.TextBox
    Friend WithEvents dgvCompetencias As System.Windows.Forms.DataGridView
    Friend WithEvents lbltotalcompetencias As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnEditarCompetencia As System.Windows.Forms.Button
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents rbtDistancia As System.Windows.Forms.RadioButton
    Friend WithEvents rbtDisciplina As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbtTodas As System.Windows.Forms.RadioButton
    Friend WithEvents btnNuevaCompetencia As System.Windows.Forms.Button
    Friend WithEvents btnEditarListaAtletas As System.Windows.Forms.Button
End Class
