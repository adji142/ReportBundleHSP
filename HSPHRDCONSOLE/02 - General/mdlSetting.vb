Imports Microsoft.Win32

Module mdlSetting
    Public Enum enumFormID
        frmGudang = 0
        frmExtruder = 1
        frmCircularLoom = 2
        frmLaminating = 3
        frmPrintingRoll = 4
        frmCutting = 5
        frmJahitManual = 6
        frmInner = 7
        frmPrintingLembar = 8
        frmSlitting = 9
        frmSemenBag = 10
        frmBenangMultifilament = 11
        frmRecycle = 12
        frmPackingKarung = 13
        frmPackingCementBag = 14
        frmMakloon = 15
        frmRewind = 16
    End Enum

    Public Enum enumSetting
        settingKodeUnit = 1
        settingKodeLokasi = 2
        settingPort = 3
        settingBaudRate = 4
    End Enum

    Public Sub SaveSetting(FormID As enumFormID, Setting As enumSetting, Value As String)
        Dim RegKey As RegistryKey
        RegKey = Registry.CurrentUser.OpenSubKey("Software", True)
        RegKey.CreateSubKey("HSPProduction\Setting")
        RegKey.Close()

        RegKey = Registry.CurrentUser.OpenSubKey("Software\HSPProduction\Setting", True)

        Select Case Setting
            Case enumSetting.settingKodeUnit
                RegKey.SetValue("KodeUnit@" & FormID.ToString, Value)
            Case enumSetting.settingKodeLokasi
                RegKey.SetValue("KodeLokasi@" & FormID.ToString, Value)
            Case enumSetting.settingPort
                RegKey.SetValue("Port@" & FormID.ToString, Value)
            Case enumSetting.settingBaudRate
                RegKey.SetValue("BaudRate@" & FormID.ToString, Value)
        End Select

        RegKey.Close()

    End Sub

    Public Function GetSetting(FormID As enumFormID, Setting As enumSetting) As String
        Dim RegKey As RegistryKey

        If Registry.CurrentUser.OpenSubKey("Software\HSPProduction\Setting") IsNot Nothing Then
            RegKey = Registry.CurrentUser.OpenSubKey("Software\HSPProduction\Setting", True)

            Select Case Setting
                Case enumSetting.settingKodeUnit
                    GetSetting = RegKey.GetValue("KodeUnit@" & FormID.ToString, "")
                Case enumSetting.settingKodeLokasi
                    GetSetting = RegKey.GetValue("KodeLokasi@" & FormID.ToString, "")
                Case enumSetting.settingPort
                    GetSetting = RegKey.GetValue("Port@" & FormID.ToString, "")
                Case enumSetting.settingBaudRate
                    GetSetting = RegKey.GetValue("BaudRate@" & FormID.ToString, "")
            End Select

            RegKey.Close()
        End If
    End Function

    Public Function GetFormat(Timbang As String) As String
        Dim TempTimbang() As String = {"I", "H", "A", "R", "D", "O", "K", "U", "S", "N"}
        If Timbang.ToString = "." Then
            GetFormat = "."
        Else
            GetFormat = TempTimbang(Timbang)
        End If
    End Function
End Module
