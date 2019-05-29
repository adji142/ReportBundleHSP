Imports Dapper
Imports AppUserSetting.HSP.Data
Public Class UserLokasi
    Public Property KodeUser As String
    Public Property KodeLokasi As String
    Public Property NamaLokasi As String
    Public Property UserIDTelegram As String
    Public Property NickNameTelegram As String
End Class
Public Class GetAllUser
    Private _DBConnection As DBConnection

    Sub New(ByVal Session As Object)
        _DBConnection = New DBConnection(Session)
    End Sub
    Public Function Add(ByVal Data As UserLokasi) As Integer
        Dim SQL As String

        SQL = "INSERT INTO hspspm.lokasiuser " +
               "VALUES " +
               "(@KodeUser,@KodeLokasi,@NamaLokasi,@UserIDTelegram,@NickNameTelegram)"

        Using DBX As IDbConnection = _DBConnection.Connection
            Add = DBX.Execute(SQL, Data)
        End Using
    End Function
    Public Function Delete(ByVal UserID As String) As Integer
        Dim SQL As String
        SQL = "delete from hspspm.lokasiuser where KodeUser = '" + UserID + "'"
        Using DBX As IDbConnection = _DBConnection.Connection
            Delete = DBX.Execute(SQL)
        End Using
    End Function
    Public Function Update(ByVal Data As UserLokasi) As Integer
        Dim SQL As String

        SQL = "Update hspspm.lokasiuser set KodeUser = @KodeUser,KodeLokasi = @KodeLokasi" +
               " where KodeUser = @KodeUser"

        Using DBX As IDbConnection = _DBConnection.Connection
            Update = DBX.Execute(SQL, Data)
        End Using
    End Function
    Public Function Read(ByVal Kriteria As String)
        Dim SQL As String
        SQL = "select a.KodeUser as 'KodeUser',a.NamaUser As 'NamaUser',coalesce (b.KodeLokasi,'') as 'KodeLokasi',coalesce(b.NamaLokasi,'') as 'NamaLokasi',coalesce(b.UserIDTelegram,'') As 'UserTelegram',coalesce(b.NickNameTelegram,'') As 'UsernameTelegram' from `user` a" +
            " LEFT JOIN hspspm.lokasiuser b on a.KodeUser = b.KodeUser" +
            " where a.Aktif = 1" +
            " and CONCAT(a.KodeUser,' ',a.NamaUser) LIKE @Kriteria "
        Kriteria = String.Concat(Space(1), Kriteria.Trim(), Space(1)).Replace(" ", "%")
        Using DBX As IDbConnection = _DBConnection.Connection
            Dim CMD As New MySql.Data.MySqlClient.MySqlCommand(SQL, DBX)
            Dim DA As New MySql.Data.MySqlClient.MySqlDataAdapter
            Dim DS As New DataSet

            CMD.Parameters.AddWithValue("@Kriteria", Kriteria)
            DA.SelectCommand = CMD
            DA.Fill(DS, "View")

            Read = DS
        End Using
    End Function
End Class
