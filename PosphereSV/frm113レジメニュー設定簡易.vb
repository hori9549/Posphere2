'20200516 堀内良幸
'簡易版に画面改造

Imports System.Data.SqlClient

Public Class frm113レジメニュー設定簡易
    Private mCommand As SqlCommand
    Private mSDA As New SqlDataAdapter
    Private DivHex As New clsHtools   'インスタンスの作成

    Dim tblCMBlist As New DataTable
    Dim DtblCmb部門 As New DataTable
    Dim DtblCmb分類 As New DataTable
    Dim DtblM頁 As New DataTable
    Dim DtblBtnD追加 As New DataTable
    Dim Dtbl_M頁 As New DataTable

    Dim DtblBtnD追加Index As Integer = -1
    Dim RowBtnD追加 As DataRow
    Dim DtblWork2 As New DataTable
    Dim Dtbl商品名list As New DataTable  '★
    Dim Dtbl部門list As New DataTable   '★
    Dim CmbPosPtn As String = -1  'CMBボックスで選択された　”POSパターン”
    Dim CmbPosName As String   'CMBボックスで選択された　”POSパターン名称”
    Dim PosKubun As String = 1    ' Pos区分の役割がはっきりするまで='１'に固定

    Dim CmbBumonCD As String = "全ての部門"   'CMB部門で選択された　”部門CD”
    Dim CmbBunruiCD As String = "全ての分類"   'CMB分類で選択された　”分類CD”

    Dim msSQL As String  '★
    Dim cDB As New clsDB '★
    Dim aryBtnList(42) As Button
    Dim aryPbtnList(8) As Button
    Dim BtnPointer As String = -1    'ボタン番号0  =  musenntaku
    Dim BtnColor As String = 16777215       'ボタン色
    Dim 基本色 As String = "DCDCDC"    'Defolt色は　グレー(DCDCDC)
    Dim 規定色 As String
    Dim Defolt色 As String = "DCDCDC"    'Defolt色は　グレー'14474460'(DCDCDC)
    Dim PBLEN As String = 0   'ページボタン左端Pointer  PageBotonLeftEdgeNumber
    Dim SelPageNo As String = -1 '選択されたページ番号
    Dim DtblPagInf As DataTable
    Dim ModeIs部門を割付 As Boolean = False          'ModeIs部門を割付?   L=285あたり参照
    Dim BtnLockStatus As Integer = 0
    Dim contNam As String     'Control "Name"をSave
    Dim sendSav As String     'sender の内容をSave

    Private Sub frm113レジメニュー設定簡易_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ControlBox = Not Me.ControlBox

        ' ボタン１～42を配列で、
        aryBtnList(0) = btn1
        aryBtnList(1) = btn2
        aryBtnList(2) = btn3
        aryBtnList(3) = btn4
        aryBtnList(4) = btn5
        aryBtnList(5) = btn6
        aryBtnList(6) = btn7
        aryBtnList(7) = btn8
        aryBtnList(8) = btn9
        aryBtnList(9) = btn10
        aryBtnList(10) = btn11
        aryBtnList(11) = btn12
        aryBtnList(12) = btn13
        aryBtnList(13) = btn14
        aryBtnList(14) = btn15
        aryBtnList(15) = btn16
        aryBtnList(16) = btn17
        aryBtnList(17) = btn18
        aryBtnList(18) = btn19
        aryBtnList(19) = btn20
        aryBtnList(20) = btn21
        aryBtnList(21) = btn22
        aryBtnList(22) = btn23
        aryBtnList(23) = btn24
        aryBtnList(24) = btn25
        aryBtnList(25) = btn26
        aryBtnList(26) = btn27
        aryBtnList(27) = btn28
        aryBtnList(28) = btn29
        aryBtnList(29) = btn30
        aryBtnList(30) = btn31
        aryBtnList(31) = btn32
        aryBtnList(32) = btn33
        aryBtnList(33) = btn34
        aryBtnList(34) = btn35
        aryBtnList(35) = btn36
        aryBtnList(36) = btn37
        aryBtnList(37) = btn38
        aryBtnList(38) = btn39
        aryBtnList(39) = btn40
        aryBtnList(40) = btn41
        aryBtnList(41) = btn42

        ' ページボタン１～８を配列で、
        aryPbtnList(0) = btnページ１
        aryPbtnList(1) = btnページ２
        aryPbtnList(2) = btnページ３
        aryPbtnList(3) = btnページ４

        '---------------------------------------------
        'CmbPosコンボボックスに登録する文字列を生成
        '---------------------------------------------
        Call SetCmbPos(cmbPOS)
        cmbPOS.ItemHeight = 50
        '---------------------------------------------
        '部門コンボボックスに登録する文字列を生成 & DTBL部門の作成
        '---------------------------------------------
        Call SetCmb部門(cmb部門)
        '---------------------------------------------
        '分類コンボボックスに登録する文字列を生成 & DTBL分類の作成
        '---------------------------------------------
        Call SetCmb分類(cmb分類)

        lblPOSパターン選択.Text = "POSパターンを選択して下さい"
        lblPOSパターン選択.ForeColor = Color.Black

        '------------　BtnD追加　{列]の作成　----------
        DtblBtnD追加.Columns.Add("ボタンNO")
        DtblBtnD追加.Columns.Add("部門CD")
        DtblBtnD追加.Columns.Add("JANCD")
        DtblBtnD追加.Columns.Add("ボタン色")
        DtblBtnD追加.Columns.Add("項目名")      ' b.[ボタン表示名]
        DtblBtnD追加.Columns.Add("UPorIN")
        DtblBtnD追加.Columns.Add("MEorBU")      'Menyu?  Bumonn?

        btn読込.Enabled = False

        Call MenuRead()    '左右のDGVを読み込む
        Call BumonnRead()

        BtnLockStatus = BtnLockStatus + 1
        Call UpperBtnNot(BtnLockStatus)           'Upper Bottons　早戻しボタン等　を　Lock
        Call PageBtnGroupeNot(BtnLockStatus)      'Page1～8　早戻しボタン等　を　Lock

        'ProgressBar1.Visible = False   'プログレスバーを隠す
        '       LblProgBar.Visible = False
        grp基本色.Enabled = False
        '  grp検索.Enabled = False
        grpメニュー選択.Enabled = False
        dgv商品名.Enabled = False
        dgv部門.Enabled = False
        btn取消.Enabled = False

        Me.ActiveControl = Me.cmbPOS
        cDB.Close()

    End Sub


    Private Sub cmbPOS_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPOS.SelectedIndexChanged
        CmbPosPtn = cmbPOS.SelectedValue.ToString()
        If CmbPosPtn = 0 Then Exit Sub

        Dim cDB As New clsDB
        Dim getSQL As String
        Dim myTable As New DataTable

        ''　パターン名称　検索SQL======================================================
        getSQL = "SELECT パターン名称"
        getSQL += " FROM POS_MPOSパターン"
        getSQL += " where posパターン= "
        getSQL += CmbPosPtn

        mCommand = cDB.getsqlComand(getSQL)
        mSDA.SelectCommand = mCommand

        Call mSDA.Fill(myTable)
        CmbPosName = myTable.Rows(0).Item("パターン名称").ToString
        lblPOSパターン選択.Text = "設定したいメニューボタンを選択してください。"
        lblPOSパターン選択.ForeColor = Color.Red

        PBLEN = 0
        SelPageNo = 1      '1ページから始める

        aryPbtnList(0).FlatStyle = FlatStyle.Popup
        btn読込.Enabled = True
        lblPOSパターン選択.Select()
    End Sub

    Sub UpperBtnNot(ByVal kaisu As Integer)  '＝＝＝＝　Upper Bottons　早戻しボタン等　を　Lock,unlock　＝＝＝＝
        If kaisu <= 2 Then       'Lock,UnLockで動作終了
            btn基本色.Enabled = Not btn基本色.Enabled
            chk基本色.Enabled = Not chk基本色.Enabled
            btnページ名称.Enabled = Not btnページ名称.Enabled
            btn更新.Enabled = Not btn更新.Enabled
            btnコピー.Enabled = Not btnコピー.Enabled
            btnキャンセル.Enabled = Not btnキャンセル.Enabled

        End If
    End Sub
    '＝＝＝＝　Page1～4　早戻しボタン等　を　Lock　＝＝＝＝
    Sub PageBtnGroupeNot(ByVal kaisu As Integer)        'Page1～4　早戻しボタン等　を　Lock
        If kaisu <= 2 Then       'Lock,UnLockで動作終了
            btn戻し.Enabled = Not btn戻し.Enabled
            '     btn早戻し.Enabled = Not btn早戻し.Enabled
            For i = 0 To 4 - 1
                '  aryPbtnList(0).Text = ""
                ' aryPbtnList(0).BackColor = Color.White
                aryPbtnList(i).Enabled = Not aryPbtnList(i).Enabled
            Next
            btn送り.Enabled = Not btn送り.Enabled
            '  btn早送り.Enabled = Not btn早送り.Enabled
        End If
    End Sub
    '---------------------------------------------------------
    '-------- BTN 読込 ---------
    '---------------------------------------------------------
    Private Sub btn読込_Click(sender As Object, e As EventArgs) Handles btn読込.Click
        lblPOSパターン選択.Text = "部門をボタンに割り付ける場合に入力します。"
        lblPOSパターン選択.ForeColor = Color.Red

        grp基本色.Enabled = True
        '  grp検索.Enabled = True
        grpメニュー選択.Enabled = True
        dgv商品名.Enabled = True
        dgv部門.Enabled = True
        btn取消.Enabled = True

        Call Menu項目クリア()
        DtblM頁.Clear()
        DtblBtnD追加.Clear()
        DtblBtnD追加Index = -1
        DtblWork2.Clear()
        Call BtnClear()
        BtnLockStatus = BtnLockStatus + 1
        Call UpperBtnNot(BtnLockStatus)
        Call PageBtnGroupeNot(BtnLockStatus)

        ' POS_M頁 取得
        msSQL = " "
        msSQL += "SELECT * from　POS_M頁 "
        msSQL += "where POSパターン= "
        msSQL += CmbPosPtn
        msSQL += " and POS区分 = "
        msSQL += PosKubun

        mCommand = cDB.getsqlComand(msSQL) '★上の二行に対するおまじない
        mSDA.SelectCommand = mCommand
        Call mSDA.Fill(DtblM頁) ''データセット作成

        If DtblM頁.Rows.Count <= 0 Then
            MsgBox("copy元にデータがありません")
            btnページ名称.Select()
            Exit Sub
        End If

        'プログレスバー
        'コントロールを初期化する
        'ProgressBar1.Visible = True   'プログレスバーを見せる
        'LblProgBar.Visible = True

        'ProgressBar1.Minimum = 0
        'ProgressBar1.Maximum = 1.5
        'ProgressBar1.Value = 0
        'LblProgBar.Text = "0"
        'LblProgBar.Update()

        '時間のかかる処理を開始する
        'プログレスバー
        Dim i As Integer
        For i = 1 To 2
            '1秒間待機する（時間のかかる処理があるものとする）
            System.Threading.Thread.Sleep(300)

            'ProgressBar1.Value = i
            'LblProgBar.Text = "いましばらくお待ちください"
            ''Label1を再描画する
            'LblProgBar.Update()
        Next

        ''結果を報告する
        'LblProgBar.Text = "完了しました。"
        'ProgressBar1.Visible = False   'プログレスバーを隠す
        'LblProgBar.Visible = False

        ''-----------ページ名読込（表示名１．．．．）表示------------------
        PBLEN = 0    '先頭から表示
        Call Show4(PBLEN)
        Call PageREADandDIsplay(CmbPosPtn, PosKubun, 1)    '1頁目をボタンに表示
        ActiveControl = Nothing
    End Sub

    '---------------------------------------------------------
    '-------- メニューTABL　読込 ---------
    '---------------------------------------------------------
    Sub MenuRead()
        Dtbl商品名list.Clear()

        '------------左側DGV]の表示----------
        msSQL = " "
        msSQL += "SELECT a.品目名　as　商品名,"
        msSQL += " format( b.[売価],'#,###') as 取引単価,c.[部門名] as 部門名,a.JANCD　as JANCD,  "
        msSQL += " a.商品CD　as　商品CD "
        'msSQL += " Select JANCD from POS_M品目ボタン設定 "
        msSQL += "　from POS_M品目 as a inner join POS_M売価 as b  "
        msSQL += " on a.JANCD = b.JANCD　"
        msSQL += " inner join [POS_M部門]　as c "
        msSQL += " on a.部門CD=c.部門CD "
        msSQL += "where  a.JANCD  <> '' "
        'msSQL += "'" + CmbPosPtn + "'"
        '部門CD検索ある？
        If CmbBumonCD <> 0 Then
            msSQL += " and a.部門CD= "
            msSQL += "'" + CmbBumonCD + "'"
        End If
        '分類CD検索ある？
        If CmbBunruiCD <> 0 Then
            msSQL += " and a.分類CD= "
            msSQL += "'" + CmbBunruiCD + "'"
        End If
        '文字検索ある？
        If txt文字検索.Text <> "" Then
            msSQL += " and a.検索カナ like "
            msSQL += "'%" + txt文字検索.Text + "%'"
        End If
        '売価の検索ある？
        Dim str As String
        Dim 売価Min As Double
        Dim 売価Max As Double
        'str = txt売価１.Text
        If Double.TryParse((txt売価１.Text), 売価Min) Then

            GoTo 売価MaxCheck
        End If
        GoTo Dtbl読込
