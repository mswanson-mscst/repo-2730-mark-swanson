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
        Me.txtCard = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCalc14And = New System.Windows.Forms.Button()
        Me.txtOrder = New System.Windows.Forms.TextBox()
        Me.lblShipping = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnCalc14Or = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnCalc17ne = New System.Windows.Forms.Button()
        Me.lblCommission = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnCalc17eq = New System.Windows.Forms.Button()
        Me.txtSales = New System.Windows.Forms.TextBox()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtCard
        '
        Me.txtCard.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCard.Location = New System.Drawing.Point(110, 48)
        Me.txtCard.Name = "txtCard"
        Me.txtCard.Size = New System.Drawing.Size(34, 24)
        Me.txtCard.TabIndex = 11
        Me.txtCard.Text = "Y"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(107, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "&Savannah (Y/N):"
        '
        'btnCalc14And
        '
        Me.btnCalc14And.Location = New System.Drawing.Point(320, 21)
        Me.btnCalc14And.Name = "btnCalc14And"
        Me.btnCalc14And.Size = New System.Drawing.Size(107, 29)
        Me.btnCalc14And.TabIndex = 12
        Me.btnCalc14And.Text = "Calculate (And)"
        Me.btnCalc14And.UseVisualStyleBackColor = True
        '
        'txtOrder
        '
        Me.txtOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrder.Location = New System.Drawing.Point(17, 48)
        Me.txtOrder.Name = "txtOrder"
        Me.txtOrder.Size = New System.Drawing.Size(85, 24)
        Me.txtOrder.TabIndex = 9
        Me.txtOrder.Text = "100"
        '
        'lblShipping
        '
        Me.lblShipping.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblShipping.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShipping.Location = New System.Drawing.Point(211, 47)
        Me.lblShipping.Name = "lblShipping"
        Me.lblShipping.Size = New System.Drawing.Size(84, 27)
        Me.lblShipping.TabIndex = 14
        Me.lblShipping.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(208, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Shipping charge:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "&Order amount:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnCalc14Or)
        Me.GroupBox1.Controls.Add(Me.txtOrder)
        Me.GroupBox1.Controls.Add(Me.btnCalc14And)
        Me.GroupBox1.Controls.Add(Me.txtCard)
        Me.GroupBox1.Controls.Add(Me.lblShipping)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(457, 100)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Free shipping for orders over $100 with Savannah CC"
        '
        'btnCalc14Or
        '
        Me.btnCalc14Or.Location = New System.Drawing.Point(320, 56)
        Me.btnCalc14Or.Name = "btnCalc14Or"
        Me.btnCalc14Or.Size = New System.Drawing.Size(107, 29)
        Me.btnCalc14Or.TabIndex = 15
        Me.btnCalc14Or.Text = "Calculate (Or)"
        Me.btnCalc14Or.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnCalc17ne)
        Me.GroupBox2.Controls.Add(Me.lblCommission)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.btnCalc17eq)
        Me.GroupBox2.Controls.Add(Me.txtSales)
        Me.GroupBox2.Controls.Add(Me.txtId)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 118)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(457, 101)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "15% commission for sales > 25000 with codes A1, B2, C3"
        '
        'btnCalc17ne
        '
        Me.btnCalc17ne.Location = New System.Drawing.Point(329, 56)
        Me.btnCalc17ne.Name = "btnCalc17ne"
        Me.btnCalc17ne.Size = New System.Drawing.Size(88, 29)
        Me.btnCalc17ne.TabIndex = 12
        Me.btnCalc17ne.Text = "Calculate (<>)"
        Me.btnCalc17ne.UseVisualStyleBackColor = True
        '
        'lblCommission
        '
        Me.lblCommission.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCommission.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCommission.Location = New System.Drawing.Point(211, 38)
        Me.lblCommission.Name = "lblCommission"
        Me.lblCommission.Size = New System.Drawing.Size(84, 27)
        Me.lblCommission.TabIndex = 11
        Me.lblCommission.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(208, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Commission:"
        '
        'btnCalc17eq
        '
        Me.btnCalc17eq.Location = New System.Drawing.Point(329, 21)
        Me.btnCalc17eq.Name = "btnCalc17eq"
        Me.btnCalc17eq.Size = New System.Drawing.Size(88, 29)
        Me.btnCalc17eq.TabIndex = 9
        Me.btnCalc17eq.Text = "Calculate (=)"
        Me.btnCalc17eq.UseVisualStyleBackColor = True
        '
        'txtSales
        '
        Me.txtSales.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSales.Location = New System.Drawing.Point(62, 42)
        Me.txtSales.Name = "txtSales"
        Me.txtSales.Size = New System.Drawing.Size(106, 24)
        Me.txtSales.TabIndex = 8
        Me.txtSales.Text = "100000"
        '
        'txtId
        '
        Me.txtId.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtId.Location = New System.Drawing.Point(17, 42)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(39, 24)
        Me.txtId.TabIndex = 6
        Me.txtId.Text = "A1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(66, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "&Sales:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 27)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(21, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "&ID:"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(212, 225)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 17
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 260)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "mswanson2e1 AndAlso, OrElse"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtCard As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnCalc14And As Button
    Friend WithEvents txtOrder As TextBox
    Friend WithEvents lblShipping As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnCalc14Or As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnCalc17eq As Button
    Friend WithEvents txtSales As TextBox
    Friend WithEvents txtId As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblCommission As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents btnCalc17ne As Button
End Class
