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
        Me.btnThread = New System.Windows.Forms.Button()
        Me.btnParada1 = New System.Windows.Forms.Button()
        Me.lstContagem1 = New System.Windows.Forms.ListBox()
        Me.lstContagem2 = New System.Windows.Forms.ListBox()
        Me.lstContagem3 = New System.Windows.Forms.ListBox()
        Me.btnThread2 = New System.Windows.Forms.Button()
        Me.btnParar2 = New System.Windows.Forms.Button()
        Me.btnSuspender = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.btnThread3 = New System.Windows.Forms.Button()
        Me.btnParar3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnThread
        '
        Me.btnThread.Location = New System.Drawing.Point(69, 12)
        Me.btnThread.Name = "btnThread"
        Me.btnThread.Size = New System.Drawing.Size(115, 28)
        Me.btnThread.TabIndex = 0
        Me.btnThread.Text = "Iniciar Thread 1"
        Me.btnThread.UseVisualStyleBackColor = True
        '
        'btnParada1
        '
        Me.btnParada1.Location = New System.Drawing.Point(69, 252)
        Me.btnParada1.Name = "btnParada1"
        Me.btnParada1.Size = New System.Drawing.Size(115, 28)
        Me.btnParada1.TabIndex = 1
        Me.btnParada1.Text = "Parar Thread 1"
        Me.btnParada1.UseVisualStyleBackColor = True
        '
        'lstContagem1
        '
        Me.lstContagem1.FormattingEnabled = True
        Me.lstContagem1.Location = New System.Drawing.Point(12, 47)
        Me.lstContagem1.Name = "lstContagem1"
        Me.lstContagem1.Size = New System.Drawing.Size(219, 199)
        Me.lstContagem1.TabIndex = 2
        '
        'lstContagem2
        '
        Me.lstContagem2.FormattingEnabled = True
        Me.lstContagem2.Location = New System.Drawing.Point(248, 47)
        Me.lstContagem2.Name = "lstContagem2"
        Me.lstContagem2.Size = New System.Drawing.Size(236, 199)
        Me.lstContagem2.TabIndex = 3
        '
        'lstContagem3
        '
        Me.lstContagem3.FormattingEnabled = True
        Me.lstContagem3.Location = New System.Drawing.Point(504, 47)
        Me.lstContagem3.Name = "lstContagem3"
        Me.lstContagem3.Size = New System.Drawing.Size(219, 199)
        Me.lstContagem3.TabIndex = 4
        '
        'btnThread2
        '
        Me.btnThread2.Location = New System.Drawing.Point(248, 12)
        Me.btnThread2.Name = "btnThread2"
        Me.btnThread2.Size = New System.Drawing.Size(115, 28)
        Me.btnThread2.TabIndex = 5
        Me.btnThread2.Text = "Iniciar Thread 2"
        Me.btnThread2.UseVisualStyleBackColor = True
        '
        'btnParar2
        '
        Me.btnParar2.Location = New System.Drawing.Point(369, 12)
        Me.btnParar2.Name = "btnParar2"
        Me.btnParar2.Size = New System.Drawing.Size(115, 28)
        Me.btnParar2.TabIndex = 6
        Me.btnParar2.Text = "Parar Thread 2"
        Me.btnParar2.UseVisualStyleBackColor = True
        '
        'btnSuspender
        '
        Me.btnSuspender.Location = New System.Drawing.Point(248, 253)
        Me.btnSuspender.Name = "btnSuspender"
        Me.btnSuspender.Size = New System.Drawing.Size(115, 28)
        Me.btnSuspender.TabIndex = 7
        Me.btnSuspender.Text = "Suspender Thread 2"
        Me.btnSuspender.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(369, 253)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(115, 28)
        Me.Button4.TabIndex = 8
        Me.Button4.Text = "Retomar Thread 2"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'btnThread3
        '
        Me.btnThread3.Location = New System.Drawing.Point(565, 12)
        Me.btnThread3.Name = "btnThread3"
        Me.btnThread3.Size = New System.Drawing.Size(115, 28)
        Me.btnThread3.TabIndex = 9
        Me.btnThread3.Text = "Iniciar Thread 3"
        Me.btnThread3.UseVisualStyleBackColor = True
        '
        'btnParar3
        '
        Me.btnParar3.Location = New System.Drawing.Point(565, 253)
        Me.btnParar3.Name = "btnParar3"
        Me.btnParar3.Size = New System.Drawing.Size(115, 28)
        Me.btnParar3.TabIndex = 10
        Me.btnParar3.Text = "Parar Thread 3"
        Me.btnParar3.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(736, 293)
        Me.Controls.Add(Me.btnParar3)
        Me.Controls.Add(Me.btnThread3)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.btnSuspender)
        Me.Controls.Add(Me.btnParar2)
        Me.Controls.Add(Me.btnThread2)
        Me.Controls.Add(Me.lstContagem3)
        Me.Controls.Add(Me.lstContagem2)
        Me.Controls.Add(Me.lstContagem1)
        Me.Controls.Add(Me.btnParada1)
        Me.Controls.Add(Me.btnThread)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnThread As System.Windows.Forms.Button
    Friend WithEvents btnParada1 As System.Windows.Forms.Button
    Friend WithEvents lstContagem1 As System.Windows.Forms.ListBox
    Friend WithEvents lstContagem2 As System.Windows.Forms.ListBox
    Friend WithEvents lstContagem3 As System.Windows.Forms.ListBox
    Friend WithEvents btnThread2 As System.Windows.Forms.Button
    Friend WithEvents btnParar2 As System.Windows.Forms.Button
    Friend WithEvents btnSuspender As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents btnThread3 As System.Windows.Forms.Button
    Friend WithEvents btnParar3 As System.Windows.Forms.Button

End Class
