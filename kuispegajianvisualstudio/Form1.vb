Public Class Form1
    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        golongan.Items.Add("Manager")
        golongan.Items.Add("Chef")
        golongan.Items.Add("Pelayan")

        status.Items.Add("Menikah")
        status.Items.Add("Belum Menikah")

        nip.Items.Add("101")
        nip.Items.Add("102")
        nip.Items.Add("103")
        nip.Items.Add("104")
    End Sub

    Private Sub golongan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles golongan.SelectedIndexChanged
        If golongan.Text = "Manager" Then
            gaji.Text = 4500000
        ElseIf golongan.Text = "Chef" Then
            gaji.Text = 3000000
        ElseIf golongan.Text = "Pelayan" Then
            gaji.Text = 2500000
        Else
            gaji.Text = 0
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnkeluar_Click(sender As Object, e As EventArgs) Handles btnkeluar.Click
        Me.Close()
    End Sub

    Private Sub nip_SelectedIndexChanged(sender As Object, e As EventArgs) Handles nip.SelectedIndexChanged
        If nip.Text = "101" Then
            nama.Text = "Zulfan Anugerah Zega"
        ElseIf nip.Text = "102" Then
            nama.Text = "Irwan Gulo"
        ElseIf nip.Text = "103" Then
            nama.Text = "Melinus Laoli"
        ElseIf nip.Text = "104" Then
            nama.Text = "Toni Sartana Sianturi"
        Else
            nama.Text = 0

        End If
    End Sub

    Private Sub status_SelectedIndexChanged(sender As Object, e As EventArgs) Handles status.SelectedIndexChanged
        If status.Text = "Menikah" Then
            tkeluarga.Text = 0.15 * gaji.Text
        ElseIf status.Text = "Belum Menikah" Then
            tkeluarga.Text = 0.25 * gaji.Text
        Else
            tkeluarga.Text = 0
        End If
    End Sub

    Private Sub btnhapus_Click(sender As Object, e As EventArgs) Handles btnhapus.Click
        nip.Text = ""
        nama.Text = ""
        golongan.Text = ""
        gaji.Text = ""
        status.Text = ""
        tkeluarga.Text = ""
        tgaji.Text = ""
    End Sub

    Private Sub btnproses_Click(sender As Object, e As EventArgs) Handles btnproses.Click
        tgaji.Text = Val(tkeluarga.Text) + Val(gaji.Text)
    End Sub
End Class
