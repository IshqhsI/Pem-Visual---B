Public Class Form1

	Private Sub TextBox2_Keyup(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.KeyUp
    
        Dim harga, banyak As Integer

        harga = Val(TextBox1.Text)
        banyak = Val(TextBox2.Text)
        TextBox3.Text = "Rp. " + Str(harga * banyak)
    
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
    
        Dim harga, banyak, total, total_setdiskon, diskonjum As Integer
        Dim diskon As String

        harga = Val(TextBox1.Text)
        banyak = Val(TextBox2.Text)
        total = Val(TextBox3.Text)
        diskon = ComboBox1.Text

        If diskon = "5%" Then
            total = harga * banyak
            diskonjum = total * 5 / 100
            total_setdiskon = total - diskonjum
        ElseIf diskon = "10%" Then
            total = harga * banyak
            diskonjum = total * 10 / 100
            total_setdiskon = total - diskonjum
        ElseIf diskon = "15%" Then
            total = harga * banyak
            diskonjum = total * 15 / 100
            total_setdiskon = total - diskonjum
        Else
            total = harga * banyak
            diskonjum = "diskon tidak dipilih"
            total_setdiskon = "diskon tidak dipilih"
        End If

        TextBox4.Text = "Rp. " + Str(diskonjum) + " "
        TextBox5.Text = "Rp. " + Str(total_setdiskon)
    
    End Sub
  
End Class
