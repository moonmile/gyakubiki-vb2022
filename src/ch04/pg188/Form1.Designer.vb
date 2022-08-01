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
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(32, 109)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(90, 25)
        Me.label4.TabIndex = 17
        Me.label4.Text = "タスク２："
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(30, 40)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(90, 25)
        Me.label3.TabIndex = 16
        Me.label3.Text = "タスク１："
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Yu Gothic UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(126, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(240, 67)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "label2"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 253)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(354, 77)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "２つのタスクを同時に実行"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 170)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(354, 77)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "２つのタスクを順番に実行"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Yu Gothic UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(126, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(240, 67)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "label1"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(380, 346)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents label4 As Label
    Private WithEvents label3 As Label
    Private WithEvents Label2 As Label
    Private WithEvents Button2 As Button
    Private WithEvents Button1 As Button
    Private WithEvents Label1 As Label
End Class
