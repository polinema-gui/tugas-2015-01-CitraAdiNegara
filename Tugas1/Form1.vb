Public Class Form1
    Private Sub UbahButton_Click(sender As Object, e As EventArgs) Handles UbahButton.Click
        If MyBase.BackColor = Color.Red Then
            MyBase.BackColor = Color.Blue
        Else
            MyBase.BackColor = Color.Red
        End If
    End Sub

    Private Sub JUDUL_Click(sender As Object, e As EventArgs) Handles JUDUL.Click

    End Sub
End Class
