Imports System.Data.SqlClient
Imports Microsoft.VisualBasic

Public Class Conexion

    Dim Server As String
    Dim NombreBD As String
    Dim Usuario As String
    Dim Password As String
    Dim CadenaConexion As String
    Dim Consulta As SqlCommand
    Dim Conexion As SqlConnection
    Dim SqlDataAdapter As SqlDataAdapter
    Dim DataSet As New DataSet
    Dim DataTable As New DataTable
    Dim DataReader As SqlDataReader


    Public Sub Conectar()

        Server = "192.168.2.5"
        NombreBD = "BDMOVILIDAD"
        Usuario = "sa"
        Password = "@servertksistemas/75482648#"
        CadenaConexion = "Data Source=" & Server & ";Initial Catalog=" & NombreBD & ";Persist Security Info=True;User ID=" & Usuario & ";Password=" & Password

        Conexion = New SqlConnection(CadenaConexion)



    End Sub

    Public Sub Mostrar(Id As Integer, Caja As TextBox, Opcion As String)

        DataTable = New DataTable

        Conectar()
        Me.Conexion.Open()
        If Opcion = "DNI" Then
            SqlDataAdapter = New SqlDataAdapter("EXEC SP_MOSTRAR_DNI " & Id, Me.Conexion)
        ElseIf Opcion = "TOTAL" Then
            SqlDataAdapter = New SqlDataAdapter("EXEC SP_MOSTRAR_TOTAL " & Id, Me.Conexion)
        ElseIf Opcion = "MES" Then
            SqlDataAdapter = New SqlDataAdapter("EXEC SP_MOSTRAR_MES " & Id, Me.Conexion)
        End If
        SqlDataAdapter.Fill(DataTable)
        Caja.Text = DataTable.Rows(0).Item(0)
        Me.Conexion.Close()

    End Sub

    Public Sub ListarUsuarios(Cbox As ComboBox)
        DataTable = New DataTable

        Conectar()
        Me.Conexion.Open()

        SqlDataAdapter = New SqlDataAdapter("EXEC SP_LISTAR_LOCAL", Me.Conexion)

        SqlDataAdapter.Fill(DataTable)
        Cbox.DisplayMember = DataTable.Rows(0).Item(0)
        Me.Conexion.Close()
    End Sub

    Public Sub MostrarCbox(Cbox As ComboBox, Opcion As String)
        DataTable = New DataTable

        Conectar()
        Me.Conexion.Open()

        SqlDataAdapter = New SqlDataAdapter("EXEC SP_LISTAR_LOCAL " & Opcion, Me.Conexion)

        SqlDataAdapter.Fill(DataTable)
        Cbox.DisplayMember = DataTable.Rows(0).Item(0)
        Cbox.ValueMember = DataTable.Rows(0).Item(1)
        Me.Conexion.Close()
    End Sub

    Public Sub CrearReporte(Usuario As Integer)
        Conectar()

        Consulta = New SqlCommand("EXEC SP_CREAR '" & Usuario & "','','','REPORTE'", Me.Conexion)
        Conexion.Open()
        Consulta.ExecuteNonQuery()

    End Sub
    Public Sub CrearUsuario(Nombre As String, DNI As String)
        Conectar()

        Consulta = New SqlCommand("EXEC SP_CREAR 0,'" & Nombre & "','" & DNI & "','USUARIO'", Me.Conexion)
        Conexion.Open()
        Consulta.ExecuteNonQuery()
        MsgBox("Usuario registrado con exito")
    End Sub
    Public Sub ListarViajes(Tabla As DataGridView)

        DataTable = New DataTable


        Conectar()
        Me.Conexion.Open()

        SqlDataAdapter = New SqlDataAdapter("EXEC SP_CRUD_VIAJE 0,0,0,0,0,'','',0.0,'','R' ", Conexion)
        SqlDataAdapter.Fill(DataTable)
        Tabla.DataSource = DataTable

        Me.Conexion.Close()



    End Sub


    Public Sub InsertarViaje(fecha As Date, origen As Integer, destino As Integer, tipo As String, monto As Decimal, motivo As String)
        Conectar()

        Consulta = New SqlCommand("EXEC SP_CRUD_VIAJE 0,0,0," & origen & "," & destino & ",'" & tipo & "','" & fecha & "'," & monto & ",'" & motivo & "','C'", Me.Conexion)
        Conexion.Open()
        Consulta.ExecuteNonQuery()
        '-------------



    End Sub


    Public Sub ModificarViaje(id As Integer, fecha As Date, origen As Integer, destino As Integer, tipo As String, monto As Decimal, motivo As String)
        Conectar()

        Consulta = New SqlCommand("EXEC SP_CRUD_VIAJE 0," & id & ",0," & origen & "," & destino & ",'" & tipo & "','" & fecha & "'," & monto & ",'" & motivo & "','U'", Me.Conexion)
        Conexion.Open()
        Consulta.ExecuteNonQuery()
        MsgBox("Se modificó con exito")
    End Sub


    Public Sub EliminarViaje(id As Integer)
        Conectar()


        Consulta = New SqlCommand("SP_CRUD_VIAJE " & id & ",0,0,0,0,'','',0.0,'','D'", Me.Conexion)
        Conexion.Open()
        Consulta.ExecuteNonQuery()
        MsgBox("Se eliminó con exito")
    End Sub






End Class

