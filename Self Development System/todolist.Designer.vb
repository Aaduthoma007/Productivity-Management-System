<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class todolist
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
        Me.addbutton = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.removebutton = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'addbutton
        '
        Me.addbutton.BackColor = System.Drawing.Color.Teal
        Me.addbutton.Font = New System.Drawing.Font("Palatino Linotype", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addbutton.ForeColor = System.Drawing.Color.White
        Me.addbutton.Location = New System.Drawing.Point(101, 265)
        Me.addbutton.Name = "addbutton"
        Me.addbutton.Size = New System.Drawing.Size(315, 66)
        Me.addbutton.TabIndex = 0
        Me.addbutton.Text = "Add Task"
        Me.addbutton.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.TextBox1.Font = New System.Drawing.Font("Segoe Print", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(88, 145)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(475, 79)
        Me.TextBox1.TabIndex = 1
        '
        'removebutton
        '
        Me.removebutton.BackColor = System.Drawing.Color.Teal
        Me.removebutton.Font = New System.Drawing.Font("Palatino Linotype", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.removebutton.ForeColor = System.Drawing.Color.White
        Me.removebutton.Location = New System.Drawing.Point(101, 365)
        Me.removebutton.Name = "removebutton"
        Me.removebutton.Size = New System.Drawing.Size(315, 66)
        Me.removebutton.TabIndex = 2
        Me.removebutton.Text = "Remove Task"
        Me.removebutton.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Teal
        Me.Button4.Font = New System.Drawing.Font("Palatino Linotype", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(656, 107)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(284, 71)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "TaskList"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(95, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(234, 35)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Enter your task here.."
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.ListBox1.Font = New System.Drawing.Font("Segoe Print", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.ForeColor = System.Drawing.Color.White
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 43
        Me.ListBox1.Location = New System.Drawing.Point(667, 201)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(284, 262)
        Me.ListBox1.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(19, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 36)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "X"
        '
        'todolist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1054, 557)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.removebutton)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.addbutton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "todolist"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "todolist"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents addbutton As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents removebutton As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label2 As Label
End Class
