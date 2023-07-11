Public Class frmAdminlog
    Private Sub btnlog_Click(sender As Object, e As EventArgs) Handles btnlog.Click
        If txtusername.Text = "Admin" And txtpassword.Text = "12345" Then
            Me.Hide()
            frmRoyalHospital.Show()
        Else
            MsgBox("Invalid username or password")
        End If
    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        txtusername.Text = ""
        txtpassword.Text = ""
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub
End Class