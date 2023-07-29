Imports System.Data.OleDb

Public Class loginform

    Dim con As New OleDbConnection

    Private Sub loginform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'STUDENT_RECORDDataSet.Member' table. You can move, or remove it, as needed.
        Me.MemberTableAdapter.Fill(Me.STUDENT_RECORDDataSet.Member)
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\johnp\Desktop\Student_Record\Student_Record\STUDENT_RECORD.accdb"
    End Sub
    Private Sub login_FormClosing(ByVal sender As System.Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'This block of code will just close the window by applying the ExitThread() which is used to exit the entire .exe file
        Dim dialog As DialogResult
        dialog = MessageBox.Show("Do you want to close the application?", "Exit", MessageBoxButtons.YesNo)

        If dialog = DialogResult.No Then
            e.Cancel = True
        Else
            Application.ExitThread()
        End If
    End Sub

    Private Sub studnoTxtBox_TextChanged(sender As Object, e As EventArgs) Handles passTxtBox.TextChanged
        passTxtBox.PasswordChar = "*"
    End Sub
    'Code for focus() to change starts here
    'What this block do, is that it makes UX much cleaner than what is given just by dragging the UI to place
    'When we press 'ENTER' on our keyboard from emailTxtBox, the code will change its focus or jump to
    'the next text field then to the button.
    Private Sub emailTxtBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles emailTxtBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            passTxtBox.Focus()
        End If
    End Sub
    Private Sub passTxtBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles passTxtBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            loginBttn.Focus()
        End If
    End Sub
    'code for focus() to change ends here
    Private Sub loginBttn_Click(ByVal sender As System.Object, e As System.EventArgs) Handles loginBttn.Click
        If passTxtBox.Text = "" Or emailTxtBox.Text = "" Then
            MsgBox("All fields are required!", MsgBoxStyle.Exclamation)
        Else
            Try
                con.Open()
                Using cmd As New OleDbCommand("Select * from Member where [EMAIL] = @EMAIL AND [PASSWORD] = @PASSWORD", con)
                    'This block will select email and password from the Data table to ensure that you registered
                    'so you can log in -1, -2
                    cmd.Parameters.AddWithValue("@EMAIL", OleDbType.VarChar).Value = emailTxtBox.Text.Trim
                    cmd.Parameters.AddWithValue("@PASSWORD", OleDbType.VarChar).Value = passTxtBox.Text.Trim

                    Dim ds As New OleDbDataAdapter(cmd)
                    Dim myTable As New DataTable
                    ds.Fill(myTable)

                    '-1 as an admin, if you input the correct parameters to call the account of the Admin. -
                    If myTable.Rows(0)("USERTYPE") = "Admin" Then
                        Dim message As String = "Welcome Admin!"
                        Dim caption As String = "Successfully Logged in!"
                        Dim result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        '- Then this code will share the declared variable on this block to the AdminGridView.
                        'Though it does not do anything on the Form of the admin, but it is still necessary to declare
                        'as the data would not pass through and will cause an error.
                        Dim AdminMain As New AdminGridView
                        AdminGridView.AdminMain = emailTxtBox.Text
                        AdminGridView.Show()
                        Me.Hide()
                    ElseIf myTable.Rows(0)("USERTYPE") = "Student" Then
                        '-2, if your usertype is equals to Student, this code will give you the ability to jump through to
                        'studentAccount.vb form. And you will be able to view your student number, and other information
                        'that you've entered when you did your first registration.
                        Dim message As String = "Welcome Student!"
                        Dim caption As String = "Successfully Logged in!"
                        Dim result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Dim studAccountView As New studentAccount
                        studentAccount.studAccountView = emailTxtBox.Text
                        studentAccount.Show()
                        Me.Hide()
                    ElseIf myTable.Rows(0)("USERTYPE") = "Registrar" Then
                        '-3, if your usertype is equals to Registrar, this code will give you the ability to jump through to
                        'registrar.vb form. And you will be able to view the forms as the registrar.
                        Dim message As String = "Welcome Registrar!"
                        Dim caption As String = "Successfully Logged in!"
                        Dim result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Dim registView As New Registrar
                        Registrar.registView = emailTxtBox.Text
                        Registrar.Show()
                        Me.Hide()
                    Else
                        MessageBox.Show("Wrong Email or Password!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        emailTxtBox.Text = ""
                        passTxtBox.Text = ""
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Wrong Email or Password!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                passTxtBox.Text = ""
            Finally
                con.Close()
            End Try
        End If
    End Sub
    Private Sub signupBttn_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles signupBttn.LinkClicked
        'A code that will hide this form, and lets you jump to the registration form
        Me.Hide()
        studRegForm.Show()
    End Sub
End Class