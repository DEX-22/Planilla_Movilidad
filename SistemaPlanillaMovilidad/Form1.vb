Imports SistemaPlanillaMovilidad.Conexion
Imports System.IO
Imports Microsoft.Office.Interop.Excel
Imports Microsoft.Office.Core
Imports System.Data


Public Class Form1

    Dim SQL As New Conexion
    Dim Id As Integer
    Dim Usuario As Integer
    Dim Origen As Integer
    Dim Destino As Integer
    Dim TipoViaje As String
    Dim Monto As Decimal
    Dim Motivo As String
    Dim Fecha As Date
    Dim Excel As New Microsoft.Office.Interop.Excel.Application
    Dim Libro As Microsoft.Office.Interop.Excel.Workbook = Nothing
    Dim Hoja As Microsoft.Office.Interop.Excel.Worksheet = Nothing
    Dim SaveFileDialog As New SaveFileDialog


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BDMOVILIDAD.USUARIO' Puede moverla o quitarla según sea necesario.
        Me.USUARIOTableAdapter.Fill(Me.BDMOVILIDAD.USUARIO)
        'TODO: esta línea de código carga datos en la tabla 'BDMOVILIDAD.MODULO_DESTINO' Puede moverla o quitarla según sea necesario.
        Me.MODULO_DESTINOTableAdapter.Fill(Me.BDMOVILIDAD.MODULO_DESTINO)
        'TODO: esta línea de código carga datos en la tabla 'BDMOVILIDAD.MODULO_ORIGEN' Puede moverla o quitarla según sea necesario.
        Me.MODULO_ORIGENTableAdapter.Fill(Me.BDMOVILIDAD.MODULO_ORIGEN)


        Me.cboxNombre.Text = "Seleccione"
        Me.cboxNombre.SelectedValue = 1
        Me.cboxFecha.Enabled = False
        Me.cboxOrigen.Enabled = False
        Me.cboxDestino.Enabled = False
        Me.rbtnIda.Enabled = False
        Me.rbtnVuelta.Enabled = False
        Me.txtMonto.Enabled = False
        Me.txtMotivo.Enabled = False
        Me.btnAgregarViaje.Enabled = False
        Me.btnAgregarViaje.BackColor = Color.FromArgb(87, 96, 111)
        Me.btnEliminarViaje.Enabled = False
        Me.btnEliminarViaje.BackColor = Color.FromArgb(87, 96, 111)
        Me.btnLimpiar.Enabled = False
        Me.btnLimpiar.BackColor = Color.FromArgb(87, 96, 111)


    End Sub



    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked

        ActivarNuevoUsuario(True)

    End Sub

    Private Sub btnCrearRegistro_Click(sender As Object, e As EventArgs) Handles btnCrearRegistro.Click

        SQL.CrearReporte(cboxNombre.SelectedValue)
        Me.cboxFecha.Enabled = True
        Me.cboxOrigen.Enabled = True
        Me.cboxDestino.Enabled = True
        Me.rbtnIda.Enabled = True
        Me.rbtnVuelta.Enabled = True
        Me.txtMonto.Enabled = True
        Me.txtMotivo.Enabled = True
        Me.btnAgregarViaje.Enabled = True
        Me.btnAgregarViaje.BackColor = Color.FromArgb(47, 53, 66)
        Me.btnEliminarViaje.Enabled = True
        Me.btnEliminarViaje.BackColor = Color.FromArgb(47, 53, 66)
        Me.btnLimpiar.Enabled = True
        Me.btnLimpiar.BackColor = Color.FromArgb(47, 53, 66)

        Me.cboxNombre.Enabled = False
        Me.btnCrearRegistro.Enabled = False


    End Sub

    Private Sub ActivarNuevoUsuario(opcion As Boolean)

        If opcion Then
            Me.btnNuevoUsuario.Enabled = True
            Me.btnNuevoUsuario.BackColor = Color.FromArgb(47, 53, 66)
            Me.txtDNI.Enabled = True
            Me.btnCrearRegistro.Enabled = False
        Else
            Me.btnNuevoUsuario.Enabled = False
            Me.btnNuevoUsuario.BackColor = Color.FromArgb(87, 96, 111)
            Me.txtDNI.Enabled = False
        End If

    End Sub
    Private Sub btnNuevoUsuario_Click(sender As Object, e As EventArgs) Handles btnNuevoUsuario.Click

        SQL.CrearUsuario(Me.cboxNombre.Text, Me.txtDNI.Text)
        ActivarNuevoUsuario(False)
        LimpiarDatosPersonales()

    End Sub



    Private Sub LimpiarDatosPersonales()
        Me.txtDNI.Text = ""
        Me.cboxNombre.Text = "Seleccione"
    End Sub

    Private Sub cboxNombre_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboxNombre.SelectedIndexChanged

        If Me.cboxNombre.SelectedIndex > 0 Then
            SQL.Mostrar(Me.cboxNombre.SelectedValue, Me.txtDNI, "DNI")
        Else
            SQL.Mostrar(1, Me.txtDNI, "DNI")
        End If



    End Sub

    Private Sub btnAgregarViaje_Click(sender As Object, e As EventArgs) Handles btnAgregarViaje.Click
        Fecha = cboxFecha.Value
        Origen = cboxOrigen.SelectedValue
        Destino = cboxDestino.SelectedValue
        If Me.rbtnIda.Checked Then
            TipoViaje = "IDA"
        ElseIf Me.rbtnVuelta.checked Then
            TipoViaje = "VUELTA"
        End If
        Monto = txtMonto.Value
        Motivo = txtMotivo.Text

        SQL.InsertarViaje(Fecha, Origen, Destino, TipoViaje, Monto, Motivo)
        SQL.Mostrar(0, Me.txtTotal, "TOTAL")
        SQL.ListarViajes(TablaViajes)
        LimpiarDatosViajes()
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        LimpiarDatosViajes()
    End Sub
    Private Sub LimpiarDatosViajes()
        Me.cboxFecha.Value = Date.Today
        Me.cboxOrigen.SelectedIndex = 0
        Me.cboxDestino.SelectedIndex = 0
        Me.rbtnIda.Checked = False
        Me.rbtnVuelta.Checked = False
        Me.txtMonto.Value = 0.00
        Me.txtMotivo.Text = ""
    End Sub

    Private Sub btnGenerarExcel_Click(sender As Object, e As EventArgs) Handles btnGenerarExcel.Click

        If cboxMeses.SelectedIndex >= 0 Then
            ExportarExcel(cboxNombre.Text, cboxMeses.Text)
        Else
            MsgBox("Debes escoger un mes para continuar")
        End If
    End Sub


    Private Sub ExportarExcel(Nombre As String, Mes As String)

        Dim Ruta As String = Path.Combine(Directory.GetCurrentDirectory(), "PLANTILLA.xlsx")
        Excel = CreateObject("Excel.Application")
        Excel.Workbooks.Open(Ruta)
        Excel.Visible = False
        Excel.Sheets("Planilla").Select()
        Excel.Range("B3").Value = cboxNombre.Text
        Excel.Range("B4").Value = txtDNI.Text
        Excel.Range("D5").Value = cboxMeses.Text



        If TablaViajes.Rows.Count > 0 Then
            Dim fila As DataGridViewRow
            Dim ValorInicial As Integer = 9
            Dim Total As Double = 0
            Dim Nfila As Integer = 0
            Dim Ncolumna As Integer = 0
            Try
                For Each fila In TablaViajes.Rows
                    Excel.Range("A" & ValorInicial).Value = fila.Cells(0).Value
                    Excel.Range("B" & ValorInicial).Value = fila.Cells(1).Value
                    Excel.Range("C" & ValorInicial).Value = fila.Cells(2).Value
                    Excel.Range("D" & ValorInicial).Value = fila.Cells(3).Value
                    Excel.Range("E" & ValorInicial).Value = fila.Cells(4).Value
                    Excel.Range("F" & ValorInicial).Value = fila.Cells(5).Value


                    ValorInicial += 1

                Next

                Excel.Range("F40").Value = txtTotal.Text

                SaveFileDialog.DefaultExt = "*.xlsx"
                SaveFileDialog.FileName = "E:\ArchivosExcel\Movilidad-" & Nombre & "-" & Mes
                SaveFileDialog.Filter = "Archivos de Excel (*.xlsx)|*.xlsx"
                SaveFileDialog.ShowDialog()
                Excel.ActiveWorkbook.SaveAs(SaveFileDialog.FileName)
                Excel.ActiveWorkbook.Close()
                Excel.Quit()
                MsgBox("Se ha guardado el archivo")

            Catch ex As Exception
                MsgBox("No se pudo guardar el archivo")
                MsgBox(ex.ToString)


            End Try


        End If


    End Sub



    Private Sub TablaViajes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles TablaViajes.CellContentClick
        If e.RowIndex >= 0 Then
            TablaViajes.CurrentCell = TablaViajes.Item(0, e.RowIndex)

            Me.Id = TablaViajes.CurrentCell.Value

        End If
    End Sub

    Private Sub btnEliminarViaje_Click(sender As Object, e As EventArgs) Handles btnEliminarViaje.Click
        If Id >= 0 Then
            MsgBox(Me.Id)

            ' SQL.EliminarViaje(Me.Id)
            'SQL.ListarViajes(TablaViajes)
        End If
    End Sub
End Class
