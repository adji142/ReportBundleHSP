Imports Sap.Data.Hana
Imports HSPProduction.HSP.Data

Public Class InvTransfer
    Public Property NoTransaksi As String
    Public Property KodeItem As String
    Public Property NamaItem As String
    Public Property LokasiAsal As String
    Public Property LokasiTujuan As String
    Public Property Quantity As Double
End Class

Public Class FGReceipt
    Public Property NoTransaksi As String
    Public Property KodeProduksi As String
    Public Property KodeItem As String
    Public Property NamaItem As String
    Public Property Lokasi As String
    Public Property Quantity As Double
End Class

Public Class SAPStaging

    Public Enum enumTransaction
        MaterialIssue = 1
        MaterialReceipt = 2
        FinishedGoodReceipt = 3
        AfvalReceipt = 4
        AfvalReceiptWWO = 5
        InventoryTransfer = 6
        DirectProcess = 7
        InventoryTransferRequest = 8
        FinishedGoodIssue = 9
        GoodIssue = 10
        GoodReceipt = 11
    End Enum

    Public Enum enumTransaksiStaging
        HasilExtruder = 1
        PemakaianBahanCLoom = 2
    End Enum

    'Execute
    'Eksekusi Data Staging Transaction Ke SBO
    Public Sub Execute(NoTransaksi As String, Transaksi As enumTransaction)
        Dim DB As New SOLStaging.SOLHDBConnection

        DB.SetSAPConnection(My.Settings.HanaServer, My.Settings.HanaSAPDatabaseName, My.Settings.HanaUserName, My.Settings.HanaPassword)
        DB.SetStagingConnection(My.Settings.HanaServer, My.Settings.HanaSTGDatabaseName, My.Settings.HanaUserName, My.Settings.HanaPassword)

        Select Case Transaksi
            Case enumTransaction.MaterialIssue

                '-----------------------------------------------------------------------------------------------------
                Dim STX As New SOLStaging.RawMaterial(DB)

                'Query
                Dim SQL As String = ""

                SQL += "SELECT ""EntryNo"" FROM  ""Staging_RM_Issue"" "
                SQL += "WHERE ""Ref"" = '" + NoTransaksi + "' AND ""Imported"" = 'N' "

                'Baca Data
                Dim DBSTG As New SAPDBConnection("STAGINGDB")
                Dim DaftarTransaksi As New List(Of Integer)()

                Using DBX As IDbConnection = DBSTG.Connection()
                    Dim CMD As New HanaCommand(SQL, DBX)
                    Dim DR As HanaDataReader = CMD.ExecuteReader()

                    While DR.Read()
                        DaftarTransaksi.Add(DR("EntryNo").ToString())
                    End While
                End Using

                'Eksekuasi
                If DaftarTransaksi.Count > 0 Then
                    STX.IssueRM(DaftarTransaksi)
                End If

                '-----------------------------------------------------------------------------------------------------

            Case enumTransaction.MaterialReceipt

                '-----------------------------------------------------------------------------------------------------
                Dim STX As New SOLStaging.RawMaterial(DB)

                'Query
                Dim SQL As String = ""

                SQL += "SELECT ""EntryNo"" FROM  ""Staging_RM_Receipt"" "
                SQL += "WHERE ""Ref"" = '" + NoTransaksi + "' AND ""Imported"" = 'N' "

                'Baca Data
                Dim DBSTG As New SAPDBConnection("STAGINGDB")
                Dim DaftarTransaksi As New List(Of Integer)()

                Using DBX As IDbConnection = DBSTG.Connection()
                    Dim CMD As New HanaCommand(SQL, DBX)
                    Dim DR As HanaDataReader = CMD.ExecuteReader()

                    While DR.Read()
                        DaftarTransaksi.Add(DR("EntryNo").ToString())
                    End While
                End Using

                'Eksekuasi
                If DaftarTransaksi.Count > 0 Then
                    STX.ReceiptRM(DaftarTransaksi)
                End If
                '-----------------------------------------------------------------------------------------------------

            Case enumTransaction.FinishedGoodReceipt

                '-----------------------------------------------------------------------------------------------------
                Dim STX As New SOLStaging.FinishedGood(DB)

                'Query
                Dim SQL As String = ""

                SQL += "SELECT ""EntryNo"" FROM  ""Staging_FG_Receipt"" "
                SQL += "WHERE ""Ref"" = '" + NoTransaksi + "' AND ""Imported"" = 'N' "

                'Baca Data
                Dim DBSTG As New SAPDBConnection("STAGINGDB")
                Dim DaftarTransaksi As New List(Of Integer)()

                Using DBX As IDbConnection = DBSTG.Connection()
                    Dim CMD As New HanaCommand(SQL, DBX)
                    Dim DR As HanaDataReader = CMD.ExecuteReader()

                    While DR.Read()
                        DaftarTransaksi.Add(DR("EntryNo").ToString())
                    End While
                End Using

                'Eksekuasi
                If DaftarTransaksi.Count > 0 Then
                    STX.ReceiptFG(DaftarTransaksi)
                End If
                '-----------------------------------------------------------------------------------------------------

            Case enumTransaction.FinishedGoodIssue

                '-----------------------------------------------------------------------------------------------------
                Dim STX As New SOLStaging.FinishedGood(DB)

                'Query
                Dim SQL As String = ""

                SQL += "SELECT ""EntryNo"" FROM  ""Staging_FG_Issue"" "
                SQL += "WHERE ""Ref"" = '" + NoTransaksi + "' AND ""Imported"" = 'N' "

                'Baca Data
                Dim DBSTG As New SAPDBConnection("STAGINGDB")
                Dim DaftarTransaksi As New List(Of Integer)()

                Using DBX As IDbConnection = DBSTG.Connection()
                    Dim CMD As New HanaCommand(SQL, DBX)
                    Dim DR As HanaDataReader = CMD.ExecuteReader()

                    While DR.Read()
                        DaftarTransaksi.Add(DR("EntryNo").ToString())
                    End While
                End Using

                'Eksekuasi
                If DaftarTransaksi.Count > 0 Then
                    STX.IssueFG(DaftarTransaksi)
                End If
                '-----------------------------------------------------------------------------------------------------

            Case enumTransaction.AfvalReceipt

                '-----------------------------------------------------------------------------------------------------
                Dim STX As New SOLStaging.RawMaterial(DB)

                'Query
                Dim SQL As String = ""

                SQL += "SELECT ""EntryNo"" FROM  ""Staging_RM_Receipt"" "
                SQL += "WHERE ""Ref"" = '" + NoTransaksi + "' AND ""Imported"" = 'N' "

                'Baca Data
                Dim DBSTG As New SAPDBConnection("STAGINGDB")
                Dim DaftarTransaksi As New List(Of Integer)()

                Using DBX As IDbConnection = DBSTG.Connection()
                    Dim CMD As New HanaCommand(SQL, DBX)
                    Dim DR As HanaDataReader = CMD.ExecuteReader()

                    While DR.Read()
                        DaftarTransaksi.Add(DR("EntryNo").ToString())
                    End While
                End Using

                'Eksekuasi
                If DaftarTransaksi.Count > 0 Then
                    STX.ReceiptRM(DaftarTransaksi)
                End If
                '-----------------------------------------------------------------------------------------------------

            Case enumTransaction.AfvalReceiptWWO

                '-----------------------------------------------------------------------------------------------------
                Dim STX As New SOLStaging.AfvalProcess(DB)

                'Query
                Dim SQL As String = ""

                SQL += "SELECT ""EntryNo"" FROM  ""Staging_Receipt_AfvalWWO"" "
                SQL += "WHERE ""Ref"" = '" + NoTransaksi + "' AND ""Imported"" = 'N' "

                'Baca Data
                Dim DBSTG As New SAPDBConnection("STAGINGDB")
                Dim DaftarTransaksi As New List(Of Integer)()

                Using DBX As IDbConnection = DBSTG.Connection()
                    Dim CMD As New HanaCommand(SQL, DBX)
                    Dim DR As HanaDataReader = CMD.ExecuteReader()

                    While DR.Read()
                        DaftarTransaksi.Add(DR("EntryNo").ToString())
                    End While
                End Using

                'Eksekuasi
                If DaftarTransaksi.Count > 0 Then
                    STX.ReceiptWWO(DaftarTransaksi)
                End If
                '-----------------------------------------------------------------------------------------------------

            Case enumTransaction.InventoryTransfer

                '-----------------------------------------------------------------------------------------------------
                Dim STX As New SOLStaging.InventoryTransfer(DB)

                'Query
                Dim SQL As String = ""

                SQL += "SELECT ""EntryNo"" FROM  ""Staging_InvTransfer"" "
                SQL += "WHERE ""Ref"" = '" + NoTransaksi + "' AND ""Imported"" = 'N' "

                'Baca Data
                Dim DBSTG As New SAPDBConnection("STAGINGDB")
                Dim DaftarTransaksi As New List(Of Integer)()

                Using DBX As IDbConnection = DBSTG.Connection()
                    Dim CMD As New HanaCommand(SQL, DBX)
                    Dim DR As HanaDataReader = CMD.ExecuteReader()

                    While DR.Read()
                        DaftarTransaksi.Add(DR("EntryNo").ToString())
                    End While
                End Using

                'Eksekuasi
                If DaftarTransaksi.Count > 0 Then
                    STX.Transfer(DaftarTransaksi)
                End If
                '-----------------------------------------------------------------------------------------------------

            Case enumTransaction.InventoryTransferRequest

                '-----------------------------------------------------------------------------------------------------
                Dim STX As New SOLStaging.InventoryTransfer(DB)

                'Query
                Dim SQL As String = ""

                SQL += "SELECT ""EntryNo"" FROM  ""Staging_InvTransferReq"" "
                SQL += "WHERE ""Ref"" = '" + NoTransaksi + "' AND ""Imported"" = 'N' "

                'Baca Data
                Dim DBSTG As New SAPDBConnection("STAGINGDB")
                Dim DaftarTransaksi As New List(Of Integer)()

                Using DBX As IDbConnection = DBSTG.Connection()
                    Dim CMD As New HanaCommand(SQL, DBX)
                    Dim DR As HanaDataReader = CMD.ExecuteReader()

                    While DR.Read()
                        DaftarTransaksi.Add(DR("EntryNo").ToString())
                    End While
                End Using

                'Eksekuasi
                If DaftarTransaksi.Count > 0 Then
                    STX.TransferReq(DaftarTransaksi)
                End If
                '-----------------------------------------------------------------------------------------------------

            Case enumTransaction.DirectProcess

                '-----------------------------------------------------------------------------------------------------
                Dim STX As New SOLStaging.AfvalProcess(DB)
                STX.ProcessSortir(NoTransaksi)
                '-----------------------------------------------------------------------------------------------------

            Case enumTransaction.GoodIssue

                '-----------------------------------------------------------------------------------------------------
                Dim STX As New SOLStaging.FinishedGood(DB)

                'Query
                Dim SQL As String = ""

                SQL += "SELECT ""EntryNo"" FROM  ""Staging_Goods_Issue"" "
                SQL += "WHERE ""Ref"" = '" + NoTransaksi + "' AND ""Imported"" = 'N' "

                'Baca Data
                Dim DBSTG As New SAPDBConnection("STAGINGDB")
                Dim DaftarTransaksi As New List(Of Integer)()

                Using DBX As IDbConnection = DBSTG.Connection()
                    Dim CMD As New HanaCommand(SQL, DBX)
                    Dim DR As HanaDataReader = CMD.ExecuteReader()

                    While DR.Read()
                        DaftarTransaksi.Add(DR("EntryNo").ToString())
                    End While
                End Using

                'Eksekuasi
                If DaftarTransaksi.Count > 0 Then
                    STX.IssueFG(DaftarTransaksi)
                End If
                '-----------------------------------------------------------------------------------------------------
        End Select

    End Sub

    'IsOpen
    'Membaca Status Transaksi Apakah Masih Open Atau Telah Di Posting
    Public Function IsOpen(NoTransaksi As String, Transaksi As enumTransaction) As Boolean
        Dim DB As New SAPDBConnection("STAGINGDB")
        Dim SQL As String = ""

        Select Case Transaksi
            Case enumTransaction.MaterialIssue
                SQL = "SELECT ""Imported"" As Status FROM ""Staging_RM_Issue"" " +
                      "WHERE ""Ref"" = '" + NoTransaksi + "'"
            Case enumTransaction.MaterialReceipt
                SQL = "SELECT ""Imported"" As Status FROM ""Staging_RM_Receipt"" " +
                      "WHERE ""Ref"" = '" + NoTransaksi + "'"
            Case enumTransaction.FinishedGoodReceipt
                SQL = "SELECT ""Imported"" As Status FROM ""Staging_FG_Receipt"" " +
                      "WHERE ""Ref"" = '" + NoTransaksi + "'"
            Case enumTransaction.FinishedGoodIssue
                SQL = "SELECT ""Imported"" As Status FROM ""Staging_FG_Issue"" " +
                      "WHERE ""Ref"" = '" + NoTransaksi + "'"
            Case enumTransaction.AfvalReceipt
                SQL = "SELECT ""Imported"" As Status FROM ""Staging_RM_Receipt"" " +
                      "WHERE ""Ref"" = '" + NoTransaksi + "'"
            Case enumTransaction.AfvalReceiptWWO
                SQL = "SELECT ""Imported"" As Status FROM ""Staging_Receipt_AfvalWWO"" " +
                      "WHERE ""Ref"" = '" + NoTransaksi + "'"
            Case enumTransaction.InventoryTransfer
                SQL = "SELECT ""Imported"" As Status FROM ""Staging_InvTransfer"" " +
                      "WHERE ""Ref"" = '" + NoTransaksi + "'"
            Case enumTransaction.InventoryTransferRequest
                SQL = "SELECT ""Imported"" As Status FROM ""Staging_InvTransferReq"" " +
                      "WHERE ""Ref"" = '" + NoTransaksi + "'"
            Case enumTransaction.DirectProcess
                SQL = "SELECT ""Imported"" As Status FROM ""Staging_Recycle_Receipt"" " +
                      "WHERE ""Ref"" = '" + NoTransaksi + "'"
        End Select

        Using DBX As IDbConnection = DB.Connection()

            Dim CMD As New HanaCommand(SQL, DBX)
            Dim DR As HanaDataReader = CMD.ExecuteReader()

            If DR.Read() Then
                If DR("Status") = "" Or DR("Status") = "N" Then
                    IsOpen = True
                Else
                    IsOpen = False
                End If
            Else
                IsOpen = False
            End If

            DR.Close()

        End Using
    End Function

    'Posting Data
    'Inventory Transfer    
    Public Function PostInventoryTransfer(Tanggal As Date,
                                          KodeItem As String,
                                          NamaItem As String,
                                          Qty As Double,
                                          KodeProduksi As String,
                                          NoTransaksi As String,
                                          LokasiAsal As String,
                                          LokasiTujuan As String) As Boolean

        Try
            Dim DB As New SAPDBConnection("STAGINGDB")
            Dim ManageBatch As String = If(KodeProduksi.Trim() = "", "N", "Y")

            Dim SQL As String

            SQL = ""
            SQL += "INSERT INTO ""Staging_InvTransfer"" "
            SQL += "VALUES ("
            SQL += "SeqInvTransfer.NEXTVAL, 0, 0, '" +
                                            Tanggal.Date.ToString("yyyyMMdd") + "', '" +
                                            KodeItem + "', '" +
                                            NamaItem + "', '" +
                                            ManageBatch + "', " +
                                            Qty.ToString + ", '" +
                                            KodeProduksi + "', '" +
                                            LokasiAsal + "', '" +
                                            LokasiTujuan + "', '" +
                                            NoTransaksi + "', 'N'"
            SQL += ")"

            Using DBX As IDbConnection = DB.Connection()
                Dim CMD As New HanaCommand(SQL, DBX)
                CMD.ExecuteNonQuery()
            End Using
            PostInventoryTransfer = True

        Catch ex As Exception
            PostInventoryTransfer = False
        End Try

    End Function

    'Posting Data
    'Inventory Transfer    
    Public Function PostInventoryTransferRequest(Tanggal As Date,
                                          KodeItem As String,
                                          NamaItem As String,
                                          Qty As Double,
                                          NoTransaksi As String,
                                          LokasiAsal As String,
                                          LokasiTujuan As String) As Boolean

        Try
            Dim DB As New SAPDBConnection("STAGINGDB")

            Dim SQL As String

            SQL = ""
            SQL += "INSERT INTO ""Staging_InvTransferReq"" "
            SQL += "VALUES ("
            SQL += "SeqInvTransferReq.NEXTVAL, '" +
                                            Tanggal.Date.ToString("yyyyMMdd") + "', '" +
                                            KodeItem + "', '" +
                                            NamaItem + "', " +
                                            Qty.ToString + ", '" +
                                            LokasiAsal + "', '" +
                                            LokasiTujuan + "', '" +
                                            NoTransaksi + "', 'N'"
            SQL += ")"

            Using DBX As IDbConnection = DB.Connection()
                Dim CMD As New HanaCommand(SQL, DBX)
                CMD.ExecuteNonQuery()
            End Using
            PostInventoryTransferRequest = True

        Catch ex As Exception
            PostInventoryTransferRequest = False
        End Try

    End Function

    'Posting Data
    'Material Issue / Afval Bahan Berdasarkan Unit Produksi dan Nomor WO
    'Menambah BDP
    Public Function PostMaterialIssue(Unit As String,
                                      NomorWO As String,
                                      Tanggal As Date,
                                      KodeItem As String,
                                      Qty As Double,
                                      KodeProduksi As String,
                                      NoTransaksi As String,
                                      Kodelokasi As String) As Boolean

        Try
            Dim DB As New SAPDBConnection("STAGINGDB")
            Dim WO As New SAPDBConnection

            Dim FG = New SAPWorkOrder().FindFGByWO(Unit, NomorWO)
            Dim RM = New SAPWorkOrder().FindRMByWO(Unit, NomorWO, KodeItem)

            Dim WOID As Long = RM.ID
            Dim FGID As Long = FG.POSID
            Dim RMID As Long = RM.POSID

            'Dim Kodelokasi As String = RM.KodeLokasi
            Dim NamaItem As String = RM.NamaItem
            Dim ManageBatch As String = If(KodeProduksi.Trim() = "", "N", "Y")

            Dim SQL As String

            Dim StockBatch As Double
            Dim QtyBahan As Double = Qty

            'Cek Stock Batch
            '-----------------------------------------------------------------------------------
            If KodeProduksi.Trim <> "" Then
                StockBatch = New SAPInventory().GetCurrentStock(Kodelokasi, KodeItem, KodeProduksi)

                'Jika stock kurang dari pemakaian aktual
                'Pemakaian bahan sebanyak sisa stock
                '---------------------------------------------------------------------------------------------
                If Qty > StockBatch Then
                    QtyBahan = StockBatch
                End If
            End If

            SQL = ""
            SQL += "INSERT INTO ""Staging_RM_Issue"" "
            SQL += "VALUES ("
            SQL += "SeqRMIssue.NEXTVAL, " + WOID.ToString + ", '" +
                                            NomorWO + "', '" +
                                            Tanggal.Date.ToString("yyyyMMdd") + "', " +
                                            FGID.ToString + ", " +
                                            RMID.ToString + ", '" +
                                            KodeItem + "', '" +
                                            NamaItem + "', '" +
                                            ManageBatch + "', " +
                                            QtyBahan.ToString + ", '" +
                                            UCase(KodeProduksi) + "', '" +
                                            Kodelokasi + "', '" +
                                            NoTransaksi + "', 'N'"
            SQL += ")"

            Using DBX As IDbConnection = DB.Connection()
                Dim CMD As New HanaCommand(SQL, DBX)
                CMD.ExecuteNonQuery()
            End Using
            PostMaterialIssue = True

        Catch ex As Exception
            PostMaterialIssue = False
        End Try

