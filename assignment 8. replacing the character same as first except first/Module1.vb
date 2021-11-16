Module Module1

    Sub Main()
        Dim str1, str2 As String
        Dim thisChar, nextChar As Char
        Dim x As Integer
        str2 = ""
        x = 0
        thisChar = ""
        nextChar = ""
        str1 = ""
        Console.Write("Iput string to process: ")
        str1 = Console.ReadLine()
            thisChar = Mid(str1, 1, 1)
        For x = 2 To Len(str1)
            nextChar = Mid(str1, x, 1)
            If nextChar = thisChar Then
                nextChar = "*"
            Else : nextChar = Mid(str1, x, 1)
            End If
            str2 = str2 & nextChar

        Next
        str2 = thisChar & str2
        Console.WriteLine("proccessed string: " & str2)
        Console.ReadKey()
    End Sub

End Module
