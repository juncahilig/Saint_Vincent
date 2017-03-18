<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminAddBook
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
        Me.grpbxMenu = New System.Windows.Forms.GroupBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnAddBook = New System.Windows.Forms.Button()
        Me.btnModifyBook = New System.Windows.Forms.Button()
        Me.btnDeleteBook = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbBookLevel = New System.Windows.Forms.ComboBox()
        Me.txtBookOnHand = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnAddChanges = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtPublisher = New System.Windows.Forms.TextBox()
        Me.txtPubYear = New System.Windows.Forms.TextBox()
        Me.txtBookISBN = New System.Windows.Forms.TextBox()
        Me.txtBookAuthor = New System.Windows.Forms.TextBox()
        Me.txtBookTitle = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBookCode = New System.Windows.Forms.TextBox()
        Me.grpbxMenu.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpbxMenu
        '
        Me.grpbxMenu.Controls.Add(Me.btnBack)
        Me.grpbxMenu.Controls.Add(Me.btnAddBook)
        Me.grpbxMenu.Controls.Add(Me.btnModifyBook)
        Me.grpbxMenu.Controls.Add(Me.btnDeleteBook)
        Me.grpbxMenu.Location = New System.Drawing.Point(12, 53)
        Me.grpbxMenu.Name = "grpbxMenu"
        Me.grpbxMenu.Size = New System.Drawing.Size(201, 396)
        Me.grpbxMenu.TabIndex = 10
        Me.grpbxMenu.TabStop = False
        '
        'btnBack
        '
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBack.Font = New System.Drawing.Font("Britannic Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(7, 196)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(188, 53)
        Me.btnBack.TabIndex = 3
        Me.btnBack.Text = "BACK"
        Me.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnAddBook
        '
        Me.btnAddBook.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddBook.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAddBook.Font = New System.Drawing.Font("Britannic Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddBook.Location = New System.Drawing.Point(6, 19)
        Me.btnAddBook.Name = "btnAddBook"
        Me.btnAddBook.Size = New System.Drawing.Size(188, 53)
        Me.btnAddBook.TabIndex = 1
        Me.btnAddBook.Text = "ADD BOOK"
        Me.btnAddBook.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAddBook.UseVisualStyleBackColor = True
        '
        'btnModifyBook
        '
        Me.btnModifyBook.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModifyBook.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnModifyBook.Font = New System.Drawing.Font("Britannic Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModifyBook.Location = New System.Drawing.Point(6, 137)
        Me.btnModifyBook.Name = "btnModifyBook"
        Me.btnModifyBook.Size = New System.Drawing.Size(188, 53)
        Me.btnModifyBook.TabIndex = 2
        Me.btnModifyBook.Text = "MODIFY BOOK"
        Me.btnModifyBook.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnModifyBook.UseVisualStyleBackColor = True
        '
        'btnDeleteBook
        '
        Me.btnDeleteBook.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDeleteBook.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDeleteBook.Font = New System.Drawing.Font("Britannic Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteBook.Location = New System.Drawing.Point(6, 78)
        Me.btnDeleteBook.Name = "btnDeleteBook"
        Me.btnDeleteBook.Size = New System.Drawing.Size(188, 53)
        Me.btnDeleteBook.TabIndex = 0
        Me.btnDeleteBook.Text = "DELETE BOOK"
        Me.btnDeleteBook.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDeleteBook.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbBookLevel)
        Me.GroupBox1.Controls.Add(Me.txtBookOnHand)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.btnAddChanges)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtPublisher)
        Me.GroupBox1.Controls.Add(Me.txtPubYear)
        Me.GroupBox1.Controls.Add(Me.txtBookISBN)
        Me.GroupBox1.Controls.Add(Me.txtBookAuthor)
        Me.GroupBox1.Controls.Add(Me.txtBookTitle)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtBookCode)
        Me.GroupBox1.Location = New System.Drawing.Point(219, 53)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(652, 396)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        '
        'cmbBookLevel
        '
        Me.cmbBookLevel.FormattingEnabled = True
        Me.cmbBookLevel.Items.AddRange(New Object() {"KINDER", "PREP", "GRADE 1", "GRADE 2", "GRADE 3", "GRADE 4", "GRADE 5", "GRADE 6", "GRADE 7", "GRADE 8", "GRADE 9", "GRADE 10", "GRADE 11", "GRADE 12"})
        Me.cmbBookLevel.Location = New System.Drawing.Point(114, 264)
        Me.cmbBookLevel.Name = "cmbBookLevel"
        Me.cmbBookLevel.Size = New System.Drawing.Size(121, 21)
        Me.cmbBookLevel.TabIndex = 48
        '
        'txtBookOnHand
        '
        Me.txtBookOnHand.Location = New System.Drawing.Point(165, 311)
        Me.txtBookOnHand.Name = "txtBookOnHand"
        Me.txtBookOnHand.Size = New System.Drawing.Size(137, 20)
        Me.txtBookOnHand.TabIndex = 47
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(89, 311)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 13)
        Me.Label9.TabIndex = 46
        Me.Label9.Text = "On-Hand:"
        '
        'btnAddChanges
        '
        Me.btnAddChanges.Location = New System.Drawing.Point(571, 367)
        Me.btnAddChanges.Name = "btnAddChanges"
        Me.btnAddChanges.Size = New System.Drawing.Size(75, 23)
        Me.btnAddChanges.TabIndex = 45
        Me.btnAddChanges.Text = "ADD"
        Me.btnAddChanges.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, -5)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(155, 23)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "ADD NEW BOOK"
        '
        'txtPublisher
        '
        Me.txtPublisher.Location = New System.Drawing.Point(132, 196)
        Me.txtPublisher.Name = "txtPublisher"
        Me.txtPublisher.Size = New System.Drawing.Size(137, 20)
        Me.txtPublisher.TabIndex = 43
        '
        'txtPubYear
        '
        Me.txtPubYear.Location = New System.Drawing.Point(165, 235)
        Me.txtPubYear.Name = "txtPubYear"
        Me.txtPubYear.Size = New System.Drawing.Size(137, 20)
        Me.txtPubYear.TabIndex = 42
        '
        'txtBookISBN
        '
        Me.txtBookISBN.Location = New System.Drawing.Point(113, 162)
        Me.txtBookISBN.Name = "txtBookISBN"
        Me.txtBookISBN.Size = New System.Drawing.Size(137, 20)
        Me.txtBookISBN.TabIndex = 41
        '
        'txtBookAuthor
        '
        Me.txtBookAuthor.Location = New System.Drawing.Point(119, 132)
        Me.txtBookAuthor.Name = "txtBookAuthor"
        Me.txtBookAuthor.Size = New System.Drawing.Size(137, 20)
        Me.txtBookAuthor.TabIndex = 40
        '
        'txtBookTitle
        '
        Me.txtBookTitle.Location = New System.Drawing.Point(108, 93)
        Me.txtBookTitle.Name = "txtBookTitle"
        Me.txtBookTitle.Size = New System.Drawing.Size(137, 20)
        Me.txtBookTitle.TabIndex = 39
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(72, 264)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 13)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "Level:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(73, 199)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "Publisher:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(72, 238)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 13)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "Publication Year:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(72, 165)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "ISBN:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(72, 135)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Author:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(72, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Title:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(72, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Book Code:"
        '
        'txtBookCode
        '
        Me.txtBookCode.Location = New System.Drawing.Point(132, 56)
        Me.txtBookCode.MaxLength = 8
        Me.txtBookCode.Name = "txtBookCode"
        Me.txtBookCode.Size = New System.Drawing.Size(137, 20)
        Me.txtBookCode.TabIndex = 31
        '
        'AdminAddBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(883, 475)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grpbxMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "AdminAddBook"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SVBS Library System"
        Me.grpbxMenu.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpbxMenu As System.Windows.Forms.GroupBox
    Friend WithEvents btnAddBook As System.Windows.Forms.Button
    Friend WithEvents btnModifyBook As System.Windows.Forms.Button
    Friend WithEvents btnDeleteBook As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtPublisher As System.Windows.Forms.TextBox
    Friend WithEvents txtPubYear As System.Windows.Forms.TextBox
    Friend WithEvents txtBookISBN As System.Windows.Forms.TextBox
    Friend WithEvents txtBookAuthor As System.Windows.Forms.TextBox
    Friend WithEvents txtBookTitle As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtBookCode As System.Windows.Forms.TextBox
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnAddChanges As System.Windows.Forms.Button
    Friend WithEvents txtBookOnHand As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmbBookLevel As System.Windows.Forms.ComboBox
End Class
