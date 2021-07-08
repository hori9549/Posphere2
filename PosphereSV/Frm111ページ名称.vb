'20200509 堀内良幸
Imports System.Data.SqlClient

Public Class Frm111ページ名称
    Dim aryLblList(40) As Label
    Dim aryTxtList(40) As TextBox
    Dim mCommand As SqlCommand
    Dim mSDA As New SqlDataAdapter
    Dim DtblWork As New DataTable
    Dim cDB As New clsDB '★
    Dim CmbPosPtn As String
    Dim CmbPosId As String
    Dim InsertMode As Boolean = False
    Dim txtNum As Integer
    Dim SendSave As String
    Private Sub Frm111ページ名称_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ControlBox = Not Me.ControlBox

        ' ボタン１～42を配列で、
        aryLblList(0) = Lbl1
        aryLblList(1) = Lbl2
        aryLblList(2) = lbl3
        aryLblList(3) = lbl4
        aryLblList(4) = lbl5
        aryLblList(5) = lbl6
        aryLblList(6) = lbl7
        aryLblList(7) = lbl8
        aryLblList(8) = Lbl9
        aryLblList(9) = Lbl10
        aryLblList(10) = Lbl11
        aryLblList(11) = Lbl12
        aryLblList(12) = Lbl13
        aryLblList(13) = Lbl14
        aryLblList(14) = Lbl15
        aryLblList(15) = Lbl16
        aryLblList(16) = Lbl17
        aryLblList(17) = Lbl18
        aryLblList(18) = Lbl19
        aryLblList(19) = Lbl20
        aryLblList(20) = Lbl21
        aryLblList(21) = Lbl22
        aryLblList(22) = lbl23
        aryLblList(23) = Lbl24
        aryLblList(24) = Lbl25
        aryLblList(25) = Lbl26
        aryLblList(26) = Lbl27
        aryLblList(27) = lbl28
        aryLblList(28) = Lbl29
        aryLblList(29) = Lbl30
        aryLblList(30) = Lbl31
        aryLblList(31) = Lbl32
        aryLblList(32) = Lbl33
        aryLblList(33) = Lbl34
        aryLblList(34) = Lbl35
        aryLblList(35) = Lbl36
        aryLblList(36) = Lbl37
        aryLblList(37) = Lbl38
        aryLblList(38) = Lbl39
        aryLblList(39) = Lbl40
        'txt
        aryTxtList(0) = Txt1
        aryTxtList(1) = Txt2
        aryTxtList(2) = Txt3
        aryTxtList(3) = Txt4
        aryTxtList(4) = Txt5
        aryTxtList(5) = Txt6
        aryTxtList(6) = Txt7
        aryTxtList(7) = Txt8
        aryTxtList(8) = Txt9
        aryTxtList(9) = Txt10
        aryTxtList(10) = Txt11
        aryTxtList(11) = Txt12
        aryTxtList(12) = txt13
        aryTxtList(13) = Txt14
        aryTxtList(14) = Txt15
        aryTxtList(15) = Txt16
        aryTxtList(16) = Txt17
        aryTxtList(17) = Txt18
        aryTxtList(18) = Txt19
        aryTxtList(19) = Txt20
        aryTxtList(20) = Txt21
        aryTxtList(21) = Txt22
        aryTxtList(22) = Txt23
        aryTxtList(23) = Txt24
        aryTxtList(24) = Txt25
        aryTxtList(25) = Txt26
        aryTxtList(26) = Txt27
        aryTxtList(27) = Txt28
        aryTxtList(28) = Txt29
        aryTxtList(29) = Txt30
        aryTxtList(30) = Txt31
        aryTxtList(31) = Txt32
        aryTxtList(32) = Txt33
        aryTxtList(33) = Txt34
        aryTxtList(34) = Txt35
        aryTxtList(35) = Txt36
        aryTxtList(36) = Txt37
        aryTxtList(37) = Txt38
        aryTxtList(38) = Txt39
        aryTxtList(39) = Txt40
        '仮のFormをつくる
        Dim LabelHead As String = "ページ"
        Dim str As String
        For i = 0 To 39
            str = LabelHead & (i + 1).ToString
            aryLblList(i).Text = str
            aryLblList(i).Enabled = False

            aryTxtList(i).Text = str
            aryTxtList(i).Enabled = False
            aryTxtList(i).TabStop = False
        Next


        'CMBPOSにItemをSet
        Dim mssql As String
        Dim strTemp As String
        mssql = " SELECT POSパターン,パターン名称 "
        mssql += "FROM POS_MPOSパターン "
        mssql += "ORDER BY POSパターン"
        mCommand = cDB.getsqlComand(mssql) '★上の二行に対するおまじない
        mSDA.SelectCommand = mCommand
        Call mSDA.Fill(DtblWork) ''データセット作成
        'SQLで検索したデータ群のレコードを、1レコードずつ取り出す
        For nRowCounter As Integer = 0 To DtblWork.Rows.Count - 1
            strTemp = DtblWork.Rows(nRowCounter).Item("POSパターン").ToString()
            strTemp += " : "
            strTemp += DtblWork.Rows(nRowCounter).Item("パターン名称").ToString()
            '生成した文字列を「部門コンボボックス」に登録する
            CmbPos.Items.Add(strTemp)
        Next
        Btn更新.Enabled = False
        ActiveControl = Nothing
    End Sub
    Private Sub CmbPos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbPos.SelectedIndexChanged
        CmbPosPtn = DtblWork.Rows(CmbPos.SelectedIndex).Item("POSパターン").ToString
        CmbPosId = DtblWork.Rows(CmbPos.SelectedIndex).Item("パターン名称").ToString
        Dim mssql As String
        Dim DtblM頁 As New DataTable
        mssql = " SELECT * "
        mssql += "FROM POS_M頁 "
        mssql += "where POSパターン= "
        mssql += "'" + CmbPosPtn + "'"
        mssql += " And POS区分 = 1 "

        mCommand = cDB.getsqlComand(mssql) '★上の二行に対するおまじない
        mSDA.SelectCommand = mCommand
        Call mSDA.Fill(DtblM頁) 'POS_M頁のDataTable

        If DtblM頁.Rows.Count <= 0 Then  'POSにページの設定がないとき
            'Dim LabelHead As String = "ページ"    'デフォルト名　ページⅩ　をつける
            'For i = 0 To 39
            '    aryTxtList(i).Text = LabelHead & (i + 1).ToString
            '    aryTxtList(i).Enabled = True
            'Next
            InsertMode = True
            aryTxtList(0).Select()
        Else
            Dim ColNam As String
            For i = 0 To 39
                ColNam = DtblM頁.Columns(i + 2).ColumnName     ' ページ名は Col(2)
                aryTxtList(i).Text = DtblM頁.Rows(0).Item(ColNam)     ' Item名を「ColumnName」で取り出す
                aryTxtList(i).Enabled = True
            Next
            InsertMode = False
        End If
        Btn更新.Enabled = True
        ActiveControl = Label1     'フォーカスを外す
        ' aryTxtList(0).Select()
    End Sub
    Private Sub Btn更新_Click(sender As Object, e As EventArgs) Handles Btn更新.Click
        Dim cDB As New clsDB
        Dim msSQL As String
        Dim myTable As New DataTable
        Dim mSDA As New SqlDataAdapter

        If InsertMode = False Then

            'Updateモード
            Try
                'トランザクション開始
                Call cDB.BeginTransaction()
                '更新
                msSQL = "UPDATE POS_M頁 "
                msSQL += "SET "

                For nFldNo = 1 To 39
                    msSQL += "表示名" + nFldNo.ToString + " = '" + aryTxtList(nFldNo - 1).Text + "',"
                Next
                msSQL += "表示名40='" + aryTxtList(39).Text + "' "
                msSQL += " where POSパターン='" + CmbPosPtn + "'"
                msSQL += " and POS区分="
                msSQL += "'1'"


                mCommand = cDB.getsqlComand(msSQL)
                Call mCommand.ExecuteNonQuery()
                'コミット
                Call cDB.Commit()
                MessageBox.Show("正常に更新しました！", "'" + CmbPosId + "'")

            Catch ex As Exception
                'ロールバック
                Call cDB.Rollback()
                MessageBox.Show("更新に失敗しました！",
                                    "グループ登録")
            End Try
        Else  '追加
            msSQL = " insert into POS_M頁 values ("
            msSQL += "'" & CmbPosPtn & "',"   'POSパターン
            msSQL += cmbPos区分.Text     'POS区分
            For i = 0 To 39
                msSQL += ",'" & aryTxtList(i).Text & "'"
            Next
            msSQL += ")"

            mCommand = cDB.getsqlComand(msSQL)
            mSDA.SelectCommand = mCommand

            Call mSDA.Fill(myTable)


        End If
    End Sub

    Private Sub Btn終了_Click(sender As Object, e As EventArgs) Handles Btn終了.Click
        Me.Close()
    End Sub

    '!!!!!!!!!!!!!!!!!!!! MouseClickでText全選択　！！！！！！！！
    Private Sub Txt1_MouseClick(sender As Object, e As MouseEventArgs) Handles Txt1.MouseClick, Txt2.MouseClick, Txt3.MouseClick, Txt4.MouseClick,
            Txt5.MouseClick, Txt6.MouseClick, Txt7.MouseClick, Txt8.MouseClick, Txt9.MouseClick, Txt10.MouseClick,
            Txt11.MouseClick, Txt12.MouseClick, txt13.MouseClick, Txt14.MouseClick, Txt15.MouseClick, Txt16.MouseClick, Txt17.MouseClick, Txt18.MouseClick, Txt19.MouseClick, Txt20.MouseClick,
            Txt21.MouseClick, Txt22.MouseClick, Txt23.MouseClick, Txt24.MouseClick, Txt25.MouseClick, Txt26.MouseClick, Txt27.MouseClick, Txt28.MouseClick, Txt29.MouseClick, Txt30.MouseClick,
            Txt31.MouseClick, Txt32.MouseClick, Txt33.MouseClick, Txt34.MouseClick, Txt35.MouseClick, Txt36.MouseClick, Txt37.MouseClick, Txt38.MouseClick, Txt39.MouseClick, Txt40.MouseClick

        txtNum = getTxtNum(sender)

        SendSave = sender.text  '一時退避
        sender.SelectAll()
    End Sub

    '!!!!!!!!!!!!!!!!!!!! ENTERKEY でFocusを移動　！！！！！！！！
    Private Sub txt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt1.KeyPress, Txt2.KeyPress, Txt3.KeyPress, Txt4.KeyPress,
                 Txt5.KeyPress, Txt6.KeyPress, Txt7.KeyPress, Txt8.KeyPress, Txt9.KeyPress, Txt10.KeyPress,
            Txt11.KeyPress, Txt12.KeyPress, txt13.KeyPress, Txt14.KeyPress, Txt15.KeyPress, Txt16.KeyPress, Txt17.KeyPress, Txt18.KeyPress, Txt19.KeyPress, Txt20.KeyPress,
            Txt21.KeyPress, Txt22.KeyPress, Txt23.KeyPress, Txt24.KeyPress, Txt25.KeyPress, Txt26.KeyPress, Txt27.KeyPress, Txt28.KeyPress, Txt29.KeyPress, Txt30.KeyPress,
            Txt31.KeyPress, Txt32.KeyPress, Txt33.KeyPress, Txt34.KeyPress, Txt35.KeyPress, Txt36.KeyPress, Txt37.KeyPress, Txt38.KeyPress, Txt39.KeyPress, Txt40.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            Me.SelectNextControl(sender, True, True, True, True)
            e.Handled = True
            ActiveControl = Nothing
        Else
            If e.KeyChar = Chr(Keys.Escape) Then
                aryTxtList(txtNum - 1).Text = SendSave.ToString
                ActiveControl = Nothing
                ' Label1.Select()
                ' ActiveControl = txtDumy
            End If
        End If

    End Sub
    Private Function getTxtNum(txtX As TextBox) As Integer
        Dim txtNum As String = CType(txtX, TextBox).Name.Substring(3)
        Return txtNum
    End Function
End Class