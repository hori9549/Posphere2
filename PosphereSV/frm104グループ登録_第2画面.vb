'-------- Frm104グループ登録_第2画面  メンバー（商品メニューのこと）を選ばせて当グループを登録----------
'-------- Frm104グループ登録_第2画面 --------                         使用変数
'1.1 load  分別　入力されたグループ番号の種類で                               lblGrpNo ： 登録済みレコードの中のグループ番号の最大値+1　　    
'                           X.X    Insert モード　　か                nGrpNoSerch：「グループ番号」が存在するか？
'                           X.X+1  Update  モード 　に分ける
'   1.2 メンバーを選択させる
Imports System.Data.SqlClient

Public Class Frm104グループ登録_第2画面
    ' Private msSQL As String
    Private mCommand As SqlCommand
    Private mSDA As New SqlDataAdapter

    Dim 選択済表Count As Integer = 0       '設定メニューの行、列番号　COUNT　UP用

    Dim bInstUpdtSwtch As Boolean = True   'レコード追加or更新モード　（TRUE:Insert　FALSE:Update）

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lblグループ名No2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Txt第2画面_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Frm104グループ登録_第2画面_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ControlBox = Not Me.ControlBox
        '====================================================================-
        ' 設定メニュー情報に　32行　の空白の表を作る
        '====================================================================
        For i As Integer = 1 To 32
            Dgv選択済品目.Rows.Add()
            ' Dgv選択済品目(0, i - 1).Value = i.ToString

            Dgv選択済品目(1, i - 1).Value = ""
        Next
        'DataGridView1にユーザーが新しい行を追加できないようにする
        Dgv選択済品目.AllowUserToAddRows = False

        選択済表Count = 0      '選択済表の行、列番号　COUNT　UP用
        ' Dim DTBL選択済品目 As New DataTable
        'Dgv選択済品目.DataSource = DTBL選択済品目

        'DTBL選択済品目.Columns.Add("NO")
        'DTBL選択済品目.Columns.Add("品目CD")
        'DTBL選択済品目.Columns.Add("品目名")
        'DTBL選択済品目.Columns.Add("単価")

        '
        '  32行の表を作る
        '
        'Dim RowCount As Integer

        'Dim row明細 As DataRow

        'For RowCount = 1 To 32   '1~32  の表を作る

        '    row明細 = DTBL選択済品目.NewRow
        '    row明細("NO") = RowCount.ToString
        '    row明細("商品CD") = "0"
        '    DTBL選択済品目.Rows.Add(row明細)

        'Next

        'Dgv選択済品目.DataSource = DTBL選択済品目



        '!!!!!!!!!!!!!!!!!!!!!!!! 以下は　デバッグ用　！！！！！！！！！！！！！！！！！！！

        'MessageBox.Show("設定メニューの行No.は：" + Dgv選択済品目.CurrentCell.RowIndex.ToString)     '行番号の表示
        'MessageBox.Show("設定メニューの列No.は：" + Dgv選択済品目.CurrentCell.ColumnIndex.ToString)     '列番号の表示

        '-----------------Grid幅の調整ーーーーーーーーーーー
        Dgv選択済品目.Columns(0).Width = 45       '第0列の幅を　に
        Dgv選択済品目.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Dgv選択済品目.Columns(1).Width = 80     '第１列の幅を　に
        Dgv選択済品目.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Dgv選択済品目.Columns(2).Width = 250      '第2列の幅を　　に
        '   Dgv選択済品目.Columns(3).Width = 70
        '  Dgv選択済品目.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        Dgv選択済品目.RowHeadersVisible = False       '左のHeaderを隠す
        'btn削除No2.Enabled = False

        '=-----------------  画面作り終了  ----------------------------------


        '------------ 1. load  分別 
        '1. load  分別

        Dim cDB As New clsDB
        Dim msSQL As String
        btn削除No2.Enabled = True
        btn削除No2.Visible = True

        If lblGrpNo.Text.Length = 0 Then　　　　　　'グループ番号の入力が未入力の場合
            '登録済みレコードの中のグループ番号の最大値+10をセット
            Dim nGrpNoMax As New DataTable
            msSQL = "SELECT max(グループ番号)+10 As grpNoMax From POS_Mグルーピング"
            mCommand = cDB.getsqlComand(msSQL)
            mSDA.SelectCommand = mCommand
            Call mSDA.Fill(nGrpNoMax) ''データセット作成
            ' lblGrpNo.Text = nGrpNoMax.Rows(0).Item("grpNoMax") + 1.ToString
            lblGrpNo.Text = nGrpNoMax.Rows(0).Item("grpNoMax").ToString.PadLeft(5, "0")
            ' グループ名なしの新グループを登録してしまおう
            'Dim MyTbl As New DataTable
            'msSQL = " INSERT INTO POS_Mグルーピング(POSパターン,グループ番号,レコードタイプ) values ("
            'msSQL += "'" + POSパターンID.Text.ToString + "',"
            'msSQL += "'" + lblGrpNo.Text + "',"          'グループ番号
            'msSQL += "'N')"           'レコードタイプ 'グループ名

            'mCommand = cDB.getsqlComand(msSQL)
            'mSDA.SelectCommand = mCommand
            'Call mSDA.Fill(MyTbl) ''データセット作成
            bInstUpdtSwtch = True 'レコード追加or更新モード　（TRUE:Insert　FALSE:Update） bInstUpdtSwtch = True                '入力された「グループ番号」のレコードをInsertするモード
            Exit Sub        'メンバーはとばす

        Else   'グループ番号「欄」に整数が入っている場合

            '入力桁数不足を補填(※lblGrpNo.Textの数字入力チェックを第1画面＜読込＞ボタン処理内でチェックする必要あり)
            ' lblGrpNo.Text = Integer.Parse(lblGrpNo.Text).ToString("00000")
            ' lblGrpNo.Text = Integer.Parse(lblGrpNo.Text).ToString("00000")
            '登録済みレコードの中に、入力された「グループ番号」が存在するか？をチェック
            Dim nGrpNoSerch As New DataTable
            msSQL = "SELECT count(*) As grpNoCnt From POS_Mグルーピング Where グループ番号='" + lblGrpNo.Text + "'"
            mCommand = cDB.getsqlComand(msSQL)
            mSDA.SelectCommand = mCommand
            Call mSDA.Fill(nGrpNoSerch) ''データセット作成

            If nGrpNoSerch.Rows(0).Item("grpNoCnt") > 0 Then  '既存の番号                                   '**　♡ ♡ ♡ 使える１句

                '入力された「グループ番号」のレコードをUpdateするモード
                bInstUpdtSwtch = False   'レコード追加or更新モード　（TRUE:Insert　FALSE:Update）
                GoTo MemSelect           '1.2 メンバーの選択に進む
            Else
                bInstUpdtSwtch = True                '入力された「グループ番号」のレコードをInsertするモード
                Exit Sub　　　'MemSelect:  とばす
            End If

        End If
