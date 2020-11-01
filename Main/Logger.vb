Public Class Logger
    Public Shared Sub Log(ByVal LogLine As String, ByVal T_LogType As LogType)
        Dim Symbol As String = ""
        If T_LogType.Equals(LogType.L_ERROR) Then
            Symbol = "ERROR"
        ElseIf T_LogType.Equals(LogType.L_INFORMATION) Then
            Symbol = "INFO"
        ElseIf T_LogType.Equals(LogType.L_WARNING) Then
            Symbol = "WARN"
        End If
        Console.WriteLine("[" + DateTime.Now.ToLongTimeString() + "] (" + Symbol + ") " + LogLine)
    End Sub
End Class