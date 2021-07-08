Imports System.Data
Imports System.Data.SqlClient

Public Class frm105商品登録
    Private Shared _mutex As System.Threading.Mutex

    Private msSQL As String
    Private mCommand As SqlCommand
    Private mSDA As New SqlDataAdapter

    Dim tblComboList As New DataTable   'POSパターンComboBoxに登録するデータリスト
    Dim tblBumon As New DataTable   '部門ComboBoxに登録するデータリスト
    Dim tblBunrui As New DataTable   '分類ComboBoxに登録するデータリスト
    Public Sub frm105商品登録_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '-------------------------------------------------------------------------------------------------------------------------
        Dim cDB As New clsDB
        Dim msSQL As String
        '-------------------------------------------------------------------------------------------------------------------------
        '-------------------------------------------------------------------------------------------------------------------------
        'データベースから取得したいデータ群をSQLで検索
        msSQL = ""
        msSQL += "SELECT POSパターン,パターン名称 "
        msSQL += "FROM POS_MPOSパターン "
        msSQL += "ORDER BY POSパターン"

        mCommand = cDB.getsqlComand(msSQL)
        mSDA.SelectCommand = mCommand
        Call mSDA.Fill(tblComboList) ''データセット作成

        'SQLで検索したデータ群のレコードを、1レコードずつ取り出す
        For nRowCounter As Integer = 0 To tblComboList.Rows.Count - 1
            cmbPOSパターン.Items.Add(tblComboList.Rows(nRowCounter).Item("パターン名称").ToString())
        Next
        cmbPOSパターン.SelectedIndex = -1
        '-------------------------------------------------------------------------------------------------------------------------
        Dim DB表示内容() As String
        DB表示内容 = {"全て", "設定済のみ", "未設定のみ"}

        cmb表示内容.DataSource = DB表示内容
        '-------------------------------------------------------------------------------------------------------------------------
        ' 部門ComboBoxのデータ設定
        msSQL = "Select 部門CD, 部門名 "
        msSQL += "FROM POS_M部門 "
        msSQL += "ORDER BY 部門CD"

        mCommand = cDB.getsqlComand(msSQL)
        mSDA.SelectCommand = mCommand
        Call mSDA.Fill(tblBumon)

        cmb部門.Items.Add("全ての部門")
        For nRowCounter As Integer = 0 To tblBumon.Rows.Count - 1
            cmb部門.Items.Add(tblBumon.Rows(nRowCounter).Item("部門名").ToString())
        Next
        cmb部門.SelectedIndex = 0
        '-------------------------------------------------------------------------------------------------------------------------
        ' 分類ComboBoxのデータ設定
        msSQL = "Select 分類CD, 分類名 "
        msSQL += "FROM POS_M分類 "
        msSQL += "ORDER BY 分類CD"

        mCommand = cDB.getsqlComand(msSQL)
        mSDA.SelectCommand = mCommand
        Call mSDA.Fill(tblBunrui)

        cmb分類.Items.Add("全ての分類")
        For nRowCounter As Integer = 0 To tblBunrui.Rows.Count - 1
            cmb分類.Items.Add(tblBunrui.Rows(nRowCounter).Item("分類名").ToString())
        Next
        cmb分類.SelectedIndex = 0
        '-------------------------------------------------------------------------------------------------------------------------
        Call cDB.Close()
        '-------------------------------------------------------------------------------------------------------------------------

        ''登録画面用テスト
        'SetGridData()

    End Sub
    Private Sub btn読込_Click(sender As Object, e As EventArgs) Handles btn読込.Click
        If cmbPOSパターン.Text = Nothing Then
            MessageBox.Show("POSパターンを選択してください。", "SpreadNPC", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ElseIf txt商品CD.Text = Nothing Then
            MessageBox.Show("商品CDを入力してください。", "SpreadNPC", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else
            Dim sfrm As New frm105商品登録_登録画面

            MessageBox.Show("該当する商品マスタは存在しません。", "SpreadNPC", MessageBoxButtons.OK, MessageBoxIcon.Information)

            'フォームの表示位置をMeの左上に固定
            sfrm.StartPosition = FormStartPosition.Manual
            sfrm.Left = Me.Left
            sfrm.Top = Me.Top
            sfrm.Owner = Me
            Call sfrm.ShowDialog()

        End If

    End Sub

    Private Sub btn検索_Click(sender As Object, e As EventArgs) Handles btn検索.Click
        If cmbPOSパターン.Text = Nothing Then
            MessageBox.Show("POSパターンを選択してください。", "SpreadNPC", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else
            Dim sfrm0 As New frm105商品登録_検索画面

            'フォームの表示位置をMeの左上に固定
            sfrm0.StartPosition = FormStartPosition.Manual
            sfrm0.Left = Me.Left
            sfrm0.Top = Me.Top
            sfrm0.Owner = Me

            sfrm0.strPosName0 = cmbPOSパターン.SelectedItem.ToString
            sfrm0.nPosNo0 = tblComboList.Rows(cmbPOSパターン.SelectedIndex).Item("POSパターン")

            Call sfrm0.ShowDialog()

        End If
    End Sub

    Private Sub btnコピー_Click(sender As Object, e As EventArgs) Handles btnコピー.Click
        If cmbPOSパターン.Text = Nothing Then
            MessageBox.Show("POSパターンを選択してください。", "SpreadNPC", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else
            Dim sfrm As New frm105商品登録_コピー画面

            ''フォームを(750, 200)の位置に表示する
            sfrm.StartPosition = FormStartPosition.Manual
            sfrm.Left = Me.Left + 620
            sfrm.Top = Me.Top + 100
            ''スタート位置を中央に指定
            'sfrm.Left = Me.Left + (Me.Width - sfrm.Width) \ 2
            'sfrm.Top = Me.Top + (Me.Height - sfrm.Height) \ 4
            sfrm.Owner = Me ' 常に親ウィンドウの手前に表示

            '-------------------------------------------------------------------------------------------------------------------------
            ''サブfrmの親はMeよ
            'sfrm.frm親 = Me
            '-------------------------------------------------------------------------------------------------------------------------
            ''サブfrmに特定のデータだけ渡す場合（frm105商品登録_コピー画面）
            sfrm.strPosPtnName = cmbPOSパターン.SelectedText
            sfrm.nPosPtnNo = tblComboList.Rows(cmbPOSパターン.SelectedIndex).Item("POSパターン")
            '-------------------------------------------------------------------------------------------------------------------------
            'モーダルで表示
            Call sfrm.ShowDialog()

        End If

    End Sub

    Private Sub btnエクスポート_Click(sender As Object, e As EventArgs) Handles btnエクスポート.Click
        If cmbPOSパターン.Text = Nothing Then
            MessageBox.Show("POSパターンを選択してください。", "SpreadNPC", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("実行時エラー'-2147217900(80040e14)';

                            マルチパート識別子 ''POS_M課税_TO_課税区分名''をバインドできませんでした。", "SpreadNPC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

    End Sub
    Private Sub btn条件クリア_Click(sender As Object, e As EventArgs) Handles btn条件クリア.Click
        If cmbPOSパターン.Text = Nothing Then
            cmbPOSパターン.SelectedIndex = -1
            cmb表示内容.SelectedIndex = 0
            cmb部門.SelectedIndex = 0
            cmb分類.SelectedIndex = 0
            txt文字検索類.Text = ""
        Else
            Dim cDB As New clsDB
            Dim msSQL As String
            Dim tblComboList As New DataTable   'POSパターンComboBoxに登録するデータリスト

            msSQL = "Select 商品CD,検索カナ As メニュータイプ,品目名 As 商品名,部門名,a.課税区分,
                      取引単価 AS 単価,a.課税区分 As 課税区分_TO,取引単価 As 単価_TO,食券発行 AS 食券,
                      品目CD,サブ_設定区分1 As 設定,テイクアウト可否,販売開始日付,販売終了日付,
                      出力先_マージ1 As 出力先1,出力先_マージ2 As 出力先2,出力先_マージ3 As 出力先3,
                      出力先_マージ4 As 出力先4,出力先_マージ5 As 出力先5,出力先_マージ6 As 出力先6 "
            msSQL += "From POS_M品目 As a, POS_M部門 As b "
            msSQL += "Where a.部門CD = b.部門CD"

            mCommand = cDB.getsqlComand(msSQL)
            mSDA.SelectCommand = mCommand

            Call mSDA.Fill(tblComboList)

            dgv一覧.DataSource = tblComboList

            Call cDB.Close()

            'cmbPOSパターン.SelectedIndex = -1
            cmb表示内容.SelectedIndex = 0
            cmb部門.SelectedIndex = 0
            cmb分類.SelectedIndex = 0
            txt文字検索類.Text = ""
        End If

        ''dgvの内容をクリアする
        'dgv一覧.DataSource = ""

    End Sub
    Private Sub btn終了_Click(sender As Object, e As EventArgs) Handles btn終了.Click
        Me.Close()
    End Sub

    Private Sub cmbPOSパターン_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPOSパターン.SelectedIndexChanged
        Dim cDB As New clsDB
        Dim msSQL As String
        Dim tblComboList As New DataTable   'POSパターンComboBoxに登録するデータリスト

        msSQL = "Select "
        msSQL += "商品CD,"
        msSQL += "検索カナ As メニュータイプ,"
        msSQL += "品目名 As 商品名,"
        msSQL += "部門名, "
        msSQL += "c.分類CD,"
        msSQL += "c.分類名,"
        msSQL += "a.課税区分,"
        msSQL += "取引単価 As 単価,"
        msSQL += "a.課税区分 As 課税区分_TO,"
        msSQL += "取引単価 As 単価_TO,"
        msSQL += "食券発行 As 食券,"
        msSQL += "品目CD,"
        msSQL += "サブ_設定区分1 As 設定,"
        msSQL += "テイクアウト可否,"
        msSQL += "販売開始日付,"
        msSQL += "販売終了日付,"
        msSQL += "出力先_マージ1 As 出力先1,"
        msSQL += "出力先_マージ2 As 出力先2,"
        msSQL += "出力先_マージ3 As 出力先3,"
        msSQL += "出力先_マージ4 As 出力先4,"
        msSQL += "出力先_マージ5 As 出力先5,"
        msSQL += "出力先_マージ6 As 出力先6 "
        msSQL += "From (POS_MP品目 As a inner join POS_M部門 As b on a.部門CD = b.部門CD)
                  inner join POS_M分類 As c on a.分類CD = c.分類CD "
        If cmb分類.SelectedIndex > 0 Then
            msSQL += "AND 部門名 = '" + cmb部門.SelectedItem.ToString() + "' "
        End If
        If cmb分類.SelectedIndex > 0 Then
            msSQL += "AND 分類名 = '" + cmb分類.SelectedItem.ToString() + "' "
        End If
        If txt文字検索類.TextLength >= 1 Then
            msSQL += "AND 検索カナ LIKE '%" + txt文字検索類.Text + "%' "
        End If
        msSQL += "Order By 商品CD"
        '-------------------------------------------------------------------------------------------------------------------------
        ''msSQL = "Select 商品CD,検索カナ As メニュータイプ,品目名 As 商品名,部門名,a.課税区分,
        ''        取引単価 AS 単価,a.課税区分 As 課税区分_TO,取引単価 As 単価_TO,食券発行 AS 食券,
        ''        品目CD,サブ_設定区分1 As 設定,テイクアウト可否,販売開始日付,販売終了日付,
        ''        出力先_マージ1 As 出力先1,出力先_マージ2 As 出力先2,出力先_マージ3 As 出力先3,
        ''        出力先_マージ4 As 出力先4,出力先_マージ5 As 出力先5,出力先_マージ6 As 出力先6 "
        ''msSQL += "From POS_M品目 As a, POS_M部門 As b "
        ''msSQL += "Where a.部門CD = b.部門CD"
        '-------------------------------------------------------------------------------------------------------------------------
        mCommand = cDB.getsqlComand(msSQL)
        mSDA.SelectCommand = mCommand

        Call mSDA.Fill(tblComboList)

        dgv一覧.DataSource = tblComboList

    End Sub

    Private Sub txt商品CD_TextChanged(sender As Object, e As EventArgs) Handles txt商品CD.TextChanged
        '入力文字数を13桁に制限
        txt商品CD.MaxLength = 13

    End Sub

    Private Sub cmb表示内容_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb表示内容.SelectedIndexChanged
        If cmbPOSパターン.Text = Nothing Then
            'MessageBox.Show("POSパターンを選択してください。", "SpreadNPC", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim cDB As New clsDB
            Dim msSQL As String
            Dim tblHyouji As New DataTable   '表示内容ComboBoxに登録するデータリスト

            msSQL = "Select 商品CD,検索カナ As メニュータイプ,品目名 As 商品名,部門名,a.課税区分,
                    取引単価 AS 単価,a.課税区分 As 課税区分_TO,取引単価 As 単価_TO,食券発行 AS 食券,
                    品目CD,サブ_設定区分1 As 設定,テイクアウト可否,販売開始日付,販売終了日付,
                    出力先_マージ1 As 出力先1,出力先_マージ2 As 出力先2,出力先_マージ3 As 出力先3,
                    出力先_マージ4 As 出力先4,出力先_マージ5 As 出力先5,出力先_マージ6 As 出力先6 "
            msSQL += "From POS_M品目 As a, POS_M部門 As b "
            msSQL += "Where a.部門CD = b.部門CD "
            ''↓ダミー↓
            msSQL += "AND 登録日 = 20191130 "
            msSQL += "Order By 商品CD"

            mCommand = cDB.getsqlComand(msSQL)
            mSDA.SelectCommand = mCommand

            Call mSDA.Fill(tblHyouji)

            dgv一覧.DataSource = tblHyouji
        End If

    End Sub

    Private Sub cmb部門_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb部門.SelectedIndexChanged
        If cmbPOSパターン.Text = Nothing Then
            'MessageBox.Show("POSパターンを選択してください。", "SpreadNPC", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim cDB As New clsDB
            Dim msSQL As String
            Dim tblBumon As New DataTable

            msSQL = "Select "
            msSQL += "商品CD,"
            msSQL += "検索カナ As メニュータイプ,"
            msSQL += "品目名 As 商品名,"
            msSQL += "部門名, "
            msSQL += "c.分類CD,"
            msSQL += "c.分類名,"
            msSQL += "a.課税区分,"
            msSQL += "取引単価 As 単価,"
            msSQL += "a.課税区分 As 課税区分_TO,"
            msSQL += "取引単価 As 単価_TO,"
            msSQL += "食券発行 As 食券,"
            msSQL += "品目CD,"
            msSQL += "サブ_設定区分1 As 設定,"
            msSQL += "テイクアウト可否,"
            msSQL += "販売開始日付,"
            msSQL += "販売終了日付,"
            msSQL += "出力先_マージ1 As 出力先1,"
            msSQL += "出力先_マージ2 As 出力先2,"
            msSQL += "出力先_マージ3 As 出力先3,"
            msSQL += "出力先_マージ4 As 出力先4,"
            msSQL += "出力先_マージ5 As 出力先5,"
            msSQL += "出力先_マージ6 As 出力先6 "
            msSQL += "From (POS_M品目 As a inner join POS_M部門 As b on a.部門CD = b.部門CD)
                      inner join POS_M分類 As c on a.分類CD = c.分類CD "
            If cmb部門.SelectedIndex > 0 Then
                msSQL += "AND 部門名 = '" + cmb部門.SelectedItem.ToString() + "' "
            End If
            'msSQL += "AND 部門名 = '" + cmb部門.SelectedItem.ToString() + "' "
            If cmb分類.SelectedIndex > 0 Then
                msSQL += "AND 分類名 = '" + cmb分類.SelectedItem.ToString() + "' "
            End If
            If txt文字検索類.TextLength > 0 Then
                msSQL += "AND 検索カナ LIKE '%" + txt文字検索類.Text + "%' "
            End If
            msSQL += "Order By 商品CD"

            'msSQL = "Select 商品CD,検索カナ As メニュータイプ,品目名 As 商品名,部門名,a.課税区分,
            '        取引単価 AS 単価,a.課税区分 As 課税区分_TO,取引単価 As 単価_TO,食券発行 AS 食券,
            '        品目CD,サブ_設定区分1 As 設定,テイクアウト可否,販売開始日付,販売終了日付,
            '        出力先_マージ1 As 出力先1,出力先_マージ2 As 出力先2,出力先_マージ3 As 出力先3,
            '        出力先_マージ4 As 出力先4,出力先_マージ5 As 出力先5,出力先_マージ6 As 出力先6 "
            'msSQL += "From POS_M品目 As a, POS_M部門 As b "
            'msSQL += "Where a.部門CD = b.部門CD "
            'msSQL += "AND 部門名 = '" + cmb部門.SelectedItem.ToString() + "' "
            'msSQL += "Order By 商品CD"

            mCommand = cDB.getsqlComand(msSQL)
            mSDA.SelectCommand = mCommand

            Call mSDA.Fill(tblBumon)

            dgv一覧.DataSource = tblBumon
        End If

    End Sub

    Private Sub cmb分類_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb分類.SelectedIndexChanged
        If cmbPOSパターン.Text = Nothing Then
            'MessageBox.Show("POSパターンを選択してください。", "SpreadNPC", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim cDB As New clsDB
            Dim msSQL As String
            Dim tblBunrui As New DataTable

            msSQL = "Select "
            msSQL += "商品CD,"
            msSQL += "検索カナ As メニュータイプ,"
            msSQL += "品目名 As 商品名,"
            msSQL += "部門名, "
            'msSQL += "c.分類CD,"
            'msSQL += "c.分類名,"
            msSQL += "a.課税区分,"
            msSQL += "取引単価 As 単価,"
            msSQL += "a.課税区分 As 課税区分_TO,"
            msSQL += "取引単価 As 単価_TO,"
            msSQL += "食券発行 As 食券,"
            msSQL += "品目CD,"
            msSQL += "サブ_設定区分1 As 設定,"
            msSQL += "テイクアウト可否,"
            msSQL += "販売開始日付,"
            msSQL += "販売終了日付,"
            msSQL += "出力先_マージ1 As 出力先1,"
            msSQL += "出力先_マージ2 As 出力先2,"
            msSQL += "出力先_マージ3 As 出力先3,"
            msSQL += "出力先_マージ4 As 出力先4,"
            msSQL += "出力先_マージ5 As 出力先5,"
            msSQL += "出力先_マージ6 As 出力先6 "
            msSQL += "From (POS_M品目 As a inner join POS_M部門 As b on a.部門CD = b.部門CD)
                      inner join POS_M分類 As c on a.分類CD = c.分類CD "
            If cmb部門.SelectedIndex > 0 Then
                msSQL += "AND 部門名 = '" + cmb部門.SelectedItem.ToString() + "' "
            End If
            If cmb分類.SelectedIndex > 0 Then
                msSQL += "AND 分類名 = '" + cmb分類.SelectedItem.ToString() + "' "
            End If
            If txt文字検索類.TextLength >= 1 Then
                msSQL += "AND 検索カナ LIKE '%" + txt文字検索類.Text + "%' "
            End If
            msSQL += "Order By 商品CD"

            mCommand = cDB.getsqlComand(msSQL)
            mSDA.SelectCommand = mCommand

            Call mSDA.Fill(tblBunrui)

            dgv一覧.DataSource = tblBunrui

            Call cDB.Close()
        End If

    End Sub

    Private Sub txt文字検索類_TextChanged(sender As Object, e As EventArgs) Handles txt文字検索類.TextChanged
        If cmbPOSパターン.Text = Nothing Then
            'MessageBox.Show("POSパターンを選択してください。", "SpreadNPC", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim cDB As New clsDB
            Dim msSQL As String
            Dim tblBunrui As New DataTable

            msSQL = "Select "
            msSQL += "商品CD,"
            msSQL += "検索カナ As メニュータイプ,"
            msSQL += "品目名 As 商品名,"
            msSQL += "部門名, "
            'msSQL += "c.分類CD,"
            'msSQL += "c.分類名,"
            msSQL += "a.課税区分,"
            msSQL += "取引単価 As 単価,"
            msSQL += "a.課税区分 As 課税区分_TO,"
            msSQL += "取引単価 As 単価_TO,"
            msSQL += "食券発行 As 食券,"
            msSQL += "品目CD,"
            msSQL += "サブ_設定区分1 As 設定,"
            msSQL += "テイクアウト可否,"
            msSQL += "販売開始日付,"
            msSQL += "販売終了日付, "
            msSQL += "出力先_マージ1 As 出力先1,"
            msSQL += "出力先_マージ2 As 出力先2,"
            msSQL += "出力先_マージ3 As 出力先3,"
            msSQL += "出力先_マージ4 As 出力先4,"
            msSQL += "出力先_マージ5 As 出力先5,"
            msSQL += "出力先_マージ6 As 出力先6 "
            msSQL += "From (POS_M品目 As a inner join POS_M部門 As b on a.部門CD = b.部門CD)
                      inner join POS_M分類 As c on a.分類CD = c.分類CD "
            If cmb部門.SelectedIndex > 0 Then
                msSQL += "AND 部門名 = '" + cmb部門.SelectedItem.ToString() + "' "
            End If
            If cmb分類.SelectedIndex > 0 Then
                msSQL += "AND 分類名 = '" + cmb分類.SelectedItem.ToString() + "' "
            End If
            If txt文字検索類.TextLength >= 1 Then
                msSQL += "AND 検索カナ LIKE '%" + txt文字検索類.Text + "%' "
            End If
            msSQL += "Order By 商品CD"

            mCommand = cDB.getsqlComand(msSQL)
            mSDA.SelectCommand = mCommand

            Call mSDA.Fill(tblBunrui)

            dgv一覧.DataSource = tblBunrui

            Call cDB.Close()
        End If

    End Sub
    Private Sub dgv一覧_SelectionChanged(sender As Object, e As EventArgs) Handles dgv一覧.SelectionChanged
        txtCD.Text = dgv一覧(0, dgv一覧.CurrentRow.Index).Value.ToString()

    End Sub

    Private Sub dgv一覧_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv一覧.CellDoubleClick
        'Dim sfrm As New frm105商品登録_登録画面

        ''フォームの表示位置をMeの左上に固定
        'sfrm.StartPosition = FormStartPosition.Manual
        'sfrm.Left = Me.Left
        'sfrm.Top = Me.Top
        'sfrm.Owner = Me
        'Call sfrm.ShowDialog()

        '↓登録画面用テスト↓
        Dim sfrm1 As New frm105商品登録_登録画面
        '-------------------------------------------------------------------------------------------------------------------------
        'サブfrm1にPOSパターンの情報を渡したい（frm105商品登録_登録画面）
        sfrm1.strPosPtnName1 = cmbPOSパターン.SelectedItem.ToString
        sfrm1.nPosPtnNo1 = tblComboList.Rows(cmbPOSパターン.SelectedIndex).Item("POSパターン")
        'サブfrm1に商品CDのテキストを渡したい（frm105商品登録_登録画面）
        sfrm1.ItemText1 = txtCD.Text
        '-------------------------------------------------------------------------------------------------------------------------
        'モーダルで表示
        Call sfrm1.ShowDialog()

    End Sub
    ''↓登録画面用テスト↓
    'Public Sub SetGridData()
    '    Dim cDB As New clsDB
    '    Dim msSQL As String
    '    Dim myTable As New DataTable

    '    'データベースから取得したいデータ群をSQLで検索
    '    msSQL = "SELECT * "
    '    msSQL += "FROM POS_M端末"

    '    mCommand = cDB.getsqlComand(msSQL)
    '    mSDA.SelectCommand = mCommand

    '    Call mSDA.Fill(myTable) 'データセット作成

    '    dgv一覧.DataSource = myTable

    '    Call cDB.Close()
    'End Sub

End Class
