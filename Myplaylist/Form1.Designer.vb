<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class YoutubeHorn
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(YoutubeHorn))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.add_to_list = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GunaElipsePanel3 = New Guna.UI.WinForms.GunaElipsePanel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GunaWinCircleProgressIndicator1 = New Guna.UI.WinForms.GunaWinCircleProgressIndicator()
        Me.GunaElipsePanel2 = New Guna.UI.WinForms.GunaElipsePanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Circular_PictureBox1 = New C_UI_.Circular_PictureBox()
        Me.GunaElipsePanel1 = New Guna.UI.WinForms.GunaElipsePanel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.gunaVScrollBar1 = New Guna.UI.WinForms.GunaVScrollBar()
        Me.GunaResizeControl1 = New Guna.UI.WinForms.GunaResizeControl()
        Me.timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.a_h = New System.Windows.Forms.Timer(Me.components)
        Me.timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.FlowLayoutPanel1 = New NEER_UI.CustomFlowLayoutPanel()
        Me.bunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Panel2.SuspendLayout()
        Me.GunaElipsePanel3.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.GunaElipsePanel2.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.Circular_PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaElipsePanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.GhostWhite
        Me.Label1.Location = New System.Drawing.Point(20, 21)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(250, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Youtube Horn | Online"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe MDL2 Assets", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.LightGray
        Me.Label4.Location = New System.Drawing.Point(1657, 22)
        Me.Label4.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = ""
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe MDL2 Assets", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.LightGray
        Me.Label3.Location = New System.Drawing.Point(1748, 22)
        Me.Label3.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = ""
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe MDL2 Assets", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.LightGray
        Me.Label5.Location = New System.Drawing.Point(1705, 22)
        Me.Label5.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 20)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = ""
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'add_to_list
        '
        Me.add_to_list.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.add_to_list.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.add_to_list.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.add_to_list.ForeColor = System.Drawing.Color.DarkGray
        Me.add_to_list.Location = New System.Drawing.Point(59, 8)
        Me.add_to_list.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.add_to_list.Name = "add_to_list"
        Me.add_to_list.Size = New System.Drawing.Size(589, 30)
        Me.add_to_list.TabIndex = 0
        Me.add_to_list.Text = "Insert the url"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(154, 146)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "0 items"
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.Panel2
        Me.BunifuDragControl1.Vertical = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.GunaElipsePanel3)
        Me.Panel2.Controls.Add(Me.GunaWinCircleProgressIndicator1)
        Me.Panel2.Controls.Add(Me.GunaElipsePanel2)
        Me.Panel2.Controls.Add(Me.Circular_PictureBox1)
        Me.Panel2.Controls.Add(Me.GunaElipsePanel1)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(7)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1794, 277)
        Me.Panel2.TabIndex = 3
        '
        'Label15
        '
        Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe MDL2 Assets", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.LightGray
        Me.Label15.Location = New System.Drawing.Point(1481, 21)
        Me.Label15.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(40, 28)
        Me.Label15.TabIndex = 16
        Me.Label15.Text = ""
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe MDL2 Assets", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.LightGray
        Me.Label14.Location = New System.Drawing.Point(1537, 21)
        Me.Label14.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(40, 28)
        Me.Label14.TabIndex = 15
        Me.Label14.Text = ""
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe MDL2 Assets", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.LightGray
        Me.Label12.Location = New System.Drawing.Point(1593, 21)
        Me.Label12.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(40, 28)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = ""
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GunaElipsePanel3
        '
        Me.GunaElipsePanel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaElipsePanel3.BackColor = System.Drawing.Color.Transparent
        Me.GunaElipsePanel3.BaseColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.GunaElipsePanel3.Controls.Add(Me.TableLayoutPanel3)
        Me.GunaElipsePanel3.Location = New System.Drawing.Point(1531, 210)
        Me.GunaElipsePanel3.Margin = New System.Windows.Forms.Padding(7)
        Me.GunaElipsePanel3.Name = "GunaElipsePanel3"
        Me.GunaElipsePanel3.Size = New System.Drawing.Size(286, 50)
        Me.GunaElipsePanel3.TabIndex = 13
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.4!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.6!))
        Me.TableLayoutPanel3.Controls.Add(Me.Label13, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label11, 1, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel3.Margin = New System.Windows.Forms.Padding(6)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(286, 50)
        Me.TableLayoutPanel3.TabIndex = 12
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(6, 9)
        Me.Label13.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(145, 32)
        Me.Label13.TabIndex = 11
        Me.Label13.Text = "Youtube List"
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe MDL2 Assets", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(199, 6)
        Me.Label11.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(55, 38)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = ""
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GunaWinCircleProgressIndicator1
        '
        Me.GunaWinCircleProgressIndicator1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GunaWinCircleProgressIndicator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GunaWinCircleProgressIndicator1.Location = New System.Drawing.Point(959, 209)
        Me.GunaWinCircleProgressIndicator1.Margin = New System.Windows.Forms.Padding(7)
        Me.GunaWinCircleProgressIndicator1.Name = "GunaWinCircleProgressIndicator1"
        Me.GunaWinCircleProgressIndicator1.ProgressColor = System.Drawing.Color.DodgerBlue
        Me.GunaWinCircleProgressIndicator1.Size = New System.Drawing.Size(53, 53)
        Me.GunaWinCircleProgressIndicator1.TabIndex = 11
        '
        'GunaElipsePanel2
        '
        Me.GunaElipsePanel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaElipsePanel2.BackColor = System.Drawing.Color.Transparent
        Me.GunaElipsePanel2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.GunaElipsePanel2.Controls.Add(Me.TableLayoutPanel2)
        Me.GunaElipsePanel2.Location = New System.Drawing.Point(1531, 146)
        Me.GunaElipsePanel2.Margin = New System.Windows.Forms.Padding(7)
        Me.GunaElipsePanel2.Name = "GunaElipsePanel2"
        Me.GunaElipsePanel2.Size = New System.Drawing.Size(286, 50)
        Me.GunaElipsePanel2.TabIndex = 7
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.4!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.6!))
        Me.TableLayoutPanel2.Controls.Add(Me.Label8, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label10, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(6)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(286, 50)
        Me.TableLayoutPanel2.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe MDL2 Assets", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(201, 7)
        Me.Label8.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 35)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = ""
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(6, 9)
        Me.Label10.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(103, 32)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Youtube"
        '
        'Circular_PictureBox1
        '
        Me.Circular_PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Circular_PictureBox1.Location = New System.Drawing.Point(29, 106)
        Me.Circular_PictureBox1.Margin = New System.Windows.Forms.Padding(7)
        Me.Circular_PictureBox1.Name = "Circular_PictureBox1"
        Me.Circular_PictureBox1.Size = New System.Drawing.Size(105, 105)
        Me.Circular_PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Circular_PictureBox1.TabIndex = 9
        Me.Circular_PictureBox1.TabStop = False
        '
        'GunaElipsePanel1
        '
        Me.GunaElipsePanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaElipsePanel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaElipsePanel1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.GunaElipsePanel1.Controls.Add(Me.Label7)
        Me.GunaElipsePanel1.Controls.Add(Me.add_to_list)
        Me.GunaElipsePanel1.Location = New System.Drawing.Point(623, 147)
        Me.GunaElipsePanel1.Margin = New System.Windows.Forms.Padding(7)
        Me.GunaElipsePanel1.Name = "GunaElipsePanel1"
        Me.GunaElipsePanel1.Size = New System.Drawing.Size(671, 48)
        Me.GunaElipsePanel1.TabIndex = 6
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
        'gunaVScrollBar1
        '
        Me.gunaVScrollBar1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gunaVScrollBar1.BackColor = System.Drawing.Color.Transparent
        Me.gunaVScrollBar1.LargeChange = 10
        Me.gunaVScrollBar1.Location = New System.Drawing.Point(1744, 277)
        Me.gunaVScrollBar1.Maximum = 1
        Me.gunaVScrollBar1.Name = "gunaVScrollBar1"
        Me.gunaVScrollBar1.Radius = 2
        Me.gunaVScrollBar1.ScrollbarSize = 5
        Me.gunaVScrollBar1.ScrollIdleColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.gunaVScrollBar1.Size = New System.Drawing.Size(50, 878)
        Me.gunaVScrollBar1.TabIndex = 69
        Me.gunaVScrollBar1.ThumbColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.gunaVScrollBar1.ThumbHoverColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.gunaVScrollBar1.ThumbPressedColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(241, Byte), Integer))
        '
        'GunaResizeControl1
        '
        Me.GunaResizeControl1.BackColor = System.Drawing.Color.Transparent
        Me.GunaResizeControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GunaResizeControl1.ForeColor = System.Drawing.Color.White
        Me.GunaResizeControl1.ForeColorDepth = 255
        Me.GunaResizeControl1.Location = New System.Drawing.Point(0, 1155)
        Me.GunaResizeControl1.Margin = New System.Windows.Forms.Padding(6)
        Me.GunaResizeControl1.Name = "GunaResizeControl1"
        Me.GunaResizeControl1.Size = New System.Drawing.Size(1794, 45)
        Me.GunaResizeControl1.TabIndex = 5
        Me.GunaResizeControl1.TargetControl = Me
        '
        'timer1
        '
        Me.timer1.Enabled = True
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
        'Timer2
        '
        Me.Timer2.Enabled = True
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel1.AutoScroll = True
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 277)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(1794, 870)
        Me.FlowLayoutPanel1.TabIndex = 70
        '
        'bunifuElipse1
        '
        Me.bunifuElipse1.ElipseRadius = 25
        Me.bunifuElipse1.TargetControl = Me
        '
        'YoutubeHorn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(168.0!, 168.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1794, 1200)
        Me.Controls.Add(Me.GunaResizeControl1)
        Me.Controls.Add(Me.gunaVScrollBar1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.MinimumSize = New System.Drawing.Size(1709, 1093)
        Me.Name = "YoutubeHorn"
        Me.Opacity = 0R
        Me.Text = "myplaylist"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GunaElipsePanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.GunaElipsePanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.Circular_PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaElipsePanel1.ResumeLayout(False)
        Me.GunaElipsePanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents add_to_list As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents GunaElipsePanel1 As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Circular_PictureBox1 As C_UI_.Circular_PictureBox
    Friend WithEvents GunaElipsePanel2 As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents Label10 As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents GunaResizeControl1 As Guna.UI.WinForms.GunaResizeControl
    Friend WithEvents GunaWinCircleProgressIndicator1 As Guna.UI.WinForms.GunaWinCircleProgressIndicator
    Public WithEvents Label5 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents GunaElipsePanel3 As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Private WithEvents gunaVScrollBar1 As Guna.UI.WinForms.GunaVScrollBar
    Private WithEvents timer1 As Timer
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Private WithEvents a_h As Timer
    Private WithEvents timer4 As Timer
    Private WithEvents Timer2 As Timer
    Friend WithEvents FlowLayoutPanel1 As NEER_UI.CustomFlowLayoutPanel
    Private WithEvents bunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    ' Friend WithEvents Circular_PictureBox1 As Myplaylist.Circular_PictureBox
End Class
