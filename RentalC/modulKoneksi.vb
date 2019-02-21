Imports System.Data.SqlClient

Module modulKoneksi

    Public KoneksiSQL As SqlConnection
    Public ID As String

    Dim namaServer As String = "ARNOLD-PC"
    Dim namaDB As String = "RentalA"
    Dim userID As String = "sa"
    Dim pwd As String = "sa123"

    Public Function AmbilKoneksi() As SqlConnection
        KoneksiSQL = New SqlConnection("server = " & namaServer &
                                       "; database = " & namaDB &
                                       "; User ID = '" & userID &
                                       "'; password = '" & pwd & "'")

        Return KoneksiSQL
    End Function

End Module
