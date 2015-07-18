Imports System
Imports System.Threading
Imports System.Threading.Thread
Imports System.IO.Ports
Imports System.ComponentModel
Imports System.Text.RegularExpressions
Imports System.Windows.Forms.ContainerControl


Public Class MainForm

    Dim vfoCount As Integer = 5
    Dim sysComPorts As Array
    Dim baudRates(5) As String
    Dim dataBits(1) As String
    Dim stopBits(1) As String
    Dim parities(2) As String
    Dim serialInputEOL As String = Chr(13) & Chr(10)
    Dim serialOutputEOL As String = ";"
    Dim vfoPorts(vfoCount) As SerialPort
    Dim vfoComboBoxes(vfoCount) As ComboBox
    Dim vfoCheckBoxes(vfoCount) As CheckBox
    Dim vfoBuffer As String
    Dim ouputBuffer As String

    Delegate Sub setStatusTextCallBack(ByVal [text] As String)
    Delegate Sub setDebugReceiverTextCallBack(ByVal [text] As String, ByVal [vfoKey] As Integer)
    Delegate Sub setDebugSenderTextCallBack(ByVal [text] As String)

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        getSystemSerialPorts()
        initPortSettingObjects()

        initRoutingObjects()
        loadSettings()

        initEnableDebugObject()

    End Sub

    Private Sub MainForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed

        stopMonitor()
        saveSettings()

    End Sub

    Private Sub startMonitor()

        'Set form control states
        startMonitorButton.Enabled = False
        startMonitorButton.Visible = False
        stopMonitorButton.Enabled = True
        inputRoutingTableLayoutPanel.Enabled = False
        comSettingsTableLayoutPanel.Enabled = False

        setStatusText("Uni-SDR Link Started")

        If My.Settings.enableDebug Then
            mainTabControl.SelectedTab = debugTabPage
        End If

        'Validate user selections
        If validatePortSelections() Then

            'Open input serial ports
            For i = 0 To vfoCount
                If vfoCheckBoxes(i).Checked And String.IsNullOrEmpty(vfoComboBoxes(i).Text) = False Then
                    vfoPorts(i).PortName = vfoComboBoxes(i).Text

                    If openSerialPort(vfoPorts(i)) = False Then
                        'MessageBox.Show(vfoPorts(i).PortName & " could not be opened")
                        stopMonitor()
                        mainTabControl.SelectedTab = portRoutingTabPage
                        Exit Sub
                    End If
                    Console.WriteLine(vfoComboBoxes(i).Text & " opened vfoPorts(" & i & ")")
                Else
                    Console.WriteLine("Com Port Index " & i & " not active")
                End If
            Next i

            'Open output serial port

            SerialPortOutput.PortName = outputPortComboBox.Text
            SerialPortOutput.NewLine = serialOutputEOL


            If openSerialPort(SerialPortOutput) = False Then
                'MessageBox.Show(SerialPortOutput.PortName & " could not be opened")
                stopMonitor()
                mainTabControl.SelectedTab = portRoutingTabPage
                Exit Sub
            End If
        End If

    End Sub

    Private Sub stopMonitor()

        'Set form control states
        startMonitorButton.Enabled = True
        startMonitorButton.Visible = True
        stopMonitorButton.Enabled = False
        comSettingsTableLayoutPanel.Enabled = True
        inputRoutingTableLayoutPanel.Enabled = True

        setStatusText("Uni-SDR Link Stopped")

        'Close input serial ports
        For i = 0 To vfoCount
            closeSerialPort(vfoPorts(i))
        Next i

        'Close output serial port
        closeSerialPort(SerialPortOutput)

    End Sub

    Private Function getFriendlyVFO(vfoKey As Integer)

        Dim vfoLetter As String

        Select Case vfoKey
            Case 0
                vfoLetter = "A"
            Case 1
                vfoLetter = "B"
            Case 2
                vfoLetter = "C"
            Case 3
                vfoLetter = "D"
            Case 4
                vfoLetter = "E"
            Case 5
                vfoLetter = "F"
            Case Else
                vfoLetter = "ERR"
        End Select

        Return vfoLetter

    End Function

    Private Sub setStatusText(status As String)

        If Me.statusTextBox.InvokeRequired Then
            Dim x As New setStatusTextCallBack(AddressOf setStatusText)
            Me.Invoke(x, New Object() {status})
        Else
            statusTextBox.Text = status
        End If

    End Sub

    Private Sub outputTranslator(ByVal [text] As String, ByVal vfoKey As Integer)
        Console.WriteLine("outputTranslator Started")

        Dim pattern As String
        Dim outputStream As String
        Dim freqPrefix As String
        Dim friendlyVFO As String
        Dim outputFreq As String
        Dim statusText As String
        Dim objRegex As Regex
        Dim match As Match

        freqPrefix = "RF"
        pattern = "(RF\d{10})"
        objRegex = New Regex(pattern)
        match = objRegex.Match([text])

        If match.Success Then
            Console.WriteLine("Frequency Command Found")

            friendlyVFO = getFriendlyVFO(vfoKey)

            outputFreq = text.Trim()
            outputFreq = outputFreq.Replace(Chr(10), "")
            outputFreq = outputFreq.Replace(Chr(13), "")
            outputFreq = outputFreq.Replace("RF", "")
            outputFreq = "0" + outputFreq


            statusText = "VFO-" + friendlyVFO + " tuned to " + outputFreq

            outputStream = serialOutputEOL & "F" & friendlyVFO & outputFreq & serialOutputEOL


            Console.WriteLine("outputStream = " & outputStream)
            If My.Settings.enableDebug Then
                debugSender(outputStream)
            End If


            setStatusText(statusText)

            outputTransmitter(outputStream)


        Else
            Console.WriteLine("Not a frequency command")
        End If

    End Sub

    Private Sub outputTransmitter(ByVal command As String)

        If SerialPortOutput.BytesToWrite < 0 Then
            outputTransmitter(command)
        Else
            Console.WriteLine("Command " & command & " sent")
            SerialPortOutput.Write(command)
        End If

    End Sub

    Private Sub dataReceiver(ByVal [text] As String, ByVal vfoKey As Integer)

        Dim eolIndex As Integer
        Dim outputFrame As String
        Dim buffer As String
        buffer = vfoBuffer

        If My.Settings.enableDebug Then
            debugReceiver(text, vfoKey)
        End If

        Console.WriteLine("dataReceiver Started")

        buffer &= [text]
        eolIndex = buffer.IndexOf(serialInputEOL)
        Console.WriteLine("eolIndex = " & eolIndex)

        Do While (buffer.Length > 0 And eolIndex > -1)
            If eolIndex > -1 Then
                outputFrame = buffer.Substring(0, eolIndex)
                Console.WriteLine("outputFrame = " & outputFrame)

                buffer = buffer.Remove(0, eolIndex + 2)
                outputTranslator(outputFrame, vfoKey)

                eolIndex = buffer.IndexOf(serialInputEOL)
                Console.WriteLine("eolIndex = " & eolIndex)
            End If
        Loop

    End Sub

    Private Sub launchHelp()
        Help.ShowHelp(Me, HelpProvider.HelpNamespace)
    End Sub

    'Serial port functions
    Private Sub getSystemSerialPorts()
        sysComPorts = System.IO.Ports.SerialPort.GetPortNames()
    End Sub

    Private Function validatePortSelections()
        Dim selectedPorts As String = ""
        Dim currentPort As String
        Dim activeVFOCount As Integer = 0

        'Get serial port input selections
        For i = 0 To vfoCount
            If String.IsNullOrEmpty(vfoComboBoxes(i).Text) = False And vfoCheckBoxes(i).Checked = True Then
                currentPort = vfoComboBoxes(i).Text & ","

                'Check for duplicate port selections
                If selectedPorts.IndexOf(currentPort) < 0 Then
                    selectedPorts &= currentPort
                    activeVFOCount = activeVFOCount + 1

                Else
                    portOperationFail(vfoComboBoxes(i).Text & " has been assigned to multiple VFO's.  A port may only be assigned to a single VFO.")
                    Return False
                End If
            End If


        Next i

        If activeVFOCount = 0 Then
            portOperationFail("You must assign a port to at least 1 VFO.")
            Return False
        End If

        'Get serial port output selection
        currentPort = outputPortComboBox.Text

        'Verify output port is selected or exit with error.
        If String.IsNullOrEmpty(currentPort) Then
            portOperationFail("Please assign a port to the SDR Console output.")
            Return False
        ElseIf selectedPorts.IndexOf(currentPort) > -1 Then
            portOperationFail("The port assigned to the SDR Console output has already been assigned to a VFO.  Please select a different port.")
            Return False
        End If

        Return True

    End Function

    Private Sub portOperationFail(message As String)
        MsgBox(message, MsgBoxStyle.Critical, "Serial Port Error")
        stopMonitor()
        mainTabControl.SelectedTab = portRoutingTabPage
    End Sub

    Private Sub initSerialPort(port As SerialPort)

        'Apply common serial port settings
        port.BaudRate = baudRateComboBox.Text
        port.DataBits = dataBitComboBox.Text

        If stopBitComboBox.Text = "1" Then
            port.StopBits = IO.Ports.StopBits.One
        Else
            port.StopBits = IO.Ports.StopBits.Two
        End If

        If parityComboBox.Text = "Even" Then
            port.Parity = Parity.Even
        ElseIf parityComboBox.Text = "Odd" Then
            port.Parity = Parity.Odd
        Else
            port.Parity = Parity.None
        End If

    End Sub

    Private Function openSerialPort(port As SerialPort)

        If port.IsOpen = False Then
            initSerialPort(port)
            Try
                port.Open()
            Catch ex As Exception
                portOperationFail("Error opening " & port.PortName & " - " & ex.Message)
                Return False
            End Try
        End If

        If port.IsOpen Then
            Return True
        Else
            Return False
        End If

    End Function

    Private Sub closeSerialPort(port As SerialPort)

        If port.IsOpen Then
            port.Close()
        End If

    End Sub

    'Debug functions
    Private Sub debugReceiver(ByVal [text] As String, ByVal vfoKey As Integer)

        Dim logText As String
        Dim timestamp As String
        Dim friendlyVFO As String
        Dim vfo As String

        friendlyVFO = getFriendlyVFO(vfoKey)
        vfo = "VFO-" + friendlyVFO

        timestamp = DateAndTime.Now.ToString("MM/dd/yy H:mm:ss.fff")

        logText = timestamp & " "
        logText &= vfo & " > "
        logText &= text.Replace(serialInputEOL, " / ")
        logText &= vbCrLf

        If Me.dataReceivedTextBox.InvokeRequired Then
            Dim x As New setDebugReceiverTextCallBack(AddressOf debugReceiver)
            Me.Invoke(x, New Object() {text, vfoKey})
        Else
            debugTruncateLog(dataReceivedTextBox)
            Me.dataReceivedTextBox.AppendText(logText)
            Me.dataReceivedTextBox.ScrollToCaret()
        End If

    End Sub

    Private Sub debugSender(ByVal [text] As String)

        Dim logText As String
        Dim timestamp As String

        timestamp = DateAndTime.Now.ToString("MM/dd/yy H:mm:ss.fff")
        logText = timestamp & " > "
        logText &= text
        logText &= vbCrLf

        If Me.dataReceivedTextBox.InvokeRequired Then
            Dim x As New setDebugSenderTextCallBack(AddressOf debugSender)
            Me.Invoke(x, New Object() {text})
        Else
            debugTruncateLog(dataSentTextBox)
            Me.dataSentTextBox.AppendText(logText)
            Me.dataSentTextBox.ScrollToCaret()
        End If

    End Sub

    Private Sub debugClear()
        dataSentTextBox.ResetText()
        dataReceivedTextBox.ResetText()
    End Sub

    Private Sub debugTruncateLog(debugTarget As TextBox)
        Dim logLength As Integer
        logLength = debugTarget.TextLength

        If logLength > 20000 Then

            Dim newLogText As String
            Dim eolIndex As Integer

            newLogText = debugTarget.Text.Remove(0, 5000)
            eolIndex = newLogText.IndexOf(vbCrLf)
            newLogText = newLogText.Remove(0, eolIndex + 1)
            newLogText &= "========== LOG LIMIT REACHED =========" & vbCrLf
            newLogText &= "=== OLDEST 5000 CHARACTERS REMOVED ===" & vbCrLf

            debugTarget.Text = newLogText

        End If
    End Sub

    'User settings functions
    Private Sub saveSettings()

        My.Settings.userSettingsExist = True

        My.Settings.VFOAActive = VFOAActiveCheckBox.Checked
        My.Settings.VFOBActive = VFOBActiveCheckBox.Checked
        My.Settings.VFOCActive = VFOCActiveCheckBox.Checked
        My.Settings.VFODActive = VFODActiveCheckBox.Checked
        My.Settings.VFOEActive = VFOEActiveCheckBox.Checked
        My.Settings.VFOFActive = VFOFActiveCheckBox.Checked

        If String.IsNullOrEmpty(VFOAPortComboBox.SelectedItem) = False Then
            My.Settings.VFOAPort = VFOAPortComboBox.SelectedItem
        End If

        If String.IsNullOrEmpty(VFOBPortComboBox.SelectedItem) = False Then
            My.Settings.VFOBPort = VFOBPortComboBox.SelectedItem
        End If

        If String.IsNullOrEmpty(VFOCPortComboBox.SelectedItem) = False Then
            My.Settings.VFOCPort = VFOCPortComboBox.SelectedItem
        End If

        If String.IsNullOrEmpty(VFODPortComboBox.SelectedItem) = False Then
            My.Settings.VFODPort = VFODPortComboBox.SelectedItem
        End If

        If String.IsNullOrEmpty(VFOEPortComboBox.SelectedItem) = False Then
            My.Settings.VFOEPort = VFOEPortComboBox.SelectedItem
        End If

        If String.IsNullOrEmpty(VFOFPortComboBox.SelectedItem) = False Then
            My.Settings.VFOFPort = VFOFPortComboBox.SelectedItem
        End If

        If String.IsNullOrEmpty(outputPortComboBox.SelectedItem) = False Then
            My.Settings.OutputPort = outputPortComboBox.SelectedItem
        End If

        My.Settings.portBaudRate = baudRateComboBox.SelectedIndex
        My.Settings.portParity = parityComboBox.SelectedIndex
        My.Settings.portStopBit = stopBitComboBox.SelectedIndex
        My.Settings.portDataBit = dataBitComboBox.SelectedIndex

        My.Settings.enableDebug = enableDebugCheckBox.Checked

    End Sub

    Private Sub loadSettings()

        If My.Settings.userSettingsExist Then

            'Init port settings
            baudRateComboBox.SelectedIndex = My.Settings.portBaudRate
            dataBitComboBox.SelectedIndex = My.Settings.portDataBit
            stopBitComboBox.SelectedIndex = My.Settings.portStopBit
            parityComboBox.SelectedIndex = My.Settings.portParity

            'Init routing selections
            vfoCheckBoxes(0).Checked = My.Settings.VFOAActive
            vfoCheckBoxes(1).Checked = My.Settings.VFOBActive
            vfoCheckBoxes(2).Checked = My.Settings.VFOCActive
            vfoCheckBoxes(3).Checked = My.Settings.VFODActive
            vfoCheckBoxes(4).Checked = My.Settings.VFOEActive
            vfoCheckBoxes(5).Checked = My.Settings.VFOFActive

            vfoComboBoxes(0).SelectedIndex = vfoComboBoxes(0).FindString(My.Settings.VFOAPort)
            vfoComboBoxes(1).SelectedIndex = vfoComboBoxes(1).FindString(My.Settings.VFOBPort)
            vfoComboBoxes(2).SelectedIndex = vfoComboBoxes(2).FindString(My.Settings.VFOCPort)
            vfoComboBoxes(3).SelectedIndex = vfoComboBoxes(3).FindString(My.Settings.VFODPort)
            vfoComboBoxes(4).SelectedIndex = vfoComboBoxes(4).FindString(My.Settings.VFOEPort)
            vfoComboBoxes(5).SelectedIndex = vfoComboBoxes(5).FindString(My.Settings.VFOFPort)

            outputPortComboBox.SelectedIndex = outputPortComboBox.FindString(My.Settings.OutputPort)

            enableDebugCheckBox.Checked = My.Settings.enableDebug
        Else
            loadDefaultSettings()
        End If

    End Sub

    Private Sub loadDefaultSettings()

        baudRateComboBox.SelectedIndex = My.Settings.defaultPortBaudRate
        dataBitComboBox.SelectedIndex = My.Settings.defaultPortDataBit
        stopBitComboBox.SelectedIndex = My.Settings.defaultPortStopBit
        parityComboBox.SelectedIndex = My.Settings.defaultPortParity

        vfoCheckBoxes(0).Checked = My.Settings.defaultVFOAActive
        vfoCheckBoxes(1).Checked = My.Settings.defaultVFOBActive
        vfoCheckBoxes(2).Checked = My.Settings.defaultVFOCActive
        vfoCheckBoxes(3).Checked = My.Settings.defaultVFODActive
        vfoCheckBoxes(4).Checked = My.Settings.defaultVFOEActive
        vfoCheckBoxes(5).Checked = My.Settings.defaultVFOFActive

        vfoComboBoxes(0).SelectedIndex = vfoComboBoxes(0).FindString(My.Settings.defaultVFOAPort)
        vfoComboBoxes(1).SelectedIndex = vfoComboBoxes(1).FindString(My.Settings.defaultVFOBPort)
        vfoComboBoxes(2).SelectedIndex = vfoComboBoxes(2).FindString(My.Settings.defaultVFOCPort)
        vfoComboBoxes(3).SelectedIndex = vfoComboBoxes(3).FindString(My.Settings.defaultVFODPort)
        vfoComboBoxes(4).SelectedIndex = vfoComboBoxes(4).FindString(My.Settings.defaultVFOEPort)
        vfoComboBoxes(5).SelectedIndex = vfoComboBoxes(5).FindString(My.Settings.defaultVFOFPort)

        outputPortComboBox.SelectedIndex = outputPortComboBox.FindString(My.Settings.defaultOutputPort)

        enableDebugCheckBox.Checked = My.Settings.defaultEnableDebug

        My.Settings.userSettingsExist = False

    End Sub

    'Form object functions
    Private Sub initPortSettingObjects()
        baudRates(0) = "57600"
        baudRates(1) = "38400"
        baudRates(2) = "19200"
        baudRates(3) = "9600"
        baudRates(4) = "4800"
        baudRates(5) = "1200"
        baudRateComboBox.Items.AddRange(baudRates)

        dataBits(0) = "7"
        dataBits(1) = "8"
        dataBitComboBox.Items.AddRange(dataBits)

        stopBits(0) = "1"
        stopBits(1) = "2"
        stopBitComboBox.Items.AddRange(stopBits)

        parities(0) = "None"
        parities(1) = "Even"
        parities(2) = "Odd"
        parityComboBox.Items.AddRange(parities)

    End Sub

    Private Sub initEnableDebugObject()

        enableDebugCheckBox.Checked = My.Settings.enableDebug

    End Sub

    Private Sub initRoutingObjects()

        'Create VFO elements
        vfoPorts(0) = SerialPortVFOA
        vfoPorts(1) = SerialPortVFOB
        vfoPorts(2) = SerialPortVFOC
        vfoPorts(3) = SerialPortVFOD
        vfoPorts(4) = SerialPortVFOE
        vfoPorts(5) = SerialPortVFOF

        vfoComboBoxes(0) = VFOAPortComboBox
        vfoComboBoxes(1) = VFOBPortComboBox
        vfoComboBoxes(2) = VFOCPortComboBox
        vfoComboBoxes(3) = VFODPortComboBox
        vfoComboBoxes(4) = VFOEPortComboBox
        vfoComboBoxes(5) = VFOFPortComboBox

        vfoCheckBoxes(0) = VFOAActiveCheckBox
        vfoCheckBoxes(1) = VFOBActiveCheckBox
        vfoCheckBoxes(2) = VFOCActiveCheckBox
        vfoCheckBoxes(3) = VFODActiveCheckBox
        vfoCheckBoxes(4) = VFOEActiveCheckBox
        vfoCheckBoxes(5) = VFOFActiveCheckBox

        setSerialPortValues()

    End Sub

    Private Sub setSerialPortValues()

        getSystemSerialPorts()

        For i = 0 To vfoCount
            vfoComboBoxes(i).Items.Clear()
            vfoComboBoxes(i).Items.AddRange(sysComPorts)
        Next i

        'Create output element
        outputPortComboBox.Items.Clear()
        outputPortComboBox.Items.AddRange(sysComPorts)

    End Sub

    'Form object event Handlers
    Private Sub startMonitorButton_Click(sender As Object, e As EventArgs) Handles startMonitorButton.Click

        startMonitor()

    End Sub

    Private Sub stopMonitorButton_Click(sender As Object, e As EventArgs) Handles stopMonitorButton.Click

        stopMonitor()

    End Sub

    Private Sub SerialPortVFOA_DataReceived(sender As Object, e As SerialDataReceivedEventArgs) Handles SerialPortVFOA.DataReceived

        Dim spdata As String
        Dim vfoKey As Integer = 0
        spdata = SerialPortVFOA.ReadExisting()
        Console.WriteLine("VFO A Data Received = " & spdata)

        dataReceiver(spdata, vfoKey)

    End Sub

    Private Sub SerialPortVFOB_DataReceived(sender As Object, e As SerialDataReceivedEventArgs) Handles SerialPortVFOB.DataReceived

        Dim spdata As String
        Dim vfoKey As Integer = 1
        spdata = SerialPortVFOB.ReadExisting()
        Console.WriteLine("VFO B Data Received = " & spdata)

        dataReceiver(spdata, vfoKey)

    End Sub

    Private Sub SerialPortVFOC_DataReceived(sender As Object, e As SerialDataReceivedEventArgs) Handles SerialPortVFOC.DataReceived
        Dim spdata As String
        Dim vfoKey As Integer = 2
        spdata = SerialPortVFOC.ReadExisting()
        Console.WriteLine("VFO C Data Received = " & spdata)

        dataReceiver(spdata, vfoKey)

    End Sub

    Private Sub SerialPortVFOD_DataReceived(sender As Object, e As SerialDataReceivedEventArgs) Handles SerialPortVFOD.DataReceived
        Dim spdata As String
        Dim vfoKey As Integer = 3
        spdata = SerialPortVFOD.ReadExisting()
        Console.WriteLine("VFO D Data Received = " & spdata)

        dataReceiver(spdata, vfoKey)

    End Sub

    Private Sub SerialPortVFOE_DataReceived(sender As Object, e As SerialDataReceivedEventArgs) Handles SerialPortVFOE.DataReceived
        Dim spdata As String
        Dim vfoKey As Integer = 4
        spdata = SerialPortVFOE.ReadExisting()
        Console.WriteLine("VFO E Data Received = " & spdata)

        dataReceiver(spdata, vfoKey)

    End Sub

    Private Sub SerialPortVFOF_DataReceived(sender As Object, e As SerialDataReceivedEventArgs) Handles SerialPortVFOF.DataReceived
        Dim spdata As String
        Dim vfoKey As Integer = 5
        spdata = SerialPortVFOF.ReadExisting()
        Console.WriteLine("VFO F Data Received = " & spdata)

        dataReceiver(spdata, vfoKey)

    End Sub

    Private Sub VFOAActiveCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles VFOAActiveCheckBox.CheckedChanged
        If Me.VFOAActiveCheckBox.Checked Then
            Me.VFOAPortComboBox.Enabled = True
        Else
            Me.VFOAPortComboBox.Enabled = False
        End If
    End Sub

    Private Sub VFOBActiveCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles VFOBActiveCheckBox.CheckedChanged
        If Me.VFOBActiveCheckBox.Checked Then
            Me.VFOBPortComboBox.Enabled = True
        Else
            Me.VFOBPortComboBox.Enabled = False
        End If
    End Sub

    Private Sub VFOCActiveCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles VFOCActiveCheckBox.CheckedChanged
        If Me.VFOCActiveCheckBox.Checked Then
            Me.VFOCPortComboBox.Enabled = True
        Else
            Me.VFOCPortComboBox.Enabled = False
        End If
    End Sub

    Private Sub VFODActiveCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles VFODActiveCheckBox.CheckedChanged
        If Me.VFODActiveCheckBox.Checked Then
            Me.VFODPortComboBox.Enabled = True
        Else
            Me.VFODPortComboBox.Enabled = False
        End If
    End Sub

    Private Sub VFOEActiveCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles VFOEActiveCheckBox.CheckedChanged
        If Me.VFOEActiveCheckBox.Checked Then
            Me.VFOEPortComboBox.Enabled = True
        Else
            Me.VFOEPortComboBox.Enabled = False
        End If
    End Sub

    Private Sub VFOFActiveCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles VFOFActiveCheckBox.CheckedChanged
        If Me.VFOFActiveCheckBox.Checked Then
            Me.VFOFPortComboBox.Enabled = True
        Else
            Me.VFOFPortComboBox.Enabled = False
        End If
    End Sub

    Private Sub rescanComPortsButton_Click(sender As Object, e As EventArgs) Handles rescanComPortsButton.Click

        setSerialPortValues()
        loadSettings()

    End Sub

    Private Sub resetButton_Click(sender As Object, e As EventArgs) Handles resetButton.Click
        loadDefaultSettings()
    End Sub

    Private Sub debugClearButton_Click(sender As Object, e As EventArgs) Handles debugClearButton.Click
        debugClear()
    End Sub

    Private Sub enableDebugCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles enableDebugCheckBox.CheckedChanged

        If enableDebugCheckBox.Checked Then
            My.Settings.enableDebug = True
        Else
            My.Settings.enableDebug = False
        End If

    End Sub

    Private Sub showHelpButton_Click(sender As Object, e As EventArgs) Handles showHelpButton.Click
        launchHelp()
    End Sub

End Class
