Option Strict On
Public Class Form1


    Private Sub btnCalculate_Click(sender As System.Object, e As System.EventArgs) Handles btnCalculate.Click

        Dim result As Double
        Dim aST As String = txtSideOne.Text
        Dim bST As String = txtSideTwo.Text

        Dim a, b As Double
        a = CDbl(aST)
        b = CDbl(bST)

        Result = Hypotnuse(3, 4)
        txtHyp.Text = CStr(result)

    End Sub
    Function Hypotnuse(ByVal a As Double, ByVal b As Double) As Double

        Dim c As Double
        c = Math.Sqrt(a ^ 2 + b ^ 2)

        Return c
    End Function
End Class
