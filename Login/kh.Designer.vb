<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class kh
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(kh))
        Me.txt2 = New System.Windows.Forms.TextBox()
        Me.thongbaokh = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt1 = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txt3 = New System.Windows.Forms.TextBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.txt4 = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.thoat = New System.Windows.Forms.Button()
        Me.sua = New System.Windows.Forms.Button()
        Me.xoa = New System.Windows.Forms.Button()
        Me.them = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.thongbaokh, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt2
        '
        Me.txt2.Location = New System.Drawing.Point(6, 26)
        Me.txt2.Name = "txt2"
        Me.txt2.Size = New System.Drawing.Size(100, 20)
        Me.txt2.TabIndex = 3
        '
        'thongbaokh
        '
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.thongbaokh.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.thongbaokh.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.thongbaokh.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.thongbaokh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.thongbaokh.Location = New System.Drawing.Point(156, 12)
        Me.thongbaokh.Name = "thongbaokh"
        Me.thongbaokh.Size = New System.Drawing.Size(326, 192)
        Me.thongbaokh.TabIndex = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.txt1)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Location = New System.Drawing.Point(12, 230)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(113, 52)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mã Khách Hàng"
        '
        'txt1
        '
        Me.txt1.Location = New System.Drawing.Point(6, 26)
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(100, 20)
        Me.txt1.TabIndex = 2
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.txt2)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox2.Location = New System.Drawing.Point(131, 230)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(113, 52)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Họ Tên Khách Hàng"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.txt3)
        Me.GroupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox3.Location = New System.Drawing.Point(250, 230)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(113, 52)
        Me.GroupBox3.TabIndex = 12
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Số ĐT Khách Hàng"
        '
        'txt3
        '
        Me.txt3.Location = New System.Drawing.Point(7, 26)
        Me.txt3.Name = "txt3"
        Me.txt3.Size = New System.Drawing.Size(100, 20)
        Me.txt3.TabIndex = 5
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox5.Controls.Add(Me.txt4)
        Me.GroupBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox5.Location = New System.Drawing.Point(369, 230)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(113, 52)
        Me.GroupBox5.TabIndex = 14
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Địa chỉ Khách Hàng"
        '
        'txt4
        '
        Me.txt4.Location = New System.Drawing.Point(7, 26)
        Me.txt4.Name = "txt4"
        Me.txt4.Size = New System.Drawing.Size(100, 20)
        Me.txt4.TabIndex = 3
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.thoat)
        Me.GroupBox4.Controls.Add(Me.sua)
        Me.GroupBox4.Controls.Add(Me.xoa)
        Me.GroupBox4.Controls.Add(Me.them)
        Me.GroupBox4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox4.Location = New System.Drawing.Point(12, 288)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(470, 49)
        Me.GroupBox4.TabIndex = 44
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Menu"
        '
        'thoat
        '
        Me.thoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.thoat.ForeColor = System.Drawing.Color.Transparent
        Me.thoat.Location = New System.Drawing.Point(430, 19)
        Me.thoat.Name = "thoat"
        Me.thoat.Size = New System.Drawing.Size(34, 23)
        Me.thoat.TabIndex = 39
        Me.thoat.Text = "X"
        Me.thoat.UseVisualStyleBackColor = True
        '
        'sua
        '
        Me.sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.sua.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.sua.Location = New System.Drawing.Point(99, 19)
        Me.sua.Name = "sua"
        Me.sua.Size = New System.Drawing.Size(75, 23)
        Me.sua.TabIndex = 37
        Me.sua.Text = "Sửa"
        Me.sua.UseVisualStyleBackColor = True
        '
        'xoa
        '
        Me.xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.xoa.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.xoa.Location = New System.Drawing.Point(192, 19)
        Me.xoa.Name = "xoa"
        Me.xoa.Size = New System.Drawing.Size(75, 23)
        Me.xoa.TabIndex = 38
        Me.xoa.Text = "Xóa"
        Me.xoa.UseVisualStyleBackColor = True
        '
        'them
        '
        Me.them.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.them.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.them.Location = New System.Drawing.Point(6, 19)
        Me.them.Name = "them"
        Me.them.Size = New System.Drawing.Size(75, 23)
        Me.them.TabIndex = 36
        Me.them.Text = "Thêm"
        Me.them.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(19, 46)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(106, 108)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 45
        Me.PictureBox1.TabStop = False
        '
        'kh
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(493, 361)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.thongbaokh)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "kh"
        Me.Text = "Form1"
        CType(Me.thongbaokh, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txt2 As System.Windows.Forms.TextBox
    Friend WithEvents thongbaokh As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt1 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txt3 As System.Windows.Forms.TextBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents txt4 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents thoat As System.Windows.Forms.Button
    Friend WithEvents sua As System.Windows.Forms.Button
    Friend WithEvents xoa As System.Windows.Forms.Button
    Friend WithEvents them As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
