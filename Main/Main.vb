Imports OpenTK
Module Main
    Dim t1 As System.Threading.Thread
    Public Sub Main()
        If Not System.IO.File.Exists(FileSystem.CurDir() + "\OpenTK.dll") Then
            Logger.Log("Failed to find the OpenTK.dll library.", LogType.L_ERROR)
            Console.ReadLine()
            End
        Else
            Logger.Log("Succesfully found the OpenTK.dll library.", LogType.L_INFORMATION)
        End If
        If Not System.IO.File.Exists(FileSystem.CurDir() + "\OpenTK.GLControl.dll") Then
            Logger.Log("Failed to find the OpenTK.GLControl.dll library.", LogType.L_ERROR)
            Console.ReadLine()
            End
        Else
            Logger.Log("Succesfully found the OpenTK.GLControl.dll library.", LogType.L_INFORMATION)
        End If
        t1 = New System.Threading.Thread(AddressOf RunWindow)
        t1.Start()
        Logger.Log("The program has been succesfully initialized.", LogType.L_INFORMATION)
        While True
            Console.ReadLine()
        End While
    End Sub
    Public Sub RunWindow()
        Dim gameWindow As GameWindow = New GameWindow(1280, 720)
        gameWindow.VSync = VSyncMode.Off
        gameWindow.Title = "Test"
        Dim Game As Game = New Game(gameWindow)
        gameWindow.Run(60, 60)
    End Sub
End Module