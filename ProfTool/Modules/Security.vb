Imports System.Management

Module Security
    Public Function GetAllAntivirusProducts() As AntiVirusProduct()
        Dim result As New List(Of AntiVirusProduct)
        Dim wmi As New ManagementObjectSearcher("root\SecurityCenter", "SELECT * FROM AntiVirusProduct")

        For Each product As ManagementObject In wmi.Get()
            result.Add(New AntiVirusProduct With {
                .InstanceGuide = product("instanceGuide"),
                .DisplayName = product("displayName"),
                .CompanyName = product("companyName"),
                .OnAccessScanningEnabled = product("onAccessScanningEnabled"),
                .PathToSignedProductExe = product("pathToSignedProductExe"),
                .ProductHasNotifiedUser = product("productHasNotifiedUser"),
                .ProductState = product("productState"),
                .ProductUpToDate = product("productUpToDate"),
                .ProductWantsWscNotifications = product("productWantsWscNotifications"),
                .VersionNumber = product("versionNumber")})
        Next

        Return result.ToArray
    End Function
End Module
