Imports System.Data

Module Globales
    Public Settings As NucleoSettings

    Public GestorNucleo As NucleoDataAccess
    ''' <summary>
    ''' MTOVAR
    ''' </summary>
    ''' <remarks></remarks>
    Public GestorAnulaPedidos As GestorAnulacionPedidos
    Public GestorListQueries As GestorListaQueries
    Public GestorCargas As GestorCarga

    ''

    Public Const TIMEOUT_WEBSERVICE As Integer = 900000

#Region " Rutinas de ejecución dinámica de los módulos "

    Public Sub EjecutarModuloPrograma(ByVal modInfo As InfoModulo)
        ' Se valida la configuración del modulo
        If modInfo.ClassType Is Nothing Then
            UIHandler.ShowError("Modulo no configurado correctamente")
            Exit Sub
        End If
        Cursor.Current = Cursors.WaitCursor

        ' Se crea y se muestra el formulario asociado al módulo
        If modInfo.Tipo = TiposModulo.Nucleo Then
            ' Se hacen algunas validaciones
            If Not GetType(IModuloNucleo).IsAssignableFrom(modInfo.ClassType) Then
                UIHandler.ShowError(modInfo.ClassType.Name & " debe implementar IModuloNucleo")
                Exit Sub
            End If

            ' Se crea la instancia y se ejecuta el módulo
            Dim modulo As IModuloNucleo = CType(Activator.CreateInstance(modInfo.ClassType), IModuloNucleo)
            modulo.Run()
        Else
            If Not GetType(IModuloPrograma).IsAssignableFrom(modInfo.ClassType) Then
                UIHandler.ShowError(modInfo.ClassType.Name & " debe implementar IModuloPrograma")
                Exit Sub
            End If

            ' Se crea la instancia y se ejecuta el módulo
            Dim modulo As IModuloPrograma = CType(Activator.CreateInstance(modInfo.ClassType), IModuloPrograma)
            modulo.Run()
        End If

        Cursor.Current = Cursors.Default
    End Sub

    Public Sub EjecutarModuloRutero(ByVal modInfo As InfoModulo)
        ' Se valida la configuración del modulo
        If modInfo.ClassType Is Nothing Then
            UIHandler.ShowError("Modulo no configurado correctamente")
            Exit Sub
        End If
        If Not GetType(IModuloRutero).IsAssignableFrom(modInfo.ClassType) Then
            UIHandler.ShowError(modInfo.ClassType.Name & " debe implementar IModuloPrograma")
            Exit Sub
        End If

        ' Se crea la instancia y se ejecuta el módulo
        Dim modulo As IModuloRutero = CType(Activator.CreateInstance(modInfo.ClassType), IModuloRutero)
        modulo.Run()
    End Sub

    Public Sub EjecutarModuloPedido(ByVal modInfo As InfoModulo, ByVal rowCliente As DataRow, ByVal rowPedido As DataRow)
        ' ' Se valida la configuración del modulo
        If modInfo.ClassType Is Nothing Then
            UIHandler.ShowError("Modulo no configurado correctamente")
            Exit Sub
        End If
        If Not GetType(IModuloPedido).IsAssignableFrom(modInfo.ClassType) Then
            UIHandler.ShowError(modInfo.ClassType.Name & " debe implementar IModuloPrograma")
            Exit Sub
        End If

        ' Se crea la instancia y se ejecuta el módulo
        Dim modulo As IModuloPedido = CType(Activator.CreateInstance(modInfo.ClassType), IModuloPedido)
        modulo.Run(rowCliente, rowPedido)
    End Sub

    


#End Region

#Region " Rutinas de Manejo de los menus y teclas rapidas de los módulos"

    Public Sub CombinarMenusModulos(ByVal menuPrincipal As MenuItem, _
    ByVal InfoModulos As ListInfoModulos, _
    ByVal MenuModulosHandler As EventHandler)

        If InfoModulos.Count <= 0 Then
            Exit Sub
        End If

        Dim menuCopia As New MenuItem
        Dim menu As MenuItem
        Dim menuModulo As ModuloMenuItem
        Dim I As Integer
        
        ' Se hace una copia de los items del menú original
        For I = 0 To menuPrincipal.MenuItems.Count - 1
            menu = menuPrincipal.MenuItems(0)
            menuPrincipal.MenuItems.Remove(menu)
            menuCopia.MenuItems.Add(menu)
        Next

        ' Se agregan los menús dinamicos de los módulos
        For I = 0 To InfoModulos.Count - 1
            menuModulo = New ModuloMenuItem
            menuModulo.Text = InfoModulos(I).Nombre
            menuModulo.InfoModulo = InfoModulos(I)
            AddHandler menuModulo.Click, MenuModulosHandler
            menuPrincipal.MenuItems.Add(menuModulo)
        Next

        ' Se agrega un separador
        menu = New MenuItem
        menu.Text = "-"
        menuPrincipal.MenuItems.Add(menu)

        ' Se agregan los menus originales
        For I = 0 To menuCopia.MenuItems.Count - 1
            menu = menuCopia.MenuItems(0)
            menuCopia.MenuItems.Remove(menu)
            menuPrincipal.MenuItems.Add(menu)
        Next
    End Sub

    Public Function ProcessHotKeys(ByVal frm As Form, ByVal e As KeyEventArgs) As Boolean
        ' Se procesan las teclas del 
        If Settings.DeviceModel = DeviceModels.MC9090 Then
            Select Case CInt(e.KeyCode)
                Case &H7D
                    OpenNETCF.Windows.Forms.SendKeys.Send("{F1}")
                    e.Handled = True
                Case &H7E
                    OpenNETCF.Windows.Forms.SendKeys.Send("{F2}")
                    e.Handled = True
            End Select
        End If
        Return e.Handled
    End Function

#End Region

End Module
