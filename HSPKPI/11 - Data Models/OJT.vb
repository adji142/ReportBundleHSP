Imports Dapper

Namespace HSP.Data
    Public Class HeaderOJT
        Public Property NoTransaksi As String
        Public Property TglTransaksi As DateTime
        Public Property TglPencatatan As DateTime
        Public Property KodeDept As String
        Public Property NamaDept As String
        Public Property KodeBagian As String
        Public Property KodePosisi As String
        Public Property NamaBagian As String
        Public Property NamaPosisi As String
        Public Property KodeKelompok As String
        Public Property KodeKaryawan As String
        Public Property NamaKaryawan As String
        Public Property UserID As String
        Public Property TRX As String
        Public Property Periode As String
    End Class

    Public Class DetailOJT
        Public Property NoTransaksi As String
        Public Property NoUrut As Integer
        Public Property KodeAspek As String
        Public Property NamaAspek As String
        Public Property Hasil As String
        Public Property Nilai As String
        Public Property NXB As String
    End Class

    Public Class DaftarOJT : Implements IDataLookup
        Private _DBConnection As DBConnection

        Public Enum enumLookupKaryawan
            DaftarKaryawan = 1
        End Enum

        Sub New(ByVal Session As Object)
            _DBConnection = New DBConnection(Session)
        End Sub

        'CRUD HeaderOJT
        '------------------------------------------------------------------------------------------------------------------
        Public Function AddHeader(ByVal Data As HeaderOJT) As Integer
            Dim SQL As String

            SQL = "INSERT INTO OJTheader " +
                  "(NoTransaksi, TglTransaksi, TglPencatatan, KodeDept, NamaDept, KodeBagian, KodePosisi, KodeKelompok, " +
                  "KodeKaryawan, NamaKaryawan, UserID, TRX, NamaBagian, NamaPosisi, Periode) " +
                  "VALUES " +
                  "(@NoTransaksi, @TglTransaksi, @TglPencatatan, @KodeDept, @NamaDept, @KodeBagian, @KodePosisi, @KodeKelompok, " +
                  "@KodeKaryawan, @NamaKaryawan, @UserID, '" + TRX() + "', @NamaBagian, @NamaPosisi, @Periode)"

            Using DBX As IDbConnection = _DBConnection.Connection
                AddHeader = DBX.Execute(SQL, Data)
            End Using
        End Function

        Public Function EditHeader(ByVal Data As HeaderOJT) As Integer
            Dim SQL As String

            SQL = "UPDATE OJTheader SET " +
                  "NoTransaksi = @NoTransaksi, " +
                  "TglTransaksi = @TglTransaksi, " +
                  "TglPencatatan = @TglPencatatan, " +
                  "Kodedept = @KodeDept, " +
                  "NamaDept = @NamaDept, " +
                  "KodeBagian = @KodeBagian, " +
                  "KodePosisi = @KodePosisi, " +
                  "NamaBagian = @NamaBagian, " +
                  "NamaPosisi = @NamaPosisi, " +
                  "KodeKelompok = @KodeKelompok, " +
                  "KodeKaryawan = @KodeKaryawan, " +
                  "NamaKaryawan = @NamaKaryawan, " +
                  "UserID = @UserID, " +
                  "Periode = @Periode, " +
                  "TRX = '" + TRX() + "' " +
                  "WHERE NoTransaksi = @NoTransaksi"

            Using DBX As IDbConnection = _DBConnection.Connection
                EditHeader = DBX.Execute(SQL, Data)
            End Using
        End Function

        Public Function DeleteHeader(ByVal ID As String) As Integer
            Dim SQL As String

            SQL = "DELETE FROM OJTHeader " +
                  "WHERE NoTransaksi = @NoTransaksi"

            Using DBX As IDbConnection = _DBConnection.Connection
                DeleteHeader = DBX.Execute(SQL, New With {.NoTransaksi = ID})
            End Using
        End Function

        Public Function FindHeader(ByVal ID As String) As HeaderOJT
            Dim SQL As String

            SQL = "SELECT * FROM OJTheader " +
                  "WHERE NoTransaksi = @NoTransaksi"

            Using DBX As IDbConnection = _DBConnection.Connection
                FindHeader = DBX.Query(Of HeaderOJT)(SQL, New With {.NoTransaksi = ID}).FirstOrDefault
            End Using
        End Function

        'CRUD DetailOJT
        '------------------------------------------------------------------------------------------------------------------

        Public Function AddDetail(ByVal Data As DetailOJT) As Integer
            Dim SQL As String

            SQL = "INSERT INTO OJTdetail " +
                  "(NoTransaksi, NoUrut, KodeAspek, Hasil, Nilai, NXB) " +
                  "VALUES " +
                  "(@NoTransaksi, @NoUrut, @KodeAspek, @Hasil, @Nilai, @NXB)"

            Using DBX As IDbConnection = _DBConnection.Connection
                AddDetail = DBX.Execute(SQL, Data)
            End Using
        End Function

        Public Function DeleteDetail(ByVal ID As String) As Integer
            Dim SQL As String

            SQL = "DELETE FROM OJTdetail " +
                  "WHERE NoTransaksi = @NoTransaksi"

            Using DBX As IDbConnection = _DBConnection.Connection
                DeleteDetail = DBX.Execute(SQL, New With {.NoTransaksi = ID})
            End Using
        End Function

        Public Function ReadTransaction(ByVal Periode As String, ByVal TextSearch As String, Optional KodeBagian As String = "", Optional KodeDept As String = "") As DataSet
            Dim SQL As String

            SQL = "SELECT " +
                 "A.NoTransaksi                          AS 'Nomor', " +
                 "A.Periode     					     AS 'Periode', " +
                 "A.NamaDept					         AS 'Departemen', " +
                 "A.NamaBagian 					         AS 'Bagian', " +
                 "A.NamaPosisi					         AS 'Posisi', " +
                 "A.KodeKaryawan 					     AS 'Kode Karyawan', " +
                 "A.NamaKaryawan 					     AS 'Nama Karyawan' " +
                 "FROM OJTheader A " +
                 "WHERE CONCAT(A.NoTransaksi, ' ', " +
                 "             A.NamaPosisi, ' ', " +
                 "             A.KodeKaryawan, ' ', " +
                 "             A.NamaKaryawan, ' ' " +
                 "             ) LIKE @TextSearch "

            If KodeBagian <> "" Then
                SQL += " AND A.KodeBagian = '" + KodeBagian + "' "
            End If

            If KodeDept <> "" Then
                SQL += " AND A.KodeDept = '" + KodeDept + "' "
            End If

            SQL += "AND A.Periode = @Periode " +
                   "ORDER BY A.TglTransaksi, A.NoTransaksi"

            TextSearch = String.Concat(Space(1), TextSearch.Trim(), Space(1)).Replace(" ", "%")

            Using DBX As IDbConnection = _DBConnection.Connection()

                Dim CMD As New MySql.Data.MySqlClient.MySqlCommand(SQL, DBX)
                Dim DA As New MySql.Data.MySqlClient.MySqlDataAdapter
                Dim DS As New DataSet

                CMD.Parameters.AddWithValue("@TextSearch", TextSearch)
                CMD.Parameters.AddWithValue("@Periode", Periode)
                DA.SelectCommand = CMD
                DA.Fill(DS, "View")

                ReadTransaction = DS
            End Using
        End Function

        Public Function ReadDetail(ByVal NoTransaksi As String) As DataSet
            Dim SQL As String

            SQL = "SELECT A.KodeAspek                           AS 'Kode Aspek', " +
                  "B.NamaAspek                                  AS 'Nama Aspek', " +
                  "B.Bobot                                      AS 'Bobot', " +
                  "CONCAT(B.Target,' ',B.Keterangan)            AS 'Target', " +
                  "A.Hasil                                      AS 'Hasil', " +
                  "A.Nilai                                      AS 'Nilai', " +
                  "A.NXB                                        AS 'NXB', " +
                  "B.Tipe                                       AS 'Tipe' " +
                  "FROM OJTdetail A " +
                  "LEFT JOIN taspekheader B on A.KodeAspek=B.KodeAspek " +
                  "WHERE A.NoTransaksi = @NoTransaksi " +
                  "ORDER BY A.NoUrut"

            Using DBX As IDbConnection = _DBConnection.Connection
                Dim CMD As New MySql.Data.MySqlClient.MySqlCommand(SQL, DBX)
                Dim DA As New MySql.Data.MySqlClient.MySqlDataAdapter
                Dim DS As New DataSet

                CMD.Parameters.AddWithValue("@NoTransaksi", NoTransaksi)
                DA.SelectCommand = CMD
                DA.Fill(DS, "View")

                ReadDetail = DS
            End Using
        End Function


        'Get Nomor Transaksi
        Public Function GetNomorTransaksi(ByVal Periode As String) As String
            Dim SQL As String
            Dim Prefik, Nomor, Temp As String

            'Rubah Format Periode Dari YYYYMM Menjadi YYMM
            Periode = Periode.Substring(2, 4)

            Using DBX As IDbConnection = _DBConnection.Connection()

                'Prefik Nomor Transaksi
                '------------------------------------------------------------------------------------------
                Prefik = "OJT-" & Periode

                'Nomor Transaksi
                '------------------------------------------------------------------------------------------
                SQL = "SELECT COUNT(*) AS Total FROM OJTheader " +
                      "WHERE LEFT(NoTransaksi, LENGTH(@Prefik)) = @Prefik "

                Temp = (DBX.Query(SQL, New With {.Prefik = Prefik}).FirstOrDefault.Total + 1).ToString
                Nomor = Temp.PadLeft(12 - Prefik.Length).Replace(" ", "0")
                '------------------------------------------------------------------------------------------

            End Using
            GetNomorTransaksi = Prefik + Nomor

        End Function

        Public Function CekData(ByVal ID As String) As HeaderOJT
            Dim SQL As String

            SQL = "SELECT * FROM OJTheader " +
                  "WHERE CONCAT(RIGHT(PERIODE,4),kodebagian,kodeposisi,kodekelompok,kodekaryawan) = @Kriteria "

            Using DBX As IDbConnection = _DBConnection.Connection
                CekData = DBX.Query(Of HeaderOJT)(SQL, New With {.Kriteria = ID}).FirstOrDefault
            End Using
        End Function

        Public Function GetLookup(TextSearch As String, Parameter As Object) As DataSet Implements IDataLookup.GetLookup
            Dim SQL As String
            Dim Lookup As String = Parameter(0)
            Dim KodeBagian As String = Parameter(1)
            Dim KodePosisi As String = Parameter(2)
            Dim Periode As String = Parameter(3)

            Select Case Lookup
                Case enumLookupKaryawan.DaftarKaryawan

                    SQL = "SELECT " +
                          "A.KodeKaryawan                            AS 'Kode', " +
                          "A.NamaKaryawan                            AS 'Nama Karyawan' " +
                          "FROM OJTheader A " +
                          "WHERE CONCAT(A.KodeKaryawan,' ',A.NamaKaryawan) LIKE @Kriteria " +
                          "AND DATE_FORMAT(A.TglTransaksi, '%y%m') = '" + Periode + "' " +
                          "AND A.KodeBagian = '" + KodeBagian + "' " +
                          "AND A.KodePosisi = '" + KodePosisi + "' "

                    TextSearch = String.Concat(Space(1), TextSearch.Trim(), Space(1)).Replace(" ", "%")

            End Select

            Using DBX As IDbConnection = _DBConnection.Connection
                Dim CMD As New MySql.Data.MySqlClient.MySqlCommand(SQL, DBX)
                Dim DA As New MySql.Data.MySqlClient.MySqlDataAdapter
                Dim DS As New DataSet

                CMD.Parameters.AddWithValue("@Kriteria", TextSearch)
                DA.SelectCommand = CMD
                DA.Fill(DS, "Lookup")

                GetLookup = DS
            End Using
        End Function

    End Class
End Namespace

