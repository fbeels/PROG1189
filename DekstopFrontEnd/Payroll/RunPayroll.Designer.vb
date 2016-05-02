<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RunPayroll
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtpasscode = New System.Windows.Forms.TextBox()
        Me.btnrunpayroll = New System.Windows.Forms.Button()
        Me.lblmsg = New System.Windows.Forms.Label()
        Me.lblResults = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PassCode:"
        '
        'txtpasscode
        '
        Me.txtpasscode.Location = New System.Drawing.Point(140, 79)
        Me.txtpasscode.Name = "txtpasscode"
        Me.txtpasscode.Size = New System.Drawing.Size(265, 26)
        Me.txtpasscode.TabIndex = 1
        '
        'btnrunpayroll
        '
        Me.btnrunpayroll.Location = New System.Drawing.Point(55, 141)
        Me.btnrunpayroll.Name = "btnrunpayroll"
        Me.btnrunpayroll.Size = New System.Drawing.Size(285, 84)
        Me.btnrunpayroll.TabIndex = 2
        Me.btnrunpayroll.Text = "Run"
        Me.btnrunpayroll.UseVisualStyleBackColor = True
        '
        'lblmsg
        '
        Me.lblmsg.AutoSize = True
        Me.lblmsg.Location = New System.Drawing.Point(51, 27)
        Me.lblmsg.Name = "lblmsg"
        Me.lblmsg.Size = New System.Drawing.Size(342, 20)
        Me.lblmsg.TabIndex = 3
        Me.lblmsg.Text = "It's PAYDAY,enter your passcode to run payroll"
        '
        'lblResults
        '
        Me.lblResults.AutoSize = True
        Me.lblResults.Location = New System.Drawing.Point(48, 236)
        Me.lblResults.Name = "lblResults"
        Me.lblResults.Size = New System.Drawing.Size(0, 20)
        Me.lblResults.TabIndex = 4
        '
        'RunPayroll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(438, 291)
        Me.Controls.Add(Me.lblResults)
        Me.Controls.Add(Me.lblmsg)
        Me.Controls.Add(Me.btnrunpayroll)
        Me.Controls.Add(Me.txtpasscode)
        Me.Controls.Add(Me.Label1)
        Me.Name = "RunPayroll"
        Me.Text = "RunPayroll"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtpasscode As System.Windows.Forms.TextBox
    Friend WithEvents btnrunpayroll As System.Windows.Forms.Button
    Friend WithEvents lblmsg As System.Windows.Forms.Label
    Friend WithEvents lblResults As System.Windows.Forms.Label
End Class
