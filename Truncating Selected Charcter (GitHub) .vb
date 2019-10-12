Module Module1

    Sub Main()
        Dim Str1, newString, nextChar, remChar As String
        Dim Count As Integer

        Str1 = ""
        newString = ""
        nextChar = ""
        remChar = ""
        Count = 0

        Console.Write("Enter string: ")
        Str1 = Console.ReadLine

        Console.Write("Enter the character that has to be removed: ")
        remChar = Console.ReadLine

        For Count = 1 To Len(Str1)
            nextChar = Mid(Str1, Count, 1)
            If nextChar <> remChar Then
                newString = newString & nextChar
            End If
        Next

        Console.WriteLine(newString)
        Console.ReadKey()
    End Sub

End Module
