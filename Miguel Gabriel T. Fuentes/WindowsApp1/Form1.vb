Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim username As String
        Dim password As String
        username = TextBox1.Text
        password = TextBox2.Text

        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("you are ekiz to me", vbExclamation + MessageBoxButtons.OK)

        Else
            If username.Equals("miguel") And password.Equals("gwapo") Then
                MsgBox("Sucessfull po", vbInformation + MessageBoxButtons.OK)
                Form2.ShowDialog()
            Else
                MsgBox("you are ekiz to me", vbCritical + MessageBoxButtons.OK)

            End If
        End If

        Me.Dispose()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If My.Settings.AppStat = "Trial Version" Then
            If My.Settings.LoadCount < 0 Then
                Form3.ShowDialog()
            End If

            Me.Text = My.Settings.AppStat & " : COUNT - " & My.Settings.LoadCount
            My.Settings.LoadCount -= 1
            My.Settings.Save()

        Else
            Me.Text = My.Settings.AppStat

        End If
    End Sub
End Class
