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
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.btnviewpayroll = New System.Windows.Forms.Button()
        Me.btnmodemp = New System.Windows.Forms.Button()
        Me.btnsearchEmp = New System.Windows.Forms.Button()
        Me.btnAddEmp = New System.Windows.Forms.Button()
        Me.btncalcpayroll = New System.Windows.Forms.Button()
        Me.btnmodPO = New System.Windows.Forms.Button()
        Me.btncreatePO = New System.Windows.Forms.Button()
        Me.TabControl1 = New MdiTabControl.TabControl()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(9, 3, 0, 3)
        Me.MenuStrip1.Size = New System.Drawing.Size(1506, 35)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(47, 29)
        Me.FileToolStripMenuItem.Text = "file"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(147, 30)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 845)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(2, 0, 21, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(1506, 30)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(184, 25)
        Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 35)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.ToolStrip1.Size = New System.Drawing.Size(1506, 25)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 60)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.SystemColors.Info
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnviewpayroll)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnmodemp)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnsearchEmp)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnAddEmp)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btncalcpayroll)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnmodPO)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btncreatePO)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ControlDark
        Me.SplitContainer1.Panel2.Controls.Add(Me.TabControl1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1506, 785)
        Me.SplitContainer1.SplitterDistance = 270
        Me.SplitContainer1.SplitterWidth = 6
        Me.SplitContainer1.TabIndex = 3
        '
        'btnviewpayroll
        '
        Me.btnviewpayroll.Enabled = False
        Me.btnviewpayroll.Location = New System.Drawing.Point(40, 507)
        Me.btnviewpayroll.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnviewpayroll.Name = "btnviewpayroll"
        Me.btnviewpayroll.Size = New System.Drawing.Size(156, 35)
        Me.btnviewpayroll.TabIndex = 7
        Me.btnviewpayroll.Text = "view Payroll"
        Me.btnviewpayroll.UseVisualStyleBackColor = True
        '
        'btnmodemp
        '
        Me.btnmodemp.Enabled = False
        Me.btnmodemp.Location = New System.Drawing.Point(40, 388)
        Me.btnmodemp.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnmodemp.Name = "btnmodemp"
        Me.btnmodemp.Size = New System.Drawing.Size(156, 35)
        Me.btnmodemp.TabIndex = 5
        Me.btnmodemp.Text = "Modify Employee"
        Me.btnmodemp.UseVisualStyleBackColor = True
        '
        'btnsearchEmp
        '
        Me.btnsearchEmp.Location = New System.Drawing.Point(40, 343)
        Me.btnsearchEmp.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnsearchEmp.Name = "btnsearchEmp"
        Me.btnsearchEmp.Size = New System.Drawing.Size(159, 35)
        Me.btnsearchEmp.TabIndex = 4
        Me.btnsearchEmp.Text = "Search Employee"
        Me.btnsearchEmp.UseVisualStyleBackColor = True
        '
        'btnAddEmp
        '
        Me.btnAddEmp.Location = New System.Drawing.Point(33, 298)
        Me.btnAddEmp.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnAddEmp.Name = "btnAddEmp"
        Me.btnAddEmp.Size = New System.Drawing.Size(166, 35)
        Me.btnAddEmp.TabIndex = 3
        Me.btnAddEmp.Text = "Add Employee"
        Me.btnAddEmp.UseVisualStyleBackColor = True
        '
        'btncalcpayroll
        '
        Me.btncalcpayroll.Location = New System.Drawing.Point(40, 462)
        Me.btncalcpayroll.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btncalcpayroll.Name = "btncalcpayroll"
        Me.btncalcpayroll.Size = New System.Drawing.Size(159, 35)
        Me.btncalcpayroll.TabIndex = 2
        Me.btncalcpayroll.Text = "Calculate Payroll"
        Me.btncalcpayroll.UseVisualStyleBackColor = True
        '
        'btnmodPO
        '
        Me.btnmodPO.Location = New System.Drawing.Point(33, 91)
        Me.btnmodPO.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnmodPO.Name = "btnmodPO"
        Me.btnmodPO.Size = New System.Drawing.Size(202, 35)
        Me.btnmodPO.TabIndex = 1
        Me.btnmodPO.Text = "Modify Purchase Order"
        Me.btnmodPO.UseVisualStyleBackColor = True
        '
        'btncreatePO
        '
        Me.btncreatePO.Location = New System.Drawing.Point(33, 26)
        Me.btncreatePO.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btncreatePO.Name = "btncreatePO"
        Me.btncreatePO.Size = New System.Drawing.Size(202, 35)
        Me.btncreatePO.TabIndex = 0
        Me.btncreatePO.Text = "Create Purchase Order"
        Me.btncreatePO.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Location = New System.Drawing.Point(3, 3)
        Me.TabControl1.MenuRenderer = Nothing
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.Size = New System.Drawing.Size(1224, 790)
        Me.TabControl1.TabCloseButtonImage = Nothing
        Me.TabControl1.TabCloseButtonImageDisabled = Nothing
        Me.TabControl1.TabCloseButtonImageHot = Nothing
        Me.TabControl1.TabIndex = 0
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1506, 875)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "main"
        Me.Text = "main"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
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
    Friend WithEvents btnmodemp As System.Windows.Forms.Button
    Friend WithEvents btnsearchEmp As System.Windows.Forms.Button
    Friend WithEvents btnAddEmp As System.Windows.Forms.Button
    Friend WithEvents btncalcpayroll As System.Windows.Forms.Button
    Friend WithEvents btnmodPO As System.Windows.Forms.Button
    Friend WithEvents btncreatePO As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As MdiTabControl.TabControl
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
