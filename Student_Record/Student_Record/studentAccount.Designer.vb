<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class studentAccount
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
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.fname = New System.Windows.Forms.Label()
        Me.studentID = New System.Windows.Forms.Label()
        Me.lname = New System.Windows.Forms.Label()
        Me.age = New System.Windows.Forms.Label()
        Me.email = New System.Windows.Forms.Label()
        Me.syear = New System.Windows.Forms.Label()
        Me.contact = New System.Windows.Forms.Label()
        Me.mname = New System.Windows.Forms.Label()
        Me.gender = New System.Windows.Forms.Label()
        Me.address = New System.Windows.Forms.Label()
        Me.guardian = New System.Windows.Forms.Label()
        Me.gcontact = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.pictureLbl = New System.Windows.Forms.Label()
        Me.MemberBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.STUDENT_RECORDDataSet = New Student_Record.STUDENT_RECORDDataSet()
        Me.MemberTableAdapter = New Student_Record.STUDENT_RECORDDataSetTableAdapters.MemberTableAdapter()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MemberBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.STUDENT_RECORDDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(235, 263)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(45, 13)
        Me.Label14.TabIndex = 51
        Me.Label14.Text = "Gender:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(230, 334)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(50, 26)
        Me.Label13.TabIndex = 50
        Me.Label13.Text = "Guardian" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Contact:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(227, 311)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(53, 13)
        Me.Label12.TabIndex = 49
        Me.Label12.Text = "Guardian:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(33, 446)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(47, 13)
        Me.Label11.TabIndex = 48
        Me.Label11.Text = "Contact:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(8, 393)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 26)
        Me.Label10.TabIndex = 47
        Me.Label10.Text = "School" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Year Entered:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(45, 353)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 13)
        Me.Label8.TabIndex = 45
        Me.Label8.Text = "Email:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(32, 530)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 13)
        Me.Label7.TabIndex = 44
        Me.Label7.Text = "Address:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(51, 311)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 13)
        Me.Label6.TabIndex = 43
        Me.Label6.Text = "Age:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(210, 237)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 13)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "Middle name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 263)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "Last name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 237)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "First name:"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.MemberBindingSource, "PICTURE", True))
        Me.PictureBox1.Location = New System.Drawing.Point(11, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(188, 158)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 53
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(40, 80, 40, 40)
        Me.Label2.Size = New System.Drawing.Size(188, 158)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "Picture " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Not Available" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(22, 195)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(61, 13)
        Me.Label15.TabIndex = 54
        Me.Label15.Text = "Student ID:"
        '
        'fname
        '
        Me.fname.AutoSize = True
        Me.fname.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MemberBindingSource, "FIRSTNAME", True))
        Me.fname.Location = New System.Drawing.Point(86, 237)
        Me.fname.Name = "fname"
        Me.fname.Size = New System.Drawing.Size(69, 13)
        Me.fname.TabIndex = 68
        Me.fname.Text = "DATA HERE"
        '
        'studentID
        '
        Me.studentID.AutoSize = True
        Me.studentID.Location = New System.Drawing.Point(86, 195)
        Me.studentID.Name = "studentID"
        Me.studentID.Size = New System.Drawing.Size(69, 13)
        Me.studentID.TabIndex = 69
        Me.studentID.Text = "DATA HERE"
        '
        'lname
        '
        Me.lname.AutoSize = True
        Me.lname.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MemberBindingSource, "LASTNAME", True))
        Me.lname.Location = New System.Drawing.Point(86, 263)
        Me.lname.Name = "lname"
        Me.lname.Size = New System.Drawing.Size(69, 13)
        Me.lname.TabIndex = 70
        Me.lname.Text = "DATA HERE"
        '
        'age
        '
        Me.age.AutoSize = True
        Me.age.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MemberBindingSource, "DOB", True))
        Me.age.Location = New System.Drawing.Point(86, 311)
        Me.age.Name = "age"
        Me.age.Size = New System.Drawing.Size(69, 13)
        Me.age.TabIndex = 71
        Me.age.Text = "DATA HERE"
        '
        'email
        '
        Me.email.AutoSize = True
        Me.email.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MemberBindingSource, "EMAIL", True))
        Me.email.Location = New System.Drawing.Point(86, 353)
        Me.email.Name = "email"
        Me.email.Size = New System.Drawing.Size(69, 13)
        Me.email.TabIndex = 72
        Me.email.Text = "DATA HERE"
        '
        'syear
        '
        Me.syear.AutoSize = True
        Me.syear.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MemberBindingSource, "SYEAR", True))
        Me.syear.Location = New System.Drawing.Point(86, 406)
        Me.syear.Name = "syear"
        Me.syear.Size = New System.Drawing.Size(69, 13)
        Me.syear.TabIndex = 73
        Me.syear.Text = "DATA HERE"
        '
        'contact
        '
        Me.contact.AutoSize = True
        Me.contact.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MemberBindingSource, "CONTACT", True))
        Me.contact.Location = New System.Drawing.Point(86, 446)
        Me.contact.Name = "contact"
        Me.contact.Size = New System.Drawing.Size(69, 13)
        Me.contact.TabIndex = 74
        Me.contact.Text = "DATA HERE"
        '
        'mname
        '
        Me.mname.AutoSize = True
        Me.mname.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MemberBindingSource, "MIDDLENAME", True))
        Me.mname.Location = New System.Drawing.Point(286, 237)
        Me.mname.Name = "mname"
        Me.mname.Size = New System.Drawing.Size(69, 13)
        Me.mname.TabIndex = 75
        Me.mname.Text = "DATA HERE"
        '
        'gender
        '
        Me.gender.AutoSize = True
        Me.gender.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MemberBindingSource, "GENDER", True))
        Me.gender.Location = New System.Drawing.Point(286, 263)
        Me.gender.Name = "gender"
        Me.gender.Size = New System.Drawing.Size(69, 13)
        Me.gender.TabIndex = 76
        Me.gender.Text = "DATA HERE"
        '
        'address
        '
        Me.address.AutoSize = True
        Me.address.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MemberBindingSource, "ADDRESS", True))
        Me.address.Location = New System.Drawing.Point(86, 530)
        Me.address.Name = "address"
        Me.address.Size = New System.Drawing.Size(69, 13)
        Me.address.TabIndex = 77
        Me.address.Text = "DATA HERE"
        '
        'guardian
        '
        Me.guardian.AutoSize = True
        Me.guardian.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MemberBindingSource, "GUARDIAN", True))
        Me.guardian.Location = New System.Drawing.Point(286, 311)
        Me.guardian.Name = "guardian"
        Me.guardian.Size = New System.Drawing.Size(69, 13)
        Me.guardian.TabIndex = 79
        Me.guardian.Text = "DATA HERE"
        '
        'gcontact
        '
        Me.gcontact.AutoSize = True
        Me.gcontact.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MemberBindingSource, "GCONTACT", True))
        Me.gcontact.Location = New System.Drawing.Point(286, 347)
        Me.gcontact.Name = "gcontact"
        Me.gcontact.Size = New System.Drawing.Size(69, 13)
        Me.gcontact.TabIndex = 80
        Me.gcontact.Text = "DATA HERE"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'pictureLbl
        '
        Me.pictureLbl.AutoSize = True
        Me.pictureLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pictureLbl.Location = New System.Drawing.Point(9, 171)
        Me.pictureLbl.Name = "pictureLbl"
        Me.pictureLbl.Size = New System.Drawing.Size(50, 9)
        Me.pictureLbl.TabIndex = 81
        Me.pictureLbl.Text = "DATA HERE"
        '
        'MemberBindingSource
        '
        Me.MemberBindingSource.DataMember = "Member"
        Me.MemberBindingSource.DataSource = Me.STUDENT_RECORDDataSet
        '
        'STUDENT_RECORDDataSet
        '
        Me.STUDENT_RECORDDataSet.DataSetName = "STUDENT_RECORDDataSet"
        Me.STUDENT_RECORDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MemberTableAdapter
        '
        Me.MemberTableAdapter.ClearBeforeFill = True
        '
        'studentAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(535, 596)
        Me.Controls.Add(Me.pictureLbl)
        Me.Controls.Add(Me.gcontact)
        Me.Controls.Add(Me.guardian)
        Me.Controls.Add(Me.address)
        Me.Controls.Add(Me.gender)
        Me.Controls.Add(Me.mname)
        Me.Controls.Add(Me.contact)
        Me.Controls.Add(Me.syear)
        Me.Controls.Add(Me.email)
        Me.Controls.Add(Me.age)
        Me.Controls.Add(Me.lname)
        Me.Controls.Add(Me.studentID)
        Me.Controls.Add(Me.fname)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Name = "studentAccount"
        Me.Text = "Student View"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MemberBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.STUDENT_RECORDDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents fname As Label
    Friend WithEvents studentID As Label
    Friend WithEvents lname As Label
    Friend WithEvents age As Label
    Friend WithEvents email As Label
    Friend WithEvents syear As Label
    Friend WithEvents contact As Label
    Friend WithEvents mname As Label
    Friend WithEvents gender As Label
    Friend WithEvents address As Label
    Friend WithEvents guardian As Label
    Friend WithEvents gcontact As Label
    Friend WithEvents STUDENT_RECORDDataSet As STUDENT_RECORDDataSet
    Friend WithEvents MemberBindingSource As BindingSource
    Friend WithEvents MemberTableAdapter As STUDENT_RECORDDataSetTableAdapters.MemberTableAdapter
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents pictureLbl As Label
End Class
