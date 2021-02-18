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
        Me.radTile = New System.Windows.Forms.Button()
        Me.radCarpet = New System.Windows.Forms.Button()
        Me.radHardwood = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'grpFloorType
        '
        Me.grpFloorType.BackColor = System.Drawing.Color.White
        Me.grpFloorType.Font = New System.Drawing.Font("Goudy Old Style", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpFloorType.Location = New System.Drawing.Point(0, 0)
        Me.grpFloorType.Name = "grpFloorType"
        Me.grpFloorType.Size = New System.Drawing.Size(175, 105)
        Me.grpFloorType.TabIndex = 0
        Me.grpFloorType.TabStop = False
        Me.grpFloorType.Text = "Flooring Type"
        '
        'radTile
        '
        Me.radTile.BackColor = System.Drawing.Color.White
        Me.radTile.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radTile.Location = New System.Drawing.Point(125, 115)
        Me.radTile.Name = "radTile"
        Me.radTile.Size = New System.Drawing.Size(75, 23)
        Me.radTile.TabIndex = 0
        Me.radTile.Text = "Tile"
        Me.radTile.UseVisualStyleBackColor = False
        '
        'radCarpet
        '
        Me.radCarpet.Location = New System.Drawing.Point(70, 165)
        Me.radCarpet.Name = "radCarpet"
        Me.radCarpet.Size = New System.Drawing.Size(75, 23)
        Me.radCarpet.TabIndex = 1
        Me.radCarpet.Text = "Carpet"
        Me.radCarpet.UseVisualStyleBackColor = True
        '
        'radHardwood
        '
        Me.radHardwood.Location = New System.Drawing.Point(183, 165)
        Me.radHardwood.Name = "radHardwood"
        Me.radHardwood.Size = New System.Drawing.Size(75, 23)
        Me.radHardwood.TabIndex = 2
        Me.radHardwood.Text = "Hardwood"
        Me.radHardwood.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(282, 253)
        Me.Controls.Add(Me.radTile)
        Me.Controls.Add(Me.radCarpet)
        Me.Controls.Add(Me.radHardwood)
        Me.Controls.Add(Me.grpFloorType)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpFloorType As GroupBox
    Friend WithEvents radTile As Button
    Friend WithEvents radCarpet As Button
    Friend WithEvents radHardwood As Button
End Class
