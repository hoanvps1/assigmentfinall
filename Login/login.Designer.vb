<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.xoa = New System.Windows.Forms.Button()
        Me.thoat = New System.Windows.Forms.Button()
        Me.dangnhap = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pass = New System.Windows.Forms.TextBox()
        Me.user = New System.Windows.Forms.TextBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'xoa
        '
        Me.xoa.BackColor = System.Drawing.Color.Transparent
        Me.xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.xoa.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.xoa.Location = New System.Drawing.Point(103, 67)
        Me.xoa.Name = "xoa"
        Me.xoa.Size = New System.Drawing.Size(84, 28)
        Me.xoa.TabIndex = 13
        Me.xoa.Text = "Xóa trăng"
        Me.xoa.UseVisualStyleBackColor = False
        '
        'thoat
        '
        Me.thoat.BackColor = System.Drawing.Color.Transparent
        Me.thoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.thoat.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.thoat.Location = New System.Drawing.Point(452, 6)
        Me.thoat.Name = "thoat"
        Me.thoat.Size = New System.Drawing.Size(23, 21)
        Me.thoat.TabIndex = 12
        Me.thoat.Text = "X"
        Me.thoat.UseVisualStyleBackColor = False
        '
        'dangnhap
        '
        Me.dangnhap.BackColor = System.Drawing.Color.Transparent
        Me.dangnhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.dangnhap.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.dangnhap.Location = New System.Drawing.Point(13, 67)
        Me.dangnhap.Name = "dangnhap"
        Me.dangnhap.Size = New System.Drawing.Size(84, 28)
        Me.dangnhap.TabIndex = 11
        Me.dangnhap.Text = "Đăng Nhập"
        Me.dangnhap.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(225, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Mật Khẩu"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(13, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Tài khoản"
        '
        'pass
        '
        Me.pass.Location = New System.Drawing.Point(228, 30)
        Me.pass.Name = "pass"
        Me.pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.pass.Size = New System.Drawing.Size(174, 20)
        Me.pass.TabIndex = 8
        '
        'user
        '
        Me.user.Location = New System.Drawing.Point(13, 30)
        Me.user.Name = "user"
        Me.user.Size = New System.Drawing.Size(174, 20)
        Me.user.TabIndex = 7
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 111)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(476, 22)
        Me.StatusStrip1.TabIndex = 14
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(49, 17)
        Me.ToolStripStatusLabel1.Text = "00:00:00"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(476, 133)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.xoa)
        Me.Controls.Add(Me.thoat)
        Me.Controls.Add(Me.dangnhap)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pass)
        Me.Controls.Add(Me.user)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.Text = "Bảng Đăng Nhập"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents xoa As System.Windows.Forms.Button
    Friend WithEvents thoat As System.Windows.Forms.Button
    Friend WithEvents dangnhap As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pass As System.Windows.Forms.TextBox
    Friend WithEvents user As System.Windows.Forms.TextBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
