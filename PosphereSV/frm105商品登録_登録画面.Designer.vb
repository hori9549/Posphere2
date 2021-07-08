<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm105商品登録_登録画面
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
        Me.grpメニュー = New System.Windows.Forms.GroupBox()
        Me.btn終了 = New System.Windows.Forms.Button()
        Me.btnエクスポート = New System.Windows.Forms.Button()
        Me.btnコピー = New System.Windows.Forms.Button()
        Me.btnキャンセル = New System.Windows.Forms.Button()
        Me.btnクリア = New System.Windows.Forms.Button()
        Me.btn更新 = New System.Windows.Forms.Button()
        Me.btn検索 = New System.Windows.Forms.Button()
        Me.btn読込 = New System.Windows.Forms.Button()
        Me.txt商品CD = New System.Windows.Forms.TextBox()
        Me.lbl商品CD = New System.Windows.Forms.Label()
        Me.cmbPOSパターン = New System.Windows.Forms.ComboBox()
        Me.lblPOSパターン = New System.Windows.Forms.Label()
        Me.tab登録設定 = New System.Windows.Forms.TabControl()
        Me.tab基本設定 = New System.Windows.Forms.TabPage()
        Me.dgvData = New System.Windows.Forms.DataGridView()
        Me.cmb課税区分2 = New System.Windows.Forms.ComboBox()
        Me.cmb課税区分1 = New System.Windows.Forms.ComboBox()
        Me.tabオーダー設定 = New System.Windows.Forms.TabControl()
        Me.tabオーダー出力先設定 = New System.Windows.Forms.TabPage()
        Me.cmb出力順位2 = New System.Windows.Forms.ComboBox()
        Me.cmb出力順位3 = New System.Windows.Forms.ComboBox()
        Me.cmb出力順位4 = New System.Windows.Forms.ComboBox()
        Me.cmb出力順位5 = New System.Windows.Forms.ComboBox()
        Me.cmb出力順位6 = New System.Windows.Forms.ComboBox()
        Me.cmb出力順位1 = New System.Windows.Forms.ComboBox()
        Me.lbl出力順位 = New System.Windows.Forms.Label()
        Me.lbl出力2 = New System.Windows.Forms.Label()
        Me.lbl出力3 = New System.Windows.Forms.Label()
        Me.lbl出力4 = New System.Windows.Forms.Label()
        Me.lbl出力5 = New System.Windows.Forms.Label()
        Me.lbl出力6 = New System.Windows.Forms.Label()
        Me.lbl出力先指定 = New System.Windows.Forms.Label()
        Me.lbl出力1 = New System.Windows.Forms.Label()
        Me.cmb出力先指定2 = New System.Windows.Forms.ComboBox()
        Me.cmb出力先指定3 = New System.Windows.Forms.ComboBox()
        Me.cmb出力先指定5 = New System.Windows.Forms.ComboBox()
        Me.cmb出力先指定6 = New System.Windows.Forms.ComboBox()
        Me.cmb出力先指定4 = New System.Windows.Forms.ComboBox()
        Me.cmb出力先指定1 = New System.Windows.Forms.ComboBox()
        Me.tabオーダー名称設定 = New System.Windows.Forms.TabPage()
        Me.lbl検索キー3 = New System.Windows.Forms.Label()
        Me.lbl検索キー2 = New System.Windows.Forms.Label()
        Me.lbl検索キー1 = New System.Windows.Forms.Label()
        Me.lblメニュー名5 = New System.Windows.Forms.Label()
        Me.lblメニュー名3 = New System.Windows.Forms.Label()
        Me.lblメニュー名4 = New System.Windows.Forms.Label()
        Me.lblメニュー名2 = New System.Windows.Forms.Label()
        Me.lblメニュー名１_下段 = New System.Windows.Forms.Label()
        Me.lblメニュー名１_上段 = New System.Windows.Forms.Label()
        Me.txt検索キー1 = New System.Windows.Forms.TextBox()
        Me.txt検索キー2 = New System.Windows.Forms.TextBox()
        Me.txt検索キー3 = New System.Windows.Forms.TextBox()
        Me.txtメニュー名5 = New System.Windows.Forms.TextBox()
        Me.txtメニュー名4 = New System.Windows.Forms.TextBox()
        Me.txtメニュー名3 = New System.Windows.Forms.TextBox()
        Me.txtメニュー名１_下段 = New System.Windows.Forms.TextBox()
        Me.txtメニュー名2 = New System.Windows.Forms.TextBox()
        Me.txtメニュー名１_上段 = New System.Windows.Forms.TextBox()
        Me.btnレジボタン表示名設定 = New System.Windows.Forms.Button()
        Me.txt販売期間2 = New System.Windows.Forms.TextBox()
        Me.lbl発行しないする = New System.Windows.Forms.Label()
        Me.lblから = New System.Windows.Forms.Label()
        Me.txt食券発行 = New System.Windows.Forms.TextBox()
        Me.txt検索カナ = New System.Windows.Forms.TextBox()
        Me.txt単価_通常 = New System.Windows.Forms.TextBox()
        Me.txt単価_TO = New System.Windows.Forms.TextBox()
        Me.txt販売期間1 = New System.Windows.Forms.TextBox()
        Me.txtレジボタン表示名設定_上段 = New System.Windows.Forms.TextBox()
        Me.txtレジボタン表示名設定_下段 = New System.Windows.Forms.TextBox()
        Me.txt商品名 = New System.Windows.Forms.TextBox()
        Me.cmbタイプ = New System.Windows.Forms.ComboBox()
        Me.cmbテイクアウト = New System.Windows.Forms.ComboBox()
        Me.lbl課税区分2 = New System.Windows.Forms.Label()
        Me.lbl課税区分1 = New System.Windows.Forms.Label()
        Me.lbl単価_TO = New System.Windows.Forms.Label()
        Me.lbl単価_通常 = New System.Windows.Forms.Label()
        Me.lblテイクアウト = New System.Windows.Forms.Label()
        Me.lbl販売期間 = New System.Windows.Forms.Label()
        Me.lbl食券発行 = New System.Windows.Forms.Label()
        Me.lblレジボタン表示名設定 = New System.Windows.Forms.Label()
        Me.lbl検索ｶﾅ = New System.Windows.Forms.Label()
        Me.lbl商品名 = New System.Windows.Forms.Label()
        Me.lblタイプ = New System.Windows.Forms.Label()
        Me.grp飲食 = New System.Windows.Forms.GroupBox()
        Me.txt付加金額 = New System.Windows.Forms.TextBox()
        Me.lblゼロ円明細 = New System.Windows.Forms.Label()
        Me.txt品目CD = New System.Windows.Forms.TextBox()
        Me.lbl付加金額 = New System.Windows.Forms.Label()
        Me.cmbゼロ円明細 = New System.Windows.Forms.ComboBox()
        Me.cmb提供時期 = New System.Windows.Forms.ComboBox()
        Me.cmb付加金額 = New System.Windows.Forms.ComboBox()
        Me.cmbサービス料 = New System.Windows.Forms.ComboBox()
        Me.cmb入力タイプ = New System.Windows.Forms.ComboBox()
        Me.lbl品目CD = New System.Windows.Forms.Label()
        Me.lbl入力タイプ = New System.Windows.Forms.Label()
        Me.lbl提供時期 = New System.Windows.Forms.Label()
        Me.lblサービス料 = New System.Windows.Forms.Label()
        Me.tabセットメニューの設定 = New System.Windows.Forms.TabPage()
        Me.txt数量 = New System.Windows.Forms.TextBox()
        Me.grpサブ情報 = New System.Windows.Forms.GroupBox()
        Me.grpサブ情報_設定 = New System.Windows.Forms.GroupBox()
        Me.cmbハンディ表示 = New System.Windows.Forms.ComboBox()
        Me.cmb設定区分 = New System.Windows.Forms.ComboBox()
        Me.cmb数量エラーチェック = New System.Windows.Forms.ComboBox()
        Me.lblハンディ表示 = New System.Windows.Forms.Label()
        Me.lbl数量エラーチェック = New System.Windows.Forms.Label()
        Me.lbl設定区分 = New System.Windows.Forms.Label()
        Me.btn取消 = New System.Windows.Forms.Button()
        Me.dgvサブ情報 = New System.Windows.Forms.DataGridView()
        Me.txt表示 = New System.Windows.Forms.TextBox()
        Me.btn選択 = New System.Windows.Forms.Button()
        Me.txt設定 = New System.Windows.Forms.TextBox()
        Me.txt名称 = New System.Windows.Forms.TextBox()
        Me.grpグループ名一覧 = New System.Windows.Forms.GroupBox()
        Me.dgvグループ名一覧 = New System.Windows.Forms.DataGridView()
        Me.txt番号 = New System.Windows.Forms.TextBox()
        Me.grpメニュー.SuspendLayout()
        Me.tab登録設定.SuspendLayout()
        Me.tab基本設定.SuspendLayout()
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabオーダー設定.SuspendLayout()
        Me.tabオーダー出力先設定.SuspendLayout()
        Me.tabオーダー名称設定.SuspendLayout()
        Me.grp飲食.SuspendLayout()
        Me.tabセットメニューの設定.SuspendLayout()
        Me.grpサブ情報.SuspendLayout()
        Me.grpサブ情報_設定.SuspendLayout()
        CType(Me.dgvサブ情報, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpグループ名一覧.SuspendLayout()
        CType(Me.dgvグループ名一覧, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpメニュー
        '
        Me.grpメニュー.Controls.Add(Me.btn終了)
        Me.grpメニュー.Controls.Add(Me.btnエクスポート)
        Me.grpメニュー.Controls.Add(Me.btnコピー)
        Me.grpメニュー.Controls.Add(Me.btnキャンセル)
        Me.grpメニュー.Controls.Add(Me.btnクリア)
        Me.grpメニュー.Controls.Add(Me.btn更新)
        Me.grpメニュー.Controls.Add(Me.btn検索)
        Me.grpメニュー.Controls.Add(Me.btn読込)
        Me.grpメニュー.Controls.Add(Me.txt商品CD)
        Me.grpメニュー.Controls.Add(Me.lbl商品CD)
        Me.grpメニュー.Controls.Add(Me.cmbPOSパターン)
        Me.grpメニュー.Controls.Add(Me.lblPOSパターン)
        Me.grpメニュー.Location = New System.Drawing.Point(10, 3)
        Me.grpメニュー.Name = "grpメニュー"
        Me.grpメニュー.Size = New System.Drawing.Size(995, 77)
        Me.grpメニュー.TabIndex = 34
        Me.grpメニュー.TabStop = False
        '
        'btn終了
        '
        Me.btn終了.Location = New System.Drawing.Point(908, 17)
        Me.btn終了.Name = "btn終了"
        Me.btn終了.Size = New System.Drawing.Size(80, 45)
        Me.btn終了.TabIndex = 12
        Me.btn終了.Text = "終了"
        Me.btn終了.UseVisualStyleBackColor = True
        '
        'btnエクスポート
        '
        Me.btnエクスポート.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnエクスポート.Location = New System.Drawing.Point(822, 17)
        Me.btnエクスポート.Name = "btnエクスポート"
        Me.btnエクスポート.Size = New System.Drawing.Size(80, 45)
        Me.btnエクスポート.TabIndex = 11
        Me.btnエクスポート.Text = "エクスポート"
        Me.btnエクスポート.UseVisualStyleBackColor = True
        '
        'btnコピー
        '
        Me.btnコピー.Enabled = False
        Me.btnコピー.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.btnコピー.Location = New System.Drawing.Point(736, 17)
        Me.btnコピー.Name = "btnコピー"
        Me.btnコピー.Size = New System.Drawing.Size(80, 45)
        Me.btnコピー.TabIndex = 10
        Me.btnコピー.Text = "コピー"
        Me.btnコピー.UseVisualStyleBackColor = True
        '
        'btnキャンセル
        '
        Me.btnキャンセル.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnキャンセル.Location = New System.Drawing.Point(650, 17)
        Me.btnキャンセル.Name = "btnキャンセル"
        Me.btnキャンセル.Size = New System.Drawing.Size(80, 45)
        Me.btnキャンセル.TabIndex = 9
        Me.btnキャンセル.Text = "キャンセル"
        Me.btnキャンセル.UseVisualStyleBackColor = True
        '
        'btnクリア
        '
        Me.btnクリア.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnクリア.Location = New System.Drawing.Point(564, 17)
        Me.btnクリア.Name = "btnクリア"
        Me.btnクリア.Size = New System.Drawing.Size(80, 45)
        Me.btnクリア.TabIndex = 8
        Me.btnクリア.Text = "クリア"
        Me.btnクリア.UseVisualStyleBackColor = True
        '
        'btn更新
        '
        Me.btn更新.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn更新.Location = New System.Drawing.Point(478, 17)
        Me.btn更新.Name = "btn更新"
        Me.btn更新.Size = New System.Drawing.Size(80, 45)
        Me.btn更新.TabIndex = 7
        Me.btn更新.Text = "更新"
        Me.btn更新.UseVisualStyleBackColor = True
        '
        'btn検索
        '
        Me.btn検索.Enabled = False
        Me.btn検索.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.btn検索.Location = New System.Drawing.Point(392, 17)
        Me.btn検索.Name = "btn検索"
        Me.btn検索.Size = New System.Drawing.Size(80, 45)
        Me.btn検索.TabIndex = 6
        Me.btn検索.Text = "検索"
        Me.btn検索.UseVisualStyleBackColor = True
        '
        'btn読込
        '
        Me.btn読込.Enabled = False
        Me.btn読込.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.btn読込.Location = New System.Drawing.Point(306, 17)
        Me.btn読込.Name = "btn読込"
        Me.btn読込.Size = New System.Drawing.Size(80, 45)
        Me.btn読込.TabIndex = 5
        Me.btn読込.Text = "読込"
        Me.btn読込.UseVisualStyleBackColor = True
        '
        'txt商品CD
        '
        Me.txt商品CD.Enabled = False
        Me.txt商品CD.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txt商品CD.Location = New System.Drawing.Point(70, 41)
        Me.txt商品CD.Name = "txt商品CD"
        Me.txt商品CD.Size = New System.Drawing.Size(86, 19)
        Me.txt商品CD.TabIndex = 4
        '
        'lbl商品CD
        '
        Me.lbl商品CD.AutoSize = True
        Me.lbl商品CD.Location = New System.Drawing.Point(12, 44)
        Me.lbl商品CD.Name = "lbl商品CD"
        Me.lbl商品CD.Size = New System.Drawing.Size(45, 12)
        Me.lbl商品CD.TabIndex = 3
        Me.lbl商品CD.Text = "商品CD"
        '
        'cmbPOSパターン
        '
        Me.cmbPOSパターン.Enabled = False
        Me.cmbPOSパターン.FormattingEnabled = True
        Me.cmbPOSパターン.Location = New System.Drawing.Point(70, 15)
        Me.cmbPOSパターン.Name = "cmbPOSパターン"
        Me.cmbPOSパターン.Size = New System.Drawing.Size(226, 20)
        Me.cmbPOSパターン.TabIndex = 2
        '
        'lblPOSパターン
        '
        Me.lblPOSパターン.AutoSize = True
        Me.lblPOSパターン.Location = New System.Drawing.Point(0, 18)
        Me.lblPOSパターン.Name = "lblPOSパターン"
        Me.lblPOSパターン.Size = New System.Drawing.Size(64, 12)
        Me.lblPOSパターン.TabIndex = 0
        Me.lblPOSパターン.Text = "POSパターン"
        '
        'tab登録設定
        '
        Me.tab登録設定.Controls.Add(Me.tab基本設定)
        Me.tab登録設定.Controls.Add(Me.tabセットメニューの設定)
        Me.tab登録設定.Location = New System.Drawing.Point(10, 86)
        Me.tab登録設定.Name = "tab登録設定"
        Me.tab登録設定.SelectedIndex = 0
        Me.tab登録設定.Size = New System.Drawing.Size(988, 621)
        Me.tab登録設定.TabIndex = 45
        '
        'tab基本設定
        '
        Me.tab基本設定.Controls.Add(Me.dgvData)
        Me.tab基本設定.Controls.Add(Me.cmb課税区分2)
        Me.tab基本設定.Controls.Add(Me.cmb課税区分1)
        Me.tab基本設定.Controls.Add(Me.tabオーダー設定)
        Me.tab基本設定.Controls.Add(Me.btnレジボタン表示名設定)
        Me.tab基本設定.Controls.Add(Me.txt販売期間2)
        Me.tab基本設定.Controls.Add(Me.lbl発行しないする)
        Me.tab基本設定.Controls.Add(Me.lblから)
        Me.tab基本設定.Controls.Add(Me.txt食券発行)
        Me.tab基本設定.Controls.Add(Me.txt検索カナ)
        Me.tab基本設定.Controls.Add(Me.txt単価_通常)
        Me.tab基本設定.Controls.Add(Me.txt単価_TO)
        Me.tab基本設定.Controls.Add(Me.txt販売期間1)
        Me.tab基本設定.Controls.Add(Me.txtレジボタン表示名設定_上段)
        Me.tab基本設定.Controls.Add(Me.txtレジボタン表示名設定_下段)
        Me.tab基本設定.Controls.Add(Me.txt商品名)
        Me.tab基本設定.Controls.Add(Me.cmbタイプ)
        Me.tab基本設定.Controls.Add(Me.cmbテイクアウト)
        Me.tab基本設定.Controls.Add(Me.lbl課税区分2)
        Me.tab基本設定.Controls.Add(Me.lbl課税区分1)
        Me.tab基本設定.Controls.Add(Me.lbl単価_TO)
        Me.tab基本設定.Controls.Add(Me.lbl単価_通常)
        Me.tab基本設定.Controls.Add(Me.lblテイクアウト)
        Me.tab基本設定.Controls.Add(Me.lbl販売期間)
        Me.tab基本設定.Controls.Add(Me.lbl食券発行)
        Me.tab基本設定.Controls.Add(Me.lblレジボタン表示名設定)
        Me.tab基本設定.Controls.Add(Me.lbl検索ｶﾅ)
        Me.tab基本設定.Controls.Add(Me.lbl商品名)
        Me.tab基本設定.Controls.Add(Me.lblタイプ)
        Me.tab基本設定.Controls.Add(Me.grp飲食)
        Me.tab基本設定.Location = New System.Drawing.Point(4, 22)
        Me.tab基本設定.Name = "tab基本設定"
        Me.tab基本設定.Padding = New System.Windows.Forms.Padding(3)
        Me.tab基本設定.Size = New System.Drawing.Size(980, 595)
        Me.tab基本設定.TabIndex = 0
        Me.tab基本設定.Text = "基本設定"
        Me.tab基本設定.UseVisualStyleBackColor = True
        '
        'dgvData
        '
        Me.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvData.Location = New System.Drawing.Point(3, 509)
        Me.dgvData.Name = "dgvData"
        Me.dgvData.RowTemplate.Height = 21
        Me.dgvData.Size = New System.Drawing.Size(977, 86)
        Me.dgvData.TabIndex = 59
        '
        'cmb課税区分2
        '
        Me.cmb課税区分2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb課税区分2.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cmb課税区分2.FormattingEnabled = True
        Me.cmb課税区分2.Location = New System.Drawing.Point(252, 245)
        Me.cmb課税区分2.Name = "cmb課税区分2"
        Me.cmb課税区分2.Size = New System.Drawing.Size(110, 20)
        Me.cmb課税区分2.TabIndex = 48
        '
        'cmb課税区分1
        '
        Me.cmb課税区分1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb課税区分1.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cmb課税区分1.FormattingEnabled = True
        Me.cmb課税区分1.Location = New System.Drawing.Point(252, 219)
        Me.cmb課税区分1.Name = "cmb課税区分1"
        Me.cmb課税区分1.Size = New System.Drawing.Size(110, 20)
        Me.cmb課税区分1.TabIndex = 47
        '
        'tabオーダー設定
        '
        Me.tabオーダー設定.Controls.Add(Me.tabオーダー出力先設定)
        Me.tabオーダー設定.Controls.Add(Me.tabオーダー名称設定)
        Me.tabオーダー設定.Location = New System.Drawing.Point(430, 231)
        Me.tabオーダー設定.Name = "tabオーダー設定"
        Me.tabオーダー設定.SelectedIndex = 0
        Me.tabオーダー設定.Size = New System.Drawing.Size(505, 285)
        Me.tabオーダー設定.TabIndex = 33
        '
        'tabオーダー出力先設定
        '
        Me.tabオーダー出力先設定.BackColor = System.Drawing.Color.LightCyan
        Me.tabオーダー出力先設定.Controls.Add(Me.cmb出力順位2)
        Me.tabオーダー出力先設定.Controls.Add(Me.cmb出力順位3)
        Me.tabオーダー出力先設定.Controls.Add(Me.cmb出力順位4)
        Me.tabオーダー出力先設定.Controls.Add(Me.cmb出力順位5)
        Me.tabオーダー出力先設定.Controls.Add(Me.cmb出力順位6)
        Me.tabオーダー出力先設定.Controls.Add(Me.cmb出力順位1)
        Me.tabオーダー出力先設定.Controls.Add(Me.lbl出力順位)
        Me.tabオーダー出力先設定.Controls.Add(Me.lbl出力2)
        Me.tabオーダー出力先設定.Controls.Add(Me.lbl出力3)
        Me.tabオーダー出力先設定.Controls.Add(Me.lbl出力4)
        Me.tabオーダー出力先設定.Controls.Add(Me.lbl出力5)
        Me.tabオーダー出力先設定.Controls.Add(Me.lbl出力6)
        Me.tabオーダー出力先設定.Controls.Add(Me.lbl出力先指定)
        Me.tabオーダー出力先設定.Controls.Add(Me.lbl出力1)
        Me.tabオーダー出力先設定.Controls.Add(Me.cmb出力先指定2)
        Me.tabオーダー出力先設定.Controls.Add(Me.cmb出力先指定3)
        Me.tabオーダー出力先設定.Controls.Add(Me.cmb出力先指定5)
        Me.tabオーダー出力先設定.Controls.Add(Me.cmb出力先指定6)
        Me.tabオーダー出力先設定.Controls.Add(Me.cmb出力先指定4)
        Me.tabオーダー出力先設定.Controls.Add(Me.cmb出力先指定1)
        Me.tabオーダー出力先設定.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabオーダー出力先設定.Location = New System.Drawing.Point(4, 22)
        Me.tabオーダー出力先設定.Name = "tabオーダー出力先設定"
        Me.tabオーダー出力先設定.Padding = New System.Windows.Forms.Padding(3)
        Me.tabオーダー出力先設定.Size = New System.Drawing.Size(497, 259)
        Me.tabオーダー出力先設定.TabIndex = 0
        Me.tabオーダー出力先設定.Text = "オーダー出力先設定"
        '
        'cmb出力順位2
        '
        Me.cmb出力順位2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb出力順位2.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cmb出力順位2.FormattingEnabled = True
        Me.cmb出力順位2.Location = New System.Drawing.Point(297, 70)
        Me.cmb出力順位2.Name = "cmb出力順位2"
        Me.cmb出力順位2.Size = New System.Drawing.Size(46, 20)
        Me.cmb出力順位2.TabIndex = 59
        '
        'cmb出力順位3
        '
        Me.cmb出力順位3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb出力順位3.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cmb出力順位3.FormattingEnabled = True
        Me.cmb出力順位3.Location = New System.Drawing.Point(297, 96)
        Me.cmb出力順位3.Name = "cmb出力順位3"
        Me.cmb出力順位3.Size = New System.Drawing.Size(46, 20)
        Me.cmb出力順位3.TabIndex = 58
        '
        'cmb出力順位4
        '
        Me.cmb出力順位4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb出力順位4.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cmb出力順位4.FormattingEnabled = True
        Me.cmb出力順位4.Location = New System.Drawing.Point(297, 122)
        Me.cmb出力順位4.Name = "cmb出力順位4"
        Me.cmb出力順位4.Size = New System.Drawing.Size(46, 20)
        Me.cmb出力順位4.TabIndex = 57
        '
        'cmb出力順位5
        '
        Me.cmb出力順位5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb出力順位5.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cmb出力順位5.FormattingEnabled = True
        Me.cmb出力順位5.Location = New System.Drawing.Point(297, 148)
        Me.cmb出力順位5.Name = "cmb出力順位5"
        Me.cmb出力順位5.Size = New System.Drawing.Size(46, 20)
        Me.cmb出力順位5.TabIndex = 56
        '
        'cmb出力順位6
        '
        Me.cmb出力順位6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb出力順位6.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cmb出力順位6.FormattingEnabled = True
        Me.cmb出力順位6.Location = New System.Drawing.Point(297, 174)
        Me.cmb出力順位6.Name = "cmb出力順位6"
        Me.cmb出力順位6.Size = New System.Drawing.Size(46, 20)
        Me.cmb出力順位6.TabIndex = 55
        '
        'cmb出力順位1
        '
        Me.cmb出力順位1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb出力順位1.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cmb出力順位1.FormattingEnabled = True
        Me.cmb出力順位1.Location = New System.Drawing.Point(297, 44)
        Me.cmb出力順位1.Name = "cmb出力順位1"
        Me.cmb出力順位1.Size = New System.Drawing.Size(46, 20)
        Me.cmb出力順位1.TabIndex = 54
        '
        'lbl出力順位
        '
        Me.lbl出力順位.AutoSize = True
        Me.lbl出力順位.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl出力順位.Location = New System.Drawing.Point(295, 29)
        Me.lbl出力順位.Name = "lbl出力順位"
        Me.lbl出力順位.Size = New System.Drawing.Size(53, 12)
        Me.lbl出力順位.TabIndex = 53
        Me.lbl出力順位.Text = "出力順位"
        '
        'lbl出力2
        '
        Me.lbl出力2.AutoSize = True
        Me.lbl出力2.Location = New System.Drawing.Point(34, 73)
        Me.lbl出力2.Name = "lbl出力2"
        Me.lbl出力2.Size = New System.Drawing.Size(35, 12)
        Me.lbl出力2.TabIndex = 52
        Me.lbl出力2.Text = "出力2"
        '
        'lbl出力3
        '
        Me.lbl出力3.AutoSize = True
        Me.lbl出力3.Location = New System.Drawing.Point(34, 99)
        Me.lbl出力3.Name = "lbl出力3"
        Me.lbl出力3.Size = New System.Drawing.Size(35, 12)
        Me.lbl出力3.TabIndex = 51
        Me.lbl出力3.Text = "出力3"
        '
        'lbl出力4
        '
        Me.lbl出力4.AutoSize = True
        Me.lbl出力4.Location = New System.Drawing.Point(34, 125)
        Me.lbl出力4.Name = "lbl出力4"
        Me.lbl出力4.Size = New System.Drawing.Size(35, 12)
        Me.lbl出力4.TabIndex = 50
        Me.lbl出力4.Text = "出力4"
        '
        'lbl出力5
        '
        Me.lbl出力5.AutoSize = True
        Me.lbl出力5.Location = New System.Drawing.Point(34, 151)
        Me.lbl出力5.Name = "lbl出力5"
        Me.lbl出力5.Size = New System.Drawing.Size(35, 12)
        Me.lbl出力5.TabIndex = 49
        Me.lbl出力5.Text = "出力5"
        '
        'lbl出力6
        '
        Me.lbl出力6.AutoSize = True
        Me.lbl出力6.Location = New System.Drawing.Point(34, 177)
        Me.lbl出力6.Name = "lbl出力6"
        Me.lbl出力6.Size = New System.Drawing.Size(35, 12)
        Me.lbl出力6.TabIndex = 48
        Me.lbl出力6.Text = "出力6"
        '
        'lbl出力先指定
        '
        Me.lbl出力先指定.AutoSize = True
        Me.lbl出力先指定.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl出力先指定.Location = New System.Drawing.Point(73, 29)
        Me.lbl出力先指定.Name = "lbl出力先指定"
        Me.lbl出力先指定.Size = New System.Drawing.Size(65, 12)
        Me.lbl出力先指定.TabIndex = 47
        Me.lbl出力先指定.Text = "出力先指定"
        '
        'lbl出力1
        '
        Me.lbl出力1.AutoSize = True
        Me.lbl出力1.Location = New System.Drawing.Point(34, 47)
        Me.lbl出力1.Name = "lbl出力1"
        Me.lbl出力1.Size = New System.Drawing.Size(35, 12)
        Me.lbl出力1.TabIndex = 46
        Me.lbl出力1.Text = "出力1"
        '
        'cmb出力先指定2
        '
        Me.cmb出力先指定2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb出力先指定2.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cmb出力先指定2.FormattingEnabled = True
        Me.cmb出力先指定2.Location = New System.Drawing.Point(75, 70)
        Me.cmb出力先指定2.Name = "cmb出力先指定2"
        Me.cmb出力先指定2.Size = New System.Drawing.Size(216, 20)
        Me.cmb出力先指定2.TabIndex = 45
        '
        'cmb出力先指定3
        '
        Me.cmb出力先指定3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb出力先指定3.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cmb出力先指定3.FormattingEnabled = True
        Me.cmb出力先指定3.Location = New System.Drawing.Point(75, 96)
        Me.cmb出力先指定3.Name = "cmb出力先指定3"
        Me.cmb出力先指定3.Size = New System.Drawing.Size(216, 20)
        Me.cmb出力先指定3.TabIndex = 44
        '
        'cmb出力先指定5
        '
        Me.cmb出力先指定5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb出力先指定5.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cmb出力先指定5.FormattingEnabled = True
        Me.cmb出力先指定5.Location = New System.Drawing.Point(75, 148)
        Me.cmb出力先指定5.Name = "cmb出力先指定5"
        Me.cmb出力先指定5.Size = New System.Drawing.Size(216, 20)
        Me.cmb出力先指定5.TabIndex = 43
        '
        'cmb出力先指定6
        '
        Me.cmb出力先指定6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb出力先指定6.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cmb出力先指定6.FormattingEnabled = True
        Me.cmb出力先指定6.Location = New System.Drawing.Point(75, 174)
        Me.cmb出力先指定6.Name = "cmb出力先指定6"
        Me.cmb出力先指定6.Size = New System.Drawing.Size(216, 20)
        Me.cmb出力先指定6.TabIndex = 42
        '
        'cmb出力先指定4
        '
        Me.cmb出力先指定4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb出力先指定4.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cmb出力先指定4.FormattingEnabled = True
        Me.cmb出力先指定4.Location = New System.Drawing.Point(75, 122)
        Me.cmb出力先指定4.Name = "cmb出力先指定4"
        Me.cmb出力先指定4.Size = New System.Drawing.Size(216, 20)
        Me.cmb出力先指定4.TabIndex = 41
        '
        'cmb出力先指定1
        '
        Me.cmb出力先指定1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb出力先指定1.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cmb出力先指定1.FormattingEnabled = True
        Me.cmb出力先指定1.Location = New System.Drawing.Point(75, 44)
        Me.cmb出力先指定1.Name = "cmb出力先指定1"
        Me.cmb出力先指定1.Size = New System.Drawing.Size(216, 20)
        Me.cmb出力先指定1.TabIndex = 40
        '
        'tabオーダー名称設定
        '
        Me.tabオーダー名称設定.BackColor = System.Drawing.Color.LightCyan
        Me.tabオーダー名称設定.Controls.Add(Me.lbl検索キー3)
        Me.tabオーダー名称設定.Controls.Add(Me.lbl検索キー2)
        Me.tabオーダー名称設定.Controls.Add(Me.lbl検索キー1)
        Me.tabオーダー名称設定.Controls.Add(Me.lblメニュー名5)
        Me.tabオーダー名称設定.Controls.Add(Me.lblメニュー名3)
        Me.tabオーダー名称設定.Controls.Add(Me.lblメニュー名4)
        Me.tabオーダー名称設定.Controls.Add(Me.lblメニュー名2)
        Me.tabオーダー名称設定.Controls.Add(Me.lblメニュー名１_下段)
        Me.tabオーダー名称設定.Controls.Add(Me.lblメニュー名１_上段)
        Me.tabオーダー名称設定.Controls.Add(Me.txt検索キー1)
        Me.tabオーダー名称設定.Controls.Add(Me.txt検索キー2)
        Me.tabオーダー名称設定.Controls.Add(Me.txt検索キー3)
        Me.tabオーダー名称設定.Controls.Add(Me.txtメニュー名5)
        Me.tabオーダー名称設定.Controls.Add(Me.txtメニュー名4)
        Me.tabオーダー名称設定.Controls.Add(Me.txtメニュー名3)
        Me.tabオーダー名称設定.Controls.Add(Me.txtメニュー名１_下段)
        Me.tabオーダー名称設定.Controls.Add(Me.txtメニュー名2)
        Me.tabオーダー名称設定.Controls.Add(Me.txtメニュー名１_上段)
        Me.tabオーダー名称設定.Location = New System.Drawing.Point(4, 22)
        Me.tabオーダー名称設定.Name = "tabオーダー名称設定"
        Me.tabオーダー名称設定.Padding = New System.Windows.Forms.Padding(3)
        Me.tabオーダー名称設定.Size = New System.Drawing.Size(497, 259)
        Me.tabオーダー名称設定.TabIndex = 1
        Me.tabオーダー名称設定.Text = "オーダー名称設定"
        '
        'lbl検索キー3
        '
        Me.lbl検索キー3.AutoSize = True
        Me.lbl検索キー3.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl検索キー3.Location = New System.Drawing.Point(25, 218)
        Me.lbl検索キー3.Name = "lbl検索キー3"
        Me.lbl検索キー3.Size = New System.Drawing.Size(55, 12)
        Me.lbl検索キー3.TabIndex = 66
        Me.lbl検索キー3.Text = "検索キー3"
        '
        'lbl検索キー2
        '
        Me.lbl検索キー2.AutoSize = True
        Me.lbl検索キー2.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl検索キー2.Location = New System.Drawing.Point(25, 193)
        Me.lbl検索キー2.Name = "lbl検索キー2"
        Me.lbl検索キー2.Size = New System.Drawing.Size(55, 12)
        Me.lbl検索キー2.TabIndex = 65
        Me.lbl検索キー2.Text = "検索キー2"
        '
        'lbl検索キー1
        '
        Me.lbl検索キー1.AutoSize = True
        Me.lbl検索キー1.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl検索キー1.Location = New System.Drawing.Point(25, 168)
        Me.lbl検索キー1.Name = "lbl検索キー1"
        Me.lbl検索キー1.Size = New System.Drawing.Size(55, 12)
        Me.lbl検索キー1.TabIndex = 64
        Me.lbl検索キー1.Text = "検索キー1"
        '
        'lblメニュー名5
        '
        Me.lblメニュー名5.AutoSize = True
        Me.lblメニュー名5.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblメニュー名5.Location = New System.Drawing.Point(25, 143)
        Me.lblメニュー名5.Name = "lblメニュー名5"
        Me.lblメニュー名5.Size = New System.Drawing.Size(58, 12)
        Me.lblメニュー名5.TabIndex = 63
        Me.lblメニュー名5.Text = "メニュー名5"
        '
        'lblメニュー名3
        '
        Me.lblメニュー名3.AutoSize = True
        Me.lblメニュー名3.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblメニュー名3.Location = New System.Drawing.Point(25, 93)
        Me.lblメニュー名3.Name = "lblメニュー名3"
        Me.lblメニュー名3.Size = New System.Drawing.Size(58, 12)
        Me.lblメニュー名3.TabIndex = 62
        Me.lblメニュー名3.Text = "メニュー名3"
        '
        'lblメニュー名4
        '
        Me.lblメニュー名4.AutoSize = True
        Me.lblメニュー名4.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblメニュー名4.Location = New System.Drawing.Point(25, 118)
        Me.lblメニュー名4.Name = "lblメニュー名4"
        Me.lblメニュー名4.Size = New System.Drawing.Size(58, 12)
        Me.lblメニュー名4.TabIndex = 61
        Me.lblメニュー名4.Text = "メニュー名4"
        '
        'lblメニュー名2
        '
        Me.lblメニュー名2.AutoSize = True
        Me.lblメニュー名2.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblメニュー名2.Location = New System.Drawing.Point(25, 68)
        Me.lblメニュー名2.Name = "lblメニュー名2"
        Me.lblメニュー名2.Size = New System.Drawing.Size(58, 12)
        Me.lblメニュー名2.TabIndex = 60
        Me.lblメニュー名2.Text = "メニュー名2"
        '
        'lblメニュー名１_下段
        '
        Me.lblメニュー名１_下段.AutoSize = True
        Me.lblメニュー名１_下段.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblメニュー名１_下段.Location = New System.Drawing.Point(25, 43)
        Me.lblメニュー名１_下段.Name = "lblメニュー名１_下段"
        Me.lblメニュー名１_下段.Size = New System.Drawing.Size(96, 12)
        Me.lblメニュー名１_下段.TabIndex = 59
        Me.lblメニュー名１_下段.Text = "メニュー名１（下段）"
        '
        'lblメニュー名１_上段
        '
        Me.lblメニュー名１_上段.AutoSize = True
        Me.lblメニュー名１_上段.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblメニュー名１_上段.Location = New System.Drawing.Point(25, 18)
        Me.lblメニュー名１_上段.Name = "lblメニュー名１_上段"
        Me.lblメニュー名１_上段.Size = New System.Drawing.Size(96, 12)
        Me.lblメニュー名１_上段.TabIndex = 58
        Me.lblメニュー名１_上段.Text = "メニュー名１（上段）"
        '
        'txt検索キー1
        '
        Me.txt検索キー1.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt検索キー1.Location = New System.Drawing.Point(127, 165)
        Me.txt検索キー1.Name = "txt検索キー1"
        Me.txt検索キー1.Size = New System.Drawing.Size(15, 19)
        Me.txt検索キー1.TabIndex = 57
        '
        'txt検索キー2
        '
        Me.txt検索キー2.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt検索キー2.Location = New System.Drawing.Point(127, 190)
        Me.txt検索キー2.Name = "txt検索キー2"
        Me.txt検索キー2.Size = New System.Drawing.Size(15, 19)
        Me.txt検索キー2.TabIndex = 56
        '
        'txt検索キー3
        '
        Me.txt検索キー3.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt検索キー3.Location = New System.Drawing.Point(127, 215)
        Me.txt検索キー3.Name = "txt検索キー3"
        Me.txt検索キー3.Size = New System.Drawing.Size(15, 19)
        Me.txt検索キー3.TabIndex = 55
        '
        'txtメニュー名5
        '
        Me.txtメニュー名5.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtメニュー名5.Location = New System.Drawing.Point(127, 140)
        Me.txtメニュー名5.Name = "txtメニュー名5"
        Me.txtメニュー名5.Size = New System.Drawing.Size(86, 19)
        Me.txtメニュー名5.TabIndex = 54
        '
        'txtメニュー名4
        '
        Me.txtメニュー名4.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtメニュー名4.Location = New System.Drawing.Point(127, 115)
        Me.txtメニュー名4.Name = "txtメニュー名4"
        Me.txtメニュー名4.Size = New System.Drawing.Size(128, 19)
        Me.txtメニュー名4.TabIndex = 53
        '
        'txtメニュー名3
        '
        Me.txtメニュー名3.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtメニュー名3.Location = New System.Drawing.Point(127, 90)
        Me.txtメニュー名3.Name = "txtメニュー名3"
        Me.txtメニュー名3.Size = New System.Drawing.Size(172, 19)
        Me.txtメニュー名3.TabIndex = 52
        '
        'txtメニュー名１_下段
        '
        Me.txtメニュー名１_下段.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtメニュー名１_下段.Location = New System.Drawing.Point(127, 40)
        Me.txtメニュー名１_下段.Name = "txtメニュー名１_下段"
        Me.txtメニュー名１_下段.Size = New System.Drawing.Size(216, 19)
        Me.txtメニュー名１_下段.TabIndex = 51
        '
        'txtメニュー名2
        '
        Me.txtメニュー名2.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtメニュー名2.Location = New System.Drawing.Point(127, 65)
        Me.txtメニュー名2.Name = "txtメニュー名2"
        Me.txtメニュー名2.Size = New System.Drawing.Size(216, 19)
        Me.txtメニュー名2.TabIndex = 50
        '
        'txtメニュー名１_上段
        '
        Me.txtメニュー名１_上段.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtメニュー名１_上段.Location = New System.Drawing.Point(127, 15)
        Me.txtメニュー名１_上段.Name = "txtメニュー名１_上段"
        Me.txtメニュー名１_上段.Size = New System.Drawing.Size(216, 19)
        Me.txtメニュー名１_上段.TabIndex = 40
        '
        'btnレジボタン表示名設定
        '
        Me.btnレジボタン表示名設定.BackColor = System.Drawing.Color.MistyRose
        Me.btnレジボタン表示名設定.Location = New System.Drawing.Point(240, 97)
        Me.btnレジボタン表示名設定.Name = "btnレジボタン表示名設定"
        Me.btnレジボタン表示名設定.Size = New System.Drawing.Size(105, 42)
        Me.btnレジボタン表示名設定.TabIndex = 13
        Me.btnレジボタン表示名設定.UseVisualStyleBackColor = False
        '
        'txt販売期間2
        '
        Me.txt販売期間2.Location = New System.Drawing.Point(228, 168)
        Me.txt販売期間2.Name = "txt販売期間2"
        Me.txt販売期間2.Size = New System.Drawing.Size(91, 19)
        Me.txt販売期間2.TabIndex = 31
        '
        'lbl発行しないする
        '
        Me.lbl発行しないする.AutoSize = True
        Me.lbl発行しないする.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl発行しないする.Location = New System.Drawing.Point(134, 146)
        Me.lbl発行しないする.Name = "lbl発行しないする"
        Me.lbl発行しないする.Size = New System.Drawing.Size(137, 12)
        Me.lbl発行しないする.TabIndex = 30
        Me.lbl発行しないする.Text = "０：発行しない　１：発行する"
        '
        'lblから
        '
        Me.lblから.AutoSize = True
        Me.lblから.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblから.Location = New System.Drawing.Point(205, 171)
        Me.lblから.Name = "lblから"
        Me.lblから.Size = New System.Drawing.Size(17, 12)
        Me.lblから.TabIndex = 29
        Me.lblから.Text = "～"
        '
        'txt食券発行
        '
        Me.txt食券発行.Location = New System.Drawing.Point(108, 143)
        Me.txt食券発行.Name = "txt食券発行"
        Me.txt食券発行.Size = New System.Drawing.Size(17, 19)
        Me.txt食券発行.TabIndex = 27
        '
        'txt検索カナ
        '
        Me.txt検索カナ.Location = New System.Drawing.Point(108, 74)
        Me.txt検索カナ.Name = "txt検索カナ"
        Me.txt検索カナ.Size = New System.Drawing.Size(148, 19)
        Me.txt検索カナ.TabIndex = 26
        '
        'txt単価_通常
        '
        Me.txt単価_通常.Location = New System.Drawing.Point(108, 219)
        Me.txt単価_通常.Name = "txt単価_通常"
        Me.txt単価_通常.Size = New System.Drawing.Size(70, 19)
        Me.txt単価_通常.TabIndex = 23
        '
        'txt単価_TO
        '
        Me.txt単価_TO.Location = New System.Drawing.Point(108, 244)
        Me.txt単価_TO.Name = "txt単価_TO"
        Me.txt単価_TO.Size = New System.Drawing.Size(70, 19)
        Me.txt単価_TO.TabIndex = 22
        '
        'txt販売期間1
        '
        Me.txt販売期間1.Location = New System.Drawing.Point(108, 168)
        Me.txt販売期間1.Name = "txt販売期間1"
        Me.txt販売期間1.Size = New System.Drawing.Size(91, 19)
        Me.txt販売期間1.TabIndex = 21
        '
        'txtレジボタン表示名設定_上段
        '
        Me.txtレジボタン表示名設定_上段.Location = New System.Drawing.Point(108, 99)
        Me.txtレジボタン表示名設定_上段.Name = "txtレジボタン表示名設定_上段"
        Me.txtレジボタン表示名設定_上段.Size = New System.Drawing.Size(126, 19)
        Me.txtレジボタン表示名設定_上段.TabIndex = 20
        '
        'txtレジボタン表示名設定_下段
        '
        Me.txtレジボタン表示名設定_下段.Location = New System.Drawing.Point(108, 119)
        Me.txtレジボタン表示名設定_下段.Name = "txtレジボタン表示名設定_下段"
        Me.txtレジボタン表示名設定_下段.Size = New System.Drawing.Size(126, 19)
        Me.txtレジボタン表示名設定_下段.TabIndex = 13
        '
        'txt商品名
        '
        Me.txt商品名.Location = New System.Drawing.Point(108, 49)
        Me.txt商品名.Name = "txt商品名"
        Me.txt商品名.Size = New System.Drawing.Size(148, 19)
        Me.txt商品名.TabIndex = 14
        '
        'cmbタイプ
        '
        Me.cmbタイプ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbタイプ.FormattingEnabled = True
        Me.cmbタイプ.Location = New System.Drawing.Point(108, 23)
        Me.cmbタイプ.Name = "cmbタイプ"
        Me.cmbタイプ.Size = New System.Drawing.Size(237, 20)
        Me.cmbタイプ.TabIndex = 18
        '
        'cmbテイクアウト
        '
        Me.cmbテイクアウト.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbテイクアウト.FormattingEnabled = True
        Me.cmbテイクアウト.Location = New System.Drawing.Point(108, 193)
        Me.cmbテイクアウト.Name = "cmbテイクアウト"
        Me.cmbテイクアウト.Size = New System.Drawing.Size(254, 20)
        Me.cmbテイクアウト.TabIndex = 13
        '
        'lbl課税区分2
        '
        Me.lbl課税区分2.AutoSize = True
        Me.lbl課税区分2.Location = New System.Drawing.Point(193, 248)
        Me.lbl課税区分2.Name = "lbl課税区分2"
        Me.lbl課税区分2.Size = New System.Drawing.Size(53, 12)
        Me.lbl課税区分2.TabIndex = 10
        Me.lbl課税区分2.Text = "課税区分"
        '
        'lbl課税区分1
        '
        Me.lbl課税区分1.AutoSize = True
        Me.lbl課税区分1.Location = New System.Drawing.Point(193, 222)
        Me.lbl課税区分1.Name = "lbl課税区分1"
        Me.lbl課税区分1.Size = New System.Drawing.Size(53, 12)
        Me.lbl課税区分1.TabIndex = 9
        Me.lbl課税区分1.Text = "課税区分"
        '
        'lbl単価_TO
        '
        Me.lbl単価_TO.AutoSize = True
        Me.lbl単価_TO.Location = New System.Drawing.Point(38, 247)
        Me.lbl単価_TO.Name = "lbl単価_TO"
        Me.lbl単価_TO.Size = New System.Drawing.Size(56, 12)
        Me.lbl単価_TO.TabIndex = 8
        Me.lbl単価_TO.Text = "単価（TO）"
        '
        'lbl単価_通常
        '
        Me.lbl単価_通常.AutoSize = True
        Me.lbl単価_通常.Location = New System.Drawing.Point(34, 222)
        Me.lbl単価_通常.Name = "lbl単価_通常"
        Me.lbl単価_通常.Size = New System.Drawing.Size(65, 12)
        Me.lbl単価_通常.TabIndex = 7
        Me.lbl単価_通常.Text = "単価（通常）"
        '
        'lblテイクアウト
        '
        Me.lblテイクアウト.AutoSize = True
        Me.lblテイクアウト.Location = New System.Drawing.Point(38, 196)
        Me.lblテイクアウト.Name = "lblテイクアウト"
        Me.lblテイクアウト.Size = New System.Drawing.Size(57, 12)
        Me.lblテイクアウト.TabIndex = 6
        Me.lblテイクアウト.Text = "テイクアウト"
        '
        'lbl販売期間
        '
        Me.lbl販売期間.AutoSize = True
        Me.lbl販売期間.Location = New System.Drawing.Point(40, 173)
        Me.lbl販売期間.Name = "lbl販売期間"
        Me.lbl販売期間.Size = New System.Drawing.Size(53, 12)
        Me.lbl販売期間.TabIndex = 5
        Me.lbl販売期間.Text = "販売期間"
        '
        'lbl食券発行
        '
        Me.lbl食券発行.AutoSize = True
        Me.lbl食券発行.Location = New System.Drawing.Point(40, 146)
        Me.lbl食券発行.Name = "lbl食券発行"
        Me.lbl食券発行.Size = New System.Drawing.Size(53, 12)
        Me.lbl食券発行.TabIndex = 4
        Me.lbl食券発行.Text = "食券発行"
        '
        'lblレジボタン表示名設定
        '
        Me.lblレジボタン表示名設定.AutoSize = True
        Me.lblレジボタン表示名設定.Location = New System.Drawing.Point(34, 108)
        Me.lblレジボタン表示名設定.Name = "lblレジボタン表示名設定"
        Me.lblレジボタン表示名設定.Size = New System.Drawing.Size(65, 24)
        Me.lblレジボタン表示名設定.TabIndex = 3
        Me.lblレジボタン表示名設定.Text = "レジボタン" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "表示名設定"
        '
        'lbl検索ｶﾅ
        '
        Me.lbl検索ｶﾅ.AutoSize = True
        Me.lbl検索ｶﾅ.Location = New System.Drawing.Point(44, 77)
        Me.lbl検索ｶﾅ.Name = "lbl検索ｶﾅ"
        Me.lbl検索ｶﾅ.Size = New System.Drawing.Size(44, 12)
        Me.lbl検索ｶﾅ.TabIndex = 2
        Me.lbl検索ｶﾅ.Text = "検索ｶﾅ"
        '
        'lbl商品名
        '
        Me.lbl商品名.AutoSize = True
        Me.lbl商品名.Location = New System.Drawing.Point(46, 49)
        Me.lbl商品名.Name = "lbl商品名"
        Me.lbl商品名.Size = New System.Drawing.Size(41, 12)
        Me.lbl商品名.TabIndex = 1
        Me.lbl商品名.Text = "商品名"
        '
        'lblタイプ
        '
        Me.lblタイプ.AutoSize = True
        Me.lblタイプ.Location = New System.Drawing.Point(51, 26)
        Me.lblタイプ.Name = "lblタイプ"
        Me.lblタイプ.Size = New System.Drawing.Size(31, 12)
        Me.lblタイプ.TabIndex = 0
        Me.lblタイプ.Text = "タイプ"
        '
        'grp飲食
        '
        Me.grp飲食.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.grp飲食.Controls.Add(Me.txt付加金額)
        Me.grp飲食.Controls.Add(Me.lblゼロ円明細)
        Me.grp飲食.Controls.Add(Me.txt品目CD)
        Me.grp飲食.Controls.Add(Me.lbl付加金額)
        Me.grp飲食.Controls.Add(Me.cmbゼロ円明細)
        Me.grp飲食.Controls.Add(Me.cmb提供時期)
        Me.grp飲食.Controls.Add(Me.cmb付加金額)
        Me.grp飲食.Controls.Add(Me.cmbサービス料)
        Me.grp飲食.Controls.Add(Me.cmb入力タイプ)
        Me.grp飲食.Controls.Add(Me.lbl品目CD)
        Me.grp飲食.Controls.Add(Me.lbl入力タイプ)
        Me.grp飲食.Controls.Add(Me.lbl提供時期)
        Me.grp飲食.Controls.Add(Me.lblサービス料)
        Me.grp飲食.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.grp飲食.Location = New System.Drawing.Point(430, 13)
        Me.grp飲食.Name = "grp飲食"
        Me.grp飲食.Size = New System.Drawing.Size(505, 200)
        Me.grp飲食.TabIndex = 32
        Me.grp飲食.TabStop = False
        Me.grp飲食.Text = " 飲　食 "
        '
        'txt付加金額
        '
        Me.txt付加金額.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt付加金額.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txt付加金額.Location = New System.Drawing.Point(135, 133)
        Me.txt付加金額.Name = "txt付加金額"
        Me.txt付加金額.Size = New System.Drawing.Size(75, 19)
        Me.txt付加金額.TabIndex = 39
        Me.txt付加金額.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblゼロ円明細
        '
        Me.lblゼロ円明細.AutoSize = True
        Me.lblゼロ円明細.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblゼロ円明細.Location = New System.Drawing.Point(20, 161)
        Me.lblゼロ円明細.Name = "lblゼロ円明細"
        Me.lblゼロ円明細.Size = New System.Drawing.Size(60, 12)
        Me.lblゼロ円明細.TabIndex = 16
        Me.lblゼロ円明細.Text = "ゼロ円明細"
        '
        'txt品目CD
        '
        Me.txt品目CD.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt品目CD.Location = New System.Drawing.Point(93, 30)
        Me.txt品目CD.Name = "txt品目CD"
        Me.txt品目CD.Size = New System.Drawing.Size(49, 19)
        Me.txt品目CD.TabIndex = 33
        '
        'lbl付加金額
        '
        Me.lbl付加金額.AutoSize = True
        Me.lbl付加金額.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl付加金額.Location = New System.Drawing.Point(24, 136)
        Me.lbl付加金額.Name = "lbl付加金額"
        Me.lbl付加金額.Size = New System.Drawing.Size(53, 12)
        Me.lbl付加金額.TabIndex = 15
        Me.lbl付加金額.Text = "付加金額"
        '
        'cmbゼロ円明細
        '
        Me.cmbゼロ円明細.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbゼロ円明細.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cmbゼロ円明細.FormattingEnabled = True
        Me.cmbゼロ円明細.Location = New System.Drawing.Point(93, 157)
        Me.cmbゼロ円明細.Name = "cmbゼロ円明細"
        Me.cmbゼロ円明細.Size = New System.Drawing.Size(254, 20)
        Me.cmbゼロ円明細.TabIndex = 38
        '
        'cmb提供時期
        '
        Me.cmb提供時期.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb提供時期.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cmb提供時期.FormattingEnabled = True
        Me.cmb提供時期.Location = New System.Drawing.Point(93, 81)
        Me.cmb提供時期.Name = "cmb提供時期"
        Me.cmb提供時期.Size = New System.Drawing.Size(254, 20)
        Me.cmb提供時期.TabIndex = 37
        '
        'cmb付加金額
        '
        Me.cmb付加金額.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb付加金額.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cmb付加金額.FormattingEnabled = True
        Me.cmb付加金額.Location = New System.Drawing.Point(93, 133)
        Me.cmb付加金額.Name = "cmb付加金額"
        Me.cmb付加金額.Size = New System.Drawing.Size(36, 20)
        Me.cmb付加金額.TabIndex = 36
        '
        'cmbサービス料
        '
        Me.cmbサービス料.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbサービス料.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cmbサービス料.FormattingEnabled = True
        Me.cmbサービス料.Location = New System.Drawing.Point(93, 107)
        Me.cmbサービス料.Name = "cmbサービス料"
        Me.cmbサービス料.Size = New System.Drawing.Size(254, 20)
        Me.cmbサービス料.TabIndex = 35
        '
        'cmb入力タイプ
        '
        Me.cmb入力タイプ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb入力タイプ.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cmb入力タイプ.FormattingEnabled = True
        Me.cmb入力タイプ.Location = New System.Drawing.Point(93, 55)
        Me.cmb入力タイプ.Name = "cmb入力タイプ"
        Me.cmb入力タイプ.Size = New System.Drawing.Size(254, 20)
        Me.cmb入力タイプ.TabIndex = 34
        '
        'lbl品目CD
        '
        Me.lbl品目CD.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl品目CD.Location = New System.Drawing.Point(28, 33)
        Me.lbl品目CD.Name = "lbl品目CD"
        Me.lbl品目CD.Size = New System.Drawing.Size(45, 12)
        Me.lbl品目CD.TabIndex = 11
        Me.lbl品目CD.Text = "品目CD"
        '
        'lbl入力タイプ
        '
        Me.lbl入力タイプ.AutoSize = True
        Me.lbl入力タイプ.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl入力タイプ.Location = New System.Drawing.Point(23, 58)
        Me.lbl入力タイプ.Name = "lbl入力タイプ"
        Me.lbl入力タイプ.Size = New System.Drawing.Size(55, 12)
        Me.lbl入力タイプ.TabIndex = 12
        Me.lbl入力タイプ.Text = "入力タイプ"
        '
        'lbl提供時期
        '
        Me.lbl提供時期.AutoSize = True
        Me.lbl提供時期.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl提供時期.Location = New System.Drawing.Point(24, 84)
        Me.lbl提供時期.Name = "lbl提供時期"
        Me.lbl提供時期.Size = New System.Drawing.Size(53, 12)
        Me.lbl提供時期.TabIndex = 13
        Me.lbl提供時期.Text = "提供時期"
        '
        'lblサービス料
        '
        Me.lblサービス料.AutoSize = True
        Me.lblサービス料.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblサービス料.Location = New System.Drawing.Point(23, 110)
        Me.lblサービス料.Name = "lblサービス料"
        Me.lblサービス料.Size = New System.Drawing.Size(54, 12)
        Me.lblサービス料.TabIndex = 14
        Me.lblサービス料.Text = "サービス料"
        '
        'tabセットメニューの設定
        '
        Me.tabセットメニューの設定.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.tabセットメニューの設定.Controls.Add(Me.txt数量)
        Me.tabセットメニューの設定.Controls.Add(Me.grpサブ情報)
        Me.tabセットメニューの設定.Controls.Add(Me.txt表示)
        Me.tabセットメニューの設定.Controls.Add(Me.btn選択)
        Me.tabセットメニューの設定.Controls.Add(Me.txt設定)
        Me.tabセットメニューの設定.Controls.Add(Me.txt名称)
        Me.tabセットメニューの設定.Controls.Add(Me.grpグループ名一覧)
        Me.tabセットメニューの設定.Controls.Add(Me.txt番号)
        Me.tabセットメニューの設定.Location = New System.Drawing.Point(4, 22)
        Me.tabセットメニューの設定.Name = "tabセットメニューの設定"
        Me.tabセットメニューの設定.Padding = New System.Windows.Forms.Padding(3)
        Me.tabセットメニューの設定.Size = New System.Drawing.Size(980, 595)
        Me.tabセットメニューの設定.TabIndex = 1
        Me.tabセットメニューの設定.Text = "セットメニューの設定"
        Me.tabセットメニューの設定.UseVisualStyleBackColor = True
        '
        'txt数量
        '
        Me.txt数量.Location = New System.Drawing.Point(362, 476)
        Me.txt数量.Name = "txt数量"
        Me.txt数量.Size = New System.Drawing.Size(94, 19)
        Me.txt数量.TabIndex = 55
        '
        'grpサブ情報
        '
        Me.grpサブ情報.Controls.Add(Me.grpサブ情報_設定)
        Me.grpサブ情報.Controls.Add(Me.btn取消)
        Me.grpサブ情報.Controls.Add(Me.dgvサブ情報)
        Me.grpサブ情報.Location = New System.Drawing.Point(456, 6)
        Me.grpサブ情報.Name = "grpサブ情報"
        Me.grpサブ情報.Size = New System.Drawing.Size(530, 577)
        Me.grpサブ情報.TabIndex = 60
        Me.grpサブ情報.TabStop = False
        Me.grpサブ情報.Text = "サブ情報"
        '
        'grpサブ情報_設定
        '
        Me.grpサブ情報_設定.Controls.Add(Me.cmbハンディ表示)
        Me.grpサブ情報_設定.Controls.Add(Me.cmb設定区分)
        Me.grpサブ情報_設定.Controls.Add(Me.cmb数量エラーチェック)
        Me.grpサブ情報_設定.Controls.Add(Me.lblハンディ表示)
        Me.grpサブ情報_設定.Controls.Add(Me.lbl数量エラーチェック)
        Me.grpサブ情報_設定.Controls.Add(Me.lbl設定区分)
        Me.grpサブ情報_設定.Location = New System.Drawing.Point(6, 495)
        Me.grpサブ情報_設定.Name = "grpサブ情報_設定"
        Me.grpサブ情報_設定.Size = New System.Drawing.Size(518, 71)
        Me.grpサブ情報_設定.TabIndex = 61
        Me.grpサブ情報_設定.TabStop = False
        '
        'cmbハンディ表示
        '
        Me.cmbハンディ表示.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbハンディ表示.FormattingEnabled = True
        Me.cmbハンディ表示.Location = New System.Drawing.Point(341, 15)
        Me.cmbハンディ表示.Name = "cmbハンディ表示"
        Me.cmbハンディ表示.Size = New System.Drawing.Size(133, 20)
        Me.cmbハンディ表示.TabIndex = 61
        '
        'cmb設定区分
        '
        Me.cmb設定区分.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb設定区分.FormattingEnabled = True
        Me.cmb設定区分.Location = New System.Drawing.Point(109, 15)
        Me.cmb設定区分.Name = "cmb設定区分"
        Me.cmb設定区分.Size = New System.Drawing.Size(133, 20)
        Me.cmb設定区分.TabIndex = 60
        '
        'cmb数量エラーチェック
        '
        Me.cmb数量エラーチェック.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb数量エラーチェック.FormattingEnabled = True
        Me.cmb数量エラーチェック.Location = New System.Drawing.Point(109, 41)
        Me.cmb数量エラーチェック.Name = "cmb数量エラーチェック"
        Me.cmb数量エラーチェック.Size = New System.Drawing.Size(365, 20)
        Me.cmb数量エラーチェック.TabIndex = 13
        '
        'lblハンディ表示
        '
        Me.lblハンディ表示.AutoSize = True
        Me.lblハンディ表示.Location = New System.Drawing.Point(263, 18)
        Me.lblハンディ表示.Name = "lblハンディ表示"
        Me.lblハンディ表示.Size = New System.Drawing.Size(65, 12)
        Me.lblハンディ表示.TabIndex = 57
        Me.lblハンディ表示.Text = "ハンディ表示"
        '
        'lbl数量エラーチェック
        '
        Me.lbl数量エラーチェック.AutoSize = True
        Me.lbl数量エラーチェック.Location = New System.Drawing.Point(16, 44)
        Me.lbl数量エラーチェック.Name = "lbl数量エラーチェック"
        Me.lbl数量エラーチェック.Size = New System.Drawing.Size(87, 12)
        Me.lbl数量エラーチェック.TabIndex = 55
        Me.lbl数量エラーチェック.Text = "数量エラーチェック"
        '
        'lbl設定区分
        '
        Me.lbl設定区分.AutoSize = True
        Me.lbl設定区分.Location = New System.Drawing.Point(33, 18)
        Me.lbl設定区分.Name = "lbl設定区分"
        Me.lbl設定区分.Size = New System.Drawing.Size(53, 12)
        Me.lbl設定区分.TabIndex = 54
        Me.lbl設定区分.Text = "設定区分"
        '
        'btn取消
        '
        Me.btn取消.BackColor = System.Drawing.Color.Tomato
        Me.btn取消.Location = New System.Drawing.Point(403, 13)
        Me.btn取消.Name = "btn取消"
        Me.btn取消.Size = New System.Drawing.Size(121, 27)
        Me.btn取消.TabIndex = 54
        Me.btn取消.Text = "取消"
        Me.btn取消.UseVisualStyleBackColor = False
        '
        'dgvサブ情報
        '
        Me.dgvサブ情報.AllowUserToAddRows = False
        Me.dgvサブ情報.AllowUserToDeleteRows = False
        Me.dgvサブ情報.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvサブ情報.Location = New System.Drawing.Point(6, 46)
        Me.dgvサブ情報.Name = "dgvサブ情報"
        Me.dgvサブ情報.ReadOnly = True
        Me.dgvサブ情報.RowTemplate.Height = 21
        Me.dgvサブ情報.Size = New System.Drawing.Size(518, 443)
        Me.dgvサブ情報.TabIndex = 50
        '
        'txt表示
        '
        Me.txt表示.Location = New System.Drawing.Point(362, 450)
        Me.txt表示.Name = "txt表示"
        Me.txt表示.Size = New System.Drawing.Size(94, 19)
        Me.txt表示.TabIndex = 54
        '
        'btn選択
        '
        Me.btn選択.Font = New System.Drawing.Font("MS UI Gothic", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn選択.Location = New System.Drawing.Point(368, 221)
        Me.btn選択.Name = "btn選択"
        Me.btn選択.Size = New System.Drawing.Size(82, 81)
        Me.btn選択.TabIndex = 59
        Me.btn選択.Text = ">"
        Me.btn選択.UseVisualStyleBackColor = True
        '
        'txt設定
        '
        Me.txt設定.Location = New System.Drawing.Point(362, 425)
        Me.txt設定.Name = "txt設定"
        Me.txt設定.Size = New System.Drawing.Size(94, 19)
        Me.txt設定.TabIndex = 53
        '
        'txt名称
        '
        Me.txt名称.Location = New System.Drawing.Point(362, 400)
        Me.txt名称.Name = "txt名称"
        Me.txt名称.Size = New System.Drawing.Size(94, 19)
        Me.txt名称.TabIndex = 52
        '
        'grpグループ名一覧
        '
        Me.grpグループ名一覧.Controls.Add(Me.dgvグループ名一覧)
        Me.grpグループ名一覧.Location = New System.Drawing.Point(6, 6)
        Me.grpグループ名一覧.Name = "grpグループ名一覧"
        Me.grpグループ名一覧.Size = New System.Drawing.Size(356, 577)
        Me.grpグループ名一覧.TabIndex = 58
        Me.grpグループ名一覧.TabStop = False
        Me.grpグループ名一覧.Text = "グループ名一覧"
        '
        'dgvグループ名一覧
        '
        Me.dgvグループ名一覧.AllowUserToAddRows = False
        Me.dgvグループ名一覧.AllowUserToDeleteRows = False
        Me.dgvグループ名一覧.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvグループ名一覧.Location = New System.Drawing.Point(6, 26)
        Me.dgvグループ名一覧.MultiSelect = False
        Me.dgvグループ名一覧.Name = "dgvグループ名一覧"
        Me.dgvグループ名一覧.ReadOnly = True
        Me.dgvグループ名一覧.RowTemplate.Height = 21
        Me.dgvグループ名一覧.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvグループ名一覧.Size = New System.Drawing.Size(344, 540)
        Me.dgvグループ名一覧.TabIndex = 50
        '
        'txt番号
        '
        Me.txt番号.Location = New System.Drawing.Point(362, 375)
        Me.txt番号.Name = "txt番号"
        Me.txt番号.Size = New System.Drawing.Size(94, 19)
        Me.txt番号.TabIndex = 51
        '
        'frm105商品登録_登録画面
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1007, 729)
        Me.Controls.Add(Me.grpメニュー)
        Me.Controls.Add(Me.tab登録設定)
        Me.Name = "frm105商品登録_登録画面"
        Me.Text = "登録画面"
        Me.grpメニュー.ResumeLayout(False)
        Me.grpメニュー.PerformLayout()
        Me.tab登録設定.ResumeLayout(False)
        Me.tab基本設定.ResumeLayout(False)
        Me.tab基本設定.PerformLayout()
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabオーダー設定.ResumeLayout(False)
        Me.tabオーダー出力先設定.ResumeLayout(False)
        Me.tabオーダー出力先設定.PerformLayout()
        Me.tabオーダー名称設定.ResumeLayout(False)
        Me.tabオーダー名称設定.PerformLayout()
        Me.grp飲食.ResumeLayout(False)
        Me.grp飲食.PerformLayout()
        Me.tabセットメニューの設定.ResumeLayout(False)
        Me.tabセットメニューの設定.PerformLayout()
        Me.grpサブ情報.ResumeLayout(False)
        Me.grpサブ情報_設定.ResumeLayout(False)
        Me.grpサブ情報_設定.PerformLayout()
        CType(Me.dgvサブ情報, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpグループ名一覧.ResumeLayout(False)
        CType(Me.dgvグループ名一覧, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpメニュー As GroupBox
    Friend WithEvents btn終了 As Button
    Friend WithEvents btnエクスポート As Button
    Friend WithEvents btnコピー As Button
    Friend WithEvents btnキャンセル As Button
    Friend WithEvents btnクリア As Button
    Friend WithEvents btn更新 As Button
    Friend WithEvents btn検索 As Button
    Friend WithEvents btn読込 As Button
    Friend WithEvents txt商品CD As TextBox
    Friend WithEvents lbl商品CD As Label
    Friend WithEvents cmbPOSパターン As ComboBox
    Friend WithEvents lblPOSパターン As Label
    Friend WithEvents tab登録設定 As TabControl
    Friend WithEvents tab基本設定 As TabPage
    Friend WithEvents tabセットメニューの設定 As TabPage
    Friend WithEvents lblタイプ As Label
    Friend WithEvents lbl単価_通常 As Label
    Friend WithEvents lblテイクアウト As Label
    Friend WithEvents lbl販売期間 As Label
    Friend WithEvents lbl食券発行 As Label
    Friend WithEvents lblレジボタン表示名設定 As Label
    Friend WithEvents lbl検索ｶﾅ As Label
    Friend WithEvents lbl商品名 As Label
    Friend WithEvents lbl課税区分1 As Label
    Friend WithEvents lbl単価_TO As Label
    Friend WithEvents txt販売期間2 As TextBox
    Friend WithEvents lbl発行しないする As Label
    Friend WithEvents lblから As Label
    Friend WithEvents txt食券発行 As TextBox
    Friend WithEvents txt検索カナ As TextBox
    Friend WithEvents txt単価_通常 As TextBox
    Friend WithEvents txt単価_TO As TextBox
    Friend WithEvents txt販売期間1 As TextBox
    Friend WithEvents txtレジボタン表示名設定_上段 As TextBox
    Friend WithEvents txtレジボタン表示名設定_下段 As TextBox
    Friend WithEvents txt商品名 As TextBox
    Friend WithEvents cmbタイプ As ComboBox
    Friend WithEvents cmbテイクアウト As ComboBox
    Friend WithEvents lbl課税区分2 As Label
    Friend WithEvents grp飲食 As GroupBox
    Friend WithEvents lblゼロ円明細 As Label
    Friend WithEvents lbl付加金額 As Label
    Friend WithEvents lblサービス料 As Label
    Friend WithEvents lbl提供時期 As Label
    Friend WithEvents lbl入力タイプ As Label
    Friend WithEvents lbl品目CD As Label
    Friend WithEvents txt付加金額 As TextBox
    Friend WithEvents txt品目CD As TextBox
    Friend WithEvents cmbゼロ円明細 As ComboBox
    Friend WithEvents cmb提供時期 As ComboBox
    Friend WithEvents cmb付加金額 As ComboBox
    Friend WithEvents cmbサービス料 As ComboBox
    Friend WithEvents cmb入力タイプ As ComboBox
    Friend WithEvents btnレジボタン表示名設定 As Button
    Friend WithEvents tabオーダー設定 As TabControl
    Friend WithEvents tabオーダー出力先設定 As TabPage
    Friend WithEvents tabオーダー名称設定 As TabPage
    Friend WithEvents cmb出力先指定2 As ComboBox
    Friend WithEvents cmb出力先指定3 As ComboBox
    Friend WithEvents cmb出力先指定5 As ComboBox
    Friend WithEvents cmb出力先指定6 As ComboBox
    Friend WithEvents cmb出力先指定4 As ComboBox
    Friend WithEvents cmb出力先指定1 As ComboBox
    Friend WithEvents cmb出力順位2 As ComboBox
    Friend WithEvents cmb出力順位3 As ComboBox
    Friend WithEvents cmb出力順位4 As ComboBox
    Friend WithEvents cmb出力順位5 As ComboBox
    Friend WithEvents cmb出力順位6 As ComboBox
    Friend WithEvents cmb出力順位1 As ComboBox
    Friend WithEvents lbl出力順位 As Label
    Friend WithEvents lbl出力2 As Label
    Friend WithEvents lbl出力3 As Label
    Friend WithEvents lbl出力4 As Label
    Friend WithEvents lbl出力5 As Label
    Friend WithEvents lbl出力6 As Label
    Friend WithEvents lbl出力先指定 As Label
    Friend WithEvents lbl出力1 As Label
    Friend WithEvents cmb課税区分1 As ComboBox
    Friend WithEvents cmb課税区分2 As ComboBox
    Friend WithEvents lbl検索キー3 As Label
    Friend WithEvents lbl検索キー2 As Label
    Friend WithEvents lbl検索キー1 As Label
    Friend WithEvents lblメニュー名5 As Label
    Friend WithEvents lblメニュー名3 As Label
    Friend WithEvents lblメニュー名4 As Label
    Friend WithEvents lblメニュー名2 As Label
    Friend WithEvents lblメニュー名１_下段 As Label
    Friend WithEvents lblメニュー名１_上段 As Label
    Friend WithEvents txt検索キー1 As TextBox
    Friend WithEvents txt検索キー2 As TextBox
    Friend WithEvents txt検索キー3 As TextBox
    Friend WithEvents txtメニュー名5 As TextBox
    Friend WithEvents txtメニュー名4 As TextBox
    Friend WithEvents txtメニュー名3 As TextBox
    Friend WithEvents txtメニュー名１_下段 As TextBox
    Friend WithEvents txtメニュー名2 As TextBox
    Friend WithEvents txtメニュー名１_上段 As TextBox
    Friend WithEvents grpサブ情報 As GroupBox
    Friend WithEvents grpサブ情報_設定 As GroupBox
    Friend WithEvents lblハンディ表示 As Label
    Friend WithEvents lbl数量エラーチェック As Label
    Friend WithEvents lbl設定区分 As Label
    Friend WithEvents btn取消 As Button
    Friend WithEvents dgvサブ情報 As DataGridView
    Friend WithEvents btn選択 As Button
    Friend WithEvents grpグループ名一覧 As GroupBox
    Friend WithEvents dgvグループ名一覧 As DataGridView
    Friend WithEvents cmb数量エラーチェック As ComboBox
    Friend WithEvents cmbハンディ表示 As ComboBox
    Friend WithEvents cmb設定区分 As ComboBox
    Friend WithEvents dgvData As DataGridView
    Friend WithEvents txt数量 As TextBox
    Friend WithEvents txt表示 As TextBox
    Friend WithEvents txt設定 As TextBox
    Friend WithEvents txt名称 As TextBox
    Friend WithEvents txt番号 As TextBox
End Class
