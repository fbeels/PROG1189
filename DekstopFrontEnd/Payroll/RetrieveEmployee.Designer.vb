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
        Me.chkreadonly = New System.Windows.Forms.CheckBox()
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
        Me.grbsearch.Location = New System.Drawing.Point(15, 17)
        Me.grbsearch.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grbsearch.Name = "grbsearch"
        Me.grbsearch.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grbsearch.Size = New System.Drawing.Size(495, 138)
        Me.grbsearch.TabIndex = 0
        Me.grbsearch.TabStop = False
        Me.grbsearch.Text = "Search"
        '
        'btnsearch
        '
        Me.btnsearch.Location = New System.Drawing.Point(311, 43)
        Me.btnsearch.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(146, 64)
        Me.btnsearch.TabIndex = 4
        Me.btnsearch.Text = "Search"
        Me.btnsearch.UseVisualStyleBackColor = True
        '
        'txtsearchlname
        '
        Me.txtsearchlname.Location = New System.Drawing.Point(143, 81)
        Me.txtsearchlname.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtsearchlname.Name = "txtsearchlname"
        Me.txtsearchlname.Size = New System.Drawing.Size(148, 26)
        Me.txtsearchlname.TabIndex = 3
        '
        'txtsearchid
        '
        Me.txtsearchid.Location = New System.Drawing.Point(143, 43)
        Me.txtsearchid.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtsearchid.Name = "txtsearchid"
        Me.txtsearchid.Size = New System.Drawing.Size(148, 26)
        Me.txtsearchid.TabIndex = 2
        Me.txtsearchid.Text = "10000001"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(51, 81)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Last name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 46)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Employee Id:"
        '
        'grbempinfo
        '
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
        Me.grbempinfo.Location = New System.Drawing.Point(16, 198)
        Me.grbempinfo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grbempinfo.Name = "grbempinfo"
        Me.grbempinfo.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grbempinfo.Size = New System.Drawing.Size(1150, 359)
        Me.grbempinfo.TabIndex = 1
        Me.grbempinfo.TabStop = False
        Me.grbempinfo.Text = "Employee Info"
        '
        'lblsuper
        '
        Me.lblsuper.AutoSize = True
        Me.lblsuper.Location = New System.Drawing.Point(857, 76)
        Me.lblsuper.Name = "lblsuper"
        Me.lblsuper.Size = New System.Drawing.Size(57, 20)
        Me.lblsuper.TabIndex = 76
        Me.lblsuper.Text = "Label3"
        '
        'lbltermination
        '
        Me.lbltermination.AutoSize = True
        Me.lbltermination.Location = New System.Drawing.Point(706, 306)
        Me.lbltermination.Name = "lbltermination"
        Me.lbltermination.Size = New System.Drawing.Size(135, 20)
        Me.lbltermination.TabIndex = 75
        Me.lbltermination.Text = "Termination Date:"
        '
        'lblstartdate
        '
        Me.lblstartdate.AutoSize = True
        Me.lblstartdate.Location = New System.Drawing.Point(754, 274)
        Me.lblstartdate.Name = "lblstartdate"
        Me.lblstartdate.Size = New System.Drawing.Size(87, 20)
        Me.lblstartdate.TabIndex = 74
        Me.lblstartdate.Text = "Start Date:"
        '
        'lblsenoritydate
        '
        Me.lblsenoritydate.AutoSize = True
        Me.lblsenoritydate.Location = New System.Drawing.Point(730, 238)
        Me.lblsenoritydate.Name = "lblsenoritydate"
        Me.lblsenoritydate.Size = New System.Drawing.Size(111, 20)
        Me.lblsenoritydate.TabIndex = 73
        Me.lblsenoritydate.Text = "Seniority DAte"
        '
        'dtpterminationdate
        '
        Me.dtpterminationdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpterminationdate.Location = New System.Drawing.Point(856, 301)
        Me.dtpterminationdate.Name = "dtpterminationdate"
        Me.dtpterminationdate.Size = New System.Drawing.Size(138, 26)
        Me.dtpterminationdate.TabIndex = 72
        '
        'dtpstartdate
        '
        Me.dtpstartdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpstartdate.Location = New System.Drawing.Point(856, 269)
        Me.dtpstartdate.Name = "dtpstartdate"
        Me.dtpstartdate.Size = New System.Drawing.Size(138, 26)
        Me.dtpstartdate.TabIndex = 71
        '
        'dtpsenority
        '
        Me.dtpsenority.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpsenority.Location = New System.Drawing.Point(856, 232)
        Me.dtpsenority.Name = "dtpsenority"
        Me.dtpsenority.Size = New System.Drawing.Size(144, 26)
        Me.dtpsenority.TabIndex = 70
        '
        'mtxcellphone
        '
        Me.mtxcellphone.Location = New System.Drawing.Point(471, 221)
        Me.mtxcellphone.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.mtxcellphone.Mask = "(999) 000-0000"
        Me.mtxcellphone.Name = "mtxcellphone"
        Me.mtxcellphone.Size = New System.Drawing.Size(148, 26)
        Me.mtxcellphone.TabIndex = 69
        '
        'mtxworkphone
        '
        Me.mtxworkphone.Location = New System.Drawing.Point(471, 186)
        Me.mtxworkphone.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.mtxworkphone.Mask = "(999) 000-0000"
        Me.mtxworkphone.Name = "mtxworkphone"
        Me.mtxworkphone.Size = New System.Drawing.Size(148, 26)
        Me.mtxworkphone.TabIndex = 68
        '
        'cboProv
        '
        Me.cboProv.FormattingEnabled = True
        Me.cboProv.Items.AddRange(New Object() {"NB", "NS", "PE", "NF", "QC", "ON"})
        Me.cboProv.Location = New System.Drawing.Point(471, 113)
        Me.cboProv.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cboProv.Name = "cboProv"
        Me.cboProv.Size = New System.Drawing.Size(180, 28)
        Me.cboProv.TabIndex = 67
        '
        'dtpdateofbirth
        '
        Me.dtpdateofbirth.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpdateofbirth.Location = New System.Drawing.Point(123, 149)
        Me.dtpdateofbirth.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dtpdateofbirth.Name = "dtpdateofbirth"
        Me.dtpdateofbirth.Size = New System.Drawing.Size(122, 26)
        Me.dtpdateofbirth.TabIndex = 66
        '
        'cbojobid
        '
        Me.cbojobid.FormattingEnabled = True
        Me.cbojobid.Location = New System.Drawing.Point(856, 116)
        Me.cbojobid.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cbojobid.Name = "cbojobid"
        Me.cbojobid.Size = New System.Drawing.Size(260, 28)
        Me.cbojobid.TabIndex = 65
        '
        'cbodept
        '
        Me.cbodept.FormattingEnabled = True
        Me.cbodept.Location = New System.Drawing.Point(856, 38)
        Me.cbodept.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cbodept.Name = "cbodept"
        Me.cbodept.Size = New System.Drawing.Size(260, 28)
        Me.cbodept.TabIndex = 64
        '
        'txtemail
        '
        Me.txtemail.Location = New System.Drawing.Point(471, 257)
        Me.txtemail.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(186, 26)
        Me.txtemail.TabIndex = 62
        '
        'txtpayrate
        '
        Me.txtpayrate.Location = New System.Drawing.Point(856, 185)
        Me.txtpayrate.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtpayrate.Name = "txtpayrate"
        Me.txtpayrate.Size = New System.Drawing.Size(70, 26)
        Me.txtpayrate.TabIndex = 61
        '
        'txtpostal
        '
        Me.txtpostal.Location = New System.Drawing.Point(471, 151)
        Me.txtpostal.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtpostal.Name = "txtpostal"
        Me.txtpostal.Size = New System.Drawing.Size(76, 26)
        Me.txtpostal.TabIndex = 60
        '
        'txtcity
        '
        Me.txtcity.Location = New System.Drawing.Point(471, 80)
        Me.txtcity.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtcity.Name = "txtcity"
        Me.txtcity.Size = New System.Drawing.Size(186, 26)
        Me.txtcity.TabIndex = 59
        '
        'txtsin
        '
        Me.txtsin.Location = New System.Drawing.Point(122, 185)
        Me.txtsin.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtsin.Name = "txtsin"
        Me.txtsin.Size = New System.Drawing.Size(178, 26)
        Me.txtsin.TabIndex = 58
        '
        'txtstreetaddress
        '
        Me.txtstreetaddress.Location = New System.Drawing.Point(471, 43)
        Me.txtstreetaddress.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtstreetaddress.Name = "txtstreetaddress"
        Me.txtstreetaddress.Size = New System.Drawing.Size(186, 26)
        Me.txtstreetaddress.TabIndex = 57
        '
        'txtmiddleinit
        '
        Me.txtmiddleinit.Location = New System.Drawing.Point(123, 77)
        Me.txtmiddleinit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtmiddleinit.Name = "txtmiddleinit"
        Me.txtmiddleinit.Size = New System.Drawing.Size(66, 26)
        Me.txtmiddleinit.TabIndex = 56
        '
        'txtlastname
        '
        Me.txtlastname.Location = New System.Drawing.Point(123, 110)
        Me.txtlastname.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtlastname.Name = "txtlastname"
        Me.txtlastname.Size = New System.Drawing.Size(177, 26)
        Me.txtlastname.TabIndex = 55
        '
        'txtfirstname
        '
        Me.txtfirstname.Location = New System.Drawing.Point(122, 40)
        Me.txtfirstname.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtfirstname.Name = "txtfirstname"
        Me.txtfirstname.Size = New System.Drawing.Size(178, 26)
        Me.txtfirstname.TabIndex = 54
        '
        'lblpayrate
        '
        Me.lblpayrate.AutoSize = True
        Me.lblpayrate.Location = New System.Drawing.Point(747, 185)
        Me.lblpayrate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblpayrate.Name = "lblpayrate"
        Me.lblpayrate.Size = New System.Drawing.Size(67, 20)
        Me.lblpayrate.TabIndex = 53
        Me.lblpayrate.Text = "Payrate:"
        '
        'lbljobid
        '
        Me.lbljobid.AutoSize = True
        Me.lbljobid.Location = New System.Drawing.Point(767, 121)
        Me.lbljobid.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbljobid.Name = "lbljobid"
        Me.lbljobid.Size = New System.Drawing.Size(47, 20)
        Me.lbljobid.TabIndex = 52
        Me.lbljobid.Text = "Jobs:"
        '
        'lbldept
        '
        Me.lbldept.AutoSize = True
        Me.lbldept.Location = New System.Drawing.Point(720, 43)
        Me.lbldept.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbldept.Name = "lbldept"
        Me.lbldept.Size = New System.Drawing.Size(94, 20)
        Me.lbldept.TabIndex = 51
        Me.lbldept.Text = "Department"
        '
        'lblsupervisor
        '
        Me.lblsupervisor.AutoSize = True
        Me.lblsupervisor.Location = New System.Drawing.Point(730, 83)
        Me.lblsupervisor.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblsupervisor.Name = "lblsupervisor"
        Me.lblsupervisor.Size = New System.Drawing.Size(84, 20)
        Me.lblsupervisor.TabIndex = 50
        Me.lblsupervisor.Text = "Supervisor"
        '
        'lblsin
        '
        Me.lblsin.AutoSize = True
        Me.lblsin.Location = New System.Drawing.Point(57, 189)
        Me.lblsin.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblsin.Name = "lblsin"
        Me.lblsin.Size = New System.Drawing.Size(53, 20)
        Me.lblsin.TabIndex = 49
        Me.lblsin.Text = "SIN #:"
        '
        'lblemail
        '
        Me.lblemail.AutoSize = True
        Me.lblemail.Location = New System.Drawing.Point(406, 259)
        Me.lblemail.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblemail.Name = "lblemail"
        Me.lblemail.Size = New System.Drawing.Size(46, 20)
        Me.lblemail.TabIndex = 48
        Me.lblemail.Text = "email"
        '
        'lblcellphone
        '
        Me.lblcellphone.AutoSize = True
        Me.lblcellphone.Location = New System.Drawing.Point(372, 224)
        Me.lblcellphone.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblcellphone.Name = "lblcellphone"
        Me.lblcellphone.Size = New System.Drawing.Size(84, 20)
        Me.lblcellphone.TabIndex = 47
        Me.lblcellphone.Text = "Cell phone"
        '
        'lblworkphone
        '
        Me.lblworkphone.AutoSize = True
        Me.lblworkphone.Location = New System.Drawing.Point(360, 191)
        Me.lblworkphone.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblworkphone.Name = "lblworkphone"
        Me.lblworkphone.Size = New System.Drawing.Size(96, 20)
        Me.lblworkphone.TabIndex = 46
        Me.lblworkphone.Text = "Work Phone"
        '
        'lblpostal
        '
        Me.lblpostal.AutoSize = True
        Me.lblpostal.Location = New System.Drawing.Point(364, 155)
        Me.lblpostal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblpostal.Name = "lblpostal"
        Me.lblpostal.Size = New System.Drawing.Size(92, 20)
        Me.lblpostal.TabIndex = 45
        Me.lblpostal.Text = "Postal code"
        '
        'lblcity
        '
        Me.lblcity.AutoSize = True
        Me.lblcity.Location = New System.Drawing.Point(420, 83)
        Me.lblcity.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblcity.Name = "lblcity"
        Me.lblcity.Size = New System.Drawing.Size(32, 20)
        Me.lblcity.TabIndex = 44
        Me.lblcity.Text = "city"
        '
        'lblprov
        '
        Me.lblprov.AutoSize = True
        Me.lblprov.Location = New System.Drawing.Point(383, 116)
        Me.lblprov.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblprov.Name = "lblprov"
        Me.lblprov.Size = New System.Drawing.Size(69, 20)
        Me.lblprov.TabIndex = 43
        Me.lblprov.Text = "Province"
        '
        'lblstreetaddress
        '
        Me.lblstreetaddress.AutoSize = True
        Me.lblstreetaddress.Location = New System.Drawing.Point(340, 46)
        Me.lblstreetaddress.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblstreetaddress.Name = "lblstreetaddress"
        Me.lblstreetaddress.Size = New System.Drawing.Size(116, 20)
        Me.lblstreetaddress.TabIndex = 42
        Me.lblstreetaddress.Text = "Street Address"
        '
        'lbldob
        '
        Me.lbldob.AutoSize = True
        Me.lbldob.Location = New System.Drawing.Point(11, 151)
        Me.lbldob.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbldob.Name = "lbldob"
        Me.lbldob.Size = New System.Drawing.Size(99, 20)
        Me.lbldob.TabIndex = 41
        Me.lbldob.Text = "Date of Birth"
        '
        'lblfirstname
        '
        Me.lblfirstname.AutoSize = True
        Me.lblfirstname.Location = New System.Drawing.Point(20, 43)
        Me.lblfirstname.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblfirstname.Name = "lblfirstname"
        Me.lblfirstname.Size = New System.Drawing.Size(90, 20)
        Me.lblfirstname.TabIndex = 40
        Me.lblfirstname.Text = "First Name:"
        '
        'lblmiddleint
        '
        Me.lblmiddleint.AutoSize = True
        Me.lblmiddleint.Location = New System.Drawing.Point(14, 80)
        Me.lblmiddleint.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblmiddleint.Name = "lblmiddleint"
        Me.lblmiddleint.Size = New System.Drawing.Size(96, 20)
        Me.lblmiddleint.TabIndex = 39
        Me.lblmiddleint.Text = "Middle Initial"
        '
        'lbllastname
        '
        Me.lbllastname.AutoSize = True
        Me.lbllastname.Location = New System.Drawing.Point(20, 113)
        Me.lbllastname.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbllastname.Name = "lbllastname"
        Me.lbllastname.Size = New System.Drawing.Size(90, 20)
        Me.lbllastname.TabIndex = 38
        Me.lbllastname.Text = "Last Name:"
        '
        'lbldebug
        '
        Me.lbldebug.AutoSize = True
        Me.lbldebug.Location = New System.Drawing.Point(176, 637)
        Me.lbldebug.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbldebug.Name = "lbldebug"
        Me.lbldebug.Size = New System.Drawing.Size(57, 20)
        Me.lbldebug.TabIndex = 2
        Me.lbldebug.Text = "Label3"
        '
        'grbsearchresults
        '
        Me.grbsearchresults.Controls.Add(Me.btnselect)
        Me.grbsearchresults.Controls.Add(Me.lstsearchresults)
        Me.grbsearchresults.Location = New System.Drawing.Point(530, 17)
        Me.grbsearchresults.Name = "grbsearchresults"
        Me.grbsearchresults.Size = New System.Drawing.Size(596, 138)
        Me.grbsearchresults.TabIndex = 3
        Me.grbsearchresults.TabStop = False
        Me.grbsearchresults.Text = "Results"
        '
        'btnselect
        '
        Me.btnselect.Location = New System.Drawing.Point(386, 31)
        Me.btnselect.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnselect.Name = "btnselect"
        Me.btnselect.Size = New System.Drawing.Size(180, 94)
        Me.btnselect.TabIndex = 8
        Me.btnselect.Text = "Select"
        Me.btnselect.UseVisualStyleBackColor = True
        '
        'lstsearchresults
        '
        Me.lstsearchresults.FormattingEnabled = True
        Me.lstsearchresults.ItemHeight = 20
        Me.lstsearchresults.Location = New System.Drawing.Point(28, 21)
        Me.lstsearchresults.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lstsearchresults.Name = "lstsearchresults"
        Me.lstsearchresults.Size = New System.Drawing.Size(320, 104)
        Me.lstsearchresults.TabIndex = 7
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'lblnomatches
        '
        Me.lblnomatches.AutoSize = True
        Me.lblnomatches.Location = New System.Drawing.Point(736, 158)
        Me.lblnomatches.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblnomatches.Name = "lblnomatches"
        Me.lblnomatches.Size = New System.Drawing.Size(139, 20)
        Me.lblnomatches.TabIndex = 9
        Me.lblnomatches.Text = "No matches found"
        '
        'chkreadonly
        '
        Me.chkreadonly.AutoSize = True
        Me.chkreadonly.Location = New System.Drawing.Point(1150, 44)
        Me.chkreadonly.Name = "chkreadonly"
        Me.chkreadonly.Size = New System.Drawing.Size(22, 21)
        Me.chkreadonly.TabIndex = 10
        Me.chkreadonly.UseVisualStyleBackColor = True
        '
        'RetrieveEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1196, 818)
        Me.Controls.Add(Me.chkreadonly)
        Me.Controls.Add(Me.lblnomatches)
        Me.Controls.Add(Me.grbsearchresults)
        Me.Controls.Add(Me.lbldebug)
        Me.Controls.Add(Me.grbempinfo)
        Me.Controls.Add(Me.grbsearch)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
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
    Friend WithEvents chkreadonly As System.Windows.Forms.CheckBox
End Class
