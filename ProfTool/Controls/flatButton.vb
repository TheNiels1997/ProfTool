Imports System.ComponentModel

Public Class flatButton
    Inherits Control

    <Category("ButtonAppearance")>
    Dim img As Image
    Public Property Image As Image
        Get
            Return img
        End Get
        Set(value As Image)
            img = value

            Me.Invalidate()
        End Set
    End Property

    <Category("ButtonAppearance")>
    Dim _content As String
    Public Property Content As String
        Get
            Return _content
        End Get
        Set(value As String)
            _content = value

            Me.Invalidate()
        End Set
    End Property

    Dim isMouseDown As Boolean = False

    Private Sub DrawBackground(ByVal rect As Rectangle, ByVal graphics As Graphics, ByVal mouseDown As Boolean)
        If mouseDown Then
            Using br As New SolidBrush(Color.DimGray)
                graphics.FillRectangle(br, rect)

                Dim p As New Pen(br)
                graphics.DrawRectangle(p, rect)
                p.Dispose()
            End Using
        Else
            Using br As New SolidBrush(SystemColors.Control)
                graphics.FillRectangle(br, rect)

                Dim p As New Pen(br)
                graphics.DrawRectangle(p, rect)
                p.Dispose()
            End Using
        End If
    End Sub

    Private Sub DrawImage(ByVal rect As Rectangle, ByVal graphics As Graphics, ByVal image As Image)
        If Not image Is Nothing Then
            Dim rectImage As New Rectangle(rect.X + (rect.Width / 2) - (image.Width / 2), rect.Y + (rect.Height / 2) - (image.Height / 2), image.Width, image.Height)

            graphics.DrawImage(image, rectImage)
        End If
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        Dim g As Graphics = e.Graphics

        g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        g.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic

        DrawBackground(Me.ClientRectangle, g, isMouseDown)
        DrawImage(Me.ClientRectangle, e.Graphics, img)
    End Sub

    Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
        MyBase.OnMouseDown(e)
        isMouseDown = True
        Me.Invalidate()
    End Sub

    Protected Overrides Sub OnMouseUp(e As MouseEventArgs)
        MyBase.OnMouseUp(e)
        isMouseDown = False
        Me.Invalidate()
    End Sub
End Class
