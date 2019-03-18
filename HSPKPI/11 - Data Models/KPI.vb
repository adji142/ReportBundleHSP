Imports Dapper

Namespace HSP.Data
    Public Class HeaderKPI
        Public Property NoTransaksi As String
        Public Property TglTransaksi As DateTime
        Public Property TglPencatatan As DateTime
        Public Property KodeBagian As String
        Public Property KodePosisi As String
        Public Property KodeDept As String
        Public Property NamaDept As String
        Public Property NamaBagian As String
        Public Property NamaPosisi As String
        Public Property KodeAspek As String
        Public Property NamaAspek As String
        Public Property KodeKelompok As String
        Public Property UserID As String
        Public Property TRX As String
        Public Property Periode As String
    End Class

    Public Class DetailKPI
        Public Property NoTransaksi As String
        Public Property NoUrut As Integer
        Public Property KodeKaryawan As String
        Public Property NamaKaryawan As String
        Public Property Hasil As String
        Public Property Nilai As String
        Public Property NXB As String
    End Class

    Public Class DaftarKPI : Implements IDataLookup
        Private _DBConnection As DBConnection

        Public Enum enumLookupKaryawan
            DaftarKaryawan = 1
        End Enum

        Sub New(ByVal Session As Object)
            _DBConnection = New DBConnection(Session)
        End Sub

        'CRUD HeaderKPI
        '------------------------------------------------------------------------------------------------------------------
        Public Function AddHeader(ByVal Data As HeaderKPI) As Integer
            Dim SQL As String

            SQL = "INSERT INTO kpiheader " +
                  "(NoTransaksi, TglTransaksi, TglPencatatan, KodeDept, KodeBagian, KodePosisi, KodeKelompok, " +
                  "KodeAspek, UserID, TRX, NamaDept, NamaBagian, NamaPosisi, Periode) " +
                  "VALUES " +
                  "(@NoTransaksi, @TglTransaksi, @TglPencatatan, @KodeDept, @KodeBagian, @KodePosisi, @KodeKelompok, " +
                  "@KodeAspek, @UserID, '" + TRX() + "', @NamaDept, @NamaBagian, @NamaPosisi, @Periode)"

            Using DBX As IDbConnection = _DBConnection.Connection
                AddHeader = DBX.Execute(SQL, Data)
            End Using
        End Function

        Public Function EditHeader(ByVal Data As HeaderKPI) As Integer
            Dim SQL As String

            SQL = "UPDATE kpiheader SET " +
                  "NoTransaksi = @NoTransaksi, " +
                  "TglTransaksi = @TglTransaksi, " +
                  "TglPencatatan = @TglPencatatan, " +
                  "KodeDept = @KodeDept, " +
                  "NamaDept = @NamaDept, " +
                  "KodeBagian = @KodeBagian, " +
                  "KodePosisi = @KodePosisi, " +
                  "NamaBagian = @NamaBagian, " +
                  "NamaPosisi = @NamaPosisi, " +
                  "KodeKelompok = @KodeKelompok, " +
                  "KodeAspek = @KodeAspek, " +
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

            SQL = "DELETE FROM kpiHeader " +
                  "WHERE NoTransaksi = @NoTransaksi"

            Using DBX As IDbConnection = _DBConnection.Connection
                DeleteHeader = DBX.Execute(SQL, New With {.NoTransaksi = ID})
            End Using
        End Function

        Public Function FindHeader(ByVal ID As String) As HeaderKPI
            Dim SQL As String

            SQL = "SELECT * FROM kpiheader " +
                  "WHERE NoTransaksi = @NoTransaksi"

            Using DBX As IDbConnection = _DBConnection.Connection
                FindHeader = DBX.Query(Of HeaderKPI)(SQL, New With {.NoTransaksi = ID}).FirstOrDefault
            End Using
        End Function

        'CRUD DetailKPI
        '------------------------------------------------------------------------------------------------------------------

        Public Function AddDetail(ByVal Data As DetailKPI) As Integer
            Dim SQL As String

            SQL = "INSERT INTO kpidetail " +
                  "(NoTransaksi, NoUrut, KodeKaryawan, NamaKaryawan, Hasil, Nilai, NXB) " +
                  "VALUES " +
                  "(@NoTransaksi, @NoUrut, @KodeKaryawan, @NamaKaryawan, @Hasil, @Nilai, @NXB)"

            Using DBX As IDbConnection = _DBConnection.Connection
                AddDetail = DBX.Execute(SQL, Data)
            End Using
        End Function

        Public Function DeleteDetail(ByVal ID As String) As Integer
            Dim SQL As String

            SQL = "DELETE FROM kpidetail " +
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
                 "A.NamaDept                             AS 'Departemen', " +
                 "A.NamaBagian 					         AS 'Bagian', " +
                 "A.NamaPosisi					         AS 'Posisi', " +
                 "D.NamaAspek    					     AS 'Aspek' " +
                 "FROM kpiheader A " +
                 "JOIN taspekheader D ON A.KodeAspek=D.KodeAspek  " +
                 "WHERE A.KodeKelompok='KPI' AND " +
                 "      CONCAT(A.NoTransaksi, ' ', " +
                 "             A.NamaPosisi, ' ', " +
                 "             D.NamaAspek, ' ' " +
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

            SQL = "SELECT A.KodeKaryawan                        AS 'Kode Karyawan', " +
                  "A.NamaKaryawan                               AS 'Nama Karyawan', " +
                  "A.Hasil                                      AS 'Hasil', " +
                  "A.Nilai                                      AS 'Nilai', " +
                  "A.NXB                                        AS 'NXB' " +
                  "FROM kpidetail A " +
                  "WHERE A.NoTransaksi = @NoTransaksi " +
                  "ORDER BY A.NamaKaryawan"

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
                Prefik = "KPI-" & Periode

                'Nomor Transaksi
                '------------------------------------------------------------------------------------------
                SQL = "SELECT CAST(RIGHT(MAX(NoTransaksi),4) AS INT)  AS Total FROM kpiheader " +
                      "WHERE LEFT(NoTransaksi, LENGTH(@Prefik)) = @Prefik "

                Temp = (DBX.Query(SQL, New With {.Prefik = Prefik}).FirstOrDefault.Total + 1).ToString
                Nomor = Temp.PadLeft(12 - Prefik.Length).Replace(" ", "0")
                '------------------------------------------------------------------------------------------

            End Using
            GetNomorTransaksi = Prefik + Nomor

        End Function

        Public Function CekData(ByVal ID As String) As HeaderKPI
            Dim SQL As String

            SQL = "SELECT * FROM kpiheader " +
                  "WHERE CONCAT(RIGHT(PERIODE,4),kodebagian,kodeposisi,kodekelompok,kodeaspek) = @Kriteria "

            Using DBX As IDbConnection = _DBConnection.Connection
                CekData = DBX.Query(Of HeaderKPI)(SQL, New With {.Kriteria = ID}).FirstOrDefault
            End Using
        End Function

        Public Function GetLookup(TextSearch As String, Parameter As Object) As DataSet Implements IDataLookup.GetLookup
            Dim SQL As String
            Dim Lookup As String = Parameter(0)
            Dim KodeBagian As String = Parameter(1)
            Dim KodePosisi As String = Parameter(2)
            Dim Periode As String = Parameter(3)

            Select Lookup
                Case enumLookupKaryawan.DaftarKaryawan

                    SQL = "SELECT " +
                          "A.KodeKaryawan                            AS 'Kode', " +
                          "A.NamaKaryawan                            AS 'Nama Karyawan' " +
                          "FROM kpiheader A " +
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

