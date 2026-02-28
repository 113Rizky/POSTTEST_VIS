Public Class Form1

    Dim total As Double
    Dim jumlah As Integer
    Dim nilaiIPS As Double
    Dim nilaiIPK As Double

    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click

        If Double.TryParse(IPS.Text, nilaiIPS) Then

            If nilaiIPS < 0 Or nilaiIPS > 4 Then
                MessageBox.Show("IP Semester harus antara 0 - 4!")
                Exit Sub
            End If

            total += nilaiIPS
            jumlah += 1

            nilaiIPK = total / jumlah

            IPK.Text = nilaiIPK.ToString("0.00")

            Hasil.Text = GetPredikat(nilaiIPK)

        Else
            MessageBox.Show("Input harus angka!")
        End If

    End Sub



    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        total = 0
        jumlah = 0
        nilaiIPK = 0
        Hasil.Text = "Hasil"
    End Sub

    Private Function GetPredikat(ipk As Double) As String

        If ipk >= 3.01 Then
            Return "Sangat Memuaskan"
        ElseIf ipk >= 2.76 Then
            Return "Memuaskan"
        ElseIf ipk >= 2.0 Then
            Return "Cukup"
        Else
            Return "Kurang"
        End If

    End Function

End Class