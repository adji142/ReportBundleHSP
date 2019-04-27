' -----------------------------------------------------------------------------------------------------------
' Nama File   : XASession.vb
' Deskripsi   : Class Untuk Mengelola Data Session
' Author      : Yudy Patrianto
' Tool        : VB.NET 
' Database    : MySQL 5.x  
' Tanggal     : 27 Januari 2011
' ----------------------------------------------------------------------------------------------------------- */

Public Class SessionApp

    Public Property KodePerusahaan As String
    Public Property NamaPerusahaan As String
    Public Property Alamat1 As String
    Public Property Alamat2 As String
    Public Property Kota As String
    Public Property Propinsi As String
    Public Property NoTelpon As String
    Public Property NoFax As String

    Public Property KodeUser As String = ""
    Public Property NamaUser As String = ""
    Public Property HakUbahTanggal As Boolean = True
    Public Property HakAkses As String = ""
    Public Property Supervisor As Boolean = True

    Public Property DBConnection As String = ""

End Class
