Imports SistemaPlanillaMovilidad.Conexion

Public Class NuevaDireccion
    Dim SQL As New Conexion
    Private Sub NuevaDireccion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.txtNombreLocal.Select()
        Me.rbtnAmbos.Select()

    End Sub
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        SQL.MostrarLocalCbox(Form1.cboxOrigen, "O")
        SQL.MostrarLocalCbox(Form1.cboxDestino, "D")

        Hide()
    End Sub

    Private Sub btnCrearLocal_Click(sender As Object, e As EventArgs) Handles btnCrearLocal.Click
        Dim Nombre As String = ""
        Dim Direccion As String = ""
        Dim Opcion As Char = ""

        If Me.txtNombreLocal.Text = "" Then
            MsgBox("debe ingresar el nombre del local")
        Else
            Nombre = Me.txtNombreLocal.Text
        End If
        If Me.txtDireccion.Text = "" Then
            MsgBox("debe ingresar la direccion del local")
        Else
            Direccion = Me.txtDireccion.Text
        End If


        If rbtnAmbos.Checked Then
            Opcion = "A"
        ElseIf rbtnOrigen.Checked Then
            Opcion = "O"
        ElseIf rbtnDestino.Checked Then
            Opcion = "D"
        End If

        If Nombre.ElementAt(0) <> " " And Direccion.ElementAt(0) <> " " Then

            SQL.CrearLocal(Nombre, Direccion, Opcion)

            Me.txtNombreLocal.Text = ""
            Me.txtDireccion.Text = ""
        Else
            MsgBox("Debe completar los campos para continuar")
        End If

    End Sub


End Class