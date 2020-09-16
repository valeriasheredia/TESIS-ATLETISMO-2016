<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LISTADOCLUBFEDERACION
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
        Me.lbltotalclub = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtnombreclub = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.Label()
        Me.dgvclubes = New System.Windows.Forms.DataGridView()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        CType(Me.dgvclubes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbltotalclub
        '
        Me.lbltotalclub.AutoSize = True
        Me.lbltotalclub.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbltotalclub.Location = New System.Drawing.Point(719, 322)
        Me.lbltotalclub.Name = "lbltotalclub"
        Me.lbltotalclub.Size = New System.Drawing.Size(2, 15)
        Me.lbltotalclub.TabIndex = 26
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(551, 322)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 13)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Total de Clubes/Federaciones"
        '
        'txtnombreclub
        '
        Me.txtnombreclub.Location = New System.Drawing.Point(235, 18)
        Me.txtnombreclub.Name = "txtnombreclub"
        Me.txtnombreclub.Size = New System.Drawing.Size(149, 20)
        Me.txtnombreclub.TabIndex = 20
        '
        'txtNombre
        '
        Me.txtNombre.AutoSize = True
        Me.txtNombre.Location = New System.Drawing.Point(28, 21)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(201, 13)
        Me.txtNombre.TabIndex = 19
        Me.txtNombre.Text = "Ingresar Nombre del Club y/o Federación"
        '
        'dgvclubes
        '
        Me.dgvclubes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvclubes.Location = New System.Drawing.Point(22, 47)
        Me.dgvclubes.Name = "dgvclubes"
        Me.dgvclubes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvclubes.Size = New System.Drawing.Size(731, 250)
        Me.dgvclubes.TabIndex = 18
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(597, 349)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 38)
        Me.btnEliminar.TabIndex = 90
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(516, 349)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(75, 38)
        Me.btnModificar.TabIndex = 89
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnImprimir
        '
        Me.btnImprimir.Location = New System.Drawing.Point(22, 349)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(75, 38)
        Me.btnImprimir.TabIndex = 88
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(678, 349)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(75, 38)
        Me.btnCerrar.TabIndex = 87
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'LISTADOCLUBFEDERACION
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(779, 399)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.lbltotalclub)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtnombreclub)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.dgvclubes)
        Me.Name = "LISTADOCLUBFEDERACION"
        Me.Text = "LISTADO  CLUB / FEDERACION"
        CType(Me.dgvclubes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbltotalclub As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtnombreclub As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.Label
    Friend WithEvents dgvclubes As System.Windows.Forms.DataGridView
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
End Class
