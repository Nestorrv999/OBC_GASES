Imports DatascanCF.Symbol
Imports System.Data
Imports System.IO
Imports System.Data.SqlServerCe
Imports Oxigenos.Common


Public Class CargueCamionForm
    Implements IModuloPrograma

    Private WithEvents m_BarcodeReader As BarcodeReader
    Public Entregado As String = "E"
    Public NoEntregado As String = ""
    Public Agregar As Boolean = True
    Public Quitar As Boolean = False
    Private SecuencialAjeno As String = ""
    Private RowCliente As DataRow
    Private SerieCilindro As String

    Public Sub Run() Implements Common.IModuloPrograma.Run
        Dim dr As DataRow
        dr = Nucleo.RowParametros
        If dr IsNot Nothing Then
            If dr("DescargaRealizada") IsNot DBNull.Value Then
                If CBool(dr("DescargaRealizada")) = True Then
                    UIHandler.ShowError("Debe realizar la carga de datos!!")
                    Exit Sub
                End If
            End If
        End If

        ' Se hacen las validaciones para dar inicio al cargue
        If Nucleo.KilometrajeInicial <> " " And Nucleo.KilometrajeInicial <> "0" Then
            UIHandler.ShowError("La ruta ya se inicio!!")
            ' se muestra el resumen del camión
            ResumenCargaForm.Run()
        Else
            UIHandler.StartWait()
            UIHandler.ShowDialog(Me)
            Me.Dispose()
            UIHandler.EndWait()
        End If
    End Sub

    Private Sub CargueCamionForm_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        m_BarcodeReader.StopRead()
    End Sub

    Private Sub CargueCamionForm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If Not Nucleo.ProcessHotKeys(Me, e) Then
            If e.KeyCode = System.Windows.Forms.Keys.Escape Then
                mnuRegresar_Click(Me, Nothing)
            ElseIf e.KeyCode = System.Windows.Forms.Keys.T Then
                mnuTransmitirDatos_Click(Me, Nothing)
            ElseIf e.KeyCode = System.Windows.Forms.Keys.R Then
                mnuResumen_Click(Me, Nothing)
            End If
        End If
    End Sub

    Private Sub frmCargueCamion_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        UiHandler1.Parent = Me
        Productos.dsProductos = Me.dsProductos
        'TODO: Borrar al integrar el nucleo
        Barcode.LoadData()
        ' Se cargan en memoria los datatables
        Productos.LoadTipoProductos()
        Productos.LoadPertenencias()
        Productos.LoadCarga()
        Productos.LoadKardexCamion()
        ' Se inicializa el scanner
        DatascanCF.Symbol.BarcodeReader.InitReader()
        m_BarcodeReader = New BarcodeReader
        m_BarcodeReader.StartRead(Me)
        LimpiarControles()
        Me.lblNolecturas.Text = "0"
        UIHandler.EndWait()
    End Sub
    'Legion 30-09-2019
    Private Sub m_BarcodeReader_ScanComplete(ByVal e As DatascanCF.Symbol.ScanCompleteArgs) Handles m_BarcodeReader.ScanComplete
        Try
            Barcode.Parse(e.Text, e.Type)
            If Not Barcode.NoDefinido Is Nothing Then
                If e.Text.Length > 7 And e.Text.Length <= 14 Then
                    Dim indice As Integer
                    indice = e.Text.IndexOf("CO")
                    If (indice <> -1) Then
                        SerieCilindro = e.Text.Substring(indice + 2)
                        RowCliente = Productos.GetSecuencialAjenoCilindro(SerieCilindro)
                        If RowCliente Is Nothing Then
                            UIHandler.ShowAlert("Cilindro ajeno no encontrado!!")
                        Else
                            SecuencialAjeno = RowCliente("Secuencial").ToString
                            Me.txtSerial.Text = SecuencialAjeno
                            GoTo SecUnica
                        End If
                        
                    End If

                Else
                    UIHandler.ShowAlert("Código no Definido!!")
                End If
            ElseIf Not Barcode.CodigoProducto Is Nothing Then
                If pnLecturaAjenos.Visible Then
                    UIHandler.ShowError("Código no válido!!")
                    Exit Sub
                End If
                MostrarInformacionCilindrosLlenos(Barcode.CodigoProducto)
            ElseIf Not Barcode.Serial Is Nothing Then
                SecuencialAjeno = Barcode.Serial
                ' Lectura de un ajeno lleno
                If pnLecturaAjenos.Visible Then
                    Me.txtSerial.Text = Barcode.Serial
