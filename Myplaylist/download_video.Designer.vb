<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class download_video
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(download_video))
        Me.GunaResizeControl1 = New Guna.UI.WinForms.GunaResizeControl()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GunaElipsePanel2 = New Guna.UI.WinForms.GunaElipsePanel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cs_ = New System.Windows.Forms.TextBox()
        Me.GunaElipsePanel1 = New Guna.UI.WinForms.GunaElipsePanel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cv_ = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Circular_PictureBox1 = New C_UI_.Circular_PictureBox()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.show_ = New System.Windows.Forms.Timer(Me.components)
        Me.time_ = New System.Windows.Forms.Timer(Me.components)
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.a_h = New System.Windows.Forms.Timer(Me.components)
        Me.Panel2.SuspendLayout()
        Me.GunaElipsePanel2.SuspendLayout()
        Me.GunaElipsePanel1.SuspendLayout()
        CType(Me.Circular_PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaResizeControl1
        '
        Me.GunaResizeControl1.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.GunaResizeControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GunaResizeControl1.ForeColor = System.Drawing.Color.White
        Me.GunaResizeControl1.ForeColorDepth = 255
        Me.GunaResizeControl1.Location = New System.Drawing.Point(0, 1080)
        Me.GunaResizeControl1.Margin = New System.Windows.Forms.Padding(6)
        Me.GunaResizeControl1.Name = "GunaResizeControl1"
        Me.GunaResizeControl1.Size = New System.Drawing.Size(1709, 13)
        Me.GunaResizeControl1.TabIndex = 5
        Me.GunaResizeControl1.TargetControl = Me
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 211)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(1709, 861)
        Me.FlowLayoutPanel1.TabIndex = 1
        Me.FlowLayoutPanel1.Visible = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.Panel2.Controls.Add(Me.GunaElipsePanel2)
        Me.Panel2.Controls.Add(Me.GunaElipsePanel1)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Circular_PictureBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(7)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1709, 216)
        Me.Panel2.TabIndex = 3
        Me.Panel2.Visible = False
        '
        'GunaElipsePanel2
        '
        Me.GunaElipsePanel2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GunaElipsePanel2.BackColor = System.Drawing.Color.Transparent
        Me.GunaElipsePanel2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.GunaElipsePanel2.Controls.Add(Me.Label8)
        Me.GunaElipsePanel2.Controls.Add(Me.cs_)
        Me.GunaElipsePanel2.Location = New System.Drawing.Point(903, 97)
        Me.GunaElipsePanel2.Margin = New System.Windows.Forms.Padding(7)
        Me.GunaElipsePanel2.Name = "GunaElipsePanel2"
        Me.GunaElipsePanel2.Size = New System.Drawing.Size(231, 48)
        Me.GunaElipsePanel2.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe MDL2 Assets", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(6, 11)
        Me.Label8.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 28)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = ""
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cs_
        '
        Me.cs_.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.cs_.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.cs_.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.cs_.ForeColor = System.Drawing.Color.Black
        Me.cs_.Location = New System.Drawing.Point(48, 7)
        Me.cs_.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.cs_.Name = "cs_"
        Me.cs_.Size = New System.Drawing.Size(179, 30)
        Me.cs_.TabIndex = 0
        Me.cs_.Text = "mp3"
        '
        'GunaElipsePanel1
        '
        Me.GunaElipsePanel1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GunaElipsePanel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaElipsePanel1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.GunaElipsePanel1.Controls.Add(Me.Label7)
        Me.GunaElipsePanel1.Controls.Add(Me.cv_)
        Me.GunaElipsePanel1.Location = New System.Drawing.Point(659, 98)
        Me.GunaElipsePanel1.Margin = New System.Windows.Forms.Padding(7)
        Me.GunaElipsePanel1.Name = "GunaElipsePanel1"
        Me.GunaElipsePanel1.Size = New System.Drawing.Size(231, 48)
        Me.GunaElipsePanel1.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe MDL2 Assets", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(6, 11)
        Me.Label7.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 28)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = ""
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cv_
        '
        Me.cv_.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.cv_.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.cv_.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.cv_.ForeColor = System.Drawing.Color.Black
        Me.cv_.Location = New System.Drawing.Point(48, 7)
        Me.cv_.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.cv_.Name = "cv_"
        Me.cv_.Size = New System.Drawing.Size(179, 30)
        Me.cv_.TabIndex = 0
        Me.cv_.Text = "mp4"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe MDL2 Assets", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.LightGray
        Me.Label4.Location = New System.Drawing.Point(1592, 20)
        Me.Label4.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 20)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = ""
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe MDL2 Assets", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.LightGray
        Me.Label5.Location = New System.Drawing.Point(1634, 17)
        Me.Label5.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 20)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = ""
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe MDL2 Assets", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.LightGray
        Me.Label3.Location = New System.Drawing.Point(1676, 17)
        Me.Label3.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = ""
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Circular_PictureBox1
        '
        Me.Circular_PictureBox1.Image = Global.Myplaylist.My.Resources.Resources.admin_d2
        Me.Circular_PictureBox1.Location = New System.Drawing.Point(27, 43)
        Me.Circular_PictureBox1.Margin = New System.Windows.Forms.Padding(7)
        Me.Circular_PictureBox1.Name = "Circular_PictureBox1"
        Me.Circular_PictureBox1.Size = New System.Drawing.Size(105, 105)
        Me.Circular_PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Circular_PictureBox1.TabIndex = 9
        Me.Circular_PictureBox1.TabStop = False
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.Panel2
        Me.BunifuDragControl1.Vertical = True
        '
        'show_
        '
        '
        'time_
        '
        Me.time_.Enabled = True
        Me.time_.Interval = 1000
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 2
        Me.BunifuElipse1.TargetControl = Me
        '
        'timer4
        '
        Me.timer4.Enabled = True
        Me.timer4.Interval = 29
        '
        'a_h
        '
        Me.a_h.Interval = 29
        '
        'download_video
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(168.0!, 168.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1709, 1093)
        Me.Controls.Add(Me.GunaResizeControl1)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.Panel2)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.MinimumSize = New System.Drawing.Size(1709, 1093)
        Me.Name = "download_video"
        Me.Opacity = 0R
        Me.Text = "downlod_video"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GunaElipsePanel2.ResumeLayout(False)
        Me.GunaElipsePanel2.PerformLayout()
        Me.GunaElipsePanel1.ResumeLayout(False)
        Me.GunaElipsePanel1.PerformLayout()
        CType(Me.Circular_PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GunaResizeControl1 As Guna.UI.WinForms.GunaResizeControl
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents Circular_PictureBox1 As C_UI_.Circular_PictureBox
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents Label4 As Label
    Public WithEvents Label5 As Label
    Friend WithEvents show_ As Timer
    Friend WithEvents GunaElipsePanel1 As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents Label7 As Label
    Friend WithEvents cv_ As TextBox
    Friend WithEvents GunaElipsePanel2 As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents Label8 As Label
    Friend WithEvents cs_ As TextBox
    Public WithEvents Panel2 As Panel
    Friend WithEvents time_ As Timer
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Private WithEvents timer4 As Timer
    Private WithEvents a_h As Timer
End Class
