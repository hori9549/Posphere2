Imports System.Data
Imports System.Data.SqlClient
Public Class frm112レジボタン設定簡易
    Private Shared _mutex As System.Threading.Mutex

    Private msSQL As String
    Private mCommand As SqlCommand
    Private mSDA As New SqlDataAdapter

    Dim tblComboList As New DataTable   'POSパターンComboBoxに登録するデータリスト
    Private Sub frmレジボタン_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '-------------------------------------------------------------------------------------------------------------------------
        Dim cDB As New clsDB
        Dim msSQL As String
        '-------------------------------------------------------------------------------------------------------------------------
        Dim dtblPOS_M機能 As New DataTable
        Dim dtblPOS_M取引 As New DataTable
        '-------------------------------------------------------------------------------------------------------------------------
        Dim dtNow As DateTime = DateTime.Now

        'Me.txt日付.Text = dtNow.Year     '年を取得
        'Me.txt日付.Text = dtNow.Month    '月を取得
        'Me.txt日付.Text = dtNow.Day      '日を取得
        Me.txt日付.Text = dtNow.Month.ToString() + "/" + dtNow.Day.ToString() + " " +
                          dtNow.Hour.ToString() + ":" + dtNow.Minute.ToString()

        'Me.txt日付.Text = Date.Now.ToLongTimeString()    ' 現在時刻を表示
        'Me.txt日付.Text = Date.Now.ToShortDateString()   ' 現在日付を表示
        '-------------------------------------------------------------------------------------------------------------------------
        'データベースから取得したいデータ群をSQLで検索
        msSQL = ""
        msSQL += "SELECT POSパターン,パターン名称 "
        msSQL += "FROM POS_MPOSパターン "
        msSQL += "ORDER BY POSパターン"

        mCommand = cDB.getsqlComand(msSQL)
        mSDA.SelectCommand = mCommand
        Call mSDA.Fill(tblComboList) ''データセット作成

        'SQLで検索したデータ群のレコードを、1レコードずつ取り出す
        For nRowCounter As Integer = 0 To tblComboList.Rows.Count - 1
            cmbposパターン選択.Items.Add(tblComboList.Rows(nRowCounter).Item("パターン名称").ToString())
        Next
        cmbposパターン選択.SelectedIndex = -1
        '-------------------------------------------------------------------------------------------------------------------------
        msSQL = ""
        msSQL += "Select a.機能CD,a.表示名 As 機能名,b.説明 "
        msSQL += "From POS_M機能ボタン設定 As a, POS_Mボタン機能 As b "
        msSQL += "Where a.機能CD = b.機能CD "
        msSQL += "Order By 機能CD"

        mCommand = cDB.getsqlComand(msSQL)
        mSDA.SelectCommand = mCommand

        Call mSDA.Fill(dtblPOS_M機能)

        col機能CD.DataSource = dtblPOS_M機能

        '+++++++++++++++カラム幅変更+++++++++++++++
        Me.col機能CD.Columns("機能CD").Width = 70
        Me.col機能CD.Columns("機能名").Width = 100
        'Me.col機能CD.Columns("説明").Width = 300
        '列の幅が自動的に変更される
        'Me.col機能CD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

        Me.col機能CD.RowHeadersWidth = 25       'RowHeader幅
        '-------------------------------------------------------------------------------------------------------------------------
        msSQL = ""
        msSQL += "Select 取引CD,取引名,クーポン金額 "
        msSQL += "From POS_M取引 "
        msSQL += "ORDER BY 取引CD"

        mCommand = cDB.getsqlComand(msSQL)
        mSDA.SelectCommand = mCommand

        Call mSDA.Fill(dtblPOS_M取引)

        col取引CD.DataSource = dtblPOS_M取引

        '+++++++++++++++カラム幅変更+++++++++++++++
        Me.col取引CD.Columns("取引CD").Width = 70
        Me.col取引CD.Columns("取引名").Width = 270
        'Me.col取引CD.Columns("クーポン金額").Width = 100
        'textを垂直方向は中央に、水平方向はセルの右側に合わせて配置
        Me.col取引CD.Columns("クーポン金額").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        '列の幅が自動的に変更される
        'col取引CD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

        Me.col取引CD.RowHeadersWidth = 25       'RowHeader幅
        '-------------------------------------------------------------------------------------------------------------------------
        'Call cDB.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub col機能CD_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles col機能CD.CellContentClick

    End Sub
    Private Sub col取引CD_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles col取引CD.CellContentClick

    End Sub

    Private Sub grp合計金額_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub txt１_TextChanged(sender As Object, e As EventArgs) Handles txt１.TextChanged

    End Sub
    Private Sub btn読込R_Click(sender As Object, e As EventArgs) Handles btn読込R.Click
        If cmbposパターン選択.Text = Nothing Then
            MessageBox.Show("POSパターンを選択してください。", "SpreadNPC", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else
            MessageBox.Show("OK!", "SpreadNPC", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub btnキー設定_Click(sender As Object, e As EventArgs) Handles btnキー設定.Click
        MessageBox.Show("設定されていません。", "SpreadNPC", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub
    Private Sub btn予備キー設定_Click(sender As Object, e As EventArgs) Handles btn予備キー設定.Click
        MessageBox.Show("設定されていません。", "SpreadNPC", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub btn終了_Click(sender As Object, e As EventArgs) Handles btn終了.Click
        Me.Close()
    End Sub

End Class