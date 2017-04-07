Imports Newtonsoft.Json

Public Class Settings
    <JsonProperty("shortcuts")>
    Public Property Shortcuts As New List(Of Shortcut)
End Class
