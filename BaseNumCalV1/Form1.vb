Public Class Form1
    Private Sub txtHex_TextChanged(sender As Object, e As EventArgs) Handles txtHex.TextChanged
        If txtHex.Text <> "" Then
            Dim decValue As Integer = HexToDec(txtHex.Text)
            txtDec.Text = decValue.ToString
            txtOct.Text = DecToOct(decValue).ToString
            txtBin.Text = DecToBin(decValue).ToString
        Else
            txtDec.Text = ""
            txtOct.Text = ""
            txtBin.Text = ""
        End If
    End Sub

    Private Sub txtDec_TextChanged(sender As Object, e As EventArgs) Handles txtDec.TextChanged
        If txtDec.Text <> "" Then
            Dim hexValue As String = DecToHex(txtDec.Text)
            txtHex.Text = hexValue
            Dim octValue As String = DecToOct(txtDec.Text)
            txtOct.Text = octValue
            Dim binValue As String = DecToBin(txtDec.Text)
            txtBin.Text = binValue
        Else
            txtHex.Text = ""
            txtOct.Text = ""
            txtBin.Text = ""
        End If
    End Sub

    Private Sub txtOct_TextChanged(sender As Object, e As EventArgs) Handles txtOct.TextChanged
        If txtOct.Text <> "" Then
            Dim decValue As Integer = OctToDec(txtOct.Text)
            txtDec.Text = decValue.ToString
            txtHex.Text = DecToHex(decValue).ToString
            txtBin.Text = DecToBin(decValue).ToString
        Else
            txtDec.Text = ""
            txtHex.Text = ""
            txtBin.Text = ""
        End If
    End Sub

    Private Sub txtBin_TextChanged(sender As Object, e As EventArgs) Handles txtBin.TextChanged
        If txtBin.Text <> "" Then
            Dim decValue As Integer = BinToDec(txtBin.Text)
            txtDec.Text = decValue.ToString
            txtHex.Text = DecToHex(decValue).ToString
            txtOct.Text = DecToOct(decValue).ToString
        Else
            txtDec.Text = ""
            txtHex.Text = ""
            txtOct.Text = ""
        End If
    End Sub

    Private Function HexToDec(hexValue As String) As Integer
        Return Convert.ToInt32(hexValue, 16)
    End Function

    Private Function DecToHex(decValue As Integer) As String
        Return decValue.ToString("X")
    End Function

    Private Function DecToOct(decValue As Integer) As String
        Return Convert.ToString(decValue, 8)
    End Function

    Private Function DecToBin(decValue As Integer) As String
        Return Convert.ToString(decValue, 2)
    End Function

    Private Function OctToDec(octValue As String) As Integer
        Return Convert.ToInt32(octValue, 8)
    End Function

    Private Function BinToDec(binValue As String) As Integer
        Return Convert.ToInt32(binValue, 2)
    End Function

End Class
