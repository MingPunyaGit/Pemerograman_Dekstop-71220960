Public Class Form1
    Private tables As New Dictionary(Of String, Integer) From {
        {"Meja No1  
        2 Kursi", 2},
        {"Meja No2  
        4 Kursi", 4},
        {"Meja No3  
        6 Kursi", 6},
        {"Meja No4  
        2 Kursi", 2},
        {"Meja No5  
        4 Kursi", 4}
    }

    Private favoriteMenus As New List(Of String) From {
        "Big Mac",
        "McChicken",
        "Quarter Pounder with Cheese",
        "McFlurry"
    }

    Private Function GetMenuSuggestionsByGuestCount(guestCount As Integer) As List(Of String)
        Dim suggestions As New List(Of String)

        If guestCount <= 2 Then
            suggestions.Add("French Fries")
            suggestions.Add("McCafe Coffee")
            suggestions.Add("Egg McMuffin")
        ElseIf guestCount <= 4 Then
            suggestions.Add("Big Mac")
            suggestions.Add("McChicken")
            suggestions.Add("Filet-O-Fish")
        Else
            suggestions.Add("Quarter Pounder with Cheese")
            suggestions.Add("Happy Meal")
            suggestions.Add("McFlurry")
        End If

        Return suggestions
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CmbJmlhKursi.Items.AddRange(tables.Keys.ToArray())
        Label1.Text = "Silahkan pilih meja terlebih dahulu"
        Label4.Text = "Kita ada saran menu rekomendasi nih buat kamu!"
        Label5.Text = "Daftar Menu"
        Label6.Text = "Riwayat Pemesanan"
        Label7.Text = "Ada berapa orang nihh"



        LbxMenu.Items.Add("Big Mac")
        LbxMenu.Items.Add("McChicken")
        LbxMenu.Items.Add("French Fries")
        LbxMenu.Items.Add("McFlurry")
        LbxMenu.Items.Add("Quarter Pounder with Cheese")
        LbxMenu.Items.Add("Filet-O-Fish")
        LbxMenu.Items.Add("Egg McMuffin")
        LbxMenu.Items.Add("Happy Meal")
        LbxMenu.Items.Add("Coca-Cola")
        LbxMenu.Items.Add("McCafe Coffee")


        LbxMenu.SelectionMode = SelectionMode.MultiExtended
    End Sub





    Private Sub DisplayMenuRecommendations()
        If CmbJmlhKursi.SelectedItem IsNot Nothing Then
            Dim selectedTable As String = CmbJmlhKursi.SelectedItem.ToString()
            Dim guestCount As Integer = NumericUpDown1.Value


            Dim menuSuggestions = GetMenuSuggestionsByGuestCount(guestCount)

            LbxMenuRekomendasi.Items.Clear()


            For Each menu In menuSuggestions
                LbxMenuRekomendasi.Items.Add(menu)
            Next
        End If
    End Sub


    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged

        DisplayMenuRecommendations()
    End Sub


    Private Sub CmbJmlhKursi_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbJmlhKursi.SelectedIndexChanged

        DisplayMenuRecommendations()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If CmbJmlhKursi.SelectedItem Is Nothing Then
            MessageBox.Show("Silakan pilih meja terlebih dahulu.")
            Return
        End If

        Dim selectedTable As String = CmbJmlhKursi.SelectedItem.ToString()
        Dim guestCount As Integer = NumericUpDown1.Value
        Dim seatCount As Integer = tables(selectedTable)
        Dim customerName As String = InputBox("Masukkan nama pemesan:", "Nama Pemesan")

        If String.IsNullOrWhiteSpace(customerName) Then
            MessageBox.Show("Nama pemesan tidak boleh kosong.")
            Return
        End If

        If guestCount > seatCount Then
            MessageBox.Show("Jumlah tamu melebihi kapasitas meja ini.")
        Else

            Dim selectedFoods As New List(Of String)
            For Each item In LbxMenu.SelectedItems
                selectedFoods.Add(item.ToString())
            Next
            Dim foodOrder As String = If(selectedFoods.Count > 0, String.Join(", ", selectedFoods), "Tidak ada makanan yang dipilih")


            LbxRiwayat.Items.Add($"{customerName} - {selectedTable} untuk {guestCount} tamu, Makanan: {foodOrder}")

            Label1.Text = "Meja berhasil dipesan oleh " & customerName
        End If
    End Sub


End Class
