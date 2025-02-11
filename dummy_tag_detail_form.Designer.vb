<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dummy_tag_detail_form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dummy_tag_detail_form))
        Me.tag_show_data = New System.Windows.Forms.TextBox()
        Me.qty_show_data = New System.Windows.Forms.TextBox()
        Me.lot_no_show_data = New System.Windows.Forms.Label()
        Me.plan_date_show_data = New System.Windows.Forms.Label()
        Me.ac_date_show_data = New System.Windows.Forms.Label()
        Me.seq_show_data = New System.Windows.Forms.Label()
        Me.shift_show_data = New System.Windows.Forms.Label()
        Me.line_show_data = New System.Windows.Forms.Label()
        Me.model_show_data = New System.Windows.Forms.Label()
        Me.part_name_show_data = New System.Windows.Forms.Label()
        Me.part_no_show_data = New System.Windows.Forms.Label()
        Me.wi_show_data = New System.Windows.Forms.Label()
        Me.print_BT = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.exit_pagedata = New System.Windows.Forms.PictureBox()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.max_box_ps = New System.Windows.Forms.Label()
        Me.lb_font1 = New System.Windows.Forms.Label()
        Me.lb_font2 = New System.Windows.Forms.Label()
        Me.lb_font3 = New System.Windows.Forms.Label()
        Me.lb_font4 = New System.Windows.Forms.Label()
        Me.lb_font5 = New System.Windows.Forms.Label()
        Me.lb_font6 = New System.Windows.Forms.Label()
        Me.font_part_name = New System.Windows.Forms.Label()
        Me.plandate = New System.Windows.Forms.Label()
        Me.qr_code_1 = New System.Windows.Forms.PictureBox()
        Me.qr_code_2 = New System.Windows.Forms.PictureBox()
        Me.qr_code_3 = New System.Windows.Forms.PictureBox()
        Me.succes = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.exit_pagedata, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.qr_code_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.qr_code_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.qr_code_3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.succes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tag_show_data
        '
        Me.tag_show_data.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tag_show_data.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tag_show_data.Font = New System.Drawing.Font("Bahnschrift Condensed", 16.2!)
        Me.tag_show_data.Location = New System.Drawing.Point(502, 430)
        Me.tag_show_data.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tag_show_data.Multiline = True
        Me.tag_show_data.Name = "tag_show_data"
        Me.tag_show_data.Size = New System.Drawing.Size(130, 27)
        Me.tag_show_data.TabIndex = 82
        Me.tag_show_data.Visible = False
        '
        'qty_show_data
        '
        Me.qty_show_data.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.qty_show_data.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.qty_show_data.Font = New System.Drawing.Font("Bahnschrift Condensed", 16.2!)
        Me.qty_show_data.Location = New System.Drawing.Point(502, 366)
        Me.qty_show_data.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.qty_show_data.Multiline = True
        Me.qty_show_data.Name = "qty_show_data"
        Me.qty_show_data.Size = New System.Drawing.Size(130, 27)
        Me.qty_show_data.TabIndex = 81
        Me.qty_show_data.Visible = False
        '
        'lot_no_show_data
        '
        Me.lot_no_show_data.AutoSize = True
        Me.lot_no_show_data.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.lot_no_show_data.Font = New System.Drawing.Font("Bahnschrift Condensed", 16.8!)
        Me.lot_no_show_data.ForeColor = System.Drawing.Color.White
        Me.lot_no_show_data.Location = New System.Drawing.Point(496, 300)
        Me.lot_no_show_data.Name = "lot_no_show_data"
        Me.lot_no_show_data.Size = New System.Drawing.Size(75, 28)
        Me.lot_no_show_data.TabIndex = 80
        Me.lot_no_show_data.Text = "not data"
        Me.lot_no_show_data.Visible = False
        '
        'plan_date_show_data
        '
        Me.plan_date_show_data.AutoSize = True
        Me.plan_date_show_data.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.plan_date_show_data.Font = New System.Drawing.Font("Bahnschrift Condensed", 16.8!)
        Me.plan_date_show_data.ForeColor = System.Drawing.Color.White
        Me.plan_date_show_data.Location = New System.Drawing.Point(496, 235)
        Me.plan_date_show_data.Name = "plan_date_show_data"
        Me.plan_date_show_data.Size = New System.Drawing.Size(75, 28)
        Me.plan_date_show_data.TabIndex = 79
        Me.plan_date_show_data.Text = "not data"
        Me.plan_date_show_data.Visible = False
        '
        'ac_date_show_data
        '
        Me.ac_date_show_data.AutoSize = True
        Me.ac_date_show_data.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.ac_date_show_data.Font = New System.Drawing.Font("Bahnschrift Condensed", 16.8!)
        Me.ac_date_show_data.ForeColor = System.Drawing.Color.White
        Me.ac_date_show_data.Location = New System.Drawing.Point(496, 170)
        Me.ac_date_show_data.Name = "ac_date_show_data"
        Me.ac_date_show_data.Size = New System.Drawing.Size(75, 28)
        Me.ac_date_show_data.TabIndex = 78
        Me.ac_date_show_data.Text = "not data"
        Me.ac_date_show_data.Visible = False
        '
        'seq_show_data
        '
        Me.seq_show_data.AutoSize = True
        Me.seq_show_data.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.seq_show_data.Font = New System.Drawing.Font("Bahnschrift Condensed", 16.8!)
        Me.seq_show_data.ForeColor = System.Drawing.Color.White
        Me.seq_show_data.Location = New System.Drawing.Point(496, 105)
        Me.seq_show_data.Name = "seq_show_data"
        Me.seq_show_data.Size = New System.Drawing.Size(75, 28)
        Me.seq_show_data.TabIndex = 77
        Me.seq_show_data.Text = "not data"
        Me.seq_show_data.Visible = False
        '
        'shift_show_data
        '
        Me.shift_show_data.AutoSize = True
        Me.shift_show_data.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.shift_show_data.Font = New System.Drawing.Font("Bahnschrift Condensed", 16.8!)
        Me.shift_show_data.ForeColor = System.Drawing.Color.White
        Me.shift_show_data.Location = New System.Drawing.Point(150, 429)
        Me.shift_show_data.Name = "shift_show_data"
        Me.shift_show_data.Size = New System.Drawing.Size(75, 28)
        Me.shift_show_data.TabIndex = 76
        Me.shift_show_data.Text = "not data"
        Me.shift_show_data.Visible = False
        '
        'line_show_data
        '
        Me.line_show_data.AutoSize = True
        Me.line_show_data.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.line_show_data.Font = New System.Drawing.Font("Bahnschrift Condensed", 16.8!)
        Me.line_show_data.ForeColor = System.Drawing.Color.White
        Me.line_show_data.Location = New System.Drawing.Point(150, 365)
        Me.line_show_data.Name = "line_show_data"
        Me.line_show_data.Size = New System.Drawing.Size(75, 28)
        Me.line_show_data.TabIndex = 75
        Me.line_show_data.Text = "not data"
        Me.line_show_data.Visible = False
        '
        'model_show_data
        '
        Me.model_show_data.AutoSize = True
        Me.model_show_data.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.model_show_data.Font = New System.Drawing.Font("Bahnschrift Condensed", 16.8!)
        Me.model_show_data.ForeColor = System.Drawing.Color.White
        Me.model_show_data.Location = New System.Drawing.Point(150, 300)
        Me.model_show_data.Name = "model_show_data"
        Me.model_show_data.Size = New System.Drawing.Size(75, 28)
        Me.model_show_data.TabIndex = 74
        Me.model_show_data.Text = "not data"
        Me.model_show_data.Visible = False
        '
        'part_name_show_data
        '
        Me.part_name_show_data.AutoSize = True
        Me.part_name_show_data.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.part_name_show_data.Font = New System.Drawing.Font("Bahnschrift Condensed", 16.8!)
        Me.part_name_show_data.ForeColor = System.Drawing.Color.White
        Me.part_name_show_data.Location = New System.Drawing.Point(150, 235)
        Me.part_name_show_data.Name = "part_name_show_data"
        Me.part_name_show_data.Size = New System.Drawing.Size(75, 28)
        Me.part_name_show_data.TabIndex = 73
        Me.part_name_show_data.Text = "not data"
        Me.part_name_show_data.Visible = False
        '
        'part_no_show_data
        '
        Me.part_no_show_data.AutoSize = True
        Me.part_no_show_data.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.part_no_show_data.Font = New System.Drawing.Font("Bahnschrift Condensed", 16.8!)
        Me.part_no_show_data.ForeColor = System.Drawing.Color.White
        Me.part_no_show_data.Location = New System.Drawing.Point(150, 170)
        Me.part_no_show_data.Name = "part_no_show_data"
        Me.part_no_show_data.Size = New System.Drawing.Size(75, 28)
        Me.part_no_show_data.TabIndex = 72
        Me.part_no_show_data.Text = "not data"
        Me.part_no_show_data.Visible = False
        '
        'wi_show_data
        '
        Me.wi_show_data.AutoSize = True
        Me.wi_show_data.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.wi_show_data.Font = New System.Drawing.Font("Bahnschrift Condensed", 16.8!)
        Me.wi_show_data.ForeColor = System.Drawing.Color.White
        Me.wi_show_data.Location = New System.Drawing.Point(150, 105)
        Me.wi_show_data.Name = "wi_show_data"
        Me.wi_show_data.Size = New System.Drawing.Size(75, 28)
        Me.wi_show_data.TabIndex = 71
        Me.wi_show_data.Text = "not data"
        Me.wi_show_data.Visible = False
        '
        'print_BT
        '
        Me.print_BT.BackgroundImage = CType(resources.GetObject("print_BT.BackgroundImage"), System.Drawing.Image)
        Me.print_BT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.print_BT.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.print_BT.Location = New System.Drawing.Point(323, 465)
        Me.print_BT.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.print_BT.Name = "print_BT"
        Me.print_BT.Size = New System.Drawing.Size(134, 43)
        Me.print_BT.TabIndex = 83
        Me.print_BT.UseVisualStyleBackColor = True
        Me.print_BT.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(76, 50)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(658, 501)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 70
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Visible = False
        '
        'exit_pagedata
        '
        Me.exit_pagedata.Image = CType(resources.GetObject("exit_pagedata.Image"), System.Drawing.Image)
        Me.exit_pagedata.Location = New System.Drawing.Point(644, 64)
        Me.exit_pagedata.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.exit_pagedata.Name = "exit_pagedata"
        Me.exit_pagedata.Size = New System.Drawing.Size(62, 47)
        Me.exit_pagedata.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.exit_pagedata.TabIndex = 84
        Me.exit_pagedata.TabStop = False
        Me.exit_pagedata.Visible = False
        '
        'PrintDocument1
        '
        '
        'max_box_ps
        '
        Me.max_box_ps.AutoSize = True
        Me.max_box_ps.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.max_box_ps.Font = New System.Drawing.Font("Bahnschrift Condensed", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.max_box_ps.ForeColor = System.Drawing.Color.White
        Me.max_box_ps.Location = New System.Drawing.Point(582, 410)
        Me.max_box_ps.Name = "max_box_ps"
        Me.max_box_ps.Size = New System.Drawing.Size(39, 18)
        Me.max_box_ps.TabIndex = 85
        Me.max_box_ps.Text = "Label1"
        Me.max_box_ps.Visible = False
        '
        'lb_font1
        '
        Me.lb_font1.AutoSize = True
        Me.lb_font1.Font = New System.Drawing.Font("Arial", 8.5!)
        Me.lb_font1.Location = New System.Drawing.Point(37, 183)
        Me.lb_font1.Name = "lb_font1"
        Me.lb_font1.Size = New System.Drawing.Size(0, 15)
        Me.lb_font1.TabIndex = 86
        '
        'lb_font2
        '
        Me.lb_font2.AutoSize = True
        Me.lb_font2.Font = New System.Drawing.Font("Consolas", 21.5!, System.Drawing.FontStyle.Bold)
        Me.lb_font2.Location = New System.Drawing.Point(34, 210)
        Me.lb_font2.Name = "lb_font2"
        Me.lb_font2.Size = New System.Drawing.Size(0, 34)
        Me.lb_font2.TabIndex = 87
        '
        'lb_font3
        '
        Me.lb_font3.AutoSize = True
        Me.lb_font3.Font = New System.Drawing.Font("Arial Narrow", 15.0!, System.Drawing.FontStyle.Bold)
        Me.lb_font3.Location = New System.Drawing.Point(37, 263)
        Me.lb_font3.Name = "lb_font3"
        Me.lb_font3.Size = New System.Drawing.Size(0, 24)
        Me.lb_font3.TabIndex = 88
        '
        'lb_font4
        '
        Me.lb_font4.AutoSize = True
        Me.lb_font4.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.lb_font4.Location = New System.Drawing.Point(38, 300)
        Me.lb_font4.Name = "lb_font4"
        Me.lb_font4.Size = New System.Drawing.Size(0, 16)
        Me.lb_font4.TabIndex = 89
        '
        'lb_font5
        '
        Me.lb_font5.AutoSize = True
        Me.lb_font5.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lb_font5.Location = New System.Drawing.Point(38, 345)
        Me.lb_font5.Name = "lb_font5"
        Me.lb_font5.Size = New System.Drawing.Size(0, 19)
        Me.lb_font5.TabIndex = 90
        '
        'lb_font6
        '
        Me.lb_font6.AutoSize = True
        Me.lb_font6.Font = New System.Drawing.Font("Arial", 9.5!)
        Me.lb_font6.Location = New System.Drawing.Point(39, 374)
        Me.lb_font6.Name = "lb_font6"
        Me.lb_font6.Size = New System.Drawing.Size(0, 16)
        Me.lb_font6.TabIndex = 91
        '
        'font_part_name
        '
        Me.font_part_name.AutoSize = True
        Me.font_part_name.Font = New System.Drawing.Font("Consolas", 21.5!, System.Drawing.FontStyle.Bold)
        Me.font_part_name.Location = New System.Drawing.Point(39, 394)
        Me.font_part_name.Name = "font_part_name"
        Me.font_part_name.Size = New System.Drawing.Size(0, 34)
        Me.font_part_name.TabIndex = 92
        '
        'plandate
        '
        Me.plandate.AutoSize = True
        Me.plandate.Font = New System.Drawing.Font("Arial", 19.5!, System.Drawing.FontStyle.Bold)
        Me.plandate.Location = New System.Drawing.Point(40, 446)
        Me.plandate.Name = "plandate"
        Me.plandate.Size = New System.Drawing.Size(0, 30)
        Me.plandate.TabIndex = 93
        '
        'qr_code_1
        '
        Me.qr_code_1.BackColor = System.Drawing.Color.Transparent
        Me.qr_code_1.Location = New System.Drawing.Point(228, 556)
        Me.qr_code_1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.qr_code_1.Name = "qr_code_1"
        Me.qr_code_1.Size = New System.Drawing.Size(84, 26)
        Me.qr_code_1.TabIndex = 94
        Me.qr_code_1.TabStop = False
        Me.qr_code_1.Visible = False
        '
        'qr_code_2
        '
        Me.qr_code_2.BackColor = System.Drawing.Color.Transparent
        Me.qr_code_2.Location = New System.Drawing.Point(318, 556)
        Me.qr_code_2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.qr_code_2.Name = "qr_code_2"
        Me.qr_code_2.Size = New System.Drawing.Size(84, 26)
        Me.qr_code_2.TabIndex = 95
        Me.qr_code_2.TabStop = False
        Me.qr_code_2.Visible = False
        '
        'qr_code_3
        '
        Me.qr_code_3.BackColor = System.Drawing.Color.Transparent
        Me.qr_code_3.Location = New System.Drawing.Point(408, 556)
        Me.qr_code_3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.qr_code_3.Name = "qr_code_3"
        Me.qr_code_3.Size = New System.Drawing.Size(84, 26)
        Me.qr_code_3.TabIndex = 96
        Me.qr_code_3.TabStop = False
        Me.qr_code_3.Visible = False
        '
        'succes
        '
        Me.succes.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.succes.Image = CType(resources.GetObject("succes.Image"), System.Drawing.Image)
        Me.succes.Location = New System.Drawing.Point(126, 105)
        Me.succes.Margin = New System.Windows.Forms.Padding(2)
        Me.succes.Name = "succes"
        Me.succes.Size = New System.Drawing.Size(505, 363)
        Me.succes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.succes.TabIndex = 97
        Me.succes.TabStop = False
        Me.succes.Visible = False
        '
        'dummy_tag_detail_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.Controls.Add(Me.succes)
        Me.Controls.Add(Me.qr_code_3)
        Me.Controls.Add(Me.qr_code_2)
        Me.Controls.Add(Me.qr_code_1)
        Me.Controls.Add(Me.plandate)
        Me.Controls.Add(Me.font_part_name)
        Me.Controls.Add(Me.lb_font6)
        Me.Controls.Add(Me.lb_font5)
        Me.Controls.Add(Me.lb_font4)
        Me.Controls.Add(Me.lb_font3)
        Me.Controls.Add(Me.lb_font2)
        Me.Controls.Add(Me.lb_font1)
        Me.Controls.Add(Me.max_box_ps)
        Me.Controls.Add(Me.exit_pagedata)
        Me.Controls.Add(Me.print_BT)
        Me.Controls.Add(Me.tag_show_data)
        Me.Controls.Add(Me.qty_show_data)
        Me.Controls.Add(Me.lot_no_show_data)
        Me.Controls.Add(Me.plan_date_show_data)
        Me.Controls.Add(Me.ac_date_show_data)
        Me.Controls.Add(Me.seq_show_data)
        Me.Controls.Add(Me.shift_show_data)
        Me.Controls.Add(Me.line_show_data)
        Me.Controls.Add(Me.model_show_data)
        Me.Controls.Add(Me.part_name_show_data)
        Me.Controls.Add(Me.part_no_show_data)
        Me.Controls.Add(Me.wi_show_data)
        Me.Controls.Add(Me.PictureBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "dummy_tag_detail_form"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dummy"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.exit_pagedata, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.qr_code_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.qr_code_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.qr_code_3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.succes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents print_BT As Button
    Friend WithEvents tag_show_data As TextBox
    Friend WithEvents qty_show_data As TextBox
    Friend WithEvents lot_no_show_data As Label
    Friend WithEvents plan_date_show_data As Label
    Friend WithEvents ac_date_show_data As Label
    Friend WithEvents seq_show_data As Label
    Friend WithEvents shift_show_data As Label
    Friend WithEvents line_show_data As Label
    Friend WithEvents model_show_data As Label
    Friend WithEvents part_name_show_data As Label
    Friend WithEvents part_no_show_data As Label
    Friend WithEvents wi_show_data As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents exit_pagedata As PictureBox
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents max_box_ps As Label
    Friend WithEvents lb_font1 As Label
    Friend WithEvents lb_font2 As Label
    Friend WithEvents lb_font3 As Label
    Friend WithEvents lb_font4 As Label
    Friend WithEvents lb_font5 As Label
    Friend WithEvents lb_font6 As Label
    Friend WithEvents font_part_name As Label
    Friend WithEvents plandate As Label
    Friend WithEvents qr_code_1 As PictureBox
    Friend WithEvents qr_code_2 As PictureBox
    Friend WithEvents qr_code_3 As PictureBox
    Friend WithEvents succes As PictureBox
End Class
