Public Class frmRoyalHospital
    Private Sub btnadddoctor_Click(sender As Object, e As EventArgs) Handles btnadddoctor.Click
        frmdoctor.Show()
    End Sub

    Private Sub btnaddnurse_Click(sender As Object, e As EventArgs) Handles btnaddnurse.Click
        frmnurse.Show()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Close()
    End Sub
End Class