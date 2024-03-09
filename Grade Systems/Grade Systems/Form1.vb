Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Math.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Evaluate_btn_Click(sender As Object, e As EventArgs) Handles Evaluate_btn.Click
        Dim math As Integer
        Dim science As Integer
        Dim english As Integer
        Dim Grade As Double

        math = Val(Math_txtbox.Text)
        science = Val(Science_txtbox.Text)
        english = Val(English_txtbox.Text)

        Grade = (math + science + english)
        Grade = Grade / 3

        If Grade >= 90 Then
            MsgBox("A+")
        ElseIf Grade >= 80 Then
            MsgBox("B+")
        ElseIf Grade >= 75 Then
            MsgBox("C+")
        Else
            MsgBox("failed")
        End If
    End Sub
End Class
