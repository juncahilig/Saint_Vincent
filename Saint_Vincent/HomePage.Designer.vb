<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HomePage
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
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
        Me.grpbxMenu.TabIndex = 3
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
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(219, 67)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(652, 396)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(81, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(167, 23)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "LIBRARY SYSTEM"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, -5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(323, 23)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "SAINT VINCENT BLESSED SCHOOL"
        '
        'HomePage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(883, 475)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grpbxMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "HomePage"
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
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
