<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuForm
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BookmasterButton = New System.Windows.Forms.Button()
        Me.ReturnButton = New System.Windows.Forms.Button()
        Me.StaffButton = New System.Windows.Forms.Button()
        Me.ExportButton = New System.Windows.Forms.Button()
        Me.QuitButton = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label1.Location = New System.Drawing.Point(32, 22)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(315, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "新宿図書館図書管理システム"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.SteelBlue
        Me.TextBox1.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(84, 91)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(125, 23)
        Me.TextBox1.TabIndex = 8
        Me.TextBox1.Text = "　　　掲示板"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(49, 106)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(221, 141)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = ""
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.ProjectManagement.My.Resources.Resources.background_blue_flower
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.BookmasterButton)
        Me.Panel1.Controls.Add(Me.ReturnButton)
        Me.Panel1.Controls.Add(Me.StaffButton)
        Me.Panel1.Controls.Add(Me.ExportButton)
        Me.Panel1.Controls.Add(Me.QuitButton)
        Me.Panel1.Location = New System.Drawing.Point(363, 67)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(247, 271)
        Me.Panel1.TabIndex = 10
        '
        'Button2
        '
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(46, 160)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(156, 26)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "返却催促"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(46, 54)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(156, 26)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "検索・照会"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BookmasterButton
        '
        Me.BookmasterButton.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.BookmasterButton.Location = New System.Drawing.Point(46, 88)
        Me.BookmasterButton.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BookmasterButton.Name = "BookmasterButton"
        Me.BookmasterButton.Size = New System.Drawing.Size(156, 26)
        Me.BookmasterButton.TabIndex = 9
        Me.BookmasterButton.Text = "書籍マスター"
        Me.BookmasterButton.UseVisualStyleBackColor = True
        '
        'ReturnButton
        '
        Me.ReturnButton.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.ReturnButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ReturnButton.Location = New System.Drawing.Point(46, 21)
        Me.ReturnButton.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ReturnButton.Name = "ReturnButton"
        Me.ReturnButton.Size = New System.Drawing.Size(156, 26)
        Me.ReturnButton.TabIndex = 12
        Me.ReturnButton.Text = "貸出・返却"
        Me.ReturnButton.UseVisualStyleBackColor = True
        '
        'StaffButton
        '
        Me.StaffButton.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.StaffButton.Location = New System.Drawing.Point(46, 192)
        Me.StaffButton.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.StaffButton.Name = "StaffButton"
        Me.StaffButton.Size = New System.Drawing.Size(156, 26)
        Me.StaffButton.TabIndex = 8
        Me.StaffButton.Text = "スタッフマスター"
        Me.StaffButton.UseVisualStyleBackColor = True
        '
        'ExportButton
        '
        Me.ExportButton.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.ExportButton.Location = New System.Drawing.Point(46, 125)
        Me.ExportButton.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ExportButton.Name = "ExportButton"
        Me.ExportButton.Size = New System.Drawing.Size(156, 26)
        Me.ExportButton.TabIndex = 10
        Me.ExportButton.Text = "貸出・返却記録"
        Me.ExportButton.UseVisualStyleBackColor = True
        '
        'QuitButton
        '
        Me.QuitButton.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.QuitButton.ForeColor = System.Drawing.Color.DarkRed
        Me.QuitButton.Location = New System.Drawing.Point(46, 225)
        Me.QuitButton.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.QuitButton.Name = "QuitButton"
        Me.QuitButton.Size = New System.Drawing.Size(156, 26)
        Me.QuitButton.TabIndex = 11
        Me.QuitButton.Text = "システム終了"
        Me.QuitButton.UseVisualStyleBackColor = True
        '
        'MenuForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.ProjectManagement.My.Resources.Resources.background_blue_flower
        Me.ClientSize = New System.Drawing.Size(662, 350)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("MS UI Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "MenuForm"
        Me.Text = "ホームページ"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BookmasterButton As Button
    Friend WithEvents ReturnButton As Button
    Friend WithEvents StaffButton As Button
    Friend WithEvents ExportButton As Button
    Friend WithEvents QuitButton As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
End Class
