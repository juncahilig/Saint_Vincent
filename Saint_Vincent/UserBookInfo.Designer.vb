<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserBookInfo
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
        Me.btnHomePage = New System.Windows.Forms.Button()
        Me.btnAdminPage = New System.Windows.Forms.Button()
        Me.btnBookInfo = New System.Windows.Forms.Button()
        Me.btnSearchBook = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtBookLevel = New System.Windows.Forms.TextBox()
        Me.txtBookPublisher = New System.Windows.Forms.TextBox()
        Me.txtBookPubYear = New System.Windows.Forms.TextBox()
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
        Me.grpbxMenu.Controls.Add(Me.btnHomePage)
        Me.grpbxMenu.Controls.Add(Me.btnAdminPage)
        Me.grpbxMenu.Controls.Add(Me.btnBookInfo)
        Me.grpbxMenu.Controls.Add(Me.btnSearchBook)
        Me.grpbxMenu.Location = New System.Drawing.Point(12, 67)
        Me.grpbxMenu.Name = "grpbxMenu"
        Me.grpbxMenu.Size = New System.Drawing.Size(201, 396)
        Me.grpbxMenu.TabIndex = 4
        Me.grpbxMenu.TabStop = False
        '
        'btnHomePage
        '
        Me.btnHomePage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHomePage.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnHomePage.Font = New System.Drawing.Font("Britannic Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHomePage.Location = New System.Drawing.Point(6, 19)
        Me.btnHomePage.Name = "btnHomePage"
        Me.btnHomePage.Size = New System.Drawing.Size(188, 53)
        Me.btnHomePage.TabIndex = 0
        Me.btnHomePage.Text = "HOME LIBRARY"
        Me.btnHomePage.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnHomePage.UseVisualStyleBackColor = True
        '
        'btnAdminPage
        '
        Me.btnAdminPage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdminPage.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAdminPage.Font = New System.Drawing.Font("Britannic Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdminPage.Location = New System.Drawing.Point(6, 196)
        Me.btnAdminPage.Name = "btnAdminPage"
        Me.btnAdminPage.Size = New System.Drawing.Size(188, 53)
        Me.btnAdminPage.TabIndex = 3
        Me.btnAdminPage.Text = "ADMINISTRATION"
        Me.btnAdminPage.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAdminPage.UseVisualStyleBackColor = True
        '
        'btnBookInfo
        '
        Me.btnBookInfo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBookInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBookInfo.Font = New System.Drawing.Font("Britannic Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBookInfo.Location = New System.Drawing.Point(6, 137)
        Me.btnBookInfo.Name = "btnBookInfo"
        Me.btnBookInfo.Size = New System.Drawing.Size(188, 53)
        Me.btnBookInfo.TabIndex = 2
        Me.btnBookInfo.Text = "BOOK INFORMATION"
        Me.btnBookInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBookInfo.UseVisualStyleBackColor = True
        '
        'btnSearchBook
        '
        Me.btnSearchBook.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearchBook.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearchBook.Font = New System.Drawing.Font("Britannic Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchBook.Location = New System.Drawing.Point(6, 78)
        Me.btnSearchBook.Name = "btnSearchBook"
        Me.btnSearchBook.Size = New System.Drawing.Size(188, 53)
        Me.btnSearchBook.TabIndex = 1
        Me.btnSearchBook.Text = "SEARCH BOOK"
        Me.btnSearchBook.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSearchBook.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtBookLevel)
        Me.GroupBox1.Controls.Add(Me.txtBookPublisher)
        Me.GroupBox1.Controls.Add(Me.txtBookPubYear)
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
        Me.GroupBox1.Location = New System.Drawing.Point(219, 67)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(652, 396)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, -5)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(198, 23)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "BOOK INFORMATION"
        '
        'txtBookLevel
        '
        Me.txtBookLevel.Enabled = False
        Me.txtBookLevel.Location = New System.Drawing.Point(215, 277)
        Me.txtBookLevel.Name = "txtBookLevel"
        Me.txtBookLevel.Size = New System.Drawing.Size(137, 20)
        Me.txtBookLevel.TabIndex = 30
        '
        'txtBookPublisher
        '
        Me.txtBookPublisher.Enabled = False
        Me.txtBookPublisher.Location = New System.Drawing.Point(232, 246)
        Me.txtBookPublisher.Name = "txtBookPublisher"
        Me.txtBookPublisher.Size = New System.Drawing.Size(137, 20)
        Me.txtBookPublisher.TabIndex = 29
        '
        'txtBookPubYear
        '
        Me.txtBookPubYear.Enabled = False
        Me.txtBookPubYear.Location = New System.Drawing.Point(266, 207)
        Me.txtBookPubYear.Name = "txtBookPubYear"
        Me.txtBookPubYear.Size = New System.Drawing.Size(137, 20)
        Me.txtBookPubYear.TabIndex = 28
        '
        'txtBookISBN
        '
        Me.txtBookISBN.Enabled = False
        Me.txtBookISBN.Location = New System.Drawing.Point(214, 178)
        Me.txtBookISBN.Name = "txtBookISBN"
        Me.txtBookISBN.Size = New System.Drawing.Size(137, 20)
        Me.txtBookISBN.TabIndex = 27
        '
        'txtBookAuthor
        '
        Me.txtBookAuthor.Enabled = False
        Me.txtBookAuthor.Location = New System.Drawing.Point(220, 148)
        Me.txtBookAuthor.Name = "txtBookAuthor"
        Me.txtBookAuthor.Size = New System.Drawing.Size(137, 20)
        Me.txtBookAuthor.TabIndex = 26
        '
        'txtBookTitle
        '
        Me.txtBookTitle.Enabled = False
        Me.txtBookTitle.Location = New System.Drawing.Point(209, 109)
        Me.txtBookTitle.Name = "txtBookTitle"
        Me.txtBookTitle.Size = New System.Drawing.Size(137, 20)
        Me.txtBookTitle.TabIndex = 25
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(173, 280)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 13)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Level:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(173, 249)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Publisher:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(173, 210)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 13)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Publication Year:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(173, 181)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "ISBN:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(173, 151)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Author:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(173, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Title:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(173, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Book Code:"
        '
        'txtBookCode
        '
        Me.txtBookCode.Location = New System.Drawing.Point(233, 72)
        Me.txtBookCode.Name = "txtBookCode"
        Me.txtBookCode.Size = New System.Drawing.Size(137, 20)
        Me.txtBookCode.TabIndex = 16
        '
        'UserBookInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(883, 475)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grpbxMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "UserBookInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SVBS Library System"
        Me.grpbxMenu.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpbxMenu As System.Windows.Forms.GroupBox
    Friend WithEvents btnHomePage As System.Windows.Forms.Button
    Friend WithEvents btnAdminPage As System.Windows.Forms.Button
    Friend WithEvents btnBookInfo As System.Windows.Forms.Button
    Friend WithEvents btnSearchBook As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtBookCode As System.Windows.Forms.TextBox
    Friend WithEvents txtBookLevel As System.Windows.Forms.TextBox
    Friend WithEvents txtBookPublisher As System.Windows.Forms.TextBox
    Friend WithEvents txtBookPubYear As System.Windows.Forms.TextBox
    Friend WithEvents txtBookISBN As System.Windows.Forms.TextBox
    Friend WithEvents txtBookAuthor As System.Windows.Forms.TextBox
    Friend WithEvents txtBookTitle As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
