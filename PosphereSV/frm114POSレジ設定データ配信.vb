Imports System.Data
Imports System.Data.SqlClient

Public Class frmレジ設定データ配信
    ''データベース接続用-------------------------------
    Private msSQL As String
    Private mCommand As SqlCommand
    Private mSDA As New SqlDataAdapter

    Dim tblComboPosPtn As New DataTable '★
    Private Sub frmレジ設定データ配信_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cDB As New clsDB '★
        Dim strTemp As String '検索条件の「部門コンボボックス」に登録する文字列を生成する際に使う作業用変数

        'データベースから取得したいデータ群をSQLで検索
        msSQL = "SELECT * " '★
        msSQL += "FROM POS_M端末" '★

        mCommand = cDB.getsqlComand(msSQL) '★上の二行に対するおまじない
        mSDA.SelectCommand = mCommand

        Call mSDA.Fill(tblComboPosPtn) ''データセット作成

        'SQLで検索したデータ群のレコードを、1レコードずつ取り出す
        For nRowCounter As Integer = 0 To tblComboPosPtn.Rows.Count - 1
            strTemp = "" '次に「部門コンボボックス」に登録する文字列　を　クリア（初期化：長さ０の文字列）する

            '「部門コンボボックス」に登録する文字列データの生成
            strTemp += tblComboPosPtn.Rows(nRowCounter).Item("端末CD").ToString()

            cDB.Close()
            '生成した文字列を「部門コンボボックス」に登録する
            cmb1.Items.Add(strTemp)

        Next

    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btn配信.Click
        '文字を右揃えにしてメッセージボックスを表示する
        Dim result As DialogResult = MessageBox.Show("ファイルを上書きしますか？",
                                                     "質問",
                                                     MessageBoxButtons.YesNoCancel,
                                                     MessageBoxIcon.Exclamation,
                                                     MessageBoxDefaultButton.Button2,
                                                     MessageBoxOptions.RightAlign)
    End Sub

    Private Sub cmb1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb1.SelectedIndexChanged

    End Sub

    Private Sub btn読込_Click(sender As Object, e As EventArgs) Handles btn読込.Click
        Dim cDB As New clsDB '★
        Dim myTable As New DataTable '★

        'データベースから取得したいデータ群をSQLで検索
        msSQL = "SELECT * " '★
        msSQL += "FROM POS_M端末 " '★
        msSQL += "where 端末CD='" + tblComboPosPtn.Rows(cmb1.SelectedIndex).Item("端末CD").ToString() + "'" '★

        mCommand = cDB.getsqlComand(msSQL) '★上の二行に対するおまじない
        mSDA.SelectCommand = mCommand
        Call mSDA.Fill(myTable) 'データセット作成

        DataGridView1.DataSource = myTable

        cDB.Close()
    End Sub

    Private Sub btn終了_Click(sender As Object, e As EventArgs) Handles btn終了.Click
        Me.Close()
    End Sub
End Class