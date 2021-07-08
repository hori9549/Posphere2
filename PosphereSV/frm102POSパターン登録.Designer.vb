<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPOSパターン
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
        Me.btn更新 = New System.Windows.Forms.Button()
        Me.btn削除 = New System.Windows.Forms.Button()
        Me.btnキャンセル = New System.Windows.Forms.Button()
        Me.btn終了 = New System.Windows.Forms.Button()
        Me.btnエクスポート = New System.Windows.Forms.Button()
        Me.btnインポート = New System.Windows.Forms.Button()
        Me.lblPOSパターン = New System.Windows.Forms.Label()
        Me.txtPOSパターンボタン = New System.Windows.Forms.TextBox()
        Me.colPOSパターン = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colパターン名称 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colオーダーリング接続 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colオーダリングIPアドレス = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgv一覧, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv一覧
        '
        Me.dgv一覧.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv一覧.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv一覧.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colPOSパターン, Me.colパターン名称, Me.colオーダーリング接続, Me.colオーダリングIPアドレス})
        Me.dgv一覧.Location = New System.Drawing.Point(12, 61)
        Me.dgv一覧.Name = "dgv一覧"
        Me.dgv一覧.RowTemplate.Height = 21
        Me.dgv一覧.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv一覧.Size = New System.Drawing.Size(1160, 629)
        Me.dgv一覧.TabIndex = 8
        '
        'btn更新
        '
        Me.btn更新.Location = New System.Drawing.Point(375, 13)
        Me.btn更新.Name = "btn更新"
        Me.btn更新.Size = New System.Drawing.Size(88, 41)
        Me.btn更新.TabIndex = 10
        Me.btn更新.UseVisualStyleBackColor = True
        '
        'btn削除
        '
        Me.btn削除.Location = New System.Drawing.Point(459, 13)
        Me.btn削除.Name = "btn削除"
        Me.btn削除.Size = New System.Drawing.Size(88, 42)
        Me.btn削除.TabIndex = 11
        Me.btn削除.UseVisualStyleBackColor = True
        '
        'btnキャンセル
        '
        Me.btnキャンセル.Location = New System.Drawing.Point(542, 13)
        Me.btnキャンセル.Name = "btnキャンセル"
        Me.btnキャンセル.Size = New System.Drawing.Size(88, 42)
        Me.btnキャンセル.TabIndex = 12
        Me.btnキャンセル.UseVisualStyleBackColor = True
        '
        'btn終了
        '
        Me.btn終了.Location = New System.Drawing.Point(915, 12)
        Me.btn終了.Name = "btn終了"
        Me.btn終了.Size = New System.Drawing.Size(88, 42)
        Me.btn終了.TabIndex = 15
        Me.btn終了.Text = "終了"
        Me.btn終了.UseVisualStyleBackColor = True
        '
        'btnエクスポート
        '
        Me.btnエクスポート.Location = New System.Drawing.Point(831, 12)
        Me.btnエクスポート.Name = "btnエクスポート"
        Me.btnエクスポート.Size = New System.Drawing.Size(88, 42)
        Me.btnエクスポート.TabIndex = 14
        Me.btnエクスポート.Text = "エクスポート"
        Me.btnエクスポート.UseVisualStyleBackColor = True
        '
        'btnインポート
        '
        Me.btnインポート.Location = New System.Drawing.Point(747, 12)
        Me.btnインポート.Name = "btnインポート"
        Me.btnインポート.Size = New System.Drawing.Size(88, 42)
        Me.btnインポート.TabIndex = 13
        Me.btnインポート.Text = "インポート"
        Me.btnインポート.UseVisualStyleBackColor = True
        '
        'lblPOSパターン
        '
        Me.lblPOSパターン.AutoSize = True
        Me.lblPOSパターン.Location = New System.Drawing.Point(22, 29)
        Me.lblPOSパターン.Name = "lblPOSパターン"
        Me.lblPOSパターン.Size = New System.Drawing.Size(64, 12)
        Me.lblPOSパターン.TabIndex = 16
        Me.lblPOSパターン.Text = "POSパターン"
        '
        'txtPOSパターンボタン
        '
        Me.txtPOSパターンボタン.Location = New System.Drawing.Point(214, 27)
        Me.txtPOSパターンボタン.Name = "txtPOSパターンボタン"
        Me.txtPOSパターンボタン.Size = New System.Drawing.Size(67, 19)
        Me.txtPOSパターンボタン.TabIndex = 17
        '
        'colPOSパターン
        '
        Me.colPOSパターン.DataPropertyName = "POSパターン"
        Me.colPOSパターン.HeaderText = "POSパターン"
        Me.colPOSパターン.Name = "colPOSパターン"
        Me.colPOSパターン.Width = 120
        '
        'colパターン名称
        '
        Me.colパターン名称.DataPropertyName = "パターン名称"
        Me.colパターン名称.HeaderText = "パターン名称"
        Me.colパターン名称.MinimumWidth = 10
        Me.colパターン名称.Name = "colパターン名称"
        Me.colパターン名称.Width = 380
        '
        'colオーダーリング接続
        '
        Me.colオーダーリング接続.DataPropertyName = "オーダリング接続"
        Me.colオーダーリング接続.HeaderText = "オーダリング接続"
        Me.colオーダーリング接続.MinimumWidth = 10
        Me.colオーダーリング接続.Name = "colオーダーリング接続"
        Me.colオーダーリング接続.Width = 200
        '
        'colオーダリングIPアドレス
        '
        Me.colオーダリングIPアドレス.DataPropertyName = "オーダリングIPアドレス"
        Me.colオーダリングIPアドレス.HeaderText = "IPアドレス"
        Me.colオーダリングIPアドレス.MinimumWidth = 10
        Me.colオーダリングIPアドレス.Name = "colオーダリングIPアドレス"
        Me.colオーダリングIPアドレス.Width = 240
        '
        'frmPOSパターン
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 707)
        Me.Controls.Add(Me.txtPOSパターンボタン)
        Me.Controls.Add(Me.lblPOSパターン)
        Me.Controls.Add(Me.btn終了)
        Me.Controls.Add(Me.btnエクスポート)
        Me.Controls.Add(Me.btnインポート)
        Me.Controls.Add(Me.btnキャンセル)
        Me.Controls.Add(Me.btn削除)
        Me.Controls.Add(Me.btn更新)
        Me.Controls.Add(Me.dgv一覧)
        Me.Name = "frmPOSパターン"
        Me.Text = "POSパターン登録"
        CType(Me.dgv一覧, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgv一覧 As DataGridView
    Friend WithEvents btn更新 As Button
    Friend WithEvents btn削除 As Button
    Friend WithEvents btnキャンセル As Button
    Friend WithEvents btn終了 As Button
    Friend WithEvents btnエクスポート As Button
    Friend WithEvents btnインポート As Button
    Friend WithEvents lblPOSパターン As Label
    Friend WithEvents txtPOSパターンボタン As TextBox
    Friend WithEvents colPOSパターン As DataGridViewTextBoxColumn
    Friend WithEvents colパターン名称 As DataGridViewTextBoxColumn
    Friend WithEvents colオーダーリング接続 As DataGridViewTextBoxColumn
    Friend WithEvents colオーダリングIPアドレス As DataGridViewTextBoxColumn
End Class
