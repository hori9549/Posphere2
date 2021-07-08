<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm104グループ登録
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
        Me.dgv一覧 = New System.Windows.Forms.DataGridView()
        Me.col1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col３ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn終了 = New System.Windows.Forms.Button()
        Me.btnエクスポート = New System.Windows.Forms.Button()
        Me.btn読込 = New System.Windows.Forms.Button()
        Me.btnキャンセル = New System.Windows.Forms.Button()
        Me.btn削除 = New System.Windows.Forms.Button()
        Me.btn更新 = New System.Windows.Forms.Button()
        Me.lblPOSパターン = New System.Windows.Forms.Label()
        Me.txtグループ番号 = New System.Windows.Forms.TextBox()
        Me.lblグループ番号 = New System.Windows.Forms.Label()
        Me.cmbPOSパターン = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgv一覧, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv一覧
        '
        Me.dgv一覧.AllowUserToAddRows = False
        Me.dgv一覧.AllowUserToDeleteRows = False
        Me.dgv一覧.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv一覧.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv一覧.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col1, Me.col2, Me.col３})
        Me.dgv一覧.Location = New System.Drawing.Point(65, 174)
        Me.dgv一覧.Margin = New System.Windows.Forms.Padding(4)
        Me.dgv一覧.MultiSelect = False
        Me.dgv一覧.Name = "dgv一覧"
        Me.dgv一覧.ReadOnly = True
        Me.dgv一覧.RowHeadersWidth = 51
        Me.dgv一覧.RowTemplate.Height = 21
        Me.dgv一覧.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv一覧.Size = New System.Drawing.Size(1089, 672)
        Me.dgv一覧.TabIndex = 4
        '
        'col1
        '
        Me.col1.DataPropertyName = "グループ番号"
        Me.col1.HeaderText = "グループ番号"
        Me.col1.MinimumWidth = 6
        Me.col1.Name = "col1"
        Me.col1.ReadOnly = True
        Me.col1.Width = 125
        '
        'col2
        '
        Me.col2.DataPropertyName = "種別"
        Me.col2.HeaderText = "種別"
        Me.col2.MinimumWidth = 6
        Me.col2.Name = "col2"
        Me.col2.ReadOnly = True
        Me.col2.Width = 125
        '
        'col３
        '
        Me.col３.DataPropertyName = "グループ名"
        Me.col３.HeaderText = "グループ名"
        Me.col３.MinimumWidth = 6
        Me.col３.Name = "col３"
        Me.col３.ReadOnly = True
        Me.col３.Width = 125
        '
        'btn終了
        '
        Me.btn終了.Location = New System.Drawing.Point(1201, 29)
        Me.btn終了.Margin = New System.Windows.Forms.Padding(4)
        Me.btn終了.Name = "btn終了"
        Me.btn終了.Size = New System.Drawing.Size(117, 52)
        Me.btn終了.TabIndex = 30
        Me.btn終了.Text = "終了"
        Me.btn終了.UseVisualStyleBackColor = True
        '
        'btnエクスポート
        '
        Me.btnエクスポート.ForeColor = System.Drawing.Color.SlateGray
        Me.btnエクスポート.Location = New System.Drawing.Point(1089, 29)
        Me.btnエクスポート.Margin = New System.Windows.Forms.Padding(4)
        Me.btnエクスポート.Name = "btnエクスポート"
        Me.btnエクスポート.Size = New System.Drawing.Size(117, 52)
        Me.btnエクスポート.TabIndex = 29
        Me.btnエクスポート.Text = "エクスポート"
        Me.btnエクスポート.UseVisualStyleBackColor = True
        '
        'btn読込
        '
        Me.btn読込.Location = New System.Drawing.Point(600, 30)
        Me.btn読込.Margin = New System.Windows.Forms.Padding(4)
        Me.btn読込.Name = "btn読込"
        Me.btn読込.Size = New System.Drawing.Size(117, 52)
        Me.btn読込.TabIndex = 1
        Me.btn読込.Text = "読込"
        Me.btn読込.UseVisualStyleBackColor = True
        '
        'btnキャンセル
        '
        Me.btnキャンセル.Enabled = False
        Me.btnキャンセル.Location = New System.Drawing.Point(964, 29)
        Me.btnキャンセル.Margin = New System.Windows.Forms.Padding(4)
        Me.btnキャンセル.Name = "btnキャンセル"
        Me.btnキャンセル.Size = New System.Drawing.Size(117, 52)
        Me.btnキャンセル.TabIndex = 27
        Me.btnキャンセル.Text = "キャンセル"
        Me.btnキャンセル.UseVisualStyleBackColor = True
        '
        'btn削除
        '
        Me.btn削除.Enabled = False
        Me.btn削除.Location = New System.Drawing.Point(852, 29)
        Me.btn削除.Margin = New System.Windows.Forms.Padding(4)
        Me.btn削除.Name = "btn削除"
        Me.btn削除.Size = New System.Drawing.Size(117, 52)
        Me.btn削除.TabIndex = 26
        Me.btn削除.Text = "削除"
        Me.btn削除.UseVisualStyleBackColor = True
        '
        'btn更新
        '
        Me.btn更新.BackColor = System.Drawing.SystemColors.Control
        Me.btn更新.Enabled = False
        Me.btn更新.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn更新.Location = New System.Drawing.Point(740, 29)
        Me.btn更新.Margin = New System.Windows.Forms.Padding(4)
        Me.btn更新.Name = "btn更新"
        Me.btn更新.Size = New System.Drawing.Size(117, 52)
        Me.btn更新.TabIndex = 25
        Me.btn更新.Text = "更新"
        Me.btn更新.UseVisualStyleBackColor = False
        '
        'lblPOSパターン
        '
        Me.lblPOSパターン.AutoSize = True
        Me.lblPOSパターン.Location = New System.Drawing.Point(63, 32)
        Me.lblPOSパターン.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPOSパターン.Name = "lblPOSパターン"
        Me.lblPOSパターン.Size = New System.Drawing.Size(81, 15)
        Me.lblPOSパターン.TabIndex = 33
        Me.lblPOSパターン.Text = "POSパターン"
        '
        'txtグループ番号
        '
        Me.txtグループ番号.Location = New System.Drawing.Point(209, 74)
        Me.txtグループ番号.Margin = New System.Windows.Forms.Padding(4)
        Me.txtグループ番号.Name = "txtグループ番号"
        Me.txtグループ番号.Size = New System.Drawing.Size(99, 22)
        Me.txtグループ番号.TabIndex = 2
        '
        'lblグループ番号
        '
        Me.lblグループ番号.AutoSize = True
        Me.lblグループ番号.Location = New System.Drawing.Point(63, 82)
        Me.lblグループ番号.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblグループ番号.Name = "lblグループ番号"
        Me.lblグループ番号.Size = New System.Drawing.Size(84, 15)
        Me.lblグループ番号.TabIndex = 35
        Me.lblグループ番号.Text = "グループ番号"
        '
        'cmbPOSパターン
        '
        Me.cmbPOSパターン.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPOSパターン.FormattingEnabled = True
        Me.cmbPOSパターン.ItemHeight = 15
        Me.cmbPOSパターン.Location = New System.Drawing.Point(209, 29)
        Me.cmbPOSパターン.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbPOSパターン.Name = "cmbPOSパターン"
        Me.cmbPOSパターン.Size = New System.Drawing.Size(235, 23)
        Me.cmbPOSパターン.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(63, 124)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(251, 15)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "※　POSパターンの選択から始めてください"
        '
        'Frm104グループ登録
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1344, 911)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgv一覧)
        Me.Controls.Add(Me.cmbPOSパターン)
        Me.Controls.Add(Me.txtグループ番号)
        Me.Controls.Add(Me.lblグループ番号)
        Me.Controls.Add(Me.lblPOSパターン)
        Me.Controls.Add(Me.btn終了)
        Me.Controls.Add(Me.btnエクスポート)
        Me.Controls.Add(Me.btn読込)
        Me.Controls.Add(Me.btnキャンセル)
        Me.Controls.Add(Me.btn削除)
        Me.Controls.Add(Me.btn更新)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Frm104グループ登録"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "グループ登録"
        CType(Me.dgv一覧, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv一覧 As DataGridView
    Friend WithEvents btn終了 As Button
    Friend WithEvents btnエクスポート As Button
    Friend WithEvents btn読込 As Button
    Friend WithEvents btnキャンセル As Button
    Friend WithEvents btn削除 As Button
    Friend WithEvents btn更新 As Button
    Friend WithEvents lblPOSパターン As Label
    Friend WithEvents txtグループ番号 As TextBox
    Friend WithEvents lblグループ番号 As Label
    Friend WithEvents cmbPOSパターン As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents col1 As DataGridViewTextBoxColumn
    Friend WithEvents col2 As DataGridViewTextBoxColumn
    Friend WithEvents col３ As DataGridViewTextBoxColumn
End Class
