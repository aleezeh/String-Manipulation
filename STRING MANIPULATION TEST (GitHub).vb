Module Module1

    Sub Main()
        Dim STR1, nextChar As String
        Dim Count, nextNo, denaryNo As Integer
        Dim validBinaryString As Boolean

        STR1 = ""
        nextChar = ""
        Count = 0
        validBinaryString = True
        nextNo = 0
        denaryNo = 0

        Console.Write("Enter Binary Number: ")
        STR1 = Console.ReadLine

        If Len(STR1) < 1 Or Len(STR1) > 8 Then
            validBinaryString = False
        End If

        If validBinaryString = True Then
            For Count = 1 To Len(STR1)
                nextChar = Mid(STR1, Count, 1)
                If nextChar <> "1" And nextChar <> "0" Then
                    validBinaryString = False
                End If
            Next
        End If

        If validBinaryString = True Then
            Console.WriteLine("It is a valid binary number.")
            For Count = Len(STR1) To 1 Step -1
                nextNo = Val(Mid(STR1, Count, 1))
                denaryNo = denaryNo + nextNo * 2 ^ (Len(STR1) - Count)
            Next
            Console.WriteLine(STR1 & "= " & denaryNo)
        Else
            Console.WriteLine("It is not a valid binary number...")
        End If
        Console.ReadKey()
    End Sub

End Module
