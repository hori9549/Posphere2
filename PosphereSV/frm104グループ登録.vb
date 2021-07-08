
' 200321 グループの追加、削除 堀内良幸
'200718 グループ一覧表の列を種別に入替

Imports System.Data.SqlClient
Public Class Frm104グループ登録
    ''データベース接続用-------------------------------
    ' Private msSQL As String
    Private mCommand As SqlCommand
    Private mSDA As New SqlDataAdapter

    Dim PosNamSave As String = ""
    Dim PosIdSave As String = ""
    '   Private dtbl明細 As New DataTable
    Private Sub Frmグループ登録_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ControlBox = Not Me.ControlBox
        Dim tblComboList As New DataTable
        Dim cDB As New clsDB
        Dim msSQL As String

        'Dim setupcmb As New CmbSet
        'setupcmb.DbTabName = "POS_MPOSパターン"
        'setupcmb.cmbName = cmbPOSパターン
        'setupcmb.ValCol = "POSパターン"
        'setupcmb.DispCol = "パターン名称"

        'Call setupcmb.CmbSet()
        'MsgBox("cmbset終了")

        'POSパターンの検索SQL======================================================
        msSQL = ""
        msSQL += "SELECT POSパターン,パターン名称 "
        msSQL += "FROM POS_MPOSパターン "
        msSQL += "ORDER BY POSパターン"

        mCommand = cDB.getsqlComand(msSQL)
        mSDA.SelectCommand = mCommand

        Call mSDA.Fill(tblComboList)
        '=============================================================

        '空行追加-----------------------------------------------------
        Dim myRow As DataRow = tblComboList.NewRow
        myRow("POSパターン") = "0"
        myRow("パターン名称") = ""
        Call tblComboList.Rows.InsertAt(myRow, 0)

        With cmbPOSパターン
            .DisplayMember = "パターン名称"
            .ValueMember = "POSパターン"

            '      cmbPOSパターン.SelectedIndex = -1

            ''グリッド表示
            .SelectedValue = 0
            .DataSource = tblComboList.DefaultView

        End With
        '' SQLで検索したデータ群のレコードを、1レコードずつ取り出す
        'For nRowCounter As Integer = 0 To tblComboList.Rows.Count - 1
        '    strTemp = "" '次に「POSパターン」に登録する文字列を　クリア初期化：長さ０の文字列）する
        '    ''「CMBPOSパターン」に登録する文字列データの生成
        '    strTemp += tblComboList.Rows(nRowCounter).Item("POSパターン").ToString()
        '    strTemp += " : "
        '    strTemp += tblComboList.Rows(nRowCounter).Item("パターン名称").ToString()
        '    cmbPOSパターン.Items.Add(strTemp)

        'Next

        Call cDB.Close()

        '1. ！グループの新規登録！
        '    If MessageBox.Show("グループを新規登録しますか？", "新規登録",
        '                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question) =
        '                    DialogResult.Cancel Then Exit Sub
        '    btn読込.Enabled = True
        '    btnキャンセル.Enabled = True

        'Dim myTable As New DataTable()　　　　　　　　　　　　　　　   　　' POS_Mグルーピング の一覧を表示
        'msSQL = "SELECT  "
        'msSQL += "POSパターン,グループ番号,レコードタイプ,グループ名 "
        'msSQL += "FROM "
        'msSQL += "POS_Mグルーピング "
        'msSQL += "WHERE POSパターン='"
        'msSQL += "2' "
        'msSQL += "order by グループ番号"
        'mCommand = cDB.getsqlComand(msSQL)
        'mSDA.SelectCommand = mCommand
        'Call mSDA.Fill(myTable) ''データセット作成
        ''dgv一覧.DataSource = myTable
        ''dgv一覧.Rows.Count.ToString()
        'Call cDB.Close()
        'dgv一覧.DataSource = myTable

        btn読込.Enabled = False
        btnキャンセル.Enabled = False
        btn更新.Enabled = False
        btn更新.Enabled = False
        cmbPOSパターン.ItemHeight = 40
        Me.ActiveControl = Me.cmbPOSパターン

    End Sub

    Private Sub Btn読込_Click(sender As Object, e As EventArgs) Handles btn読込.Click

        '4.   グループ番号 は、入ってる？  
        '
        '   4.１ txt「グループ番号」欄に何かが入力されているとき場合
        '              
        '     4.1.1　欄 は整数か？　　No----->　　END SUB
        '     4.1.2　整数を5桁で０００埋め　

        '   4.2　グループ番号 が「ない」場合は、
        '　　　　　　SELECT max(グループ番号)+1 As grpNoMax froM POS_Mグルーピング をグループ番号とするーーー＞第２画面で


        Dim sfrm As New Frm104グループ登録_第2画面

        ' 4.
        If txtグループ番号.Text = "" Then
            '   4.2
            sfrm.lblGrpNo.Text = ""                      '  引き継ぐグループ番号に””
        Else
            '     4.1.1　欄 は整数か？　　No----->　　END SUB
            Dim Instr As String
            'Dim InNum As Integer
            'InNum = 0
            Instr = txtグループ番号.Text
            If IsNumeric(Instr) = True Then

                txtグループ番号.Text = Instr.PadLeft(5, "0")
                sfrm.lblGrpNo.Text = txtグループ番号.Text   '第2画面に引き継ぐグループ番号に"0000+”

            Else
                MessageBox.Show("整数を入力してください", "'" + txtグループ番号.Text + "'")         '+txtグループ番号.text+ )
                txtグループ番号.Text = ""
                Exit Sub
            End If
        End If
        ' sfrm.lblPosPtn.Text = PosNamSave
        sfrm.lblPosPtn.Text = PosIdSave

        sfrm.POSパターンID.Text = PosNamSave                            'PosIdSave: CmbPosパターン時にSave

        Call sfrm.ShowDialog(Owner)
        cmbPOSパターン.SelectedIndex = -1


        'myTable.Clear()     '何はともあれまずクリア

        'msSQL = "SELECT max(グループ番号） "        'データベースから取得したいデータ群をSQLで検索
        'msSQL += "from POS_Mグルーピング"

        'btn読込.Visible = True
        'lblグループ番号.Visible = True
        txtグループ番号.Enabled = True
        'mCommand = cDB.getsqlComand(msSQL)
        'mSDA.SelectCommand = mCommand
        'Call mSDA.Fill(myTable) ''データセット作成
        'dgv一覧.DataSource = myTable
        'dgv一覧.Rows.Count.ToString()
        'Call cDB.Close()
        'dgv一覧.DataSource = myTable



        '------------------------------------------------------------------
        '4.0  txtグループ番号が空白の場合- POSパターンに属するグループを表示 

        'myTable.Clear()     '何はともあれまずクリア

        'msSQL = "SELECT * "     'データベースから取得したいデータ群をSQLで検索
        'msSQL += "FROM "
        'msSQL += "POS_Mグルーピング "
        'msSQL += "where POSパターン="
        'msSQL += "'" + tblComboList.Rows(cmbPOSパターン.SelectedIndex).Item("POSパターン").ToString + "'"
        'mCommand = cDB.getsqlComand(msSQL)
        'mSDA.SelectCommand = mCommand
        'Call mSDA.Fill(myTable) ''データセット作成
        'dgv一覧.DataSource = myTable
        'dgv一覧.Rows.Count.ToString()
        'Call cDB.Close()
        'dgv一覧.DataSource = myTable
        'btnキャンセル.Enabled = True                'Btnキャンセル有効

        'Exit Sub            '-------->レコード番号の入力を待つ
        '----------------------------------------------------------------
        ' 4.1.1　グループ番号 が「ある」場合は、
        '          4.2.1.1 select * from POS_Mグルーピング where グループ番号＝'txtグループ番号'
        '                           「更新」または、「削除」を待つ
        '                           「Btn更新」、「Btn削除」をENABLEDへ

        'myTable.Clear()     '何はともあれまずクリア

        'msSQL = "SELECT * "     'データベースから取得したいデータ群をSQLで検索
        'msSQL += "FROM "
        'msSQL += "POS_Mグルーピング "
        'msSQL += "where グループ番号="
        'msSQL += "'" + txtグループ番号.Text + "'"
        'mCommand = cDB.getsqlComand(msSQL)
        'mSDA.SelectCommand = mCommand
        'Call mSDA.Fill(myTable) ''データセット作成

        'Call cDB.Close()
        'dgv一覧.DataSource = myTable
        '' btnキャンセル.Enabled = True                'Btnキャンセル有効


        ''sfrm.POSパターンID.Text = tblComboList.Rows(cmbPOSパターン.SelectedIndex).Item("POSパターン").ToString
        ''sfrm.lblPosPtn.Text = tblComboList.Rows(cmbPOSパターン.SelectedIndex).Item("パターン名称").ToString()
        '' sfrm.lblGrpNo.Text = txtグループ番号.Text("00000")                       '  先頭に'0'を足す

        'If dgv一覧.Rows.Count <= 0 Then            '新たな番号の場合　新規追加OK？
        '    sfrm.TxtNo2.Text = ""
        '    Call sfrm.ShowDialog()
        '    Me.Close()

        '    Exit Sub

        'End If                                      '既存の番号の場合
        'sfrm.TxtNo2.Text = dgv一覧(3, 0).Value.ToString("00000")                   '  先頭に'0'を足す
        'Call sfrm.ShowDialog()
        'Me.close()
        'Exit Sub
        ''Dim result As DialogResult =
        ''MessageBox.Show("新規追加OK？", " '" + txtグループ番号.Text + "'", MessageBoxButtons.OKCancel)
        ''If result = DialogResult.OK Then          '新たな番号の場合　新規追加
        ''    グループ名なしで登録してしまおう3 / 25
        ''    Dim cDB As New clsDB
        ''    Dim msSQL As String
        ''    Dim myTable As New DataTable

        ''    msSQL = "INSERT INTO POS_Mグルーピング"
        ''    msSQL += "(POSパターン,グループ番号,レコードタイプ,グループ名)"
        ''    msSQL += "values ("
        ''    msSQL += "'" + tblComboList.Rows(cmbPOSパターン.SelectedIndex).Item("POSパターン").ToString + "',"
        ''    msSQL += "'" + txtグループ番号.Text + "',"
        ''    msSQL += "'" + tblComboList.Rows(cmbPOSパターン.SelectedIndex).Item("レコードタイプ").ToString + "',"
        ''    msSQL += "'H',"
        ''    msSQL += "'')"

        ''    mCommand = cDB.getsqlComand(msSQL)
        ''    mSDA.SelectCommand = mCommand

        ''    Call mSDA.Fill(myTable) ''データセット作成

        ''    dgv一覧.DataSource = myTable
        ''    Call cDB.Close()

        ''    --------------結果表示」-----------------------
        ''    msSQL = "SELECT *  "
        ''    msSQL += "FROM "
        ''    msSQL += "POS_Mグルーピング"

        ''    mCommand = cDB.getsqlComand(msSQL)
        ''    mSDA.SelectCommand = mCommand

        ''Call mSDA.Fill(myTable) ''データセット作成

        ''    dgv一覧.DataSource = myTable

        ''    Call cDB.Close()
        ''    '--------第2画面にせんい---------
        ''    Dim sfrm As New Frm104グループ登録_第2画面

        ''    sfrm.POSパターンID.Text = tblComboList.Rows(cmbPOSパターン.SelectedIndex).Item("POSパターン").ToString
        ''    sfrm.lblPosPtn.Text = tblComboList.Rows(cmbPOSパターン.SelectedIndex).Item("パターン名称").ToString()
        ''    sfrm.lblGrpNo.Text = txtグループ番号.Text
        ''    sfrm.Txt新規か.Text = "NEW"
        ''    Call sfrm.ShowDialog()
        ''    Me.Close()

        ''グループ番号が存在したとき
        '    cmbPOSパターン.SelectedIndex = -1
        dgv一覧.DataSource = Nothing
        txtグループ番号.Text = ""
        'MessageBox.Show("更新？削除？", " '" + txtグループ番号.Text + "'")
        ' btn読込.Enabled = False
        '   btn更新.Enabled = True
        'btnキャンセル.Enabled = True
        'btn削除.Enabled = True
        'btn削除.Visible = True
        'btn更新.Visible = True
        '  btn読込.Visible = False
        '  Exit Sub


    End Sub

    Private Sub Btn終了_Click(sender As Object, e As EventArgs) Handles btn終了.Click
        Close()
    End Sub

    'Private Sub CmbPOSパターン_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPOSパターン.SelectedIndexChanged
    '    '   0.1 CmbPOSパターン_SelectedIndexChanged
    '    '       選択されたPOSパターンを持つグループを選んで一覧表示

    '    Dim cDB As New clsDB
    '    Dim msSQL As String
    '    Dim myTable As New DataTable
    '    msSQL = ""
    '    msSQL += "SELECT posパターン,グループ番号,(レコードタイプ),グループ名 "
    '    msSQL += "FROM POS_Mグルーピング "
    '    msSQL += "WHERE POSパターン = "
    '    msSQL += tblComboList.Rows(cmbPOSパターン.SelectedIndex).Item("POSパターン").ToString() + " "
    '    msSQL += "ORDER BY グループ番号 "
    '    mCommand = cDB.getsqlComand(msSQL)
    '    mSDA.SelectCommand = mCommand
    '    Call mSDA.Fill(myTable) ''データセット作成
    '    dgv一覧.DataSource = myTable      ''  「dgv一覧」に表示

    '    Call cDB.Close()
    'End Sub


    'Private Sub Btn更新_Click(sender As Object, e As EventArgs) Handles btn更新.Click
    '    Dim result As DialogResult =
    '       MessageBox.Show("メンバの更新しますか？", " '" + txtグループ番号.Text + "'", MessageBoxButtons.OKCancel)
    '    If result = DialogResult.OK Then          '新たな番号の場合　新規追加
    '        '--------第2画面にせんい---------
    '        Dim sfrm As New Frm104グループ登録_第2画面

    '        sfrm.POSパターンID.Text = tblComboList.Rows(cmbPOSパターン.SelectedIndex).Item("POSパターン").ToString
    '        sfrm.lblPosPtn.Text = tblComboList.Rows(cmbPOSパターン.SelectedIndex).Item("パターン名称").ToString()
    '        sfrm.lblGrpNo.Text = txtグループ番号.Text
    '        sfrm.新規Flag.Text = "NEW"
    '        Call sfrm.ShowDialog()
    '    End If

    'Dim cDB As New clsDB
    'Dim msSQL As String
    'Dim myTable As New DataTable

    'msSQL = "UPDATE POS_Mグルーピング "
    'msSQL += "Set "
    'msSQL += "メンバ1 = ' ',"
    'msSQL += "メンバ2='030',"
    'msSQL += "メンバ3='130',"
    'msSQL += "メンバ4='400' "
    'msSQL += " where グループ番号='30005' "

    ''  msSQL = "INSERT INTO POS_Mグルーピング(POSパターン)(グループ番号)(レコードタイプ)(グループ名)
    ''values ('3','30005','G','あいうえお')"
    ''msSQL = "INSERT INTO POS_M分類(分類CD,分類名) values ('010050','あいうえお')"
    'mCommand = cDB.getsqlComand(msSQL)
    'mSDA.SelectCommand = mCommand

    'Call mSDA.Fill(myTable) ''データセット作成

    'dgv一覧.DataSource = myTable
    'Call cDB.Close()

    ''--------------結果表示」-----------------------
    'myTable.Rows.Clear()
    'msSQL = "SELECT *  "
    'msSQL += "FROM "
    'msSQL += "POS_Mグルーピング"

    'mCommand = cDB.getsqlComand(msSQL)
    'mSDA.SelectCommand = mCommand

    'Call mSDA.Fill(myTable) ''データセット作成

    'dgv一覧.DataSource = myTable

    'Call cDB.Close()
    '  End Sub

    Private Sub Btn削除_Click(sender As Object, e As EventArgs) Handles btn削除.Click
        MessageBox.Show("本当に消すよ！", "'" + txtグループ番号.Text + "'")
        Dim cDB As New clsDB
        Dim msSQL As String
        Dim myTable As New DataTable

        msSQL = "DELETE from POS_Mグルーピング  where グループ番号="
        msSQL += "'" + txtグループ番号.Text + "'"
        mCommand = cDB.getsqlComand(msSQL)
        mSDA.SelectCommand = mCommand

        'Call mSDA.Fill(myTable) ''データセット作成

        'dgv一覧.DataSource = myTable

        MessageBox.Show(" 1レコードを削除しました", "'" + txtグループ番号.Text + "'")
        Call cDB.Close()

        ''--------------結果表示」-----------------------
        txtグループ番号.Text = ""

        msSQL = "SELECT *  "
        msSQL += "FROM "
        msSQL += "POS_Mグルーピング"

        mCommand = cDB.getsqlComand(msSQL)
        mSDA.SelectCommand = mCommand

        Call mSDA.Fill(myTable) ''データセット作成

        dgv一覧.DataSource = myTable

        Call cDB.Close()
    End Sub

    Private Sub Btnエクスポート_Click(sender As Object, e As EventArgs) Handles btnエクスポート.Click
        Dim sfrm As New frm125エクスポート画面

        '変数を共通にしてもらう？
        sfrm.tgtTableName = "POS_Mグルーピング"

        Call sfrm.ShowDialog()

        'Dim cDB As New clsDB
        'Dim msSQL As String
        'Dim myTable As New DataTable

        'msSQL = "INSERT INTO POS_Mグルーピング(POSパターン,グループ番号,レコードタイプ,グループ名) values ('3','0010','D','Group10')"
        '' msSQL = "INSERT INTO POS_M分類(分類CD,分類名) values ('010050','あいうえお')"

        'mCommand = cDB.getsqlComand(msSQL)
        'mSDA.SelectCommand = mCommand

        'Call mSDA.Fill(myTable) ''データセット作成

        'dgv一覧.DataSource = myTable
        'Call cDB.Close()

        ''--------------結果表示」-----------------------
        'msSQL = "SELECT *  "
        'msSQL += "FROM "
        'msSQL += "POS_Mグルーピング"

        'mCommand = cDB.getsqlComand(msSQL)
        'mSDA.SelectCommand = mCommand

        'Call mSDA.Fill(myTable) ''データセット作成

        'dgv一覧.DataSource = myTable

        'Call cDB.Close()
    End Sub

    'Private Sub Dgv一覧_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv一覧.CellContentClick
    '    txtグループ番号.Text = dgv一覧(1, dgv一覧.CurrentRow.Index).Value.ToString()
    '    btnエクスポート.Enabled = False     'BTNエクスポートはさわらないで！
    '    btn削除.Enabled = False             'btn削除はさわらないで！
    '    ' btn読込.Enabled = False             'btn読込はさわらないで！
    '    MessageBox.Show("グループ番号をクリックするかNewナンバーを入力して「読込」ボタンを押して")
    'End Sub
    'Private Sub Dgv一覧_SelectionChanged(sender As Object, e As EventArgs) Handles dgv一覧.SelectionChanged
    '    '    txtグループ番号.Text = dgv一覧(0, dgv一覧.CurrentRow.Index).Value.ToString()
    '    txtグループ番号.Text = dgv一覧(1, dgv一覧.CurrentRow.Index).Value.ToString()
    '    btnエクスポート.Enabled = False     'BTNエクスポートはさわらないで！
    '    btn削除.Enabled = False             'btn削除はさわらないで！
    '    ' btn読込.Enabled = False             'btn読込はさわらないで！

    'End Sub

    'Private Sub cmbPOSパターン_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbPOSパターン.SelectedValueChanged

    Private Sub cmbPOSパターン_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPOSパターン.SelectedIndexChanged
        If cmbPOSパターン.SelectedIndex <= 0 Then
            Exit Sub
        End If
        '0. イベントの始まり
        dgv一覧.DataSource = Nothing
        '   POSパターンを選択されたとき「読込」ボタンを解除する
        btn読込.Enabled = True
        btn読込.Visible = True
        btn削除.Enabled = False
        '   btn削除.Visible = False

        txtグループ番号.Enabled = True
        'lblグループ番号.Visible = True
        'Dim sfrm As New Frm104グループ登録_第2画面                   'POSパターンの番号をSAVE .Item("パターン名称").ToString()

        'Dim cDB As New clsDB
        'Dim msSQL As String
        'Dim myTable As New DataTable
        PosIdSave = cmbPOSパターン.SelectedValue.ToString()
        PosNamSave = cmbPOSパターン.Text
        'MsgBox(cmbPOSパターン.Text)
        '''-------------- POSパターンの番号を取り出し＆ SAVE -----------------------
        'Dim SepCharLen As Integer = 3  '区切れ文字が” : ”の場合
        'Dim Item1Len As Integer
        'Dim SepCharIndx As Integer
        'Item1Len = cmbPOSパターン.Text.Length
        '' SepCharLen = SepChar.Length.ToString
        'SepCharIndx = cmbPOSパターン.Text.IndexOf(" : ", 0, Item1Len)
        ''            Item1 = cmbPOSパターン.Text.Substring(0)
        '' Exit Sub
        ''   Else
        ''Item1 = cmbPOSパターン.Text.Substring(0, cmbPOSパターン.Text.IndexOf(SepChar))
        'PosNamSave = cmbPOSパターン.Text.Substring(0, SepCharIndx)
        'PosIdSave = cmbPOSパターン.Text.Substring(SepCharIndx + SepCharLen)    '区切り文字の後ろ全部

        'msSQL = "select POS_MPOSパターン.POSパターン from POS_MPOSパターン "
        'msSQL += "where POS_MPOSパターン.パターン名称= "
        'msSQL += "'" + cmbPOSパターン.SelectedItem.ToString + "'"

        'mCommand = cDB.getsqlComand(msSQL)
        'mSDA.SelectCommand = mCommand
        'Call mSDA.Fill(myTable) ''データセット作成

        'sfrm.POSパターンID.Text = myTable.Rows(0).Item("POSパターン").ToString()                                   
        'PosNamSave = cmbPOSパターン.SelectedItem.ToString
        'PosIdSave = myTable.Rows(0).Item("POSパターン").ToString()    'PosIdSave: 第2画面に引き継ぐため  '**　♡ ♡ ♡ 使える１句
        'txtグループ番号.Visible = True
        'sfrm.Txt新規か.Text = myTable.Rows(0).Item("POSパターン").ToString()
        Dim cDB As New clsDB
        Dim msSQL As String
        Dim Dtbl一覧 As New DataTable()　　　　　　　　　　　　　　　   　　' POS_Mグルーピング の一覧を表示
        msSQL = "SELECT  "
        msSQL += "グループ番号,"
        msSQL += "case when レコードタイプ='H' then '飲食放題'  Else 'セレクト'　end as 種別,"
        msSQL += "グループ名 "
        msSQL += "FROM "
        msSQL += "POS_Mグルーピング "
        msSQL += "WHERE POSパターン = "
        msSQL += "'" + PosIdSave.ToString() + "'"
        msSQL += " order by グループ番号"
        mCommand = cDB.getsqlComand(msSQL)
        mSDA.SelectCommand = mCommand
        Call mSDA.Fill(Dtbl一覧) ''データセット作成
        'dgv一覧.DataSource = myTable
        'dgv一覧.Rows.Count.ToString()
        Call cDB.Close()
        dgv一覧.DataSource = Dtbl一覧
        '-----------------Grid幅の調整ーーーーーーーーーーー
        dgv一覧.Columns(0).Width = 100        '第0列の幅を　に
        dgv一覧.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter        '真ん中に表示
        dgv一覧.Columns(1).Width = 100       '第１列の幅を　に                            
        dgv一覧.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv一覧.Columns(2).Width = 100
        dgv一覧.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        '   dgv一覧.Columns(3).Width = 200

        Call cDB.Close()

    End Sub

    Private Sub btnキャンセル_Click(sender As Object, e As EventArgs) Handles btnキャンセル.Click
        btn読込.Enabled = False
        btn削除.Enabled = False
        btn更新.Enabled = False
        btnエクスポート.Enabled = False
        btn読込.Visible = False
        btn削除.Visible = False
        btn更新.Visible = False
        btnエクスポート.Visible = False
        txtグループ番号.Visible = False
        lblグループ番号.Visible = False
        ' dgv一覧.Columns.Clear()
        'dgv一覧.Refresh()
        dgv一覧.DataSource = Nothing
        'dgv一覧.Rows.Clear()     '何はともあれまずクリア
        txtグループ番号.Text = ""
        cmbPOSパターン.SelectedIndex = -1
    End Sub



    'Private Sub txtグループ番号_TextChanged(sender As Object, e As EventArgs) Handles txtグループ番号.TextChanged

    'End Sub
    '!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
    ''txtグループ番号_TextChanged,Frm104グループ登録_KeyDown,うまく反応しない
    'Private Sub txtグループ番号_TextChanged(sender As Object, e As EventArgs) Handles txtグループ番号.TextChanged
    '    '   0.2 グループ番号_TextChanged　
    '    Dim cDB As New clsDB
    '    Dim msSQL As String
    '    Dim myTable As New DataTable
    '    msSQL = ""
    '    msSQL += "SELECT * "
    '    msSQL += "FROM POS_Mグルーピング "
    '    'msSQL += "WHERE グループ番号 = "
    '    'msSQL += "'" + txtグループ番号.ToString + "'"
    '    '' msSQL += "ORDER BY グループ番号 "
    '    mCommand = cDB.getsqlComand(msSQL)
    '    mSDA.SelectCommand = mCommand
    '    Call mSDA.Fill(myTable) ''データセット作成
    '    dgv一覧.DataSource = myTable      ''  「dgv一覧」に表示

    '    Call cDB.Close()
    'End Sub

    'Private Sub Frm104グループ登録_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
    '    'Private Sub Frm104グループ登録_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
    '    If e.KeyCode = Keys.Enter Then
    '        Dim forward As Boolean = e.Modifiers <> Keys.Shift
    '        'Me.ProcessTabKey(forward);
    '        Me.SelectNextControl(Me.ActiveControl, forward, True, True, True)
    '        e.Handled = True

    '    End If
    'End Sub
End Class