<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Proxee
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Proxee))
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.closedbox_dot_net = New System.Windows.Forms.Label()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.tmrCheckSkype = New System.Windows.Forms.Timer(Me.components)
        Me.tabOptions = New System.Windows.Forms.TabPage()
        Me.txtSkypePath = New System.Windows.Forms.TextBox()
        Me.cmboProxyType = New System.Windows.Forms.ComboBox()
        Me.chkPassword = New System.Windows.Forms.CheckBox()
        Me.tabPing = New System.Windows.Forms.TabPage()
        Me.lstPing = New System.Windows.Forms.ListBox()
        Me.tabMain = New System.Windows.Forms.TabPage()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.stripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.cmboProxyAddresses = New System.Windows.Forms.ComboBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.btnProxyOn = New System.Windows.Forms.Button()
        Me.btnProxyOff = New System.Windows.Forms.Button()
        Me.btnChangePass = New System.Windows.Forms.Button()
        Me.Tab2 = New System.Windows.Forms.TabControl()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.tabOptions.SuspendLayout()
        Me.tabPing.SuspendLayout()
        Me.tabMain.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.Tab2.SuspendLayout()
        Me.SuspendLayout()
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.NotifyIcon1.BalloonTipText = "Proxee"
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "Proxee"
        Me.NotifyIcon1.Visible = True
        '
        'closedbox_dot_net
        '
        Me.closedbox_dot_net.AutoSize = True
        Me.closedbox_dot_net.Location = New System.Drawing.Point(3133, 1010)
        Me.closedbox_dot_net.Name = "closedbox_dot_net"
        Me.closedbox_dot_net.Size = New System.Drawing.Size(219, 13)
        Me.closedbox_dot_net.TabIndex = 50
        Me.closedbox_dot_net.Text = "proxy program by alex @ www.closedbox.net"
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblTitle.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.Transparent
        Me.lblTitle.Location = New System.Drawing.Point(560, -1)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(96, 14)
        Me.lblTitle.TabIndex = 54
        Me.lblTitle.Text = "www.proxee.net"
        '
        'tmrCheckSkype
        '
        Me.tmrCheckSkype.Interval = 5000
        '
        'tabOptions
        '
        Me.tabOptions.BackColor = System.Drawing.SystemColors.Control
        Me.tabOptions.Controls.Add(Me.txtSkypePath)
        Me.tabOptions.Controls.Add(Me.cmboProxyType)
        Me.tabOptions.Controls.Add(Me.chkPassword)
        Me.tabOptions.Location = New System.Drawing.Point(4, 22)
        Me.tabOptions.Name = "tabOptions"
        Me.tabOptions.Padding = New System.Windows.Forms.Padding(3)
        Me.tabOptions.Size = New System.Drawing.Size(293, 118)
        Me.tabOptions.TabIndex = 2
        Me.tabOptions.Text = "Options"
        '
        'txtSkypePath
        '
        Me.txtSkypePath.BackColor = System.Drawing.Color.White
        Me.txtSkypePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSkypePath.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSkypePath.Location = New System.Drawing.Point(6, 35)
        Me.txtSkypePath.Multiline = True
        Me.txtSkypePath.Name = "txtSkypePath"
        Me.txtSkypePath.Size = New System.Drawing.Size(281, 23)
        Me.txtSkypePath.TabIndex = 72
        Me.txtSkypePath.Text = "C:\Program Files (x86)\Skype\Phone\Skype.exe"
        '
        'cmboProxyType
        '
        Me.cmboProxyType.BackColor = System.Drawing.Color.White
        Me.cmboProxyType.Enabled = False
        Me.cmboProxyType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmboProxyType.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmboProxyType.FormattingEnabled = True
        Me.cmboProxyType.Location = New System.Drawing.Point(6, 64)
        Me.cmboProxyType.Name = "cmboProxyType"
        Me.cmboProxyType.Size = New System.Drawing.Size(76, 23)
        Me.cmboProxyType.TabIndex = 73
        Me.cmboProxyType.Text = "SOCKS5"
        '
        'chkPassword
        '
        Me.chkPassword.AutoSize = True
        Me.chkPassword.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPassword.ForeColor = System.Drawing.Color.Black
        Me.chkPassword.Location = New System.Drawing.Point(99, 66)
        Me.chkPassword.Name = "chkPassword"
        Me.chkPassword.Size = New System.Drawing.Size(188, 19)
        Me.chkPassword.TabIndex = 74
        Me.chkPassword.Text = "Show Uncensored Password"
        Me.chkPassword.UseVisualStyleBackColor = True
        '
        'tabPing
        '
        Me.tabPing.BackColor = System.Drawing.SystemColors.Control
        Me.tabPing.Controls.Add(Me.lstPing)
        Me.tabPing.Location = New System.Drawing.Point(4, 22)
        Me.tabPing.Name = "tabPing"
        Me.tabPing.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPing.Size = New System.Drawing.Size(293, 118)
        Me.tabPing.TabIndex = 1
        Me.tabPing.Text = "Latency"
        '
        'lstPing
        '
        Me.lstPing.FormattingEnabled = True
        Me.lstPing.Location = New System.Drawing.Point(9, 12)
        Me.lstPing.Name = "lstPing"
        Me.lstPing.Size = New System.Drawing.Size(278, 95)
        Me.lstPing.TabIndex = 94
        '
        'tabMain
        '
        Me.tabMain.BackColor = System.Drawing.SystemColors.Control
        Me.tabMain.Controls.Add(Me.StatusStrip1)
        Me.tabMain.Controls.Add(Me.cmboProxyAddresses)
        Me.tabMain.Controls.Add(Me.txtPassword)
        Me.tabMain.Controls.Add(Me.txtUsername)
        Me.tabMain.Controls.Add(Me.btnProxyOn)
        Me.tabMain.Controls.Add(Me.btnProxyOff)
        Me.tabMain.Controls.Add(Me.btnChangePass)
        Me.tabMain.Location = New System.Drawing.Point(4, 22)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.Padding = New System.Windows.Forms.Padding(3)
        Me.tabMain.Size = New System.Drawing.Size(293, 118)
        Me.tabMain.TabIndex = 0
        Me.tabMain.Text = "Main"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.stripStatusLabel})
        Me.StatusStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.StatusStrip1.Location = New System.Drawing.Point(3, 95)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(287, 20)
        Me.StatusStrip1.TabIndex = 52
        Me.StatusStrip1.Text = "stripStatus"
        '
        'stripStatusLabel
        '
        Me.stripStatusLabel.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stripStatusLabel.Name = "stripStatusLabel"
        Me.stripStatusLabel.Size = New System.Drawing.Size(88, 15)
        Me.stripStatusLabel.Text = "Status: Ready"
        '
        'cmboProxyAddresses
        '
        Me.cmboProxyAddresses.BackColor = System.Drawing.Color.White
        Me.cmboProxyAddresses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmboProxyAddresses.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmboProxyAddresses.ForeColor = System.Drawing.Color.Black
        Me.cmboProxyAddresses.FormattingEnabled = True
        Me.cmboProxyAddresses.Location = New System.Drawing.Point(6, 62)
        Me.cmboProxyAddresses.MaxDropDownItems = 5
        Me.cmboProxyAddresses.Name = "cmboProxyAddresses"
        Me.cmboProxyAddresses.Size = New System.Drawing.Size(194, 23)
        Me.cmboProxyAddresses.TabIndex = 31
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.White
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPassword.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(6, 35)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(194, 23)
        Me.txtPassword.TabIndex = 30
        Me.txtPassword.Text = "Proxy Password"
        '
        'txtUsername
        '
        Me.txtUsername.BackColor = System.Drawing.Color.White
        Me.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUsername.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(6, 11)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(194, 23)
        Me.txtUsername.TabIndex = 29
        Me.txtUsername.Text = "Email Address"
        '
        'btnProxyOn
        '
        Me.btnProxyOn.BackColor = System.Drawing.Color.White
        Me.btnProxyOn.BackgroundImage = CType(resources.GetObject("btnProxyOn.BackgroundImage"), System.Drawing.Image)
        Me.btnProxyOn.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnProxyOn.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnProxyOn.Font = New System.Drawing.Font("Corbel", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProxyOn.ForeColor = System.Drawing.Color.White
        Me.btnProxyOn.Location = New System.Drawing.Point(210, 6)
        Me.btnProxyOn.Name = "btnProxyOn"
        Me.btnProxyOn.Size = New System.Drawing.Size(77, 23)
        Me.btnProxyOn.TabIndex = 44
        Me.btnProxyOn.Text = "Proxy On"
        Me.btnProxyOn.UseVisualStyleBackColor = False
        '
        'btnProxyOff
        '
        Me.btnProxyOff.BackColor = System.Drawing.Color.White
        Me.btnProxyOff.BackgroundImage = CType(resources.GetObject("btnProxyOff.BackgroundImage"), System.Drawing.Image)
        Me.btnProxyOff.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnProxyOff.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnProxyOff.Font = New System.Drawing.Font("Corbel", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProxyOff.ForeColor = System.Drawing.Color.White
        Me.btnProxyOff.Location = New System.Drawing.Point(210, 35)
        Me.btnProxyOff.Name = "btnProxyOff"
        Me.btnProxyOff.Size = New System.Drawing.Size(77, 21)
        Me.btnProxyOff.TabIndex = 45
        Me.btnProxyOff.Text = "Proxy Off"
        Me.btnProxyOff.UseVisualStyleBackColor = False
        '
        'btnChangePass
        '
        Me.btnChangePass.BackColor = System.Drawing.Color.White
        Me.btnChangePass.BackgroundImage = CType(resources.GetObject("btnChangePass.BackgroundImage"), System.Drawing.Image)
        Me.btnChangePass.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnChangePass.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnChangePass.Font = New System.Drawing.Font("Corbel", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChangePass.ForeColor = System.Drawing.Color.White
        Me.btnChangePass.Location = New System.Drawing.Point(210, 64)
        Me.btnChangePass.Name = "btnChangePass"
        Me.btnChangePass.Size = New System.Drawing.Size(77, 21)
        Me.btnChangePass.TabIndex = 51
        Me.btnChangePass.Text = "Account"
        Me.btnChangePass.UseVisualStyleBackColor = False
        '
        'Tab2
        '
        Me.Tab2.Controls.Add(Me.tabMain)
        Me.Tab2.Controls.Add(Me.tabPing)
        Me.Tab2.Controls.Add(Me.tabOptions)
        Me.Tab2.Location = New System.Drawing.Point(2, -1)
        Me.Tab2.Name = "Tab2"
        Me.Tab2.SelectedIndex = 0
        Me.Tab2.Size = New System.Drawing.Size(301, 144)
        Me.Tab2.TabIndex = 75
        '
        'BackgroundWorker1
        '
        '
        'Proxee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(302, 144)
        Me.Controls.Add(Me.Tab2)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.closedbox_dot_net)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Proxee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Proxee - RL: 12/14/2014"
        Me.TopMost = True
        Me.tabOptions.ResumeLayout(False)
        Me.tabOptions.PerformLayout()
        Me.tabPing.ResumeLayout(False)
        Me.tabMain.ResumeLayout(False)
        Me.tabMain.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Tab2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents closedbox_dot_net As System.Windows.Forms.Label
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents tmrCheckSkype As System.Windows.Forms.Timer
    Friend WithEvents tabOptions As System.Windows.Forms.TabPage
    Friend WithEvents txtSkypePath As System.Windows.Forms.TextBox
    Private WithEvents cmboProxyType As System.Windows.Forms.ComboBox
    Friend WithEvents chkPassword As System.Windows.Forms.CheckBox
    Friend WithEvents tabPing As System.Windows.Forms.TabPage
    Friend WithEvents lstPing As System.Windows.Forms.ListBox
    Friend WithEvents tabMain As System.Windows.Forms.TabPage
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents stripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Public WithEvents cmboProxyAddresses As System.Windows.Forms.ComboBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents btnProxyOn As System.Windows.Forms.Button
    Friend WithEvents btnProxyOff As System.Windows.Forms.Button
    Friend WithEvents btnChangePass As System.Windows.Forms.Button
    Friend WithEvents Tab2 As System.Windows.Forms.TabControl
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker

End Class
