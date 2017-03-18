<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminReturnBook
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtStudFirstName = New System.Windows.Forms.TextBox()
        Me.txtStudLastName = New System.Windows.Forms.TextBox()
        Me.txtStudNum = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBookTitle = New System.Windows.Forms.TextBox()
        Me.txtBookCode = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnReturnChanges = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.grpbxMenu = New System.Windows.Forms.GroupBox()
        Me.btnBorrowBook = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnPendingBook = New System.Windows.Forms.Button()
        Me.btnReturnBook = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.grpbxMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtStudFirstName)
        Me.GroupBox1.Controls.Add(Me.txtStudLastName)
        Me.GroupBox1.Controls.Add(Me.txtStudNum)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtBookTitle)
        Me.GroupBox1.Controls.Add(Me.txtBookCode)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnReturnChanges)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Location = New System.Drawing.Point(219, 67)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(652, 396)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        '
        'txtStudFirstName
        '
        Me.txtStudFirstName.Enabled = False
        Me.txtStudFirstName.Location = New System.Drawing.Point(176, 225)
        Me.txtStudFirstName.Name = "txtStudFirstName"
        Me.txtStudFirstName.Size = New System.Drawing.Size(100, 20)
        Me.txtStudFirstName.TabIndex = 37
        '
        'txtStudLastName
        '
        Me.txtStudLastName.Enabled = False
        Me.txtStudLastName.Location = New System.Drawing.Point(176, 199)
        Me.txtStudLastName.Name = "txtStudLastName"
        Me.txtStudLastName.Size = New System.Drawing.Size(100, 20)
        Me.txtStudLastName.TabIndex = 36
        '
        'txtStudNum
        '
        Me.txtStudNum.Location = New System.Drawing.Point(176, 170)
        Me.txtStudNum.Name = "txtStudNum"
        Me.txtStudNum.Size = New System.Drawing.Size(100, 20)
        Me.txtStudNum.TabIndex = 35
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(72, 173)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(87, 13)
        Me.Label9.TabIndex = 34
        Me.Label9.Text = "Student Number:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(72, 212)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 13)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "First Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(72, 193)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Last Name:"
        '
        'txtBookTitle
        '
        Me.txtBookTitle.Enabled = False
        Me.txtBookTitle.Location = New System.Drawing.Point(156, 126)
        Me.txtBookTitle.Name = "txtBookTitle"
        Me.txtBookTitle.Size = New System.Drawing.Size(100, 20)
        Me.txtBookTitle.TabIndex = 30
        '
        'txtBookCode
        '
        Me.txtBookCode.Location = New System.Drawing.Point(156, 95)
        Me.txtBookCode.Name = "txtBookCode"
        Me.txtBookCode.Size = New System.Drawing.Size(100, 20)
        Me.txtBookCode.TabIndex = 29
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(74, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Title:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(74, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Book Code:"
        '
        'btnReturnChanges
        '
        Me.btnReturnChanges.Location = New System.Drawing.Point(557, 331)
        Me.btnReturnChanges.Name = "btnReturnChanges"
        Me.btnReturnChanges.Size = New System.Drawing.Size(75, 23)
        Me.btnReturnChanges.TabIndex = 14
        Me.btnReturnChanges.Text = "RETURN"
        Me.btnReturnChanges.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, -5)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(144, 23)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "RETURN BOOK"
        '
        'grpbxMenu
        '
        Me.grpbxMenu.Controls.Add(Me.btnBorrowBook)
        Me.grpbxMenu.Controls.Add(Me.btnBack)
        Me.grpbxMenu.Controls.Add(Me.btnPendingBook)
        Me.grpbxMenu.Controls.Add(Me.btnReturnBook)
        Me.grpbxMenu.Location = New System.Drawing.Point(12, 67)
        Me.grpbxMenu.Name = "grpbxMenu"
        Me.grpbxMenu.Size = New System.Drawing.Size(201, 396)
        Me.grpbxMenu.TabIndex = 11
        Me.grpbxMenu.TabStop = False
        '
        'btnBorrowBook
        '
        Me.btnBorrowBook.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBorrowBook.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBorrowBook.Font = New System.Drawing.Font("Britannic Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrowBook.Location = New System.Drawing.Point(6, 19)
        Me.btnBorrowBook.Name = "btnBorrowBook"
        Me.btnBorrowBook.Size = New System.Drawing.Size(188, 53)
        Me.btnBorrowBook.TabIndex = 1
        Me.btnBorrowBook.Text = "BORROW BOOK"
        Me.btnBorrowBook.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBorrowBook.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBack.Font = New System.Drawing.Font("Britannic Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(6, 196)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(188, 53)
        Me.btnBack.TabIndex = 3
        Me.btnBack.Text = "BACK"
        Me.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnPendingBook
        '
        Me.btnPendingBook.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPendingBook.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPendingBook.Font = New System.Drawing.Font("Britannic Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPendingBook.Location = New System.Drawing.Point(6, 137)
        Me.btnPendingBook.Name = "btnPendingBook"
        Me.btnPendingBook.Size = New System.Drawing.Size(188, 53)
        Me.btnPendingBook.TabIndex = 2
        Me.btnPendingBook.Text = "PENDING BOOK"
        Me.btnPendingBook.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPendingBook.UseVisualStyleBackColor = True
        '
        'btnReturnBook
        '
        Me.btnReturnBook.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReturnBook.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnReturnBook.Font = New System.Drawing.Font("Britannic Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturnBook.Location = New System.Drawing.Point(6, 78)
        Me.btnReturnBook.Name = "btnReturnBook"
        Me.btnReturnBook.Size = New System.Drawing.Size(188, 53)
        Me.btnReturnBook.TabIndex = 0
        Me.btnReturnBook.Text = "RETURN BOOK"
        Me.btnReturnBook.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnReturnBook.UseVisualStyleBackColor = True
        '
        'AdminReturnBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(883, 475)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grpbxMenu)
        Me.Enabled = False
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "AdminReturnBook"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AdminReturnBook"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grpbxMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents grpbxMenu As System.Windows.Forms.GroupBox
    Friend WithEvents btnBorrowBook As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnPendingBook As System.Windows.Forms.Button
    Friend WithEvents btnReturnBook As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnReturnChanges As System.Windows.Forms.Button
    Friend WithEvents txtBookTitle As System.Windows.Forms.TextBox
    Friend WithEvents txtBookCode As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtStudFirstName As System.Windows.Forms.TextBox
    Friend WithEvents txtStudLastName As System.Windows.Forms.TextBox
    Friend WithEvents txtStudNum As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
