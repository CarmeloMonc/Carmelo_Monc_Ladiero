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
        Me.Math_txtbox = New System.Windows.Forms.TextBox()
        Me.Science_txtbox = New System.Windows.Forms.TextBox()
        Me.English_txtbox = New System.Windows.Forms.TextBox()
        Me.Evaluate_btn = New System.Windows.Forms.Button()
        Me.Math = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Math_txtbox
        '
        Me.Math_txtbox.Location = New System.Drawing.Point(115, 56)
        Me.Math_txtbox.Name = "Math_txtbox"
        Me.Math_txtbox.Size = New System.Drawing.Size(194, 20)
        Me.Math_txtbox.TabIndex = 0
        '
        'Science_txtbox
        '
        Me.Science_txtbox.Location = New System.Drawing.Point(115, 142)
        Me.Science_txtbox.Name = "Science_txtbox"
        Me.Science_txtbox.Size = New System.Drawing.Size(194, 20)
        Me.Science_txtbox.TabIndex = 1
        '
        'English_txtbox
        '
        Me.English_txtbox.Location = New System.Drawing.Point(115, 239)
        Me.English_txtbox.Name = "English_txtbox"
        Me.English_txtbox.Size = New System.Drawing.Size(194, 20)
        Me.English_txtbox.TabIndex = 2
        '
        'Evaluate_btn
        '
        Me.Evaluate_btn.Location = New System.Drawing.Point(176, 283)
        Me.Evaluate_btn.Name = "Evaluate_btn"
        Me.Evaluate_btn.Size = New System.Drawing.Size(75, 23)
        Me.Evaluate_btn.TabIndex = 3
        Me.Evaluate_btn.Text = "Evaluate"
        Me.Evaluate_btn.UseVisualStyleBackColor = True
        '
        'Math
        '
        Me.Math.AutoSize = True
        Me.Math.Location = New System.Drawing.Point(116, 30)
        Me.Math.Name = "Math"
        Me.Math.Size = New System.Drawing.Size(31, 13)
        Me.Math.TabIndex = 4
        Me.Math.Text = "Math"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(116, 117)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Science"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(116, 214)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "English"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(456, 377)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Math)
        Me.Controls.Add(Me.Evaluate_btn)
        Me.Controls.Add(Me.English_txtbox)
        Me.Controls.Add(Me.Science_txtbox)
        Me.Controls.Add(Me.Math_txtbox)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Math_txtbox As TextBox
    Friend WithEvents Science_txtbox As TextBox
    Friend WithEvents English_txtbox As TextBox
    Friend WithEvents Evaluate_btn As Button
    Friend WithEvents Math As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
