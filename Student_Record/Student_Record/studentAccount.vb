Imports System.Data.OleDb
Imports System.IO.File
Imports System.IO.FileStream
Public Class studentAccount
    Public Shared studAccountView
    Dim con As New OleDbConnection
    Private Sub studentAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'STUDENT_RECORDDataSet.Member' table. You can move, or remove it, as needed.
        Me.MemberTableAdapter.Fill(Me.STUDENT_RECORDDataSet.Member)
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\johnp\Desktop\Student_Record\Student_Record\STUDENT_RECORD.accdb"

        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        'This code is to verify who the user is by using their email as a base for the code'
        email.Text = studAccountView

        'This code will execute to select every data from the row where [EMAIL] is equals to what email.Text has in its value
        Using cmd As New OleDbCommand("SELECT * FROM Member WHERE [EMAIL] ='" & email.Text & "'", con)
            Dim myreader As OleDbDataReader
            myreader = cmd.ExecuteReader
            If myreader.Read Then

                'This code is used to generate an ID for students though the ID would not be saved in the database
                studentID.Text = Convert.ToString(myreader("SYEAR").ToString) + "0000" + Convert.ToString(myreader("ID"))

                'Block of this code is used for calling all the Data and putting it on their appropriate place on
                'the form. It is also used to convert the Data .ToString, all of the data are converted to .ToSting
                'to avoid unnecessary erros along the way.
                fname.Text = myreader("FIRSTNAME").ToString
                lname.Text = myreader("LASTNAME").ToString
                mname.Text = myreader("MIDDLENAME").ToString
                gender.Text = myreader("GENDER").ToString
                address.Text = myreader("ADDRESS").ToString
                contact.Text = myreader("CONTACT").ToString
                age.Text = DateDiff(DateInterval.Year, myreader("DOB"), DateTime.Now)
                guardian.Text = myreader("GUARDIAN").ToString
                gcontact.Text = myreader("GCONTACT").ToString
                syear.Text = myreader("SYEAR").ToString
                pictureLbl.Text = myreader("PICTURE").ToString

            End If
        End Using

    End Sub
    Private Sub studentAccount_FormClosing(ByVal sender As System.Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'This block of code will just close the window by applying the ExitThread() which is used to exit the entire .exe file
        Dim dialog As DialogResult
        dialog = MessageBox.Show("Do you want to close the application?", "Exit", MessageBoxButtons.YesNo)

        If dialog = DialogResult.No Then
            e.Cancel = True
        Else
            Application.ExitThread()
        End If
    End Sub

    Private Sub pictureLbl_TextChanged(sender As Object, e As EventArgs) Handles pictureLbl.TextChanged
        'Below will scan if the PICTURE from Member database table has been loaded, if the picture isn't available
        'the label text behind the picturebox1 will be visible
        If (System.IO.File.Exists(pictureLbl.Text)) Then
            PictureBox1.Image = Image.FromFile(pictureLbl.Text)
        End If
        If pictureLbl.Text = "" Then
            PictureBox1.Hide()
        Else
            PictureBox1.Show()
        End If
    End Sub
End Class