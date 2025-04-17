<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.rad_1 = New System.Windows.Forms.RadioButton
        Me.rad_2 = New System.Windows.Forms.RadioButton
        Me.rad_3 = New System.Windows.Forms.RadioButton
        Me.txt_1 = New System.Windows.Forms.TextBox
        Me.txt_2 = New System.Windows.Forms.TextBox
        Me.txt_3 = New System.Windows.Forms.TextBox
        Me.btn_1 = New System.Windows.Forms.Button
        Me.lbl_1 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'rad_1
        '
        Me.rad_1.AutoSize = True
        Me.rad_1.Checked = True
        Me.rad_1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rad_1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rad_1.ForeColor = System.Drawing.Color.Red
        Me.rad_1.Location = New System.Drawing.Point(38, 71)
        Me.rad_1.Name = "rad_1"
        Me.rad_1.Size = New System.Drawing.Size(59, 20)
        Me.rad_1.TabIndex = 0
        Me.rad_1.TabStop = True
        Me.rad_1.Text = "Kelvin"
        Me.rad_1.UseVisualStyleBackColor = True
        '
        'rad_2
        '
        Me.rad_2.AutoSize = True
        Me.rad_2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rad_2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rad_2.ForeColor = System.Drawing.Color.Blue
        Me.rad_2.Location = New System.Drawing.Point(139, 71)
        Me.rad_2.Name = "rad_2"
        Me.rad_2.Size = New System.Drawing.Size(87, 20)
        Me.rad_2.TabIndex = 1
        Me.rad_2.Text = "Fahrenheit"
        Me.rad_2.UseVisualStyleBackColor = True
        '
        'rad_3
        '
        Me.rad_3.AutoSize = True
        Me.rad_3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rad_3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rad_3.ForeColor = System.Drawing.Color.Lime
        Me.rad_3.Location = New System.Drawing.Point(288, 71)
        Me.rad_3.Name = "rad_3"
        Me.rad_3.Size = New System.Drawing.Size(66, 20)
        Me.rad_3.TabIndex = 2
        Me.rad_3.Text = "Celsius"
        Me.rad_3.UseVisualStyleBackColor = True
        '
        'txt_1
        '
        Me.txt_1.BackColor = System.Drawing.Color.Black
        Me.txt_1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_1.ForeColor = System.Drawing.Color.Red
        Me.txt_1.Location = New System.Drawing.Point(23, 101)
        Me.txt_1.Name = "txt_1"
        Me.txt_1.Size = New System.Drawing.Size(100, 23)
        Me.txt_1.TabIndex = 4
        Me.txt_1.Text = "0"
        Me.txt_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_2
        '
        Me.txt_2.BackColor = System.Drawing.Color.Black
        Me.txt_2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_2.ForeColor = System.Drawing.Color.Blue
        Me.txt_2.Location = New System.Drawing.Point(138, 101)
        Me.txt_2.Name = "txt_2"
        Me.txt_2.Size = New System.Drawing.Size(100, 23)
        Me.txt_2.TabIndex = 5
        Me.txt_2.Text = "0"
        Me.txt_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_3
        '
        Me.txt_3.BackColor = System.Drawing.Color.Black
        Me.txt_3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_3.ForeColor = System.Drawing.Color.Lime
        Me.txt_3.Location = New System.Drawing.Point(270, 101)
        Me.txt_3.Name = "txt_3"
        Me.txt_3.Size = New System.Drawing.Size(100, 23)
        Me.txt_3.TabIndex = 6
        Me.txt_3.Text = "0"
        Me.txt_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn_1
        '
        Me.btn_1.BackColor = System.Drawing.Color.Black
        Me.btn_1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_1.ForeColor = System.Drawing.Color.Yellow
        Me.btn_1.Location = New System.Drawing.Point(23, 133)
        Me.btn_1.Name = "btn_1"
        Me.btn_1.Size = New System.Drawing.Size(347, 27)
        Me.btn_1.TabIndex = 7
        Me.btn_1.Text = "Convert"
        Me.btn_1.UseVisualStyleBackColor = False
        '
        'lbl_1
        '
        Me.lbl_1.AutoSize = True
        Me.lbl_1.Font = New System.Drawing.Font("Andalus", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lbl_1.ForeColor = System.Drawing.Color.Red
        Me.lbl_1.Location = New System.Drawing.Point(38, 5)
        Me.lbl_1.Name = "lbl_1"
        Me.lbl_1.Size = New System.Drawing.Size(61, 73)
        Me.lbl_1.TabIndex = 8
        Me.lbl_1.Text = "K"
        Me.lbl_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Andalus", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(165, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 73)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "F"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Andalus", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Lime
        Me.Label2.Location = New System.Drawing.Point(292, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 73)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "C"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(392, 168)
        Me.Controls.Add(Me.rad_3)
        Me.Controls.Add(Me.rad_2)
        Me.Controls.Add(Me.rad_1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_1)
        Me.Controls.Add(Me.btn_1)
        Me.Controls.Add(Me.txt_3)
        Me.Controls.Add(Me.txt_2)
        Me.Controls.Add(Me.txt_1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(400, 200)
        Me.MinimumSize = New System.Drawing.Size(400, 200)
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "KFC Converter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rad_1 As System.Windows.Forms.RadioButton
    Friend WithEvents rad_2 As System.Windows.Forms.RadioButton
    Friend WithEvents rad_3 As System.Windows.Forms.RadioButton
    Friend WithEvents txt_1 As System.Windows.Forms.TextBox
    Friend WithEvents txt_2 As System.Windows.Forms.TextBox
    Friend WithEvents txt_3 As System.Windows.Forms.TextBox
    Friend WithEvents btn_1 As System.Windows.Forms.Button
    Friend WithEvents lbl_1 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
