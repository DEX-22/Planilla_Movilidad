<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NuevaDireccion
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.txtNombreLocal = New System.Windows.Forms.TextBox()
        Me.btnCrearLocal = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbtnOrigen = New System.Windows.Forms.RadioButton()
        Me.rbtnDestino = New System.Windows.Forms.RadioButton()
        Me.rbtnAmbos = New System.Windows.Forms.RadioButton()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.GroupBox1)
        Me.GroupBox2.Controls.Add(Me.btnCerrar)
        Me.GroupBox2.Controls.Add(Me.txtNombreLocal)
        Me.GroupBox2.Controls.Add(Me.btnCrearLocal)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtDireccion)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.5!)
        Me.GroupBox2.Location = New System.Drawing.Point(2, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(380, 257)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Registrar nueva ubicacion"
        '
        'btnCerrar
        '
        Me.btnCerrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnCerrar.BackgroundImage = Global.SistemaPlanillaMovilidad.My.Resources.Resources.cerrar_40px
        Me.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnCerrar.Location = New System.Drawing.Point(251, 206)
        Me.btnCerrar.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(42, 44)
        Me.btnCerrar.TabIndex = 7
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'txtNombreLocal
        '
        Me.txtNombreLocal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.txtNombreLocal.Location = New System.Drawing.Point(152, 36)
        Me.txtNombreLocal.Name = "txtNombreLocal"
        Me.txtNombreLocal.Size = New System.Drawing.Size(188, 30)
        Me.txtNombreLocal.TabIndex = 6
        '
        'btnCrearLocal
        '
        Me.btnCrearLocal.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnCrearLocal.BackgroundImage = Global.SistemaPlanillaMovilidad.My.Resources.Resources.guardar_40px
        Me.btnCrearLocal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnCrearLocal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCrearLocal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCrearLocal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnCrearLocal.Location = New System.Drawing.Point(113, 206)
        Me.btnCrearLocal.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCrearLocal.Name = "btnCrearLocal"
        Me.btnCrearLocal.Size = New System.Drawing.Size(44, 44)
        Me.btnCrearLocal.TabIndex = 4
        Me.btnCrearLocal.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label7.Location = New System.Drawing.Point(20, 91)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(93, 25)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Direccion"
        '
        'txtDireccion
        '
        Me.txtDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.txtDireccion.Location = New System.Drawing.Point(122, 88)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(218, 30)
        Me.txtDireccion.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label6.Location = New System.Drawing.Point(20, 36)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(126, 25)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Nombre local"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbtnAmbos)
        Me.GroupBox1.Controls.Add(Me.rbtnDestino)
        Me.GroupBox1.Controls.Add(Me.rbtnOrigen)
        Me.GroupBox1.Location = New System.Drawing.Point(25, 139)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(315, 54)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Elige una opcion"
        '
        'rbtnOrigen
        '
        Me.rbtnOrigen.AutoSize = True
        Me.rbtnOrigen.Location = New System.Drawing.Point(6, 23)
        Me.rbtnOrigen.Name = "rbtnOrigen"
        Me.rbtnOrigen.Size = New System.Drawing.Size(82, 26)
        Me.rbtnOrigen.TabIndex = 0
        Me.rbtnOrigen.TabStop = True
        Me.rbtnOrigen.Text = "Origen"
        Me.rbtnOrigen.UseVisualStyleBackColor = True
        '
        'rbtnDestino
        '
        Me.rbtnDestino.AutoSize = True
        Me.rbtnDestino.Location = New System.Drawing.Point(106, 23)
        Me.rbtnDestino.Name = "rbtnDestino"
        Me.rbtnDestino.Size = New System.Drawing.Size(89, 26)
        Me.rbtnDestino.TabIndex = 1
        Me.rbtnDestino.TabStop = True
        Me.rbtnDestino.Text = "Destino"
        Me.rbtnDestino.UseVisualStyleBackColor = True
        '
        'rbtnAmbos
        '
        Me.rbtnAmbos.AutoSize = True
        Me.rbtnAmbos.Location = New System.Drawing.Point(211, 23)
        Me.rbtnAmbos.Name = "rbtnAmbos"
        Me.rbtnAmbos.Size = New System.Drawing.Size(83, 26)
        Me.rbtnAmbos.TabIndex = 2
        Me.rbtnAmbos.TabStop = True
        Me.rbtnAmbos.Text = "Ambos"
        Me.rbtnAmbos.UseVisualStyleBackColor = True
        '
        'NuevaDireccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 261)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "NuevaDireccion"
        Me.Text = "NuevaDireccion"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnCerrar As Button
    Friend WithEvents txtNombreLocal As TextBox
    Friend WithEvents btnCrearLocal As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbtnAmbos As RadioButton
    Friend WithEvents rbtnDestino As RadioButton
    Friend WithEvents rbtnOrigen As RadioButton
End Class
