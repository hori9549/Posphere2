Imports System.Data
Imports System.Data.SqlClient

Public Class frm109POS電子ジャーナル収集
    Private msSQL As String
    Private mCommand As SqlCommand
    Private mSDA As New SqlDataAdapter

    Private TMjnlDirectory As String = "\\USER-POS\SpreadN_DJNL\" '端末側ジャーナルファイル格納ディレクトリ
    Private PCjnlDirectory As String = "D:\e-PR\POS_JNL\" 'PC側ジャーナルファイル格納ディレクトリ

    Private Sub frm109POS電子ジャーナル収集_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim cDB As New clsDB
        Dim myTable As New DataTable

        Dim strTemp As String

        'データベースから取得したいデータ群をSQLで検索
        msSQL = "SELECT * "
        msSQL += "FROM POS_M端末"

        mCommand = cDB.getsqlComand(msSQL)
        mSDA.SelectCommand = mCommand

        Call mSDA.Fill(myTable) ''データセット作成
        Call cDB.Close()

        'SQLで検索したデータ群のレコードを、1レコードずつ取り出す
        For nRowCounter As Integer = 0 To myTable.Rows.Count - 1
            strTemp = "" '次に「部門コンボボックス」に登録する文字列　を　クリア（初期化：長さ０の文字列）する

            '「部門コンボボックス」に登録する文字列データの生成
            strTemp += myTable.Rows(nRowCounter).Item("端末CD").ToString()

            cDB.Close()
            '生成した文字列を「部門コンボボックス」に登録する
            cmb1.Items.Add(strTemp)

        Next

    End Sub


    Private Sub txtPCツール側ジャーナル_TextChanged(sender As Object, e As EventArgs) Handles txtPCツール側ジャーナル下.TextChanged

    End Sub

    Private Sub btn終了_Click(sender As Object, e As EventArgs) Handles btn終了.Click
        Me.Close()
    End Sub

    Private Sub cmb1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb1.SelectedIndexChanged

        txt端末側ジャーナル下.Text = TMjnlDirectory

        CheckedListBox1.Items.Clear()
        lst2.Items.Clear()

        For intCount = 1 To 9

            CheckedListBox1.Items.Add(cmb1.Text + intCount.ToString, True)

        Next

        txtPCツール側ジャーナル下.Text = PCjnlDirectory + cmb1.Text + "\"

        '拡張子がJNLのファイルを取得するための変数


        Dim dirPath As New System.IO.DirectoryInfo(txtPCツール側ジャーナル下.Text)

        'If System.IO.File.Exists(txtPCツール側ジャーナル下.Text + "*.JNL") = True Then
        'End If

        'フォルダがなければ作成する
        If System.IO.Directory.Exists(txtPCツール側ジャーナル下.Text) = False Then
            System.IO.Directory.CreateDirectory(txtPCツール側ジャーナル下.Text)
        End If

        Dim chkFiles As System.IO.FileInfo() = dirPath.GetFiles("*")

        Dim chkJournal As Boolean = False

        For Each filename As System.IO.FileInfo In chkFiles
            If Strings.Right(filename.Name, 3) = "JNL" Then chkJournal = True
        Next

        If chkJournal = True Then
            Dim files As System.IO.FileInfo() = dirPath.GetFiles("*.JNL")

            'ListBox2に拡張子がJNLのファイルを表示する
            For Each filename As System.IO.FileInfo In files
            lst2.Items.Add(filename.Name)
        Next
        End If

    End Sub

    Private Sub btn実行_Click(sender As Object, e As EventArgs) Handles btn実行.Click


        If txtPCツール側ジャーナル下.Text = "" Then

        Else

            Dim Path As String = txtPCツール側ジャーナル下.Text

            'フォルダがなければ作成する
            If System.IO.Directory.Exists(Path) = False Then
                System.IO.Directory.CreateDirectory(Path)
            End If

            For intCount = 0 To CheckedListBox1.CheckedItems.Count - 1

                Using writer As New System.IO.StreamWriter(txtPCツール側ジャーナル下.Text + CheckedListBox1.CheckedItems(0) + ".JNL",
                                                           False, System.Text.Encoding.GetEncoding("shift_jis"))

                End Using

                CheckedListBox1.Items.Remove(CheckedListBox1.CheckedItems(0))

                '本来の処理はファイルの移動
                'System.IO.File.Move(txt端末側ジャーナル下.Text + CheckedListBox1.CheckedItems(0), txtPCツール側ジャーナル下.Text + CheckedListBox1.CheckedItems(0))

            Next

            '拡張子がJNLのファイルを取得するための変数
            Dim di As New System.IO.DirectoryInfo(txtPCツール側ジャーナル下.Text)
            Dim files As System.IO.FileInfo() = di.GetFiles("*.JNL")

            'ListBox2に拡張子がJNLのファイルを表示する
            For Each filename As System.IO.FileInfo In files
                lst2.Items.Add(filename.Name)
            Next

            'リストボックスのチェックをすべてクリアする
            lst2.ClearSelected()

        End If
    End Sub

    Private Sub txt端末側ジャーナル下_Click(sender As Object, e As EventArgs) Handles txt端末側ジャーナル下.Click
        'txt端末側ジャーナル下をクリックしたら、フォルダを選択できる
        Dim fbd As New FolderBrowserDialog

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
            txt端末側ジャーナル下.Text = fbd.SelectedPath.ToString
        End If

    End Sub

    Private Sub txtPCツール側ジャーナル下_Click(sender As Object, e As EventArgs) Handles txtPCツール側ジャーナル下.Click
        'txtPCツール側ジャーナル下をクリックしたら、フォルダを選択できる
        Dim fbd As New FolderBrowserDialog

        fbd.Description = "フォルダを指定してください。"

        'ルートフォルダを指定する
        'デフォルトでDesktop
        fbd.RootFolder = Environment.SpecialFolder.Desktop

        '最初に選択するフォルダを指定する
        'RootFolder以下にあるフォルダである必要がある
        'fbd.SelectedPath = "\\USER-POS\SpreadN_DJNL\"
        fbd.SelectedPath = "C:\Windows"

        'ユーザーが新しいフォルダを作成できるようにする
        'デフォルトでTrue
        fbd.ShowNewFolderButton = True

        'ダイアログを表示する
        If fbd.ShowDialog(Me) = DialogResult.OK Then
            txtPCツール側ジャーナル下.Text = fbd.SelectedPath.ToString
        End If

    End Sub
End Class

