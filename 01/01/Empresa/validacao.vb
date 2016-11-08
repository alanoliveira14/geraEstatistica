Public Class validacao

    Shared Function validarCPF(ByVal CPF As String)
        Dim j As Integer = 10
        Dim a As Integer = 0
        Dim x As Integer = 0
        Dim y As Integer = 0
        Dim z As Integer = 0
        If CPF.Length <> 14 Then
            Return False
        Else
            CPF = CPF.Substring(0, 3) + CPF.Substring(4, 3) + CPF.Substring(8, 3) + CPF.Substring(12)
            While j > 1
                x = x + CInt(CPF.Substring(y, 1)) * j
                y = y + 1
                j = j - 1
            End While
            z = x Mod 11
            If z = 0 Or z = 1 Then
                a = 0
            Else
                a = 11 - z
            End If
            If (CPF.Substring(9, 1) <> a) Then
                Return False
            Else
                j = 11
                x = 0
                y = 0
                While j > 1
                    x = x + CInt(CPF.Substring(y, 1)) * j
                    y = y + 1
                    j = j - 1
                End While
                z = x Mod 11
                If z = 0 Or z = 1 Then
                    a = 0
                Else
                    a = 11 - z
                End If
                If (CPF.Substring(10, 1) <> a) Then
                    Return False
                Else
                    Return True
                End If
            End If
        End If
    End Function

    Shared Function validarcnpj(ByVal CNPJ As String)
        Dim j As Integer = 5
        Dim c As Integer = 0
        Dim a As Integer = 0
        Dim x As Integer = 0
        Dim y As Integer = 0
        Dim z As Integer = 0
        If CNPJ.Length <> 18 Then
            Return False
        Else
            CNPJ = CNPJ.Substring(0, 2) + CNPJ.Substring(3, 3) + CNPJ.Substring(7, 3) + CNPJ.Substring(11, 4) + CNPJ.Substring(16, 2)
            While j > 1
                x = x + CInt(CNPJ.Substring(y, 1)) * j
                y = y + 1
                j = j - 1
                If j = 1 And c = 0 Then
                    j = 9
                    c = 1
                End If
            End While
            z = x Mod 11
            If z = 0 Or z = 1 Then
                a = 0
            Else
                a = 11 - z
            End If
            If (CNPJ.Substring(12, 1) <> a) Then
                Return False
            Else
                j = 6
                x = 0
                y = 0
                c = 0
                While j > 1
                    x = x + CInt(CNPJ.Substring(y, 1)) * j
                    y = y + 1
                    j = j - 1
                    If j = 1 And c = 0 Then
                        j = 9
                        c = 1
                    End If
                End While
                z = x Mod 11
                If z = 0 Or z = 1 Then
                    a = 0
                Else
                    a = 11 - z
                End If
                If (CNPJ.Substring(13, 1) <> a) Then
                    Return False
                Else
                    Return True
                End If
            End If
        End If
    End Function

End Class
