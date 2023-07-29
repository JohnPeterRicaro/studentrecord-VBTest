<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminGridView
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FIRSTNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LASTNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MIDDLENAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GENDERDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EMAILDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ADDRESSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CONTACTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DOBDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GUARDIANDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GCONTACTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SYEARDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PASSWORDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PICTUREDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.USERTYPEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MemberBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.STUDENT_RECORDDataSet = New Student_Record.STUDENT_RECORDDataSet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.fnameTxtBox = New System.Windows.Forms.TextBox()
        Me.lnameTxtBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.mnameTxtBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.addTxtBox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.emailTxtBox = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.psswrdTxtBox = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.syearBox = New System.Windows.Forms.ComboBox()
        Me.conTxtBox = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.guardTxtBox = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.gconTxtBox = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.insertBttn = New System.Windows.Forms.Button()
        Me.updateBttn = New System.Windows.Forms.Button()
        Me.deleteBttn = New System.Windows.Forms.Button()
        Me.prevBttn = New System.Windows.Forms.Button()
        Me.nxtBttn = New System.Windows.Forms.Button()
        Me.firstBttn = New System.Windows.Forms.Button()
        Me.lastBttn = New System.Windows.Forms.Button()
        Me.picTxtBox = New System.Windows.Forms.TextBox()
        Me.picBttn = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.genderBox = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.MemberTableAdapter = New Student_Record.STUDENT_RECORDDataSetTableAdapters.MemberTableAdapter()
        Me.idlbl = New System.Windows.Forms.Label()
        Me.searchBttn = New System.Windows.Forms.Button()
        Me.searchTxtBox = New System.Windows.Forms.TextBox()
        Me.refreshBttn = New System.Windows.Forms.Button()
        Me.registBox = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MemberBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.STUDENT_RECORDDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.FIRSTNAMEDataGridViewTextBoxColumn, Me.LASTNAMEDataGridViewTextBoxColumn, Me.MIDDLENAMEDataGridViewTextBoxColumn, Me.GENDERDataGridViewTextBoxColumn, Me.EMAILDataGridViewTextBoxColumn, Me.ADDRESSDataGridViewTextBoxColumn, Me.CONTACTDataGridViewTextBoxColumn, Me.DOBDataGridViewTextBoxColumn, Me.GUARDIANDataGridViewTextBoxColumn, Me.GCONTACTDataGridViewTextBoxColumn, Me.SYEARDataGridViewTextBoxColumn, Me.PASSWORDDataGridViewTextBoxColumn, Me.PICTUREDataGridViewTextBoxColumn, Me.USERTYPEDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.MemberBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(15, 655)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(577, 170)
        Me.DataGridView1.TabIndex = 0
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        '
        'FIRSTNAMEDataGridViewTextBoxColumn
        '
        Me.FIRSTNAMEDataGridViewTextBoxColumn.DataPropertyName = "FIRSTNAME"
        Me.FIRSTNAMEDataGridViewTextBoxColumn.HeaderText = "FIRSTNAME"
        Me.FIRSTNAMEDataGridViewTextBoxColumn.Name = "FIRSTNAMEDataGridViewTextBoxColumn"
        '
        'LASTNAMEDataGridViewTextBoxColumn
        '
        Me.LASTNAMEDataGridViewTextBoxColumn.DataPropertyName = "LASTNAME"
        Me.LASTNAMEDataGridViewTextBoxColumn.HeaderText = "LASTNAME"
        Me.LASTNAMEDataGridViewTextBoxColumn.Name = "LASTNAMEDataGridViewTextBoxColumn"
        '
        'MIDDLENAMEDataGridViewTextBoxColumn
        '
        Me.MIDDLENAMEDataGridViewTextBoxColumn.DataPropertyName = "MIDDLENAME"
        Me.MIDDLENAMEDataGridViewTextBoxColumn.HeaderText = "MIDDLENAME"
        Me.MIDDLENAMEDataGridViewTextBoxColumn.Name = "MIDDLENAMEDataGridViewTextBoxColumn"
        '
        'GENDERDataGridViewTextBoxColumn
        '
        Me.GENDERDataGridViewTextBoxColumn.DataPropertyName = "GENDER"
        Me.GENDERDataGridViewTextBoxColumn.HeaderText = "GENDER"
        Me.GENDERDataGridViewTextBoxColumn.Name = "GENDERDataGridViewTextBoxColumn"
        '
        'EMAILDataGridViewTextBoxColumn
        '
        Me.EMAILDataGridViewTextBoxColumn.DataPropertyName = "EMAIL"
        Me.EMAILDataGridViewTextBoxColumn.HeaderText = "EMAIL"
        Me.EMAILDataGridViewTextBoxColumn.Name = "EMAILDataGridViewTextBoxColumn"
        '
        'ADDRESSDataGridViewTextBoxColumn
        '
        Me.ADDRESSDataGridViewTextBoxColumn.DataPropertyName = "ADDRESS"
        Me.ADDRESSDataGridViewTextBoxColumn.HeaderText = "ADDRESS"
        Me.ADDRESSDataGridViewTextBoxColumn.Name = "ADDRESSDataGridViewTextBoxColumn"
        '
        'CONTACTDataGridViewTextBoxColumn
        '
        Me.CONTACTDataGridViewTextBoxColumn.DataPropertyName = "CONTACT"
        Me.CONTACTDataGridViewTextBoxColumn.HeaderText = "CONTACT"
        Me.CONTACTDataGridViewTextBoxColumn.Name = "CONTACTDataGridViewTextBoxColumn"
        '
        'DOBDataGridViewTextBoxColumn
        '
        Me.DOBDataGridViewTextBoxColumn.DataPropertyName = "DOB"
        Me.DOBDataGridViewTextBoxColumn.HeaderText = "DOB"
        Me.DOBDataGridViewTextBoxColumn.Name = "DOBDataGridViewTextBoxColumn"
        '
        'GUARDIANDataGridViewTextBoxColumn
        '
        Me.GUARDIANDataGridViewTextBoxColumn.DataPropertyName = "GUARDIAN"
        Me.GUARDIANDataGridViewTextBoxColumn.HeaderText = "GUARDIAN"
        Me.GUARDIANDataGridViewTextBoxColumn.Name = "GUARDIANDataGridViewTextBoxColumn"
        '
        'GCONTACTDataGridViewTextBoxColumn
        '
        Me.GCONTACTDataGridViewTextBoxColumn.DataPropertyName = "GCONTACT"
        Me.GCONTACTDataGridViewTextBoxColumn.HeaderText = "GCONTACT"
        Me.GCONTACTDataGridViewTextBoxColumn.Name = "GCONTACTDataGridViewTextBoxColumn"
        '
        'SYEARDataGridViewTextBoxColumn
        '
        Me.SYEARDataGridViewTextBoxColumn.DataPropertyName = "SYEAR"
        Me.SYEARDataGridViewTextBoxColumn.HeaderText = "SYEAR"
        Me.SYEARDataGridViewTextBoxColumn.Name = "SYEARDataGridViewTextBoxColumn"
        '
        'PASSWORDDataGridViewTextBoxColumn
        '
        Me.PASSWORDDataGridViewTextBoxColumn.DataPropertyName = "PASSWORD"
        Me.PASSWORDDataGridViewTextBoxColumn.HeaderText = "PASSWORD"
        Me.PASSWORDDataGridViewTextBoxColumn.Name = "PASSWORDDataGridViewTextBoxColumn"
        '
        'PICTUREDataGridViewTextBoxColumn
        '
        Me.PICTUREDataGridViewTextBoxColumn.DataPropertyName = "PICTURE"
        Me.PICTUREDataGridViewTextBoxColumn.HeaderText = "PICTURE"
        Me.PICTUREDataGridViewTextBoxColumn.Name = "PICTUREDataGridViewTextBoxColumn"
        '
        'USERTYPEDataGridViewTextBoxColumn
        '
        Me.USERTYPEDataGridViewTextBoxColumn.DataPropertyName = "USERTYPE"
        Me.USERTYPEDataGridViewTextBoxColumn.HeaderText = "USERTYPE"
        Me.USERTYPEDataGridViewTextBoxColumn.Name = "USERTYPEDataGridViewTextBoxColumn"
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(65)
        Me.Label2.Size = New System.Drawing.Size(238, 168)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Picture " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Not Available" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(12, 43)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(238, 168)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 262)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "First name:"
        '
        'fnameTxtBox
        '
        Me.fnameTxtBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MemberBindingSource, "FIRSTNAME", True))
        Me.fnameTxtBox.Location = New System.Drawing.Point(76, 259)
        Me.fnameTxtBox.Name = "fnameTxtBox"
        Me.fnameTxtBox.Size = New System.Drawing.Size(116, 20)
        Me.fnameTxtBox.TabIndex = 6
        '
        'lnameTxtBox
        '
        Me.lnameTxtBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MemberBindingSource, "LASTNAME", True))
        Me.lnameTxtBox.Location = New System.Drawing.Point(76, 285)
        Me.lnameTxtBox.Name = "lnameTxtBox"
        Me.lnameTxtBox.Size = New System.Drawing.Size(116, 20)
        Me.lnameTxtBox.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 288)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Last name:"
        '
        'mnameTxtBox
        '
        Me.mnameTxtBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MemberBindingSource, "MIDDLENAME", True))
        Me.mnameTxtBox.Location = New System.Drawing.Point(276, 259)
        Me.mnameTxtBox.Name = "mnameTxtBox"
        Me.mnameTxtBox.Size = New System.Drawing.Size(116, 20)
        Me.mnameTxtBox.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(200, 262)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Middle name:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 336)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Birth Day:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd/MM/yy"
        Me.DateTimePicker1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.MemberBindingSource, "DOB", True))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(77, 333)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(76, 20)
        Me.DateTimePicker1.TabIndex = 13
        '
        'addTxtBox
        '
        Me.addTxtBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MemberBindingSource, "ADDRESS", True))
        Me.addTxtBox.Location = New System.Drawing.Point(276, 333)
        Me.addTxtBox.Name = "addTxtBox"
        Me.addTxtBox.Size = New System.Drawing.Size(116, 20)
        Me.addTxtBox.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(222, 336)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Address:"
        '
        'emailTxtBox
        '
        Me.emailTxtBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MemberBindingSource, "EMAIL", True))
        Me.emailTxtBox.Location = New System.Drawing.Point(76, 375)
        Me.emailTxtBox.Name = "emailTxtBox"
        Me.emailTxtBox.Size = New System.Drawing.Size(116, 20)
        Me.emailTxtBox.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(35, 378)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Email:"
        '
        'psswrdTxtBox
        '
        Me.psswrdTxtBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MemberBindingSource, "PASSWORD", True))
        Me.psswrdTxtBox.Location = New System.Drawing.Point(276, 375)
        Me.psswrdTxtBox.Name = "psswrdTxtBox"
        Me.psswrdTxtBox.Size = New System.Drawing.Size(116, 20)
        Me.psswrdTxtBox.TabIndex = 19
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(214, 378)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 13)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Password:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(-2, 418)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 26)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "School" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Year Entered:"
        '
        'syearBox
        '
        Me.syearBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MemberBindingSource, "SYEAR", True))
        Me.syearBox.FormattingEnabled = True
        Me.syearBox.Items.AddRange(New Object() {"2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030", "2031", "2032", "2034", "2035", "2036", "2037", "2038", "2039", "2040"})
        Me.syearBox.Location = New System.Drawing.Point(76, 423)
        Me.syearBox.Name = "syearBox"
        Me.syearBox.Size = New System.Drawing.Size(62, 21)
        Me.syearBox.TabIndex = 21
        '
        'conTxtBox
        '
        Me.conTxtBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MemberBindingSource, "CONTACT", True))
        Me.conTxtBox.Location = New System.Drawing.Point(76, 468)
        Me.conTxtBox.Name = "conTxtBox"
        Me.conTxtBox.Size = New System.Drawing.Size(116, 20)
        Me.conTxtBox.TabIndex = 23
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(23, 471)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(47, 13)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Contact:"
        '
        'guardTxtBox
        '
        Me.guardTxtBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MemberBindingSource, "GUARDIAN", True))
        Me.guardTxtBox.Location = New System.Drawing.Point(276, 468)
        Me.guardTxtBox.Name = "guardTxtBox"
        Me.guardTxtBox.Size = New System.Drawing.Size(116, 20)
        Me.guardTxtBox.TabIndex = 25
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(217, 471)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(53, 13)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "Guardian:"
        '
        'gconTxtBox
        '
        Me.gconTxtBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MemberBindingSource, "GCONTACT", True))
        Me.gconTxtBox.Location = New System.Drawing.Point(276, 500)
        Me.gconTxtBox.Name = "gconTxtBox"
        Me.gconTxtBox.Size = New System.Drawing.Size(116, 20)
        Me.gconTxtBox.TabIndex = 27
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(220, 494)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(50, 26)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "Guardian" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Contact:"
        '
        'insertBttn
        '
        Me.insertBttn.Location = New System.Drawing.Point(13, 600)
        Me.insertBttn.Name = "insertBttn"
        Me.insertBttn.Size = New System.Drawing.Size(75, 23)
        Me.insertBttn.TabIndex = 28
        Me.insertBttn.Text = "INSERT"
        Me.insertBttn.UseVisualStyleBackColor = True
        '
        'updateBttn
        '
        Me.updateBttn.Location = New System.Drawing.Point(94, 600)
        Me.updateBttn.Name = "updateBttn"
        Me.updateBttn.Size = New System.Drawing.Size(75, 23)
        Me.updateBttn.TabIndex = 29
        Me.updateBttn.Text = "UPDATE"
        Me.updateBttn.UseVisualStyleBackColor = True
        '
        'deleteBttn
        '
        Me.deleteBttn.Location = New System.Drawing.Point(175, 600)
        Me.deleteBttn.Name = "deleteBttn"
        Me.deleteBttn.Size = New System.Drawing.Size(75, 23)
        Me.deleteBttn.TabIndex = 30
        Me.deleteBttn.Text = "REMOVE"
        Me.deleteBttn.UseVisualStyleBackColor = True
        '
        'prevBttn
        '
        Me.prevBttn.Location = New System.Drawing.Point(13, 626)
        Me.prevBttn.Name = "prevBttn"
        Me.prevBttn.Size = New System.Drawing.Size(75, 23)
        Me.prevBttn.TabIndex = 31
        Me.prevBttn.Text = "PREVIOUS"
        Me.prevBttn.UseVisualStyleBackColor = True
        '
        'nxtBttn
        '
        Me.nxtBttn.Location = New System.Drawing.Point(94, 626)
        Me.nxtBttn.Name = "nxtBttn"
        Me.nxtBttn.Size = New System.Drawing.Size(75, 23)
        Me.nxtBttn.TabIndex = 32
        Me.nxtBttn.Text = "NEXT"
        Me.nxtBttn.UseVisualStyleBackColor = True
        '
        'firstBttn
        '
        Me.firstBttn.Location = New System.Drawing.Point(175, 626)
        Me.firstBttn.Name = "firstBttn"
        Me.firstBttn.Size = New System.Drawing.Size(75, 23)
        Me.firstBttn.TabIndex = 33
        Me.firstBttn.Text = "FIRST"
        Me.firstBttn.UseVisualStyleBackColor = True
        '
        'lastBttn
        '
        Me.lastBttn.Location = New System.Drawing.Point(256, 626)
        Me.lastBttn.Name = "lastBttn"
        Me.lastBttn.Size = New System.Drawing.Size(75, 23)
        Me.lastBttn.TabIndex = 34
        Me.lastBttn.Text = "LAST"
        Me.lastBttn.UseVisualStyleBackColor = True
        '
        'picTxtBox
        '
        Me.picTxtBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MemberBindingSource, "PICTURE", True))
        Me.picTxtBox.Location = New System.Drawing.Point(94, 216)
        Me.picTxtBox.Name = "picTxtBox"
        Me.picTxtBox.Size = New System.Drawing.Size(156, 20)
        Me.picTxtBox.TabIndex = 38
        '
        'picBttn
        '
        Me.picBttn.Location = New System.Drawing.Point(13, 214)
        Me.picBttn.Name = "picBttn"
        Me.picBttn.Size = New System.Drawing.Size(75, 23)
        Me.picBttn.TabIndex = 37
        Me.picBttn.Text = "INS. PIC"
        Me.picBttn.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'genderBox
        '
        Me.genderBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MemberBindingSource, "GENDER", True))
        Me.genderBox.FormattingEnabled = True
        Me.genderBox.Items.AddRange(New Object() {"Male", "Female", "LGBTQ+"})
        Me.genderBox.Location = New System.Drawing.Point(276, 285)
        Me.genderBox.Name = "genderBox"
        Me.genderBox.Size = New System.Drawing.Size(62, 21)
        Me.genderBox.TabIndex = 40
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(225, 288)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(45, 13)
        Me.Label14.TabIndex = 39
        Me.Label14.Text = "Gender:"
        '
        'MemberTableAdapter
        '
        Me.MemberTableAdapter.ClearBeforeFill = True
        '
        'idlbl
        '
        Me.idlbl.AutoSize = True
        Me.idlbl.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MemberBindingSource, "ID", True))
        Me.idlbl.Location = New System.Drawing.Point(572, 587)
        Me.idlbl.Name = "idlbl"
        Me.idlbl.Size = New System.Drawing.Size(18, 13)
        Me.idlbl.TabIndex = 42
        Me.idlbl.Text = "ID"
        '
        'searchBttn
        '
        Me.searchBttn.Location = New System.Drawing.Point(487, 626)
        Me.searchBttn.Name = "searchBttn"
        Me.searchBttn.Size = New System.Drawing.Size(105, 23)
        Me.searchBttn.TabIndex = 43
        Me.searchBttn.Text = "SEARCH"
        Me.searchBttn.UseVisualStyleBackColor = True
        '
        'searchTxtBox
        '
        Me.searchTxtBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MemberBindingSource, "GUARDIAN", True))
        Me.searchTxtBox.Location = New System.Drawing.Point(387, 603)
        Me.searchTxtBox.Name = "searchTxtBox"
        Me.searchTxtBox.Size = New System.Drawing.Size(203, 20)
        Me.searchTxtBox.TabIndex = 44
        '
        'refreshBttn
        '
        Me.refreshBttn.Location = New System.Drawing.Point(387, 626)
        Me.refreshBttn.Name = "refreshBttn"
        Me.refreshBttn.Size = New System.Drawing.Size(94, 23)
        Me.refreshBttn.TabIndex = 45
        Me.refreshBttn.Text = "REFRESH"
        Me.refreshBttn.UseVisualStyleBackColor = True
        '
        'registBox
        '
        Me.registBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MemberBindingSource, "GENDER", True))
        Me.registBox.FormattingEnabled = True
        Me.registBox.Items.AddRange(New Object() {"Student", "Registrar"})
        Me.registBox.Location = New System.Drawing.Point(76, 500)
        Me.registBox.Name = "registBox"
        Me.registBox.Size = New System.Drawing.Size(62, 21)
        Me.registBox.TabIndex = 47
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(15, 503)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(55, 13)
        Me.Label15.TabIndex = 46
        Me.Label15.Text = "User type:"
        '
        'AdminGridView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(602, 863)
        Me.Controls.Add(Me.registBox)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.refreshBttn)
        Me.Controls.Add(Me.searchTxtBox)
        Me.Controls.Add(Me.searchBttn)
        Me.Controls.Add(Me.idlbl)
        Me.Controls.Add(Me.genderBox)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.picTxtBox)
        Me.Controls.Add(Me.picBttn)
        Me.Controls.Add(Me.lastBttn)
        Me.Controls.Add(Me.firstBttn)
        Me.Controls.Add(Me.nxtBttn)
        Me.Controls.Add(Me.prevBttn)
        Me.Controls.Add(Me.deleteBttn)
        Me.Controls.Add(Me.updateBttn)
        Me.Controls.Add(Me.insertBttn)
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
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "AdminGridView"
        Me.Text = "Admin View"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MemberBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.STUDENT_RECORDDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents fnameTxtBox As TextBox
    Friend WithEvents lnameTxtBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents mnameTxtBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents addTxtBox As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents emailTxtBox As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents psswrdTxtBox As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents syearBox As ComboBox
    Friend WithEvents conTxtBox As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents guardTxtBox As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents gconTxtBox As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents insertBttn As Button
    Friend WithEvents updateBttn As Button
    Friend WithEvents deleteBttn As Button
    Friend WithEvents prevBttn As Button
    Friend WithEvents nxtBttn As Button
    Friend WithEvents firstBttn As Button
    Friend WithEvents lastBttn As Button
    Friend WithEvents MemberTableAdapter As STUDENT_RECORDDataSetTableAdapters.MemberTableAdapter
    Friend WithEvents picTxtBox As TextBox
    Friend WithEvents picBttn As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents genderBox As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents STUDENT_RECORDDataSet As STUDENT_RECORDDataSet
    Friend WithEvents MemberBindingSource As BindingSource
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FIRSTNAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LASTNAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MIDDLENAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GENDERDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EMAILDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ADDRESSDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CONTACTDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DOBDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GUARDIANDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GCONTACTDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SYEARDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PASSWORDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PICTUREDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents USERTYPEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents idlbl As Label
    Friend WithEvents searchBttn As Button
    Friend WithEvents searchTxtBox As TextBox
    Friend WithEvents refreshBttn As Button
    Friend WithEvents registBox As ComboBox
    Friend WithEvents Label15 As Label
End Class
