Partial Public Class GestorVenta
    Inherits GestorBase

    <System.Diagnostics.DebuggerNonUserCode()> _
    Public Sub New(ByVal Container As System.ComponentModel.IContainer)
        MyClass.New()

        'Requerido para la compatibilidad con el Diseñador de composiciones de clases Windows.Forms
        Container.Add(Me)

    End Sub

    <System.Diagnostics.DebuggerNonUserCode()> _
    Public Sub New()
        MyBase.New()

        'El Diseñador de componentes requiere esta llamada.
        InitializeComponent()

    End Sub

    'Component reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de componentes
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de componentes requiere el siguiente procedimiento
    'Se puede modificar usando el Diseñador de componentes.
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.dsVenta = New Oxigenos.Liquidos.VentaDataSet
        Me.dtaTanquesCliente = New Oxigenos.Liquidos.VentaDataSetTableAdapters.TanquesClienteTableAdapter
        Me.dtaAforos = New Oxigenos.Liquidos.VentaDataSetTableAdapters.AforosTableAdapter
        Me.dtaDetalleFactura = New Oxigenos.Liquidos.VentaDataSetTableAdapters.DetalleFacturaTableAdapter
        Me.dtaDetallePedido = New Oxigenos.Liquidos.VentaDataSetTableAdapters.DetallePedidoTableAdapter
        Me.dtaMaestroFacturas = New Oxigenos.Liquidos.VentaDataSetTableAdapters.MaestroFacturasTableAdapter
        '
        'dsVenta
        '
        Me.dsVenta.DataSetName = "VentaDataSet"
        Me.dsVenta.Prefix = ""
        Me.dsVenta.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dtaTanquesCliente
        '
        Me.dtaTanquesCliente.ClearBeforeFill = True
        '
        'dtaAforos
        '
        Me.dtaAforos.ClearBeforeFill = True
        '
        'dtaDetalleFactura
        '
        Me.dtaDetalleFactura.ClearBeforeFill = True
        '
        'dtaDetallePedido
        '
        Me.dtaDetallePedido.ClearBeforeFill = True
        '
        'dtaMaestroFacturas
        '
        Me.dtaMaestroFacturas.ClearBeforeFill = True

    End Sub
    Friend WithEvents dsVenta As Oxigenos.Liquidos.VentaDataSet
    Friend WithEvents dtaTanquesCliente As Oxigenos.Liquidos.VentaDataSetTableAdapters.TanquesClienteTableAdapter
    Friend WithEvents dtaAforos As Oxigenos.Liquidos.VentaDataSetTableAdapters.AforosTableAdapter
    Friend WithEvents dtaDetalleFactura As Oxigenos.Liquidos.VentaDataSetTableAdapters.DetalleFacturaTableAdapter
    Friend WithEvents dtaDetallePedido As Oxigenos.Liquidos.VentaDataSetTableAdapters.DetallePedidoTableAdapter
    Friend WithEvents dtaMaestroFacturas As Oxigenos.Liquidos.VentaDataSetTableAdapters.MaestroFacturasTableAdapter

End Class
