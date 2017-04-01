<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdatingForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UpdatingForm))
        Me.lvwFile = New System.Windows.Forms.ListView()
        Me.colStatus = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colVersion = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clsProgress = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.imageList = New System.Windows.Forms.ImageList(Me.components)
        Me.lblDownloadFile = New System.Windows.Forms.Label()
        Me.lblSinglePercent = New System.Windows.Forms.Label()
        Me.lblAllTip = New System.Windows.Forms.Label()
        Me.lblAllPercent = New System.Windows.Forms.Label()
        Me.prbSingle = New System.Windows.Forms.ProgressBar()
        Me.prbAll = New System.Windows.Forms.ProgressBar()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.lblTip = New System.Windows.Forms.Label()
        Me.picBack = New System.Windows.Forms.PictureBox()
        CType(Me.picBack, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lvwFile
        '
        Me.lvwFile.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colStatus, Me.colName, Me.colVersion, Me.clsProgress})
        Me.lvwFile.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwFile.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lvwFile.FullRowSelect = True
        Me.lvwFile.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvwFile.HideSelection = False
        Me.lvwFile.Location = New System.Drawing.Point(139, 25)
        Me.lvwFile.MultiSelect = False
        Me.lvwFile.Name = "lvwFile"
        Me.lvwFile.Size = New System.Drawing.Size(382, 139)
        Me.lvwFile.SmallImageList = Me.imageList
        Me.lvwFile.TabIndex = 2
        Me.lvwFile.UseCompatibleStateImageBehavior = False
        Me.lvwFile.View = System.Windows.Forms.View.Details
        '
        'colStatus
        '
        Me.colStatus.Text = ""
        Me.colStatus.Width = 24
        '
        'colName
        '
        Me.colName.Text = "文件名"
        Me.colName.Width = 180
        '
        'colVersion
        '
        Me.colVersion.Text = "版本"
        Me.colVersion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.colVersion.Width = 100
        '
        'clsProgress
        '
        Me.clsProgress.Text = "状态"
        Me.clsProgress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'imageList
        '
        Me.imageList.ImageStream = CType(resources.GetObject("imageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imageList.TransparentColor = System.Drawing.Color.Transparent
        Me.imageList.Images.SetKeyName(0, "1.jpg")
        Me.imageList.Images.SetKeyName(1, "2.jpg")
        Me.imageList.Images.SetKeyName(2, "3.jpg")
        Me.imageList.Images.SetKeyName(3, "4.jpg")
        '
        'lblDownloadFile
        '
        Me.lblDownloadFile.AutoSize = True
        Me.lblDownloadFile.Location = New System.Drawing.Point(143, 181)
        Me.lblDownloadFile.Name = "lblDownloadFile"
        Me.lblDownloadFile.Size = New System.Drawing.Size(65, 12)
        Me.lblDownloadFile.TabIndex = 3
        Me.lblDownloadFile.Text = "当前进度："
        '
        'lblSinglePercent
        '
        Me.lblSinglePercent.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblSinglePercent.AutoSize = True
        Me.lblSinglePercent.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblSinglePercent.ForeColor = System.Drawing.Color.Maroon
        Me.lblSinglePercent.Location = New System.Drawing.Point(491, 181)
        Me.lblSinglePercent.Name = "lblSinglePercent"
        Me.lblSinglePercent.Size = New System.Drawing.Size(17, 12)
        Me.lblSinglePercent.TabIndex = 5
        Me.lblSinglePercent.Text = "0%"
        Me.lblSinglePercent.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblAllTip
        '
        Me.lblAllTip.AutoSize = True
        Me.lblAllTip.Location = New System.Drawing.Point(143, 227)
        Me.lblAllTip.Name = "lblAllTip"
        Me.lblAllTip.Size = New System.Drawing.Size(53, 12)
        Me.lblAllTip.TabIndex = 6
        Me.lblAllTip.Text = "总进度："
        '
        'lblAllPercent
        '
        Me.lblAllPercent.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblAllPercent.AutoSize = True
        Me.lblAllPercent.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblAllPercent.ForeColor = System.Drawing.Color.Green
        Me.lblAllPercent.Location = New System.Drawing.Point(491, 227)
        Me.lblAllPercent.Name = "lblAllPercent"
        Me.lblAllPercent.Size = New System.Drawing.Size(17, 12)
        Me.lblAllPercent.TabIndex = 8
        Me.lblAllPercent.Text = "0%"
        Me.lblAllPercent.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'prbSingle
        '
        Me.prbSingle.Location = New System.Drawing.Point(143, 196)
        Me.prbSingle.Name = "prbSingle"
        Me.prbSingle.Size = New System.Drawing.Size(380, 14)
        Me.prbSingle.TabIndex = 9
        '
        'prbAll
        '
        Me.prbAll.Location = New System.Drawing.Point(143, 242)
        Me.prbAll.Name = "prbAll"
        Me.prbAll.Size = New System.Drawing.Size(380, 14)
        Me.prbAll.TabIndex = 10
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(432, 275)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(90, 27)
        Me.btnQuit.TabIndex = 14
        Me.btnQuit.Text = "完成"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'lblTip
        '
        Me.lblTip.AutoSize = True
        Me.lblTip.ForeColor = System.Drawing.Color.Maroon
        Me.lblTip.Location = New System.Drawing.Point(143, 10)
        Me.lblTip.Name = "lblTip"
        Me.lblTip.Size = New System.Drawing.Size(125, 12)
        Me.lblTip.TabIndex = 15
        Me.lblTip.Text = "需要下载的文件列表："
        '
        'picBack
        '
        Me.picBack.BackgroundImage = CType(resources.GetObject("picBack.BackgroundImage"), System.Drawing.Image)
        Me.picBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.picBack.Location = New System.Drawing.Point(7, 10)
        Me.picBack.Name = "picBack"
        Me.picBack.Size = New System.Drawing.Size(130, 248)
        Me.picBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picBack.TabIndex = 11
        Me.picBack.TabStop = False
        '
        'UpdatingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(529, 314)
        Me.Controls.Add(Me.lblTip)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.picBack)
        Me.Controls.Add(Me.prbAll)
        Me.Controls.Add(Me.prbSingle)
        Me.Controls.Add(Me.lblAllPercent)
        Me.Controls.Add(Me.lblAllTip)
        Me.Controls.Add(Me.lblSinglePercent)
        Me.Controls.Add(Me.lblDownloadFile)
        Me.Controls.Add(Me.lvwFile)
        Me.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "UpdatingForm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "更新"
        CType(Me.picBack, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lvwFile As System.Windows.Forms.ListView
    Friend WithEvents colStatus As System.Windows.Forms.ColumnHeader
    Friend WithEvents colName As System.Windows.Forms.ColumnHeader
    Friend WithEvents imageList As System.Windows.Forms.ImageList
    Friend WithEvents lblDownloadFile As System.Windows.Forms.Label
    Friend WithEvents lblSinglePercent As System.Windows.Forms.Label
    Friend WithEvents lblAllTip As System.Windows.Forms.Label
    Friend WithEvents lblAllPercent As System.Windows.Forms.Label
    Friend WithEvents prbSingle As System.Windows.Forms.ProgressBar
    Friend WithEvents prbAll As System.Windows.Forms.ProgressBar
    Friend WithEvents btnQuit As System.Windows.Forms.Button
    Friend WithEvents lblTip As System.Windows.Forms.Label
    Friend WithEvents picBack As System.Windows.Forms.PictureBox
    Friend WithEvents colVersion As System.Windows.Forms.ColumnHeader
    Friend WithEvents clsProgress As System.Windows.Forms.ColumnHeader

End Class
