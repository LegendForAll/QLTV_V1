Imports System.Configuration
Imports System.Data.SqlClient
Imports QLTV_V1DTO
Imports Utility

Public Class ReaderDAL
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
        query &= "Select TOP 1 [Id_Readers] "
        query &= "From [tbl_Readers] "
        query &= "Order By [Id_Readers] DESC "

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
                            msOnDB = reader("Id_Readers")
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
    Public Function insert(dg As ReaderDTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [tbl_Readers] ([Id_Readers], [Id_typeReaders], [Name_Readers], [Address], [Birthday],[Email],[Card_Date],[Id_Employee])"
        'sai fix
        query &= "VALUES (@Id_Readers,@Id_typeReaders,@Name_Readers,@Address,@Birthday,@Email,@Card_Date,@Id_Employee)"

        'get MSHS
        Dim nextID = "1"
        buildIDStudent(nextID)
        dg.Id_Reader = nextID

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@Id_Readers", dg.Id_Reader)
                    .Parameters.AddWithValue("@Id_typeReaders", dg.Type_Reader)
                    .Parameters.AddWithValue("@Name_Readers", dg.Reader_Name)
                    .Parameters.AddWithValue("@Address", dg.Address)
                    .Parameters.AddWithValue("@Birthday", dg.DateTime_Brith)
                    'them Email/Card date/ID Employee
                    .Parameters.AddWithValue("@Email", dg.Email)
                    .Parameters.AddWithValue("@Card_Date", dg.DateTime_Card)
                    .Parameters.AddWithValue("@Id_Employee", dg.Employee)
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

    Public Function selectALL(ByRef listStudent As List(Of ReaderDTO)) As Result

        Dim query As String = String.Empty
        query &= "SELECT [Id_Readers], [Id_typeReaders], [Name_Readers], [Address], [Birthday],[Email],[Card_Date],[Id_Employee]"
        query &= "FROM [tbl_Readers]"


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
                            listStudent.Add(New ReaderDTO(reader("Id_Reader"), reader("Type_Reader"), reader("Reader_Name"), reader("Address"), reader("DateTime_Brith"), reader("Email"), reader("DateTime_Card"), reader("Employee")))
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



    Public Function selectALL_ByType(maLoai As Integer, ByRef listHocSinh As List(Of ReaderDTO)) As Result

        Dim query As String = String.Empty
        query &= "SELECT [Id_Readers], [Id_typeReaders], [Name_Readers], [Address], [Birthday],[Email],[Card_Date],[Id_Employee] "
        query &= "FROM [tbl_Readers] "
        query &= "WHERE [Id_typeReaders] = @Id_typeReaders "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@Id_typeReaders", maLoai)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listHocSinh.Clear()
                        While reader.Read()
                            listHocSinh.Add(New ReaderDTO(reader("Id_Reader"), reader("Type_Reader"), reader("Reader_Name"), reader("Address"), reader("DateTime_Brith"), reader("Email"), reader("DateTime_Card"), reader("Employee")))
                        End While
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Taking all students by gender failed", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function update(dg As ReaderDTO) As Result

        Dim query As String = String.Empty
        query &= " UPDATE [tbl_Readers] SET"
        query &= " [Id_typeReaders] = @Id_typeReaders "
        query &= " ,[Name_Readers] = @Name_Readers "
        query &= " ,[Address] = @Address "
        query &= " ,[Birthday] = @Birthday "
        query &= " ,[Email] = @Email "
        query &= " ,[Card_Date] = @Card_Date "
        query &= " ,[Id_Employee] = @Id_Employee "
        query &= " WHERE "
        query &= " [Id_Readers] = @Id_Readers "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@Id_Readers", dg.Id_Reader)
                    .Parameters.AddWithValue("@Id_typeReaders", dg.Type_Reader)
                    .Parameters.AddWithValue("@Name_Readers", dg.Reader_Name)
                    .Parameters.AddWithValue("@Address", dg.Address)
                    .Parameters.AddWithValue("@Birthday", dg.DateTime_Brith)
                    'them Email/Card date/ID Employee
                    .Parameters.AddWithValue("@Email", dg.Email)
                    .Parameters.AddWithValue("@Card_Date", dg.DateTime_Card)
                    .Parameters.AddWithValue("@Id_Employee", dg.Employee)
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

    Public Function delete(maDocGia As String) As Result

        Dim query As String = String.Empty
        query &= " DELETE FROM [tbl_Readers] "
        query &= " WHERE "
        query &= " [Id_Readers] = @Id_Readers "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@Id_Readers", maDocGia)
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
