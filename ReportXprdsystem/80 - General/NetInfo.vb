Module NetInfo

    Function MacAddress() As String
        Dim nics() As System.Net.NetworkInformation.NetworkInterface = System.Net.NetworkInformation.NetworkInterface.GetAllNetworkInterfaces()
        Return nics(1).GetPhysicalAddress.ToString
    End Function

    Function IPAddress() As String
        Dim HostName As String = System.Net.Dns.GetHostName
        'Return System.Net.Dns.GetHostEntry(HostName).AddressList(0).ToString()
        Return System.Net.Dns.GetHostByName(HostName).AddressList(0).ToString
    End Function

    Function HostName() As String
        Return System.Net.Dns.GetHostName
    End Function

    Function TRX() As String
        Return (Now.ToString("yyyyMMddHHmmss") & "#" & HostName() & "#" & MacAddress() & "#" & IPAddress()).ToUpper() & "#"
    End Function

    Function IP() As String
        Return (IPAddress())
    End Function

End Module
