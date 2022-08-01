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
        Me.label3 = New System.Windows.Forms.Label()
        Me.ListBox3 = New System.Windows.Forms.ListBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(29, 335)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(667, 75)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "配列を並び替える"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(485, 26)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(99, 25)
        Me.label3.TabIndex = 12
        Me.label3.Text = "降順でソート"
        '
        'ListBox3
        '
        Me.ListBox3.FormattingEnabled = True
        Me.ListBox3.ItemHeight = 25
        Me.ListBox3.Location = New System.Drawing.Point(485, 65)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.Size = New System.Drawing.Size(211, 254)
        Me.ListBox3.TabIndex = 11
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(259, 26)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(99, 25)
        Me.label2.TabIndex = 10
        Me.label2.Text = "昇順でソート"
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 25
        Me.ListBox2.Location = New System.Drawing.Point(259, 65)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(211, 254)
        Me.ListBox2.TabIndex = 9
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(29, 26)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(67, 25)
        Me.label1.TabIndex = 8
        Me.label1.Text = "ソート前"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 25
        Me.ListBox1.Location = New System.Drawing.Point(29, 65)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(211, 254)
        Me.ListBox1.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(717, 430)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.ListBox3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents Button1 As Button
    Private WithEvents label3 As Label
    Private WithEvents ListBox3 As ListBox
    Private WithEvents label2 As Label
    Private WithEvents ListBox2 As ListBox
    Private WithEvents label1 As Label
    Private WithEvents ListBox1 As ListBox
End Class
