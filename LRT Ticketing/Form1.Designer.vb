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
        Me.components = New System.ComponentModel.Container()
        Me.pbLoading1 = New System.Windows.Forms.ProgressBar()
        Me.lblPercentProg = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'pbLoading1
        '
        Me.pbLoading1.Location = New System.Drawing.Point(21, 132)
        Me.pbLoading1.Name = "pbLoading1"
        Me.pbLoading1.Size = New System.Drawing.Size(513, 30)
        Me.pbLoading1.TabIndex = 0
        '
        'lblPercentProg
        '
        Me.lblPercentProg.AutoSize = True
        Me.lblPercentProg.BackColor = System.Drawing.Color.Transparent
        Me.lblPercentProg.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPercentProg.Location = New System.Drawing.Point(492, 165)
        Me.lblPercentProg.Name = "lblPercentProg"
        Me.lblPercentProg.Size = New System.Drawing.Size(34, 20)
        Me.lblPercentProg.TabIndex = 1
        Me.lblPercentProg.Text = "0%"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 30
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.LRT_Ticketing.My.Resources.Resources.Frame_1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(560, 296)
        Me.Controls.Add(Me.lblPercentProg)
        Me.Controls.Add(Me.pbLoading1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pbLoading1 As ProgressBar
    Friend WithEvents lblPercentProg As Label
    Friend WithEvents Timer1 As Timer
End Class
