'20200801 : 漆谷

'554行/588行 追加/更新の実行ができない（SQL分の作成は確認済み）
'ボタンの設定を削除（登録済みのレコードを削除）する方法は？
'692行 ※金額の決まり方が不明
'800行以降 設定値や取引CDの表示の条件が不明

Imports System.Data.SqlClient

Public Class frm110レジボタン設定

    Dim mCommand As SqlCommand
    Dim mSDA As New SqlDataAdapter
    Dim DtblCmbPos As New DataTable
    Dim DtblCmb機能 As New DataTable
    Dim DtblCmb取引 As New DataTable
    Dim DtblGet機能ボタン設定 As New DataTable
    Dim DtblGetボタン機能 As New DataTable
    Dim myTable As New DataTable

    Dim FlgPOSデータ読込 As Boolean = False

    Dim DtblBtnD追加 As New DataTable
    Dim DtblBtnD追加Index As Integer = -1
    Dim RowBtnD追加 As DataRow
    Dim DtblPagInf As New DataTable       'PageInfomation
    Dim CmbPosPtn As String = -1  'CMBボックスで選択された　”POSパターン”
    '	Dim CmbPosId As String   'CMBボックスで選択された　”POSパターン名称”
    Dim CmbBumonCD As String = "9999"   'CMB部門で選択された　”部門CD”
    Dim CmbBunruiCD As String = "9999"   'CMB分類で選択された　”分類CD”
    Dim msSQL As String  '★

    Dim aryBtnList(58) As Button
    Dim aryPbtnList(4) As Button
    Dim BtnPointer As String = -1    'ボタン番号0  =  musenntaku
    Dim BtnInfoSaveTxt As String = ""          'osareta ボタンの表示
    Dim BtnColor As String = 16777215       'ボタン色
    Dim 基本色 As String
    Dim 規定色 As String
    Dim Flag規定色あり As Boolean
    Dim PBLEN As String = 0   'ページボタン左端Pointer  PageBotonLeftEdgeNumber
    Dim SelPageNo As String = -1 '選択されたページ番号
    Dim PosPtn As String     'Posパターンの番号

    Dim selButton As Button
    Dim sndButton As String

    '------------------------------------------------
    '    DivRGB　　の本体
    '------------------------------------------------
    Private Sub DivRGB(ByVal InHex As String, ByRef P1 As Byte, ByRef P2 As Byte, ByRef P3 As Byte)
        Dim HexKasira As String = "&H"
        Select Case InHex.Length         'HexのLengthによる処理
            Case 1 To 2
                P3 = HexKasira & Mid(InHex, 1)
                P2 = "&H0"
                P1 = "&H0"
            Case 3
                P1 = "&H0"
                P2 = HexKasira & Mid(InHex, 1, 1)
                P3 = HexKasira & Mid(InHex, 2, 2)
            Case 4
                P1 = "&H0"
                P2 = HexKasira & Mid(InHex, 1, 2)
                P3 = HexKasira & Mid(InHex, 3, 2)
            Case 5
                P1 = HexKasira & Mid(InHex, 1, 1)
                P2 = HexKasira & Mid(InHex, 2, 2)
                P3 = HexKasira & Mid(InHex, 4, 2)
            Case 6
                P1 = HexKasira & Mid(InHex, 1, 2)
                P2 = HexKasira & Mid(InHex, 3, 2)
                P3 = HexKasira & Mid(InHex, 5, 2)
            Case Else
                P1 = "&Hff"
                P2 = "&Hff"
                P3 = "&Hff"
        End Select
    End Sub
    '----- DivRGB　ここまで-----------
    '------------------------------------------------
    '    ColorPNL　　の本体    パネルの中から色を選択
    '------------------------------------------------
    Private Sub ColorPNL(ByRef SelectedColor As String)
        Dim f As New Frm111レジメニュ設定_Colorサンプル
        Dim Result As System.Windows.Forms.DialogResult
        Result = f.ShowDialog()
        '  MessageBox.Show(Result.ToString() & "が選択されました。")
        If Result = DialogResult.OK Then
            SelectedColor = "a9a9a9"             'Btn1 = Gray  a9a9a9
            GoTo End処理
        End If
        If Result = DialogResult.Cancel Then   'BTN2 Dialog  Cancel
            SelectedColor = "add8e6"             'Btn2 = lightblue add8e6
            GoTo End処理
        End If
        If Result = DialogResult.Abort Then    'BTN3 Dialog abort
            SelectedColor = "ffff00"
            GoTo End処理
        End If
        SelectedColor = "ffc0cb"             'Btn4 = Pink ffc0cb
