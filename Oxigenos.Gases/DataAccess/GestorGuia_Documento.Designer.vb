﻿Partial Public Class GestorGuia_Documento
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
        Me.dtaGuia_Documento = New Oxigenos.Gases.GuiaDocumentoTableAdapters.Guia_DocumentoTableAdapter
        Me.dsGuiaDocumento = New Oxigenos.Gases.GuiaDocumento
        '
        'dtaGuia_Documento
        '
        Me.dtaGuia_Documento.ClearBeforeFill = True
        '
        'dsGuiaDocumento
        '
        Me.dsGuiaDocumento.DataSetName = "GuiaDocumento"
        Me.dsGuiaDocumento.Prefix = ""
        Me.dsGuiaDocumento.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema

    End Sub
    Friend WithEvents dtaGuia_Documento As Oxigenos.Gases.GuiaDocumentoTableAdapters.Guia_DocumentoTableAdapter
    Friend WithEvents dsGuiaDocumento As Oxigenos.Gases.GuiaDocumento

End Class
