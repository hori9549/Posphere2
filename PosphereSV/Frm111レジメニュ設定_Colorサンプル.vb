'200710 Frm111にColorCodeを送る
'200818 color変更

Public Class Frm111レジメニュ設定_Colorサンプル

    Private DivHex As New clsHtools   'インスタンスの作成

    Public Property fromF1 As String
    Public Property RtnColor As String

    Dim aryBtnList(16) As Button

    '  Dim f1 As Frm111レジメニュー設定
    '  Dim tempcolor As String
    ' コンストラクタ
    'Sub New(ByVal f As Form)
    '    f1 = f ' メイン・フォームへの参照を保存
    '    InitializeComponent()
    'End Sub

    ''------------------------------------------------
    ''    DivHexRGB　　の本体
    ''------------------------------------------------
    'Sub DivHexRGB(ByVal InHex As String, ByRef P1 As Byte, ByRef P2 As Byte, ByRef P3 As Byte)
    '    Dim HexKasira As String = "&H"
    '    Select Case InHex.Length         'HexのLengthによる処理
    '        Case 1 To 2
    '            P3 = HexKasira & Mid(InHex, 1)
    '            P2 = "&H0"
    '            P1 = "&H0"
    '        Case 3
    '            P1 = "&H0"
    '            P2 = HexKasira & Mid(InHex, 1, 1)
    '            P3 = HexKasira & Mid(InHex, 2, 2)
    '        Case 4
    '            P1 = "&H0"
    '            P2 = HexKasira & Mid(InHex, 1, 2)
    '            P3 = HexKasira & Mid(InHex, 3, 2)
    '        Case 5
    '            P1 = HexKasira & Mid(InHex, 1, 1)
    '            P2 = HexKasira & Mid(InHex, 2, 2)
    '            P3 = HexKasira & Mid(InHex, 4, 2)
    '        Case 6
    '            P1 = HexKasira & Mid(InHex, 1, 2)
    '            P2 = HexKasira & Mid(InHex, 3, 2)
    '            P3 = HexKasira & Mid(InHex, 5, 2)
    '        Case Else
    '            P1 = "&Hff"
    '            P2 = "&Hff"
    '            P3 = "&Hff"
    '    End Select
    'End Sub
    Private Sub Frm111レジメニュ設定_Colorサンプル_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '   Me.ControlBox = Not Me.ControlBox

        TxbRtn.Visible = False
        Btn規定値.Enabled = False

        aryBtnList(0) = Btn1
        aryBtnList(1) = Btn2
        aryBtnList(2) = Btn3
        aryBtnList(3) = Btn4
        aryBtnList(4) = Btn5
        aryBtnList(5) = Btn6
        aryBtnList(6) = Btn7
        aryBtnList(7) = Btn8
        aryBtnList(8) = Btn9
        aryBtnList(9) = Btn10
        aryBtnList(10) = Btn11
        aryBtnList(11) = Btn12
        aryBtnList(12) = Btn13
        aryBtnList(13) = Btn14
        aryBtnList(14) = Btn15
        aryBtnList(15) = Btn16

        'インスタンスの作成
        '   Dim DivHex As New DivRGB
        'プロパティに値を設定
        Dim R As Byte             '戻値1　FromArgb(p1, p2, p3)のパラメーターになる
        Dim G As Byte             '戻値2　FromArgb(p1, p2, p3)のパラメーターになる
        Dim B As Byte             '戻値3　FromArgb(p1, p2, p3)のパラメーターになる

        Dim BtnColr As String
        For i = 0 To 15
            BtnColr = aryBtnList(i).Text

            DivHex.Inhex = BtnColr           'プロパティに値を設定

            DivHex.DivRGB()   'メソッドの呼び出し

            R = DivHex.P1          'プロパティをGet
            G = DivHex.P2
            B = DivHex.P3
            '  Call DivHexRGB(BtnColr, R, G, B)
            aryBtnList(i).BackColor = Color.FromArgb(R, G, B)
            aryBtnList(i).ForeColor = Color.FromArgb(R, G, B)
        Next
        RtnColor = fromF1
        TxbRtn.Visible = False      '終始見せない
    End Sub
    Private Sub Btnキャンセル_Click(sender As Object, e As EventArgs) Handles Btnキャンセル.Click
        RtnColor = fromF1
        Call Rtn処理()
    End Sub

    Private Sub Btn規定値_Click(sender As Object, e As EventArgs) Handles Btn規定値.Click
        ' TxbRtn.Text = tempcolor.ToString
        ' RtnColor = tempcolor
        Call Rtn処理()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btn1.Click, Btn2.Click, Btn3.Click, Btn4.Click, Btn5.Click, Btn8.Click,
        Btn6.Click, Btn7.Click, Btn9.Click, Btn10.Click, Btn11.Click, Btn12.Click, Btn13.Click, Btn14.Click, Btn15.Click, Btn16.Click

        Btn規定値.Enabled = True
        RtnColor = sender.Text
    End Sub
    Sub Rtn処理()
        '  MsgBox("modoります") '  Dim f1_label1 As Label = CType(f1.Controls("Label1"), Label)
        '  f1_label1.Text = Me.TxbRtn.Text
        Me.Close()
    End Sub
End Class