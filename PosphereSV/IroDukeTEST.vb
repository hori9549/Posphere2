Public Class IroDukeTEST
    ' ファンクション" IroDuke " 4つの引数が必要
    '------------------------------------------------
    '     色付け
    '------------------------------------------------
    Dim Sample As String       '色彩の16進コードを入れる
    Dim p1 As Byte             '戻値1　FromArgb(p1, p2, p3)のパラメーターになる
    Dim p2 As Byte             '戻値2　FromArgb(p1, p2, p3)のパラメーターになる
    Dim p3 As Byte             '戻値3　FromArgb(p1, p2, p3)のパラメーターになる

    '　以下は使用例

    Private Sub IroDuke_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Sample = "F7F7F7"
        Call IroDuke(Sample, p1, p2, p3)
        Me.BackColor = Color.FromArgb(p1, p2, p3)
    End Sub
    Private Sub Button1_MouseClick(sender As Object, e As MouseEventArgs) Handles Button1.MouseClick
        Sample = "AFEAFF"
        Call IroDuke(Sample, p1, p2, p3)
        Me.BackColor = Color.FromArgb(p1, p2, p3)
    End Sub
    Private Sub botton2_MouseClick(sender As Object, e As MouseEventArgs) Handles Button2.MouseClick
        Sample = "FFABAB"
        Call IroDuke(Sample, p1, p2, p3)
        Me.BackColor = Color.FromArgb(p1, p2, p3)
    End Sub
    Private Sub Button3_MouseClick(sender As Object, e As MouseEventArgs) Handles Button3.MouseClick
        Sample = "FFFF00"
        Call IroDuke(Sample, p1, p2, p3)
        Me.BackColor = Color.FromArgb(p1, p2, p3)
    End Sub

    '------------------------------------------------
    '    IroDuke　　の本体
    '------------------------------------------------
    Sub IroDuke(ByVal InHex As String, ByRef P1 As Byte, ByRef P2 As Byte, ByRef P3 As Byte)
        Dim strTempColor As String
        Dim HexKasira As String = "&H"
        strTempColor = InHex

        Select Case strTempColor.Length         'HexのLengthによる処理
            Case 1 To 2
                P3 = HexKasira & Mid(strTempColor, 1)
                P2 = "&H0"
                P1 = "&H0"
            Case 3
                P1 = "&H0"
                P2 = HexKasira & Mid(strTempColor, 1, 1)
                P3 = HexKasira & Mid(strTempColor, 2, 2)
            Case 4
                P1 = "&H0"
                P2 = HexKasira & Mid(strTempColor, 1, 2)
                P3 = HexKasira & Mid(strTempColor, 3, 2)
            Case 5
                P1 = HexKasira & Mid(strTempColor, 1, 1)
                P2 = HexKasira & Mid(strTempColor, 2, 2)
                P3 = HexKasira & Mid(strTempColor, 4, 2)
            Case 6
                P1 = HexKasira & Mid(strTempColor, 1, 2)
                P2 = HexKasira & Mid(strTempColor, 3, 2)
                P3 = HexKasira & Mid(strTempColor, 5, 2)
            Case Else
                P1 = "&Hff"
                P2 = "&Hff"
                P3 = "&Hff"
        End Select

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub
End Class