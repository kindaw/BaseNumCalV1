Public Class Form1
    Private Sub txtHex_TextChanged(sender As Object, e As EventArgs) Handles txtHex.TextChanged
        ' Allow only 0-9 and A-F for hexadecimal input
        For Each c As Char In txtHex.Text
            If Not (Char.IsDigit(c) OrElse ("A"c <= Char.ToUpper(c) AndAlso Char.ToUpper(c) <= "F"c)) Then
                MessageBox.Show("Only digits 0-9 and letters A-F are allowed for hexadecimal input.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtHex.Text = txtHex.Text.Remove(txtHex.Text.Length - 1)
                Exit For
            End If
        Next
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
        ' Allow only 0-9 for decimal input
        For Each c As Char In txtDec.Text
            If Not Char.IsDigit(c) Then
                MessageBox.Show("Only digits 0 to 9 are allowed for decimal input.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtDec.Text = txtDec.Text.Remove(txtDec.Text.Length - 1)
                Exit For
            End If
        Next
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
        ' Allow only 0-7 for octal input
        For Each c As Char In txtOct.Text
            If Not Char.IsDigit(c) OrElse CInt(c.ToString()) > 7 Then
                MessageBox.Show("Only digits 0 to 7 are allowed for octal input.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtOct.Text = txtOct.Text.Remove(txtOct.Text.Length - 1)
                Exit For
            End If
        Next
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
        ' Allow only 0 and 1 for binary input
        For Each c As Char In txtBin.Text
            If Not (c = "0"c Or c = "1"c) Then
                MessageBox.Show("Only 0 and 1 are allowed for binary input.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtBin.Text = txtBin.Text.Remove(txtBin.Text.Length - 1)
                Exit For
            End If
        Next
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

    Private Sub lblstop_Click(sender As Object, e As EventArgs)

    End Sub
End Class
