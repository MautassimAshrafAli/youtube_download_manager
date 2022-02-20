Public Class download_list

    Dim s_ As String = System.Environment.GetEnvironmentVariable("USERPROFILE")

    Private Sub download_list_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.CenterToScreen()

    End Sub

    Private Sub TextBox1_MouseEnter(sender As Object, e As EventArgs) Handles url_.MouseEnter

        If url_.Text = "Insert the url" Then

            url_.Text = String.Empty
            url_.ForeColor = Color.Black
            Label7.ForeColor = Color.Black

        End If
    End Sub

    Private Sub TextBox1_MouseLeave(sender As Object, e As EventArgs) Handles url_.MouseLeave

        If url_.Text <> "Insert the url" AndAlso url_.Text <> String.Empty Then

            url_.ForeColor = Color.Black

        Else

            url_.ForeColor = Color.DarkGray
            Label7.ForeColor = Color.DarkGray

            If String.IsNullOrEmpty(url_.Text) = True Then

                url_.Text = "Insert the url"


            End If

        End If

    End Sub

    Private Sub TextBox2_MouseEnter(sender As Object, e As EventArgs) Handles start_r.MouseEnter
        If start_r.Text = "Start" Then

            start_r.Text = String.Empty
            start_r.ForeColor = Color.Black


        End If
    End Sub

    Private Sub TextBox2_MouseLeave(sender As Object, e As EventArgs) Handles start_r.MouseLeave
        If start_r.Text <> "Start" AndAlso start_r.Text <> String.Empty Then

            start_r.ForeColor = Color.Black

        Else

            start_r.ForeColor = Color.DarkGray


            If String.IsNullOrEmpty(start_r.Text) = True Then

                start_r.Text = "Start"


            End If

        End If
    End Sub

    Private Sub TextBox3_MouseEnter(sender As Object, e As EventArgs) Handles end_r.MouseEnter
        If end_r.Text = "End" Then

            end_r.Text = String.Empty
            end_r.ForeColor = Color.Black


        End If
    End Sub

    Private Sub TextBox3_MouseLeave(sender As Object, e As EventArgs) Handles end_r.MouseLeave
        If end_r.Text <> "Start" AndAlso end_r.Text <> String.Empty Then

            end_r.ForeColor = Color.Black

        Else

            end_r.ForeColor = Color.DarkGray


            If String.IsNullOrEmpty(end_r.Text) = True Then

                end_r.Text = "End"


            End If

        End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Me.Close()
    End Sub
    Private Sub Convert_to_video_Click(sender As Object, e As EventArgs) Handles Panel4.Click, Convert_to_video.Click

        If url_.Text <> "Insert the url" AndAlso url_.Text <> String.Empty AndAlso start_r.Text <> "Start" AndAlso
            start_r.Text <> String.Empty AndAlso end_r.Text <> "End" AndAlso end_r.Text <> String.Empty Then

            Label2.Visible = False

            Shell("cmd.exe /c cd/ & cd Windows & cd youtube-dl & youtube-dl --update & youtube-dl -f " + c_video.Text +
                  " -f best -ciw --playlist-items " + start_r.Text + "-" + end_r.Text + " -o ""C:\Users\" + System.IO.Path.GetFileName(s_) +
                  "\Desktop\My_offlineVideo_list\%(title)s.%(ext)s"" --no-mtime " + url_.Text, AppWinStyle.NormalFocus)

        Else

            Label2.Visible = True

        End If

    End Sub

    Private Sub Convert_to_sound_Click(sender As Object, e As EventArgs) Handles Panel5.Click, Convert_to_sound.Click

        If url_.Text <> "Insert the url" AndAlso url_.Text <> String.Empty AndAlso start_r.Text <> "Start" AndAlso
            start_r.Text <> String.Empty AndAlso end_r.Text <> "End" AndAlso end_r.Text <> String.Empty Then

            Label2.Visible = False

            Shell("cmd.exe /c cd/ & cd Windows & cd youtube-dl & youtube-dl --update & youtube-dl -x --audio-format " + c_sound.Text +
                  " -ciw --playlist-items " + start_r.Text + "-" + end_r.Text + " -o ""C:\Users\" + System.IO.Path.GetFileName(s_) +
                  "\Desktop\My_offlineSound_list\%(title)s.%(ext)s"" --no-mtime " + url_.Text, AppWinStyle.NormalFocus)

        Else

            Label2.Visible = True

        End If

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Panel3.Click, Label4.Click

        Shell("cmd.exe /c start " + url_.Text, AppWinStyle.Hide)

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

    Private Sub GunaLinePanel1_MouseDown(sender As Object, e As MouseEventArgs) Handles GunaLinePanel1.MouseDown
        a_h.Start()
    End Sub

    Private Sub GunaLinePanel1_MouseUp(sender As Object, e As MouseEventArgs) Handles GunaLinePanel1.MouseUp
        timer4.Start()
    End Sub

End Class