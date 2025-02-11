<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class newfa_reprint_form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(newfa_reprint_form))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.wi_newfa = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.actaul_newfa = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.box_newfa = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.seq_newfa = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.qty_newfa = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lot_newfa = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.shift_newfa = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.qrcode_newfa = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.status = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.fa_id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.re_id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.lb_font1 = New System.Windows.Forms.Label()
        Me.lb_font2 = New System.Windows.Forms.Label()
        Me.lb_font3 = New System.Windows.Forms.Label()
        Me.qr_code_1 = New System.Windows.Forms.PictureBox()
        Me.qr_code_2 = New System.Windows.Forms.PictureBox()
        Me.qr_code_3 = New System.Windows.Forms.PictureBox()
        Me.lb_font4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lb_font6 = New System.Windows.Forms.Label()
        Me.font_part_name = New System.Windows.Forms.Label()
        Me.lb_font5 = New System.Windows.Forms.Label()
        Me.plandate = New System.Windows.Forms.Label()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.alert = New System.Windows.Forms.PictureBox()
        Me.succes = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.qr_code_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.qr_code_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.qr_code_3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.alert, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.succes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Location = New System.Drawing.Point(1, 550)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(99, 46)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.Color.White
        Me.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.wi_newfa, Me.actaul_newfa, Me.box_newfa, Me.seq_newfa, Me.qty_newfa, Me.lot_newfa, Me.shift_newfa, Me.qrcode_newfa, Me.status, Me.fa_id, Me.re_id})
        Me.ListView1.Font = New System.Drawing.Font("Bahnschrift Condensed", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.FullRowSelect = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(100, 100)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(598, 444)
        Me.ListView1.TabIndex = 1
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'wi_newfa
        '
        Me.wi_newfa.Text = "WI"
        Me.wi_newfa.Width = 120
        '
        'actaul_newfa
        '
        Me.actaul_newfa.Text = "ACTUAL DATE"
        Me.actaul_newfa.Width = 151
        '
        'box_newfa
        '
        Me.box_newfa.Text = "BOX NO."
        Me.box_newfa.Width = 87
        '
        'seq_newfa
        '
        Me.seq_newfa.Text = "SEQ."
        Me.seq_newfa.Width = 67
        '
        'qty_newfa
        '
        Me.qty_newfa.Text = "QTY."
        Me.qty_newfa.Width = 78
        '
        'lot_newfa
        '
        Me.lot_newfa.Text = "LOT NO."
        Me.lot_newfa.Width = 96
        '
        'shift_newfa
        '
        Me.shift_newfa.Text = "SHIFT"
        Me.shift_newfa.Width = 0
        '
        'qrcode_newfa
        '
        Me.qrcode_newfa.Text = "QR-CODE"
        Me.qrcode_newfa.Width = 0
        '
        'status
        '
        Me.status.Text = "status"
        Me.status.Width = 0
        '
        'fa_id
        '
        Me.fa_id.Text = "fa"
        Me.fa_id.Width = 0
        '
        're_id
        '
        Me.re_id.Text = "re"
        Me.re_id.Width = 0
        '
        'PrintDocument1
        '
        '
        'lb_font1
        '
        Me.lb_font1.AutoSize = True
        Me.lb_font1.Font = New System.Drawing.Font("Arial", 8.5!)
        Me.lb_font1.Location = New System.Drawing.Point(126, 26)
        Me.lb_font1.Name = "lb_font1"
        Me.lb_font1.Size = New System.Drawing.Size(0, 17)
        Me.lb_font1.TabIndex = 26
        '
        'lb_font2
        '
        Me.lb_font2.AutoSize = True
        Me.lb_font2.Font = New System.Drawing.Font("Consolas", 21.5!, System.Drawing.FontStyle.Bold)
        Me.lb_font2.Location = New System.Drawing.Point(160, 26)
        Me.lb_font2.Name = "lb_font2"
        Me.lb_font2.Size = New System.Drawing.Size(0, 42)
        Me.lb_font2.TabIndex = 27
        '
        'lb_font3
        '
        Me.lb_font3.AutoSize = True
        Me.lb_font3.Font = New System.Drawing.Font("Arial Narrow", 15.0!, System.Drawing.FontStyle.Bold)
        Me.lb_font3.Location = New System.Drawing.Point(166, 26)
        Me.lb_font3.Name = "lb_font3"
        Me.lb_font3.Size = New System.Drawing.Size(0, 30)
        Me.lb_font3.TabIndex = 28
        '
        'qr_code_1
        '
        Me.qr_code_1.BackColor = System.Drawing.Color.Transparent
        Me.qr_code_1.Location = New System.Drawing.Point(117, 26)
        Me.qr_code_1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.qr_code_1.Name = "qr_code_1"
        Me.qr_code_1.Size = New System.Drawing.Size(84, 26)
        Me.qr_code_1.TabIndex = 51
        Me.qr_code_1.TabStop = False
        Me.qr_code_1.Visible = False
        '
        'qr_code_2
        '
        Me.qr_code_2.BackColor = System.Drawing.Color.Transparent
        Me.qr_code_2.Location = New System.Drawing.Point(117, 26)
        Me.qr_code_2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.qr_code_2.Name = "qr_code_2"
        Me.qr_code_2.Size = New System.Drawing.Size(84, 26)
        Me.qr_code_2.TabIndex = 52
        Me.qr_code_2.TabStop = False
        Me.qr_code_2.Visible = False
        '
        'qr_code_3
        '
        Me.qr_code_3.BackColor = System.Drawing.Color.Transparent
        Me.qr_code_3.Location = New System.Drawing.Point(117, 26)
        Me.qr_code_3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.qr_code_3.Name = "qr_code_3"
        Me.qr_code_3.Size = New System.Drawing.Size(84, 26)
        Me.qr_code_3.TabIndex = 53
        Me.qr_code_3.TabStop = False
        Me.qr_code_3.Visible = False
        '
        'lb_font4
        '
        Me.lb_font4.AutoSize = True
        Me.lb_font4.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.lb_font4.Location = New System.Drawing.Point(66, 33)
        Me.lb_font4.Name = "lb_font4"
        Me.lb_font4.Size = New System.Drawing.Size(0, 19)
        Me.lb_font4.TabIndex = 54
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(154, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 19)
        Me.Label1.TabIndex = 55
        '
        'lb_font6
        '
        Me.lb_font6.AutoSize = True
        Me.lb_font6.Font = New System.Drawing.Font("Arial", 9.5!)
        Me.lb_font6.Location = New System.Drawing.Point(201, 33)
        Me.lb_font6.Name = "lb_font6"
        Me.lb_font6.Size = New System.Drawing.Size(0, 18)
        Me.lb_font6.TabIndex = 56
        '
        'font_part_name
        '
        Me.font_part_name.AutoSize = True
        Me.font_part_name.Font = New System.Drawing.Font("Consolas", 21.5!, System.Drawing.FontStyle.Bold)
        Me.font_part_name.Location = New System.Drawing.Point(44, 26)
        Me.font_part_name.Name = "font_part_name"
        Me.font_part_name.Size = New System.Drawing.Size(0, 42)
        Me.font_part_name.TabIndex = 57
        '
        'lb_font5
        '
        Me.lb_font5.AutoSize = True
        Me.lb_font5.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lb_font5.Location = New System.Drawing.Point(44, 427)
        Me.lb_font5.Name = "lb_font5"
        Me.lb_font5.Size = New System.Drawing.Size(0, 23)
        Me.lb_font5.TabIndex = 58
        '
        'plandate
        '
        Me.plandate.AutoSize = True
        Me.plandate.Font = New System.Drawing.Font("Arial", 19.5!, System.Drawing.FontStyle.Bold)
        Me.plandate.Location = New System.Drawing.Point(50, 47)
        Me.plandate.Name = "plandate"
        Me.plandate.Size = New System.Drawing.Size(0, 38)
        Me.plandate.TabIndex = 59
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
        'alert
        '
        Me.alert.BackColor = System.Drawing.Color.White
        Me.alert.Image = CType(resources.GetObject("alert.Image"), System.Drawing.Image)
        Me.alert.Location = New System.Drawing.Point(146, 146)
        Me.alert.Name = "alert"
        Me.alert.Size = New System.Drawing.Size(505, 363)
        Me.alert.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.alert.TabIndex = 60
        Me.alert.TabStop = False
        Me.alert.Visible = False
        '
        'succes
        '
        Me.succes.BackColor = System.Drawing.Color.White
        Me.succes.Image = CType(resources.GetObject("succes.Image"), System.Drawing.Image)
        Me.succes.Location = New System.Drawing.Point(147, 146)
        Me.succes.Name = "succes"
        Me.succes.Size = New System.Drawing.Size(505, 363)
        Me.succes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.succes.TabIndex = 61
        Me.succes.TabStop = False
        Me.succes.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(599, 543)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(116, 54)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 62
        Me.PictureBox2.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(91, 524)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(618, 23)
        Me.Panel1.TabIndex = 63
        '
        'newfa_reprint_form
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.succes)
        Me.Controls.Add(Me.alert)
        Me.Controls.Add(Me.plandate)
        Me.Controls.Add(Me.lb_font5)
        Me.Controls.Add(Me.font_part_name)
        Me.Controls.Add(Me.lb_font6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lb_font4)
        Me.Controls.Add(Me.qr_code_3)
        Me.Controls.Add(Me.qr_code_2)
        Me.Controls.Add(Me.qr_code_1)
        Me.Controls.Add(Me.lb_font3)
        Me.Controls.Add(Me.lb_font2)
        Me.Controls.Add(Me.lb_font1)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "newfa_reprint_form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.qr_code_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.qr_code_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.qr_code_3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.alert, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.succes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ListView1 As ListView
    Friend WithEvents wi_newfa As ColumnHeader
    Friend WithEvents actaul_newfa As ColumnHeader
    Friend WithEvents box_newfa As ColumnHeader
    Friend WithEvents seq_newfa As ColumnHeader
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents lb_font1 As Label
    Friend WithEvents lb_font2 As Label
    Friend WithEvents lb_font3 As Label
    Friend WithEvents qr_code_1 As PictureBox
    Friend WithEvents qr_code_2 As PictureBox
    Friend WithEvents qr_code_3 As PictureBox
    Friend WithEvents lb_font4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lb_font6 As Label
    Friend WithEvents font_part_name As Label
    Friend WithEvents lb_font5 As Label
    Friend WithEvents plandate As Label
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents alert As PictureBox
    Friend WithEvents succes As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents qty_newfa As ColumnHeader
    Friend WithEvents lot_newfa As ColumnHeader
    Friend WithEvents shift_newfa As ColumnHeader
    Friend WithEvents Panel1 As Panel
    Friend WithEvents qrcode_newfa As ColumnHeader
    Friend WithEvents status As ColumnHeader
    Friend WithEvents fa_id As ColumnHeader
    Friend WithEvents re_id As ColumnHeader
End Class
