Module Module1

    Sub Main()
        Dim Str1, newString, nextChar As String
        Dim Count As Integer

        Str1 = ""
        newString = ""
        nextChar = ""
        Count = 0

        Console.Write("Enter string to inverse: ")
        Str1 = Console.ReadLine

        For Count = Len(Str1) To 1 Step -1
            nextChar = Mid(Str1, Count, 1)
            newString = newString & nextChar
        Next

        Console.WriteLine(newString)
        Console.ReadKey()

    End Sub

End Module
