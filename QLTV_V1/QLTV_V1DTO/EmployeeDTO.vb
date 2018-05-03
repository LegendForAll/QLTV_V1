Public Class EmployeeDTO
    Private str_Id_Employee As String
    Private str_Name_Employee As String
    Private day_Brithday As DateTime
    Private str_Address As String

    Public Sub New()

    End Sub

    Public Sub New(str_Id_Employee As String, str_Name_Employee As String, day_Brithday As DateTime, str_Address As String)
        Me.str_Id_Employee = str_Id_Employee
        Me.str_Name_Employee = str_Name_Employee
        Me.day_Brithday = day_Brithday
        Me.str_Address = day_Brithday

    End Sub

    Property Id_Employee() As String
        Get
            Return str_Id_Employee
        End Get
        Set(value As String)
            str_Id_Employee = value
        End Set
    End Property

    Property Name_Employee() As String
        Get
            Return str_Name_Employee
        End Get
        Set(value As String)
            str_Name_Employee = value
        End Set
    End Property

    Property DateTime_Brith() As DateTime
        Get
            Return day_Brithday
        End Get
        Set(value As DateTime)
            day_Brithday = value
        End Set
    End Property

    Property Address() As String
        Get
            Return str_Address
        End Get
        Set(value As String)
            str_Address = value
        End Set
    End Property
End Class
