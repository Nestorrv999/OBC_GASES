Partial Public Class GestorGuiaCarga
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
        Me.dsGuiaDeCarga = New Oxigenos.Gases.GuiaDeCargaDataSet
        Me.dtaGuiaCarga = New Oxigenos.Gases.GuiaDeCargaDataSetTableAdapters.GuiaCargaTableAdapter
        Me.dtaParametros = New Oxigenos.Gases.GuiaDeCargaDataSetTableAdapters.ParametrosTableAdapter
        '
        'dsGuiaDeCarga
        '
        Me.dsGuiaDeCarga.DataSetName = "GuiaDeCargaDataSet"
        Me.dsGuiaDeCarga.Prefix = ""
        Me.dsGuiaDeCarga.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dtaGuiaCarga
        '
        Me.dtaGuiaCarga.ClearBeforeFill = True
        '
        'dtaParametros
        '
        Me.dtaParametros.ClearBeforeFill = True

    End Sub
    Friend WithEvents dsGuiaDeCarga As Oxigenos.Gases.GuiaDeCargaDataSet
    Friend WithEvents dtaGuiaCarga As Oxigenos.Gases.GuiaDeCargaDataSetTableAdapters.GuiaCargaTableAdapter
    Friend WithEvents dtaParametros As Oxigenos.Gases.GuiaDeCargaDataSetTableAdapters.ParametrosTableAdapter

End Class
