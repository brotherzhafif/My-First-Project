Public Class Form1


    Private Sub btn_Go_Click(sender As Object, e As EventArgs) Handles btn_Go.Click


        MsgBox("Cringe lu kontol")


    End Sub

    Private Sub btn_Var_Click(sender As Object, e As EventArgs) Handles btn_Var.Click

        Dim First_Name As String
        Dim Last_Name As String

        First_Name = "Raja"
        Last_Name = "Raditya"

        MessageBox.Show("Selamat Datang " & First_Name & " " & Last_Name & " Semoga Harimu Menyenangkan")

    End Sub

    Private Sub btn_data_Click(sender As Object, e As EventArgs) Handles btn_data.Click

        Dim name As String
        Dim age As Integer
        Dim married As Boolean
        Dim profit As Decimal
        Dim born As Date

        name = "Raja zhafif raditya harahap"
        age = 17
        married = False
        profit = 999.99
        born = #4/15/2005#

        MessageBox.Show("Perkenalkan namanya adalah " & name & vbNewLine & "Dia berumur " & age & " tahun" & vbNewLine & "Dia sudah menikah ? Tentu saja " & married & vbNewLine & "Penghasilannya adalah RP." & profit & vbNewLine & "Dia lahir pada " & born)

    End Sub

    Private Sub stinput_Click(sender As Object, e As EventArgs) Handles stinput.Click
        Dim stinput As String
        stinput = InputBox("Silahkan Masukan Nama Anda")

        MessageBox.Show(stinput & " Adalah Orang Tolol")
    End Sub

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        Dim stName As String
        Dim intUmur As Integer
        Dim stGender As String
        Dim stWork As String

        stWork = lstWork.SelectedItem
        stName = txtNama.Text
        intUmur = nmrUmur.Text
        stGender = txtGender.Text

        MessageBox.Show("Nama : " & stName & vbNewLine & "Umur : " & intUmur & " tahun" & vbNewLine &
                        "Jenis Kelamin : " & stGender & vbNewLine & "Pekerjaannya adalah " & stWork)
    End Sub

End Class
