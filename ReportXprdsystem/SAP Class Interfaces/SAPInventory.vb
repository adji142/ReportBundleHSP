Imports Sap.Data.Hana
Imports ReportXprdsystem.HSP.Data

Public Class ItemSAP
    Public Property KodeItem As String
    Public Property NamaItem As String
    Public Property Satuan As String
    Public Property BeratStandar As Double
    Public Property Lebar As Double
End Class

Public Class Stock
    Public Property KodeItem As String
    Public Property KodeProduksi As String
    Public Property Panjang As Double
    Public Property Berat As Double
End Class

Public Class SAPInventory : Implements IDataLookup

    'GetCurrentStock
    'Membaca Saldo Stock Per Item Per Lokasi
    Public Function GetCurrentStock(KodeLokasi As String, KodeItem As String, Optional KodeProduksi As String = "") As Double
        Dim DB As New SAPDBConnection
        Dim SQL As String

        If KodeProduksi = "" Then
            SQL = "SELECT ""OnHand"" As SaldoStock FROM ""SOL_ITEMWHSSTOCK"" " +
                          "WHERE ""ItemCode"" = '" + KodeItem + "' AND ""WhsCode"" = '" + KodeLokasi + "'"
        Else
            SQL = "SELECT ""Quantity"" As SaldoStock FROM ""SOL_ITEMBATCHWHSSTOCK"" " +
                          "WHERE ""DistNumber"" = '" + UCase(KodeProduksi) + "' AND ""ItemCode"" = '" + KodeItem + "' AND ""WhsCode"" = '" + KodeLokasi + "'"
        End If

        Using DBX As IDbConnection = DB.Connection()

            Dim CMD As New HanaCommand(SQL, DBX)
            Dim DR As HanaDataReader = CMD.ExecuteReader()

            If DR.Read() Then
                GetCurrentStock = DR("SaldoStock").ToString()
            Else
                GetCurrentStock = 0
            End If

            DR.Close()

        End Using
    End Function

    Public Function GetCurrentStock(KodeLokasi As String, ByVal KodeProduksi As String) As Boolean
        Dim DB As New SAPDBConnection
        Dim SQL As String

        SQL = "SELECT ""Quantity"" As SaldoStock FROM ""SOL_ITEMBATCHWHSSTOCK"" " +
                          "WHERE ""DistNumber"" = '" + UCase(KodeProduksi) + "' AND ""WhsCode"" = '" + KodeLokasi + "' "

        Using DBX As IDbConnection = DB.Connection()

            Dim CMD As New HanaCommand(SQL, DBX)
            Dim DR As HanaDataReader = CMD.ExecuteReader()

            If DR.Read() Then
                If DR("SaldoStock") <= 0 Then
                    GetCurrentStock = False
                Else
                    GetCurrentStock = True
                End If
            Else
                GetCurrentStock = False
            End If

            DR.Close()

        End Using
    End Function

    Public Function GetItem(KodeItem As String) As String
        Dim DB As New SAPDBConnection
        Dim SQL As String


        SQL = "SELECT ""ItemName"" As NamaItem FROM ""OITM"" " +
              "WHERE ""ItemCode"" = '" + KodeItem + "' "

        Using DBX As IDbConnection = DB.Connection()

            Dim CMD As New HanaCommand(SQL, DBX)
            Dim DR As HanaDataReader = CMD.ExecuteReader()

            If DR.Read() Then
                GetItem = DR("NamaItem")
            Else
                MsgBox("Kode Item Tidak Valid...!!!")
                GetItem = ""
            End If

            DR.Close()

        End Using
    End Function

    Public Function FindItem(ByVal GrupItem As String, ByVal KodeItem As String) As ItemSAP
        Dim DB As New SAPDBConnection
        Dim SQL As String

        SQL = "SELECT ""ItemCode"", ""ItemName"", ""InvntryUom"" " +
              "FROM ""OITM"" " +
              "WHERE ""ItmsGrpCod""='" + GrupItem + "' AND ""ItemCode""='" + KodeItem + "' AND ""validFor""='Y' "

        Using DBX As IDbConnection = DB.Connection()
            Dim CMD As New HanaCommand(SQL, DBX)
            Dim DR As HanaDataReader = CMD.ExecuteReader()
            Dim Temp As ItemSAP = Nothing

            If DR.Read() Then
                Temp = New ItemSAP()
                Temp.KodeItem = DR("ItemCode")
                Temp.NamaItem = DR("ItemName")
                Temp.Satuan = DR("InvntryUom")
            End If

            DR.Close()

            FindItem = Temp
        End Using
    End Function

    Public Function FindItem(ByVal KodeItem As String) As ItemSAP
        Dim DB As New SAPDBConnection
        Dim SQL As String

        SQL = "SELECT ""ItemCode"", ""ItemName"", ""InvntryUom"", CAST(""U_SOL_SATUAN_GRM"" AS DOUBLE) AS ""U_SOL_SATUAN_GRM"", CAST(IFNULL(""U_SOL_LOM_LEBAR"",'0') AS DOUBLE) AS ""Lebar"" " +
              "FROM ""OITM"" " +
              "WHERE ""ItemCode""='" + KodeItem + "' AND ""validFor""='Y' "

        Using DBX As IDbConnection = DB.Connection()
            Dim CMD As New HanaCommand(SQL, DBX)
            Dim DR As HanaDataReader = CMD.ExecuteReader()
            Dim Temp As ItemSAP = Nothing

            If DR.Read() Then
                Temp = New ItemSAP()
                Temp.KodeItem = DR("ItemCode")
                Temp.NamaItem = DR("ItemName")
                Temp.Satuan = DR("InvntryUom")
                Temp.BeratStandar = DR("U_SOL_SATUAN_GRM")
                Temp.Lebar = DR("Lebar")
            End If

            DR.Close()

            FindItem = Temp
        End Using
    End Function

    Public Function FindItemSlitting(ByVal KodeItem As String) As ItemSAP
        Dim DB As New SAPDBConnection
        Dim SQL As String

        SQL = "SELECT ""ItemCode"", ""ItemName"", ""InvntryUom"", CAST(""U_SOL_SATUAN_GRM"" AS DOUBLE) AS ""U_SOL_SATUAN_GRM"", CAST(""U_SOL_SLT_LBRHSLSLIT"" AS DOUBLE) AS ""Lebar"" " +
              "FROM ""OITM"" " +
              "WHERE ""ItemCode""='" + KodeItem + "' AND ""validFor""='Y' "

        Using DBX As IDbConnection = DB.Connection()
            Dim CMD As New HanaCommand(SQL, DBX)
            Dim DR As HanaDataReader = CMD.ExecuteReader()
            Dim Temp As ItemSAP = Nothing

            If DR.Read() Then
                Temp = New ItemSAP()
                Temp.KodeItem = DR("ItemCode")
                Temp.NamaItem = DR("ItemName")
                Temp.Satuan = DR("InvntryUom")
                Temp.BeratStandar = DR("U_SOL_SATUAN_GRM")
                Temp.Lebar = DR("Lebar")
            End If

            DR.Close()

            FindItemSlitting = Temp
        End Using
    End Function

    Public Function FindStockByItem(KodeLokasi As String, KodeItem As String, KodeProduksi As String) As Stock
        Dim DB As New SAPDBConnection
        Dim SQL As String

        SQL = "SELECT " +
              "     ""ItemCode"" As KodeItem, " +
              "     ""DistNumber"" As KodeProduksi, " +
              "     ""Quantity"" As Panjang, " +
              "     ""Kg"" As Berat " +
              "FROM ""SOL_ITEMBATCHWHSSTOCK"" " +
              "WHERE ""DistNumber"" = '" + KodeProduksi + "' AND ""ItemCode"" = '" + KodeItem + "' AND ""WhsCode"" = '" + KodeLokasi + "'"

        Using DBX As IDbConnection = DB.Connection()
            Dim CMD As New HanaCommand(SQL, DBX)
            Dim DR As HanaDataReader = CMD.ExecuteReader()
            Dim Temp As Stock = Nothing

            If DR.Read() Then
                Temp = New Stock()
                Temp.KodeItem = DR("KodeItem")
                Temp.KodeProduksi = DR("KodeProduksi")
                Temp.Panjang = DR("Panjang").ToString()
                Temp.Berat = DR("Berat").ToString()
            End If

            DR.Close()

            FindStockByItem = Temp
        End Using
    End Function

    Public Function GetValidBOM(KodeItem As String) As Boolean
        Dim DB As New SAPDBConnection
        Dim SQL As String

        SQL = "SELECT ""FG_ItemCode"" FROM ""SOL_ITEMBOM"" WHERE ""FG_ItemCode""='" + KodeItem + "' "

        Using DBX As IDbConnection = DB.Connection()
            Dim CMD As New HanaCommand(SQL, DBX)
            Dim DR As HanaDataReader = CMD.ExecuteReader()
            Dim Temp As ItemSAP = Nothing

            If DR.Read() Then
                GetValidBOM = True
            Else
                GetValidBOM = False
            End If

            DR.Close()

        End Using
    End Function

    Public Function ReadStock(KodeUnit As String, KodeLokasi As String) As DataSet
        Dim DB As New SAPDBConnection
        Dim SQl As String

        SQl = "SELECT * FROM HSP_SALDO_STOCK " +
              "WHERE ""Unit"" ='" + KodeUnit + "' AND ""Lokasi"" ='" + KodeLokasi + "' " +
              "ORDER BY ""KodeItem"",""NamaItem"" "

        Using DBX As IDbConnection = DB.Connection()

            Dim CMD As New HanaCommand(SQl, DBX)
            Dim DA As New HanaDataAdapter
            Dim DS As New DataSet

            DA.SelectCommand = CMD
            DA.Fill(DS, "View")

            ReadStock = DS
        End Using
    End Function

    Public Function ReadAccount() As DataSet
        Dim DB As New SAPDBConnection
        Dim SQl As String

        SQl = "SELECT * FROM HSP_ACCOUNT_OINM "

        Using DBX As IDbConnection = DB.Connection()

            Dim CMD As New HanaCommand(SQl, DBX)
            Dim DA As New HanaDataAdapter
            Dim DS As New DataSet

            DA.SelectCommand = CMD
            DA.Fill(DS, "View")

            ReadAccount = DS
        End Using
    End Function

    Public Function ReadStockBatchRoll(KodeLokasi As String) As DataSet
        Dim DB As New SAPDBConnection
        Dim SQL As String

        SQL = "SELECT * FROM ""HSP_TMP_STOCKBATCH"" " +
              "WHERE ""KodeLokasi"" ='" & KodeLokasi & "' AND LEFT(""KodeItem"",1)='3' "

        Using DBX As IDbConnection = DB.Connection()

            Dim CMD As New HanaCommand(SQL, DBX)
            Dim DA As New HanaDataAdapter
            Dim DS As New DataSet

            DA.SelectCommand = CMD
            DA.Fill(DS, "View")

            ReadStockBatchRoll = DS
        End Using

    End Function

    Public Function ReadStockBatchPacking(KodeLokasi As String) As DataSet
        Dim DB As New SAPDBConnection
        Dim SQL As String

        SQL = "SELECT * FROM ""HSP_TMP_STOCKBATCH"" " +
              "WHERE ""KodeLokasi"" ='" & KodeLokasi & "' AND LEFT(""KodeItem"",1)='4' AND ""Kelompok""<>'197' "

        Using DBX As IDbConnection = DB.Connection()

            Dim CMD As New HanaCommand(SQL, DBX)
            Dim DA As New HanaDataAdapter
            Dim DS As New DataSet

            DA.SelectCommand = CMD
            DA.Fill(DS, "View")

            ReadStockBatchPacking = DS
        End Using

    End Function

    Public Function ReadStockBatchBmf(KodeLokasi As String) As DataSet
        Dim DB As New SAPDBConnection
        Dim SQL As String

        SQL = "SELECT * FROM ""HSP_TMP_STOCKBATCH"" " +
              "WHERE ""KodeLokasi"" ='" & KodeLokasi & "' AND LEFT(""KodeItem"",1)='4' AND ""Kelompok""='197' "

        Using DBX As IDbConnection = DB.Connection()

            Dim CMD As New HanaCommand(SQL, DBX)
            Dim DA As New HanaDataAdapter
            Dim DS As New DataSet

            DA.SelectCommand = CMD
            DA.Fill(DS, "View")

            ReadStockBatchBmf = DS
        End Using

    End Function

    Public Function ReadItemRoll(ByVal UnitProduksi As String) As DataSet
        Dim DB As New SAPDBConnection
        Dim SQL As String

        SQL = "SELECT * FROM ""HSP_ITEMROLL"" " +
              "WHERE ""UnitProduksi"" ='" & UnitProduksi & "' "

        Using DBX As IDbConnection = DB.Connection()

            Dim CMD As New HanaCommand(SQL, DBX)
            Dim DA As New HanaDataAdapter
            Dim DS As New DataSet

            DA.SelectCommand = CMD
            DA.Fill(DS, "View")

            ReadItemRoll = DS
        End Using

    End Function

    Public Function GetLookup(TextSearch As String, Parameter As Object) As DataSet Implements IDataLookup.GetLookup
        Dim DB As New SAPDBConnection
        Dim SQL As String = ""

        Dim GrupItem As String = Parameter(0)

        SQL = "SELECT " +
              " ""ItemCode""                            AS ""Kode Item"", " +
              " ""ItemName""                            AS ""Nama Item"", " +
              " ""InvntryUom""                          AS ""Satuan"" " +
              "FROM ""OITM"" " +
              "WHERE ""ItemCode""||' '||""ItemName"" LIKE '%" + TextSearch + "%' " +
              " AND ""ItmsGrpCod""='" + GrupItem + "' AND ""validFor""='Y' " +
              "ORDER BY ""ItemCode"" "

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
