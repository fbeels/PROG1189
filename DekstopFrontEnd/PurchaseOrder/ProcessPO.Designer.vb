<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ProcessPO
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ddlStatus = New System.Windows.Forms.ComboBox()
        Me.dtpEnd = New System.Windows.Forms.DateTimePicker()
        Me.dtStart = New System.Windows.Forms.DateTimePicker()
        Me.txtLast = New System.Windows.Forms.TextBox()
        Me.txtFirst = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.lstResults = New System.Windows.Forms.ListBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblDenial = New System.Windows.Forms.Label()
        Me.ddlItemStatus = New System.Windows.Forms.ComboBox()
        Me.txtDenial = New System.Windows.Forms.TextBox()
        Me.gpItems = New System.Windows.Forms.GroupBox()
        Me.txtSource = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtJustification = New System.Windows.Forms.TextBox()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtDesc = New System.Windows.Forms.TextBox()
        Me.txtItemName = New System.Windows.Forms.TextBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.lblItemID = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblSup = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lblDept = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpItems.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnSearch)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ddlStatus)
        Me.GroupBox1.Controls.Add(Me.dtpEnd)
        Me.GroupBox1.Controls.Add(Me.dtStart)
        Me.GroupBox1.Controls.Add(Me.txtLast)
        Me.GroupBox1.Controls.Add(Me.txtFirst)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(363, 121)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search"
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(260, 81)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(74, 23)
        Me.btnSearch.TabIndex = 6
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(254, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Status"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(149, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "To date"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "From date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(132, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Last Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "First name"
        '
        'ddlStatus
        '
        Me.ddlStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddlStatus.FormattingEnabled = True
        Me.ddlStatus.Location = New System.Drawing.Point(254, 35)
        Me.ddlStatus.Name = "ddlStatus"
        Me.ddlStatus.Size = New System.Drawing.Size(80, 21)
        Me.ddlStatus.TabIndex = 4
        '
        'dtpEnd
        '
        Me.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpEnd.Location = New System.Drawing.Point(149, 84)
        Me.dtpEnd.Name = "dtpEnd"
        Me.dtpEnd.Size = New System.Drawing.Size(83, 20)
        Me.dtpEnd.TabIndex = 3
        '
        'dtStart
        '
        Me.dtStart.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtStart.Location = New System.Drawing.Point(12, 84)
        Me.dtStart.Name = "dtStart"
        Me.dtStart.Size = New System.Drawing.Size(80, 20)
        Me.dtStart.TabIndex = 2
        Me.dtStart.Value = New Date(1990, 1, 1, 0, 0, 0, 0)
        '
        'txtLast
        '
        Me.txtLast.Location = New System.Drawing.Point(132, 35)
        Me.txtLast.Name = "txtLast"
        Me.txtLast.Size = New System.Drawing.Size(100, 20)
        Me.txtLast.TabIndex = 1
        '
        'txtFirst
        '
        Me.txtFirst.Location = New System.Drawing.Point(12, 36)
        Me.txtFirst.Name = "txtFirst"
        Me.txtFirst.Size = New System.Drawing.Size(100, 20)
        Me.txtFirst.TabIndex = 0
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 136)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(776, 150)
        Me.DataGridView1.TabIndex = 1
        '
        'lstResults
        '
        Me.lstResults.FormattingEnabled = True
        Me.lstResults.Location = New System.Drawing.Point(449, 9)
        Me.lstResults.Name = "lstResults"
        Me.lstResults.Size = New System.Drawing.Size(339, 121)
        Me.lstResults.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(36, 35)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Item ID:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(30, 63)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 13)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Item Name:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(28, 91)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(63, 13)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "Description:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(40, 116)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(34, 13)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "Price:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(28, 140)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(49, 13)
        Me.Label14.TabIndex = 10
        Me.Label14.Text = "Quantity:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(207, 35)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(65, 13)
        Me.Label15.TabIndex = 11
        Me.Label15.Text = "Justification:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(439, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 13)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Status:"
        '
        'lblDenial
        '
        Me.lblDenial.AutoSize = True
        Me.lblDenial.Location = New System.Drawing.Point(440, 69)
        Me.lblDenial.Name = "lblDenial"
        Me.lblDenial.Size = New System.Drawing.Size(92, 13)
        Me.lblDenial.TabIndex = 16
        Me.lblDenial.Text = "Reason for Denial"
        Me.lblDenial.Visible = False
        '
        'ddlItemStatus
        '
        Me.ddlItemStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddlItemStatus.FormattingEnabled = True
        Me.ddlItemStatus.Location = New System.Drawing.Point(443, 32)
        Me.ddlItemStatus.Name = "ddlItemStatus"
        Me.ddlItemStatus.Size = New System.Drawing.Size(103, 21)
        Me.ddlItemStatus.TabIndex = 17
        '
        'txtDenial
        '
        Me.txtDenial.Location = New System.Drawing.Point(446, 90)
        Me.txtDenial.Name = "txtDenial"
        Me.txtDenial.Size = New System.Drawing.Size(100, 20)
        Me.txtDenial.TabIndex = 18
        Me.txtDenial.Visible = False
        '
        'gpItems
        '
        Me.gpItems.Controls.Add(Me.txtSource)
        Me.gpItems.Controls.Add(Me.Label6)
        Me.gpItems.Controls.Add(Me.txtJustification)
        Me.gpItems.Controls.Add(Me.txtQuantity)
        Me.gpItems.Controls.Add(Me.txtPrice)
        Me.gpItems.Controls.Add(Me.txtDesc)
        Me.gpItems.Controls.Add(Me.txtItemName)
        Me.gpItems.Controls.Add(Me.btnSubmit)
        Me.gpItems.Controls.Add(Me.Label7)
        Me.gpItems.Controls.Add(Me.Label9)
        Me.gpItems.Controls.Add(Me.lblDenial)
        Me.gpItems.Controls.Add(Me.Label15)
        Me.gpItems.Controls.Add(Me.ddlItemStatus)
        Me.gpItems.Controls.Add(Me.txtDenial)
        Me.gpItems.Controls.Add(Me.Label8)
        Me.gpItems.Controls.Add(Me.Label11)
        Me.gpItems.Controls.Add(Me.Label12)
        Me.gpItems.Controls.Add(Me.Label14)
        Me.gpItems.Controls.Add(Me.lblItemID)
        Me.gpItems.Location = New System.Drawing.Point(20, 299)
        Me.gpItems.Name = "gpItems"
        Me.gpItems.Size = New System.Drawing.Size(564, 163)
        Me.gpItems.TabIndex = 19
        Me.gpItems.TabStop = False
        Me.gpItems.Text = "Item"
        Me.gpItems.Visible = False
        '
        'txtSource
        '
        Me.txtSource.Location = New System.Drawing.Point(278, 69)
        Me.txtSource.Name = "txtSource"
        Me.txtSource.Size = New System.Drawing.Size(100, 20)
        Me.txtSource.TabIndex = 26
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(207, 72)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 13)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Source:"
        '
        'txtJustification
        '
        Me.txtJustification.Location = New System.Drawing.Point(278, 32)
        Me.txtJustification.Name = "txtJustification"
        Me.txtJustification.Size = New System.Drawing.Size(100, 20)
        Me.txtJustification.TabIndex = 24
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(97, 142)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(100, 20)
        Me.txtQuantity.TabIndex = 23
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(97, 116)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(100, 20)
        Me.txtPrice.TabIndex = 22
        '
        'txtDesc
        '
        Me.txtDesc.Location = New System.Drawing.Point(97, 88)
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(100, 20)
        Me.txtDesc.TabIndex = 21
        '
        'txtItemName
        '
        Me.txtItemName.Location = New System.Drawing.Point(97, 60)
        Me.txtItemName.Name = "txtItemName"
        Me.txtItemName.Size = New System.Drawing.Size(100, 20)
        Me.txtItemName.TabIndex = 20
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(457, 134)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(75, 23)
        Me.btnSubmit.TabIndex = 19
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'lblItemID
        '
        Me.lblItemID.AutoSize = True
        Me.lblItemID.Location = New System.Drawing.Point(105, 35)
        Me.lblItemID.Name = "lblItemID"
        Me.lblItemID.Size = New System.Drawing.Size(45, 13)
        Me.lblItemID.TabIndex = 6
        Me.lblItemID.Text = "Label10"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(632, 315)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(60, 13)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "Supervisor:"
        '
        'lblSup
        '
        Me.lblSup.AutoSize = True
        Me.lblSup.Location = New System.Drawing.Point(701, 315)
        Me.lblSup.Name = "lblSup"
        Me.lblSup.Size = New System.Drawing.Size(45, 13)
        Me.lblSup.TabIndex = 28
        Me.lblSup.Text = "Label10"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(632, 339)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(65, 13)
        Me.Label16.TabIndex = 29
        Me.Label16.Text = "Department:"
        '
        'lblDept
        '
        Me.lblDept.AutoSize = True
        Me.lblDept.Location = New System.Drawing.Point(701, 339)
        Me.lblDept.Name = "lblDept"
        Me.lblDept.Size = New System.Drawing.Size(45, 13)
        Me.lblDept.TabIndex = 30
        Me.lblDept.Text = "Label10"
        '
        'ProcessPO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 474)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.lblDept)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lblSup)
        Me.Controls.Add(Me.gpItems)
        Me.Controls.Add(Me.lstResults)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "ProcessPO"
        Me.Text = "ProcessPO"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpItems.ResumeLayout(False)
        Me.gpItems.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ddlStatus As ComboBox
    Friend WithEvents dtpEnd As DateTimePicker
    Friend WithEvents dtStart As DateTimePicker
    Friend WithEvents txtLast As TextBox
    Friend WithEvents txtFirst As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents lstResults As ListBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblDenial As Label
    Friend WithEvents ddlItemStatus As ComboBox
    Friend WithEvents txtDenial As TextBox
    Friend WithEvents gpItems As GroupBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents txtJustification As TextBox
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents txtDesc As TextBox
    Friend WithEvents txtItemName As TextBox
    Friend WithEvents lblItemID As Label
    Friend WithEvents txtSource As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lblSup As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents lblDept As Label
End Class
