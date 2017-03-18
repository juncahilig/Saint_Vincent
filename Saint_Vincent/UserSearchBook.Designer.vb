<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserSearchBook
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
        Me.btnGoSearch = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.grpbxMenu = New System.Windows.Forms.GroupBox()
        Me.btnHomePage = New System.Windows.Forms.Button()
        Me.btnAdministration = New System.Windows.Forms.Button()
        Me.btnBookInfo = New System.Windows.Forms.Button()
        Me.btnSearchBook = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblSearchBy = New System.Windows.Forms.Label()
        Me.btnTitle = New System.Windows.Forms.Button()
        Me.btnKeyword = New System.Windows.Forms.Button()
        Me.btnAuthor = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpbxMenu.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
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
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(54, 92)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(552, 298)
        Me.DataGridView1.TabIndex = 13
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
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(109, 21)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(413, 20)
        Me.txtSearch.TabIndex = 9
        '
        'grpbxMenu
        '
        Me.grpbxMenu.Controls.Add(Me.btnHomePage)
        Me.grpbxMenu.Controls.Add(Me.btnAdministration)
        Me.grpbxMenu.Controls.Add(Me.btnBookInfo)
        Me.grpbxMenu.Controls.Add(Me.btnSearchBook)
        Me.grpbxMenu.Location = New System.Drawing.Point(12, 67)
        Me.grpbxMenu.Name = "grpbxMenu"
        Me.grpbxMenu.Size = New System.Drawing.Size(201, 396)
        Me.grpbxMenu.TabIndex = 8
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
        Me.btnHomePage.TabIndex = 1
        Me.btnHomePage.Text = "HOME LIBRARY"
        Me.btnHomePage.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnHomePage.UseVisualStyleBackColor = True
        '
        'btnAdministration
        '
        Me.btnAdministration.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdministration.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAdministration.Font = New System.Drawing.Font("Britannic Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdministration.Location = New System.Drawing.Point(6, 196)
        Me.btnAdministration.Name = "btnAdministration"
        Me.btnAdministration.Size = New System.Drawing.Size(188, 53)
        Me.btnAdministration.TabIndex = 3
        Me.btnAdministration.Text = "ADMINISTRATION"
        Me.btnAdministration.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAdministration.UseVisualStyleBackColor = True
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
        Me.btnSearchBook.TabIndex = 0
        Me.btnSearchBook.Text = "SEARCH BOOK"
        Me.btnSearchBook.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSearchBook.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.btnTitle)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Controls.Add(Me.btnKeyword)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnAuthor)
        Me.GroupBox1.Controls.Add(Me.txtSearch)
        Me.GroupBox1.Controls.Add(Me.btnGoSearch)
        Me.GroupBox1.Location = New System.Drawing.Point(219, 67)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(652, 396)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, -4)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(144, 23)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "SEARCH BOOK"
        '
        'lblSearchBy
        '
        Me.lblSearchBy.AutoSize = True
        Me.lblSearchBy.Location = New System.Drawing.Point(818, 9)
        Me.lblSearchBy.Name = "lblSearchBy"
        Me.lblSearchBy.Size = New System.Drawing.Size(53, 13)
        Me.lblSearchBy.TabIndex = 17
        Me.lblSearchBy.Text = "SearchBy"
        Me.lblSearchBy.Visible = False
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
        'UserSearchBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(883, 475)
        Me.Controls.Add(Me.lblSearchBy)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grpbxMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "UserSearchBook"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SVBS Library System"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpbxMenu.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnGoSearch As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents grpbxMenu As System.Windows.Forms.GroupBox
    Friend WithEvents btnHomePage As System.Windows.Forms.Button
    Friend WithEvents btnAdministration As System.Windows.Forms.Button
    Friend WithEvents btnBookInfo As System.Windows.Forms.Button
    Friend WithEvents btnSearchBook As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblSearchBy As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnTitle As System.Windows.Forms.Button
    Friend WithEvents btnKeyword As System.Windows.Forms.Button
    Friend WithEvents btnAuthor As System.Windows.Forms.Button
End Class
