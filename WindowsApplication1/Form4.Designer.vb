<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.btnDownload = New System.Windows.Forms.Button()
        Me.pgrDownload = New System.Windows.Forms.ProgressBar()
        Me.SuspendLayout()
        '
        'btnDownload
        '
        Me.btnDownload.Location = New System.Drawing.Point(53, 54)
        Me.btnDownload.Name = "btnDownload"
        Me.btnDownload.Size = New System.Drawing.Size(167, 41)
        Me.btnDownload.TabIndex = 0
        Me.btnDownload.Text = "Iniciar Download"
        Me.btnDownload.UseVisualStyleBackColor = True
        '
        'pgrDownload
        '
        Me.pgrDownload.Location = New System.Drawing.Point(12, 12)
        Me.pgrDownload.Name = "pgrDownload"
        Me.pgrDownload.Size = New System.Drawing.Size(260, 23)
        Me.pgrDownload.TabIndex = 1
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 117)
        Me.Controls.Add(Me.pgrDownload)
        Me.Controls.Add(Me.btnDownload)
        Me.Name = "Form4"
        Me.Text = "Form4"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnDownload As System.Windows.Forms.Button
    Friend WithEvents pgrDownload As System.Windows.Forms.ProgressBar
End Class
