Public Class Ecuacion

    Private _a As Double
    Private _b As Double
    Private _c As Double

    Private _Re1 As Double
    Private _Im1 As Double
    Private _Re2 As Double
    Private _Im2 As Double

    Private _Estado As Integer
    Private _Complejo1 As Complejo
    Private _Complejo2 As Complejo

    Public Sub New(a As Double, b As Double, c As Double)
        Me._a = a
        Me._b = b
        Me._c = c
    End Sub

    Public Property A As Double
        Get
            Return Me._a
        End Get
        Set(ByVal value As Double)
            Me._a = value
        End Set
    End Property

    Public Property B As Double
        Get
            Return Me._b
        End Get
        Set(ByVal value As Double)
            Me._b = value
        End Set
    End Property

    Public Property C As Double
        Get
            Return Me._c
        End Get
        Set(ByVal value As Double)
            Me._c = value
        End Set
    End Property

    Public Property Re1 As Double
        Get
            Return _Re1
        End Get
        Set(value As Double)
            _Re1 = value
        End Set
    End Property

    Public Property Im1 As Double
        Get
            Return _Im1
        End Get
        Set(value As Double)
            _Im1 = value
        End Set
    End Property

    Public Property Re2 As Double
        Get
            Return _Re2
        End Get
        Set(value As Double)
            _Re2 = value
        End Set
    End Property

    Public Property Im2 As Double
        Get
            Return _Im2
        End Get
        Set(value As Double)
            _Im2 = value
        End Set
    End Property

    Public Property Complejo1 As Complejo
        Get
            Return _Complejo1
        End Get
        Set
            _Complejo1 = Value
        End Set
    End Property

    Public Property Complejo2 As Complejo
        Get
            Return _Complejo2
        End Get
        Set
            _Complejo2 = Value
        End Set
    End Property

    Public Property Estado As Integer
        Get
            Return _Estado
        End Get
        Set(value As Integer)
            _Estado = value
        End Set
    End Property

    Public Function Calcular() As Double
        Dim delta As Double
        delta = Math.Pow(B, 2) - (4 * A * C)
        If delta > 0 Then
            Re1 = (-B + Math.Sqrt(delta)) / (2 * A)
            'Re1 = Math.Sign(Re1) * Math.Floor(Math.Abs(Re1) * 100) / 100.0
            Re2 = (-B - Math.Sqrt(delta)) / (2 * A)
        ElseIf delta <= 0 Then
            Re1 = -B / (2 * A)
            Re2 = Re1
            If delta < 0 Then
                Im1 = Math.Sqrt(-delta) / (2 * A)
                Im2 = -Im1
            End If
        End If
        Complejo1 = New Complejo(Re1, Im1)
        Complejo2 = New Complejo(Re2, Im2)

        Return delta
    End Function
End Class