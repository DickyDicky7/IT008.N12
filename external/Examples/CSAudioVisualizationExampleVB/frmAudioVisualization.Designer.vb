<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAudioVisualization
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAudioVisualization))
        Me.cmdOrderLicense = New System.Windows.Forms.Button()
        Me.lblRecorderMode = New System.Windows.Forms.Label()
        Me.cboRecorderMode = New System.Windows.Forms.ComboBox()
        Me.lblAudioSource = New System.Windows.Forms.Label()
        Me.cboAudioSource = New System.Windows.Forms.ComboBox()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.AudioVisualization1 = New CSAudioVisualization.AudioVisualization()
        Me.SuspendLayout()
        '
        'cmdOrderLicense
        '
        Me.cmdOrderLicense.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.cmdOrderLicense.Image = CType(resources.GetObject("cmdOrderLicense.Image"), System.Drawing.Image)
        Me.cmdOrderLicense.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdOrderLicense.Location = New System.Drawing.Point(429, 487)
        Me.cmdOrderLicense.Name = "cmdOrderLicense"
        Me.cmdOrderLicense.Size = New System.Drawing.Size(160, 34)
        Me.cmdOrderLicense.TabIndex = 294
        Me.cmdOrderLicense.Text = "Order a license online"
        Me.cmdOrderLicense.UseVisualStyleBackColor = True
        '
        'lblRecorderMode
        '
        Me.lblRecorderMode.AutoSize = True
        Me.lblRecorderMode.Location = New System.Drawing.Point(56, 26)
        Me.lblRecorderMode.Name = "lblRecorderMode"
        Me.lblRecorderMode.Size = New System.Drawing.Size(81, 13)
        Me.lblRecorderMode.TabIndex = 293
        Me.lblRecorderMode.Text = "Recorder Mode"
        '
        'cboRecorderMode
        '
        Me.cboRecorderMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRecorderMode.FormattingEnabled = True
        Me.cboRecorderMode.Location = New System.Drawing.Point(59, 42)
        Me.cboRecorderMode.Name = "cboRecorderMode"
        Me.cboRecorderMode.Size = New System.Drawing.Size(530, 21)
        Me.cboRecorderMode.TabIndex = 292
        '
        'lblAudioSource
        '
        Me.lblAudioSource.AutoSize = True
        Me.lblAudioSource.Location = New System.Drawing.Point(56, 79)
        Me.lblAudioSource.Name = "lblAudioSource"
        Me.lblAudioSource.Size = New System.Drawing.Size(71, 13)
        Me.lblAudioSource.TabIndex = 291
        Me.lblAudioSource.Text = "Audio Source"
        '
        'cboAudioSource
        '
        Me.cboAudioSource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAudioSource.FormattingEnabled = True
        Me.cboAudioSource.Location = New System.Drawing.Point(59, 95)
        Me.cboAudioSource.Name = "cboAudioSource"
        Me.cboAudioSource.Size = New System.Drawing.Size(530, 21)
        Me.cboAudioSource.TabIndex = 290
        '
        'btnStop
        '
        Me.btnStop.Location = New System.Drawing.Point(196, 487)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(131, 34)
        Me.btnStop.TabIndex = 289
        Me.btnStop.Text = "Stop"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(59, 487)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(131, 34)
        Me.btnStart.TabIndex = 288
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'AudioVisualization1
        '
        Me.AudioVisualization1.AudioSource = Nothing
        Me.AudioVisualization1.BarCount = 50
        Me.AudioVisualization1.BarSpacing = 2
        Me.AudioVisualization1.ColorBase = System.Drawing.Color.DarkRed
        Me.AudioVisualization1.ColorMax = System.Drawing.Color.Snow
        Me.AudioVisualization1.DeviceIndex = 0
        Me.AudioVisualization1.FileName = Nothing
        Me.AudioVisualization1.HighQuality = True
        Me.AudioVisualization1.Interval = 40
        Me.AudioVisualization1.IsXLogScale = True
        Me.AudioVisualization1.Location = New System.Drawing.Point(59, 133)
        Me.AudioVisualization1.MaximumFrequency = 10000
        Me.AudioVisualization1.MessageArgs = Nothing
        Me.AudioVisualization1.Name = "AudioVisualization1"
        Me.AudioVisualization1.pic3DGraph = Nothing
        Me.AudioVisualization1.Size = New System.Drawing.Size(530, 329)
        Me.AudioVisualization1.TabIndex = 295
        Me.AudioVisualization1.UseAverage = True
        Me.AudioVisualization1.UserKey = "Your registration key"
        Me.AudioVisualization1.UserName = "Your email"
        Me.AudioVisualization1.VisMode = CSAudioVisualization.GraphMode.ModeSpectrum
        '
        'frmAudioVisualization
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(645, 547)
        Me.Controls.Add(Me.AudioVisualization1)
        Me.Controls.Add(Me.cmdOrderLicense)
        Me.Controls.Add(Me.lblRecorderMode)
        Me.Controls.Add(Me.cboRecorderMode)
        Me.Controls.Add(Me.lblAudioSource)
        Me.Controls.Add(Me.cboAudioSource)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.btnStart)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAudioVisualization"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CSAudioVisualization - VB Full Example"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents cmdOrderLicense As Button
    Private WithEvents lblRecorderMode As Label
    Private WithEvents cboRecorderMode As ComboBox
    Private WithEvents lblAudioSource As Label
    Private WithEvents cboAudioSource As ComboBox
    Private WithEvents btnStop As Button
    Private WithEvents btnStart As Button
    Friend WithEvents AudioVisualization1 As CSAudioVisualization.AudioVisualization
End Class
