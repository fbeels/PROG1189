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
        Me.AboutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.lblloggedinuserid = New System.Windows.Forms.Label()
        Me.lbluser = New System.Windows.Forms.Label()
        Me.cboUser = New System.Windows.Forms.ComboBox()
        Me.grbHR = New System.Windows.Forms.GroupBox()
        Me.btnsearchpaystubs = New System.Windows.Forms.Button()
        Me.btnviewpayroll = New System.Windows.Forms.Button()
        Me.btnmodemp = New System.Windows.Forms.Button()
        Me.btnsearchEmp = New System.Windows.Forms.Button()
        Me.btnAddEmp = New System.Windows.Forms.Button()
        Me.btnmodPO = New System.Windows.Forms.Button()
        Me.btncreatePO = New System.Windows.Forms.Button()
        Me.TabControl1 = New MdiTabControl.TabControl()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.grbHR.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1385, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AboutToolStripMenuItem1
        '
        Me.AboutToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem2})
        Me.AboutToolStripMenuItem1.Name = "AboutToolStripMenuItem1"
        Me.AboutToolStripMenuItem1.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem1.Text = "About"
        '
        'AboutToolStripMenuItem2
        '
        Me.AboutToolStripMenuItem2.Name = "AboutToolStripMenuItem2"
        Me.AboutToolStripMenuItem2.Size = New System.Drawing.Size(152, 22)
        Me.AboutToolStripMenuItem2.Text = "About"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 662)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1385, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(120, 17)
        Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ToolStripLabel2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1385, 25)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(88, 22)
        Me.ToolStripLabel1.Text = "Purchase Order"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(84, 22)
        Me.ToolStripLabel2.Text = "Add Employee"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 49)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.SystemColors.Info
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblloggedinuserid)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lbluser)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cboUser)
        Me.SplitContainer1.Panel1.Controls.Add(Me.grbHR)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ControlDark
        Me.SplitContainer1.Panel2.Controls.Add(Me.TabControl1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1385, 613)
        Me.SplitContainer1.SplitterDistance = 247
        Me.SplitContainer1.TabIndex = 3
        '
        'lblloggedinuserid
        '
        Me.lblloggedinuserid.AutoSize = True
        Me.lblloggedinuserid.Location = New System.Drawing.Point(103, 19)
        Me.lblloggedinuserid.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblloggedinuserid.Name = "lblloggedinuserid"
        Me.lblloggedinuserid.Size = New System.Drawing.Size(33, 13)
        Me.lblloggedinuserid.TabIndex = 11
        Me.lblloggedinuserid.Text = "None"
        '
        'lbluser
        '
        Me.lbluser.AutoSize = True
        Me.lbluser.Location = New System.Drawing.Point(2, 19)
        Me.lbluser.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbluser.Name = "lbluser"
        Me.lbluser.Size = New System.Drawing.Size(82, 13)
        Me.lbluser.TabIndex = 10
        Me.lbluser.Text = "Logged in User:"
        '
        'cboUser
        '
        Me.cboUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboUser.FormattingEnabled = True
        Me.cboUser.Location = New System.Drawing.Point(19, 42)
        Me.cboUser.Margin = New System.Windows.Forms.Padding(2)
        Me.cboUser.Name = "cboUser"
        Me.cboUser.Size = New System.Drawing.Size(145, 21)
        Me.cboUser.TabIndex = 9
        '
        'grbHR
        '
        Me.grbHR.Controls.Add(Me.btnsearchpaystubs)
        Me.grbHR.Controls.Add(Me.btnviewpayroll)
        Me.grbHR.Controls.Add(Me.btnmodemp)
        Me.grbHR.Controls.Add(Me.btnsearchEmp)
        Me.grbHR.Controls.Add(Me.btnAddEmp)
        Me.grbHR.Location = New System.Drawing.Point(15, 307)
        Me.grbHR.Margin = New System.Windows.Forms.Padding(2)
        Me.grbHR.Name = "grbHR"
        Me.grbHR.Padding = New System.Windows.Forms.Padding(2)
        Me.grbHR.Size = New System.Drawing.Size(149, 201)
        Me.grbHR.TabIndex = 8
        Me.grbHR.TabStop = False
        Me.grbHR.Text = "Human Resources"
        '
        'btnsearchpaystubs
        '
        Me.btnsearchpaystubs.Location = New System.Drawing.Point(20, 122)
        Me.btnsearchpaystubs.Margin = New System.Windows.Forms.Padding(2)
        Me.btnsearchpaystubs.Name = "btnsearchpaystubs"
        Me.btnsearchpaystubs.Size = New System.Drawing.Size(105, 30)
        Me.btnsearchpaystubs.TabIndex = 13
        Me.btnsearchpaystubs.Text = "Search Paystubs"
        Me.btnsearchpaystubs.UseVisualStyleBackColor = True
        '
        'btnviewpayroll
        '
        Me.btnviewpayroll.Location = New System.Drawing.Point(20, 162)
        Me.btnviewpayroll.Name = "btnviewpayroll"
        Me.btnviewpayroll.Size = New System.Drawing.Size(104, 23)
        Me.btnviewpayroll.TabIndex = 12
        Me.btnviewpayroll.Text = "view Payroll"
        Me.btnviewpayroll.UseVisualStyleBackColor = True
        '
        'btnmodemp
        '
        Me.btnmodemp.Location = New System.Drawing.Point(20, 84)
        Me.btnmodemp.Name = "btnmodemp"
        Me.btnmodemp.Size = New System.Drawing.Size(104, 23)
        Me.btnmodemp.TabIndex = 11
        Me.btnmodemp.Text = "Modify Employee"
        Me.btnmodemp.UseVisualStyleBackColor = True
        '
        'btnsearchEmp
        '
        Me.btnsearchEmp.Location = New System.Drawing.Point(20, 55)
        Me.btnsearchEmp.Name = "btnsearchEmp"
        Me.btnsearchEmp.Size = New System.Drawing.Size(106, 23)
        Me.btnsearchEmp.TabIndex = 10
        Me.btnsearchEmp.Text = "Search Employee"
        Me.btnsearchEmp.UseVisualStyleBackColor = True
        '
        'btnAddEmp
        '
        Me.btnAddEmp.Location = New System.Drawing.Point(15, 26)
        Me.btnAddEmp.Name = "btnAddEmp"
        Me.btnAddEmp.Size = New System.Drawing.Size(111, 23)
        Me.btnAddEmp.TabIndex = 9
        Me.btnAddEmp.Text = "Add Employee"
        Me.btnAddEmp.UseVisualStyleBackColor = True
        '
        'btnmodPO
        '
        Me.btnmodPO.Location = New System.Drawing.Point(6, 75)
        Me.btnmodPO.Name = "btnmodPO"
        Me.btnmodPO.Size = New System.Drawing.Size(135, 23)
        Me.btnmodPO.TabIndex = 1
        Me.btnmodPO.Text = "Process Purchase Order"
        Me.btnmodPO.UseVisualStyleBackColor = True
        '
        'btncreatePO
        '
        Me.btncreatePO.Location = New System.Drawing.Point(8, 33)
        Me.btncreatePO.Name = "btncreatePO"
        Me.btncreatePO.Size = New System.Drawing.Size(135, 23)
        Me.btncreatePO.TabIndex = 0
        Me.btncreatePO.Text = "Purchase Order"
        Me.btncreatePO.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Location = New System.Drawing.Point(2, 2)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(2)
        Me.TabControl1.MenuRenderer = Nothing
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.Size = New System.Drawing.Size(1129, 802)
        Me.TabControl1.TabCloseButtonImage = Nothing
        Me.TabControl1.TabCloseButtonImageDisabled = Nothing
        Me.TabControl1.TabCloseButtonImageHot = Nothing
        Me.TabControl1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btncreatePO)
        Me.GroupBox1.Controls.Add(Me.btnmodPO)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 96)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(149, 120)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Purchase Order"
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1385, 684)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "main"
        Me.Text = "Acme Stuff"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.grbHR.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents btnmodPO As System.Windows.Forms.Button
    Friend WithEvents btncreatePO As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As MdiTabControl.TabControl
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents grbHR As System.Windows.Forms.GroupBox
    Friend WithEvents btnviewpayroll As System.Windows.Forms.Button
    Friend WithEvents btnmodemp As System.Windows.Forms.Button
    Friend WithEvents btnsearchEmp As System.Windows.Forms.Button
    Friend WithEvents btnAddEmp As System.Windows.Forms.Button
    Friend WithEvents AboutToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents lbluser As System.Windows.Forms.Label
    Friend WithEvents cboUser As System.Windows.Forms.ComboBox
    Friend WithEvents lblloggedinuserid As System.Windows.Forms.Label
    Friend WithEvents btnsearchpaystubs As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As GroupBox
End Class
