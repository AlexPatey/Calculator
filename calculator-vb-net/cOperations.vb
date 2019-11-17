Public Class cOperations

    Private value1 As Decimal
    Private value2 As Decimal
    Private oper As Char
    Private answer As Decimal

    Private Sub setVal1(ByVal val1 As Decimal)

        value1 = val1

    End Sub

    Private Sub setVal2(ByVal val2 As Decimal)

        value2 = val2

    End Sub

    Public Sub typeNumber(ByVal number As Integer)

        If Form1.displayBox.Text.Length < 18 And Form1.operatorBox.Text = "" Then
            Form1.displayBox.Text = Form1.displayBox.Text & number
            Me.setVal1(CDec(Form1.displayBox.Text))
        ElseIf Form1.displayBox.Text.Length < 18 Then
            Form1.displayBox.Text = Form1.displayBox.Text & number
            Me.setVal2(CDec(Form1.displayBox.Text))
        Else
            MsgBox("Cannot add another digit!!")
        End If

    End Sub

    Public Sub truncateNumber(ByVal truncateAmount As Integer)

        If Not Form1.displayBox.Text.Length = 0 Then
            Form1.displayBox.Text = Microsoft.VisualBasic.Strings.Left(Form1.displayBox.Text, truncateAmount)

            If Not Form1.displayBox.Text.Length = 0 Then
                Me.setVal1(CDec(Form1.displayBox.Text))
            Else
                Me.setVal1(0)
            End If

        End If

    End Sub

    Private Sub shiftVal(ByVal val As Decimal, ByVal op As Char)


        Form1.displayBox.Text = ""

        Form1.operatorBox.Text = val & " " & op


    End Sub

    Public Sub chooseOperation(ByVal op As Char)

        Select Case op

            Case "a"

                shiftVal(value1, "+")
                oper = "+"

            Case "s"

                shiftVal(value1, "-")
                oper = "-"

            Case "d"

                shiftVal(value1, "÷")
                oper = "/"

            Case "m"

                shiftVal(value1, "X")
                oper = "*"

        End Select

    End Sub

    Public Sub doOperation()

        Select Case oper

            Case "+"

                answer = value1 + value2

            Case "-"

                answer = value1 - value2

            Case "/"

                answer = value1 / value2

            Case "*"

                answer = value1 * value2

        End Select

        Form1.operatorBox.Text = ""
        Form1.displayBox.Text = answer
        value1 = CDec(answer)

    End Sub

    Public Sub addDec()

        If Not Form1.displayBox.Text.Contains(".") Then
            If Form1.displayBox.Text.Length < 18 And Form1.operatorBox.Text = "" Then
                Form1.displayBox.Text = Form1.displayBox.Text & "."
                Me.setVal1(CDec(Form1.displayBox.Text))
            ElseIf Form1.displayBox.Text.Length < 18 Then
                Form1.displayBox.Text = Form1.displayBox.Text & "."
                Me.setVal2(CDec(Form1.displayBox.Text))
            Else
                MsgBox("Cannot add another digit!!")
            End If
        End If

    End Sub

End Class
