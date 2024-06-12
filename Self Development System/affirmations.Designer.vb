<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class affirmations
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(affirmations))
        Me.luse = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Guna2ImageButton5 = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.SuspendLayout()
        '
        'luse
        '
        Me.luse.AutoSize = True
        Me.luse.Font = New System.Drawing.Font("Times New Roman", 15.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.luse.ForeColor = System.Drawing.Color.Teal
        Me.luse.Location = New System.Drawing.Point(205, 61)
        Me.luse.Name = "luse"
        Me.luse.Size = New System.Drawing.Size(643, 31)
        Me.luse.TabIndex = 86
        Me.luse.Text = """I am confident in my abilities and believe in myself."""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Teal
        Me.Label1.Location = New System.Drawing.Point(205, 147)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(587, 31)
        Me.Label1.TabIndex = 87
        Me.Label1.Text = """I am deserving of love, happiness, and success."""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 15.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Teal
        Me.Label2.Location = New System.Drawing.Point(158, 418)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(680, 31)
        Me.Label2.TabIndex = 88
        Me.Label2.Text = """I am worthy of all the good things that life has to offer."""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 15.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Teal
        Me.Label3.Location = New System.Drawing.Point(162, 323)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(730, 31)
        Me.Label3.TabIndex = 89
        Me.Label3.Text = """I am grateful for the opportunities and blessings in my life."""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 15.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Teal
        Me.Label4.Location = New System.Drawing.Point(152, 418)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 31)
        Me.Label4.TabIndex = 90
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 15.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Teal
        Me.Label5.Location = New System.Drawing.Point(152, 238)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(833, 31)
        Me.Label5.TabIndex = 91
        Me.Label5.Text = """ I Give thanks to the Lord, for He is good; His love endures forever."""
        '
        'Guna2ImageButton5
        '
        Me.Guna2ImageButton5.CheckedState.Parent = Me.Guna2ImageButton5
        Me.Guna2ImageButton5.HoverState.Parent = Me.Guna2ImageButton5
        Me.Guna2ImageButton5.Image = CType(resources.GetObject("Guna2ImageButton5.Image"), System.Drawing.Image)
        Me.Guna2ImageButton5.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2ImageButton5.ImageSize = New System.Drawing.Size(40, 40)
        Me.Guna2ImageButton5.Location = New System.Drawing.Point(-12, -17)
        Me.Guna2ImageButton5.Name = "Guna2ImageButton5"
        Me.Guna2ImageButton5.PressedState.Parent = Me.Guna2ImageButton5
        Me.Guna2ImageButton5.Size = New System.Drawing.Size(122, 109)
        Me.Guna2ImageButton5.TabIndex = 92
        '
        'affirmations
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1036, 510)
        Me.Controls.Add(Me.Guna2ImageButton5)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.luse)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "affirmations"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "affirmations"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents luse As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Guna2ImageButton5 As Guna.UI2.WinForms.Guna2ImageButton
End Class
