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
        Me.btnprefill = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbllastname
        '
        Me.lbllastname.AutoSize = True
        Me.lbllastname.Location = New System.Drawing.Point(566, 32)
        Me.lbllastname.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbllastname.Name = "lbllastname"
        Me.lbllastname.Size = New System.Drawing.Size(90, 20)
        Me.lbllastname.TabIndex = 0
        Me.lbllastname.Text = "Last Name:"
        '
        'lblmiddleint
        '
        Me.lblmiddleint.AutoSize = True
        Me.lblmiddleint.Location = New System.Drawing.Point(338, 32)
        Me.lblmiddleint.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblmiddleint.Name = "lblmiddleint"
        Me.lblmiddleint.Size = New System.Drawing.Size(96, 20)
        Me.lblmiddleint.TabIndex = 1
        Me.lblmiddleint.Text = "Middle Initial"
        '
        'lblfirstname
        '
        Me.lblfirstname.AutoSize = True
        Me.lblfirstname.Location = New System.Drawing.Point(13, 32)
        Me.lblfirstname.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblfirstname.Name = "lblfirstname"
        Me.lblfirstname.Size = New System.Drawing.Size(81, 20)
        Me.lblfirstname.TabIndex = 2
        Me.lblfirstname.Text = "first Name"
        '
        'lbldob
        '
        Me.lbldob.AutoSize = True
        Me.lbldob.Location = New System.Drawing.Point(123, 96)
        Me.lbldob.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbldob.Name = "lbldob"
        Me.lbldob.Size = New System.Drawing.Size(99, 20)
        Me.lbldob.TabIndex = 3
        Me.lbldob.Text = "Date of Birth"
        '
        'lblstreetaddress
        '
        Me.lblstreetaddress.AutoSize = True
        Me.lblstreetaddress.Location = New System.Drawing.Point(123, 162)
        Me.lblstreetaddress.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblstreetaddress.Name = "lblstreetaddress"
        Me.lblstreetaddress.Size = New System.Drawing.Size(116, 20)
        Me.lblstreetaddress.TabIndex = 4
        Me.lblstreetaddress.Text = "Street Address"
        '
        'lblprov
        '
        Me.lblprov.AutoSize = True
        Me.lblprov.Location = New System.Drawing.Point(123, 228)
        Me.lblprov.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblprov.Name = "lblprov"
        Me.lblprov.Size = New System.Drawing.Size(69, 20)
        Me.lblprov.TabIndex = 5
        Me.lblprov.Text = "Province"
        '
        'lblcity
        '
        Me.lblcity.AutoSize = True
        Me.lblcity.Location = New System.Drawing.Point(452, 162)
        Me.lblcity.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblcity.Name = "lblcity"
        Me.lblcity.Size = New System.Drawing.Size(32, 20)
        Me.lblcity.TabIndex = 6
        Me.lblcity.Text = "city"
        '
        'lblpostal
        '
        Me.lblpostal.AutoSize = True
        Me.lblpostal.Location = New System.Drawing.Point(340, 226)
        Me.lblpostal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblpostal.Name = "lblpostal"
        Me.lblpostal.Size = New System.Drawing.Size(92, 20)
        Me.lblpostal.TabIndex = 7
        Me.lblpostal.Text = "Postal code"
        '
        'lblworkphone
        '
        Me.lblworkphone.AutoSize = True
        Me.lblworkphone.Location = New System.Drawing.Point(27, 277)
        Me.lblworkphone.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblworkphone.Name = "lblworkphone"
        Me.lblworkphone.Size = New System.Drawing.Size(96, 20)
        Me.lblworkphone.TabIndex = 8
        Me.lblworkphone.Text = "Work Phone"
        '
        'lblcellphone
        '
        Me.lblcellphone.AutoSize = True
        Me.lblcellphone.Location = New System.Drawing.Point(302, 274)
        Me.lblcellphone.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblcellphone.Name = "lblcellphone"
        Me.lblcellphone.Size = New System.Drawing.Size(84, 20)
        Me.lblcellphone.TabIndex = 9
        Me.lblcellphone.Text = "Cell phone"
        '
        'lblemail
        '
        Me.lblemail.AutoSize = True
        Me.lblemail.Location = New System.Drawing.Point(574, 274)
        Me.lblemail.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblemail.Name = "lblemail"
        Me.lblemail.Size = New System.Drawing.Size(46, 20)
        Me.lblemail.TabIndex = 10
        Me.lblemail.Text = "email"
        '
        'lblsin
        '
        Me.lblsin.AutoSize = True
        Me.lblsin.Location = New System.Drawing.Point(379, 96)
        Me.lblsin.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblsin.Name = "lblsin"
        Me.lblsin.Size = New System.Drawing.Size(185, 20)
        Me.lblsin.TabIndex = 11
        Me.lblsin.Text = "Social Insurance number"
        '
        'lblsupervisor
        '
        Me.lblsupervisor.AutoSize = True
        Me.lblsupervisor.Location = New System.Drawing.Point(355, 351)
        Me.lblsupervisor.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblsupervisor.Name = "lblsupervisor"
        Me.lblsupervisor.Size = New System.Drawing.Size(84, 20)
        Me.lblsupervisor.TabIndex = 12
        Me.lblsupervisor.Text = "Supervisor"
        '
        'lbldept
        '
        Me.lbldept.AutoSize = True
        Me.lbldept.Location = New System.Drawing.Point(123, 354)
        Me.lbldept.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbldept.Name = "lbldept"
        Me.lbldept.Size = New System.Drawing.Size(94, 20)
        Me.lbldept.TabIndex = 13
        Me.lbldept.Text = "Department"
        '
        'lbljobid
        '
        Me.lbljobid.AutoSize = True
        Me.lbljobid.Location = New System.Drawing.Point(123, 408)
        Me.lbljobid.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbljobid.Name = "lbljobid"
        Me.lbljobid.Size = New System.Drawing.Size(39, 20)
        Me.lbljobid.TabIndex = 14
        Me.lbljobid.Text = "Job:"
        '
        'lblpayrate
        '
        Me.lblpayrate.AutoSize = True
        Me.lblpayrate.Location = New System.Drawing.Point(448, 414)
        Me.lblpayrate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblpayrate.Name = "lblpayrate"
        Me.lblpayrate.Size = New System.Drawing.Size(67, 20)
        Me.lblpayrate.TabIndex = 15
        Me.lblpayrate.Text = "Payrate:"
        '
        'txtfirstname
        '
        Me.txtfirstname.Location = New System.Drawing.Point(127, 32)
        Me.txtfirstname.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtfirstname.Name = "txtfirstname"
        Me.txtfirstname.Size = New System.Drawing.Size(178, 26)
        Me.txtfirstname.TabIndex = 16
        '
        'txtlastname
        '
        Me.txtlastname.Location = New System.Drawing.Point(689, 29)
        Me.txtlastname.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtlastname.Name = "txtlastname"
        Me.txtlastname.Size = New System.Drawing.Size(146, 26)
        Me.txtlastname.TabIndex = 17
        '
        'txtmiddleinit
        '
        Me.txtmiddleinit.Location = New System.Drawing.Point(467, 32)
        Me.txtmiddleinit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtmiddleinit.Name = "txtmiddleinit"
        Me.txtmiddleinit.Size = New System.Drawing.Size(66, 26)
        Me.txtmiddleinit.TabIndex = 18
        '
        'txtstreetaddress
        '
        Me.txtstreetaddress.Location = New System.Drawing.Point(248, 162)
        Me.txtstreetaddress.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtstreetaddress.Name = "txtstreetaddress"
        Me.txtstreetaddress.Size = New System.Drawing.Size(186, 26)
        Me.txtstreetaddress.TabIndex = 19
        '
        'txtsin
        '
        Me.txtsin.Location = New System.Drawing.Point(572, 96)
        Me.txtsin.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtsin.Name = "txtsin"
        Me.txtsin.Size = New System.Drawing.Size(184, 26)
        Me.txtsin.TabIndex = 20
        '
        'txtcity
        '
        Me.txtcity.Location = New System.Drawing.Point(492, 159)
        Me.txtcity.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtcity.Name = "txtcity"
        Me.txtcity.Size = New System.Drawing.Size(199, 26)
        Me.txtcity.TabIndex = 22
        '
        'txtpostal
        '
        Me.txtpostal.Location = New System.Drawing.Point(452, 222)
        Me.txtpostal.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtpostal.Name = "txtpostal"
        Me.txtpostal.Size = New System.Drawing.Size(76, 26)
        Me.txtpostal.TabIndex = 23
        '
        'txtpayrate
        '
        Me.txtpayrate.Location = New System.Drawing.Point(538, 417)
        Me.txtpayrate.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtpayrate.Name = "txtpayrate"
        Me.txtpayrate.Size = New System.Drawing.Size(70, 26)
        Me.txtpayrate.TabIndex = 25
        '
        'txtemail
        '
        Me.txtemail.Location = New System.Drawing.Point(630, 269)
        Me.txtemail.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(208, 26)
        Me.txtemail.TabIndex = 27
        '
        'cbosupervisor
        '
        Me.cbosupervisor.FormattingEnabled = True
        Me.cbosupervisor.Location = New System.Drawing.Point(447, 348)
        Me.cbosupervisor.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cbosupervisor.Name = "cbosupervisor"
        Me.cbosupervisor.Size = New System.Drawing.Size(167, 28)
        Me.cbosupervisor.TabIndex = 28
        '
        'cbodept
        '
        Me.cbodept.FormattingEnabled = True
        Me.cbodept.Location = New System.Drawing.Point(214, 343)
        Me.cbodept.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cbodept.Name = "cbodept"
        Me.cbodept.Size = New System.Drawing.Size(114, 28)
        Me.cbodept.TabIndex = 29
        '
        'cbojobid
        '
        Me.cbojobid.FormattingEnabled = True
        Me.cbojobid.Location = New System.Drawing.Point(204, 406)
        Me.cbojobid.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cbojobid.Name = "cbojobid"
        Me.cbojobid.Size = New System.Drawing.Size(208, 28)
        Me.cbojobid.TabIndex = 30
        '
        'dtpdateofbirth
        '
        Me.dtpdateofbirth.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpdateofbirth.Location = New System.Drawing.Point(237, 91)
        Me.dtpdateofbirth.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dtpdateofbirth.Name = "dtpdateofbirth"
        Me.dtpdateofbirth.Size = New System.Drawing.Size(122, 26)
        Me.dtpdateofbirth.TabIndex = 31
        '
        'btnsave
        '
        Me.btnsave.Location = New System.Drawing.Point(320, 488)
        Me.btnsave.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(402, 72)
        Me.btnsave.TabIndex = 32
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'btnreset
        '
        Me.btnreset.Location = New System.Drawing.Point(86, 488)
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
        Me.lblresult.Location = New System.Drawing.Point(32, 652)
        Me.lblresult.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblresult.Name = "lblresult"
        Me.lblresult.Size = New System.Drawing.Size(704, 63)
        Me.lblresult.TabIndex = 34
        Me.lblresult.Text = "Errors and result"
        '
        'cboProv
        '
        Me.cboProv.FormattingEnabled = True
        Me.cboProv.Items.AddRange(New Object() {"NB", "NS", "PE", "NF", "QC", "ON"})
        Me.cboProv.Location = New System.Drawing.Point(209, 223)
        Me.cboProv.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cboProv.Name = "cboProv"
        Me.cboProv.Size = New System.Drawing.Size(79, 28)
        Me.cboProv.TabIndex = 35
        '
        'mtxworkphone
        '
        Me.mtxworkphone.Location = New System.Drawing.Point(136, 269)
        Me.mtxworkphone.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.mtxworkphone.Mask = "(999) 000-0000"
        Me.mtxworkphone.Name = "mtxworkphone"
        Me.mtxworkphone.Size = New System.Drawing.Size(148, 26)
        Me.mtxworkphone.TabIndex = 36
        '
        'mtxcellphone
        '
        Me.mtxcellphone.Location = New System.Drawing.Point(394, 268)
        Me.mtxcellphone.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.mtxcellphone.Mask = "(999) 000-0000"
        Me.mtxcellphone.Name = "mtxcellphone"
        Me.mtxcellphone.Size = New System.Drawing.Size(148, 26)
        Me.mtxcellphone.TabIndex = 37
        '
        'btnprefill
        '
        Me.btnprefill.Location = New System.Drawing.Point(748, 608)
        Me.btnprefill.Name = "btnprefill"
        Me.btnprefill.Size = New System.Drawing.Size(86, 44)
        Me.btnprefill.TabIndex = 38
        Me.btnprefill.Text = "prefill"
        Me.btnprefill.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'AddEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(858, 760)
        Me.Controls.Add(Me.btnprefill)
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
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "AddEmployee"
        Me.Text = "AddEmp"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents btnprefill As System.Windows.Forms.Button
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
End Class
