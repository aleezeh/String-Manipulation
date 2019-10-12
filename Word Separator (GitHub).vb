Module Module1

    Sub Main()
        Dim Str1, Str2, nextChar As String
        Dim Count As Integer

        Str1 = ""
        Str2 = ""
        nextChar = ""
        Count = 0

        Console.Write("Enter string: ")
        Str1 = Console.ReadLine

        For Count = 1 To Len(Str1)
            nextChar = Mid(Str1, Count, 1)
            If nextChar <> " " Then
                Str2 = Str2 & nextChar
            Else
                Console.WriteLine(Str2)
                Str2 = ""
            End If
        Next

        Console.WriteLine(Str2)
        Console.ReadKey()
    End Sub

End Module
