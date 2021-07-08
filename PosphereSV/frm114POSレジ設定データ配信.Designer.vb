<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmレジ設定データ配信
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblPOSパターン = New System.Windows.Forms.Label()
        Me.cmb1 = New System.Windows.Forms.ComboBox()
        Me.btn読込 = New System.Windows.Forms.Button()
        Me.btn疎通確認 = New System.Windows.Forms.Button()
        Me.btn配信 = New System.Windows.Forms.Button()
        Me.btn終了 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.colＮｏ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col配信有無 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col端末名称 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colＩＰアドレス = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col状態 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col前回通信日時 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col配信フォルダ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblPOSパターン
        '
        Me.lblPOSパターン.AutoSize = True
        Me.lblPOSパターン.Location = New System.Drawing.Point(37, 30)
        Me.lblPOSパターン.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblPOSパターン.Name = "lblPOSパターン"
        Me.lblPOSパターン.Size = New System.Drawing.Size(98, 18)
        Me.lblPOSパターン.TabIndex = 0
        Me.lblPOSパターン.Text = "POSパターン"
        '
        'cmb1
        '
        Me.cmb1.FormattingEnabled = True
        Me.cmb1.Location = New System.Drawing.Point(153, 26)
        Me.cmb1.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmb1.Name = "cmb1"
        Me.cmb1.Size = New System.Drawing.Size(531, 26)
        Me.cmb1.TabIndex = 1
        '
        'btn読込
        '
        Me.btn読込.Location = New System.Drawing.Point(732, 28)
        Me.btn読込.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btn読込.Name = "btn読込"
        Me.btn読込.Size = New System.Drawing.Size(135, 56)
        Me.btn読込.TabIndex = 2
        Me.btn読込.Text = "読込"
        Me.btn読込.UseVisualStyleBackColor = True
        '
        'btn疎通確認
        '
        Me.btn疎通確認.Location = New System.Drawing.Point(1128, 28)
        Me.btn疎通確認.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btn疎通確認.Name = "btn疎通確認"
        Me.btn疎通確認.Size = New System.Drawing.Size(135, 56)
        Me.btn疎通確認.TabIndex = 3
        Me.btn疎通確認.Text = "疎通確認"
        Me.btn疎通確認.UseVisualStyleBackColor = True
        '
        'btn配信
        '
        Me.btn配信.Location = New System.Drawing.Point(1310, 28)
        Me.btn配信.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btn配信.Name = "btn配信"
        Me.btn配信.Size = New System.Drawing.Size(135, 56)
        Me.btn配信.TabIndex = 4
        Me.btn配信.Text = "配信"
        Me.btn配信.UseVisualStyleBackColor = True
        '
        'btn終了
        '
        Me.btn終了.Location = New System.Drawing.Point(1492, 28)
        Me.btn終了.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btn終了.Name = "btn終了"
        Me.btn終了.Size = New System.Drawing.Size(135, 56)
        Me.btn終了.TabIndex = 5
        Me.btn終了.Text = "終了"
        Me.btn終了.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colＮｏ, Me.col配信有無, Me.col端末名称, Me.colＩＰアドレス, Me.col状態, Me.col前回通信日時, Me.col配信フォルダ})
        Me.DataGridView1.Location = New System.Drawing.Point(40, 102)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 21
        Me.DataGridView1.Size = New System.Drawing.Size(1942, 798)
        Me.DataGridView1.TabIndex = 6
        '
        'colＮｏ
        '
        Me.colＮｏ.HeaderText = "Ｎｏ"
        Me.colＮｏ.MinimumWidth = 8
        Me.colＮｏ.Name = "colＮｏ"
        Me.colＮｏ.Width = 150
        '
        'col配信有無
        '
        Me.col配信有無.HeaderText = "配信有無"
        Me.col配信有無.MinimumWidth = 8
        Me.col配信有無.Name = "col配信有無"
        Me.col配信有無.Width = 150
        '
        'col端末名称
        '
        Me.col端末名称.HeaderText = "端末名称"
        Me.col端末名称.MinimumWidth = 8
        Me.col端末名称.Name = "col端末名称"
        Me.col端末名称.Width = 150
        '
        'colＩＰアドレス
        '
        Me.colＩＰアドレス.HeaderText = "ＩＰアドレス"
        Me.colＩＰアドレス.MinimumWidth = 8
        Me.colＩＰアドレス.Name = "colＩＰアドレス"
        Me.colＩＰアドレス.Width = 150
        '
        'col状態
        '
        Me.col状態.HeaderText = "状態"
        Me.col状態.MinimumWidth = 8
        Me.col状態.Name = "col状態"
        Me.col状態.Width = 150
        '
        'col前回通信日時
        '
        Me.col前回通信日時.HeaderText = "前回通信日時"
        Me.col前回通信日時.MinimumWidth = 8
        Me.col前回通信日時.Name = "col前回通信日時"
        Me.col前回通信日時.Width = 150
        '
        'col配信フォルダ
        '
        Me.col配信フォルダ.HeaderText = "配信フォルダ"
        Me.col配信フォルダ.MinimumWidth = 8
        Me.col配信フォルダ.Name = "col配信フォルダ"
        Me.col配信フォルダ.Width = 150
        '
        'frmレジ設定データ配信
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1680, 1094)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btn終了)
        Me.Controls.Add(Me.btn配信)
        Me.Controls.Add(Me.btn疎通確認)
        Me.Controls.Add(Me.btn読込)
        Me.Controls.Add(Me.cmb1)
        Me.Controls.Add(Me.lblPOSパターン)
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "frmレジ設定データ配信"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPOSパターン As Label
    Friend WithEvents cmb1 As ComboBox
    Friend WithEvents btn読込 As Button
    Friend WithEvents btn疎通確認 As Button
    Friend WithEvents btn配信 As Button
    Friend WithEvents btn終了 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents colＮｏ As DataGridViewTextBoxColumn
    Friend WithEvents col配信有無 As DataGridViewTextBoxColumn
    Friend WithEvents col端末名称 As DataGridViewTextBoxColumn
    Friend WithEvents colＩＰアドレス As DataGridViewTextBoxColumn
    Friend WithEvents col状態 As DataGridViewTextBoxColumn
    Friend WithEvents col前回通信日時 As DataGridViewTextBoxColumn
    Friend WithEvents col配信フォルダ As DataGridViewTextBoxColumn
End Class
