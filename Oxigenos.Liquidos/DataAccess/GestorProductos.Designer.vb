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
        Me.dsProductos = New Oxigenos.Liquidos.ProductosDataSet
        Me.dtaProductos = New Oxigenos.Liquidos.ProductosDataSetTableAdapters.ProductosTableAdapter
        Me.dtaPrecios = New Oxigenos.Liquidos.ProductosDataSetTableAdapters.PreciosTableAdapter
        Me.dtaKardex = New Oxigenos.Liquidos.ProductosDataSetTableAdapters.KardexCamionTableAdapter
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
        'dtaPrecios
        '
        Me.dtaPrecios.ClearBeforeFill = True
        '
        'dtaKardex
        '
        Me.dtaKardex.ClearBeforeFill = True

    End Sub
    Friend WithEvents dsProductos As Oxigenos.Liquidos.ProductosDataSet
    Friend WithEvents dtaProductos As Oxigenos.Liquidos.ProductosDataSetTableAdapters.ProductosTableAdapter
    Friend WithEvents dtaPrecios As Oxigenos.Liquidos.ProductosDataSetTableAdapters.PreciosTableAdapter
    Friend WithEvents dtaKardex As Oxigenos.Liquidos.ProductosDataSetTableAdapters.KardexCamionTableAdapter

End Class
