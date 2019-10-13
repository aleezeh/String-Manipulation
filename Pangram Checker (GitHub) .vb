Module Module1

    Sub Main()
        Dim Str1, alphaString, nextChar As String
        Dim Count As Integer
        Dim IsPangram As Boolean

        Str1 = ""
        nextChar = ""
        alphaString = "abcdefghijklmnopqrstuvwxyz"
        IsPangram = True
        Count = 0

        Console.Write("Enter string: ")
        Str1 = Console.ReadLine

        For Count = 1 To Len(alphaString)
            nextChar = Mid(alphaString, Count, 1)
            If LCase(InStr(Str1, nextChar)) = 0 Then
                IsPangram = False
            End If
        Next

        If IsPangram = False Then
            Console.WriteLine("It is not a Pangram.")
        Else
            Console.WriteLine("It is a Pangram.")
        End If

        Console.ReadKey()




    End Sub

End Module
