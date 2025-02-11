<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class log_reprint_form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(log_reprint_form))
        Me.line = New System.Windows.Forms.Label()
        Me.seq = New System.Windows.Forms.Label()
        Me.part_no = New System.Windows.Forms.Label()
        Me.box = New System.Windows.Forms.Label()
        Me.qty = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.no = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.log_part_no = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.log_lot = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.log_line = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.log_box_no = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.log_qty = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.log_seq = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ref_menu_id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lot = New System.Windows.Forms.Label()
        Me.data_combobox = New System.Windows.Forms.Label()
        Me.alert = New System.Windows.Forms.PictureBox()
        Me.lb_font1 = New System.Windows.Forms.Label()
        Me.lb_font2 = New System.Windows.Forms.Label()
        Me.lb_font3 = New System.Windows.Forms.Label()
        Me.lb_font4 = New System.Windows.Forms.Label()
        Me.lb_font5 = New System.Windows.Forms.Label()
        Me.lb_font6 = New System.Windows.Forms.Label()
        Me.font_part_name = New System.Windows.Forms.Label()
        Me.plandate = New System.Windows.Forms.Label()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.qr_code_1 = New System.Windows.Forms.PictureBox()
        Me.qr_code_2 = New System.Windows.Forms.PictureBox()
        Me.qr_code_3 = New System.Windows.Forms.PictureBox()
        Me.succes = New System.Windows.Forms.PictureBox()
        Me.slide = New System.Windows.Forms.PictureBox()
        Me.reprint = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.alert, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.qr_code_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.qr_code_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.qr_code_3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.succes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.slide, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.reprint, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'line
        '
        Me.line.AutoSize = True
        Me.line.BackColor = System.Drawing.Color.Transparent
        Me.line.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.line.Location = New System.Drawing.Point(260, 552)
        Me.line.Name = "line"
        Me.line.Size = New System.Drawing.Size(0, 23)
        Me.line.TabIndex = 1
        '
        'seq
        '
        Me.seq.AutoSize = True
        Me.seq.BackColor = System.Drawing.Color.Transparent
        Me.seq.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.seq.Location = New System.Drawing.Point(287, 534)
        Me.seq.Name = "seq"
        Me.seq.Size = New System.Drawing.Size(0, 23)
        Me.seq.TabIndex = 2
        '
        'part_no
        '
        Me.part_no.AutoSize = True
        Me.part_no.BackColor = System.Drawing.Color.Transparent
        Me.part_no.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.part_no.Location = New System.Drawing.Point(315, 534)
        Me.part_no.Name = "part_no"
        Me.part_no.Size = New System.Drawing.Size(0, 23)
        Me.part_no.TabIndex = 3
        '
        'box
        '
        Me.box.AutoSize = True
        Me.box.BackColor = System.Drawing.Color.Transparent
        Me.box.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.box.Location = New System.Drawing.Point(323, 542)
        Me.box.Name = "box"
        Me.box.Size = New System.Drawing.Size(0, 23)
        Me.box.TabIndex = 4
        '
        'qty
        '
        Me.qty.AutoSize = True
        Me.qty.BackColor = System.Drawing.Color.Transparent
        Me.qty.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.qty.Location = New System.Drawing.Point(323, 542)
        Me.qty.Name = "qty"
        Me.qty.Size = New System.Drawing.Size(0, 23)
        Me.qty.TabIndex = 5
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Location = New System.Drawing.Point(2, 504)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(133, 88)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.no, Me.log_part_no, Me.log_lot, Me.log_line, Me.log_box_no, Me.log_qty, Me.log_seq, Me.ref_menu_id})
        Me.ListView1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ListView1.Font = New System.Drawing.Font("Bahnschrift Condensed", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.FullRowSelect = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(70, 84)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(651, 414)
        Me.ListView1.TabIndex = 8
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'no
        '
        Me.no.Text = "NO."
        '
        'log_part_no
        '
        Me.log_part_no.Text = "PART NO."
        Me.log_part_no.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.log_part_no.Width = 150
        '
        'log_lot
        '
        Me.log_lot.Text = "LOT"
        Me.log_lot.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'log_line
        '
        Me.log_line.Text = "LINE"
        Me.log_line.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.log_line.Width = 150
        '
        'log_box_no
        '
        Me.log_box_no.Text = "BOX"
        Me.log_box_no.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.log_box_no.Width = 70
        '
        'log_qty
        '
        Me.log_qty.Text = "QTY."
        Me.log_qty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.log_qty.Width = 70
        '
        'log_seq
        '
        Me.log_seq.Text = "SEQ."
        Me.log_seq.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.log_seq.Width = 68
        '
        'ref_menu_id
        '
        Me.ref_menu_id.Text = "menu_id"
        Me.ref_menu_id.Width = 0
        '
        'lot
        '
        Me.lot.AutoSize = True
        Me.lot.BackColor = System.Drawing.Color.Transparent
        Me.lot.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.lot.Location = New System.Drawing.Point(229, 534)
        Me.lot.Name = "lot"
        Me.lot.Size = New System.Drawing.Size(0, 23)
        Me.lot.TabIndex = 9
        '
        'data_combobox
        '
        Me.data_combobox.AutoSize = True
        Me.data_combobox.BackColor = System.Drawing.Color.Transparent
        Me.data_combobox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.data_combobox.Location = New System.Drawing.Point(519, 526)
        Me.data_combobox.Name = "data_combobox"
        Me.data_combobox.Size = New System.Drawing.Size(0, 23)
        Me.data_combobox.TabIndex = 11
        '
        'alert
        '
        Me.alert.BackColor = System.Drawing.Color.White
        Me.alert.Image = CType(resources.GetObject("alert.Image"), System.Drawing.Image)
        Me.alert.Location = New System.Drawing.Point(148, 121)
        Me.alert.Name = "alert"
        Me.alert.Size = New System.Drawing.Size(505, 363)
        Me.alert.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.alert.TabIndex = 12
        Me.alert.TabStop = False
        Me.alert.Visible = False
        '
        'lb_font1
        '
        Me.lb_font1.AutoSize = True
        Me.lb_font1.Font = New System.Drawing.Font("Arial", 8.5!)
        Me.lb_font1.Location = New System.Drawing.Point(211, 545)
        Me.lb_font1.Name = "lb_font1"
        Me.lb_font1.Size = New System.Drawing.Size(0, 15)
        Me.lb_font1.TabIndex = 25
        '
        'lb_font2
        '
        Me.lb_font2.AutoSize = True
        Me.lb_font2.Font = New System.Drawing.Font("Consolas", 21.5!, System.Drawing.FontStyle.Bold)
        Me.lb_font2.Location = New System.Drawing.Point(235, 534)
        Me.lb_font2.Name = "lb_font2"
        Me.lb_font2.Size = New System.Drawing.Size(0, 34)
        Me.lb_font2.TabIndex = 26
        '
        'lb_font3
        '
        Me.lb_font3.AutoSize = True
        Me.lb_font3.Font = New System.Drawing.Font("Arial Narrow", 15.0!, System.Drawing.FontStyle.Bold)
        Me.lb_font3.Location = New System.Drawing.Point(287, 542)
        Me.lb_font3.Name = "lb_font3"
        Me.lb_font3.Size = New System.Drawing.Size(0, 24)
        Me.lb_font3.TabIndex = 27
        '
        'lb_font4
        '
        Me.lb_font4.AutoSize = True
        Me.lb_font4.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.lb_font4.Location = New System.Drawing.Point(287, 534)
        Me.lb_font4.Name = "lb_font4"
        Me.lb_font4.Size = New System.Drawing.Size(0, 16)
        Me.lb_font4.TabIndex = 28
        '
        'lb_font5
        '
        Me.lb_font5.AutoSize = True
        Me.lb_font5.Font = New System.Drawing.Font("Consolas", 14.5!, System.Drawing.FontStyle.Bold)
        Me.lb_font5.Location = New System.Drawing.Point(287, 547)
        Me.lb_font5.Name = "lb_font5"
        Me.lb_font5.Size = New System.Drawing.Size(0, 23)
        Me.lb_font5.TabIndex = 30
        '
        'lb_font6
        '
        Me.lb_font6.AutoSize = True
        Me.lb_font6.Font = New System.Drawing.Font("Arial", 9.5!)
        Me.lb_font6.Location = New System.Drawing.Point(266, 545)
        Me.lb_font6.Name = "lb_font6"
        Me.lb_font6.Size = New System.Drawing.Size(0, 16)
        Me.lb_font6.TabIndex = 35
        '
        'font_part_name
        '
        Me.font_part_name.AutoSize = True
        Me.font_part_name.Font = New System.Drawing.Font("Consolas", 21.5!, System.Drawing.FontStyle.Bold)
        Me.font_part_name.Location = New System.Drawing.Point(217, 538)
        Me.font_part_name.Name = "font_part_name"
        Me.font_part_name.Size = New System.Drawing.Size(0, 34)
        Me.font_part_name.TabIndex = 48
        '
        'plandate
        '
        Me.plandate.AutoSize = True
        Me.plandate.Font = New System.Drawing.Font("Arial", 19.5!, System.Drawing.FontStyle.Bold)
        Me.plandate.Location = New System.Drawing.Point(223, 527)
        Me.plandate.Name = "plandate"
        Me.plandate.Size = New System.Drawing.Size(0, 30)
        Me.plandate.TabIndex = 49
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
        'qr_code_1
        '
        Me.qr_code_1.BackColor = System.Drawing.Color.Transparent
        Me.qr_code_1.Location = New System.Drawing.Point(239, 534)
        Me.qr_code_1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.qr_code_1.Name = "qr_code_1"
        Me.qr_code_1.Size = New System.Drawing.Size(84, 26)
        Me.qr_code_1.TabIndex = 50
        Me.qr_code_1.TabStop = False
        Me.qr_code_1.Visible = False
        '
        'qr_code_2
        '
        Me.qr_code_2.BackColor = System.Drawing.Color.Transparent
        Me.qr_code_2.Location = New System.Drawing.Point(329, 534)
        Me.qr_code_2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.qr_code_2.Name = "qr_code_2"
        Me.qr_code_2.Size = New System.Drawing.Size(84, 26)
        Me.qr_code_2.TabIndex = 51
        Me.qr_code_2.TabStop = False
        Me.qr_code_2.Visible = False
        '
        'qr_code_3
        '
        Me.qr_code_3.BackColor = System.Drawing.Color.Transparent
        Me.qr_code_3.Location = New System.Drawing.Point(419, 534)
        Me.qr_code_3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.qr_code_3.Name = "qr_code_3"
        Me.qr_code_3.Size = New System.Drawing.Size(84, 26)
        Me.qr_code_3.TabIndex = 52
        Me.qr_code_3.TabStop = False
        Me.qr_code_3.Visible = False
        '
        'succes
        '
        Me.succes.BackColor = System.Drawing.Color.White
        Me.succes.Image = CType(resources.GetObject("succes.Image"), System.Drawing.Image)
        Me.succes.Location = New System.Drawing.Point(148, 119)
        Me.succes.Name = "succes"
        Me.succes.Size = New System.Drawing.Size(505, 363)
        Me.succes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.succes.TabIndex = 53
        Me.succes.TabStop = False
        Me.succes.Visible = False
        '
        'slide
        '
        Me.slide.Image = CType(resources.GetObject("slide.Image"), System.Drawing.Image)
        Me.slide.Location = New System.Drawing.Point(609, 502)
        Me.slide.Name = "slide"
        Me.slide.Size = New System.Drawing.Size(124, 45)
        Me.slide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.slide.TabIndex = 54
        Me.slide.TabStop = False
        '
        'reprint
        '
        Me.reprint.Image = CType(resources.GetObject("reprint.Image"), System.Drawing.Image)
        Me.reprint.Location = New System.Drawing.Point(609, 502)
        Me.reprint.Name = "reprint"
        Me.reprint.Size = New System.Drawing.Size(124, 94)
        Me.reprint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.reprint.TabIndex = 55
        Me.reprint.TabStop = False
        Me.reprint.Visible = False
        '
        'log_reprint_form
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoValidate = System.Windows.Forms.AutoValidate.Disable
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.Controls.Add(Me.reprint)
        Me.Controls.Add(Me.slide)
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
        Me.Controls.Add(Me.alert)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.data_combobox)
        Me.Controls.Add(Me.lot)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.qty)
        Me.Controls.Add(Me.box)
        Me.Controls.Add(Me.part_no)
        Me.Controls.Add(Me.seq)
        Me.Controls.Add(Me.line)
        Me.Font = New System.Drawing.Font("Bahnschrift Condensed", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "log_reprint_form"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.alert, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.qr_code_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.qr_code_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.qr_code_3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.succes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.slide, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.reprint, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents line As Label
    Friend WithEvents seq As Label
    Friend WithEvents part_no As Label
    Friend WithEvents box As Label
    Friend WithEvents qty As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ListView1 As ListView
    Friend WithEvents no As ColumnHeader
    Friend WithEvents log_part_no As ColumnHeader
    Friend WithEvents log_lot As ColumnHeader
    Friend WithEvents lot As Label
    Friend WithEvents log_line As ColumnHeader
    Friend WithEvents log_box_no As ColumnHeader
    Friend WithEvents log_qty As ColumnHeader
    Friend WithEvents log_seq As ColumnHeader
    Friend WithEvents data_combobox As Label
    Friend WithEvents alert As PictureBox
    Friend WithEvents lb_font1 As Label
    Friend WithEvents lb_font2 As Label
    Friend WithEvents lb_font3 As Label
    Friend WithEvents lb_font4 As Label
    Friend WithEvents lb_font5 As Label
    Friend WithEvents lb_font6 As Label
    Friend WithEvents font_part_name As Label
    Friend WithEvents plandate As Label
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents qr_code_1 As PictureBox
    Friend WithEvents qr_code_2 As PictureBox
    Friend WithEvents qr_code_3 As PictureBox
    Friend WithEvents succes As PictureBox
    Friend WithEvents slide As PictureBox
    Friend WithEvents reprint As PictureBox
    Friend WithEvents ref_menu_id As ColumnHeader
End Class
