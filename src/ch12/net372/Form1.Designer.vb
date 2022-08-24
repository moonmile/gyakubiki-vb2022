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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 25
        Me.ListBox1.Location = New System.Drawing.Point(21, 59)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(354, 179)
        Me.ListBox1.TabIndex = 10
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(20, 249)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(356, 83)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "IPアドレスを取得"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(33, 19)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(99, 25)
        Me.label1.TabIndex = 8
        Me.label1.Text = "IPアドレス："
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(392, 351)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents ListBox1 As ListBox
    Private WithEvents Button1 As Button
    Private WithEvents label1 As Label
End Class
