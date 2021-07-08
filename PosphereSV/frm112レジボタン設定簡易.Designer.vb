<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm112レジボタン設定簡易
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.cmbposパターン選択 = New System.Windows.Forms.ComboBox()
        Me.lblLposパターン = New System.Windows.Forms.Label()
        Me.lblposパターン選択 = New System.Windows.Forms.Label()
        Me.grpposパターン = New System.Windows.Forms.GroupBox()
        Me.btn読込R = New System.Windows.Forms.Button()
        Me.btn終了 = New System.Windows.Forms.Button()
        Me.btnキー設定 = New System.Windows.Forms.Button()
        Me.btn予備キー設定 = New System.Windows.Forms.Button()
        Me.grp選択ボタン = New System.Windows.Forms.GroupBox()
        Me.lblボタン設定 = New System.Windows.Forms.Label()
        Me.grp選択機能取引 = New System.Windows.Forms.GroupBox()
        Me.lbl出荷時に戻す = New System.Windows.Forms.Label()
        Me.col取引CD = New System.Windows.Forms.DataGridView()
        Me.lbl取引CD = New System.Windows.Forms.Label()
        Me.col機能CD = New System.Windows.Forms.DataGridView()
        Me.lbl機能CD = New System.Windows.Forms.Label()
        Me.grp合計金額 = New System.Windows.Forms.GroupBox()
        Me.lblつり銭 = New System.Windows.Forms.Label()
        Me.lbl現金預 = New System.Windows.Forms.Label()
        Me.lbl差引 = New System.Windows.Forms.Label()
        Me.lbl現金以外 = New System.Windows.Forms.Label()
        Me.lbl合計金額 = New System.Windows.Forms.Label()
        Me.btn3_5 = New System.Windows.Forms.Button()
        Me.btn3_4 = New System.Windows.Forms.Button()
        Me.btn3_3 = New System.Windows.Forms.Button()
        Me.btn3_2 = New System.Windows.Forms.Button()
        Me.btn3_1 = New System.Windows.Forms.Button()
        Me.btn2_5 = New System.Windows.Forms.Button()
        Me.btn2_4 = New System.Windows.Forms.Button()
        Me.btn2_3 = New System.Windows.Forms.Button()
        Me.btn2_2 = New System.Windows.Forms.Button()
        Me.btn2_1 = New System.Windows.Forms.Button()
        Me.btn1_5 = New System.Windows.Forms.Button()
        Me.btn1_4 = New System.Windows.Forms.Button()
        Me.btn1_3 = New System.Windows.Forms.Button()
        Me.btn1_2 = New System.Windows.Forms.Button()
        Me.btn1_1 = New System.Windows.Forms.Button()
        Me.txt３ = New System.Windows.Forms.TextBox()
        Me.txt日付 = New System.Windows.Forms.TextBox()
        Me.txt２ = New System.Windows.Forms.TextBox()
        Me.txt１ = New System.Windows.Forms.TextBox()
        Me.txtつり銭入力 = New System.Windows.Forms.TextBox()
        Me.txt現金預入力 = New System.Windows.Forms.TextBox()
        Me.txt差引入力 = New System.Windows.Forms.TextBox()
        Me.txt現金以外入力 = New System.Windows.Forms.TextBox()
        Me.txt合計入力１ = New System.Windows.Forms.TextBox()
        Me.txt合計入力２ = New System.Windows.Forms.TextBox()
        Me.grpposパターン.SuspendLayout()
        Me.grp選択ボタン.SuspendLayout()
        Me.grp選択機能取引.SuspendLayout()
        CType(Me.col取引CD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.col機能CD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp合計金額.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmbposパターン選択
        '
        Me.cmbposパターン選択.FormattingEnabled = True
        Me.cmbposパターン選択.Location = New System.Drawing.Point(78, 12)
        Me.cmbposパターン選択.Name = "cmbposパターン選択"
        Me.cmbposパターン選択.Size = New System.Drawing.Size(321, 20)
        Me.cmbposパターン選択.TabIndex = 6
        '
        'lblLposパターン
        '
        Me.lblLposパターン.AutoSize = True
        Me.lblLposパターン.Location = New System.Drawing.Point(3, 15)
        Me.lblLposパターン.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblLposパターン.Name = "lblLposパターン"
        Me.lblLposパターン.Size = New System.Drawing.Size(70, 12)
        Me.lblLposパターン.TabIndex = 7
        Me.lblLposパターン.Text = "ＰＯＳパターン"
        '
        'lblposパターン選択
        '
        Me.lblposパターン選択.AutoSize = True
        Me.lblposパターン選択.Location = New System.Drawing.Point(-1, 39)
        Me.lblposパターン選択.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblposパターン選択.Name = "lblposパターン選択"
        Me.lblposパターン選択.Size = New System.Drawing.Size(159, 12)
        Me.lblposパターン選択.TabIndex = 9
        Me.lblposパターン選択.Text = "ＰＯＳパターンを選択して下さい。"
        '
        'grpposパターン
        '
        Me.grpposパターン.Controls.Add(Me.btn読込R)
        Me.grpposパターン.Controls.Add(Me.btn終了)
        Me.grpposパターン.Controls.Add(Me.lblposパターン選択)
        Me.grpposパターン.Controls.Add(Me.btnキー設定)
        Me.grpposパターン.Controls.Add(Me.btn予備キー設定)
        Me.grpposパターン.Controls.Add(Me.cmbposパターン選択)
        Me.grpposパターン.Controls.Add(Me.lblLposパターン)
        Me.grpposパターン.Location = New System.Drawing.Point(9, 12)
        Me.grpposパターン.Name = "grpposパターン"
        Me.grpposパターン.Size = New System.Drawing.Size(998, 67)
        Me.grpposパターン.TabIndex = 13
        Me.grpposパターン.TabStop = False
        '
        'btn読込R
        '
        Me.btn読込R.Location = New System.Drawing.Point(404, 17)
        Me.btn読込R.Margin = New System.Windows.Forms.Padding(2)
        Me.btn読込R.Name = "btn読込R"
        Me.btn読込R.Size = New System.Drawing.Size(78, 34)
        Me.btn読込R.TabIndex = 16
        Me.btn読込R.Text = "読込(R)"
        Me.btn読込R.UseVisualStyleBackColor = True
        '
        'btn終了
        '
        Me.btn終了.Location = New System.Drawing.Point(904, 17)
        Me.btn終了.Margin = New System.Windows.Forms.Padding(2)
        Me.btn終了.Name = "btn終了"
        Me.btn終了.Size = New System.Drawing.Size(79, 34)
        Me.btn終了.TabIndex = 15
        Me.btn終了.Text = "終了(X)"
        Me.btn終了.UseVisualStyleBackColor = True
        '
        'btnキー設定
        '
        Me.btnキー設定.Location = New System.Drawing.Point(737, 17)
        Me.btnキー設定.Margin = New System.Windows.Forms.Padding(2)
        Me.btnキー設定.Name = "btnキー設定"
        Me.btnキー設定.Size = New System.Drawing.Size(88, 34)
        Me.btnキー設定.TabIndex = 13
        Me.btnキー設定.Text = "キーボード設定"
        Me.btnキー設定.UseVisualStyleBackColor = True
        '
        'btn予備キー設定
        '
        Me.btn予備キー設定.Location = New System.Drawing.Point(824, 17)
        Me.btn予備キー設定.Margin = New System.Windows.Forms.Padding(2)
        Me.btn予備キー設定.Name = "btn予備キー設定"
        Me.btn予備キー設定.Size = New System.Drawing.Size(81, 34)
        Me.btn予備キー設定.TabIndex = 14
        Me.btn予備キー設定.Text = "予備キー設定"
        Me.btn予備キー設定.UseVisualStyleBackColor = True
        '
        'grp選択ボタン
        '
        Me.grp選択ボタン.Controls.Add(Me.lblボタン設定)
        Me.grp選択ボタン.Location = New System.Drawing.Point(0, 7)
        Me.grp選択ボタン.Name = "grp選択ボタン"
        Me.grp選択ボタン.Size = New System.Drawing.Size(721, 129)
        Me.grp選択ボタン.TabIndex = 14
        Me.grp選択ボタン.TabStop = False
        Me.grp選択ボタン.Text = "GroupBox2"
        '
        'lblボタン設定
        '
        Me.lblボタン設定.AutoSize = True
        Me.lblボタン設定.Location = New System.Drawing.Point(5, 0)
        Me.lblボタン設定.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblボタン設定.Name = "lblボタン設定"
        Me.lblボタン設定.Size = New System.Drawing.Size(104, 12)
        Me.lblボタン設定.TabIndex = 0
        Me.lblボタン設定.Text = "選択ボタン設定内容"
        '
        'grp選択機能取引
        '
        Me.grp選択機能取引.Controls.Add(Me.lbl出荷時に戻す)
        Me.grp選択機能取引.Controls.Add(Me.col取引CD)
        Me.grp選択機能取引.Controls.Add(Me.grp選択ボタン)
        Me.grp選択機能取引.Controls.Add(Me.lbl取引CD)
        Me.grp選択機能取引.Controls.Add(Me.col機能CD)
        Me.grp選択機能取引.Controls.Add(Me.lbl機能CD)
        Me.grp選択機能取引.Location = New System.Drawing.Point(10, 85)
        Me.grp選択機能取引.Name = "grp選択機能取引"
        Me.grp選択機能取引.Size = New System.Drawing.Size(727, 608)
        Me.grp選択機能取引.TabIndex = 16
        Me.grp選択機能取引.TabStop = False
        '
        'lbl出荷時に戻す
        '
        Me.lbl出荷時に戻す.AutoSize = True
        Me.lbl出荷時に戻す.Location = New System.Drawing.Point(580, 379)
        Me.lbl出荷時に戻す.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl出荷時に戻す.Name = "lbl出荷時に戻す"
        Me.lbl出荷時に戻す.Size = New System.Drawing.Size(108, 12)
        Me.lbl出荷時に戻す.TabIndex = 4
        Me.lbl出荷時に戻す.Text = "※工場出荷時に戻す"
        '
        'col取引CD
        '
        Me.col取引CD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.col取引CD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.col取引CD.Location = New System.Drawing.Point(7, 369)
        Me.col取引CD.Margin = New System.Windows.Forms.Padding(2)
        Me.col取引CD.Name = "col取引CD"
        Me.col取引CD.RowHeadersWidth = 62
        Me.col取引CD.RowTemplate.Height = 27
        Me.col取引CD.Size = New System.Drawing.Size(512, 234)
        Me.col取引CD.TabIndex = 3
        '
        'lbl取引CD
        '
        Me.lbl取引CD.AutoSize = True
        Me.lbl取引CD.Location = New System.Drawing.Point(5, 355)
        Me.lbl取引CD.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl取引CD.Name = "lbl取引CD"
        Me.lbl取引CD.Size = New System.Drawing.Size(69, 12)
        Me.lbl取引CD.TabIndex = 2
        Me.lbl取引CD.Text = "取引CD一覧"
        '
        'col機能CD
        '
        Me.col機能CD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.col機能CD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.col機能CD.Location = New System.Drawing.Point(7, 153)
        Me.col機能CD.Margin = New System.Windows.Forms.Padding(2)
        Me.col機能CD.Name = "col機能CD"
        Me.col機能CD.RowHeadersWidth = 62
        Me.col機能CD.RowTemplate.Height = 27
        Me.col機能CD.Size = New System.Drawing.Size(714, 198)
        Me.col機能CD.TabIndex = 1
        '
        'lbl機能CD
        '
        Me.lbl機能CD.AutoSize = True
        Me.lbl機能CD.Location = New System.Drawing.Point(9, 139)
        Me.lbl機能CD.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl機能CD.Name = "lbl機能CD"
        Me.lbl機能CD.Size = New System.Drawing.Size(69, 12)
        Me.lbl機能CD.TabIndex = 0
        Me.lbl機能CD.Text = "機能CD一覧"
        '
        'grp合計金額
        '
        Me.grp合計金額.Controls.Add(Me.lblつり銭)
        Me.grp合計金額.Controls.Add(Me.lbl現金預)
        Me.grp合計金額.Controls.Add(Me.lbl差引)
        Me.grp合計金額.Controls.Add(Me.lbl現金以外)
        Me.grp合計金額.Controls.Add(Me.lbl合計金額)
        Me.grp合計金額.Controls.Add(Me.btn3_5)
        Me.grp合計金額.Controls.Add(Me.btn3_4)
        Me.grp合計金額.Controls.Add(Me.btn3_3)
        Me.grp合計金額.Controls.Add(Me.btn3_2)
        Me.grp合計金額.Controls.Add(Me.btn3_1)
        Me.grp合計金額.Controls.Add(Me.btn2_5)
        Me.grp合計金額.Controls.Add(Me.btn2_4)
        Me.grp合計金額.Controls.Add(Me.btn2_3)
        Me.grp合計金額.Controls.Add(Me.btn2_2)
        Me.grp合計金額.Controls.Add(Me.btn2_1)
        Me.grp合計金額.Controls.Add(Me.btn1_5)
        Me.grp合計金額.Controls.Add(Me.btn1_4)
        Me.grp合計金額.Controls.Add(Me.btn1_3)
        Me.grp合計金額.Controls.Add(Me.btn1_2)
        Me.grp合計金額.Controls.Add(Me.btn1_1)
        Me.grp合計金額.Controls.Add(Me.txt３)
        Me.grp合計金額.Controls.Add(Me.txt日付)
        Me.grp合計金額.Controls.Add(Me.txt２)
        Me.grp合計金額.Controls.Add(Me.txt１)
        Me.grp合計金額.Controls.Add(Me.txtつり銭入力)
        Me.grp合計金額.Controls.Add(Me.txt現金預入力)
        Me.grp合計金額.Controls.Add(Me.txt差引入力)
        Me.grp合計金額.Controls.Add(Me.txt現金以外入力)
        Me.grp合計金額.Controls.Add(Me.txt合計入力１)
        Me.grp合計金額.Controls.Add(Me.txt合計入力２)
        Me.grp合計金額.Location = New System.Drawing.Point(737, 92)
        Me.grp合計金額.Name = "grp合計金額"
        Me.grp合計金額.Size = New System.Drawing.Size(271, 608)
        Me.grp合計金額.TabIndex = 38
        Me.grp合計金額.TabStop = False
        '
        'lblつり銭
        '
        Me.lblつり銭.AutoSize = True
        Me.lblつり銭.Location = New System.Drawing.Point(14, 75)
        Me.lblつり銭.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblつり銭.Name = "lblつり銭"
        Me.lblつり銭.Size = New System.Drawing.Size(34, 12)
        Me.lblつり銭.TabIndex = 36
        Me.lblつり銭.Text = "つり銭"
        '
        'lbl現金預
        '
        Me.lbl現金預.AutoSize = True
        Me.lbl現金預.Location = New System.Drawing.Point(7, 58)
        Me.lbl現金預.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl現金預.Name = "lbl現金預"
        Me.lbl現金預.Size = New System.Drawing.Size(49, 12)
        Me.lbl現金預.TabIndex = 35
        Me.lbl現金預.Text = "現金預り"
        '
        'lbl差引
        '
        Me.lbl差引.AutoSize = True
        Me.lbl差引.Location = New System.Drawing.Point(16, 41)
        Me.lbl差引.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl差引.Name = "lbl差引"
        Me.lbl差引.Size = New System.Drawing.Size(29, 12)
        Me.lbl差引.TabIndex = 34
        Me.lbl差引.Text = "差引"
        '
        'lbl現金以外
        '
        Me.lbl現金以外.AutoSize = True
        Me.lbl現金以外.Location = New System.Drawing.Point(5, 24)
        Me.lbl現金以外.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl現金以外.Name = "lbl現金以外"
        Me.lbl現金以外.Size = New System.Drawing.Size(53, 12)
        Me.lbl現金以外.TabIndex = 33
        Me.lbl現金以外.Text = "現金以外"
        '
        'lbl合計金額
        '
        Me.lbl合計金額.AutoSize = True
        Me.lbl合計金額.Location = New System.Drawing.Point(5, 7)
        Me.lbl合計金額.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl合計金額.Name = "lbl合計金額"
        Me.lbl合計金額.Size = New System.Drawing.Size(53, 12)
        Me.lbl合計金額.TabIndex = 32
        Me.lbl合計金額.Text = "合計金額"
        '
        'btn3_5
        '
        Me.btn3_5.Location = New System.Drawing.Point(209, 239)
        Me.btn3_5.Margin = New System.Windows.Forms.Padding(2)
        Me.btn3_5.Name = "btn3_5"
        Me.btn3_5.Size = New System.Drawing.Size(50, 50)
        Me.btn3_5.TabIndex = 31
        Me.btn3_5.UseVisualStyleBackColor = True
        '
        'btn3_4
        '
        Me.btn3_4.Location = New System.Drawing.Point(159, 239)
        Me.btn3_4.Margin = New System.Windows.Forms.Padding(2)
        Me.btn3_4.Name = "btn3_4"
        Me.btn3_4.Size = New System.Drawing.Size(50, 50)
        Me.btn3_4.TabIndex = 30
        Me.btn3_4.UseVisualStyleBackColor = True
        '
        'btn3_3
        '
        Me.btn3_3.Location = New System.Drawing.Point(109, 239)
        Me.btn3_3.Margin = New System.Windows.Forms.Padding(2)
        Me.btn3_3.Name = "btn3_3"
        Me.btn3_3.Size = New System.Drawing.Size(50, 50)
        Me.btn3_3.TabIndex = 29
        Me.btn3_3.UseVisualStyleBackColor = True
        '
        'btn3_2
        '
        Me.btn3_2.Location = New System.Drawing.Point(59, 239)
        Me.btn3_2.Margin = New System.Windows.Forms.Padding(2)
        Me.btn3_2.Name = "btn3_2"
        Me.btn3_2.Size = New System.Drawing.Size(50, 50)
        Me.btn3_2.TabIndex = 28
        Me.btn3_2.UseVisualStyleBackColor = True
        '
        'btn3_1
        '
        Me.btn3_1.Location = New System.Drawing.Point(9, 239)
        Me.btn3_1.Margin = New System.Windows.Forms.Padding(2)
        Me.btn3_1.Name = "btn3_1"
        Me.btn3_1.Size = New System.Drawing.Size(50, 50)
        Me.btn3_1.TabIndex = 27
        Me.btn3_1.UseVisualStyleBackColor = True
        '
        'btn2_5
        '
        Me.btn2_5.Location = New System.Drawing.Point(209, 189)
        Me.btn2_5.Margin = New System.Windows.Forms.Padding(2)
        Me.btn2_5.Name = "btn2_5"
        Me.btn2_5.Size = New System.Drawing.Size(50, 50)
        Me.btn2_5.TabIndex = 26
        Me.btn2_5.UseVisualStyleBackColor = True
        '
        'btn2_4
        '
        Me.btn2_4.Location = New System.Drawing.Point(159, 189)
        Me.btn2_4.Margin = New System.Windows.Forms.Padding(2)
        Me.btn2_4.Name = "btn2_4"
        Me.btn2_4.Size = New System.Drawing.Size(50, 50)
        Me.btn2_4.TabIndex = 25
        Me.btn2_4.UseVisualStyleBackColor = True
        '
        'btn2_3
        '
        Me.btn2_3.Location = New System.Drawing.Point(109, 189)
        Me.btn2_3.Margin = New System.Windows.Forms.Padding(2)
        Me.btn2_3.Name = "btn2_3"
        Me.btn2_3.Size = New System.Drawing.Size(50, 50)
        Me.btn2_3.TabIndex = 24
        Me.btn2_3.UseVisualStyleBackColor = True
        '
        'btn2_2
        '
        Me.btn2_2.Location = New System.Drawing.Point(59, 189)
        Me.btn2_2.Margin = New System.Windows.Forms.Padding(2)
        Me.btn2_2.Name = "btn2_2"
        Me.btn2_2.Size = New System.Drawing.Size(50, 50)
        Me.btn2_2.TabIndex = 23
        Me.btn2_2.UseVisualStyleBackColor = True
        '
        'btn2_1
        '
        Me.btn2_1.Location = New System.Drawing.Point(9, 189)
        Me.btn2_1.Margin = New System.Windows.Forms.Padding(2)
        Me.btn2_1.Name = "btn2_1"
        Me.btn2_1.Size = New System.Drawing.Size(50, 50)
        Me.btn2_1.TabIndex = 22
        Me.btn2_1.UseVisualStyleBackColor = True
        '
        'btn1_5
        '
        Me.btn1_5.Location = New System.Drawing.Point(209, 139)
        Me.btn1_5.Margin = New System.Windows.Forms.Padding(2)
        Me.btn1_5.Name = "btn1_5"
        Me.btn1_5.Size = New System.Drawing.Size(50, 50)
        Me.btn1_5.TabIndex = 21
        Me.btn1_5.UseVisualStyleBackColor = True
        '
        'btn1_4
        '
        Me.btn1_4.Location = New System.Drawing.Point(159, 139)
        Me.btn1_4.Margin = New System.Windows.Forms.Padding(2)
        Me.btn1_4.Name = "btn1_4"
        Me.btn1_4.Size = New System.Drawing.Size(50, 50)
        Me.btn1_4.TabIndex = 20
        Me.btn1_4.UseVisualStyleBackColor = True
        '
        'btn1_3
        '
        Me.btn1_3.Location = New System.Drawing.Point(109, 139)
        Me.btn1_3.Margin = New System.Windows.Forms.Padding(2)
        Me.btn1_3.Name = "btn1_3"
        Me.btn1_3.Size = New System.Drawing.Size(50, 50)
        Me.btn1_3.TabIndex = 19
        Me.btn1_3.UseVisualStyleBackColor = True
        '
        'btn1_2
        '
        Me.btn1_2.Location = New System.Drawing.Point(59, 139)
        Me.btn1_2.Margin = New System.Windows.Forms.Padding(2)
        Me.btn1_2.Name = "btn1_2"
        Me.btn1_2.Size = New System.Drawing.Size(50, 50)
        Me.btn1_2.TabIndex = 18
        Me.btn1_2.UseVisualStyleBackColor = True
        '
        'btn1_1
        '
        Me.btn1_1.Location = New System.Drawing.Point(9, 139)
        Me.btn1_1.Margin = New System.Windows.Forms.Padding(2)
        Me.btn1_1.Name = "btn1_1"
        Me.btn1_1.Size = New System.Drawing.Size(50, 50)
        Me.btn1_1.TabIndex = 17
        Me.btn1_1.UseVisualStyleBackColor = True
        '
        'txt３
        '
        Me.txt３.Location = New System.Drawing.Point(107, 120)
        Me.txt３.Name = "txt３"
        Me.txt３.Size = New System.Drawing.Size(148, 19)
        Me.txt３.TabIndex = 16
        '
        'txt日付
        '
        Me.txt日付.Location = New System.Drawing.Point(9, 120)
        Me.txt日付.Name = "txt日付"
        Me.txt日付.Size = New System.Drawing.Size(99, 19)
        Me.txt日付.TabIndex = 15
        '
        'txt２
        '
        Me.txt２.Location = New System.Drawing.Point(107, 101)
        Me.txt２.Name = "txt２"
        Me.txt２.Size = New System.Drawing.Size(148, 19)
        Me.txt２.TabIndex = 14
        '
        'txt１
        '
        Me.txt１.Location = New System.Drawing.Point(9, 101)
        Me.txt１.Name = "txt１"
        Me.txt１.Size = New System.Drawing.Size(99, 19)
        Me.txt１.TabIndex = 13
        '
        'txtつり銭入力
        '
        Me.txtつり銭入力.Location = New System.Drawing.Point(59, 82)
        Me.txtつり銭入力.Name = "txtつり銭入力"
        Me.txtつり銭入力.Size = New System.Drawing.Size(196, 19)
        Me.txtつり銭入力.TabIndex = 12
        '
        'txt現金預入力
        '
        Me.txt現金預入力.Location = New System.Drawing.Point(59, 63)
        Me.txt現金預入力.Name = "txt現金預入力"
        Me.txt現金預入力.Size = New System.Drawing.Size(196, 19)
        Me.txt現金預入力.TabIndex = 11
        '
        'txt差引入力
        '
        Me.txt差引入力.Location = New System.Drawing.Point(59, 44)
        Me.txt差引入力.Name = "txt差引入力"
        Me.txt差引入力.Size = New System.Drawing.Size(196, 19)
        Me.txt差引入力.TabIndex = 10
        '
        'txt現金以外入力
        '
        Me.txt現金以外入力.Location = New System.Drawing.Point(59, 25)
        Me.txt現金以外入力.Name = "txt現金以外入力"
        Me.txt現金以外入力.Size = New System.Drawing.Size(196, 19)
        Me.txt現金以外入力.TabIndex = 9
        '
        'txt合計入力１
        '
        Me.txt合計入力１.Location = New System.Drawing.Point(59, 7)
        Me.txt合計入力１.Name = "txt合計入力１"
        Me.txt合計入力１.Size = New System.Drawing.Size(53, 19)
        Me.txt合計入力１.TabIndex = 8
        '
        'txt合計入力２
        '
        Me.txt合計入力２.Location = New System.Drawing.Point(110, 7)
        Me.txt合計入力２.Name = "txt合計入力２"
        Me.txt合計入力２.Size = New System.Drawing.Size(145, 19)
        Me.txt合計入力２.TabIndex = 7
        '
        'frm112レジボタン設定簡易
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 718)
        Me.Controls.Add(Me.grp合計金額)
        Me.Controls.Add(Me.grpposパターン)
        Me.Controls.Add(Me.grp選択機能取引)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frm112レジボタン設定簡易"
        Me.Text = "レジボタン設定(簡易レジ)"
        Me.grpposパターン.ResumeLayout(False)
        Me.grpposパターン.PerformLayout()
        Me.grp選択ボタン.ResumeLayout(False)
        Me.grp選択ボタン.PerformLayout()
        Me.grp選択機能取引.ResumeLayout(False)
        Me.grp選択機能取引.PerformLayout()
        CType(Me.col取引CD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.col機能CD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp合計金額.ResumeLayout(False)
        Me.grp合計金額.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmbposパターン選択 As ComboBox
    Friend WithEvents lblLposパターン As Label
    Friend WithEvents btn読込 As Button
    Friend WithEvents lblposパターン選択 As Label
    Friend WithEvents grpposパターン As GroupBox
    Friend WithEvents grp選択ボタン As GroupBox
    Friend WithEvents grp選択機能取引 As GroupBox
    Friend WithEvents lblボタン設定 As Label
    Friend WithEvents col取引CD As DataGridView
    Friend WithEvents lbl取引CD As Label
    Friend WithEvents col機能CD As DataGridView
    Friend WithEvents lbl機能CD As Label
    Friend WithEvents lbl出荷時に戻す As Label
    Friend WithEvents grp合計金額 As GroupBox
    Friend WithEvents lblつり銭 As Label
    Friend WithEvents lbl現金預 As Label
    Friend WithEvents lbl差引 As Label
    Friend WithEvents lbl現金以外 As Label
    Friend WithEvents lbl合計金額 As Label
    Friend WithEvents btn3_5 As Button
    Friend WithEvents btn3_4 As Button
    Friend WithEvents btn3_3 As Button
    Friend WithEvents btn3_2 As Button
    Friend WithEvents btn3_1 As Button
    Friend WithEvents btn2_5 As Button
    Friend WithEvents btn2_4 As Button
    Friend WithEvents btn2_3 As Button
    Friend WithEvents btn2_2 As Button
    Friend WithEvents btn2_1 As Button
    Friend WithEvents btn1_5 As Button
    Friend WithEvents btn1_4 As Button
    Friend WithEvents btn1_3 As Button
    Friend WithEvents btn1_2 As Button
    Friend WithEvents btn1_1 As Button
    Friend WithEvents txt３ As TextBox
    Friend WithEvents txt日付 As TextBox
    Friend WithEvents txt２ As TextBox
    Friend WithEvents txt１ As TextBox
    Friend WithEvents txtつり銭入力 As TextBox
    Friend WithEvents txt現金預入力 As TextBox
    Friend WithEvents txt差引入力 As TextBox
    Friend WithEvents txt現金以外入力 As TextBox
    Friend WithEvents txt合計入力１ As TextBox
    Friend WithEvents txt合計入力２ As TextBox
    Friend WithEvents btn終了 As Button
    Friend WithEvents btnキー設定 As Button
    Friend WithEvents btn予備キー設定 As Button
    Friend WithEvents btn読込R As Button
End Class
