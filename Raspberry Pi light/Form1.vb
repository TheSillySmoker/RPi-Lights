Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnOn_Click(sender As Object, e As EventArgs) Handles btnOn.Click
        System.Diagnostics.Process.Start("LEDOn.bat")
    End Sub


    Private Sub btnFlash_Click(sender As Object, e As EventArgs) Handles btnFlash.Click
        System.Diagnostics.Process.Start("Flashing.bat")
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnOff.Click
        System.Diagnostics.Process.Start("LEDOff.bat")
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        System.Diagnostics.Process.Start("pull.bat")
    End Sub
End Class