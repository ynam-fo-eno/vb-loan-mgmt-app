Imports System.Data.OleDb
Public Class Form1
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

    'Button for saving data new user provides.
    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        Call ConDB()
        command = "INSERT into Applicant1([FullName],[AffSacco],[ID],[KRAPin],[Contribution],[MonthlyIncome]) VALUES('" & txtFullName.Text & "','" & txtAffSacco.Text & "','" & txtID.Text & "','" & txtKRA.Text & "','" & txtContr.Text & "','" & txtMIncome.Text & "')"
        Dim cmd As OleDbCommand = New OleDbCommand(command, myconnection)
        cmd.Parameters.Add(New OleDbParameter("FullName", CType(txtFullName.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("AffSacco", CType(txtAffSacco.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("ID", CType(txtID.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("KRAPin", CType(txtKRA.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Contrbution", CType(txtContr.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("MonthlyIncome", CType(txtMIncome.Text, String)))
        MsgBox("Record " & txtFullName.Text & " Saved")
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myconnection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    'End of saving button.


    ' This one moves to the next form (ile ya 2.Cross-Checking...)
    Private Sub CmdNext_Click(sender As Object, e As EventArgs) Handles CmdNext.Click
        Form2.Show()
    End Sub
    'End of next button.


    'This is the part of the code that connects your VB code to your Access DB
    Private Sub ConDB()
        conString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Timo\Desktop\216Project\Sacco1MDB.mdb"
        myconnection.ConnectionString = conString
        myconnection.Open()
    End Sub
    'NB: Hapo kwa Data Source, make sure you replace the path here with the one for YOUR Access sheets, not mine!

End Class
