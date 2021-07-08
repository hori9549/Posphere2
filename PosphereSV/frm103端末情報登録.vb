Imports System.Data
Imports System.Data.SqlClient
Public Class frm103端末情報登録
    ''データベース接続用-------------------------------
    Private mCommand As SqlCommand
    Private mSDA As New SqlDataAdapter

    Private Sub btn終了_Click(sender As Object, e As EventArgs) Handles btn終了.Click
        Me.Close()

    End Sub

    Private Sub frm103端末情報登録_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        SetGridData()

    End Sub

    Private Sub dgv一覧_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv一覧.CellDoubleClick
        '自画面を非表示
        'Me.Visible = False
        'Me.Close()
        Dim sfrm As New frm103端末情報登録_第2画面
        sfrm.StartPosition = FormStartPosition.CenterParent

        Dim rInd As Integer = dgv一覧.CurrentRow.Index
        sfrm.txt端末CD入力.Text = dgv一覧(0, rInd).Value.ToString
        sfrm.txt端末名入力.Text = dgv一覧(1, rInd).Value.ToString
        sfrm.cmb_POSパターン_SelectedIndex = dgv一覧(2, rInd).Value.ToString

        Select Case dgv一覧(3, rInd).Value
            Case 1
                sfrm.rdbtnレストランレジ.Checked = True
            Case 2
                sfrm.rdbtn物販レジ.Checked = True
            Case 3
                sfrm.rdbtn物販簡易.Checked = True
            Case Else
                MessageBox.Show("変なデータ：" + dgv一覧(3, rInd).Value.ToString)
        End Select

        Dim strIp() As String
        strIp = dgv一覧(4, rInd).Value.ToString().Split(".")

        If strIp.Length >= 4 Then
            sfrm.txtアドレス1.Text = strIp(0)
            sfrm.txtアドレス2.Text = strIp(1)
            sfrm.txtアドレス3.Text = strIp(2)
            sfrm.txtアドレス4.Text = strIp(3)
        End If

        'If strIp.Length >= 1 Then
        '    sfrm.txtアドレス1.Text = strIp(0)
        'End If
        'If strIp.Length >= 2 Then
        '    sfrm.txtアドレス2.Text = strIp(1)
        'End If
        'If strIp.Length >= 3 Then
        '    sfrm.txtアドレス3.Text = strIp(2)
        'End If
        'If strIp.Length >= 4 Then
        '    sfrm.txtアドレス4.Text = strIp(3)
        'End If

        sfrm.txtマスタ配信.Text = dgv一覧(5, rInd).Value.ToString
        sfrm.txt背面画像配信.Text = dgv一覧(6, rInd).Value.ToString
        sfrm.txt更新プログラム配信.Text = dgv一覧(7, rInd).ToString


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

    End Sub
    Private Sub btnエクスポート_Click(sender As Object, e As EventArgs) Handles btnエクスポート.Click
        Dim sfrm As New frm125エクスポート画面
        Call sfrm.ShowDialog()
    End Sub

    Public Sub SetGridData()
        Dim cDB As New clsDB
        Dim msSQL As String
        Dim myTable As New DataTable

        'データベースから取得したいデータ群をSQLで検索
        msSQL = "SELECT * "
        msSQL += "FROM POS_M端末"

        mCommand = cDB.getsqlComand(msSQL)
        mSDA.SelectCommand = mCommand

        Call mSDA.Fill(myTable) 'データセット作成

        dgv一覧.DataSource = myTable

        Call cDB.Close()
    End Sub

End Class

