Imports System.Data
Imports System.Data.SqlClient

Public Class frm105商品登録_登録画面
    Private Shared _mutex As System.Threading.Mutex

    Private msSQL As String
    Private mCommand As SqlCommand
    Private mSDA As New SqlDataAdapter

    'cmbPOSパターン表示連携用
    Public strPosPtnName1 As String
    Public nPosPtnNo1 As Integer
    Public ItemText1 As String
    Public strPosPtnName2 As String
    'Public nPosPtnNo2 As Integer
    Public ItemText2 As String
    Public strPosPtnName3 As String
    'Public nPosPtnNo3 As Integer
    Public ItemText3 As String
    '-------------------------------------------------------------------------------------------------------------------------
    '画面右側の「出力する項目」グリッドの実体データ
    Dim dtbl出力する項目 As New DataTable

    '画面左側の「出力可能な項目」グリッドの実体データ
    Dim dtbl出力可能 As New DataTable
    Public Sub MoveToGrid(ByVal dtMoto As DataTable,
                               ByVal dtSaki As DataTable,
                               ByVal dgvMoto As DataGridView
                               )

        If dtMoto.Rows.Count <= 0 Then
            '移動元Gridの登録データが1件もない場合、以下の処理を行わずExitSubする
            Exit Sub
        End If

        If dgvMoto.SelectedRows.Count <= 0 Then
            '移動元Gridの登録データが1件もない場合、以下の処理を行わずExitSubする
            Exit Sub
        End If

        Dim row選択後 As DataRow
        row選択後 = dtSaki.NewRow
        row選択後("番号") = dtMoto.Rows(dgvMoto.SelectedRows(0).Index).Item("番号")
        row選択後("名称") = dtMoto.Rows(dgvMoto.SelectedRows(0).Index).Item("名称")

        dtSaki.Rows.InsertAt(row選択後, dtSaki.Rows.Count)

        'dtMoto.Rows.RemoveAt(dgvMoto.SelectedRows(0).Index)
        '-------------------------------------------------------------------------------------------------------------------------
        'Dim 選択済表Count As Integer = 0       '設定メニューの行、列番号　COUNT　UP用
        '-------------------------------------------------------------------------------------------------------------------------
    End Sub
    Private Sub frm105商品登録_登録画面_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cDB As New clsDB
        Dim msSQL As String
        Dim mSDA As New SqlDataAdapter
        '-------------------------------------------------------------------------------------------------------------------------
        Dim dgvTable As New DataTable
        'Dim Dataグループ As New DataTable
        '-------------------------------------------------------------------------------------------------------------------------
        '選択済表Count = 0      '選択済表の行、列番号　COUNT　UP用
        '-------------------------------------------------------------------------------------------------------------------------
        If ItemText1 > 0 Then
            Me.cmbPOSパターン.Text = strPosPtnName1
            Me.txt商品CD.Text = ItemText1          '商品CDを取得
        End If
        If ItemText2 > 0 Then
            Me.cmbPOSパターン.Text = strPosPtnName2
            Me.txt商品CD.Text = ItemText2
        End If
        If ItemText3 > 0 Then
            Me.cmbPOSパターン.Text = strPosPtnName3
            Me.txt商品CD.Text = ItemText3
        End If
        '-------------------------------------------------------------------------------------------------------------------------
        msSQL = ""
        msSQL += "select * "
        msSQL += "from POS_MP品目 "
        msSQL += "where  商品CD="
        msSQL += "'" + txt商品CD.Text + "'"
        mCommand = cDB.getsqlComand(msSQL)
        mSDA.SelectCommand = mCommand

        Call mSDA.Fill(dgvTable) ''データセット作成

        dgvData.DataSource = dgvTable
        '-------------------------------------------------------------------------------------------------------------------------
        ''基本設定
        'cmbタイプ.Text = ""
        txt商品名.Text = dgvData("品目名", 0).Value.ToString
        txt検索カナ.Text = dgvData("検索カナ", 0).Value.ToString
        txtレジボタン表示名設定_上段.Text = dgvData("ボタン表示名1", 0).Value.ToString
        txtレジボタン表示名設定_下段.Text = dgvData("ボタン表示名2", 0).Value.ToString
        btnレジボタン表示名設定.Text = dgvData("ボタン表示名", 0).Value.ToString
        txt食券発行.Text = dgvData("食券発行", 0).Value.ToString
        txt販売期間1.Text = dgvData("販売開始日付", 0).Value.ToString
        txt販売期間2.Text = dgvData("販売終了日付", 0).Value.ToString
        'cmbテイクアウト.Text = ""
        txt単価_通常.Text = dgvData("取引単価", 0).Value.ToString
        'cmb課税区分1.Text = ""
        txt単価_TO.Text = dgvData("取引単価", 0).Value.ToString
        'cmb課税区分2.Text = ""

        Dim DBタイプ() As String
        DBタイプ = {"グランドメニュー", "グランド＆セレクトメニュー", "飲み放題コースメニュー", "物販"}
        cmbタイプ.DataSource = DBタイプ
        cmbタイプ.SelectedIndex = 0
        Dim DBテイクアウト() As String
        DBテイクアウト = {"テイクアウト可", "テイクアウト不可", "テイクアウト専用"}
        cmbテイクアウト.DataSource = DBテイクアウト
        cmbテイクアウト.SelectedIndex = 0
        Dim DB課税区分1() As String
        DB課税区分1 = {"内税8％", "外税8％", "内税10％", "外税10％", "軽減内税8％", "軽減外税8％", "非課税"}
        cmb課税区分1.DataSource = DB課税区分1
        cmb課税区分1.SelectedIndex = 0
        Dim DB課税区分2() As String
        DB課税区分2 = {"内税8％", "外税8％", "内税10％", "外税10％", "軽減内税8％", "軽減外税8％", "非課税"}
        cmb課税区分2.DataSource = DB課税区分2
        cmb課税区分2.SelectedIndex = 0
        '-------------------------------------------------------------------------------------------------------------------------
        ''飲食
        txt品目CD.Text = dgvData("品目CD", 0).Value.ToString
        cmb入力タイプ.Text = ""
        'cmb提供時期.Text = ""
        'cmbサービス料.Text = ""
        'cmb付加金額.Text = ""
        txt付加金額.Text = "0"
        'cmbゼロ円明細.Text = ""

        Dim DB入力タイプ() As String
        DB入力タイプ = {"ノーマルメニュー", "シングルメニュー"}
        cmb入力タイプ.DataSource = DB入力タイプ
        cmb入力タイプ.SelectedIndex = 0
        Dim DB提供時期() As String
        DB提供時期 = {"任意", "必須", "表示確認"}
        cmb提供時期.DataSource = DB提供時期
        cmb提供時期.SelectedIndex = 0
        Dim DBサービス料() As String
        DBサービス料 = {"対象外", "対象"}
        cmbサービス料.DataSource = DBサービス料
        cmbサービス料.SelectedIndex = 0
        Dim DB付加金額() As String
        DB付加金額 = {"+", "-"}
        cmb付加金額.DataSource = DB付加金額
        cmb付加金額.SelectedIndex = 0
        Dim DBゼロ円明細() As String
        DBゼロ円明細 = {"取り込まない（セレクト品等）", "取り込む（セレクト品等）"}
        cmbゼロ円明細.DataSource = DBゼロ円明細
        cmbゼロ円明細.SelectedIndex = 0
        '-------------------------------------------------------------------------------------------------------------------------
        'オーダー出力先設定
        txtメニュー名１_上段.Text = dgvData("メニュー名1_1", 0).Value.ToString
        txtメニュー名１_下段.Text = dgvData("メニュー名1_2", 0).Value.ToString
        txtメニュー名2.Text = dgvData("メニュー名2", 0).Value.ToString
        txtメニュー名3.Text = dgvData("メニュー名3", 0).Value.ToString
        txtメニュー名4.Text = dgvData("メニュー名4", 0).Value.ToString
        txtメニュー名5.Text = dgvData("メニュー名5", 0).Value.ToString
        txt検索キー1.Text = dgvData("名称検索キー1", 0).Value.ToString
        txt検索キー2.Text = dgvData("名称検索キー2", 0).Value.ToString
        txt検索キー3.Text = dgvData("名称検索キー3", 0).Value.ToString
        '-------------------------------------------------------------------------------------------------------------------------
        'オーダー名称設定
        Dim DB出力先指定1() As String
        DB出力先指定1 = {"D--:グランドメニューに従う", "P--:グランドメニューに従う"}
        cmb出力先指定1.DataSource = DB出力先指定1
        cmb出力先指定1.SelectedIndex = -1
        Dim DB出力先指定2() As String
        DB出力先指定2 = {"D--:グランドメニューに従う", "P--:グランドメニューに従う"}
        cmb出力先指定2.DataSource = DB出力先指定2
        cmb出力先指定2.SelectedIndex = -1
        Dim DB出力先指定3() As String
        DB出力先指定3 = {"D--:グランドメニューに従う", "P--:グランドメニューに従う"}
        cmb出力先指定3.DataSource = DB出力先指定3
        cmb出力先指定3.SelectedIndex = -1
        Dim DB出力先指定4() As String
        DB出力先指定4 = {"D--:グランドメニューに従う", "P--:グランドメニューに従う"}
        cmb出力先指定4.DataSource = DB出力先指定4
        cmb出力先指定4.SelectedIndex = -1
        Dim DB出力先指定5() As String
        DB出力先指定5 = {"D--:グランドメニューに従う", "P--:グランドメニューに従う"}
        cmb出力先指定5.DataSource = DB出力先指定5
        cmb出力先指定5.SelectedIndex = -1
        Dim DB出力先指定6() As String
        DB出力先指定6 = {"D--:グランドメニューに従う", "P--:グランドメニューに従う"}
        cmb出力先指定6.DataSource = DB出力先指定6
        cmb出力先指定6.SelectedIndex = -1
        Dim DB出力順位1() As String
        DB出力順位1 = {"0", "99"}
        cmb出力順位1.DataSource = DB出力順位1
        cmb出力順位1.SelectedIndex = 0
        Dim DB出力順位2() As String
        DB出力順位2 = {"0", "99"}
        cmb出力順位2.DataSource = DB出力順位2
        cmb出力順位2.SelectedIndex = 0
        Dim DB出力順位3() As String
        DB出力順位3 = {"0", "99"}
        cmb出力順位3.DataSource = DB出力順位3
        cmb出力順位3.SelectedIndex = 0
        Dim DB出力順位4() As String
        DB出力順位4 = {"0", "99"}
        cmb出力順位4.DataSource = DB出力順位4
        cmb出力順位4.SelectedIndex = 0
        Dim DB出力順位5() As String
        DB出力順位5 = {"0", "99"}
        cmb出力順位5.DataSource = DB出力順位5
        cmb出力順位5.SelectedIndex = 0
        Dim DB出力順位6() As String
        DB出力順位6 = {"0", "99"}
        cmb出力順位6.DataSource = DB出力順位6
        cmb出力順位6.SelectedIndex = 0
        '-------------------------------------------------------------------------------------------------------------------------
        '-------------------------------------------------------------------------------------------------------------------------
        'セットメニューの設定
        msSQL = ""
        msSQL += "select グループ番号 As 番号,グループ名 As 名称 "
        msSQL += "from POS_Mグルーピング "
        msSQL += "Order By グループ番号"

        mCommand = cDB.getsqlComand(msSQL)
        mSDA.SelectCommand = mCommand

        Call mSDA.Fill(dtbl出力可能) ''データセット作成

        dgvグループ名一覧.DataSource = dtbl出力可能

        Dim DB設定区分() As String
        DB設定区分 = {"セレクト", "ノンセレクト", "時価"}
        cmb設定区分.DataSource = DB設定区分
        cmb設定区分.SelectedIndex = 0
        Dim DBハンディ表示() As String
        DBハンディ表示 = {"表示", "なし"}
        cmbハンディ表示.DataSource = DBハンディ表示
        cmbハンディ表示.SelectedIndex = 0
        Dim DB数量エラーチェック() As String
        DB数量エラーチェック = {"チェックなし",
                                "メニュー数＝グループのセレクト数量",
                                "メニュー数≧グループのセレクト数量",
                                "メニュー数≦グループのセレクト数量",
                                "メニュー数＝グループのセレクト数量×２",
                                "メニュー数＝グループのセレクト数量×３"}
        cmb数量エラーチェック.DataSource = DB数量エラーチェック
        cmb数量エラーチェック.SelectedIndex = 0
        '-------------------------------------------------------------------------------------------------------------------------
        'タブのサイズを変更できるようにする
        tab登録設定.SizeMode = TabSizeMode.Fixed
        'タブのサイズを 横140x縦40 にする
        tab登録設定.ItemSize = New Size(300, 30)

        tabオーダー設定.SizeMode = TabSizeMode.Fixed
        tabオーダー設定.ItemSize = New Size(140, 30)
        '-------------------------------------------------------------------------------------------------------------------------
        '-------------------------------------------------------------------------------------------------------------------------
        Call cDB.Close()

        '画面右側の「出力する項目」グリッドの設定
        dgvサブ情報.DataSource = dtbl出力する項目
        dtbl出力する項目.Columns.Add("番号")
        dtbl出力する項目.Columns.Add("名称")

    End Sub
    Private Sub txt商品CD_TextChanged(sender As Object, e As EventArgs) Handles txt商品CD.TextChanged
        '入力文字数を13桁に制限
        txt商品CD.MaxLength = 13

    End Sub

    Private Sub btn更新_Click(sender As Object, e As EventArgs) Handles btn更新.Click
        MessageBox.Show("未設定です。", "SpreadNPC", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub btnクリア_Click(sender As Object, e As EventArgs) Handles btnクリア.Click
        'If txt付加金額.Text = "0" Then
        '    'MessageBox.Show("", "SpreadNPC", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'Else
        MessageBox.Show("この商品に設定した付加情報をクリアします。
よろしいですか？", "SpreadNPC", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)

        dgvサブ情報.DataSource = Nothing
        'dgvサブ情報.Columns.Clear()
        'End If

    End Sub

    Private Sub btnキャンセル_Click(sender As Object, e As EventArgs) Handles btnキャンセル.Click
        'If txt付加金額.Text = "0" Then
        '    'MessageBox.Show("", "SpreadNPC", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'Else
        MessageBox.Show("編集された内容を保存せずにキャンセルします。
よろしいですか？", "SpreadNPC", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)

        'End If

        Me.Close()

    End Sub

    Private Sub btnエクスポート_Click(sender As Object, e As EventArgs) Handles btnエクスポート.Click
        MessageBox.Show("実行時エラー'-2147217900(80040e14)';

マルチパート識別子 ''POS_M課税_TO_課税区分名''をバインドできませんでした。", "SpreadNPC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End Sub
    Private Sub btn終了_Click(sender As Object, e As EventArgs) Handles btn終了.Click
        Dim menu As New frmフォームメニュー
        Call menu.ShowDialog()

    End Sub

    Private Sub txt付加金額_TextChanged(sender As Object, e As EventArgs) Handles txt付加金額.TextChanged
        If txt付加金額.Text = "0" Then
            'MessageBox.Show("", "SpreadNPC", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("付加金額は変更できません！「0」に[戻します。", "SpreadNPC", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub btn選択_Click(sender As Object, e As EventArgs) Handles btn選択.Click
        '-------------------------------------------------------------------------------------
        MoveToGrid(dtbl出力可能,
                    dtbl出力する項目,
                    dgvグループ名一覧
                    )
        '-------------------------------------------------------------------------------------
        'Dim cDB As New clsDB
        'Dim msSQL As String
        'Dim mSDA As New SqlDataAdapter
        'Dim Dataグループ As New DataTable

        'msSQL = ""
        'msSQL += "select グループ番号 As 番号,グループ名 As 名称 "
        'msSQL += "from POS_Mグルーピング "
        'msSQL += "where グループ番号 = "
        'msSQL += "'" + txt番号.Text + "'"
        'msSQL += "Order By グループ番号"

        'mCommand = cDB.getsqlComand(msSQL)
        'mSDA.SelectCommand = mCommand

        'Call mSDA.Fill(Dataグループ) ''データセット作成

        'dgvサブ情報.DataSource = Dataグループ
        '-------------------------------------------------------------------------------------
        ''メッセージ表示用の変数
        'Dim strMessageList As String

        ''選択しているセルの値の取得
        'strMessageList = "選択しているセルの値：" & dgvグループ名一覧.SelectedCells(0).Value & vbCrLf

        ''選択している行番号の取得
        'strMessageList = strMessageList & "選択しているセルの行番号：" & dgvグループ名一覧.SelectedCells(0).RowIndex & vbCrLf

        ''選択している列番号の取得
        'strMessageList = strMessageList & "選択しているセルの列番号：" & dgvグループ名一覧.SelectedCells(0).ColumnIndex & vbCrLf

        ''メッセージボックスで表示
        'MsgBox(strMessageList)
        '--------------------------------以下テスト-----------------------------------------------------
        ''1行追加
        'dgvグループ名一覧.Rows.Add()

        ''登録した行番号を取得
        'Dim maxRowNum As Integer
        'maxRowNum = dgvグループ名一覧.Rows.Count

        ''最終行に値を仮の値をセット
        'dgvグループ名一覧.Rows(maxRowNum - 1).Cells(0).Value = maxRowNum
        'dgvグループ名一覧.Rows(maxRowNum - 1).Cells(1).Value = "ユーザ_追加"
        'dgvグループ名一覧.Rows(maxRowNum - 1).Cells(2).Value = "XX"
        'dgvグループ名一覧.Rows(maxRowNum - 1).Cells(3).Value = "ＸＸ"
        '-------------------------------------------------------------------------------------
        'Dim dt As DataTable 'employee
        'Dim row As DataRow = dt.NewRow '追加行を宣言

        ''値をセット
        'row("id") = "4"
        'row("first_name") = "四郎"
        'row("last_name") = "鈴木"
        'row("department_id") = "2"
        'row("height") = "155"

        ''テーブルの末尾に追加
        'dt.Rows.Add(row)
        '-------------------------------------------------------------------------------------
        'dgvサブ情報(0, 選択済表Count).Value = (選択済表Count + 1).ToString         '行　NO

        'dgvサブ情報(1, 選択済表Count).Value = txt商品CD.Text.ToString
        'dgvサブ情報(1, 選択済表Count).Value = txt名称.Text.ToString
        'dgvサブ情報(1, 選択済表Count).Value = txt設定.Text.ToString

        '選択済表Count = 選択済表Count + 1       'Count UP
        '-------------------------------------------------------------------------------------
        ''DataTableの変数宣言
        'Dim dt As New DataTable("people")

        ''列追加
        'dt.Columns.Add("列名")

        ''行の設定
        'Dim dtRow As DataRow
        'dtRow = dt.NewRow
        'dtRow("列名") = "任意の値"

        ''行追加
        'dt.Rows.Add(dtRow)

        'dgvサブ情報.DataSource = dt
        '-------------------------------------------------------------------------------------
    End Sub
    Private Sub btn取消_Click(sender As Object, e As EventArgs) Handles btn取消.Click

        dgvサブ情報.DataSource = Nothing
        'dgvサブ情報.Columns.Clear()

    End Sub

    Private Sub cmb設定区分_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb設定区分.SelectedIndexChanged
        If cmb設定区分.Text = "時価" Then
            MessageBox.Show("時価の設定はできません！", "SpreadNPC", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub
    Private Sub dgvグループ名一覧_SelectionChanged(sender As Object, e As EventArgs) Handles dgvグループ名一覧.SelectionChanged
        txt番号.Text = dgvグループ名一覧(0, dgvグループ名一覧.CurrentRow.Index).Value.ToString()
        txt名称.Text = dgvグループ名一覧(1, dgvグループ名一覧.CurrentRow.Index).Value.ToString()

    End Sub
End Class