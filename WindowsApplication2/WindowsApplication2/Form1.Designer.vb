<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txt1 = New System.Windows.Forms.TextBox()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.lbl3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(291, 69)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "คำนวณ"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txt1
        '
        Me.txt1.Location = New System.Drawing.Point(164, 70)
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(100, 20)
        Me.txt1.TabIndex = 5
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.BackColor = System.Drawing.Color.YellowGreen
        Me.lbl1.Location = New System.Drawing.Point(172, 117)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(76, 13)
        Me.lbl1.TabIndex = 6
        Me.lbl1.Text = "                       "
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.BackColor = System.Drawing.Color.YellowGreen
        Me.lbl2.Location = New System.Drawing.Point(172, 145)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(76, 13)
        Me.lbl2.TabIndex = 7
        Me.lbl2.Text = "                       "
        '
        'lbl3
        '
        Me.lbl3.AutoSize = True
        Me.lbl3.BackColor = System.Drawing.Color.YellowGreen
        Me.lbl3.Location = New System.Drawing.Point(172, 177)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(76, 13)
        Me.lbl3.TabIndex = 8
        Me.lbl3.Text = "                       "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.LemonChiffon
        Me.Label4.Location = New System.Drawing.Point(49, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "เงินเดือน"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Pink
        Me.Label5.Location = New System.Drawing.Point(52, 116)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "รายได้ทั้งปี"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Gold
        Me.Label6.Location = New System.Drawing.Point(52, 145)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "ภาษี 5%"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.GreenYellow
        Me.Label7.Location = New System.Drawing.Point(52, 177)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "รายได้หลังหักภาษี"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(496, 362)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lbl3)
        Me.Controls.Add(Me.lbl2)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.txt1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txt1 As System.Windows.Forms.TextBox
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents lbl2 As System.Windows.Forms.Label
    Friend WithEvents lbl3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label

End Class
