Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim sftp As New Chilkat.SFtp()

        Dim success As Boolean

        success = sftp.UnlockComponent("30-day trial")
        TextBox1.Text = sftp.LastErrorText


    End Sub
End Class
