<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbDate = New System.Windows.Forms.Label()
        Me.lbTime = New System.Windows.Forms.Label()
        Me.tmrTimeOfDay = New System.Windows.Forms.Timer(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnWifi = New ProfTool.flatButton()
        Me.btnSettings = New ProfTool.flatButton()
        Me.btnTaskManager = New ProfTool.flatButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.tmrBattery = New System.Windows.Forms.Timer(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnShutDown = New ProfTool.flatButton()
        Me.btnLogout = New ProfTool.flatButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.ShortcutButton1 = New ProfTool.shortcutButton()
        Me.btnDiskmgmt = New ProfTool.shortcutButton()
        Me.btnDevmgmt = New ProfTool.shortcutButton()
        Me.btnCommandPrompt = New ProfTool.shortcutButton()
        Me.btnCommandPromptElevated = New ProfTool.shortcutButton()
        Me.btnRestartAdvancedOptions = New ProfTool.shortcutButton()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnExplorer = New ProfTool.shortcutButton()
        Me.btnRun = New ProfTool.shortcutButton()
        Me.btnBrowser = New ProfTool.shortcutButton()
        Me.btnAntivirus = New ProfTool.shortcutButton()
        Me.btnAddShortcut = New ProfTool.flatButton()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.lbDate)
        Me.Panel1.Controls.Add(Me.lbTime)
        Me.Panel1.Location = New System.Drawing.Point(825, 570)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(1)
        Me.Panel1.Size = New System.Drawing.Size(90, 40)
        Me.Panel1.TabIndex = 0
        '
        'lbDate
        '
        Me.lbDate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbDate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbDate.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDate.Location = New System.Drawing.Point(1, 20)
        Me.lbDate.Name = "lbDate"
        Me.lbDate.Size = New System.Drawing.Size(88, 19)
        Me.lbDate.TabIndex = 1
        Me.lbDate.Text = "..."
        Me.lbDate.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbTime
        '
        Me.lbTime.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbTime.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbTime.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTime.Location = New System.Drawing.Point(1, 1)
        Me.lbTime.Name = "lbTime"
        Me.lbTime.Size = New System.Drawing.Size(88, 19)
        Me.lbTime.TabIndex = 0
        Me.lbTime.Text = "..."
        Me.lbTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tmrTimeOfDay
        '
        Me.tmrTimeOfDay.Enabled = True
        Me.tmrTimeOfDay.Interval = 1000
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.btnWifi)
        Me.Panel2.Controls.Add(Me.btnSettings)
        Me.Panel2.Controls.Add(Me.btnTaskManager)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Location = New System.Drawing.Point(668, 570)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(1)
        Me.Panel2.Size = New System.Drawing.Size(152, 40)
        Me.Panel2.TabIndex = 1
        '
        'btnWifi
        '
        Me.btnWifi.BackColor = System.Drawing.SystemColors.Control
        Me.btnWifi.Content = Nothing
        Me.btnWifi.Image = Global.ProfTool.My.Resources.Resources.wifi
        Me.btnWifi.Location = New System.Drawing.Point(80, 4)
        Me.btnWifi.Name = "btnWifi"
        Me.btnWifi.Size = New System.Drawing.Size(32, 32)
        Me.btnWifi.TabIndex = 4
        Me.btnWifi.Text = "FlatButton1"
        Me.ToolTip1.SetToolTip(Me.btnWifi, "Networks")
        '
        'btnSettings
        '
        Me.btnSettings.Content = Nothing
        Me.btnSettings.Image = Global.ProfTool.My.Resources.Resources.settings_small
        Me.btnSettings.Location = New System.Drawing.Point(4, 4)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Size = New System.Drawing.Size(32, 32)
        Me.btnSettings.TabIndex = 3
        Me.btnSettings.Text = "FlatButton2"
        Me.ToolTip1.SetToolTip(Me.btnSettings, "Control panel")
        '
        'btnTaskManager
        '
        Me.btnTaskManager.Content = Nothing
        Me.btnTaskManager.Image = Global.ProfTool.My.Resources.Resources.tasks_small
        Me.btnTaskManager.Location = New System.Drawing.Point(42, 4)
        Me.btnTaskManager.Name = "btnTaskManager"
        Me.btnTaskManager.Size = New System.Drawing.Size(32, 32)
        Me.btnTaskManager.TabIndex = 2
        Me.btnTaskManager.Text = "FlatButton1"
        Me.ToolTip1.SetToolTip(Me.btnTaskManager, "Task manager")
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Location = New System.Drawing.Point(116, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'tmrBattery
        '
        Me.tmrBattery.Enabled = True
        '
        'btnShutDown
        '
        Me.btnShutDown.Content = Nothing
        Me.btnShutDown.Image = Global.ProfTool.My.Resources.Resources.shutdown
        Me.btnShutDown.Location = New System.Drawing.Point(4, 4)
        Me.btnShutDown.Name = "btnShutDown"
        Me.btnShutDown.Size = New System.Drawing.Size(32, 32)
        Me.btnShutDown.TabIndex = 6
        Me.btnShutDown.Text = "FlatButton2"
        Me.ToolTip1.SetToolTip(Me.btnShutDown, "Shutdown")
        '
        'btnLogout
        '
        Me.btnLogout.Content = Nothing
        Me.btnLogout.Image = Global.ProfTool.My.Resources.Resources.logout
        Me.btnLogout.Location = New System.Drawing.Point(44, 4)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(32, 32)
        Me.btnLogout.TabIndex = 5
        Me.btnLogout.Text = "FlatButton2"
        Me.ToolTip1.SetToolTip(Me.btnLogout, "Logout")
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel3.Controls.Add(Me.btnShutDown)
        Me.Panel3.Controls.Add(Me.btnLogout)
        Me.Panel3.Location = New System.Drawing.Point(12, 570)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(80, 40)
        Me.Panel3.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 25)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Shortcuts"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 173)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 25)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "System tools"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoScroll = True
        Me.FlowLayoutPanel1.Controls.Add(Me.ShortcutButton1)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnDiskmgmt)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnDevmgmt)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnCommandPrompt)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnCommandPromptElevated)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnRestartAdvancedOptions)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(12, 201)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(903, 363)
        Me.FlowLayoutPanel1.TabIndex = 15
        '
        'ShortcutButton1
        '
        Me.ShortcutButton1.Content = "Regedit"
        Me.ShortcutButton1.Image = Global.ProfTool.My.Resources.Resources.regedit
        Me.ShortcutButton1.IsAddedShortcut = False
        Me.ShortcutButton1.Location = New System.Drawing.Point(3, 3)
        Me.ShortcutButton1.Name = "ShortcutButton1"
        Me.ShortcutButton1.Size = New System.Drawing.Size(109, 102)
        Me.ShortcutButton1.TabIndex = 14
        Me.ShortcutButton1.Text = "ShortcutButton1"
        '
        'btnDiskmgmt
        '
        Me.btnDiskmgmt.Content = "Disk management"
        Me.btnDiskmgmt.Image = CType(resources.GetObject("btnDiskmgmt.Image"), System.Drawing.Image)
        Me.btnDiskmgmt.IsAddedShortcut = False
        Me.btnDiskmgmt.Location = New System.Drawing.Point(118, 3)
        Me.btnDiskmgmt.Name = "btnDiskmgmt"
        Me.btnDiskmgmt.Size = New System.Drawing.Size(109, 102)
        Me.btnDiskmgmt.TabIndex = 12
        Me.btnDiskmgmt.Text = "ShortcutButton1"
        '
        'btnDevmgmt
        '
        Me.btnDevmgmt.Content = "Device management"
        Me.btnDevmgmt.Image = CType(resources.GetObject("btnDevmgmt.Image"), System.Drawing.Image)
        Me.btnDevmgmt.IsAddedShortcut = False
        Me.btnDevmgmt.Location = New System.Drawing.Point(233, 3)
        Me.btnDevmgmt.Name = "btnDevmgmt"
        Me.btnDevmgmt.Size = New System.Drawing.Size(109, 102)
        Me.btnDevmgmt.TabIndex = 13
        Me.btnDevmgmt.Text = "ShortcutButton2"
        '
        'btnCommandPrompt
        '
        Me.btnCommandPrompt.Content = "Command prompt"
        Me.btnCommandPrompt.Image = Global.ProfTool.My.Resources.Resources.command
        Me.btnCommandPrompt.IsAddedShortcut = False
        Me.btnCommandPrompt.Location = New System.Drawing.Point(348, 3)
        Me.btnCommandPrompt.Name = "btnCommandPrompt"
        Me.btnCommandPrompt.Size = New System.Drawing.Size(109, 102)
        Me.btnCommandPrompt.TabIndex = 9
        Me.btnCommandPrompt.Text = "ShortcutButton1"
        '
        'btnCommandPromptElevated
        '
        Me.btnCommandPromptElevated.Content = "Command prompt (Elevated)"
        Me.btnCommandPromptElevated.Image = Global.ProfTool.My.Resources.Resources.command_admin
        Me.btnCommandPromptElevated.IsAddedShortcut = False
        Me.btnCommandPromptElevated.Location = New System.Drawing.Point(463, 3)
        Me.btnCommandPromptElevated.Name = "btnCommandPromptElevated"
        Me.btnCommandPromptElevated.Size = New System.Drawing.Size(109, 102)
        Me.btnCommandPromptElevated.TabIndex = 10
        Me.btnCommandPromptElevated.Text = "ShortcutButton1"
        '
        'btnRestartAdvancedOptions
        '
        Me.btnRestartAdvancedOptions.Content = "Advanced startup options"
        Me.btnRestartAdvancedOptions.Image = Global.ProfTool.My.Resources.Resources.recovery
        Me.btnRestartAdvancedOptions.IsAddedShortcut = False
        Me.btnRestartAdvancedOptions.Location = New System.Drawing.Point(578, 3)
        Me.btnRestartAdvancedOptions.Name = "btnRestartAdvancedOptions"
        Me.btnRestartAdvancedOptions.Size = New System.Drawing.Size(109, 102)
        Me.btnRestartAdvancedOptions.TabIndex = 11
        Me.btnRestartAdvancedOptions.Text = "ShortcutButton1"
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.AutoScroll = True
        Me.FlowLayoutPanel2.Controls.Add(Me.btnExplorer)
        Me.FlowLayoutPanel2.Controls.Add(Me.btnRun)
        Me.FlowLayoutPanel2.Controls.Add(Me.btnBrowser)
        Me.FlowLayoutPanel2.Controls.Add(Me.btnAntivirus)
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(12, 37)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(902, 108)
        Me.FlowLayoutPanel2.TabIndex = 16
        '
        'btnExplorer
        '
        Me.btnExplorer.Content = "Explorer"
        Me.btnExplorer.Image = Global.ProfTool.My.Resources.Resources.explorer
        Me.btnExplorer.IsAddedShortcut = False
        Me.btnExplorer.Location = New System.Drawing.Point(3, 3)
        Me.btnExplorer.Name = "btnExplorer"
        Me.btnExplorer.Size = New System.Drawing.Size(109, 102)
        Me.btnExplorer.TabIndex = 2
        Me.btnExplorer.Text = "ShortcutButton1"
        '
        'btnRun
        '
        Me.btnRun.Content = "Run..."
        Me.btnRun.Image = CType(resources.GetObject("btnRun.Image"), System.Drawing.Image)
        Me.btnRun.IsAddedShortcut = False
        Me.btnRun.Location = New System.Drawing.Point(118, 3)
        Me.btnRun.Name = "btnRun"
        Me.btnRun.Size = New System.Drawing.Size(109, 102)
        Me.btnRun.TabIndex = 3
        Me.btnRun.Text = "ShortcutButton2"
        '
        'btnBrowser
        '
        Me.btnBrowser.Content = "Browser"
        Me.btnBrowser.Image = CType(resources.GetObject("btnBrowser.Image"), System.Drawing.Image)
        Me.btnBrowser.IsAddedShortcut = False
        Me.btnBrowser.Location = New System.Drawing.Point(233, 3)
        Me.btnBrowser.Name = "btnBrowser"
        Me.btnBrowser.Size = New System.Drawing.Size(109, 102)
        Me.btnBrowser.TabIndex = 4
        Me.btnBrowser.Text = "ShortcutButton2"
        '
        'btnAntivirus
        '
        Me.btnAntivirus.Content = "Antivirus"
        Me.btnAntivirus.Image = Global.ProfTool.My.Resources.Resources.antivirus
        Me.btnAntivirus.IsAddedShortcut = False
        Me.btnAntivirus.Location = New System.Drawing.Point(348, 3)
        Me.btnAntivirus.Name = "btnAntivirus"
        Me.btnAntivirus.Size = New System.Drawing.Size(109, 102)
        Me.btnAntivirus.TabIndex = 5
        Me.btnAntivirus.Text = "ShortcutButton2"
        '
        'btnAddShortcut
        '
        Me.btnAddShortcut.Content = Nothing
        Me.btnAddShortcut.Image = Global.ProfTool.My.Resources.Resources.add
        Me.btnAddShortcut.Location = New System.Drawing.Point(94, 11)
        Me.btnAddShortcut.Name = "btnAddShortcut"
        Me.btnAddShortcut.Size = New System.Drawing.Size(23, 23)
        Me.btnAddShortcut.TabIndex = 17
        Me.btnAddShortcut.Text = "FlatButton1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(927, 622)
        Me.Controls.Add(Me.btnAddShortcut)
        Me.Controls.Add(Me.FlowLayoutPanel2)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ProfTool Launcher"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbDate As Label
    Friend WithEvents lbTime As Label
    Friend WithEvents tmrTimeOfDay As Timer
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents tmrBattery As Timer
    Friend WithEvents btnSettings As flatButton
    Friend WithEvents btnTaskManager As flatButton
    Friend WithEvents btnExplorer As shortcutButton
    Friend WithEvents btnRun As shortcutButton
    Friend WithEvents btnBrowser As shortcutButton
    Friend WithEvents btnAntivirus As shortcutButton
    Friend WithEvents btnWifi As flatButton
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnLogout As flatButton
    Friend WithEvents btnShutDown As flatButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnCommandPrompt As shortcutButton
    Friend WithEvents btnCommandPromptElevated As shortcutButton
    Friend WithEvents btnRestartAdvancedOptions As shortcutButton
    Friend WithEvents btnDiskmgmt As shortcutButton
    Friend WithEvents btnDevmgmt As shortcutButton
    Friend WithEvents ShortcutButton1 As shortcutButton
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents btnAddShortcut As flatButton
End Class
