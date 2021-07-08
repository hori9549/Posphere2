<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm117POS背面画像ファイル配信
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
        Me.lbl配信元フォルダ = New System.Windows.Forms.Label()
        Me.btn参照１ = New System.Windows.Forms.Button()
        Me.txt参照box1 = New System.Windows.Forms.TextBox()
        Me.btn終了 = New System.Windows.Forms.Button()
        Me.btn配信 = New System.Windows.Forms.Button()
        Me.btn一覧表示 = New System.Windows.Forms.Button()
        Me.lblposパターン = New System.Windows.Forms.Label()
        Me.grpPOS更新プログラム配信 = New System.Windows.Forms.DataGridView()
        Me.cmbposパターン = New System.Windows.Forms.ComboBox()
        Me.btn読込 = New System.Windows.Forms.Button()
        CType(Me.grpPOS更新プログラム配信, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl配信元フォルダ
        '
        Me.lbl配信元フォルダ.AutoSize = True
        Me.lbl配信元フォルダ.Location = New System.Drawing.Point(78, 56)
        Me.lbl配信元フォルダ.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.lbl配信元フォルダ.Name = "lbl配信元フォルダ"
        Me.lbl配信元フォルダ.Size = New System.Drawing.Size(179, 24)
        Me.lbl配信元フォルダ.TabIndex = 1
        Me.lbl配信元フォルダ.Text = "  配信元フォルダ  "
        '
        'btn参照１
        '
        Me.btn参照１.Location = New System.Drawing.Point(314, 40)
        Me.btn参照１.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.btn参照１.Name = "btn参照１"
        Me.btn参照１.Size = New System.Drawing.Size(117, 58)
        Me.btn参照１.TabIndex = 3
        Me.btn参照１.Text = "参照"
        Me.btn参照１.UseVisualStyleBackColor = True
        '
        'txt参照box1
        '
        Me.txt参照box1.Location = New System.Drawing.Point(524, 50)
        Me.txt参照box1.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.txt参照box1.Name = "txt参照box1"
        Me.txt参照box1.Size = New System.Drawing.Size(786, 31)
        Me.txt参照box1.TabIndex = 5
        Me.txt参照box1.Text = "D:\AP\POS\SpreadN_UPDT"
        '
        'btn終了
        '
        Me.btn終了.Location = New System.Drawing.Point(1876, 44)
        Me.btn終了.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.btn終了.Name = "btn終了"
        Me.btn終了.Size = New System.Drawing.Size(184, 82)
        Me.btn終了.TabIndex = 15
        Me.btn終了.Text = "終了"
        Me.btn終了.UseVisualStyleBackColor = True
        '
        'btn配信
        '
        Me.btn配信.Location = New System.Drawing.Point(1655, 44)
        Me.btn配信.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.btn配信.Name = "btn配信"
        Me.btn配信.Size = New System.Drawing.Size(178, 82)
        Me.btn配信.TabIndex = 14
        Me.btn配信.Text = "配信"
        Me.btn配信.UseVisualStyleBackColor = True
        '
        'btn一覧表示
        '
        Me.btn一覧表示.Location = New System.Drawing.Point(1408, 44)
        Me.btn一覧表示.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.btn一覧表示.Name = "btn一覧表示"
        Me.btn一覧表示.Size = New System.Drawing.Size(204, 82)
        Me.btn一覧表示.TabIndex = 13
        Me.btn一覧表示.Text = "疎通確認"
        Me.btn一覧表示.UseVisualStyleBackColor = True
        '
        'lblposパターン
        '
        Me.lblposパターン.AutoSize = True
        Me.lblposパターン.Location = New System.Drawing.Point(78, 170)
        Me.lblposパターン.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.lblposパターン.Name = "lblposパターン"
        Me.lblposパターン.Size = New System.Drawing.Size(159, 24)
        Me.lblposパターン.TabIndex = 16
        Me.lblposパターン.Text = "  POSパターン  "
        '
        'grpPOS更新プログラム配信
        '
        Me.grpPOS更新プログラム配信.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grpPOS更新プログラム配信.Location = New System.Drawing.Point(-2, 242)
        Me.grpPOS更新プログラム配信.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.grpPOS更新プログラム配信.Name = "grpPOS更新プログラム配信"
        Me.grpPOS更新プログラム配信.RowHeadersWidth = 82
        Me.grpPOS更新プログラム配信.RowTemplate.Height = 21
        Me.grpPOS更新プログラム配信.Size = New System.Drawing.Size(2132, 1192)
        Me.grpPOS更新プログラム配信.TabIndex = 17
        '
        'cmbposパターン
        '
        Me.cmbposパターン.FormattingEnabled = True
        Me.cmbposパターン.Location = New System.Drawing.Point(314, 154)
        Me.cmbposパターン.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.cmbposパターン.Name = "cmbposパターン"
        Me.cmbposパターン.Size = New System.Drawing.Size(775, 32)
        Me.cmbposパターン.TabIndex = 18
        '
        'btn読込
        '
        Me.btn読込.Location = New System.Drawing.Point(1168, 136)
        Me.btn読込.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.btn読込.Name = "btn読込"
        Me.btn読込.Size = New System.Drawing.Size(147, 72)
        Me.btn読込.TabIndex = 19
        Me.btn読込.Text = "読込"
        Me.btn読込.UseVisualStyleBackColor = True
        '
        'frm117POS背面画像ファイル配信
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(2184, 1458)
        Me.Controls.Add(Me.btn読込)
        Me.Controls.Add(Me.cmbposパターン)
        Me.Controls.Add(Me.grpPOS更新プログラム配信)
        Me.Controls.Add(Me.lblposパターン)
        Me.Controls.Add(Me.btn終了)
        Me.Controls.Add(Me.btn配信)
        Me.Controls.Add(Me.btn一覧表示)
        Me.Controls.Add(Me.txt参照box1)
        Me.Controls.Add(Me.btn参照１)
        Me.Controls.Add(Me.lbl配信元フォルダ)
        Me.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.Name = "frm117POS背面画像ファイル配信"
        Me.Text = "frmPOS背画像配信"
        CType(Me.grpPOS更新プログラム配信, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl配信元フォルダ As Label
    Friend WithEvents btn参照１ As Button
    Friend WithEvents txt参照box1 As TextBox
    Friend WithEvents btn終了 As Button
    Friend WithEvents btn配信 As Button
    Friend WithEvents btn一覧表示 As Button
    Friend WithEvents lblposパターン As Label
    Friend WithEvents grpPOS更新プログラム配信 As DataGridView
    Friend WithEvents cmbposパターン As ComboBox
    Friend WithEvents btn読込 As Button
End Class
