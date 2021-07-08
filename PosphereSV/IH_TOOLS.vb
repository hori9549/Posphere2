Imports System.Data.SqlClient

Public Class H_TOOLS
    '------------------------------------------------
    '    DivRGB   FORMARGB のパラメータ作成ツール
    '------------------------------------------------
    ' ”16進数　”    　　　　　'色彩の16進コードを入れる　　1～6桁
    'Dim  R As Byte             '戻値1　FromArgb(p1, p2, p3)のパラメーターになる
    'Dim  G As Byte             '戻値2　FromArgb(p1, p2, p3)のパラメーターになる
    'Dim  B As Byte             '戻値3　FromArgb(p1, p2, p3)のパラメーターになる

    '　以下は使用例

    Private Sub IroDuke_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Sample = "98FB98"
        Dim R As Byte             '戻値1　FromArgb(p1, p2, p3)のパラメーターになる
        Dim G As Byte             '戻値2　FromArgb(p1, p2, p3)のパラメーターになる
        Dim B As Byte             '戻値3　FromArgb(p1, p2, p3)のパラメーターになる
        Call DivRGB("98FB98", R, G, B)
        Me.BackColor = Color.FromArgb(R, G, B)
    End Sub
    Private Sub Button1_MouseClick(sender As Object, e As MouseEventArgs) Handles Button1.MouseClick
        'Sample = "FF0000"
        Dim R As Byte             '戻値1　FromArgb(p1, p2, p3)のパラメーターになる
        Dim G As Byte             '戻値2　FromArgb(p1, p2, p3)のパラメーターになる
        Dim B As Byte             '戻値3　FromArgb(p1, p2, p3)のパラメーターになる
        Call DivRGB("FF0000", R, G, B)
        Me.BackColor = Color.FromArgb(R, G, B)
    End Sub
    Private Sub botton2_MouseClick(sender As Object, e As MouseEventArgs) Handles Button2.MouseClick
        'Sample = "4169E1"
        Dim R As Byte             '戻値1　FromArgb(p1, p2, p3)のパラメーターになる
        Dim G As Byte             '戻値2　FromArgb(p1, p2, p3)のパラメーターになる
        Dim B As Byte             '戻値3　FromArgb(p1, p2, p3)のパラメーターになる
        Call DivRGB("4169E1", R, G, B)
        Me.BackColor = Color.FromArgb(R, G, B)
    End Sub
    Private Sub Button3_MouseClick(sender As Object, e As MouseEventArgs) Handles Button3.MouseClick
        'Sample = "FFFF00"
        Dim p1 As Byte             '戻値1　FromArgb(p1, p2, p3)のパラメーターになる
        Dim p2 As Byte             '戻値2　FromArgb(p1, p2, p3)のパラメーターになる
        Dim p3 As Byte             '戻値3　FromArgb(p1, p2, p3)のパラメーターになる
        Call DivRGB("FFFF00", p1, p2, p3)
        Me.BackColor = Color.FromArgb(p1, p2, p3)
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        'Sample = "FFFFFF"
        Dim p1 As Byte             '戻値1　FromArgb(p1, p2, p3)のパラメーターになる
        Dim p2 As Byte             '戻値2　FromArgb(p1, p2, p3)のパラメーターになる
        Dim p3 As Byte             '戻値3　FromArgb(p1, p2, p3)のパラメーターになる
        Call DivRGB("FFFFFF", p1, p2, p3)
        Me.BackColor = Color.FromArgb(p1, p2, p3)

    End Sub

    '------------------------------------------------
    '    DivRGB　　の本体
    '------------------------------------------------
    Sub DivRGB(ByVal InHex As String, ByRef P1 As Byte, ByRef P2 As Byte, ByRef P3 As Byte)
        Dim HexKasira As String = "&H"
        Select Case InHex.Length         'HexのLengthによる処理
            Case 1 To 2
                P3 = HexKasira & Mid(InHex, 1)
                P2 = "&H0"
                P1 = "&H0"
            Case 3
                P1 = "&H0"
                P2 = HexKasira & Mid(InHex, 1, 1)
                P3 = HexKasira & Mid(InHex, 2, 2)
            Case 4
                P1 = "&H0"
                P2 = HexKasira & Mid(InHex, 1, 2)
                P3 = HexKasira & Mid(InHex, 3, 2)
            Case 5
                P1 = HexKasira & Mid(InHex, 1, 1)
                P2 = HexKasira & Mid(InHex, 2, 2)
                P3 = HexKasira & Mid(InHex, 4, 2)
            Case 6
                P1 = HexKasira & Mid(InHex, 1, 2)
                P2 = HexKasira & Mid(InHex, 3, 2)
                P3 = HexKasira & Mid(InHex, 5, 2)
            Case Else
                P1 = "&Hff"
                P2 = "&Hff"
                P3 = "&Hff"
        End Select
    End Sub

    '-----------------------------------------------
    '  VBdeHLOOKUP     DataTableをEXCELのVLOOKUP関数のように使う
    '-----------------------------------------------
    Public Sub VBdeVLOOKUP(ByVal dtMoto As DataTable,
                           ByVal InColNam As String,
                           ByVal InKeyWord As String,
                           ByVal OutColNam As String,
                               ByRef OutData As String,
                               ByRef OutRowI As String,
                               ByRef OutRowC As String)

        For i = 0 To dtMoto.Rows.Count - 1
            If dtMoto.Rows(i).Item(InColNam).ToString = InKeyWord Then
                OutData = dtMoto.Rows(i).Item(OutColNam).ToString
                OutRowI = i.ToString
                GoTo FoundProcess
            End If
        Next
        OutData = "KeyWordなし"
        OutRowI = "---"
