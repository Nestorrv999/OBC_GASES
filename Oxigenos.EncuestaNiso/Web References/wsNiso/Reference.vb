﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Este código fue generado por una herramienta.
'     Versión del motor en tiempo de ejecución:2.0.50727.5420
'
'     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
'     se vuelve a generar el código.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.Xml.Serialization

'
'Microsoft.CompactFramework.Design.Data generó automáticamente este código fuente, versión=2.0.50727.5420.
'
Namespace wsNiso
    
    '''<remarks/>
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Web.Services.WebServiceBindingAttribute(Name:="WebService1Soap", [Namespace]:="http://tempuri.org/")>  _
    Partial Public Class WebService1
        Inherits System.Web.Services.Protocols.SoapHttpClientProtocol
        
        '''<remarks/>
        Public Sub New()
            MyBase.New
            Me.Url = "http://201.234.244.37/WsNiso/WebService1.asmx"
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ActualizarEstadoRegistro", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function ActualizarEstadoRegistro(ByVal id As Integer, ByVal estado As String, ByVal usrid As Integer) As Boolean
            Dim results() As Object = Me.Invoke("ActualizarEstadoRegistro", New Object() {id, estado, usrid})
            Return CType(results(0),Boolean)
        End Function
        
        '''<remarks/>
        Public Function BeginActualizarEstadoRegistro(ByVal id As Integer, ByVal estado As String, ByVal usrid As Integer, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("ActualizarEstadoRegistro", New Object() {id, estado, usrid}, callback, asyncState)
        End Function
        
        '''<remarks/>
        Public Function EndActualizarEstadoRegistro(ByVal asyncResult As System.IAsyncResult) As Boolean
            Dim results() As Object = Me.EndInvoke(asyncResult)
            Return CType(results(0),Boolean)
        End Function
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ActualizarGestion", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function ActualizarGestion(ByVal id As Integer, ByVal gestionRealizada As String, ByVal aplicaSqr As Boolean, ByVal IdSqr As String, ByVal usrId As Integer) As Boolean
            Dim results() As Object = Me.Invoke("ActualizarGestion", New Object() {id, gestionRealizada, aplicaSqr, IdSqr, usrId})
            Return CType(results(0),Boolean)
        End Function
        
        '''<remarks/>
        Public Function BeginActualizarGestion(ByVal id As Integer, ByVal gestionRealizada As String, ByVal aplicaSqr As Boolean, ByVal IdSqr As String, ByVal usrId As Integer, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("ActualizarGestion", New Object() {id, gestionRealizada, aplicaSqr, IdSqr, usrId}, callback, asyncState)
        End Function
        
        '''<remarks/>
        Public Function EndActualizarGestion(ByVal asyncResult As System.IAsyncResult) As Boolean
            Dim results() As Object = Me.EndInvoke(asyncResult)
            Return CType(results(0),Boolean)
        End Function
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ActualizarPregunta", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function ActualizarPregunta(ByVal rst As Respuesta) As Boolean
            Dim results() As Object = Me.Invoke("ActualizarPregunta", New Object() {rst})
            Return CType(results(0),Boolean)
        End Function
        
        '''<remarks/>
        Public Function BeginActualizarPregunta(ByVal rst As Respuesta, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("ActualizarPregunta", New Object() {rst}, callback, asyncState)
        End Function
        
        '''<remarks/>
        Public Function EndActualizarPregunta(ByVal asyncResult As System.IAsyncResult) As Boolean
            Dim results() As Object = Me.EndInvoke(asyncResult)
            Return CType(results(0),Boolean)
        End Function
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/AlmacenarPregunta", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function AlmacenarPregunta(ByVal rst As Respuesta) As Boolean
            Dim results() As Object = Me.Invoke("AlmacenarPregunta", New Object() {rst})
            Return CType(results(0),Boolean)
        End Function
        
        '''<remarks/>
        Public Function BeginAlmacenarPregunta(ByVal rst As Respuesta, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("AlmacenarPregunta", New Object() {rst}, callback, asyncState)
        End Function
        
        '''<remarks/>
        Public Function EndAlmacenarPregunta(ByVal asyncResult As System.IAsyncResult) As Boolean
            Dim results() As Object = Me.EndInvoke(asyncResult)
            Return CType(results(0),Boolean)
        End Function
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/EnviarMail", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function EnviarMail(ByVal [to] As String, ByVal mensaje As String) As Boolean
            Dim results() As Object = Me.Invoke("EnviarMail", New Object() {[to], mensaje})
            Return CType(results(0),Boolean)
        End Function
        
        '''<remarks/>
        Public Function BeginEnviarMail(ByVal [to] As String, ByVal mensaje As String, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("EnviarMail", New Object() {[to], mensaje}, callback, asyncState)
        End Function
        
        '''<remarks/>
        Public Function EndEnviarMail(ByVal asyncResult As System.IAsyncResult) As Boolean
            Dim results() As Object = Me.EndInvoke(asyncResult)
            Return CType(results(0),Boolean)
        End Function
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetCliente", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function GetCliente(ByVal CodigoCliente As String) As System.Data.DataSet
            Dim results() As Object = Me.Invoke("GetCliente", New Object() {CodigoCliente})
            Return CType(results(0),System.Data.DataSet)
        End Function
        
        '''<remarks/>
        Public Function BeginGetCliente(ByVal CodigoCliente As String, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("GetCliente", New Object() {CodigoCliente}, callback, asyncState)
        End Function
        
        '''<remarks/>
        Public Function EndGetCliente(ByVal asyncResult As System.IAsyncResult) As System.Data.DataSet
            Dim results() As Object = Me.EndInvoke(asyncResult)
            Return CType(results(0),System.Data.DataSet)
        End Function
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetClienteOtro", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function GetClienteOtro(ByVal CodigoCliente As String) As System.Data.DataSet
            Dim results() As Object = Me.Invoke("GetClienteOtro", New Object() {CodigoCliente})
            Return CType(results(0),System.Data.DataSet)
        End Function
        
        '''<remarks/>
        Public Function BeginGetClienteOtro(ByVal CodigoCliente As String, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("GetClienteOtro", New Object() {CodigoCliente}, callback, asyncState)
        End Function
        
        '''<remarks/>
        Public Function EndGetClienteOtro(ByVal asyncResult As System.IAsyncResult) As System.Data.DataSet
            Dim results() As Object = Me.EndInvoke(asyncResult)
            Return CType(results(0),System.Data.DataSet)
        End Function
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetEstadosRegistros", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function GetEstadosRegistros() As EstadoRegistro()
            Dim results() As Object = Me.Invoke("GetEstadosRegistros", New Object(-1) {})
            Return CType(results(0),EstadoRegistro())
        End Function
        
        '''<remarks/>
        Public Function BeginGetEstadosRegistros(ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("GetEstadosRegistros", New Object(-1) {}, callback, asyncState)
        End Function
        
        '''<remarks/>
        Public Function EndGetEstadosRegistros(ByVal asyncResult As System.IAsyncResult) As EstadoRegistro()
            Dim results() As Object = Me.EndInvoke(asyncResult)
            Return CType(results(0),EstadoRegistro())
        End Function
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetOrigenes", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function GetOrigenes() As Origen()
            Dim results() As Object = Me.Invoke("GetOrigenes", New Object(-1) {})
            Return CType(results(0),Origen())
        End Function
        
        '''<remarks/>
        Public Function BeginGetOrigenes(ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("GetOrigenes", New Object(-1) {}, callback, asyncState)
        End Function
        
        '''<remarks/>
        Public Function EndGetOrigenes(ByVal asyncResult As System.IAsyncResult) As Origen()
            Dim results() As Object = Me.EndInvoke(asyncResult)
            Return CType(results(0),Origen())
        End Function
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetPreguntas", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function GetPreguntas() As Pregunta()
            Dim results() As Object = Me.Invoke("GetPreguntas", New Object(-1) {})
            Return CType(results(0),Pregunta())
        End Function
        
        '''<remarks/>
        Public Function BeginGetPreguntas(ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("GetPreguntas", New Object(-1) {}, callback, asyncState)
        End Function
        
        '''<remarks/>
        Public Function EndGetPreguntas(ByVal asyncResult As System.IAsyncResult) As Pregunta()
            Dim results() As Object = Me.EndInvoke(asyncResult)
            Return CType(results(0),Pregunta())
        End Function
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetRespuestas", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function GetRespuestas(ByVal fechaIni As Date, ByVal FechaFin As Date, ByVal estado As String) As System.Data.DataSet
            Dim results() As Object = Me.Invoke("GetRespuestas", New Object() {fechaIni, FechaFin, estado})
            Return CType(results(0),System.Data.DataSet)
        End Function
        
        '''<remarks/>
        Public Function BeginGetRespuestas(ByVal fechaIni As Date, ByVal FechaFin As Date, ByVal estado As String, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("GetRespuestas", New Object() {fechaIni, FechaFin, estado}, callback, asyncState)
        End Function
        
        '''<remarks/>
        Public Function EndGetRespuestas(ByVal asyncResult As System.IAsyncResult) As System.Data.DataSet
            Dim results() As Object = Me.EndInvoke(asyncResult)
            Return CType(results(0),System.Data.DataSet)
        End Function
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetSeguimiento", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function GetSeguimiento(ByVal id As Integer) As System.Data.DataSet
            Dim results() As Object = Me.Invoke("GetSeguimiento", New Object() {id})
            Return CType(results(0),System.Data.DataSet)
        End Function
        
        '''<remarks/>
        Public Function BeginGetSeguimiento(ByVal id As Integer, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("GetSeguimiento", New Object() {id}, callback, asyncState)
        End Function
        
        '''<remarks/>
        Public Function EndGetSeguimiento(ByVal asyncResult As System.IAsyncResult) As System.Data.DataSet
            Dim results() As Object = Me.EndInvoke(asyncResult)
            Return CType(results(0),System.Data.DataSet)
        End Function
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetTipoRespuestas", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function GetTipoRespuestas(ByVal preg As Pregunta) As Respuesta()
            Dim results() As Object = Me.Invoke("GetTipoRespuestas", New Object() {preg})
            Return CType(results(0),Respuesta())
        End Function
        
        '''<remarks/>
        Public Function BeginGetTipoRespuestas(ByVal preg As Pregunta, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("GetTipoRespuestas", New Object() {preg}, callback, asyncState)
        End Function
        
        '''<remarks/>
        Public Function EndGetTipoRespuestas(ByVal asyncResult As System.IAsyncResult) As Respuesta()
            Dim results() As Object = Me.EndInvoke(asyncResult)
            Return CType(results(0),Respuesta())
        End Function
    End Class
    
    '''<comentarios/>
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://tempuri.org/")>  _
    Partial Public Class Respuesta
        
        Private idField As Integer
        
        Private cODI_CLIField As String
        
        Private iD_PREGUNTAField As Integer
        
        Private iD_RESPUESTAField As Integer
        
        Private fECHA_RESPUESTAField As Date
        
        Private cORREO_ELECTRONICOField As String
        
        Private tELEFONOField As String
        
        Private nOMBREField As String
        
        Private eSTADO_REGISTROField As String
        
        Private uSRID_GESTIONField As String
        
        Private fECHA_GESTIONField As Date
        
        Private iD_ORIGENField As String
        
        Private gestionRealizadaField As String
        
        '''<comentarios/>
        Public Property ID() As Integer
            Get
                Return Me.idField
            End Get
            Set
                Me.idField = value
            End Set
        End Property
        
        '''<comentarios/>
        Public Property CODI_CLI() As String
            Get
                Return Me.cODI_CLIField
            End Get
            Set
                Me.cODI_CLIField = value
            End Set
        End Property
        
        '''<comentarios/>
        Public Property ID_PREGUNTA() As Integer
            Get
                Return Me.iD_PREGUNTAField
            End Get
            Set
                Me.iD_PREGUNTAField = value
            End Set
        End Property
        
        '''<comentarios/>
        Public Property ID_RESPUESTA() As Integer
            Get
                Return Me.iD_RESPUESTAField
            End Get
            Set
                Me.iD_RESPUESTAField = value
            End Set
        End Property
        
        '''<comentarios/>
        Public Property FECHA_RESPUESTA() As Date
            Get
                Return Me.fECHA_RESPUESTAField
            End Get
            Set
                Me.fECHA_RESPUESTAField = value
            End Set
        End Property
        
        '''<comentarios/>
        Public Property CORREO_ELECTRONICO() As String
            Get
                Return Me.cORREO_ELECTRONICOField
            End Get
            Set
                Me.cORREO_ELECTRONICOField = value
            End Set
        End Property
        
        '''<comentarios/>
        Public Property TELEFONO() As String
            Get
                Return Me.tELEFONOField
            End Get
            Set
                Me.tELEFONOField = value
            End Set
        End Property
        
        '''<comentarios/>
        Public Property NOMBRE() As String
            Get
                Return Me.nOMBREField
            End Get
            Set
                Me.nOMBREField = value
            End Set
        End Property
        
        '''<comentarios/>
        Public Property ESTADO_REGISTRO() As String
            Get
                Return Me.eSTADO_REGISTROField
            End Get
            Set
                Me.eSTADO_REGISTROField = value
            End Set
        End Property
        
        '''<comentarios/>
        Public Property USRID_GESTION() As String
            Get
                Return Me.uSRID_GESTIONField
            End Get
            Set
                Me.uSRID_GESTIONField = value
            End Set
        End Property
        
        '''<comentarios/>
        Public Property FECHA_GESTION() As Date
            Get
                Return Me.fECHA_GESTIONField
            End Get
            Set
                Me.fECHA_GESTIONField = value
            End Set
        End Property
        
        '''<comentarios/>
        Public Property ID_ORIGEN() As String
            Get
                Return Me.iD_ORIGENField
            End Get
            Set
                Me.iD_ORIGENField = value
            End Set
        End Property
        
        '''<comentarios/>
        Public Property GestionRealizada() As String
            Get
                Return Me.gestionRealizadaField
            End Get
            Set
                Me.gestionRealizadaField = value
            End Set
        End Property
    End Class
    
    '''<comentarios/>
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://tempuri.org/")>  _
    Partial Public Class Pregunta
        
        Private iD_PREGUNTAField As Integer
        
        Private dESCRIPCIONField As String
        
        '''<comentarios/>
        Public Property ID_PREGUNTA() As Integer
            Get
                Return Me.iD_PREGUNTAField
            End Get
            Set
                Me.iD_PREGUNTAField = value
            End Set
        End Property
        
        '''<comentarios/>
        Public Property DESCRIPCION() As String
            Get
                Return Me.dESCRIPCIONField
            End Get
            Set
                Me.dESCRIPCIONField = value
            End Set
        End Property
    End Class
    
    '''<comentarios/>
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://tempuri.org/")>  _
    Partial Public Class Origen
        
        Private iD_ORIGENField As Integer
        
        Private nOMBREField As String
        
        '''<comentarios/>
        Public Property ID_ORIGEN() As Integer
            Get
                Return Me.iD_ORIGENField
            End Get
            Set
                Me.iD_ORIGENField = value
            End Set
        End Property
        
        '''<comentarios/>
        Public Property NOMBRE() As String
            Get
                Return Me.nOMBREField
            End Get
            Set
                Me.nOMBREField = value
            End Set
        End Property
    End Class
    
    '''<comentarios/>
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://tempuri.org/")>  _
    Partial Public Class EstadoRegistro
        
        Private id_estadoField As String
        
        Private descripcionField As String
        
        '''<comentarios/>
        Public Property id_estado() As String
            Get
                Return Me.id_estadoField
            End Get
            Set
                Me.id_estadoField = value
            End Set
        End Property
        
        '''<comentarios/>
        Public Property descripcion() As String
            Get
                Return Me.descripcionField
            End Get
            Set
                Me.descripcionField = value
            End Set
        End Property
    End Class
End Namespace
