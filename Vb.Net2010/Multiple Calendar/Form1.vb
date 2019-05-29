Public Class Form1

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub


    Public Function Color2Uint32(ByVal clr As Color) As UInt32
        Dim t As Int32
        Dim a() As Byte

        t = ColorTranslator.ToOle(clr)


        a = BitConverter.GetBytes(t)

        Return BitConverter.ToUInt32(a, 0)


    End Function

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        ColorDialog1.ShowDialog()
        Me.AxCalendar1.Month = 1
        Me.AxCalendar1.Year = 2016
        Me.AxCalendar1.SetHighLightDay(2016, 1, 1, Color2Uint32(ColorDialog1.Color))

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        ColorDialog1.ShowDialog()
        Me.AxCalendar2.Month = 2
        Me.AxCalendar2.Year = 2016

        Me.AxCalendar2.SetHighLightDay(2016, 2, 1, Color2Uint32(ColorDialog1.Color))

    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        ColorDialog1.ShowDialog()
        Me.AxCalendar3.Month = 3
        Me.AxCalendar3.Year = 2016

        Me.AxCalendar3.SetHighLightDay(2016, 3, 1, Color2Uint32(ColorDialog1.Color))

    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        ColorDialog1.ShowDialog()
        Me.AxCalendar4.Month = 4
        Me.AxCalendar4.Year = 2016

        Me.AxCalendar4.SetHighLightDay(2016, 4, 1, Color2Uint32(ColorDialog1.Color))

    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        ColorDialog1.ShowDialog()
        Me.AxCalendar5.Month = 5
        Me.AxCalendar5.Year = 2016

        Me.AxCalendar5.SetHighLightDay(2016, 5, 1, Color2Uint32(ColorDialog1.Color))

    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        ColorDialog1.ShowDialog()
        Me.AxCalendar6.Month = 6
        Me.AxCalendar6.Year = 2016

        Me.AxCalendar6.SetHighLightDay(2016, 6, 1, Color2Uint32(ColorDialog1.Color))

    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs)


    End Sub
End Class
