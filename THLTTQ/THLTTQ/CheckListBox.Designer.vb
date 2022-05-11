<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CheckListBox
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
        Me.List_checkBox = New System.Windows.Forms.CheckedListBox()
        Me.Buton1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.soThich_Label = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'List_checkBox
        '
        Me.List_checkBox.Font = New System.Drawing.Font("Harrington", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.List_checkBox.FormattingEnabled = True
        Me.List_checkBox.Location = New System.Drawing.Point(42, 73)
        Me.List_checkBox.Name = "List_checkBox"
        Me.List_checkBox.Size = New System.Drawing.Size(288, 334)
        Me.List_checkBox.TabIndex = 0
        '
        'Buton1
        '
        Me.Buton1.Font = New System.Drawing.Font("Harrington", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Buton1.Location = New System.Drawing.Point(303, 499)
        Me.Buton1.Name = "Buton1"
        Me.Buton1.Size = New System.Drawing.Size(252, 42)
        Me.Buton1.TabIndex = 1
        Me.Buton1.Text = "Chọn danh sách"
        Me.Buton1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Harrington", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(477, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(260, 27)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Danh sách được lựa chọn:"
        '
        'soThich_Label
        '
        Me.soThich_Label.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.soThich_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.soThich_Label.Location = New System.Drawing.Point(492, 119)
        Me.soThich_Label.Name = "soThich_Label"
        Me.soThich_Label.Size = New System.Drawing.Size(245, 315)
        Me.soThich_Label.TabIndex = 3
        '
        'CheckListBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 573)
        Me.Controls.Add(Me.soThich_Label)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Buton1)
        Me.Controls.Add(Me.List_checkBox)
        Me.Name = "CheckListBox"
        Me.Text = "CheckListBox"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents List_checkBox As CheckedListBox
    Friend WithEvents Buton1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents soThich_Label As Label
End Class
