Public Class TypeReaderDTO
    Private i_Id_TypeReader As Integer
    Private str_Name_TypeReader As String

    Public Sub New()

    End Sub

    Public Sub New(i_Id_TypeReader As Integer, str_Name_TypeReader As String)
        Me.i_Id_TypeReader = i_Id_TypeReader
        Me.str_Name_TypeReader = str_Name_TypeReader
    End Sub

    Property Id_TypeReader() As Integer
        Get
            Return i_Id_TypeReader
        End Get
        Set(value As Integer)
            i_Id_TypeReader = value
        End Set
    End Property

    Property Name_TypeReader() As String
        Get
            Return str_Name_TypeReader
        End Get
        Set(value As String)
            str_Name_TypeReader = value
        End Set
    End Property
End Class
