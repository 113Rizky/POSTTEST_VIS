Module Module1
    Public judulBuku(99) As String
    Public genreBuku(99) As String
    Public jumlah As Integer = 0

    Public Function CariIndexBuku(ByVal judul As String) As Integer
        For i As Integer = 0 To jumlah - 1
            If String.Equals(judulBuku(i), judul, StringComparison.OrdinalIgnoreCase) Then
                Return i
            End If
        Next
        Return -1
    End Function

    Public Sub TambahBuku(ByVal judul As String, ByVal genre As String)
        If jumlah >= judulBuku.Length Then Exit Sub

        judulBuku(jumlah) = judul
        genreBuku(jumlah) = genre
        jumlah += 1
    End Sub

    Public Sub HapusBuku(ByVal judul As String, ByRef berhasil As Boolean)
        Dim idx As Integer = CariIndexBuku(judul)
        If idx = -1 Then
            berhasil = False
            Exit Sub
        End If

        For i As Integer = idx To jumlah - 2
            judulBuku(i) = judulBuku(i + 1)
            genreBuku(i) = genreBuku(i + 1)
        Next

        judulBuku(jumlah - 1) = ""
        genreBuku(jumlah - 1) = ""
        jumlah -= 1

        berhasil = True
    End Sub
End Module
