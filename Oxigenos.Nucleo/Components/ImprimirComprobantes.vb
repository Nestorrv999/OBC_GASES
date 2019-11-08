Imports System.IO

'<summary>
' CLASE UTILIZADA PARA IMPRIMIR LOS DOCUMENTOS EN LA IMPRESORA ZEBRA
' UTILIZA LENGUAJE EPL
' HEREDA DE LA CLASE BASE DATASCAN.PRINTBASE
'</summary>
Public Class ImprimirComprobantes
    Inherits PrintManager
    'CONSTANTE DE ANCHO DE PAPEL
    Private Const T70 As Double = 11.7234042553192
    Private Const TReglon As Double = 35
    Private TInicioReglonY As Double = 545
    Private TInicioReglonX As Double = 24
    Private TInicioReglonReportesX As Double = 24
    Private TInicioReglonReportesY As Double = 10
    
    Private m_iInicioTabla As Integer = 0

    Private m_sObservaciones As String = ""

    Public Sub New(ByVal iPrinterModel As PrinterModels)
        m_iTipoImpresora = iPrinterModel
    End Sub

    'Public Function Print(ByVal doc As PrinterReport) As Boolean
    '    If m_iTipoImpresora = PrinterModels.ZebraPortatil Then
    '        PrintPortatil(doc)
    '    Else
    '        PrintSyscan(doc)
    '    End If
    'End Function

    Public Function Print(ByVal doc As PrinterDocument) As Boolean
        If m_iTipoImpresora = PrinterModels.ZebraPortatil Then
            Return PrintPortatil(doc)
        Else
            ' Return PrintSyscan(doc)
        End If
    End Function

    Private nTitulo As Integer = 0
    Private Function CalcularReglon(ByVal bTitulo As Boolean) As String
        Dim sCoordenadas As String
        If bTitulo Then
            sCoordenadas = TInicioReglonReportesX.ToString + " " + (TInicioReglonReportesY + ((m_iNumeroReglones - 6) * (TReglon + 20))).ToString
            nTitulo = nTitulo + 20
            Return "T 7 1 " + sCoordenadas + " "
        Else
            sCoordenadas = TInicioReglonReportesX.ToString + " " + (TInicioReglonReportesY + 20 + nTitulo + ((m_iNumeroReglones - 6) * TReglon)).ToString
            Return "T 7 0 " + sCoordenadas + " "
        End If
    End Function

    ' TIPO FUNCION : METODO DE LA CLASE
    ' DESCRIPCION: FUNCION PARA IMPRIMIR LOS TIQUETES
    '              ESTA FUNCION UTILIZA UNA PLANTILLA QUE CONTIENE LAS INSTRUCCIONES EPL
    Public Function PrintPortatil(ByVal doc As PrinterReport) As Boolean
        ' Se agrega el encabezado del documento
        Me.InitPage()
        'Me.AppendLine("! 0 200 200 1000 1")
        'Me.AppendLine("JOURNAL")
        'Me.AppendLine("CONTRAST 3")
        'Me.AppendLine("TONE 0")
        'Me.AppendLine("SPEED 3")
        'Me.AppendLine("PAGE-WIDTH 840")
        'Me.AppendLine("BAR-SENSE")
        AppendLine(CalcularReglon(True) & "OXIGENOS DE COLOMBIA" & Space(5) & Now.ToString("yyyy/MM/dd HH:mm"))
        AppendLine(CalcularReglon(True) & "Sucursal:  {0} Placa: {1}", _
            GestorNucleo.dsNucleo.Parametros(0).NombreSucursal, _
            GestorNucleo.dsNucleo.Parametros(0).CodigoVehiculo)
        AppendLine(CalcularReglon(True) & "Conductor: {0} Ruta:  {1} ", _
            GestorNucleo.dsNucleo.Parametros(0).NombreChofer, _
            GestorNucleo.dsNucleo.Parametros(0).RutaPrincipal)


        ' Se agrega la linea de titulos
        AppendLine(CalcularReglon(True) & doc.Titulo)
        Dim col As PrinterReport.ColumnInfo
        Dim Item As KeyValuePair(Of String, PrinterReport.ColumnInfo)
        If doc.Titulo.IndexOf("DOCUMENTOS GENERADOS") >= 0 Then
            'MODIFICAR LA TABLA
            'PRIMERO LOS DATOS
            Dim iPos As Integer = 0
            For Each Item In doc.Columnas
                col = Item.Value
                Select Case iPos
                    Case 0
                        col.MaxLength = 9
                    Case 1
                        col.Caption = "Documen."
                        col.MaxLength = 8
                    Case 2
                        col.Caption = "Codigo"
                        col.MaxLength = 8
                    Case 3
                        col.Caption = "Nombre"
                        col.MaxLength = 20
                    Case 4
                        col.MaxLength = 13
                End Select
                iPos = iPos + 1
            Next
        End If
        Dim sTitulos As String = Space(2)
        Dim sSepTitulo As String = Space(2)
        Dim sSepTotales As String = Space(2)
        Dim sTotales As String = Space(2)
        For Each Item In doc.Columnas
            col = Item.Value
            If col.Alineacion = PrinterReport.TipoAlineacion.Izquierda Then
                sTitulos &= AlignLeft(col.Caption, col.MaxLength + 1)
            Else
                sTitulos &= AlignRight(col.Caption, col.MaxLength) & " "
            End If
            sSepTitulo &= StrDup(col.MaxLength, "-"c) & " "

            If col.Total IsNot Nothing AndAlso col.Total <> "" Then
                sSepTotales &= StrDup(col.MaxLength, "-"c) & " "
                sTotales &= AlignRight(col.Total, col.MaxLength) & " "
            Else
                sTotales &= Space(col.MaxLength + 1)
                sSepTotales &= Space(col.MaxLength + 1)
            End If
        Next
        AppendLine(CalcularReglon(False) & sTitulos)
        AppendLine(CalcularReglon(False) & sSepTitulo)

        ' Se agregan los registros
        Dim I As Integer
        Dim sRegistro As String = Nothing
        Dim sValor As String
        For I = 0 To doc.dtReporte.Rows.Count - 1
            sRegistro = Space(2)
            For Each Item In doc.Columnas
                col = Item.Value
                If col.Formato <> "" Then
                    sValor = String.Format("{0:" & col.Formato & "}", doc.dtReporte.Rows(I)(col.FieldName))
                Else
                    sValor = CStr(doc.dtReporte.Rows(I)(col.FieldName))
                End If
                If col.Alineacion = PrinterReport.TipoAlineacion.Izquierda Then
                    sRegistro &= AlignLeft(sValor, col.MaxLength + 1)
                Else
                    sRegistro &= AlignRight(sValor, col.MaxLength) & " "
                End If
            Next
            AppendLine(CalcularReglon(False) & sRegistro)
        Next

        ' Se agregan los totales
        AppendLine(CalcularReglon(False) & sSepTotales)
        AppendLine(CalcularReglon(False) & sTotales)

        Me.RemplazarTexto("! 0 200 200 1000 1", Me.CalcularTamañoPapel(m_iNumeroReglones))

        ' Me.AppendLine("PRINT")
        Me.EndPage()
        'ENVIO LA IMPRESION
        Return Me.SendDataToPrinter()

        
    End Function

    ' TIPO FUNCION : METODO DE LA CLASE
    ' DESCRIPCION: FUNCION PARA IMPRIMIR LOS TIQUETES
    '              ESTA FUNCION UTILIZA UNA PLANTILLA QUE CONTIENE LAS INSTRUCCIONES EPL
    Public Function PrintPortatil(ByVal doc As PrinterDocument) As Boolean
        'CARGO LA PLANTILLA
        If Not File.Exists(Settings.Etiqueta) Then
            Return False
        End If
        Dim fArchivoFacturas As New StreamReader(Settings.Etiqueta)
        Try
            Dim sLineaLeer As String = ""
            Me.InitPage()
            sLineaLeer = fArchivoFacturas.ReadLine
            While Not sLineaLeer Is Nothing
                'REEMPLAZO LOS TAGS DE LA PLANTILLA POR LOS VALORES
                Me.AppendLine(Me.ReemplazarVariables(sLineaLeer, doc))
                sLineaLeer = fArchivoFacturas.ReadLine
            End While
            'CALCULO EL TAMAÑO DEL PAPEL
            'EL TAMAÑO ES CONSTANTE
            'Me.RemplazarTexto("! 0 200 200 1000 1", Me.CalcularTamañoPapel(m_iNumeroLineas,40))
            Me.AppendLine("PRINT")
            Me.EndPage()
            'ENVIO LA IMPRESION
            For i As Integer = 1 To CInt(Settings.NumeroEtiquetas)
                Select Case i
                    Case 2
                        Me.RemplazarTexto("ORIGINAL", "PRIMERA COPIA")
                    Case 3
                        Me.RemplazarTexto("PRIMERA COPIA", "SEGUNDA COPIA")
                    Case 4
                        Me.RemplazarTexto("SEGUNDA COPIA", "TERCERA COPIA")
                    Case 5
                        Me.RemplazarTexto("TERCERA COPIA", "CUARTA COPIA")
                End Select
                Me.SendDataToPrinter()
                While Not UIHandler.Confirm("¿La copia N0. " + i.ToString + " del documento fue impreso correctamente?", "Impresión Correcta?")
                    Me.SendDataToPrinter()
                End While
            Next
            Return True
        Catch
            Return False
        Finally
            fArchivoFacturas.Close()
        End Try
    End Function
    ''' <summary>
    ''' Imprimir hoja de ruta
    ''' </summary>
    ''' <param name="doc"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function PrintPortatilHojaRuta(ByVal doc As PrinterDocument) As Boolean
        'CARGO LA PLANTILLA
        ' Se agrega el encabezado del documento
        'CARGO LA PLANTILLA
        If Not File.Exists(Settings.EtiquetaHojaRuta) Then
            Return False
        End If
        Dim fArchivoFacturas As StreamReader
        Try
            Dim sLinea As String = ""

            Me.InitPage()
            Me.AppendLine("! 0 200 200 2000 1")
            Me.AppendLine("JOURNAL")
            Me.AppendLine("CONTRAST 1")
            Me.AppendLine("TONE 0")
            Me.AppendLine("SPEED 2")
            Me.AppendLine("PAGE-WIDTH 840")
            Me.AppendLine("BAR-SENSE")

            Dim numeroHojasImpresion As Integer = (doc.DetalleHojaruta.Count \ 15)
            If (doc.DetalleHojaruta.Count \ 15) > 0 Then
                numeroHojasImpresion = numeroHojasImpresion + 1
            Else
                numeroHojasImpresion = 1
            End If

            For numeroIteracion As Integer = 0 To numeroHojasImpresion - 1
                fArchivoFacturas = New StreamReader(Settings.EtiquetaHojaRuta)
                sLinea = fArchivoFacturas.ReadLine
                While Not sLinea Is Nothing
                    'REEMPLAZO LOS TAGS DE LA PLANTILLA POR LOS VALORES

                    If sLinea.IndexOf("[") >= 0 Then
                        Dim sVariable As String = sLinea.Substring(sLinea.IndexOf("[") + 1)
                        If sVariable.IndexOf("]") >= 0 Then
                            sVariable = sVariable.Substring(0, sVariable.IndexOf("]"))
                        End If
                        Dim tagOriginal As String = String.Empty
                        If sVariable.StartsWith("(Linea)") Then
                            tagOriginal = "[" + sVariable + "]"
                            sVariable = "(LINEA)"
                        End If
                        Select Case sVariable.ToUpper
                            Case "(LINEA)"
                                Dim nombreTag As String = tagOriginal.Substring(8) '"PresionInicial"
                                nombreTag = nombreTag.Substring(0, nombreTag.Length - 2)
                                Dim posicionTag As Integer = CInt(tagOriginal.Substring(tagOriginal.Length - 2, 1))
                                Dim valorRemplazar As String = Me.ObtenerValor(nombreTag, posicionTag, numeroIteracion, doc.DetalleHojaruta)
                                sLinea = sLinea.Replace(tagOriginal, valorRemplazar)
                            Case "PRODUCTO"
                                sLinea = sLinea.Replace("[Producto]", doc.Producto)
                            Case "TOTALM3"
                                sLinea = sLinea.Replace("[Totalm3]", doc.Totalm3)
                            Case "TANQUERO"
                                sLinea = sLinea.Replace("[Tanquero]", doc.Tanquero)
                            Case "CABEZOTE"
                                sLinea = sLinea.Replace("[Cabezote]", doc.Cabezote)
                            Case "HORASALIDA"
                                sLinea = sLinea.Replace("[HoraSalida]", doc.HoraSalida)
                            Case "HORAENTRADA"
                                sLinea = sLinea.Replace("[HoraEntrada]", doc.HoraEntrada)
                            Case "KMSALIDA"
                                sLinea = sLinea.Replace("[kmSalida]", doc.KmSalida)

                            Case "FECHASALIDA"
                                sLinea = sLinea.Replace("[FechaSalida]", doc.FechaSalida)

                            Case "KMENTRADA"
                                sLinea = sLinea.Replace("[KmEntrada]", doc.KmEntrada)

                            Case "FECHAENTRADA"
                                sLinea = sLinea.Replace("[Fechaentrada]", doc.FechaEntrada)

                            Case "TOTALHORA"

                                sLinea = sLinea.Replace("[TotalHora]", CStr(doc.Totalhoras))

                            Case "TOTALKM"
                                sLinea = sLinea.Replace("[TotalKm]", CStr(doc.Totalkm))

                            Case "HOJARUTA"
                                sLinea = sLinea.Replace("[hojaruta]", doc.HojaRuta)
                            Case "TERMINAL"
                                sLinea = sLinea.Replace("[Terminal]", doc.Terminal)
                            Case "NOMBRETRANSPORTADORA"
                                sLinea = sLinea.Replace("[Nombretransportadora]", doc.Nombretransportadora)
                            Case "CEDULA"
                                sLinea = sLinea.Replace("[cedula]", doc.CodConductor)
                            Case "CHOFER"
                                sLinea = sLinea.Replace("[chofer]", doc.NombreConductor)
                            Case "PTDEVENTA"
                                sLinea = sLinea.Replace("[PtdeVenta]", doc.PtvdeVenta)

                        End Select

                    End If


                    'Finalmente se agrega la linea
                    Me.AppendLine(sLinea)
                    sLinea = fArchivoFacturas.ReadLine
                End While
                'CALCULO EL TAMAÑO DEL PAPEL
                'EL TAMAÑO ES CONSTANTE
                'Me.RemplazarTexto("! 0 200 200 1000 1", Me.CalcularTamañoPapel(m_iNumeroLineas,40))
                'Me.AppendLine("PRINT")
                Me.EndPage()
                fArchivoFacturas.Close()
            Next
            Me.SendDataToPrinter()
        Catch ex As Exception
            UIHandler.ShowAlert(ex.Message)
        Finally

        End Try

    End Function


    Private Function ObtenerValor(ByVal nombreTag As String, ByVal posicionTag As Integer, ByVal numeroIteracion As Integer, ByVal DetalleHojaruta As List(Of Common.PrinterDocument.DetalleReporteHojaRuta)) As String
        If (posicionTag + (numeroIteracion * 15)) < DetalleHojaruta.Count Then
            Select Case nombreTag.ToUpper
                Case "PRINICIAL"
                    Return DetalleHojaruta(posicionTag + (numeroIteracion * 15)).PresionInicial
                Case "REMISION"
                    Return DetalleHojaruta(posicionTag + (numeroIteracion * 15)).NoRemision
                Case "RELACIONCARGUE"
                    If DetalleHojaruta(posicionTag + (numeroIteracion * 15)).RelacionCargue.Length > 64 Then
                        Return DetalleHojaruta(posicionTag + (numeroIteracion * 15)).RelacionCargue.Substring(0, 64)
                    Else
                        Return DetalleHojaruta(posicionTag + (numeroIteracion * 15)).RelacionCargue
                    End If
                Case "DIA"
                    Return DetalleHojaruta(posicionTag + (numeroIteracion * 15)).Dia
                Case "KMLLEGDA"
                    Return DetalleHojaruta(posicionTag + (numeroIteracion * 15)).KmLLegada
                Case "HRLLEGDA"
                    Return DetalleHojaruta(posicionTag + (numeroIteracion * 15)).HoraLlegada
                Case "HRSALIDA"
                    Return DetalleHojaruta(posicionTag + (numeroIteracion * 15)).HoraTerminada
                Case "TOTAL"
                    Return DetalleHojaruta(posicionTag + (numeroIteracion * 15)).TotalCargado
                Case "PRFINAL"
                    Return DetalleHojaruta(posicionTag + (numeroIteracion * 15)).PresionFinal
                Case "NIVELINI"
                    Return DetalleHojaruta(posicionTag + (numeroIteracion * 15)).NivelInicial
                Case "NIVFINAL"
                    Return DetalleHojaruta(posicionTag + (numeroIteracion * 15)).NivelFinal
            End Select

        Else
            Return String.Empty
        End If
    End Function


    ' TIPO FUNCION : METODO DE LA CLASE
    ' DESCRIPCION: FUNCION PARA PROBAR LA COMUNICACION CON LA IMPRESORA
    Public Function ProbarImpresora() As Boolean
        Me.InitPage()
        Me.AppendLine(" ")
        Me.EndPage()
        Return Me.SendDataToPrinter()
    End Function

    ' TIPO FUNCION : METODO DE LA CLASE
    ' DESCRIPCION: FUNCION PARA REEMPLAZAR LOS TAGS DE LAS PLANTILLAS POR EL VALOR DE LAS VARIABLES
    Private Function ReemplazarVariablesHojaRuta(ByVal sLinea As String, ByVal doc As PrinterDocument) As String
        If sLinea.IndexOf("[") >= 0 Then
            Dim sVariable As String = sLinea.Substring(sLinea.IndexOf("[") + 1)
            If sVariable.IndexOf("]") >= 0 Then
                sVariable = sVariable.Substring(0, sVariable.IndexOf("]"))
            End If
            Select Case sVariable.ToUpper
                Case "Producto"
                    sLinea = sLinea.Replace("[Producto]", doc.Producto)
                Case "Totalm3"
                    sLinea = sLinea.Replace("[Totalm3]", doc.Totalm3)
                Case "Tanquero"
                    sLinea = sLinea.Replace("[Tanquero]", doc.Tanquero)
                Case "Cabezote"
                    'If doc.Cliente.Direccion.Length <= 20 Then
                    sLinea = sLinea.Replace("[Cabezote]", doc.Cabezote)
                    'Else
                    'sLinea = sLinea.Replace("[DIRECCION]", doc.Cliente.Direccion.Substring(0, 20))
                    'End If
                Case "HoraSalida"
                    ' If doc.Cliente.Direccion.Length <= 20 Then
                    sLinea = sLinea.Replace("[HoraSalida]", doc.HoraSalida)
                    'Else
                    'sLinea = sLinea.Replace("[DIRECCION2]", doc.Cliente.Direccion.Substring(20, doc.Cliente.Direccion.Length - 20))
                    ' End If
                Case "kmSalida"
                    sLinea = sLinea.Replace("[kmSalida]", doc.KmSalida)

                Case "FechaSalida"
                    sLinea = sLinea.Replace("[FechaSalida]", doc.FechaSalida)

                Case "KmEntrada"
                    sLinea = sLinea.Replace("[KmEntrada]", doc.KmEntrada)

                Case "Fechaentrada"
                    sLinea = sLinea.Replace("[Fechaentrada]", doc.FechaEntrada)

                Case "TotalHora"

                    sLinea = sLinea.Replace("[TotalHora]", CStr(doc.Totalhoras))

                Case "TotalKm"
                    sLinea = sLinea.Replace("[TotalKm]", CStr(doc.Totalkm))

                Case "hojaruta"
                    sLinea = sLinea.Replace("[hojaruta]", doc.HojaRuta)
                Case "Terminal"
                    sLinea = sLinea.Replace("Terminal", doc.Terminal)

            End Select
            Dim i As Integer
            For i = 0 To 9

            Next i
        End If
        Return sLinea
    End Function
    ' TIPO FUNCION : METODO DE LA CLASE
    ' DESCRIPCION: FUNCION PARA REEMPLAZAR LOS TAGS DE LAS PLANTILLAS POR EL VALOR DE LAS VARIABLES
    Private Function ReemplazarVariables(ByVal sLinea As String, ByVal doc As PrinterDocument) As String
        If sLinea.IndexOf("[") >= 0 Then
            Dim sVariable As String = sLinea.Substring(sLinea.IndexOf("[") + 1)
            If sVariable.IndexOf("]") >= 0 Then
                sVariable = sVariable.Substring(0, sVariable.IndexOf("]"))
            End If
            Select Case sVariable.ToUpper
                Case "NOMBRE EMPRESA"
                    If CStrDBNull(Nucleo.RowParametros("CodigoEmpresa")) = "21" Then
                        sLinea = sLinea.Replace("[NOMBRE EMPRESA]", "OXIGENOS DE COLOMBIA LTDA")
                    Else
                        sLinea = sLinea.Replace("[NOMBRE EMPRESA]", "LIQUIDO CARBONICO COLOMBIANA S.A")
                    End If
                Case "NIT EMPRESA"
                    sLinea = sLinea.Replace("[NIT EMPRESA]", CStrDBNull(Nucleo.RowParametros("NitPraxair")))
                Case "CLIENTE"
                    sLinea = sLinea.Replace("[CLIENTE]", doc.Cliente.Nombre)
                Case "DIRECCION"
                    If doc.Cliente.Direccion.Length <= 20 Then
                        sLinea = sLinea.Replace("[DIRECCION]", doc.Cliente.Direccion)
                    Else
                        sLinea = sLinea.Replace("[DIRECCION]", doc.Cliente.Direccion.Substring(0, 20))
                    End If
                Case "DIRECCION2"
                    If doc.Cliente.Direccion.Length <= 20 Then
                        sLinea = sLinea.Replace("[DIRECCION2]", "")
                    Else
                        sLinea = sLinea.Replace("[DIRECCION2]", doc.Cliente.Direccion.Substring(20, doc.Cliente.Direccion.Length - 20))
                    End If
                Case "TELEFONO"
                    sLinea = sLinea.Replace("[TELEFONO]", doc.Cliente.Telefono)
                Case "BARRIO"
                    sLinea = sLinea.Replace("[BARRIO]", doc.Cliente.Barrio)
                Case "NIT"
                    sLinea = sLinea.Replace("[NIT]", doc.Cliente.NIT)
                Case "ENTIDAD"
                    sLinea = sLinea.Replace("[ENTIDAD]", doc.Cliente.Entidad)
                Case "SUCURSAL"
                    sLinea = sLinea.Replace("[SUCURSAL]", doc.Sucursal)
                Case "DOCUMENTO"
                    sLinea = sLinea.Replace("[DOCUMENTO]", doc.Nombre + " - " + doc.Consecutivo)
                Case "FE-A"
                    sLinea = sLinea.Replace("[FE-A]", doc.FechaElaboracion.Year.ToString)
                Case "FE-M"
                    sLinea = sLinea.Replace("[FE-M]", doc.FechaElaboracion.Month.ToString)
                Case "FE-D"
                    sLinea = sLinea.Replace("[FE-D]", doc.FechaElaboracion.Day.ToString)
                Case "FV-A"
                    sLinea = sLinea.Replace("[FV-A]", doc.FechaVencimiento.Year.ToString)
                Case "FV-M"
                    sLinea = sLinea.Replace("[FV-M]", doc.FechaVencimiento.Month.ToString)
                Case "FV-D"
                    sLinea = sLinea.Replace("[FV-D]", doc.FechaVencimiento.Day.ToString)
                Case "CODIGOCLIENTE"
                    sLinea = sLinea.Replace("[CODIGOCLIENTE]", doc.Cliente.Codigo.ToString)
                Case "ORDENCOMPRA"
                    sLinea = sLinea.Replace("[ORDENCOMPRA]", doc.OrdenCompra)
                Case "PEDIDO"
                    sLinea = sLinea.Replace("[PEDIDO]", doc.NumPedido)
                Case "DETALLEFACTURA"
                    Dim i As Integer = 0
                    Dim sCoordenadas As String = ""
                    Dim sReglon As String = ""
                    Dim iNumeroReglones As Int32 = 0
                    Dim sLineaAdicional As String = sLinea
                    For i = 0 To doc.Items.Count - 1
                        If doc.Items(i).Descripcion.Length > 20 Then
                            doc.Items(i).Descripcion = doc.Items(i).Descripcion.Substring(0, 20)
                        End If
                        sCoordenadas = TInicioReglonX.ToString + " " + (TInicioReglonY + (iNumeroReglones * TReglon)).ToString
                        If doc.Items(i).UsaPrecios Then
                            sReglon = String.Format("{0,-8}{1,-20}{2,9:#,##0}{3,7}{4,9:#,##0}{5,11:#,##0}", _
                                doc.Items(i).CodProducto, doc.Items(i).Descripcion, doc.Items(i).Cantidad, _
                                doc.Items(i).UnidadMedida, doc.Items(i).PrecioUnitario, doc.Items(i).PrecioTotal)
                        Else
                            sReglon = String.Format("{0,-8}{1,-20}{2,9:#,##0}{3,7}", _
                                doc.Items(i).CodProducto, doc.Items(i).Descripcion, _
                                doc.Items(i).Cantidad, doc.Items(i).UnidadMedida)
                        End If
                        If i = 0 Then
                            sLinea = sLinea.Replace("[DETALLEFACTURA]", sCoordenadas + " " + sReglon)
                        Else
                            AppendLine(sLineaAdicional.Replace("[DETALLEFACTURA]", sCoordenadas + " " + sReglon))
                        End If
                        iNumeroReglones = iNumeroReglones + 1
                        If Not IsEmptyOrNull(doc.Items(i).InfoAdicional) Then
                            m_sObservaciones = doc.Items(i).InfoAdicional
                            'sLinea = sLinea.Replace("[OBSERVACIONES]", doc.Items(i).InfoAdicional)
                            'sCoordenadas = TInicioReglonX.ToString + " " + (TInicioReglonY + (iNumeroReglones * (TReglon - 15))).ToString
                            'AppendLine(sLineaAdicional.Replace("[DETALLEFACTURA]", sCoordenadas + " " + doc.Items(i).InfoAdicional))
                            'iNumeroReglones = iNumeroReglones + 1
                        End If
                    Next
                Case "OBSERVACIONES"
                    sLinea = sLinea.Replace("[OBSERVACIONES]", m_sObservaciones)
                Case "SUBTOTAL"
                    If doc.MostarTotales Then
                        sLinea = sLinea.Replace("[SUBTOTAL]", String.Format("{0:#,##0.00}", doc.Subtotal))
                    Else
                        sLinea = sLinea.Replace("[SUBTOTAL]", "")
                    End If
                Case "IVA"
                    If doc.MostarTotales Then
                        sLinea = sLinea.Replace("[IVA]", String.Format("{0:#,##0.00}", doc.TotalIVA))
                    Else
                        sLinea = sLinea.Replace("[IVA]", "")
                    End If
                Case "TOTAL"
                    If doc.MostarTotales Then
                        sLinea = sLinea.Replace("[TOTAL]", String.Format("{0:#,##0.00}", doc.Total))
                    Else
                        sLinea = sLinea.Replace("[TOTAL]", "")
                    End If
                Case "RESOLUCION"
                    If doc.Resolucion IsNot Nothing Then
                        sLinea = sLinea.Replace("[RESOLUCION]", String.Format("RESOLUCION DE FACTURACION DIAN RESOL. {0} DEL {1:dd/MM/yyyy}  FACTURA DESDE {2} ", doc.Resolucion.Numero, doc.Resolucion.Fecha, doc.Resolucion.RangoIni))
                    Else
                        sLinea = sLinea.Replace("[RESOLUCION]", "")
                    End If
                Case "RESOLUCION2"
                    If doc.Resolucion IsNot Nothing Then
                        sLinea = sLinea.Replace("[RESOLUCION2]", String.Format("HASTA {0} ", doc.Resolucion.RangoFin))
                    Else
                        sLinea = sLinea.Replace("[RESOLUCION2]", "")
                    End If
                Case "CHOFER"
                    sLinea = sLinea.Replace("[CHOFER]", GestorNucleo.dsNucleo.Parametros(0).NombreChofer)
                Case "RUTA"
                    sLinea = sLinea.Replace("[RUTA]", GestorNucleo.dsNucleo.Parametros(0).RutaPrincipal)
                Case "HORA"
                    sLinea = sLinea.Replace("[HORA]", Now.ToString("HH:mm"))
                Case "COPIA"
                    sLinea = sLinea.Replace("[COPIA]", "ORIGINAL")
                    'REEMPLAZAR VARIABLES
                Case "A1"
                    If doc.Nombre.IndexOf("FACT") >= 0 Then
                        sLinea = sLinea.Replace("[A1]", "Esta factura de venta se asimila en todos sus efectos a letra de cambio(Art. 774 codigo comercio)")
                    Else
                        sLinea = sLinea.Replace("[A1]", "")
                    End If
                Case "A2"
                    If doc.Nombre.IndexOf("FACT") >= 0 Then
                        sLinea = sLinea.Replace("[A2]", "y como tal se acepta por el comprador.")
                    Else
                        sLinea = sLinea.Replace("[A2]", "")
                    End If
                Case "L1"
                    If doc.Nombre.IndexOf("FACT") >= 0 Then
                        sLinea = sLinea.Replace("[L1]", "AUTORETENEDORES RES.0052 DE JUL 16/1992")
                    Else
                        sLinea = sLinea.Replace("[L1]", "")
                    End If
                Case "L2"
                    If doc.Nombre.IndexOf("FACT") >= 0 Then
                        sLinea = sLinea.Replace("[L2]", "IVA REGIMEN COMUN CIIU 2429")
                    Else
                        sLinea = sLinea.Replace("[L2]", "")
                    End If
                Case "L3"
                    If doc.Nombre.IndexOf("FACT") >= 0 Then
                        sLinea = sLinea.Replace("[L3]", "ICA BOGOTA 3699 TARIFA 11.4 X MIL")
                    Else
                        sLinea = sLinea.Replace("[L3]", "")
                    End If
                Case "L4"
                    If doc.Nombre.IndexOf("FACT") >= 0 Then
                        sLinea = sLinea.Replace("[L4]", "SOMOS GRANDES CONTRIBUYENTES (RES 2509 DIC 03/93)")
                    Else
                        sLinea = sLinea.Replace("[L4]", "")
                    End If
                Case "L5"
                    If doc.Nombre.IndexOf("FACT") >= 0 Then
                        sLinea = sLinea.Replace("[L5]", "SOMOS RETENEDORES DE IVA")
                    Else
                        sLinea = sLinea.Replace("[L5]", "")
                    End If
                Case "L6"
                    If doc.Nombre.IndexOf("FACT") >= 0 Then
                        sLinea = sLinea.Replace("[L6]", "AGENTE RETENEDOR DE IMPUESTOS SOBRE LAS VENTAS")
                    Else
                        sLinea = sLinea.Replace("[L6]", "")
                    End If
            End Select
        End If
        Return sLinea
    End Function

    ' TIPO FUNCION : METODO DE LA CLASE
    ' DESCRIPCION: FUNCION PARA ENVIAR LOS  COMANDOS EPL NECESARIOS PARA INICIAR UNA IMPRESION
    '              EN EL CASO QUE NO SE UTILICEN PLANTILLAS (CIERRE CAJA)
    Private Sub ImprimirInicioQL()
        Me.InitPage()
        Me.AppendLine("! 0 200 200 1000 1")
        Me.AppendLine("JOURNAL")
        Me.AppendLine("CONTRAST 0")
        Me.AppendLine("TONE 200")
        Me.AppendLine("SPEED 2")
        Me.AppendLine("PAGE-WIDTH 400")
        Me.AppendLine("BAR-SENSE")
        Me.AppendLine(";// PAGE 0000000004000600")
    End Sub

    ' TIPO FUNCION : METODO DE LA CLASE
    ' DESCRIPCION: FUNCION PARA CALCULAR EL TAMAÑO DEL PAPEL, DE ACUERDO AL NUMERO DE LINEAS ADICIONADAS
    Private Function CalcularTamañoPapel(ByVal nNumLineas As Integer) As String
        Dim iNuevoTamano As Integer = CInt(((1000 * nNumLineas) / 940))
        iNuevoTamano = CInt((nNumLineas * TReglon) + 50)
        Return "! 0 200 200 " + iNuevoTamano.ToString + " 1"
    End Function

    ' TIPO FUNCION : METODO DE LA CLASE
    ' DESCRIPCION: FUNCION PARA IMPRIMIR LOS TOTALES DEL CIERRE DE CAJA
    Public Sub InfoImprimirTotales()
        Dim nLin As Integer
        Dim nAnc As Integer
        Dim TotalRepMat As Double

        nAnc = 365
        TotalRepMat = 0

        Dim LineaImp As Integer = 0
        Dim i As Integer = 0
        ' Escribe Tìtulo centrado '
        LineaImp = LineaImp + 20
        Me.AppendLine(QL320ImpTexto("TOTALES POR DESTINOS", LineaImp, 20))

        LineaImp = LineaImp + 20
        nLin = LineaImp
        Me.AppendLine(QL320ImpLinea(15, nLin, nAnc, nLin, 3))

        LineaImp = LineaImp + 5
        Me.AppendLine(QL320ImpTexto("DESTINO", LineaImp, 20))
        Me.AppendLine(QL320ImpTexto("PX", LineaImp, 210))
        Me.AppendLine(QL320ImpTexto("TOTAL", LineaImp, 290))

        LineaImp = LineaImp + 25
        Me.AppendLine(QL320ImpLinea(15, LineaImp, nAnc, LineaImp, 3))

        For Each rw As Data.DataRow In New Data.DataTable("sd").Rows
            LineaImp = LineaImp + 5
            Me.AppendLine(QL320ImpTextoTabla(CStr(rw("DESTINO")), LineaImp, 20))
            Me.AppendLine(QL320ImpTextoTabla(CStr(rw("PASAJEROS")), LineaImp, 210))
            Me.AppendLine(QL320ImpTextoTabla(CStr(Format(rw("VALORDESTINO"), "$##,#0")), LineaImp, 260))
            LineaImp = LineaImp + 20
            i = i + 1
        Next

        LineaImp = LineaImp + 5
        Me.AppendLine(QL320ImpLinea(15, LineaImp, nAnc, LineaImp, 3))

        Me.AppendLine(QL320ImpLinea(15, nLin, 15, LineaImp, 1))
        Me.AppendLine(QL320ImpLinea(201, nLin, 201, LineaImp, 1))
        Me.AppendLine(QL320ImpLinea(255, nLin, 255, LineaImp, 1))
        Me.AppendLine(QL320ImpLinea(365, nLin, 365, LineaImp, 1))
        LineaImp = LineaImp + 75
        Me.AppendLine(QL320ImpTexto("Firma: ________________________", LineaImp, 35))
        LineaImp = LineaImp + 25
        Dim sAux As String = ""
        i = 0

        Me.AppendLine("BT 0 0 0")
        Me.AppendLine("BT OFF")

    End Sub

    ' TIPO FUNCION : METODO DE LA CLASE
    ' DESCRIPCION: FUNCION PARA IMPRIMIR TITULOS
    '              GENERA EL CODIGO EPL PARA IMPRIMIR TEXTO CON TAMAÑO DE FUENTA MAS GRANDE 
    Private Function QL320ImpTitulo(ByVal Texto As String, ByVal Fila As Integer, ByVal ColIni As Integer, ByVal Alineacion As Byte) As String
        Dim sTxt As String
        Dim nFte As Byte
        Dim nTam As Byte
        Dim nCol As Integer

        nFte = 0
        nTam = 4

        Select Case Alineacion
            Case 0 : nCol = ColIni
            Case 1 : nCol = CentroTexto(Texto, ColIni)
            Case Else : nCol = ColIni
        End Select

        sTxt = "T " & nFte & " " & nTam & " " & nCol & " " & Fila & " " & Texto

        Return sTxt
    End Function

    ' TIPO FUNCION : METODO DE LA CLASE
    ' DESCRIPCION: FUNCION PARA CENTRAR TEXTOS
    '              GENERA EL CODIGO EPL CON COORDENADAS DEL TEXTO CENTRADAS
    Private Function CentroTexto(ByVal Texto As String, ByVal PosIni As Integer) As Integer
        Dim nCar As Integer
        Dim nCen As Integer

        nCar = Len(Texto)
        nCen = Int(PuntoCentralTexto(47, nCar, PosIni) * CInt(T70))

        Return nCen
    End Function

    ' TIPO FUNCION : METODO DE LA CLASE
    ' DESCRIPCION: FUNCION PARA CENTRAR TEXTOS
    '              GENERA EL CODIGO EPL CON COORDENADAS DEL TEXTO CENTRADAS
    Private Function PuntoCentralTexto(ByVal MaxCar As Integer, ByVal NumCar As Integer, ByVal PosIni As Integer) As Integer
        Dim nCen As Integer
        Dim nTam As Integer

        nTam = MaxCar - PosIni
        nCen = PosIni + CInt((nTam - NumCar) / 2)

        Return nCen
    End Function

    ' TIPO FUNCION : METODO DE LA CLASE
    ' DESCRIPCION: FUNCION PARA IMPRIMIR LINEAS 
    '              GENERA EL CODIGO EPL PARA IMPRIMIR LINEAS SE BASA EN COORDENADAS (X0,X1 - Y1,Y1)
    Private Function QL320ImpLinea(ByVal X1 As Integer, ByVal Y1 As Integer, ByVal X2 As Integer, ByVal y2 As Integer, ByVal Grosor As Byte) As String
        Dim sTxt As String
        sTxt = "LINE " & X1 & " " & Y1 & " " & X2 & " " & y2 & " " & Grosor
        Return sTxt
    End Function

    ' TIPO FUNCION : METODO DE LA CLASE
    ' DESCRIPCION: FUNCION PARA IMPRIMIR TEXTOS
    '              GENERA EL CODIGO EPL PARA IMPRIMIR TEXTOS 
    Private Function QL320ImpTexto(ByVal Texto As String, ByVal Fila As Integer, ByVal Columna As Integer) As String
        Dim sTxt As String
        Dim nFte As Byte
        Dim nTam As Byte

        nFte = 0
        nTam = 2
        sTxt = "T " & nFte & " " & nTam & " " & Columna & " " & Fila & " " & Texto

        Return sTxt
    End Function

    ' TIPO FUNCION : METODO DE LA CLASE
    ' DESCRIPCION: FUNCION PARA IMPRIMIR TEXTOS EN CELDAS DE LAS TABLAS
    '              GENERA EL CODIGO EPL CON LAS COORDENADAS DE IMPRESION DE CELDAS
    Private Function QL320ImpTextoTabla(ByVal Texto As String, ByVal Fila As Integer, ByVal Columna As Integer) As String
        Dim sTxt As String
        Dim nFte As Byte
        Dim nTam As Byte

        nFte = 0
        nTam = 2
        sTxt = "T " & nFte & " " & nTam & " " & Columna & " " & Fila & " " & Texto

        Return sTxt
    End Function

    Public Function CStrDBNull(ByVal sValor As Object, Optional ByVal sValorDefecto As String = "") As String
        If sValor Is Nothing Then
            Return sValorDefecto
        ElseIf sValor.GetType Is Type.GetType("System.DBNull") Then
            If sValorDefecto <> "" Then
                Return sValorDefecto
            Else
                Return ""
            End If
        Else
            Return CStr(sValor)
        End If
    End Function

End Class





