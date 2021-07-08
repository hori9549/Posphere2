Public Class clsHtools
    ''------------------------------------------------
    ''    DivRGB　　の本体
    ''------------------------------------------------

    'プロパティ
    Public Property Inhex As String
    Public Property P1 As Byte
    Public Property P2 As Byte
    Public Property P3 As Byte

    'メソッドの作成
    Public Sub DivRGB()
        Dim HexKasira As String = "&H"
        Select Case Inhex.Length         'HexのLengthによる処理
            Case 1 To 2
                P3 = HexKasira & Mid(Inhex, 1)
                P2 = "&H0"
                P1 = "&H0"
            Case 3
                P1 = "&H0"
                P2 = HexKasira & Mid(Inhex, 1, 1)
                P3 = HexKasira & Mid(Inhex, 2, 2)
            Case 4
                P1 = "&H0"
                P2 = HexKasira & Mid(Inhex, 1, 2)
                P3 = HexKasira & Mid(Inhex, 3, 2)
            Case 5
                P1 = HexKasira & Mid(Inhex, 1, 1)
                P2 = HexKasira & Mid(Inhex, 2, 2)
                P3 = HexKasira & Mid(Inhex, 4, 2)
            Case 6
                P1 = HexKasira & Mid(Inhex, 1, 2)
                P2 = HexKasira & Mid(Inhex, 3, 2)
                P3 = HexKasira & Mid(Inhex, 5, 2)
            Case Else
                P1 = "&Hff"
                P2 = "&Hff"
                P3 = "&Hff"
        End Select
    End Sub
End Class
