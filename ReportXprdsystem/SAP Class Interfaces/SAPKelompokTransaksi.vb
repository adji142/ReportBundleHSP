Imports Sap.Data.Hana
Imports ReportXprdsystem.HSP.Data

Public Enum enumObjectTransaction
    GoodsReceipt = 59
    GoodsIssue = 60
End Enum

Public Class SAPKelompokTransaksi
    Public Property KodeObject As Long
    Public Property KodeKelompok As String
    Public Property NamaKelompok As String
    Public Property Tahun As String
End Class

Public Class DaftarSAPKelompokTransaksi
    Public Function Find(ByVal ID As enumObjectTransaction, ByVal Tahun As String) As SAPKelompokTransaksi
        Dim DB As New SAPDBConnection
        Dim SQL As String

        SQL = "SELECT ""ObjectCode""            ""KodeObject"", " +
              "       ""Series""                ""KodeKelompok"", " +
              "       ""SeriesName""            ""NamaKelompok"", " +
              "       ""Indicator""             ""Tahun"" " +
              "FROM ""NNM1"" " +
              "WHERE ""ObjectCode""='" & ID & "' AND ""Indicator""='" & Tahun & "' "

        Using DBX As IDbConnection = DB.Connection()
            Dim CMD As New HanaCommand(SQL, DBX)
            Dim DR As HanaDataReader = CMD.ExecuteReader()
            Dim Temp As SAPKelompokTransaksi = Nothing

            If DR.Read() Then
                Temp = New SAPKelompokTransaksi()

                Temp.KodeObject = DR("KodeObject")
                Temp.KodeKelompok = DR("KodeKelompok")
                Temp.NamaKelompok = DR("NamaKelompok")
                Temp.Tahun = DR("Tahun")
            End If

            DR.Close()

            Find = Temp
        End Using
    End Function
End Class
