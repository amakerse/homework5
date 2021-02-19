'Suzanne Amaker
' 02/18/2021
'Homework 5


<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmFlooring
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
        Me.grpFloorType = New System.Windows.Forms.GroupBox()
        Me.radHardwood = New System.Windows.Forms.RadioButton()
        Me.radCarpet = New System.Windows.Forms.RadioButton()
        Me.radTile = New System.Windows.Forms.RadioButton()
        Me.lblHeading = New System.Windows.Forms.TextBox()
        Me.txtFootage = New System.Windows.Forms.TextBox()
        Me.lblSquareFeet = New System.Windows.Forms.Label()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.lblCostEstimate = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
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
        Me.grpFloorType.Location = New System.Drawing.Point(179, 129)
        Me.grpFloorType.Name = "grpFloorType"
        Me.grpFloorType.Size = New System.Drawing.Size(203, 174)
        Me.grpFloorType.TabIndex = 0
        Me.grpFloorType.TabStop = False
        Me.grpFloorType.Text = "Flooring Type"
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
        'lblHeading
        '
        Me.lblHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(102, 12)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(342, 38)
        Me.lblHeading.TabIndex = 3
        Me.lblHeading.Text = "Flooring Cost Calculator"
        '
        'txtFootage
        '
        Me.txtFootage.Location = New System.Drawing.Point(293, 82)
        Me.txtFootage.Name = "txtFootage"
        Me.txtFootage.Size = New System.Drawing.Size(79, 22)
        Me.txtFootage.TabIndex = 5
        Me.txtFootage.Text = "5"
        '
        'lblSquareFeet
        '
        Me.lblSquareFeet.AutoSize = True
        Me.lblSquareFeet.Location = New System.Drawing.Point(112, 82)
        Me.lblSquareFeet.Name = "lblSquareFeet"
        Me.lblSquareFeet.Size = New System.Drawing.Size(114, 17)
        Me.lblSquareFeet.TabIndex = 6
        Me.lblSquareFeet.Text = "Square Footage:"
        '
        'lblCost
        '
        Me.lblCost.AutoSize = True
        Me.lblCost.Location = New System.Drawing.Point(115, 317)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(94, 17)
        Me.lblCost.TabIndex = 7
        Me.lblCost.Text = "Cost Estimate"
        '
        'lblCostEstimate
        '
        Me.lblCostEstimate.AutoSize = True
        Me.lblCostEstimate.Location = New System.Drawing.Point(293, 316)
        Me.lblCostEstimate.Name = "lblCostEstimate"
        Me.lblCostEstimate.Size = New System.Drawing.Size(68, 17)
        Me.lblCostEstimate.TabIndex = 8
        Me.lblCostEstimate.Text = "$0000.00"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(12, 129)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(116, 30)
        Me.btnCalculate.TabIndex = 9
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(12, 202)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(116, 30)
        Me.btnClear.TabIndex = 10
        Me.btnClear.Text = "CLEAR"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'frmFlooring
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(553, 340)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblCostEstimate)
        Me.Controls.Add(Me.lblCost)
        Me.Controls.Add(Me.lblSquareFeet)
        Me.Controls.Add(Me.txtFootage)
        Me.Controls.Add(Me.lblHeading)
        Me.Controls.Add(Me.grpFloorType)
        Me.Name = "frmFlooring"
        Me.Text = "Flooring Cost"
        Me.grpFloorType.ResumeLayout(False)
        Me.grpFloorType.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpFloorType As GroupBox
    Friend WithEvents radHardwood As RadioButton
    Friend WithEvents radCarpet As RadioButton
    Friend WithEvents radTile As RadioButton
    Friend WithEvents lblHeading As TextBox
    Friend WithEvents txtFootage As TextBox
    Friend WithEvents lblSquareFeet As Label
    Friend WithEvents lblCost As Label
    Friend WithEvents lblCostEstimate As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub grpFloorType_Enter(sender As Object, e As EventArgs) Handles grpFloorType.Enter

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim decFootage As Decimal
        Dim decCostPerSquareFoot As Decimal
        Dim decCostEstimate As Decimal
        Dim decTileCost As Decimal = 4.49D
        Dim decCarpetCost As Decimal = 4.99D
        Dim decHardwoodCost As Decimal = 7.49D

        If IsNumeric(txtFootage.Text) Then
            decFootage = Convert.ToDecimal(txtFootage.Text)
        End If
        If decFootage > 0 Then
            If radTile.Checked Then
                decCostPerSquareFoot = decTileCost
            ElseIf radCarpet.Checked Then
                decCostPerSquareFoot = decCarpetCost
            ElseIf radHardwood.Checked Then
                decCostPerSquareFoot = decHardwoodCost
            End If
        End If
        decCostEstimate = decFootage * decCostPerSquareFoot
        lblCostEstimate.Text = decCostEstimate.ToString("C")


        MsgBox("You entered" & decFootage.ToString() & ". Enter a Positive Number",  , "Imput Error")
        txtFootage.Text = ""
        txtFootage.Focus()


        MsgBox("You entered" & decFootage.ToString() & ". Enter a Numeric Number",  , "Imput Error")
        txtFootage.Text = ""
        txtFootage.Focus()



    End Sub

    Private Sub lblCostEstimate_Click(sender As Object, e As EventArgs) Handles lblCostEstimate.Click

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtFootage.Clear()
        lblCostEstimate.Text = ""
        radTile.Checked = True
        radCarpet.Checked = False
        radHardwood.Checked = False
        txtFootage.Focus()
        lblCostEstimate.Text = ""

    End Sub

    Private Sub lblSquareFeet_Click(sender As Object, e As EventArgs) Handles lblSquareFeet.Click

    End Sub

    Private Sub lblHeading_TextChanged(sender As Object, e As EventArgs) Handles lblHeading.TextChanged

    End Sub

    Private Sub txtFootage_TextChanged(sender As Object, e As EventArgs) Handles txtFootage.TextChanged

    End Sub
End Class
