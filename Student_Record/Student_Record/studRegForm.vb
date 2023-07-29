Imports System.Text.RegularExpressions
Imports System.Data.OleDb

Public Class studRegForm

    Dim con As New OleDbConnection
    Private Sub studRegForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\johnp\Desktop\Student_Record\Student_Record\STUDENT_RECORD.accdb"
        picBox()
    End Sub
    Private Sub studRegForm_FormClosing(ByVal sender As System.Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'This block of code will just close the window by applying the ExitThread() which is used to exit the entire .exe file
        Dim dialog As DialogResult
        dialog = MessageBox.Show("Do you want to close the application?", "Exit", MessageBoxButtons.YesNo)

        If dialog = DialogResult.No Then
            e.Cancel = True
        Else
            Application.ExitThread()
        End If
    End Sub

    Private Sub psswrdTxtBox_TextChanged(sender As Object, e As EventArgs) Handles psswrdTxtBox.TextChanged
        'A simple code to hide the sensitive password input
        psswrdTxtBox.PasswordChar = "*"
    End Sub
    Private Sub picBttn_Click(sender As Object, e As EventArgs) Handles picBttn.Click
        'Base code to run file explorer to locate what picture you want to use in your form
        OpenFileDialog1.ShowDialog()
        picTxtBox.Text = OpenFileDialog1.FileName
    End Sub
    Public Sub picTxtBox_TextChanged(sender As Object, e As EventArgs) Handles picTxtBox.TextChanged
        'A simple code to load your picture using the string located on your textbox field(picTxtBox.Text)
        If (System.IO.File.Exists(picTxtBox.Text)) Then
            PictureBox1.Image = Image.FromFile(picTxtBox.Text)
        End If
        picBox()
    End Sub

    Public Sub picBox()
        'A public sub that will run if called. This sub hides the picturebox1 if it does not read any data from picTxtBox.Text
        If picTxtBox.Text = "" Then
            PictureBox1.Hide()
        Else
            PictureBox1.Show()
        End If
    End Sub

    Private Sub submitBttn_Click(sender As Object, e As EventArgs) Handles submitBttn.Click
        Dim contact As String = conTxtBox.Text
        Dim gcontact As String = gconTxtBox.Text
        Dim email As String = emailTxtBox.Text

        If emailTxtBox.Text = "" Or fnameTxtBox.Text = "" Or lnameTxtBox.Text = "" Or mnameTxtBox.Text = "" Or addTxtBox.Text = "" Or genderBox.Text = "" Or psswrdTxtBox.Text = "" Or syearBox.Text = "" Or conTxtBox.Text = "" Or gconTxtBox.Text = "" Or guardTxtBox.Text = "" Or picTxtBox.Text = "" Then
            MessageBox.Show("Please fill all of the input field!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf IsInputNumber(contact) = False Or IsValidEmailFormat(email) = False Or IsInputNumber(gcontact) = False Then
            MessageBox.Show("Please input a correct email, or a correct contact info for yourself or your guardian", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If

            Using cmd As New OleDbCommand("SELECT COUNT(*) FROM Member WHERE [EMAIL] =@EMAIL OR [PASSWORD] = @PASSWORD", con)
                'This code will select if your email or password input has already been taken on the database
                cmd.Parameters.AddWithValue("@EMAIL", OleDbType.VarChar).Value = emailTxtBox.Text.Trim
                cmd.Parameters.AddWithValue("@PASSWORD", OleDbType.VarChar).Value = psswrdTxtBox.Text.Trim


                Dim count = Convert.ToInt32(cmd.ExecuteScalar())
                'If your count, in this case you are counting how many first columns has similar email or password to your initial input
                'The idea making the email and password unique is that Student can have similar names through out every school year
                'To avoid any errors, it is best to just make sure their email or password are unique
                If count > 0 Then
                    MessageBox.Show("Email and Password has already been taken", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    'This section of code will execute if your email or password input are unique
                    'Thus inserting the student data you used on the input fields
                    Using create As New OleDbCommand("INSERT INTO Member ([FIRSTNAME], [LASTNAME], [MIDDLENAME], [GENDER], 
                     [EMAIL], [ADDRESS], [CONTACT], [DOB], [GUARDIAN], [GCONTACT], [SYEAR], [PASSWORD], [PICTURE],[USERTYPE])
                     VALUES (@FIRSTNAME, @LASTNAME, @MIDDLENAME, @GENDER, @EMAIL, @ADDRESS, @CONTACT, @DOB, @GUARDIAN,
                     @GCONTACT, @SYEAR, @PASSWORD, @PICTURE, @USERTYPE)", con)

                        Dim studYear As Integer = Convert.ToInt32(syearBox.SelectedItem)

                        create.Parameters.AddWithValue("@FIRSTNAME", OleDbType.VarChar).Value = fnameTxtBox.Text.Trim
                        create.Parameters.AddWithValue("@LASTNAME", OleDbType.VarChar).Value = lnameTxtBox.Text.Trim
                        create.Parameters.AddWithValue("@MIDDLENAME", OleDbType.VarChar).Value = mnameTxtBox.Text.Trim
                        create.Parameters.AddWithValue("@GENDER", OleDbType.VarChar).Value = genderBox.SelectedItem
                        create.Parameters.AddWithValue("@EMAIL", OleDbType.VarChar).Value = emailTxtBox.Text.Trim
                        create.Parameters.AddWithValue("@ADDRESS", OleDbType.VarChar).Value = addTxtBox.Text.Trim
                        create.Parameters.AddWithValue("@CONTACT", OleDbType.VarChar).Value = conTxtBox.Text.Trim
                        create.Parameters.AddWithValue("@DOB", OleDbType.Date).Value = DateTimePicker1.Value.ToString
                        create.Parameters.AddWithValue("@GUARDIAN", OleDbType.VarChar).Value = guardTxtBox.Text.Trim
                        create.Parameters.AddWithValue("@GCONTACT", OleDbType.VarChar).Value = gconTxtBox.Text.Trim
                        create.Parameters.AddWithValue("@SYEAR", OleDbType.Integer).Value = studYear
                        create.Parameters.AddWithValue("@PASSWORD", OleDbType.VarChar).Value = psswrdTxtBox.Text.Trim
                        create.Parameters.AddWithValue("@PICTURE", OleDbType.VarChar).Value = picTxtBox.Text.Trim

                        'This is a static variable to declare what usertype students are gonna get.
                        'I have decided to use a static variable since the entire system is small and only requires a single admin.
                        'Each account registered here, will be automatically assigned as a Student usertype.
                        create.Parameters.AddWithValue("@USERTYPE", OleDbType.VarChar).Value = "Student"

                        If create.ExecuteNonQuery Then
                            MessageBox.Show("Account created!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            emailTxtBox.Clear()
                            psswrdTxtBox.Clear()
                            fnameTxtBox.Clear()
                            lnameTxtBox.Clear()
                            mnameTxtBox.Clear()
                            genderBox.SelectedValue = ""
                            addTxtBox.Clear()
                            conTxtBox.Clear()
                            DateTimePicker1.Value = DateTime.Now
                            guardTxtBox.Clear()
                            gconTxtBox.Clear()
                            syearBox.SelectedValue = ""
                            picTxtBox.Clear()
                        End If
                    End Using
                    con.Close()
                End If
            End Using

        End If
    End Sub

    'This code will check if your string of text are valid email format. IsValidEmailFormat()'
    Function IsValidEmailFormat(ByVal s As String) As Boolean
        Return Regex.IsMatch(s, "^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$")
    End Function

    'This code will check if your string of text are all numbers. IsInputNumbers()'
    Function IsInputNumber(ByVal KeyChar As String) As Boolean
        Dim allowedChars As String
        allowedChars = "0123456789./-"

        If allowedChars.IndexOf(KeyChar) = -1 And (Asc(KeyChar)) <> 9 Then
            'This will check for the value of your text using ascii code to determine if it's a number ranging from 0 to 9'
            Return True
        End If

        Return False
    End Function

    'Code for Focus starts here'
    Private Sub picTxtBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles picTxtBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            fnameTxtBox.Focus()
        End If
    End Sub
    Private Sub fnameTxtBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles fnameTxtBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            lnameTxtBox.Focus()
        End If
    End Sub

    Private Sub lnameTxtBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles lnameTxtBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            mnameTxtBox.Focus()
        End If
    End Sub
    Private Sub mnameTxtBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles mnameTxtBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            genderBox.Focus()
        End If
    End Sub

    Private Sub genderBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles genderBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            DateTimePicker1.Focus()
        End If
    End Sub

    Private Sub DateTimePicker1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles DateTimePicker1.KeyPress
        If Asc(e.KeyChar) = 13 Then
            addTxtBox.Focus()
        End If
    End Sub

    Private Sub addTxtBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles addTxtBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            emailTxtBox.Focus()
        End If
    End Sub

    Private Sub emailTxtBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles emailTxtBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            psswrdTxtBox.Focus()
        End If
    End Sub

    Private Sub psswrdTxtBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles psswrdTxtBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            syearBox.Focus()
        End If
    End Sub
    Private Sub syearBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles syearBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            conTxtBox.Focus()
        End If
    End Sub
    Private Sub conTxtBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles conTxtBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            guardTxtBox.Focus()
        End If
    End Sub
    Private Sub guardTxtBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles guardTxtBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            gconTxtBox.Focus()
        End If
    End Sub
    Private Sub gconTxtBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles gconTxtBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            submitBttn.Focus()
        End If
    End Sub
    'Code for Focus ends here'
End Class
