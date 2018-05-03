Imports QLTV_V1DAL
Imports QLTV_V1DTO
Imports Utility

Public Class TextBUS
    Private lhsDAL As TextDAL
    Public Sub New()
        lhsDAL = New TextDAL()
    End Sub
    Public Sub New(connectionString As String)
        lhsDAL = New TextDAL(connectionString)
    End Sub
    Public Function isValidName(lhs As TextDTO) As Boolean

        If (lhs.Name.Length < 1) Then
            Return False
        End If

        Return True

    End Function



    Public Function selectAll(ByRef listLoaiHS As List(Of TextDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return lhsDAL.selectALL(listLoaiHS)
    End Function

End Class
