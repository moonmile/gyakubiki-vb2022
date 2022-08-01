Friend Module Program

    <STAThread()>
    Friend Sub Main(args As String())
        Application.SetHighDpiMode(HighDpiMode.SystemAware)
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)

        Dim Splash As New Splash
        Splash.ShowDialog()

        Application.Run(New Form1)
    End Sub

End Module
