Partial Public Class NucleoDataAccess
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
        Me.dsNucleo = New Oxigenos.Principal.NucleoDataSet
        Me.dtaParametros = New Oxigenos.Principal.NucleoDataSetTableAdapters.ParametrosTableAdapter
        Me.dtaClientes = New Oxigenos.Principal.NucleoDataSetTableAdapters.ClientesTableAdapter
        Me.dtaDirecciones = New Oxigenos.Principal.NucleoDataSetTableAdapters.DireccionesClienteTableAdapter
        Me.dtaPedidos = New Oxigenos.Principal.NucleoDataSetTableAdapters.PedidosTableAdapter
        Me.dtaDocumentos = New Oxigenos.Principal.NucleoDataSetTableAdapters.TalonariosTableAdapter
        Me.dtaEntidades = New Oxigenos.Principal.NucleoDataSetTableAdapters.EntidadesTableAdapter
        Me.dtaMaestroGuias = New Oxigenos.Principal.NucleoDataSetTableAdapters.MaestroGuiasTableAdapter
        '
        'dsNucleo
        '
        Me.dsNucleo.DataSetName = "NucleoDataSet"
        Me.dsNucleo.Prefix = ""
        'Me.dsNucleo.RemotingFormat = System.Data.SerializationFormat.Xml
        Me.dsNucleo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dtaParametros
        '
        Me.dtaParametros.ClearBeforeFill = True
        '
        'dtaClientes
        '
        Me.dtaClientes.ClearBeforeFill = True
        '
        'dtaDirecciones
        '
        Me.dtaDirecciones.ClearBeforeFill = True
        '
        'dtaPedidos
        '
        Me.dtaPedidos.ClearBeforeFill = True
        '
        'dtaDocumentos
        '
        Me.dtaDocumentos.ClearBeforeFill = True
        '
        'dtaEntidades
        '
        Me.dtaEntidades.ClearBeforeFill = True
        '
        'dtaMaestroGuias
        '
        Me.dtaMaestroGuias.ClearBeforeFill = True

    End Sub
    Friend WithEvents dsNucleo As Oxigenos.Principal.NucleoDataSet
    Friend WithEvents dtaParametros As Oxigenos.Principal.NucleoDataSetTableAdapters.ParametrosTableAdapter
    Friend WithEvents dtaClientes As Oxigenos.Principal.NucleoDataSetTableAdapters.ClientesTableAdapter
    Friend WithEvents dtaDirecciones As Oxigenos.Principal.NucleoDataSetTableAdapters.DireccionesClienteTableAdapter
    Friend WithEvents dtaPedidos As Oxigenos.Principal.NucleoDataSetTableAdapters.PedidosTableAdapter
    Friend WithEvents dtaDocumentos As Oxigenos.Principal.NucleoDataSetTableAdapters.TalonariosTableAdapter
    Friend WithEvents dtaEntidades As Oxigenos.Principal.NucleoDataSetTableAdapters.EntidadesTableAdapter
    Friend WithEvents dtaMaestroGuias As Oxigenos.Principal.NucleoDataSetTableAdapters.MaestroGuiasTableAdapter

End Class
