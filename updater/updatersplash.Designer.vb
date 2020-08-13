<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class updatersplash
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(updatersplash))
        Me.Timeupdate = New System.Windows.Forms.Timer(Me.components)
        Me.textupdate = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Timeupdate
        '
        Me.Timeupdate.Interval = 1000
        '
        'textupdate
        '
        Me.textupdate.AutoSize = True
        Me.textupdate.BackColor = System.Drawing.Color.Transparent
        Me.textupdate.Location = New System.Drawing.Point(137, 246)
        Me.textupdate.Name = "textupdate"
        Me.textupdate.Size = New System.Drawing.Size(130, 13)
        Me.textupdate.TabIndex = 0
        Me.textupdate.Text = "Conectando a database..."
        Me.textupdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'updatersplash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InfoText
        Me.BackgroundImage = Global.updater.My.Resources.Resources.updaterlogo
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(387, 260)
        Me.Controls.Add(Me.textupdate)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "updatersplash"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "upsplash"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timeupdate As System.Windows.Forms.Timer
    Friend WithEvents textupdate As Label
End Class
