<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.btnStart = New System.Windows.Forms.Button()
        Me.lstThread = New System.Windows.Forms.ListBox()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(83, 13)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(115, 28)
        Me.btnStart.TabIndex = 0
        Me.btnStart.Text = "Disparar Thread"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'lstThread
        '
        Me.lstThread.FormattingEnabled = True
        Me.lstThread.Location = New System.Drawing.Point(12, 48)
        Me.lstThread.Name = "lstThread"
        Me.lstThread.Size = New System.Drawing.Size(260, 199)
        Me.lstThread.TabIndex = 1
        '
        'btnStop
        '
        Me.btnStop.Location = New System.Drawing.Point(83, 253)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(115, 28)
        Me.btnStop.TabIndex = 2
        Me.btnStop.Text = "Parar Thread"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 286)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.lstThread)
        Me.Controls.Add(Me.btnStart)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents lstThread As System.Windows.Forms.ListBox
    Friend WithEvents btnStop As System.Windows.Forms.Button
End Class
