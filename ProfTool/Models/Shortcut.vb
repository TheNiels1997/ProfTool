Imports Newtonsoft.Json

Public Class Shortcut
    <JsonProperty("executablePath")>
    Public Property ExecutablePath As String

    <JsonProperty("associatedIcon")>
    Public Property AssociatedIcon As Byte()

    <JsonProperty("displayName")>
    Public Property DisplayName As String
End Class
