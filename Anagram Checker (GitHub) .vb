Module Module1

    Sub Main()
        Dim Str1, Str2, nextChar As String
        Dim Count As Integer
        Dim IsAnagram As Boolean

        Str1 = ""
        Str2 = ""
        nextChar = ""
        Count = 0
        IsAnagram = True

        Console.Write("Enter string one: ")
        Str1 = Console.ReadLine

        Console.Write("Enter string two: ")
        Str2 = Console.ReadLine

        If Len(Str1) <> Len(Str2) Then
            IsAnagram = False
            Console.WriteLine("It is not an Anagram.")
            Console.ReadKey()
        Else
            For Count = 1 To Len(Str1)
                nextChar = Mid(Str1, Count, 1)
                If InStr(Str2, nextChar) = 0 Then
                    IsAnagram = False
                End If
            Next
        End If

        If IsAnagram = False Then
            Console.WriteLine("It is not an Anagram.")
        Else
            Console.WriteLine("It is an Anagram.")
        End If

        Console.ReadKey()

    End Sub

End Module
