Partial Public Class GestorAtencionPedidos
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
        Me.dsAtencionPedidos = New Oxigenos.Gases.AtencionPedidos
        Me.dtaDetallePedido = New Oxigenos.Gases.AtencionPedidosTableAdapters.DetallePedidoTableAdapter
        Me.dtaDetalleGuiaAsignacionesRecolecciones = New Oxigenos.Gases.AtencionPedidosTableAdapters.DetalleGuiaAsignacionesRecoleccionesTableAdapter
        Me.dtaDetalleGuiaFacturasRemisiones = New Oxigenos.Gases.AtencionPedidosTableAdapters.DetalleGuiaFacturasRemisionesTableAdapter
        '
        'dsAtencionPedidos
        '
        Me.dsAtencionPedidos.DataSetName = "AtencionPedidos"
        Me.dsAtencionPedidos.Prefix = ""
        Me.dsAtencionPedidos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dtaDetallePedido
        '
        Me.dtaDetallePedido.ClearBeforeFill = True
        '
        'dtaDetalleGuiaAsignacionesRecolecciones
        '
        Me.dtaDetalleGuiaAsignacionesRecolecciones.ClearBeforeFill = True
        '
        'dtaDetalleGuiaFacturasRemisiones
        '
        Me.dtaDetalleGuiaFacturasRemisiones.ClearBeforeFill = True

    End Sub
    Friend WithEvents dsAtencionPedidos As Oxigenos.Gases.AtencionPedidos
    Friend WithEvents dtaDetallePedido As Oxigenos.Gases.AtencionPedidosTableAdapters.DetallePedidoTableAdapter
    Friend WithEvents dtaDetalleGuiaAsignacionesRecolecciones As Oxigenos.Gases.AtencionPedidosTableAdapters.DetalleGuiaAsignacionesRecoleccionesTableAdapter
    Friend WithEvents dtaDetalleGuiaFacturasRemisiones As Oxigenos.Gases.AtencionPedidosTableAdapters.DetalleGuiaFacturasRemisionesTableAdapter

End Class
