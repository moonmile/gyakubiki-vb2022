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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(27, 351)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(354, 72)
        Me.Button2.TabIndex = 19
        Me.Button2.Text = "挿入文字列（$）の利用"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(178, 162)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 25)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "label8"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(178, 114)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 25)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "label7"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(178, 69)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 25)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "label6"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(178, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 25)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "label5"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(27, 162)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(90, 25)
        Me.label4.TabIndex = 14
        Me.label4.Text = "ゼロ埋め："
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(27, 114)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(116, 25)
        Me.label3.TabIndex = 13
        Me.label3.Text = "小数点付き："
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(27, 69)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(102, 25)
        Me.label2.TabIndex = 12
        Me.label2.Text = "カンマ付き："
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(27, 25)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(66, 25)
        Me.label1.TabIndex = 11
        Me.label1.Text = "通常："
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(27, 261)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(354, 72)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "数値を文字列に変換"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(402, 449)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents Button2 As Button
    Private WithEvents Label8 As Label
    Private WithEvents Label7 As Label
    Private WithEvents Label6 As Label
    Private WithEvents Label5 As Label
    Private WithEvents label4 As Label
    Private WithEvents label3 As Label
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
    Private WithEvents Button1 As Button
End Class
