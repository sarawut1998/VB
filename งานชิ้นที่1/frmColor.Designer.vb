<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmColor
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
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnUp = New System.Windows.Forms.Button()
        Me.btnDown = New System.Windows.Forms.Button()
        Me.cboSize = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblFSky = New System.Windows.Forms.Label()
        Me.lblFBlack = New System.Windows.Forms.Label()
        Me.lblFWhite = New System.Windows.Forms.Label()
        Me.lblFViolet = New System.Windows.Forms.Label()
        Me.lblFBrown = New System.Windows.Forms.Label()
        Me.lblFGreen = New System.Windows.Forms.Label()
        Me.lblFYellow = New System.Windows.Forms.Label()
        Me.lblFBlue = New System.Windows.Forms.Label()
        Me.lblFOrange = New System.Windows.Forms.Label()
        Me.lblFRed = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblBSky = New System.Windows.Forms.Label()
        Me.lblBBlack = New System.Windows.Forms.Label()
        Me.lblBwhite = New System.Windows.Forms.Label()
        Me.lblBViolet = New System.Windows.Forms.Label()
        Me.lblBBrown = New System.Windows.Forms.Label()
        Me.lblBGreen = New System.Windows.Forms.Label()
        Me.lblBYellow = New System.Windows.Forms.Label()
        Me.lblBBlue = New System.Windows.Forms.Label()
        Me.lblBOrange = New System.Windows.Forms.Label()
        Me.lblBRed = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtInput
        '
        Me.txtInput.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtInput.Location = New System.Drawing.Point(160, 55)
        Me.txtInput.Multiline = True
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(328, 78)
        Me.txtInput.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(47, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "กำหนดตัวเลข"
        '
        'btnUp
        '
        Me.btnUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnUp.Location = New System.Drawing.Point(488, 55)
        Me.btnUp.Name = "btnUp"
        Me.btnUp.Size = New System.Drawing.Size(51, 39)
        Me.btnUp.TabIndex = 2
        Me.btnUp.Text = "+"
        Me.btnUp.UseVisualStyleBackColor = True
        '
        'btnDown
        '
        Me.btnDown.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnDown.Location = New System.Drawing.Point(488, 94)
        Me.btnDown.Name = "btnDown"
        Me.btnDown.Size = New System.Drawing.Size(51, 39)
        Me.btnDown.TabIndex = 3
        Me.btnDown.Text = "-"
        Me.btnDown.UseVisualStyleBackColor = True
        '
        'cboSize
        '
        Me.cboSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSize.FormattingEnabled = True
        Me.cboSize.Items.AddRange(New Object() {"12", "14", "16", "18", "20", "22", "24", "26", "28", "30", "32", "34", "36", "38", "40", "42", "44", "46", "48", "50"})
        Me.cboSize.Location = New System.Drawing.Point(482, 149)
        Me.cboSize.Name = "cboSize"
        Me.cboSize.Size = New System.Drawing.Size(62, 21)
        Me.cboSize.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(379, 149)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ขนาดฟอนต์"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.GroupBox1.Controls.Add(Me.lblFSky)
        Me.GroupBox1.Controls.Add(Me.lblFBlack)
        Me.GroupBox1.Controls.Add(Me.lblFWhite)
        Me.GroupBox1.Controls.Add(Me.lblFViolet)
        Me.GroupBox1.Controls.Add(Me.lblFBrown)
        Me.GroupBox1.Controls.Add(Me.lblFGreen)
        Me.GroupBox1.Controls.Add(Me.lblFYellow)
        Me.GroupBox1.Controls.Add(Me.lblFBlue)
        Me.GroupBox1.Controls.Add(Me.lblFOrange)
        Me.GroupBox1.Controls.Add(Me.lblFRed)
        Me.GroupBox1.Location = New System.Drawing.Point(131, 206)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 82)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ForeColor"
        '
        'lblFSky
        '
        Me.lblFSky.AutoSize = True
        Me.lblFSky.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblFSky.ForeColor = System.Drawing.Color.Red
        Me.lblFSky.Location = New System.Drawing.Point(154, 45)
        Me.lblFSky.Name = "lblFSky"
        Me.lblFSky.Size = New System.Drawing.Size(31, 26)
        Me.lblFSky.TabIndex = 0
        Me.lblFSky.Text = "        " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblFBlack
        '
        Me.lblFBlack.AutoSize = True
        Me.lblFBlack.BackColor = System.Drawing.Color.Black
        Me.lblFBlack.ForeColor = System.Drawing.Color.Red
        Me.lblFBlack.Location = New System.Drawing.Point(154, 16)
        Me.lblFBlack.Name = "lblFBlack"
        Me.lblFBlack.Size = New System.Drawing.Size(31, 26)
        Me.lblFBlack.TabIndex = 0
        Me.lblFBlack.Text = "        " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblFWhite
        '
        Me.lblFWhite.AutoSize = True
        Me.lblFWhite.BackColor = System.Drawing.Color.White
        Me.lblFWhite.ForeColor = System.Drawing.Color.Red
        Me.lblFWhite.Location = New System.Drawing.Point(117, 45)
        Me.lblFWhite.Name = "lblFWhite"
        Me.lblFWhite.Size = New System.Drawing.Size(31, 26)
        Me.lblFWhite.TabIndex = 0
        Me.lblFWhite.Text = "        " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblFViolet
        '
        Me.lblFViolet.AutoSize = True
        Me.lblFViolet.BackColor = System.Drawing.Color.Fuchsia
        Me.lblFViolet.ForeColor = System.Drawing.Color.Red
        Me.lblFViolet.Location = New System.Drawing.Point(117, 16)
        Me.lblFViolet.Name = "lblFViolet"
        Me.lblFViolet.Size = New System.Drawing.Size(31, 26)
        Me.lblFViolet.TabIndex = 0
        Me.lblFViolet.Text = "        " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblFBrown
        '
        Me.lblFBrown.AutoSize = True
        Me.lblFBrown.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblFBrown.ForeColor = System.Drawing.Color.Red
        Me.lblFBrown.Location = New System.Drawing.Point(80, 45)
        Me.lblFBrown.Name = "lblFBrown"
        Me.lblFBrown.Size = New System.Drawing.Size(31, 26)
        Me.lblFBrown.TabIndex = 0
        Me.lblFBrown.Text = "        " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblFGreen
        '
        Me.lblFGreen.AutoSize = True
        Me.lblFGreen.BackColor = System.Drawing.Color.Lime
        Me.lblFGreen.ForeColor = System.Drawing.Color.Red
        Me.lblFGreen.Location = New System.Drawing.Point(80, 16)
        Me.lblFGreen.Name = "lblFGreen"
        Me.lblFGreen.Size = New System.Drawing.Size(31, 26)
        Me.lblFGreen.TabIndex = 0
        Me.lblFGreen.Text = "        " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblFYellow
        '
        Me.lblFYellow.AutoSize = True
        Me.lblFYellow.BackColor = System.Drawing.Color.Yellow
        Me.lblFYellow.ForeColor = System.Drawing.Color.Red
        Me.lblFYellow.Location = New System.Drawing.Point(43, 45)
        Me.lblFYellow.Name = "lblFYellow"
        Me.lblFYellow.Size = New System.Drawing.Size(31, 26)
        Me.lblFYellow.TabIndex = 0
        Me.lblFYellow.Text = "        " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblFBlue
        '
        Me.lblFBlue.AutoSize = True
        Me.lblFBlue.BackColor = System.Drawing.Color.Blue
        Me.lblFBlue.ForeColor = System.Drawing.Color.Red
        Me.lblFBlue.Location = New System.Drawing.Point(43, 16)
        Me.lblFBlue.Name = "lblFBlue"
        Me.lblFBlue.Size = New System.Drawing.Size(31, 26)
        Me.lblFBlue.TabIndex = 0
        Me.lblFBlue.Text = "        " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblFOrange
        '
        Me.lblFOrange.AutoSize = True
        Me.lblFOrange.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblFOrange.ForeColor = System.Drawing.Color.Red
        Me.lblFOrange.Location = New System.Drawing.Point(6, 44)
        Me.lblFOrange.Name = "lblFOrange"
        Me.lblFOrange.Size = New System.Drawing.Size(31, 26)
        Me.lblFOrange.TabIndex = 0
        Me.lblFOrange.Text = "        " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblFRed
        '
        Me.lblFRed.AutoSize = True
        Me.lblFRed.BackColor = System.Drawing.Color.Red
        Me.lblFRed.ForeColor = System.Drawing.Color.Red
        Me.lblFRed.Location = New System.Drawing.Point(6, 16)
        Me.lblFRed.Name = "lblFRed"
        Me.lblFRed.Size = New System.Drawing.Size(31, 26)
        Me.lblFRed.TabIndex = 0
        Me.lblFRed.Text = "        " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.GroupBox2.Controls.Add(Me.lblBSky)
        Me.GroupBox2.Controls.Add(Me.lblBBlack)
        Me.GroupBox2.Controls.Add(Me.lblBwhite)
        Me.GroupBox2.Controls.Add(Me.lblBViolet)
        Me.GroupBox2.Controls.Add(Me.lblBBrown)
        Me.GroupBox2.Controls.Add(Me.lblBGreen)
        Me.GroupBox2.Controls.Add(Me.lblBYellow)
        Me.GroupBox2.Controls.Add(Me.lblBBlue)
        Me.GroupBox2.Controls.Add(Me.lblBOrange)
        Me.GroupBox2.Controls.Add(Me.lblBRed)
        Me.GroupBox2.Location = New System.Drawing.Point(350, 206)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 82)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "BgColor"
        '
        'lblBSky
        '
        Me.lblBSky.AutoSize = True
        Me.lblBSky.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblBSky.ForeColor = System.Drawing.Color.Red
        Me.lblBSky.Location = New System.Drawing.Point(154, 45)
        Me.lblBSky.Name = "lblBSky"
        Me.lblBSky.Size = New System.Drawing.Size(31, 26)
        Me.lblBSky.TabIndex = 0
        Me.lblBSky.Text = "        " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblBBlack
        '
        Me.lblBBlack.AutoSize = True
        Me.lblBBlack.BackColor = System.Drawing.Color.Black
        Me.lblBBlack.ForeColor = System.Drawing.Color.Red
        Me.lblBBlack.Location = New System.Drawing.Point(154, 16)
        Me.lblBBlack.Name = "lblBBlack"
        Me.lblBBlack.Size = New System.Drawing.Size(31, 26)
        Me.lblBBlack.TabIndex = 0
        Me.lblBBlack.Text = "        " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblBwhite
        '
        Me.lblBwhite.AutoSize = True
        Me.lblBwhite.BackColor = System.Drawing.Color.White
        Me.lblBwhite.ForeColor = System.Drawing.Color.Red
        Me.lblBwhite.Location = New System.Drawing.Point(117, 45)
        Me.lblBwhite.Name = "lblBwhite"
        Me.lblBwhite.Size = New System.Drawing.Size(31, 26)
        Me.lblBwhite.TabIndex = 0
        Me.lblBwhite.Text = "        " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblBViolet
        '
        Me.lblBViolet.AutoSize = True
        Me.lblBViolet.BackColor = System.Drawing.Color.Fuchsia
        Me.lblBViolet.ForeColor = System.Drawing.Color.Red
        Me.lblBViolet.Location = New System.Drawing.Point(117, 16)
        Me.lblBViolet.Name = "lblBViolet"
        Me.lblBViolet.Size = New System.Drawing.Size(31, 26)
        Me.lblBViolet.TabIndex = 0
        Me.lblBViolet.Text = "        " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblBBrown
        '
        Me.lblBBrown.AutoSize = True
        Me.lblBBrown.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblBBrown.ForeColor = System.Drawing.Color.Red
        Me.lblBBrown.Location = New System.Drawing.Point(80, 45)
        Me.lblBBrown.Name = "lblBBrown"
        Me.lblBBrown.Size = New System.Drawing.Size(31, 26)
        Me.lblBBrown.TabIndex = 0
        Me.lblBBrown.Text = "        " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblBGreen
        '
        Me.lblBGreen.AutoSize = True
        Me.lblBGreen.BackColor = System.Drawing.Color.Lime
        Me.lblBGreen.ForeColor = System.Drawing.Color.Red
        Me.lblBGreen.Location = New System.Drawing.Point(80, 16)
        Me.lblBGreen.Name = "lblBGreen"
        Me.lblBGreen.Size = New System.Drawing.Size(31, 26)
        Me.lblBGreen.TabIndex = 0
        Me.lblBGreen.Text = "        " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblBYellow
        '
        Me.lblBYellow.AutoSize = True
        Me.lblBYellow.BackColor = System.Drawing.Color.Yellow
        Me.lblBYellow.ForeColor = System.Drawing.Color.Red
        Me.lblBYellow.Location = New System.Drawing.Point(43, 45)
        Me.lblBYellow.Name = "lblBYellow"
        Me.lblBYellow.Size = New System.Drawing.Size(31, 26)
        Me.lblBYellow.TabIndex = 0
        Me.lblBYellow.Text = "        " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblBBlue
        '
        Me.lblBBlue.AutoSize = True
        Me.lblBBlue.BackColor = System.Drawing.Color.Blue
        Me.lblBBlue.ForeColor = System.Drawing.Color.Red
        Me.lblBBlue.Location = New System.Drawing.Point(43, 16)
        Me.lblBBlue.Name = "lblBBlue"
        Me.lblBBlue.Size = New System.Drawing.Size(31, 26)
        Me.lblBBlue.TabIndex = 0
        Me.lblBBlue.Text = "        " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblBOrange
        '
        Me.lblBOrange.AutoSize = True
        Me.lblBOrange.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblBOrange.ForeColor = System.Drawing.Color.Red
        Me.lblBOrange.Location = New System.Drawing.Point(6, 44)
        Me.lblBOrange.Name = "lblBOrange"
        Me.lblBOrange.Size = New System.Drawing.Size(31, 26)
        Me.lblBOrange.TabIndex = 0
        Me.lblBOrange.Text = "        " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblBRed
        '
        Me.lblBRed.AutoSize = True
        Me.lblBRed.BackColor = System.Drawing.Color.Red
        Me.lblBRed.ForeColor = System.Drawing.Color.Red
        Me.lblBRed.Location = New System.Drawing.Point(6, 16)
        Me.lblBRed.Name = "lblBRed"
        Me.lblBRed.Size = New System.Drawing.Size(31, 26)
        Me.lblBRed.TabIndex = 0
        Me.lblBRed.Text = "        " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'frmColor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(594, 334)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cboSize)
        Me.Controls.Add(Me.btnDown)
        Me.Controls.Add(Me.btnUp)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtInput)
        Me.Name = "frmColor"
        Me.Text = "frmColor"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtInput As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnUp As Button
    Friend WithEvents btnDown As Button
    Friend WithEvents cboSize As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblFRed As Label
    Friend WithEvents lblFSky As Label
    Friend WithEvents lblFBlack As Label
    Friend WithEvents lblFWhite As Label
    Friend WithEvents lblFViolet As Label
    Friend WithEvents lblFBrown As Label
    Friend WithEvents lblFGreen As Label
    Friend WithEvents lblFYellow As Label
    Friend WithEvents lblFBlue As Label
    Friend WithEvents lblFOrange As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblBSky As Label
    Friend WithEvents lblBBlack As Label
    Friend WithEvents lblBwhite As Label
    Friend WithEvents lblBViolet As Label
    Friend WithEvents lblBBrown As Label
    Friend WithEvents lblBGreen As Label
    Friend WithEvents lblBYellow As Label
    Friend WithEvents lblBBlue As Label
    Friend WithEvents lblBOrange As Label
    Friend WithEvents lblBRed As Label
End Class
