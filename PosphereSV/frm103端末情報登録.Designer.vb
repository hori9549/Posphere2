<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm103端末情報登録
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgv一覧 = New System.Windows.Forms.DataGridView()
        Me.col端末CD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col端末名 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPOSパターン = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPOS種別 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col端末IPアドレス = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colマスタ用フォルダ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn終了 = New System.Windows.Forms.Button()
        Me.btnエクスポート = New System.Windows.Forms.Button()
        Me.btnインポート = New System.Windows.Forms.Button()
        Me.txt1 = New System.Windows.Forms.TextBox()
        Me.lbl端末CD = New System.Windows.Forms.Label()
        CType(Me.dgv一覧, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv一覧
        '
        Me.dgv一覧.AllowUserToAddRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv一覧.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv一覧.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv一覧.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col端末CD, Me.col端末名, Me.colPOSパターン, Me.colPOS種別, Me.col端末IPアドレス, Me.colマスタ用フォルダ})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv一覧.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv一覧.Location = New System.Drawing.Point(8, 156)
        Me.dgv一覧.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.dgv一覧.Name = "dgv一覧"
        Me.dgv一覧.RowTemplate.Height = 21
        Me.dgv一覧.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv一覧.Size = New System.Drawing.Size(989, 334)
        Me.dgv一覧.TabIndex = 17
        '
        'col端末CD
        '
        Me.col端末CD.DataPropertyName = "端末CD"
        Me.col端末CD.HeaderText = "端末CD"
        Me.col端末CD.Name = "col端末CD"
        Me.col端末CD.Width = 90
        '
        'col端末名
        '
        Me.col端末名.DataPropertyName = "端末名"
        Me.col端末名.HeaderText = "端末名"
        Me.col端末名.Name = "col端末名"
        Me.col端末名.Width = 150
        '
        'colPOSパターン
        '
        Me.colPOSパターン.DataPropertyName = "POSパターン"
        Me.colPOSパターン.HeaderText = "POSパターン"
        Me.colPOSパターン.MinimumWidth = 10
        Me.colPOSパターン.Name = "colPOSパターン"
        Me.colPOSパターン.Width = 160
        '
        'colPOS種別
        '
        Me.colPOS種別.DataPropertyName = "POS種別"
        Me.colPOS種別.HeaderText = "POS種別"
        Me.colPOS種別.Name = "colPOS種別"
        Me.colPOS種別.Width = 160
        '
        'col端末IPアドレス
        '
        Me.col端末IPアドレス.DataPropertyName = "端末IPアドレス"
        Me.col端末IPアドレス.HeaderText = "端末IPアドレス"
        Me.col端末IPアドレス.MinimumWidth = 10
        Me.col端末IPアドレス.Name = "col端末IPアドレス"
        Me.col端末IPアドレス.Width = 180
        '
        'colマスタ用フォルダ
        '
        Me.colマスタ用フォルダ.DataPropertyName = "マスタ用フォルダ"
        Me.colマスタ用フォルダ.HeaderText = "マスタ用フォルダ"
        Me.colマスタ用フォルダ.Name = "colマスタ用フォルダ"
        Me.colマスタ用フォルダ.Width = 180
        '
        'btn終了
        '
        Me.btn終了.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn終了.Location = New System.Drawing.Point(897, 45)
        Me.btn終了.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btn終了.Name = "btn終了"
        Me.btn終了.Size = New System.Drawing.Size(100, 50)
        Me.btn終了.TabIndex = 25
        Me.btn終了.Text = "終了"
        Me.btn終了.UseVisualStyleBackColor = True
        '
        'btnエクスポート
        '
        Me.btnエクスポート.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnエクスポート.Location = New System.Drawing.Point(800, 45)
        Me.btnエクスポート.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnエクスポート.Name = "btnエクスポート"
        Me.btnエクスポート.Size = New System.Drawing.Size(100, 50)
        Me.btnエクスポート.TabIndex = 24
        Me.btnエクスポート.Text = "エクスポート"
        Me.btnエクスポート.UseVisualStyleBackColor = True
        '
        'btnインポート
        '
        Me.btnインポート.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnインポート.Location = New System.Drawing.Point(703, 45)
        Me.btnインポート.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnインポート.Name = "btnインポート"
        Me.btnインポート.Size = New System.Drawing.Size(100, 50)
        Me.btnインポート.TabIndex = 23
        Me.btnインポート.Text = "インポート"
        Me.btnインポート.UseVisualStyleBackColor = True
        '
        'txt1
        '
        Me.txt1.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt1.Location = New System.Drawing.Point(85, 33)
        Me.txt1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(66, 23)
        Me.txt1.TabIndex = 27
        '
        'lbl端末CD
        '
        Me.lbl端末CD.AutoSize = True
        Me.lbl端末CD.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl端末CD.Location = New System.Drawing.Point(20, 36)
        Me.lbl端末CD.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl端末CD.Name = "lbl端末CD"
        Me.lbl端末CD.Size = New System.Drawing.Size(61, 16)
        Me.lbl端末CD.TabIndex = 26
        Me.lbl端末CD.Text = "端末CD"
        '
        'frm103端末情報登録
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.txt1)
        Me.Controls.Add(Me.lbl端末CD)
        Me.Controls.Add(Me.btn終了)
        Me.Controls.Add(Me.btnエクスポート)
        Me.Controls.Add(Me.btnインポート)
        Me.Controls.Add(Me.dgv一覧)
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Name = "frm103端末情報登録"
        Me.Text = "frm端末情報登録vb"
        CType(Me.dgv一覧, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv一覧 As DataGridView
    Friend WithEvents btn終了 As Button
    Friend WithEvents btnエクスポート As Button
    Friend WithEvents btnインポート As Button
    Friend WithEvents txt1 As TextBox
    Friend WithEvents lbl端末CD As Label
    Friend WithEvents col端末CD As DataGridViewTextBoxColumn
    Friend WithEvents col端末名 As DataGridViewTextBoxColumn
    Friend WithEvents colPOSパターン As DataGridViewTextBoxColumn
    Friend WithEvents colPOS種別 As DataGridViewTextBoxColumn
    Friend WithEvents col端末IPアドレス As DataGridViewTextBoxColumn
    Friend WithEvents colマスタ用フォルダ As DataGridViewTextBoxColumn
End Class
