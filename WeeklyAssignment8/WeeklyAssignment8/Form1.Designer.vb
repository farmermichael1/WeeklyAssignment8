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
        Me.cbMonth = New System.Windows.Forms.ComboBox()
        Me.lbTitle = New System.Windows.Forms.Label()
        Me.lbMonth = New System.Windows.Forms.Label()
        Me.lbAverage = New System.Windows.Forms.Label()
        Me.lbGreat = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbMonth
        '
        Me.cbMonth.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMonth.FormattingEnabled = True
        Me.cbMonth.Location = New System.Drawing.Point(456, 155)
        Me.cbMonth.Name = "cbMonth"
        Me.cbMonth.Size = New System.Drawing.Size(193, 37)
        Me.cbMonth.TabIndex = 0
        '
        'lbTitle
        '
        Me.lbTitle.AutoSize = True
        Me.lbTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTitle.Location = New System.Drawing.Point(427, 55)
        Me.lbTitle.Name = "lbTitle"
        Me.lbTitle.Size = New System.Drawing.Size(259, 74)
        Me.lbTitle.TabIndex = 1
        Me.lbTitle.Text = "Smart Home " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Electric Savings"
        Me.lbTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbMonth
        '
        Me.lbMonth.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbMonth.AutoSize = True
        Me.lbMonth.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbMonth.Location = New System.Drawing.Point(146, 330)
        Me.lbMonth.Name = "lbMonth"
        Me.lbMonth.Size = New System.Drawing.Size(439, 24)
        Me.lbMonth.TabIndex = 2
        Me.lbMonth.Text = "The electric savings for (MONTH) is (MONEY)"
        Me.lbMonth.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbAverage
        '
        Me.lbAverage.AutoSize = True
        Me.lbAverage.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.lbAverage.Location = New System.Drawing.Point(167, 431)
        Me.lbAverage.Name = "lbAverage"
        Me.lbAverage.Size = New System.Drawing.Size(384, 24)
        Me.lbAverage.TabIndex = 3
        Me.lbAverage.Text = "The average monthly savings: (MONEY)"
        Me.lbAverage.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbGreat
        '
        Me.lbGreat.AutoSize = True
        Me.lbGreat.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.lbGreat.Location = New System.Drawing.Point(107, 481)
        Me.lbGreat.Name = "lbGreat"
        Me.lbGreat.Size = New System.Drawing.Size(532, 24)
        Me.lbGreat.TabIndex = 4
        Me.lbGreat.Text = "(THIS MONTH) had the most significant monthly savings"
        Me.lbGreat.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnCalc
        '
        Me.btnCalc.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalc.Location = New System.Drawing.Point(248, 373)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(230, 38)
        Me.btnCalc.TabIndex = 5
        Me.btnCalc.Text = "Display Statistics"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WeeklyAssignment8.My.Resources.Resources.smarthome
        Me.PictureBox1.Location = New System.Drawing.Point(-3, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(371, 307)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.ClientSize = New System.Drawing.Size(720, 562)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.lbGreat)
        Me.Controls.Add(Me.lbAverage)
        Me.Controls.Add(Me.lbMonth)
        Me.Controls.Add(Me.lbTitle)
        Me.Controls.Add(Me.cbMonth)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbMonth As ComboBox
    Friend WithEvents lbTitle As Label
    Friend WithEvents lbMonth As Label
    Friend WithEvents lbAverage As Label
    Friend WithEvents lbGreat As Label
    Friend WithEvents btnCalc As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
