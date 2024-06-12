<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class stopwatch
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(stopwatch))
        Me.CircularProgressBar1 = New Guna.UI2.WinForms.Guna2CircleProgressBar()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.Button3 = New Guna.UI2.WinForms.Guna2Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Guna2ImageButton1 = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.CircularProgressBar1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CircularProgressBar1
        '
        Me.CircularProgressBar1.Controls.Add(Me.Label2)
        Me.CircularProgressBar1.Controls.Add(Me.Label1)
        Me.CircularProgressBar1.Location = New System.Drawing.Point(47, 33)
        Me.CircularProgressBar1.Maximum = 59
        Me.CircularProgressBar1.Name = "CircularProgressBar1"
        Me.CircularProgressBar1.ProgressColor2 = System.Drawing.Color.Teal
        Me.CircularProgressBar1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.CircularProgressBar1.ShadowDecoration.Parent = Me.CircularProgressBar1
        Me.CircularProgressBar1.Size = New System.Drawing.Size(460, 460)
        Me.CircularProgressBar1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Impact", 48.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.MediumAquamarine
        Me.Label2.Location = New System.Drawing.Point(149, 246)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(171, 98)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "000"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Impact", 48.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkCyan
        Me.Label1.Location = New System.Drawing.Point(69, 148)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(332, 98)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "00:00:00"
        '
        'Button1
        '
        Me.Button1.CheckedState.Parent = Me.Button1
        Me.Button1.CustomImages.Parent = Me.Button1
        Me.Button1.FillColor = System.Drawing.Color.Teal
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.HoverState.Parent = Me.Button1
        Me.Button1.Location = New System.Drawing.Point(703, 136)
        Me.Button1.Name = "Button1"
        Me.Button1.ShadowDecoration.Parent = Me.Button1
        Me.Button1.Size = New System.Drawing.Size(180, 45)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Start"
        '
        'Button2
        '
        Me.Button2.CheckedState.Parent = Me.Button2
        Me.Button2.CustomImages.Parent = Me.Button2
        Me.Button2.FillColor = System.Drawing.Color.Teal
        Me.Button2.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.HoverState.Parent = Me.Button2
        Me.Button2.Location = New System.Drawing.Point(576, 203)
        Me.Button2.Name = "Button2"
        Me.Button2.ShadowDecoration.Parent = Me.Button2
        Me.Button2.Size = New System.Drawing.Size(180, 45)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Lap"
        '
        'Button3
        '
        Me.Button3.CheckedState.Parent = Me.Button3
        Me.Button3.CustomImages.Parent = Me.Button3
        Me.Button3.FillColor = System.Drawing.Color.Teal
        Me.Button3.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.HoverState.Parent = Me.Button3
        Me.Button3.Location = New System.Drawing.Point(826, 203)
        Me.Button3.Name = "Button3"
        Me.Button3.ShadowDecoration.Parent = Me.Button3
        Me.Button3.Size = New System.Drawing.Size(180, 45)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Reset"
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.SystemColors.Menu
        Me.ListBox1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 22
        Me.ListBox1.Location = New System.Drawing.Point(601, 290)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(395, 158)
        Me.ListBox1.TabIndex = 4
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'Guna2ImageButton1
        '
        Me.Guna2ImageButton1.CheckedState.Parent = Me.Guna2ImageButton1
        Me.Guna2ImageButton1.HoverState.Parent = Me.Guna2ImageButton1
        Me.Guna2ImageButton1.Image = CType(resources.GetObject("Guna2ImageButton1.Image"), System.Drawing.Image)
        Me.Guna2ImageButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2ImageButton1.ImageSize = New System.Drawing.Size(40, 40)
        Me.Guna2ImageButton1.Location = New System.Drawing.Point(-31, -20)
        Me.Guna2ImageButton1.Name = "Guna2ImageButton1"
        Me.Guna2ImageButton1.PressedState.Parent = Me.Guna2ImageButton1
        Me.Guna2ImageButton1.Size = New System.Drawing.Size(122, 109)
        Me.Guna2ImageButton1.TabIndex = 2
        '
        'stopwatch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1054, 557)
        Me.Controls.Add(Me.Guna2ImageButton1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CircularProgressBar1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "stopwatch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "stopwatch"
        Me.CircularProgressBar1.ResumeLayout(False)
        Me.CircularProgressBar1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CircularProgressBar1 As Guna.UI2.WinForms.Guna2CircleProgressBar
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Button3 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Guna2ImageButton1 As Guna.UI2.WinForms.Guna2ImageButton
End Class
