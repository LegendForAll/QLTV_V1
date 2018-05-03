<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_AddReader
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.tbx_ID_Reader = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.dtp_DateBrith = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.cbx_TypeReader = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.tbx_name_Reader = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.tbx_Address = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.dtp_CardDate = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.tbx_Email = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btn_Enter = New System.Windows.Forms.Button()
        Me.btn_EnterClose = New System.Windows.Forms.Button()
        Me.tbx_name_Employee = New System.Windows.Forms.TextBox()
        Me.cbx_Text = New System.Windows.Forms.ComboBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.tbx_ID_Reader)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(11, 11)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(332, 52)
        Me.Panel1.TabIndex = 0
        '
        'tbx_ID_Reader
        '
        Me.tbx_ID_Reader.Location = New System.Drawing.Point(86, 17)
        Me.tbx_ID_Reader.Name = "tbx_ID_Reader"
        Me.tbx_ID_Reader.ReadOnly = True
        Me.tbx_ID_Reader.Size = New System.Drawing.Size(228, 20)
        Me.tbx_ID_Reader.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID Reader:"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Location = New System.Drawing.Point(1, 1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(359, 253)
        Me.Panel2.TabIndex = 1
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.dtp_DateBrith)
        Me.Panel5.Controls.Add(Me.Label4)
        Me.Panel5.Location = New System.Drawing.Point(11, 185)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(332, 52)
        Me.Panel5.TabIndex = 3
        '
        'dtp_DateBrith
        '
        Me.dtp_DateBrith.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_DateBrith.Location = New System.Drawing.Point(114, 14)
        Me.dtp_DateBrith.Name = "dtp_DateBrith"
        Me.dtp_DateBrith.Size = New System.Drawing.Size(200, 20)
        Me.dtp_DateBrith.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Brithday:"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.cbx_TypeReader)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Location = New System.Drawing.Point(11, 127)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(332, 52)
        Me.Panel4.TabIndex = 2
        '
        'cbx_TypeReader
        '
        Me.cbx_TypeReader.FormattingEnabled = True
        Me.cbx_TypeReader.Location = New System.Drawing.Point(193, 17)
        Me.cbx_TypeReader.Name = "cbx_TypeReader"
        Me.cbx_TypeReader.Size = New System.Drawing.Size(121, 21)
        Me.cbx_TypeReader.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Type of reader:"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.tbx_name_Reader)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Location = New System.Drawing.Point(11, 69)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(332, 52)
        Me.Panel3.TabIndex = 1
        '
        'tbx_name_Reader
        '
        Me.tbx_name_Reader.Location = New System.Drawing.Point(86, 17)
        Me.tbx_name_Reader.Name = "tbx_name_Reader"
        Me.tbx_name_Reader.Size = New System.Drawing.Size(228, 20)
        Me.tbx_name_Reader.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Reader name:"
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.tbx_Address)
        Me.Panel6.Controls.Add(Me.Label5)
        Me.Panel6.Location = New System.Drawing.Point(13, 11)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(332, 52)
        Me.Panel6.TabIndex = 4
        '
        'tbx_Address
        '
        Me.tbx_Address.Location = New System.Drawing.Point(86, 17)
        Me.tbx_Address.Name = "tbx_Address"
        Me.tbx_Address.Size = New System.Drawing.Size(228, 20)
        Me.tbx_Address.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Address:"
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.Panel6)
        Me.Panel7.Controls.Add(Me.Panel9)
        Me.Panel7.Controls.Add(Me.Panel10)
        Me.Panel7.Controls.Add(Me.Panel12)
        Me.Panel7.Location = New System.Drawing.Point(366, 1)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(359, 253)
        Me.Panel7.TabIndex = 5
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.dtp_CardDate)
        Me.Panel9.Controls.Add(Me.Label7)
        Me.Panel9.Location = New System.Drawing.Point(13, 185)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(332, 52)
        Me.Panel9.TabIndex = 3
        '
        'dtp_CardDate
        '
        Me.dtp_CardDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_CardDate.Location = New System.Drawing.Point(114, 14)
        Me.dtp_CardDate.Name = "dtp_CardDate"
        Me.dtp_CardDate.Size = New System.Drawing.Size(200, 20)
        Me.dtp_CardDate.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Card date:"
        '
        'Panel10
        '
        Me.Panel10.Controls.Add(Me.tbx_name_Employee)
        Me.Panel10.Controls.Add(Me.Label8)
        Me.Panel10.Location = New System.Drawing.Point(13, 127)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(332, 52)
        Me.Panel10.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 20)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(119, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Employees make cards:"
        '
        'Panel12
        '
        Me.Panel12.Controls.Add(Me.tbx_Email)
        Me.Panel12.Controls.Add(Me.Label10)
        Me.Panel12.Location = New System.Drawing.Point(13, 69)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(332, 52)
        Me.Panel12.TabIndex = 0
        '
        'tbx_Email
        '
        Me.tbx_Email.Location = New System.Drawing.Point(86, 17)
        Me.tbx_Email.Name = "tbx_Email"
        Me.tbx_Email.Size = New System.Drawing.Size(228, 20)
        Me.tbx_Email.TabIndex = 2
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(3, 20)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(35, 13)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Email:"
        '
        'btn_Enter
        '
        Me.btn_Enter.Location = New System.Drawing.Point(476, 273)
        Me.btn_Enter.Name = "btn_Enter"
        Me.btn_Enter.Size = New System.Drawing.Size(75, 23)
        Me.btn_Enter.TabIndex = 6
        Me.btn_Enter.Text = "Enter"
        Me.btn_Enter.UseVisualStyleBackColor = True
        '
        'btn_EnterClose
        '
        Me.btn_EnterClose.Location = New System.Drawing.Point(572, 273)
        Me.btn_EnterClose.Name = "btn_EnterClose"
        Me.btn_EnterClose.Size = New System.Drawing.Size(121, 23)
        Me.btn_EnterClose.TabIndex = 7
        Me.btn_EnterClose.Text = "Enter and Close"
        Me.btn_EnterClose.UseVisualStyleBackColor = True
        '
        'tbx_name_Employee
        '
        Me.tbx_name_Employee.Location = New System.Drawing.Point(128, 16)
        Me.tbx_name_Employee.Name = "tbx_name_Employee"
        Me.tbx_name_Employee.Size = New System.Drawing.Size(186, 20)
        Me.tbx_name_Employee.TabIndex = 3
        '
        'cbx_Text
        '
        Me.cbx_Text.FormattingEnabled = True
        Me.cbx_Text.Location = New System.Drawing.Point(144, 260)
        Me.cbx_Text.Name = "cbx_Text"
        Me.cbx_Text.Size = New System.Drawing.Size(182, 21)
        Me.cbx_Text.TabIndex = 8
        '
        'Frm_AddReader
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(728, 308)
        Me.Controls.Add(Me.cbx_Text)
        Me.Controls.Add(Me.btn_EnterClose)
        Me.Controls.Add(Me.btn_Enter)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "Frm_AddReader"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_AddReader"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        Me.Panel12.ResumeLayout(False)
        Me.Panel12.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents tbx_ID_Reader As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents tbx_name_Reader As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents dtp_DateBrith As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents cbx_TypeReader As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents tbx_Address As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents dtp_CardDate As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel12 As Panel
    Friend WithEvents tbx_Email As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents btn_Enter As Button
    Friend WithEvents btn_EnterClose As Button
    Friend WithEvents tbx_name_Employee As TextBox
    Friend WithEvents cbx_Text As ComboBox
End Class