Jump:


    End Function



    'Posting Data
    'Material Receipt / Penerimaan Sisa Bahan Berdasarkan Unit Produksi dan Nomor WO
    'Mengurangi BDP
    Public Function PostMaterialReceipt(Unit As String,
                                        NomorWO As String,
                                        Tanggal As Date,
                                        KodeItem As String,
                                        Qty As Double,
                                        Timbang As Double,
                                        KodeProduksi As String,
                                        NoTransaksi As String,
                                        Kodelokasi As String) As Boolean

        Try
            Dim DB As New SAPDBConnection("STAGINGDB")
            Dim WO As New SAPDBConnection

            Dim FG = New SAPWorkOrder().FindFGByWO(Unit, NomorWO)
            Dim RM = New SAPWorkOrder().FindRMByWO(Unit, NomorWO, KodeItem)

            Dim WOID As Long = RM.ID
            Dim FGID As Long = FG.POSID
            Dim RMID As Long = RM.POSID

            'Dim Kodelokasi As String = RM.KodeLokasi
            Dim NamaItem As String = RM.NamaItem
            Dim ManageBatch As String = If(KodeProduksi.Trim() = "", "N", "Y")

            Dim SQL As String

            SQL = ""
            SQL += "INSERT INTO ""Staging_RM_Receipt"" "
            SQL += "VALUES ("
            SQL += "SeqRMReceipt.NEXTVAL, " + WOID.ToString + ", '" +
                                            NomorWO + "', '" +
                                            Tanggal.Date.ToString("yyyyMMdd") + "', " +
                                            FGID.ToString + ", " +
                                            RMID.ToString + ", '" +
                                            KodeItem + "', '" +
                                            NamaItem + "', '" +
                                            ManageBatch + "', " +
                                            Qty.ToString + ", '" +
                                            KodeProduksi + "', " +
                                            Timbang.ToString + ", '" +
                                            Kodelokasi + "', '" +
                                            NoTransaksi + "', 'N'"
            SQL += ")"

            Using DBX As IDbConnection = DB.Connection()
                Dim CMD As New HanaCommand(SQL, DBX)
                CMD.ExecuteNonQuery()
            End Using
            PostMaterialReceipt = True

        Catch ex As Exception
            PostMaterialReceipt = False
        End Try

    End Function

    'Posting Data
    'Afval Receipt / Penerimaan Afval Produksi Berdasarkan Unit Produksi dan Nomor WO    
    Public Function PostAfvalReceipt(Unit As String,
                                     NomorWO As String,
                                     Tanggal As Date,
                                     KodeItem As String,
                                     Timbang As Double,
                                     NoTransaksi As String,
                                     Kodelokasi As String) As Boolean

        Try
            Dim DB As New SAPDBConnection("STAGINGDB")
            Dim WO As New SAPDBConnection

            Dim FG = New SAPWorkOrder().FindFGByWO(Unit, NomorWO)
            Dim RM = New SAPWorkOrder().FindAfvalByWO(Unit, NomorWO, KodeItem)

            Dim WOID As Long = RM.ID
            Dim FGID As Long = FG.POSID
            Dim RMID As Long = RM.POSID

            'Dim Kodelokasi As String = RM.KodeLokasi
            Dim NamaItem As String = RM.NamaItem
            Dim ManageBatch As String = "N"
            Dim KodeProduksi = ""

            Dim SQL As String

            SQL = ""
            SQL += "INSERT INTO ""Staging_RM_Receipt"" "
            SQL += "VALUES ("
            SQL += "SeqRMReceipt.NEXTVAL, " + WOID.ToString + ", '" +
                                            NomorWO + "', '" +
                                            Tanggal.Date.ToString("yyyyMMdd") + "', " +
                                            FGID.ToString + ", " +
                                            RMID.ToString + ", '" +
                                            KodeItem + "', '" +
                                            NamaItem + "', '" +
                                            ManageBatch + "', " +
                                            Timbang.ToString + ", '" +
                                            KodeProduksi + "', " +
                                            Timbang.ToString + ", '" +
                                            Kodelokasi + "', '" +
                                            NoTransaksi + "', 'N'"
            SQL += ")"

            Using DBX As IDbConnection = DB.Connection()
                Dim CMD As New HanaCommand(SQL, DBX)
                CMD.ExecuteNonQuery()
            End Using
            PostAfvalReceipt = True

        Catch ex As Exception
            PostAfvalReceipt = False
        End Try

    End Function

    'Posting Data
    'Afval Receipt / Penerimaan Afval Produksi Berdasarkan Unit Produksi Tanpa Nomor WO
    Public Function PostAfvalReceiptWWO(Unit As String,
                                        Tanggal As Date,
                                        KodeItem As String,
                                        NamaItem As String,
                                        KodeLokasi As String,
                                        Timbang As Double,
                                        NoTransaksi As String) As Boolean

        Try
            Dim DB As New SAPDBConnection("STAGINGDB")
            Dim WO As New SAPDBConnection

            Dim ManageBatch As String = "N"
            Dim KodeProduksi = ""

            Dim SQL As String

            SQL = ""
            SQL += "INSERT INTO ""Staging_Receipt_AfvalWWO"" "
            SQL += "VALUES ("
            SQL += "SeqReceiptAfvalWWO.NEXTVAL, '" + Tanggal.Date.ToString("yyyyMMdd") + "', '" +
                                            KodeItem + "', '" +
                                            NamaItem + "', '" +
                                            ManageBatch + "', " +
                                            Timbang.ToString + ", '" +
                                            KodeProduksi + "', " +
                                            Timbang.ToString + ", '" +
                                            KodeLokasi + "', '" +
                                            NoTransaksi + "', 'N'"
            SQL += ")"

            Using DBX As IDbConnection = DB.Connection()
                Dim CMD As New HanaCommand(SQL, DBX)
                CMD.ExecuteNonQuery()
            End Using
            PostAfvalReceiptWWO = True

        Catch ex As Exception

            PostAfvalReceiptWWO = False
        End Try

    End Function

    'Posting Data
    'Finished Good Receipt / Penerimaan Hasil Produksi Berdasarkan Unit Produksi dan Nomor WO  
    'Mengurangi BDP
    Public Function PostFinishedGoodReceipt(Unit As String,
                                            NomorWO As String,
                                            Tanggal As Date,
                                            KodeItem As String,
                                            Qty As Double,
                                            Timbang As Double,
                                            KodeProduksi As String,
                                            KodeBatch As String,
                                            NoTransaksi As String,
                                            Kodelokasi As String) As Boolean

        Try
            Dim DB As New SAPDBConnection("STAGINGDB")
            Dim WO As New SAPDBConnection

            Dim FG = New SAPWorkOrder().FindFGByWO(Unit, NomorWO)

            Dim WOID As Long = FG.ID
            Dim FGID As Long = FG.POSID

            'Dim Kodelokasi As String = FG.KodeLokasi
            Dim NamaItem As String = FG.NamaItem
            Dim ManageBatch As String = If(KodeProduksi.Trim() = "", "N", "Y")

            Dim SQL As String

            SQL = ""
            SQL += "INSERT INTO ""Staging_FG_Receipt"" "
            SQL += "VALUES ("
            SQL += "SeqFGReceipt.NEXTVAL, " + WOID.ToString + ", '" +
                                            NomorWO + "', '" +
                                            Tanggal.Date.ToString("yyyyMMdd") + "', " +
                                            FGID.ToString + ", '" +
                                            KodeItem + "', '" +
                                            NamaItem + "', '" +
                                            ManageBatch + "', " +
                                            Qty.ToString + ", '" +
                                            KodeProduksi + "', '" +
                                            KodeBatch + "', " +
                                            Timbang.ToString + ", '" +
                                            Kodelokasi + "', '" +
                                            NoTransaksi + "', 'N'"
            SQL += ")"

            Using DBX As IDbConnection = DB.Connection()
                Dim CMD As New HanaCommand(SQL, DBX)
                CMD.ExecuteNonQuery()
            End Using
            PostFinishedGoodReceipt = True

        Catch ex As Exception
            PostFinishedGoodReceipt = False
        End Try

    End Function

    'Posting Data
    'Finished Good Issue / Retur Hasil Produksi Berdasarkan Unit Produksi dan Nomor WO    
    'Menambah BDP
    Public Function PostFinishedGoodIssue(Unit As String,
                                          NomorWO As String,
                                          Tanggal As Date,
                                          KodeItem As String,
                                          Qty As Double,
                                          Timbang As Double,
                                          KodeProduksi As String,
                                          KodeBatch As String,
                                          NoTransaksi As String,
                                          Kodelokasi As String) As Boolean

        Try
            Dim DB As New SAPDBConnection("STAGINGDB")
            Dim WO As New SAPDBConnection

            Dim FG = New SAPWorkOrder().FindFGByWO(Unit, NomorWO)

            Dim WOID As Long = FG.ID
            Dim FGID As Long = FG.POSID

            'Dim Kodelokasi As String = FG.KodeLokasi
            Dim NamaItem As String = FG.NamaItem
            Dim ManageBatch As String = If(KodeProduksi.Trim() = "", "N", "Y")

            Dim SQL As String

            SQL = ""
            SQL += "INSERT INTO ""Staging_FG_Issue"" "
            SQL += "VALUES ("
            SQL += "SeqFGIssue.NEXTVAL, " + WOID.ToString + ", '" +
                                            NomorWO + "', '" +
                                            Tanggal.Date.ToString("yyyyMMdd") + "', " +
                                            FGID.ToString + ", '" +
                                            KodeItem + "', '" +
                                            NamaItem + "', '" +
                                            ManageBatch + "', " +
                                            Qty.ToString + ", '" +
                                            KodeProduksi + "', '" +
                                            Kodelokasi + "', '" +
                                            NoTransaksi + "', 'N'"
            SQL += ")"

            Using DBX As IDbConnection = DB.Connection()
                Dim CMD As New HanaCommand(SQL, DBX)
                CMD.ExecuteNonQuery()
            End Using
            PostFinishedGoodIssue = True

        Catch ex As Exception
            PostFinishedGoodIssue = False
        End Try

    End Function

    'Posting Data Proses Sortir
    Public Function DirectProcess(Tanggal As Date,
                                  KodeItem As String,
                                  NamaItem As String,
                                  KodeLokasi As String,
                                  Timbang As Double,
                                  NoTransaksi As String) As Boolean

        Try

            Dim DB As New SAPDBConnection("STAGINGDB")

            '---------------------------------------------------------------------------------------------
            'Baca Data Item BOM
            '---------------------------------------------------------------------------------------------
            Dim BOM As New SAPDBConnection
            Dim DT As DataTable = New SAPWorkOrder().ReadItemBOM(KodeItem).Tables("View")
            Dim DR As DataRow
            If DT.Rows.Count > 0 Then

                DR = DT.Rows(0)
                Dim RMKodeItem As String = DR("RMKodeItem")
                Dim RMNamaItem As String = DR("RMNamaItem")

                Dim RMID As Long = DR("RMPos")
                Dim FGID As Long = 10
                '---------------------------------------------------------------------------------------------

                Dim ManageBatch As String = "N"
                Dim KodeProduksi = ""

                Dim SQL As String

                Dim StockAfval As Double
                Dim TimbangBahan As Double = Timbang

                'Cek Stock Afval
                '---------------------------------------------------------------------------------------------

                StockAfval = New SAPInventory().GetCurrentStock(KodeLokasi, RMKodeItem, KodeProduksi)

                'Jika stock kurang dari hasil
                'Pemakaian bahan sebanyak sisa
                '---------------------------------------------------------------------------------------------
                If Timbang > StockAfval Then
                    TimbangBahan = Math.Abs(StockAfval)
                End If

                '---------------------------------------------------------------------------------------------
                'Bahan Produksi
                '---------------------------------------------------------------------------------------------
                SQL = ""
                SQL += "INSERT INTO ""Staging_Recycle_Issue"" "
                SQL += "VALUES ("
                SQL += "SeqRecycleIssue.NEXTVAL, '" + Tanggal.Date.ToString("yyyyMMdd") + "', " +
                                                FGID.ToString() + ", " +
                                                RMID.ToString() + ", '" +
                                                RMKodeItem + "', '" +
                                                RMNamaItem + "', '" +
                                                ManageBatch + "', " +
                                                TimbangBahan.ToString + ", '" +
                                                KodeProduksi + "', '" +
                                                KodeLokasi + "', '" +
                                                NoTransaksi + "', 'N'"
                SQL += ")"

                Using DBX As IDbConnection = DB.Connection()
                    Dim CMD As New HanaCommand(SQL, DBX)
                    CMD.ExecuteNonQuery()
                End Using
                '---------------------------------------------------------------------------------------------

                '---------------------------------------------------------------------------------------------
                'Hasil Produksi
                '---------------------------------------------------------------------------------------------
                SQL = ""
                SQL += "INSERT INTO ""Staging_Recycle_Receipt"" "
                SQL += "VALUES ("
                SQL += "SeqRecycleReceipt.NEXTVAL, '" + Tanggal.Date.ToString("yyyyMMdd") + "', " + FGID.ToString() + ", '" +
                                                KodeItem + "', '" +
                                                NamaItem + "', '" +
                                                ManageBatch + "', " +
                                                Timbang.ToString + ", '" +
                                                KodeProduksi + "', " +
                                                Timbang.ToString + ", '" +
                                                KodeLokasi + "', '" +
                                                NoTransaksi + "', 'N'"
                SQL += ")"

                Using DBX As IDbConnection = DB.Connection()
                    Dim CMD As New HanaCommand(SQL, DBX)
                    CMD.ExecuteNonQuery()
                End Using
                '---------------------------------------------------------------------------------------------

            End If

            DirectProcess = True

        Catch ex As Exception
            MsgBox(ex.ToString)
            DirectProcess = False
        End Try

    End Function

    Public Function Read(ByVal Tanggal As Date, Transaksi As enumTransaksiStaging) As DataSet
        Dim DB As New SAPDBConnection("STAGINGDB")
        Dim SQL As String = ""

        Select Case Transaksi
            Case enumTransaksiStaging.HasilExtruder
                SQL += "SELECT " +
                              "         ""WO_Number""       AS ""NomorWO"", " +
                              "         CAST(SUM(""Quantity"") AS DOUBLE)   AS ""Qty"" " +
                              "FROM     ""Staging_FG_Receipt"" " +
                              "WHERE    ""DocDate""='" + Tanggal.Date.ToString("yyyyMMdd") + "' AND LEFT(""Ref"",4)='EXHP' " +
                              "GROUP BY ""WO_Number"" ORDER BY ""WO_Number"" "

            Case enumTransaksiStaging.PemakaianBahanCLoom
                SQL += "SELECT " +
                              "         ""WO_Number""       AS ""NomorWO"", " +
                              "         CAST(SUM(""Quantity"") AS DOUBLE)   AS ""Qty"" " +
                              "FROM     ""Staging_RM_Issue"" " +
                              "WHERE    ""DocDate""='" + Tanggal.Date.ToString("yyyyMMdd") + "' AND LEFT(""Ref"",4)='EXTK' " +
                              "GROUP BY ""WO_Number"" ORDER BY ""WO_Number"" "
        End Select

        Using DBX As IDbConnection = DB.Connection()

            Dim CMD As New HanaCommand(SQL, DBX)
            Dim DA As New HanaDataAdapter
            Dim DS As New DataSet

            DA.SelectCommand = CMD
            DA.Fill(DS, "View")

            Read = DS
        End Using
    End Function

    Public Function ReadSAPExtruder(ByVal Tanggal As Date)
        Dim DB As New SAPDBConnection
        Dim SQL As String

        SQL = "SELECT " +
                    "X.""AUFTRAG""                                AS ""NomorWO"", " +
                    "CAST(SUM(X.""Hasil"") as DOUBLE)             AS ""Qty"" " +
              "FROM RECAP_PRODUKSI X " +
              "INNER JOIN BEAS_FTPOS Y ON X.""BELNR_ID"" = Y.""BELNR_ID"" AND X.""BELPOS_ID"" = Y.""BELPOS_ID"" " +
              "INNER JOIN OITM Z ON Y.""ItemCode"" = Z.""ItemCode"" " +
              "LEFT JOIN BEAS_FTAPL Z1 ON Z1.""BELNR_ID"" = Y.""BELNR_ID"" AND Z1.""BELPOS_ID"" = Y.""BELPOS_ID"" AND Z1.""AGTYP"" ='operation' " +
              "LEFT JOIN BEAS_APLATZ Z2 ON Z1.""APLATZ_ID"" = Z2.""APLATZ_ID"" " +
              "WHERE X.""DocDate"" ='" + Tanggal.Date.ToString("yyyyMMdd") + "' AND Z.""U_SOL_ROUTING"" = 'EXTRUDER' " +
              "GROUP BY X.""AUFTRAG"" " +
              "ORDER BY X.""AUFTRAG"" "

        Using DBX As IDbConnection = DB.Connection()

            Dim CMD As New HanaCommand(SQL, DBX)
            Dim DA As New HanaDataAdapter
            Dim DS As New DataSet

            DA.SelectCommand = CMD
            DA.Fill(DS, "View")

            ReadSAPExtruder = DS
        End Using
    End Function

    Public Function GetStagingFGReceipt(ByVal NoTransaksi As String) As FGReceipt
        Dim DB As New SAPDBConnection("STAGINGDB_LIVE")
        Dim SQL As String

        SQL = "SELECT ""Ref"", ""ItemCode"", ""ItemName"", ""Batch"", ""Warehouse"", CAST(""Quantity"" AS DOUBLE) AS ""Quantity""  " +
              "FROM ""Staging_FG_Receipt"" " +
              "WHERE ""Ref""='" + NoTransaksi + "' "

        Using DBX As IDbConnection = DB.Connection()
            Dim CMD As New HanaCommand(SQL, DBX)
            Dim DR As HanaDataReader = CMD.ExecuteReader()
            Dim Temp As FGReceipt = Nothing

            If DR.Read() Then
                Temp = New FGReceipt()
                Temp.NoTransaksi = DR("Ref")
                Temp.KodeProduksi = DR("Batch")
                Temp.KodeItem = DR("ItemCode")
                Temp.NamaItem = DR("ItemName")
                Temp.Lokasi = DR("Warehouse")
                Temp.Quantity = DR("Quantity")
            End If

            DR.Close()

            GetStagingFGReceipt = Temp
        End Using
    End Function

    Public Function GetStagingRecycleReceipt(ByVal NoTransaksi As String) As FGReceipt
        Dim DB As New SAPDBConnection("STAGINGDB_LIVE")
        Dim SQL As String

        SQL = "SELECT ""Ref"", ""ItemCode"", ""ItemName"", ""Warehouse"", CAST(""Quantity"" AS DOUBLE) AS ""Quantity""  " +
              "FROM ""Staging_Recycle_Receipt"" " +
              "WHERE ""Ref""='" + NoTransaksi + "' "

        Using DBX As IDbConnection = DB.Connection()
            Dim CMD As New HanaCommand(SQL, DBX)
            Dim DR As HanaDataReader = CMD.ExecuteReader()
            Dim Temp As FGReceipt = Nothing

            If DR.Read() Then
                Temp = New FGReceipt()
                Temp.NoTransaksi = DR("Ref")
                Temp.KodeProduksi = ""
                Temp.KodeItem = DR("ItemCode")
                Temp.NamaItem = DR("ItemName")
                Temp.Lokasi = DR("Warehouse")
                Temp.Quantity = DR("Quantity")
            End If

            DR.Close()

            GetStagingRecycleReceipt = Temp
        End Using
    End Function

    Public Function GetStagingInvTransfer(ByVal NoTransaksi As String) As InvTransfer
        Dim DB As New SAPDBConnection("STAGINGDB_LIVE")
        Dim SQL As String

        SQL = "SELECT ""Ref"", ""ItemCode"", ""ItemName"", ""WhsFrom"", ""WhsTo"", SUM(CAST(""Quantity"" AS DOUBLE)) AS ""Quantity""  " +
              "FROM ""Staging_InvTransfer"" " +
              "WHERE ""Ref""='" + NoTransaksi + "' " +
              "GROUP BY ""Ref"", ""ItemCode"", ""ItemName"", ""WhsFrom"", ""WhsTo"" "

        Using DBX As IDbConnection = DB.Connection()
            Dim CMD As New HanaCommand(SQL, DBX)
            Dim DR As HanaDataReader = CMD.ExecuteReader()
            Dim Temp As InvTransfer = Nothing

            If DR.Read() Then
                Temp = New InvTransfer()
                Temp.NoTransaksi = DR("Ref")
                Temp.KodeItem = DR("ItemCode")
                Temp.NamaItem = DR("ItemName")
                Temp.LokasiAsal = DR("WhsFrom")
                Temp.LokasiTujuan = DR("WhsTo")
                Temp.Quantity = DR("Quantity")
            End If

            DR.Close()

            GetStagingInvTransfer = Temp
        End Using
    End Function

    Public Function UpdateStagingFGReceipt(ByVal NoTransaksi As String)
        Dim DB As New SAPDBConnection("STAGINGDB_LIVE")
        Dim SQL As String

        SQL = "UPDATE ""Staging_FG_Receipt"" SET " +
              " ""Imported""='N' " +
              "WHERE ""Ref""='" + NoTransaksi + "' "

        Using DBX As IDbConnection = DB.Connection()
            Dim CMD As New HanaCommand(SQL, DBX)
            CMD.ExecuteNonQuery()
        End Using
    End Function

    Public Function UpdateStagingFGIssue(ByVal NoTransaksi As String)
        Dim DB As New SAPDBConnection("STAGINGDB_LIVE")
        Dim SQL As String

        SQL = "UPDATE ""Staging_FG_Issue"" SET " +
              " ""Imported""='N' " +
              "WHERE ""Ref""='" + NoTransaksi + "' "

        Using DBX As IDbConnection = DB.Connection()
            Dim CMD As New HanaCommand(SQL, DBX)
            CMD.ExecuteNonQuery()
        End Using
    End Function

    Public Function UpdateStagingRecycleReceipt(ByVal NoTransaksi As String)
        Dim DB As New SAPDBConnection("STAGINGDB_LIVE")
        Dim SQL As String

        SQL = "UPDATE ""Staging_Recycle_Receipt"" SET " +
              " ""Imported""='N' " +
              "WHERE ""Ref""='" + NoTransaksi + "' "

        Using DBX As IDbConnection = DB.Connection()
            Dim CMD As New HanaCommand(SQL, DBX)
            CMD.ExecuteNonQuery()
        End Using
    End Function

    Public Function UpdateStagingInvTransfer(ByVal NoTransaksi As String)
        Dim DB As New SAPDBConnection("STAGINGDB_LIVE")
        Dim SQL As String

        SQL = "UPDATE ""Staging_InvTransfer"" SET " +
              " ""Imported""='N' " +
              "WHERE ""Ref""='" + NoTransaksi + "' "

        Using DBX As IDbConnection = DB.Connection()
            Dim CMD As New HanaCommand(SQL, DBX)
            CMD.ExecuteNonQuery()
        End Using
    End Function

    Public Function UpdateStagingRMIssue(ByVal NoTransaksi As String)
        Dim DB As New SAPDBConnection("STAGINGDB_LIVE")
        Dim SQL As String

        SQL = "UPDATE ""Staging_RM_Issue"" SET " +
              " ""Imported""='N' " +
              "WHERE ""Ref""='" + NoTransaksi + "' "

        Using DBX As IDbConnection = DB.Connection()
            Dim CMD As New HanaCommand(SQL, DBX)
            CMD.ExecuteNonQuery()
        End Using
    End Function

    Public Function UpdateStagingRMReceipt(ByVal NoTransaksi As String)
        Dim DB As New SAPDBConnection("STAGINGDB_LIVE")
        Dim SQL As String

        SQL = "UPDATE ""Staging_RM_Receipt"" SET " +
              " ""Imported""='N' " +
              "WHERE ""Ref""='" + NoTransaksi + "' "

        Using DBX As IDbConnection = DB.Connection()
            Dim CMD As New HanaCommand(SQL, DBX)
            CMD.ExecuteNonQuery()
        End Using
    End Function

    Public Function RemoveStagingData(ByVal NoTransaksi As String) As Integer
        Dim DB As New SAPDBConnection("STAGINGDB_LIVE")
        Dim SQL As String

        SQL = "DELETE FROM ""Staging_RM_Issue"" " +
              "WHERE ""Ref""='" + NoTransaksi + "' ;"

        SQL += "DELETE FROM ""Staging_FG_Receipt"" " +
               "WHERE ""Ref""='" + NoTransaksi + "' ;"

        SQL += "DELETE FROM ""Staging_FG_Issue"" " +
               "WHERE ""Ref""='" + NoTransaksi + "' ;"

        SQL += "DELETE FROM ""Staging_RM_Receipt"" " +
               "WHERE ""Ref""='" + NoTransaksi + "' ;"

        SQL += "DELETE FROM ""Staging_InvTransfer"" " +
               "WHERE ""Ref""='" + NoTransaksi + "' ;"

        SQL += "DELETE FROM ""Staging_Receipt_AfvalWWO"" " +
               "WHERE ""Ref""='" + NoTransaksi + "' ;"

        SQL += "DELETE FROM ""Staging_InvTransferReq"" " +
               "WHERE ""Ref""='" + NoTransaksi + "' ;"

        SQL += "DELETE FROM ""Staging_Recycle_Receipt"" " +
               "WHERE ""Ref""='" + NoTransaksi + "' ;"

        Using DBX As IDbConnection = DB.Connection()
            Dim CMD As New HanaCommand(SQL, DBX)
            CMD.ExecuteNonQuery()
        End Using
    End Function

    Public Function ReadStagingFGReceiptRoll(ByVal Tanggal As Date) As DataSet
        Dim DB As New SAPDBConnection("STAGINGDB_LIVE")
        Dim SQL As String = ""

        SQL += "SELECT " +
               " A.""Ref""                           AS ""NoTransaksi"", " +
               " A.""DocDate""                       AS ""TglTransaksi"", " +
               " B.""ImportedTime""                  AS ""TglTimbang"", " +
               " A.""WO_Number""                     AS ""NomorWO"", " +
               " A.""ItemCode""                      AS ""KodeItem"", " +
               " A.""ItemName""                      AS ""NamaItem"", " +
               " 1                                   AS ""KodeShift"", " +
               " 'A'                                 AS ""KodeGrup"", " +
               " CASE WHEN LEFT(A.""ItemCode"",3)='302' THEN " +
               " '002' " +
               " WHEN LEFT(A.""ItemCode"",3)='303' THEN " +
               " '003' " +
               " WHEN LEFT(A.""ItemCode"",3)='304' THEN " +
               " '004' " +
               " WHEN LEFT(A.""ItemCode"",3)='305' THEN " +
               " '013' END                           AS ""KodeUnit"", " +
               " '003'                               AS ""KodeUnitPeruntukan"", " +
               " SUBSTRING(A.""Batch"",9,4)          AS ""KodeMesin"", " +
               " A.""Warehouse""                     AS ""KodeLokasi"", " +
               " A.""Batch""                         AS ""KodeProduksi"", " +
               " A.""BatchWeight""                   AS ""Berat"", " +
               " IFNULL(A.""Quantity"",0)            AS ""PanjangRoll"", " +
               " IFNULL(C.""Quantity"",0)            AS ""Pakai"", " +
               " IFNULL(A.""Quantity"",0)-IFNULL(C.""Quantity"",0)   AS ""Sisa"" " +
               " FROM ""Staging_FG_Receipt"" A " +
               " LEFT JOIN ""Staging_LOG"" B ON B.""EntryNo"" = A.""EntryNo"" " +
               " LEFT JOIN ""Staging_RM_Issue"" C ON C.""Batch"" = A.""Batch"" " +
               " WHERE B.""TransType""='FGR' AND A.""Batch""<>'' AND LEFT(A.""ItemCode"",1)<>'4' AND A.""DocDate"" = '" + Tanggal.Date.ToString("yyyyMMdd") + "' "

        Using DBX As IDbConnection = DB.Connection()

            Dim CMD As New HanaCommand(SQL, DBX)
            Dim DA As New HanaDataAdapter
            Dim DS As New DataSet

            DA.SelectCommand = CMD
            DA.Fill(DS, "View")

            ReadStagingFGReceiptRoll = DS
        End Using
    End Function

    Public Function ReadStagingFGReceiptBall(ByVal Tanggal As Date) As DataSet
        Dim DB As New SAPDBConnection("STAGINGDB_LIVE")
        Dim SQL As String = ""

        SQL += "SELECT " +
               " CASE WHEN LEFT(A.""Ref"",4)='PFBK' THEN " +
               " 1 ELSE 2 END                        AS ""Kelompok"", " +
               " A.""Ref""                           AS ""NoTransaksi"", " +
               " A.""DocDate""                       AS ""TglTransaksi"", " +
               " B.""ImportedTime""                  AS ""TglTimbang"", " +
               " A.""WO_Number""                     AS ""NomorWO"", " +
               " A.""ItemCode""                      AS ""KodeItem"", " +
               " A.""ItemName""                      AS ""NamaItem"", " +
               " 1                                   AS ""KodeShift"", " +
               " 'A'                                 AS ""KodeGrup"", " +
               " CASE WHEN LEFT(A.""Ref"",4)='PFBK' THEN " +
               " '011' ELSE '012' END                AS ""KodeUnit"", " +
               " '003'                               AS ""KodeUnitPeruntukan"", " +
               " SUBSTRING(A.""Batch"",9,4)          AS ""KodeMesin"", " +
               " A.""Warehouse""                     AS ""KodeLokasi"", " +
               " A.""Batch""                         AS ""KodeProduksi"", " +
               " A.""BatchWeight""                   AS ""Berat"", " +
               " IFNULL(A.""Quantity"",0)            AS ""Pcs"", " +
               " IFNULL(C.""Quantity"",0)            AS ""Pakai"", " +
               " IFNULL(A.""Quantity"",0)-IFNULL(C.""Quantity"",0)   AS ""Sisa"" " +
               " FROM ""Staging_FG_Receipt"" A " +
               " LEFT JOIN ""Staging_LOG"" B ON B.""EntryNo"" = A.""EntryNo"" " +
               " LEFT JOIN ""Staging_InvTransfer"" C ON C.""Batch"" = A.""Batch"" " +
               " WHERE B.""TransType""='FGR' AND A.""Batch""<>'' AND LEFT(A.""ItemCode"",1)='4' AND LEFT(A.""Batch"",1)='4' AND A.""DocDate"" = '" + Tanggal.Date.ToString("yyyyMMdd") + "' "

        Using DBX As IDbConnection = DB.Connection()

            Dim CMD As New HanaCommand(SQL, DBX)
            Dim DA As New HanaDataAdapter
            Dim DS As New DataSet

            DA.SelectCommand = CMD
            DA.Fill(DS, "View")

            ReadStagingFGReceiptBall = DS
        End Using
    End Function
End Class
