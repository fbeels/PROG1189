<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CalcPayroll
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.CalculatePayrollBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FinalProjDataSet = New FinalProjDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.CalculatePayrollTableAdapter = New FinalProjDataSetTableAdapters.CalculatePayrollTableAdapter()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.FinalProjDataSet2 = New FinalProjDataSet2()
        Me.YtdpensionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CurpensionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.YtdeiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CureiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.YtdcppDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CurcppDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.YtdincometaxDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CurincometaxDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CurgrossDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.YtdgrossDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PayrollDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ChequeidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.CalculatePayrollBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FinalProjDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FinalProjDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CalculatePayrollBindingSource
        '
        Me.CalculatePayrollBindingSource.DataMember = "CalculatePayroll"
        Me.CalculatePayrollBindingSource.DataSource = Me.FinalProjDataSet
        '
        'FinalProjDataSet
        '
        Me.FinalProjDataSet.DataSetName = "FinalProjDataSet"
        Me.FinalProjDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.CalculatePayrollBindingSource
        ReportDataSource2.Name = "DataSet2"
        ReportDataSource2.Value = Me.CalculatePayrollBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Payroll.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 23)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1278, 232)
        Me.ReportViewer1.TabIndex = 0
        '
        'CalculatePayrollTableAdapter
        '
        Me.CalculatePayrollTableAdapter.ClearBeforeFill = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ChequeidDataGridViewTextBoxColumn, Me.PayrollDateDataGridViewTextBoxColumn, Me.EmpidDataGridViewTextBoxColumn, Me.YtdgrossDataGridViewTextBoxColumn, Me.CurgrossDataGridViewTextBoxColumn, Me.CurincometaxDataGridViewTextBoxColumn, Me.YtdincometaxDataGridViewTextBoxColumn, Me.CurcppDataGridViewTextBoxColumn, Me.YtdcppDataGridViewTextBoxColumn, Me.CureiDataGridViewTextBoxColumn, Me.YtdeiDataGridViewTextBoxColumn, Me.CurpensionDataGridViewTextBoxColumn, Me.YtdpensionDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.CalculatePayrollBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(3, 374)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(1287, 199)
        Me.DataGridView1.TabIndex = 1
        '
        'FinalProjDataSet2
        '
        Me.FinalProjDataSet2.DataSetName = "FinalProjDataSet2"
        Me.FinalProjDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'YtdpensionDataGridViewTextBoxColumn
        '
        Me.YtdpensionDataGridViewTextBoxColumn.DataPropertyName = "ytd_pension"
        Me.YtdpensionDataGridViewTextBoxColumn.HeaderText = "ytd_pension"
        Me.YtdpensionDataGridViewTextBoxColumn.Name = "YtdpensionDataGridViewTextBoxColumn"
        Me.YtdpensionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CurpensionDataGridViewTextBoxColumn
        '
        Me.CurpensionDataGridViewTextBoxColumn.DataPropertyName = "cur_pension"
        Me.CurpensionDataGridViewTextBoxColumn.HeaderText = "cur_pension"
        Me.CurpensionDataGridViewTextBoxColumn.Name = "CurpensionDataGridViewTextBoxColumn"
        Me.CurpensionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'YtdeiDataGridViewTextBoxColumn
        '
        Me.YtdeiDataGridViewTextBoxColumn.DataPropertyName = "ytd_ei"
        Me.YtdeiDataGridViewTextBoxColumn.HeaderText = "ytd_ei"
        Me.YtdeiDataGridViewTextBoxColumn.Name = "YtdeiDataGridViewTextBoxColumn"
        Me.YtdeiDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CureiDataGridViewTextBoxColumn
        '
        Me.CureiDataGridViewTextBoxColumn.DataPropertyName = "cur_ei"
        Me.CureiDataGridViewTextBoxColumn.HeaderText = "cur_ei"
        Me.CureiDataGridViewTextBoxColumn.Name = "CureiDataGridViewTextBoxColumn"
        Me.CureiDataGridViewTextBoxColumn.ReadOnly = True
        '
        'YtdcppDataGridViewTextBoxColumn
        '
        Me.YtdcppDataGridViewTextBoxColumn.DataPropertyName = "ytd_cpp"
        Me.YtdcppDataGridViewTextBoxColumn.HeaderText = "ytd_cpp"
        Me.YtdcppDataGridViewTextBoxColumn.Name = "YtdcppDataGridViewTextBoxColumn"
        Me.YtdcppDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CurcppDataGridViewTextBoxColumn
        '
        Me.CurcppDataGridViewTextBoxColumn.DataPropertyName = "cur_cpp"
        Me.CurcppDataGridViewTextBoxColumn.HeaderText = "cur_cpp"
        Me.CurcppDataGridViewTextBoxColumn.Name = "CurcppDataGridViewTextBoxColumn"
        Me.CurcppDataGridViewTextBoxColumn.ReadOnly = True
        '
        'YtdincometaxDataGridViewTextBoxColumn
        '
        Me.YtdincometaxDataGridViewTextBoxColumn.DataPropertyName = "ytd_incometax"
        Me.YtdincometaxDataGridViewTextBoxColumn.HeaderText = "ytd_incometax"
        Me.YtdincometaxDataGridViewTextBoxColumn.Name = "YtdincometaxDataGridViewTextBoxColumn"
        Me.YtdincometaxDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CurincometaxDataGridViewTextBoxColumn
        '
        Me.CurincometaxDataGridViewTextBoxColumn.DataPropertyName = "cur_incometax"
        Me.CurincometaxDataGridViewTextBoxColumn.HeaderText = "cur_incometax"
        Me.CurincometaxDataGridViewTextBoxColumn.Name = "CurincometaxDataGridViewTextBoxColumn"
        Me.CurincometaxDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CurgrossDataGridViewTextBoxColumn
        '
        Me.CurgrossDataGridViewTextBoxColumn.DataPropertyName = "cur_gross"
        Me.CurgrossDataGridViewTextBoxColumn.HeaderText = "cur_gross"
        Me.CurgrossDataGridViewTextBoxColumn.Name = "CurgrossDataGridViewTextBoxColumn"
        Me.CurgrossDataGridViewTextBoxColumn.ReadOnly = True
        '
        'YtdgrossDataGridViewTextBoxColumn
        '
        Me.YtdgrossDataGridViewTextBoxColumn.DataPropertyName = "ytd_gross"
        Me.YtdgrossDataGridViewTextBoxColumn.HeaderText = "ytd_gross"
        Me.YtdgrossDataGridViewTextBoxColumn.Name = "YtdgrossDataGridViewTextBoxColumn"
        Me.YtdgrossDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmpidDataGridViewTextBoxColumn
        '
        Me.EmpidDataGridViewTextBoxColumn.DataPropertyName = "empid"
        Me.EmpidDataGridViewTextBoxColumn.HeaderText = "empid"
        Me.EmpidDataGridViewTextBoxColumn.Name = "EmpidDataGridViewTextBoxColumn"
        Me.EmpidDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PayrollDateDataGridViewTextBoxColumn
        '
        Me.PayrollDateDataGridViewTextBoxColumn.DataPropertyName = "PayrollDate"
        Me.PayrollDateDataGridViewTextBoxColumn.HeaderText = "PayrollDate"
        Me.PayrollDateDataGridViewTextBoxColumn.Name = "PayrollDateDataGridViewTextBoxColumn"
        Me.PayrollDateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ChequeidDataGridViewTextBoxColumn
        '
        Me.ChequeidDataGridViewTextBoxColumn.DataPropertyName = "chequeid"
        Me.ChequeidDataGridViewTextBoxColumn.HeaderText = "chequeid"
        Me.ChequeidDataGridViewTextBoxColumn.Name = "ChequeidDataGridViewTextBoxColumn"
        Me.ChequeidDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CalcPayroll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1302, 600)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "CalcPayroll"
        Me.Text = "CalcPayroll"
        CType(Me.CalculatePayrollBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FinalProjDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FinalProjDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents CalculatePayrollBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FinalProjDataSet As FinalProjDataSet
    Friend WithEvents CalculatePayrollTableAdapter As FinalProjDataSetTableAdapters.CalculatePayrollTableAdapter
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents FinalProjDataSet2 As FinalProjDataSet2
    Friend WithEvents ChequeidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PayrollDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmpidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents YtdgrossDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CurgrossDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CurincometaxDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents YtdincometaxDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CurcppDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents YtdcppDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CureiDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents YtdeiDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CurpensionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents YtdpensionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
