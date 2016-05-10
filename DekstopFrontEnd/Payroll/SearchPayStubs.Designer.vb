<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SearchPayStubs
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.SearchPayStubsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FinalProjSearchPayStubs = New FinalProjSearchPayStubs()
        Me.btnsearchpaystubs = New System.Windows.Forms.Button()
        Me.cboEmployees = New System.Windows.Forms.ComboBox()
        Me.dtpStartDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpEndDate = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SearchPayStubsTableAdapter = New FinalProjSearchPayStubsTableAdapters.SearchPayStubsTableAdapter()
        CType(Me.SearchPayStubsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FinalProjSearchPayStubs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SearchPayStubsBindingSource
        '
        Me.SearchPayStubsBindingSource.DataMember = "SearchPayStubs"
        Me.SearchPayStubsBindingSource.DataSource = Me.FinalProjSearchPayStubs
        '
        'FinalProjSearchPayStubs
        '
        Me.FinalProjSearchPayStubs.DataSetName = "FinalProjSearchPayStubs"
        Me.FinalProjSearchPayStubs.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnsearchpaystubs
        '
        Me.btnsearchpaystubs.Location = New System.Drawing.Point(1014, 13)
        Me.btnsearchpaystubs.Name = "btnsearchpaystubs"
        Me.btnsearchpaystubs.Size = New System.Drawing.Size(102, 37)
        Me.btnsearchpaystubs.TabIndex = 0
        Me.btnsearchpaystubs.Text = "Search"
        Me.btnsearchpaystubs.UseVisualStyleBackColor = True
        '
        'cboEmployees
        '
        Me.cboEmployees.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEmployees.FormattingEnabled = True
        Me.cboEmployees.Items.AddRange(New Object() {"10000001"})
        Me.cboEmployees.Location = New System.Drawing.Point(146, 13)
        Me.cboEmployees.Name = "cboEmployees"
        Me.cboEmployees.Size = New System.Drawing.Size(198, 28)
        Me.cboEmployees.TabIndex = 1
        '
        'dtpStartDate
        '
        Me.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpStartDate.Location = New System.Drawing.Point(515, 13)
        Me.dtpStartDate.Name = "dtpStartDate"
        Me.dtpStartDate.Size = New System.Drawing.Size(147, 26)
        Me.dtpStartDate.TabIndex = 2
        '
        'dtpEndDate
        '
        Me.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpEndDate.Location = New System.Drawing.Point(823, 13)
        Me.dtpEndDate.Name = "dtpEndDate"
        Me.dtpEndDate.Size = New System.Drawing.Size(149, 26)
        Me.dtpEndDate.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Employee:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(386, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Start Date:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(704, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "End Date"
        '
        'ReportViewer1
        '
        ReportDataSource2.Name = "DataSet1"
        ReportDataSource2.Value = Me.SearchPayStubsBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "SearchPayStubs1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 63)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1136, 487)
        Me.ReportViewer1.TabIndex = 7
        '
        'SearchPayStubsTableAdapter
        '
        Me.SearchPayStubsTableAdapter.ClearBeforeFill = True
        '
        'SearchPayStubs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1202, 865)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpEndDate)
        Me.Controls.Add(Me.dtpStartDate)
        Me.Controls.Add(Me.cboEmployees)
        Me.Controls.Add(Me.btnsearchpaystubs)
        Me.Name = "SearchPayStubs"
        Me.Text = "SearchPayStubs"
        CType(Me.SearchPayStubsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FinalProjSearchPayStubs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnsearchpaystubs As System.Windows.Forms.Button
    Friend WithEvents cboEmployees As System.Windows.Forms.ComboBox
    Friend WithEvents dtpStartDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpEndDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents SearchPayStubsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FinalProjSearchPayStubs As FinalProjSearchPayStubs
    Friend WithEvents SearchPayStubsTableAdapter As FinalProjSearchPayStubsTableAdapters.SearchPayStubsTableAdapter
End Class
