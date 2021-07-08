'20200820 : 漆谷

'読み込むファイルとデータベースの関係がわからず

'	01PC.csv	→	M担当
'	02PC.csv	→	M客層
'	03PC.csv	→	M分類
'	04PC.csv	→	M課税区分
'	05PC.csv	→	M部門
'	06PC.csv	→	M商品
'	07PC.csv	→	M取引分類
'	08PC.csv	→	M取引
'	09PC.csv	→	Mクーポン券発行
'	11PC.csv	→	Mバンドル
'	12PC.csv	→	M単品スケジュール
'	13PC.csv	→	M売価
'	23PC.csv	→	M消費税切替用売価
'	25PC.csv	→	M消費税切替用部門
'	26PC.csv	→	M消費税切替用商品

Imports System.Data
Imports System.Data.SqlClient
Imports System.IO

Public Class frm817マスタ反映

    Private ini As clsINI = New clsINI("設定.ini")

    'データベース接続用
    Private msSQL As String
    Private mCommand As SqlCommand
    Private mSDA As New SqlDataAdapter

    Public cmb_M単品スケジュール_SelectedIndex As Integer

    Private Sub frmマスタ反映_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '  clb反映対象ファイル.Items.Clear()

        txt最上部.Text = "外部CSVより各マスタを取り込みます。"
        txt更新日時.Text = "最終更新日時" + "：" + Now
        'txt格納場所.Text = ini.GetProfileString("FTP", "受信POSフォルダ", "")

        'Dim dilPath As New System.IO.DirectoryInfo(txt格納場所.Text)
        'Dim files As System.IO.FileInfo() =
        'dilPath.GetFiles("12PC.csv", System.IO.SearchOption.AllDirectories)

        'Dim chkFiles As System.IO.FileInfo() = dilPath.GetFiles("*")
        Dim chkJournal As Boolean = False

        '拡張子が「csv」のファイルが存在するかチェック
        'For Each filename As System.IO.FileInfo In chkFiles

        '    If Strings.Right(filename.Name, 3) = "csv" Then chkJournal = True
        '    If chkJournal = True Then Exit For

        'Next

        '拡張子が「csv」のファイルが存在するならファイル名を取得
        If chkJournal = True Then
            '  Dim getFiles As System.IO.FileInfo() = dilPath.GetFiles("*.csv")

            'lstジャーナルファイル一覧に結果を表示する
            '  For Each filename As System.IO.FileInfo In getFiles
            '  clb反映対象ファイル.Items.Add(filename.Name)
            '  Next

            'For index = 0 To clb反映対象ファイル.Items.Count - 1
            '    clb反映対象ファイル.SetItemChecked(index, True)
            'Next
        End If

    End Sub

    Private Sub btn実行_Click(sender As Object, e As EventArgs) Handles btn実行.Click

        Dim strクエリ As String = ""
        Dim strファイル名 As String = ""
        Dim strテーブル名 As String = ""
        Dim numChecked As Int16 = 0

        'For i = 0 To clb反映対象ファイル.CheckedItems.Count - 1

        '    If clb反映対象ファイル.CheckedItems(i) <> "" Then

        '        Dim cDB As New clsDB '★

        '        If clb反映対象ファイル.CheckedItems(i).ToString.Length >= 8 Then

        '            strファイル名 = clb反映対象ファイル.CheckedItems(i).ToString.Substring(clb反映対象ファイル.CheckedItems(i).ToString.Length - 8, 8)

        '            Select Case clb反映対象ファイル.CheckedItems(i).ToString.Substring(clb反映対象ファイル.CheckedItems(i).ToString.Length - 8, 8)

        '                Case "01PC.csv"
        '                    strテーブル名 = "M担当"
        '                Case "02PC.csv"
        '                    strテーブル名 = "M客層"
        '                Case "03PC.csv"
        '                    strテーブル名 = "M分類"
        '                Case "04PC.csv"
        '                    strテーブル名 = "M課税区分"
        '                Case "05PC.csv"
        '                    strテーブル名 = "M部門"
        '                Case "06PC.csv"
        '                    strテーブル名 = "M商品"
        '                Case "07PC.csv"
        '                    strテーブル名 = "M取引分類"
        '                Case "08PC.csv"
        '                    strテーブル名 = "M取引"
        '                Case "09PC.csv"
        '                    strテーブル名 = "Mクーポン券発行"
        '                Case "11PC.csv"
        '                    strテーブル名 = "Mバンドル"
        '                Case "12PC.csv"
        '                    strテーブル名 = "M単品スケジュール"
        '                Case "13PC.csv"
        '                    strテーブル名 = "M売価"
        '                Case "23PC.csv"
        '                    strテーブル名 = "M消費税切替用売価"
        '                Case "25PC.csv"
        '                    strテーブル名 = "M消費税切替用部門"
        '                Case "26PC.csv"
        '                    strテーブル名 = "M消費税切替用商品"

        '                Case Else
        '                    strテーブル名 = "M" + clb反映対象ファイル.CheckedItems(i).ToString.Substring(0, clb反映対象ファイル.CheckedItems(i).ToString.Length - 4)

        '            End Select

        '        Else

        '            strテーブル名 = "M" + clb反映対象ファイル.CheckedItems(i).ToString.Substring(0, clb反映対象ファイル.CheckedItems(i).ToString.Length - 4)

        '        End If

        '        cDB.BeginTransaction()

        '        Try

        '            txt進捗.Text = strテーブル名

        '            msSQL = ""
        '            msSQL += " BULK INSERT " + strテーブル名
        '            msSQL += " FROM "
        '            msSQL += " '" + txt格納場所.Text
        '            msSQL += "\" + clb反映対象ファイル.CheckedItems(i).ToString + "' "
        '            msSQL += " WITH ( DATAFILETYPE = 'char' "
        '            msSQL += " , FIRSTROW = 2 "
        '            msSQL += " , FIELDTERMINATOR = ',' ) "
        '            MessageBox.Show(msSQL)

        '            cDB.Commit()
        '            Call cDB.Close()

        '        Catch ex As Exception
        '            cDB.Rollback()
        '            cDB.Close()
        '            MessageBox.Show("登録に失敗しました。「" + msSQL + "」" + vbCrLf + ex.ToString,
        '                            "Informarmation",
        '                            MessageBoxButtons.OK,
        '                            MessageBoxIcon.Error)

        '            txt進捗.Text = ""

        '        End Try

        '        txt進捗.Text = ""

        '    End If

        'Next i

    End Sub

    Private Sub btnキャンセル_Click(sender As Object, e As EventArgs) Handles btnキャンセル.Click

        Me.Close()

    End Sub



End Class