Public Class DataOverview
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        SimpleOPCInterface.ExitApp()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        SimpleOPCInterface.Show()

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        SimpleOPCInterface.Show()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        SimpleOPCInterface.ExitApp()
    End Sub
End Class