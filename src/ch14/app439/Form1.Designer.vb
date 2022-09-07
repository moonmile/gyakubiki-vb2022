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
        Me.label2 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(30, 196)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(48, 25)
        Me.label2.TabIndex = 14
        Me.label2.Text = "値："
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(110, 193)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(252, 31)
        Me.TextBox2.TabIndex = 13
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(30, 135)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(74, 25)
        Me.label1.TabIndex = 12
        Me.label1.Text = "キー名："
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(21, 26)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(354, 82)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "接続文字列を読み込み"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(110, 135)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(252, 31)
        Me.TextBox1.TabIndex = 10
        Me.TextBox1.Text = "connection1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(390, 256)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents label2 As Label
    Private WithEvents TextBox2 As TextBox
    Private WithEvents label1 As Label
    Private WithEvents Button1 As Button
    Private WithEvents TextBox1 As TextBox
End Class
