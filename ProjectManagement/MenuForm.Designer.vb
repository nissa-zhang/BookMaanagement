﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LendButton = New System.Windows.Forms.Button()
        Me.ReturnButton = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BookmasterButton = New System.Windows.Forms.Button()
        Me.ExportButton = New System.Windows.Forms.Button()
        Me.StaffButton = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.QuitButton = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(45, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(233, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "新宿図書館ABCシステム"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.Controls.Add(Me.LendButton)
        Me.Panel1.Controls.Add(Me.ReturnButton)
        Me.Panel1.Location = New System.Drawing.Point(28, 75)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(135, 169)
        Me.Panel1.TabIndex = 1
        '
        'LendButton
        '
        Me.LendButton.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.LendButton.Location = New System.Drawing.Point(3, 11)
        Me.LendButton.Name = "LendButton"
        Me.LendButton.Size = New System.Drawing.Size(129, 63)
        Me.LendButton.TabIndex = 7
        Me.LendButton.Text = "書籍貸出"
        Me.LendButton.UseVisualStyleBackColor = True
        '
        'ReturnButton
        '
        Me.ReturnButton.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.ReturnButton.Location = New System.Drawing.Point(3, 87)
        Me.ReturnButton.Name = "ReturnButton"
        Me.ReturnButton.Size = New System.Drawing.Size(129, 65)
        Me.ReturnButton.TabIndex = 6
        Me.ReturnButton.Text = "書籍返却"
        Me.ReturnButton.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel2.Controls.Add(Me.BookmasterButton)
        Me.Panel2.Controls.Add(Me.ExportButton)
        Me.Panel2.Location = New System.Drawing.Point(169, 75)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(137, 169)
        Me.Panel2.TabIndex = 2
        '
        'BookmasterButton
        '
        Me.BookmasterButton.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.BookmasterButton.Location = New System.Drawing.Point(5, 11)
        Me.BookmasterButton.Name = "BookmasterButton"
        Me.BookmasterButton.Size = New System.Drawing.Size(126, 63)
        Me.BookmasterButton.TabIndex = 3
        Me.BookmasterButton.Text = "書籍マスター"
        Me.BookmasterButton.UseVisualStyleBackColor = True
        '
        'ExportButton
        '
        Me.ExportButton.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.ExportButton.Location = New System.Drawing.Point(6, 87)
        Me.ExportButton.Name = "ExportButton"
        Me.ExportButton.Size = New System.Drawing.Size(126, 65)
        Me.ExportButton.TabIndex = 4
        Me.ExportButton.Text = "書籍貸出・返却の記録"
        Me.ExportButton.UseVisualStyleBackColor = True
        '
        'StaffButton
        '
        Me.StaffButton.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.StaffButton.Location = New System.Drawing.Point(5, 13)
        Me.StaffButton.Name = "StaffButton"
        Me.StaffButton.Size = New System.Drawing.Size(126, 61)
        Me.StaffButton.TabIndex = 1
        Me.StaffButton.Text = "スタッフマスター"
        Me.StaffButton.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel3.Controls.Add(Me.StaffButton)
        Me.Panel3.Location = New System.Drawing.Point(312, 75)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(134, 169)
        Me.Panel3.TabIndex = 3
        '
        'QuitButton
        '
        Me.QuitButton.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.QuitButton.Location = New System.Drawing.Point(360, 23)
        Me.QuitButton.Name = "QuitButton"
        Me.QuitButton.Size = New System.Drawing.Size(72, 29)
        Me.QuitButton.TabIndex = 4
        Me.QuitButton.Text = "終了"
        Me.QuitButton.UseVisualStyleBackColor = True
        '
        'MenuForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(465, 289)
        Me.Controls.Add(Me.QuitButton)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "MenuForm"
        Me.Text = "メインメニュー"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BookmasterButton As Button
    Friend WithEvents StaffButton As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents ExportButton As Button
    Friend WithEvents QuitButton As Button
    Friend WithEvents ReturnButton As Button
    Friend WithEvents LendButton As Button
End Class
