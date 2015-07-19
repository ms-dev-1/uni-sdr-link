<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.startMonitorButton = New System.Windows.Forms.Button()
        Me.stopMonitorButton = New System.Windows.Forms.Button()
        Me.dataReceivedLabel = New System.Windows.Forms.Label()
        Me.dataSentLabel = New System.Windows.Forms.Label()
        Me.SerialPortVFOA = New System.IO.Ports.SerialPort(Me.components)
        Me.SerialPortVFOB = New System.IO.Ports.SerialPort(Me.components)
        Me.SerialPortVFOC = New System.IO.Ports.SerialPort(Me.components)
        Me.SerialPortVFOD = New System.IO.Ports.SerialPort(Me.components)
        Me.SerialPortVFOE = New System.IO.Ports.SerialPort(Me.components)
        Me.SerialPortVFOF = New System.IO.Ports.SerialPort(Me.components)
        Me.SerialPortOutput = New System.IO.Ports.SerialPort(Me.components)
        Me.baudRateComboBox = New System.Windows.Forms.ComboBox()
        Me.outputPortComboBox = New System.Windows.Forms.ComboBox()
        Me.SDRConsoleOutputLabel = New System.Windows.Forms.Label()
        Me.VFODLabel = New System.Windows.Forms.Label()
        Me.VFOCLabel = New System.Windows.Forms.Label()
        Me.VFOELabel = New System.Windows.Forms.Label()
        Me.VFOBLabel = New System.Windows.Forms.Label()
        Me.inputTableLabelVFO = New System.Windows.Forms.Label()
        Me.VFOALabel = New System.Windows.Forms.Label()
        Me.VFOFLabel = New System.Windows.Forms.Label()
        Me.inputTableLabelComPort = New System.Windows.Forms.Label()
        Me.VFOAPortComboBox = New System.Windows.Forms.ComboBox()
        Me.VFOBPortComboBox = New System.Windows.Forms.ComboBox()
        Me.VFODPortComboBox = New System.Windows.Forms.ComboBox()
        Me.inputTableLabelActive = New System.Windows.Forms.Label()
        Me.VFOEPortComboBox = New System.Windows.Forms.ComboBox()
        Me.VFOCPortComboBox = New System.Windows.Forms.ComboBox()
        Me.VFOFPortComboBox = New System.Windows.Forms.ComboBox()
        Me.inputRoutingTableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.outputRoutingLabel = New System.Windows.Forms.Label()
        Me.VFOBActiveCheckBox = New System.Windows.Forms.CheckBox()
        Me.VFOCActiveCheckBox = New System.Windows.Forms.CheckBox()
        Me.VFOEActiveCheckBox = New System.Windows.Forms.CheckBox()
        Me.VFODActiveCheckBox = New System.Windows.Forms.CheckBox()
        Me.VFOFActiveCheckBox = New System.Windows.Forms.CheckBox()
        Me.VFOAActiveCheckBox = New System.Windows.Forms.CheckBox()
        Me.inputPanelLabel = New System.Windows.Forms.Label()
        Me.comSettingsTableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.enableDebugLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.parityComboBox = New System.Windows.Forms.ComboBox()
        Me.rescanComPortsButton = New System.Windows.Forms.Button()
        Me.comSettingsLabel = New System.Windows.Forms.Label()
        Me.stopBitComboBox = New System.Windows.Forms.ComboBox()
        Me.dataBitComboBox = New System.Windows.Forms.ComboBox()
        Me.parityLabel = New System.Windows.Forms.Label()
        Me.stopBitLabel = New System.Windows.Forms.Label()
        Me.dataBitLabel = New System.Windows.Forms.Label()
        Me.baudRateLabel = New System.Windows.Forms.Label()
        Me.saveSpacerLabel = New System.Windows.Forms.Label()
        Me.resetButton = New System.Windows.Forms.Button()
        Me.enableDebugCheckBox = New System.Windows.Forms.CheckBox()
        Me.mainTabControl = New System.Windows.Forms.TabControl()
        Me.portRoutingTabPage = New System.Windows.Forms.TabPage()
        Me.portSettingsTabPage = New System.Windows.Forms.TabPage()
        Me.debugTabPage = New System.Windows.Forms.TabPage()
        Me.debugTableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.dataSentTextBox = New System.Windows.Forms.TextBox()
        Me.dataReceivedTextBox = New System.Windows.Forms.TextBox()
        Me.debugClearButton = New System.Windows.Forms.Button()
        Me.HelpProvider = New System.Windows.Forms.HelpProvider()
        Me.showHelpButton = New System.Windows.Forms.Button()
        Me.statusTextBox = New System.Windows.Forms.TextBox()
        Me.inputRoutingTableLayoutPanel.SuspendLayout()
        Me.comSettingsTableLayoutPanel.SuspendLayout()
        Me.mainTabControl.SuspendLayout()
        Me.portRoutingTabPage.SuspendLayout()
        Me.portSettingsTabPage.SuspendLayout()
        Me.debugTabPage.SuspendLayout()
        Me.debugTableLayoutPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'startMonitorButton
        '
        Me.startMonitorButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.startMonitorButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.startMonitorButton.BackColor = System.Drawing.Color.DarkGreen
        Me.startMonitorButton.Font = New System.Drawing.Font("HelveticaNeue LT 55 Roman", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.startMonitorButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.startMonitorButton.Location = New System.Drawing.Point(0, 0)
        Me.startMonitorButton.Name = "startMonitorButton"
        Me.startMonitorButton.Padding = New System.Windows.Forms.Padding(0, 4, 0, 4)
        Me.startMonitorButton.Size = New System.Drawing.Size(354, 52)
        Me.startMonitorButton.TabIndex = 0
        Me.startMonitorButton.Text = "START"
        Me.startMonitorButton.UseVisualStyleBackColor = False
        '
        'stopMonitorButton
        '
        Me.stopMonitorButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.stopMonitorButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.stopMonitorButton.BackColor = System.Drawing.Color.DarkRed
        Me.stopMonitorButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.stopMonitorButton.Enabled = False
        Me.stopMonitorButton.Font = New System.Drawing.Font("HelveticaNeue LT 55 Roman", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stopMonitorButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.stopMonitorButton.Location = New System.Drawing.Point(0, 0)
        Me.stopMonitorButton.Name = "stopMonitorButton"
        Me.stopMonitorButton.Padding = New System.Windows.Forms.Padding(0, 4, 0, 4)
        Me.stopMonitorButton.Size = New System.Drawing.Size(354, 52)
        Me.stopMonitorButton.TabIndex = 1
        Me.stopMonitorButton.Text = "STOP"
        Me.stopMonitorButton.UseVisualStyleBackColor = False
        '
        'dataReceivedLabel
        '
        Me.dataReceivedLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dataReceivedLabel.AutoSize = True
        Me.dataReceivedLabel.Font = New System.Drawing.Font("HelveticaNeue LT 55 Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dataReceivedLabel.Location = New System.Drawing.Point(0, 0)
        Me.dataReceivedLabel.Margin = New System.Windows.Forms.Padding(0)
        Me.dataReceivedLabel.Name = "dataReceivedLabel"
        Me.dataReceivedLabel.Size = New System.Drawing.Size(380, 20)
        Me.dataReceivedLabel.TabIndex = 5
        Me.dataReceivedLabel.Text = "Data Received from Unitrunker"
        Me.dataReceivedLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'dataSentLabel
        '
        Me.dataSentLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dataSentLabel.AutoSize = True
        Me.dataSentLabel.Font = New System.Drawing.Font("HelveticaNeue LT 55 Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dataSentLabel.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.dataSentLabel.Location = New System.Drawing.Point(0, 172)
        Me.dataSentLabel.Margin = New System.Windows.Forms.Padding(0)
        Me.dataSentLabel.Name = "dataSentLabel"
        Me.dataSentLabel.Size = New System.Drawing.Size(380, 20)
        Me.dataSentLabel.TabIndex = 6
        Me.dataSentLabel.Text = "Data Sent to SDR Console"
        Me.dataSentLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'SerialPortVFOA
        '
        '
        'SerialPortVFOB
        '
        '
        'SerialPortVFOC
        '
        '
        'SerialPortVFOD
        '
        '
        'SerialPortVFOE
        '
        '
        'SerialPortVFOF
        '
        '
        'baudRateComboBox
        '
        Me.baudRateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.baudRateComboBox.Font = New System.Drawing.Font("HelveticaNeue LT 55 Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.baudRateComboBox.FormattingEnabled = True
        Me.baudRateComboBox.Location = New System.Drawing.Point(201, 53)
        Me.baudRateComboBox.Name = "baudRateComboBox"
        Me.baudRateComboBox.Size = New System.Drawing.Size(121, 27)
        Me.baudRateComboBox.TabIndex = 210
        '
        'outputPortComboBox
        '
        Me.outputPortComboBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.outputPortComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.outputPortComboBox.Font = New System.Drawing.Font("HelveticaNeue LT 55 Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.outputPortComboBox.FormattingEnabled = True
        Me.outputPortComboBox.Location = New System.Drawing.Point(161, 360)
        Me.outputPortComboBox.Name = "outputPortComboBox"
        Me.outputPortComboBox.Size = New System.Drawing.Size(150, 27)
        Me.outputPortComboBox.TabIndex = 190
        '
        'SDRConsoleOutputLabel
        '
        Me.SDRConsoleOutputLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SDRConsoleOutputLabel.AutoSize = True
        Me.SDRConsoleOutputLabel.Font = New System.Drawing.Font("HelveticaNeue LT 55 Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SDRConsoleOutputLabel.Location = New System.Drawing.Point(4, 357)
        Me.SDRConsoleOutputLabel.Name = "SDRConsoleOutputLabel"
        Me.SDRConsoleOutputLabel.Size = New System.Drawing.Size(150, 38)
        Me.SDRConsoleOutputLabel.TabIndex = 21
        Me.SDRConsoleOutputLabel.Text = "SDR Console Port"
        Me.SDRConsoleOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'VFODLabel
        '
        Me.VFODLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VFODLabel.AutoSize = True
        Me.VFODLabel.Font = New System.Drawing.Font("HelveticaNeue LT 55 Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VFODLabel.Location = New System.Drawing.Point(161, 184)
        Me.VFODLabel.Name = "VFODLabel"
        Me.VFODLabel.Size = New System.Drawing.Size(150, 33)
        Me.VFODLabel.TabIndex = 16
        Me.VFODLabel.Text = "Controls VFO D"
        Me.VFODLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'VFOCLabel
        '
        Me.VFOCLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VFOCLabel.AutoSize = True
        Me.VFOCLabel.Font = New System.Drawing.Font("HelveticaNeue LT 55 Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VFOCLabel.Location = New System.Drawing.Point(161, 150)
        Me.VFOCLabel.Name = "VFOCLabel"
        Me.VFOCLabel.Size = New System.Drawing.Size(150, 33)
        Me.VFOCLabel.TabIndex = 14
        Me.VFOCLabel.Text = "Controls VFO C"
        Me.VFOCLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'VFOELabel
        '
        Me.VFOELabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VFOELabel.AutoSize = True
        Me.VFOELabel.Font = New System.Drawing.Font("HelveticaNeue LT 55 Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VFOELabel.Location = New System.Drawing.Point(161, 218)
        Me.VFOELabel.Name = "VFOELabel"
        Me.VFOELabel.Size = New System.Drawing.Size(150, 33)
        Me.VFOELabel.TabIndex = 18
        Me.VFOELabel.Text = "Controls VFO E"
        Me.VFOELabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'VFOBLabel
        '
        Me.VFOBLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VFOBLabel.AutoSize = True
        Me.VFOBLabel.Font = New System.Drawing.Font("HelveticaNeue LT 55 Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VFOBLabel.Location = New System.Drawing.Point(161, 116)
        Me.VFOBLabel.Name = "VFOBLabel"
        Me.VFOBLabel.Size = New System.Drawing.Size(150, 33)
        Me.VFOBLabel.TabIndex = 12
        Me.VFOBLabel.Text = "Controls VFO B"
        Me.VFOBLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'inputTableLabelVFO
        '
        Me.inputTableLabelVFO.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.inputTableLabelVFO.AutoSize = True
        Me.inputTableLabelVFO.Font = New System.Drawing.Font("HelveticaNeue LT 55 Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inputTableLabelVFO.Location = New System.Drawing.Point(161, 50)
        Me.inputTableLabelVFO.Name = "inputTableLabelVFO"
        Me.inputTableLabelVFO.Padding = New System.Windows.Forms.Padding(0, 6, 0, 6)
        Me.inputTableLabelVFO.Size = New System.Drawing.Size(150, 31)
        Me.inputTableLabelVFO.TabIndex = 0
        Me.inputTableLabelVFO.Text = "SDR Console"
        Me.inputTableLabelVFO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'VFOALabel
        '
        Me.VFOALabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VFOALabel.AutoSize = True
        Me.VFOALabel.Font = New System.Drawing.Font("HelveticaNeue LT 55 Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VFOALabel.Location = New System.Drawing.Point(161, 82)
        Me.VFOALabel.Name = "VFOALabel"
        Me.VFOALabel.Size = New System.Drawing.Size(150, 33)
        Me.VFOALabel.TabIndex = 10
        Me.VFOALabel.Text = "Controls VFO A"
        Me.VFOALabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'VFOFLabel
        '
        Me.VFOFLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VFOFLabel.AutoSize = True
        Me.VFOFLabel.Font = New System.Drawing.Font("HelveticaNeue LT 55 Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VFOFLabel.Location = New System.Drawing.Point(161, 252)
        Me.VFOFLabel.Name = "VFOFLabel"
        Me.VFOFLabel.Size = New System.Drawing.Size(150, 33)
        Me.VFOFLabel.TabIndex = 20
        Me.VFOFLabel.Text = "Controls VFO F"
        Me.VFOFLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'inputTableLabelComPort
        '
        Me.inputTableLabelComPort.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.inputTableLabelComPort.AutoSize = True
        Me.inputTableLabelComPort.Font = New System.Drawing.Font("HelveticaNeue LT 55 Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inputTableLabelComPort.Location = New System.Drawing.Point(4, 50)
        Me.inputTableLabelComPort.Name = "inputTableLabelComPort"
        Me.inputTableLabelComPort.Padding = New System.Windows.Forms.Padding(0, 6, 0, 6)
        Me.inputTableLabelComPort.Size = New System.Drawing.Size(150, 31)
        Me.inputTableLabelComPort.TabIndex = 1
        Me.inputTableLabelComPort.Text = "Unitrunker"
        Me.inputTableLabelComPort.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'VFOAPortComboBox
        '
        Me.VFOAPortComboBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VFOAPortComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.VFOAPortComboBox.Enabled = False
        Me.VFOAPortComboBox.Font = New System.Drawing.Font("HelveticaNeue LT 55 Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VFOAPortComboBox.FormattingEnabled = True
        Me.VFOAPortComboBox.Location = New System.Drawing.Point(4, 85)
        Me.VFOAPortComboBox.Name = "VFOAPortComboBox"
        Me.VFOAPortComboBox.Size = New System.Drawing.Size(150, 27)
        Me.VFOAPortComboBox.TabIndex = 101
        '
        'VFOBPortComboBox
        '
        Me.VFOBPortComboBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VFOBPortComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.VFOBPortComboBox.Enabled = False
        Me.VFOBPortComboBox.Font = New System.Drawing.Font("HelveticaNeue LT 55 Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VFOBPortComboBox.FormattingEnabled = True
        Me.VFOBPortComboBox.Location = New System.Drawing.Point(4, 119)
        Me.VFOBPortComboBox.Name = "VFOBPortComboBox"
        Me.VFOBPortComboBox.Size = New System.Drawing.Size(150, 27)
        Me.VFOBPortComboBox.TabIndex = 111
        '
        'VFODPortComboBox
        '
        Me.VFODPortComboBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VFODPortComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.VFODPortComboBox.Enabled = False
        Me.VFODPortComboBox.Font = New System.Drawing.Font("HelveticaNeue LT 55 Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VFODPortComboBox.FormattingEnabled = True
        Me.VFODPortComboBox.Location = New System.Drawing.Point(4, 187)
        Me.VFODPortComboBox.Name = "VFODPortComboBox"
        Me.VFODPortComboBox.Size = New System.Drawing.Size(150, 27)
        Me.VFODPortComboBox.TabIndex = 131
        '
        'inputTableLabelActive
        '
        Me.inputTableLabelActive.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.inputTableLabelActive.AutoSize = True
        Me.inputTableLabelActive.Font = New System.Drawing.Font("HelveticaNeue LT 55 Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inputTableLabelActive.Location = New System.Drawing.Point(318, 50)
        Me.inputTableLabelActive.Name = "inputTableLabelActive"
        Me.inputTableLabelActive.Padding = New System.Windows.Forms.Padding(0, 6, 0, 6)
        Me.inputTableLabelActive.Size = New System.Drawing.Size(74, 31)
        Me.inputTableLabelActive.TabIndex = 2
        Me.inputTableLabelActive.Text = "Active"
        Me.inputTableLabelActive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'VFOEPortComboBox
        '
        Me.VFOEPortComboBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VFOEPortComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.VFOEPortComboBox.Enabled = False
        Me.VFOEPortComboBox.Font = New System.Drawing.Font("HelveticaNeue LT 55 Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VFOEPortComboBox.FormattingEnabled = True
        Me.VFOEPortComboBox.Location = New System.Drawing.Point(4, 221)
        Me.VFOEPortComboBox.Name = "VFOEPortComboBox"
        Me.VFOEPortComboBox.Size = New System.Drawing.Size(150, 27)
        Me.VFOEPortComboBox.TabIndex = 141
        '
        'VFOCPortComboBox
        '
        Me.VFOCPortComboBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VFOCPortComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.VFOCPortComboBox.Enabled = False
        Me.VFOCPortComboBox.Font = New System.Drawing.Font("HelveticaNeue LT 55 Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VFOCPortComboBox.FormattingEnabled = True
        Me.VFOCPortComboBox.Location = New System.Drawing.Point(4, 153)
        Me.VFOCPortComboBox.Name = "VFOCPortComboBox"
        Me.VFOCPortComboBox.Size = New System.Drawing.Size(150, 27)
        Me.VFOCPortComboBox.TabIndex = 121
        '
        'VFOFPortComboBox
        '
        Me.VFOFPortComboBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VFOFPortComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.VFOFPortComboBox.Enabled = False
        Me.VFOFPortComboBox.Font = New System.Drawing.Font("HelveticaNeue LT 55 Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VFOFPortComboBox.FormattingEnabled = True
        Me.VFOFPortComboBox.Location = New System.Drawing.Point(4, 255)
        Me.VFOFPortComboBox.Name = "VFOFPortComboBox"
        Me.VFOFPortComboBox.Size = New System.Drawing.Size(150, 27)
        Me.VFOFPortComboBox.TabIndex = 151
        '
        'inputRoutingTableLayoutPanel
        '
        Me.inputRoutingTableLayoutPanel.AutoSize = True
        Me.inputRoutingTableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.inputRoutingTableLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.inputRoutingTableLayoutPanel.ColumnCount = 3
        Me.inputRoutingTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.inputRoutingTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.inputRoutingTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.inputRoutingTableLayoutPanel.Controls.Add(Me.outputRoutingLabel, 0, 8)
        Me.inputRoutingTableLayoutPanel.Controls.Add(Me.outputPortComboBox, 1, 9)
        Me.inputRoutingTableLayoutPanel.Controls.Add(Me.SDRConsoleOutputLabel, 0, 9)
        Me.inputRoutingTableLayoutPanel.Controls.Add(Me.VFOBActiveCheckBox, 2, 3)
        Me.inputRoutingTableLayoutPanel.Controls.Add(Me.VFOCActiveCheckBox, 2, 4)
        Me.inputRoutingTableLayoutPanel.Controls.Add(Me.VFOEActiveCheckBox, 2, 6)
        Me.inputRoutingTableLayoutPanel.Controls.Add(Me.VFODActiveCheckBox, 2, 5)
        Me.inputRoutingTableLayoutPanel.Controls.Add(Me.VFOFActiveCheckBox, 2, 7)
        Me.inputRoutingTableLayoutPanel.Controls.Add(Me.inputTableLabelActive, 2, 1)
        Me.inputRoutingTableLayoutPanel.Controls.Add(Me.VFOFLabel, 1, 7)
        Me.inputRoutingTableLayoutPanel.Controls.Add(Me.VFOALabel, 1, 2)
        Me.inputRoutingTableLayoutPanel.Controls.Add(Me.VFOBLabel, 1, 3)
        Me.inputRoutingTableLayoutPanel.Controls.Add(Me.VFOELabel, 1, 6)
        Me.inputRoutingTableLayoutPanel.Controls.Add(Me.VFOCLabel, 1, 4)
        Me.inputRoutingTableLayoutPanel.Controls.Add(Me.VFODLabel, 1, 5)
        Me.inputRoutingTableLayoutPanel.Controls.Add(Me.VFOAActiveCheckBox, 2, 2)
        Me.inputRoutingTableLayoutPanel.Controls.Add(Me.inputTableLabelVFO, 1, 1)
        Me.inputRoutingTableLayoutPanel.Controls.Add(Me.inputTableLabelComPort, 0, 1)
        Me.inputRoutingTableLayoutPanel.Controls.Add(Me.VFOAPortComboBox, 0, 2)
        Me.inputRoutingTableLayoutPanel.Controls.Add(Me.VFOBPortComboBox, 0, 3)
        Me.inputRoutingTableLayoutPanel.Controls.Add(Me.VFOCPortComboBox, 0, 4)
        Me.inputRoutingTableLayoutPanel.Controls.Add(Me.VFODPortComboBox, 0, 5)
        Me.inputRoutingTableLayoutPanel.Controls.Add(Me.VFOEPortComboBox, 0, 6)
        Me.inputRoutingTableLayoutPanel.Controls.Add(Me.VFOFPortComboBox, 0, 7)
        Me.inputRoutingTableLayoutPanel.Controls.Add(Me.inputPanelLabel, 0, 0)
        Me.inputRoutingTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.inputRoutingTableLayoutPanel.ForeColor = System.Drawing.Color.GhostWhite
        Me.inputRoutingTableLayoutPanel.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize
        Me.inputRoutingTableLayoutPanel.Location = New System.Drawing.Point(0, 0)
        Me.inputRoutingTableLayoutPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.inputRoutingTableLayoutPanel.Name = "inputRoutingTableLayoutPanel"
        Me.inputRoutingTableLayoutPanel.RowCount = 10
        Me.inputRoutingTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.inputRoutingTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.inputRoutingTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.inputRoutingTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.inputRoutingTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.inputRoutingTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.inputRoutingTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.inputRoutingTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.inputRoutingTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.inputRoutingTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.inputRoutingTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.inputRoutingTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.inputRoutingTableLayoutPanel.Size = New System.Drawing.Size(396, 396)
        Me.inputRoutingTableLayoutPanel.TabIndex = 24
        '
        'outputRoutingLabel
        '
        Me.outputRoutingLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.outputRoutingLabel.AutoSize = True
        Me.outputRoutingLabel.BackColor = System.Drawing.Color.DimGray
        Me.inputRoutingTableLayoutPanel.SetColumnSpan(Me.outputRoutingLabel, 3)
        Me.outputRoutingLabel.Font = New System.Drawing.Font("HelveticaNeue LT 55 Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.outputRoutingLabel.ForeColor = System.Drawing.Color.Gainsboro
        Me.outputRoutingLabel.Location = New System.Drawing.Point(1, 289)
        Me.outputRoutingLabel.Margin = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me.outputRoutingLabel.Name = "outputRoutingLabel"
        Me.outputRoutingLabel.Padding = New System.Windows.Forms.Padding(0, 24, 0, 8)
        Me.outputRoutingLabel.Size = New System.Drawing.Size(394, 64)
        Me.outputRoutingLabel.TabIndex = 26
        Me.outputRoutingLabel.Text = "OUTPUT ROUTING"
        Me.outputRoutingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'VFOBActiveCheckBox
        '
        Me.VFOBActiveCheckBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VFOBActiveCheckBox.AutoSize = True
        Me.VFOBActiveCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.VFOBActiveCheckBox.Font = New System.Drawing.Font("HelveticaNeue LT 55 Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VFOBActiveCheckBox.Location = New System.Drawing.Point(318, 119)
        Me.VFOBActiveCheckBox.Name = "VFOBActiveCheckBox"
        Me.VFOBActiveCheckBox.Size = New System.Drawing.Size(74, 27)
        Me.VFOBActiveCheckBox.TabIndex = 112
        Me.VFOBActiveCheckBox.UseVisualStyleBackColor = True
        '
        'VFOCActiveCheckBox
        '
        Me.VFOCActiveCheckBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VFOCActiveCheckBox.AutoSize = True
        Me.VFOCActiveCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.VFOCActiveCheckBox.Font = New System.Drawing.Font("HelveticaNeue LT 55 Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VFOCActiveCheckBox.Location = New System.Drawing.Point(318, 153)
        Me.VFOCActiveCheckBox.Name = "VFOCActiveCheckBox"
        Me.VFOCActiveCheckBox.Size = New System.Drawing.Size(74, 27)
        Me.VFOCActiveCheckBox.TabIndex = 122
        Me.VFOCActiveCheckBox.UseVisualStyleBackColor = True
        '
        'VFOEActiveCheckBox
        '
        Me.VFOEActiveCheckBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VFOEActiveCheckBox.AutoSize = True
        Me.VFOEActiveCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.VFOEActiveCheckBox.Font = New System.Drawing.Font("HelveticaNeue LT 55 Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VFOEActiveCheckBox.Location = New System.Drawing.Point(318, 221)
        Me.VFOEActiveCheckBox.Name = "VFOEActiveCheckBox"
        Me.VFOEActiveCheckBox.Size = New System.Drawing.Size(74, 27)
        Me.VFOEActiveCheckBox.TabIndex = 142
        Me.VFOEActiveCheckBox.UseVisualStyleBackColor = True
        '
        'VFODActiveCheckBox
        '
        Me.VFODActiveCheckBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VFODActiveCheckBox.AutoSize = True
        Me.VFODActiveCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.VFODActiveCheckBox.Font = New System.Drawing.Font("HelveticaNeue LT 55 Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VFODActiveCheckBox.Location = New System.Drawing.Point(318, 187)
        Me.VFODActiveCheckBox.Name = "VFODActiveCheckBox"
        Me.VFODActiveCheckBox.Size = New System.Drawing.Size(74, 27)
        Me.VFODActiveCheckBox.TabIndex = 132
        Me.VFODActiveCheckBox.UseVisualStyleBackColor = True
        '
        'VFOFActiveCheckBox
        '
        Me.VFOFActiveCheckBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VFOFActiveCheckBox.AutoSize = True
        Me.VFOFActiveCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.VFOFActiveCheckBox.Font = New System.Drawing.Font("HelveticaNeue LT 55 Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VFOFActiveCheckBox.Location = New System.Drawing.Point(318, 255)
        Me.VFOFActiveCheckBox.Name = "VFOFActiveCheckBox"
        Me.VFOFActiveCheckBox.Size = New System.Drawing.Size(74, 27)
        Me.VFOFActiveCheckBox.TabIndex = 152
        Me.VFOFActiveCheckBox.UseVisualStyleBackColor = True
        '
        'VFOAActiveCheckBox
        '
        Me.VFOAActiveCheckBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VFOAActiveCheckBox.AutoSize = True
        Me.VFOAActiveCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.VFOAActiveCheckBox.Font = New System.Drawing.Font("HelveticaNeue LT 55 Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VFOAActiveCheckBox.Location = New System.Drawing.Point(318, 85)
        Me.VFOAActiveCheckBox.Name = "VFOAActiveCheckBox"
        Me.VFOAActiveCheckBox.Size = New System.Drawing.Size(74, 27)
        Me.VFOAActiveCheckBox.TabIndex = 102
        Me.VFOAActiveCheckBox.UseVisualStyleBackColor = True
        '
        'inputPanelLabel
        '
        Me.inputPanelLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.inputPanelLabel.AutoSize = True
        Me.inputPanelLabel.BackColor = System.Drawing.Color.DimGray
        Me.inputRoutingTableLayoutPanel.SetColumnSpan(Me.inputPanelLabel, 3)
        Me.inputPanelLabel.Font = New System.Drawing.Font("HelveticaNeue LT 55 Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inputPanelLabel.ForeColor = System.Drawing.Color.Gainsboro
        Me.inputPanelLabel.Location = New System.Drawing.Point(4, 1)
        Me.inputPanelLabel.Name = "inputPanelLabel"
        Me.inputPanelLabel.Padding = New System.Windows.Forms.Padding(0, 8, 0, 8)
        Me.inputPanelLabel.Size = New System.Drawing.Size(388, 48)
        Me.inputPanelLabel.TabIndex = 25
        Me.inputPanelLabel.Text = "INPUT ROUTING"
        Me.inputPanelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'comSettingsTableLayoutPanel
        '
        Me.comSettingsTableLayoutPanel.AutoSize = True
        Me.comSettingsTableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.comSettingsTableLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.comSettingsTableLayoutPanel.ColumnCount = 2
        Me.comSettingsTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.comSettingsTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.comSettingsTableLayoutPanel.Controls.Add(Me.enableDebugLabel, 0, 8)
        Me.comSettingsTableLayoutPanel.Controls.Add(Me.Label1, 0, 7)
        Me.comSettingsTableLayoutPanel.Controls.Add(Me.parityComboBox, 1, 4)
        Me.comSettingsTableLayoutPanel.Controls.Add(Me.rescanComPortsButton, 0, 6)
        Me.comSettingsTableLayoutPanel.Controls.Add(Me.comSettingsLabel, 0, 0)
        Me.comSettingsTableLayoutPanel.Controls.Add(Me.stopBitComboBox, 1, 3)
        Me.comSettingsTableLayoutPanel.Controls.Add(Me.dataBitComboBox, 1, 2)
        Me.comSettingsTableLayoutPanel.Controls.Add(Me.baudRateComboBox, 1, 1)
        Me.comSettingsTableLayoutPanel.Controls.Add(Me.parityLabel, 0, 4)
        Me.comSettingsTableLayoutPanel.Controls.Add(Me.stopBitLabel, 0, 3)
        Me.comSettingsTableLayoutPanel.Controls.Add(Me.dataBitLabel, 0, 2)
        Me.comSettingsTableLayoutPanel.Controls.Add(Me.baudRateLabel, 0, 1)
        Me.comSettingsTableLayoutPanel.Controls.Add(Me.saveSpacerLabel, 0, 5)
        Me.comSettingsTableLayoutPanel.Controls.Add(Me.resetButton, 1, 6)
        Me.comSettingsTableLayoutPanel.Controls.Add(Me.enableDebugCheckBox, 1, 8)
        Me.comSettingsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.comSettingsTableLayoutPanel.Location = New System.Drawing.Point(0, 0)
        Me.comSettingsTableLayoutPanel.Name = "comSettingsTableLayoutPanel"
        Me.comSettingsTableLayoutPanel.RowCount = 9
        Me.comSettingsTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.comSettingsTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.comSettingsTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.comSettingsTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.comSettingsTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.comSettingsTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.comSettingsTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64.0!))
        Me.comSettingsTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.comSettingsTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.comSettingsTableLayoutPanel.Size = New System.Drawing.Size(396, 344)
        Me.comSettingsTableLayoutPanel.TabIndex = 27
        '
        'enableDebugLabel
        '
        Me.enableDebugLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.enableDebugLabel.AutoSize = True
        Me.enableDebugLabel.Font = New System.Drawing.Font("HelveticaNeue LT 55 Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.enableDebugLabel.Location = New System.Drawing.Point(85, 313)
        Me.enableDebugLabel.Name = "enableDebugLabel"
        Me.enableDebugLabel.Padding = New System.Windows.Forms.Padding(0, 3, 0, 5)
        Me.enableDebugLabel.Size = New System.Drawing.Size(109, 30)
        Me.enableDebugLabel.TabIndex = 40
        Me.enableDebugLabel.Text = "Enable Debug"
        Me.enableDebugLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.comSettingsTableLayoutPanel.SetColumnSpan(Me.Label1, 3)
        Me.Label1.Location = New System.Drawing.Point(1, 282)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(394, 30)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = " "
        '
        'parityComboBox
        '
        Me.parityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.parityComboBox.Font = New System.Drawing.Font("HelveticaNeue LT 55 Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.parityComboBox.FormattingEnabled = True
        Me.parityComboBox.Location = New System.Drawing.Point(201, 155)
        Me.parityComboBox.Name = "parityComboBox"
        Me.parityComboBox.Size = New System.Drawing.Size(121, 27)
        Me.parityComboBox.TabIndex = 213
        '
        'rescanComPortsButton
        '
        Me.rescanComPortsButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rescanComPortsButton.Font = New System.Drawing.Font("HelveticaNeue LT 55 Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rescanComPortsButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.rescanComPortsButton.Location = New System.Drawing.Point(9, 225)
        Me.rescanComPortsButton.Margin = New System.Windows.Forms.Padding(8)
        Me.rescanComPortsButton.Name = "rescanComPortsButton"
        Me.rescanComPortsButton.Size = New System.Drawing.Size(180, 48)
        Me.rescanComPortsButton.TabIndex = 214
        Me.rescanComPortsButton.Text = "RE-SCAN COM PORTS"
        Me.rescanComPortsButton.UseVisualStyleBackColor = True
        '
        'comSettingsLabel
        '
        Me.comSettingsLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.comSettingsLabel.AutoSize = True
        Me.comSettingsLabel.BackColor = System.Drawing.Color.DimGray
        Me.comSettingsTableLayoutPanel.SetColumnSpan(Me.comSettingsLabel, 2)
        Me.comSettingsLabel.Font = New System.Drawing.Font("HelveticaNeue LT 55 Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comSettingsLabel.ForeColor = System.Drawing.Color.Gainsboro
        Me.comSettingsLabel.Location = New System.Drawing.Point(4, 1)
        Me.comSettingsLabel.Name = "comSettingsLabel"
        Me.comSettingsLabel.Padding = New System.Windows.Forms.Padding(0, 8, 0, 8)
        Me.comSettingsLabel.Size = New System.Drawing.Size(388, 48)
        Me.comSettingsLabel.TabIndex = 26
        Me.comSettingsLabel.Text = "COM PORT SETTINGS"
        Me.comSettingsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'stopBitComboBox
        '
        Me.stopBitComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.stopBitComboBox.Font = New System.Drawing.Font("HelveticaNeue LT 55 Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stopBitComboBox.FormattingEnabled = True
        Me.stopBitComboBox.Location = New System.Drawing.Point(201, 121)
        Me.stopBitComboBox.Name = "stopBitComboBox"
        Me.stopBitComboBox.Size = New System.Drawing.Size(121, 27)
        Me.stopBitComboBox.TabIndex = 212
        '
        'dataBitComboBox
        '
        Me.dataBitComboBox.DisplayMember = "0"
        Me.dataBitComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.dataBitComboBox.Font = New System.Drawing.Font("HelveticaNeue LT 55 Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dataBitComboBox.FormattingEnabled = True
        Me.dataBitComboBox.Location = New System.Drawing.Point(201, 87)
        Me.dataBitComboBox.Name = "dataBitComboBox"
        Me.dataBitComboBox.Size = New System.Drawing.Size(121, 27)
        Me.dataBitComboBox.TabIndex = 211
        '
        'parityLabel
        '
        Me.parityLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.parityLabel.AutoSize = True
        Me.parityLabel.Font = New System.Drawing.Font("HelveticaNeue LT 55 Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.parityLabel.Location = New System.Drawing.Point(145, 152)
        Me.parityLabel.Name = "parityLabel"
        Me.parityLabel.Size = New System.Drawing.Size(49, 33)
        Me.parityLabel.TabIndex = 27
        Me.parityLabel.Text = "Parity"
        Me.parityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'stopBitLabel
        '
        Me.stopBitLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.stopBitLabel.AutoSize = True
        Me.stopBitLabel.Font = New System.Drawing.Font("HelveticaNeue LT 55 Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stopBitLabel.Location = New System.Drawing.Point(127, 118)
        Me.stopBitLabel.Name = "stopBitLabel"
        Me.stopBitLabel.Size = New System.Drawing.Size(67, 33)
        Me.stopBitLabel.TabIndex = 28
        Me.stopBitLabel.Text = "Stop Bit"
        Me.stopBitLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dataBitLabel
        '
        Me.dataBitLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dataBitLabel.AutoSize = True
        Me.dataBitLabel.Font = New System.Drawing.Font("HelveticaNeue LT 55 Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dataBitLabel.Location = New System.Drawing.Point(129, 84)
        Me.dataBitLabel.Name = "dataBitLabel"
        Me.dataBitLabel.Size = New System.Drawing.Size(65, 33)
        Me.dataBitLabel.TabIndex = 10
        Me.dataBitLabel.Text = "Data Bit"
        Me.dataBitLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'baudRateLabel
        '
        Me.baudRateLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.baudRateLabel.AutoSize = True
        Me.baudRateLabel.Font = New System.Drawing.Font("HelveticaNeue LT 55 Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.baudRateLabel.Location = New System.Drawing.Point(111, 50)
        Me.baudRateLabel.Name = "baudRateLabel"
        Me.baudRateLabel.Size = New System.Drawing.Size(83, 33)
        Me.baudRateLabel.TabIndex = 0
        Me.baudRateLabel.Text = "Baud Rate"
        Me.baudRateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'saveSpacerLabel
        '
        Me.saveSpacerLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.saveSpacerLabel.AutoSize = True
        Me.comSettingsTableLayoutPanel.SetColumnSpan(Me.saveSpacerLabel, 3)
        Me.saveSpacerLabel.Location = New System.Drawing.Point(1, 186)
        Me.saveSpacerLabel.Margin = New System.Windows.Forms.Padding(0)
        Me.saveSpacerLabel.Name = "saveSpacerLabel"
        Me.saveSpacerLabel.Size = New System.Drawing.Size(394, 30)
        Me.saveSpacerLabel.TabIndex = 33
        Me.saveSpacerLabel.Text = " "
        '
        'resetButton
        '
        Me.resetButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.resetButton.Font = New System.Drawing.Font("HelveticaNeue LT 55 Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.resetButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.resetButton.Location = New System.Drawing.Point(206, 225)
        Me.resetButton.Margin = New System.Windows.Forms.Padding(8)
        Me.resetButton.Name = "resetButton"
        Me.resetButton.Size = New System.Drawing.Size(181, 48)
        Me.resetButton.TabIndex = 215
        Me.resetButton.Text = "LOAD DEFAULT SETUP"
        Me.resetButton.UseVisualStyleBackColor = True
        '
        'enableDebugCheckBox
        '
        Me.enableDebugCheckBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.enableDebugCheckBox.AutoSize = True
        Me.enableDebugCheckBox.Location = New System.Drawing.Point(198, 313)
        Me.enableDebugCheckBox.Margin = New System.Windows.Forms.Padding(0)
        Me.enableDebugCheckBox.Name = "enableDebugCheckBox"
        Me.enableDebugCheckBox.Padding = New System.Windows.Forms.Padding(8)
        Me.HelpProvider.SetShowHelp(Me.enableDebugCheckBox, False)
        Me.enableDebugCheckBox.Size = New System.Drawing.Size(31, 30)
        Me.enableDebugCheckBox.TabIndex = 216
        Me.enableDebugCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.enableDebugCheckBox.UseVisualStyleBackColor = True
        '
        'mainTabControl
        '
        Me.mainTabControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mainTabControl.Controls.Add(Me.portRoutingTabPage)
        Me.mainTabControl.Controls.Add(Me.portSettingsTabPage)
        Me.mainTabControl.Controls.Add(Me.debugTabPage)
        Me.mainTabControl.Font = New System.Drawing.Font("HelveticaNeue LT 55 Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider.SetHelpKeyword(Me.mainTabControl, "Overview.htm")
        Me.HelpProvider.SetHelpNavigator(Me.mainTabControl, System.Windows.Forms.HelpNavigator.Topic)
        Me.mainTabControl.ItemSize = New System.Drawing.Size(153, 30)
        Me.mainTabControl.Location = New System.Drawing.Point(0, 55)
        Me.mainTabControl.Margin = New System.Windows.Forms.Padding(0)
        Me.mainTabControl.Name = "mainTabControl"
        Me.mainTabControl.Padding = New System.Drawing.Point(26, 3)
        Me.mainTabControl.SelectedIndex = 0
        Me.HelpProvider.SetShowHelp(Me.mainTabControl, True)
        Me.mainTabControl.ShowToolTips = True
        Me.mainTabControl.Size = New System.Drawing.Size(404, 435)
        Me.mainTabControl.TabIndex = 100
        '
        'portRoutingTabPage
        '
        Me.portRoutingTabPage.BackColor = System.Drawing.Color.DimGray
        Me.portRoutingTabPage.Controls.Add(Me.inputRoutingTableLayoutPanel)
        Me.portRoutingTabPage.ForeColor = System.Drawing.Color.Gainsboro
        Me.HelpProvider.SetHelpKeyword(Me.portRoutingTabPage, "")
        Me.HelpProvider.SetHelpNavigator(Me.portRoutingTabPage, System.Windows.Forms.HelpNavigator.TopicId)
        Me.HelpProvider.SetHelpString(Me.portRoutingTabPage, "Routing.htm")
        Me.portRoutingTabPage.Location = New System.Drawing.Point(4, 34)
        Me.portRoutingTabPage.Margin = New System.Windows.Forms.Padding(0)
        Me.portRoutingTabPage.Name = "portRoutingTabPage"
        Me.HelpProvider.SetShowHelp(Me.portRoutingTabPage, True)
        Me.portRoutingTabPage.Size = New System.Drawing.Size(396, 397)
        Me.portRoutingTabPage.TabIndex = 0
        Me.portRoutingTabPage.Text = "ROUTING"
        '
        'portSettingsTabPage
        '
        Me.portSettingsTabPage.BackColor = System.Drawing.Color.DimGray
        Me.portSettingsTabPage.Controls.Add(Me.comSettingsTableLayoutPanel)
        Me.portSettingsTabPage.Font = New System.Drawing.Font("HelveticaNeue LT 55 Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.portSettingsTabPage.ForeColor = System.Drawing.Color.Gainsboro
        Me.HelpProvider.SetHelpKeyword(Me.portSettingsTabPage, "Settings.htm")
        Me.HelpProvider.SetHelpNavigator(Me.portSettingsTabPage, System.Windows.Forms.HelpNavigator.TopicId)
        Me.portSettingsTabPage.Location = New System.Drawing.Point(4, 34)
        Me.portSettingsTabPage.Margin = New System.Windows.Forms.Padding(0)
        Me.portSettingsTabPage.Name = "portSettingsTabPage"
        Me.HelpProvider.SetShowHelp(Me.portSettingsTabPage, True)
        Me.portSettingsTabPage.Size = New System.Drawing.Size(396, 397)
        Me.portSettingsTabPage.TabIndex = 1
        Me.portSettingsTabPage.Text = "SETTINGS"
        '
        'debugTabPage
        '
        Me.debugTabPage.BackColor = System.Drawing.Color.DimGray
        Me.debugTabPage.Controls.Add(Me.debugTableLayoutPanel)
        Me.debugTabPage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.debugTabPage.Location = New System.Drawing.Point(4, 34)
        Me.debugTabPage.Margin = New System.Windows.Forms.Padding(0)
        Me.debugTabPage.Name = "debugTabPage"
        Me.debugTabPage.Size = New System.Drawing.Size(396, 397)
        Me.debugTabPage.TabIndex = 2
        Me.debugTabPage.Text = "DEBUG"
        '
        'debugTableLayoutPanel
        '
        Me.debugTableLayoutPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.debugTableLayoutPanel.ColumnCount = 1
        Me.debugTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.debugTableLayoutPanel.Controls.Add(Me.dataSentTextBox, 0, 3)
        Me.debugTableLayoutPanel.Controls.Add(Me.dataReceivedTextBox, 0, 1)
        Me.debugTableLayoutPanel.Controls.Add(Me.dataReceivedLabel, 0, 0)
        Me.debugTableLayoutPanel.Controls.Add(Me.dataSentLabel, 0, 2)
        Me.debugTableLayoutPanel.Controls.Add(Me.debugClearButton, 0, 4)
        Me.HelpProvider.SetHelpNavigator(Me.debugTableLayoutPanel, System.Windows.Forms.HelpNavigator.TopicId)
        Me.HelpProvider.SetHelpString(Me.debugTableLayoutPanel, "Debug.htm")
        Me.debugTableLayoutPanel.Location = New System.Drawing.Point(8, 3)
        Me.debugTableLayoutPanel.Name = "debugTableLayoutPanel"
        Me.debugTableLayoutPanel.RowCount = 5
        Me.debugTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.debugTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.debugTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.debugTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.debugTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.HelpProvider.SetShowHelp(Me.debugTableLayoutPanel, True)
        Me.debugTableLayoutPanel.Size = New System.Drawing.Size(380, 384)
        Me.debugTableLayoutPanel.TabIndex = 7
        '
        'dataSentTextBox
        '
        Me.dataSentTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dataSentTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dataSentTextBox.Font = New System.Drawing.Font("Monospac821 BT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dataSentTextBox.Location = New System.Drawing.Point(3, 195)
        Me.dataSentTextBox.Multiline = True
        Me.dataSentTextBox.Name = "dataSentTextBox"
        Me.dataSentTextBox.ReadOnly = True
        Me.dataSentTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.dataSentTextBox.Size = New System.Drawing.Size(374, 146)
        Me.dataSentTextBox.TabIndex = 311
        '
        'dataReceivedTextBox
        '
        Me.dataReceivedTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dataReceivedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dataReceivedTextBox.Font = New System.Drawing.Font("Monospac821 BT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dataReceivedTextBox.Location = New System.Drawing.Point(3, 23)
        Me.dataReceivedTextBox.Multiline = True
        Me.dataReceivedTextBox.Name = "dataReceivedTextBox"
        Me.dataReceivedTextBox.ReadOnly = True
        Me.dataReceivedTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.dataReceivedTextBox.Size = New System.Drawing.Size(374, 146)
        Me.dataReceivedTextBox.TabIndex = 310
        '
        'debugClearButton
        '
        Me.debugClearButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.debugTableLayoutPanel.SetColumnSpan(Me.debugClearButton, 3)
        Me.debugClearButton.Font = New System.Drawing.Font("HelveticaNeue LT 55 Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.debugClearButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.debugClearButton.Location = New System.Drawing.Point(3, 347)
        Me.debugClearButton.Name = "debugClearButton"
        Me.debugClearButton.Size = New System.Drawing.Size(75, 34)
        Me.debugClearButton.TabIndex = 312
        Me.debugClearButton.Text = "CLEAR"
        Me.debugClearButton.UseVisualStyleBackColor = True
        '
        'HelpProvider
        '
        Me.HelpProvider.HelpNamespace = "Uni-SDR-Link.chm"
        '
        'showHelpButton
        '
        Me.showHelpButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.showHelpButton.BackColor = System.Drawing.Color.Gray
        Me.showHelpButton.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.showHelpButton.FlatAppearance.BorderSize = 0
        Me.showHelpButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.showHelpButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.showHelpButton.Font = New System.Drawing.Font("HelveticaNeue LT 55 Roman", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.showHelpButton.ForeColor = System.Drawing.Color.White
        Me.HelpProvider.SetHelpKeyword(Me.showHelpButton, "Overview.html")
        Me.HelpProvider.SetHelpNavigator(Me.showHelpButton, System.Windows.Forms.HelpNavigator.TopicId)
        Me.HelpProvider.SetHelpString(Me.showHelpButton, "")
        Me.showHelpButton.Location = New System.Drawing.Point(353, 1)
        Me.showHelpButton.Name = "showHelpButton"
        Me.HelpProvider.SetShowHelp(Me.showHelpButton, True)
        Me.showHelpButton.Size = New System.Drawing.Size(51, 51)
        Me.showHelpButton.TabIndex = 10
        Me.showHelpButton.Text = "?"
        Me.showHelpButton.UseVisualStyleBackColor = False
        '
        'statusTextBox
        '
        Me.statusTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.statusTextBox.BackColor = System.Drawing.Color.Gainsboro
        Me.statusTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.statusTextBox.Font = New System.Drawing.Font("HelveticaNeue LT 55 Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.statusTextBox.Location = New System.Drawing.Point(3, 494)
        Me.statusTextBox.Name = "statusTextBox"
        Me.statusTextBox.ReadOnly = True
        Me.statusTextBox.Size = New System.Drawing.Size(393, 16)
        Me.statusTextBox.TabIndex = 101
        Me.statusTextBox.Text = "Uni-SDR Link Stopped"
        Me.statusTextBox.WordWrap = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.CancelButton = Me.stopMonitorButton
        Me.ClientSize = New System.Drawing.Size(404, 513)
        Me.Controls.Add(Me.statusTextBox)
        Me.Controls.Add(Me.showHelpButton)
        Me.Controls.Add(Me.mainTabControl)
        Me.Controls.Add(Me.startMonitorButton)
        Me.Controls.Add(Me.stopMonitorButton)
        Me.HelpButton = True
        Me.HelpProvider.SetHelpKeyword(Me, "Overview.html")
        Me.HelpProvider.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.TopicId)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(414, 544)
        Me.Name = "MainForm"
        Me.HelpProvider.SetShowHelp(Me, True)
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.Text = "Uni-SDR Link v1.0.0.0"
        Me.inputRoutingTableLayoutPanel.ResumeLayout(False)
        Me.inputRoutingTableLayoutPanel.PerformLayout()
        Me.comSettingsTableLayoutPanel.ResumeLayout(False)
        Me.comSettingsTableLayoutPanel.PerformLayout()
        Me.mainTabControl.ResumeLayout(False)
        Me.portRoutingTabPage.ResumeLayout(False)
        Me.portRoutingTabPage.PerformLayout()
        Me.portSettingsTabPage.ResumeLayout(False)
        Me.portSettingsTabPage.PerformLayout()
        Me.debugTabPage.ResumeLayout(False)
        Me.debugTableLayoutPanel.ResumeLayout(False)
        Me.debugTableLayoutPanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents startMonitorButton As System.Windows.Forms.Button
    Friend WithEvents stopMonitorButton As System.Windows.Forms.Button
    Friend WithEvents dataReceivedLabel As System.Windows.Forms.Label
    Friend WithEvents dataSentLabel As System.Windows.Forms.Label
    Friend WithEvents SerialPortVFOA As System.IO.Ports.SerialPort
    Friend WithEvents SerialPortVFOB As System.IO.Ports.SerialPort
    Friend WithEvents SerialPortVFOC As System.IO.Ports.SerialPort
    Friend WithEvents SerialPortVFOD As System.IO.Ports.SerialPort
    Friend WithEvents SerialPortVFOE As System.IO.Ports.SerialPort
    Friend WithEvents SerialPortVFOF As System.IO.Ports.SerialPort
    Friend WithEvents SerialPortOutput As System.IO.Ports.SerialPort
    Friend WithEvents baudRateComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents outputPortComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents SDRConsoleOutputLabel As System.Windows.Forms.Label
    Friend WithEvents VFODLabel As System.Windows.Forms.Label
    Friend WithEvents VFOCLabel As System.Windows.Forms.Label
    Friend WithEvents VFOELabel As System.Windows.Forms.Label
    Friend WithEvents VFOBLabel As System.Windows.Forms.Label
    Friend WithEvents inputTableLabelVFO As System.Windows.Forms.Label
    Friend WithEvents VFOALabel As System.Windows.Forms.Label
    Friend WithEvents VFOFLabel As System.Windows.Forms.Label
    Friend WithEvents inputTableLabelComPort As System.Windows.Forms.Label
    Friend WithEvents VFOAPortComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents VFOBPortComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents VFODPortComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents inputTableLabelActive As System.Windows.Forms.Label
    Friend WithEvents VFOEPortComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents VFOCPortComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents VFOFPortComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents inputRoutingTableLayoutPanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents VFOBActiveCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents VFOCActiveCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents VFOEActiveCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents VFODActiveCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents VFOFActiveCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents VFOAActiveCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents inputPanelLabel As System.Windows.Forms.Label
    Friend WithEvents comSettingsLabel As System.Windows.Forms.Label
    Friend WithEvents comSettingsTableLayoutPanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents baudRateLabel As System.Windows.Forms.Label
    Friend WithEvents parityComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents stopBitComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents dataBitComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents parityLabel As System.Windows.Forms.Label
    Friend WithEvents stopBitLabel As System.Windows.Forms.Label
    Friend WithEvents dataBitLabel As System.Windows.Forms.Label
    Friend WithEvents mainTabControl As System.Windows.Forms.TabControl
    Friend WithEvents portRoutingTabPage As System.Windows.Forms.TabPage
    Friend WithEvents portSettingsTabPage As System.Windows.Forms.TabPage
    Friend WithEvents debugTabPage As System.Windows.Forms.TabPage
    Friend WithEvents outputRoutingLabel As System.Windows.Forms.Label
    Friend WithEvents debugTableLayoutPanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents debugClearButton As System.Windows.Forms.Button
    Friend WithEvents saveSpacerLabel As System.Windows.Forms.Label
    Friend WithEvents rescanComPortsButton As System.Windows.Forms.Button
    Friend WithEvents resetButton As System.Windows.Forms.Button
    Friend WithEvents enableDebugLabel As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents enableDebugCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents HelpProvider As System.Windows.Forms.HelpProvider
    Friend WithEvents showHelpButton As System.Windows.Forms.Button
    Friend WithEvents dataSentTextBox As System.Windows.Forms.TextBox
    Friend WithEvents dataReceivedTextBox As System.Windows.Forms.TextBox
    Friend WithEvents statusTextBox As System.Windows.Forms.TextBox

End Class
