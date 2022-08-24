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
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 25
        Me.ListBox1.Location = New System.Drawing.Point(12, 264)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(354, 154)
        Me.ListBox1.TabIndex = 31
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(127, 71)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(227, 31)
        Me.TextBox2.TabIndex = 30
        Me.TextBox2.Text = "秀和システム"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(23, 74)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(84, 25)
        Me.label3.TabIndex = 29
        Me.label3.Text = "出版社："
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(12, 221)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(66, 25)
        Me.label2.TabIndex = 28
        Me.label2.Text = "結果："
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(127, 19)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(227, 31)
        Me.TextBox1.TabIndex = 27
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(23, 22)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(84, 25)
        Me.label1.TabIndex = 26
        Me.label1.Text = "著者名："
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 124)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(354, 78)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "実行"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(380, 441)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents ListBox1 As ListBox
    Private WithEvents TextBox2 As TextBox
    Private WithEvents label3 As Label
    Private WithEvents label2 As Label
    Private WithEvents TextBox1 As TextBox
    Private WithEvents label1 As Label
    Private WithEvents Button1 As Button
End Class
