Imports System.IO
Imports System.Drawing.Printing
Imports System.Runtime.InteropServices

Public Class PrinterSet
    <StructLayout(LayoutKind.Sequential, CharSet:=CharSet.Unicode)> _
    Structure DOCINFOW
        <MarshalAs(UnmanagedType.LPWStr)> Public pDocName As String
        <MarshalAs(UnmanagedType.LPWStr)> Public pOutputFile As String
        <MarshalAs(UnmanagedType.LPWStr)> Public pDataType As String
    End Structure

    <DllImport("winspool.Drv", EntryPoint:="OpenPrinterW", _
       SetLastError:=True, CharSet:=CharSet.Unicode, _
       ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function OpenPrinter(ByVal src As String, ByRef hPrinter As IntPtr, ByVal pd As Int32) As Boolean
    End Function

    <DllImport("winspool.Drv", EntryPoint:="ClosePrinter", _
       SetLastError:=True, CharSet:=CharSet.Unicode, _
       ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function ClosePrinter(ByVal hPrinter As IntPtr) As Boolean
    End Function

    <DllImport("winspool.Drv", EntryPoint:="StartDocPrinterW", _
       SetLastError:=True, CharSet:=CharSet.Unicode, _
       ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function StartDocPrinter(ByVal hPrinter As IntPtr, ByVal level As Int32, ByRef pDI As DOCINFOW) As Boolean
    End Function

    <DllImport("winspool.Drv", EntryPoint:="EndDocPrinter", _
       SetLastError:=True, CharSet:=CharSet.Unicode, _
       ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function EndDocPrinter(ByVal hPrinter As IntPtr) As Boolean
    End Function

    <DllImport("winspool.Drv", EntryPoint:="StartPagePrinter", _
       SetLastError:=True, CharSet:=CharSet.Unicode, _
       ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function StartPagePrinter(ByVal hPrinter As IntPtr) As Boolean
    End Function

    <DllImport("winspool.Drv", EntryPoint:="EndPagePrinter", _
       SetLastError:=True, CharSet:=CharSet.Unicode, _
       ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function EndPagePrinter(ByVal hPrinter As IntPtr) As Boolean
    End Function

    <DllImport("winspool.Drv", EntryPoint:="WritePrinter", _
       SetLastError:=True, CharSet:=CharSet.Unicode, _
       ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function WritePrinter(ByVal hPrinter As IntPtr, ByVal pBytes As IntPtr, ByVal dwCount As Int32, ByRef dwWritten As Int32) As Boolean
    End Function

    Public Shared Function SendBytesToPrinter(ByVal szPrinterName As String, ByVal pBytes As IntPtr, ByVal dwCount As Int32) As Boolean
        Dim hPrinter As IntPtr
        Dim dwError As Int32
        Dim di As New DOCINFOW
        Dim dwWritten As Int32
        Dim bSuccess As Boolean

        With di
            di.pDocName = "Nota"
            di.pDataType = "RAW"
        End With

        bSuccess = False
        If OpenPrinter(szPrinterName, hPrinter, 0) Then
            If StartDocPrinter(hPrinter, 1, di) Then
                If StartPagePrinter(hPrinter) Then

                    bSuccess = WritePrinter(hPrinter, pBytes, dwCount, dwWritten)
                    EndPagePrinter(hPrinter)
                End If
                EndDocPrinter(hPrinter)
            End If
            ClosePrinter(hPrinter)
        End If
        If bSuccess = False Then
            dwError = Marshal.GetLastWin32Error()
        End If
        Return bSuccess
    End Function

    Public Shared Function SendFileToPrinter(ByVal szPrinterName As String, ByVal szFileName As String) As Boolean
        Dim fs As New FileStream(szFileName, FileMode.Open)
        Dim br As New BinaryReader(fs)
        Dim bytes(fs.Length) As Byte
        Dim bSuccess As Boolean
        Dim pUnmanagedBytes As IntPtr


        bytes = br.ReadBytes(fs.Length)

        pUnmanagedBytes = Marshal.AllocCoTaskMem(fs.Length)

        Marshal.Copy(bytes, 0, pUnmanagedBytes, fs.Length)

        bSuccess = SendBytesToPrinter(szPrinterName, pUnmanagedBytes, fs.Length)

        Marshal.FreeCoTaskMem(pUnmanagedBytes)
        Return bSuccess
    End Function

    Public Shared Function SendStringToPrinter(ByVal szPrinterName As String, ByVal szString As String)
        Dim pBytes As IntPtr
        Dim dwCount As Int32

        dwCount = szString.Length()

        pBytes = Marshal.StringToCoTaskMemAnsi(szString)

        SendBytesToPrinter(szPrinterName, pBytes, dwCount)
        Marshal.FreeCoTaskMem(pBytes)
    End Function
End Class
