Public Class Admin_Inv
	Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
		Me.Hide()
		Admin_Homevb.Show()
	End Sub
	Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
		Me.Hide()
		Admin_OrdLogs.Show()
	End Sub
	Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
		Me.Hide()
		Admin_InvLogs.Show()
	End Sub

	Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

	End Sub
End Class