Imports System.Text
Imports System.Net
Imports System.Text.RegularExpressions
Imports System.IO
Imports SimpleWifi


Public Class YoutubeHorn

    Dim s As String
    Dim r1 As String
    Dim nu As Integer = 0
    Dim v As Guna.UI.Lib.ScrollBar.PanelScrollHelper
    Private Shared wifi_ As Wifi

    Public Shared Sub SetDoubleBuffering(ByVal control As System.Windows.Forms.Control, ByVal value As Boolean)
        Dim controlProperty As System.Reflection.PropertyInfo = GetType(System.Windows.Forms.Control).GetProperty("DoubleBuffered", (System.Reflection.BindingFlags.NonPublic Or System.Reflection.BindingFlags.Instance))
        controlProperty.SetValue(control, value, Nothing)
    End Sub

    Public Function CopyDirectory(ByVal SrcPath As String, ByVal DestPath As String, Optional ByVal bQuiet As Boolean = False) As Boolean

        If DestPath.Substring(DestPath.Length - 1, 1) <> System.IO.Path.DirectorySeparatorChar Then
            DestPath += System.IO.Path.DirectorySeparatorChar
        End If
        If Not System.IO.Directory.Exists(DestPath) Then System.IO.Directory.CreateDirectory(DestPath)
        Dim Files As String()
        Files = System.IO.Directory.GetFileSystemEntries(SrcPath)
        Dim element As String
        For Each element In Files
            If System.IO.Directory.Exists(element) Then
                CopyDirectory(element, DestPath & System.IO.Path.GetFileName(element), True)
            Else
                System.IO.File.Copy(element, DestPath & System.IO.Path.GetFileName(element), True)
            End If
        Next
        Return True
    End Function

    Dim s_ As String = System.Environment.GetEnvironmentVariable("USERPROFILE")

    Private Sub Myplaylist_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        On Error Resume Next

        Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)

        SetDoubleBuffering(Panel2, True)
        SetDoubleBuffering(FlowLayoutPanel1, True)
        SetDoubleBuffering(TableLayoutPanel2, True)
        SetDoubleBuffering(TableLayoutPanel3, True)
        SetDoubleBuffering(GunaElipsePanel1, True)
        SetDoubleBuffering(GunaElipsePanel2, True)
        SetDoubleBuffering(GunaElipsePanel3, True)
        SetDoubleBuffering(GunaResizeControl1, True)
        SetDoubleBuffering(GunaWinCircleProgressIndicator1, True)

        Me.CenterToScreen()

        'icon fornt text

        Label8.Text = Char.ConvertFromUtf32("&HF6FA")
        Label3.Text = Char.ConvertFromUtf32("&HE8BB")
        Label5.Text = Char.ConvertFromUtf32("&HE922")
        Label4.Text = Char.ConvertFromUtf32("&HE921")
        Label11.Text = Char.ConvertFromUtf32("&HE81E")
        Label12.Text = Char.ConvertFromUtf32("&HF384")
        Label14.Text = Char.ConvertFromUtf32("&HEC4F")
        Label15.Text = Char.ConvertFromUtf32("&HE149")

        v = New Guna.UI.Lib.ScrollBar.PanelScrollHelper(FlowLayoutPanel1, gunaVScrollBar1, False)

        Circular_PictureBox1.ImageLocation = "C:\ProgramData\Microsoft\User Account Pictures\user.png"

    End Sub

    Private Sub NeeR_button31_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Application.Exit()
    End Sub

    Private Sub Min__Click(sender As Object, e As EventArgs) Handles Label4.Click
        If Me.WindowState = FormWindowState.Normal Then

            Me.WindowState = FormWindowState.Minimized

        End If
    End Sub

    Private Sub TextBox1_MouseEnter(sender As Object, e As EventArgs) Handles add_to_list.MouseEnter

        If add_to_list.Text = "Insert the url" Then

            add_to_list.Text = String.Empty
            add_to_list.ForeColor = Color.Black
            Label7.ForeColor = Color.Black

        End If

    End Sub

    Private Sub TextBox1_MouseLeave(sender As Object, e As EventArgs) Handles add_to_list.MouseLeave

        If add_to_list.Text <> "Insert the url" AndAlso add_to_list.Text <> String.Empty Then

            add_to_list.ForeColor = Color.Black

        Else

            add_to_list.ForeColor = Color.DarkGray
            Label7.ForeColor = Color.DarkGray

            If String.IsNullOrEmpty(add_to_list.Text) = True Then

                add_to_list.Text = "Insert the url"


            End If

        End If

    End Sub
    Private Async Sub Go_Click(sender As Object, e As EventArgs) Handles Label7.Click


        FlowLayoutPanel1.Refresh()

        Label2.Text = FlowLayoutPanel1.Controls.Count.ToString + " items"

        Dim list_y As New C_UI_.YutubeList_UI



        If add_to_list.Text <> "Insert the url" AndAlso add_to_list.Text <> String.Empty Then

            'the playlist of youtube

            'the url = 32 char                the id = 11 char  the list id                                            number of video
            'https://www.youtube.com/watch?v= wJhm_0rHjAg       &list=RDGMEMYH9CUrFO7CfLJpaD7UR85wVMWi7woZS3w8w&index= 15


            ' the url of video

            'the url = 32 char                the id = 11 char
            'https://www.youtube.com/watch?v= -Zx3CX0KM-E
            'https://www.youtube.com/watch?v=ptx7UlK9yWg

            ' the url of youtube music video

            'https://music.youtube.com/watch?v=2HF-4O9N5sw&feature=share

            st = add_to_list.Text.Replace("https://music.youtube.com", "https://www.youtube.com")


            s = st.Substring(32, 11)

            list_y.Tag = nu.ToString()
            list_y.the_number = "#"



            'add the video

            FlowLayoutPanel1.Controls.Add(list_y)

            Await Task.Delay(100)

            AddHandler list_y.pic_click, AddressOf Pic_c
            AddHandler list_y.del_click, AddressOf del_c
            'AddHandler list_y.openLink_click, AddressOf open_c




        End If

        FlowLayoutPanel1.Refresh()

        Label2.Text = FlowLayoutPanel1.Controls.Count.ToString + " items"

        'save the url in txt file in desktop (file name playList)

        Dim w1 As New IO.StreamWriter("C:\Users\" + System.IO.Path.GetFileName(s_) + "\Desktop\playList\url" + FlowLayoutPanel1.Controls.Count.ToString + ".txt", True, Encoding.UTF8)
        w1.Write("https://www.youtube.com/watch?v=" + s)
        w1.Close()


        add_to_list.Text = String.Empty
        add_to_list.ForeColor = Color.DarkGray
        Label7.ForeColor = Color.DarkGray

        If String.IsNullOrEmpty(add_to_list.Text) = True Then

            add_to_list.Text = "Insert the url"


        End If

        GunaWinCircleProgressIndicator1.Visible = True
        GunaWinCircleProgressIndicator1.ProgressColor = Color.Green

        Timer2.Start()


    End Sub

    Private Sub Pic_c(sender As Object, e As EventArgs)

        Shell("cmd.exe /c start " + DirectCast(sender, C_UI_.YutubeList_UI).Name, AppWinStyle.Hide)


    End Sub



    Private Sub Url__Click(sender As Object, e As EventArgs) Handles Label8.Click, TableLayoutPanel2.Click, Label10.Click

        Shell("cmd.exe /c start https://www.youtube.com/", AppWinStyle.Hide)

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click


        If Me.WindowState = FormWindowState.Normal Then

            Me.WindowState = FormWindowState.Maximized
            Label5.Text = Char.ConvertFromUtf32("&HE923")

        Else

            Me.WindowState = FormWindowState.Normal
            Me.Size = New Size(977, 625)
            Label5.Text = Char.ConvertFromUtf32("&HE922")

        End If





    End Sub
    Dim itemcode As Match
    Dim st As String
    Private Async Sub add_to_list_KeyDown(sender As Object, e As KeyEventArgs) Handles add_to_list.KeyDown

        If e.KeyCode = Keys.Enter Then

            e.SuppressKeyPress = True

            FlowLayoutPanel1.Refresh()

            Label2.Text = FlowLayoutPanel1.Controls.Count.ToString + " items"

            Dim list_y As New C_UI_.YutubeList_UI

            If add_to_list.Text <> "Insert the url" AndAlso add_to_list.Text <> String.Empty Then

                'the playlist of youtube

                'the url = 32 char                the id = 11 char  the list id                                            number of video
                'https://www.youtube.com/watch?v= wJhm_0rHjAg       &list=RDGMEMYH9CUrFO7CfLJpaD7UR85wVMWi7woZS3w8w&index= 15

                ' the url of youtube video

                'the url = 32 char                the id = 11 char
                'https://www.youtube.com/watch?v= -Zx3CX0KM-E
                'https://www.youtube.com/watch?v=ptx7UlK9yWg


                ' the url of youtube music video

                'https://music.youtube.com/watch?v=2HF-4O9N5sw&feature=share

                st = add_to_list.Text.Replace("https://music.youtube.com", "https://www.youtube.com")


                s = st.Substring(32, 11)

                list_y.Tag = nu.ToString()
                list_y.the_number = "#"

                'add the video

                FlowLayoutPanel1.Controls.Add(list_y)

                Await Task.Delay(100)

                AddHandler list_y.pic_click, AddressOf Pic_c
                AddHandler list_y.del_click, AddressOf del_c
                'AddHandler list_y.openLink_click, AddressOf open_c



            End If

            FlowLayoutPanel1.Refresh()

            Label2.Text = FlowLayoutPanel1.Controls.Count.ToString + " items"

            'save the url in txt file in desktop (file name playList)

            Dim w1 As New IO.StreamWriter("C:\Users\" + System.IO.Path.GetFileName(s_) + "\Desktop\playList\url" + FlowLayoutPanel1.Controls.Count.ToString + ".txt", True, Encoding.UTF8)
            w1.Write("https://www.youtube.com/watch?v=" + s)
            w1.Close()

            add_to_list.Text = String.Empty
            add_to_list.ForeColor = Color.DarkGray
            Label7.ForeColor = Color.DarkGray

            If String.IsNullOrEmpty(add_to_list.Text) = True Then

                add_to_list.Text = "Insert the url"

            End If

            GunaWinCircleProgressIndicator1.Visible = True
            GunaWinCircleProgressIndicator1.ProgressColor = Color.Green

            Timer2.Start()


        End If
    End Sub


    'function to rename the txt file

    Private Async Sub renameFiles()

        Dim sourcePath As String = "C:\Users\" + System.IO.Path.GetFileName(s_) + "\Desktop\playList"
        Dim searchPattern As String = "*.txt"

        Dim curDir As New DirectoryInfo(sourcePath)

        Dim i As Integer = 1

        For Each t As FileInfo In curDir.GetFiles(searchPattern).OrderBy(Function(num) num.CreationTime)

            File.Move(t.FullName, Path.Combine(t.Directory.FullName, "url" & i & ".txt"))
            i += 1

            Await Task.Delay(100)

        Next

    End Sub

    Private Sub open_c(sender As Object, e As EventArgs)


        openVideo._yUrl = DirectCast(sender, C_UI_.YutubeList_UI).the_id_tag.ToString()

        Dim ov As New openVideo

        ov.Show()

        'MessageBox.Show((DirectCast(sender, C_UI_.YutubeList_UI).the_id_tag).ToString())

    End Sub

    Public Shared list_yd As New C_UI_.downlodVideo

    Private Async Sub download_c(sender As Object, e As EventArgs)


        Dim dv As New download_video()

        dv.Show()


        dv.Location = Me.Location

        dv.Size = Me.Size

        If Me.WindowState = FormWindowState.Maximized Then

            dv.WindowState = FormWindowState.Maximized
            dv.Label5.Text = Char.ConvertFromUtf32("&HE923")

        Else

            dv.WindowState = FormWindowState.Normal
            dv.Label5.Text = Char.ConvertFromUtf32("&HE922")


        End If

        dv.BackColor = Me.BackColor
        dv.Panel2.BackColor = Panel2.BackColor
        dv.Circular_PictureBox1.BackColor = Circular_PictureBox1.BackColor
        list_yd.the_back_color_name = Color.FromArgb(28, 28, 28)
        list_yd.the_back_color_url = Color.FromArgb(28, 28, 28)


        dv.Label3.ForeColor = Label3.ForeColor
        dv.Label5.ForeColor = Label5.ForeColor
        dv.Label4.ForeColor = Label4.ForeColor
        ' dv.Label6.ForeColor = Label6.ForeColor


        dv.GunaResizeControl1.ForeColor = GunaResizeControl1.ForeColor
        dv.GunaResizeControl1.BackColor = GunaResizeControl1.BackColor



        dv.FlowLayoutPanel1.Controls.Clear()

        list_yd.the_number = "#" + DirectCast(sender, C_UI_.YutubeList_UI).Tag


        s = DirectCast(sender, C_UI_.YutubeList_UI).Name.Substring(DirectCast(sender, C_UI_.YutubeList_UI).Name.LastIndexOf("=") + 1)


        list_yd.Size = dv.FlowLayoutPanel1.Size

        Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create(DirectCast(sender, C_UI_.YutubeList_UI).Name)
        Dim response As System.Net.HttpWebResponse = request.GetResponse

        Dim sr As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream())

        Dim sourcecode As String = sr.ReadToEnd


        'get image of video

        list_yd.the_imageLocation = "https://i.ytimg.com/vi/" + s + "/maxresdefault.jpg"
        list_yd.the_imageLocation = "https://i.ytimg.com/vi/" + s + "/hqdefault.jpg"



        list_yd.the_image_sizeMode = PictureBoxSizeMode.StretchImage

        'get title

        Dim t As New System.Text.RegularExpressions.Regex("<meta name=""title"" content="".*"">")
        Dim matches_t As MatchCollection = t.Matches(sourcecode)

        For Each itemcode As Match In matches_t

            list_yd.the_name = WebUtility.HtmlDecode(itemcode.Value.Split("""").GetValue(3))


        Next

        'get url

        list_yd.Name = DirectCast(sender, C_UI_.YutubeList_UI).Name
        list_yd.the_url = DirectCast(sender, C_UI_.YutubeList_UI).Name
        dv.the_link_.Text = DirectCast(sender, C_UI_.YutubeList_UI).Name
        dv.the_link_id = s

        'get publish date





        Dim r As New Regex("<meta itemprop=""datePublished"" content="".*"">")
        Dim matches As MatchCollection = r.Matches(sourcecode)

        For Each itemcode As Match In matches

            list_yd.the_date = "publish on:" + itemcode.Value.Split("""").GetValue(3)


        Next



        'get genre

        Dim g As New Regex("<meta itemprop=""genre"" content="".*"">")
        Dim matches_g As MatchCollection = g.Matches(sourcecode)

        For Each itemcode_g As Match In matches_g

            list_yd.the_genre = "genre:" + itemcode_g.Value.Split("""").GetValue(3)


        Next



        'get channel name


        Dim c As New Regex("<link itemprop=""name"" content="".*"">")
        Dim matches_c As MatchCollection = c.Matches(sourcecode)

        For Each itemcode_t As Match In matches_c

            list_yd.the_channel = "channel:" + itemcode_t.Value.Split("""").GetValue(3)


        Next


        'get id

        list_yd.the_id = "id:" + s


        'add the video
        dv.FlowLayoutPanel1.Controls.Add(list_yd)

        Await Task.Delay(100)


    End Sub

    Private Sub del_c(sender As Object, e As EventArgs)

        Dim w1 As New IO.StreamWriter("C:\Users\" + System.IO.Path.GetFileName(s_) + "\Desktop\playList\url" + DirectCast(sender, C_UI_.YutubeList_UI).Tag + ".txt", True, Encoding.UTF8)
        w1.Write("(delete)")
        w1.Close()

        System.IO.File.Delete("C:\Users\" + System.IO.Path.GetFileName(s_) + "\Desktop\playList\url" + DirectCast(sender, C_UI_.YutubeList_UI).Tag + ".txt")


        GunaWinCircleProgressIndicator1.Visible = True
        GunaWinCircleProgressIndicator1.ProgressColor = Color.Red

        Timer2.Start()


    End Sub

    Private Sub GunaSwitch1_CheckedChanged(sender As Object, e As EventArgs)

        Timer2.Start()

    End Sub

    Private Sub Label8_MouseEnter(sender As Object, e As EventArgs) Handles TableLayoutPanel2.MouseEnter, Label8.MouseEnter, Label10.MouseEnter
        Label8.ForeColor = Color.LightGray
        Label10.ForeColor = Color.LightGray
    End Sub

    Private Sub Label11_MouseEnter(sender As Object, e As EventArgs) Handles Label11.MouseEnter, Label13.MouseEnter, TableLayoutPanel3.MouseEnter
        Label11.ForeColor = Color.LightGray
        Label13.ForeColor = Color.LightGray
    End Sub

    Private Sub Panel2_MouseEnter(sender As Object, e As EventArgs) Handles Panel2.MouseEnter
        Label8.ForeColor = Color.White
        Label10.ForeColor = Color.White
        Label11.ForeColor = Color.White
        Label13.ForeColor = Color.White
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles TableLayoutPanel3.Click, Label13.Click, Label11.Click
        Dim listD As New download_list

        listD.Show()

        listD.BackColor = Panel2.BackColor
        listD.Label3.ForeColor = Label3.ForeColor
        listD.Label11.ForeColor = Label3.ForeColor


    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click
        Dim offl As New offlineList

        offl.Show()

        offl.Location = Me.Location

        offl.Size = Me.Size

        If Me.WindowState = FormWindowState.Maximized Then

            offl.WindowState = FormWindowState.Maximized
            offl.Label5.Text = Char.ConvertFromUtf32("&HE923")

        Else

            offl.WindowState = FormWindowState.Normal
            offl.Label5.Text = Char.ConvertFromUtf32("&HE922")


        End If

        offl.BackColor = Me.BackColor
        offl.Panel2.BackColor = Panel2.BackColor
        offl.Circular_PictureBox1.BackColor = Circular_PictureBox1.BackColor

        offl.Label3.ForeColor = Label3.ForeColor
        offl.Label5.ForeColor = Label5.ForeColor
        offl.Label4.ForeColor = Label4.ForeColor
        ' offl.Label6.ForeColor = Label6.ForeColor
        offl.Label12.ForeColor = Label12.ForeColor
        offl.Label14.ForeColor = Label14.ForeColor


        offl.GunaResizeControl1.ForeColor = GunaResizeControl1.ForeColor
        offl.GunaResizeControl1.BackColor = GunaResizeControl1.BackColor

        Me.Close()

    End Sub

    Private Sub timer1_Tick_1(sender As Object, e As EventArgs) Handles timer1.Tick
        FlowLayoutPanel1.VerticalScroll.Value = gunaVScrollBar1.Value

    End Sub

    Private Sub FlowLayoutPanel1_MouseEnter(sender As Object, e As EventArgs) Handles FlowLayoutPanel1.MouseEnter
        gunaVScrollBar1.Maximum = FlowLayoutPanel1.VerticalScroll.Maximum
    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click

        GunaWinCircleProgressIndicator1.Visible = True
        GunaWinCircleProgressIndicator1.ProgressColor = Color.DodgerBlue

        Timer2.Start()
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

    Private Sub Panel2_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel2.MouseDown
        a_h.Start()
    End Sub

    Private Sub Panel2_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel2.MouseUp
        timer4.Start()
    End Sub

    Dim n As Integer = 0
    Dim the_link_id As String

    Private Async Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

        Try

            n += 1

            If n = 8 Then

                wifi_ = New Wifi()

                'Label6.Text = SystemInformation.UserName

                'create & copy files 

                If My.Computer.FileSystem.DirectoryExists("C:\youtube-dl") = False Then

                    ' CopyDirectory("C:\Users\" + System.IO.Path.GetFileName(s_) + "\Desktop\Myplaylist\Myplaylist\bin\x86\Release\youtube-dl", "C:\youtube-dl")

                    CopyDirectory("C:\Users\" + System.IO.Path.GetFileName(s_) + "\Desktop\NEAR_VOS_TOOLS\v_assistant\bin\x64\Release\Youtube_Horn\youtube-dl", "C:\youtube-dl")

                End If

                If My.Computer.FileSystem.DirectoryExists("C:\Users\" + System.IO.Path.GetFileName(s_) + "\Desktop\playList") = False Then

                    My.Computer.FileSystem.CreateDirectory("C:\Users\" + System.IO.Path.GetFileName(s_) + "\Desktop\playList")

                End If

                If My.Computer.FileSystem.DirectoryExists("C:\Users\" + System.IO.Path.GetFileName(s_) + "\Desktop\My_list") = False Then

                    My.Computer.FileSystem.CreateDirectory("C:\Users\" + System.IO.Path.GetFileName(s_) + "\Desktop\My_list")

                End If

                If My.Computer.FileSystem.DirectoryExists("C:\Users\" + System.IO.Path.GetFileName(s_) + "\Desktop\My_offlineVideo_list") = False Then

                    My.Computer.FileSystem.CreateDirectory("C:\Users\" + System.IO.Path.GetFileName(s_) + "\Desktop\My_offlineVideo_list")

                End If
                If My.Computer.FileSystem.DirectoryExists("C:\Users\" + System.IO.Path.GetFileName(s_) + "\Desktop\My_offlineSound_list") = False Then

                    My.Computer.FileSystem.CreateDirectory("C:\Users\" + System.IO.Path.GetFileName(s_) + "\Desktop\My_offlineSound_list")

                End If

                'If My.Computer.FileSystem.DirectoryExists("C:\music_browser\Default\Cache") = False Then


                '    My.Computer.FileSystem.CreateDirectory("C:\music_browser\Default\Cache")

                'End If


            End If

            If n = 10 Then



                'call function to rename text file

                renameFiles()


                'get item number of file

                Dim item_ As ObjectModel.ReadOnlyCollection(Of String)
                item_ = My.Computer.FileSystem.GetFiles("C:\Users\" + System.IO.Path.GetFileName(s_) + "\Desktop\playList")

                FlowLayoutPanel1.Controls.Clear()



                For nu = 1 To item_.Count

                    Dim list_y As New C_UI_.YutubeList_UI

                    Dim r1_ As New IO.StreamReader("C:\Users\" + System.IO.Path.GetFileName(s_) + "\Desktop\playList\url" + nu.ToString + ".txt")
                    If (r1_ IsNot Nothing) Then

                        r1 = r1_.ReadToEnd
                        r1_.Close()

                    End If

                    list_y.Tag = nu.ToString()
                    list_y.the_number = "#" + nu.ToString()

                    If r1.Contains("(delete)") Then

                        list_y.Hide()

                    End If

                    s = r1.Substring(r1.LastIndexOf("=") + 1)


                    Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("https://www.youtube.com/watch?v=" + s)
                    Dim response As System.Net.HttpWebResponse = request.GetResponse


                    Dim sr As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream())

                    Dim sourcecode As String = sr.ReadToEnd


                    'get image of video

                    list_y.the_imageLocation = "https://i.ytimg.com/vi/" + s + "/maxresdefault.jpg"
                    list_y.the_imageLocation = "https://i.ytimg.com/vi/" + s + "/hqdefault.jpg"

                    list_y.the_image_sizeMode = PictureBoxSizeMode.StretchImage

                    'get title

                    Dim t As New System.Text.RegularExpressions.Regex("<meta name=""title"" content="".*"">")
                    Dim matches_t As MatchCollection = t.Matches(sourcecode)

                    For Each itemcode As Match In matches_t

                        list_y.the_name = WebUtility.HtmlDecode(itemcode.Value.Split("""").GetValue(3))

                    Next

                    'get url


                    list_y.Name = "https://www.youtube.com/watch?v=" + s
                    list_y.the_url = "https://www.youtube.com/watch?v=" + s


                    'get publish date

                    Dim r As New System.Text.RegularExpressions.Regex("<meta itemprop=""datePublished"" content="".*"">")
                    Dim matches As MatchCollection = r.Matches(sourcecode)

                    For Each itemcode As Match In matches

                        list_y.the_date = "publish on:" + itemcode.Value.Split("""").GetValue(3)

                    Next



                    'get genre

                    Dim g As New System.Text.RegularExpressions.Regex("<meta itemprop=""genre"" content="".*"">")
                    Dim matches_g As MatchCollection = g.Matches(sourcecode)

                    For Each itemcode_g As Match In matches_g

                        list_y.the_genre = "genre:" + itemcode_g.Value.Split("""").GetValue(3)

                    Next



                    'get channel name


                    Dim c As New System.Text.RegularExpressions.Regex("<link itemprop=""name"" content="".*"">")
                    Dim matches_c As MatchCollection = c.Matches(sourcecode)

                    For Each itemcode_t As Match In matches_c

                        list_y.the_channel = "channel:" + itemcode_t.Value.Split("""").GetValue(3)

                    Next


                    'get id

                    list_y.the_id = "id:" + s
                    list_y.the_id_tag = s


                    'add the video
                    FlowLayoutPanel1.Controls.Add(list_y)

                    Await Task.Delay(1)


                    AddHandler list_y.pic_click, AddressOf Pic_c
                    AddHandler list_y.del_click, AddressOf del_c
                    AddHandler list_y.download_click, AddressOf download_c
                    AddHandler list_y.openLink_click, AddressOf open_c

                    'MessageBox.Show("d")



                    Label2.Text = FlowLayoutPanel1.Controls.Count.ToString() + " items"

                Next


                GunaWinCircleProgressIndicator1.Visible = False

                n = 0

                Timer2.Stop()




            End If

        Catch ex As Exception
        End Try



    End Sub
End Class