End処理:
        f.Dispose()
    End Sub
    '-------- ColorPNL ここまで------------------------

    Private Sub frm110レジボタン設定_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim cDB As New clsDB '★

        FlgPOSデータ読込 = False
        selButton = Nothing

        'ボタン5～58を配列にセット(1-5は不明のため欠番、5-8もボタンが不要になるので削除する？)
        aryBtnList(5) = btn5
        aryBtnList(6) = btn6
        aryBtnList(7) = btn7
        aryBtnList(8) = btn8
        aryBtnList(9) = btn9
        aryBtnList(10) = btn10
        aryBtnList(11) = btn11
        aryBtnList(12) = btn12
        aryBtnList(13) = btn13
        aryBtnList(14) = btn14
        aryBtnList(15) = btn15
        aryBtnList(16) = btn16
        aryBtnList(17) = btn17
        aryBtnList(18) = btn18
        aryBtnList(19) = btn19
        aryBtnList(20) = btn20
        aryBtnList(21) = btn21
        aryBtnList(22) = btn22
        aryBtnList(23) = btn23
        aryBtnList(24) = btn24
        aryBtnList(25) = btn25
        aryBtnList(26) = btn26
        aryBtnList(27) = btn27
        aryBtnList(28) = btn28
        aryBtnList(29) = btn29
        aryBtnList(30) = btn30
        aryBtnList(31) = btn31
        aryBtnList(32) = btn32
        aryBtnList(33) = btn33
        aryBtnList(34) = btn34
        aryBtnList(35) = btn35
        aryBtnList(36) = btn36
        aryBtnList(37) = btn37
        aryBtnList(38) = btn38
        aryBtnList(39) = btn39
        aryBtnList(40) = btn40
        aryBtnList(41) = btn41
        aryBtnList(42) = btn42
        aryBtnList(43) = btn43
        aryBtnList(44) = btn44
        aryBtnList(45) = btn45
        aryBtnList(46) = btn46
        aryBtnList(47) = btn47
        aryBtnList(48) = btn48
        aryBtnList(49) = btn49
        aryBtnList(50) = btn50
        aryBtnList(51) = btn51
        aryBtnList(52) = btn52
        aryBtnList(53) = btn53
        aryBtnList(54) = btn54
        aryBtnList(55) = btn55
        aryBtnList(56) = btn56
        aryBtnList(57) = btn57
        aryBtnList(58) = btn58

        'ボタンをアクティブにする
        For i = 9 To 58
            aryBtnList(i).Enabled = True
        Next i
        '
        lbl機能CD.Visible = False
        txt機能CD.Visible = False
        txt機能名.Visible = False
        cmb機能名.Visible = False
        cmbNO.Visible = False
        txt説明.Visible = False
        lbl表示名.Visible = False
        txt表示名.Visible = False
        lbl印刷名.Visible = False
        txt印刷名.Visible = False
        lblオプション.Visible = False
        txtオプション.Visible = False
        lbl単位.Visible = False
        lbl取引CD.Visible = False
        txt取引CD.Visible = False
        txt取引名.Visible = False
        lblイメージ.Visible = False
        btnイメージ.Visible = False
        btn更新.Visible = False
        btn取消.Visible = False
        btnキャンセル.Visible = False

        'DgvCmb部門Temp.DataSource = DtblCmb部門
        DtblCmb機能.Columns.Add("機能CD")
        DtblCmb機能.Columns.Add("機能名")
        DtblCmb機能.Columns.Add("説明")

        Dim rowCmb機能 As DataRow
        rowCmb機能 = DtblCmb機能.NewRow     '1行目のセット	
        rowCmb機能("機能CD") = "9999"
        rowCmb機能("機能名") = "全ての機能"
        rowCmb機能("説明") = "全ての説明"
        DtblCmb機能.Rows.Add(rowCmb機能)
        'CMB部門のITEMをセット
        msSQL = ""
        msSQL += "SELECT 機能CD, 機能名, 説明 "
        msSQL += "From POS_Mボタン機能 "
        msSQL += "Order By 機能CD"

        mCommand = cDB.getsqlComand(msSQL)  '★上の二行に対するおまじない
        mSDA.SelectCommand = mCommand

        Call mSDA.Fill(DtblCmb機能)   'データセット作成

        dgv機能CD一覧.DataSource = DtblCmb機能

        'DgvCmb取引.DataSource = DtblCmb取引
        DtblCmb取引.Columns.Add("取引CD")
        DtblCmb取引.Columns.Add("取引名")
        DtblCmb取引.Columns.Add("クーポン金額")

        Dim rowCmb取引 As DataRow
        rowCmb取引 = DtblCmb取引.NewRow     '1行目のセット	
        rowCmb取引("取引CD") = "9999"
        rowCmb取引("取引名") = "全ての機能"
        rowCmb取引("クーポン金額") = "全ての説明"
        DtblCmb取引.Rows.Add(rowCmb取引)

        msSQL = ""
        msSQL += "Select 取引CD,取引名,クーポン金額 "
        msSQL += "From POS_M取引 "
        msSQL += "ORDER BY 取引CD"

        mCommand = cDB.getsqlComand(msSQL)
        mSDA.SelectCommand = mCommand

        Call mSDA.Fill(DtblCmb取引)

        dgv取引CD一覧.DataSource = DtblCmb取引

        Dim strTemp As String
        msSQL = ""
        msSQL += "SELECT POSパターン,パターン名称 "
        msSQL += "FROM POS_MPOSパターン "
        msSQL += "ORDER BY POSパターン"
        mCommand = cDB.getsqlComand(msSQL) '★上の二行に対するおまじない
        mSDA.SelectCommand = mCommand
        Call mSDA.Fill(DtblCmbPos) ''データセット作成
        'SQLで検索したデータ群のレコードを、1レコードずつ取り出す

        For nRowCounter As Integer = 0 To DtblCmbPos.Rows.Count - 1
            strTemp = "" 'クリア（初期化：長さ０の文字列）する
            strTemp += DtblCmbPos.Rows(nRowCounter).Item("POSパターン").ToString()
            strTemp += " : "
            strTemp += DtblCmbPos.Rows(nRowCounter).Item("パターン名称").ToString()

            '生成した文字列を「CmbPosパターン」に登録する
            cmbposパターン.Items.Add(strTemp)
        Next

        '------------Btnデータ{DGV]のsakusei----------
        dgv取引.DataSource = DtblBtnD追加
        DtblBtnD追加.Columns.Add("ボタンNO")
        DtblBtnD追加.Columns.Add("部門CD")
        DtblBtnD追加.Columns.Add("JANCD")
        DtblBtnD追加.Columns.Add("項目名")
        DtblBtnD追加.Columns.Add("ボタン色")
        DtblBtnD追加.Columns.Add("UPorIN")

        'データグリッドビューは行で選択するようにする
        dgv機能CD一覧.ReadOnly = True
        dgv機能CD一覧.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        dgv取引CD一覧.ReadOnly = True
        dgv取引CD一覧.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        btn読込.Enabled = False
        btn5.Enabled = False
        btn6.Enabled = False
        btn7.Enabled = False
        btn8.Enabled = False
        btnキー設定.Enabled = False
        btn予備キー設定.Enabled = False

        'データ格納用のデータグリッドビューは非表示
        dgv取引.Visible = False
        DgvPagInf.Visible = False
        DataGrid1.Visible = False

        '初期化ボタンのレストランは非アクティブ
        btnレストラン前払.Enabled = False
        btnレストラン後払.Enabled = False

    End Sub

    Private Sub btn終了_Click(sender As Object, e As EventArgs) Handles btn終了.Click
        Me.Close()

    End Sub

    Private Sub btn読込_Click(sender As Object, e As EventArgs) Handles btn読込.Click

        FlgPOSデータ読込 = True
        Call MenuRead()

        btnキー設定.Enabled = True

    End Sub

    Private Sub MenuRead()

        Dim cDB As New clsDB '★

        DtblPagInf.Rows.Clear()
        DgvPagInf.DataSource = Nothing
        DtblBtnD追加.Rows.Clear()
        dgv取引.DataSource = Nothing
        DtblBtnD追加Index = 0    '書込みData用TableのIndexを初期化

        'Call BtnClear()

        msSQL = " "
        msSQL += " Select * From POS_M機能ボタン設定 "
        'msSQL += " inner join POS_Mposパターン "
        'msSQL += " On POS_M機能ボタン設定.posパターン= POS_Mposパターン.posパターン"
        msSQL += " where POS_M機能ボタン設定.POSパターン= " + CmbPosPtn
        'msSQL += " and POS_M機能ボタン設定.機能CD =  "
        msSQL += " and POS_M機能ボタン設定.POS区分 = '1' "
        msSQL += " order by POS_M機能ボタン設定.ボタンNO"
        mCommand = cDB.getsqlComand(msSQL)
        mSDA.SelectCommand = mCommand

        Call mSDA.Fill(DtblPagInf)        ''データセット作成
        'dgv取引.DataSource = DtblCmb取引

        Dim p1 As Byte
        Dim p2 As Byte
        Dim p3 As Byte
        '変数の宣言とデータのセット
        Dim intBtnNum As Integer
        Dim Inhex As String
        Dim Intcolor As String
        '16進数に変換する
        For j = 0 To aryBtnList.Length - 1 - 1
            For i = 0 To DtblPagInf.Rows.Count - 1
                intBtnNum = DtblPagInf.Rows(i).Item("ボタンNO")
                If intBtnNum = j Then
                    Intcolor = DtblPagInf.Rows(i).Item("ボタン色").ToString
                    aryBtnList(intBtnNum).Text = DtblPagInf.Rows(i).Item("表示名").ToString
                    Inhex = Hex(Intcolor)
                    Call DivRGB(Inhex, p1, p2, p3)
                    aryBtnList(intBtnNum).BackColor = Color.FromArgb(p1, p2, p3)       'ボタンに色付け
                    Exit For
                End If
            Next
        Next

    End Sub

    Private Sub cmbposパターン_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbposパターン.SelectedIndexChanged
        CmbPosPtn = DtblCmbPos.Rows(cmbposパターン.SelectedIndex).Item("POSパターン").ToString

        'SelPageNo = -1
        'PosPtn = cmbposパターン.Text.Substring(0, 1)

        btn読込.Enabled = True


    End Sub

    Private Sub btn物販_Click(sender As Object, e As EventArgs) Handles btn物販.Click

        'メッセージボックスを表示する 
        Dim result As DialogResult = MessageBox.Show("パネルの状態がすべて出荷時設定に戻ります。",
                                             "よろしいですか？",
                                             MessageBoxButtons.OKCancel,
                                             MessageBoxIcon.Exclamation,
                                             MessageBoxDefaultButton.Button2)

        '何が選択されたか調べる 
        If result = DialogResult.Yes Then
            '「はい」が選択された時 


        ElseIf result = DialogResult.Cancel Then
            '「キャンセル」が選択された時 

        End If
    End Sub

    Private Sub btnレストラン前払_Click(sender As Object, e As EventArgs) Handles btnレストラン前払.Click

        'メッセージボックスを表示する 
        Dim result As DialogResult = MessageBox.Show("パネルの状態がすべて出荷時設定に戻ります。",
                                             "よろしいですか？",
                                             MessageBoxButtons.OKCancel,
                                             MessageBoxIcon.Exclamation,
                                             MessageBoxDefaultButton.Button2)

        '何が選択されたか調べる 
        If result = DialogResult.Yes Then
            '「はい」が選択された時 


        ElseIf result = DialogResult.Cancel Then
            '「キャンセル」が選択された時 

        End If

    End Sub

    Private Sub btnレストラン後払_Click(sender As Object, e As EventArgs) Handles btnレストラン後払.Click

        'メッセージボックスを表示する 
        Dim result As DialogResult = MessageBox.Show("パネルの状態がすべて出荷時設定に戻ります。",
                                             "よろしいですか？",
                                             MessageBoxButtons.OKCancel,
                                             MessageBoxIcon.Exclamation,
                                             MessageBoxDefaultButton.Button2)

        '何が選択されたか調べる 
        If result = DialogResult.Yes Then
            '「はい」が選択された時 


        ElseIf result = DialogResult.Cancel Then
            '「キャンセル」が選択された時 

        End If


    End Sub

    Private Sub btn1_1_Click(sender As Object, e As EventArgs)

        BtnPointer = 1
        Dim BtnXindex As Integer
        Call UPDINF(BtnXindex)

    End Sub

    Private Sub UPDINF(ByRef BtnXindex As String)    '入力中のRecがあるか
        If SelPageNo <= 0 Then
            MsgBox("最初にPAGEを選択して")
            Exit Sub
        End If
        DtblBtnD追加.Rows.Add()
        DtblBtnD追加Index = DtblBtnD追加Index + 1
        '  Call Menu項目クリア()
        For i = 0 To DtblPagInf.Rows.Count - 1
            If BtnPointer = DtblPagInf.Rows(i).Item("ボタンNO") Then
                BtnXindex = i.ToString
                GoTo Mitsuketa
            End If
        Next
        BtnXindex = -1                          ' BtnXindex のRowインデックス
        DtblBtnD追加(DtblBtnD追加Index - 1).Item("ボタンNO") = BtnPointer.ToString
        DtblBtnD追加(DtblBtnD追加Index - 1).Item("UPorIN") = "" 'Btn番号のみ書き込みはまだ未完成状態
        dgv取引.DataSource = DtblBtnD追加                   'DGV後で消す＃＃＃＃＃
        Exit Sub
