Public Class ReaderDTO
    Private str_Id_Reader As String
    Private i_Type_Reader As Integer
    Private str_Name_Reader As String
    Private str_Address As String
    Private str_Email As String
    Private day_Brithday As DateTime
    Private day_DateCard As DateTime
    Private str_Employee As String

    Public Sub New()

    End Sub

    Public Sub New(str_Id_Reader As String, i_Type_Reader As Integer, str_Name_Reader As String, str_Address As String, str_Email As String, day_Brithday As DateTime, day_DateCard As DateTime, str_Employee As String)
        Me.str_Id_Reader = str_Id_Reader
        Me.i_Type_Reader = i_Type_Reader
        Me.str_Name_Reader = str_Name_Reader
        Me.str_Address = str_Address
        Me.str_Email = str_Email
        Me.day_Brithday = day_Brithday
        Me.day_DateCard = day_DateCard
        Me.str_Employee = str_Employee
    End Sub

    Property Id_Reader() As String
        Get
            Return str_Id_Reader
        End Get
        Set(ByVal Value As String)
            str_Id_Reader = Value
        End Set
    End Property

    Property Type_Reader() As Integer
        Get
            Return i_Type_Reader
        End Get
        Set(ByVal Value As Integer)
            i_Type_Reader = Value
        End Set
    End Property

    Property Reader_Name() As String
        Get
            Return str_Name_Reader
        End Get
        Set(ByVal Value As String)
            str_Name_Reader = Value
        End Set
    End Property

    Property Address() As String
        Get
            Return str_Address
        End Get
        Set(ByVal Value As String)
            str_Address = Value
        End Set
    End Property

    Property Email() As String
        Get
            Return str_Email
        End Get
        Set(ByVal Value As String)
            str_Email = Value
        End Set
    End Property

    Property DateTime_Brith() As DateTime
        Get
            Return day_Brithday
        End Get
        Set(ByVal Value As DateTime)
            day_Brithday = Value
        End Set
    End Property

    Property DateTime_Card() As DateTime
        Get
            Return day_DateCard
        End Get
        Set(ByVal Value As DateTime)
            day_DateCard = Value
        End Set
    End Property

    Property Employee() As String
        Get
            Return str_Employee
        End Get
        Set(ByVal Value As String)
            str_Employee = Value
        End Set
    End Property
End Class
