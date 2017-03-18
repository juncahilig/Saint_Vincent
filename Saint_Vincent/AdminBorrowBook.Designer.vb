<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminBorrowBook
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
        Me.cmbStudLevel = New System.Windows.Forms.ComboBox()
        Me.txtStudPending = New System.Windows.Forms.TextBox()
        Me.txtStudFirstName = New System.Windows.Forms.TextBox()
        Me.txtStudLastName = New System.Windows.Forms.TextBox()
        Me.txtStudNum = New System.Windows.Forms.TextBox()
        Me.txtBookOnHand = New System.Windows.Forms.TextBox()
        Me.txtBookAuthor = New System.Windows.Forms.TextBox()
        Me.txtBookTitle = New System.Windows.Forms.TextBox()
        Me.txtBookCode = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBorrowChanges = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.grpbxMenu = New System.Windows.Forms.GroupBox()
        Me.btnBorrowBook = New System.Windows.Forms.Button()
        Me.btnPendingBook = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnReturnBook = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.grpbxMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbStudLevel)
        Me.GroupBox1.Controls.Add(Me.txtStudPending)
        Me.GroupBox1.Controls.Add(Me.txtStudFirstName)
        Me.GroupBox1.Controls.Add(Me.txtStudLastName)
        Me.GroupBox1.Controls.Add(Me.txtStudNum)
        Me.GroupBox1.Controls.Add(Me.txtBookOnHand)
        Me.GroupBox1.Controls.Add(Me.txtBookAuthor)
        Me.GroupBox1.Controls.Add(Me.txtBookTitle)
        Me.GroupBox1.Controls.Add(Me.txtBookCode)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnBorrowChanges)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Location = New System.Drawing.Point(219, 67)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(652, 396)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        '
        'cmbStudLevel
        '
        Me.cmbStudLevel.FormattingEnabled = True
        Me.cmbStudLevel.Items.AddRange(New Object() {"KINDER", "PREP", "GRADE 1", "GRADE 2", "GRADE 3", "GRADE 4", "GRADE 5", "GRADE 6", "GRADE 7", "GRADE 8", "GRADE 9", "GRADE 10", "GRADE 11", "GRADE 12"})
        Me.cmbStudLevel.Location = New System.Drawing.Point(404, 156)
        Me.cmbStudLevel.Name = "cmbStudLevel"
        Me.cmbStudLevel.Size = New System.Drawing.Size(121, 21)
        Me.cmbStudLevel.TabIndex = 34
        '
        'txtStudPending
        '
        Me.txtStudPending.Location = New System.Drawing.Point(404, 180)
        Me.txtStudPending.Name = "txtStudPending"
        Me.txtStudPending.Size = New System.Drawing.Size(100, 20)
        Me.txtStudPending.TabIndex = 33
        '
        'txtStudFirstName
        '
        Me.txtStudFirstName.Location = New System.Drawing.Point(404, 130)
        Me.txtStudFirstName.Name = "txtStudFirstName"
        Me.txtStudFirstName.Size = New System.Drawing.Size(100, 20)
        Me.txtStudFirstName.TabIndex = 31
        '
        'txtStudLastName
        '
        Me.txtStudLastName.Location = New System.Drawing.Point(404, 104)
        Me.txtStudLastName.Name = "txtStudLastName"
        Me.txtStudLastName.Size = New System.Drawing.Size(100, 20)
        Me.txtStudLastName.TabIndex = 30
        '
        'txtStudNum
        '
        Me.txtStudNum.Location = New System.Drawing.Point(404, 75)
        Me.txtStudNum.Name = "txtStudNum"
        Me.txtStudNum.Size = New System.Drawing.Size(100, 20)
        Me.txtStudNum.TabIndex = 29
        '
        'txtBookOnHand
        '
        Me.txtBookOnHand.Location = New System.Drawing.Point(135, 176)
        Me.txtBookOnHand.Name = "txtBookOnHand"
        Me.txtBookOnHand.Size = New System.Drawing.Size(100, 20)
        Me.txtBookOnHand.TabIndex = 28
        '
        'txtBookAuthor
        '
        Me.txtBookAuthor.Location = New System.Drawing.Point(135, 147)
        Me.txtBookAuthor.Name = "txtBookAuthor"
        Me.txtBookAuthor.Size = New System.Drawing.Size(100, 20)
        Me.txtBookAuthor.TabIndex = 27
        '
        'txtBookTitle
        '
        Me.txtBookTitle.Location = New System.Drawing.Point(135, 114)
        Me.txtBookTitle.Name = "txtBookTitle"
        Me.txtBookTitle.Size = New System.Drawing.Size(100, 20)
        Me.txtBookTitle.TabIndex = 26
        '
        'txtBookCode
        '
        Me.txtBookCode.Location = New System.Drawing.Point(135, 83)
        Me.txtBookCode.Name = "txtBookCode"
        Me.txtBookCode.Size = New System.Drawing.Size(100, 20)
        Me.txtBookCode.TabIndex = 25
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(300, 176)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(77, 13)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "Pending Book:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(300, 78)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(87, 13)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Student Number:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(300, 147)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 13)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Level:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(300, 117)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 13)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "First Name:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(53, 176)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "On-Hand:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(53, 137)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Author:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(53, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Title:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(300, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Last Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(53, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Book Code:"
        '
        'btnBorrowChanges
        '
        Me.btnBorrowChanges.Location = New System.Drawing.Point(571, 367)
        Me.btnBorrowChanges.Name = "btnBorrowChanges"
        Me.btnBorrowChanges.Size = New System.Drawing.Size(75, 23)
        Me.btnBorrowChanges.TabIndex = 14
        Me.btnBorrowChanges.Text = "BORROW"
        Me.btnBorrowChanges.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, -5)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(153, 23)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "BORROW BOOK"
        '
        'grpbxMenu
        '
        Me.grpbxMenu.Controls.Add(Me.btnBorrowBook)
        Me.grpbxMenu.Controls.Add(Me.btnPendingBook)
        Me.grpbxMenu.Controls.Add(Me.btnBack)
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
        'btnPendingBook
        '
        Me.btnPendingBook.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPendingBook.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPendingBook.Font = New System.Drawing.Font("Britannic Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPendingBook.Location = New System.Drawing.Point(7, 137)
        Me.btnPendingBook.Name = "btnPendingBook"
        Me.btnPendingBook.Size = New System.Drawing.Size(188, 53)
        Me.btnPendingBook.TabIndex = 3
        Me.btnPendingBook.Text = "PENDING BOOK"
        Me.btnPendingBook.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPendingBook.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBack.Font = New System.Drawing.Font("Britannic Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(7, 196)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(188, 53)
        Me.btnBack.TabIndex = 2
        Me.btnBack.Text = "BACK"
        Me.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBack.UseVisualStyleBackColor = True
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
        'AdminBorrowBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(883, 475)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grpbxMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "AdminBorrowBook"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AdminBorrowBook"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grpbxMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents grpbxMenu As System.Windows.Forms.GroupBox
    Friend WithEvents btnBorrowBook As System.Windows.Forms.Button
    Friend WithEvents btnPendingBook As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnReturnBook As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnBorrowChanges As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtStudPending As System.Windows.Forms.TextBox
    Friend WithEvents txtStudFirstName As System.Windows.Forms.TextBox
    Friend WithEvents txtStudLastName As System.Windows.Forms.TextBox
    Friend WithEvents txtStudNum As System.Windows.Forms.TextBox
    Friend WithEvents txtBookOnHand As System.Windows.Forms.TextBox
    Friend WithEvents txtBookAuthor As System.Windows.Forms.TextBox
    Friend WithEvents txtBookTitle As System.Windows.Forms.TextBox
    Friend WithEvents txtBookCode As System.Windows.Forms.TextBox
    Friend WithEvents cmbStudLevel As System.Windows.Forms.ComboBox
End Class
