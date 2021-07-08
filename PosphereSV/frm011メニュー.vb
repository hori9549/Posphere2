Public Class frmフォームメニュー
    'POSタブ---------------------------------------------------------------------------------------------------------
    Private Sub btn閉じる_Click(sender As Object, e As EventArgs) Handles btn閉じる.Click
        Me.Close()
    End Sub

    Private Sub btn01マスタデータ反映_Click(sender As Object, e As EventArgs) Handles btnマスタデータ反映.Click
        Dim sfrm As New frm101マスタ取込
        Call sfrm.ShowDialog()
    End Sub

    Private Sub btn02POSパターン登録_Click(sender As Object, e As EventArgs) Handles btnPOSパターン.Click
        Dim sfrm As New frmPOSパターン
        Call sfrm.ShowDialog()
    End Sub

    Private Sub btn03端末情報_Click(sender As Object, e As EventArgs) Handles btn端末情報.Click
        Dim sfrm As New frm103端末情報登録
        Call sfrm.ShowDialog()
    End Sub

    Private Sub btn04グループ登録_Click(sender As Object, e As EventArgs) Handles btnグループ登録.Click
        Dim sfrm As New frm104グループ登録
        Call sfrm.ShowDialog()
    End Sub

    Private Sub btn05商品登録_Click(sender As Object, e As EventArgs) Handles btn商品登録.Click
        Dim sfrm As New frm105商品登録
        Call sfrm.ShowDialog()
    End Sub

    Private Sub btn06データベース参照_Click(sender As Object, e As EventArgs) Handles btnデータベース参照.Click
        Dim sfrm As New frm106データベース参照
        Call sfrm.ShowDialog()
    End Sub

    Private Sub btn08電子ジャーナル照会_Click(sender As Object, e As EventArgs) Handles btn電子ジャーナル照会.Click
        Dim sfrm As New frm108電子ジャーナル照会
        Call sfrm.ShowDialog()
    End Sub

    Private Sub btn09POS電子収集_Click(sender As Object, e As EventArgs) Handles btnPOS電子収集.Click
        Dim sfrm As New frm109POS電子ジャーナル収集
        Call sfrm.ShowDialog()
    End Sub

    Private Sub btn10レジボタン設定_Click(sender As Object, e As EventArgs) Handles btnレジボタン設定.Click
        Dim sfrm As New frm110レジボタン設定
        Call sfrm.ShowDialog()
    End Sub

    Private Sub btn11レジメニュー設定_Click(sender As Object, e As EventArgs) Handles btnレジメニュー設定.Click
        Dim sfrm As New frm111レジメニュー設定
        Call sfrm.ShowDialog()
    End Sub

    Private Sub btn12レジボタン簡易_Click(sender As Object, e As EventArgs) Handles btnレジボタン簡易.Click
        Dim sfrm As New frm112レジボタン設定簡易
        Call sfrm.ShowDialog()
    End Sub

    Private Sub btn13レジメニュー簡易_Click(sender As Object, e As EventArgs) Handles btnレジメニュー簡易.Click
        Dim sfrm As New frm113レジメニュー設定簡易
        Call sfrm.ShowDialog()
    End Sub

    Private Sub btn14POSレジ設定データ配信_Click(sender As Object, e As EventArgs) Handles btnPOSレジ設定データ配信.Click
        Dim sfrm As New frmレジ設定データ配信
        Call sfrm.ShowDialog()
    End Sub

    Private Sub btn17POS背画像配信_Click(sender As Object, e As EventArgs) Handles btnPOS背画像配信.Click
        Dim sfrm As New frm117POS背面画像ファイル配信
        Call sfrm.ShowDialog()
    End Sub

    Private Sub btn18POS更新プログラム配信_Click(sender As Object, e As EventArgs) Handles btnPOS更新プログラム配信.Click
        Dim sfrm As New frm118POS更新プログラム配信
        Call sfrm.ShowDialog()
    End Sub

    Private Sub btn19テーブル配信_Click(sender As Object, e As EventArgs) Handles btnテーブル配信.Click
        Dim sfrm As New frm119テーブル配置
        Call sfrm.ShowDialog()
    End Sub

    Private Sub btn20ハンディ設定_Click(sender As Object, e As EventArgs) Handles btnハンディ設定.Click
        Dim sfrm As New frm120ハンディターミナル設定
        Call sfrm.ShowDialog()
    End Sub

    Private Sub btn21プリンタコントロール_Click(sender As Object, e As EventArgs) Handles btnプリンタコントロール.Click
        Dim sfrm As New frm121プリンタコントロール設定
        Call sfrm.ShowDialog()
    End Sub

    Private Sub btn22伝票フォーマット_Click(sender As Object, e As EventArgs) Handles btn伝票フォーマット.Click
        Dim sfrm As New frm122伝票フォーマット設定
        Call sfrm.ShowDialog()
    End Sub


    '店舗SVタブ------------------------------------------------------------------------------------------------------
    Private Sub btn店舗情報_Click(sender As Object, e As EventArgs) 
        'Dim sfrm As New frm店舗情報登録
        'Call sfrm.ShowDialog()
    End Sub

    Private Sub btnpos設定_Click(sender As Object, e As EventArgs) Handles btnpos設定.Click

    End Sub

    Private Sub frmフォームメニュー_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class