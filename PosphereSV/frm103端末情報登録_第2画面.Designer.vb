<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm103端末情報登録_第2画面
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl端末名 = New System.Windows.Forms.Label()
        Me.lblPOSパターン = New System.Windows.Forms.Label()
        Me.lblPOS種別 = New System.Windows.Forms.Label()
        Me.lbl端末IPアドレス = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblマスタ配信 = New System.Windows.Forms.Label()
        Me.lbl背面画像 = New System.Windows.Forms.Label()
        Me.lbl更新プロ配信フォルダ = New System.Windows.Forms.Label()
        Me.txt端末名入力 = New System.Windows.Forms.TextBox()
        Me.txtマスタ配信 = New System.Windows.Forms.TextBox()
        Me.txt背面画像配信 = New System.Windows.Forms.TextBox()
        Me.txt更新プログラム配信 = New System.Windows.Forms.TextBox()
        Me.cmb_POSパターン = New System.Windows.Forms.ComboBox()
        Me.grb内枠 = New System.Windows.Forms.GroupBox()
        Me.rdbtn物販簡易 = New System.Windows.Forms.RadioButton()
        Me.rdbtn物販レジ = New System.Windows.Forms.RadioButton()
        Me.rdbtnレストランレジ = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtアドレス1 = New System.Windows.Forms.TextBox()
        Me.txtアドレス2 = New System.Windows.Forms.TextBox()
        Me.txtアドレス3 = New System.Windows.Forms.TextBox()
        Me.btn疎通確認 = New System.Windows.Forms.Button()
        Me.txtアドレス4 = New System.Windows.Forms.TextBox()
        Me.grb外枠 = New System.Windows.Forms.GroupBox()
        Me.btn参照3 = New System.Windows.Forms.Button()
        Me.btn参照2 = New System.Windows.Forms.Button()
        Me.btn参照1 = New System.Windows.Forms.Button()
        Me.gpbメニュー = New System.Windows.Forms.GroupBox()
        Me.btnキャンセル = New System.Windows.Forms.Button()
        Me.btn削除 = New System.Windows.Forms.Button()
        Me.btn更新 = New System.Windows.Forms.Button()
        Me.txt端末CD入力 = New System.Windows.Forms.TextBox()
        Me.lbl端末CD = New System.Windows.Forms.Label()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.FontDialog2 = New System.Windows.Forms.FontDialog()
        Me.grb内枠.SuspendLayout()
        Me.grb外枠.SuspendLayout()
        Me.gpbメニュー.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 114)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 12)
        Me.Label1.TabIndex = 0
        '
        'lbl端末名
        '
        Me.lbl端末名.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl端末名.Location = New System.Drawing.Point(6, 12)
        Me.lbl端末名.Name = "lbl端末名"
        Me.lbl端末名.Size = New System.Drawing.Size(150, 20)
        Me.lbl端末名.TabIndex = 1
        Me.lbl端末名.Text = "端末名"
        '
        'lblPOSパターン
        '
        Me.lblPOSパターン.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblPOSパターン.Location = New System.Drawing.Point(6, 56)
        Me.lblPOSパターン.Name = "lblPOSパターン"
        Me.lblPOSパターン.Size = New System.Drawing.Size(150, 20)
        Me.lblPOSパターン.TabIndex = 2
        Me.lblPOSパターン.Text = "POSパターン"
        '
        'lblPOS種別
        '
        Me.lblPOS種別.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblPOS種別.Location = New System.Drawing.Point(6, 106)
        Me.lblPOS種別.Name = "lblPOS種別"
        Me.lblPOS種別.Size = New System.Drawing.Size(150, 80)
        Me.lblPOS種別.TabIndex = 3
        Me.lblPOS種別.Text = "POS種別"
        '
        'lbl端末IPアドレス
        '
        Me.lbl端末IPアドレス.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl端末IPアドレス.Location = New System.Drawing.Point(6, 218)
        Me.lbl端末IPアドレス.Name = "lbl端末IPアドレス"
        Me.lbl端末IPアドレス.Size = New System.Drawing.Size(150, 20)
        Me.lbl端末IPアドレス.TabIndex = 4
        Me.lbl端末IPアドレス.Text = "端末IPアドレス"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label6.Location = New System.Drawing.Point(352, 258)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 16)
        Me.Label6.TabIndex = 5
        '
        'lblマスタ配信
        '
        Me.lblマスタ配信.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblマスタ配信.Location = New System.Drawing.Point(6, 269)
        Me.lblマスタ配信.Name = "lblマスタ配信"
        Me.lblマスタ配信.Size = New System.Drawing.Size(150, 20)
        Me.lblマスタ配信.TabIndex = 6
        Me.lblマスタ配信.Text = "マスタ配信フォルダ"
        '
        'lbl背面画像
        '
        Me.lbl背面画像.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl背面画像.Location = New System.Drawing.Point(6, 302)
        Me.lbl背面画像.Name = "lbl背面画像"
        Me.lbl背面画像.Size = New System.Drawing.Size(150, 20)
        Me.lbl背面画像.TabIndex = 7
        Me.lbl背面画像.Text = "背面画像配信フォルダ"
        '
        'lbl更新プロ配信フォルダ
        '
        Me.lbl更新プロ配信フォルダ.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl更新プロ配信フォルダ.Location = New System.Drawing.Point(6, 335)
        Me.lbl更新プロ配信フォルダ.Name = "lbl更新プロ配信フォルダ"
        Me.lbl更新プロ配信フォルダ.Size = New System.Drawing.Size(150, 20)
        Me.lbl更新プロ配信フォルダ.TabIndex = 8
        Me.lbl更新プロ配信フォルダ.Text = "更新プログラム配信フォルダ"
        '
        'txt端末名入力
        '
        Me.txt端末名入力.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt端末名入力.Location = New System.Drawing.Point(181, 9)
        Me.txt端末名入力.Name = "txt端末名入力"
        Me.txt端末名入力.Size = New System.Drawing.Size(350, 23)
        Me.txt端末名入力.TabIndex = 9
        '
        'txtマスタ配信
        '
        Me.txtマスタ配信.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtマスタ配信.Location = New System.Drawing.Point(182, 266)
        Me.txtマスタ配信.Name = "txtマスタ配信"
        Me.txtマスタ配信.Size = New System.Drawing.Size(350, 23)
        Me.txtマスタ配信.TabIndex = 10
        '
        'txt背面画像配信
        '
        Me.txt背面画像配信.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt背面画像配信.Location = New System.Drawing.Point(182, 299)
        Me.txt背面画像配信.Name = "txt背面画像配信"
        Me.txt背面画像配信.Size = New System.Drawing.Size(350, 23)
        Me.txt背面画像配信.TabIndex = 11
        '
        'txt更新プログラム配信
        '
        Me.txt更新プログラム配信.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt更新プログラム配信.Location = New System.Drawing.Point(182, 332)
        Me.txt更新プログラム配信.Name = "txt更新プログラム配信"
        Me.txt更新プログラム配信.Size = New System.Drawing.Size(350, 23)
        Me.txt更新プログラム配信.TabIndex = 12
        '
        'cmb_POSパターン
        '
        Me.cmb_POSパターン.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cmb_POSパターン.FormattingEnabled = True
        Me.cmb_POSパターン.Location = New System.Drawing.Point(181, 52)
        Me.cmb_POSパターン.Name = "cmb_POSパターン"
        Me.cmb_POSパターン.Size = New System.Drawing.Size(350, 24)
        Me.cmb_POSパターン.TabIndex = 13
        '
        'grb内枠
        '
        Me.grb内枠.Controls.Add(Me.rdbtn物販簡易)
        Me.grb内枠.Controls.Add(Me.rdbtn物販レジ)
        Me.grb内枠.Controls.Add(Me.rdbtnレストランレジ)
        Me.grb内枠.Location = New System.Drawing.Point(181, 97)
        Me.grb内枠.Name = "grb内枠"
        Me.grb内枠.Size = New System.Drawing.Size(350, 112)
        Me.grb内枠.TabIndex = 14
        Me.grb内枠.TabStop = False
        '
        'rdbtn物販簡易
        '
        Me.rdbtn物販簡易.AutoSize = True
        Me.rdbtn物販簡易.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.rdbtn物販簡易.Location = New System.Drawing.Point(15, 86)
        Me.rdbtn物販簡易.Name = "rdbtn物販簡易"
        Me.rdbtn物販簡易.Size = New System.Drawing.Size(115, 20)
        Me.rdbtn物販簡易.TabIndex = 2
        Me.rdbtn物販簡易.Text = "物販簡易レジ"
        Me.rdbtn物販簡易.UseVisualStyleBackColor = True
        '
        'rdbtn物販レジ
        '
        Me.rdbtn物販レジ.AutoSize = True
        Me.rdbtn物販レジ.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.rdbtn物販レジ.Location = New System.Drawing.Point(15, 52)
        Me.rdbtn物販レジ.Name = "rdbtn物販レジ"
        Me.rdbtn物販レジ.Size = New System.Drawing.Size(83, 20)
        Me.rdbtn物販レジ.TabIndex = 1
        Me.rdbtn物販レジ.Text = "物販レジ"
        Me.rdbtn物販レジ.UseVisualStyleBackColor = True
        '
        'rdbtnレストランレジ
        '
        Me.rdbtnレストランレジ.AutoSize = True
        Me.rdbtnレストランレジ.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.rdbtnレストランレジ.Location = New System.Drawing.Point(15, 18)
        Me.rdbtnレストランレジ.Name = "rdbtnレストランレジ"
        Me.rdbtnレストランレジ.Size = New System.Drawing.Size(280, 20)
        Me.rdbtnレストランレジ.TabIndex = 0
        Me.rdbtnレストランレジ.Text = "レストランレジ＆物販キッチンプリンタ使用"
        Me.rdbtnレストランレジ.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(214, 226)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 10)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "."
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label5.Location = New System.Drawing.Point(268, 226)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(20, 10)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "."
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label7.Location = New System.Drawing.Point(322, 225)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(20, 10)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "."
        '
        'txtアドレス1
        '
        Me.txtアドレス1.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtアドレス1.Location = New System.Drawing.Point(182, 218)
        Me.txtアドレス1.Name = "txtアドレス1"
        Me.txtアドレス1.Size = New System.Drawing.Size(30, 23)
        Me.txtアドレス1.TabIndex = 20
        '
        'txtアドレス2
        '
        Me.txtアドレス2.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtアドレス2.Location = New System.Drawing.Point(236, 219)
        Me.txtアドレス2.Name = "txtアドレス2"
        Me.txtアドレス2.Size = New System.Drawing.Size(30, 23)
        Me.txtアドレス2.TabIndex = 21
        '
        'txtアドレス3
        '
        Me.txtアドレス3.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtアドレス3.Location = New System.Drawing.Point(290, 219)
        Me.txtアドレス3.Name = "txtアドレス3"
        Me.txtアドレス3.Size = New System.Drawing.Size(30, 23)
        Me.txtアドレス3.TabIndex = 22
        '
        'btn疎通確認
        '
        Me.btn疎通確認.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn疎通確認.Location = New System.Drawing.Point(399, 215)
        Me.btn疎通確認.Name = "btn疎通確認"
        Me.btn疎通確認.Size = New System.Drawing.Size(90, 30)
        Me.btn疎通確認.TabIndex = 23
        Me.btn疎通確認.Text = "疎通確認"
        Me.btn疎通確認.UseVisualStyleBackColor = True
        '
        'txtアドレス4
        '
        Me.txtアドレス4.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtアドレス4.Location = New System.Drawing.Point(344, 219)
        Me.txtアドレス4.Name = "txtアドレス4"
        Me.txtアドレス4.Size = New System.Drawing.Size(30, 23)
        Me.txtアドレス4.TabIndex = 24
        '
        'grb外枠
        '
        Me.grb外枠.Controls.Add(Me.btn参照3)
        Me.grb外枠.Controls.Add(Me.btn参照2)
        Me.grb外枠.Controls.Add(Me.btn参照1)
        Me.grb外枠.Controls.Add(Me.txtアドレス4)
        Me.grb外枠.Controls.Add(Me.btn疎通確認)
        Me.grb外枠.Controls.Add(Me.txtアドレス3)
        Me.grb外枠.Controls.Add(Me.txtアドレス2)
        Me.grb外枠.Controls.Add(Me.txtアドレス1)
        Me.grb外枠.Controls.Add(Me.Label7)
        Me.grb外枠.Controls.Add(Me.Label5)
        Me.grb外枠.Controls.Add(Me.Label2)
        Me.grb外枠.Controls.Add(Me.grb内枠)
        Me.grb外枠.Controls.Add(Me.cmb_POSパターン)
        Me.grb外枠.Controls.Add(Me.txt更新プログラム配信)
        Me.grb外枠.Controls.Add(Me.txt背面画像配信)
        Me.grb外枠.Controls.Add(Me.txtマスタ配信)
        Me.grb外枠.Controls.Add(Me.txt端末名入力)
        Me.grb外枠.Controls.Add(Me.lbl更新プロ配信フォルダ)
        Me.grb外枠.Controls.Add(Me.lbl背面画像)
        Me.grb外枠.Controls.Add(Me.lblマスタ配信)
        Me.grb外枠.Controls.Add(Me.Label6)
        Me.grb外枠.Controls.Add(Me.lbl端末IPアドレス)
        Me.grb外枠.Controls.Add(Me.lblPOS種別)
        Me.grb外枠.Controls.Add(Me.lblPOSパターン)
        Me.grb外枠.Controls.Add(Me.lbl端末名)
        Me.grb外枠.Location = New System.Drawing.Point(12, 175)
        Me.grb外枠.Name = "grb外枠"
        Me.grb外枠.Size = New System.Drawing.Size(984, 369)
        Me.grb外枠.TabIndex = 25
        Me.grb外枠.TabStop = False
        '
        'btn参照3
        '
        Me.btn参照3.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn参照3.Location = New System.Drawing.Point(538, 328)
        Me.btn参照3.Name = "btn参照3"
        Me.btn参照3.Size = New System.Drawing.Size(60, 30)
        Me.btn参照3.TabIndex = 27
        Me.btn参照3.Text = "参照"
        Me.btn参照3.UseVisualStyleBackColor = True
        '
        'btn参照2
        '
        Me.btn参照2.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn参照2.Location = New System.Drawing.Point(538, 295)
        Me.btn参照2.Name = "btn参照2"
        Me.btn参照2.Size = New System.Drawing.Size(60, 30)
        Me.btn参照2.TabIndex = 26
        Me.btn参照2.Text = "参照"
        Me.btn参照2.UseVisualStyleBackColor = True
        '
        'btn参照1
        '
        Me.btn参照1.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn参照1.Location = New System.Drawing.Point(538, 262)
        Me.btn参照1.Name = "btn参照1"
        Me.btn参照1.Size = New System.Drawing.Size(60, 30)
        Me.btn参照1.TabIndex = 25
        Me.btn参照1.Text = "参照"
        Me.btn参照1.UseVisualStyleBackColor = True
        '
        'gpbメニュー
        '
        Me.gpbメニュー.Controls.Add(Me.btnキャンセル)
        Me.gpbメニュー.Controls.Add(Me.btn削除)
        Me.gpbメニュー.Controls.Add(Me.btn更新)
        Me.gpbメニュー.Controls.Add(Me.txt端末CD入力)
        Me.gpbメニュー.Controls.Add(Me.lbl端末CD)
        Me.gpbメニュー.Location = New System.Drawing.Point(12, 27)
        Me.gpbメニュー.Name = "gpbメニュー"
        Me.gpbメニュー.Size = New System.Drawing.Size(984, 115)
        Me.gpbメニュー.TabIndex = 26
        Me.gpbメニュー.TabStop = False
        '
        'btnキャンセル
        '
        Me.btnキャンセル.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnキャンセル.Location = New System.Drawing.Point(878, 29)
        Me.btnキャンセル.Name = "btnキャンセル"
        Me.btnキャンセル.Size = New System.Drawing.Size(100, 50)
        Me.btnキャンセル.TabIndex = 4
        Me.btnキャンセル.Text = "キャンセル"
        Me.btnキャンセル.UseVisualStyleBackColor = True
        '
        'btn削除
        '
        Me.btn削除.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn削除.Location = New System.Drawing.Point(780, 29)
        Me.btn削除.Name = "btn削除"
        Me.btn削除.Size = New System.Drawing.Size(100, 50)
        Me.btn削除.TabIndex = 3
        Me.btn削除.Text = "削除"
        Me.btn削除.UseVisualStyleBackColor = True
        '
        'btn更新
        '
        Me.btn更新.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn更新.Location = New System.Drawing.Point(683, 29)
        Me.btn更新.Name = "btn更新"
        Me.btn更新.Size = New System.Drawing.Size(100, 50)
        Me.btn更新.TabIndex = 2
        Me.btn更新.Text = "更新"
        Me.btn更新.UseVisualStyleBackColor = True
        '
        'txt端末CD入力
        '
        Me.txt端末CD入力.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt端末CD入力.Location = New System.Drawing.Point(106, 26)
        Me.txt端末CD入力.Name = "txt端末CD入力"
        Me.txt端末CD入力.Size = New System.Drawing.Size(76, 23)
        Me.txt端末CD入力.TabIndex = 1
        '
        'lbl端末CD
        '
        Me.lbl端末CD.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl端末CD.Location = New System.Drawing.Point(18, 29)
        Me.lbl端末CD.Name = "lbl端末CD"
        Me.lbl端末CD.Size = New System.Drawing.Size(82, 20)
        Me.lbl端末CD.TabIndex = 0
        Me.lbl端末CD.Text = "端末CD"
        '
        'frm103端末情報登録_第2画面
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 691)
        Me.Controls.Add(Me.gpbメニュー)
        Me.Controls.Add(Me.grb外枠)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frm103端末情報登録_第2画面"
        Me.Text = "登録画面"
        Me.grb内枠.ResumeLayout(False)
        Me.grb内枠.PerformLayout()
        Me.grb外枠.ResumeLayout(False)
        Me.grb外枠.PerformLayout()
        Me.gpbメニュー.ResumeLayout(False)
        Me.gpbメニュー.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lbl端末名 As Label
    Friend WithEvents lblPOSパターン As Label
    Friend WithEvents lblPOS種別 As Label
    Friend WithEvents lbl端末IPアドレス As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblマスタ配信 As Label
    Friend WithEvents lbl背面画像 As Label
    Friend WithEvents lbl更新プロ配信フォルダ As Label
    Friend WithEvents txt端末名入力 As TextBox
    Friend WithEvents txtマスタ配信 As TextBox
    Friend WithEvents txt背面画像配信 As TextBox
    Friend WithEvents txt更新プログラム配信 As TextBox
    Friend WithEvents cmb_POSパターン As ComboBox
    Friend WithEvents grb内枠 As GroupBox
    Friend WithEvents rdbtn物販簡易 As RadioButton
    Friend WithEvents rdbtn物販レジ As RadioButton
    Friend WithEvents rdbtnレストランレジ As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtアドレス1 As TextBox
    Friend WithEvents txtアドレス2 As TextBox
    Friend WithEvents txtアドレス3 As TextBox
    Friend WithEvents btn疎通確認 As Button
    Friend WithEvents txtアドレス4 As TextBox
    Friend WithEvents grb外枠 As GroupBox
    Friend WithEvents btn参照3 As Button
    Friend WithEvents btn参照2 As Button
    Friend WithEvents btn参照1 As Button
    Friend WithEvents gpbメニュー As GroupBox
    Friend WithEvents btnキャンセル As Button
    Friend WithEvents btn削除 As Button
    Friend WithEvents btn更新 As Button
    Friend WithEvents txt端末CD入力 As TextBox
    Friend WithEvents lbl端末CD As Label
    Friend WithEvents FontDialog1 As FontDialog
    Friend WithEvents FontDialog2 As FontDialog
End Class
