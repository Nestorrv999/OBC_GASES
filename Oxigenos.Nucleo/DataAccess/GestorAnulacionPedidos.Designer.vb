Partial Public Class GestorAnulacionPedidos
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
        Me.dsAnulacionPedidos = New Oxigenos.Principal.AnulacionPedidos
        Me.dtaMotivosAnulacion = New Oxigenos.Principal.AnulacionPedidosTableAdapters.MotivosAnulacionTableAdapter
        Me.dtaSolicitud_Anula_Pedido = New Oxigenos.Principal.AnulacionPedidosTableAdapters.Solicitud_Anula_PedidoTableAdapter
        Me.dtaParametros = New Oxigenos.Principal.AnulacionPedidosTableAdapters.ParametrosTableAdapter
        '
        'dsAnulacionPedidos
        '
        Me.dsAnulacionPedidos.DataSetName = "AnulacionPedidos"
        Me.dsAnulacionPedidos.Prefix = ""
        Me.dsAnulacionPedidos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dtaMotivosAnulacion
        '
        Me.dtaMotivosAnulacion.ClearBeforeFill = True
        '
        'dtaSolicitud_Anula_Pedido
        '
        Me.dtaSolicitud_Anula_Pedido.ClearBeforeFill = True
        '
        'dtaParametros
        '
        Me.dtaParametros.ClearBeforeFill = True

    End Sub
    Friend WithEvents dsAnulacionPedidos As Oxigenos.Principal.AnulacionPedidos
    Friend WithEvents dtaMotivosAnulacion As Oxigenos.Principal.AnulacionPedidosTableAdapters.MotivosAnulacionTableAdapter
    Friend WithEvents dtaSolicitud_Anula_Pedido As Oxigenos.Principal.AnulacionPedidosTableAdapters.Solicitud_Anula_PedidoTableAdapter
    Friend WithEvents dtaParametros As Oxigenos.Principal.AnulacionPedidosTableAdapters.ParametrosTableAdapter

End Class
