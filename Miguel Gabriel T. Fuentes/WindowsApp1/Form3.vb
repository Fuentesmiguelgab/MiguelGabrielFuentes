Public Class Form3
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'qwerty37
        If My.Settings.SerialKey = TextBox3.Text Then
            My.Settings.AppStat = "FULL VERSION"
            My.Settings.Save()
            Me.Close()
        Else
            MsgBox("WRONG KEY", vbCritical + MessageBoxButtons.OKCancel)

        End If
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form3_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        End

    End Sub
End Class