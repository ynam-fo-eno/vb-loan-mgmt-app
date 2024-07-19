<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtRecipient = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtBorrowed = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtRate = New System.Windows.Forms.TextBox()
        Me.txtPerYr = New System.Windows.Forms.TextBox()
        Me.txtPerMonth = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtPayback = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtInstalment = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.cmdConfirm = New System.Windows.Forms.Button()
        Me.cmdConLe = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtOutstanding = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(369, 213)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 25)
        Me.Label2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(-3, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(484, 38)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Tracking Payments made by Recipient"
        '
        'txtRecipient
        '
        Me.txtRecipient.Enabled = False
        Me.txtRecipient.Location = New System.Drawing.Point(539, 27)
        Me.txtRecipient.Name = "txtRecipient"
        Me.txtRecipient.Size = New System.Drawing.Size(150, 31)
        Me.txtRecipient.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(-3, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(1410, 41)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "---------------------------------------------------------------------------------" &
    "-----------------------------------"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(-3, 123)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(296, 38)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Amount Borrowed=sh."
        '
        'txtBorrowed
        '
        Me.txtBorrowed.Enabled = False
        Me.txtBorrowed.Location = New System.Drawing.Point(369, 131)
        Me.txtBorrowed.Name = "txtBorrowed"
        Me.txtBorrowed.Size = New System.Drawing.Size(193, 31)
        Me.txtBorrowed.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(638, 299)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 38)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "years="
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(-3, 292)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(395, 38)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Period chosen for repayment="
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(-3, 213)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(281, 38)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Interest rate chosen="
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(1046, 307)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(110, 38)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "months"
        '
        'txtRate
        '
        Me.txtRate.Enabled = False
        Me.txtRate.Location = New System.Drawing.Point(369, 221)
        Me.txtRate.Name = "txtRate"
        Me.txtRate.Size = New System.Drawing.Size(193, 31)
        Me.txtRate.TabIndex = 12
        '
        'txtPerYr
        '
        Me.txtPerYr.Enabled = False
        Me.txtPerYr.Location = New System.Drawing.Point(444, 299)
        Me.txtPerYr.Name = "txtPerYr"
        Me.txtPerYr.Size = New System.Drawing.Size(139, 31)
        Me.txtPerYr.TabIndex = 14
        '
        'txtPerMonth
        '
        Me.txtPerMonth.Enabled = False
        Me.txtPerMonth.Location = New System.Drawing.Point(800, 307)
        Me.txtPerMonth.Name = "txtPerMonth"
        Me.txtPerMonth.Size = New System.Drawing.Size(139, 31)
        Me.txtPerMonth.TabIndex = 15
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label9.Location = New System.Drawing.Point(-3, 379)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(487, 38)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Amount to repay by period above=sh."
        '
        'txtPayback
        '
        Me.txtPayback.Enabled = False
        Me.txtPayback.Location = New System.Drawing.Point(539, 387)
        Me.txtPayback.Name = "txtPayback"
        Me.txtPayback.Size = New System.Drawing.Size(193, 31)
        Me.txtPayback.TabIndex = 16
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label10.Location = New System.Drawing.Point(-3, 464)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(395, 38)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Monthly instalment to pay=sh."
        '
        'txtInstalment
        '
        Me.txtInstalment.Enabled = False
        Me.txtInstalment.Location = New System.Drawing.Point(539, 464)
        Me.txtInstalment.Name = "txtInstalment"
        Me.txtInstalment.Size = New System.Drawing.Size(193, 31)
        Me.txtInstalment.TabIndex = 18
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label11.Location = New System.Drawing.Point(741, 111)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(300, 38)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "Date of loan reception:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label12.Location = New System.Drawing.Point(741, 200)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(280, 38)
        Me.Label12.TabIndex = 19
        Me.Label12.Text = "Repayment Deadline:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(1061, 118)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(300, 31)
        Me.DateTimePicker1.TabIndex = 1
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(1061, 207)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(300, 31)
        Me.DateTimePicker2.TabIndex = 13
        '
        'cmdConfirm
        '
        Me.cmdConfirm.BackColor = System.Drawing.Color.Red
        Me.cmdConfirm.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cmdConfirm.Location = New System.Drawing.Point(3, 571)
        Me.cmdConfirm.Name = "cmdConfirm"
        Me.cmdConfirm.Size = New System.Drawing.Size(275, 83)
        Me.cmdConfirm.TabIndex = 3
        Me.cmdConfirm.Text = "Confirm"
        Me.cmdConfirm.UseVisualStyleBackColor = False
        '
        'cmdConLe
        '
        Me.cmdConLe.BackColor = System.Drawing.Color.Red
        Me.cmdConLe.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cmdConLe.Location = New System.Drawing.Point(414, 571)
        Me.cmdConLe.Name = "cmdConLe"
        Me.cmdConLe.Size = New System.Drawing.Size(275, 83)
        Me.cmdConLe.TabIndex = 4
        Me.cmdConLe.Text = "Continue/Leave"
        Me.cmdConLe.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label13.Location = New System.Drawing.Point(709, 530)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(678, 38)
        Me.Label13.TabIndex = 22
        Me.Label13.Text = "Enter a 4-digit password below for easier access later."
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(1061, 623)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(326, 31)
        Me.txtPassword.TabIndex = 2
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label14.Location = New System.Drawing.Point(741, 387)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(337, 38)
        Me.Label14.TabIndex = 23
        Me.Label14.Text = "Outstanding Amount =sh."
        '
        'txtOutstanding
        '
        Me.txtOutstanding.Enabled = False
        Me.txtOutstanding.Location = New System.Drawing.Point(1084, 394)
        Me.txtOutstanding.Name = "txtOutstanding"
        Me.txtOutstanding.Size = New System.Drawing.Size(193, 31)
        Me.txtOutstanding.TabIndex = 17
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1399, 775)
        Me.Controls.Add(Me.txtOutstanding)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.cmdConLe)
        Me.Controls.Add(Me.cmdConfirm)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtInstalment)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtPayback)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtPerMonth)
        Me.Controls.Add(Me.txtPerYr)
        Me.Controls.Add(Me.txtRate)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtBorrowed)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtRecipient)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Name = "Form5"
        Me.Text = "Loan Recipient's Upkeep With Payments"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtRecipient As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtBorrowed As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtRate As TextBox
    Friend WithEvents txtPerYr As TextBox
    Friend WithEvents txtPerMonth As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtPayback As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtInstalment As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents cmdConfirm As Button
    Friend WithEvents cmdConLe As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtOutstanding As TextBox
End Class
