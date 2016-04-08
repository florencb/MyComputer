<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblDisplayAvailableMemory = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblDisplayTotalMemory = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblDisplayLanguage = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblDisplayOSVersion = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblDisplayOperatingSystem = New System.Windows.Forms.Label()
        Me.lblDisplayOSPlatform = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblDisplayUserName = New System.Windows.Forms.Label()
        Me.lblDisplayComputerName = New System.Windows.Forms.Label()
        Me.lblDisplayCPUName = New System.Windows.Forms.Label()
        Me.tmrDisplayMemory = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblDisplayAvailableMemory)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.lblDisplayTotalMemory)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Location = New System.Drawing.Point(43, 292)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(602, 108)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Physical Memory (MB)"
        '
        'lblDisplayAvailableMemory
        '
        Me.lblDisplayAvailableMemory.AutoSize = True
        Me.lblDisplayAvailableMemory.Location = New System.Drawing.Point(360, 51)
        Me.lblDisplayAvailableMemory.Name = "lblDisplayAvailableMemory"
        Me.lblDisplayAvailableMemory.Size = New System.Drawing.Size(127, 13)
        Me.lblDisplayAvailableMemory.TabIndex = 9
        Me.lblDisplayAvailableMemory.Text = "Display Available Memory"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 51)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(93, 13)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Available Memory:"
        '
        'lblDisplayTotalMemory
        '
        Me.lblDisplayTotalMemory.AutoSize = True
        Me.lblDisplayTotalMemory.Location = New System.Drawing.Point(360, 20)
        Me.lblDisplayTotalMemory.Name = "lblDisplayTotalMemory"
        Me.lblDisplayTotalMemory.Size = New System.Drawing.Size(108, 13)
        Me.lblDisplayTotalMemory.TabIndex = 8
        Me.lblDisplayTotalMemory.Text = "Display Total Memory"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 20)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Total Memory:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.lblDisplayLanguage)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.lblDisplayOSVersion)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.lblDisplayOperatingSystem)
        Me.GroupBox2.Controls.Add(Me.lblDisplayOSPlatform)
        Me.GroupBox2.Location = New System.Drawing.Point(43, 165)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(602, 121)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Operating System Information"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 103)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Language:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 74)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "OS Version"
        '
        'lblDisplayLanguage
        '
        Me.lblDisplayLanguage.AutoSize = True
        Me.lblDisplayLanguage.Location = New System.Drawing.Point(360, 103)
        Me.lblDisplayLanguage.Name = "lblDisplayLanguage"
        Me.lblDisplayLanguage.Size = New System.Drawing.Size(92, 13)
        Me.lblDisplayLanguage.TabIndex = 7
        Me.lblDisplayLanguage.Text = "Display Language"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 45)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "OS Platform:"
        '
        'lblDisplayOSVersion
        '
        Me.lblDisplayOSVersion.AutoSize = True
        Me.lblDisplayOSVersion.Location = New System.Drawing.Point(360, 74)
        Me.lblDisplayOSVersion.Name = "lblDisplayOSVersion"
        Me.lblDisplayOSVersion.Size = New System.Drawing.Size(97, 13)
        Me.lblDisplayOSVersion.TabIndex = 6
        Me.lblDisplayOSVersion.Text = "Display OS Version"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Operating System:"
        '
        'lblDisplayOperatingSystem
        '
        Me.lblDisplayOperatingSystem.AutoSize = True
        Me.lblDisplayOperatingSystem.Location = New System.Drawing.Point(360, 16)
        Me.lblDisplayOperatingSystem.Name = "lblDisplayOperatingSystem"
        Me.lblDisplayOperatingSystem.Size = New System.Drawing.Size(127, 13)
        Me.lblDisplayOperatingSystem.TabIndex = 4
        Me.lblDisplayOperatingSystem.Text = "Display Operating System"
        '
        'lblDisplayOSPlatform
        '
        Me.lblDisplayOSPlatform.AutoSize = True
        Me.lblDisplayOSPlatform.Location = New System.Drawing.Point(360, 45)
        Me.lblDisplayOSPlatform.Name = "lblDisplayOSPlatform"
        Me.lblDisplayOSPlatform.Size = New System.Drawing.Size(100, 13)
        Me.lblDisplayOSPlatform.TabIndex = 5
        Me.lblDisplayOSPlatform.Text = "Display OS Platform"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.lblDisplayUserName)
        Me.GroupBox3.Controls.Add(Me.lblDisplayComputerName)
        Me.GroupBox3.Controls.Add(Me.lblDisplayCPUName)
        Me.GroupBox3.Location = New System.Drawing.Point(43, 23)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(602, 120)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Computer Information"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Current User:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Computer Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CPU Name:"
        '
        'lblDisplayUserName
        '
        Me.lblDisplayUserName.AutoSize = True
        Me.lblDisplayUserName.Location = New System.Drawing.Point(360, 82)
        Me.lblDisplayUserName.Name = "lblDisplayUserName"
        Me.lblDisplayUserName.Size = New System.Drawing.Size(97, 13)
        Me.lblDisplayUserName.TabIndex = 3
        Me.lblDisplayUserName.Text = "Display User Name"
        '
        'lblDisplayComputerName
        '
        Me.lblDisplayComputerName.AutoSize = True
        Me.lblDisplayComputerName.Location = New System.Drawing.Point(360, 51)
        Me.lblDisplayComputerName.Name = "lblDisplayComputerName"
        Me.lblDisplayComputerName.Size = New System.Drawing.Size(120, 13)
        Me.lblDisplayComputerName.TabIndex = 3
        Me.lblDisplayComputerName.Text = "Display Computer Name"
        '
        'lblDisplayCPUName
        '
        Me.lblDisplayCPUName.AutoSize = True
        Me.lblDisplayCPUName.Location = New System.Drawing.Point(360, 20)
        Me.lblDisplayCPUName.Name = "lblDisplayCPUName"
        Me.lblDisplayCPUName.Size = New System.Drawing.Size(97, 13)
        Me.lblDisplayCPUName.TabIndex = 2
        Me.lblDisplayCPUName.Text = "Display CPU Name"
        '
        'tmrDisplayMemory
        '
        Me.tmrDisplayMemory.Enabled = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(657, 429)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "My Computer"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblDisplayAvailableMemory As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblDisplayTotalMemory As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblDisplayLanguage As System.Windows.Forms.Label
    Friend WithEvents lblDisplayOSVersion As System.Windows.Forms.Label
    Friend WithEvents lblDisplayOperatingSystem As System.Windows.Forms.Label
    Friend WithEvents lblDisplayOSPlatform As System.Windows.Forms.Label
    Friend WithEvents lblDisplayUserName As System.Windows.Forms.Label
    Friend WithEvents lblDisplayComputerName As System.Windows.Forms.Label
    Friend WithEvents lblDisplayCPUName As System.Windows.Forms.Label
    Friend WithEvents tmrDisplayMemory As System.Windows.Forms.Timer

End Class
