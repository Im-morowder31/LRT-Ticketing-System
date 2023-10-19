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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.cbFrom = New System.Windows.Forms.ComboBox()
        Me.cbTo = New System.Windows.Forms.ComboBox()
        Me.cbDiscount = New System.Windows.Forms.ComboBox()
        Me.btnReset = New System.Windows.Forms.PictureBox()
        Me.btnProcess = New System.Windows.Forms.PictureBox()
        CType(Me.btnReset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnProcess, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbFrom
        '
        Me.cbFrom.BackColor = System.Drawing.SystemColors.Window
        Me.cbFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbFrom.FormattingEnabled = True
        Me.cbFrom.Items.AddRange(New Object() {"DAGUPAN CITY", "URDANETA CITY", "ROSALES", "PANIQUI", "MONCADA", "TARLAC CITY", "CONCEPCION", "CAPAS", "BAMBAN", "MABALACAT", "ANGELES CITY"})
        Me.cbFrom.Location = New System.Drawing.Point(59, 113)
        Me.cbFrom.Name = "cbFrom"
        Me.cbFrom.Size = New System.Drawing.Size(296, 28)
        Me.cbFrom.TabIndex = 0
        '
        'cbTo
        '
        Me.cbTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTo.FormattingEnabled = True
        Me.cbTo.Items.AddRange(New Object() {"DAGUPAN CITY", "URDANETA CITY", "ROSALES", "PANIQUI", "MONCADA", "TARLAC CITY", "CONCEPCION", "CAPAS", "BAMBAN", "MABALACAT", "ANGELES CITY"})
        Me.cbTo.Location = New System.Drawing.Point(59, 200)
        Me.cbTo.Name = "cbTo"
        Me.cbTo.Size = New System.Drawing.Size(296, 28)
        Me.cbTo.TabIndex = 1
        '
        'cbDiscount
        '
        Me.cbDiscount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDiscount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDiscount.FormattingEnabled = True
        Me.cbDiscount.Items.AddRange(New Object() {"NO DISCOUNT", "GOVERNMENT EMPLOYEE (10%)", "STUDENT (10%)", "SENIOR CITIZEN (20%)", "CHILDREN (50%)"})
        Me.cbDiscount.Location = New System.Drawing.Point(59, 288)
        Me.cbDiscount.Name = "cbDiscount"
        Me.cbDiscount.Size = New System.Drawing.Size(296, 28)
        Me.cbDiscount.TabIndex = 2
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.Transparent
        Me.btnReset.Image = Global.LRT_Ticketing.My.Resources.Resources.ResetUp
        Me.btnReset.Location = New System.Drawing.Point(75, 344)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(132, 51)
        Me.btnReset.TabIndex = 3
        Me.btnReset.TabStop = False
        '
        'btnProcess
        '
        Me.btnProcess.BackColor = System.Drawing.Color.Transparent
        Me.btnProcess.Image = Global.LRT_Ticketing.My.Resources.Resources.ProcessUp
        Me.btnProcess.Location = New System.Drawing.Point(238, 344)
        Me.btnProcess.Name = "btnProcess"
        Me.btnProcess.Size = New System.Drawing.Size(132, 51)
        Me.btnProcess.TabIndex = 4
        Me.btnProcess.TabStop = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.LRT_Ticketing.My.Resources.Resources.FinalBg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(446, 495)
        Me.Controls.Add(Me.btnProcess)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.cbDiscount)
        Me.Controls.Add(Me.cbTo)
        Me.Controls.Add(Me.cbFrom)
        Me.DoubleBuffered = True
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LRT Ticketing System"
        CType(Me.btnReset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnProcess, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cbFrom As ComboBox
    Friend WithEvents cbTo As ComboBox
    Friend WithEvents cbDiscount As ComboBox
    Friend WithEvents btnReset As PictureBox
    Friend WithEvents btnProcess As PictureBox
End Class
