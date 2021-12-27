Imports SistemaPlanillaMovilidad.Conexion

Public Class RegistrarUsuario
    Dim SQL As New Conexion


    Private Sub RegistrarUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtNombre.Select()
    End Sub


    Private Sub btnCrearUsuario_Click(sender As Object, e As EventArgs) Handles btnCrearUsuario.Click
        If txtNombre.Text.Length > 0 And txtDni.Text.Length > 0 Then
            If txtDni.Text.Length < 8 Then
                MsgBox("El dni debe contener 8 digitos")
            Else
                SQL.CrearUsuario(txtNombre.Text, txtDni.Text)
                Me.txtNombre.Text = ""
                Me.txtDni.Text = ""
            End If
        Else
            MsgBox("Debe llenar todos los campos para contnuar")
        End If




    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SQL.ListarUsuarios(Form1.cboxNombre)
        Hide()

    End Sub

End Class