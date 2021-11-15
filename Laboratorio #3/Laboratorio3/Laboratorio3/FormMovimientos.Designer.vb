<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMovimientos
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.dtgMovimientos = New System.Windows.Forms.DataGridView()
        Me.txtNombreCompleto = New System.Windows.Forms.TextBox()
        Me.rdbDepositos = New System.Windows.Forms.RadioButton()
        Me.rdbRetiros = New System.Windows.Forms.RadioButton()
        CType(Me.dtgMovimientos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(413, 31)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "MOVIMIENTOS DEL CLIENTE"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(108, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Cliente:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(108, 166)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 20)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Movimientos:"
        '
        'btnBuscar
        '
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.Location = New System.Drawing.Point(479, 102)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(110, 31)
        Me.btnBuscar.TabIndex = 12
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'dtgMovimientos
        '
        Me.dtgMovimientos.BackgroundColor = System.Drawing.Color.White
        Me.dtgMovimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgMovimientos.Location = New System.Drawing.Point(186, 249)
        Me.dtgMovimientos.Name = "dtgMovimientos"
        Me.dtgMovimientos.ReadOnly = True
        Me.dtgMovimientos.RowHeadersVisible = False
        Me.dtgMovimientos.Size = New System.Drawing.Size(336, 325)
        Me.dtgMovimientos.TabIndex = 13
        '
        'txtNombreCompleto
        '
        Me.txtNombreCompleto.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreCompleto.Location = New System.Drawing.Point(183, 102)
        Me.txtNombreCompleto.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNombreCompleto.Name = "txtNombreCompleto"
        Me.txtNombreCompleto.Size = New System.Drawing.Size(276, 28)
        Me.txtNombreCompleto.TabIndex = 14
        '
        'rdbDepositos
        '
        Me.rdbDepositos.AutoSize = True
        Me.rdbDepositos.Checked = True
        Me.rdbDepositos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbDepositos.Location = New System.Drawing.Point(186, 200)
        Me.rdbDepositos.Name = "rdbDepositos"
        Me.rdbDepositos.Size = New System.Drawing.Size(99, 24)
        Me.rdbDepositos.TabIndex = 16
        Me.rdbDepositos.TabStop = True
        Me.rdbDepositos.Text = "Depositos"
        Me.rdbDepositos.UseVisualStyleBackColor = True
        '
        'rdbRetiros
        '
        Me.rdbRetiros.AutoSize = True
        Me.rdbRetiros.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbRetiros.Location = New System.Drawing.Point(317, 200)
        Me.rdbRetiros.Name = "rdbRetiros"
        Me.rdbRetiros.Size = New System.Drawing.Size(78, 24)
        Me.rdbRetiros.TabIndex = 18
        Me.rdbRetiros.TabStop = True
        Me.rdbRetiros.Text = "Retiros"
        Me.rdbRetiros.UseVisualStyleBackColor = True
        '
        'FormMovimientos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(1065, 586)
        Me.Controls.Add(Me.rdbRetiros)
        Me.Controls.Add(Me.rdbDepositos)
        Me.Controls.Add(Me.txtNombreCompleto)
        Me.Controls.Add(Me.dtgMovimientos)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormMovimientos"
        Me.Text = "FormMovimientos"
        CType(Me.dtgMovimientos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnBuscar As Button
    Friend WithEvents dtgMovimientos As DataGridView
    Friend WithEvents txtNombreCompleto As TextBox
    Friend WithEvents rdbDepositos As RadioButton
    Friend WithEvents rdbRetiros As RadioButton
End Class