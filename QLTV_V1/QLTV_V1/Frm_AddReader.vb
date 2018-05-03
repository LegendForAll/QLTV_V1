Imports QLTV_V1BUS
Imports QLTV_V1DTO
Imports Utility

Public Class Frm_AddReader
    Private DGBus As ReaderBUS
    Private lhsBus As TypeReaderBUS
    Private lnvBus As EmployeeBUS
    Private textBus As TextBUS

    Private Sub Frm_AddReader_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGBus = New ReaderBUS()
        lhsBus = New TypeReaderBUS()
        textBus = New TextBUS()

        ''lnvBus = New EmployeeBUS()
        'Load Loai doc gia list
        'Dim listLoaiDocGia = New List(Of TypeReaderDTO)
        'Dim result As Result
        'result = lhsBus.selectAll(listLoaiDocGia)
        'If (result.FlagResult = False) Then
        '    MessageBox.Show("Get the autocomplete code Reader failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    System.Console.WriteLine(result.SystemMessage)
        '    Me.Close()
        '    Return
        'End If
        'cbx_TypeReader.DataSource = New BindingSource(listLoaiDocGia, String.Empty)
        'cbx_TypeReader.DisplayMember = "Name_TypeReader"
        'cbx_TypeReader.ValueMember = "Id_TypeReader"
        'Text
        'Dim myCurrencyManager As CurrencyManager = Me.BindingContext(cbx_TypeReader.DataSource)
        'myCurrencyManager.Refresh()
        'If (listLoaiDocGia.Count > 0) Then
        '    cbx_TypeReader.SelectedIndex = 0
        'End If
        '' Load Nhan vien list
        'Dim listNhanVien = New List(Of EmployeeDTO)
        'result = lnvBus.selectAll(listNhanVien)
        'If (result.FlagResult = False) Then
        '    MessageBox.Show("Get the autocomplete code Employee failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    System.Console.WriteLine(result.SystemMessage)
        '    Me.Close()
        '    Return
        'End If
        'cbx_Text.DataSource = New BindingSource(listNhanVien, String.Empty)
        'cbx_Text.DisplayMember = "Name_Employee"
        'cbx_Text.ValueMember = "Id_Employee"
        'myCurrencyManager = Me.BindingContext(cbx_Text.DataSource)
        'myCurrencyManager.Refresh()
        'If (listNhanVien.Count > 0) Then
        '    cbx_Text.SelectedIndex = 0
        'End If
        ' Load Nam Hoc list
        Dim listNamHoc = New List(Of TypeReaderDTO)
        Dim result As Result
        result = lhsBus.selectAll(listNamHoc)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách Năm Học không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If
        cbx_TypeReader.DataSource = New BindingSource(listNamHoc, String.Empty)
        cbx_TypeReader.DisplayMember = "Name_TypeReader"
        cbx_TypeReader.ValueMember = "Id_TypeReader"
        Dim myCurrencyManager As CurrencyManager = Me.BindingContext(cbx_TypeReader.DataSource)
        myCurrencyManager.Refresh()
        If (listNamHoc.Count > 0) Then
            cbx_TypeReader.SelectedIndex = 0
        End If

        ' Load Khoi list
        Dim listKhoi = New List(Of TextDTO)
        result = textBus.selectAll(listKhoi)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách Khối không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If
        cbx_Text.DataSource = New BindingSource(listKhoi, String.Empty)
        cbx_Text.DisplayMember = "Name"
        cbx_Text.ValueMember = "Id"
        myCurrencyManager = Me.BindingContext(cbx_Text.DataSource)
        myCurrencyManager.Refresh()
        If (listNamHoc.Count > 0) Then
            cbx_Text.SelectedIndex = 0
        End If
        'set MSSH auto
        Dim nextMshs = "1"
        result = DGBus.buildMSHS(nextMshs)
        If (result.FlagResult = False) Then
            MessageBox.Show("Get the autocomplete code student failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If
        tbx_ID_Reader.Text = nextMshs
    End Sub

    Private Sub btn_Enter_Click(sender As Object, e As EventArgs) Handles btn_Enter.Click
        Dim Reader As ReaderDTO
        Reader = New ReaderDTO()
        Dim Text_year As DateTime
        '1. Mapping data from GUI control
        Reader.Id_Reader = tbx_ID_Reader.Text
        Reader.Reader_Name = tbx_name_Reader.Text
        Reader.Address = tbx_Address.Text
        Reader.DateTime_Brith = dtp_DateBrith.Value
        Reader.Type_Reader = Convert.ToInt32(cbx_TypeReader.SelectedValue)
        Reader.Email = tbx_Email.Text
        Reader.DateTime_Card = dtp_CardDate.Value
        Reader.Employee = tbx_name_Employee.Text

        'kiem tra nam
        Text_year = dtp_DateBrith.Value

        '2. Business .....
        If (DGBus.isValidName(Reader) = False) Then
            MessageBox.Show("Student name is not correct")
            tbx_name_Reader.Focus()
            Return
        End If
        '3. Insert to DB
        Dim result As Result
        result = DGBus.insert(Reader)
        If (result.FlagResult = True And ((2018 - Text_year.Year) <= 55) And ((2018 - Text_year.Year) >= 18)) Then
            MessageBox.Show("Add Student Success.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'set MSSH auto
            Dim nextMshs = "1"
            result = DGBus.buildMSHS(nextMshs)
            If (result.FlagResult = False) Then
                MessageBox.Show("Get the autocomplete code student failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
                Return
            End If
            tbx_ID_Reader.Text = nextMshs
            tbx_Address.Text = String.Empty
            tbx_name_Reader.Text = String.Empty

        Else
            MessageBox.Show("Add Student unsuccessful.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub
End Class