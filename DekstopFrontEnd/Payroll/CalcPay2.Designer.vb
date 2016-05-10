<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CalcPay2
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
        Me.GetLastPayrollBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FinalProjGetLastPayroll = New FinalProjGetLastPayroll()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.GetLastPayrollTableAdapter = New FinalProjGetLastPayrollTableAdapters.GetLastPayrollTableAdapter()
        CType(Me.GetLastPayrollBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FinalProjGetLastPayroll, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GetLastPayrollBindingSource
        '
        Me.GetLastPayrollBindingSource.DataMember = "GetLastPayroll"
        Me.GetLastPayrollBindingSource.DataSource = Me.FinalProjGetLastPayroll
        '
        'FinalProjGetLastPayroll
        '
        Me.FinalProjGetLastPayroll.DataSetName = "FinalProjGetLastPayroll"
        Me.FinalProjGetLastPayroll.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.GetLastPayrollBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "LastPayroll.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1202, 865)
        Me.ReportViewer1.TabIndex = 0
        '
        'GetLastPayrollTableAdapter
        '
        Me.GetLastPayrollTableAdapter.ClearBeforeFill = True
        '
        'CalcPay2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1202, 865)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "CalcPay2"
        Me.Text = "CalcPay2"
        CType(Me.GetLastPayrollBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FinalProjGetLastPayroll, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents GetLastPayrollBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FinalProjGetLastPayroll As FinalProjGetLastPayroll
    Friend WithEvents GetLastPayrollTableAdapter As FinalProjGetLastPayrollTableAdapters.GetLastPayrollTableAdapter
End Class
