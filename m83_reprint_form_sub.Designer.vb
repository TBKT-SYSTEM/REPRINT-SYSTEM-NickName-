<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class m83_reprint_form_sub
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(m83_reprint_form_sub))
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.wi_newfa = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.actaul_newfa = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.box_newfa = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.seq_newfa = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lot_no = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.qty_newfa = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.plan_newfa = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.qr_code_newfa = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.instr = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.shift_newfa = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.log_id_tag = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.font_1 = New System.Windows.Forms.Label()
        Me.Label_wi_type = New System.Windows.Forms.Label()
        Me.font_2 = New System.Windows.Forms.Label()
        Me.font_3 = New System.Windows.Forms.Label()
        Me.font_qty = New System.Windows.Forms.Label()
        Me.font_4 = New System.Windows.Forms.Label()
        Me.font_data = New System.Windows.Forms.Label()
        Me.font_show_data = New System.Windows.Forms.Label()
        Me.succes = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.succes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(599, 543)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(116, 54)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 63
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Location = New System.Drawing.Point(1, 550)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(99, 46)
        Me.PictureBox1.TabIndex = 64
        Me.PictureBox1.TabStop = False
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.Color.White
        Me.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.wi_newfa, Me.actaul_newfa, Me.box_newfa, Me.seq_newfa, Me.lot_no, Me.qty_newfa, Me.plan_newfa, Me.qr_code_newfa, Me.instr, Me.shift_newfa, Me.log_id_tag})
        Me.ListView1.Font = New System.Drawing.Font("Bahnschrift Condensed", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.FullRowSelect = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(101, 93)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(598, 444)
        Me.ListView1.TabIndex = 65
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'wi_newfa
        '
        Me.wi_newfa.Text = "WI"
        Me.wi_newfa.Width = 129
        '
        'actaul_newfa
        '
        Me.actaul_newfa.Text = "ACTUAL DATE"
        Me.actaul_newfa.Width = 134
        '
        'box_newfa
        '
        Me.box_newfa.Text = "BOX NO."
        Me.box_newfa.Width = 100
        '
        'seq_newfa
        '
        Me.seq_newfa.Text = "SEQ."
        Me.seq_newfa.Width = 94
        '
        'lot_no
        '
        Me.lot_no.Text = "LOT NO."
        Me.lot_no.Width = 113
        '
        'qty_newfa
        '
        Me.qty_newfa.Text = "qty"
        Me.qty_newfa.Width = 0
        '
        'plan_newfa
        '
        Me.plan_newfa.Text = "PLAN DATE"
        Me.plan_newfa.Width = 0
        '
        'qr_code_newfa
        '
        Me.qr_code_newfa.Text = "QR CODE"
        Me.qr_code_newfa.Width = 0
        '
        'instr
        '
        Me.instr.Text = "instr_"
        Me.instr.Width = 0
        '
        'shift_newfa
        '
        Me.shift_newfa.Text = "shift"
        Me.shift_newfa.Width = 0
        '
        'log_id_tag
        '
        Me.log_id_tag.Text = "log_id"
        Me.log_id_tag.Width = 0
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
        'font_1
        '
        Me.font_1.AutoSize = True
        Me.font_1.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.font_1.Location = New System.Drawing.Point(12, 9)
        Me.font_1.Name = "font_1"
        Me.font_1.Size = New System.Drawing.Size(0, 27)
        Me.font_1.TabIndex = 66
        Me.font_1.Visible = False
        '
        'Label_wi_type
        '
        Me.Label_wi_type.AutoSize = True
        Me.Label_wi_type.Font = New System.Drawing.Font("Arial", 8.3!)
        Me.Label_wi_type.Location = New System.Drawing.Point(20, 17)
        Me.Label_wi_type.Name = "Label_wi_type"
        Me.Label_wi_type.Size = New System.Drawing.Size(0, 15)
        Me.Label_wi_type.TabIndex = 67
        Me.Label_wi_type.Visible = False
        '
        'font_2
        '
        Me.font_2.AutoSize = True
        Me.font_2.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.font_2.Location = New System.Drawing.Point(73, 17)
        Me.font_2.Name = "font_2"
        Me.font_2.Size = New System.Drawing.Size(0, 14)
        Me.font_2.TabIndex = 68
        Me.font_2.Visible = False
        '
        'font_3
        '
        Me.font_3.AutoSize = True
        Me.font_3.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.font_3.Location = New System.Drawing.Point(98, 28)
        Me.font_3.Name = "font_3"
        Me.font_3.Size = New System.Drawing.Size(0, 16)
        Me.font_3.TabIndex = 69
        Me.font_3.Visible = False
        '
        'font_qty
        '
        Me.font_qty.AutoSize = True
        Me.font_qty.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.font_qty.Location = New System.Drawing.Point(52, 17)
        Me.font_qty.Name = "font_qty"
        Me.font_qty.Size = New System.Drawing.Size(0, 27)
        Me.font_qty.TabIndex = 70
        Me.font_qty.Visible = False
        '
        'font_4
        '
        Me.font_4.AutoSize = True
        Me.font_4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.font_4.Location = New System.Drawing.Point(58, 9)
        Me.font_4.Name = "font_4"
        Me.font_4.Size = New System.Drawing.Size(0, 18)
        Me.font_4.TabIndex = 71
        Me.font_4.Visible = False
        '
        'font_data
        '
        Me.font_data.AutoSize = True
        Me.font_data.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.font_data.Location = New System.Drawing.Point(120, 25)
        Me.font_data.Name = "font_data"
        Me.font_data.Size = New System.Drawing.Size(0, 16)
        Me.font_data.TabIndex = 72
        Me.font_data.Visible = False
        '
        'font_show_data
        '
        Me.font_show_data.AutoSize = True
        Me.font_show_data.Font = New System.Drawing.Font("Arial", 9.5!)
        Me.font_show_data.Location = New System.Drawing.Point(184, 49)
        Me.font_show_data.Name = "font_show_data"
        Me.font_show_data.Size = New System.Drawing.Size(0, 16)
        Me.font_show_data.TabIndex = 73
        Me.font_show_data.Visible = False
        '
        'succes
        '
        Me.succes.BackColor = System.Drawing.Color.White
        Me.succes.Image = CType(resources.GetObject("succes.Image"), System.Drawing.Image)
        Me.succes.Location = New System.Drawing.Point(148, 139)
        Me.succes.Name = "succes"
        Me.succes.Size = New System.Drawing.Size(505, 363)
        Me.succes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.succes.TabIndex = 74
        Me.succes.TabStop = False
        Me.succes.Visible = False
        '
        'm83_reprint_form_sub
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.Controls.Add(Me.succes)
        Me.Controls.Add(Me.font_show_data)
        Me.Controls.Add(Me.font_data)
        Me.Controls.Add(Me.font_4)
        Me.Controls.Add(Me.font_qty)
        Me.Controls.Add(Me.font_3)
        Me.Controls.Add(Me.font_2)
        Me.Controls.Add(Me.Label_wi_type)
        Me.Controls.Add(Me.font_1)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "m83_reprint_form_sub"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "m83_reprint_form"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.succes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ListView1 As ListView
    Friend WithEvents wi_newfa As ColumnHeader
    Friend WithEvents actaul_newfa As ColumnHeader
    Friend WithEvents box_newfa As ColumnHeader
    Friend WithEvents seq_newfa As ColumnHeader
    Friend WithEvents lot_no As ColumnHeader
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents font_1 As Label
    Friend WithEvents Label_wi_type As Label
    Friend WithEvents font_2 As Label
    Friend WithEvents font_3 As Label
    Friend WithEvents qty_newfa As ColumnHeader
    Friend WithEvents font_qty As Label
    Friend WithEvents font_4 As Label
    Friend WithEvents plan_newfa As ColumnHeader
    Friend WithEvents font_data As Label
    Friend WithEvents qr_code_newfa As ColumnHeader
    Friend WithEvents instr As ColumnHeader
    Friend WithEvents shift_newfa As ColumnHeader
    Friend WithEvents log_id_tag As ColumnHeader
    Friend WithEvents font_show_data As Label
    Friend WithEvents succes As PictureBox
End Class
