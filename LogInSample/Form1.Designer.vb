<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.FirstName = New System.Windows.Forms.Label()
        Me.SecondName = New System.Windows.Forms.Label()
        Me.EmailID = New System.Windows.Forms.Label()
        Me.MobileNo = New System.Windows.Forms.Label()
        Me.RegistrationForm = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Submit = New System.Windows.Forms.Button()
        Me.LoadData = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GenerateReport = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FirstName
        '
        Me.FirstName.AutoSize = True
        Me.FirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FirstName.Location = New System.Drawing.Point(172, 110)
        Me.FirstName.Name = "FirstName"
        Me.FirstName.Size = New System.Drawing.Size(106, 25)
        Me.FirstName.TabIndex = 0
        Me.FirstName.Text = "First Name"
        '
        'SecondName
        '
        Me.SecondName.AutoSize = True
        Me.SecondName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SecondName.Location = New System.Drawing.Point(172, 153)
        Me.SecondName.Name = "SecondName"
        Me.SecondName.Size = New System.Drawing.Size(137, 25)
        Me.SecondName.TabIndex = 1
        Me.SecondName.Text = "Second Name"
        Me.SecondName.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'EmailID
        '
        Me.EmailID.AutoSize = True
        Me.EmailID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailID.Location = New System.Drawing.Point(172, 194)
        Me.EmailID.Name = "EmailID"
        Me.EmailID.Size = New System.Drawing.Size(81, 25)
        Me.EmailID.TabIndex = 2
        Me.EmailID.Text = "Email Id"
        '
        'MobileNo
        '
        Me.MobileNo.AutoSize = True
        Me.MobileNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MobileNo.Location = New System.Drawing.Point(172, 234)
        Me.MobileNo.Name = "MobileNo"
        Me.MobileNo.Size = New System.Drawing.Size(105, 25)
        Me.MobileNo.TabIndex = 3
        Me.MobileNo.Text = "Mobile No."
        '
        'RegistrationForm
        '
        Me.RegistrationForm.AutoSize = True
        Me.RegistrationForm.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RegistrationForm.Location = New System.Drawing.Point(140, 34)
        Me.RegistrationForm.Name = "RegistrationForm"
        Me.RegistrationForm.Size = New System.Drawing.Size(313, 42)
        Me.RegistrationForm.TabIndex = 4
        Me.RegistrationForm.Text = "Registration Form"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(354, 110)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(184, 30)
        Me.TextBox1.TabIndex = 5
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(354, 234)
        Me.TextBox4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(184, 30)
        Me.TextBox4.TabIndex = 6
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(354, 194)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(184, 30)
        Me.TextBox3.TabIndex = 7
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(354, 153)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(184, 30)
        Me.TextBox2.TabIndex = 8
        '
        'Submit
        '
        Me.Submit.Location = New System.Drawing.Point(285, 314)
        Me.Submit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Submit.Name = "Submit"
        Me.Submit.Size = New System.Drawing.Size(104, 34)
        Me.Submit.TabIndex = 9
        Me.Submit.Text = "Submit"
        Me.Submit.UseVisualStyleBackColor = True
        '
        'LoadData
        '
        Me.LoadData.AutoEllipsis = True
        Me.LoadData.Location = New System.Drawing.Point(660, 314)
        Me.LoadData.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LoadData.Name = "LoadData"
        Me.LoadData.Size = New System.Drawing.Size(122, 34)
        Me.LoadData.TabIndex = 10
        Me.LoadData.Text = "Load Data"
        Me.LoadData.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(583, 58)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(442, 230)
        Me.DataGridView1.TabIndex = 11
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(477, 314)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(118, 34)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Delete"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(463, 412)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(247, 38)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Move To Next Form"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GenerateReport
        '
        Me.GenerateReport.Location = New System.Drawing.Point(192, 412)
        Me.GenerateReport.Name = "GenerateReport"
        Me.GenerateReport.Size = New System.Drawing.Size(177, 38)
        Me.GenerateReport.TabIndex = 14
        Me.GenerateReport.Text = "Generate Report"
        Me.GenerateReport.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(733, 412)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(171, 38)
        Me.Button3.TabIndex = 15
        Me.Button3.Text = "Convert to postcode"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Aqua
        Me.ClientSize = New System.Drawing.Size(1051, 515)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.GenerateReport)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.LoadData)
        Me.Controls.Add(Me.Submit)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.RegistrationForm)
        Me.Controls.Add(Me.MobileNo)
        Me.Controls.Add(Me.EmailID)
        Me.Controls.Add(Me.SecondName)
        Me.Controls.Add(Me.FirstName)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form1"
        Me.Text = "Registration Form"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FirstName As Label
    Friend WithEvents SecondName As Label
    Friend WithEvents EmailID As Label
    Friend WithEvents MobileNo As Label
    Friend WithEvents RegistrationForm As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Submit As Button
    Friend WithEvents LoadData As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents GenerateReport As Button
    Friend WithEvents Button3 As Button
End Class
