<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm109POS電子ジャーナル収集
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
        Me.txtPCツール側ジャーナル下 = New System.Windows.Forms.TextBox()
        Me.txt端末側ジャーナル下 = New System.Windows.Forms.TextBox()
        Me.grp1 = New System.Windows.Forms.GroupBox()
        Me.lbl端末 = New System.Windows.Forms.Label()
        Me.cmb1 = New System.Windows.Forms.ComboBox()
        Me.lblから = New System.Windows.Forms.Label()
        Me.lbl精算日付 = New System.Windows.Forms.Label()
        Me.btn実行 = New System.Windows.Forms.Button()
        Me.btn終了 = New System.Windows.Forms.Button()
        Me.btnキャンセル = New System.Windows.Forms.Button()
        Me.lst2 = New System.Windows.Forms.ListBox()
        Me.lbl矢印 = New System.Windows.Forms.Label()
        Me.btn端末側ジャーナル = New System.Windows.Forms.Button()
        Me.btnPCツール側ジャーナル = New System.Windows.Forms.Button()
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.dtp清算日付始点 = New System.Windows.Forms.DateTimePicker()
        Me.dtp清算日付終点 = New System.Windows.Forms.DateTimePicker()
        Me.grp1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtPCツール側ジャーナル下
        '
        Me.txtPCツール側ジャーナル下.Location = New System.Drawing.Point(540, 82)
        Me.txtPCツール側ジャーナル下.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPCツール側ジャーナル下.Name = "txtPCツール側ジャーナル下"
        Me.txtPCツール側ジャーナル下.Size = New System.Drawing.Size(465, 19)
        Me.txtPCツール側ジャーナル下.TabIndex = 27
        Me.txtPCツール側ジャーナル下.Tag = ""
        Me.txtPCツール側ジャーナル下.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt端末側ジャーナル下
        '
        Me.txt端末側ジャーナル下.Location = New System.Drawing.Point(4, 80)
        Me.txt端末側ジャーナル下.Margin = New System.Windows.Forms.Padding(2)
        Me.txt端末側ジャーナル下.Name = "txt端末側ジャーナル下"
        Me.txt端末側ジャーナル下.Size = New System.Drawing.Size(466, 19)
        Me.txt端末側ジャーナル下.TabIndex = 26
        Me.txt端末側ジャーナル下.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'grp1
        '
        Me.grp1.Controls.Add(Me.dtp清算日付終点)
        Me.grp1.Controls.Add(Me.dtp清算日付始点)
        Me.grp1.Controls.Add(Me.lbl端末)
        Me.grp1.Controls.Add(Me.cmb1)
        Me.grp1.Controls.Add(Me.lblから)
        Me.grp1.Controls.Add(Me.lbl精算日付)
        Me.grp1.Controls.Add(Me.btn実行)
        Me.grp1.Controls.Add(Me.btn終了)
        Me.grp1.Controls.Add(Me.btnキャンセル)
        Me.grp1.Location = New System.Drawing.Point(4, 10)
        Me.grp1.Name = "grp1"
        Me.grp1.Size = New System.Drawing.Size(1001, 40)
        Me.grp1.TabIndex = 25
        Me.grp1.TabStop = False
        '
        'lbl端末
        '
        Me.lbl端末.AutoSize = True
        Me.lbl端末.Location = New System.Drawing.Point(359, 16)
        Me.lbl端末.Name = "lbl端末"
        Me.lbl端末.Size = New System.Drawing.Size(29, 12)
        Me.lbl端末.TabIndex = 34
        Me.lbl端末.Text = "端末"
        '
        'cmb1
        '
        Me.cmb1.FormattingEnabled = True
        Me.cmb1.Location = New System.Drawing.Point(394, 12)
        Me.cmb1.Name = "cmb1"
        Me.cmb1.Size = New System.Drawing.Size(276, 20)
        Me.cmb1.TabIndex = 19
        '
        'lblから
        '
        Me.lblから.AutoSize = True
        Me.lblから.Location = New System.Drawing.Point(199, 17)
        Me.lblから.Name = "lblから"
        Me.lblから.Size = New System.Drawing.Size(17, 12)
        Me.lblから.TabIndex = 33
        Me.lblから.Text = "～"
        '
        'lbl精算日付
        '
        Me.lbl精算日付.AutoSize = True
        Me.lbl精算日付.Location = New System.Drawing.Point(6, 15)
        Me.lbl精算日付.Name = "lbl精算日付"
        Me.lbl精算日付.Size = New System.Drawing.Size(53, 12)
        Me.lbl精算日付.TabIndex = 32
        Me.lbl精算日付.Text = "精算日付"
        '
        'btn実行
        '
        Me.btn実行.Location = New System.Drawing.Point(696, 11)
        Me.btn実行.Margin = New System.Windows.Forms.Padding(2)
        Me.btn実行.Name = "btn実行"
        Me.btn実行.Size = New System.Drawing.Size(91, 22)
        Me.btn実行.TabIndex = 14
        Me.btn実行.Text = "実行(U)"
        Me.btn実行.UseVisualStyleBackColor = True
        '
        'btn終了
        '
        Me.btn終了.Location = New System.Drawing.Point(904, 11)
        Me.btn終了.Margin = New System.Windows.Forms.Padding(2)
        Me.btn終了.Name = "btn終了"
        Me.btn終了.Size = New System.Drawing.Size(91, 22)
        Me.btn終了.TabIndex = 16
        Me.btn終了.Tag = ""
        Me.btn終了.Text = "終了(E)"
        Me.btn終了.UseVisualStyleBackColor = True
        '
        'btnキャンセル
        '
        Me.btnキャンセル.Location = New System.Drawing.Point(800, 11)
        Me.btnキャンセル.Margin = New System.Windows.Forms.Padding(2)
        Me.btnキャンセル.Name = "btnキャンセル"
        Me.btnキャンセル.Size = New System.Drawing.Size(91, 22)
        Me.btnキャンセル.TabIndex = 15
        Me.btnキャンセル.Text = "キャンセル(C)"
        Me.btnキャンセル.UseVisualStyleBackColor = True
        '
        'lst2
        '
        Me.lst2.FormattingEnabled = True
        Me.lst2.ItemHeight = 12
        Me.lst2.Location = New System.Drawing.Point(540, 102)
        Me.lst2.Margin = New System.Windows.Forms.Padding(2)
        Me.lst2.Name = "lst2"
        Me.lst2.Size = New System.Drawing.Size(466, 628)
        Me.lst2.TabIndex = 24
        '
        'lbl矢印
        '
        Me.lbl矢印.AutoSize = True
        Me.lbl矢印.Location = New System.Drawing.Point(489, 343)
        Me.lbl矢印.Name = "lbl矢印"
        Me.lbl矢印.Size = New System.Drawing.Size(31, 12)
        Me.lbl矢印.TabIndex = 29
        Me.lbl矢印.Text = "> > >"
        '
        'btn端末側ジャーナル
        '
        Me.btn端末側ジャーナル.Location = New System.Drawing.Point(4, 52)
        Me.btn端末側ジャーナル.Name = "btn端末側ジャーナル"
        Me.btn端末側ジャーナル.Size = New System.Drawing.Size(466, 26)
        Me.btn端末側ジャーナル.TabIndex = 30
        Me.btn端末側ジャーナル.Text = "端末側ジャーナル一覧"
        Me.btn端末側ジャーナル.UseVisualStyleBackColor = True
        '
        'btnPCツール側ジャーナル
        '
        Me.btnPCツール側ジャーナル.Location = New System.Drawing.Point(540, 50)
        Me.btnPCツール側ジャーナル.Name = "btnPCツール側ジャーナル"
        Me.btnPCツール側ジャーナル.Size = New System.Drawing.Size(466, 31)
        Me.btnPCツール側ジャーナル.TabIndex = 31
        Me.btnPCツール側ジャーナル.Text = "PCツール側ジャーナル一覧"
        Me.btnPCツール側ジャーナル.UseVisualStyleBackColor = True
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.Location = New System.Drawing.Point(4, 101)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(466, 634)
        Me.CheckedListBox1.TabIndex = 33
        '
        'dtp清算日付始点
        '
        Me.dtp清算日付始点.Location = New System.Drawing.Point(65, 12)
        Me.dtp清算日付始点.Name = "dtp清算日付始点"
        Me.dtp清算日付始点.Size = New System.Drawing.Size(128, 19)
        Me.dtp清算日付始点.TabIndex = 35
        Me.dtp清算日付始点.Value = New Date(2020, 5, 15, 19, 33, 38, 0)
        '
        'dtp清算日付終点
        '
        Me.dtp清算日付終点.Location = New System.Drawing.Point(222, 12)
        Me.dtp清算日付終点.Name = "dtp清算日付終点"
        Me.dtp清算日付終点.Size = New System.Drawing.Size(128, 19)
        Me.dtp清算日付終点.TabIndex = 36
        Me.dtp清算日付終点.Value = New Date(2020, 5, 15, 19, 33, 38, 0)
        '
        'frm109POS電子ジャーナル収集
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.CheckedListBox1)
        Me.Controls.Add(Me.btnPCツール側ジャーナル)
        Me.Controls.Add(Me.btn端末側ジャーナル)
        Me.Controls.Add(Me.lbl矢印)
        Me.Controls.Add(Me.txtPCツール側ジャーナル下)
        Me.Controls.Add(Me.txt端末側ジャーナル下)
        Me.Controls.Add(Me.grp1)
        Me.Controls.Add(Me.lst2)
        Me.Name = "frm109POS電子ジャーナル収集"
        Me.Text = "POS電子ジャーナル収集"
        Me.grp1.ResumeLayout(False)
        Me.grp1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtPCツール側ジャーナル下 As TextBox
    Friend WithEvents txt端末側ジャーナル下 As TextBox
    Friend WithEvents grp1 As GroupBox
    Friend WithEvents cmb1 As ComboBox
    Friend WithEvents btn実行 As Button
    Friend WithEvents btn終了 As Button
    Friend WithEvents btnキャンセル As Button
    Friend WithEvents lst2 As ListBox
    Friend WithEvents lbl矢印 As Label
    Friend WithEvents btn端末側ジャーナル As Button
    Friend WithEvents btnPCツール側ジャーナル As Button
    Friend WithEvents lbl精算日付 As Label
    Friend WithEvents lblから As Label
    Friend WithEvents lbl端末 As Label
    Friend WithEvents CheckedListBox1 As CheckedListBox
    Friend WithEvents dtp清算日付始点 As DateTimePicker
    Friend WithEvents dtp清算日付終点 As DateTimePicker
End Class
