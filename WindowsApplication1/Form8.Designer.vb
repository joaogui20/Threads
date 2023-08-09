<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form8
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
        Me.btnThread1 = New System.Windows.Forms.Button()
        Me.btnThread2 = New System.Windows.Forms.Button()
        Me.btnThread3 = New System.Windows.Forms.Button()
        Me.btnThread4 = New System.Windows.Forms.Button()
        Me.btnThread5 = New System.Windows.Forms.Button()
        Me.btnThread6 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnThread1
        '
        Me.btnThread1.Location = New System.Drawing.Point(57, 40)
        Me.btnThread1.Name = "btnThread1"
        Me.btnThread1.Size = New System.Drawing.Size(127, 36)
        Me.btnThread1.TabIndex = 0
        Me.btnThread1.Text = "Thread 1"
        Me.btnThread1.UseVisualStyleBackColor = True
        '
        'btnThread2
        '
        Me.btnThread2.Location = New System.Drawing.Point(57, 108)
        Me.btnThread2.Name = "btnThread2"
        Me.btnThread2.Size = New System.Drawing.Size(127, 36)
        Me.btnThread2.TabIndex = 1
        Me.btnThread2.Text = "Thread 2"
        Me.btnThread2.UseVisualStyleBackColor = True
        '
        'btnThread3
        '
        Me.btnThread3.Location = New System.Drawing.Point(57, 180)
        Me.btnThread3.Name = "btnThread3"
        Me.btnThread3.Size = New System.Drawing.Size(127, 36)
        Me.btnThread3.TabIndex = 2
        Me.btnThread3.Text = "Thread 3"
        Me.btnThread3.UseVisualStyleBackColor = True
        '
        'btnThread4
        '
        Me.btnThread4.Location = New System.Drawing.Point(249, 40)
        Me.btnThread4.Name = "btnThread4"
        Me.btnThread4.Size = New System.Drawing.Size(127, 36)
        Me.btnThread4.TabIndex = 3
        Me.btnThread4.Text = "Thread 4"
        Me.btnThread4.UseVisualStyleBackColor = True
        '
        'btnThread5
        '
        Me.btnThread5.Location = New System.Drawing.Point(249, 108)
        Me.btnThread5.Name = "btnThread5"
        Me.btnThread5.Size = New System.Drawing.Size(127, 36)
        Me.btnThread5.TabIndex = 4
        Me.btnThread5.Text = "Thread 5"
        Me.btnThread5.UseVisualStyleBackColor = True
        '
        'btnThread6
        '
        Me.btnThread6.Location = New System.Drawing.Point(249, 180)
        Me.btnThread6.Name = "btnThread6"
        Me.btnThread6.Size = New System.Drawing.Size(127, 36)
        Me.btnThread6.TabIndex = 5
        Me.btnThread6.Text = "Thread 6"
        Me.btnThread6.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(438, 257)
        Me.Controls.Add(Me.btnThread6)
        Me.Controls.Add(Me.btnThread5)
        Me.Controls.Add(Me.btnThread4)
        Me.Controls.Add(Me.btnThread3)
        Me.Controls.Add(Me.btnThread2)
        Me.Controls.Add(Me.btnThread1)
        Me.Name = "Form8"
        Me.Text = "Form8"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnThread1 As System.Windows.Forms.Button
    Friend WithEvents btnThread2 As System.Windows.Forms.Button
    Friend WithEvents btnThread3 As System.Windows.Forms.Button
    Friend WithEvents btnThread4 As System.Windows.Forms.Button
    Friend WithEvents btnThread5 As System.Windows.Forms.Button
    Friend WithEvents btnThread6 As System.Windows.Forms.Button

End Class
