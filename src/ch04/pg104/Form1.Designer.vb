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
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(21, 217)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(453, 85)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "TryParseを使う"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(317, 27)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(24, 25)
        Me.label2.TabIndex = 12
        Me.label2.Text = "="
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(154, 27)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(24, 25)
        Me.label1.TabIndex = 11
        Me.label1.Text = "+"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(347, 24)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(127, 31)
        Me.TextBox3.TabIndex = 10
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(184, 24)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(127, 31)
        Me.TextBox2.TabIndex = 9
        Me.TextBox2.Text = "7.0"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(21, 24)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(127, 31)
        Me.TextBox1.TabIndex = 8
        Me.TextBox1.Text = "10.25"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(21, 113)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(453, 85)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "文字列を数値型に変換"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(493, 332)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents Button2 As Button
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
    Private WithEvents TextBox3 As TextBox
    Private WithEvents TextBox2 As TextBox
    Private WithEvents TextBox1 As TextBox
    Private WithEvents Button1 As Button
End Class
