<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditEmployee
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
        Me.lblnomatches = New System.Windows.Forms.Label()
        Me.grbsearchresults = New System.Windows.Forms.GroupBox()
        Me.btneditemploymentinfo = New System.Windows.Forms.Button()
        Me.btneditjobinfo = New System.Windows.Forms.Button()
        Me.btnselect = New System.Windows.Forms.Button()
        Me.lstsearchresults = New System.Windows.Forms.ListBox()
        Me.grbempinfo = New System.Windows.Forms.GroupBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.lbldebug = New System.Windows.Forms.Label()
        Me.grbemployment = New System.Windows.Forms.GroupBox()
        Me.txtempid = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtsin = New System.Windows.Forms.TextBox()
        Me.lblsin = New System.Windows.Forms.Label()
        Me.chkemailstub = New System.Windows.Forms.CheckBox()
        Me.lblsenoritydate = New System.Windows.Forms.Label()
        Me.dtpsenority = New System.Windows.Forms.DateTimePicker()
        Me.rdostatusTerminated = New System.Windows.Forms.RadioButton()
        Me.rdostatusRetired = New System.Windows.Forms.RadioButton()
        Me.rdostatusActive = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpterminationdate = New System.Windows.Forms.DateTimePicker()
        Me.grbjob = New System.Windows.Forms.GroupBox()
        Me.lblsuperid = New System.Windows.Forms.Label()
        Me.lblstartdate = New System.Windows.Forms.Label()
        Me.dtpstartdate = New System.Windows.Forms.DateTimePicker()
        Me.lblsuper = New System.Windows.Forms.Label()
        Me.cbojobid = New System.Windows.Forms.ComboBox()
        Me.cbodept = New System.Windows.Forms.ComboBox()
        Me.txtpayrate = New System.Windows.Forms.TextBox()
        Me.lblpayrate = New System.Windows.Forms.Label()
        Me.lbljobid = New System.Windows.Forms.Label()
        Me.lbldept = New System.Windows.Forms.Label()
        Me.lblsupervisor = New System.Windows.Forms.Label()
        Me.grbpersonal = New System.Windows.Forms.GroupBox()
        Me.mtxcellphone = New System.Windows.Forms.MaskedTextBox()
        Me.mtxworkphone = New System.Windows.Forms.MaskedTextBox()
        Me.cboProv = New System.Windows.Forms.ComboBox()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.txtpostal = New System.Windows.Forms.TextBox()
        Me.txtcity = New System.Windows.Forms.TextBox()
        Me.txtstreetaddress = New System.Windows.Forms.TextBox()
        Me.lblemail = New System.Windows.Forms.Label()
        Me.lblcellphone = New System.Windows.Forms.Label()
        Me.lblworkphone = New System.Windows.Forms.Label()
        Me.lblpostal = New System.Windows.Forms.Label()
        Me.lblcity = New System.Windows.Forms.Label()
        Me.lblprov = New System.Windows.Forms.Label()
        Me.lblstreetaddress = New System.Windows.Forms.Label()
        Me.dtpdateofbirth = New System.Windows.Forms.DateTimePicker()
        Me.lbldob = New System.Windows.Forms.Label()
        Me.txtmiddleinit = New System.Windows.Forms.TextBox()
        Me.txtlastname = New System.Windows.Forms.TextBox()
        Me.txtfirstname = New System.Windows.Forms.TextBox()
        Me.lblfirstname = New System.Windows.Forms.Label()
        Me.lblmiddleint = New System.Windows.Forms.Label()
        Me.lbllastname = New System.Windows.Forms.Label()
        Me.grbsearch = New System.Windows.Forms.GroupBox()
        Me.btnsearch = New System.Windows.Forms.Button()
        Me.txtsearchlname = New System.Windows.Forms.TextBox()
        Me.txtsearchid = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.grbsearchresults.SuspendLayout()
        Me.grbempinfo.SuspendLayout()
        Me.grbemployment.SuspendLayout()
        Me.grbjob.SuspendLayout()
        Me.grbpersonal.SuspendLayout()
        Me.grbsearch.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblnomatches
        '
        Me.lblnomatches.AutoSize = True
        Me.lblnomatches.Location = New System.Drawing.Point(81, 32)
        Me.lblnomatches.Name = "lblnomatches"
        Me.lblnomatches.Size = New System.Drawing.Size(94, 13)
        Me.lblnomatches.TabIndex = 14
        Me.lblnomatches.Text = "No matches found"
        '
        'grbsearchresults
        '
        Me.grbsearchresults.Controls.Add(Me.btneditemploymentinfo)
        Me.grbsearchresults.Controls.Add(Me.btneditjobinfo)
        Me.grbsearchresults.Controls.Add(Me.btnselect)
        Me.grbsearchresults.Controls.Add(Me.lstsearchresults)
        Me.grbsearchresults.Controls.Add(Me.lblnomatches)
        Me.grbsearchresults.Location = New System.Drawing.Point(349, 9)
        Me.grbsearchresults.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.grbsearchresults.Name = "grbsearchresults"
        Me.grbsearchresults.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.grbsearchresults.Size = New System.Drawing.Size(397, 112)
        Me.grbsearchresults.TabIndex = 13
        Me.grbsearchresults.TabStop = False
        Me.grbsearchresults.Text = "Results"
        '
        'btneditemploymentinfo
        '
        Me.btneditemploymentinfo.Location = New System.Drawing.Point(260, 71)
        Me.btneditemploymentinfo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btneditemploymentinfo.Name = "btneditemploymentinfo"
        Me.btneditemploymentinfo.Size = New System.Drawing.Size(122, 30)
        Me.btneditemploymentinfo.TabIndex = 15
        Me.btneditemploymentinfo.Text = "Edit Employment Info"
        Me.btneditemploymentinfo.UseVisualStyleBackColor = True
        '
        'btneditjobinfo
        '
        Me.btneditjobinfo.Location = New System.Drawing.Point(257, 45)
        Me.btneditjobinfo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btneditjobinfo.Name = "btneditjobinfo"
        Me.btneditjobinfo.Size = New System.Drawing.Size(125, 19)
        Me.btneditjobinfo.TabIndex = 9
        Me.btneditjobinfo.Text = "Edit Job Info"
        Me.btneditjobinfo.UseVisualStyleBackColor = True
        '
        'btnselect
        '
        Me.btnselect.Location = New System.Drawing.Point(257, 14)
        Me.btnselect.Name = "btnselect"
        Me.btnselect.Size = New System.Drawing.Size(120, 25)
        Me.btnselect.TabIndex = 8
        Me.btnselect.Text = "Edit Personal Info"
        Me.btnselect.UseVisualStyleBackColor = True
        '
        'lstsearchresults
        '
        Me.lstsearchresults.FormattingEnabled = True
        Me.lstsearchresults.Location = New System.Drawing.Point(19, 14)
        Me.lstsearchresults.Name = "lstsearchresults"
        Me.lstsearchresults.Size = New System.Drawing.Size(215, 69)
        Me.lstsearchresults.TabIndex = 7
        '
        'grbempinfo
        '
        Me.grbempinfo.Controls.Add(Me.btnSave)
        Me.grbempinfo.Controls.Add(Me.lbldebug)
        Me.grbempinfo.Controls.Add(Me.grbemployment)
        Me.grbempinfo.Controls.Add(Me.grbjob)
        Me.grbempinfo.Controls.Add(Me.grbpersonal)
        Me.grbempinfo.Location = New System.Drawing.Point(6, 127)
        Me.grbempinfo.Name = "grbempinfo"
        Me.grbempinfo.Size = New System.Drawing.Size(767, 445)
        Me.grbempinfo.TabIndex = 12
        Me.grbempinfo.TabStop = False
        Me.grbempinfo.Text = "Employee Info"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(306, 381)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(189, 44)
        Me.btnSave.TabIndex = 22
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'lbldebug
        '
        Me.lbldebug.AutoSize = True
        Me.lbldebug.Location = New System.Drawing.Point(57, 396)
        Me.lbldebug.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbldebug.Name = "lbldebug"
        Me.lbldebug.Size = New System.Drawing.Size(39, 13)
        Me.lbldebug.TabIndex = 21
        Me.lbldebug.Text = "Label3"
        '
        'grbemployment
        '
        Me.grbemployment.BackColor = System.Drawing.Color.CadetBlue
        Me.grbemployment.Controls.Add(Me.txtempid)
        Me.grbemployment.Controls.Add(Me.Label3)
        Me.grbemployment.Controls.Add(Me.txtsin)
        Me.grbemployment.Controls.Add(Me.lblsin)
        Me.grbemployment.Controls.Add(Me.chkemailstub)
        Me.grbemployment.Controls.Add(Me.lblsenoritydate)
        Me.grbemployment.Controls.Add(Me.dtpsenority)
        Me.grbemployment.Controls.Add(Me.rdostatusTerminated)
        Me.grbemployment.Controls.Add(Me.rdostatusRetired)
        Me.grbemployment.Controls.Add(Me.rdostatusActive)
        Me.grbemployment.Controls.Add(Me.Label4)
        Me.grbemployment.Controls.Add(Me.dtpterminationdate)
        Me.grbemployment.Location = New System.Drawing.Point(17, 274)
        Me.grbemployment.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.grbemployment.Name = "grbemployment"
        Me.grbemployment.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.grbemployment.Size = New System.Drawing.Size(740, 94)
        Me.grbemployment.TabIndex = 20
        Me.grbemployment.TabStop = False
        Me.grbemployment.Text = "Employment Info"
        '
        'txtempid
        '
        Me.txtempid.Location = New System.Drawing.Point(99, 22)
        Me.txtempid.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtempid.Name = "txtempid"
        Me.txtempid.Size = New System.Drawing.Size(117, 20)
        Me.txtempid.TabIndex = 97
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 26)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 96
        Me.Label3.Text = "Employee ID:"
        '
        'txtsin
        '
        Me.txtsin.Location = New System.Drawing.Point(99, 45)
        Me.txtsin.Name = "txtsin"
        Me.txtsin.Size = New System.Drawing.Size(120, 20)
        Me.txtsin.TabIndex = 95
        '
        'lblsin
        '
        Me.lblsin.AutoSize = True
        Me.lblsin.Location = New System.Drawing.Point(55, 48)
        Me.lblsin.Name = "lblsin"
        Me.lblsin.Size = New System.Drawing.Size(38, 13)
        Me.lblsin.TabIndex = 94
        Me.lblsin.Text = "SIN #:"
        '
        'chkemailstub
        '
        Me.chkemailstub.AutoSize = True
        Me.chkemailstub.Location = New System.Drawing.Point(274, 48)
        Me.chkemailstub.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkemailstub.Name = "chkemailstub"
        Me.chkemailstub.Size = New System.Drawing.Size(99, 17)
        Me.chkemailstub.TabIndex = 93
        Me.chkemailstub.Text = "Email pay stubs"
        Me.chkemailstub.UseVisualStyleBackColor = True
        '
        'lblsenoritydate
        '
        Me.lblsenoritydate.AutoSize = True
        Me.lblsenoritydate.Location = New System.Drawing.Point(256, 22)
        Me.lblsenoritydate.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblsenoritydate.Name = "lblsenoritydate"
        Me.lblsenoritydate.Size = New System.Drawing.Size(73, 13)
        Me.lblsenoritydate.TabIndex = 92
        Me.lblsenoritydate.Text = "Seniority Date"
        '
        'dtpsenority
        '
        Me.dtpsenority.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpsenority.Location = New System.Drawing.Point(340, 18)
        Me.dtpsenority.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtpsenority.Name = "dtpsenority"
        Me.dtpsenority.Size = New System.Drawing.Size(97, 20)
        Me.dtpsenority.TabIndex = 91
        '
        'rdostatusTerminated
        '
        Me.rdostatusTerminated.AutoSize = True
        Me.rdostatusTerminated.Location = New System.Drawing.Point(504, 53)
        Me.rdostatusTerminated.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rdostatusTerminated.Name = "rdostatusTerminated"
        Me.rdostatusTerminated.Size = New System.Drawing.Size(78, 17)
        Me.rdostatusTerminated.TabIndex = 90
        Me.rdostatusTerminated.TabStop = True
        Me.rdostatusTerminated.Text = "Terminated"
        Me.rdostatusTerminated.UseVisualStyleBackColor = True
        '
        'rdostatusRetired
        '
        Me.rdostatusRetired.AutoSize = True
        Me.rdostatusRetired.Location = New System.Drawing.Point(504, 34)
        Me.rdostatusRetired.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rdostatusRetired.Name = "rdostatusRetired"
        Me.rdostatusRetired.Size = New System.Drawing.Size(59, 17)
        Me.rdostatusRetired.TabIndex = 89
        Me.rdostatusRetired.TabStop = True
        Me.rdostatusRetired.Text = "Retired"
        Me.rdostatusRetired.UseVisualStyleBackColor = True
        '
        'rdostatusActive
        '
        Me.rdostatusActive.AutoSize = True
        Me.rdostatusActive.Location = New System.Drawing.Point(504, 14)
        Me.rdostatusActive.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rdostatusActive.Name = "rdostatusActive"
        Me.rdostatusActive.Size = New System.Drawing.Size(55, 17)
        Me.rdostatusActive.TabIndex = 88
        Me.rdostatusActive.TabStop = True
        Me.rdostatusActive.Text = "Active"
        Me.rdostatusActive.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(456, 16)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 87
        Me.Label4.Text = "Status:"
        '
        'dtpterminationdate
        '
        Me.dtpterminationdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpterminationdate.Location = New System.Drawing.Point(583, 53)
        Me.dtpterminationdate.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtpterminationdate.Name = "dtpterminationdate"
        Me.dtpterminationdate.Size = New System.Drawing.Size(93, 20)
        Me.dtpterminationdate.TabIndex = 86
        '
        'grbjob
        '
        Me.grbjob.BackColor = System.Drawing.Color.Aquamarine
        Me.grbjob.Controls.Add(Me.lblsuperid)
        Me.grbjob.Controls.Add(Me.lblstartdate)
        Me.grbjob.Controls.Add(Me.dtpstartdate)
        Me.grbjob.Controls.Add(Me.lblsuper)
        Me.grbjob.Controls.Add(Me.cbojobid)
        Me.grbjob.Controls.Add(Me.cbodept)
        Me.grbjob.Controls.Add(Me.txtpayrate)
        Me.grbjob.Controls.Add(Me.lblpayrate)
        Me.grbjob.Controls.Add(Me.lbljobid)
        Me.grbjob.Controls.Add(Me.lbldept)
        Me.grbjob.Controls.Add(Me.lblsupervisor)
        Me.grbjob.Location = New System.Drawing.Point(22, 161)
        Me.grbjob.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.grbjob.Name = "grbjob"
        Me.grbjob.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.grbjob.Size = New System.Drawing.Size(740, 100)
        Me.grbjob.TabIndex = 19
        Me.grbjob.TabStop = False
        Me.grbjob.Text = "Job Info"
        '
        'lblsuperid
        '
        Me.lblsuperid.AutoSize = True
        Me.lblsuperid.Location = New System.Drawing.Point(231, 59)
        Me.lblsuperid.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblsuperid.Name = "lblsuperid"
        Me.lblsuperid.Size = New System.Drawing.Size(41, 13)
        Me.lblsuperid.TabIndex = 87
        Me.lblsuperid.Text = "superid"
        '
        'lblstartdate
        '
        Me.lblstartdate.AutoSize = True
        Me.lblstartdate.Location = New System.Drawing.Point(452, 63)
        Me.lblstartdate.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblstartdate.Name = "lblstartdate"
        Me.lblstartdate.Size = New System.Drawing.Size(58, 13)
        Me.lblstartdate.TabIndex = 86
        Me.lblstartdate.Text = "Start Date:"
        '
        'dtpstartdate
        '
        Me.dtpstartdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpstartdate.Location = New System.Drawing.Point(520, 60)
        Me.dtpstartdate.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtpstartdate.Name = "dtpstartdate"
        Me.dtpstartdate.Size = New System.Drawing.Size(93, 20)
        Me.dtpstartdate.TabIndex = 85
        '
        'lblsuper
        '
        Me.lblsuper.AutoSize = True
        Me.lblsuper.Location = New System.Drawing.Point(96, 59)
        Me.lblsuper.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblsuper.Name = "lblsuper"
        Me.lblsuper.Size = New System.Drawing.Size(33, 13)
        Me.lblsuper.TabIndex = 84
        Me.lblsuper.Text = "super"
        '
        'cbojobid
        '
        Me.cbojobid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbojobid.FormattingEnabled = True
        Me.cbojobid.Location = New System.Drawing.Point(363, 20)
        Me.cbojobid.Name = "cbojobid"
        Me.cbojobid.Size = New System.Drawing.Size(175, 21)
        Me.cbojobid.TabIndex = 83
        '
        'cbodept
        '
        Me.cbodept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbodept.FormattingEnabled = True
        Me.cbodept.Location = New System.Drawing.Point(95, 20)
        Me.cbodept.Name = "cbodept"
        Me.cbodept.Size = New System.Drawing.Size(175, 21)
        Me.cbodept.TabIndex = 82
        '
        'txtpayrate
        '
        Me.txtpayrate.Location = New System.Drawing.Point(363, 59)
        Me.txtpayrate.Name = "txtpayrate"
        Me.txtpayrate.Size = New System.Drawing.Size(48, 20)
        Me.txtpayrate.TabIndex = 81
        '
        'lblpayrate
        '
        Me.lblpayrate.AutoSize = True
        Me.lblpayrate.Location = New System.Drawing.Point(303, 59)
        Me.lblpayrate.Name = "lblpayrate"
        Me.lblpayrate.Size = New System.Drawing.Size(46, 13)
        Me.lblpayrate.TabIndex = 80
        Me.lblpayrate.Text = "Payrate:"
        '
        'lbljobid
        '
        Me.lbljobid.AutoSize = True
        Me.lbljobid.Location = New System.Drawing.Point(298, 22)
        Me.lbljobid.Name = "lbljobid"
        Me.lbljobid.Size = New System.Drawing.Size(32, 13)
        Me.lbljobid.TabIndex = 79
        Me.lbljobid.Text = "Jobs:"
        '
        'lbldept
        '
        Me.lbldept.AutoSize = True
        Me.lbldept.Location = New System.Drawing.Point(8, 25)
        Me.lbldept.Name = "lbldept"
        Me.lbldept.Size = New System.Drawing.Size(62, 13)
        Me.lbldept.TabIndex = 78
        Me.lbldept.Text = "Department"
        '
        'lblsupervisor
        '
        Me.lblsupervisor.AutoSize = True
        Me.lblsupervisor.Location = New System.Drawing.Point(15, 59)
        Me.lblsupervisor.Name = "lblsupervisor"
        Me.lblsupervisor.Size = New System.Drawing.Size(57, 13)
        Me.lblsupervisor.TabIndex = 77
        Me.lblsupervisor.Text = "Supervisor"
        '
        'grbpersonal
        '
        Me.grbpersonal.BackColor = System.Drawing.Color.AntiqueWhite
        Me.grbpersonal.Controls.Add(Me.mtxcellphone)
        Me.grbpersonal.Controls.Add(Me.mtxworkphone)
        Me.grbpersonal.Controls.Add(Me.cboProv)
        Me.grbpersonal.Controls.Add(Me.txtemail)
        Me.grbpersonal.Controls.Add(Me.txtpostal)
        Me.grbpersonal.Controls.Add(Me.txtcity)
        Me.grbpersonal.Controls.Add(Me.txtstreetaddress)
        Me.grbpersonal.Controls.Add(Me.lblemail)
        Me.grbpersonal.Controls.Add(Me.lblcellphone)
        Me.grbpersonal.Controls.Add(Me.lblworkphone)
        Me.grbpersonal.Controls.Add(Me.lblpostal)
        Me.grbpersonal.Controls.Add(Me.lblcity)
        Me.grbpersonal.Controls.Add(Me.lblprov)
        Me.grbpersonal.Controls.Add(Me.lblstreetaddress)
        Me.grbpersonal.Controls.Add(Me.dtpdateofbirth)
        Me.grbpersonal.Controls.Add(Me.lbldob)
        Me.grbpersonal.Controls.Add(Me.txtmiddleinit)
        Me.grbpersonal.Controls.Add(Me.txtlastname)
        Me.grbpersonal.Controls.Add(Me.txtfirstname)
        Me.grbpersonal.Controls.Add(Me.lblfirstname)
        Me.grbpersonal.Controls.Add(Me.lblmiddleint)
        Me.grbpersonal.Controls.Add(Me.lbllastname)
        Me.grbpersonal.Location = New System.Drawing.Point(17, 18)
        Me.grbpersonal.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.grbpersonal.Name = "grbpersonal"
        Me.grbpersonal.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.grbpersonal.Size = New System.Drawing.Size(740, 139)
        Me.grbpersonal.TabIndex = 18
        Me.grbpersonal.TabStop = False
        Me.grbpersonal.Text = "Personal Info"
        '
        'mtxcellphone
        '
        Me.mtxcellphone.Location = New System.Drawing.Point(509, 48)
        Me.mtxcellphone.Mask = "(999) 000-0000"
        Me.mtxcellphone.Name = "mtxcellphone"
        Me.mtxcellphone.Size = New System.Drawing.Size(100, 20)
        Me.mtxcellphone.TabIndex = 83
        '
        'mtxworkphone
        '
        Me.mtxworkphone.Location = New System.Drawing.Point(509, 25)
        Me.mtxworkphone.Mask = "(999) 000-0000"
        Me.mtxworkphone.Name = "mtxworkphone"
        Me.mtxworkphone.Size = New System.Drawing.Size(100, 20)
        Me.mtxworkphone.TabIndex = 82
        '
        'cboProv
        '
        Me.cboProv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProv.FormattingEnabled = True
        Me.cboProv.Items.AddRange(New Object() {"NB", "NS", "PE", "NF", "QC", "ON"})
        Me.cboProv.Location = New System.Drawing.Point(306, 74)
        Me.cboProv.Name = "cboProv"
        Me.cboProv.Size = New System.Drawing.Size(121, 21)
        Me.cboProv.TabIndex = 81
        '
        'txtemail
        '
        Me.txtemail.Location = New System.Drawing.Point(509, 71)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(100, 20)
        Me.txtemail.TabIndex = 80
        '
        'txtpostal
        '
        Me.txtpostal.Location = New System.Drawing.Point(306, 99)
        Me.txtpostal.Name = "txtpostal"
        Me.txtpostal.Size = New System.Drawing.Size(121, 20)
        Me.txtpostal.TabIndex = 79
        '
        'txtcity
        '
        Me.txtcity.Location = New System.Drawing.Point(306, 53)
        Me.txtcity.Name = "txtcity"
        Me.txtcity.Size = New System.Drawing.Size(125, 20)
        Me.txtcity.TabIndex = 78
        '
        'txtstreetaddress
        '
        Me.txtstreetaddress.Location = New System.Drawing.Point(306, 29)
        Me.txtstreetaddress.Name = "txtstreetaddress"
        Me.txtstreetaddress.Size = New System.Drawing.Size(125, 20)
        Me.txtstreetaddress.TabIndex = 77
        '
        'lblemail
        '
        Me.lblemail.AutoSize = True
        Me.lblemail.Location = New System.Drawing.Point(466, 73)
        Me.lblemail.Name = "lblemail"
        Me.lblemail.Size = New System.Drawing.Size(32, 13)
        Me.lblemail.TabIndex = 76
        Me.lblemail.Text = "Email"
        '
        'lblcellphone
        '
        Me.lblcellphone.AutoSize = True
        Me.lblcellphone.Location = New System.Drawing.Point(443, 50)
        Me.lblcellphone.Name = "lblcellphone"
        Me.lblcellphone.Size = New System.Drawing.Size(57, 13)
        Me.lblcellphone.TabIndex = 75
        Me.lblcellphone.Text = "Cell phone"
        '
        'lblworkphone
        '
        Me.lblworkphone.AutoSize = True
        Me.lblworkphone.Location = New System.Drawing.Point(435, 29)
        Me.lblworkphone.Name = "lblworkphone"
        Me.lblworkphone.Size = New System.Drawing.Size(67, 13)
        Me.lblworkphone.TabIndex = 74
        Me.lblworkphone.Text = "Work Phone"
        '
        'lblpostal
        '
        Me.lblpostal.AutoSize = True
        Me.lblpostal.Location = New System.Drawing.Point(235, 101)
        Me.lblpostal.Name = "lblpostal"
        Me.lblpostal.Size = New System.Drawing.Size(63, 13)
        Me.lblpostal.TabIndex = 73
        Me.lblpostal.Text = "Postal code"
        '
        'lblcity
        '
        Me.lblcity.AutoSize = True
        Me.lblcity.Location = New System.Drawing.Point(272, 55)
        Me.lblcity.Name = "lblcity"
        Me.lblcity.Size = New System.Drawing.Size(24, 13)
        Me.lblcity.TabIndex = 72
        Me.lblcity.Text = "City"
        '
        'lblprov
        '
        Me.lblprov.AutoSize = True
        Me.lblprov.Location = New System.Drawing.Point(247, 76)
        Me.lblprov.Name = "lblprov"
        Me.lblprov.Size = New System.Drawing.Size(49, 13)
        Me.lblprov.TabIndex = 71
        Me.lblprov.Text = "Province"
        '
        'lblstreetaddress
        '
        Me.lblstreetaddress.AutoSize = True
        Me.lblstreetaddress.Location = New System.Drawing.Point(219, 31)
        Me.lblstreetaddress.Name = "lblstreetaddress"
        Me.lblstreetaddress.Size = New System.Drawing.Size(76, 13)
        Me.lblstreetaddress.TabIndex = 70
        Me.lblstreetaddress.Text = "Street Address"
        '
        'dtpdateofbirth
        '
        Me.dtpdateofbirth.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpdateofbirth.Location = New System.Drawing.Point(88, 101)
        Me.dtpdateofbirth.Name = "dtpdateofbirth"
        Me.dtpdateofbirth.Size = New System.Drawing.Size(118, 20)
        Me.dtpdateofbirth.TabIndex = 68
        '
        'lbldob
        '
        Me.lbldob.AutoSize = True
        Me.lbldob.Location = New System.Drawing.Point(12, 103)
        Me.lbldob.Name = "lbldob"
        Me.lbldob.Size = New System.Drawing.Size(66, 13)
        Me.lbldob.TabIndex = 67
        Me.lbldob.Text = "Date of Birth"
        '
        'txtmiddleinit
        '
        Me.txtmiddleinit.Location = New System.Drawing.Point(87, 55)
        Me.txtmiddleinit.Name = "txtmiddleinit"
        Me.txtmiddleinit.Size = New System.Drawing.Size(119, 20)
        Me.txtmiddleinit.TabIndex = 62
        '
        'txtlastname
        '
        Me.txtlastname.Location = New System.Drawing.Point(87, 76)
        Me.txtlastname.Name = "txtlastname"
        Me.txtlastname.Size = New System.Drawing.Size(119, 20)
        Me.txtlastname.TabIndex = 61
        '
        'txtfirstname
        '
        Me.txtfirstname.Location = New System.Drawing.Point(86, 31)
        Me.txtfirstname.Name = "txtfirstname"
        Me.txtfirstname.Size = New System.Drawing.Size(120, 20)
        Me.txtfirstname.TabIndex = 60
        '
        'lblfirstname
        '
        Me.lblfirstname.AutoSize = True
        Me.lblfirstname.Location = New System.Drawing.Point(18, 32)
        Me.lblfirstname.Name = "lblfirstname"
        Me.lblfirstname.Size = New System.Drawing.Size(60, 13)
        Me.lblfirstname.TabIndex = 59
        Me.lblfirstname.Text = "First Name:"
        '
        'lblmiddleint
        '
        Me.lblmiddleint.AutoSize = True
        Me.lblmiddleint.Location = New System.Drawing.Point(14, 57)
        Me.lblmiddleint.Name = "lblmiddleint"
        Me.lblmiddleint.Size = New System.Drawing.Size(65, 13)
        Me.lblmiddleint.TabIndex = 58
        Me.lblmiddleint.Text = "Middle Initial"
        '
        'lbllastname
        '
        Me.lbllastname.AutoSize = True
        Me.lbllastname.Location = New System.Drawing.Point(18, 78)
        Me.lbllastname.Name = "lbllastname"
        Me.lbllastname.Size = New System.Drawing.Size(61, 13)
        Me.lbllastname.TabIndex = 57
        Me.lbllastname.Text = "Last Name:"
        '
        'grbsearch
        '
        Me.grbsearch.Controls.Add(Me.btnsearch)
        Me.grbsearch.Controls.Add(Me.txtsearchlname)
        Me.grbsearch.Controls.Add(Me.txtsearchid)
        Me.grbsearch.Controls.Add(Me.Label2)
        Me.grbsearch.Controls.Add(Me.Label1)
        Me.grbsearch.Location = New System.Drawing.Point(5, 9)
        Me.grbsearch.Name = "grbsearch"
        Me.grbsearch.Size = New System.Drawing.Size(330, 111)
        Me.grbsearch.TabIndex = 11
        Me.grbsearch.TabStop = False
        Me.grbsearch.Text = "Search"
        '
        'btnsearch
        '
        Me.btnsearch.Location = New System.Drawing.Point(207, 28)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(97, 42)
        Me.btnsearch.TabIndex = 4
        Me.btnsearch.Text = "Search"
        Me.btnsearch.UseVisualStyleBackColor = True
        '
        'txtsearchlname
        '
        Me.txtsearchlname.Location = New System.Drawing.Point(95, 53)
        Me.txtsearchlname.Name = "txtsearchlname"
        Me.txtsearchlname.Size = New System.Drawing.Size(100, 20)
        Me.txtsearchlname.TabIndex = 3
        '
        'txtsearchid
        '
        Me.txtsearchid.Location = New System.Drawing.Point(95, 28)
        Me.txtsearchid.Name = "txtsearchid"
        Me.txtsearchid.Size = New System.Drawing.Size(100, 20)
        Me.txtsearchid.TabIndex = 2
        Me.txtsearchid.Text = "10000001"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Last name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Employee Id:"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.grbsearchresults)
        Me.GroupBox1.Controls.Add(Me.grbempinfo)
        Me.GroupBox1.Controls.Add(Me.grbsearch)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 0)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(788, 607)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        '
        'EditEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(809, 621)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "EditEmployee"
        Me.Text = "EditEmployee"
        Me.grbsearchresults.ResumeLayout(False)
        Me.grbsearchresults.PerformLayout()
        Me.grbempinfo.ResumeLayout(False)
        Me.grbempinfo.PerformLayout()
        Me.grbemployment.ResumeLayout(False)
        Me.grbemployment.PerformLayout()
        Me.grbjob.ResumeLayout(False)
        Me.grbjob.PerformLayout()
        Me.grbpersonal.ResumeLayout(False)
        Me.grbpersonal.PerformLayout()
        Me.grbsearch.ResumeLayout(False)
        Me.grbsearch.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblnomatches As System.Windows.Forms.Label
    Friend WithEvents grbsearchresults As System.Windows.Forms.GroupBox
    Friend WithEvents btnselect As System.Windows.Forms.Button
    Friend WithEvents lstsearchresults As System.Windows.Forms.ListBox
    Friend WithEvents grbempinfo As System.Windows.Forms.GroupBox
    Friend WithEvents grbsearch As System.Windows.Forms.GroupBox
    Friend WithEvents btnsearch As System.Windows.Forms.Button
    Friend WithEvents txtsearchlname As System.Windows.Forms.TextBox
    Friend WithEvents txtsearchid As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents lbldebug As System.Windows.Forms.Label
    Friend WithEvents grbemployment As System.Windows.Forms.GroupBox
    Friend WithEvents txtempid As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtsin As System.Windows.Forms.TextBox
    Friend WithEvents lblsin As System.Windows.Forms.Label
    Friend WithEvents chkemailstub As System.Windows.Forms.CheckBox
    Friend WithEvents lblsenoritydate As System.Windows.Forms.Label
    Friend WithEvents dtpsenority As System.Windows.Forms.DateTimePicker
    Friend WithEvents rdostatusTerminated As System.Windows.Forms.RadioButton
    Friend WithEvents rdostatusRetired As System.Windows.Forms.RadioButton
    Friend WithEvents rdostatusActive As System.Windows.Forms.RadioButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtpterminationdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents grbjob As System.Windows.Forms.GroupBox
    Friend WithEvents lblsuperid As System.Windows.Forms.Label
    Friend WithEvents lblstartdate As System.Windows.Forms.Label
    Friend WithEvents dtpstartdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblsuper As System.Windows.Forms.Label
    Friend WithEvents cbojobid As System.Windows.Forms.ComboBox
    Friend WithEvents cbodept As System.Windows.Forms.ComboBox
    Friend WithEvents txtpayrate As System.Windows.Forms.TextBox
    Friend WithEvents lblpayrate As System.Windows.Forms.Label
    Friend WithEvents lbljobid As System.Windows.Forms.Label
    Friend WithEvents lbldept As System.Windows.Forms.Label
    Friend WithEvents lblsupervisor As System.Windows.Forms.Label
    Friend WithEvents grbpersonal As System.Windows.Forms.GroupBox
    Friend WithEvents mtxcellphone As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mtxworkphone As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cboProv As System.Windows.Forms.ComboBox
    Friend WithEvents txtemail As System.Windows.Forms.TextBox
    Friend WithEvents txtpostal As System.Windows.Forms.TextBox
    Friend WithEvents txtcity As System.Windows.Forms.TextBox
    Friend WithEvents txtstreetaddress As System.Windows.Forms.TextBox
    Friend WithEvents lblemail As System.Windows.Forms.Label
    Friend WithEvents lblcellphone As System.Windows.Forms.Label
    Friend WithEvents lblworkphone As System.Windows.Forms.Label
    Friend WithEvents lblpostal As System.Windows.Forms.Label
    Friend WithEvents lblcity As System.Windows.Forms.Label
    Friend WithEvents lblprov As System.Windows.Forms.Label
    Friend WithEvents lblstreetaddress As System.Windows.Forms.Label
    Friend WithEvents dtpdateofbirth As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbldob As System.Windows.Forms.Label
    Friend WithEvents txtmiddleinit As System.Windows.Forms.TextBox
    Friend WithEvents txtlastname As System.Windows.Forms.TextBox
    Friend WithEvents txtfirstname As System.Windows.Forms.TextBox
    Friend WithEvents lblfirstname As System.Windows.Forms.Label
    Friend WithEvents lblmiddleint As System.Windows.Forms.Label
    Friend WithEvents lbllastname As System.Windows.Forms.Label
    Friend WithEvents btneditemploymentinfo As System.Windows.Forms.Button
    Friend WithEvents btneditjobinfo As System.Windows.Forms.Button
End Class
