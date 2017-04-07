Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports Microsoft.Win32

Module Tools

    <Extension()>
    <DllImport("user32.dll", SetLastError:=True)>
    Public Function MoveWindow(ByVal hWnd As IntPtr, ByVal x As Integer, ByVal y As Integer, ByVal width As Integer, ByVal height As Integer, ByVal repaint As Boolean) As Boolean

    End Function

    <Extension()>
    Public Function GetDefaultBrowserPath(ByVal aString As String) As String
        Dim browserName As String = "iexplore.exe"

        Using userChoiceKey As RegistryKey = Registry.CurrentUser.OpenSubKey("Software\Microsoft\Windows\Shell\Associations\UrlAssociations\http\UserChoice")
            If userChoiceKey IsNot Nothing Then
                Dim progIdValue As Object = userChoiceKey.GetValue("Progid")
                If progIdValue IsNot Nothing Then
                    If progIdValue.ToString().ToLower().Contains("chrome") Then
                        browserName = "chrome.exe"
                    ElseIf progIdValue.ToString().ToLower().Contains("firefox") Then
                        browserName = "firefox.exe"
                    ElseIf progIdValue.ToString().ToLower().Contains("safari") Then
                        browserName = "safari.exe"
                    ElseIf progIdValue.ToString().ToLower().Contains("opera") Then
                        browserName = "opera.exe"
                    End If
                End If
            End If
        End Using

        Return browserName
    End Function

    <Extension()>
    Public Function ImageToBytes(ByVal image As Image) As Byte()
        Using ms As New MemoryStream()
            image.Save(ms, Imaging.ImageFormat.Png)
            Return ms.ToArray
        End Using
    End Function

    <Extension()>
    Public Function BytesToImage(ByVal bytes As Byte()) As Image
        Using ms As New MemoryStream(bytes)
            Return Image.FromStream(ms)
        End Using
    End Function
End Module
