<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdministrarWIFI
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.gbxInfoWifi = New System.Windows.Forms.GroupBox()
        Me.btnConectarDesconectar = New System.Windows.Forms.Button()
        Me.lblMAC = New System.Windows.Forms.Label()
        Me.lblAdaptadorWireless = New System.Windows.Forms.Label()
        Me.lblMiIP = New System.Windows.Forms.Label()
        Me.lblCanal = New System.Windows.Forms.Label()
        Me.lblCifrado = New System.Windows.Forms.Label()
        Me.lblTipoSeguridad = New System.Windows.Forms.Label()
        Me.lblSeguridad = New System.Windows.Forms.Label()
        Me.lblIntensidadSeñal = New System.Windows.Forms.Label()
        Me.lblSSID = New System.Windows.Forms.Label()
        Me.lblEstadoConexion = New System.Windows.Forms.Label()
        Me.lblConectado_SiNo = New System.Windows.Forms.Label()
        Me.gbxRedesDisponibles = New System.Windows.Forms.GroupBox()
        Me.btnCrearPerfilNuevo = New System.Windows.Forms.Button()
        Me.btnEscanearRedesDisponibles = New System.Windows.Forms.Button()
        Me.lvwWifiDisponibles = New System.Windows.Forms.ListView()
        Me.colSSID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colSeñal = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colAutenticacionDeRed = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colCifradoDeDatos = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colCanal = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.gbxPerfilesGuardados = New System.Windows.Forms.GroupBox()
        Me.btnEliminarPerfilGuardado = New System.Windows.Forms.Button()
        Me.btnActualizarPerfilesGuardados = New System.Windows.Forms.Button()
        Me.gbxRedesGuardadas = New System.Windows.Forms.GroupBox()
        Me.btnEliminarRedGuardada = New System.Windows.Forms.Button()
        Me.btnConectarRedGuardada = New System.Windows.Forms.Button()
        Me.btnEscanearRedesGuardadas = New System.Windows.Forms.Button()
        Me.lvwRedesGuardadas = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.gbxInfoRed = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lvwInfoRed = New System.Windows.Forms.ListView()
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tmrConexionActual = New System.Windows.Forms.Timer(Me.components)
        Me.lvwPerfilesGuardados = New System.Windows.Forms.ListView()
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.gbxInfoWifi.SuspendLayout()
        Me.gbxRedesDisponibles.SuspendLayout()
        Me.gbxPerfilesGuardados.SuspendLayout()
        Me.gbxRedesGuardadas.SuspendLayout()
        Me.gbxInfoRed.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbxInfoWifi
        '
        Me.gbxInfoWifi.Controls.Add(Me.btnConectarDesconectar)
        Me.gbxInfoWifi.Controls.Add(Me.lblMAC)
        Me.gbxInfoWifi.Controls.Add(Me.lblAdaptadorWireless)
        Me.gbxInfoWifi.Controls.Add(Me.lblMiIP)
        Me.gbxInfoWifi.Controls.Add(Me.lblCanal)
        Me.gbxInfoWifi.Controls.Add(Me.lblCifrado)
        Me.gbxInfoWifi.Controls.Add(Me.lblTipoSeguridad)
        Me.gbxInfoWifi.Controls.Add(Me.lblSeguridad)
        Me.gbxInfoWifi.Controls.Add(Me.lblIntensidadSeñal)
        Me.gbxInfoWifi.Controls.Add(Me.lblSSID)
        Me.gbxInfoWifi.Controls.Add(Me.lblEstadoConexion)
        Me.gbxInfoWifi.Controls.Add(Me.lblConectado_SiNo)
        Me.gbxInfoWifi.Location = New System.Drawing.Point(18, 13)
        Me.gbxInfoWifi.Name = "gbxInfoWifi"
        Me.gbxInfoWifi.Size = New System.Drawing.Size(324, 229)
        Me.gbxInfoWifi.TabIndex = 0
        Me.gbxInfoWifi.TabStop = False
        Me.gbxInfoWifi.Text = "Información conexión WIFI actual"
        '
        'btnConectarDesconectar
        '
        Me.btnConectarDesconectar.Location = New System.Drawing.Point(171, 25)
        Me.btnConectarDesconectar.Name = "btnConectarDesconectar"
        Me.btnConectarDesconectar.Size = New System.Drawing.Size(139, 23)
        Me.btnConectarDesconectar.TabIndex = 11
        Me.btnConectarDesconectar.Text = "btnConectarDesconectar"
        Me.btnConectarDesconectar.UseVisualStyleBackColor = True
        '
        'lblMAC
        '
        Me.lblMAC.AutoSize = True
        Me.lblMAC.Location = New System.Drawing.Point(6, 204)
        Me.lblMAC.Name = "lblMAC"
        Me.lblMAC.Size = New System.Drawing.Size(40, 13)
        Me.lblMAC.TabIndex = 10
        Me.lblMAC.Text = "lblMAC"
        '
        'lblAdaptadorWireless
        '
        Me.lblAdaptadorWireless.AutoSize = True
        Me.lblAdaptadorWireless.Location = New System.Drawing.Point(6, 182)
        Me.lblAdaptadorWireless.Name = "lblAdaptadorWireless"
        Me.lblAdaptadorWireless.Size = New System.Drawing.Size(106, 13)
        Me.lblAdaptadorWireless.TabIndex = 9
        Me.lblAdaptadorWireless.Text = "lblAdaptadorWireless"
        '
        'lblMiIP
        '
        Me.lblMiIP.AutoSize = True
        Me.lblMiIP.Location = New System.Drawing.Point(6, 159)
        Me.lblMiIP.Name = "lblMiIP"
        Me.lblMiIP.Size = New System.Drawing.Size(38, 13)
        Me.lblMiIP.TabIndex = 8
        Me.lblMiIP.Text = "lblMiIP"
        '
        'lblCanal
        '
        Me.lblCanal.AutoSize = True
        Me.lblCanal.Location = New System.Drawing.Point(6, 137)
        Me.lblCanal.Name = "lblCanal"
        Me.lblCanal.Size = New System.Drawing.Size(44, 13)
        Me.lblCanal.TabIndex = 7
        Me.lblCanal.Text = "lblCanal"
        '
        'lblCifrado
        '
        Me.lblCifrado.AutoSize = True
        Me.lblCifrado.Location = New System.Drawing.Point(6, 114)
        Me.lblCifrado.Name = "lblCifrado"
        Me.lblCifrado.Size = New System.Drawing.Size(50, 13)
        Me.lblCifrado.TabIndex = 6
        Me.lblCifrado.Text = "lblCifrado"
        '
        'lblTipoSeguridad
        '
        Me.lblTipoSeguridad.AutoSize = True
        Me.lblTipoSeguridad.Location = New System.Drawing.Point(152, 95)
        Me.lblTipoSeguridad.Name = "lblTipoSeguridad"
        Me.lblTipoSeguridad.Size = New System.Drawing.Size(86, 13)
        Me.lblTipoSeguridad.TabIndex = 5
        Me.lblTipoSeguridad.Text = "lblTipoSeguridad"
        '
        'lblSeguridad
        '
        Me.lblSeguridad.AutoSize = True
        Me.lblSeguridad.Location = New System.Drawing.Point(6, 95)
        Me.lblSeguridad.Name = "lblSeguridad"
        Me.lblSeguridad.Size = New System.Drawing.Size(65, 13)
        Me.lblSeguridad.TabIndex = 4
        Me.lblSeguridad.Text = "lblSeguridad"
        '
        'lblIntensidadSeñal
        '
        Me.lblIntensidadSeñal.AutoSize = True
        Me.lblIntensidadSeñal.Location = New System.Drawing.Point(152, 72)
        Me.lblIntensidadSeñal.Name = "lblIntensidadSeñal"
        Me.lblIntensidadSeñal.Size = New System.Drawing.Size(93, 13)
        Me.lblIntensidadSeñal.TabIndex = 3
        Me.lblIntensidadSeñal.Text = "lblIntensidadSeñal"
        '
        'lblSSID
        '
        Me.lblSSID.AutoSize = True
        Me.lblSSID.Location = New System.Drawing.Point(6, 72)
        Me.lblSSID.Name = "lblSSID"
        Me.lblSSID.Size = New System.Drawing.Size(42, 13)
        Me.lblSSID.TabIndex = 2
        Me.lblSSID.Text = "lblSSID"
        '
        'lblEstadoConexion
        '
        Me.lblEstadoConexion.AutoSize = True
        Me.lblEstadoConexion.Location = New System.Drawing.Point(6, 48)
        Me.lblEstadoConexion.Name = "lblEstadoConexion"
        Me.lblEstadoConexion.Size = New System.Drawing.Size(94, 13)
        Me.lblEstadoConexion.TabIndex = 1
        Me.lblEstadoConexion.Text = "lblEstadoConexion"
        '
        'lblConectado_SiNo
        '
        Me.lblConectado_SiNo.AutoSize = True
        Me.lblConectado_SiNo.Location = New System.Drawing.Point(6, 25)
        Me.lblConectado_SiNo.Name = "lblConectado_SiNo"
        Me.lblConectado_SiNo.Size = New System.Drawing.Size(98, 13)
        Me.lblConectado_SiNo.TabIndex = 0
        Me.lblConectado_SiNo.Text = "lblConectado_SiNo"
        '
        'gbxRedesDisponibles
        '
        Me.gbxRedesDisponibles.Controls.Add(Me.btnCrearPerfilNuevo)
        Me.gbxRedesDisponibles.Controls.Add(Me.btnEscanearRedesDisponibles)
        Me.gbxRedesDisponibles.Controls.Add(Me.lvwWifiDisponibles)
        Me.gbxRedesDisponibles.Location = New System.Drawing.Point(351, 13)
        Me.gbxRedesDisponibles.Name = "gbxRedesDisponibles"
        Me.gbxRedesDisponibles.Size = New System.Drawing.Size(675, 228)
        Me.gbxRedesDisponibles.TabIndex = 1
        Me.gbxRedesDisponibles.TabStop = False
        Me.gbxRedesDisponibles.Text = "Redes WIFI disponibles"
        '
        'btnCrearPerfilNuevo
        '
        Me.btnCrearPerfilNuevo.Location = New System.Drawing.Point(544, 201)
        Me.btnCrearPerfilNuevo.Name = "btnCrearPerfilNuevo"
        Me.btnCrearPerfilNuevo.Size = New System.Drawing.Size(125, 23)
        Me.btnCrearPerfilNuevo.TabIndex = 2
        Me.btnCrearPerfilNuevo.Text = "btnCrearPerfilNuevo"
        Me.btnCrearPerfilNuevo.UseVisualStyleBackColor = True
        '
        'btnEscanearRedesDisponibles
        '
        Me.btnEscanearRedesDisponibles.Location = New System.Drawing.Point(364, 201)
        Me.btnEscanearRedesDisponibles.Name = "btnEscanearRedesDisponibles"
        Me.btnEscanearRedesDisponibles.Size = New System.Drawing.Size(143, 23)
        Me.btnEscanearRedesDisponibles.TabIndex = 1
        Me.btnEscanearRedesDisponibles.Text = "btnEscanearRedesDisponibles"
        Me.btnEscanearRedesDisponibles.UseVisualStyleBackColor = True
        '
        'lvwWifiDisponibles
        '
        Me.lvwWifiDisponibles.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colSSID, Me.colSeñal, Me.colAutenticacionDeRed, Me.colCifradoDeDatos, Me.colCanal})
        Me.lvwWifiDisponibles.FullRowSelect = True
        Me.lvwWifiDisponibles.GridLines = True
        Me.lvwWifiDisponibles.Location = New System.Drawing.Point(6, 19)
        Me.lvwWifiDisponibles.Name = "lvwWifiDisponibles"
        Me.lvwWifiDisponibles.Size = New System.Drawing.Size(663, 176)
        Me.lvwWifiDisponibles.TabIndex = 0
        Me.lvwWifiDisponibles.UseCompatibleStateImageBehavior = False
        Me.lvwWifiDisponibles.View = System.Windows.Forms.View.Details
        '
        'colSSID
        '
        Me.colSSID.Text = "SSID"
        '
        'colSeñal
        '
        Me.colSeñal.Text = "Señal"
        '
        'colAutenticacionDeRed
        '
        Me.colAutenticacionDeRed.Text = "Autenticación de Red"
        '
        'colCifradoDeDatos
        '
        Me.colCifradoDeDatos.Text = "Cifrado de datos"
        '
        'colCanal
        '
        Me.colCanal.Text = "Canal"
        '
        'gbxPerfilesGuardados
        '
        Me.gbxPerfilesGuardados.Controls.Add(Me.lvwPerfilesGuardados)
        Me.gbxPerfilesGuardados.Controls.Add(Me.btnEliminarPerfilGuardado)
        Me.gbxPerfilesGuardados.Controls.Add(Me.btnActualizarPerfilesGuardados)
        Me.gbxPerfilesGuardados.Location = New System.Drawing.Point(18, 248)
        Me.gbxPerfilesGuardados.Name = "gbxPerfilesGuardados"
        Me.gbxPerfilesGuardados.Size = New System.Drawing.Size(157, 315)
        Me.gbxPerfilesGuardados.TabIndex = 2
        Me.gbxPerfilesGuardados.TabStop = False
        Me.gbxPerfilesGuardados.Text = "Perfiles guardados"
        '
        'btnEliminarPerfilGuardado
        '
        Me.btnEliminarPerfilGuardado.Location = New System.Drawing.Point(9, 284)
        Me.btnEliminarPerfilGuardado.Name = "btnEliminarPerfilGuardado"
        Me.btnEliminarPerfilGuardado.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminarPerfilGuardado.TabIndex = 2
        Me.btnEliminarPerfilGuardado.Text = "btnEliminarPerfilGuardado"
        Me.btnEliminarPerfilGuardado.UseVisualStyleBackColor = True
        '
        'btnActualizarPerfilesGuardados
        '
        Me.btnActualizarPerfilesGuardados.Location = New System.Drawing.Point(9, 255)
        Me.btnActualizarPerfilesGuardados.Name = "btnActualizarPerfilesGuardados"
        Me.btnActualizarPerfilesGuardados.Size = New System.Drawing.Size(75, 23)
        Me.btnActualizarPerfilesGuardados.TabIndex = 1
        Me.btnActualizarPerfilesGuardados.Text = "btnActualizarPerfilesGuardados"
        Me.btnActualizarPerfilesGuardados.UseVisualStyleBackColor = True
        '
        'gbxRedesGuardadas
        '
        Me.gbxRedesGuardadas.Controls.Add(Me.btnEliminarRedGuardada)
        Me.gbxRedesGuardadas.Controls.Add(Me.btnConectarRedGuardada)
        Me.gbxRedesGuardadas.Controls.Add(Me.btnEscanearRedesGuardadas)
        Me.gbxRedesGuardadas.Controls.Add(Me.lvwRedesGuardadas)
        Me.gbxRedesGuardadas.Location = New System.Drawing.Point(183, 248)
        Me.gbxRedesGuardadas.Name = "gbxRedesGuardadas"
        Me.gbxRedesGuardadas.Size = New System.Drawing.Size(500, 315)
        Me.gbxRedesGuardadas.TabIndex = 3
        Me.gbxRedesGuardadas.TabStop = False
        Me.gbxRedesGuardadas.Text = "Redes guardadas y disponibles ahora"
        '
        'btnEliminarRedGuardada
        '
        Me.btnEliminarRedGuardada.Location = New System.Drawing.Point(343, 284)
        Me.btnEliminarRedGuardada.Name = "btnEliminarRedGuardada"
        Me.btnEliminarRedGuardada.Size = New System.Drawing.Size(125, 23)
        Me.btnEliminarRedGuardada.TabIndex = 3
        Me.btnEliminarRedGuardada.Text = "btnEliminarRedGuardada"
        Me.btnEliminarRedGuardada.UseVisualStyleBackColor = True
        '
        'btnConectarRedGuardada
        '
        Me.btnConectarRedGuardada.Location = New System.Drawing.Point(212, 284)
        Me.btnConectarRedGuardada.Name = "btnConectarRedGuardada"
        Me.btnConectarRedGuardada.Size = New System.Drawing.Size(125, 23)
        Me.btnConectarRedGuardada.TabIndex = 2
        Me.btnConectarRedGuardada.Text = "btnConectarRedGuardada"
        Me.btnConectarRedGuardada.UseVisualStyleBackColor = True
        '
        'btnEscanearRedesGuardadas
        '
        Me.btnEscanearRedesGuardadas.Location = New System.Drawing.Point(63, 284)
        Me.btnEscanearRedesGuardadas.Name = "btnEscanearRedesGuardadas"
        Me.btnEscanearRedesGuardadas.Size = New System.Drawing.Size(143, 23)
        Me.btnEscanearRedesGuardadas.TabIndex = 1
        Me.btnEscanearRedesGuardadas.Text = "btnEscanearRedesGuardadas"
        Me.btnEscanearRedesGuardadas.UseVisualStyleBackColor = True
        '
        'lvwRedesGuardadas
        '
        Me.lvwRedesGuardadas.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.lvwRedesGuardadas.FullRowSelect = True
        Me.lvwRedesGuardadas.GridLines = True
        Me.lvwRedesGuardadas.Location = New System.Drawing.Point(6, 19)
        Me.lvwRedesGuardadas.Name = "lvwRedesGuardadas"
        Me.lvwRedesGuardadas.Size = New System.Drawing.Size(483, 249)
        Me.lvwRedesGuardadas.TabIndex = 0
        Me.lvwRedesGuardadas.UseCompatibleStateImageBehavior = False
        Me.lvwRedesGuardadas.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "SSID"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Señal"
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Autenticación de Red"
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Cifrado de datos"
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Canal"
        '
        'gbxInfoRed
        '
        Me.gbxInfoRed.Controls.Add(Me.TextBox1)
        Me.gbxInfoRed.Controls.Add(Me.lvwInfoRed)
        Me.gbxInfoRed.Location = New System.Drawing.Point(697, 248)
        Me.gbxInfoRed.Name = "gbxInfoRed"
        Me.gbxInfoRed.Size = New System.Drawing.Size(329, 315)
        Me.gbxInfoRed.TabIndex = 4
        Me.gbxInfoRed.TabStop = False
        Me.gbxInfoRed.Text = "Info. Red seleccionada"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox1.ForeColor = System.Drawing.Color.Blue
        Me.TextBox1.Location = New System.Drawing.Point(10, 151)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBox1.Size = New System.Drawing.Size(309, 152)
        Me.TextBox1.TabIndex = 14
        Me.TextBox1.Text = "Estructura de configuración de la RED"
        '
        'lvwInfoRed
        '
        Me.lvwInfoRed.BackColor = System.Drawing.SystemColors.Window
        Me.lvwInfoRed.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader6, Me.ColumnHeader7})
        Me.lvwInfoRed.FullRowSelect = True
        Me.lvwInfoRed.GridLines = True
        Me.lvwInfoRed.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.lvwInfoRed.Location = New System.Drawing.Point(10, 19)
        Me.lvwInfoRed.Name = "lvwInfoRed"
        Me.lvwInfoRed.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lvwInfoRed.Size = New System.Drawing.Size(309, 126)
        Me.lvwInfoRed.TabIndex = 13
        Me.lvwInfoRed.TabStop = False
        Me.lvwInfoRed.UseCompatibleStateImageBehavior = False
        Me.lvwInfoRed.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = ""
        Me.ColumnHeader6.Width = 104
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = ""
        Me.ColumnHeader7.Width = 120
        '
        'tmrConexionActual
        '
        '
        'lvwPerfilesGuardados
        '
        Me.lvwPerfilesGuardados.BackColor = System.Drawing.SystemColors.Window
        Me.lvwPerfilesGuardados.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader8})
        Me.lvwPerfilesGuardados.FullRowSelect = True
        Me.lvwPerfilesGuardados.GridLines = True
        Me.lvwPerfilesGuardados.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.lvwPerfilesGuardados.Location = New System.Drawing.Point(9, 19)
        Me.lvwPerfilesGuardados.Name = "lvwPerfilesGuardados"
        Me.lvwPerfilesGuardados.Size = New System.Drawing.Size(131, 224)
        Me.lvwPerfilesGuardados.TabIndex = 6
        Me.lvwPerfilesGuardados.TabStop = False
        Me.lvwPerfilesGuardados.UseCompatibleStateImageBehavior = False
        Me.lvwPerfilesGuardados.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Perfiles registrados"
        Me.ColumnHeader8.Width = 120
        '
        'frmAdministrarWIFI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1056, 570)
        Me.Controls.Add(Me.gbxInfoRed)
        Me.Controls.Add(Me.gbxRedesGuardadas)
        Me.Controls.Add(Me.gbxPerfilesGuardados)
        Me.Controls.Add(Me.gbxRedesDisponibles)
        Me.Controls.Add(Me.gbxInfoWifi)
        Me.Name = "frmAdministrarWIFI"
        Me.Text = "Administrar WIFI (API de Windows) .NET 2010"
        Me.gbxInfoWifi.ResumeLayout(False)
        Me.gbxInfoWifi.PerformLayout()
        Me.gbxRedesDisponibles.ResumeLayout(False)
        Me.gbxPerfilesGuardados.ResumeLayout(False)
        Me.gbxRedesGuardadas.ResumeLayout(False)
        Me.gbxInfoRed.ResumeLayout(False)
        Me.gbxInfoRed.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbxInfoWifi As System.Windows.Forms.GroupBox
    Friend WithEvents lblMAC As System.Windows.Forms.Label
    Friend WithEvents lblAdaptadorWireless As System.Windows.Forms.Label
    Friend WithEvents lblMiIP As System.Windows.Forms.Label
    Friend WithEvents lblCanal As System.Windows.Forms.Label
    Friend WithEvents lblCifrado As System.Windows.Forms.Label
    Friend WithEvents lblTipoSeguridad As System.Windows.Forms.Label
    Friend WithEvents lblSeguridad As System.Windows.Forms.Label
    Friend WithEvents lblIntensidadSeñal As System.Windows.Forms.Label
    Friend WithEvents lblSSID As System.Windows.Forms.Label
    Friend WithEvents lblEstadoConexion As System.Windows.Forms.Label
    Friend WithEvents lblConectado_SiNo As System.Windows.Forms.Label
    Friend WithEvents btnConectarDesconectar As System.Windows.Forms.Button
    Friend WithEvents gbxRedesDisponibles As System.Windows.Forms.GroupBox
    Friend WithEvents lvwWifiDisponibles As System.Windows.Forms.ListView
    Friend WithEvents colSSID As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnEscanearRedesDisponibles As System.Windows.Forms.Button
    Friend WithEvents colSeñal As System.Windows.Forms.ColumnHeader
    Friend WithEvents colAutenticacionDeRed As System.Windows.Forms.ColumnHeader
    Friend WithEvents colCifradoDeDatos As System.Windows.Forms.ColumnHeader
    Friend WithEvents colCanal As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnCrearPerfilNuevo As System.Windows.Forms.Button
    Friend WithEvents gbxPerfilesGuardados As System.Windows.Forms.GroupBox
    Friend WithEvents btnEliminarPerfilGuardado As System.Windows.Forms.Button
    Friend WithEvents btnActualizarPerfilesGuardados As System.Windows.Forms.Button
    Friend WithEvents gbxRedesGuardadas As System.Windows.Forms.GroupBox
    Friend WithEvents btnConectarRedGuardada As System.Windows.Forms.Button
    Friend WithEvents btnEscanearRedesGuardadas As System.Windows.Forms.Button
    Friend WithEvents lvwRedesGuardadas As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnEliminarRedGuardada As System.Windows.Forms.Button
    Friend WithEvents gbxInfoRed As System.Windows.Forms.GroupBox
    Friend WithEvents lvwInfoRed As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents tmrConexionActual As System.Windows.Forms.Timer
    Friend WithEvents lvwPerfilesGuardados As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader

End Class
