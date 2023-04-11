Public Class formCalculadora
    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        Button1.Visible = False
        Button2.Visible = False
        Button3.Visible = False
        'btnCalcular.Enabled = False
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Private Sub btnCalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcular.Click

        Dim va, vb, vc As Double
        Dim ec As Ecuacion

        Try
            va = Convert.ToDouble(txtBoxA.Text)
            vb = Convert.ToDouble(txtBoxB.Text)
            vc = Convert.ToDouble(txtBoxC.Text)
        Catch fex As FormatException
            MessageBox.Show(fex.Source & Constants.vbCrLf & fex.Message, "Error de formato al convertir datos de entrada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        Catch oex As OverflowException
            MessageBox.Show(oex.Source & Constants.vbCrLf & oex.Message, "Error de desbordamiento al convertir datos de entrada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try
        ec = New Ecuacion(va, vb, vc)
        If ec.Calcular() < 0 Then
            lblRE1.ForeColor = Color.Red
            lblRE2.ForeColor = Color.Red
            lblEstado.Text = "Estado Imaginario"
        Else
            lblRE1.ForeColor = Color.Black
            lblRE2.ForeColor = Color.Black
            lblEstado.Text = "Estado Real"
        End If

        lblRE1.Text = ec.Complejo1.ToString()
        lblRE2.Text = ec.Complejo2.ToString()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtBoxA.Text = "2,69"
        txtBoxB.Text = "-1,87"
        txtBoxC.Text = "5,47"
        btnCalcular.PerformClick()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtBoxA.Text = "-0,78"
        txtBoxB.Text = "3,58"
        txtBoxC.Text = "-2,73"
        btnCalcular.PerformClick()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        txtBoxA.Text = "4"
        txtBoxB.Text = "28"
        txtBoxC.Text = "49"
        btnCalcular.PerformClick()
    End Sub

    Private Sub formCalculadora_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim consejo As New ToolTip
        consejo.SetToolTip(Button1, "a = 2,69, b = -1,87, c= 5,47")
        consejo.SetToolTip(Button2, "a = -0,78, b = 3,58, c= -2,73")
        consejo.SetToolTip(Button3, "a = 4, b = 28, c= 49")
    End Sub
End Class