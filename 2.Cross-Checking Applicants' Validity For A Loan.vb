Imports System.Data.OleDb
Public Class Form2
    Dim pro As String
    Dim conString As String
    Dim command As String
    Dim myconnection As OleDbConnection = New OleDbConnection
    Dim da As New OleDbDataAdapter
    Dim con As New OleDbConnection
    Dim dt As New DataTable
    Dim dr As OleDbDataReader
    Dim Qry As String
    ' Dim C As New conection
    Dim cmd As OleDbCommand

    'This one is used to see if a given applicant is in the system or not.
    ' Also checks if the person selected is eligible for a loan or not.
    Private Sub cmdSearch_Click(sender As Object, e As EventArgs) Handles cmdSearch.Click
        Qry = "select * from Applicant1 WHERE FullName='" & txtSearch.Text & "'"
        cmd = New OleDbCommand(Qry, myconnection)
        cmd.ExecuteNonQuery()
        dr = cmd.ExecuteReader
        If dr.Read Then
            txtFName.Text = dr("FullName")
            txtASacco.Text = dr("AffSacco")
            txtContribution.Text = dr("Contribution")
            txtMonthlyIncome.Text = dr("MonthlyIncome")
            MsgBox("Applicant " & txtFName.Text & " Found.")
        ElseIf txtSearch.Text = "" Then
            MsgBox("Please enter someone in the search text box.")
        Else
            MsgBox("Applicant " & txtFName.Text & " NOT found.")
        End If

        If txtContribution.Text >= 10000 And txtMonthlyIncome.Text >= 45000 Then

            MsgBox("Applicant " & txtFName.Text & " is eligible for a loan.")
        Else
            MsgBox("Apologies, but Mr./Mrs. " & txtFName.Text & " is currently ineligible for a loan here.")
        End If

    End Sub

    'This one uses a data grid to give you a view of a table in the database currently.
    'Needs you to put a data grid in your form and once again change data source to match your Access Sheet's path
    'not mine!
    Private Sub cmdView_Click(sender As Object, e As EventArgs) Handles cmdView.Click
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Timo\Desktop\216Project\Sacco1MDB.mdb"
        con.Open()
        da = New OleDbDataAdapter("SELECT * FROM Applicant1", con)
        da.Fill(dt)
        DGrid1.DataSource = dt.DefaultView
        con.Close()
    End Sub
    'End of table-viewing button.

    ' This one moves to the next form (ile ya 3.Successful...)
    'after checking some conditions the applicant meets
    Private Sub cmdNext_Click(sender As Object, e As EventArgs) Handles cmdNext.Click
        If txtSearch.Text = "" Then
            MsgBox("No applicant entered.")
        Else
            If txtContribution.Text >= 10000 And txtMonthlyIncome.Text >= 45000 Then

                MsgBox("Applicant " & txtFName.Text & " may move to the next form to further secure their loan.")
                Dim f3_1 As New Form3(Me)
                f3_1.ShowDialog()

            Else
                MsgBox("Apologies, but Mr./Mrs. " & txtFName.Text & " can't move to next form due to their ineligibility.")
            End If

        End If
    End Sub
    'End of next button.

   'This is the part of the code that connects your VB code to your Access DB.
    Private Sub ConDB()
        conString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Timo\Desktop\216Project\Sacco1MDB.mdb"
        myconnection.ConnectionString = conString
        myconnection.Open()
    End Sub
    'NB: Hapo kwa Data Source, make sure you replace the path here with the one for YOUR Access sheets, not mine!

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call ConDB()
    End Sub


End Class