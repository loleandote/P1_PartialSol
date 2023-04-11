Public Class Complejo
    Private ReadOnly real As Double
    Private ReadOnly imaginario As Double
    Public Sub New(real As Double, imaginario As Double)
        Me.real = Math.Sign(real) * Math.Floor(Math.Abs(real) * 100) / 100.0
        Me.imaginario = Math.Sign(imaginario) * Math.Floor(Math.Abs(imaginario) * 100) / 100.0
    End Sub

    Public Overrides Function ToString() As String
        Dim texto As String
        texto = real.ToString("0.00")
        If imaginario > 0 Then
            texto += "+" + imaginario.ToString("0.00") + " i"
        ElseIf imaginario < 0 Then
            texto += "-" + imaginario.ToString("0.00") + " i"
        End If
        Return texto
    End Function
End Class
