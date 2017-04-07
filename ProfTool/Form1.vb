Imports System.ComponentModel
Imports System.IO
Imports System.Threading
Imports Newtonsoft.Json

Public Class Form1
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        Dim borderRect As New Rectangle(Panel1.ClientRectangle.X, Panel1.ClientRectangle.Y, Panel1.ClientRectangle.Width - 1, Panel1.ClientRectangle.Height - 1)

        DrawBorder(Color.Silver, borderRect, e.Graphics)
    End Sub

    Private Sub tmrTimeOfDay_Tick(sender As Object, e As EventArgs) Handles tmrTimeOfDay.Tick
        lbTime.Text = String.Format("{0}:{1}", FormatInt(TimeOfDay.Hour), FormatInt(TimeOfDay.Minute))
        lbDate.Text = String.Format("{0}-{1}-{2}", FormatInt(DateAndTime.Now.Day), FormatInt(DateAndTime.Now.Month), DateAndTime.Now.Year)
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint
        Dim borderRect As New Rectangle(Panel2.ClientRectangle.X, Panel2.ClientRectangle.Y, Panel2.ClientRectangle.Width - 1, Panel2.ClientRectangle.Height - 1)

        DrawBorder(Color.Silver, borderRect, e.Graphics)
    End Sub

    Private Sub tmrBattery_Tick(sender As Object, e As EventArgs) Handles tmrBattery.Tick
        Dim stat As PowerStatus = SystemInformation.PowerStatus

        PictureBox1.Image = GetProperBatteryImage(stat.BatteryLifePercent * 100, stat.BatteryChargeStatus)
    End Sub

    Private Sub FlatButton1_Click(sender As Object, e As EventArgs) Handles btnTaskManager.Click
        StartProcess("taskmgr")
    End Sub

    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        StartProcess("control")
    End Sub

    Private Sub ShortcutButton1_Click(sender As Object, e As EventArgs) Handles btnExplorer.Click
        StartProcess("explorer")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StartProcess("runonce.exe", "/alternateshellstartup")

        Control.CheckForIllegalCrossThreadCalls = False

        If File.Exists(String.Format("{0}\settings.json", Application.StartupPath)) Then
            LoadShortcuts()
        End If
    End Sub

    Private Sub ShortcutButton2_Click(sender As Object, e As EventArgs) Handles btnRun.Click
        Dim fullPath As String = String.Format("{0}\Users\{1}\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\System Tools\run.lnk", Environment.GetLogicalDrives(0), Environment.UserName)
        StartProcess(fullPath)
    End Sub

    Private Sub PictureBox1_MouseHover(sender As Object, e As EventArgs) Handles PictureBox1.MouseHover
        Dim stat As PowerStatus = SystemInformation.PowerStatus

        ToolTip1.Show(String.Format("{0}%", stat.BatteryLifePercent * 100), PictureBox1)
    End Sub

    Private Sub btnBrowser_Click(sender As Object, e As EventArgs) Handles btnBrowser.Click
        StartProcess(GetDefaultBrowserPath(String.Empty))
    End Sub

    Private Sub btnWifi_Click(sender As Object, e As EventArgs) Handles btnWifi.Click
        StartProcess("control", "/name Microsoft.NetworkAndSharingCenter")
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint
        Dim borderRect As New Rectangle(Panel3.ClientRectangle.X, Panel3.ClientRectangle.Y, Panel3.ClientRectangle.Width - 1, Panel3.ClientRectangle.Height - 1)

        DrawBorder(Color.Silver, borderRect, e.Graphics)
    End Sub

    Private Sub FlatButton1_Click_1(sender As Object, e As EventArgs) Handles btnLogout.Click
        StartProcess("cmd.exe", "/c logoff")
    End Sub

    Private Sub lbTime_Click(sender As Object, e As EventArgs) Handles lbTime.Click
        StartProcess("control", "/name Microsoft.DateAndTime")
    End Sub

    Private Sub lbDate_Click(sender As Object, e As EventArgs) Handles lbDate.Click
        StartProcess("control", "/name Microsoft.DateAndTime")
    End Sub

    Private Sub btnShutDown_Click(sender As Object, e As EventArgs) Handles btnShutDown.Click
        Dim msg = MsgBox("There is still a session running, are you sure you want to shut down?", MessageBoxButtons.YesNo)

        If msg = MsgBoxResult.Yes Then
            ThreadPool.QueueUserWorkItem(AddressOf Shutdown)
        End If
    End Sub

    Private Sub ShortcutButton1_Click_1(sender As Object, e As EventArgs) Handles btnCommandPrompt.Click
        StartProcess("cmd.exe")
    End Sub

    Private Sub btnCommandPromptElevated_Click(sender As Object, e As EventArgs) Handles btnCommandPromptElevated.Click
        StartProcess("cmd.exe", String.Empty, "runas")
    End Sub

    Private Sub ShortcutButton1_Click_2(sender As Object, e As EventArgs) Handles btnRestartAdvancedOptions.Click
        Dim msg = MsgBox("There is still a session running, are you sure you want to reboot?", MessageBoxButtons.YesNo)

        If msg = DialogResult.Yes Then
            StartProcess("cmd.exe", "/c shutdown -r -o -f -t 01")
        End If
    End Sub

    Private Sub ShortcutButton1_Click_3(sender As Object, e As EventArgs) Handles btnDiskmgmt.Click
        StartProcess("diskmgmt.msc")
    End Sub

    Private Sub ShortcutButton2_Click_1(sender As Object, e As EventArgs) Handles btnDevmgmt.Click
        StartProcess("devmgmt.msc")
    End Sub

    Private Sub btnAntivirus_Click(sender As Object, e As EventArgs) Handles btnAntivirus.Click
        Dim path As String = String.Format("{0}\hitmanpro.exe", Application.StartupPath)

        If File.Exists(path) Then
            StartProcess(path, "runas")
        End If
    End Sub

    Private Sub ShortcutButton1_Click_4(sender As Object, e As EventArgs) Handles ShortcutButton1.Click
        StartProcess("regedit")
    End Sub

    Private Sub StartProcess(ByVal fileName As String, Optional ByVal arguments As String = "", Optional ByVal verb As String = "", Optional ByVal createNoWindow As Boolean = False)
        Try
            Using p As New Process
                p.StartInfo.FileName = fileName
                p.StartInfo.Verb = verb
                p.StartInfo.Arguments = arguments
                p.StartInfo.CreateNoWindow = createNoWindow
                p.Start()
            End Using
        Catch ex As Win32Exception

        End Try
    End Sub

    Private Sub ShortcutClick(ByVal sender As Object, ByVal e As EventArgs)
        Dim shortcutbtn As shortcutButton = DirectCast(sender, shortcutButton)
        StartProcess(shortcutbtn.Text)
    End Sub

    Private Sub LoadShortcuts()
        Dim path As String = String.Format("{0}\settings.json", Application.StartupPath)

        Using reader As New StreamReader(path)
            Dim sett As Settings = JsonConvert.DeserializeObject(Of Settings)(reader.ReadToEnd)

            For Each shrtcut As Shortcut In sett.Shortcuts
                Dim btnClick As New shortcutButton
                btnClick.Text = shr.ExecutablePath
                btnClick.Content = shrtcut.DisplayName
                btnClick.Image = BytesToImage(shrtcut.AssociatedIcon)
                btnClick.Size = New Size(109, 102)
                btnClick.IsAddedShortcut = True
                AddHandler btnClick.Click, AddressOf ShortcutClick
                FlowLayoutPanel2.Controls.Add(btnClick)
            Next
        End Using
    End Sub

    Private Sub Shutdown()
        SaveShortcuts()
        StartProcess("cmd.exe", "/c shutdown -s -f -t 00")
    End Sub

    Private Sub SaveShortcuts()
        Dim sett As New Settings

        For Each control As Control In FlowLayoutPanel2.Controls
            Dim btn As shortcutButton = DirectCast(control, shortcutButton)
            If btn.IsAddedShortcut Then
                Dim shortcut As New Shortcut
                shortcut.ExecutablePath = btn.Text
                shortcut.DisplayName = btn.Content
                shortcut.AssociatedIcon = ImageToBytes(btn.Image)
                sett.Shortcuts.Add(shortcut)
            End If
        Next

        Using sw As New StreamWriter(String.Format("{0}\settings.json", Application.StartupPath))
            sw.Write(JsonConvert.SerializeObject(sett))
        End Using
    End Sub

    Private Sub FlatButton1_Click_2(sender As Object, e As EventArgs) Handles btnAddShortcut.Click
        Using ofd As New OpenFileDialog With {.Filter = "*All files|*.*"}
            If ofd.ShowDialog = DialogResult.OK Then
                Dim btnClick As New shortcutButton
                btnClick.Text = ofd.FileName
                btnClick.Content = Path.GetFileNameWithoutExtension(ofd.FileName)
                btnClick.Image = Icon.ExtractAssociatedIcon(ofd.FileName).ToBitmap
                btnClick.Size = New Size(109, 102)
                btnClick.IsAddedShortcut = True
                AddHandler btnClick.Click, AddressOf ShortcutClick
                FlowLayoutPanel2.Controls.Add(btnClick)
            End If
        End Using
    End Sub

    Private Sub FlatButton1_Click_3(sender As Object, e As EventArgs)
        SaveShortcuts()
        Application.Exit()
    End Sub
End Class
