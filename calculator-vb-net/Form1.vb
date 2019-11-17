Public Class Form1

    Public Operations As cOperations
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Operations = New cOperations

    End Sub

    '------------------------------------------------------------------------------
    'Allows user to type number up to maximum number 999999999999999999, else an 
    'error message appears

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click

        Me.Operations.typeNumber(1)

    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click

        Me.Operations.typeNumber(2)

    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click

        Me.Operations.typeNumber(3)

    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click

        Me.Operations.typeNumber(4)

    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click

        Me.Operations.typeNumber(5)

    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click

        Me.Operations.typeNumber(6)

    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click

        Me.Operations.typeNumber(7)

    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click

        Me.Operations.typeNumber(8)

    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click

        Me.Operations.typeNumber(9)

    End Sub

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click

        Me.Operations.typeNumber(0)

    End Sub

    '------------------------------------------------------------------------------


    Private Sub btnC_Click(sender As Object, e As EventArgs) Handles btnC.Click

        Me.Operations.truncateNumber(0)

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        Me.Operations.truncateNumber(Me.displayBox.Text.Length - 1)

    End Sub

    Private Sub btnDivide_Click(sender As Object, e As EventArgs) Handles btnDivide.Click

        Me.Operations.chooseOperation("d")

    End Sub

    Private Sub btnMultiply_Click(sender As Object, e As EventArgs) Handles btnMultiply.Click

        Me.Operations.chooseOperation("m")

    End Sub

    Private Sub btnMinus_Click(sender As Object, e As EventArgs) Handles btnMinus.Click

        Me.Operations.chooseOperation("s")

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        Me.Operations.chooseOperation("a")

    End Sub

    Private Sub btnEquals_Click(sender As Object, e As EventArgs) Handles btnEquals.Click

        Me.Operations.doOperation()

    End Sub

    Private Sub btnDec_Click(sender As Object, e As EventArgs) Handles btnDec.Click

        Me.Operations.addDec()

    End Sub
End Class
