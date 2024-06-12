<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.label = New System.Windows.Forms.Label()
        Me.luse = New System.Windows.Forms.Label()
        Me.lpass = New System.Windows.Forms.Label()
        Me.use = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.registerdb = New Guna.UI2.WinForms.Guna2Button()
        Me.lnamedb = New System.Windows.Forms.TextBox()
        Me.passdb = New System.Windows.Forms.TextBox()
        Me.fnamedb = New System.Windows.Forms.TextBox()
        Me.usedb = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'label
        '
        Me.label.AutoSize = True
        Me.label.Font = New System.Drawing.Font("Palatino Linotype", 32.2!, System.Drawing.FontStyle.Bold)
        Me.label.ForeColor = System.Drawing.Color.Teal
        Me.label.Location = New System.Drawing.Point(240, 58)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(311, 73)
        Me.label.TabIndex = 1
        Me.label.Text = "REGISTER"
        '
        'luse
        '
        Me.luse.AutoSize = True
        Me.luse.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.8!, System.Drawing.FontStyle.Bold)
        Me.luse.ForeColor = System.Drawing.Color.Teal
        Me.luse.Location = New System.Drawing.Point(61, 184)
        Me.luse.Name = "luse"
        Me.luse.Size = New System.Drawing.Size(144, 31)
        Me.luse.TabIndex = 2
        Me.luse.Text = "Firstname"
        '
        'lpass
        '
        Me.lpass.AutoSize = True
        Me.lpass.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.8!, System.Drawing.FontStyle.Bold)
        Me.lpass.ForeColor = System.Drawing.Color.Teal
        Me.lpass.Location = New System.Drawing.Point(431, 184)
        Me.lpass.Name = "lpass"
        Me.lpass.Size = New System.Drawing.Size(141, 31)
        Me.lpass.TabIndex = 5
        Me.lpass.Text = "Lastname"
        '
        'use
        '
        Me.use.AutoSize = True
        Me.use.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.8!, System.Drawing.FontStyle.Bold)
        Me.use.ForeColor = System.Drawing.Color.Teal
        Me.use.Location = New System.Drawing.Point(58, 284)
        Me.use.Name = "use"
        Me.use.Size = New System.Drawing.Size(147, 31)
        Me.use.TabIndex = 7
        Me.use.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.8!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.Teal
        Me.Label2.Location = New System.Drawing.Point(430, 284)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(142, 31)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Password"
        '
        'registerdb
        '
        Me.registerdb.Animated = True
        Me.registerdb.AutoRoundedCorners = True
        Me.registerdb.BorderRadius = 21
        Me.registerdb.CheckedState.Parent = Me.registerdb
        Me.registerdb.CustomImages.Parent = Me.registerdb
        Me.registerdb.FillColor = System.Drawing.Color.Teal
        Me.registerdb.Font = New System.Drawing.Font("Palatino Linotype", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.registerdb.ForeColor = System.Drawing.Color.White
        Me.registerdb.HoverState.Parent = Me.registerdb
        Me.registerdb.Location = New System.Drawing.Point(316, 375)
        Me.registerdb.Name = "registerdb"
        Me.registerdb.ShadowDecoration.Parent = Me.registerdb
        Me.registerdb.Size = New System.Drawing.Size(180, 45)
        Me.registerdb.TabIndex = 11
        Me.registerdb.Text = "Register"
        '
        'lnamedb
        '
        Me.lnamedb.Location = New System.Drawing.Point(588, 193)
        Me.lnamedb.Name = "lnamedb"
        Me.lnamedb.Size = New System.Drawing.Size(150, 22)
        Me.lnamedb.TabIndex = 14
        Me.lnamedb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'passdb
        '
        Me.passdb.Location = New System.Drawing.Point(588, 293)
        Me.passdb.MinimumSize = New System.Drawing.Size(5, 5)
        Me.passdb.Name = "passdb"
        Me.passdb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.passdb.Size = New System.Drawing.Size(150, 22)
        Me.passdb.TabIndex = 15
        Me.passdb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.passdb.UseSystemPasswordChar = True
        '
        'fnamedb
        '
        Me.fnamedb.Location = New System.Drawing.Point(221, 193)
        Me.fnamedb.Name = "fnamedb"
        Me.fnamedb.Size = New System.Drawing.Size(150, 22)
        Me.fnamedb.TabIndex = 16
        Me.fnamedb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'usedb
        '
        Me.usedb.Location = New System.Drawing.Point(221, 293)
        Me.usedb.Name = "usedb"
        Me.usedb.Size = New System.Drawing.Size(150, 22)
        Me.usedb.TabIndex = 17
        Me.usedb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(28, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 36)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "X"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.usedb)
        Me.Controls.Add(Me.fnamedb)
        Me.Controls.Add(Me.passdb)
        Me.Controls.Add(Me.lnamedb)
        Me.Controls.Add(Me.registerdb)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.use)
        Me.Controls.Add(Me.lpass)
        Me.Controls.Add(Me.luse)
        Me.Controls.Add(Me.label)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents label As Label
    Friend WithEvents luse As Label
    Friend WithEvents lpass As Label
    Friend WithEvents use As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents registerdb As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lnamedb As TextBox
    Friend WithEvents passdb As TextBox
    Friend WithEvents fnamedb As TextBox
    Friend WithEvents usedb As TextBox
    Friend WithEvents Label1 As Label
End Class
