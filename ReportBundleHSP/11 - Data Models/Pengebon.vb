Imports Dapper
Namespace HSP.Data
    Public Class Pengebon : Implements IDataLookup
        Private _DBConnection As DBConnection
        Sub New(ByVal Session As Object)
            _DBConnection = New DBConnection(Session)
        End Sub
        Public Function GetLookup(TextSearch As String, Parameter As Object) As DataSet Implements IDataLookup.GetLookup
            Dim SQL As String
            SQL = "Select KodeLokasi,NamaLokasi from hspspm.LokasiUser order by NamaLokasi"

            Using DBX As IDbConnection = _DBConnection.Connection
                Dim CMD As New MySql.Data.MySqlClient.MySqlCommand(SQL, DBX)
                Dim DA As New MySql.Data.MySqlClient.MySqlDataAdapter
                Dim DS As New DataSet

                DA.SelectCommand = CMD
                DA.Fill(DS, "Lookup")
                GetLookup = DS
            End Using
        End Function
        Public Function Read(ByVal UserID As String) As DataSet
            Dim SQL As String
            SQL = "Select KodeLokasi,NamaLokasi from hspspm.LokasiUser where KodeUser like '%" + UserID + "%' order by NamaLokasi"

            Using DBX As IDbConnection = _DBConnection.Connection
                Dim CMD As New MySql.Data.MySqlClient.MySqlCommand(SQL, DBX)
                Dim DA As New MySql.Data.MySqlClient.MySqlDataAdapter
                Dim DS As New DataSet

                DA.SelectCommand = CMD
                DA.Fill(DS, "View")
                Read = DS
            End Using
        End Function
    End Class
End Namespace
