Imports System.Data.SqlClient
Public Class Frm111ページコピー
    ''データベース接続用-------------------------------
    Private msSQL As String
    Private mCommand As SqlCommand
    Private mSDA As New SqlDataAdapter
    Dim sakiPosPTN As String = ""
    Dim sakiPosName As String = ""
    Private Sub Frm111ページコピー_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ControlBox = Not Me.ControlBox

        ' LblPosP.Enabled = False
        Btn実行.Enabled = False
        ProgressBar1.Visible = False   'プログレスバーを見せる
        lblPrgBar.Visible = False

        Call ItemSetToCMB("POS_MPOSパターン", "POSパターン", "パターン名称", CmbPos)

    End Sub
    Private Sub Btn実行_Click(sender As Object, e As EventArgs) Handles Btn実行.Click

        If CmbPos.Text.Length <= 0 Then
            MsgBox("POSパターンを選択してください")
            Exit Sub
        End If
        Dim msgA As String = txt元CmbPosPtn.Text & " : " & txt元CmbPosName.Text
        Dim msgB As String = sakiPosPTN.ToString & " : " & sakiPosName.ToString

        Dim result As DialogResult =
        MessageBox.Show(msgA & "の全ページを" & vbCrLf & msgB.ToString +
                        " にコピーします," & vbCrLf & "コピー先の全ページの内容は更新されて元には戻せません、実行しますか？",
                          "ページコピー", MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Warning)
        '何が選択されたか調べる 
        If result = DialogResult.Yes Then
            '「はい」が選択された時 


            'コントロールを初期化する
            ProgressBar1.Visible = True   'プログレスバーを見せる
            lblPrgBar.Visible = True

            ProgressBar1.Minimum = 0
            ProgressBar1.Maximum = 3
            ProgressBar1.Value = 0
            lblPrgBar.Text = "3"
            'Label1を再描画する
            lblPrgBar.Update()

            '時間のかかる処理を開始する
            Dim i As Integer
            For i = 1 To 3
                '1秒間待機する（時間のかかる処理があるものとする）
                System.Threading.Thread.Sleep(1000)

                'ProgressBar1の値を変更する
                ProgressBar1.Value = i
                'Label1のテキストを変更する
                lblPrgBar.Text = "もうしばらくお待ちください"

                'Label1を再描画する
                lblPrgBar.Update()
                '（フォーム全体を再描画するには、次のようにする）
                'Me.Update()
            Next

            '元の M頁読込
            Dim dtblM頁 As New DataTable
            Dim cDB As New clsDB

            msSQL = " "
            msSQL += "SELECT * From POS_M頁 "
            msSQL += "where POS区分=1 And POSパターン="
            msSQL += "'" + txt元CmbPosPtn.Text + "'"

            ''msSQL += " except select JANCD from POS_M品目ボタン設定"
            mCommand = cDB.getsqlComand(msSQL)
            mSDA.SelectCommand = mCommand
            Call mSDA.Fill(dtblM頁)

            'copy元のPOS_M頁のデーターは存在する？
            If dtblM頁.Rows.Count <= 0 Then
                MsgBox("copy元にデータがありません")
                CmbPos.Select()
                Exit Sub
            End If

            '先の M頁UPDATE
            Try
                'トランザクション開始
                Call cDB.BeginTransaction()
                '更新
                msSQL = " "
                msSQL = " update POS_M頁 Set "
                msSQL += "表示名1= '" + dtblM頁.Rows(0).Item("表示名1") + "',"
                msSQL += "表示名2= '" + dtblM頁.Rows(0).Item("表示名2") + "',"
                msSQL += "表示名3= '" + dtblM頁.Rows(0).Item("表示名3") + "',"
                msSQL += "表示名4= '" + dtblM頁.Rows(0).Item("表示名4") + "',"
                msSQL += "表示名5= '" + dtblM頁.Rows(0).Item("表示名5") + "',"
                msSQL += "表示名6= '" + dtblM頁.Rows(0).Item("表示名6") + "',"
                msSQL += "表示名7= '" + dtblM頁.Rows(0).Item("表示名7") + "',"
                msSQL += "表示名8= '" + dtblM頁.Rows(0).Item("表示名8") + "',"
                msSQL += "表示名9= '" + dtblM頁.Rows(0).Item("表示名9") + "',"
                msSQL += "表示名10= '" + dtblM頁.Rows(0).Item("表示名10") + "',"
                msSQL += "表示名11= '" + dtblM頁.Rows(0).Item("表示名11") + "',"
                msSQL += "表示名12= '" + dtblM頁.Rows(0).Item("表示名12") + "',"
                msSQL += "表示名13= '" + dtblM頁.Rows(0).Item("表示名13") + "',"
                msSQL += "表示名14= '" + dtblM頁.Rows(0).Item("表示名14") + "',"
                msSQL += "表示名15= '" + dtblM頁.Rows(0).Item("表示名15") + "',"
                msSQL += "表示名16= '" + dtblM頁.Rows(0).Item("表示名16") + "',"
                msSQL += "表示名17= '" + dtblM頁.Rows(0).Item("表示名17") + "',"
                msSQL += "表示名18= '" + dtblM頁.Rows(0).Item("表示名18") + "',"
                msSQL += "表示名19= '" + dtblM頁.Rows(0).Item("表示名19") + "',"
                msSQL += "表示名20= '" + dtblM頁.Rows(0).Item("表示名20") + "',"
                msSQL += "表示名21= '" + dtblM頁.Rows(0).Item("表示名21") + "',"
                msSQL += "表示名22= '" + dtblM頁.Rows(0).Item("表示名22") + "',"
                msSQL += "表示名23= '" + dtblM頁.Rows(0).Item("表示名23") + "',"
                msSQL += "表示名24= '" + dtblM頁.Rows(0).Item("表示名24") + "',"
                msSQL += "表示名25= '" + dtblM頁.Rows(0).Item("表示名25") + "',"
                msSQL += "表示名26= '" + dtblM頁.Rows(0).Item("表示名26") + "',"
                msSQL += "表示名27= '" + dtblM頁.Rows(0).Item("表示名27") + "',"
                msSQL += "表示名28= '" + dtblM頁.Rows(0).Item("表示名28") + "',"
                msSQL += "表示名29= '" + dtblM頁.Rows(0).Item("表示名29") + "',"
                msSQL += "表示名30= '" + dtblM頁.Rows(0).Item("表示名30") + "',"
                msSQL += "表示名31= '" + dtblM頁.Rows(0).Item("表示名31") + "',"
                msSQL += "表示名32= '" + dtblM頁.Rows(0).Item("表示名32") + "',"
                msSQL += "表示名33= '" + dtblM頁.Rows(0).Item("表示名33") + "',"
                msSQL += "表示名34= '" + dtblM頁.Rows(0).Item("表示名34") + "',"
                msSQL += "表示名35= '" + dtblM頁.Rows(0).Item("表示名35") + "',"
                msSQL += "表示名36= '" + dtblM頁.Rows(0).Item("表示名36") + "',"
                msSQL += "表示名37= '" + dtblM頁.Rows(0).Item("表示名37") + "',"
                msSQL += "表示名38= '" + dtblM頁.Rows(0).Item("表示名38") + "',"
                msSQL += "表示名39= '" + dtblM頁.Rows(0).Item("表示名39") + "',"
                msSQL += "表示名40= '" + dtblM頁.Rows(0).Item("表示名40") + "'"

                msSQL += " where POSパターン='" + sakiPosPTN + "'"
                msSQL += " and POS区分=1"

                mCommand = cDB.getsqlComand(msSQL)
                Call mCommand.ExecuteNonQuery()
                'コミット
                Call cDB.Commit()
                ' MessageBox.Show("設定の変更に成功しました！")
            Catch ex As Exception
                'ロールバック
                Call cDB.Rollback()
                MessageBox.Show("ページのコピーに失敗しました！",
                                "ページコピー")
            End Try

            ' POS_M品目ボタン設定の読込変更
            '1. コピー先のPOS_M品目ボタン設定の　Data削除
            Try
                'トランザクション開始
                Call cDB.BeginTransaction()
                msSQL = " "
                msSQL += " Delete　from  POS_M品目ボタン設定 "
                msSQL += "where POSパターン= "
                msSQL += "'" + sakiPosPTN + "'"
                msSQL += " and POS区分=1"

                mCommand = cDB.getsqlComand(msSQL)
                Call mCommand.ExecuteNonQuery()
                'コミット
                Call cDB.Commit()
                '  MessageBox.Show(" sakinoレコードを削除しました", "'" + sakiPosPTN + "'")
            Catch ex As Exception
                'ロールバック
                Call cDB.Rollback()
                MessageBox.Show("ページのコピーに失敗しました")
            End Try
            ' 2. コピー元の対象Data取得
            Dim DtblM品目Btn As New DataTable

            msSQL = " "
            msSQL += "SELECT * From POS_M品目ボタン設定 "
            msSQL += "where POSパターン="
            msSQL += "'" + txt元CmbPosPtn.Text + "'"
            msSQL += " and  POS区分= 1"

            mCommand = cDB.getsqlComand(msSQL)
            mSDA.SelectCommand = mCommand
            Call mSDA.Fill(DtblM品目Btn)
            '    DgvMボタン.DataSource = DtblM品目Btn

            ' 3. コピー先にPosPTNだけ変更してコピー
            For i = 0 To DtblM品目Btn.Rows.Count - 1
                Try
                    'トランザクション開始
                    Call cDB.BeginTransaction()

                    msSQL = " "
                    msSQL += " insert into  POS_M品目ボタン設定 "
                    msSQL += " values(　"
                    msSQL += "'" + sakiPosPTN + "',"   'POSパターン
                    msSQL += "'1',"   'POS区分
                    msSQL += "'" + DtblM品目Btn.Rows(i).Item("頁NO").ToString + "',"   '頁NO
                    msSQL += "'" + DtblM品目Btn.Rows(i).Item("ボタンNO").ToString + "',"   'ボタンNO
                    msSQL += "'" + DtblM品目Btn.Rows(i).Item("JANCD").ToString + "',"   'JANCD
                    msSQL += "'" + DtblM品目Btn.Rows(i).Item("部門CD").ToString + "',"   '部門CD
                    msSQL += "'" + DtblM品目Btn.Rows(i).Item("ボタン色").ToString + "')"   'ボタン色

                    mCommand = cDB.getsqlComand(msSQL)
                    Call mCommand.ExecuteNonQuery()
                    'コミット
                    Call cDB.Commit()

                    'プログレスバーで結果を報告する
                    lblPrgBar.Text = "完了しました。"
                    ' MessageBox.Show("COPYが正常に終了しました！")
                Catch ex As Exception
                    'ロールバック
                    Call cDB.Rollback()
                    MessageBox.Show("Copyに失敗しました！")

                End Try
            Next
            MessageBox.Show("ページのコピーが正常に終了しました！")
            ProgressBar1.Visible = True   'プログレスバーを見せる
            lblPrgBar.Visible = True
            '　2秒待って終了する
            System.Threading.Thread.Sleep(2000)
            Me.Close()
            '「いいえ」が選択された時 
        ElseIf result = DialogResult.No Then
            '1秒間待機する（余韻を残しながら終了する）
            System.Threading.Thread.Sleep(1000)
            Me.Close()
        End If

    End Sub
    Private Sub Btnキャンセル_Click(sender As Object, e As EventArgs) Handles Btnキャンセル.Click
        txt元CmbPosPtn.Text = ""
        Me.Close()
    End Sub

    Private Sub ItemSetToCMB(ByVal テーブル名 As String,
                             ByVal コロン前 As String,
                             ByVal コロン後 As String,
                             ByVal 対象コンボボックス As ComboBox)
        Dim cDB As New clsDB
        Dim myTable As New DataTable
        Dim strTemp As String

        'データベースから取得したいデータ群をSQLで検索
        msSQL = "SELECT * "
        msSQL += "FROM " + テーブル名
        mCommand = cDB.getsqlComand(msSQL)
        mSDA.SelectCommand = mCommand
        Call mSDA.Fill(myTable) ''データセット作成

        'SQLで検索したデータ群のレコードを取り出す
        With myTable
            For Each getItem As DataRow In .Rows

                'Copy元のPosPtnは、CmbBoxに登録しない
                If getItem(コロン前).ToString() <>
                   txt元CmbPosPtn.Text Then

                    strTemp = ""
                    strTemp += getItem(コロン前).ToString()
                    strTemp += " ： "
                    strTemp += getItem(コロン後).ToString()

                    対象コンボボックス.Items.Add(strTemp)
                End If
            Next
        End With
        Call cDB.Close()

    End Sub

    '#########################################################
    '##  Cmbボックスの Selected.Item を Get する            ##
    '#########################################################
    Private Sub SelItemGet(ByVal CmbName As ComboBox,
                       ByVal SepChar As String,
                       ByRef Item1 As String,
                      ByRef Item2 As String)
        Dim SepCharLen As Integer
        Dim ItemLen As Integer
        Dim SepCharIndx As Integer
        Dim str As String = CmbName.Text
        ItemLen = str.Length.ToString
        SepCharLen = SepChar.Length.ToString
        SepCharIndx = str.IndexOf(SepChar, 0, ItemLen)
        Item1 = str.Substring(0, SepCharIndx)
        Item2 = str.Substring(SepCharIndx + SepCharLen)    '区切り文字の後ろ全部

    End Sub

    Private Sub CmbPos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbPos.SelectedIndexChanged
        Call SelItemGet(CmbPos, " ： ", sakiPosPTN, sakiPosName)
        LblPosP.Enabled = True
        Btn実行.Enabled = True
        ActiveControl = Nothing      'フォーカスを外す
    End Sub

End Class