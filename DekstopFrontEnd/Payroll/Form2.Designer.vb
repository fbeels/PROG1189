<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.SearchPayStubsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FinalProjDataSet8888 = New FinalProjDataSet8888()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SearchPayStubsTableAdapter = New FinalProjDataSet8888TableAdapters.SearchPayStubsTableAdapter()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpEndDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpStartDate = New System.Windows.Forms.DateTimePicker()
        Me.cboEmployees = New System.Windows.Forms.ComboBox()
        Me.btnsearchpaystubs = New System.Windows.Forms.Button()
        CType(Me.SearchPayStubsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FinalProjDataSet8888, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SearchPayStubsBindingSource
        '
        Me.SearchPayStubsBindingSource.DataMember = "SearchPayStubs"
        Me.SearchPayStubsBindingSource.DataSource = Me.FinalProjDataSet8888
        '
        'FinalProjDataSet8888
        '
        Me.FinalProjDataSet8888.DataSetName = "FinalProjDataSet8888"
        Me.FinalProjDataSet8888.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "FinalProjDataset8888"
        ReportDataSource1.Value = Me.SearchPayStubsBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "SearchPayStubs3.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(15, 111)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1312, 405)
        Me.ReportViewer1.TabIndex = 0
        '
        'SearchPayStubsTableAdapter
        '
        Me.SearchPayStubsTableAdapter.ClearBeforeFill = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(694, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 20)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "End Date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(376, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 20)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Start Date:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 20)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Employee:"
        '
        'dtpEndDate
        '
        Me.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpEndDate.Location = New System.Drawing.Point(777, 22)
        Me.dtpEndDate.Name = "dtpEndDate"
        Me.dtpEndDate.Size = New System.Drawing.Size(149, 26)
        Me.dtpEndDate.TabIndex = 17
        '
        'dtpStartDate
        '
        Me.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpStartDate.Location = New System.Drawing.Point(505, 24)
        Me.dtpStartDate.Name = "dtpStartDate"
        Me.dtpStartDate.Size = New System.Drawing.Size(147, 26)
        Me.dtpStartDate.TabIndex = 16
        '
        'cboEmployees
        '
        Me.cboEmployees.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEmployees.FormattingEnabled = True
        Me.cboEmployees.Items.AddRange(New Object() {"10000001"})
        Me.cboEmployees.Location = New System.Drawing.Point(136, 24)
        Me.cboEmployees.Name = "cboEmployees"
        Me.cboEmployees.Size = New System.Drawing.Size(198, 28)
        Me.cboEmployees.TabIndex = 15
        '
        'btnsearchpaystubs
        '
        Me.btnsearchpaystubs.Location = New System.Drawing.Point(946, 19)
        Me.btnsearchpaystubs.Name = "btnsearchpaystubs"
        Me.btnsearchpaystubs.Size = New System.Drawing.Size(102, 37)
        Me.btnsearchpaystubs.TabIndex = 14
        Me.btnsearchpaystubs.Text = "Search"
        Me.btnsearchpaystubs.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1421, 659)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpEndDate)
        Me.Controls.Add(Me.dtpStartDate)
        Me.Controls.Add(Me.cboEmployees)
        Me.Controls.Add(Me.btnsearchpaystubs)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.SearchPayStubsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FinalProjDataSet8888, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents SearchPayStubsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FinalProjDataSet8888 As FinalProjDataSet8888
    Friend WithEvents SearchPayStubsTableAdapter As FinalProjDataSet8888TableAdapters.SearchPayStubsTableAdapter
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpEndDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpStartDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents cboEmployees As System.Windows.Forms.ComboBox
    Friend WithEvents btnsearchpaystubs As System.Windows.Forms.Button
End Class
