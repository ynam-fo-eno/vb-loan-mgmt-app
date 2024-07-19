<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.cmdSearch = New System.Windows.Forms.Button()
        Me.txtFName = New System.Windows.Forms.TextBox()
        Me.txtASacco = New System.Windows.Forms.TextBox()
        Me.txtContribution = New System.Windows.Forms.TextBox()
        Me.DGrid1 = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmdView = New System.Windows.Forms.Button()
        Me.cmdNext = New System.Windows.Forms.Button()
        Me.txtMonthlyIncome = New System.Windows.Forms.TextBox()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        CType(Me.DGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(3, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(498, 38)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter Name of Applicant to Search For:"
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtSearch.Location = New System.Drawing.Point(3, 73)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(478, 45)
        Me.txtSearch.TabIndex = 1
        '
        'cmdSearch
        '
        Me.cmdSearch.BackColor = System.Drawing.Color.Red
        Me.cmdSearch.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cmdSearch.Location = New System.Drawing.Point(3, 140)
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(165, 55)
        Me.cmdSearch.TabIndex = 2
        Me.cmdSearch.Text = "&Search"
        Me.cmdSearch.UseVisualStyleBackColor = False
        '
        'txtFName
        '
        Me.txtFName.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtFName.Location = New System.Drawing.Point(3, 237)
        Me.txtFName.Name = "txtFName"
        Me.txtFName.Size = New System.Drawing.Size(287, 45)
        Me.txtFName.TabIndex = 10
        '
        'txtASacco
        '
        Me.txtASacco.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtASacco.Location = New System.Drawing.Point(3, 316)
        Me.txtASacco.Name = "txtASacco"
        Me.txtASacco.Size = New System.Drawing.Size(287, 45)
        Me.txtASacco.TabIndex = 11
        '
        'txtContribution
        '
        Me.txtContribution.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtContribution.Location = New System.Drawing.Point(3, 381)
        Me.txtContribution.Name = "txtContribution"
        Me.txtContribution.Size = New System.Drawing.Size(287, 45)
        Me.txtContribution.TabIndex = 12
        '
        'DGrid1
        '
        Me.DGrid1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGrid1.Location = New System.Drawing.Point(348, 155)
        Me.DGrid1.Name = "DGrid1"
        Me.DGrid1.RowHeadersWidth = 62
        Me.DGrid1.RowTemplate.Height = 33
        Me.DGrid1.Size = New System.Drawing.Size(1008, 435)
        Me.DGrid1.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(507, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(559, 38)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Click Button Below to Check Applicant Table"
        '
        'cmdView
        '
        Me.cmdView.BackColor = System.Drawing.Color.Red
        Me.cmdView.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cmdView.Location = New System.Drawing.Point(517, 94)
        Me.cmdView.Name = "cmdView"
        Me.cmdView.Size = New System.Drawing.Size(165, 55)
        Me.cmdView.TabIndex = 3
        Me.cmdView.Text = "&View Table"
        Me.cmdView.UseVisualStyleBackColor = False
        '
        'cmdNext
        '
        Me.cmdNext.BackColor = System.Drawing.Color.Red
        Me.cmdNext.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cmdNext.Location = New System.Drawing.Point(3, 521)
        Me.cmdNext.Name = "cmdNext"
        Me.cmdNext.Size = New System.Drawing.Size(217, 55)
        Me.cmdNext.TabIndex = 4
        Me.cmdNext.Text = "&To Next Form"
        Me.cmdNext.UseVisualStyleBackColor = False
        '
        'txtMonthlyIncome
        '
        Me.txtMonthlyIncome.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtMonthlyIncome.Location = New System.Drawing.Point(3, 454)
        Me.txtMonthlyIncome.Name = "txtMonthlyIncome"
        Me.txtMonthlyIncome.Size = New System.Drawing.Size(287, 45)
        Me.txtMonthlyIncome.TabIndex = 15
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(1506, 657)
        Me.Controls.Add(Me.txtMonthlyIncome)
        Me.Controls.Add(Me.cmdNext)
        Me.Controls.Add(Me.cmdView)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DGrid1)
        Me.Controls.Add(Me.txtContribution)
        Me.Controls.Add(Me.txtASacco)
        Me.Controls.Add(Me.txtFName)
        Me.Controls.Add(Me.cmdSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Cross-Checking Applicants' Validity For A Loan"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents cmdSearch As Button
    Friend WithEvents DGrid1 As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents cmdView As Button
    Friend WithEvents cmdNext As Button
    Public WithEvents txtFName As TextBox
    Friend WithEvents txtContribution As TextBox
    Friend WithEvents txtMonthlyIncome As TextBox
    Friend WithEvents txtASacco As TextBox
    Friend WithEvents ColorDialog1 As ColorDialog
End Class
