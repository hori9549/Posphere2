Imports System.Data
Imports System.Data.SqlClient

Public Class frm105商品登録_コピー画面
    Private Shared _mutex As System.Threading.Mutex

    Private msSQL As String
    Private mCommand As SqlCommand
    Private mSDA As New SqlDataAdapter


    '-------------------------------------------------------------------------------------------------------------------------
    ''Publicな親
    'Public frm親 As frm105商品登録
    '-------------------------------------------------------------------------------------------------------------------------
    '特定のデータだけもらう場合（frm105商品登録）
    Public strPosPtnName As String
    Public nPosPtnNo As Integer

    Private Sub frm105商品登録_コピー画面_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim DB選択内容() As String
        DB選択内容 = {"レストラン", "スナック", "ショッピング", "ベーカリー"}

        cmb選択.DataSource = DB選択内容
        cmb選択.SelectedIndex = -1

        ''タイトルバーを消す
        'Me.FormBorderStyle = FormBorderStyle.None
        ''ユーザーがサイズを変更できないようにする（最大化、最小化はできる）
        'Me.FormBorderStyle = FormBorderStyle.FixedSingle

    End Sub
    Private Sub btn実行_Click(sender As Object, e As EventArgs) Handles btn実行.Click
        'Dim cDB As New clsDB
        'Dim msSQL As String
        'Dim tblsentaku As New DataTable
        'MessageBox.Show(strPosPtnName, "商品登録", MessageBoxButtons.OK, MessageBoxIcon.Information)

        'If strPosPtnName = frm親.cmbPOSパターン.Text Then
        If strPosPtnName = "レストラン" Then
            If Me.cmb選択.Text = Nothing Then
                MessageBox.Show("コピー元のPOSパターンを選択して下さい。", "商品登録", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ElseIf Me.cmb選択.Text = "レストラン" Then
                MessageBox.Show("コピー元のPOSパターンが同じです。", "商品登録", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ElseIf Me.cmb選択.Text = "スナック" Then
                MessageBox.Show("オーダリング接続有無に相違があるパターン間のコピーはできません。", "商品登録", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ElseIf Me.cmb選択.Text = "ショッピング" Then
                MessageBox.Show("オーダリング接続有無に相違があるパターン間のコピーはできません。", "商品登録", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ElseIf Me.cmb選択.Text = "ベーカリー" Then
                MessageBox.Show("オーダリング接続有無に相違があるパターン間のコピーはできません。", "商品登録", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else
                MessageBox.Show("エラー", "商品登録", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            End If

        ElseIf strPosPtnName = "スナック" Then
            If Me.cmb選択.Text = Nothing Then
                MessageBox.Show("コピー元のPOSパターンを選択して下さい。", "商品登録", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ElseIf Me.cmb選択.Text = "レストラン" Then
                MessageBox.Show("オーダリング接続有無に相違があるパターン間のコピーはできません。", "商品登録", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ElseIf Me.cmb選択.Text = "スナック" Then
                MessageBox.Show("コピー元のPOSパターンが同じです。", "商品登録", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ElseIf Me.cmb選択.Text = "ショッピング" Then
                MessageBox.Show("ショッピングの設定内容をコピーします。よろしいですか？", "商品登録", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)

            ElseIf Me.cmb選択.Text = "ベーカリー" Then
                MessageBox.Show("ベーカリーの設定内容をコピーします。よろしいですか？", "商品登録", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)

            Else
                MessageBox.Show("エラー", "商品登録", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            End If

        ElseIf strPosPtnName = "ショッピング" Then
            If Me.cmb選択.Text = Nothing Then
                MessageBox.Show("コピー元のPOSパターンを選択して下さい。", "商品登録", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ElseIf Me.cmb選択.Text = "レストラン" Then
                MessageBox.Show("オーダリング接続有無に相違があるパターン間のコピーはできません。", "商品登録", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ElseIf Me.cmb選択.Text = "スナック" Then
                MessageBox.Show("スナックの設定内容をコピーします。よろしいですか？", "商品登録", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)

            ElseIf Me.cmb選択.Text = "ショッピング" Then
                MessageBox.Show("コピー元のPOSパターンが同じです。", "商品登録", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ElseIf Me.cmb選択.Text = "ベーカリー" Then
                MessageBox.Show("ベーカリーの設定内容をコピーします。よろしいですか？", "商品登録", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)

            Else
                MessageBox.Show("エラー", "商品登録", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            End If

        ElseIf strPosPtnName = "ベーカリー" Then
            If Me.cmb選択.Text = Nothing Then
                MessageBox.Show("コピー元のPOSパターンを選択して下さい。", "商品登録", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ElseIf Me.cmb選択.Text = "レストラン" Then
                MessageBox.Show("オーダリング接続有無に相違があるパターン間のコピーはできません。", "商品登録", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ElseIf Me.cmb選択.Text = "スナック" Then
                MessageBox.Show("スナックの設定内容をコピーします。よろしいですか？", "商品登録", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)

            ElseIf Me.cmb選択.Text = "ショッピング" Then
                MessageBox.Show("ショッピングの設定内容をコピーします。よろしいですか？", "商品登録", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)

            ElseIf Me.cmb選択.Text = "ベーカリー" Then
                MessageBox.Show("コピー元のPOSパターンが同じです。", "商品登録", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else
                MessageBox.Show("エラー", "商品登録", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            End If

        Else
            MessageBox.Show("エラー", "商品登録", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End If

        'mCommand = cDB.getsqlComand(msSQL)
        'mSDA.SelectCommand = mCommand

        'Call mSDA.Fill(tblsentaku)

        'dgv一覧.DataSource = tblComboList
        '-------------------------------------------------------------------------------------------------------------------------
        'MessageBox.Show("コピー元のPOSパターンが同じです。", "商品登録", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'MessageBox.Show("オーダリング接続有無に相違があるパターン間のコピーはできません。", "商品登録", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'MessageBox.Show("スナックの設定内容をコピーします。よろしいですか？", "商品登録", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
        'MessageBox.Show("ショッピングの設定内容をコピーします。よろしいですか？", "商品登録", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
        'MessageBox.Show("ベーカリーの設定内容をコピーします。よろしいですか？", "商品登録", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
        'MessageBox.Show("レストラン後払いのパターン間コピーはできません。", "商品登録", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '-------------------------------------------------------------------------------------------------------------------------
    End Sub

    Private Sub btnキャンセル_Click(sender As Object, e As EventArgs) Handles btnキャンセル.Click
        Me.Close()
    End Sub

End Class