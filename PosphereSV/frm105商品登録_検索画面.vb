Imports System.Data
Imports System.Data.SqlClient

Public Class frm105商品登録_検索画面
    Private Shared _mutex As System.Threading.Mutex

    Private msSQL As String
    Private mCommand As SqlCommand
    Private mSDA As New SqlDataAdapter

    Dim tblBumon As New DataTable   '部門ComboBoxに登録するデータリスト
    Dim tblBunrui As New DataTable   '分類ComboBoxに登録するデータリスト

    'cmbPOSパターン表示連携用
    Public strPosName0 As String
    Public nPosNo0 As Integer
    Private Sub frm105商品登録_検索画面_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cDB As New clsDB
        Dim msSQL As String
        '-------------------------------------------------------------------------------------------------------------------------
        Dim myTable As New DataTable
        Dim mSDA As New SqlDataAdapter
        '-------------------------------------------------------------------------------------------------------------------------
        msSQL = "Select 部門CD, 部門名 "
        msSQL += "FROM POS_M部門 "
        msSQL += "ORDER BY 部門CD"

        mCommand = cDB.getsqlComand(msSQL)
        mSDA.SelectCommand = mCommand
        Call mSDA.Fill(tblBumon)

        cmb部門.Items.Add("指定なし")
        For nRowCounter As Integer = 0 To tblBumon.Rows.Count - 1
            cmb部門.Items.Add(tblBumon.Rows(nRowCounter).Item("部門名").ToString())
        Next
        cmb部門.SelectedIndex = 0
        '-------------------------------------------------------------------------------------------------------------------------
        msSQL = "Select 分類CD, 分類名 "
        msSQL += "FROM POS_M分類 "
        msSQL += "ORDER BY 分類CD"

        mCommand = cDB.getsqlComand(msSQL)
        mSDA.SelectCommand = mCommand
        Call mSDA.Fill(tblBunrui)

        cmb分類.Items.Add("指定なし")
        For nRowCounter As Integer = 0 To tblBunrui.Rows.Count - 1
            cmb分類.Items.Add(tblBunrui.Rows(nRowCounter).Item("分類名").ToString())
        Next
        cmb分類.SelectedIndex = 0
        '-------------------------------------------------------------------------------------------------------------------------
        Me.cmbPOSパターン.Text = strPosName0
        '-------------------------------------------------------------------------------------------------------------------------
        Call cDB.Close()
        '-------------------------------------------------------------------------------------------------------------------------

    End Sub
    Private Sub cmb分類_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb分類.SelectedIndexChanged

    End Sub

    Private Sub cmb部門_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb部門.SelectedIndexChanged

    End Sub

    Private Sub txt検索カナ_TextChanged(sender As Object, e As EventArgs) Handles txt検索カナ.TextChanged

    End Sub

    Private Sub txtJANコード_TextChanged(sender As Object, e As EventArgs) Handles txtJANコード.TextChanged
        '入力文字数を13桁に制限
        txtJANコード.MaxLength = 13
    End Sub
    Private Sub btn検索_Click(sender As Object, e As EventArgs) Handles btn検索.Click
        Dim cDB As New clsDB
        Dim msSQL As String
        Dim tblComboList As New DataTable
        '-------------------------------------------------------------------------------------------------------------------------
        'テーブルを結合して、dgv一覧の ｜部門｜検索カナ｜商品名｜ に表示
        msSQL = "Select 商品CD,b.部門名 As 部門,a.検索カナ,a.品目名 As 商品名 "
        msSQL += "From (POS_MP品目 As a inner join POS_M部門 As b on a.部門CD = b.部門CD)
                      inner join POS_M分類 As c on a.分類CD = c.分類CD "
        If cmb分類.SelectedIndex > 0 Then
            msSQL += "AND 分類名 = '" + cmb分類.SelectedItem.ToString() + "' "
        End If
        If cmb部門.SelectedIndex > 0 Then
            msSQL += "AND 部門名 = '" + cmb部門.SelectedItem.ToString() + "' "
        End If
        If txt検索カナ.TextLength > 0 Then
            '    ''txt検索カナに入力した文字を結合したテーブルから検索したい
            msSQL += "AND 検索カナ LIKE '%" + txt検索カナ.Text + "%' "
            'msSQL += "OR "
            'If cmb分類.SelectedIndex > 0 And cmb部門.SelectedIndex > 0 And txt検索カナ.TextLength >= 1 Then
            '    msSQL += "品目名 = '" + cmb分類.SelectedItem.ToString() + "' "
            '    msSQL += "AND 部門名 = '" + cmb部門.SelectedItem.ToString() + "' "
            '    msSQL += "AND 品目名 LIKE '%" + txt検索カナ.Text + "%'"
            'End If
        End If
        If txtJANコード.TextLength > 0 Then
            msSQL += "AND JANCD1 = '" + txtJANコード.Text + "'"
        End If
        '-------------------------------------------------------------------------------------------------------------------------
        '=========================================================================================================================
        'Else
        ''    ''テーブルを結合して、dgv一覧の ｜部門｜検索カナ｜商品名｜ に表示
        ''    msSQL = "Select b.部門名 As 部門,a.検索カナ,a.品目名 As 商品名 "
        ''    msSQL += "From POS_M品目 As a, POS_M部門 As b "
        ''    msSQL += "Where a.部門CD = b.部門CD "
        ''    msSQL += "Order By a.商品CD"


        ''    mCommand = cDB.getsqlComand(msSQL)
        ''    mSDA.SelectCommand = mCommand

        ''    Call mSDA.Fill(tblComboList)

        ''    dgv一覧.DataSource = tblComboList

        ''    Call cDB.Close()
        'End If
        '=========================================================================================================================
        '-------------------------------------------------------------------------------------------------------------------------
        msSQL += "Order By a.部門CD + a.検索カナ"

        mCommand = cDB.getsqlComand(msSQL)
        mSDA.SelectCommand = mCommand

        Call mSDA.Fill(tblComboList)

        dgv一覧.DataSource = tblComboList

        Call cDB.Close()
        '-------------------------------------------------------------------------------------------------------------------------
        If tblComboList.Rows.Count = 0 Then
            MessageBox.Show("検索結果はゼロです", "検索結果", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            'MessageBox.Show("POSパターンを選択してください。", "SpreadNPC", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        '-------------------------------------------------------------------------------------------------------------------------
        ''btnのテキスト色を変更
        'btn選択.ForeColor = Color.Black
        'btn条件クリア.ForeColor = Color.Black

        ''btnの有効化
        btn選択.Enabled = True
        btn条件クリア.Enabled = True
    End Sub

    Private Sub btn選択_Click(sender As Object, e As EventArgs) Handles btn選択.Click
        Dim sfrm2 As New frm105商品登録_登録画面

        ''サブfrm2にcmbPOSパターンのTextを渡す（frm105商品登録_登録画面）
        sfrm2.strPosPtnName2 = cmbPOSパターン.Text
        sfrm2.ItemText2 = txt商品CD.Text
        '-------------------------------------------------------------------------------------------------------------------------

        Call sfrm2.ShowDialog()
    End Sub
    Private Sub btn条件クリア_Click(sender As Object, e As EventArgs) Handles btn条件クリア.Click
        Dim cDB As New clsDB
        Dim msSQL As String
        Dim tblComboList As New DataTable

        ''テーブルを結合して、dgv一覧の ｜部門｜検索カナ｜商品名｜ に表示
        msSQL = "Select 商品CD,b.部門名 As 部門,a.検索カナ,a.品目名 As 商品名 "
        msSQL += "From POS_MP品目 As a, POS_M部門 As b "
        msSQL += "Where a.部門CD = b.部門CD "
        msSQL += "Order By a.商品CD"

        mCommand = cDB.getsqlComand(msSQL)
        mSDA.SelectCommand = mCommand

        Call mSDA.Fill(tblComboList)

        dgv一覧.DataSource = tblComboList

        Call cDB.Close()
        '-------------------------------------------------------------------------------------------------------------------------
        cmb分類.SelectedIndex = 0
        cmb部門.SelectedIndex = 0
        txt検索カナ.Text = ""
        txtJANコード.Text = ""

        ''btnのテキスト色を変更
        'btn選択.ForeColor = Color.Gray
        'btn条件クリア.ForeColor = Color.Gray

        ''btnの無効化
        btn選択.Enabled = False
        btn条件クリア.Enabled = False

        ''dgvの内容をクリアする
        'dgv一覧.DataSource = ""

        ''btnの有効化
        btn選択.Enabled = True
        btn条件クリア.Enabled = True

    End Sub
    Private Sub btn閉じる_Click(sender As Object, e As EventArgs) Handles btn閉じる.Click
        Me.Close()
    End Sub
    Private Sub dgv一覧_SelectionChanged(sender As Object, e As EventArgs) Handles dgv一覧.SelectionChanged
        txt商品CD.Text = dgv一覧(0, dgv一覧.CurrentRow.Index).Value.ToString()

    End Sub
    Private Sub dgv一覧_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv一覧.CellContentDoubleClick
        Dim sfrm3 As New frm105商品登録_登録画面

        ''サブfrm3にcmbPOSパターンのTextを渡す（frm105商品登録_登録画面）
        sfrm3.strPosPtnName3 = cmbPOSパターン.Text
        sfrm3.ItemText3 = txt商品CD.Text
        '-------------------------------------------------------------------------------------------------------------------------
        'モーダルで表示
        Call sfrm3.ShowDialog()

    End Sub

End Class