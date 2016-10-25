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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblAdditional = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblCommissionOnly = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnCalcSelectCase = New System.Windows.Forms.Button()
        Me.btnCalc_IfElseIf = New System.Windows.Forms.Button()
        Me.btnCalc_NestedIf = New System.Windows.Forms.Button()
        Me.btnCalc_IfThen = New System.Windows.Forms.Button()
        Me.chkTravel = New System.Windows.Forms.CheckBox()
        Me.chkMoreThan10 = New System.Windows.Forms.CheckBox()
        Me.lblTotalCommisssion = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSales = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Location = New System.Drawing.Point(238, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(294, 188)
        Me.GroupBox1.TabIndex = 31
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Commission calculations"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(122, 160)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(31, 13)
        Me.Label19.TabIndex = 12
        Me.Label19.Text = "$700"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(17, 160)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(53, 13)
        Me.Label18.TabIndex = 11
        Me.Label18.Text = "Travelling"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(122, 144)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(31, 13)
        Me.Label17.TabIndex = 10
        Me.Label17.Text = "$500"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(17, 141)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(56, 13)
        Me.Label16.TabIndex = 9
        Me.Label16.Text = "> 10 years"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(17, 122)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(99, 13)
        Me.Label15.TabIndex = 8
        Me.Label15.Text = "Additional amounts:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(122, 87)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(156, 13)
        Me.Label14.TabIndex = 7
        Me.Label14.Text = "$3,120 + 14% of sales > 30,000"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(122, 67)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(141, 13)
        Me.Label13.TabIndex = 6
        Me.Label13.Text = "$120 + 13% of sales > 6,000"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(122, 47)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(66, 13)
        Me.Label12.TabIndex = 5
        Me.Label12.Text = "10% of sales"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label11.Location = New System.Drawing.Point(125, 25)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(154, 15)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Commission                              "
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(17, 87)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 13)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "> 30,000"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(17, 67)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(91, 13)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "6,000 - 29,999.99"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(17, 47)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "1 - 5,999.99"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Location = New System.Drawing.Point(17, 25)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 15)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Sales ($)              "
        '
        'lblAdditional
        '
        Me.lblAdditional.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAdditional.Location = New System.Drawing.Point(15, 163)
        Me.lblAdditional.Name = "lblAdditional"
        Me.lblAdditional.Size = New System.Drawing.Size(100, 23)
        Me.lblAdditional.TabIndex = 28
        Me.lblAdditional.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 146)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 13)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Additional amount:"
        '
        'lblCommissionOnly
        '
        Me.lblCommissionOnly.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCommissionOnly.Location = New System.Drawing.Point(15, 116)
        Me.lblCommissionOnly.Name = "lblCommissionOnly"
        Me.lblCommissionOnly.Size = New System.Drawing.Size(100, 23)
        Me.lblCommissionOnly.TabIndex = 26
        Me.lblCommissionOnly.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 13)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Commission only:"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(134, 146)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(88, 23)
        Me.btnExit.TabIndex = 24
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnCalcSelectCase
        '
        Me.btnCalcSelectCase.Location = New System.Drawing.Point(134, 116)
        Me.btnCalcSelectCase.Name = "btnCalcSelectCase"
        Me.btnCalcSelectCase.Size = New System.Drawing.Size(88, 23)
        Me.btnCalcSelectCase.TabIndex = 21
        Me.btnCalcSelectCase.Text = "Select Case"
        Me.btnCalcSelectCase.UseVisualStyleBackColor = True
        '
        'btnCalc_IfElseIf
        '
        Me.btnCalc_IfElseIf.Location = New System.Drawing.Point(134, 86)
        Me.btnCalc_IfElseIf.Name = "btnCalc_IfElseIf"
        Me.btnCalc_IfElseIf.Size = New System.Drawing.Size(88, 23)
        Me.btnCalc_IfElseIf.TabIndex = 20
        Me.btnCalc_IfElseIf.Text = "If ElseIf"
        Me.btnCalc_IfElseIf.UseVisualStyleBackColor = True
        '
        'btnCalc_NestedIf
        '
        Me.btnCalc_NestedIf.Location = New System.Drawing.Point(134, 55)
        Me.btnCalc_NestedIf.Name = "btnCalc_NestedIf"
        Me.btnCalc_NestedIf.Size = New System.Drawing.Size(88, 23)
        Me.btnCalc_NestedIf.TabIndex = 19
        Me.btnCalc_NestedIf.Text = "Nested If"
        Me.btnCalc_NestedIf.UseVisualStyleBackColor = True
        '
        'btnCalc_IfThen
        '
        Me.btnCalc_IfThen.Location = New System.Drawing.Point(134, 24)
        Me.btnCalc_IfThen.Name = "btnCalc_IfThen"
        Me.btnCalc_IfThen.Size = New System.Drawing.Size(88, 23)
        Me.btnCalc_IfThen.TabIndex = 18
        Me.btnCalc_IfThen.Text = "If Then"
        Me.btnCalc_IfThen.UseVisualStyleBackColor = True
        '
        'chkTravel
        '
        Me.chkTravel.AutoSize = True
        Me.chkTravel.Location = New System.Drawing.Point(15, 75)
        Me.chkTravel.Name = "chkTravel"
        Me.chkTravel.Size = New System.Drawing.Size(72, 17)
        Me.chkTravel.TabIndex = 23
        Me.chkTravel.Text = "Travelling"
        Me.chkTravel.UseVisualStyleBackColor = True
        '
        'chkMoreThan10
        '
        Me.chkMoreThan10.AutoSize = True
        Me.chkMoreThan10.Location = New System.Drawing.Point(15, 52)
        Me.chkMoreThan10.Name = "chkMoreThan10"
        Me.chkMoreThan10.Size = New System.Drawing.Size(77, 17)
        Me.chkMoreThan10.TabIndex = 22
        Me.chkMoreThan10.Text = "> 10 Years"
        Me.chkMoreThan10.UseVisualStyleBackColor = True
        '
        'lblTotalCommisssion
        '
        Me.lblTotalCommisssion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalCommisssion.Location = New System.Drawing.Point(15, 212)
        Me.lblTotalCommisssion.Name = "lblTotalCommisssion"
        Me.lblTotalCommisssion.Size = New System.Drawing.Size(100, 23)
        Me.lblTotalCommisssion.TabIndex = 30
        Me.lblTotalCommisssion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 195)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 13)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Total commission:"
        '
        'txtSales
        '
        Me.txtSales.Location = New System.Drawing.Point(15, 26)
        Me.txtSales.Name = "txtSales"
        Me.txtSales.Size = New System.Drawing.Size(100, 20)
        Me.txtSales.TabIndex = 17
        Me.txtSales.Text = "a100000"
        Me.txtSales.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Sales:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(549, 247)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblAdditional)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblCommissionOnly)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalcSelectCase)
        Me.Controls.Add(Me.btnCalc_IfElseIf)
        Me.Controls.Add(Me.btnCalc_NestedIf)
        Me.Controls.Add(Me.btnCalc_IfThen)
        Me.Controls.Add(Me.chkTravel)
        Me.Controls.Add(Me.chkMoreThan10)
        Me.Controls.Add(Me.lblTotalCommisssion)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtSales)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "mswanson2h1 Marshall Sales Commission"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblAdditional As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblCommissionOnly As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents btnCalcSelectCase As Button
    Friend WithEvents btnCalc_IfElseIf As Button
    Friend WithEvents btnCalc_NestedIf As Button
    Friend WithEvents btnCalc_IfThen As Button
    Friend WithEvents chkTravel As CheckBox
    Friend WithEvents chkMoreThan10 As CheckBox
    Friend WithEvents lblTotalCommisssion As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSales As TextBox
    Friend WithEvents Label1 As Label
End Class