売価MaxCheck:
        If Double.TryParse((txt売価２.Text), 売価Max) Then
            If 売価Min > 売価Max Then
                '  MsgBox("OK 売価１より大きな数値です")
                ' Else
                '   MsgBox("売価2の方が小さいか数値ではありません")
                GoTo Dtbl読込
            End If
        Else
            ' MsgBox("売価2が数値ではありません")
            GoTo Dtbl読込
        End If
SqlSet:
        str = 売価Min.ToString
        msSQL += " and b.売価> " + str
        str = 売価Max.ToString
        msSQL += " And b.売価 < " + str
Dtbl読込:
        msSQL += "ORDER BY a.JANCD"
        mCommand = cDB.getsqlComand(msSQL)
        mSDA.SelectCommand = mCommand
        Call mSDA.Fill(Dtbl商品名list)

        If Dtbl商品名list.Rows.Count <= 0 Then
            MsgBox("検索条件に一致するレコードは、ありません")
        End If
        dgv商品名.DataSource = Dtbl商品名list

        dgv商品名.Columns(0).Width = 215
        dgv商品名.Columns(1).Width = 95
        dgv商品名.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv商品名.Columns(2).Width = 105
        dgv商品名.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv商品名.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv商品名.Columns(3).Width = 200


    End Sub

    Private Sub btn終了_Click(sender As Object, e As EventArgs) Handles btn終了.Click
        If DtblBtnD追加Index >= 0 Then  'メニューを選択途中か？
            'メッセージボックスを表示する
            Select Case MessageBox.Show("設定は保存されません終了してもいいですか？",
                                                       "確認",
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Asterisk)
                Case vbYes
                    Me.Close()
                Case Else
                    Exit Sub
            End Select

        Else
            Me.Close()
        End If
    End Sub

    '------Btnページの押下時処理---------------
    Private Sub btnページ1_Click(sender As Object, e As EventArgs) Handles btnページ１.Click, btnページ２.Click,
        btnページ３.Click, btnページ４.Click

        Dim btnPnum As Integer = getBtnPnum(sender)
        SelPageNo = PBLEN + btnPnum   'ページ１ボタンは+1 ページボタン左端Pointer  PageBotonLeftEdgeNumber

        Call PageREADandDIsplay(CmbPosPtn, PosKubun, SelPageNo)

    End Sub

    '' getBtnNum
    '
    ' 機能      : ページボタン番号を取得する
    '
    ' 返り値    : ページボタン番号
    '
    ' 機能説明  : 押下されたページボタン番号を取得する
    '
    ' 備考      : 
    '
    Private Function getBtnPnum(btnPx As Button) As Integer
        Dim btnNum As Integer = (CType(btnPx, Button).Name).Substring(6)
        Return btnNum
    End Function


    '------------------------------------------
    '  !!!!  PAGE READ  !!!!
    '------------------------------------------
    Sub PageREADandDIsplay(ByVal Posptn As String,
                           ByVal Pos区分 As String,
                           ByVal PageNam As String)

        '    '--------------------------------
        '    '    AllClear()
        '    '--------------------------------------
        Call Menu項目クリア()
        DtblBtnD追加.Clear()
        DtblBtnD追加Index = -1
        DtblWork2.Clear()

        Call BtnClear()
        For i = 0 To 3  'PageBTNを強調表示
            aryPbtnList(i).FlatStyle = FlatStyle.Standard
        Next
        aryPbtnList(PageNam - PBLEN - 1).FlatStyle = FlatStyle.Popup  'PageBTNを強調表示

        msSQL = " "     ' DtblWork2に　「読み込んだPageのデータセット」 作成
        msSQL += "  Select a.*,b.ボタン表示名,c.ボタン表示名 as 部門表示名 "
        msSQL += " from ([POS_M品目ボタン設定]　as a "
        msSQL += " Left Join POS_M品目 as b "
        msSQL += " On a.JANCD=b.JANCD) "
        msSQL += " Left Join POS_M部門 as c "
        msSQL += " On a.部門CD=c.部門CD "
        msSQL += " where a.POSパターン = "
        msSQL += Posptn
        msSQL += " And a.POS区分 = "
        msSQL += Pos区分
        msSQL += " And a.頁NO = "
        msSQL += PageNam
        msSQL += " order by a.ボタンNO"

        mCommand = cDB.getsqlComand(msSQL)
        mSDA.SelectCommand = mCommand
        Call mSDA.Fill(DtblWork2)        ''データセット作成

        Dim R As Byte
        Dim G As Byte
        Dim B As Byte
        '変数の宣言とデータのセット
        Dim intTemp As Integer
        Dim Inhex As String
        Dim Intcolor As String
        '16進数に変換する
        ' For i = 0 To DtblWork2.Rows.Count - 1
        For Each getItem As DataRow In DtblWork2.Rows
            intTemp = getItem("ボタンNO").ToString
            Intcolor = getItem("ボタン色").ToString
            If Intcolor <> "" Then
                If getItem("JANCD").ToString <> "" Then
                    aryBtnList(intTemp - 1).Text = getItem("ボタン表示名").ToString
                Else
                    aryBtnList(intTemp - 1).Text = getItem("部門表示名").ToString
                End If
                Inhex = Hex(Intcolor.ToString)
                DivHex.Inhex = Inhex           'プロパティに値を設定
                Call DivHex.DivRGB()    'メソッドの呼び出し
                R = DivHex.P1    'ByLef?の受け取り
                G = DivHex.P2    'ByLef?の受け取り
                B = DivHex.P3    'ByLef?の受け取り
                aryBtnList(intTemp - 1).BackColor = Color.FromArgb(R, G, B)       'ボタンに色付け
            End If
        Next
        Call cDB.Close()
    End Sub

    Private Sub dgv部門_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv部門.CellContentClick
        If e.RowIndex < 0 Then Exit Sub
        If e.ColumnIndex < 0 Then Exit Sub
        If BtnPointer > 0 Then      '部門listの選択はDGVから直接取り出した


            txt部門CD.Text = dgv部門.Rows(e.RowIndex).Cells(0).Value.ToString()
            txt項目名.Text = dgv部門.Rows(e.RowIndex).Cells(1).Value.ToString()
            txtJANCD.Text = ""

            aryBtnList(BtnPointer - 1).Text = dgv部門.Rows(e.RowIndex).Cells(1).Value.ToString()
            btn規定色.Text = dgv部門.Rows(e.RowIndex).Cells(1).Value.ToString()

            DtblBtnD追加(DtblBtnD追加Index).Item("部門CD") = dgv部門.Rows(e.RowIndex).Cells(0).Value.ToString()
            DtblBtnD追加(DtblBtnD追加Index).Item("JANCD") = ""
            DtblBtnD追加(DtblBtnD追加Index).Item("項目名") = dgv部門.Rows(e.RowIndex).Cells(1).Value.ToString()
            Call ColorNow(BtnColor)             'BTnColor:整数   CLaSS
            DtblBtnD追加(DtblBtnD追加Index).Item("ボタン色") = BtnColor
            If DtblBtnD追加(DtblBtnD追加Index).Item("UPorIN") = "" Then
                DtblBtnD追加(DtblBtnD追加Index).Item("UPorIN") = "I"
            End If

            DtblBtnD追加(DtblBtnD追加Index).Item("MEorBU") = "BU"

            '選択Buttonと規定色を発色
            Dim p1 As Byte
            Dim p2 As Byte
            Dim p3 As Byte
            Dim InHex As String
            InHex = Hex(BtnColor.ToString)        '16進数に変換する
            DivHex.Inhex = InHex          'プロパティに値を設定
            Call DivHex.DivRGB()    'メソッドの呼び出し
            p1 = DivHex.P1    'ByLef?の受け取り
            p2 = DivHex.P2    'ByLef?の受け取り
            p3 = DivHex.P3    'ByLef?の受け取り

            aryBtnList(BtnPointer - 1).BackColor = Color.FromArgb(p1, p2, p3)       'ボタンに色付け
            btn規定色.BackColor = Color.FromArgb(p1, p2, p3)

        Else
            MessageBox.Show("ボタンを選択してください")
        End If

        ' End If
    End Sub

    '########### ボタン押下##########
    Private Sub btn_Click(sender As Object, e As EventArgs) Handles _
            btn1.Click, btn2.Click, btn3.Click, btn4.Click, btn5.Click,
            btn6.Click, btn7.Click, btn8.Click,
            btn9.Click, btn10.Click, btn11.Click, btn12.Click, btn13.Click,
            btn14.Click, btn15.Click, btn16.Click, btn17.Click, btn18.Click,
            btn19.Click, btn20.Click, btn21.Click, btn22.Click, btn23.Click,
            btn24.Click, btn25.Click, btn26.Click, btn27.Click, btn28.Click,
            btn29.Click, btn30.Click, btn31.Click, btn32.Click, btn33.Click,
            btn34.Click, btn35.Click, btn36.Click, btn37.Click, btn38.Click,
            btn39.Click, btn40.Click, btn41.Click, btn42.Click
        If cmbPOS.SelectedIndex <= 0 Then
            MsgBox("POSパターンを選択してください")
            cmbPOS.Select()
            Me.ActiveControl = Me.cmbPOS
            Exit Sub
        End If

        BtnPointer = getBtnNum(sender)       'Function  Btn番号　取り出し
        txt項目名.Text = sender.text
        btn規定色.Text = sender.text
        Dim BtnXindex As Integer
        Call EntryBtnD追加(BtnPointer, BtnXindex)

    End Sub

    '' getBtnNum
    '
    ' 機能      : ボタン番号を取得する
    '
    ' 返り値    : ボタン番号
    '
    ' 機能説明  : 押下されたボタンのボタン番号を取得する
    '
    ' 備考      : 
    '
    Private Function getBtnNum(btnX As Button) As Integer
        Dim btnNum As Integer = (CType(btnX, Button).Name).Substring(3)
        Return btnNum
    End Function
    Private Sub btn更新_Click(sender As Object, e As EventArgs) Handles btn更新.Click

        If BtnPointer <= 0 Then       'ikinariBtn更新を押した
            Exit Sub
        End If
        With DtblBtnD追加
            For i = 0 To DtblBtnD追加Index - 1  'Last-1のレコードまでｗりと正当性をチェック
                '未完成なRecord なら後ろでスルーされるのでここでもスルー
                If .Rows(i).Item("MEorBU") <> "" Then
                    For T = i + 1 To DtblBtnD追加Index
                        If .Rows(i).Item("ボタンNO") = .Rows(T).Item("ボタンNO") Then
                            If .Rows(T).Item("MEorBU") <> "" Then 'wりを見つけたandどちらも正当なレコード
                                .Rows(i).Item("MEorBU") = ""        '後ろのレコードを生かす
                            End If
                        End If
                    Next
                End If
            Next
            '未完成なRecord ならスルー
            For i = 0 To DtblBtnD追加Index
                If .Rows(i).Item("MEorBU") <> "" Then    '未完成なRecord
                    If .Rows(i).Item("UPorIN") = "I" Then
                        Call InsertMode更新(i)
                    Else
                        Call UpdateMode更新(i)
                    End If
                End If
            Next
            Call PageREADandDIsplay(CmbPosPtn, PosKubun, SelPageNo)    '更新されたPageを表示
            MessageBox.Show("設定が正しく登録されました。")

            BtnPointer = -1
            .Clear()
            DtblBtnD追加Index = -1
            ActiveControl = Nothing      'フォーカスを外す
        End With
    End Sub
    '-----------------------------------
    ' InsertMode更新
    '-----------------------------------
    Sub InsertMode更新(ByVal Indx As Integer)     'Insertモード
        ' !! ME (メニュー登録)か、BU(部門の割り付け)か、で列Dataを変える
        Dim cDB As New clsDB
        Dim msSQL As String
        Dim myTable As New DataTable
        Dim mSDA As New SqlDataAdapter
        Try
            'トランザクション開始
            Call cDB.BeginTransaction()
            msSQL = "insert into POS_M品目ボタン設定 values("
            msSQL += "'" + CmbPosPtn + "',"          '  "POSパターン"
            msSQL += "'1',"                   'POS区分=1,"
            msSQL += "'" + SelPageNo + "',"     ',頁NO,
            msSQL += "'" + DtblBtnD追加.Rows(Indx).Item("ボタンNO") + "',"      'ボタンNO,

            If DtblBtnD追加.Rows(Indx).Item("MEorBU") = "ME" Then
                msSQL += "'" + DtblBtnD追加.Rows(Indx).Item("JANCD") + "',"          ' ME (メニュー登録)
                msSQL += "'',"                 '部門CD=""
                msSQL += "'" + DtblBtnD追加.Rows(Indx).Item("ボタン色") + "')"                       ''ボタン色)"

                msSQL += " update POS_M品目 set "
                msSQL += " ボタン表示名= '" + DtblBtnD追加.Rows(Indx).Item("項目名") + "'"  'ピン止め疑問　POS_M品目でボタン表示名を
                '    msSQL += " ,部門CD='" + txt部門CD.Text + "'"    ボタン表示名を変更してしまうのはまずいと思う∵別のページで別の表示名を持てない、またはボタン表示名1(2)のつかいかたは？
                msSQL += " where JANCD='" + DtblBtnD追加.Rows(Indx).Item("JANCD") + "'"

            Else　　  　'BU(部門の割り付け
                msSQL += "'',"                 'JANCD=""
                msSQL += "'" + DtblBtnD追加.Rows(Indx).Item("部門CD") + "',"
                msSQL += "'" + DtblBtnD追加.Rows(Indx).Item("ボタン色") + "')"                       ''ボタン色)"

                msSQL += " update POS_M部門 set "
                msSQL += " ボタン表示名= '" + DtblBtnD追加.Rows(Indx).Item("項目名") + "'"
                msSQL += " where 部門CD= "
                msSQL += "'" + DtblBtnD追加.Rows(Indx).Item("部門CD") + "'"
            End If

            mCommand = cDB.getsqlComand(msSQL)
            Call mCommand.ExecuteNonQuery()
            'コミット
            Call cDB.Commit()
            ' MessageBox.Show("追加登録が正常に終了しました！")
        Catch ex As Exception
            'ロールバック
            Call cDB.Rollback()

            MessageBox.Show("追加登録に失敗しました！",
                                "グループ登録IN")
            Me.Close()
        End Try

    End Sub
    '-----------------------------------
    ' Update Mode 更新
    '-----------------------------------
    Sub UpdateMode更新(ByVal Indx As Integer)         '変更するのは POS_M品目.'ボタン表示名' '部門CD'　
        ' 　　　　             　　POS_M品目ボタン設定.ボタン色
        Dim cDB As New clsDB
        Dim msSQL As String
        Dim myTable As New DataTable
        Dim mSDA As New SqlDataAdapter

        Try
            'トランザクション開始
            Call cDB.BeginTransaction()
            '更新
            msSQL = " update POS_M品目ボタン設定 set "

            msSQL += "ボタン色="
            msSQL += DtblBtnD追加.Rows(Indx).Item("ボタン色")

            If DtblBtnD追加.Rows(Indx).Item("MEorBU") = "ME" Then

                msSQL += " , JANCD= '" + DtblBtnD追加.Rows(Indx).Item("JANCD") + "'"
                msSQL += " ,部門CD=''"       '部門CD=''
                msSQL += " where POSパターン=　"
                msSQL += CmbPosPtn
                msSQL += " and POS区分="
                msSQL += PosKubun
                msSQL += " and 頁NO="
                msSQL += SelPageNo
                msSQL += " and ボタンNO='" + DtblBtnD追加.Rows(Indx).Item("ボタンNO") + "'"

                msSQL += " update POS_M品目 set "
                msSQL += " ボタン表示名= '" + DtblBtnD追加.Rows(Indx).Item("項目名") + "'"  'ピン止め疑問　POS_M品目でボタン表示名を
                msSQL += " where JANCD=　'" + DtblBtnD追加.Rows(Indx).Item("JANCD") + "'"

            Else

                msSQL += " ,JANCD=''"       'JANCD=''
                msSQL += " ,部門CD='" + DtblBtnD追加.Rows(Indx).Item("部門CD") + "'"

                msSQL += " where POSパターン='" + CmbPosPtn + "' and POS区分='1'"
                msSQL += " and 頁NO='" + SelPageNo + "'"               'ボタンが押されたページ番号
                msSQL += " and ボタンNO='" + DtblBtnD追加.Rows(Indx).Item("ボタンNO") + "'"

                msSQL += " update POS_M部門 set "
                msSQL += " ボタン表示名= '" + DtblBtnD追加.Rows(Indx).Item("項目名") + "'"  'ピン止め疑問　POS_M品目でボタン表示名を
                msSQL += " where 部門CD=　'"
                msSQL += DtblBtnD追加.Rows(Indx).Item("部門CD")
                msSQL += "'"

            End If

            mCommand = cDB.getsqlComand(msSQL)
            Call mCommand.ExecuteNonQuery()
            'コミット
            Call cDB.Commit()
            '  MessageBox.Show("更新が正常に終了しました！")
        Catch ex As Exception
            'ロールバック
            Call cDB.Rollback()
            MessageBox.Show("Updateに失敗しました！", "レジメニュー設定")
            Me.Close()
        End Try
        '  Call Cancell処理()
    End Sub

    'Btn内容クリアーに改名
    Private Sub btn取消_Click(sender As Object, e As EventArgs) Handles btn取消.Click
        If SelPageNo <= 0 Then   'いきなり押された
            Exit Sub
        End If
        If BtnPointer <= 0 Then   'いきなり押された
            Exit Sub
        End If

        Select Case MessageBox.Show("選択されたボタンの内容と" & vbCr &
                                    "更新中の内容も無効になります！" & vbCr &
                                    "内容の削除を行いますか？", "確認",
                                                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            Case vbOK

                Dim cDB As New clsDB
                Dim msSQL As String
                Dim myTable As New DataTable
                Dim mSDA As New SqlDataAdapter

                Try
                    'トランザクション開始
                    Call cDB.BeginTransaction()
                    msSQL = " Delete　from　 POS_M品目ボタン設定 "
                    msSQL += " where 頁NO='" + SelPageNo + "'"               'ボタンが押されたページ番号
                    msSQL += " and ボタンNO='" + BtnPointer + "'"
                    msSQL += " and POSパターン='" + CmbPosPtn + "' and POS区分="
                    msSQL += PosKubun
                    mCommand = cDB.getsqlComand(msSQL)
                    Call mCommand.ExecuteNonQuery()
                    'コミット
                    Call cDB.Commit()
                    MessageBox.Show("削除が正常に終了しました！")
                Catch ex As Exception
                    'ロールバック
                    Call cDB.Rollback()
                    MessageBox.Show("削除に失敗しました！ ")
                    Me.Close()
                End Try
                'Page内容更新表示
                Call PageREADandDIsplay(CmbPosPtn, PosKubun, SelPageNo)
            Case Else
                Exit Sub

        End Select
        BtnPointer = -1
    End Sub
    Sub Menu項目クリア()
        btn規定色.BackColor = Color.White   'ボタン色を戻す
        If chk基本色.Checked = False Then
            btn基本色.BackColor = Color.White
        End If
        If DtblBtnD追加Index > 0 Then
            txt項目名.Text = ""
            txt部門CD.Text = ""
            txtJANCD.Text = ""
        End If
    End Sub
    '--------------------------------------------
    ' ーー　COLOR NOW Btn の色はなにか　　  
    Sub ColorNow(ByRef BtnColor As String)         'BtnColor:整数
        If chk基本色.Checked = True Then       '基本色は、''　　仮
            BtnColor = Convert.ToInt32(基本色, 16)
        Else            '基本色が選択されていない
            BtnColor = Convert.ToInt32("DCDCDC", 16)   'Defolt色は　Gray(DCDCDC)
        End If
    End Sub

    Private Sub btn規定色_Click(sender As Object, e As EventArgs) Handles btn規定色.Click
        If BtnPointer <= 0 Then
            MsgBox("登録するボタンを選択してください")
            Exit Sub
        End If
        Dim sfrm As New Frm111レジメニュ設定_Colorサンプル
        sfrm.fromF1 = Defolt色
        sfrm.ShowDialog()

        規定色 = sfrm.RtnColor

        Dim R As Byte             '戻値1　FromArgb(p1, p2, p3)のパラメーターになる
        Dim G As Byte             '戻値2　FromArgb(p1, p2, p3)のパラメーターになる
        Dim B As Byte             '戻値3　FromArgb(p1, p2, p3)のパラメーターになる

        DivHex.Inhex = 規定色          'プロパティに値を設定
        Call DivHex.DivRGB()   'メソッドの呼び出し
        R = DivHex.P1    'ByLef?の受け取り
        G = DivHex.P2    'ByLef?の受け取り
        B = DivHex.P3    'ByLef?の受け取り

        btn規定色.BackColor = Color.FromArgb(R, G, B)
        DtblBtnD追加.Rows(DtblBtnD追加Index).Item("ボタン色") = Convert.ToInt32(規定色, 16)   'ボタン色書き換え　　　
        aryBtnList(BtnPointer - 1).BackColor = Color.FromArgb(R, G, B)
    End Sub

    'Private Sub btn基本色_Click(sender As Object, e As EventArgs)

    '    Dim P1 As Byte             ' 戻値1　FromArgb(p1, p2, p3)のパラメーターになる
    '    Dim P2 As Byte             '戻値2　FromArgb(p1, p2, p3)のパラメーターになる
    '    Dim P3 As Byte             '戻値3　FromArgb(p1, p2, p3)のパラメーターになる
    '    Dim sfrm As New Frm111レジメニュ設定_Colorサンプル
    '    sfrm.fromF1 = Defolt色
    '    sfrm.ShowDialog()

    '    基本色 = sfrm.RtnColor
    '    Call ChoicePaintColor(基本色.ToString, P1, P2, P3)

    '    btn基本色.BackColor = Color.FromArgb(P1, P2, P3)
    '    btn規定色.BackColor = Color.FromArgb(P1, P2, P3)

    'End Sub
    '----------------------------------------------------------------------------------------
    'btn基本色  btn規定色  DtblBtnD追加 aryBtnList(BtnPointer - 1)  に選択されたCOLORを　表示
    Sub ChoicePaintColor(ByVal PaintiingBlack As String,
                              ByRef R As Byte,
                              ByRef G As Byte,
                              ByRef B As Byte)

        DivHex.Inhex = PaintiingBlack        'プロパティに値を設定
        Call DivHex.DivRGB()   'メソッドの呼び出し
        R = DivHex.P1    'ByLef?の受け取り
        G = DivHex.P2    'ByLef?の受け取り
        B = DivHex.P3    'ByLef?の受け取り

        If BtnPointer > 0 Then      'Btnがまだ選択されていないときは、登録しない
            DtblBtnD追加.Rows(DtblBtnD追加Index).Item("ボタン色") = Convert.ToInt32(PaintiingBlack, 16)  'ボタン色書き換え　
            aryBtnList(BtnPointer - 1).BackColor = Color.FromArgb(R, G, B)   'ボタン色書き換え　
        End If

    End Sub
    '--------------------------------------
    '   Sub BtnClear()
    '--------------------------------------
    Sub BtnClear()　　        '---------ボタン42個の表示クリア---------
        BtnPointer = -1
        For i = 1 To 42
            aryBtnList(i - 1).Text = ""
            aryBtnList(i - 1).BackColor = Color.White
            aryBtnList(i - 1).FlatStyle = FlatStyle.Standard
        Next
    End Sub
    '--------------------------------------------
    '選択したボタンはページに登録されているか？　（　UpdateかInsertか ）
    '--------------------------------------------
    Sub EntryBtnD追加(ByVal BtnNum As Integer,
                     ByRef BtnXindex As Integer)    '入力中のRecがあるか

        aryBtnList(BtnNum - 1).FlatStyle = FlatStyle.Popup

        DtblBtnD追加.Rows.Add()
        DtblBtnD追加Index = DtblBtnD追加Index + 1

        For i = 0 To DtblWork2.Rows.Count - 1
            If BtnNum = DtblWork2.Rows(i).Item("ボタンNO") Then
                BtnXindex = i.ToString
                '    BtnBlgPage = True                              'Btn Belong To Table 
                GoTo Mitsuketa
            End If
        Next
        BtnXindex = -1                          ' BtnXindex Work2のRowインデックス
        DtblBtnD追加(DtblBtnD追加Index).Item("ボタンNO") = BtnNum.ToString
        DtblBtnD追加(DtblBtnD追加Index).Item("UPorIN") = "I"   '見つからないので Insert
        DtblBtnD追加(DtblBtnD追加Index).Item("MEorBU") = ""      'Menu Or 部門の書き込み未定
        '    DgvBtnD追加.DataSource = DtblBtnD追加                   'DGV後で消す＃＃＃＃＃
        Exit Sub
Mitsuketa:       'Mode によって分ける
        '  If ModeIs部門を割付 = False Then

        DtblBtnD追加(DtblBtnD追加Index).Item("ボタンNO") = DtblWork2.Rows(BtnXindex).Item("ボタンNO")
        DtblBtnD追加(DtblBtnD追加Index).Item("ボタン色") = DtblWork2.Rows(BtnXindex).Item("ボタン色")
        DtblBtnD追加(DtblBtnD追加Index).Item("UPorIN") = "U"

        If DtblWork2.Rows(BtnXindex).Item("JANCD") <> "" Then
            DtblBtnD追加(DtblBtnD追加Index).Item("JANCD") = DtblWork2.Rows(BtnXindex).Item("JANCD")
            DtblBtnD追加(DtblBtnD追加Index).Item("項目名") = DtblWork2.Rows(BtnXindex).Item("ボタン表示名")
            DtblBtnD追加(DtblBtnD追加Index).Item("MEorBU") = "ME"      'Menuの書き込み
        Else
            DtblBtnD追加(DtblBtnD追加Index).Item("部門CD") = DtblWork2.Rows(BtnXindex).Item("部門CD")
            DtblBtnD追加(DtblBtnD追加Index).Item("項目名") = DtblWork2.Rows(BtnXindex).Item("部門表示名")
            DtblBtnD追加(DtblBtnD追加Index).Item("MEorBU") = "BU"      'Menuの書き込み
        End If

        Dim R As Byte             '戻値1　FromArgb(p1, p2, p3)のパラメーターになる
        Dim G As Byte             '戻値2　FromArgb(p1, p2, p3)のパラメーターになる
        Dim B As Byte             '戻値3　FromArgb(p1, p2, p3)のパラメーターになる
        Dim inhex As String = Hex(DtblWork2.Rows(BtnXindex).Item("ボタン色"))

        DivHex.Inhex = inhex        'プロパティに値を設定
        Call DivHex.DivRGB()   'メソッドの呼び出し
        R = DivHex.P1    'ByLef?の受け取り
        G = DivHex.P2    'ByLef?の受け取り
        B = DivHex.P3    'ByLef?の受け取り

        btn規定色.BackColor = Color.FromArgb(R, G, B)


    End Sub

    Private Sub btnキャンセル_Click(sender As Object, e As EventArgs) Handles btnキャンセル.Click
        'メッセージボックスを表示する
        Select Case MessageBox.Show("設定は保存されませんキャンセルしてもいいですか？",
                                                         "確認",
                                                       MessageBoxButtons.YesNo,
                                                         MessageBoxIcon.Asterisk)
            Case vbYes
                Call PageREADandDIsplay(CmbPosPtn, PosKubun, SelPageNo)
                'Call Menu項目クリア()
                'DtblBtnD追加.Clear()
                DtblBtnD追加Index = -1

            Case Else
                '「いいえ」か　Xが、選択された時 
        End Select
        ActiveControl = Nothing
    End Sub

    Sub Show4(ByVal LeftNum As Integer)      'ページボタンを4つ表示
        '------Btnページの表示---------------
        Dim ColNam As String
        For i = 0 To 3
            aryPbtnList(i).FlatStyle = FlatStyle.Standard            '強調表示を戻す
            ColNam = DtblM頁.Columns(LeftNum + 2).ColumnName     ' ページ名は Col(2)
            aryPbtnList(i).Text = DtblM頁.Rows(0).Item(ColNam)   ' ページ名を「ColumnName」で取り出す
            LeftNum = LeftNum + 1
        Next
    End Sub

    Private Sub btn送り_Click(sender As Object, e As EventArgs) Handles btn送り.Click
        If PBLEN + 1 > 36 Then     '右からはみ出る  Left=P33 Right=P40
            Exit Sub
        End If
        PBLEN = PBLEN + 1  'ページボタン左端Pointer  PageBotonLeftEdgeNumber
        Call show4(PBLEN)
        Call BtnPopUP()   '選択したPageが、はみ出していないなら強調表示
    End Sub

    '    Private Sub btn早送り_Click(sender As Object, e As EventArgs) Handles btn早送り.Click
    '        If PBLEN + 7 > 32 Then     '右からはみ出る
    '            PBLEN = 32
    '            GoTo GoToShow8
    '        End If
    '        PBLEN = PBLEN + 7  'ページボタン左端Pointer  PageBotonLeftEdgeNumber
    'GoToShow8:
    '        Call Show8(PBLEN)
    '        Call BtnPopUP()   '選択したPageが、はみ出していないなら強調表示

    '    End Sub

    Sub BtnPopUP()   '選択したPageが、はみ出していないなら強調表示
        If SelPageNo - PBLEN > 0 And SelPageNo - PBLEN <= 4 Then
            aryPbtnList(SelPageNo - PBLEN - 1).FlatStyle = FlatStyle.Popup    '強調表示
        End If
    End Sub
    Private Sub btn戻し_Click(sender As Object, e As EventArgs) Handles btn戻し.Click
        If PBLEN - 1 < 0 Then  'ページボタン左端Pointer  PageBotonLeftEdgeNumbe
            Exit Sub
        End If
        PBLEN = PBLEN - 1
        Call Show4(PBLEN)
        Call BtnPopUP()   '選択したPageが、はみ出していないなら強調表示

    End Sub

    '    Private Sub btn早戻し_Click(sender As Object, e As EventArgs) Handles btn早戻し.Click
    '        If PBLEN - 7 < 0 Then  'ページボタン左端Pointer  PageBotonLeftEdgeNumbe
    '            PBLEN = 0
    '            GoTo GoToShow8
    '        End If
    '        PBLEN = PBLEN - 7
    'GoToShow8:
    '        Call Show8(PBLEN)
    '        Call BtnPopUP()   '選択したPageが、はみ出していないなら強調表示

    '    End Sub

    Private Sub btnページ名称_Click(sender As Object, e As EventArgs) Handles btnページ名称.Click
        Dim sfrm As New Frm111ページ名称
        Call sfrm.ShowDialog()
    End Sub

    Private Sub btnコピー_Click(sender As Object, e As EventArgs) Handles btnコピー.Click
        Dim sfrm As New Frm111ページコピー
        sfrm.txt元CmbPosPtn.Text = CmbPosPtn
        sfrm.txt元CmbPosName.Text = CmbPosName
        Call sfrm.ShowDialog()
        ActiveControl = Nothing      'フォーカスを外す
    End Sub
    '===============================================================
    ' SetCmbPos CMBボックスにItemをSetする
    '===============================================================
    Public Sub SetCmbPos(ByVal setDDL As ComboBox)
        Dim cDB As New clsDB
        Dim getSQL As String
        Dim myTable As New DataTable

        ''検索SQL======================================================
        getSQL = "SELECT パターン名称 as 表示,POSパターン"
        getSQL += " FROM POS_MPOSパターン"
        getSQL += " ORDER BY POSパターン"

        mCommand = cDB.getsqlComand(getSQL)
        mSDA.SelectCommand = mCommand

        Call mSDA.Fill(myTable)
        ''=============================================================

        ''先頭行追加-----------------------------------------------------
        Dim myRow As DataRow = myTable.NewRow
        myRow("POSパターン") = "0"
        myRow("表示") = ""
        Call myTable.Rows.InsertAt(myRow, 0)

        With setDDL
            .DisplayMember = "表示"
            .ValueMember = "POSパターン"

            ''グリッド表示
            .DataSource = myTable.DefaultView
            .SelectedValue = 0

        End With
    End Sub
    '===============================================================
    ' SetCmb部門 cmb部門にItemをSetする
    '===============================================================
    Public Sub SetCmb部門(ByVal setDDL As ComboBox)
        Dim cDB As New clsDB
        Dim getSQL As String
        Dim myTable As New DataTable

        ''検索SQL======================================================
        getSQL = "SELECT 部門名 as 表示,部門CD"
        getSQL += " FROM POS_M部門"
        getSQL += " ORDER BY 部門CD"

        mCommand = cDB.getsqlComand(getSQL)
        mSDA.SelectCommand = mCommand

        Call mSDA.Fill(myTable)

        ''先頭行追加-----------------------------------------------------
        Dim myRow As DataRow = myTable.NewRow
        myRow("部門CD") = "0"
        myRow("表示") = "全ての部門"
        Call myTable.Rows.InsertAt(myRow, 0)

        With setDDL
            .DisplayMember = "表示"
            .ValueMember = "部門CD"

            ''グリッド表示
            .DataSource = myTable.DefaultView
            .SelectedValue = 0

        End With
    End Sub
    '===============================================================
    ' SetCmb分類 にItemをSetする
    '===============================================================
    Public Sub SetCmb分類(ByVal setDDL As ComboBox)
        Dim cDB As New clsDB
        Dim getSQL As String
        Dim myTable As New DataTable

        ''検索SQL======================================================
        getSQL = "SELECT 分類名 as 表示,分類CD"
        getSQL += " FROM POS_M分類"
        getSQL += " ORDER BY 分類CD"

        mCommand = cDB.getsqlComand(getSQL)
        mSDA.SelectCommand = mCommand

        Call mSDA.Fill(myTable)

        ''先頭行追加-----------------------------------------------------
        Dim myRow As DataRow = myTable.NewRow
        myRow("分類CD") = "0"
        myRow("表示") = "全ての分類"
        Call myTable.Rows.InsertAt(myRow, 0)

        With setDDL
            .DisplayMember = "表示"
            .ValueMember = "分類CD"

            ''グリッド表示
            .DataSource = myTable.DefaultView
            .SelectedValue = 0

        End With
    End Sub

    Sub PosM頁Read(ByVal pospatn As String,
                   ByVal kubunn As String)
        '############  POS_M頁 ページ名読込（表示名１．．．．）表示  Fanction化のため　以下　wリ（たぶん？）
        msSQL = " "
        msSQL += "SELECT * from　POS_M頁 "
        msSQL += "where POSパターン= "
        msSQL += pospatn
        msSQL += " and POS区分 = "
        msSQL += kubunn

        mCommand = cDB.getsqlComand(msSQL) '★上の二行に対するおまじない
        mSDA.SelectCommand = mCommand
        Call mSDA.Fill(DtblM頁) ''データセット作成

        If DtblM頁.Rows.Count <= 0 Then
            MsgBox("copy元にデータがありません")
            btnページ名称.Select()
            Exit Sub
        End If

        '   DgvM頁.DataSource = DtblM頁
    End Sub
    Sub BumonnRead()
        '------------右側DGV]の表示----------   
        Dtbl部門list.Clear()
        dgv部門.DataSource = Nothing

        msSQL = " "
        msSQL += "Select 部門CD,部門名　"
        msSQL += " from POS_M部門 "
        msSQL += "ORDER BY 部門CD"
        mCommand = cDB.getsqlComand(msSQL)
        mSDA.SelectCommand = mCommand
        Call mSDA.Fill(Dtbl部門list)
        dgv部門.DataSource = Dtbl部門list
        cmb部門.SelectedValue.ToString()
    End Sub

    Private Sub cmb部門_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb部門.SelectedIndexChanged
        CmbBumonCD = cmb部門.SelectedValue.ToString()
    End Sub

    Private Sub cmb分類_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb分類.SelectedIndexChanged
        Dim item2 As String = 0
        CmbBunruiCD = cmb分類.SelectedValue.ToString()
    End Sub

    Private Sub Btn検索開始_Click(sender As Object, e As EventArgs) Handles Btn検索開始.Click
        Call MenuRead()
    End Sub
    Private Sub btn条件クリア_Click(sender As Object, e As EventArgs) Handles btn条件クリア.Click
        cmb部門.SelectedIndex = 0
        cmb分類.SelectedIndex = 0
        txt文字検索.Text = ""
        txt売価１.Text = "0"
        txt売価２.Text = "99999999"
        Call MenuRead()
    End Sub

    Private Sub dgv商品名_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv商品名.CellClick
        If cmbPOS.SelectedIndex <= 0 Then
            MsgBox("POSパターンを選択してください")
            cmbPOS.Select()
            Me.ActiveControl = Me.cmbPOS

            Exit Sub
        End If

        If e.RowIndex < 0 Then Exit Sub
        If e.ColumnIndex < 0 Then Exit Sub

        If BtnPointer > 0 Then
            '    If DtblBtnD追加Index >= 0 Then
            Dim selected商品CD As String
            selected商品CD = dgv商品名.Rows(e.RowIndex).Cells("商品CD").Value.ToString

            Dim dtblsele商品 As New DataTable

            '------------左側DGV]の選ばれた1行を表示----------
            msSQL = " "
            msSQL += "SELECT a.品目名　as　商品名,"
            msSQL += " format( b.[売価],'#,###') as 取引単価,c.[部門名] as 部門名,a.JANCD　as JANCD,  "
            msSQL += " a.商品CD　as　商品CD "
            msSQL += "　from POS_M品目 as a inner join POS_M売価 as b  "
            msSQL += " on a.JANCD = b.JANCD　"
            msSQL += " inner join [POS_M部門]　as c "
            msSQL += " on a.部門CD=c.部門CD "
            msSQL += "where a.商品CD=　'" & selected商品CD & "'"

            mCommand = cDB.getsqlComand(msSQL)
            mSDA.SelectCommand = mCommand

            Call mSDA.Fill(dtblsele商品) ''データセット作成

            txt項目名.Text = dtblsele商品.Rows(0).Item("商品名").ToString
            aryBtnList(BtnPointer - 1).Text = txt項目名.Text
            txtJANCD.Text = dtblsele商品.Rows(0).Item("JANCD").ToString
            btn規定色.Text = dtblsele商品.Rows(0).Item("商品名").ToString
            txt部門CD.Text = ""
            DtblBtnD追加(DtblBtnD追加Index).Item("部門CD") = ""
            DtblBtnD追加(DtblBtnD追加Index).Item("JANCD") = dtblsele商品.Rows(0).Item("JANCD").ToString

            DtblBtnD追加(DtblBtnD追加Index).Item("項目名") = dtblsele商品.Rows(0).Item("商品名").ToString
            '   Btn色は何にすべきか
            Call ColorNow(BtnColor)             'BTnColor:整数   CLaSS
            DtblBtnD追加(DtblBtnD追加Index).Item("ボタン色") = BtnColor
            If DtblBtnD追加(DtblBtnD追加Index).Item("UPorIN") = "" Then
                DtblBtnD追加(DtblBtnD追加Index).Item("UPorIN") = "I"
            End If
            DtblBtnD追加(DtblBtnD追加Index).Item("MEorBU") = "ME"

            '選択Buttonと規定色を発色
            Dim p1 As Byte
            Dim p2 As Byte
            Dim p3 As Byte
            Dim InHex As String
            InHex = Hex(BtnColor.ToString)        '16進数に変換する
            DivHex.Inhex = InHex          'プロパティに値を設定
            Call DivHex.DivRGB()    'メソッドの呼び出し
            p1 = DivHex.P1    'ByLef?の受け取り
            p2 = DivHex.P2    'ByLef?の受け取り
            p3 = DivHex.P3    'ByLef?の受け取り

            ' Call DivRGB(InHex, p1, p2, p3)
            aryBtnList(BtnPointer - 1).BackColor = Color.FromArgb(p1, p2, p3)       'ボタンに色付け
            btn規定色.BackColor = Color.FromArgb(p1, p2, p3)

        Else
            MessageBox.Show("ボタンを選択してください")
        End If

    End Sub


    Private Sub txt文字検索_MouseClick(sender As Object, e As MouseEventArgs) Handles txt文字検索.MouseClick,
                                                                                      txt売価１.MouseClick, txt売価２.MouseClick
        contNam = sender.name.ToString   'Control "Name"
        sendSav = sender.text

        sender.SelectAll()　　　　　　'MouseClickでText全選択
    End Sub

    Private Sub txt文字検索_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt文字検索.KeyPress,
         txt売価１.KeyPress, txt売価２.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            Me.SelectNextControl(sender, True, True, True, True)
            e.Handled = True
        Else
            If e.KeyChar = Chr(Keys.Escape) Then
                Controls(contNam).Text = sendSav        'MouseClicされたControlの内容を戻す
                ActiveControl = Nothing
            End If
        End If
    End Sub

    Private Sub txt項目名_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt項目名.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            Me.SelectNextControl(sender, True, True, True, True)
            e.Handled = True
            If BtnPointer > 0 Then
                If DtblBtnD追加Index >= 0 Then
                    DtblBtnD追加(DtblBtnD追加Index).Item("項目名") = txt項目名.Text
                    aryBtnList(BtnPointer - 1).Text = txt項目名.Text
                    btn規定色.Text = txt項目名.Text
                End If
            End If
            ActiveControl = Nothing
        Else
            If e.KeyChar = Chr(Keys.Escape) Then
                ActiveControl = Nothing
            End If
        End If
    End Sub

    Private Sub btn基本色_MouseClick(sender As Object, e As MouseEventArgs) Handles btn基本色.MouseClick

        Dim P1 As Byte             ' 戻値1　FromArgb(p1, p2, p3)のパラメーターになる
        Dim P2 As Byte             '戻値2　FromArgb(p1, p2, p3)のパラメーターになる
        Dim P3 As Byte             '戻値3　FromArgb(p1, p2, p3)のパラメーターになる
        Dim sfrm As New Frm111レジメニュ設定_Colorサンプル
        sfrm.fromF1 = Defolt色
        sfrm.ShowDialog()

        基本色 = sfrm.RtnColor
        Call ChoicePaintColor(基本色.ToString, P1, P2, P3)

        btn基本色.BackColor = Color.FromArgb(P1, P2, P3)
        btn規定色.BackColor = Color.FromArgb(P1, P2, P3)

    End Sub
End Class