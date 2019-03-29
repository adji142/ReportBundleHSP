Imports Sap.Data.Hana
Imports HSPProduction.HSP.Data

'Class FGWorkOrder
'Data-Data Detail Finished Good Pada Work Order
Public Class FGWorkOrder
    Public Property ID As Long
    Public Property POSID As Long
    Public Property NomorWO As String
    Public Property Tanggal As Date
    Public Property KodeItem As String
    Public Property NamaItem As String
    Public Property QtyBOM As Double
    Public Property Satuan As String
    Public Property KodeLokasi As String

    Public Property Denier As Double
    Public Property Lebar As Double
    Public Property MeshPakan As Double
    Public Property MeshLusi As Double
    Public Property PanjangPotongCutting As Double
    Public Property PanjangPotongPrinting As Double
    Public Property BeratStandar As Double
    Public Property Closing As String

End Class

'Class RMWorkOrder
'Data-Data Detail Raw Material Pada Work Order
Public Class RMWorkOrder
    Public Property ID As Long
    Public Property POSID As Long
    Public Property NomorWO As String
    Public Property KodeItem As String
    Public Property NamaItem As String
    Public Property QtyBOM As Double
    Public Property QtyKebutuhan As Double
    Public Property Satuan As String
    Public Property KodeLokasi As String
    Public Property Rounting As String
End Class

Public Class RMProyeksiLoom
    Public Property Nomor As String
    Public Property Proyeksi As Double
    Public Property Prosentase As Double
    Public Property Kebutuhan As Double
End Class

'Class AfvalWorkOrder
'Data-Data Detail Afval Produksi Pada Work Order
Public Class AfvalWorkOrder
    Public Property ID As Long
    Public Property POSID As Long
    Public Property NomorWO As String
    Public Property KodeItem As String
    Public Property NamaItem As String
    Public Property QtyBOM As Double
    Public Property Satuan As String
    Public Property KodeLokasi As String
End Class

Public Class Extruder
    Public Property NomorWO As String
    Public Property KodeMesin As String
End Class

Public Class DataWorkOrder
    Public Property NomorWo As String
    Public Property TglMulai As DateTime
    Public Property TglSelesai As DateTime
    Public Property KodeItem As String
    Public Property NamaItem As String
    Public Property QtyPlan As Double
    Public Property Satuan As String
    Public Property Unit As String
    Public Property StatusWO As String
End Class

