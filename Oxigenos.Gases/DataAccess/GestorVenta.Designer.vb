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
        Me.dtaDetalleFactura = New Oxigenos.Gases.VentaDataSetTableAdapters.DetalleFacturaTableAdapter
        Me.dtaDetalleGuiaAsignacionesRecolecciones = New Oxigenos.Gases.VentaDataSetTableAdapters.DetalleGuiaAsignacionesRecoleccionesTableAdapter
        Me.dtaFacturasManuales = New Oxigenos.Gases.VentaDataSetTableAdapters.FacturasManualesTableAdapter
        Me.dtaMaestroFacturas = New Oxigenos.Gases.VentaDataSetTableAdapters.MaestroFacturasTableAdapter
        Me.dtaPrecios = New Oxigenos.Gases.VentaDataSetTableAdapters.PreciosTableAdapter
        Me.dtaDetalleGuiaRecoleccionesAjenos = New Oxigenos.Gases.VentaDataSetTableAdapters.DetalleGuiaRecoleccionesAjenosTableAdapter
        Me.dtaDetalleGuiaFacturasRemisiones = New Oxigenos.Gases.VentaDataSetTableAdapters.DetalleGuiaFacturasRemisionesTableAdapter
        Me.dsVenta = New Oxigenos.Gases.VentaDataSet
        Me.dtaMaestroGuias = New Oxigenos.Gases.VentaDataSetTableAdapters.MaestroGuiasTableAdapter
        Me.dtaCilindrosLeidos = New Oxigenos.Gases.VentaDataSetTableAdapters.CilindrosLeidosTableAdapter
        Me.dtaNocopias = New Oxigenos.Gases.VentaDataSetTableAdapters.CopiasDocumentosTableAdapter
        Me.dtaDocumentos = New Oxigenos.Gases.VentaDataSetTableAdapters.DocumentosTableAdapter
        '
        'dtaDetalleFactura
        '
        Me.dtaDetalleFactura.ClearBeforeFill = True
        '
        'dtaDetalleGuiaAsignacionesRecolecciones
        '
        Me.dtaDetalleGuiaAsignacionesRecolecciones.ClearBeforeFill = True
        '
        'dtaFacturasManuales
        '
        Me.dtaFacturasManuales.ClearBeforeFill = True
        '
        'dtaMaestroFacturas
        '
        Me.dtaMaestroFacturas.ClearBeforeFill = True
        '
        'dtaPrecios
        '
        Me.dtaPrecios.ClearBeforeFill = True
        '
        'dtaDetalleGuiaRecoleccionesAjenos
        '
        Me.dtaDetalleGuiaRecoleccionesAjenos.ClearBeforeFill = True
        '
        'dtaDetalleGuiaFacturasRemisiones
        '
        Me.dtaDetalleGuiaFacturasRemisiones.ClearBeforeFill = True
        '
        'dsVenta
        '
        Me.dsVenta.DataSetName = "VentaDataSet"
        Me.dsVenta.Prefix = ""
        Me.dsVenta.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dtaMaestroGuias
        '
        Me.dtaMaestroGuias.ClearBeforeFill = True
        '
        'dtaCilindrosLeidos
        '
        Me.dtaCilindrosLeidos.ClearBeforeFill = True
        Me.dtaNocopias.ClearBeforeFill = True

    End Sub
    Friend WithEvents dtaDetalleFactura As Oxigenos.Gases.VentaDataSetTableAdapters.DetalleFacturaTableAdapter
    Friend WithEvents dtaDetalleGuiaAsignacionesRecolecciones As Oxigenos.Gases.VentaDataSetTableAdapters.DetalleGuiaAsignacionesRecoleccionesTableAdapter
    Friend WithEvents dtaFacturasManuales As Oxigenos.Gases.VentaDataSetTableAdapters.FacturasManualesTableAdapter
    Friend WithEvents dtaMaestroFacturas As Oxigenos.Gases.VentaDataSetTableAdapters.MaestroFacturasTableAdapter
    Friend WithEvents dtaPrecios As Oxigenos.Gases.VentaDataSetTableAdapters.PreciosTableAdapter
    Friend WithEvents dtaDetalleGuiaRecoleccionesAjenos As Oxigenos.Gases.VentaDataSetTableAdapters.DetalleGuiaRecoleccionesAjenosTableAdapter
    Friend WithEvents dtaDetalleGuiaFacturasRemisiones As Oxigenos.Gases.VentaDataSetTableAdapters.DetalleGuiaFacturasRemisionesTableAdapter
    Friend WithEvents dsVenta As Oxigenos.Gases.VentaDataSet
    Friend WithEvents dtaMaestroGuias As Oxigenos.Gases.VentaDataSetTableAdapters.MaestroGuiasTableAdapter
    Friend WithEvents dtaCilindrosLeidos As Oxigenos.Gases.VentaDataSetTableAdapters.CilindrosLeidosTableAdapter
    Friend WithEvents dtaNocopias As Oxigenos.Gases.VentaDataSetTableAdapters.CopiasDocumentosTableAdapter
    Friend WithEvents dtaDocumentos As Oxigenos.Gases.VentaDataSetTableAdapters.DocumentosTableAdapter

End Class
