<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLicencia
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtSerial5 = New System.Windows.Forms.TextBox()
        Me.txtSerial4 = New System.Windows.Forms.TextBox()
        Me.txtSerial3 = New System.Windows.Forms.TextBox()
        Me.txtSerial2 = New System.Windows.Forms.TextBox()
        Me.txtSerial1 = New System.Windows.Forms.TextBox()
        Me.btnRegistar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblInformacion = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtSerial5)
        Me.GroupBox1.Controls.Add(Me.txtSerial4)
        Me.GroupBox1.Controls.Add(Me.txtSerial3)
        Me.GroupBox1.Controls.Add(Me.txtSerial2)
        Me.GroupBox1.Controls.Add(Me.txtSerial1)
        Me.GroupBox1.Controls.Add(Me.btnRegistar)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 172)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(275, 132)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Registro del Producto "
        '
        'txtSerial5
        '
        Me.txtSerial5.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSerial5.Location = New System.Drawing.Point(216, 54)
        Me.txtSerial5.MaxLength = 5
        Me.txtSerial5.Name = "txtSerial5"
        Me.txtSerial5.Size = New System.Drawing.Size(45, 20)
        Me.txtSerial5.TabIndex = 14
        Me.txtSerial5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSerial4
        '
        Me.txtSerial4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSerial4.Location = New System.Drawing.Point(165, 54)
        Me.txtSerial4.MaxLength = 5
        Me.txtSerial4.Name = "txtSerial4"
        Me.txtSerial4.Size = New System.Drawing.Size(45, 20)
        Me.txtSerial4.TabIndex = 13
        Me.txtSerial4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSerial3
        '
        Me.txtSerial3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSerial3.Location = New System.Drawing.Point(114, 54)
        Me.txtSerial3.MaxLength = 5
        Me.txtSerial3.Name = "txtSerial3"
        Me.txtSerial3.Size = New System.Drawing.Size(45, 20)
        Me.txtSerial3.TabIndex = 12
        Me.txtSerial3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSerial2
        '
        Me.txtSerial2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSerial2.Location = New System.Drawing.Point(63, 54)
        Me.txtSerial2.MaxLength = 5
        Me.txtSerial2.Name = "txtSerial2"
        Me.txtSerial2.Size = New System.Drawing.Size(45, 20)
        Me.txtSerial2.TabIndex = 11
        Me.txtSerial2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSerial1
        '
        Me.txtSerial1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSerial1.Location = New System.Drawing.Point(12, 54)
        Me.txtSerial1.MaxLength = 5
        Me.txtSerial1.Name = "txtSerial1"
        Me.txtSerial1.Size = New System.Drawing.Size(45, 20)
        Me.txtSerial1.TabIndex = 10
        Me.txtSerial1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnRegistar
        '
        Me.btnRegistar.Location = New System.Drawing.Point(186, 96)
        Me.btnRegistar.Name = "btnRegistar"
        Me.btnRegistar.Size = New System.Drawing.Size(75, 23)
        Me.btnRegistar.TabIndex = 9
        Me.btnRegistar.Text = "Registrar"
        Me.btnRegistar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(67, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Escriba la Clave del Producto"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.lblInformacion)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(275, 154)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Información del Estado del Sistema "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(57, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(153, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Categoría de Licencia:  DEMO"
        '
        'lblInformacion
        '
        Me.lblInformacion.AutoSize = True
        Me.lblInformacion.Location = New System.Drawing.Point(57, 87)
        Me.lblInformacion.Name = "lblInformacion"
        Me.lblInformacion.Size = New System.Drawing.Size(148, 13)
        Me.lblInformacion.TabIndex = 0
        Me.lblInformacion.Text = "Periodo de prueba de 30 días"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Location = New System.Drawing.Point(293, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(379, 154)
        Me.GroupBox3.TabIndex = 10
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Contacto con Analistas - Diseñadores - Promotores "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(89, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(163, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Miguel Quinteiro: xxxx@xxxx.com"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(89, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(193, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Darwinson Rodríguez:  xxxx@xxxx.com"
        '
        'GroupBox4
        '
        Me.GroupBox4.Location = New System.Drawing.Point(12, 310)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(660, 72)
        Me.GroupBox4.TabIndex = 11
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Otros Datos Importantes sobre el derecho de uso "
        '
        'GroupBox5
        '
        Me.GroupBox5.Location = New System.Drawing.Point(293, 172)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(379, 132)
        Me.GroupBox5.TabIndex = 12
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Formas de Pago "
        '
        'frmLicencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 394)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmLicencia"
        Me.Text = "Licencia"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtSerial1 As System.Windows.Forms.TextBox
    Friend WithEvents btnRegistar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSerial5 As System.Windows.Forms.TextBox
    Friend WithEvents txtSerial4 As System.Windows.Forms.TextBox
    Friend WithEvents txtSerial3 As System.Windows.Forms.TextBox
    Friend WithEvents txtSerial2 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblInformacion As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
End Class
