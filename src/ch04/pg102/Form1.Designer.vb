﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(243, 90)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 25)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "label4"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(119, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 25)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "label3"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(119, 31)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(247, 31)
        Me.TextBox1.TabIndex = 9
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(19, 90)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(69, 25)
        Me.label2.TabIndex = 8
        Me.label2.Text = "ランク："
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(15, 34)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(66, 25)
        Me.label1.TabIndex = 7
        Me.label1.Text = "得点："
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 229)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(354, 84)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "列挙型を定義する"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(378, 344)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents Label4 As Label
    Private WithEvents Label3 As Label
    Private WithEvents TextBox1 As TextBox
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
    Private WithEvents Button1 As Button
End Class