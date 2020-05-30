<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MinimizedApps
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MinimizedApps))
        Me.Fade_in = New System.Windows.Forms.Timer(Me.components)
        Me.Location_changer = New System.Windows.Forms.Timer(Me.components)
        Me.picThumb = New System.Windows.Forms.PictureBox()
        Me.picIcon = New System.Windows.Forms.PictureBox()
        Me.lblName = New System.Windows.Forms.Label()
        CType(Me.picThumb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Fade_in
        '
        Me.Fade_in.Enabled = True
        Me.Fade_in.Interval = 1
        '
        'Location_changer
        '
        Me.Location_changer.Enabled = True
        Me.Location_changer.Interval = 1
        '
        'picThumb
        '
        Me.picThumb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picThumb.Location = New System.Drawing.Point(8, 42)
        Me.picThumb.Name = "picThumb"
        Me.picThumb.Size = New System.Drawing.Size(229, 131)
        Me.picThumb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picThumb.TabIndex = 0
        Me.picThumb.TabStop = False
        '
        'picIcon
        '
        Me.picIcon.BackColor = System.Drawing.Color.Transparent
        Me.picIcon.Image = CType(resources.GetObject("picIcon.Image"), System.Drawing.Image)
        Me.picIcon.Location = New System.Drawing.Point(-1, -1)
        Me.picIcon.Name = "picIcon"
        Me.picIcon.Size = New System.Drawing.Size(45, 40)
        Me.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picIcon.TabIndex = 1
        Me.picIcon.TabStop = False
        '
        'lblName
        '
        Me.lblName.BackColor = System.Drawing.Color.Transparent
        Me.lblName.Font = New System.Drawing.Font("ABeeZee", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblName.Location = New System.Drawing.Point(39, 4)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(198, 35)
        Me.lblName.TabIndex = 26
        Me.lblName.Text = "Name"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MinimizedApps
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(245, 181)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.picThumb)
        Me.Controls.Add(Me.picIcon)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "MinimizedApps"
        Me.Opacity = 0.0R
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.TopMost = True
        CType(Me.picThumb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Fade_in As System.Windows.Forms.Timer
    Friend WithEvents Location_changer As System.Windows.Forms.Timer
    Friend WithEvents picThumb As System.Windows.Forms.PictureBox
    Friend WithEvents picIcon As System.Windows.Forms.PictureBox
    Friend WithEvents lblName As System.Windows.Forms.Label
End Class
