<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource4 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpEndDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpStartDate = New System.Windows.Forms.DateTimePicker()
        Me.cboEmployees = New System.Windows.Forms.ComboBox()
        Me.btnsearchpaystubs = New System.Windows.Forms.Button()
        Me.FinalProjDataSet77771 = New FinalProjDataSet7777()
        Me.FinalProjDataSet77771BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportViewer2 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.SearchPayStubsTableAdapter1 = New FinalProjDataSet7777TableAdapters.SearchPayStubsTableAdapter()
        CType(Me.FinalProjDataSet77771, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FinalProjDataSet77771BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        ReportDataSource3.Name = "searchpayroll"
        ReportDataSource3.Value = Me.FinalProjDataSet77771BindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "searchpaystubs2.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 119)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1192, 401)
        Me.ReportViewer1.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(780, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 20)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "End Date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(462, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 20)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Start Date:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(97, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 20)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Employee:"
        '
        'dtpEndDate
        '
        Me.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpEndDate.Location = New System.Drawing.Point(899, 12)
        Me.dtpEndDate.Name = "dtpEndDate"
        Me.dtpEndDate.Size = New System.Drawing.Size(149, 26)
        Me.dtpEndDate.TabIndex = 10
        '
        'dtpStartDate
        '
        Me.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpStartDate.Location = New System.Drawing.Point(591, 12)
        Me.dtpStartDate.Name = "dtpStartDate"
        Me.dtpStartDate.Size = New System.Drawing.Size(147, 26)
        Me.dtpStartDate.TabIndex = 9
        '
        'cboEmployees
        '
        Me.cboEmployees.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEmployees.FormattingEnabled = True
        Me.cboEmployees.Items.AddRange(New Object() {"10000001"})
        Me.cboEmployees.Location = New System.Drawing.Point(222, 12)
        Me.cboEmployees.Name = "cboEmployees"
        Me.cboEmployees.Size = New System.Drawing.Size(198, 28)
        Me.cboEmployees.TabIndex = 8
        '
        'btnsearchpaystubs
        '
        Me.btnsearchpaystubs.Location = New System.Drawing.Point(1090, 12)
        Me.btnsearchpaystubs.Name = "btnsearchpaystubs"
        Me.btnsearchpaystubs.Size = New System.Drawing.Size(102, 37)
        Me.btnsearchpaystubs.TabIndex = 7
        Me.btnsearchpaystubs.Text = "Search"
        Me.btnsearchpaystubs.UseVisualStyleBackColor = True
        '
        'FinalProjDataSet77771
        '
        Me.FinalProjDataSet77771.DataSetName = "FinalProjDataSet7777"
        Me.FinalProjDataSet77771.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FinalProjDataSet77771BindingSource
        '
        Me.FinalProjDataSet77771BindingSource.DataSource = Me.FinalProjDataSet77771
        Me.FinalProjDataSet77771BindingSource.Position = 0
        '
        'ReportViewer2
        '
        ReportDataSource4.Name = "searchpayroll"
        ReportDataSource4.Value = Me.BindingSource1
        Me.ReportViewer2.LocalReport.DataSources.Add(ReportDataSource4)
        Me.ReportViewer2.LocalReport.ReportEmbeddedResource = "searchpaystubs2.rdlc"
        Me.ReportViewer2.Location = New System.Drawing.Point(48, 574)
        Me.ReportViewer2.Name = "ReportViewer2"
        Me.ReportViewer2.Size = New System.Drawing.Size(1035, 246)
        Me.ReportViewer2.TabIndex = 14
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "SearchPayStubs"
        Me.BindingSource1.DataSource = Me.FinalProjDataSet77771BindingSource
        '
        'SearchPayStubsTableAdapter1
        '
        Me.SearchPayStubsTableAdapter1.ClearBeforeFill = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1202, 865)
        Me.Controls.Add(Me.ReportViewer2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpEndDate)
        Me.Controls.Add(Me.dtpStartDate)
        Me.Controls.Add(Me.cboEmployees)
        Me.Controls.Add(Me.btnsearchpaystubs)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "Form1"
        Me.Text = "Search PayStubs"
        CType(Me.FinalProjDataSet77771, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FinalProjDataSet77771BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents SearchPayStubsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FinalProjDataSet7777 As FinalProjDataSet7777
    Friend WithEvents SearchPayStubsTableAdapter As FinalProjDataSet7777TableAdapters.SearchPayStubsTableAdapter
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpEndDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpStartDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents cboEmployees As System.Windows.Forms.ComboBox
    Friend WithEvents btnsearchpaystubs As System.Windows.Forms.Button
    Friend WithEvents FinalProjDataSet77771BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FinalProjDataSet77771 As FinalProjDataSet7777
    Friend WithEvents ReportViewer2 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents SearchPayStubsTableAdapter1 As FinalProjDataSet7777TableAdapters.SearchPayStubsTableAdapter
End Class
