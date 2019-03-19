Imports Dapper
Namespace HSP.Data
    Public Class KryUpdate
        Public Property userid As String
        Public Property karyawanid As Integer
    End Class
    Public Class UserKaryawan : Implements IDataLookup
        Private _DBConnection As DBConnection
        Public Enum enumLookupKaryawan
            DaftarKaryawan = 1
        End Enum

        Sub New(ByVal Session As Object)
            _DBConnection = New DBConnection(Session)
        End Sub
        Public Function AddUser(ByVal Data As KryUpdate) As Integer
            Dim SQL As String
            SQL = "insert into userkaryawan(userid,karyawanid) values" +
                "(@userid,@karyawanid)"
            Using DBX As IDbConnection = _DBConnection.Connection
                AddUser = DBX.Execute(SQL, Data)
            End Using
        End Function
        Public Function ReadTransaction(ByVal TextSearch As String, Optional KodeBagian As String = "", Optional KodeDept As String = "") As DataSet
            Dim SQL As String

            SQL = "SELECT " +
                 "A.UserID                               , " +
                 "A.UserName     					     , " +
                 "Case when A.Active = 1 then 'Y' else 'N' end AS 'Status', " +
                 "B.karyawanid 					         AS 'IDKaryawan' " +
                 "FROM user A " +
                 "LEFT JOIN userkaryawan B ON A.UserID=b.userid  " +
                 "WHERE A.UserName LIKE @TextSearch"

            'If KodeBagian <> "" Then
            '    SQL += " AND B.bagianid = '" + KodeBagian + "' "
            'End If

            'If KodeDept <> "" Then
            '    SQL += " AND b.departemenid = '" + KodeDept + "' "
            'End If

            TextSearch = String.Concat(Space(1), TextSearch.Trim(), Space(1)).Replace(" ", "%")

            Using DBX As IDbConnection = _DBConnection.Connection()

                Dim CMD As New MySql.Data.MySqlClient.MySqlCommand(SQL, DBX)
                Dim DA As New MySql.Data.MySqlClient.MySqlDataAdapter
                Dim DS As New DataSet

                CMD.Parameters.AddWithValue("@TextSearch", TextSearch)
                DA.SelectCommand = CMD
                DA.Fill(DS, "View")

                ReadTransaction = DS
            End Using
        End Function
        Public Function CheckValidation(Optional Userid As String = "", Optional Karyawanid As String = "") As DataSet
            Dim SQL As String
            SQL = "Select b.* from userkaryawan a " +
                " inner join user b on b.userid = a.userid where a.karyawanid =" + Karyawanid + ""
            Using DBX As IDbConnection = _DBConnection.Connection()
                Dim CMD As New MySql.Data.MySqlClient.MySqlCommand(SQL, DBX)
                Dim DA As New MySql.Data.MySqlClient.MySqlDataAdapter
                Dim DS As New DataSet
                DA.SelectCommand = CMD
                DA.Fill(DS, "View")

                CheckValidation = DS
            End Using
        End Function
        Public Function Delete(ByVal ID As String) As Integer
            Dim SQL As String

            SQL = "DELETE FROM userkaryawan " +
                  "WHERE UserID = @userid "

            Using DBX As IDbConnection = _DBConnection.Connection
                Delete = DBX.Execute(SQL, New With {.userid = ID})
            End Using
        End Function

        Public Function GetLookup(TextSearch As String, Parameter As Object) As DataSet Implements IDataLookup.GetLookup
            Dim SQL As String
            Dim Lookup As String = Parameter(0)
            Dim KodeBagian As String = Parameter(1)
            Dim KodePosisi As String = Parameter(2)
            Dim Periode As String = Parameter(3)

            Select Case Lookup
                'Case enumLookupKaryawan.DaftarKaryawan

                '    SQL = "SELECT " +
                '          "A.KodeKaryawan                            AS 'Kode', " +
                '          "A.NamaKaryawan                            AS 'Nama Karyawan' " +
                '          "FROM kpiheader A " +
                '          "WHERE CONCAT(A.KodeKaryawan,' ',A.NamaKaryawan) LIKE @Kriteria " +
                '          "AND DATE_FORMAT(A.TglTransaksi, '%y%m') = '" + Periode + "' " +
                '          "AND A.KodeBagian = '" + KodeBagian + "' " +
                '          "AND A.KodePosisi = '" + KodePosisi + "' "

                '    TextSearch = String.Concat(Space(1), TextSearch.Trim(), Space(1)).Replace(" ", "%")

            End Select

            Using DBX As IDbConnection = _DBConnection.Connection
                'Dim CMD As New MySql.Data.MySqlClient.MySqlCommand(SQL, DBX)
                'Dim DA As New MySql.Data.MySqlClient.MySqlDataAdapter
                Dim DS As New DataSet

                'CMD.Parameters.AddWithValue("@Kriteria", TextSearch)
                'DA.SelectCommand = CMD
                'DA.Fill(DS, "Lookup")

                GetLookup = DS
            End Using
        End Function
    End Class
End Namespace
