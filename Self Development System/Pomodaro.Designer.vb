<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pomodaro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pomodaro))
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.addbutton = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblremainingtime = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblsession = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2ImageButton1 = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.SuspendLayout()
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Impact", 65.0!)
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.Color.Teal
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(198, 23)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(730, 135)
        Me.Guna2HtmlLabel1.TabIndex = 12
        Me.Guna2HtmlLabel1.Text = "Pomodaro Timer"
        Me.Guna2HtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'addbutton
        '
        Me.addbutton.BackColor = System.Drawing.Color.Teal
        Me.addbutton.Font = New System.Drawing.Font("Palatino Linotype", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addbutton.ForeColor = System.Drawing.Color.White
        Me.addbutton.Location = New System.Drawing.Point(54, 259)
        Me.addbutton.Name = "addbutton"
        Me.addbutton.Size = New System.Drawing.Size(315, 66)
        Me.addbutton.TabIndex = 13
        Me.addbutton.Text = "Start Pomodaro"
        Me.addbutton.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Teal
        Me.Button1.Font = New System.Drawing.Font("Palatino Linotype", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(54, 378)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(315, 66)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Stop"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'lblremainingtime
        '
        Me.lblremainingtime.BackColor = System.Drawing.Color.Transparent
        Me.lblremainingtime.Font = New System.Drawing.Font("Impact", 42.5!, System.Drawing.FontStyle.Bold)
        Me.lblremainingtime.ForeColor = System.Drawing.Color.Teal
        Me.lblremainingtime.Location = New System.Drawing.Point(607, 344)
        Me.lblremainingtime.Name = "lblremainingtime"
        Me.lblremainingtime.Size = New System.Drawing.Size(174, 88)
        Me.lblremainingtime.TabIndex = 18
        Me.lblremainingtime.Text = "00:00"
        Me.lblremainingtime.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblsession
        '
        Me.lblsession.BackColor = System.Drawing.Color.Transparent
        Me.lblsession.Font = New System.Drawing.Font("Impact", 42.5!, System.Drawing.FontStyle.Bold)
        Me.lblsession.ForeColor = System.Drawing.Color.Teal
        Me.lblsession.Location = New System.Drawing.Point(566, 250)
        Me.lblsession.Name = "lblsession"
        Me.lblsession.Size = New System.Drawing.Size(241, 88)
        Me.lblsession.TabIndex = 19
        Me.lblsession.Text = "Session"
        Me.lblsession.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Guna2ImageButton1
        '
        Me.Guna2ImageButton1.CheckedState.Parent = Me.Guna2ImageButton1
        Me.Guna2ImageButton1.HoverState.Parent = Me.Guna2ImageButton1
        Me.Guna2ImageButton1.Image = CType(resources.GetObject("Guna2ImageButton1.Image"), System.Drawing.Image)
        Me.Guna2ImageButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2ImageButton1.ImageSize = New System.Drawing.Size(40, 40)
        Me.Guna2ImageButton1.Location = New System.Drawing.Point(-17, -10)
        Me.Guna2ImageButton1.Name = "Guna2ImageButton1"
        Me.Guna2ImageButton1.PressedState.Parent = Me.Guna2ImageButton1
        Me.Guna2ImageButton1.Size = New System.Drawing.Size(122, 109)
        Me.Guna2ImageButton1.TabIndex = 20
        '
        'pomodaro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1054, 557)
        Me.Controls.Add(Me.Guna2ImageButton1)
        Me.Controls.Add(Me.lblsession)
        Me.Controls.Add(Me.lblremainingtime)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.addbutton)
        Me.Controls.Add(Me.Guna2HtmlLabel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "pomodaro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "pomodaro"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents addbutton As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblremainingtime As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblsession As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2ImageButton1 As Guna.UI2.WinForms.Guna2ImageButton
End Class
