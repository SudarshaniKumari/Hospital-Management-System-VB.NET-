Public Class frmdoctorpage
    Private Sub btnaddpatient_Click(sender As Object, e As EventArgs) Handles btnaddpatient.Click
        frmpatient.Show()
    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Close()
    End Sub
End Class