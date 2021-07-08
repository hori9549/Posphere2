<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm105商品登録_コピー画面
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
        Me.lblコピー = New System.Windows.Forms.Label()
        Me.cmb選択 = New System.Windows.Forms.ComboBox()
        Me.btn実行 = New System.Windows.Forms.Button()
        Me.btnキャンセル = New System.Windows.Forms.Button()
        Me.lblPOSパターン = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblコピー
        '
        Me.lblコピー.AutoSize = True
        Me.lblコピー.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblコピー.Location = New System.Drawing.Point(12, 18)
        Me.lblコピー.Name = "lblコピー"
        Me.lblコピー.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblコピー.Size = New System.Drawing.Size(202, 12)
        Me.lblコピー.TabIndex = 0
        Me.lblコピー.Text = "コピー元のPOSパターンを選択して下さい。"
        '
        'cmb選択
        '
        Me.cmb選択.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb選択.FormattingEnabled = True
        Me.cmb選択.Location = New System.Drawing.Point(91, 46)
        Me.cmb選択.Name = "cmb選択"
        Me.cmb選択.Size = New System.Drawing.Size(300, 20)
        Me.cmb選択.TabIndex = 1
        '
        'btn実行
        '
        Me.btn実行.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btn実行.Location = New System.Drawing.Point(226, 83)
        Me.btn実行.Name = "btn実行"
        Me.btn実行.Size = New System.Drawing.Size(75, 36)
        Me.btn実行.TabIndex = 2
        Me.btn実行.Text = "実行"
        Me.btn実行.UseVisualStyleBackColor = True
        '
        'btnキャンセル
        '
        Me.btnキャンセル.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnキャンセル.Location = New System.Drawing.Point(307, 83)
        Me.btnキャンセル.Name = "btnキャンセル"
        Me.btnキャンセル.Size = New System.Drawing.Size(75, 36)
        Me.btnキャンセル.TabIndex = 3
        Me.btnキャンセル.Text = "キャンセル"
        Me.btnキャンセル.UseVisualStyleBackColor = True
        '
        'lblPOSパターン
        '
        Me.lblPOSパターン.AutoSize = True
        Me.lblPOSパターン.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblPOSパターン.Location = New System.Drawing.Point(12, 49)
        Me.lblPOSパターン.Name = "lblPOSパターン"
        Me.lblPOSパターン.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblPOSパターン.Size = New System.Drawing.Size(64, 12)
        Me.lblPOSパターン.TabIndex = 4
        Me.lblPOSパターン.Text = "POSパターン"
        '
        'frm105商品登録_コピー画面
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(394, 137)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblPOSパターン)
        Me.Controls.Add(Me.btnキャンセル)
        Me.Controls.Add(Me.btn実行)
        Me.Controls.Add(Me.cmb選択)
        Me.Controls.Add(Me.lblコピー)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frm105商品登録_コピー画面"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblコピー As Label
    Friend WithEvents cmb選択 As ComboBox
    Friend WithEvents btn実行 As Button
    Friend WithEvents btnキャンセル As Button
    Friend WithEvents lblPOSパターン As Label
End Class
