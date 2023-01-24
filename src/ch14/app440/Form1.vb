Imports System.Configuration
Imports Microsoft.Win32

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)
        Dim appSettings = configFile.AppSettings.Settings
        Dim key = TextBox1.Text
        Dim value = TextBox2.Text
        If appSettings(key) Is Nothing Then
            appSettings.Add(key, value)
        Else
            appSettings(key).Value = value
        End If
        configFile.Save(ConfigurationSaveMode.Modified)
        MessageBox.Show("設定を保存しました")
    End Sub
End Class
