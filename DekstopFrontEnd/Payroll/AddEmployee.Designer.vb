<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddEmployee
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
        Me.btnsave = New System.Windows.Forms.Button()
        Me.btnreset = New System.Windows.Forms.Button()
        Me.lblresult = New System.Windows.Forms.Label()
        Me.btnprefill = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.mtxcellphone = New System.Windows.Forms.MaskedTextBox()
        Me.lblcellphone = New System.Windows.Forms.Label()
        Me.txtsin = New System.Windows.Forms.TextBox()
        Me.lblsin = New System.Windows.Forms.Label()
        Me.dtpdateofbirth = New System.Windows.Forms.DateTimePicker()
        Me.lbldob = New System.Windows.Forms.Label()
        Me.cboProv = New System.Windows.Forms.ComboBox()
        Me.txtpostal = New System.Windows.Forms.TextBox()
        Me.txtcity = New System.Windows.Forms.TextBox()
        Me.txtstreetaddress = New System.Windows.Forms.TextBox()
        Me.lblpostal = New System.Windows.Forms.Label()
        Me.lblcity = New System.Windows.Forms.Label()
        Me.lblprov = New System.Windows.Forms.Label()
        Me.lblstreetaddress = New System.Windows.Forms.Label()
        Me.txtmiddleinit = New System.Windows.Forms.TextBox()
        Me.txtlastname = New System.Windows.Forms.TextBox()
        Me.txtfirstname = New System.Windows.Forms.TextBox()
        Me.lblfirstname = New System.Windows.Forms.Label()
        Me.lblmiddleint = New System.Windows.Forms.Label()
        Me.lbllastname = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkemailstub = New System.Windows.Forms.CheckBox()
        Me.lblsuperid = New System.Windows.Forms.Label()
        Me.lblsupername = New System.Windows.Forms.Label()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.lblemail = New System.Windows.Forms.Label()
        Me.mtxworkphone = New System.Windows.Forms.MaskedTextBox()
        Me.lblworkphone = New System.Windows.Forms.Label()
        Me.cbojobid = New System.Windows.Forms.ComboBox()
        Me.cbodept = New System.Windows.Forms.ComboBox()
        Me.txtpayrate = New System.Windows.Forms.TextBox()
        Me.lblpayrate = New System.Windows.Forms.Label()
        Me.lbljobid = New System.Windows.Forms.Label()
        Me.lbldept = New System.Windows.Forms.Label()
        Me.lblsupervisor = New System.Windows.Forms.Label()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnsave
        '
        Me.btnsave.Location = New System.Drawing.Point(175, 355)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(268, 47)
        Me.btnsave.TabIndex = 32
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'btnreset
        '
        Me.btnreset.Location = New System.Drawing.Point(19, 355)
        Me.btnreset.Name = "btnreset"
        Me.btnreset.Size = New System.Drawing.Size(135, 47)
        Me.btnreset.TabIndex = 33
        Me.btnreset.Text = "Reset"
        Me.btnreset.UseVisualStyleBackColor = True
        '
        'lblresult
        '
        Me.lblresult.BackColor = System.Drawing.Color.LemonChiffon
        Me.lblresult.Location = New System.Drawing.Point(16, 425)
        Me.lblresult.Name = "lblresult"
        Me.lblresult.Size = New System.Drawing.Size(469, 41)
        Me.lblresult.TabIndex = 34
        Me.lblresult.Text = "Errors and result"
        '
        'btnprefill
        '
        Me.btnprefill.Location = New System.Drawing.Point(448, 373)
        Me.btnprefill.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnprefill.Name = "btnprefill"
        Me.btnprefill.Size = New System.Drawing.Size(42, 29)
        Me.btnprefill.TabIndex = 38
        Me.btnprefill.Text = "prefill"
        Me.btnprefill.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.mtxcellphone)
        Me.GroupBox1.Controls.Add(Me.lblcellphone)
        Me.GroupBox1.Controls.Add(Me.txtsin)
        Me.GroupBox1.Controls.Add(Me.lblsin)
        Me.GroupBox1.Controls.Add(Me.dtpdateofbirth)
        Me.GroupBox1.Controls.Add(Me.lbldob)
        Me.GroupBox1.Controls.Add(Me.cboProv)
        Me.GroupBox1.Controls.Add(Me.txtpostal)
        Me.GroupBox1.Controls.Add(Me.txtcity)
        Me.GroupBox1.Controls.Add(Me.txtstreetaddress)
        Me.GroupBox1.Controls.Add(Me.lblpostal)
        Me.GroupBox1.Controls.Add(Me.lblcity)
        Me.GroupBox1.Controls.Add(Me.lblprov)
        Me.GroupBox1.Controls.Add(Me.lblstreetaddress)
        Me.GroupBox1.Controls.Add(Me.txtmiddleinit)
        Me.GroupBox1.Controls.Add(Me.txtlastname)
        Me.GroupBox1.Controls.Add(Me.txtfirstname)
        Me.GroupBox1.Controls.Add(Me.lblfirstname)
        Me.GroupBox1.Controls.Add(Me.lblmiddleint)
        Me.GroupBox1.Controls.Add(Me.lbllastname)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 17)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(479, 147)
        Me.GroupBox1.TabIndex = 39
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Personal Information"
        '
        'mtxcellphone
        '
        Me.mtxcellphone.Location = New System.Drawing.Point(303, 121)
        Me.mtxcellphone.Mask = "(999) 000-0000"
        Me.mtxcellphone.Name = "mtxcellphone"
        Me.mtxcellphone.Size = New System.Drawing.Size(100, 20)
        Me.mtxcellphone.TabIndex = 49
        '
        'lblcellphone
        '
        Me.lblcellphone.AutoSize = True
        Me.lblcellphone.Location = New System.Drawing.Point(240, 121)
        Me.lblcellphone.Name = "lblcellphone"
        Me.lblcellphone.Size = New System.Drawing.Size(57, 13)
        Me.lblcellphone.TabIndex = 48
        Me.lblcellphone.Text = "Cell phone"
        '
        'txtsin
        '
        Me.txtsin.Location = New System.Drawing.Point(90, 114)
        Me.txtsin.Name = "txtsin"
        Me.txtsin.Size = New System.Drawing.Size(124, 20)
        Me.txtsin.TabIndex = 47
        '
        'lblsin
        '
        Me.lblsin.AutoSize = True
        Me.lblsin.Location = New System.Drawing.Point(59, 120)
        Me.lblsin.Name = "lblsin"
        Me.lblsin.Size = New System.Drawing.Size(25, 13)
        Me.lblsin.TabIndex = 46
        Me.lblsin.Text = "SIN"
        '
        'dtpdateofbirth
        '
        Me.dtpdateofbirth.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpdateofbirth.Location = New System.Drawing.Point(90, 88)
        Me.dtpdateofbirth.Name = "dtpdateofbirth"
        Me.dtpdateofbirth.Size = New System.Drawing.Size(83, 20)
        Me.dtpdateofbirth.TabIndex = 45
        '
        'lbldob
        '
        Me.lbldob.AutoSize = True
        Me.lbldob.Location = New System.Drawing.Point(19, 91)
        Me.lbldob.Name = "lbldob"
        Me.lbldob.Size = New System.Drawing.Size(66, 13)
        Me.lbldob.TabIndex = 44
        Me.lbldob.Text = "Date of Birth"
        '
        'cboProv
        '
        Me.cboProv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProv.FormattingEnabled = True
        Me.cboProv.Items.AddRange(New Object() {"NB", "NS", "PE", "NF", "QC", "ON"})
        Me.cboProv.Location = New System.Drawing.Point(303, 67)
        Me.cboProv.Name = "cboProv"
        Me.cboProv.Size = New System.Drawing.Size(54, 21)
        Me.cboProv.TabIndex = 43
        '
        'txtpostal
        '
        Me.txtpostal.Location = New System.Drawing.Point(303, 92)
        Me.txtpostal.Name = "txtpostal"
        Me.txtpostal.Size = New System.Drawing.Size(52, 20)
        Me.txtpostal.TabIndex = 42
        '
        'txtcity
        '
        Me.txtcity.Location = New System.Drawing.Point(303, 44)
        Me.txtcity.Name = "txtcity"
        Me.txtcity.Size = New System.Drawing.Size(134, 20)
        Me.txtcity.TabIndex = 41
        '
        'txtstreetaddress
        '
        Me.txtstreetaddress.Location = New System.Drawing.Point(303, 16)
        Me.txtstreetaddress.Name = "txtstreetaddress"
        Me.txtstreetaddress.Size = New System.Drawing.Size(125, 20)
        Me.txtstreetaddress.TabIndex = 40
        '
        'lblpostal
        '
        Me.lblpostal.AutoSize = True
        Me.lblpostal.Location = New System.Drawing.Point(234, 95)
        Me.lblpostal.Name = "lblpostal"
        Me.lblpostal.Size = New System.Drawing.Size(63, 13)
        Me.lblpostal.TabIndex = 39
        Me.lblpostal.Text = "Postal code"
        '
        'lblcity
        '
        Me.lblcity.AutoSize = True
        Me.lblcity.Location = New System.Drawing.Point(274, 47)
        Me.lblcity.Name = "lblcity"
        Me.lblcity.Size = New System.Drawing.Size(24, 13)
        Me.lblcity.TabIndex = 38
        Me.lblcity.Text = "City"
        '
        'lblprov
        '
        Me.lblprov.AutoSize = True
        Me.lblprov.Location = New System.Drawing.Point(248, 67)
        Me.lblprov.Name = "lblprov"
        Me.lblprov.Size = New System.Drawing.Size(49, 13)
        Me.lblprov.TabIndex = 37
        Me.lblprov.Text = "Province"
        '
        'lblstreetaddress
        '
        Me.lblstreetaddress.AutoSize = True
        Me.lblstreetaddress.Location = New System.Drawing.Point(221, 19)
        Me.lblstreetaddress.Name = "lblstreetaddress"
        Me.lblstreetaddress.Size = New System.Drawing.Size(76, 13)
        Me.lblstreetaddress.TabIndex = 36
        Me.lblstreetaddress.Text = "Street Address"
        '
        'txtmiddleinit
        '
        Me.txtmiddleinit.Location = New System.Drawing.Point(89, 41)
        Me.txtmiddleinit.Name = "txtmiddleinit"
        Me.txtmiddleinit.Size = New System.Drawing.Size(45, 20)
        Me.txtmiddleinit.TabIndex = 24
        '
        'txtlastname
        '
        Me.txtlastname.Location = New System.Drawing.Point(89, 64)
        Me.txtlastname.Name = "txtlastname"
        Me.txtlastname.Size = New System.Drawing.Size(99, 20)
        Me.txtlastname.TabIndex = 23
        '
        'txtfirstname
        '
        Me.txtfirstname.Location = New System.Drawing.Point(90, 19)
        Me.txtfirstname.Name = "txtfirstname"
        Me.txtfirstname.Size = New System.Drawing.Size(120, 20)
        Me.txtfirstname.TabIndex = 22
        '
        'lblfirstname
        '
        Me.lblfirstname.AutoSize = True
        Me.lblfirstname.Location = New System.Drawing.Point(30, 19)
        Me.lblfirstname.Name = "lblfirstname"
        Me.lblfirstname.Size = New System.Drawing.Size(57, 13)
        Me.lblfirstname.TabIndex = 21
        Me.lblfirstname.Text = "First Name"
        '
        'lblmiddleint
        '
        Me.lblmiddleint.AutoSize = True
        Me.lblmiddleint.Location = New System.Drawing.Point(19, 43)
        Me.lblmiddleint.Name = "lblmiddleint"
        Me.lblmiddleint.Size = New System.Drawing.Size(65, 13)
        Me.lblmiddleint.TabIndex = 20
        Me.lblmiddleint.Text = "Middle Initial"
        '
        'lbllastname
        '
        Me.lbllastname.AutoSize = True
        Me.lbllastname.Location = New System.Drawing.Point(20, 64)
        Me.lbllastname.Name = "lbllastname"
        Me.lbllastname.Size = New System.Drawing.Size(61, 13)
        Me.lbllastname.TabIndex = 19
        Me.lbllastname.Text = "Last Name:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkemailstub)
        Me.GroupBox2.Controls.Add(Me.lblsuperid)
        Me.GroupBox2.Controls.Add(Me.lblsupername)
        Me.GroupBox2.Controls.Add(Me.txtemail)
        Me.GroupBox2.Controls.Add(Me.lblemail)
        Me.GroupBox2.Controls.Add(Me.mtxworkphone)
        Me.GroupBox2.Controls.Add(Me.lblworkphone)
        Me.GroupBox2.Controls.Add(Me.cbojobid)
        Me.GroupBox2.Controls.Add(Me.cbodept)
        Me.GroupBox2.Controls.Add(Me.txtpayrate)
        Me.GroupBox2.Controls.Add(Me.lblpayrate)
        Me.GroupBox2.Controls.Add(Me.lbljobid)
        Me.GroupBox2.Controls.Add(Me.lbldept)
        Me.GroupBox2.Controls.Add(Me.lblsupervisor)
        Me.GroupBox2.Location = New System.Drawing.Point(9, 175)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(481, 174)
        Me.GroupBox2.TabIndex = 40
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Employment Information"
        '
        'chkemailstub
        '
        Me.chkemailstub.AutoSize = True
        Me.chkemailstub.Location = New System.Drawing.Point(120, 123)
        Me.chkemailstub.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkemailstub.Name = "chkemailstub"
        Me.chkemailstub.Size = New System.Drawing.Size(151, 17)
        Me.chkemailstub.TabIndex = 45
        Me.chkemailstub.Text = "Recieve PayStub by Email"
        Me.chkemailstub.UseVisualStyleBackColor = True
        '
        'lblsuperid
        '
        Me.lblsuperid.AutoSize = True
        Me.lblsuperid.Location = New System.Drawing.Point(199, 56)
        Me.lblsuperid.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblsuperid.Name = "lblsuperid"
        Me.lblsuperid.Size = New System.Drawing.Size(39, 13)
        Me.lblsuperid.TabIndex = 44
        Me.lblsuperid.Text = "Label1"
        '
        'lblsupername
        '
        Me.lblsupername.AutoSize = True
        Me.lblsupername.Location = New System.Drawing.Point(97, 56)
        Me.lblsupername.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblsupername.Name = "lblsupername"
        Me.lblsupername.Size = New System.Drawing.Size(39, 13)
        Me.lblsupername.TabIndex = 43
        Me.lblsupername.Text = "Label1"
        '
        'txtemail
        '
        Me.txtemail.Location = New System.Drawing.Point(315, 50)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(140, 20)
        Me.txtemail.TabIndex = 42
        '
        'lblemail
        '
        Me.lblemail.AutoSize = True
        Me.lblemail.Location = New System.Drawing.Point(268, 53)
        Me.lblemail.Name = "lblemail"
        Me.lblemail.Size = New System.Drawing.Size(32, 13)
        Me.lblemail.TabIndex = 41
        Me.lblemail.Text = "Email"
        '
        'mtxworkphone
        '
        Me.mtxworkphone.Location = New System.Drawing.Point(355, 19)
        Me.mtxworkphone.Mask = "(999) 000-0000"
        Me.mtxworkphone.Name = "mtxworkphone"
        Me.mtxworkphone.Size = New System.Drawing.Size(100, 20)
        Me.mtxworkphone.TabIndex = 40
        '
        'lblworkphone
        '
        Me.lblworkphone.AutoSize = True
        Me.lblworkphone.Location = New System.Drawing.Point(268, 19)
        Me.lblworkphone.Name = "lblworkphone"
        Me.lblworkphone.Size = New System.Drawing.Size(67, 13)
        Me.lblworkphone.TabIndex = 39
        Me.lblworkphone.Text = "Work Phone"
        '
        'cbojobid
        '
        Me.cbojobid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbojobid.FormattingEnabled = True
        Me.cbojobid.Location = New System.Drawing.Point(38, 87)
        Me.cbojobid.Name = "cbojobid"
        Me.cbojobid.Size = New System.Drawing.Size(200, 21)
        Me.cbojobid.TabIndex = 38
        '
        'cbodept
        '
        Me.cbodept.FormattingEnabled = True
        Me.cbodept.Location = New System.Drawing.Point(98, 23)
        Me.cbodept.Name = "cbodept"
        Me.cbodept.Size = New System.Drawing.Size(140, 21)
        Me.cbodept.TabIndex = 37
        '
        'txtpayrate
        '
        Me.txtpayrate.Location = New System.Drawing.Point(63, 122)
        Me.txtpayrate.Name = "txtpayrate"
        Me.txtpayrate.Size = New System.Drawing.Size(48, 20)
        Me.txtpayrate.TabIndex = 35
        '
        'lblpayrate
        '
        Me.lblpayrate.AutoSize = True
        Me.lblpayrate.Location = New System.Drawing.Point(5, 124)
        Me.lblpayrate.Name = "lblpayrate"
        Me.lblpayrate.Size = New System.Drawing.Size(46, 13)
        Me.lblpayrate.TabIndex = 34
        Me.lblpayrate.Text = "Payrate:"
        '
        'lbljobid
        '
        Me.lbljobid.AutoSize = True
        Me.lbljobid.Location = New System.Drawing.Point(7, 92)
        Me.lbljobid.Name = "lbljobid"
        Me.lbljobid.Size = New System.Drawing.Size(27, 13)
        Me.lbljobid.TabIndex = 33
        Me.lbljobid.Text = "Job:"
        '
        'lbldept
        '
        Me.lbldept.AutoSize = True
        Me.lbldept.Location = New System.Drawing.Point(23, 25)
        Me.lbldept.Name = "lbldept"
        Me.lbldept.Size = New System.Drawing.Size(62, 13)
        Me.lbldept.TabIndex = 32
        Me.lbldept.Text = "Department"
        '
        'lblsupervisor
        '
        Me.lblsupervisor.AutoSize = True
        Me.lblsupervisor.Location = New System.Drawing.Point(21, 56)
        Me.lblsupervisor.Name = "lblsupervisor"
        Me.lblsupervisor.Size = New System.Drawing.Size(57, 13)
        Me.lblsupervisor.TabIndex = 31
        Me.lblsupervisor.Text = "Supervisor"
        '
        'AddEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(510, 494)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnprefill)
        Me.Controls.Add(Me.lblresult)
        Me.Controls.Add(Me.btnreset)
        Me.Controls.Add(Me.btnsave)
        Me.Name = "AddEmployee"
        Me.Text = "AddEmp"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents btnreset As System.Windows.Forms.Button
    Friend WithEvents lblresult As System.Windows.Forms.Label
    Friend WithEvents btnprefill As System.Windows.Forms.Button
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtemail As System.Windows.Forms.TextBox
    Friend WithEvents lblemail As System.Windows.Forms.Label
    Friend WithEvents mtxworkphone As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblworkphone As System.Windows.Forms.Label
    Friend WithEvents cbojobid As System.Windows.Forms.ComboBox
    Friend WithEvents cbodept As System.Windows.Forms.ComboBox
    Friend WithEvents txtpayrate As System.Windows.Forms.TextBox
    Friend WithEvents lblpayrate As System.Windows.Forms.Label
    Friend WithEvents lbljobid As System.Windows.Forms.Label
    Friend WithEvents lbldept As System.Windows.Forms.Label
    Friend WithEvents lblsupervisor As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents mtxcellphone As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblcellphone As System.Windows.Forms.Label
    Friend WithEvents txtsin As System.Windows.Forms.TextBox
    Friend WithEvents lblsin As System.Windows.Forms.Label
    Friend WithEvents dtpdateofbirth As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbldob As System.Windows.Forms.Label
    Friend WithEvents cboProv As System.Windows.Forms.ComboBox
    Friend WithEvents txtpostal As System.Windows.Forms.TextBox
    Friend WithEvents txtcity As System.Windows.Forms.TextBox
    Friend WithEvents txtstreetaddress As System.Windows.Forms.TextBox
    Friend WithEvents lblpostal As System.Windows.Forms.Label
    Friend WithEvents lblcity As System.Windows.Forms.Label
    Friend WithEvents lblprov As System.Windows.Forms.Label
    Friend WithEvents lblstreetaddress As System.Windows.Forms.Label
    Friend WithEvents txtmiddleinit As System.Windows.Forms.TextBox
    Friend WithEvents txtlastname As System.Windows.Forms.TextBox
    Friend WithEvents txtfirstname As System.Windows.Forms.TextBox
    Friend WithEvents lblfirstname As System.Windows.Forms.Label
    Friend WithEvents lblmiddleint As System.Windows.Forms.Label
    Friend WithEvents lbllastname As System.Windows.Forms.Label
    Friend WithEvents lblsupername As System.Windows.Forms.Label
    Friend WithEvents lblsuperid As System.Windows.Forms.Label
    Friend WithEvents chkemailstub As System.Windows.Forms.CheckBox
End Class
