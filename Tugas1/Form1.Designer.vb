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
        Me.UbahButton = New System.Windows.Forms.Button()
        Me.JUDUL = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'UbahButton
        '
        Me.UbahButton.Location = New System.Drawing.Point(187, 212)
        Me.UbahButton.Name = "UbahButton"
        Me.UbahButton.Size = New System.Drawing.Size(75, 23)
        Me.UbahButton.TabIndex = 0
        Me.UbahButton.Text = "Ubah"
        Me.UbahButton.UseVisualStyleBackColor = True
        '
        'JUDUL
        '
        Me.JUDUL.AutoSize = True
        Me.JUDUL.Font = New System.Drawing.Font("Gloucester MT Extra Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JUDUL.Location = New System.Drawing.Point(31, 29)
        Me.JUDUL.Name = "JUDUL"
        Me.JUDUL.Size = New System.Drawing.Size(231, 25)
        Me.JUDUL.TabIndex = 1
        Me.JUDUL.Text = "MENGUBAH WARNA BACKGROUND"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Violet
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.JUDUL)
        Me.Controls.Add(Me.UbahButton)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UbahButton As System.Windows.Forms.Button
    Friend WithEvents JUDUL As System.Windows.Forms.Label

End Class
