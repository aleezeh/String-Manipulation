Module Module1

    Sub Main()
        Dim Str1, Letters, Digits, Extras, Spaces, nextChar As String
        Dim Count As Integer

        Str1 = ""
        Letters = ""
        Digits = ""
        Extras = ""
        Spaces = ""
        nextChar = ""
        Count = 0

        Console.Write("Enter string: ")
        Str1 = Console.ReadLine

        For Count = 1 To Len(Str1)
            nextChar = Mid(Str1, Count, 1)
            If LCase(nextChar) >= "a" And LCase(nextChar) <= "z" Then
                Letters = Letters & nextChar
            ElseIf nextChar >= "0" And nextChar <= "9" Then
                Digits = Digits & nextChar
            ElseIf nextChar = " " Then
                Spaces = Spaces & nextChar
            Else
                Extras = Extras & nextChar
            End If
        Next

        Console.WriteLine("Alphabets: " & Letters)
        Console.WriteLine("Numbers: " & Digits)
        Console.WriteLine("Special Characters: " & Extras)
        Console.ReadKey()


    End Sub

End Module
