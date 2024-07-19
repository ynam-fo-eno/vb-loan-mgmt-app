Imports System.Data.OleDb
Public Class Form3
    Dim pro As String
    Dim conString As String
    Dim command As String
    Dim myconnection As OleDbConnection = New OleDbConnection
    Dim da As New OleDbDataAdapter
    Dim con As New OleDbConnection
    Dim dt As New DataTable
    Dim dr As OleDbDataReader
    Dim Qry As String
    Dim cmd As OleDbCommand

    Dim f2_31 As Form2
    Dim rate As Double
    Dim period As Integer

    ' Unfortunately this one is foggy in my mind but
    'nadahni it was for preserving the form2 you'd made so you could transfer data
    'from there to this form.
    Public Sub New(ByVal frm2_31 As Form2)
        InitializeComponent()
        f2_31 = frm2_31
    End Sub

    'This is the part of the code that connects your VB code to your Access DB.
    Private Sub ConDB()
        conString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Timo\Desktop\216Project\Sacco1MDB.mdb"
        myconnection.ConnectionString = conString
        myconnection.Open()
    End Sub
    'NB: Hapo kwa Data Source, make sure you replace the path here with the one for YOUR Access sheets, not mine!


    'This loads it up with the name of the person who made it to the system from Form 2.
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtAppli.Text = f2_31.txtFName.Text
    End Sub

    'This button saves the loan choice made by the applicant.
    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click

        If RadioButton1.Checked = True Then
            rate = 0.1
            period = 2
            txtPayback.Text = txtReqLoan.Text + (rate * period * txtReqLoan.Text)
            txtRate.Text = rate
            txtPeriod.Text = period

        ElseIf RadioButton2.Checked = True Then
            rate = 0.1
            period = 5
            txtPayback.Text = txtReqLoan.Text + (rate * period * txtReqLoan.Text)
            txtRate.Text = rate
            txtPeriod.Text = period

        ElseIf RadioButton3.Checked = True Then
            rate = 0.05
            period = 1
            txtPayback.Text = txtReqLoan.Text + (rate * period * txtReqLoan.Text)
            txtRate.Text = rate
            txtPeriod.Text = period

        ElseIf RadioButton4.Checked = True Then
            rate = 0.05
            period = 5
            txtPayback.Text = txtReqLoan.Text + (rate * period * txtReqLoan.Text)
            txtRate.Text = rate
            txtPeriod.Text = period
        Else
            MsgBox("Please select from the plans above, otherwise no loan for you!")
        End If


        If txtReqLoan.Text <= 1000000 Then
            MsgBox("Loan Request by " & txtAppli.Text & " successful.")
            MsgBox("Loan Request by " & txtAppli.Text & " saved.")
            Call ConDB()
            command = "INSERT into Applicant2([ApplicantName],[AffSacco],[AmountBorrowed],[Reason],[Rate],[Period],[PaybackAmount]) VALUES('" & txtAppli.Text & "','" & "" & "','" & txtReqLoan.Text & "','" & txtRaison.Text & "','" & txtRate.Text & "','" & txtPeriod.Text & "','" & txtPayback.Text & "')"
            Dim cmd As OleDbCommand = New OleDbCommand(command, myconnection)
            cmd.Parameters.Add(New OleDbParameter("ApplicantName", CType(txtAppli.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("AffSacco", CType("", String)))
            cmd.Parameters.Add(New OleDbParameter("AmountBorrowed", CType(txtReqLoan.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("Reason", CType(txtRaison.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("Rate", CType(txtRate.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("Period", CType(txtPeriod.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("PaybackAmount", CType(txtPayback.Text, String)))
            Try
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                myconnection.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try


        Else
            MsgBox("Loan Request by " & txtAppli.Text & " unsuccessful.")
            End
        End If
    End Sub
    'End of button from loan chosen.

    'Moving to the next one plain and simple
    Private Sub cmdToNext_Click(sender As Object, e As EventArgs) Handles cmdToNext.Click
        Dim f4_1 As New Form4(Me)
        f4_1.ShowDialog()
    End Sub

    'Lets you check the table via a data grid, just like in Form 2.
    Private Sub cmdCheck_Click(sender As Object, e As EventArgs) Handles cmdCheck.Click
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Timo\Desktop\216Project\Sacco1MDB.mdb"
        con.Open()
        da = New OleDbDataAdapter("SELECT * FROM Applicant2", con)
        da.Fill(dt)
        DGrid2.DataSource = dt.DefaultView
        con.Close()
    End Sub
End Class