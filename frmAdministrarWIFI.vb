Imports System
Imports System.Net
Imports System.Text
Imports System.Xml.XPath
Imports System.IO
Imports System.Xml


Public Class frmAdministrarWIFI
    Dim Cliente As WlanClient = New WlanClient()

    Public Structure sProfilDetail
        Dim SSID As String
        Dim SSIDhex As String
        Dim authentication As String
        Dim encryption As String
        Dim useOneX As String
        Dim keyType As String
        Dim isProtected As String
        Dim keyMaterial As String
        Dim keyIndex As String
    End Structure

    Function ProfileDetail(ByVal XMLProfile As String) As sProfilDetail
        Dim result As New sProfilDetail

        Dim document As XPathDocument = New XPathDocument(New StringReader(XMLProfile))
        Dim navigator As XPathNavigator = document.CreateNavigator()

        Dim manager As XmlNamespaceManager = New XmlNamespaceManager(navigator.NameTable)
        manager.AddNamespace("s", "http://www.microsoft.com/networking/WLAN/profile/v1")

        On Error Resume Next
        result.SSID = navigator.SelectSingleNode("/s:WLANProfile/s:name", manager).InnerXml
        result.SSIDhex = navigator.SelectSingleNode("/s:WLANProfile/s:SSIDConfig/s:SSID/s:hex", manager).InnerXml
        result.authentication = navigator.SelectSingleNode("/s:WLANProfile/s:MSM/s:security/s:authEncryption/s:authentication", manager).InnerXml
        result.encryption = navigator.SelectSingleNode("/s:WLANProfile/s:MSM/s:security/s:authEncryption/s:encryption", manager).InnerXml
        result.useOneX = navigator.SelectSingleNode("/s:WLANProfile/s:MSM/s:security/s:authEncryption/s:useOneX", manager).InnerXml
        result.keyType = navigator.SelectSingleNode("/s:WLANProfile/s:MSM/s:security/s:sharedKey/s:keyType", manager).InnerXml
        result.isProtected = navigator.SelectSingleNode("/s:WLANProfile/s:MSM/s:security/s:sharedKey/s:protected", manager).InnerXml
        result.keyMaterial = navigator.SelectSingleNode("/s:WLANProfile/s:MSM/s:security/s:sharedKey/s:keyMaterial", manager).InnerXml
        result.keyIndex = navigator.SelectSingleNode("/s:WLANProfile/s:MSM/s:security/s:keyIndex", manager).InnerXml

        Return result

    End Function

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lvwWifiDisponibles.View = View.Details 'Ver detalles en ListView
        lvwPerfilesGuardados.View = View.Details
        lvwPerfilesGuardados.HeaderStyle = ColumnHeaderStyle.None
        tmrConexionActual.Interval = 500
        tmrConexionActual.Enabled = True
    End Sub

    Private Sub btnCrearPerfilNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCrearPerfilNuevo.Click
        Call frmCrearPerfil.Show()
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)

    End Sub

    Private Sub tmrConexionActual_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrConexionActual.Tick
        For Each wlanIface As WlanClient.WlanInterface In Cliente.Interfaces

            If wlanIface.InterfaceState = Wlan.WlanInterfaceState.Connected = True Or wlanIface.InterfaceState = Wlan.WlanInterfaceState.AdHocNetworkFormed Then
                lblConectado_SiNo.Text = "¿Conectado?: Sí"
            Else
                lblConectado_SiNo.Text = "¿Conectado?: No"
            End If

            Select Case wlanIface.CurrentConnection.isState
                Case Wlan.WlanInterfaceState.AdHocNetworkFormed
                    lblEstadoConexion.Text = "Estado: Conectado en Ad-Hoc " & wlanIface.CurrentConnection.profileName
                Case Wlan.WlanInterfaceState.Associating
                    lblEstadoConexion.Text = "Estado: Asociación en curso..."
                Case Wlan.WlanInterfaceState.Authenticating
                    lblEstadoConexion.Text = "Estado: Autenticando..."
                Case Wlan.WlanInterfaceState.Connected
                    lblEstadoConexion.Text = "Estado: Conectado a " & """" & wlanIface.CurrentConnection.profileName & """"
                Case Wlan.WlanInterfaceState.Disconnected
                    lblEstadoConexion.Text = "Estado: Desconectado"
                Case Wlan.WlanInterfaceState.Disconnecting
                    lblEstadoConexion.Text = "Estado: Desconexión en curso..."
                Case Wlan.WlanInterfaceState.Discovering
                    lblEstadoConexion.Text = "Estado: Cargando..."
                Case Wlan.WlanInterfaceState.NotReady
                    lblEstadoConexion.Text = "Estado: No disponible"
            End Select

            If wlanIface.InterfaceState = Wlan.WlanInterfaceState.Connected Or wlanIface.InterfaceState = Wlan.WlanInterfaceState.AdHocNetworkFormed Then
                lblSSID.Text = "SSID: " & wlanIface.CurrentConnection.profileName
                lblIntensidadSeñal.Text = "Intensidad de señal: " & wlanIface.CurrentConnection.wlanAssociationAttributes.wlanSignalQuality & " %"
                lblSeguridad.Text = "Seguridad: " & wlanIface.CurrentConnection.wlanSecurityAttributes.securityEnabled
                lblTipoSeguridad.Text = "Tipo: " & wlanIface.CurrentConnection.wlanSecurityAttributes.dot11AuthAlgorithm.ToString
                lblCifrado.Text = "Cifrado: " & wlanIface.CurrentConnection.wlanSecurityAttributes.dot11CipherAlgorithm.ToString
                lblCanal.Text = "Canal : " & wlanIface.Channel
                Me.Text = "Administrador WIFI <API Windows> / Actualmente conectado a " & lblSSID.Text & " - Señal: " & lblIntensidadSeñal.Text
            Else
                lblSSID.Text = "SSID : -"
                Me.Text = "Administrador WIFI <API Windows>"
                lblIntensidadSeñal.Text = "Intensidad de señal: -"
                lblSeguridad.Text = "Seguridad: -"
                lblTipoSeguridad.Text = "Tipo: -"
                lblCifrado.Text = "Cifrado: -"
                lblCanal.Text = "Canal: -"

                lblEstadoConexion.Text = "Estado: Desconectado"
            End If

            Dim MAC = wlanIface.NetworkInterface.GetPhysicalAddress.ToString
            Dim adMAC = "" 'dim adMac As String
            For i = 1 To MAC.Length Step 2
                adMAC = adMAC & MAC.Substring(i - 1, 1) & MAC.Substring(i, 1) & "-" '&= MAC.Substring(i - 1, 1) & MAC.Substring(i, 1) & "-"
            Next

            Dim NombreHostLocal As String
            NombreHostLocal = Dns.GetHostName()
            Dim ipEnter As IPHostEntry = Dns.GetHostEntry(NombreHostLocal)
            Dim DirIP() As IPAddress = ipEnter.AddressList

            lblAdaptadorWireless.Text = wlanIface.InterfaceDescription 'adaptador wireless
            lblMAC.Text = "Dirección MAC Adap.: " & adMAC.Remove(adMAC.Length - 1)
            '=====================================
            '===== OBTENER IP ================
            'Dim nombre_Host As String = Dns.GetHostName
            'Dim este_Host As Net.IPHostEntry = Dns.GetHostEntry(nombre_Host)
            'Dim direccion_Ip As String = este_Host.AddressList(0).ToString
            'lblMiIP.Text = direccion_Ip
            '=Corregido=
            Dim Host As IPHostEntry
            Dim IPLocal As String = ""
            Host = Dns.GetHostEntry(Dns.GetHostName())
            For Each ip As IPAddress In Host.AddressList
                If ip.AddressFamily.ToString() = "InterNetwork" Then
                    IPLocal = ip.ToString()
                End If
            Next
            lblMiIP.Text = "IP Local: " + IPLocal


        Next
    End Sub

    Private Sub btnEscanearRedesDisponibles_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEscanearRedesDisponibles.Click
        lvwWifiDisponibles.Items.Clear()
        Dim Ver_SSID = ""
        Dim Ver_Señal As String = ""
        Dim Ver_Seguridad As String = ""
        Dim Ver_Cifrado As String = ""
        Dim Ver_Canal As String = ""


        For Each wlanIface As WlanClient.WlanInterface In Cliente.Interfaces
            'Listar todas las redes
            Dim networks As Wlan.WlanAvailableNetwork() = wlanIface.GetAvailableNetworkList(0)

            For Each network As Wlan.WlanAvailableNetwork In networks
                'El escaneo de redes inalámbrica consultando su arquitectura BSS
                If network.dot11BssType = Wlan.Dot11BssType.Any Then
                    Call ListarTodasLasRedesWLAN(Ver_SSID, Ver_Señal, Ver_Seguridad, Ver_Cifrado, Ver_Canal, network, wlanIface)
                End If

                If network.dot11BssType = Wlan.Dot11BssType.Infrastructure Then
                    Call ListarTodasLasRedesWLAN(Ver_SSID, Ver_Señal, Ver_Seguridad, Ver_Cifrado, Ver_Canal, network, wlanIface)
                End If

                If network.dot11BssType = Wlan.Dot11BssType.Independent Then
                    Call ListarTodasLasRedesWLAN(Ver_SSID, Ver_Señal, Ver_Seguridad, Ver_Cifrado, Ver_Canal, network, wlanIface)
                End If
            Next
        Next
    End Sub

    Private Shared Function GetStringForSSID(ByVal ssid As Wlan.Dot11Ssid) As String
        'Funcion necesaria para convertir un valor a string (precisamente a SSID)
        Return Encoding.ASCII.GetString(ssid.SSID, 0, CInt(ssid.SSIDLength))
    End Function

    Private Sub ListarTodasLasRedesWLAN(ByVal Ver_SSID As String, ByVal Ver_Señal As String, ByVal Ver_Seguridad As String, ByVal Ver_Cifrado As String, ByVal Ver_Canal As String, ByRef network As Wlan.WlanAvailableNetwork, ByRef wlanIface As WlanClient.WlanInterface)
        Dim SubItemsLV1 As New ListViewItem
        Ver_SSID = GetStringForSSID(network.dot11Ssid)
        Ver_Señal = network.wlanSignalQuality

        If network.dot11DefaultAuthAlgorithm = 1 Then Ver_Seguridad = "Abierta" ' estos datos lo saco yendo a la definicion de dot11DefaultAuthAlgorithm
        If network.dot11DefaultAuthAlgorithm = 2 Then Ver_Seguridad = "SharedKey"

        If network.dot11DefaultAuthAlgorithm = &HFFFFFFFF Then Ver_Seguridad = "IHV_End"
        If network.dot11DefaultAuthAlgorithm = &H80000000 Then Ver_Seguridad = "IHV_Start"
        If network.dot11DefaultAuthAlgorithm = 6 Then Ver_Seguridad = "RSNA"
        If network.dot11DefaultAuthAlgorithm = 7 Then Ver_Seguridad = "WPA2PSK"
        If network.dot11DefaultAuthAlgorithm = 3 Then Ver_Seguridad = "WPA"
        If network.dot11DefaultAuthAlgorithm = 5 Then Ver_Seguridad = "WPA_None"
        If network.dot11DefaultAuthAlgorithm = 4 Then Ver_Seguridad = "WPA_PSK"
        'Ver_Seguridad = network.dot11DefaultAuthAlgorithm
        If network.dot11DefaultCipherAlgorithm = 4 Then Ver_Cifrado = "CCMP" 'estos datos lo saco yendo a la definicion de dot11DefaultCipherAlgorithm
        If network.dot11DefaultCipherAlgorithm = &HFFFFFFFF Then Ver_Cifrado = "IHV_End"
        If network.dot11DefaultCipherAlgorithm = &H80000000 Then Ver_Cifrado = "IHV_Start"
        If network.dot11DefaultCipherAlgorithm = 0 Then Ver_Cifrado = "Deshabilitado"
        If network.dot11DefaultCipherAlgorithm = &H100 Then Ver_Cifrado = "RSN_UseGroup"
        If network.dot11DefaultCipherAlgorithm = 2 Then Ver_Cifrado = "TKIP"
        If network.dot11DefaultCipherAlgorithm = &H101 Then Ver_Cifrado = "WEP"
        If network.dot11DefaultCipherAlgorithm = 5 Then Ver_Cifrado = "WEP104"
        If network.dot11DefaultCipherAlgorithm = 1 Then Ver_Cifrado = "WEP40"
        If network.dot11DefaultCipherAlgorithm = &H100 Then Ver_Cifrado = "WPA_UseGroup"
        Ver_Canal = wlanIface.Channel

        SubItemsLV1.Text = Ver_SSID
        lvwWifiDisponibles.Items.Add(SubItemsLV1) 'Listar redes en ListView lvwWifiDisponibles
        SubItemsLV1.SubItems.Add(Ver_Señal & " %")
        SubItemsLV1.SubItems.Add(Ver_Seguridad)
        SubItemsLV1.SubItems.Add(Ver_Cifrado)
        SubItemsLV1.SubItems.Add(Ver_Canal)

    End Sub


    Private Sub btnActualizarPerfilesGuardados_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizarPerfilesGuardados.Click
        'Para listar todos los perfiles WLAN que estan registrados y que se hicieron uso
        'en la computadora, ya sea que estén o no disponibles para una conexión (ONLINE)
        lvwPerfilesGuardados.Items.Clear()

        For Each wlanIface As WlanClient.WlanInterface In Cliente.Interfaces
            'wlanIface.Scan()
            Dim networks As Wlan.WlanProfileInfo() = wlanIface.GetProfiles
            For Each network As Wlan.WlanProfileInfo In networks
                If network.profileName = "" Then Continue For
                Dim SubItemsListViewPerfilesGuardados As New ListViewItem
                lvwPerfilesGuardados.Items.Add(network.profileName)
            Next
        Next
    End Sub

    Private Sub btnEliminarPerfilGuardado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarPerfilGuardado.Click
        Call EliminarPerfil(lvwPerfilesGuardados)
        Call btnActualizarPerfilesGuardados_Click(Nothing, Nothing)
    End Sub

    Private Function EliminarPerfil(ByRef ListViewNumeroo As ListView)
        If ListViewNumeroo.SelectedItems.Count = 0 Then
            MsgBox("No se ha selccionado ninguna Red WLAN", MsgBoxStyle.Information, "Atención")
            Return 0
            Exit Function
        End If

        Dim wlanIface As WlanClient.WlanInterface = cliente.Interfaces(0)
        Dim r = ListViewNumeroo.SelectedItems(ListViewNumeroo.SelectedItems.Count - 1).Text

        ' MsgBox(r)
        Dim res As MsgBoxResult
        res = MsgBox("¿Seguro que desea eliminar el perfil """ & r & """ de la lista de favoritos?", MsgBoxStyle.YesNo, "Eliminar Perfil")
        If res = MsgBoxResult.No Then
            Return Nothing
            Exit Function
        End If

        If res = MsgBoxResult.Yes Then
            wlanIface.DeleteProfile(r)
            'Call ActualizarLV(Nothing, Nothing) 'actualizar (no envio parametros)
        End If

        MsgBox("El perfil """ & r & """ ha sido eliminado", MsgBoxStyle.Information)
        Return Nothing
    End Function

    Private Sub btnEscanearRedesGuardadas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEscanearRedesGuardadas.Click
        'Para listar todos los perfiles WLAN disponibles para una conexión
        lvwRedesGuardadas.Items.Clear()

        For Each wlanIface As WlanClient.WlanInterface In Cliente.Interfaces
            wlanIface.Scan()
            Dim networks As Wlan.WlanAvailableNetwork() = wlanIface.GetAvailableNetworkList(Wlan.WlanGetAvailableNetworkFlags.IncludeAllAdhocProfiles)

            For Each network As Wlan.WlanAvailableNetwork In networks
                If network.profileName = "" Then Continue For

                Dim SubItemsLV2 As New ListViewItem
                SubItemsLV2.Text = network.profileName
                lvwRedesGuardadas.Items.Add(SubItemsLV2)
                SubItemsLV2.SubItems.Add(network.wlanSignalQuality & " %")

                'Modo de autenticación
                If network.dot11DefaultAuthAlgorithm = 1 Then SubItemsLV2.SubItems.Add("Open") ' estos datos lo saco yendo a la definicion de dot11DefaultAuthAlgorithm
                If network.dot11DefaultAuthAlgorithm = 2 Then SubItemsLV2.SubItems.Add("SharedKey")
                If network.dot11DefaultAuthAlgorithm = &HFFFFFFFF Then SubItemsLV2.SubItems.Add("IHV_End")
                If network.dot11DefaultAuthAlgorithm = &H80000000 Then SubItemsLV2.SubItems.Add("IHV_Start")
                If network.dot11DefaultAuthAlgorithm = 6 Then SubItemsLV2.SubItems.Add("RSNA")
                If network.dot11DefaultAuthAlgorithm = 7 Then SubItemsLV2.SubItems.Add("WPA2PSK")
                If network.dot11DefaultAuthAlgorithm = 3 Then SubItemsLV2.SubItems.Add("WPA")
                If network.dot11DefaultAuthAlgorithm = 5 Then SubItemsLV2.SubItems.Add("WPA_None")
                If network.dot11DefaultAuthAlgorithm = 4 Then SubItemsLV2.SubItems.Add("WPA_PSK")
                'Cifrado()
                If network.dot11DefaultCipherAlgorithm = 4 Then SubItemsLV2.SubItems.Add("CCMP") 'estos datos lo saco yendo a la definicion de dot11DefaultCipherAlgorithm
                If network.dot11DefaultCipherAlgorithm = &HFFFFFFFF Then SubItemsLV2.SubItems.Add("IHV_End")
                If network.dot11DefaultCipherAlgorithm = &H80000000 Then SubItemsLV2.SubItems.Add("IHV_Start")
                If network.dot11DefaultCipherAlgorithm = 0 Then SubItemsLV2.SubItems.Add("None")
                If network.dot11DefaultCipherAlgorithm = &H100 Then SubItemsLV2.SubItems.Add("RSN_UseGroup")
                If network.dot11DefaultCipherAlgorithm = 2 Then SubItemsLV2.SubItems.Add("TKIP")
                If network.dot11DefaultCipherAlgorithm = &H101 Then SubItemsLV2.SubItems.Add("WEP")
                If network.dot11DefaultCipherAlgorithm = 5 Then SubItemsLV2.SubItems.Add("WEP104")
                If network.dot11DefaultCipherAlgorithm = 1 Then SubItemsLV2.SubItems.Add("WEP40")
                If network.dot11DefaultCipherAlgorithm = &H100 Then SubItemsLV2.SubItems.Add("WPA_UseGroup")
                SubItemsLV2.SubItems.Add(wlanIface.Channel)
            Next

        Next
    End Sub

    Private Sub btnConectarRedGuardada_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConectarRedGuardada.Click
        Call ConectarAWlanSeleccionada(lvwRedesGuardadas)
    End Sub

    Private Sub ConectarAWlanSeleccionada(ByRef ListViewNumeroo As ListView)
        If ListViewNumeroo.SelectedItems.Count = 0 Then
            MsgBox("No se ha selccionado ninguna Red WLAN", MsgBoxStyle.Information)
            Exit Sub
        End If

        Dim r = ListViewNumeroo.SelectedItems(ListViewNumeroo.SelectedItems.Count - 1).Text

        For Each wlanIface As WlanClient.WlanInterface In cliente.Interfaces
            Dim xmlDATA = wlanIface.GetProfileXml(r)
            'MsgBox(xmlDATA)
            Dim detail As sProfilDetail = ProfileDetail(xmlDATA)

            On Error Resume Next

            wlanIface.SetProfile(Wlan.WlanProfileFlags.AllUser, xmlDATA, True)
            wlanIface.Connect(Wlan.WlanConnectionMode.Profile, Wlan.Dot11BssType.Any, detail.SSID)
        Next
    End Sub

    Private Sub btnConectarDesconectar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConectarDesconectar.Click
        Dim wlanIface As WlanClient.WlanInterface = Cliente.Interfaces(0)
        wlanIface.Disconnect()
    End Sub

    Private Sub btnEliminarRedGuardada_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarRedGuardada.Click
        Call EliminarPerfil(lvwRedesGuardadas)
        Call btnEscanearRedesGuardadas_Click(Nothing, Nothing)
    End Sub
End Class
