Friend Module Program

    <STAThread()>
    Friend Sub Main(args As String())
        Application.SetHighDpiMode(HighDpiMode.SystemAware)
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)
        ' フォームを開く前の処理
        MessageBox.Show("起動時刻 " + DateTime.Now.ToString())
        ' フォームを開く
        Application.Run(New Form1)
    End Sub

End Module
