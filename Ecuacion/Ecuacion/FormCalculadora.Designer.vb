<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formCalculadora
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.lblEnunciado1 = New System.Windows.Forms.Label()
        Me.lblEcuacion = New System.Windows.Forms.Label()
        Me.lblEnunciado2 = New System.Windows.Forms.Label()
        Me.lblA = New System.Windows.Forms.Label()
        Me.lblB = New System.Windows.Forms.Label()
        Me.lblC = New System.Windows.Forms.Label()
        Me.txtBoxA = New System.Windows.Forms.TextBox()
        Me.txtBoxB = New System.Windows.Forms.TextBox()
        Me.txtBoxC = New System.Windows.Forms.TextBox()
        Me.lblRaiz1 = New System.Windows.Forms.Label()
        Me.lblRaiz2 = New System.Windows.Forms.Label()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.lblRE1 = New System.Windows.Forms.Label()
        Me.lblRE2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCalcular
        '
        Me.btnCalcular.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
        Me.btnCalcular.Location = New System.Drawing.Point(188, 107)
        Me.btnCalcular.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(243, 108)
        Me.btnCalcular.TabIndex = 0
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'lblEnunciado1
        '
        Me.lblEnunciado1.AutoSize = True
        Me.lblEnunciado1.Location = New System.Drawing.Point(31, 23)
        Me.lblEnunciado1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEnunciado1.Name = "lblEnunciado1"
        Me.lblEnunciado1.Size = New System.Drawing.Size(402, 17)
        Me.lblEnunciado1.TabIndex = 1
        Me.lblEnunciado1.Text = "Dada la fórmula general de las ecuaciones de segundo grado:"
        '
        'lblEcuacion
        '
        Me.lblEcuacion.AutoSize = True
        Me.lblEcuacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.lblEcuacion.Location = New System.Drawing.Point(439, 13)
        Me.lblEcuacion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEcuacion.Name = "lblEcuacion"
        Me.lblEcuacion.Size = New System.Drawing.Size(187, 31)
        Me.lblEcuacion.TabIndex = 2
        Me.lblEcuacion.Text = "Ax^2+Bx+C=0"
        Me.lblEcuacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEnunciado2
        '
        Me.lblEnunciado2.AutoSize = True
        Me.lblEnunciado2.Location = New System.Drawing.Point(31, 60)
        Me.lblEnunciado2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEnunciado2.Name = "lblEnunciado2"
        Me.lblEnunciado2.Size = New System.Drawing.Size(420, 17)
        Me.lblEnunciado2.TabIndex = 3
        Me.lblEnunciado2.Text = "Introduzca los valores de los parámetros para obtener las raíces!!"
        '
        'lblA
        '
        Me.lblA.AutoSize = True
        Me.lblA.Location = New System.Drawing.Point(31, 112)
        Me.lblA.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblA.Name = "lblA"
        Me.lblA.Size = New System.Drawing.Size(17, 17)
        Me.lblA.TabIndex = 4
        Me.lblA.Text = "A"
        '
        'lblB
        '
        Me.lblB.AutoSize = True
        Me.lblB.Location = New System.Drawing.Point(31, 153)
        Me.lblB.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblB.Name = "lblB"
        Me.lblB.Size = New System.Drawing.Size(17, 17)
        Me.lblB.TabIndex = 5
        Me.lblB.Text = "B"
        '
        'lblC
        '
        Me.lblC.AutoSize = True
        Me.lblC.Location = New System.Drawing.Point(31, 193)
        Me.lblC.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblC.Name = "lblC"
        Me.lblC.Size = New System.Drawing.Size(17, 17)
        Me.lblC.TabIndex = 6
        Me.lblC.Text = "C"
        '
        'txtBoxA
        '
        Me.txtBoxA.Location = New System.Drawing.Point(69, 107)
        Me.txtBoxA.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBoxA.Name = "txtBoxA"
        Me.txtBoxA.Size = New System.Drawing.Size(84, 22)
        Me.txtBoxA.TabIndex = 7
        '
        'txtBoxB
        '
        Me.txtBoxB.Location = New System.Drawing.Point(69, 148)
        Me.txtBoxB.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBoxB.Name = "txtBoxB"
        Me.txtBoxB.Size = New System.Drawing.Size(84, 22)
        Me.txtBoxB.TabIndex = 8
        '
        'txtBoxC
        '
        Me.txtBoxC.Location = New System.Drawing.Point(69, 188)
        Me.txtBoxC.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBoxC.Name = "txtBoxC"
        Me.txtBoxC.Size = New System.Drawing.Size(84, 22)
        Me.txtBoxC.TabIndex = 9
        '
        'lblRaiz1
        '
        Me.lblRaiz1.AutoSize = True
        Me.lblRaiz1.Location = New System.Drawing.Point(441, 116)
        Me.lblRaiz1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRaiz1.Name = "lblRaiz1"
        Me.lblRaiz1.Size = New System.Drawing.Size(52, 17)
        Me.lblRaiz1.TabIndex = 10
        Me.lblRaiz1.Text = "Raíz 1:"
        '
        'lblRaiz2
        '
        Me.lblRaiz2.AutoSize = True
        Me.lblRaiz2.Location = New System.Drawing.Point(440, 156)
        Me.lblRaiz2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRaiz2.Name = "lblRaiz2"
        Me.lblRaiz2.Size = New System.Drawing.Size(52, 17)
        Me.lblRaiz2.TabIndex = 11
        Me.lblRaiz2.Text = "Raíz 2:"
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblEstado.Location = New System.Drawing.Point(441, 191)
        Me.lblEstado.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(67, 20)
        Me.lblEstado.TabIndex = 12
        Me.lblEstado.Text = "Estado"
        '
        'lblRE1
        '
        Me.lblRE1.AutoSize = True
        Me.lblRE1.Location = New System.Drawing.Point(497, 116)
        Me.lblRE1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRE1.Name = "lblRE1"
        Me.lblRE1.Size = New System.Drawing.Size(0, 17)
        Me.lblRE1.TabIndex = 13
        '
        'lblRE2
        '
        Me.lblRE2.AutoSize = True
        Me.lblRE2.Location = New System.Drawing.Point(497, 156)
        Me.lblRE2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRE2.Name = "lblRE2"
        Me.lblRE2.Size = New System.Drawing.Size(0, 17)
        Me.lblRE2.TabIndex = 14
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(69, 243)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 23)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Prueba 1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(188, 243)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(90, 23)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "Prueba 2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(320, 243)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(90, 23)
        Me.Button3.TabIndex = 17
        Me.Button3.Text = "Prueba 3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'formCalculadora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(686, 303)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblRE2)
        Me.Controls.Add(Me.lblRE1)
        Me.Controls.Add(Me.lblEstado)
        Me.Controls.Add(Me.lblRaiz2)
        Me.Controls.Add(Me.lblRaiz1)
        Me.Controls.Add(Me.txtBoxC)
        Me.Controls.Add(Me.txtBoxB)
        Me.Controls.Add(Me.txtBoxA)
        Me.Controls.Add(Me.lblC)
        Me.Controls.Add(Me.lblB)
        Me.Controls.Add(Me.lblA)
        Me.Controls.Add(Me.lblEnunciado2)
        Me.Controls.Add(Me.lblEcuacion)
        Me.Controls.Add(Me.lblEnunciado1)
        Me.Controls.Add(Me.btnCalcular)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "formCalculadora"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "Ejemplo de Aplicación con Windows Forms"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCalcular As Button
    Friend WithEvents lblEnunciado1 As Label
    Friend WithEvents lblEcuacion As Label
    Friend WithEvents lblEnunciado2 As Label
    Friend WithEvents lblA As Label
    Friend WithEvents lblB As Label
    Friend WithEvents lblC As Label
    Friend WithEvents txtBoxA As TextBox
    Friend WithEvents txtBoxB As TextBox
    Friend WithEvents txtBoxC As TextBox
    Friend WithEvents lblRaiz1 As Label
    Friend WithEvents lblRaiz2 As Label
    Friend WithEvents lblEstado As Label
    Friend WithEvents lblRE1 As Label
    Friend WithEvents lblRE2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
