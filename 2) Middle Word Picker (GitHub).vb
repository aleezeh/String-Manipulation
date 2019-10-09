Module Module1

    Sub Main()
        Dim Str1, myWord, finalWord As String
        Dim spacePos1, spacePos2 As Integer

        Str1 = ""
        myWord = ""
        finalWord = ""
        spacePos1 = 0
        spacePos2 = 0

        Console.Write("Enter string of three words: ")
        Str1 = Console.ReadLine

        spacePos1 = InStr(Str1, " ")
        myWord = Mid(Str1, spacePos1 + 1, Len(Str1))

        spacePos2 = InStr(myWord, " ")

        finalWord = Mid(myWord, 1, spacePos2 - 1)


        Console.Write(finalWord)
        Console.ReadKey()






    End Sub

End Module
