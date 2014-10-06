Option Strict On

Public Class Form1

    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        Dim Ast, Bst, Cst, Dst As String
        Dim A, B, C, D As Double

        ' Read the input from the user
        Ast = txtA.Text
        Bst = txtB.Text
        Cst = txtC.Text
        Dst = txtD.Text

        ' All input must be numbers
        If Not (IsNumeric(Ast) And IsNumeric(Bst) And IsNumeric(Cst) _
                And IsNumeric(Dst)) Then
            MessageBox.Show("Please enter valid numbers", "Error!")
            Return
        End If

        ' Convert to double
        A = CDbl(Ast)
        B = CDbl(Bst)
        C = CDbl(Cst)
        D = CDbl(Dst)

        ' Please write your code here...

        If (B < A Or C < D) Then
            MessageBox.Show("please enter valid numbers", "Error")
        End If


        txtResult.Text = FindIntersection(A, B, C, D)
    End Sub


    Function FindIntersection(A As Double, B As Double, C As Double, d As Double) As String

        Dim result As String
        If (B < C) Or (d < A) Then
            result = "no intersection"
        Else
            Dim begPoint As Double
            begPoint = Math.Max(A, C)

            Dim endpoint As Double
            endpoint = Math.Min(B, d)

            result = "The intersection is from " & begPoint & " to " & endpoint\
            Return result
        End If



    End Function
End Class
