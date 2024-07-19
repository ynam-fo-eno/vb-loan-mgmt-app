<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txtFullName = New System.Windows.Forms.TextBox()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtAffSacco = New System.Windows.Forms.TextBox()
        Me.txtKRA = New System.Windows.Forms.TextBox()
        Me.CmdNext = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtContr = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtMIncome = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtFullName
        '
        Me.txtFullName.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtFullName.Location = New System.Drawing.Point(456, 23)
        Me.txtFullName.Name = "txtFullName"
        Me.txtFullName.Size = New System.Drawing.Size(382, 45)
        Me.txtFullName.TabIndex = 1
        '
        'cmdSave
        '
        Me.cmdSave.BackColor = System.Drawing.Color.Red
        Me.cmdSave.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cmdSave.Location = New System.Drawing.Point(3, 540)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(150, 61)
        Me.cmdSave.TabIndex = 7
        Me.cmdSave.Text = "&Save"
        Me.cmdSave.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(12, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 38)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Full Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(3, 221)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(160, 38)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "ID Number:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(12, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(197, 38)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Affiliate Sacco:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(3, 302)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 38)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "KRA PIN:"
        '
        'txtID
        '
        Me.txtID.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtID.Location = New System.Drawing.Point(456, 201)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(382, 45)
        Me.txtID.TabIndex = 3
        '
        'txtAffSacco
        '
        Me.txtAffSacco.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtAffSacco.Location = New System.Drawing.Point(456, 114)
        Me.txtAffSacco.Name = "txtAffSacco"
        Me.txtAffSacco.Size = New System.Drawing.Size(382, 45)
        Me.txtAffSacco.TabIndex = 2
        '
        'txtKRA
        '
        Me.txtKRA.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtKRA.Location = New System.Drawing.Point(456, 292)
        Me.txtKRA.Name = "txtKRA"
        Me.txtKRA.Size = New System.Drawing.Size(382, 45)
        Me.txtKRA.TabIndex = 4
        '
        'CmdNext
        '
        Me.CmdNext.BackColor = System.Drawing.Color.Red
        Me.CmdNext.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CmdNext.Location = New System.Drawing.Point(293, 540)
        Me.CmdNext.Name = "CmdNext"
        Me.CmdNext.Size = New System.Drawing.Size(177, 61)
        Me.CmdNext.TabIndex = 8
        Me.CmdNext.Text = "To Next Form"
        Me.CmdNext.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(3, 389)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(401, 38)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Monthly Contribution to Sacco:"
        '
        'txtContr
        '
        Me.txtContr.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtContr.Location = New System.Drawing.Point(456, 389)
        Me.txtContr.Name = "txtContr"
        Me.txtContr.Size = New System.Drawing.Size(382, 45)
        Me.txtContr.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(3, 481)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(225, 38)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Monthly Income:"
        '
        'txtMIncome
        '
        Me.txtMIncome.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtMIncome.Location = New System.Drawing.Point(456, 481)
        Me.txtMIncome.Name = "txtMIncome"
        Me.txtMIncome.Size = New System.Drawing.Size(382, 45)
        Me.txtMIncome.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(697, 33)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 38)
        Me.Label7.TabIndex = 11
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(1362, 613)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtMIncome)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtContr)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.CmdNext)
        Me.Controls.Add(Me.txtKRA)
        Me.Controls.Add(Me.txtAffSacco)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.txtFullName)
        Me.Name = "Form1"
        Me.Text = "Sacco Members' Registration"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtFullName As TextBox
    Friend WithEvents cmdSave As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtAffSacco As TextBox
    Friend WithEvents txtKRA As TextBox
    Friend WithEvents CmdNext As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txtContr As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtMIncome As TextBox
    Friend WithEvents Label7 As Label
End Class
