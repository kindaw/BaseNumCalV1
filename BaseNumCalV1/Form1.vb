Public Class Form1
    Private Sub txtHex_TextChanged(sender As Object, e As EventArgs) Handles txtHex.TextChanged
        If txtHex.Text <> "" Then
            Dim decValue As Long = HexToDec(txtHex.Text)
            txtDec.Text = decValue.ToString()
            txtOct.Text = DecToOct(decValue)
            txtBin.Text = DecToBin(decValue)
        Else
            txtDec.Text = ""
            txtOct.Text = ""
            txtBin.Text = ""
        End If
    End Sub

    Private Sub txtDec_TextChanged(sender As Object, e As EventArgs) Handles txtDec.TextChanged
        If txtDec.Text <> "" Then
            Dim decValue As Long = Long.Parse(txtDec.Text)
            txtHex.Text = DecToHex(decValue)
            txtOct.Text = DecToOct(decValue)
            txtBin.Text = DecToBin(decValue)
        Else
            txtHex.Text = ""
            txtOct.Text = ""
            txtBin.Text = ""
        End If
    End Sub

    Private Sub txtOct_TextChanged(sender As Object, e As EventArgs) Handles txtOct.TextChanged
        If txtOct.Text <> "" Then
            Dim decValue As Long = OctToDec(txtOct.Text)
            txtDec.Text = decValue.ToString()
            txtHex.Text = DecToHex(decValue)
            txtBin.Text = DecToBin(decValue)
        Else
            txtDec.Text = ""
            txtHex.Text = ""
            txtBin.Text = ""
        End If
    End Sub

    Private Sub txtBin_TextChanged(sender As Object, e As EventArgs) Handles txtBin.TextChanged
        If txtBin.Text <> "" Then
            Dim decValue As Long = BinToDec(txtBin.Text)
            txtDec.Text = decValue.ToString()
            txtHex.Text = DecToHex(decValue)
            txtOct.Text = DecToOct(decValue)
        Else
            txtDec.Text = ""
            txtHex.Text = ""
            txtOct.Text = ""
        End If
    End Sub

    Private Function HexToDec(hexValue As String) As Long
        Return Convert.ToInt64(hexValue, 16)
    End Function

    Private Function DecToHex(decValue As Long) As String
        Return decValue.ToString("X")
    End Function

    Private Function DecToOct(decValue As Long) As String
        Return Convert.ToString(decValue, 8)
    End Function

    Private Function DecToBin(decValue As Long) As String
        Return Convert.ToString(decValue, 2)
    End Function

    Private Function OctToDec(octValue As String) As Long
        Return Convert.ToInt64(octValue, 8)
    End Function

    Private Function BinToDec(binValue As String) As Long
        Return Convert.ToInt64(binValue, 2)
    End Function

End Class
