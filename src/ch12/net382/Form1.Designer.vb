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
        Me.label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(21, 202)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(354, 225)
        Me.TextBox2.TabIndex = 9
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(21, 163)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(66, 25)
        Me.label2.TabIndex = 8
        Me.label2.Text = "結果："
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(100, 17)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(263, 31)
        Me.TextBox1.TabIndex = 7
        Me.TextBox1.Text = "1"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(32, 20)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(48, 25)
        Me.label1.TabIndex = 6
        Me.label1.Text = "ID："
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(21, 65)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(354, 78)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "実行"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(399, 450)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents TextBox2 As TextBox
    Private WithEvents label2 As Label
    Private WithEvents TextBox1 As TextBox
    Private WithEvents label1 As Label
    Private WithEvents Button1 As Button
End Class
