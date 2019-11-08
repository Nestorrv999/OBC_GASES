Imports DatascanCF.Symbol

Public Class RecoleccionesManualesForm
    Private WithEvents m_BarcodeReader As BarcodeReader
    Public RowProducto As ProductosDataSet.ProductosRow
    Public RowLeidos As DataRow
    Public sPertenencia As String = ""
    Public bCapturaManual As Boolean = False
    Public sSecuencialAjeno As String = ""

#Region "Eventos"

    Private Sub RecoleccionesManualesForm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If Not Nucleo.ProcessHotKeys(Me, e) Then
            If e.KeyCode = System.Windows.Forms.Keys.Escape Then
                btnRegresar_Click(Me, Nothing)
            ElseIf e.KeyCode = System.Windows.Forms.Keys.G Then
                btnGenerar_Click(Me, Nothing)
            End If
        End If
    End Sub

    Private Sub RecoleccionesManualesForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        UiHandler1.Parent = Me
        ' Se inicializa el scanner
        DatascanCF.Symbol.BarcodeReader.InitReader()
        m_BarcodeReader = New BarcodeReader
        m_BarcodeReader.StartRead(Me)
        Barcode.LoadData()
        LimpiarControles()
        Me.dsVenta = Venta.dsVenta
        Me.dsProductos = Productos.dsProductos
        Me.cbPertenencia.Focus()
        UIHandler.EndWait()
    End Sub

    Private Sub txtSerial_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSerial.KeyPress
        If e.KeyChar = vbCr Then
            If cbPertenencia.SelectedIndex >= 0 And Me.txtProducto.Text <> "" And _
            Me.lblDescripcionProducto.Text <> "" And Me.txtCapacidad.Text <> "" Then
                If CInt(txtCapacidad.Text) > 0 Then
                    If Me.txtSerial.Text <> "" Then
                        sSecuencialAjeno = Me.txtSerial.Text
                        GuardarDatos(sSecuencialAjeno)
                    End If
                Else
                    UIHandler.ShowError("La capacidad debe se mayor a 0!!")
                End If
            Else
                UIHandler.ShowError("Ingrese los datos solicitados!!")
            End If
            End If
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        ' Se llama la forma para seleccionar el producto
        Dim Row As DataRow
        Dim CodProducto As String = ""
        Row = BuscarProductoForm.Run("", Nothing, True)
        If Row IsNot Nothing Then
            ' Se trae el codigo y la descripción del producto
            Me.txtProducto.Text = CStr(Row("Codigo"))
            Me.lblDescripcionProducto.Text = CStr(Row("Descripcion"))
        End If
    End Sub

    Private Sub btnRegresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegresar.Click
        UIHandler.StartWait()
        DialogResult = System.Windows.Forms.DialogResult.Yes
    End Sub

    Private Sub cbPertenencia_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbPertenencia.SelectedIndexChanged
        Dim nIndex As Integer = 0
        nIndex = cbPertenencia.SelectedIndex
        If nIndex >= 0 Then
            If cbPertenencia.Text = "CLIENTE" Then
                sPertenencia = Pertenencia.Cliente
                Me.lblSerial.Visible = True
                Me.txtSerial.Visible = True
                Me.lblCantidad.Visible = False
                Me.txtCantidad.Visible = False
                Me.txtCantidad.Text = "1"
            ElseIf cbPertenencia.Text = "PRAXAIR" Then
                sPertenencia = Pertenencia.Praxair
                Me.lblSerial.Visible = False
                Me.txtSerial.Visible = False
                Me.lblCantidad.Visible = True
                Me.txtCantidad.Visible = True
                Me.txtSerial.Text = ""
            End If
        End If
    End Sub

    Private Sub txtCantidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantidad.KeyPress
        If e.KeyChar = vbCr Then
            sSecuencialAjeno = ""
            If cbPertenencia.SelectedIndex >= 0 And Me.txtProducto.Text <> "" And _
            Me.lblDescripcionProducto.Text <> "" And Me.txtCapacidad.Text <> "" And _
            Me.txtCantidad.Text <> "" Then
                If CInt(Me.txtCantidad.Text) > 0 And CInt(Me.txtCapacidad.Text) > 0 Then
                    GuardarDatos(sSecuencialAjeno)
                Else
                    UIHandler.ShowError("La capacidad y cantidad debe ser mayor a 0!!")
                End If
            Else
                UIHandler.ShowError("Ingrese los datos solicitados!!")
            End If
            End If
    End Sub

    Private Sub txtCapacidad_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCapacidad.GotFocus
        If Me.txtCapacidad.Text <> "" Then
            Me.txtCapacidad.Text.Replace(",", "")
        End If
    End Sub

    Private Sub txtProducto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtProducto.KeyPress
        If e.KeyChar = vbCr Then
            If Me.txtProducto.Text <> "" Then
                RowProducto = Productos.GetProducto(Me.txtProducto.Text)
                If RowProducto IsNot Nothing Then
                    Me.lblDescripcionProducto.Text = RowProducto.Descripcion
                Else
                    UIHandler.ShowError("Código no existe!!")
                    Me.lblDescripcionProducto.Text = ""
                    Me.txtProducto.Text = ""
                    Me.txtProducto.Focus()
                End If
            Else
                UIHandler.ShowError("Ingrese el producto!!")
                Me.txtProducto.Focus()
            End If
        End If
    End Sub

