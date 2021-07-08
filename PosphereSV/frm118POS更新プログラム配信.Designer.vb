<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm118POS更新プログラム配信
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn参照１ = New System.Windows.Forms.Button()
        Me.btn参照２ = New System.Windows.Forms.Button()
        Me.txt参照box1 = New System.Windows.Forms.TextBox()
        Me.txt参照box2 = New System.Windows.Forms.TextBox()
        Me.lblVer1 = New System.Windows.Forms.Label()
        Me.lblVer2 = New System.Windows.Forms.Label()
        Me.txtBox3 = New System.Windows.Forms.TextBox()
        Me.txtBox4 = New System.Windows.Forms.TextBox()
        Me.btn一覧表示 = New System.Windows.Forms.Button()
        Me.btn配信 = New System.Windows.Forms.Button()
        Me.btn終了 = New System.Windows.Forms.Button()
        Me.grpPOS更新プログラム配信 = New System.Windows.Forms.DataGridView()
        CType(Me.grpPOS更新プログラム配信, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl配信元フォルダ
        '
        Me.lbl配信元フォルダ.AutoSize = True
        Me.lbl配信元フォルダ.Location = New System.Drawing.Point(29, 11)
        Me.lbl配信元フォルダ.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl配信元フォルダ.Name = "lbl配信元フォルダ"
        Me.lbl配信元フォルダ.Size = New System.Drawing.Size(95, 15)
        Me.lbl配信元フォルダ.TabIndex = 0
        Me.lbl配信元フォルダ.Text = "配信元フォルダ"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 56)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "配信元フォルダ(簡易)"
        '
        'btn参照１
        '
        Me.btn参照１.Location = New System.Drawing.Point(205, 1)
        Me.btn参照１.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn参照１.Name = "btn参照１"
        Me.btn参照１.Size = New System.Drawing.Size(72, 36)
        Me.btn参照１.TabIndex = 2
        Me.btn参照１.Text = "参照"
        Me.btn参照１.UseVisualStyleBackColor = True
        '
        'btn参照２
        '
        Me.btn参照２.Location = New System.Drawing.Point(205, 45)
        Me.btn参照２.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn参照２.Name = "btn参照２"
        Me.btn参照２.Size = New System.Drawing.Size(72, 34)
        Me.btn参照２.TabIndex = 3
        Me.btn参照２.Text = "参照"
        Me.btn参照２.UseVisualStyleBackColor = True
        '
        'txt参照box1
        '
        Me.txt参照box1.Location = New System.Drawing.Point(285, 8)
        Me.txt参照box1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt参照box1.Name = "txt参照box1"
        Me.txt参照box1.Size = New System.Drawing.Size(344, 22)
        Me.txt参照box1.TabIndex = 4
        Me.txt参照box1.Text = "D:\AP\POS\SpreadN_UPDT"
        '
        'txt参照box2
        '
        Me.txt参照box2.Location = New System.Drawing.Point(285, 48)
        Me.txt参照box2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt参照box2.Name = "txt参照box2"
        Me.txt参照box2.Size = New System.Drawing.Size(344, 22)
        Me.txt参照box2.TabIndex = 5
        Me.txt参照box2.Text = "D:\AP\POS\SpreadNS_UPDT"
        '
        'lblVer1
        '
        Me.lblVer1.AutoSize = True
        Me.lblVer1.Location = New System.Drawing.Point(639, 19)
        Me.lblVer1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblVer1.Name = "lblVer1"
        Me.lblVer1.Size = New System.Drawing.Size(29, 15)
        Me.lblVer1.TabIndex = 6
        Me.lblVer1.Text = "Ver"
        '
        'lblVer2
        '
        Me.lblVer2.AutoSize = True
        Me.lblVer2.Location = New System.Drawing.Point(639, 55)
        Me.lblVer2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblVer2.Name = "lblVer2"
        Me.lblVer2.Size = New System.Drawing.Size(29, 15)
        Me.lblVer2.TabIndex = 7
        Me.lblVer2.Text = "Ver"
        '
        'txtBox3
        '
        Me.txtBox3.Location = New System.Drawing.Point(696, 15)
        Me.txtBox3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtBox3.Name = "txtBox3"
        Me.txtBox3.Size = New System.Drawing.Size(176, 22)
        Me.txtBox3.TabIndex = 8
        Me.txtBox3.Text = "4.00"
        '
        'txtBox4
        '
        Me.txtBox4.Location = New System.Drawing.Point(696, 51)
        Me.txtBox4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtBox4.Name = "txtBox4"
        Me.txtBox4.Size = New System.Drawing.Size(176, 22)
        Me.txtBox4.TabIndex = 9
        Me.txtBox4.Text = "4.00"
        '
        'btn一覧表示
        '
        Me.btn一覧表示.Location = New System.Drawing.Point(927, 28)
        Me.btn一覧表示.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn一覧表示.Name = "btn一覧表示"
        Me.btn一覧表示.Size = New System.Drawing.Size(125, 51)
        Me.btn一覧表示.TabIndex = 10
        Me.btn一覧表示.Text = "一覧表示"
        Me.btn一覧表示.UseVisualStyleBackColor = True
        '
        'btn配信
        '
        Me.btn配信.Location = New System.Drawing.Point(1079, 28)
        Me.btn配信.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn配信.Name = "btn配信"
        Me.btn配信.Size = New System.Drawing.Size(109, 51)
        Me.btn配信.TabIndex = 11
        Me.btn配信.Text = "配信"
        Me.btn配信.UseVisualStyleBackColor = True
        '
        'btn終了
        '
        Me.btn終了.Location = New System.Drawing.Point(1215, 28)
        Me.btn終了.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn終了.Name = "btn終了"
        Me.btn終了.Size = New System.Drawing.Size(113, 51)
        Me.btn終了.TabIndex = 12
        Me.btn終了.Text = "終了"
        Me.btn終了.UseVisualStyleBackColor = True
        '
        'grpPOS更新プログラム配信
        '
        Me.grpPOS更新プログラム配信.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grpPOS更新プログラム配信.Location = New System.Drawing.Point(45, 111)
        Me.grpPOS更新プログラム配信.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpPOS更新プログラム配信.Name = "grpPOS更新プログラム配信"
        Me.grpPOS更新プログラム配信.RowHeadersWidth = 51
        Me.grpPOS更新プログラム配信.RowTemplate.Height = 21
        Me.grpPOS更新プログラム配信.Size = New System.Drawing.Size(1312, 785)
        Me.grpPOS更新プログラム配信.TabIndex = 13
        '
        'frm118POS更新プログラム配信
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1284, 775)
        Me.Controls.Add(Me.grpPOS更新プログラム配信)
        Me.Controls.Add(Me.btn終了)
        Me.Controls.Add(Me.btn配信)
        Me.Controls.Add(Me.btn一覧表示)
        Me.Controls.Add(Me.txtBox4)
        Me.Controls.Add(Me.txtBox3)
        Me.Controls.Add(Me.lblVer2)
        Me.Controls.Add(Me.lblVer1)
        Me.Controls.Add(Me.txt参照box2)
        Me.Controls.Add(Me.txt参照box1)
        Me.Controls.Add(Me.btn参照２)
        Me.Controls.Add(Me.btn参照１)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbl配信元フォルダ)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frm118POS更新プログラム配信"
        Me.Text = "ＰＯＳ更新プログラム配信"
        CType(Me.grpPOS更新プログラム配信, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl配信元フォルダ As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btn参照１ As Button
    Friend WithEvents btn参照２ As Button
    Friend WithEvents txt参照box1 As TextBox
    Friend WithEvents txt参照box2 As TextBox
    Friend WithEvents lblVer1 As Label
    Friend WithEvents lblVer2 As Label
    Friend WithEvents txtBox3 As TextBox
    Friend WithEvents txtBox4 As TextBox
    Friend WithEvents btn一覧表示 As Button
    Friend WithEvents btn配信 As Button
    Friend WithEvents btn終了 As Button
    Friend WithEvents grpPOS更新プログラム配信 As DataGridView
End Class
