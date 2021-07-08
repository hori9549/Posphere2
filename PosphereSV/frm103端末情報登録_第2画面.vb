Imports System.Data
Imports System.Data.SqlClient
Public Class frm103端末情報登録_第2画面
    ''データベース接続用-------------------------------
    Private msSQL As String
    Private mCommand As SqlCommand
    Private mSDA As New SqlDataAdapter
    Private dtbl明細 As New DataTable

    Dim tblComboList As New DataTable
    Public cmb_POSパターン_SelectedIndex As Integer
    Public nRadioBtnIdx As Integer

    Private Sub cmb_POSパターン_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_POSパターン.SelectedIndexChanged
        Dim cDB As New clsDB
        Dim msSQL As String
        Dim myTable As New DataTable
        '  Dim strTemp As String '検索条件の「部門コンボボックス」に登録する文字列を生成する際に使う作業用変数

        'データベースから取得したいデータ群をSQLで検索
        msSQL = "SELECT * "
        msSQL += "FROM POS_M端末"

        mCommand = cDB.getsqlComand(msSQL)
        mSDA.SelectCommand = mCommand

        Call mSDA.Fill(myTable) ''データセット作成
        'dgv一覧.DataSource = myTable
        Call cDB.Close()
    End Sub

    Private Sub frm103端末情報登録_第2画面_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cDB As New clsDB
        Dim msSQL As String
        Dim strTemp As String '検索条件の「CmbPosパターン」に登録する文字列を生成する際に使う作業用変数
        Dim nCmbSelectIndex As Integer = -1

        'データベースから取得したいデータ群をSQLで検索
        msSQL = ""
        msSQL += "select POSパターン,パターン名称 "
        msSQL += "from POS_MPOSパターン"

        mCommand = cDB.getsqlComand(msSQL)
        mSDA.SelectCommand = mCommand
        Call mSDA.Fill(tblComboList) ''データセット作成

        'SQLで検索したデータ群のレコードを、1レコードずつ取り出す
        For nRowCounter As Integer = 0 To tblComboList.Rows.Count - 1
            '「POSパターン」に登録する文字列データの生成
            strTemp = tblComboList.Rows(nRowCounter).Item("パターン名称").ToString()

            '生成した文字列を「POSパターン」に登録する
            cmb_POSパターン.Items.Add(strTemp)

            If cmb_POSパターン_SelectedIndex = tblComboList.Rows(nRowCounter).Item("POSパターン") Then
                nCmbSelectIndex = nRowCounter
            End If
        Next


        Call cDB.Close()

        cmb_POSパターン.SelectedIndex = nCmbSelectIndex
        txt端末名入力.SelectAll()
    End Sub

    Private Sub btn疎通確認_Click(sender As Object, e As EventArgs) Handles btn疎通確認.Click

        MessageBox.Show("端末情報登録")

    End Sub

    Private Sub btn参照1_Click(sender As Object, e As EventArgs) Handles btn参照1.Click
        'FolderBrowserDialogクラスのインスタンスを作成
        Dim fbd As New FolderBrowserDialog

        '上部に表示する説明テキストを指定する
        fbd.Description = "フォルダを指定してください。"
        'ルートフォルダを指定する
        'デフォルトでDesktop
        fbd.RootFolder = Environment.SpecialFolder.Desktop
        '最初に選択するフォルダを指定する
        'RootFolder以下にあるフォルダである必要がある
        fbd.SelectedPath = "C:\Windows"
        'ユーザーが新しいフォルダを作成できるようにする
        'デフォルトでTrue
        fbd.ShowNewFolderButton = True

        'ダイアログを表示する
        If fbd.ShowDialog(Me) = DialogResult.OK Then
            '選択されたフォルダを表示する
            txtマスタ配信.Text = fbd.SelectedPath
        End If


    End Sub

    Private Sub btn参照2_Click(sender As Object, e As EventArgs) Handles btn参照2.Click
        Dim fbd As New FolderBrowserDialog
        fbd.Description = "フォルダを指定してください。"
        fbd.RootFolder = Environment.SpecialFolder.Desktop
        fbd.SelectedPath = "C:\Windows"
        fbd.ShowNewFolderButton = True

        If fbd.ShowDialog(Me) = DialogResult.OK Then
            txt背面画像配信.Text = fbd.SelectedPath
        End If
    End Sub

    Private Sub btn参照3_Click(sender As Object, e As EventArgs) Handles btn参照3.Click
        Dim fbd As New FolderBrowserDialog
        fbd.Description = "フォルダを指定してください。"
        fbd.RootFolder = Environment.SpecialFolder.Desktop
        fbd.SelectedPath = "C:\Windows"
        fbd.ShowNewFolderButton = True

        If fbd.ShowDialog(Me) = DialogResult.OK Then
            txt更新プログラム配信.Text = fbd.SelectedPath
        End If
    End Sub


    Private Sub btn更新_Click(sender As Object, e As EventArgs) Handles btn更新.Click
        Dim cDB As New clsDB
        Dim msSQL As String


        If txtアドレス1.Text.Length = 0 Or
                txtアドレス2.Text.Length = 0 Or
                txtアドレス3.Text.Length = 0 Or
                txtアドレス4.Text.Length = 0 Then

            MessageBox.Show("IPアドレスの入力が正しくありません。" & Environment.NewLine &
                            "IPアドレスの欄は空白で登録します。",
                        "確認！", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        Try
            'トランザクション開始
            Call cDB.BeginTransaction()
            '更新
            msSQL = "UPDATE POS_M端末 "

            msSQL += "SET 端末名 = '" + txt端末名入力.Text + "' "

            msSQL += ", POSパターン = " + tblComboList.Rows(cmb_POSパターン.SelectedIndex).Item("POSパターン").ToString

            If rdbtnレストランレジ.Checked = True Then
                msSQL += ", POS種別 = 1"
            ElseIf rdbtn物販レジ.Checked = True Then
                msSQL += ", POS種別 = 2"
            ElseIf rdbtn物販簡易.Checked = True Then
                msSQL += ", POS種別 = 3"
            End If

            msSQL += ", 端末IPアドレス = "
            msSQL += "'"
            If txtアドレス1.Text.Length > 0 And
                txtアドレス2.Text.Length > 0 And
                txtアドレス3.Text.Length > 0 And
                txtアドレス4.Text.Length > 0 Then
                msSQL += txtアドレス1.Text + "."
                msSQL += txtアドレス2.Text + "."
                msSQL += txtアドレス3.Text + "."
                msSQL += txtアドレス4.Text
            End If
            msSQL += "' "

            msSQL += ", マスタ用フォルダ = '" + txtマスタ配信.Text + "' "
            msSQL += ", 背面画像用フォルダ = '" + txt背面画像配信.Text + "' "
            msSQL += ", 更新AP用フォルダ = '" + txt更新プログラム配信.Text + "' "


            msSQL += " WHERE 端末CD = '" + txt端末CD入力.Text + "' "

            mCommand = cDB.getsqlComand(msSQL)
            Call mCommand.ExecuteNonQuery()
            'コミット
            Call cDB.Commit()
            MessageBox.Show("正常に更新しました！",
                        "端末情報登録", MessageBoxButtons.OK, MessageBoxIcon.None)
        Catch ex As Exception
            'ロールバック
            Call cDB.Rollback()
            MessageBox.Show("更新に失敗しました！",
                        "端末情報登録", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


        Me.Close()

    End Sub

    Private Sub btn削除_Click(sender As Object, e As EventArgs) Handles btn削除.Click
        Dim bYesNo As Boolean
        bYesNo = MessageBox.Show("この登録内容を削除します。よろしいですか？",
                                    "端末情報登録",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Exclamation)
        Select Case bYesNo
            Case DialogResult.Yes

            Case DialogResult.No
                Application.Exit()
        End Select

        Dim cDB As New clsDB
        Dim msSQL As String
        Dim myTable As New DataTable
        Dim strTemp As String
        Try
            'トランザクション開始
            Call cDB.BeginTransaction()
            '削除
            msSQL = "Delete POS_M端末 where 端末CD = " + txt端末CD入力.Text
            mCommand = cDB.getsqlComand(msSQL)
            Call mCommand.ExecuteNonQuery()
            'コミット
            Call cDB.Commit()
        Catch ex As Exception
            'ロールバック
            Call cDB.Rollback()
        End Try

        Me.Close()

    End Sub

    Private Sub btnキャンセル_Click(sender As Object, e As EventArgs) Handles btnキャンセル.Click
        Me.Close()
    End Sub

    Private Sub btnｴｸｽﾎﾟｰﾄ_Click(sender As Object, e As EventArgs)
        Dim sfrm As New frm125エクスポート画面
        sfrm.ShowDialog()
    End Sub

    Private Sub btn終了_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

End Class
