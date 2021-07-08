
Imports System.Data
Imports System.Data.SqlClient
'20191127わかさあやこ
Public Class frm102POSパターン登録第2画面
    'Private Shared _mutex As System.Threading.Mutex

    Private msSQL As String
    Private mCommand As SqlCommand
    Private mSDA As New SqlDataAdapter
    Private dtbl明細 As New DataTable
    Dim tblCombList As New DataTable   'POSパターンComboBoxに登録するデータリスト
    Public nRadioBtnIdx As Integer



    Private Sub frm102POSパターン登録第2画面_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cDB As New clsDB
        Dim msSQL As String
        Dim myTable As New DataTable



        'データベースから取得したいデータ群をSQLで検索
        msSQL = ""
        msSQL += "SELECT POSパターン "
        msSQL += "FROM POS_MPOSパターン "
        msSQL += "ORDER BY POSパターン"

        mCommand = cDB.getsqlComand(msSQL)
        mSDA.SelectCommand = mCommand
        Call mSDA.Fill(myTable) ''データセット作成

        'SQLで検索したデータ群のレコードを、1レコードずつ取り出す
        For nRowCounter As Integer = 0 To myTable.Rows.Count - 1
        Next

        Call cDB.Close()


    End Sub

    Private Sub btn更新_Click(sender As Object, e As EventArgs) Handles btn更新.Click
        Dim cDB As New clsDB
        Dim msSQL As String

        If txtadoresu1.Text.Length = 0 Or
                txtadoresu2.Text.Length = 0 Or
                txtadoresu3.Text.Length = 0 Or
                txtadoresu4.Text.Length = 0 Then
            MessageBox.Show("IPアドレス入力が正しくありません。IPアドレスはブランクで登録します。",
                        "POSパターン登録")
        End If

        Try
            'トランザクション開始
            Call cDB.BeginTransaction()
            '更新
            msSQL = "UPDATE POS_MPOSパターン "

            msSQL += "SET パターン名称 = '" + txtパターン名称2.Text + "' "


            If RadioButton1.Checked = True Then

                msSQL += ", オーダリング接続 = 1"

            ElseIf RadioButton2.Checked = True Then
                msSQL += ", オーダリング接続 = 2"

            ElseIf RadioButton3.Checked = True Then
                msSQL += ", オーダリング接続 = 3"

            ElseIf RadioButton4.Checked = True Then
                msSQL += ", オーダリング接続 = 4"

            End If

            msSQL += ", "

            msSQL += "オーダリングIPアドレス = "
            msSQL += "'"
            If txtadoresu1.Text.Length > 0 And
                txtadoresu2.Text.Length > 0 And
                txtadoresu3.Text.Length > 0 And
                txtadoresu4.Text.Length > 0 Then
                msSQL += txtadoresu1.Text + "."
                msSQL += txtadoresu2.Text + "."
                msSQL += txtadoresu3.Text + "."
                msSQL += txtadoresu4.Text
            End If
            msSQL += "' "

            msSQL += " WHERE POSパターン = '" + txtPOSボタン.Text + "' "


            mCommand = cDB.getsqlComand(msSQL)
            Call mCommand.ExecuteNonQuery()
            'コミット
            Call cDB.Commit()
            MessageBox.Show("正常に更新しました！",
                        "POSパターン登録")
        Catch ex As Exception
            'ロールバック
            Call cDB.Rollback()
            MessageBox.Show("更新に失敗しました！",
                        "POSパターン登録")
        End Try

        Me.Close()

    End Sub

    Private Sub btn疎通確認_Click(sender As Object, e As EventArgs) Handles btn疎通確認.Click


        MessageBox.Show(txtadoresu1.Text + "." + txtadoresu2.Text + "." + txtadoresu3.Text + "." + txtadoresu4.Text +
                        vbCrLf + "疎通が確認されました",
                         "POSパターン登録")
        'MessageBox.Show(msSQL += "オーダリングIPアドレス = ")



    End Sub

    Private Sub btn終了_Click(sender As Object, e As EventArgs) Handles btn終了.Click
        Me.Close()

    End Sub

    Private Sub btnキャンセル_Click(sender As Object, e As EventArgs) Handles btnキャンセル.Click
        Me.Close()
    End Sub

    Private Sub btnエクスポート_Click(sender As Object, e As EventArgs) Handles btnエクスポート.Click
        Dim sfrm As New frm125エクスポート画面
        Call sfrm.ShowDialog()
    End Sub

    Private Sub btn削除_Click(sender As Object, e As EventArgs) Handles btn削除.Click

    End Sub
End Class












