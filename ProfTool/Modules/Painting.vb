Imports System.Drawing.Drawing2D
Imports System.Runtime.CompilerServices

Module Painting

    <Extension()>
    Public Sub DrawBorder(ByVal borderColor As Color, ByVal rect As Rectangle, ByVal graphics As Graphics)
        Using p As New Pen(borderColor)
            graphics.DrawRectangle(p, rect)
        End Using
    End Sub

    <Extension()>
    Public Sub DrawBattery(ByVal percentage As Integer, ByVal color As Color, ByVal rect As Rectangle, ByVal graphics As Graphics)

    End Sub
End Module
