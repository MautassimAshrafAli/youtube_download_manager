<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class download_list
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(download_list))
        Me.GunaLinePanel1 = New Guna.UI.WinForms.GunaLinePanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GunaElipsePanel4 = New Guna.UI.WinForms.GunaElipsePanel()
        Me.c_sound = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GunaElipsePanel5 = New Guna.UI.WinForms.GunaElipsePanel()
        Me.c_video = New System.Windows.Forms.TextBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Convert_to_sound = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Convert_to_video = New System.Windows.Forms.Label()
        Me.GunaElipsePanel3 = New Guna.UI.WinForms.GunaElipsePanel()
        Me.end_r = New System.Windows.Forms.TextBox()
        Me.GunaElipsePanel2 = New Guna.UI.WinForms.GunaElipsePanel()
        Me.start_r = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GunaElipsePanel1 = New Guna.UI.WinForms.GunaElipsePanel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.url_ = New System.Windows.Forms.TextBox()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.a_h = New System.Windows.Forms.Timer(Me.components)
        Me.timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.GunaLinePanel1.SuspendLayout()
        Me.GunaElipsePanel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GunaElipsePanel5.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.GunaElipsePanel3.SuspendLayout()
        Me.GunaElipsePanel2.SuspendLayout()
        Me.GunaElipsePanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GunaLinePanel1
        '
        Me.GunaLinePanel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaLinePanel1.Controls.Add(Me.Label2)
        Me.GunaLinePanel1.Controls.Add(Me.GunaElipsePanel4)
        Me.GunaLinePanel1.Controls.Add(Me.Panel3)
        Me.GunaLinePanel1.Controls.Add(Me.GunaElipsePanel5)
        Me.GunaLinePanel1.Controls.Add(Me.Panel5)
        Me.GunaLinePanel1.Controls.Add(Me.Panel4)
        Me.GunaLinePanel1.Controls.Add(Me.GunaElipsePanel3)
        Me.GunaLinePanel1.Controls.Add(Me.GunaElipsePanel2)
        Me.GunaLinePanel1.Controls.Add(Me.Label3)
        Me.GunaLinePanel1.Controls.Add(Me.Label11)
        Me.GunaLinePanel1.Controls.Add(Me.GunaElipsePanel1)
        Me.GunaLinePanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GunaLinePanel1.LineBottom = 3
        Me.GunaLinePanel1.LineColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.GunaLinePanel1.LineLeft = 3
        Me.GunaLinePanel1.LineRight = 3
        Me.GunaLinePanel1.LineStyle = System.Windows.Forms.BorderStyle.None
        Me.GunaLinePanel1.LineTop = 3
        Me.GunaLinePanel1.Location = New System.Drawing.Point(0, 0)
        Me.GunaLinePanel1.Margin = New System.Windows.Forms.Padding(6)
        Me.GunaLinePanel1.Name = "GunaLinePanel1"
        Me.GunaLinePanel1.Size = New System.Drawing.Size(1050, 602)
        Me.GunaLinePanel1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(335, 92)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(386, 30)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "*Error one or more of the fields is empty"
        Me.Label2.Visible = False
        '
        'GunaElipsePanel4
        '
        Me.GunaElipsePanel4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GunaElipsePanel4.BackColor = System.Drawing.Color.Transparent
        Me.GunaElipsePanel4.BaseColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.GunaElipsePanel4.Controls.Add(Me.c_sound)
        Me.GunaElipsePanel4.Location = New System.Drawing.Point(577, 370)
        Me.GunaElipsePanel4.Margin = New System.Windows.Forms.Padding(7)
        Me.GunaElipsePanel4.Name = "GunaElipsePanel4"
        Me.GunaElipsePanel4.Size = New System.Drawing.Size(239, 48)
        Me.GunaElipsePanel4.TabIndex = 19
        '
        'c_sound
        '
        Me.c_sound.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.c_sound.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.c_sound.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.c_sound.ForeColor = System.Drawing.Color.Black
        Me.c_sound.Location = New System.Drawing.Point(7, 8)
        Me.c_sound.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.c_sound.Name = "c_sound"
        Me.c_sound.Size = New System.Drawing.Size(225, 30)
        Me.c_sound.TabIndex = 0
        Me.c_sound.Text = "mp3"
        '
        'Panel3
        '
        Me.Panel3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Location = New System.Drawing.Point(151, 484)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(6)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(209, 57)
        Me.Panel3.TabIndex = 20
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(17, 15)
        Me.Label4.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(169, 30)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Open in youtube"
        '
        'GunaElipsePanel5
        '
        Me.GunaElipsePanel5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GunaElipsePanel5.BackColor = System.Drawing.Color.Transparent
        Me.GunaElipsePanel5.BaseColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.GunaElipsePanel5.Controls.Add(Me.c_video)
        Me.GunaElipsePanel5.Location = New System.Drawing.Point(230, 370)
        Me.GunaElipsePanel5.Margin = New System.Windows.Forms.Padding(7)
        Me.GunaElipsePanel5.Name = "GunaElipsePanel5"
        Me.GunaElipsePanel5.Size = New System.Drawing.Size(239, 48)
        Me.GunaElipsePanel5.TabIndex = 18
        '
        'c_video
        '
        Me.c_video.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.c_video.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.c_video.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.c_video.ForeColor = System.Drawing.Color.Black
        Me.c_video.Location = New System.Drawing.Point(7, 8)
        Me.c_video.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.c_video.Name = "c_video"
        Me.c_video.Size = New System.Drawing.Size(225, 30)
        Me.c_video.TabIndex = 0
        Me.c_video.Text = "mp4"
        '
        'Panel5
        '
        Me.Panel5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel5.Controls.Add(Me.Convert_to_sound)
        Me.Panel5.Location = New System.Drawing.Point(658, 484)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(6)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(209, 57)
        Me.Panel5.TabIndex = 19
        '
        'Convert_to_sound
        '
        Me.Convert_to_sound.AutoSize = True
        Me.Convert_to_sound.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Convert_to_sound.ForeColor = System.Drawing.Color.White
        Me.Convert_to_sound.Location = New System.Drawing.Point(20, 15)
        Me.Convert_to_sound.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Convert_to_sound.Name = "Convert_to_sound"
        Me.Convert_to_sound.Size = New System.Drawing.Size(173, 30)
        Me.Convert_to_sound.TabIndex = 2
        Me.Convert_to_sound.Text = "Convert to sound"
        '
        'Panel4
        '
        Me.Panel4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel4.Controls.Add(Me.Convert_to_video)
        Me.Panel4.Location = New System.Drawing.Point(405, 484)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(6)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(209, 57)
        Me.Panel4.TabIndex = 18
        '
        'Convert_to_video
        '
        Me.Convert_to_video.AutoSize = True
        Me.Convert_to_video.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Convert_to_video.ForeColor = System.Drawing.Color.White
        Me.Convert_to_video.Location = New System.Drawing.Point(20, 15)
        Me.Convert_to_video.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Convert_to_video.Name = "Convert_to_video"
        Me.Convert_to_video.Size = New System.Drawing.Size(166, 30)
        Me.Convert_to_video.TabIndex = 1
        Me.Convert_to_video.Text = "Convert to video"
        '
        'GunaElipsePanel3
        '
        Me.GunaElipsePanel3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GunaElipsePanel3.BackColor = System.Drawing.Color.Transparent
        Me.GunaElipsePanel3.BaseColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.GunaElipsePanel3.Controls.Add(Me.end_r)
        Me.GunaElipsePanel3.Location = New System.Drawing.Point(577, 265)
        Me.GunaElipsePanel3.Margin = New System.Windows.Forms.Padding(7)
        Me.GunaElipsePanel3.Name = "GunaElipsePanel3"
        Me.GunaElipsePanel3.Size = New System.Drawing.Size(239, 48)
        Me.GunaElipsePanel3.TabIndex = 17
        '
        'end_r
        '
        Me.end_r.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.end_r.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.end_r.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.end_r.ForeColor = System.Drawing.Color.DarkGray
        Me.end_r.Location = New System.Drawing.Point(7, 8)
        Me.end_r.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.end_r.Name = "end_r"
        Me.end_r.Size = New System.Drawing.Size(225, 30)
        Me.end_r.TabIndex = 0
        Me.end_r.Text = "End"
        '
        'GunaElipsePanel2
        '
        Me.GunaElipsePanel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GunaElipsePanel2.BackColor = System.Drawing.Color.Transparent
        Me.GunaElipsePanel2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.GunaElipsePanel2.Controls.Add(Me.start_r)
        Me.GunaElipsePanel2.Location = New System.Drawing.Point(230, 265)
        Me.GunaElipsePanel2.Margin = New System.Windows.Forms.Padding(7)
        Me.GunaElipsePanel2.Name = "GunaElipsePanel2"
        Me.GunaElipsePanel2.Size = New System.Drawing.Size(239, 48)
        Me.GunaElipsePanel2.TabIndex = 16
        '
        'start_r
        '
        Me.start_r.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.start_r.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.start_r.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.start_r.ForeColor = System.Drawing.Color.DarkGray
        Me.start_r.Location = New System.Drawing.Point(7, 8)
        Me.start_r.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.start_r.Name = "start_r"
        Me.start_r.Size = New System.Drawing.Size(225, 30)
        Me.start_r.TabIndex = 0
        Me.start_r.Text = "Start"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe MDL2 Assets", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.LightGray
        Me.Label3.Location = New System.Drawing.Point(1000, 21)
        Me.Label3.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 20)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = ""
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe MDL2 Assets", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(22, 15)
        Me.Label11.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(55, 38)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = ""
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GunaElipsePanel1
        '
        Me.GunaElipsePanel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GunaElipsePanel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaElipsePanel1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.GunaElipsePanel1.Controls.Add(Me.Label7)
        Me.GunaElipsePanel1.Controls.Add(Me.url_)
        Me.GunaElipsePanel1.Location = New System.Drawing.Point(199, 153)
        Me.GunaElipsePanel1.Margin = New System.Windows.Forms.Padding(7)
        Me.GunaElipsePanel1.Name = "GunaElipsePanel1"
        Me.GunaElipsePanel1.Size = New System.Drawing.Size(671, 48)
        Me.GunaElipsePanel1.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe MDL2 Assets", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DarkGray
        Me.Label7.Location = New System.Drawing.Point(7, 11)
        Me.Label7.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 28)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = ""
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'url_
        '
        Me.url_.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.url_.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.url_.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.url_.ForeColor = System.Drawing.Color.DarkGray
        Me.url_.Location = New System.Drawing.Point(59, 8)
        Me.url_.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.url_.Name = "url_"
        Me.url_.Size = New System.Drawing.Size(589, 30)
        Me.url_.TabIndex = 0
        Me.url_.Text = "Insert the url"
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.GunaLinePanel1
        Me.BunifuDragControl1.Vertical = True
        '
        'a_h
        '
        Me.a_h.Interval = 29
        '
        'timer4
        '
        Me.timer4.Enabled = True
        Me.timer4.Interval = 29
        '
        'download_list
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(168.0!, 168.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1050, 602)
        Me.Controls.Add(Me.GunaLinePanel1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "download_list"
        Me.Opacity = 0R
        Me.Text = "download_list"
        Me.GunaLinePanel1.ResumeLayout(False)
        Me.GunaLinePanel1.PerformLayout()
        Me.GunaElipsePanel4.ResumeLayout(False)
        Me.GunaElipsePanel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.GunaElipsePanel5.ResumeLayout(False)
        Me.GunaElipsePanel5.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.GunaElipsePanel3.ResumeLayout(False)
        Me.GunaElipsePanel3.PerformLayout()
        Me.GunaElipsePanel2.ResumeLayout(False)
        Me.GunaElipsePanel2.PerformLayout()
        Me.GunaElipsePanel1.ResumeLayout(False)
        Me.GunaElipsePanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GunaLinePanel1 As Guna.UI.WinForms.GunaLinePanel
    Friend WithEvents GunaElipsePanel1 As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents Label7 As Label
    Friend WithEvents url_ As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents GunaElipsePanel3 As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents end_r As TextBox
    Friend WithEvents GunaElipsePanel2 As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents start_r As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Convert_to_video As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Convert_to_sound As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents GunaElipsePanel4 As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents c_sound As TextBox
    Friend WithEvents GunaElipsePanel5 As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents c_video As TextBox
    Friend WithEvents Label2 As Label
    Private WithEvents a_h As Timer
    Private WithEvents timer4 As Timer
End Class
