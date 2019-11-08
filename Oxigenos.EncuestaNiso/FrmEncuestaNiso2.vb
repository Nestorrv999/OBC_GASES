Public Class FrmEncuestaNiso2

    Public Satisfecho1 As Boolean
    Public insatisfecho1 As Boolean

    Public Satisfecho2 As Boolean
    Public insatisfecho2 As Boolean

    Public codi_cli As String


    Private Sub Label1_ParentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.ParentChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim ws As New wsNiso.WebService1
        Dim rsta As New wsNiso.Respuesta
        rsta.CODI_CLI = ParametrosIniciales.codigoCliente

        rsta.CORREO_ELECTRONICO = Me.txtCorreo.Text
        rsta.ESTADO_REGISTRO = 1
        rsta.FECHA_GESTION = Date.Now()
        rsta.FECHA_RESPUESTA = Date.Now()
        rsta.ID_ORIGEN = ParametrosIniciales.origen

        rsta.ID_PREGUNTA = 1
        rsta.ID_RESPUESTA = IIf(Me.Satisfecho1 = True, 1, 2)
        rsta.NOMBRE = Me.txtNombre.Text
        rsta.TELEFONO = Me.txtTelefono.Text

        rsta.CORREO_ELECTRONICO = Me.txtCorreo.Text & "@" & txtDominio.Text

        Dim rsta2 As New wsNiso.Respuesta
        rsta2.CODI_CLI = ParametrosIniciales.codigoCliente
        rsta2.CORREO_ELECTRONICO = Me.txtTelefono.Text
        rsta2.ESTADO_REGISTRO = 1
        rsta2.FECHA_GESTION = Date.Now()
        rsta2.FECHA_RESPUESTA = Date.Now()
        rsta2.ID_ORIGEN = ParametrosIniciales.origen
        rsta2.ID_PREGUNTA = 2
        rsta2.ID_RESPUESTA = IIf(Me.Satisfecho2 = True, 1, 2)
        rsta2.NOMBRE = Me.txtNombre.Text
        rsta2.TELEFONO = Me.txtTelefono.Text
        rsta2.CORREO_ELECTRONICO = Me.txtCorreo.Text & "@" & txtDominio.Text


        Dim bool1 As Boolean
        Dim bool2 As Boolean

        Try

      
            ws.AlmacenarPregunta(rsta)
            ws.AlmacenarPregunta(rsta2)

            MessageBox.Show("Registro almacenado con exito")
            Me.Dispose()


        Catch ex As Exception

        End Try



    End Sub
End Class