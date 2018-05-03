Imports QLTV_V1DAL
Imports QLTV_V1DTO
Imports Utility

Public Class EmployeeBUS
    Private nvDAL As EmployeeDAL
    Public Sub New()
        nvDAL = New EmployeeDAL()
    End Sub
    Public Sub New(connectionString As String)
        nvDAL = New EmployeeDAL(connectionString)
    End Sub

    Public Function isValidName(nv As EmployeeDTO) As Boolean

        If (nv.Name_Employee.Length < 1) Then
            Return False
        End If

        Return True
    End Function

    Public Function insert(nv As EmployeeDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return nvDAL.insert(nv)
    End Function

    Public Function update(nv As EmployeeDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return nvDAL.update(nv)
    End Function

    Public Function delete(maLoai As Integer) As Result
        '1. verify data here!!

        '2. insert to DB
        Return nvDAL.delete(maLoai)
    End Function

    Public Function selectAll(ByRef listLoaiHS As List(Of EmployeeDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return nvDAL.selectALL(listLoaiHS)
    End Function


    Public Function buildMSHS(ByRef nextMshs As Integer) As Result
        Return nvDAL.buildIDStudent(nextMshs)
    End Function
End Class
