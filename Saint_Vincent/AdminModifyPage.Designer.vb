<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminModifyPage
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
        Me.grpbxMenu.SuspendLayout()
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
        Me.grpbxMenu.TabIndex = 9
        Me.grpbxMenu.TabStop = False
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
        Me.GroupBox1.Location = New System.Drawing.Point(219, 53)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(652, 396)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        '
        'AdminModifyPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(883, 475)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grpbxMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "AdminModifyPage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SVBS Library System"
        Me.grpbxMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpbxMenu As System.Windows.Forms.GroupBox
    Friend WithEvents btnAddBook As System.Windows.Forms.Button
    Friend WithEvents btnModifyBook As System.Windows.Forms.Button
    Friend WithEvents btnDeleteBook As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnBack As System.Windows.Forms.Button
End Class
