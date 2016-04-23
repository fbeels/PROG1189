<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.btncreatePO = New System.Windows.Forms.Button()
        Me.btnmodPO = New System.Windows.Forms.Button()
        Me.btncalcpayroll = New System.Windows.Forms.Button()
        Me.btnAddEmp = New System.Windows.Forms.Button()
        Me.btnsearchEmp = New System.Windows.Forms.Button()
        Me.btnmodemp = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.btnviewpayroll = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(531, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(35, 20)
        Me.FileToolStripMenuItem.Text = "file"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 418)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(531, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(531, 25)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 49)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnviewpayroll)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button7)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnmodemp)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnsearchEmp)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnAddEmp)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btncalcpayroll)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnmodPO)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btncreatePO)
        Me.SplitContainer1.Size = New System.Drawing.Size(531, 369)
        Me.SplitContainer1.SplitterDistance = 177
        Me.SplitContainer1.TabIndex = 3
        '
        'btncreatePO
        '
        Me.btncreatePO.Location = New System.Drawing.Point(22, 17)
        Me.btncreatePO.Name = "btncreatePO"
        Me.btncreatePO.Size = New System.Drawing.Size(135, 23)
        Me.btncreatePO.TabIndex = 0
        Me.btncreatePO.Text = "Create Purchase Order"
        Me.btncreatePO.UseVisualStyleBackColor = True
        '
        'btnmodPO
        '
        Me.btnmodPO.Location = New System.Drawing.Point(22, 59)
        Me.btnmodPO.Name = "btnmodPO"
        Me.btnmodPO.Size = New System.Drawing.Size(135, 23)
        Me.btnmodPO.TabIndex = 1
        Me.btnmodPO.Text = "Modify Purchase Order"
        Me.btnmodPO.UseVisualStyleBackColor = True
        '
        'btncalcpayroll
        '
        Me.btncalcpayroll.Location = New System.Drawing.Point(27, 300)
        Me.btncalcpayroll.Name = "btncalcpayroll"
        Me.btncalcpayroll.Size = New System.Drawing.Size(116, 23)
        Me.btncalcpayroll.TabIndex = 2
        Me.btncalcpayroll.Text = "Calculate Payroll"
        Me.btncalcpayroll.UseVisualStyleBackColor = True
        '
        'btnAddEmp
        '
        Me.btnAddEmp.Location = New System.Drawing.Point(22, 194)
        Me.btnAddEmp.Name = "btnAddEmp"
        Me.btnAddEmp.Size = New System.Drawing.Size(111, 23)
        Me.btnAddEmp.TabIndex = 3
        Me.btnAddEmp.Text = "Add Employee"
        Me.btnAddEmp.UseVisualStyleBackColor = True
        '
        'btnsearchEmp
        '
        Me.btnsearchEmp.Location = New System.Drawing.Point(27, 223)
        Me.btnsearchEmp.Name = "btnsearchEmp"
        Me.btnsearchEmp.Size = New System.Drawing.Size(106, 23)
        Me.btnsearchEmp.TabIndex = 4
        Me.btnsearchEmp.Text = "Search Employee"
        Me.btnsearchEmp.UseVisualStyleBackColor = True
        '
        'btnmodemp
        '
        Me.btnmodemp.Location = New System.Drawing.Point(27, 252)
        Me.btnmodemp.Name = "btnmodemp"
        Me.btnmodemp.Size = New System.Drawing.Size(104, 23)
        Me.btnmodemp.TabIndex = 5
        Me.btnmodemp.Text = "Modify Employee"
        Me.btnmodemp.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(36, 88)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(75, 23)
        Me.Button7.TabIndex = 6
        Me.Button7.Text = "Button7"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'btnviewpayroll
        '
        Me.btnviewpayroll.Location = New System.Drawing.Point(22, 329)
        Me.btnviewpayroll.Name = "btnviewpayroll"
        Me.btnviewpayroll.Size = New System.Drawing.Size(75, 23)
        Me.btnviewpayroll.TabIndex = 7
        Me.btnviewpayroll.Text = "view Payroll"
        Me.btnviewpayroll.UseVisualStyleBackColor = True
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(531, 440)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "main"
        Me.Text = "main"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents btnviewpayroll As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents btnmodemp As System.Windows.Forms.Button
    Friend WithEvents btnsearchEmp As System.Windows.Forms.Button
    Friend WithEvents btnAddEmp As System.Windows.Forms.Button
    Friend WithEvents btncalcpayroll As System.Windows.Forms.Button
    Friend WithEvents btnmodPO As System.Windows.Forms.Button
    Friend WithEvents btncreatePO As System.Windows.Forms.Button
End Class
