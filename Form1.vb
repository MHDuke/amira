'Amira Abdulhamid Annubi - 1st architecture
Public Class Form1
    Private Sub btnCalculate_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCalculate.Click
        Dim distance As Double
        Double.TryParse(txtDistanceTravelled.Text, distance)

        Dim passengerCount As Integer
        Integer.TryParse(txtPassengerCount.Text, passengerCount)
        If distance = 0 OrElse passengerCount = 0 Then
            MessageBox.Show("distance travelled and passengers count must be greater than zero")
            Exit Sub
        End If
        txtResult.Text = CalculateFare(distance, passengerCount)
    End Sub
    Private Function CalculateFare(ByVal distance As Double, ByVal passengerCount As Int32) As String
        Const fixedInitialAmount = 3

        Dim fare = fixedInitialAmount + ((distance - 1) * passengerCount)

        If passengerCount > 5 Then
            fare = fare + (fare / 2)
        End If

        Return fare
    End Function
End Class
