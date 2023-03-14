Public Class Complejo
    Private ReadOnly real As Double
    Private ReadOnly imaginario As Double
    Public Sub New(real As Double, imaginario As Double)
        Me.real = real
        Me.imaginario = imaginario
    End Sub

    Public Overrides Function ToString() As String
        Dim texto As String
        texto = real.ToString("0.00")
        If imaginario <> 0 Then
            texto += " " + imaginario.ToString("0.00") + " i"
            'ElseIf imaginario < 0 Then
            '    texto += " " + imaginario.ToString("0.00") + " -i"
        End If
        Return texto
    End Function
End Class
