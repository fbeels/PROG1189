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
        Me.lblsuperid = New System.Windows.Forms.Label()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnsave
        '
        Me.btnsave.Location = New System.Drawing.Point(262, 546)
        Me.btnsave.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(402, 72)
        Me.btnsave.TabIndex = 32
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'btnreset
        '
        Me.btnreset.Location = New System.Drawing.Point(28, 546)
        Me.btnreset.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnreset.Name = "btnreset"
        Me.btnreset.Size = New System.Drawing.Size(202, 72)
        Me.btnreset.TabIndex = 33
        Me.btnreset.Text = "reset"
        Me.btnreset.UseVisualStyleBackColor = True
        '
        'lblresult
        '
        Me.lblresult.BackColor = System.Drawing.Color.LemonChiffon
        Me.lblresult.Location = New System.Drawing.Point(24, 654)
        Me.lblresult.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblresult.Name = "lblresult"
        Me.lblresult.Size = New System.Drawing.Size(704, 63)
        Me.lblresult.TabIndex = 34
        Me.lblresult.Text = "Errors and result"
        '
        'btnprefill
        '
        Me.btnprefill.Location = New System.Drawing.Point(672, 574)
        Me.btnprefill.Name = "btnprefill"
        Me.btnprefill.Size = New System.Drawing.Size(63, 45)
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
        Me.GroupBox1.Location = New System.Drawing.Point(16, 26)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(718, 226)
        Me.GroupBox1.TabIndex = 39
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Personal Information"
        '
        'mtxcellphone
        '
        Me.mtxcellphone.Location = New System.Drawing.Point(454, 186)
        Me.mtxcellphone.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.mtxcellphone.Mask = "(999) 000-0000"
        Me.mtxcellphone.Name = "mtxcellphone"
        Me.mtxcellphone.Size = New System.Drawing.Size(148, 26)
        Me.mtxcellphone.TabIndex = 49
        '
        'lblcellphone
        '
        Me.lblcellphone.AutoSize = True
        Me.lblcellphone.Location = New System.Drawing.Point(360, 186)
        Me.lblcellphone.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblcellphone.Name = "lblcellphone"
        Me.lblcellphone.Size = New System.Drawing.Size(84, 20)
        Me.lblcellphone.TabIndex = 48
        Me.lblcellphone.Text = "Cell phone"
        '
        'txtsin
        '
        Me.txtsin.Location = New System.Drawing.Point(135, 175)
        Me.txtsin.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtsin.Name = "txtsin"
        Me.txtsin.Size = New System.Drawing.Size(184, 26)
        Me.txtsin.TabIndex = 47
        '
        'lblsin
        '
        Me.lblsin.AutoSize = True
        Me.lblsin.Location = New System.Drawing.Point(88, 185)
        Me.lblsin.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblsin.Name = "lblsin"
        Me.lblsin.Size = New System.Drawing.Size(36, 20)
        Me.lblsin.TabIndex = 46
        Me.lblsin.Text = "SIN"
        '
        'dtpdateofbirth
        '
        Me.dtpdateofbirth.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpdateofbirth.Location = New System.Drawing.Point(135, 135)
        Me.dtpdateofbirth.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dtpdateofbirth.Name = "dtpdateofbirth"
        Me.dtpdateofbirth.Size = New System.Drawing.Size(122, 26)
        Me.dtpdateofbirth.TabIndex = 45
        '
        'lbldob
        '
        Me.lbldob.AutoSize = True
        Me.lbldob.Location = New System.Drawing.Point(28, 140)
        Me.lbldob.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbldob.Name = "lbldob"
        Me.lbldob.Size = New System.Drawing.Size(99, 20)
        Me.lbldob.TabIndex = 44
        Me.lbldob.Text = "Date of Birth"
        '
        'cboProv
        '
        Me.cboProv.FormattingEnabled = True
        Me.cboProv.Items.AddRange(New Object() {"NB", "NS", "PE", "NF", "QC", "ON"})
        Me.cboProv.Location = New System.Drawing.Point(454, 103)
        Me.cboProv.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cboProv.Name = "cboProv"
        Me.cboProv.Size = New System.Drawing.Size(79, 28)
        Me.cboProv.TabIndex = 43
        '
        'txtpostal
        '
        Me.txtpostal.Location = New System.Drawing.Point(454, 142)
        Me.txtpostal.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtpostal.Name = "txtpostal"
        Me.txtpostal.Size = New System.Drawing.Size(76, 26)
        Me.txtpostal.TabIndex = 42
        '
        'txtcity
        '
        Me.txtcity.Location = New System.Drawing.Point(454, 68)
        Me.txtcity.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtcity.Name = "txtcity"
        Me.txtcity.Size = New System.Drawing.Size(199, 26)
        Me.txtcity.TabIndex = 41
        '
        'txtstreetaddress
        '
        Me.txtstreetaddress.Location = New System.Drawing.Point(454, 25)
        Me.txtstreetaddress.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtstreetaddress.Name = "txtstreetaddress"
        Me.txtstreetaddress.Size = New System.Drawing.Size(186, 26)
        Me.txtstreetaddress.TabIndex = 40
        '
        'lblpostal
        '
        Me.lblpostal.AutoSize = True
        Me.lblpostal.Location = New System.Drawing.Point(351, 146)
        Me.lblpostal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblpostal.Name = "lblpostal"
        Me.lblpostal.Size = New System.Drawing.Size(92, 20)
        Me.lblpostal.TabIndex = 39
        Me.lblpostal.Text = "Postal code"
        '
        'lblcity
        '
        Me.lblcity.AutoSize = True
        Me.lblcity.Location = New System.Drawing.Point(411, 72)
        Me.lblcity.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblcity.Name = "lblcity"
        Me.lblcity.Size = New System.Drawing.Size(32, 20)
        Me.lblcity.TabIndex = 38
        Me.lblcity.Text = "city"
        '
        'lblprov
        '
        Me.lblprov.AutoSize = True
        Me.lblprov.Location = New System.Drawing.Point(372, 103)
        Me.lblprov.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblprov.Name = "lblprov"
        Me.lblprov.Size = New System.Drawing.Size(69, 20)
        Me.lblprov.TabIndex = 37
        Me.lblprov.Text = "Province"
        '
        'lblstreetaddress
        '
        Me.lblstreetaddress.AutoSize = True
        Me.lblstreetaddress.Location = New System.Drawing.Point(332, 29)
        Me.lblstreetaddress.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblstreetaddress.Name = "lblstreetaddress"
        Me.lblstreetaddress.Size = New System.Drawing.Size(116, 20)
        Me.lblstreetaddress.TabIndex = 36
        Me.lblstreetaddress.Text = "Street Address"
        '
        'txtmiddleinit
        '
        Me.txtmiddleinit.Location = New System.Drawing.Point(134, 63)
        Me.txtmiddleinit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtmiddleinit.Name = "txtmiddleinit"
        Me.txtmiddleinit.Size = New System.Drawing.Size(66, 26)
        Me.txtmiddleinit.TabIndex = 24
        '
        'txtlastname
        '
        Me.txtlastname.Location = New System.Drawing.Point(134, 98)
        Me.txtlastname.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtlastname.Name = "txtlastname"
        Me.txtlastname.Size = New System.Drawing.Size(146, 26)
        Me.txtlastname.TabIndex = 23
        '
        'txtfirstname
        '
        Me.txtfirstname.Location = New System.Drawing.Point(135, 29)
        Me.txtfirstname.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtfirstname.Name = "txtfirstname"
        Me.txtfirstname.Size = New System.Drawing.Size(178, 26)
        Me.txtfirstname.TabIndex = 22
        '
        'lblfirstname
        '
        Me.lblfirstname.AutoSize = True
        Me.lblfirstname.Location = New System.Drawing.Point(45, 29)
        Me.lblfirstname.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblfirstname.Name = "lblfirstname"
        Me.lblfirstname.Size = New System.Drawing.Size(81, 20)
        Me.lblfirstname.TabIndex = 21
        Me.lblfirstname.Text = "first Name"
        '
        'lblmiddleint
        '
        Me.lblmiddleint.AutoSize = True
        Me.lblmiddleint.Location = New System.Drawing.Point(28, 66)
        Me.lblmiddleint.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblmiddleint.Name = "lblmiddleint"
        Me.lblmiddleint.Size = New System.Drawing.Size(96, 20)
        Me.lblmiddleint.TabIndex = 20
        Me.lblmiddleint.Text = "Middle Initial"
        '
        'lbllastname
        '
        Me.lbllastname.AutoSize = True
        Me.lbllastname.Location = New System.Drawing.Point(30, 98)
        Me.lbllastname.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbllastname.Name = "lbllastname"
        Me.lbllastname.Size = New System.Drawing.Size(90, 20)
        Me.lbllastname.TabIndex = 19
        Me.lbllastname.Text = "Last Name:"
        '
        'GroupBox2
        '
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
        Me.GroupBox2.Location = New System.Drawing.Point(14, 269)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox2.Size = New System.Drawing.Size(722, 268)
        Me.GroupBox2.TabIndex = 40
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Employment Information"
        '
        'lblsupername
        '
        Me.lblsupername.AutoSize = True
        Me.lblsupername.Location = New System.Drawing.Point(145, 83)
        Me.lblsupername.Name = "lblsupername"
        Me.lblsupername.Size = New System.Drawing.Size(57, 20)
        Me.lblsupername.TabIndex = 43
        Me.lblsupername.Text = "Label1"
        '
        'txtemail
        '
        Me.txtemail.Location = New System.Drawing.Point(472, 77)
        Me.txtemail.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(208, 26)
        Me.txtemail.TabIndex = 42
        '
        'lblemail
        '
        Me.lblemail.AutoSize = True
        Me.lblemail.Location = New System.Drawing.Point(402, 82)
        Me.lblemail.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblemail.Name = "lblemail"
        Me.lblemail.Size = New System.Drawing.Size(46, 20)
        Me.lblemail.TabIndex = 41
        Me.lblemail.Text = "email"
        '
        'mtxworkphone
        '
        Me.mtxworkphone.Location = New System.Drawing.Point(472, 28)
        Me.mtxworkphone.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.mtxworkphone.Mask = "(999) 000-0000"
        Me.mtxworkphone.Name = "mtxworkphone"
        Me.mtxworkphone.Size = New System.Drawing.Size(148, 26)
        Me.mtxworkphone.TabIndex = 40
        '
        'lblworkphone
        '
        Me.lblworkphone.AutoSize = True
        Me.lblworkphone.Location = New System.Drawing.Point(363, 32)
        Me.lblworkphone.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblworkphone.Name = "lblworkphone"
        Me.lblworkphone.Size = New System.Drawing.Size(96, 20)
        Me.lblworkphone.TabIndex = 39
        Me.lblworkphone.Text = "Work Phone"
        '
        'cbojobid
        '
        Me.cbojobid.FormattingEnabled = True
        Me.cbojobid.Location = New System.Drawing.Point(147, 118)
        Me.cbojobid.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cbojobid.Name = "cbojobid"
        Me.cbojobid.Size = New System.Drawing.Size(208, 28)
        Me.cbojobid.TabIndex = 38
        '
        'cbodept
        '
        Me.cbodept.FormattingEnabled = True
        Me.cbodept.Location = New System.Drawing.Point(147, 35)
        Me.cbodept.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cbodept.Name = "cbodept"
        Me.cbodept.Size = New System.Drawing.Size(208, 28)
        Me.cbodept.TabIndex = 37
        '
        'txtpayrate
        '
        Me.txtpayrate.Location = New System.Drawing.Point(146, 189)
        Me.txtpayrate.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtpayrate.Name = "txtpayrate"
        Me.txtpayrate.Size = New System.Drawing.Size(70, 26)
        Me.txtpayrate.TabIndex = 35
        '
        'lblpayrate
        '
        Me.lblpayrate.AutoSize = True
        Me.lblpayrate.Location = New System.Drawing.Point(56, 186)
        Me.lblpayrate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblpayrate.Name = "lblpayrate"
        Me.lblpayrate.Size = New System.Drawing.Size(67, 20)
        Me.lblpayrate.TabIndex = 34
        Me.lblpayrate.Text = "Payrate:"
        '
        'lbljobid
        '
        Me.lbljobid.AutoSize = True
        Me.lbljobid.Location = New System.Drawing.Point(88, 128)
        Me.lbljobid.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbljobid.Name = "lbljobid"
        Me.lbljobid.Size = New System.Drawing.Size(39, 20)
        Me.lbljobid.TabIndex = 33
        Me.lbljobid.Text = "Job:"
        '
        'lbldept
        '
        Me.lbldept.AutoSize = True
        Me.lbldept.Location = New System.Drawing.Point(36, 40)
        Me.lbldept.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbldept.Name = "lbldept"
        Me.lbldept.Size = New System.Drawing.Size(94, 20)
        Me.lbldept.TabIndex = 32
        Me.lbldept.Text = "Department"
        '
        'lblsupervisor
        '
        Me.lblsupervisor.AutoSize = True
        Me.lblsupervisor.Location = New System.Drawing.Point(48, 86)
        Me.lblsupervisor.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblsupervisor.Name = "lblsupervisor"
        Me.lblsupervisor.Size = New System.Drawing.Size(84, 20)
        Me.lblsupervisor.TabIndex = 31
        Me.lblsupervisor.Text = "Supervisor"
        '
        'lblsuperid
        '
        Me.lblsuperid.AutoSize = True
        Me.lblsuperid.Location = New System.Drawing.Point(7, 86)
        Me.lblsuperid.Name = "lblsuperid"
        Me.lblsuperid.Size = New System.Drawing.Size(57, 20)
        Me.lblsuperid.TabIndex = 44
        Me.lblsuperid.Text = "Label1"
        '
        'AddEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(765, 760)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnprefill)
        Me.Controls.Add(Me.lblresult)
        Me.Controls.Add(Me.btnreset)
        Me.Controls.Add(Me.btnsave)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
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
End Class
