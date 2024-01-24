Public Class Form1

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub RadioButton9_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton9.CheckedChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Points As Integer = 0
        If CheckBox1.Checked = True Then
            If RadioButton2.Checked = True Then
                Points = Points + 10

            End If
            If RadioButton9.Checked = True Then
                Points = Points + 10

            End If
            If RadioButton4.Checked = True Then
                Points = Points + 10
            End If
            Label5.Text = "You have scored : " + Points.ToString

        Else : MsgBox("Swear on God that you have not copied")
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False
        MsgBox("Your time is up")
        End
    End Sub

    Dim Time As Integer = 0
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If Time < 10 Then
            Time = Time + 1
        Else
            Timer2.Enabled = False
        End If

    End Sub
End Class
