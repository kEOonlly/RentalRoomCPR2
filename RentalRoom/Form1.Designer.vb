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
        Me.pbID = New System.Windows.Forms.PictureBox()
        Me.tbID = New System.Windows.Forms.TextBox()
        Me.tbname = New System.Windows.Forms.TextBox()
        Me.tbsname = New System.Windows.Forms.TextBox()
        Me.tbgender = New System.Windows.Forms.TextBox()
        Me.tbphone = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnmmn = New System.Windows.Forms.Label()
        Me.btnexit = New System.Windows.Forms.Label()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Button7 = New System.Windows.Forms.Button()
        CType(Me.pbID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.SuspendLayout()
        '
        'pbID
        '
        Me.pbID.Location = New System.Drawing.Point(307, 44)
        Me.pbID.Name = "pbID"
        Me.pbID.Size = New System.Drawing.Size(145, 125)
        Me.pbID.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbID.TabIndex = 0
        Me.pbID.TabStop = False
        '
        'tbID
        '
        Me.tbID.Location = New System.Drawing.Point(162, 34)
        Me.tbID.Name = "tbID"
        Me.tbID.Size = New System.Drawing.Size(100, 20)
        Me.tbID.TabIndex = 0
        '
        'tbname
        '
        Me.tbname.Location = New System.Drawing.Point(162, 60)
        Me.tbname.Name = "tbname"
        Me.tbname.Size = New System.Drawing.Size(100, 20)
        Me.tbname.TabIndex = 1
        '
        'tbsname
        '
        Me.tbsname.Location = New System.Drawing.Point(162, 86)
        Me.tbsname.Name = "tbsname"
        Me.tbsname.Size = New System.Drawing.Size(100, 20)
        Me.tbsname.TabIndex = 2
        '
        'tbgender
        '
        Me.tbgender.Location = New System.Drawing.Point(162, 112)
        Me.tbgender.Name = "tbgender"
        Me.tbgender.Size = New System.Drawing.Size(100, 20)
        Me.tbgender.TabIndex = 3
        '
        'tbphone
        '
        Me.tbphone.Location = New System.Drawing.Point(162, 138)
        Me.tbphone.Name = "tbphone"
        Me.tbphone.Size = New System.Drawing.Size(100, 20)
        Me.tbphone.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("NSimSun", 14.25!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(68, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 19)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("NSimSun", 14.25!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(68, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 19)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("NSimSun", 14.25!)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(68, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 19)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Surname"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("NSimSun", 14.25!)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(68, 116)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 19)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Gender"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("NSimSun", 14.25!)
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(68, 142)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 19)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Phone"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("NSimSun", 14.25!)
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(303, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(149, 19)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Identify image"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(307, 209)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Clear All"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(72, 238)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 14
        Me.Button3.Text = "Edit"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(181, 238)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 15
        Me.Button4.Text = "Delete"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(307, 238)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 16
        Me.Button5.Text = "Refresh"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(51, 289)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(617, 141)
        Me.DataGridView1.TabIndex = 17
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.btnmmn)
        Me.Panel1.Controls.Add(Me.btnexit)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(723, 30)
        Me.Panel1.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 5)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 21)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Menu Lab"
        '
        'btnmmn
        '
        Me.btnmmn.AutoSize = True
        Me.btnmmn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.btnmmn.Location = New System.Drawing.Point(655, 3)
        Me.btnmmn.Name = "btnmmn"
        Me.btnmmn.Size = New System.Drawing.Size(16, 24)
        Me.btnmmn.TabIndex = 3
        Me.btnmmn.Text = "-"
        '
        'btnexit
        '
        Me.btnexit.AutoSize = True
        Me.btnexit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnexit.Location = New System.Drawing.Point(686, 7)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(20, 20)
        Me.btnexit.TabIndex = 2
        Me.btnexit.Text = "X"
        '
        'btnsave
        '
        Me.btnsave.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.btnsave.FlatAppearance.BorderSize = 0
        Me.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsave.Location = New System.Drawing.Point(72, 209)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(75, 23)
        Me.btnsave.TabIndex = 19
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.Panel7.Controls.Add(Me.Button7)
        Me.Panel7.Controls.Add(Me.Label6)
        Me.Panel7.Controls.Add(Me.pbID)
        Me.Panel7.Controls.Add(Me.btnsave)
        Me.Panel7.Controls.Add(Me.tbID)
        Me.Panel7.Controls.Add(Me.tbname)
        Me.Panel7.Controls.Add(Me.DataGridView1)
        Me.Panel7.Controls.Add(Me.tbsname)
        Me.Panel7.Controls.Add(Me.Button5)
        Me.Panel7.Controls.Add(Me.tbgender)
        Me.Panel7.Controls.Add(Me.Button4)
        Me.Panel7.Controls.Add(Me.tbphone)
        Me.Panel7.Controls.Add(Me.Button3)
        Me.Panel7.Controls.Add(Me.Label1)
        Me.Panel7.Controls.Add(Me.Button2)
        Me.Panel7.Controls.Add(Me.Label2)
        Me.Panel7.Controls.Add(Me.Label3)
        Me.Panel7.Controls.Add(Me.Label4)
        Me.Panel7.Controls.Add(Me.Label5)
        Me.Panel7.Location = New System.Drawing.Point(12, 30)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(699, 440)
        Me.Panel7.TabIndex = 21
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.Button7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Button7.FlatAppearance.BorderSize = 0
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Impact", 12.0!)
        Me.Button7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button7.Location = New System.Drawing.Point(558, 19)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(121, 35)
        Me.Button7.TabIndex = 21
        Me.Button7.Text = "Main"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(723, 482)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.pbID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pbID As PictureBox
    Friend WithEvents tbID As TextBox
    Friend WithEvents tbname As TextBox
    Friend WithEvents tbsname As TextBox
    Friend WithEvents tbgender As TextBox
    Friend WithEvents tbphone As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents btnmmn As Label
    Friend WithEvents btnexit As Label
    Friend WithEvents btnsave As Button
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Button7 As Button
End Class
