<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Teclado
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
        Me.txtEscribir = New System.Windows.Forms.TextBox()
        Me.lblSugerencia = New System.Windows.Forms.Label()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnEntrenar = New System.Windows.Forms.Button()
        Me.btnEnviar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtEscribir
        '
        Me.txtEscribir.Location = New System.Drawing.Point(18, 34)
        Me.txtEscribir.Name = "txtEscribir"
        Me.txtEscribir.Size = New System.Drawing.Size(154, 20)
        Me.txtEscribir.TabIndex = 0
        '
        'lblSugerencia
        '
        Me.lblSugerencia.AutoSize = True
        Me.lblSugerencia.Location = New System.Drawing.Point(94, 76)
        Me.lblSugerencia.Name = "lblSugerencia"
        Me.lblSugerencia.Size = New System.Drawing.Size(0, 13)
        Me.lblSugerencia.TabIndex = 1
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(68, 182)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btnLimpiar.TabIndex = 2
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        Me.btnLimpiar.Visible = False
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(191, 181)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 3
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        Me.btnGuardar.Visible = False
        '
        'btnEntrenar
        '
        Me.btnEntrenar.Location = New System.Drawing.Point(18, 118)
        Me.btnEntrenar.Name = "btnEntrenar"
        Me.btnEntrenar.Size = New System.Drawing.Size(75, 23)
        Me.btnEntrenar.TabIndex = 4
        Me.btnEntrenar.Text = "Entrenar"
        Me.btnEntrenar.UseVisualStyleBackColor = True
        '
        'btnEnviar
        '
        Me.btnEnviar.Location = New System.Drawing.Point(190, 31)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(75, 23)
        Me.btnEnviar.TabIndex = 5
        Me.btnEnviar.Text = "Enviar"
        Me.btnEnviar.UseVisualStyleBackColor = True
        '
        'Teclado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnEnviar)
        Me.Controls.Add(Me.btnEntrenar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.lblSugerencia)
        Me.Controls.Add(Me.txtEscribir)
        Me.Name = "Teclado"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtEscribir As TextBox
    Friend WithEvents lblSugerencia As Label
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnEntrenar As Button
    Friend WithEvents btnEnviar As Button
End Class
