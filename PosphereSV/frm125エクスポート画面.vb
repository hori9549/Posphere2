Imports System.Data
Imports System.Data.SqlClient
Public Class frm125エクスポート画面
    ''データベース接続用-------------------------------
    Private msSQL As String
    Private mCommand As SqlCommand
    Private mSDA As New SqlDataAdapter

    'Dim 選択済表Count As Integer = 0       '設定メニューの行、列番号　COUNT　UP用

    Public tgtTableName As String

    '画面右側の「出力する項目」グリッドの実体データ
    Dim dtbl出力する項目 As New DataTable

    '画面左側の「出力可能な項目」グリッドの実体データ
    Dim dtbl出力可能 As New DataTable

    Public Sub MoveToGrid(ByVal dtMoto As DataTable,
                               ByVal dtSaki As DataTable,
                               ByVal dgvMoto As DataGridView
                               )

        If dtMoto.Rows.Count <= 0 Then
            '移動元Gridの登録データが1件もない場合、以下の処理を行わずExitSubする
            Exit Sub
        End If

        If dgvMoto.SelectedRows.Count <= 0 Then
            '移動元Gridの登録データが1件もない場合、以下の処理を行わずExitSubする
            Exit Sub
        End If

        Dim row選択後 As DataRow
        row選択後 = dtSaki.NewRow
        row選択後("列名") = dtMoto.Rows(dgvMoto.SelectedRows(0).Index).Item("列名")
        dtSaki.Rows.InsertAt(row選択後, dtSaki.Rows.Count)

        dtMoto.Rows.RemoveAt(dgvMoto.SelectedRows(0).Index)




    End Sub

    Private Sub frm125エクスポート画面_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cDB As New clsDB
        Dim msSQL As String

        'データベースから取得したいデータ群をSQLで検索
        'フィールド（列）の一覧取得
        msSQL = "SELECT name As 列名 "
        msSQL += "FROM sys.columns "
        msSQL += "WHERE object_id = (SELECT object_id "
        msSQL += "            From sys.tables "
        msSQL += "            Where Name = '" + tgtTableName + "'"
        msSQL += "            )"

        mCommand = cDB.getsqlComand(msSQL)
        mSDA.SelectCommand = mCommand
        Call mSDA.Fill(dtbl出力可能) ''データセット作成

        dgv出力可能.DataSource = dtbl出力可能

        Call cDB.Close()

        '画面右側の「出力する項目」グリッドの設定
        dgv出力する.DataSource = dtbl出力する項目
        dtbl出力する項目.Columns.Add("列名")

        dgv出力可能.Columns(0).Visible = False
        dgv出力する.Columns(0).Visible = False


    End Sub

    Private Sub Btn選択ボタン_Click(sender As Object, e As EventArgs) Handles btn単右へ.Click

        '-----------------------------------
        MoveToGrid(dtbl出力可能,
                    dtbl出力する項目,
                    dgv出力可能
                    )
        '-----------------------------------
        'If dtbl出力可能.Rows.Count <= 0 Then
        '    '移動元Gridの登録データが1件もない場合、以下の処理を行わずExitSubする
        '    Exit Sub
        'End If

        'Dim row選択後 As DataRow
        'row選択後 = dtbl出力する項目.NewRow
        'row選択後("列名") = dtbl出力可能.Rows(dgv出力可能.SelectedRows(0).Index).Item("列名")
        'dtbl出力する項目.Rows.InsertAt(row選択後, dtbl出力する項目.Rows.Count)

        'dtbl出力可能.Rows.RemoveAt(dgv出力可能.SelectedRows(0).Index)
        '-----------------------------------



    End Sub

    Private Sub btnキャンセル_Click_1(sender As Object, e As EventArgs) Handles btnキャンセル.Click
        Me.Close()
    End Sub

    Private Sub btn単左へ_Click(sender As Object, e As EventArgs) Handles btn単左へ.Click

        '-----------------------------------
        MoveToGrid(dtbl出力する項目,
                    dtbl出力可能,
                    dgv出力する
                    )
        '-----------------------------------
        'If dtbl出力する項目.Rows.Count <= 0 Then
        '    '移動元Gridの登録データが1件もない場合、以下の処理を行わずExitSubする
        '    Exit Sub
        'End If

        'Dim row選択後 As DataRow
        'row選択後 = dtbl出力可能.NewRow
        'row選択後("列名") = dtbl出力する項目.Rows(dgv出力する.SelectedRows(0).Index).Item("列名")
        'dtbl出力可能.Rows.InsertAt(row選択後, dtbl出力可能.Rows.Count)

        'dtbl出力する項目.Rows.RemoveAt(dgv出力する.SelectedRows(0).Index)
        '-----------------------------------
        'Dim row選択後 As DataRow
        'row選択後 = dtbl出力可能.NewRow
        'row選択後("列名") = dtbl出力する項目.Rows(dgv出力する.SelectedRows(0).Index).Item("列名")
        'dtbl出力可能.Rows.InsertAt(row選択後, dtbl出力可能.Rows.Count)

        'dtbl出力する項目.Rows(dgv出力する.SelectedRows(0).Index).Delete()
        '-----------------------------------

    End Sub


    Private Sub btn全右へ_Click(sender As Object, e As EventArgs) Handles btn全右へ.Click

        If dgv出力可能.Rows.Count <= 0 Then
            '移動元Gridの登録データが1件もない場合、以下の処理を行わずExitSubする
            Exit Sub
        End If


        dtbl出力する項目 = dtbl出力可能.Copy
        dgv出力する.DataSource = dtbl出力する項目

        dtbl出力可能.Clear()



    End Sub



    Private Sub btn全左へ_Click(sender As Object, e As EventArgs) Handles btn全左へ.Click

        If dgv出力する.Rows.Count <= 0 Then
            '移動元Gridの登録データが1件もない場合、以下の処理を行わずExitSubする
            Exit Sub
        End If


        dtbl出力可能 = dtbl出力する項目.Copy
        dgv出力可能.DataSource = dtbl出力可能

        dtbl出力する項目.Clear()



    End Sub

    Private Sub btn出力_Click(sender As Object, e As EventArgs) Handles btn出力.Click
        '保存用のファイルを開く
        Using writer As New System.IO.StreamWriter("C:\work\test.csv", False, System.Text.Encoding.GetEncoding("shift_jis"))
            Dim rowCount As Integer = dgv出力する.Rows.Count

            ''ユーザによる行追加が許可されている場合は、最後の新規入力用の
            '' 1行分を差し引く
            'Dim rowCount As Integer = dgv出力する.Rows.Count
            'If (dgv出力する.AllowUserToAddRows = True) Then
            '    rowCount = rowCount - 1
            'End If

            ' 行
            For i As Integer = 0 To rowCount - 1
                ' リストの初期化
                Dim strList As New List(Of String)

                ' 列
                For j As Integer = 1 To dgv出力する.Columns.Count - 1
                    strList.Add(dgv出力する(j, i).Value.ToString())
                Next
                Dim strArray As String() = strList.ToArray() ' 配列へ変換

                ' CSV 形式に変換
                Dim strCsvData As String = String.Join(",", strArray)

                writer.WriteLine(strCsvData)
            Next
        End Using
    End Sub

End Class