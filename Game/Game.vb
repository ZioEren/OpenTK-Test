Imports OpenTK
Imports OpenTK.Graphics.OpenGL
Imports System.ComponentModel
Imports System.Drawing
Public Class Game
    Dim WithEvents gameWindow As GameWindow
    Public Shared random As New Random
    Dim thread1 As System.Threading.Thread
    Dim A1 As Integer = 0
    Dim A2 As Integer = 0
    Dim A3 As Integer = 0
    Dim A4 As Integer = 0
    Dim A5 As Integer = 0
    Dim A6 As Integer = 0
    Dim A7 As Integer = 0
    Dim A8 As Integer = 0
    Dim A9 As Integer = 0
    Dim A10 As Integer = 0
    Dim A11 As Integer = 0
    Dim A12 As Integer = 0
    Dim texture As Integer
    Public Sub New(ByVal T_gameWindow As GameWindow)
        gameWindow = T_gameWindow
        ' GL.Enable(EnableCap.Texture2D)
    End Sub
    Public Shared Function GetRandomNumber(ByVal StartCap As Integer, ByVal EndCap As Integer) As Integer
        Return random.Next(StartCap, EndCap)
    End Function
    Public Function GetGameWindow() As GameWindow
        Return gameWindow
    End Function
    Public Sub SetGameWindow(ByVal T_gameWindow As GameWindow)
        gameWindow = T_gameWindow
    End Sub
    Private Sub gameWindow_Load(sender As Object, e As EventArgs) Handles gameWindow.Load
        Logger.Log("Succesfully started the game window.", LogType.L_INFORMATION)
        'texture = ContentPipe.LoadTexture("mario.png")
    End Sub
    Private Sub gameWindow_RenderFrame(sender As Object, e As FrameEventArgs) Handles gameWindow.RenderFrame
        Lol()
    End Sub
    Public Sub Lol()
        GL.Clear(ClearBufferMask.ColorBufferBit)
        GL.ClearColor(Color.CornflowerBlue)
        GL.Begin(PrimitiveType.Quads)
        GL.Color3(Color.Red)
        GL.Vertex2(0, 0)
        GL.Color3(Color.Blue)
        GL.Vertex2(0.9, 0)
        GL.Color3(Color.Orange)
        GL.Vertex2(1, -0.9)
        GL.Color3(Color.Green)
        GL.Vertex2(0, -1)
        GL.End()
        gameWindow.SwapBuffers()
    End Sub
    Public Sub Lol1()
        GL.Clear(ClearBufferMask.ColorBufferBit)
        GL.ClearColor(Color.CornflowerBlue)
        GL.Begin(PrimitiveType.Quads)
        GL.Color3(Color.FromArgb(GetRandomNumber(0, 255)))
        GL.Vertex2(0, 0)
        GL.Color3(Color.FromArgb(GetRandomNumber(0, 255)))
        GL.Vertex2(0.9, 0)
        GL.Color3(Color.FromArgb(GetRandomNumber(0, 255)))
        GL.Vertex2(1, -0.9)
        GL.Color3(Color.FromArgb(GetRandomNumber(0, 255)))
        GL.Vertex2(0, -1)
        GL.End()
        gameWindow.SwapBuffers()
    End Sub
    Public Sub Lol2()
        GL.Clear(ClearBufferMask.ColorBufferBit)
        GL.ClearColor(Color.CornflowerBlue)
        GL.Begin(PrimitiveType.Quads)
        GL.Color3(Color.FromArgb(GetRandomNumber(0, 255), GetRandomNumber(0, 255), GetRandomNumber(0, 255)))
        GL.Vertex2(0, 0)
        GL.Color3(Color.FromArgb(GetRandomNumber(0, 255), GetRandomNumber(0, 255), GetRandomNumber(0, 255)))
        GL.Vertex2(0.9, 0)
        GL.Color3(Color.FromArgb(GetRandomNumber(0, 255), GetRandomNumber(0, 255), GetRandomNumber(0, 255)))
        GL.Vertex2(1, -0.9)
        GL.Color3(Color.FromArgb(GetRandomNumber(0, 255), GetRandomNumber(0, 255), GetRandomNumber(0, 255)))
        GL.Vertex2(0, -1)
        GL.End()
        gameWindow.SwapBuffers()
    End Sub
    Public Sub Lol3()
        A1 += 1
        A2 += 2
        A3 += 3
        A4 += 4
        A5 += 5
        A6 += 6
        A7 += 7
        A8 += 8
        A9 += 9
        A10 += 10
        A11 += 11
        A12 += 12
        If A1 > 255 Then
            A1 = 0
        End If
        If A2 > 255 Then
            A2 = 0
        End If
        If A3 > 255 Then
            A3 = 0
        End If
        If A4 > 255 Then
            A4 = 0
        End If
        If A5 > 255 Then
            A5 = 0
        End If
        If A6 > 255 Then
            A6 = 0
        End If
        If A7 > 255 Then
            A7 = 0
        End If
        If A8 > 255 Then
            A8 = 0
        End If
        If A9 > 255 Then
            A9 = 0
        End If
        If A10 > 255 Then
            A10 = 0
        End If
        If A11 > 255 Then
            A11 = 0
        End If
        If A12 > 255 Then
            A12 = 0
        End If
        GL.Clear(ClearBufferMask.ColorBufferBit)
        GL.ClearColor(Color.CornflowerBlue)
        GL.Begin(PrimitiveType.Quads)
        GL.Color3(Color.FromArgb(A1, A2, A3))
        GL.Vertex2(0, 0)
        GL.Color3(Color.FromArgb(A4, A5, A6))
        GL.Vertex2(0.9, 0)
        GL.Color3(Color.FromArgb(A7, A8, A9))
        GL.Vertex2(1, -0.9)
        GL.Color3(Color.FromArgb(A10, A11, A12))
        GL.Vertex2(0, -1)
        GL.End()
        gameWindow.SwapBuffers()
    End Sub
    Public Sub Lol4()
        GL.Clear(ClearBufferMask.ColorBufferBit)
        GL.ClearColor(Color.CornflowerBlue)
        GL.BindTexture(TextureTarget.Texture2D, texture)
        GL.Begin(PrimitiveType.Quads)
        GL.Color3(Color.Red)
        GL.TexCoord2(0, 0)
        GL.Vertex2(0, 0)
        GL.Color3(Color.Blue)
        GL.TexCoord2(1, 0)
        GL.Vertex2(0.9, 0)
        GL.Color3(Color.Orange)
        GL.TexCoord2(1, 1)
        GL.Vertex2(1, -0.9)
        GL.Color3(Color.Green)
        GL.TexCoord2(0, 1)
        GL.Vertex2(0, -1)
        GL.End()
        gameWindow.SwapBuffers()
    End Sub
    Private Sub gameWindow_Closing(sender As Object, e As CancelEventArgs) Handles gameWindow.Closing
        End
    End Sub
End Class