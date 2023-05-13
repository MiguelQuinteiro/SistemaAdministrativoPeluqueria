<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRespaldo
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
        Me.lblArchivoO = New System.Windows.Forms.Label()
        Me.lblCarpetaO = New System.Windows.Forms.Label()
        Me.lblUnidadO = New System.Windows.Forms.Label()
        Me.lstArchivosO = New System.Windows.Forms.ListBox()
        Me.lstCarpetasO = New System.Windows.Forms.ListBox()
        Me.lstUnidadesO = New System.Windows.Forms.ListBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblArchivoD = New System.Windows.Forms.Label()
        Me.lblCarpetaD = New System.Windows.Forms.Label()
        Me.lblUnidadD = New System.Windows.Forms.Label()
        Me.lstArchivosD = New System.Windows.Forms.ListBox()
        Me.lstCarpetasD = New System.Windows.Forms.ListBox()
        Me.lstUnidadesD = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblArchivoO)
        Me.GroupBox1.Controls.Add(Me.lblCarpetaO)
        Me.GroupBox1.Controls.Add(Me.lblUnidadO)
        Me.GroupBox1.Controls.Add(Me.lstArchivosO)
        Me.GroupBox1.Controls.Add(Me.lstCarpetasO)
        Me.GroupBox1.Controls.Add(Me.lstUnidadesO)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(656, 150)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de Origen "
        '
        'lblArchivoO
        '
        Me.lblArchivoO.AutoSize = True
        Me.lblArchivoO.Location = New System.Drawing.Point(384, 24)
        Me.lblArchivoO.Name = "lblArchivoO"
        Me.lblArchivoO.Size = New System.Drawing.Size(77, 13)
        Me.lblArchivoO.TabIndex = 11
        Me.lblArchivoO.Text = "Archivo Origen"
        '
        'lblCarpetaO
        '
        Me.lblCarpetaO.AutoSize = True
        Me.lblCarpetaO.Location = New System.Drawing.Point(135, 24)
        Me.lblCarpetaO.Name = "lblCarpetaO"
        Me.lblCarpetaO.Size = New System.Drawing.Size(78, 13)
        Me.lblCarpetaO.TabIndex = 10
        Me.lblCarpetaO.Text = "Carpeta Origen"
        '
        'lblUnidadO
        '
        Me.lblUnidadO.AutoSize = True
        Me.lblUnidadO.Location = New System.Drawing.Point(9, 24)
        Me.lblUnidadO.Name = "lblUnidadO"
        Me.lblUnidadO.Size = New System.Drawing.Size(75, 13)
        Me.lblUnidadO.TabIndex = 9
        Me.lblUnidadO.Text = "Unidad Origen"
        '
        'lstArchivosO
        '
        Me.lstArchivosO.FormattingEnabled = True
        Me.lstArchivosO.Location = New System.Drawing.Point(387, 40)
        Me.lstArchivosO.Name = "lstArchivosO"
        Me.lstArchivosO.Size = New System.Drawing.Size(255, 95)
        Me.lstArchivosO.TabIndex = 8
        '
        'lstCarpetasO
        '
        Me.lstCarpetasO.FormattingEnabled = True
        Me.lstCarpetasO.Location = New System.Drawing.Point(138, 40)
        Me.lstCarpetasO.Name = "lstCarpetasO"
        Me.lstCarpetasO.Size = New System.Drawing.Size(243, 95)
        Me.lstCarpetasO.TabIndex = 7
        '
        'lstUnidadesO
        '
        Me.lstUnidadesO.FormattingEnabled = True
        Me.lstUnidadesO.HorizontalScrollbar = True
        Me.lstUnidadesO.Location = New System.Drawing.Point(12, 40)
        Me.lstUnidadesO.Name = "lstUnidadesO"
        Me.lstUnidadesO.Size = New System.Drawing.Size(120, 95)
        Me.lstUnidadesO.TabIndex = 6
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblArchivoD)
        Me.GroupBox2.Controls.Add(Me.lblCarpetaD)
        Me.GroupBox2.Controls.Add(Me.lblUnidadD)
        Me.GroupBox2.Controls.Add(Me.lstArchivosD)
        Me.GroupBox2.Controls.Add(Me.lstCarpetasD)
        Me.GroupBox2.Controls.Add(Me.lstUnidadesD)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 168)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(655, 148)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos Destino "
        '
        'lblArchivoD
        '
        Me.lblArchivoD.AutoSize = True
        Me.lblArchivoD.Location = New System.Drawing.Point(383, 22)
        Me.lblArchivoD.Name = "lblArchivoD"
        Me.lblArchivoD.Size = New System.Drawing.Size(82, 13)
        Me.lblArchivoD.TabIndex = 17
        Me.lblArchivoD.Text = "Archivo Destino"
        '
        'lblCarpetaD
        '
        Me.lblCarpetaD.AutoSize = True
        Me.lblCarpetaD.Location = New System.Drawing.Point(134, 22)
        Me.lblCarpetaD.Name = "lblCarpetaD"
        Me.lblCarpetaD.Size = New System.Drawing.Size(83, 13)
        Me.lblCarpetaD.TabIndex = 16
        Me.lblCarpetaD.Text = "Carpeta Destino"
        '
        'lblUnidadD
        '
        Me.lblUnidadD.AutoSize = True
        Me.lblUnidadD.Location = New System.Drawing.Point(8, 22)
        Me.lblUnidadD.Name = "lblUnidadD"
        Me.lblUnidadD.Size = New System.Drawing.Size(80, 13)
        Me.lblUnidadD.TabIndex = 15
        Me.lblUnidadD.Text = "Unidad Destino"
        '
        'lstArchivosD
        '
        Me.lstArchivosD.FormattingEnabled = True
        Me.lstArchivosD.Location = New System.Drawing.Point(386, 38)
        Me.lstArchivosD.Name = "lstArchivosD"
        Me.lstArchivosD.Size = New System.Drawing.Size(255, 95)
        Me.lstArchivosD.TabIndex = 14
        '
        'lstCarpetasD
        '
        Me.lstCarpetasD.FormattingEnabled = True
        Me.lstCarpetasD.Location = New System.Drawing.Point(137, 38)
        Me.lstCarpetasD.Name = "lstCarpetasD"
        Me.lstCarpetasD.Size = New System.Drawing.Size(243, 95)
        Me.lstCarpetasD.TabIndex = 13
        '
        'lstUnidadesD
        '
        Me.lstUnidadesD.FormattingEnabled = True
        Me.lstUnidadesD.Location = New System.Drawing.Point(11, 38)
        Me.lstUnidadesD.Name = "lstUnidadesD"
        Me.lstUnidadesD.Size = New System.Drawing.Size(120, 95)
        Me.lstUnidadesD.TabIndex = 12
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 340)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Limpiar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(592, 340)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 19
        Me.Button2.Text = "Respaldar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'frmRespaldo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 394)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmRespaldo"
        Me.Text = "Respaldo"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblArchivoO As System.Windows.Forms.Label
    Friend WithEvents lblCarpetaO As System.Windows.Forms.Label
    Friend WithEvents lblUnidadO As System.Windows.Forms.Label
    Friend WithEvents lstArchivosO As System.Windows.Forms.ListBox
    Friend WithEvents lstCarpetasO As System.Windows.Forms.ListBox
    Friend WithEvents lstUnidadesO As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblArchivoD As System.Windows.Forms.Label
    Friend WithEvents lblCarpetaD As System.Windows.Forms.Label
    Friend WithEvents lblUnidadD As System.Windows.Forms.Label
    Friend WithEvents lstArchivosD As System.Windows.Forms.ListBox
    Friend WithEvents lstCarpetasD As System.Windows.Forms.ListBox
    Friend WithEvents lstUnidadesD As System.Windows.Forms.ListBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
