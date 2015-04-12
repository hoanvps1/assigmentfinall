<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class nhanvien
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(nhanvien))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt1 = New System.Windows.Forms.TextBox()
        Me.txt2 = New System.Windows.Forms.TextBox()
        Me.pass = New System.Windows.Forms.Label()
        Me.txt3 = New System.Windows.Forms.TextBox()
        Me.user = New System.Windows.Forms.Label()
        Me.manhanvien = New System.Windows.Forms.Label()
        Me.thoat = New System.Windows.Forms.Button()
        Me.sua = New System.Windows.Forms.Button()
        Me.xoa = New System.Windows.Forms.Button()
        Me.them = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.thongbaonv = New System.Windows.Forms.DataGridView()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.thongbaonv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.txt1)
        Me.GroupBox1.Controls.Add(Me.txt2)
        Me.GroupBox1.Controls.Add(Me.pass)
        Me.GroupBox1.Controls.Add(Me.txt3)
        Me.GroupBox1.Controls.Add(Me.user)
        Me.GroupBox1.Controls.Add(Me.manhanvien)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Location = New System.Drawing.Point(199, 36)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(435, 99)
        Me.GroupBox1.TabIndex = 37
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Các giá trị"
        '
        'txt1
        '
        Me.txt1.Location = New System.Drawing.Point(151, 16)
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(278, 20)
        Me.txt1.TabIndex = 35
        '
        'txt2
        '
        Me.txt2.Location = New System.Drawing.Point(151, 42)
        Me.txt2.Name = "txt2"
        Me.txt2.Size = New System.Drawing.Size(278, 20)
        Me.txt2.TabIndex = 36
        '
        'pass
        '
        Me.pass.AutoSize = True
        Me.pass.BackColor = System.Drawing.Color.Transparent
        Me.pass.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.pass.Location = New System.Drawing.Point(6, 71)
        Me.pass.Name = "pass"
        Me.pass.Size = New System.Drawing.Size(53, 13)
        Me.pass.TabIndex = 42
        Me.pass.Text = "Mật Khẩu"
        '
        'txt3
        '
        Me.txt3.Location = New System.Drawing.Point(151, 68)
        Me.txt3.Name = "txt3"
        Me.txt3.Size = New System.Drawing.Size(278, 20)
        Me.txt3.TabIndex = 37
        '
        'user
        '
        Me.user.AutoSize = True
        Me.user.BackColor = System.Drawing.Color.Transparent
        Me.user.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.user.Location = New System.Drawing.Point(6, 45)
        Me.user.Name = "user"
        Me.user.Size = New System.Drawing.Size(84, 13)
        Me.user.TabIndex = 41
        Me.user.Text = "Tên Đăng Nhập"
        '
        'manhanvien
        '
        Me.manhanvien.AutoSize = True
        Me.manhanvien.BackColor = System.Drawing.Color.Transparent
        Me.manhanvien.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.manhanvien.Location = New System.Drawing.Point(6, 19)
        Me.manhanvien.Name = "manhanvien"
        Me.manhanvien.Size = New System.Drawing.Size(75, 13)
        Me.manhanvien.TabIndex = 40
        Me.manhanvien.Text = "Mã Nhân Viên"
        '
        'thoat
        '
        Me.thoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.thoat.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.thoat.Location = New System.Drawing.Point(333, 19)
        Me.thoat.Name = "thoat"
        Me.thoat.Size = New System.Drawing.Size(26, 23)
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
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.thoat)
        Me.GroupBox2.Controls.Add(Me.sua)
        Me.GroupBox2.Controls.Add(Me.xoa)
        Me.GroupBox2.Controls.Add(Me.them)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox2.Location = New System.Drawing.Point(266, 141)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(368, 49)
        Me.GroupBox2.TabIndex = 38
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Menu"
        '
        'thongbaonv
        '
        Me.thongbaonv.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.thongbaonv.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.thongbaonv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.thongbaonv.Location = New System.Drawing.Point(199, 206)
        Me.thongbaonv.Name = "thongbaonv"
        Me.thongbaonv.Size = New System.Drawing.Size(435, 123)
        Me.thongbaonv.TabIndex = 36
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(31, 67)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(122, 123)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 39
        Me.PictureBox4.TabStop = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 335)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(639, 22)
        Me.StatusStrip1.TabIndex = 40
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(49, 17)
        Me.ToolStripStatusLabel1.Text = "00:00:00"
        '
        'Timer1
        '
        '
        'nhanvien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(639, 357)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.thongbaonv)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "nhanvien"
        Me.Text = "Bảng Nhân Viên"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.thongbaonv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt1 As System.Windows.Forms.TextBox
    Friend WithEvents txt2 As System.Windows.Forms.TextBox
    Friend WithEvents pass As System.Windows.Forms.Label
    Friend WithEvents txt3 As System.Windows.Forms.TextBox
    Friend WithEvents user As System.Windows.Forms.Label
    Friend WithEvents manhanvien As System.Windows.Forms.Label
    Friend WithEvents thoat As System.Windows.Forms.Button
    Friend WithEvents sua As System.Windows.Forms.Button
    Friend WithEvents xoa As System.Windows.Forms.Button
    Friend WithEvents them As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents thongbaonv As System.Windows.Forms.DataGridView
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