MemSelect:
        ' 1.2 メンバーを選択させる

        '- 1 ------------登録されているグループの DATA 読込-------------------
        'Dim cDB As New clsDB
        'Dim msSQL As String
        Dim myTable As New DataTable
        'Dim mSDA As New SqlDataAdapter
        'MessageBox.Show(" + lblGrpNo.Text +＝", lblGrpNo.Text)
        msSQL = ""
        msSQL += "select * "
        msSQL += "from POS_Mグルーピング "
        msSQL += "where  グループ番号="
        msSQL += "'" + lblGrpNo.Text + "'"     '######### ここがポイント ###########
        mCommand = cDB.getsqlComand(msSQL)
        mSDA.SelectCommand = mCommand

        Call mSDA.Fill(myTable) ''データセット作成

        DgvWork.DataSource = myTable

        Call cDB.Close()

        '--2 -------------読込んだ　TEST DATA の「メンバに（品目コード」が登録されているか　空白か？-------------------
        '-- 2．１　ない場合は　　右の表は空白のまま ------------
        '-- 2．2　あった場合は　品目CDをキーにして、品目名,取引単価を右の表に登録　-------------------
        '-- 2．3 「メンバ] の枠は　32　あるので空白””が出てくるまで（または32回）ループさせる。

        '--2 .4 グループ名のSAVE
        '-- 2．１
        Dim myTable2 As New DataTable

        TxtNo2.Text = DgvWork(3, 0).Value.ToString     '--2 .4 グループ名のSAVE

        For i As Integer = 4 To 35　　　　　　　'メンバ１　＝　col’３’
            Txt商品CD.Text = DgvWork(i, 0).Value.ToString
            'MessageBox.Show("レコード数は上記↑", MemNum.ToString)
            ' MessageBox.Show("DgvWork(i , 0).Value.ToString=", DgvWork(i, 0).Value.ToString)
            '！！　もし　メンバ Ⅹが、””ならもう Record は、ない！            '
            If Txt商品CD.Text = "" Then
                ' If (Not String.IsNullOrWhiteSpace(DgvWork(i + MemNum, 0).Value.ToString)) Then
                'MessageBox.Show("メンバー１の内容は＝", (DgvWork(i + MemNum, 0).Value.ToString))
                ' MessageBox.Show("メンバの検索は、終わりましたRec数は=", (i - 4).ToString)
                Exit For
            Else

                'MessageBox.Show("メンバー１の内容は＝", (DgvWork(i + MemNum, 0).Value.ToString))
                '-- 2．2
                ' /* メンバ1のCDで品目名を表示*/
                ' /* メンバ1のCDで単価を表示*/

                ' MessageBox.Show("Txt商品CD.Text =", Txt商品CD.Text)
                msSQL = "Select POS_MP品目.品目名"
                msSQL += ",FORMAT(POS_MP品目.取引単価, '#,##0')"
                msSQL += "　From POS_Mグルーピング, POS_MP品目 "
                msSQL += " Where  POS_Mグルーピング.グループ番号 = "

                msSQL += "'" + lblGrpNo.Text + "'"        '######### ここがポイント ###########
                msSQL += " and "

                msSQL += " POS_MP品目.品目CD="
                msSQL += "'" + Txt商品CD.Text + "'"
                msSQL += " "
                '        Select Case POS_MP品目.品目名,POS_MP品目.取引単価
                'From POS_Mグルーピング, POS_MP品目
                '  Where POS_Mグルーピング.グループ番号 = 2
                '   And
                '   POS_Mグルーピング.メンバ2 = POS_MP品目.品目CD
                mCommand = cDB.getsqlComand(msSQL)
                mSDA.SelectCommand = mCommand
                Call mSDA.Fill(myTable2)  ''データセット作成
                DGVwork2.DataSource = myTable2
                Call cDB.Close()



                'MessageBox.Show("DGVwork2(0, i-4).Value.ToString=", DGVwork2(0, i - 4).Value.ToString)
                Txt商品CD.Text = DgvWork(i, 0).Value.ToString             'メンバ１＝ ”col3”
                Txt品目名.Text = DGVwork2(0, i - 4).Value.ToString
                Txt単価.Text = DGVwork2(1, i - 4).Value.ToString

                '-- 2．2 ########### 右の表に Txt商品CD、Txt品目名、Txt単価 ###########

                ' Dgv選択済品目.Rows.Add()       '-----  1行追加  -------
                ' Dgv選択済品目.CurrentRow.Selected = True         ' 選択状態にする
                ' -------------------- 右の表に書き込み-----------------
                Dgv選択済品目(0, 選択済表Count).Value = (選択済表Count + 1).ToString         '行　NO

                Dgv選択済品目(1, 選択済表Count).Value = Txt商品CD.Text.ToString
                Dgv選択済品目(2, 選択済表Count).Value = Txt品目名.Text.ToString
                '     Dgv選択済品目(3, 選択済表Count).Value = Txt単価.Text.ToString


                選択済表Count = 選択済表Count + 1       'Count UP

            End If

        Next

    End Sub

    Private Sub Cmb種別No2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb種別No2.SelectedIndexChanged

        If TxtNo2.Text = "" Then

            '     If Txt新規か.Text = "NEW" Then
            MessageBox.Show("グループ名を入れてください。")
        End If


        '#######種別の選択#################

        Dim cDB As New clsDB
        Dim msSQL As String
        Dim myTable As New DataTable
        Dim mSDA As New SqlDataAdapter
        msSQL = ""
        msSQL += "Select 品目CD as 番号,"
        msSQL += "品目名 as 名称,"
        msSQL += "FORMAT(取引単価,'#,##0')　as 単価 "
        msSQL += "from POS_MP品目 "
        msSQL += "where  品目CD　!= '' and "
        msSQL += "POSパターン= "
        msSQL += "'" + lblPosPtn.Text + "'"

        mCommand = cDB.getsqlComand(msSQL)
        mSDA.SelectCommand = mCommand

        Call mSDA.Fill(myTable) ''データセット作成

        dgv選択品目表.DataSource = myTable
        '---------------Grid幅の調整ーーーーーーーーーーー
        dgv選択品目表.Columns(0).Width = 70      '第0列の幅を　に
        dgv選択品目表.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv選択品目表.Columns(1).Width = 130     '第１列の幅を　に
        dgv選択品目表.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgv選択品目表.Columns(2).Width = 80      '第2列の幅を　　に
        dgv選択品目表.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        Call cDB.Close()


    End Sub

    Private Sub Label2_Click_1(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Dgv選択メンバー一覧_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv選択品目表.CellClick

        ' ??????? Debug  TEMP  MessageBox.Show(" ")
        'MessageBox.Show(" e.RowIndexは：", e.RowIndex.ToString)
        'MessageBox.Show(" e.colindexは：", e.ColumnIndex.ToString)

        If e.RowIndex < 0 Then Exit Sub     ' ←選択した行がヘッダーの場合は処理を行わない
        Txt商品CD.Text = dgv選択品目表.Rows(e.RowIndex).Cells(0).Value.ToString
        Txt品目名.Text = dgv選択品目表.Rows(e.RowIndex).Cells(1).Value.ToString
        Txt単価.Text = dgv選択品目表.Rows(e.RowIndex).Cells(2).Value.ToString


    End Sub

    Private Sub Btn選択ボタン_Click(sender As Object, e As EventArgs) Handles Btn選択ボタン.Click
        '-----------グループ名がないときは先に進ませない
        If TxtNo2.Text = "" Then
            MessageBox.Show("グループ名をいれて！！")
            '     Exit Sub
        End If

        '---------------------------------------------------------------------------
        '     選択したのか？
        '---------------------------------------------------------------------------
        If Txt商品CD.Text.ToString = "" Then
            MessageBox.Show("選んでください", "確認", MessageBoxButtons.OK, MessageBoxIcon.Question)
            GoTo End処理
        End If
        '---------------------------------------------------------------------------
        '      ３２行　以内か？
        '---------------------------------------------------------------------------
        If 選択済表Count >= 32 Then
            MessageBox.Show("登録できるのは３２行までです。")
            Exit Sub
        End If
        '---------------------------------------------------------------------------
        '     重複　Ｃｏｄｅ　は、ないか？
        '---------------------------------------------------------------------------
        'MessageBox.Show("選択済表Count :", 選択済表Count.ToString)
        If 選択済表Count > 0 Then

            For count = 0 To 選択済表Count - 1
                'MessageBox.Show("count=:", count.ToString)
                'MessageBox.Show("Txt商品CD.Text : ", Txt商品CD.Text.ToString)
                'MessageBox.Show("Dgv選択済品目(1, count) : ", Dgv選択済品目(1, count).Value.ToString)

                If Txt商品CD.Text.ToString = Dgv選択済品目(1, count).Value.ToString Then

                    MessageBox.Show("重複データーがあります")
                    Exit Sub
                End If
            Next

        End If

        '########### 右の表に Txt商品CD、Txt品目名、Txt単価 ###########

        'Dgv選択済品目.Rows.Add()       '-----  1行追加  -------
        ' Dgv選択済品目.CurrentRow.Selected = True         ' 選択状態にする
        ' -------------------- 右の表に書き込み-----------------
        Dgv選択済品目(0, 選択済表Count).Value = (選択済表Count + 1).ToString         '行　NO

        Dgv選択済品目(1, 選択済表Count).Value = Txt商品CD.Text.ToString
        Dgv選択済品目(2, 選択済表Count).Value = Txt品目名.Text.ToString
        '  Dgv選択済品目(3, 選択済表Count).Value = Txt単価.Text.ToString

        選択済表Count = 選択済表Count + 1       'Count UP

End処理:
    End Sub


    Private Sub BtnキャンセルNo2_Click(sender As Object, e As EventArgs) Handles btnキャンセルNo2.Click
        Dim result As DialogResult = MessageBox.Show("編集された内容を保存せずにｷｬﾝｾﾙします。　よろしいですか？",
                                             "グループ登録",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Asterisk)
        '何が選択されたか調べる 
        If result = DialogResult.Yes Then
            '「はい」が選択された時 
            Me.Close()
        ElseIf result = DialogResult.No Then
            '「いいえ」が選択された時 
            Exit Sub

        End If

    End Sub

    Private Sub Btn取消_Click(sender As Object, e As EventArgs) Handles Btn取消.Click

        If 選択済表Count <= 0 Then
            MessageBox.Show("削除する行がありません！", "確認", MessageBoxButtons.OK, MessageBoxIcon.Question)
            Exit Sub
        End If

        'If CInt(e.ToString) > 選択済表Count Then Exit Sub    '枠の外
        ' MessageBox.Show("枠の外?", Dgv選択済品目.SelectedRows.ToString)
        '  -------  取消の確認　メッセージボックスを表示する --------
        Dim result As DialogResult =
            MessageBox.Show("消去 OK? or cancel", "確認",
                         MessageBoxButtons.OKCancel,
                         MessageBoxIcon.Question)
        '何が選択されたか調べる 
        If result = DialogResult.Cancel Then Exit Sub

        '「OK」が選択された時 
        For Each row As DataGridViewRow In Dgv選択済品目.SelectedRows
            ' オブジェクト指定で行を削除する
            Dgv選択済品目.Rows.Remove(row)
            選択済表Count = 選択済表Count - 1       'Count Down = Current行位置
            Dgv選択済品目.Rows.Add()

            Dgv選択済品目(1, 31).Value = ""      '追加行に　””最終行
        Next

        'Dgv選択済品目.Rows.add()

        '================== Re Numbering===============

        For C As Integer = 0 To 選択済表Count - 1
            'MessageBox.Show("Dgv選択済品目(0, RowCount).Value = :", Dgv選択済品目(0, RowCount).Value)
            'MessageBox.Show("(RowCount + 1).ToString= :", (RowCount + 1).ToString)
            'Dgv選択済品目(0, RowCount).Value = (RowCount + 1).ToString
            Dgv選択済品目(0, C).Value = C + 1
        Next

    End Sub

    Private Sub Dgv選択済品目_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv選択済品目.CellContentClick
        'e.RowIndex> 選択済表Count
    End Sub

    Private Sub Btn更新No2_Click(sender As Object, e As EventArgs) Handles btn更新No2.Click

        Dim cDB As New clsDB
        Dim msSQL As String
        Dim myTable As New DataTable
        Dim mSDA As New SqlDataAdapter

        If TxtNo2.Text = "" Then
            MessageBox.Show("グループ名入れて")
            Exit Sub
        End If

        If bInstUpdtSwtch = True Then
            'Insertモード
            Try
                'トランザクション開始
                Call cDB.BeginTransaction()
                '更新

                msSQL = "INSERT INTO POS_Mグルーピング "
                'msSQL += "POSパターン,グループ番号,レコードタイプ,グループ名,"
                'msSQL += "メンバ1,メンバ2,メンバ3) "

                msSQL += "VALUES("
                msSQL += " '" + lblPosPtn.Text + "',"    'POSパターン
                msSQL += "'" + lblGrpNo.Text + "',"        'グループ番号
                msSQL += "'H',"                                 'レコードタイプ
                msSQL += "'" + TxtNo2.Text + "'"        'グループ名

                msSQL += ",'" + Dgv選択済品目(1, 0).Value.ToString + "'"   'メンバ1
                msSQL += ",'" + Dgv選択済品目(1, 1).Value.ToString + "'" 'メンバ2
                msSQL += ",'" + Dgv選択済品目(1, 2).Value.ToString + "'"  'メンバ3
                msSQL += ",'" + Dgv選択済品目(1, 3).Value.ToString + "'"   'メンバ4
                msSQL += ",'" + Dgv選択済品目(1, 4).Value.ToString + "'"   'メンバ5
                msSQL += ",'" + Dgv選択済品目(1, 5).Value.ToString + "'"   'メンバ6
                msSQL += ",'" + Dgv選択済品目(1, 6).Value.ToString + "'"   'メンバ7
                msSQL += ",'" + Dgv選択済品目(1, 7).Value.ToString + "'"   'メンバ8
                msSQL += ",'" + Dgv選択済品目(1, 8).Value.ToString + "'"   'メンバ9
                msSQL += ",'" + Dgv選択済品目(1, 9).Value.ToString + "'"   'メンバ10
                msSQL += ",'" + Dgv選択済品目(1, 10).Value.ToString + "'"   'メンバ11
                msSQL += ",'" + Dgv選択済品目(1, 11).Value.ToString + "'"   'メンバ12
                msSQL += ",'" + Dgv選択済品目(1, 12).Value.ToString + "'"   'メンバ13
                msSQL += ",'" + Dgv選択済品目(1, 13).Value.ToString + "'"   'メンバ14
                msSQL += ",'" + Dgv選択済品目(1, 14).Value.ToString + "'"   'メンバ15
                msSQL += ",'" + Dgv選択済品目(1, 15).Value.ToString + "'"   'メンバ16
                msSQL += ",'" + Dgv選択済品目(1, 16).Value.ToString + "'"   'メンバ17
                msSQL += ",'" + Dgv選択済品目(1, 17).Value.ToString + "'"   'メンバ18
                msSQL += ",'" + Dgv選択済品目(1, 18).Value.ToString + "'"   'メンバ19
                msSQL += ",'" + Dgv選択済品目(1, 19).Value.ToString + "'"   'メンバ20
                msSQL += ",'" + Dgv選択済品目(1, 20).Value.ToString + "'"   'メンバ21
                msSQL += ",'" + Dgv選択済品目(1, 21).Value.ToString + "'"   'メンバ22
                msSQL += ",'" + Dgv選択済品目(1, 22).Value.ToString + "'"   'メンバ23
                msSQL += ",'" + Dgv選択済品目(1, 23).Value.ToString + "'"   'メンバ24
                msSQL += ",'" + Dgv選択済品目(1, 24).Value.ToString + "'"   'メンバ25
                msSQL += ",'" + Dgv選択済品目(1, 25).Value.ToString + "'"   'メンバ26
                msSQL += ",'" + Dgv選択済品目(1, 26).Value.ToString + "'"   'メンバ27
                msSQL += ",'" + Dgv選択済品目(1, 27).Value.ToString + "'"   'メンバ28
                msSQL += ",'" + Dgv選択済品目(1, 28).Value.ToString + "'"   'メンバ29
                msSQL += ",'" + Dgv選択済品目(1, 29).Value.ToString + "'"   'メンバ30
                msSQL += ",'" + Dgv選択済品目(1, 30).Value.ToString + "'"   'メンバ31
                msSQL += ",'" + Dgv選択済品目(1, 31).Value.ToString + "'"   'メンバ32
                msSQL += ")"
                mCommand = cDB.getsqlComand(msSQL)
                Call mCommand.ExecuteNonQuery()
                'コミット
                Call cDB.Commit()
                MessageBox.Show("追加登録が正常に終了しました！", "'" + lblGrpNo.Text + "'")
            Catch ex As Exception
                'ロールバック
                Call cDB.Rollback()

                MessageBox.Show("追加登録に失敗しました！",
                                    "グループ登録IN")
            End Try

        Else
            'Updateモード
            Try
                'トランザクション開始
                Call cDB.BeginTransaction()
                '更新
                msSQL = "UPDATE POS_Mグルーピング "
                msSQL += "SET "
                msSQL += "POSパターン='" + lblPosPtn.Text + "'"
                msSQL += ",グループ番号='" + lblGrpNo.Text + "'"
                msSQL += ",レコードタイプ='H'"
                msSQL += ",グループ名='" + TxtNo2.Text + "'"
                msSQL += ",メンバ1='" + Dgv選択済品目(1, 0).Value.ToString + "'"
                msSQL += ",メンバ2='" + Dgv選択済品目(1, 1).Value.ToString + "'"
                msSQL += ",メンバ3='" + Dgv選択済品目(1, 2).Value.ToString + "'"
                msSQL += ",メンバ4='" + Dgv選択済品目(1, 3).Value.ToString + "'"
                msSQL += ",メンバ5='" + Dgv選択済品目(1, 4).Value.ToString + "'"
                msSQL += ",メンバ6='" + Dgv選択済品目(1, 5).Value.ToString + "'"
                msSQL += ",メンバ7='" + Dgv選択済品目(1, 6).Value.ToString + "'"
                msSQL += ",メンバ8='" + Dgv選択済品目(1, 7).Value.ToString + "'"
                msSQL += ",メンバ9='" + Dgv選択済品目(1, 8).Value.ToString + "'"
                msSQL += ",メンバ10='" + Dgv選択済品目(1, 9).Value.ToString + "'"
                msSQL += ",メンバ11='" + Dgv選択済品目(1, 10).Value.ToString + "'"
                msSQL += ",メンバ12='" + Dgv選択済品目(1, 11).Value.ToString + "'"
                msSQL += ",メンバ13='" + Dgv選択済品目(1, 12).Value.ToString + "'"
                msSQL += ",メンバ14='" + Dgv選択済品目(1, 13).Value.ToString + "'"
                msSQL += ",メンバ15='" + Dgv選択済品目(1, 14).Value.ToString + "'"
                msSQL += ",メンバ16='" + Dgv選択済品目(1, 15).Value.ToString + "'"
                msSQL += ",メンバ17='" + Dgv選択済品目(1, 16).Value.ToString + "'"
                msSQL += ",メンバ18='" + Dgv選択済品目(1, 17).Value.ToString + "'"
                msSQL += ",メンバ19='" + Dgv選択済品目(1, 18).Value.ToString + "'"
                msSQL += ",メンバ20='" + Dgv選択済品目(1, 19).Value.ToString + "'"
                msSQL += ",メンバ21 ='" + Dgv選択済品目(1, 20).Value.ToString + "'"
                msSQL += ",メンバ22='" + Dgv選択済品目(1, 21).Value.ToString + "'"
                msSQL += ",メンバ23='" + Dgv選択済品目(1, 22).Value.ToString + "'"
                msSQL += ",メンバ24='" + Dgv選択済品目(1, 23).Value.ToString + "'"
                msSQL += ",メンバ25='" + Dgv選択済品目(1, 24).Value.ToString + "'"
                msSQL += ",メンバ26='" + Dgv選択済品目(1, 25).Value.ToString + "'"
                msSQL += ",メンバ27='" + Dgv選択済品目(1, 26).Value.ToString + "'"
                msSQL += ",メンバ28='" + Dgv選択済品目(1, 27).Value.ToString + "'"
                msSQL += ",メンバ29='" + Dgv選択済品目(1, 28).Value.ToString + "'"
                msSQL += ",メンバ30='" + Dgv選択済品目(1, 29).Value.ToString + "'"
                msSQL += ",メンバ31='" + Dgv選択済品目(1, 30).Value.ToString + "'"
                msSQL += ",メンバ32='" + Dgv選択済品目(1, 31).Value.ToString + "'"
                msSQL += " WHERE グループ番号 = '" + lblGrpNo.Text + "' "

                mCommand = cDB.getsqlComand(msSQL)
                Call mCommand.ExecuteNonQuery()
                'コミット
                Call cDB.Commit()
                MessageBox.Show("正常に更新しました！", "'" + lblGrpNo.Text + "'")

            Catch ex As Exception
                'ロールバック
                Call cDB.Rollback()
                MessageBox.Show("更新に失敗しました！",
                                    "グループ登録")
            End Try
        End If
        Me.Close()


        'myTable.Clear()     '何はともあれまずクリア
        'msSQL = "SELECT * "     'データベースから取得したいデータ群をSQLで検索
        'msSQL += "FROM "
        'msSQL += "POS_Mグルーピング "
        'msSQL += "where グループ番号="
        'msSQL += "'" + lblGrpNo.Text + "'"         'グループ番号

        'mCommand = cDB.getsqlComand(msSQL)
        'mSDA.SelectCommand = mCommand
        'Call mSDA.Fill(myTable) ''データセット作成

        'DgvWork.DataSource = myTable

        'If DgvWork.Rows.Count <= 0 Then
        '    msSQL = "insert into "
        '    msSQL += "POS_Mグルーピング values('1',"
        '    msSQL += "'" + lblGrpNo.Text + "','H',"
        '    msSQL += "'" + TxtNo2.Text + "'"          'グループ名

        '    mCommand = cDB.getsqlComand(msSQL)

        '    mSDA.SelectCommand = mCommand

        '    Call mSDA.Fill(myTable) ''データセット作成

        '    DgvWork.DataSource = myTable

        'End If





        'msSQL = "UPDATE POS_Mグルーピング "
        '    msSQL += "Set "
        '    msSQL += "グループ名='" + TxtNo2.Text + "'"

        '    Dim nFldNo As Integer
        '    For nFldNo = 1 To Dgv選択済品目.Rows.Count - 1
        '        msSQL += "メンバ" + nFldNo.ToString + " = '" + Dgv選択済品目(1, nFldNo - 1).Value.ToString + "',"
        '    Next
        '    msSQL += "メンバ" + nFldNo.ToString + " = '" + Dgv選択済品目(1, nFldNo - 1).Value.ToString + "' "
        '    msSQL += " where グループ番号='" + lblGrpNo.Text + "' "

        '    mCommand = cDB.getsqlComand(msSQL)

        '    mSDA.SelectCommand = mCommand

        '    Call mSDA.Fill(myTable) ''データセット作成

        '    DgvWork.DataSource = myTable

        ''--------------結果表示」-----------------------
        'msSQL = "SELECT *  "
        '    msSQL += "FROM "
        '    msSQL += "POS_Mグルーピング"

        '    mCommand = cDB.getsqlComand(msSQL)
        '    mSDA.SelectCommand = mCommand

        '    Call mSDA.Fill(myTable) ''データセット作成

        '    DgvWork.DataSource = myTable
        '    ' MessageBox.Show("グループの更新完了")
        '    Call cDB.Close()

        '    Dim sfrm As New Frm104グループ登録


        '    sfrm.txtグループ番号.Text = ""
        '    Txt新規か.Text = "NO"

        '    MessageBox.Show("グループの更新完了")
        '    Me.Close()
        '    Call sfrm.ShowDialog()

        ''3/14 WORK
        ''===================　グループ一覧表　読込TEST　------------------
        'Dim cDB As New clsDB
        'Dim msSQL As String
        'Dim myTable As New DataTable
        'Dim mSDA As New SqlDataAdapter

        ''データベースから取得したいデータ群をSQLで検索
        ''msSQL = "SELECT グループ番号,レコードタイプ,グループ名,メンバ1,メンバ2  "
        ''msSQL = " SELECT *"
        ''msSQL += "FROM "
        ''msSQL += "POS_Mグルーピング "
        ''msSQL += "where グループ番号=00002"

        '' /* メンバ1のCDで品目名を表示*/
        '' /* メンバ1のCDで単価を表示*/

        'msSQL = "Select POS_MP品目.品目名"
        'msSQL += ",POS_MP品目.取引単価"
        'msSQL += "　From POS_Mグルーピング, POS_MP品目 "

        'msSQL += " Where  POS_Mグルーピング.グループ番号 = 0007 And"
        'msSQL += " POS_Mグルーピング.メンバ1 = POS_MP品目.品目CD"
        'msSQL += ""
        ''        Select Case POS_MP品目.品目名,POS_MP品目.取引単価
        ''From POS_Mグルーピング, POS_MP品目
        ''  Where POS_Mグルーピング.グループ番号 = 2
        ''   And
        ''   POS_Mグルーピング.メンバ2 = POS_MP品目.品目CD
        'mCommand = cDB.getsqlComand(msSQL)
        'mSDA.SelectCommand = mCommand

        'Call mSDA.Fill(myTable)  ''データセット作成

        'DGVwork2.DataSource = myTable

        'Call cDB.Close()

        ''MessageBox.Show("[DgvWork(0, 0).Value.ToString]=", DGVwork2(0, 0).Value.ToString)
        'Txt商品CD.Text = DgvWork(4, 0).Value.ToString
        'Txt品目名.Text = DGVwork2(0, 0).Value.ToString
        'Txt単価.Text = DGVwork2(1, 0).Value.ToString

    End Sub

    ' Private Sub BtnTemp_Click(sender As Object, e As EventArgs) Handles BtnTemp.Click
    'Dim cDB As New clsDB
    'Dim msSQL As String
    'Dim myTable As New DataTable
    'Dim mSDA As New SqlDataAdapter

    'msSQL = "UPDATE POS_Mグルーピング "
    'msSQL += "Set "
    'msSQL += "メンバ1 = "
    'msSQL += "'" + Dgv選択済品目(1, 0).Value.ToString + "'"

    'msSQL += " where グループ番号="
    ''MessageBox.Show("+lblGrpNo.Text + ='", lblGrpNo.Text)
    'msSQL += "'" + lblGrpNo.Text + "'"
    ''msSQL +=+lblGrpNo.Text+"'"           'lblGrpNo = グループ番号
    ''  msSQL = "INSERT INTO POS_Mグルーピング(POSパターン)(グループ番号)(レコードタイプ)(グループ名)
    ''values ('3','30005','G','あいうえお')"
    ''msSQL = "INSERT INTO POS_M分類(分類CD,分類名) values ('010050','あいうえお')"
    'mCommand = cDB.getsqlComand(msSQL)
    'mSDA.SelectCommand = mCommand

    'Call mSDA.Fill(myTable) ''データセット作成

    'DgvWork.DataSource = myTable
    'Call cDB.Close()

    ''--------------結果表示」-----------------------
    'msSQL = "SELECT *  "
    'msSQL += "FROM "
    'msSQL += "POS_Mグルーピング"

    'mCommand = cDB.getsqlComand(msSQL)
    'mSDA.SelectCommand = mCommand

    'Call mSDA.Fill(myTable) ''データセット作成

    'DgvWork.DataSource = myTable

    'Call cDB.Close()
    ' End Sub

    Private Sub btn削除No2_Click(sender As Object, e As EventArgs) Handles btn削除No2.Click

        Dim result As DialogResult = MessageBox.Show("この登録内容を削除します。　よろしいですか？",
                                                     "グループ登録",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Asterisk)
        '何が選択されたか調べる 
        If result = DialogResult.Yes Then
            '「はい」が選択された時 

            '削除OK?が出たとき
            Dim cDB As New clsDB
            Dim msSQL As String
            Dim myTable As New DataTable
            Dim mSDA As New SqlDataAdapter

            Try
                'トランザクション開始
                Call cDB.BeginTransaction()
                '削除
                msSQL = "DELETE from POS_Mグルーピング"
                msSQL += " where "
                msSQL += " グループ番号 ="
                msSQL += "'" + lblGrpNo.Text + "'"

                mCommand = cDB.getsqlComand(msSQL)

                Call mCommand.ExecuteNonQuery()
                'コミット
                Call cDB.Commit()
                MessageBox.Show(" 削除しました", "グループ登録")

            Catch ex As Exception
                'ロールバック
                Call cDB.Rollback()

                MessageBox.Show("削除に失敗しました！", "グループ登録IN")
            End Try
            Me.Close()
        ElseIf result = DialogResult.No Then
            '「いいえ」が選択された時 
            Exit Sub

        End If

        '  Me.Close()

    End Sub




    '    Dim cDB As New clsDB
    '    Dim msSQL As String
    '    Dim myTable As New DataTable
    '    Dim mSDA As New SqlDataAdapter
    '    msSQL = "DELETE from POS_Mグルーピング"
    '    msSQL += " where "
    '    msSQL += " グループ番号 ="
    '    msSQL += "'" + lblGrpNo.Text + "'"

    '    mCommand = cDB.getsqlComand(msSQL)
    '    mSDA.SelectCommand = mCommand

    '    Call mSDA.Fill(myTable) ''データセット作成

    '    DgvWork.DataSource = myTable

    '    MessageBox.Show("POS_Mグルーピング 1レコードを削除しました")

    '    Call cDB.Close()
    '    lblGrpNo.Text = ""
    '    lblグループ番号No2.Text = ""
    '    POSパターンID.Text = ""
    '    '--------------結果表示」-----------------------
    '    msSQL = "SELECT *  "
    '    msSQL += "FROM "
    '    msSQL += "POS_Mグルーピング"

    '    mCommand = cDB.getsqlComand(msSQL)
    '    mSDA.SelectCommand = mCommand

    '    Call mSDA.Fill(myTable) ''データセット作成

    '    DgvWork.DataSource = myTable

    '    Call cDB.Close()
    '    Me.Close()
    'End Sub



    '======== Very Interest Module =============
    '------------==================================
    ''保存用のファイルを開く
    'Using writer As New System.IO.StreamWriter("C:\work\test2.csv", False, System.Text.Encoding.GetEncoding("shift_jis"))
    '    Dim rowCount As Integer = dgvデータベース参照.Rows.Count

    '    ' ユーザによる行追加が許可されている場合は、最後の新規入力用の
    '    ' 1行分を差し引く
    '    'Dim rowCount As Integer = dgvデータベース参照.Rows.Count
    '    'If (dgvデータベース参照.AllowUserToAddRows = True) Then
    '    '    rowCount = rowCount - 1
    '    'End If

    '    ' 行
    '    For i As Integer = 0 To rowCount - 1
    '        ' リストの初期化
    '        Dim strList As New List(Of String)

    '        ' 列
    '        For j As Integer = 0 To dgvデータベース参照.Columns.Count - 1
    '            strList.Add(dgvデータベース参照(j, i).Value.ToString())
    '        Next
    '        Dim strArray As String() = strList.ToArray() ' 配列へ変換

    '        ' CSV 形式に変換
    '        Dim strCsvData As String = String.Join(",", strArray)

    '        writer.WriteLine(strCsvData)
    '    Next
    'End Using

End Class