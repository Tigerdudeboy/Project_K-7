<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFileSelect
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
        Me.lblUpdates = New System.Windows.Forms.Label()
        Me.tmrScroll = New System.Windows.Forms.Timer(Me.components)
        Me.lblContinue = New System.Windows.Forms.Label()
        Me.lblLoad = New System.Windows.Forms.Label()
        Me.lblNew = New System.Windows.Forms.Label()
        Me.lblDev = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.lneUpdatesDivider = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.lneGameDivider = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.lneTitleDivider = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblQuit = New System.Windows.Forms.Label()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblUpdates
        '
        Me.lblUpdates.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblUpdates.AutoSize = True
        Me.lblUpdates.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUpdates.Location = New System.Drawing.Point(292, 400)
        Me.lblUpdates.Name = "lblUpdates"
        Me.lblUpdates.Size = New System.Drawing.Size(183, 29)
        Me.lblUpdates.TabIndex = 0
        Me.lblUpdates.Text = "Updates | Test"
        '
        'tmrScroll
        '
        Me.tmrScroll.Enabled = True
        Me.tmrScroll.Interval = 50
        '
        'lblContinue
        '
        Me.lblContinue.AutoSize = True
        Me.lblContinue.BackColor = System.Drawing.Color.Transparent
        Me.lblContinue.Enabled = False
        Me.lblContinue.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContinue.Location = New System.Drawing.Point(12, 106)
        Me.lblContinue.Name = "lblContinue"
        Me.lblContinue.Size = New System.Drawing.Size(265, 29)
        Me.lblContinue.TabIndex = 1
        Me.lblContinue.Text = "Continue Game (WIP)"
        '
        'lblLoad
        '
        Me.lblLoad.AutoSize = True
        Me.lblLoad.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoad.Location = New System.Drawing.Point(12, 135)
        Me.lblLoad.Name = "lblLoad"
        Me.lblLoad.Size = New System.Drawing.Size(219, 29)
        Me.lblLoad.TabIndex = 2
        Me.lblLoad.Text = "Load Game (WIP)"
        '
        'lblNew
        '
        Me.lblNew.AutoSize = True
        Me.lblNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNew.Location = New System.Drawing.Point(12, 164)
        Me.lblNew.Name = "lblNew"
        Me.lblNew.Size = New System.Drawing.Size(214, 29)
        Me.lblNew.TabIndex = 3
        Me.lblNew.Text = "New Game (WIP)"
        '
        'lblDev
        '
        Me.lblDev.AutoSize = True
        Me.lblDev.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDev.Location = New System.Drawing.Point(12, 193)
        Me.lblDev.Name = "lblDev"
        Me.lblDev.Size = New System.Drawing.Size(206, 29)
        Me.lblDev.TabIndex = 4
        Me.lblDev.Text = "Dev Game (WIP)"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.lneUpdatesDivider, Me.lneGameDivider, Me.lneTitleDivider})
        Me.ShapeContainer1.Size = New System.Drawing.Size(573, 439)
        Me.ShapeContainer1.TabIndex = 5
        Me.ShapeContainer1.TabStop = False
        '
        'lneUpdatesDivider
        '
        Me.lneUpdatesDivider.Name = "lneUpdatesDivider"
        Me.lneUpdatesDivider.X1 = 291
        Me.lneUpdatesDivider.X2 = 567
        Me.lneUpdatesDivider.Y1 = 391
        Me.lneUpdatesDivider.Y2 = 391
        '
        'lneGameDivider
        '
        Me.lneGameDivider.Name = "lneGameDivider"
        Me.lneGameDivider.X1 = 286
        Me.lneGameDivider.X2 = 286
        Me.lneGameDivider.Y1 = 97
        Me.lneGameDivider.Y2 = 433
        '
        'lneTitleDivider
        '
        Me.lneTitleDivider.Name = "lneTitleDivider"
        Me.lneTitleDivider.X1 = 5
        Me.lneTitleDivider.X2 = 567
        Me.lneTitleDivider.Y1 = 92
        Me.lneTitleDivider.Y2 = 92
        '
        'lblTitle
        '
        Me.lblTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.Gray
        Me.lblTitle.Location = New System.Drawing.Point(0, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(573, 66)
        Me.lblTitle.TabIndex = 6
        Me.lblTitle.Text = "Project K-7" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "0.0.0.1"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblQuit
        '
        Me.lblQuit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblQuit.AutoSize = True
        Me.lblQuit.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuit.Location = New System.Drawing.Point(12, 391)
        Me.lblQuit.Name = "lblQuit"
        Me.lblQuit.Size = New System.Drawing.Size(137, 29)
        Me.lblQuit.TabIndex = 7
        Me.lblQuit.Text = "Quit Game"
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescription.Location = New System.Drawing.Point(291, 97)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(101, 31)
        Me.lblDescription.TabIndex = 8
        Me.lblDescription.Text = "Label1"
        '
        'frmFileSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(573, 439)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.lblQuit)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblDev)
        Me.Controls.Add(Me.lblContinue)
        Me.Controls.Add(Me.lblLoad)
        Me.Controls.Add(Me.lblNew)
        Me.Controls.Add(Me.lblUpdates)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.MinimumSize = New System.Drawing.Size(589, 477)
        Me.Name = "frmFileSelect"
        Me.Text = "Project K-7"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblUpdates As System.Windows.Forms.Label
    Friend WithEvents tmrScroll As System.Windows.Forms.Timer
    Friend WithEvents lblContinue As System.Windows.Forms.Label
    Friend WithEvents lblLoad As System.Windows.Forms.Label
    Friend WithEvents lblNew As System.Windows.Forms.Label
    Friend WithEvents lblDev As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents lneTitleDivider As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lneGameDivider As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents lneUpdatesDivider As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents lblQuit As System.Windows.Forms.Label
    Friend WithEvents lblDescription As System.Windows.Forms.Label

End Class
