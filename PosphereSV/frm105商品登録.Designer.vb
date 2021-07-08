<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm105商品登録
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
        Me.lblPOSパターン = New System.Windows.Forms.Label()
        Me.cmbPOSパターン = New System.Windows.Forms.ComboBox()
        Me.lbl商品CD = New System.Windows.Forms.Label()
        Me.txt商品CD = New System.Windows.Forms.TextBox()
        Me.btn読込 = New System.Windows.Forms.Button()
        Me.btn検索 = New System.Windows.Forms.Button()
        Me.btn更新 = New System.Windows.Forms.Button()
        Me.btnクリア = New System.Windows.Forms.Button()
        Me.btnキャンセル = New System.Windows.Forms.Button()
        Me.btnコピー = New System.Windows.Forms.Button()
        Me.btnエクスポート = New System.Windows.Forms.Button()
        Me.btn終了 = New System.Windows.Forms.Button()
        Me.grpメニュー = New System.Windows.Forms.GroupBox()
        Me.txt文字検索類 = New System.Windows.Forms.TextBox()
        Me.dgv一覧 = New System.Windows.Forms.DataGridView()
        Me.lbl文字検索類 = New System.Windows.Forms.Label()
        Me.cmb分類 = New System.Windows.Forms.ComboBox()
        Me.lbl分類 = New System.Windows.Forms.Label()
        Me.cmb部門 = New System.Windows.Forms.ComboBox()
        Me.lbl部門 = New System.Windows.Forms.Label()
        Me.cmb表示内容 = New System.Windows.Forms.ComboBox()
        Me.lbl表示内容 = New System.Windows.Forms.Label()
        Me.btn条件クリア = New System.Windows.Forms.Button()
        Me.txtCD = New System.Windows.Forms.TextBox()
        Me.grpメニュー.SuspendLayout()
        CType(Me.dgv一覧, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'cmbPOSパターン
        '
        Me.cmbPOSパターン.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPOSパターン.FormattingEnabled = True
        Me.cmbPOSパターン.Location = New System.Drawing.Point(70, 15)
        Me.cmbPOSパターン.Name = "cmbPOSパターン"
        Me.cmbPOSパターン.Size = New System.Drawing.Size(226, 20)
        Me.cmbPOSパターン.TabIndex = 2
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
        'txt商品CD
        '
        Me.txt商品CD.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txt商品CD.Location = New System.Drawing.Point(70, 41)
        Me.txt商品CD.Name = "txt商品CD"
        Me.txt商品CD.Size = New System.Drawing.Size(105, 19)
        Me.txt商品CD.TabIndex = 4
        '
        'btn読込
        '
        Me.btn読込.Location = New System.Drawing.Point(306, 17)
        Me.btn読込.Name = "btn読込"
        Me.btn読込.Size = New System.Drawing.Size(80, 45)
        Me.btn読込.TabIndex = 5
        Me.btn読込.Text = "読込"
        Me.btn読込.UseVisualStyleBackColor = True
        '
        'btn検索
        '
        Me.btn検索.Location = New System.Drawing.Point(392, 17)
        Me.btn検索.Name = "btn検索"
        Me.btn検索.Size = New System.Drawing.Size(80, 45)
        Me.btn検索.TabIndex = 6
        Me.btn検索.Text = "検索"
        Me.btn検索.UseVisualStyleBackColor = True
        '
        'btn更新
        '
        Me.btn更新.Enabled = False
        Me.btn更新.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.btn更新.Location = New System.Drawing.Point(478, 17)
        Me.btn更新.Name = "btn更新"
        Me.btn更新.Size = New System.Drawing.Size(80, 45)
        Me.btn更新.TabIndex = 7
        Me.btn更新.Text = "更新"
        Me.btn更新.UseVisualStyleBackColor = True
        '
        'btnクリア
        '
        Me.btnクリア.Enabled = False
        Me.btnクリア.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.btnクリア.Location = New System.Drawing.Point(564, 17)
        Me.btnクリア.Name = "btnクリア"
        Me.btnクリア.Size = New System.Drawing.Size(80, 45)
        Me.btnクリア.TabIndex = 8
        Me.btnクリア.Text = "クリア"
        Me.btnクリア.UseVisualStyleBackColor = True
        '
        'btnキャンセル
        '
        Me.btnキャンセル.Enabled = False
        Me.btnキャンセル.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.btnキャンセル.Location = New System.Drawing.Point(650, 17)
        Me.btnキャンセル.Name = "btnキャンセル"
        Me.btnキャンセル.Size = New System.Drawing.Size(80, 45)
        Me.btnキャンセル.TabIndex = 9
        Me.btnキャンセル.Text = "キャンセル"
        Me.btnキャンセル.UseVisualStyleBackColor = True
        '
        'btnコピー
        '
        Me.btnコピー.Location = New System.Drawing.Point(736, 17)
        Me.btnコピー.Name = "btnコピー"
        Me.btnコピー.Size = New System.Drawing.Size(80, 45)
        Me.btnコピー.TabIndex = 10
        Me.btnコピー.Text = "コピー"
        Me.btnコピー.UseVisualStyleBackColor = True
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
        'btn終了
        '
        Me.btn終了.Location = New System.Drawing.Point(908, 17)
        Me.btn終了.Name = "btn終了"
        Me.btn終了.Size = New System.Drawing.Size(80, 45)
        Me.btn終了.TabIndex = 12
        Me.btn終了.Text = "終了"
        Me.btn終了.UseVisualStyleBackColor = True
        '
        'grpメニュー
        '
        Me.grpメニュー.Controls.Add(Me.txtCD)
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
        Me.grpメニュー.TabIndex = 24
        Me.grpメニュー.TabStop = False
        '
        'txt文字検索類
        '
        Me.txt文字検索類.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.txt文字検索類.Location = New System.Drawing.Point(675, 90)
        Me.txt文字検索類.Name = "txt文字検索類"
        Me.txt文字検索類.Size = New System.Drawing.Size(234, 19)
        Me.txt文字検索類.TabIndex = 31
        '
        'dgv一覧
        '
        Me.dgv一覧.AllowUserToAddRows = False
        Me.dgv一覧.AllowUserToDeleteRows = False
        Me.dgv一覧.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv一覧.Location = New System.Drawing.Point(10, 115)
        Me.dgv一覧.MultiSelect = False
        Me.dgv一覧.Name = "dgv一覧"
        Me.dgv一覧.ReadOnly = True
        Me.dgv一覧.RowTemplate.Height = 21
        Me.dgv一覧.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv一覧.Size = New System.Drawing.Size(1000, 602)
        Me.dgv一覧.TabIndex = 33
        '
        'lbl文字検索類
        '
        Me.lbl文字検索類.AutoSize = True
        Me.lbl文字検索類.Location = New System.Drawing.Point(604, 92)
        Me.lbl文字検索類.Name = "lbl文字検索類"
        Me.lbl文字検索類.Size = New System.Drawing.Size(65, 12)
        Me.lbl文字検索類.TabIndex = 30
        Me.lbl文字検索類.Text = "文字検索類"
        '
        'cmb分類
        '
        Me.cmb分類.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb分類.FormattingEnabled = True
        Me.cmb分類.Location = New System.Drawing.Point(428, 89)
        Me.cmb分類.Name = "cmb分類"
        Me.cmb分類.Size = New System.Drawing.Size(170, 20)
        Me.cmb分類.TabIndex = 29
        '
        'lbl分類
        '
        Me.lbl分類.AutoSize = True
        Me.lbl分類.Location = New System.Drawing.Point(393, 92)
        Me.lbl分類.Name = "lbl分類"
        Me.lbl分類.Size = New System.Drawing.Size(29, 12)
        Me.lbl分類.TabIndex = 28
        Me.lbl分類.Text = "分類"
        '
        'cmb部門
        '
        Me.cmb部門.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb部門.FormattingEnabled = True
        Me.cmb部門.Location = New System.Drawing.Point(217, 89)
        Me.cmb部門.Name = "cmb部門"
        Me.cmb部門.Size = New System.Drawing.Size(170, 20)
        Me.cmb部門.TabIndex = 27
        '
        'lbl部門
        '
        Me.lbl部門.AutoSize = True
        Me.lbl部門.Location = New System.Drawing.Point(182, 92)
        Me.lbl部門.Name = "lbl部門"
        Me.lbl部門.Size = New System.Drawing.Size(29, 12)
        Me.lbl部門.TabIndex = 26
        Me.lbl部門.Text = "部門"
        '
        'cmb表示内容
        '
        Me.cmb表示内容.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb表示内容.FormattingEnabled = True
        Me.cmb表示内容.Location = New System.Drawing.Point(70, 89)
        Me.cmb表示内容.Name = "cmb表示内容"
        Me.cmb表示内容.Size = New System.Drawing.Size(106, 20)
        Me.cmb表示内容.TabIndex = 25
        '
        'lbl表示内容
        '
        Me.lbl表示内容.AutoSize = True
        Me.lbl表示内容.Location = New System.Drawing.Point(11, 92)
        Me.lbl表示内容.Name = "lbl表示内容"
        Me.lbl表示内容.Size = New System.Drawing.Size(53, 12)
        Me.lbl表示内容.TabIndex = 24
        Me.lbl表示内容.Text = "表示内容"
        '
        'btn条件クリア
        '
        Me.btn条件クリア.Location = New System.Drawing.Point(915, 90)
        Me.btn条件クリア.Name = "btn条件クリア"
        Me.btn条件クリア.Size = New System.Drawing.Size(90, 20)
        Me.btn条件クリア.TabIndex = 32
        Me.btn条件クリア.Text = "条件クリア"
        Me.btn条件クリア.UseVisualStyleBackColor = True
        '
        'txtCD
        '
        Me.txtCD.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCD.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txtCD.Location = New System.Drawing.Point(210, 44)
        Me.txtCD.Name = "txtCD"
        Me.txtCD.Size = New System.Drawing.Size(86, 12)
        Me.txtCD.TabIndex = 34
        '
        'frm105商品登録
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.txt文字検索類)
        Me.Controls.Add(Me.grpメニュー)
        Me.Controls.Add(Me.dgv一覧)
        Me.Controls.Add(Me.lbl文字検索類)
        Me.Controls.Add(Me.btn条件クリア)
        Me.Controls.Add(Me.cmb分類)
        Me.Controls.Add(Me.lbl表示内容)
        Me.Controls.Add(Me.lbl分類)
        Me.Controls.Add(Me.cmb表示内容)
        Me.Controls.Add(Me.cmb部門)
        Me.Controls.Add(Me.lbl部門)
        Me.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.Name = "frm105商品登録"
        Me.Text = "商品登録"
        Me.grpメニュー.ResumeLayout(False)
        Me.grpメニュー.PerformLayout()
        CType(Me.dgv一覧, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPOSパターン As Label
    Friend WithEvents cmbPOSパターン As ComboBox
    Friend WithEvents lbl商品CD As Label
    Friend WithEvents txt商品CD As TextBox
    Friend WithEvents btn読込 As Button
    Friend WithEvents btn検索 As Button
    Friend WithEvents btn更新 As Button
    Friend WithEvents btnクリア As Button
    Friend WithEvents btnキャンセル As Button
    Friend WithEvents btnコピー As Button
    Friend WithEvents btnエクスポート As Button
    Friend WithEvents btn終了 As Button
    Friend WithEvents grpメニュー As GroupBox
    Friend WithEvents txt文字検索類 As TextBox
    Friend WithEvents dgv一覧 As DataGridView
    Friend WithEvents lbl文字検索類 As Label
    Friend WithEvents cmb分類 As ComboBox
    Friend WithEvents lbl分類 As Label
    Friend WithEvents cmb部門 As ComboBox
    Friend WithEvents lbl部門 As Label
    Friend WithEvents cmb表示内容 As ComboBox
    Friend WithEvents lbl表示内容 As Label
    Friend WithEvents btn条件クリア As Button
    Friend WithEvents txtCD As TextBox
End Class