SecUnica:
                    ' Se busca que el secuencial exista en la tabla de cilindroscliente
                    RowCliente = Productos.GetSecuencialAjenoVacio(SecuencialAjeno)
                    If RowCliente Is Nothing Then
                        UIHandler.ShowError("Secuencial no esta registrado para el cargue!!")
                        Me.txtSerial.Text = ""
                        Me.txtSerial.Focus()
                        Exit Sub
                    End If
                    ValidarDatosLeidos()
                Else
                    ' Lectura de un ajeno vacío
                    pnLecturaAjenos.Visible = False
                    pnCargue.Enabled = True
                    If SecuencialAjeno = "" Then
                        Me.txtBarras.Text = Barcode.Serial
                    Else
                        Me.txtBarras.Text = SecuencialAjeno
                    End If
                    MostrarDatosAjenoVacio()
                End If
            End If
        Catch ex As Exception
            UIHandler.ShowError(ex.Message)
        End Try
    End Sub

    Private Sub mnuRegresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRegresar.Click
        UIHandler.StartWait()
        DialogResult = System.Windows.Forms.DialogResult.Yes
    End Sub

    Private Sub mnuResumen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuResumen.Click
        ResumenCargaForm.Run()
    End Sub

    ' Se busca el codigo ingresado manualmente o leído
    Private Sub MostrarInformacionCilindrosLlenos(ByVal Codigo As String)
        If Codigo <> "" Then
            If Codigo.Length > 8 Then
                UIHandler.ShowAlert("Código Inválido!!")
                LimpiarControles()
                Exit Sub
            End If
            Productos.LoadProducto(Codigo)
            If Me.dsProductos.Productos.Count = 0 Then
                UIHandler.ShowAlert("Producto no existe!!")
                LimpiarControles()
                Exit Sub
            End If

            ' Se muestran los datos del codigo de barras
            lblSecuencial.Text = Barcode.Secuencial
            lblProducto.Text = Barcode.CodigoProducto
            lblCapacidad.Text = Barcode.CapacidadWithFormat
            lblTipoPertenencia.Text = Barcode.Pertenencia
            lblSucursal.Text = Barcode.CodigoSucursal
            lblDescripcionTipoPertenencia.Text = Productos.GetPertenencia(Barcode.Pertenencia)
            lblSep1.Visible = True
            lblSep2.Visible = True
            ' Se muestra la informacion del producto
            bsProductos.Position = 0
            ' Se valida el tipo de producto
            If Not lblTipoProducto.Text = TipoProducto.Producto And _
            Not lblTipoProducto.Text = TipoProducto.Activo Then
                UIHandler.ShowError("Tipo de Producto no es el Correcto!!")
                LimpiarControles()
                Exit Sub
            End If

            '' Se valida que el secuencial no este leído
            'If Productos.GetSecuencial(lblSecuencial.Text) Then
            '    UIHandler.ShowError("Código ya leído!!")
            '    LimpiarControles()
            '    Exit Sub
            'End If

            If Me.lblTipoPertenencia.Text = Pertenencia.Cliente Then
                ' Se activa el panel de captura de seriales

                    pnCargue.Enabled = False
                    pnLecturaAjenos.Visible = True
                    pnLecturaAjenos.BringToFront()
                    Me.txtSerial.Text = ""
                    Me.txtSerial.Focus()
            Else
                SecuencialAjeno = ""
                ValidarDatosLeidos()
            End If
        End If
    End Sub

    Private Sub ValidarDatosLeidos()
        Dim Row As ProductosDataSet.CargaRow
        ' Se busca si ya existe el codigo en la tabla de carga
        Row = Me.dsProductos.Carga.FindByCodSucursalCodProductoCapacidadSecuencialPertenenciaCodTipoProductoSecuencialAjeno(Me.lblSucursal.Text, _
        Me.lblProducto.Text, QuitarFormato(Me.lblCapacidad.Text), Me.lblSecuencial.Text, Me.lblTipoPertenencia.Text, Me.lblTipoProducto.Text, SecuencialAjeno)

        If Row IsNot Nothing Then
            If MsgBox("Producto ya fue cargado, Desea eliminarlo?", MsgBoxStyle.YesNo, "Confirmación") = MsgBoxResult.Yes Then
                Try
                    Productos.OpenConnection()
                    ' Se elimina del kardex de camión
                    Row.Delete()
                    EliminarItemKardexCamion(Me.lblProducto.Text, QuitarFormato(Me.lblCapacidad.Text), Me.lblTipoProducto.Text)

                    If lblTipoProducto.Text = TipoProducto.Producto Then
                        Row = Me.dsProductos.Carga.FindByCodSucursalCodProductoCapacidadSecuencialPertenenciaCodTipoProductoSecuencialAjeno(Me.lblSucursal.Text, _
                        Me.lblProducto.Text, QuitarFormato(Me.lblCapacidad.Text), Me.lblSecuencial.Text, Me.lblTipoPertenencia.Text, TipoProducto.Activo, SecuencialAjeno)

                        If Row IsNot Nothing Then
                            Row.Delete()
                            ' Se elimina del kardex de camión
                            EliminarItemKardexCamion(Me.lblProducto.Text, QuitarFormato(Me.lblCapacidad.Text), TipoProducto.Activo)
                        End If
                    End If

                    ' Si es un ajeno se actualiza la tabla cilindros del cliente
                    If SecuencialAjeno <> "" Then
                        RowCliente("Seleccionado") = EstadoCilindroCliente.NoCargado
                    End If
                    ' Se actualiza el No. de leídos
                    If CInt(Me.lblNolecturas.Text) > 0 Then
                        Me.lblNolecturas.Text = CStr(CInt(Me.lblNolecturas.Text) - 1)
                    End If
                    pnLecturaAjenos.Visible = False
                    pnCargue.Enabled = True

                    ' Se actualizan las tablas
                    Productos.UpdateCarga()
                    Productos.UpdateKardexCamion()
                    Productos.UpdateCilindroCliente(RowCliente)

                    If pnLecturaAjenos.Visible Then
                        Me.txtSerial.Text = ""
                        Me.txtSerial.Focus()
                    Else
                        Me.txtBarras.Text = ""
                        Me.txtBarras.Focus()
                    End If
                Finally
                    Productos.CloseConnection()
                End Try
                Exit Sub
            End If
        Else
            If SecuencialAjeno <> "" Then
                If cstrDBNULL(RowCliente("Seleccionado")) = EstadoCilindroCliente.Cargado Then
                    UIHandler.ShowError("Secuencial ya leído!!")
                    If pnLecturaAjenos.Visible Then
                        Me.txtSerial.Text = ""
                        Me.txtSerial.Focus()
                    Else
                        Me.txtBarras.Text = ""
                        Me.txtBarras.Focus()
                    End If
                    Exit Sub
                End If
            End If
            ' Se Actualizan las tablas de cargue y kardex
            pnLecturaAjenos.Visible = False
            pnCargue.Enabled = True
            ActualizarDatosCargue(Me.lblSucursal.Text, Me.lblProducto.Text, QuitarFormato(Me.lblCapacidad.Text), _
            Me.lblSecuencial.Text, Me.lblTipoPertenencia.Text, Me.lblTipoProducto.Text, SecuencialAjeno)
        End If
    End Sub

    Public Sub ActualizarDatosCargue(ByVal sSucursal As String, ByVal sProducto As String, _
        ByVal sCapacidad As String, ByVal sSecuencial As String, ByVal sCodPertenencia As String, _
        ByVal sTipoProducto As String, ByVal sSecuencialAjeno As String)
        Dim CodActivo As String = ""
        Dim CapacidadActivo As String = ""
        Dim Row As ProductosDataSet.KardexCamionRow

        Try
            Productos.OpenConnection()
            ' Actualiza la carga
            InsertCarga(sSucursal, sProducto, sCapacidad, _
            sSecuencial, sCodPertenencia, sTipoProducto, sSecuencialAjeno)

            'Actualiza el kardex de camión
            Row = dsProductos.KardexCamion.FindByCodProductoCapacidadCodTipoProducto(sProducto, _
            sCapacidad, sTipoProducto)
            Productos.ActualizarDataTableKardexCamion(Row, sProducto, sCapacidad, sTipoProducto, sSucursal, _
            Me.lblTipoPertenencia.Text, 1, True)
            If lblTipoProducto.Text = TipoProducto.Producto Then
                ' Si es un Producto se obtiene el codigo y capacidad del activo
                If Productos.ObtenerActivoProducto(sProducto, sCapacidad, CodActivo, CapacidadActivo) Then
                    ' Se actualizan activos
                    InsertCarga(sSucursal, sProducto, sCapacidad, sSecuencial, sCodPertenencia, _
                    TipoProducto.Activo, sSecuencialAjeno)
                    ' Se actualizan activos en el kardex camion
                    Row = dsProductos.KardexCamion.FindByCodProductoCapacidadCodTipoProducto(sProducto, _
                    sCapacidad, TipoProducto.Activo)
                    Productos.ActualizarDataTableKardexCamion(Row, sProducto, sCapacidad, TipoProducto.Activo, sSucursal, _
                    Me.lblTipoPertenencia.Text, 1, True)
                End If
            End If
            ' Se actualiza la tabla de cilindros Leidos en el caso de tener secuencialAjeno
            If SecuencialAjeno <> "" Then
                RowCliente("Seleccionado") = EstadoCilindroCliente.Cargado
            End If
            Productos.UpdateCarga()
            Productos.UpdateKardexCamion()
            Productos.UpdateCilindroCliente(RowCliente)

            Me.lblNolecturas.Text = CStr(CInt(lblNolecturas.Text) + 1)
            Me.txtBarras.Text = ""
            Me.txtBarras.Focus()
        Finally
            Productos.CloseConnection()
        End Try
    End Sub

    Private Sub InsertCarga(ByVal sSucursal As String, ByVal sProducto As String, ByVal sCapacidad As String, _
    ByVal sSecuencial As String, ByVal sPertenencia As String, ByVal sTipoProducto As String, ByVal sSecuencialAjeno As String)
        Dim Row As ProductosDataSet.CargaRow
        Row = dsProductos.Carga.NewCargaRow
        Row.CodSucursal = sSucursal
        Row.CodProducto = sProducto
        Row.Capacidad = sCapacidad
        Row.Secuencial = sSecuencial
        Row.Pertenencia = sPertenencia
        Row.CodTipoProducto = sTipoProducto
        Row.SecuencialAjeno = sSecuencialAjeno
        Row.NoCarga = "1"
        Row.EstadoEntrega = EstadosCilindro.NoEntregado
        dsProductos.Carga.AddCargaRow(Row)
    End Sub

    Private Sub EliminarItemKardexCamion(ByVal sProducto As String, ByVal sCapacidad As String, ByVal sCodTipoProducto As String)
        Dim Row As ProductosDataSet.KardexCamionRow
        Row = dsProductos.KardexCamion.FindByCodProductoCapacidadCodTipoProducto(sProducto, sCapacidad, sCodTipoProducto)
        If Row IsNot Nothing Then
            If Me.lblTipoPertenencia.Text = Pertenencia.Cliente Then
                If Row.CantidadCliente - 1 = 0 And Row.CantidadPraxair = 0 Then
                    ' se elimina la fila
                    Row.Delete()
                Else
                    Row.SaldoCliente = CShort(Row.SaldoCliente) - CShort(1)
                    Row.CantidadCliente = CShort(Row.CantidadCliente) - CShort(1)
                End If
            Else
                If Row.CantidadPraxair - 1 = 0 And Row.CantidadCliente = 0 Then
                    ' se elimina la fila
                    Row.Delete()
                Else
                    Row.SaldoPraxair = CShort(Row.SaldoPraxair) - CShort(1)
                    Row.CantidadPraxair = CShort(Row.CantidadPraxair) - CShort(1)
                End If
            End If
        End If
    End Sub

    Private Sub MostrarDatosAjenoVacio()
        ' Se busca que el secuencial en la tabla de cilindroscliente
        ' y se extrae la información necesaria
        RowCliente = Productos.GetSecuencialAjenoVacio(SecuencialAjeno)
        If RowCliente Is Nothing Then
            UIHandler.ShowError("Secuencial no esta registrado para el cargue!!")
            Me.txtBarras.Text = ""
            Me.txtBarras.Focus()
            Exit Sub
        End If
        ' Se muestran los datos en pantalla
        Me.lblTipoProducto.Text = TipoProducto.Activo
        Me.lblDescripcionTipoProducto.Text = "Activo"
        Me.lblDescripcionProducto.Text = Productos.NombreProducto(CStr(RowCliente("CodProducto")))
        Me.lblSucursal.Text = CStr(RowCliente("Sucursal"))
        Me.lblProducto.Text = CStr(RowCliente("CodProducto"))
        Me.lblCapacidad.Text = Format(CLng(RowCliente("Capacidad")), "###,##0")
        Me.lblSecuencial.Text = ""
        Me.lblTipoPertenencia.Text = Pertenencia.Cliente
        Me.lblDescripcionTipoPertenencia.Text = Productos.GetPertenencia(Me.lblTipoPertenencia.Text)
        lblSep1.Visible = True
        lblSep2.Visible = True
        ValidarDatosLeidos()
    End Sub

    Private Sub LimpiarControles()
        Me.txtBarras.Text = ""
        Me.lblCapacidad.Text = ""
        Me.lblDescripcionProducto.Text = ""
        Me.lblDescripcionTipoPertenencia.Text = ""
        Me.lblDescripcionTipoProducto.Text = ""
        Me.lblProducto.Text = ""
        Me.lblSecuencial.Text = ""
        Me.lblSucursal.Text = ""
        Me.lblTipoPertenencia.Text = ""
        Me.lblTipoProducto.Text = ""
        Me.lblSep1.Visible = False
        Me.lblSep2.Visible = False
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.pnLecturaAjenos.Visible = False
        Me.pnCargue.Enabled = True
        Me.txtBarras.Text = ""
        Me.txtBarras.Focus()
    End Sub

    'Busqueda manual
    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        If Me.txtBarras.Text <> "" Then
            If Me.txtBarras.Text.Length = 24 Then
                Barcode.Parse(Me.txtBarras.Text, DatascanCF.Symbol.BarcodeType.EAN128)
                MostrarInformacionCilindrosLlenos(Barcode.CodigoProducto)
            ElseIf Me.txtBarras.Text.Length = 7 Then
                ' Vacio Ajeno
                SecuencialAjeno = Me.txtBarras.Text
                MostrarDatosAjenoVacio()
            Else
                UIHandler.ShowError("Código Inválido!!")
                Me.txtBarras.Text = ""
                Me.txtBarras.Focus()
            End If
        End If
    End Sub

    Private Sub mnuTransmitirDatos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuTransmitirDatos.Click

        'Dim lstQuerys As New ListQuerysDescarga
        'lstQuerys.Add("KardexCamion", "KardexCamion")
        'lstQuerys.Add("Carga", "Carga")

        If Nucleo.CargueCamion Then
            ' TODO: Registrar envio exitoso en la base de datos
        End If

        'If Nucleo.DescargarDatos(ProcesosComunicacion.EnvioCargueCamion, "Envio Cargue Camión", False, lstQuerys) Then
        ' TODO: Registrar envio exitoso en la base de datos
        'End If
    End Sub

End Class
