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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(23, 373)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(573, 78)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "検索する"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 25
        Me.ListBox1.Location = New System.Drawing.Point(326, 67)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(270, 279)
        Me.ListBox1.TabIndex = 12
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(326, 34)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(66, 25)
        Me.label3.TabIndex = 11
        Me.label3.Text = "結果："
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(23, 268)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(271, 31)
        Me.TextBox2.TabIndex = 10
        Me.TextBox2.Text = "カキ"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(23, 231)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(149, 25)
        Me.label2.TabIndex = 9
        Me.label2.Text = "検索する文字列："
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(23, 25)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(102, 25)
        Me.label1.TabIndex = 8
        Me.label1.Text = "検索対象："
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(23, 67)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(271, 144)
        Me.TextBox1.TabIndex = 7
        Me.TextBox1.Text = "カキは粒がそろったものを選びます。カキの下処理は、大根おろしを使います。"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(615, 473)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents Button1 As Button
    Private WithEvents ListBox1 As ListBox
    Private WithEvents label3 As Label
    Private WithEvents TextBox2 As TextBox
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
    Private WithEvents TextBox1 As TextBox
End Class
