<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class scan_tag
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(scan_tag))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.wi = New System.Windows.Forms.Label()
        Me.part_name = New System.Windows.Forms.Label()
        Me.part_no = New System.Windows.Forms.Label()
        Me.pro_seq = New System.Windows.Forms.Label()
        Me.box_no = New System.Windows.Forms.Label()
        Me.actual_date = New System.Windows.Forms.Label()
        Me.plan_date = New System.Windows.Forms.Label()
        Me.lot_no = New System.Windows.Forms.Label()
        Me.model = New System.Windows.Forms.Label()
        Me.line = New System.Windows.Forms.Label()
        Me.shift = New System.Windows.Forms.Label()
        Me.qr_code = New System.Windows.Forms.TextBox()
        Me.qty = New System.Windows.Forms.TextBox()
        Me.reprint = New System.Windows.Forms.Button()
        Me.exit_pagedata = New System.Windows.Forms.PictureBox()
        Me.button_confirm = New System.Windows.Forms.PictureBox()
        Me.button_cancel = New System.Windows.Forms.PictureBox()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.lb_font1 = New System.Windows.Forms.Label()
        Me.lb_font2 = New System.Windows.Forms.Label()
        Me.lb_font3 = New System.Windows.Forms.Label()
        Me.lb_font4 = New System.Windows.Forms.Label()
        Me.qr_code_1 = New System.Windows.Forms.PictureBox()
        Me.lb_font5 = New System.Windows.Forms.Label()
        Me.plan_tag = New System.Windows.Forms.Label()
        Me.qr_code_2 = New System.Windows.Forms.PictureBox()
        Me.qr_code_3 = New System.Windows.Forms.PictureBox()
        Me.plandate = New System.Windows.Forms.Label()
        Me.lb_font6 = New System.Windows.Forms.Label()
        Me.PrintDocument2 = New System.Drawing.Printing.PrintDocument()
        Me.qty_pcs = New System.Windows.Forms.Label()
        Me.PrintPreviewDialog2 = New System.Windows.Forms.PrintPreviewDialog()
        Me.panel_number = New System.Windows.Forms.TableLayoutPanel()
        Me.del = New System.Windows.Forms.Button()
        Me.num0 = New System.Windows.Forms.Button()
        Me.clear = New System.Windows.Forms.Button()
        Me.num9 = New System.Windows.Forms.Button()
        Me.num8 = New System.Windows.Forms.Button()
        Me.num7 = New System.Windows.Forms.Button()
        Me.num6 = New System.Windows.Forms.Button()
        Me.num5 = New System.Windows.Forms.Button()
        Me.num4 = New System.Windows.Forms.Button()
        Me.num3 = New System.Windows.Forms.Button()
        Me.num1 = New System.Windows.Forms.Button()
        Me.num2 = New System.Windows.Forms.Button()
        Me.number_input = New System.Windows.Forms.TextBox()
        Me.back_button = New System.Windows.Forms.PictureBox()
        Me.menu_key_number = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.font_part_name = New System.Windows.Forms.Label()
        Me.lb_scanner_port = New System.Windows.Forms.TextBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.confirm = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.key = New System.Windows.Forms.PictureBox()
        Me.ok_button = New System.Windows.Forms.PictureBox()
        Me.alert = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.exit_pagedata, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.button_confirm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.button_cancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.qr_code_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.qr_code_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.qr_code_3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_number.SuspendLayout()
        CType(Me.back_button, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.menu_key_number, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.confirm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.key, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ok_button, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.alert, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(634, 463)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(166, 138)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'wi
        '
        Me.wi.AutoSize = True
        Me.wi.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.wi.Font = New System.Drawing.Font("Bahnschrift Condensed", 16.8!)
        Me.wi.ForeColor = System.Drawing.Color.White
        Me.wi.Location = New System.Drawing.Point(156, 115)
        Me.wi.Name = "wi"
        Me.wi.Size = New System.Drawing.Size(75, 28)
        Me.wi.TabIndex = 2
        Me.wi.Text = "not data"
        '
        'part_name
        '
        Me.part_name.AutoSize = True
        Me.part_name.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.part_name.Font = New System.Drawing.Font("Bahnschrift Condensed", 16.8!)
        Me.part_name.ForeColor = System.Drawing.Color.White
        Me.part_name.Location = New System.Drawing.Point(156, 245)
        Me.part_name.Name = "part_name"
        Me.part_name.Size = New System.Drawing.Size(75, 28)
        Me.part_name.TabIndex = 3
        Me.part_name.Text = "not data"
        '
        'part_no
        '
        Me.part_no.AutoSize = True
        Me.part_no.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.part_no.Font = New System.Drawing.Font("Bahnschrift Condensed", 16.8!)
        Me.part_no.ForeColor = System.Drawing.Color.White
        Me.part_no.Location = New System.Drawing.Point(156, 180)
        Me.part_no.Name = "part_no"
        Me.part_no.Size = New System.Drawing.Size(75, 28)
        Me.part_no.TabIndex = 4
        Me.part_no.Text = "not data"
        '
        'pro_seq
        '
        Me.pro_seq.AutoSize = True
        Me.pro_seq.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.pro_seq.Font = New System.Drawing.Font("Bahnschrift Condensed", 16.8!)
        Me.pro_seq.ForeColor = System.Drawing.Color.White
        Me.pro_seq.Location = New System.Drawing.Point(504, 115)
        Me.pro_seq.Name = "pro_seq"
        Me.pro_seq.Size = New System.Drawing.Size(75, 28)
        Me.pro_seq.TabIndex = 5
        Me.pro_seq.Text = "not data"
        '
        'box_no
        '
        Me.box_no.AutoSize = True
        Me.box_no.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.box_no.Font = New System.Drawing.Font("Bahnschrift Condensed", 16.8!)
        Me.box_no.ForeColor = System.Drawing.Color.White
        Me.box_no.Location = New System.Drawing.Point(504, 180)
        Me.box_no.Name = "box_no"
        Me.box_no.Size = New System.Drawing.Size(75, 28)
        Me.box_no.TabIndex = 6
        Me.box_no.Text = "not data"
        '
        'actual_date
        '
        Me.actual_date.AutoSize = True
        Me.actual_date.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.actual_date.Font = New System.Drawing.Font("Bahnschrift Condensed", 16.8!)
        Me.actual_date.ForeColor = System.Drawing.Color.White
        Me.actual_date.Location = New System.Drawing.Point(504, 245)
        Me.actual_date.Name = "actual_date"
        Me.actual_date.Size = New System.Drawing.Size(75, 28)
        Me.actual_date.TabIndex = 7
        Me.actual_date.Text = "not data"
        '
        'plan_date
        '
        Me.plan_date.AutoSize = True
        Me.plan_date.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.plan_date.Font = New System.Drawing.Font("Bahnschrift Condensed", 16.8!)
        Me.plan_date.ForeColor = System.Drawing.Color.White
        Me.plan_date.Location = New System.Drawing.Point(504, 310)
        Me.plan_date.Name = "plan_date"
        Me.plan_date.Size = New System.Drawing.Size(75, 28)
        Me.plan_date.TabIndex = 8
        Me.plan_date.Text = "not data"
        '
        'lot_no
        '
        Me.lot_no.AutoSize = True
        Me.lot_no.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.lot_no.Font = New System.Drawing.Font("Bahnschrift Condensed", 16.8!)
        Me.lot_no.ForeColor = System.Drawing.Color.White
        Me.lot_no.Location = New System.Drawing.Point(504, 376)
        Me.lot_no.Name = "lot_no"
        Me.lot_no.Size = New System.Drawing.Size(75, 28)
        Me.lot_no.TabIndex = 10
        Me.lot_no.Text = "not data"
        '
        'model
        '
        Me.model.AutoSize = True
        Me.model.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.model.Font = New System.Drawing.Font("Bahnschrift Condensed", 16.8!)
        Me.model.ForeColor = System.Drawing.Color.White
        Me.model.Location = New System.Drawing.Point(156, 310)
        Me.model.Name = "model"
        Me.model.Size = New System.Drawing.Size(75, 28)
        Me.model.TabIndex = 11
        Me.model.Text = "not data"
        '
        'line
        '
        Me.line.AutoSize = True
        Me.line.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.line.Font = New System.Drawing.Font("Bahnschrift Condensed", 16.8!)
        Me.line.ForeColor = System.Drawing.Color.White
        Me.line.Location = New System.Drawing.Point(156, 376)
        Me.line.Name = "line"
        Me.line.Size = New System.Drawing.Size(75, 28)
        Me.line.TabIndex = 12
        Me.line.Text = "not data"
        '
        'shift
        '
        Me.shift.AutoSize = True
        Me.shift.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.shift.Font = New System.Drawing.Font("Bahnschrift Condensed", 16.8!)
        Me.shift.ForeColor = System.Drawing.Color.White
        Me.shift.Location = New System.Drawing.Point(156, 439)
        Me.shift.Name = "shift"
        Me.shift.Size = New System.Drawing.Size(75, 28)
        Me.shift.TabIndex = 13
        Me.shift.Text = "not data"
        '
        'qr_code
        '
        Me.qr_code.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.qr_code.Font = New System.Drawing.Font("Bahnschrift Condensed", 20.0!)
        Me.qr_code.Location = New System.Drawing.Point(182, 281)
        Me.qr_code.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.qr_code.Multiline = True
        Me.qr_code.Name = "qr_code"
        Me.qr_code.Size = New System.Drawing.Size(440, 38)
        Me.qr_code.TabIndex = 14
        '
        'qty
        '
        Me.qty.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.qty.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.qty.Font = New System.Drawing.Font("Bahnschrift Condensed", 16.2!)
        Me.qty.Location = New System.Drawing.Point(508, 440)
        Me.qty.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.qty.Multiline = True
        Me.qty.Name = "qty"
        Me.qty.Size = New System.Drawing.Size(130, 27)
        Me.qty.TabIndex = 15
        '
        'reprint
        '
        Me.reprint.BackgroundImage = CType(resources.GetObject("reprint.BackgroundImage"), System.Drawing.Image)
        Me.reprint.Location = New System.Drawing.Point(336, 479)
        Me.reprint.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.reprint.Name = "reprint"
        Me.reprint.Size = New System.Drawing.Size(123, 43)
        Me.reprint.TabIndex = 16
        Me.reprint.UseVisualStyleBackColor = True
        '
        'exit_pagedata
        '
        Me.exit_pagedata.Image = CType(resources.GetObject("exit_pagedata.Image"), System.Drawing.Image)
        Me.exit_pagedata.Location = New System.Drawing.Point(649, 67)
        Me.exit_pagedata.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.exit_pagedata.Name = "exit_pagedata"
        Me.exit_pagedata.Size = New System.Drawing.Size(62, 47)
        Me.exit_pagedata.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.exit_pagedata.TabIndex = 18
        Me.exit_pagedata.TabStop = False
        '
        'button_confirm
        '
        Me.button_confirm.Image = CType(resources.GetObject("button_confirm.Image"), System.Drawing.Image)
        Me.button_confirm.Location = New System.Drawing.Point(441, 402)
        Me.button_confirm.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.button_confirm.Name = "button_confirm"
        Me.button_confirm.Size = New System.Drawing.Size(148, 49)
        Me.button_confirm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.button_confirm.TabIndex = 22
        Me.button_confirm.TabStop = False
        '
        'button_cancel
        '
        Me.button_cancel.Image = CType(resources.GetObject("button_cancel.Image"), System.Drawing.Image)
        Me.button_cancel.Location = New System.Drawing.Point(207, 402)
        Me.button_cancel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.button_cancel.Name = "button_cancel"
        Me.button_cancel.Size = New System.Drawing.Size(148, 49)
        Me.button_cancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.button_cancel.TabIndex = 23
        Me.button_cancel.TabStop = False
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'lb_font1
        '
        Me.lb_font1.AutoSize = True
        Me.lb_font1.Font = New System.Drawing.Font("Arial", 8.5!)
        Me.lb_font1.Location = New System.Drawing.Point(12, 9)
        Me.lb_font1.Name = "lb_font1"
        Me.lb_font1.Size = New System.Drawing.Size(0, 15)
        Me.lb_font1.TabIndex = 24
        '
        'lb_font2
        '
        Me.lb_font2.AutoSize = True
        Me.lb_font2.Font = New System.Drawing.Font("Consolas", 21.5!, System.Drawing.FontStyle.Bold)
        Me.lb_font2.Location = New System.Drawing.Point(56, 9)
        Me.lb_font2.Name = "lb_font2"
        Me.lb_font2.Size = New System.Drawing.Size(0, 34)
        Me.lb_font2.TabIndex = 25
        '
        'lb_font3
        '
        Me.lb_font3.AutoSize = True
        Me.lb_font3.Font = New System.Drawing.Font("Arial Narrow", 15.0!, System.Drawing.FontStyle.Bold)
        Me.lb_font3.Location = New System.Drawing.Point(62, 9)
        Me.lb_font3.Name = "lb_font3"
        Me.lb_font3.Size = New System.Drawing.Size(0, 24)
        Me.lb_font3.TabIndex = 26
        '
        'lb_font4
        '
        Me.lb_font4.AutoSize = True
        Me.lb_font4.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.lb_font4.Location = New System.Drawing.Point(82, 9)
        Me.lb_font4.Name = "lb_font4"
        Me.lb_font4.Size = New System.Drawing.Size(0, 16)
        Me.lb_font4.TabIndex = 27
        '
        'qr_code_1
        '
        Me.qr_code_1.BackColor = System.Drawing.Color.Transparent
        Me.qr_code_1.Location = New System.Drawing.Point(227, 12)
        Me.qr_code_1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.qr_code_1.Name = "qr_code_1"
        Me.qr_code_1.Size = New System.Drawing.Size(84, 26)
        Me.qr_code_1.TabIndex = 28
        Me.qr_code_1.TabStop = False
        '
        'lb_font5
        '
        Me.lb_font5.AutoSize = True
        Me.lb_font5.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lb_font5.Location = New System.Drawing.Point(88, 29)
        Me.lb_font5.Name = "lb_font5"
        Me.lb_font5.Size = New System.Drawing.Size(0, 19)
        Me.lb_font5.TabIndex = 29
        '
        'plan_tag
        '
        Me.plan_tag.AutoSize = True
        Me.plan_tag.Location = New System.Drawing.Point(194, 9)
        Me.plan_tag.Name = "plan_tag"
        Me.plan_tag.Size = New System.Drawing.Size(0, 13)
        Me.plan_tag.TabIndex = 30
        '
        'qr_code_2
        '
        Me.qr_code_2.BackColor = System.Drawing.Color.Transparent
        Me.qr_code_2.Location = New System.Drawing.Point(365, 12)
        Me.qr_code_2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.qr_code_2.Name = "qr_code_2"
        Me.qr_code_2.Size = New System.Drawing.Size(84, 26)
        Me.qr_code_2.TabIndex = 31
        Me.qr_code_2.TabStop = False
        '
        'qr_code_3
        '
        Me.qr_code_3.BackColor = System.Drawing.Color.Transparent
        Me.qr_code_3.Location = New System.Drawing.Point(504, 12)
        Me.qr_code_3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.qr_code_3.Name = "qr_code_3"
        Me.qr_code_3.Size = New System.Drawing.Size(84, 26)
        Me.qr_code_3.TabIndex = 32
        Me.qr_code_3.TabStop = False
        '
        'plandate
        '
        Me.plandate.AutoSize = True
        Me.plandate.Font = New System.Drawing.Font("Arial", 19.5!, System.Drawing.FontStyle.Bold)
        Me.plandate.Location = New System.Drawing.Point(82, 9)
        Me.plandate.Name = "plandate"
        Me.plandate.Size = New System.Drawing.Size(0, 30)
        Me.plandate.TabIndex = 33
        '
        'lb_font6
        '
        Me.lb_font6.AutoSize = True
        Me.lb_font6.Font = New System.Drawing.Font("Arial", 9.5!)
        Me.lb_font6.Location = New System.Drawing.Point(56, 36)
        Me.lb_font6.Name = "lb_font6"
        Me.lb_font6.Size = New System.Drawing.Size(0, 16)
        Me.lb_font6.TabIndex = 34
        '
        'PrintDocument2
        '
        '
        'qty_pcs
        '
        Me.qty_pcs.AutoSize = True
        Me.qty_pcs.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.qty_pcs.Font = New System.Drawing.Font("Bahnschrift Condensed", 10.2!)
        Me.qty_pcs.ForeColor = System.Drawing.Color.White
        Me.qty_pcs.Location = New System.Drawing.Point(595, 417)
        Me.qty_pcs.Name = "qty_pcs"
        Me.qty_pcs.Size = New System.Drawing.Size(0, 17)
        Me.qty_pcs.TabIndex = 35
        '
        'PrintPreviewDialog2
        '
        Me.PrintPreviewDialog2.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog2.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog2.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog2.Document = Me.PrintDocument2
        Me.PrintPreviewDialog2.Enabled = True
        Me.PrintPreviewDialog2.Icon = CType(resources.GetObject("PrintPreviewDialog2.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog2.Name = "PrintPreviewDialog2"
        Me.PrintPreviewDialog2.Visible = False
        '
        'panel_number
        '
        Me.panel_number.BackColor = System.Drawing.Color.White
        Me.panel_number.ColumnCount = 3
        Me.panel_number.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.panel_number.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.panel_number.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.panel_number.Controls.Add(Me.del, 2, 3)
        Me.panel_number.Controls.Add(Me.num0, 1, 3)
        Me.panel_number.Controls.Add(Me.clear, 0, 3)
        Me.panel_number.Controls.Add(Me.num9, 2, 2)
        Me.panel_number.Controls.Add(Me.num8, 1, 2)
        Me.panel_number.Controls.Add(Me.num7, 0, 2)
        Me.panel_number.Controls.Add(Me.num6, 2, 1)
        Me.panel_number.Controls.Add(Me.num5, 1, 1)
        Me.panel_number.Controls.Add(Me.num4, 0, 1)
        Me.panel_number.Controls.Add(Me.num3, 2, 0)
        Me.panel_number.Controls.Add(Me.num1, 0, 0)
        Me.panel_number.Controls.Add(Me.num2, 1, 0)
        Me.panel_number.Location = New System.Drawing.Point(275, 244)
        Me.panel_number.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.panel_number.Name = "panel_number"
        Me.panel_number.RowCount = 4
        Me.panel_number.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00062!))
        Me.panel_number.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00062!))
        Me.panel_number.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00062!))
        Me.panel_number.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.99813!))
        Me.panel_number.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panel_number.Size = New System.Drawing.Size(250, 228)
        Me.panel_number.TabIndex = 38
        '
        'del
        '
        Me.del.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.del.Font = New System.Drawing.Font("Bahnschrift", 18.0!)
        Me.del.Location = New System.Drawing.Point(169, 173)
        Me.del.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.del.Name = "del"
        Me.del.Size = New System.Drawing.Size(78, 50)
        Me.del.TabIndex = 50
        Me.del.Text = "Del"
        Me.del.UseVisualStyleBackColor = True
        '
        'num0
        '
        Me.num0.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.num0.Font = New System.Drawing.Font("Bahnschrift", 18.0!)
        Me.num0.Location = New System.Drawing.Point(86, 173)
        Me.num0.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.num0.Name = "num0"
        Me.num0.Size = New System.Drawing.Size(77, 50)
        Me.num0.TabIndex = 49
        Me.num0.Text = "0"
        Me.num0.UseVisualStyleBackColor = True
        '
        'clear
        '
        Me.clear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.clear.Font = New System.Drawing.Font("Bahnschrift", 18.0!)
        Me.clear.ForeColor = System.Drawing.Color.Red
        Me.clear.Location = New System.Drawing.Point(3, 173)
        Me.clear.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.clear.Name = "clear"
        Me.clear.Size = New System.Drawing.Size(77, 50)
        Me.clear.TabIndex = 48
        Me.clear.Text = "C"
        Me.clear.UseVisualStyleBackColor = True
        '
        'num9
        '
        Me.num9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.num9.Font = New System.Drawing.Font("Bahnschrift", 18.0!)
        Me.num9.Location = New System.Drawing.Point(169, 116)
        Me.num9.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.num9.Name = "num9"
        Me.num9.Size = New System.Drawing.Size(78, 51)
        Me.num9.TabIndex = 47
        Me.num9.Text = "9"
        Me.num9.UseVisualStyleBackColor = True
        '
        'num8
        '
        Me.num8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.num8.Font = New System.Drawing.Font("Bahnschrift", 18.0!)
        Me.num8.Location = New System.Drawing.Point(86, 116)
        Me.num8.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.num8.Name = "num8"
        Me.num8.Size = New System.Drawing.Size(77, 51)
        Me.num8.TabIndex = 46
        Me.num8.Text = "8"
        Me.num8.UseVisualStyleBackColor = True
        '
        'num7
        '
        Me.num7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.num7.Font = New System.Drawing.Font("Bahnschrift", 18.0!)
        Me.num7.Location = New System.Drawing.Point(3, 116)
        Me.num7.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.num7.Name = "num7"
        Me.num7.Size = New System.Drawing.Size(77, 51)
        Me.num7.TabIndex = 45
        Me.num7.Text = "7"
        Me.num7.UseVisualStyleBackColor = True
        '
        'num6
        '
        Me.num6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.num6.Font = New System.Drawing.Font("Bahnschrift", 18.0!)
        Me.num6.Location = New System.Drawing.Point(169, 59)
        Me.num6.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.num6.Name = "num6"
        Me.num6.Size = New System.Drawing.Size(78, 51)
        Me.num6.TabIndex = 44
        Me.num6.Text = "6"
        Me.num6.UseVisualStyleBackColor = True
        '
        'num5
        '
        Me.num5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.num5.Font = New System.Drawing.Font("Bahnschrift", 18.0!)
        Me.num5.Location = New System.Drawing.Point(86, 59)
        Me.num5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.num5.Name = "num5"
        Me.num5.Size = New System.Drawing.Size(77, 51)
        Me.num5.TabIndex = 43
        Me.num5.Text = "5"
        Me.num5.UseVisualStyleBackColor = True
        '
        'num4
        '
        Me.num4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.num4.Font = New System.Drawing.Font("Bahnschrift", 18.0!)
        Me.num4.Location = New System.Drawing.Point(3, 59)
        Me.num4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.num4.Name = "num4"
        Me.num4.Size = New System.Drawing.Size(77, 51)
        Me.num4.TabIndex = 42
        Me.num4.Text = "4"
        Me.num4.UseVisualStyleBackColor = True
        '
        'num3
        '
        Me.num3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.num3.Font = New System.Drawing.Font("Bahnschrift", 18.0!)
        Me.num3.Location = New System.Drawing.Point(169, 2)
        Me.num3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.num3.Name = "num3"
        Me.num3.Size = New System.Drawing.Size(78, 51)
        Me.num3.TabIndex = 41
        Me.num3.Text = "3"
        Me.num3.UseVisualStyleBackColor = True
        '
        'num1
        '
        Me.num1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.num1.Font = New System.Drawing.Font("Bahnschrift", 18.0!)
        Me.num1.Location = New System.Drawing.Point(3, 2)
        Me.num1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.num1.Name = "num1"
        Me.num1.Size = New System.Drawing.Size(77, 51)
        Me.num1.TabIndex = 39
        Me.num1.Text = "1"
        Me.num1.UseVisualStyleBackColor = True
        '
        'num2
        '
        Me.num2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.num2.Font = New System.Drawing.Font("Bahnschrift", 18.0!)
        Me.num2.Location = New System.Drawing.Point(86, 2)
        Me.num2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.num2.Name = "num2"
        Me.num2.Size = New System.Drawing.Size(77, 51)
        Me.num2.TabIndex = 40
        Me.num2.Text = "2"
        Me.num2.UseVisualStyleBackColor = True
        '
        'number_input
        '
        Me.number_input.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.number_input.Enabled = False
        Me.number_input.Font = New System.Drawing.Font("Bahnschrift Condensed", 28.2!)
        Me.number_input.Location = New System.Drawing.Point(262, 114)
        Me.number_input.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.number_input.Multiline = True
        Me.number_input.Name = "number_input"
        Me.number_input.ReadOnly = True
        Me.number_input.Size = New System.Drawing.Size(274, 77)
        Me.number_input.TabIndex = 39
        Me.number_input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'back_button
        '
        Me.back_button.BackColor = System.Drawing.Color.White
        Me.back_button.Image = CType(resources.GetObject("back_button.Image"), System.Drawing.Image)
        Me.back_button.Location = New System.Drawing.Point(133, 413)
        Me.back_button.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.back_button.Name = "back_button"
        Me.back_button.Size = New System.Drawing.Size(128, 57)
        Me.back_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.back_button.TabIndex = 41
        Me.back_button.TabStop = False
        '
        'menu_key_number
        '
        Me.menu_key_number.BackColor = System.Drawing.Color.Transparent
        Me.menu_key_number.Image = CType(resources.GetObject("menu_key_number.Image"), System.Drawing.Image)
        Me.menu_key_number.Location = New System.Drawing.Point(674, 479)
        Me.menu_key_number.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.menu_key_number.Name = "menu_key_number"
        Me.menu_key_number.Size = New System.Drawing.Size(37, 45)
        Me.menu_key_number.TabIndex = 42
        Me.menu_key_number.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(492, 180)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 19)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(357, 337)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 18)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "Label2"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(358, 406)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 18)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "Label3"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(147, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 13)
        Me.Label4.TabIndex = 46
        '
        'font_part_name
        '
        Me.font_part_name.AutoSize = True
        Me.font_part_name.Font = New System.Drawing.Font("Consolas", 21.5!, System.Drawing.FontStyle.Bold)
        Me.font_part_name.Location = New System.Drawing.Point(82, 22)
        Me.font_part_name.Name = "font_part_name"
        Me.font_part_name.Size = New System.Drawing.Size(0, 34)
        Me.font_part_name.TabIndex = 47
        '
        'lb_scanner_port
        '
        Me.lb_scanner_port.Location = New System.Drawing.Point(59, 23)
        Me.lb_scanner_port.Name = "lb_scanner_port"
        Me.lb_scanner_port.Size = New System.Drawing.Size(100, 20)
        Me.lb_scanner_port.TabIndex = 48
        Me.lb_scanner_port.Text = "emp"
        Me.lb_scanner_port.Visible = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(151, 114)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(503, 362)
        Me.PictureBox3.TabIndex = 20
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(82, 60)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(654, 500)
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'confirm
        '
        Me.confirm.BackColor = System.Drawing.Color.Transparent
        Me.confirm.Image = CType(resources.GetObject("confirm.Image"), System.Drawing.Image)
        Me.confirm.Location = New System.Drawing.Point(150, 115)
        Me.confirm.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.confirm.Name = "confirm"
        Me.confirm.Size = New System.Drawing.Size(503, 364)
        Me.confirm.TabIndex = 21
        Me.confirm.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 7000
        '
        'key
        '
        Me.key.BackColor = System.Drawing.Color.Black
        Me.key.Image = CType(resources.GetObject("key.Image"), System.Drawing.Image)
        Me.key.Location = New System.Drawing.Point(206, 75)
        Me.key.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.key.Name = "key"
        Me.key.Size = New System.Drawing.Size(392, 449)
        Me.key.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.key.TabIndex = 36
        Me.key.TabStop = False
        '
        'ok_button
        '
        Me.ok_button.Image = CType(resources.GetObject("ok_button.Image"), System.Drawing.Image)
        Me.ok_button.Location = New System.Drawing.Point(543, 413)
        Me.ok_button.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ok_button.Name = "ok_button"
        Me.ok_button.Size = New System.Drawing.Size(128, 57)
        Me.ok_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.ok_button.TabIndex = 40
        Me.ok_button.TabStop = False
        '
        'alert
        '
        Me.alert.BackColor = System.Drawing.Color.Transparent
        Me.alert.Image = CType(resources.GetObject("alert.Image"), System.Drawing.Image)
        Me.alert.Location = New System.Drawing.Point(151, 112)
        Me.alert.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.alert.Name = "alert"
        Me.alert.Size = New System.Drawing.Size(503, 394)
        Me.alert.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.alert.TabIndex = 19
        Me.alert.TabStop = False
        '
        'scan_tag
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.Controls.Add(Me.lb_scanner_port)
        Me.Controls.Add(Me.font_part_name)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.alert)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.menu_key_number)
        Me.Controls.Add(Me.back_button)
        Me.Controls.Add(Me.ok_button)
        Me.Controls.Add(Me.number_input)
        Me.Controls.Add(Me.panel_number)
        Me.Controls.Add(Me.key)
        Me.Controls.Add(Me.button_confirm)
        Me.Controls.Add(Me.button_cancel)
        Me.Controls.Add(Me.confirm)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.qty_pcs)
        Me.Controls.Add(Me.lb_font6)
        Me.Controls.Add(Me.plandate)
        Me.Controls.Add(Me.qr_code_3)
        Me.Controls.Add(Me.qr_code_2)
        Me.Controls.Add(Me.plan_tag)
        Me.Controls.Add(Me.lb_font5)
        Me.Controls.Add(Me.qr_code_1)
        Me.Controls.Add(Me.lb_font4)
        Me.Controls.Add(Me.lb_font3)
        Me.Controls.Add(Me.lb_font2)
        Me.Controls.Add(Me.lb_font1)
        Me.Controls.Add(Me.exit_pagedata)
        Me.Controls.Add(Me.reprint)
        Me.Controls.Add(Me.qty)
        Me.Controls.Add(Me.shift)
        Me.Controls.Add(Me.line)
        Me.Controls.Add(Me.model)
        Me.Controls.Add(Me.lot_no)
        Me.Controls.Add(Me.plan_date)
        Me.Controls.Add(Me.actual_date)
        Me.Controls.Add(Me.box_no)
        Me.Controls.Add(Me.pro_seq)
        Me.Controls.Add(Me.part_no)
        Me.Controls.Add(Me.part_name)
        Me.Controls.Add(Me.wi)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.qr_code)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "scan_tag"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.exit_pagedata, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.button_confirm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.button_cancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.qr_code_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.qr_code_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.qr_code_3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_number.ResumeLayout(False)
        CType(Me.back_button, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.menu_key_number, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.confirm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.key, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ok_button, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.alert, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents wi As Label
    Friend WithEvents part_name As Label
    Friend WithEvents part_no As Label
    Friend WithEvents pro_seq As Label
    Friend WithEvents box_no As Label
    Friend WithEvents actual_date As Label
    Friend WithEvents plan_date As Label
    Friend WithEvents lot_no As Label
    Friend WithEvents model As Label
    Friend WithEvents line As Label
    Friend WithEvents shift As Label
    Friend WithEvents qr_code As TextBox
    Friend WithEvents qty As TextBox
    Friend WithEvents reprint As Button
    Friend WithEvents exit_pagedata As PictureBox
    Friend WithEvents button_confirm As PictureBox
    Friend WithEvents button_cancel As PictureBox
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents lb_font1 As Label
    Friend WithEvents lb_font2 As Label
    Friend WithEvents lb_font3 As Label
    Friend WithEvents lb_font4 As Label
    Friend WithEvents qr_code_1 As PictureBox
    Friend WithEvents lb_font5 As Label
    Friend WithEvents plan_tag As Label
    Friend WithEvents qr_code_2 As PictureBox
    Friend WithEvents qr_code_3 As PictureBox
    Friend WithEvents plandate As Label
    Friend WithEvents lb_font6 As Label
    Friend WithEvents PrintDocument2 As Printing.PrintDocument
    Friend WithEvents qty_pcs As Label
    Friend WithEvents PrintPreviewDialog2 As PrintPreviewDialog
    Friend WithEvents panel_number As TableLayoutPanel
    Friend WithEvents del As Button
    Friend WithEvents num0 As Button
    Friend WithEvents clear As Button
    Friend WithEvents num9 As Button
    Friend WithEvents num8 As Button
    Friend WithEvents num7 As Button
    Friend WithEvents num6 As Button
    Friend WithEvents num5 As Button
    Friend WithEvents num4 As Button
    Friend WithEvents num3 As Button
    Friend WithEvents num2 As Button
    Friend WithEvents num1 As Button
    Friend WithEvents number_input As TextBox
    Friend WithEvents back_button As PictureBox
    Friend WithEvents menu_key_number As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents font_part_name As Label
    Friend WithEvents lb_scanner_port As TextBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents confirm As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents key As PictureBox
    Friend WithEvents ok_button As PictureBox
    Friend WithEvents alert As PictureBox
End Class
