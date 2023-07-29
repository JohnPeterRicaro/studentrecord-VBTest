<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class loginform
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.emaillbl = New System.Windows.Forms.Label()
        Me.studnolbl = New System.Windows.Forms.Label()
        Me.emailTxtBox = New System.Windows.Forms.TextBox()
        Me.MemberBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.STUDENT_RECORDDataSet = New Student_Record.STUDENT_RECORDDataSet()
        Me.passTxtBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.loginBttn = New System.Windows.Forms.Button()
        Me.signupBttn = New System.Windows.Forms.LinkLabel()
        Me.pictureBox = New System.Windows.Forms.PictureBox()
        Me.MemberTableAdapter = New Student_Record.STUDENT_RECORDDataSetTableAdapters.MemberTableAdapter()
        CType(Me.MemberBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.STUDENT_RECORDDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(62, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(225, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "STUDENT RECORD"
        '
        'emaillbl
        '
        Me.emaillbl.AutoSize = True
        Me.emaillbl.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold)
        Me.emaillbl.Location = New System.Drawing.Point(54, 281)
        Me.emaillbl.Name = "emaillbl"
        Me.emaillbl.Size = New System.Drawing.Size(60, 20)
        Me.emaillbl.TabIndex = 1
        Me.emaillbl.Text = "EMAIL :"
        '
        'studnolbl
        '
        Me.studnolbl.AutoSize = True
        Me.studnolbl.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold)
        Me.studnolbl.Location = New System.Drawing.Point(22, 309)
        Me.studnolbl.Name = "studnolbl"
        Me.studnolbl.Size = New System.Drawing.Size(92, 20)
        Me.studnolbl.TabIndex = 2
        Me.studnolbl.Text = "PASSWORD:"
        '
        'emailTxtBox
        '
        Me.emailTxtBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MemberBindingSource, "EMAIL", True))
        Me.emailTxtBox.Location = New System.Drawing.Point(120, 281)
        Me.emailTxtBox.Name = "emailTxtBox"
        Me.emailTxtBox.Size = New System.Drawing.Size(151, 20)
        Me.emailTxtBox.TabIndex = 3
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
        'passTxtBox
        '
        Me.passTxtBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MemberBindingSource, "PASSWORD", True))
        Me.passTxtBox.Location = New System.Drawing.Point(120, 309)
        Me.passTxtBox.Name = "passTxtBox"
        Me.passTxtBox.Size = New System.Drawing.Size(151, 20)
        Me.passTxtBox.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Location = New System.Drawing.Point(81, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(56)
        Me.Label2.Size = New System.Drawing.Size(184, 140)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Photo" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Not Available"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'loginBttn
        '
        Me.loginBttn.Location = New System.Drawing.Point(137, 348)
        Me.loginBttn.Name = "loginBttn"
        Me.loginBttn.Size = New System.Drawing.Size(64, 24)
        Me.loginBttn.TabIndex = 6
        Me.loginBttn.Text = "Login"
        Me.loginBttn.UseVisualStyleBackColor = True
        '
        'signupBttn
        '
        Me.signupBttn.AutoSize = True
        Me.signupBttn.Location = New System.Drawing.Point(78, 385)
        Me.signupBttn.Name = "signupBttn"
        Me.signupBttn.Size = New System.Drawing.Size(198, 13)
        Me.signupBttn.TabIndex = 7
        Me.signupBttn.TabStop = True
        Me.signupBttn.Text = "Not signed up yet? Click here to sign up!"
        '
        'pictureBox
        '
        Me.pictureBox.ImageLocation = "C:\Users\johnp\Desktop\Student_Record\person.png"
        Me.pictureBox.Location = New System.Drawing.Point(81, 94)
        Me.pictureBox.Name = "pictureBox"
        Me.pictureBox.Size = New System.Drawing.Size(184, 140)
        Me.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBox.TabIndex = 9
        Me.pictureBox.TabStop = False
        '
        'MemberTableAdapter
        '
        Me.MemberTableAdapter.ClearBeforeFill = True
        '
        'loginform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(345, 458)
        Me.Controls.Add(Me.pictureBox)
        Me.Controls.Add(Me.signupBttn)
        Me.Controls.Add(Me.loginBttn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.passTxtBox)
        Me.Controls.Add(Me.emailTxtBox)
        Me.Controls.Add(Me.studnolbl)
        Me.Controls.Add(Me.emaillbl)
        Me.Controls.Add(Me.Label1)
        Me.Name = "loginform"
        Me.Text = "Login"
        CType(Me.MemberBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.STUDENT_RECORDDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents emaillbl As Label
    Friend WithEvents studnolbl As Label
    Friend WithEvents emailTxtBox As TextBox
    Friend WithEvents passTxtBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents loginBttn As Button
    Friend WithEvents signupBttn As LinkLabel
    Friend WithEvents pictureBox As PictureBox
    Friend WithEvents STUDENT_RECORDDataSet As STUDENT_RECORDDataSet
    Friend WithEvents MemberBindingSource As BindingSource
    Friend WithEvents MemberTableAdapter As STUDENT_RECORDDataSetTableAdapters.MemberTableAdapter
End Class
