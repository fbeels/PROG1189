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
        Me.grbsearch = New System.Windows.Forms.GroupBox()
        Me.grbempinfo = New System.Windows.Forms.GroupBox()
        Me.mtxcellphone = New System.Windows.Forms.MaskedTextBox()
        Me.mtxworkphone = New System.Windows.Forms.MaskedTextBox()
        Me.cboProv = New System.Windows.Forms.ComboBox()
        Me.dtpdateofbirth = New System.Windows.Forms.DateTimePicker()
        Me.cbojobid = New System.Windows.Forms.ComboBox()
        Me.cbodept = New System.Windows.Forms.ComboBox()
        Me.cbosupervisor = New System.Windows.Forms.ComboBox()
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtsearchid = New System.Windows.Forms.TextBox()
        Me.txtsearchlname = New System.Windows.Forms.TextBox()
        Me.btnsearch = New System.Windows.Forms.Button()
        Me.lstsearchresults = New System.Windows.Forms.ListBox()
        Me.btnselect = New System.Windows.Forms.Button()
        Me.grbsearch.SuspendLayout()
        Me.grbempinfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'grbsearch
        '
        Me.grbsearch.Controls.Add(Me.btnselect)
        Me.grbsearch.Controls.Add(Me.lstsearchresults)
        Me.grbsearch.Controls.Add(Me.btnsearch)
        Me.grbsearch.Controls.Add(Me.txtsearchlname)
        Me.grbsearch.Controls.Add(Me.txtsearchid)
        Me.grbsearch.Controls.Add(Me.Label2)
        Me.grbsearch.Controls.Add(Me.Label1)
        Me.grbsearch.Location = New System.Drawing.Point(10, 11)
        Me.grbsearch.Name = "grbsearch"
        Me.grbsearch.Size = New System.Drawing.Size(769, 96)
        Me.grbsearch.TabIndex = 0
        Me.grbsearch.TabStop = False
        Me.grbsearch.Text = "Search"
        '
        'grbempinfo
        '
        Me.grbempinfo.Controls.Add(Me.mtxcellphone)
        Me.grbempinfo.Controls.Add(Me.mtxworkphone)
        Me.grbempinfo.Controls.Add(Me.cboProv)
        Me.grbempinfo.Controls.Add(Me.dtpdateofbirth)
        Me.grbempinfo.Controls.Add(Me.cbojobid)
        Me.grbempinfo.Controls.Add(Me.cbodept)
        Me.grbempinfo.Controls.Add(Me.cbosupervisor)
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
        Me.grbempinfo.Size = New System.Drawing.Size(767, 262)
        Me.grbempinfo.TabIndex = 1
        Me.grbempinfo.TabStop = False
        Me.grbempinfo.Text = "Employee Info"
        '
        'mtxcellphone
        '
        Me.mtxcellphone.Location = New System.Drawing.Point(567, 89)
        Me.mtxcellphone.Mask = "(999) 000-0000"
        Me.mtxcellphone.Name = "mtxcellphone"
        Me.mtxcellphone.Size = New System.Drawing.Size(100, 20)
        Me.mtxcellphone.TabIndex = 69
        '
        'mtxworkphone
        '
        Me.mtxworkphone.Location = New System.Drawing.Point(567, 61)
        Me.mtxworkphone.Mask = "(999) 000-0000"
        Me.mtxworkphone.Name = "mtxworkphone"
        Me.mtxworkphone.Size = New System.Drawing.Size(100, 20)
        Me.mtxworkphone.TabIndex = 68
        '
        'cboProv
        '
        Me.cboProv.FormattingEnabled = True
        Me.cboProv.Items.AddRange(New Object() {"NB", "NS", "PE", "NF", "QC", "ON"})
        Me.cboProv.Location = New System.Drawing.Point(314, 111)
        Me.cboProv.Name = "cboProv"
        Me.cboProv.Size = New System.Drawing.Size(121, 21)
        Me.cboProv.TabIndex = 67
        '
        'dtpdateofbirth
        '
        Me.dtpdateofbirth.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpdateofbirth.Location = New System.Drawing.Point(91, 140)
        Me.dtpdateofbirth.Name = "dtpdateofbirth"
        Me.dtpdateofbirth.Size = New System.Drawing.Size(83, 20)
        Me.dtpdateofbirth.TabIndex = 66
        '
        'cbojobid
        '
        Me.cbojobid.FormattingEnabled = True
        Me.cbojobid.Location = New System.Drawing.Point(558, 176)
        Me.cbojobid.Name = "cbojobid"
        Me.cbojobid.Size = New System.Drawing.Size(81, 21)
        Me.cbojobid.TabIndex = 65
        '
        'cbodept
        '
        Me.cbodept.FormattingEnabled = True
        Me.cbodept.Location = New System.Drawing.Point(388, 178)
        Me.cbodept.Name = "cbodept"
        Me.cbodept.Size = New System.Drawing.Size(53, 21)
        Me.cbodept.TabIndex = 64
        '
        'cbosupervisor
        '
        Me.cbosupervisor.FormattingEnabled = True
        Me.cbosupervisor.Location = New System.Drawing.Point(385, 208)
        Me.cbosupervisor.Name = "cbosupervisor"
        Me.cbosupervisor.Size = New System.Drawing.Size(75, 21)
        Me.cbosupervisor.TabIndex = 63
        '
        'txtemail
        '
        Me.txtemail.Location = New System.Drawing.Point(567, 119)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(140, 20)
        Me.txtemail.TabIndex = 62
        '
        'txtpayrate
        '
        Me.txtpayrate.Location = New System.Drawing.Point(564, 210)
        Me.txtpayrate.Name = "txtpayrate"
        Me.txtpayrate.Size = New System.Drawing.Size(48, 20)
        Me.txtpayrate.TabIndex = 61
        '
        'txtpostal
        '
        Me.txtpostal.Location = New System.Drawing.Point(314, 137)
        Me.txtpostal.Name = "txtpostal"
        Me.txtpostal.Size = New System.Drawing.Size(52, 20)
        Me.txtpostal.TabIndex = 60
        '
        'txtcity
        '
        Me.txtcity.Location = New System.Drawing.Point(314, 85)
        Me.txtcity.Name = "txtcity"
        Me.txtcity.Size = New System.Drawing.Size(134, 20)
        Me.txtcity.TabIndex = 59
        '
        'txtsin
        '
        Me.txtsin.Location = New System.Drawing.Point(131, 178)
        Me.txtsin.Name = "txtsin"
        Me.txtsin.Size = New System.Drawing.Size(124, 20)
        Me.txtsin.TabIndex = 58
        '
        'txtstreetaddress
        '
        Me.txtstreetaddress.Location = New System.Drawing.Point(314, 59)
        Me.txtstreetaddress.Name = "txtstreetaddress"
        Me.txtstreetaddress.Size = New System.Drawing.Size(125, 20)
        Me.txtstreetaddress.TabIndex = 57
        '
        'txtmiddleinit
        '
        Me.txtmiddleinit.Location = New System.Drawing.Point(87, 80)
        Me.txtmiddleinit.Name = "txtmiddleinit"
        Me.txtmiddleinit.Size = New System.Drawing.Size(45, 20)
        Me.txtmiddleinit.TabIndex = 56
        '
        'txtlastname
        '
        Me.txtlastname.Location = New System.Drawing.Point(82, 108)
        Me.txtlastname.Name = "txtlastname"
        Me.txtlastname.Size = New System.Drawing.Size(99, 20)
        Me.txtlastname.TabIndex = 55
        '
        'txtfirstname
        '
        Me.txtfirstname.Location = New System.Drawing.Point(87, 56)
        Me.txtfirstname.Name = "txtfirstname"
        Me.txtfirstname.Size = New System.Drawing.Size(120, 20)
        Me.txtfirstname.TabIndex = 54
        '
        'lblpayrate
        '
        Me.lblpayrate.AutoSize = True
        Me.lblpayrate.Location = New System.Drawing.Point(504, 208)
        Me.lblpayrate.Name = "lblpayrate"
        Me.lblpayrate.Size = New System.Drawing.Size(46, 13)
        Me.lblpayrate.TabIndex = 53
        Me.lblpayrate.Text = "Payrate:"
        '
        'lbljobid
        '
        Me.lbljobid.AutoSize = True
        Me.lbljobid.Location = New System.Drawing.Point(504, 177)
        Me.lbljobid.Name = "lbljobid"
        Me.lbljobid.Size = New System.Drawing.Size(38, 13)
        Me.lbljobid.TabIndex = 52
        Me.lbljobid.Text = "JobID:"
        '
        'lbldept
        '
        Me.lbldept.AutoSize = True
        Me.lbldept.Location = New System.Drawing.Point(311, 181)
        Me.lbldept.Name = "lbldept"
        Me.lbldept.Size = New System.Drawing.Size(62, 13)
        Me.lbldept.TabIndex = 51
        Me.lbldept.Text = "Department"
        '
        'lblsupervisor
        '
        Me.lblsupervisor.AutoSize = True
        Me.lblsupervisor.Location = New System.Drawing.Point(311, 208)
        Me.lblsupervisor.Name = "lblsupervisor"
        Me.lblsupervisor.Size = New System.Drawing.Size(57, 13)
        Me.lblsupervisor.TabIndex = 50
        Me.lblsupervisor.Text = "Supervisor"
        '
        'lblsin
        '
        Me.lblsin.AutoSize = True
        Me.lblsin.Location = New System.Drawing.Point(1, 177)
        Me.lblsin.Name = "lblsin"
        Me.lblsin.Size = New System.Drawing.Size(124, 13)
        Me.lblsin.TabIndex = 49
        Me.lblsin.Text = "Social Insurance number"
        '
        'lblemail
        '
        Me.lblemail.AutoSize = True
        Me.lblemail.Location = New System.Drawing.Point(530, 119)
        Me.lblemail.Name = "lblemail"
        Me.lblemail.Size = New System.Drawing.Size(31, 13)
        Me.lblemail.TabIndex = 48
        Me.lblemail.Text = "email"
        '
        'lblcellphone
        '
        Me.lblcellphone.AutoSize = True
        Me.lblcellphone.Location = New System.Drawing.Point(504, 92)
        Me.lblcellphone.Name = "lblcellphone"
        Me.lblcellphone.Size = New System.Drawing.Size(57, 13)
        Me.lblcellphone.TabIndex = 47
        Me.lblcellphone.Text = "Cell phone"
        '
        'lblworkphone
        '
        Me.lblworkphone.AutoSize = True
        Me.lblworkphone.Location = New System.Drawing.Point(494, 66)
        Me.lblworkphone.Name = "lblworkphone"
        Me.lblworkphone.Size = New System.Drawing.Size(67, 13)
        Me.lblworkphone.TabIndex = 46
        Me.lblworkphone.Text = "Work Phone"
        '
        'lblpostal
        '
        Me.lblpostal.AutoSize = True
        Me.lblpostal.Location = New System.Drawing.Point(240, 140)
        Me.lblpostal.Name = "lblpostal"
        Me.lblpostal.Size = New System.Drawing.Size(63, 13)
        Me.lblpostal.TabIndex = 45
        Me.lblpostal.Text = "Postal code"
        '
        'lblcity
        '
        Me.lblcity.AutoSize = True
        Me.lblcity.Location = New System.Drawing.Point(270, 83)
        Me.lblcity.Name = "lblcity"
        Me.lblcity.Size = New System.Drawing.Size(23, 13)
        Me.lblcity.TabIndex = 44
        Me.lblcity.Text = "city"
        '
        'lblprov
        '
        Me.lblprov.AutoSize = True
        Me.lblprov.Location = New System.Drawing.Point(246, 108)
        Me.lblprov.Name = "lblprov"
        Me.lblprov.Size = New System.Drawing.Size(49, 13)
        Me.lblprov.TabIndex = 43
        Me.lblprov.Text = "Province"
        '
        'lblstreetaddress
        '
        Me.lblstreetaddress.AutoSize = True
        Me.lblstreetaddress.Location = New System.Drawing.Point(227, 59)
        Me.lblstreetaddress.Name = "lblstreetaddress"
        Me.lblstreetaddress.Size = New System.Drawing.Size(76, 13)
        Me.lblstreetaddress.TabIndex = 42
        Me.lblstreetaddress.Text = "Street Address"
        '
        'lbldob
        '
        Me.lbldob.AutoSize = True
        Me.lbldob.Location = New System.Drawing.Point(11, 144)
        Me.lbldob.Name = "lbldob"
        Me.lbldob.Size = New System.Drawing.Size(66, 13)
        Me.lbldob.TabIndex = 41
        Me.lbldob.Text = "Date of Birth"
        '
        'lblfirstname
        '
        Me.lblfirstname.AutoSize = True
        Me.lblfirstname.Location = New System.Drawing.Point(22, 59)
        Me.lblfirstname.Name = "lblfirstname"
        Me.lblfirstname.Size = New System.Drawing.Size(54, 13)
        Me.lblfirstname.TabIndex = 40
        Me.lblfirstname.Text = "first Name"
        '
        'lblmiddleint
        '
        Me.lblmiddleint.AutoSize = True
        Me.lblmiddleint.Location = New System.Drawing.Point(11, 83)
        Me.lblmiddleint.Name = "lblmiddleint"
        Me.lblmiddleint.Size = New System.Drawing.Size(65, 13)
        Me.lblmiddleint.TabIndex = 39
        Me.lblmiddleint.Text = "Middle Initial"
        '
        'lbllastname
        '
        Me.lbllastname.AutoSize = True
        Me.lbllastname.Location = New System.Drawing.Point(15, 111)
        Me.lbllastname.Name = "lbllastname"
        Me.lbllastname.Size = New System.Drawing.Size(61, 13)
        Me.lbllastname.TabIndex = 38
        Me.lbllastname.Text = "Last Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(19, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Id:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Last name"
        '
        'txtsearchid
        '
        Me.txtsearchid.Location = New System.Drawing.Point(92, 27)
        Me.txtsearchid.Name = "txtsearchid"
        Me.txtsearchid.Size = New System.Drawing.Size(100, 20)
        Me.txtsearchid.TabIndex = 2
        '
        'txtsearchlname
        '
        Me.txtsearchlname.Location = New System.Drawing.Point(79, 70)
        Me.txtsearchlname.Name = "txtsearchlname"
        Me.txtsearchlname.Size = New System.Drawing.Size(100, 20)
        Me.txtsearchlname.TabIndex = 3
        '
        'btnsearch
        '
        Me.btnsearch.Location = New System.Drawing.Point(217, 33)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(97, 56)
        Me.btnsearch.TabIndex = 4
        Me.btnsearch.Text = "Search"
        Me.btnsearch.UseVisualStyleBackColor = True
        '
        'lstsearchresults
        '
        Me.lstsearchresults.FormattingEnabled = True
        Me.lstsearchresults.Location = New System.Drawing.Point(371, 17)
        Me.lstsearchresults.Name = "lstsearchresults"
        Me.lstsearchresults.Size = New System.Drawing.Size(215, 69)
        Me.lstsearchresults.TabIndex = 5
        '
        'btnselect
        '
        Me.btnselect.Location = New System.Drawing.Point(612, 24)
        Me.btnselect.Name = "btnselect"
        Me.btnselect.Size = New System.Drawing.Size(120, 61)
        Me.btnselect.TabIndex = 6
        Me.btnselect.Text = "Select"
        Me.btnselect.UseVisualStyleBackColor = True
        '
        'RetrieveEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(799, 532)
        Me.Controls.Add(Me.grbempinfo)
        Me.Controls.Add(Me.grbsearch)
        Me.Name = "RetrieveEmployee"
        Me.Text = "RetrieveEmployee"
        Me.grbsearch.ResumeLayout(False)
        Me.grbsearch.PerformLayout()
        Me.grbempinfo.ResumeLayout(False)
        Me.grbempinfo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grbsearch As System.Windows.Forms.GroupBox
    Friend WithEvents grbempinfo As System.Windows.Forms.GroupBox
    Friend WithEvents btnselect As System.Windows.Forms.Button
    Friend WithEvents lstsearchresults As System.Windows.Forms.ListBox
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
    Friend WithEvents cbosupervisor As System.Windows.Forms.ComboBox
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
End Class
