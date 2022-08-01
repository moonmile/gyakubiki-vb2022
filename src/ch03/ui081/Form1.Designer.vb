<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(510, 237)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(167, 80)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "太文字"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(510, 129)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(167, 80)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "色変更"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(510, 24)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(167, 80)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "フォント変更"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(21, 24)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(473, 392)
        Me.RichTextBox1.TabIndex = 4
        Me.RichTextBox1.Text = "今日のタスク" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10) & "1.旅費精算" & Global.Microsoft.VisualBasic.ChrW(10) & "2.業務報告書（提出は夕方まで）" & Global.Microsoft.VisualBasic.ChrW(10) & "3.ファイル整理" & Global.Microsoft.VisualBasic.ChrW(10) & "4.夕方に本屋へ（VBの学習用）"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(694, 450)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents Button3 As Button
    Private WithEvents Button2 As Button
    Private WithEvents Button1 As Button
    Private WithEvents RichTextBox1 As RichTextBox
End Class
