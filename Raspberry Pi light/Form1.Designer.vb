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
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnOn = New System.Windows.Forms.Button()
        Me.btnFlash = New System.Windows.Forms.Button()
        Me.btnOff = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnTrial = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.Info
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(120, 140)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(57, 36)
        Me.btnExit.TabIndex = 0
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnOn
        '
        Me.btnOn.BackColor = System.Drawing.SystemColors.Info
        Me.btnOn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOn.Location = New System.Drawing.Point(45, 86)
        Me.btnOn.Name = "btnOn"
        Me.btnOn.Size = New System.Drawing.Size(57, 36)
        Me.btnOn.TabIndex = 1
        Me.btnOn.Text = "On"
        Me.btnOn.UseVisualStyleBackColor = False
        '
        'btnFlash
        '
        Me.btnFlash.BackColor = System.Drawing.SystemColors.Info
        Me.btnFlash.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFlash.Location = New System.Drawing.Point(45, 140)
        Me.btnFlash.Name = "btnFlash"
        Me.btnFlash.Size = New System.Drawing.Size(57, 36)
        Me.btnFlash.TabIndex = 2
        Me.btnFlash.Text = "Flash"
        Me.btnFlash.UseVisualStyleBackColor = False
        '
        'btnOff
        '
        Me.btnOff.BackColor = System.Drawing.SystemColors.Info
        Me.btnOff.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOff.Location = New System.Drawing.Point(120, 86)
        Me.btnOff.Name = "btnOff"
        Me.btnOff.Size = New System.Drawing.Size(57, 36)
        Me.btnOff.TabIndex = 3
        Me.btnOff.Text = "Off"
        Me.btnOff.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Montserrat Subrayada", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(175, 38)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Choose the state " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "of the LED..."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.SystemColors.Info
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(45, 194)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(132, 36)
        Me.btnUpdate.TabIndex = 5
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnTrial
        '
        Me.btnTrial.BackColor = System.Drawing.SystemColors.Info
        Me.btnTrial.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnTrial.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTrial.Location = New System.Drawing.Point(45, 245)
        Me.btnTrial.Name = "btnTrial"
        Me.btnTrial.Size = New System.Drawing.Size(132, 36)
        Me.btnTrial.TabIndex = 6
        Me.btnTrial.Text = "Trial"
        Me.btnTrial.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(230, 312)
        Me.Controls.Add(Me.btnTrial)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnOff)
        Me.Controls.Add(Me.btnFlash)
        Me.Controls.Add(Me.btnOn)
        Me.Controls.Add(Me.btnExit)
        Me.Name = "Form1"
        Me.Text = "LED Control"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents btnOn As Button
    Friend WithEvents btnFlash As Button
    Friend WithEvents btnOff As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnTrial As Button
End Class
