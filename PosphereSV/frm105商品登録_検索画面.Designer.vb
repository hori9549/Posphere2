<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm105商品登録_検索画面
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
        Me.lblJANコード = New System.Windows.Forms.Label()
        Me.lbl検索カナ = New System.Windows.Forms.Label()
        Me.txtJANコード = New System.Windows.Forms.TextBox()
        Me.cmb部門 = New System.Windows.Forms.ComboBox()
        Me.txt検索カナ = New System.Windows.Forms.TextBox()
        Me.btn閉じる = New System.Windows.Forms.Button()
        Me.btn条件クリア = New System.Windows.Forms.Button()
        Me.btn選択 = New System.Windows.Forms.Button()
        Me.btn検索 = New System.Windows.Forms.Button()
        Me.lbl部門 = New System.Windows.Forms.Label()
        Me.cmb分類 = New System.Windows.Forms.ComboBox()
        Me.lbl分類 = New System.Windows.Forms.Label()
        Me.dgv一覧 = New System.Windows.Forms.DataGridView()
        Me.cmbPOSパターン = New System.Windows.Forms.ComboBox()
        Me.txt商品CD = New System.Windows.Forms.TextBox()
        Me.lblPOSパターン = New System.Windows.Forms.Label()
        Me.grpメニュー.SuspendLayout()
        CType(Me.dgv一覧, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpメニュー
        '
        Me.grpメニュー.Controls.Add(Me.lblJANコード)
        Me.grpメニュー.Controls.Add(Me.lbl検索カナ)
        Me.grpメニュー.Controls.Add(Me.txtJANコード)
        Me.grpメニュー.Controls.Add(Me.cmb部門)
        Me.grpメニュー.Controls.Add(Me.txt検索カナ)
        Me.grpメニュー.Controls.Add(Me.btn閉じる)
        Me.grpメニュー.Controls.Add(Me.btn条件クリア)
        Me.grpメニュー.Controls.Add(Me.btn選択)
        Me.grpメニュー.Controls.Add(Me.btn検索)
        Me.grpメニュー.Controls.Add(Me.lbl部門)
        Me.grpメニュー.Controls.Add(Me.cmb分類)
        Me.grpメニュー.Controls.Add(Me.lbl分類)
        Me.grpメニュー.Location = New System.Drawing.Point(10, 3)
        Me.grpメニュー.Name = "grpメニュー"
        Me.grpメニュー.Size = New System.Drawing.Size(995, 77)
        Me.grpメニュー.TabIndex = 34
        Me.grpメニュー.TabStop = False
        '
        'lblJANコード
        '
        Me.lblJANコード.AutoSize = True
        Me.lblJANコード.Location = New System.Drawing.Point(307, 45)
        Me.lblJANコード.Name = "lblJANコード"
        Me.lblJANコード.Size = New System.Drawing.Size(55, 12)
        Me.lblJANコード.TabIndex = 18
        Me.lblJANコード.Text = "JANコード"
        '
        'lbl検索カナ
        '
        Me.lbl検索カナ.AutoSize = True
        Me.lbl検索カナ.Location = New System.Drawing.Point(309, 20)
        Me.lbl検索カナ.Name = "lbl検索カナ"
        Me.lbl検索カナ.Size = New System.Drawing.Size(48, 12)
        Me.lbl検索カナ.TabIndex = 17
        Me.lbl検索カナ.Text = "検索カナ"
        '
        'txtJANコード
        '
        Me.txtJANコード.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txtJANコード.Location = New System.Drawing.Point(368, 41)
        Me.txtJANコード.Multiline = True
        Me.txtJANコード.Name = "txtJANコード"
        Me.txtJANコード.Size = New System.Drawing.Size(212, 20)
        Me.txtJANコード.TabIndex = 16
        '
        'cmb部門
        '
        Me.cmb部門.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb部門.FormattingEnabled = True
        Me.cmb部門.Location = New System.Drawing.Point(69, 41)
        Me.cmb部門.Name = "cmb部門"
        Me.cmb部門.Size = New System.Drawing.Size(212, 20)
        Me.cmb部門.TabIndex = 15
        '
        'txt検索カナ
        '
        Me.txt検索カナ.ImeMode = System.Windows.Forms.ImeMode.KatakanaHalf
        Me.txt検索カナ.Location = New System.Drawing.Point(368, 18)
        Me.txt検索カナ.Multiline = True
        Me.txt検索カナ.Name = "txt検索カナ"
        Me.txt検索カナ.Size = New System.Drawing.Size(212, 20)
        Me.txt検索カナ.TabIndex = 14
        '
        'btn閉じる
        '
        Me.btn閉じる.Location = New System.Drawing.Point(907, 18)
        Me.btn閉じる.Name = "btn閉じる"
        Me.btn閉じる.Size = New System.Drawing.Size(80, 45)
        Me.btn閉じる.TabIndex = 12
        Me.btn閉じる.Text = "閉じる"
        Me.btn閉じる.UseVisualStyleBackColor = True
        '
        'btn条件クリア
        '
        Me.btn条件クリア.Enabled = False
        Me.btn条件クリア.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn条件クリア.Location = New System.Drawing.Point(796, 18)
        Me.btn条件クリア.Name = "btn条件クリア"
        Me.btn条件クリア.Size = New System.Drawing.Size(80, 45)
        Me.btn条件クリア.TabIndex = 8
        Me.btn条件クリア.Text = "条件クリア"
        Me.btn条件クリア.UseVisualStyleBackColor = True
        '
        'btn選択
        '
        Me.btn選択.Enabled = False
        Me.btn選択.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn選択.Location = New System.Drawing.Point(685, 18)
        Me.btn選択.Name = "btn選択"
        Me.btn選択.Size = New System.Drawing.Size(80, 45)
        Me.btn選択.TabIndex = 7
        Me.btn選択.Text = "選択"
        Me.btn選択.UseVisualStyleBackColor = True
        '
        'btn検索
        '
        Me.btn検索.Location = New System.Drawing.Point(599, 18)
        Me.btn検索.Name = "btn検索"
        Me.btn検索.Size = New System.Drawing.Size(80, 45)
        Me.btn検索.TabIndex = 6
        Me.btn検索.Text = "検索"
        Me.btn検索.UseVisualStyleBackColor = True
        '
        'lbl部門
        '
        Me.lbl部門.AutoSize = True
        Me.lbl部門.Location = New System.Drawing.Point(24, 45)
        Me.lbl部門.Name = "lbl部門"
        Me.lbl部門.Size = New System.Drawing.Size(29, 12)
        Me.lbl部門.TabIndex = 3
        Me.lbl部門.Text = "部門"
        '
        'cmb分類
        '
        Me.cmb分類.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb分類.FormattingEnabled = True
        Me.cmb分類.Location = New System.Drawing.Point(69, 17)
        Me.cmb分類.Name = "cmb分類"
        Me.cmb分類.Size = New System.Drawing.Size(212, 20)
        Me.cmb分類.TabIndex = 2
        '
        'lbl分類
        '
        Me.lbl分類.AutoSize = True
        Me.lbl分類.Location = New System.Drawing.Point(24, 20)
        Me.lbl分類.Name = "lbl分類"
        Me.lbl分類.Size = New System.Drawing.Size(29, 12)
        Me.lbl分類.TabIndex = 0
        Me.lbl分類.Text = "分類"
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
        Me.dgv一覧.Size = New System.Drawing.Size(988, 602)
        Me.dgv一覧.TabIndex = 44
        '
        'cmbPOSパターン
        '
        Me.cmbPOSパターン.BackColor = System.Drawing.SystemColors.Window
        Me.cmbPOSパターン.Cursor = System.Windows.Forms.Cursors.SizeAll
        Me.cmbPOSパターン.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.cmbPOSパターン.Enabled = False
        Me.cmbPOSパターン.FormattingEnabled = True
        Me.cmbPOSパターン.Location = New System.Drawing.Point(97, 86)
        Me.cmbPOSパターン.Name = "cmbPOSパターン"
        Me.cmbPOSパターン.Size = New System.Drawing.Size(86, 20)
        Me.cmbPOSパターン.TabIndex = 19
        '
        'txt商品CD
        '
        Me.txt商品CD.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt商品CD.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txt商品CD.Location = New System.Drawing.Point(205, 89)
        Me.txt商品CD.Name = "txt商品CD"
        Me.txt商品CD.Size = New System.Drawing.Size(86, 12)
        Me.txt商品CD.TabIndex = 45
        '
        'lblPOSパターン
        '
        Me.lblPOSパターン.AutoSize = True
        Me.lblPOSパターン.Location = New System.Drawing.Point(27, 89)
        Me.lblPOSパターン.Name = "lblPOSパターン"
        Me.lblPOSパターン.Size = New System.Drawing.Size(64, 12)
        Me.lblPOSパターン.TabIndex = 46
        Me.lblPOSパターン.Text = "POSパターン"
        '
        'frm105商品登録_検索画面
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1009, 729)
        Me.Controls.Add(Me.lblPOSパターン)
        Me.Controls.Add(Me.txt商品CD)
        Me.Controls.Add(Me.cmbPOSパターン)
        Me.Controls.Add(Me.grpメニュー)
        Me.Controls.Add(Me.dgv一覧)
        Me.Name = "frm105商品登録_検索画面"
        Me.Text = "検索画面"
        Me.grpメニュー.ResumeLayout(False)
        Me.grpメニュー.PerformLayout()
        CType(Me.dgv一覧, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpメニュー As GroupBox
    Friend WithEvents btn閉じる As Button
    Friend WithEvents btn条件クリア As Button
    Friend WithEvents btn選択 As Button
    Friend WithEvents btn検索 As Button
    Friend WithEvents lbl部門 As Label
    Friend WithEvents cmb分類 As ComboBox
    Friend WithEvents lbl分類 As Label
    Friend WithEvents dgv一覧 As DataGridView
    Friend WithEvents txt検索カナ As TextBox
    Friend WithEvents cmb部門 As ComboBox
    Friend WithEvents txtJANコード As TextBox
    Friend WithEvents lblJANコード As Label
    Friend WithEvents lbl検索カナ As Label
    Friend WithEvents cmbPOSパターン As ComboBox
    Friend WithEvents txt商品CD As TextBox
    Friend WithEvents lblPOSパターン As Label
End Class
