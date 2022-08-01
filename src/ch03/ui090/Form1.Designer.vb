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
        Me.button2 = New System.Windows.Forms.Button()
        Me.button1 = New System.Windows.Forms.Button()
        Me.dateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.label3 = New System.Windows.Forms.Label()
        Me.textBox3 = New System.Windows.Forms.TextBox()
        Me.textBox4 = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.textBox2 = New System.Windows.Forms.TextBox()
        Me.textBox1 = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'button2
        '
        Me.button2.Location = New System.Drawing.Point(347, 177)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(112, 34)
        Me.button2.TabIndex = 17
        Me.button2.TabStop = False
        Me.button2.Text = "キャンセル"
        Me.button2.UseVisualStyleBackColor = True
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(212, 177)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(112, 34)
        Me.button1.TabIndex = 15
        Me.button1.Text = "登録する"
        Me.button1.UseVisualStyleBackColor = True
        '
        'dateTimePicker1
        '
        Me.dateTimePicker1.Location = New System.Drawing.Point(140, 117)
        Me.dateTimePicker1.Name = "dateTimePicker1"
        Me.dateTimePicker1.Size = New System.Drawing.Size(319, 31)
        Me.dateTimePicker1.TabIndex = 14
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(28, 123)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(102, 25)
        Me.label3.TabIndex = 16
        Me.label3.Text = "生年月日："
        '
        'textBox3
        '
        Me.textBox3.Location = New System.Drawing.Point(309, 72)
        Me.textBox3.Name = "textBox3"
        Me.textBox3.Size = New System.Drawing.Size(150, 31)
        Me.textBox3.TabIndex = 12
        '
        'textBox4
        '
        Me.textBox4.Location = New System.Drawing.Point(140, 72)
        Me.textBox4.Name = "textBox4"
        Me.textBox4.Size = New System.Drawing.Size(150, 31)
        Me.textBox4.TabIndex = 11
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(28, 75)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(87, 25)
        Me.label2.TabIndex = 13
        Me.label2.Text = "ふりがな："
        '
        'textBox2
        '
        Me.textBox2.Location = New System.Drawing.Point(309, 26)
        Me.textBox2.Name = "textBox2"
        Me.textBox2.Size = New System.Drawing.Size(150, 31)
        Me.textBox2.TabIndex = 10
        '
        'textBox1
        '
        Me.textBox1.Location = New System.Drawing.Point(140, 26)
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(150, 31)
        Me.textBox1.TabIndex = 8
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(28, 29)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(66, 25)
        Me.label1.TabIndex = 9
        Me.label1.Text = "氏名："
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(482, 241)
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.dateTimePicker1)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.textBox3)
        Me.Controls.Add(Me.textBox4)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.textBox2)
        Me.Controls.Add(Me.textBox1)
        Me.Controls.Add(Me.label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents button2 As Button
    Private WithEvents button1 As Button
    Private WithEvents dateTimePicker1 As DateTimePicker
    Private WithEvents label3 As Label
    Private WithEvents textBox3 As TextBox
    Private WithEvents textBox4 As TextBox
    Private WithEvents label2 As Label
    Private WithEvents textBox2 As TextBox
    Private WithEvents textBox1 As TextBox
    Private WithEvents label1 As Label
End Class
