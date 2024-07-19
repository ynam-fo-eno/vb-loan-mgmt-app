Imports System.Data.OleDb
Public Class Form4
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

    Dim f3_41 As Form3

    ' Again, this one is foggy in my mind but
    'nadahni it was for preserving the form3 you'd made so you could transfer data
    'from there to this form.
    Public Sub New(ByVal frm3_41 As Form3)
        InitializeComponent()
        f3_41 = frm3_41
    End Sub

    'This is the part of the code that connects your VB code to your Access DB.
    Private Sub ConDB()
        conString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Timo\Desktop\216Project\Sacco1MDB.mdb"
        myconnection.ConnectionString = conString
        myconnection.Open()
    End Sub
    'NB: Hapo kwa Data Source, make sure you replace the path here with the one for YOUR Access sheets, not mine!

    'This one ensures that when the form starts up, it picks the relevant details of this
    'specific applicant from the first table in the Db and displays them.
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtAName.Text = f3_41.txtAppli.Text
        Call ConDB()
        Qry = "select * from Applicant1 WHERE FullName='" & txtAName.Text & "'"
        cmd = New OleDbCommand(Qry, myconnection)
        cmd.ExecuteNonQuery()
        dr = cmd.ExecuteReader
        If dr.Read Then
            txtAS.Text = dr("AffSacco")
        End If
    End Sub


    'Lets you check the table via a data grid, just like in Form 2.
    Private Sub cmdCheck_Click(sender As Object, e As EventArgs) Handles cmdCheck.Click
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Timo\Desktop\216Project\Sacco1MDB.mdb"
        con.Open()
        da = New OleDbDataAdapter("SELECT * FROM Applicant2", con)
        da.Fill(dt)
        DGrid3.DataSource = dt.DefaultView
        con.Close()
    End Sub

    'Updates new details for applicant.
    Private Sub cmdSaveCon_Click(sender As Object, e As EventArgs) Handles cmdSaveCon.Click
        command = "UPDATE Applicant2 SET [AffSacco]='" & txtAS.Text & "',[PhoneNumber]='" & txtPNo.Text & "',[Email]='" & txtEmail.Text & "',[GuarantorName]='" & txtGuarantor.Text & "',[GuarantorSacco]='" & txtGSacco.Text & "' WHERE [ApplicantName]='" & txtAName.Text & "'"
        Dim cmd As OleDbCommand = New OleDbCommand(command, myconnection)
        MsgBox("Records of " & txtAName.Text & " saved!")
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myconnection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Dim f5_1 As New Form5(Me)
        f5_1.ShowDialog()
    End Sub


End Class