Public Class TextDTO
    Private i_Id As Integer
    Private str_Name As String

    Public Sub New()

    End Sub

    Public Sub New(i_Id As Integer, str_Name As String)
        Me.i_Id = i_Id
        Me.str_Name = str_Name
    End Sub

    Property Id() As Integer
        Get
            Return i_Id
        End Get
        Set(value As Integer)
            i_Id = value
        End Set
    End Property
    Property Name() As String
        Get
            Return str_Name
        End Get
        Set(value As String)
            str_Name = value
        End Set
    End Property
End Class
