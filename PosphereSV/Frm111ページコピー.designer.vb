<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm111ページコピー
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
        Me.CmbPos = New System.Windows.Forms.ComboBox()
        Me.LblPosP = New System.Windows.Forms.Label()
        Me.Btnキャンセル = New System.Windows.Forms.Button()
        Me.Btn実行 = New System.Windows.Forms.Button()
        Me.txt元CmbPosPtn = New System.Windows.Forms.TextBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.lbl先PosPtn = New System.Windows.Forms.Label()
        Me.lblPrgBar = New System.Windows.Forms.Label()
        Me.txt元CmbPosName = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'CmbPos
        '
        Me.CmbPos.FormattingEnabled = True
        Me.CmbPos.ItemHeight = 15
        Me.CmbPos.Location = New System.Drawing.Point(275, 64)
        Me.CmbPos.Margin = New System.Windows.Forms.Padding(4)
        Me.CmbPos.Name = "CmbPos"
        Me.CmbPos.Size = New System.Drawing.Size(200, 23)
        Me.CmbPos.TabIndex = 83
        '
        'LblPosP
        '
        Me.LblPosP.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LblPosP.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.LblPosP.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LblPosP.Location = New System.Drawing.Point(77, 64)
        Me.LblPosP.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblPosP.Name = "LblPosP"
        Me.LblPosP.Size = New System.Drawing.Size(133, 29)
        Me.LblPosP.TabIndex = 82
        Me.LblPosP.Text = "POSパターン"
        Me.LblPosP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Btnキャンセル
        '
        Me.Btnキャンセル.Location = New System.Drawing.Point(295, 150)
        Me.Btnキャンセル.Margin = New System.Windows.Forms.Padding(4)
        Me.Btnキャンセル.Name = "Btnキャンセル"
        Me.Btnキャンセル.Size = New System.Drawing.Size(133, 39)
        Me.Btnキャンセル.TabIndex = 85
        Me.Btnキャンセル.Text = "キャンセル"
        Me.Btnキャンセル.UseVisualStyleBackColor = True
        '
        'Btn実行
        '
        Me.Btn実行.Location = New System.Drawing.Point(77, 150)
        Me.Btn実行.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn実行.Name = "Btn実行"
        Me.Btn実行.Size = New System.Drawing.Size(133, 39)
        Me.Btn実行.TabIndex = 84
        Me.Btn実行.Text = "実行"
        Me.Btn実行.UseVisualStyleBackColor = True
        '
        'txt元CmbPosPtn
        '
        Me.txt元CmbPosPtn.Location = New System.Drawing.Point(464, 125)
        Me.txt元CmbPosPtn.Margin = New System.Windows.Forms.Padding(4)
        Me.txt元CmbPosPtn.Multiline = True
        Me.txt元CmbPosPtn.Name = "txt元CmbPosPtn"
        Me.txt元CmbPosPtn.Size = New System.Drawing.Size(132, 50)
        Me.txt元CmbPosPtn.TabIndex = 86
        Me.txt元CmbPosPtn.Text = "コピー元の" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "CmbPosPtn" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.txt元CmbPosPtn.Visible = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(77, 253)
        Me.ProgressBar1.Margin = New System.Windows.Forms.Padding(4)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(373, 29)
        Me.ProgressBar1.TabIndex = 88
        '
        'lbl先PosPtn
        '
        Me.lbl先PosPtn.AutoSize = True
        Me.lbl先PosPtn.Font = New System.Drawing.Font("MS UI Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl先PosPtn.ForeColor = System.Drawing.Color.Green
        Me.lbl先PosPtn.Location = New System.Drawing.Point(272, 24)
        Me.lbl先PosPtn.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl先PosPtn.Name = "lbl先PosPtn"
        Me.lbl先PosPtn.Size = New System.Drawing.Size(286, 17)
        Me.lbl先PosPtn.TabIndex = 89
        Me.lbl先PosPtn.Text = "※コピー先のPOSパターンを選んでください"
        '
        'lblPrgBar
        '
        Me.lblPrgBar.AutoSize = True
        Me.lblPrgBar.Font = New System.Drawing.Font("MS UI Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblPrgBar.ForeColor = System.Drawing.Color.Red
        Me.lblPrgBar.Location = New System.Drawing.Point(77, 218)
        Me.lblPrgBar.Name = "lblPrgBar"
        Me.lblPrgBar.Size = New System.Drawing.Size(116, 17)
        Me.lblPrgBar.TabIndex = 90
        Me.lblPrgBar.Text = "PROGバーMSG"
        '
        'txt元CmbPosName
        '
        Me.txt元CmbPosName.Location = New System.Drawing.Point(464, 199)
        Me.txt元CmbPosName.Margin = New System.Windows.Forms.Padding(4)
        Me.txt元CmbPosName.Multiline = True
        Me.txt元CmbPosName.Name = "txt元CmbPosName"
        Me.txt元CmbPosName.Size = New System.Drawing.Size(132, 50)
        Me.txt元CmbPosName.TabIndex = 91
        Me.txt元CmbPosName.Text = "コピー元の" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "CmbPosName" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.txt元CmbPosName.Visible = False
        '
        'Frm111ページコピー
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(640, 325)
        Me.Controls.Add(Me.txt元CmbPosName)
        Me.Controls.Add(Me.lblPrgBar)
        Me.Controls.Add(Me.lbl先PosPtn)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.txt元CmbPosPtn)
        Me.Controls.Add(Me.Btnキャンセル)
        Me.Controls.Add(Me.Btn実行)
        Me.Controls.Add(Me.CmbPos)
        Me.Controls.Add(Me.LblPosP)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Frm111ページコピー"
        Me.Text = "ページコピー"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CmbPos As ComboBox
    Friend WithEvents Btnキャンセル As Button
    Friend WithEvents Btn実行 As Button
    Friend WithEvents txt元CmbPosPtn As TextBox
    Protected WithEvents LblPosP As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents lbl先PosPtn As Label
    Friend WithEvents lblPrgBar As Label
    Friend WithEvents txt元CmbPosName As TextBox
End Class
