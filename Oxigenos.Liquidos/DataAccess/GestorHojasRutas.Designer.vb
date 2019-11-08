Partial Public Class GestorHojasRutas
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
        Me.dsHojasRuta = New Oxigenos.Liquidos.HojasRutaDataSet
        Me.dtaHojasRuta = New Oxigenos.Liquidos.HojasRutaDataSetTableAdapters.HojasRutaTableAdapter
        Me.dtaLugaresCarga = New Oxigenos.Liquidos.HojasRutaDataSetTableAdapters.LugaresCargaTableAdapter
        Me.dtaChoferes = New Oxigenos.Liquidos.HojasRutaDataSetTableAdapters.ChoferesTableAdapter
        Me.dtaTanqueros = New Oxigenos.Liquidos.HojasRutaDataSetTableAdapters.TanquerosTableAdapter
        Me.dtaTractores = New Oxigenos.Liquidos.HojasRutaDataSetTableAdapters.TractoresTableAdapter
        '
        'dsHojasRuta
        '
        Me.dsHojasRuta.DataSetName = "HojasRutaDataSet"
        Me.dsHojasRuta.Prefix = ""
        Me.dsHojasRuta.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dtaHojasRuta
        '
        Me.dtaHojasRuta.ClearBeforeFill = True
        '
        'dtaLugaresCarga
        '
        Me.dtaLugaresCarga.ClearBeforeFill = True
        '
        'dtaChoferes
        '
        Me.dtaChoferes.ClearBeforeFill = True
        '
        'dtaTanqueros
        '
        Me.dtaTanqueros.ClearBeforeFill = True
        '
        'dtaTractores
        '
        Me.dtaTractores.ClearBeforeFill = True

    End Sub
    Friend WithEvents dsHojasRuta As Oxigenos.Liquidos.HojasRutaDataSet
    Friend WithEvents dtaHojasRuta As Oxigenos.Liquidos.HojasRutaDataSetTableAdapters.HojasRutaTableAdapter
    Friend WithEvents dtaLugaresCarga As Oxigenos.Liquidos.HojasRutaDataSetTableAdapters.LugaresCargaTableAdapter
    Friend WithEvents dtaChoferes As Oxigenos.Liquidos.HojasRutaDataSetTableAdapters.ChoferesTableAdapter
    Friend WithEvents dtaTanqueros As Oxigenos.Liquidos.HojasRutaDataSetTableAdapters.TanquerosTableAdapter
    Friend WithEvents dtaTractores As Oxigenos.Liquidos.HojasRutaDataSetTableAdapters.TractoresTableAdapter

End Class
