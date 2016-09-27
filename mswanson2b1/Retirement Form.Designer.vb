<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRetirement
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
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.lblTotalContrib = New System.Windows.Forms.Label()
        Me.lblEmployerContrib = New System.Windows.Forms.Label()
        Me.lblEmployeeContrib = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtEmployerRate = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtEmployeeRate = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtGrossPay = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(299, 258)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(133, 52)
        Me.btnExit.TabIndex = 21
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(159, 258)
        Me.btnCalc.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(133, 52)
        Me.btnCalc.TabIndex = 20
        Me.btnCalc.Text = "&Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'lblTotalContrib
        '
        Me.lblTotalContrib.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblTotalContrib.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalContrib.Location = New System.Drawing.Point(300, 210)
        Me.lblTotalContrib.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblTotalContrib.Name = "lblTotalContrib"
        Me.lblTotalContrib.Size = New System.Drawing.Size(132, 33)
        Me.lblTotalContrib.TabIndex = 27
        Me.lblTotalContrib.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblEmployerContrib
        '
        Me.lblEmployerContrib.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEmployerContrib.Location = New System.Drawing.Point(300, 171)
        Me.lblEmployerContrib.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblEmployerContrib.Name = "lblEmployerContrib"
        Me.lblEmployerContrib.Size = New System.Drawing.Size(132, 33)
        Me.lblEmployerContrib.TabIndex = 26
        Me.lblEmployerContrib.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblEmployeeContrib
        '
        Me.lblEmployeeContrib.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEmployeeContrib.Location = New System.Drawing.Point(300, 132)
        Me.lblEmployeeContrib.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblEmployeeContrib.Name = "lblEmployeeContrib"
        Me.lblEmployeeContrib.Size = New System.Drawing.Size(132, 33)
        Me.lblEmployeeContrib.TabIndex = 25
        Me.lblEmployeeContrib.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(34, 216)
        Me.Label6.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(178, 20)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Total annual contribution:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(34, 177)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(208, 20)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Employer annual contribution:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(34, 138)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(211, 20)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Employee annual contribution:"
        '
        'txtEmployerRate
        '
        Me.txtEmployerRate.Location = New System.Drawing.Point(369, 92)
        Me.txtEmployerRate.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txtEmployerRate.Name = "txtEmployerRate"
        Me.txtEmployerRate.Size = New System.Drawing.Size(63, 27)
        Me.txtEmployerRate.TabIndex = 19
        Me.txtEmployerRate.Text = "0.07"
        Me.txtEmployerRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(34, 95)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(293, 20)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Employe&r contribution rate (decimal form):"
        '
        'txtEmployeeRate
        '
        Me.txtEmployeeRate.Location = New System.Drawing.Point(369, 55)
        Me.txtEmployeeRate.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txtEmployeeRate.Name = "txtEmployeeRate"
        Me.txtEmployeeRate.Size = New System.Drawing.Size(63, 27)
        Me.txtEmployeeRate.TabIndex = 17
        Me.txtEmployeeRate.Text = "0.05"
        Me.txtEmployeeRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 58)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(296, 20)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "&Employee contribution rate (decimal form):"
        '
        'txtGrossPay
        '
        Me.txtGrossPay.Location = New System.Drawing.Point(300, 18)
        Me.txtGrossPay.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txtGrossPay.Name = "txtGrossPay"
        Me.txtGrossPay.Size = New System.Drawing.Size(132, 27)
        Me.txtGrossPay.TabIndex = 15
        Me.txtGrossPay.Text = "1000"
        Me.txtGrossPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 21)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 20)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "&Gross weekly pay:"
        '
        'frmRetirement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(469, 331)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.lblTotalContrib)
        Me.Controls.Add(Me.lblEmployerContrib)
        Me.Controls.Add(Me.lblEmployeeContrib)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtEmployerRate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtEmployeeRate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtGrossPay)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Name = "frmRetirement"
        Me.Text = "mswanson2b2 Retirement"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents btnCalc As Button
    Friend WithEvents lblTotalContrib As Label
    Friend WithEvents lblEmployerContrib As Label
    Friend WithEvents lblEmployeeContrib As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtEmployerRate As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtEmployeeRate As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtGrossPay As TextBox
    Friend WithEvents Label1 As Label
End Class
