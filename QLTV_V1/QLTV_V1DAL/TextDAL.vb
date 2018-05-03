Imports System.Configuration
Imports System.Data.SqlClient
Imports QLTV_V1DTO
Imports Utility
Public Class TextDAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub
    Public Function selectALL(ByRef listStudent As List(Of TextDTO)) As Result

        Dim query As String = String.Empty
        query &= "SELECT [id], [Name]"
        query &= "FROM [Table_1]"


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
                            listStudent.Add(New TextDTO(reader("Id"), reader("Name")))
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
End Class
