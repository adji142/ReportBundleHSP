Imports Dapper

Namespace HSP.Data
    Public Class Dept
        Public Property KodeDept As String
        Public Property NamaDept As String
    End Class

    Public Class Bagian
        Public Property KodeBag As String
        Public Property NamaBag As String
        Public Property KodeDept As String
    End Class

    Public Class Posisi
        Public Property KodePosisi As String
        Public Property NamaPosisi As String
        Public Property KodeBag As String
    End Class

    Public Class MasterHR
        Private _DBConnection As DBConnection

        Sub New(ByVal Session As Object)
            _DBConnection = New DBConnection(Session)
        End Sub

        Public Function AddDept(ByVal Data As Dept) As Integer
            Dim SQL As String

            SQL = "INSERT INTO tdepartemen " +
                  "(KodeDept, NamaDept) " +
                  "VALUES " +
                  "(@KodeDept, @NamaDept)"

            Using DBX As IDbConnection = _DBConnection.Connection
                AddDept = DBX.Execute(SQL, Data)
            End Using
        End Function

        Public Function DelDept(ByVal ID As String) As Integer
            Dim SQL As String

            SQL = "DELETE FROM tdepartemen"

            Using DBX As IDbConnection = _DBConnection.Connection
                DelDept = DBX.Execute(SQL)    'DBX.Execute(SQL, New With {.KodeAspek = ID})
            End Using
        End Function

        Public Function AddBagian(ByVal Data As Bagian) As Integer
            Dim SQL As String

            SQL = "INSERT INTO tBagian " +
                  "(KodeBag, NamaBag, KodeDept) " +
                  "VALUES " +
                  "(@KodeBag, @NamaBag, @KodeDept)"

            Using DBX As IDbConnection = _DBConnection.Connection
                AddBagian = DBX.Execute(SQL, Data)
            End Using
        End Function

        Public Function DelBagian(ByVal ID As String) As Integer
            Dim SQL As String

            SQL = "DELETE FROM tbagian"

            Using DBX As IDbConnection = _DBConnection.Connection
                DelBagian = DBX.Execute(SQL)    'DBX.Execute(SQL, New With {.KodeAspek = ID})
            End Using
        End Function

        Public Function AddPosisi(ByVal Data As Posisi) As Integer
            Dim SQL As String

            SQL = "INSERT INTO tposisi " +
                  "(KodePosisi, NamaPosisi, KodeBag) " +
                  "VALUES " +
                  "(@KodePosisi, @NamaPosisi, @KodeBag)"

            Using DBX As IDbConnection = _DBConnection.Connection
                AddPosisi = DBX.Execute(SQL, Data)
            End Using
        End Function

        Public Function DelPosisi(ByVal ID As String) As Integer
            Dim SQL As String

            SQL = "DELETE FROM tposisi"

            Using DBX As IDbConnection = _DBConnection.Connection
                DelPosisi = DBX.Execute(SQL)
            End Using
        End Function
    End Class
End Namespace

