Imports QLTV_V1DAL
Imports QLTV_V1DTO
Imports Utility

Public Class ReaderBUS
    Private dgDAL As ReaderDAL
    Public Sub New()
        dgDAL = New ReaderDAL()
    End Sub
    Public Sub New(connectionString As String)
        dgDAL = New ReaderDAL(connectionString)
    End Sub

    Public Function isValidName(hs As ReaderDTO) As Boolean

        If (hs.Reader_Name.Length < 1) Then
            Return False
        End If

        Return True
    End Function

    Public Function insert(hs As ReaderDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return dgDAL.insert(hs)
    End Function

    Public Function update(hs As ReaderDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return dgDAL.update(hs)
    End Function

    Public Function delete(maLoai As Integer) As Result
        '1. verify data here!!

        '2. insert to DB
        Return dgDAL.delete(maLoai)
    End Function

    Public Function selectAll(ByRef listLoaiHS As List(Of ReaderDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return dgDAL.selectALL(listLoaiHS)
    End Function

    Public Function selectALL_ByType(maLoai As Integer, ByRef listHS As List(Of ReaderDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return dgDAL.selectALL_ByType(maLoai, listHS)
    End Function

    Public Function buildMSHS(ByRef nextMshs As Integer) As Result
        Return dgDAL.buildIDStudent(nextMshs)
    End Function
End Class
