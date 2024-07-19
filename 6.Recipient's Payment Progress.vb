Imports System.Data.OleDb

Public Class Form6
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

    Dim f5_61 As Form5


    'Presumably for preserving Form 5 data.
    Public Sub New(ByVal frm5_61 As Form5)
        InitializeComponent()
        f5_61 = frm5_61
    End Sub

    'As usual change hio part ya data source.
    Private Sub ConDB()
        conString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Timo\Desktop\216Project\Sacco1MDB.mdb"
        myconnection.ConnectionString = conString
        myconnection.Open()
    End Sub

    'Just making data (username) persist from form 5 to form 6.
    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtRec1.Text = f5_61.txtRecipient.Text
    End Sub

    'This one assumes you came directly to form 6 from the MDI Parent.
    Private Sub cmdLogin_Click(sender As Object, e As EventArgs) Handles cmdLogin.Click
        Call ConDB()
        Qry = "select * from  Applicant3 WHERE Password='" & txtPassword.Text & "'"
        cmd = New OleDbCommand(Qry, myconnection)
        cmd.ExecuteNonQuery()
        dr = cmd.ExecuteReader
        If dr.Read Then
            txtRec1.Text = dr("Recipient")
            txtPB.Text = dr("Payback")
            txtOut.Text = dr("OutDebt")
            txtML.Text = dr("MPeriod")
        Else
            MsgBox("Incorrect password. Please try again.")
        End If
    End Sub

    'This one assumes user has put in a certain amount they paid off.
    ' Don't worry about that absurd thing I had to do hapo kwa txtOut.
    ' It's my first-year attempt to fix weird behavior from reading numerical
    'values from a text field. Literally ANY OTHER language has good counters for this
    'but not VB as far as I know smfffh
    Private Sub cmdConfirm_Click(sender As Object, e As EventArgs) Handles cmdConfirm.Click

        Dim n As Integer = txtML.Text
        Dim o As Integer = txtML.Text + 1

        For m = o To n Step -1
            txtOut.Text = txtOut.Text - (txtLatestIns.Text / 2)
            txtRep.Text = txtPB.Text - txtOut.Text
            txtML.Text = n - 1
        Next
        MsgBox("Payment Confirmed. Please confirm if pending amount is correct.")
        command = "UPDATE Applicant3 SET [OutDebt]='" & txtOut.Text & "', [MPeriod]='" & txtML.Text & "',[LatestIns]='" & txtLatestIns.Text & "',[MPESALatest]='" & txtConfirmation.Text & "',[TotalRepayment]='" & txtRep.Text & "' WHERE [Recipient]='" & txtRec1.Text & "'"
        Dim cmd As OleDbCommand = New OleDbCommand(command, myconnection)
        MsgBox("Payment Records Updated!")
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myconnection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    'This updates the user's payment details and generates
    'a pseudo-report. If you can get Crystal Report to work
    'kwako kwa Visual Studio, the better, otherwise use the tricks
    'I used here.
    Private Sub cmdUpdate_Click(sender As Object, e As EventArgs) Handles cmdUpdate.Click
        MsgBox("Report generated!")
        Me.BackColor = Color.White
        FormBorderStyle = FormBorderStyle.None
        txtRec1.BorderStyle = BorderStyle.None
        txtPB.BorderStyle = BorderStyle.None
        txtRep.BorderStyle = BorderStyle.None
        txtOut.BorderStyle = BorderStyle.None
        txtLatestIns.BorderStyle = BorderStyle.None
        txtConfirmation.BorderStyle = BorderStyle.None
        txtML.BorderStyle = BorderStyle.None
        txtLatestIns.Enabled = False
        txtConfirmation.Enabled = False
        Label1.Text = "NAME OF RECIPIENT"
        Label2.Text = "INITIAL PAYBACK AMOUNT=SH."
        Label3.Text = "TOTAL AMOUNT REPAID= SH."
        Label4.Text = "CURRENT OUSTANDING DEBT= SH."
        Label6.Text = "LATEST AMOUNT PAID= SH."
        Label7.Text = "LATEST MPESA CONFIRMATION MESSAGE:  "
        txtPassword.Visible = False
        Label8.Visible = False
        cmdConfirm.Visible = False
        cmdLogin.Visible = False
        cmdUpdate.Visible = False
        cmdExit.BackColor = Color.DarkGray



    End Sub

    'Ending your time in this app.
    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        MsgBox("Thanks once again for working with us. Hope to meet again.")
        End
    End Sub

End Class