FoundProcess:               '見つかった時
        OutRowC = 生徒TABL.Rows.Count

    End Sub


    Dim 生徒TABL As New DataTable
    Dim 商品TABL As New DataTable
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click    '----Start Btn
        DgvTab1.DataSource = 生徒TABL           'TAB1

        生徒TABL.Columns.Add("ID")
        生徒TABL.Columns.Add("FirstName")
        生徒TABL.Columns.Add("SecondName")

        Dim row追加 As DataRow

        row追加 = 生徒TABL.NewRow
        row追加("ID") = "1"
        row追加("FirstName") = "一ノ瀬"
        row追加("SecondName") = "一郎"
        生徒TABL.Rows.Add(row追加)

        row追加 = 生徒TABL.NewRow
        row追加("ID") = "2"
        row追加("FirstName") = "二宮"
        row追加("SecondName") = "二郎"
        生徒TABL.Rows.Add(row追加)

        row追加 = 生徒TABL.NewRow
        row追加("ID") = "3"
        row追加("FirstName") = "三浦"
        row追加("SecondName") = "三郎"
        生徒TABL.Rows.Add(row追加)

        row追加 = 生徒TABL.NewRow
        row追加("ID") = "4"
        row追加("FirstName") = "四田"
        row追加("SecondName") = "四郎"
        生徒TABL.Rows.Add(row追加)

        DataGridView1.DataSource = 商品TABL
        商品TABL.Columns.Add("商品ＣＤ")
        商品TABL.Columns.Add("商品名")
        商品TABL.Columns.Add("単価")
        商品TABL.Columns.Add("部署")

        row追加 = 商品TABL.NewRow
        row追加("商品ＣＤ") = "0010"
        row追加("商品名") = "せんべい"
        row追加("単価") = "100"
        row追加("部署") = "菓子部"
        商品TABL.Rows.Add(row追加)

        row追加 = 商品TABL.NewRow
        row追加("商品ＣＤ") = "0020"
        row追加("商品名") = "バナナ"
        row追加("単価") = "200"
        row追加("部署") = "青果部"
        商品TABL.Rows.Add(row追加)

        row追加 = 商品TABL.NewRow
        row追加("商品ＣＤ") = "0030"
        row追加("商品名") = "ワイン"
        row追加("単価") = "300"
        row追加("部署") = "酒類部"
        商品TABL.Rows.Add(row追加)
        '--------ComboBox-----------
        CmbTablList.Items.Add("生徒TABL")
        CmbTablList.Items.Add("商品TABL")
    End Sub

    'Table選択
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbTablList.SelectedIndexChanged
        CmbKey列.Items.Clear()
        Cmbここから.Items.Clear()

        Select Case CmbTablList.SelectedIndex           'TABEL名に応じたItemを取り出す
            Case 0
                Call CmbNameget(生徒TABL, CmbKey列)
                Call CmbNameget(生徒TABL, Cmbここから)
            Case 1
                Call CmbNameget(商品TABL, CmbKey列)
                Call CmbNameget(商品TABL, Cmbここから)
            Case Else
                MsgBox("どちらのTABLEを検索しますか")
        End Select
        'Dim OutData As String
        'Dim OutRowI As String
        'Dim OutRowC As String
        ''Call VBdeVLOOKUP(生徒TABL, "FirstName", "一ノ瀬", "SecondName", OutData, OutRowI, OutRowC)
        'Dim dtblName As DataTable
        'dtblName = ComboBox1.SelectedItem


    End Sub
    'dtblTempの列名をCMB_Xにセットする
    Sub CmbNameget(ByVal Dtbl As DataTable,
                   ByVal cmb As ComboBox)
        '  Dim strtemp As String
        For i = 0 To Dtbl.Columns.Count - 1
            cmb.Items.Add(Dtbl.Columns(i).ColumnName)
        Next
    End Sub

    '-----Keyワードを含む'列のItemをCMBにセット
    Sub CmbItemget(ByVal Dtbl As DataTable,
                   ByVal cmb As ComboBox,
                   ByVal ColNam As String)
        For i = 0 To Dtbl.Rows.Count - 1
            cmb.Items.Add(Dtbl.Rows(i).Item(ColNam))
        Next
    End Sub
    '-----Keyワードが属する'列名を選んで'
    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbKey列.SelectedIndexChanged
        CMBKeyWord.Items.Clear()
        Select Case CmbTablList.SelectedIndex           'TABEL名に応じたItemを取り出す
            Case 0
                Call CmbItemget(生徒TABL, CMBKeyWord, CmbKey列.SelectedItem)
            Case 1
                Call CmbItemget(商品TABL, CMBKeyWord, CmbKey列.SelectedItem)
            Case Else
                '   MsgBox("どちらのTABLEを検索しますか")
        End Select

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click   '検索 START

        Dim OutData As String = ""
        Dim OutRowI As String = ""
        Dim OutRowC As String = ""
        Select Case CmbTablList.SelectedIndex           'TABEL名に応じたItemを取り出す
            Case 0
                Call VBdeVLOOKUP(生徒TABL, CmbKey列.SelectedItem, CMBKeyWord.SelectedItem, Cmbここから.SelectedItem, OutData, OutRowI, OutRowC)
            Case 1
                Call VBdeVLOOKUP(商品TABL, CmbKey列.SelectedItem, CMBKeyWord.SelectedItem, Cmbここから.SelectedItem, OutData, OutRowI, OutRowC)
        End Select
        TextBox1.Text = OutData
        TextBox2.Text = OutRowI
        TextBox3.Text = OutRowC

    End Sub
End Class