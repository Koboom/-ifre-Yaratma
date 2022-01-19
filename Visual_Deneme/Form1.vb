Public Class Form1

    Public Function karakter_uret(en_kucuk_ASCII As Integer, en_buyuk_ASCII As Integer) As String
        Dim rassal_sayi As Integer
        rassal_sayi = Int((en_buyuk_ASCII - en_kucuk_ASCII + 1) * Rnd() + en_kucuk_ASCII)
        karakter_uret = Chr(rassal_sayi)

    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim rassal_karakter_turu_sec As Integer
        Dim gecici_sifre As String

        For dongu_sayisi = 0 To 10
            rassal_karakter_turu_sec = Int((3 - 1 + 1) * Rnd() + 1)


            Select Case rassal_karakter_turu_sec
                Case 1
                    gecici_sifre = gecici_sifre + karakter_uret(48, 57)
                Case 2
                    gecici_sifre = gecici_sifre + karakter_uret(97, 122)
                Case 3
                    gecici_sifre = gecici_sifre + karakter_uret(65, 90)

            End Select

            Label1.Text = gecici_sifre

        Next


    End Sub
End Class
