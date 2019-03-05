Imports Dapper

Namespace HSP.Data

    Public Enum enumKoreksi
        enumRoll = 1
        enumBall = 2
        enumBenangMultifilament = 3
        enumBenangExtruder = 4
    End Enum

    Public Class Inventory
        Private _DBConnection As DBConnection

        Sub New(ByVal Session As Object)
            _DBConnection = New DBConnection(Session)
        End Sub

        Public Function ReadData(ByVal KodeProduksi As String, _
                                 ByVal KodeItem As String, _
                                 ByVal Koreksi As enumKoreksi, _
                                 ByVal KodeLokasi As String) As DataSet

            Dim SQL As String = ""

            Select Case Koreksi
                Case enumKoreksi.enumRoll
                    If KodeProduksi <> "" Then
                        SQL = "SELECT KodeItem, NamaItem, Satuan1 AS Satuan, Jumlah1 AS Stock FROM stockroll WHERE KodeProduksi ='" + KodeProduksi + "' AND StatusStock=1 AND StatusTransaksi=1 AND KodeLokasi = '" + KodeLokasi + "' " +
                              "UNION ALL " +
                              "SELECT KodeItem, NamaItem,  Satuan2 AS Satuan, Jumlah2 AS Stock FROM stockroll WHERE KodeProduksi ='" + KodeProduksi + "' AND StatusStock=1 AND StatusTransaksi=1 AND KodeLokasi = '" + KodeLokasi + "' " +
                              "UNION ALL " +
                              "SELECT KodeItem, NamaItem,  Satuan3 AS Satuan, Jumlah3 AS Stock FROM stockroll WHERE KodeProduksi ='" + KodeProduksi + "' AND StatusStock=1 AND StatusTransaksi=1 AND KodeLokasi = '" + KodeLokasi + "' "
                    Else
                        SQL = "SELECT Satuan1 AS Satuan, Jumlah1 AS Stock FROM stockroll WHERE KodeItem ='" + KodeItem + "' AND StatusStock=1 AND StatusTransaksi=1 AND KodeLokasi = '" + KodeLokasi + "' "
                    End If
            End Select

            Using DBX As IDbConnection = _DBConnection.Connection

                Dim CMD As New MySql.Data.MySqlClient.MySqlCommand(SQL, DBX)
                Dim DA As New MySql.Data.MySqlClient.MySqlDataAdapter
                Dim DS As New DataSet

                DA.SelectCommand = CMD
                DA.Fill(DS, "View")

                ReadData = DS
            End Using
        End Function

    End Class
End Namespace

