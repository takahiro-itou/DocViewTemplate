Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim message As String
        Dim result As Integer
        Dim objWrapper As Wrapper.Class1 = New Wrapper.Class1()

        message = TextBox1.Text
        result = objWrapper.test1(message)
        MsgBox("入力した文字列の長さは " & result, MsgBoxStyle.OkOnly)
    End Sub
End Class
