<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DailyJournal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DailyJournal))
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2ImageButton1 = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.Guna2ImageButton4 = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.Guna2ImageButton2 = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.SuspendLayout()
        '
        'Guna2Button2
        '
        Me.Guna2Button2.CheckedState.Parent = Me.Guna2Button2
        Me.Guna2Button2.CustomImages.Parent = Me.Guna2Button2
        Me.Guna2Button2.FillColor = System.Drawing.Color.Teal
        Me.Guna2Button2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button2.ForeColor = System.Drawing.Color.White
        Me.Guna2Button2.HoverState.Parent = Me.Guna2Button2
        Me.Guna2Button2.Location = New System.Drawing.Point(262, 251)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.ShadowDecoration.Parent = Me.Guna2Button2
        Me.Guna2Button2.Size = New System.Drawing.Size(147, 41)
        Me.Guna2Button2.TabIndex = 8
        Me.Guna2Button2.Text = "Book Journal"
        '
        'Guna2Button1
        '
        Me.Guna2Button1.CheckedState.Parent = Me.Guna2Button1
        Me.Guna2Button1.CustomImages.Parent = Me.Guna2Button1
        Me.Guna2Button1.FillColor = System.Drawing.Color.Teal
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.HoverState.Parent = Me.Guna2Button1
        Me.Guna2Button1.Location = New System.Drawing.Point(644, 251)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.ShadowDecoration.Parent = Me.Guna2Button1
        Me.Guna2Button1.Size = New System.Drawing.Size(147, 41)
        Me.Guna2Button1.TabIndex = 9
        Me.Guna2Button1.Text = "Movie Journal"
        '
        'Guna2ImageButton1
        '
        Me.Guna2ImageButton1.CheckedState.Parent = Me.Guna2ImageButton1
        Me.Guna2ImageButton1.HoverState.Parent = Me.Guna2ImageButton1
        Me.Guna2ImageButton1.Image = CType(resources.GetObject("Guna2ImageButton1.Image"), System.Drawing.Image)
        Me.Guna2ImageButton1.ImageSize = New System.Drawing.Size(80, 80)
        Me.Guna2ImageButton1.Location = New System.Drawing.Point(663, 157)
        Me.Guna2ImageButton1.Name = "Guna2ImageButton1"
        Me.Guna2ImageButton1.PressedState.Parent = Me.Guna2ImageButton1
        Me.Guna2ImageButton1.Size = New System.Drawing.Size(106, 88)
        Me.Guna2ImageButton1.TabIndex = 15
        '
        'Guna2ImageButton4
        '
        Me.Guna2ImageButton4.CheckedState.Parent = Me.Guna2ImageButton4
        Me.Guna2ImageButton4.HoverState.Parent = Me.Guna2ImageButton4
        Me.Guna2ImageButton4.Image = CType(resources.GetObject("Guna2ImageButton4.Image"), System.Drawing.Image)
        Me.Guna2ImageButton4.ImageSize = New System.Drawing.Size(80, 80)
        Me.Guna2ImageButton4.Location = New System.Drawing.Point(290, 168)
        Me.Guna2ImageButton4.Name = "Guna2ImageButton4"
        Me.Guna2ImageButton4.PressedState.Parent = Me.Guna2ImageButton4
        Me.Guna2ImageButton4.Size = New System.Drawing.Size(75, 77)
        Me.Guna2ImageButton4.TabIndex = 16
        '
        'Guna2ImageButton2
        '
        Me.Guna2ImageButton2.CheckedState.Parent = Me.Guna2ImageButton2
        Me.Guna2ImageButton2.HoverState.Parent = Me.Guna2ImageButton2
        Me.Guna2ImageButton2.Image = CType(resources.GetObject("Guna2ImageButton2.Image"), System.Drawing.Image)
        Me.Guna2ImageButton2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2ImageButton2.ImageSize = New System.Drawing.Size(40, 40)
        Me.Guna2ImageButton2.Location = New System.Drawing.Point(-18, -17)
        Me.Guna2ImageButton2.Name = "Guna2ImageButton2"
        Me.Guna2ImageButton2.PressedState.Parent = Me.Guna2ImageButton2
        Me.Guna2ImageButton2.Size = New System.Drawing.Size(122, 109)
        Me.Guna2ImageButton2.TabIndex = 44
        '
        'DailyJournal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1036, 510)
        Me.Controls.Add(Me.Guna2ImageButton2)
        Me.Controls.Add(Me.Guna2ImageButton4)
        Me.Controls.Add(Me.Guna2ImageButton1)
        Me.Controls.Add(Me.Guna2Button1)
        Me.Controls.Add(Me.Guna2Button2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "DailyJournal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SleepJournal"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2ImageButton1 As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents Guna2ImageButton4 As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents Guna2ImageButton2 As Guna.UI2.WinForms.Guna2ImageButton
End Class
