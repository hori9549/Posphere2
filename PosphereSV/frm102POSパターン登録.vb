Imports System.Data
Imports System.Data.SqlClient

'20191127わかさあやこ
Public Class frmPOSパターン
    Private msSQL As String
    Private mCommand As SqlCommand
    Private mSDA As New SqlDataAdapter
    Private dtbl明細 As New DataTable

    Private Sub frmPOSパターン_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetGridData()
    End Sub


    Private Sub dgv一覧_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv一覧.CellDoubleClick
        Dim sfrm As New frm102POSパターン登録第2画面
        Dim rInd As Integer = dgv一覧.CurrentRow.Index

        sfrm.txtPOSボタン.Text = dgv一覧(0, rInd).Value.ToString
        sfrm.txtパターン名称2.Text = dgv一覧(1, rInd).Value.ToString
        Select Case dgv一覧(2, rInd).Value
            Case 1
                sfrm.RadioButton1.Checked = True
            Case 2
                sfrm.RadioButton2.Checked = True
            Case 3
                sfrm.RadioButton3.Checked = True
            Case 4
                sfrm.RadioButton4.Checked = True
            Case Else
                MessageBox.Show("適応のない番号です：" + dgv一覧(2, rInd).Value.ToString)
        End Select

        sfrm.txtadoresu1.Text = dgv一覧(3, rInd).Value.ToString
        Dim strIp() As String
        strIp = dgv一覧(3, rInd).Value.ToString().Split(".")

        If strIp.Length >= 4 Then
            sfrm.txtadoresu1.Text = strIp(0)
            sfrm.txtadoresu2.Text = strIp(1)
            sfrm.txtadoresu3.Text = strIp(2)
            sfrm.txtadoresu4.Text = strIp(3)
        End If

        Call sfrm.ShowDialog()

        SetGridData()
        Me.Show()

    End Sub

    Private Sub btnインポート_Click(sender As Object, e As EventArgs) Handles btnインポート.Click
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
            Console.WriteLine(fbd.SelectedPath)
        End If
        '        C#
        '        コードを隠すコードを選択
        '//FolderBrowserDialogクラスのインスタンスを作成
        'FolderBrowserDialog fbd = New FolderBrowserDialog();

        '//上部に表示する説明テキストを指定する
        'fbd.Description = "フォルダを指定してください。";
        '//ルートフォルダを指定する
        '//デフォルトでDesktop
        'fbd.RootFolder = Environment.SpecialFolder.Desktop;
        '//最初に選択するフォルダを指定する
        '//RootFolder以下にあるフォルダである必要がある
        'fbd.SelectedPath = @"C:\Windows";
        '//ユーザーが新しいフォルダを作成できるようにする
        '//デフォルトでTrue
        'fbd.ShowNewFolderButton = True;

        '//ダイアログを表示する
        'If (fbd.ShowDialog(this) == DialogResult.OK) Then
        '            {
        '    //選択されたフォルダを表示する
        '    Console.WriteLine(fbd.SelectedPath);
        '}
    End Sub

    Private Sub btn終了_Click(sender As Object, e As EventArgs) Handles btn終了.Click
        Me.Close()
    End Sub

    Private Sub btnエクスポート_Click(sender As Object, e As EventArgs) Handles btnエクスポート.Click
        Dim sfrm As New frm125エクスポート画面
        Call sfrm.ShowDialog()
    End Sub


    ''SQLで検索したデータ群のレコードを、1レコードずつ取り出す
    'For nRowCounter As Integer = 0 To myTable.Rows.Count - 1
    '    strTemp = "" '次に「部門コンボボックス」に登録する文字列　を　クリア（初期化：長さ０の文字列）する

    '    '取り出したレコードのフィールドを1つずつ取得する場合は以下の処理で取り出せるよ
    '    'For nColumuCounter As Integer = 0 To myTable.Columns.Count - 1
    '    '    strTemp += myTable.Rows(nRowCounter).Item(nColumuCounter).ToString()
    '    'Next

    '    '「部門コンボボックス」に登録する文字列データの生成
    '    strTemp += myTable.Rows(nRowCounter).Item("POSパターン").ToString()
    '    strTemp += "パターン名称"
    '    strTemp += myTable.Rows(nRowCounter).Item("オーダリング接続").ToString()
    '    strTemp += myTable.Rows(nRowCounter).Item("オーダリングIPアドレス").ToString()
    '    '生成した文字列を「部門コンボボックス」に登録する
    '    dgv一覧.DataSource.myTable(strTemp)





    'Private Sub btn更新_Click(sender As Object, e As EventArgs) Handles btn更新.Click
    '    Dim row明細 As DataRow
    '    row明細 = dtbl明細.New Row

    ' dtbl明細.Rows Add()



    'End Sub

    Public Sub SetGridData()
        Dim cDB As New clsDB
        Dim msSQL As String
        Dim myTable As New DataTable
        'Dim strTemp As String '検索条件の「部門コンボボックス」に登録する文字列を生成する際に使う作業用変数

        'データベースから取得したいデータ群をSQLで検索
        msSQL = "SELECT * "
        msSQL += " FROM POS_MPOSパターン"

        mCommand = cDB.getsqlComand(msSQL)
        mSDA.SelectCommand = mCommand

        Call mSDA.Fill(myTable) ''データセット作成

        dgv一覧.DataSource = myTable

        Call cDB.Close()
    End Sub
End Class
'

