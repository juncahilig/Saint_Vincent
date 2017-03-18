<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminSearchBook
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
        Me.btnTransaction = New System.Windows.Forms.Button()
        Me.btnSearchBook = New System.Windows.Forms.Button()
        Me.btnBookInventory = New System.Windows.Forms.Button()
        Me.btnModifyPage = New System.Windows.Forms.Button()
        Me.btnBookInfo = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnTitle = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnKeyword = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAuthor = New System.Windows.Forms.Button()
        Me.txtAdminSearch = New System.Windows.Forms.TextBox()
        Me.btnGoSearch = New System.Windows.Forms.Button()
        Me.lblSearchBy = New System.Windows.Forms.Label()
        Me.btnChangePassword = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.grpbxMenu.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpbxMenu
        '
        Me.grpbxMenu.Controls.Add(Me.btnLogout)
        Me.grpbxMenu.Controls.Add(Me.btnChangePassword)
        Me.grpbxMenu.Controls.Add(Me.btnTransaction)
        Me.grpbxMenu.Controls.Add(Me.btnSearchBook)
        Me.grpbxMenu.Controls.Add(Me.btnBookInventory)
        Me.grpbxMenu.Controls.Add(Me.btnModifyPage)
        Me.grpbxMenu.Controls.Add(Me.btnBookInfo)
        Me.grpbxMenu.Location = New System.Drawing.Point(12, 67)
        Me.grpbxMenu.Name = "grpbxMenu"
        Me.grpbxMenu.Size = New System.Drawing.Size(201, 438)
        Me.grpbxMenu.TabIndex = 8
        Me.grpbxMenu.TabStop = False
        '
        'btnTransaction
        '
        Me.btnTransaction.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnTransaction.Font = New System.Drawing.Font("Britannic Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTransaction.Location = New System.Drawing.Point(6, 255)
        Me.btnTransaction.Name = "btnTransaction"
        Me.btnTransaction.Size = New System.Drawing.Size(188, 53)
        Me.btnTransaction.TabIndex = 4
        Me.btnTransaction.Text = "TRANSACTIONS"
        Me.btnTransaction.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnTransaction.UseVisualStyleBackColor = True
        '
        'btnSearchBook
        '
        Me.btnSearchBook.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearchBook.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearchBook.Font = New System.Drawing.Font("Britannic Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchBook.Location = New System.Drawing.Point(6, 19)
        Me.btnSearchBook.Name = "btnSearchBook"
        Me.btnSearchBook.Size = New System.Drawing.Size(188, 53)
        Me.btnSearchBook.TabIndex = 0
        Me.btnSearchBook.Text = "SEARCH BOOK"
        Me.btnSearchBook.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSearchBook.UseVisualStyleBackColor = True
        '
        'btnBookInventory
        '
        Me.btnBookInventory.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBookInventory.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBookInventory.Font = New System.Drawing.Font("Britannic Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBookInventory.Location = New System.Drawing.Point(6, 196)
        Me.btnBookInventory.Name = "btnBookInventory"
        Me.btnBookInventory.Size = New System.Drawing.Size(188, 53)
        Me.btnBookInventory.TabIndex = 3
        Me.btnBookInventory.Text = "BOOK INVENTORY"
        Me.btnBookInventory.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBookInventory.UseVisualStyleBackColor = True
        '
        'btnModifyPage
        '
        Me.btnModifyPage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModifyPage.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnModifyPage.Font = New System.Drawing.Font("Britannic Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModifyPage.Location = New System.Drawing.Point(6, 137)
        Me.btnModifyPage.Name = "btnModifyPage"
        Me.btnModifyPage.Size = New System.Drawing.Size(188, 53)
        Me.btnModifyPage.TabIndex = 2
        Me.btnModifyPage.Text = "MODIFY BOOK"
        Me.btnModifyPage.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnModifyPage.UseVisualStyleBackColor = True
        '
        'btnBookInfo
        '
        Me.btnBookInfo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBookInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBookInfo.Font = New System.Drawing.Font("Britannic Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBookInfo.Location = New System.Drawing.Point(6, 78)
        Me.btnBookInfo.Name = "btnBookInfo"
        Me.btnBookInfo.Size = New System.Drawing.Size(188, 53)
        Me.btnBookInfo.TabIndex = 1
        Me.btnBookInfo.Text = "BOOK INFORMATION"
        Me.btnBookInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBookInfo.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.btnTitle)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Controls.Add(Me.btnKeyword)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnAuthor)
        Me.GroupBox1.Controls.Add(Me.txtAdminSearch)
        Me.GroupBox1.Controls.Add(Me.btnGoSearch)
        Me.GroupBox1.Location = New System.Drawing.Point(219, 67)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(652, 438)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        '
        'btnTitle
        '
        Me.btnTitle.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTitle.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnTitle.Location = New System.Drawing.Point(426, 50)
        Me.btnTitle.Name = "btnTitle"
        Me.btnTitle.Size = New System.Drawing.Size(180, 36)
        Me.btnTitle.TabIndex = 15
        Me.btnTitle.Text = "TITLE"
        Me.btnTitle.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(54, 92)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(552, 298)
        Me.DataGridView1.TabIndex = 13
        '
        'btnKeyword
        '
        Me.btnKeyword.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnKeyword.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnKeyword.Location = New System.Drawing.Point(240, 50)
        Me.btnKeyword.Name = "btnKeyword"
        Me.btnKeyword.Size = New System.Drawing.Size(180, 36)
        Me.btnKeyword.TabIndex = 14
        Me.btnKeyword.Text = "KEYWORD"
        Me.btnKeyword.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(49, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "SEARCH:"
        '
        'btnAuthor
        '
        Me.btnAuthor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAuthor.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAuthor.Location = New System.Drawing.Point(54, 50)
        Me.btnAuthor.Name = "btnAuthor"
        Me.btnAuthor.Size = New System.Drawing.Size(180, 36)
        Me.btnAuthor.TabIndex = 12
        Me.btnAuthor.Text = "AUTHOR"
        Me.btnAuthor.UseVisualStyleBackColor = True
        '
        'txtAdminSearch
        '
        Me.txtAdminSearch.Location = New System.Drawing.Point(109, 21)
        Me.txtAdminSearch.Name = "txtAdminSearch"
        Me.txtAdminSearch.Size = New System.Drawing.Size(413, 20)
        Me.txtAdminSearch.TabIndex = 9
        '
        'btnGoSearch
        '
        Me.btnGoSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGoSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnGoSearch.Location = New System.Drawing.Point(528, 21)
        Me.btnGoSearch.Name = "btnGoSearch"
        Me.btnGoSearch.Size = New System.Drawing.Size(78, 20)
        Me.btnGoSearch.TabIndex = 11
        Me.btnGoSearch.Text = "GO"
        Me.btnGoSearch.UseVisualStyleBackColor = True
        '
        'lblSearchBy
        '
        Me.lblSearchBy.AutoSize = True
        Me.lblSearchBy.Location = New System.Drawing.Point(818, 9)
        Me.lblSearchBy.Name = "lblSearchBy"
        Me.lblSearchBy.Size = New System.Drawing.Size(53, 13)
        Me.lblSearchBy.TabIndex = 18
        Me.lblSearchBy.Text = "SearchBy"
        '
        'btnChangePassword
        '
        Me.btnChangePassword.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnChangePassword.Font = New System.Drawing.Font("Britannic Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChangePassword.Location = New System.Drawing.Point(6, 314)
        Me.btnChangePassword.Name = "btnChangePassword"
        Me.btnChangePassword.Size = New System.Drawing.Size(188, 53)
        Me.btnChangePassword.TabIndex = 6
        Me.btnChangePassword.Text = "CHANGE PASSWORD"
        Me.btnChangePassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnChangePassword.UseVisualStyleBackColor = True
        '
        'btnLogout
        '
        Me.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLogout.Font = New System.Drawing.Font("Britannic Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.Location = New System.Drawing.Point(6, 373)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(188, 53)
        Me.btnLogout.TabIndex = 7
        Me.btnLogout.Text = "LOGOUT"
        Me.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, -4)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(144, 23)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "SEARCH BOOK"
        '
        'AdminSearchBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(883, 510)
        Me.Controls.Add(Me.lblSearchBy)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grpbxMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "AdminSearchBook"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SVBS Library System"
        Me.grpbxMenu.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpbxMenu As System.Windows.Forms.GroupBox
    Friend WithEvents btnTransaction As System.Windows.Forms.Button
    Friend WithEvents btnSearchBook As System.Windows.Forms.Button
    Friend WithEvents btnBookInventory As System.Windows.Forms.Button
    Friend WithEvents btnModifyPage As System.Windows.Forms.Button
    Friend WithEvents btnBookInfo As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnTitle As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnKeyword As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnAuthor As System.Windows.Forms.Button
    Friend WithEvents txtAdminSearch As System.Windows.Forms.TextBox
    Friend WithEvents btnGoSearch As System.Windows.Forms.Button
    Friend WithEvents lblSearchBy As System.Windows.Forms.Label
    Friend WithEvents btnChangePassword As System.Windows.Forms.Button
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
