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
        Me.lblRangeCount = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboSearchRanges = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblValueCount = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboSearchValues = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblCommissions = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblRangeCount
        '
        Me.lblRangeCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRangeCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRangeCount.Location = New System.Drawing.Point(289, 226)
        Me.lblRangeCount.Name = "lblRangeCount"
        Me.lblRangeCount.Size = New System.Drawing.Size(75, 23)
        Me.lblRangeCount.TabIndex = 19
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(245, 226)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Count:"
        '
        'cboSearchRanges
        '
        Me.cboSearchRanges.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cboSearchRanges.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSearchRanges.FormattingEnabled = True
        Me.cboSearchRanges.Items.AddRange(New Object() {"    0 - 200", "100 - 300", "700 - 800"})
        Me.cboSearchRanges.Location = New System.Drawing.Point(121, 226)
        Me.cboSearchRanges.Name = "cboSearchRanges"
        Me.cboSearchRanges.Size = New System.Drawing.Size(99, 114)
        Me.cboSearchRanges.TabIndex = 17
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 226)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Search for range:"
        '
        'lblValueCount
        '
        Me.lblValueCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblValueCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValueCount.Location = New System.Drawing.Point(289, 107)
        Me.lblValueCount.Name = "lblValueCount"
        Me.lblValueCount.Size = New System.Drawing.Size(75, 23)
        Me.lblValueCount.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(245, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Count:"
        '
        'cboSearchValues
        '
        Me.cboSearchValues.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cboSearchValues.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSearchValues.FormattingEnabled = True
        Me.cboSearchValues.Items.AddRange(New Object() {"50", "100", "300", "900"})
        Me.cboSearchValues.Location = New System.Drawing.Point(121, 107)
        Me.cboSearchValues.Name = "cboSearchValues"
        Me.cboSearchValues.Size = New System.Drawing.Size(99, 116)
        Me.cboSearchValues.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Search for value:"
        '
        'lblCommissions
        '
        Me.lblCommissions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCommissions.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCommissions.Location = New System.Drawing.Point(121, 15)
        Me.lblCommissions.Name = "lblCommissions"
        Me.lblCommissions.Size = New System.Drawing.Size(243, 75)
        Me.lblCommissions.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Commission values:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 342)
        Me.Controls.Add(Me.lblRangeCount)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cboSearchRanges)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblValueCount)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cboSearchValues)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblCommissions)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "mswanson3e1 Arrays, Functions"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblRangeCount As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cboSearchRanges As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lblValueCount As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cboSearchValues As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblCommissions As Label
    Friend WithEvents Label1 As Label
End Class
