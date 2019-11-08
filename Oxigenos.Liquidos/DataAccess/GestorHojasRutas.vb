Public Class GestorHojasRutas

    Public ReadOnly Property HojaActual() As HojasRutaDataSet.HojasRutaRow
        Get
            Return Me.dsHojasRuta.HojasRuta(0)
        End Get
    End Property

    Public Sub LoadLugaresCarga()
        dtaLugaresCarga.Connection = Me.Connection
        dtaLugaresCarga.Fill(Me.dsHojasRuta.LugaresCarga)
    End Sub

    Public Sub LoadChoferes()
        dtaChoferes.Connection = Me.Connection
        dtaChoferes.Fill(Me.dsHojasRuta.Choferes)
    End Sub

    Public Sub LoadHojaRutaActual()
        dtaHojasRuta.Connection = Me.Connection
        dtaHojasRuta.FillByEstadoNoEs(Me.dsHojasRuta.HojasRuta, EstadosHojaRuta.Cerrada)
    End Sub

    Public Sub UpdateHojaRuta(ByVal row As HojasRutaDataSet.HojasRutaRow)
        dtaHojasRuta.Connection = Me.Connection
        dtaHojasRuta.Update(row)
        row.AcceptChanges()
    End Sub

    Public Sub LoadTractores()
        dtaTractores.Connection = Me.Connection
        dtaTractores.Fill(Me.dsHojasRuta.Tractores)
    End Sub

    Public Sub LoadTanqueros(ByVal CodProducto As String)
        dtaTanqueros.Connection = Me.Connection
        dtaTanqueros.FillByProducto(dsHojasRuta.Tanqueros, CodProducto)
    End Sub

End Class
