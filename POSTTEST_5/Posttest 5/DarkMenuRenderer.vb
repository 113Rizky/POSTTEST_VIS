Imports System.Windows.Forms
Imports System.Drawing

Public Class DarkMenuRenderer
    Inherits ToolStripProfessionalRenderer

    Public Sub New()
        MyBase.New(New DarkColorTable())
    End Sub

    Protected Overrides Sub OnRenderMenuItemBackground(e As ToolStripItemRenderEventArgs)
        Dim rc As Rectangle = New Rectangle(Point.Empty, e.Item.Size)
        Dim c As Color = If(e.Item.Selected, Color.FromArgb(229, 9, 20), Color.FromArgb(30, 30, 47))
        Using brush As New SolidBrush(c)
            e.Graphics.FillRectangle(brush, rc)
        End Using
    End Sub

End Class

Public Class DarkColorTable
    Inherits ProfessionalColorTable

    Public Overrides ReadOnly Property MenuItemSelected As Color
        Get
            Return Color.FromArgb(229, 9, 20)
        End Get
    End Property

    Public Overrides ReadOnly Property MenuItemBorder As Color
        Get
            Return Color.FromArgb(229, 9, 20)
        End Get
    End Property

    Public Overrides ReadOnly Property ToolStripDropDownBackground As Color
        Get
            Return Color.FromArgb(30, 30, 47)
        End Get
    End Property

    Public Overrides ReadOnly Property MenuBorder As Color
        Get
            Return Color.FromArgb(50, 50, 70)
        End Get
    End Property

    Public Overrides ReadOnly Property MenuItemSelectedGradientBegin As Color
        Get
            Return Color.FromArgb(229, 9, 20)
        End Get
    End Property

    Public Overrides ReadOnly Property MenuItemSelectedGradientEnd As Color
        Get
            Return Color.FromArgb(180, 7, 16)
        End Get
    End Property

    Public Overrides ReadOnly Property ImageMarginGradientBegin As Color
        Get
            Return Color.FromArgb(30, 30, 47)
        End Get
    End Property

    Public Overrides ReadOnly Property ImageMarginGradientMiddle As Color
        Get
            Return Color.FromArgb(30, 30, 47)
        End Get
    End Property

    Public Overrides ReadOnly Property ImageMarginGradientEnd As Color
        Get
            Return Color.FromArgb(30, 30, 47)
        End Get
    End Property

End Class