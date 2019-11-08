Partial Public Class GestorListaQueries
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
        Me.dsListaQueries = New Oxigenos.Principal.ListaQueriesDataSet
        Me.dtaParamDescarga = New Oxigenos.Principal.ListaQueriesDataSetTableAdapters.ParamDescargaTableAdapter
        '
        'dsListaQueries
        '
        Me.dsListaQueries.DataSetName = "ListaQueriesDataSet"
        Me.dsListaQueries.Prefix = ""
        Me.dsListaQueries.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dtaParamDescarga
        '
        Me.dtaParamDescarga.ClearBeforeFill = True

    End Sub
    Friend WithEvents dsListaQueries As Oxigenos.Principal.ListaQueriesDataSet
    Friend WithEvents dtaParamDescarga As Oxigenos.Principal.ListaQueriesDataSetTableAdapters.ParamDescargaTableAdapter

End Class
