Partial Public Class GestorProductos
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
        Me.dsProductos = New Oxigenos.Gases.ProductosDataSet
        Me.dtaProductos = New Oxigenos.Gases.ProductosDataSetTableAdapters.ProductosTableAdapter
        Me.dtaPertenencia = New Oxigenos.Gases.ProductosDataSetTableAdapters.PertenenciaTableAdapter
        Me.dtaCarga = New Oxigenos.Gases.ProductosDataSetTableAdapters.CargaTableAdapter
        Me.dtaActivoProducto = New Oxigenos.Gases.ProductosDataSetTableAdapters.ActivoProductoTableAdapter
        Me.dtaKardexCamion = New Oxigenos.Gases.ProductosDataSetTableAdapters.KardexCamionTableAdapter
        Me.dtaTipoProductos = New Oxigenos.Gases.ProductosDataSetTableAdapters.TipoProductosTableAdapter
        Me.dtaCilindrosCliente = New Oxigenos.Gases.ProductosDataSetTableAdapters.CilindrosClienteTableAdapter
        '
        'dsProductos
        '
        Me.dsProductos.DataSetName = "ProductosDataSet"
        Me.dsProductos.Prefix = ""
        Me.dsProductos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dtaProductos
        '
        Me.dtaProductos.ClearBeforeFill = True
        '
        'dtaPertenencia
        '
        Me.dtaPertenencia.ClearBeforeFill = True
        '
        'dtaCarga
        '
        Me.dtaCarga.ClearBeforeFill = True
        '
        'dtaActivoProducto
        '
        Me.dtaActivoProducto.ClearBeforeFill = True
        '
        'dtaKardexCamion
        '
        Me.dtaKardexCamion.ClearBeforeFill = True
        '
        'dtaTipoProductos
        '
        Me.dtaTipoProductos.ClearBeforeFill = True
        '
        'dtaCilindrosCliente
        '
        Me.dtaCilindrosCliente.ClearBeforeFill = True

    End Sub
    Friend WithEvents dsProductos As Oxigenos.Gases.ProductosDataSet
    Friend WithEvents dtaProductos As Oxigenos.Gases.ProductosDataSetTableAdapters.ProductosTableAdapter
    Friend WithEvents dtaPertenencia As Oxigenos.Gases.ProductosDataSetTableAdapters.PertenenciaTableAdapter
    Friend WithEvents dtaCarga As Oxigenos.Gases.ProductosDataSetTableAdapters.CargaTableAdapter
    Friend WithEvents dtaActivoProducto As Oxigenos.Gases.ProductosDataSetTableAdapters.ActivoProductoTableAdapter
    Friend WithEvents dtaKardexCamion As Oxigenos.Gases.ProductosDataSetTableAdapters.KardexCamionTableAdapter
    Friend WithEvents dtaTipoProductos As Oxigenos.Gases.ProductosDataSetTableAdapters.TipoProductosTableAdapter
    Friend WithEvents dtaCilindrosCliente As Oxigenos.Gases.ProductosDataSetTableAdapters.CilindrosClienteTableAdapter

End Class
