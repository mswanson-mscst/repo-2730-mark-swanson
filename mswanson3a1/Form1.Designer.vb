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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblCount = New System.Windows.Forms.Label()
        Me.btnSumForNext = New System.Windows.Forms.Button()
        Me.btnSumLoopUntil = New System.Windows.Forms.Button()
        Me.btnSumDoWhile = New System.Windows.Forms.Button()
        Me.lblAvg = New System.Windows.Forms.Label()
        Me.txtList = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.posttestLoopUntilButton = New System.Windows.Forms.Button()
        Me.forLoopButton = New System.Windows.Forms.Button()
        Me.posttestLoopWhileButton = New System.Windows.Forms.Button()
        Me.pretestDoUntilButton = New System.Windows.Forms.Button()
        Me.pretestDoWhileButton = New System.Windows.Forms.Button()
        Me.lblEven = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.lblCount)
        Me.GroupBox2.Controls.Add(Me.btnSumForNext)
        Me.GroupBox2.Controls.Add(Me.btnSumLoopUntil)
        Me.GroupBox2.Controls.Add(Me.btnSumDoWhile)
        Me.GroupBox2.Controls.Add(Me.lblAvg)
        Me.GroupBox2.Controls.Add(Me.txtList)
        Me.GroupBox2.Location = New System.Drawing.Point(270, 13)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(252, 176)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "p332 & 348 #22 Addition"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(189, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Count:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(133, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Average:"
        '
        'lblCount
        '
        Me.lblCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCount.Location = New System.Drawing.Point(190, 30)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(52, 30)
        Me.lblCount.TabIndex = 16
        Me.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSumForNext
        '
        Me.btnSumForNext.Location = New System.Drawing.Point(132, 135)
        Me.btnSumForNext.Name = "btnSumForNext"
        Me.btnSumForNext.Size = New System.Drawing.Size(110, 29)
        Me.btnSumForNext.TabIndex = 15
        Me.btnSumForNext.Text = "Sum, For Next"
        Me.btnSumForNext.UseVisualStyleBackColor = True
        '
        'btnSumLoopUntil
        '
        Me.btnSumLoopUntil.Location = New System.Drawing.Point(133, 100)
        Me.btnSumLoopUntil.Name = "btnSumLoopUntil"
        Me.btnSumLoopUntil.Size = New System.Drawing.Size(110, 29)
        Me.btnSumLoopUntil.TabIndex = 14
        Me.btnSumLoopUntil.Text = "Sum, Loop Until"
        Me.btnSumLoopUntil.UseVisualStyleBackColor = True
        '
        'btnSumDoWhile
        '
        Me.btnSumDoWhile.Location = New System.Drawing.Point(133, 65)
        Me.btnSumDoWhile.Name = "btnSumDoWhile"
        Me.btnSumDoWhile.Size = New System.Drawing.Size(110, 29)
        Me.btnSumDoWhile.TabIndex = 7
        Me.btnSumDoWhile.Text = "Sum, Do While"
        Me.btnSumDoWhile.UseVisualStyleBackColor = True
        '
        'lblAvg
        '
        Me.lblAvg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAvg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvg.Location = New System.Drawing.Point(133, 30)
        Me.lblAvg.Name = "lblAvg"
        Me.lblAvg.Size = New System.Drawing.Size(52, 30)
        Me.lblAvg.TabIndex = 13
        Me.lblAvg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtList
        '
        Me.txtList.Location = New System.Drawing.Point(8, 18)
        Me.txtList.Multiline = True
        Me.txtList.Name = "txtList"
        Me.txtList.ReadOnly = True
        Me.txtList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtList.Size = New System.Drawing.Size(115, 146)
        Me.txtList.TabIndex = 11
        Me.txtList.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.posttestLoopUntilButton)
        Me.GroupBox1.Controls.Add(Me.forLoopButton)
        Me.GroupBox1.Controls.Add(Me.posttestLoopWhileButton)
        Me.GroupBox1.Controls.Add(Me.pretestDoUntilButton)
        Me.GroupBox1.Controls.Add(Me.pretestDoWhileButton)
        Me.GroupBox1.Controls.Add(Me.lblEven)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(251, 203)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "p347 #13 Loop 2-20"
        '
        'posttestLoopUntilButton
        '
        Me.posttestLoopUntilButton.Location = New System.Drawing.Point(117, 127)
        Me.posttestLoopUntilButton.Name = "posttestLoopUntilButton"
        Me.posttestLoopUntilButton.Size = New System.Drawing.Size(121, 29)
        Me.posttestLoopUntilButton.TabIndex = 5
        Me.posttestLoopUntilButton.Text = "Posttest: Loop Until"
        Me.posttestLoopUntilButton.UseVisualStyleBackColor = True
        '
        'forLoopButton
        '
        Me.forLoopButton.Location = New System.Drawing.Point(118, 163)
        Me.forLoopButton.Name = "forLoopButton"
        Me.forLoopButton.Size = New System.Drawing.Size(121, 29)
        Me.forLoopButton.TabIndex = 4
        Me.forLoopButton.Text = "Pretest: For"
        Me.forLoopButton.UseVisualStyleBackColor = True
        '
        'posttestLoopWhileButton
        '
        Me.posttestLoopWhileButton.Location = New System.Drawing.Point(117, 91)
        Me.posttestLoopWhileButton.Name = "posttestLoopWhileButton"
        Me.posttestLoopWhileButton.Size = New System.Drawing.Size(121, 29)
        Me.posttestLoopWhileButton.TabIndex = 3
        Me.posttestLoopWhileButton.Text = "Posttest: Loop While"
        Me.posttestLoopWhileButton.UseVisualStyleBackColor = True
        '
        'pretestDoUntilButton
        '
        Me.pretestDoUntilButton.Location = New System.Drawing.Point(117, 55)
        Me.pretestDoUntilButton.Name = "pretestDoUntilButton"
        Me.pretestDoUntilButton.Size = New System.Drawing.Size(121, 29)
        Me.pretestDoUntilButton.TabIndex = 2
        Me.pretestDoUntilButton.Text = "Pretest: Do Until"
        Me.pretestDoUntilButton.UseVisualStyleBackColor = True
        '
        'pretestDoWhileButton
        '
        Me.pretestDoWhileButton.Location = New System.Drawing.Point(118, 19)
        Me.pretestDoWhileButton.Name = "pretestDoWhileButton"
        Me.pretestDoWhileButton.Size = New System.Drawing.Size(120, 29)
        Me.pretestDoWhileButton.TabIndex = 1
        Me.pretestDoWhileButton.Text = "Pretest: Do While"
        Me.pretestDoWhileButton.UseVisualStyleBackColor = True
        '
        'lblEven
        '
        Me.lblEven.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEven.Location = New System.Drawing.Point(7, 19)
        Me.lblEven.Name = "lblEven"
        Me.lblEven.Size = New System.Drawing.Size(104, 173)
        Me.lblEven.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(533, 223)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "mswanson3a1 Loops, sum, count"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblCount As Label
    Friend WithEvents btnSumForNext As Button
    Friend WithEvents btnSumLoopUntil As Button
    Friend WithEvents btnSumDoWhile As Button
    Friend WithEvents lblAvg As Label
    Friend WithEvents txtList As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents posttestLoopUntilButton As Button
    Friend WithEvents forLoopButton As Button
    Friend WithEvents posttestLoopWhileButton As Button
    Friend WithEvents pretestDoUntilButton As Button
    Friend WithEvents pretestDoWhileButton As Button
    Friend WithEvents lblEven As Label
End Class
