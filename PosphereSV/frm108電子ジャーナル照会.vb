Public Class frm108電子ジャーナル照会

    Private Sub grpジャーナル内検索_Enter(sender As Object, e As EventArgs) Handles grpジャーナル内検索.Enter

    End Sub

    Private Sub btn終了_Click(sender As Object, e As EventArgs) Handles btn終了.Click
        Me.Close()
    End Sub

    Private Sub btnジャーナルファイル一覧_Click(sender As Object, e As EventArgs) Handles btnジャーナルファイル一覧.Click

        Dim appPath As String = System.AppDomain.CurrentDomain.BaseDirectory

        lstジャーナルファイル一覧.Items.Clear()

        '※テスト用に実行ファイルと同じロケーションにジャーナルファイルを作成（製品版では削除）
        If System.IO.File.Exists(appPath + "test.JNL") Then

        Else
            Call 試験用ジャーナルファイル作成(appPath, "test.JNL")
        End If

        'ジャーナルファイルが存在するかチェック
        'Dim di As New System.IO.DirectoryInfo(txt端末.Text)

        'テスト用に実行ファイルと同じロケーションに作成したジャーナルファイルをチェック
        Dim di As New System.IO.DirectoryInfo(appPath)

        Dim chkFiles As System.IO.FileInfo() = di.GetFiles("*")

        Dim chkJournal As Boolean = False

        For Each filename As System.IO.FileInfo In chkFiles
            If Strings.Right(filename.Name, 3) = "JNL" Then chkJournal = True
        Next

        If chkJournal = True Then
            Dim files As System.IO.FileInfo() = di.GetFiles("*.JNL")

            'lstジャーナルファイル一覧に結果を表示する
            For Each filename As System.IO.FileInfo In files
                lstジャーナルファイル一覧.Items.Add(filename.Name)
            Next
        End If

    End Sub

    Private Sub btn一覧で選択されたジャーナル_Click(sender As Object, e As EventArgs) Handles btn一覧で選択されたジャーナル.Click

        If lstジャーナルファイル一覧.SelectedItems.Count > 0 Then

            Dim strSelectedtext As String

            Dim line As String = ""
            Dim al As New ArrayList

            lstジャーナルの表示.Items.Clear()

            strSelectedtext = lstジャーナルファイル一覧.SelectedItem.ToString

            Using sr As IO.StreamReader = New IO.StreamReader(
                strSelectedtext, System.Text.Encoding.GetEncoding("Shift_JIS"))

                line = sr.ReadLine()
                Do Until line Is Nothing
                    al.Add(line)
                    line = sr.ReadLine()
                Loop

            End Using

            For i As Integer = 0 To al.Count - 1
                lstジャーナルの表示.Items.Add(al.Item(i))
            Next i

        Else

            MessageBox.Show("ジャーナルファイルが選択されていません")

        End If

    End Sub

    Private Sub btn参照_Click(sender As Object, e As EventArgs) Handles btn参照.Click
        'FolderBrowserDialogクラスのインスタンスを作成
        Dim fbd As New FolderBrowserDialog

        '上部に表示する説明テキストを指定
        fbd.Description = "フォルダを指定してください。"
        'ルートフォルダを指定
        fbd.RootFolder = Environment.SpecialFolder.Desktop
        '最初に選択するフォルダを指定
        fbd.SelectedPath = "C:\Windows"
        'ユーザーが新しいフォルダを作成できる
        fbd.ShowNewFolderButton = True

        If fbd.ShowDialog(Me) = DialogResult.OK Then
            txt端末.Text = fbd.SelectedPath
        End If

    End Sub

    Private Sub btn検索_Click(sender As Object, e As EventArgs) Handles btn検索.Click
        Dim flgSelect As Boolean
        Dim intSelect As Integer

        If txt検索文字列.Text = "" Then
            MessageBox.Show("検索文字列を指定してください")
        Else
            lstジャーナルの表示.ClearSelected()

            flgSelect = False

            '日付検索のチェックボックスが入っている
            If chk検索日付.Checked = True Then
                For i = 0 To lstジャーナルの表示.Items.Count - 1

                    If lstジャーナルの表示.Items(i).Contains(dtp検索日付.Value.Year.ToString() +
                    dtp検索日付.Value.Month.ToString("00") +
                    dtp検索日付.Value.Day.ToString("00")) = True Then

                        If lstジャーナルの表示.Items(i).Contains(txt検索文字列.Text) = True Then

                            lstジャーナルの表示.SelectionMode = SelectionMode.MultiExtended
                            lstジャーナルの表示.SetSelected(i, True)

                            If flgSelect = False Then
                                intSelect = i
                                flgSelect = True
                            End If

                        End If

                    End If
                Next
            Else
                For i = 0 To lstジャーナルの表示.Items.Count - 1

                    If lstジャーナルの表示.Items(i).Contains(txt検索文字列.Text) = True Then

                        lstジャーナルの表示.SelectionMode = SelectionMode.MultiExtended
                        lstジャーナルの表示.SetSelected(i, True)

                        If flgSelect = False Then
                            intSelect = i
                            flgSelect = True
                        End If

                    End If

                Next

            End If
        End If

    End Sub

    Private Sub sLBSearch(ByVal LBox As ListBox, ByVal SearchStr As String,
        Optional ByVal Exact As Integer = 0, Optional ByVal sPos As Integer = -1)
        'ListBox 内を完全一致・前方一致検索を再帰的に行うプロシージャ
        Dim ret As Integer = -1
        ret = LBox.FindString(SearchStr, sPos)

        If ret <= sPos Or ret = -1 Then  '見つから無かった場合
            Return
        Else                '見つかった場合
            With LBox
                .SelectionMode = SelectionMode.MultiExtended
                .SetSelected(ret, True)         '見つかった行を選択状態に
                If ret < .Items.Count - 1 Then  '次の検索
                    sLBSearch(LBox, SearchStr, Exact, ret)
                Else
                    Return
                End If
            End With
        End If
    End Sub

    Private Sub 試験用ジャーナルファイル作成(ByVal testPath As String, ByVal testFile As String)

        Using writer As New System.IO.StreamWriter(testPath + testFile,
                                                           False, System.Text.Encoding.GetEncoding("shift_jis"))

            'writer.WriteLine("20200205,111702,000000,001,停止,                                ")
            'writer.WriteLine("20200205,111702,000000,002,停止,────────────────")
            'writer.WriteLine("20200205,111706,000000,001,停止,ｻｲﾝｵﾝ 004:渡辺　富幸            ")
            'writer.WriteLine("20200205,111706,000000,002,停止,────────────────")
            'writer.WriteLine("20200205,111742,000000,001,停止,ｻｲﾝｵﾝ 004:渡辺　富幸            ")
            'writer.WriteLine("20200205,111742,000000,002,停止,────────────────")
            writer.WriteLine("20200205,111751,000099,001,登録,2020年02月05日(水)      11時17分")
            writer.WriteLine("20200205,111751,000099,002,登録,           領　収　書           ")
            writer.WriteLine("20200205,111751,000099,003,登録,釣銭準備金              \100,000")
            writer.WriteLine("20200205,111751,000099,004,登録,合計                    \100,000")
            writer.WriteLine("20200205,111751,000099,005,登録,ﾚｼｰﾄ№000099            ﾚｼﾞ:0021")
            writer.WriteLine("20200205,111751,000099,006,登録,担当:渡辺　富幸         店 :0000")
            writer.WriteLine("20200205,111751,000099,007,登録,客層 99 その他                  ")
            writer.WriteLine("20200205,111751,000099,008,登録,────────────────")
            writer.WriteLine("20200205,113326,000100,001,登録,2020年02月05日(水)      11時33分")
            writer.WriteLine("20200205,113326,000100,002,登録,           領　収　書           ")
            writer.WriteLine("20200205,113326,000100,003,登録,2400000008705                   ")
            writer.WriteLine("20200205,113326,000100,004,登録,送料830                     \830")
            writer.WriteLine("20200205,113326,000100,005,登録,2400000008712                   ")
            writer.WriteLine("20200205,113326,000100,006,登録,送料940                     \940")
            writer.WriteLine("20200205,113326,000100,007,登録,2400000008729                   ")
            writer.WriteLine("20200205,113326,000100,008,登録,送料1050                  \1,050")
            writer.WriteLine("20200205,113326,000100,009,登録,2400000008736                   ")
            writer.WriteLine("20200205,113326,000100,010,登録,送料1160                  \1,160")
            writer.WriteLine("20200205,113326,000100,011,登録,2400000008743                   ")
            writer.WriteLine("20200205,113326,000100,012,登録,送料1270                  \1,270")
            writer.WriteLine("20200205,113326,000100,013,登録,2400000008750                   ")
            writer.WriteLine("20200205,113326,000100,014,登録,送料1290                  \1,290")
            writer.WriteLine("20200205,113326,000100,015,登録,小　計                    \6,540")
            writer.WriteLine("20200205,113326,000100,016,登録,合計 6点                  \6,540")
            writer.WriteLine("20200205,113326,000100,017,登録,(内課税10%               \6,540)")
            writer.WriteLine("20200205,113326,000100,018,登録,(　内消費税10%             \594)")
            writer.WriteLine("20200205,113326,000100,019,登録,(消費税計                  \594)")
            writer.WriteLine("20200205,113326,000100,020,登録,お預り                   \10,000")
            writer.WriteLine("20200205,113326,000100,021,登録,お釣り                    \3,460")
            writer.WriteLine("20200205,113326,000100,022,登録,ﾚｼｰﾄ№000100            ﾚｼﾞ:0021")
            writer.WriteLine("20200205,113326,000100,023,登録,担当:渡辺　富幸         店 :0000")
            writer.WriteLine("20200205,113326,000100,024,登録,客層 99 その他                  ")
            writer.WriteLine("20200205,113326,000100,025,登録,────────────────")
            writer.WriteLine("20200205,164723,000000,001,停止,ｻｲﾝｵﾝ 004:渡辺　富幸            ")
            writer.WriteLine("20200205,164723,000000,002,停止,────────────────")
            writer.WriteLine("20200206,140401,000000,001,停止,ｻｲﾝｵﾝ 004:渡辺　富幸            ")
            writer.WriteLine("20200206,140401,000000,002,停止,────────────────")
            writer.WriteLine("20200206,140528,000000,001,停止,ｻｲﾝｵﾝ 004:渡辺　富幸            ")
            writer.WriteLine("20200206,140528,000000,002,停止,────────────────")
            writer.WriteLine("20200206,140745,000000,001,停止,ｻｲﾝｵﾝ 004:渡辺　富幸            ")
            writer.WriteLine("20200206,140745,000000,002,停止,────────────────")
            writer.WriteLine("20200206,140810,000000,001,停止,                                ")
            writer.WriteLine("20200206,140810,000000,002,停止,────────────────")
            writer.WriteLine("20200206,140813,000000,001,停止,ｻｲﾝｵﾝ 004:渡辺　富幸            ")
            writer.WriteLine("20200206,140813,000000,002,停止,────────────────")
            writer.WriteLine("20200206,140838,100001,001,点検,                                ")
            writer.WriteLine("20200206,140838,100002,002,点検,────────────────")
            writer.WriteLine("20200206,140846,000000,001,停止,                                ")
            writer.WriteLine("20200206,140846,000000,002,停止,────────────────")
            writer.WriteLine("20200206,140854,000000,001,停止,ｻｲﾝｵﾝ 004:渡辺　富幸            ")
            writer.WriteLine("20200206,140854,000000,002,停止,────────────────")
            writer.WriteLine("20200207,101253,000000,001,停止,ｻｲﾝｵﾝ 004:渡辺　富幸            ")
            writer.WriteLine("20200207,101253,000000,002,停止,────────────────")
            writer.WriteLine("20200207,114309,100001,001,点検,                                ")
            writer.WriteLine("20200207,114309,100002,002,点検,品目別集計　 　集計             ")
            writer.WriteLine("20200207,114309,100003,003,点検,品目別集計　 　集計             ")
            writer.WriteLine("20200207,114309,100004,004,点検,品目別集計　 　集計             ")
            writer.WriteLine("20200207,114309,100005,005,点検,品目別集計　 　集計             ")
            writer.WriteLine("20200207,114309,100006,006,点検,品目別集計　 　集計             ")
            writer.WriteLine("20200207,114309,100007,007,点検,品目別集計　 　集計             ")
            writer.WriteLine("20200207,114309,100008,008,点検,品目別集計　 　集計             ")
            writer.WriteLine("20200207,114309,100009,009,点検,品目別集計　 　集計             ")
            writer.WriteLine("20200207,114309,100010,010,点検,品目別集計　 　集計             ")
            writer.WriteLine("20200207,114309,100011,011,点検,品目別集計　 　集計             ")
            writer.WriteLine("20200207,114309,100012,012,点検,品目別集計　 　集計             ")
            writer.WriteLine("20200207,114309,100013,013,点検,品目別集計　 　集計             ")
            writer.WriteLine("20200207,114309,100014,014,点検,品目別集計　 　集計             ")
            writer.WriteLine("20200207,114309,100015,015,点検,品目別集計　 　集計             ")
            writer.WriteLine("20200207,114309,100016,016,点検,品目別集計　 　集計             ")
            writer.WriteLine("20200207,114309,100017,017,点検,品目別集計　 　集計             ")
            writer.WriteLine("20200207,114309,100018,018,点検,品目別集計　 　集計             ")
            writer.WriteLine("20200207,114309,100019,019,点検,────────────────")
            writer.WriteLine("20200207,125325,100001,001,点検,                                ")
            writer.WriteLine("20200207,125325,100002,002,点検,部門別集計　 　集計             ")
            writer.WriteLine("20200207,125325,100003,003,点検,部門別集計　 　集計             ")
            writer.WriteLine("20200207,125325,100004,004,点検,品目別集計　 　集計             ")
            writer.WriteLine("20200207,125325,100005,005,点検,部門別集計　 　集計             ")
            writer.WriteLine("20200207,125325,100006,006,点検,品目別集計　 　集計             ")
            writer.WriteLine("20200207,125325,100007,007,点検,部門別集計　 　集計             ")
            writer.WriteLine("20200207,125325,100008,008,点検,────────────────")
            writer.WriteLine("20200207,143508,000000,001,停止,ｻｲﾝｵﾝ 004:渡辺　富幸            ")
            writer.WriteLine("20200207,143508,000000,002,停止,────────────────")
            writer.WriteLine("20200207,150747,000000,001,停止,ｻｲﾝｵﾝ 004:渡辺　富幸            ")
            writer.WriteLine("20200207,150747,000000,002,停止,────────────────")
            writer.WriteLine("20200207,155618,000000,001,停止,                                ")
            writer.WriteLine("20200207,155618,000000,002,停止,────────────────")
            writer.WriteLine("20200207,161218,000000,001,停止,ｻｲﾝｵﾝ 004:渡辺　富幸            ")
            writer.WriteLine("20200207,161218,000000,002,停止,────────────────")
            'writer.WriteLine("20200207,161225,100001,001,点検,                                ")
            'writer.WriteLine("20200207,161225,100002,002,点検,品目別集計　 　集計             ")
            'writer.WriteLine("20200207,161225,100003,003,点検,部門別集計　 　集計             ")
            'writer.WriteLine("20200207,161225,100004,004,点検,客層別集計　 　集計             ")
            'writer.WriteLine("20200207,161225,100005,005,点検,分類別集計 　　集計             ")
            'writer.WriteLine("20200207,161225,100006,006,点検,現金外取引集計 集計             ")
            'writer.WriteLine("20200207,161225,100007,007,点検,時間帯別集計 　集計             ")
            'writer.WriteLine("20200207,161225,100008,008,点検,会計集計  　   集計             ")
            'writer.WriteLine("20200207,161225,100009,009,点検,ジャーナル　   集計             ")
            'writer.WriteLine("20200207,161225,100010,010,点検,────────────────")
            'writer.WriteLine("20200207,162130,000000,001,停止,                                ")
            'writer.WriteLine("20200207,162130,000000,002,停止,────────────────")
            'writer.WriteLine("20200207,162133,000000,001,停止,ｻｲﾝｵﾝ 004:渡辺　富幸            ")
            'writer.WriteLine("20200207,162133,000000,002,停止,────────────────")
            'writer.WriteLine("20200207,162139,100001,001,点検,                                ")
            'writer.WriteLine("20200207,162139,100002,002,点検,────────────────")
            'writer.WriteLine("20200207,162156,100001,001,点検,                                ")
            'writer.WriteLine("20200207,162156,100002,002,点検,────────────────")
            'writer.WriteLine("20200207,162617,000000,001,停止,                                ")
            'writer.WriteLine("20200207,162617,000000,002,停止,────────────────")
            'writer.WriteLine("20200207,163139,000000,001,停止,ｻｲﾝｵﾝ 004:渡辺　富幸            ")
            'writer.WriteLine("20200207,163139,000000,002,停止,────────────────")
            'writer.WriteLine("20200207,170208,000000,001,停止,ｻｲﾝｵﾝ 004:渡辺　富幸            ")
            'writer.WriteLine("20200207,170208,000000,002,停止,────────────────")
            'writer.WriteLine("20200207,170212,100001,001,点検,                                ")
            'writer.WriteLine("20200207,170212,100002,002,点検,────────────────")
            'writer.WriteLine("20200207,172657,000000,001,停止,ｻｲﾝｵﾝ 004:渡辺　富幸            ")
            'writer.WriteLine("20200207,172657,000000,002,停止,────────────────")
            'writer.WriteLine("20200207,172704,000000,001,停止,                                ")
            'writer.WriteLine("20200207,172704,000000,002,停止,────────────────")
            'writer.WriteLine("20200207,172830,000000,001,停止,ｻｲﾝｵﾝ 001:武藤　和彦            ")
            'writer.WriteLine("20200207,172830,000000,002,停止,────────────────")
            'writer.WriteLine("20200207,172836,000000,001,停止,                                ")
            'writer.WriteLine("20200207,172836,000000,002,停止,────────────────")
            'writer.WriteLine("20200207,172837,000000,001,停止,ｻｲﾝｵﾝ 004:渡辺　富幸            ")
            'writer.WriteLine("20200207,172837,000000,002,停止,────────────────")
            'writer.WriteLine("20200207,173207,000000,001,停止,                                ")
            'writer.WriteLine("20200207,173207,000000,002,停止,────────────────")
            'writer.WriteLine("20200207,182203,000000,001,停止,ｻｲﾝｵﾝ 004:渡辺　富幸            ")
            'writer.WriteLine("20200207,182203,000000,002,停止,────────────────")
            'writer.WriteLine("20200207,212311,000000,001,停止,ｻｲﾝｵﾝ 004:渡辺　富幸            ")
            'writer.WriteLine("20200207,212311,000000,002,停止,────────────────")
            'writer.WriteLine("20200207,212321,100001,001,点検,                                ")
            'writer.WriteLine("20200207,212321,100002,002,点検,品目別集計　 　集計             ")
            'writer.WriteLine("20200207,212321,100003,003,点検,品目別集計　 　集計             ")
            'writer.WriteLine("20200207,212321,100004,004,点検,品目別集計　 　集計             ")
            'writer.WriteLine("20200207,212321,100005,005,点検,会計集計  　   集計             ")
            'writer.WriteLine("20200207,212321,100006,006,点検,────────────────")
            'writer.WriteLine("20200207,212831,100001,001,点検,                                ")
            'writer.WriteLine("20200207,212831,100002,002,点検,────────────────")
            'writer.WriteLine("20200210,111202,000000,001,停止,ｻｲﾝｵﾝ 004:渡辺　富幸            ")
            'writer.WriteLine("20200210,111202,000000,002,停止,────────────────")
            'writer.WriteLine("20200210,113944,000000,001,停止,                                ")
            'writer.WriteLine("20200210,113944,000000,002,停止,────────────────")
            'writer.WriteLine("20200210,113946,000000,001,停止,ｻｲﾝｵﾝ 004:渡辺　富幸            ")
            'writer.WriteLine("20200210,113946,000000,002,停止,────────────────")
            'writer.WriteLine("20200210,113949,100001,001,点検,                                ")
            'writer.WriteLine("20200210,113949,100002,002,点検,────────────────")
            'writer.WriteLine("20200210,122543,100001,001,点検,                                ")
            'writer.WriteLine("20200210,122543,100002,002,点検,現金外取引集計 集計             ")
            'writer.WriteLine("20200210,122543,100003,003,点検,────────────────")
            'writer.WriteLine("20200212,144039,000000,001,停止,ｻｲﾝｵﾝ 004:渡辺　富幸            ")
            'writer.WriteLine("20200212,144039,000000,002,停止,────────────────")
            'writer.WriteLine("20200212,144045,100001,001,点検,                                ")
            'writer.WriteLine("20200212,144045,100002,002,点検,────────────────")
            'writer.WriteLine("20200213,122431,000000,001,停止,ｻｲﾝｵﾝ 004:渡辺　富幸            ")
            'writer.WriteLine("20200213,122431,000000,002,停止,────────────────")
            'writer.WriteLine("20200213,151826,000000,001,停止,ｻｲﾝｵﾝ 004:渡辺　富幸            ")
            'writer.WriteLine("20200213,151826,000000,002,停止,────────────────")
            'writer.WriteLine("20200214,115039,000000,001,停止,ｻｲﾝｵﾝ 004:渡辺　富幸            ")
            'writer.WriteLine("20200214,115039,000000,002,停止,────────────────")
            'writer.WriteLine("20200217,141844,000000,001,停止,ｻｲﾝｵﾝ 004:渡辺　富幸            ")
            'writer.WriteLine("20200217,141844,000000,002,停止,────────────────")
            'writer.WriteLine("20200217,161416,000000,001,停止,ｻｲﾝｵﾝ 004:渡辺　富幸            ")
            'writer.WriteLine("20200217,161416,000000,002,停止,────────────────")
            'writer.WriteLine("20200218,110047,000000,001,停止,ｻｲﾝｵﾝ 004:渡辺　富幸            ")
            'writer.WriteLine("20200218,110047,000000,002,停止,────────────────")
            'writer.WriteLine("20200218,134331,000000,001,停止,ｻｲﾝｵﾝ 004:渡辺　富幸            ")
            'writer.WriteLine("20200218,134331,000000,002,停止,────────────────")
            'writer.WriteLine("20200218,134419,000000,001,停止,ｻｲﾝｵﾝ 004:渡辺　富幸            ")
            'writer.WriteLine("20200218,134419,000000,002,停止,────────────────")
            'writer.WriteLine("20200218,134428,000101,001,登録,2020年02月18日(火)      13時44分")
            'writer.WriteLine("20200218,134428,000101,002,登録,           領　収　書           ")
            'writer.WriteLine("20200218,134428,000101,003,登録,2300000313505                   ")
            'writer.WriteLine("20200218,134428,000101,004,登録,じゃらん６９０              \690")
            'writer.WriteLine("20200218,134428,000101,005,登録,2300000313512                   ")
            'writer.WriteLine("20200218,134428,000101,006,登録,じゃらん４９０              \490")
            'writer.WriteLine("20200218,134428,000101,007,登録,------------- 取消 -------------")
            'writer.WriteLine("20200218,134428,000101,008,登録,2400000000846                   ")
            'writer.WriteLine("20200218,134428,000101,009,登録,全国版高速道路地図            \0")
            'writer.WriteLine("20200218,134428,000101,010,登録,小　計                    \1,180")
            'writer.WriteLine("20200218,134428,000101,011,登録,合計 2点                  \1,180")
            'writer.WriteLine("20200218,134428,000101,012,登録,(内課税10%               \1,180)")
            'writer.WriteLine("20200218,134428,000101,013,登録,(　内消費税10%             \107)")
            'writer.WriteLine("20200218,134428,000101,014,登録,(消費税計                  \107)")
            'writer.WriteLine("20200218,134428,000101,015,登録,お預り                   \10,000")
            'writer.WriteLine("20200218,134428,000101,016,登録,お釣り                    \8,820")
            'writer.WriteLine("20200218,134428,000101,017,登録,ﾚｼｰﾄ№000101            ﾚｼﾞ:0021")
            'writer.WriteLine("20200218,134428,000101,018,登録,担当:渡辺　富幸         店 :0000")
            'writer.WriteLine("20200218,134428,000101,019,登録,客層 99 その他                  ")
            'writer.WriteLine("20200218,134428,000101,020,登録,────────────────")
            'writer.WriteLine("20200219,112358,000000,001,停止,ｻｲﾝｵﾝ 004:渡辺　富幸            ")
            'writer.WriteLine("20200219,112358,000000,002,停止,────────────────")
            'writer.WriteLine("20200220,151425,000000,001,停止,ｻｲﾝｵﾝ 004:渡辺　富幸            ")
            'writer.WriteLine("20200220,151425,000000,002,停止,────────────────")
            'writer.WriteLine("20200221,145539,000000,001,停止,ｻｲﾝｵﾝ 004:渡辺　富幸            ")
            'writer.WriteLine("20200221,145539,000000,002,停止,────────────────")
            'writer.WriteLine("20200221,165445,000000,001,停止,ｻｲﾝｵﾝ 004:渡辺　富幸            ")
            'writer.WriteLine("20200221,165445,000000,002,停止,────────────────")
            'writer.WriteLine("20200225,102929,000000,001,停止,ｻｲﾝｵﾝ 004:渡辺　富幸            ")
            'writer.WriteLine("20200225,102929,000000,002,停止,────────────────")
            'writer.WriteLine("20200226,123803,000000,001,停止,ｻｲﾝｵﾝ 004:渡辺　富幸            ")
            'writer.WriteLine("20200226,123803,000000,002,停止,────────────────")
            'writer.WriteLine("20200228,194131,000000,001,停止,ｻｲﾝｵﾝ 004:渡辺　富幸            ")
            'writer.WriteLine("20200228,194131,000000,002,停止,────────────────")
            'writer.WriteLine("20200228,194145,100001,001,点検,                                ")
            'writer.WriteLine("20200228,194145,100002,002,点検,品目別集計　 　集計             ")
            'writer.WriteLine("20200228,194145,100003,003,点検,部門別集計　 　集計             ")
            'writer.WriteLine("20200228,194145,100004,004,点検,客層別集計　 　集計             ")
            'writer.WriteLine("20200228,194145,100005,005,点検,分類別集計 　　集計             ")
            'writer.WriteLine("20200228,194145,100006,006,点検,現金外取引集計 集計             ")
            'writer.WriteLine("20200228,194145,100007,007,点検,時間帯別集計 　集計             ")
            'writer.WriteLine("20200228,194145,100008,008,点検,会計集計  　   集計             ")
            'writer.WriteLine("20200228,194145,100009,009,点検,ジャーナル　   集計             ")
            'writer.WriteLine("20200228,194145,100010,010,点検,品目別集計　 　集計             ")
            'writer.WriteLine("20200228,194145,100011,011,点検,分類別集計 　　集計             ")
            'writer.WriteLine("20200228,194145,100012,012,点検,客層別集計　 　集計             ")
            'writer.WriteLine("20200228,194145,100013,013,点検,現金外取引集計 集計             ")
            'writer.WriteLine("20200228,194145,100014,014,点検,時間帯別集計 　集計             ")
            'writer.WriteLine("20200228,194145,100015,015,点検,会計集計  　   集計             ")
            'writer.WriteLine("20200228,194145,100016,016,点検,ジャーナル　   集計             ")
            'writer.WriteLine("20200228,194145,100017,017,点検,ジャーナル　   集計             ")
            'writer.WriteLine("20200228,194145,100018,018,点検,現金外取引集計 集計             ")
            'writer.WriteLine("20200228,194145,100019,019,点検,品目別集計　 　集計             ")
            'writer.WriteLine("20200228,194145,100020,020,点検,────────────────")
            'writer.WriteLine("20200228,202414,000000,001,停止,ｻｲﾝｵﾝ 004:渡辺　富幸            ")
            'writer.WriteLine("20200228,202414,000000,002,停止,────────────────")
            'writer.WriteLine("20200228,202420,100001,001,点検,                                ")
            'writer.WriteLine("20200228,202420,100002,002,点検,品目別集計　 　集計             ")
            'writer.WriteLine("20200228,202420,100003,003,点検,品目別集計　 　集計             ")
            'writer.WriteLine("20200228,202420,100004,004,点検,部門別集計　 　集計             ")
            'writer.WriteLine("20200228,202420,100005,005,点検,品目別集計　 　集計             ")
            'writer.WriteLine("20200228,202420,100006,006,点検,部門別集計　 　集計             ")
            'writer.WriteLine("20200228,202420,100007,007,点検,会計集計  　   集計             ")
            'writer.WriteLine("20200228,202420,100008,008,点検,品目別集計　 　集計             ")
            'writer.WriteLine("20200228,202420,100009,009,点検,部門別集計　 　集計             ")
            'writer.WriteLine("20200228,202420,100010,010,点検,会計集計  　   集計             ")
            'writer.WriteLine("20200228,202420,100011,011,点検,品目別集計　 　集計             ")
            'writer.WriteLine("20200228,202420,100012,012,点検,客層別集計　 　集計             ")
            'writer.WriteLine("20200228,202420,100013,013,点検,────────────────")
            'writer.WriteLine("20200228,222048,000000,001,停止,ｻｲﾝｵﾝ 001:武藤　和彦            ")
            'writer.WriteLine("20200228,222048,000000,002,停止,────────────────")
            'writer.WriteLine("20200228,222407,000000,001,停止,                                ")
            'writer.WriteLine("20200228,222407,000000,002,停止,────────────────")
            'writer.WriteLine("20200228,222410,000000,001,停止,ｻｲﾝｵﾝ 004:渡辺　富幸            ")
            'writer.WriteLine("20200228,222410,000000,002,停止,────────────────")
            'writer.WriteLine("20200228,222417,100001,001,点検,                                ")
            'writer.WriteLine("20200228,222417,100002,002,点検,ジャーナル　   集計             ")
            'writer.WriteLine("20200228,222417,100003,003,点検,────────────────")
            'writer.WriteLine("20200304,140306,000000,001,停止,ｻｲﾝｵﾝ 004:渡辺　富幸            ")
            'writer.WriteLine("20200304,140306,000000,002,停止,────────────────")
            'writer.WriteLine("20200304,140728,000000,001,停止,ｻｲﾝｵﾝ 004:渡辺　富幸            ")
            'writer.WriteLine("20200304,140728,000000,002,停止,────────────────")
            'writer.WriteLine("20200304,142614,000000,001,停止,ｻｲﾝｵﾝ 004:渡辺　富幸            ")
            'writer.WriteLine("20200304,142614,000000,002,停止,────────────────")
            'writer.WriteLine("20200304,152303,000000,001,停止,ｻｲﾝｵﾝ 004:渡辺　富幸            ")
            'writer.WriteLine("20200304,152303,000000,002,停止,────────────────")
            'writer.WriteLine("20200304,180026,000000,001,停止,ｻｲﾝｵﾝ 004:渡辺　富幸            ")
            'writer.WriteLine("20200304,180026,000000,002,停止,────────────────")
            'writer.WriteLine("20200304,180057,000000,001,停止,ｻｲﾝｵﾝ 004:渡辺　富幸            ")
            'writer.WriteLine("20200304,180057,000000,002,停止,────────────────")
            'writer.WriteLine("20200304,180101,100001,001,点検,                                ")
            'writer.WriteLine("20200304,180101,100002,002,点検,品目別集計　 　集計             ")
            'writer.WriteLine("20200304,180101,100003,003,点検,会計集計  　   集計             ")
            'writer.WriteLine("20200304,180101,100004,004,点検,品目別集計　 　集計             ")
            'writer.WriteLine("20200304,180101,100005,005,点検,部門別集計　 　集計             ")
            'writer.WriteLine("20200304,180101,100006,006,点検,品目別集計　 　集計             ")
            'writer.WriteLine("20200304,180101,100007,007,点検,部門別集計　 　集計             ")
            'writer.WriteLine("20200304,180101,100008,008,点検,客層別集計　 　集計             ")
            'writer.WriteLine("20200304,180101,100009,009,点検,分類別集計 　　集計             ")
            'writer.WriteLine("20200304,180101,100010,010,点検,会計集計  　   集計             ")
            'writer.WriteLine("20200304,180101,100011,011,点検,会計集計  　   集計             ")
            'writer.WriteLine("20200304,180101,100012,012,点検,会計集計  　   集計             ")
            'writer.WriteLine("20200304,180101,100013,013,点検,会計集計  　   集計             ")
            'writer.WriteLine("20200304,180101,100014,014,点検,────────────────")
            'writer.WriteLine("20200304,181003,000000,001,停止,ｻｲﾝｵﾝ 004:渡辺　富幸            ")
            'writer.WriteLine("20200304,181003,000000,002,停止,────────────────")
            'writer.WriteLine("20200304,181011,100001,001,点検,                                ")
            'writer.WriteLine("20200304,181011,100002,002,点検,────────────────")
            'writer.WriteLine("20200304,192937,000000,001,停止,ｻｲﾝｵﾝ 004:渡辺　富幸            ")
            'writer.WriteLine("20200304,192937,000000,002,停止,────────────────")
            'writer.WriteLine("20200304,202955,000000,001,停止,ｻｲﾝｵﾝ 004:渡辺　富幸            ")
            'writer.WriteLine("20200304,202955,000000,002,停止,────────────────")
            'writer.WriteLine("20200304,202959,100001,001,点検,                                ")
            'writer.WriteLine("20200304,202959,100002,002,点検,ジャーナル　   集計             ")
            'writer.WriteLine("20200304,202959,100003,003,点検,ジャーナル　   集計             ")
            'writer.WriteLine("20200304,202959,100004,004,点検,ジャーナル　   集計             ")
            'writer.WriteLine("20200304,202959,100005,005,点検,ジャーナル　   集計             ")
            'writer.WriteLine("20200304,202959,100006,006,点検,ジャーナル　   集計             ")
            'writer.WriteLine("20200304,202959,100007,007,点検,ジャーナル　   集計             ")
            'writer.WriteLine("20200304,202959,100008,008,点検,────────────────")
            'writer.WriteLine("20200306,215632,000000,001,停止,ｻｲﾝｵﾝ 004:渡辺　富幸            ")
            'writer.WriteLine("20200306,215632,000000,002,停止,────────────────")
            'writer.WriteLine("20200307,000222,000000,001,停止,ｻｲﾝｵﾝ 001:武藤　和彦            ")
            'writer.WriteLine("20200307,000222,000000,002,停止,────────────────")
            'writer.WriteLine("20200307,000249,000000,001,停止,ｻｲﾝｵﾝ 004:渡辺　富幸            ")
            'writer.WriteLine("20200307,000249,000000,002,停止,────────────────")
            'writer.WriteLine("20200307,000253,100001,001,点検,                                ")
            'writer.WriteLine("20200307,000253,100002,002,点検,────────────────")
            'writer.WriteLine("20200307,002023,000000,001,停止,ｻｲﾝｵﾝ 001:武藤　和彦            ")
            'writer.WriteLine("20200307,002023,000000,002,停止,────────────────")
            'writer.WriteLine("20200307,002242,000000,001,停止,ｻｲﾝｵﾝ 001:武藤　和彦            ")
            'writer.WriteLine("20200307,002242,000000,002,停止,────────────────")
            'writer.WriteLine("20200307,002249,000102,001,登録,2020年03月07日(土)      00時22分")
            'writer.WriteLine("20200307,002249,000102,002,登録,           両　　　替           ")
            'writer.WriteLine("20200307,002249,000102,003,登録,ﾚｼｰﾄ№000102            ﾚｼﾞ:0021")
            'writer.WriteLine("20200307,002249,000102,004,登録,担当:武藤　和彦         店 :0000")
            'writer.WriteLine("20200307,002249,000102,005,登録,客層 99 その他                  ")
            'writer.WriteLine("20200307,002249,000102,006,登録,────────────────")
            'writer.WriteLine("20200307,002253,000000,001,停止,                                ")
            'writer.WriteLine("20200307,002253,000000,002,停止,────────────────")
            'writer.WriteLine("20200307,002256,000000,001,停止,ｻｲﾝｵﾝ 001:武藤　和彦            ")
            'writer.WriteLine("20200307,002256,000000,002,停止,────────────────")
            'writer.WriteLine("20200307,002316,000000,001,停止,                                ")
            'writer.WriteLine("20200307,002316,000000,002,停止,────────────────")
            'writer.WriteLine("20200307,002328,000000,001,停止,ｻｲﾝｵﾝ 001:武藤　和彦            ")
            'writer.WriteLine("20200307,002328,000000,002,停止,────────────────")
            'writer.WriteLine("20200307,002336,000000,001,停止,                                ")
            'writer.WriteLine("20200307,002336,000000,002,停止,────────────────")
            'writer.WriteLine("20200307,002340,000000,001,停止,ｻｲﾝｵﾝ 001:武藤　和彦            ")
            'writer.WriteLine("20200307,002340,000000,002,停止,────────────────")
            'writer.WriteLine("20200307,002349,000000,001,停止,                                ")
            'writer.WriteLine("20200307,002349,000000,002,停止,────────────────")
            'writer.WriteLine("20200307,002351,000000,001,停止,ｻｲﾝｵﾝ 004:渡辺　富幸            ")
            'writer.WriteLine("20200307,002351,000000,002,停止,────────────────")
            'writer.WriteLine("20200307,003018,000000,001,停止,ｻｲﾝｵﾝ 004:渡辺　富幸            ")
            'writer.WriteLine("20200307,003018,000000,002,停止,────────────────")
            'writer.WriteLine("20200307,003022,100001,001,点検,                                ")
            'writer.WriteLine("20200307,003022,100002,002,点検,────────────────")
            'writer.WriteLine("20200307,012939,000000,001,停止,                                ")
            'writer.WriteLine("20200307,012939,000000,002,停止,────────────────")
            'writer.WriteLine("20200307,012941,000000,001,停止,ｻｲﾝｵﾝ 004:渡辺　富幸            ")
            'writer.WriteLine("20200307,012941,000000,002,停止,────────────────")
            'writer.WriteLine("20200307,012946,100001,001,点検,                                ")
            'writer.WriteLine("20200307,012946,100002,002,点検,品目別集計　 　集計             ")
            'writer.WriteLine("20200307,012946,100003,003,点検,────────────────")
            'writer.WriteLine("20200307,212700,000000,001,停止,ｻｲﾝｵﾝ 004:渡辺　富幸            ")
            'writer.WriteLine("20200307,212700,000000,002,停止,────────────────")
            'writer.WriteLine("20200307,212706,100001,001,点検,                                ")
            'writer.WriteLine("20200307,212706,100002,002,点検,品目別集計　 　集計             ")
            'writer.WriteLine("20200307,212706,100003,003,点検,時間帯別集計 　集計             ")
            'writer.WriteLine("20200307,212706,100004,004,点検,現金外取引集計 集計             ")
            'writer.WriteLine("20200307,212706,100005,005,点検,分類別集計 　　集計             ")
            'writer.WriteLine("20200307,212706,100006,006,点検,客層別集計　 　集計             ")
            'writer.WriteLine("20200307,212706,100007,007,点検,部門別集計　 　集計             ")
            'writer.WriteLine("20200307,212706,100008,008,点検,品目別集計　 　集計             ")
            'writer.WriteLine("20200307,212706,100009,009,点検,時間帯別集計 　集計             ")
            'writer.WriteLine("20200307,212706,100010,010,点検,現金外取引集計 集計             ")
            'writer.WriteLine("20200307,212706,100011,011,点検,────────────────")
            'writer.WriteLine("20200309,110250,000000,001,停止,ｻｲﾝｵﾝ 004:渡辺　富幸            ")
            'writer.WriteLine("20200309,110250,000000,002,停止,────────────────")
            'writer.WriteLine("20200309,124500,000103,001,登消,2020年03月09日(月)      12時45分")
            'writer.WriteLine("20200309,124500,000103,002,登消,            一括取消            ")
            'writer.WriteLine("20200309,124500,000103,003,登消,送料1950                      \0")
            'writer.WriteLine("20200309,124500,000103,004,登消,合計                          \0")
            'writer.WriteLine("20200309,124500,000103,005,登消,ﾚｼｰﾄ№000103            ﾚｼﾞ:0021")
            'writer.WriteLine("20200309,124500,000103,006,登消,担当:渡辺　富幸         店 :0000")
            'writer.WriteLine("20200309,124500,000103,007,登消,客層 99 その他                  ")
            'writer.WriteLine("20200309,124500,000103,008,登消,────────────────")
            'writer.WriteLine("20200310,132754,000000,001,停止,ｻｲﾝｵﾝ 001:武藤　和彦            ")
            'writer.WriteLine("20200310,132754,000000,002,停止,────────────────")
            'writer.WriteLine("20200310,133310,000000,001,停止,ｻｲﾝｵﾝ 002:石橋　久美子          ")
            'writer.WriteLine("20200310,133310,000000,002,停止,────────────────")
            'writer.WriteLine("20200310,133319,000000,001,停止,                                ")
            'writer.WriteLine("20200310,133319,000000,002,停止,────────────────")
            'writer.WriteLine("20200310,133326,000000,001,停止,ｻｲﾝｵﾝ 002:石橋　久美子          ")
            'writer.WriteLine("20200310,133326,000000,002,停止,────────────────")
            'writer.WriteLine("20200310,133345,000000,001,停止,                                ")
            'writer.WriteLine("20200310,133345,000000,002,停止,────────────────")
            'writer.WriteLine("20200310,135800,000000,001,停止,ｻｲﾝｵﾝ 001:武藤　和彦            ")
            'writer.WriteLine("20200310,135800,000000,002,停止,────────────────")
            'writer.WriteLine("20200310,140038,000000,001,停止,ｻｲﾝｵﾝ 002:石橋　久美子          ")
            'writer.WriteLine("20200310,140038,000000,002,停止,────────────────")
            'writer.WriteLine("20200310,140107,000000,001,停止,                                ")
            'writer.WriteLine("20200310,140107,000000,002,停止,────────────────")
            'writer.WriteLine("20200310,140110,000000,001,停止,ｻｲﾝｵﾝ 001:武藤　和彦            ")
            'writer.WriteLine("20200310,140110,000000,002,停止,────────────────")
            'writer.WriteLine("20200310,140127,000000,001,停止,                                ")
            'writer.WriteLine("20200310,140127,000000,002,停止,────────────────")
            'writer.WriteLine("20200310,140232,000000,001,停止,ｻｲﾝｵﾝ 004:渡辺　富幸            ")
            'writer.WriteLine("20200310,140232,000000,002,停止,────────────────")
            'writer.WriteLine("20200311,164133,000000,001,停止,ｻｲﾝｵﾝ 004:渡辺　富幸            ")
            'writer.WriteLine("20200311,164133,000000,002,停止,────────────────")
            'writer.WriteLine("20200311,164141,100001,001,点検,                                ")
            'writer.WriteLine("20200311,164141,100002,002,点検,品目別集計　 　集計             ")
            'writer.WriteLine("20200311,164141,100003,003,点検,────────────────")
            'writer.WriteLine("20200311,164218,000104,001,登録,2020年03月11日(水)      16時42分")
            'writer.WriteLine("20200311,164218,000104,002,登録,           領　収　書           ")
            'writer.WriteLine("20200311,164218,000104,003,登録,2300000313505                   ")
            'writer.WriteLine("20200311,164218,000104,004,登録,じゃらん６９０              \690")
            'writer.WriteLine("20200311,164218,000104,005,登録,値引き                     \-500")
            'writer.WriteLine("20200311,164218,000104,006,登録,2300000313505                   ")
            'writer.WriteLine("20200311,164218,000104,007,登録,じゃらん６９０              \690")
            'writer.WriteLine("20200311,164218,000104,008,登録,2300000313512                   ")
            'writer.WriteLine("20200311,164218,000104,009,登録,じゃらん４９０              \490")
            'writer.WriteLine("20200311,164218,000104,010,登録,小　計                    \1,370")
            'writer.WriteLine("20200311,164218,000104,011,登録,合計 3点                  \1,370")
            'writer.WriteLine("20200311,164218,000104,012,登録,(内課税10%               \1,370)")
            'writer.WriteLine("20200311,164218,000104,013,登録,(　内消費税10%             \124)")
            'writer.WriteLine("20200311,164218,000104,014,登録,(消費税計                  \124)")
            'writer.WriteLine("20200311,164218,000104,015,登録,お預り                   \10,000")
            'writer.WriteLine("20200311,164218,000104,016,登録,お釣り                    \8,630")
            'writer.WriteLine("20200311,164218,000104,017,登録,ﾚｼｰﾄ№000104            ﾚｼﾞ:0021")
            'writer.WriteLine("20200311,164218,000104,018,登録,担当:渡辺　富幸         店 :0000")
            'writer.WriteLine("20200311,164218,000104,019,登録,客層 99 その他                  ")
            'writer.WriteLine("20200311,164218,000104,020,登録,────────────────")
            'writer.WriteLine("20200311,164508,100001,001,点検,                                ")
            'writer.WriteLine("20200311,164508,100002,002,点検,品目別集計　 　集計             ")
            'writer.WriteLine("20200311,164508,100003,003,点検,────────────────")
            'writer.WriteLine("20200311,181326,000000,001,停止,ｻｲﾝｵﾝ 004:渡辺　富幸            ")
            'writer.WriteLine("20200311,181326,000000,002,停止,────────────────")
            'writer.WriteLine("20200311,181331,000000,001,停止,                                ")
            'writer.WriteLine("20200311,181331,000000,002,停止,────────────────")
            'writer.WriteLine("20200311,181332,000000,001,停止,ｻｲﾝｵﾝ 004:渡辺　富幸            ")
            'writer.WriteLine("20200311,181332,000000,002,停止,────────────────")
            'writer.WriteLine("20200311,181337,100001,001,点検,                                ")
            'writer.WriteLine("20200311,181337,100002,002,点検,品目別集計　 　集計             ")
            'writer.WriteLine("20200311,181337,100003,003,点検,客層別集計　 　集計             ")
            'writer.WriteLine("20200311,181337,100004,004,点検,時間帯別集計 　集計             ")
            'writer.WriteLine("20200311,181337,100005,005,点検,客層別集計　 　集計             ")
            'writer.WriteLine("20200311,181337,100006,006,点検,時間帯別集計 　集計             ")
            'writer.WriteLine("20200311,181337,100007,007,点検,────────────────")
            'writer.WriteLine("20200311,193639,000000,001,停止,ｻｲﾝｵﾝ 001:武藤　和彦            ")
            'writer.WriteLine("20200311,193639,000000,002,停止,────────────────")
            'writer.WriteLine("20200311,195150,000000,001,停止,ｻｲﾝｵﾝ 004:渡辺　富幸            ")
            'writer.WriteLine("20200311,195150,000000,002,停止,────────────────")
            'writer.WriteLine("20200311,195154,100001,001,点検,                                ")
            'writer.WriteLine("20200311,195154,100002,002,点検,部門別集計　 　集計             ")
            'writer.WriteLine("20200311,195154,100003,003,点検,品目別集計　 　集計             ")
            'writer.WriteLine("20200311,195154,100004,004,点検,分類別集計 　　集計             ")
            'writer.WriteLine("20200311,195154,100005,005,点検,現金外取引集計 集計             ")
            'writer.WriteLine("20200311,195154,100006,006,点検,時間帯別集計 　集計             ")
            'writer.WriteLine("20200311,195154,100007,007,点検,部門別集計　 　集計             ")
            'writer.WriteLine("20200311,195154,100008,008,点検,品目別集計　 　集計             ")
            'writer.WriteLine("20200311,195154,100009,009,点検,部門別集計　 　集計             ")
            'writer.WriteLine("20200311,195154,100010,010,点検,客層別集計　 　集計             ")
            'writer.WriteLine("20200311,195154,100011,011,点検,時間帯別集計 　集計             ")
            'writer.WriteLine("20200311,195154,100012,012,点検,ジャーナル　   集計             ")
            'writer.WriteLine("20200311,195154,100013,013,点検,品目別集計　 　集計             ")
            'writer.WriteLine("20200311,195154,100014,014,点検,部門別集計　 　集計             ")
            'writer.WriteLine("20200311,195154,100015,015,点検,客層別集計　 　集計             ")
            'writer.WriteLine("20200311,195154,100016,016,点検,分類別集計 　　集計             ")
            'writer.WriteLine("20200311,195154,100017,017,点検,時間帯別集計 　集計             ")
            'writer.WriteLine("20200311,195154,100018,018,点検,会計集計  　   集計             ")
            'writer.WriteLine("20200311,195154,100019,019,点検,会計集計  　   集計             ")
            'writer.WriteLine("20200311,195154,100020,020,点検,ジャーナル　   集計             ")
            'writer.WriteLine("20200311,195154,100021,021,点検,時間帯別集計 　集計             ")
            'writer.WriteLine("20200311,195154,100022,022,点検,品目別集計　 　集計             ")
            'writer.WriteLine("20200311,195154,100023,023,点検,品目別集計　 　集計             ")
            'writer.WriteLine("20200311,195154,100024,024,点検,部門別集計　 　集計             ")
            'writer.WriteLine("20200311,195154,100025,025,点検,客層別集計　 　集計             ")
            'writer.WriteLine("20200311,195154,100026,026,点検,部門別集計　 　集計             ")
            'writer.WriteLine("20200311,195154,100027,027,点検,客層別集計　 　集計             ")
            'writer.WriteLine("20200311,195154,100028,028,点検,時間帯別集計 　集計             ")
            'writer.WriteLine("20200311,195154,100029,029,点検,品目別集計　 　集計             ")
            'writer.WriteLine("20200311,195154,100030,030,点検,部門別集計　 　集計             ")
            'writer.WriteLine("20200311,195154,100031,031,点検,客層別集計　 　集計             ")
            'writer.WriteLine("20200311,195154,100032,032,点検,現金外取引集計 集計             ")
            'writer.WriteLine("20200311,195154,100033,033,点検,品目別集計　 　集計             ")
            'writer.WriteLine("20200311,195154,100034,034,点検,時間帯別集計 　集計             ")
            'writer.WriteLine("20200311,195154,100035,035,点検,品目別集計　 　集計             ")
            'writer.WriteLine("20200311,195154,100036,036,点検,時間帯別集計 　集計             ")
            'writer.WriteLine("20200311,195154,100037,037,点検,分類別集計 　　集計             ")
            'writer.WriteLine("20200311,195154,100038,038,点検,時間帯別集計 　集計             ")
            'writer.WriteLine("20200311,195154,100039,039,点検,品目別集計　 　集計             ")
            'writer.WriteLine("20200311,195154,100040,040,点検,時間帯別集計 　集計             ")
            'writer.WriteLine("20200311,195154,100041,041,点検,ジャーナル　   集計             ")
            'writer.WriteLine("20200311,195154,100042,042,点検,部門別集計　 　集計             ")
            'writer.WriteLine("20200311,195154,100043,043,点検,品目別集計　 　集計             ")
            'writer.WriteLine("20200311,195154,100044,044,点検,時間帯別集計 　集計             ")
            'writer.WriteLine("20200311,195154,100045,045,点検,品目別集計　 　集計             ")
            'writer.WriteLine("20200311,195154,100046,046,点検,客層別集計　 　集計             ")
            'writer.WriteLine("20200311,195154,100047,047,点検,────────────────")
            'writer.WriteLine("20200311,201737,100001,001,点検,                                ")
            'writer.WriteLine("20200311,201737,100002,002,点検,品目別集計　 　集計             ")
            'writer.WriteLine("20200311,201737,100003,003,点検,────────────────")
            'writer.WriteLine("20200312,145529,000000,001,停止,ｻｲﾝｵﾝ 004:渡辺　富幸            ")
            'writer.WriteLine("20200312,145529,000000,002,停止,────────────────")
            'writer.WriteLine("20200313,102652,000000,001,停止,ｻｲﾝｵﾝ 004:渡辺　富幸            ")
            'writer.WriteLine("20200313,102652,000000,002,停止,────────────────")
            'writer.WriteLine("20200316,120140,000000,001,停止,ｻｲﾝｵﾝ 004:渡辺　富幸            ")
            'writer.WriteLine("20200316,120140,000000,002,停止,────────────────")
            'writer.WriteLine("20200317,143629,000000,001,停止,ｻｲﾝｵﾝ 004:渡辺　富幸            ")
            'writer.WriteLine("20200317,143629,000000,002,停止,────────────────")
            'writer.WriteLine("20200317,164218,000000,001,停止,ｻｲﾝｵﾝ 004:渡辺　富幸            ")
            'writer.WriteLine("20200317,164218,000000,002,停止,────────────────")
            'writer.WriteLine("20200317,164223,000105,001,登録,2020年03月17日(火)      16時42分")
            'writer.WriteLine("20200317,164223,000105,002,登録,           領　収　書           ")
            'writer.WriteLine("20200317,164223,000105,003,登録,2400000008705                   ")
            'writer.WriteLine("20200317,164223,000105,004,登録,送料830                     \830")
            'writer.WriteLine("20200317,164223,000105,005,登録,小　計                      \830")
            'writer.WriteLine("20200317,164223,000105,006,登録,合計 1点                    \830")
            'writer.WriteLine("20200317,164223,000105,007,登録,(内課税10%                 \830)")
            'writer.WriteLine("20200317,164223,000105,008,登録,(　内消費税10%              \75)")
            'writer.WriteLine("20200317,164223,000105,009,登録,(消費税計                   \75)")
            'writer.WriteLine("20200317,164223,000105,010,登録,お預り              \111,111,111")
            'writer.WriteLine("20200317,164223,000105,011,登録,お釣り              \111,110,281")
            'writer.WriteLine("20200317,164223,000105,012,登録,ﾚｼｰﾄ№000105            ﾚｼﾞ:0021")
            'writer.WriteLine("20200317,164223,000105,013,登録,担当:渡辺　富幸         店 :0000")
            'writer.WriteLine("20200317,164223,000105,014,登録,客層 99 その他                  ")
            'writer.WriteLine("20200317,164223,000105,015,登録,────────────────")
            'writer.WriteLine("20200317,164638,000106,001,登録,2020年03月17日(火)      16時46分")
            'writer.WriteLine("20200317,164638,000106,002,登録,           領　収　書           ")
            'writer.WriteLine("20200317,164638,000106,003,登録,2400000008712                   ")
            'writer.WriteLine("20200317,164638,000106,004,登録,送料940                     \940")
            'writer.WriteLine("20200317,164638,000106,005,登録,小　計                      \940")
            'writer.WriteLine("20200317,164638,000106,006,登録,合計 1点                    \940")
            'writer.WriteLine("20200317,164638,000106,007,登録,(内課税10%                 \940)")
            'writer.WriteLine("20200317,164638,000106,008,登録,(　内消費税10%              \85)")
            'writer.WriteLine("20200317,164638,000106,009,登録,(消費税計                   \85)")
            'writer.WriteLine("20200317,164638,000106,010,登録,お預り                    \1,000")
            'writer.WriteLine("20200317,164638,000106,011,登録,お釣り                       \60")
            'writer.WriteLine("20200317,164638,000106,012,登録,ﾚｼｰﾄ№000106            ﾚｼﾞ:0021")
            'writer.WriteLine("20200317,164638,000106,013,登録,担当:渡辺　富幸         店 :0000")
            'writer.WriteLine("20200317,164638,000106,014,登録,客層 99 その他                  ")
            'writer.WriteLine("20200317,164638,000106,015,登録,────────────────")
            'writer.WriteLine("20200318,132326,000000,001,停止,ｻｲﾝｵﾝ 004:渡辺　富幸            ")
            'writer.WriteLine("20200318,132326,000000,002,停止,────────────────")
            'writer.WriteLine("20200318,135208,000000,001,停止,ｻｲﾝｵﾝ 004:渡辺　富幸            ")
            'writer.WriteLine("20200318,135208,000000,002,停止,────────────────")
            'writer.WriteLine("20200318,135224,000103,001,再レ,2020年03月09日(月)      12時45分")
            'writer.WriteLine("20200318,135224,000103,002,再レ,            一括取消            ")
            'writer.WriteLine("20200318,135224,000103,003,再レ,送料1950                      \0")
            'writer.WriteLine("20200318,135224,000103,004,再レ,合計                          \0")
            'writer.WriteLine("20200318,135224,000103,005,再レ,ﾚｼｰﾄ№000103*           ﾚｼﾞ:0021")
            'writer.WriteLine("20200318,135224,000103,006,再レ,担当:渡辺　富幸         店 :0000")
            'writer.WriteLine("20200318,135224,000103,007,再レ,客層 99 その他                  ")
            'writer.WriteLine("20200318,135224,000103,008,再レ,────────────────")
            'writer.WriteLine("20200318,135307,000106,001,再レ,2020年03月17日(火)      16時46分")
            'writer.WriteLine("20200318,135307,000106,002,再レ,           領　収　書           ")
            'writer.WriteLine("20200318,135307,000106,003,再レ,2400000008712                   ")
            'writer.WriteLine("20200318,135307,000106,004,再レ,送料940                     \940")
            'writer.WriteLine("20200318,135307,000106,005,再レ,小　計                      \940")
            'writer.WriteLine("20200318,135307,000106,006,再レ,合計 1点                    \940")
            'writer.WriteLine("20200318,135307,000106,007,再レ,(内課税10%                 \940)")
            'writer.WriteLine("20200318,135307,000106,008,再レ,(　内消費税10%              \85)")
            'writer.WriteLine("20200318,135307,000106,009,再レ,(消費税計                   \85)")
            'writer.WriteLine("20200318,135307,000106,010,再レ,お預り                    \1,000")
            'writer.WriteLine("20200318,135307,000106,011,再レ,お釣り                       \60")
            'writer.WriteLine("20200318,135307,000106,012,再レ,ﾚｼｰﾄ№000106*           ﾚｼﾞ:0021")
            'writer.WriteLine("20200318,135307,000106,013,再レ,担当:渡辺　富幸         店 :0000")
            'writer.WriteLine("20200318,135307,000106,014,再レ,客層 99 その他                  ")
            'writer.WriteLine("20200318,135307,000106,015,再レ,────────────────")
            'writer.WriteLine("20200318,135435,000101,001,再レ,2020年02月18日(火)      13時44分")
            'writer.WriteLine("20200318,135435,000101,002,再レ,           領　収　書           ")
            'writer.WriteLine("20200318,135435,000101,003,再レ,2300000313505                   ")
            'writer.WriteLine("20200318,135435,000101,004,再レ,じゃらん６９０              \690")
            'writer.WriteLine("20200318,135435,000101,005,再レ,2300000313512                   ")
            'writer.WriteLine("20200318,135435,000101,006,再レ,じゃらん４９０              \490")
            'writer.WriteLine("20200318,135435,000101,007,再レ,------------- 取消 -------------")
            'writer.WriteLine("20200318,135435,000101,008,再レ,2400000000846                   ")
            'writer.WriteLine("20200318,135435,000101,009,再レ,全国版高速道路地図            \0")
            'writer.WriteLine("20200318,135435,000101,010,再レ,小　計                    \1,180")
            'writer.WriteLine("20200318,135435,000101,011,再レ,合計 2点                  \1,180")
            'writer.WriteLine("20200318,135435,000101,012,再レ,(内課税10%               \1,180)")
            'writer.WriteLine("20200318,135435,000101,013,再レ,(　内消費税10%             \107)")
            'writer.WriteLine("20200318,135435,000101,014,再レ,(消費税計                  \107)")
            'writer.WriteLine("20200318,135435,000101,015,再レ,お預り                   \10,000")
            'writer.WriteLine("20200318,135435,000101,016,再レ,お釣り                    \8,820")
            'writer.WriteLine("20200318,135435,000101,017,再レ,ﾚｼｰﾄ№000101*           ﾚｼﾞ:0021")
            'writer.WriteLine("20200318,135435,000101,018,再レ,担当:渡辺　富幸         店 :0000")
            'writer.WriteLine("20200318,135435,000101,019,再レ,客層 99 その他                  ")
            'writer.WriteLine("20200318,135435,000101,020,再レ,────────────────")
            'writer.WriteLine("20200318,135443,000102,001,再レ,2020年03月07日(土)      00時22分")
            'writer.WriteLine("20200318,135443,000102,002,再レ,           両　　　替           ")
            'writer.WriteLine("20200318,135443,000102,003,再レ,ﾚｼｰﾄ№000102*           ﾚｼﾞ:0021")
            'writer.WriteLine("20200318,135443,000102,004,再レ,担当:武藤　和彦         店 :0000")
            'writer.WriteLine("20200318,135443,000102,005,再レ,────────────────")
            'writer.WriteLine("20200318,135500,000100,001,再レ,2020年02月05日(水)      11時33分")
            'writer.WriteLine("20200318,135500,000100,002,再レ,           領　収　書           ")
            'writer.WriteLine("20200318,135500,000100,003,再レ,2400000008705                   ")
            'writer.WriteLine("20200318,135500,000100,004,再レ,送料830                     \830")
            'writer.WriteLine("20200318,135500,000100,005,再レ,2400000008712                   ")
            'writer.WriteLine("20200318,135500,000100,006,再レ,送料940                     \940")
            'writer.WriteLine("20200318,135500,000100,007,再レ,2400000008729                   ")
            'writer.WriteLine("20200318,135500,000100,008,再レ,送料1050                  \1,050")
            'writer.WriteLine("20200318,135500,000100,009,再レ,2400000008736                   ")
            'writer.WriteLine("20200318,135500,000100,010,再レ,送料1160                  \1,160")
            'writer.WriteLine("20200318,135500,000100,011,再レ,2400000008743                   ")
            'writer.WriteLine("20200318,135500,000100,012,再レ,送料1270                  \1,270")
            'writer.WriteLine("20200318,135500,000100,013,再レ,2400000008750                   ")
            'writer.WriteLine("20200318,135500,000100,014,再レ,送料1290                  \1,290")
            'writer.WriteLine("20200318,135500,000100,015,再レ,小　計                    \6,540")
            'writer.WriteLine("20200318,135500,000100,016,再レ,合計 6点                  \6,540")
            'writer.WriteLine("20200318,135500,000100,017,再レ,(内課税10%               \6,540)")
            'writer.WriteLine("20200318,135500,000100,018,再レ,(　内消費税10%             \594)")
            'writer.WriteLine("20200318,135500,000100,019,再レ,(消費税計                  \594)")
            'writer.WriteLine("20200318,135500,000100,020,再レ,お預り                   \10,000")
            'writer.WriteLine("20200318,135500,000100,021,再レ,お釣り                    \3,460")
            'writer.WriteLine("20200318,135500,000100,022,再レ,ﾚｼｰﾄ№000100*           ﾚｼﾞ:0021")
            'writer.WriteLine("20200318,135500,000100,023,再レ,担当:渡辺　富幸         店 :0000")
            'writer.WriteLine("20200318,135500,000100,024,再レ,客層 99 その他                  ")
            'writer.WriteLine("20200318,135500,000100,025,再レ,────────────────")
            'writer.WriteLine("20200318,135532,000104,001,再レ,2020年03月11日(水)      16時42分")
            'writer.WriteLine("20200318,135532,000104,002,再レ,           領　収　書           ")
            'writer.WriteLine("20200318,135532,000104,003,再レ,2300000313505                   ")
            'writer.WriteLine("20200318,135532,000104,004,再レ,じゃらん６９０              \690")
            'writer.WriteLine("20200318,135532,000104,005,再レ,値引き                     \-500")
            'writer.WriteLine("20200318,135532,000104,006,再レ,2300000313505                   ")
            'writer.WriteLine("20200318,135532,000104,007,再レ,じゃらん６９０              \690")
            'writer.WriteLine("20200318,135532,000104,008,再レ,2300000313512                   ")
            'writer.WriteLine("20200318,135532,000104,009,再レ,じゃらん４９０              \490")
            'writer.WriteLine("20200318,135532,000104,010,再レ,小　計                    \1,370")
            'writer.WriteLine("20200318,135532,000104,011,再レ,合計 3点                  \1,370")
            'writer.WriteLine("20200318,135532,000104,012,再レ,(内課税10%               \1,370)")
            'writer.WriteLine("20200318,135532,000104,013,再レ,(　内消費税10%             \124)")
            'writer.WriteLine("20200318,135532,000104,014,再レ,(消費税計                  \124)")
            'writer.WriteLine("20200318,135532,000104,015,再レ,お預り                   \10,000")
            'writer.WriteLine("20200318,135532,000104,016,再レ,お釣り                    \8,630")
            'writer.WriteLine("20200318,135532,000104,017,再レ,ﾚｼｰﾄ№000104*           ﾚｼﾞ:0021")
            'writer.WriteLine("20200318,135532,000104,018,再レ,担当:渡辺　富幸         店 :0000")
            'writer.WriteLine("20200318,135532,000104,019,再レ,客層 99 その他                  ")
            'writer.WriteLine("20200318,135532,000104,020,再レ,────────────────")
            'writer.WriteLine("20200319,170142,000000,001,停止,ｻｲﾝｵﾝ 001:武藤　和彦            ")
            'writer.WriteLine("20200319,170142,000000,002,停止,────────────────")
            'writer.WriteLine("20200319,170208,000000,001,停止,                                ")
            'writer.WriteLine("20200319,170208,000000,002,停止,────────────────")
            'writer.WriteLine("20200319,170217,000000,001,停止,ｻｲﾝｵﾝ 033:神田　康志            ")
            'writer.WriteLine("20200319,170217,000000,002,停止,────────────────")
            'writer.WriteLine("20200319,170227,000000,001,停止,                                ")
            'writer.WriteLine("20200319,170227,000000,002,停止,────────────────")
            'writer.WriteLine("20200319,170239,000000,001,停止,ｻｲﾝｵﾝ 004:渡辺　富幸            ")
            'writer.WriteLine("20200319,170239,000000,002,停止,────────────────")
            'writer.WriteLine("20200323,161223,000000,001,停止,ｻｲﾝｵﾝ 004:渡辺　富幸            ")
            'writer.WriteLine("20200323,161223,000000,002,停止,────────────────")
            'writer.WriteLine("20200323,174740,000000,001,停止,ｻｲﾝｵﾝ 004:渡辺　富幸            ")
            'writer.WriteLine("20200323,174740,000000,002,停止,────────────────")
            'writer.WriteLine("20200323,174747,100001,001,点検,                                ")
            'writer.WriteLine("20200323,174747,100002,002,点検,────────────────")
            'writer.WriteLine("20200324,110220,000000,001,停止,ｻｲﾝｵﾝ 001:武藤　和彦            ")
            'writer.WriteLine("20200324,110220,000000,002,停止,────────────────")
            'writer.WriteLine("20200324,192437,000107,001,登消,2020年03月24日(火)      19時24分")
            'writer.WriteLine("20200324,192437,000107,002,登消,            一括取消            ")
            'writer.WriteLine("20200324,192437,000107,003,登消,2400000008705                   ")
            'writer.WriteLine("20200324,192437,000107,004,登消,送料830                         ")
            'writer.WriteLine("20200324,192437,000107,005,登消,  @830×2                 \1,660")
            'writer.WriteLine("20200324,192437,000107,006,登消,小　計                    \1,660")
            'writer.WriteLine("20200324,192437,000107,007,登消,合計 2点                  \1,660")
            'writer.WriteLine("20200324,192437,000107,008,登消,(内課税10%               \1,660)")
            'writer.WriteLine("20200324,192437,000107,009,登消,(　内消費税10%             \150)")
            'writer.WriteLine("20200324,192437,000107,010,登消,(消費税計                  \150)")
            'writer.WriteLine("20200324,192437,000107,011,登消,ﾚｼｰﾄ№000107            ﾚｼﾞ:0021")
            'writer.WriteLine("20200324,192437,000107,012,登消,担当:武藤　和彦         店 :0000")
            'writer.WriteLine("20200324,192437,000107,013,登消,客層 99 その他                  ")
            'writer.WriteLine("20200324,192437,000107,014,登消,────────────────")
            'writer.WriteLine("20200326,194849,000000,001,停止,ｻｲﾝｵﾝ 004:渡辺　富幸            ")
            'writer.WriteLine("20200326,194849,000000,002,停止,────────────────")
            'writer.WriteLine("20200327,181431,000000,001,停止,ｻｲﾝｵﾝ 004:渡辺　富幸            ")
            'writer.WriteLine("20200327,181431,000000,002,停止,────────────────")
            'writer.WriteLine("20200327,182940,000000,001,停止,マスタ反映                      ")
            'writer.WriteLine("20200327,183429,000000,001,停止,ｻｲﾝｵﾝ 004:渡辺　富幸            ")
            'writer.WriteLine("20200327,183429,000000,002,停止,────────────────")
            'writer.WriteLine("20200327,184345,000000,001,停止,ｻｲﾝｵﾝ 004:渡辺　富幸            ")
            'writer.WriteLine("20200327,184345,000000,002,停止,────────────────")
            'writer.WriteLine("20200327,222012,000000,001,停止,ｻｲﾝｵﾝ 004:渡辺　富幸            ")
            'writer.WriteLine("20200327,222012,000000,002,停止,────────────────")
            'writer.WriteLine("20200327,223806,000000,001,停止,ｻｲﾝｵﾝ 004:渡辺　富幸            ")
            'writer.WriteLine("20200327,223806,000000,002,停止,────────────────")
            'writer.WriteLine("20200328,203351,000000,001,停止,ｻｲﾝｵﾝ 004:渡辺　富幸            ")
            'writer.WriteLine("20200328,203351,000000,002,停止,────────────────")
            'writer.WriteLine("20200328,203400,100001,001,点検,                                ")
            'writer.WriteLine("20200328,203400,100002,002,点検,客層別集計　 　集計             ")
            'writer.WriteLine("20200328,203400,100003,003,点検,分類別集計 　　集計             ")
            'writer.WriteLine("20200328,203400,100004,004,点検,部門別集計　 　集計             ")
            'writer.WriteLine("20200328,203400,100005,005,点検,現金外取引集計 集計             ")
            'writer.WriteLine("20200328,203400,100006,006,点検,────────────────")
            'writer.WriteLine("20200330,155707,000000,001,停止,ｻｲﾝｵﾝ 001:武藤　和彦            ")
            'writer.WriteLine("20200330,155707,000000,002,停止,────────────────")
            'writer.WriteLine("20200330,155805,000000,001,停止,ｻｲﾝｵﾝ 004:渡辺　富幸            ")
            'writer.WriteLine("20200330,155805,000000,002,停止,────────────────")
            'writer.WriteLine("20200330,160616,000000,001,停止,ｻｲﾝｵﾝ 004:渡辺　富幸            ")
            'writer.WriteLine("20200330,160616,000000,002,停止,────────────────")
            'writer.WriteLine("20200330,173135,000000,001,停止,ｻｲﾝｵﾝ 001:武藤　和彦            ")
            'writer.WriteLine("20200330,173135,000000,002,停止,────────────────")
            'writer.WriteLine("20200330,173213,000000,001,停止,ｻｲﾝｵﾝ 004:渡辺　富幸            ")
            'writer.WriteLine("20200330,173213,000000,002,停止,────────────────")
            'writer.WriteLine("20200331,140028,000000,001,停止,ｻｲﾝｵﾝ 001:武藤　和彦            ")
            'writer.WriteLine("20200331,140028,000000,002,停止,────────────────")
            'writer.WriteLine("20200331,140133,000000,001,停止,ｻｲﾝｵﾝ 004:渡辺　富幸            ")
            'writer.WriteLine("20200331,140133,000000,002,停止,────────────────")
            'writer.WriteLine("20200331,152731,000000,001,停止,ｻｲﾝｵﾝ 001:武藤　和彦            ")
            'writer.WriteLine("20200331,152731,000000,002,停止,────────────────")
            'writer.WriteLine("20200331,152910,000000,001,停止,ｻｲﾝｵﾝ 004:渡辺　富幸            ")
            'writer.WriteLine("20200331,152910,000000,002,停止,────────────────")
            'writer.WriteLine("20200402,140954,000000,001,停止,ｻｲﾝｵﾝ 004:渡辺　富幸            ")
            'writer.WriteLine("20200402,140954,000000,002,停止,────────────────")
            'writer.WriteLine("20200403,183949,000000,001,停止,ｻｲﾝｵﾝ 001:武藤　和彦            ")
            'writer.WriteLine("20200403,183949,000000,002,停止,────────────────")
            'writer.WriteLine("20200403,184047,000000,001,停止,ｻｲﾝｵﾝ 004:渡辺　富幸            ")
            'writer.WriteLine("20200403,184047,000000,002,停止,────────────────")
            'writer.WriteLine("20200403,185358,000000,001,停止,ｻｲﾝｵﾝ 004:渡辺　富幸            ")
            'writer.WriteLine("20200403,185358,000000,002,停止,────────────────")
            'writer.WriteLine("20200403,185924,000108,001,登消,2020年04月03日(金)      18時59分")
            'writer.WriteLine("20200403,185924,000108,002,登消,            一括取消            ")
            'writer.WriteLine("20200403,185924,000108,003,登消,送料1730                      \0")
            'writer.WriteLine("20200403,185924,000108,004,登消,合計                          \0")
            'writer.WriteLine("20200403,185924,000108,005,登消,ﾚｼｰﾄ№000108            ﾚｼﾞ:0021")
            'writer.WriteLine("20200403,185924,000108,006,登消,担当:渡辺　富幸         店 :0000")
            'writer.WriteLine("20200403,185924,000108,007,登消,客層 99 その他                  ")
            'writer.WriteLine("20200403,185924,000108,008,登消,────────────────")
            'writer.WriteLine("20200403,192612,000000,001,停止,マスタ反映                      ")
            'writer.WriteLine("20200403,194741,000000,001,停止,マスタ反映                      ")
            'writer.WriteLine("20200403,194758,000000,001,停止,マスタ反映                      ")
            'writer.WriteLine("20200403,194904,000000,001,停止,マスタ反映                      ")
            'writer.WriteLine("20200403,194911,000000,001,停止,マスタ反映                      ")
            'writer.WriteLine("20200403,195050,000000,001,停止,マスタ反映                      ")
            'writer.WriteLine("20200403,195921,000000,001,停止,マスタ反映                      ")
            'writer.WriteLine("20200403,201220,000000,001,停止,マスタ反映                      ")
            'writer.WriteLine("20200403,201224,000000,001,停止,マスタ反映                      ")
            'writer.WriteLine("20200403,201234,000000,001,停止,マスタ反映                      ")
            'writer.WriteLine("20200403,201243,000000,001,停止,マスタ反映                      ")
            'writer.WriteLine("20200403,214404,000000,001,停止,マスタ反映                      ")
            'writer.WriteLine("20200403,215334,000000,001,停止,マスタ反映                      ")
            'writer.WriteLine("20200403,224326,000000,001,停止,ｻｲﾝｵﾝ 001:武藤　和彦            ")
            'writer.WriteLine("20200403,224326,000000,002,停止,────────────────")
            'writer.WriteLine("20200403,224512,000000,001,停止,ｻｲﾝｵﾝ 004:渡辺　富幸            ")
            'writer.WriteLine("20200403,224512,000000,002,停止,────────────────")
            'writer.WriteLine("20200403,224528,000000,001,停止,マスタ反映                      ")
            'writer.WriteLine("20200403,224557,000000,001,停止,マスタ反映                      ")
            'writer.WriteLine("20200404,192233,000000,001,停止,ｻｲﾝｵﾝ 004:渡辺　富幸            ")
            'writer.WriteLine("20200404,192233,000000,002,停止,────────────────")
            'writer.WriteLine("20200404,192421,000000,001,停止,ｻｲﾝｵﾝ 004:渡辺　富幸            ")
            'writer.WriteLine("20200404,192421,000000,002,停止,────────────────")
            'writer.WriteLine("20200404,192427,100001,001,点検,                                ")
            'writer.WriteLine("20200404,192427,100002,002,点検,────────────────")
            'writer.WriteLine("20200404,194907,000000,001,停止,ｻｲﾝｵﾝ 001:武藤　和彦            ")
            'writer.WriteLine("20200404,194907,000000,002,停止,────────────────")
            'writer.WriteLine("20200404,195116,000000,001,停止,ｻｲﾝｵﾝ 004:渡辺　富幸            ")
            'writer.WriteLine("20200404,195116,000000,002,停止,────────────────")
            'writer.WriteLine("20200404,195217,000000,001,停止,                                ")
            'writer.WriteLine("20200404,195217,000000,002,停止,────────────────")
            'writer.WriteLine("20200404,195219,000000,001,停止,ｻｲﾝｵﾝ 004:渡辺　富幸            ")
            'writer.WriteLine("20200404,195219,000000,002,停止,────────────────")
            'writer.WriteLine("20200413,123011,000000,001,停止,ｻｲﾝｵﾝ 004:渡辺　富幸            ")
            'writer.WriteLine("20200413,123011,000000,002,停止,────────────────")
            'writer.WriteLine("20200413,163856,000000,001,停止,ｻｲﾝｵﾝ 004:渡辺　富幸            ")
            'writer.WriteLine("20200413,163856,000000,002,停止,────────────────")
            'writer.WriteLine("20200413,165830,000000,001,停止,ｻｲﾝｵﾝ 004:渡辺　富幸            ")
            'writer.WriteLine("20200413,165830,000000,002,停止,────────────────")
            'writer.WriteLine("20200413,182828,000000,001,停止,ｻｲﾝｵﾝ 001:武藤　和彦            ")
            'writer.WriteLine("20200413,182828,000000,002,停止,────────────────")
            'writer.WriteLine("20200413,184239,000000,001,停止,ｻｲﾝｵﾝ 004:渡辺　富幸            ")
            'writer.WriteLine("20200413,184239,000000,002,停止,────────────────")
            'writer.WriteLine("20200414,203855,000000,001,停止,ｻｲﾝｵﾝ 004:渡辺　富幸            ")
            'writer.WriteLine("20200414,203855,000000,002,停止,────────────────")
            'writer.WriteLine("20200414,210336,000109,001,登録,2020年04月14日(火)      21時03分")
            'writer.WriteLine("20200414,210336,000109,002,登録,           領　収　書           ")
            'writer.WriteLine("20200414,210336,000109,003,登録,2400000008705                   ")
            'writer.WriteLine("20200414,210336,000109,004,登録,送料830                     \830")
            'writer.WriteLine("20200414,210336,000109,005,登録,2400000008712                   ")
            'writer.WriteLine("20200414,210336,000109,006,登録,送料940                     \940")
            'writer.WriteLine("20200414,210336,000109,007,登録,2400000008729                   ")
            'writer.WriteLine("20200414,210336,000109,008,登録,送料1050                  \1,050")
            'writer.WriteLine("20200414,210336,000109,009,登録,小　計                    \2,820")
            'writer.WriteLine("20200414,210336,000109,010,登録,合計 3点                  \2,820")
            'writer.WriteLine("20200414,210336,000109,011,登録,(内課税10%               \2,820)")
            'writer.WriteLine("20200414,210336,000109,012,登録,(　内消費税10%             \256)")
            'writer.WriteLine("20200414,210336,000109,013,登録,(消費税計                  \256)")
            'writer.WriteLine("20200414,210336,000109,014,登録,お預り                   \10,000")
            'writer.WriteLine("20200414,210336,000109,015,登録,お釣り                    \7,180")
            'writer.WriteLine("20200414,210336,000109,016,登録,ﾚｼｰﾄ№000109            ﾚｼﾞ:0021")
            'writer.WriteLine("20200414,210336,000109,017,登録,担当:渡辺　富幸         店 :0000")
            'writer.WriteLine("20200414,210336,000109,018,登録,客層 99 その他                  ")
            'writer.WriteLine("20200414,210336,000109,019,登録,────────────────")
            'writer.WriteLine("20200414,210409,100001,001,点検,                                ")
            'writer.WriteLine("20200414,210409,100002,002,点検,品目別集計　 　集計             ")
            'writer.WriteLine("20200414,210409,100003,003,点検,部門別集計　 　集計             ")
            'writer.WriteLine("20200414,210409,100004,004,点検,部門別集計　 　集計             ")
            'writer.WriteLine("20200414,210409,100005,005,点検,────────────────")
            'writer.WriteLine("20200414,211007,000000,001,停止,ｻｲﾝｵﾝ 004:渡辺　富幸            ")
            'writer.WriteLine("20200414,211007,000000,002,停止,────────────────")
            'writer.WriteLine("20200415,153628,000000,001,停止,マスタ反映                      ")
            'writer.WriteLine("20200415,153718,000000,001,停止,マスタ反映                      ")
            'writer.WriteLine("20200415,153757,000000,001,停止,マスタ反映                      ")
            'writer.WriteLine("20200417,215730,000000,001,停止,ｻｲﾝｵﾝ 004:渡辺　富幸            ")
            'writer.WriteLine("20200417,215730,000000,002,停止,────────────────")

        End Using

    End Sub

    '印刷用変数
    Private printingText As String
    Private printingPosition As Integer
    Private printFont As Font

    Private Sub btn印刷_Click(ByVal sender As System.Object,
        ByVal e As System.EventArgs) Handles btn印刷.Click

        Dim result As DialogResult = MessageBox.Show("ジャーナル情報を印刷しますか？",
                                             "印刷",
                                             MessageBoxButtons.OKCancel,
                                             MessageBoxIcon.Exclamation,
                                             MessageBoxDefaultButton.Button2)

        If result = DialogResult.Cancel Then
            '「キャンセル」が選択された場合は何もしない
        ElseIf result = DialogResult.OK Then
            '「OK」が選択された場合は印刷する

            MessageBox.Show(lstジャーナルの表示.Text)

            '印刷する文字列と位置を設定する
            printingText = lstジャーナルの表示.Text
            printingPosition = 0
            '印刷に使うフォントを指定する
            printFont = New Font("ＭＳ Ｐゴシック", 10)
            'PrintDocumentオブジェクトの作成
            Dim pd As New System.Drawing.Printing.PrintDocument
            'PrintPageイベントハンドラの追加
            AddHandler pd.PrintPage, AddressOf pd_PrintPage
            '印刷を開始する
            pd.Print()
        End If
    End Sub

    Private Sub pd_PrintPage(ByVal sender As Object,
        ByVal e As System.Drawing.Printing.PrintPageEventArgs)
        If printingPosition = 0 Then
            '改行記号を'\n'に統一する
            printingText = printingText.Replace(vbCrLf, vbLf)
            printingText = printingText.Replace(vbCr, vbLf)
        End If

        '印刷する初期位置を決定
        Dim x As Integer = e.MarginBounds.Left
        Dim y As Integer = e.MarginBounds.Top

        '1ページに収まらなくなるか、印刷する文字がなくなるかまでループ
        While e.MarginBounds.Bottom > y + printFont.Height AndAlso
            printingPosition < printingText.Length
            Dim line As String = ""

            While True
                '印刷する文字がなくなるか、
                '改行の時はループから抜けて印刷する
                If printingPosition >= printingText.Length OrElse
                    printingText.Chars(printingPosition) = vbLf Then
                    printingPosition += 1
                    Exit While
                End If
                '一文字追加し、印刷幅を超えるか調べる
                line += printingText.Chars(printingPosition)
                If e.Graphics.MeasureString(line, printFont).Width _
                    > e.MarginBounds.Width Then
                    '印刷幅を超えたため、折り返す
                    line = line.Substring(0, line.Length - 1)
                    Exit While
                End If
                '印刷文字位置を次へ
                printingPosition += 1
            End While
            '一行書き出す
            e.Graphics.DrawString(line, printFont, Brushes.Black, x, y)
            '次の行の印刷位置を計算
            y += printFont.GetHeight(e.Graphics)
        End While

        '次のページがあるか調べる
        If printingPosition >= printingText.Length Then
            e.HasMorePages = False
            '初期化する
            printingPosition = 0
        Else
            e.HasMorePages = True
        End If
    End Sub

    Private Sub btn抽出_Click(sender As Object, e As EventArgs) Handles btn抽出.Click

        If txt端末.Text = "" Then

            MessageBox.Show("参照先を指定してください！")

        End If

    End Sub
End Class