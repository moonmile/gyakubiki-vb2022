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
        Me.textBox1 = New System.Windows.Forms.TextBox()
        Me.checkBox2 = New System.Windows.Forms.CheckBox()
        Me.checkBox1 = New System.Windows.Forms.CheckBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.button6 = New System.Windows.Forms.Button()
        Me.button5 = New System.Windows.Forms.Button()
        Me.button4 = New System.Windows.Forms.Button()
        Me.button3 = New System.Windows.Forms.Button()
        Me.button2 = New System.Windows.Forms.Button()
        Me.button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'textBox1
        '
        Me.textBox1.Location = New System.Drawing.Point(27, 337)
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(496, 31)
        Me.textBox1.TabIndex = 19
        '
        'checkBox2
        '
        Me.checkBox2.AutoSize = True
        Me.checkBox2.Location = New System.Drawing.Point(198, 85)
        Me.checkBox2.Name = "checkBox2"
        Me.checkBox2.Size = New System.Drawing.Size(121, 29)
        Me.checkBox2.TabIndex = 18
        Me.checkBox2.Text = "checkBox2"
        Me.checkBox2.UseVisualStyleBackColor = True
        '
        'checkBox1
        '
        Me.checkBox1.AutoSize = True
        Me.checkBox1.Location = New System.Drawing.Point(28, 85)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(121, 29)
        Me.checkBox1.TabIndex = 17
        Me.checkBox1.Text = "checkBox1"
        Me.checkBox1.UseVisualStyleBackColor = True
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(28, 28)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(364, 25)
        Me.label1.TabIndex = 16
        Me.label1.Text = "フォームの中にボタンを見つけたら、文字列を変える"
        '
        'button6
        '
        Me.button6.Location = New System.Drawing.Point(370, 240)
        Me.button6.Name = "button6"
        Me.button6.Size = New System.Drawing.Size(153, 78)
        Me.button6.TabIndex = 15
        Me.button6.Text = "button6"
        Me.button6.UseVisualStyleBackColor = True
        '
        'button5
        '
        Me.button5.Location = New System.Drawing.Point(198, 240)
        Me.button5.Name = "button5"
        Me.button5.Size = New System.Drawing.Size(153, 78)
        Me.button5.TabIndex = 14
        Me.button5.Text = "button5"
        Me.button5.UseVisualStyleBackColor = True
        '
        'button4
        '
        Me.button4.Location = New System.Drawing.Point(28, 240)
        Me.button4.Name = "button4"
        Me.button4.Size = New System.Drawing.Size(153, 78)
        Me.button4.TabIndex = 13
        Me.button4.Text = "button4"
        Me.button4.UseVisualStyleBackColor = True
        '
        'button3
        '
        Me.button3.Location = New System.Drawing.Point(370, 138)
        Me.button3.Name = "button3"
        Me.button3.Size = New System.Drawing.Size(153, 78)
        Me.button3.TabIndex = 12
        Me.button3.Text = "button3"
        Me.button3.UseVisualStyleBackColor = True
        '
        'button2
        '
        Me.button2.Location = New System.Drawing.Point(198, 138)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(153, 78)
        Me.button2.TabIndex = 11
        Me.button2.Text = "button2"
        Me.button2.UseVisualStyleBackColor = True
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(28, 138)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(153, 78)
        Me.button1.TabIndex = 10
        Me.button1.Text = "実行"
        Me.button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(549, 391)
        Me.Controls.Add(Me.textBox1)
        Me.Controls.Add(Me.checkBox2)
        Me.Controls.Add(Me.checkBox1)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.button6)
        Me.Controls.Add(Me.button5)
        Me.Controls.Add(Me.button4)
        Me.Controls.Add(Me.button3)
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents textBox1 As TextBox
    Private WithEvents checkBox2 As CheckBox
    Private WithEvents checkBox1 As CheckBox
    Private WithEvents label1 As Label
    Private WithEvents button6 As Button
    Private WithEvents button5 As Button
    Private WithEvents button4 As Button
    Private WithEvents button3 As Button
    Private WithEvents button2 As Button
    Private WithEvents button1 As Button
End Class