Mitsuketa:
        DtblBtnD追加(DtblBtnD追加Index - 1).Item("ボタンNO") = DtblPagInf.Rows(BtnXindex).Item("ボタンNO")
        'DtblBtnD追加(DtblBtnD追加Index - 1).Item("部門CD") = DtblPagInf.Rows(BtnXindex).Item("部門CD")
        'DtblBtnD追加(DtblBtnD追加Index - 1).Item("JANCD") = DtblPagInf.Rows(BtnXindex).Item("JANCD")
        DtblBtnD追加(DtblBtnD追加Index - 1).Item("項目名") = DtblPagInf.Rows(BtnXindex).Item("表示名")
        DtblBtnD追加(DtblBtnD追加Index - 1).Item("ボタン色") = DtblPagInf.Rows(BtnXindex).Item("ボタン色")
        DtblBtnD追加(DtblBtnD追加Index - 1).Item("UPorIN") = "U"
        dgv取引.DataSource = DtblBtnD追加                   'DGV後で消す＃＃＃＃＃
    End Sub

    Private Sub btn_Click(sender As Object, e As EventArgs) Handles _
            btn9.Click, btn10.Click, btn11.Click, btn12.Click, btn13.Click,
            btn14.Click, btn15.Click, btn16.Click, btn17.Click, btn18.Click,
            btn19.Click, btn20.Click, btn21.Click, btn22.Click, btn23.Click,
            btn24.Click, btn25.Click, btn26.Click, btn27.Click, btn28.Click,
            btn29.Click, btn30.Click, btn31.Click, btn32.Click, btn33.Click,
            btn34.Click, btn35.Click, btn36.Click, btn37.Click, btn38.Click,
            btn39.Click, btn40.Click, btn41.Click, btn42.Click, btn43.Click,
            btn44.Click, btn45.Click, btn46.Click, btn47.Click, btn48.Click,
            btn49.Click, btn50.Click, btn51.Click, btn52.Click, btn53.Click,
            btn54.Click, btn55.Click, btn56.Click, btn57.Click, btn58.Click

        If FlgPOSデータ読込 = False Then

            MessageBox.Show("POSデータを読み込んでください。")

        Else

            selButton = sender
            Call ボタン情報取得(selButton)

            '選択したボタン以外は選択できなくする
            For i = 9 To 58
                aryBtnList(i).Enabled = False
            Next i
            sender.Enabled = True

        End If





    End Sub

    Private Sub btn更新_Click(sender As Object, e As EventArgs) Handles btn更新.Click

        '選択したボタンの情報レコードがデータベースに存在するか確認
        If DtblGet機能ボタン設定.Rows.Count = 0 Then
            'レコードが存在しない場合はINSERT
            Call ボタン情報追加(selButton)
        Else
            'レコードが存在する場合はUPDATE
            Call ボタン情報更新(selButton)
        End If

    End Sub


    Private Sub ボタン情報追加(setButton As Button)

        Dim cDB As New clsDB '★

        Dim getColor As Color
        Dim strColor As String
        Dim num16Color As Integer

        msSQL = ""
        msSQL += " INSERT INTO POS_M機能ボタン設定 "
        msSQL += "( POSパターン"
        msSQL += ", POS区分"
        msSQL += ", ボタンNO"
        msSQL += ", 機能CD"
        msSQL += ", 表示名"
        msSQL += ", 印刷名"
        msSQL += ", ボタン色"
        msSQL += ", 金額"
        msSQL += ", パーセント"
        msSQL += ", 業務種別"
        msSQL += ", NO"
        msSQL += ", 取引CD"
        msSQL += " ) "
        msSQL += " VALUES "
        msSQL += "(" + CmbPosPtn
        msSQL += "," + "1" 'POS区分
        msSQL += "," + sndButton.ToString.Substring(3)
        msSQL += "," + txt機能CD.Text
        msSQL += ",'" + txt表示名.Text + "'"
        msSQL += ",'" + txt印刷名.Text + "'"

        getColor = btnイメージ.BackColor
        'Colorデータを色名称でも
        strColor = String.Format("{0:X2}{1:X2}{2:X2}", getColor.R, getColor.G, getColor.B)
        'ボタンの背景色を16進数から10進数に変換して格納
        num16Color = Convert.ToInt32(strColor.Substring(0), 16)

        msSQL += ",'" + num16Color.ToString + "'"
        msSQL += "," + "0" '金額
        msSQL += ",'" + txt印刷名.Text + "'"
        msSQL += ",'" + txt印刷名.Text + "'"
        msSQL += ",'" + cmbNO.Text + "'"
        msSQL += ",'" + txt取引CD.Text + "'"
        msSQL += " ) "

        cDB.BeginTransaction()

        Try
            'mCommand = cDB.getsqlComand(msSQL)
            'mSDA.SelectCommand = mCommand

            mCommand = cDB.getsqlComand(msSQL)
            mSDA.SelectCommand = mCommand
            Call mSDA.Fill(myTable)

            cDB.Commit()
            Call cDB.Close()

        Catch ex As Exception
            cDB.Rollback()
            cDB.Close()
            MessageBox.Show("登録に失敗しました。「" + msSQL + "」" + vbCrLf + ex.ToString,
                            "Informarmation",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        End Try

    End Sub
    Private Sub ボタン情報更新(setButton As Button)

        Dim cDB As New clsDB '★
        Dim getColor As Color
        Dim strColor As String
        Dim num16Color As Integer

        msSQL = ""
        msSQL += " UPDATE POS_M機能ボタン設定 "
        msSQL += " SET 機能CD = '" + txt機能CD.Text + "' "
        msSQL += "    ,表示名 = '" + txt表示名.Text + "' "
        msSQL += "    ,印刷名 = '" + txt印刷名.Text + "' "

        getColor = btnイメージ.BackColor
        'Colorデータを色名称でも
        strColor = String.Format("{0:X2}{1:X2}{2:X2}", getColor.R, getColor.G, getColor.B)
        'ボタンの背景色を16進数から10進数に変換して格納
        num16Color = Convert.ToInt32(strColor.Substring(0), 16)

        msSQL += "    ,ボタン色 = '" + num16Color.ToString + "'"

        '※金額の決まり方が不明(取引CDから取得？)
        msSQL += "    ,金額 = 0 "
        msSQL += "    ,パーセント = '" + txt印刷名.Text + "' "
        msSQL += "    ,業務種別 = '" + txt印刷名.Text + "' "
        msSQL += "    ,NO = '" + cmbNO.Text + "' "
        msSQL += "    ,取引CD = '" + txt取引CD.Text + "' "
        msSQL += " where POSパターン = " + CmbPosPtn + " "
        msSQL += " and POS区分 = 1 "
        msSQL += " and ボタンNO = " + sndButton.ToString.Substring(3) + " "

        cDB.BeginTransaction()

        Try
            'mCommand = cDB.getsqlComand(msSQL)
            'mSDA.SelectCommand = mCommand

            mCommand = cDB.getsqlComand(msSQL)
            mSDA.SelectCommand = mCommand
            Call mSDA.Fill(myTable)

            cDB.Commit()
            Call cDB.Close()

        Catch ex As Exception
            cDB.Rollback()
            cDB.Close()
            MessageBox.Show("登録に失敗しました。「" + msSQL + "」" + vbCrLf + ex.ToString,
                            "Informarmation",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btn取消_Click(sender As Object, e As EventArgs) Handles btn取消.Click

        Call ボタン情報取得(selButton)

    End Sub

    Private Sub btnキャンセル_Click(sender As Object, e As EventArgs) Handles btnキャンセル.Click

        'ボタン設定の入力欄を非表示にする
        lbl機能CD.Visible = False
        txt機能CD.Visible = False
        txt機能CD.Text = ""
        txt機能名.Visible = False
        txt機能名.Text = ""
        cmb機能名.Visible = False
        cmb機能名.Text = ""
        cmbNO.Visible = False
        cmbNO.Text = ""
        txt説明.Visible = False
        txt説明.Text = ""
        lbl表示名.Visible = False
        txt表示名.Visible = False
        txt表示名.Text = ""
        lbl印刷名.Visible = False
        txt印刷名.Visible = False
        txt印刷名.Text = ""
        lblオプション.Visible = False
        txtオプション.Visible = False
        txtオプション.Text = ""
        lbl取引CD.Visible = False
        txt取引CD.Visible = False
        txt取引CD.Text = ""
        txt取引名.Visible = False
        txt取引名.Text = ""
        lblイメージ.Visible = False
        btnイメージ.Visible = False
        btn更新.Visible = False
        btn取消.Visible = False
        btnキャンセル.Visible = False

        'ボタンをアクティブにする
        For i = 9 To 58
            aryBtnList(i).Enabled = True
        Next i

    End Sub

    Private Sub btnイメージ_Click(sender As Object, e As EventArgs) Handles btnイメージ.Click

        'ボタンの背景色をダイアログで選択
        Dim cd As New ColorDialog()

        'はじめに選択されている色を設定
        cd.Color = btnイメージ.BackColor
        '色の作成部分を表示可能にする
        'デフォルトがTrueのため必要はない
        cd.AllowFullOpen = True
        '純色だけに制限しない
        'デフォルトがFalseのため必要はない
        cd.SolidColorOnly = False
        '[作成した色]に指定した色（RGB値）を表示する
        cd.CustomColors = New Integer() {&H33, &H66, &H99,
            &HCC, &H3300, &H3333, &H3366, &H3399, &H33CC,
            &H6600, &H6633, &H6666, &H6699, &H66CC,
            &H9900, &H9933}

        'ダイアログを表示する
        If cd.ShowDialog() = DialogResult.OK Then
            '選択された色の取得
            btnイメージ.BackColor = cd.Color
        End If

    End Sub

    Private Sub dgv機能CD一覧_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgv機能CD一覧.CellMouseClick

        txt機能CD.Text = dgv機能CD一覧.SelectedRows(0).Cells(0).Value
        txt機能名.Text = dgv機能CD一覧.SelectedRows(0).Cells(1).Value
        txt説明.Text = dgv機能CD一覧.SelectedRows(0).Cells(2).Value
    End Sub

    Private Sub dgv取引CD一覧_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgv取引CD一覧.CellMouseClick

        txt取引CD.Text = dgv取引CD一覧.SelectedRows(0).Cells(0).Value
        txt取引名.Text = dgv取引CD一覧.SelectedRows(0).Cells(1).Value

    End Sub

    Private Sub ボタン情報取得(setButton As Button)

        Dim cDB As New clsDB '★

        sndButton = CType(setButton, Button).Name

        '入力欄を初期化
        txt機能CD.Text = ""
        txt機能名.Text = ""
        txt説明.Text = ""
        txt表示名.Text = ""
        txt印刷名.Text = ""
        txtオプション.Text = ""
        btnイメージ.Text = ""
        lblオプション.Text = ""
        lbl単位.Text = ""
        cmb機能名.Text = ""
        cmbNO.Text = ""

        Try

            '選択したボタンの情報をデータベースから取得
            DtblGet機能ボタン設定.Rows.Clear()
            msSQL = ""
            msSQL += " SELECT POSパターン"
            msSQL += " ,POS区分"
            msSQL += " ,ボタンNO"
            msSQL += " ,機能CD"
            msSQL += " ,表示名"
            msSQL += " ,印刷名"
            msSQL += " ,ボタン色"
            msSQL += " ,金額"
            msSQL += " ,パーセント"
            msSQL += " ,業務種別"
            msSQL += " ,NO"
            msSQL += " ,取引CD "
            msSQL += " From POS_M機能ボタン設定 "
            msSQL += " where POSパターン = " + CmbPosPtn + " "
            msSQL += " and POS区分 = 1 "
            msSQL += " and ボタンNO = " + sndButton.ToString.Substring(3) + " "
            msSQL += " Order By ボタンNO "

            mCommand = cDB.getsqlComand(msSQL)
            mSDA.SelectCommand = mCommand

            Call mSDA.Fill(DtblGet機能ボタン設定)   'データセット作成

            '選択したボタンの情報をデータベースから取得
            DtblGetボタン機能.Rows.Clear()
            msSQL = ""
            msSQL += " SELECT 機能CD, 機能名, 印刷名, 説明, ボタン色 "
            msSQL += " From POS_Mボタン機能 "
            msSQL += " where 機能CD = " + DtblGet機能ボタン設定.Rows(0).Item("機能CD").ToString + " "
            msSQL += " Order By 機能CD "

            mCommand = cDB.getsqlComand(msSQL)
            mSDA.SelectCommand = mCommand

            Call mSDA.Fill(DtblGetボタン機能)   'データセット作成

            lbl機能CD.Visible = True
            txt機能CD.Visible = True
            txt機能名.Visible = True
            txt説明.Visible = True
            lbl表示名.Visible = True
            txt表示名.Visible = True
            lbl印刷名.Visible = True
            txt印刷名.Visible = True
            lbl取引CD.Visible = True
            txt取引CD.Visible = True
            txt取引名.Visible = True
            lblイメージ.Visible = True
            btnイメージ.Visible = True
            btn更新.Visible = True
            btn取消.Visible = True
            btnキャンセル.Visible = True

            txt機能CD.Text = DtblGet機能ボタン設定.Rows(0).Item("機能CD")
            txt機能名.Text = DtblGetボタン機能.Rows(0).Item("機能名")
            txt説明.Text = DtblGetボタン機能.Rows(0).Item("説明")
            txt表示名.Text = DtblGet機能ボタン設定.Rows(0).Item("表示名")
            txt印刷名.Text = DtblGet機能ボタン設定.Rows(0).Item("印刷名")

            '更新するボタンのサンプルイメージの設定
            '変数の宣言
            Dim p1 As Byte
            Dim p2 As Byte
            Dim p3 As Byte
            Dim Inhex As String
            Dim Intcolor As String

            'データのセット
            Intcolor = DtblGet機能ボタン設定.Rows(0).Item("ボタン色").ToString
            btnイメージ.Text = DtblGet機能ボタン設定.Rows(0).Item("表示名").ToString

            '16進数に変換する
            Inhex = Hex(Intcolor)
            Call DivRGB(Inhex, p1, p2, p3)
            btnイメージ.BackColor = Color.FromArgb(p1, p2, p3)       'ボタンに色付け

        Catch ex As Exception

            lbl機能CD.Visible = True
            txt機能CD.Visible = True
            txt機能名.Visible = True
            txt説明.Visible = True
            lbl表示名.Visible = True
            txt表示名.Visible = True
            lbl印刷名.Visible = True
            txt印刷名.Visible = True
            lbl取引CD.Visible = True
            txt取引CD.Visible = True
            txt取引名.Visible = True
            lblイメージ.Visible = True
            btnイメージ.Visible = True
            btn更新.Visible = True
            btn取消.Visible = True
            btnキャンセル.Visible = True

        End Try

        Select Case txt機能CD.Text

                'Case "100" '割込
                'Case "200" '一括取消
                'Case "201" '指定取消
                'Case "300" '返品
                'Case "400" '入金
                'Case "410" '釣銭準備
                'Case "451" '釣銭回収
                'Case "452" '出金
                'Case "500" 'JAN
                'Case "501" '単価変更
                'Case "502" '数量変更
                'Case "503" 'リピート
            Case "630" '客層
                lblオプション.Visible = True
                txtオプション.Visible = True
                lblオプション.Text = "設定値"
                txtオプション.Text = DtblGet機能ボタン設定.Rows(0).Item("パーセント")


            Case "631" '客層2
                lblオプション.Visible = True
                txtオプション.Visible = True
                lblオプション.Text = "設定値"

            Case "650" '担当
                lblオプション.Visible = True
                txtオプション.Visible = True
                lblオプション.Text = "設定値"

                'Case "660" '係り
                'Case "670" 'ﾃｰﾌﾞﾙ 精算
                'Case "680" '伝票精算
            Case "700" '値引
                lblオプション.Visible = True
                txtオプション.Visible = True
                lblオプション.Text = "値引率"
                lbl単位.Visible = True
                lbl単位.Text = "円"

            Case "750" '-%
                lblオプション.Visible = True
                txtオプション.Visible = True
                lblオプション.Text = "割引率"
                lbl単位.Visible = True
                lbl単位.Text = "％"

            Case "760" '奉仕料
                lblオプション.Visible = True
                txtオプション.Visible = True
                lblオプション.Text = "料率"
                lbl単位.Visible = True
                lbl単位.Text = "円"

                'Case "800" '領収
                'Case "801" '両替
                'Case "802" '釣銭状態
                'Case "803" '棒金OPEN
                'Case "804" '全回収
                'Case "810" '万円預り
                'Case "811" '千円預り
                'Case "820" '小計
            Case "830" '信計1

                cmb機能名.Visible = False
                cmbNO.Visible = False
                txt取引CD.Text = DtblGet機能ボタン設定.Rows(0).Item("取引CD")

            Case "831" '信計2
            Case "832" '信計3
            Case "833" '信計4
            Case "840" 'II計釣有
                lblオプション.Visible = True
                txtオプション.Visible = True
                lblオプション.Text = "設定額"
                lbl単位.Visible = True
                lbl単位.Text = "円"

            Case "841" 'II計釣無
                lblオプション.Visible = True
                txtオプション.Visible = True
                lblオプション.Text = "設定額"
                lbl単位.Visible = True
                lbl単位.Text = "円"

                'Case "842" 'II計ｸｰﾎﾟﾝ
                'Case "850" '貸計
                'Case "860" '現／預
                'Case "900" '＃
                'Case "910" '人数
                'Case "920" 'ﾚｼｰﾄ 訂正
                'Case "930" 'ﾚｼｰﾄ 停止
                'Case "931" '宣伝停止
                'Case "932" 'INFOX OFF
                'Case "933" 'ＴＯ開始
                'Case "940" 'ﾚｼｰﾄ 後出
                'Case "941" '直前ﾚｼｰﾄ
                'Case "950" '個別会計
                'Case "960" '割勘計算
                'Case "970" 'ﾃｰﾌﾞﾙ 状態
                'Case "996" '予備キー3
                'Case "997" '予備キー1
                'Case "998" '予備キー2
                'Case "999" '操作キー

            Case Else
                cmb機能名.Visible = False
                cmbNO.Visible = False
                lblオプション.Visible = False
                txtオプション.Visible = False
                lbl単位.Visible = False
        End Select

    End Sub




    Private Sub txt表示名_TextChanged(sender As Object, e As EventArgs) Handles txt表示名.TextChanged

        btnイメージ.Text = txt表示名.Text

    End Sub

    Private Sub btnキー設定_Click(sender As Object, e As EventArgs) Handles btnキー設定.Click

        Dim frmキーボード設定 As New frm110レジボタン設定_キーボード設定

        frmキーボード設定.lblPOSパターン.Text = CmbPosPtn
        frmキーボード設定.ShowDialog()

    End Sub


End Class
