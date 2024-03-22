<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCrearPerfil
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
        Me.gbxCrearPerfil = New System.Windows.Forms.GroupBox()
        Me.txtMensajeInformacionPerfil = New System.Windows.Forms.TextBox()
        Me.gbxCrearPerfil_Seguridad = New System.Windows.Forms.GroupBox()
        Me.comboboxCrearPerfil_CifradoDatos = New System.Windows.Forms.ComboBox()
        Me.comboBoxCrearPerfil_AutenticacionRed = New System.Windows.Forms.ComboBox()
        Me.txtCrearPerfil_ContraseñaConfirmar = New System.Windows.Forms.TextBox()
        Me.lblCotraseñaConfirmar = New System.Windows.Forms.Label()
        Me.txtCrearPerfil_ContraseñaRed = New System.Windows.Forms.TextBox()
        Me.lblContraseñaRed = New System.Windows.Forms.Label()
        Me.lblCifradoDatos = New System.Windows.Forms.Label()
        Me.lblAutenticacionRed = New System.Windows.Forms.Label()
        Me.btnGuardarPerfil = New System.Windows.Forms.Button()
        Me.txtCrearPerfil_SSID = New System.Windows.Forms.TextBox()
        Me.lblCrearPerfil_SSID = New System.Windows.Forms.Label()
        Me.gbxCrearPerfil.SuspendLayout()
        Me.gbxCrearPerfil_Seguridad.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbxCrearPerfil
        '
        Me.gbxCrearPerfil.Controls.Add(Me.txtMensajeInformacionPerfil)
        Me.gbxCrearPerfil.Controls.Add(Me.gbxCrearPerfil_Seguridad)
        Me.gbxCrearPerfil.Controls.Add(Me.btnGuardarPerfil)
        Me.gbxCrearPerfil.Controls.Add(Me.txtCrearPerfil_SSID)
        Me.gbxCrearPerfil.Controls.Add(Me.lblCrearPerfil_SSID)
        Me.gbxCrearPerfil.Location = New System.Drawing.Point(12, 12)
        Me.gbxCrearPerfil.Name = "gbxCrearPerfil"
        Me.gbxCrearPerfil.Size = New System.Drawing.Size(329, 254)
        Me.gbxCrearPerfil.TabIndex = 1
        Me.gbxCrearPerfil.TabStop = False
        Me.gbxCrearPerfil.Text = "Registro de nueva Red WLAN"
        '
        'txtMensajeInformacionPerfil
        '
        Me.txtMensajeInformacionPerfil.BackColor = System.Drawing.SystemColors.Control
        Me.txtMensajeInformacionPerfil.ForeColor = System.Drawing.Color.Red
        Me.txtMensajeInformacionPerfil.Location = New System.Drawing.Point(13, 200)
        Me.txtMensajeInformacionPerfil.Multiline = True
        Me.txtMensajeInformacionPerfil.Name = "txtMensajeInformacionPerfil"
        Me.txtMensajeInformacionPerfil.Size = New System.Drawing.Size(198, 44)
        Me.txtMensajeInformacionPerfil.TabIndex = 12
        Me.txtMensajeInformacionPerfil.TabStop = False
        '
        'gbxCrearPerfil_Seguridad
        '
        Me.gbxCrearPerfil_Seguridad.Controls.Add(Me.comboboxCrearPerfil_CifradoDatos)
        Me.gbxCrearPerfil_Seguridad.Controls.Add(Me.comboBoxCrearPerfil_AutenticacionRed)
        Me.gbxCrearPerfil_Seguridad.Controls.Add(Me.txtCrearPerfil_ContraseñaConfirmar)
        Me.gbxCrearPerfil_Seguridad.Controls.Add(Me.lblCotraseñaConfirmar)
        Me.gbxCrearPerfil_Seguridad.Controls.Add(Me.txtCrearPerfil_ContraseñaRed)
        Me.gbxCrearPerfil_Seguridad.Controls.Add(Me.lblContraseñaRed)
        Me.gbxCrearPerfil_Seguridad.Controls.Add(Me.lblCifradoDatos)
        Me.gbxCrearPerfil_Seguridad.Controls.Add(Me.lblAutenticacionRed)
        Me.gbxCrearPerfil_Seguridad.Location = New System.Drawing.Point(9, 45)
        Me.gbxCrearPerfil_Seguridad.Name = "gbxCrearPerfil_Seguridad"
        Me.gbxCrearPerfil_Seguridad.Size = New System.Drawing.Size(309, 148)
        Me.gbxCrearPerfil_Seguridad.TabIndex = 0
        Me.gbxCrearPerfil_Seguridad.TabStop = False
        Me.gbxCrearPerfil_Seguridad.Text = "Seguridad"
        '
        'comboboxCrearPerfil_CifradoDatos
        '
        Me.comboboxCrearPerfil_CifradoDatos.FormattingEnabled = True
        Me.comboboxCrearPerfil_CifradoDatos.Location = New System.Drawing.Point(132, 46)
        Me.comboboxCrearPerfil_CifradoDatos.Name = "comboboxCrearPerfil_CifradoDatos"
        Me.comboboxCrearPerfil_CifradoDatos.Size = New System.Drawing.Size(162, 21)
        Me.comboboxCrearPerfil_CifradoDatos.TabIndex = 3
        '
        'comboBoxCrearPerfil_AutenticacionRed
        '
        Me.comboBoxCrearPerfil_AutenticacionRed.FormattingEnabled = True
        Me.comboBoxCrearPerfil_AutenticacionRed.Location = New System.Drawing.Point(132, 19)
        Me.comboBoxCrearPerfil_AutenticacionRed.Name = "comboBoxCrearPerfil_AutenticacionRed"
        Me.comboBoxCrearPerfil_AutenticacionRed.Size = New System.Drawing.Size(162, 21)
        Me.comboBoxCrearPerfil_AutenticacionRed.TabIndex = 2
        '
        'txtCrearPerfil_ContraseñaConfirmar
        '
        Me.txtCrearPerfil_ContraseñaConfirmar.Location = New System.Drawing.Point(132, 115)
        Me.txtCrearPerfil_ContraseñaConfirmar.Name = "txtCrearPerfil_ContraseñaConfirmar"
        Me.txtCrearPerfil_ContraseñaConfirmar.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtCrearPerfil_ContraseñaConfirmar.Size = New System.Drawing.Size(162, 20)
        Me.txtCrearPerfil_ContraseñaConfirmar.TabIndex = 5
        '
        'lblCotraseñaConfirmar
        '
        Me.lblCotraseñaConfirmar.AutoSize = True
        Me.lblCotraseñaConfirmar.Location = New System.Drawing.Point(18, 115)
        Me.lblCotraseñaConfirmar.Name = "lblCotraseñaConfirmar"
        Me.lblCotraseñaConfirmar.Size = New System.Drawing.Size(110, 13)
        Me.lblCotraseñaConfirmar.TabIndex = 16
        Me.lblCotraseñaConfirmar.Text = "Confirmar contraseña:"
        '
        'txtCrearPerfil_ContraseñaRed
        '
        Me.txtCrearPerfil_ContraseñaRed.Location = New System.Drawing.Point(132, 89)
        Me.txtCrearPerfil_ContraseñaRed.Name = "txtCrearPerfil_ContraseñaRed"
        Me.txtCrearPerfil_ContraseñaRed.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtCrearPerfil_ContraseñaRed.Size = New System.Drawing.Size(162, 20)
        Me.txtCrearPerfil_ContraseñaRed.TabIndex = 4
        '
        'lblContraseñaRed
        '
        Me.lblContraseñaRed.AutoSize = True
        Me.lblContraseñaRed.Location = New System.Drawing.Point(18, 89)
        Me.lblContraseñaRed.Name = "lblContraseñaRed"
        Me.lblContraseñaRed.Size = New System.Drawing.Size(108, 13)
        Me.lblContraseñaRed.TabIndex = 14
        Me.lblContraseñaRed.Text = "Contraseña de la red:"
        '
        'lblCifradoDatos
        '
        Me.lblCifradoDatos.AutoSize = True
        Me.lblCifradoDatos.Location = New System.Drawing.Point(17, 54)
        Me.lblCifradoDatos.Name = "lblCifradoDatos"
        Me.lblCifradoDatos.Size = New System.Drawing.Size(87, 13)
        Me.lblCifradoDatos.TabIndex = 11
        Me.lblCifradoDatos.Text = "Cifrado de datos:"
        '
        'lblAutenticacionRed
        '
        Me.lblAutenticacionRed.AutoSize = True
        Me.lblAutenticacionRed.Location = New System.Drawing.Point(18, 27)
        Me.lblAutenticacionRed.Name = "lblAutenticacionRed"
        Me.lblAutenticacionRed.Size = New System.Drawing.Size(108, 13)
        Me.lblAutenticacionRed.TabIndex = 10
        Me.lblAutenticacionRed.Text = "Autenticación de red:"
        '
        'btnGuardarPerfil
        '
        Me.btnGuardarPerfil.Location = New System.Drawing.Point(226, 211)
        Me.btnGuardarPerfil.Name = "btnGuardarPerfil"
        Me.btnGuardarPerfil.Size = New System.Drawing.Size(92, 24)
        Me.btnGuardarPerfil.TabIndex = 6
        Me.btnGuardarPerfil.TabStop = False
        Me.btnGuardarPerfil.Text = "Guardar Perfil"
        Me.btnGuardarPerfil.UseVisualStyleBackColor = True
        '
        'txtCrearPerfil_SSID
        '
        Me.txtCrearPerfil_SSID.Location = New System.Drawing.Point(126, 19)
        Me.txtCrearPerfil_SSID.Name = "txtCrearPerfil_SSID"
        Me.txtCrearPerfil_SSID.Size = New System.Drawing.Size(177, 20)
        Me.txtCrearPerfil_SSID.TabIndex = 1
        '
        'lblCrearPerfil_SSID
        '
        Me.lblCrearPerfil_SSID.AutoSize = True
        Me.lblCrearPerfil_SSID.Location = New System.Drawing.Point(6, 22)
        Me.lblCrearPerfil_SSID.Name = "lblCrearPerfil_SSID"
        Me.lblCrearPerfil_SSID.Size = New System.Drawing.Size(114, 13)
        Me.lblCrearPerfil_SSID.TabIndex = 0
        Me.lblCrearPerfil_SSID.Text = "Nombre de red (SSID):"
        '
        'frmCrearPerfil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(353, 272)
        Me.Controls.Add(Me.gbxCrearPerfil)
        Me.Name = "frmCrearPerfil"
        Me.Text = "Crear nuevo perfil y guardar"
        Me.gbxCrearPerfil.ResumeLayout(False)
        Me.gbxCrearPerfil.PerformLayout()
        Me.gbxCrearPerfil_Seguridad.ResumeLayout(False)
        Me.gbxCrearPerfil_Seguridad.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbxCrearPerfil As System.Windows.Forms.GroupBox
    Friend WithEvents txtMensajeInformacionPerfil As System.Windows.Forms.TextBox
    Friend WithEvents gbxCrearPerfil_Seguridad As System.Windows.Forms.GroupBox
    Friend WithEvents comboboxCrearPerfil_CifradoDatos As System.Windows.Forms.ComboBox
    Friend WithEvents comboBoxCrearPerfil_AutenticacionRed As System.Windows.Forms.ComboBox
    Friend WithEvents txtCrearPerfil_ContraseñaConfirmar As System.Windows.Forms.TextBox
    Friend WithEvents lblCotraseñaConfirmar As System.Windows.Forms.Label
    Friend WithEvents txtCrearPerfil_ContraseñaRed As System.Windows.Forms.TextBox
    Friend WithEvents lblContraseñaRed As System.Windows.Forms.Label
    Friend WithEvents lblCifradoDatos As System.Windows.Forms.Label
    Friend WithEvents lblAutenticacionRed As System.Windows.Forms.Label
    Friend WithEvents btnGuardarPerfil As System.Windows.Forms.Button
    Friend WithEvents txtCrearPerfil_SSID As System.Windows.Forms.TextBox
    Friend WithEvents lblCrearPerfil_SSID As System.Windows.Forms.Label
End Class
