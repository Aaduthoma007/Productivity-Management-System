<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Taskhub
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Taskhub))
        Me.Guna2ImageButton1 = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2ImageButton2 = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Guna2ImageButton1
        '
        Me.Guna2ImageButton1.CheckedState.Parent = Me.Guna2ImageButton1
        Me.Guna2ImageButton1.HoverState.Parent = Me.Guna2ImageButton1
        Me.Guna2ImageButton1.Image = CType(resources.GetObject("Guna2ImageButton1.Image"), System.Drawing.Image)
        Me.Guna2ImageButton1.ImageSize = New System.Drawing.Size(80, 80)
        Me.Guna2ImageButton1.Location = New System.Drawing.Point(260, 139)
        Me.Guna2ImageButton1.Name = "Guna2ImageButton1"
        Me.Guna2ImageButton1.PressedState.Parent = Me.Guna2ImageButton1
        Me.Guna2ImageButton1.Size = New System.Drawing.Size(170, 153)
        Me.Guna2ImageButton1.TabIndex = 1
        '
        'Guna2Button1
        '
        Me.Guna2Button1.CheckedState.Parent = Me.Guna2Button1
        Me.Guna2Button1.CustomImages.Parent = Me.Guna2Button1
        Me.Guna2Button1.FillColor = System.Drawing.Color.Teal
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.HoverState.Parent = Me.Guna2Button1
        Me.Guna2Button1.Location = New System.Drawing.Point(271, 298)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.PressedColor = System.Drawing.Color.Aqua
        Me.Guna2Button1.ShadowDecoration.Parent = Me.Guna2Button1
        Me.Guna2Button1.Size = New System.Drawing.Size(147, 41)
        Me.Guna2Button1.TabIndex = 7
        Me.Guna2Button1.Text = "To Do List"
        '
        'Guna2ImageButton2
        '
        Me.Guna2ImageButton2.CheckedState.Parent = Me.Guna2ImageButton2
        Me.Guna2ImageButton2.HoverState.Parent = Me.Guna2ImageButton2
        Me.Guna2ImageButton2.Image = CType(resources.GetObject("Guna2ImageButton2.Image"), System.Drawing.Image)
        Me.Guna2ImageButton2.ImageSize = New System.Drawing.Size(100, 100)
        Me.Guna2ImageButton2.Location = New System.Drawing.Point(646, 139)
        Me.Guna2ImageButton2.Name = "Guna2ImageButton2"
        Me.Guna2ImageButton2.PressedState.Parent = Me.Guna2ImageButton2
        Me.Guna2ImageButton2.Size = New System.Drawing.Size(170, 153)
        Me.Guna2ImageButton2.TabIndex = 8
        '
        'Guna2Button2
        '
        Me.Guna2Button2.CheckedState.Parent = Me.Guna2Button2
        Me.Guna2Button2.CustomImages.Parent = Me.Guna2Button2
        Me.Guna2Button2.FillColor = System.Drawing.Color.Teal
        Me.Guna2Button2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button2.ForeColor = System.Drawing.Color.White
        Me.Guna2Button2.HoverState.Parent = Me.Guna2Button2
        Me.Guna2Button2.Location = New System.Drawing.Point(669, 298)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.PressedColor = System.Drawing.Color.Aqua
        Me.Guna2Button2.ShadowDecoration.Parent = Me.Guna2Button2
        Me.Guna2Button2.Size = New System.Drawing.Size(147, 41)
        Me.Guna2Button2.TabIndex = 9
        Me.Guna2Button2.Text = "Wishlist"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(30, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 36)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "X"
        '
        'Taskhub
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1054, 557)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Guna2Button2)
        Me.Controls.Add(Me.Guna2ImageButton2)
        Me.Controls.Add(Me.Guna2Button1)
        Me.Controls.Add(Me.Guna2ImageButton1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Taskhub"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Taskhub"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2ImageButton1 As Guna.UI2.WinForms.Guna2ImageButton
    Private WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2ImageButton2 As Guna.UI2.WinForms.Guna2ImageButton
    Private WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label2 As Label
End Class
