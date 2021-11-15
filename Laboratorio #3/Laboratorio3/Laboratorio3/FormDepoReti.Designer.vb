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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnDatos = New System.Windows.Forms.Button()
        Me.txtSaldo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnProcesar = New System.Windows.Forms.Button()
        Me.rbDeposito = New System.Windows.Forms.RadioButton()
        Me.rbRetiro = New System.Windows.Forms.RadioButton()
        Me.txtNombreCompleto = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNumCuenta = New System.Windows.Forms.TextBox()
        Me.txtNombreCuenta = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(248, 18)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(368, 39)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "DEPÓSITO / RETIRO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(62, 99)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 25)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Cliente:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(59, 157)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 25)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Cuenta:"
        '
        'btnDatos
        '
        Me.btnDatos.BackgroundImage = Global.Laboratorio3.My.Resources.Resources.lupa
        Me.btnDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDatos.Location = New System.Drawing.Point(633, 99)
        Me.btnDatos.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDatos.Name = "btnDatos"
        Me.btnDatos.Size = New System.Drawing.Size(100, 34)
        Me.btnDatos.TabIndex = 16
        Me.btnDatos.Text = "Datos"
        Me.btnDatos.UseVisualStyleBackColor = True
        '
        'txtSaldo
        '
        Me.txtSaldo.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldo.Location = New System.Drawing.Point(138, 62)
        Me.txtSaldo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.ReadOnly = True
        Me.txtSaldo.Size = New System.Drawing.Size(368, 33)
        Me.txtSaldo.TabIndex = 18
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(45, 66)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 25)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Saldo:"
        '
        'btnProcesar
        '
        Me.btnProcesar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnProcesar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnProcesar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcesar.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProcesar.Location = New System.Drawing.Point(677, 37)
        Me.btnProcesar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnProcesar.Name = "btnProcesar"
        Me.btnProcesar.Size = New System.Drawing.Size(256, 76)
        Me.btnProcesar.TabIndex = 19
        Me.btnProcesar.Text = "Procesar"
        Me.btnProcesar.UseVisualStyleBackColor = False
        '
        'rbDeposito
        '
        Me.rbDeposito.AutoSize = True
        Me.rbDeposito.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbDeposito.Location = New System.Drawing.Point(125, 40)
        Me.rbDeposito.Margin = New System.Windows.Forms.Padding(4)
        Me.rbDeposito.Name = "rbDeposito"
        Me.rbDeposito.Size = New System.Drawing.Size(118, 29)
        Me.rbDeposito.TabIndex = 20
        Me.rbDeposito.TabStop = True
        Me.rbDeposito.Text = "Depósito"
        Me.rbDeposito.UseVisualStyleBackColor = True
        '
        'rbRetiro
        '
        Me.rbRetiro.AutoSize = True
        Me.rbRetiro.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbRetiro.Location = New System.Drawing.Point(599, 40)
        Me.rbRetiro.Margin = New System.Windows.Forms.Padding(4)
        Me.rbRetiro.Name = "rbRetiro"
        Me.rbRetiro.Size = New System.Drawing.Size(89, 29)
        Me.rbRetiro.TabIndex = 21
        Me.rbRetiro.TabStop = True
        Me.rbRetiro.Text = "Retiro"
        Me.rbRetiro.UseVisualStyleBackColor = True
        '
        'txtNombreCompleto
        '
        Me.txtNombreCompleto.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreCompleto.Location = New System.Drawing.Point(156, 95)
        Me.txtNombreCompleto.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNombreCompleto.Name = "txtNombreCompleto"
        Me.txtNombreCompleto.ReadOnly = True
        Me.txtNombreCompleto.Size = New System.Drawing.Size(368, 33)
        Me.txtNombreCompleto.TabIndex = 22
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtNumCuenta)
        Me.GroupBox1.Controls.Add(Me.txtNombreCuenta)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtNombreCompleto)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnDatos)
        Me.GroupBox1.Location = New System.Drawing.Point(99, 30)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(864, 246)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(545, 157)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(116, 25)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "ID Cuenta:"
        '
        'txtNumCuenta
        '
        Me.txtNumCuenta.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumCuenta.Location = New System.Drawing.Point(678, 153)
        Me.txtNumCuenta.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNumCuenta.Name = "txtNumCuenta"
        Me.txtNumCuenta.ReadOnly = True
        Me.txtNumCuenta.Size = New System.Drawing.Size(140, 33)
        Me.txtNumCuenta.TabIndex = 24
        '
        'txtNombreCuenta
        '
        Me.txtNombreCuenta.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreCuenta.Location = New System.Drawing.Point(156, 153)
        Me.txtNombreCuenta.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNombreCuenta.Name = "txtNombreCuenta"
        Me.txtNombreCuenta.ReadOnly = True
        Me.txtNombreCuenta.Size = New System.Drawing.Size(368, 33)
        Me.txtNombreCuenta.TabIndex = 23
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbDeposito)
        Me.GroupBox2.Controls.Add(Me.rbRetiro)
        Me.GroupBox2.Location = New System.Drawing.Point(99, 298)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(918, 100)
        Me.GroupBox2.TabIndex = 24
        Me.GroupBox2.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtSaldo)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.btnProcesar)
        Me.GroupBox3.Location = New System.Drawing.Point(66, 443)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1007, 155)
        Me.GroupBox3.TabIndex = 25
        Me.GroupBox3.TabStop = False
        '
        'FormDepoReti
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(1108, 610)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FormDepoReti"
        Me.Text = " "
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnDatos As Button
    Friend WithEvents txtSaldo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnProcesar As Button
    Friend WithEvents rbDeposito As RadioButton
    Friend WithEvents rbRetiro As RadioButton
    Friend WithEvents txtNombreCompleto As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtNumCuenta As TextBox
    Friend WithEvents txtNombreCuenta As TextBox
End Class
