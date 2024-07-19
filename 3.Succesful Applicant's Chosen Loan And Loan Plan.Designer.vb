<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtAppli = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.txtReqLoan = New System.Windows.Forms.TextBox()
        Me.txtPayback = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtRaison = New System.Windows.Forms.TextBox()
        Me.cmdToNext = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtRate = New System.Windows.Forms.TextBox()
        Me.txtPeriod = New System.Windows.Forms.TextBox()
        Me.cmdCheck = New System.Windows.Forms.Button()
        Me.DGrid2 = New System.Windows.Forms.DataGridView()
        CType(Me.DGrid2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bookman Old Style", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(-4, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(389, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "To the successful applicant"
        '
        'txtAppli
        '
        Me.txtAppli.Enabled = False
        Me.txtAppli.Location = New System.Drawing.Point(430, 9)
        Me.txtAppli.Name = "txtAppli"
        Me.txtAppli.Size = New System.Drawing.Size(320, 31)
        Me.txtAppli.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bookman Old Style", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(744, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 33)
        Me.Label2.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Bookman Old Style", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(-4, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(996, 33)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "we now request you to pick ONE of our plans from the check box below:"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.BackColor = System.Drawing.Color.White
        Me.RadioButton1.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.RadioButton1.Location = New System.Drawing.Point(-4, 120)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(407, 42)
        Me.RadioButton1.TabIndex = 1
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "10%interest p.a,2 yrs to repay"
        Me.RadioButton1.UseVisualStyleBackColor = False
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.BackColor = System.Drawing.Color.White
        Me.RadioButton2.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.RadioButton2.Location = New System.Drawing.Point(491, 120)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(407, 42)
        Me.RadioButton2.TabIndex = 2
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "10%interest p.a,5 yrs to repay"
        Me.RadioButton2.UseVisualStyleBackColor = False
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.BackColor = System.Drawing.Color.White
        Me.RadioButton3.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.RadioButton3.Location = New System.Drawing.Point(-4, 199)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(380, 42)
        Me.RadioButton3.TabIndex = 3
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "5%interest p.a,1 yr to repay"
        Me.RadioButton3.UseVisualStyleBackColor = False
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.BackColor = System.Drawing.Color.White
        Me.RadioButton4.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.RadioButton4.Location = New System.Drawing.Point(491, 199)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(392, 42)
        Me.RadioButton4.TabIndex = 4
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "5%interest p.a,5 yrs to repay"
        Me.RadioButton4.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Bookman Old Style", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(-4, 262)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(1392, 99)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Now select from this next checkbox how much you wanna borrow. (Just keep it under" &
    " sh.1,000,000!)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Bookman Old Style", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(-4, 456)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 33)
        Me.Label5.TabIndex = 13
        '
        'cmdSave
        '
        Me.cmdSave.BackColor = System.Drawing.Color.Red
        Me.cmdSave.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cmdSave.Location = New System.Drawing.Point(-4, 547)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(233, 53)
        Me.cmdSave.TabIndex = 7
        Me.cmdSave.Text = "Save"
        Me.cmdSave.UseVisualStyleBackColor = False
        '
        'txtReqLoan
        '
        Me.txtReqLoan.Location = New System.Drawing.Point(596, 308)
        Me.txtReqLoan.Name = "txtReqLoan"
        Me.txtReqLoan.Size = New System.Drawing.Size(320, 31)
        Me.txtReqLoan.TabIndex = 5
        '
        'txtPayback
        '
        Me.txtPayback.Enabled = False
        Me.txtPayback.Location = New System.Drawing.Point(606, 460)
        Me.txtPayback.Name = "txtPayback"
        Me.txtPayback.Size = New System.Drawing.Size(320, 31)
        Me.txtPayback.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Bookman Old Style", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(-4, 308)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(308, 33)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Requested Loan= sh. "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Bookman Old Style", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(-4, 460)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(604, 33)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Expected Payback after period in plan= sh. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Bookman Old Style", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(-4, 374)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(314, 33)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Reason for borrowing:"
        '
        'txtRaison
        '
        Me.txtRaison.Location = New System.Drawing.Point(596, 378)
        Me.txtRaison.Name = "txtRaison"
        Me.txtRaison.Size = New System.Drawing.Size(320, 31)
        Me.txtRaison.TabIndex = 6
        '
        'cmdToNext
        '
        Me.cmdToNext.BackColor = System.Drawing.Color.Red
        Me.cmdToNext.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cmdToNext.Location = New System.Drawing.Point(331, 547)
        Me.cmdToNext.Name = "cmdToNext"
        Me.cmdToNext.Size = New System.Drawing.Size(233, 53)
        Me.cmdToNext.TabIndex = 8
        Me.cmdToNext.Text = "To Next Form"
        Me.cmdToNext.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Bookman Old Style", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label9.Location = New System.Drawing.Point(914, 126)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(204, 33)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Rate/100 p.a."
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Bookman Old Style", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label10.Location = New System.Drawing.Point(914, 208)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(317, 33)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Repayment period(yrs)"
        '
        'txtRate
        '
        Me.txtRate.Enabled = False
        Me.txtRate.Location = New System.Drawing.Point(1242, 120)
        Me.txtRate.Name = "txtRate"
        Me.txtRate.Size = New System.Drawing.Size(119, 31)
        Me.txtRate.TabIndex = 10
        '
        'txtPeriod
        '
        Me.txtPeriod.Enabled = False
        Me.txtPeriod.Location = New System.Drawing.Point(1242, 212)
        Me.txtPeriod.Name = "txtPeriod"
        Me.txtPeriod.Size = New System.Drawing.Size(119, 31)
        Me.txtPeriod.TabIndex = 11
        '
        'cmdCheck
        '
        Me.cmdCheck.BackColor = System.Drawing.Color.Red
        Me.cmdCheck.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cmdCheck.Location = New System.Drawing.Point(639, 547)
        Me.cmdCheck.Name = "cmdCheck"
        Me.cmdCheck.Size = New System.Drawing.Size(233, 53)
        Me.cmdCheck.TabIndex = 24
        Me.cmdCheck.Text = "&Check"
        Me.cmdCheck.UseVisualStyleBackColor = False
        '
        'DGrid2
        '
        Me.DGrid2.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DGrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGrid2.GridColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DGrid2.Location = New System.Drawing.Point(12, 645)
        Me.DGrid2.Name = "DGrid2"
        Me.DGrid2.RowHeadersWidth = 62
        Me.DGrid2.RowTemplate.Height = 33
        Me.DGrid2.Size = New System.Drawing.Size(1366, 368)
        Me.DGrid2.TabIndex = 25
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(1423, 1025)
        Me.Controls.Add(Me.DGrid2)
        Me.Controls.Add(Me.cmdCheck)
        Me.Controls.Add(Me.txtPeriod)
        Me.Controls.Add(Me.txtRate)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cmdToNext)
        Me.Controls.Add(Me.txtRaison)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtPayback)
        Me.Controls.Add(Me.txtReqLoan)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.RadioButton4)
        Me.Controls.Add(Me.RadioButton3)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtAppli)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form3"
        Me.Text = "Succesful Applicant's Chosen Loan & Loan Plan"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DGrid2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Public WithEvents txtAppli As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cmdSave As Button
    Public WithEvents txtReqLoan As TextBox
    Public WithEvents txtPayback As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Public WithEvents txtRaison As TextBox
    Friend WithEvents cmdToNext As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Public WithEvents txtRate As TextBox
    Public WithEvents txtPeriod As TextBox
    Friend WithEvents cmdCheck As Button
    Friend WithEvents DGrid2 As DataGridView
End Class
