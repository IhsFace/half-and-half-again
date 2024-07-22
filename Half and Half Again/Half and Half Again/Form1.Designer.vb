<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        GroupBox1 = New GroupBox()
        lstArrayItems = New ListBox()
        btnLoadList = New Button()
        GroupBox2 = New GroupBox()
        lblOutputMsg = New Label()
        Label3 = New Label()
        btnSearch = New Button()
        txtInput = New TextBox()
        Label2 = New Label()
        GroupBox3 = New GroupBox()
        btnExit = New Button()
        btnClear = New Button()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 16F)
        Label1.ForeColor = Color.MediumTurquoise
        Label1.Location = New Point(126, 53)
        Label1.Name = "Label1"
        Label1.Size = New Size(616, 59)
        Label1.TabIndex = 0
        Label1.Text = "BINARY SEARCH OF AN ARRAY"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(lstArrayItems)
        GroupBox1.ForeColor = SystemColors.Control
        GroupBox1.Location = New Point(55, 137)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(316, 545)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        GroupBox1.Text = "Array Contents"
        ' 
        ' lstArrayItems
        ' 
        lstArrayItems.FormattingEnabled = True
        lstArrayItems.Location = New Point(25, 53)
        lstArrayItems.Name = "lstArrayItems"
        lstArrayItems.Size = New Size(264, 452)
        lstArrayItems.TabIndex = 0
        ' 
        ' btnLoadList
        ' 
        btnLoadList.Location = New Point(421, 169)
        btnLoadList.Name = "btnLoadList"
        btnLoadList.Size = New Size(150, 46)
        btnLoadList.TabIndex = 2
        btnLoadList.Text = "Load Array"
        btnLoadList.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(lblOutputMsg)
        GroupBox2.Controls.Add(Label3)
        GroupBox2.Controls.Add(btnSearch)
        GroupBox2.Controls.Add(txtInput)
        GroupBox2.Controls.Add(Label2)
        GroupBox2.ForeColor = SystemColors.Control
        GroupBox2.Location = New Point(423, 270)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(703, 217)
        GroupBox2.TabIndex = 3
        GroupBox2.TabStop = False
        ' 
        ' lblOutputMsg
        ' 
        lblOutputMsg.BackColor = Color.LightSteelBlue
        lblOutputMsg.ForeColor = SystemColors.ControlText
        lblOutputMsg.Location = New Point(133, 142)
        lblOutputMsg.Name = "lblOutputMsg"
        lblOutputMsg.Size = New Size(500, 32)
        lblOutputMsg.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(32, 142)
        Label3.Name = "Label3"
        Label3.Size = New Size(83, 32)
        Label3.TabIndex = 3
        Label3.Text = "Result:"
        ' 
        ' btnSearch
        ' 
        btnSearch.ForeColor = SystemColors.ControlText
        btnSearch.Location = New Point(542, 43)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(150, 46)
        btnSearch.TabIndex = 2
        btnSearch.Text = "Search >"
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' txtInput
        ' 
        txtInput.Location = New Point(336, 47)
        txtInput.Name = "txtInput"
        txtInput.Size = New Size(200, 39)
        txtInput.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(6, 50)
        Label2.Name = "Label2"
        Label2.Size = New Size(324, 32)
        Label2.TabIndex = 0
        Label2.Text = "Type in a Value to Search For"
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(btnExit)
        GroupBox3.Controls.Add(btnClear)
        GroupBox3.Location = New Point(715, 567)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(400, 106)
        GroupBox3.TabIndex = 4
        GroupBox3.TabStop = False
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(220, 38)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(150, 46)
        btnExit.TabIndex = 1
        btnExit.Text = "EXIT"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(35, 38)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(150, 46)
        btnClear.TabIndex = 0
        btnClear.Text = "CLEAR"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Indigo
        ClientSize = New Size(1174, 729)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(btnLoadList)
        Controls.Add(GroupBox1)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Half and Half Again"
        GroupBox1.ResumeLayout(False)
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox3.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lstArrayItems As ListBox
    Friend WithEvents btnLoadList As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtInput As TextBox
    Friend WithEvents lblOutputMsg As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnExit As Button
    Friend WithEvents btnClear As Button

End Class
