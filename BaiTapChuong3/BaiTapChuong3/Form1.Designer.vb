<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tb_canhDay = New System.Windows.Forms.TextBox()
        Me.tb_chieuCao = New System.Windows.Forms.TextBox()
        Me.bt_tinhTong = New System.Windows.Forms.Button()
        Me.bt_tinhTong3Canh = New System.Windows.Forms.Button()
        Me.tb_canh2 = New System.Windows.Forms.TextBox()
        Me.tb_canh1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tb_canh3 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lb_kq1 = New System.Windows.Forms.Label()
        Me.lb_ketQua = New System.Windows.Forms.Label()
        Me.lb_ketQua2 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(28, 36)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(916, 651)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Turquoise
        Me.TabPage1.Controls.Add(Me.lb_ketQua2)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.tb_canh3)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.bt_tinhTong3Canh)
        Me.TabPage1.Controls.Add(Me.tb_canh2)
        Me.TabPage1.Controls.Add(Me.tb_canh1)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(908, 622)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Tính diện tích "
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.lb_ketQua)
        Me.TabPage2.Controls.Add(Me.lb_kq1)
        Me.TabPage2.Controls.Add(Me.bt_tinhTong)
        Me.TabPage2.Controls.Add(Me.tb_chieuCao)
        Me.TabPage2.Controls.Add(Me.tb_canhDay)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(908, 622)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Tính diện tích tam giác"
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TabPage3.Controls.Add(Me.Label9)
        Me.TabPage3.Controls.Add(Me.Button3)
        Me.TabPage3.Controls.Add(Me.TextBox6)
        Me.TabPage3.Controls.Add(Me.Label7)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(908, 622)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Tính tổng"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(48, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(842, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "TÍNH DIỆN TÍCH TAM GIÁC KHI BIẾT CẠNH ĐÁY VÀ CHIỀU CAO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Harrington", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(112, 238)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(268, 27)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nhập vào độ dài cạch đáy:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Harrington", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(163, 309)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(211, 27)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nhập vào chiều cao:"
        '
        'tb_canhDay
        '
        Me.tb_canhDay.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_canhDay.Location = New System.Drawing.Point(386, 238)
        Me.tb_canhDay.Name = "tb_canhDay"
        Me.tb_canhDay.Size = New System.Drawing.Size(318, 34)
        Me.tb_canhDay.TabIndex = 3
        '
        'tb_chieuCao
        '
        Me.tb_chieuCao.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_chieuCao.Location = New System.Drawing.Point(386, 309)
        Me.tb_chieuCao.Name = "tb_chieuCao"
        Me.tb_chieuCao.Size = New System.Drawing.Size(318, 34)
        Me.tb_chieuCao.TabIndex = 4
        '
        'bt_tinhTong
        '
        Me.bt_tinhTong.Font = New System.Drawing.Font("Harrington", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_tinhTong.Location = New System.Drawing.Point(349, 528)
        Me.bt_tinhTong.Name = "bt_tinhTong"
        Me.bt_tinhTong.Size = New System.Drawing.Size(249, 64)
        Me.bt_tinhTong.TabIndex = 5
        Me.bt_tinhTong.Text = "Tính tổng"
        Me.bt_tinhTong.UseVisualStyleBackColor = True
        '
        'bt_tinhTong3Canh
        '
        Me.bt_tinhTong3Canh.Font = New System.Drawing.Font("Harrington", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_tinhTong3Canh.Location = New System.Drawing.Point(317, 527)
        Me.bt_tinhTong3Canh.Name = "bt_tinhTong3Canh"
        Me.bt_tinhTong3Canh.Size = New System.Drawing.Size(227, 64)
        Me.bt_tinhTong3Canh.TabIndex = 10
        Me.bt_tinhTong3Canh.Text = "Tính Tổng"
        Me.bt_tinhTong3Canh.UseVisualStyleBackColor = True
        '
        'tb_canh2
        '
        Me.tb_canh2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_canh2.Location = New System.Drawing.Point(482, 265)
        Me.tb_canh2.Name = "tb_canh2"
        Me.tb_canh2.Size = New System.Drawing.Size(318, 34)
        Me.tb_canh2.TabIndex = 9
        '
        'tb_canh1
        '
        Me.tb_canh1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_canh1.Location = New System.Drawing.Point(482, 192)
        Me.tb_canh1.Name = "tb_canh1"
        Me.tb_canh1.Size = New System.Drawing.Size(318, 34)
        Me.tb_canh1.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Harrington", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(154, 269)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(312, 27)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Nhập vào chiều dài cạnh thứ 2:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Harrington", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(154, 199)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(308, 27)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Nhập vào chiều dài cạnh thứ 1:"
        '
        'tb_canh3
        '
        Me.tb_canh3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_canh3.Location = New System.Drawing.Point(482, 334)
        Me.tb_canh3.Name = "tb_canh3"
        Me.tb_canh3.Size = New System.Drawing.Size(318, 34)
        Me.tb_canh3.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Harrington", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(154, 338)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(313, 27)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Nhập vào chiều dài cạnh thứ 3:"
        '
        'TextBox6
        '
        Me.TextBox6.Font = New System.Drawing.Font("Harrington", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.Location = New System.Drawing.Point(377, 267)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(318, 35)
        Me.TextBox6.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Harrington", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(214, 270)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(157, 27)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Nhập vào số n:"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(318, 479)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(308, 64)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label8.Location = New System.Drawing.Point(96, 72)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(744, 29)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "TÍNH DIỆN TÍCH CỦA TAM GIÁC KHI BIẾT CHIỀU DÀI CỦA 3 CẠNH"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(311, 91)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(279, 42)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "TÍNH TỔNG S "
        '
        'lb_kq1
        '
        Me.lb_kq1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_kq1.Location = New System.Drawing.Point(305, 443)
        Me.lb_kq1.Name = "lb_kq1"
        Me.lb_kq1.Size = New System.Drawing.Size(121, 40)
        Me.lb_kq1.TabIndex = 6
        Me.lb_kq1.Text = "Kết quả:"
        Me.lb_kq1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lb_ketQua
        '
        Me.lb_ketQua.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lb_ketQua.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_ketQua.Location = New System.Drawing.Point(452, 448)
        Me.lb_ketQua.Name = "lb_ketQua"
        Me.lb_ketQua.Size = New System.Drawing.Size(157, 39)
        Me.lb_ketQua.TabIndex = 7
        Me.lb_ketQua.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lb_ketQua2
        '
        Me.lb_ketQua2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lb_ketQua2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_ketQua2.Location = New System.Drawing.Point(459, 418)
        Me.lb_ketQua2.Name = "lb_ketQua2"
        Me.lb_ketQua2.Size = New System.Drawing.Size(157, 39)
        Me.lb_ketQua2.TabIndex = 15
        Me.lb_ketQua2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(312, 413)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(121, 40)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "Kết quả:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(956, 699)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents bt_tinhTong As Button
    Friend WithEvents tb_chieuCao As TextBox
    Friend WithEvents tb_canhDay As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents tb_canh3 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents bt_tinhTong3Canh As Button
    Friend WithEvents tb_canh2 As TextBox
    Friend WithEvents tb_canh1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Button3 As Button
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents lb_kq1 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lb_ketQua As Label
    Friend WithEvents lb_ketQua2 As Label
    Friend WithEvents Label11 As Label
End Class
