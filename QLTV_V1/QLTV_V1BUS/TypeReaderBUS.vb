Imports QLTV_V1DAL
Imports QLTV_V1DTO
Imports Utility

Public Class TypeReaderBUS
    Private lhsDAL As TypeReaderDAL
    Public Sub New()
        lhsDAL = New TypeReaderDAL()
    End Sub
    Public Sub New(connectionString As String)
        lhsDAL = New TypeReaderDAL(connectionString)
    End Sub
    Public Function isValidName(lhs As TypeReaderDTO) As Boolean

        If (lhs.Name_TypeReader.Length < 1) Then
            Return False
        End If

        Return True

    End Function

    Public Function insert(lhs As TypeReaderDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return lhsDAL.insert(lhs)
    End Function
    Public Function update(lhs As TypeReaderDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return lhsDAL.update(lhs)
    End Function
    Public Function delete(maLoai As Integer) As Result
        '1. verify data here!!

        '2. insert to DB
        Return lhsDAL.delete(maLoai)
    End Function
    Public Function selectAll(ByRef listLoaiHS As List(Of TypeReaderDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return lhsDAL.selectALL(listLoaiHS)
    End Function
    Public Function getNextID(ByRef nextID As Integer) As Result
        Return lhsDAL.getNextID(nextID)
    End Function
End Class
