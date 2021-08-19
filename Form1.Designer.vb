<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.StandardCB = New System.Windows.Forms.ComboBox()
        Me.Standard_lable = New System.Windows.Forms.Label()
        Me.Class_lable = New System.Windows.Forms.Label()
        Me.ClassCB = New System.Windows.Forms.ComboBox()
        Me.GoToClass = New System.Windows.Forms.Button()
        Me.Selected_Path = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.pupils_Label = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'StandardCB
        '
        Me.StandardCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.StandardCB.FormattingEnabled = True
        Me.StandardCB.Items.AddRange(New Object() {"Select Standard"})
        Me.StandardCB.Location = New System.Drawing.Point(240, 221)
        Me.StandardCB.Name = "StandardCB"
        Me.StandardCB.Size = New System.Drawing.Size(121, 21)
        Me.StandardCB.TabIndex = 1
        '
        'Standard_lable
        '
        Me.Standard_lable.AutoSize = True
        Me.Standard_lable.Location = New System.Drawing.Point(181, 224)
        Me.Standard_lable.Name = "Standard_lable"
        Me.Standard_lable.Size = New System.Drawing.Size(53, 13)
        Me.Standard_lable.TabIndex = 2
        Me.Standard_lable.Text = "Standard:"
        '
        'Class_lable
        '
        Me.Class_lable.AutoSize = True
        Me.Class_lable.Location = New System.Drawing.Point(395, 224)
        Me.Class_lable.Name = "Class_lable"
        Me.Class_lable.Size = New System.Drawing.Size(35, 13)
        Me.Class_lable.TabIndex = 3
        Me.Class_lable.Text = "Class:"
        '
        'ClassCB
        '
        Me.ClassCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ClassCB.Enabled = False
        Me.ClassCB.FormattingEnabled = True
        Me.ClassCB.Location = New System.Drawing.Point(436, 221)
        Me.ClassCB.Name = "ClassCB"
        Me.ClassCB.Size = New System.Drawing.Size(121, 21)
        Me.ClassCB.TabIndex = 5
        '
        'GoToClass
        '
        Me.GoToClass.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GoToClass.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.GoToClass.FlatAppearance.CheckedBackColor = System.Drawing.Color.DodgerBlue
        Me.GoToClass.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.GoToClass.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.GoToClass.ForeColor = System.Drawing.Color.Black
        Me.GoToClass.Location = New System.Drawing.Point(307, 278)
        Me.GoToClass.Name = "GoToClass"
        Me.GoToClass.Size = New System.Drawing.Size(125, 23)
        Me.GoToClass.TabIndex = 6
        Me.GoToClass.Text = "Go to Class"
        Me.GoToClass.UseVisualStyleBackColor = True
        '
        'Selected_Path
        '
        Me.Selected_Path.AutoSize = True
        Me.Selected_Path.Location = New System.Drawing.Point(12, 381)
        Me.Selected_Path.Name = "Selected_Path"
        Me.Selected_Path.Size = New System.Drawing.Size(77, 13)
        Me.Selected_Path.TabIndex = 7
        Me.Selected_Path.Text = "Selected_Path"
        Me.Selected_Path.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Selected_Path.Visible = False
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue
        Me.Button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.DodgerBlue
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.Button1.Location = New System.Drawing.Point(651, 368)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Edit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'pupils_Label
        '
        Me.pupils_Label.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pupils_Label.AutoSize = True
        Me.pupils_Label.Font = New System.Drawing.Font("Courier New", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pupils_Label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.pupils_Label.Location = New System.Drawing.Point(173, 62)
        Me.pupils_Label.Name = "pupils_Label"
        Me.pupils_Label.Size = New System.Drawing.Size(392, 103)
        Me.pupils_Label.TabIndex = 9
        Me.pupils_Label.Text = "pupils"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(738, 403)
        Me.Controls.Add(Me.pupils_Label)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Selected_Path)
        Me.Controls.Add(Me.GoToClass)
        Me.Controls.Add(Me.ClassCB)
        Me.Controls.Add(Me.Class_lable)
        Me.Controls.Add(Me.Standard_lable)
        Me.Controls.Add(Me.StandardCB)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MasterSheet"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StandardCB As System.Windows.Forms.ComboBox
    Friend WithEvents Standard_lable As System.Windows.Forms.Label
    Friend WithEvents Class_lable As System.Windows.Forms.Label
    Friend WithEvents ClassCB As System.Windows.Forms.ComboBox
    Friend WithEvents GoToClass As System.Windows.Forms.Button
    Friend WithEvents Selected_Path As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents pupils_Label As System.Windows.Forms.Label

End Class
