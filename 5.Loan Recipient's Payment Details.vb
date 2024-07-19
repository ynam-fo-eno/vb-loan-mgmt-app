Imports System.Data.OleDb
Public Class Form5
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

    Dim f4_51 As Form4

    Dim D As String = ""

    'Presumably for preserving Form 4 data.
    Public Sub New(ByVal frm4_51 As Form4)
        InitializeComponent()
        f4_51 = frm4_51
    End Sub

    'As usual change hio part ya data source.
    Private Sub ConDB()
        conString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Timo\Desktop\216Project\Sacco1MDB.mdb"
        myconnection.ConnectionString = conString
        myconnection.Open()
    End Sub

    'This makes sure that the name of person from previous form is checked against 
    'the table then any data required is put into the corrssponding text fields and kept read-only.
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtRecipient.Text = f4_51.txtAName.Text
        Call ConDB()
        Qry = "select * from Applicant2 WHERE ApplicantName='" & txtRecipient.Text & "'"
        cmd = New OleDbCommand(Qry, myconnection)
        cmd.ExecuteNonQuery()
        dr = cmd.ExecuteReader
        If dr.Read Then
            txtBorrowed.Text = dr("AmountBorrowed")
            txtRate.Text = dr("Rate")
            txtPerYr.Text = dr("Period")
            txtPerMonth.Text = txtPerYr.Text * 12
            txtPayback.Text = dr("PaybackAmount")
            txtOutstanding.Text = txtPayback.Text
            txtInstalment.Text = txtPayback.Text / txtPerMonth.Text
        End If
    End Sub

    'This is for confirming the loan our applicant from  earlier chose.
    Private Sub cmdConfirm_Click(sender As Object, e As EventArgs) Handles cmdConfirm.Click
        If txtPerYr.Text = 1 Then
            D = Date.ParseExact("12/04/2024", "dd/MM/yyyy", Nothing)
            DateTimePicker2.Value = D
        ElseIf txtPerYr.Text = 2 Then
            D = Date.ParseExact("12/04/2025", "dd/MM/yyyy", Nothing)
            DateTimePicker2.Value = D
        Else
            D = Date.ParseExact("12/04/2028", "dd/MM/yyyy", Nothing)
            DateTimePicker2.Value = D
        End If


        command = "INSERT into Applicant3([Recipient],[Borrowed],[Rate],[YPeriod],[MPeriod],[OutDebt],[TotalRepayment],[Payback],[LatestIns],[Instalment],[Password],[StartDate],[EndDate],[MPESALatest]) VALUES('" & txtRecipient.Text & "','" & txtBorrowed.Text & "','" & txtRate.Text & "','" & txtPerYr.Text & "','" & txtPerMonth.Text & "','" & txtOutstanding.Text & "','" & "" & "','" & txtPayback.Text & "','" & "" & "','" & txtInstalment.Text & "','" & txtPassword.Text & "','" & DateTimePicker1.Text & "','" & DateTimePicker2.Text & "','" & "" & "')"
        Dim cmd As OleDbCommand = New OleDbCommand(command, myconnection)
        cmd.Parameters.Add(New OleDbParameter("Recipient", CType(txtRecipient.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Borrowed", CType(txtBorrowed.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Rate", CType(txtRate.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("YPeriod", CType(txtPerYr.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("MPeriod", CType(txtPerMonth.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("OutDebt", CType(txtOutstanding.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("TotalRepayemnt", CType("", String)))
        cmd.Parameters.Add(New OleDbParameter("Payback", CType(txtPayback.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("LatestIns", CType("", String)))
        cmd.Parameters.Add(New OleDbParameter("Instalment", CType(txtInstalment.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Password", CType(txtPassword.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("StartDate", CType(DateTimePicker1.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("EndDate", CType(DateTimePicker2.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("MPESALatest", CType("", String)))

        MsgBox("Records of loan recipient " & txtRecipient.Text & " saved!")
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myconnection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    'This one checks if the user can pay or not. If they can, they advance,
    'if not they're rmeinded to pay off in good time and app ends there.
    Private Sub cmdConLe_Click(sender As Object, e As EventArgs) Handles cmdConLe.Click
        Dim conle As MsgBoxResult = MsgBox("Click Yes to confirm payments made or no to leave", MsgBoxStyle.YesNo, "Continue?")
        If conle = MsgBoxResult.Yes Then
            MsgBox("All right then, off to record your payments thus far!")
            Dim f6_1 As New Form6(Me)
            f6_1.ShowDialog()
        Else
            MsgBox("Thank you for the reception of your loan. Please ensure you repay in good time.")
            End
        End If
    End Sub


End Class