Public Class SAPWorkOrder : Implements IDataLookup

    Public Enum enumLookupWorkOrder
        woDaftarFGAktif = 1
        woDaftarRMAktif = 2
        woDaftarFGAktifByMesin = 3
        woDaftarRMAktifByWO = 4
        woDaftarFGAktifAll = 5
    End Enum

    'Read 
    'Daftar Work Order Aktif Berdasarkan Tanggal Dan Unit Produksi Tertentu 
    Public Function ReadFGWorkOrderByUnit(Unit As String, Tanggal As Date) As DataSet
        Dim DB As New SAPDBConnection
        Dim SQL As String

        SQL = "SELECT DISTINCT " +
              " ""WO_Number""           AS ""Nomor"", " +
              " ""WO_Date""             AS ""Tanggal"", " +
              " ""FG_ItemCode""         AS ""Kode Item"", " +
              " ""FG_ItemName""         AS ""Nama Item"" " +
              "FROM ""SOL_WO_BOM"" " +
              "WHERE ""FG_POS_Closed"" = 'N' AND ""WO_TYPE"" = '" + Unit + "' AND CAST(""WO_Date"" AS DATE) <= '" + Tanggal.Date.ToString("yyyyMMdd") + "' "

        Using DBX As IDbConnection = DB.Connection()

            Dim CMD As New HanaCommand(SQL, DBX)
            Dim DA As New HanaDataAdapter
            Dim DS As New DataSet

            'CMD.Parameters.AddWithValue("@WO_TYPE", Unit)
            DA.SelectCommand = CMD
            DA.Fill(DS, "View")

            ReadFGWorkOrderByUnit = DS
        End Using

    End Function

    'Read 
    'Daftar Work Order Aktif Berdasarkan Unit Produksi Tertentu 
    Public Function ReadFGWorkOrderByUnit(Unit As String) As DataSet
        Dim DB As New SAPDBConnection
        Dim SQL As String

        SQL = "SELECT DISTINCT " +
              " ""WO_Number""           AS ""Nomor"", " +
              " ""WO_Date""             AS ""Tanggal"", " +
              " ""FG_ItemCode""         AS ""Kode Item"", " +
              " ""FG_ItemName""         AS ""Nama Item"" " +
              "FROM ""SOL_WO_BOM"" " +
              "WHERE ""WO_TYPE"" = '" + Unit + "' AND CAST(""WO_Date"" AS DATE) <= '" + Now.Date.ToString("yyyyMMdd") + "' ORDER BY ""WO_Number"" "

        Using DBX As IDbConnection = DB.Connection()

            Dim CMD As New HanaCommand(SQL, DBX)
            Dim DA As New HanaDataAdapter
            Dim DS As New DataSet

            DA.SelectCommand = CMD
            DA.Fill(DS, "View")

            ReadFGWorkOrderByUnit = DS
        End Using

    End Function

    'Read 
    'Daftar Work Order Aktif Berdasarkan Unit Produksi Tertentu 
    Public Function ReadFGWorkOrderByUnitEx(Unit As String) As DataSet
        Dim DB As New SAPDBConnection
        Dim SQL As String

        SQL = "SELECT DISTINCT " +
              " ""WO_Number""           AS ""Nomor"", " +
              " ""WO_Date""             AS ""Tanggal"", " +
              " ""FG_ItemCode""         AS ""Kode Item"", " +
              " ""FG_ItemName""         AS ""Nama Item"" " +
              "FROM ""SOL_WO_BOM"" " +
              "WHERE ""WO_TYPE"" = '" + Unit + "'  ORDER BY ""WO_Number"" "

        Using DBX As IDbConnection = DB.Connection()

            Dim CMD As New HanaCommand(SQL, DBX)
            Dim DA As New HanaDataAdapter
            Dim DS As New DataSet

            DA.SelectCommand = CMD
            DA.Fill(DS, "View")

            ReadFGWorkOrderByUnitEx = DS
        End Using

    End Function


    'Read 
    'Daftar Work Order Aktif Berdasarkan Tanggal Dan Unit Produksi Tertentu 
    Public Function ReadFGWorkOrderByUnit(Unit As String, Tanggal As Date, KodeMesin As String) As DataSet
        Dim DB As New SAPDBConnection
        Dim SQL As String

        SQL = "SELECT DISTINCT " +
              " ""WO_Number""           AS ""Nomor"", " +
              " ""WO_Date""             AS ""Tanggal"", " +
              " ""FG_ItemCode""         AS ""Kode Item"", " +
              " ""FG_ItemName""         AS ""Nama Item"" " +
              "FROM ""SOL_WO_MACHINE"" " +
              "WHERE ""FG_POS_Closed"" = 'N' AND ""WO_TYPE"" = '" + Unit + "' AND CAST(""WO_Date"" AS DATE) <= '" + Tanggal.Date.ToString("yyyyMMdd") + "' AND ""WO_MACHINE""='" & KodeMesin & "' "

        Using DBX As IDbConnection = DB.Connection()

            Dim CMD As New HanaCommand(SQL, DBX)
            Dim DA As New HanaDataAdapter
            Dim DS As New DataSet

            'CMD.Parameters.AddWithValue("@WO_TYPE", Unit)
            DA.SelectCommand = CMD
            DA.Fill(DS, "View")

            ReadFGWorkOrderByUnit = DS
        End Using

    End Function

    'Read 
    'Daftar Work Order Aktif Berdasarkan Item Material dan Tanggal 
    'Khusus untuk Loom
    Public Function ReadRMWorkOrderLoomByItem(KodeItem As String, Tanggal As Date) As List(Of RMWorkOrder)
        Dim DB As New SAPDBConnection

        Using DBX As IDbConnection = DB.Connection()

            Dim CMD As New HanaCommand("", DBX)

            CMD.CommandType = CommandType.StoredProcedure
            CMD.CommandText = "SOL_CLOOM_RM_USAGE"
            CMD.Parameters.AddWithValue("@RM_ItemCode", KodeItem)
            CMD.Parameters.AddWithValue("@DateParam", Tanggal.Date)

            Dim DR As HanaDataReader = CMD.ExecuteReader()
            Dim DaftarWO As New List(Of RMWorkOrder)()
            Dim WO As RMWorkOrder
            While DR.Read()

                WO = New RMWorkOrder
                WO.ID = DR("WO_ID")
                WO.POSID = DR("RM_POS_ID")
                WO.NomorWO = DR("WO_NUM")
                WO.KodeItem = DR("RM_ItemCode")
                WO.NamaItem = DR("RM_ItemName")
                WO.QtyBOM = DR("RM_Quantity").ToString
                WO.QtyKebutuhan = DR("RM_PredictedQty").ToString
                WO.Satuan = DR("RM_UOM")
                WO.KodeLokasi = DR("RM_WhsCode")
                DaftarWO.Add(WO)

            End While

            ReadRMWorkOrderLoomByItem = DaftarWO
        End Using

    End Function

    'Read 
    'Daftar Raw Material Pada Work Order Berdasarkan Nomor WO
    Public Function ReadRMByWO(NomorWO As String, KodeUnitSAP As String) As DataSet
        Dim DB As New SAPDBConnection
        Dim SQL As String

        SQL = "SELECT DISTINCT " +
              " ""WO_ID""               AS ""ID"", " +
              " ""WO_Number""           AS ""Nomor"", " +
              " ""WO_Date""             AS ""Tanggal"", " +
              " ""RM_ItemCode""         AS ""Kode Item"", " +
              " ""RM_ItemName""         AS ""Nama Item"", " +
              " ""RM_Quantity""         AS ""Qty"", " +
              " ""RM_UoM""              AS ""Satuan"" " +
              "FROM SOL_WO_BOM " +
              "WHERE ""RM_IssueMethod"" = 'M' AND ""FG_POS_Closed"" = 'N' AND ""RM_Quantity"" > 0 AND ""WO_Number"" = '" + NomorWO + "' AND  ""WO_TYPE"" = '" + KodeUnitSAP + "' ORDER BY ""RM_Quantity"" DESC "

        Using DBX As IDbConnection = DB.Connection()

            Dim CMD As New HanaCommand(SQL, DBX)
            Dim DA As New HanaDataAdapter
            Dim DS As New DataSet

            'CMD.Parameters.AddWithValue("@WO_TYPE", Unit)
            DA.SelectCommand = CMD
            DA.Fill(DS, "View")

            ReadRMByWO = DS
        End Using

    End Function

    'Read 
    'Daftar Raw Material Pada Work Order Berdasarkan Nomor WO
    Public Function ReadRMByWOBackFlush(NomorWO As String, KodeUnitSAP As String) As DataSet
        Dim DB As New SAPDBConnection
        Dim SQL As String

        SQL = "SELECT DISTINCT " +
              " ""WO_ID""               AS ""ID"", " +
              " ""WO_Number""           AS ""Nomor"", " +
              " ""WO_Date""             AS ""Tanggal"", " +
              " ""RM_ItemCode""         AS ""Kode Item"", " +
              " ""RM_ItemName""         AS ""Nama Item"", " +
              " ""RM_Quantity""         AS ""Qty"", " +
              " ""RM_UoM""              AS ""Satuan"" " +
              "FROM SOL_WO_BOM " +
              "WHERE ""RM_IssueMethod"" = 'B' AND ""FG_POS_Closed"" = 'N' AND ""RM_Quantity"" > 0 AND ""WO_Number"" = '" + NomorWO + "' AND  ""WO_TYPE"" = '" + KodeUnitSAP + "' ORDER BY ""RM_Quantity"" DESC "

        Using DBX As IDbConnection = DB.Connection()

            Dim CMD As New HanaCommand(SQL, DBX)
            Dim DA As New HanaDataAdapter
            Dim DS As New DataSet

            'CMD.Parameters.AddWithValue("@WO_TYPE", Unit)
            DA.SelectCommand = CMD
            DA.Fill(DS, "View")

            ReadRMByWOBackFlush = DS
        End Using

    End Function

    Public Function ReadRMByWONonBatch(NomorWO As String, KodeUnitSAP As String, Optional ByRef Batch As Boolean = False) As DataSet
        Dim DB As New SAPDBConnection
        Dim SQL As String

        SQL = "SELECT DISTINCT " +
              " ""WO_ID""               AS ""ID"", " +
              " ""WO_Number""           AS ""Nomor"", " +
              " ""WO_Date""             AS ""Tanggal"", " +
              " ""RM_ItemCode""         AS ""Kode Item"", " +
              " ""RM_ItemName""         AS ""Nama Item"", " +
              " ""RM_Quantity""         AS ""Qty"", " +
              " ""RM_UoM""              AS ""Satuan"" " +
              "FROM SOL_WO_BOM " +
              "WHERE ""RM_IssueMethod"" = 'M' AND ""FG_POS_Closed"" = 'N' AND ""RM_Quantity"" > 0 AND ""WO_Number"" = '" + NomorWO + "' AND  ""WO_TYPE"" = '" + KodeUnitSAP + "' "

        If Batch = False Then
            SQL += " AND ""RM_ManageBatch""='N' "
        End If

        SQL += " ORDER BY ""RM_Quantity"" DESC "

        Using DBX As IDbConnection = DB.Connection()

            Dim CMD As New HanaCommand(SQL, DBX)
            Dim DA As New HanaDataAdapter
            Dim DS As New DataSet

            'CMD.Parameters.AddWithValue("@WO_TYPE", Unit)
            DA.SelectCommand = CMD
            DA.Fill(DS, "View")

            ReadRMByWONonBatch = DS
        End Using

    End Function

    'Read 
    'Daftar Item BDP Berdasarkkan Nomor WO
    Public Function ReadWIPByWO(NomorWO As String, KodeUnitSAP As String) As DataSet
        Dim DB As New SAPDBConnection
        Dim SQL As String

        SQL = "SELECT * " +
              "FROM HSP_TRANSFER_BDP " +
              "WHERE ""NomorWO"" = '" + NomorWO + "' AND ""UnitProduksi"" = '" + KodeUnitSAP + "' ORDER BY ""RMKodeItem"" "

        Using DBX As IDbConnection = DB.Connection()

            Dim CMD As New HanaCommand(SQL, DBX)
            Dim DA As New HanaDataAdapter
            Dim DS As New DataSet

            DA.SelectCommand = CMD
            DA.Fill(DS, "View")

            ReadWIPByWO = DS
        End Using

    End Function

    'Read 
    'Daftar BOM Berdasarkan Kode Item Barang Jadi
    Public Function ReadItemBOM(KodeItem As String) As DataSet
        Dim DB As New SAPDBConnection
        Dim SQL As String

        SQL = "SELECT DISTINCT " +
              " ""FG_ItemCode""         AS ""FGKodeItem"", " +
              " ""FG_ItemName""         AS ""FGNamaItem"", " +
              " ""FG_Qty""              AS ""FGQty"", " +
              " ""FG_UoM""              AS ""FGSatuan"", " +
              " ""RM_POS""              AS ""RMPos"", " +
              " ""RM_ItemCode""         AS ""RMKodeItem"", " +
              " ""RM_ItemName""         AS ""RMNamaItem"", " +
              " ""RM_IssueMethod""      AS ""RMMetoda"", " +
              " ""RM_Qty""              AS ""RMQty"", " +
              " ""RM_UoM""              AS ""RMSatuan"" " +
              "FROM SOL_ITEMBOM " +
              "WHERE ""FG_ItemCode"" = '" + KodeItem + "' "

        Using DBX As IDbConnection = DB.Connection()

            Dim CMD As New HanaCommand(SQL, DBX)
            Dim DA As New HanaDataAdapter
            Dim DS As New DataSet

            'CMD.Parameters.AddWithValue("@WO_TYPE", Unit)
            DA.SelectCommand = CMD
            DA.Fill(DS, "View")

            ReadItemBOM = DS
        End Using

    End Function

    'Find
    'Mencari Detail Item Finished Good Pada Work Order Berdasarkan Unit Produksi dan Nomor WO
    Public Function FindFGByWO(Unit As String, NomorWO As String) As FGWorkOrder
        Dim DB As New SAPDBConnection
        Dim SQL As String

        SQL = "SELECT DISTINCT " +
              " ""WO_ID""               AS ""ID"", " +
              " ""FG_POS_ID""           AS ""POSID"", " +
              " ""WO_Number""           AS ""Nomor"", " +
              " ""WO_Date""             AS ""Tanggal"", " +
              " ""FG_ItemCode""         AS ""KodeItem"", " +
              " ""FG_ItemName""         AS ""NamaItem"", " +
              " ""FG_Quantity""         AS ""QtyBOM"", " +
              " ""FG_UoM""              AS ""Satuan"", " +
              " ""FG_Whs""              AS ""KodeLokasi"", " +
              " ""FG_LOM_DENIER""       AS ""Denier"", " +
              " ""FG_LOM_LEBAR""        AS ""Lebar"", " +
              " ""FG_LOM_MESHLUSI""     AS ""MeshLusi"", " +
              " ""FG_LOM_MESHPAKAN""    AS ""MeshPakan"", " +
              " ""FG_CUT_PJGPOTONG""    AS ""PanjangPotongCutting"", " +
              " ""FG_PRINT_PJGPOTONG""  AS ""PanjangPotongPrinting"", " +
              " ""FG_GRAM""             AS ""BeratStandar"", " +
              " ""FG_POS_Closed""       AS ""Closing"" " +
              "FROM SOL_WO_BOM " +
              "WHERE ""WO_Number"" = '" + NomorWO + "' AND ""WO_TYPE"" = '" + Unit + "'"

        Using DBX As IDbConnection = DB.Connection()

            Dim CMD As New HanaCommand(SQL, DBX)
            Dim DR As HanaDataReader = CMD.ExecuteReader()
            Dim Temp As FGWorkOrder = Nothing

            If DR.Read() Then
                Temp = New FGWorkOrder()
                Temp.ID = DR("ID")
                Temp.POSID = DR("POSID")
                Temp.NomorWO = DR("Nomor")
                Temp.Tanggal = DR("Tanggal")
                Temp.KodeItem = DR("KodeItem")
                Temp.NamaItem = DR("NamaItem")
                Temp.QtyBOM = DR("QtyBOM").ToString()
                Temp.Satuan = DR("Satuan")
                Temp.KodeLokasi = DR("KodeLokasi")

                Temp.Denier = DR("Denier").ToString()
                Temp.Lebar = DR("Lebar").ToString()
                Temp.MeshLusi = DR("MeshLusi").ToString()
                Temp.MeshPakan = DR("MeshPakan").ToString()
                Temp.PanjangPotongCutting = DR("PanjangPotongCutting").ToString()
                Temp.PanjangPotongPrinting = DR("PanjangPotongPrinting").ToString()
                Temp.BeratStandar = DR("BeratStandar").ToString()

                Temp.Closing = DR("Closing")
            End If

            DR.Close()

            FindFGByWO = Temp

        End Using
    End Function

    Public Function FindFGByWOWithStartDate(Unit As String, NomorWO As String) As DataWorkOrder
        Dim DB As New SAPDBConnection
        Dim SQL As String

        SQL = "SELECT * FROM ""HSP_RPT_PLAN_WO"" " +
              "WHERE ""NomorWO"" = '" + NomorWO + "' AND ""Unit"" = '" + Unit + "'"

        Using DBX As IDbConnection = DB.Connection()

            Dim CMD As New HanaCommand(SQL, DBX)
            Dim DR As HanaDataReader = CMD.ExecuteReader()
            Dim Temp As DataWorkOrder = Nothing

            If DR.Read() Then
                Temp = New DataWorkOrder()

                Temp.NomorWo = DR("NomorWO")
                Temp.TglMulai = DR("TglMulai")
                Temp.tglSelesai = DR("TglSelesai")
                Temp.KodeItem = DR("KodeItem")
                Temp.NamaItem = DR("NamaItem")
                Temp.QtyPlan = DR("QtyPlan").ToString
                Temp.Satuan = DR("Satuan")
                Temp.Unit = DR("Unit")
                Temp.StatusWO = DR("StatusWO")
            End If

            DR.Close()

            FindFGByWOWithStartDate = Temp

        End Using
    End Function

    'Find
    'Mencari Detail Item Finished Good Pada Work Order Berdasarkan Unit Produksi dan Nomor WO
    Public Function FindFGByItem(KodeItem As String) As FGWorkOrder
        Dim DB As New SAPDBConnection
        Dim SQL As String

        SQL = "SELECT DISTINCT " +
              " ""WO_ID""               AS ""ID"", " +
              " ""FG_POS_ID""           AS ""POSID"", " +
              " ""WO_Number""           AS ""Nomor"", " +
              " ""WO_Date""             AS ""Tanggal"", " +
              " ""FG_ItemCode""         AS ""KodeItem"", " +
              " ""FG_ItemName""         AS ""NamaItem"", " +
              " ""FG_Quantity""         AS ""QtyBOM"", " +
              " ""FG_UoM""              AS ""Satuan"", " +
              " ""FG_Whs""              AS ""KodeLokasi"", " +
              " ""FG_LOM_DENIER""       AS ""Denier"", " +
              " ""FG_LOM_LEBAR""        AS ""Lebar"", " +
              " ""FG_LOM_MESHLUSI""     AS ""MeshLusi"", " +
              " ""FG_LOM_MESHPAKAN""    AS ""MeshPakan"", " +
              " ""FG_CUT_PJGPOTONG""    AS ""PanjangPotongCutting"", " +
              " ""FG_PRINT_PJGPOTONG""  AS ""PanjangPotongPrinting"", " +
              " ""FG_GRAM""             AS ""BeratStandar"", " +
              " ""FG_POS_Closed""       AS ""Closing"" " +
              "FROM SOL_WO_BOM " +
              "WHERE ""FG_ItemCode"" = '" + KodeItem + "' "

        Using DBX As IDbConnection = DB.Connection()

            Dim CMD As New HanaCommand(SQL, DBX)
            Dim DR As HanaDataReader = CMD.ExecuteReader()
            Dim Temp As FGWorkOrder = Nothing

            If DR.Read() Then
                Temp = New FGWorkOrder()
                Temp.ID = DR("ID")
                Temp.POSID = DR("POSID")
                Temp.NomorWO = DR("Nomor")
                Temp.Tanggal = DR("Tanggal")
                Temp.KodeItem = DR("KodeItem")
                Temp.NamaItem = DR("NamaItem")
                Temp.QtyBOM = DR("QtyBOM").ToString()
                Temp.Satuan = DR("Satuan")
                Temp.KodeLokasi = DR("KodeLokasi")

                Temp.Denier = DR("Denier").ToString()
                Temp.Lebar = DR("Lebar").ToString()
                Temp.MeshLusi = DR("MeshLusi").ToString()
                Temp.MeshPakan = DR("MeshPakan").ToString()
                Temp.PanjangPotongCutting = DR("PanjangPotongCutting").ToString()
                Temp.PanjangPotongPrinting = DR("PanjangPotongPrinting").ToString()
                Temp.BeratStandar = DR("BeratStandar").ToString()

                Temp.Closing = DR("Closing")
            End If

            DR.Close()

            FindFGByItem = Temp

        End Using
    End Function

    'Find
    'Mencari Detail Item Finished Good Pada Work Order Berdasarkan Unit Produksi dan ID
    Public Function FindFGByID(Unit As String, ID As Long) As FGWorkOrder
        Dim DB As New SAPDBConnection
        Dim SQL As String

        SQL = "SELECT DISTINCT " +
              " ""WO_ID""               AS ""ID"", " +
              " ""FG_POS_ID""           AS ""POSID"", " +
              " ""WO_Number""           AS ""Nomor"", " +
              " ""WO_Date""             AS ""Tanggal"", " +
              " ""FG_ItemCode""         AS ""KodeItem"", " +
              " ""FG_ItemName""         AS ""NamaItem"", " +
              " ""FG_Quantity""         AS ""QtyBOM"", " +
              " ""FG_UoM""              AS ""Satuan"", " +
              " ""FG_Whs""              AS ""KodeLokasi"", " +
              " ""FG_LOM_DENIER""       AS ""Denier"", " +
              " ""FG_LOM_LEBAR""        AS ""Lebar"", " +
              " ""FG_LOM_MESHLUSI""     AS ""MeshLusi"", " +
              " ""FG_LOM_MESHPAKAN""    AS ""MeshPakan"", " +
              " ""FG_CUT_PJGPOTONG""    AS ""PanjangPotongCutting"", " +
              " ""FG_PRINT_PJGPOTONG""  AS ""PanjangPotongPrinting"" " +
              " ""FG_GRAM""             AS ""BeratStandar"", " +
              "FROM SOL_WO_BOM " +
              "WHERE ""WO_ID"" = " + ID.ToString() + " AND ""WO_TYPE"" = '" + Unit + "'"

        Using DBX As IDbConnection = DB.Connection()

            Dim CMD As New HanaCommand(SQL, DBX)
            Dim DR As HanaDataReader = CMD.ExecuteReader()
            Dim Temp As FGWorkOrder = Nothing

            If DR.Read() Then
                Temp = New FGWorkOrder()
                Temp.ID = DR("ID")
                Temp.POSID = DR("POSID")
                Temp.NomorWO = DR("Nomor")
                Temp.Tanggal = DR("Tanggal")
                Temp.KodeItem = DR("KodeItem")
                Temp.NamaItem = DR("NamaItem")
                Temp.QtyBOM = DR("QtyBOM").ToString()
                Temp.Satuan = DR("Satuan")
                Temp.KodeLokasi = DR("KodeLokasi")

                Temp.Denier = DR("Denier").ToString()
                Temp.Lebar = DR("Lebar").ToString()
                Temp.MeshLusi = DR("MeshLusi").ToString()
                Temp.MeshPakan = DR("MeshPakan").ToString()
                Temp.PanjangPotongCutting = DR("PanjangPotongCutting").ToString()
                Temp.PanjangPotongPrinting = DR("PanjangPotongPrinting").ToString()
                Temp.BeratStandar = DR("BeratStandar").ToString()
            End If

            DR.Close()

            FindFGByID = Temp

        End Using

    End Function

    'Find
    'Mencari Detail Item Raw Material Pada Work Order Berdasarkan Unit Produksi, Nomor WO dan Kode Item
    Public Function FindRMByWO(Unit As String, NomorWO As String, KodeItem As String) As RMWorkOrder
        Dim DB As New SAPDBConnection
        Dim SQL As String

        SQL = "SELECT DISTINCT " +
              " ""WO_ID""               AS ""ID"", " +
              " ""RM_POS_ID""           AS ""POSID"", " +
              " ""WO_Number""           AS ""Nomor"", " +
              " ""WO_Date""             AS ""Tanggal"", " +
              " ""RM_ItemCode""         AS ""KodeItem"", " +
              " ""RM_ItemName""         AS ""NamaItem"", " +
              " ""RM_Quantity""         AS ""QtyBOM"", " +
              " ""RM_UoM""              AS ""Satuan"", " +
              " ""RM_Whs""              AS ""KodeLokasi"" " +
              "FROM SOL_WO_BOM " +
              "WHERE ""RM_Quantity"" > 0 AND ""WO_Number"" = '" + NomorWO + "' AND ""RM_ItemCode"" = '" + KodeItem + "' AND ""WO_TYPE"" = '" + Unit + "'"

        Using DBX As IDbConnection = DB.Connection()

            Dim CMD As New HanaCommand(SQL, DBX)
            Dim DR As HanaDataReader = CMD.ExecuteReader()
            Dim Temp As RMWorkOrder = Nothing

            If DR.Read() Then
                Temp = New RMWorkOrder()
                Temp.ID = DR("ID")
                Temp.POSID = DR("POSID")
                Temp.NomorWO = DR("Nomor")
                Temp.KodeItem = DR("KodeItem")
                Temp.NamaItem = DR("NamaItem")
                Temp.QtyBOM = DR("QtyBOM").ToString()
                Temp.QtyKebutuhan = Temp.QtyBOM
                Temp.Satuan = DR("Satuan")
                Temp.KodeLokasi = DR("KodeLokasi")
            End If

            DR.Close()

            FindRMByWO = Temp

        End Using
    End Function

    'Find
    'Mencari Detail Item Raw Material Pada Work Order Berdasarkan Unit Produksi,ID dan Kode Item
    Public Function FindRMByID(Unit As String, ID As Long, KodeItem As String) As RMWorkOrder
        Dim DB As New SAPDBConnection
        Dim SQL As String

        SQL = "SELECT DISTINCT " +
              " ""WO_ID""               AS ""ID"", " +
              " ""RM_POS_ID""           AS ""POSID"", " +
              " ""WO_Number""           AS ""Nomor"", " +
              " ""WO_Date""             AS ""Tanggal"", " +
              " ""RM_ItemCode""         AS ""KodeItem"", " +
              " ""RM_ItemName""         AS ""NamaItem"", " +
              " ""RM_Quantity""         AS ""QtyBOM"", " +
              " ""RM_UoM""              AS ""Satuan"", " +
              " ""RM_Whs""              AS ""KodeLokasi"" " +
              "FROM SOL_WO_BOM " +
              "WHERE ""RM_Quantity"" > 0 AND ""WO_ID"" = " + ID.ToString() + " AND ""RM_ItemCode"" = '" + KodeItem + "' AND ""WO_TYPE"" = '" + Unit + "'"

        Using DBX As IDbConnection = DB.Connection()

            Dim CMD As New HanaCommand(SQL, DBX)
            Dim DR As HanaDataReader = CMD.ExecuteReader()
            Dim Temp As RMWorkOrder = Nothing

            If DR.Read() Then
                Temp = New RMWorkOrder()
                Temp.ID = DR("ID")
                Temp.POSID = DR("POSID")
                Temp.NomorWO = DR("Nomor")
                Temp.KodeItem = DR("KodeItem")
                Temp.NamaItem = DR("NamaItem")
                Temp.QtyBOM = DR("QtyBOM").ToString()
                Temp.QtyKebutuhan = Temp.QtyBOM
                Temp.Satuan = DR("Satuan")
                Temp.KodeLokasi = DR("KodeLokasi")
            End If

            DR.Close()

            FindRMByID = Temp

        End Using
    End Function

    'Find
    'Mencari Detail Item Finished Good Pada Work Order Berdasarkan Unit Produksi dan Nomor WO
    Public Function FindMesin(Unit As String, NomorWO As String) As Extruder
        Dim DB As New SAPDBConnection
        Dim SQL As String

        SQL = "SELECT DISTINCT B.""APLATZ_ID"" AS ""KodeMesin"" " +
              "FROM ""SOL_WO_BOM"" A " +
              "LEFT JOIN ""BEAS_FTAPL"" B ON B.""BELNR_ID"" = A.""WO_ID"" " +
              "WHERE A.""WO_TYPE"" = '" + Unit + "' AND A.""WO_Number""='" + NomorWO + "' AND B.""AGTYP""='operation' "

        Using DBX As IDbConnection = DB.Connection()

            Dim CMD As New HanaCommand(SQL, DBX)
            Dim DR As HanaDataReader = CMD.ExecuteReader()
            Dim Temp As Extruder = Nothing

            If DR.Read() Then
                Temp = New Extruder()
                Temp.KodeMesin = DR("KodeMesin")
            End If

            DR.Close()

            FindMesin = Temp

        End Using
    End Function

    'Find
    'Mencari Item Raw 
    Public Function GetRMItemName(KodeItem As String) As String
        Dim DB As New SAPDBConnection
        Dim SQL As String

        SQL = "SELECT DISTINCT " +
              " ""RM_ItemName""         AS ""NamaItem"" " +
              "FROM SOL_WO_BOM " +
              "WHERE ""RM_ItemCode"" = '" + KodeItem + "'"

        GetRMItemName = ""
        Using DBX As IDbConnection = DB.Connection()

            Dim CMD As New HanaCommand(SQL, DBX)
            Dim DR As HanaDataReader = CMD.ExecuteReader()

            If DR.Read() Then
                GetRMItemName = DR("NamaItem")
            End If

            DR.Close()

        End Using
    End Function

    'GetAfvalItem
    'Mencari Kode Item Afval Pada Work Order Berdasarkan Unit Produksi dan Nomor WO 
    Public Function GetAfvalItemByWO(Unit As String, NomorWO As String) As String
        Dim DB As New SAPDBConnection
        Dim SQL As String

        SQL = "SELECT ""RM_ItemCode"" As KodeItem FROM ""SOL_WO_BOM"" " +
              "WHERE ""RM_Quantity"" <= 0 AND ""WO_Number"" = '" + NomorWO + "' AND ""WO_TYPE"" = '" + Unit + "'"

        Using DBX As IDbConnection = DB.Connection()

            Dim CMD As New HanaCommand(SQL, DBX)
            Dim DR As HanaDataReader = CMD.ExecuteReader()

            If DR.Read() Then
                GetAfvalItemByWO = DR("KodeItem")
            Else
                GetAfvalItemByWO = ""
            End If

            DR.Close()

        End Using
    End Function

    'Find
    'Mencari Detail Item Afval Pada Work Order Berdasarkan Unit Produksi, Nomor WO dan KodeItem Afval
    Public Function FindAfvalByWO(Unit As String, NomorWO As String, KodeItem As String) As AfvalWorkOrder
        Dim DB As New SAPDBConnection
        Dim SQL As String

        SQL = "SELECT DISTINCT " +
              " ""WO_ID""               AS ""ID"", " +
              " ""RM_POS_ID""           AS ""POSID"", " +
              " ""WO_Number""           AS ""Nomor"", " +
              " ""WO_Date""             AS ""Tanggal"", " +
              " ""RM_ItemCode""         AS ""KodeItem"", " +
              " ""RM_ItemName""         AS ""NamaItem"", " +
              " ""RM_Quantity""         AS ""QtyBOM"", " +
              " ""RM_UoM""              AS ""Satuan"", " +
              " ""RM_Whs""              AS ""KodeLokasi"" " +
              "FROM SOL_WO_BOM " +
              "WHERE ""RM_Quantity"" <= 0 AND ""WO_Number"" = '" + NomorWO + "' AND ""RM_ItemCode"" = '" + KodeItem + "' AND ""WO_TYPE"" = '" + Unit + "'"

        Using DBX As IDbConnection = DB.Connection()

            Dim CMD As New HanaCommand(SQL, DBX)
            Dim DR As HanaDataReader = CMD.ExecuteReader()
            Dim Temp As AfvalWorkOrder = Nothing

            If DR.Read() Then
                Temp = New AfvalWorkOrder()
                Temp.ID = DR("ID")
                Temp.POSID = DR("POSID")
                Temp.NomorWO = DR("Nomor")
                Temp.KodeItem = DR("KodeItem")
                Temp.NamaItem = DR("NamaItem")
                Temp.QtyBOM = DR("QtyBOM").ToString()
                Temp.Satuan = DR("Satuan")
                Temp.KodeLokasi = DR("KodeLokasi")
            End If

            DR.Close()

            FindAfvalByWO = Temp

        End Using
    End Function

    'Find
    'Mencari Detail Item Afval Pada Work Order Berdasarkan Unit Produksi, ID dan KodeItem Afval
    Public Function FindAfvalByID(Unit As String, ID As Long, KodeItem As String) As AfvalWorkOrder
        Dim DB As New SAPDBConnection
        Dim SQL As String

        SQL = "SELECT DISTINCT " +
              " ""WO_ID""               AS ""ID"", " +
              " ""RM_POS_ID""           AS ""POSID"", " +
              " ""WO_Number""           AS ""Nomor"", " +
              " ""WO_Date""             AS ""Tanggal"", " +
              " ""RM_ItemCode""         AS ""KodeItem"", " +
              " ""RM_ItemName""         AS ""NamaItem"", " +
              " ""RM_Quantity""         AS ""QtyBOM"", " +
              " ""RM_UoM""              AS ""Satuan"", " +
              " ""RM_Whs""              AS ""KodeLokasi"" " +
              "FROM SOL_WO_BOM " +
              "WHERE ""RM_Quantity"" <= 0 AND ""WO_ID"" = " + ID + " AND ""RM_ItemCode"" = '" + KodeItem + "' AND ""WO_TYPE"" = '" + Unit + "'"

        Using DBX As IDbConnection = DB.Connection()

            Dim CMD As New HanaCommand(SQL, DBX)
            Dim DR As HanaDataReader = CMD.ExecuteReader()
            Dim Temp As AfvalWorkOrder = Nothing

            If DR.Read() Then
                Temp = New AfvalWorkOrder()
                Temp.ID = DR("ID")
                Temp.POSID = DR("POSID")
                Temp.NomorWO = DR("Nomor")
                Temp.KodeItem = DR("KodeItem")
                Temp.NamaItem = DR("NamaItem")
                Temp.QtyBOM = DR("QtyBOM").ToString()
                Temp.Satuan = DR("Satuan")
                Temp.KodeLokasi = DR("KodeLokasi")
            End If

            DR.Close()

            FindAfvalByID = Temp

        End Using
    End Function

    Public Function ReadWOPlanQty(Unit As String) As DataSet
        Dim DB As New SAPDBConnection
        Dim SQL As String

        SQL = "SELECT * FROM ""HSP_RPT_PLAN_WO"" " +
              "WHERE ""Unit""='" + Unit + "' AND ""StatusWO"" = 'OPEN' "

        Using DBX As IDbConnection = DB.Connection()

            Dim CMD As New HanaCommand(SQL, DBX)
            Dim DA As New HanaDataAdapter
            Dim DS As New DataSet

            DA.SelectCommand = CMD
            DA.Fill(DS, "View")

            ReadWOPlanQty = DS
        End Using

    End Function

    Public Function ReadWOPlanQty(Unit As String, NomorWO As String) As DataSet
        Dim DB As New SAPDBConnection
        Dim SQL As String

        SQL = "SELECT * FROM ""HSP_RPT_PLAN_WO"" " +
              "WHERE ""Unit""='" + Unit + "' AND ""NomorWO""='" + NomorWO + "' "

        Using DBX As IDbConnection = DB.Connection()

            Dim CMD As New HanaCommand(SQL, DBX)
            Dim DA As New HanaDataAdapter
            Dim DS As New DataSet

            DA.SelectCommand = CMD
            DA.Fill(DS, "View")

            ReadWOPlanQty = DS
        End Using

    End Function

    Public Function GetLookup(TextSearch As String, Parameter As Object) As DataSet Implements IDataLookup.GetLookup
        Dim DB As New SAPDBConnection
        Dim SQL As String = ""

        Dim Lookup As enumLookupWorkOrder = Parameter(0)
        Dim KodeUnit As String = Parameter(1)
        Dim Tanggal As Date

        Try
            Tanggal = Parameter(2)
        Catch ex As Exception
            Tanggal = DateSerial(1900, 1, 1)
        End Try

        Select Case Lookup
            Case enumLookupWorkOrder.woDaftarFGAktif
                If Tanggal <> DateSerial(1900, 1, 1) Then

                    SQL = "SELECT DISTINCT " +
                          " ""WO_Number""           AS ""Nomor"", " +
                          " ""WO_Date""             AS ""Tanggal"", " +
                          " ""FG_ItemCode""         AS ""Kode Item"", " +
                          " ""FG_ItemName""         AS ""Nama Item"" " +
                          "FROM ""SOL_WO_BOM"" " +
                          "WHERE ""WO_Number""||' '|| " +
                          "      ""FG_ItemCode""||' '|| " +
                          "      ""FG_ItemName"" LIKE '%" + TextSearch + "%' AND ""FG_POS_Closed"" = 'N' AND ""WO_TYPE"" = '" + KodeUnit + "' AND CAST(""WO_Date"" AS DATE) <= '" + Tanggal.Date.ToString("yyyyMMdd") + "' " +
                          "ORDER BY ""WO_Date"" DESC"

                    TextSearch = String.Concat(Space(1), TextSearch.Trim, Space(1)).Replace(" ", "%")
                Else
                    SQL = "SELECT DISTINCT " +
                          " ""WO_Number""           AS ""Nomor"", " +
                          " ""WO_Date""             AS ""Tanggal"", " +
                          " ""FG_ItemCode""         AS ""Kode Item"", " +
                          " ""FG_ItemName""         AS ""Nama Item"" " +
                          "FROM ""SOL_WO_BOM"" " +
                          "WHERE ""WO_Number""||' '|| " +
                          "      ""FG_ItemCode""||' '|| " +
                          "      ""FG_ItemName"" LIKE '%" + TextSearch + "%' AND ""FG_POS_Closed"" = 'N' AND ""WO_TYPE"" = '" + KodeUnit + "' " +
                          "ORDER BY ""WO_Date"" DESC"

                    TextSearch = String.Concat(Space(1), TextSearch.Trim, Space(1)).Replace(" ", "%")
                End If

            Case enumLookupWorkOrder.woDaftarRMAktif

                SQL = "SELECT DISTINCT " +
                      " ""RM_ItemCode""         AS ""Kode Item"", " +
                      " ""RM_ItemName""         AS ""Nama Item"" " +
                      "FROM ""SOL_WO_BOM"" " +
                      "WHERE ""WO_Number""||' '|| " +
                      "      ""FG_ItemCode""||' '|| " +
                      "      ""FG_ItemName"" LIKE '%" + TextSearch + "%' AND ""RM_Quantity"" > 0 AND ""FG_POS_Closed"" = 'N' AND ""WO_TYPE"" = '" + KodeUnit + "' AND CAST(""WO_Date"" AS DATE) <= '" + Tanggal.Date.ToString("yyyyMMdd") + "' "

                TextSearch = String.Concat(Space(1), TextSearch.Trim, Space(1)).Replace(" ", "%")

            Case enumLookupWorkOrder.woDaftarFGAktifByMesin
                Dim KodeMesin As String = Parameter(3)
                SQL = "SELECT DISTINCT " +
                      " ""WO_Number""           AS ""Nomor"", " +
                      " ""WO_Date""             AS ""Tanggal"", " +
                      " ""FG_ItemCode""         AS ""Kode Item"", " +
                      " ""FG_ItemName""         AS ""Nama Item"" " +
                      "FROM ""SOL_WO_MACHINE"" " +
                      "WHERE ""WO_Number""||' '|| " +
                      "      ""FG_ItemCode""||' '|| " +
                      "      ""FG_ItemName"" LIKE '%" + TextSearch + "%' AND ""FG_POS_Closed"" = 'N' AND ""WO_TYPE"" = '" + KodeUnit + "' AND CAST(""WO_Date"" AS DATE) <= '" + Tanggal.Date.ToString("yyyyMMdd") + "' AND ""WO_MACHINE"" = '" + KodeMesin + "' "

                TextSearch = String.Concat(Space(1), TextSearch.Trim, Space(1)).Replace(" ", "%")

            Case enumLookupWorkOrder.woDaftarRMAktifByWO
                Dim NomorWO As String = Parameter(3)
                SQL = "SELECT DISTINCT " +
                      " ""RM_ItemCode""         AS ""Kode Item"", " +
                      " ""RM_ItemName""         AS ""Nama Item"" " +
                      "FROM ""SOL_WO_BOM"" " +
                      "WHERE ""WO_Number""='" + NomorWO + "' AND " +
                      "      ""FG_ItemCode""||' '|| " +
                      "      ""FG_ItemName"" LIKE '%" + TextSearch + "%' AND ""RM_Quantity"" > 0 AND ""FG_POS_Closed"" = 'N' AND ""WO_TYPE"" = '" + KodeUnit + "' AND CAST(""WO_Date"" AS DATE) <= '" + Tanggal.Date.ToString("yyyyMMdd") + "' "

                TextSearch = String.Concat(Space(1), TextSearch.Trim, Space(1)).Replace(" ", "%")

            Case enumLookupWorkOrder.woDaftarFGAktifAll
                SQL = "SELECT DISTINCT " +
                      " ""WO_Number""           AS ""Nomor"", " +
                      " ""WO_Date""             AS ""Tanggal"", " +
                      " ""FG_ItemCode""         AS ""Kode Item"", " +
                      " ""FG_ItemName""         AS ""Nama Item"" " +
                      "FROM ""SOL_WO_BOM"" " +
                      "WHERE ""WO_TYPE"" = '" + KodeUnit + "' AND CAST(""WO_Date"" AS DATE) <= '" + Now.Date.ToString("yyyyMMdd") + "' ORDER BY ""WO_Number"" "

                'TextSearch = String.Concat(Space(1), TextSearch.Trim, Space(1)).Replace(" ", "%")
        End Select

        Using DBX As IDbConnection = DB.Connection()

            Dim CMD As New HanaCommand(SQL, DBX)
            Dim DA As New HanaDataAdapter
            Dim DS As New DataSet

            DA.SelectCommand = CMD
            DA.Fill(DS, "Lookup")

            GetLookup = DS
        End Using
    End Function
End Class
