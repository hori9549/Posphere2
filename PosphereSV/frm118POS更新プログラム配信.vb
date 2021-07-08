Imports System.Data '★
Imports System.Data.SqlClient '★
Public Class frm118POS更新プログラム配信
    Private msSQL As String '★
    Private mCommand As SqlCommand '★
    Private mSDA As New SqlDataAdapter '★
    Private Sub ＰＯＳ更新プログラム配信_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles lblVer2.Click

    End Sub

    Private Sub btn終了_Click(sender As Object, e As EventArgs) Handles btn終了.Click
        Me.Close()
    End Sub


    Private Sub btn参照１_Click(sender As Object, e As EventArgs) Handles btn参照１.Click 'FolderBrowserDialogクラスのインスタンスを作成
        Dim fbd As New FolderBrowserDialog

        '上部に表示する説明テキストを指定する　　ダイアログボックスを表示する
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
            txt参照box1.Text = fbd.SelectedPath
        End If
    End Sub

    Private Sub btn一覧表示_Click(sender As Object, e As EventArgs) Handles btn一覧表示.Click
        Dim cDB As New clsDB '★
        Dim msSQL As String '★
        Dim myTable As New DataTable '★
        Dim strTemp As String '検索条件の「部門コンボボックス」に登録する文字列を生成する際に使う作業用変数

        'データベースから取得したいデータ群をSQLで検索
        msSQL = "SELECT * " '★
        msSQL += "FROM POS_M端末" '★

        mCommand = cDB.getsqlComand(msSQL)
        mSDA.SelectCommand = mCommand

        Call mSDA.Fill(myTable) ''データセット作成

        grpPOS更新プログラム配信.DataSource = myTable

        cDB.Close()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Sub btn配信_Click(sender As Object, e As EventArgs) Handles btn配信.Click
        '文字を右揃えにしてメッセージボックスを表示する
        Dim result As DialogResult = MessageBox.Show("ファイルを上書きしますか？",
                                                     "質問",
                                                     MessageBoxButtons.YesNoCancel,
                                                     MessageBoxIcon.Exclamation,
                                                     MessageBoxDefaultButton.Button2,
                                                     MessageBoxOptions.RightAlign)


    End Sub

    Private Sub btn参照２_Click(sender As Object, e As EventArgs) Handles btn参照２.Click

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
            txt参照box2.Text = fbd.SelectedPath

        End If
    End Sub

    Private Sub txt参照box1_TextChanged(sender As Object, e As EventArgs) Handles txt参照box1.TextChanged

    End Sub
End Class