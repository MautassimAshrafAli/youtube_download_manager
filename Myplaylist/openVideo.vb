Imports System.Text.RegularExpressions

Public Class openVideo


	Public Shared _yUrl As String

	Private Sub openVideo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

		Me.CenterToScreen()

		Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)

	
		webBrowser1.DocumentText = String.Format(
					"<meta http-equiv='X-UA-Compatible' content='IE=Edge'/>" &
				  "<iframe width=""{1}"" height=""{2}""" &
				  " src=""https://www.youtube.com/embed/{0}?autoplay=1"" title = ""YouTube video player"" frameborder=""0"" allow = ""accelerometer; autoplay; clipboard - write; encrypted - media; gyroscope; picture -In-picture"" allowfullscreen scrolling='no'; encrypted-media; gyroscope;></iframe>", _yUrl, webBrowser1.Width - 25, webBrowser1.Height - 20)


	End Sub


	Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
		Me.Close()
	End Sub

	Private Sub timer4_Tick(sender As Object, e As EventArgs) Handles timer4.Tick
		If Me.InvokeRequired Then

			timer4.Stop()
		End If

		If Me.Opacity < 1 Then

			Me.Opacity += 0.1


		Else

			timer4.Stop()
		End If
	End Sub

	Private Sub a_h_Tick(sender As Object, e As EventArgs) Handles a_h.Tick
		Me.Opacity -= 0.1

		If Me.Opacity < 0.9 Then

			a_h.Stop()

		End If
	End Sub

	Private Sub panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles panel1.MouseDown
		a_h.Start()
	End Sub

	Private Sub panel1_MouseUp(sender As Object, e As MouseEventArgs) Handles panel1.MouseUp
		timer4.Start()
	End Sub

	Private Sub webBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles webBrowser1.DocumentCompleted
		webBrowser1.Document.Body.Style = "overflow:hidden"
	End Sub
End Class