Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO 'librería de entrada y salida de visual con el sistema
Imports System.Data.SqlClient
Public Class FormAbonos2
    Dim con As New SqlConnection("Data Source=DESKTOP-KH7N6DR\SQLEXPRESS;Initial Catalog=Datos_TECDEVELOPMENT;Persist Security Info=True;User ID=sa;Password=12345678")
    Dim variable
    Public FechaPago As String
    Public IDC As String
    Public restante As String
    Public IDClientecredito As String
    Public idabonos
    Public nombre
    Public va
    Public ve
    Public vi
    Public vo
    Public vu
    Public vv
    Public Pre
    Public H
    Public anioss
    Public Total_pagar

    Private cadenaConexion As String = "Data Source=DESKTOP-KH7N6DR\SQLEXPRESS;Initial Catalog=Datos_TECDEVELOPMENT;Persist Security Info=True;User ID=sa;Password=12345678"


    Private Sub ButtonBuscar_Click(sender As Object, e As EventArgs) Handles ButtonBuscar.Click

        con.Open()

        Dim Tb As String = TextoBuscar.Text()
        Dim command As New SqlCommand("SELECT C.ID_cliente, Nombre, Telefono, Correo, Ciudad_estado, Pago_mes, Restante, Total_Pagar, Fecha_Abono As Fecha_Ultimo_Pago  FROM Clientes C INNER JOIN FormaCompra f ON C.ID_cliente=f.ID_cliente INNER JOIN Clientes_Credito t ON f.ID_FormaCompra =t.ID_FormaCompra INNER JOIN ABONOS A ON t.ID_ClientesCredito =A.ID_ClientesCredito   where Forma ='Crédito'and nombre = '" & Tb & "'", con)
        Dim sda As New SqlDataAdapter(command)
        Dim dt As New DataTable
        sda.Fill(dt)
        DataGridView1.DataSource = dt
        con.Close()



    End Sub

    Private Sub LoadDataGrid() ''para actualizar los datos en la tabla

        Dim command As New SqlCommand("SELECT C.ID_cliente, Nombre, Telefono, Correo, Ciudad_estado, Pago_mes, Restante, Total_Pagar, Fecha_Abono As Fecha_Ultimo_Pago  FROM Clientes C INNER JOIN FormaCompra f ON C.ID_cliente=f.ID_cliente INNER JOIN Clientes_Credito t ON f.ID_FormaCompra =t.ID_FormaCompra INNER JOIN ABONOS A ON t.ID_ClientesCredito =A.ID_ClientesCredito   where Forma ='Crédito'", con) ''seleccionamos los datos de la tabla
        Dim sda As New SqlDataAdapter(command)
        Dim dt As New DataTable
        sda.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub FormAbonos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataGrid()
    End Sub

    Private Sub DataGridView1_CellClick1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        Datoscompartidos.Dato = DataGridView1.Item(0, i).Value()
        Total_pagar = DataGridView1.Item(7, i).Value()
        'MsgBox(Datoscompartidos.Dato)
    End Sub





    Private Sub ButtonSeleccionar_Click(sender As Object, e As EventArgs) Handles ButtonSeleccionar.Click
        If Datoscompartidos.Dato = "" Then
            MsgBox("seleccione un dato primero")
            LabelPago.Visible = False
            TextBoxPago.Visible = False
            ButtonAceptar.Visible = False
            Labelfecha.Visible = False
            DateTimePicker.Visible = False

        Else
            Using cnn As New SqlConnection(cadenaConexion)
                Dim cmd As SqlCommand = cnn.CreateCommand()
                cmd.CommandText = "select Nombre From Clientes where ID_Cliente= '" & Datoscompartidos.Dato & "'"
                cnn.Open()
                Dim value As Object = cmd.ExecuteScalar()

                nombre = Convert.ToString(value)



                cmd.CommandText = "SELECT Tiempo_Credito FROM Clientes C INNER JOIN FormaCompra f ON C.ID_cliente=f.ID_cliente INNER JOIN Clientes_Credito t ON f.ID_FormaCompra =t.ID_FormaCompra INNER JOIN ABONOS A ON t.ID_ClientesCredito =A.ID_ClientesCredito   where C.ID_Cliente= '" & Datoscompartidos.Dato & "'"
                Dim valuae As Object = cmd.ExecuteScalar()
                anioss = Convert.ToString(valuae)


                cmd.CommandText = "select ID_FormaCompra From FormaCompra where ID_Cliente= '" & Datoscompartidos.Dato & "'"
                Dim valu2 As Object = cmd.ExecuteScalar()
                variable = Convert.ToString(valu2)



                cmd.CommandText = "select ID_ClientesCredito From Clientes_Credito where ID_FormaCompra= '" & variable & "'"
                Dim valu3 As Object = cmd.ExecuteScalar()
                IDC = Convert.ToString(valu3)
                variable = Convert.ToString(valu3)

                cmd.CommandText = "select TOP 1 ID_Abonos From Abonos where ID_ClientesCredito='" & variable & "'ORDER BY ID_ClientesCredito DESC"
                Dim valu4 As Object = cmd.ExecuteScalar()
                variable = Convert.ToString(valu4)
                idabonos = Convert.ToString(valu4)

                cmd.CommandText = "select Fecha_Abono From Abonos where ID_Abonos='" & idabonos & "'"
                Dim valu5 As Object = cmd.ExecuteScalar()
                FechaPago = Convert.ToString(valu5)

                cmd.CommandText = "select Restante From Abonos where ID_Abonos='" & idabonos & "'"
                Dim valu6 As Object = cmd.ExecuteScalar()
                restante = Convert.ToString(valu6)
                cnn.Close()


            End Using
            LabelPago.Visible = True
            TextBoxPago.Visible = True
            ButtonAceptar.Visible = True
            Labelfecha.Visible = True
            DateTimePicker.Visible = True

        End If
    End Sub


    Private Sub ButtonInicio_Click(sender As Object, e As EventArgs) Handles ButtonInicio.Click
        FormMenu2.Show()
        Me.Close()
        Datoscompartidos.Dato = ""
    End Sub

    Private Sub ButtonCsesion_Click(sender As Object, e As EventArgs) Handles ButtonCsesion.Click
        Form1.Show()
        Me.Close()
        Datoscompartidos.Dato = ""
    End Sub

    Private Sub ButtonAceptar_Click(sender As Object, e As EventArgs) Handles ButtonAceptar.Click
        If TextBoxPago.Text = "" Then
            MsgBox("Agregar un pago primero")
        Else
            Dim men = "Ingresar el abono a " & nombre
            Dim preg = MessageBox.Show(men, "Mensaje", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If preg = vbOK Then
                'Dim A As Integer = Convert.ToInt64(restante)
                'Dim B = TextBoxPago.Text
                'B = Convert.ToInt64(B)
                Dim agre = restante - TextBoxPago.Text
                Dim fecha1 = DateTimePicker.Value.Date.ToString("yyyy/MM/dd")

                con.Open()
                Dim command As New SqlCommand("update Abonos set ID_ClientesCredito='" & IDC & "', Pago='" & TextBoxPago.Text & "', Restante='" & agre & "', Fecha_Abono='" & fecha1 & "'where ID_Abonos = '" & idabonos & "' ", con)
                command.ExecuteNonQuery()
                LoadDataGrid()

                con.Close()
                LabelPago.Visible = False
                TextBoxPago.Visible = False
                ButtonAceptar.Visible = False
                Labelfecha.Visible = False
                DateTimePicker.Visible = False

                Try
                    'bloque 1

                    'Dim tabla As New PdfPTable(dt)
                    'Dim tabla2 As New PdfPTable(Datos2.ColumnCount)


                    'formatos de los textos
                    Dim font8 As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 12, iTextSharp.text.Font.NORMAL))
                    Dim font88 As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 12, iTextSharp.text.Font.BOLD))
                    Dim fontB12 As New Font(FontFactory.GetFont(FontFactory.TIMES_ROMAN, 14, iTextSharp.text.Font.NORMAL))
                    Dim fontTitulo As New Font(FontFactory.GetFont(FontFactory.TIMES_ROMAN, 20, iTextSharp.text.Font.NORMAL))
                    Dim CVacio As PdfPCell = New PdfPCell(New Phrase(""))
                    CVacio.Border = 0


                    Dim documentoPDf As New Document
                    PdfWriter.GetInstance(documentoPDf, New FileStream("Recibo.pdf", FileMode.Create))
                    documentoPDf.Open()

                    Dim tabla1 As PdfPTable = New PdfPTable(4)
                    Dim Col2 As PdfPCell
                    Dim Col3 As PdfPCell
                    tabla1.WidthPercentage = 95
                    Dim widths As Single() = New Single() {4.0F, 6.0F, 1.0F, 5.0F}
                    tabla1.SetWidths(widths)

                    Col2 = New PdfPCell(New Phrase("Almacenes ISC", font88))
                    Col2.Border = 0
                    tabla1.AddCell(Col2)
                    tabla1.AddCell(CVacio)
                    tabla1.AddCell(CVacio)
                    Col3 = New PdfPCell(New Phrase("Recibo de pago", fontTitulo))
                    Col3.Border = 0
                    tabla1.AddCell(Col3)


                    Col2 = New PdfPCell(New Phrase("Cliente: ", font8))
                    Col2.Border = 0
                    tabla1.AddCell(Col2)
                    tabla1.AddCell(CVacio)
                    tabla1.AddCell(CVacio)
                    tabla1.AddCell(CVacio)


                    Col2 = New PdfPCell(New Phrase(nombre, font8))
                    Col2.Border = 0
                    tabla1.AddCell(Col2)
                    tabla1.AddCell(CVacio)
                    tabla1.AddCell(CVacio)
                    Col3 = New PdfPCell(New Phrase(fecha1, font8))
                    Col3.Border = 0
                    tabla1.AddCell(Col3)


                    tabla1.AddCell(CVacio)
                    tabla1.AddCell(CVacio)
                    tabla1.AddCell(CVacio)
                    Col3 = New PdfPCell(New Phrase("N° de Cliente: " & IDC, font8))
                    Col3.Border = 0
                    tabla1.AddCell(Col3)

                    tabla1.AddCell(CVacio)
                    'Col2 = New PdfPCell(New Phrase("Merida, yucatan, Caller 67A po 244 y 65 #231 C.P 97455", font8))
                    'Col2.Border = 0
                    tabla1.AddCell(CVacio)
                    tabla1.AddCell(CVacio)
                    tabla1.AddCell(CVacio)

                    'solo hacen espacio para que no este achocado
                    tabla1.AddCell(CVacio)
                    Col2 = New PdfPCell(New Phrase(" ", font8))
                    Col2.Border = 0
                    tabla1.AddCell(Col2)
                    tabla1.AddCell(CVacio)
                    tabla1.AddCell(CVacio)

                    tabla1.AddCell(CVacio)
                    Col2 = New PdfPCell(New Phrase(" ", font8))
                    Col2.Border = 0
                    tabla1.AddCell(Col2)
                    tabla1.AddCell(CVacio)
                    tabla1.AddCell(CVacio)

                    documentoPDf.Add(tabla1)



                    documentoPDf.Add(New Chunk(""))

                    'bloque 3 de la primera tabla inserta los nombres en las columnas del data grip al pdf

                    'documentoPDf.Add(dt)

                    Dim tabla3 As PdfPTable = New PdfPTable(1)
                    Dim colum As PdfPCell
                    tabla3.WidthPercentage = 95
                    Dim widthsa As Single() = New Single() {4.0F, 6.0F, 1.0F, 5.0F}
                    tabla1.SetWidths(widthsa)

                    Using cnn As New SqlConnection(cadenaConexion)
                        Dim cmd As SqlCommand = cnn.CreateCommand()
                        cmd.CommandText = "select Marca From Autos_Vendidos A INNER JOIN Clientes C ON A.ID_AutoVendido =C.ID_AutoVendido where ID_Cliente ='" & Datoscompartidos.Dato & "'"
                        cnn.Open()
                        Dim var As Object = cmd.ExecuteScalar()
                        va = var
                        cmd.CommandText = "select Modelo From Autos_Vendidos A INNER JOIN Clientes C ON A.ID_AutoVendido =C.ID_AutoVendido where ID_Cliente ='" & Datoscompartidos.Dato & "'"
                        Dim vart As Object = cmd.ExecuteScalar()
                        ve = vart

                        cmd.CommandText = "select anio From Autos_Vendidos A INNER JOIN Clientes C ON A.ID_AutoVendido =C.ID_AutoVendido where ID_Cliente ='" & Datoscompartidos.Dato & "'"
                        Dim varta As Object = cmd.ExecuteScalar()
                        vi = varta

                        cmd.CommandText = "select Tipo_Transmicion From Autos_Vendidos A INNER JOIN Clientes C ON A.ID_AutoVendido =C.ID_AutoVendido where ID_Cliente ='" & Datoscompartidos.Dato & "'"
                        Dim varte As Object = cmd.ExecuteScalar()
                        vo = varte

                        cmd.CommandText = "select Consumo_Gasolina From Autos_Vendidos A INNER JOIN Clientes C ON A.ID_AutoVendido =C.ID_AutoVendido where ID_Cliente ='" & Datoscompartidos.Dato & "'"
                        Dim varti As Object = cmd.ExecuteScalar()
                        vu = varti

                        cmd.CommandText = "select No_Puertas From Autos_Vendidos A INNER JOIN Clientes C ON A.ID_AutoVendido =C.ID_AutoVendido where ID_Cliente ='" & Datoscompartidos.Dato & "'"
                        Dim varto As Object = cmd.ExecuteScalar()
                        vv = varto

                        cmd.CommandText = "select Precio From Autos_Vendidos A INNER JOIN Clientes C ON A.ID_AutoVendido =C.ID_AutoVendido where ID_Cliente ='" & Datoscompartidos.Dato & "'"
                        Dim vartu As Object = cmd.ExecuteScalar()
                        Pre = Convert.ToInt64(vartu)
                        cnn.Close()
                     
                    End Using



                    colum = New PdfPCell(New Phrase("Marca: " & va, font88))
                    colum.Border = 0
                    tabla3.AddCell(colum)

                    colum = New PdfPCell(New Phrase("Modelo: " & ve, font88))
                    colum.Border = 0
                    tabla3.AddCell(colum)

                    colum = New PdfPCell(New Phrase("Año: " & vi, font88))
                    colum.Border = 0
                    tabla3.AddCell(colum)

                    colum = New PdfPCell(New Phrase("Tpo de transmición: " & vo, font88))
                    colum.Border = 0
                    tabla3.AddCell(colum)

                    colum = New PdfPCell(New Phrase("Consumo de gasolina: " & vu, font88))
                    colum.Border = 0
                    tabla3.AddCell(colum)

                    colum = New PdfPCell(New Phrase("Puertas: " & vv, font88))
                    colum.Border = 0
                    tabla3.AddCell(colum)

                    documentoPDf.Add(tabla3)



                    Dim tabla4 As PdfPTable = New PdfPTable(4)
                    Dim Col13 As PdfPCell
                    tabla4.WidthPercentage = 95
                    Dim widthse As Single() = New Single() {4.0F, 6.0F, 1.0F, 5.0F}
                    tabla4.SetWidths(widthse)

                    tabla4.AddCell(CVacio)
                    tabla4.AddCell(CVacio)
                    tabla4.AddCell(CVacio)
                    tabla4.AddCell(CVacio)

                    'Dim precioImpreso = "Subtotal: " + PrecioModi

                    tabla4.AddCell(CVacio)
                    tabla4.AddCell(CVacio)
                    tabla4.AddCell(CVacio)
                    Col13 = New PdfPCell(New Phrase("Pago: " & TextBoxPago.Text, font88))
                    Col13.Border = 0
                    tabla4.AddCell(Col13)


                    tabla4.AddCell(CVacio)
                    tabla4.AddCell(CVacio)
                    tabla4.AddCell(CVacio)
                    Col13 = New PdfPCell(New Phrase("Faltante: " & agre, font88))
                    Col13.Border = 0
                    tabla4.AddCell(Col13)


                    tabla4.AddCell(CVacio)
                    tabla4.AddCell(CVacio)
                    tabla4.AddCell(CVacio)
                    Col13 = New PdfPCell(New Phrase("Precio total: " & Total_pagar, font88))
                    Col13.Border = 0
                    tabla4.AddCell(Col13)
                    documentoPDf.Add(tabla4)

                    Dim tabla7 As PdfPTable = New PdfPTable(1)
                    Dim Col113 As PdfPCell
                    tabla7.WidthPercentage = 95
                    Dim widthso As Single() = New Single() {10.0F}
                    tabla7.SetWidths(widthso)

                    tabla7.AddCell(CVacio)

                    Col113 = New PdfPCell(New Phrase("Gracias por tu confianza.", fontB12))
                    Col113.Border = 0
                    tabla7.AddCell(Col113)

                    Col113 = New PdfPCell(New Phrase("calle 17 por 56 y 25 col. centro, Merida/Yucatan, 97455, 9911345625", fontB12))
                    Col113.Border = 0
                    tabla7.AddCell(Col113)

                    documentoPDf.Add(tabla7)
                    documentoPDf.Close()


                    'bloque 5 

                    If System.IO.File.Exists("Recibo.pdf") Then
                        If MsgBox("Texto convertido a Archivo PDF correctamente " + _
                               "¿desea abrir el Archivo PDF resultante?",
                               MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                            System.Diagnostics.Process.Start("Recibo.pdf")
                        End If
                    Else
                        MsgBox("El Archivo PDF no se ha generado, " + _
                               "compruebe que tenga permisos en la carpeta de destino.",
                               MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
                    End If
                Catch ex As Exception
                    MsgBox("Se ha producido un error al intentar convertir el texto a PDF: " + _
                    vbCrLf + vbCrLf + ex.Message,
                    MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)




                End Try


            Else
                TextBoxPago.Clear()
            End If

            TextBoxPago.Clear()
        End If



    End Sub

    Private Sub ButtonAtras_Click(sender As Object, e As EventArgs) Handles ButtonAtras.Click
        FormClientes2.Show()
        Datoscompartidos.Dato = ""
        Me.Close()
    End Sub

End Class