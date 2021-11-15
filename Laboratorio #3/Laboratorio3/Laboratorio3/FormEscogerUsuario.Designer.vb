<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEscogerUsuario
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtgListaUsuarios = New System.Windows.Forms.DataGridView()
        CType(Me.dtgListaUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(659, 50)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Elija el usuario a realizar la acción"
        '
        'dtgListaUsuarios
        '
        Me.dtgListaUsuarios.AllowUserToAddRows = False
        Me.dtgListaUsuarios.AllowUserToDeleteRows = False
        Me.dtgListaUsuarios.BackgroundColor = System.Drawing.Color.RoyalBlue
        Me.dtgListaUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dtgListaUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgListaUsuarios.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtgListaUsuarios.Location = New System.Drawing.Point(67, 108)
        Me.dtgListaUsuarios.Name = "dtgListaUsuarios"
        Me.dtgListaUsuarios.ReadOnly = True
        Me.dtgListaUsuarios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dtgListaUsuarios.RowHeadersWidth = 51
        Me.dtgListaUsuarios.RowTemplate.Height = 24
        Me.dtgListaUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgListaUsuarios.Size = New System.Drawing.Size(924, 384)
        Me.dtgListaUsuarios.TabIndex = 1
        '
        'FormEscogerUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.dtgListaUsuarios)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormEscogerUsuario"
        Me.Text = "Escoger Usuario"
        CType(Me.dtgListaUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents dtgListaUsuarios As DataGridView
End Class
