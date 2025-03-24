Public Class Cal10 'Inicio de clase pública Cal10
    Dim resultado As Double 'Definir resultado como double para poder operar con decimales y números grandes
    Private Sub SalirButton_Click(sender As Object, e As EventArgs) Handles SalirButton.Click 'Cuando se clickea el botón de salir
        Application.Exit() 'Salir del programa
    End Sub 'Fin de función salir
    Private Sub BorrarButton_Click(sender As Object, e As EventArgs) Handles BorrarButton.Click 'Cuando se clickea el botón de borrar
        Valor1.Clear() 'Limpiar valor 1
        Valor2.Clear() 'Limpiar valor 2 
        Valor3.Clear() 'Limpiar valor 3
        Valor4.Clear() 'Limpiar valor 4
        Valor5.Clear() 'Limpiar valor 5
        Valor6.Clear() 'Limpiar valor 6
        Valor7.Clear() 'Limpiar valor 7
        Valor8.Clear() 'Limpiar valor 8
        Valor9.Clear() 'Limpiar valor 9
        Valor10.Clear() 'Limpiar valor 10
        ValorResultado.Clear() 'Limpiar resultado
        Operador1.Text = "" 'Limpiar operador 1
        Operador2.Text = "" 'Limpiar operador 2
        Operador3.Text = "" 'Limpiar operador 3
        Operador4.Text = "" 'Limpiar operador 4
        Operador5.Text = "" 'Limpiar operador 5
        Operador6.Text = "" 'Limpiar operador 6
        Operador7.Text = "" 'Limpiar operador 7
        Operador8.Text = "" 'Limpiar operador 8
        Operador9.Text = "" 'Limpiar operador 9
        SumaCheck.Checked = False 'Descheckear suma
        RestaCheck.Checked = False 'Descheckear resta
        MultiplicaciónCheck.Checked = False 'Descheckear multiplicación
        DivisiónCheck.Checked = False 'Descheckear división
        BorrarButton.Enabled = False 'Deshabilitar botón de borrar
        BorrarUltimoButton.Enabled = False 'Deshabilitar botón de borrar último valor
    End Sub 'Fin de función borrar
    Private Sub SumaCheck_CheckedChanged(sender As Object, e As EventArgs) Handles SumaCheck.CheckedChanged 'Cuando cambia el check de suma
        If SumaCheck.Checked Then 'Si la suma está checkeada
            RestaCheck.Checked = False 'Descheckear resta
            MultiplicaciónCheck.Checked = False 'Descheckear multiplicación
            DivisiónCheck.Checked = False 'Descheckear división
            If Operador1.Text = "" Then 'Si el operador 1 está vacío
                Operador1.Text = "+" 'Operador 1 es suma
            ElseIf Operador2.Text = "" Then 'Si el operador 2 está vacío
                Operador2.Text = "+" 'Operador 2 es suma
            ElseIf Operador3.Text = "" Then 'Si el operador 3 está vacío
                Operador3.Text = "+" 'Operador 3 es suma
            ElseIf Operador4.Text = "" Then 'Si el operador 4 está vacío
                Operador4.Text = "+" 'Operador 4 es suma
            ElseIf Operador5.Text = "" Then 'Si el operador 5 está vacío
                Operador5.Text = "+" 'Operador 5 es suma
            ElseIf Operador6.Text = "" Then 'Si el operador 6 está vacío
                Operador6.Text = "+" 'Operador 6 es suma
            ElseIf Operador7.Text = "" Then 'Si el operador 7 está vacío
                Operador7.Text = "+" 'Operador 7 es suma
            ElseIf Operador8.Text = "" Then 'Si el operador 8 está vacío
                Operador8.Text = "+" 'Operador 8 es suma
            ElseIf Operador9.Text = "" Then 'Si el operador 9 está vacío
                Operador9.Text = "+" 'Operador 9 es suma
            End If 'Fin de condicional
            Calcular() 'Calcular
        End If 'Fin de condicional
    End Sub 'Fin de función check de suma
    Private Sub RestaCheck_CheckedChanged(sender As Object, e As EventArgs) Handles RestaCheck.CheckedChanged 'Cuando cambia el check de resta
        If RestaCheck.Checked Then 'Si la resta está checkeada
            SumaCheck.Checked = False 'Descheckear suma
            MultiplicaciónCheck.Checked = False 'Descheckear multiplicación
            DivisiónCheck.Checked = False 'Descheckear división
            If Operador1.Text = "" Then 'Si el operador 1 está vacío
                Operador1.Text = "-" 'Operador 1 es resta
            ElseIf Operador2.Text = "" Then 'Si el operador 2 está vacío
                Operador2.Text = "-" 'Operador 2 es resta
            ElseIf Operador3.Text = "" Then 'Si el operador 3 está vacío
                Operador3.Text = "-" 'Operador 3 es resta
            ElseIf Operador4.Text = "" Then 'Si el operador 4 está vacío
                Operador4.Text = "-" 'Operador 4 es resta
            ElseIf Operador5.Text = "" Then 'Si el operador 5 está vacío
                Operador5.Text = "-" 'Operador 5 es resta
            ElseIf Operador6.Text = "" Then 'Si el operador 6 está vacío
                Operador6.Text = "-" 'Operador 6 es resta
            ElseIf Operador7.Text = "" Then 'Si el operador 7 está vacío
                Operador7.Text = "-" 'Operador 7 es resta
            ElseIf Operador8.Text = "" Then 'Si el operador 8 está vacío
                Operador8.Text = "-" 'Operador 8 es resta
            ElseIf Operador9.Text = "" Then 'Si el operador 9 está vacío
                Operador9.Text = "-" 'Operador 9 es resta
            End If 'Fin de condicional
            Calcular() 'Calcular
        End If 'Fin de condicional
    End Sub 'Fin de función check de resta
    Private Sub MultiplicaciónCheck_CheckedChanged(sender As Object, e As EventArgs) Handles MultiplicaciónCheck.CheckedChanged 'Cuando cambia el check de multiplicación
        If MultiplicaciónCheck.Checked Then 'Si la multiplicación está checkeada
            SumaCheck.Checked = False 'Descheckear suma
            RestaCheck.Checked = False 'Descheckear resta
            DivisiónCheck.Checked = False 'Descheckear división
            If Operador1.Text = "" Then 'Si el operador 1 está vacío
                Operador1.Text = "*" 'Operador 1 es multiplicación
            ElseIf Operador2.Text = "" Then 'Si el operador 2 está vacío
                Operador2.Text = "*" 'Operador 2 es multiplicación
            ElseIf Operador3.Text = "" Then 'Si el operador 3 está vacío
                Operador3.Text = "*" 'Operador 3 es multiplicación
            ElseIf Operador4.Text = "" Then 'Si el operador 4 está vacío
                Operador4.Text = "*" 'Operador 4 es multiplicación
            ElseIf Operador5.Text = "" Then 'Si el operador 5 está vacío
                Operador5.Text = "*" 'Operador 5 es multiplicación
            ElseIf Operador6.Text = "" Then 'Si el operador 6 está vacío
                Operador6.Text = "*" 'Operador 6 es multiplicación
            ElseIf Operador7.Text = "" Then 'Si el operador 7 está vacío
                Operador7.Text = "*" 'Operador 7 es multiplicación
            ElseIf Operador8.Text = "" Then 'Si el operador 8 está vacío
                Operador8.Text = "*" 'Operador 8 es multiplicación
            ElseIf Operador9.Text = "" Then 'Si el operador 9 está vacío
                Operador9.Text = "*" 'Operador 9 es multiplicación
            End If 'Fin de condicional
            Calcular() 'Calcular
        End If 'Fin de condicional
    End Sub 'Fin de función check de multiplicación
    Private Sub DivisiónCheck_CheckedChanged(sender As Object, e As EventArgs) Handles DivisiónCheck.CheckedChanged 'Cuando cambia el check de división
        If DivisiónCheck.Checked Then 'Si la división está checkeada
            SumaCheck.Checked = False 'Descheckear suma
            RestaCheck.Checked = False 'Descheckear resta
            MultiplicaciónCheck.Checked = False 'Descheckear multiplicación
            If Operador1.Text = "" Then 'Si el operador 1 está vacío
                Operador1.Text = "/" 'Operador 1 es división
            ElseIf Operador2.Text = "" Then 'Si el operador 2 está vacío
                Operador2.Text = "/" 'Operador 2 es división
            ElseIf Operador3.Text = "" Then 'Si el operador 3 está vacío
                Operador3.Text = "/" 'Operador 3 es división
            ElseIf Operador4.Text = "" Then 'Si el operador 4 está vacío
                Operador4.Text = "/" 'Operador 4 es división
            ElseIf Operador5.Text = "" Then 'Si el operador 5 está vacío
                Operador5.Text = "/" 'Operador 5 es división
            ElseIf Operador6.Text = "" Then 'Si el operador 6 está vacío
                Operador6.Text = "/" 'Operador 6 es división
            ElseIf Operador7.Text = "" Then 'Si el operador 7 está vacío
                Operador7.Text = "/" 'Operador 7 es división
            ElseIf Operador8.Text = "" Then 'Si el operador 8 está vacío
                Operador8.Text = "/" 'Operador 8 es división
            ElseIf Operador9.Text = "" Then 'Si el operador 9 está vacío
                Operador9.Text = "/" 'Operador 9 es división
            End If 'Fin de condicional
            Calcular() 'Calcular
        End If 'Fin de condicional
    End Sub 'Fin de función check de división
    Private Sub BorrarUltimoButton_Click(sender As Object, e As EventArgs) Handles BorrarUltimoButton.Click 'Cuando se clickea el botón de borrar último valor
        If Valor10.Text <> "" Then 'Si el valor 10 no está vacío
            Valor10.Text = "" 'Vaciar valor 10
        ElseIf Valor9.Text <> "" Then 'Si el valor 9 no está vacío
            Valor9.Text = "" 'Vaciar valor 9
        ElseIf Valor8.Text <> "" Then 'Si el valor 8 no está vacío
            Valor8.Text = "" 'Vaciar valor 8
        ElseIf Valor7.Text <> "" Then 'Si el valor 7 no está vacío
            Valor7.Text = "" 'Vaciar valor 7
        ElseIf Valor6.Text <> "" Then 'Si el valor 6 no está vacío
            Valor6.Text = "" 'Vaciar valor 6
        ElseIf Valor5.Text <> "" Then 'Si el valor 5 no está vacío
            Valor5.Text = "" 'Vaciar valor 5
        ElseIf Valor4.Text <> "" Then 'Si el valor 4 no está vacío
            Valor4.Text = "" 'Vaciar valor 4
        ElseIf Valor3.Text <> "" Then 'Si el valor 3 no está vacío
            Valor3.Text = "" 'Vaciar valor 3
        ElseIf Valor2.Text <> "" Then 'Si el valor 2 no está vacío
            Valor2.Text = "" 'Vaciar valor 2
        ElseIf Valor1.Text <> "" Then 'Si el valor 1 no está vacío
            Valor1.Text = "" 'Vaciar valor 1
        End If 'Fin de condicional
        Operador1.Text = "" 'Vaciar operador 1
        Operador2.Text = "" 'Vaciar operador 2
        Operador3.Text = "" 'Vaciar operador 3
        Operador4.Text = "" 'Vaciar operador 4
        Operador5.Text = "" 'Vaciar operador 5
        Operador6.Text = "" 'Vaciar operador 6
        Operador7.Text = "" 'Vaciar operador 7
        Operador8.Text = "" 'Vaciar operador 8
        Operador9.Text = "" 'Vaciar operador 9
        SumaCheck.Checked = False 'Descheckear suma
        RestaCheck.Checked = False 'Descheckear resta
        MultiplicaciónCheck.Checked = False 'Descheckear multiplicación
        DivisiónCheck.Checked = False 'Descheckear división
    End Sub 'Fin de función borrar último valor
    Private Sub Valor1_TextChanged(sender As Object, e As EventArgs) Handles Valor1.TextChanged, Valor2.TextChanged, Valor3.TextChanged, Valor4.TextChanged, Valor5.TextChanged, Valor6.TextChanged, Valor7.TextChanged, Valor8.TextChanged, Valor9.TextChanged, Valor10.TextChanged 'Cuando cambia algún valor
        Calcular() 'Calcular con los dígitos existentes
    End Sub 'Fin de función al cambiar un valor
    Private Sub Calcular() 'Función de calcular
        If Valor1.Text <> "" Or Valor2.Text <> "" Or Valor3.Text <> "" Or Valor4.Text <> "" Or Valor5.Text <> "" Or Valor6.Text <> "" Or Valor7.Text <> "" Or Valor8.Text <> "" Or Valor9.Text <> "" Or Valor10.Text <> "" Or Operador1.Text <> "" Or Operador2.Text <> "" Or Operador3.Text <> "" Or Operador4.Text <> "" Or Operador5.Text <> "" Or Operador6.Text <> "" Or Operador7.Text <> "" Or Operador8.Text <> "" Or Operador9.Text <> "" Then 'Si hay algún valor u operador no vacío
            BorrarButton.Enabled = True 'Habilitar botón de borrar
            BorrarUltimoButton.Enabled = True 'Habilitar botón de borrar último valor
        Else 'Si no
            BorrarButton.Enabled = False 'Deshabilitar botón de borrar
            BorrarUltimoButton.Enabled = False 'Deshabilitar botón de borrar último valor
        End If 'Fin de condicional
        Try 'Intentar la ejecución del siguiente código
            resultado = Val(Valor1.Text) 'Resultado es igual al valor 1
            If Operador1.Text = "+" Then 'Si el operador 1 es suma
                resultado += Val(Valor2.Text) 'Resultado se suma por valor 2
            ElseIf Operador1.Text = "-" Then 'Si el operador 1 es resta
                resultado -= Val(Valor2.Text) 'Resultado se resta por valor 2
            ElseIf Operador1.Text = "*" Then 'Si el operador 1 es multiplicación
                resultado *= Val(Valor2.Text) 'Resultado se multiplica por valor 2
            ElseIf Operador1.Text = "/" Then 'Si el operador 1 es división
                resultado /= Val(Valor2.Text) 'Resultado se divide por valor 2
            End If 'Fin de condicional
            If Operador2.Text = "+" Then 'Si el operador 2 es suma
                resultado += Val(Valor3.Text) 'Resultado se suma por valor 3
            ElseIf Operador2.Text = "-" Then 'Si el operador 2 es resta
                resultado -= Val(Valor3.Text) 'Resultado se resta por valor 3
            ElseIf Operador2.Text = "*" Then 'Si el operador 2 es multiplicación
                resultado *= Val(Valor3.Text) 'Resultado se multiplica por valor 3
            ElseIf Operador2.Text = "/" Then 'Si el operador 2 es división
                resultado /= Val(Valor3.Text) 'Resultado se divide por valor 3
            End If 'Fin de condicional
            If Operador3.Text = "+" Then 'Si el operador 3 es suma
                resultado += Val(Valor4.Text) 'Resultado se suma por valor 4
            ElseIf Operador3.Text = "-" Then 'Si el operador 3 es resta
                resultado -= Val(Valor4.Text) 'Resultado se resta por valor 4
            ElseIf Operador3.Text = "*" Then 'Si el operador 3 es multiplicación
                resultado *= Val(Valor4.Text) 'Resultado se multiplica por valor 4
            ElseIf Operador3.Text = "/" Then 'Si el operador 3 es división
                resultado /= Val(Valor4.Text) 'Resultado se divide por valor 4
            End If 'Fin de condicional
            If Operador4.Text = "+" Then 'Si el operador 4 es suma
                resultado += Val(Valor5.Text) 'Resultado se suma por valor 5
            ElseIf Operador4.Text = "-" Then 'Si el operador 4 es resta
                resultado -= Val(Valor5.Text) 'Resultado se resta por valor 5
            ElseIf Operador4.Text = "*" Then 'Si el operador 4 es multiplicación
                resultado *= Val(Valor5.Text) 'Resultado se multiplica por valor 5
            ElseIf Operador4.Text = "/" Then 'Si el operador 4 es división
                resultado /= Val(Valor5.Text) 'Resultado se divide por valor 5
            End If 'Fin de condicional
            If Operador5.Text = "+" Then 'Si el operador 5 es suma
                resultado += Val(Valor6.Text) 'Resultado se suma por valor 6
            ElseIf Operador5.Text = "-" Then 'Si el operador 5 es resta
                resultado -= Val(Valor6.Text) 'Resultado se resta por valor 6
            ElseIf Operador5.Text = "*" Then 'Si el operador 5 es multiplicación
                resultado *= Val(Valor6.Text) 'Resultado se multiplica por valor 6
            ElseIf Operador5.Text = "/" Then 'Si el operador 5 es división
                resultado /= Val(Valor6.Text) 'Resultado se divide por valor 6
            End If 'Fin de condicional
            If Operador6.Text = "+" Then 'Si el operador 6 es suma
                resultado += Val(Valor7.Text) 'Resultado se suma por valor 7
            ElseIf Operador6.Text = "-" Then 'Si el operador 6 es resta
                resultado -= Val(Valor7.Text) 'Resultado se resta por valor 7
            ElseIf Operador6.Text = "*" Then 'Si el operador 6 es multiplicación
                resultado *= Val(Valor7.Text) 'Resultado se multiplica por valor 7
            ElseIf Operador6.Text = "/" Then 'Si el operador 6 es división
                resultado /= Val(Valor7.Text) 'Resultado se divide por valor 7
            End If 'Fin de condicional
            If Operador7.Text = "+" Then 'Si el operador 7 es suma
                resultado += Val(Valor8.Text) 'Resultado se suma por valor 8
            ElseIf Operador7.Text = "-" Then 'Si el operador 7 es resta
                resultado -= Val(Valor8.Text) 'Resultado se resta por valor 8
            ElseIf Operador7.Text = "*" Then 'Si el operador 7 es multiplicación
                resultado *= Val(Valor8.Text) 'Resultado se multiplica por valor 8
            ElseIf Operador7.Text = "/" Then 'Si el operador 7 es división
                resultado /= Val(Valor8.Text) 'Resultado se divide por valor 8
            End If 'Fin de condicional
            If Operador8.Text = "+" Then 'Si el operador 8 es suma
                resultado += Val(Valor9.Text) 'Resultado se suma por valor 9
            ElseIf Operador8.Text = "-" Then 'Si el operador 8 es resta
                resultado -= Val(Valor9.Text) 'Resultado se resta por valor 9
            ElseIf Operador8.Text = "*" Then 'Si el operador 8 es multiplicación
                resultado *= Val(Valor9.Text) 'Resultado se multiplica por valor 9
            ElseIf Operador8.Text = "/" Then 'Si el operador 8 es división
                resultado /= Val(Valor9.Text) 'Resultado se divide por valor 9
            End If 'Fin de condicional
            If Operador9.Text = "+" Then 'Si el operador 9 es suma
                resultado += Val(Valor10.Text) 'Resultado se suma por valor 10
            ElseIf Operador9.Text = "-" Then 'Si el operador 9 es resta
                resultado -= Val(Valor10.Text) 'Resultado se resta por valor 10
            ElseIf Operador9.Text = "*" Then 'Si el operador 9 es multiplicación
                resultado *= Val(Valor10.Text) 'Resultado se multiplica por valor 10
            ElseIf Operador9.Text = "/" Then 'Si el operador 9 es división
                resultado /= Val(Valor10.Text) 'Resultado se divide por valor 10
            End If 'Fin de condicional
            If resultado.ToString() = "NaN" Then 'Si el resultado no es un número
                ValorResultado.Text = "" 'Vaciar resultado
            ElseIf resultado = "∞" Then 'Si el resultado es infinito (división por cero o números muy grandes)
                ValorResultado.Text = "Indeterminado" 'Resultado es indeterminado
            Else 'Si no
                ValorResultado.Text = resultado 'El resultado es el número del resultado
            End If 'Fin de condicional
        Catch e As OverflowException 'Si hay un desborde aritmético
            ValorResultado.Text = "Error" 'Escribir error en el resultado
        End Try 'Fin de try
    End Sub 'Fin de función Calcular
    Private Sub Valor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Valor1.KeyPress, Valor2.KeyPress, Valor3.KeyPress, Valor4.KeyPress, Valor5.KeyPress, Valor6.KeyPress, Valor7.KeyPress, Valor8.KeyPress, Valor9.KeyPress, Valor10.KeyPress 'Al presionar una tecla en algún valor
        If Not Char.IsControl(e.KeyChar) And Not Char.IsDigit(e.KeyChar) Then 'Si la tecla no es de control (enter, borrar, etc.) y no es un dígito
            MessageBox.Show("Por favor sólo ingresar números!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error) 'Mostrar error
            e.Handled = True 'Evento manejado, termina el evento (evita que se escriba el carácter en el textbox)
        End If 'Fin de condicional
    End Sub 'Fin de función al presionar una tecla en un valor
End Class 'Fin de clase Cal10
