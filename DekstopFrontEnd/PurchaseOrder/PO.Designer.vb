<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CreatePO
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CreatePO))
        Me.dgvPO = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblEmp = New System.Windows.Forms.Label()
        Me.lblDep = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblSup = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblErr = New System.Windows.Forms.Label()
        Me.lblIDlabel = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblSubtotal = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.dtpStart = New System.Windows.Forms.DateTimePicker()
        Me.dtpEnd = New System.Windows.Forms.DateTimePicker()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.lstResults = New System.Windows.Forms.ListBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.lblStatusLabel = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblres = New System.Windows.Forms.Label()
        CType(Me.dgvPO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvPO
        '
        Me.dgvPO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPO.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke
        Me.dgvPO.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.dgvPO.Location = New System.Drawing.Point(15, 186)
        Me.dgvPO.Name = "dgvPO"
        Me.dgvPO.Size = New System.Drawing.Size(777, 250)
        Me.dgvPO.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Employee"
        '
        'lblEmp
        '
        Me.lblEmp.AutoSize = True
        Me.lblEmp.Location = New System.Drawing.Point(15, 65)
        Me.lblEmp.Name = "lblEmp"
        Me.lblEmp.Size = New System.Drawing.Size(38, 13)
        Me.lblEmp.TabIndex = 4
        Me.lblEmp.Text = "lblEmp"
        '
        'lblDep
        '
        Me.lblDep.AutoSize = True
        Me.lblDep.Location = New System.Drawing.Point(131, 65)
        Me.lblDep.Name = "lblDep"
        Me.lblDep.Size = New System.Drawing.Size(37, 13)
        Me.lblDep.TabIndex = 6
        Me.lblDep.Text = "lblDep"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(131, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Department"
        '
        'lblSup
        '
        Me.lblSup.AutoSize = True
        Me.lblSup.Location = New System.Drawing.Point(251, 65)
        Me.lblSup.Name = "lblSup"
        Me.lblSup.Size = New System.Drawing.Size(36, 13)
        Me.lblSup.TabIndex = 8
        Me.lblSup.Text = "lblSup"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(251, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Supervisor"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(355, 65)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(40, 13)
        Me.lblDate.TabIndex = 10
        Me.lblDate.Text = "lblDate"
        '
        'lblErr
        '
        Me.lblErr.AutoSize = True
        Me.lblErr.Location = New System.Drawing.Point(160, 96)
        Me.lblErr.Name = "lblErr"
        Me.lblErr.Size = New System.Drawing.Size(30, 13)
        Me.lblErr.TabIndex = 11
        Me.lblErr.Text = "lblErr"
        '
        'lblIDlabel
        '
        Me.lblIDlabel.AutoSize = True
        Me.lblIDlabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIDlabel.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.lblIDlabel.Location = New System.Drawing.Point(139, 15)
        Me.lblIDlabel.Name = "lblIDlabel"
        Me.lblIDlabel.Size = New System.Drawing.Size(135, 16)
        Me.lblIDlabel.TabIndex = 12
        Me.lblIDlabel.Text = "Purchase Order ID"
        Me.lblIDlabel.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Subtotal"
        '
        'lblSubtotal
        '
        Me.lblSubtotal.AutoSize = True
        Me.lblSubtotal.Location = New System.Drawing.Point(31, 148)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(34, 13)
        Me.lblSubtotal.TabIndex = 14
        Me.lblSubtotal.Text = "$0.00"
        Me.lblSubtotal.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(128, 131)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(25, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Tax"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(217, 130)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(31, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Total"
        '
        'lblTax
        '
        Me.lblTax.AutoSize = True
        Me.lblTax.Location = New System.Drawing.Point(128, 148)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(34, 13)
        Me.lblTax.TabIndex = 17
        Me.lblTax.Text = "$0.00"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(217, 148)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(34, 13)
        Me.lblTotal.TabIndex = 18
        Me.lblTotal.Text = "$0.00"
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.lblID.Location = New System.Drawing.Point(254, 15)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(16, 16)
        Me.lblID.TabIndex = 19
        Me.lblID.Text = "0"
        Me.lblID.Visible = False
        '
        'dtpStart
        '
        Me.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpStart.Location = New System.Drawing.Point(129, 49)
        Me.dtpStart.Name = "dtpStart"
        Me.dtpStart.Size = New System.Drawing.Size(84, 20)
        Me.dtpStart.TabIndex = 20
        '
        'dtpEnd
        '
        Me.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpEnd.Location = New System.Drawing.Point(239, 50)
        Me.dtpEnd.Name = "dtpEnd"
        Me.dtpEnd.Size = New System.Drawing.Size(84, 20)
        Me.dtpEnd.TabIndex = 21
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(5, 50)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(82, 20)
        Me.txtID.TabIndex = 22
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(2, 34)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 13)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "By ID"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(93, 53)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(30, 13)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "- Or -"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(126, 33)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 13)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "By Date Range"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(219, 53)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(20, 13)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "To"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnSearch)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtID)
        Me.GroupBox1.Controls.Add(Me.dtpEnd)
        Me.GroupBox1.Controls.Add(Me.dtpStart)
        Me.GroupBox1.Location = New System.Drawing.Point(425, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(364, 76)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search Purchase Orders"
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(283, 13)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 27
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'lstResults
        '
        Me.lstResults.FormattingEnabled = True
        Me.lstResults.Location = New System.Drawing.Point(425, 121)
        Me.lstResults.Name = "lstResults"
        Me.lstResults.Size = New System.Drawing.Size(348, 56)
        Me.lstResults.TabIndex = 23
        Me.lstResults.Visible = False
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(286, 121)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(109, 40)
        Me.btnSave.TabIndex = 24
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'lblStatusLabel
        '
        Me.lblStatusLabel.AutoSize = True
        Me.lblStatusLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatusLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.lblStatusLabel.Location = New System.Drawing.Point(283, 15)
        Me.lblStatusLabel.Name = "lblStatusLabel"
        Me.lblStatusLabel.Size = New System.Drawing.Size(51, 16)
        Me.lblStatusLabel.TabIndex = 25
        Me.lblStatusLabel.Text = "Status"
        Me.lblStatusLabel.Visible = False
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.lblStatus.Location = New System.Drawing.Point(337, 15)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(12, 16)
        Me.lblStatus.TabIndex = 26
        Me.lblStatus.Text = "."
        Me.lblStatus.Visible = False
        '
        'lblres
        '
        Me.lblres.AutoSize = True
        Me.lblres.Location = New System.Drawing.Point(427, 105)
        Me.lblres.Name = "lblres"
        Me.lblres.Size = New System.Drawing.Size(148, 13)
        Me.lblres.TabIndex = 27
        Me.lblres.Text = "Search Result (ID/Cost/Date)"
        Me.lblres.Visible = False
        '
        'CreatePO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 546)
        Me.Controls.Add(Me.lblres)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.lblStatusLabel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lstResults)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblTax)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblSubtotal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblIDlabel)
        Me.Controls.Add(Me.lblErr)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblSup)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblDep)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblEmp)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvPO)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CreatePO"
        Me.Text = "Purchase Order"
        CType(Me.dgvPO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvPO As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents lblEmp As Label
    Friend WithEvents lblDep As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblSup As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents lblErr As Label
    Friend WithEvents lblIDlabel As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblSubtotal As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblTax As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblID As Label
    Friend WithEvents dtpStart As DateTimePicker
    Friend WithEvents dtpEnd As DateTimePicker
    Friend WithEvents txtID As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents lstResults As ListBox
    Friend WithEvents btnSave As Button
    Friend WithEvents lblStatusLabel As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents lblres As Label
End Class
