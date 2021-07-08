<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm108電子ジャーナル照会
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
        Me.grp1 = New System.Windows.Forms.GroupBox()
        Me.dtp清算日付終点 = New System.Windows.Forms.DateTimePicker()
        Me.dtp清算日付始点 = New System.Windows.Forms.DateTimePicker()
        Me.lblから = New System.Windows.Forms.Label()
        Me.lbl精算日付 = New System.Windows.Forms.Label()
        Me.btn参照 = New System.Windows.Forms.Button()
        Me.txt端末 = New System.Windows.Forms.TextBox()
        Me.lstジャーナルの表示 = New System.Windows.Forms.ListBox()
        Me.lstジャーナルファイル一覧 = New System.Windows.Forms.ListBox()
        Me.grpジャーナル内検索 = New System.Windows.Forms.GroupBox()
        Me.lbl検索まで = New System.Windows.Forms.Label()
        Me.lb検索分終点 = New System.Windows.Forms.Label()
        Me.lb検索時終点 = New System.Windows.Forms.Label()
        Me.txt検索分終点 = New System.Windows.Forms.TextBox()
        Me.txt検索時終点 = New System.Windows.Forms.TextBox()
        Me.dtp検索日付 = New System.Windows.Forms.DateTimePicker()
        Me.chk検索日付 = New System.Windows.Forms.CheckBox()
        Me.lbl検索文字列 = New System.Windows.Forms.Label()
        Me.lbl検索から = New System.Windows.Forms.Label()
        Me.lb検索分始点 = New System.Windows.Forms.Label()
        Me.lb検索時始点 = New System.Windows.Forms.Label()
        Me.lbl時間 = New System.Windows.Forms.Label()
        Me.lbl検索日付 = New System.Windows.Forms.Label()
        Me.btn検索 = New System.Windows.Forms.Button()
        Me.txt検索分始点 = New System.Windows.Forms.TextBox()
        Me.txt検索文字列 = New System.Windows.Forms.TextBox()
        Me.txt検索時始点 = New System.Windows.Forms.TextBox()
        Me.btnジャーナルファイル一覧 = New System.Windows.Forms.Button()
        Me.btn一覧で選択されたジャーナル = New System.Windows.Forms.Button()
        Me.btn抽出 = New System.Windows.Forms.Button()
        Me.btn印刷 = New System.Windows.Forms.Button()
        Me.btn終了 = New System.Windows.Forms.Button()
        Me.chk印刷 = New System.Windows.Forms.CheckBox()
        Me.grp1.SuspendLayout()
        Me.grpジャーナル内検索.SuspendLayout()
        Me.SuspendLayout()
        '
        'grp1
        '
        Me.grp1.Controls.Add(Me.dtp清算日付終点)
        Me.grp1.Controls.Add(Me.dtp清算日付始点)
        Me.grp1.Controls.Add(Me.lblから)
        Me.grp1.Controls.Add(Me.lbl精算日付)
        Me.grp1.Controls.Add(Me.btn参照)
        Me.grp1.Controls.Add(Me.txt端末)
        Me.grp1.Location = New System.Drawing.Point(3, 12)
        Me.grp1.Name = "grp1"
        Me.grp1.Size = New System.Drawing.Size(694, 70)
        Me.grp1.TabIndex = 19
        Me.grp1.TabStop = False
        '
        'dtp清算日付終点
        '
        Me.dtp清算日付終点.Location = New System.Drawing.Point(215, 11)
        Me.dtp清算日付終点.Name = "dtp清算日付終点"
        Me.dtp清算日付終点.Size = New System.Drawing.Size(121, 19)
        Me.dtp清算日付終点.TabIndex = 32
        Me.dtp清算日付終点.Value = New Date(2020, 5, 15, 19, 33, 38, 0)
        '
        'dtp清算日付始点
        '
        Me.dtp清算日付始点.Location = New System.Drawing.Point(65, 11)
        Me.dtp清算日付始点.Name = "dtp清算日付始点"
        Me.dtp清算日付始点.Size = New System.Drawing.Size(121, 19)
        Me.dtp清算日付始点.TabIndex = 31
        Me.dtp清算日付始点.Value = New Date(2020, 5, 15, 19, 33, 38, 0)
        '
        'lblから
        '
        Me.lblから.AutoSize = True
        Me.lblから.Location = New System.Drawing.Point(192, 16)
        Me.lblから.Name = "lblから"
        Me.lblから.Size = New System.Drawing.Size(17, 12)
        Me.lblから.TabIndex = 19
        Me.lblから.Text = "～"
        '
        'lbl精算日付
        '
        Me.lbl精算日付.AutoSize = True
        Me.lbl精算日付.Location = New System.Drawing.Point(6, 13)
        Me.lbl精算日付.Name = "lbl精算日付"
        Me.lbl精算日付.Size = New System.Drawing.Size(53, 12)
        Me.lbl精算日付.TabIndex = 18
        Me.lbl精算日付.Text = "精算日付"
        '
        'btn参照
        '
        Me.btn参照.Location = New System.Drawing.Point(4, 31)
        Me.btn参照.Margin = New System.Windows.Forms.Padding(2)
        Me.btn参照.Name = "btn参照"
        Me.btn参照.Size = New System.Drawing.Size(77, 23)
        Me.btn参照.TabIndex = 17
        Me.btn参照.Text = "参照"
        Me.btn参照.UseVisualStyleBackColor = True
        '
        'txt端末
        '
        Me.txt端末.Location = New System.Drawing.Point(84, 35)
        Me.txt端末.Margin = New System.Windows.Forms.Padding(2)
        Me.txt端末.Name = "txt端末"
        Me.txt端末.Size = New System.Drawing.Size(546, 19)
        Me.txt端末.TabIndex = 15
        Me.txt端末.Text = "d:\SpreadN_DJNL"
        '
        'lstジャーナルの表示
        '
        Me.lstジャーナルの表示.FormattingEnabled = True
        Me.lstジャーナルの表示.ItemHeight = 12
        Me.lstジャーナルの表示.Location = New System.Drawing.Point(393, 128)
        Me.lstジャーナルの表示.Margin = New System.Windows.Forms.Padding(2)
        Me.lstジャーナルの表示.Name = "lstジャーナルの表示"
        Me.lstジャーナルの表示.Size = New System.Drawing.Size(387, 592)
        Me.lstジャーナルの表示.TabIndex = 18
        '
        'lstジャーナルファイル一覧
        '
        Me.lstジャーナルファイル一覧.FormattingEnabled = True
        Me.lstジャーナルファイル一覧.ItemHeight = 12
        Me.lstジャーナルファイル一覧.Location = New System.Drawing.Point(3, 128)
        Me.lstジャーナルファイル一覧.Margin = New System.Windows.Forms.Padding(2)
        Me.lstジャーナルファイル一覧.Name = "lstジャーナルファイル一覧"
        Me.lstジャーナルファイル一覧.Size = New System.Drawing.Size(387, 592)
        Me.lstジャーナルファイル一覧.TabIndex = 17
        '
        'grpジャーナル内検索
        '
        Me.grpジャーナル内検索.Controls.Add(Me.lbl検索まで)
        Me.grpジャーナル内検索.Controls.Add(Me.lb検索分終点)
        Me.grpジャーナル内検索.Controls.Add(Me.lb検索時終点)
        Me.grpジャーナル内検索.Controls.Add(Me.txt検索分終点)
        Me.grpジャーナル内検索.Controls.Add(Me.txt検索時終点)
        Me.grpジャーナル内検索.Controls.Add(Me.dtp検索日付)
        Me.grpジャーナル内検索.Controls.Add(Me.chk検索日付)
        Me.grpジャーナル内検索.Controls.Add(Me.lbl検索文字列)
        Me.grpジャーナル内検索.Controls.Add(Me.lbl検索から)
        Me.grpジャーナル内検索.Controls.Add(Me.lb検索分始点)
        Me.grpジャーナル内検索.Controls.Add(Me.lb検索時始点)
        Me.grpジャーナル内検索.Controls.Add(Me.lbl時間)
        Me.grpジャーナル内検索.Controls.Add(Me.lbl検索日付)
        Me.grpジャーナル内検索.Controls.Add(Me.btn検索)
        Me.grpジャーナル内検索.Controls.Add(Me.txt検索分始点)
        Me.grpジャーナル内検索.Controls.Add(Me.txt検索文字列)
        Me.grpジャーナル内検索.Controls.Add(Me.txt検索時始点)
        Me.grpジャーナル内検索.Location = New System.Drawing.Point(786, 88)
        Me.grpジャーナル内検索.Name = "grpジャーナル内検索"
        Me.grpジャーナル内検索.Size = New System.Drawing.Size(219, 632)
        Me.grpジャーナル内検索.TabIndex = 22
        Me.grpジャーナル内検索.TabStop = False
        Me.grpジャーナル内検索.Text = "ジャーナル内検索"
        '
        'lbl検索まで
        '
        Me.lbl検索まで.AutoSize = True
        Me.lbl検索まで.Location = New System.Drawing.Point(168, 78)
        Me.lbl検索まで.Name = "lbl検索まで"
        Me.lbl検索まで.Size = New System.Drawing.Size(24, 12)
        Me.lbl検索まで.TabIndex = 39
        Me.lbl検索まで.Text = "まで"
        '
        'lb検索分終点
        '
        Me.lb検索分終点.AutoSize = True
        Me.lb検索分終点.Location = New System.Drawing.Point(141, 78)
        Me.lb検索分終点.Name = "lb検索分終点"
        Me.lb検索分終点.Size = New System.Drawing.Size(17, 12)
        Me.lb検索分終点.TabIndex = 38
        Me.lb検索分終点.Text = "分"
        '
        'lb検索時終点
        '
        Me.lb検索時終点.AutoSize = True
        Me.lb検索時終点.Location = New System.Drawing.Point(95, 78)
        Me.lb検索時終点.Name = "lb検索時終点"
        Me.lb検索時終点.Size = New System.Drawing.Size(17, 12)
        Me.lb検索時終点.TabIndex = 37
        Me.lb検索時終点.Text = "時"
        '
        'txt検索分終点
        '
        Me.txt検索分終点.Location = New System.Drawing.Point(117, 75)
        Me.txt検索分終点.Margin = New System.Windows.Forms.Padding(2)
        Me.txt検索分終点.Name = "txt検索分終点"
        Me.txt検索分終点.Size = New System.Drawing.Size(19, 19)
        Me.txt検索分終点.TabIndex = 35
        '
        'txt検索時終点
        '
        Me.txt検索時終点.Location = New System.Drawing.Point(73, 75)
        Me.txt検索時終点.Margin = New System.Windows.Forms.Padding(2)
        Me.txt検索時終点.Name = "txt検索時終点"
        Me.txt検索時終点.Size = New System.Drawing.Size(19, 19)
        Me.txt検索時終点.TabIndex = 34
        '
        'dtp検索日付
        '
        Me.dtp検索日付.Location = New System.Drawing.Point(89, 20)
        Me.dtp検索日付.Name = "dtp検索日付"
        Me.dtp検索日付.Size = New System.Drawing.Size(121, 19)
        Me.dtp検索日付.TabIndex = 33
        Me.dtp検索日付.Value = New Date(2020, 5, 15, 19, 33, 38, 0)
        '
        'chk検索日付
        '
        Me.chk検索日付.AutoSize = True
        Me.chk検索日付.Location = New System.Drawing.Point(52, 24)
        Me.chk検索日付.Name = "chk検索日付"
        Me.chk検索日付.Size = New System.Drawing.Size(15, 14)
        Me.chk検索日付.TabIndex = 30
        Me.chk検索日付.UseVisualStyleBackColor = True
        '
        'lbl検索文字列
        '
        Me.lbl検索文字列.AutoSize = True
        Me.lbl検索文字列.Location = New System.Drawing.Point(11, 103)
        Me.lbl検索文字列.Name = "lbl検索文字列"
        Me.lbl検索文字列.Size = New System.Drawing.Size(65, 12)
        Me.lbl検索文字列.TabIndex = 29
        Me.lbl検索文字列.Text = "検索文字列"
        '
        'lbl検索から
        '
        Me.lbl検索から.AutoSize = True
        Me.lbl検索から.Location = New System.Drawing.Point(168, 55)
        Me.lbl検索から.Name = "lbl検索から"
        Me.lbl検索から.Size = New System.Drawing.Size(23, 12)
        Me.lbl検索から.TabIndex = 28
        Me.lbl検索から.Text = "から"
        '
        'lb検索分始点
        '
        Me.lb検索分始点.AutoSize = True
        Me.lb検索分始点.Location = New System.Drawing.Point(141, 55)
        Me.lb検索分始点.Name = "lb検索分始点"
        Me.lb検索分始点.Size = New System.Drawing.Size(17, 12)
        Me.lb検索分始点.TabIndex = 27
        Me.lb検索分始点.Text = "分"
        '
        'lb検索時始点
        '
        Me.lb検索時始点.AutoSize = True
        Me.lb検索時始点.Location = New System.Drawing.Point(95, 55)
        Me.lb検索時始点.Name = "lb検索時始点"
        Me.lb検索時始点.Size = New System.Drawing.Size(17, 12)
        Me.lb検索時始点.TabIndex = 26
        Me.lb検索時始点.Text = "時"
        '
        'lbl時間
        '
        Me.lbl時間.AutoSize = True
        Me.lbl時間.Location = New System.Drawing.Point(11, 55)
        Me.lbl時間.Name = "lbl時間"
        Me.lbl時間.Size = New System.Drawing.Size(29, 12)
        Me.lbl時間.TabIndex = 25
        Me.lbl時間.Text = "時間"
        '
        'lbl検索日付
        '
        Me.lbl検索日付.AutoSize = True
        Me.lbl検索日付.Location = New System.Drawing.Point(11, 24)
        Me.lbl検索日付.Name = "lbl検索日付"
        Me.lbl検索日付.Size = New System.Drawing.Size(29, 12)
        Me.lbl検索日付.TabIndex = 24
        Me.lbl検索日付.Text = "日付"
        '
        'btn検索
        '
        Me.btn検索.Location = New System.Drawing.Point(142, 141)
        Me.btn検索.Name = "btn検索"
        Me.btn検索.Size = New System.Drawing.Size(68, 28)
        Me.btn検索.TabIndex = 23
        Me.btn検索.Text = "検索"
        Me.btn検索.UseVisualStyleBackColor = True
        '
        'txt検索分始点
        '
        Me.txt検索分始点.Location = New System.Drawing.Point(117, 52)
        Me.txt検索分始点.Margin = New System.Windows.Forms.Padding(2)
        Me.txt検索分始点.Name = "txt検索分始点"
        Me.txt検索分始点.Size = New System.Drawing.Size(19, 19)
        Me.txt検索分始点.TabIndex = 20
        '
        'txt検索文字列
        '
        Me.txt検索文字列.Location = New System.Drawing.Point(13, 117)
        Me.txt検索文字列.Margin = New System.Windows.Forms.Padding(2)
        Me.txt検索文字列.Name = "txt検索文字列"
        Me.txt検索文字列.Size = New System.Drawing.Size(197, 19)
        Me.txt検索文字列.TabIndex = 18
        '
        'txt検索時始点
        '
        Me.txt検索時始点.Location = New System.Drawing.Point(73, 52)
        Me.txt検索時始点.Margin = New System.Windows.Forms.Padding(2)
        Me.txt検索時始点.Name = "txt検索時始点"
        Me.txt検索時始点.Size = New System.Drawing.Size(19, 19)
        Me.txt検索時始点.TabIndex = 1
        '
        'btnジャーナルファイル一覧
        '
        Me.btnジャーナルファイル一覧.Location = New System.Drawing.Point(3, 88)
        Me.btnジャーナルファイル一覧.Name = "btnジャーナルファイル一覧"
        Me.btnジャーナルファイル一覧.Size = New System.Drawing.Size(387, 35)
        Me.btnジャーナルファイル一覧.TabIndex = 23
        Me.btnジャーナルファイル一覧.Text = "ジャーナルファイル一覧"
        Me.btnジャーナルファイル一覧.UseVisualStyleBackColor = True
        '
        'btn一覧で選択されたジャーナル
        '
        Me.btn一覧で選択されたジャーナル.Location = New System.Drawing.Point(393, 88)
        Me.btn一覧で選択されたジャーナル.Name = "btn一覧で選択されたジャーナル"
        Me.btn一覧で選択されたジャーナル.Size = New System.Drawing.Size(387, 35)
        Me.btn一覧で選択されたジャーナル.TabIndex = 24
        Me.btn一覧で選択されたジャーナル.Text = "一覧で選択されたジャーナルの表示"
        Me.btn一覧で選択されたジャーナル.UseVisualStyleBackColor = True
        '
        'btn抽出
        '
        Me.btn抽出.Location = New System.Drawing.Point(713, 20)
        Me.btn抽出.Margin = New System.Windows.Forms.Padding(2)
        Me.btn抽出.Name = "btn抽出"
        Me.btn抽出.Size = New System.Drawing.Size(51, 22)
        Me.btn抽出.TabIndex = 24
        Me.btn抽出.Text = "抽出"
        Me.btn抽出.UseVisualStyleBackColor = True
        '
        'btn印刷
        '
        Me.btn印刷.Location = New System.Drawing.Point(870, 20)
        Me.btn印刷.Margin = New System.Windows.Forms.Padding(2)
        Me.btn印刷.Name = "btn印刷"
        Me.btn印刷.Size = New System.Drawing.Size(56, 22)
        Me.btn印刷.TabIndex = 25
        Me.btn印刷.Text = "印刷"
        Me.btn印刷.UseVisualStyleBackColor = True
        '
        'btn終了
        '
        Me.btn終了.Location = New System.Drawing.Point(947, 20)
        Me.btn終了.Margin = New System.Windows.Forms.Padding(2)
        Me.btn終了.Name = "btn終了"
        Me.btn終了.Size = New System.Drawing.Size(51, 22)
        Me.btn終了.TabIndex = 26
        Me.btn終了.Tag = ""
        Me.btn終了.Text = "終了(C)"
        Me.btn終了.UseVisualStyleBackColor = True
        '
        'chk印刷
        '
        Me.chk印刷.AutoSize = True
        Me.chk印刷.Location = New System.Drawing.Point(838, 50)
        Me.chk印刷.Name = "chk印刷"
        Me.chk印刷.Size = New System.Drawing.Size(165, 16)
        Me.chk印刷.TabIndex = 27
        Me.chk印刷.Text = "印刷に検索条件を反映させる"
        Me.chk印刷.UseVisualStyleBackColor = True
        '
        'frm108電子ジャーナル照会
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.chk印刷)
        Me.Controls.Add(Me.btn抽出)
        Me.Controls.Add(Me.btn印刷)
        Me.Controls.Add(Me.btn終了)
        Me.Controls.Add(Me.btn一覧で選択されたジャーナル)
        Me.Controls.Add(Me.btnジャーナルファイル一覧)
        Me.Controls.Add(Me.grpジャーナル内検索)
        Me.Controls.Add(Me.grp1)
        Me.Controls.Add(Me.lstジャーナルの表示)
        Me.Controls.Add(Me.lstジャーナルファイル一覧)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frm108電子ジャーナル照会"
        Me.Text = "電子ジャーナル照会"
        Me.grp1.ResumeLayout(False)
        Me.grp1.PerformLayout()
        Me.grpジャーナル内検索.ResumeLayout(False)
        Me.grpジャーナル内検索.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grp1 As GroupBox
    Friend WithEvents txt端末 As TextBox
    Friend WithEvents lstジャーナルの表示 As ListBox
    Friend WithEvents lstジャーナルファイル一覧 As ListBox
    Friend WithEvents btn参照 As Button
    Friend WithEvents grpジャーナル内検索 As GroupBox
    Friend WithEvents txt検索時始点 As TextBox
    Friend WithEvents txt検索文字列 As TextBox
    Friend WithEvents txt検索分始点 As TextBox
    Friend WithEvents btn検索 As Button
    Friend WithEvents btnジャーナルファイル一覧 As Button
    Friend WithEvents btn一覧で選択されたジャーナル As Button
    Friend WithEvents btn抽出 As Button
    Friend WithEvents btn印刷 As Button
    Friend WithEvents btn終了 As Button
    Friend WithEvents lblから As Label
    Friend WithEvents lbl精算日付 As Label
    Friend WithEvents lbl検索から As Label
    Friend WithEvents lb検索分始点 As Label
    Friend WithEvents lb検索時始点 As Label
    Friend WithEvents lbl時間 As Label
    Friend WithEvents lbl検索日付 As Label
    Friend WithEvents lbl検索文字列 As Label
    Friend WithEvents chk検索日付 As CheckBox
    Friend WithEvents chk印刷 As CheckBox
    Friend WithEvents dtp清算日付終点 As DateTimePicker
    Friend WithEvents dtp清算日付始点 As DateTimePicker
    Friend WithEvents dtp検索日付 As DateTimePicker
    Friend WithEvents lbl検索まで As Label
    Friend WithEvents lb検索分終点 As Label
    Friend WithEvents lb検索時終点 As Label
    Friend WithEvents txt検索分終点 As TextBox
    Friend WithEvents txt検索時終点 As TextBox
End Class
