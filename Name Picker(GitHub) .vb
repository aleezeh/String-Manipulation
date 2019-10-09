Module Module1

    Sub Main()
        Dim Str1, Str2, myString, firstName, lastName As String
        Dim spacePos1, spacePos2 As Integer

        Str1 = ""
        Str2 = ""
        myString = ""
        firstName = ""
        lastName = ""
        spacePos1 = 0
        spacePos2 = 0

        Console.Write("Enter first string: ")
        Str1 = Console.ReadLine

        Console.Write("Enter second string: ")
        Str2 = Console.ReadLine

        spacePos1 = InStr(Str1, " ")
        firstName = Mid(Str1, 1, spacePos1 - 1)

        spacePos2 = InStr(Str2, " ")
        lastName = Mid(Str2, spacePos2 + 1, Len(Str2))

        myString = firstName & " " & lastName

        Console.WriteLine(myString)
        Console.ReadKey()

    End Sub

End Module
