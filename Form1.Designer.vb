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
        Me.label1 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Result = New System.Windows.Forms.TextBox()
        Me.Calculate = New System.Windows.Forms.Button()
        Me.remove = New System.Windows.Forms.Button()
        Me.CmbLenght = New System.Windows.Forms.ComboBox()
        Me.CmbWidth = New System.Windows.Forms.ComboBox()
        Me.CmbHeight = New System.Windows.Forms.ComboBox()
        Me.CmbrollCoverage = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(30, 70)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(75, 15)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Length(feet):"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(30, 110)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(70, 15)
        Me.label2.TabIndex = 1
        Me.label2.Text = "Width(feet):"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(30, 148)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(74, 15)
        Me.label3.TabIndex = 2
        Me.label3.Text = "Height(feet):"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(30, 185)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(117, 15)
        Me.label4.TabIndex = 3
        Me.label4.Text = "Roll Coverage(sqrFt):"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(364, 89)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Single Roll"
        '
        'Result
        '
        Me.Result.Location = New System.Drawing.Point(364, 107)
        Me.Result.Name = "Result"
        Me.Result.ReadOnly = True
        Me.Result.Size = New System.Drawing.Size(206, 23)
        Me.Result.TabIndex = 5
        '
        'Calculate
        '
        Me.Calculate.Location = New System.Drawing.Point(364, 145)
        Me.Calculate.Name = "Calculate"
        Me.Calculate.Size = New System.Drawing.Size(93, 23)
        Me.Calculate.TabIndex = 10
        Me.Calculate.Text = "Calculate"
        Me.Calculate.UseVisualStyleBackColor = True
        '
        'remove
        '
        Me.remove.Location = New System.Drawing.Point(463, 144)
        Me.remove.Name = "remove"
        Me.remove.Size = New System.Drawing.Size(93, 23)
        Me.remove.TabIndex = 11
        Me.remove.Text = "Exit"
        Me.remove.UseVisualStyleBackColor = True
        '
        'CmbLenght
        '
        Me.CmbLenght.FormattingEnabled = True
        Me.CmbLenght.Items.AddRange(New Object() {"10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30"})
        Me.CmbLenght.Location = New System.Drawing.Point(153, 67)
        Me.CmbLenght.Name = "CmbLenght"
        Me.CmbLenght.Size = New System.Drawing.Size(156, 23)
        Me.CmbLenght.TabIndex = 12
        '
        'CmbWidth
        '
        Me.CmbWidth.FormattingEnabled = True
        Me.CmbWidth.Items.AddRange(New Object() {"10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30"})
        Me.CmbWidth.Location = New System.Drawing.Point(153, 102)
        Me.CmbWidth.Name = "CmbWidth"
        Me.CmbWidth.Size = New System.Drawing.Size(156, 23)
        Me.CmbWidth.TabIndex = 13
        '
        'CmbHeight
        '
        Me.CmbHeight.FormattingEnabled = True
        Me.CmbHeight.Items.AddRange(New Object() {"10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30"})
        Me.CmbHeight.Location = New System.Drawing.Point(153, 140)
        Me.CmbHeight.Name = "CmbHeight"
        Me.CmbHeight.Size = New System.Drawing.Size(156, 23)
        Me.CmbHeight.TabIndex = 14
        '
        'CmbrollCoverage
        '
        Me.CmbrollCoverage.FormattingEnabled = True
        Me.CmbrollCoverage.Items.AddRange(New Object() {"40", "40.5", "41", "41.5", "42", "42.5", "43", "43.5", "44", "44.5", "45", "45.5", "46", "46.5", "47", "47.5", "48", "48.5", "49", "49.5", "50"})
        Me.CmbrollCoverage.Location = New System.Drawing.Point(153, 173)
        Me.CmbrollCoverage.Name = "CmbrollCoverage"
        Me.CmbrollCoverage.Size = New System.Drawing.Size(156, 23)
        Me.CmbrollCoverage.TabIndex = 15
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(612, 273)
        Me.Controls.Add(Me.CmbrollCoverage)
        Me.Controls.Add(Me.CmbHeight)
        Me.Controls.Add(Me.CmbWidth)
        Me.Controls.Add(Me.CmbLenght)
        Me.Controls.Add(Me.remove)
        Me.Controls.Add(Me.Calculate)
        Me.Controls.Add(Me.Result)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Name = "Form1"
        Me.Text = "Wallpaper app"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents label1 As Label
    Friend WithEvents label2 As Label
    Friend WithEvents label3 As Label
    Friend WithEvents label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Result As TextBox
    Friend WithEvents Calculate As Button
    Friend WithEvents remove As Button
    Friend WithEvents CmbLenght As ComboBox
    Friend WithEvents CmbWidth As ComboBox
    Friend WithEvents CmbHeight As ComboBox
    Friend WithEvents CmbrollCoverage As ComboBox
End Class
