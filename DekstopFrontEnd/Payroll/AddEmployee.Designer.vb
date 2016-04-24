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
        Me.lbllastname = New System.Windows.Forms.Label()
        Me.lblmiddleint = New System.Windows.Forms.Label()
        Me.lblfirstname = New System.Windows.Forms.Label()
        Me.lbldob = New System.Windows.Forms.Label()
        Me.lblstreetaddress = New System.Windows.Forms.Label()
        Me.lblprov = New System.Windows.Forms.Label()
        Me.lblcity = New System.Windows.Forms.Label()
        Me.lblpostal = New System.Windows.Forms.Label()
        Me.lblworkphone = New System.Windows.Forms.Label()
        Me.lblcellphone = New System.Windows.Forms.Label()
        Me.lblemail = New System.Windows.Forms.Label()
        Me.lblsin = New System.Windows.Forms.Label()
        Me.lblsupervisor = New System.Windows.Forms.Label()
        Me.lbldept = New System.Windows.Forms.Label()
        Me.lbljobid = New System.Windows.Forms.Label()
        Me.lblpayrate = New System.Windows.Forms.Label()
        Me.txtfirstname = New System.Windows.Forms.TextBox()
        Me.txtlastname = New System.Windows.Forms.TextBox()
        Me.txtmiddleinit = New System.Windows.Forms.TextBox()
        Me.txtstreetaddress = New System.Windows.Forms.TextBox()
        Me.txtsin = New System.Windows.Forms.TextBox()
        Me.txtcity = New System.Windows.Forms.TextBox()
        Me.txtpostal = New System.Windows.Forms.TextBox()
        Me.txtpayrate = New System.Windows.Forms.TextBox()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.cbosupervisor = New System.Windows.Forms.ComboBox()
        Me.cbodept = New System.Windows.Forms.ComboBox()
        Me.cbojobid = New System.Windows.Forms.ComboBox()
        Me.dtpdateofbirth = New System.Windows.Forms.DateTimePicker()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.btnreset = New System.Windows.Forms.Button()
        Me.lblresult = New System.Windows.Forms.Label()
        Me.cboProv = New System.Windows.Forms.ComboBox()
        Me.mtxworkphone = New System.Windows.Forms.MaskedTextBox()
        Me.mtxcellphone = New System.Windows.Forms.MaskedTextBox()
        Me.SuspendLayout()
        '
        'lbllastname
        '
        Me.lbllastname.AutoSize = True
        Me.lbllastname.Location = New System.Drawing.Point(347, 24)
        Me.lbllastname.Name = "lbllastname"
        Me.lbllastname.Size = New System.Drawing.Size(61, 13)
        Me.lbllastname.TabIndex = 0
        Me.lbllastname.Text = "Last Name:"
        '
        'lblmiddleint
        '
        Me.lblmiddleint.AutoSize = True
        Me.lblmiddleint.Location = New System.Drawing.Point(214, 24)
        Me.lblmiddleint.Name = "lblmiddleint"
        Me.lblmiddleint.Size = New System.Drawing.Size(65, 13)
        Me.lblmiddleint.TabIndex = 1
        Me.lblmiddleint.Text = "Middle Initial"
        '
        'lblfirstname
        '
        Me.lblfirstname.AutoSize = True
        Me.lblfirstname.Location = New System.Drawing.Point(18, 24)
        Me.lblfirstname.Name = "lblfirstname"
        Me.lblfirstname.Size = New System.Drawing.Size(54, 13)
        Me.lblfirstname.TabIndex = 2
        Me.lblfirstname.Text = "first Name"
        '
        'lbldob
        '
        Me.lbldob.AutoSize = True
        Me.lbldob.Location = New System.Drawing.Point(45, 68)
        Me.lbldob.Name = "lbldob"
        Me.lbldob.Size = New System.Drawing.Size(66, 13)
        Me.lbldob.TabIndex = 3
        Me.lbldob.Text = "Date of Birth"
        '
        'lblstreetaddress
        '
        Me.lblstreetaddress.AutoSize = True
        Me.lblstreetaddress.Location = New System.Drawing.Point(17, 105)
        Me.lblstreetaddress.Name = "lblstreetaddress"
        Me.lblstreetaddress.Size = New System.Drawing.Size(76, 13)
        Me.lblstreetaddress.TabIndex = 4
        Me.lblstreetaddress.Text = "Street Address"
        '
        'lblprov
        '
        Me.lblprov.AutoSize = True
        Me.lblprov.Location = New System.Drawing.Point(23, 141)
        Me.lblprov.Name = "lblprov"
        Me.lblprov.Size = New System.Drawing.Size(49, 13)
        Me.lblprov.TabIndex = 5
        Me.lblprov.Text = "Province"
        '
        'lblcity
        '
        Me.lblcity.AutoSize = True
        Me.lblcity.Location = New System.Drawing.Point(249, 103)
        Me.lblcity.Name = "lblcity"
        Me.lblcity.Size = New System.Drawing.Size(23, 13)
        Me.lblcity.TabIndex = 6
        Me.lblcity.Text = "city"
        '
        'lblpostal
        '
        Me.lblpostal.AutoSize = True
        Me.lblpostal.Location = New System.Drawing.Point(227, 147)
        Me.lblpostal.Name = "lblpostal"
        Me.lblpostal.Size = New System.Drawing.Size(63, 13)
        Me.lblpostal.TabIndex = 7
        Me.lblpostal.Text = "Postal code"
        '
        'lblworkphone
        '
        Me.lblworkphone.AutoSize = True
        Me.lblworkphone.Location = New System.Drawing.Point(18, 180)
        Me.lblworkphone.Name = "lblworkphone"
        Me.lblworkphone.Size = New System.Drawing.Size(67, 13)
        Me.lblworkphone.TabIndex = 8
        Me.lblworkphone.Text = "Work Phone"
        '
        'lblcellphone
        '
        Me.lblcellphone.AutoSize = True
        Me.lblcellphone.Location = New System.Drawing.Point(214, 178)
        Me.lblcellphone.Name = "lblcellphone"
        Me.lblcellphone.Size = New System.Drawing.Size(57, 13)
        Me.lblcellphone.TabIndex = 9
        Me.lblcellphone.Text = "Cell phone"
        '
        'lblemail
        '
        Me.lblemail.AutoSize = True
        Me.lblemail.Location = New System.Drawing.Point(383, 178)
        Me.lblemail.Name = "lblemail"
        Me.lblemail.Size = New System.Drawing.Size(31, 13)
        Me.lblemail.TabIndex = 10
        Me.lblemail.Text = "email"
        '
        'lblsin
        '
        Me.lblsin.AutoSize = True
        Me.lblsin.Location = New System.Drawing.Point(265, 64)
        Me.lblsin.Name = "lblsin"
        Me.lblsin.Size = New System.Drawing.Size(124, 13)
        Me.lblsin.TabIndex = 11
        Me.lblsin.Text = "Social Insurance number"
        '
        'lblsupervisor
        '
        Me.lblsupervisor.AutoSize = True
        Me.lblsupervisor.Location = New System.Drawing.Point(36, 277)
        Me.lblsupervisor.Name = "lblsupervisor"
        Me.lblsupervisor.Size = New System.Drawing.Size(57, 13)
        Me.lblsupervisor.TabIndex = 12
        Me.lblsupervisor.Text = "Supervisor"
        '
        'lbldept
        '
        Me.lbldept.AutoSize = True
        Me.lbldept.Location = New System.Drawing.Point(45, 236)
        Me.lbldept.Name = "lbldept"
        Me.lbldept.Size = New System.Drawing.Size(62, 13)
        Me.lbldept.TabIndex = 13
        Me.lbldept.Text = "Department"
        '
        'lbljobid
        '
        Me.lbljobid.AutoSize = True
        Me.lbljobid.Location = New System.Drawing.Point(214, 280)
        Me.lbljobid.Name = "lbljobid"
        Me.lbljobid.Size = New System.Drawing.Size(38, 13)
        Me.lbljobid.TabIndex = 14
        Me.lbljobid.Text = "JobID:"
        '
        'lblpayrate
        '
        Me.lblpayrate.AutoSize = True
        Me.lblpayrate.Location = New System.Drawing.Point(382, 278)
        Me.lblpayrate.Name = "lblpayrate"
        Me.lblpayrate.Size = New System.Drawing.Size(46, 13)
        Me.lblpayrate.TabIndex = 15
        Me.lblpayrate.Text = "Payrate:"
        '
        'txtfirstname
        '
        Me.txtfirstname.Location = New System.Drawing.Point(78, 24)
        Me.txtfirstname.Name = "txtfirstname"
        Me.txtfirstname.Size = New System.Drawing.Size(120, 20)
        Me.txtfirstname.TabIndex = 16
        '
        'txtlastname
        '
        Me.txtlastname.Location = New System.Drawing.Point(414, 21)
        Me.txtlastname.Name = "txtlastname"
        Me.txtlastname.Size = New System.Drawing.Size(99, 20)
        Me.txtlastname.TabIndex = 17
        '
        'txtmiddleinit
        '
        Me.txtmiddleinit.Location = New System.Drawing.Point(285, 21)
        Me.txtmiddleinit.Name = "txtmiddleinit"
        Me.txtmiddleinit.Size = New System.Drawing.Size(45, 20)
        Me.txtmiddleinit.TabIndex = 18
        '
        'txtstreetaddress
        '
        Me.txtstreetaddress.Location = New System.Drawing.Point(104, 105)
        Me.txtstreetaddress.Name = "txtstreetaddress"
        Me.txtstreetaddress.Size = New System.Drawing.Size(125, 20)
        Me.txtstreetaddress.TabIndex = 19
        '
        'txtsin
        '
        Me.txtsin.Location = New System.Drawing.Point(395, 65)
        Me.txtsin.Name = "txtsin"
        Me.txtsin.Size = New System.Drawing.Size(124, 20)
        Me.txtsin.TabIndex = 20
        '
        'txtcity
        '
        Me.txtcity.Location = New System.Drawing.Point(293, 105)
        Me.txtcity.Name = "txtcity"
        Me.txtcity.Size = New System.Drawing.Size(134, 20)
        Me.txtcity.TabIndex = 22
        '
        'txtpostal
        '
        Me.txtpostal.Location = New System.Drawing.Point(301, 144)
        Me.txtpostal.Name = "txtpostal"
        Me.txtpostal.Size = New System.Drawing.Size(52, 20)
        Me.txtpostal.TabIndex = 23
        '
        'txtpayrate
        '
        Me.txtpayrate.Location = New System.Drawing.Point(442, 280)
        Me.txtpayrate.Name = "txtpayrate"
        Me.txtpayrate.Size = New System.Drawing.Size(48, 20)
        Me.txtpayrate.TabIndex = 25
        '
        'txtemail
        '
        Me.txtemail.Location = New System.Drawing.Point(420, 175)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(140, 20)
        Me.txtemail.TabIndex = 27
        '
        'cbosupervisor
        '
        Me.cbosupervisor.FormattingEnabled = True
        Me.cbosupervisor.Location = New System.Drawing.Point(110, 277)
        Me.cbosupervisor.Name = "cbosupervisor"
        Me.cbosupervisor.Size = New System.Drawing.Size(75, 21)
        Me.cbosupervisor.TabIndex = 28
        '
        'cbodept
        '
        Me.cbodept.FormattingEnabled = True
        Me.cbodept.Location = New System.Drawing.Point(130, 229)
        Me.cbodept.Name = "cbodept"
        Me.cbodept.Size = New System.Drawing.Size(53, 21)
        Me.cbodept.TabIndex = 29
        '
        'cbojobid
        '
        Me.cbojobid.FormattingEnabled = True
        Me.cbojobid.Location = New System.Drawing.Point(268, 279)
        Me.cbojobid.Name = "cbojobid"
        Me.cbojobid.Size = New System.Drawing.Size(81, 21)
        Me.cbojobid.TabIndex = 30
        '
        'dtpdateofbirth
        '
        Me.dtpdateofbirth.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpdateofbirth.Location = New System.Drawing.Point(125, 64)
        Me.dtpdateofbirth.Name = "dtpdateofbirth"
        Me.dtpdateofbirth.Size = New System.Drawing.Size(83, 20)
        Me.dtpdateofbirth.TabIndex = 31
        '
        'btnsave
        '
        Me.btnsave.Location = New System.Drawing.Point(284, 360)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(142, 32)
        Me.btnsave.TabIndex = 32
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'btnreset
        '
        Me.btnreset.Location = New System.Drawing.Point(62, 344)
        Me.btnreset.Name = "btnreset"
        Me.btnreset.Size = New System.Drawing.Size(135, 47)
        Me.btnreset.TabIndex = 33
        Me.btnreset.Text = "reset"
        Me.btnreset.UseVisualStyleBackColor = True
        '
        'lblresult
        '
        Me.lblresult.Location = New System.Drawing.Point(21, 424)
        Me.lblresult.Name = "lblresult"
        Me.lblresult.Size = New System.Drawing.Size(469, 41)
        Me.lblresult.TabIndex = 34
        Me.lblresult.Text = "Errors and result"
        '
        'cboProv
        '
        Me.cboProv.FormattingEnabled = True
        Me.cboProv.Items.AddRange(New Object() {"NB", "NS", "PE", "NF", "QC", "ON"})
        Me.cboProv.Location = New System.Drawing.Point(91, 144)
        Me.cboProv.Name = "cboProv"
        Me.cboProv.Size = New System.Drawing.Size(121, 21)
        Me.cboProv.TabIndex = 35
        '
        'mtxworkphone
        '
        Me.mtxworkphone.Location = New System.Drawing.Point(91, 175)
        Me.mtxworkphone.Mask = "(999) 000-0000"
        Me.mtxworkphone.Name = "mtxworkphone"
        Me.mtxworkphone.Size = New System.Drawing.Size(100, 20)
        Me.mtxworkphone.TabIndex = 36
        '
        'mtxcellphone
        '
        Me.mtxcellphone.Location = New System.Drawing.Point(277, 175)
        Me.mtxcellphone.Mask = "(999) 000-0000"
        Me.mtxcellphone.Name = "mtxcellphone"
        Me.mtxcellphone.Size = New System.Drawing.Size(100, 20)
        Me.mtxcellphone.TabIndex = 37
        '
        'AddEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(572, 494)
        Me.Controls.Add(Me.mtxcellphone)
        Me.Controls.Add(Me.mtxworkphone)
        Me.Controls.Add(Me.cboProv)
        Me.Controls.Add(Me.lblresult)
        Me.Controls.Add(Me.btnreset)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.dtpdateofbirth)
        Me.Controls.Add(Me.cbojobid)
        Me.Controls.Add(Me.cbodept)
        Me.Controls.Add(Me.cbosupervisor)
        Me.Controls.Add(Me.txtemail)
        Me.Controls.Add(Me.txtpayrate)
        Me.Controls.Add(Me.txtpostal)
        Me.Controls.Add(Me.txtcity)
        Me.Controls.Add(Me.txtsin)
        Me.Controls.Add(Me.txtstreetaddress)
        Me.Controls.Add(Me.txtmiddleinit)
        Me.Controls.Add(Me.txtlastname)
        Me.Controls.Add(Me.txtfirstname)
        Me.Controls.Add(Me.lblpayrate)
        Me.Controls.Add(Me.lbljobid)
        Me.Controls.Add(Me.lbldept)
        Me.Controls.Add(Me.lblsupervisor)
        Me.Controls.Add(Me.lblsin)
        Me.Controls.Add(Me.lblemail)
        Me.Controls.Add(Me.lblcellphone)
        Me.Controls.Add(Me.lblworkphone)
        Me.Controls.Add(Me.lblpostal)
        Me.Controls.Add(Me.lblcity)
        Me.Controls.Add(Me.lblprov)
        Me.Controls.Add(Me.lblstreetaddress)
        Me.Controls.Add(Me.lbldob)
        Me.Controls.Add(Me.lblfirstname)
        Me.Controls.Add(Me.lblmiddleint)
        Me.Controls.Add(Me.lbllastname)
        Me.Name = "AddEmployee"
        Me.Text = "AddEmp"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbllastname As System.Windows.Forms.Label
    Friend WithEvents lblmiddleint As System.Windows.Forms.Label
    Friend WithEvents lblfirstname As System.Windows.Forms.Label
    Friend WithEvents lbldob As System.Windows.Forms.Label
    Friend WithEvents lblstreetaddress As System.Windows.Forms.Label
    Friend WithEvents lblprov As System.Windows.Forms.Label
    Friend WithEvents lblcity As System.Windows.Forms.Label
    Friend WithEvents lblpostal As System.Windows.Forms.Label
    Friend WithEvents lblworkphone As System.Windows.Forms.Label
    Friend WithEvents lblcellphone As System.Windows.Forms.Label
    Friend WithEvents lblemail As System.Windows.Forms.Label
    Friend WithEvents lblsin As System.Windows.Forms.Label
    Friend WithEvents lblsupervisor As System.Windows.Forms.Label
    Friend WithEvents lbldept As System.Windows.Forms.Label
    Friend WithEvents lbljobid As System.Windows.Forms.Label
    Friend WithEvents lblpayrate As System.Windows.Forms.Label
    Friend WithEvents txtfirstname As System.Windows.Forms.TextBox
    Friend WithEvents txtlastname As System.Windows.Forms.TextBox
    Friend WithEvents txtmiddleinit As System.Windows.Forms.TextBox
    Friend WithEvents txtstreetaddress As System.Windows.Forms.TextBox
    Friend WithEvents txtsin As System.Windows.Forms.TextBox
    Friend WithEvents txtcity As System.Windows.Forms.TextBox
    Friend WithEvents txtpostal As System.Windows.Forms.TextBox
    Friend WithEvents txtpayrate As System.Windows.Forms.TextBox
    Friend WithEvents txtemail As System.Windows.Forms.TextBox
    Friend WithEvents cbosupervisor As System.Windows.Forms.ComboBox
    Friend WithEvents cbodept As System.Windows.Forms.ComboBox
    Friend WithEvents cbojobid As System.Windows.Forms.ComboBox
    Friend WithEvents dtpdateofbirth As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents btnreset As System.Windows.Forms.Button
    Friend WithEvents lblresult As System.Windows.Forms.Label
    Friend WithEvents cboProv As System.Windows.Forms.ComboBox
    Friend WithEvents mtxworkphone As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mtxcellphone As System.Windows.Forms.MaskedTextBox
End Class
