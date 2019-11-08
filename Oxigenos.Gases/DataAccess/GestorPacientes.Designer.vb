Partial Public Class GestorPacientes
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
        Me.dsPacientes = New Oxigenos.Gases.PacientesDataSet
        Me.dtaAutorizaciones = New Oxigenos.Gases.PacientesDataSetTableAdapters.AutorizacionesTableAdapter
        Me.dtaDetalleAutorizaciones = New Oxigenos.Gases.PacientesDataSetTableAdapters.DetalleAutorizacionesTableAdapter
        Me.dtaAlquileres = New Oxigenos.Gases.PacientesDataSetTableAdapters.AlquileresTableAdapter
        Me.dtaEntidadCliente = New Oxigenos.Gases.PacientesDataSetTableAdapters.EntidadClienteTableAdapter
        Me.dtaEntidades = New Oxigenos.Gases.PacientesDataSetTableAdapters.EntidadesTableAdapter
        Me.dtaDetallesTipoAsignacion = New Oxigenos.Gases.PacientesDataSetTableAdapters.DetallesTipoAsignacionTableAdapter
        Me.dtaDepositosEntidad = New Oxigenos.Gases.PacientesDataSetTableAdapters.DepositosEntidadTableAdapter
        Me.dtaTipoAsignaciones = New Oxigenos.Gases.PacientesDataSetTableAdapters.TipoAsignacionesTableAdapter
        Me.dtaDepositosGarantia = New Oxigenos.Gases.PacientesDataSetTableAdapters.DepositosGarantiaTableAdapter
        Me.dtaAlquileresPagados = New Oxigenos.Gases.PacientesDataSetTableAdapters.AlquileresPagadosTableAdapter
        Me.dtaAutorizacionAsignacion = New Oxigenos.Gases.PacientesDataSetTableAdapters.AutorizacionAsignacionTableAdapter
        Me.dtaAutorizacionRemision = New Oxigenos.Gases.PacientesDataSetTableAdapters.AutorizacionRemisionTableAdapter
        Me.dtaAsignaciones = New Oxigenos.Gases.PacientesDataSetTableAdapters.AsignacionesTableAdapter
        Me.dtaAlquileresPendientes = New Oxigenos.Gases.PacientesDataSetTableAdapters.AlquileresPendientesTableAdapter
        Me.dtaDeudasPagadas = New Oxigenos.Gases.PacientesDataSetTableAdapters.DeudasPagadasTableAdapter
        Me.dtaMovimientoCopagosCuotas = New Oxigenos.Gases.PacientesDataSetTableAdapters.MovimientoCopagosCuotasTableAdapter
        Me.dtaClientes = New Oxigenos.Gases.PacientesDataSetTableAdapters.ClientesTableAdapter
        Me.dtaCopagosPorCobrar = New Oxigenos.Gases.PacientesDataSetTableAdapters.CopagosPorCobrarTableAdapter
        '
        'dsPacientes
        '
        Me.dsPacientes.DataSetName = "PacientesDataSet"
        Me.dsPacientes.Prefix = ""
        Me.dsPacientes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dtaAutorizaciones
        '
        Me.dtaAutorizaciones.ClearBeforeFill = True
        '
        'dtaDetalleAutorizaciones
        '
        Me.dtaDetalleAutorizaciones.ClearBeforeFill = True
        '
        'dtaAlquileres
        '
        Me.dtaAlquileres.ClearBeforeFill = True
        '
        'dtaEntidadCliente
        '
        Me.dtaEntidadCliente.ClearBeforeFill = True
        '
        'dtaEntidades
        '
        Me.dtaEntidades.ClearBeforeFill = True
        '
        'dtaDetallesTipoAsignacion
        '
        Me.dtaDetallesTipoAsignacion.ClearBeforeFill = True
        '
        'dtaDepositosEntidad
        '
        Me.dtaDepositosEntidad.ClearBeforeFill = True
        '
        'dtaTipoAsignaciones
        '
        Me.dtaTipoAsignaciones.ClearBeforeFill = True
        '
        'dtaDepositosGarantia
        '
        Me.dtaDepositosGarantia.ClearBeforeFill = True
        '
        'dtaAlquileresPagados
        '
        Me.dtaAlquileresPagados.ClearBeforeFill = True
        '
        'dtaAutorizacionAsignacion
        '
        Me.dtaAutorizacionAsignacion.ClearBeforeFill = True
        '
        'dtaAutorizacionRemision
        '
        Me.dtaAutorizacionRemision.ClearBeforeFill = True
        '
        'dtaAsignaciones
        '
        Me.dtaAsignaciones.ClearBeforeFill = True
        '
        'dtaAlquileresPendientes
        '
        Me.dtaAlquileresPendientes.ClearBeforeFill = True
        '
        'dtaDeudasPagadas
        '
        Me.dtaDeudasPagadas.ClearBeforeFill = True
        '
        'dtaMovimientoCopagosCuotas
        '
        Me.dtaMovimientoCopagosCuotas.ClearBeforeFill = True
        '
        'dtaClientes
        '
        Me.dtaClientes.ClearBeforeFill = True
        '
        'dtaCopagosPorCobrar
        '
        Me.dtaCopagosPorCobrar.ClearBeforeFill = True

    End Sub
    Friend WithEvents dsPacientes As Oxigenos.Gases.PacientesDataSet
    Friend WithEvents dtaAutorizaciones As Oxigenos.Gases.PacientesDataSetTableAdapters.AutorizacionesTableAdapter
    Friend WithEvents dtaDetalleAutorizaciones As Oxigenos.Gases.PacientesDataSetTableAdapters.DetalleAutorizacionesTableAdapter
    Friend WithEvents dtaAlquileres As Oxigenos.Gases.PacientesDataSetTableAdapters.AlquileresTableAdapter
    Friend WithEvents dtaEntidadCliente As Oxigenos.Gases.PacientesDataSetTableAdapters.EntidadClienteTableAdapter
    Friend WithEvents dtaEntidades As Oxigenos.Gases.PacientesDataSetTableAdapters.EntidadesTableAdapter
    Friend WithEvents dtaDetallesTipoAsignacion As Oxigenos.Gases.PacientesDataSetTableAdapters.DetallesTipoAsignacionTableAdapter
    Friend WithEvents dtaDepositosEntidad As Oxigenos.Gases.PacientesDataSetTableAdapters.DepositosEntidadTableAdapter
    Friend WithEvents dtaTipoAsignaciones As Oxigenos.Gases.PacientesDataSetTableAdapters.TipoAsignacionesTableAdapter
    Friend WithEvents dtaDepositosGarantia As Oxigenos.Gases.PacientesDataSetTableAdapters.DepositosGarantiaTableAdapter
    Friend WithEvents dtaAlquileresPagados As Oxigenos.Gases.PacientesDataSetTableAdapters.AlquileresPagadosTableAdapter
    Friend WithEvents dtaAutorizacionAsignacion As Oxigenos.Gases.PacientesDataSetTableAdapters.AutorizacionAsignacionTableAdapter
    Friend WithEvents dtaAutorizacionRemision As Oxigenos.Gases.PacientesDataSetTableAdapters.AutorizacionRemisionTableAdapter
    Friend WithEvents dtaAsignaciones As Oxigenos.Gases.PacientesDataSetTableAdapters.AsignacionesTableAdapter
    Friend WithEvents dtaAlquileresPendientes As Oxigenos.Gases.PacientesDataSetTableAdapters.AlquileresPendientesTableAdapter
    Friend WithEvents dtaDeudasPagadas As Oxigenos.Gases.PacientesDataSetTableAdapters.DeudasPagadasTableAdapter
    Friend WithEvents dtaMovimientoCopagosCuotas As Oxigenos.Gases.PacientesDataSetTableAdapters.MovimientoCopagosCuotasTableAdapter
    Friend WithEvents dtaClientes As Oxigenos.Gases.PacientesDataSetTableAdapters.ClientesTableAdapter
    Friend WithEvents dtaCopagosPorCobrar As Oxigenos.Gases.PacientesDataSetTableAdapters.CopagosPorCobrarTableAdapter

End Class
