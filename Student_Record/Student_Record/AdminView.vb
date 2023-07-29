Imports System.Text.RegularExpressions
Imports System.IO.File
Imports System.IO.FileStream
Imports System.Data.OleDb
Imports System.Globalization

Public Class AdminGridView
    Public Shared AdminMain

    Dim con As New OleDbConnection
    Dim command As New OleDbDataAdapter
    Private Sub AdminGridView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'STUDENT_RECORDDataSet.Member' table. You can move, or remove it, as needed.
        Me.MemberTableAdapter.Fill(Me.STUDENT_RECORDDataSet.Member)
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\johnp\Desktop\Student_Record\Student_Record\STUDENT_RECORD.accdb"
        picBox()
    End Sub
    Private Sub insertBttn_Click(sender As Object, e As EventArgs) Handles insertBttn.Click
        Dim contact As String = conTxtBox.Text
        Dim gcontact As String = gconTxtBox.Text
        Dim email As String = emailTxtBox.Text

        If emailTxtBox.Text = "" Or fnameTxtBox.Text = "" Or lnameTxtBox.Text = "" Or mnameTxtBox.Text = "" Or addTxtBox.Text = "" Or
            genderBox.Text = "" Or psswrdTxtBox.Text = "" Or syearBox.Text = "" Or conTxtBox.Text = "" Or gconTxtBox.Text = "" Or
            guardTxtBox.Text = "" Or picTxtBox.Text = "" Then

            MessageBox.Show("Please fill all of the input field!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf IsInputNumber(contact) = False Or IsValidEmailFormat(email) = False Or IsInputNumber(gcontact) = False Then
            MessageBox.Show("Please input a correct email, or a correct contact info for yourself or your guardian
            ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If

            Using cmd As New OleDbCommand("SELECT COUNT(*) FROM Member WHERE [EMAIL] =@EMAIL OR [PASSWORD] = @PASSWORD", con)
                cmd.Parameters.AddWithValue("@EMAIL", OleDbType.VarChar).Value = emailTxtBox.Text.Trim
                cmd.Parameters.AddWithValue("@PASSWORD", OleDbType.VarChar).Value = psswrdTxtBox.Text.Trim
                'This block of code is a reused code from other forms, it will function the same as those.
                Dim count = Convert.ToInt32(cmd.ExecuteScalar())
                If count > 0 Then
                    MessageBox.Show("Email and Password has already been taken", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
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
                        create.Parameters.AddWithValue("@USERTYPE", OleDbType.VarChar).Value = registBox.SelectedItem

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
                            bind_data()
                            con.Close()
                        End If
                    End Using
                End If
            End Using
        End If
    End Sub
    Private Sub updateBttn_Click(sender As Object, e As EventArgs) Handles updateBttn.Click
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Using create As New OleDbCommand("UPDATE Member SET [FIRSTNAME] =@FIRSTNAME, [LASTNAME] =@LASTNAME, [MIDDLENAME] =@MIDDLENAME, [GENDER] =@GENDER, 
            [EMAIL] =@EMAIL, [ADDRESS] =@ADDRESS, [CONTACT] =@CONTACT, [DOB] =@DOB, [GUARDIAN] =@GUARDIAN, [GCONTACT] =@GCONTACT, [SYEAR] =@SYEAR, [PASSWORD] =@PASSWORD,
            [PICTURE] =@PICTURE, [USERTYPE] =@USERTYPE WHERE [ID] =@ID", con)
            'This block of code will allow the Admin to update the information on the database of each student even the Admin's own information.
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
            create.Parameters.AddWithValue("@USERTYPE", OleDbType.VarChar).Value = registBox.SelectedItem

            create.Parameters.AddWithValue("@ID", idlbl.Text)

            If create.ExecuteNonQuery Then
                MessageBox.Show("Account updated!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
                con.Close()
            End If
        End Using
        bind_data()
        con.Close()

    End Sub
    Private Sub deleteBttn_Click(sender As Object, e As EventArgs) Handles deleteBttn.Click
        'The IF statement will ask the Admin first if he is sure to delete the data from the database.
        'Then the query command will execute the delete syntax  where the ID is equals to the ID on the label(idlbl.Text)
        'This code is designed so that when the Admin clicks any data from the DataGridView1, the data will be automatically
        'showed on the form fields. This block of code is programmed with ease of use in mind.
        If MsgBox("Do you wish to permanently delete this information from the database?", vbQuestion + vbYesNo) = vbNo Then
            MsgBox("Data not deleted!", vbInformation)
        Else
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            Using deleteUser As New OleDbCommand("DELETE FROM Member WHERE [ID] =@ID", con)

                deleteUser.Parameters.AddWithValue("@ID", idlbl.Text)

                If deleteUser.ExecuteNonQuery Then
                    MessageBox.Show("Data deleted from the Database!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
                    registBox.SelectedValue = ""
                    con.Close()
                End If
            End Using
            bind_data()
            con.Close()
        End If
    End Sub
    Private Sub searchBttn_Click(sender As Object, e As EventArgs) Handles searchBttn.Click
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Using search As New OleDbCommand("SELECT * FROM Member WHERE [FIRSTNAME] = @FIRSTNAME OR [LASTNAME] = @LASTNAME
        OR [MIDDLENAME] = @MIDDLENAME OR [GENDER] = @GENDER OR [EMAIL] = @EMAIL OR [ADDRESS] = @ADDRESS OR [CONTACT] = @CONTACT OR
        [GUARDIAN] = @GUARDIAN OR [GCONTACT] = @GCONTACT OR [USERTYPE] = @USERTYPE", con)
            'The search button is designed with only a single text field in mind. So the Admin will not randomly delete whoever is on the
            'input field. Though the Admin needs to click the data on DataGridView1 first so that the admin will select the data he wants
            'to modify.
            search.Parameters.AddWithValue("@FIRSTNAME", searchTxtBox.Text)
            search.Parameters.AddWithValue("@LASTNAME", searchTxtBox.Text)
            search.Parameters.AddWithValue("@MIDDLENAME", searchTxtBox.Text)
            search.Parameters.AddWithValue("@GENDER", searchTxtBox.Text)
            search.Parameters.AddWithValue("@EMAIL", searchTxtBox.Text)
            search.Parameters.AddWithValue("@ADDRESS", searchTxtBox.Text)
            search.Parameters.AddWithValue("@CONTACT", searchTxtBox.Text)
            search.Parameters.AddWithValue("@GUARDIAN", searchTxtBox.Text)
            search.Parameters.AddWithValue("@GCONTACT", searchTxtBox.Text)
            search.Parameters.AddWithValue("@USERTYPE", searchTxtBox.Text)

            Dim adapter As New OleDbDataAdapter(search)
            Dim table As New DataTable()

            Dim count = Convert.ToInt32(search.ExecuteScalar())

            If count < 0 Then
                MessageBox.Show("Input does not exist!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                search.ExecuteNonQuery()
                table.Clear()

                adapter.Fill(table)

                DataGridView1.DataSource = table
            End If
        End Using
        con.Close()
    End Sub
    Private Sub prevBttn_Click(sender As Object, e As EventArgs) Handles prevBttn.Click
        'This will move to previous row when clicked. The data that MemberBindingSource is calling are from STUDENT_RECORDDataSet.xsd.
        MemberBindingSource.MovePrevious()
    End Sub

    Private Sub nxtBttn_Click(sender As Object, e As EventArgs) Handles nxtBttn.Click
        'This will move to next row when clicked.
        MemberBindingSource.MoveNext()
    End Sub

    Private Sub firstBttn_Click(sender As Object, e As EventArgs) Handles firstBttn.Click
        'This will move to first row when clicked.
        MemberBindingSource.MoveFirst()
    End Sub

    Private Sub lastBttn_Click(sender As Object, e As EventArgs) Handles lastBttn.Click
        'This will move to last row when clicked.
        MemberBindingSource.MoveLast()
    End Sub

    'This code will check if your string of text are valid email format. IsValidEmailFormat()'
    Function IsValidEmailFormat(ByVal s As String) As Boolean
        Return Regex.IsMatch(s, "^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$")
    End Function

    'This code will check if your string of text are all numbers. IsInputNumbers()
    'the byval value will throw the input string into keychar
    'then the if statement will check using the declared Dim allowedChars on KeyChar
    Function IsInputNumber(ByVal KeyChar As String) As Boolean
        Dim allowedChars As String
        allowedChars = "0123456789./-"

        If allowedChars.IndexOf(KeyChar) = -1 And (Asc(KeyChar)) <> 9 Then
            'This will check for the value of your text using ascii code to determine if it's a number ranging from 0 to 9'
            Return True
        End If

        Return False
    End Function
    Private Sub picBttn_Click(sender As Object, e As EventArgs) Handles picBttn.Click
        'Base code to run file explorer to locate what picture you want to use in your form
        OpenFileDialog1.ShowDialog()
        picTxtBox.Text = OpenFileDialog1.FileName
    End Sub

    Private Sub picTxtBox_TextChanged(sender As Object, e As EventArgs) Handles picTxtBox.TextChanged
        'A simple code to load your picture using the string located on your textbox field(picTxtBox.Text)
        If (System.IO.File.Exists(picTxtBox.Text)) Then
            PictureBox1.Image = Image.FromFile(picTxtBox.Text)
        End If
        picBox()
    End Sub
    Private Sub bind_data()
        'bind_data() is used to update the DataGridView1 in real time.
        'For every changes the Admin makes, the bind_data() sub shall be called so the Data will be called.
        Dim cmd As New OleDbCommand("SELECT * from Member", con)
        Dim da As New OleDbDataAdapter
        da.SelectCommand = cmd
        Dim table1 As New DataTable
        table1.Clear()
        da.Fill(table1)
        DataGridView1.DataSource = table1
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        'For every click the Admin does on each cell, the data would be transferred to the appropriate input fields.
        'This will allow the Admin to have an easier time editing User information.
        Dim i As String = DataGridView1.CurrentRow.Cells(8).Value.ToString

        Dim result As Date

        'The DateTimePicker Value is hard to manipulate in Visual Basic, as it would not be easily transformed into string.
        'On that regard, an Error handler as simple as An IF statement would suffice to catch the errors that would occur in our code.
        If DateTime.TryParseExact(i, "dd/MM/yy", CultureInfo.InvariantCulture, DateTimeStyles.None, result) Then
            DateTimePicker1.Value = result
        Else
            Console.WriteLine("format error!", result)
        End If

        idlbl.Text = DataGridView1.CurrentRow.Cells(0).Value
        fnameTxtBox.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
        lnameTxtBox.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString
        mnameTxtBox.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString
        genderBox.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString
        emailTxtBox.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString
        addTxtBox.Text = DataGridView1.CurrentRow.Cells(6).Value.ToString
        conTxtBox.Text = DataGridView1.CurrentRow.Cells(7).Value.ToString
        guardTxtBox.Text = DataGridView1.CurrentRow.Cells(9).Value.ToString
        gconTxtBox.Text = DataGridView1.CurrentRow.Cells(10).Value.ToString
        syearBox.Text = DataGridView1.CurrentRow.Cells(11).Value.ToString
        psswrdTxtBox.Text = DataGridView1.CurrentRow.Cells(12).Value.ToString
        picTxtBox.Text = DataGridView1.CurrentRow.Cells(13).Value.ToString

    End Sub

    Private Sub searchTxtBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles searchTxtBox.KeyPress
        'This will allow the user to jump from searchTxtBox to searchBttn using ENTER key
        If Asc(e.KeyChar) = 13 Then
            searchBttn.Focus()
        End If
    End Sub

    Private Sub refreshBttn_Click(sender As Object, e As EventArgs) Handles refreshBttn.Click
        'Re-used the bind_data code to "REFRESH" the datagridview1 table
        bind_data()
    End Sub
    Private Sub AdminGridView_FormClosing(ByVal sender As System.Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
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
    Public Sub picBox()
        'A public sub that will run if called. This sub hides the picturebox1 if it does not read any data from picTxtBox.Text
        If picTxtBox.Text = "" Then
            PictureBox1.Hide()
        Else
            PictureBox1.Show()
        End If
    End Sub

    'Developer FAQ:
    ' "Why didn't you create a back button?"
    ' I tried to but I've seen vulnerabilities that can be exploited by the user when switching from one account to another.
    ' "Is there more to this project?"
    ' Yes, possibly, though due to the limited time constraints I've only created this small project with small scope. 

End Class
