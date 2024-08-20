<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.txtHex = New System.Windows.Forms.TextBox()
        Me.txtDec = New System.Windows.Forms.TextBox()
        Me.txtOct = New System.Windows.Forms.TextBox()
        Me.txtBin = New System.Windows.Forms.TextBox()
        Me.lblBin = New System.Windows.Forms.Label()
        Me.lblOct = New System.Windows.Forms.Label()
        Me.lblDec = New System.Windows.Forms.Label()
        Me.lblHex = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtHex
        '
        Me.txtHex.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.txtHex.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!)
        Me.txtHex.ForeColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.txtHex.Location = New System.Drawing.Point(152, 227)
        Me.txtHex.Name = "txtHex"
        Me.txtHex.Size = New System.Drawing.Size(592, 49)
        Me.txtHex.TabIndex = 0
        '
        'txtDec
        '
        Me.txtDec.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.txtDec.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!)
        Me.txtDec.ForeColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.txtDec.Location = New System.Drawing.Point(152, 172)
        Me.txtDec.Name = "txtDec"
        Me.txtDec.Size = New System.Drawing.Size(592, 49)
        Me.txtDec.TabIndex = 1
        '
        'txtOct
        '
        Me.txtOct.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.txtOct.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!)
        Me.txtOct.ForeColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.txtOct.Location = New System.Drawing.Point(152, 117)
        Me.txtOct.Name = "txtOct"
        Me.txtOct.Size = New System.Drawing.Size(592, 49)
        Me.txtOct.TabIndex = 2
        '
        'txtBin
        '
        Me.txtBin.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.txtBin.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!)
        Me.txtBin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.txtBin.Location = New System.Drawing.Point(152, 62)
        Me.txtBin.Name = "txtBin"
        Me.txtBin.Size = New System.Drawing.Size(592, 49)
        Me.txtBin.TabIndex = 3
        '
        'lblBin
        '
        Me.lblBin.AutoSize = True
        Me.lblBin.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!)
        Me.lblBin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblBin.Location = New System.Drawing.Point(62, 65)
        Me.lblBin.Name = "lblBin"
        Me.lblBin.Size = New System.Drawing.Size(89, 42)
        Me.lblBin.TabIndex = 4
        Me.lblBin.Text = "BIN:"
        '
        'lblOct
        '
        Me.lblOct.AutoSize = True
        Me.lblOct.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!)
        Me.lblOct.ForeColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblOct.Location = New System.Drawing.Point(44, 120)
        Me.lblOct.Name = "lblOct"
        Me.lblOct.Size = New System.Drawing.Size(107, 42)
        Me.lblOct.TabIndex = 5
        Me.lblOct.Text = "OCT:"
        '
        'lblDec
        '
        Me.lblDec.AutoSize = True
        Me.lblDec.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!)
        Me.lblDec.ForeColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblDec.Location = New System.Drawing.Point(43, 175)
        Me.lblDec.Name = "lblDec"
        Me.lblDec.Size = New System.Drawing.Size(107, 42)
        Me.lblDec.TabIndex = 6
        Me.lblDec.Text = "DEC:"
        '
        'lblHex
        '
        Me.lblHex.AutoSize = True
        Me.lblHex.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!)
        Me.lblHex.ForeColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblHex.Location = New System.Drawing.Point(45, 230)
        Me.lblHex.Name = "lblHex"
        Me.lblHex.Size = New System.Drawing.Size(105, 42)
        Me.lblHex.TabIndex = 7
        Me.lblHex.Text = "HEX:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 347)
        Me.Controls.Add(Me.lblHex)
        Me.Controls.Add(Me.lblDec)
        Me.Controls.Add(Me.lblOct)
        Me.Controls.Add(Me.lblBin)
        Me.Controls.Add(Me.txtBin)
        Me.Controls.Add(Me.txtOct)
        Me.Controls.Add(Me.txtDec)
        Me.Controls.Add(Me.txtHex)
        Me.Name = "Form1"
        Me.Text = "Number Base Converter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtHex As TextBox
    Friend WithEvents txtDec As TextBox
    Friend WithEvents txtOct As TextBox
    Friend WithEvents txtBin As TextBox
    Friend WithEvents lblBin As Label
    Friend WithEvents lblOct As Label
    Friend WithEvents lblDec As Label
    Friend WithEvents lblHex As Label
End Class
