Imports System.Runtime.CompilerServices

Module Formats

    <Extension()>
    Public Function FormatInt(ByVal int As Integer) As String
        Return IIf(int < 10, String.Format("0{0}", int), int)
    End Function

    <Extension()>
    Public Function FormatTime(ByVal sec As Long) As String
        Dim result As String = String.Empty
        Dim ts = TimeSpan.FromSeconds(sec)

        Select Case sec
            Case < 60
                result = String.Format("{0} seconds", FormatInt(ts.Seconds))
            Case < 3600
                result = String.Format("{0}:{1}", FormatInt(ts.Minutes), FormatInt(ts.Seconds))
            Case < 86400
                result = String.Format("{0}:{1}:{2}", FormatInt(ts.Hours), FormatInt(ts.Minutes), FormatInt(ts.Seconds))
        End Select

        Return result
    End Function
End Module
