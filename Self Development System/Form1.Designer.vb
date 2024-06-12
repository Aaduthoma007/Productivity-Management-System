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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.luse = New System.Windows.Forms.Label()
        Me.lpass = New System.Windows.Forms.Label()
        Me.login = New Guna.UI2.WinForms.Guna2Button()
        Me.register = New Guna.UI2.WinForms.Guna2Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 32.2!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Teal
        Me.Label1.Location = New System.Drawing.Point(229, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(320, 62)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "WELCOME"
        '
        'luse
        '
        Me.luse.AutoSize = True
        Me.luse.Font = New System.Drawing.Font("Times New Roman", 15.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.luse.ForeColor = System.Drawing.Color.Teal
        Me.luse.Location = New System.Drawing.Point(229, 157)
        Me.luse.Name = "luse"
        Me.luse.Size = New System.Drawing.Size(132, 31)
        Me.luse.TabIndex = 1
        Me.luse.Text = "Username"
        '
        'lpass
        '
        Me.lpass.AutoSize = True
        Me.lpass.Font = New System.Drawing.Font("Times New Roman", 15.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lpass.ForeColor = System.Drawing.Color.Teal
        Me.lpass.Location = New System.Drawing.Point(234, 240)
        Me.lpass.Name = "lpass"
        Me.lpass.Size = New System.Drawing.Size(127, 31)
        Me.lpass.TabIndex = 2
        Me.lpass.Text = "Password"
        '
        'login
        '
        Me.login.Animated = True
        Me.login.AutoRoundedCorners = True
        Me.login.BorderRadius = 19
        Me.login.CheckedState.Parent = Me.login
        Me.login.CustomImages.Parent = Me.login
        Me.login.FillColor = System.Drawing.Color.Teal
        Me.login.Font = New System.Drawing.Font("Palatino Linotype", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.login.ForeColor = System.Drawing.Color.White
        Me.login.HoverState.Parent = Me.login
        Me.login.Location = New System.Drawing.Point(314, 319)
        Me.login.Name = "login"
        Me.login.ShadowDecoration.Parent = Me.login
        Me.login.Size = New System.Drawing.Size(156, 41)
        Me.login.TabIndex = 5
        Me.login.Text = "Login"
        '
        'register
        '
        Me.register.Animated = True
        Me.register.AutoRoundedCorners = True
        Me.register.BorderRadius = 20
        Me.register.CheckedState.Parent = Me.register
        Me.register.CustomImages.Parent = Me.register
        Me.register.FillColor = System.Drawing.Color.Teal
        Me.register.Font = New System.Drawing.Font("Palatino Linotype", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.register.ForeColor = System.Drawing.Color.White
        Me.register.HoverState.Parent = Me.register
        Me.register.Location = New System.Drawing.Point(667, 396)
        Me.register.Name = "register"
        Me.register.ShadowDecoration.Parent = Me.register
        Me.register.Size = New System.Drawing.Size(121, 42)
        Me.register.TabIndex = 6
        Me.register.Text = "Register "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Teal
        Me.Label4.Location = New System.Drawing.Point(558, 406)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 23)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "New User?"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(398, 166)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(140, 22)
        Me.TextBox1.TabIndex = 8
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(398, 249)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox2.Size = New System.Drawing.Size(140, 22)
        Me.TextBox2.TabIndex = 9
        Me.TextBox2.UseSystemPasswordChar = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.register)
        Me.Controls.Add(Me.login)
        Me.Controls.Add(Me.lpass)
        Me.Controls.Add(Me.luse)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents luse As Label
    Friend WithEvents lpass As Label
    Friend WithEvents login As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents register As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
End Class
