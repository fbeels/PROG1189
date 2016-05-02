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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(main))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.grbHR = New System.Windows.Forms.GroupBox()
        Me.btnviewpayroll = New System.Windows.Forms.Button()
        Me.btnmodemp = New System.Windows.Forms.Button()
        Me.btnsearchEmp = New System.Windows.Forms.Button()
        Me.btnAddEmp = New System.Windows.Forms.Button()
        Me.btncalcpayroll = New System.Windows.Forms.Button()
        Me.btnmodPO = New System.Windows.Forms.Button()
        Me.btncreatePO = New System.Windows.Forms.Button()
        Me.TabControl1 = New MdiTabControl.TabControl()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.HumanResourcesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProcurementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.grbHR.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HumanResourcesToolStripMenuItem, Me.ProcurementToolStripMenuItem, Me.AboutToolStripMenuItem1})
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
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(211, 30)
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
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripLabel1, Me.ToolStripLabel2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 35)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.ToolStrip1.Size = New System.Drawing.Size(1506, 31)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 66)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.SystemColors.Info
        Me.SplitContainer1.Panel1.Controls.Add(Me.grbHR)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnmodPO)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btncreatePO)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ControlDark
        Me.SplitContainer1.Panel2.Controls.Add(Me.TabControl1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1506, 779)
        Me.SplitContainer1.SplitterDistance = 270
        Me.SplitContainer1.SplitterWidth = 6
        Me.SplitContainer1.TabIndex = 3
        '
        'grbHR
        '
        Me.grbHR.Controls.Add(Me.btnviewpayroll)
        Me.grbHR.Controls.Add(Me.btnmodemp)
        Me.grbHR.Controls.Add(Me.btnsearchEmp)
        Me.grbHR.Controls.Add(Me.btnAddEmp)
        Me.grbHR.Controls.Add(Me.btncalcpayroll)
        Me.grbHR.Location = New System.Drawing.Point(22, 472)
        Me.grbHR.Name = "grbHR"
        Me.grbHR.Size = New System.Drawing.Size(224, 310)
        Me.grbHR.TabIndex = 8
        Me.grbHR.TabStop = False
        Me.grbHR.Text = "Human Resources"
        '
        'btnviewpayroll
        '
        Me.btnviewpayroll.Enabled = False
        Me.btnviewpayroll.Location = New System.Drawing.Point(30, 249)
        Me.btnviewpayroll.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnviewpayroll.Name = "btnviewpayroll"
        Me.btnviewpayroll.Size = New System.Drawing.Size(156, 35)
        Me.btnviewpayroll.TabIndex = 12
        Me.btnviewpayroll.Text = "view Payroll"
        Me.btnviewpayroll.UseVisualStyleBackColor = True
        '
        'btnmodemp
        '
        Me.btnmodemp.Enabled = False
        Me.btnmodemp.Location = New System.Drawing.Point(30, 130)
        Me.btnmodemp.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnmodemp.Name = "btnmodemp"
        Me.btnmodemp.Size = New System.Drawing.Size(156, 35)
        Me.btnmodemp.TabIndex = 11
        Me.btnmodemp.Text = "Modify Employee"
        Me.btnmodemp.UseVisualStyleBackColor = True
        '
        'btnsearchEmp
        '
        Me.btnsearchEmp.Location = New System.Drawing.Point(30, 85)
        Me.btnsearchEmp.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnsearchEmp.Name = "btnsearchEmp"
        Me.btnsearchEmp.Size = New System.Drawing.Size(159, 35)
        Me.btnsearchEmp.TabIndex = 10
        Me.btnsearchEmp.Text = "Search Employee"
        Me.btnsearchEmp.UseVisualStyleBackColor = True
        '
        'btnAddEmp
        '
        Me.btnAddEmp.Location = New System.Drawing.Point(23, 40)
        Me.btnAddEmp.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnAddEmp.Name = "btnAddEmp"
        Me.btnAddEmp.Size = New System.Drawing.Size(166, 35)
        Me.btnAddEmp.TabIndex = 9
        Me.btnAddEmp.Text = "Add Employee"
        Me.btnAddEmp.UseVisualStyleBackColor = True
        '
        'btncalcpayroll
        '
        Me.btncalcpayroll.Location = New System.Drawing.Point(30, 204)
        Me.btncalcpayroll.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btncalcpayroll.Name = "btncalcpayroll"
        Me.btncalcpayroll.Size = New System.Drawing.Size(159, 35)
        Me.btncalcpayroll.TabIndex = 8
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
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(28, 28)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(135, 28)
        Me.ToolStripLabel1.Text = "ToolStripLabel1"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(135, 28)
        Me.ToolStripLabel2.Text = "ToolStripLabel2"
        '
        'HumanResourcesToolStripMenuItem
        '
        Me.HumanResourcesToolStripMenuItem.Name = "HumanResourcesToolStripMenuItem"
        Me.HumanResourcesToolStripMenuItem.Size = New System.Drawing.Size(167, 29)
        Me.HumanResourcesToolStripMenuItem.Text = "Human Resources"
        '
        'ProcurementToolStripMenuItem
        '
        Me.ProcurementToolStripMenuItem.Name = "ProcurementToolStripMenuItem"
        Me.ProcurementToolStripMenuItem.Size = New System.Drawing.Size(125, 29)
        Me.ProcurementToolStripMenuItem.Text = "Procurement"
        '
        'AboutToolStripMenuItem1
        '
        Me.AboutToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem2})
        Me.AboutToolStripMenuItem1.Name = "AboutToolStripMenuItem1"
        Me.AboutToolStripMenuItem1.Size = New System.Drawing.Size(74, 29)
        Me.AboutToolStripMenuItem1.Text = "About"
        '
        'AboutToolStripMenuItem2
        '
        Me.AboutToolStripMenuItem2.Name = "AboutToolStripMenuItem2"
        Me.AboutToolStripMenuItem2.Size = New System.Drawing.Size(211, 30)
        Me.AboutToolStripMenuItem2.Text = "About"
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
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.grbHR.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents btnmodPO As System.Windows.Forms.Button
    Friend WithEvents btncreatePO As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As MdiTabControl.TabControl
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents grbHR As System.Windows.Forms.GroupBox
    Friend WithEvents btnviewpayroll As System.Windows.Forms.Button
    Friend WithEvents btnmodemp As System.Windows.Forms.Button
    Friend WithEvents btnsearchEmp As System.Windows.Forms.Button
    Friend WithEvents btnAddEmp As System.Windows.Forms.Button
    Friend WithEvents btncalcpayroll As System.Windows.Forms.Button
    Friend WithEvents HumanResourcesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProcurementToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
End Class
