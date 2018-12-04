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
        Me.Balance = New System.Windows.Forms.Label()
        Me.Tax = New System.Windows.Forms.Label()
        Me.Income = New System.Windows.Forms.Label()
        Me.Salary = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Labal1 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(329, 284)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "คำนวณ"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Balance
        '
        Me.Balance.AutoSize = True
        Me.Balance.BackColor = System.Drawing.Color.Aqua
        Me.Balance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Balance.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Balance.Location = New System.Drawing.Point(316, 230)
        Me.Balance.Name = "Balance"
        Me.Balance.Size = New System.Drawing.Size(97, 20)
        Me.Balance.TabIndex = 9
        Me.Balance.Text = "                      "
        '
        'Tax
        '
        Me.Tax.AutoSize = True
        Me.Tax.BackColor = System.Drawing.Color.Aqua
        Me.Tax.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Tax.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Tax.Location = New System.Drawing.Point(316, 176)
        Me.Tax.Name = "Tax"
        Me.Tax.Size = New System.Drawing.Size(97, 20)
        Me.Tax.TabIndex = 10
        Me.Tax.Text = "                      "
        '
        'Income
        '
        Me.Income.AutoSize = True
        Me.Income.BackColor = System.Drawing.Color.Aqua
        Me.Income.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Income.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Income.Location = New System.Drawing.Point(316, 117)
        Me.Income.Name = "Income"
        Me.Income.Size = New System.Drawing.Size(97, 20)
        Me.Income.TabIndex = 11
        Me.Income.Text = "                      "
        '
        'Salary
        '
        Me.Salary.Location = New System.Drawing.Point(313, 64)
        Me.Salary.Name = "Salary"
        Me.Salary.Size = New System.Drawing.Size(100, 20)
        Me.Salary.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Yellow
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(97, 230)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(168, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "เงินได้คงเหลือหลังหักภาษา"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Yellow
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(97, 176)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "ภาษีที่ต้องชำระ 5%"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(97, 64)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 20)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "เงินเดือน"
        '
        'Labal1
        '
        Me.Labal1.AutoSize = True
        Me.Labal1.BackColor = System.Drawing.Color.Yellow
        Me.Labal1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Labal1.Location = New System.Drawing.Point(97, 117)
        Me.Labal1.Name = "Labal1"
        Me.Labal1.Size = New System.Drawing.Size(73, 20)
        Me.Labal1.TabIndex = 7
        Me.Labal1.Text = "รายได้ทั้งปี"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(164, 326)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(353, 24)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "นายศราวุธ เค้ายาง  60342110065-5  BIS2/1N"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(537, 361)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Balance)
        Me.Controls.Add(Me.Tax)
        Me.Controls.Add(Me.Income)
        Me.Controls.Add(Me.Salary)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Labal1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Balance As Label
    Friend WithEvents Tax As Label
    Friend WithEvents Income As Label
    Friend WithEvents Salary As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Labal1 As Label
    Friend WithEvents Label1 As Label
End Class
