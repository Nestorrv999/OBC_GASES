Imports System.Data
Imports System.Text
Imports System.Math
Imports System.IO
Imports OpenNETCF.IO.Serial
Imports OpenNETCF.VisualBasic
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Public Class PrintManager
    Private portSettings As New HandshakeNone()
    Private Port As Port
    Private m_gnucleo As New NucleoDataAccess
    Private sbDoc As StringBuilder
    Public m_iTipoImpresora As PrinterModels
    Public m_iNumeroReglones As Integer = 0
    Public m_subtotal As Double
    Public m_restalinea As Integer = 15

#Region "Constantes Portatil"
    'CONSTANTE DE ANCHO DE PAPEL
    Private Const T70 As Double = 11.7234042553192
    Private Const TReglon As Double = 35
    Private TInicioReglonY As Double = 592
    Private TInicioReglonX As Double = 24
    Private TInicioReglonReportesX As Double = 24
    Private TInicioReglonReportesY As Double = 10

    Private m_iInicioTabla As Integer = 0

    Private m_sObservaciones As String = ""
    Private numFilasImpresion As Integer = 20
#End Region
    Private Sub OpenPort()
        ' Se crea y se abre el puerto de la impresora
        'portSettings.BasicSettings.BaudRate = BaudRates.CBR_9600
        'portSettings.BasicSettings.ByteSize = 8
        'portSettings.BasicSettings.Parity = Parity.none
        'portSettings.BasicSettings.StopBits = StopBits.one
        'Port = New Port(Settings.PrinterPort, portSettings)
        'Port.Open()

        ' Se crea y se abre el puerto de la impresora
        If m_iTipoImpresora = PrinterModels.ZebraPortatil Then
            portSettings.BasicSettings.BaudRate = BaudRates.CBR_19200
        Else
            portSettings.BasicSettings.BaudRate = BaudRates.CBR_9600
        End If
        portSettings.BasicSettings.ByteSize = 8
        portSettings.BasicSettings.Parity = Parity.none
        portSettings.BasicSettings.StopBits = StopBits.one
        Port = New Port(Settings.PrinterPort, portSettings)
        Port.Open()
    End Sub

    Private Sub ClosePort()
        Port.Close()
        Port = Nothing
    End Sub

    Private Sub AppendLine()
        sbDoc.Append(vbCrLf)
    End Sub

    Private Sub AppendLines(ByVal nCount As Integer)
        ' Se construye el encabezado
        For I As Integer = 1 To nCount
            AppendLine()
        Next
    End Sub

    Private Sub AppendLine(ByVal sLine As String)
        If Settings.PrinterModel = PrinterModels.SyscanZFP3Friction Then
            sbDoc.Append(Space(8) & sLine & vbCrLf)
        Else
            sbDoc.Append(sLine & vbCrLf)
        End If
    End Sub

    Private Sub InitPage()
        sbDoc = New StringBuilder
    End Sub

    Private Sub EndPage()
        sbDoc.Append(vbFormFeed)
    End Sub

    Private Sub AppendLine(ByVal sLine As String, ByVal ParamArray args() As Object)
        If Settings.PrinterModel = PrinterModels.SyscanZFP3Friction Then
            sbDoc.AppendFormat(Nothing, Space(8) & sLine & vbCrLf, args)
        Else
            sbDoc.AppendFormat(Nothing, sLine & vbCrLf, args)
        End If
    End Sub

    Private Sub InitPrinter()
        ' Se envia cadena de inicialización
        'Dim sInitData As Byte() = {27, 91, 75, 4, 0, 0, 3, 0, 80}
        ' port.Output = sInitData
  

        If m_iTipoImpresora <> PrinterModels.ZebraPortatil Then
            Dim sInitPagina() As Byte = {27, 91, 75, 4, 0, 0, 3, 0, 80, 18, 27, 48, 15, 27, 50, 27, 65, 2}
            Port.Output = sInitPagina
            'Dim sInitPagina() As Byte = {27, 91, 75, 4, 0, 0, 3, 0, 80, 18, 27, 48, 15, 27, 50, 27, 65, 2}
            'Port.Output = sInitPagina
        End If
    End Sub

    Private Sub PrintData(ByVal sData As String)
        Port.Output = Encoding.Default.GetBytes(sData)
    End Sub

    Public Function Print(ByVal doc As PrinterDocument) As Integer
        If m_iTipoImpresora = PrinterModels.ZebraPortatil Then
            Return PrintPortatil(doc)
        Else
            Return Sysncan(doc)
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
    
    ' TIPO FUNCION : METODO DE LA CLASE
    ' DESCRIPCION: FUNCION PARA REEMPLAZAR LOS TAGS DE LAS PLANTILLAS POR EL VALOR DE LAS VARIABLES
    Private Function ReemplazarVariables(ByVal sLinea As String, ByVal doc As PrinterDocument, ByRef Pagina As Integer, ByRef Total As Integer) As String
        'Dim segunda, Tercera As String
        Dim codProducto As Object()
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
                Case "ENTIDAD"
                    sLinea = sLinea.Replace("[ENTIDAD]", doc.Cliente.Entidad)
                Case "SUB-DIVISION"
                    sLinea = sLinea.Replace("[SUB-DIVISION]", doc.Cliente.SubDivision)
                Case "TIPO_PAGO"
                    sLinea = sLinea.Replace("[TIPO_PAGO]", doc.Cliente.TipoPago)
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
                    ' sLinea = sLinea.Replace("[ORDENCOMPRA]", doc.OrdenCompra)
                Case "PEDIDO"
                    sLinea = sLinea.Replace("[PEDIDO]", doc.NumPedido)
                Case "CODIGOBARRAS"
                    sLinea = sLinea.Replace("[CODIGOBARRAS]", doc.CodigoBarras)
                Case "DETALLEFACTURA"
                    Dim num As Integer = 0
                    Dim str1 As String = ""
                    Dim str2 As String = ""
                    Dim str3 As String = sLinea

                    Me.m_subtotal = 0
                    Dim tInicioReglonY As Double = Me.TInicioReglonY
                    num = 0
                    Do
                        If (doc.Items.Count - 1 >= num + Pagina * 5) Then
                            Me.m_subtotal = Me.m_subtotal + Convert.ToDouble(doc.Items(num + Pagina * 5).PrecioTotal)

                            'DATASCAN 20170912 
                            'ANTES:
                            ''''DATASCAN 20170221
                            ''''If doc.Items(num + Pagina * 5).InfoAdicional.Trim().Length > 0 Then
                            'AHORA:
                            If doc.Items(num + Pagina * 5).InfoAdicional.Trim().Length > 0 _
                            And (doc.TipoDocumento <> "FCO" And doc.TipoDocumento <> "FAC") Then
                                If doc.Items(num + Pagina * 5).InfoAdicional.Split(CChar(",")).Length > 0 Then
                                    doc.Items(num + Pagina * 5).Cantidad = doc.Items(num + Pagina * 5).InfoAdicional.Split(CChar(",")).Length
                                    doc.Items(num + Pagina * 5).CantiUnit = doc.Items(num + Pagina * 5).InfoAdicional.Split(CChar(",")).Length
                                End If
                            End If
                            'FIN DATASCAN

                            If (String.Compare(doc.Items(num + Pagina * 5).CodProducto.Substring(0, 1), "0", False) = 0) Then
                                If (doc.Items(num + Pagina * 5).Descripcion.Length > 17) Then
                                    doc.Items(num + Pagina * 5).Descripcion = doc.Items(num + Pagina * 5).Descripcion.Substring(0, 17)
                                End If
                                Dim item As PrinterDocument.DocumentItem = doc.Items(num + Pagina * 5)
                                Dim strArrays() As String = {doc.Items(num + Pagina * 5).Descripcion.ToUpper(), "(", CStr(doc.Items(num + Pagina * 5).CantiUnit), "x", doc.Items(num + Pagina * 5).Capacidad, ")"}
                                item.Descripcion = String.Concat(strArrays)
                            ElseIf (doc.Items(num + Pagina * 5).Descripcion.Length > 23) Then
                                doc.Items(num + Pagina * 5).Descripcion = doc.Items(num + Pagina * 5).Descripcion.Substring(0, 23)
                            End If

                            str1 = String.Concat(Me.TInicioReglonX.ToString(), " ", tInicioReglonY.ToString())
                            tInicioReglonY = tInicioReglonY + 20
                            If (Not doc.Items(num + Pagina * 5).UsaPrecios) Then
                                codProducto = New Object() {doc.Items(num + Pagina * 5).CodProducto, doc.Items(num + Pagina * 5).Descripcion, doc.Items(num + Pagina * 5).Cantidad, doc.Items(num + Pagina * 5).UnidadMedida, "0", "0"}
                                'DATASCAN 20170915
                                'ANTES:
                                'str2 = String.Format("{0,-8}{1,-23}{2,9:#,##0}{3,4}{4,9:#,##0}{5,11:#,##0}", codProducto)
                                'AHORA:
                                str2 = String.Format("{0,-8}{1,-23}{2,9}{3,4}{4,9:#,##0}{5,11:#,##0}", codProducto)
                                'FIN DATASCAN 20170915                                
                            Else
                                codProducto = New Object() {doc.Items(num + Pagina * 5).CodProducto, doc.Items(num + Pagina * 5).Descripcion, doc.Items(num + Pagina * 5).Cantidad, doc.Items(num + Pagina * 5).UnidadMedida, doc.Items(num + Pagina * 5).PrecioUnitario, doc.Items(num + Pagina * 5).PrecioTotal}
                                'DATASCAN 20170915
                                'ANTES:
                                'str2 = String.Format("{0,-8}{1,-23}{2,9:#,##0}{3,4}{4,9:#,##0}{5,11:#,##0}", codProducto)
                                'AHORA:
                                str2 = String.Format("{0,-8}{1,-23}{2,9}{3,4}{4,9:#,##0}{5,11:#,##0}", codProducto)
                                'FIN DATASCAN 20170915   
                            End If
                            If (num <> 0) Then
                                Me.AppendLine(str3.Replace("[DETALLEFACTURA]", String.Concat(str1, " ", str2)))
                            Else
                                sLinea = sLinea.Replace("[DETALLEFACTURA]", String.Concat(str1, " ", str2))
                            End If
                            If (Not Me.IsEmptyOrNull(doc.Items(num + Pagina * 5).InfoAdicional)) Then
                                Me.m_sObservaciones = String.Concat(Me.m_sObservaciones, doc.Items(num + Pagina * 5).InfoAdicional, ";")
                                Dim str4 As String = ""
                                Dim str5 As String = ""
                                Dim str6 As String = ""
                                Dim str7 As String = ""
                                Dim str8 As String = ""
                                Dim str9 As String = ""
                                Dim str10 As String = ""
                                Dim str11 As String = ""
                                Dim str12 As String = ""
                                Dim str13 As String = ""
                                Dim str14 As String = ""
                                If (Me.m_sObservaciones.Length <= 63) Then
                                    str1 = String.Concat(Me.TInicioReglonX.ToString(), " ", tInicioReglonY.ToString())
                                    tInicioReglonY = tInicioReglonY + 20
                                    Me.AppendLine(str3.Replace("[DETALLEFACTURA]", String.Concat(str1, " ", Me.m_sObservaciones.ToString())))
                                    str4 = ""
                                Else
                                    str1 = String.Concat(Me.TInicioReglonX.ToString(), " ", tInicioReglonY.ToString())
                                    tInicioReglonY = tInicioReglonY + 20
                                    Me.AppendLine(str3.Replace("[DETALLEFACTURA]", String.Concat(str1, " ", Me.m_sObservaciones.Substring(0, 63).ToString())))
                                    str4 = Me.m_sObservaciones.Substring(63, Me.m_sObservaciones.Length - 63)
                                End If
                                If (str4.Length > 0) Then
                                    str1 = String.Concat(Me.TInicioReglonX.ToString(), " ", tInicioReglonY.ToString())
                                    tInicioReglonY = tInicioReglonY + 20
                                    If (str4.Length <= 63) Then
                                        Me.AppendLine(str3.Replace("[DETALLEFACTURA]", String.Concat(str1, " ", str4)))
                                        str5 = ""
                                    Else
                                        Me.AppendLine(str3.Replace("[DETALLEFACTURA]", String.Concat(str1, " ", str4.Substring(0, 63).ToString())))
                                        str5 = str4.Substring(63, str4.Length - 63)
                                    End If
                                End If
                                If (str5.Length > 0) Then
                                    str1 = String.Concat(Me.TInicioReglonX.ToString(), " ", tInicioReglonY.ToString())
                                    tInicioReglonY = tInicioReglonY + 20
                                    If (str5.Length <= 63) Then
                                        Me.AppendLine(str3.Replace("[DETALLEFACTURA]", String.Concat(str1, " ", str5)))
                                        str6 = ""
                                    Else
                                        Me.AppendLine(str3.Replace("[DETALLEFACTURA]", String.Concat(str1, " ", str5.Substring(0, 63))))
                                        str6 = str5.Substring(63, str5.Length - 63)
                                    End If
                                End If
                                If (str6.Length > 0) Then
                                    str1 = String.Concat(Me.TInicioReglonX.ToString(), " ", tInicioReglonY.ToString())
                                    tInicioReglonY = tInicioReglonY + 20
                                    If (str6.Length <= 63) Then
                                        Me.AppendLine(str3.Replace("[DETALLEFACTURA]", String.Concat(str1, " ", str6)))
                                        str7 = ""
                                    Else
                                        Me.AppendLine(str3.Replace("[DETALLEFACTURA]", String.Concat(str1, " ", str6.Substring(0, 63))))
                                        str7 = str6.Substring(63, str6.Length - 63)
                                    End If
                                End If
                                If (str7.Length > 0) Then
                                    str1 = String.Concat(Me.TInicioReglonX.ToString(), " ", tInicioReglonY.ToString())
                                    tInicioReglonY = tInicioReglonY + 20
                                    If (str7.Length <= 63) Then
                                        Me.AppendLine(str3.Replace("[DETALLEFACTURA]", String.Concat(str1, " ", str7)))
                                        str8 = ""
                                    Else
                                        Me.AppendLine(str3.Replace("[DETALLEFACTURA]", String.Concat(str1, " ", str7.Substring(0, 63))))
                                        str8 = str7.Substring(63, str7.Length - 63)
                                    End If
                                End If
                                If (str8.Length > 0) Then
                                    str1 = String.Concat(Me.TInicioReglonX.ToString(), " ", tInicioReglonY.ToString())
                                    tInicioReglonY = tInicioReglonY + 20
                                    If (str8.Length <= 63) Then
                                        Me.AppendLine(str3.Replace("[DETALLEFACTURA]", String.Concat(str1, " ", str8)))
                                        str9 = ""

                                    Else
                                        Me.AppendLine(str3.Replace("[DETALLEFACTURA]", String.Concat(str1, " ", str8.Substring(0, 63))))
                                        str9 = str8.Substring(63, str8.Length - 63)
                                    End If

                                End If
                                If (str9.Length > 0) Then
                                    str1 = String.Concat(Me.TInicioReglonX.ToString(), " ", tInicioReglonY.ToString())
                                    tInicioReglonY = tInicioReglonY + 20
                                    If (str9.Length <= 63) Then
                                        Me.AppendLine(str3.Replace("[DETALLEFACTURA]", String.Concat(str1, " ", str9)))
                                        str10 = ""
                                    Else
                                        Me.AppendLine(str3.Replace("[DETALLEFACTURA]", String.Concat(str1, " ", str9.Substring(0, 63))))
                                        str10 = str9.Substring(63, str9.Length - 63)



                                    End If
                                End If
                                If (str10.Length > 0) Then
                                    str1 = String.Concat(Me.TInicioReglonX.ToString(), " ", tInicioReglonY.ToString())
                                    tInicioReglonY = tInicioReglonY + 20
                                    If (str10.Length <= 63) Then
                                        Me.AppendLine(str3.Replace("[DETALLEFACTURA]", String.Concat(str1, " ", str10)))
                                        str11 = ""





                                    Else
                                        Me.AppendLine(str3.Replace("[DETALLEFACTURA]", String.Concat(str1, " ", str10.Substring(0, 63))))
                                        str11 = str10.Substring(63, str10.Length - 63)
                                    End If


                                End If
                                If (str11.Length > 0) Then
                                    str1 = String.Concat(Me.TInicioReglonX.ToString(), " ", tInicioReglonY.ToString())
                                    tInicioReglonY = tInicioReglonY + 20
                                    If (str11.Length <= 63) Then
                                        Me.AppendLine(str3.Replace("[DETALLEFACTURA]", String.Concat(str1, " ", str11)))
                                        str12 = ""



                                    Else
                                        Me.AppendLine(str3.Replace("[DETALLEFACTURA]", String.Concat(str1, " ", str11.Substring(0, 63))))
                                        str12 = str11.Substring(63, str11.Length - 63)
                                    End If
                                End If
                                If (str12.Length > 0) Then
                                    str1 = String.Concat(Me.TInicioReglonX.ToString(), " ", tInicioReglonY.ToString())
                                    tInicioReglonY = tInicioReglonY + 20
                                    If (str12.Length <= 63) Then
                                        Me.AppendLine(str3.Replace("[DETALLEFACTURA]", String.Concat(str1, " ", str12)))
                                        str13 = ""



                                    Else
                                        Me.AppendLine(str3.Replace("[DETALLEFACTURA]", String.Concat(str1, " ", str12.Substring(0, 63))))
                                        str13 = str12.Substring(63, str12.Length - 63)

                                    End If
                                End If
                                If (str13.Length > 0) Then
                                    str1 = String.Concat(Me.TInicioReglonX.ToString(), " ", tInicioReglonY.ToString())
                                    tInicioReglonY = tInicioReglonY + 20
                                    If (str13.Length <= 63) Then
                                        Me.AppendLine(str3.Replace("[DETALLEFACTURA]", String.Concat(str1, " ", str13)))
                                        str14 = ""



                                    Else
                                        Me.AppendLine(str3.Replace("[DETALLEFACTURA]", String.Concat(str1, " ", str13.Substring(0, 63))))
                                        str14 = str13.Substring(63, str13.Length - 63)
                                    End If
                                End If
                                If (str14.Length > 0) Then
                                    str1 = String.Concat(Me.TInicioReglonX.ToString(), " ", tInicioReglonY.ToString())
                                    tInicioReglonY = tInicioReglonY + 20
                                    If (str14.Length <= 63) Then
                                        Me.AppendLine(str3.Replace("[DETALLEFACTURA]", String.Concat(str1, " ", str14)))
                                        str14 = ""



                                    Else
                                        Me.AppendLine(str3.Replace("[DETALLEFACTURA]", String.Concat(str1, " ", str14.Substring(0, 63))))
                                        str14 = ""
                                    End If
                                End If
                                Me.m_sObservaciones = ""
                                tInicioReglonY = tInicioReglonY + 20


                            End If
                        End If
                        num = num + 1
                    Loop While num <= 4
                Case "OBSERVACIONES"
                    'If m_sObservaciones.Length > 63 Then
                    '    sLinea = sLinea.Replace("[OBSERVACIONES]", doc.ObservacionGeneral & " " & m_sObservaciones.Substring(0, 63))
                    '    segunda = ""
                    'Else
                    '    sLinea = sLinea.Replace("[OBSERVACIONES]", doc.ObservacionGeneral & " " & m_sObservaciones)
                    'End If

                    'DATASCAN 20170525
                    'ANTES:
                    'sLinea = sLinea.Replace("[OBSERVACIONES]", "")
                    'AHORA:
                    If doc.TipoDocumento = "RECOLECCION" Then
                        sLinea = sLinea.Replace("[OBSERVACIONES]", LeerLineaTexto(1, "\Application\DatosRecoleccion.txt"))
                    Else
                        sLinea = sLinea.Replace("[OBSERVACIONES]", "")
                    End If
                    'FIN
                Case "OBSERVACIONES1"
                    'If m_sObservaciones.Length > 63 Then
                    '    segunda = m_sObservaciones.Substring(63, m_sObservaciones.Length - 63)
                    '    If segunda.Length > 63 Then
                    '        sLinea = sLinea.Replace("[OBSERVACIONES1]", segunda.Substring(0, 63))
                    '    Else
                    '        sLinea = sLinea.Replace("[OBSERVACIONES1]", segunda)
                    '    End If
                    'Else
                    '    sLinea = sLinea.Replace("[OBSERVACIONES1]", "")
                    'End If

                    'DATASCAN 20170525
                    'ANTES:
                    'sLinea = sLinea.Replace("[OBSERVACIONES1]", "")
                    'AHORA:
                    If doc.TipoDocumento = "RECOLECCION" Then
                        sLinea = sLinea.Replace("[OBSERVACIONES1]", LeerLineaTexto(2, "\Application\DatosRecoleccion.txt"))
                    Else
                        sLinea = sLinea.Replace("[OBSERVACIONES1]", "")
                    End If
                    'FIN

                Case "OBSERVACIONES2"
                    'If m_sObservaciones.Length > 63 Then
                    '    segunda = m_sObservaciones.Substring(63, m_sObservaciones.Length - 63)
                    '    If segunda.Length > 63 Then
                    '        Tercera = segunda.Substring(63, segunda.Length - 63)
                    '        sLinea = sLinea.Replace("[OBSERVACIONES2]", Tercera)
                    '    Else
                    '        sLinea = sLinea.Replace("[OBSERVACIONES2]", "")
                    '    End If
                    'Else
                    '    sLinea = sLinea.Replace("[OBSERVACIONES2]", "")
                    'End If
                    ''  sLinea = sLinea.Replace("[OBSERVACIONES2]", m_sObservaciones)                

                    'DATASCAN 20170525
                    'ANTES:
                    'sLinea = sLinea.Replace("[OBSERVACIONES2]", "")
                    'AHORA:
                    If doc.TipoDocumento = "RECOLECCION" Then
                        sLinea = sLinea.Replace("[OBSERVACIONES2]", LeerLineaTexto(3, "\Application\DatosRecoleccion.txt"))
                    Else
                        sLinea = sLinea.Replace("[OBSERVACIONES2]", "")
                    End If
                    'FIN
                Case "SUBTOTAL"
                    If doc.MostarTotales Then
                        If Pagina = (Total - 1) Then
                            sLinea = sLinea.Replace("[SUBTOTAL]", String.Format("{0:#,##0.00}", doc.Subtotal))
                        Else
                            sLinea = sLinea.Replace("[SUBTOTAL]", String.Format("{0:#,##0.00}", m_subtotal))
                        End If
                    Else
                        sLinea = sLinea.Replace("[SUBTOTAL]", "")
                    End If
                Case "IVA"
                    If doc.MostarTotales Then
                        If Pagina = (Total - 1) Then
                            sLinea = sLinea.Replace("[IVA]", String.Format("{0:#,##0.00}", doc.TotalIVA))
                        Else
                            sLinea = sLinea.Replace("[IVA]", "")
                        End If
                    Else
                        sLinea = sLinea.Replace("[IVA]", "")
                    End If
                Case "TOTAL"
                    If doc.MostarTotales Then
                        If Pagina = (Total - 1) Then
                            sLinea = sLinea.Replace("[TOTAL]", String.Format("{0:#,##0.00}", doc.Total))
                        Else
                            sLinea = sLinea.Replace("[TOTAL]", "")
                        End If
                    Else
                        sLinea = sLinea.Replace("[TOTAL]", "")
                    End If
                Case "RESOLUCION"
                    If doc.Resolucion IsNot Nothing Then
                        'DATASCAN 20170217
                        'ANTES:
                        'sLinea = sLinea.Replace("[RESOLUCION]", String.Format("RESOLUCION DE FACTURACION DIAN RESOL. {0} DEL {1:dd/MM/yyyy}  FACTURA DESDE {2} ", doc.Resolucion.Numero, doc.Resolucion.Fecha, doc.Resolucion.RangoIni)
                        'AHORA:
                        Dim sResolIni As String = Convert.ToInt32(doc.Resolucion.RangoIni.Split(CChar("-"))(0)) & "-" & Convert.ToInt32(doc.Resolucion.RangoIni.Split(CChar("-"))(1))
                        Dim sResolFin As String = Convert.ToInt32(doc.Resolucion.RangoFin.Split(CChar("-"))(0)) & "-" & Convert.ToInt32(doc.Resolucion.RangoFin.Split(CChar("-"))(1))
                        sLinea = sLinea.Replace("[RESOLUCION]", String.Format("DIAN  RESOL. {0} DEL {1:dd/MM/yyyy}  FACTURA DESDE {2} HASTA {3} ", doc.Resolucion.Numero, doc.Resolucion.Fecha, sResolIni, sResolFin))
                        'FIN''''''''''''''''
                    Else
                        sLinea = sLinea.Replace("[RESOLUCION]", "")
                    End If
                Case "RESOLUCION2"
                    If doc.Resolucion IsNot Nothing Then
                        'DATASCAN 20170217
                        'ANTES:
                        'sLinea = sLinea.Replace("[RESOLUCION2]", String.Format("HASTA {0} ", doc.Resolucion.RangoFin))
                        'AHORA:                        
                        sLinea = sLinea.Replace("[RESOLUCION2]", "PAGOS: " + LeerLineaTexto(5, "\Application\DatosContribuyente.txt")) + " REPORTAR CONSIG A: PAGOS_CLIENTES@PRAXAIR.COM"
                        'FIN'''''''''''''''''''''''''''''
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
                        'If doc.Nombre.IndexOf("FACT") >= 0 Then
                    If doc.TipoDocumento = "FAC" Then
                        sLinea = sLinea.Replace("[A1]", "Esta factura de venta se asimila en todos sus efectos a letra de cambio(Art. 774 codigo comercio)")
                    Else
                        sLinea = sLinea.Replace("[A1]", "")
                    End If
                Case "A2"
                    If doc.TipoDocumento = "FAC" Then
                        'If doc.Nombre.IndexOf("FACT") >= 0 Then
                        sLinea = sLinea.Replace("[A2]", "y como tal se acepta por el comprador.")
                    Else
                        sLinea = sLinea.Replace("[A2]", "")
                    End If
                Case "L1"
                        'If doc.Nombre.IndexOf("FACT") >= 0 Then
                    If doc.TipoDocumento = "FAC" Then
                        'DATASCAN 20170217
                        'ANTES:
                        'sLinea = sLinea.Replace("[L1]", "AUTORETENEDORES RES.0052 DE JUL 16/1992")
                        'AHORA:
                        sLinea = sLinea.Replace("[L1]", LeerLineaTexto(1, "\Application\DatosContribuyente.txt"))
                        'FIN''''''''''''''''''
                    Else
                        sLinea = sLinea.Replace("[L1]", "")
                    End If
                Case "L2"
                    If doc.TipoDocumento = "FAC" Then
                        'If doc.Nombre.IndexOf("FACT") >= 0 Then
                        'DATASCAN 20170217
                        'ANTES:
                        'sLinea = sLinea.Replace("[L2]", "IVA REGIMEN COMUN CIIU 2429")
                        'AHORA:
                        sLinea = sLinea.Replace("[L2]", LeerLineaTexto(2, "\Application\DatosContribuyente.txt"))
                        'FIN''''''''''''''''''
                    Else
                        sLinea = sLinea.Replace("[L2]", "")
                    End If
                Case "L3"
                    If doc.TipoDocumento = "FAC" Then
                        'If doc.Nombre.IndexOf("FACT") >= 0 Then
                        'If doc.Nombre.IndexOf("FACT") >= 0 Then
                        'DATASCAN 20170217
                        'ANTES:
                        'sLinea = sLinea.Replace("[L3]", "ICA BOGOTA 3699 TARIFA 11.04 X MIL")
                        'AHORA:
                        sLinea = sLinea.Replace("[L3]", LeerLineaTexto(3, "\Application\DatosContribuyente.txt"))
                        'FIN''''''''''''''''''
                    Else
                        sLinea = sLinea.Replace("[L3]", "")
                    End If
                Case "L4"
                        'If doc.Nombre.IndexOf("FACT") >= 0 Then
                    If doc.TipoDocumento = "FAC" Then
                        'DATASCAN 20170217
                        'ANTES:
                        'sLinea = sLinea.Replace("[L4]", "SOMOS GRANDES CONTRIBUYENTES (RES 2509 DIC 03/93)")
                        'AHORA:
                        sLinea = sLinea.Replace("[L4]", LeerLineaTexto(4, "\Application\DatosContribuyente.txt"))
                        'FIN''''''''''''''''''
                    Else
                        sLinea = sLinea.Replace("[L4]", "")
                    End If
                Case "L5"
                        'If doc.Nombre.IndexOf("FACT") >= 0 Then
                    If doc.TipoDocumento = "FAC" Then
                        sLinea = sLinea.Replace("[L5]", "SOMOS RETENEDORES DE IVA")
                    Else
                        sLinea = sLinea.Replace("[L5]", "")
                    End If
                Case "L6"
                        'If doc.Nombre.IndexOf("FACT") >= 0 Then
                    If doc.TipoDocumento = "FAC" Then
                        sLinea = sLinea.Replace("[L6]", "AGENTE RETENEDOR DE IMPUESTOS SOBRE LAS VENTAS")
                    Else
                        sLinea = sLinea.Replace("[L6]", "")
                    End If
                Case "PAGINA"
                        sLinea = sLinea.Replace("[PAGINA]", "Pagina : " & Pagina + 1 & "/" & Total)
            End Select
        End If
        Return sLinea
    End Function

    Public Function LeerLineaTexto(ByVal num As Integer, ByVal path As String) As String
        Dim text As String = ""
        Dim rnk As StreamReader = New StreamReader(path) '"\Application\DatosContribuyente.txt"
        Dim x As Integer
        For x = 1 To num
            text = rnk.ReadLine()
            If text = Nothing Then
                rnk.Close()
            End If
        Next x
        rnk.Close()
        Return text
    End Function

    ' TIPO FUNCION : METODO DE LA CLASE
    ' DESCRIPCION: FUNCION PARA IMPRIMIR LOS TIQUETES
    '              ESTA FUNCION UTILIZA UNA PLANTILLA QUE CONTIENE LAS INSTRUCCIONES EPL
    Public Function PrintPortatil(ByVal doc As PrinterDocument) As Integer
        If doc.Tipo = TipoReporte.ControlEnvases Then
            Return PrintControlenvase(doc)
        ElseIf doc.Tipo = TipoReporte.DocumentosGenerados Then
            Return PrintDocumentoGenerado(doc)
        Else
            Return PrintFactutra(doc)
        End If
    End Function
    Private Function ObtenerValorControlEnvase(ByVal nombreTag As String, ByVal posicionTag As Integer, ByVal numeroIteracion As Integer, ByVal DetalleControlEnvase As List(Of Common.PrinterDocument.ControlEnvases)) As String
        If (posicionTag + (numeroIteracion * 14)) < DetalleControlEnvase.Count Then
            Select Case nombreTag.ToUpper

                Case "CODPRO"
                    Return DetalleControlEnvase(posicionTag + (numeroIteracion * 14)).CodProducto
                Case "DESCRIPCION"
                    Return DetalleControlEnvase(posicionTag + (numeroIteracion * 14)).Descripcion
                Case "CAP"
                    Return DetalleControlEnvase(posicionTag + (numeroIteracion * 14)).Capacidad
                Case "PE"
                    Return DetalleControlEnvase(posicionTag + (numeroIteracion * 14)).PE
                Case "SALLLE"
                    Return DetalleControlEnvase(posicionTag + (numeroIteracion * 14)).SalidaLLe
                Case "SALVAC"
                    Return DetalleControlEnvase(posicionTag + (numeroIteracion * 14)).SalidaVac
                Case "VENTA"
                    Return DetalleControlEnvase(posicionTag + (numeroIteracion * 14)).Ventas
                Case "ASIG"
                    Return DetalleControlEnvase(posicionTag + (numeroIteracion * 14)).Asignacion
                Case "RECOLEC"
                    Return DetalleControlEnvase(posicionTag + (numeroIteracion * 14)).Recolecion
                Case "VACENT"
                    Return DetalleControlEnvase(posicionTag + (numeroIteracion * 14)).VaciosEnt
                Case "RETLLEN"
                    Return DetalleControlEnvase(posicionTag + (numeroIteracion * 14)).RetornoLleno
                Case "RETVAC"
                    Return DetalleControlEnvase(posicionTag + (numeroIteracion * 14)).RetornoVac
            End Select
        Else
            Return String.Empty
        End If
    End Function
    Private Function ObtenerValorDocumentoGenerado(ByVal nombreTag As String, ByVal posicionTag As Integer, ByVal numeroIteracion As Integer, ByVal DetalleHojaruta As List(Of Common.PrinterDocument.DocumentosGenerados)) As String
        If (posicionTag + (numeroIteracion * numFilasImpresion)) < DetalleHojaruta.Count Then
            Select Case nombreTag.ToUpper
                Case "TIPO"
                    Return DetalleHojaruta(posicionTag + (numeroIteracion * numFilasImpresion)).Tipo
                Case "PREF"
                    Return DetalleHojaruta(posicionTag + (numeroIteracion * numFilasImpresion)).Prefijo
                Case "DOC"
                    Return DetalleHojaruta(posicionTag + (numeroIteracion * numFilasImpresion)).Documento
                Case "NOMBRE"
                    If DetalleHojaruta(posicionTag + (numeroIteracion * numFilasImpresion)).Nombre.Length > 36 Then
                        Return DetalleHojaruta(posicionTag + (numeroIteracion * numFilasImpresion)).Nombre.Substring(0, 36)
                    Else
                        Return DetalleHojaruta(posicionTag + (numeroIteracion * numFilasImpresion)).Nombre
                    End If

                Case "CLI"
                    Return DetalleHojaruta(posicionTag + (numeroIteracion * numFilasImpresion)).Cliente
                Case "CONT"
                    Return DetalleHojaruta(posicionTag + (numeroIteracion * numFilasImpresion)).Contado
                Case "CRE"
                    Return DetalleHojaruta(posicionTag + (numeroIteracion * numFilasImpresion)).Credito
                Case "EST"
                    Return DetalleHojaruta(posicionTag + (numeroIteracion * numFilasImpresion)).Estado
                Case "REIM"
                    Return DetalleHojaruta(posicionTag + (numeroIteracion * numFilasImpresion)).Reimpresion

            End Select

        Else
            Return String.Empty
        End If
    End Function
    Public Function PrintDocumentoGenerado(ByVal doc As PrinterDocument) As Integer
        'CARGO LA PLANTILLA
        ' Se agrega el encabezado del documento
        'CARGO LA PLANTILLA
        If Not File.Exists(Settings.EtiquetaDocumentoGenerado) Then
            Return -1
        End If
        Dim fArchivoFacturas As StreamReader
        Try
            Dim sLinea As String = ""


            'DATASCAN 20170913 ESTE BLOQUE SE TRASLADA ABAJO Y DESPUES DEL IF
            'Me.InitPage()
            'Me.AppendLine("! 0 200 200 1550 1")
            'Me.AppendLine("JOURNAL")
            'Me.AppendLine("CONTRAST 1")
            'Me.AppendLine("TONE 0")
            'Me.AppendLine("SPEED 2")
            'Me.AppendLine("PAGE-WIDTH 840")
            'Me.AppendLine("BAR-SENSE")
            'FIN DATASCAN 20170913

            Dim numeroHojasImpresion As Integer = (doc.DetalleDocumentoGenerado.Count \ numFilasImpresion)
            If (doc.DetalleDocumentoGenerado.Count \ numFilasImpresion) > 0 Then
                numeroHojasImpresion = numeroHojasImpresion + 1
            Else
                numeroHojasImpresion = 1
            End If

            For numeroIteracion As Integer = 0 To numeroHojasImpresion - 1
                'DATASCAN 20170913
                Me.InitPage()
                Me.AppendLine("! 0 200 200 1550 1")
                Me.AppendLine("JOURNAL")
                Me.AppendLine("CONTRAST 1")
                Me.AppendLine("TONE 0")
                Me.AppendLine("SPEED 2")
                Me.AppendLine("PAGE-WIDTH 840")
                Me.AppendLine("BAR-SENSE")
                'FIN DATASCAN 20170913

                fArchivoFacturas = New StreamReader(Settings.EtiquetaDocumentoGenerado)
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
                                Dim nombreTag As String = tagOriginal.Substring(8)

                                'validacion error mas de dos digitos
                                Dim posicionTag As Integer
                                If IsNumeric(tagOriginal.Substring(tagOriginal.Length - 3, 2)) = True Then
                                    nombreTag = nombreTag.Substring(0, nombreTag.Length - 3)
                                    posicionTag = CInt(tagOriginal.Substring(tagOriginal.Length - 3, 2))
                                Else
                                    nombreTag = nombreTag.Substring(0, nombreTag.Length - 2)
                                    posicionTag = CInt(tagOriginal.Substring(tagOriginal.Length - 2, 1))
                                End If

                                Dim valorRemplazar As String = Me.ObtenerValorDocumentoGenerado(nombreTag, posicionTag, numeroIteracion, doc.DetalleDocumentoGenerado)
                                sLinea = sLinea.Replace(tagOriginal, valorRemplazar)
                            Case "NOMBRE EMPRESA"
                                If CStrDBNull(Nucleo.RowParametros("CodigoEmpresa")) = "21" Then
                                    sLinea = sLinea.Replace("[NOMBRE EMPRESA]", "OXIGENOS DE COLOMBIA LTDA")
                                Else
                                    sLinea = sLinea.Replace("[NOMBRE EMPRESA]", "LIQUIDO CARBONICO COLOMBIANA S.A")
                                End If
                            Case "FECHA"
                                sLinea = sLinea.Replace("[FECHA]", Date.Now.ToString)
                            Case "SUCURSAL"
                                sLinea = sLinea.Replace("[SUCURSAL]", GestorNucleo.dsNucleo.Parametros(0).CodigoSucursal)
                            Case "PLACA"
                                sLinea = sLinea.Replace("[PLACA]", GestorNucleo.dsNucleo.Parametros(0).CodigoVehiculo)
                            Case "RUTA"
                                sLinea = sLinea.Replace("[RUTA]", GestorNucleo.dsNucleo.Parametros(0).RutaPrincipal)
                            Case "CHOFER"
                                sLinea = sLinea.Replace("[CHOFER]", GestorNucleo.dsNucleo.Parametros(0).NombreChofer)
                            Case "REMITOC"
                                sLinea = sLinea.Replace("[REMITOC]", GestorNucleo.dsNucleo.Parametros(0).MensajeChofer)
                            Case "PAGINA"
                                sLinea = sLinea.Replace("[PAGINA]", "Página : " & CStr(numeroIteracion + 1) & "/" & CStr(numeroHojasImpresion))
                            Case "KMINICIAL"
                                sLinea = sLinea.Replace("[KMINICIAL]", GestorNucleo.dsNucleo.Parametros(0).KilometrajeInicial)
                            Case "KMFINAL"
                                sLinea = sLinea.Replace("[KMFINAL]", GestorNucleo.dsNucleo.Parametros(0).KilometrajeFinal)
                            Case "KMTOTAL"
                                sLinea = sLinea.Replace("[KMTOTAL]", CStr(CDbl(GestorNucleo.dsNucleo.Parametros(0).KilometrajeFinal) - CDbl(GestorNucleo.dsNucleo.Parametros(0).KilometrajeInicial)))
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

                'DATASCAN 20170913
                Me.SendDataToPrinter()
                If sbDoc.ToString().Length() > 0 Then
                    sbDoc.Remove(0, sbDoc.ToString().Length())
                End If                
                'FIN DATASCAN 20170913
            Next
            'Me.SendDataToPrinter() 'DATASCAN 20170913 SE TRASLADA ESTA LINEA ANTES DEL NEXT
            Return 0
        Catch ex As Exception
            UIHandler.ShowAlert(ex.Message)
            Return -1
        Finally

        End Try

    End Function
    Public Function PrintControlenvase(ByVal doc As PrinterDocument) As Integer
        'CARGO LA PLANTILLA
        ' Se agrega el encabezado del documento
        'CARGO LA PLANTILLA
        If Not File.Exists(Settings.EtiquetaControlenvase) Then
            Return -1
        End If
        Dim fArchivoFacturas As StreamReader
        Try
            Dim sLinea As String = ""

            Me.InitPage()
            Me.AppendLine("! 0 200 200 1850 1")
            Me.AppendLine("JOURNAL")
            Me.AppendLine("CONTRAST 1")
            Me.AppendLine("TONE 0")
            Me.AppendLine("SPEED 2")
            Me.AppendLine("PAGE-WIDTH 840")
            Me.AppendLine("BAR-SENSE")

            Dim numeroHojasImpresion As Integer = (doc.DetalleControlenvases.Count \ 14)
            If (doc.DetalleControlenvases.Count \ 14) > 0 Then
                numeroHojasImpresion = numeroHojasImpresion + 1
            Else
                numeroHojasImpresion = 1
            End If

            For numeroIteracion As Integer = 0 To numeroHojasImpresion - 1
                fArchivoFacturas = New StreamReader(Settings.EtiquetaControlenvase)
                sLinea = fArchivoFacturas.ReadLine
                'Dim aux As Integer
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
                                Dim nombreTag As String = tagOriginal.Substring(8)

                                'validacion error mas de dos digitos
                                Dim posicionTag As Integer
                                If IsNumeric(tagOriginal.Substring(tagOriginal.Length - 3, 2)) = True Then
                                    nombreTag = nombreTag.Substring(0, nombreTag.Length - 3)
                                    posicionTag = CInt(tagOriginal.Substring(tagOriginal.Length - 3, 2))
                                Else
                                    nombreTag = nombreTag.Substring(0, nombreTag.Length - 2)
                                    posicionTag = CInt(tagOriginal.Substring(tagOriginal.Length - 2, 1))
                                End If


                                Dim valorRemplazar As String = Me.ObtenerValorControlEnvase(nombreTag, posicionTag, numeroIteracion, doc.DetalleControlenvases)
                                sLinea = sLinea.Replace(tagOriginal, valorRemplazar)
                            Case "NOMBRE EMPRESA"
                                If CStrDBNull(Nucleo.RowParametros("CodigoEmpresa")) = "21" Then
                                    sLinea = sLinea.Replace("[NOMBRE EMPRESA]", "OXIGENOS DE COLOMBIA LTDA")
                                Else
                                    sLinea = sLinea.Replace("[NOMBRE EMPRESA]", "LIQUIDO CARBONICO COLOMBIANA S.A")
                                End If
                            Case "FECHA"
                                sLinea = sLinea.Replace("[FECHA]", Date.Now.ToString)
                            Case "SUCURSAL"
                                sLinea = sLinea.Replace("[SUCURSAL]", GestorNucleo.dsNucleo.Parametros(0).CodigoSucursal)
                            Case "PLACA"
                                sLinea = sLinea.Replace("[PLACA]", GestorNucleo.dsNucleo.Parametros(0).CodigoVehiculo)
                            Case "RUTA"
                                sLinea = sLinea.Replace("[RUTA]", GestorNucleo.dsNucleo.Parametros(0).RutaPrincipal)
                            Case "CHOFER"
                                sLinea = sLinea.Replace("[CHOFER]", GestorNucleo.dsNucleo.Parametros(0).NombreChofer)
                            Case "PAGINA"
                                sLinea = sLinea.Replace("[PAGINA]", "Página : " & CStr(numeroIteracion + 1) & "/" & CStr(numeroHojasImpresion))
                            Case "KMINICIAL"
                                sLinea = sLinea.Replace("[KMINICIAL]", GestorNucleo.dsNucleo.Parametros(0).KilometrajeInicial)
                            Case "REMITOC"
                                sLinea = sLinea.Replace("[REMITOC]", GestorNucleo.dsNucleo.Parametros(0).MensajeChofer)
                            Case "KMFINAL"
                                sLinea = sLinea.Replace("[KMFINAL]", GestorNucleo.dsNucleo.Parametros(0).KilometrajeFinal)
                            Case "KMTOTAL"
                                sLinea = sLinea.Replace("[KMTOTAL]", CStr(CDbl(GestorNucleo.dsNucleo.Parametros(0).KilometrajeFinal) - CDbl(GestorNucleo.dsNucleo.Parametros(0).KilometrajeInicial)))
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
            Return 0
        Catch ex As Exception
            Return -1
            UIHandler.ShowAlert(ex.Message)
        Finally

        End Try

    End Function

    Public Function PrintFactutra(ByVal doc As PrinterDocument) As Integer
        Dim num As Integer
        Dim count As Integer = 0

        If (Not File.Exists(Globales.Settings.Etiqueta)) Then
            MessageBox.Show(String.Concat("No se encuentra el Formato: ", Globales.Settings.Etiqueta))
            Return -1
        End If
        Try
            Try
                Dim num1 As Double = 0
                Dim count1 As Integer = doc.Items.Count - 1
                Dim num2 As Integer = 0


                ''DATASCAN
                'ANTES: 20170208

                'Do
                '    If (Strings.Len(doc.Items(num2).InfoAdicional.ToString()) > 63) Then
                '        num1 = num1 + Math.Round(CDbl(Strings.Len(doc.Items(num2).InfoAdicional.ToString())) / 63, 0) / 2
                '    End If
                '    num2 = num2 + 1
                'Loop While num2 <= count1

                'Dim num3 As Integer = CInt((Math.Round(num1) + doc.Items.Count) / 5)

                'If ((CInt(Math.Round(num1)) + doc.Items.Count) Mod 5 > 0) Then
                '    num3 = num3 + 1
                'End If

                'AHORA:20170208

                For num2 = 0 To count1
                    If (Strings.Len(doc.Items(num2).InfoAdicional.ToString()) > 63) Then
                        num1 = num1 + Math.Round(CDbl(Strings.Len(doc.Items(num2).InfoAdicional.ToString())) / 63, 0) / 2
                    End If
                Next

                'VALIDA SI EL RESULTADO ES UN DECIMAL
                Dim num3 As Integer = CInt(Math.Ceiling((Math.Round(num1) + doc.Items.Count) / 5))
                'FIN CAMBIOS 20170208

                Dim num4 As Integer = num3 - 1
                Dim num5 As Integer = 0

                Do
                    If (count > 0 AndAlso doc.ListNoCopias.Count < count) Then
                        count = count - doc.ListNoCopias.Count
                    End If

                    Dim streamReader As System.IO.StreamReader = New System.IO.StreamReader(Globales.Settings.Etiqueta)
                    Dim str As String = ""
                    Me.InitPage()
                    str = streamReader.ReadLine()
                    While str IsNot Nothing
                        Me.AppendLine(Me.ReemplazarVariables(str, doc, num5, num3))
                        str = streamReader.ReadLine()
                    End While
                    Me.AppendLine("PRINT")
                    If (doc.ListNoCopias.Count <= 0) Then
                        Dim [integer] As Integer = CInt(Globales.Settings.NumeroEtiquetas)
                        For i As Integer = 1 To [integer]
                            Select Case i
                                Case 2
                                    Me.RemplazarTexto("ORIGINAL", "PRIMERA COPIA")
                                    Exit Select
                                Case 3
                                    Me.RemplazarTexto("PRIMERA COPIA", "SEGUNDA COPIA")
                                    Exit Select
                                Case 4
                                    Me.RemplazarTexto("SEGUNDA COPIA", "TERCERA COPIA")
                                    Exit Select
                                Case 5
                                    Me.RemplazarTexto("TERCERA COPIA", "CUARTA COPIA")
                                    Exit Select
                            End Select
                            Me.SendDataToPrinter()
                            count = count + 1
                            While Not UIHandler.Confirm(String.Concat("¿La copia N0. ", i.ToString(), " del documento fue impreso correctamente?"), "Impresión Correcta?")
                                count = count + 1
                                Me.SendDataToPrinter()
                            End While
                        Next

                    Else
                        Dim count2 As Integer = doc.ListNoCopias.Count - 1
                        For j As Integer = 0 To count2
                            If (j <> 0) Then
                                Me.RemplazarTexto(doc.ListNoCopias(j - 1).Descripcion.ToString(), doc.ListNoCopias(j).Descripcion.ToString())
                            Else
                                Me.RemplazarTexto("ORIGINAL", doc.ListNoCopias(j).Descripcion.ToString())
                            End If
                            Me.SendDataToPrinter()
                            count = count + 1
                            While Not UIHandler.Confirm(String.Concat("¿La copia N0. ", (j + 1).ToString(), " del documento fue impreso correctamente?"), "Impresión Correcta?")
                                count = count + 1
                                Me.SendDataToPrinter()
                            End While
                        Next

                    End If
                    streamReader.Close()
                    num5 = num5 + 1
                Loop While num5 <= num4


                num = count
            Catch exception As System.Exception
                ProjectData.SetProjectError(exception)
                UIHandler.ShowAlert(exception.Message)
                num = -1
                Return num
                ProjectData.ClearProjectError()
            End Try
        Finally

        End Try
        Return num
    End Function

    'Public Function PrintFactutra(ByVal doc As PrinterDocument) As Integer
    '    Dim Impresiones As Integer = 0
    '    'CARGO LA PLANTILLA
    '    If Not File.Exists(Settings.Etiqueta) Then            
    '        MessageBox.Show(String.Concat("No se encuentra el Formato: ", Settings.Etiqueta))
    '        Return -1
    '    End If
    '    ' Dim fArchivoFacturas As New StreamReader(Settings.Etiqueta)
    '    Dim fArchivoFacturas As StreamReader
    '    Try

    '        Dim C As Integer
    '        Dim j As Integer

    '        C = doc.Items.Count \ 9

    '        If (doc.Items.Count Mod 9) > 0 Then
    '            C = C + 1
    '        End If

    '        For j = 0 To C - 1
    '            If Impresiones > 0 Then
    '                If (doc.ListNoCopias.Count) < Impresiones Then
    '                    Impresiones = Impresiones - (doc.ListNoCopias.Count)
    '                End If
    '            End If
    '            fArchivoFacturas = New StreamReader(Settings.Etiqueta)
    '            Dim sLineaLeer As String = ""
    '            Me.InitPage()
    '            sLineaLeer = fArchivoFacturas.ReadLine
    '            While Not sLineaLeer Is Nothing
    '                'REEMPLAZO LOS TAGS DE LA PLANTILLA POR LOS VALORES
    '                Me.AppendLine(Me.ReemplazarVariables(sLineaLeer, doc, j, C))
    '                sLineaLeer = fArchivoFacturas.ReadLine
    '            End While
    '            'CALCULO EL TAMAÑO DEL PAPEL
    '            'EL TAMAÑO ES CONSTANTE

    '            Me.AppendLine("PRINT")
    '            'Me.EndPage()
    '            'ENVIO LA IMPRESION
    '            If doc.ListNoCopias.Count > 0 Then
    '                For i As Integer = 0 To doc.ListNoCopias.Count - 1
    '                    If i = 0 Then
    '                        Me.RemplazarTexto("ORIGINAL", doc.ListNoCopias(i).Descripcion.ToString)
    '                    Else
    '                        Me.RemplazarTexto(doc.ListNoCopias(i - 1).Descripcion.ToString, doc.ListNoCopias(i).Descripcion.ToString)
    '                    End If

    '                    Me.SendDataToPrinter()
    '                    Impresiones += 1
    '                    While Not UIHandler.Confirm("¿La copia N0. " + (i + 1).ToString + " del documento fue impreso correctamente?", "Impresión Correcta?")
    '                        Impresiones += 1
    '                        Me.SendDataToPrinter()
    '                    End While
    '                Next
    '            Else
    '                For i As Integer = 1 To CInt(Settings.NumeroEtiquetas)
    '                    Select Case i
    '                        Case 2
    '                            Me.RemplazarTexto("ORIGINAL", "PRIMERA COPIA")
    '                        Case 3
    '                            Me.RemplazarTexto("PRIMERA COPIA", "SEGUNDA COPIA")
    '                        Case 4
    '                            Me.RemplazarTexto("SEGUNDA COPIA", "TERCERA COPIA")
    '                        Case 5
    '                            Me.RemplazarTexto("TERCERA COPIA", "CUARTA COPIA")

    '                    End Select
    '                    Me.SendDataToPrinter()
    '                    Impresiones += 1
    '                    While Not UIHandler.Confirm("¿La copia N0. " + i.ToString + " del documento fue impreso correctamente?", "Impresión Correcta?")
    '                        Impresiones += 1
    '                        Me.SendDataToPrinter()
    '                    End While
    '                Next
    '            End If
    '            fArchivoFacturas.Close()
    '        Next j

    '        Return Impresiones
    '    Catch
    '        Return -1
    '    Finally
    '        fArchivoFacturas.Close()
    '    End Try
    'End Function

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
    Public Sub RemplazarTexto(ByVal sTextoViejo As String, ByVal sNuevoTexto As String)
        sbDoc.Replace(sTextoViejo, sNuevoTexto)
    End Sub
    Private Function CalcularTamañoPapel(ByVal nNumLineas As Integer) As String
        Dim iNuevoTamano As Integer = CInt(((1000 * nNumLineas) / 940))
        iNuevoTamano = CInt((nNumLineas * TReglon) + 50)
        Return "! 0 200 200 " + iNuevoTamano.ToString + " 1"
    End Function
    Private Function Sysncan(ByVal doc As PrinterDocument) As Integer
        Try
            Dim I As Integer
            Dim Descripcion As String = ""
            ' Se arma y el documento envia el encabezado
            InitPage()
            AppendLines(7)
            AppendLine(Space(70) & doc.Nombre)
            AppendLine(Space(8) & doc.Cliente.Nombre)
            AppendLine(Space(18) & doc.Cliente.Direccion & "- " & doc.Cliente.Telefono)
            AppendLine(Space(8) & "{0,-60}{1,-19}{2,-6}{3,-6}{4,-7}{5,-6}{6,-6}{7,-6}", _
                doc.Cliente.Barrio, doc.Consecutivo, doc.FechaElaboracion.Day, _
                doc.FechaElaboracion.Month, doc.FechaElaboracion.Year, doc.FechaVencimiento.Day, _
                doc.FechaVencimiento.Month, doc.FechaVencimiento.Year)
            AppendLine(Space(8) & doc.Cliente.NIT)
            AppendLine(Space(8) & "{0,-58}{1,-13}{2,-33}{3}", _
                doc.Cliente.Entidad, doc.Cliente.Codigo, doc.TipoPago, doc.NumPedido)
            AppendLines(2)

            ' Se agregan los items
            Dim nItemLines As Integer = 0
            For I = 0 To doc.Items.Count - 1
                'se agrego para que coloque la capacidad y la cantidad de cilindros                
                Descripcion = doc.Items(I).Descripcion.ToUpper() & "(" & doc.Items(I).CantiUnit & "x" & doc.Items(I).Capacidad & ")"
                If doc.Items(I).UsaPrecios Then
                    AppendLine("{0,-8} {1,-54}{2,12:#,##0}  {3,-4}{4,17:#,##0.00}{5,23:#,##0.00}", _
                        doc.Items(I).CodProducto, Descripcion, doc.Items(I).Cantidad, _
                        doc.Items(I).UnidadMedida, doc.Items(I).PrecioUnitario, doc.Items(I).PrecioTotal)
                Else
                    AppendLine("{0,-8} {1,-54}{2,12:#,##0}  {3,-4}", _
                        doc.Items(I).CodProducto, Descripcion, _
                        doc.Items(I).Cantidad, doc.Items(I).UnidadMedida)
                End If
                If IsEmptyOrNull(doc.Items(I).InfoAdicional) Then
                    nItemLines += 1
                Else
                    AppendLine(Space(9) & doc.Items(I).InfoAdicional)
                    nItemLines += 2
                End If
            Next
            AppendLines(26 - nItemLines)

            ' Se agregan los totales
            If doc.MostarTotales Then
                AppendLine(Space(8) & "{0,30:#,##0.00}{1,45:#,##0.00}{2,38:#,##0.00}", _
                    doc.Subtotal, doc.TotalIVA, doc.Total)
                AppendLines(3)
            Else
                AppendLines(4)
            End If

            ' Se agrega información resolución factura
            If doc.Resolucion IsNot Nothing Then
                AppendLine("       *** SOMOS RETENEDORES DE IVA *** ")
                AppendLine("    *** RESOLUCION DE FACTURACION DIAN ***")
                AppendLine("    RESOL. {0} DEL {1:dd/MM/yyyy}", doc.Resolucion.Numero, doc.Resolucion.Fecha)
                'DATASCAN 20170217
                'ANTES:
                'AppendLine("    FACTURA DESDE {0} HASTA {1}", doc.Resolucion.RangoIni, doc.Resolucion.RangoFin)
                'AHORA:
                Dim sResolIni As String = Convert.ToInt32(doc.Resolucion.RangoIni.Split(CChar("-"))(0)) & "-" & Convert.ToInt32(doc.Resolucion.RangoIni.Split(CChar("-"))(1))
                Dim sResolFin As String = Convert.ToInt32(doc.Resolucion.RangoFin.Split(CChar("-"))(0)) & "-" & Convert.ToInt32(doc.Resolucion.RangoFin.Split(CChar("-"))(1))
                AppendLine("    FACTURA DESDE {0} HASTA {1}", sResolIni, sResolFin)
                'FIN'''''''''''''''''''''''''''''

                If doc.Resolucion.NoAutorizacion <> "" Then
                    AppendLine("    Entidad: " & doc.Resolucion.NoEntidad & " No. Autorizacion: " & doc.Resolucion.NoAutorizacion)
                End If
                AppendLines(3)
                AppendLine("La presente factura de venta se asimila en todos sus efectos legales a una letra de cambio Art. 774 C.Cio")
            Else
                AppendLines(8)
            End If
            AppendLines(5)

            ' se agrega el final del documento
            AppendLine(Space(12) & GestorNucleo.dsNucleo.Parametros(0).NombreChofer)
            AppendLine(Space(12) & GestorNucleo.dsNucleo.Parametros(0).RutaPrincipal)
            AppendLine(Space(12) & Now.ToString("HH:mm"))
            EndPage()
            SendDataToPrinter()
            Return 1
        Catch e As Exception
            Return -1
        End Try
    End Function


    Private Function SendDataToPrinter() As Boolean
        ' Se abre el puerto y se envia el documento
        Do
            Try
                OpenPort()
                Exit Do
            Catch
                If Settings.PrinterPortType = PrinterPortTypes.Bluetooth Then
                    If Not UIHandler.Confirm("No se pudo establecer comunicación con la impresora, por favor asegurese de que este encendida", "Volver a intentar?") Then
                        Return False
                    End If
                Else
                    UIHandler.ShowError("No se pudo abrir el puerto de comunicaciones especificado, revise la configuración y vuelva a intentar")
                    Return False
                End If
            End Try
        Loop

        InitPrinter()
        PrintData(sbDoc.ToString())
        ClosePort()
        Return True
    End Function

    Public Function Print(ByVal doc As PrinterReport) As Boolean
        InitPage()

        ' Se agrega el encabezado del documento
        AppendLines(2)
        AppendLine(Space(2) & "OXIGENOS DE COLOMBIA" & Space(30) & Now.ToString("yyyy/MM/dd HH:mm"))
        AppendLine()
        AppendLine(Space(2) & "Sucursal:  {0,-60} Placa: {1}", _
            GestorNucleo.dsNucleo.Parametros(0).NombreSucursal, _
            GestorNucleo.dsNucleo.Parametros(0).CodigoVehiculo)
        AppendLine(Space(2) & "Conductor: {0,-60} Ruta:  {1} ", _
            GestorNucleo.dsNucleo.Parametros(0).NombreChofer, _
            GestorNucleo.dsNucleo.Parametros(0).RutaPrincipal)

        ' Se agrega la linea de titulos
        AppendLines(2)
        AppendLine(Space(2) & doc.Titulo)
        AppendLine()
        Dim Item As KeyValuePair(Of String, PrinterReport.ColumnInfo)
        Dim col As PrinterReport.ColumnInfo
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
        AppendLine(sTitulos)
        AppendLine(sSepTitulo)

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
            AppendLine(sRegistro)
        Next

        ' Se agregan los totales
        AppendLine(sSepTotales)
        AppendLine(sTotales)
        EndPage()

        Return SendDataToPrinter()


    End Function

    Private Function IsEmptyOrNull(ByVal s As String) As Boolean
        Return ((s Is Nothing) OrElse (s.Trim() = ""))
    End Function

    Private Function AlignLeft(ByVal s As String, ByVal Len As Integer) As String
        s = s.Trim()
        If s.Length > Len Then
            s = s.Substring(0, Len - 1)
        End If
        Return s.PadRight(Len)
    End Function

    Private Function AlignRight(ByVal s As String, ByVal Len As Integer) As String
        s = s.Trim()
        If s.Length > Len Then
            s = s.Substring(0, Len - 1)
        End If
        Return s.PadLeft(Len)
    End Function


End Class
