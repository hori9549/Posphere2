<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm104グループ登録_第2画面
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtNo2 = New System.Windows.Forms.TextBox()
        Me.lblグループ名No2 = New System.Windows.Forms.Label()
        Me.lblグループ番号No2 = New System.Windows.Forms.Label()
        Me.lblPOSパターンNo2 = New System.Windows.Forms.Label()
        Me.btnキャンセルNo2 = New System.Windows.Forms.Button()
        Me.btn削除No2 = New System.Windows.Forms.Button()
        Me.btn更新No2 = New System.Windows.Forms.Button()
        Me.cmb種別No2 = New System.Windows.Forms.ComboBox()
        Me.Grb選択メンバー一覧 = New System.Windows.Forms.GroupBox()
        Me.dgv選択品目表 = New System.Windows.Forms.DataGridView()
        Me.Btn選択ボタン = New System.Windows.Forms.Button()
        Me.Grb設定メニュー情報 = New System.Windows.Forms.GroupBox()
        Me.Btn取消 = New System.Windows.Forms.Button()
        Me.Dgv選択済品目 = New System.Windows.Forms.DataGridView()
        Me.NO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.商品CD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.品目名 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblPosPtn = New System.Windows.Forms.Label()
        Me.lblGrpNo = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.新規Flag = New System.Windows.Forms.Label()
        Me.Txt新規か = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.POSパターンID = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Txt単価 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Txt品目名 = New System.Windows.Forms.TextBox()
        Me.Txt商品CD = New System.Windows.Forms.TextBox()
        Me.DgvWork = New System.Windows.Forms.DataGridView()
        Me.DGVwork2 = New System.Windows.Forms.DataGridView()
        Me.Grb選択メンバー一覧.SuspendLayout()
        CType(Me.dgv選択品目表, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Grb設定メニュー情報.SuspendLayout()
        CType(Me.Dgv選択済品目, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DgvWork, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVwork2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label1.Location = New System.Drawing.Point(264, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 12)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "種　別"
        '
        'TxtNo2
        '
        Me.TxtNo2.Location = New System.Drawing.Point(146, 54)
        Me.TxtNo2.Name = "TxtNo2"
        Me.TxtNo2.Size = New System.Drawing.Size(100, 19)
        Me.TxtNo2.TabIndex = 2
        '
        'lblグループ名No2
        '
        Me.lblグループ名No2.AutoSize = True
        Me.lblグループ名No2.Location = New System.Drawing.Point(36, 57)
        Me.lblグループ名No2.Name = "lblグループ名No2"
        Me.lblグループ名No2.Size = New System.Drawing.Size(55, 12)
        Me.lblグループ名No2.TabIndex = 3
        Me.lblグループ名No2.Text = "グループ名"
        '
        'lblグループ番号No2
        '
        Me.lblグループ番号No2.AutoSize = True
        Me.lblグループ番号No2.Location = New System.Drawing.Point(214, 27)
        Me.lblグループ番号No2.Name = "lblグループ番号No2"
        Me.lblグループ番号No2.Size = New System.Drawing.Size(77, 12)
        Me.lblグループ番号No2.TabIndex = 45
        Me.lblグループ番号No2.Text = "グループ番号 : "
        '
        'lblPOSパターンNo2
        '
        Me.lblPOSパターンNo2.AutoSize = True
        Me.lblPOSパターンNo2.Location = New System.Drawing.Point(30, 27)
        Me.lblPOSパターンNo2.Name = "lblPOSパターンNo2"
        Me.lblPOSパターンNo2.Size = New System.Drawing.Size(74, 12)
        Me.lblPOSパターンNo2.TabIndex = 44
        Me.lblPOSパターンNo2.Text = "POSパターン : "
        '
        'btnキャンセルNo2
        '
        Me.btnキャンセルNo2.Location = New System.Drawing.Point(907, 12)
        Me.btnキャンセルNo2.Name = "btnキャンセルNo2"
        Me.btnキャンセルNo2.Size = New System.Drawing.Size(88, 42)
        Me.btnキャンセルNo2.TabIndex = 40
        Me.btnキャンセルNo2.Text = "キャンセル"
        Me.btnキャンセルNo2.UseVisualStyleBackColor = True
        '
        'btn削除No2
        '
        Me.btn削除No2.Location = New System.Drawing.Point(823, 12)
        Me.btn削除No2.Name = "btn削除No2"
        Me.btn削除No2.Size = New System.Drawing.Size(88, 42)
        Me.btn削除No2.TabIndex = 39
        Me.btn削除No2.Text = "削除"
        Me.btn削除No2.UseVisualStyleBackColor = True
        '
        'btn更新No2
        '
        Me.btn更新No2.Location = New System.Drawing.Point(739, 12)
        Me.btn更新No2.Name = "btn更新No2"
        Me.btn更新No2.Size = New System.Drawing.Size(88, 42)
        Me.btn更新No2.TabIndex = 38
        Me.btn更新No2.Text = "更新"
        Me.btn更新No2.UseVisualStyleBackColor = True
        '
        'cmb種別No2
        '
        Me.cmb種別No2.FormattingEnabled = True
        Me.cmb種別No2.Items.AddRange(New Object() {"セレクト", "飲食放題"})
        Me.cmb種別No2.Location = New System.Drawing.Point(310, 54)
        Me.cmb種別No2.Name = "cmb種別No2"
        Me.cmb種別No2.Size = New System.Drawing.Size(179, 20)
        Me.cmb種別No2.TabIndex = 48
        '
        'Grb選択メンバー一覧
        '
        Me.Grb選択メンバー一覧.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Grb選択メンバー一覧.Controls.Add(Me.dgv選択品目表)
        Me.Grb選択メンバー一覧.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Grb選択メンバー一覧.Location = New System.Drawing.Point(21, 93)
        Me.Grb選択メンバー一覧.Name = "Grb選択メンバー一覧"
        Me.Grb選択メンバー一覧.Size = New System.Drawing.Size(373, 542)
        Me.Grb選択メンバー一覧.TabIndex = 49
        Me.Grb選択メンバー一覧.TabStop = False
        Me.Grb選択メンバー一覧.Text = "選択メンバー一覧"
        '
        'dgv選択品目表
        '
        Me.dgv選択品目表.AllowUserToAddRows = False
        Me.dgv選択品目表.AllowUserToDeleteRows = False
        Me.dgv選択品目表.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv選択品目表.Location = New System.Drawing.Point(20, 15)
        Me.dgv選択品目表.MultiSelect = False
        Me.dgv選択品目表.Name = "dgv選択品目表"
        Me.dgv選択品目表.ReadOnly = True
        Me.dgv選択品目表.RowTemplate.Height = 21
        Me.dgv選択品目表.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv選択品目表.Size = New System.Drawing.Size(344, 510)
        Me.dgv選択品目表.TabIndex = 50
        '
        'Btn選択ボタン
        '
        Me.Btn選択ボタン.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn選択ボタン.Font = New System.Drawing.Font("MS UI Gothic", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Btn選択ボタン.Location = New System.Drawing.Point(424, 204)
        Me.Btn選択ボタン.Name = "Btn選択ボタン"
        Me.Btn選択ボタン.Size = New System.Drawing.Size(92, 81)
        Me.Btn選択ボタン.TabIndex = 50
        Me.Btn選択ボタン.Text = "＞"
        Me.Btn選択ボタン.UseVisualStyleBackColor = False
        '
        'Grb設定メニュー情報
        '
        Me.Grb設定メニュー情報.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Grb設定メニュー情報.Controls.Add(Me.Btn取消)
        Me.Grb設定メニュー情報.Controls.Add(Me.Dgv選択済品目)
        Me.Grb設定メニュー情報.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Grb設定メニュー情報.Location = New System.Drawing.Point(549, 93)
        Me.Grb設定メニュー情報.Name = "Grb設定メニュー情報"
        Me.Grb設定メニュー情報.Size = New System.Drawing.Size(446, 580)
        Me.Grb設定メニュー情報.TabIndex = 51
        Me.Grb設定メニュー情報.TabStop = False
        Me.Grb設定メニュー情報.Text = "設定メニュー情報"
        '
        'Btn取消
        '
        Me.Btn取消.Location = New System.Drawing.Point(310, 15)
        Me.Btn取消.Name = "Btn取消"
        Me.Btn取消.Size = New System.Drawing.Size(68, 27)
        Me.Btn取消.TabIndex = 54
        Me.Btn取消.Text = "取消"
        Me.Btn取消.UseVisualStyleBackColor = True
        '
        'Dgv選択済品目
        '
        Me.Dgv選択済品目.AllowUserToDeleteRows = False
        Me.Dgv選択済品目.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv選択済品目.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NO, Me.商品CD, Me.品目名})
        Me.Dgv選択済品目.Location = New System.Drawing.Point(15, 48)
        Me.Dgv選択済品目.Name = "Dgv選択済品目"
        Me.Dgv選択済品目.ReadOnly = True
        Me.Dgv選択済品目.RowTemplate.Height = 21
        Me.Dgv選択済品目.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dgv選択済品目.Size = New System.Drawing.Size(425, 515)
        Me.Dgv選択済品目.TabIndex = 50
        '
        'NO
        '
        Me.NO.HeaderText = "NO."
        Me.NO.Name = "NO"
        Me.NO.ReadOnly = True
        '
        '商品CD
        '
        Me.商品CD.HeaderText = "番　号"
        Me.商品CD.Name = "商品CD"
        Me.商品CD.ReadOnly = True
        '
        '品目名
        '
        Me.品目名.HeaderText = "名　称"
        Me.品目名.Name = "品目名"
        Me.品目名.ReadOnly = True
        '
        'lblPosPtn
        '
        Me.lblPosPtn.AutoSize = True
        Me.lblPosPtn.Location = New System.Drawing.Point(100, 27)
        Me.lblPosPtn.Name = "lblPosPtn"
        Me.lblPosPtn.Size = New System.Drawing.Size(52, 12)
        Me.lblPosPtn.TabIndex = 52
        Me.lblPosPtn.Text = "れすとらん"
        '
        'lblGrpNo
        '
        Me.lblGrpNo.AutoSize = True
        Me.lblGrpNo.Location = New System.Drawing.Point(287, 27)
        Me.lblGrpNo.Name = "lblGrpNo"
        Me.lblGrpNo.Size = New System.Drawing.Size(67, 12)
        Me.lblGrpNo.TabIndex = 53
        Me.lblGrpNo.Text = "グループ番号"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.新規Flag)
        Me.GroupBox1.Controls.Add(Me.Txt新規か)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.POSパターンID)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Txt単価)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Txt品目名)
        Me.GroupBox1.Controls.Add(Me.Txt商品CD)
        Me.GroupBox1.Location = New System.Drawing.Point(409, 321)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(140, 297)
        Me.GroupBox1.TabIndex = 57
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "デバッグ後にunVisible"
        Me.GroupBox1.Visible = False
        '
        '新規Flag
        '
        Me.新規Flag.AutoSize = True
        Me.新規Flag.Location = New System.Drawing.Point(14, 257)
        Me.新規Flag.Name = "新規Flag"
        Me.新規Flag.Size = New System.Drawing.Size(38, 12)
        Me.新規Flag.TabIndex = 61
        Me.新規Flag.Text = "Label6"
        '
        'Txt新規か
        '
        Me.Txt新規か.Location = New System.Drawing.Point(41, 275)
        Me.Txt新規か.Name = "Txt新規か"
        Me.Txt新規か.Size = New System.Drawing.Size(67, 19)
        Me.Txt新規か.TabIndex = 60
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 203)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 12)
        Me.Label5.TabIndex = 59
        Me.Label5.Text = "PosパターンID"
        '
        'POSパターンID
        '
        Me.POSパターンID.Location = New System.Drawing.Point(34, 228)
        Me.POSパターンID.Name = "POSパターンID"
        Me.POSパターンID.Size = New System.Drawing.Size(100, 19)
        Me.POSパターンID.TabIndex = 58
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(4, 141)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 12)
        Me.Label4.TabIndex = 57
        Me.Label4.Text = """単価""の内容"
        '
        'Txt単価
        '
        Me.Txt単価.Location = New System.Drawing.Point(32, 166)
        Me.Txt単価.Name = "Txt単価"
        Me.Txt単価.Size = New System.Drawing.Size(100, 19)
        Me.Txt単価.TabIndex = 56
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(-2, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 12)
        Me.Label2.TabIndex = 55
        Me.Label2.Text = "品目名の内容"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(0, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 12)
        Me.Label3.TabIndex = 54
        Me.Label3.Text = "商品CDの内容"
        '
        'Txt品目名
        '
        Me.Txt品目名.Location = New System.Drawing.Point(29, 106)
        Me.Txt品目名.Name = "Txt品目名"
        Me.Txt品目名.Size = New System.Drawing.Size(100, 19)
        Me.Txt品目名.TabIndex = 53
        '
        'Txt商品CD
        '
        Me.Txt商品CD.Location = New System.Drawing.Point(32, 43)
        Me.Txt商品CD.Name = "Txt商品CD"
        Me.Txt商品CD.Size = New System.Drawing.Size(100, 19)
        Me.Txt商品CD.TabIndex = 52
        '
        'DgvWork
        '
        Me.DgvWork.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvWork.Location = New System.Drawing.Point(49, 679)
        Me.DgvWork.Name = "DgvWork"
        Me.DgvWork.RowTemplate.Height = 21
        Me.DgvWork.Size = New System.Drawing.Size(649, 38)
        Me.DgvWork.TabIndex = 58
        Me.DgvWork.Visible = False
        '
        'DGVwork2
        '
        Me.DGVwork2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVwork2.Location = New System.Drawing.Point(723, 679)
        Me.DGVwork2.Name = "DGVwork2"
        Me.DGVwork2.ReadOnly = True
        Me.DGVwork2.RowTemplate.Height = 21
        Me.DGVwork2.Size = New System.Drawing.Size(266, 38)
        Me.DGVwork2.TabIndex = 55
        Me.DGVwork2.Visible = False
        '
        'Frm104グループ登録_第2画面
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.DGVwork2)
        Me.Controls.Add(Me.DgvWork)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblGrpNo)
        Me.Controls.Add(Me.lblPosPtn)
        Me.Controls.Add(Me.Grb設定メニュー情報)
        Me.Controls.Add(Me.Btn選択ボタン)
        Me.Controls.Add(Me.Grb選択メンバー一覧)
        Me.Controls.Add(Me.cmb種別No2)
        Me.Controls.Add(Me.lblグループ番号No2)
        Me.Controls.Add(Me.lblPOSパターンNo2)
        Me.Controls.Add(Me.btnキャンセルNo2)
        Me.Controls.Add(Me.btn削除No2)
        Me.Controls.Add(Me.btn更新No2)
        Me.Controls.Add(Me.lblグループ名No2)
        Me.Controls.Add(Me.TxtNo2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Frm104グループ登録_第2画面"
        Me.Text = "グループ登録 設定"
        Me.Grb選択メンバー一覧.ResumeLayout(False)
        CType(Me.dgv選択品目表, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Grb設定メニュー情報.ResumeLayout(False)
        CType(Me.Dgv選択済品目, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DgvWork, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVwork2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtNo2 As TextBox
    Friend WithEvents lblグループ名No2 As Label
    Friend WithEvents lblグループ番号No2 As Label
    Friend WithEvents lblPOSパターンNo2 As Label
    Friend WithEvents btnキャンセルNo2 As Button
    Friend WithEvents btn削除No2 As Button
    Friend WithEvents btn更新No2 As Button
    Friend WithEvents cmb種別No2 As ComboBox
    Friend WithEvents Grb選択メンバー一覧 As GroupBox
    Friend WithEvents dgv選択品目表 As DataGridView
    Friend WithEvents Btn選択ボタン As Button
    Friend WithEvents Grb設定メニュー情報 As GroupBox
    Friend WithEvents Dgv選択済品目 As DataGridView
    Friend WithEvents Btn取消 As Button
    Friend WithEvents lblPosPtn As Label
    Friend WithEvents lblGrpNo As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Txt単価 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Txt品目名 As TextBox
    Friend WithEvents Txt商品CD As TextBox
    Friend WithEvents DgvWork As DataGridView
    Friend WithEvents DGVwork2 As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents POSパターンID As TextBox
    Friend WithEvents 新規Flag As Label
    Friend WithEvents Txt新規か As TextBox
    Friend WithEvents NO As DataGridViewTextBoxColumn
    Friend WithEvents 商品CD As DataGridViewTextBoxColumn
    Friend WithEvents 品目名 As DataGridViewTextBoxColumn
End Class
