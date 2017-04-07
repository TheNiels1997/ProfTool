Imports System.Runtime.CompilerServices

Module Selections

    <Extension()>
    Public Function GetProperBatteryImage(ByVal percentage As Integer, ByVal charging As BatteryChargeStatus) As Image
        If charging = BatteryChargeStatus.Charging Then
            Return My.Resources.batcharge
        Else
            Select Case percentage
                Case 100
                    Return My.Resources.bat100
                Case < 100
                    Return My.Resources.bat100
                Case < 80
                    Return My.Resources.bat80
                Case < 65
                    Return My.Resources.bat65
                Case < 50
                    Return My.Resources.bat50
                Case < 35
                    Return My.Resources.bat35
                Case < 15
                    Return My.Resources.bat15
            End Select
        End If
    End Function

End Module
