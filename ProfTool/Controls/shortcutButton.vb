Imports System.ComponentModel

Public Class shortcutButton
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

    Public Property IsAddedShortcut As Boolean

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

    Private Sub DrawText(ByVal rect As Rectangle, ByVal graphics As Graphics)
        Using fnt As New Font("Segoe UI", 8)
            graphics.DrawString(_content, fnt, Brushes.Black, rect, New StringFormat With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center})
        End Using
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        Dim rectImage As New Rectangle(Me.ClientRectangle.X, Me.ClientRectangle.Y, Me.ClientRectangle.Width, Me.ClientRectangle.Height - 30)
        Dim rectContent As New Rectangle(Me.ClientRectangle.X, Me.ClientRectangle.Y + (Me.ClientRectangle.Height - 30), Me.ClientRectangle.Width, 30)

        Dim g As Graphics = e.Graphics

        g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        g.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic

        DrawBackground(Me.ClientRectangle, g, isMouseDown)
        DrawImage(rectImage, g, img)
        DrawText(rectContent, g)
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
