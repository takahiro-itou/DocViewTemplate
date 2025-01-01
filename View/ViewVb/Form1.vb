﻿Public Class Form1

Private Sub RunCount(ByVal message As String)
    Dim result As Integer
    Dim objWrapper As SampleWrapper.Common.SampleDocument = New SampleWrapper.Common.SampleDocument()

    objWrapper.setMessage(message)
    result = objWrapper.countAlphabet()
    MsgBox("入力した文字列中のアルファベットの個数は " & result, MsgBoxStyle.OkOnly)
End Sub

Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    RunCount(TextBox1.Text)
End Sub

Private Sub mnuFileExit_Click(sender As Object, e As EventArgs) Handles _
            mnuFileExit.Click
''--------------------------------------------------------------------
''    メニュー「ファイル」－「終了」
''--------------------------------------------------------------------
    Application.Exit()
End Sub

Private Sub mnuRunCount_Click(sender As Object, e As EventArgs) Handles _
            mnuRunCount.Click
''--------------------------------------------------------------------
''    メニュー「実行」－「カウント」
''--------------------------------------------------------------------
    RunCount(TextBox1.Text)
End Sub

Private Sub SampleControl1_RunButtonClick(sender As Object, e As EventArgs) _
    Handles SampleControl1.RunButtonClick
''--------------------------------------------------------------------
''    イベントハンドラ
''
''    ユーザーコントロールの「実行ボタンクリック」
''--------------------------------------------------------------------
    RunCount(SampleControl1.InputText)
End Sub

End Class
