Public Class AntiVirusProduct
    Public Property InstanceGuide As String
    Public Property DisplayName As String
    Public Property ProductUpToDate As Boolean
    Public Property OnAccessScanningEnabled As Boolean
    Public Property ProductHasNotifiedUser As Boolean
    Public Property ProductWantsWscNotifications As Boolean
    Public Property ProductState As UInt16
    Public Property CompanyName As String
    Public Property VersionNumber As String
    Public Property PathToSignedProductExe As String

    Public Overloads Function ToString() As String
        Dim result As String = String.Format("InstanceGuide:{0} DisplayName:{1} ProductUpToDate:{2} OnAccessScanningEnabled:{3} ProductHasNotifiedUser:{4} ProductWantsWscNotifications:{5} ProductState:{6} CompanyName:{7} VersioNumber:{8} PathToSignedProductExe:{9}", InstanceGuide & vbNewLine, DisplayName & vbNewLine, ProductUpToDate & vbNewLine,
                                             OnAccessScanningEnabled & vbNewLine, ProductHasNotifiedUser & vbNewLine, ProductWantsWscNotifications & vbNewLine,
                                             ProductState & vbNewLine, CompanyName & vbNewLine, VersionNumber & vbNewLine, PathToSignedProductExe)

        Return result
    End Function
End Class