#End Region

    Public Shared Sub Run()
        UIHandler.StartWait()
        Dim form As New RecoleccionesManualesForm
        form.ShowDialog()
        form.Dispose()
        UIHandler.EndWait()
    End Sub

    Private Sub m_BarcodeReader_ScanComplete(ByVal e As DatascanCF.Symbol.ScanCompleteArgs) Handles m_BarcodeReader.ScanComplete
        Try
            Barcode.Parse(e.Text, e.Type)
            If Not Barcode.NoDefinido Is Nothing Then
                UIHandler.ShowAlert("Código no Definido!!")
            ElseIf Not Barcode.Serial Is Nothing Then
                If txtSerial.Visible Then
                    Me.txtSerial.Text = Barcode.Serial
                    If cbPertenencia.SelectedIndex >= 0 And Me.txtProducto.Text <> "" And _
                    Me.lblDescripcionProducto.Text <> "" And Me.txtCapacidad.Text <> "" Then
                        sSecuencialAjeno = Barcode.Serial
                        GuardarDatos(sSecuencialAjeno)
                    Else
                        UIHandler.ShowError("Ingrese los datos solicitados!!")
                    End If
                Else
                    UIHandler.ShowAlert("Código Inválido!!")
                End If
            End If
        Catch ex As Exception
            UIHandler.ShowError(ex.Message)
        End Try
    End Sub

    Public Sub LimpiarControles()
        Me.txtProducto.Text = ""
        Me.txtCapacidad.Text = ""
        Me.txtSerial.Text = ""
        Me.txtCantidad.Text = ""
        Me.lblDescripcionProducto.Text = ""
        Me.cbPertenencia.SelectedIndex = -1
        Me.cbPertenencia.Focus()
    End Sub

    Public Sub GuardarDatos(ByVal Secuencial As String)
        Dim RowCilindroCliente As DataRow
        ' Si se lee serial se debe validar que éste no se encuentre
        ' en la tabla de cilindros cliente
        If Secuencial <> "" Then
            RowCilindroCliente = Productos.GetSecuencialAjenoVacio(Secuencial)
            If RowCilindroCliente IsNot Nothing Then
                UIHandler.ShowError("Error el serial leído es para entrega!!")
                Me.txtSerial.Text = ""
                Me.txtSerial.Focus()
                Exit Sub
            End If
        End If

        Dim sCapacidad As String = (CDbl(QuitarFormato(Me.txtCapacidad.Text)) * 1000).ToString("##0")

        RowLeidos = dsVenta.CilindrosLeidos.FindByCodSucursalCodProductoCapacidadSecuencialPertenenciaCodTipoProductoSecuencialAjeno(Nucleo.CodigoSucursal, _
        Me.txtProducto.Text, sCapacidad, "", sPertenencia, "", Secuencial)

        If RowLeidos IsNot Nothing Then
            UIHandler.ShowError("Cilindro ya Registrado!!")
            Exit Sub
        End If

        Productos.LoadProducto(Me.txtProducto.Text)

        'Se inserta en el datatable de Leídos
        Venta.dsVenta.CilindrosLeidos.AddCilindrosLeidosRow(Nucleo.CodigoSucursal, Me.txtProducto.Text, _
        sCapacidad, "", sPertenencia, "", Secuencial, CShort(txtCantidad.Text), _
        cstrDBNULL(Me.dsProductos.Productos.Rows(0)("UnidadMedida")), "N", 0)

        ' Se limpian los controles
        Me.lblItems.Text = CStr(CInt(Me.lblItems.Text) + 1)
        If sPertenencia = Pertenencia.Cliente Then
            Me.txtSerial.Text = ""
            Me.txtSerial.Focus()
        Else
            Me.txtProducto.Text = ""
            Me.lblDescripcionProducto.Text = ""
            Me.txtCapacidad.Text = ""
            Me.txtCantidad.Text = ""
            Me.txtProducto.Focus()
        End If
    End Sub

    Private Sub btnGenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerar.Click
        ' Se genera el documento manual
        If dsVenta.CilindrosLeidos.Rows.Count > 0 Then
            AsignaDocumentoManualForm.Run(TipoMovimientos.Recoleccion, "Recolección Manual", TiposDocumento.RecoleccionManual)
            UIHandler.StartWait()
            DialogResult = System.Windows.Forms.DialogResult.OK
        Else
            UIHandler.ShowAlert("No existen datos para generar!!")
        End If
    End Sub

    Private Sub txtSerial_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSerial.TextChanged

    End Sub

    Private Sub txtCapacidad_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCapacidad.TextChanged

    End Sub
End Class