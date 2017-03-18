<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminInventory
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
        Me.btnChangePassword = New System.Windows.Forms.Button()
        Me.btnTransaction = New System.Windows.Forms.Button()
        Me.btnSearchBook = New System.Windows.Forms.Button()
        Me.btnBookInventory = New System.Windows.Forms.Button()
        Me.btnModifyPage = New System.Windows.Forms.Button()
        Me.btnBookInfo = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnTitle = New System.Windows.Forms.Button()
        Me.btnKeyword = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAuthor = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnGoSearch = New System.Windows.Forms.Button()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.grpbxMenu.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpbxMenu
        '
        Me.grpbxMenu.Controls.Add(Me.btnChangePassword)
        Me.grpbxMenu.Controls.Add(Me.btnTransaction)
        Me.grpbxMenu.Controls.Add(Me.btnSearchBook)
        Me.grpbxMenu.Controls.Add(Me.btnBookInventory)
        Me.grpbxMenu.Controls.Add(Me.btnModifyPage)
        Me.grpbxMenu.Controls.Add(Me.btnBookInfo)
        Me.grpbxMenu.Location = New System.Drawing.Point(12, 39)
        Me.grpbxMenu.Name = "grpbxMenu"
        Me.grpbxMenu.Size = New System.Drawing.Size(201, 435)
        Me.grpbxMenu.TabIndex = 5
        Me.grpbxMenu.TabStop = False
        '
        'btnChangePassword
        '
        Me.btnChangePassword.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnChangePassword.Font = New System.Drawing.Font("Britannic Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChangePassword.Location = New System.Drawing.Point(7, 314)
        Me.btnChangePassword.Name = "btnChangePassword"
        Me.btnChangePassword.Size = New System.Drawing.Size(188, 53)
        Me.btnChangePassword.TabIndex = 20
        Me.btnChangePassword.Text = "CHANGE PASSWORD"
        Me.btnChangePassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnChangePassword.UseVisualStyleBackColor = True
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
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(6, 90)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(640, 300)
        Me.DataGridView1.TabIndex = 6
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.btnTitle)
        Me.GroupBox1.Controls.Add(Me.btnKeyword)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnAuthor)
        Me.GroupBox1.Controls.Add(Me.txtSearch)
        Me.GroupBox1.Controls.Add(Me.btnGoSearch)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Location = New System.Drawing.Point(219, 39)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(652, 396)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, -5)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(174, 23)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "BOOK INVENTORY"
        '
        'btnTitle
        '
        Me.btnTitle.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTitle.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnTitle.Location = New System.Drawing.Point(431, 48)
        Me.btnTitle.Name = "btnTitle"
        Me.btnTitle.Size = New System.Drawing.Size(180, 36)
        Me.btnTitle.TabIndex = 21
        Me.btnTitle.Text = "TITLE"
        Me.btnTitle.UseVisualStyleBackColor = True
        '
        'btnKeyword
        '
        Me.btnKeyword.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnKeyword.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnKeyword.Location = New System.Drawing.Point(245, 48)
        Me.btnKeyword.Name = "btnKeyword"
        Me.btnKeyword.Size = New System.Drawing.Size(180, 36)
        Me.btnKeyword.TabIndex = 20
        Me.btnKeyword.Text = "KEYWORD"
        Me.btnKeyword.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(54, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "SEARCH:"
        '
        'btnAuthor
        '
        Me.btnAuthor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAuthor.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAuthor.Location = New System.Drawing.Point(59, 48)
        Me.btnAuthor.Name = "btnAuthor"
        Me.btnAuthor.Size = New System.Drawing.Size(180, 36)
        Me.btnAuthor.TabIndex = 19
        Me.btnAuthor.Text = "AUTHOR"
        Me.btnAuthor.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(114, 19)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(413, 20)
        Me.txtSearch.TabIndex = 16
        '
        'btnGoSearch
        '
        Me.btnGoSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGoSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnGoSearch.Location = New System.Drawing.Point(533, 19)
        Me.btnGoSearch.Name = "btnGoSearch"
        Me.btnGoSearch.Size = New System.Drawing.Size(78, 20)
        Me.btnGoSearch.TabIndex = 18
        Me.btnGoSearch.Text = "GO"
        Me.btnGoSearch.UseVisualStyleBackColor = True
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Location = New System.Drawing.Point(818, 9)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(53, 13)
        Me.lblSearch.TabIndex = 18
        Me.lblSearch.Text = "SearchBy"
        '
        'btnLogout
        '
        Me.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLogout.Font = New System.Drawing.Font("Britannic Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.Location = New System.Drawing.Point(19, 412)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(188, 53)
        Me.btnLogout.TabIndex = 19
        Me.btnLogout.Text = "LOGOUT"
        Me.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'AdminInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(883, 516)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.lblSearch)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grpbxMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "AdminInventory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SVBS Library System"
        Me.grpbxMenu.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpbxMenu As System.Windows.Forms.GroupBox
    Friend WithEvents btnTransaction As System.Windows.Forms.Button
    Friend WithEvents btnSearchBook As System.Windows.Forms.Button
    Friend WithEvents btnBookInventory As System.Windows.Forms.Button
    Friend WithEvents btnModifyPage As System.Windows.Forms.Button
    Friend WithEvents btnBookInfo As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnTitle As System.Windows.Forms.Button
    Friend WithEvents btnKeyword As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnAuthor As System.Windows.Forms.Button
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents btnGoSearch As System.Windows.Forms.Button
    Friend WithEvents lblSearch As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents btnChangePassword As System.Windows.Forms.Button
End Class
