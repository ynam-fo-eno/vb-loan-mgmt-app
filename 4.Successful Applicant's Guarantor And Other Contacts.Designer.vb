<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.txtAName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtAS = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtGuarantor = New System.Windows.Forms.TextBox()
        Me.txtGSacco = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtPNo = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.cmdSaveCon = New System.Windows.Forms.Button()
        Me.cmdCheck = New System.Windows.Forms.Button()
        Me.DGrid3 = New System.Windows.Forms.DataGridView()
        CType(Me.DGrid3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(3, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(166, 38)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "To Mr./Mrs. "
        '
        'txtAName
        '
        Me.txtAName.Enabled = False
        Me.txtAName.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtAName.Location = New System.Drawing.Point(189, 12)
        Me.txtAName.Name = "txtAName"
        Me.txtAName.Size = New System.Drawing.Size(311, 45)
        Me.txtAName.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(525, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(172, 38)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = ",of the sacco"
        '
        'txtAS
        '
        Me.txtAS.Enabled = False
        Me.txtAS.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtAS.Location = New System.Drawing.Point(736, 16)
        Me.txtAS.Name = "txtAS"
        Me.txtAS.Size = New System.Drawing.Size(243, 45)
        Me.txtAS.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(3, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(727, 38)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = ",please enter the name of your guarantor and their sacco."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(722, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(629, 38)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "(You two should be preferably in the same sacco.)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtGuarantor
        '
        Me.txtGuarantor.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtGuarantor.Location = New System.Drawing.Point(307, 146)
        Me.txtGuarantor.Name = "txtGuarantor"
        Me.txtGuarantor.Size = New System.Drawing.Size(436, 45)
        Me.txtGuarantor.TabIndex = 1
        '
        'txtGSacco
        '
        Me.txtGSacco.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtGSacco.Location = New System.Drawing.Point(417, 217)
        Me.txtGSacco.Name = "txtGSacco"
        Me.txtGSacco.Size = New System.Drawing.Size(326, 45)
        Me.txtGSacco.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(3, 153)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(229, 38)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Guarantor Name:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(3, 220)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(347, 38)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Guarantor's Affiliate Sacco:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(3, 279)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(776, 38)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Also for contact's sake, please give your phone no. and email:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(3, 343)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(212, 38)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Phone Number:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label9.Location = New System.Drawing.Point(3, 414)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(196, 38)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Email Address:"
        '
        'txtPNo
        '
        Me.txtPNo.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtPNo.Location = New System.Drawing.Point(417, 352)
        Me.txtPNo.Name = "txtPNo"
        Me.txtPNo.Size = New System.Drawing.Size(326, 45)
        Me.txtPNo.TabIndex = 3
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtEmail.Location = New System.Drawing.Point(417, 419)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(422, 45)
        Me.txtEmail.TabIndex = 4
        '
        'cmdSaveCon
        '
        Me.cmdSaveCon.BackColor = System.Drawing.Color.Red
        Me.cmdSaveCon.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cmdSaveCon.Location = New System.Drawing.Point(886, 146)
        Me.cmdSaveCon.Name = "cmdSaveCon"
        Me.cmdSaveCon.Size = New System.Drawing.Size(267, 116)
        Me.cmdSaveCon.TabIndex = 5
        Me.cmdSaveCon.Text = "&Save All Details"
        Me.cmdSaveCon.UseVisualStyleBackColor = False
        '
        'cmdCheck
        '
        Me.cmdCheck.BackColor = System.Drawing.Color.Red
        Me.cmdCheck.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cmdCheck.Location = New System.Drawing.Point(877, 326)
        Me.cmdCheck.Name = "cmdCheck"
        Me.cmdCheck.Size = New System.Drawing.Size(276, 126)
        Me.cmdCheck.TabIndex = 17
        Me.cmdCheck.Text = "Check Applicant Details"
        Me.cmdCheck.UseVisualStyleBackColor = False
        '
        'DGrid3
        '
        Me.DGrid3.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DGrid3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGrid3.Location = New System.Drawing.Point(12, 470)
        Me.DGrid3.Name = "DGrid3"
        Me.DGrid3.RowHeadersWidth = 62
        Me.DGrid3.RowTemplate.Height = 33
        Me.DGrid3.Size = New System.Drawing.Size(1266, 332)
        Me.DGrid3.TabIndex = 18
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(1390, 819)
        Me.Controls.Add(Me.DGrid3)
        Me.Controls.Add(Me.cmdCheck)
        Me.Controls.Add(Me.cmdSaveCon)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtPNo)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtGSacco)
        Me.Controls.Add(Me.txtGuarantor)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtAS)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtAName)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form4"
        Me.Text = "Successful Applicant's Guarantor & Other Contacts"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DGrid3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtGuarantor As TextBox
    Friend WithEvents txtGSacco As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtPNo As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents cmdSaveCon As Button
    Public WithEvents txtAName As TextBox
    Public WithEvents txtAS As TextBox
    Friend WithEvents cmdCheck As Button
    Friend WithEvents DGrid3 As DataGridView
End Class
