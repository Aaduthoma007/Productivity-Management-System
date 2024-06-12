<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Bookj
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Bookj))
        Me.Guna2ImageButton1 = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.txt_language = New System.Windows.Forms.TextBox()
        Me.PhoneNo = New System.Windows.Forms.Label()
        Me.txt_isbn = New System.Windows.Forms.TextBox()
        Me.txt_publisher = New System.Windows.Forms.TextBox()
        Me.txt_author = New System.Windows.Forms.TextBox()
        Me.txt_genre = New System.Windows.Forms.TextBox()
        Me.txt_title = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_dob = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.deselect = New Guna.UI2.WinForms.Guna2Button()
        Me.delete = New Guna.UI2.WinForms.Guna2Button()
        Me.update = New Guna.UI2.WinForms.Guna2Button()
        Me.save = New Guna.UI2.WinForms.Guna2Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2ImageButton1
        '
        Me.Guna2ImageButton1.CheckedState.Parent = Me.Guna2ImageButton1
        Me.Guna2ImageButton1.HoverState.Parent = Me.Guna2ImageButton1
        Me.Guna2ImageButton1.Image = CType(resources.GetObject("Guna2ImageButton1.Image"), System.Drawing.Image)
        Me.Guna2ImageButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2ImageButton1.ImageSize = New System.Drawing.Size(40, 40)
        Me.Guna2ImageButton1.Location = New System.Drawing.Point(-19, -9)
        Me.Guna2ImageButton1.Name = "Guna2ImageButton1"
        Me.Guna2ImageButton1.PressedState.Parent = Me.Guna2ImageButton1
        Me.Guna2ImageButton1.Size = New System.Drawing.Size(122, 109)
        Me.Guna2ImageButton1.TabIndex = 56
        '
        'txt_language
        '
        Me.txt_language.Location = New System.Drawing.Point(142, 380)
        Me.txt_language.Name = "txt_language"
        Me.txt_language.Size = New System.Drawing.Size(231, 22)
        Me.txt_language.TabIndex = 55
        '
        'PhoneNo
        '
        Me.PhoneNo.AutoSize = True
        Me.PhoneNo.Font = New System.Drawing.Font("Palatino Linotype", 9.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PhoneNo.Location = New System.Drawing.Point(138, 354)
        Me.PhoneNo.Name = "PhoneNo"
        Me.PhoneNo.Size = New System.Drawing.Size(84, 23)
        Me.PhoneNo.TabIndex = 54
        Me.PhoneNo.Text = "Language"
        '
        'txt_isbn
        '
        Me.txt_isbn.Location = New System.Drawing.Point(142, 314)
        Me.txt_isbn.Name = "txt_isbn"
        Me.txt_isbn.Size = New System.Drawing.Size(231, 22)
        Me.txt_isbn.TabIndex = 53
        '
        'txt_publisher
        '
        Me.txt_publisher.Location = New System.Drawing.Point(142, 237)
        Me.txt_publisher.Name = "txt_publisher"
        Me.txt_publisher.Size = New System.Drawing.Size(231, 22)
        Me.txt_publisher.TabIndex = 52
        '
        'txt_author
        '
        Me.txt_author.Location = New System.Drawing.Point(142, 103)
        Me.txt_author.Name = "txt_author"
        Me.txt_author.Size = New System.Drawing.Size(231, 22)
        Me.txt_author.TabIndex = 51
        '
        'txt_genre
        '
        Me.txt_genre.Location = New System.Drawing.Point(142, 173)
        Me.txt_genre.Name = "txt_genre"
        Me.txt_genre.Size = New System.Drawing.Size(231, 22)
        Me.txt_genre.TabIndex = 50
        '
        'txt_title
        '
        Me.txt_title.Location = New System.Drawing.Point(142, 41)
        Me.txt_title.Name = "txt_title"
        Me.txt_title.Size = New System.Drawing.Size(231, 22)
        Me.txt_title.TabIndex = 49
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Palatino Linotype", 9.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(140, 211)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 23)
        Me.Label5.TabIndex = 48
        Me.Label5.Text = "Publisher"
        '
        'txt_dob
        '
        Me.txt_dob.AutoSize = True
        Me.txt_dob.Font = New System.Drawing.Font("Palatino Linotype", 9.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_dob.Location = New System.Drawing.Point(140, 288)
        Me.txt_dob.Name = "txt_dob"
        Me.txt_dob.Size = New System.Drawing.Size(49, 23)
        Me.txt_dob.TabIndex = 47
        Me.txt_dob.Text = "ISBN"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Palatino Linotype", 9.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(140, 147)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 23)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "Genre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Palatino Linotype", 9.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(140, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 23)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Author"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 9.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(138, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 23)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Title"
        '
        'deselect
        '
        Me.deselect.CheckedState.Parent = Me.deselect
        Me.deselect.CustomImages.Parent = Me.deselect
        Me.deselect.FillColor = System.Drawing.Color.Teal
        Me.deselect.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.deselect.ForeColor = System.Drawing.Color.White
        Me.deselect.HoverState.Parent = Me.deselect
        Me.deselect.Location = New System.Drawing.Point(853, 464)
        Me.deselect.Name = "deselect"
        Me.deselect.PressedColor = System.Drawing.Color.Aqua
        Me.deselect.ShadowDecoration.Parent = Me.deselect
        Me.deselect.Size = New System.Drawing.Size(147, 41)
        Me.deselect.TabIndex = 61
        Me.deselect.Text = "Deselect"
        '
        'delete
        '
        Me.delete.CheckedState.Parent = Me.delete
        Me.delete.CustomImages.Parent = Me.delete
        Me.delete.FillColor = System.Drawing.Color.Teal
        Me.delete.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.delete.ForeColor = System.Drawing.Color.White
        Me.delete.HoverState.Parent = Me.delete
        Me.delete.Location = New System.Drawing.Point(615, 464)
        Me.delete.Name = "delete"
        Me.delete.PressedColor = System.Drawing.Color.Aqua
        Me.delete.ShadowDecoration.Parent = Me.delete
        Me.delete.Size = New System.Drawing.Size(147, 41)
        Me.delete.TabIndex = 60
        Me.delete.Text = "Delete"
        '
        'update
        '
        Me.update.CheckedState.Parent = Me.update
        Me.update.CustomImages.Parent = Me.update
        Me.update.FillColor = System.Drawing.Color.Teal
        Me.update.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.update.ForeColor = System.Drawing.Color.White
        Me.update.HoverState.Parent = Me.update
        Me.update.Location = New System.Drawing.Point(853, 402)
        Me.update.Name = "update"
        Me.update.PressedColor = System.Drawing.Color.Aqua
        Me.update.ShadowDecoration.Parent = Me.update
        Me.update.Size = New System.Drawing.Size(147, 41)
        Me.update.TabIndex = 59
        Me.update.Text = "Update"
        '
        'save
        '
        Me.save.CheckedState.Parent = Me.save
        Me.save.CustomImages.Parent = Me.save
        Me.save.FillColor = System.Drawing.Color.Teal
        Me.save.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.save.ForeColor = System.Drawing.Color.White
        Me.save.HoverState.Parent = Me.save
        Me.save.Location = New System.Drawing.Point(615, 402)
        Me.save.Name = "save"
        Me.save.PressedColor = System.Drawing.Color.Aqua
        Me.save.ShadowDecoration.Parent = Me.save
        Me.save.Size = New System.Drawing.Size(147, 41)
        Me.save.TabIndex = 58
        Me.save.Text = "Save"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.GridColor = System.Drawing.Color.Teal
        Me.DataGridView1.Location = New System.Drawing.Point(540, 15)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(484, 368)
        Me.DataGridView1.TabIndex = 57
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Mongolian Baiti", 12.8!)
        Me.Label4.ForeColor = System.Drawing.Color.Teal
        Me.Label4.Location = New System.Drawing.Point(51, 441)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(535, 24)
        Me.Label4.TabIndex = 62
        Me.Label4.Text = "Enter the details of the Books that have changed your lives"
        '
        'Bookj
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1036, 510)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.deselect)
        Me.Controls.Add(Me.delete)
        Me.Controls.Add(Me.update)
        Me.Controls.Add(Me.save)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Guna2ImageButton1)
        Me.Controls.Add(Me.txt_language)
        Me.Controls.Add(Me.PhoneNo)
        Me.Controls.Add(Me.txt_isbn)
        Me.Controls.Add(Me.txt_publisher)
        Me.Controls.Add(Me.txt_author)
        Me.Controls.Add(Me.txt_genre)
        Me.Controls.Add(Me.txt_title)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_dob)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Bookj"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "bookj"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2ImageButton1 As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents txt_language As TextBox
    Friend WithEvents PhoneNo As Label
    Friend WithEvents txt_isbn As TextBox
    Friend WithEvents txt_publisher As TextBox
    Friend WithEvents txt_author As TextBox
    Friend WithEvents txt_genre As TextBox
    Friend WithEvents txt_title As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_dob As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Private WithEvents deselect As Guna.UI2.WinForms.Guna2Button
    Private WithEvents delete As Guna.UI2.WinForms.Guna2Button
    Private WithEvents update As Guna.UI2.WinForms.Guna2Button
    Private WithEvents save As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label4 As Label
End Class
