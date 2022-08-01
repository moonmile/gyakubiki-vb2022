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
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(21, 150)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(320, 31)
        Me.TextBox2.TabIndex = 13
        Me.TextBox2.Text = "★★★"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(21, 110)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(149, 25)
        Me.label4.TabIndex = 12
        Me.label4.Text = "挿入する文字列："
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(21, 311)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(320, 69)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "指定位置に挿入"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 245)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 25)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "label3"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(21, 66)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(320, 31)
        Me.TextBox1.TabIndex = 9
        Me.TextBox1.Text = "マスダトモアキ"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(21, 199)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(84, 25)
        Me.label2.TabIndex = 8
        Me.label2.Text = "挿入後："
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(21, 23)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(84, 25)
        Me.label1.TabIndex = 7
        Me.label1.Text = "挿入前："
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(352, 397)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents TextBox2 As TextBox
    Private WithEvents label4 As Label
    Private WithEvents Button1 As Button
    Private WithEvents Label3 As Label
    Private WithEvents TextBox1 As TextBox
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
End Class
