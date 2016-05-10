<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RetrieveEmployee
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
        Me.grbsearch = New System.Windows.Forms.GroupBox()
        Me.btnsearch = New System.Windows.Forms.Button()
        Me.txtsearchlname = New System.Windows.Forms.TextBox()
        Me.txtsearchid = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grbempinfo = New System.Windows.Forms.GroupBox()
        Me.rdostatusTerminated = New System.Windows.Forms.RadioButton()
        Me.rdostatusRetired = New System.Windows.Forms.RadioButton()
        Me.rdostatusActive = New System.Windows.Forms.RadioButton()
        Me.lblsuper = New System.Windows.Forms.Label()
        Me.lbltermination = New System.Windows.Forms.Label()
        Me.lblstartdate = New System.Windows.Forms.Label()
        Me.lblsenoritydate = New System.Windows.Forms.Label()
        Me.dtpterminationdate = New System.Windows.Forms.DateTimePicker()
        Me.dtpstartdate = New System.Windows.Forms.DateTimePicker()
        Me.dtpsenority = New System.Windows.Forms.DateTimePicker()
        Me.mtxcellphone = New System.Windows.Forms.MaskedTextBox()
        Me.mtxworkphone = New System.Windows.Forms.MaskedTextBox()
        Me.cboProv = New System.Windows.Forms.ComboBox()
        Me.dtpdateofbirth = New System.Windows.Forms.DateTimePicker()
        Me.cbojobid = New System.Windows.Forms.ComboBox()
        Me.cbodept = New System.Windows.Forms.ComboBox()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.txtpayrate = New System.Windows.Forms.TextBox()
        Me.txtpostal = New System.Windows.Forms.TextBox()
        Me.txtcity = New System.Windows.Forms.TextBox()
        Me.txtsin = New System.Windows.Forms.TextBox()
        Me.txtstreetaddress = New System.Windows.Forms.TextBox()
        Me.txtmiddleinit = New System.Windows.Forms.TextBox()
        Me.txtlastname = New System.Windows.Forms.TextBox()
        Me.txtfirstname = New System.Windows.Forms.TextBox()
        Me.lblpayrate = New System.Windows.Forms.Label()
        Me.lbljobid = New System.Windows.Forms.Label()
        Me.lbldept = New System.Windows.Forms.Label()
        Me.lblsupervisor = New System.Windows.Forms.Label()
        Me.lblsin = New System.Windows.Forms.Label()
        Me.lblemail = New System.Windows.Forms.Label()
        Me.lblcellphone = New System.Windows.Forms.Label()
        Me.lblworkphone = New System.Windows.Forms.Label()
        Me.lblpostal = New System.Windows.Forms.Label()
        Me.lblcity = New System.Windows.Forms.Label()
        Me.lblprov = New System.Windows.Forms.Label()
        Me.lblstreetaddress = New System.Windows.Forms.Label()
        Me.lbldob = New System.Windows.Forms.Label()
        Me.lblfirstname = New System.Windows.Forms.Label()
        Me.lblmiddleint = New System.Windows.Forms.Label()
        Me.lbllastname = New System.Windows.Forms.Label()
        Me.lbldebug = New System.Windows.Forms.Label()
        Me.grbsearchresults = New System.Windows.Forms.GroupBox()
        Me.btnselect = New System.Windows.Forms.Button()
        Me.lstsearchresults = New System.Windows.Forms.ListBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.lblnomatches = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.grbsearch.SuspendLayout()
        Me.grbempinfo.SuspendLayout()
        Me.grbsearchresults.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grbsearch
        '
        Me.grbsearch.Controls.Add(Me.btnsearch)
        Me.grbsearch.Controls.Add(Me.txtsearchlname)
        Me.grbsearch.Controls.Add(Me.txtsearchid)
        Me.grbsearch.Controls.Add(Me.Label2)
        Me.grbsearch.Controls.Add(Me.Label1)
        Me.grbsearch.Location = New System.Drawing.Point(10, 11)
        Me.grbsearch.Name = "grbsearch"
        Me.grbsearch.Size = New System.Drawing.Size(330, 90)
        Me.grbsearch.TabIndex = 0
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
        'grbempinfo
        '
        Me.grbempinfo.Controls.Add(Me.rdostatusTerminated)
        Me.grbempinfo.Controls.Add(Me.rdostatusRetired)
        Me.grbempinfo.Controls.Add(Me.rdostatusActive)
        Me.grbempinfo.Controls.Add(Me.lblsuper)
        Me.grbempinfo.Controls.Add(Me.lbltermination)
        Me.grbempinfo.Controls.Add(Me.lblstartdate)
        Me.grbempinfo.Controls.Add(Me.lblsenoritydate)
        Me.grbempinfo.Controls.Add(Me.dtpterminationdate)
        Me.grbempinfo.Controls.Add(Me.dtpstartdate)
        Me.grbempinfo.Controls.Add(Me.dtpsenority)
        Me.grbempinfo.Controls.Add(Me.mtxcellphone)
        Me.grbempinfo.Controls.Add(Me.mtxworkphone)
        Me.grbempinfo.Controls.Add(Me.cboProv)
        Me.grbempinfo.Controls.Add(Me.dtpdateofbirth)
        Me.grbempinfo.Controls.Add(Me.cbojobid)
        Me.grbempinfo.Controls.Add(Me.cbodept)
        Me.grbempinfo.Controls.Add(Me.txtemail)
        Me.grbempinfo.Controls.Add(Me.txtpayrate)
        Me.grbempinfo.Controls.Add(Me.txtpostal)
        Me.grbempinfo.Controls.Add(Me.txtcity)
        Me.grbempinfo.Controls.Add(Me.txtsin)
        Me.grbempinfo.Controls.Add(Me.txtstreetaddress)
        Me.grbempinfo.Controls.Add(Me.txtmiddleinit)
        Me.grbempinfo.Controls.Add(Me.txtlastname)
        Me.grbempinfo.Controls.Add(Me.txtfirstname)
        Me.grbempinfo.Controls.Add(Me.lblpayrate)
        Me.grbempinfo.Controls.Add(Me.lbljobid)
        Me.grbempinfo.Controls.Add(Me.lbldept)
        Me.grbempinfo.Controls.Add(Me.lblsupervisor)
        Me.grbempinfo.Controls.Add(Me.lblsin)
        Me.grbempinfo.Controls.Add(Me.lblemail)
        Me.grbempinfo.Controls.Add(Me.lblcellphone)
        Me.grbempinfo.Controls.Add(Me.lblworkphone)
        Me.grbempinfo.Controls.Add(Me.lblpostal)
        Me.grbempinfo.Controls.Add(Me.lblcity)
        Me.grbempinfo.Controls.Add(Me.lblprov)
        Me.grbempinfo.Controls.Add(Me.lblstreetaddress)
        Me.grbempinfo.Controls.Add(Me.lbldob)
        Me.grbempinfo.Controls.Add(Me.lblfirstname)
        Me.grbempinfo.Controls.Add(Me.lblmiddleint)
        Me.grbempinfo.Controls.Add(Me.lbllastname)
        Me.grbempinfo.Location = New System.Drawing.Point(11, 129)
        Me.grbempinfo.Name = "grbempinfo"
        Me.grbempinfo.Size = New System.Drawing.Size(767, 233)
        Me.grbempinfo.TabIndex = 1
        Me.grbempinfo.TabStop = False
        Me.grbempinfo.Text = "Employee Info"
        '
        'rdostatusTerminated
        '
        Me.rdostatusTerminated.AutoSize = True
        Me.rdostatusTerminated.Location = New System.Drawing.Point(81, 191)
        Me.rdostatusTerminated.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rdostatusTerminated.Name = "rdostatusTerminated"
        Me.rdostatusTerminated.Size = New System.Drawing.Size(78, 17)
        Me.rdostatusTerminated.TabIndex = 79
        Me.rdostatusTerminated.TabStop = True
        Me.rdostatusTerminated.Text = "Terminated"
        Me.rdostatusTerminated.UseVisualStyleBackColor = True
        '
        'rdostatusRetired
        '
        Me.rdostatusRetired.AutoSize = True
        Me.rdostatusRetired.Location = New System.Drawing.Point(81, 172)
        Me.rdostatusRetired.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rdostatusRetired.Name = "rdostatusRetired"
        Me.rdostatusRetired.Size = New System.Drawing.Size(59, 17)
        Me.rdostatusRetired.TabIndex = 78
        Me.rdostatusRetired.TabStop = True
        Me.rdostatusRetired.Text = "Retired"
        Me.rdostatusRetired.UseVisualStyleBackColor = True
        '
        'rdostatusActive
        '
        Me.rdostatusActive.AutoSize = True
        Me.rdostatusActive.Location = New System.Drawing.Point(81, 152)
        Me.rdostatusActive.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rdostatusActive.Name = "rdostatusActive"
        Me.rdostatusActive.Size = New System.Drawing.Size(55, 17)
        Me.rdostatusActive.TabIndex = 77
        Me.rdostatusActive.TabStop = True
        Me.rdostatusActive.Text = "Active"
        Me.rdostatusActive.UseVisualStyleBackColor = True
        '
        'lblsuper
        '
        Me.lblsuper.AutoSize = True
        Me.lblsuper.Location = New System.Drawing.Point(571, 49)
        Me.lblsuper.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblsuper.Name = "lblsuper"
        Me.lblsuper.Size = New System.Drawing.Size(39, 13)
        Me.lblsuper.TabIndex = 76
        Me.lblsuper.Text = "Label3"
        '
        'lbltermination
        '
        Me.lbltermination.AutoSize = True
        Me.lbltermination.Location = New System.Drawing.Point(33, 153)
        Me.lbltermination.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbltermination.Name = "lbltermination"
        Me.lbltermination.Size = New System.Drawing.Size(40, 13)
        Me.lbltermination.TabIndex = 75
        Me.lbltermination.Text = "Status:"
        '
        'lblstartdate
        '
        Me.lblstartdate.AutoSize = True
        Me.lblstartdate.Location = New System.Drawing.Point(503, 178)
        Me.lblstartdate.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblstartdate.Name = "lblstartdate"
        Me.lblstartdate.Size = New System.Drawing.Size(58, 13)
        Me.lblstartdate.TabIndex = 74
        Me.lblstartdate.Text = "Start Date:"
        '
        'lblsenoritydate
        '
        Me.lblsenoritydate.AutoSize = True
        Me.lblsenoritydate.Location = New System.Drawing.Point(487, 155)
        Me.lblsenoritydate.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblsenoritydate.Name = "lblsenoritydate"
        Me.lblsenoritydate.Size = New System.Drawing.Size(73, 13)
        Me.lblsenoritydate.TabIndex = 73
        Me.lblsenoritydate.Text = "Seniority Date"
        '
        'dtpterminationdate
        '
        Me.dtpterminationdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpterminationdate.Location = New System.Drawing.Point(161, 172)
        Me.dtpterminationdate.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtpterminationdate.Name = "dtpterminationdate"
        Me.dtpterminationdate.Size = New System.Drawing.Size(93, 20)
        Me.dtpterminationdate.TabIndex = 72
        '
        'dtpstartdate
        '
        Me.dtpstartdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpstartdate.Location = New System.Drawing.Point(571, 175)
        Me.dtpstartdate.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtpstartdate.Name = "dtpstartdate"
        Me.dtpstartdate.Size = New System.Drawing.Size(93, 20)
        Me.dtpstartdate.TabIndex = 71
        '
        'dtpsenority
        '
        Me.dtpsenority.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpsenority.Location = New System.Drawing.Point(571, 151)
        Me.dtpsenority.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtpsenority.Name = "dtpsenority"
        Me.dtpsenority.Size = New System.Drawing.Size(97, 20)
        Me.dtpsenority.TabIndex = 70
        '
        'mtxcellphone
        '
        Me.mtxcellphone.Location = New System.Drawing.Point(314, 144)
        Me.mtxcellphone.Mask = "(999) 000-0000"
        Me.mtxcellphone.Name = "mtxcellphone"
        Me.mtxcellphone.Size = New System.Drawing.Size(100, 20)
        Me.mtxcellphone.TabIndex = 69
        '
        'mtxworkphone
        '
        Me.mtxworkphone.Location = New System.Drawing.Point(314, 121)
        Me.mtxworkphone.Mask = "(999) 000-0000"
        Me.mtxworkphone.Name = "mtxworkphone"
        Me.mtxworkphone.Size = New System.Drawing.Size(100, 20)
        Me.mtxworkphone.TabIndex = 68
        '
        'cboProv
        '
        Me.cboProv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProv.FormattingEnabled = True
        Me.cboProv.Items.AddRange(New Object() {"NB", "NS", "PE", "NF", "QC", "ON"})
        Me.cboProv.Location = New System.Drawing.Point(314, 73)
        Me.cboProv.Name = "cboProv"
        Me.cboProv.Size = New System.Drawing.Size(121, 21)
        Me.cboProv.TabIndex = 67
        '
        'dtpdateofbirth
        '
        Me.dtpdateofbirth.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpdateofbirth.Location = New System.Drawing.Point(82, 97)
        Me.dtpdateofbirth.Name = "dtpdateofbirth"
        Me.dtpdateofbirth.Size = New System.Drawing.Size(83, 20)
        Me.dtpdateofbirth.TabIndex = 66
        '
        'cbojobid
        '
        Me.cbojobid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbojobid.FormattingEnabled = True
        Me.cbojobid.Location = New System.Drawing.Point(571, 75)
        Me.cbojobid.Name = "cbojobid"
        Me.cbojobid.Size = New System.Drawing.Size(175, 21)
        Me.cbojobid.TabIndex = 65
        '
        'cbodept
        '
        Me.cbodept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbodept.FormattingEnabled = True
        Me.cbodept.Location = New System.Drawing.Point(571, 25)
        Me.cbodept.Name = "cbodept"
        Me.cbodept.Size = New System.Drawing.Size(175, 21)
        Me.cbodept.TabIndex = 64
        '
        'txtemail
        '
        Me.txtemail.Location = New System.Drawing.Point(314, 167)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(125, 20)
        Me.txtemail.TabIndex = 62
        '
        'txtpayrate
        '
        Me.txtpayrate.Location = New System.Drawing.Point(571, 120)
        Me.txtpayrate.Name = "txtpayrate"
        Me.txtpayrate.Size = New System.Drawing.Size(48, 20)
        Me.txtpayrate.TabIndex = 61
        '
        'txtpostal
        '
        Me.txtpostal.Location = New System.Drawing.Point(314, 98)
        Me.txtpostal.Name = "txtpostal"
        Me.txtpostal.Size = New System.Drawing.Size(52, 20)
        Me.txtpostal.TabIndex = 60
        '
        'txtcity
        '
        Me.txtcity.Location = New System.Drawing.Point(314, 52)
        Me.txtcity.Name = "txtcity"
        Me.txtcity.Size = New System.Drawing.Size(125, 20)
        Me.txtcity.TabIndex = 59
        '
        'txtsin
        '
        Me.txtsin.Location = New System.Drawing.Point(81, 120)
        Me.txtsin.Name = "txtsin"
        Me.txtsin.Size = New System.Drawing.Size(120, 20)
        Me.txtsin.TabIndex = 58
        '
        'txtstreetaddress
        '
        Me.txtstreetaddress.Location = New System.Drawing.Point(314, 28)
        Me.txtstreetaddress.Name = "txtstreetaddress"
        Me.txtstreetaddress.Size = New System.Drawing.Size(125, 20)
        Me.txtstreetaddress.TabIndex = 57
        '
        'txtmiddleinit
        '
        Me.txtmiddleinit.Location = New System.Drawing.Point(82, 50)
        Me.txtmiddleinit.Name = "txtmiddleinit"
        Me.txtmiddleinit.Size = New System.Drawing.Size(45, 20)
        Me.txtmiddleinit.TabIndex = 56
        '
        'txtlastname
        '
        Me.txtlastname.Location = New System.Drawing.Point(82, 71)
        Me.txtlastname.Name = "txtlastname"
        Me.txtlastname.Size = New System.Drawing.Size(119, 20)
        Me.txtlastname.TabIndex = 55
        '
        'txtfirstname
        '
        Me.txtfirstname.Location = New System.Drawing.Point(81, 26)
        Me.txtfirstname.Name = "txtfirstname"
        Me.txtfirstname.Size = New System.Drawing.Size(120, 20)
        Me.txtfirstname.TabIndex = 54
        '
        'lblpayrate
        '
        Me.lblpayrate.AutoSize = True
        Me.lblpayrate.Location = New System.Drawing.Point(498, 120)
        Me.lblpayrate.Name = "lblpayrate"
        Me.lblpayrate.Size = New System.Drawing.Size(46, 13)
        Me.lblpayrate.TabIndex = 53
        Me.lblpayrate.Text = "Payrate:"
        '
        'lbljobid
        '
        Me.lbljobid.AutoSize = True
        Me.lbljobid.Location = New System.Drawing.Point(511, 79)
        Me.lbljobid.Name = "lbljobid"
        Me.lbljobid.Size = New System.Drawing.Size(32, 13)
        Me.lbljobid.TabIndex = 52
        Me.lbljobid.Text = "Jobs:"
        '
        'lbldept
        '
        Me.lbldept.AutoSize = True
        Me.lbldept.Location = New System.Drawing.Point(480, 28)
        Me.lbldept.Name = "lbldept"
        Me.lbldept.Size = New System.Drawing.Size(62, 13)
        Me.lbldept.TabIndex = 51
        Me.lbldept.Text = "Department"
        '
        'lblsupervisor
        '
        Me.lblsupervisor.AutoSize = True
        Me.lblsupervisor.Location = New System.Drawing.Point(487, 54)
        Me.lblsupervisor.Name = "lblsupervisor"
        Me.lblsupervisor.Size = New System.Drawing.Size(57, 13)
        Me.lblsupervisor.TabIndex = 50
        Me.lblsupervisor.Text = "Supervisor"
        '
        'lblsin
        '
        Me.lblsin.AutoSize = True
        Me.lblsin.Location = New System.Drawing.Point(38, 123)
        Me.lblsin.Name = "lblsin"
        Me.lblsin.Size = New System.Drawing.Size(38, 13)
        Me.lblsin.TabIndex = 49
        Me.lblsin.Text = "SIN #:"
        '
        'lblemail
        '
        Me.lblemail.AutoSize = True
        Me.lblemail.Location = New System.Drawing.Point(271, 168)
        Me.lblemail.Name = "lblemail"
        Me.lblemail.Size = New System.Drawing.Size(32, 13)
        Me.lblemail.TabIndex = 48
        Me.lblemail.Text = "Email"
        '
        'lblcellphone
        '
        Me.lblcellphone.AutoSize = True
        Me.lblcellphone.Location = New System.Drawing.Point(248, 146)
        Me.lblcellphone.Name = "lblcellphone"
        Me.lblcellphone.Size = New System.Drawing.Size(57, 13)
        Me.lblcellphone.TabIndex = 47
        Me.lblcellphone.Text = "Cell phone"
        '
        'lblworkphone
        '
        Me.lblworkphone.AutoSize = True
        Me.lblworkphone.Location = New System.Drawing.Point(240, 124)
        Me.lblworkphone.Name = "lblworkphone"
        Me.lblworkphone.Size = New System.Drawing.Size(67, 13)
        Me.lblworkphone.TabIndex = 46
        Me.lblworkphone.Text = "Work Phone"
        '
        'lblpostal
        '
        Me.lblpostal.AutoSize = True
        Me.lblpostal.Location = New System.Drawing.Point(243, 101)
        Me.lblpostal.Name = "lblpostal"
        Me.lblpostal.Size = New System.Drawing.Size(63, 13)
        Me.lblpostal.TabIndex = 45
        Me.lblpostal.Text = "Postal code"
        '
        'lblcity
        '
        Me.lblcity.AutoSize = True
        Me.lblcity.Location = New System.Drawing.Point(280, 54)
        Me.lblcity.Name = "lblcity"
        Me.lblcity.Size = New System.Drawing.Size(24, 13)
        Me.lblcity.TabIndex = 44
        Me.lblcity.Text = "City"
        '
        'lblprov
        '
        Me.lblprov.AutoSize = True
        Me.lblprov.Location = New System.Drawing.Point(255, 75)
        Me.lblprov.Name = "lblprov"
        Me.lblprov.Size = New System.Drawing.Size(49, 13)
        Me.lblprov.TabIndex = 43
        Me.lblprov.Text = "Province"
        '
        'lblstreetaddress
        '
        Me.lblstreetaddress.AutoSize = True
        Me.lblstreetaddress.Location = New System.Drawing.Point(227, 30)
        Me.lblstreetaddress.Name = "lblstreetaddress"
        Me.lblstreetaddress.Size = New System.Drawing.Size(76, 13)
        Me.lblstreetaddress.TabIndex = 42
        Me.lblstreetaddress.Text = "Street Address"
        '
        'lbldob
        '
        Me.lbldob.AutoSize = True
        Me.lbldob.Location = New System.Drawing.Point(7, 98)
        Me.lbldob.Name = "lbldob"
        Me.lbldob.Size = New System.Drawing.Size(66, 13)
        Me.lbldob.TabIndex = 41
        Me.lbldob.Text = "Date of Birth"
        '
        'lblfirstname
        '
        Me.lblfirstname.AutoSize = True
        Me.lblfirstname.Location = New System.Drawing.Point(13, 28)
        Me.lblfirstname.Name = "lblfirstname"
        Me.lblfirstname.Size = New System.Drawing.Size(60, 13)
        Me.lblfirstname.TabIndex = 40
        Me.lblfirstname.Text = "First Name:"
        '
        'lblmiddleint
        '
        Me.lblmiddleint.AutoSize = True
        Me.lblmiddleint.Location = New System.Drawing.Point(9, 52)
        Me.lblmiddleint.Name = "lblmiddleint"
        Me.lblmiddleint.Size = New System.Drawing.Size(65, 13)
        Me.lblmiddleint.TabIndex = 39
        Me.lblmiddleint.Text = "Middle Initial"
        '
        'lbllastname
        '
        Me.lbllastname.AutoSize = True
        Me.lbllastname.Location = New System.Drawing.Point(13, 73)
        Me.lbllastname.Name = "lbllastname"
        Me.lbllastname.Size = New System.Drawing.Size(61, 13)
        Me.lbllastname.TabIndex = 38
        Me.lbllastname.Text = "Last Name:"
        '
        'lbldebug
        '
        Me.lbldebug.AutoSize = True
        Me.lbldebug.Location = New System.Drawing.Point(117, 414)
        Me.lbldebug.Name = "lbldebug"
        Me.lbldebug.Size = New System.Drawing.Size(39, 13)
        Me.lbldebug.TabIndex = 2
        Me.lbldebug.Text = "Label3"
        '
        'grbsearchresults
        '
        Me.grbsearchresults.Controls.Add(Me.btnselect)
        Me.grbsearchresults.Controls.Add(Me.lstsearchresults)
        Me.grbsearchresults.Location = New System.Drawing.Point(353, 11)
        Me.grbsearchresults.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.grbsearchresults.Name = "grbsearchresults"
        Me.grbsearchresults.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.grbsearchresults.Size = New System.Drawing.Size(397, 90)
        Me.grbsearchresults.TabIndex = 3
        Me.grbsearchresults.TabStop = False
        Me.grbsearchresults.Text = "Results"
        '
        'btnselect
        '
        Me.btnselect.Location = New System.Drawing.Point(257, 20)
        Me.btnselect.Name = "btnselect"
        Me.btnselect.Size = New System.Drawing.Size(120, 61)
        Me.btnselect.TabIndex = 8
        Me.btnselect.Text = "Select"
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
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'lblnomatches
        '
        Me.lblnomatches.AutoSize = True
        Me.lblnomatches.Location = New System.Drawing.Point(491, 103)
        Me.lblnomatches.Name = "lblnomatches"
        Me.lblnomatches.Size = New System.Drawing.Size(94, 13)
        Me.lblnomatches.TabIndex = 9
        Me.lblnomatches.Text = "No matches found"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(221, 383)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(92, 31)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'RetrieveEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(797, 532)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblnomatches)
        Me.Controls.Add(Me.grbsearchresults)
        Me.Controls.Add(Me.lbldebug)
        Me.Controls.Add(Me.grbempinfo)
        Me.Controls.Add(Me.grbsearch)
        Me.Name = "RetrieveEmployee"
        Me.Text = "RetrieveEmployee"
        Me.grbsearch.ResumeLayout(False)
        Me.grbsearch.PerformLayout()
        Me.grbempinfo.ResumeLayout(False)
        Me.grbempinfo.PerformLayout()
        Me.grbsearchresults.ResumeLayout(False)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grbsearch As System.Windows.Forms.GroupBox
    Friend WithEvents grbempinfo As System.Windows.Forms.GroupBox
    Friend WithEvents btnsearch As System.Windows.Forms.Button
    Friend WithEvents txtsearchlname As System.Windows.Forms.TextBox
    Friend WithEvents txtsearchid As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents mtxcellphone As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mtxworkphone As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cboProv As System.Windows.Forms.ComboBox
    Friend WithEvents dtpdateofbirth As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbojobid As System.Windows.Forms.ComboBox
    Friend WithEvents cbodept As System.Windows.Forms.ComboBox
    Friend WithEvents txtemail As System.Windows.Forms.TextBox
    Friend WithEvents txtpayrate As System.Windows.Forms.TextBox
    Friend WithEvents txtpostal As System.Windows.Forms.TextBox
    Friend WithEvents txtcity As System.Windows.Forms.TextBox
    Friend WithEvents txtsin As System.Windows.Forms.TextBox
    Friend WithEvents txtstreetaddress As System.Windows.Forms.TextBox
    Friend WithEvents txtmiddleinit As System.Windows.Forms.TextBox
    Friend WithEvents txtlastname As System.Windows.Forms.TextBox
    Friend WithEvents txtfirstname As System.Windows.Forms.TextBox
    Friend WithEvents lblpayrate As System.Windows.Forms.Label
    Friend WithEvents lbljobid As System.Windows.Forms.Label
    Friend WithEvents lbldept As System.Windows.Forms.Label
    Friend WithEvents lblsupervisor As System.Windows.Forms.Label
    Friend WithEvents lblsin As System.Windows.Forms.Label
    Friend WithEvents lblemail As System.Windows.Forms.Label
    Friend WithEvents lblcellphone As System.Windows.Forms.Label
    Friend WithEvents lblworkphone As System.Windows.Forms.Label
    Friend WithEvents lblpostal As System.Windows.Forms.Label
    Friend WithEvents lblcity As System.Windows.Forms.Label
    Friend WithEvents lblprov As System.Windows.Forms.Label
    Friend WithEvents lblstreetaddress As System.Windows.Forms.Label
    Friend WithEvents lbldob As System.Windows.Forms.Label
    Friend WithEvents lblfirstname As System.Windows.Forms.Label
    Friend WithEvents lblmiddleint As System.Windows.Forms.Label
    Friend WithEvents lbllastname As System.Windows.Forms.Label
    Friend WithEvents lbldebug As System.Windows.Forms.Label
    Friend WithEvents lbltermination As System.Windows.Forms.Label
    Friend WithEvents lblstartdate As System.Windows.Forms.Label
    Friend WithEvents lblsenoritydate As System.Windows.Forms.Label
    Friend WithEvents dtpterminationdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpstartdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpsenority As System.Windows.Forms.DateTimePicker
    Friend WithEvents grbsearchresults As System.Windows.Forms.GroupBox
    Friend WithEvents btnselect As System.Windows.Forms.Button
    Friend WithEvents lstsearchresults As System.Windows.Forms.ListBox
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents lblnomatches As System.Windows.Forms.Label
    Friend WithEvents lblsuper As System.Windows.Forms.Label
    Friend WithEvents rdostatusTerminated As System.Windows.Forms.RadioButton
    Friend WithEvents rdostatusRetired As System.Windows.Forms.RadioButton
    Friend WithEvents rdostatusActive As System.Windows.Forms.RadioButton
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
