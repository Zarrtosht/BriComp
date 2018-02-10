<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SteelGeom_form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.tbName = New System.Windows.Forms.TextBox()
        Me.btnAddSteelGeom = New System.Windows.Forms.Button()
        Me.btnCancelSteelGeom = New System.Windows.Forms.Button()
        Me.grpPrevSteelGeom = New System.Windows.Forms.GroupBox()
        Me.grpSteelConst = New System.Windows.Forms.GroupBox()
        Me.tbConst = New System.Windows.Forms.TextBox()
        Me.tbTfo = New System.Windows.Forms.TextBox()
        Me.tbBfo = New System.Windows.Forms.TextBox()
        Me.tbTw = New System.Windows.Forms.TextBox()
        Me.tbBfu = New System.Windows.Forms.TextBox()
        Me.tbTfu = New System.Windows.Forms.TextBox()
        Me.tbHw = New System.Windows.Forms.TextBox()
        Me.lbSteelGeomName = New System.Windows.Forms.Label()
        Me.lbltfo = New System.Windows.Forms.Label()
        Me.lblbfo = New System.Windows.Forms.Label()
        Me.lbltw = New System.Windows.Forms.Label()
        Me.lblhw = New System.Windows.Forms.Label()
        Me.lbltfu = New System.Windows.Forms.Label()
        Me.lblbfu = New System.Windows.Forms.Label()
        Me.grpSteelDim = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbZ = New System.Windows.Forms.TextBox()
        Me.btnCalcSteelGeom = New System.Windows.Forms.Button()
        Me.grpSteelConst.SuspendLayout()
        Me.grpSteelDim.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbName
        '
        Me.tbName.Location = New System.Drawing.Point(67, 12)
        Me.tbName.Name = "tbName"
        Me.tbName.Size = New System.Drawing.Size(164, 22)
        Me.tbName.TabIndex = 1
        Me.tbName.Text = "SteelGeom-1"
        '
        'btnAddSteelGeom
        '
        Me.btnAddSteelGeom.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddSteelGeom.Location = New System.Drawing.Point(451, 566)
        Me.btnAddSteelGeom.Name = "btnAddSteelGeom"
        Me.btnAddSteelGeom.Size = New System.Drawing.Size(75, 31)
        Me.btnAddSteelGeom.TabIndex = 2
        Me.btnAddSteelGeom.Text = "Add"
        Me.btnAddSteelGeom.UseVisualStyleBackColor = True
        '
        'btnCancelSteelGeom
        '
        Me.btnCancelSteelGeom.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelSteelGeom.Location = New System.Drawing.Point(613, 566)
        Me.btnCancelSteelGeom.Name = "btnCancelSteelGeom"
        Me.btnCancelSteelGeom.Size = New System.Drawing.Size(75, 31)
        Me.btnCancelSteelGeom.TabIndex = 3
        Me.btnCancelSteelGeom.Text = "Cancel"
        Me.btnCancelSteelGeom.UseVisualStyleBackColor = True
        '
        'grpPrevSteelGeom
        '
        Me.grpPrevSteelGeom.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpPrevSteelGeom.BackColor = System.Drawing.Color.Transparent
        Me.grpPrevSteelGeom.Location = New System.Drawing.Point(237, 9)
        Me.grpPrevSteelGeom.Name = "grpPrevSteelGeom"
        Me.grpPrevSteelGeom.Size = New System.Drawing.Size(451, 551)
        Me.grpPrevSteelGeom.TabIndex = 4
        Me.grpPrevSteelGeom.TabStop = False
        Me.grpPrevSteelGeom.Text = "Preview"
        '
        'grpSteelConst
        '
        Me.grpSteelConst.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grpSteelConst.Controls.Add(Me.tbConst)
        Me.grpSteelConst.Location = New System.Drawing.Point(15, 272)
        Me.grpSteelConst.Name = "grpSteelConst"
        Me.grpSteelConst.Size = New System.Drawing.Size(215, 287)
        Me.grpSteelConst.TabIndex = 5
        Me.grpSteelConst.TabStop = False
        Me.grpSteelConst.Text = "Constants"
        '
        'tbConst
        '
        Me.tbConst.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbConst.BackColor = System.Drawing.SystemColors.Control
        Me.tbConst.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbConst.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbConst.Location = New System.Drawing.Point(9, 21)
        Me.tbConst.Multiline = True
        Me.tbConst.Name = "tbConst"
        Me.tbConst.Size = New System.Drawing.Size(200, 260)
        Me.tbConst.TabIndex = 0
        '
        'tbTfo
        '
        Me.tbTfo.Location = New System.Drawing.Point(44, 29)
        Me.tbTfo.Name = "tbTfo"
        Me.tbTfo.Size = New System.Drawing.Size(165, 22)
        Me.tbTfo.TabIndex = 6
        '
        'tbBfo
        '
        Me.tbBfo.Location = New System.Drawing.Point(44, 57)
        Me.tbBfo.Name = "tbBfo"
        Me.tbBfo.Size = New System.Drawing.Size(165, 22)
        Me.tbBfo.TabIndex = 7
        '
        'tbTw
        '
        Me.tbTw.Location = New System.Drawing.Point(44, 85)
        Me.tbTw.Name = "tbTw"
        Me.tbTw.Size = New System.Drawing.Size(165, 22)
        Me.tbTw.TabIndex = 8
        '
        'tbBfu
        '
        Me.tbBfu.Location = New System.Drawing.Point(44, 169)
        Me.tbBfu.Name = "tbBfu"
        Me.tbBfu.Size = New System.Drawing.Size(165, 22)
        Me.tbBfu.TabIndex = 11
        '
        'tbTfu
        '
        Me.tbTfu.Location = New System.Drawing.Point(44, 141)
        Me.tbTfu.Name = "tbTfu"
        Me.tbTfu.Size = New System.Drawing.Size(165, 22)
        Me.tbTfu.TabIndex = 10
        '
        'tbHw
        '
        Me.tbHw.Location = New System.Drawing.Point(44, 113)
        Me.tbHw.Name = "tbHw"
        Me.tbHw.Size = New System.Drawing.Size(165, 22)
        Me.tbHw.TabIndex = 9
        '
        'lbSteelGeomName
        '
        Me.lbSteelGeomName.AutoSize = True
        Me.lbSteelGeomName.Location = New System.Drawing.Point(12, 12)
        Me.lbSteelGeomName.Name = "lbSteelGeomName"
        Me.lbSteelGeomName.Size = New System.Drawing.Size(49, 17)
        Me.lbSteelGeomName.TabIndex = 0
        Me.lbSteelGeomName.Text = "Name:"
        '
        'lbltfo
        '
        Me.lbltfo.AutoSize = True
        Me.lbltfo.Location = New System.Drawing.Point(6, 29)
        Me.lbltfo.Name = "lbltfo"
        Me.lbltfo.Size = New System.Drawing.Size(28, 17)
        Me.lbltfo.TabIndex = 12
        Me.lbltfo.Text = "tfo:"
        '
        'lblbfo
        '
        Me.lblbfo.AutoSize = True
        Me.lblbfo.Location = New System.Drawing.Point(6, 57)
        Me.lblbfo.Name = "lblbfo"
        Me.lblbfo.Size = New System.Drawing.Size(32, 17)
        Me.lblbfo.TabIndex = 13
        Me.lblbfo.Text = "bfo:"
        '
        'lbltw
        '
        Me.lbltw.AutoSize = True
        Me.lbltw.Location = New System.Drawing.Point(6, 85)
        Me.lbltw.Name = "lbltw"
        Me.lbltw.Size = New System.Drawing.Size(25, 17)
        Me.lbltw.TabIndex = 14
        Me.lbltw.Text = "tw:"
        '
        'lblhw
        '
        Me.lblhw.AutoSize = True
        Me.lblhw.Location = New System.Drawing.Point(6, 113)
        Me.lblhw.Name = "lblhw"
        Me.lblhw.Size = New System.Drawing.Size(29, 17)
        Me.lblhw.TabIndex = 15
        Me.lblhw.Text = "hw:"
        '
        'lbltfu
        '
        Me.lbltfu.AutoSize = True
        Me.lbltfu.Location = New System.Drawing.Point(6, 141)
        Me.lbltfu.Name = "lbltfu"
        Me.lbltfu.Size = New System.Drawing.Size(28, 17)
        Me.lbltfu.TabIndex = 14
        Me.lbltfu.Text = "tfu:"
        '
        'lblbfu
        '
        Me.lblbfu.AutoSize = True
        Me.lblbfu.Location = New System.Drawing.Point(6, 169)
        Me.lblbfu.Name = "lblbfu"
        Me.lblbfu.Size = New System.Drawing.Size(32, 17)
        Me.lblbfu.TabIndex = 15
        Me.lblbfu.Text = "bfu:"
        '
        'grpSteelDim
        '
        Me.grpSteelDim.Controls.Add(Me.Label1)
        Me.grpSteelDim.Controls.Add(Me.tbZ)
        Me.grpSteelDim.Controls.Add(Me.lblbfu)
        Me.grpSteelDim.Controls.Add(Me.tbBfu)
        Me.grpSteelDim.Controls.Add(Me.tbTfu)
        Me.grpSteelDim.Controls.Add(Me.lbltfu)
        Me.grpSteelDim.Controls.Add(Me.lbltfo)
        Me.grpSteelDim.Controls.Add(Me.tbTfo)
        Me.grpSteelDim.Controls.Add(Me.tbHw)
        Me.grpSteelDim.Controls.Add(Me.lblhw)
        Me.grpSteelDim.Controls.Add(Me.lblbfo)
        Me.grpSteelDim.Controls.Add(Me.tbBfo)
        Me.grpSteelDim.Controls.Add(Me.tbTw)
        Me.grpSteelDim.Controls.Add(Me.lbltw)
        Me.grpSteelDim.Location = New System.Drawing.Point(15, 40)
        Me.grpSteelDim.Name = "grpSteelDim"
        Me.grpSteelDim.Size = New System.Drawing.Size(215, 226)
        Me.grpSteelDim.TabIndex = 6
        Me.grpSteelDim.TabStop = False
        Me.grpSteelDim.Text = "Dimensions [mm]"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 197)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(19, 17)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "z:"
        '
        'tbZ
        '
        Me.tbZ.Location = New System.Drawing.Point(44, 197)
        Me.tbZ.Name = "tbZ"
        Me.tbZ.Size = New System.Drawing.Size(165, 22)
        Me.tbZ.TabIndex = 12
        Me.tbZ.Text = "optional"
        '
        'btnCalcSteelGeom
        '
        Me.btnCalcSteelGeom.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCalcSteelGeom.Location = New System.Drawing.Point(532, 566)
        Me.btnCalcSteelGeom.Name = "btnCalcSteelGeom"
        Me.btnCalcSteelGeom.Size = New System.Drawing.Size(75, 31)
        Me.btnCalcSteelGeom.TabIndex = 2
        Me.btnCalcSteelGeom.Text = "Preview"
        Me.btnCalcSteelGeom.UseVisualStyleBackColor = True
        '
        'SteelGeom_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 601)
        Me.Controls.Add(Me.btnAddSteelGeom)
        Me.Controls.Add(Me.btnCancelSteelGeom)
        Me.Controls.Add(Me.btnCalcSteelGeom)
        Me.Controls.Add(Me.grpSteelDim)
        Me.Controls.Add(Me.grpSteelConst)
        Me.Controls.Add(Me.tbName)
        Me.Controls.Add(Me.lbSteelGeomName)
        Me.Controls.Add(Me.grpPrevSteelGeom)
        Me.Name = "SteelGeom_form"
        Me.Text = "Add steel geometry"
        Me.grpSteelConst.ResumeLayout(False)
        Me.grpSteelConst.PerformLayout()
        Me.grpSteelDim.ResumeLayout(False)
        Me.grpSteelDim.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbName As TextBox
    Friend WithEvents btnAddSteelGeom As Button
    Friend WithEvents btnCancelSteelGeom As Button
    Friend WithEvents grpPrevSteelGeom As GroupBox
    Friend WithEvents grpSteelConst As GroupBox
    Friend WithEvents tbTfo As TextBox
    Friend WithEvents tbBfo As TextBox
    Friend WithEvents tbTw As TextBox
    Friend WithEvents tbBfu As TextBox
    Friend WithEvents tbTfu As TextBox
    Friend WithEvents tbHw As TextBox
    Friend WithEvents lbSteelGeomName As Label
    Friend WithEvents lbltfo As Label
    Friend WithEvents lblbfo As Label
    Friend WithEvents lbltw As Label
    Friend WithEvents lblhw As Label
    Friend WithEvents lbltfu As Label
    Friend WithEvents lblbfu As Label
    Friend WithEvents grpSteelDim As GroupBox
    Friend WithEvents tbConst As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tbZ As TextBox
    Friend WithEvents btnCalcSteelGeom As Button
End Class
