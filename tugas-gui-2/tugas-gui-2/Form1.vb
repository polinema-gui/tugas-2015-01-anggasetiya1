Public Class Form1

    Private Sub Klik_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        If Me.BackColor = Color.Blue Then
            Me.BackColor = Color.Pink
        Else : Me.BackColor = Color.Cyan


        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BackColor = Color.Orange
    End Sub
End Class
