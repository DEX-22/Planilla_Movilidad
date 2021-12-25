<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistrarUsuario
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.btnCrearUsuario = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtDni = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.txtNombre)
        Me.GroupBox2.Controls.Add(Me.btnCrearUsuario)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtDni)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.5!)
        Me.GroupBox2.Location = New System.Drawing.Point(1, 1)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(339, 231)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Registrar usuario"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Button1.BackgroundImage = Global.SistemaPlanillaMovilidad.My.Resources.Resources.cerrar_40px
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(219, 152)
        Me.Button1.Margin = New System.Windows.Forms.Padding(0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(42, 44)
        Me.Button1.TabIndex = 7
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.txtNombre.Location = New System.Drawing.Point(117, 36)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(186, 30)
        Me.txtNombre.TabIndex = 6
        '
        'btnCrearUsuario
        '
        Me.btnCrearUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnCrearUsuario.BackgroundImage = Global.SistemaPlanillaMovilidad.My.Resources.Resources.guardar_40px
        Me.btnCrearUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnCrearUsuario.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCrearUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCrearUsuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnCrearUsuario.Location = New System.Drawing.Point(90, 152)
        Me.btnCrearUsuario.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCrearUsuario.Name = "btnCrearUsuario"
        Me.btnCrearUsuario.Size = New System.Drawing.Size(44, 44)
        Me.btnCrearUsuario.TabIndex = 4
        Me.btnCrearUsuario.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label7.Location = New System.Drawing.Point(57, 91)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 25)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "DNI"
        '
        'txtDni
        '
        Me.txtDni.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.txtDni.Location = New System.Drawing.Point(117, 88)
        Me.txtDni.Name = "txtDni"
        Me.txtDni.Size = New System.Drawing.Size(186, 30)
        Me.txtDni.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label6.Location = New System.Drawing.Point(20, 36)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 25)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Nombres"
        '
        'RegistrarUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(339, 231)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "RegistrarUsuario"
        Me.Text = "RegistrarUsuario"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnCrearUsuario As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents txtDni As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Button1 As Button
End Class
