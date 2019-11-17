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
        Me.displayBox = New System.Windows.Forms.TextBox()
        Me.operatorBox = New System.Windows.Forms.TextBox()
        Me.btnDec = New System.Windows.Forms.Button()
        Me.btnC = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btn9 = New System.Windows.Forms.Button()
        Me.btn8 = New System.Windows.Forms.Button()
        Me.btn7 = New System.Windows.Forms.Button()
        Me.btn6 = New System.Windows.Forms.Button()
        Me.btn5 = New System.Windows.Forms.Button()
        Me.btn4 = New System.Windows.Forms.Button()
        Me.btnMinus = New System.Windows.Forms.Button()
        Me.btnMultiply = New System.Windows.Forms.Button()
        Me.btnDivide = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.btnEquals = New System.Windows.Forms.Button()
        Me.btn0 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'displayBox
        '
        Me.displayBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.displayBox.Location = New System.Drawing.Point(25, 106)
        Me.displayBox.Multiline = True
        Me.displayBox.Name = "displayBox"
        Me.displayBox.Size = New System.Drawing.Size(389, 47)
        Me.displayBox.TabIndex = 0
        Me.displayBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'operatorBox
        '
        Me.operatorBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.operatorBox.Location = New System.Drawing.Point(25, 36)
        Me.operatorBox.Multiline = True
        Me.operatorBox.Name = "operatorBox"
        Me.operatorBox.Size = New System.Drawing.Size(389, 47)
        Me.operatorBox.TabIndex = 1
        Me.operatorBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnDec
        '
        Me.btnDec.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btnDec.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDec.Location = New System.Drawing.Point(232, 593)
        Me.btnDec.Name = "btnDec"
        Me.btnDec.Size = New System.Drawing.Size(75, 69)
        Me.btnDec.TabIndex = 2
        Me.btnDec.Text = "." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnDec.UseVisualStyleBackColor = False
        '
        'btnC
        '
        Me.btnC.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btnC.Location = New System.Drawing.Point(233, 173)
        Me.btnC.Name = "btnC"
        Me.btnC.Size = New System.Drawing.Size(75, 69)
        Me.btnC.TabIndex = 3
        Me.btnC.Text = "C"
        Me.btnC.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btnBack.Location = New System.Drawing.Point(131, 173)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 69)
        Me.btnBack.TabIndex = 4
        Me.btnBack.Text = "<--"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btn9
        '
        Me.btn9.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btn9.Location = New System.Drawing.Point(231, 280)
        Me.btn9.Name = "btn9"
        Me.btn9.Size = New System.Drawing.Size(75, 69)
        Me.btn9.TabIndex = 7
        Me.btn9.Text = "9"
        Me.btn9.UseVisualStyleBackColor = False
        '
        'btn8
        '
        Me.btn8.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btn8.Location = New System.Drawing.Point(130, 280)
        Me.btn8.Name = "btn8"
        Me.btn8.Size = New System.Drawing.Size(75, 69)
        Me.btn8.TabIndex = 6
        Me.btn8.Text = "8"
        Me.btn8.UseVisualStyleBackColor = False
        '
        'btn7
        '
        Me.btn7.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btn7.Location = New System.Drawing.Point(24, 280)
        Me.btn7.Name = "btn7"
        Me.btn7.Size = New System.Drawing.Size(75, 69)
        Me.btn7.TabIndex = 5
        Me.btn7.Text = "7"
        Me.btn7.UseVisualStyleBackColor = False
        '
        'btn6
        '
        Me.btn6.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btn6.Location = New System.Drawing.Point(231, 388)
        Me.btn6.Name = "btn6"
        Me.btn6.Size = New System.Drawing.Size(75, 69)
        Me.btn6.TabIndex = 10
        Me.btn6.Text = "6"
        Me.btn6.UseVisualStyleBackColor = False
        '
        'btn5
        '
        Me.btn5.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btn5.Location = New System.Drawing.Point(130, 388)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(75, 69)
        Me.btn5.TabIndex = 9
        Me.btn5.Text = "5"
        Me.btn5.UseVisualStyleBackColor = False
        '
        'btn4
        '
        Me.btn4.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btn4.Location = New System.Drawing.Point(24, 388)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(75, 69)
        Me.btn4.TabIndex = 8
        Me.btn4.Text = "4"
        Me.btn4.UseVisualStyleBackColor = False
        '
        'btnMinus
        '
        Me.btnMinus.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btnMinus.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMinus.Location = New System.Drawing.Point(338, 388)
        Me.btnMinus.Name = "btnMinus"
        Me.btnMinus.Size = New System.Drawing.Size(75, 69)
        Me.btnMinus.TabIndex = 13
        Me.btnMinus.Text = "-"
        Me.btnMinus.UseVisualStyleBackColor = False
        '
        'btnMultiply
        '
        Me.btnMultiply.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btnMultiply.Location = New System.Drawing.Point(338, 280)
        Me.btnMultiply.Name = "btnMultiply"
        Me.btnMultiply.Size = New System.Drawing.Size(75, 69)
        Me.btnMultiply.TabIndex = 12
        Me.btnMultiply.Text = "X"
        Me.btnMultiply.UseVisualStyleBackColor = False
        '
        'btnDivide
        '
        Me.btnDivide.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btnDivide.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDivide.Location = New System.Drawing.Point(338, 173)
        Me.btnDivide.Name = "btnDivide"
        Me.btnDivide.Size = New System.Drawing.Size(75, 69)
        Me.btnDivide.TabIndex = 11
        Me.btnDivide.Text = "÷"
        Me.btnDivide.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(339, 493)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 69)
        Me.btnAdd.TabIndex = 17
        Me.btnAdd.Text = "+"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btn3
        '
        Me.btn3.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btn3.Location = New System.Drawing.Point(232, 493)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(75, 69)
        Me.btn3.TabIndex = 16
        Me.btn3.Text = "3"
        Me.btn3.UseVisualStyleBackColor = False
        '
        'btn2
        '
        Me.btn2.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btn2.Location = New System.Drawing.Point(131, 493)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(75, 69)
        Me.btn2.TabIndex = 15
        Me.btn2.Text = "2"
        Me.btn2.UseVisualStyleBackColor = False
        '
        'btn1
        '
        Me.btn1.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btn1.Location = New System.Drawing.Point(25, 493)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(75, 69)
        Me.btn1.TabIndex = 14
        Me.btn1.Text = "1"
        Me.btn1.UseVisualStyleBackColor = False
        '
        'btnEquals
        '
        Me.btnEquals.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btnEquals.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEquals.Location = New System.Drawing.Point(339, 593)
        Me.btnEquals.Name = "btnEquals"
        Me.btnEquals.Size = New System.Drawing.Size(75, 69)
        Me.btnEquals.TabIndex = 21
        Me.btnEquals.Text = "="
        Me.btnEquals.UseVisualStyleBackColor = False
        '
        'btn0
        '
        Me.btn0.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btn0.Location = New System.Drawing.Point(131, 593)
        Me.btn0.Name = "btn0"
        Me.btn0.Size = New System.Drawing.Size(75, 69)
        Me.btn0.TabIndex = 19
        Me.btn0.Text = "0"
        Me.btn0.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.ClientSize = New System.Drawing.Size(440, 692)
        Me.Controls.Add(Me.btnEquals)
        Me.Controls.Add(Me.btn0)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.btnMinus)
        Me.Controls.Add(Me.btnMultiply)
        Me.Controls.Add(Me.btnDivide)
        Me.Controls.Add(Me.btn6)
        Me.Controls.Add(Me.btn5)
        Me.Controls.Add(Me.btn4)
        Me.Controls.Add(Me.btn9)
        Me.Controls.Add(Me.btn8)
        Me.Controls.Add(Me.btn7)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnC)
        Me.Controls.Add(Me.btnDec)
        Me.Controls.Add(Me.operatorBox)
        Me.Controls.Add(Me.displayBox)
        Me.Name = "Form1"
        Me.Text = "CALCULATOR"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents displayBox As TextBox
    Friend WithEvents operatorBox As TextBox
    Friend WithEvents btnDec As Button
    Friend WithEvents btnC As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents btn9 As Button
    Friend WithEvents btn8 As Button
    Friend WithEvents btn7 As Button
    Friend WithEvents btn6 As Button
    Friend WithEvents btn5 As Button
    Friend WithEvents btn4 As Button
    Friend WithEvents btnMinus As Button
    Friend WithEvents btnMultiply As Button
    Friend WithEvents btnDivide As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents btn1 As Button
    Friend WithEvents btnEquals As Button
    Friend WithEvents btn0 As Button
End Class
