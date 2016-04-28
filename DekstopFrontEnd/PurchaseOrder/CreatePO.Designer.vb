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
        Me.ddlEmployees = New System.Windows.Forms.ComboBox()
        Me.dgvPO = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblEmp = New System.Windows.Forms.Label()
        Me.lblDep = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblSup = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblErr = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblSubtotal = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        CType(Me.dgvPO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ddlEmployees
        '
        Me.ddlEmployees.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddlEmployees.FormattingEnabled = True
        Me.ddlEmployees.Location = New System.Drawing.Point(12, 12)
        Me.ddlEmployees.Name = "ddlEmployees"
        Me.ddlEmployees.Size = New System.Drawing.Size(121, 21)
        Me.ddlEmployees.TabIndex = 0
        '
        'dgvPO
        '
        Me.dgvPO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPO.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke
        Me.dgvPO.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.dgvPO.Location = New System.Drawing.Point(12, 94)
        Me.dgvPO.Name = "dgvPO"
        Me.dgvPO.Size = New System.Drawing.Size(646, 250)
        Me.dgvPO.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Employee"
        '
        'lblEmp
        '
        Me.lblEmp.AutoSize = True
        Me.lblEmp.Location = New System.Drawing.Point(12, 53)
        Me.lblEmp.Name = "lblEmp"
        Me.lblEmp.Size = New System.Drawing.Size(38, 13)
        Me.lblEmp.TabIndex = 4
        Me.lblEmp.Text = "lblEmp"
        '
        'lblDep
        '
        Me.lblDep.AutoSize = True
        Me.lblDep.Location = New System.Drawing.Point(128, 53)
        Me.lblDep.Name = "lblDep"
        Me.lblDep.Size = New System.Drawing.Size(37, 13)
        Me.lblDep.TabIndex = 6
        Me.lblDep.Text = "lblDep"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(128, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Department"
        '
        'lblSup
        '
        Me.lblSup.AutoSize = True
        Me.lblSup.Location = New System.Drawing.Point(248, 53)
        Me.lblSup.Name = "lblSup"
        Me.lblSup.Size = New System.Drawing.Size(36, 13)
        Me.lblSup.TabIndex = 8
        Me.lblSup.Text = "lblSup"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(248, 36)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Supervisor"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(352, 53)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(40, 13)
        Me.lblDate.TabIndex = 10
        Me.lblDate.Text = "lblDate"
        '
        'lblErr
        '
        Me.lblErr.AutoSize = True
        Me.lblErr.Location = New System.Drawing.Point(302, 365)
        Me.lblErr.Name = "lblErr"
        Me.lblErr.Size = New System.Drawing.Size(30, 13)
        Me.lblErr.TabIndex = 11
        Me.lblErr.Text = "lblErr"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 391)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Purchase Order ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(196, 392)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Subtotal"
        '
        'lblSubtotal
        '
        Me.lblSubtotal.AutoSize = True
        Me.lblSubtotal.Location = New System.Drawing.Point(196, 409)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(34, 13)
        Me.lblSubtotal.TabIndex = 14
        Me.lblSubtotal.Text = "$0.00"
        Me.lblSubtotal.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(293, 392)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(25, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Tax"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(382, 391)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(31, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Total"
        '
        'lblTax
        '
        Me.lblTax.AutoSize = True
        Me.lblTax.Location = New System.Drawing.Point(293, 409)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(34, 13)
        Me.lblTax.TabIndex = 17
        Me.lblTax.Text = "$0.00"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(382, 409)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(34, 13)
        Me.lblTotal.TabIndex = 18
        Me.lblTotal.Text = "$0.00"
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(104, 392)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(13, 13)
        Me.lblID.TabIndex = 19
        Me.lblID.Text = "0"
        '
        'CreatePO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(801, 431)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblTax)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblSubtotal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblErr)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblSup)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblDep)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblEmp)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvPO)
        Me.Controls.Add(Me.ddlEmployees)
        Me.Name = "CreatePO"
        Me.Text = "CreatePO"
        CType(Me.dgvPO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ddlEmployees As ComboBox
    Friend WithEvents dgvPO As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents lblEmp As Label
    Friend WithEvents lblDep As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblSup As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents lblErr As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblSubtotal As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblTax As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblID As Label
End Class
