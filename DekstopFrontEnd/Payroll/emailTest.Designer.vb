<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class emailTest
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
        Me.lsttosend = New System.Windows.Forms.ListBox()
        Me.btnsend = New System.Windows.Forms.Button()
        Me.lstsent = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lsttosend
        '
        Me.lsttosend.FormattingEnabled = True
        Me.lsttosend.ItemHeight = 20
        Me.lsttosend.Location = New System.Drawing.Point(204, 96)
        Me.lsttosend.Name = "lsttosend"
        Me.lsttosend.Size = New System.Drawing.Size(120, 84)
        Me.lsttosend.TabIndex = 0
        '
        'btnsend
        '
        Me.btnsend.Location = New System.Drawing.Point(294, 266)
        Me.btnsend.Name = "btnsend"
        Me.btnsend.Size = New System.Drawing.Size(368, 74)
        Me.btnsend.TabIndex = 1
        Me.btnsend.Text = "Button1"
        Me.btnsend.UseVisualStyleBackColor = True
        '
        'lstsent
        '
        Me.lstsent.FormattingEnabled = True
        Me.lstsent.ItemHeight = 20
        Me.lstsent.Location = New System.Drawing.Point(500, 94)
        Me.lstsent.Name = "lstsent"
        Me.lstsent.Size = New System.Drawing.Size(202, 104)
        Me.lstsent.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(212, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(508, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Label2"
        '
        'emailTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1026, 559)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstsent)
        Me.Controls.Add(Me.btnsend)
        Me.Controls.Add(Me.lsttosend)
        Me.Name = "emailTest"
        Me.Text = "emailTest"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lsttosend As System.Windows.Forms.ListBox
    Friend WithEvents btnsend As System.Windows.Forms.Button
    Friend WithEvents lstsent As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
