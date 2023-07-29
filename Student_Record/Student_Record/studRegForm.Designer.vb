<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class studRegForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.picTxtBox = New System.Windows.Forms.TextBox()
        Me.MemberBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.STUDENT_RECORDDataSet = New Student_Record.STUDENT_RECORDDataSet()
        Me.picBttn = New System.Windows.Forms.Button()
        Me.gconTxtBox = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.guardTxtBox = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.conTxtBox = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.syearBox = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.psswrdTxtBox = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.emailTxtBox = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.addTxtBox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.mnameTxtBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lnameTxtBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.fnameTxtBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.submitBttn = New System.Windows.Forms.Button()
        Me.genderBox = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.MemberTableAdapter = New Student_Record.STUDENT_RECORDDataSetTableAdapters.MemberTableAdapter()
        CType(Me.MemberBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.STUDENT_RECORDDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picTxtBox
        '
        Me.picTxtBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MemberBindingSource, "PICTURE", True))
        Me.picTxtBox.Location = New System.Drawing.Point(99, 212)
        Me.picTxtBox.Name = "picTxtBox"
        Me.picTxtBox.Size = New System.Drawing.Size(157, 20)
        Me.picTxtBox.TabIndex = 64
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
        'picBttn
        '
        Me.picBttn.Location = New System.Drawing.Point(18, 211)
        Me.picBttn.Name = "picBttn"
        Me.picBttn.Size = New System.Drawing.Size(75, 23)
        Me.picBttn.TabIndex = 63
        Me.picBttn.Text = "INS. PIC"
        Me.picBttn.UseVisualStyleBackColor = True
        '
        'gconTxtBox
        '
        Me.gconTxtBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MemberBindingSource, "GCONTACT", True))
        Me.gconTxtBox.Location = New System.Drawing.Point(282, 495)
        Me.gconTxtBox.Name = "gconTxtBox"
        Me.gconTxtBox.Size = New System.Drawing.Size(116, 20)
        Me.gconTxtBox.TabIndex = 62
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(226, 489)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(50, 26)
        Me.Label13.TabIndex = 61
        Me.Label13.Text = "Guardian" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Contact:"
        '
        'guardTxtBox
        '
        Me.guardTxtBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MemberBindingSource, "GUARDIAN", True))
        Me.guardTxtBox.Location = New System.Drawing.Point(282, 463)
        Me.guardTxtBox.Name = "guardTxtBox"
        Me.guardTxtBox.Size = New System.Drawing.Size(116, 20)
        Me.guardTxtBox.TabIndex = 60
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(223, 466)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(53, 13)
        Me.Label12.TabIndex = 59
        Me.Label12.Text = "Guardian:"
        '
        'conTxtBox
        '
        Me.conTxtBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MemberBindingSource, "CONTACT", True))
        Me.conTxtBox.Location = New System.Drawing.Point(82, 463)
        Me.conTxtBox.Name = "conTxtBox"
        Me.conTxtBox.Size = New System.Drawing.Size(116, 20)
        Me.conTxtBox.TabIndex = 58
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(29, 466)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(47, 13)
        Me.Label11.TabIndex = 57
        Me.Label11.Text = "Contact:"
        '
        'syearBox
        '
        Me.syearBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedItem", Me.MemberBindingSource, "SYEAR", True))
        Me.syearBox.FormattingEnabled = True
        Me.syearBox.Items.AddRange(New Object() {"2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030", "2031", "2032", "2034", "2035", "2036", "2037", "2038", "2039", "2040"})
        Me.syearBox.Location = New System.Drawing.Point(82, 418)
        Me.syearBox.Name = "syearBox"
        Me.syearBox.Size = New System.Drawing.Size(62, 21)
        Me.syearBox.TabIndex = 56
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(4, 413)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 26)
        Me.Label10.TabIndex = 55
        Me.Label10.Text = "School" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Year Entered:"
        '
        'psswrdTxtBox
        '
        Me.psswrdTxtBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MemberBindingSource, "PASSWORD", True))
        Me.psswrdTxtBox.Location = New System.Drawing.Point(282, 370)
        Me.psswrdTxtBox.Name = "psswrdTxtBox"
        Me.psswrdTxtBox.Size = New System.Drawing.Size(116, 20)
        Me.psswrdTxtBox.TabIndex = 54
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(220, 373)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 13)
        Me.Label9.TabIndex = 53
        Me.Label9.Text = "Password:"
        '
        'emailTxtBox
        '
        Me.emailTxtBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MemberBindingSource, "EMAIL", True))
        Me.emailTxtBox.Location = New System.Drawing.Point(82, 370)
        Me.emailTxtBox.Name = "emailTxtBox"
        Me.emailTxtBox.Size = New System.Drawing.Size(116, 20)
        Me.emailTxtBox.TabIndex = 52
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(41, 373)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 13)
        Me.Label8.TabIndex = 51
        Me.Label8.Text = "Email:"
        '
        'addTxtBox
        '
        Me.addTxtBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MemberBindingSource, "ADDRESS", True))
        Me.addTxtBox.Location = New System.Drawing.Point(282, 328)
        Me.addTxtBox.Name = "addTxtBox"
        Me.addTxtBox.Size = New System.Drawing.Size(116, 20)
        Me.addTxtBox.TabIndex = 50
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(228, 331)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 13)
        Me.Label7.TabIndex = 49
        Me.Label7.Text = "Address:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd/MM/yy"
        Me.DateTimePicker1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.MemberBindingSource, "DOB", True))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(83, 328)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(76, 20)
        Me.DateTimePicker1.TabIndex = 48
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(23, 331)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 47
        Me.Label6.Text = "Birth Day:"
        '
        'mnameTxtBox
        '
        Me.mnameTxtBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MemberBindingSource, "MIDDLENAME", True))
        Me.mnameTxtBox.Location = New System.Drawing.Point(282, 254)
        Me.mnameTxtBox.Name = "mnameTxtBox"
        Me.mnameTxtBox.Size = New System.Drawing.Size(116, 20)
        Me.mnameTxtBox.TabIndex = 46
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(206, 257)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 13)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "Middle name:"
        '
        'lnameTxtBox
        '
        Me.lnameTxtBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MemberBindingSource, "LASTNAME", True))
        Me.lnameTxtBox.Location = New System.Drawing.Point(82, 280)
        Me.lnameTxtBox.Name = "lnameTxtBox"
        Me.lnameTxtBox.Size = New System.Drawing.Size(116, 20)
        Me.lnameTxtBox.TabIndex = 44
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 283)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "Last name:"
        '
        'fnameTxtBox
        '
        Me.fnameTxtBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MemberBindingSource, "FIRSTNAME", True))
        Me.fnameTxtBox.Location = New System.Drawing.Point(82, 254)
        Me.fnameTxtBox.Name = "fnameTxtBox"
        Me.fnameTxtBox.Size = New System.Drawing.Size(116, 20)
        Me.fnameTxtBox.TabIndex = 42
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 257)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "First name:"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(18, 38)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(238, 168)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 40
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(65)
        Me.Label2.Size = New System.Drawing.Size(238, 168)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Picture " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Not Available" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'submitBttn
        '
        Me.submitBttn.Location = New System.Drawing.Point(323, 543)
        Me.submitBttn.Name = "submitBttn"
        Me.submitBttn.Size = New System.Drawing.Size(75, 23)
        Me.submitBttn.TabIndex = 65
        Me.submitBttn.Text = "SUBMIT"
        Me.submitBttn.UseVisualStyleBackColor = True
        '
        'genderBox
        '
        Me.genderBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedItem", Me.MemberBindingSource, "GENDER", True))
        Me.genderBox.FormattingEnabled = True
        Me.genderBox.Items.AddRange(New Object() {"Male", "Female", "LGBTQ+"})
        Me.genderBox.Location = New System.Drawing.Point(282, 279)
        Me.genderBox.Name = "genderBox"
        Me.genderBox.Size = New System.Drawing.Size(62, 21)
        Me.genderBox.TabIndex = 67
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(231, 282)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(45, 13)
        Me.Label14.TabIndex = 66
        Me.Label14.Text = "Gender:"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'MemberTableAdapter
        '
        Me.MemberTableAdapter.ClearBeforeFill = True
        '
        'studRegForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(412, 602)
        Me.Controls.Add(Me.genderBox)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.submitBttn)
        Me.Controls.Add(Me.picTxtBox)
        Me.Controls.Add(Me.picBttn)
        Me.Controls.Add(Me.gconTxtBox)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.guardTxtBox)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.conTxtBox)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.syearBox)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.psswrdTxtBox)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.emailTxtBox)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.addTxtBox)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.mnameTxtBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lnameTxtBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.fnameTxtBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Name = "studRegForm"
        Me.Text = "Student Registration"
        CType(Me.MemberBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.STUDENT_RECORDDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picTxtBox As TextBox
    Friend WithEvents picBttn As Button
    Friend WithEvents gconTxtBox As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents guardTxtBox As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents conTxtBox As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents syearBox As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents psswrdTxtBox As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents emailTxtBox As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents addTxtBox As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents mnameTxtBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents lnameTxtBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents fnameTxtBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents submitBttn As Button
    Friend WithEvents STUDENT_RECORDDataSet As STUDENT_RECORDDataSet
    Friend WithEvents MemberBindingSource As BindingSource
    Friend WithEvents MemberTableAdapter As STUDENT_RECORDDataSetTableAdapters.MemberTableAdapter
    Friend WithEvents genderBox As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
