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
        Me.grpFloorType = New System.Windows.Forms.GroupBox()
        Me.radTile = New System.Windows.Forms.RadioButton()
        Me.radCarpet = New System.Windows.Forms.RadioButton()
        Me.radHardwood = New System.Windows.Forms.RadioButton()
        Me.grpFloorType.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpFloorType
        '
        Me.grpFloorType.BackColor = System.Drawing.Color.White
        Me.grpFloorType.Controls.Add(Me.radHardwood)
        Me.grpFloorType.Controls.Add(Me.radCarpet)
        Me.grpFloorType.Controls.Add(Me.radTile)
        Me.grpFloorType.Font = New System.Drawing.Font("Goudy Old Style", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpFloorType.Location = New System.Drawing.Point(0, 0)
        Me.grpFloorType.Name = "grpFloorType"
        Me.grpFloorType.Size = New System.Drawing.Size(233, 227)
        Me.grpFloorType.TabIndex = 0
        Me.grpFloorType.TabStop = False
        Me.grpFloorType.Text = "Flooring Type"
        '
        'radTile
        '
        Me.radTile.AutoSize = True
        Me.radTile.Checked = True
        Me.radTile.Location = New System.Drawing.Point(3, 31)
        Me.radTile.Name = "radTile"
        Me.radTile.Size = New System.Drawing.Size(70, 31)
        Me.radTile.TabIndex = 0
        Me.radTile.TabStop = True
        Me.radTile.Text = "Tile"
        Me.radTile.UseVisualStyleBackColor = True
        '
        'radCarpet
        '
        Me.radCarpet.AutoSize = True
        Me.radCarpet.Location = New System.Drawing.Point(6, 86)
        Me.radCarpet.Name = "radCarpet"
        Me.radCarpet.Size = New System.Drawing.Size(97, 31)
        Me.radCarpet.TabIndex = 1
        Me.radCarpet.Text = "Carpet"
        Me.radCarpet.UseVisualStyleBackColor = True
        '
        'radHardwood
        '
        Me.radHardwood.AutoSize = True
        Me.radHardwood.Location = New System.Drawing.Point(12, 135)
        Me.radHardwood.Name = "radHardwood"
        Me.radHardwood.Size = New System.Drawing.Size(134, 31)
        Me.radHardwood.TabIndex = 2
        Me.radHardwood.Text = "Hardwood"
        Me.radHardwood.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(282, 253)
        Me.Controls.Add(Me.grpFloorType)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.grpFloorType.ResumeLayout(False)
        Me.grpFloorType.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpFloorType As GroupBox
    Friend WithEvents radHardwood As RadioButton
    Friend WithEvents radCarpet As RadioButton
    Friend WithEvents radTile As RadioButton
End Class
