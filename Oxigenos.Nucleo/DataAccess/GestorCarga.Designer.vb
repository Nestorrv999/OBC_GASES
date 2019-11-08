Partial Public Class GestorCarga
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
        Me.dsCargaDataset = New Oxigenos.Principal.CargaDataset
        Me.dtaPedidos = New Oxigenos.Principal.CargaDatasetTableAdapters.PedidosTableAdapter
        Me.dtaPedidosReasignados = New Oxigenos.Principal.CargaDatasetTableAdapters.PedidosReasignadosTableAdapter
        Me.dtaConfirmacionAnulacionPedido = New Oxigenos.Principal.CargaDatasetTableAdapters.ConfirmacionAnulacionPedidoTableAdapter
        Me.dtaSolicitud_Anula_Pedido = New Oxigenos.Principal.CargaDatasetTableAdapters.Solicitud_Anula_PedidoTableAdapter
        '
        'dsCargaDataset
        '
        Me.dsCargaDataset.DataSetName = "CargaDataset"
        Me.dsCargaDataset.Prefix = ""
        Me.dsCargaDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dtaPedidos
        '
        Me.dtaPedidos.ClearBeforeFill = True
        '
        'dtaPedidosReasignados
        '
        Me.dtaPedidosReasignados.ClearBeforeFill = True
        '
        'dtaConfirmacionAnulacionPedido
        '
        Me.dtaConfirmacionAnulacionPedido.ClearBeforeFill = True
        '
        'dtaSolicitud_Anula_Pedido
        '
        Me.dtaSolicitud_Anula_Pedido.ClearBeforeFill = True

    End Sub
    Friend WithEvents dsCargaDataset As Oxigenos.Principal.CargaDataset
    Friend WithEvents dtaPedidos As Oxigenos.Principal.CargaDatasetTableAdapters.PedidosTableAdapter
    Friend WithEvents dtaPedidosReasignados As Oxigenos.Principal.CargaDatasetTableAdapters.PedidosReasignadosTableAdapter
    Friend WithEvents dtaConfirmacionAnulacionPedido As Oxigenos.Principal.CargaDatasetTableAdapters.ConfirmacionAnulacionPedidoTableAdapter
    Friend WithEvents dtaSolicitud_Anula_Pedido As Oxigenos.Principal.CargaDatasetTableAdapters.Solicitud_Anula_PedidoTableAdapter

End Class
