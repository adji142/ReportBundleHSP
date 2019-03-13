Imports HSPProduction.HSP.Data

Public Class frmUpdateBeratStandarPackingKarung

    Public Sub New()
        InitializeComponent()
    End Sub

    
    Private Sub btSave_Click(sender As Object, e As EventArgs) Handles btSave.Click
        Dim Data = New DaftarProduksiPackingPcs(ActiveSession)
        Dim DaftarTransaksi = New DaftarProduksiPackingPcs(ActiveSession).ReadBeratStandarNol().Tables("View")
        Dim DR As DataRow

        lstTransaksi.Items.Clear()
        For Each DR In DaftarTransaksi.Rows
            lstTransaksi.Items.Add(DR("NoTransaksi"))
            lstTransaksi.SelectedIndex = lstTransaksi.Items.Count - 1

            Dim WO As New SAPWorkOrder
            Dim WOItem = WO.FindFGByWO(New DaftarUnitProduksi(ActiveSession).Find(DR("KodeUnit")).KodeUnitSAP, DR("NomorWO"))

            Dim _PanjangPotong As Long = WOItem.PanjangPotongCutting
            Dim _Lebar As Long = WOItem.Lebar
            Dim _Denier As Long = WOItem.Denier
            Dim _MeshLusi As Long = WOItem.MeshLusi
            Dim _MeshPakan As Long = WOItem.MeshPakan


            'txtBeratStandar.Value = (_Lebar * 2 * _PanjangPotong * _Denier * _MeshPakan * 875) / 1000
            'Dim _BeratStandar As Double = ((2 * _Lebar * (_PanjangPotong / 100) * (_MeshPakan + _MeshLusi) * _Denier) / 22860000) * DR("FGPcs")
            Dim _BeratStandar As Double = WOItem.BeratStandar

            Data.UpdateBeratStandar(DR("NoTransaksi"), _BeratStandar)

            lblTotalBaris.Text = lstTransaksi.Items.Count
            lblTotalBaris.Refresh()

        Next

    End Sub

    Private Sub btClose_Click(sender As Object, e As EventArgs) Handles btClose.Click
        Me.Close()
        Me.Dispose()
    End Sub
End Class