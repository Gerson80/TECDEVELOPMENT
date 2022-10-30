Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO 'librería de entrada y salida de visual con el sistema
Imports System.Data.SqlClient
Public Class FormAgregardatosCliente2
    Public IDImpreso As String
    Public PrecioModi
    Public Enganche
    Public Abonos
    Private cadenaConexion As String = "Data Source=DESKTOP-KH7N6DR\SQLEXPRESS;Initial Catalog=Datos_TECDEVELOPMENT;Persist Security Info=True;User ID=sa;Password=12345678"
    Dim con As New SqlConnection("Data Source=DESKTOP-KH7N6DR\SQLEXPRESS;Initial Catalog=Datos_TECDEVELOPMENT;Persist Security Info=True;User ID=sa;Password=12345678")

    Private Sub FormAgregardatosCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LabelNombre.Text = Datoscompartidos.Marca + " " + Datoscompartidos.Modelo
        LabelAnio.Text = Datoscompartidos.anio
        LabelPrecio.Text = "$" + Datoscompartidos.precio

    End Sub

    Private Sub ButtonCancelar_Click(sender As Object, e As EventArgs) Handles ButtonCancelar.Click
        FormProductos2.Show()
        Me.Close()
        Datoscompartidos.anio = ""
        Datoscompartidos.Ciudad = ""
        Datoscompartidos.Consumo = ""
        Datoscompartidos.ID = ""
        Datoscompartidos.Marca = ""
        Datoscompartidos.Modelo = ""
        Datoscompartidos.precio = ""
        Datoscompartidos.puertas = ""
        Datoscompartidos.stock = ""
        Datoscompartidos.Sucursal = ""
        Datoscompartidos.Tipo = ""
    End Sub

    Private Sub ButtonAtras_Click(sender As Object, e As EventArgs) Handles ButtonAtras.Click
        FormCaracteristicas2.Show()
        Me.Hide()
    End Sub


    Private Sub BontonAceptar_Click(sender As Object, e As EventArgs) Handles BontonAceptar.Click
        Dim Nombre = TextBoxNombre.Text
        Dim Telefono = TextBoxTelefono.Text
        Dim Correo = TextBoxCorreo.Text
        Dim Ciudad = TextBoxCiudad.Text
        Dim Domicilio = TextBoxDomicilio.Text
        Dim fecha = DateTimePicker.Value.Date
        Dim fecha1 = DateTimePicker.Value.Date.ToString("yyyy/MM/dd")

        Dim dato
        If Nombre = "" Or Telefono = "" Or Correo = "" Or Ciudad = "" Or Domicilio = "" Then
            MsgBox("No puede dejar campos vacios")
        Else
            Using cnn As New SqlConnection(cadenaConexion)
                Dim cmd As SqlCommand = cnn.CreateCommand()
                cmd.CommandText = "insert into Autos_vendidos values('" & Datoscompartidos.Marca & "','" & Datoscompartidos.Modelo & "','" & Datoscompartidos.precio & "','" & Datoscompartidos.Tipo & "','" & Datoscompartidos.Consumo & "','" & Datoscompartidos.Ciudad & "','" & Datoscompartidos.Sucursal & "','" & Datoscompartidos.puertas & "','" & Datoscompartidos.anio & "')"
                cnn.Open()
                Dim value As Object = cmd.ExecuteScalar()

                cmd.CommandText = "SELECT TOP 1 ID_AutoVendido FROM Autos_Vendidos ORDER BY ID_AutoVendido  DESC;"
                Dim value2 As Object = cmd.ExecuteScalar()
                dato = Convert.ToInt64(value2)
                IDImpreso = dato

                cmd.CommandText = "insert into Clientes values('" & dato & "','" & Nombre & "','" & Telefono & "','" & Correo & "','" & Ciudad & "','" & Domicilio & "')"
                Dim value3 As Object = cmd.ExecuteScalar()


                cmd.CommandText = "SELECT TOP 1 ID_Cliente FROM Clientes ORDER BY ID_Cliente  DESC"
                Dim value4 As Object = cmd.ExecuteScalar()
                dato = Convert.ToInt64(value4)

                cmd.CommandText = "insert into FormaCompra values('" & dato & "','" & ComboBox1.Text & "')"
                Dim value5 As Object = cmd.ExecuteScalar()


                cmd.CommandText = "SELECT TOP 1 ID_FormaCompra FROM FormaCompra  ORDER BY ID_FormaCompra DESC"
                Dim value6 As Object = cmd.ExecuteScalar()
                dato = Convert.ToInt64(value6)

                If ComboBox1.Text = "Contado" Then
                    cmd.CommandText = "insert into Cliente_Contado values('" & dato & "','" & fecha1 & "')"
                    Dim value7 As Object = cmd.ExecuteScalar()



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
                        Col3 = New PdfPCell(New Phrase("Recibo de venta", fontTitulo))
                        Col3.Border = 0
                        tabla1.AddCell(Col3)


                        Col2 = New PdfPCell(New Phrase("Vendido a:", font8))
                        Col2.Border = 0
                        tabla1.AddCell(Col2)
                        tabla1.AddCell(CVacio)
                        tabla1.AddCell(CVacio)
                        tabla1.AddCell(CVacio)


                        Col2 = New PdfPCell(New Phrase(TextBoxNombre.Text, font8))
                        Col2.Border = 0
                        tabla1.AddCell(Col2)
                        tabla1.AddCell(CVacio)
                        tabla1.AddCell(CVacio)
                        Col3 = New PdfPCell(New Phrase(fecha1, font8))
                        Col3.Border = 0
                        tabla1.AddCell(Col3)


                        Col2 = New PdfPCell(New Phrase(TextBoxDomicilio.Text, font8))
                        Col2.Border = 0
                        tabla1.AddCell(Col2)
                        tabla1.AddCell(CVacio)
                        tabla1.AddCell(CVacio)
                        Col3 = New PdfPCell(New Phrase("N° de factura: " & IDImpreso, font8))
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

                        colum = New PdfPCell(New Phrase("Marca: " & Datoscompartidos.Marca, font88))
                        colum.Border = 0
                        tabla3.AddCell(colum)

                        colum = New PdfPCell(New Phrase("Modelo: " & Datoscompartidos.Modelo, font88))
                        colum.Border = 0
                        tabla3.AddCell(colum)

                        colum = New PdfPCell(New Phrase("Año: " & Datoscompartidos.anio, font88))
                        colum.Border = 0
                        tabla3.AddCell(colum)

                        colum = New PdfPCell(New Phrase("Tpo de transmición: " & Datoscompartidos.Tipo, font88))
                        colum.Border = 0
                        tabla3.AddCell(colum)

                        colum = New PdfPCell(New Phrase("Consumo de gasolina: " & Datoscompartidos.Consumo, font88))
                        colum.Border = 0
                        tabla3.AddCell(colum)

                        colum = New PdfPCell(New Phrase("Puertas: " & Datoscompartidos.puertas, font88))
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

                        Dim precioImpreso = "Total pagado: " + Datoscompartidos.precio

                        tabla4.AddCell(CVacio)
                        tabla4.AddCell(CVacio)
                        tabla4.AddCell(CVacio)
                        Col13 = New PdfPCell(New Phrase(precioImpreso, font88))
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

                    cmd.CommandText = "insert into Clientes_Credito values('" & dato & "','" & fecha1 & "','" & ComboBox2.Text & "','" & Abonos & "','" & PrecioModi & "')"

                    Dim val As Object = cmd.ExecuteScalar()

                    cmd.CommandText = "SELECT TOP 1 ID_ClientesCredito FROM Clientes_Credito  ORDER BY ID_ClientesCredito DESC"
                    Dim val2 As Object = cmd.ExecuteScalar()
                    dato = Convert.ToInt64(val2)

                    Dim pag = PrecioModi - Enganche

                    cmd.CommandText = "insert into Abonos values('" & dato & "','" & Enganche & "','" & pag & "','" & fecha1 & "')"
                    Dim val3 As Object = cmd.ExecuteScalar()

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
                        Col3 = New PdfPCell(New Phrase("Recibo de venta", fontTitulo))
                        Col3.Border = 0
                        tabla1.AddCell(Col3)


                        Col2 = New PdfPCell(New Phrase("Vendido a:", font8))
                        Col2.Border = 0
                        tabla1.AddCell(Col2)
                        tabla1.AddCell(CVacio)
                        tabla1.AddCell(CVacio)
                        tabla1.AddCell(CVacio)


                        Col2 = New PdfPCell(New Phrase(TextBoxNombre.Text, font8))
                        Col2.Border = 0
                        tabla1.AddCell(Col2)
                        tabla1.AddCell(CVacio)
                        tabla1.AddCell(CVacio)
                        Col3 = New PdfPCell(New Phrase(fecha1, font8))
                        Col3.Border = 0
                        tabla1.AddCell(Col3)


                        Col2 = New PdfPCell(New Phrase(TextBoxDomicilio.Text, font8))
                        Col2.Border = 0
                        tabla1.AddCell(Col2)
                        tabla1.AddCell(CVacio)
                        tabla1.AddCell(CVacio)
                        Col3 = New PdfPCell(New Phrase("N° de factura: " & IDImpreso, font8))
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

                        colum = New PdfPCell(New Phrase("Marca: " & Datoscompartidos.Marca, font88))
                        colum.Border = 0
                        tabla3.AddCell(colum)

                        colum = New PdfPCell(New Phrase("Modelo: " & Datoscompartidos.Modelo, font88))
                        colum.Border = 0
                        tabla3.AddCell(colum)

                        colum = New PdfPCell(New Phrase("Año: " & Datoscompartidos.anio, font88))
                        colum.Border = 0
                        tabla3.AddCell(colum)

                        colum = New PdfPCell(New Phrase("Tpo de transmición: " & Datoscompartidos.Tipo, font88))
                        colum.Border = 0
                        tabla3.AddCell(colum)

                        colum = New PdfPCell(New Phrase("Consumo de gasolina: " & Datoscompartidos.Consumo, font88))
                        colum.Border = 0
                        tabla3.AddCell(colum)

                        colum = New PdfPCell(New Phrase("Puertas: " & Datoscompartidos.puertas, font88))
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
                        Col13 = New PdfPCell(New Phrase("Subtotal: " & PrecioModi, font88))
                        Col13.Border = 0
                        tabla4.AddCell(Col13)


                        tabla4.AddCell(CVacio)
                        tabla4.AddCell(CVacio)
                        tabla4.AddCell(CVacio)
                        Col13 = New PdfPCell(New Phrase("Enganche: " & Enganche, font88))
                        Col13.Border = 0
                        tabla4.AddCell(Col13)

                        tabla4.AddCell(CVacio)
                        tabla4.AddCell(CVacio)
                        tabla4.AddCell(CVacio)
                        Col13 = New PdfPCell(New Phrase("Total: : " & pag, font88))
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

                End If
                Dim resta = Datoscompartidos.stock
                resta = resta - 1
                cmd.CommandText = "update Autos set Stock='" & resta & "' where ID_Auto = '" & Datoscompartidos.ID & "' "

                Dim value9 As Object = cmd.ExecuteScalar()
                cnn.Close()
            End Using
            'MsgBox(fecha1)
            FormProductos2.Show()
            Me.Close()
            Datoscompartidos.anio = ""
            Datoscompartidos.Ciudad = ""
            Datoscompartidos.Consumo = ""
            Datoscompartidos.ID = ""
            Datoscompartidos.Marca = ""
            Datoscompartidos.Modelo = ""
            Datoscompartidos.precio = ""
            Datoscompartidos.puertas = ""
            Datoscompartidos.stock = ""
            Datoscompartidos.Sucursal = ""
            Datoscompartidos.Tipo = ""
        End If





    End Sub


    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "Crédito" Then
            ComboBox2.Visible = True
        Else
            ComboBox2.Visible = False
            LabelEnganche.Visible = False
            LabelTotal.Visible = False
            LabelAbonos.Visible = False
        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        If ComboBox2.Text = "3" Then
            PrecioModi = (Datoscompartidos.precio * 20 / 100) + Datoscompartidos.precio
            Enganche = PrecioModi * 10 / 100
            Abonos = (PrecioModi - Enganche) / 36
            LabelEnganche.Text = "Enganche: " & Enganche
            LabelTotal.Text = "Precio: " & PrecioModi
            LabelAbonos.Text = "Abonos: " & Abonos
            LabelEnganche.Visible = True
            LabelTotal.Visible = True
            LabelAbonos.Visible = True

        End If

        If ComboBox2.Text = "5" Then
            PrecioModi = (Datoscompartidos.precio * 30 / 100) + Datoscompartidos.precio
            Enganche = PrecioModi * 10 / 100
            Abonos = (PrecioModi - Enganche) / 60
            LabelEnganche.Text = "Enganche: " & Enganche
            LabelTotal.Text = "Precio: " & PrecioModi
            LabelAbonos.Text = "Abonos: " & Abonos
            LabelEnganche.Visible = True
            LabelTotal.Visible = True
            LabelAbonos.Visible = True
        End If




    End Sub

End Class