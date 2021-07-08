<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm102POSパターン登録第2画面
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
        Me.txtadoresu1 = New System.Windows.Forms.TextBox()
        Me.txtadoresu2 = New System.Windows.Forms.TextBox()
        Me.txtadoresu3 = New System.Windows.Forms.TextBox()
        Me.txtadoresu4 = New System.Windows.Forms.TextBox()
        Me.txtパターン名称2 = New System.Windows.Forms.TextBox()
        Me.btnオーダリング = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.btnキャンセル = New System.Windows.Forms.Button()
        Me.btn削除 = New System.Windows.Forms.Button()
        Me.btn更新 = New System.Windows.Forms.Button()
        Me.grb2 = New System.Windows.Forms.GroupBox()
        Me.lblIPアドレス = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btn終了 = New System.Windows.Forms.Button()
        Me.btnエクスポート = New System.Windows.Forms.Button()
        Me.btnインポート = New System.Windows.Forms.Button()
        Me.txtPOSボタン = New System.Windows.Forms.TextBox()
        Me.lblPOSパターン = New System.Windows.Forms.Label()
        Me.lblパターン名称 = New System.Windows.Forms.Label()
        Me.lblオーダリング接続有無 = New System.Windows.Forms.Label()
        Me.btn疎通確認 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.grb2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtadoresu1
        '
        Me.txtadoresu1.Location = New System.Drawing.Point(151, 35)
        Me.txtadoresu1.Name = "txtadoresu1"
        Me.txtadoresu1.Size = New System.Drawing.Size(80, 19)
        Me.txtadoresu1.TabIndex = 4
        '
        'txtadoresu2
        '
        Me.txtadoresu2.Location = New System.Drawing.Point(256, 35)
        Me.txtadoresu2.Name = "txtadoresu2"
        Me.txtadoresu2.Size = New System.Drawing.Size(80, 19)
        Me.txtadoresu2.TabIndex = 5
        '
        'txtadoresu3
        '
        Me.txtadoresu3.Location = New System.Drawing.Point(361, 35)
        Me.txtadoresu3.Name = "txtadoresu3"
        Me.txtadoresu3.Size = New System.Drawing.Size(80, 19)
        Me.txtadoresu3.TabIndex = 6
        '
        'txtadoresu4
        '
        Me.txtadoresu4.Location = New System.Drawing.Point(466, 35)
        Me.txtadoresu4.Name = "txtadoresu4"
        Me.txtadoresu4.Size = New System.Drawing.Size(80, 19)
        Me.txtadoresu4.TabIndex = 7
        '
        'txtパターン名称2
        '
        Me.txtパターン名称2.Location = New System.Drawing.Point(217, 97)
        Me.txtパターン名称2.Name = "txtパターン名称2"
        Me.txtパターン名称2.Size = New System.Drawing.Size(89, 19)
        Me.txtパターン名称2.TabIndex = 8
        '
        'btnオーダリング
        '
        Me.btnオーダリング.Location = New System.Drawing.Point(51, 279)
        Me.btnオーダリング.Name = "btnオーダリング"
        Me.btnオーダリング.Size = New System.Drawing.Size(76, 20)
        Me.btnオーダリング.TabIndex = 10
        Me.btnオーダリング.Text = "オーダリング"
        Me.btnオーダリング.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton4)
        Me.GroupBox1.Controls.Add(Me.RadioButton3)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Location = New System.Drawing.Point(217, 144)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(693, 125)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(18, 81)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(66, 16)
        Me.RadioButton4.TabIndex = 3
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "接続なし"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(18, 59)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(189, 16)
        Me.RadioButton3.TabIndex = 2
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "接続あり　物販キッチンプリンタ使用"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(18, 37)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(148, 16)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "接続あり　　レストラン前払"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(18, 15)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(177, 16)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "接続あり　　レストランオーダリング"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'btnキャンセル
        '
        Me.btnキャンセル.Location = New System.Drawing.Point(574, 21)
        Me.btnキャンセル.Name = "btnキャンセル"
        Me.btnキャンセル.Size = New System.Drawing.Size(88, 42)
        Me.btnキャンセル.TabIndex = 17
        Me.btnキャンセル.Text = "キャンセル"
        Me.btnキャンセル.UseVisualStyleBackColor = True
        '
        'btn削除
        '
        Me.btn削除.Location = New System.Drawing.Point(489, 21)
        Me.btn削除.Name = "btn削除"
        Me.btn削除.Size = New System.Drawing.Size(88, 42)
        Me.btn削除.TabIndex = 16
        Me.btn削除.Text = "削除"
        Me.btn削除.UseVisualStyleBackColor = True
        '
        'btn更新
        '
        Me.btn更新.Location = New System.Drawing.Point(409, 22)
        Me.btn更新.Name = "btn更新"
        Me.btn更新.Size = New System.Drawing.Size(88, 41)
        Me.btn更新.TabIndex = 15
        Me.btn更新.Text = "更新"
        Me.btn更新.UseVisualStyleBackColor = True
        '
        'grb2
        '
        Me.grb2.Controls.Add(Me.btn疎通確認)
        Me.grb2.Controls.Add(Me.lblIPアドレス)
        Me.grb2.Controls.Add(Me.Label7)
        Me.grb2.Controls.Add(Me.Label5)
        Me.grb2.Controls.Add(Me.Label6)
        Me.grb2.Controls.Add(Me.txtadoresu1)
        Me.grb2.Controls.Add(Me.txtadoresu2)
        Me.grb2.Controls.Add(Me.txtadoresu3)
        Me.grb2.Controls.Add(Me.txtadoresu4)
        Me.grb2.Location = New System.Drawing.Point(48, 280)
        Me.grb2.Name = "grb2"
        Me.grb2.Size = New System.Drawing.Size(862, 75)
        Me.grb2.TabIndex = 18
        Me.grb2.TabStop = False
        Me.grb2.Text = "GroupBox2"
        '
        'lblIPアドレス
        '
        Me.lblIPアドレス.AutoSize = True
        Me.lblIPアドレス.Location = New System.Drawing.Point(6, 42)
        Me.lblIPアドレス.Name = "lblIPアドレス"
        Me.lblIPアドレス.Size = New System.Drawing.Size(51, 12)
        Me.lblIPアドレス.TabIndex = 29
        Me.lblIPアドレス.Text = "IPアドレス"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(237, 42)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(13, 12)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "．"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(447, 42)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(13, 12)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "．"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(342, 42)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(13, 12)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "．"
        '
        'btn終了
        '
        Me.btn終了.Location = New System.Drawing.Point(908, 21)
        Me.btn終了.Name = "btn終了"
        Me.btn終了.Size = New System.Drawing.Size(88, 42)
        Me.btn終了.TabIndex = 24
        Me.btn終了.Text = "終了"
        Me.btn終了.UseVisualStyleBackColor = True
        '
        'btnエクスポート
        '
        Me.btnエクスポート.Location = New System.Drawing.Point(824, 21)
        Me.btnエクスポート.Name = "btnエクスポート"
        Me.btnエクスポート.Size = New System.Drawing.Size(88, 42)
        Me.btnエクスポート.TabIndex = 23
        Me.btnエクスポート.Text = "エクスポート"
        Me.btnエクスポート.UseVisualStyleBackColor = True
        '
        'btnインポート
        '
        Me.btnインポート.Location = New System.Drawing.Point(740, 21)
        Me.btnインポート.Name = "btnインポート"
        Me.btnインポート.Size = New System.Drawing.Size(88, 42)
        Me.btnインポート.TabIndex = 22
        Me.btnインポート.UseVisualStyleBackColor = True
        '
        'txtPOSボタン
        '
        Me.txtPOSボタン.Location = New System.Drawing.Point(217, 21)
        Me.txtPOSボタン.Name = "txtPOSボタン"
        Me.txtPOSボタン.Size = New System.Drawing.Size(89, 19)
        Me.txtPOSボタン.TabIndex = 25
        '
        'lblPOSパターン
        '
        Me.lblPOSパターン.AutoSize = True
        Me.lblPOSパターン.Location = New System.Drawing.Point(49, 28)
        Me.lblPOSパターン.Name = "lblPOSパターン"
        Me.lblPOSパターン.Size = New System.Drawing.Size(64, 12)
        Me.lblPOSパターン.TabIndex = 26
        Me.lblPOSパターン.Text = "POSパターン"
        '
        'lblパターン名称
        '
        Me.lblパターン名称.AutoSize = True
        Me.lblパターン名称.Location = New System.Drawing.Point(49, 100)
        Me.lblパターン名称.Name = "lblパターン名称"
        Me.lblパターン名称.Size = New System.Drawing.Size(66, 12)
        Me.lblパターン名称.TabIndex = 27
        Me.lblパターン名称.Text = "パターン名称"
        '
        'lblオーダリング接続有無
        '
        Me.lblオーダリング接続有無.AutoSize = True
        Me.lblオーダリング接続有無.Location = New System.Drawing.Point(46, 159)
        Me.lblオーダリング接続有無.Name = "lblオーダリング接続有無"
        Me.lblオーダリング接続有無.Size = New System.Drawing.Size(106, 12)
        Me.lblオーダリング接続有無.TabIndex = 28
        Me.lblオーダリング接続有無.Text = "オーダリング接続有無"
        '
        'btn疎通確認
        '
        Me.btn疎通確認.Location = New System.Drawing.Point(692, 35)
        Me.btn疎通確認.Name = "btn疎通確認"
        Me.btn疎通確認.Size = New System.Drawing.Size(80, 19)
        Me.btn疎通確認.TabIndex = 33
        Me.btn疎通確認.Text = "疎通確認"
        Me.btn疎通確認.UseVisualStyleBackColor = True
        '
        'frm102POSパターン登録第2画面
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.lblオーダリング接続有無)
        Me.Controls.Add(Me.lblパターン名称)
        Me.Controls.Add(Me.lblPOSパターン)
        Me.Controls.Add(Me.txtPOSボタン)
        Me.Controls.Add(Me.btn終了)
        Me.Controls.Add(Me.btnエクスポート)
        Me.Controls.Add(Me.btnインポート)
        Me.Controls.Add(Me.grb2)
        Me.Controls.Add(Me.btnキャンセル)
        Me.Controls.Add(Me.btn削除)
        Me.Controls.Add(Me.btn更新)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnオーダリング)
        Me.Controls.Add(Me.txtパターン名称2)
        Me.Name = "frm102POSパターン登録第2画面"
        Me.Text = "frm102POSパターン登録第2画面"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grb2.ResumeLayout(False)
        Me.grb2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtadoresu1 As TextBox
    Friend WithEvents txtadoresu2 As TextBox
    Friend WithEvents txtadoresu3 As TextBox
    Friend WithEvents txtadoresu4 As TextBox
    Friend WithEvents txtパターン名称2 As TextBox
    Friend WithEvents btnオーダリング As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents btnキャンセル As Button
    Friend WithEvents btn削除 As Button
    Friend WithEvents btn更新 As Button
    Friend WithEvents grb2 As GroupBox
    Friend WithEvents btn終了 As Button
    Friend WithEvents btnエクスポート As Button
    Friend WithEvents btnインポート As Button
    Friend WithEvents txtPOSボタン As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblIPアドレス As Label
    Friend WithEvents lblPOSパターン As Label
    Friend WithEvents lblパターン名称 As Label
    Friend WithEvents lblオーダリング接続有無 As Label
    Friend WithEvents btn疎通確認 As Button
End Class
