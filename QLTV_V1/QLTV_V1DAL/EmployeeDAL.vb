Imports System.Configuration
Imports System.Data.SqlClient
Imports QLTV_V1DTO
Imports Utility

Public Class EmployeeDAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

    Public Function buildIDStudent(ByRef nextID As String) As Result
        nextID = String.Empty
        Dim y = DateTime.Now.Year
        Dim x = y.ToString().Substring(2)
        nextID = x + "000000"


        Dim query As String = String.Empty
        query &= "Select TOP 1 [Id_Employee] "
        query &= "From [tbl_Employee] "
        query &= "Order By [Id_Employee] DESC "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    Dim msOnDB As String
                    msOnDB = Nothing
                    If reader.HasRows = True Then
                        While reader.Read()
                            msOnDB = reader("Id_Employee")
                        End While
                    End If
                    If (msOnDB <> Nothing And msOnDB.Length >= 8) Then
                        Dim currentYear = DateTime.Now.Year.ToString().Substring(2)
                        Dim iCurrentYear = Integer.Parse(currentYear)
                        Dim currentYearOnDB = msOnDB.Substring(0, 2)
                        Dim icurrentYearOnDB = Integer.Parse(currentYearOnDB)
                        Dim year = iCurrentYear
                        If (year < icurrentYearOnDB) Then
                            year = icurrentYearOnDB
                        End If
                        nextID = year.ToString()
                        Dim v = msOnDB.Substring(2)
                        Dim convertDecimal = Convert.ToDecimal(v)
                        convertDecimal = convertDecimal + 1
                        Dim tmp = convertDecimal.ToString()
                        tmp = tmp.PadLeft(msOnDB.Length - 2, "0")
                        nextID = nextID + tmp
                        System.Console.WriteLine(nextID)
                    End If

                Catch ex As Exception
                    conn.Close() ' that bai!!!
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Automatically retrieves the next Student Number without success", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function insert(nv As EmployeeDTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [tbl_Employee] ([Id_Employee], [Name_Employee], [Address], [Birthday])"
        'sai fix
        query &= "VALUES (@Id_Employee,@Name_Employee,@Address,@Birthday)"

        'get MSHS
        Dim nextID = "1"
        buildIDStudent(nextID)
        nv.Id_Employee = nextID

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@Id_Employee", nv.Id_Employee)
                    .Parameters.AddWithValue("@Name_Employee", nv.Name_Employee)
                    .Parameters.AddWithValue("@Address", nv.Address)
                    .Parameters.AddWithValue("@Birthday", nv.DateTime_Brith)

                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Add Student unsuccessful", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function selectALL(ByRef listStudent As List(Of EmployeeDTO)) As Result

        Dim query As String = String.Empty
        query &= "SELECT [Id_Employee], [Name_Employee],[Address],[Birthday]"
        query &= "FROM [tbl_Employee]"


        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listStudent.Clear()
                        While reader.Read()
                            listStudent.Add(New EmployeeDTO(reader("Id_Employee"), reader("Name_Employee"), reader("Address"), reader("DateTime_Brith")))
                        End While
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Takes all Students unsuccessful", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function



    Public Function update(nv As EmployeeDTO) As Result

        Dim query As String = String.Empty
        query &= " UPDATE [tbl_Employee] SET"
        query &= " ,[Name_Employee] = @Name_Employee "
        query &= " ,[Address] = @Address "
        query &= " ,[Birthday] = @Birthday "
        query &= " WHERE "
        query &= " [Id_Employee] = @Id_Employee "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@Name_Employee", nv.Name_Employee)
                    .Parameters.AddWithValue("@Address", nv.Address)
                    .Parameters.AddWithValue("@Birthday", nv.DateTime_Brith)
                    .Parameters.AddWithValue("@Id_Employee", nv.Id_Employee)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Update Students fail", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function delete(maNhanVien As String) As Result

        Dim query As String = String.Empty
        query &= " DELETE FROM [tbl_Employee] "
        query &= " WHERE "
        query &= " [Id_Employee] = @Id_Employee "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@id_Student", maNhanVien)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Delete Student failed", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)  ' thanh cong
    End Function
End Class
