<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDepoReti
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
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnDatos = New System.Windows.Forms.Button()
        Me.txtNombre1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnProcesar = New System.Windows.Forms.Button()
        Me.rbDeposito = New System.Windows.Forms.RadioButton()
        Me.rbRetiro = New System.Windows.Forms.RadioButton()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(298, 31)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "DEPÓSITO / RETIRO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(106, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 20)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Cliente:"
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(181, 136)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(277, 28)
        Me.ComboBox1.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(104, 139)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 20)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Cuenta:"
        '
        'btnDatos
        '
        Me.btnDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDatos.Location = New System.Drawing.Point(463, 101)
        Me.btnDatos.Name = "btnDatos"
        Me.btnDatos.Size = New System.Drawing.Size(75, 28)
        Me.btnDatos.TabIndex = 16
        Me.btnDatos.Text = "Datos"
        Me.btnDatos.UseVisualStyleBackColor = True
        '
        'txtNombre1
        '
        Me.txtNombre1.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre1.Location = New System.Drawing.Point(181, 237)
        Me.txtNombre1.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNombre1.Name = "txtNombre1"
        Me.txtNombre1.Size = New System.Drawing.Size(277, 28)
        Me.txtNombre1.TabIndex = 18
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(116, 241)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 20)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Saldo:"
        '
        'btnProcesar
        '
        Me.btnProcesar.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProcesar.Location = New System.Drawing.Point(244, 292)
        Me.btnProcesar.Name = "btnProcesar"
        Me.btnProcesar.Size = New System.Drawing.Size(148, 40)
        Me.btnProcesar.TabIndex = 19
        Me.btnProcesar.Text = "Procesar"
        Me.btnProcesar.UseVisualStyleBackColor = True
        '
        'rbDeposito
        '
        Me.rbDeposito.AutoSize = True
        Me.rbDeposito.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbDeposito.Location = New System.Drawing.Point(182, 198)
        Me.rbDeposito.Name = "rbDeposito"
        Me.rbDeposito.Size = New System.Drawing.Size(99, 24)
        Me.rbDeposito.TabIndex = 20
        Me.rbDeposito.TabStop = True
        Me.rbDeposito.Text = "Depósito"
        Me.rbDeposito.UseVisualStyleBackColor = True
        '
        'rbRetiro
        '
        Me.rbRetiro.AutoSize = True
        Me.rbRetiro.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbRetiro.Location = New System.Drawing.Point(287, 198)
        Me.rbRetiro.Name = "rbRetiro"
        Me.rbRetiro.Size = New System.Drawing.Size(76, 24)
        Me.rbRetiro.TabIndex = 21
        Me.rbRetiro.TabStop = True
        Me.rbRetiro.Text = "Retiro"
        Me.rbRetiro.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(181, 101)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(277, 28)
        Me.TextBox1.TabIndex = 22
        '
        'FormDepoReti
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(619, 352)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.rbRetiro)
        Me.Controls.Add(Me.rbDeposito)
        Me.Controls.Add(Me.btnProcesar)
        Me.Controls.Add(Me.txtNombre1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnDatos)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormDepoReti"
        Me.Text = "FormDepoReti"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnDatos As Button
    Friend WithEvents txtNombre1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnProcesar As Button
    Friend WithEvents rbDeposito As RadioButton
    Friend WithEvents rbRetiro As RadioButton
    Friend WithEvents TextBox1 As TextBox
End Class
