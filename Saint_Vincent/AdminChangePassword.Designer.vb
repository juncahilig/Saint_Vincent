<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminChangePassword
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
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCancelChanges = New System.Windows.Forms.Button()
        Me.btnSaveChanges = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.grpbxMenu = New System.Windows.Forms.GroupBox()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnChangePassword = New System.Windows.Forms.Button()
        Me.btnTransaction = New System.Windows.Forms.Button()
        Me.btnSearchBook = New System.Windows.Forms.Button()
        Me.btnBookInventory = New System.Windows.Forms.Button()
        Me.btnModifyPage = New System.Windows.Forms.Button()
        Me.btnBookInfo = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.grpbxMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnCancelChanges)
        Me.GroupBox1.Controls.Add(Me.btnSaveChanges)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Location = New System.Drawing.Point(219, 25)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(652, 438)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(243, 166)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 21
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(243, 137)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 20
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(243, 108)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 19
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(121, 166)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Confirm Password:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(121, 137)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "New Password:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(124, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Old Password:"
        '
        'btnCancelChanges
        '
        Me.btnCancelChanges.Location = New System.Drawing.Point(439, 389)
        Me.btnCancelChanges.Name = "btnCancelChanges"
        Me.btnCancelChanges.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelChanges.TabIndex = 15
        Me.btnCancelChanges.Text = "CANCEL"
        Me.btnCancelChanges.UseVisualStyleBackColor = True
        '
        'btnSaveChanges
        '
        Me.btnSaveChanges.Location = New System.Drawing.Point(543, 377)
        Me.btnSaveChanges.Name = "btnSaveChanges"
        Me.btnSaveChanges.Size = New System.Drawing.Size(75, 23)
        Me.btnSaveChanges.TabIndex = 14
        Me.btnSaveChanges.Text = "SAVE"
        Me.btnSaveChanges.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, -5)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(196, 23)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "CHANGE PASSWORD"
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
        Me.grpbxMenu.Location = New System.Drawing.Point(12, 25)
        Me.grpbxMenu.Name = "grpbxMenu"
        Me.grpbxMenu.Size = New System.Drawing.Size(201, 438)
        Me.grpbxMenu.TabIndex = 10
        Me.grpbxMenu.TabStop = False
        '
        'btnLogout
        '
        Me.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLogout.Font = New System.Drawing.Font("Britannic Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.Location = New System.Drawing.Point(6, 373)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(188, 53)
        Me.btnLogout.TabIndex = 6
        Me.btnLogout.Text = "LOGOUT"
        Me.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'btnChangePassword
        '
        Me.btnChangePassword.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnChangePassword.Font = New System.Drawing.Font("Britannic Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChangePassword.Location = New System.Drawing.Point(6, 314)
        Me.btnChangePassword.Name = "btnChangePassword"
        Me.btnChangePassword.Size = New System.Drawing.Size(188, 53)
        Me.btnChangePassword.TabIndex = 5
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
        'AdminChangePassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(893, 475)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grpbxMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "AdminChangePassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SVBS Library System"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grpbxMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents grpbxMenu As System.Windows.Forms.GroupBox
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents btnChangePassword As System.Windows.Forms.Button
    Friend WithEvents btnTransaction As System.Windows.Forms.Button
    Friend WithEvents btnSearchBook As System.Windows.Forms.Button
    Friend WithEvents btnBookInventory As System.Windows.Forms.Button
    Friend WithEvents btnModifyPage As System.Windows.Forms.Button
    Friend WithEvents btnBookInfo As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnCancelChanges As System.Windows.Forms.Button
    Friend WithEvents btnSaveChanges As System.Windows.Forms.Button
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
