Imports System.data
Imports DatascanCF.Symbol

Public Class BarcodeParser
    ' Definicion Campos Codigos barras
    Private m_sCodigoProducto As String
    Private m_sCodigoSucursal As String
    Private m_sCapacidad As String
    Private m_sSecuencial As String
    Private m_sPertenencia As String
    Private m_sNoDefinido As String
    Private m_sSerial As String
    Private m_sCilindro As String
    Private m_sCapacidadWithFormat As String

    Public Sub LoadData()
        ' Se llenan los datatables
        dsBarcode.CodigoBarras.Rows.Clear()
        dsBarcode.CodigoBarras.AddCodigoBarrasRow(TiposCodigo.Propios, "Definicion Codigos propios", CShort(DatascanCF.Symbol.BarcodeType.EAN128), 24, Nothing, Nothing, Nothing)
        dsBarcode.CodigoBarras.AddCodigoBarrasRow(TiposCodigo.SerialesAjenos, "Seriales Ajenos", CShort(DatascanCF.Symbol.BarcodeType.CODE39), 7, Nothing, Nothing, Nothing)
        'Campos Codigos de barra
        dsBarcode.CamposCodigoBarras.Rows.Clear()
        dsBarcode.CamposCodigoBarras.AddCamposCodigoBarrasRow(TiposCodigo.Propios, CodigosBarras.CodigoSucursal, 0, 2)
        dsBarcode.CamposCodigoBarras.AddCamposCodigoBarrasRow(TiposCodigo.Propios, CodigosBarras.CodigoProducto, 2, 10)
        dsBarcode.CamposCodigoBarras.AddCamposCodigoBarrasRow(TiposCodigo.Propios, CodigosBarras.Capacidad, 10, 16)
        dsBarcode.CamposCodigoBarras.AddCamposCodigoBarrasRow(TiposCodigo.Propios, CodigosBarras.Secuencial, 16, 23)
        dsBarcode.CamposCodigoBarras.AddCamposCodigoBarrasRow(TiposCodigo.Propios, CodigosBarras.Pertenencia, 23, 24)
        dsBarcode.CamposCodigoBarras.AddCamposCodigoBarrasRow(TiposCodigo.SerialesAjenos, CodigosBarras.Serial, 0, 7)
        dsBarcode.CamposCodigoBarras.AddCamposCodigoBarrasRow(TiposCodigo.SerialesAjenos, CodigosBarras.Cilindro, 0, 7)
    End Sub

    Public Sub InicializarValores()
        m_sCodigoProducto = Nothing
        m_sCodigoSucursal = Nothing
        m_sCapacidad = Nothing
        m_sSecuencial = Nothing
        m_sPertenencia = Nothing
        m_sNoDefinido = Nothing
        m_sSerial = Nothing
        m_sCilindro = Nothing
    End Sub


    Public Sub Parse(ByVal sCodigo As String, ByVal iSimbologia As Integer)
        ' Buscar el código de barras al cual corresponde
        Dim rows As DataRow()
        Dim row As DataRow
        Dim rowCampo As BarcodeDataSet.CamposCodigoBarrasRow
        Dim rowCodigo As BarcodeDataSet.CodigoBarrasRow
        Dim sAux As String = ""
        ' Se inicializan las variables
        InicializarValores()

        ' Se obtienen los datos del codigo
        rows = dsBarcode.CodigoBarras.Select("Longitud = " & sCodigo.Length & "AND Simbologia =" & iSimbologia)
        If rows.Length > 0 Then
            rowCodigo = CType(rows(0), BarcodeDataSet.CodigoBarrasRow)
            ' Se valida si el dato es numérico
            If Not rowCodigo.IsEsNumericoNull Then
                If CType(rowCodigo.EsNumerico, Boolean) Then
                    If IsNumeric(sCodigo) Then
                        NoDefinido = sCodigo
                        Exit Sub
                    End If
                End If
            End If
            'Se valida si el dato tiene prefijo
            If Not rowCodigo.IsPrefijoNull Then
                If Not sCodigo.StartsWith(rowCodigo.Prefijo) Then
                    NoDefinido = sCodigo
                    Exit Sub
                End If
            End If
            ' Se valida si el dato tiene sufijo
            If Not rowCodigo.IsSufijoNull Then
                If Not sCodigo.EndsWith(rowCodigo.Sufijo) Then
                    NoDefinido = sCodigo
                    Exit Sub
                End If
            End If
            ' Se buscan las filas con la configuración de campos y se extraen los datos
            rows = dsBarcode.CamposCodigoBarras.Select("IdCodigoBarras = " & rowCodigo.Id)
            If rows.Length > 0 Then
                sAux = sCodigo
                For Each row In rows
                    rowCampo = CType(row, BarcodeDataSet.CamposCodigoBarrasRow)

                    ' Se validan las posiciones del campo
                    If Not rowCampo.IsPosFinNull And Not rowCampo.IsPosIniNull Then
                        If Not rowCampo.PosFin - rowCampo.PosIni > sCodigo.Length - rowCampo.PosIni Then
                            sCodigo = sCodigo.Substring(rowCampo.PosIni, rowCampo.PosFin - rowCampo.PosIni)
                        Else
                            sCodigo = sCodigo.Substring(rowCampo.PosIni)
                        End If
                    Else
                        NoDefinido = sCodigo
                        Exit Sub
                    End If
                    Select Case rowCampo.IdCampo
                        Case CodigosBarras.CodigoProducto
                            CodigoProducto = sCodigo
                        Case CodigosBarras.CodigoSucursal
                            CodigoSucursal = sCodigo
                        Case CodigosBarras.Capacidad
                            Capacidad = sCodigo
                            CapacidadWithFormat = sCodigo
                        Case CodigosBarras.Secuencial
                            Secuencial = sCodigo
                        Case CodigosBarras.Pertenencia
                            Pertenencia = sCodigo
                        Case CodigosBarras.Serial
                            Serial = sCodigo
                    End Select
                    sCodigo = sAux
                Next
            Else
                NoDefinido = sCodigo
            End If
        Else
            NoDefinido = sCodigo
        End If
    End Sub

    Public Enum TiposCodigo As Short
        AjenosVacios = 1
        Propios = 2
        SerialesAjenos = 3
    End Enum

    Public Enum CodigosBarras As Short
        CodigoProducto = 1
        CodigoSucursal = 2
        Capacidad = 3
        Secuencial = 4
        Pertenencia = 5
        Serial = 6
        Cilindro = 7
    End Enum

    Public Property CodigoProducto() As String
        Get
            Return m_sCodigoProducto
        End Get
        Set(ByVal value As String)
            ' Se formatea la cadena 
            ' quitando los ceros a la izquierda
            'Try
            'm_sCodigoProducto = CStr(CLng(value))
            'Catch ex As Exception
            'm_sCodigoProducto = ""
            'End Try
            m_sCodigoProducto = value.Substring(1)
        End Set
    End Property

    Public Property CodigoSucursal() As String
        Get
            Return m_sCodigoSucursal
        End Get
        Set(ByVal value As String)
            m_sCodigoSucursal = value
        End Set
    End Property

    Public Property CapacidadWithFormat() As String
        Get
            Return m_sCapacidadWithFormat
        End Get
        Set(ByVal value As String)
            ' Se formatea la cadena
            ' quitando los ceros a la izquierda
            Try
                m_sCapacidadWithFormat = Format(CLng(value), "###,##0")
            Catch ex As Exception
                m_sCapacidadWithFormat = ""
            End Try
        End Set
    End Property

    Public Property Capacidad() As String
        Get
            Return m_sCapacidad
        End Get
        Set(ByVal value As String)
            Try
                m_sCapacidad = CStr(CLng(value))
            Catch ex As Exception
                m_sCapacidad = ""
            End Try
        End Set
    End Property

    Public Property Secuencial() As String
        Get
            Return m_sSecuencial
        End Get
        Set(ByVal value As String)
            m_sSecuencial = value
        End Set
    End Property

    Public Property Pertenencia() As String
        Get
            Return m_sPertenencia
        End Get
        Set(ByVal value As String)
            m_sPertenencia = value
        End Set
    End Property

    Public Property NoDefinido() As String
        Get
            Return m_sNoDefinido
        End Get
        Set(ByVal value As String)
            m_sNoDefinido = value
        End Set
    End Property

    Public Property Serial() As String
        Get
            Return m_sSerial
        End Get
        Set(ByVal value As String)
            m_sSerial = value
        End Set
    End Property

    Public Property Cilindro() As String
        Get
            Return m_sCilindro
        End Get
        Set(ByVal value As String)
            m_sCilindro = value
        End Set
    End Property
End Class


