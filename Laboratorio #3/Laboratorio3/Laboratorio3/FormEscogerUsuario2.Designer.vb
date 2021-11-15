<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormEscogerUsuario2
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.dtgListaUsuarios2 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dtgListaUsuarios2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtgListaUsuarios2
        '
        Me.dtgListaUsuarios2.AllowUserToAddRows = False
        Me.dtgListaUsuarios2.AllowUserToDeleteRows = False
        Me.dtgListaUsuarios2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgListaUsuarios2.Location = New System.Drawing.Point(75, 129)
        Me.dtgListaUsuarios2.Name = "dtgListaUsuarios2"
        Me.dtgListaUsuarios2.ReadOnly = True
        Me.dtgListaUsuarios2.RowHeadersWidth = 51
        Me.dtgListaUsuarios2.RowTemplate.Height = 24
        Me.dtgListaUsuarios2.Size = New System.Drawing.Size(924, 384)
        Me.dtgListaUsuarios2.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(50, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(659, 50)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Elija el usuario a realizar la acción"
        '
        'FormEscogerUsuario2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.dtgListaUsuarios2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormEscogerUsuario2"
        Me.Text = "Escoger Usuario"
        CType(Me.dtgListaUsuarios2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtgListaUsuarios2 As DataGridView
    Friend WithEvents Label1 As Label
End Class
